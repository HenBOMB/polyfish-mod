#region Assembly GameLogicAssembly, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// /mnt/hen480/SteamLibrary/steamapps/common/The Battle of Polytopia/BepInEx/interop/GameLogicAssembly.dll
// Decompiled with ICSharpCode.Decompiler 
#endregion

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Polytopia.Data;
using PolytopiaBackendBase.Common;

public class UnitState : Il2CppSystem.Object
{
    private static readonly System.IntPtr NativeFieldInfoPtr_id;

    private static readonly System.IntPtr NativeFieldInfoPtr_leader;

    private static readonly System.IntPtr NativeFieldInfoPtr_follower;

    private static readonly System.IntPtr NativeFieldInfoPtr_owner;

    private static readonly System.IntPtr NativeFieldInfoPtr_birthClimate;

    private static readonly System.IntPtr NativeFieldInfoPtr_birthClimateSkinType;

    private static readonly System.IntPtr NativeFieldInfoPtr_type;

    private static readonly System.IntPtr NativeFieldInfoPtr_previousTurnEndCoordinates;

    private static readonly System.IntPtr NativeFieldInfoPtr_coordinates;

    private static readonly System.IntPtr NativeFieldInfoPtr_home;

    private static readonly System.IntPtr NativeFieldInfoPtr_passengerUnit;

    private static readonly System.IntPtr NativeFieldInfoPtr_health;

    private static readonly System.IntPtr NativeFieldInfoPtr_promotionLevel;

    private static readonly System.IntPtr NativeFieldInfoPtr_xp;

    private static readonly System.IntPtr NativeFieldInfoPtr_moved;

    private static readonly System.IntPtr NativeFieldInfoPtr_attacked;

    private static readonly System.IntPtr NativeFieldInfoPtr_direction;

    private static readonly System.IntPtr NativeFieldInfoPtr_flipped;

    private static readonly System.IntPtr NativeFieldInfoPtr_createdTurn;

    private static readonly System.IntPtr NativeFieldInfoPtr_UnitData;

    private static readonly System.IntPtr NativeFieldInfoPtr_effects;

    private static readonly System.IntPtr NativeFieldInfoPtr_isTemporaryExplorerUnit;

    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_UnitState_GameState_Byte_UInt32_UnitData_WorldCoordinates_WorldCoordinates_0;

    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_UnitState_Byte_UnitData_WorldCoordinates_WorldCoordinates_UInt32_Int32_Int32_0;

    private static readonly System.IntPtr NativeMethodInfoPtr_cloneState_Public_Void_UnitState_0;

    private static readonly System.IntPtr NativeMethodInfoPtr_HasEffect_Public_Boolean_UnitEffect_0;

    private static readonly System.IntPtr NativeMethodInfoPtr_AddEffect_Public_Void_UnitEffect_0;

    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveEffect_Public_Void_UnitEffect_0;

    private static readonly System.IntPtr NativeMethodInfoPtr_MakeExhauseted_Public_Void_GameState_0;

    private static readonly System.IntPtr NativeMethodInfoPtr_MakeExhausetedV115_Public_Void_GameState_0;

    private static readonly System.IntPtr NativeMethodInfoPtr_DisableFollowers_Public_Void_GameState_0;

    private static readonly System.IntPtr NativeMethodInfoPtr_CanAttack_Public_Boolean_0;

    private static readonly System.IntPtr NativeMethodInfoPtr_CanMove_Public_Boolean_0;

    private static readonly System.IntPtr NativeMethodInfoPtr_IsFreezable_Public_Boolean_GameState_PlayerState_0;

    private static readonly System.IntPtr NativeMethodInfoPtr_IsInvisible_Public_Boolean_GameState_Byte_0;

    private static readonly System.IntPtr NativeMethodInfoPtr_IsInvisible_Public_Boolean_PlayerState_0;

    private static readonly System.IntPtr NativeMethodInfoPtr_HasActivePeaceTreaty_Public_Boolean_GameState_PlayerState_0;

    private static readonly System.IntPtr NativeMethodInfoPtr_HasFollower_Public_Boolean_0;

    private static readonly System.IntPtr NativeMethodInfoPtr_HasLeader_Public_Boolean_0;

    private static readonly System.IntPtr NativeMethodInfoPtr_FollowerDirection_Public_GridDirection_GameState_0;

    private static readonly System.IntPtr NativeMethodInfoPtr_LeaderDirection_Public_GridDirection_GameState_0;

