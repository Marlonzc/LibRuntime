{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 HorseEntityId; // 0x10
	System.Int64 MaxFuel; // 0x18
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e20450
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e204f8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e20700
	static System.Void .cctor(); // 0x06e209c4
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SpawnVehicleNodeExecutor : WizardGames.Soc.Common.SimpleCustom.GraphNodeExecutorBase
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 VehicleEntityId; // 0x10
	System.Int64 CurFuel; // 0x18
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e20b58
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e20c00
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e20e08
	static System.Void .cctor(); // 0x06e210cc
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.StartStoryStageNodeExecutor : WizardGames.Soc.Common.SimpleCustom.GraphNodeExecutorBase
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 PreStage; // 0x10
	System.Int64 PostStage; // 0x18
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e21260
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e21308
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e21510
	static System.Void .cctor(); // 0x06e217d4
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SummarizedDamageRecord : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Single AttackDamage; // 0x10
	System.Collections.Generic.Dictionary<System.Int32,System.Single> AttackDamageByPart; // 0x18
	System.Int32 KillCount; // 0x20
	System.Int32 KnockdownCount; // 0x24
	System.String HitName; // 0x28
	System.UInt64 HitRoleId; // 0x30
	System.Int64 HitPlayerRoleId; // 0x38
	System.Int64 HitEntityId; // 0x40
	System.Int64 HitTableId; // 0x48
	System.Int32 HitEntityType; // 0x50
	System.Single SufferDamage; // 0x54
	System.Collections.Generic.Dictionary<System.Int32,System.Single> SufferDamageByPart; // 0x58
	System.Boolean IsKilledByThis; // 0x60
	System.Int32 WaysToDieID; // 0x64
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e21968
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e219fc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e21dd4
	static System.Void .cctor(); // 0x06e221a8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SwimSprayEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent, WizardGames.Soc.Common.Cache.ICacheObject
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 SwimEventType; // 0x38
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e225ac
	System.Int32 GetClassHash(); // 0x06e22658
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e226c0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e2290c
	System.Void .ctor(); // 0x06e22c08
	static WizardGames.Soc.Common.SimpleCustom.SwimSprayEvent NewEvent(); // 0x06e22c94
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06e22d0c
	System.Void Dispose(); // 0x06e22dbc
	static System.Void .cctor(); // 0x06e22e24
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SwitchEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 PreviousHeldItemBulletId; // 0x38
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e23020
	System.Int32 GetClassHash(); // 0x06e230d4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e2313c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e23364
	System.Void .ctor(); // 0x06e2363c
	static WizardGames.Soc.Common.SimpleCustom.SwitchEvent NewEvent(); // 0x06e236d0
	static WizardGames.Soc.Common.SimpleCustom.SwitchEvent NewEvent(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06e23748
	System.Void Dispose(); // 0x06e2384c
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06e238b4
	static System.Void .cctor(); // 0x06e23964
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.TeamRankInfo : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 TeamEntityId; // 0x10
	System.Int32 Score; // 0x18
	System.Int32 CupNum; // 0x1c
	System.String TeamName; // 0x20
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e23b2c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e23bc0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e23e18
	static System.Void .cctor(); // 0x06e24114
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.TeamSearchItemData : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.UInt64 RoleId; // 0x10
	System.String Name; // 0x18
	System.Int32 ServerLocation; // 0x20
	System.String HeadIcon; // 0x28
	System.Int32 GivenPermissions; // 0x30
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e24310
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e243a4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e24620
	static System.Void .cctor(); // 0x06e2492c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.TeamSearchResultData : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.TeamSearchItemData> ItemDatas; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e24b5c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e24bf0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e24e60
	static System.Void .cctor(); // 0x06e25174
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.TemplateGrades : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.HashSet<System.Int32> Grades; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e252d4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e25368
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e255cc
	System.Void .ctor(); // 0x06e258d4
	static System.Void .cctor(); // 0x06e25988
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.TerritoryFillUpkeepData : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 Bzid; // 0x10
	System.Int32 count; // 0x18
	System.Boolean IsMaxNumLimit; // 0x1c
	System.Collections.Generic.List<System.Int64> Path; // 0x20
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e25ae8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e25b7c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e25e48
	System.Void .ctor(); // 0x06e261ac
	static System.Void .cctor(); // 0x06e26214
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.TraceTimeData : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.Cache.IPooledObject
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 748161912;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Common.SimpleCustom.TraceTimeData> pool; // 0x18
	System.Int32 Identifier; // 0x10
	System.Int64 ClientSendTs; // 0x18
	System.Int64 GateReceiveTs; // 0x20
	System.Int64 SimulatorReceiveTs; // 0x28
	System.Int64 SimulatorProcessTs; // 0x30
	System.Int64 WorldFrameEndTs; // 0x38
	System.Int64 AoiSendTs; // 0x40
	System.Int64 GateSendTs; // 0x48
	System.Int64 ClientSequence; // 0x50
	System.Int64 ClientReceiveTs; // 0x58
	System.Int64 ClientMainThreadTs; // 0x60
	System.Int64 ClientProcessTs; // 0x68
	System.Boolean <IsReturn>k__BackingField; // 0x70
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e26410
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e264a4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e26728
	System.Void .ctor(); // 0x06e26a38
	System.Boolean ValueEquals(WizardGames.Soc.Common.SimpleCustom.TraceTimeData rhs); // 0x06e26aa0
	System.Boolean get_IsReturn(); // 0x06e26b18
	System.Void set_IsReturn(System.Boolean value); // 0x06e26b7c
	System.Void StartTrace(System.Int64 now, System.Int32 identifier); // 0x06e26bf8
	System.String ToString(); // 0x06e26c7c
	System.Void ReturnToPool(); // 0x06e26dcc
	static WizardGames.Soc.Common.SimpleCustom.TraceTimeData GetFromPool(); // 0x06e26e80
	static System.Void .cctor(); // 0x06e26f28
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.TrainBarricadeHpZeroEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e271e4
	System.Int32 GetClassHash(); // 0x06e27290
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e272f8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e27520
	System.Void Dispose(); // 0x06e277f8
	System.Void .ctor(); // 0x06e27860
	static WizardGames.Soc.Common.SimpleCustom.TrainBarricadeHpZeroEvent NewEvent(); // 0x06e278ec
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06e27964
	static System.Void .cctor(); // 0x06e27a0c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.TrainHpZeroEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e27bd4
	System.Int32 GetClassHash(); // 0x06e27c80
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e27ce8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e27f10
	System.Void Dispose(); // 0x06e281e8
	System.Void .ctor(); // 0x06e28250
	static WizardGames.Soc.Common.SimpleCustom.TrainHpZeroEvent NewEvent(); // 0x06e282dc
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06e28354
	static System.Void .cctor(); // 0x06e283fc
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.UgcPropertyModifyInfo : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 PropertyId; // 0x10
	WizardGames.Soc.Common.SimpleCustom.SimpleDataObject Data; // 0x18
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e285c4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e28658
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e288c0
	System.Void .ctor(); // 0x06e28ba8
	static System.Void .cctor(); // 0x06e28c10
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.UpdateTransformData : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 OwnerEntityId; // 0x10
	System.Int64 PartEntityId; // 0x18
	System.Numerics.Vector3 Rot; // 0x20
	System.Numerics.Vector3 Pos; // 0x2c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e28da4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e28e38
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e29138
	static System.Void .cctor(); // 0x06e29494
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.UpgradePartAudioEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 PartEntityId; // 0x38
	System.Single PosY; // 0x40
	System.Int32 Grade; // 0x44
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e29690
	System.Int32 GetClassHash(); // 0x06e2973c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e297a4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e29a28
	System.Void Dispose(); // 0x06e29d44
	System.Void .ctor(); // 0x06e29dac
	static WizardGames.Soc.Common.SimpleCustom.UpgradePartAudioEvent NewEvent(); // 0x06e29e38
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06e29eb0
	static System.Void .cctor(); // 0x06e29f70
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.UserCmd : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.Cache.ICacheObject, Share.Common.ObjPool.IPooledObjectNew, WizardGames.Soc.Common.Cache.IPooledObject
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 148141126;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 Sequence; // 0x10
	System.Int64 SnapshotSequence; // 0x18
	System.Int32 Interval; // 0x20
	System.Single Yaw; // 0x24
	System.Single Pitch; // 0x28
	System.Single ViewYaw; // 0x2c
	System.Single ViewPitch; // 0x30
	System.Single ShootYaw; // 0x34
	System.Single ShootPitch; // 0x38
	System.Int64 SendTime; // 0x40
	System.Int64 SendRenderTime; // 0x48
	System.Single Fov; // 0x50
	System.Single JoystickYaw; // 0x54
	System.Int32 ReloadAmmoId; // 0x58
	System.Int64 ReloadAmmoNodeId; // 0x60
	System.Collections.BitArray ButtonBits; // 0x68
	System.Single LittleEyeGoPosX; // 0x70
	System.Single LittleEyeGoPosY; // 0x74
	System.Single LittleEyeGoPosZ; // 0x78
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.ProjectileHitData> ProjectileHits; // 0x80
	System.Single CarDataPosX; // 0x88
	System.Single CarDataPosY; // 0x8c
	System.Single CarDataPosZ; // 0x90
	System.Single CarDataRotX; // 0x94
	System.Single CarDataRotY; // 0x98
	System.Single CarDataRotZ; // 0x9c
	System.Single CarDataVelX; // 0xa0
	System.Single CarDataVelY; // 0xa4
	System.Single CarDataVelZ; // 0xa8
	System.Single CarDataAngVelX; // 0xac
	System.Single CarDataAngVelY; // 0xb0
	System.Single CarDataAngVelZ; // 0xb4
	System.Int64 CarDataMountableId; // 0xb8
	System.Single CarDataSteerAngle; // 0xc0
	System.Single CarDataGasPedal; // 0xc4
	System.Int32 CarDataTotalStartTime; // 0xc8
	System.Int32 CarDataRevSpeed; // 0xcc
	System.Int32 CarDataFlag; // 0xd0
	System.Int32 CarDataHorseState; // 0xd4
	System.Int32 CarDataUnActiveState; // 0xd8
	System.Int32 CarDataMoveState; // 0xdc
	System.Int32 CarDataPhyxSimulateTime; // 0xe0
	System.Boolean CarMoving; // 0xe4
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.MeleeHitData> MeleeHitDatas; // 0xe8
	System.Single PosX; // 0xf0
	System.Single PosY; // 0xf4
	System.Single PosZ; // 0xf8
	System.Boolean NeedClientAuthority; // 0xfc
	System.Int64 PlatformId; // 0x100
	System.Single PlatformX; // 0x108
	System.Single PlatformY; // 0x10c
	System.Single PlatformZ; // 0x110
	System.Int32 CollisionFlags; // 0x114
	System.Boolean IsGrounded; // 0x118
	System.Single NormalX; // 0x11c
	System.Single NormalY; // 0x120
	System.Single NormalZ; // 0x124
	System.Int64 ClientAuthorityTimeAck; // 0x128
	WizardGames.Soc.Common.SimpleCustom.RootMotionData RootMotionData; // 0x130
	System.Byte PoseState; // 0x138
	System.Byte MoveState; // 0x139
	System.Byte MoveJumpState; // 0x13a
	System.Byte MoveSwimState; // 0x13b
	System.Byte MoveLadderState; // 0x13c
	System.Byte MoveMantleState; // 0x13d
	System.Byte AdsState; // 0x13e
	WizardGames.Soc.Common.SimpleCustom.TraceTimeData TraceTime; // 0x140
	System.Single FlyMaxSpeed; // 0x148
	System.Int64 ClientSmoothRenderTime; // 0x150
	System.Numerics.Vector3 EyePosition; // 0x158
	System.Single JoystickPercent; // 0x164
	System.Boolean MagicBulletFlag; // 0x168
	System.Int32 HoldItemIndex; // 0x16c
	System.Int64 WorkbenchId; // 0x170
	System.Int64 AidTargetId; // 0x178
	System.Int32 InteractiveID; // 0x180
	System.Int64 InteractiveTargetID; // 0x188
	System.Int64 currentLockingEntityId; // 0x190
	System.Single currentLockingEntityToken; // 0x198
	System.Boolean SetupAdsPressed; // 0x19c
	System.Boolean SetupSprintPressed; // 0x19d
	System.Boolean SetupCrouchPressed; // 0x19e
	System.Single ViewKickPitch; // 0x1a0
	System.Single ViewKickYaw; // 0x1a4
	System.Single ShootOffsetX; // 0x1a8
	System.Single ShootOffsetY; // 0x1ac
	System.Single ViewOffsetX; // 0x1b0
	System.Single ViewOffsetY; // 0x1b4
	System.Boolean IsPc; // 0x1b8
	System.Byte SpatialAudio; // 0x1b9
	System.Boolean IsPredict; // 0x1ba
	System.Boolean Recourse; // 0x1bb
	static System.Int32 FullCmdBaseSequence; // 0x18
	static System.Boolean EnableIncrementalCmd; // 0x1c
	static WizardGames.Soc.Common.SimpleCustom.UserCmd EmptyCmd; // 0x20
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Common.SimpleCustom.UserCmd> pool; // 0x28
	System.Int32 ClientTime; // 0x1bc
	System.Int32 BaseSequence; // 0x1c0
	System.Collections.Generic.List<System.Int32> SerializePropertyList; // 0x1c8
	System.Boolean IsMadeByServer; // 0x1d0
	System.Boolean Turn; // 0x1d1
	System.UInt64 <Mid>k__BackingField; // 0x1d8
	System.Boolean <IsReturn>k__BackingField; // 0x1e0
	System.Boolean <CareThreadSafe>k__BackingField; // 0x1e1
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e2a1d4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e2a3f4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e2b268
	System.Boolean get_MoveForwardContinuous(); // 0x06e2f00c
	System.Void set_MoveForwardContinuous(System.Boolean value); // 0x06e2f080
	System.Boolean get_MoveBackwardContinuous(); // 0x06e2f10c
	System.Void set_MoveBackwardContinuous(System.Boolean value); // 0x06e2f180
	System.Boolean get_MoveRightContinuous(); // 0x06e2f20c
	System.Void set_MoveRightContinuous(System.Boolean value); // 0x06e2f280
	System.Boolean get_MoveLeftContinuous(); // 0x06e2f30c
	System.Void set_MoveLeftContinuous(System.Boolean value); // 0x06e2f380
	System.Boolean get_Jump(); // 0x06e2f40c
	System.Void set_Jump(System.Boolean value); // 0x06e2f480
	System.Void set_JumpContinus(System.Boolean value); // 0x06e2f50c
	System.Boolean get_Idle(); // 0x06e2f598
	System.Void set_Idle(System.Boolean value); // 0x06e2f60c
	System.Boolean get_Walk(); // 0x06e2f698
	System.Void set_WalkContinus(System.Boolean value); // 0x06e2f70c
	System.Boolean get_Run(); // 0x06e2f798
	System.Void set_Run(System.Boolean value); // 0x06e2f80c
	System.Void set_RunContinus(System.Boolean value); // 0x06e2f898
	System.Boolean get_Sprint(); // 0x06e2f924
	System.Void set_Sprint(System.Boolean value); // 0x06e2f998
	System.Void set_SprintContinus(System.Boolean value); // 0x06e2fa24
	System.Boolean get_Crouch(); // 0x06e2fab0
	System.Void set_Crouch(System.Boolean value); // 0x06e2fb24
	System.Void set_CrouchContinus(System.Boolean value); // 0x06e2fbb0
	System.Boolean get_Crawl(); // 0x06e2fc3c
	System.Void set_Crawl(System.Boolean value); // 0x06e2fcb0
	System.Void set_CrawlContinus(System.Boolean value); // 0x06e2fd3c
	System.Boolean get_Mantle(); // 0x06e2fdc8
	System.Void set_Mantle(System.Boolean value); // 0x06e2fe3c
	System.Void set_MantleContinuous(System.Boolean value); // 0x06e2fec8
	System.Boolean get_ActivePressMantle(); // 0x06e2ff54
	System.Void set_ActivePressMantle(System.Boolean value); // 0x06e2ffc8
	System.Boolean get_FireCancel(); // 0x06e30054
	System.Void set_FireCancel(System.Boolean value); // 0x06e300c8
	System.Boolean get_Fire1(); // 0x06e30154
	System.Void set_Fire1(System.Boolean value); // 0x06e301c8
	System.Boolean get_Fire1Continus(); // 0x06e30254
	System.Void set_Fire1Continus(System.Boolean value); // 0x06e302c8
	System.Boolean get_Fire2(); // 0x06e30354
	System.Void set_Fire2(System.Boolean value); // 0x06e303c8
	System.Boolean get_Fire2Continus(); // 0x06e30454
	System.Void set_Fire2Continus(System.Boolean value); // 0x06e304c8
	System.Boolean get_FireBoth(); // 0x06e30554
	System.Void set_FireBoth(System.Boolean value); // 0x06e305c8
	System.Boolean get_FireBothContinuous(); // 0x06e30654
	System.Void set_FireBothContinuous(System.Boolean value); // 0x06e306c8
	System.Boolean get_Reload(); // 0x06e30754
	System.Void set_Reload(System.Boolean value); // 0x06e307c8
	System.Void set_ReloadContinus(System.Boolean value); // 0x06e30854
	System.Boolean get_Suicide(); // 0x06e308e0
	System.Void set_SuicideContinus(System.Boolean value); // 0x06e30954
	System.Boolean get_AttackAction(); // 0x054c4760
	System.Void set_AttackAction(System.Boolean value); // 0x05523a7c
	System.Void set_WakeUpAction(System.Boolean value); // 0x06e309e0
	System.Boolean get_Fly(); // 0x06e30a6c
	System.Void set_Fly(System.Boolean value); // 0x06e30ae0
	System.Boolean get_Up(); // 0x06e30b6c
	System.Void set_Up(System.Boolean value); // 0x06e30be0
	System.Boolean get_UpContinue(); // 0x06e30c6c
	System.Void set_UpContinue(System.Boolean value); // 0x06e30ce0
	System.Boolean get_Down(); // 0x06e30d6c
	System.Void set_Down(System.Boolean value); // 0x06e30de0
	System.Boolean get_DownContinue(); // 0x06e30e6c
	System.Void set_DownContinue(System.Boolean value); // 0x06e30ee0
	System.Boolean get_Observer(); // 0x06e30f6c
	System.Void set_Observer(System.Boolean value); // 0x06e30fe0
	System.Boolean get_ShortCut(); // 0x06e3106c
	System.Void set_ShortCut(System.Boolean value); // 0x06e310e0
	System.Boolean get_HiddenUse(); // 0x06e3116c
	System.Void set_HiddenUse(System.Boolean value); // 0x06e311e0
	System.Boolean get_SwitchSkin(); // 0x06e3126c
	System.Boolean get_ItemModel(); // 0x06e312e0
	System.Void set_ItemModel(System.Boolean value); // 0x06e31354
	System.Boolean get_MoveForward(); // 0x06e313e0
	System.Void set_MoveForward(System.Boolean value); // 0x06e31454
	System.Boolean get_MoveBackward(); // 0x06e314e0
	System.Void set_MoveBackward(System.Boolean value); // 0x06e31554
	System.Boolean get_MoveRight(); // 0x06e315e0
	System.Void set_MoveRight(System.Boolean value); // 0x06e31654
	System.Boolean get_MoveLeft(); // 0x06e316e0
	System.Void set_MoveLeft(System.Boolean value); // 0x06e31754
	System.Boolean get_Ladder(); // 0x06e317e0
	System.Void set_Ladder(System.Boolean value); // 0x06e31854
	System.Boolean get_CutParachute(); // 0x06e318e0
	System.Void set_CutParachute(System.Boolean value); // 0x06e31954
	System.Boolean get_CmdPc(); // 0x06e319e0
	System.Void set_CmdPc(System.Boolean value); // 0x06e31a54
	System.Void .ctor(); // 0x06e31ae0
	static WizardGames.Soc.Common.SimpleCustom.UserCmd Get(); // 0x06e31cd4
	static System.Void Return(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06e31d7c
	System.Void StartTrace(System.Int64 now); // 0x06e31ea4
	System.Boolean get_HasMove(); // 0x06e31f6c
	System.Boolean get_HasSwitch(); // 0x06e320e4
	System.Boolean GetHasMove(System.Boolean InF, System.Boolean InB, System.Boolean InL, System.Boolean InR, System.Boolean InTurn); // 0x06e3201c
	System.Void ContinuesCheck(WizardGames.Soc.Common.SimpleCustom.UserCmd old); // 0x06e32164
	System.Boolean AnyActionKeyPress(); // 0x06e32470
	System.Void SetCmd(WizardGames.Soc.Common.Control.UserCmdConstant cmd, System.Boolean enable); // 0x06e3252c
	System.Void Copy(WizardGames.Soc.Common.SimpleCustom.UserCmd newCmd); // 0x06e325c0
	System.UInt64 get_Mid(); // 0x06e32b20
	System.Void set_Mid(System.UInt64 value); // 0x06e32b84
	System.Boolean get_IsReturn(); // 0x06e32bfc
	System.Void set_IsReturn(System.Boolean value); // 0x06e32c60
	System.Boolean get_CareThreadSafe(); // 0x06e32cdc
	System.Void set_CareThreadSafe(System.Boolean value); // 0x06e32d40
	System.Void ReturnToPool(); // 0x06e32814
	System.Void Dispose(); // 0x06e31de8
	WizardGames.Soc.Common.SimpleCustom.UserCmd GetBaseCmd(); // 0x06e2e750
	System.Boolean ValueEquals(System.Boolean lhs, System.Boolean rhs); // 0x06e2ec30
	System.Boolean ValueEquals(System.Int32 lhs, System.Int32 rhs); // 0x06e2e85c
	System.Boolean ValueEquals(System.Int64 lhs, System.Int64 rhs); // 0x06e2e8e0
	System.Boolean ValueEquals(System.Single lhs, System.Single rhs); // 0x06e2e964
	System.Boolean ValueEquals(System.Numerics.Vector3 lhs, System.Numerics.Vector3 rhs); // 0x06e2ef3c
	System.Boolean ValueEquals(System.Collections.BitArray lhs, System.Collections.BitArray rhs); // 0x06e2ea00
	System.Boolean ValueEquals(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.ProjectileHitData> lhs, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.ProjectileHitData> rhs); // 0x06e2eb00
	System.Boolean ValueEquals(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.MeleeHitData> lhs, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.MeleeHitData> rhs); // 0x06e2ecb8
	System.Boolean ValueEquals(WizardGames.Soc.Common.SimpleCustom.RootMotionData lhs, WizardGames.Soc.Common.SimpleCustom.RootMotionData rhs); // 0x06e2ede8
	System.Boolean ValueEquals(WizardGames.Soc.Common.SimpleCustom.TraceTimeData lhs, WizardGames.Soc.Common.SimpleCustom.TraceTimeData rhs); // 0x06e2ee94
	System.Boolean IsFinite(); // 0x06e32dbc
	static System.Void .cctor(); // 0x06e330a0
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.UserControllerSetting : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.Cache.ICacheObject, Share.Common.ObjPool.IPooledObjectNew, WizardGames.Soc.Common.Cache.IPooledObject
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 58593911;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Boolean InputBackBreakMantle; // 0x10
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Common.SimpleCustom.UserControllerSetting> pool; // 0x18
	System.UInt64 <Mid>k__BackingField; // 0x18
	System.Boolean <IsReturn>k__BackingField; // 0x20
	System.Boolean <CareThreadSafe>k__BackingField; // 0x21
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e343ac
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e34440
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e34634
	System.UInt64 get_Mid(); // 0x06e348e0
	System.Void set_Mid(System.UInt64 value); // 0x06e34944
	System.Boolean get_IsReturn(); // 0x06e349bc
	System.Void set_IsReturn(System.Boolean value); // 0x06e34a20
	System.Boolean get_CareThreadSafe(); // 0x06e34a9c
	System.Void set_CareThreadSafe(System.Boolean value); // 0x06e34b00
	System.Void .ctor(); // 0x06e34b7c
	static WizardGames.Soc.Common.SimpleCustom.UserControllerSetting Get(); // 0x06e34be4
	static System.Void Return(WizardGames.Soc.Common.SimpleCustom.UserControllerSetting userController); // 0x06e34c8c
	System.Void Dispose(); // 0x06e34cf8
	System.Void ReturnToPool(); // 0x06e34db4
	static System.Void .cctor(); // 0x06e34e18
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueNodeCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e34fd0
	static WizardGames.Soc.Common.SimpleCustom.ValueNodeCfg ValueNodeCfgConstructor(); // 0x06e35078
	System.Void .ctor(); // 0x06e350f8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e35184
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e35380
	static System.Void .cctor(); // 0x06e3562c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueBoolCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3578c
	static WizardGames.Soc.Common.SimpleCustom.ValueBoolCfg ValueBoolCfgConstructor(); // 0x06e35834
	System.Void .ctor(); // 0x06e358b4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e35940
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e35b3c
	static System.Void .cctor(); // 0x06e35de8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueFloatCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e35f48
	static WizardGames.Soc.Common.SimpleCustom.ValueFloatCfg ValueFloatCfgConstructor(); // 0x06e35ff0
	System.Void .ctor(); // 0x06e36070
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e360fc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e362f8
	static System.Void .cctor(); // 0x06e365a4
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueLongCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e36704
	static WizardGames.Soc.Common.SimpleCustom.ValueLongCfg ValueLongCfgConstructor(); // 0x06e367ac
	System.Void .ctor(); // 0x06e3682c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e368b8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e36ab4
	static System.Void .cctor(); // 0x06e36d60
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueStringCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e36ec0
	static WizardGames.Soc.Common.SimpleCustom.ValueStringCfg ValueStringCfgConstructor(); // 0x06e36f68
	System.Void .ctor(); // 0x06e36fe8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e37074
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e37270
	static System.Void .cctor(); // 0x06e3751c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueVector3Cfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3767c
	static WizardGames.Soc.Common.SimpleCustom.ValueVector3Cfg ValueVector3CfgConstructor(); // 0x06e37724
	System.Void .ctor(); // 0x06e377a4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e37830
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e37a2c
	static System.Void .cctor(); // 0x06e37cd8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueListBoolCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e37e38
	static WizardGames.Soc.Common.SimpleCustom.ValueListBoolCfg ValueListBoolCfgConstructor(); // 0x06e37ee0
	System.Void .ctor(); // 0x06e37f60
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e37fec
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e381e8
	static System.Void .cctor(); // 0x06e38494
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueListFloatCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e385f4
	static WizardGames.Soc.Common.SimpleCustom.ValueListFloatCfg ValueListFloatCfgConstructor(); // 0x06e3869c
	System.Void .ctor(); // 0x06e3871c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e387a8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e389a4
	static System.Void .cctor(); // 0x06e38c50
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueListLongCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e38db0
	static WizardGames.Soc.Common.SimpleCustom.ValueListLongCfg ValueListLongCfgConstructor(); // 0x06e38e58
	System.Void .ctor(); // 0x06e38ed8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e38f64
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e39160
	static System.Void .cctor(); // 0x06e3940c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueListStringCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3956c
	static WizardGames.Soc.Common.SimpleCustom.ValueListStringCfg ValueListStringCfgConstructor(); // 0x06e39614
	System.Void .ctor(); // 0x06e39694
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e39720
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e3991c
	static System.Void .cctor(); // 0x06e39bc8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueListVector3Cfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e39d28
	static WizardGames.Soc.Common.SimpleCustom.ValueListVector3Cfg ValueListVector3CfgConstructor(); // 0x06e39dd0
	System.Void .ctor(); // 0x06e39e50
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e39edc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e3a0d8
	static System.Void .cctor(); // 0x06e3a384
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongBoolCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3a4e4
	static WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongBoolCfg ValueDictionaryLongBoolCfgConstructor(); // 0x06e3a58c
	System.Void .ctor(); // 0x06e3a60c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3a698
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e3a894
	static System.Void .cctor(); // 0x06e3ab40
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongFloatCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3aca0
	static WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongFloatCfg ValueDictionaryLongFloatCfgConstructor(); // 0x06e3ad48
	System.Void .ctor(); // 0x06e3adc8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3ae54
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e3b050
	static System.Void .cctor(); // 0x06e3b2fc
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongLongCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3b45c
	static WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongLongCfg ValueDictionaryLongLongCfgConstructor(); // 0x06e3b504
	System.Void .ctor(); // 0x06e3b584
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3b610
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e3b80c
	static System.Void .cctor(); // 0x06e3bab8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongStringCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3bc18
	static WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongStringCfg ValueDictionaryLongStringCfgConstructor(); // 0x06e3bcc0
	System.Void .ctor(); // 0x06e3bd40
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3bdcc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e3bfc8
	static System.Void .cctor(); // 0x06e3c274
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongVector3Cfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3c3d4
	static WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongVector3Cfg ValueDictionaryLongVector3CfgConstructor(); // 0x06e3c47c
	System.Void .ctor(); // 0x06e3c4fc
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3c588
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e3c784
	static System.Void .cctor(); // 0x06e3ca30
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueECompareTypeCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3cb90
	static WizardGames.Soc.Common.SimpleCustom.ValueECompareTypeCfg ValueECompareTypeCfgConstructor(); // 0x06e3cc38
	System.Void .ctor(); // 0x06e3ccb8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3cd44
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e3cf40
	static System.Void .cctor(); // 0x06e3d1ec
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueEMultiLangStrTypeCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3d34c
	static WizardGames.Soc.Common.SimpleCustom.ValueEMultiLangStrTypeCfg ValueEMultiLangStrTypeCfgConstructor(); // 0x06e3d3f4
	System.Void .ctor(); // 0x06e3d474
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3d500
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e3d6fc
	static System.Void .cctor(); // 0x06e3d9a8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueETableTypeCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3db08
	static WizardGames.Soc.Common.SimpleCustom.ValueETableTypeCfg ValueETableTypeCfgConstructor(); // 0x06e3dbb0
	System.Void .ctor(); // 0x06e3dc30
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3dcbc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e3deb8
	static System.Void .cctor(); // 0x06e3e164
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueEEventParamsTypeCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3e2c4
	static WizardGames.Soc.Common.SimpleCustom.ValueEEventParamsTypeCfg ValueEEventParamsTypeCfgConstructor(); // 0x06e3e36c
	System.Void .ctor(); // 0x06e3e3ec
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3e478
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e3e674
	static System.Void .cctor(); // 0x06e3e920
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueEDataSetTypeCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3ea80
	static WizardGames.Soc.Common.SimpleCustom.ValueEDataSetTypeCfg ValueEDataSetTypeCfgConstructor(); // 0x06e3eb28
	System.Void .ctor(); // 0x06e3eba8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3ec34
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e3ee30
	static System.Void .cctor(); // 0x06e3f0dc
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueEStatPanelDisplayableModeCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3f23c
	static WizardGames.Soc.Common.SimpleCustom.ValueEStatPanelDisplayableModeCfg ValueEStatPanelDisplayableModeCfgConstructor(); // 0x06e3f2e4
	System.Void .ctor(); // 0x06e3f364
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3f3f0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e3f5ec
	static System.Void .cctor(); // 0x06e3f898
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueEGameResultTypeCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3f9f8
	static WizardGames.Soc.Common.SimpleCustom.ValueEGameResultTypeCfg ValueEGameResultTypeCfgConstructor(); // 0x06e3faa0
	System.Void .ctor(); // 0x06e3fb20
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e3fbac
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e3fda8
	static System.Void .cctor(); // 0x06e40054
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueEProgressBarTypeCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e401b4
	static WizardGames.Soc.Common.SimpleCustom.ValueEProgressBarTypeCfg ValueEProgressBarTypeCfgConstructor(); // 0x06e4025c
	System.Void .ctor(); // 0x06e402dc
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e40368
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e40564
	static System.Void .cctor(); // 0x06e40810
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueEGivePlayerItemTypeCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e40970
	static WizardGames.Soc.Common.SimpleCustom.ValueEGivePlayerItemTypeCfg ValueEGivePlayerItemTypeCfgConstructor(); // 0x06e40a18
	System.Void .ctor(); // 0x06e40a98
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e40b24
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e40d20
	static System.Void .cctor(); // 0x06e40fcc
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueEServerTypeCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4112c
	static WizardGames.Soc.Common.SimpleCustom.ValueEServerTypeCfg ValueEServerTypeCfgConstructor(); // 0x06e411d4
	System.Void .ctor(); // 0x06e41254
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e412e0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e414dc
	static System.Void .cctor(); // 0x06e41788
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueCustomEventParamCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e418e8
	static WizardGames.Soc.Common.SimpleCustom.ValueCustomEventParamCfg ValueCustomEventParamCfgConstructor(); // 0x06e41990
	System.Void .ctor(); // 0x06e41a10
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e41a9c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e41c98
	static System.Void .cctor(); // 0x06e41f44
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueListCustomEventParamCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e420a4
	static WizardGames.Soc.Common.SimpleCustom.ValueListCustomEventParamCfg ValueListCustomEventParamCfgConstructor(); // 0x06e4214c
	System.Void .ctor(); // 0x06e421cc
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e42258
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e42454
	static System.Void .cctor(); // 0x06e42700
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongCustomEventParamCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e42860
	static WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongCustomEventParamCfg ValueDictionaryLongCustomEventParamCfgConstructor(); // 0x06e42908
	System.Void .ctor(); // 0x06e42988
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e42a14
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e42c10
	static System.Void .cctor(); // 0x06e42ebc
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueCustomTypeExampleCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4301c
	static WizardGames.Soc.Common.SimpleCustom.ValueCustomTypeExampleCfg ValueCustomTypeExampleCfgConstructor(); // 0x06e430c4
	System.Void .ctor(); // 0x06e43144
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e431d0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e433cc
	static System.Void .cctor(); // 0x06e43678
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueListCustomTypeExampleCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e43964
	static WizardGames.Soc.Common.SimpleCustom.ValueListCustomTypeExampleCfg ValueListCustomTypeExampleCfgConstructor(); // 0x06e43a70
	System.Void .ctor(); // 0x06e43af0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e43b78
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e43d74
	static System.Void .cctor(); // 0x06e44020
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongCustomTypeExampleCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e44180
	static WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongCustomTypeExampleCfg ValueDictionaryLongCustomTypeExampleCfgConstructor(); // 0x06e44224
	System.Void .ctor(); // 0x06e442a4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4432c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e44528
	static System.Void .cctor(); // 0x06e447d4
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueInitStatPanelDataCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e44934
	static WizardGames.Soc.Common.SimpleCustom.ValueInitStatPanelDataCfg ValueInitStatPanelDataCfgConstructor(); // 0x06e449d8
	System.Void .ctor(); // 0x06e44a58
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e44ae0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e44cdc
	static System.Void .cctor(); // 0x06e44f88
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueListInitStatPanelDataCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e450e8
	static WizardGames.Soc.Common.SimpleCustom.ValueListInitStatPanelDataCfg ValueListInitStatPanelDataCfgConstructor(); // 0x06e4518c
	System.Void .ctor(); // 0x06e4520c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e45294
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e45490
	static System.Void .cctor(); // 0x06e4573c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongInitStatPanelDataCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4589c
	static WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongInitStatPanelDataCfg ValueDictionaryLongInitStatPanelDataCfgConstructor(); // 0x06e45940
	System.Void .ctor(); // 0x06e459c0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e45a48
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e45c44
	static System.Void .cctor(); // 0x06e45ef0
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueStatTeamDataCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e46050
	static WizardGames.Soc.Common.SimpleCustom.ValueStatTeamDataCfg ValueStatTeamDataCfgConstructor(); // 0x06e460f4
	System.Void .ctor(); // 0x06e46174
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e461fc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e463f8
	static System.Void .cctor(); // 0x06e466a4
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueListStatTeamDataCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e46804
	static WizardGames.Soc.Common.SimpleCustom.ValueListStatTeamDataCfg ValueListStatTeamDataCfgConstructor(); // 0x06e468a8
	System.Void .ctor(); // 0x06e46928
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e469b0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e46bac
	static System.Void .cctor(); // 0x06e46e58
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongStatTeamDataCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e46fb8
	static WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongStatTeamDataCfg ValueDictionaryLongStatTeamDataCfgConstructor(); // 0x06e4705c
	System.Void .ctor(); // 0x06e470dc
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e47164
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e47360
	static System.Void .cctor(); // 0x06e4760c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueItemCountCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4776c
	static WizardGames.Soc.Common.SimpleCustom.ValueItemCountCfg ValueItemCountCfgConstructor(); // 0x06e47810
	System.Void .ctor(); // 0x06e47890
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e47918
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e47b14
	static System.Void .cctor(); // 0x06e47dc0
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueListItemCountCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e47f20
	static WizardGames.Soc.Common.SimpleCustom.ValueListItemCountCfg ValueListItemCountCfgConstructor(); // 0x06e47fc4
	System.Void .ctor(); // 0x06e48044
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e480cc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e482c8
	static System.Void .cctor(); // 0x06e48574
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongItemCountCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e486d4
	static WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongItemCountCfg ValueDictionaryLongItemCountCfgConstructor(); // 0x06e48778
	System.Void .ctor(); // 0x06e487f8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e48880
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e48a7c
	static System.Void .cctor(); // 0x06e48d28
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueMultiLangStringCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e48e88
	static WizardGames.Soc.Common.SimpleCustom.ValueMultiLangStringCfg ValueMultiLangStringCfgConstructor(); // 0x06e48f2c
	System.Void .ctor(); // 0x06e48fac
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e49034
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e49230
	static System.Void .cctor(); // 0x06e494dc
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueListMultiLangStringCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4963c
	static WizardGames.Soc.Common.SimpleCustom.ValueListMultiLangStringCfg ValueListMultiLangStringCfgConstructor(); // 0x06e496e0
	System.Void .ctor(); // 0x06e49760
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e497e8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e499e4
	static System.Void .cctor(); // 0x06e49c90
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongMultiLangStringCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e49df0
	static WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongMultiLangStringCfg ValueDictionaryLongMultiLangStringCfgConstructor(); // 0x06e49e94
	System.Void .ctor(); // 0x06e49f14
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e49f9c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e4a198
	static System.Void .cctor(); // 0x06e4a444
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueMultiLangStringBuilderCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4a5a4
	static WizardGames.Soc.Common.SimpleCustom.ValueMultiLangStringBuilderCfg ValueMultiLangStringBuilderCfgConstructor(); // 0x06e4a648
	System.Void .ctor(); // 0x06e4a6c8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4a750
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e4a94c
	static System.Void .cctor(); // 0x06e4abf8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueListMultiLangStringBuilderCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4ad58
	static WizardGames.Soc.Common.SimpleCustom.ValueListMultiLangStringBuilderCfg ValueListMultiLangStringBuilderCfgConstructor(); // 0x06e4adfc
	System.Void .ctor(); // 0x06e4ae7c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4af04
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e4b100
	static System.Void .cctor(); // 0x06e4b3ac
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongMultiLangStringBuilderCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4b50c
	static WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongMultiLangStringBuilderCfg ValueDictionaryLongMultiLangStringBuilderCfgConstructor(); // 0x06e4b5b0
	System.Void .ctor(); // 0x06e4b630
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4b6b8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e4b8b4
	static System.Void .cctor(); // 0x06e4bb60
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueNodeIdCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4bcc0
	static WizardGames.Soc.Common.SimpleCustom.ValueNodeIdCfg ValueNodeIdCfgConstructor(); // 0x06e4bd64
	System.Void .ctor(); // 0x06e4bde4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4be6c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e4c068
	static System.Void .cctor(); // 0x06e4c314
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueStatDynamicFieldsCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4c474
	static WizardGames.Soc.Common.SimpleCustom.ValueStatDynamicFieldsCfg ValueStatDynamicFieldsCfgConstructor(); // 0x06e4c518
	System.Void .ctor(); // 0x06e4c598
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4c620
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e4c81c
	static System.Void .cctor(); // 0x06e4cac8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueListStatDynamicFieldsCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4cc28
	static WizardGames.Soc.Common.SimpleCustom.ValueListStatDynamicFieldsCfg ValueListStatDynamicFieldsCfgConstructor(); // 0x06e4cccc
	System.Void .ctor(); // 0x06e4cd4c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4cdd4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e4cfd0
	static System.Void .cctor(); // 0x06e4d27c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongStatDynamicFieldsCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4d3dc
	static WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongStatDynamicFieldsCfg ValueDictionaryLongStatDynamicFieldsCfgConstructor(); // 0x06e4d480
	System.Void .ctor(); // 0x06e4d500
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4d588
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e4d784
	static System.Void .cctor(); // 0x06e4da30
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueTableFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4db90
	static WizardGames.Soc.Common.SimpleCustom.ValueTableFieldInfoCfg ValueTableFieldInfoCfgConstructor(); // 0x06e4dc34
	System.Void .ctor(); // 0x06e4dcb4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4dd3c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e4df38
	static System.Void .cctor(); // 0x06e4e1e4
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueListTableFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4e344
	static WizardGames.Soc.Common.SimpleCustom.ValueListTableFieldInfoCfg ValueListTableFieldInfoCfgConstructor(); // 0x06e4e3e8
	System.Void .ctor(); // 0x06e4e468
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4e4f0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e4e6ec
	static System.Void .cctor(); // 0x06e4e998
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongTableFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4eaf8
	static WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongTableFieldInfoCfg ValueDictionaryLongTableFieldInfoCfgConstructor(); // 0x06e4eb9c
	System.Void .ctor(); // 0x06e4ec1c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4eca4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e4eea0
	static System.Void .cctor(); // 0x06e4f14c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueTableLongFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4f2ac
	static WizardGames.Soc.Common.SimpleCustom.ValueTableLongFieldInfoCfg ValueTableLongFieldInfoCfgConstructor(); // 0x06e4f350
	System.Void .ctor(); // 0x06e4f3d0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4f458
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e4f654
	static System.Void .cctor(); // 0x06e4f900
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueListTableLongFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4fa60
	static WizardGames.Soc.Common.SimpleCustom.ValueListTableLongFieldInfoCfg ValueListTableLongFieldInfoCfgConstructor(); // 0x06e4fb04
	System.Void .ctor(); // 0x06e4fb84
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e4fc0c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e4fe08
	static System.Void .cctor(); // 0x06e500b4
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongTableLongFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e50214
	static WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongTableLongFieldInfoCfg ValueDictionaryLongTableLongFieldInfoCfgConstructor(); // 0x06e502b8
	System.Void .ctor(); // 0x06e50338
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e503c0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e505bc
	static System.Void .cctor(); // 0x06e50868
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueTableBoolFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e509c8
	static WizardGames.Soc.Common.SimpleCustom.ValueTableBoolFieldInfoCfg ValueTableBoolFieldInfoCfgConstructor(); // 0x06e50a6c
	System.Void .ctor(); // 0x06e50aec
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e50b74
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e50d70
	static System.Void .cctor(); // 0x06e5101c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueListTableBoolFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e5117c
	static WizardGames.Soc.Common.SimpleCustom.ValueListTableBoolFieldInfoCfg ValueListTableBoolFieldInfoCfgConstructor(); // 0x06e51220
	System.Void .ctor(); // 0x06e512a0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e51328
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e51524
	static System.Void .cctor(); // 0x06e517d0
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongTableBoolFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e51930
	static WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongTableBoolFieldInfoCfg ValueDictionaryLongTableBoolFieldInfoCfgConstructor(); // 0x06e519d4
	System.Void .ctor(); // 0x06e51a54
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e51adc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e51cd8
	static System.Void .cctor(); // 0x06e51f84
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueTableFloatFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e520e4
	static WizardGames.Soc.Common.SimpleCustom.ValueTableFloatFieldInfoCfg ValueTableFloatFieldInfoCfgConstructor(); // 0x06e52188
	System.Void .ctor(); // 0x06e52208
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e52290
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e5248c
	static System.Void .cctor(); // 0x06e52738
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueListTableFloatFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e52898
	static WizardGames.Soc.Common.SimpleCustom.ValueListTableFloatFieldInfoCfg ValueListTableFloatFieldInfoCfgConstructor(); // 0x06e5293c
	System.Void .ctor(); // 0x06e529bc
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e52a44
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e52c40
	static System.Void .cctor(); // 0x06e52eec
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongTableFloatFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e5304c
	static WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongTableFloatFieldInfoCfg ValueDictionaryLongTableFloatFieldInfoCfgConstructor(); // 0x06e530f0
	System.Void .ctor(); // 0x06e53170
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e531f8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e533f4
	static System.Void .cctor(); // 0x06e536a0
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueTableStringFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e53800
	static WizardGames.Soc.Common.SimpleCustom.ValueTableStringFieldInfoCfg ValueTableStringFieldInfoCfgConstructor(); // 0x06e538a4
	System.Void .ctor(); // 0x06e53924
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e539ac
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e53ba8
	static System.Void .cctor(); // 0x06e53e54
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueListTableStringFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e53fb4
	static WizardGames.Soc.Common.SimpleCustom.ValueListTableStringFieldInfoCfg ValueListTableStringFieldInfoCfgConstructor(); // 0x06e54058
	System.Void .ctor(); // 0x06e540d8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e54160
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e5435c
	static System.Void .cctor(); // 0x06e54608
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongTableStringFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e54768
	static WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongTableStringFieldInfoCfg ValueDictionaryLongTableStringFieldInfoCfgConstructor(); // 0x06e5480c
	System.Void .ctor(); // 0x06e5488c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e54914
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e54b10
	static System.Void .cctor(); // 0x06e54dbc
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueTableTextFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e54f1c
	static WizardGames.Soc.Common.SimpleCustom.ValueTableTextFieldInfoCfg ValueTableTextFieldInfoCfgConstructor(); // 0x06e54fc0
	System.Void .ctor(); // 0x06e55040
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e550c8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e552c4
	static System.Void .cctor(); // 0x06e55570
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueListTableTextFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e556d0
	static WizardGames.Soc.Common.SimpleCustom.ValueListTableTextFieldInfoCfg ValueListTableTextFieldInfoCfgConstructor(); // 0x06e55774
	System.Void .ctor(); // 0x06e557f4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e5587c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e55a78
	static System.Void .cctor(); // 0x06e55d24
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongTableTextFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e55e84
	static WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongTableTextFieldInfoCfg ValueDictionaryLongTableTextFieldInfoCfgConstructor(); // 0x06e55f28
	System.Void .ctor(); // 0x06e55fa8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e56030
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e5622c
	static System.Void .cctor(); // 0x06e564d8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueTableLongArrayFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e56638
	static WizardGames.Soc.Common.SimpleCustom.ValueTableLongArrayFieldInfoCfg ValueTableLongArrayFieldInfoCfgConstructor(); // 0x06e566dc
	System.Void .ctor(); // 0x06e5675c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e567e4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e569e0
	static System.Void .cctor(); // 0x06e56c8c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueListTableLongArrayFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e56dec
	static WizardGames.Soc.Common.SimpleCustom.ValueListTableLongArrayFieldInfoCfg ValueListTableLongArrayFieldInfoCfgConstructor(); // 0x06e56e90
	System.Void .ctor(); // 0x06e56f10
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e56f98
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e57194
	static System.Void .cctor(); // 0x06e57440
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongTableLongArrayFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e575a0
	static WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongTableLongArrayFieldInfoCfg ValueDictionaryLongTableLongArrayFieldInfoCfgConstructor(); // 0x06e57644
	System.Void .ctor(); // 0x06e576c4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e5774c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e57948
	static System.Void .cctor(); // 0x06e57bf4
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueTableFloatArrayFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e57d54
	static WizardGames.Soc.Common.SimpleCustom.ValueTableFloatArrayFieldInfoCfg ValueTableFloatArrayFieldInfoCfgConstructor(); // 0x06e57df8
	System.Void .ctor(); // 0x06e57e78
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e57f00
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e580fc
	static System.Void .cctor(); // 0x06e583a8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueListTableFloatArrayFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e58508
	static WizardGames.Soc.Common.SimpleCustom.ValueListTableFloatArrayFieldInfoCfg ValueListTableFloatArrayFieldInfoCfgConstructor(); // 0x06e585ac
	System.Void .ctor(); // 0x06e5862c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e586b4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e588b0
	static System.Void .cctor(); // 0x06e58b5c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongTableFloatArrayFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e58cbc
	static WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongTableFloatArrayFieldInfoCfg ValueDictionaryLongTableFloatArrayFieldInfoCfgConstructor(); // 0x06e58d60
	System.Void .ctor(); // 0x06e58de0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e58e68
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e59064
	static System.Void .cctor(); // 0x06e59310
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueSelectableTeamInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e59470
	static WizardGames.Soc.Common.SimpleCustom.ValueSelectableTeamInfoCfg ValueSelectableTeamInfoCfgConstructor(); // 0x06e59514
	System.Void .ctor(); // 0x06e59594
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e5961c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e59818
	static System.Void .cctor(); // 0x06e59ac4
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueListSelectableTeamInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e59c24
	static WizardGames.Soc.Common.SimpleCustom.ValueListSelectableTeamInfoCfg ValueListSelectableTeamInfoCfgConstructor(); // 0x06e59cc8
	System.Void .ctor(); // 0x06e59d48
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e59dd0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e59fcc
	static System.Void .cctor(); // 0x06e5a278
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongSelectableTeamInfoCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e5a3d8
	static WizardGames.Soc.Common.SimpleCustom.ValueDictionaryLongSelectableTeamInfoCfg ValueDictionaryLongSelectableTeamInfoCfgConstructor(); // 0x06e5a47c
	System.Void .ctor(); // 0x06e5a4fc
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e5a584
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e5a780
	static System.Void .cctor(); // 0x06e5aa2c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueVariableIdCfg : WizardGames.Soc.Common.SimpleCustom.ValueCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e5ab8c
	static WizardGames.Soc.Common.SimpleCustom.ValueVariableIdCfg ValueVariableIdCfgConstructor(); // 0x06e5ac30
	System.Void .ctor(); // 0x06e5acb0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e5ad38
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e5af34
	static System.Void .cctor(); // 0x06e5b1e0
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ValueCfg : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.String DebugTypeName; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e5b340
	static WizardGames.Soc.Common.SimpleCustom.ValueCfg ValueCfgConstructor(); // 0x06e5b3c4
	System.Void .ctor(); // 0x06e43a08
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e5b444
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e5b640
	static System.Void .cctor(); // 0x06e5b8ec
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.VarGuidPortCfg : WizardGames.Soc.Common.SimpleCustom.PortCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	WizardGames.Soc.Common.SimpleCustom.PortDataType DataType; // 0x20
	System.Int32 DefaultValue; // 0x24
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e5ba4c
	static WizardGames.Soc.Common.SimpleCustom.VarGuidPortCfg VarGuidPortCfgConstructor(); // 0x06e5baf4
	System.Void .ctor(); // 0x06e5bb74
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e5bc00
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e5be60
	static System.Void .cctor(); // 0x06e5c150
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.VariableBoolCfg : WizardGames.Soc.Common.SimpleCustom.VariableCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Boolean Value; // 0x40
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e5c34c
	static WizardGames.Soc.Common.SimpleCustom.VariableBoolCfg VariableBoolCfgConstructor(); // 0x06e5c458
	System.Void .ctor(); // 0x06e5c4d8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e5c560
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e5c824
	static System.Void .cctor(); // 0x06e5cb58
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.VariableFloatCfg : WizardGames.Soc.Common.SimpleCustom.VariableCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Single Value; // 0x40
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e5cdf0
	static WizardGames.Soc.Common.SimpleCustom.VariableFloatCfg VariableFloatCfgConstructor(); // 0x06e5ce94
	System.Void .ctor(); // 0x06e5cf14
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e5cf9c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e5d25c
	static System.Void .cctor(); // 0x06e5d59c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.VariableLongCfg : WizardGames.Soc.Common.SimpleCustom.VariableCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 Value; // 0x40
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e5d834
	static WizardGames.Soc.Common.SimpleCustom.VariableLongCfg VariableLongCfgConstructor(); // 0x06e5d8d8
	System.Void .ctor(); // 0x06e5d958
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e5d9e0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e5dca0
	static System.Void .cctor(); // 0x06e5dfd4
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.VariableStringCfg : WizardGames.Soc.Common.SimpleCustom.VariableCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.String Value; // 0x40
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e5e26c
	static WizardGames.Soc.Common.SimpleCustom.VariableStringCfg VariableStringCfgConstructor(); // 0x06e5e310
	System.Void .ctor(); // 0x06e5e390
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e5e418
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e5e6e0
	static System.Void .cctor(); // 0x06e5ea14
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.VariableVector3Cfg : WizardGames.Soc.Common.SimpleCustom.VariableCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	WizardGames.Soc.Common.SimpleCustom.SimpleVector3 Value; // 0x40
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e5ecac
	static WizardGames.Soc.Common.SimpleCustom.VariableVector3Cfg VariableVector3CfgConstructor(); // 0x06e5ed50
	System.Void .ctor(); // 0x06e5edd0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e5ee58
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e5f170
	static System.Void .cctor(); // 0x06e5f4d0
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.VariableListBoolCfg : WizardGames.Soc.Common.SimpleCustom.VariableCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.List<System.Boolean> Value; // 0x40
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e5f768
	static WizardGames.Soc.Common.SimpleCustom.VariableListBoolCfg VariableListBoolCfgConstructor(); // 0x06e5f80c
	System.Void .ctor(); // 0x06e5f88c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e5f914
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e5fc4c
	static System.Void .cctor(); // 0x06e5ffe8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.VariableListFloatCfg : WizardGames.Soc.Common.SimpleCustom.VariableCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.List<System.Single> Value; // 0x40
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e60280
	static WizardGames.Soc.Common.SimpleCustom.VariableListFloatCfg VariableListFloatCfgConstructor(); // 0x06e60324
	System.Void .ctor(); // 0x06e603a4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e6042c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e60764
	static System.Void .cctor(); // 0x06e60b00
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.VariableListLongCfg : WizardGames.Soc.Common.SimpleCustom.VariableCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.List<System.Int64> Value; // 0x40
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e60d98
	static WizardGames.Soc.Common.SimpleCustom.VariableListLongCfg VariableListLongCfgConstructor(); // 0x06e60e3c
	System.Void .ctor(); // 0x06e60ebc
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e60f44
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e6127c
	static System.Void .cctor(); // 0x06e61618
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.VariableListStringCfg : WizardGames.Soc.Common.SimpleCustom.VariableCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.List<System.String> Value; // 0x40
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e618b0
	static WizardGames.Soc.Common.SimpleCustom.VariableListStringCfg VariableListStringCfgConstructor(); // 0x06e61954
	System.Void .ctor(); // 0x06e619d4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e61a5c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e61d94
	static System.Void .cctor(); // 0x06e62130
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.VariableListVector3Cfg : WizardGames.Soc.Common.SimpleCustom.VariableCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.SimpleVector3> Value; // 0x40
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e623c8
	static WizardGames.Soc.Common.SimpleCustom.VariableListVector3Cfg VariableListVector3CfgConstructor(); // 0x06e6246c
	System.Void .ctor(); // 0x06e624ec
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e62574
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e628b8
	static System.Void .cctor(); // 0x06e62c60
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.VariableDictionaryLongBoolCfg : WizardGames.Soc.Common.SimpleCustom.VariableCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,System.Boolean> Value; // 0x40
	System.Collections.Generic.List<System.Int64> KeysOfValue; // 0x48
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e62ef8
	static WizardGames.Soc.Common.SimpleCustom.VariableDictionaryLongBoolCfg VariableDictionaryLongBoolCfgConstructor(); // 0x06e62f9c
	System.Void .ctor(); // 0x06e6301c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e630a4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e63454
	static System.Void .cctor(); // 0x06e63860
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.VariableDictionaryLongFloatCfg : WizardGames.Soc.Common.SimpleCustom.VariableCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,System.Single> Value; // 0x40
	System.Collections.Generic.List<System.Int64> KeysOfValue; // 0x48
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e63b2c
	static WizardGames.Soc.Common.SimpleCustom.VariableDictionaryLongFloatCfg VariableDictionaryLongFloatCfgConstructor(); // 0x06e63bd0
	System.Void .ctor(); // 0x06e63c50
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e63cd8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e64088
	static System.Void .cctor(); // 0x06e64494
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.VariableDictionaryLongLongCfg : WizardGames.Soc.Common.SimpleCustom.VariableCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> Value; // 0x40
	System.Collections.Generic.List<System.Int64> KeysOfValue; // 0x48
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e64760
	static WizardGames.Soc.Common.SimpleCustom.VariableDictionaryLongLongCfg VariableDictionaryLongLongCfgConstructor(); // 0x06e64804
	System.Void .ctor(); // 0x06e64884
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e6490c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e64cbc
	static System.Void .cctor(); // 0x06e650c8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.VariableDictionaryLongStringCfg : WizardGames.Soc.Common.SimpleCustom.VariableCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,System.String> Value; // 0x40
	System.Collections.Generic.List<System.Int64> KeysOfValue; // 0x48
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e65394
	static WizardGames.Soc.Common.SimpleCustom.VariableDictionaryLongStringCfg VariableDictionaryLongStringCfgConstructor(); // 0x06e65438
	System.Void .ctor(); // 0x06e654b8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e65540
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e658f0
	static System.Void .cctor(); // 0x06e65cfc
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.VariableDictionaryLongVector3Cfg : WizardGames.Soc.Common.SimpleCustom.VariableCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.SimpleVector3> Value; // 0x40
	System.Collections.Generic.List<System.Int64> KeysOfValue; // 0x48
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e65fc8
	static WizardGames.Soc.Common.SimpleCustom.VariableDictionaryLongVector3Cfg VariableDictionaryLongVector3CfgConstructor(); // 0x06e6606c
	System.Void .ctor(); // 0x06e660ec
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e66174
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e66530
	static System.Void .cctor(); // 0x06e66948
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.VariableCustomTypeExampleCfg : WizardGames.Soc.Common.SimpleCustom.VariableCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	WizardGames.Soc.Common.SimpleCustom.CustomTypeExampleCfg Value; // 0x40
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e66c14
	static WizardGames.Soc.Common.SimpleCustom.VariableCustomTypeExampleCfg VariableCustomTypeExampleCfgConstructor(); // 0x06e66cb8
	System.Void .ctor(); // 0x06e66d38
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e66dc0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e670d8
	static System.Void .cctor(); // 0x06e67438
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.VariableListCustomTypeExampleCfg : WizardGames.Soc.Common.SimpleCustom.VariableCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.CustomTypeExampleCfg> Value; // 0x40
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e676d0
	static WizardGames.Soc.Common.SimpleCustom.VariableListCustomTypeExampleCfg VariableListCustomTypeExampleCfgConstructor(); // 0x06e67774
	System.Void .ctor(); // 0x06e677f4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e6787c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e67bc0
	static System.Void .cctor(); // 0x06e67f68
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.VariableDictionaryLongCustomTypeExampleCfg : WizardGames.Soc.Common.SimpleCustom.VariableCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.CustomTypeExampleCfg> Value; // 0x40
	System.Collections.Generic.List<System.Int64> KeysOfValue; // 0x48
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e68200
	static WizardGames.Soc.Common.SimpleCustom.VariableDictionaryLongCustomTypeExampleCfg VariableDictionaryLongCustomTypeExampleCfgConstructor(); // 0x06e682a4
	System.Void .ctor(); // 0x06e68324
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e683ac
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e68768
	static System.Void .cctor(); // 0x06e68b80
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.VariableItemCountCfg : WizardGames.Soc.Common.SimpleCustom.VariableCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	WizardGames.Soc.Common.SimpleCustom.ItemCountCfg Value; // 0x40
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e68e4c
	static WizardGames.Soc.Common.SimpleCustom.VariableItemCountCfg VariableItemCountCfgConstructor(); // 0x06e68ef0
	System.Void .ctor(); // 0x06e68f70
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e68ff8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e69310
	static System.Void .cctor(); // 0x06e69670
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.VariableListItemCountCfg : WizardGames.Soc.Common.SimpleCustom.VariableCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.ItemCountCfg> Value; // 0x40
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e69908
	static WizardGames.Soc.Common.SimpleCustom.VariableListItemCountCfg VariableListItemCountCfgConstructor(); // 0x06e699ac
	System.Void .ctor(); // 0x06e69a2c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e69ab4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e69df8
	static System.Void .cctor(); // 0x06e6a1a0
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.VariableDictionaryLongItemCountCfg : WizardGames.Soc.Common.SimpleCustom.VariableCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.ItemCountCfg> Value; // 0x40
	System.Collections.Generic.List<System.Int64> KeysOfValue; // 0x48
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e6a438
	static WizardGames.Soc.Common.SimpleCustom.VariableDictionaryLongItemCountCfg VariableDictionaryLongItemCountCfgConstructor(); // 0x06e6a4dc
	System.Void .ctor(); // 0x06e6a55c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e6a5e4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e6a9a0
	static System.Void .cctor(); // 0x06e6adb8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.VariableCfg : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 Name; // 0x10
	System.Boolean NeedSync; // 0x18
	System.String Desc; // 0x20
	WizardGames.Soc.Common.SimpleCustom.EVarScopeType ScopeType; // 0x28
	WizardGames.Soc.Common.SimpleCustom.EVarCreateType CreateType; // 0x30
	System.String DebugTypeName; // 0x38
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e6b084
	static WizardGames.Soc.Common.SimpleCustom.VariableCfg VariableCfgConstructor(); // 0x06e6b108
	System.Void .ctor(); // 0x06e5c3f0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e6b188
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e6b424
	static System.Void .cctor(); // 0x06e6b740
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.VehicleTLogInfo : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 VehicleId; // 0x10
	System.Int64 VehicleGetInTime; // 0x18
	System.Int32 VehicleDuration; // 0x20
	WizardGames.Soc.Common.SimpleCustom.VehicleGetInReason VehicleGetInReason; // 0x24
	WizardGames.Soc.Common.SimpleCustom.VehicleGetOffReason VehicleGetOffReason; // 0x28
	System.Numerics.Vector3 VehicleGetInLocation; // 0x2c
	System.Int32 VehicleDistance; // 0x38
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e6b9a4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e6ba38
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e6bd54
	static System.Void .cctor(); // 0x06e6c0ec
}

// Client.Runtime
struct WizardGames.Soc.Common.SimpleCustom.VisionTree : System.ValueType, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Byte Scale; // 0x10
	System.Int32 RotY; // 0x14
	System.Int32 TemplateId; // 0x18
	System.Single PosX; // 0x1c
	System.Single PosY; // 0x20
	System.Single PosZ; // 0x24
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e6c384
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e6c43c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e6c6c0
	System.Void .ctor(WizardGames.Soc.Common.CustomType.TreeBriefData tree); // 0x06e6c9dc
	static System.Void .cctor(); // 0x06e6cab8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.WakeUpEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent, WizardGames.Soc.Common.Cache.ICacheObject
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e6cd1c
	System.Int32 GetClassHash(); // 0x06e6ce40
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e6cea8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e6d0d0
	System.Void .ctor(); // 0x06e6d3a8
	static WizardGames.Soc.Common.SimpleCustom.WakeUpEvent NewEvent(); // 0x06e6d430
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06e6d4a8
	System.Void Dispose(); // 0x06e6d550
	static System.Void .cctor(); // 0x06e6d630
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.WeaponSimple : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 HoldItemIndex; // 0x10
	System.Int64 TableId; // 0x18
	System.Int64 SkinId; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.AccessorySimple> AccessoryDisplayDatas; // 0x28
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e6d7f8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e6d88c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e6db60
	static System.Void .cctor(); // 0x06e6dec8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.WeaponTLogInfo : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 WeaponId; // 0x10
	System.Int32 WeaponBulletId; // 0x14
	System.Int32 WeaponTime; // 0x18
	System.Int32 WeaponAttackCount; // 0x1c
	System.Int32 WeaponScoreCount; // 0x20
	System.Int32 WeaponScorePlayerCount; // 0x24
	System.Int32 WeaponScoreNPCCount; // 0x28
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e6e0c4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e6e158
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e6e400
	System.Void OnGet(); // 0x06e6e744
	System.Void OnRelease(); // 0x06e6e7a4
	System.Void OnDestroy(); // 0x06e6e810
	static System.Void .cctor(); // 0x06e6e870
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.WorldEntitySpawnRecord : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 EntityType; // 0x10
	System.Int64 TemplateId; // 0x18
	WizardGames.Soc.Common.SimpleCustom.SimpleVector3 Pos; // 0x20
	WizardGames.Soc.Common.SimpleCustom.SimpleVector3 Rot; // 0x28
	System.Int64 BindPlayerId; // 0x30
	System.Int64 PlayerTaskId; // 0x38
	System.Int64 AnchorEntityId; // 0x40
	System.Int32 SpawnResult; // 0x48
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e6eb08
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e6eb9c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e6eee8
	static System.Void .cctor(); // 0x06e6f254
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ChangeWorld : System.Object, WizardGames.Soc.Common.Cache.ICacheObject, WizardGames.Soc.Common.Synchronization.IChangeWorld, Share.Common.ObjPool.IPooledObjectNew
{
	System.Int64 Sequence; // 0x10
	System.UInt64 RoleId; // 0x18
	System.Int64 UserCmdSequence; // 0x20
	System.Int64 WorldTime; // 0x28
	System.Int64 SnapshotSequenceAck; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent> LocationBasedEvents; // 0x38
	System.UInt64 <Mid>k__BackingField; // 0x40
	System.Boolean <IsReturn>k__BackingField; // 0x48
	System.Boolean <CareThreadSafe>k__BackingField; // 0x49
	System.Collections.Generic.HashSet<System.Int64> <WaitingChangeEntities>k__BackingField; // 0x50
	System.UInt64 get_Mid(); // 0x06e6f520
	System.Void set_Mid(System.UInt64 value); // 0x06e6f584
	System.Boolean get_IsReturn(); // 0x06e6f5fc
	System.Void set_IsReturn(System.Boolean value); // 0x06e6f660
	System.Boolean get_CareThreadSafe(); // 0x06e6f6dc
	System.Void set_CareThreadSafe(System.Boolean value); // 0x06e6f740
	System.Void ReturnToPool(); // 0x06e6f7bc
	System.Collections.Generic.HashSet<System.Int64> get_WaitingChangeEntities(); // 0x06e6fa64
	System.Void set_WaitingChangeEntities(System.Collections.Generic.HashSet<System.Int64> value); // 0x06e6fac8
	System.Void .ctor(); // 0x06e6fb48
	System.Void Dispose(); // 0x06e6fcb0
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.IntentionState : System.Object
{
	System.Boolean Active; // 0x10
	System.Boolean ThisFrameChange; // 0x11
	System.Boolean Interrupted; // 0x12
	System.Boolean Cached; // 0x13
	System.Boolean ApplyCached; // 0x14
	System.Void .ctor(); // 0x06e6fd3c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.CmdIntention : System.Object
{
	WizardGames.Soc.Common.SimpleCustom.IntentionState AdsState; // 0x10
	WizardGames.Soc.Common.SimpleCustom.IntentionState SprintState; // 0x18
	WizardGames.Soc.Common.SimpleCustom.IntentionState CrouchState; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.IntentionState> _adsPressedLevel; // 0x28
	System.Collections.Generic.List<System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.IntentionState>> _parallelLevel; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.IntentionState> SprintCacheLevel; // 0x38
	System.Void .ctor(); // 0x06e6fda4
	System.Void ProcessCmd(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.Unity.Character.PlayerLogicParams p); // 0x06e7039c
	static System.Boolean CheckFirstActiveInThisFrame(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.IntentionState> level); // 0x06e71028
	static System.Void CheckFirstActive(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.IntentionState> level); // 0x06e70e98
	static System.Void SetState(WizardGames.Soc.Common.SimpleCustom.IntentionState& state, System.Boolean change, System.Boolean curActive); // 0x06e70b2c
	static System.Boolean GetCmdToggleIntention(System.Boolean curButton, System.Boolean lastButton, System.Boolean lastState, System.Boolean setupPressed); // 0x06e70a80
	static System.Void UpdateSprintCacheToggleIntention(WizardGames.Soc.Common.SimpleCustom.IntentionState& state, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd curCmd, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.IntentionState> cacheLevel); // 0x06e70bcc
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.HorseCmdIntention : System.Object
{
	WizardGames.Soc.Common.SimpleCustom.IntentionState SprintState; // 0x10
	System.Void .ctor(); // 0x06e712d8
	System.Void ProcessCmd(WizardGames.Soc.Common.Entity.HorseEntity horse, WizardGames.Soc.Common.Unity.Horse.HorseLogicParams p); // 0x06e71374
	static System.Void SetState(WizardGames.Soc.Common.SimpleCustom.IntentionState& state, System.Boolean change, System.Boolean curActive); // 0x06e71540
	static System.Boolean GetCmdToggleIntention(System.Boolean curButton, System.Boolean lastButton, System.Boolean lastState, System.Boolean setupPressed); // 0x06e71494
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.KillEventData : System.Object
{
	System.String KillerIcon; // 0x10
	System.String KillerName; // 0x18
	System.Int64 WeaponTableId; // 0x20
	System.Int32 DamageType; // 0x28
	System.Int32 KillType; // 0x2c
	System.String TargetIcon; // 0x30
	System.String TargetName; // 0x38
	System.Int64 serverWorldTime; // 0x40
	
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.Snapshot : System.Object, WizardGames.Soc.Common.Cache.ICacheObject, Share.Common.ObjPool.IPooledObjectNew
{
	static SocLogger logger; // 0x0
	System.Int64 Sequence; // 0x10
	System.Int64 WorldTime; // 0x18
	System.Int32 Interval; // 0x20
	System.Int64 CmdSequenceAck; // 0x28
	System.UInt64 <Mid>k__BackingField; // 0x30
	System.Boolean <IsReturn>k__BackingField; // 0x38
	System.Boolean <CareThreadSafe>k__BackingField; // 0x39
	System.UInt64 get_Mid(); // 0x06e715e0
	System.Void set_Mid(System.UInt64 value); // 0x06e71644
	System.Boolean get_IsReturn(); // 0x06e716bc
	System.Void set_IsReturn(System.Boolean value); // 0x06e71720
	System.Boolean get_CareThreadSafe(); // 0x06e7179c
	System.Void set_CareThreadSafe(System.Boolean value); // 0x06e71800
	System.Void ReturnToPool(); // 0x06e7187c
	static WizardGames.Soc.Common.SimpleCustom.Snapshot NewSnapshot(); // 0x06e718e8
	System.Void .ctor(); // 0x06e71988
	static System.Void Return(WizardGames.Soc.Common.SimpleCustom.Snapshot snapshot); // 0x06e719f0
	System.Void Dispose(); // 0x06e71a5c
	static WizardGames.Soc.Common.SimpleCustom.Snapshot NewSnapshotFromIncrement(WizardGames.Soc.Common.Synchronization.SnapshotIncremental inc); // 0x06e71ae8
	static System.Void .cctor(); // 0x06e71b8c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent : Share.Common.ObjPool.Alpha3PooledObjectBase, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	System.Boolean bFromServer; // 0x1a
	System.Single PosX; // 0x1c
	System.Single PosZ; // 0x20
	System.Int64 SourceId; // 0x28
	System.Int64 Sequence; // 0x30
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1551888510;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	static System.Void .cctor(); // 0x06e71c60
	System.Void .ctor(); // 0x06e6cdc4
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x054e7844
	System.Int32 GetClassHash(); // 0x06e71f5c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e71fc4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e721ec
	System.Void Dispose(); // 0x06e6d5b4
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent.<>c : System.Object
{
	static WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x06e724c4
	System.Void .ctor(); // 0x06e72528
	System.Void <.cctor>b__0_0(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent> value, MessagePack.MessagePackWriter& writer); // 0x06e72590
	System.Void <.cctor>b__0_1(System.Collections.Generic.IList<WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent> value, MessagePack.MessagePackWriter& writer); // 0x06e7265c
}

// Client.Runtime
interface WizardGames.Soc.Common.SimpleCustom.IJsonSerializable : 
{
	
	
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ProtectionData : System.Object
{
	System.Single[] BaseProtection; // 0x10
	System.Single[][] AreaProtection; // 0x18
	System.Single[] ArmorProtection; // 0x20
	System.Void .ctor(); // 0x06e72728
}

// Client.Runtime
enum WizardGames.Soc.Common.SimpleCustom.EPopType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.SimpleCustom.EPopType CommonTips = 0;
	static WizardGames.Soc.Common.SimpleCustom.EPopType CommnTipsWithWindow = 1;
	static WizardGames.Soc.Common.SimpleCustom.EPopType InstantNotification = 2;
	static WizardGames.Soc.Common.SimpleCustom.EPopType LobbyTips = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.SimpleCustom.AutoTurretEventType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.SimpleCustom.AutoTurretEventType SwitchOn = 0;
	static WizardGames.Soc.Common.SimpleCustom.AutoTurretEventType UpdateWeapon = 1;
	static WizardGames.Soc.Common.SimpleCustom.AutoTurretEventType FlakSwitchOn = 2;
	static WizardGames.Soc.Common.SimpleCustom.AutoTurretEventType FlakUpdateWeapon = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.SimpleCustom.DamageType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.SimpleCustom.DamageType Generic = 0;
	static WizardGames.Soc.Common.SimpleCustom.DamageType Hunger = 1;
	static WizardGames.Soc.Common.SimpleCustom.DamageType Thirst = 2;
	static WizardGames.Soc.Common.SimpleCustom.DamageType Cold = 3;
	static WizardGames.Soc.Common.SimpleCustom.DamageType Drowned = 4;
	static WizardGames.Soc.Common.SimpleCustom.DamageType Heat = 5;
	static WizardGames.Soc.Common.SimpleCustom.DamageType Bleeding = 6;
	static WizardGames.Soc.Common.SimpleCustom.DamageType Poison = 7;
	static WizardGames.Soc.Common.SimpleCustom.DamageType Suicide = 8;
	static WizardGames.Soc.Common.SimpleCustom.DamageType Bullet = 9;
	static WizardGames.Soc.Common.SimpleCustom.DamageType Slash = 10;
	static WizardGames.Soc.Common.SimpleCustom.DamageType Blunt = 11;
	static WizardGames.Soc.Common.SimpleCustom.DamageType Fall = 12;
	static WizardGames.Soc.Common.SimpleCustom.DamageType Radiation = 13;
	static WizardGames.Soc.Common.SimpleCustom.DamageType Bite = 14;
	static WizardGames.Soc.Common.SimpleCustom.DamageType Stab = 15;
	static WizardGames.Soc.Common.SimpleCustom.DamageType Explosion = 16;
	static WizardGames.Soc.Common.SimpleCustom.DamageType RadiationExposure = 17;
	static WizardGames.Soc.Common.SimpleCustom.DamageType ColdExposure = 18;
	static WizardGames.Soc.Common.SimpleCustom.DamageType Decay = 19;
	static WizardGames.Soc.Common.SimpleCustom.DamageType ElectricShock = 20;
	static WizardGames.Soc.Common.SimpleCustom.DamageType Arrow = 21;
	static WizardGames.Soc.Common.SimpleCustom.DamageType AntiVehicle = 22;
	static WizardGames.Soc.Common.SimpleCustom.DamageType Collision = 23;
	static WizardGames.Soc.Common.SimpleCustom.DamageType FunWater = 24;
	static WizardGames.Soc.Common.SimpleCustom.DamageType LAST = 25;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.SimpleCustom.EGunshipEvent : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.SimpleCustom.EGunshipEvent None = 0;
	static WizardGames.Soc.Common.SimpleCustom.EGunshipEvent Born = 1;
	static WizardGames.Soc.Common.SimpleCustom.EGunshipEvent Evacuation = 2;
	static WizardGames.Soc.Common.SimpleCustom.EGunshipEvent Destroy = 3;
	static WizardGames.Soc.Common.SimpleCustom.EGunshipEvent LeaveMonument = 4;
	
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.HitSourceInfo : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	System.Int64 EntityID; // 0x10
	System.Int32 EntityType; // 0x18
	System.Int64 TableID; // 0x20
	System.Void OnGet(); // 0x06e72790
	System.Void OnRelease(); // 0x06e727f0
	System.Void OnDestroy(); // 0x06e72864
	System.Void .ctor(); // 0x06e728c4
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.HitRequestEx : System.Object
{
	static System.Func<System.UInt64,System.UInt64,System.Boolean> IsSameTeamFunc; // 0x0
	static System.Boolean IsEnemy(WizardGames.Soc.Common.Entity.PlayerEntity targetPlayerEntity, WizardGames.Soc.Common.Entity.PlayerEntity sourcePlayerEntity); // 0x06e7292c
	static WizardGames.Soc.Common.Data.DamageRelation GetDamageRelation(System.Int64 TargetId, System.Int64 SourceId); // 0x06e72a10
	static System.Void SetDamageRelation(Share.Common.ObjPool.Alpha3PooledObjectBase pooledObject); // 0x06e72f98
	static System.Void SetDamageRelation(WizardGames.Soc.Common.SimpleCustom.HitRequest hitRequest); // 0x06e7304c
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum GetModifiedHitMaterial(WizardGames.Soc.Common.Entity.IEntity target, System.Int32 hitPart); // 0x06e730c0
	static System.Boolean IsAbiotic(WizardGames.Soc.Common.Entity.MonsterEntity monsterEntity); // 0x06e73754
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ICCmdDealer : WizardGames.Soc.Common.SimpleCustom.CmdDealer<WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit>
{
	
	System.Void .ctor(); // 0x06e73874
}

// Client.Runtime
interface WizardGames.Soc.Common.SimpleCustom.ICmd : 
{
	
	System.Boolean OfflineVerify(); // 0x054c4760
}

// Client.Runtime
interface WizardGames.Soc.Common.SimpleCustom.ISnapshot<TSnapshot> : 
{
	
	WizardGames.Soc.Common.SimpleCustom.ISnapshot<TSnapshot> MakeSnapshot(); // 0x054e7844
	System.Void ApplyCmd(WizardGames.Soc.Common.SimpleCustom.ICmd cmd); // 0x05523a54
	System.Boolean GenRevertCmd(WizardGames.Soc.Common.SimpleCustom.ICmd cmd, WizardGames.Soc.Common.SimpleCustom.ICmd& rcmd); // 0x054e0cf4
	System.Boolean OnlineVerify(WizardGames.Soc.Common.SimpleCustom.ICmd cmd); // 0x054dec74
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.CmdDealer<TSnapshot> : System.Object
{
	System.Int32 SnapshotInterval; // 0x0
	System.Int32 SnapshotNum; // 0x0
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.SimpleCustom.ICmd> cmdDic; // 0x0
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.SimpleCustom.ICmd> revertCmdDic; // 0x0
	System.Collections.Generic.LinkedList<System.Tuple<System.Int32,WizardGames.Soc.Common.SimpleCustom.ISnapshot<TSnapshot>>> snapshotQueue; // 0x0
	System.Int32 <cmdNow>k__BackingField; // 0x0
	System.Int32 cmdCount; // 0x0
	WizardGames.Soc.Common.SimpleCustom.ISnapshot<TSnapshot> snapshotNow; // 0x0
	System.Int32 get_cmdNow(); // 0x0548ba98
	System.Void set_cmdNow(System.Int32 value); // 0x055056e8
	System.Void CleanUp(); // 0x055049cc
	System.Boolean OfflineVerify(WizardGames.Soc.Common.SimpleCustom.ICmd cmd); // 0x054dec74
	System.Boolean OnlineVerify(WizardGames.Soc.Common.SimpleCustom.ICmd cmd); // 0x054dec74
	System.Boolean AddCmd(WizardGames.Soc.Common.SimpleCustom.ICmd cmd); // 0x054dec74
	System.Boolean ApplyCmdNow(); // 0x054c4760
	System.Boolean ApplyCmd(System.Int32 cmdTarget); // 0x054c4f88
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
enum WizardGames.Soc.Common.SimpleCustom.EVarCreateType : System.Enum
{
	System.Int64 value__; // 0x10
	static WizardGames.Soc.Common.SimpleCustom.EVarCreateType Custom = 0;
	static WizardGames.Soc.Common.SimpleCustom.EVarCreateType Builtin = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.SimpleCustom.PortDataType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.SimpleCustom.PortDataType Int32 = 0;
	static WizardGames.Soc.Common.SimpleCustom.PortDataType Float = 1;
	static WizardGames.Soc.Common.SimpleCustom.PortDataType String = 2;
	static WizardGames.Soc.Common.SimpleCustom.PortDataType Vector3 = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.SimpleCustom.SwimEventType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.SimpleCustom.SwimEventType Spray = 0;
	static WizardGames.Soc.Common.SimpleCustom.SwimEventType InDive = 1;
	static WizardGames.Soc.Common.SimpleCustom.SwimEventType OutDive = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.SimpleCustom.VehicleGetInReason : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.SimpleCustom.VehicleGetInReason Other = 1;
	static WizardGames.Soc.Common.SimpleCustom.VehicleGetInReason Driver = 2;
	static WizardGames.Soc.Common.SimpleCustom.VehicleGetInReason Passenger = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.SimpleCustom.VehicleGetOffReason : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.SimpleCustom.VehicleGetOffReason Other = 1;
	static WizardGames.Soc.Common.SimpleCustom.VehicleGetOffReason Dismount = 2;
	static WizardGames.Soc.Common.SimpleCustom.VehicleGetOffReason SwitchSeat = 3;
	static WizardGames.Soc.Common.SimpleCustom.VehicleGetOffReason PlayerDie = 4;
	static WizardGames.Soc.Common.SimpleCustom.VehicleGetOffReason VehicleDie = 5;
	static WizardGames.Soc.Common.SimpleCustom.VehicleGetOffReason EquipForbidMount = 6;
	static WizardGames.Soc.Common.SimpleCustom.VehicleGetOffReason LeaveTeam = 7;
	static WizardGames.Soc.Common.SimpleCustom.VehicleGetOffReason BoatFlip = 8;
	static WizardGames.Soc.Common.SimpleCustom.VehicleGetOffReason Offline = 9;
	static WizardGames.Soc.Common.SimpleCustom.VehicleGetOffReason Remove = 10;
	static WizardGames.Soc.Common.SimpleCustom.VehicleGetOffReason DismountSuicide = 11;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.SimpleCustom.EMultiLangStrType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.SimpleCustom.EMultiLangStrType NORMAL = 0;
	static WizardGames.Soc.Common.SimpleCustom.EMultiLangStrType MULTI_LANG = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.SimpleCustom.ETableType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.SimpleCustom.ETableType DATA = 0;
	static WizardGames.Soc.Common.SimpleCustom.ETableType CONFIG = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.SimpleCustom.EEventParamsType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.SimpleCustom.EEventParamsType Bool = 0;
	static WizardGames.Soc.Common.SimpleCustom.EEventParamsType Long = 1;
	static WizardGames.Soc.Common.SimpleCustom.EEventParamsType Float = 2;
	static WizardGames.Soc.Common.SimpleCustom.EEventParamsType String = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.SimpleCustom.EVariableType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.SimpleCustom.EVariableType Bool = 0;
	static WizardGames.Soc.Common.SimpleCustom.EVariableType Long = 1;
	static WizardGames.Soc.Common.SimpleCustom.EVariableType Float = 2;
	static WizardGames.Soc.Common.SimpleCustom.EVariableType String = 3;
	static WizardGames.Soc.Common.SimpleCustom.EVariableType Vector3 = 4;
	static WizardGames.Soc.Common.SimpleCustom.EVariableType Object = 5;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.SimpleCustom.EStatPanelDisplayableMode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.SimpleCustom.EStatPanelDisplayableMode Personal = 0;
	static WizardGames.Soc.Common.SimpleCustom.EStatPanelDisplayableMode Team = 1;
	static WizardGames.Soc.Common.SimpleCustom.EStatPanelDisplayableMode TeamPoints = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.SimpleCustom.EGameResultType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.SimpleCustom.EGameResultType Draw = 0;
	static WizardGames.Soc.Common.SimpleCustom.EGameResultType Victory = 1;
	static WizardGames.Soc.Common.SimpleCustom.EGameResultType Defeat = 2;
	static WizardGames.Soc.Common.SimpleCustom.EGameResultType TimeOver = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.SimpleCustom.EProgressBarType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.SimpleCustom.EProgressBarType RaidAttack = 0;
	static WizardGames.Soc.Common.SimpleCustom.EProgressBarType RaidDefense = 1;
	static WizardGames.Soc.Common.SimpleCustom.EProgressBarType RaidSymmetry = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.SimpleCustom.EServerType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.SimpleCustom.EServerType Warzone = 0;
	static WizardGames.Soc.Common.SimpleCustom.EServerType Room = 1;
	static WizardGames.Soc.Common.SimpleCustom.EServerType UGC = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.SimpleCustom.EVarScopeType : System.Enum
{
	System.Int64 value__; // 0x10
	static WizardGames.Soc.Common.SimpleCustom.EVarScopeType Graph = 0;
	static WizardGames.Soc.Common.SimpleCustom.EVarScopeType Player = 1;
	static WizardGames.Soc.Common.SimpleCustom.EVarScopeType Team = 2;
	static WizardGames.Soc.Common.SimpleCustom.EVarScopeType Local = 3;
	
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.PlayerCustomizeData : System.Object
{
	System.Int32 Sex; // 0x10
	System.Int32 FaceId; // 0x14
	System.Int32 HairId; // 0x18
	System.Int32 HairColorId; // 0x1c
	System.Void .ctor(); // 0x06e738f0
	System.Void .ctor(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06e73958
	System.Void .ctor(WizardGames.Soc.SocClient.GoLoader.IPlayerData playerEntity); // 0x06e73d4c
	System.Void .ctor(System.Int32 sex, System.Int32 faceId, System.Int32 hairId, System.Int32 hairColorId); // 0x06e73a24
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SocHideInInspector : System.Attribute
{
	
	System.Void .ctor(); // 0x06e73f6c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SocDisableSearch : System.Attribute
{
	
	System.Void .ctor(); // 0x06e73fd4
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SocDictKeysAttribute : System.Attribute
{
	System.String FieldName; // 0x10
	System.Void .ctor(System.String fieldName); // 0x06e7403c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SocVarGuidAttribute : System.Attribute
{
	System.Type Type; // 0x10
	System.Boolean IsCanWrite; // 0x18
	System.Void .ctor(System.Type type); // 0x06e740c8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SocGraphGuidAttribute : System.Attribute
{
	
	System.Void .ctor(); // 0x06e7415c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.DataInputAttribute : System.Attribute
{
	WizardGames.Soc.Common.SimpleCustom.EEditType EditType; // 0x10
	System.String DisplayName; // 0x18
	System.Void .ctor(); // 0x06e741c4
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ConstDataIn : System.Attribute
{
	
	System.Void .ctor(); // 0x06e74258
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.DynamicContainer : System.Attribute
{
	
	System.Void .ctor(); // 0x06e742c0
}

// Client.Runtime
enum WizardGames.Soc.Common.SimpleCustom.EEditType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.SimpleCustom.EEditType Const = 0;
	static WizardGames.Soc.Common.SimpleCustom.EEditType Mutable = 1;
	
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.GraphSystemVarAttribute : System.Attribute
{
	System.Int64 VarId; // 0x10
	System.Void .ctor(); // 0x06e74328
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.AirdropControllerEntity : WizardGames.Soc.Share.Framework.EntityBase
{
	static System.Int32 CLASS_HASH = 813973837;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06e74390
	System.String GetTypeName(); // 0x06e743f8
	System.Int32 get_EntityType(); // 0x06e74470
	System.Void .ctor(); // 0x06e744d4
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06e74564
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06e74614
	static System.Object DeserializeAirdropControllerEntityContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e746c4
	static System.Void .cctor(); // 0x06e74794
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.AirdropEntity : WizardGames.Soc.Common.Entity.BoxEntity, WizardGames.Soc.Common.Entity.Interface.IMarkerEntity
{
	static System.Int32 CLASS_HASH = 732085592;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06e749bc
	System.String GetTypeName(); // 0x06e74a24
	System.Int32 get_EntityType(); // 0x06e74a9c
	System.Void .ctor(); // 0x06e74b00
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06e74c18
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06e74d74
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06e74ed0
	System.Boolean get_IsReputationRewardDrop(); // 0x06e74f50
	static System.Void .cctor(); // 0x06e74fb4
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.AirDropPlaneEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.ISmoothCloneEntity
{
	static System.Int32 CLASS_HASH = 301578954;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Single <PosX_Smooth>k__BackingField; // 0x5c
	System.Single <PosY_Smooth>k__BackingField; // 0x60
	System.Single <PosZ_Smooth>k__BackingField; // 0x64
	System.Single <RotateX_Smooth>k__BackingField; // 0x68
	System.Single <RotateY_Smooth>k__BackingField; // 0x6c
	System.Single <RotateZ_Smooth>k__BackingField; // 0x70
	System.Int64 <ParentId>k__BackingField; // 0x78
	System.Int64 <MountID>k__BackingField; // 0x80
	System.Int32 GetClassHash(); // 0x06e757d0
	System.String GetTypeName(); // 0x06e75838
	System.Int32 get_EntityType(); // 0x06e758b0
	System.Void .ctor(); // 0x06e75914
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06e759a4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06e75a54
	System.Single get_PosX(); // 0x06e75b04
	System.Void set_PosX(System.Single value); // 0x06e75b78
	System.Single get_PosY(); // 0x06e75c04
	System.Void set_PosY(System.Single value); // 0x06e75c78
	System.Single get_PosZ(); // 0x06e75d04
	System.Void set_PosZ(System.Single value); // 0x06e75d78
	System.Single get_RotateY(); // 0x06e75e04
	System.Void set_RotateY(System.Single value); // 0x06e75e78
	System.Int64 get_CallerUserId(); // 0x06e75f04
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06e75f78
	System.Single get_PosX_Smooth(); // 0x06e75ff8
	System.Void set_PosX_Smooth(System.Single value); // 0x06e7605c
	System.Single get_PosY_Smooth(); // 0x06e760d4
	System.Void set_PosY_Smooth(System.Single value); // 0x06e76138
	System.Single get_PosZ_Smooth(); // 0x06e761b0
	System.Void set_PosZ_Smooth(System.Single value); // 0x06e76214
	System.Single get_RotateX_Smooth(); // 0x06e7628c
	System.Void set_RotateX_Smooth(System.Single value); // 0x06e762f0
	System.Single get_RotateY_Smooth(); // 0x06e76368
	System.Void set_RotateY_Smooth(System.Single value); // 0x06e763cc
	System.Single get_RotateZ_Smooth(); // 0x06e76444
	System.Void set_RotateZ_Smooth(System.Single value); // 0x06e764a8
	System.Int64 get_ParentId(); // 0x06e76520
	System.Int64 get_MountID(); // 0x06e76584
	System.Boolean get_HasLocalRotation(); // 0x06e765e8
	System.Void CopyPositionAndRotation(UnityEngine.Vector3& pos, UnityEngine.Vector3& rotate); // 0x06e7664c
	System.Void CopyLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation); // 0x06e766f8
	System.Boolean NeedSmooth(UnityEngine.Vector3 lastPos, UnityEngine.Vector3 lastRotate); // 0x06e76774
	static System.Void .cctor(); // 0x06e7682c
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.BaseMountableEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Common.Entity.IBaseMountableEntity, WizardGames.Soc.Common.Entity.ICombatEntity, WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.ISpawnEntity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Share.Framework.IPredictType, CommonUnity.Runtime.Entity.ISeekerTarget
{
	static System.Int32 CLASS_HASH = 669686566;
	static System.Int32 StaticClassHash; // 0x0
	static System.String TYPE_NAME = "BaseMountableEntity";
	System.Single SmoothYawAdd; // 0x5c
	System.Boolean <HasInitProperty>k__BackingField; // 0x60
	WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo; // 0x68
	System.Collections.Generic.List<System.Int64> subscribeIds; // 0x70
	System.Collections.Generic.List<System.Int64> damageableSubscribeIds; // 0x78
	System.Int64 posChangeEventHandle; // 0x80
	WizardGames.Soc.Common.Entity.BaseMountableEntity targetEntity; // 0x88
	System.Int32 _remainLimitedAuthorityTs1; // 0x90
	static System.Int32 Attribution_None = 0;
	static System.Int32 Attribution_Claimed = 1;
	static System.Int32 Attribution_Unclaimed = 2;
	System.Boolean <IsInBornMonument>k__BackingField; // 0x94
	static System.Int32 GUNSHIP_TEMPLATE_ID = 22030011;
	System.Single LastHp; // 0x98
	System.Int64 <LastDriverId>k__BackingField; // 0xa0
	System.Int64 <VehicleLastRepairedTime>k__BackingField; // 0xa8
	System.Single[] <RiderProtection>k__BackingField; // 0xb0
	System.Boolean <HasOtherMountableNearby>k__BackingField; // 0xb8
	System.Single <VelocityX>k__BackingField; // 0xbc
	System.Single <VelocityY>k__BackingField; // 0xc0
	System.Single <VelocityZ>k__BackingField; // 0xc4
	System.Boolean <IsAuthority>k__BackingField; // 0xc8
	System.Int32 <PosKey>k__BackingField; // 0xcc
	System.Int32 GetClassHash(); // 0x06e76e64
	System.String GetTypeName(); // 0x06e76ecc
	System.Void .ctor(); // 0x055049cc
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x055128b0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x05524154
	System.Single get_PosX(); // 0x06e772f0
	System.Void set_PosX(System.Single value); // 0x06e77364
	System.Single get_PosY(); // 0x06e773f0
	System.Void set_PosY(System.Single value); // 0x06e77464
	System.Single get_PosZ(); // 0x06e774f0
	System.Void set_PosZ(System.Single value); // 0x06e77564
	System.Single get_RotateX(); // 0x06e775f0
	System.Void set_RotateX(System.Single value); // 0x06e77664
	System.Single get_RotateY(); // 0x06e776f0
	System.Void set_RotateY(System.Single value); // 0x06e77764
	System.Single get_RotateZ(); // 0x06e777f0
	System.Void set_RotateZ(System.Single value); // 0x06e77864
	System.Int32 get_SpeedInt(); // 0x06e778f0
	System.Void set_SpeedInt(System.Int32 value); // 0x06e77964
	System.Int32 get_Flag(); // 0x06e779f0
	System.Void set_Flag(System.Int32 value); // 0x06e77a64
	System.Int64 get_TableId(); // 0x06e77af0
	System.Void set_TableId(System.Int64 value); // 0x06e77b64
	System.Boolean get_IsGround(); // 0x06e77bf0
	System.Void set_IsGround(System.Boolean value); // 0x06e77c64
	System.Int64 get_Seat1Id(); // 0x06e77cf0
	System.Void set_Seat1Id(System.Int64 value); // 0x06e77d64
	System.Int64 get_Seat2Id(); // 0x06e77df0
	System.Void set_Seat2Id(System.Int64 value); // 0x06e77e64
	System.Int64 get_Seat3Id(); // 0x06e77ef0
	System.Void set_Seat3Id(System.Int64 value); // 0x06e77f64
	System.Int64 get_Seat4Id(); // 0x06e77ff0
	System.Void set_Seat4Id(System.Int64 value); // 0x06e78064
	System.Int64 get_Seat5Id(); // 0x06e780f0
	System.Void set_Seat5Id(System.Int64 value); // 0x06e78164
	System.Int64 get_Seat6Id(); // 0x06e781f0
	System.Void set_Seat6Id(System.Int64 value); // 0x06e78264
	System.Int64 get_Seat7Id(); // 0x06e782f0
	System.Void set_Seat7Id(System.Int64 value); // 0x06e78364
	System.Int64 get_Seat8Id(); // 0x06e783f0
	System.Void set_Seat8Id(System.Int64 value); // 0x06e78464
	System.Int64 get_Seat9Id(); // 0x06e784f0
	System.Void set_Seat9Id(System.Int64 value); // 0x06e78564
	System.Int64 get_Seat10Id(); // 0x06e785f0
	System.Void set_Seat10Id(System.Int64 value); // 0x06e78664
	System.Int64 get_TemplateId(); // 0x06e786f0
	System.Int32 get_VehicleType(); // 0x06e78764
	System.Void set_VehicleType(System.Int32 value); // 0x06e787d8
	System.Int64 get_DriverId(); // 0x06e78864
	System.Void set_DriverId(System.Int64 value); // 0x06e788d8
	System.Single get_Fuel(); // 0x06e78964
	System.Void set_Fuel(System.Single value); // 0x06e789d8
	System.Single get_MaxFuel(); // 0x06e78a64
	System.Void set_MaxFuel(System.Single value); // 0x06e78ad8
	System.Int32 get_Decoy(); // 0x06e78b64
	System.Int64 get_VehicleLastAttackedTime(); // 0x06e78bd8
	System.Void set_VehicleLastAttackedTime(System.Int64 value); // 0x06e78c4c
	System.Boolean get_CanDecay(); // 0x06e78cd8
	System.Void set_CanDecay(System.Boolean value); // 0x06e78d4c
	System.Single get_Power(); // 0x06e78dd8
	System.Void set_Power(System.Single value); // 0x06e78e4c
	System.Single get_MountableMaxSpeed(); // 0x06e78ed8
	System.Void set_MountableMaxSpeed(System.Single value); // 0x06e78f4c
	System.Single get_FuelConsumption(); // 0x06e78fd8
	System.Void set_FuelConsumption(System.Single value); // 0x06e7904c
	System.Boolean get_IsForceServerAuthority(); // 0x06e790d8
	System.Void set_IsForceServerAuthority(System.Boolean value); // 0x06e7914c
	System.Void set_IsSleep(System.Boolean value); // 0x06e791d8
	System.Int32 get_Attribution(); // 0x06e79264
	System.Void set_Attribution(System.Int32 value); // 0x06e792d8
	System.Int32 get_SpawnType(); // 0x06e79364
	System.Boolean get_IsGanRaoDanUsing(); // 0x06e793d8
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06e7944c
	WizardGames.Soc.Share.Framework.IPredictType GetNewInstance(System.Int64 id); // 0x06e794cc
	System.Void SubscribePropertyChange(WizardGames.Soc.Common.Entity.BaseMountableEntity target, WizardGames.Soc.Common.Unity.Go.BaseMountableGo _mountableGo); // 0x0552af00
	System.Void SyncServerProperty2Local(WizardGames.Soc.Common.Entity.BaseMountableEntity target); // 0x06e7a764
	System.Void UnSubscribePropertyChange(); // 0x055049cc
	System.Void OnTransformChange(WizardGames.Soc.Share.Framework.PositionChangeEvent e); // 0x05523a54
	System.Void OnFlagChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.Entity.BaseMountableEntity target); // 0x06e7ae74
	System.Void OnIsGroundChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue, WizardGames.Soc.Common.Entity.BaseMountableEntity target); // 0x06e7af7c
	System.Void OnSeat1IdChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.Entity.BaseMountableEntity target); // 0x05527280
	System.Void OnSeat2IdChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.Entity.BaseMountableEntity target); // 0x05527280
	System.Void OnSeat3IdChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.Entity.BaseMountableEntity target); // 0x05527280
	System.Void OnSeat4IdChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.Entity.BaseMountableEntity target); // 0x05527280
	System.Void OnSeat5IdChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.Entity.BaseMountableEntity target); // 0x05527280
	System.Void OnSeat6IdChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.Entity.BaseMountableEntity target); // 0x05527280
	System.Void OnSeat7IdChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.Entity.BaseMountableEntity target); // 0x05527280
	System.Void OnSeat8IdChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.Entity.BaseMountableEntity target); // 0x05527280
	System.Void OnSeat9IdChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.Entity.BaseMountableEntity target); // 0x05527280
	System.Void OnSeat10IdChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.Entity.BaseMountableEntity target); // 0x05527280
	System.Void OnDriverIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.Entity.BaseMountableEntity target); // 0x06e7b714
	System.Void OnFuelChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Entity.BaseMountableEntity target); // 0x06e7b7bc
	System.Void OnMaxFuelChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Entity.BaseMountableEntity target); // 0x06e7b8bc
	System.Void OnVehicleLastAttackedTimeChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.Entity.BaseMountableEntity target); // 0x06e7b9bc
	System.Void OnCanDecayChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue, WizardGames.Soc.Common.Entity.BaseMountableEntity target); // 0x06e7ba64
	System.Void OnPowerChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Entity.BaseMountableEntity target); // 0x06e7bb0c
	System.Void OnMountableMaxSpeedChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Entity.BaseMountableEntity target); // 0x06e7bbb4
	System.Void OnFuelConsumptionChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Entity.BaseMountableEntity target); // 0x06e7bc5c
	System.Void OnIsForceServerAuthorityChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue, WizardGames.Soc.Common.Entity.BaseMountableEntity target); // 0x06e7bd04
	System.Void OnMaxHpChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Entity.BaseMountableEntity target); // 0x06e7bdac
	System.Void OnHpChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Entity.BaseMountableEntity target); // 0x06e7bf10
	System.Void OnAttributionChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.Entity.BaseMountableEntity target); // 0x06e7c074
	System.Int64 GetOwnerId(); // 0x06e7c11c
	System.Int64 get_TableID(); // 0x06e7c180
	System.Boolean IsValid(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06e7c1e4
	System.Boolean get_CanBeShot(); // 0x06e7c3e0
	UnityEngine.Vector3 get_SeekingPos(); // 0x06e7c450
	UnityEngine.Vector3 GetSeekingPosSmooth(System.Int64 renderTime); // 0x06e7c628
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Boolean> get_TargeterInfos(); // 0x06e7c944
	WizardGames.Soc.Share.Framework.BasicTypeList<System.Int64> get_SeekerIds(); // 0x06e7ca58
	System.Boolean get_IsInBornMonument(); // 0x054c4760
	System.Void .ctor(System.Int64 id); // 0x055112ac
	System.Int64 get_VehicleLastRepairedTime(); // 0x054a4380
	System.Single[] get_RiderProtection(); // 0x054e7844
	System.Void set_RiderProtection(System.Single[] value); // 0x05523a54
	System.Int32 get_DriversCount(); // 0x06e7ce94
	System.Single get_VelocityX(); // 0x054a5abc
	System.Void set_VelocityX(System.Single value); // 0x05513724
	System.Single get_VelocityY(); // 0x054a5abc
	System.Void set_VelocityY(System.Single value); // 0x05513724
	System.Single get_VelocityZ(); // 0x054a5abc
	System.Void set_VelocityZ(System.Single value); // 0x05513724
	System.Single get_HpRate(); // 0x06e7d198
	System.Single get_Hp(); // 0x06e7c32c
	System.Void set_Hp(System.Single value); // 0x06e7bfb8
	System.Single get_MaxHp(); // 0x06e7d21c
	System.Void set_MaxHp(System.Single value); // 0x06e7be54
	System.Collections.Generic.IEnumerable<System.Int64> GetSeatedIds(); // 0x054e7844
	System.Int32 get_RemainLimitedAuthorityTs(); // 0x06e7d404
	System.Boolean get_IsAuthority(); // 0x054c4760
	System.Void set_IsAuthority(System.Boolean value); // 0x05523a7c
	System.Boolean HasAnyMounted(); // 0x06e7d548
	System.Void RefreshAttribution(); // 0x06e7d650
	System.Void Cleanup(System.Boolean isDestroy); // 0x06e7d6b0
	static System.Void .cctor(); // 0x06e7d820
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.BaseMountableEntity.<>c__DisplayClass133_0 : System.Object
{
	WizardGames.Soc.Common.Entity.BaseMountableEntity <>4__this; // 0x10
	WizardGames.Soc.Common.Entity.BaseMountableEntity target; // 0x18
	System.Void .ctor(); // 0x055049cc
	System.Void <SubscribePropertyChange>b__0(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x05525bf4
	System.Void <SubscribePropertyChange>b__1(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x0552b2a8
	System.Void <SubscribePropertyChange>b__2(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x05527160
	System.Void <SubscribePropertyChange>b__3(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x05527160
	System.Void <SubscribePropertyChange>b__4(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x05527160
	System.Void <SubscribePropertyChange>b__5(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x05527160
	System.Void <SubscribePropertyChange>b__6(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x05527160
	System.Void <SubscribePropertyChange>b__7(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x05527160
	System.Void <SubscribePropertyChange>b__8(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x05527160
	System.Void <SubscribePropertyChange>b__9(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x05527160
	System.Void <SubscribePropertyChange>b__10(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x05527160
	System.Void <SubscribePropertyChange>b__11(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x05527160
	System.Void <SubscribePropertyChange>b__12(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x05527728
	System.Void <SubscribePropertyChange>b__13(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x05527728
	System.Void <SubscribePropertyChange>b__14(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x05527160
	System.Void <SubscribePropertyChange>b__15(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x05527728
	System.Void <SubscribePropertyChange>b__16(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x05527728
	System.Void <SubscribePropertyChange>b__17(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x05527160
	System.Void <SubscribePropertyChange>b__18(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x0552b2a8
	System.Void <SubscribePropertyChange>b__19(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x05527728
	System.Void <SubscribePropertyChange>b__20(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x05527728
	System.Void <SubscribePropertyChange>b__21(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x05527728
	System.Void <SubscribePropertyChange>b__22(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x0552b2a8
	System.Void <SubscribePropertyChange>b__23(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x05525bf4
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.BaseMountableEntity.<GetSeatedIds>d__229 : System.Object, System.Collections.Generic.IEnumerable<System.Int64>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Int64>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Int64 <>2__current; // 0x18
	System.Int32 <>l__initialThreadId; // 0x20
	WizardGames.Soc.Common.Entity.BaseMountableEntity <>4__this; // 0x28
	System.Void .ctor(System.Int32 <>1__state); // 0x055056e8
	System.Void System.IDisposable.Dispose(); // 0x055049cc
	System.Boolean MoveNext(); // 0x054c4760
	System.Int64 System.Collections.Generic.IEnumerator<System.Int64>.get_Current(); // 0x054a4380
	System.Void System.Collections.IEnumerator.Reset(); // 0x055049cc
	System.Object System.Collections.IEnumerator.get_Current(); // 0x054e7844
	System.Collections.Generic.IEnumerator<System.Int64> System.Collections.Generic.IEnumerable<System.Int64>.GetEnumerator(); // 0x054e7844
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x054e7844
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.BaseVehicleEntity : WizardGames.Soc.Common.Entity.BaseMountableEntity, WizardGames.Soc.Common.Entity.IBaseVehicleEntity, WizardGames.Soc.Common.Entity.IBaseMountableEntity, WizardGames.Soc.Common.Entity.ICombatEntity, WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.ISpawnEntity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity
{
	static System.Int32 CLASS_HASH = 1750139043;
	static System.Int32 StaticClassHash; // 0x0
	static System.String TYPE_NAME = "BaseVehicleEntity";
	System.Boolean IsClient; // 0xd0
	System.Int32 GetClassHash(); // 0x06e7ee78
	System.String GetTypeName(); // 0x06e7eee0
	System.Void .ctor(); // 0x06e7ef58
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06e7efe0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06e7f08c
	System.Single get_Steering(); // 0x06e7f138
	System.Void set_Steering(System.Single value); // 0x06e7f1ac
	System.Single get_GasPedal(); // 0x06e7f238
	System.Void set_GasPedal(System.Single value); // 0x06e7f2ac
	System.Single get_Break(); // 0x06e7f338
	System.Void set_Break(System.Single value); // 0x06e7f3ac
	System.Single get_Throttle(); // 0x06e7f438
	System.Void set_Throttle(System.Single value); // 0x06e7f4ac
	System.Boolean get_LightsAreOn(); // 0x06e7f538
	System.Void set_LightsAreOn(System.Boolean value); // 0x06e7f5ac
	System.Single get_DriveWheelVelocity(); // 0x06e7f638
	System.Void set_DriveWheelVelocity(System.Single value); // 0x06e7f6ac
	System.Single get_SteerAngle(); // 0x06e7f738
	System.Void set_SteerAngle(System.Single value); // 0x06e7f7ac
	System.Single get_DriveWheelSlip(); // 0x06e7f838
	System.Void set_DriveWheelSlip(System.Single value); // 0x06e7f8ac
	System.Boolean get_IsGrounded(); // 0x06e7f938
	System.Void set_IsGrounded(System.Boolean value); // 0x06e7f9ac
	System.Boolean get_IsEngineStartFailed(); // 0x06e7fa38
	System.Void set_IsEngineStartFailed(System.Boolean value); // 0x06e7faac
	System.Boolean get_IsInterior(); // 0x06e7fb38
	System.Void set_IsInterior(System.Boolean value); // 0x06e7fbac
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06e7fc38
	System.Void SubscribePropertyChange(WizardGames.Soc.Common.Entity.BaseVehicleEntity target, WizardGames.Soc.Common.Unity.Go.BaseMountableGo _mountableGo); // 0x0552af00
	System.Void SyncServerProperty2Local(WizardGames.Soc.Common.Entity.BaseMountableEntity target); // 0x06e806c4
	System.Void UnSubscribePropertyChange(); // 0x06e80834
	System.Void OnSteeringChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Entity.BaseVehicleEntity target); // 0x06e80898
	System.Void OnGasPedalChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Entity.BaseVehicleEntity target); // 0x06e809a0
	System.Void OnBreakChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Entity.BaseVehicleEntity target); // 0x06e80aa8
	System.Void OnThrottleChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Entity.BaseVehicleEntity target); // 0x06e80bb0
	System.Void OnLightsAreOnChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue, WizardGames.Soc.Common.Entity.BaseVehicleEntity target); // 0x06e80cb8
	System.Void OnDriveWheelVelocityChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Entity.BaseVehicleEntity target); // 0x06e80dc0
	System.Void OnSteerAngleChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Entity.BaseVehicleEntity target); // 0x06e80ec8
	System.Void OnDriveWheelSlipChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Entity.BaseVehicleEntity target); // 0x06e80f70
	System.Void OnIsGroundedChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue, WizardGames.Soc.Common.Entity.BaseVehicleEntity target); // 0x06e81078
	System.Void OnIsEngineStartFailedChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue, WizardGames.Soc.Common.Entity.BaseVehicleEntity target); // 0x06e81180
	System.Void OnSpeedIntChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.Entity.BaseVehicleEntity target); // 0x06e81288
	System.Void OnSteerAngleIntChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.Entity.BaseVehicleEntity target); // 0x06e81330
	System.Void OnIsInterior(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue, WizardGames.Soc.Common.Entity.BaseVehicleEntity target); // 0x06e813f4
	System.Void .ctor(System.Int64 id); // 0x06e8149c
	static System.Void .cctor(); // 0x06e8153c
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.BaseVehicleEntity.<>c__DisplayClass55_0 : System.Object
{
	WizardGames.Soc.Common.Entity.BaseVehicleEntity <>4__this; // 0x10
	WizardGames.Soc.Common.Entity.BaseVehicleEntity target; // 0x18
	System.Void .ctor(); // 0x06e8065c
	System.Void <SubscribePropertyChange>b__0(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x06e8158c
	System.Void <SubscribePropertyChange>b__1(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x06e81638
	System.Void <SubscribePropertyChange>b__2(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x06e816e4
	System.Void <SubscribePropertyChange>b__3(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x06e81790
	System.Void <SubscribePropertyChange>b__4(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x06e8183c
	System.Void <SubscribePropertyChange>b__5(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x06e818e8
	System.Void <SubscribePropertyChange>b__6(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x06e81994
	System.Void <SubscribePropertyChange>b__7(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x06e81a40
	System.Void <SubscribePropertyChange>b__8(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x06e81aec
	System.Void <SubscribePropertyChange>b__9(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x06e81b98
	System.Void <SubscribePropertyChange>b__10(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x06e81c44
	System.Void <SubscribePropertyChange>b__11(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x06e81cf0
	System.Void <SubscribePropertyChange>b__12(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x06e81d9c
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.BeeBuzzGroupEntity : WizardGames.Soc.Common.Entity.MonumentGroupEntity
{
	static System.Int32 CLASS_HASH = 1731212651;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06e81e48
	System.String GetTypeName(); // 0x06e81eb0
	System.Int32 get_EntityType(); // 0x06e81f28
	System.Void .ctor(); // 0x06e81f8c
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06e82018
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06e820c8
	System.Single get_PosX(); // 0x06e82178
	System.Single get_PosY(); // 0x06e821ec
	System.Single get_PosZ(); // 0x06e82260
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06e822d4
	static System.Object DeserializeBeeBuzzGroupEntityContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e82354
	static System.Void .cctor(); // 0x06e82428
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.BonusRocketEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Common.Entity.ISmoothCloneEntity
{
	static System.Int32 CLASS_HASH = 1267769000;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Single <PosX_Smooth>k__BackingField; // 0x5c
	System.Single <PosY_Smooth>k__BackingField; // 0x60
	System.Single <PosZ_Smooth>k__BackingField; // 0x64
	System.Single <RotateX_Smooth>k__BackingField; // 0x68
	System.Single <RotateY_Smooth>k__BackingField; // 0x6c
	System.Single <RotateZ_Smooth>k__BackingField; // 0x70
	System.Int64 <ParentId>k__BackingField; // 0x78
	System.Int64 <MountID>k__BackingField; // 0x80
	System.Int32 GetClassHash(); // 0x06e82720
	System.String GetTypeName(); // 0x06e82788
	System.Int32 get_EntityType(); // 0x06e82800
	System.Void .ctor(); // 0x06e82864
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06e828f4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06e829a4
	System.Single get_PosX(); // 0x06e82a54
	System.Void set_PosX(System.Single value); // 0x06e82ac8
	System.Single get_PosY(); // 0x06e82b54
	System.Void set_PosY(System.Single value); // 0x06e82bc8
	System.Single get_PosZ(); // 0x06e82c54
	System.Void set_PosZ(System.Single value); // 0x06e82cc8
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06e82d54
	System.Single get_PosX_Smooth(); // 0x06e82dd4
	System.Void set_PosX_Smooth(System.Single value); // 0x06e82e38
	System.Single get_PosY_Smooth(); // 0x06e82eb0
	System.Void set_PosY_Smooth(System.Single value); // 0x06e82f14
	System.Single get_PosZ_Smooth(); // 0x06e82f8c
	System.Void set_PosZ_Smooth(System.Single value); // 0x06e82ff0
	System.Single get_RotateX_Smooth(); // 0x06e83068
	System.Void set_RotateX_Smooth(System.Single value); // 0x06e830cc
	System.Single get_RotateY_Smooth(); // 0x06e83144
	System.Void set_RotateY_Smooth(System.Single value); // 0x06e831a8
	System.Single get_RotateZ_Smooth(); // 0x06e83220
	System.Void set_RotateZ_Smooth(System.Single value); // 0x06e83284
	System.Int64 get_ParentId(); // 0x06e832fc
	System.Int64 get_MountID(); // 0x06e83360
	System.Boolean get_HasLocalRotation(); // 0x06e833c4
	System.Void CopyPositionAndRotation(UnityEngine.Vector3& pos, UnityEngine.Vector3& rotate); // 0x06e83428
	System.Void CopyLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation); // 0x06e834c8
	System.Boolean NeedSmooth(UnityEngine.Vector3 lastPos, UnityEngine.Vector3 lastRotate); // 0x06e83544
	static System.Void .cctor(); // 0x06e835fc
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.BoxEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Common.Entity.ISpawnEntity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.ICombatEntity, WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Common.Entity.IAttachedEntity, WizardGames.Soc.Common.Entity.ISmoothCloneEntity
{
	static System.Int32 CLASS_HASH = 8946699;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	UnityEngine.Transform <AttachedTransform>k__BackingField; // 0x60
	System.Single <PosX_Smooth>k__BackingField; // 0x68
	System.Single <PosY_Smooth>k__BackingField; // 0x6c
	System.Single <PosZ_Smooth>k__BackingField; // 0x70
	System.Single <RotateX_Smooth>k__BackingField; // 0x74
	System.Single <RotateY_Smooth>k__BackingField; // 0x78
	System.Single <RotateZ_Smooth>k__BackingField; // 0x7c
	System.Int64 <MountID>k__BackingField; // 0x80
	System.Int32 GetClassHash(); // 0x06e837f0
	System.String GetTypeName(); // 0x06e83858
	System.Int32 get_EntityType(); // 0x06e838d0
	System.Void .ctor(); // 0x06e74b88
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06e74cc4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06e74e20
	System.Int64 get_TemplateId(); // 0x06e83934
	System.Int32 get_SpawnType(); // 0x06e839a8
	System.Boolean get_ParachuteDisable(); // 0x06e83a1c
	System.Void set_ParachuteDisable(System.Boolean value); // 0x06e83a90
	System.Single get_PosX(); // 0x06e83b1c
	System.Void set_PosX(System.Single value); // 0x06e83b90
	System.Single get_PosY(); // 0x06e83c1c
	System.Void set_PosY(System.Single value); // 0x06e83c90
	System.Single get_PosZ(); // 0x06e83d1c
	System.Void set_PosZ(System.Single value); // 0x06e83d90
	System.Single get_RotateX(); // 0x06e83e1c
	System.Void set_RotateX(System.Single value); // 0x06e83e90
	System.Single get_RotateY(); // 0x06e83f1c
	System.Void set_RotateY(System.Single value); // 0x06e83f90
	System.Single get_RotateZ(); // 0x06e8401c
	System.Void set_RotateZ(System.Single value); // 0x06e84090
	System.Int32 get_BoxStateID(); // 0x06e8411c
	System.Int64 get_CountDownStartTime(); // 0x06e84190
	System.Int64 get_CountDownFinishTime(); // 0x06e84204
	System.Int32 get_MonumentId(); // 0x06e84278
	System.Int64 get_PlayerId(); // 0x06e842ec
	System.Int64 get_TargetEntityID(); // 0x06e84360
	System.Void set_TargetEntityID(System.Int64 value); // 0x06e843d4
	System.Int32 get_TargetColliderIndex(); // 0x06e84460
	System.Void set_TargetColliderIndex(System.Int32 value); // 0x06e844d4
	System.Single get_PosOffsetX(); // 0x06e84560
	System.Void set_PosOffsetX(System.Single value); // 0x06e845d4
	System.Single get_PosOffsetY(); // 0x06e84660
	System.Void set_PosOffsetY(System.Single value); // 0x06e846d4
	System.Single get_PosOffsetZ(); // 0x06e84760
	System.Void set_PosOffsetZ(System.Single value); // 0x06e847d4
	System.Single get_RotOffsetX(); // 0x06e84860
	System.Void set_RotOffsetX(System.Single value); // 0x06e848d4
	System.Single get_RotOffsetY(); // 0x06e84960
	System.Void set_RotOffsetY(System.Single value); // 0x06e849d4
	System.Single get_RotOffsetZ(); // 0x06e84a60
	System.Void set_RotOffsetZ(System.Single value); // 0x06e84ad4
	System.Single get_RotOffsetW(); // 0x06e84b60
	System.Void set_RotOffsetW(System.Single value); // 0x06e84bd4
	System.Boolean get_IsOpen(); // 0x06e84c60
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06e84cd4
	System.Void set_AttachedTransform(UnityEngine.Transform value); // 0x06e84d54
	WizardGames.Soc.Common.Component.BoxComponent get_ComponentBox(); // 0x06e84dd4
	WizardGames.Soc.Common.Component.RootNodeComponent get_RootNode(); // 0x06e84e90
	System.Void Init(); // 0x06e84f10
	System.Single get_PosX_Smooth(); // 0x06e84fb0
	System.Void set_PosX_Smooth(System.Single value); // 0x06e85014
	System.Single get_PosY_Smooth(); // 0x06e8508c
	System.Void set_PosY_Smooth(System.Single value); // 0x06e850f0
	System.Single get_PosZ_Smooth(); // 0x06e85168
	System.Void set_PosZ_Smooth(System.Single value); // 0x06e851cc
	System.Single get_RotateX_Smooth(); // 0x06e85244
	System.Void set_RotateX_Smooth(System.Single value); // 0x06e852a8
	System.Single get_RotateY_Smooth(); // 0x06e85320
	System.Void set_RotateY_Smooth(System.Single value); // 0x06e85384
	System.Single get_RotateZ_Smooth(); // 0x06e853fc
	System.Void set_RotateZ_Smooth(System.Single value); // 0x06e85460
	System.Int64 get_ParentId(); // 0x06e854d8
	System.Int64 get_MountID(); // 0x06e8553c
	System.Boolean get_HasLocalRotation(); // 0x06e855a0
	System.Void CopyPositionAndRotation(UnityEngine.Vector3& pos, UnityEngine.Vector3& rotate); // 0x06e85604
	System.Void CopyLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation); // 0x06e856c8
	System.Boolean NeedSmooth(UnityEngine.Vector3 lastPos, UnityEngine.Vector3 lastRotate); // 0x06e857b8
	System.String ToPrettyString(); // 0x06e85870
	static System.Void .cctor(); // 0x06e85b48
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.BulletEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.Ability.IProjectile, WizardGames.Soc.Common.Entity.Ability.IHitTargetHistory, IPredictHitTarget, WizardGames.Soc.Common.Entity.ISmoothCloneEntity
{
	static System.Int32 CLASS_HASH = 429315459;
	static System.Int32 StaticClassHash; // 0x0
	static System.String TYPE_NAME = "BulletEntity";
	static System.String[] PropNameArray; // 0x8
	System.Single <PosX_Smooth>k__BackingField; // 0x5c
	System.Single <PosY_Smooth>k__BackingField; // 0x60
	System.Single <PosZ_Smooth>k__BackingField; // 0x64
	System.Single <RotateX_Smooth>k__BackingField; // 0x68
	System.Single <RotateY_Smooth>k__BackingField; // 0x6c
	System.Single <RotateZ_Smooth>k__BackingField; // 0x70
	System.Int64 <ParentId>k__BackingField; // 0x78
	System.Int64 <MountID>k__BackingField; // 0x80
	System.Boolean <IsWhizSoundHappened>k__BackingField; // 0x88
	System.Boolean <Predict>k__BackingField; // 0x89
	System.Boolean <Destroy>k__BackingField; // 0x8a
	System.Single <PowerForVelocity>k__BackingField; // 0x8c
	System.Numerics.Vector3 <Acceleration>k__BackingField; // 0x90
	System.Int64 <OwnerTableID>k__BackingField; // 0xa0
	System.Single <MoveTime>k__BackingField; // 0xa8
	System.Int32 <NowSequence>k__BackingField; // 0xac
	System.Int32 <StartSequence>k__BackingField; // 0xb0
	System.Numerics.Vector3 <CmdEyePosition>k__BackingField; // 0xb4
	System.Single <DamageScale>k__BackingField; // 0xc0
	System.Int64 <WeaponTableID>k__BackingField; // 0xc8
	System.Int32 <FuzeDuration>k__BackingField; // 0xd0
	System.Int32 <BulletIndex>k__BackingField; // 0xd4
	System.Boolean <MagicBullet>k__BackingField; // 0xd8
	System.Int32 <skillTime>k__BackingField; // 0xdc
	System.Boolean <IsServer>k__BackingField; // 0xe0
	System.Numerics.Vector3 <SourceEntityPosition>k__BackingField; // 0xe4
	System.Single <AdsProgress>k__BackingField; // 0xf0
	System.Int32 <SourceMoveState>k__BackingField; // 0xf4
	System.Int32 <SourcePoseState>k__BackingField; // 0xf8
	System.Int32 <SourceMonumentID>k__BackingField; // 0xfc
	System.Int64 <LocalTime>k__BackingField; // 0x100
	System.Boolean <HitScreenBox>k__BackingField; // 0x108
	System.Single <TotalMoveDistance>k__BackingField; // 0x10c
	System.Int64 <ThrowWeaponId>k__BackingField; // 0x110
	System.Int32 <Tag>k__BackingField; // 0x118
	System.Collections.Generic.HashSet<System.Int64> targetHistory; // 0x120
	System.Collections.Generic.HashSet<System.Int64> preditcHits; // 0x128
	System.Boolean <HitWater>k__BackingField; // 0x130
	System.Int32 GetClassHash(); // 0x06e86304
	System.String GetTypeName(); // 0x06e8636c
	System.Int32 get_EntityType(); // 0x06e863e4
	System.Void .ctor(); // 0x06e86448
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06e8655c
	System.Single get_PosX(); // 0x06e86690
	System.Void set_PosX(System.Single value); // 0x06e86704
	System.Single get_PosY(); // 0x06e86790
	System.Void set_PosY(System.Single value); // 0x06e86804
	System.Single get_PosZ(); // 0x06e86890
	System.Void set_PosZ(System.Single value); // 0x06e86904
	System.Single get_ForwardX(); // 0x06e86990
	System.Void set_ForwardX(System.Single value); // 0x06e86a04
	System.Single get_ForwardY(); // 0x06e86a90
	System.Void set_ForwardY(System.Single value); // 0x06e86b04
	System.Single get_ForwardZ(); // 0x06e86b90
	System.Void set_ForwardZ(System.Single value); // 0x06e86c04
	System.Int32 get_TemplateId(); // 0x06e86c90
	System.Int64 get_WeaponId(); // 0x06e86d04
	System.Void set_WeaponId(System.Int64 value); // 0x06e86d78
	System.Int64 get_TableId(); // 0x06e86e04
	System.Void set_TableId(System.Int64 value); // 0x06e86e78
	System.Int64 get_OwnerEntityId(); // 0x06e72f24
	System.Void set_OwnerEntityId(System.Int64 value); // 0x06e86f04
	System.Single get_CreateTime(); // 0x06e86f90
	System.Void set_CreateTime(System.Single value); // 0x06e87004
	System.Int32 get_OwnerEntityType(); // 0x06e87090
	System.Void set_OwnerEntityType(System.Int32 value); // 0x06e87104
	System.Int32 get_PveAttFix(); // 0x06e87190
	System.Void set_PveAttFix(System.Int32 value); // 0x06e87204
	System.Single get_Power(); // 0x06e87290
	System.Void set_Power(System.Single value); // 0x06e87304
	System.Int32 get_PierceNum(); // 0x06e87390
	System.Void set_PierceNum(System.Int32 value); // 0x06e87404
	System.Int64 get_SkinID(); // 0x06e87490
	System.Void set_SkinID(System.Int64 value); // 0x06e87504
	System.Single get_BornPosX(); // 0x06e87590
	System.Void set_BornPosX(System.Single value); // 0x06e87604
	System.Single get_BornPosY(); // 0x06e87690
	System.Void set_BornPosY(System.Single value); // 0x06e87704
	System.Single get_BornPosZ(); // 0x06e87790
	System.Void set_BornPosZ(System.Single value); // 0x06e87804
	System.Single get_VelocityX(); // 0x06e87890
	System.Void set_VelocityX(System.Single value); // 0x06e87904
	System.Single get_VelocityY(); // 0x06e87990
	System.Void set_VelocityY(System.Single value); // 0x06e87a04
	System.Single get_VelocityZ(); // 0x06e87a90
	System.Void set_VelocityZ(System.Single value); // 0x06e87b04
	System.Int64 get_TargetEntityId(); // 0x06e87b90
	System.Void set_TargetEntityId(System.Int64 value); // 0x06e87c04
	System.Single get_TargetPredictionX(); // 0x06e87c90
	System.Void set_TargetPredictionX(System.Single value); // 0x06e87d04
	System.Single get_TargetPredictionY(); // 0x06e87d90
	System.Void set_TargetPredictionY(System.Single value); // 0x06e87e04
	System.Single get_TargetPredictionZ(); // 0x06e87e90
	System.Void set_TargetPredictionZ(System.Single value); // 0x06e87f04
	System.Boolean get_DestroyEffect(); // 0x06e87f90
	System.Void set_DestroyEffect(System.Boolean value); // 0x06e88004
	System.Void set_DisplayByEvent(System.Boolean value); // 0x06e88090
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06e8811c
	System.Single get_PosX_Smooth(); // 0x06e8819c
	System.Void set_PosX_Smooth(System.Single value); // 0x06e88200
	System.Single get_PosY_Smooth(); // 0x06e88278
	System.Void set_PosY_Smooth(System.Single value); // 0x06e882dc
	System.Single get_PosZ_Smooth(); // 0x06e88354
	System.Void set_PosZ_Smooth(System.Single value); // 0x06e883b8
	System.Single get_RotateX_Smooth(); // 0x06e88430
	System.Void set_RotateX_Smooth(System.Single value); // 0x06e88494
	System.Single get_RotateY_Smooth(); // 0x06e8850c
	System.Void set_RotateY_Smooth(System.Single value); // 0x06e88570
	System.Single get_RotateZ_Smooth(); // 0x06e885e8
	System.Void set_RotateZ_Smooth(System.Single value); // 0x06e8864c
	System.Int64 get_ParentId(); // 0x06e886c4
	System.Int64 get_MountID(); // 0x06e88728
	System.Boolean get_HasLocalRotation(); // 0x06e8878c
	System.Boolean get_IsWhizSoundHappened(); // 0x06e887f0
	System.Void set_IsWhizSoundHappened(System.Boolean value); // 0x06e88854
	System.Void CopyPositionAndRotation(UnityEngine.Vector3& pos, UnityEngine.Vector3& rotate); // 0x06e888d0
	System.Void CopyLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation); // 0x06e889dc
	System.Boolean NeedSmooth(UnityEngine.Vector3 lastPos, UnityEngine.Vector3 lastRotate); // 0x06e88a58
	static WizardGames.Soc.Common.Entity.BulletEntity CreateSnapshotBulletEntity(WizardGames.Soc.Common.SimpleCustom.BulletCreateEvent data); // 0x06e88b10
	System.Boolean get_Predict(); // 0x06e8902c
	System.Void set_Predict(System.Boolean value); // 0x06e89090
	System.Boolean get_Destroy(); // 0x06e8910c
	System.Void set_Destroy(System.Boolean value); // 0x06e89170
	System.Void set_PowerForVelocity(System.Single value); // 0x06e891ec
	System.Numerics.Vector3 get_Acceleration(); // 0x06e89264
	System.Void set_Acceleration(System.Numerics.Vector3 value); // 0x06e892c8
	System.Numerics.Vector3 get_BornPosition(); // 0x06e88e18
	System.Int64 get_OwnerTableID(); // 0x06e89360
	System.Void set_OwnerTableID(System.Int64 value); // 0x06e893c4
	System.Int32 get_NowSequence(); // 0x06e8943c
	System.Void set_NowSequence(System.Int32 value); // 0x06e894a0
	System.Int32 get_StartSequence(); // 0x06e89518
	System.Void set_StartSequence(System.Int32 value); // 0x06e8957c
	System.Numerics.Vector3 get_LogicVelocity(); // 0x06e895f4
	System.Void set_LogicVelocity(System.Numerics.Vector3 value); // 0x06e88f7c
	System.Numerics.Vector3 get_LogicDirection(); // 0x06e896a8
	System.Void set_LogicDirection(System.Numerics.Vector3 value); // 0x06e8975c
	System.Numerics.Vector3 get_LogicPosition(); // 0x06e8980c
	System.Void set_LogicPosition(System.Numerics.Vector3 value); // 0x06e88ecc
	System.Void set_CmdEyePosition(System.Numerics.Vector3 value); // 0x06e898c0
	System.Single get_DamageScale(); // 0x06e89958
	System.Void set_DamageScale(System.Single value); // 0x06e899bc
	System.Int64 get_WeaponTableID(); // 0x06e89a34
	System.Void set_WeaponTableID(System.Int64 value); // 0x06e89a98
	System.Int32 get_FuzeDuration(); // 0x06e89b10
	System.Void set_FuzeDuration(System.Int32 value); // 0x06e89b74
	System.Int32 get_BulletIndex(); // 0x06e89bec
	System.Void set_BulletIndex(System.Int32 value); // 0x06e89c50
	System.Boolean get_MagicBullet(); // 0x06e89cc8
	System.Void set_MagicBullet(System.Boolean value); // 0x06e89d2c
	System.Void set_IsServer(System.Boolean value); // 0x06e89da8
	System.Numerics.Vector3 get_SourceEntityPosition(); // 0x06e89e24
	System.Void set_SourceEntityPosition(System.Numerics.Vector3 value); // 0x06e89e88
	System.Single get_AdsProgress(); // 0x06e89f20
	System.Void set_AdsProgress(System.Single value); // 0x06e89f84
	System.Int32 get_SourceMoveState(); // 0x06e89ffc
	System.Void set_SourceMoveState(System.Int32 value); // 0x06e8a060
	System.Int32 get_SourcePoseState(); // 0x06e8a0d8
	System.Void set_SourcePoseState(System.Int32 value); // 0x06e8a13c
	System.Int32 get_SourceMonumentID(); // 0x06e8a1b4
	System.Void set_SourceMonumentID(System.Int32 value); // 0x06e8a218
	System.Void set_LocalTime(System.Int64 value); // 0x06e8a290
	System.Boolean get_HitScreenBox(); // 0x06e8a308
	System.Void set_HitScreenBox(System.Boolean value); // 0x06e8a36c
	System.Single get_TotalMoveDistance(); // 0x06e8a3e8
	System.Void set_TotalMoveDistance(System.Single value); // 0x06e8a44c
	System.Boolean get_IsMeleeThrow(); // 0x06e8a4c4
	System.Int64 get_Identifier(); // 0x06e8a5d4
	System.Int32 get_Tag(); // 0x06e8a6d4
	System.Void set_Tag(System.Int32 value); // 0x06e8a738
	System.Void AddTargetHistory(System.Int64 entityID); // 0x06e8a7b0
	System.Boolean HasHitTarget(System.Int64 entityID); // 0x06e8a874
	System.Void ClearHistory(); // 0x06e8a910
	System.Void AddPredictHitTarget(System.Int64 entityID); // 0x06e8a994
	System.Boolean HasPredictHitTarget(System.Int64 entityID); // 0x06e8aa74
	System.Void ClearPredict(); // 0x06e8ab40
	System.Void Release(); // 0x06e8abc4
	System.Void ReturnToPoolBusiness(); // 0x06e8ac28
	System.Numerics.Vector3 GetNoisePosOffset(); // 0x06e8adfc
	System.Numerics.Vector3 InternalGetNoisePosOffset(System.Numerics.Vector3 targetVelocity, System.Numerics.Vector3 targetPoint); // 0x06e8b1c4
	static WizardGames.Soc.Common.Entity.BulletEntity CreatEntityByPool(System.Int64 entityId); // 0x06e8b514
	static System.Void .cctor(); // 0x06e8b66c
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.CarEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.ICombatEntity, WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Common.Entity.ISmoothCloneEntity
{
	static System.Int32 CLASS_HASH = 330407135;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Single <PosX_Smooth>k__BackingField; // 0x5c
	System.Single <PosY_Smooth>k__BackingField; // 0x60
	System.Single <PosZ_Smooth>k__BackingField; // 0x64
	System.Single <RotateX_Smooth>k__BackingField; // 0x68
	System.Single <RotateY_Smooth>k__BackingField; // 0x6c
	System.Single <RotateZ_Smooth>k__BackingField; // 0x70
	System.Int64 <ParentId>k__BackingField; // 0x78
	System.Int64 <MountID>k__BackingField; // 0x80
	System.Int64 <TemplateId>k__BackingField; // 0x88
	System.Int32 GetClassHash(); // 0x06e8bcd8
	System.String GetTypeName(); // 0x06e8bd40
	System.Int32 get_EntityType(); // 0x06e8bdb8
	System.Void .ctor(); // 0x06e8be1c
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06e8beac
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06e8bf5c
	System.Single get_PosX(); // 0x06e8c00c
	System.Void set_PosX(System.Single value); // 0x06e8c080
	System.Single get_PosZ(); // 0x06e8c10c
	System.Void set_PosZ(System.Single value); // 0x06e8c180
	System.Single get_PosY(); // 0x06e8c20c
	System.Void set_PosY(System.Single value); // 0x06e8c280
	System.Single get_RotateY(); // 0x06e8c30c
	System.Single get_RotateX(); // 0x06e8c380
	System.Single get_RotateZ(); // 0x06e8c3f4
	System.Int64 get_CtrlPlayerId(); // 0x06e8c468
	System.Int64 get_Seat1Id(); // 0x06e8c4dc
	System.Int64 get_Seat2Id(); // 0x06e8c550
	System.Int64 get_Seat3Id(); // 0x06e8c5c4
	System.Int64 get_Seat4Id(); // 0x06e8c638
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06e8c6ac
	System.Single get_PosX_Smooth(); // 0x06e8c73c
	System.Void set_PosX_Smooth(System.Single value); // 0x06e8c7a0
	System.Single get_PosY_Smooth(); // 0x06e8c818
	System.Void set_PosY_Smooth(System.Single value); // 0x06e8c87c
	System.Single get_PosZ_Smooth(); // 0x06e8c8f4
	System.Void set_PosZ_Smooth(System.Single value); // 0x06e8c958
	System.Single get_RotateX_Smooth(); // 0x06e8c9d0
	System.Void set_RotateX_Smooth(System.Single value); // 0x06e8ca34
	System.Single get_RotateY_Smooth(); // 0x06e8caac
	System.Void set_RotateY_Smooth(System.Single value); // 0x06e8cb10
	System.Single get_RotateZ_Smooth(); // 0x06e8cb88
	System.Void set_RotateZ_Smooth(System.Single value); // 0x06e8cbec
	System.Int64 get_ParentId(); // 0x06e8cc64
	System.Int64 get_MountID(); // 0x06e8ccc8
	System.Boolean get_HasLocalRotation(); // 0x06e8cd2c
	System.Void CopyPositionAndRotation(UnityEngine.Vector3& pos, UnityEngine.Vector3& rotate); // 0x06e8cd90
	System.Void CopyLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation); // 0x06e8ce54
	System.Boolean NeedSmooth(UnityEngine.Vector3 lastPos, UnityEngine.Vector3 lastRotate); // 0x06e8ced0
	System.Int64 get_TemplateId(); // 0x06e8cf88
	static System.Void .cctor(); // 0x06e8cfec
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.CarshredderEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Common.Entity.ISpawnEntity, WizardGames.Soc.Common.Entity.ITemplateEntity
{
	static System.Int32 CLASS_HASH = 87867950;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06e8d554
	System.String GetTypeName(); // 0x06e8d5bc
	System.Int32 get_EntityType(); // 0x06e8d634
	System.Void .ctor(); // 0x06e8d698
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06e8d728
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06e8d7d8
	System.Int64 get_TemplateId(); // 0x06e8d888
	System.Int32 get_SpawnType(); // 0x06e8d8fc
	System.Single get_RotateX(); // 0x06e8d970
	System.Void set_RotateX(System.Single value); // 0x06e8d9e4
	System.Single get_RotateY(); // 0x06e8da70
	System.Void set_RotateY(System.Single value); // 0x06e8dae4
	System.Single get_RotateZ(); // 0x06e8db70
	System.Void set_RotateZ(System.Single value); // 0x06e8dbe4
	System.Single get_PosX(); // 0x06e8dc70
	System.Void set_PosX(System.Single value); // 0x06e8dce4
	System.Single get_PosY(); // 0x06e8dd70
	System.Void set_PosY(System.Single value); // 0x06e8dde4
	System.Single get_PosZ(); // 0x06e8de70
	System.Void set_PosZ(System.Single value); // 0x06e8dee4
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06e8df70
	static System.Void .cctor(); // 0x06e8dff0
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.CaveLiftEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.ISpawnEntity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Common.Entity.IPlatformEntity, WizardGames.Soc.Common.Entity.ISmoothCloneEntity, WizardGames.Soc.Common.Entity.IRotation3Entity
{
	static System.Int32 CLASS_HASH = 1653437957;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int64 <ParentId>k__BackingField; // 0x60
	System.Int64 <MountID>k__BackingField; // 0x68
	System.Boolean <HasLocalRotation>k__BackingField; // 0x70
	System.Collections.Generic.HashSet<System.Int64> childrenList; // 0x78
	System.Int64 <firstTakeInPlayerId>k__BackingField; // 0x80
	System.Single <PosX_Smooth>k__BackingField; // 0x88
	System.Single <PosY_Smooth>k__BackingField; // 0x8c
	System.Single <PosZ_Smooth>k__BackingField; // 0x90
	System.Single <RotateX_Smooth>k__BackingField; // 0x94
	System.Single <RotateY_Smooth>k__BackingField; // 0x98
	System.Single <RotateZ_Smooth>k__BackingField; // 0x9c
	System.Int32 GetClassHash(); // 0x06e8e31c
	System.String GetTypeName(); // 0x06e8e384
	System.Int32 get_EntityType(); // 0x06e8e3fc
	System.Void .ctor(); // 0x06e8e460
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06e8e53c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06e8e638
	System.Single get_PosX(); // 0x06e8e734
	System.Void set_PosX(System.Single value); // 0x06e8e7a8
	System.Single get_PosY(); // 0x06e8e834
	System.Void set_PosY(System.Single value); // 0x06e8e8a8
	System.Single get_PosZ(); // 0x06e8e934
	System.Void set_PosZ(System.Single value); // 0x06e8e9a8
	System.Single get_RotateX(); // 0x06e8ea34
	System.Void set_RotateX(System.Single value); // 0x06e8eaa8
	System.Single get_RotateY(); // 0x06e8eb34
	System.Void set_RotateY(System.Single value); // 0x06e8eba8
	System.Single get_RotateZ(); // 0x06e8ec34
	System.Void set_RotateZ(System.Single value); // 0x06e8eca8
	System.Int64 get_TemplateId(); // 0x06e8ed34
	System.Int32 get_SpawnType(); // 0x06e8eda8
	System.Boolean get_IsMoving(); // 0x06e8ee1c
	System.Single get_Height(); // 0x06e8ee90
	System.Int32 get_MoveDirection(); // 0x06e8ef04
	System.Single get_BucketOriginRotX(); // 0x06e8ef78
	System.Single get_BucketOriginRotY(); // 0x06e8efec
	System.Single get_BucketOriginRotZ(); // 0x06e8f060
	System.Single get_OriginalHeight(); // 0x06e8f0d4
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06e8f148
	System.Void RemoteCallAwakeCaveLift(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int64 callerId); // 0x06e8f1c8
	System.Int64 get_ParentId(); // 0x06e8f354
	System.Int64 get_MountID(); // 0x06e8f3b8
	System.Boolean get_HasLocalRotation(); // 0x06e8f41c
	System.Void CopyPositionAndRotation(UnityEngine.Vector3& pos, UnityEngine.Vector3& rotate); // 0x06e8f480
	System.Void CopyLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation); // 0x06e8f544
	System.Boolean NeedSmooth(UnityEngine.Vector3 lastPos, UnityEngine.Vector3 lastRotate); // 0x06e8f5c0
	System.Collections.Generic.HashSet<System.Int64> GetChildrenList(); // 0x06e8f678
	System.Void set_firstTakeInPlayerId(System.Int64 value); // 0x06e8f6dc
	System.Single get_PosX_Smooth(); // 0x06e8f754
	System.Void set_PosX_Smooth(System.Single value); // 0x06e8f7b8
	System.Single get_PosY_Smooth(); // 0x06e8f830
	System.Void set_PosY_Smooth(System.Single value); // 0x06e8f894
	System.Single get_PosZ_Smooth(); // 0x06e8f90c
	System.Void set_PosZ_Smooth(System.Single value); // 0x06e8f970
	System.Single get_RotateX_Smooth(); // 0x06e8f9e8
	System.Void set_RotateX_Smooth(System.Single value); // 0x06e8fa4c
	System.Single get_RotateY_Smooth(); // 0x06e8fac4
	System.Void set_RotateY_Smooth(System.Single value); // 0x06e8fb28
	System.Single get_RotateZ_Smooth(); // 0x06e8fba0
	System.Void set_RotateZ_Smooth(System.Single value); // 0x06e8fc04
	static System.Void .cctor(); // 0x06e8fc7c
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.CollectableEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Common.Entity.IPrivateEntity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.ISpawnEntity
{
	static System.Int32 CLASS_HASH = 276106260;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06e90148
	System.String GetTypeName(); // 0x06e901b0
	System.Int32 get_EntityType(); // 0x06e90228
	System.Void .ctor(); // 0x06e9028c
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06e9031c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06e903cc
	System.Single get_PosX(); // 0x06e9047c
	System.Void set_PosX(System.Single value); // 0x06e904f0
	System.Single get_PosZ(); // 0x06e9057c
	System.Void set_PosZ(System.Single value); // 0x06e905f0
	System.Single get_PosY(); // 0x06e9067c
	System.Void set_PosY(System.Single value); // 0x06e906f0
	System.Single get_RotateX(); // 0x06e9077c
	System.Void set_RotateX(System.Single value); // 0x06e907f0
	System.Single get_RotateY(); // 0x06e9087c
	System.Void set_RotateY(System.Single value); // 0x06e908f0
	System.Single get_RotateZ(); // 0x06e9097c
	System.Void set_RotateZ(System.Single value); // 0x06e909f0
	System.Int64 get_TemplateId(); // 0x06e90a7c
	System.Int32 get_SpawnType(); // 0x06e90af0
	System.Int64 get_BelongPlayerEntityId(); // 0x06e90b64
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06e90bd8
	System.Void Init(); // 0x06e90c58
	System.Void AddLocalComponent(); // 0x06e90cc8
	System.String ToPrettyString(); // 0x06e90d5c
	static System.Void .cctor(); // 0x06e91034
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.CorpseEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.ISpawnEntity, WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Common.Entity.IAttachedEntity, WizardGames.Soc.Common.Entity.IHaveEmbedded, WizardGames.Soc.Common.Entity.ISmoothCloneEntity, WizardGames.Soc.Common.Entity.ICombatEntity, WizardGames.Soc.Common.Entity.IEquipEntity
{
	static System.Int32 CLASS_HASH = 1040366449;
	static System.Int32 StaticClassHash; // 0x0
	static System.String TYPE_NAME = "CorpseEntity";
	static System.String[] PropNameArray; // 0x8
	System.Single <PosX_Smooth>k__BackingField; // 0x5c
	System.Single <PosY_Smooth>k__BackingField; // 0x60
	System.Single <PosZ_Smooth>k__BackingField; // 0x64
	System.Single <RotateX_Smooth>k__BackingField; // 0x68
	System.Single <RotateY_Smooth>k__BackingField; // 0x6c
	System.Single <RotateZ_Smooth>k__BackingField; // 0x70
	System.Int64 <MountID>k__BackingField; // 0x78
	UnityEngine.Transform <AttachedTransform>k__BackingField; // 0x80
	System.Int32 <DefenseTemplateId>k__BackingField; // 0x88
	System.Int32 <BuoyancyPhase>k__BackingField; // 0x8c
	System.Int64 <LastUpdateBuoyancyTime>k__BackingField; // 0x90
	System.Single <FloatAcc>k__BackingField; // 0x98
	System.Single <FloatSpeedMax>k__BackingField; // 0x9c
	System.Single <StaticDepthAcc>k__BackingField; // 0xa0
	System.Single <DampingAcc>k__BackingField; // 0xa4
	System.Single <CurFloatingSpeed>k__BackingField; // 0xa8
	System.Int64 <LastLogTime>k__BackingField; // 0xb0
	System.Single <DampingAmpMin>k__BackingField; // 0xb8
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.IWearItemEntity> WearedItems; // 0xc0
	System.Boolean LocalNeedSyncTrans; // 0xc8
	System.Boolean IsFeedOccupied; // 0xc9
	System.Int64 LastUpdateTime; // 0xd0
	System.Boolean DeathStable; // 0xd8
	System.Single LastTickPosX; // 0xdc
	System.Single LastTickPosY; // 0xe0
	System.Single LastTickPosZ; // 0xe4
	System.Boolean NeedUpMove; // 0xe8
	WizardGames.Soc.Common.Entity.GatherLogic <GatherComponent>k__BackingField; // 0xf0
	System.Int32 <LocalEquipVersion>k__BackingField; // 0xf8
	System.Int32 GetClassHash(); // 0x06e91394
	System.String GetTypeName(); // 0x06e913fc
	System.Int32 get_EntityType(); // 0x06e91474
	System.Void .ctor(); // 0x06e914d8
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06e915b8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06e91a50
	System.Int64 get_TemplateId(); // 0x06e91b50
	System.Int32 get_SpawnType(); // 0x06e91bc4
	System.Int64 get_BornTime(); // 0x06e91c38
	System.Single get_RemainHp(); // 0x06e91cac
	System.Int64 get_KillPlayerId(); // 0x06e91d20
	System.Boolean get_IsDieFromCrawl(); // 0x06e91d94
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipHeadCustom(); // 0x06e91e08
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipEyeCustom(); // 0x06e91ecc
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipJawCustom(); // 0x06e91f90
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipUpperArmorCustom(); // 0x06e92054
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipShirtCustom(); // 0x06e92118
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipGloveCustom(); // 0x06e921dc
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipPantsCustom(); // 0x06e922a0
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipLowerArmorCustom(); // 0x06e92364
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipShoeCustom(); // 0x06e92428
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipBagCustom(); // 0x06e924ec
	System.Int32 get_EquipVersion(); // 0x06e925b0
	System.Int32 get_Sex(); // 0x06e92624
	System.Int32 get_FaceId(); // 0x06e92698
	System.Int32 get_HairId(); // 0x06e9270c
	System.Int32 get_HairColorId(); // 0x06e92780
	System.Boolean get_IsHighlight2Self(); // 0x06e927f4
	System.Boolean get_IsHighlight2Killer(); // 0x06e92868
	System.Int32 get_Highlight2SelfCountdown(); // 0x06e928dc
	System.Int32 get_Highlight2KillCountdown(); // 0x06e92950
	System.Single get_VelocityX(); // 0x06e929c4
	System.Single get_VelocityY(); // 0x06e92a38
	System.Single get_VelocityZ(); // 0x06e92aac
	System.Boolean get_IsGibs(); // 0x06e92b20
	System.Single get_PosX(); // 0x06e92b94
	System.Void set_PosX(System.Single value); // 0x06e92c08
	System.Single get_PosY(); // 0x06e92c94
	System.Void set_PosY(System.Single value); // 0x06e92d08
	System.Single get_PosZ(); // 0x06e92d94
	System.Void set_PosZ(System.Single value); // 0x06e92e08
	System.Single get_RotateZ(); // 0x06e92e94
	System.Void set_RotateZ(System.Single value); // 0x06e92f08
	System.Single get_RotateY(); // 0x06e92f94
	System.Void set_RotateY(System.Single value); // 0x06e93008
	System.Single get_RotateX(); // 0x06e93094
	System.Void set_RotateX(System.Single value); // 0x06e93108
	WizardGames.Soc.Common.Entity.ECorpseTypeEnum get_CorpseType(); // 0x06e93194
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipSaddleCustom(); // 0x06e93208
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipArmorCustom(); // 0x06e932cc
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipFeetCustom(); // 0x06e93390
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipLeftBagCustom(); // 0x06e93454
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipRightBagCustom(); // 0x06e93518
	System.Int64 get_HostEntityId(); // 0x06e935dc
	System.Boolean get_IsPlayer(); // 0x06e93650
	WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int64> get_Costumes(); // 0x06e936c4
	System.Void set_Costumes(WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int64> value); // 0x06e93764
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int32,System.Boolean> get_CostumeOptions(); // 0x06e937f0
	System.Void set_CostumeOptions(WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int32,System.Boolean> value); // 0x06e93890
	System.Int64 get_TargetEntityID(); // 0x06e9391c
	System.Void set_TargetEntityID(System.Int64 value); // 0x06e93990
	System.Int32 get_TargetColliderIndex(); // 0x06e93a1c
	System.Void set_TargetColliderIndex(System.Int32 value); // 0x06e93a90
	System.Single get_PosOffsetX(); // 0x06e93b1c
	System.Void set_PosOffsetX(System.Single value); // 0x06e93b90
	System.Single get_PosOffsetY(); // 0x06e93c1c
	System.Void set_PosOffsetY(System.Single value); // 0x06e93c90
	System.Single get_PosOffsetZ(); // 0x06e93d1c
	System.Void set_PosOffsetZ(System.Single value); // 0x06e93d90
	System.Single get_RotOffsetX(); // 0x06e93e1c
	System.Void set_RotOffsetX(System.Single value); // 0x06e93e90
	System.Single get_RotOffsetY(); // 0x06e93f1c
	System.Void set_RotOffsetY(System.Single value); // 0x06e93f90
	System.Single get_RotOffsetZ(); // 0x06e9401c
	System.Void set_RotOffsetZ(System.Single value); // 0x06e94090
	System.Single get_RotOffsetW(); // 0x06e9411c
	System.Void set_RotOffsetW(System.Single value); // 0x06e94190
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06e9421c
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06e94664
	System.Void InvokeChildOnCustomCreate(); // 0x06e946e4
	System.Void InvokeChildOnCustomRemove(); // 0x06e950d8
	static System.Object DeserializeCorpseEntityContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e95b80
	System.Single get_PosX_Smooth(); // 0x06e95ca4
	System.Void set_PosX_Smooth(System.Single value); // 0x06e95d08
	System.Single get_PosY_Smooth(); // 0x06e95d80
	System.Void set_PosY_Smooth(System.Single value); // 0x06e95de4
	System.Single get_PosZ_Smooth(); // 0x06e95e5c
	System.Void set_PosZ_Smooth(System.Single value); // 0x06e95ec0
	System.Single get_RotateX_Smooth(); // 0x06e95f38
	System.Void set_RotateX_Smooth(System.Single value); // 0x06e95f9c
	System.Single get_RotateY_Smooth(); // 0x06e96014
	System.Void set_RotateY_Smooth(System.Single value); // 0x06e96078
	System.Single get_RotateZ_Smooth(); // 0x06e960f0
	System.Void set_RotateZ_Smooth(System.Single value); // 0x06e96154
	System.Int64 get_ParentId(); // 0x06e961cc
	System.Int64 get_MountID(); // 0x06e96230
	System.Boolean get_HasLocalRotation(); // 0x06e96294
	System.Void set_AttachedTransform(UnityEngine.Transform value); // 0x06e962f8
	WizardGames.Soc.Common.Component.RootNodeComponent get_RootNode(); // 0x06e96378
	System.Boolean get_HideHelmet(); // 0x06e963f8
	System.Boolean get_HideBag(); // 0x06e9650c
	System.Boolean get_OnlyShowEquip(); // 0x06e96574
	System.Boolean GetCostumeOptionByKey(System.Int32 key); // 0x06e96460
	System.Void Init(); // 0x06e965dc
	System.Void CopyPositionAndRotation(UnityEngine.Vector3& pos, UnityEngine.Vector3& rotate); // 0x06e9667c
	System.Void CopyLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation); // 0x06e96740
	System.Boolean NeedSmooth(UnityEngine.Vector3 lastPos, UnityEngine.Vector3 lastRotate); // 0x06e96830
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipHead(); // 0x06e968e8
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipEye(); // 0x06e9694c
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipJaw(); // 0x06e969b0
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipUpperArmor(); // 0x06e96a14
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipShirt(); // 0x06e96a78
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipGlove(); // 0x06e96adc
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipPants(); // 0x06e96b40
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipLowerArmor(); // 0x06e96ba4
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipShoe(); // 0x06e96c08
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipBag(); // 0x06e96c6c
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipSaddle(); // 0x06e96cd0
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipArmor(); // 0x06e96d34
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipFeet(); // 0x06e96d98
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipLeftBag(); // 0x06e96dfc
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipRightBag(); // 0x06e96e60
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.IWearItemEntity> EnumWearedItem(); // 0x06e96ec4
	System.Int32 get_LocalEquipVersion(); // 0x06e97760
	System.Void set_LocalEquipVersion(System.Int32 value); // 0x06e977c4
	System.Void ForceUpdateEquip(); // 0x06e9783c
	System.String ToPrettyString(); // 0x06e97990
	static System.Void .cctor(); // 0x06e97cd0
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.DecalEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity
{
	static System.Int32 CLASS_HASH = 64545378;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06e9890c
	System.String GetTypeName(); // 0x06e98974
	System.Int32 get_EntityType(); // 0x06e989ec
	System.Void .ctor(); // 0x06e98a50
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06e98ae0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06e98b90
	System.Single get_PosX(); // 0x06e98c40
	System.Void set_PosX(System.Single value); // 0x06e98cb4
	System.Single get_PosY(); // 0x06e98d40
	System.Void set_PosY(System.Single value); // 0x06e98db4
	System.Single get_PosZ(); // 0x06e98e40
	System.Void set_PosZ(System.Single value); // 0x06e98eb4
	System.Single get_RotateX(); // 0x06e98f40
	System.Void set_RotateX(System.Single value); // 0x06e98fb4
	System.Single get_RotateY(); // 0x06e99040
	System.Void set_RotateY(System.Single value); // 0x06e990b4
	System.Single get_RotateZ(); // 0x06e99140
	System.Void set_RotateZ(System.Single value); // 0x06e991b4
	System.Int64 get_AttachEntityId(); // 0x06e99240
	System.Int64 get_TableId(); // 0x06e992b4
	System.Single get_LocalPosX(); // 0x06e99328
	System.Single get_LocalPosY(); // 0x06e9939c
	System.Single get_LocalPosZ(); // 0x06e99410
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06e99484
	static System.Void .cctor(); // 0x06e99504
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.DigEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Common.Entity.ISpawnEntity, WizardGames.Soc.Common.Entity.ITemplateEntity, Share.Entity.Interface.ILadderEntity
{
	static System.Int32 CLASS_HASH = 378165419;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06e99af4
	System.String GetTypeName(); // 0x06e99b5c
	System.Int32 get_EntityType(); // 0x06e99bd4
	System.Void .ctor(); // 0x06e99c38
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06e99cc8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06e99d78
	System.Single get_PosX(); // 0x06e99e28
	System.Void set_PosX(System.Single value); // 0x06e99e9c
	System.Single get_PosZ(); // 0x06e99f28
	System.Void set_PosZ(System.Single value); // 0x06e99f9c
	System.Single get_PosY(); // 0x06e9a028
	System.Void set_PosY(System.Single value); // 0x06e9a09c
	System.Single get_RotateX(); // 0x06e9a128
	System.Void set_RotateX(System.Single value); // 0x06e9a19c
	System.Single get_RotateY(); // 0x06e9a228
	System.Void set_RotateY(System.Single value); // 0x06e9a29c
	System.Single get_RotateZ(); // 0x06e9a328
	System.Void set_RotateZ(System.Single value); // 0x06e9a39c
	System.Int64 get_TemplateId(); // 0x06e9a428
	System.Int32 get_SpawnType(); // 0x06e9a49c
	System.Boolean get_Digging(); // 0x06e9a510
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06e9a584
	System.Void Init(); // 0x06e9a604
	static System.Void .cctor(); // 0x06e9a6a4
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.EffectEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.ISmoothCloneEntity
{
	static System.Int32 CLASS_HASH = 1737645968;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Single <PosX_Smooth>k__BackingField; // 0x5c
	System.Single <PosY_Smooth>k__BackingField; // 0x60
	System.Single <PosZ_Smooth>k__BackingField; // 0x64
	System.Single <RotateX_Smooth>k__BackingField; // 0x68
	System.Single <RotateY_Smooth>k__BackingField; // 0x6c
	System.Single <RotateZ_Smooth>k__BackingField; // 0x70
	System.Int64 <ParentId>k__BackingField; // 0x78
	System.Int64 <MountID>k__BackingField; // 0x80
	System.Int32 GetClassHash(); // 0x06e9aa04
	System.String GetTypeName(); // 0x06e9aa6c
	System.Int32 get_EntityType(); // 0x06e9aae4
	System.Void .ctor(); // 0x06e9ab48
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06e9abd8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06e9ac88
	System.Single get_PosX(); // 0x06e9ad38
	System.Void set_PosX(System.Single value); // 0x06e9adac
	System.Single get_PosY(); // 0x06e9ae38
	System.Void set_PosY(System.Single value); // 0x06e9aeac
	System.Single get_PosZ(); // 0x06e9af38
	System.Void set_PosZ(System.Single value); // 0x06e9afac
	System.Single get_ForwardX(); // 0x06e9b038
	System.Single get_ForwardY(); // 0x06e9b0ac
	System.Single get_ForwardZ(); // 0x06e9b120
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06e9b194
	System.Single get_PosX_Smooth(); // 0x06e9b214
	System.Void set_PosX_Smooth(System.Single value); // 0x06e9b278
	System.Single get_PosY_Smooth(); // 0x06e9b2f0
	System.Void set_PosY_Smooth(System.Single value); // 0x06e9b354
	System.Single get_PosZ_Smooth(); // 0x06e9b3cc
	System.Void set_PosZ_Smooth(System.Single value); // 0x06e9b430
	System.Single get_RotateX_Smooth(); // 0x06e9b4a8
	System.Void set_RotateX_Smooth(System.Single value); // 0x06e9b50c
	System.Single get_RotateY_Smooth(); // 0x06e9b584
	System.Void set_RotateY_Smooth(System.Single value); // 0x06e9b5e8
	System.Single get_RotateZ_Smooth(); // 0x06e9b660
	System.Void set_RotateZ_Smooth(System.Single value); // 0x06e9b6c4
	System.Int64 get_ParentId(); // 0x06e9b73c
	System.Int64 get_MountID(); // 0x06e9b7a0
	System.Boolean get_HasLocalRotation(); // 0x06e9b804
	System.Void CopyPositionAndRotation(UnityEngine.Vector3& pos, UnityEngine.Vector3& rotate); // 0x06e9b868
	System.Void CopyLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation); // 0x06e9b92c
	System.Boolean NeedSmooth(UnityEngine.Vector3 lastPos, UnityEngine.Vector3 lastRotate); // 0x06e9b9a8
	static System.Void .cctor(); // 0x06e9ba60
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.ElevatorEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Common.Entity.ISpawnEntity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.IPlatformEntity, WizardGames.Soc.Common.Entity.ISmoothCloneEntity
{
	static System.Int32 CLASS_HASH = 940669900;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Single <PosX_Smooth>k__BackingField; // 0x5c
	System.Single <PosY_Smooth>k__BackingField; // 0x60
	System.Single <PosZ_Smooth>k__BackingField; // 0x64
	System.Single <RotateX_Smooth>k__BackingField; // 0x68
	System.Single <RotateY_Smooth>k__BackingField; // 0x6c
	System.Single <RotateZ_Smooth>k__BackingField; // 0x70
	System.Int64 <ParentId>k__BackingField; // 0x78
	System.Int64 <MountID>k__BackingField; // 0x80
	System.Collections.Generic.HashSet<System.Int64> childrenList; // 0x88
	System.Int64 <firstTakeInPlayerId>k__BackingField; // 0x90
	System.Int32 GetClassHash(); // 0x06e9bd58
	System.String GetTypeName(); // 0x06e9bdc0
	System.Int32 get_EntityType(); // 0x06e9be38
	System.Void .ctor(); // 0x06e9be9c
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06e9bf78
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06e9c074
	System.Single get_PosX(); // 0x06e9c170
	System.Void set_PosX(System.Single value); // 0x06e9c1e4
	System.Single get_PosY(); // 0x06e9c270
	System.Void set_PosY(System.Single value); // 0x06e9c2e4
	System.Single get_PosZ(); // 0x06e9c370
	System.Void set_PosZ(System.Single value); // 0x06e9c3e4
	System.Single get_RotateX(); // 0x06e9c470
	System.Void set_RotateX(System.Single value); // 0x06e9c4e4
	System.Single get_RotateY(); // 0x06e9c570
	System.Void set_RotateY(System.Single value); // 0x06e9c5e4
	System.Single get_RotateZ(); // 0x06e9c670
	System.Void set_RotateZ(System.Single value); // 0x06e9c6e4
	System.Int64 get_TemplateId(); // 0x06e9c770
	System.Int32 get_SpawnType(); // 0x06e9c7e4
	System.Single get_Speed(); // 0x06e9c858
	System.Int32 get_MaxFloor(); // 0x06e9c8cc
	System.Int32 get_CurFloor(); // 0x06e9c940
	System.Boolean get_IsMoving(); // 0x06e9c9b4
	System.Int32 get_MoveDirection(); // 0x06e9ca28
	System.Int32 get_MonumentId(); // 0x06e9ca9c
	System.Int32 get_ComponentType(); // 0x06e9cb10
	System.Int64 get_HostElevatorId(); // 0x06e9cb84
	System.Single get_EndPosY(); // 0x06e9cbf8
	System.Boolean get_IsPressed(); // 0x06e9cc6c
	System.Boolean get_DoorOpened(); // 0x06e9cce0
	System.Boolean get_FromTerrainMeta(); // 0x06e9cd54
	System.Int64 get_ConstructionElevtorId(); // 0x06e9cdc8
	System.Single get_InsideOffset(); // 0x06e9ce3c
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06e9ceb0
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x06e9cf30
	System.Void RemoteCallCallElevator(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Int32 callType, System.Int64 callerId); // 0x06e9d6c0
	System.Single get_PosX_Smooth(); // 0x06e9d864
	System.Void set_PosX_Smooth(System.Single value); // 0x06e9d8c8
	System.Single get_PosY_Smooth(); // 0x06e9d940
	System.Void set_PosY_Smooth(System.Single value); // 0x06e9d9a4
	System.Single get_PosZ_Smooth(); // 0x06e9da1c
	System.Void set_PosZ_Smooth(System.Single value); // 0x06e9da80
	System.Single get_RotateX_Smooth(); // 0x06e9daf8
	System.Void set_RotateX_Smooth(System.Single value); // 0x06e9db5c
	System.Single get_RotateY_Smooth(); // 0x06e9dbd4
	System.Void set_RotateY_Smooth(System.Single value); // 0x06e9dc38
	System.Single get_RotateZ_Smooth(); // 0x06e9dcb0
	System.Void set_RotateZ_Smooth(System.Single value); // 0x06e9dd14
	System.Int64 get_ParentId(); // 0x06e9dd8c
	System.Int64 get_MountID(); // 0x06e9ddf0
	System.Boolean get_HasLocalRotation(); // 0x06e9de54
	System.Void CopyPositionAndRotation(UnityEngine.Vector3& pos, UnityEngine.Vector3& rotate); // 0x06e9deb8
	System.Void CopyLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation); // 0x06e9df7c
	System.Boolean NeedSmooth(UnityEngine.Vector3 lastPos, UnityEngine.Vector3 lastRotate); // 0x06e9dff8
	System.Void OnMoveDone(System.Int64 playerId); // 0x06e9d224
	System.Void OnMoveStart(); // 0x06e9d444
	System.Void ElevatorTips(System.Int64 entityId, System.Int32 tipsId, System.Boolean fail); // 0x06e9d588
	System.Boolean IsMainElevator(); // 0x06e9e0b0
	System.Collections.Generic.HashSet<System.Int64> GetChildrenList(); // 0x06e9e1b8
	System.Void set_firstTakeInPlayerId(System.Int64 value); // 0x06e9e21c
	static System.Void .cctor(); // 0x06e9e294
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.FixPointSpawner : WizardGames.Soc.Share.Framework.EntityBase
{
	static System.Int32 CLASS_HASH = 703399958;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	static WizardGames.Soc.Common.Entity.FixPointSpawner <Instance>k__BackingField; // 0x10
	System.Collections.Generic.List<UnityEngine.Vector3> _trainDischargePositions; // 0x60
	System.Int32 GetClassHash(); // 0x06e9ea50
	System.String GetTypeName(); // 0x06e9eab8
	System.Int32 get_EntityType(); // 0x06e9eb30
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06e9eb94
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06e9ecc8
	System.Int32 get_DynamicMonumentId(); // 0x06e9ed78
	WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int64> get_MarkerEntityIds(); // 0x06e9edec
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int32,System.UInt32> get_ComingEvents(); // 0x06e9ee8c
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int32,System.UInt32> get_EndingEvents(); // 0x06e9ef2c
	static System.Object DeserializeFixPointSpawnerContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e9efcc
	static WizardGames.Soc.Common.Entity.FixPointSpawner get_Instance(); // 0x06e9f0f8
	static System.Void set_Instance(WizardGames.Soc.Common.Entity.FixPointSpawner value); // 0x06e9f180
	System.Void PostInit(); // 0x06e9f214
	System.Void GenerateTrainDischargePositions(); // 0x06e9f3f8
	System.Boolean GetClosestTrainDischargePosition(UnityEngine.Vector3 pos, UnityEngine.Vector3& closest); // 0x06e9f924
	System.Boolean GetClosestTreasureHuntPosition(UnityEngine.Vector3 pos, UnityEngine.Vector3& closest, System.Int32 templateId); // 0x06e9fba0
	System.Void Cleanup(System.Boolean isDestroy); // 0x06ea0c94
	static System.Void .cctor(); // 0x06ea0ea4
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.GlobalInfoSyncEntity : WizardGames.Soc.Share.Framework.EntityBase
{
	static System.Int32 CLASS_HASH = 331942556;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	static SocLogger logger; // 0x10
	System.Int32 GetClassHash(); // 0x06ea1030
	System.String GetTypeName(); // 0x06ea1098
	System.Int32 get_EntityType(); // 0x06ea1110
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06ea1174
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06ea12ac
	System.Int64 get_LogicStartTime(); // 0x06ea135c
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.DeadSheepTerritoryInfo> get_GlobalShownDeadSheep(); // 0x06ea13d0
	System.Void set_GlobalShownDeadSheep(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.DeadSheepTerritoryInfo> value); // 0x06ea1470
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.BannedPlayerTerritoryInfo> get_BannedPlayerTerritories(); // 0x06ea14fc
	System.Void set_BannedPlayerTerritories(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.BannedPlayerTerritoryInfo> value); // 0x06ea159c
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x06ea1628
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06ea1800
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x06ea1c48
	static System.Object DeserializeGlobalInfoSyncEntityContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ea1fb0
	static WizardGames.Soc.Common.Entity.GlobalInfoSyncEntity get_Instance(); // 0x06ea20b4
	System.Void PostInit(); // 0x06ea21bc
	System.Void Cleanup(System.Boolean isDestroy); // 0x06ea23bc
	System.Void DrawDebugSphere(System.Single posX, System.Single posY, System.Single posZ); // 0x06ea1e78
	static System.Void .cctor(); // 0x06ea2580
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.GlobalMarkerEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.Interface.IMarkerEntity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity
{
	static System.Int32 CLASS_HASH = 1184796179;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06ea27a0
	System.String GetTypeName(); // 0x06ea2808
	System.Int32 get_EntityType(); // 0x06ea2880
	System.Void .ctor(); // 0x06ea28e4
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06ea2974
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06ea2a24
	System.Single get_PosX(); // 0x06ea2ad4
	System.Void set_PosX(System.Single value); // 0x06ea2b48
	System.Single get_PosY(); // 0x06ea2bd4
	System.Void set_PosY(System.Single value); // 0x06ea2c48
	System.Single get_PosZ(); // 0x06ea2cd4
	System.Void set_PosZ(System.Single value); // 0x06ea2d48
	System.Int32 get_Type(); // 0x06ea2dd4
	System.Single get_RotateX(); // 0x06ea2e48
	System.Void set_RotateX(System.Single value); // 0x06ea2ebc
	System.Single get_RotateY(); // 0x06ea2f48
	System.Void set_RotateY(System.Single value); // 0x06ea2fbc
	System.Single get_RotateZ(); // 0x06ea3048
	System.Void set_RotateZ(System.Single value); // 0x06ea30bc
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06ea3148
	System.Void Init(); // 0x06ea31d8
	static System.Void .cctor(); // 0x06ea3284
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.HorseEntity : WizardGames.Soc.Common.Entity.BaseVehicleEntity, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.IEquipEntity, WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Common.Entity.Interface.IMarkerEntity, WizardGames.Soc.Common.Entity.ICorpseableEntity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Common.Entity.IHaveEmbedded, WizardGames.Soc.Common.Entity.ISmoothCloneEntity, WizardGames.Soc.Common.Entity.ISpawnEntity
{
	static System.Int32 CLASS_HASH = 151053091;
	static System.Int32 StaticClassHash; // 0x0
	static System.String TYPE_NAME = "HorseEntity";
	static System.String[] PropNameArray; // 0x8
	System.Boolean <NotFreedom>k__BackingField; // 0xd1
	System.Single <PosX_Smooth>k__BackingField; // 0xd4
	System.Single <PosY_Smooth>k__BackingField; // 0xd8
	System.Single <PosZ_Smooth>k__BackingField; // 0xdc
	System.Single <RotateX_Smooth>k__BackingField; // 0xe0
	System.Single <RotateY_Smooth>k__BackingField; // 0xe4
	System.Single <RotateZ_Smooth>k__BackingField; // 0xe8
	System.Int64 <ParentId>k__BackingField; // 0xf0
	System.Int64 <MountID>k__BackingField; // 0xf8
	System.Int64 boughtSubscribeId; // 0x100
	System.Int32 <LocalEquipCount>k__BackingField; // 0x108
	WizardGames.Soc.Common.Entity.IEntity <Entity>k__BackingField; // 0x110
	System.Int32 <LocalEquipVersion>k__BackingField; // 0x118
	WizardGames.Soc.Common.Character.HorseRMData HorseRmData; // 0x120
	System.Single DeadType; // 0x208
	System.Boolean FirstLoad; // 0x20c
	System.Single[] PrevRotation; // 0x210
	System.Single[] NowRotation; // 0x218
	System.Single[] CGRootPrevRotation; // 0x220
	System.Single[] CGRootNowRotation; // 0x228
	System.Single CmdDeltaTime; // 0x230
	System.Boolean NeedSample; // 0x234
	WizardGames.Soc.Common.Unity.Character.AnimParametersHorse AnimParametersHorse; // 0x238
	System.Int32 MaxStaminaSeconds; // 0x254
	System.Single MaxStamina; // 0x258
	System.Single MaxSpeed; // 0x25c
	System.Boolean IsFloodedHeightWater; // 0x260
	System.Boolean IsInfluentHeightWater; // 0x261
	System.Int64 followTargetEntityId; // 0x268
	System.Single ArrivedDistance; // 0x270
	System.Boolean Arrived; // 0x274
	System.Int64 NextForagingCheckTime; // 0x278
	System.Int64 ForagingStateEndTime; // 0x280
	System.Int64 WhenEatFoodNextDecayTime; // 0x288
	System.Boolean HasHitchingPost; // 0x290
	WizardGames.Soc.Common.Entity.EHorseAnimType AnimType; // 0x294
	System.Single NextIdleAnimTime; // 0x298
	System.Int32 MainIdleCount; // 0x29c
	System.Single SmoothVelocity; // 0x2a0
	System.Single SmoothRotateVelocity; // 0x2a4
	WizardGames.Soc.Common.Entity.EHorseJumpAnimType JumpAnimType; // 0x2a8
	System.Int32 JumpAnimIndex; // 0x2ac
	System.Single AniLocomotionMultiplier; // 0x2b0
	System.Single AniHorizontal; // 0x2b4
	System.Single AniVertical; // 0x2b8
	System.Single AniLastHorizontal; // 0x2bc
	System.Single AniLastVertical; // 0x2c0
	System.Single HorseBreedInfoMaxSpeed; // 0x2c4
	System.Boolean IsOnGround; // 0x2c8
	System.Numerics.Vector3 DLastCcPos; // 0x2cc
	System.Numerics.Vector3 DNowCcPos; // 0x2d8
	System.Numerics.Vector3 DCcMoveVelocity; // 0x2e4
	System.Numerics.Vector3 DLastVelocity; // 0x2f0
	System.Boolean IsRollBack; // 0x2fc
	System.Single LastHalterNormalizedTime; // 0x300
	System.Boolean BackRun; // 0x304
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.IWearItemEntity> WearedItems; // 0x308
	System.Int32 CurHitIndex; // 0x310
	WizardGames.Soc.Common.Data.Vehicle.HorseBreedinfo _breedInfo; // 0x318
	System.Int32 GetClassHash(); // 0x06ea34ac
	System.String GetTypeName(); // 0x06ea3514
	System.Int32 get_EntityType(); // 0x06ea358c
	System.Void .ctor(); // 0x055049cc
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x055128b0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x05524154
	System.Void set_ScaleX(System.Single value); // 0x06ea3a34
	System.Void set_ScaleY(System.Single value); // 0x06ea3ac0
	System.Void set_ScaleZ(System.Single value); // 0x06ea3b4c
	System.Boolean get_JustBought(); // 0x06ea3bd8
	System.Void set_JustBought(System.Boolean value); // 0x06ea3c4c
	System.Boolean get_InEat(); // 0x06ea3cd8
	System.Void set_InEat(System.Boolean value); // 0x06ea3d4c
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipSaddleCustom(); // 0x06ea3dd8
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipArmorCustom(); // 0x06ea3e9c
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipFeetCustom(); // 0x06ea3f60
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipLeftBagCustom(); // 0x06ea4024
	WizardGames.Soc.Common.CustomType.WearItemCustom get_EquipRightBagCustom(); // 0x06ea40e8
	System.Int32 get_EquipVersion(); // 0x06ea41ac
	System.Void set_EquipVersion(System.Int32 value); // 0x06ea4220
	System.Single get_EquipmentSpeedMod(); // 0x06ea42ac
	System.Void set_EquipmentSpeedMod(System.Single value); // 0x06ea4320
	System.Void set_NumStorageSlots(System.Int32 value); // 0x06ea43ac
	System.Int64 get_FollowTargetEntityId(); // 0x06ea4438
	System.Void set_FollowTargetEntityId(System.Int64 value); // 0x06ea44ac
	System.Int32 get_HorseState(); // 0x06ea4538
	System.Void set_HorseState(System.Int32 value); // 0x06ea45ac
	System.Int32 get_MoveState(); // 0x06ea4638
	System.Void set_MoveState(System.Int32 value); // 0x06ea46ac
	System.Int32 get_UnAliveState(); // 0x06ea4738
	System.Void set_UnAliveState(System.Int32 value); // 0x06ea47ac
	System.Single get_RotateSpeed(); // 0x06ea4838
	System.Void set_RotateSpeed(System.Single value); // 0x06ea48ac
	System.Single get_AniRotateSpeed(); // 0x06ea4938
	System.Void set_AniRotateSpeed(System.Single value); // 0x06ea49ac
	System.Single get_NextJumpTime(); // 0x06ea4a38
	System.Void set_NextJumpTime(System.Single value); // 0x06ea4aac
	System.Int32 get_JumpState(); // 0x06ea4b38
	System.Void set_JumpState(System.Int32 value); // 0x06ea4bac
	System.Single get_GroundNormalX(); // 0x06ea4c38
	System.Void set_GroundNormalX(System.Single value); // 0x06ea4cac
	System.Single get_GroundNormalY(); // 0x06ea4d38
	System.Void set_GroundNormalY(System.Single value); // 0x06ea4dac
	System.Single get_GroundNormalZ(); // 0x06ea4e38
	System.Void set_GroundNormalZ(System.Single value); // 0x06ea4eac
	System.Single get_StateTime(); // 0x06ea4f38
	System.Void set_StateTime(System.Single value); // 0x06ea4fac
	System.Single get_MaxRotateSpeed(); // 0x06ea5038
	System.Void set_MaxRotateSpeed(System.Single value); // 0x06ea50ac
	System.Int32 get_DirDotY(); // 0x06ea5138
	System.Void set_DirDotY(System.Int32 value); // 0x06ea51ac
	System.Int32 get_SpawnMonumentId(); // 0x06ea5238
	System.Int32 get_HitIndex(); // 0x06ea52ac
	System.Void set_HitIndex(System.Int32 value); // 0x06ea5320
	System.Boolean get_InSlope(); // 0x06ea53ac
	System.Void set_InSlope(System.Boolean value); // 0x06ea5420
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06ea54ac
	System.Void InvokeChildOnCustomCreate(); // 0x06ea552c
	System.Void InvokeChildOnCustomRemove(); // 0x06ea58e0
	System.Void set_NotFreedom(System.Boolean value); // 0x05523a7c
	WizardGames.Soc.Share.Framework.IPredictType GetNewInstance(System.Int64 id); // 0x06ea5d4c
	System.Single get_PosX_Smooth(); // 0x054a5abc
	System.Void set_PosX_Smooth(System.Single value); // 0x05513724
	System.Single get_PosY_Smooth(); // 0x054a5abc
	System.Void set_PosY_Smooth(System.Single value); // 0x05513724
	System.Single get_PosZ_Smooth(); // 0x054a5abc
	System.Void set_PosZ_Smooth(System.Single value); // 0x05513724
	System.Single get_RotateX_Smooth(); // 0x054a5abc
	System.Void set_RotateX_Smooth(System.Single value); // 0x05513724
	System.Single get_RotateY_Smooth(); // 0x054a5abc
	System.Void set_RotateY_Smooth(System.Single value); // 0x05513724
	System.Single get_RotateZ_Smooth(); // 0x054a5abc
	System.Void set_RotateZ_Smooth(System.Single value); // 0x05513724
	System.Int64 get_ParentId(); // 0x054a4380
	System.Int64 get_MountID(); // 0x054a4380
	System.Boolean get_HasLocalRotation(); // 0x06ea6504
	System.Void Init(); // 0x06ea6568
	System.Void PostInit(); // 0x06ea6688
	System.Void CopyPositionAndRotation(UnityEngine.Vector3& pos, UnityEngine.Vector3& rotate); // 0x06ea6750
	System.Void CopyLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation); // 0x06ea682c
	System.Boolean NeedSmooth(UnityEngine.Vector3 lastPos, UnityEngine.Vector3 lastRotate); // 0x06ea68a8
	System.Void SubscribePropertyChange(WizardGames.Soc.Common.Entity.HorseEntity target, WizardGames.Soc.Common.Unity.Go.BaseMountableGo _mountableGo); // 0x0552af00
	System.Void UnSubscribePropertyChange(); // 0x06ea7bcc
	System.Void OnNotFreedomChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue, WizardGames.Soc.Common.Entity.HorseEntity target); // 0x06ea7c34
	System.Void OnJustBoughtChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue, WizardGames.Soc.Common.Entity.HorseEntity target); // 0x06ea7d30
	System.Void OnIsInteriorChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue, WizardGames.Soc.Common.Entity.HorseEntity target); // 0x06ea7dd8
	System.Void OnEquipSaddleCustomChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue, WizardGames.Soc.Common.Entity.HorseEntity target); // 0x06ea7e84
	System.Void OnEquipArmorCustomChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue, WizardGames.Soc.Common.Entity.HorseEntity target); // 0x06ea8004
	System.Void OnEquipFeetCustomChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue, WizardGames.Soc.Common.Entity.HorseEntity target); // 0x06ea8184
	System.Void OnEquipLeftBagCustomChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue, WizardGames.Soc.Common.Entity.HorseEntity target); // 0x06ea8304
	System.Void OnEquipRightBagCustomChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue, WizardGames.Soc.Common.Entity.HorseEntity target); // 0x06ea8484
	System.Void OnEquipVersionChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.Entity.HorseEntity target); // 0x06ea8604
	System.Void OnEquipmentSpeedModChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Entity.HorseEntity target); // 0x05527978
	System.Void OnNumStorageSlotsChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.Entity.HorseEntity target); // 0x06ea8878
	System.Void OnFollowTargetEntityIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.Entity.HorseEntity target); // 0x06ea8920
	System.Void OnHorseStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.Entity.HorseEntity target); // 0x06ea89c8
	System.Void OnMoveStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.Entity.HorseEntity target); // 0x06ea8ad0
	System.Void OnUnAliveStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.Entity.HorseEntity target); // 0x06ea8bd8
	System.Void OnJumpStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.Entity.HorseEntity target); // 0x06ea8ce0
	System.Void OnRotateSpeedChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Entity.HorseEntity target); // 0x06ea8de8
	System.Void OnAniRotateSpeedChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Entity.HorseEntity target); // 0x06ea8ef0
	System.Void OnNextJumpTimeChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Entity.HorseEntity target); // 0x06ea8ff8
	System.Void OnGroundNormalXChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Entity.HorseEntity target); // 0x06ea9100
	System.Void OnGroundNormalYChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Entity.HorseEntity target); // 0x06ea9208
	System.Void OnGroundNormalZChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Entity.HorseEntity target); // 0x06ea9310
	System.Void OnStateTimeChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Entity.HorseEntity target); // 0x06ea9418
	System.Void OnMaxRotateSpeedChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Entity.HorseEntity target); // 0x06ea9520
	System.Void OnDirDotYChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.Entity.HorseEntity target); // 0x06ea9628
	System.Void OnSpeedIntChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.Entity.HorseEntity target); // 0x06ea9730
	System.Void UpdateHorseEquip(); // 0x06ea983c
	WizardGames.Soc.Common.Entity.IEntity get_Entity(); // 0x054e7844
	System.Void set_LocalEquipVersion(System.Int32 value); // 0x055056e8
	System.Int32 get_DriversCount(); // 0x06eaa4d8
	System.Boolean CanFeedOnInteractiveList(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x054dec74
	System.Boolean CanFeed(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06eaa65c
	System.Boolean get_IsWeak(); // 0x054c4760
	System.Int32 get_RemainLimitedAuthorityTs(); // 0x06eaa830
	System.Void RefreshAttribution(); // 0x06eaa9c8
	WizardGames.Soc.Common.Component.SocHorseStaminaComponent get_HorseStaminaComponent(); // 0x06eaab80
	WizardGames.Soc.Common.Entity.IEntity get_FollowTarget(); // 0x054e7844
	System.Void .ctor(System.Int64 id); // 0x055112ac
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipSaddle(); // 0x06eaacc8
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipArmor(); // 0x06eaad2c
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipFeet(); // 0x06eaad90
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipLeftBag(); // 0x06eaadf4
	WizardGames.Soc.Common.Entity.IWearItemEntity get_EquipRightBag(); // 0x06eaae58
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.IWearItemEntity> EnumWearedItem(); // 0x054e7844
	System.String ToPrettyString(); // 0x06eaaebc
	WizardGames.Soc.Common.Data.Vehicle.HorseBreedinfo get_BreedInfo(); // 0x054e7844
	System.Int32 get_Breeds(); // 0x06eab310
	System.Void set_Breeds(System.Int32 value); // 0x06eab39c
	static System.Void .cctor(); // 0x06eab41c
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.HorseEntity.<>c__DisplayClass158_0 : System.Object
{
	WizardGames.Soc.Common.Entity.HorseEntity <>4__this; // 0x10
	WizardGames.Soc.Common.Entity.HorseEntity target; // 0x18
	System.Void .ctor(); // 0x06ea7b64
	System.Void <SubscribePropertyChange>b__0(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x06eac598
	System.Void <SubscribePropertyChange>b__1(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x06eac644
	System.Void <SubscribePropertyChange>b__2(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x06eac6f0
	System.Void <SubscribePropertyChange>b__3(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue); // 0x06eac79c
	System.Void <SubscribePropertyChange>b__4(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue); // 0x06eac848
	System.Void <SubscribePropertyChange>b__5(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue); // 0x06eac8f4
	System.Void <SubscribePropertyChange>b__6(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue); // 0x06eac9a0
	System.Void <SubscribePropertyChange>b__7(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue); // 0x06eaca4c
	System.Void <SubscribePropertyChange>b__8(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x06eacaf8
	System.Void <SubscribePropertyChange>b__9(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x06eacba4
	System.Void <SubscribePropertyChange>b__10(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x06eacc50
	System.Void <SubscribePropertyChange>b__11(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x06eaccfc
	System.Void <SubscribePropertyChange>b__12(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x06eacda8
	System.Void <SubscribePropertyChange>b__13(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x06eace54
	System.Void <SubscribePropertyChange>b__14(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x06eacf00
	System.Void <SubscribePropertyChange>b__15(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x06eacfac
	System.Void <SubscribePropertyChange>b__16(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x06ead058
	System.Void <SubscribePropertyChange>b__17(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x06ead104
	System.Void <SubscribePropertyChange>b__18(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x06ead1b0
	System.Void <SubscribePropertyChange>b__19(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x06ead25c
	System.Void <SubscribePropertyChange>b__20(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x06ead308
	System.Void <SubscribePropertyChange>b__21(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x06ead3b4
	System.Void <SubscribePropertyChange>b__22(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x06ead460
	System.Void <SubscribePropertyChange>b__23(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x06ead50c
	System.Void <SubscribePropertyChange>b__24(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x06ead5b8
	System.Void <SubscribePropertyChange>b__25(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x06ead664
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.InteractionEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.ISpawnEntity, WizardGames.Soc.Common.Entity.IPrivateEntity
{
	static System.Int32 CLASS_HASH = 763906085;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06ead710
	System.String GetTypeName(); // 0x06ead778
	System.Int32 get_EntityType(); // 0x06ead7f0
	System.Void .ctor(); // 0x06ead854
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06ead8e4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06ead994
	System.Single get_PosX(); // 0x06eada44
	System.Void set_PosX(System.Single value); // 0x06eadab8
	System.Single get_PosY(); // 0x06eadb44
	System.Void set_PosY(System.Single value); // 0x06eadbb8
	System.Single get_PosZ(); // 0x06eadc44
	System.Void set_PosZ(System.Single value); // 0x06eadcb8
	System.Single get_RotateX(); // 0x06eadd44
	System.Void set_RotateX(System.Single value); // 0x06eaddb8
	System.Single get_RotateY(); // 0x06eade44
	System.Void set_RotateY(System.Single value); // 0x06eadeb8
	System.Single get_RotateZ(); // 0x06eadf44
	System.Void set_RotateZ(System.Single value); // 0x06eadfb8
	System.Int64 get_TemplateId(); // 0x06eae044
	System.Int32 get_MonumentId(); // 0x06eae0b8
	System.Boolean get_HasMatchZipline(); // 0x06eae12c
	System.Int64 get_LastInterStartTime(); // 0x06eae1a0
	System.Int32 get_TrainUnloadType(); // 0x06eae214
	System.Int32 get_TrainUnloadCount(); // 0x06eae288
	System.Int32 get_SpawnType(); // 0x06eae2fc
	System.Int64 get_BelongPlayerEntityId(); // 0x06eae370
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06eae3e4
	static System.Void .cctor(); // 0x06eae464
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.IOEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.ISpawnEntity, Share.Entity.Interface.ILadderEntity, WizardGames.Soc.Common.Entity.IEntity
{
	static System.Int32 CLASS_HASH = 470251721;
	static System.Int32 StaticClassHash; // 0x0
	static System.String TYPE_NAME = "IOEntity";
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06eae8fc
	System.String GetTypeName(); // 0x06eae964
	System.Int32 get_EntityType(); // 0x06eae9dc
	System.Void .ctor(); // 0x06eaea40
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06eaead0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06eaebbc
	System.Int64 get_TemplateId(); // 0x06eaec6c
	System.Int32 get_SpawnType(); // 0x06eaece0
	System.Int32 get_Activation(); // 0x06eaed54
	System.Int32 get_StateId(); // 0x06eaedc8
	System.Void set_StateId(System.Int32 value); // 0x06eaee3c
	System.Int32 get_MonumentId(); // 0x06eaeec8
	System.Single get_PosX(); // 0x06eaef3c
	System.Void set_PosX(System.Single value); // 0x06eaefb0
	System.Single get_PosY(); // 0x06eaf03c
	System.Void set_PosY(System.Single value); // 0x06eaf0b0
	System.Single get_PosZ(); // 0x06eaf13c
	System.Void set_PosZ(System.Single value); // 0x06eaf1b0
	System.Single get_RotateX(); // 0x06eaf23c
	System.Void set_RotateX(System.Single value); // 0x06eaf2b0
	System.Single get_RotateY(); // 0x06eaf33c
	System.Void set_RotateY(System.Single value); // 0x06eaf3b0
	System.Single get_RotateZ(); // 0x06eaf43c
	System.Void set_RotateZ(System.Single value); // 0x06eaf4b0
	System.Int32 get_GameGraphId(); // 0x06eaf53c
	System.Int32 get_LeftGuaranteedNum(); // 0x06eaf5b0
	System.Int64 get_GameResetTimeStamp(); // 0x06eaf624
	System.Int64 get_CoolDownEndTimeStamp(); // 0x06eaf698
	System.Boolean get_IsUsed(); // 0x06eaf70c
	System.Boolean get_IsShowElectricShock(); // 0x06eaf780
	WizardGames.Soc.Share.Framework.BasicTypeList<System.Int32> get_GameSuccessPath(); // 0x06eaf7f4
	System.Void set_GameSuccessPath(WizardGames.Soc.Share.Framework.BasicTypeList<System.Int32> value); // 0x06eaf894
	System.Int64 get_LadderId(); // 0x06eaf920
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06eaf994
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06eafcb4
	System.Void RemoteCallOnPlayerFinshFuseBoxGame(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Boolean isSuccess, System.Collections.Generic.IList<System.Int32> gameSuccessPath); // 0x06eafd34
	System.Void RemoteCallOnPlayerOpenFuseBoxGame(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06eafed8
	System.Void RemoteCallForceCloseFuseBox(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06eb0044
	System.Void RemoteCallOnPlayerExitFuseBoxGame(WizardGames.Soc.Common.Framework.Network.ERpcTarget target); // 0x06eb01b0
	static System.Object DeserializeIOEntityContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06eb031c
	System.Void Init(); // 0x06eb03f0
	static System.Void .cctor(); // 0x06eb0490
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.KatyushaEntity : WizardGames.Soc.Common.Entity.BaseVehicleEntity, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Common.Entity.ISmoothCloneEntity
{
	static System.Int32 CLASS_HASH = 248351567;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Single <PosX_Smooth>k__BackingField; // 0xd4
	System.Single <PosY_Smooth>k__BackingField; // 0xd8
	System.Single <PosZ_Smooth>k__BackingField; // 0xdc
	System.Single <RotateX_Smooth>k__BackingField; // 0xe0
	System.Single <RotateY_Smooth>k__BackingField; // 0xe4
	System.Single <RotateZ_Smooth>k__BackingField; // 0xe8
	System.Int64 <ParentId>k__BackingField; // 0xf0
	System.Int64 <MountID>k__BackingField; // 0xf8
	System.Int32 GetClassHash(); // 0x06eb0a60
	System.String GetTypeName(); // 0x06eb0ac8
	System.Int32 get_EntityType(); // 0x06eb0b40
	System.Void .ctor(); // 0x06eb0ba4
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06eb0c30
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06eb0ce0
	System.Single get_CurDirX(); // 0x06eb0d90
	System.Single get_CurDirY(); // 0x06eb0e04
	System.Int32 get_CurMissileCount(); // 0x06eb0e78
	System.Boolean get_HasAimingModule(); // 0x06eb0eec
	System.Int64 get_NextAllowLaunchTime(); // 0x06eb0f60
	System.Int64 get_LaunchPlayerID(); // 0x06eb0fd4
	System.Boolean get_IsLanuching(); // 0x06eb1048
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06eb10bc
	System.Void RemoteCallRotateCartridge(WizardGames.Soc.Common.Framework.Network.ERpcTarget target, System.Single targetX, System.Single targetY, System.Single targetZ); // 0x06eb113c
	System.Single get_PosX_Smooth(); // 0x054a5abc
	System.Void set_PosX_Smooth(System.Single value); // 0x05513724
	System.Single get_PosY_Smooth(); // 0x054a5abc
	System.Void set_PosY_Smooth(System.Single value); // 0x05513724
	System.Single get_PosZ_Smooth(); // 0x054a5abc
	System.Void set_PosZ_Smooth(System.Single value); // 0x05513724
	System.Single get_RotateX_Smooth(); // 0x054a5abc
	System.Void set_RotateX_Smooth(System.Single value); // 0x05513724
	System.Single get_RotateY_Smooth(); // 0x054a5abc
	System.Void set_RotateY_Smooth(System.Single value); // 0x05513724
	System.Single get_RotateZ_Smooth(); // 0x054a5abc
	System.Void set_RotateZ_Smooth(System.Single value); // 0x05513724
	System.Int64 get_ParentId(); // 0x054a4380
	System.Int64 get_MountID(); // 0x054a4380
	System.Boolean get_HasLocalRotation(); // 0x06eb18e8
	System.Void CopyPositionAndRotation(UnityEngine.Vector3& pos, UnityEngine.Vector3& rotate); // 0x06eb194c
	System.Void CopyLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation); // 0x06eb1a28
	System.Boolean NeedSmooth(UnityEngine.Vector3 lastPos, UnityEngine.Vector3 lastRotate); // 0x06eb1aa4
	System.Void Init(); // 0x06eb1b5c
	static System.Void .cctor(); // 0x06eb1bfc
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.LowLodBoxEntity : WizardGames.Soc.Common.Entity.BoxEntity
{
	static System.Int32 CLASS_HASH = 664783590;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Int32 GetClassHash(); // 0x06eb29b8
	System.String GetTypeName(); // 0x06eb2a20
	System.Int32 get_EntityType(); // 0x06eb2a98
	System.Void .ctor(); // 0x06eb2afc
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06eb2b88
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06eb2c38
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06eb2ce8
	static System.Void .cctor(); // 0x06eb2d68
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.MagicFieldEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Common.Entity.ISmoothCloneEntity
{
	static System.Int32 CLASS_HASH = 35392983;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Single <PosX_Smooth>k__BackingField; // 0x5c
	System.Single <PosY_Smooth>k__BackingField; // 0x60
	System.Single <PosZ_Smooth>k__BackingField; // 0x64
	System.Single <RotateX_Smooth>k__BackingField; // 0x68
	System.Single <RotateY_Smooth>k__BackingField; // 0x6c
	System.Single <RotateZ_Smooth>k__BackingField; // 0x70
	System.Int64 <ParentId>k__BackingField; // 0x78
	System.Int64 <MountID>k__BackingField; // 0x80
	System.Int32 GetClassHash(); // 0x06eb3524
	System.String GetTypeName(); // 0x06eb358c
	System.Int32 get_EntityType(); // 0x06eb3604
	System.Void .ctor(); // 0x06eb3668
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06eb36f8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06eb37a8
	System.Int64 get_TemplateId(); // 0x06eb3858
	System.Single get_PosX(); // 0x06eb38cc
	System.Void set_PosX(System.Single value); // 0x06eb3940
	System.Single get_PosY(); // 0x06eb39cc
	System.Void set_PosY(System.Single value); // 0x06eb3a40
	System.Single get_PosZ(); // 0x06eb3acc
	System.Void set_PosZ(System.Single value); // 0x06eb3b40
	System.Single get_RotateX(); // 0x06eb3bcc
	System.Void set_RotateX(System.Single value); // 0x06eb3c40
	System.Single get_RotateY(); // 0x06eb3ccc
	System.Void set_RotateY(System.Single value); // 0x06eb3d40
	System.Single get_RotateZ(); // 0x06eb3dcc
	System.Void set_RotateZ(System.Single value); // 0x06eb3e40
	System.Int64 get_CreateEntityID(); // 0x06eb3ecc
	System.Int32 get_CreateIndex(); // 0x06eb3f40
	System.Int64 get_PlayerID(); // 0x06eb3fb4
	System.Boolean get_IsCreateByMerge(); // 0x06eb4028
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06eb409c
	System.Single get_PosX_Smooth(); // 0x06eb411c
	System.Void set_PosX_Smooth(System.Single value); // 0x06eb4180
	System.Single get_PosY_Smooth(); // 0x06eb41f8
	System.Void set_PosY_Smooth(System.Single value); // 0x06eb425c
	System.Single get_PosZ_Smooth(); // 0x06eb42d4
	System.Void set_PosZ_Smooth(System.Single value); // 0x06eb4338
	System.Single get_RotateX_Smooth(); // 0x06eb43b0
	System.Void set_RotateX_Smooth(System.Single value); // 0x06eb4414
	System.Single get_RotateY_Smooth(); // 0x06eb448c
	System.Void set_RotateY_Smooth(System.Single value); // 0x06eb44f0
	System.Single get_RotateZ_Smooth(); // 0x06eb4568
	System.Void set_RotateZ_Smooth(System.Single value); // 0x06eb45cc
	System.Int64 get_ParentId(); // 0x06eb4644
	System.Int64 get_MountID(); // 0x06eb46a8
	System.Boolean get_HasLocalRotation(); // 0x06eb470c
	System.Void CopyPositionAndRotation(UnityEngine.Vector3& pos, UnityEngine.Vector3& rotate); // 0x06eb4770
	System.Void CopyLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation); // 0x06eb4834
	System.Boolean NeedSmooth(UnityEngine.Vector3 lastPos, UnityEngine.Vector3 lastRotate); // 0x06eb48b0
	static System.Void .cctor(); // 0x06eb4968
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.MissileEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.ISmoothCloneEntity
{
	static System.Int32 CLASS_HASH = 591568809;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Single <PosX_Smooth>k__BackingField; // 0x5c
	System.Single <PosY_Smooth>k__BackingField; // 0x60
	System.Single <PosZ_Smooth>k__BackingField; // 0x64
	System.Single <RotateX_Smooth>k__BackingField; // 0x68
	System.Single <RotateY_Smooth>k__BackingField; // 0x6c
	System.Single <RotateZ_Smooth>k__BackingField; // 0x70
	System.Int64 <ParentId>k__BackingField; // 0x78
	System.Int64 <MountID>k__BackingField; // 0x80
	static SocLogger Log; // 0x10
	System.Int32 GetClassHash(); // 0x06eb4fd4
	System.String GetTypeName(); // 0x06eb503c
	System.Int32 get_EntityType(); // 0x06eb50b4
	System.Void .ctor(); // 0x06eb5118
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06eb51a8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06eb5258
	System.Single get_PosX(); // 0x06eb5308
	System.Void set_PosX(System.Single value); // 0x06eb537c
	System.Single get_PosY(); // 0x06eb5408
	System.Void set_PosY(System.Single value); // 0x06eb547c
	System.Single get_PosZ(); // 0x06eb5508
	System.Void set_PosZ(System.Single value); // 0x06eb557c
	System.Single get_RotateY(); // 0x06eb5608
	System.Void set_RotateY(System.Single value); // 0x06eb567c
	System.Single get_RotateX(); // 0x06eb5708
	System.Void set_RotateX(System.Single value); // 0x06eb577c
	System.Single get_RotateZ(); // 0x06eb5808
	System.Void set_RotateZ(System.Single value); // 0x06eb587c
	System.Int64 get_TemplateId(); // 0x06eb5908
	System.Int64 get_KatyushaId(); // 0x06eb597c
	System.Int32 get_Order(); // 0x06eb59f0
	System.Int64 get_CreateTime(); // 0x06eb5a64
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06eb5ad8
	System.Void ExecuteRpc(WizardGames.Soc.Share.Framework.Network.DecodedRpc rpc); // 0x06eb5b58
	System.Single get_PosX_Smooth(); // 0x06eb63dc
	System.Void set_PosX_Smooth(System.Single value); // 0x06eb6440
	System.Single get_PosY_Smooth(); // 0x06eb64b8
	System.Void set_PosY_Smooth(System.Single value); // 0x06eb651c
	System.Single get_PosZ_Smooth(); // 0x06eb6594
	System.Void set_PosZ_Smooth(System.Single value); // 0x06eb65f8
	System.Single get_RotateX_Smooth(); // 0x06eb6670
	System.Void set_RotateX_Smooth(System.Single value); // 0x06eb66d4
	System.Single get_RotateY_Smooth(); // 0x06eb674c
	System.Void set_RotateY_Smooth(System.Single value); // 0x06eb67b0
	System.Single get_RotateZ_Smooth(); // 0x06eb6828
	System.Void set_RotateZ_Smooth(System.Single value); // 0x06eb688c
	System.Int64 get_ParentId(); // 0x06eb6904
	System.Int64 get_MountID(); // 0x06eb6968
	System.Boolean get_HasLocalRotation(); // 0x06eb69cc
	System.Void CopyPositionAndRotation(UnityEngine.Vector3& pos, UnityEngine.Vector3& rotate); // 0x06eb6a30
	System.Void CopyLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation); // 0x06eb6af4
	System.Boolean NeedSmooth(UnityEngine.Vector3 lastPos, UnityEngine.Vector3 lastRotate); // 0x06eb6b70
	System.Void MissileExplore(System.Boolean isplayEffects, System.Single x, System.Single y, System.Single z); // 0x06eb5dfc
	static System.Void .cctor(); // 0x06eb6c28
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.ModularCarEntity : WizardGames.Soc.Common.Entity.BaseVehicleEntity, WizardGames.Soc.Common.Entity.IHaveEmbedded, WizardGames.Soc.Common.Entity.ISmoothCloneEntity
{
	static System.Int32 CLASS_HASH = 1768609351;
	static System.Int32 StaticClassHash; // 0x0
	static System.String[] PropNameArray; // 0x8
	System.Single <PosX_Smooth>k__BackingField; // 0xd4
	System.Single <PosY_Smooth>k__BackingField; // 0xd8
	System.Single <PosZ_Smooth>k__BackingField; // 0xdc
	System.Single <RotateX_Smooth>k__BackingField; // 0xe0
	System.Single <RotateY_Smooth>k__BackingField; // 0xe4
	System.Single <RotateZ_Smooth>k__BackingField; // 0xe8
	System.Int64 <ParentId>k__BackingField; // 0xf0
	System.Int64 <MountID>k__BackingField; // 0xf8
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.VehicleModuleCustom> socketModules; // 0x100
	System.Int32 GetClassHash(); // 0x06eb70c4
	System.String GetTypeName(); // 0x06eb712c
	System.Int32 get_EntityType(); // 0x06eb71a4
	System.Void .ctor(); // 0x06eb7208
	System.Void .ctor(System.Int64 entityId, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06eb7294
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06eb7448
	System.Boolean get_IsModuleInit(); // 0x06eb74f8
	System.Void set_IsModuleInit(System.Boolean value); // 0x06eb756c
	WizardGames.Soc.Common.CustomType.VehicleModuleCustom get_Socket1ModuleCustom(); // 0x06eb75f8
	System.Void set_Socket1ModuleCustom(WizardGames.Soc.Common.CustomType.VehicleModuleCustom value); // 0x06eb76bc
	WizardGames.Soc.Common.CustomType.VehicleModuleCustom get_Socket2ModuleCustom(); // 0x06eb7748
	System.Void set_Socket2ModuleCustom(WizardGames.Soc.Common.CustomType.VehicleModuleCustom value); // 0x06eb780c
	WizardGames.Soc.Common.CustomType.VehicleModuleCustom get_Socket3ModuleCustom(); // 0x06eb7898
	System.Void set_Socket3ModuleCustom(WizardGames.Soc.Common.CustomType.VehicleModuleCustom value); // 0x06eb795c
	WizardGames.Soc.Common.CustomType.VehicleModuleCustom get_Socket4ModuleCustom(); // 0x06eb79e8
	System.Void set_Socket4ModuleCustom(WizardGames.Soc.Common.CustomType.VehicleModuleCustom value); // 0x06eb7aac
	System.Int32 get_LifeStage(); // 0x06eb7b38
	System.Void set_LifeStage(System.Int32 value); // 0x06eb7bac
	System.UInt64 get_LockPlayerRoleId(); // 0x06eb7c38
	System.Void set_LockPlayerRoleId(System.UInt64 value); // 0x06eb7cac
	System.Int32 get_LiftState(); // 0x06eb7d38
	System.Void set_LiftState(System.Int32 value); // 0x06eb7dac
	System.Void set_GrabLifterEntityId(System.Int64 value); // 0x06eb7e38
	System.Boolean IsPositionRelatedField(System.Int32 propertyId); // 0x06eb7ec4
	System.Void InvokeChildOnCustomCreate(); // 0x06eb7f44
	System.Void InvokeChildOnCustomRemove(); // 0x06eb8258
	WizardGames.Soc.Share.Framework.IPredictType GetNewInstance(System.Int64 id); // 0x06eb859c
	System.Single get_PosX_Smooth(); // 0x054a5abc
	System.Void set_PosX_Smooth(System.Single value); // 0x05513724
	System.Single get_PosY_Smooth(); // 0x054a5abc
	System.Void set_PosY_Smooth(System.Single value); // 0x05513724
	System.Single get_PosZ_Smooth(); // 0x054a5abc
	System.Void set_PosZ_Smooth(System.Single value); // 0x05513724
	System.Single get_RotateX_Smooth(); // 0x054a5abc
	System.Void set_RotateX_Smooth(System.Single value); // 0x05513724
	System.Single get_RotateY_Smooth(); // 0x054a5abc
	System.Void set_RotateY_Smooth(System.Single value); // 0x05513724
	System.Single get_RotateZ_Smooth(); // 0x054a5abc
	System.Void set_RotateZ_Smooth(System.Single value); // 0x05513724
	System.Int64 get_ParentId(); // 0x054a4380
	System.Int64 get_MountID(); // 0x054a4380
	System.Boolean get_HasLocalRotation(); // 0x06eb8cd0
	System.Void Init(); // 0x06eb8d34
	System.Void CopyPositionAndRotation(UnityEngine.Vector3& pos, UnityEngine.Vector3& rotate); // 0x06eb8dd4
	System.Void CopyLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation); // 0x06eb8eb0
	System.Boolean NeedSmooth(UnityEngine.Vector3 lastPos, UnityEngine.Vector3 lastRotate); // 0x06eb8f2c
	System.Void SubscribePropertyChange(WizardGames.Soc.Common.Entity.ModularCarEntity target, WizardGames.Soc.Common.Unity.Go.BaseMountableGo _mountableGo); // 0x0552af00
	System.Void OnSocket1ModuleCustomChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue, WizardGames.Soc.Common.Entity.ModularCarEntity target); // 0x06eb96d8
	System.Void OnSocket2ModuleCustomChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue, WizardGames.Soc.Common.Entity.ModularCarEntity target); // 0x06eb9858
	System.Void OnSocket3ModuleCustomChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue, WizardGames.Soc.Common.Entity.ModularCarEntity target); // 0x06eb99d8
	System.Void OnSocket4ModuleCustomChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue, WizardGames.Soc.Common.Entity.ModularCarEntity target); // 0x06eb9b58
	System.Void OnLifeStageChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.Entity.ModularCarEntity target); // 0x06eb9cd8
	System.Void OnLockPlayerRoleIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.UInt64 oldValue, System.UInt64 newValue, WizardGames.Soc.Common.Entity.ModularCarEntity target); // 0x06eb9d80
	System.Void OnLiftStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.Entity.ModularCarEntity target); // 0x06eb9e28
	System.Void OnGrabLifterEntityIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.Entity.ModularCarEntity target); // 0x06eb9ed0
	System.Boolean get_IsAlive(); // 0x06eb9f78
	System.Boolean get_IsDead(); // 0x06eb9fe8
	System.Int32 get_DriversCount(); // 0x06eba058
	System.Void SetSocketModule(WizardGames.Soc.Common.CustomType.VehicleModuleCustom entity, System.Int32 socketIndex, System.Int32 socketsTaken); // 0x06eba144
	System.Boolean HasAnyMounted(); // 0x06eba354
	System.Void .ctor(System.Int64 id); // 0x06eb863c
	WizardGames.Soc.Common.Entity.IVehicleModuleCustom get_Socket1Module(); // 0x06eba420
	System.Void set_Socket1Module(WizardGames.Soc.Common.Entity.IVehicleModuleCustom value); // 0x06eba484
	WizardGames.Soc.Common.Entity.IVehicleModuleCustom get_Socket2Module(); // 0x06eba548
	System.Void set_Socket2Module(WizardGames.Soc.Common.Entity.IVehicleModuleCustom value); // 0x06eba5ac
	WizardGames.Soc.Common.Entity.IVehicleModuleCustom get_Socket3Module(); // 0x06eba670
	System.Void set_Socket3Module(WizardGames.Soc.Common.Entity.IVehicleModuleCustom value); // 0x06eba6d4
	WizardGames.Soc.Common.Entity.IVehicleModuleCustom get_Socket4Module(); // 0x06eba798
	System.Void set_Socket4Module(WizardGames.Soc.Common.Entity.IVehicleModuleCustom value); // 0x06eba7fc
	System.Void SetModuleViaSocketIndex(System.Int32 socketIndex, WizardGames.Soc.Common.CustomType.VehicleModuleCustom module); // 0x06eba1e0
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.VehicleModuleCustom> GetModuleEntities(); // 0x054e7844
	System.String ToPrettyString(); // 0x06ebad84
	static System.Void .cctor(); // 0x06ebb0b8
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.ModularCarEntity.<>c__DisplayClass83_0 : System.Object
{
	WizardGames.Soc.Common.Entity.ModularCarEntity <>4__this; // 0x10
	WizardGames.Soc.Common.Entity.ModularCarEntity target; // 0x18
	System.Void .ctor(); // 0x06eb9670
	System.Void <SubscribePropertyChange>b__0(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue); // 0x06ebbd84
	System.Void <SubscribePropertyChange>b__1(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue); // 0x06ebbe30
	System.Void <SubscribePropertyChange>b__2(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue); // 0x06ebbedc
	System.Void <SubscribePropertyChange>b__3(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue); // 0x06ebbf88
	System.Void <SubscribePropertyChange>b__4(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x06ebc034
	System.Void <SubscribePropertyChange>b__5(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.UInt64 oldValue, System.UInt64 newValue); // 0x06ebc0e0
	System.Void <SubscribePropertyChange>b__6(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x06ebc18c
	System.Void <SubscribePropertyChange>b__7(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x06ebc238
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.MonsterEntity : WizardGames.Soc.Share.Framework.EntityBase, WizardGames.Soc.Share.Framework.IPositionEntity, WizardGames.Soc.Share.Framework.IPosition2Entity, WizardGames.Soc.Common.Entity.IRotation3Entity, WizardGames.Soc.Common.Entity.IRotationEntity, WizardGames.Soc.Common.Entity.ITemplateEntity, WizardGames.Soc.Common.Entity.ISpawnEntity, WizardGames.Soc.Common.Entity.ICombatEntity, WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Common.Entity.IShortcutEntity, WizardGames.Soc.Common.Entity.IMountVehicleEntity, WizardGames.Soc.Common.Entity.IMovableEntity, WizardGames.Soc.Common.Entity.IHaveEmbedded, WizardGames.Soc.Common.Entity.ISmoothCloneEntity, CommonUnity.Runtime.Entity.ISeekerTarget
{
	static System.Int32 CLASS_HASH = 735457143;
	static System.Int32 StaticClassHash; // 0x0
	static System.String TYPE_NAME = "MonsterEntity";
	static System.String[] PropNameArray; // 0x8
	System.Single RotateY_Local; // 0x5c
	System.Single TargetLookX_Local; // 0x60
	System.Single TargetLookY_Local; // 0x64
	System.Single TargetLookZ_Local; // 0x68
	System.Int32 MoveType_Local; // 0x6c
	System.Int32 BattleState_Local; // 0x70
	System.Single SpeedX_Local; // 0x74
	System.Single SpeedZ_Local; // 0x78
	System.Int64 MeleeAttackTS_Local; // 0x80
	System.Int64 CurrentHeldItemId_Local; // 0x88
	System.Int32 MoveTypeDt_Local; // 0x90
	System.Int32 Type_Local; // 0x94
	System.Int64 TargetId_Local; // 0x98
	System.Int64 MountableId_Local; // 0xa0
	System.Byte MonsterLifeState_Local; // 0xa8
	System.Byte MonsterPoseState_Local; // 0xa9
	System.Byte MonsterAttackState_Local; // 0xaa
	System.Byte MonsterActionState_Local; // 0xab
	System.Byte MonsterDirectionType_Local; // 0xac
	System.Byte MonsterMoveState_Local; // 0xad
	System.Int32 SpecialIdleAnimType_Local; // 0xb0
	System.Int32 NormalAttackType_Local; // 0xb4
	System.Single <PosX_Smooth>k__BackingField; // 0xb8
	System.Single <PosY_Smooth>k__BackingField; // 0xbc
	System.Single <PosZ_Smooth>k__BackingField; // 0xc0
	System.Single <RotateX_Smooth>k__BackingField; // 0xc4
	System.Single <RotateY_Smooth>k__BackingField; // 0xc8
	System.Single <RotateZ_Smooth>k__BackingField; // 0xcc
	System.Int64 <ParentId>k__BackingField; // 0xd0
	System.Int64 <MountID>k__BackingField; // 0xd8
	WizardGames.Soc.Common.Entity.MonsterEntity.EDeathState DeathState; // 0xe0
	WizardGames.Soc.Common.Entity.MonsterEntity.EIdleAnim IdleAnim; // 0xe4
	System.Single IdleAnimTime; // 0xe8
	System.Boolean NextIdleAnimUse03; // 0xec
	System.Single idleAnimationDuration1; // 0xf0
	System.Single idleAnimationDuration2; // 0xf4
	System.Single idleAnimationDuration3; // 0xf8
	System.Int32 <BuoyancyPhase>k__BackingField; // 0xfc
	System.Int64 <LastUpdateBuoyancyTime>k__BackingField; // 0x100
	System.Single <FloatAcc>k__BackingField; // 0x108
	System.Single <FloatSpeedMax>k__BackingField; // 0x10c
	System.Single <StaticDepthAcc>k__BackingField; // 0x110
	System.Single <DampingAcc>k__BackingField; // 0x114
	System.Single <DampingAmpMin>k__BackingField; // 0x118
	System.Int64 <LastLogTime>k__BackingField; // 0x120
	System.Single <CurFloatingSpeed>k__BackingField; // 0x128
	System.Int64 PreviousWeaponId; // 0x130
	System.Int64 PreviousBehaviorTemplateId; // 0x138
	System.Int64 <CtrlId>k__BackingField; // 0x140
	System.Single <Steering>k__BackingField; // 0x148
	System.Object <BasePlayerType>k__BackingField; // 0x150
	System.Boolean <IsInAir>k__BackingField; // 0x158
	System.Boolean <IsGround>k__BackingField; // 0x159
	System.Int32 <AirTimeAcc>k__BackingField; // 0x15c
	System.Boolean <MarkAttackerHostile>k__BackingField; // 0x160
	System.Boolean HasPreloadCorpse; // 0x161
	System.Boolean IsRotating; // 0x162
	System.Boolean IsBot; // 0x163
	System.Boolean LogEnabled; // 0x164
	System.Int32 AnimationType; // 0x168
	System.Boolean CanChangeAiState; // 0x16c
	WizardGames.Soc.Common.State.Monster.EMonsterPoseState LocalMonsterPoseState; // 0x16d
	System.Int32 CoverBack; // 0x170
	WizardGames.Soc.Common.Entity.MonsterEntity.CoverStateEnum CoverState; // 0x174
	System.Single HitToCoverPossible; // 0x178
	System.Single ReloadToCoverPossible; // 0x17c
	System.Single SwitchCoverPossible; // 0x180
	System.Boolean IsComplete; // 0x184
	System.Boolean IsAiStateEnteredTag; // 0x185
	System.Boolean IsAnimStateEnteredTag; // 0x186
	System.Boolean IsReload; // 0x187
	System.Boolean AutoTurretReload; // 0x188
	System.Boolean CanReloadQuit; // 0x189
	System.Boolean IsSwitchWeapon; // 0x18a
	System.Boolean CanChangeWeapon; // 0x18b
	System.Boolean CanCombat; // 0x18c
	System.Boolean CanShoot; // 0x18d
	System.Boolean BeThrowing; // 0x18e
	System.Single AtkTimeInterval; // 0x190
	System.Int32 bulletCount; // 0x194
	System.Single AtkStartTime; // 0x198
	System.Single AtkEndTime; // 0x19c
	System.Int32 AimType; // 0x1a0
	System.Boolean BrakeMove; // 0x1a4
	System.Single LastShootTime; // 0x1a8
	System.Single LastShootSuccessTime; // 0x1ac
	System.Int64 LastBeAtkedEntId; // 0x1b0
	System.Single LastBeAtkedTime; // 0x1b8
	System.Single AtkedLogTime; // 0x1bc
	System.Single NextAttackTime; // 0x1c0
	System.Single AttackTime; // 0x1c4
	System.Single AttackCD; // 0x1c8
	System.Single DamageTime; // 0x1cc
	System.Numerics.Vector3 AttackOffset; // 0x1d0
	System.Single CombatAttackDamage; // 0x1dc
	System.Single ShootAttackDamage; // 0x1e0
	System.Boolean IsAttack; // 0x1e4
	System.Boolean AttackEnd; // 0x1e5
	System.Single FirstBattleStateTimestamp; // 0x1e8
	System.Boolean FirstBattleStateHasBeen; // 0x1ec
	System.Single <LastReloadTime>k__BackingField; // 0x1f0
	System.Int64 <LastAttackPlayerId>k__BackingField; // 0x1f8
	System.Int64 <LastAttackedTimeByPlayer>k__BackingField; // 0x200
	System.Int32 ResumeDeRateBulletCount; // 0x208
	System.Int64 StartDeRateBulletTime; // 0x210
	System.Boolean DeRateBulletTag; // 0x218
	System.Numerics.Vector3 ClientTargetAtkPos; // 0x21c
	System.Numerics.Vector3 ClientWeaponIkBasePos; // 0x228
	System.Nullable<System.Numerics.Vector3> LastVisibleTargetShootPos; // 0x234
	System.Nullable<System.Numerics.Vector3> LastVisibleSndTargetShootPos; // 0x244
	System.Single StandTurnStartRotateY; // 0x254
	System.Single StandTurnTargetRotateY; // 0x258
	System.Single StandTurnAngle; // 0x25c
	System.Single NextTurnTime; // 0x260
	System.Boolean InTurn; // 0x264
	System.Single ClientMoveDirX; // 0x268
	System.Single ClientMoveDirZ; // 0x26c
	System.Single ClientMoveDirOriginX; // 0x270
	System.Single ClientMoveDirOriginZ; // 0x274
	System.Numerics.Vector3 ClientLookForwardDir; // 0x278
	System.Single LastMoveX; // 0x284
	System.Single LastMoveZ; // 0x288
	System.Int64 LastMoveTime; // 0x290
	System.Int64 NextSpecialIdleAnimTime; // 0x298
	System.Int64 EnterSpecialIdleAnimTime; // 0x2a0
	System.Single TargetPosX; // 0x2a8
	System.Single TargetPosY; // 0x2ac
	System.Single TargetPosZ; // 0x2b0
	System.Single <Acceleration>k__BackingField; // 0x2b4
	System.Single[] SpeedFraction; // 0x2b8
	System.Int32 SpeedTimeState; // 0x2c0
	System.Single TraceDecisionStartTime; // 0x2c4
	System.Boolean NoEntryToMonument; // 0x2c8
	System.Boolean NeedInCanChaseArea; // 0x2c9
	System.Boolean NoEntryToSafeArea; // 0x2ca
	System.Single Sleep; // 0x2cc
	System.Boolean IsSleep; // 0x2d0
	System.Single <MaxWakeupTime>k__BackingField; // 0x2d4
	System.Single <WakeupTime>k__BackingField; // 0x2d8
	System.Single DeathTime; // 0x2dc
	System.Single DeathAudioTime; // 0x2e0
	System.Single ClientDeathAnimStartTime; // 0x2e4
	System.Boolean IsRoll; // 0x2e8
	System.Boolean IsRecourse; // 0x2e9
	System.Boolean IsShow; // 0x2ea
	System.Single ActionStateTime; // 0x2ec
	System.Boolean IsInShelter; // 0x2f0
	System.Int64 BehaviorTreeId; // 0x2f8
	System.Single TargetLookXLocal; // 0x300
	System.Single TargetLookYLocal; // 0x304
	System.Single TargetLookZLocal; // 0x308
	System.Numerics.Vector3 PositionLocal; // 0x30c
	System.Single RotateYLocal; // 0x318
	System.Boolean <IsCallingForHelp>k__BackingField; // 0x31c
	System.Single <IsCallingForHelpDuration>k__BackingField; // 0x320
	WizardGames.Soc.Common.State.Monster.EMonsterAiState aiStateLocal; // 0x324
	WizardGames.Soc.Common.State.Monster.EMonsterAiState <LastAiStateLocal>k__BackingField; // 0x325
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> ChangeWeaponDistance; // 0x328
	System.Single ChangeWeaponCD; // 0x330
	System.Int64 LastChangeWeaponTime; // 0x338
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Entity.MonsterEntity.EThrowWeaponID,System.Int64> LastThrowTimeMap; // 0x340
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Entity.MonsterEntity.AIRelationTriggerInfo> mAIRelationDic; // 0x348
	System.Int32 CurrentSenseParamId; // 0x350
	System.Collections.Generic.List<System.Int32> SenseTypeData; // 0x358
	System.Boolean ChaseOceanTarget; // 0x360
	System.Single SwitchSwimmingWadeDepth; // 0x364
	System.Boolean senseFriendlies; // 0x368
	System.String PrefabPath; // 0x370
	System.String HitboxPath; // 0x378
	System.Int32 SpeciesType; // 0x380
	System.String Name; // 0x388
	System.Int32 AiParamId; // 0x390
	System.Int32 BulletMaxCount; // 0x394
	System.Single BulletReloadTime; // 0x398
	System.Single BulletSpeed; // 0x39c
	System.Single AtkShootInterval; // 0x3a0
	System.Single MissAngleLimit; // 0x3a4
	System.Single RecourseTime; // 0x3a8
	System.Single MinHitRate; // 0x3ac
	System.Single ActionStateTimeClient; // 0x3b0
	System.Single CurrentLerpHipSight; // 0x3b4
	System.Int32 poseStateTarget; // 0x3b8
	System.Single CurrentLerpCrouchStand; // 0x3bc
	System.Single poseStateChangeStartValue; // 0x3c0
	System.Int64 poseStateChangeStartTime; // 0x3c8
	WizardGames.Soc.Common.State.Monster.AdditiveLayerStateEnum AddLayerState; // 0x3d0
	WizardGames.Soc.Common.State.Monster.FullBodyLayerStateEnum FullBodyLayerState; // 0x3d4
	WizardGames.Soc.Common.State.Monster.LowerLayerStateEnum LowerLayerState; // 0x3d8
	WizardGames.Soc.Common.State.Monster.UpperLayerStateEnum UpperLayerState; // 0x3dc
	System.Single CurUpperLayerWeight; // 0x3e0
	System.Single TargetUpperLayerWeight; // 0x3e4
	System.Single CurFullBodyLayerWeight; // 0x3e8
	System.Single TargetFullBodyLayerWeight; // 0x3ec
	System.Single CurTwoHandLayerWeight; // 0x3f0
	System.Single TargetTwoHandLayerWeight; // 0x3f4
	System.Single CurHandLayerWeight; // 0x3f8
	System.Single TargetHandLayerWeight; // 0x3fc
	System.Single ClientAnimBlendX; // 0x400
	System.Single ClientAnimBlendY; // 0x404
	System.Single ClientAnimMoveStateBlend; // 0x408
	System.Single ClientAnimTargetUpDown; // 0x40c
	System.Single ClientAnimOrgTargetUpDown; // 0x410
	System.Single ClientAnimCurUpDown; // 0x414
	System.Single ClientAnimUpDownTime; // 0x418
	System.Single ClientLastAnimUpdateTime; // 0x41c
	System.Int32 ClientLastMoveType; // 0x420
	System.Int32 ClientLastBattleState; // 0x424
	System.Single ClientLastUpperLayerUpdateTime; // 0x428
	WizardGames.Soc.Common.Entity.MonsterEntity.EPoseLayerState PoseLayerState; // 0x42c
	WizardGames.Soc.Common.Entity.MonsterEntity.ELocomotionLayerState LocomotionLayerState; // 0x430
	WizardGames.Soc.Common.Entity.MonsterEntity.EAdditiveLayerState AdditiveLayerstate; // 0x434
	WizardGames.Soc.Common.Entity.MonsterEntity.EAimOffsetLayerState AimOffsetLayerState; // 0x438
	System.Int64 LastMeleeAttackTS; // 0x440
	System.Single ToLocomotionPoseTime; // 0x448
	System.Single ToIdlePoseTime; // 0x44c
	System.Single StartIdle2LocoLerp; // 0x450
	System.Boolean ToIdlePoseFlag; // 0x454
	System.Boolean ToLocomotionPoseFlag; // 0x455
	System.Single LeftIdle2LocoLerp; // 0x458
	System.Int64 LocomotionLayerTargetWeightTpWeaponId; // 0x460
	System.Single LocomotionLayerTargetWeightTp; // 0x468
	System.Single LocomotionLayerOverrideTargetWeightTp; // 0x46c
	System.Single LocomotionLayerNowWeightTp; // 0x470
	System.Single LocomotionLayerWeightTimeTp; // 0x474
	System.Single LocomotionLayerWeightSpeedTp; // 0x478
	System.Single LocomotionSpineLayerTargetWeightTp; // 0x47c
	System.Single LocomotionSpineLayerOverrideTargetWeightTp; // 0x480
	System.Single LocomotionSpineLayerNowWeightTp; // 0x484
	System.Single LocomotionSpineLayerWeightTimeTp; // 0x488
	System.Single LocomotionSpineLayerWeightSpeedTp; // 0x48c
	System.Single LocomotionWeaponLayerTargetWeightTp; // 0x490
	System.Single LocomotionWeaponLayerOverrideTargetWeightTp; // 0x494
	System.Single LocomotionWeaponLayerNowWeightTp; // 0x498
	System.Single LocomotionWeaponLayerWeightTimeTp; // 0x49c
	System.Single LocomotionWeaponLayerWeightSpeedTp; // 0x4a0
	System.Single LocomotionLeftArmLayerTargetWeightTp; // 0x4a4
	System.Single LocomotionLeftArmLayerOverrideTargetWeightTp; // 0x4a8
	System.Single LocomotionLeftArmLayerNowWeightTp; // 0x4ac
	System.Single LocomotionLeftArmLayerWeightTimeTp; // 0x4b0
	System.Single LocomotionLeftArmLayerWeightSpeedTp; // 0x4b4
	System.Single LocomotionRightArmLayerTargetWeightTp; // 0x4b8
	System.Single LocomotionRightArmLayerOverrideTargetWeightTp; // 0x4bc
	System.Single LocomotionRightArmLayerNowWeightTp; // 0x4c0
	System.Single LocomotionRightArmLayerWeightTimeTp; // 0x4c4
	System.Single LocomotionRightArmLayerWeightSpeedTp; // 0x4c8
	System.Boolean BowShowArrow; // 0x4cc
	System.Single[] IdleAudioInterval; // 0x4d0
	System.String IdleAudioEvent; // 0x4d8
	System.String DeathAudioEvent; // 0x4e0
	System.String SwitchBattleAudioEvent; // 0x4e8
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> SwitchBattleAudioInterval; // 0x4f0
	System.Int32 MaxGroupSize; // 0x4f8
	System.Object WeaponAnimSmbData; // 0x500
	WizardGames.Soc.Common.Unity.Character.AnimParametersScientist TpParameters; // 0x508
	System.Int32 DieType; // 0x564
	System.Boolean HasFeedType; // 0x568
	System.Single FeedRange; // 0x56c
	System.Collections.Generic.Dictionary<System.Int64,System.Boolean> FeedEntityId; // 0x570
	System.Int32 FeedTerrainType; // 0x578
	System.Boolean InFeedMove; // 0x57c
	System.Numerics.Vector3 FeedDest; // 0x580
	System.Boolean StartFeed; // 0x58c
	System.Boolean HasFeed; // 0x58d
	System.Single FirstFeedTime; // 0x590
	System.Int64 FeedTargetId; // 0x598
	System.Int64 FleeTargetId; // 0x5a0
	System.Int64 FinalFleeId; // 0x5a8
	System.Boolean SelfHeal; // 0x5b0
	System.Single SearchCoverRange; // 0x5b4
	System.Single MinCoverSocre; // 0x5b8
	System.Single MaxTravelToCover; // 0x5bc
	System.Single MinCoverScoreDefense; // 0x5c0
	WizardGames.Soc.Common.Algorithm.ConstList<System.Int32> FittingCoverType; // 0x5c8
	System.Single expectShootAngleInCover; // 0x5d0
	System.Single expectCoverToTargetMinDistance; // 0x5d4
	System.Boolean RotateOnCorner; // 0x5d8
	System.Single ForbidAttackTime; // 0x5dc
	System.Boolean RotateInLogic; // 0x5e0
	System.Single TurretSwitchOnSpeed; // 0x5e4
	System.Single TurretSwitchOffSpeed; // 0x5e8
	System.Int32 ActionFlags; // 0x5ec
	System.Int32 UtilityActionFlags; // 0x5f0
	System.Int32 MoveFlags; // 0x5f4
	System.Single SplitRoundTravelCheck; // 0x5f8
	System.Single RoundSplitUtility; // 0x5fc
	System.Single CautiousChaseDistance; // 0x600
	System.Single ChaseMoveUtility; // 0x604
	System.Single ChaseRunUtility; // 0x608
	System.Single SplitBwUtility; // 0x60c
	System.Single ToCoverUtility; // 0x610
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> SwitchPoseCd; // 0x618
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> SwitchPoseTimeOfDuration; // 0x620
	System.Single SwitchPoseStartTime; // 0x628
	System.Single SwitchPoseUtility; // 0x62c
	System.Single BattleSplitUtility; // 0x630
	System.Single SplitLimitAngle; // 0x634
	System.Single SplitLimitAngleForward; // 0x638
	System.Single MaxWadeDepth; // 0x63c
	System.Single MaxWadeDepthOcean; // 0x640
	System.Numerics.Vector3 GroupRoamPoint; // 0x644
	System.Boolean CheckActVolume; // 0x650
	System.Int32 TopologyPreference; // 0x654
	System.Int32 BiomePreference; // 0x658
	System.Single[] <BaseProtection>k__BackingField; // 0x660
	System.Single[][] <AreaProtections>k__BackingField; // 0x668
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> WarningShootBulletHitRate; // 0x670
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> HitRange; // 0x678
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> HitRate; // 0x680
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> LongAttackRange; // 0x688
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> LongHitRange; // 0x690
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> LongHitRate; // 0x698
	System.Single MinLongHitRate; // 0x6a0
	System.Single LongHitDuration; // 0x6a4
	System.Int32 ChaseMode; // 0x6a8
	System.Single SplitProbability; // 0x6ac
	System.Single SplitProbabilityForward; // 0x6b0
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> BattleSplitTimeOfDuration; // 0x6b8
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> BattleSplitForwardTimeOfDuration; // 0x6c0
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> BattleSplitForwardMotionlessTime; // 0x6c8
	System.Single CanBattleSplitDistanceForwardSqr; // 0x6d0
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> SplitRange; // 0x6d8
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> SplitRangeForward; // 0x6e0
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> SplitBwTriggerDis; // 0x6e8
	System.Single SplitBwLimitAngleF; // 0x6f0
	System.Single SplitBwLimitAngleS; // 0x6f4
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> SplitBwMoveInterval; // 0x6f8
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> SplitBwRange; // 0x700
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> ToCoverCd; // 0x708
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> CoverMoveTypeDis; // 0x710
	System.Single StandEyeHeight; // 0x718
	System.Single CrouchEyeHeight; // 0x71c
	System.Single StandBodyHeight; // 0x720
	System.Single CrouchBodyHeight; // 0x724
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> RecourseRange; // 0x728
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> LowerIdleTimeOfDuration; // 0x730
