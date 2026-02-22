	static WizardGames.Soc.Common.State.Monster.EMonsterDirectionType Forward = 1;
	static WizardGames.Soc.Common.State.Monster.EMonsterDirectionType Target = 2;
	static WizardGames.Soc.Common.State.Monster.EMonsterDirectionType TargetLookPos = 3;
	static WizardGames.Soc.Common.State.Monster.EMonsterDirectionType NoTurn = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.State.Monster.EMonsterMoveState : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.State.Monster.EMonsterMoveState Idle = 0;
	static WizardGames.Soc.Common.State.Monster.EMonsterMoveState Move = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.State.Character.LadderTestDir : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.State.Character.LadderTestDir None = 0;
	static WizardGames.Soc.Common.State.Character.LadderTestDir Top = 1;
	static WizardGames.Soc.Common.State.Character.LadderTestDir Bottom = 2;
	static WizardGames.Soc.Common.State.Character.LadderTestDir Fly = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.State.Character.LadderMoveType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.State.Character.LadderMoveType None = 0;
	static WizardGames.Soc.Common.State.Character.LadderMoveType KeepDownMove = 1;
	static WizardGames.Soc.Common.State.Character.LadderMoveType BotExitTolerance = 2;
	static WizardGames.Soc.Common.State.Character.LadderMoveType TopExitTolerance = 4;
	static WizardGames.Soc.Common.State.Character.LadderMoveType FastLadder = 8;
	static WizardGames.Soc.Common.State.Character.LadderMoveType MoveTolerance = 16;
	static WizardGames.Soc.Common.State.Character.LadderMoveType WaitTolerance = 32;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.State.Character.StateRecoveryEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.State.Character.StateRecoveryEnum None = 0;
	static WizardGames.Soc.Common.State.Character.StateRecoveryEnum Draw = 1;
	static WizardGames.Soc.Common.State.Character.StateRecoveryEnum ReloadEmpty = 2;
	static WizardGames.Soc.Common.State.Character.StateRecoveryEnum ReloadEnd = 3;
	static WizardGames.Soc.Common.State.Character.StateRecoveryEnum Inspection = 4;
	static WizardGames.Soc.Common.State.Character.StateRecoveryEnum Attack = 5;
	static WizardGames.Soc.Common.State.Character.StateRecoveryEnum Bolt = 6;
	static WizardGames.Soc.Common.State.Character.StateRecoveryEnum StartUp = 7;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.State.Character.ECommonStateRecoveryEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.State.Character.ECommonStateRecoveryEnum None = 0;
	static WizardGames.Soc.Common.State.Character.ECommonStateRecoveryEnum Mantle = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.State.Character.HeldItemInvisibleStateEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.State.Character.HeldItemInvisibleStateEnum None = 0;
	static WizardGames.Soc.Common.State.Character.HeldItemInvisibleStateEnum Camera = 1;
	static WizardGames.Soc.Common.State.Character.HeldItemInvisibleStateEnum ActionState = 2;
	static WizardGames.Soc.Common.State.Character.HeldItemInvisibleStateEnum Ladder = 4;
	static WizardGames.Soc.Common.State.Character.HeldItemInvisibleStateEnum Zipline = 8;
	static WizardGames.Soc.Common.State.Character.HeldItemInvisibleStateEnum WallBlock = 16;
	static WizardGames.Soc.Common.State.Character.HeldItemInvisibleStateEnum WithHost = 32;
	static WizardGames.Soc.Common.State.Character.HeldItemInvisibleStateEnum Mantle = 64;
	static WizardGames.Soc.Common.State.Character.HeldItemInvisibleStateEnum Interactive = 128;
	static WizardGames.Soc.Common.State.Character.HeldItemInvisibleStateEnum ADS_ForCurrent = 256;
	static WizardGames.Soc.Common.State.Character.HeldItemInvisibleStateEnum AnimEvent_ForCurrent = 512;
	static WizardGames.Soc.Common.State.Character.HeldItemInvisibleStateEnum Observer = 1024;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.State.Character.PlayerInvisibleStateEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.State.Character.PlayerInvisibleStateEnum None = 0;
	static WizardGames.Soc.Common.State.Character.PlayerInvisibleStateEnum Camera = 1;
	static WizardGames.Soc.Common.State.Character.PlayerInvisibleStateEnum Observer = 2;
	static WizardGames.Soc.Common.State.Character.PlayerInvisibleStateEnum Ladder = 4;
	static WizardGames.Soc.Common.State.Character.PlayerInvisibleStateEnum Mantle = 8;
	static WizardGames.Soc.Common.State.Character.PlayerInvisibleStateEnum Sleep = 16;
	static WizardGames.Soc.Common.State.Character.PlayerInvisibleStateEnum TP2FPADSTransition = 32;
	static WizardGames.Soc.Common.State.Character.PlayerInvisibleStateEnum Newbie = 64;
	static WizardGames.Soc.Common.State.Character.PlayerInvisibleStateEnum Telescope = 128;
	static WizardGames.Soc.Common.State.Character.PlayerInvisibleStateEnum CameraCulling = 256;
	static WizardGames.Soc.Common.State.Character.PlayerInvisibleStateEnum LittleEye = 512;
	static WizardGames.Soc.Common.State.Character.PlayerInvisibleStateEnum Photo = 1024;
	static WizardGames.Soc.Common.State.Character.PlayerInvisibleStateEnum Possession = 2048;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Train.MiniCopterEffectConfig : UnityEngine.ScriptableObject
{
	SerializableDictionary<System.Single,WizardGames.Soc.Common.Train.MiniCopterEffectConfig.CopterEffectData> CopterHpEffectDic; // 0x18
	SerializableDictionary<System.Int32,System.Single> CopterHpEffectDelayDic; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.Common.Train.MiniCopterEffectConfig.CopterEffectData> CopterExplodeEffectList; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.Common.Train.MiniCopterEffectConfig.CopterEffectData> CopterStartEffectList; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.Train.MiniCopterEffectConfig.CopterEffectData> CopterHitEffectIds; // 0x38
	SerializableDictionary<WizardGames.Soc.Common.Combat.ColliderMaterialEnum,WizardGames.Soc.Common.Train.MiniCopterEffectConfig.CopterEffectData> CopterFlyGroundEffectList; // 0x40
	WizardGames.Soc.Common.Train.MiniCopterEffectConfig.CopterEffectData DefaultFlyGroundEffect; // 0x48
	System.Single CopterGroundTestDist; // 0x50
	System.Int32 CopterGroundTestInterval; // 0x54
	System.Single CopterStartMaxSpeed; // 0x58
	SerializableDictionary<System.Single,WizardGames.Soc.Common.Unity.Character.SerializeListNestList<WizardGames.Soc.Common.Train.MiniCopterEffectConfig.PropellerEffectData>> PropellerEffectDic; // 0x60
	System.Void .ctor(); // 0x06ce182c
}

// Client.Runtime
class WizardGames.Soc.Common.Train.MiniCopterEffectConfig.CopterEffectData : System.Object
{
	System.Int32 EffectTableId; // 0x10
	System.String EffectBindingName; // 0x18
	System.Boolean Attach; // 0x20
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf Audio; // 0x28
	System.Int32 SkillTableId; // 0x40
	System.Boolean IsSkill; // 0x44
	System.Void .ctor(); // 0x06ce1a9c
}

// Client.Runtime
class WizardGames.Soc.Common.Train.MiniCopterEffectConfig.PropellerEffectData : System.Object
{
	System.Int32 EffectTableId; // 0x10
	System.String EffectBindingName; // 0x18
	System.Void .ctor(); // 0x06ce1b04
}

// Client.Runtime
class WizardGames.Soc.Common.Train.TrainCoupling : System.Object
{
	System.Boolean _isCoupled; // 0x10
	WizardGames.Soc.Common.Train.TrainCar owner; // 0x18
	System.Boolean isFrontCoupling; // 0x20
	WizardGames.Soc.Common.Train.TrainCouplingController controller; // 0x28
	UnityEngine.Transform couplingPoint; // 0x30
	UnityEngine.Transform couplingPivot; // 0x38
	System.Boolean isValid; // 0x40
	WizardGames.Soc.Common.Train.TrainCoupling <CoupledTo>k__BackingField; // 0x48
	TimeSince timeSinceCouplingBlock; // 0x50
	WizardGames.Soc.Common.Train.TrainCoupling rearCoupling; // 0x58
	WizardGames.Soc.Common.Train.TrainCoupling frontCoupling; // 0x60
	System.Void .ctor(WizardGames.Soc.Common.Train.TrainCar owner, System.Boolean isFrontCoupling, WizardGames.Soc.Common.Train.TrainCouplingController controller, UnityEngine.Transform couplingPoint, UnityEngine.Transform couplingPivot); // 0x06ce1b6c
}

// Client.Runtime
class WizardGames.Soc.Common.Train.TrainCouplingController : System.Object
{
	static BaseRustEntity.Flags Flag_CouplingFront = 256;
	static BaseRustEntity.Flags Flag_CouplingRear = 512;
	WizardGames.Soc.Common.Train.TrainCoupling frontCoupling; // 0x10
	WizardGames.Soc.Common.Train.TrainCoupling rearCoupling; // 0x18
	WizardGames.Soc.Common.Train.TrainCar owner; // 0x20
	static System.Single max_couple_speed; // 0x0
	System.Void .ctor(WizardGames.Soc.Common.Train.TrainCar owner); // 0x06ce1cac
	static System.Void .cctor(); // 0x06ce1e00
}

// Client.Runtime
class WizardGames.Soc.Common.Train.TrainCar : BaseVehicle
{
	UnityEngine.Transform TrainUnloadPos; // 0x360
	UnityEngine.Transform FrontBogiePivot; // 0x368
	System.Boolean FrontBogieCanRotate; // 0x370
	UnityEngine.Transform RearBogiePivot; // 0x378
	System.Boolean RearBogieCanRotate; // 0x380
	UnityEngine.Transform CentreOfMassTransform; // 0x388
	WizardGames.Soc.Common.Entity.TrainCarEntity mTrainCarEntity; // 0x390
	UnityEngine.Transform[] WheelVisuals; // 0x398
	System.Single WheelRadius; // 0x3a0
	WizardGames.Soc.Common.Train.TrainCar.ELeverStyleEnum LeverStyle; // 0x3a4
	UnityEngine.Transform LeftHandLever; // 0x3a8
	UnityEngine.Transform RightHandLever; // 0x3b0
	UnityEngine.GameObject FrontCollisionTrigger; // 0x3b8
	UnityEngine.GameObject RearCollisionTrigger; // 0x3c0
	UnityEngine.GameObject FrontPoint; // 0x3c8
	UnityEngine.GameObject RearPoint; // 0x3d0
	System.Collections.Generic.List<UnityEngine.Transform> SparkEffectRoot; // 0x3d8
	UnityEngine.GameObject CockpitAudioPos; // 0x3e0
	UnityEngine.GameObject BrakeSound; // 0x3e8
	UnityEngine.GameObject FrontImpactPos; // 0x3f0
	UnityEngine.GameObject RearImpactPos; // 0x3f8
	UnityEngine.Transform WorkcartGearNeedle; // 0x400
	UnityEngine.Transform WorkcartSpeedNeedle; // 0x408
	System.Collections.Generic.List<UnityEngine.Transform> CarLightsRootArray; // 0x410
	WizardGames.Soc.Procedural.TrainTrackSpline FrontTrackSection; // 0x418
	UnityEngine.Transform frontCouplingPivot; // 0x420
	UnityEngine.Transform rearCoupling; // 0x428
	UnityEngine.Transform rearCouplingPivot; // 0x430
	WizardGames.Soc.Common.Train.TrainCouplingController coupling; // 0x438
	UnityEngine.Transform ore_plane; // 0x440
	UnityEngine.Transform ore_plane_LOD0; // 0x448
	UnityEngine.Transform ore_plane_LOD1; // 0x450
	UnityEngine.Transform ore_plane_LOD2; // 0x458
	UnityEngine.Transform serverOnly; // 0x460
	System.Single GetSpeed(); // 0x06ce1e4c
	System.Single GetTrackSpeed(); // 0x06ce1efc
	System.Void InitShared(); // 0x06ce1f60
	System.Void UpdateOrePlane(System.Single percentage); // 0x06ce1ff4
	System.Void .ctor(); // 0x06ce2354
}

// Client.Runtime
enum WizardGames.Soc.Common.Train.TrainCar.ELeverStyleEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Train.TrainCar.ELeverStyleEnum WorkCart = 0;
	static WizardGames.Soc.Common.Train.TrainCar.ELeverStyleEnum Locomotive = 1;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Vehicle.BaseFuelComponent : System.Object
{
	static System.Int32 FuelBizId = 12020006;
	static SocLogger <Logger>k__BackingField; // 0x0
	WizardGames.Soc.Common.Entity.IBaseVehicleEntity VehicleEntity; // 0x10
	WizardGames.Soc.Common.Unity.Go.BaseVehicleGo VehicleGo; // 0x18
	System.Int32 FuelItemCount; // 0x20
	System.Single pendingFuel; // 0x24
	static System.Single predictConsumeFuel = 0.10000000149011612;
	System.Boolean onRequest; // 0x28
	System.Single idleFuelPerSec; // 0x2c
	System.Single maxFuelPerSec; // 0x30
	static SocLogger get_Logger(); // 0x06ce23f8
	System.Boolean get_OnRequest(); // 0x06ce2480
	System.Void .ctor(WizardGames.Soc.Common.Unity.Go.BaseVehicleGo vehicleGo); // 0x06ce24e4
	System.Boolean HasFuelWhenWorldResponse(); // 0x06ce25cc
	System.Single GetFuelConsume(System.Single throttleInput); // 0x06ce2648
	System.Void CheckFuelEnough(); // 0x06ce26dc
	System.Int32 TryUseFuel(System.Single seconds, System.Single fuelUsedPerSecond); // 0x06ce27d4
	System.Void ConsumeFuel(System.Int32 amount); // 0x06ce28e8
	System.Void OnConsumeFuelCallback(System.Int32 code, System.Int32 remaining, System.Int32 useCount); // 0x06ce295c
	static System.Void .cctor(); // 0x06ce2c90
}

// Client.Runtime
class WizardGames.Soc.Common.Vehicle.VehicleGroundCheck : UnityEngine.MonoBehaviour
{
	System.Collections.Generic.Dictionary<System.Int64,UnityEngine.Vector3> ContactedEntities; // 0x30
	UnityEngine.Rigidbody rb; // 0x38
	System.Boolean NeedWakeUp(WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo mgrGo); // 0x06ce2d64
	System.Boolean IsValidCollision(UnityEngine.Collision collision, WizardGames.Soc.Common.Unity.Go.BaseEntityGo& entityGo); // 0x06ce30d0
	System.Void OnCollisionEnter(UnityEngine.Collision other); // 0x06ce3204
	System.Void OnCollisionExit(UnityEngine.Collision other); // 0x06ce334c
	System.Void Init(UnityEngine.Rigidbody rb); // 0x06ce3484
	System.Void .ctor(); // 0x06ce352c
}

// Client.Runtime
class WizardGames.Soc.Common.Vehicle.FuelComponent : WizardGames.Soc.Common.Vehicle.BaseFuelComponent
{
	
	System.Void ConsumeFuel(System.Int32 amount); // 0x06ce35e0
	System.Void .ctor(WizardGames.Soc.Common.Unity.Go.BaseVehicleGo vehicleGo); // 0x06ce365c
	System.Void CheckFuelEnough(); // 0x06ce36fc
	System.Boolean HasFuelWhenWorldResponse(); // 0x06ce375c
}

// Client.Runtime
class WizardGames.Soc.Common.ResourceGather.GatheringHitRequest : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	System.Int64 AttackId; // 0x20
	System.Int64 TargetId; // 0x28
	System.Single Damage; // 0x30
	System.Void Dispose(); // 0x06ce3840
	System.Void .ctor(); // 0x06ce38b0
}

// Client.Runtime
struct WizardGames.Soc.Common.MonumentPath.BaseEntityData : System.ValueType
{
	WizardGames.Soc.Common.Data.EntityTypeEnum EntityType; // 0x10
	System.Int64 templateId; // 0x14
	
}

// Client.Runtime
class WizardGames.Soc.Common.MonumentPath.BasePoint : UnityEngine.MonoBehaviour
{
	System.Int32 id; // 0x30
	System.Boolean notEnd; // 0x34
	System.Int32 pathId; // 0x38
	System.Collections.Generic.List<System.Int32> connectIds; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.Common.MonumentPath.BaseEntityData> connectEntitys; // 0x48
	System.Void Init(WizardGames.Soc.Common.Data.BasePointData data); // 0x06ce3918
	System.Void .ctor(); // 0x06ce3cf4
}

// Client.Runtime
class WizardGames.Soc.Common.MonumentPath.BaseWay : UnityEngine.MonoBehaviour
{
	System.Int32 id; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.MonumentPath.BasePoint> containPoints; // 0x38
	System.Void .ctor(); // 0x06ce3e00
}

// Client.Runtime
struct WizardGames.Soc.Common.MonumentPath.MonumentEntityWay : System.ValueType, System.IDisposable
{
	System.Int32 MonumentID; // 0x10
	Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int64,Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashSet<WizardGames.Soc.Common.MonumentPath.BasePointInfo>>> mEntity2WayDic; // 0x18
	System.Void .ctor(System.Int32 monumentID); // 0x06ce3eb4
	System.Void AddEntityPointData(WizardGames.Soc.Common.MonumentPath.BasePointInfo point); // 0x06ce3f78
	System.Void AddEntityPoint(System.String entityTypeStr, System.Int64 entityTemplateId, WizardGames.Soc.Common.MonumentPath.BasePointInfo point); // 0x06ce40f4
	System.Void GetEntityPoint(System.Int32 entityType, System.Int32 templateId, System.Collections.Generic.List<WizardGames.Soc.Common.MonumentPath.BasePointInfo>& points); // 0x06ce440c
	System.Void Dispose(); // 0x06ce491c
}

// Client.Runtime
class WizardGames.Soc.Common.MonumentPath.MgrPathPoint : System.Object
{
	static System.Single MAXCOST; // 0x0
	static Unity.Collections.NativeParallelHashMap<System.Int32,Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,WizardGames.Soc.Common.MonumentPath.BaseWayInfo>> sAllMonumentPaths; // 0x8
	static Unity.Collections.NativeParallelHashMap<System.Int32,Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,WizardGames.Soc.Common.MonumentPath.BasePointInfo>> sId2Point; // 0x18
	static Unity.Collections.NativeParallelHashMap<System.Int32,WizardGames.Soc.Common.MonumentPath.MonumentEntityWay> sMonument2EntityPointsDic; // 0x28
	static SocLogger Log; // 0x38
	static Rust.AI.AStarNodeList sOpenNodeList; // 0x40
	static System.Collections.Generic.HashSet<WizardGames.Soc.Common.MonumentPath.BasePointInfo> sClosedNodeList; // 0x48
	static System.Collections.Generic.List<System.UInt64> lastNodeMids; // 0x50
	static System.Single Heuristic(WizardGames.Soc.Common.MonumentPath.BasePointInfo from, WizardGames.Soc.Common.MonumentPath.BasePointInfo to); // 0x06ce4d48
	static System.Boolean AStarFindPath(System.Int32 mounmentId, WizardGames.Soc.Common.MonumentPath.BasePointInfo start, WizardGames.Soc.Common.MonumentPath.BasePointInfo goal, System.Single preCost, System.Collections.Generic.Stack<WizardGames.Soc.Common.MonumentPath.BasePointInfo>& path, System.Single& pathCost); // 0x06ce4e54
	static System.Void ReleaseAStarNodeList(); // 0x06ce5cf8
	static System.Void GetNodesNear(UnityEngine.Vector3 point, Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.Soc.Common.MonumentPath.BasePointInfo> nodes, System.Collections.Generic.List<WizardGames.Soc.Common.MonumentPath.BasePointInfo>& nearNodes, System.Single dist, System.Single heightDist); // 0x06ce6024
	static System.Void GetNodesNearByMonumentID(System.Int32 monumentId, System.Int32 pathId, UnityEngine.Vector3 point, System.Collections.Generic.List<WizardGames.Soc.Common.MonumentPath.BasePointInfo>& nearNodes, System.Single dist, System.Single heightDist); // 0x06ce639c
	static System.Void GetTargetEntityPoint(System.Int32 monumentId, System.Int32 entityType, System.Int32 templateId, System.Collections.Generic.List<WizardGames.Soc.Common.MonumentPath.BasePointInfo>& points); // 0x06ce66d0
	static System.Void SetPathInfo(System.Int32 monumentId, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,WizardGames.Soc.Common.MonumentPath.BaseWayInfo> id2way, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,WizardGames.Soc.Common.MonumentPath.BasePointInfo> id2Point); // 0x06ce6824
	static System.Void ParsePointInfo(System.Int32 monumentId, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,WizardGames.Soc.Common.MonumentPath.BasePointInfo> points); // 0x06ce6960
	static System.Void Clear(); // 0x06ce6cc8
	static System.Void Dispose(); // 0x06ce7774
	static System.Void .cctor(); // 0x06ce796c
}

// Client.Runtime
struct WizardGames.Soc.Common.MonumentPath.BasePointInfo : System.ValueType, System.IEquatable<WizardGames.Soc.Common.MonumentPath.BasePointInfo>, System.IDisposable
{
	System.Int32 id; // 0x10
	System.Boolean notEnd; // 0x14
	System.Int32 pathId; // 0x15
	UnityEngine.Vector3 position; // 0x19
	Unity.Collections.LowLevel.Unsafe.UnsafeList<System.Int32> connectIds; // 0x25
	Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.Soc.Common.MonumentPath.BaseEntityData> connectEntitys; // 0x3d
	System.Void Init(WizardGames.Soc.Common.Data.BasePointData data); // 0x06ce7c28
	static System.Boolean op_Equality(WizardGames.Soc.Common.MonumentPath.BasePointInfo lhs, WizardGames.Soc.Common.MonumentPath.BasePointInfo rhs); // 0x06ce5f18
	static System.Boolean op_Inequality(WizardGames.Soc.Common.MonumentPath.BasePointInfo lhs, WizardGames.Soc.Common.MonumentPath.BasePointInfo rhs); // 0x06ce4850
	System.Boolean Equals(WizardGames.Soc.Common.MonumentPath.BasePointInfo other); // 0x06ce80c8
	System.Void Dispose(); // 0x06ce76d8
}

// Client.Runtime
struct WizardGames.Soc.Common.MonumentPath.BaseWayInfo : System.ValueType, System.IEquatable<WizardGames.Soc.Common.MonumentPath.BaseWayInfo>, System.IDisposable
{
	System.Int32 id; // 0x10
	UnityEngine.Vector3 position; // 0x14
	Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.Soc.Common.MonumentPath.BasePointInfo> containPoints; // 0x20
	System.Boolean Equals(WizardGames.Soc.Common.MonumentPath.BaseWayInfo other); // 0x06ce8180
	static System.Boolean op_Equality(WizardGames.Soc.Common.MonumentPath.BaseWayInfo lhs, WizardGames.Soc.Common.MonumentPath.BaseWayInfo rhs); // 0x06ce65e8
	static System.Boolean op_Inequality(WizardGames.Soc.Common.MonumentPath.BaseWayInfo lhs, WizardGames.Soc.Common.MonumentPath.BaseWayInfo rhs); // 0x06ce8234
	System.Void Dispose(); // 0x06ce765c
}

// Client.Runtime
class WizardGames.Soc.Common.Synchronization.MgrTime : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Int64 <RenderWorldTime>k__BackingField; // 0x18
	System.Int64 RenderWorldDelay; // 0x20
	System.Boolean started; // 0x28
	System.Int32 syncTimeCount; // 0x2c
	System.Int32 <Ping>k__BackingField; // 0x30
	System.Int64 dynamicNudge; // 0x38
	System.Boolean isInNudge; // 0x40
	System.Int64 <lastSnapshotWorldTime>k__BackingField; // 0x48
	System.Int64 realTime; // 0x50
	System.Boolean hasNewSnapshot; // 0x58
	System.Int64 <dt>k__BackingField; // 0x60
	System.Boolean bFirstTime; // 0x68
	System.DateTime _pingRequestTime; // 0x70
	System.Boolean _pingResponse; // 0x78
	WizardGames.Soc.Common.Utility.Counter LagCounter; // 0x80
	System.Int64 get_ServerWorldTime(); // 0x06ce82fc
	System.Int64 get_RenderWorldTime(); // 0x06ce83f4
	System.Void set_RenderWorldTime(System.Int64 value); // 0x06ce8458
	System.Int64 get_RenderDelay(); // 0x06ce84d0
	System.Int32 get_Ping(); // 0x06ce8588
	System.Void set_Ping(System.Int32 value); // 0x06ce85ec
	System.Int64 get_lastSnapshotWorldTime(); // 0x06ce8664
	System.Void set_lastSnapshotWorldTime(System.Int64 value); // 0x06ce86c8
	System.Int64 get_dt(); // 0x06ce8740
	System.Void set_dt(System.Int64 value); // 0x06ce87a4
	System.Boolean get_IsSyncDone(); // 0x06ce881c
	System.Boolean OnSyncTime(); // 0x06ce8888
	System.Void Reset(); // 0x06ce88fc
	System.Boolean PingRequest(); // 0x06ce8960
	System.Void PingResponse(); // 0x06ce8a08
	System.Void StartWorld(); // 0x06ce8b50
	System.Void Update(System.Int32 timeInterval); // 0x06ce8bb8
	System.Void OnNewSnapshotReceived(System.Int64 snapShotWorldTime); // 0x06ce8d18
	System.Void RecaculateDt(); // 0x06ce8de0
	System.Void UpdateRenderTime(System.Int32 timeInterval); // 0x06ce931c
	System.Void SetRenderWorldTime(System.Int64 renderWorldTime); // 0x06ce963c
	System.Void .ctor(); // 0x06ce96e8
	static System.Void .cctor(); // 0x06ce97b8
}

// Client.Runtime
class WizardGames.Soc.Common.Synchronization.HistorySnapshot : System.Object, WizardGames.Soc.Common.Cache.ICacheObject, Share.Common.ObjPool.IPooledObjectNew
{
	System.UInt64 <Mid>k__BackingField; // 0x10
	System.Boolean <IsReturn>k__BackingField; // 0x18
	System.Boolean <CareThreadSafe>k__BackingField; // 0x19
	System.Collections.Generic.Dictionary<System.Int64,Share.Common.ObjPool.Alpha3PooledObjectBase> Histories; // 0x20
	System.UInt64 get_Mid(); // 0x06ce988c
	System.Void set_Mid(System.UInt64 value); // 0x06ce98f0
	System.Boolean get_IsReturn(); // 0x06ce9968
	System.Void set_IsReturn(System.Boolean value); // 0x06ce99cc
	System.Boolean get_CareThreadSafe(); // 0x06ce9a48
	System.Void set_CareThreadSafe(System.Boolean value); // 0x06ce9aac
	System.Void ReturnToPool(); // 0x06ce9b28
	System.Void Dispose(); // 0x06ce9cf4
	System.Void .ctor(); // 0x06ce9d80
}

// Client.Runtime
class WizardGames.Soc.Common.Synchronization.MgrSnapshotReceiver : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Boolean <IsFullSnapshotReceived>k__BackingField; // 0x11
	WizardGames.Soc.Common.Synchronization.SnapshotIncremental NowIncremental; // 0x18
	System.Action BeforeReceiveSnapshotFull; // 0x20
	System.Action<WizardGames.Soc.Common.SimpleCustom.Snapshot,WizardGames.Soc.Common.Synchronization.SnapshotIncremental> ReceiveSnapshotFull; // 0x28
	System.Action<WizardGames.Soc.Common.Synchronization.SnapshotIncremental> SwitchSnapshotIncremental; // 0x30
	System.Collections.Generic.Queue<System.ValueTuple<System.Int64,System.Action>> PendingRpc; // 0x38
	System.Boolean get_IsFullSnapshotReceived(); // 0x06ce9e34
	System.Void set_IsFullSnapshotReceived(System.Boolean value); // 0x06ce9e98
	System.Int64 get_NowSnapshotSequence(); // 0x06ce9f14
	System.Int64 get_SnapshotWorldTime(); // 0x06ce9f88
	System.Void CleanUp(); // 0x06ce9ffc
	System.Void AddPendingRpc(System.Int64 sequence, System.Action action); // 0x06cea178
	System.Void ConsumeRpcPending(System.Int64 sequence); // 0x06cea378
	System.Void ResetData(); // 0x06cea060
	System.Void .ctor(); // 0x06cea6a4
	static System.Void .cctor(); // 0x06cea758
}

// Client.Runtime
class WizardGames.Soc.Common.Synchronization.SmoothAlgorithm : System.Object
{
	
	static System.Single AngleLerp(System.Single initAngle, System.Single finalAngle, System.Single factor); // 0x06cea82c
}

// Client.Runtime
class WizardGames.Soc.Common.Synchronization.SnapshotIncremental : System.Object, WizardGames.Soc.Common.Cache.ICacheObject
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.Common.Cache.ObjectPoolWithLock<WizardGames.Soc.Common.Synchronization.SnapshotIncremental> _pool; // 0x8
	System.Int64 Sequence; // 0x10
	System.Int64 ServerTime; // 0x18
	System.Int32 Interval; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent> SnapshotEvents; // 0x28
	System.Int64 CmdSequenceAck; // 0x30
	System.Boolean <IsReturn>k__BackingField; // 0x38
	static WizardGames.Soc.Common.Cache.ObjectPoolWithLock<WizardGames.Soc.Common.Synchronization.SnapshotIncremental> get_Pool(); // 0x06cea900
	System.Boolean get_IsReturn(); // 0x06cea988
	System.Void set_IsReturn(System.Boolean value); // 0x06cea9ec
	static WizardGames.Soc.Common.Synchronization.SnapshotIncremental GetFromPool(); // 0x06ceaa68
	static System.Void Return(WizardGames.Soc.Common.Synchronization.SnapshotIncremental incremental); // 0x06cea584
	System.Void .ctor(); // 0x06ceab6c
	static WizardGames.Soc.Common.Synchronization.SnapshotIncremental NewSnapshotIncremental(System.Int64 sequence); // 0x06ceabd4
	System.Void Clear(); // 0x06ceacc8
	System.Void Dispose(); // 0x06ceaf04
	System.Void MoveDiffFrom(WizardGames.Soc.Common.Synchronization.SnapshotIncremental other); // 0x06ceaf68
	static System.Void .cctor(); // 0x06ceb094
}

// Client.Runtime
interface WizardGames.Soc.Common.Synchronization.IChangeWorld : 
{
	
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType ThirdPerson = 0;
	static WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType Horse = 1;
	static WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType Bear = 2;
	static WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType PolarBear = 3;
	static WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType Boar = 4;
	static WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType Stag = 5;
	static WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType Chicken = 6;
	static WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType Wolf = 7;
	static WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType Scientist = 8;
	static WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType ChickenMutation = 9;
	static WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType Sum = 10;
	static WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType None = 11;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.MgrPhysicsScene : WizardGames.Soc.Common.Manager.MgrBase
{
	UnityEngine.SceneManagement.Scene scene; // 0x14
	UnityEngine.PhysicsScene PhysicsScene; // 0x18
	System.Collections.Generic.HashSet<WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType> hitBoxGosCacheFlag; // 0x20
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType,System.ValueTuple<System.String,UnityEngine.GameObject>> hitBoxGos; // 0x28
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType,System.Collections.Generic.List<System.String>> HitBoxGosChilds; // 0x30
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType,System.Collections.Generic.Dictionary<System.String,UnityEngine.Collider>> HitBoxGosColliders; // 0x38
	System.Void Init(); // 0x06ceb1c4
	System.Void Destroy(); // 0x06ceb328
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06ceb390
	System.Threading.Tasks.Task OnExitWorld(); // 0x06ceb510
	System.Void CleanUp(); // 0x06ceb988
	System.Void AddGoToPhysicsScene(WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType physicsSceneType, System.String hitBoxPath, WizardGames.Soc.Common.Unity.Go.HitBoxUtility.HitGoAddSceneCallback callback); // 0x06ceb9f0
	System.Void LoadCallBack(WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType physicsSceneType, UnityEngine.GameObject hitBoxGo, System.String path); // 0x06cebc10
	System.Void GetChildPathByGo(UnityEngine.GameObject go, System.String path, System.Collections.Generic.List<System.String> childPaths, System.Collections.Generic.Dictionary<System.String,UnityEngine.Collider> collides); // 0x06cebf98
	System.Void .ctor(); // 0x06cec238
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.PlayerBreatheViewMotionController : System.Object
{
	WizardGames.Soc.SocClient.Player.DampingMixerMotion yawMixerMotion; // 0x10
	WizardGames.Soc.SocClient.Player.DampingMixerMotion pitchMixerMotion; // 0x18
	System.Int64 BreathStartTime; // 0x20
	WizardGames.Soc.Common.Data.gun.Gunsway BreatheConfig; // 0x28
	System.Void Init(); // 0x055049cc
	System.Void Release(); // 0x055049cc
	System.Void OnCharacterAdsStateChange(System.Int64 entityId, WizardGames.Soc.Common.Entity.PlayerAdsStateEnum oldState, WizardGames.Soc.Common.Entity.PlayerAdsStateEnum newState); // 0x06cec894
	System.Void OnMoveStateChangeAction(System.Int64 entityId, WizardGames.Soc.Common.Entity.PlayerMoveStateEnum oldState, WizardGames.Soc.Common.Entity.PlayerMoveStateEnum newState); // 0x06cecb9c
	WizardGames.Soc.SocClient.Player.ILogicMotion GetMotion(System.Int32 vsId, System.Single rate); // 0x06ceca3c
	System.Void OnHeldItemChange(WizardGames.Soc.Common.Entity.IHeldItemEntity helditem); // 0x06cec518
	System.Void UpdateBreathe(System.Single dt); // 0x06ceccc8
	System.Void .ctor(); // 0x06cece60
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.ClientSnapshotReceiver : WizardGames.Soc.Common.Synchronization.MgrSnapshotReceiver
{
	static SocLogger logger; // 0x0
	System.Int64 lastCmdAckTs; // 0x40
	System.Int64 LastCmdAckTsLocal; // 0x48
	System.Int64 newReceivedSnapshotSequence; // 0x50
	System.Collections.Generic.Queue<WizardGames.Soc.Common.Synchronization.SnapshotIncremental> receivedIncrementals; // 0x58
	System.Collections.Generic.List<System.Int64> SmoothEntities; // 0x60
	System.Boolean <IsReconnectFullSnapshotReceived>k__BackingField; // 0x68
	System.Boolean <IsReconnectFullSnapshotParsed>k__BackingField; // 0x69
	System.Int64 <SnapshotServerTimeWhenRenderTimeChanged>k__BackingField; // 0x70
	System.Int64 _lastPlayerEntityRenderTime; // 0x78
	System.Int64 _lastSnapshotServerTime; // 0x80
	System.Void .ctor(); // 0x06cecec8
	System.Int64 get_NewReceivedSnapshotSequence(); // 0x06ced058
	System.Boolean get_IsReconnectFullSnapshotReceived(); // 0x06ced0bc
	System.Void set_IsReconnectFullSnapshotReceived(System.Boolean value); // 0x06ced120
	System.Boolean get_IsReconnectFullSnapshotParsed(); // 0x06ced19c
	System.Void set_IsReconnectFullSnapshotParsed(System.Boolean value); // 0x06ced200
	System.Int64 get_NowCmdSequenceAck(); // 0x06ced27c
	System.Int64 get_LocalRenderDelay(); // 0x06ced2f0
	System.Void ReceiveFull(WizardGames.Soc.Common.Synchronization.SnapshotIncremental snapshot); // 0x06ced3e4
	System.Void ReceiveIncremental(WizardGames.Soc.Common.Synchronization.SnapshotIncremental inc); // 0x06cedf34
	System.Void AfterSwitchSnapshot(); // 0x06cee0f4
	System.Boolean GetReadySnapshot(System.Int64 rendertime, WizardGames.Soc.Common.Synchronization.SnapshotIncremental& inc); // 0x06cee42c
	System.Int64 get_SnapshotServerTimeWhenRenderTimeChanged(); // 0x06cee654
	System.Void set_SnapshotServerTimeWhenRenderTimeChanged(System.Int64 value); // 0x06cee6b8
	System.Void UpdateSnapshotServerTimeWhenRenderTimeChanged(); // 0x06cee730
	System.Int64 Update(System.Int64 renderTime); // 0x06cee854
	System.Void ParseEntities(); // 0x06ceda10
	System.Void OnFastDisconnected(WizardGames.Soc.Common.Framework.Network.DisconnectReason reason); // 0x06cef4c0
	static System.Boolean IsSmoothEntity(System.Int32 entityType); // 0x06cef394
	static System.Boolean IsPredictEntity(System.Int32 entityType); // 0x06cef458
	static System.Void .cctor(); // 0x06cef600
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.ClientSnapshotReceiverDebugger : WizardGames.Soc.Common.Unity.Synchronization.SnapshotReceiverDebugger
{
	static WizardGames.Soc.Common.Syncronization.ClientSnapshotReceiverDebugger instance; // 0x0
	static WizardGames.Soc.Common.Syncronization.ClientSnapshotReceiverDebugger get_Instance(); // 0x06cef6d4
	System.Void .ctor(); // 0x06cef788
	static System.Void Release(); // 0x06cef900
	System.Void OnSwitchSnapshot(WizardGames.Soc.Common.Synchronization.SnapshotIncremental incremental); // 0x06cefaac
}

// Client.Runtime
enum WizardGames.Soc.Common.Syncronization.CmdBufferType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Syncronization.CmdBufferType LadderAds = 1;
	static WizardGames.Soc.Common.Syncronization.CmdBufferType LadderReload = 2;
	static WizardGames.Soc.Common.Syncronization.CmdBufferType InAirJump = 3;
	static WizardGames.Soc.Common.Syncronization.CmdBufferType InAirCrouch = 4;
	static WizardGames.Soc.Common.Syncronization.CmdBufferType SwitchAds = 5;
	static WizardGames.Soc.Common.Syncronization.CmdBufferType SwitchReload = 6;
	static WizardGames.Soc.Common.Syncronization.CmdBufferType SwitchFire = 7;
	static WizardGames.Soc.Common.Syncronization.CmdBufferType WakeUpCrouch = 8;
	static WizardGames.Soc.Common.Syncronization.CmdBufferType WakeUpSwitch = 9;
	static WizardGames.Soc.Common.Syncronization.CmdBufferType MantleJump = 10;
	static WizardGames.Soc.Common.Syncronization.CmdBufferType MantleReload = 11;
	static WizardGames.Soc.Common.Syncronization.CmdBufferType MantleFire = 12;
	static WizardGames.Soc.Common.Syncronization.CmdBufferType MantleADS = 13;
	static WizardGames.Soc.Common.Syncronization.CmdBufferType MantleCrouch = 14;
	static WizardGames.Soc.Common.Syncronization.CmdBufferType FireReload = 15;
	static WizardGames.Soc.Common.Syncronization.CmdBufferType MeleeUseContinue = 16;
	static WizardGames.Soc.Common.Syncronization.CmdBufferType LadderMeleeThrow = 17;
	static WizardGames.Soc.Common.Syncronization.CmdBufferType MantleMeleeThrow = 18;
	static WizardGames.Soc.Common.Syncronization.CmdBufferType SwitchMeleeThrow = 19;
	static WizardGames.Soc.Common.Syncronization.CmdBufferType ReloadFire = 20;
	static WizardGames.Soc.Common.Syncronization.CmdBufferType ReloadAds = 21;
	static WizardGames.Soc.Common.Syncronization.CmdBufferType FireEndFire = 22;
	static WizardGames.Soc.Common.Syncronization.CmdBufferType FireEndReload = 23;
	static WizardGames.Soc.Common.Syncronization.CmdBufferType SprintFire = 24;
	static WizardGames.Soc.Common.Syncronization.CmdBufferType FireSprint = 25;
	static WizardGames.Soc.Common.Syncronization.CmdBufferType End = 26;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.BaseCmdPreserver : System.Object
{
	System.Int32 StartTime; // 0x10
	WizardGames.Soc.Common.Data.character.ChracterCmdPreserve <Table>k__BackingField; // 0x18
	System.Int32 get_PreserveTime(); // 0x06cefc80
	WizardGames.Soc.Common.Data.character.ChracterCmdPreserve get_Table(); // 0x06cefd34
	System.Void set_Table(WizardGames.Soc.Common.Data.character.ChracterCmdPreserve value); // 0x06cefd98
	System.Void Init(WizardGames.Soc.Common.Data.character.ChracterCmdPreserve tb); // 0x06cefe18
	System.Boolean CheckPreserve(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x054e0cf4
	System.Void ModifyCmd(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x0552d210
	System.Boolean CheckClear(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x054dec74
	static System.Void CheckAdsCmd(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06cefecc
	static System.Void CheckCrouchCmd(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06cf0004
	static System.Void CheckSprintCmd(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06cf013c
	System.Void .ctor(); // 0x06cf0274
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.FireEndStateFirePreserver : WizardGames.Soc.Common.Syncronization.BaseCmdPreserver
{
	
	System.Boolean CheckPreserve(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06cf02dc
	System.Void ModifyCmd(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06cf0398
	System.Boolean CheckClear(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06cf0440
	System.Void .ctor(); // 0x06cf04d4
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.FireEndStateReloadPreserver : WizardGames.Soc.Common.Syncronization.BaseCmdPreserver
{
	System.Int32 AmmoID; // 0x20
	System.Boolean CheckPreserve(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06cf0538
	System.Void ModifyCmd(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06cf05fc
	System.Boolean CheckClear(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06cf0724
	System.Void .ctor(); // 0x06cf07c8
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.FireStateReloadCmdPreserver : WizardGames.Soc.Common.Syncronization.BaseCmdPreserver
{
	System.Int32 AmmoID; // 0x20
	System.Boolean CheckPreserve(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06cf082c
	System.Void ModifyCmd(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06cf08f0
	System.Boolean CheckClear(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06cf0a18
	System.Void .ctor(); // 0x06cf0ad0
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.FireStateSprintPreserver : WizardGames.Soc.Common.Syncronization.BaseCmdPreserver
{
	
	System.Boolean CheckPreserve(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06cf0b34
	System.Void ModifyCmd(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06cf0bf0
	System.Boolean CheckClear(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06cf0c8c
	System.Void .ctor(); // 0x06cf0d20
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.InAirCrouchCmdPreserver : WizardGames.Soc.Common.Syncronization.BaseCmdPreserver
{
	
	System.Boolean CheckPreserve(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06cf0d84
	System.Void ModifyCmd(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06cf0e74
	System.Boolean CheckClear(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06cf0f78
	System.Void .ctor(); // 0x06cf1060
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.InAirJumpCmdPreserver : WizardGames.Soc.Common.Syncronization.BaseCmdPreserver
{
	System.Int32 jumpStart; // 0x20
	System.Boolean CheckPreserve(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06cf10c4
	System.Void ModifyCmd(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06cf1194
	System.Boolean CheckClear(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06cf123c
	System.Void .ctor(); // 0x06cf12f0
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.LadderStateAdsCmdPreserver : WizardGames.Soc.Common.Syncronization.BaseCmdPreserver
{
	
	System.Boolean CheckPreserve(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06cf1354
	System.Void ModifyCmd(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06cf1410
	System.Boolean CheckClear(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06cf14ac
	System.Void .ctor(); // 0x06cf1578
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.LadderStateMeleeThrowPreserver : WizardGames.Soc.Common.Syncronization.BaseCmdPreserver
{
	
	System.Boolean CheckPreserve(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06cf15dc
	System.Void ModifyCmd(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06cf1698
	System.Boolean CheckClear(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06cf1740
	System.Void .ctor(); // 0x06cf1808
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.LadderStateReloadCmdPreserver : WizardGames.Soc.Common.Syncronization.BaseCmdPreserver
{
	System.Int32 AmmoID; // 0x20
	System.Boolean CheckPreserve(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06cf186c
	System.Void ModifyCmd(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06cf1930
	System.Boolean CheckClear(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06cf1a58
	System.Void .ctor(); // 0x06cf1b24
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.MantleStateADSCmdPreserver : WizardGames.Soc.Common.Syncronization.BaseCmdPreserver
{
	
	System.Boolean CheckPreserve(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06d1b844
	System.Void ModifyCmd(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06d1b900
	System.Boolean CheckClear(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06d1b9a0
	System.Void .ctor(); // 0x06d1ba58
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.MantleStateCrouchCmdPreserver : WizardGames.Soc.Common.Syncronization.BaseCmdPreserver
{
	
	System.Boolean CheckPreserve(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06d1bac0
	System.Void ModifyCmd(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06d1bb7c
	System.Boolean CheckClear(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06d1bc1c
	System.Void .ctor(); // 0x06d1bcd0
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.MantleStateFirePreserver : WizardGames.Soc.Common.Syncronization.BaseCmdPreserver
{
	
	System.Boolean CheckPreserve(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06d1bd38
	System.Void ModifyCmd(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06d1bdf4
	System.Boolean CheckClear(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06d1be9c
	System.Void .ctor(); // 0x06d1bf30
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.MantleStateJumpPreserver : WizardGames.Soc.Common.Syncronization.BaseCmdPreserver
{
	
	System.Boolean CheckPreserve(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06d1bf98
	System.Void ModifyCmd(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06d1c054
	System.Boolean CheckClear(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06d1c0fc
	System.Void .ctor(); // 0x06d1c1cc
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.MantleStateMeleeThrowPreserver : WizardGames.Soc.Common.Syncronization.BaseCmdPreserver
{
	
	System.Boolean CheckPreserve(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06d1c234
	System.Void ModifyCmd(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06d1c2f0
	System.Boolean CheckClear(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06d1c398
	System.Void .ctor(); // 0x06d1c42c
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.MantleStateReloadPreserver : WizardGames.Soc.Common.Syncronization.BaseCmdPreserver
{
	System.Int32 AmmoID; // 0x20
	System.Boolean CheckPreserve(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06d1c494
	System.Void ModifyCmd(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06d1c558
	System.Boolean CheckClear(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06d1c680
	System.Void .ctor(); // 0x06d1c738
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.MeleeUseContinuePreserver : WizardGames.Soc.Common.Syncronization.BaseCmdPreserver
{
	
	System.Boolean CheckPreserve(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06d1c7a0
	System.Void ModifyCmd(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06d1c85c
	System.Boolean CheckClear(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06d1c904
	System.Void .ctor(); // 0x06d1c9b8
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.ReloadStateAdsPreserver : WizardGames.Soc.Common.Syncronization.BaseCmdPreserver
{
	
	System.Boolean CheckPreserve(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06d1ca20
	System.Void ModifyCmd(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06d1cadc
	System.Boolean CheckClear(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06d1cb7c
	System.Void .ctor(); // 0x06d1cc30
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.ReloadStateFirePreserver : WizardGames.Soc.Common.Syncronization.BaseCmdPreserver
{
	
	System.Boolean CheckPreserve(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06d1cc98
	System.Void ModifyCmd(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06d1cd54
	System.Boolean CheckClear(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06d1cdfc
	System.Void .ctor(); // 0x06d1ce90
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.SprintStateFirePreserver : WizardGames.Soc.Common.Syncronization.BaseCmdPreserver
{
	
	System.Boolean CheckPreserve(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06d1cef8
	System.Void ModifyCmd(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06d1cfb4
	System.Boolean CheckClear(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06d1d05c
	System.Void .ctor(); // 0x06d1d0f0
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.SwitchStateAdsCmdPreserver : WizardGames.Soc.Common.Syncronization.BaseCmdPreserver
{
	
	System.Boolean CheckPreserve(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06d1d158
	System.Void ModifyCmd(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06d1d214
	System.Boolean CheckClear(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06d1d2b4
	System.Void .ctor(); // 0x06d1d368
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.SwitchStateFirePreserver : WizardGames.Soc.Common.Syncronization.BaseCmdPreserver
{
	
	System.Boolean CheckPreserve(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06d1d3d0
	System.Void ModifyCmd(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06d1d48c
	System.Boolean CheckClear(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06d1d534
	System.Void .ctor(); // 0x06d1d5c8
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.SwitchStateMeleeThrowPreserver : WizardGames.Soc.Common.Syncronization.BaseCmdPreserver
{
	
	System.Boolean CheckPreserve(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06d1d630
	System.Void ModifyCmd(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06d1d6ec
	System.Boolean CheckClear(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06d1d794
	System.Void .ctor(); // 0x06d1d828
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.SwitchStateReloadCmdPreserver : WizardGames.Soc.Common.Syncronization.BaseCmdPreserver
{
	
	System.Boolean CheckPreserve(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06d1d890
	System.Void ModifyCmd(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06d1d94c
	System.Boolean CheckClear(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06d1daf0
	System.Void .ctor(); // 0x06d1db84
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.WakeUpStateCrouchCmdPreserver : WizardGames.Soc.Common.Syncronization.BaseCmdPreserver
{
	
	System.Boolean CheckPreserve(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06d1dbec
	System.Void ModifyCmd(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06d1dca8
	System.Boolean CheckClear(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06d1dd48
	System.Void .ctor(); // 0x06d1ddfc
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.WakeUpStateSwitchCmdPreserver : WizardGames.Soc.Common.Syncronization.BaseCmdPreserver
{
	System.Int32 ShortCutCMD; // 0x20
	System.Boolean CheckPreserve(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06d1de64
	System.Void ModifyCmd(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06d1dffc
	System.Boolean CheckClear(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06d1e0a4
	System.Boolean SwitchShortcut(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06d1df54
	System.Void .ctor(); // 0x06d1e158
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.MgrEntityCareStates : WizardGames.Soc.Common.Manager.MgrBase
{
	WizardGames.Soc.Common.Data.DayAndNightState DayAndNightState; // 0x14
	WizardGames.Soc.Common.Data.CharacterState CharacterState; // 0x18
	System.Void UnlimitUpdate(); // 0x06d1e1c0
	System.Void .ctor(); // 0x06d1e2dc
}

// Client.Runtime
enum WizardGames.Soc.Common.Syncronization.ELightType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Syncronization.ELightType None = 0;
	static WizardGames.Soc.Common.Syncronization.ELightType SelfLight = 1;
	static WizardGames.Soc.Common.Syncronization.ELightType HeldLight = 2;
	static WizardGames.Soc.Common.Syncronization.ELightType EquipLight = 3;
	static WizardGames.Soc.Common.Syncronization.ELightType TorchLight = 4;
	static WizardGames.Soc.Common.Syncronization.ELightType CarLight = 5;
	static WizardGames.Soc.Common.Syncronization.ELightType NightVersionLight = 6;
	static WizardGames.Soc.Common.Syncronization.ELightType NoneEffectLight = 999;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Syncronization.ELightSourceType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Syncronization.ELightSourceType NightLight = 0;
	static WizardGames.Soc.Common.Syncronization.ELightSourceType FlashLight = 1;
	static WizardGames.Soc.Common.Syncronization.ELightSourceType LightableHat = 2;
	static WizardGames.Soc.Common.Syncronization.ELightSourceType Laser = 3;
	static WizardGames.Soc.Common.Syncronization.ELightSourceType TorchLight = 4;
	static WizardGames.Soc.Common.Syncronization.ELightSourceType CarNightLight = 5;
	static WizardGames.Soc.Common.Syncronization.ELightSourceType NightVersionLight = 6;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Syncronization.ELightStateType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Syncronization.ELightStateType Normal = 0;
	static WizardGames.Soc.Common.Syncronization.ELightStateType Dying = 1;
	static WizardGames.Soc.Common.Syncronization.ELightStateType Mantle = 2;
	static WizardGames.Soc.Common.Syncronization.ELightStateType Ladder = 3;
	static WizardGames.Soc.Common.Syncronization.ELightStateType Swim = 4;
	static WizardGames.Soc.Common.Syncronization.ELightStateType Car = 5;
	static WizardGames.Soc.Common.Syncronization.ELightStateType Horse = 6;
	static WizardGames.Soc.Common.Syncronization.ELightStateType Pick = 7;
	static WizardGames.Soc.Common.Syncronization.ELightStateType SleepOrWakeUp = 8;
	static WizardGames.Soc.Common.Syncronization.ELightStateType Zipline = 9;
	static WizardGames.Soc.Common.Syncronization.ELightStateType Ship = 10;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.LightControl : System.Object
{
	WizardGames.Soc.Common.Syncronization.ELightType lightType; // 0x10
	System.Boolean isOpen; // 0x14
	System.Boolean isIncompatibleClose; // 0x15
	System.Boolean isStateBlockClose; // 0x16
	System.Boolean lastStateBlock; // 0x17
	System.Boolean isDirty; // 0x18
	System.Action<System.Boolean> ChangeStateCallback; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.Common.Syncronization.ELightType> passiveCloseLights; // 0x28
	WizardGames.Soc.Common.Data.effect.LightState lightStateTable; // 0x30
	WizardGames.Soc.Common.Syncronization.MgrMyLights mgrMyLights; // 0x38
	WizardGames.Soc.Common.Syncronization.ELightStateType lastLightStateType; // 0x40
	System.Boolean get_IsStateBlockClose(); // 0x06d1e3b0
	System.Boolean get_IsOpen(); // 0x06d1e414
	System.Boolean get_IsLogicOpen(); // 0x06d1e478
	System.Boolean get_IsIncompatibleClose(); // 0x06d1e4f4
	System.Boolean get_LastStateBlock(); // 0x06d1e558
	System.Int32 get_Priority(); // 0x06d1e5bc
	System.Void .ctor(WizardGames.Soc.Common.Syncronization.MgrMyLights mgrMyLights, WizardGames.Soc.Common.Syncronization.ELightType lightType, System.Action<System.Boolean> changeStateCallback); // 0x06d1e62c
	WizardGames.Soc.Common.Syncronization.ELightStateType GetLightStateIndex(); // 0x06d1e7d4
	System.Void Update(); // 0x06d1e9c0
	System.Void SetLightState(System.Boolean isOn); // 0x06d1eb60
	System.Boolean CloseIncompatibleLight(WizardGames.Soc.Common.Syncronization.LightControl lightControl, System.Boolean needSort); // 0x06d1f1cc
	System.Void TryRemoveTorchLight(); // 0x06d1f494
	System.Void IncompatibleClose(); // 0x06d1f3ec
	System.Void StateBlockClose(); // 0x06d1ead0
	System.Void CloseIncompatibleLights(); // 0x06d1ed30
	System.Void OpenIncompatibleLights(WizardGames.Soc.Common.Syncronization.ELightType expectLightType); // 0x06d1efa0
	static System.Int32 SortLightControls(WizardGames.Soc.Common.Syncronization.ELightType left, WizardGames.Soc.Common.Syncronization.ELightType right); // 0x06d1f89c
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.MgrMyLights : System.Object
{
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Syncronization.ELightType,WizardGames.Soc.Common.Syncronization.LightControl> LightControlDict; // 0x10
	System.Collections.Generic.HashSet<WizardGames.Soc.Common.Syncronization.ELightSourceType> ExistLightSrouce; // 0x18
	System.Int64 mountableId; // 0x20
	WizardGames.Soc.SocClient.ClientLight.LightItem carLightItem; // 0x28
	System.Void Init(); // 0x06d1fa20
	System.Void Release(); // 0x06d1fac8
	WizardGames.Soc.Common.Syncronization.ELightType LightSourceType2LightType(WizardGames.Soc.Common.Syncronization.ELightSourceType sourceType); // 0x06d1fb70
	System.Void AddLightControl(WizardGames.Soc.Common.Syncronization.ELightSourceType sourceType, System.Action<System.Boolean> changeStateCallback, System.Boolean isOn); // 0x06d1fc00
	System.Void RemoveLightControl(WizardGames.Soc.Common.Syncronization.ELightSourceType sourceType, System.Boolean isOn); // 0x06d1f73c
	System.Void ChangeLightState(WizardGames.Soc.Common.Syncronization.ELightSourceType sourceType, System.Boolean isOn, System.Boolean check); // 0x06d1fd40
	WizardGames.Soc.Common.Syncronization.LightControl GetLightControl(WizardGames.Soc.Common.Syncronization.ELightSourceType sourceType); // 0x06d1f644
	System.Void Update(); // 0x06d1ff94
	System.Void RefreshFlashUIState(); // 0x06d1ec2c
	System.Void SetMountableId(System.Int64 mountableId); // 0x06d20630
	System.Void EnterMountable(); // 0x06d206c4
	System.Boolean GetCarLightArea(); // 0x06d2045c
	System.Void ExitMountable(); // 0x06d207fc
	System.Void AddCarLight(WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo); // 0x06d20860
	System.Void ChangeCarNightLightHandler(System.Boolean open); // 0x06d20b9c
	System.Void RemoveCarLight(); // 0x06d20aa4
	System.Void .ctor(); // 0x06d20c40
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.MgrMyPlayer : WizardGames.Soc.Common.Manager.MgrBase
{
	static WizardGames.Soc.Common.Syncronization.MgrMyPlayer.EUiLoadingFinishFlag LoadingAllFlags = 7;
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer.EUiLoadingFinishFlag CompleteLoading; // 0x14
	static SocLogger logger; // 0x0
	static System.Boolean ShowHitFont; // 0x8
	static System.Boolean ShowHpBarUi; // 0x9
	static System.Boolean EnableHeldItemCache; // 0xa
	WizardGames.Soc.Common.Entity.PlayerEntity MyEntityLocal; // 0x18
	System.Boolean WantChangeSkin; // 0x20
	System.Int64 UserCmdSequence; // 0x28
	System.Collections.Generic.List<System.Int64> UserCmdSequenceHistory; // 0x30
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PlayerEntity> MyPlayerHistory; // 0x38
	WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo FpPlayerGo; // 0x40
	WizardGames.Soc.Common.Unity.Go.ClientPlayerGo TpPlayerGo; // 0x48
	UnityEngine.GameObject MyPlayer; // 0x50
	UnityEngine.Transform MyPlayerTransform; // 0x58
	UnityEngine.GameObject MyPlayerView; // 0x60
	WizardGames.Soc.Common.Unity.CameraState ZiplineCamState; // 0x68
	System.Single _ccOverrideSpeed; // 0x6c
	System.Single CurLadderBlend; // 0x70
	System.Action MyPlayerLoadSuccess; // 0x78
	System.Action<WizardGames.Soc.Common.Entity.PlayerEntity> OnEntityUpdate; // 0x80
	WizardGames.Soc.Common.Unity.Character.PlayerLogicParams playerLogicParams; // 0x88
	WizardGames.Soc.Common.Syncronization.MgrMyLights mgrMyLights; // 0x90
	WizardGames.Soc.SocClient.Player.PlayerBoneManager PlayerBoneManager; // 0x98
	UnityEngine.GameObject SceneSetUpObj; // 0xa0
	UnityEngine.Light SceneLight; // 0xa8
	System.Int64 smoothRenderTime; // 0xb0
	WizardGames.Soc.Common.Entity.HistoryPlayerEntity smoothNowModel; // 0xb8
	System.Boolean openFly; // 0xc0
	System.Boolean isServerEntityObserver; // 0xc1
	System.Boolean isIkOpen; // 0xc2
	System.Boolean isAimIKOpen; // 0xc3
	System.Boolean debug; // 0xc4
	System.Boolean isLayerWeightOpen; // 0xc5
	System.Boolean IsBeLightened; // 0xc6
	System.Boolean <StreamingLoaded>k__BackingField; // 0xc7
	System.Boolean <ConstructionLoaded>k__BackingField; // 0xc8
	System.Boolean IsWaitingReconnect; // 0xc9
	System.Boolean isOpenedRespawnWindow; // 0xca
	System.Boolean isOpenedDyingWindow; // 0xcb
	System.Boolean TpOffsetYawEnable; // 0xcc
	System.Single TpOffsetRecoverTime; // 0xd0
	System.Int64 WeaponFire1PressTime; // 0xd8
	System.Boolean bLastUpdateIsInLittleEyeMode; // 0xe0
	WizardGames.Soc.Common.Unity.CameraState LastUpdateCameraState; // 0xe4
	WizardGames.Soc.Common.Syncronization.PlayerCmdPreserver CmdPreserver; // 0xe8
	WizardGames.Soc.Common.Syncronization.PlayerBreatheViewMotionController BreatheViewMotionController; // 0xf0
	WizardGames.Soc.SocClient.Player.FpHeldItemBreatheMotionController FpHeldItemBreatheMotionController; // 0xf8
	WizardGames.Soc.SocClient.Player.FpHeldItemMoveMotionController FpHeldItemMoveMotionController; // 0x100
	WizardGames.Soc.SocClient.Player.HeldItem.BagHeldItemUseController BagHeldItemUseController; // 0x108
	WizardGames.Soc.Common.Combat.SmartFireController SmartFireController; // 0x110
	WizardGames.Soc.SocClient.Player.HeldItem.ThrowParabolaController ThrowParabolaController; // 0x118
	WizardGames.Soc.SocClient.Player.HeldItem.LocalHeldItemEntityController LocalHeldItemEntityController; // 0x120
	WizardGames.Soc.SocClient.Systems.RecoilData RecoilData; // 0x128
	System.Collections.Generic.HashSet<System.Int64> SubscribeIds; // 0x130
	System.Single LastPlatformYaw; // 0x138
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.PlayerInteractiveType,System.Int32> waterstate2tips; // 0x140
	static System.Int32 IsFetchingBottle = 3023;
	static System.Int32 SqrMagnitude = 100;
	System.Action<System.Int64> onMountableChanged; // 0x148
	System.Action<System.Boolean,System.Int64> onSeatChanged; // 0x150
	WizardGames.Soc.SocClient.Fx.FxUnderwater fxUnderWater; // 0x158
	System.Boolean EokaPistolAddViewkick; // 0x160
	UnityEngine.Light selfNightLight; // 0x168
	System.Boolean <AutoDrive>k__BackingField; // 0x170
	WizardGames.Soc.SocClient.Player.HeldItemFovController HeldItemSceneFovController; // 0x178
	WizardGames.Soc.SocClient.Player.HeldItemFovController HeldItemGunFovController; // 0x180
	System.Int64 mantleTpModelDisplayerTimer; // 0x188
	WizardGames.Soc.Common.Unity.Horse.HorseGoPredict HorseGoPredict; // 0x190
	WizardGames.Soc.Common.Unity.Parachute.ParachuteGoPredict ParachuteGoPredict; // 0x198
	System.Single canUseCampingTentTimeSec; // 0x1a0
	System.Boolean IsWeaponLoaded; // 0x1a4
	System.Boolean _lastLittleEyeRendererEnabled; // 0x1a5
	System.Boolean PosInCommonWithObserver; // 0x1a6
	System.Int64 lateSyncEquipFlagTimer; // 0x1a8
	WizardGames.Soc.Common.Unity.Go.BaseMountableGo _currentMountableGo; // 0x1b0
	System.Action OnCheckBackWeapon; // 0x1b8
	System.Boolean isInWater; // 0x1c0
	System.Int64 ccParentEntityId; // 0x1c8
	System.String fovPath; // 0x1d0
	System.String gunFovCurvePath; // 0x1d8
	System.UInt64 _loadFovAssetAsyncId; // 0x1e0
	System.UInt64 _loadGunFovCurveAsyncId; // 0x1e8
	System.Int32 _timeSinceLastFire; // 0x1f0
	static System.Collections.Generic.List<System.Int64> GanRaoDanContainerPath; // 0x10
	static System.Collections.Generic.List<System.Int64> OilItemPath; // 0x18
	static System.Collections.Generic.List<System.Int64> OilContainerPath; // 0x20
	static System.Collections.Generic.List<System.Int64> ModuleSlotContainerPath; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap> allModuleSlotContainerNodes; // 0x1f8
	WizardGames.Soc.SocClient.Player.ADSFovTransition SceneFovTransition; // 0x200
	WizardGames.Soc.SocClient.Player.ADSFovTransition GunFovTransition; // 0x208
	WizardGames.Soc.SocClient.Player.ADSAnimController ADSAnimController; // 0x210
	WizardGames.Soc.Common.Unity.Character.CharacterFovConfig sceneFovConfig; // 0x218
	WizardGames.Soc.Common.Unity.Character.CharacterFovConfig gunFovConfig; // 0x220
	System.Single <ADSChangeMaxLerp>k__BackingField; // 0x228
	System.Single adsgunfov; // 0x22c
	System.Collections.Generic.HashSet<System.Int64> adsSubscribes; // 0x230
	System.Boolean adsvalid; // 0x238
	System.Int32 nextState; // 0x23c
	static System.Single EscapeLoadingTime = 10;
	static System.Single EscapeDamageCdTime = 30;
	System.Single escapeFromStuckTime; // 0x240
	System.Single getPlayerDamgeTime; // 0x244
	System.Int32 littleEyeEnableBits; // 0x248
	WizardGames.Soc.Common.Syncronization.LittleEyeState littleEyeState; // 0x24c
	UnityEngine.Vector3 initOffset; // 0x250
	System.Int64 mountableIdSubscribeId; // 0x260
	System.Int64 mountableTypeSubscribeId; // 0x268
	System.Single oldPitch; // 0x270
	System.Single oldYaw; // 0x274
	System.Boolean needReset; // 0x278
	System.Boolean notFpNow; // 0x279
	static System.Single debugAlpha; // 0x30
	static System.Single changeAlpha; // 0x34
	System.Collections.Generic.HashSet<System.Int64> visibleSubscribeIds; // 0x280
	System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Vector2> ViewOffsets; // 0x288
	System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Vector2> ShootOffsets; // 0x290
	UnityEngine.Vector2 ViewOffset; // 0x298
	UnityEngine.Vector2 ShootOffset; // 0x2a0
	WizardGames.Soc.Common.Syncronization.SecMoveReportInfo SecMoveReportInfo; // 0x2a8
	System.Int64 get_MyEntityId(); // 0x06cf1e68
	WizardGames.Soc.Common.Entity.PlayerEntity get_MyEntityServer(); // 0x06cf1f10
	WizardGames.Soc.Common.Component.RootNodeComponent get_MyRootNode(); // 0x06cf1fbc
	UnityEngine.GameObject get_MyPlayerViewGoTp(); // 0x06cf2038
	UnityEngine.GameObject get_MyPlayerCc(); // 0x06cf20b0
	UnityEngine.Transform get_MyPlayerColliderTransform(); // 0x06cf2158
	UnityEngine.Animator get_MyFpAnimator(); // 0x06cf2200
	UnityEngine.Animator get_MyTpAnimator(); // 0x06cf22a4
	WizardGames.Soc.Common.Unity.Character.SocCharacterController get_MyCharacterController(); // 0x06cf234c
	UnityEngine.GameObject get_EquipFpWeapon(); // 0x06cf23c0
	UnityEngine.GameObject get_EquipTpWeapon(); // 0x06cf24b8
	UnityEngine.Camera get_GetMyCamera(); // 0x06cf25b0
	WizardGames.Soc.Common.Unity.CameraState get_CameraState(); // 0x06cf264c
	System.Single get_CCOverrideSpeed(); // 0x06cf26e8
	System.Void set_CCOverrideSpeed(System.Single value); // 0x06cf274c
	System.UInt64 get_RoleId(); // 0x06cf27f8
	System.Boolean get_StreamingLoaded(); // 0x06cf2870
	System.Void set_StreamingLoaded(System.Boolean value); // 0x06cf28d4
	System.Boolean get_ConstructionLoaded(); // 0x06cf2950
	System.Void set_ConstructionLoaded(System.Boolean value); // 0x06cf29b4
	System.Boolean get_preloadFinish(); // 0x06cf2a30
	WizardGames.Soc.SocClient.Ui.UiHud get_UiHud(); // 0x06cf2b1c
	WizardGames.Soc.SocClient.Fx.FxUnderwater get_FxUnderwater(); // 0x06cf2c24
	System.Boolean get_AutoDrive(); // 0x06cf2c88
	System.Void set_AutoDrive(System.Boolean value); // 0x06cf2cec
	System.Boolean get_IsDyingTpAnimControllerLoaded(); // 0x06cf2d68
	System.Boolean get_IsDeadWindowActive(); // 0x06cf2e8c
	System.Void Init(); // 0x06cf2fe4
	System.Boolean get_IsMountDriver(); // 0x06cf324c
	WizardGames.Soc.Common.Unity.Go.BaseMountableGo GetMountableGo(); // 0x06cf32bc
	System.Void SetConstructionLoaded(System.Boolean flag); // 0x06cf348c
	System.Void StartLoadConstruction(); // 0x06cf3674
	System.Void OnStreamingCompleted(WizardGames.Soc.StreamingSource source); // 0x06cf3780
	System.Void AfterPreloadFinish(); // 0x06cf3a5c
	System.Void RefreshStaicShadowMap(); // 0x06cf40f8
	System.Void RefreshSkyRendering(); // 0x06cf4164
	System.Void CheckFinishLoading(); // 0x06cf3570
	System.Void OnWeaponLoaded(); // 0x06cf43c4
	System.Void TryRemoveUiLoading(); // 0x06cf41ec
	System.Void CheckStreamingLoaded(); // 0x06cf4450
	System.Void OnRecoverAllPreCreateConstruction(); // 0x06cf47d4
	System.Threading.Tasks.Task AfterEnterWorld(); // 0x06cf48ec
	System.Void OnTransChange(System.Int64 entityId, UnityEngine.Vector3 pos, UnityEngine.Vector3 rot); // 0x06cf4c14
	System.Void Bind(); // 0x055049cc
	System.Void UnBind(); // 0x055049cc
	System.Threading.Tasks.Task OnExitWorld(); // 0x054e7844
	System.Void CleanUp(); // 0x06cf766c
	System.Void InitOnReconnect(WizardGames.Soc.Common.Unity.Go.ClientPlayerGo playerGo); // 0x05523a54
	System.Void Start(WizardGames.Soc.Common.Entity.PlayerEntity serverEntity); // 0x06cf7bc0
	System.Void OnDataUpdate(); // 0x06cfa3b8
	System.Void ObserverStart(); // 0x055049cc
	System.Void DisableAutoDrive(System.Int32 disableTip); // 0x06cfab58
	System.Void SetAutoDrive(System.Boolean value); // 0x06cfad5c
	System.Void OnVehicleTypeChange(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, System.Int32 _, System.Int32 __); // 0x06cf9e6c
	System.Void OnMoveStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte oldMoveStateEnum, System.Byte newMoveStateEnum); // 0x06cfaec4
	System.Void OnPlatformIdChanged(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int64 oldVal, System.Int64 newVal); // 0x06cfaf54
	System.Void OnHorseMountDirChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 o, System.Int32 n); // 0x06cfb1bc
	System.Void InitReputaion(); // 0x06cfa100
	System.Void TP2FPADSTransitionFinished(); // 0x06cfb24c
	System.Void ChangeNightLightHandler(System.Boolean value); // 0x06cfb354
	System.Void RefreshEquipEnable(); // 0x06cfb3e8
	System.Void SetRemoteEquipEnable(System.Int32 equipIndex, System.Boolean enable); // 0x06cfb534
	System.Void LateSyncEquipEnableFlag(); // 0x06cfb5f0
	System.Void ShowFp(System.Boolean show); // 0x06cfb79c
	System.Void ShowTp(System.Boolean show); // 0x06cfb900
	System.Void ShowFpModels(System.Boolean show); // 0x06cfb878
	System.Void ShowTpModels(System.Boolean show); // 0x06cfb9dc
	System.Void CopyDataFromServerEntity(WizardGames.Soc.Common.Entity.PlayerEntity local, WizardGames.Soc.Common.Entity.PlayerEntity serverEntity); // 0x06cfba64
	System.Void InitEntityModelByServerFullSpanShot(WizardGames.Soc.Common.Entity.PlayerEntity serverEntity); // 0x06cf92e4
	System.Void Spawn(System.Int64 entityId, WizardGames.Soc.Common.Entity.PlayerEntity serverEntity); // 0x06cf969c
	System.Void OnTeleport(); // 0x06cfc204
	System.Void UpdateMyPlayer(System.Int32 interval); // 0x06cfc33c
	System.Void ComparePredictGo(); // 0x06cfeb5c
	System.Void UpdatePredictGo(System.Int32 interval); // 0x06cfed58
	System.Void UpdateCmd(); // 0x06cfe6f8
	System.Void UpdateVehicleCameraDebug(); // 0x06cfedcc
	System.Void UpdateLittleEyeVisible(); // 0x06cfe1f8
	System.Void UpdateLittleEyeFade(System.Single pitch, System.Single yaw); // 0x06cfee54
	System.Void SetPartModelAlpha(System.Single alpha); // 0x06cff454
	System.Void SetHeldItemAlpha(System.Single alpha); // 0x06cff504
	System.Void ResetLittleEyeFade(); // 0x06cff5f8
	System.Void SetRenderEnabled(System.Boolean enabled); // 0x06cfefe8
	System.Void OnLittleEyeExited(); // 0x06cff3e0
	System.Void UpdateTpRotation(); // 0x055049cc
	System.Void BlendLadderRot(System.Single dt); // 0x06cffca4
	System.Void UpdateFpRotation(); // 0x06cfcc0c
	System.Single LimitPitch(System.Single pitch, System.Single limitPitch); // 0x06d002b4
	System.Void OnLadderStepUp(System.Boolean stepSuc); // 0x06d00634
	System.Void OnChangeLifeCycleFlags(WizardGames.Soc.Common.Entity.PlayerEntity serverEntity, System.Int32 newValue, System.Int32 oldValue); // 0x06d007ac
	System.Void UpdateUi(); // 0x06cfd848
	System.Void CalculateSmoothPlayerView(System.Int32 intervalTime); // 0x06cfd0a0
	System.Void GetSmoothPlayerViewPosBefore(System.Int32 intervalTime, UnityEngine.Vector3& pos, UnityEngine.Vector3& heightOffset, System.Boolean& needLateSmooth, WizardGames.Soc.Common.Syncronization.MgrMyPlayer.SmoothModelInfos& smoothInfos); // 0x06d01064
	System.Void LerpSmoothPlayerViewPos(System.Int32 intervalTime, System.Boolean needLateSmooth, UnityEngine.Vector3& pos, WizardGames.Soc.Common.Syncronization.MgrMyPlayer.SmoothModelInfos& infos); // 0x0550f988
	System.Void LateUpdate(UnityEngine.Camera cam); // 0x06d022b8
	System.Void OnEntityGoRemoved(WizardGames.Soc.Common.Unity.Go.IEntityGo go); // 0x06d0257c
	System.Void CheckPlatform(WizardGames.Soc.Common.Entity.PlayerEntity serverEntity, System.Boolean predict); // 0x06cf3be0
	System.Void Rollback(WizardGames.Soc.Common.Entity.PlayerEntity serverEntity, System.Int64 cmdSequence); // 0x06d026b8
	System.Void PredictMove(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06d02ac4
	System.Void RollbackCmd(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, System.Int32 clientTime); // 0x06d03780
	System.Void Move(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastCmd, System.Boolean isRollBack); // 0x0552d23c
	System.Void HandlePlayers2SetLayer(WizardGames.Soc.Common.Contexts.Context context); // 0x06d0398c
	System.Void PreCmdChange(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x05523a54
	System.Void AfterCmdChange(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x05523a54
	System.Void LadderFailed(); // 0x06d06ef4
	System.Boolean TryGetCurrentHeldItemGo<T>(T& heldItemGo, System.Boolean fp); // 0x052af1f0
	System.Boolean TryGetHeldItemInterface<T>(System.Int64 id, T& entity); // 0x052af1f0
	System.Boolean TryGetCurrentHeldItemInterface<T>(T& entity); // 0x052af1f0
	System.Void OnCurrentHeldItemChange(System.Int64 oldId, System.Int64 newId, WizardGames.Soc.Common.Entity.IHeldItemEntity newHeld); // 0x06d07060
	System.Void TryBagUseHeldItem(WizardGames.Soc.Common.CustomType.BaseItemNode item, System.Int64 targetId, WizardGames.Soc.SocClient.Player.HeldItem.BagUsePurposes purpose); // 0x06d0943c
	System.Void CompareEquipHead(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x06d094f8
	static T CloneOrCopyData<T>(T target, T src); // 0x052af1f0
	System.Void SyncServerEntityModel(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x06d09758
	System.Void InvokeMonumentChange(System.Int32 monumentId); // 0x06d0a694
	System.Boolean IsInSafetyArea(); // 0x06d0b1e8
	System.Void InvokeMountChange(); // 0x06d0a74c
	System.Void InvokeSeatChange(); // 0x06d0acf4
	System.Void RefreshMountableState(); // 0x06d0b264
	System.Void RefreshMountableLightState(System.Int64 mountableId, System.Int32 vehicleType); // 0x06d0b358
	System.Void RefreshMountableLightState(); // 0x06d0b46c
	System.Void RefreshHeldItemLightState(); // 0x06d0b504
	System.Void RefreshPartModelLightState(); // 0x06d0b998
	System.Int64 GetMountStatus(); // 0x06d0af80
	System.Void CameraChangeState(WizardGames.Soc.Common.Unity.CameraState lastCameraState, WizardGames.Soc.Common.Unity.CameraState nowCameraState); // 0x06cf9990
	System.Void InitSceneCamera(); // 0x06cf9a48
	System.Void InitEffects(); // 0x06cf9bbc
	System.Void OpenDyingWindow(WizardGames.Soc.Common.Entity.PlayerEntity serverEntity, System.Boolean isAidingOther); // 0x06d00c30
	System.Void OpenRespawnWindow(WizardGames.Soc.Common.Entity.PlayerEntity serverEntity, System.String windowName); // 0x06cf9cec
	System.Void RemoveRespawnWindow(); // 0x06d00e18
	System.Void OpenDamageScreenEffectWindow(WizardGames.Soc.Common.Entity.PlayerEntity serverEntity); // 0x06d00f38
	WizardGames.Soc.Common.Entity.PlayerEntity GetPlayerEntityInConeRange(System.Single maxAngle, System.Single maxDistance); // 0x06d0c5a4
	System.Boolean CheckDoFire1(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06d0514c
	System.Boolean CheckDoFire2(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x054dec74
	System.Int32 CheckReloadTrigger(WizardGames.Soc.Common.Entity.IHaveBulletEntity havebullet, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, System.Int32 expectAmmo, System.Int64 ammoNodeId); // 0x06d04f2c
	System.Int32 PredictAmmoID(WizardGames.Soc.Common.Entity.IHaveBulletEntity weapon, System.Int32 ammoId); // 0x06d0cdb4
	System.Void CheckDryFire(); // 0x06d0382c
	System.Boolean CheckBagAvailableAmmo(WizardGames.Soc.Common.Entity.IHaveBulletEntity haveBulletEntity); // 0x06d09200
	System.Void UIStateEvent(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x06d0d5ec
	System.Void UpdatePlayerPropertyWithHeldItem(WizardGames.Soc.Common.Entity.IHeldItemEntity helditem); // 0x06d07a58
	System.Void ToggleFly(System.Boolean active); // 0x06cfc128
	System.Single GetGunFov(WizardGames.Soc.Common.Entity.IItemEntity entity); // 0x06d08658
	System.Void SetTpAnimator(System.Boolean enable); // 0x06d0da7c
	System.Void AfterWaitReconnectInGame(); // 0x06d0dc24
	System.Void RefreshLocalHeldItems(); // 0x06d0de18
	System.Void AfterFastReconnectParseIncremental(); // 0x06d0dea0
	System.Void AddLifeCycleFlagEvent(System.Int32 flags); // 0x06d0df5c
	System.Void OnFastDisconnected(WizardGames.Soc.Common.Framework.Network.DisconnectReason reason); // 0x06d0e088
	System.Void OnFastReconnected(); // 0x06d0e114
	System.Threading.Tasks.Task OnEnterWorld(); // 0x054e7844
	System.Void OnEnterActivationVolume(System.Int32 activationId); // 0x055056e8
	System.Void OnExitActivationVolume(System.Int32 activationId); // 0x055056e8
	System.Void StartUseItemWithRecord(WizardGames.Soc.Common.Entity.IHeldItemEntity itemEntity, System.Single total); // 0x06d0ec50
	System.Void TryFinishUseItem(System.Int64 recordId); // 0x06d0ee44
	System.Void StartReload(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams player); // 0x06d0ef40
	System.Void OnLeaveReload(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams player); // 0x06d0f424
	System.Void StartUseItem(System.Int64 recordId, System.Int64 tableId, System.Single total); // 0x06d0f5d8
	System.Void ShowEscapeBar(System.Single total, System.Action onComplete); // 0x06d0f70c
	System.Boolean CanMoveMagazineInCurState(WizardGames.Soc.Common.CustomType.BaseItemNode magazine, WizardGames.Soc.Common.CustomType.WeaponItemNode tarWeapon, System.Boolean showTips); // 0x06d0f834
	System.Boolean CanMakeWaterCmd(); // 0x06d0fd80
	System.Boolean DrinkWaterCmd(WizardGames.Soc.Common.CustomType.WaterBottleItemNode item); // 0x06d10038
	System.Void DropWaterItem(System.Int64 curWaterId); // 0x06d1043c
	System.Void OnCharacterStateChange(WizardGames.Soc.Common.Entity.PlayerEntity entity, WizardGames.Soc.Common.Entity.PlayerCharacterStateEnum oldState, WizardGames.Soc.Common.Entity.PlayerCharacterStateEnum newState); // 0x06d10628
	System.Void OnCharacterPoseStateChange(WizardGames.Soc.Common.Entity.PlayerEntity entity, WizardGames.Soc.Common.Entity.PlayerPoseStateEnum oldState, WizardGames.Soc.Common.Entity.PlayerPoseStateEnum newState); // 0x06d106b8
	System.Void OnHurt(WizardGames.Soc.Common.SimpleCustom.DamageDataEvent damageData); // 0x06d10a40
	System.Single GetWholeAttrValue(WizardGames.Soc.Common.SimpleCustom.DamageType type, System.Int32 factor); // 0x06d10ce4
	System.Single GetPartAttrValue(WizardGames.Soc.Common.SimpleCustom.DamageType type, System.Int32 bodyIndex, System.Int32 factor); // 0x06d10e84
	static WizardGames.Soc.Common.Unity.Go.BasePlayerGo InitLocalPlayer(WizardGames.Soc.Common.Entity.IEntity entity); // 0x054e7844
	UnityEngine.Vector3 GetPlayerForwardPos(System.Single forwardScale, System.Single xOffset, System.Single yOffset, System.Single zOffset); // 0x06d113dc
	System.Boolean IsDriverView(WizardGames.Soc.Common.Unity.Go.BaseMountableGo baseMountableGo); // 0x06d0034c
	WizardGames.Soc.Common.CustomType.ItemContainerNode GetGanRaoDanItemContainerNode(); // 0x06d11590
	WizardGames.Soc.Common.CustomType.ItemContainerNode GetOilItemContainerNode(); // 0x06d11688
	WizardGames.Soc.Common.CustomType.ItemContainerNode GetModuleSlotContainerNode(WizardGames.Soc.Common.Entity.IBaseMountableEntity CurVehicleEntity); // 0x06d11780
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap> GetAllModuleSlotContainerNodes(WizardGames.Soc.Common.Entity.IBaseMountableEntity CurVehicleEntity); // 0x06d11b5c
	WizardGames.Soc.Common.CustomType.ItemContainerNode GetHorseEquipContainerNode(WizardGames.Soc.Common.Entity.IBaseMountableEntity CurVehicleEntity); // 0x06d11ec4
	System.Boolean IsOpenFly(); // 0x06d12178
	System.Void OnMountChanged(System.Int64 mountedId); // 0x06d121dc
	System.Void OnMountSeatIndexChanged(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, System.Int32 oldValue, System.Int32 newValue); // 0x06d126f8
	System.Void PredictMountableMove(System.Int32 frameTime, System.Int32 timeSinceLastUpdate, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, System.Int32 physicsUpdateCount, System.Int32 tickTime, System.Int32 allPhysicTime, WizardGames.Soc.Common.Unity.Go.BaseMountableGo& mountableGo); // 0x06d12870
	System.Void UpdateEquips(System.Collections.Generic.List<System.Int64> equips, System.Collections.Generic.Dictionary<System.Int64,System.Int64> skins); // 0x06d12e44
	System.Void OnRespawnResetCollider(); // 0x06d12f20
	static WizardGames.Soc.Common.CustomType.NodeBase GetNodeBase(WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap ContainerNode, System.Int64 pos); // 0x06d13160
	static System.Void GetNodePath(WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap ContainerNode, System.Collections.Generic.List<System.Int64> output); // 0x06d13260
	System.Void InitPredictHorse(); // 0x06cfa210
	System.Void PredictHorse(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06d1336c
	System.Void InitPredictParachute(); // 0x06cfa2e4
	System.Void PredictParachute(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06d135e8
	WizardGames.Soc.Common.Component.PlayerDebugComponent GetPlayerDebugComponent(); // 0x06d137e4
	WizardGames.Soc.Common.Component.PlayerConstructionComponent GetPlayerConstructionComponent(); // 0x06d138ac
	System.Void OnSelfDamage(WizardGames.Soc.Common.SimpleCustom.DamageDataEvent data); // 0x06d13974
	System.Boolean CanCampingTentUse(System.Boolean showReasonTips); // 0x06d13b78
	System.Void CompareTargetingLauncherToken(WizardGames.Soc.Common.Entity.PlayerEntity serverEntity); // 0x06d13e24
	System.Void OnHostileChanged(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x06d13ffc
	System.Void SetSprintInLadder(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06d05498
	System.Single get_ADSChangeMaxLerp(); // 0x06d14104
	System.Void set_ADSChangeMaxLerp(System.Single value); // 0x06d14168
	System.Void InitADS(); // 0x06cf575c
	System.Void OnAdsStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x06d141e0
	System.Void OnUnaliveStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x06d14c40
	System.Void OnPosedyingStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x06d14f54
	System.Void ReleaseADS(); // 0x06cf66b4
	System.Void HeldItemChangeResetADS(WizardGames.Soc.Common.Entity.IHeldItemEntity heldItemEntity); // 0x06d15268
	System.Void OnUpdateADS(); // 0x06d0d744
	System.Void SwitchADS(WizardGames.Soc.Common.Entity.PlayerAdsStateEnum oldState, WizardGames.Soc.Common.Entity.PlayerAdsStateEnum newState); // 0x06d142e0
	System.Void UpdateAdsAnimState(); // 0x06d1558c
	System.Boolean ResetInVehicle(); // 0x06d15af8
	System.Void ADSUpdate(System.Single dt); // 0x06cfc8f0
	System.Void ADSLateUpdate(System.Single dt); // 0x06d023d4
	System.Boolean get_IsEscapeFromStuckLoading(); // 0x06d15c00
	System.Void StartEscapeFromStuckLoading(); // 0x06d15c7c
	System.Void StopEscapeLoading(); // 0x06d10c2c
	System.Boolean CanEscapeFromStuck(); // 0x06d15d30
	System.Void InitLittleEye(); // 0x055049cc
	System.Void ReleaseLittleEye(); // 0x055049cc
	System.Void BuildStateSwitchEvent(System.Boolean isInBuildMode); // 0x06d15f8c
	System.Void EnableLittleEye(WizardGames.Soc.Common.Syncronization.LittleEyeEnableBit bit, System.Boolean enable); // 0x06d16084
	System.Boolean LittleEyeEnable(); // 0x06d0ca08
	System.Void EnterLittleEye(); // 0x06d162c8
	System.Void ExitLittleEye(); // 0x06d16ae8
	System.Void CollectInputLittleEye(System.Single factorX, System.Single factorY); // 0x06d16b98
	System.Void UpdateLittleEye(System.Single dt); // 0x06cfdb50
	System.Boolean GetXYZRatio(System.Single x, System.Single y, System.Single z, UnityEngine.Vector3& res); // 0x06d1766c
	System.Void SetCameraBackToNormal(System.Single yawDelta, System.Single pitchDelta, System.Single rollDelta); // 0x06d177c8
	System.Void OnBuildModeEnter(); // 0x06d16018
	System.Void OnMountableIdChanged(WizardGames.Soc.Share.Framework.CustomTypeBase self, System.Int64 oldValue, System.Int64 newValue); // 0x06d17c48
	System.Void OnMountableTypeChange(WizardGames.Soc.Share.Framework.CustomTypeBase self, System.Int32 oldValue, System.Int32 newValue); // 0x06d18078
	System.Void ResetLittleEye(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06d1823c
	static System.Void SetRendererAlpha(UnityEngine.Renderer renderer, System.Single alpha); // 0x06d18538
	System.Void InitModelVisible(); // 0x06cf59e4
	System.Void OnMoveStateChangeActionVisible(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x06d089ac
	System.Void OnCurWeaponIDChangeActionVisible(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 o, System.Int64 n); // 0x06d19038
	System.Void OnMoveLadderStateChangeActionVisible(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x0552b2a8
	System.Void OnAdsStateChangeVisible(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x06d18cfc
	System.Void CameraChangeStateVisible(WizardGames.Soc.Common.Unity.CameraState lastCameraState, WizardGames.Soc.Common.Unity.CameraState nowCameraState); // 0x06d0bf18
	System.Void OnActionStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x06d18a48
	System.Void OnCommonStateRecoveryChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 o, System.Int32 n); // 0x06d198e4
	System.Void PlayTaskMovie(); // 0x06d19b10
	System.Void NewbieItemSwitchFinishDoSomething(System.Int64 itemTableId); // 0x06d19624
	System.Void OnUnAliveStateChangeVisible(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x06d18e8c
	System.Void ReleaseModelVisible(); // 0x06cf684c
	System.Void AddViewOffset(UnityEngine.Vector2 offset, WizardGames.Soc.Common.Syncronization.ViewOffsetType source); // 0x06d19d18
	System.Void AddShootOffset(UnityEngine.Vector2 offset, WizardGames.Soc.Common.Syncronization.ShootOffsetType source); // 0x06d19de0
	System.Void CorrectCmdViewPitchYaw(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, System.Single dt); // 0x06d19ea8
	System.Void CorrectCmdShootPitchYaw(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, System.Single dt); // 0x06d1a068
	System.Void InterruptBagReload(); // 0x06d0d3d0
	System.Void .ctor(); // 0x06d1a264
	static System.Void .cctor(); // 0x06d1a89c
	System.Void <OnStreamingCompleted>b__135_0(); // 0x06d1adc8
	System.Void <LateSyncEquipEnableFlag>b__165_0(System.Int64 id, System.Object data, System.Boolean delete); // 0x06d1af64
	System.Void <OnMoveStateChangeActionVisible>b__384_0(System.Int64 id, System.Object data, System.Boolean delete); // 0x06d1b02c
	System.Void <OnCurWeaponIDChangeActionVisible>b__385_0(System.Int64 id, System.Object data, System.Boolean delete); // 0x06d1b16c
}

// Client.Runtime
struct WizardGames.Soc.Common.Syncronization.MgrMyPlayer.SmoothModelInfo : System.ValueType
{
	UnityEngine.Vector3 Pos; // 0x10
	System.Boolean IsGround; // 0x1c
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Syncronization.MgrMyPlayer.SmoothModelInfos : System.ValueType
{
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer.SmoothModelInfo PreModel; // 0x10
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer.SmoothModelInfo LastModel; // 0x20
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer.SmoothModelInfo NowModel; // 0x30
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Syncronization.MgrMyPlayer.EUiLoadingFinishFlag : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Syncronization.MgrMyPlayer.EUiLoadingFinishFlag None = 0;
	static WizardGames.Soc.Common.Syncronization.MgrMyPlayer.EUiLoadingFinishFlag Stream = 1;
	static WizardGames.Soc.Common.Syncronization.MgrMyPlayer.EUiLoadingFinishFlag Construction = 2;
	static WizardGames.Soc.Common.Syncronization.MgrMyPlayer.EUiLoadingFinishFlag Weapon = 4;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.MgrMyPlayer.<>c : System.Object
{
	static WizardGames.Soc.Common.Syncronization.MgrMyPlayer.<>c <>9; // 0x0
	static WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__392_0; // 0x8
	static System.Void .cctor(); // 0x06d20d4c
	System.Void .ctor(); // 0x06d20db0
	System.Void <NewbieItemSwitchFinishDoSomething>b__392_0(System.Int64 id, System.Object data, System.Boolean delete); // 0x06d20e18
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.MgrMyPlayer.<>c__DisplayClass235_0 : System.Object
{
	System.Boolean isAidingOther; // 0x10
	System.Void .ctor(); // 0x06d20ed8
	System.Void <OpenDyingWindow>b__0(WizardGames.Soc.SocClient.Ui.UiDying uiDyingWin); // 0x06d20f40
}

// Client.Runtime
enum WizardGames.Soc.Common.Syncronization.LittleEyeEnableBit : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Syncronization.LittleEyeEnableBit UI = 0;
	static WizardGames.Soc.Common.Syncronization.LittleEyeEnableBit Zipline = 1;
	static WizardGames.Soc.Common.Syncronization.LittleEyeEnableBit Count = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Syncronization.LittleEyeState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Syncronization.LittleEyeState None = 0;
	static WizardGames.Soc.Common.Syncronization.LittleEyeState In = 1;
	static WizardGames.Soc.Common.Syncronization.LittleEyeState Exit = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Syncronization.ViewOffsetType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Syncronization.ViewOffsetType ViewKick = 0;
	static WizardGames.Soc.Common.Syncronization.ViewOffsetType Breathe = 1;
	static WizardGames.Soc.Common.Syncronization.ViewOffsetType Walk = 2;
	static WizardGames.Soc.Common.Syncronization.ViewOffsetType Count = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Syncronization.ShootOffsetType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Syncronization.ShootOffsetType MagicBullet = 0;
	static WizardGames.Soc.Common.Syncronization.ShootOffsetType GunKick = 1;
	static WizardGames.Soc.Common.Syncronization.ShootOffsetType Count = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.SecMoveReportInfo : System.Object
{
	static System.Single RecordInterval = 0.5;
	static System.Single ReportInterval = 300;
	System.Int32 angle; // 0x10
	System.Single startTime; // 0x14
	System.Single recordTime; // 0x18
	System.Single deltaTime; // 0x1c
	System.Int32 recordIndex; // 0x20
	System.Int32[] angleFlow; // 0x28
	System.Int32[] angleDistribution; // 0x30
	System.Void .ctor(); // 0x06d20fc8
	System.Void Tick(); // 0x06d21158
	System.Void SetAngle(System.Int32 newAngle); // 0x06d21448
	System.Void Record(); // 0x06d2122c
	System.Void Clear(); // 0x06d2108c
	System.Void Report(); // 0x06d2131c
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.MgrPredict : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.HashSet<System.Int64> UserCmdHistory; // 0x18
	System.Int64 LastAddCmdSequence; // 0x20
	System.Int64 lastRemoveCmdSequence; // 0x28
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.HistoryPlayerEntity> MyEntityHistory; // 0x30
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.HistoryWeaponEntity> MyWeaponHistory; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.HistoryHorseEntity> HorseEntityHistory; // 0x40
	System.Int64 MyEntityTeleportSeq; // 0x48
	WizardGames.Soc.Common.Utility.Counter PredictionFailureCount; // 0x50
	WizardGames.Soc.Common.Utility.Counter PosPredictionFailureCount; // 0x58
	WizardGames.Soc.Common.Utility.Counter MoveStateFailureCount; // 0x60
	WizardGames.Soc.Common.Utility.Counter IsGroundFailureCount; // 0x68
	WizardGames.Soc.Common.Utility.Counter WeaponIdFailureCount; // 0x70
	System.Int64 PausePredictCmdSequence; // 0x78
	System.Int64 LastCompareCmdSequence; // 0x80
	WizardGames.Soc.Common.Syncronization.PlayerPredictLogic PlayerPredictLogic; // 0x88
	WizardGames.Soc.Common.Syncronization.PlatformPredictLogic PlatformPredictLogic; // 0x89
	WizardGames.Soc.Common.Syncronization.Predict.WeaponPredictLogic WeaponPredictLogic; // 0x8a
	WizardGames.Soc.Common.Syncronization.HorsePredictLogic HorsePredictLogic; // 0x8b
	UnityEngine.Vector3 entityPos; // 0x8c
	UnityEngine.Vector3 ccPos; // 0x98
	UnityEngine.Vector3 playerGoPos; // 0xa4
	WizardGames.Soc.Common.Entity.PlayerMoveStateEnum MoveState; // 0xb0
	WizardGames.Soc.Common.Entity.PlayerMoveMantleStateEnum MantleState; // 0xb1
	WizardGames.Soc.Common.Entity.PlayerMoveJumpStateEnum MoveJumpState; // 0xb2
	System.Collections.Generic.List<System.Int64> removeList; // 0xb8
	System.Void Init(); // 0x06d214c0
	System.Threading.Tasks.Task OnExitWorld(); // 0x06d215d8
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06d216fc
	System.Void CompareHistory(); // 0x06d21828
	System.Void Rollback(WizardGames.Soc.Common.Entity.PlayerEntity serverEntity, System.Int64 cmdSequence, WizardGames.Soc.Common.Entity.HistoryPlayerEntity localEntity); // 0x06d23e3c
	System.Void RecordPlayerPos(); // 0x06d24aa0
	System.Void RecoveryPlayerPos(); // 0x06d24f7c
	System.Void SaveUserCmdResultHistory(); // 0x06d251c0
	System.Void SaveUserCmdResultHistoryByHorse(); // 0x06d25aac
	System.Void RemoveUserCmdResultHistory(System.Int64 sequence, System.Boolean clearAll); // 0x06d238f4
	System.Void HorseRollback(WizardGames.Soc.Common.Entity.HorseEntity serverEntity, System.Int64 cmdSequence, WizardGames.Soc.Common.Entity.HistoryHorseEntity localEntity); // 0x06d25d00
	System.Void CleanUp(); // 0x06d26560
	System.Void .ctor(); // 0x06d26634
	static System.Void .cctor(); // 0x06d26a0c
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.MgrUserCmd : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Data.AdsOnType AdsOnTypConfig; // 0x14
	System.Boolean SetupSprintPressed; // 0x18
	System.Boolean SetupCrouchPressed; // 0x19
	System.Int64 DeltaSqe; // 0x20
	WizardGames.Soc.Common.SimpleCustom.UserCmd NowCmd; // 0x28
	WizardGames.Soc.Common.SimpleCustom.UserCmd LastCmd; // 0x30
	System.Collections.Generic.Queue<WizardGames.Soc.Common.SimpleCustom.UserCmd> _cmdQueue; // 0x38
	WizardGames.Soc.Common.SimpleCustom.UserCmd BaseCmd; // 0x40
	System.Int64 lastCmdTime; // 0x48
	System.Int64 lastTraceTs; // 0x50
	System.Int64 lastReportData2Ts; // 0x58
	System.Int32 _cmdSequence; // 0x60
	WizardGames.Soc.Common.Framework.Network.INetworkCompressor lz4Compressor; // 0x68
	System.Int64 lastSendAntiCheatSource2Ts; // 0x70
	System.Int64 lastSendAntiCheatSource1Ts; // 0x78
	System.Boolean JustFiredBullet; // 0x80
	static System.Int64 PredictAidTargetId; // 0x8
	System.Int32 LastRemoveCmdSequence; // 0x84
	System.Int32 SendCmdStep; // 0x88
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.UserCmd> tempList; // 0x90
	System.Boolean get_SetupAdsPressed(); // 0x06d26ae0
	System.Void .ctor(); // 0x06d26b4c
	System.Void CleanUp(); // 0x06d26cbc
	System.Void CreateUserCmd(); // 0x06d26d20
	System.Void CreateReviewCmd(); // 0x06d26df0
	System.Void PrePredictMove(System.Int32 FrameTime, System.Int64 snapshotSequence); // 0x06d26fc0
	System.Void SendUserCmd(System.Int64 serverWorldTime, System.Int64 renderTime, System.Boolean isOnline); // 0x06d27050
	System.Void SaveUserCmd(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06d26f14
	System.Collections.Generic.IList<WizardGames.Soc.Common.SimpleCustom.UserCmd> CmdList(System.Int64 cmdSequence); // 0x06d24d20
	System.Collections.Generic.IList<WizardGames.Soc.Common.SimpleCustom.UserCmd> GetCmd(System.Int64 cmdSequence); // 0x06d24844
	System.Void OnAckCmd(System.Int64 cmdAck); // 0x06d27a2c
	WizardGames.Soc.Common.SimpleCustom.UserCmd GetBaseCmd(); // 0x06d27bfc
	System.Void ResetBaseCmd(WizardGames.Soc.Common.Syncronization.MgrUserCmd.EBaseCmdResetReason reason); // 0x06d279ac
	System.Void DoFastReconnect(); // 0x06d27c60
	System.Void InitCmdSequence(System.Int32 cmdSequence); // 0x06d27d60
	System.Void CheckFilterCmd(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06d278f4
	static System.Void .cctor(); // 0x06d27de8
}

// Client.Runtime
enum WizardGames.Soc.Common.Syncronization.MgrUserCmd.EBaseCmdResetReason : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Syncronization.MgrUserCmd.EBaseCmdResetReason CmdQueueFull = 0;
	static WizardGames.Soc.Common.Syncronization.MgrUserCmd.EBaseCmdResetReason CmdAck = 1;
	static WizardGames.Soc.Common.Syncronization.MgrUserCmd.EBaseCmdResetReason Reconnect = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.PlayerCmdPreserver : System.Object
{
	WizardGames.Soc.Common.Syncronization.BaseCmdPreserver CurrentPreserver; // 0x10
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Syncronization.BaseCmdPreserver> preservers; // 0x18
	System.Collections.Generic.List<System.Int32> usingPreservers; // 0x20
	System.Collections.Generic.HashSet<System.Int32> excludePreserve; // 0x28
	static System.Boolean EnableBuffer; // 0x0
	System.Void .ctor(); // 0x06d27e8c
	System.Void OnHeldItemChanged(WizardGames.Soc.Common.Entity.IHeldItemEntity helditem); // 0x06d28618
	System.Void PreProcessCmdRecord(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastcmd); // 0x06d28cc4
	System.Void PostProcessCmdRecord(WizardGames.Soc.Common.Entity.PlayerEntity player); // 0x06d28ebc
	static System.Boolean CreatePreserver(System.Int32 type, WizardGames.Soc.Common.Syncronization.BaseCmdPreserver& preserver); // 0x06d280a0
	static System.Void .cctor(); // 0x06d28fec
}

// Client.Runtime
struct WizardGames.Soc.Common.Syncronization.HorsePredictLogic : System.ValueType
{
	
	System.Boolean PredictCheck(WizardGames.Soc.Common.Syncronization.PredictContext& pc); // 0x06d23240
	System.Boolean ComparePosition(WizardGames.Soc.Common.Syncronization.PredictContext& pc); // 0x06d2930c
	System.Void RollBack(WizardGames.Soc.Common.Syncronization.PredictContext& pc); // 0x06d236d0
}

// Client.Runtime
struct WizardGames.Soc.Common.Syncronization.PredictContext : System.ValueType
{
	WizardGames.Soc.Common.Entity.HistoryPlayerEntity LocalPlayer; // 0x10
	WizardGames.Soc.Common.Entity.HistoryPlayerEntity NextLocalPlayer; // 0x18
	WizardGames.Soc.Common.Entity.PlayerEntity ServerPlayer; // 0x20
	WizardGames.Soc.SocClient.Player.HeldItem.ALocalCustomWrapper LocalWrapper; // 0x28
	WizardGames.Soc.Common.Entity.IItemEntity ServerHeldItem; // 0x30
	WizardGames.Soc.Common.Entity.HistoryWeaponEntity LocalWeapon; // 0x38
	System.Int64 UserCmdSequence; // 0x40
	System.Boolean Predict; // 0x48
	System.Boolean NeedRollBack; // 0x49
	WizardGames.Soc.Common.Syncronization.EPredictStep Step; // 0x4c
	System.String Rst; // 0x50
	System.Boolean HorsePredict; // 0x58
	WizardGames.Soc.Common.Entity.HistoryHorseEntity LocalHorse; // 0x60
	WizardGames.Soc.Common.Entity.HorseEntity ServerHorse; // 0x68
	WizardGames.Soc.Common.Syncronization.EPredictStep HorseStep; // 0x70
	System.String HorseRst; // 0x78
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Syncronization.EPredictStep : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Syncronization.EPredictStep None = 0;
	static WizardGames.Soc.Common.Syncronization.EPredictStep EntityEmpty = 1;
	static WizardGames.Soc.Common.Syncronization.EPredictStep ClientTime = 2;
	static WizardGames.Soc.Common.Syncronization.EPredictStep MoveState = 3;
	static WizardGames.Soc.Common.Syncronization.EPredictStep PoseState = 4;
	static WizardGames.Soc.Common.Syncronization.EPredictStep ZiplineState = 5;
	static WizardGames.Soc.Common.Syncronization.EPredictStep ActionState = 6;
	static WizardGames.Soc.Common.Syncronization.EPredictStep InteractiveState = 7;
	static WizardGames.Soc.Common.Syncronization.EPredictStep LaddersState = 8;
	static WizardGames.Soc.Common.Syncronization.EPredictStep WeaponId = 9;
	static WizardGames.Soc.Common.Syncronization.EPredictStep PlayerPos = 10;
	static WizardGames.Soc.Common.Syncronization.EPredictStep PlatFormPos = 11;
	static WizardGames.Soc.Common.Syncronization.EPredictStep WeaponState = 12;
	static WizardGames.Soc.Common.Syncronization.EPredictStep HorseMoveState = 13;
	static WizardGames.Soc.Common.Syncronization.EPredictStep HorseFuel = 14;
	static WizardGames.Soc.Common.Syncronization.EPredictStep HorseMaxFuel = 15;
	static WizardGames.Soc.Common.Syncronization.EPredictStep HorsePos = 16;
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Syncronization.PlatformPredictLogic : System.ValueType
{
	
	System.Boolean PredictCheck(WizardGames.Soc.Common.Syncronization.PredictContext& pc); // 0x06d22ad0
	System.Boolean ComparePosition(WizardGames.Soc.Common.Syncronization.PredictContext& pc); // 0x06d29554
	System.Boolean ComparePosition(WizardGames.Soc.Common.Entity.HistoryPlayerEntity localEntity, WizardGames.Soc.Common.Entity.PlayerEntity serverEntity, System.String& rst, WizardGames.Soc.Common.Syncronization.EPredictStep& step); // 0x06d29614
	System.Void RollBack(WizardGames.Soc.Common.Syncronization.PredictContext& pc); // 0x06d22d50
}

// Client.Runtime
struct WizardGames.Soc.Common.Syncronization.PlayerPredictLogic : System.ValueType
{
	
	System.Boolean PredictCheck(WizardGames.Soc.Common.Syncronization.PredictContext& pc); // 0x06d222fc
	System.Boolean ComparePosition(WizardGames.Soc.Common.Syncronization.PredictContext& pc); // 0x06d29bc4
	System.Void RollBack(WizardGames.Soc.Common.Syncronization.PredictContext& pc); // 0x06d22eb8
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.PredictLogicUtility : System.Object
{
	
	static System.Boolean CompareLongValue(System.String title, System.Int64 server, System.Int64 client, System.Int64 limit, System.String& rst); // 0x06d298ec
	static System.Boolean CompareFloatValue(System.String title, System.Single server, System.Single client, System.Single limit, System.String& rst); // 0x06d29038
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.WearEquipChange.DivingmaskEquipHandler : WizardGames.Soc.Common.Syncronization.WearEquipChange.WearEquipBase, WizardGames.Soc.Common.Syncronization.WearEquipChange.IWearEquipHandler
{
	UnityEngine.GameObject PPV_DivingGlasses; // 0x20
	static System.String ppvName; // 0x0
	System.Boolean isInit; // 0x28
	System.Boolean isShowUIModel; // 0x29
	System.Void .ctor(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, System.Boolean isMaster); // 0x06d29ea4
	System.Void InitMasterInfo(); // 0x06d29fcc
	System.Void DoPutOnAction(System.Int64 equipId, System.Int32 position); // 0x06d2a158
	System.Void CameraInWaterChangeAction(System.Boolean inWater); // 0x06d2a678
	System.Void DoTakeOffAction(System.Int64 equipId, System.Int32 position); // 0x06d2a710
	System.Void DoChangeSameEquipAction(); // 0x06d2a938
	System.Void SetDivingGlassActive(System.Boolean enabled); // 0x06d2a57c
	System.Void OnUIModelShow(System.Boolean isShow); // 0x06d2a998
	System.Void CleanUp(); // 0x06d2ab80
	static System.Void .cctor(); // 0x06d2ac48
}

// Client.Runtime
interface WizardGames.Soc.Common.Syncronization.WearEquipChange.IWearEquipHandler : 
{
	
	System.Void DoPutOnAction(System.Int64 equipId, System.Int32 position); // 0x055112d4
	System.Void DoTakeOffAction(System.Int64 equipId, System.Int32 position); // 0x055112d4
	System.Void DoChangeSameEquipAction(); // 0x055049cc
	System.Void CleanUp(); // 0x055049cc
	System.Void Update(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.WearEquipChange.LightableHatEquipHandler : WizardGames.Soc.Common.Syncronization.WearEquipChange.WearEquipBase, WizardGames.Soc.Common.Syncronization.WearEquipChange.IWearEquipHandler
{
	WizardGames.Soc.SocClient.GoLoader.PartModelController partModelController; // 0x20
	WizardGames.Soc.Common.CustomType.WearItemCustom lightableEquip; // 0x28
	System.Int64 equipEnableFlagsSubscribeId; // 0x30
	System.Void .ctor(WizardGames.Soc.SocClient.GoLoader.PartModelController partModelController, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, System.Boolean isMaster); // 0x06d2acb0
	System.Void OnCameraStateChange(WizardGames.Soc.Common.Unity.CameraState oldCameraState, WizardGames.Soc.Common.Unity.CameraState nowCameraState); // 0x06d2ae4c
	System.Void DoPutOnAction(System.Int64 equipId, System.Int32 position); // 0x06d2b310
	System.Void ConditionChanged(WizardGames.Soc.Share.Framework.CustomTypeBase embeddedEntity, System.Single oldValue, System.Single newValue); // 0x06d2b6a8
	System.Void MyPlayerUpdateOnReconnect(); // 0x06d2b7fc
	System.Void EquipEnableFlagsChanged(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Int32 oldValue, System.Int32 newValue); // 0x06d2b85c
	System.Void DoTakeOffAction(System.Int64 equipId, System.Int32 position); // 0x06d2b934
	System.Void DoChangeSameEquipAction(); // 0x06d2be5c
	System.Void CleanUp(); // 0x06d2c14c
	System.Void TryCloseHeadLight(System.Boolean isRemove, System.Boolean needSend); // 0x06d2c2a4
	System.Void OnUILightClickDelegate(System.Boolean on); // 0x06d2c46c
	System.Void SetHatLightActive(System.Boolean active); // 0x06d2afac
	System.Void OpenLight(); // 0x06d2c54c
	System.Void CloseHatLight(System.Boolean isAuto, System.Boolean needSend); // 0x06d2bb84
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.WearEquipChange.NightVisionEquipHandler : WizardGames.Soc.Common.Syncronization.WearEquipChange.WearEquipBase, WizardGames.Soc.Common.Syncronization.WearEquipChange.IWearEquipHandler
{
	static System.String ppvName; // 0x0
	UnityEngine.GameObject PPV_NightVisionDevice; // 0x20
	UnityEngine.Rendering.Universal.ColorAdjustments colorAdjustment; // 0x28
	System.Boolean isInit; // 0x30
	WizardGames.Soc.Common.CustomType.WearItemCustom nightVisionEquip; // 0x38
	System.Single upperBoundary; // 0x40
	System.Single lowerBoundary; // 0x44
	static System.Action<System.Boolean> OnSwitchAction; // 0x8
	static System.Action<System.Single> OnLightChange; // 0x10
	WizardGames.Soc.SocClient.GoLoader.PartModelController partModelController; // 0x48
	static System.Void add_OnSwitchAction(System.Action<System.Boolean> value); // 0x06d2c610
	static System.Void remove_OnSwitchAction(System.Action<System.Boolean> value); // 0x06d2c740
	static System.Void add_OnLightChange(System.Action<System.Single> value); // 0x06d2c870
	static System.Void remove_OnLightChange(System.Action<System.Single> value); // 0x06d2c9a0
	System.Void .ctor(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, System.Boolean isMaster, WizardGames.Soc.SocClient.GoLoader.PartModelController tpControl); // 0x06d2cad0
	System.Void OnCameraStateChange(WizardGames.Soc.Common.Unity.CameraState oldCameraState, WizardGames.Soc.Common.Unity.CameraState nowCameraState); // 0x06d2cc78
	System.Void Update(); // 0x06d2d088
	System.Void InitMasterInfo(); // 0x06d2d588
	System.Void DoPutOnAction(System.Int64 equipId, System.Int32 position); // 0x06d2d768
	System.Void OnUILightClickDelegate(System.Boolean on); // 0x06d2da28
	System.Void OpenLight(); // 0x06d2db04
	System.Void CloseLight(System.Boolean isAuto); // 0x06d2dbcc
	System.Void SetNightVisionActive(System.Boolean enabled, System.Boolean setMask); // 0x06d2cde0
	System.Void ConditionChanged(WizardGames.Soc.Share.Framework.CustomTypeBase embeddedEntity, System.Single oldValue, System.Single newValue); // 0x06d2e208
	System.Void DoTakeOffAction(System.Int64 equipId, System.Int32 position); // 0x06d2e358
	System.Void DoChangeSameEquipAction(); // 0x06d2e504
	System.Void OnUIModelShow(System.Boolean isShow); // 0x06d2e888
	System.Void SetNightLightActive(System.Boolean active); // 0x06d2de9c
	System.Void CleanUp(); // 0x06d2e96c
	static System.Void .cctor(); // 0x06d2eb08
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.WearEquipChange.SunglassesEquipHandler : WizardGames.Soc.Common.Syncronization.WearEquipChange.WearEquipBase, WizardGames.Soc.Common.Syncronization.WearEquipChange.IWearEquipHandler
{
	static System.String ppvName; // 0x0
	System.Void .ctor(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, System.Boolean isMaster); // 0x06d2eb70
	System.Void DoPutOnAction(System.Int64 equipId, System.Int32 position); // 0x06d2ebf8
	System.Void DoTakeOffAction(System.Int64 equipId, System.Int32 position); // 0x06d2ecfc
	System.Void DoChangeSameEquipAction(); // 0x06d2ee00
	System.Void CleanUp(); // 0x06d2ee60
	static System.Void .cctor(); // 0x06d2eec0
}

// Client.Runtime
class WizardGames.Soc.Common.Syncronization.WearEquipChange.WearEquipBase : System.Object
{
	WizardGames.Soc.Common.Entity.PlayerEntity playerEntity; // 0x10
	System.Boolean isMaster; // 0x18
	System.Void .ctor(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, System.Boolean isMaster); // 0x06d29f2c
	System.Void OnUIModelShow(System.Boolean isShow); // 0x06d2ef28
	System.Void Update(); // 0x06d2ef9c
}

// Client.Runtime
struct WizardGames.Soc.Common.Syncronization.Predict.WeaponPredictLogic : System.ValueType
{
	
	System.Boolean PredictCheck(WizardGames.Soc.Common.Syncronization.PredictContext& pc); // 0x06d22b4c
	System.Void RollBack(WizardGames.Soc.Common.Syncronization.PredictContext& pc); // 0x06d22e20
}

// Client.Runtime
class WizardGames.Soc.Common.Manager.CallbackData : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	System.Int32 hashCode; // 0x1c
	System.Action<System.Int32,WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent> callback; // 0x20
	System.Func<WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent,System.Boolean> filter; // 0x28
	System.Boolean isEarly; // 0x30
	System.Void .ctor(); // 0x06d2effc
}

// Client.Runtime
class WizardGames.Soc.Common.Manager.LocationBasedEventManager : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.DataSet.CommonDataSet<WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent>> eventQueueMap; // 0x18
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int64>> subscriberDict; // 0x20
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Manager.CallbackData> callbackDataDict; // 0x28
	static SocLogger logger; // 0x0
	static System.Int64 callbackId; // 0x8
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> SnapshotPoolCount; // 0x30
	System.Void Init(); // 0x06d2f064
	System.Int64 SubscribeEvent(System.Int32 hashCode, System.Action<System.Int32,WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent> callback, System.Boolean isEarly, System.Func<WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent,System.Boolean> filter); // 0x06d2f0c8
	System.Void UnsubscribeEvent(System.Int64 subscribeId); // 0x06d2f338
	System.Void EmitEvents(System.Boolean isEarly); // 0x06d2f4b0
	WizardGames.Soc.Common.DataSet.CommonDataSet<WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent> GetRequestQueue(System.Int32 hashCode); // 0x06d2f9b4
	System.Void AddEvent(WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent baseSnapshotEvent); // 0x06d2fad0
	System.Void IteratorAllEvents<U,M>(System.Int32 hashCode, WizardGames.Soc.Common.DataSet.CommonDelegate.EventDelegate<U,M> action, M& arg0); // 0x052af1f0
	System.Void IteratorAllEvents<U,M>(System.Int32 hashCode, WizardGames.Soc.Common.DataSet.CommonDelegate.EventDelegate2<U,M> action, M arg0); // 0x052af1f0
	System.Void IteratorAllEvents<U,M,K>(System.Int32 hashCode, WizardGames.Soc.Common.DataSet.CommonDelegate.EventDelegate<U,M,K> action, M& arg0, K& arg1); // 0x052af1f0
	WizardGames.Soc.Common.DataSet.CommonDataSet<WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent> BindEventQueue(System.Int32 hashCode); // 0x06d2fb94
	System.Void ClearEventQueue(); // 0x06d2fc10
	System.Int32 GetPoolCount(System.Int32 hashCode); // 0x06d2ff78
	System.Void .ctor(); // 0x06d30030
	static System.Void .cctor(); // 0x06d30254
}

// Client.Runtime
enum WizardGames.Soc.Common.Manager.MgrRange : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Manager.MgrRange Persistent = 1;
	static WizardGames.Soc.Common.Manager.MgrRange LobbyOnly = 2;
	static WizardGames.Soc.Common.Manager.MgrRange GameOnly = 4;
	static WizardGames.Soc.Common.Manager.MgrRange AllRange = 7;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Manager.McCommon : System.Object
{
	WizardGames.Soc.Common.Manager.McCommon.MgrRegList[] MgrRegLists; // 0x10
	System.Collections.Generic.Dictionary<System.Type,WizardGames.Soc.Common.Manager.McCommon.MgrRegister> fixedMgrRegDict; // 0x18
	System.Collections.Generic.Dictionary<System.Type,WizardGames.Soc.Common.Manager.McCommon.MgrRegister> mgrRegDict; // 0x20
	System.Collections.Generic.Dictionary<System.Type,WizardGames.Soc.Common.Manager.McCommon.MgrRegister> re_RegMgrDic; // 0x28
	static System.Boolean OpenShadow; // 0x0
	static System.Boolean UseResShadowSetting; // 0x1
	static SocLogger logger; // 0x8
	static WizardGames.Soc.Common.Manager.McCommon _instance; // 0x10
	System.Int32 MgrIndex; // 0x30
	System.Int32 ClientLogicFrameTime; // 0x34
	System.Int32 LogicFrameTime; // 0x38
	System.Int32 CurrentFrameTime; // 0x3c
	System.Boolean OpenDynamicFrameTime; // 0x40
	static System.Func<System.UInt64,WizardGames.Soc.Common.Entity.PlayerEntity> GetPlayerByRoleIdFunc; // 0x18
	static System.Func<System.Int64,WizardGames.Soc.Common.Entity.IEntity> GetEntityFunc; // 0x20
	static System.Action<System.Int64,WizardGames.Soc.Common.Entity.IEmbeddedCustom> AddToEmbeddedEntity; // 0x28
	static System.Action<System.Int64> RemoveFromEmbeddedEntity; // 0x30
	static System.Collections.Generic.List<WizardGames.Soc.Share.Framework.CustomTypeBase> EmbeddedEntityCreateList; // 0x38
	System.Comparison<WizardGames.Soc.Common.Manager.McCommon.MgrRegister> mgrRegComparison; // 0x48
	System.Collections.Generic.List<WizardGames.Soc.Common.Manager.McCommon.MgrRegister> SortedMgrRegs; // 0x50
	System.Collections.Generic.List<WizardGames.Soc.Common.Manager.MgrBase> MgrList; // 0x58
	System.Boolean hasCallOnAccountEnterLobby; // 0x60
	static WizardGames.Soc.Common.Main.Loop.MgrLoop Loop; // 0x40
	static WizardGames.Soc.Common.Synchronization.MgrTime Time; // 0x48
	static WizardGames.Soc.Common.Systems.MgrSystem System; // 0x50
	static WizardGames.Soc.Common.Data.MgrTables Tables; // 0x58
	static WizardGames.Soc.Common.Unity.Manager.MgrCollider Collider; // 0x60
	static WizardGames.Soc.Common.Manager.MgrElectric Electric; // 0x68
	static WizardGames.Soc.Common.Manager.IElectricCollection ElectricCollection; // 0x70
	static WizardGames.Soc.Common.Manager.LocationBasedEventManager LocationBasedEvent; // 0x78
	static WizardGames.Soc.Common.Manager.SystemRequestManager SystemRequestMgr; // 0x80
	System.Boolean <IsClient>k__BackingField; // 0x61
	static WizardGames.Soc.Common.Manager.McCommon get_Instance(); // 0x06d3033c
	System.Void .ctor(); // 0x06d3042c
	System.Void CleanUp(System.Boolean clearMgrList); // 0x06d3097c
	System.Int32 RangeToIndex(WizardGames.Soc.Common.Manager.MgrRange range); // 0x06d30c10
	System.Void RegFixedMgr<T>(System.Action<WizardGames.Soc.Common.Manager.MgrBase> setMgr, WizardGames.Soc.Common.Manager.MgrRange range); // 0x052af1f0
	System.Void RegMgr<T>(System.Action<WizardGames.Soc.Common.Manager.MgrBase> setMgr, WizardGames.Soc.Common.Manager.MgrRange range, System.Boolean reRegister); // 0x052af1f0
	WizardGames.Soc.Common.Manager.McCommon.MgrRegister CreateMgrReg<T>(System.Action<WizardGames.Soc.Common.Manager.MgrBase> setMgr, WizardGames.Soc.Common.Manager.MgrRange range); // 0x052af1f0
	System.Void RegMgr(WizardGames.Soc.Common.Manager.McCommon.MgrRegister reg); // 0x06d30c98
	System.Void ActiveMgrRegs(WizardGames.Soc.Common.Manager.MgrRange range, System.Boolean isActive, System.Collections.Generic.List<WizardGames.Soc.Common.Manager.McCommon.MgrRegister> sortedMgrRegs); // 0x06d30ddc
	System.Void InitMgrByRange(WizardGames.Soc.Common.Manager.MgrRange InRange); // 0x06d30f40
	System.Void ClearMgrByRange(WizardGames.Soc.Common.Manager.MgrRange InRange, System.Boolean isCleanUp); // 0x06d314a4
	System.Void Re_RegisterMgrs(); // 0x06d31908
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06d31f8c
	System.Threading.Tasks.Task AfterEnterWorld(); // 0x06d320a0
	System.Threading.Tasks.Task OnExitWorld(); // 0x06d321b4
	System.Void BeforeEnterWorld(); // 0x06d322c8
	System.Void AfterExitWorld(); // 0x06d32328
	System.Void OnSdkLogined(); // 0x06d32388
	System.Void OnAccountLogined(); // 0x06d3268c
	System.Void OnAccountEnterLobby(); // 0x06d32990
	System.Void OnAccountLogout(); // 0x06d32ca4
	System.Void OnLobbyReconnected(); // 0x06d32fb0
	System.Void OnFastReconnected(); // 0x06d332b8
	System.Void OnFastDisconnected(WizardGames.Soc.Common.Framework.Network.DisconnectReason reason); // 0x06d335c0
	System.Void RegisterAllMgrs(); // 0x06d338e0
	System.Void set_IsClient(System.Boolean value); // 0x06d33d78
	WizardGames.Soc.Common.Manager.MgrBase GetMgrByName(System.String className); // 0x06d33df4
	static System.Void .cctor(); // 0x06d33fc0
}

// Client.Runtime
class WizardGames.Soc.Common.Manager.McCommon.MgrRegister : System.Object
{
	System.Func<WizardGames.Soc.Common.Manager.MgrBase> CreateMgr; // 0x10
	System.Type CreateType; // 0x18
	System.Action<WizardGames.Soc.Common.Manager.MgrBase> SetMgr; // 0x20
	WizardGames.Soc.Common.Manager.MgrBase Inst; // 0x28
	System.Int32 Index; // 0x30
	System.Int32 RangeIndex; // 0x34
	WizardGames.Soc.Common.Manager.MgrBase Create(); // 0x06d313ec
	System.Void Clear(System.Boolean isCleanUp); // 0x06d31774
	System.Void SetNull(); // 0x06d3187c
	System.Void .ctor(); // 0x06d340f8
}

// Client.Runtime
class WizardGames.Soc.Common.Manager.McCommon.MgrRegList : System.Object
{
	System.Boolean IsActive; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.Manager.McCommon.MgrRegister> MgrRegs; // 0x18
	System.Void .ctor(); // 0x06d30914
}

// Client.Runtime
class WizardGames.Soc.Common.Manager.McCommon.<>c : System.Object
{
	static WizardGames.Soc.Common.Manager.McCommon.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.Manager.McCommon.MgrRegister> <>9__33_0; // 0x8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__65_0; // 0x10
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__65_1; // 0x18
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__65_2; // 0x20
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__65_3; // 0x28
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__65_4; // 0x30
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__65_5; // 0x38
	static System.Void .cctor(); // 0x06d34160
	System.Void .ctor(); // 0x06d341c4
	System.Int32 <.ctor>b__33_0(WizardGames.Soc.Common.Manager.McCommon.MgrRegister a, WizardGames.Soc.Common.Manager.McCommon.MgrRegister b); // 0x06d3422c
	System.Void <RegisterAllMgrs>b__65_0(WizardGames.Soc.Common.Manager.MgrBase mgr); // 0x06d342c0
	System.Void <RegisterAllMgrs>b__65_1(WizardGames.Soc.Common.Manager.MgrBase mgr); // 0x06d343f4
	System.Void <RegisterAllMgrs>b__65_2(WizardGames.Soc.Common.Manager.MgrBase mgr); // 0x06d34528
	System.Void <RegisterAllMgrs>b__65_3(WizardGames.Soc.Common.Manager.MgrBase mgr); // 0x06d3465c
	System.Void <RegisterAllMgrs>b__65_4(WizardGames.Soc.Common.Manager.MgrBase mgr); // 0x06d34790
	System.Void <RegisterAllMgrs>b__65_5(WizardGames.Soc.Common.Manager.MgrBase mgr); // 0x06d348c4
}

// Client.Runtime
class WizardGames.Soc.Common.Manager.McCommon.<>c__38<T> : System.Object
{
	static WizardGames.Soc.Common.Manager.McCommon.<>c__38<T> <>9; // 0x0
	static System.Func<WizardGames.Soc.Common.Manager.MgrBase> <>9__38_0; // 0x8
	static System.Void .cctor(); // 0x054fd168
	System.Void .ctor(); // 0x055049cc
	WizardGames.Soc.Common.Manager.MgrBase <CreateMgrReg>b__38_0(); // 0x054e7844
}

// Client.Runtime
struct WizardGames.Soc.Common.Manager.McCommon.<AfterEnterWorld>d__45 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.Common.Manager.McCommon <>4__this; // 0x30
	System.Collections.Generic.List.Enumerator<WizardGames.Soc.Common.Manager.MgrBase> <>7__wrap1; // 0x38
	WizardGames.Soc.Common.Manager.MgrBase <m>5__3; // 0x50
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x58
	System.Void MoveNext(); // 0x06d349f8
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x06d34ffc
}

// Client.Runtime
struct WizardGames.Soc.Common.Manager.McCommon.<OnEnterWorld>d__44 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.Common.Manager.McCommon <>4__this; // 0x30
	System.Collections.Generic.List.Enumerator<WizardGames.Soc.Common.Manager.MgrBase> <>7__wrap1; // 0x38
	WizardGames.Soc.Common.Manager.MgrBase <m>5__3; // 0x50
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x58
	System.Void MoveNext(); // 0x06d350a0
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x06d356a4
}

// Client.Runtime
struct WizardGames.Soc.Common.Manager.McCommon.<OnExitWorld>d__46 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.Common.Manager.McCommon <>4__this; // 0x30
	System.Collections.Generic.List.Enumerator<WizardGames.Soc.Common.Manager.MgrBase> <>7__wrap1; // 0x38
	WizardGames.Soc.Common.Manager.MgrBase <m>5__3; // 0x50
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x58
	System.Void MoveNext(); // 0x06d35748
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x06d35e74
}

// Client.Runtime
class WizardGames.Soc.Common.Manager.MgrBase : System.Object
{
	System.Boolean <IsInited>k__BackingField; // 0x10
	System.Boolean get_IsInited(); // 0x06d35f18
	System.Void set_IsInited(System.Boolean value); // 0x06d35f7c
	System.Void Init(); // 0x06d21524
	System.Void Destroy(); // 0x06d35ff8
	System.Void CleanUp(); // 0x06d265d4
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06d21768
	System.Threading.Tasks.Task AfterEnterWorld(); // 0x06d360a8
	System.Threading.Tasks.Task OnExitWorld(); // 0x06d2163c
	System.Void OnSdkLogined(); // 0x06d36168
	System.Void OnAccountLogined(); // 0x06d361c8
	System.Void OnAccountEnterLobby(); // 0x06d36228
	System.Void OnAccountLogout(); // 0x06d36288
	System.Void OnLobbyReconnected(); // 0x06d362e8
	System.Void OnFastReconnected(); // 0x06d36348
	System.Void OnFastDisconnected(WizardGames.Soc.Common.Framework.Network.DisconnectReason reason); // 0x06d363a8
	System.Void .ctor(); // 0x06d1e348
}

// Client.Runtime
enum WizardGames.Soc.Common.Manager.ESystemRequest : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Manager.ESystemRequest FireRequestSet = 0;
	static WizardGames.Soc.Common.Manager.ESystemRequest BulletRequestSet = 1;
	static WizardGames.Soc.Common.Manager.ESystemRequest HitRequestSet = 2;
	static WizardGames.Soc.Common.Manager.ESystemRequest NextFrameHitRequestSet = 3;
	static WizardGames.Soc.Common.Manager.ESystemRequest FilterHitRequestSet = 4;
	static WizardGames.Soc.Common.Manager.ESystemRequest HostileSet = 5;
	static WizardGames.Soc.Common.Manager.ESystemRequest KillRequestSet = 6;
	static WizardGames.Soc.Common.Manager.ESystemRequest CorpseRequestSet = 7;
	static WizardGames.Soc.Common.Manager.ESystemRequest BulletSkillRequestSet = 8;
	static WizardGames.Soc.Common.Manager.ESystemRequest RebornRequestSet = 9;
	static WizardGames.Soc.Common.Manager.ESystemRequest EscapeRequestSet = 10;
	static WizardGames.Soc.Common.Manager.ESystemRequest UseItemRequestSet = 11;
	static WizardGames.Soc.Common.Manager.ESystemRequest UseItemAckRequestSet = 12;
	static WizardGames.Soc.Common.Manager.ESystemRequest ExplosionRequestSet = 13;
	static WizardGames.Soc.Common.Manager.ESystemRequest ItemEntityConditionSet = 14;
	static WizardGames.Soc.Common.Manager.ESystemRequest HeldItemRequestSet = 15;
	static WizardGames.Soc.Common.Manager.ESystemRequest ClientSwitchEventTpDataSet = 16;
	static WizardGames.Soc.Common.Manager.ESystemRequest ClientSwitchEventFpDataSet = 17;
	static WizardGames.Soc.Common.Manager.ESystemRequest CameraHitShakeDataSet = 18;
	static WizardGames.Soc.Common.Manager.ESystemRequest GunTrapFireRequest = 19;
	static WizardGames.Soc.Common.Manager.ESystemRequest WeaponEffectDataSet = 20;
	static WizardGames.Soc.Common.Manager.ESystemRequest TreeFallDownEffectSet = 21;
	static WizardGames.Soc.Common.Manager.ESystemRequest OfflineRequestSet = 22;
	static WizardGames.Soc.Common.Manager.ESystemRequest flyMoveRequestSet = 23;
	static WizardGames.Soc.Common.Manager.ESystemRequest PlayerSwitchHeldItemReqeustSet = 24;
	static WizardGames.Soc.Common.Manager.ESystemRequest PlayerInvisableBitReqeustSet = 25;
	static WizardGames.Soc.Common.Manager.ESystemRequest HeldItemInvisableBitReqeustSet = 26;
	static WizardGames.Soc.Common.Manager.ESystemRequest PlayerInteractiveReqeustSet = 27;
	static WizardGames.Soc.Common.Manager.ESystemRequest MonsterFireRequestSet = 28;
	static WizardGames.Soc.Common.Manager.ESystemRequest MonsterThrowRequestSet = 29;
	static WizardGames.Soc.Common.Manager.ESystemRequest ConstructionRefreshGradeRequestSet = 30;
	static WizardGames.Soc.Common.Manager.ESystemRequest DeathAnimRequestSet = 31;
	static WizardGames.Soc.Common.Manager.ESystemRequest ConstructionRefreshGapRequestSet = 32;
	static WizardGames.Soc.Common.Manager.ESystemRequest ConstructionGapPropertyChangeRequestSet = 33;
	static WizardGames.Soc.Common.Manager.ESystemRequest CameraShakeRequestSet = 34;
	static WizardGames.Soc.Common.Manager.ESystemRequest WireUpdateViewRequestSet = 35;
	static WizardGames.Soc.Common.Manager.ESystemRequest ClientHitStatisticRequestSet = 36;
	static WizardGames.Soc.Common.Manager.ESystemRequest SimulatorDeployMoveCheckRequestSet = 37;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Manager.SystemRequestManager : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Manager.ESystemRequest,WizardGames.Soc.Common.DataSet.CommonDataSet<Share.Common.ObjPool.Alpha3PooledObjectBase>> requestQueueMap; // 0x18
	System.Void Init(); // 0x06d3641c
	WizardGames.Soc.Common.DataSet.CommonDataSet<Share.Common.ObjPool.Alpha3PooledObjectBase> GetRequestQueue(WizardGames.Soc.Common.Manager.ESystemRequest requestEnum); // 0x06d36480
	System.Void AddRequest(WizardGames.Soc.Common.Manager.ESystemRequest requestEnum, Share.Common.ObjPool.Alpha3PooledObjectBase request); // 0x06d3659c
	WizardGames.Soc.Common.DataSet.CommonDataSet<Share.Common.ObjPool.Alpha3PooledObjectBase> BindRequestQueue(WizardGames.Soc.Common.Manager.ESystemRequest requestEnum); // 0x06d367f0
	System.Void .ctor(); // 0x06d3686c
	static System.Void .cctor(); // 0x06d36920
}

// Client.Runtime
interface WizardGames.Soc.Common.Manager.IElectricCollection : 
{
	
	
}

// Client.Runtime
class WizardGames.Soc.Common.Manager.ElectricICStorageNode : System.Object
{
	System.Int32 <StorageCapacity>k__BackingField; // 0x10
	System.Int32 <StorageNow>k__BackingField; // 0x14
	System.Int32 get_StorageCapacity(); // 0x06d369f4
	System.Int32 get_StorageNow(); // 0x06d36a58
	System.Void set_StorageNow(System.Int32 value); // 0x06d36abc
	static System.Int32 GetPartTypeValue(System.Int64 partType); // 0x06d36b34
	System.Boolean ChangePartNum(System.Int64 partType, System.Int32 num); // 0x06d36c6c
	System.Void ChangeStorageValue(System.Int32 value); // 0x06d36e50
	System.Void .ctor(); // 0x06d36f58
}

// Client.Runtime
class WizardGames.Soc.Common.Manager.MgrElectric : WizardGames.Soc.Common.Manager.MgrBase
{
	WizardGames.Soc.Common.CustomType.ElectricConnectSystem electricConnectSystem; // 0x18
	WizardGames.Soc.Common.CustomType.ElectricUpdateSystem electricUpdateSystem; // 0x20
	WizardGames.Soc.Common.CustomType.ElectricBluePrintSystem electricBluePrintSystem; // 0x28
	WizardGames.Soc.Common.CustomType.ElectricUpdateGroupContext electricUpdateGroupContext; // 0x30
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.CustomType.ElectricCBase> electricCBaseDic; // 0x38
	SocLogger get_Logger(); // 0x06d36fc0
	System.Int64 AddTimerOnce(System.Int32 timeout, System.Action<System.Int64> callback, System.String filePath, System.Int32 lineNumber); // 0x06d37050
	System.Void SafeCancelTimer(System.Int64& timerId); // 0x06d37250
	System.Void Init(); // 0x06d37308
	System.Void CleanUp(); // 0x06d373ac
	System.Void ElectricMarkDirty(System.Int64 id); // 0x06d37450
	System.Boolean RequestClear(System.Int64 entityId, System.Int32 index, System.Boolean isInput, System.Boolean tempVisiable); // 0x06d374d0
	static System.Boolean GenRevertICCmd(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit, WizardGames.Soc.Common.SimpleCustom.ICmd cmd, WizardGames.Soc.Common.SimpleCustom.ICmd& rcmd); // 0x06d3757c
	System.Boolean TryGetElectricC(System.Int64 id, WizardGames.Soc.Common.CustomType.ElectricCBase& comp); // 0x06d3760c
	System.Void AddElectricC(System.Int64 id, WizardGames.Soc.Common.CustomType.ElectricCBase comp); // 0x06d376b4
	System.Boolean RemoveElectricC(System.Int64 id); // 0x06d3775c
	System.Void .ctor(); // 0x06d3783c
	static System.Void .cctor(); // 0x06d379e4
}

// Client.Runtime
class WizardGames.Soc.Common.Manager.MgrElectric.<>c__DisplayClass8_0 : System.Object
{
	System.Action<System.Int64> callback; // 0x10
	System.Void .ctor(); // 0x06d371e8
	System.Void <AddTimerOnce>b__0(System.Int64 tid, System.Object _, System.Boolean __); // 0x06d37ab8
}

// Client.Runtime
class WizardGames.Soc.Common.Main.Loop.CustomLoop : System.Object, WizardGames.Soc.Common.Main.Loop.ILoop
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Main.Loop.LoopFrequency <LoopFrequency>k__BackingField; // 0x10
	WizardGames.Soc.Common.Profile.EProfileFunc <LoopFunc>k__BackingField; // 0x14
	WizardGames.Soc.Common.Utility.Counter <LoopCounter>k__BackingField; // 0x18
	System.Action<System.Int32,System.Int32,System.Int32> LoopUpdateAction; // 0x20
	System.Int32 loopQueueNumber; // 0x28
	WizardGames.Soc.Common.Main.Loop.LoopFrequency get_LoopFrequency(); // 0x06d37b64
	System.Void set_LoopFrequency(WizardGames.Soc.Common.Main.Loop.LoopFrequency value); // 0x06d37bc8
	WizardGames.Soc.Common.Profile.EProfileFunc get_LoopFunc(); // 0x06d37c40
	System.Void set_LoopFunc(WizardGames.Soc.Common.Profile.EProfileFunc value); // 0x06d37ca4
	System.Int32 get_LoopQueueNumber(); // 0x06d37d1c
	WizardGames.Soc.Common.Utility.Counter get_LoopCounter(); // 0x06d37d80
	System.Void set_LoopCounter(WizardGames.Soc.Common.Utility.Counter value); // 0x06d37de4
	System.Void .ctor(WizardGames.Soc.Common.Main.Loop.LoopFrequency freq, System.Int32 queueNumber, WizardGames.Soc.Common.Profile.EProfileFunc func, System.String name); // 0x06d37e64
	System.Void LoopUpdate(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x06d38340
	static System.Void .cctor(); // 0x06d385e4
}

// Client.Runtime
interface WizardGames.Soc.Common.Main.Loop.ILoop : 
{
	
	WizardGames.Soc.Common.Main.Loop.LoopFrequency get_LoopFrequency(); // 0x0548ba98
	System.Int32 get_LoopQueueNumber(); // 0x0548ba98
	WizardGames.Soc.Common.Utility.Counter get_LoopCounter(); // 0x054e7844
	System.Void LoopUpdate(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x05505834
}

// Client.Runtime
enum WizardGames.Soc.Common.Main.Loop.LoopFrequency : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Main.Loop.LoopFrequency BeforeLoop = 0;
	static WizardGames.Soc.Common.Main.Loop.LoopFrequency Unlimited = 1;
	static WizardGames.Soc.Common.Main.Loop.LoopFrequency Frequency60 = 2;
	static WizardGames.Soc.Common.Main.Loop.LoopFrequency Frequency45 = 3;
	static WizardGames.Soc.Common.Main.Loop.LoopFrequency Frequency30 = 4;
	static WizardGames.Soc.Common.Main.Loop.LoopFrequency Frequency20 = 5;
	static WizardGames.Soc.Common.Main.Loop.LoopFrequency Frequency10 = 6;
	static WizardGames.Soc.Common.Main.Loop.LoopFrequency Frequency5 = 7;
	static WizardGames.Soc.Common.Main.Loop.LoopFrequency Frequency2 = 8;
	static WizardGames.Soc.Common.Main.Loop.LoopFrequency Frequency1 = 9;
	static WizardGames.Soc.Common.Main.Loop.LoopFrequency AfterLoop = 10;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Main.Loop.LoopGroup : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Main.Loop.ILoop> LoopList; // 0x10
	System.Single LastTickTime; // 0x18
	System.Single ExcuteTime; // 0x1c
	System.Single NextTickTime; // 0x20
	System.Int32 FrequencyFrames; // 0x24
	WizardGames.Soc.Common.Utility.Counter GroupTimer; // 0x28
	System.Void .ctor(); // 0x06d386b8
}

// Client.Runtime
class WizardGames.Soc.Common.Main.Loop.MgrLoop : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger Log; // 0x0
	static System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Main.Loop.LoopFrequency,WizardGames.Soc.Common.Main.Loop.LoopGroup> LoopTable; // 0x8
	static System.Diagnostics.Stopwatch Stopwatch; // 0x10
	static System.Diagnostics.Stopwatch LoopPerformanceWatch; // 0x18
	static WizardGames.Soc.Common.Utility.Counter LoopTimer; // 0x20
	static System.Int64 _lastTickTime; // 0x28
	static System.Int32 _tickInterval; // 0x30
	static System.Int32 FrameCount; // 0x34
	static System.Collections.Generic.List<System.Int32> TickIntervalHistory; // 0x38
	static System.Diagnostics.Stopwatch loopWatch; // 0x40
	static System.Int32 LogTimes; // 0x48
	static System.Int32 TickCostWarningMs; // 0x4c
	static WizardGames.Soc.Common.Main.Loop.CustomLoop get_DefaultFpsUnlimitedLoop(); // 0x06d387d0
	static WizardGames.Soc.Common.Main.Loop.CustomLoop get_DefaultFps60Loop(); // 0x06d38c80
	static WizardGames.Soc.Common.Main.Loop.CustomLoop get_DefaultFps30Loop(); // 0x06d38d60
	static WizardGames.Soc.Common.Main.Loop.CustomLoop get_DefaultFps20Loop(); // 0x06d38e40
	static WizardGames.Soc.Common.Main.Loop.CustomLoop get_DefaultFps10Loop(); // 0x06d38f20
	static WizardGames.Soc.Common.Main.Loop.CustomLoop get_DefaultFps2Loop(); // 0x06d39000
	static WizardGames.Soc.Common.Main.Loop.CustomLoop get_DefaultFps1Loop(); // 0x06d390e0
	static WizardGames.Soc.Common.Main.Loop.CustomLoop get_DefaultAfterLoop(); // 0x06d391c0
	static WizardGames.Soc.Common.Main.Loop.CustomLoop get_DefaultBeforeLoop(); // 0x06d392a0
	static System.Int32 get_AverageTickInterval(); // 0x06d39380
	static System.Void CreateFrequency(WizardGames.Soc.Common.Main.Loop.LoopFrequency frequency, System.Int32 framesPerSeconds, System.Boolean isUnlimited); // 0x06d394b8
	static System.Void CreateLoopInfo(WizardGames.Soc.Common.Main.Loop.LoopFrequency frequency); // 0x06d3959c
	static System.Void .cctor(); // 0x06d396cc
	static WizardGames.Soc.Common.Main.Loop.ILoop GetLoopByName(System.String name); // 0x06d388b0
	static System.Boolean IsUnlimitedLoop(WizardGames.Soc.Common.Main.Loop.LoopFrequency freq); // 0x06d39d00
	static System.Void AddLoop(WizardGames.Soc.Common.Main.Loop.ILoop loop); // 0x06d38080
	static System.Boolean RemoveLoop(WizardGames.Soc.Common.Main.Loop.ILoop loop); // 0x06d39d7c
	static System.Boolean UpdateLoopList(WizardGames.Soc.Common.Main.Loop.LoopFrequency freq, System.Int64 now); // 0x06d39f0c
	static System.Int32 PredictNextUpdateTimeInterval(WizardGames.Soc.Common.Main.Loop.LoopGroup loop, System.Int64 now, System.Boolean isUnlimitedLoop); // 0x06d3a3d8
	static System.Void Tick(System.Int64 now); // 0x06d3a528
	static System.Void Update(); // 0x06d3a6bc
	static System.Void Clear(); // 0x06d3a9c8
	System.Void .ctor(); // 0x06d3aa50
}

// Client.Runtime
class WizardGames.Soc.Common.Main.Loop.MgrLoop.<>c : System.Object
{
	static WizardGames.Soc.Common.Main.Loop.MgrLoop.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.Main.Loop.ILoop> <>9__43_0; // 0x8
	static System.Void .cctor(); // 0x06d3aab4
	System.Void .ctor(); // 0x06d3ab18
	System.Int32 <AddLoop>b__43_0(WizardGames.Soc.Common.Main.Loop.ILoop x, WizardGames.Soc.Common.Main.Loop.ILoop y); // 0x06d3ab80
}

// Client.Runtime
class WizardGames.Soc.Common.LogService.SocUnityLogService : System.Object, System.IDisposable
{
	static SocLogger logger; // 0x0
	System.Void .ctor(); // 0x06d3ace4
	System.Void InitService(System.String loggerName, System.String configPath, System.String logFileName); // 0x06d3ad4c
	System.Void StopService(); // 0x06d3b1e4
	System.Void Dispose(); // 0x06d3b270
	static System.Void .cctor(); // 0x06d3b2d4
}

// Client.Runtime
class WizardGames.Soc.Common.Indicator.EffectIndicator : System.Object
{
	static System.Collections.Generic.Dictionary<System.Int32,System.String> EffectType2Name; // 0x0
	System.String <Measurement>k__BackingField; // 0x10
	WizardGames.Soc.Common.Indicator.IndicatorData data; // 0x18
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> effectTypeCountDic; // 0x20
	System.String get_Measurement(); // 0x06d3b3a8
	System.Void .ctor(System.String measurement); // 0x06d3b40c
	static System.Void .cctor(); // 0x06d3b6ac
}

// Client.Runtime
class WizardGames.Soc.Common.Indicator.EntityIndicator : System.Object
{
	System.String <Measurement>k__BackingField; // 0x10
	System.Int32 _total; // 0x18
	System.Int32 _addCount; // 0x1c
	System.Int32 _removeCount; // 0x20
	System.Int32[] _entityCount; // 0x28
	System.String[] _countString; // 0x30
	System.Text.StringBuilder _stringBuilder; // 0x38
	WizardGames.Soc.Common.Indicator.IndicatorData _data; // 0x40
	System.Int32 _index; // 0x48
	System.String get_Measurement(); // 0x06d3ba48
	System.Void set_Measurement(System.String value); // 0x06d3baac
	System.Void .ctor(System.String measurement); // 0x06d3bb2c
	System.Void OnEntityCreate(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06d3bd78
	System.Void OnEntityRemove(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06d3bf98
	System.Void OnEntityChange(System.Int32 entityType, System.Int32 count); // 0x06d3c1c0
}

// Client.Runtime
class WizardGames.Soc.Common.Indicator.IndicatorValue : System.Object
{
	System.String _sv; // 0x10
	WizardGames.Soc.Common.Indicator.IndicatorValue.UnionValue _uv; // 0x18
	WizardGames.Soc.Common.Indicator.IndicatorValue.EValueType _valueType; // 0x20
	System.Void SetValue(System.String value); // 0x06d3c23c
	System.Void SetValue(System.Int32 value); // 0x06d3c2e4
	System.Void SetValue(System.Single value); // 0x06d3c364
	System.Void SetValue(System.Int64 value); // 0x06d3c3e4
	System.Void PostValue(System.String catgory, System.String key); // 0x06d3c478
	System.String ToString(); // 0x06d3c588
	System.Void .ctor(); // 0x06d3c674
}

// Client.Runtime
struct WizardGames.Soc.Common.Indicator.IndicatorValue.UnionValue : System.ValueType
{
	System.Int32 I; // 0x10
	System.Single F; // 0x10
	System.Int64 L; // 0x10
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Indicator.IndicatorValue.EValueType : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Indicator.IndicatorValue.EValueType ValueString = 0;
	static WizardGames.Soc.Common.Indicator.IndicatorValue.EValueType ValueInt = 1;
	static WizardGames.Soc.Common.Indicator.IndicatorValue.EValueType ValueFloat = 2;
	static WizardGames.Soc.Common.Indicator.IndicatorValue.EValueType ValueLong = 3;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Indicator.IndicatorData : System.Object
{
	System.String <Measurement>k__BackingField; // 0x10
	System.Collections.Generic.Dictionary<System.String,System.String> <Tags>k__BackingField; // 0x18
	System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String,WizardGames.Soc.Common.Indicator.IndicatorValue>> Values; // 0x20
	static WizardGames.Soc.Common.ObjPool.ObjectPool<WizardGames.Soc.Common.Indicator.IndicatorValue> IndicatorValueStack; // 0x0
	System.String get_Measurement(); // 0x06d3c6dc
	System.Collections.Generic.Dictionary<System.String,System.String> get_Tags(); // 0x06d3c740
	System.Void .ctor(System.String measurement, System.Int32 capacity); // 0x06d3b570
	WizardGames.Soc.Common.Indicator.IndicatorData SetTag(System.String tagName, System.String tagValue); // 0x06d3c7a4
	System.Void SetValue(System.String key, System.String value); // 0x06d3c898
	System.Void SetValue(System.String key, System.Int32 value); // 0x06d3ca30
	System.Void SetValue(System.String key, System.Single value); // 0x06d3cbc8
	System.Void SetValue(System.String key, System.Int64 value); // 0x06d3cd6c
	System.Void Clear(); // 0x06d3cf04
	static System.Void .cctor(); // 0x06d3d084
}

// Client.Runtime
class WizardGames.Soc.Common.Indicator.IndicatorData.<>c : System.Object
{
	static WizardGames.Soc.Common.Indicator.IndicatorData.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x06d3d224
	System.Void .ctor(); // 0x06d3d288
	WizardGames.Soc.Common.Indicator.IndicatorValue <.cctor>b__16_0(); // 0x06d3d2f0
}

// Client.Runtime
class WizardGames.Soc.Common.Indicator.LoopFpsIndicator : System.Object
{
	System.Int32[] _lastFpsPerSource; // 0x10
	System.String[] _fpsSourceNames; // 0x18
	System.String <Measurement>k__BackingField; // 0x20
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Main.Loop.LoopFrequency,System.String> _freqNameDict; // 0x28
	WizardGames.Soc.Common.Indicator.IndicatorData data; // 0x30
	System.String get_Measurement(); // 0x06d3d378
	System.Void set_Measurement(System.String value); // 0x06d3d3dc
	System.String GetFreqName(WizardGames.Soc.Common.Main.Loop.LoopFrequency freq); // 0x06d3d45c
	System.Void .ctor(System.String measurement); // 0x06d3d5e8
	System.Void Collect(System.Collections.Generic.IList<WizardGames.Soc.Common.Indicator.IndicatorData> list, System.Boolean simple); // 0x06d3d8f4
}

// Client.Runtime
class WizardGames.Soc.Common.Indicator.PacketIndicator : System.Object
{
	System.String <Measurement>k__BackingField; // 0x10
	System.String <Target>k__BackingField; // 0x18
	WizardGames.Soc.Common.Indicator.IndicatorData data; // 0x20
	System.String get_Measurement(); // 0x06d3df14
	System.Void set_Measurement(System.String value); // 0x06d3df78
	System.Void set_Target(System.String value); // 0x06d3dff8
	System.Void .ctor(System.String measurement, System.String target); // 0x06d3e078
}

// Client.Runtime
class WizardGames.Soc.Common.Indicator.RpcIndicator : System.Object
{
	System.String <Measurement>k__BackingField; // 0x10
	System.Action<WizardGames.Soc.Common.Indicator.IndicatorData> OnNewData; // 0x18
	System.Void set_Measurement(System.String value); // 0x06d3e234
	System.Void .ctor(System.String measurement); // 0x06d3e2b4
}

// Client.Runtime
class WizardGames.Soc.Common.Indicator.TimeIndicator : System.Object
{
	System.String <Measurement>k__BackingField; // 0x10
	WizardGames.Soc.Common.Indicator.IndicatorData data; // 0x18
	System.String get_Measurement(); // 0x06d3e374
	System.Void set_Measurement(System.String value); // 0x06d3e3d8
	System.Void .ctor(System.String measurement); // 0x06d3e458
	System.Void Collect(System.Collections.Generic.IList<WizardGames.Soc.Common.Indicator.IndicatorData> list, WizardGames.Soc.Common.Synchronization.MgrTime mgrTime); // 0x06d3e5b4
}

// Client.Runtime
class WizardGames.Soc.Common.Indicator.UnityObjectPoolIndicator : System.Object
{
	System.String <Measurement>k__BackingField; // 0x10
	System.String <ObjectName>k__BackingField; // 0x18
	System.Boolean IsEnabled; // 0x20
	System.Int32 PostThresholdPoolCount; // 0x24
	WizardGames.Soc.Common.Indicator.IndicatorData[] dataList; // 0x28
	System.Int32 collectIndex; // 0x30
	System.String get_Measurement(); // 0x06d3e900
	System.Void set_Measurement(System.String value); // 0x06d3e964
	System.Void set_ObjectName(System.String value); // 0x06d3e9e4
	System.Void .ctor(System.String objectName, System.String measurement); // 0x06d3ea64
	System.Void Collect(System.Collections.Generic.List<WizardGames.Soc.Common.Indicator.IndicatorData> list); // 0x06d3ed40
}

// Client.Runtime
class WizardGames.Soc.Common.Systems.ImmediatelyEventSystemBase : System.Object, WizardGames.Soc.Common.Systems.IEventSystem, WizardGames.Soc.Common.Systems.ISystem
{
	System.Int64 subscribeId; // 0x10
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x06d3f01c
	System.Int64 RegisterListener(); // 0x054a4380
	System.Void UnregisterListener(); // 0x06d3f0a4
	System.Void OnEvent(System.Int32 hashCode, WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent baseSnapshotEvent); // 0x06d3f140
	System.Void Execute(System.Int32 hashCode, WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent baseSnapshotEvent); // 0x06d3f1b8
	System.Void OnDestroy(); // 0x06d3f234
	System.Void .ctor(); // 0x06d3f294
}

// Client.Runtime
class WizardGames.Soc.Common.Systems.ReactiveSystemBase : WizardGames.Soc.Common.Systems.BaseSystem
{
	WizardGames.Soc.Common.DataSet.CommonDataSet<Share.Common.ObjPool.Alpha3PooledObjectBase> requestEventQueue; // 0x28
	WizardGames.Soc.Common.DataSet.CommonDataSet<WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent> snapshotEventQueue; // 0x30
	System.Boolean get_handleSnapshotEvent(); // 0x054c4760
	System.Int32 get_eventQueueId(); // 0x0548ba98
	System.Int32 get_MaxProcessNumPerTick(); // 0x06d3f2fc
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x06d3f360
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x06d3f4a8
	System.Void ProcessRequest(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x06d3f848
	System.Void ExecuteEvent(Share.Common.ObjPool.Alpha3PooledObjectBase pooledObject, WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x06d3fab4
	System.Void OnDestroy(); // 0x06d3fb4c
	System.Void .ctor(); // 0x06d3fbc4
}

// Client.Runtime
class WizardGames.Soc.Common.Systems.BasePrioritySystem : WizardGames.Soc.Common.Systems.BaseSystem
{
	static System.Int32 HighPriority; // 0x0
	static System.Int32 MediumPriority; // 0x4
	static System.Int32 LowPriority; // 0x8
	static System.Int32 PriorityCount; // 0xc
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x06d635fc
	static System.Void .cctor(); // 0x06d63660
}

// Client.Runtime
class WizardGames.Soc.Common.Systems.BaseSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	SocLogger Log; // 0x10
	WizardGames.Soc.Common.Systems.SystemEntitySet activeEntities; // 0x18
	System.Int64 curEntityId; // 0x20
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x0548ba98
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x06d636b0
	System.Void OnEntityBeforeRemove(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06d63894
	System.Void OnEntityRemove(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06d63908
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x06d63adc
	System.Void OnDestroy(); // 0x06d63b6c
	System.Int64 GetEntity(); // 0x06d63f64
	System.Void OnCompStatusChanged(System.Int64 entityId, System.Int32 compId, System.Boolean isActive, System.Int32 priority); // 0x06d641bc
	System.Void .ctor(); // 0x06d644e8
}

// Client.Runtime
class WizardGames.Soc.Common.Systems.CommonCopterBehSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	SocLogger logger; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.VehicleEntity> CachedEntities; // 0x18
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x06d647f0
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x06d64854
	System.Void OnDestroy(); // 0x06d64978
	System.Void UpdateEntity(System.Int64 entity_id, WizardGames.Soc.Common.Entity.VehicleEntity test_entity); // 0x06d649d8
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x06d64b2c
	System.Void .ctor(); // 0x06d64d08
}

// Client.Runtime
enum WizardGames.Soc.Common.Systems.EConstructionPropertyFlag : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Systems.EConstructionPropertyFlag PartHp = 1;
	static WizardGames.Soc.Common.Systems.EConstructionPropertyFlag Pos = 2;
	static WizardGames.Soc.Common.Systems.EConstructionPropertyFlag Rotate = 4;
	static WizardGames.Soc.Common.Systems.EConstructionPropertyFlag PartState = 8;
	static WizardGames.Soc.Common.Systems.EConstructionPropertyFlag ModuleState = 16;
	static WizardGames.Soc.Common.Systems.EConstructionPropertyFlag LastMovedSec = 32;
	static WizardGames.Soc.Common.Systems.EConstructionPropertyFlag InitProperty = 17;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Systems.PartBasePropertyChangeSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Systems.EConstructionPropertyFlag> changeInfoDict; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Systems.EConstructionPropertyFlag> tempChangeInfoDict; // 0x18
	System.Collections.Generic.List<System.Int64> subscribeIds; // 0x20
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x06d64d70
	System.Void OnDestroy(); // 0x06d64dd4
	static System.Boolean HasFlags(WizardGames.Soc.Common.Systems.EConstructionPropertyFlag selfFlags, WizardGames.Soc.Common.Systems.EConstructionPropertyFlag flags); // 0x06d65058
	System.Void AddSubscribe<TValue>(System.Int32 propertyId, System.Action<WizardGames.Soc.Share.Framework.CustomTypeBase,TValue,TValue> cb); // 0x052af1f0
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x06d650d4
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05526948
	System.Void OnHpChange(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Single oldValue, System.Single newValue); // 0x06d65394
	System.Void OnPartStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Int32 oldValue, System.Int32 newValue); // 0x06d655cc
	System.Void OnModuleStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Int32 oldValue, System.Int32 newValue); // 0x06d65708
	System.Void OnLastMoveTimeChange(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Int32 oldValue, System.Int32 newValue); // 0x06d65844
	System.Void OnPositionChange(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Single oldValue, System.Single newValue); // 0x06d65980
	System.Void OnRotationChange(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Single oldValue, System.Single newValue); // 0x06d65c10
	System.Void AddFlagChange(System.Int64 entityId, WizardGames.Soc.Common.Systems.EConstructionPropertyFlag flag); // 0x06d65494
	System.Void OnGoCreate(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06d65d4c
	WizardGames.Soc.Common.Entity.PartEntity GetPartEntity(System.Int64 entityId); // 0x054e931c
	System.Void UpdateCommon(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x06d65e7c
	System.Void FireEventOnPartEntityTransChange(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06d666bc
	System.Void .ctor(); // 0x06d668b8
	static System.Void .cctor(); // 0x06d669f4
}

// Client.Runtime
enum WizardGames.Soc.Common.Systems.EStorageDebrisPropertyFlag : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Systems.EStorageDebrisPropertyFlag Pos = 1;
	static WizardGames.Soc.Common.Systems.EStorageDebrisPropertyFlag Rotate = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Systems.StorageDebrisBasePropertyChangeSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Systems.EStorageDebrisPropertyFlag> changeInfoDict; // 0x10
	System.Collections.Generic.List<System.Int64> subscribeIds; // 0x18
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x06d66ac8
	System.Void OnDestroy(); // 0x06d66b2c
	static System.Boolean HasFlags(WizardGames.Soc.Common.Systems.EStorageDebrisPropertyFlag selfFlags, WizardGames.Soc.Common.Systems.EStorageDebrisPropertyFlag flags); // 0x06d66ce4
	System.Void AddSubscribe<TValue>(System.Int32 propertyId, System.Action<WizardGames.Soc.Share.Framework.CustomTypeBase,TValue,TValue> cb); // 0x052af1f0
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x06d66d60
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x06d66f4c
	System.Void OnPositionChange(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Single oldValue, System.Single newValue); // 0x06d672f8
	System.Void OnRotationChange(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Single oldValue, System.Single newValue); // 0x06d675d8
	System.Void AddFlagChange(System.Int64 entityId, WizardGames.Soc.Common.Systems.EStorageDebrisPropertyFlag flag); // 0x06d67434
	System.Void UpdateCommon(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x06d66fec
	System.Void .ctor(); // 0x06d67714
	static System.Void .cctor(); // 0x06d67820
}

// Client.Runtime
class WizardGames.Soc.Common.Systems.EntityRemoveSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x06d678f4
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x06d67958
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x06d679cc
	System.Void OnDestroy(); // 0x06d67c28
	System.Void .ctor(); // 0x06d67c88
	static System.Void .cctor(); // 0x06d67cf0
}

// Client.Runtime
class WizardGames.Soc.Common.Systems.GpuInstSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static System.Collections.Generic.HashSet<WizardGames.Soc.Common.Component.GpuInstComponent> activeComps; // 0x0
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x06d67dc4
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x06d67e28
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x06d67e9c
	System.Void OnDestroy(); // 0x06d68144
	System.Void .ctor(); // 0x06d681a4
	static System.Void .cctor(); // 0x06d6820c
}

// Client.Runtime
class WizardGames.Soc.Common.Systems.PhysicsMoveSystem : WizardGames.Soc.Common.Systems.BaseSystem
{
	static SocLogger logger; // 0x0
	static System.Boolean DebugShowCollider; // 0x8
	System.Collections.Generic.LinkedList<WizardGames.Soc.Common.Component.PhysicsMoveComponent> componentList; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.Common.Component.PhysicsMoveComponent> waitRemoveList; // 0x30
	System.Int32 attachIdleTimer; // 0x38
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x06d682a4
	System.Void AddComponent(WizardGames.Soc.Common.Component.PhysicsMoveComponent physicsMoveComponent); // 0x06d68308
	System.Void RemoveComponent(WizardGames.Soc.Common.Component.PhysicsMoveComponent physicsMoveComponent, System.Boolean delayRemove); // 0x06d683e0
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x06d68550
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x06d685c4
	System.Void OnDestroy(); // 0x06d68a64
	System.Void .ctor(); // 0x06d68ac4
	static System.Void .cctor(); // 0x06d68bd0
}

// Client.Runtime
class WizardGames.Soc.Common.Systems.PlayerStateSystem : WizardGames.Soc.Common.Systems.BaseSystem
{
	WizardGames.Soc.Common.Contexts.Context context; // 0x28
	System.Collections.Generic.List<System.Int64> delFlagIds; // 0x30
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x06d68cb4
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x06d68d18
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05526948
	System.Void OnDestroy(); // 0x06d693ac
	System.Void .ctor(); // 0x06d69410
}

// Client.Runtime
class WizardGames.Soc.Common.Systems.ProjectileSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.Ability.IProjectile> projectiles; // 0x10
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x06d694c0
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x06d69524
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x06d695f4
	System.Void OnDestroy(); // 0x06d69cc0
	System.Void ProjectileLifeCheck(WizardGames.Soc.Common.Contexts.Context context, System.Int64 entityId, WizardGames.Soc.Common.Entity.Ability.IProjectile projectile, System.Int32 deltaTime, System.Int64 serverTime); // 0x06d69850
	System.Void .ctor(); // 0x06d69d20
}

// Client.Runtime
class WizardGames.Soc.Common.Systems.NodeWrapper<T> : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	System.Collections.Generic.LinkedListNode<T> Node; // 0x0
	System.Collections.Generic.HashSet<System.Int64> CompSet; // 0x0
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Systems.SystemEntitySet : System.Object
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Systems.NodeWrapper<System.Int64>> entityMap; // 0x10
	System.Collections.Generic.LinkedList<System.Int64> entities; // 0x18
	System.Collections.Generic.LinkedListNode<System.Int64> startCursor; // 0x20
	System.Collections.Generic.LinkedListNode<System.Int64> currentCursor; // 0x28
	System.Collections.Generic.HashSet<System.Int64> tmpAddEntity; // 0x30
	System.Collections.Generic.HashSet<System.Int64> tmpRemoveEntity; // 0x38
	System.Single maxFrameUpdateTimeMs; // 0x40
	System.Int64 lastTickTimeMs; // 0x48
	System.Diagnostics.Stopwatch stopwatch; // 0x50
	System.Int64 lastFrameCount; // 0x58
	System.Boolean hasFinCycle; // 0x60
	System.Int32 entCounter; // 0x64
	System.Single additionalCost; // 0x68
	System.Single remainingCost; // 0x6c
	System.Boolean enableDynamicFrame; // 0x70
	System.Int64 dynamicFrameIntervalMs; // 0x78
	System.Single get_SummaryFrameUpdateTimeMs(); // 0x06d69d88
	System.Int32 get_invalidId(); // 0x06d69df4
	System.Int64 GetEntity(); // 0x06d63fd8
	System.Void Clear(); // 0x06d63cb4
	System.Void AddEntityComponent(System.Int64 entityId, System.Int64 compId); // 0x06d6428c
	System.Void RemoveEntityComponent(System.Int64 entityId, System.Int64 compId); // 0x06d64390
	System.Void ForceRemoveEntity(System.Int64 entityId, System.Boolean keepWrapper); // 0x06d63a08
	System.Void AddEntity(System.Int64 entityId, System.Int64 compId); // 0x06d6a2c0
	System.Void RemoveEntity(System.Int64 entityId, WizardGames.Soc.Common.Systems.NodeWrapper<System.Int64> nodeWrapper, System.Boolean keepWrapper); // 0x06d6a4a4
	System.Collections.Generic.LinkedListNode<System.Int64> GetNextNode(System.Collections.Generic.LinkedListNode<System.Int64> node); // 0x06d6a15c
	System.Collections.Generic.LinkedListNode<System.Int64> GetPreNode(System.Collections.Generic.LinkedListNode<System.Int64> node); // 0x06d6a7b8
	System.Collections.Generic.LinkedListNode<System.Int64> GetPreDifferentNode(System.Collections.Generic.LinkedListNode<System.Int64> node); // 0x06d6a660
	System.Collections.Generic.LinkedListNode<System.Int64> GetNextDifferentNode(System.Collections.Generic.LinkedListNode<System.Int64> node); // 0x06d6a70c
	System.Boolean CheckFrameChanged(System.Int64 frame); // 0x06d69fd8
	System.Boolean CheckTimeLimitExceeded(); // 0x06d69e6c
	System.Boolean CheckFinishedCycle(System.Int64 frameCount); // 0x06d6a0c0
	System.Void UpdateFrameData(System.Int64 frameCount); // 0x06d6a238
	System.Void .ctor(); // 0x06d64628
	static System.Void .cctor(); // 0x06d6a8a8
}

// Client.Runtime
class WizardGames.Soc.Common.Systems.TargetMoveSystem : WizardGames.Soc.Common.Systems.BaseSystem
{
	static SocLogger <Logger>k__BackingField; // 0x0
	static System.Collections.Generic.List<WizardGames.Soc.SocSimulator.TargetMoveComp> targetMoveComps; // 0x8
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x06d6a97c
	static System.Void .cctor(); // 0x06d6a9e0
}

// Client.Runtime
class WizardGames.Soc.Common.Systems.ViewKickBaseSystem : System.Object
{
	static SocLogger logger; // 0x0
	System.Single clearRecoilPitch; // 0x10
	System.Single yawAngularSpeedThreshold; // 0x14
	System.Single pitchRecoilReductionPercent; // 0x18
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x06d6ab0c
	UnityEngine.Vector2 CalViewKickValue(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd userCmd, WizardGames.Soc.Common.SimpleCustom.UserCmd lastCmd, WizardGames.Soc.Common.CustomType.WeaponCustom weaponEntity, System.Int64 clientTime, System.Int32 deltaTime); // 0x06d6aca8
	System.Void .ctor(); // 0x06d6b1b0
	static System.Void .cctor(); // 0x06d6b224
}

// Client.Runtime
class WizardGames.Soc.Common.Systems.SystemGroup<T> : System.Object
{
	System.Collections.Generic.List<T> <Systems>k__BackingField; // 0x0
	System.Collections.Generic.List<T> get_Systems(); // 0x054e7844
	System.Void .ctor(); // 0x055049cc
	System.Void Add(T system); // 0x052af1f0
	System.Void Clear(); // 0x055049cc
}

// Client.Runtime
interface WizardGames.Soc.Common.Systems.ISystem : 
{
	
	System.Void OnDestroy(); // 0x055049cc
}

// Client.Runtime
interface WizardGames.Soc.Common.Systems.IBaseSystem : , WizardGames.Soc.Common.Systems.ISystem
{
	
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05523a54
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05526948
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x0548ba98
}

// Client.Runtime
interface WizardGames.Soc.Common.Systems.IEventSystem : , WizardGames.Soc.Common.Systems.ISystem
{
	
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05523a54
}

// Client.Runtime
interface WizardGames.Soc.Common.Systems.ISystemInitHandler : 
{
	
	System.Void Init(); // 0x055049cc
}

// Client.Runtime
interface WizardGames.Soc.Common.Systems.IUserCmdSystem : , WizardGames.Soc.Common.Systems.ISystem
{
	
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05523a54
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x0552e1cc
}

// Client.Runtime
class WizardGames.Soc.Common.Systems.MgrSystem : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Systems.SystemGroup<WizardGames.Soc.Common.Systems.IBaseSystem> FirstUnlimitedSystemGroup; // 0x18
	WizardGames.Soc.Common.Systems.SystemGroup<WizardGames.Soc.Common.Systems.IUserCmdSystem> PreUserCmdSystemGroup; // 0x20
	WizardGames.Soc.Common.Systems.SystemGroup<WizardGames.Soc.Common.Systems.IUserCmdSystem> UserCmdSystemGroup; // 0x28
	WizardGames.Soc.Common.Systems.SystemGroup<WizardGames.Soc.Common.Systems.IUserCmdSystem> UserCmdSystemGroupInThread; // 0x30
	WizardGames.Soc.Common.Systems.SystemGroup<WizardGames.Soc.Common.Systems.IUserCmdSystem> RenderUserCmdSystemGroup; // 0x38
	WizardGames.Soc.Common.Systems.SystemGroup<WizardGames.Soc.Common.Systems.IUserCmdSystem> PostUserCmdSystemGroup; // 0x40
	WizardGames.Soc.Common.Systems.SystemGroup<WizardGames.Soc.Common.Systems.IUserCmdSystem> OfflinePlayerSystemGroup; // 0x48
	WizardGames.Soc.Common.Systems.SystemGroup<WizardGames.Soc.Common.Systems.IUserCmdSystem> LateUpdateUserCmdSystemGroup; // 0x50
	WizardGames.Soc.Common.Systems.SystemGroup<WizardGames.Soc.Common.Systems.IBaseSystem> BaseSystemGroup; // 0x58
	WizardGames.Soc.Common.Systems.SystemGroup<WizardGames.Soc.Common.Systems.IBaseSystem> AiSystemGroup; // 0x60
	WizardGames.Soc.Common.Systems.SystemGroup<WizardGames.Soc.Common.Systems.IBaseSystem> AllAuxSystemGroup; // 0x68
	WizardGames.Soc.Common.Systems.SystemGroup<WizardGames.Soc.Common.Systems.IBaseSystem> BeforeCameraRenderSystemGroup; // 0x70
	WizardGames.Soc.Common.Systems.SystemGroup<WizardGames.Soc.Common.Systems.IBaseSystem> RenderSystemGroup; // 0x78
	WizardGames.Soc.Common.Systems.SystemGroup<WizardGames.Soc.Common.Systems.IBaseSystem> BeforeAnimBeginSystemGroup; // 0x80
	WizardGames.Soc.Common.Systems.SystemGroup<WizardGames.Soc.Common.Systems.IBaseSystem> AfterAnimBeginSystemGroup; // 0x88
	WizardGames.Soc.Common.Systems.SystemGroup<WizardGames.Soc.Common.Systems.IBaseSystem> LateUpdateSystemGroup; // 0x90
	WizardGames.Soc.Common.Systems.SystemGroup<WizardGames.Soc.Common.Systems.IBaseSystem> AfterLoopGroup; // 0x98
	WizardGames.Soc.Common.Systems.SystemGroup<WizardGames.Soc.Common.Systems.IBaseSystem> Update10FPSSystemGroup; // 0xa0
	WizardGames.Soc.Common.Systems.SystemGroup<WizardGames.Soc.Common.Systems.IBaseSystem> Update1FPSSystemGroup; // 0xa8
	WizardGames.Soc.Common.Systems.SystemGroup<WizardGames.Soc.Common.Systems.IBaseSystem> FixedSystemGroup; // 0xb0
	WizardGames.Soc.Common.Systems.SystemGroup<WizardGames.Soc.Common.Systems.IEventSystem> EventSystemGroup; // 0xb8
	WizardGames.Soc.Common.Contexts.Context Context; // 0xc0
	WizardGames.Soc.Common.Utility.Counter OnlineUpdateTimer; // 0xc8
	WizardGames.Soc.Common.Utility.Counter OfflineUpdateTimer; // 0xd0
	WizardGames.Soc.Common.Utility.Counter singleSystemTimer; // 0xd8
	System.Collections.Generic.Queue<WizardGames.Soc.Common.SimpleCustom.UserCmd> <offlineCmds>k__BackingField; // 0xe0
	WizardGames.Soc.Common.SimpleCustom.UserCmd cacheCmd; // 0xe8
	System.Diagnostics.Stopwatch stopwatch; // 0xf0
	System.Void Init(); // 0x06d6b2f8
	System.Threading.Tasks.Task OnExitWorld(); // 0x06d6b360
	System.Void InitSystem(WizardGames.Soc.Common.Systems.ISystemInitHandler handler); // 0x06d6b5e8
	System.Void ClearSystems(); // 0x06d6b3f8
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x06d6b8a0
	System.Void OnDestroy(); // 0x06d6b6cc
	System.Void OnCreateInternal(WizardGames.Soc.Common.Systems.SystemGroup<WizardGames.Soc.Common.Systems.IBaseSystem> ss, WizardGames.Soc.Common.Contexts.Context context); // 0x06d6ba50
	System.Void OnCreateInternal(WizardGames.Soc.Common.Systems.SystemGroup<WizardGames.Soc.Common.Systems.IUserCmdSystem> ss, WizardGames.Soc.Common.Contexts.Context context); // 0x06d6bd9c
	System.Void OnCreateInternal(WizardGames.Soc.Common.Systems.SystemGroup<WizardGames.Soc.Common.Systems.IEventSystem> ss, WizardGames.Soc.Common.Contexts.Context context); // 0x06d6c0e8
	System.Void OnDestroyInternal<T>(WizardGames.Soc.Common.Systems.SystemGroup<T> ss); // 0x052af1f0
	System.Void OnFirstGroupUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld, System.Boolean isServer); // 0x06d6c434
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld, System.Boolean isServer); // 0x06d6cc98
	System.Void OnFps10Update(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld, System.Boolean isServer); // 0x06d6cd5c
	System.Void OfflineSystemUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x06d6ce38
	System.Void OnBeforeCameraRenderUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x06d6d2f0
	System.Void OnRenderUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x06d6d3ac
	System.Void OnLateUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x06d6d468
	System.Void OnAfterAnimBegin(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x06d6d524
	System.Void OnBeforeAnimBegin(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x06d6d5e0
	System.Void OnCmdLateUpdate(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity entity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x06d6d69c
	System.Void OnAfterLoopUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x06d6d8f4
	System.Void OnFixedUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x06d6d9b0
	System.Void OnlineSystemUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld, WizardGames.Soc.Common.Systems.SystemGroup<WizardGames.Soc.Common.Systems.IBaseSystem> systemGroup, System.String title); // 0x06d6c4f8
	T GetBaseSystem<T>(); // 0x052af1f0
	T GetBaseSystem<T>(WizardGames.Soc.Common.Systems.SystemGroup<WizardGames.Soc.Common.Systems.IBaseSystem> systemGroup); // 0x052af1f0
	System.Void .ctor(); // 0x06d6da6c
	static System.Void .cctor(); // 0x06d6dfc0
}

// Client.Runtime
class WizardGames.Soc.Common.Event.PartEntityRotationChangeEvent : System.Object
{
	static WizardGames.Soc.Common.Event.PartEntityRotationChangeEvent Instance; // 0x0
	System.Void .ctor(); // 0x06d6e094
	static System.Void .cctor(); // 0x06d6e0fc
}

// Client.Runtime
class WizardGames.Soc.Common.Event.TrySwitchAbility : WizardGames.Soc.Share.Framework.Event.ComponentAbilityBase<System.Boolean,System.Boolean>
{
	
	System.Void .ctor(System.Boolean input); // 0x06d6e160
}

// Client.Runtime
class WizardGames.Soc.Common.Event.SwitchChangeEvent : System.Object
{
	System.Boolean SwitchOpened; // 0x10
	System.Int64 PublisherId; // 0x18
	System.Boolean FlagChange; // 0x20
	System.Void .ctor(); // 0x06d6e1f4
}

// Client.Runtime
class WizardGames.Soc.Common.Soc.Common.Src.Electric.ElectricModuleTemplateMapper : System.Object
{
	static System.Collections.Generic.Dictionary<System.Int64,System.Int32> electricTemplateModuleMapper; // 0x0
	static System.Int32 GetPartModuleId(System.Int64 partTemplateId); // 0x06d6e25c
	static System.Void .cctor(); // 0x06d6e334
}

// Client.Runtime
interface WizardGames.Soc.Common.Soc.Common.Src.Entity.Interface.IBuffEntity : 
{
	
	
}

// Client.Runtime
class WizardGames.Soc.Common.DebugGroup.DebugParameter : System.Object
{
	System.Boolean LagCompensationToggle; // 0x10
	System.Numerics.Vector3 TemperatureTrigger; // 0x14
	System.Boolean DamageDebugOpen; // 0x20
	System.Boolean RadiationDisplayOpen; // 0x21
	System.Boolean BulletHitTrustClient; // 0x22
	System.Void .ctor(); // 0x06d6e510
}

// Client.Runtime
interface WizardGames.Soc.Common.DebugGroup.DebugLog.ILogger : 
{
	
	System.Void LogError(System.Object message); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.Common.DebugGroup.DebugLog.DebugLog : System.Object
{
	static WizardGames.Soc.Common.DebugGroup.DebugLog.ILogger _logger; // 0x0
	static System.Void LogError(System.Object message); // 0x06d6e598
}

// Client.Runtime
class WizardGames.Soc.Common.DataSet.CommonDelegate<T,U> : System.Object
{
	
	
}

// Client.Runtime
class WizardGames.Soc.Common.DataSet.CommonDelegate.EventDelegate<T,U> : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05525a60
	System.Void Invoke(T t, U& u); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Common.DataSet.CommonDelegate.EventDelegate2<T,U> : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05525a60
	System.Void Invoke(T t, U u); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Common.DataSet.CommonDelegate<T,U,K> : System.Object
{
	
	
}

// Client.Runtime
class WizardGames.Soc.Common.DataSet.CommonDelegate.EventDelegate<T,U,K> : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05525a60
	System.Void Invoke(T t, U& u, K& k); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Common.DataSet.CommonDataSet<T> : System.Object
{
	static SocLogger logger; // 0x0
	System.Boolean MultiThreadMode; // 0x0
	System.Action<T> OnEnqueue; // 0x0
	System.Collections.Generic.Queue<T> queue; // 0x0
	System.Collections.Concurrent.ConcurrentQueue<T> conQueue; // 0x0
	System.Boolean HasData(); // 0x054c4760
	System.Void Enqueue(T& request); // 0x05523a54
	T Dequeue(); // 0x052af1f0
	System.Void Clear(); // 0x055049cc
	System.Collections.Generic.Queue.Enumerator<T> GetEnumerator(); // 0x052af1f0
	System.Void .ctor(); // 0x055049cc
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
struct WizardGames.Soc.Common.Weapon.MagPhysicsData : System.ValueType
{
	System.Boolean Valid; // 0x10
	System.String MagPrefabPath; // 0x18
	System.String ExMagPrefabPath; // 0x20
	WizardGames.Soc.Common.Data.Display.MagDisplay MagDisplay; // 0x28
	UnityEngine.Transform MagSocket; // 0x30
	
}

// Client.Runtime
class WizardGames.Soc.Common.Weapon.TargetingLauncherData : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.Defines.TableItemEnum LauncherType; // 0x10
	WizardGames.Soc.Common.Entity.PlayerEntity myPlayerEntity; // 0x18
	System.Collections.Generic.List<System.Int64> targetEntityTypes; // 0x20
	System.Single minTargetDis; // 0x28
	System.Single maxTargetDis; // 0x2c
	System.Single maxLockingDot; // 0x30
	System.Single plusTokenPerSecond; // 0x34
	System.Single minusTokenPerSecond; // 0x38
	CommonUnity.Runtime.Entity.ISeekerTarget lockedEntity; // 0x40
	System.Single lockedTokenThreshold; // 0x48
	System.Int64 lockedTime; // 0x50
	System.Int64 leftLockedTime; // 0x58
	System.Collections.Generic.Dictionary<System.Int64,System.Single> seekingTargetTokens; // 0x60
	System.Collections.Generic.List<System.Int64> seekingTargetIds; // 0x68
	CommonUnity.Runtime.Entity.ISeekerTarget currentLockingEntity; // 0x70
	CommonUnity.Runtime.Entity.ISeekerTarget preLockingEntity; // 0x78
	CommonUnity.Runtime.Entity.ISeekerTarget preLockedEntity; // 0x80
	System.Collections.Generic.List<System.Int64> removedTargetTokens; // 0x88
	UnityEngine.RaycastHit[] hits; // 0x90
	System.Collections.Generic.List<UnityEngine.RaycastHit> tmpHits; // 0x98
	System.Collections.Generic.List<WizardGames.Soc.Common.Combat.SocRaycastHit> tmpSocHits; // 0xa0
	System.Boolean hitScreenBox; // 0xa8
	System.Collections.Generic.Dictionary<System.Int64,CommonUnity.Runtime.Entity.ISeekerTarget> seekerTargets; // 0xb0
	System.Boolean TargetIsGanRaoDanUsing(); // 0x06d6e694
	System.Void .ctor(WizardGames.Soc.Common.CustomType.WeaponCustom weapon, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06d6e908
	System.Boolean CheckPlayerIsLocking(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06d6ed7c
	System.Boolean CheckCurrentWeaponIsHolding(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x06d6ee28
	System.Void Update(System.Int32 deltaTime); // 0x06d6ef50
	System.Void UpdateCurrentLockingEntity(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, System.Int64& currentLockingEntityId, System.Collections.Generic.List<System.Int64>& currentLockableEntityIds); // 0x06d6fe14
	System.Boolean CheckIsLockable(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, CommonUnity.Runtime.Entity.ISeekerTarget target); // 0x06d71014
	System.Void UpdateCurrentLockableEntity(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, System.Collections.Generic.List<System.Int64>& currentLockableEntityIds); // 0x06d70398
	System.Void CheckAndUpdateLockedTarget(System.Int32 deltaTime); // 0x055056e8
	System.Void UpdateCurrentLockingEntityToken(System.Int32 deltaTime); // 0x055056e8
	System.Void TokenDepletion(System.Int32 deltaTime); // 0x06d6fa7c
	System.Void DebugDrawTokenProgress(CommonUnity.Runtime.Entity.ISeekerTarget target); // 0x06d71e1c
	System.Void RemoveInvalidSeekingTarget(); // 0x06d6eff4
	System.Void RemoveTargets(); // 0x06d6f2d4
	System.Boolean CheckIsInLockArea(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, CommonUnity.Runtime.Entity.ISeekerTarget target, System.Single& dotFromCenter, System.Int64 renderTime); // 0x06d7076c
	System.Boolean CheckIfIsBlocked(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, CommonUnity.Runtime.Entity.ISeekerTarget target, System.Int64 renderTime); // 0x06d71490
	UnityEngine.Vector3 YawPitch2Dir(UnityEngine.Vector2 yawPitch); // 0x06d713d0
	System.Void DebugDrawLockingRange(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06d70038
	CommonUnity.Runtime.Entity.ISeekerTarget SeekingTarget(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, System.Collections.Generic.List<System.Int64>& currentLockableEntityIds); // 0x06d70b58
	System.Void ClearToken(); // 0x06d71f3c
	System.Void ResetCurrentLockingEntity(CommonUnity.Runtime.Entity.ISeekerTarget target); // 0x06d71ff0
	System.Void ResetLockedEntity(); // 0x055049cc
	System.Void SyncServerTargetToken(WizardGames.Soc.Common.Entity.PlayerEntity serverEntity); // 0x06d72084
	System.Boolean CompareHistory(WizardGames.Soc.Common.Entity.PlayerEntity serverEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd ackCmd); // 0x06d722c0
	System.Void RoolBack(WizardGames.Soc.Common.Entity.PlayerEntity serverEntity); // 0x05523a54
	System.Boolean GetSeekerTargetToken(System.Int64 entityId, System.Single& token, System.Single& progress); // 0x06d7265c
	System.Boolean IsLocked(System.Int64& entityId); // 0x06d72754
	static System.Boolean IsTargetingLauncher(WizardGames.Soc.Common.CustomType.WeaponCustom weapon); // 0x06d72858
	static System.Boolean IsPlayerIsLocking(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.CustomType.WeaponCustom weapon); // 0x06d728d4
	static System.Void .cctor(); // 0x06d729c8
}

// Client.Runtime
class WizardGames.Soc.Common.Weapon.WeaponPostData : System.Object, WizardGames.Soc.Common.Weapon.IWeaponData
{
	System.Collections.Generic.Queue<System.Single> ViewKickPunchPitch; // 0x10
	System.Collections.Generic.Queue<System.Single> ViewKickPunchYaw; // 0x18
	System.Collections.Generic.Queue<System.Boolean> SaveClipQueue; // 0x20
	System.Collections.Generic.Dictionary<System.Int64,System.Boolean> FireKeepDic; // 0x28
	System.Collections.Generic.Queue<WizardGames.Soc.Common.Entity.ThrownEntity> ThrownEntities; // 0x30
	System.Void .ctor(); // 0x06d72a9c
}

// Client.Runtime
class WizardGames.Soc.Common.Weapon.WeaponPreData : System.Object, WizardGames.Soc.Common.Weapon.IWeaponData
{
	UnityEngine.GameObject EquipFpWeapon; // 0x10
	UnityEngine.GameObject EquipTpWeapon; // 0x18
	System.Void .ctor(); // 0x06d72c98
}

// Client.Runtime
class WizardGames.Soc.Common.Weapon.AutoMatchPrefabTransformInLb : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	UnityEngine.GameObject SourcePrefab; // 0x30
	System.Void OnEnable(); // 0x06d72d00
	System.Void MatchTransform(UnityEngine.Transform self, UnityEngine.Transform other, System.Int32& time); // 0x06d72e6c
	System.Void .ctor(); // 0x06d73638
	static System.Void .cctor(); // 0x06d736a0
}

// Client.Runtime
enum WizardGames.Soc.Common.Weapon.EHeldItem : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Weapon.EHeldItem Invalid = -1;
	static WizardGames.Soc.Common.Weapon.EHeldItem EmptyHand = 0;
	static WizardGames.Soc.Common.Weapon.EHeldItem AK47 = 1;
	static WizardGames.Soc.Common.Weapon.EHeldItem MP5 = 2;
	static WizardGames.Soc.Common.Weapon.EHeldItem Hammer = 3;
	static WizardGames.Soc.Common.Weapon.EHeldItem PickAxe = 4;
	static WizardGames.Soc.Common.Weapon.EHeldItem HealthNeedle = 5;
	static WizardGames.Soc.Common.Weapon.EHeldItem ArchitecturalDrawing = 6;
	static WizardGames.Soc.Common.Weapon.EHeldItem AK47_2 = 7;
	static WizardGames.Soc.Common.Weapon.EHeldItem Torcher = 8;
	static WizardGames.Soc.Common.Weapon.EHeldItem Bow = 9;
	static WizardGames.Soc.Common.Weapon.EHeldItem RocketLauncher = 10;
	static WizardGames.Soc.Common.Weapon.EHeldItem DoubleBarreledShotgun = 11;
	static WizardGames.Soc.Common.Weapon.EHeldItem L96 = 12;
	static WizardGames.Soc.Common.Weapon.EHeldItem Grenade = 13;
	static WizardGames.Soc.Common.Weapon.EHeldItem MolotovCocktail = 14;
	static WizardGames.Soc.Common.Weapon.EHeldItem C4 = 15;
	static WizardGames.Soc.Common.Weapon.EHeldItem CallAirdrop = 16;
	static WizardGames.Soc.Common.Weapon.EHeldItem CrossBow = 17;
	static WizardGames.Soc.Common.Weapon.EHeldItem Hmlmg = 17;
	static WizardGames.Soc.Common.Weapon.EHeldItem Pistol = 18;
	static WizardGames.Soc.Common.Weapon.EHeldItem CommonRifle = 19;
	static WizardGames.Soc.Common.Weapon.EHeldItem CommonMelee = 20;
	static WizardGames.Soc.Common.Weapon.EHeldItem CommonItem = 21;
	static WizardGames.Soc.Common.Weapon.EHeldItem End = 22;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Weapon.ERunServerType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Weapon.ERunServerType None = 0;
	static WizardGames.Soc.Common.Weapon.ERunServerType Client = 1;
	static WizardGames.Soc.Common.Weapon.ERunServerType Simulator = 2;
	static WizardGames.Soc.Common.Weapon.ERunServerType Both = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Weapon.ERunFrameType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Weapon.ERunFrameType None = 0;
	static WizardGames.Soc.Common.Weapon.ERunFrameType Logic = 1;
	static WizardGames.Soc.Common.Weapon.ERunFrameType Render = 2;
	static WizardGames.Soc.Common.Weapon.ERunFrameType Late = 4;
	static WizardGames.Soc.Common.Weapon.ERunFrameType Both = 7;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Weapon.ShowEquipPos : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Weapon.ShowEquipPos Hand = 0;
	static WizardGames.Soc.Common.Weapon.ShowEquipPos BackLeft = 1;
	static WizardGames.Soc.Common.Weapon.ShowEquipPos BackRight = 2;
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Weapon.WeaponAccessoryVisitor : System.ValueType, System.Collections.Generic.IEnumerable<WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom>, System.Collections.IEnumerable
{
	WizardGames.Soc.Common.CustomType.WeaponCustom weaponCustom; // 0x10
	System.Void .ctor(WizardGames.Soc.Common.CustomType.WeaponCustom weaponCustom); // 0x06d73774
	System.Collections.Generic.IEnumerator<WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom> GetEnumerator(); // 0x06d737f4
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x06d73920
}

// Client.Runtime
class WizardGames.Soc.Common.Weapon.WeaponAccessoryVisitor.WeaponAccessoryEnumerator : System.Object, System.Collections.Generic.IEnumerator<WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 idx; // 0x10
	WizardGames.Soc.Common.CustomType.WeaponCustom weaponCustom; // 0x18
	WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom get_Current(); // 0x06d73984
	System.Object System.Collections.IEnumerator.get_Current(); // 0x06d73a74
	System.Void Dispose(); // 0x06d73ad8
	System.Boolean MoveNext(); // 0x06d73b90
	System.Void Reset(); // 0x06d738b8
	System.Void .ctor(); // 0x06d73c34
}

// Client.Runtime
class WizardGames.Soc.Common.Weapon.HeldItemUtility : System.Object
{
	static System.Collections.Generic.List<WizardGames.Soc.Common.Entity.IItemEntity> all_items; // 0x0
	static SocLogger logger; // 0x8
	static System.Func<WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom,System.Boolean> ScopeSelector; // 0x10
	static WizardGames.Soc.Common.Const.EHeldSocketType GetSocketType(System.Int32 HeldSocketType, WizardGames.Soc.Common.Weapon.ShowEquipPos equipPos); // 0x06d73c9c
	static WizardGames.Soc.Common.Const.EHeldSocketTypeInHorse GetSocketTypeInHorse(System.Int32 heldSocketType); // 0x06d73d50
	static System.Boolean IsBaseWeaponLocator(WizardGames.Soc.Common.Const.EHeldSocketType SocketType); // 0x06d73dbc
	static System.Boolean IsLeftWeaponLocator(WizardGames.Soc.Common.Const.EHeldSocketType SocketType); // 0x06d73e28
	static System.Boolean IsRightWeaponLocator(WizardGames.Soc.Common.Const.EHeldSocketType SocketType); // 0x06d73e90
	static System.Boolean IsRightWeaponNoLeftHandLocator(WizardGames.Soc.Common.Const.EHeldSocketType SocketType); // 0x06d73ef8
	static System.Boolean IsLeftWeaponNoRightHandLocator(WizardGames.Soc.Common.Const.EHeldSocketType SocketType); // 0x06d73f60
	static System.Void GetWeaponHandSocketName(System.Int64 tableId, WizardGames.Soc.Common.Const.EHeldSocketType SocketType, System.String& WeaponHandName, System.String& WeaponLocName, System.Boolean isNewProcess); // 0x06d73fc8
	static System.Boolean FindAdsOffsetData(System.Int64 weaponTableId, System.Int64 accessoryTableId, WizardGames.Soc.Common.Data.gun.GunOffset& tb); // 0x06d7438c
	static System.Boolean FindWeaponFovData(System.Int64 weaponTableId, System.Int64 accessoryTableId, WizardGames.Soc.Common.Data.gun.GunFov& tb); // 0x06d745e0
	static System.Boolean FindWeaponRecoilData(System.Int64 weaponTableId, System.Int64 accessoryTableId, WizardGames.Soc.Common.Data.gun.GunRecoil& tb); // 0x06d74834
	static System.Boolean FindWeaponBreatheViewData(System.Int64 weaponTableId, System.Int64 accessoryTableId, WizardGames.Soc.Common.Data.gun.Gunsway& tb); // 0x06d74a88
	static System.Boolean FindWeaponMoveSwayData(System.Int64 weaponTableId, System.Int64 accessoryTableId, WizardGames.Soc.Common.Data.gun.GunMovesway& tb); // 0x06d74cdc
	static System.Boolean TryGetAccessoryAsset(WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom accessory, System.Int64 weaponTableId, WizardGames.Soc.Common.Data.part.PartAsset& PartAsset); // 0x06d74f30
	static System.Boolean TryGetAccessoryAsset(System.Int64 tableId, System.Int64 SkinId, System.Int64 weaponTableId, WizardGames.Soc.Common.Data.part.PartAsset& PartAsset); // 0x06d7500c
	static System.Boolean TryGetAccessoryDisplay(System.Int64 tableId, System.Int64 SkinId, WizardGames.Soc.Common.Data.Display.PartDisplay& dis); // 0x06d753c4
	static WizardGames.Soc.Common.Weapon.WeaponAccessoryVisitor EnumWeaponAccessoryId(WizardGames.Soc.Common.CustomType.WeaponCustom weapon); // 0x06d75528
	static System.Boolean SelectWeaponAccessory(WizardGames.Soc.Common.CustomType.WeaponCustom weapon, System.Func<WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom,System.Boolean> selector, WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom& entity); // 0x06d755f0
	static System.Collections.Generic.IEnumerable<WizardGames.Soc.Common.Entity.IItemEntity> EnumPlayerShotCutItem(WizardGames.Soc.Common.Entity.IShortcutEntity entity); // 0x06d758fc
	static System.Boolean Breakable<T>(T entity); // 0x052af1f0
	static System.Boolean Broken<T>(T entity); // 0x052af1f0
	static System.Void UpdateCurrentWeapon(WizardGames.Soc.Common.Entity.PlayerEntity player); // 0x06d75c3c
	static System.Void UpdateWeaponAccessoryCorrection(WizardGames.Soc.Common.CustomType.WeaponCustom weapon); // 0x06d75d3c
	static System.Int32 ExtraMagazineAmmo(System.Int32 baseCapacity, System.Int32 correction); // 0x06d76ca0
	static System.Boolean IsNewWeapon(System.Int64 weaponTableId); // 0x06d76d60
	static System.Boolean GetMantleList(System.Int64 itemId, System.Int64 skinId, System.Int32[]& array); // 0x06d77008
	static System.Boolean GetInspectionSound(WizardGames.Soc.Common.Entity.IHeldItemEntity heldItem, System.String& inspectionSound); // 0x06d77328
	static System.Boolean GetPrefabPath(System.Int64 itemId, System.Int64 skinId, WizardGames.Soc.SocClient.GoLoader.ModelType modelType, System.String& path); // 0x06d77680
	static System.Boolean GetMetaPath(System.Int64 itemId, System.Int64 skinId, System.Boolean isFp, WizardGames.Soc.Common.Entity.PlayerCharacterTypeEnum characterType, System.String& path); // 0x06d77b8c
	static System.Boolean GetPrefabPath(WizardGames.Soc.Common.Weapon.EquipType et, System.Int64 apperanceId, WizardGames.Soc.SocClient.GoLoader.ModelType modelType, System.String& path); // 0x06d77784
	static System.Boolean GetPrefabPath(System.Int64 itemId, System.Int64 skinId, System.String& fp, System.String& tp); // 0x06d77f20
	static System.Boolean GetPrefabPath(WizardGames.Soc.Common.Weapon.EquipType et, System.Int64 apperanceId, System.String& fp, System.String& tp); // 0x06d78024
	static WizardGames.Soc.Common.Weapon.EquipType GetEquipType(System.Int64 itemId); // 0x06d772a0
	static System.Boolean GetDropModelPath(System.Int64 itemId, System.Int64 skinId, System.String& path, System.Boolean useClothBagModel); // 0x06d78648
	static System.Boolean TryGetWeaponDisplay(System.Int64 itemId, System.Int64 skinId, WizardGames.Soc.Common.Data.Display.WeaponDisplay& tb); // 0x06d789c4
	static System.Boolean TryGetWeaponDisplay(WizardGames.Soc.Common.CustomType.WeaponCustom weapon, WizardGames.Soc.Common.Data.Display.WeaponDisplay& tb); // 0x06d78b28
	static System.Boolean TryGetMeleeDisplay(System.Int64 itemId, System.Int64 skinId, WizardGames.Soc.Common.Data.Display.MeleeDisplay& tb); // 0x06d78bf8
	static System.Boolean TryGetMeleeDisplay(WizardGames.Soc.Common.CustomType.MeleeCustom melee, WizardGames.Soc.Common.Data.Display.MeleeDisplay& tb); // 0x06d78d5c
	static System.Boolean TryGetThrowDisplay(System.Int64 itemId, System.Int64 skinId, WizardGames.Soc.Common.Data.Display.ThrowDisplay& tb); // 0x06d78e2c
	static System.Boolean TryGetThrowDisplay(WizardGames.Soc.Common.CustomType.ThrowWeaponCustom throwWeapon, WizardGames.Soc.Common.Data.Display.ThrowDisplay& tb); // 0x06d78f90
	static System.Boolean TryGetUseItemDisplay(WizardGames.Soc.Common.CustomType.UseItemCustom useitem, WizardGames.Soc.Common.Data.Display.MeleeDisplay& tb); // 0x06d79060
	static System.Boolean TryGetHeldItemDisplay(WizardGames.Soc.Common.CustomType.HeldItemCustom helditem, WizardGames.Soc.Common.Data.Display.MeleeDisplay& tb); // 0x06d79130
	static System.Boolean TryGetHeldItemAnimator(WizardGames.Soc.Common.CustomType.HeldItemCustom helditem, WizardGames.Soc.Common.Entity.PlayerCharacterTypeEnum eType, System.Boolean isFp, System.String& animatorPath); // 0x06d79200
	static System.Boolean TryGetHeldItemAnimator(WizardGames.Soc.Common.CustomType.MeleeCustom helditem, WizardGames.Soc.Common.Entity.PlayerCharacterTypeEnum eType, System.Boolean isFp, System.String& animatorPath); // 0x06d7937c
	static System.Boolean TryGetHeldItemAnimator(WizardGames.Soc.Common.CustomType.UseItemCustom helditem, WizardGames.Soc.Common.Entity.PlayerCharacterTypeEnum eType, System.Boolean isFp, System.String& animatorPath); // 0x06d794f8
	static System.Boolean TryGetHeldItemAnimator(WizardGames.Soc.Common.CustomType.ThrowWeaponCustom helditem, WizardGames.Soc.Common.Entity.PlayerCharacterTypeEnum eType, System.Boolean isFp, System.String& animatorPath); // 0x06d79674
	static System.Boolean TryGetHeldItemAnimator(WizardGames.Soc.Common.CustomType.WeaponCustom helditem, WizardGames.Soc.Common.Entity.PlayerCharacterTypeEnum eType, System.Boolean isFp, System.String& animatorPath); // 0x06d797f0
	static System.Boolean TryGetHeldItemMeta(WizardGames.Soc.Common.CustomType.HeldItemCustom helditem, WizardGames.Soc.Common.Entity.PlayerCharacterTypeEnum eType, System.Boolean isFp, System.String& metaPath); // 0x06d7996c
	static System.Boolean TryGetHeldItemMeta(WizardGames.Soc.Common.CustomType.MeleeCustom helditem, WizardGames.Soc.Common.Entity.PlayerCharacterTypeEnum eType, System.Boolean isFp, System.String& metaPath); // 0x06d79ae8
	static System.Boolean TryGetHeldItemMeta(WizardGames.Soc.Common.CustomType.UseItemCustom helditem, WizardGames.Soc.Common.Entity.PlayerCharacterTypeEnum eType, System.Boolean isFp, System.String& metaPath); // 0x06d79c64
	static System.Boolean TryGetHeldItemMeta(WizardGames.Soc.Common.CustomType.ThrowWeaponCustom helditem, WizardGames.Soc.Common.Entity.PlayerCharacterTypeEnum eType, System.Boolean isFp, System.String& metaPath); // 0x06d79de0
	static System.Boolean TryGetHeldItemMeta(WizardGames.Soc.Common.CustomType.WeaponCustom helditem, WizardGames.Soc.Common.Entity.PlayerCharacterTypeEnum eType, System.Boolean isFp, System.String& metaPath); // 0x06d79f5c
	static System.Boolean TryGetCurrentHeldItem<T>(WizardGames.Soc.Common.Entity.PlayerEntity player, T& heldItem); // 0x052af1f0
	static System.Boolean TryGetHeldItem<T>(WizardGames.Soc.Common.Entity.PlayerEntity player, System.Int64 entityID, T& heldItem); // 0x052af1f0
	static System.Boolean IsBurstMode(WizardGames.Soc.Common.CustomType.WeaponCustom weapon); // 0x06d7a0d8
	static System.Boolean IsBurstMode(WizardGames.Soc.Common.Data.gun.GunBase table); // 0x06d7a1f0
	static System.Int32 BurstCount(WizardGames.Soc.Common.Data.gun.GunBase table); // 0x06d7a264
	static System.Boolean IsSingleMode(WizardGames.Soc.Common.CustomType.WeaponCustom weapon); // 0x054c4760
	static System.Boolean IsSingleMode(WizardGames.Soc.Common.Data.gun.GunBase table); // 0x06d7a2d0
	static System.Boolean IsSingleContinualFire(WizardGames.Soc.Common.Data.gun.GunBase table); // 0x06d7a344
	static System.Boolean CanUseInSprint(WizardGames.Soc.Common.Entity.IHeldItemEntity helditem); // 0x06d7a3b8
	static System.Boolean CanHeldInMantle(System.Int64 weaponTableId); // 0x06d7a714
	static System.Boolean CanAds(WizardGames.Soc.Common.Entity.IHeldItemEntity helditem); // 0x06d7a818
	static System.Int32 ReShowTypeInMantle(System.Int64 weaponTableId); // 0x06d7a9cc
	static System.Single GetAmmoSpreadScale(System.Single adsOffset, System.Int64 ammoId); // 0x06d7aad0
	static System.Boolean CheckHideEquip(System.Int64 weaponTableId, System.Int32 id); // 0x06d7abf0
	static System.Boolean IsInList(System.Int32[] ids, System.Int32 id); // 0x06d7ae8c
	static System.Int32 GetEntityTypeByCfgID(System.Int32 id); // 0x06d7af3c
	static System.Boolean AttackSecondPhase(WizardGames.Soc.Common.Entity.IHeldItemEntity helditem, WizardGames.Soc.Common.Entity.PlayerEntity player); // 0x06d7b0b0
	static System.Single GetWeaponAdsFOV(WizardGames.Soc.Common.CustomType.WeaponCustom weapon, System.Single currentFov, System.Boolean useRate); // 0x06d7b270
	static System.Single GetRealAdsFOV(System.Single currentFov, System.Single targetfov, System.Boolean useRate); // 0x06d7b540
	static WizardGames.Soc.Common.Combat.BulletRequest GenerateBulletRequestByFireReqeust(WizardGames.Soc.Common.Combat.FireRequest fireRequest); // 0x06d7b65c
	static WizardGames.Soc.Common.Entity.BulletEntity GenerateBulletEntityByBulletReqeust(WizardGames.Soc.Common.Combat.BulletRequest bulletRequest, System.Single serverTime, System.Numerics.Vector3 Acceleration, WizardGames.Soc.Common.Contexts.Context context); // 0x06d7b77c
	static System.Boolean HasTag(System.Int32 tags, System.Int32 tag); // 0x06d7c510
	static System.Boolean TryGetBowAimRate(System.Int64 id, System.Single progress, System.Collections.Generic.IList<System.Single> parameters, System.Single& rate); // 0x06d7c58c
	static System.Boolean TryGetBowChargeRate(System.Int64 id, System.Single progress, System.Collections.Generic.IList<System.Single> parameters, System.Single& rate); // 0x06d7c948
	static System.Void UpdateBowFireScale(WizardGames.Soc.Common.Data.gun.GunBase tb, System.Single drawProgress, System.Single chargeProgress, WizardGames.Soc.Common.CustomType.WeaponCustom weapon); // 0x06d7cc6c
	static System.Void .cctor(); // 0x06d7ce64
}

// Client.Runtime
class WizardGames.Soc.Common.Weapon.HeldItemUtility.<>c : System.Object
{
	static WizardGames.Soc.Common.Weapon.HeldItemUtility.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x06d7cfe0
	System.Void .ctor(); // 0x06d7d044
	System.Boolean <.cctor>b__95_0(WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom entity); // 0x06d7d0ac
}

// Client.Runtime
interface WizardGames.Soc.Common.Weapon.IWeaponData : 
{
	
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Weapon.WeaponUniqueIndex : System.ValueType, System.IEquatable<WizardGames.Soc.Common.Weapon.WeaponUniqueIndex>
{
	System.Int32 TableId; // 0x10
	System.Int32 AppearanceId; // 0x14
	System.Boolean Equals(WizardGames.Soc.Common.Weapon.WeaponUniqueIndex other); // 0x06d7d1d8
	System.String ToString(); // 0x06d7d270
	System.Int32 GetHashCode(); // 0x06d7d348
}

// Client.Runtime
struct WizardGames.Soc.Common.Weapon.WeaponUnique : System.ValueType, System.IEquatable<WizardGames.Soc.Common.Weapon.WeaponUnique>
{
	System.Int32 TableId; // 0x10
	System.Int32 AppearanceId; // 0x14
	WizardGames.Soc.Common.Entity.PlayerCharacterTypeEnum CharacterType; // 0x18
	System.Boolean Equals(WizardGames.Soc.Common.Weapon.WeaponUnique other); // 0x06d7d3f0
	System.String ToString(); // 0x06d7d49c
	System.Int32 GetHashCode(); // 0x06d7d5b0
}

// Client.Runtime
enum WizardGames.Soc.Common.Weapon.EquipType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Weapon.EquipType Hold = 0;
	static WizardGames.Soc.Common.Weapon.EquipType Weapon = 1;
	static WizardGames.Soc.Common.Weapon.EquipType Throw = 2;
	static WizardGames.Soc.Common.Weapon.EquipType None = 3;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Weapon.HeldItemUtilityShare : System.Object
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.Common.Weapon.EquipType GetEquipType(System.Int64 itemId); // 0x06d78424
	static System.Void .cctor(); // 0x06d7d66c
}

// Client.Runtime
class WizardGames.Soc.Common.Contexts.MgrLifeCycle : System.Object
{
	static SocLogger <Logger>k__BackingField; // 0x0
	static System.Action<WizardGames.Soc.Common.Entity.PlayerEntity,System.Int32,System.Int32> OnChangeLifeCycleFlags; // 0x8
	static System.Action<WizardGames.Soc.Common.Entity.IEntity,WizardGames.Soc.Common.Entity.IEntity,WizardGames.Soc.Common.SimpleCustom.DamageDataEvent> OnDead; // 0x10
	static System.Void AddOnDead(System.Action<WizardGames.Soc.Common.Entity.IEntity,WizardGames.Soc.Common.Entity.IEntity,WizardGames.Soc.Common.SimpleCustom.DamageDataEvent> action); // 0x06d7d740
	static System.Void RemoveOnDead(System.Action<WizardGames.Soc.Common.Entity.IEntity,WizardGames.Soc.Common.Entity.IEntity,WizardGames.Soc.Common.SimpleCustom.DamageDataEvent> action); // 0x06d7d8f8
	static System.Void .cctor(); // 0x06d7da20
}

// Client.Runtime
class WizardGames.Soc.Common.Contexts.Context : System.Object
{
	WizardGames.Soc.Common.Entity.BaseMgrLocalEntity MgrEntity; // 0x10
	WizardGames.Soc.Common.Synchronization.MgrTime MgrTime; // 0x18
	WizardGames.Soc.Common.Synchronization.MgrSnapshotReceiver MgrSnapshotReceiver; // 0x20
	WizardGames.Soc.Common.Systems.MgrSystem MgrSystem; // 0x28
	WizardGames.Soc.Common.Manager.SystemRequestManager SystemRequestMgr; // 0x30
	WizardGames.Soc.SocSimulator.PropModifyDict PropModifyDict; // 0x38
	System.Action<WizardGames.Soc.Common.SimpleCustom.KillEventData> OnAddKillEventData; // 0x40
	System.Collections.Generic.HashSet<System.Int64> WearItemRequestSet; // 0x48
	System.Collections.Generic.List<System.Int64> BuoyancyEntityId; // 0x50
	System.Collections.Generic.List<System.Int64> RemoveEntityIds; // 0x58
	System.Collections.Generic.List<System.Int64> MonsterEntityAddIds; // 0x60
	System.Collections.Generic.List<System.Int64> MonsterEntityRemoveIds; // 0x68
	WizardGames.Soc.Common.Weapon.IWeaponData PreData; // 0x70
	WizardGames.Soc.Common.Weapon.IWeaponData PostData; // 0x78
	Src.Animation.ISocAnimWarpingData WarpingData; // 0x80
	WizardGames.Soc.Common.DebugGroup.DebugParameter DebugParameter; // 0x88
	System.Boolean ClientAuthority; // 0x90
	System.Int64 FrameNumber; // 0x98
	System.Double EngineTime; // 0xa0
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int64>> tickableMap; // 0xa8
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.HashSet<WizardGames.Soc.Common.Systems.BaseSystem>> comp2SysDict; // 0xb0
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.HashSet<WizardGames.Soc.Common.Systems.BasePrioritySystem>> comp2PrioritySysDict; // 0xb8
	System.Collections.Generic.HashSet<System.Int64> Players2SetLayer; // 0xc0
	System.Void .ctor(); // 0x06d7daf4
	System.Void Clear(); // 0x06d7de28
	System.Void OnCompStatusChanged(System.Int64 entityId, System.Int32 compId, System.Boolean isActive, System.Int32 priority); // 0x06d7ded4
	System.Void RegisterInterestComp(System.Int32 compId, WizardGames.Soc.Common.Systems.BaseSystem system); // 0x06d7e0c4
}

// Client.Runtime
enum WizardGames.Soc.Common.Construction.EAnimSubNodeMeshDealerType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Construction.EAnimSubNodeMeshDealerType GPUInstChangeMeshEnable = 0;
	static WizardGames.Soc.Common.Construction.EAnimSubNodeMeshDealerType NotInstChangeMeshMotionVector = 1;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.AnimSubNodeMeshDealer : System.Object
{
	UnityEngine.Transform transform; // 0x10
	System.Collections.Generic.List<UnityEngine.Renderer> subRenderers; // 0x18
	WizardGames.Soc.Common.Construction.EAnimSubNodeMeshDealerType type; // 0x20
	static System.Void GetFromPool(WizardGames.Soc.Common.Construction.AnimSubNodeMeshDealer& dealer, UnityEngine.Transform transform, WizardGames.Soc.Common.Construction.EAnimSubNodeMeshDealerType type); // 0x06d7e364
	static System.Void ReturnToPool(WizardGames.Soc.Common.Construction.AnimSubNodeMeshDealer& dealer); // 0x06d7e518
	System.Void .ctor(); // 0x06d7e6b8
	System.Void Setup(UnityEngine.Transform transform, WizardGames.Soc.Common.Construction.EAnimSubNodeMeshDealerType type); // 0x06d7e48c
	System.Collections.Generic.List<UnityEngine.Renderer> get_SubRenderers(); // 0x06d7e720
	System.Void OnAnimStateChange(System.Boolean enterAnimMode); // 0x06d7e848
	System.Void Dispose(); // 0x06d7e5e4
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.ColliderGameObjectBind : UnityEngine.MonoBehaviour
{
	UnityEngine.Behaviour[] monoBehaviours; // 0x30
	UnityEngine.GameObject[] gameObjects; // 0x38
	System.Void SetEnabled(System.Boolean enabled); // 0x06d7eab8
	System.Void .ctor(); // 0x06d7ec74
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.EmissionToggle : UnityEngine.MonoBehaviour
{
	UnityEngine.Color emissionColor; // 0x30
	UnityEngine.Renderer[] targetRenderers; // 0x40
	System.Int32 materialIndex; // 0x48
	System.Boolean inited; // 0x4c
	System.Nullable<System.Single> emissionPercent; // 0x50
	static UnityEngine.MaterialPropertyBlock block; // 0x0
	static System.Int32 emissionColorID; // 0x8
	System.Void OnEnable(); // 0x06d7ecdc
	System.Void Init(); // 0x06d7ed40
	System.Void SetEmissionEnabled(System.Boolean on); // 0x06d7ef60
	System.Void SetEmission(System.Single percent); // 0x06d7eff0
	System.Void .ctor(); // 0x06d7f200
	static System.Void .cctor(); // 0x06d7f270
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.EntityFlag_Toggle : UnityEngine.MonoBehaviour
{
	System.Boolean runClientside; // 0x30
	System.Boolean runServerside; // 0x31
	WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags flag; // 0x34
	UnityEngine.Events.UnityEvent onFlagEnabled; // 0x38
	UnityEngine.Events.UnityEvent onFlagDisabled; // 0x40
	System.Boolean hasRunOnce; // 0x48
	System.Boolean lastHasFlag; // 0x49
	System.Void OnDisable(); // 0x06d7f2d8
	System.Void BindPart(WizardGames.Soc.Common.Entity.PartEntity entity); // 0x06d7f33c
	System.Void UnBindPart(WizardGames.Soc.Common.Entity.PartEntity entity); // 0x06d7f540
	System.Void OnStateFlagUpdated(System.Int32 oldFlag, System.Int32 newFlag); // 0x06d7f450
	System.Void OnStateToggled(System.Boolean state); // 0x06d7f648
	System.Void .ctor(); // 0x06d7f6bc
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.LadderHatchBind : WizardGames.Soc.Common.Construction.ColliderGameObjectBind
{
	
	System.Void .ctor(); // 0x06d7f788
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.ConstructionSocketRuntime : WizardGames.Soc.Common.Construction.SocketRuntimeBase
{
	static System.Collections.Generic.Dictionary<System.Int32,System.Predicate<WizardGames.Soc.Common.Construction.SocketRuntimeBase>> PredicateSocketSides; // 0x0
	System.Boolean get_NeedFixRotation(); // 0x06d7f7ec
	System.Int32 get_RotationDegrees(); // 0x06d7f85c
	System.Boolean get_RestrictPlacementRotation(); // 0x06d7f8cc
	System.Int32 get_RotationOffset(); // 0x06d7f93c
	System.Int32 get_WallCheckSocketId(); // 0x06d7f9ac
	WizardGames.Soc.Common.Construction.ConstructionSocketRuntime get_ShareCapacitySocketData(); // 0x06d7fa1c
	System.Boolean TestTarget(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget target); // 0x06d7fb24
	WizardGames.Soc.Common.Construction.ConstructionSocketRuntime get_CombineLinkSocketData(); // 0x06d7fc8c
	WizardGames.Soc.Common.Unity.Construction.Placement DoPlacement(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget& target); // 0x06d7fd94
	WizardGames.Soc.Common.Unity.Construction.Placement SetRotatePosWithoutRotation(UnityEngine.Quaternion femaleSocketRot, UnityEngine.Vector3 femaleSocketPos); // 0x06d8075c
	System.Boolean CanConnect(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, WizardGames.Soc.Common.Construction.SocketRuntimeBase socketData, UnityEngine.Vector3 socketPosition, UnityEngine.Quaternion socketRotation); // 0x06d80ab8
	WizardGames.Soc.Common.Construction.EConstructionSocketType get_SocketType(); // 0x06d812f4
	System.Boolean get_IgnoreProximity(); // 0x06d81364
	System.Boolean CanConnect(WizardGames.Soc.Common.Algorithm.Vector3 position, WizardGames.Soc.Common.Framework.Algorithm.Quaternion rotation, WizardGames.Soc.Common.Construction.SocketRuntimeBase socketData, WizardGames.Soc.Common.Algorithm.Vector3 socketPosition, WizardGames.Soc.Common.Framework.Algorithm.Quaternion socketRotation); // 0x06d813d4
	System.Boolean IsCompatible(WizardGames.Soc.Common.Construction.SocketRuntimeBase socketData); // 0x06d814f8
	static System.Boolean PredicateSocketSide(WizardGames.Soc.Common.Construction.SocketRuntimeBase socketData, WizardGames.Soc.Common.Construction.ESocketSide target); // 0x06d81578
	System.Void .ctor(); // 0x06d816b8
	static System.Void .cctor(); // 0x06d817a8
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.ConstructionSocketRuntime.<>c : System.Object
{
	static WizardGames.Soc.Common.Construction.ConstructionSocketRuntime.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x06d81adc
	System.Void .ctor(); // 0x06d81b40
	System.Boolean <.cctor>b__29_0(WizardGames.Soc.Common.Construction.SocketRuntimeBase socket); // 0x06d81ba8
	System.Boolean <.cctor>b__29_1(WizardGames.Soc.Common.Construction.SocketRuntimeBase socket); // 0x06d81c20
	System.Boolean <.cctor>b__29_2(WizardGames.Soc.Common.Construction.SocketRuntimeBase socket); // 0x06d81cc0
	System.Boolean <.cctor>b__29_3(WizardGames.Soc.Common.Construction.SocketRuntimeBase socket); // 0x06d81d60
	System.Boolean <.cctor>b__29_4(WizardGames.Soc.Common.Construction.SocketRuntimeBase socket); // 0x06d81e00
	System.Boolean <.cctor>b__29_5(WizardGames.Soc.Common.Construction.SocketRuntimeBase socket); // 0x06d81ea0
	System.Boolean <.cctor>b__29_6(WizardGames.Soc.Common.Construction.SocketRuntimeBase socket); // 0x06d81f40
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.ElevatorSocketRuntime : WizardGames.Soc.Common.Construction.ConstructionSocketRuntime
{
	static UnityEngine.Vector3 size; // 0x0
	System.Boolean CanConnectToEntity(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget target); // 0x06d81fe0
	System.Boolean CanConnect(WizardGames.Soc.Common.Algorithm.Vector3 position, WizardGames.Soc.Common.Framework.Algorithm.Quaternion rotation, WizardGames.Soc.Common.Construction.SocketRuntimeBase socketData, WizardGames.Soc.Common.Algorithm.Vector3 socketPosition, WizardGames.Soc.Common.Framework.Algorithm.Quaternion socketRotation); // 0x06d822b0
	System.Void .ctor(); // 0x06d82674
	static System.Void .cctor(); // 0x06d826fc
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.FreeSocketRuntime : WizardGames.Soc.Common.Construction.SocketRuntimeBase
{
	System.Collections.Generic.List<UnityEngine.RaycastHit> hits; // 0x30
	System.Boolean get_UseTargetNormal(); // 0x06d82754
	System.Boolean get_BlendAimAngle(); // 0x06d827c4
	System.Int32 get_TargetNormalRange(); // 0x06d82834
	UnityEngine.Vector3 get_idealPlacementNormal(); // 0x06d828a4
	System.Single get_AutoAbsorbWidth(); // 0x06d8291c
	System.Single get_AutoAbsorbLength(); // 0x06d8298c
	System.Boolean TestTarget(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget target); // 0x06d829fc
	WizardGames.Soc.Common.Unity.Construction.Placement DoPlacement(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget& target); // 0x06d82a90
	System.Boolean LeftRightTry(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget& target, UnityEngine.Vector3& findBias, UnityEngine.Vector3& direct, System.Single constructionBias, System.Boolean isLeft); // 0x06d83a68
	System.Boolean LeftRightTry(UnityEngine.Vector3& position, UnityEngine.Vector3& findBias, UnityEngine.Vector3& direct, System.Single constructionBias, System.Boolean isLeft); // 0x06d83b2c
	System.Void .ctor(); // 0x06d84270
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.NeighbourSocketRuntime : WizardGames.Soc.Common.Construction.SocketRuntimeBase
{
	
	System.Boolean TestTarget(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget target); // 0x06d84344
	System.Boolean CanConnect(WizardGames.Soc.Common.Algorithm.Vector3 position, WizardGames.Soc.Common.Framework.Algorithm.Quaternion rotation, WizardGames.Soc.Common.Construction.SocketRuntimeBase socketData, WizardGames.Soc.Common.Algorithm.Vector3 socketPosition, WizardGames.Soc.Common.Framework.Algorithm.Quaternion socketRotation); // 0x06d843d4
	System.Void .ctor(); // 0x06d844f8
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.SocketConfigData : System.Object
{
	WizardGames.Soc.Common.Unity.Construction.SocketModNoMono[] SocketMods; // 0x10
	UnityEngine.Vector3 localPositionUnity; // 0x18
	UnityEngine.Quaternion localRotationUnity; // 0x24
	UnityEngine.Vector3 selectSizeUnity; // 0x34
	UnityEngine.Vector3 selectCenterUnity; // 0x40
	UnityEngine.Vector3 idealPlacementNormalUnity; // 0x4c
	WizardGames.Soc.Common.Unity.Construction.SocketModConfigData[] SocketModConfigs; // 0x58
	WizardGames.Soc.Common.Data.part.SocketBehaviorType socketBehaviorType; // 0x60
	System.String socketName; // 0x68
	System.Int32 socketId; // 0x70
	WizardGames.Soc.Common.Algorithm.Vector3 localPosition; // 0x74
	WizardGames.Soc.Common.Framework.Algorithm.Quaternion localRotation; // 0x80
	System.Boolean male; // 0x90
	System.Boolean maleDummy; // 0x91
	System.Boolean female; // 0x92
	System.Boolean femaleDummy; // 0x93
	System.Boolean monogamous; // 0x94
	WizardGames.Soc.Common.Algorithm.Vector3 selectSize; // 0x98
	WizardGames.Soc.Common.Algorithm.Vector3 selectCenter; // 0xa4
	WizardGames.Soc.Common.Construction.EConstructionSocketType constructionSocketType; // 0xb0
	System.Boolean restrictPlacementRotation; // 0xb4
	System.Int32 rotationDegrees; // 0xb8
	System.Int32 rotationOffset; // 0xbc
	System.Boolean needFixRotation; // 0xc0
	System.Single angleAllowed; // 0xc4
	WizardGames.Soc.Common.Construction.ESocketSide socketSide; // 0xc8
	System.Int32 wallCheckSocketId; // 0xcc
	System.Int32 combineLinkSocketId; // 0xd0
	System.Int32 shareCapacitySocketId; // 0xd4
	System.Boolean ignorePromixity; // 0xd8
	System.Single support; // 0xdc
	System.Boolean needPermission; // 0xe0
	System.Single placementHight; // 0xe4
	System.Boolean alignToNormal; // 0xe8
	WizardGames.Soc.Common.Algorithm.Vector3 idealPlacementNormal; // 0xec
	System.Boolean useTargetNormal; // 0xf8
	System.Boolean blendAimAngle; // 0xf9
	System.Int32 targetNormalRange; // 0xfc
	System.Single autoAbsorbWidth; // 0x100
	System.Single autoAbsorbLength; // 0x104
	System.Int32 maxFloor; // 0x108
	System.Void .ctor(); // 0x06d84580
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.SocketRuntimeBase : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Entity.PartEntity ParentPartEntity; // 0x20
	WizardGames.Soc.Common.Construction.SocketConfigData SocketConfigData; // 0x28
	WizardGames.Soc.Common.Unity.Construction.SocketModNoMono[] get_SocketMods(); // 0x06d845e8
	UnityEngine.Quaternion get_LocalUnityRotation(); // 0x06d811a4
	UnityEngine.Vector3 get_LocalUnitySelectCenter(); // 0x06d84658
	UnityEngine.Vector3 get_LocalUnitySelectSize(); // 0x06d846c8
	UnityEngine.Vector3 get_LocalUnityPosition(); // 0x06d81134
	UnityEngine.Vector3 GetSelectPivot(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); // 0x06d84738
	WizardGames.Soc.Common.Unity.Utility.OBB GetUnitySelectBounds(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale); // 0x06d84838
	System.Boolean CanConnect(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, WizardGames.Soc.Common.Construction.SocketRuntimeBase socketData, UnityEngine.Vector3 socketPosition, UnityEngine.Quaternion socketRotation); // 0x06d81018
	System.Boolean TestTarget(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget target); // 0x06d7fbfc
	WizardGames.Soc.Common.Unity.Construction.Placement DoPlacement(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget& target); // 0x06d84b2c
	System.Boolean CanConnectToEntity(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget target); // 0x06d82220
	System.Boolean ModifyAndCheckSocketMods(WizardGames.Soc.Common.Unity.Construction.Placement placement); // 0x06d84d44
	System.Boolean JustCheckSocketMods(WizardGames.Soc.Common.Unity.Construction.Placement placement); // 0x06d84e3c
	SocLogger get_Logger(); // 0x06d84f2c
	WizardGames.Soc.Common.Component.ConstructionSocketBaseComponent get_SocketComponent(); // 0x06d84fbc
	System.Int32 get_SocketId(); // 0x06d85034
	System.Void Init(); // 0x06d850a4
	static T Generate<T>(); // 0x052af1f0
	System.String get_SocketName(); // 0x06d85104
	WizardGames.Soc.Common.Construction.ESocketSide get_SocketSide(); // 0x06d81648
	System.Boolean get_Male(); // 0x06d81214
	System.Boolean get_Female(); // 0x06d81284
	System.Boolean get_MaleDummy(); // 0x06d85174
	System.Boolean get_FemaleDummy(); // 0x06d851e4
	WizardGames.Soc.Common.Framework.Algorithm.Quaternion get_LocalRotation(); // 0x06d80a48
	WizardGames.Soc.Common.Algorithm.Vector3 get_SelectCenter(); // 0x06d85254
	WizardGames.Soc.Common.Algorithm.Vector3 get_SelectSize(); // 0x06d852c4
	WizardGames.Soc.Common.Algorithm.Vector3 get_LocalPosition(); // 0x06d85334
	System.Boolean CanConnect(WizardGames.Soc.Common.Algorithm.Vector3 position, WizardGames.Soc.Common.Framework.Algorithm.Quaternion rotation, WizardGames.Soc.Common.Construction.SocketRuntimeBase socketData, WizardGames.Soc.Common.Algorithm.Vector3 socketPosition, WizardGames.Soc.Common.Framework.Algorithm.Quaternion socketRotation); // 0x06d853a4
	System.Boolean IsCompatible(WizardGames.Soc.Common.Construction.SocketRuntimeBase socketData); // 0x06d854c8
	System.Void ReleaseToPool(); // 0x06d85548
	System.Void .ctor(); // 0x06d81740
	static System.Void .cctor(); // 0x06d855e4
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.StabilitySocketRuntime : WizardGames.Soc.Common.Construction.SocketRuntimeBase
{
	
	System.Boolean TestTarget(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget target); // 0x06d856b8
	System.Boolean CanConnect(WizardGames.Soc.Common.Algorithm.Vector3 position, WizardGames.Soc.Common.Framework.Algorithm.Quaternion rotation, WizardGames.Soc.Common.Construction.SocketRuntimeBase socketData, WizardGames.Soc.Common.Algorithm.Vector3 socketPosition, WizardGames.Soc.Common.Framework.Algorithm.Quaternion socketRotation); // 0x06d85748
	System.Void .ctor(); // 0x06d8586c
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.TerrainSocketRuntime : WizardGames.Soc.Common.Construction.SocketRuntimeBase
{
	WizardGames.Soc.Common.Algorithm.Vector3 FixLocalPos; // 0x30
	System.Boolean get_alignToNormal(); // 0x06d858f4
	System.Boolean TestTarget(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget target); // 0x06d85964
	WizardGames.Soc.Common.Algorithm.Vector3 get_LocalPosition(); // 0x06d859f8
	WizardGames.Soc.Common.Unity.Construction.Placement DoPlacement(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget& target); // 0x06d85b10
	System.Void .ctor(); // 0x06d85eec
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.BuildingPrivilegeCheckerHotfix : System.Object
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.List<System.Int32> desertedGroups; // 0x8
	static System.Void DeniedHint(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.EResultType result, WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckContext& ctx); // 0x06d86010
	static WizardGames.Soc.Common.Entity.TerritoryEntity GetTerritoryCenter(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Entity.PartEntity part); // 0x06d86c44
	static WizardGames.Soc.Common.Entity.TerritoryEntity GetTerritoryCenter(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Algorithm.Vector3 pos); // 0x06d86d9c
	static WizardGames.Soc.Common.Entity.TerritoryEntity GetTerritoryCenter(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, System.Int64 terrId); // 0x06d86f08
	static System.Boolean IsSameTeam(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, System.UInt64 roleId1, System.UInt64 roleId2); // 0x06d86fec
	static System.Boolean CheckPermissionByPartEx(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.EPrivilegeType pType, WizardGames.Soc.Common.Entity.PartEntity partEntity, System.Boolean silent); // 0x06d87174
	static System.Boolean CheckPermissionByTemplateEx(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.EPrivilegeType pType, WizardGames.Soc.Common.Algorithm.Vector3 pos, System.Int64 templateId, System.Boolean silent); // 0x06d874f8
	static System.Boolean HasSpecialPermission(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, System.Int64 partId, System.Int32 permissionGroupId); // 0x06d877b8
	static System.Boolean HasSpecialPermission(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Entity.TerritoryEntity terrEnt, System.Int32 permissionGroupId); // 0x06d87a08
	static System.Void Init(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self); // 0x06d87b00
	static System.Boolean IsPass(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.EResultType result); // 0x06d8a774
	static WizardGames.Soc.Common.Construction.EResultType CheckPermissionByPart(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.EPrivilegeType pType, WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.Entity.PartEntity partEntity, System.Boolean silent); // 0x06d8735c
	static WizardGames.Soc.Common.Construction.EResultType CheckPermissionByPart(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask needPrivilege, WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.Entity.PartEntity partEntity, System.Boolean silent); // 0x06d8a96c
	static WizardGames.Soc.Common.Construction.EResultType CheckPermissionByTemplate(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.EPrivilegeType pType, WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.Algorithm.Vector3 pos, System.Int64 templateId, System.Boolean silent); // 0x06d876a4
	static WizardGames.Soc.Common.Construction.EResultType CheckPermissionByPos(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask needPrivilege, WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.Algorithm.Vector3 pos, System.Boolean silent); // 0x06d8093c
	static WizardGames.Soc.Common.Construction.EResultType CheckPermission(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.EPrivilegeType pType, WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.Entity.PartEntity part, WizardGames.Soc.Common.Algorithm.Vector3 pos, System.Int64 templateId, System.Int64 terrId, System.Boolean silent); // 0x06d8a7f0
	static WizardGames.Soc.Common.Construction.EResultType CheckPermission(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask needPrivilege, WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.Entity.PartEntity part, WizardGames.Soc.Common.Algorithm.Vector3 pos, System.Int64 templateId, System.Int64 terrId, System.Boolean silent); // 0x06d8ab20
	static WizardGames.Soc.Common.Construction.EResultType CheckPermission(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckContext& ctx); // 0x06d8aee8
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask GetBuildPrivilegeNeedByPart(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, System.Int64 templateId); // 0x06d8b130
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask GetPickUpPrivilegeNeedByPart(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, System.Int64 templateId); // 0x06d8b250
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask GetDeletePrivilegeNeedByPart(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, System.Int64 templateId); // 0x06d8b378
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask GetInteractPrivilegeNeedByPart(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, System.Int64 templateId); // 0x06d8b498
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask GetPasswordPrivilegeNeedByPart(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, System.Int64 templateId); // 0x06d8b5c0
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask GetPrivilegeMaskByType(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, System.Int64 templateId, WizardGames.Soc.Common.Construction.EPrivilegeType type); // 0x06d8ad04
	static WizardGames.Soc.Common.Construction.EResultType OwnerPass(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckContext& ctx, System.Boolean& checkNext); // 0x06d8b6ec
	static WizardGames.Soc.Common.Construction.EResultType OwnerPassIfNoTerrCenter(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckContext& ctx, System.Boolean& checkNext); // 0x06d8b7b4
	static WizardGames.Soc.Common.Construction.EResultType CheckOnCreateToolCupboard(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckContext& ctx, System.Boolean& checkNext); // 0x06d8b87c
	static WizardGames.Soc.Common.Construction.EResultType DeniedDefault(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckContext& ctx, System.Boolean& checkNext); // 0x06d8ba68
	static WizardGames.Soc.Common.Construction.EResultType PassDefault(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckContext& ctx, System.Boolean& checkNext); // 0x06d8bae8
	static WizardGames.Soc.Common.Construction.EResultType PrivilegeMustHave(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckContext& ctx, System.Boolean& checkNext); // 0x06d8bb6c
	static WizardGames.Soc.Common.Construction.EResultType TerritoryStateDenied(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckContext& ctx, System.Boolean& checkNext); // 0x06d8c1f8
	static WizardGames.Soc.Common.Construction.EResultType MiddleStateDenied(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckContext& ctx, System.Boolean& checkNext); // 0x06d8c2a4
	static WizardGames.Soc.Common.Construction.EResultType MiddleStatePass(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckContext& ctx, System.Boolean& checkNext); // 0x06d8c344
	static WizardGames.Soc.Common.Construction.EResultType TerritoryGrace(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckContext& ctx, System.Boolean& checkNext); // 0x06d8c3dc
	static WizardGames.Soc.Common.Construction.EResultType PrivilegeTestIfHaveToolCupboard(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckContext& ctx, System.Boolean& checkNext); // 0x06d8c50c
	static WizardGames.Soc.Common.Construction.EResultType CheckBuildingPrivilegeMask(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckContext& ctx, System.Boolean& checkNext); // 0x06d8bc34
	static System.Boolean PassOnDeserted(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, System.UInt64 needMaks); // 0x06d8c5d4
	static WizardGames.Soc.Common.Construction.EResultType PassIfInSameTeam(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckContext& ctx, System.Boolean& checkNext); // 0x06d8c7fc
	static WizardGames.Soc.Common.Construction.EResultType CheckSafetyBox(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckContext& ctx, System.Boolean& checkNext); // 0x06d8c918
	static WizardGames.Soc.Common.Construction.EResultType TimeNewBuildForRotate(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckContext& ctx, System.Boolean& checkNext); // 0x06d8ca5c
	static WizardGames.Soc.Common.Construction.EResultType TimeNewBuild(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckContext& ctx, System.Boolean& checkNext); // 0x06d8cbdc
	static WizardGames.Soc.Common.Construction.EResultType TimeAttackedBlock(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckContext& ctx, System.Boolean& checkNext); // 0x06d8ce60
	static WizardGames.Soc.Common.Construction.EResultType InteractTypeRotate(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckContext& ctx, System.Boolean& checkNext); // 0x06d8cf14
	static WizardGames.Soc.Common.Construction.EResultType InteractTypeRemove(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckContext& ctx, System.Boolean& checkNext); // 0x06d8d03c
	static WizardGames.Soc.Common.Construction.EResultType InteractTypeRepair(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckContext& ctx, System.Boolean& checkNext); // 0x06d8d164
	static WizardGames.Soc.Common.Construction.EResultType InteractTypePickup(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckContext& ctx, System.Boolean& checkNext); // 0x06d8d28c
	static System.Void .cctor(); // 0x06d8d3b4
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.Alpha3SocketBaseHotfix : System.Object
{
	
	static System.Void Setup(WizardGames.Soc.Common.Construction.SocketRuntimeBase self, WizardGames.Soc.Common.Entity.PartEntity parentPartEntity, System.Int32 id); // 0x06d8d7c8
	static WizardGames.Soc.Common.Framework.Algorithm.OBB GetSelectBounds(WizardGames.Soc.Common.Construction.SocketRuntimeBase self, WizardGames.Soc.Common.Algorithm.Vector3 position, WizardGames.Soc.Common.Framework.Algorithm.Quaternion rotation, WizardGames.Soc.Common.Algorithm.Vector3 scale); // 0x06d8daf4
	static System.Boolean IsEmpty(WizardGames.Soc.Common.Construction.SocketRuntimeBase self); // 0x06d8dfd4
	static System.Boolean IsOccupied(WizardGames.Soc.Common.Construction.SocketRuntimeBase self); // 0x06d8e044
	static System.Boolean CanConnectCommonVirtual(WizardGames.Soc.Common.Construction.SocketRuntimeBase self, WizardGames.Soc.Common.Algorithm.Vector3 position, WizardGames.Soc.Common.Framework.Algorithm.Quaternion rotation, WizardGames.Soc.Common.Construction.SocketRuntimeBase socketData, WizardGames.Soc.Common.Algorithm.Vector3 socketPosition, WizardGames.Soc.Common.Framework.Algorithm.Quaternion socketRotation); // 0x06d8e0fc
	static System.Boolean IsCompatibleCommonVirtual(WizardGames.Soc.Common.Construction.SocketRuntimeBase self, WizardGames.Soc.Common.Construction.SocketRuntimeBase socketData); // 0x06d8e220
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.BuildingPrivilegeHelper : System.Object
{
	
	static System.UInt64 CalcMask(System.Int32 permissionUnitId); // 0x06d8e360
	static System.Boolean IsInChargePos(WizardGames.Soc.Common.Algorithm.Vector3 terrPos, WizardGames.Soc.Common.Algorithm.Vector3 targetPos, System.Double distance, System.Double distanceSquare); // 0x06d8e3cc
	static System.Int64 FindInChargeTs(WizardGames.Soc.Common.Entity.TerritoryEntity terrEnt, WizardGames.Soc.Common.Algorithm.Vector3 targetPos, System.Double distance, System.Double distanceSquare); // 0x06d8e5a0
	static WizardGames.Soc.Common.Entity.TerritoryEntity ChooseTerritoryCenter(System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.TerritoryEntity> terrDict, WizardGames.Soc.Common.Algorithm.Vector3 pos); // 0x06d8e858
}

// Client.Runtime
enum WizardGames.Soc.Common.Construction.ECreatePlayerConstructionBlueprintRespCode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Construction.ECreatePlayerConstructionBlueprintRespCode Suc = 0;
	static WizardGames.Soc.Common.Construction.ECreatePlayerConstructionBlueprintRespCode DistanceTooFar = 1;
	static WizardGames.Soc.Common.Construction.ECreatePlayerConstructionBlueprintRespCode PermissionNotPass = 2;
	static WizardGames.Soc.Common.Construction.ECreatePlayerConstructionBlueprintRespCode HasNoBriefDataList = 3;
	static WizardGames.Soc.Common.Construction.ECreatePlayerConstructionBlueprintRespCode PullConstructionDataFailed = 4;
	static WizardGames.Soc.Common.Construction.ECreatePlayerConstructionBlueprintRespCode HasNoBriefData = 5;
	static WizardGames.Soc.Common.Construction.ECreatePlayerConstructionBlueprintRespCode InCD = 6;
	static WizardGames.Soc.Common.Construction.ECreatePlayerConstructionBlueprintRespCode SimulatorCheckFailed = 7;
	static WizardGames.Soc.Common.Construction.ECreatePlayerConstructionBlueprintRespCode ConsumeNotEnough = 8;
	static WizardGames.Soc.Common.Construction.ECreatePlayerConstructionBlueprintRespCode WrongPlayerState = 9;
	static WizardGames.Soc.Common.Construction.ECreatePlayerConstructionBlueprintRespCode SameRequestAlreadyExist = 10;
	static WizardGames.Soc.Common.Construction.ECreatePlayerConstructionBlueprintRespCode StoryUnLock = 11;
	static WizardGames.Soc.Common.Construction.ECreatePlayerConstructionBlueprintRespCode REGION_LOCK = 12;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Construction.EGenerateBlueprintDataRespCode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Construction.EGenerateBlueprintDataRespCode Suc = 0;
	static WizardGames.Soc.Common.Construction.EGenerateBlueprintDataRespCode NoValidTerritory = 1;
	static WizardGames.Soc.Common.Construction.EGenerateBlueprintDataRespCode NotValidSlot = 2;
	static WizardGames.Soc.Common.Construction.EGenerateBlueprintDataRespCode ServerBusy = 3;
	static WizardGames.Soc.Common.Construction.EGenerateBlueprintDataRespCode ServerNoBriefData = 4;
	static WizardGames.Soc.Common.Construction.EGenerateBlueprintDataRespCode PartNumTooLarge = 5;
	static WizardGames.Soc.Common.Construction.EGenerateBlueprintDataRespCode SameSlotSaving = 6;
	static WizardGames.Soc.Common.Construction.EGenerateBlueprintDataRespCode SlotInCD = 7;
	static WizardGames.Soc.Common.Construction.EGenerateBlueprintDataRespCode HasNoPermission = 8;
	static WizardGames.Soc.Common.Construction.EGenerateBlueprintDataRespCode SensitiveWords = 9;
	static WizardGames.Soc.Common.Construction.EGenerateBlueprintDataRespCode SlotUnLock = 10;
	static WizardGames.Soc.Common.Construction.EGenerateBlueprintDataRespCode WrongPlayerState = 11;
	static WizardGames.Soc.Common.Construction.EGenerateBlueprintDataRespCode MissingToolBox = 12;
	static WizardGames.Soc.Common.Construction.EGenerateBlueprintDataRespCode InvalidDistance = 13;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Construction.ETransformPartRespCode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Construction.ETransformPartRespCode Suc = 0;
	static WizardGames.Soc.Common.Construction.ETransformPartRespCode NoPermission = 1;
	static WizardGames.Soc.Common.Construction.ETransformPartRespCode DistanceTooFar = 2;
	static WizardGames.Soc.Common.Construction.ETransformPartRespCode WrongPlayerState = 3;
	static WizardGames.Soc.Common.Construction.ETransformPartRespCode PartNotExist = 4;
	static WizardGames.Soc.Common.Construction.ETransformPartRespCode SimulatorCheckFailed = 5;
	static WizardGames.Soc.Common.Construction.ETransformPartRespCode HasNoBriefData = 6;
	static WizardGames.Soc.Common.Construction.ETransformPartRespCode PullConstructionDataFailed = 7;
	static WizardGames.Soc.Common.Construction.ETransformPartRespCode InvalidTransform = 8;
	static WizardGames.Soc.Common.Construction.ETransformPartRespCode SameRequestAlreadyExist = 9;
	static WizardGames.Soc.Common.Construction.ETransformPartRespCode InCD = 10;
	static WizardGames.Soc.Common.Construction.ETransformPartRespCode OverlapWitchOtherOBB = 11;
	static WizardGames.Soc.Common.Construction.ETransformPartRespCode CanNotFindPart = 12;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.ConstructionSocketHotfix : System.Object
{
	
	static System.Boolean CanConnectCommon(WizardGames.Soc.Common.Construction.ConstructionSocketRuntime self, WizardGames.Soc.Common.Algorithm.Vector3 position, WizardGames.Soc.Common.Framework.Algorithm.Quaternion rotation, WizardGames.Soc.Common.Construction.SocketRuntimeBase socketData, WizardGames.Soc.Common.Algorithm.Vector3 socketPosition, WizardGames.Soc.Common.Framework.Algorithm.Quaternion socketRotation); // 0x06d8eb24
	static System.Boolean IsCompatibleCommon(WizardGames.Soc.Common.Construction.ConstructionSocketRuntime self, WizardGames.Soc.Common.Construction.SocketRuntimeBase socketData); // 0x06d8efe0
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.NeighbourSocketHotfix : System.Object
{
	
	static System.Boolean CanConnectCommon(WizardGames.Soc.Common.Construction.NeighbourSocketRuntime self, WizardGames.Soc.Common.Algorithm.Vector3 position, WizardGames.Soc.Common.Framework.Algorithm.Quaternion rotation, WizardGames.Soc.Common.Construction.SocketRuntimeBase socketData, WizardGames.Soc.Common.Algorithm.Vector3 socketPosition, WizardGames.Soc.Common.Framework.Algorithm.Quaternion socketRotation); // 0x06d8f0fc
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.StabilitySocketHotfix : System.Object
{
	
	static System.Boolean CanConnectCommon(WizardGames.Soc.Common.Construction.StabilitySocketRuntime self, WizardGames.Soc.Common.Algorithm.Vector3 position, WizardGames.Soc.Common.Framework.Algorithm.Quaternion rotation, WizardGames.Soc.Common.Construction.SocketRuntimeBase socketData, WizardGames.Soc.Common.Algorithm.Vector3 socketPosition, WizardGames.Soc.Common.Framework.Algorithm.Quaternion socketRotation); // 0x06d8f41c
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.ConstructionConsumeUtils : System.Object
{
	static SocLogger logger; // 0x0
	static System.Void MergeConsume(System.Collections.Generic.IDictionary<System.Int64,System.Int32> costTotal, System.Collections.Generic.IDictionary<System.Int64,System.Int32> consume); // 0x06d8f73c
	static System.Void RemoveConsume(System.Collections.Generic.IDictionary<System.Int64,System.Int32> costTotal, System.Collections.Generic.IDictionary<System.Int64,System.Int32> consume); // 0x06d8fc38
	static System.Void CopyConsume(System.Collections.Generic.IDictionary<System.Int64,System.Int32> origin, System.Collections.Generic.IDictionary<System.Int64,System.Int32> target); // 0x06d90200
	static System.Boolean CalcRepairHP(WizardGames.Soc.Common.Entity.PartEntity partEntity, System.Single& healthMissing, System.Single& healthMissingFraction); // 0x06d9060c
	static System.Single MaxHealthHp(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06d90ac0
	static System.Collections.Generic.Dictionary<System.Int64,System.Int32> GetRepairConsume(System.Single healthMissingFraction, System.Int64 partType, System.Int64 grade); // 0x06d90de4
	static System.Collections.Generic.Dictionary<System.Int64,System.Single> GetRepairMaterial(System.Int64 partType, System.Int64 grade); // 0x06d91154
	static System.Collections.Generic.List<WizardGames.Soc.Common.Construction.ItemCostAmount> RepairCost(System.Single healthMissingFraction, System.Int64 partType, System.Int32 grade); // 0x06d91e30
	static System.Collections.Generic.Dictionary<System.Int64,System.Int32> GetBuildConsume(System.Int64 partType, System.Int64 grade); // 0x06d921d4
	static System.Void GetBuildConsume(System.Int64 partType, System.Int64 grade, System.Collections.Generic.Dictionary<System.Int64,System.Int32> itemCost); // 0x06d922bc
	static System.Void GetBuildConsume(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.ConstructionBlueprintSaveData> blueprintSaveData, System.Collections.Generic.Dictionary<System.Int64,System.Int32> itemCost, System.Boolean ignoreToolCupboard); // 0x06d925dc
	static System.Collections.Generic.List<WizardGames.Soc.Common.Construction.ItemCostAmount> GetConstructionBuildCost(System.Int64 partTemplateId, System.Int32 grade); // 0x06d916e0
	static System.Collections.Generic.Dictionary<System.Int64,System.Int32> GetComboBuildConsume(System.Int64 comboId, System.Int32 grade, System.Boolean isUpgrade); // 0x06d92ab4
	static System.Collections.Generic.Dictionary<System.Int64,System.Int32> GetComboChildBuildConsume(System.Int64 childComboPartType); // 0x06d92ff0
	static System.Collections.Generic.Dictionary<System.Int64,System.Int32> GetConsumeDictFromList(System.Collections.Generic.List<WizardGames.Soc.Common.Construction.ItemCostAmount> list, System.Int32 count); // 0x06d933f0
	static System.Void GetConsumeDictFromList(System.Collections.Generic.List<WizardGames.Soc.Common.Construction.ItemCostAmount> list, System.Collections.Generic.Dictionary<System.Int64,System.Int32> consume, System.Int32 count); // 0x06d934d8
	static System.Collections.Generic.Dictionary<System.Int64,System.Int32> GetNoneCorePartUpgradeCost(System.Int64 templateId); // 0x06d937a4
	static System.Collections.Generic.Dictionary<System.Int64,System.Int32> GetTransformationConsume(System.Int64 curParentEntityId, System.Int64 targetParentType, System.Int32 targetParentGrade, System.Int64 targetComboChildGroupId, System.UInt32 usedTimes); // 0x06d939b4
	static System.Collections.Generic.Dictionary<System.Int64,System.Int32> GetPartChangeConsume(System.Int64 curParentEntityId, System.Int64 targetParentType, System.Int32 targetParentGrade, System.Int64 targetComboChildGroupId); // 0x06d93e38
	static System.Collections.Generic.Dictionary<System.Int64,System.Int32> GetPartChangeConsume(System.Int64 curParentType, System.Int32 curParentGrade, System.Int64 targetParentType, System.Int32 targetParentGrade, System.Collections.Generic.List<System.Int64> curAliveChildTypeList, System.Int64 targetComboChildGroupId); // 0x06d944a8
	static System.Void .cctor(); // 0x06d95074
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.ConstructionUtils : System.Object
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.HashSet<WizardGames.Soc.Common.Construction.PartType> needSplicingPartAfterLoadSet; // 0x8
	static System.Boolean get_BEnableLinkLog(); // 0x06d95148
	static WizardGames.Soc.Common.Entity.PartEntity GetPartEntityByEntityID(System.Int64 entityId); // 0x06d951a4
	static System.Boolean IsCoreConstruction(System.Int64 partTemplateId); // 0x06d95244
	static System.Void FindNearbyParts(WizardGames.Soc.Common.Algorithm.Vector3 pos, System.Single radius, System.Collections.Generic.List<System.Int64>& partIdList, System.Int64 ignoreEntityId); // 0x06d95344
	static System.Boolean IsWallTypePart(System.Int64 tempId); // 0x06d95474
	static System.Boolean IsWallTypePart(WizardGames.Soc.Common.Construction.PartType partType); // 0x06d954fc
	static System.Boolean CheckWildPartTypeLimit(WizardGames.Soc.Common.CustomType.PartLimitInfo partLimitInfo, System.Int64 templateId, System.Int32 addCount); // 0x06d95578
	static System.Boolean CheckTerrPartTypeLimit(WizardGames.Soc.Common.CustomType.PartLimitInfo partLimitInfo, System.Int64 templateId, System.Int32 addCount); // 0x06d9599c
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Construction.SocketRuntimeBase> GetOneSideLinks(WizardGames.Soc.Common.Component.ConstructionSocketBaseComponent originSocketComp, WizardGames.Soc.Common.Entity.PartEntity other, System.Int32 idx); // 0x06d95dc0
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Construction.SocketRuntimeBase> GetSocketsBySide(WizardGames.Soc.Common.Component.ConstructionSocketBaseComponent socketBaseComponent, WizardGames.Soc.Common.Construction.ESocketSide side, System.Int32 idx); // 0x06d96a4c
	static System.Boolean CheckPersonalCount(WizardGames.Soc.Common.CustomType.PartLimitInfo partLimitInfo, System.Int64 templateId, System.Int32 addCount); // 0x06d96d20
	static System.Int32 GetWildPartTypeLimit(System.Int64 templateId); // 0x06d97148
	static System.Int32 GetTerrPartTypeLimit(System.Int64 templateId); // 0x06d974b4
	static System.Int32 GetPersonalPartTypeLimit(System.Int64 templateId); // 0x06d97820
	static System.Int64 FindComboTargetGroup(System.Int64 groupId, System.Int32 targetGrade); // 0x06d97b8c
	static System.Int32 DecodeGradeCombo(System.Int64 comboId, System.Int32 key, System.Collections.Generic.List<System.Int64> notExistPart, System.Collections.Generic.List<System.Int64> existPart); // 0x06d97f78
	static System.Void .cctor(); // 0x06d981fc
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.DecayUtil : System.Object
{
	static System.Collections.Generic.List<System.Single> blocksTaxPaid; // 0x0
	static System.Int32 get_BracketsLength(); // 0x06d98354
	static System.Void CalculateUpkeepCostAmounts(System.Int64 template, System.Int32 grade, System.Collections.Generic.Dictionary<System.Int64,System.Single> itemAmounts, System.Single multiplier); // 0x06d984dc
	static System.Single CalculateUpkeepCostFraction(System.Int32 corePartCount); // 0x06d988e0
	static System.Single CalculateBuildingTaxRate(System.Int32 corePartCount); // 0x06d98968
	static System.Void .cctor(); // 0x06d98e08
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.WorkBenchUtil : System.Object
{
	static System.Collections.Generic.List<System.Int32> WorkbenchPartIds; // 0x0
	static System.Collections.Generic.List<System.Int32> WorkbenchLevelInteractionId; // 0x8
	static System.Int32 HighestLevel; // 0x10
	static System.Int32 TemplateIdToLevel(System.Int64 partId); // 0x06d98ea0
	static System.Boolean IsWorkBench(System.Int32 partTemplateId); // 0x06d98fb8
	static System.Void .cctor(); // 0x06d9906c
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.WardrobeHelper : System.Object
{
	
	static System.Int32 GetWearIndexBySlot(System.Int32 slotIndex); // 0x06d993c4
	static System.Int32 GetBeltIndexBySlot(System.Int32 slotIndex); // 0x06d99428
	static System.Int32 GetCommonIndexBySlot(System.Int32 slotIndex); // 0x06d99490
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.PermissionConst : System.Object
{
	static System.Collections.Generic.Dictionary<System.Int32,System.UInt64> PermissionGroupMask; // 0x0
	static System.Void .cctor(); // 0x06d994f8
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.BaseAttr : System.Attribute
{
	
	System.Void .ctor(); // 0x06d995fc
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.SocketModAttribute : WizardGames.Soc.Common.Construction.BaseAttr
{
	WizardGames.Soc.Common.Construction.SocketModType type; // 0x10
	System.Void .ctor(WizardGames.Soc.Common.Construction.SocketModType type); // 0x06d99664
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.CheckConfigBaseJson : System.Object
{
	System.Int32 CheckConfigType; // 0x10
	System.Double PosX; // 0x18
	System.Double PosY; // 0x20
	System.Double PosZ; // 0x28
	System.Double RotateX; // 0x30
	System.Double RotateY; // 0x38
	System.Double RotateZ; // 0x40
	System.Int32 ErrorPhrase; // 0x48
	System.Int32 LayerMask; // 0x4c
	System.Boolean WantsHit; // 0x50
	System.Int32 PveErrorPhase; // 0x54
	System.Single CheckDistance; // 0x58
	System.Boolean WantsInside; // 0x5c
	System.Double BoundsCenterX; // 0x60
	System.Double BoundsCenterY; // 0x68
	System.Double BoundsCenterZ; // 0x70
	System.Double BoundsExtendsX; // 0x78
	System.Double BoundsExtendsY; // 0x80
	System.Double BoundsExtendsZ; // 0x88
	System.Void .ctor(); // 0x06d996e4
}

// Client.Runtime
enum WizardGames.Soc.Common.Construction.InvalidBuildReason : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Construction.InvalidBuildReason SimulatorBug = -1;
	static WizardGames.Soc.Common.Construction.InvalidBuildReason None = 0;
	static WizardGames.Soc.Common.Construction.InvalidBuildReason TooCloseToRoad = 1;
	static WizardGames.Soc.Common.Construction.InvalidBuildReason TooFarToOwner = 2;
	static WizardGames.Soc.Common.Construction.InvalidBuildReason HasNoPermission = 3;
	static WizardGames.Soc.Common.Construction.InvalidBuildReason OverlapWitchOtherOBB = 4;
	static WizardGames.Soc.Common.Construction.InvalidBuildReason GroundWatch = 5;
	static WizardGames.Soc.Common.Construction.InvalidBuildReason Proximity = 6;
	static WizardGames.Soc.Common.Construction.InvalidBuildReason SocketMod = 7;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Construction.ECreatePartRespCode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Construction.ECreatePartRespCode Success = 0;
	static WizardGames.Soc.Common.Construction.ECreatePartRespCode ConfigMissing = 1;
	static WizardGames.Soc.Common.Construction.ECreatePartRespCode CampingTentNotUnlocked = 2;
	static WizardGames.Soc.Common.Construction.ECreatePartRespCode CampingTentInCd = 3;
	static WizardGames.Soc.Common.Construction.ECreatePartRespCode CampingTentSafeTimeFailed = 4;
	static WizardGames.Soc.Common.Construction.ECreatePartRespCode InvalidGrade = 5;
	static WizardGames.Soc.Common.Construction.ECreatePartRespCode ConsumeFailed = 6;
	static WizardGames.Soc.Common.Construction.ECreatePartRespCode ServerCreateEntityFailed = 7;
	static WizardGames.Soc.Common.Construction.ECreatePartRespCode RegionLock = 8;
	static WizardGames.Soc.Common.Construction.ECreatePartRespCode InvalidDistance = 9;
	static WizardGames.Soc.Common.Construction.ECreatePartRespCode LightLimit = 10;
	static WizardGames.Soc.Common.Construction.ECreatePartRespCode PermissionCheckFailed = 11;
	static WizardGames.Soc.Common.Construction.ECreatePartRespCode SimulatorCheckFailed = 12;
	static WizardGames.Soc.Common.Construction.ECreatePartRespCode OverLimit = 13;
	static WizardGames.Soc.Common.Construction.ECreatePartRespCode CanNotCaptureDeadSheep = 14;
	static WizardGames.Soc.Common.Construction.ECreatePartRespCode ToolboxConflict = 15;
	static WizardGames.Soc.Common.Construction.ECreatePartRespCode SingleSkinLimit = 16;
	static WizardGames.Soc.Common.Construction.ECreatePartRespCode TerritorySkinLimit = 17;
	static WizardGames.Soc.Common.Construction.ECreatePartRespCode InBatchRecovering = 18;
	static WizardGames.Soc.Common.Construction.ECreatePartRespCode SocketCheckFailed = 19;
	static WizardGames.Soc.Common.Construction.ECreatePartRespCode GlobalMonsterCountLimit = 20;
	static WizardGames.Soc.Common.Construction.ECreatePartRespCode SimulatorNotReady = 21;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Construction.ERequestDeployVehicleRespCode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Construction.ERequestDeployVehicleRespCode Success = 0;
	static WizardGames.Soc.Common.Construction.ERequestDeployVehicleRespCode InvalidVehicleData = 1;
	static WizardGames.Soc.Common.Construction.ERequestDeployVehicleRespCode VehicleNumLimit = 2;
	static WizardGames.Soc.Common.Construction.ERequestDeployVehicleRespCode NoPermission = 3;
	static WizardGames.Soc.Common.Construction.ERequestDeployVehicleRespCode DistanceTooFar = 4;
	static WizardGames.Soc.Common.Construction.ERequestDeployVehicleRespCode WrongPlayerState = 5;
	static WizardGames.Soc.Common.Construction.ERequestDeployVehicleRespCode WrongPlayerData = 6;
	static WizardGames.Soc.Common.Construction.ERequestDeployVehicleRespCode SimulatorCheckFailed = 7;
	static WizardGames.Soc.Common.Construction.ERequestDeployVehicleRespCode CostNotEnough = 8;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.ConstructionRequestErrorCode : System.Object
{
	
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Construction.ConstructionRequestErrorCode.ESwitchToolBoxErrorCode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Construction.ConstructionRequestErrorCode.ESwitchToolBoxErrorCode Success = 0;
	static WizardGames.Soc.Common.Construction.ConstructionRequestErrorCode.ESwitchToolBoxErrorCode NotInReputationMode = 1;
	static WizardGames.Soc.Common.Construction.ConstructionRequestErrorCode.ESwitchToolBoxErrorCode CannotFindToolbox = 2;
	static WizardGames.Soc.Common.Construction.ConstructionRequestErrorCode.ESwitchToolBoxErrorCode HasOtherReputationBox = 3;
	static WizardGames.Soc.Common.Construction.ConstructionRequestErrorCode.ESwitchToolBoxErrorCode ToolboxNoPermissionModule = 4;
	static WizardGames.Soc.Common.Construction.ConstructionRequestErrorCode.ESwitchToolBoxErrorCode NotCaptain = 5;
	static WizardGames.Soc.Common.Construction.ConstructionRequestErrorCode.ESwitchToolBoxErrorCode InActivateCD = 6;
	static WizardGames.Soc.Common.Construction.ConstructionRequestErrorCode.ESwitchToolBoxErrorCode HaveReputationItems = 7;
	static WizardGames.Soc.Common.Construction.ConstructionRequestErrorCode.ESwitchToolBoxErrorCode SouDaJianDisabled = 8;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Construction.ConstructionRequestErrorCode.EAutoCreateToolboxAndSwitchToReputationModeErrorCode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Construction.ConstructionRequestErrorCode.EAutoCreateToolboxAndSwitchToReputationModeErrorCode Success = 0;
	static WizardGames.Soc.Common.Construction.ConstructionRequestErrorCode.EAutoCreateToolboxAndSwitchToReputationModeErrorCode CreateFailed_NearCoreConstruction = 1;
	static WizardGames.Soc.Common.Construction.ConstructionRequestErrorCode.EAutoCreateToolboxAndSwitchToReputationModeErrorCode CreateFailed_NearOtherToolbox = 2;
	static WizardGames.Soc.Common.Construction.ConstructionRequestErrorCode.EAutoCreateToolboxAndSwitchToReputationModeErrorCode CreateFailed_NoSwitchPermission = 3;
	static WizardGames.Soc.Common.Construction.ConstructionRequestErrorCode.EAutoCreateToolboxAndSwitchToReputationModeErrorCode CreateFailed_ExistTheOtherOne = 4;
	static WizardGames.Soc.Common.Construction.ConstructionRequestErrorCode.EAutoCreateToolboxAndSwitchToReputationModeErrorCode SwitchModeFailed = 5;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.ConstructionUtilsData : System.Object
{
	static System.Single MAX_BUILD_DISTANCE; // 0x0
	static SocLogger logger; // 0x8
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Construction.SocketRuntimeBase>[] tempLinkDic; // 0x10
	static System.Collections.Generic.HashSet<WizardGames.Soc.Common.Construction.PartType> PartsNeedFireEffectComp; // 0x18
	static WizardGames.Soc.Common.Construction.SocketConfigData GetSocketConfigData(System.Int64 partTemplateId, System.Int64 skinId, System.Int32 socketId); // 0x06d8da48
	static System.Void .cctor(); // 0x06d9974c
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.ItemCostAmount : System.Object
{
	System.Int64 templateId; // 0x10
	System.Single amount; // 0x18
	System.Void .ctor(System.Int64 id, System.Single amount); // 0x06d92138
}

// Client.Runtime
enum WizardGames.Soc.Common.Construction.ConstructionPartType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Construction.ConstructionPartType None = 0;
	static WizardGames.Soc.Common.Construction.ConstructionPartType Core = 1;
	static WizardGames.Soc.Common.Construction.ConstructionPartType Building = 2;
	static WizardGames.Soc.Common.Construction.ConstructionPartType Deploy = 3;
	static WizardGames.Soc.Common.Construction.ConstructionPartType Lock = 4;
	static WizardGames.Soc.Common.Construction.ConstructionPartType Electric = 5;
	static WizardGames.Soc.Common.Construction.ConstructionPartType Water = 6;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Construction.ConstructionGrade : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Construction.ConstructionGrade Default = 0;
	static WizardGames.Soc.Common.Construction.ConstructionGrade Twig = 1;
	static WizardGames.Soc.Common.Construction.ConstructionGrade Wood = 2;
	static WizardGames.Soc.Common.Construction.ConstructionGrade Stone = 3;
	static WizardGames.Soc.Common.Construction.ConstructionGrade Metal = 4;
	static WizardGames.Soc.Common.Construction.ConstructionGrade Toptier = 5;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Construction.SocketModType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Construction.SocketModType Base = 0;
	static WizardGames.Soc.Common.Construction.SocketModType TerrainCheck = 1;
	static WizardGames.Soc.Common.Construction.SocketModType AngleCheck = 2;
	static WizardGames.Soc.Common.Construction.SocketModType AreaCheck = 3;
	static WizardGames.Soc.Common.Construction.SocketModType Attaction = 4;
	static WizardGames.Soc.Common.Construction.SocketModType InWater = 5;
	static WizardGames.Soc.Common.Construction.SocketModType LockSlot = 6;
	static WizardGames.Soc.Common.Construction.SocketModType NotInDoor = 7;
	static WizardGames.Soc.Common.Construction.SocketModType SphereCheck = 8;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.ConstructionEntityFlags : System.Object
{
	
	static System.Boolean HasFlag(System.Int32 flag, WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags f); // 0x06d99a2c
	static System.Int32 SetFlag(System.Int32 flag, WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags f, System.Boolean b); // 0x06d99aa8
	static System.Boolean IsOpen(System.Int32 flag); // 0x06d99b34
}

// Client.Runtime
enum WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags Placeholder = 1;
	static WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags On = 2;
	static WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags OnFire = 4;
	static WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags Open = 8;
	static WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags Locked = 16;
	static WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags Debugging = 32;
	static WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags Disabled = 64;
	static WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags Reserved1 = 128;
	static WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags Reserved2 = 256;
	static WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags Reserved3 = 512;
	static WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags Reserved4 = 1024;
	static WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags Reserved5 = 2048;
	static WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags Broken = 4096;
	static WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags Busy = 8192;
	static WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags Reserved6 = 16384;
	static WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags IsShortCircuit = 32768;
	static WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags ElectricHasPower = 65536;
	static WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags FluidicHasWater = 131072;
	static WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags Reserved10 = 262144;
	static WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags Reserved11 = 524288;
	static WizardGames.Soc.Common.Construction.ConstructionEntityFlags.Flags Working = 1048576;
	
}

// Client.Runtime
interface WizardGames.Soc.Common.Construction.IChangeTransform : 
{
	
	System.Void OnTransformChanged(); // 0x055049cc
}

// Client.Runtime
enum WizardGames.Soc.Common.Construction.PartType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Construction.PartType None = 0;
	static WizardGames.Soc.Common.Construction.PartType Foundation = 1;
	static WizardGames.Soc.Common.Construction.PartType FoundationTriangle = 2;
	static WizardGames.Soc.Common.Construction.PartType FoundationSteps = 3;
	static WizardGames.Soc.Common.Construction.PartType Ramp = 4;
	static WizardGames.Soc.Common.Construction.PartType Floor = 5;
	static WizardGames.Soc.Common.Construction.PartType FloorTriangle = 6;
	static WizardGames.Soc.Common.Construction.PartType FloorFrame = 7;
	static WizardGames.Soc.Common.Construction.PartType FloorTriangleFrame = 8;
	static WizardGames.Soc.Common.Construction.PartType Wall = 9;
	static WizardGames.Soc.Common.Construction.PartType WallDoorway = 10;
	static WizardGames.Soc.Common.Construction.PartType WallWindow = 11;
	static WizardGames.Soc.Common.Construction.PartType WallFrame = 12;
	static WizardGames.Soc.Common.Construction.PartType WallHalf = 13;
	static WizardGames.Soc.Common.Construction.PartType WallLow = 14;
	static WizardGames.Soc.Common.Construction.PartType StairsU = 15;
	static WizardGames.Soc.Common.Construction.PartType StairsL = 16;
	static WizardGames.Soc.Common.Construction.PartType StairsSpiral = 17;
	static WizardGames.Soc.Common.Construction.PartType StairsSpiralTriangle = 18;
	static WizardGames.Soc.Common.Construction.PartType RoofTriangle = 19;
	static WizardGames.Soc.Common.Construction.PartType Roof = 20;
	static WizardGames.Soc.Common.Construction.PartType WoodDoor5001 = 5001;
	static WizardGames.Soc.Common.Construction.PartType WoodDoor5002 = 5002;
	static WizardGames.Soc.Common.Construction.PartType WoodDoor5003 = 5003;
	static WizardGames.Soc.Common.Construction.PartType MetalDoor5004 = 5004;
	static WizardGames.Soc.Common.Construction.PartType ArmoredDoor5005 = 5005;
	static WizardGames.Soc.Common.Construction.PartType DoubleWoodDoor5006 = 5006;
	static WizardGames.Soc.Common.Construction.PartType DoubleWoodDoor5007 = 5007;
	static WizardGames.Soc.Common.Construction.PartType DoubleWoodDoor5008 = 5008;
	static WizardGames.Soc.Common.Construction.PartType DoubleMetalDoor5009 = 5009;
	static WizardGames.Soc.Common.Construction.PartType ArmoredDoubleDoor5010 = 5010;
	static WizardGames.Soc.Common.Construction.PartType MetalHorizontalEmbrasure5011 = 5011;
	static WizardGames.Soc.Common.Construction.PartType MetalHorizontalEmbrasure5012 = 5012;
	static WizardGames.Soc.Common.Construction.PartType MetalHorizontalEmbrasure5013 = 5013;
	static WizardGames.Soc.Common.Construction.PartType MetalHorizontalEmbrasure5014 = 5014;
	static WizardGames.Soc.Common.Construction.PartType MetalHorizontalEmbrasure5015 = 5015;
	static WizardGames.Soc.Common.Construction.PartType MetalVerticalEmbrasure5016 = 5016;
	static WizardGames.Soc.Common.Construction.PartType MetalVerticalEmbrasure5017 = 5017;
	static WizardGames.Soc.Common.Construction.PartType MetalVerticalEmbrasure5018 = 5018;
	static WizardGames.Soc.Common.Construction.PartType MetalVerticalEmbrasure5019 = 5019;
	static WizardGames.Soc.Common.Construction.PartType MetalVerticalEmbrasure5020 = 5020;
	static WizardGames.Soc.Common.Construction.PartType WoodDoor = 10010002;
	static WizardGames.Soc.Common.Construction.PartType DoubleWoodDoor = 10010003;
	static WizardGames.Soc.Common.Construction.PartType ToolCupboard = 10010004;
	static WizardGames.Soc.Common.Construction.PartType MetalDoor = 10010005;
	static WizardGames.Soc.Common.Construction.PartType DoubleMetalDoor = 10010006;
	static WizardGames.Soc.Common.Construction.PartType CodeLock = 10010007;
	static WizardGames.Soc.Common.Construction.PartType WoodenLadder = 10010008;
	static WizardGames.Soc.Common.Construction.PartType WoodenBarricade = 10010009;
	static WizardGames.Soc.Common.Construction.PartType MetalBarricade = 10010010;
	static WizardGames.Soc.Common.Construction.PartType WoodenBarricadeCover = 10010011;
	static WizardGames.Soc.Common.Construction.PartType HighExternalWoodenGate = 10010012;
	static WizardGames.Soc.Common.Construction.PartType HighExternalWoodenWall = 10010013;
	static WizardGames.Soc.Common.Construction.PartType HighExternalStoneGate = 10010014;
	static WizardGames.Soc.Common.Construction.PartType HighExternalStoneWall = 10010015;
	static WizardGames.Soc.Common.Construction.PartType PrisonCellGate = 10010016;
	static WizardGames.Soc.Common.Construction.PartType PrisonCellWall = 10010017;
	static WizardGames.Soc.Common.Construction.PartType MetalHorizontalEmbrasure = 10010018;
	static WizardGames.Soc.Common.Construction.PartType MetalVerticalEmbrasure = 10010019;
	static WizardGames.Soc.Common.Construction.PartType ArmoredDoor = 10010020;
	static WizardGames.Soc.Common.Construction.PartType KeyLock = 10010021;
	static WizardGames.Soc.Common.Construction.PartType ArmoredDoubleDoor = 10010022;
	static WizardGames.Soc.Common.Construction.PartType GarageDoor = 10010023;
	static WizardGames.Soc.Common.Construction.PartType WoodShutters = 10010025;
	static WizardGames.Soc.Common.Construction.PartType StrengthenedGlassWindow = 10010026;
	static WizardGames.Soc.Common.Construction.PartType ReinforcedGlassWindow = 10010027;
	static WizardGames.Soc.Common.Construction.PartType MetalWindowBars = 10010028;
	static WizardGames.Soc.Common.Construction.PartType WoodenWindowBars = 10010029;
	static WizardGames.Soc.Common.Construction.PartType FloorGrill = 10010030;
	static WizardGames.Soc.Common.Construction.PartType FloorTriangleGrill = 10010031;
	static WizardGames.Soc.Common.Construction.PartType ChainlinkFence = 10010032;
	static WizardGames.Soc.Common.Construction.PartType ChainlinkFenceGate = 10010033;
	static WizardGames.Soc.Common.Construction.PartType ShopFront = 10010034;
	static WizardGames.Soc.Common.Construction.PartType MetalShopFront = 10010035;
	static WizardGames.Soc.Common.Construction.PartType BarbedWoodenBarricade = 10010036;
	static WizardGames.Soc.Common.Construction.PartType SandbagBarricade = 10010037;
	static WizardGames.Soc.Common.Construction.PartType ConcreteBarricade = 10010038;
	static WizardGames.Soc.Common.Construction.PartType StoneBarricade = 10010039;
	static WizardGames.Soc.Common.Construction.PartType Netting = 10010040;
	static WizardGames.Soc.Common.Construction.PartType LadderHatch = 10010041;
	static WizardGames.Soc.Common.Construction.PartType TriangleLadderHatch = 10010042;
	static WizardGames.Soc.Common.Construction.PartType WatchTower = 10010043;
	static WizardGames.Soc.Common.Construction.PartType HonorFurnace = 10010044;
	static WizardGames.Soc.Common.Construction.PartType WoodenFloorSpikes = 10010045;
	static WizardGames.Soc.Common.Construction.PartType WatchTower_v1 = 10010046;
	static WizardGames.Soc.Common.Construction.PartType Furnace = 11010001;
	static WizardGames.Soc.Common.Construction.PartType OilRefinery = 11010002;
	static WizardGames.Soc.Common.Construction.PartType Campfire = 11010003;
	static WizardGames.Soc.Common.Construction.PartType Tier1WorkBench = 11010004;
	static WizardGames.Soc.Common.Construction.PartType Tier2WorkBench = 11010005;
	static WizardGames.Soc.Common.Construction.PartType Tier3WorkBench = 11010006;
	static WizardGames.Soc.Common.Construction.PartType WoodStorageBox = 11010007;
	static WizardGames.Soc.Common.Construction.PartType LargeWoodBox = 11010008;
	static WizardGames.Soc.Common.Construction.PartType FurnaceLarge = 11010009;
	static WizardGames.Soc.Common.Construction.PartType HoboBarrel = 11010010;
	static WizardGames.Soc.Common.Construction.PartType StoneFireplace = 11010011;
	static WizardGames.Soc.Common.Construction.PartType Barbeque = 11010012;
	static WizardGames.Soc.Common.Construction.PartType Recycler = 11010013;
	static WizardGames.Soc.Common.Construction.PartType SleepingBag = 11010014;
	static WizardGames.Soc.Common.Construction.PartType ResearchTable = 11010015;
	static WizardGames.Soc.Common.Construction.PartType MixingTable = 11010016;
	static WizardGames.Soc.Common.Construction.PartType RepairBench = 11010017;
	static WizardGames.Soc.Common.Construction.PartType SmallWaterCatcher = 11010018;
	static WizardGames.Soc.Common.Construction.PartType LargeWaterCatcher = 11010019;
	static WizardGames.Soc.Common.Construction.PartType WoodenBed = 11010020;
	static WizardGames.Soc.Common.Construction.PartType WoodStorageBox_v1 = 11010028;
	static WizardGames.Soc.Common.Construction.PartType LargeWoodBox_v1 = 11010029;
	static WizardGames.Soc.Common.Construction.PartType LargePlanterBox = 11010030;
	static WizardGames.Soc.Common.Construction.PartType SmallPlanterBox = 11010031;
	static WizardGames.Soc.Common.Construction.PartType Composter = 11010032;
	static WizardGames.Soc.Common.Construction.PartType FluidCombiner = 11010034;
	static WizardGames.Soc.Common.Construction.PartType FluidSplitter = 11010035;
	static WizardGames.Soc.Common.Construction.PartType WaterBarrel = 11010036;
	static WizardGames.Soc.Common.Construction.PartType VendingMachine = 11010038;
	static WizardGames.Soc.Common.Construction.PartType Rug = 11010039;
	static WizardGames.Soc.Common.Construction.PartType HitchTrough = 11010040;
	static WizardGames.Soc.Common.Construction.PartType FlameTurret = 11010041;
	static WizardGames.Soc.Common.Construction.PartType ShotgunTrap = 11010042;
	static WizardGames.Soc.Common.Construction.PartType Locker = 11010044;
	static WizardGames.Soc.Common.Construction.PartType FurnaceSeahorse = 11010045;
	static WizardGames.Soc.Common.Construction.PartType LargeWoodBoxSasanian = 11010046;
	static WizardGames.Soc.Common.Construction.PartType LargeWoodBoxCyberRevolution = 11010047;
	static WizardGames.Soc.Common.Construction.PartType FurnaceShark = 11010048;
	static WizardGames.Soc.Common.Construction.PartType LargeWoodBoxCrab = 11010049;
	static WizardGames.Soc.Common.Construction.PartType SleepingBagSeahare = 11010050;
	static WizardGames.Soc.Common.Construction.PartType ResearchTable_v1 = 11010051;
	static WizardGames.Soc.Common.Construction.PartType RepairBench_v1 = 11010052;
	static WizardGames.Soc.Common.Construction.PartType Tier1WorkBench_v1 = 11010053;
	static WizardGames.Soc.Common.Construction.PartType Tier2WorkBench_v1 = 11010054;
	static WizardGames.Soc.Common.Construction.PartType Tier3WorkBench_v1 = 11010055;
	static WizardGames.Soc.Common.Construction.PartType HoboBarrel_v1 = 11010056;
	static WizardGames.Soc.Common.Construction.PartType OilRefinery_v1 = 11010057;
	static WizardGames.Soc.Common.Construction.PartType Recycler_v1 = 11010058;
	static WizardGames.Soc.Common.Construction.PartType RugBearSkin = 11010059;
	static WizardGames.Soc.Common.Construction.PartType CampingTent = 11010060;
	static WizardGames.Soc.Common.Construction.PartType SmallStash = 11010061;
	static WizardGames.Soc.Common.Construction.PartType Lantern = 11010062;
	static WizardGames.Soc.Common.Construction.PartType LargeFreeCampsiteFlag = 11010063;
	static WizardGames.Soc.Common.Construction.PartType CollisionTrigger = 11010064;
	static WizardGames.Soc.Common.Construction.PartType GMExportAnchor = 11010065;
	static WizardGames.Soc.Common.Construction.PartType WarDrums = 11010066;
	static WizardGames.Soc.Common.Construction.PartType BattleFlag = 11010067;
	static WizardGames.Soc.Common.Construction.PartType TestGenerator = 19010001;
	static WizardGames.Soc.Common.Construction.PartType WindTurbine = 19010002;
	static WizardGames.Soc.Common.Construction.PartType LargeSolarPanel = 19010003;
	static WizardGames.Soc.Common.Construction.PartType SmallGenerator = 19010004;
	static WizardGames.Soc.Common.Construction.PartType LargeRechargeableBattery = 19010005;
	static WizardGames.Soc.Common.Construction.PartType MediumRechargeableBattery = 19010006;
	static WizardGames.Soc.Common.Construction.PartType SmallRechargeableBattery = 19010007;
	static WizardGames.Soc.Common.Construction.PartType DebrisWall = 19010009;
	static WizardGames.Soc.Common.Construction.PartType CommonPartDebris = 19010010;
	static WizardGames.Soc.Common.Construction.PartType CommonPartStoneDebris = 19010011;
	static WizardGames.Soc.Common.Construction.PartType Switch = 19020001;
	static WizardGames.Soc.Common.Construction.PartType ElectricalBranch = 19020002;
	static WizardGames.Soc.Common.Construction.PartType Blocker = 19020003;
	static WizardGames.Soc.Common.Construction.PartType RootCombiner = 19020004;
	static WizardGames.Soc.Common.Construction.PartType ORSwitch = 19020005;
	static WizardGames.Soc.Common.Construction.PartType Splitter = 19020006;
	static WizardGames.Soc.Common.Construction.PartType MemoryCell = 19020007;
	static WizardGames.Soc.Common.Construction.PartType RANDSwitch = 19020008;
	static WizardGames.Soc.Common.Construction.PartType Button = 19020009;
	static WizardGames.Soc.Common.Construction.PartType Counter = 19020010;
	static WizardGames.Soc.Common.Construction.PartType IntelligentBranch = 19020011;
	static WizardGames.Soc.Common.Construction.PartType TestIC = 19020012;
	static WizardGames.Soc.Common.Construction.PartType Timer = 19020013;
	static WizardGames.Soc.Common.Construction.PartType ANDSwitch = 19020014;
	static WizardGames.Soc.Common.Construction.PartType XORSwitch = 19020015;
	static WizardGames.Soc.Common.Construction.PartType MultiportCombiner = 19020016;
	static WizardGames.Soc.Common.Construction.PartType MultiportBranch = 19020017;
	static WizardGames.Soc.Common.Construction.PartType TimeSwitch = 19020018;
	static WizardGames.Soc.Common.Construction.PartType BackupFuelPowerIC = 19020019;
	static WizardGames.Soc.Common.Construction.PartType CeilingLight = 19030001;
	static WizardGames.Soc.Common.Construction.PartType AutoTurret = 19030002;
	static WizardGames.Soc.Common.Construction.PartType SirenLight = 19030003;
	static WizardGames.Soc.Common.Construction.PartType ElectricHeater = 19030004;
	static WizardGames.Soc.Common.Construction.PartType DeluxeChristmasLights = 19030005;
	static WizardGames.Soc.Common.Construction.PartType DoorController = 19030006;
	static WizardGames.Soc.Common.Construction.PartType ElectricFurnace = 19030007;
	static WizardGames.Soc.Common.Construction.PartType FlasherLight = 19030008;
	static WizardGames.Soc.Common.Construction.PartType IndustrialWallLight = 19030009;
	static WizardGames.Soc.Common.Construction.PartType GreenIndustrialWallLight = 19030010;
	static WizardGames.Soc.Common.Construction.PartType RedIndustrialWallLight = 19030011;
	static WizardGames.Soc.Common.Construction.PartType Igniter = 19030012;
	static WizardGames.Soc.Common.Construction.PartType HBHFSensor = 19030013;
	static WizardGames.Soc.Common.Construction.PartType LaserDetector = 19030014;
	static WizardGames.Soc.Common.Construction.PartType PressurePad = 19030015;
	static WizardGames.Soc.Common.Construction.PartType ModularCarLift = 19030016;
	static WizardGames.Soc.Common.Construction.PartType Elevator = 19030017;
	static WizardGames.Soc.Common.Construction.PartType SearchLight = 19030018;
	static WizardGames.Soc.Common.Construction.PartType RFBroadcaster = 19030019;
	static WizardGames.Soc.Common.Construction.PartType RFReceiver = 19030020;
	static WizardGames.Soc.Common.Construction.PartType FluidSwitchPump = 19030021;
	static WizardGames.Soc.Common.Construction.PartType PoweredWaterPurifier = 19030022;
	static WizardGames.Soc.Common.Construction.PartType WaterPump = 19030023;
	static WizardGames.Soc.Common.Construction.PartType Sprinkler = 19030024;
	static WizardGames.Soc.Common.Construction.PartType SamSite = 19030025;
	static WizardGames.Soc.Common.Construction.PartType UGCSpawnPoint = 20250001;
	static WizardGames.Soc.Common.Construction.PartType UGCCheckPoint = 20250002;
	static WizardGames.Soc.Common.Construction.PartType UGCSettlementPoint = 20250003;
	static WizardGames.Soc.Common.Construction.PartType UGCMonsterSpawnPoint = 20250004;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker : System.Object
{
	static WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker Instance; // 0x0
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask,System.Collections.Generic.List<WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckBuildingPrivilege>> InteractTestFuncDict; // 0x10
	static System.Void .cctor(); // 0x06d99b9c
	System.Void .ctor(); // 0x06d99c3c
}

// Client.Runtime
struct WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckContext : System.ValueType
{
	WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask needPrivilege; // 0x10
	WizardGames.Soc.Common.Entity.PlayerEntity player; // 0x18
	WizardGames.Soc.Common.Entity.PartEntity part; // 0x20
	WizardGames.Soc.Common.Algorithm.Vector3 pos; // 0x28
	System.Int64 templateId; // 0x38
	System.Int64 terrId; // 0x40
	WizardGames.Soc.Common.Entity.TerritoryEntity terrEnt; // 0x48
	System.Boolean silent; // 0x50
	System.Single RetParam; // 0x54
	
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckBuildingPrivilege : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x06d99cf0
	WizardGames.Soc.Common.Construction.EResultType Invoke(WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker self, WizardGames.Soc.Common.Construction.BuildingPrivilegeChecker.CheckContext& ctx, System.Boolean& checkNext); // 0x06d99e24
}

// Client.Runtime
enum WizardGames.Soc.Common.Construction.EPrivilegeType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Construction.EPrivilegeType Build = 1;
	static WizardGames.Soc.Common.Construction.EPrivilegeType Upgrade = 2;
	static WizardGames.Soc.Common.Construction.EPrivilegeType Repair = 3;
	static WizardGames.Soc.Common.Construction.EPrivilegeType Rotate = 4;
	static WizardGames.Soc.Common.Construction.EPrivilegeType PickUp = 5;
	static WizardGames.Soc.Common.Construction.EPrivilegeType Delete = 6;
	static WizardGames.Soc.Common.Construction.EPrivilegeType Interact = 7;
	static WizardGames.Soc.Common.Construction.EPrivilegeType Password = 8;
	static WizardGames.Soc.Common.Construction.EPrivilegeType Immunity = 9;
	static WizardGames.Soc.Common.Construction.EPrivilegeType Move = 10;
	static WizardGames.Soc.Common.Construction.EPrivilegeType Remould = 11;
	static WizardGames.Soc.Common.Construction.EPrivilegeType Reputation = 12;
	static WizardGames.Soc.Common.Construction.EPrivilegeType ChangeDirection = 13;
	static WizardGames.Soc.Common.Construction.EPrivilegeType SafetyBoxLevelUp = 14;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask None = 0;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask BuildA_CheckTerritory = 1;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask BuildB_Everyone = 2;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask Upgrade = 3;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask Repair = 4;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask Rotate = 5;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask PickUpA_CheckTerritory = 6;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask PickUpB_CheckOwner = 7;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask PickUpC_Forbidden = 8;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask DeleteA_CheckTerritory = 9;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask DeleteB_Forbidden = 10;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask InteractA_Everyone = 11;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask InteractB_Owner = 12;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask InteractC_NeedPermission = 13;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask PasswordA_Turret = 14;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask PasswordB_Normal = 15;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask PasswordC_Territory = 16;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask PasswordD_Container = 17;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask PasswordE_Door = 18;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask Immunity = 19;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask Move = 20;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask Remould = 21;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask PasswordF_Everyone = 22;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask Reputation = 23;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask ChangeDirection = 24;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask PasswordG_Bed = 25;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask SafetyBoxLevelUp = 26;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask End = 27;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Construction.EResultType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Construction.EResultType UndefineError = 0;
	static WizardGames.Soc.Common.Construction.EResultType Pass = 1;
	static WizardGames.Soc.Common.Construction.EResultType NotShow = 2;
	static WizardGames.Soc.Common.Construction.EResultType InteractDenied = 3;
	static WizardGames.Soc.Common.Construction.EResultType PrivilegeDenied = 4;
	static WizardGames.Soc.Common.Construction.EResultType TimeNewBuildDenied = 5;
	static WizardGames.Soc.Common.Construction.EResultType TimeAttackBlockDenied = 6;
	static WizardGames.Soc.Common.Construction.EResultType OwnerDenied = 7;
	static WizardGames.Soc.Common.Construction.EResultType DefaultDenied = 8;
	static WizardGames.Soc.Common.Construction.EResultType ModeNotStart = 9;
	static WizardGames.Soc.Common.Construction.EResultType NoPart = 10;
	static WizardGames.Soc.Common.Construction.EResultType TeamDifferent = 11;
	static WizardGames.Soc.Common.Construction.EResultType InMiddleState = 12;
	static WizardGames.Soc.Common.Construction.EResultType IsBatchRecovering = 13;
	static WizardGames.Soc.Common.Construction.EResultType ToolCupboardConflict = 14;
	static WizardGames.Soc.Common.Construction.EResultType DesertedPrivilegeDenied = 15;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Construction.EBuildingPrivilegeOperation : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOperation AddSomeOne = 1;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOperation ApplyJoin = 2;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOperation AcceptJoin = 3;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOperation BatchAcceptJoin = 4;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOperation DeleteFromGroup = 5;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOperation DeleteCompletely = 6;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOperation CreateGroup = 7;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOperation DeleteGroup = 8;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOperation AddAdmin = 9;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOperation RemoveAdmin = 10;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOperation Rename = 11;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Construction.EBuildingPrivilegeOpCode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOpCode Suc = 0;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOpCode Fail = 1;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOpCode ConfigError = 2;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOpCode ParamError = 3;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOpCode OwnerNotFound = 4;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOpCode BaseGroupCannotRemove = 5;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOpCode NotTeammate = 6;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOpCode TeammateCannotRemove = 7;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOpCode NoPermission = 8;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOpCode EntityNotFound = 9;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOpCode GroupNotFound = 10;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOpCode PlayerNotFound = 11;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOpCode RepeatedOperation = 12;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOpCode MaxCountExceed = 13;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOpCode DataError = 14;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOpCode RemoveAdminFrist = 15;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOpCode AdminAlready = 16;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOpCode LengthError = 17;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOpCode AlreadyInGroup = 18;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOpCode MinganciTestFail = 19;
	static WizardGames.Soc.Common.Construction.EBuildingPrivilegeOpCode NotInGroup = 20;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Construction.EConstructionSocketType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Construction.EConstructionSocketType None = 0;
	static WizardGames.Soc.Common.Construction.EConstructionSocketType Foundation = 1;
	static WizardGames.Soc.Common.Construction.EConstructionSocketType Floor = 2;
	static WizardGames.Soc.Common.Construction.EConstructionSocketType Misc = 3;
	static WizardGames.Soc.Common.Construction.EConstructionSocketType Doorway = 4;
	static WizardGames.Soc.Common.Construction.EConstructionSocketType Wall = 5;
	static WizardGames.Soc.Common.Construction.EConstructionSocketType Block = 6;
	static WizardGames.Soc.Common.Construction.EConstructionSocketType Ramp = 7;
	static WizardGames.Soc.Common.Construction.EConstructionSocketType StairsTriangle = 8;
	static WizardGames.Soc.Common.Construction.EConstructionSocketType Stairs = 9;
	static WizardGames.Soc.Common.Construction.EConstructionSocketType FloorFrameTriangle = 10;
	static WizardGames.Soc.Common.Construction.EConstructionSocketType Window = 11;
	static WizardGames.Soc.Common.Construction.EConstructionSocketType Shutters = 12;
	static WizardGames.Soc.Common.Construction.EConstructionSocketType WallFrame = 13;
	static WizardGames.Soc.Common.Construction.EConstructionSocketType FloorFrame = 14;
	static WizardGames.Soc.Common.Construction.EConstructionSocketType WindowDressing = 15;
	static WizardGames.Soc.Common.Construction.EConstructionSocketType DoorDressing = 16;
	static WizardGames.Soc.Common.Construction.EConstructionSocketType Elevator = 17;
	static WizardGames.Soc.Common.Construction.EConstructionSocketType DoubleDoorDressing = 18;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Construction.ESocketSide : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Construction.ESocketSide None = 0;
	static WizardGames.Soc.Common.Construction.ESocketSide Up = 2;
	static WizardGames.Soc.Common.Construction.ESocketSide Down = 4;
	static WizardGames.Soc.Common.Construction.ESocketSide Front = 8;
	static WizardGames.Soc.Common.Construction.ESocketSide Back = 16;
	static WizardGames.Soc.Common.Construction.ESocketSide Left = 32;
	static WizardGames.Soc.Common.Construction.ESocketSide Right = 64;
	static WizardGames.Soc.Common.Construction.ESocketSide Center = 128;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionGroupConfig : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScriptNode> constructionScriptNodes; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScript_WallGroupConfig> wallGroups; // 0x18
	System.Void .ctor(); // 0x06d99e88
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScript_WallGroupConfig : System.Object
{
	System.Boolean isNecessary; // 0x10
	System.Single heightDelta; // 0x14
	System.Int64[] walls; // 0x18
	System.Void .ctor(); // 0x06d99f94
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScriptNode : System.Object
{
	WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScript_RandomHp randomHp; // 0x10
	WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScript_BonusChest bonusChest; // 0x18
	WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScript_OutDoorPartConfig outDoorPartConfig; // 0x20
	WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScript_GameplayData gameplayData; // 0x28
	WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScript_BedGroup bedGroup; // 0x30
	System.Void .ctor(); // 0x06d99ffc
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScript_BedGroup : System.Object
{
	System.Int32 groupName; // 0x10
	System.Void .ctor(); // 0x06d9a064
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScript_RandomHp : System.Object
{
	System.Int32 hpMin; // 0x10
	System.Int32 hpMax; // 0x14
	System.Void .ctor(); // 0x06d9a0cc
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScript_OutDoorPartConfig : System.Object
{
	System.Boolean isNecessary; // 0x10
	System.Single tolerance; // 0x14
	System.Void .ctor(); // 0x06d9a134
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScript_BonusChest : System.Object
{
	System.Int32 chestId; // 0x10
	WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScript_BonusChest.ContainerDrop[] containers; // 0x18
	System.Void .ctor(); // 0x06d9a19c
}

// Client.Runtime
struct WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScript_BonusChest.ContainerDrop : System.ValueType
{
	System.UInt32 containerId; // 0x10
	System.UInt32 dropId; // 0x14
	
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.ConstructionEditConfig.ConstructionScript_GameplayData : System.Object
{
	System.Int32 gamePlayDataInt; // 0x10
	System.Void .ctor(); // 0x06d9a204
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.SystemRequest.SimulatorCheckMoveDeployRequest : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	
	System.Void .ctor(); // 0x06d9a26c
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.SystemRequest.RefreshGapPropertyChangeRequest : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	System.Int64 entityId; // 0x20
	static WizardGames.Soc.Common.Construction.SystemRequest.RefreshGapPropertyChangeRequest Generate(System.Int64 entityId); // 0x06d9a2d4
	System.Void .ctor(); // 0x06d9a364
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.SystemRequest.RefreshGapRequest : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	
	System.Void .ctor(); // 0x06d9a3cc
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.SystemRequest.RefreshGradeMeshRequest : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	
	System.Void .ctor(); // 0x06d9a434
}

// Client.Runtime
class WizardGames.Soc.Common.Construction.SystemRequest.WireUpdateViewRequest : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	
	static WizardGames.Soc.Common.Construction.SystemRequest.WireUpdateViewRequest Generate(); // 0x06d9a49c
	System.Void .ctor(); // 0x06d9a514
}

// Client.Runtime
class WizardGames.Soc.Common.Compose.ComposeUtil : System.Object
{
	
	static System.Int32 CalculateInterval(WizardGames.Soc.Common.Data.blueprintData.Blueprint data, WizardGames.Soc.Common.Data.global.TbGlobalConfig globalConfig, System.Int32 level, log4net.ILog log); // 0x06d9a57c
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.BulletRequest : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	WizardGames.Soc.Common.Entity.IEntity OwnerEntity; // 0x20
	System.Numerics.Vector3 Direction; // 0x28
	System.Single InitialVelocity; // 0x34
	System.Int64 OwnerEntityId; // 0x38
	System.Int64 OwnerTableId; // 0x40
	System.Int32 Sequence; // 0x48
	System.Int64 LagCompensationTime; // 0x50
	System.Numerics.Vector3 LogicPosition; // 0x58
	System.Single DamageScale; // 0x64
	System.Int64 WeaponId; // 0x68
	System.Int64 WeaponTableId; // 0x70
	System.Int64 AmmoTableId; // 0x78
	System.Int32 BulletIndex; // 0x80
	System.Int32 PveAttFix; // 0x84
	System.Boolean MagicBullet; // 0x88
	System.Boolean IsServerBullet; // 0x89
	System.Numerics.Vector3 SourcePosition; // 0x8c
	System.Int32 SourceMonumentId; // 0x98
	System.Single SourceAdsProgress; // 0x9c
	System.Int32 SourceMoveState; // 0xa0
	System.Int32 SourcePoseState; // 0xa4
	System.Int64 TargetEntityId; // 0xa8
	System.Numerics.Vector3 TargetPredictionPos; // 0xb0
	System.Int64 SkinId; // 0xc0
	System.Int64 LocalTime; // 0xc8
	System.Numerics.Vector3 CmdEyePosition; // 0xd0
	System.Int32 Tag; // 0xdc
	System.Boolean IsConsumeItem; // 0xe0
	System.Void Dispose(); // 0x06d9a788
	static WizardGames.Soc.Common.Combat.BulletRequest NewRequest(); // 0x06d9a83c
	System.Void .ctor(); // 0x06d9a8b4
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.BulletSkillRequest : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	System.Int32 SkillId; // 0x1c
	System.Numerics.Vector3 Direction; // 0x20
	System.Numerics.Vector3 Position; // 0x2c
	System.Numerics.Vector3 Normal; // 0x38
	System.Int64 OwnerId; // 0x48
	System.Int64 WeaponTableId; // 0x50
	System.Int64 WeaponSkinId; // 0x58
	System.Int64 AmmoTableId; // 0x60
	System.Int64 PlayerId; // 0x68
	static System.Void TryCreateAndAddReq(WizardGames.Soc.Common.Entity.Ability.IProjectile projectile, System.Int32 skillId, System.Numerics.Vector3 curPos, System.Numerics.Vector3 normal); // 0x06d9a928
	System.Void Dispose(); // 0x055049cc
	System.Void .ctor(); // 0x06d9aa98
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.CameraHitShakeData : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	System.Single DirX; // 0x1c
	System.Single DirY; // 0x20
	System.Single DirZ; // 0x24
	System.Int64 WeaponTableId; // 0x28
	System.Single Para; // 0x30
	System.Single PosX; // 0x34
	System.Single PosY; // 0x38
	System.Single PosZ; // 0x3c
	System.Int32 ShotLenId; // 0x40
	System.Void .ctor(); // 0x06d9ab00
	static WizardGames.Soc.Common.Combat.CameraHitShakeData Generate(); // 0x06d9ab68
	System.Void Dispose(); // 0x06d9abe0
}

// Client.Runtime
struct WizardGames.Soc.Common.Combat.SelectConf : System.ValueType
{
	WizardGames.Soc.Common.State.Character.LadderTestDir testDir; // 0x10
	WizardGames.Soc.Common.Unity.Character.LadderSelectPoint testPoint; // 0x14
	WizardGames.Soc.Common.Unity.Character.LadderSelectInOutPoint testInOutPoint; // 0x18
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Combat.LadderAnimCostData : System.ValueType
{
	UnityEngine.Vector3 startPosition; // 0x10
	UnityEngine.Vector3 endPosition; // 0x1c
	System.Int32 costTimeMs; // 0x28
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Combat.NestedListV3 : System.ValueType
{
	System.Collections.Generic.List<UnityEngine.Vector3> wayPoints; // 0x10
	WizardGames.Soc.Common.State.Character.LadderTestDir Dir; // 0x18
	System.Boolean IsEnable(WizardGames.Soc.Common.State.Character.LadderTestDir testDir); // 0x06d9ac58
	System.Boolean IsEnable(System.Int32 testDir); // 0x06d9ad00
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.AdsorbCollideConfig : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	System.Boolean IsRerverse; // 0x30
	System.Boolean disableBackEnter; // 0x31
	System.Boolean LadderFlip; // 0x32
	Share.Entity.Interface.ILadderEntity Entity; // 0x38
	UnityEngine.Vector3 LadderWorldPosition; // 0x40
	UnityEngine.Quaternion LadderWorldQuat; // 0x4c
	UnityEngine.Vector3 LadderWorldScale; // 0x5c
	UnityEngine.Vector3 LadderWorldForward; // 0x68
	UnityEngine.Vector3 LadderWorldRight; // 0x74
	UnityEngine.Vector3 LadderWorldNormal; // 0x80
	UnityEngine.Quaternion moveRotation; // 0x8c
	UnityEngine.Transform mainTrans; // 0xa0
	System.Boolean CustomLadderConf; // 0xa8
	System.Single LadderMeshOffset; // 0xac
	System.Collections.Generic.List<WizardGames.Soc.Common.Combat.SelectConf> EnterTestMap; // 0xb0
	System.Collections.Generic.List<WizardGames.Soc.Common.Combat.SelectConf> LeaveTestMap; // 0xb8
	System.Int64 SpawnGroupId; // 0xc0
	System.Int64 SpawnPointId; // 0xc8
	UnityEngine.Vector3 LadderNormal; // 0xd0
	UnityEngine.Vector3 LadderRight; // 0xdc
	UnityEngine.Vector3 LadderForward; // 0xe8
	UnityEngine.Vector3 TopOffSet; // 0xf4
	UnityEngine.Vector3 TopAdsorbSize; // 0x100
	UnityEngine.Vector3 TopMoveAbleOffset; // 0x10c
	UnityEngine.Vector3 TopMoveableSize; // 0x118
	UnityEngine.Vector3 LadderOffset; // 0x124
	UnityEngine.Vector3 LadderSize; // 0x130
	UnityEngine.Vector3 BottomAdsorbSize; // 0x13c
	UnityEngine.Vector3 BottomOffSet; // 0x148
	UnityEngine.Vector3 FlyAdsorbSize; // 0x154
	UnityEngine.Vector3 FlyAbleOffset; // 0x160
	UnityEngine.BoxCollider PreliminaryCollider; // 0x170
	UnityEngine.BoxCollider LadderSelectCollider; // 0x178
	UnityEngine.BoxCollider TopSelectCollider; // 0x180
	UnityEngine.BoxCollider TopMoveAbleSelectCollider; // 0x188
	UnityEngine.BoxCollider BottomSelectCollider; // 0x190
	UnityEngine.BoxCollider FlySelectCollider; // 0x198
	WizardGames.Soc.Common.Unity.Construction.ConstructionConfig WorldConstructionConfig; // 0x1a0
	System.Collections.Generic.List<UnityEngine.Collider> IgnoreCollides; // 0x1a8
	System.Collections.Generic.List<WizardGames.Soc.Common.Combat.NestedListV3> NewLocalWayPoints; // 0x1b0
	System.Boolean PreviewLadder; // 0x1b8
	System.Boolean DrawObb; // 0x1b9
	System.Single PreviewLine; // 0x1bc
	System.Void Refresh(Share.Entity.Interface.ILadderEntity targetentity); // 0x06d9ada8
	System.Void RefreshTransform(); // 0x06d9ae4c
	static System.Boolean IsLadderFlip(WizardGames.Soc.Common.Combat.AdsorbCollideConfig ladder, UnityEngine.Quaternion ladderQuat); // 0x06d9b3fc
	UnityEngine.Vector3 GetLadderPos(); // 0x06d9b568
	UnityEngine.Quaternion GetLadderQuat(); // 0x06d9b354
	UnityEngine.Vector3 GetLadderScale(); // 0x06d9b610
	UnityEngine.Vector3 GetLadderNormal(); // 0x06d9b6b8
	UnityEngine.Vector3 GetLadderRight(); // 0x06d9b760
	UnityEngine.Vector3 GetLadderForward(); // 0x06d9b808
	System.Boolean ShouldIgnoreCollide(UnityEngine.Collider testCollide); // 0x06d9b8b0
	static System.Boolean ShouldIgnoreCollide(WizardGames.Soc.Common.Combat.AdsorbCollideConfig[] configs, UnityEngine.Collider testCollide); // 0x06d9b94c
	static System.Boolean ShouldIgnoreCollide(WizardGames.Soc.Common.Combat.AdsorbCollideConfig config, UnityEngine.Collider testCollide); // 0x06d9ba18
	WizardGames.Soc.Common.Unity.Utility.OBB GetTopObb(UnityEngine.Vector3 pos, UnityEngine.Quaternion q, UnityEngine.Vector3 gs); // 0x06d9bae8
	WizardGames.Soc.Common.Unity.Utility.OBB GetTopObb(); // 0x06d9bc6c
	WizardGames.Soc.Common.Unity.Utility.OBB GetLadderObb(UnityEngine.Vector3 pos, UnityEngine.Quaternion q, UnityEngine.Vector3 gs); // 0x06d9bd18
	WizardGames.Soc.Common.Unity.Utility.OBB GetLadderObb(); // 0x06d9bea0
	WizardGames.Soc.Common.Unity.Utility.OBB GetLadder_AdjustObb(UnityEngine.Vector3 pos, UnityEngine.Quaternion q, UnityEngine.Vector3 gs, System.Single extraThickness, System.Single extraTop, System.Single extraBot, System.Single extraLR); // 0x06d9bf4c
	WizardGames.Soc.Common.Unity.Utility.OBB GetLadder_AdjustObb(); // 0x06d9c124
	WizardGames.Soc.Common.Unity.Utility.OBB GetBottomObb(UnityEngine.Vector3 pos, UnityEngine.Quaternion q, UnityEngine.Vector3 gs); // 0x06d9c220
	WizardGames.Soc.Common.Unity.Utility.OBB GetBottomObb(); // 0x06d9c3a8
	WizardGames.Soc.Common.Unity.Utility.OBB GetTopMoveableObb(UnityEngine.Vector3 pos, UnityEngine.Quaternion q, UnityEngine.Vector3 gs); // 0x06d9c454
	WizardGames.Soc.Common.Unity.Utility.OBB GetTopMoveableObb(); // 0x06d9c624
	static System.Boolean ObbMoveUpByPoint(WizardGames.Soc.Common.Unity.Utility.OBB& obb, System.Single targetY); // 0x06d9c6d0
	static UnityEngine.Vector3 MoveUpByPoint(WizardGames.Soc.Common.Unity.Utility.OBB& obb, UnityEngine.Vector3 obbPoint, UnityEngine.Vector3 targetPoint, System.Single yEpsilon, System.Single precisionThreshold); // 0x06d9c8f8
	static UnityEngine.Bounds _InverseTransformBounds(UnityEngine.Transform localTrans, WizardGames.Soc.Common.Unity.Utility.OBB collideObb); // 0x06d9cae0
	static UnityEngine.Bounds _InverseTransformBounds(UnityEngine.Transform localTrans, UnityEngine.BoxCollider WorldCollider); // 0x06d9d134
	System.Void RefreshRuntime(); // 0x06d9d2c4
	System.Void Refresh(); // 0x06d9d328
	WizardGames.Soc.Common.Unity.Utility.OBB _CalculateBoundingAABB(System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Utility.OBB> obbs); // 0x06d9dbbc
	System.Void .ctor(); // 0x06d9dfdc
	static System.Void .cctor(); // 0x06d9e228
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.ColliderConfig : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	UnityEngine.Collider _collider; // 0x30
	System.Action OnColliderHit; // 0x38
	System.Boolean IsOpenHitEvent; // 0x40
	WizardGames.Soc.Common.Combat.HitPart hitPart; // 0x41
	WizardGames.Soc.Common.Combat.ColliderMaterialEnum hitMaterial; // 0x42
	System.Boolean ignoreHurt; // 0x43
	System.Boolean IgnoreBulletHit; // 0x44
	System.Boolean IgnoreAllBulletHit; // 0x45
	System.Boolean IsScreenBox; // 0x46
	System.Int16 ballisticPropertyID; // 0x48
	System.Boolean isInit; // 0x4a
	System.Byte index; // 0x4b
	System.Int64 entityId; // 0x50
	System.Byte entityType; // 0x58
	System.Void RefreshWithoutEntity(System.Int64 entityId, System.Int32 entityType); // 0x06d9e2bc
	WizardGames.Soc.Common.Combat.ColliderMaterialEnum get_HitMaterial(); // 0x06d9e41c
	System.Void set_HitMaterial(WizardGames.Soc.Common.Combat.ColliderMaterialEnum value); // 0x06d9e480
	System.Int32 get_BallisticPropertyID(); // 0x06d9e4f8
	System.Void set_BallisticPropertyID(System.Int32 value); // 0x06d9e55c
	System.Int32 get_Index(); // 0x06d9e5d4
	System.Void set_Index(System.Int32 value); // 0x06d9e638
	System.Int64 get_EntityId(); // 0x06d9e6b0
	System.Void set_EntityId(System.Int64 value); // 0x06d9e714
	System.Int32 get_EntityType(); // 0x06d9e78c
	WizardGames.Soc.Common.Combat.HitPart get_HitPart(); // 0x06d9e7f0
	System.Boolean get_IgnoreHurt(); // 0x06d9e854
	System.Void set_IgnoreHurt(System.Boolean value); // 0x06d9e8b8
	WizardGames.Soc.Common.Entity.IEntity get_OwnerEntity(); // 0x06d9e934
	WizardGames.Soc.Common.Unity.Go.IEntityGo get_OwnerEntityGo(); // 0x06d9e9f8
	System.Int64 get_OwnerEntityId(); // 0x06d9eab4
	System.Void Start(); // 0x06d9ed9c
	System.Void SetDebugShowEntityId(System.Int64 entityId); // 0x06d9e3a8
	System.Void Reset(); // 0x06d9f018
	System.Void OnDestroy(); // 0x06d9f0dc
	System.Void Refresh(WizardGames.Soc.Common.Entity.IEntity entity, WizardGames.Soc.Common.Unity.Go.IEntityGo entityGo, System.Boolean isMyself); // 0x06d9f14c
	System.Void Refresh(WizardGames.Soc.Common.Entity.IEntity entity, System.Boolean isMyself); // 0x06d9f39c
	UnityEngine.Collider GetCollider(); // 0x06d9f5d8
	System.Void SyncMaterial(); // 0x06d9ee5c
	System.Void .ctor(); // 0x06d9f63c
	static System.Void .cctor(); // 0x06d9f6ac
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.ColliderConfigSet : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.Dictionary<System.Int32,System.String> PlayerColliderIndex2NameMap; // 0x8
	WizardGames.Soc.Common.Combat.ColliderConfig[] configs; // 0x30
	System.Int32 BallisticPropertyID; // 0x38
	System.Boolean ShareUse; // 0x3c
	static System.Void Add(System.Int32 entityType, WizardGames.Soc.Common.Combat.ColliderConfigSet set); // 0x06d9f780
	static System.Boolean TryGetPlayerConfigName(System.Int32 index, System.String& name); // 0x06d9f990
	System.Void Refresh(WizardGames.Soc.Common.Entity.IEntity target, WizardGames.Soc.Common.Unity.Go.IEntityGo entityGo, System.Boolean isMyself); // 0x06d9fa5c
	System.Void RefreshWithoutEntity(System.Int64 entityId, System.Int32 entityType); // 0x06d9fcec
	System.Void RefreshInner(WizardGames.Soc.Common.Entity.IEntity target, WizardGames.Soc.Common.Unity.Go.IEntityGo entityGo, System.Boolean isMyself); // 0x06d9fafc
	System.Void RefreshInner(WizardGames.Soc.Common.Entity.IEntity target, System.Boolean isMyself); // 0x06d9fe28
	System.Void Clean(); // 0x06da000c
	System.Boolean HaveHitCollider(); // 0x06da0108
	WizardGames.Soc.Common.Combat.ColliderConfig GetCollider(System.Int32 index); // 0x06da0180
	WizardGames.Soc.Common.Combat.ColliderConfig[] GetAllCollider(); // 0x06da0220
	System.Boolean IsInSet(UnityEngine.Collider col); // 0x06da0284
	System.Void AddColliderConfig(WizardGames.Soc.Common.Combat.ColliderConfig config); // 0x06da03e0
	System.Void AddColliderConfigs(WizardGames.Soc.Common.Combat.ColliderConfig[] config); // 0x06da0574
	System.Void UpdateConstructionColliderConfigs(System.Collections.Generic.List<WizardGames.Soc.Common.Combat.ColliderConfig> colliderConfigs); // 0x06da05f4
	System.Void .ctor(); // 0x06da07cc
	static System.Void .cctor(); // 0x06da0864
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.ColliderConfigSet_Construction : WizardGames.Soc.Common.Combat.ColliderConfigSet
{
	
	System.Void UpdateColliderConfigSet(System.Int64 parentId, WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06da0938
	System.Void CollectionColliderConfig(System.Collections.Generic.List<WizardGames.Soc.Common.Combat.ColliderConfig> configs); // 0x06da0ab4
	System.Void .ctor(); // 0x06da0b28
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.ColliderConfigSet_Construction_Core : WizardGames.Soc.Common.Combat.ColliderConfigSet_Construction
{
	
	System.Void .ctor(); // 0x06da0bb0
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.ColliderConfigSet_Construction_Deployed : WizardGames.Soc.Common.Combat.ColliderConfigSet_Construction
{
	WizardGames.Soc.Common.Combat.ColliderConfig[] baseColliderConfigs; // 0x40
	WizardGames.Soc.Common.Combat.ColliderConfig[] skinColliderConfigs; // 0x48
	System.Void InitBaseColiderConifg(); // 0x06da0c14
	System.Void InitSkinGoCollider(UnityEngine.GameObject skinGo); // 0x06da0cb4
	System.Void RemoveSkinGoCollider(); // 0x06da0d60
	System.Void CollectionColliderConfig(System.Collections.Generic.List<WizardGames.Soc.Common.Combat.ColliderConfig> configs); // 0x06da0dcc
	System.Void .ctor(); // 0x06da0f80
}

// Client.Runtime
enum WizardGames.Soc.Common.Combat.ColliderMaterialEnum : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum Unknown = 0;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum Bone = 1;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum BouncyBall = 2;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum Cloth = 3;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum ClothFlesh = 4;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum Concrete = 5;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum Dirt = 6;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum Flesh = 7;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum Forest = 8;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum Generic = 9;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum Glass = 10;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum Grass = 11;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum Gravel = 12;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum Grenade = 13;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum MaxFriction = 14;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum MaxFrictionNoBounce = 15;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum Metal = 16;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum MetalLowFriction = 17;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum MetalOre = 18;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum Path = 19;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum Rock = 20;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum Sand = 21;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum SandBag = 22;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum SledFriction = 23;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum SledNoFriction = 24;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum Snow = 25;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum Stones = 26;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum Tundra = 27;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum Water = 28;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum Wood = 29;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum Terrain = 30;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum LightColoredTree = 31;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum DarkTree = 32;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum Ore = 33;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum TrainTrackLowFriction = 34;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum SledFrictionNoBounce = 35;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum ZeroFriction = 36;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum ZeroFrictionAbsolute = 37;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum Ice = 38;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum Cactus = 39;
	static WizardGames.Soc.Common.Combat.ColliderMaterialEnum Bearintrailer = 40;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.ConstructionColliderConfigCollection : UnityEngine.MonoBehaviour
{
	WizardGames.Soc.Common.Combat.ColliderConfig[] configs; // 0x30
	WizardGames.Soc.Common.Combat.ColliderConfig[] GetAllCollider(); // 0x06da0fe4
	System.Void CollectionColliderConfig(); // 0x06da1048
	System.Void .ctor(); // 0x06da1378
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.HitBoxComp : WizardGames.Soc.Common.Component.BaseComponentLocal
{
	System.Collections.Generic.List<System.String> <HitBoxNames>k__BackingField; // 0x38
	System.Collections.Generic.List<System.String> get_HitBoxNames(); // 0x06da1410
	System.Void set_HitBoxNames(System.Collections.Generic.List<System.String> value); // 0x06da1474
	UnityEngine.Vector3 GetPointWithHitBox(UnityEngine.Vector3 localPosition); // 0x054b17e0
	UnityEngine.Vector3 GetLocalPointWithHitBox(UnityEngine.Vector3 position); // 0x054b17e0
	UnityEngine.Vector3 GetDirectionWithHitBoxByLocalSpace(UnityEngine.Vector3 localDirection); // 0x054b17e0
	UnityEngine.Vector3 GetLocalSpaceDirectionWithHitBoxByWorldSpace(UnityEngine.Vector3 direction); // 0x054b17e0
	System.Void ApplyToHitBox(); // 0x055049cc
	UnityEngine.GameObject GetBaseChildByName(System.String name); // 0x054f9d14
	System.Void .ctor(); // 0x06da14f4
}

// Client.Runtime
enum WizardGames.Soc.Common.Combat.PoseIndexEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Combat.PoseIndexEnum stand = 0;
	static WizardGames.Soc.Common.Combat.PoseIndexEnum crouch = 1;
	static WizardGames.Soc.Common.Combat.PoseIndexEnum dying = 2;
	static WizardGames.Soc.Common.Combat.PoseIndexEnum falldying = 3;
	static WizardGames.Soc.Common.Combat.PoseIndexEnum sleep = 4;
	static WizardGames.Soc.Common.Combat.PoseIndexEnum swimidle = 5;
	static WizardGames.Soc.Common.Combat.PoseIndexEnum swimforward = 6;
	static WizardGames.Soc.Common.Combat.PoseIndexEnum zipline = 7;
	static WizardGames.Soc.Common.Combat.PoseIndexEnum ladder = 8;
	static WizardGames.Soc.Common.Combat.PoseIndexEnum mantle = 9;
	static WizardGames.Soc.Common.Combat.PoseIndexEnum drive = 10;
	static WizardGames.Soc.Common.Combat.PoseIndexEnum count = 11;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.PoseTransLocalCaches : System.Object
{
	System.Collections.Generic.List<UnityEngine.Vector3> Positions; // 0x10
	System.Collections.Generic.List<UnityEngine.Quaternion> Rotations; // 0x18
	System.Collections.Generic.List<UnityEngine.Vector3> Scales; // 0x20
	System.Void .ctor(); // 0x06da1580
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.ServerPlayerColliderPreset : UnityEngine.ScriptableObject
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Combat.PoseTransLocalCaches> PoseCaches; // 0x18
	System.Void .ctor(); // 0x06da16bc
}

// Client.Runtime
struct WizardGames.Soc.Common.Combat.SocRaycastHit : System.ValueType
{
	UnityEngine.GameObject colliderGo; // 0x10
	UnityEngine.Vector3 normal; // 0x18
	UnityEngine.Vector3 point; // 0x24
	System.Single distance; // 0x30
	UnityEngine.Collider collider; // 0x38
	System.Int64 entityId; // 0x40
	System.Int32 entityType; // 0x48
	UnityEngine.GameObject get_ColliderGo(); // 0x06da1724
	UnityEngine.Vector3 get_Normal(); // 0x06da1788
	UnityEngine.Vector3 get_Point(); // 0x06da17ec
	System.Single get_Distance(); // 0x06da1850
	UnityEngine.Collider get_Collider(); // 0x06da18b4
	System.Int64 get_EntityId(); // 0x06da1918
	System.Int32 get_EntityType(); // 0x06da197c
	WizardGames.Soc.Common.Entity.IEntity get_OwnerEntity(); // 0x06da19e0
	System.Int64 get_OwnerEntityId(); // 0x06da1aa4
	System.Void .ctor(UnityEngine.RaycastHit hit, System.Int64 entityId, System.Int32 entityType); // 0x06da1c50
	System.Void .ctor(UnityEngine.RaycastHit hit, UnityEngine.GameObject mainGo, WizardGames.Soc.Common.Combat.HitBoxComp hitBoxComp, System.Single defaultDistance, System.Int64 entityId, System.Int32 entityType); // 0x06da1dc4
	System.Boolean GetColliderConfig(WizardGames.Soc.Common.Combat.ColliderConfig& config); // 0x06da1fd0
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.TriggerWrap : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	System.Single scale; // 0x30
	UnityEngine.BoxCollider collider; // 0x38
	System.Collections.Generic.HashSet<System.Int64> entityIds; // 0x40
	System.Collections.Generic.HashSet<System.Int64> caches; // 0x48
	UnityEngine.Collider[] results; // 0x50
	System.Action<System.Int32,System.Int32> OnEntityCountChange; // 0x58
	System.Action<WizardGames.Soc.Common.Entity.IEntity> OnEntityAdd; // 0x60
	System.Action<WizardGames.Soc.Common.Entity.IEntity> OnEntityRemove; // 0x68
	System.Void OnEnable(); // 0x06da215c
	System.Void OnDisable(); // 0x06da29bc