    private static readonly System.IntPtr NativeMethodInfoPtr_IsDetectingHiddenUnits_Public_Boolean_GameState_0;

    private static readonly System.IntPtr NativeMethodInfoPtr_GetFullCost_Public_Int32_GameState_0;

    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_Int32_0;

    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeDefault_Public_Void_BinaryWriter_Int32_0;

    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_Int32_0;

    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeDefault_Public_Void_BinaryReader_Int32_0;

    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe uint id
    {
        get
        {
            nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
            return *(uint*)num;
        }
        set
        {
            *(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
        }
    }

    public unsafe uint leader
    {
        get
        {
            nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leader);
            return *(uint*)num;
        }
        set
        {
            *(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leader)) = num;
        }
    }

    public unsafe uint follower
    {
        get
        {
            nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_follower);
            return *(uint*)num;
        }
        set
        {
            *(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_follower)) = num;
        }
    }

    public unsafe byte owner
    {
        get
        {
            nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_owner);
            return *(byte*)num;
        }
        set
        {
            *(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_owner)) = b;
        }
    }

    public unsafe TribeType birthClimate
    {
        get
        {
            nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_birthClimate);
            return *(TribeType*)num;
        }
        set
        {
            *(TribeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_birthClimate)) = tribeType;
        }
    }

    public unsafe SkinType birthClimateSkinType
    {
        get
        {
            nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_birthClimateSkinType);
            return *(SkinType*)num;
        }
        set
        {
            *(SkinType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_birthClimateSkinType)) = skinType;
        }
    }

    public unsafe UnitData.Type type
    {
        get
        {
            nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
            return *(UnitData.Type*)num;
        }
        set
        {
            *(UnitData.Type*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = type;
        }
    }

    public unsafe WorldCoordinates previousTurnEndCoordinates
    {
        get
        {
            nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousTurnEndCoordinates);
            return *(WorldCoordinates*)num;
        }
        set
        {
            *(WorldCoordinates*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousTurnEndCoordinates)) = worldCoordinates;
        }
    }

    public unsafe WorldCoordinates coordinates
    {
        get
        {
            nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coordinates);
            return *(WorldCoordinates*)num;
        }
        set
        {
            *(WorldCoordinates*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coordinates)) = worldCoordinates;
        }
    }

    public unsafe WorldCoordinates home
    {
        get
        {
            nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_home);
            return *(WorldCoordinates*)num;
        }
        set
        {
            *(WorldCoordinates*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_home)) = worldCoordinates;
        }
    }

    public unsafe UnitState passengerUnit
    {
        get
        {
            nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passengerUnit);
            System.IntPtr intPtr = *(System.IntPtr*)num;
            return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnitState>(intPtr) : null;
        }
        set
        {
            System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passengerUnit), IL2CPP.Il2CppObjectBaseToPtr(obj));
        }
    }

    public unsafe ushort health
    {
        get
        {
            nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_health);
            return *(ushort*)num;
        }
        set
        {
            *(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_health)) = num;
        }
    }

    public unsafe ushort promotionLevel
    {
        get
        {
            nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_promotionLevel);
            return *(ushort*)num;
        }
        set
        {
            *(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_promotionLevel)) = num;
        }
    }

    public unsafe ushort xp
    {
        get
        {
            nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xp);
            return *(ushort*)num;
        }
        set
        {
            *(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xp)) = num;
        }
    }

    public unsafe bool moved
    {
        get
        {
            nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moved);
            return *(bool*)num;
        }
        set
        {
            *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moved)) = flag;
        }
    }

    public unsafe bool attacked
    {
        get
        {
            nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attacked);
            return *(bool*)num;
        }
        set
        {
            *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attacked)) = flag;
        }
    }

    public unsafe GridDirection direction
    {
        get
        {
            nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_direction);
            return *(GridDirection*)num;
        }
        set
        {
            *(GridDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_direction)) = gridDirection;
        }
    }

    public unsafe bool flipped
    {
        get
        {
            nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flipped);
            return *(bool*)num;
        }
        set
        {
            *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flipped)) = flag;
        }
    }

    public unsafe ushort createdTurn
    {
        get
        {
            nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createdTurn);
            return *(ushort*)num;
        }
        set
        {
            *(ushort*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createdTurn)) = num;
        }
    }

    public unsafe UnitData UnitData
    {
        get
        {
            nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UnitData);
            System.IntPtr intPtr = *(System.IntPtr*)num;
            return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnitData>(intPtr) : null;
        }
        set
        {
            System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UnitData), IL2CPP.Il2CppObjectBaseToPtr(obj));
        }
    }

    public unsafe List<UnitEffect> effects
    {
        get
        {
            nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effects);
            System.IntPtr intPtr = *(System.IntPtr*)num;
            return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<UnitEffect>>(intPtr) : null;
        }
        set
        {
            System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
            IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effects), IL2CPP.Il2CppObjectBaseToPtr(obj));
        }
    }

    public unsafe bool isTemporaryExplorerUnit
    {
        get
        {
            nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTemporaryExplorerUnit);
            return *(bool*)num;
        }
        set
        {
            *(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTemporaryExplorerUnit)) = flag;
        }
    }

    static UnitState()
    {
        Il2CppClassPointerStore<UnitState>.NativeClassPtr = IL2CPP.GetIl2CppClass("GameLogicAssembly.dll", "", "UnitState");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitState>.NativeClassPtr);
        NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitState>.NativeClassPtr, "id");
        NativeFieldInfoPtr_leader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitState>.NativeClassPtr, "leader");
        NativeFieldInfoPtr_follower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitState>.NativeClassPtr, "follower");
        NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitState>.NativeClassPtr, "owner");
        NativeFieldInfoPtr_birthClimate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitState>.NativeClassPtr, "birthClimate");
        NativeFieldInfoPtr_birthClimateSkinType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitState>.NativeClassPtr, "birthClimateSkinType");
        NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitState>.NativeClassPtr, "type");
        NativeFieldInfoPtr_previousTurnEndCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitState>.NativeClassPtr, "previousTurnEndCoordinates");
        NativeFieldInfoPtr_coordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitState>.NativeClassPtr, "coordinates");
        NativeFieldInfoPtr_home = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitState>.NativeClassPtr, "home");
        NativeFieldInfoPtr_passengerUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitState>.NativeClassPtr, "passengerUnit");
        NativeFieldInfoPtr_health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitState>.NativeClassPtr, "health");
        NativeFieldInfoPtr_promotionLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitState>.NativeClassPtr, "promotionLevel");
        NativeFieldInfoPtr_xp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitState>.NativeClassPtr, "xp");
        NativeFieldInfoPtr_moved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitState>.NativeClassPtr, "moved");
        NativeFieldInfoPtr_attacked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitState>.NativeClassPtr, "attacked");
        NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitState>.NativeClassPtr, "direction");
        NativeFieldInfoPtr_flipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitState>.NativeClassPtr, "flipped");
        NativeFieldInfoPtr_createdTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitState>.NativeClassPtr, "createdTurn");
        NativeFieldInfoPtr_UnitData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitState>.NativeClassPtr, "UnitData");
        NativeFieldInfoPtr_effects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitState>.NativeClassPtr, "effects");
        NativeFieldInfoPtr_isTemporaryExplorerUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitState>.NativeClassPtr, "isTemporaryExplorerUnit");
        NativeMethodInfoPtr_Create_Public_Static_UnitState_GameState_Byte_UInt32_UnitData_WorldCoordinates_WorldCoordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665380);
        NativeMethodInfoPtr_Create_Public_Static_UnitState_Byte_UnitData_WorldCoordinates_WorldCoordinates_UInt32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665381);
        NativeMethodInfoPtr_cloneState_Public_Void_UnitState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665382);
        NativeMethodInfoPtr_HasEffect_Public_Boolean_UnitEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665383);
        NativeMethodInfoPtr_AddEffect_Public_Void_UnitEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665384);
        NativeMethodInfoPtr_RemoveEffect_Public_Void_UnitEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665385);
        NativeMethodInfoPtr_MakeExhauseted_Public_Void_GameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665386);
        NativeMethodInfoPtr_MakeExhausetedV115_Public_Void_GameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665387);
        NativeMethodInfoPtr_DisableFollowers_Public_Void_GameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665388);
        NativeMethodInfoPtr_CanAttack_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665389);
        NativeMethodInfoPtr_CanMove_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665390);
        NativeMethodInfoPtr_IsFreezable_Public_Boolean_GameState_PlayerState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665391);
        NativeMethodInfoPtr_IsInvisible_Public_Boolean_GameState_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665392);
        NativeMethodInfoPtr_IsInvisible_Public_Boolean_PlayerState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665393);
        NativeMethodInfoPtr_HasActivePeaceTreaty_Public_Boolean_GameState_PlayerState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665394);
        NativeMethodInfoPtr_HasFollower_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665395);
        NativeMethodInfoPtr_HasLeader_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665396);
        NativeMethodInfoPtr_FollowerDirection_Public_GridDirection_GameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665397);
        NativeMethodInfoPtr_LeaderDirection_Public_GridDirection_GameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665398);
        NativeMethodInfoPtr_IsDetectingHiddenUnits_Public_Boolean_GameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665399);
        NativeMethodInfoPtr_GetFullCost_Public_Int32_GameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665400);
        NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665401);
        NativeMethodInfoPtr_SerializeDefault_Public_Void_BinaryWriter_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665402);
        NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665403);
        NativeMethodInfoPtr_DeserializeDefault_Public_Void_BinaryReader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665404);
        NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665405);
        NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitState>.NativeClassPtr, 100665406);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 670173, RefRangeEnd = 670181, XrefRangeStart = 670157, XrefRangeEnd = 670173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe static UnitState Create(GameState gameState, byte playerId, uint currentTurn, UnitData unitData, WorldCoordinates coordinates, WorldCoordinates home)
    {
        System.IntPtr* ptr = stackalloc System.IntPtr[6];
        *ptr = IL2CPP.Il2CppObjectBaseToPtr(gameState);
        *(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playerId;
        *(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &currentTurn;
        *(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(unitData);
        *(WorldCoordinates**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
        *(WorldCoordinates**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &home;
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_UnitState_GameState_Byte_UInt32_UnitData_WorldCoordinates_WorldCoordinates_0, (System.IntPtr)0, (void**)ptr, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnitState>(intPtr) : null;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 670181, XrefRangeEnd = 670197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe static UnitState Create(byte playerId, UnitData unitData, WorldCoordinates coordinates, WorldCoordinates home, uint currentTurn, int mapWidth, int mapHeight)
    {
        System.IntPtr* ptr = stackalloc System.IntPtr[7];
        *ptr = (nint)(&playerId);
        *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(unitData);
        *(WorldCoordinates**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
        *(WorldCoordinates**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &home;
        *(uint**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &currentTurn;
        *(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &mapWidth;
        *(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &mapHeight;
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_UnitState_Byte_UnitData_WorldCoordinates_WorldCoordinates_UInt32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnitState>(intPtr) : null;
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 670197, RefRangeEnd = 670198, XrefRangeStart = 670197, XrefRangeEnd = 670197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe void cloneState(UnitState originalUnit)
    {
        IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
        System.IntPtr* ptr = stackalloc System.IntPtr[1];
        *ptr = IL2CPP.Il2CppObjectBaseToPtr(originalUnit);
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_cloneState_Public_Void_UnitState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(65)]
    [CachedScanResults(RefRangeStart = 670202, RefRangeEnd = 670267, XrefRangeStart = 670198, XrefRangeEnd = 670202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe bool HasEffect(UnitEffect effect)
    {
        IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
        System.IntPtr* ptr = stackalloc System.IntPtr[1];
        *ptr = (nint)(&effect);
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasEffect_Public_Boolean_UnitEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
    }

    [CallerCount(18)]
    [CachedScanResults(RefRangeStart = 670273, RefRangeEnd = 670291, XrefRangeStart = 670267, XrefRangeEnd = 670273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe void AddEffect(UnitEffect effect)
    {
        IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
        System.IntPtr* ptr = stackalloc System.IntPtr[1];
        *ptr = (nint)(&effect);
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddEffect_Public_Void_UnitEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(26)]
    [CachedScanResults(RefRangeStart = 670295, RefRangeEnd = 670321, XrefRangeStart = 670291, XrefRangeEnd = 670295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe void RemoveEffect(UnitEffect effect)
    {
        IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
        System.IntPtr* ptr = stackalloc System.IntPtr[1];
        *ptr = (nint)(&effect);
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveEffect_Public_Void_UnitEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 670329, RefRangeEnd = 670333, XrefRangeStart = 670321, XrefRangeEnd = 670329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe void MakeExhauseted(GameState gameState)
    {
        IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
        System.IntPtr* ptr = stackalloc System.IntPtr[1];
        *ptr = IL2CPP.Il2CppObjectBaseToPtr(gameState);
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeExhauseted_Public_Void_GameState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 670333, XrefRangeEnd = 670345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe void MakeExhausetedV115(GameState gameState)
    {
        IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
        System.IntPtr* ptr = stackalloc System.IntPtr[1];
        *ptr = IL2CPP.Il2CppObjectBaseToPtr(gameState);
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeExhausetedV115_Public_Void_GameState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 670347, RefRangeEnd = 670352, XrefRangeStart = 670345, XrefRangeEnd = 670347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe void DisableFollowers(GameState state)
    {
        IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
        System.IntPtr* ptr = stackalloc System.IntPtr[1];
        *ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableFollowers_Public_Void_GameState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(21)]
    [CachedScanResults(RefRangeStart = 670356, RefRangeEnd = 670377, XrefRangeStart = 670352, XrefRangeEnd = 670356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe bool CanAttack()
    {
        IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
        System.IntPtr* param = null;
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanAttack_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
    }

    [CallerCount(17)]
    [CachedScanResults(RefRangeStart = 670377, RefRangeEnd = 670394, XrefRangeStart = 670377, XrefRangeEnd = 670377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe bool CanMove()
    {
        IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
        System.IntPtr* param = null;
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanMove_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 670401, RefRangeEnd = 670403, XrefRangeStart = 670394, XrefRangeEnd = 670401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe bool IsFreezable(GameState state, PlayerState player)
    {
        IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
        System.IntPtr* ptr = stackalloc System.IntPtr[2];
        *ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
        *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(player);
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsFreezable_Public_Boolean_GameState_PlayerState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
    }

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 670408, RefRangeEnd = 670424, XrefRangeStart = 670403, XrefRangeEnd = 670408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe bool IsInvisible(GameState gameState, byte playerId)
    {
        IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
        System.IntPtr* ptr = stackalloc System.IntPtr[2];
        *ptr = IL2CPP.Il2CppObjectBaseToPtr(gameState);
        *(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playerId;
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsInvisible_Public_Boolean_GameState_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 670428, RefRangeEnd = 670431, XrefRangeStart = 670424, XrefRangeEnd = 670428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe bool IsInvisible(PlayerState viewer)
    {
        IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
        System.IntPtr* ptr = stackalloc System.IntPtr[1];
        *ptr = IL2CPP.Il2CppObjectBaseToPtr(viewer);
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsInvisible_Public_Boolean_PlayerState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
    }

    [CallerCount(18)]
    [CachedScanResults(RefRangeStart = 670433, RefRangeEnd = 670451, XrefRangeStart = 670431, XrefRangeEnd = 670433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe bool HasActivePeaceTreaty(GameState state, PlayerState player)
    {
        IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
        System.IntPtr* ptr = stackalloc System.IntPtr[2];
        *ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
        *(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(player);
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasActivePeaceTreaty_Public_Boolean_GameState_PlayerState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
    }

    [CallerCount(28)]
    [CachedScanResults(RefRangeStart = 670451, RefRangeEnd = 670479, XrefRangeStart = 670451, XrefRangeEnd = 670451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe bool HasFollower()
    {
        IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
        System.IntPtr* param = null;
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasFollower_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
    }

    [CallerCount(29)]
    [CachedScanResults(RefRangeStart = 670479, RefRangeEnd = 670508, XrefRangeStart = 670479, XrefRangeEnd = 670479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe bool HasLeader()
    {
        IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
        System.IntPtr* param = null;
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasLeader_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 670520, RefRangeEnd = 670522, XrefRangeStart = 670508, XrefRangeEnd = 670520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe GridDirection FollowerDirection(GameState state)
    {
        IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
        System.IntPtr* ptr = stackalloc System.IntPtr[1];
        *ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FollowerDirection_Public_GridDirection_GameState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(GridDirection*)IL2CPP.il2cpp_object_unbox(obj);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 670534, RefRangeEnd = 670536, XrefRangeStart = 670522, XrefRangeEnd = 670534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe GridDirection LeaderDirection(GameState state)
    {
        IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
        System.IntPtr* ptr = stackalloc System.IntPtr[1];
        *ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LeaderDirection_Public_GridDirection_GameState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(GridDirection*)IL2CPP.il2cpp_object_unbox(obj);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 670543, RefRangeEnd = 670544, XrefRangeStart = 670536, XrefRangeEnd = 670543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe bool IsDetectingHiddenUnits(GameState gameState)
    {
        IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
        System.IntPtr* ptr = stackalloc System.IntPtr[1];
        *ptr = IL2CPP.Il2CppObjectBaseToPtr(gameState);
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDetectingHiddenUnits_Public_Boolean_GameState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 670548, RefRangeEnd = 670551, XrefRangeStart = 670544, XrefRangeEnd = 670548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe int GetFullCost(GameState gameState)
    {
        IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
        System.IntPtr* ptr = stackalloc System.IntPtr[1];
        *ptr = IL2CPP.Il2CppObjectBaseToPtr(gameState);
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFullCost_Public_Int32_GameState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*)IL2CPP.il2cpp_object_unbox(obj);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 670552, RefRangeEnd = 670553, XrefRangeStart = 670551, XrefRangeEnd = 670552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe void Serialize(BinaryWriter writer, int version)
    {
        IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
        System.IntPtr* ptr = stackalloc System.IntPtr[2];
        *ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
        *(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &version;
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_Void_BinaryWriter_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 670570, RefRangeEnd = 670572, XrefRangeStart = 670553, XrefRangeEnd = 670570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe void SerializeDefault(BinaryWriter writer, int version)
    {
        IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
        System.IntPtr* ptr = stackalloc System.IntPtr[2];
        *ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
        *(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &version;
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeDefault_Public_Void_BinaryWriter_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 670573, RefRangeEnd = 670574, XrefRangeStart = 670572, XrefRangeEnd = 670573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe void Deserialize(BinaryReader reader, int version)
    {
        IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
        System.IntPtr* ptr = stackalloc System.IntPtr[2];
        *ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
        *(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &version;
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Public_Void_BinaryReader_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 670628, RefRangeEnd = 670630, XrefRangeStart = 670574, XrefRangeEnd = 670628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe void DeserializeDefault(BinaryReader reader, int version)
    {
        IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
        System.IntPtr* ptr = stackalloc System.IntPtr[2];
        *ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
        *(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &version;
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeserializeDefault_Public_Void_BinaryReader_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 670630, XrefRangeEnd = 670650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe override string ToString()
    {
        IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
        System.IntPtr* param = null;
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 670657, RefRangeEnd = 670665, XrefRangeStart = 670650, XrefRangeEnd = 670657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
    public unsafe UnitState()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitState>.NativeClassPtr))
    {
        System.IntPtr* param = null;
        Unsafe.SkipInit(out System.IntPtr exc);
        System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
        Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public UnitState(System.IntPtr pointer)
        : base(pointer)
    {
    }
}
#if false // Decompilation log
'178' items in cache
------------------
Resolve: 'Il2Cppmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'Il2Cppmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: '/mnt/hen480/SteamLibrary/steamapps/common/The Battle of Polytopia/BepInEx/interop/Il2Cppmscorlib.dll'
------------------
Resolve: 'Il2CppInterop.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'Il2CppInterop.Runtime, Version=1.5.1.0, Culture=neutral, PublicKeyToken=null'
WARN: Version mismatch. Expected: '0.0.0.0', Got: '1.5.1.0'
Load from: '/mnt/hen480/SteamLibrary/steamapps/common/The Battle of Polytopia/BepInEx/core/Il2CppInterop.Runtime.dll'
------------------
Resolve: 'PolytopiaBackendBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'PolytopiaBackendBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: '/mnt/hen480/SteamLibrary/steamapps/common/The Battle of Polytopia/BepInEx/interop/PolytopiaBackendBase.dll'
------------------
Resolve: 'Il2CppSystem.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null'
Could not find by name: 'Il2CppSystem.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null'
------------------
Resolve: 'Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: '/mnt/hen480/SteamLibrary/steamapps/common/The Battle of Polytopia/BepInEx/interop/Newtonsoft.Json.dll'
------------------
Resolve: 'System.Runtime, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Found single assembly: 'System.Runtime, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: '/home/henry/.nuget/packages/microsoft.netcore.app.ref/6.0.36/ref/net6.0/System.Runtime.dll'
------------------
Resolve: 'Il2CppInterop.Common, Version=1.5.1.0, Culture=neutral, PublicKeyToken=null'
Could not find by name: 'Il2CppInterop.Common, Version=1.5.1.0, Culture=neutral, PublicKeyToken=null'
------------------
Resolve: 'System.Runtime.InteropServices, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'System.Runtime.InteropServices, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: '/home/henry/.nuget/packages/microsoft.netcore.app.ref/6.0.36/ref/net6.0/System.Runtime.InteropServices.dll'
------------------
Resolve: 'System.Runtime.CompilerServices.Unsafe, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'System.Runtime.CompilerServices.Unsafe, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Load from: '/home/henry/.nuget/packages/microsoft.netcore.app.ref/6.0.36/ref/net6.0/System.Runtime.CompilerServices.Unsafe.dll'
#endif
