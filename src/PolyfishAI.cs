using PolyMod.Api;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

namespace PolyfishAI.src
{
    public class PolyfishPlugin : PolyScript
    {
        public static PolyfishAPI API { get; private set; } = null!;
        public static new ManualLogSource Logger { get; private set; } = null!;
        public static string LastExitButtonPath { get; set; } = "Canvas/HUDScreen/ButtonBar/NextTurnButton";

        private static readonly System.Collections.Concurrent.ConcurrentQueue<Action> _mainThreadQueue = new();

        public override void Load()
        {
            Logger = base.Logger;
            base.Logger.LogInfo("PolyfishAI initialized!");

            // Initialize the bridge to talk to the Rust server (PolyAI)
            API = new PolyfishAPI("http://localhost:3000", base.Logger);

            // Create and apply our Harmony patches
            Harmony.CreateAndPatchAll(typeof(GameHooks));
            Harmony.CreateAndPatchAll(typeof(UILogger));
            Harmony.CreateAndPatchAll(typeof(PolyfishPlugin));

            base.Logger.LogInfo("Applied Harmony hooks for PolyfishAI.");
        }

        public static void RunOnMainThread(Action action)
        {
            _mainThreadQueue.Enqueue(action);
        }

        public static string GetGameObjectPath(GameObject obj)
        {
            string path = obj.name;
            Transform parent = obj.transform.parent;
            while (parent != null)
            {
                path = parent.name + "/" + path;
                parent = parent.parent;
            }
            return path;
        }

        public static UIButtonBase? FindButtonByPath(string path)
        {
            foreach (var btn in UnityEngine.Object.FindObjectsOfType<UIButtonBase>())
            {
                if (GetGameObjectPath(btn.gameObject) == path)
                    return btn;
            }
            return null;
        }

        [HarmonyPatch(typeof(GameManager), "Update")]
        [HarmonyPostfix]
        public static void OnGameManagerUpdate()
        {
            while (_mainThreadQueue.TryDequeue(out var action))
            {
                try
                {
                    action.Invoke();
                }
                catch (Exception ex)
                {
                    Logger.LogError("Error in MainThreadAction: " + ex);
                }
            }
        }

        public override void Unload()
        {
            base.Logger.LogInfo("PolyfishAI shutting down...");
        }
    }

    /// <summary>
    /// Helper to identify buttons being clicked on screen since UnityExplorer is currently broken.
    /// </summary>
    [HarmonyPatch]
    public class UILogger
    {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(UIButtonBase), "OnPointerClick")]
        public static void OnButtonClicked(UIButtonBase __instance)
        {
            try
            {
                string path = PolyfishPlugin.GetGameObjectPath(__instance.gameObject);
                string text = __instance.GetComponentInChildren<TextMeshProUGUI>()?.text ?? "N/A";
                PolyfishPlugin.Logger.LogInfo($"[UI Click] Path: {path} | Logic: {__instance.GetType().Name} | Text: {text}");

                if (text.Equals("Exit", StringComparison.OrdinalIgnoreCase) || text.Equals("QUIT", StringComparison.OrdinalIgnoreCase))
                {
                    PolyfishPlugin.LastExitButtonPath = path;
                    PolyfishPlugin.Logger.LogInfo("Saved last exit button path: " + path);
                }
            }
            catch (Exception ex)
            {
                PolyfishPlugin.Logger.LogWarning("UILogger failed: " + ex.Message);
            }
        }
    }

    [HarmonyPatch]
    public class GameHooks
    {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(LevelManager), "Start")]
        public static void OnStartGame()
        {
            // Replay detection
            // --> Extract replay and exit immediately
            ReplayInterface replayInterface = UnityEngine.Object.FindObjectOfType<ReplayInterface>();

            if (replayInterface != null)
            {
                PolyfishPlugin.Logger!.LogInfo("Replay detected, initiating auto-save in 3s...");

                Task.Run(async () =>
                {
                    try
                    {
                        // Wait for the timeline to be built
                        await Task.Delay(3000);

                        PolyfishPlugin.RunOnMainThread(() =>
                        {
                            PolyfishPlugin.Logger.LogInfo("Capturing replay data...");
                            PolyfishPlugin.API!.SaveReplaySync(replayInterface);
                        });

                        // Small extra delay for the HTTP request to start/ui to settle
                        await Task.Delay(1000);

                        PolyfishPlugin.RunOnMainThread(() =>
                        {
                            PolyfishPlugin.Logger.LogInfo($"Executing automated click on exit button: {PolyfishPlugin.LastExitButtonPath}");

                            var btn = PolyfishPlugin.FindButtonByPath(PolyfishPlugin.LastExitButtonPath);

                            if (btn != null && btn.gameObject.activeInHierarchy)
                            {
                                var eventData = new PointerEventData(EventSystem.current)
                                {
                                    button = PointerEventData.InputButton.Left
                                };

                                // Ensure the EventSystem sees this as the selected object
                                if (EventSystem.current != null)
                                {
                                    EventSystem.current.SetSelectedGameObject(btn.gameObject);
                                }

                                // Simulate the full click sequence (Down -> Up -> Click)
                                ExecuteEvents.Execute(btn.gameObject, eventData, ExecuteEvents.pointerDownHandler);
                                ExecuteEvents.Execute(btn.gameObject, eventData, ExecuteEvents.pointerUpHandler);
                                ExecuteEvents.Execute(btn.gameObject, eventData, ExecuteEvents.pointerClickHandler);
                                
                                // Also try Submit just in case
                                ExecuteEvents.Execute(btn.gameObject, eventData, ExecuteEvents.submitHandler);

                                PolyfishPlugin.Logger.LogInfo("Exit button click events dispatched successfully!");
                            }
                            else
                            {
                                PolyfishPlugin.Logger.LogWarning($"FAILED to find active exit button with path: {PolyfishPlugin.LastExitButtonPath}");
                            }
                        });
                    }
                    catch (Exception ex)
                    {
                        PolyfishPlugin.Logger.LogError("Critical error in async replay capture: " + ex.Message);
                    }
                });
            }
        }

        // [HarmonyPostfix]
        // [HarmonyPatch(typeof(GameManager), "LoadStartScene")]
        // public static void OnReturnToMenu()
        // {
        // }
    }
}
