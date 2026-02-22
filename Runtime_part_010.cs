	static WizardGames.Soc.Common.Entity.ETestCustomTypeEnum Long = 1;
	static WizardGames.Soc.Common.Entity.ETestCustomTypeEnum Float = 2;
	static WizardGames.Soc.Common.Entity.ETestCustomTypeEnum Vector3 = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.ECorpseTypeEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Entity.ECorpseTypeEnum Invalid = 0;
	static WizardGames.Soc.Common.Entity.ECorpseTypeEnum Player = 1;
	static WizardGames.Soc.Common.Entity.ECorpseTypeEnum Monster = 2;
	static WizardGames.Soc.Common.Entity.ECorpseTypeEnum Vehicle = 3;
	static WizardGames.Soc.Common.Entity.ECorpseTypeEnum Horse = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.EPatrolGroupState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Entity.EPatrolGroupState Default = 0;
	static WizardGames.Soc.Common.Entity.EPatrolGroupState Patrol = 1;
	static WizardGames.Soc.Common.Entity.EPatrolGroupState KilledAll = 2;
	static WizardGames.Soc.Common.Entity.EPatrolGroupState BoxTaken = 3;
	static WizardGames.Soc.Common.Entity.EPatrolGroupState CarDestroy = 4;
	static WizardGames.Soc.Common.Entity.EPatrolGroupState Destination = 5;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.PlayerActionHoldStateEnum : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Entity.PlayerActionHoldStateEnum Normal = 0;
	static WizardGames.Soc.Common.Entity.PlayerActionHoldStateEnum DrinkWater = 1;
	static WizardGames.Soc.Common.Entity.PlayerActionHoldStateEnum PourWater = 2;
	static WizardGames.Soc.Common.Entity.PlayerActionHoldStateEnum CollectWaterStart = 3;
	static WizardGames.Soc.Common.Entity.PlayerActionHoldStateEnum CollectWaterLoop = 4;
	static WizardGames.Soc.Common.Entity.PlayerActionHoldStateEnum CollectWaterEnd = 5;
	static WizardGames.Soc.Common.Entity.PlayerActionHoldStateEnum FullWater = 6;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.PlayerActionStateEnum : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Entity.PlayerActionStateEnum Hold = 0;
	static WizardGames.Soc.Common.Entity.PlayerActionStateEnum Switch = 1;
	static WizardGames.Soc.Common.Entity.PlayerActionStateEnum Reload = 2;
	static WizardGames.Soc.Common.Entity.PlayerActionStateEnum Review = 3;
	static WizardGames.Soc.Common.Entity.PlayerActionStateEnum Fire = 4;
	static WizardGames.Soc.Common.Entity.PlayerActionStateEnum AidOther = 5;
	static WizardGames.Soc.Common.Entity.PlayerActionStateEnum PickUp = 6;
	static WizardGames.Soc.Common.Entity.PlayerActionStateEnum UseItem = 7;
	static WizardGames.Soc.Common.Entity.PlayerActionStateEnum Attack = 8;
	static WizardGames.Soc.Common.Entity.PlayerActionStateEnum Throw = 9;
	static WizardGames.Soc.Common.Entity.PlayerActionStateEnum Interaction = 10;
	static WizardGames.Soc.Common.Entity.PlayerActionStateEnum Bolt = 11;
	static WizardGames.Soc.Common.Entity.PlayerActionStateEnum Dance = 12;
	static WizardGames.Soc.Common.Entity.PlayerActionStateEnum QuickDraw = 13;
	static WizardGames.Soc.Common.Entity.PlayerActionStateEnum SwipeCard = 14;
	static WizardGames.Soc.Common.Entity.PlayerActionStateEnum StartUp = 15;
	static WizardGames.Soc.Common.Entity.PlayerActionStateEnum Gesture = 16;
	static WizardGames.Soc.Common.Entity.PlayerActionStateEnum AidSelf = 17;
	static WizardGames.Soc.Common.Entity.PlayerActionStateEnum FireWarm = 18;
	static WizardGames.Soc.Common.Entity.PlayerActionStateEnum Charge = 19;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.PlayerActionStateReloadEnum : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Entity.PlayerActionStateReloadEnum None = 0;
	static WizardGames.Soc.Common.Entity.PlayerActionStateReloadEnum Start = 1;
	static WizardGames.Soc.Common.Entity.PlayerActionStateReloadEnum Loop = 2;
	static WizardGames.Soc.Common.Entity.PlayerActionStateReloadEnum End = 3;
	static WizardGames.Soc.Common.Entity.PlayerActionStateReloadEnum WaitToContinue = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.PlayerAdsAnimStateEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Entity.PlayerAdsAnimStateEnum AdsNone = 0;
	static WizardGames.Soc.Common.Entity.PlayerAdsAnimStateEnum AdsDown = 1;
	static WizardGames.Soc.Common.Entity.PlayerAdsAnimStateEnum AdsUp = 2;
	static WizardGames.Soc.Common.Entity.PlayerAdsAnimStateEnum AdsIdle = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.PlayerAdsStateEnum : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Entity.PlayerAdsStateEnum AdsOff = 0;
	static WizardGames.Soc.Common.Entity.PlayerAdsStateEnum AdsOn = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.PlayerAttackStateEnum : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Entity.PlayerAttackStateEnum None = 0;
	static WizardGames.Soc.Common.Entity.PlayerAttackStateEnum Start = 1;
	static WizardGames.Soc.Common.Entity.PlayerAttackStateEnum Loop = 2;
	static WizardGames.Soc.Common.Entity.PlayerAttackStateEnum HitLoop = 3;
	static WizardGames.Soc.Common.Entity.PlayerAttackStateEnum End = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.PlayerBowStateEnum : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Entity.PlayerBowStateEnum NonArrow_Idle = 0;
	static WizardGames.Soc.Common.Entity.PlayerBowStateEnum Arrow_Idle = 1;
	static WizardGames.Soc.Common.Entity.PlayerBowStateEnum Pick_Arrow = 2;
	static WizardGames.Soc.Common.Entity.PlayerBowStateEnum Auto_Fire = 3;
	static WizardGames.Soc.Common.Entity.PlayerBowStateEnum Cancel_Arrow = 4;
	static WizardGames.Soc.Common.Entity.PlayerBowStateEnum Fire = 5;
	static WizardGames.Soc.Common.Entity.PlayerBowStateEnum AdsUp = 6;
	static WizardGames.Soc.Common.Entity.PlayerBowStateEnum ChargeUp = 7;
	static WizardGames.Soc.Common.Entity.PlayerBowStateEnum ChargeDown = 8;
	static WizardGames.Soc.Common.Entity.PlayerBowStateEnum ChargeFire = 9;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.PlayerCharacterStateEnum : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Entity.PlayerCharacterStateEnum Active = 0;
	static WizardGames.Soc.Common.Entity.PlayerCharacterStateEnum UnActive = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.PlayerCharacterTypeEnum : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Entity.PlayerCharacterTypeEnum Male = 0;
	static WizardGames.Soc.Common.Entity.PlayerCharacterTypeEnum Female = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.PlayerInteractiveStateEnum : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Entity.PlayerInteractiveStateEnum Idle = 0;
	static WizardGames.Soc.Common.Entity.PlayerInteractiveStateEnum Hands = 1;
	static WizardGames.Soc.Common.Entity.PlayerInteractiveStateEnum FullBody = 2;
	static WizardGames.Soc.Common.Entity.PlayerInteractiveStateEnum HalfBodySprint = 3;
	static WizardGames.Soc.Common.Entity.PlayerInteractiveStateEnum Halfbody = 4;
	static WizardGames.Soc.Common.Entity.PlayerInteractiveStateEnum GestureHalfBody = 5;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.PlayerMoveJumpStateEnum : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Entity.PlayerMoveJumpStateEnum JumpNone = 0;
	static WizardGames.Soc.Common.Entity.PlayerMoveJumpStateEnum EnterJump = 1;
	static WizardGames.Soc.Common.Entity.PlayerMoveJumpStateEnum InJump = 2;
	static WizardGames.Soc.Common.Entity.PlayerMoveJumpStateEnum LeaveJump = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.PlayerMoveLadderStateEnum : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Entity.PlayerMoveLadderStateEnum LadderNone = 0;
	static WizardGames.Soc.Common.Entity.PlayerMoveLadderStateEnum InLadder = 1;
	static WizardGames.Soc.Common.Entity.PlayerMoveLadderStateEnum BleedInLadder = 2;
	static WizardGames.Soc.Common.Entity.PlayerMoveLadderStateEnum BleedOutLadder = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.PlayerMoveMantleStateEnum : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Entity.PlayerMoveMantleStateEnum MantleNone = 0;
	static WizardGames.Soc.Common.Entity.PlayerMoveMantleStateEnum MantleOn = 1;
	static WizardGames.Soc.Common.Entity.PlayerMoveMantleStateEnum MantleOver = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.PlayerMoveStateEnum : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Entity.PlayerMoveStateEnum MoveIdle = 0;
	static WizardGames.Soc.Common.Entity.PlayerMoveStateEnum Run = 1;
	static WizardGames.Soc.Common.Entity.PlayerMoveStateEnum Sprint = 2;
	static WizardGames.Soc.Common.Entity.PlayerMoveStateEnum Jump = 3;
	static WizardGames.Soc.Common.Entity.PlayerMoveStateEnum Fall = 4;
	static WizardGames.Soc.Common.Entity.PlayerMoveStateEnum MoveMantle = 5;
	static WizardGames.Soc.Common.Entity.PlayerMoveStateEnum MoveLadder = 6;
	static WizardGames.Soc.Common.Entity.PlayerMoveStateEnum Fly = 7;
	static WizardGames.Soc.Common.Entity.PlayerMoveStateEnum Observer = 8;
	static WizardGames.Soc.Common.Entity.PlayerMoveStateEnum MoveSwim = 9;
	static WizardGames.Soc.Common.Entity.PlayerMoveStateEnum MoveZipline = 10;
	static WizardGames.Soc.Common.Entity.PlayerMoveStateEnum Mountable = 11;
	static WizardGames.Soc.Common.Entity.PlayerMoveStateEnum Max = 12;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.PlayerMoveSwimStateEnum : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Entity.PlayerMoveSwimStateEnum SwimIdle = 0;
	static WizardGames.Soc.Common.Entity.PlayerMoveSwimStateEnum SwimRun = 1;
	static WizardGames.Soc.Common.Entity.PlayerMoveSwimStateEnum SwimSprint = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.PlayerMoveZiplineStateEnum : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Entity.PlayerMoveZiplineStateEnum ZiplineNone = 0;
	static WizardGames.Soc.Common.Entity.PlayerMoveZiplineStateEnum ZiplineIn = 1;
	static WizardGames.Soc.Common.Entity.PlayerMoveZiplineStateEnum ZiplineSlow = 2;
	static WizardGames.Soc.Common.Entity.PlayerMoveZiplineStateEnum ZiplineFast = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.PlayerPassiveStateEnum : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Entity.PlayerPassiveStateEnum PassiveIdle = 0;
	static WizardGames.Soc.Common.Entity.PlayerPassiveStateEnum PassiveFall = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.PlayerPoseDyingStateEnum : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Entity.PlayerPoseDyingStateEnum PoseDyingNone = 0;
	static WizardGames.Soc.Common.Entity.PlayerPoseDyingStateEnum Crawl = 1;
	static WizardGames.Soc.Common.Entity.PlayerPoseDyingStateEnum Incapacitated = 2;
	static WizardGames.Soc.Common.Entity.PlayerPoseDyingStateEnum Lying = 3;
	static WizardGames.Soc.Common.Entity.PlayerPoseDyingStateEnum Rescued = 4;
	static WizardGames.Soc.Common.Entity.PlayerPoseDyingStateEnum SelfHealing = 5;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.PlayerPoseStateEnum : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Entity.PlayerPoseStateEnum Stand = 0;
	static WizardGames.Soc.Common.Entity.PlayerPoseStateEnum Crouch = 1;
	static WizardGames.Soc.Common.Entity.PlayerPoseStateEnum Dying = 2;
	static WizardGames.Soc.Common.Entity.PlayerPoseStateEnum Swim = 3;
	static WizardGames.Soc.Common.Entity.PlayerPoseStateEnum Ladder = 4;
	static WizardGames.Soc.Common.Entity.PlayerPoseStateEnum Dive = 5;
	static WizardGames.Soc.Common.Entity.PlayerPoseStateEnum Mantle = 6;
	static WizardGames.Soc.Common.Entity.PlayerPoseStateEnum Zipline = 7;
	static WizardGames.Soc.Common.Entity.PlayerPoseStateEnum Drive = 8;
	static WizardGames.Soc.Common.Entity.PlayerPoseStateEnum Max = 9;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.PlayerThrowState : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Entity.PlayerThrowState Idle = 0;
	static WizardGames.Soc.Common.Entity.PlayerThrowState ThrowFarStart = 1;
	static WizardGames.Soc.Common.Entity.PlayerThrowState ThrowNearStart = 2;
	static WizardGames.Soc.Common.Entity.PlayerThrowState ThrowReady = 3;
	static WizardGames.Soc.Common.Entity.PlayerThrowState Throw = 4;
	static WizardGames.Soc.Common.Entity.PlayerThrowState CancelThrow = 5;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.PlayerUnAliveStateEnum : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Entity.PlayerUnAliveStateEnum Sleep = 0;
	static WizardGames.Soc.Common.Entity.PlayerUnAliveStateEnum Dead = 1;
	static WizardGames.Soc.Common.Entity.PlayerUnAliveStateEnum WakeUp = 2;
	static WizardGames.Soc.Common.Entity.PlayerUnAliveStateEnum ToDie = 3;
	static WizardGames.Soc.Common.Entity.PlayerUnAliveStateEnum GoSleep = 4;
	static WizardGames.Soc.Common.Entity.PlayerUnAliveStateEnum UnAliveNone = 5;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.SightStateEnum : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Entity.SightStateEnum Out = 0;
	static WizardGames.Soc.Common.Entity.SightStateEnum OutOfSightActionBack = 1;
	static WizardGames.Soc.Common.Entity.SightStateEnum OutOfSightAction = 2;
	static WizardGames.Soc.Common.Entity.SightStateEnum IntoSightAction = 3;
	static WizardGames.Soc.Common.Entity.SightStateEnum IntoSightActionBack = 4;
	static WizardGames.Soc.Common.Entity.SightStateEnum SightStable = 5;
	static WizardGames.Soc.Common.Entity.SightStateEnum None = 6;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.TrainEngineStateEnum : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Entity.TrainEngineStateEnum Starting = 0;
	static WizardGames.Soc.Common.Entity.TrainEngineStateEnum On = 1;
	static WizardGames.Soc.Common.Entity.TrainEngineStateEnum Running = 2;
	static WizardGames.Soc.Common.Entity.TrainEngineStateEnum Off = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Entity.TrainUnloadStateEnum : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Entity.TrainUnloadStateEnum None = 0;
	static WizardGames.Soc.Common.Entity.TrainUnloadStateEnum AutoParking = 1;
	static WizardGames.Soc.Common.Entity.TrainUnloadStateEnum Unloading = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.GatherReward : System.Object
{
	System.Int64 <Id>k__BackingField; // 0x10
	System.Int32 <InitialCount>k__BackingField; // 0x18
	System.Int32 <Count>k__BackingField; // 0x1c
	System.Boolean <IsPoiTaskItem>k__BackingField; // 0x20
	
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.GatherLogic : System.Object
{
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.GatherReward> Rewards; // 0x10
	System.Int32 CurrentRewardCount; // 0x18
	System.Int32 TotalRewardCount; // 0x1c
	System.Boolean FinishBonus; // 0x20
	
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.IItemEntity : , WizardGames.Soc.Common.Entity.IEmbeddedCustom, WizardGames.Soc.Common.Entity.IEntity
{
	
	System.Int64 get_OwnerEntityId(); // 0x054a4380
	System.Int64 get_ItemUid(); // 0x054a4380
	System.Int64 get_TableId(); // 0x054a4380
	System.Single get_Condition(); // 0x054a5abc
	System.Void set_Condition(System.Single value); // 0x05513724
	System.Single get_MaxCondition(); // 0x054a5abc
	System.Void set_MaxCondition(System.Single value); // 0x05513724
	System.Boolean get_isBroken(); // 0x054c4760
	System.Int32 get_Position(); // 0x0548ba98
	System.Int64 get_SkinId(); // 0x054a4380
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.IPrivateEntity : 
{
	
	System.Int64 get_BelongPlayerEntityId(); // 0x054a4380
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.IRechargeableEntity : , WizardGames.Soc.Common.Entity.IItemEntity, WizardGames.Soc.Common.Entity.IEmbeddedCustom, WizardGames.Soc.Common.Entity.IEntity
{
	
	System.Int32 get_PrepareTime(); // 0x0548ba98
	System.Void set_PrepareTime(System.Int32 value); // 0x055056e8
	System.Boolean get_CanRecharge(); // 0x054c4760
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.ISpawnEntity : 
{
	
	System.Int32 get_SpawnType(); // 0x0548ba98
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.ITemplateEntity : 
{
	
	System.Int64 get_TemplateId(); // 0x054a4380
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.IVehicleModuleCustom : 
{
	
	System.Int64 get_EntityId(); // 0x054a4380
	System.Single get_MaxHp(); // 0x054a5abc
	System.Single get_Hp(); // 0x054a5abc
	System.Int64 get_TemplateId(); // 0x054a4380
	System.Int64 get_DriverId(); // 0x054a4380
	System.Single get_Power(); // 0x054a5abc
	System.Int64 get_ModularCarId(); // 0x054a4380
	System.Int32 get_SocketIndex(); // 0x0548ba98
	System.Int32 get_SocketsTaken(); // 0x0548ba98
	System.Boolean get_Seat1Window(); // 0x054c4760
	System.Boolean get_Seat2Window(); // 0x054c4760
	WizardGames.Soc.Common.Entity.IItemEntity get_Carburetor(); // 0x054e7844
	WizardGames.Soc.Common.Entity.IItemEntity get_Crankshaft(); // 0x054e7844
	WizardGames.Soc.Common.Entity.IItemEntity get_Piston(); // 0x054e7844
	WizardGames.Soc.Common.Entity.IItemEntity get_SparkPlug(); // 0x054e7844
	WizardGames.Soc.Common.Entity.IItemEntity get_Valve(); // 0x054e7844
	System.Single get_LastHp(); // 0x054a5abc
	System.Collections.Generic.IEnumerable<WizardGames.Soc.Common.Entity.IItemEntity> GetEngineItems(); // 0x06f90c8c
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.IVehicleModuleCustom.<GetEngineItems>d__212 : System.Object, System.Collections.Generic.IEnumerable<WizardGames.Soc.Common.Entity.IItemEntity>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<WizardGames.Soc.Common.Entity.IItemEntity>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	WizardGames.Soc.Common.Entity.IItemEntity <>2__current; // 0x18
	System.Int32 <>l__initialThreadId; // 0x20
	WizardGames.Soc.Common.Entity.IVehicleModuleCustom <>4__this; // 0x28
	System.Void .ctor(System.Int32 <>1__state); // 0x06f90d30
	System.Void System.IDisposable.Dispose(); // 0x06f90dc0
	System.Boolean MoveNext(); // 0x06f90e20
	WizardGames.Soc.Common.Entity.IItemEntity System.Collections.Generic.IEnumerator<WizardGames.Soc.Common.Entity.IItemEntity>.get_Current(); // 0x06f91190
	System.Void System.Collections.IEnumerator.Reset(); // 0x06f911f4
	System.Object System.Collections.IEnumerator.get_Current(); // 0x06f9127c
	System.Collections.Generic.IEnumerator<WizardGames.Soc.Common.Entity.IItemEntity> System.Collections.Generic.IEnumerable<WizardGames.Soc.Common.Entity.IItemEntity>.GetEnumerator(); // 0x06f912e0
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x06f913b0
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.IWearItemEntity : , WizardGames.Soc.Common.Entity.IItemEntity, WizardGames.Soc.Common.Entity.IEmbeddedCustom, WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Common.Entity.IRechargeableEntity, WizardGames.Soc.Common.Entity.IConditionConsumeEntity
{
	
	System.Int32 get_ProtectAreaValue(); // 0x0548ba98
	WizardGames.Soc.Common.Algorithm.ConstList<System.Single> get_Protection(); // 0x054e7844
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.Request.EntityRemoveRequest : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	System.Int64 RemoveId; // 0x20
	System.Void Dispose(); // 0x06f91414
	System.Void .ctor(); // 0x06f91480
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.Interface.IMarkerEntity : 
{
	
	
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.EntityCollection.EntityIndexManager : System.Object
{
	
	static System.Int32 GetEntityIndex(System.Type type); // 0x06f914e8
	static System.Type GetEntityType(System.Int32 entityIndex); // 0x06f915dc
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.EntityCollection.EntityIndex<T> : System.Object
{
	static System.Int32 Index; // 0x0
	static System.Type Type; // 0x8
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.EntityCollection.EntitySetFactory : System.Object
{
	static System.Type IEntityType; // 0x0
	static System.Type EntitySetAttributeType; // 0x8
	static System.Type EntitySetGenericsType; // 0x10
	static System.Collections.Generic.Dictionary<System.Type,System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet>> EntityToSetMakerMap; // 0x18
	static System.Void Init(System.Collections.Generic.Dictionary<System.Type,System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet>> entityToSetMakerMap); // 0x06f916b4
	static WizardGames.Soc.Common.Entity.EntityCollection.EntitySet CreateEntitySet(System.Type type); // 0x06f91748
	static System.Void .cctor(); // 0x06f91a08
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.EntityCollection.EntitySetFactory.<>c : System.Object
{
	static WizardGames.Soc.Common.Entity.EntityCollection.EntitySetFactory.<>c <>9; // 0x0
	static System.Func<System.Type,System.Boolean> <>9__6_0; // 0x8
	static System.Void .cctor(); // 0x06f91b1c
	System.Void .ctor(); // 0x06f91b80
	System.Boolean <CreateEntitySet>b__6_0(System.Type i); // 0x06f91be8
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.EntityCollection.EntitySet : System.Object
{
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.IEntity> GenericEntities; // 0x10
	WizardGames.Soc.Common.Entity.IEntity FindEntity(System.Int64 Id); // 0x054e931c
	System.Void OnAddEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06f91cc0
	System.Void OnRemoveEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06f91f9c
	System.Void .ctor(); // 0x06f920b0
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.EntityCollection.EntitySet<T> : WizardGames.Soc.Common.Entity.EntityCollection.EntitySet
{
	System.Collections.Generic.Dictionary<System.Int64,T> Entities; // 0x0
	WizardGames.Soc.Common.Entity.IEntity FindEntity(System.Int64 Id); // 0x054e931c
	System.Void OnAddEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x05523a54
	System.Void OnRemoveEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x05523a54
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.EntityCollection.EntityTypeCache : System.Object
{
	static System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.List<System.Type>> EntityInterfaceMap; // 0x0
	static System.Int32[][] _entityItfs; // 0x8
	static SocLogger logger; // 0x10
	static System.Void Init(System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.List<System.Type>> entityInterfaceMap); // 0x06f92168
	static System.Int32[] GetInterfaces(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06f92c70
	static System.Int32[] GetInterfaces(System.Int32 entityIndex); // 0x06f92d78
	static System.Void .cctor(); // 0x06f92e6c
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.EntityCollection.InterfaceIndexManager : System.Object
{
	static SocLogger logger; // 0x0
	static System.Int32 InterfaceIndexLenght; // 0x8
	static System.Type[] _interfaceTypes; // 0x10
	static System.Void .cctor(); // 0x06f92f3c
	static System.Void Initialize(System.Collections.Generic.HashSet<System.Type> allInterfaceTypes); // 0x06f927b0
	static System.Int32 GetInterfaceIndex(System.Type type); // 0x06f92b40
	static System.Type GetInterfaceType(System.Int32 interfaceIndex); // 0x06f93010
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.EntityCollection.InterfaceIndex<T> : System.Object
{
	static System.Int32 Index; // 0x0
	static System.Type Type; // 0x8
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.EntityCollection.InterfaceCount : System.Object
{
	static System.Int32 Count; // 0x0
	
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.EntityCollection.Attribute.EntitySetAttribute : System.Attribute
{
	
	System.Void .ctor(); // 0x06f93168
}

// Client.Runtime
class WizardGames.Soc.Common.Entity.Collection.EntitySetCollection : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet[] EntityCollection; // 0x10
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet[] InterfaceCollection; // 0x18
	System.Void .ctor(); // 0x06f931d0
	System.Void EntitySetAddHandle(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06f93470
	System.Void EntitySetRemoveHandle(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06f939cc
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet<T> GetEntitySetViaType<T>(System.Boolean local); // 0x052af1f0
	WizardGames.Soc.Common.Entity.IEntity GetEntityViaType(System.Type EntityType, System.Int64 Id, System.Boolean local); // 0x06f93e30
	System.Collections.Generic.Dictionary<System.Int64,T> GetEntitiesViaType<T>(System.Boolean local); // 0x052af1f0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet<T> GetEntitySetViaInterface<T>(System.Boolean local); // 0x052af1f0
	System.Collections.Generic.Dictionary<System.Int64,T> GetEntitiesViaInterface<T>(System.Boolean local); // 0x052af1f0
	static System.Void .cctor(); // 0x06f93fd4
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.Ability.IHitTargetHistory : 
{
	
	System.Void AddTargetHistory(System.Int64 entityID); // 0x055112ac
	System.Boolean HasHitTarget(System.Int64 entityID); // 0x054c5f44
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.Ability.IPredictEntity : 
{
	
	System.Boolean get_Predict(); // 0x054c4760
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.Ability.IProjectile : , WizardGames.Soc.Common.Entity.Ability.IHitTargetHistory, IPredictHitTarget
{
	
	System.Int64 get_EntityId(); // 0x054a4380
	System.Int64 get_OwnerEntityId(); // 0x054a4380
	System.Int32 get_OwnerEntityType(); // 0x0548ba98
	System.Int64 get_OwnerTableID(); // 0x054a4380
	System.Single get_CreateTime(); // 0x054a5abc
	System.Boolean get_Destroy(); // 0x054c4760
	System.Void set_Destroy(System.Boolean value); // 0x05523a7c
	System.Single get_Power(); // 0x054a5abc
	System.Void set_Power(System.Single value); // 0x05513724
	System.Int32 get_PierceNum(); // 0x0548ba98
	System.Void set_PierceNum(System.Int32 value); // 0x055056e8
	System.Numerics.Vector3 get_Acceleration(); // 0x054b1148
	System.Void set_Acceleration(System.Numerics.Vector3 value); // 0x05514688
	System.Int32 get_NowSequence(); // 0x0548ba98
	System.Void set_NowSequence(System.Int32 value); // 0x055056e8
	System.Int32 get_StartSequence(); // 0x0548ba98
	System.Numerics.Vector3 get_LogicVelocity(); // 0x054b1148
	System.Void set_LogicVelocity(System.Numerics.Vector3 value); // 0x05514688
	System.Numerics.Vector3 get_LogicDirection(); // 0x054b1148
	System.Void set_LogicDirection(System.Numerics.Vector3 value); // 0x05514688
	System.Numerics.Vector3 get_LogicPosition(); // 0x054b1148
	System.Void set_LogicPosition(System.Numerics.Vector3 value); // 0x05514688
	System.Single get_DamageScale(); // 0x054a5abc
	System.Void set_DamageScale(System.Single value); // 0x05513724
	System.Int64 get_WeaponTableID(); // 0x054a4380
	System.Int64 get_SkinID(); // 0x054a4380
	System.Numerics.Vector3 get_BornPosition(); // 0x054b1148
	System.Int64 get_TableId(); // 0x054a4380
	System.Int32 get_FuzeDuration(); // 0x0548ba98
	System.Int32 get_BulletIndex(); // 0x0548ba98
	System.Boolean get_MagicBullet(); // 0x054c4760
	System.Int64 get_Identifier(); // 0x054a4380
	System.Int64 get_WeaponId(); // 0x054a4380
	System.Boolean get_IsMeleeThrow(); // 0x054c4760
	System.Numerics.Vector3 get_SourceEntityPosition(); // 0x054b1148
	System.Single get_AdsProgress(); // 0x054a5abc
	System.Int32 get_SourceMoveState(); // 0x0548ba98
	System.Int32 get_SourcePoseState(); // 0x0548ba98
	System.Int32 get_SourceMonumentID(); // 0x0548ba98
	System.Boolean get_HitScreenBox(); // 0x054c4760
	System.Void set_HitScreenBox(System.Boolean value); // 0x05523a7c
	System.Int32 get_Tag(); // 0x0548ba98
	System.Single get_TotalMoveDistance(); // 0x054a5abc
	System.Void set_TotalMoveDistance(System.Single value); // 0x05513724
}

// Client.Runtime
interface WizardGames.Soc.Common.Entity.Ability.IWeaponState : 
{
	
	
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.AccessoryDisplayData : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1077469808;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06f940a8
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f94110
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f9419c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f94228
	System.Int64 get_TableId(); // 0x06f942b4
	System.Void set_TableId(System.Int64 value); // 0x06f94328
	System.Int64 get_SkinId(); // 0x06f943b4
	System.Void set_SkinId(System.Int64 value); // 0x06f94428
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f944b4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06f94778
	System.Void .ctor(WizardGames.Soc.Common.CustomType.AccessoryDisplayData other); // 0x06f94aa4
	static System.Void .cctor(); // 0x06f94b5c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.CreateBuildingNode : WizardGames.Soc.Common.CustomType.AsyncNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1729747609;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06f94cf0
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f94d58
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f94eb0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f95008
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f95160
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06f953c8
	static System.Void .cctor(); // 0x06f956a8
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.CreateBuildingWithPathNode : WizardGames.Soc.Common.CustomType.AsyncNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1272065199;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06f95974
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f959dc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f95a88
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f95b34
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f95be0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06f95e48
	static System.Void .cctor(); // 0x06f96128
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.SpawnHorseNode : WizardGames.Soc.Common.CustomType.AsyncNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 705642430;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06f9645c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f964c4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f96570
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f9661c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f966c8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06f96930
	static System.Void .cctor(); // 0x06f96c10
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.SpawnMiniCopterNode : WizardGames.Soc.Common.CustomType.AsyncNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 2138557406;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06f96f78
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f96fe0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f9708c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f97138
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f971e4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06f9744c
	static System.Void .cctor(); // 0x06f9772c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.SpawnRowBoatNode : WizardGames.Soc.Common.CustomType.AsyncNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 2011754181;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06f97a60
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f97ac8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f97b74
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f97c20
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f97ccc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06f97f34
	static System.Void .cctor(); // 0x06f98214
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.SpawnModularCarNode : WizardGames.Soc.Common.CustomType.AsyncNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1197788213;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06f98548
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f985b0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f9865c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f98708
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f987b4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06f98a1c
	static System.Void .cctor(); // 0x06f98cfc
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.MovePlayersNode : WizardGames.Soc.Common.CustomType.AsyncNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 402619030;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06f99030
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f99098
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f99144
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f991f0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f9929c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06f99504
	static System.Void .cctor(); // 0x06f997e4
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.MakePlayerRebornNode : WizardGames.Soc.Common.CustomType.AsyncNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1870763462;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06f99ae4
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f99b4c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f99bf8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f99ca4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f99d50
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06f99fb8
	static System.Void .cctor(); // 0x06f9a298
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.SetPlayerStatusNode : WizardGames.Soc.Common.CustomType.AsyncNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 222719969;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06f9a564
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f9a5cc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f9a678
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f9a724
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f9a7d0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06f9aa38
	static System.Void .cctor(); // 0x06f9ad18
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.SetPlayerInvincibleNode : WizardGames.Soc.Common.CustomType.AsyncNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 794914467;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06f9afe4
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f9b04c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f9b0f8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f9b1a4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f9b250
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06f9b4b8
	static System.Void .cctor(); // 0x06f9b798
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.KillPlayerNode : WizardGames.Soc.Common.CustomType.AsyncNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 334783790;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06f9b9c8
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f9ba30
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f9badc
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f9bb88
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f9bc34
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06f9be9c
	static System.Void .cctor(); // 0x06f9c17c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.GameEndKickPlayerNode : WizardGames.Soc.Common.CustomType.AsyncNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1130257614;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06f9c3ac
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f9c414
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f9c4c0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f9c56c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f9c618
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06f9c880
	static System.Void .cctor(); // 0x06f9cb60
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.RequestPlayerSupplyNode : WizardGames.Soc.Common.CustomType.AsyncNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 519526575;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06f9cdf8
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f9ce60
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f9cf0c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f9cfb8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f9d064
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06f9d2cc
	static System.Void .cctor(); // 0x06f9d5ac
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.CancelPlayerSupplyNode : WizardGames.Soc.Common.CustomType.AsyncNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 813579778;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06f9d7dc
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f9d844
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f9d8f0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f9d99c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f9da48
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06f9dcb0
	static System.Void .cctor(); // 0x06f9df90
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ActivityContainer : WizardGames.Soc.Common.CustomType.DirectoryNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1604425711;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06f9e18c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f9e1f4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f9e2a4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f9e354
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f9e404
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06f9e844
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06f9ec18
	static System.Object DeserializeActivityContainerContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f9ee70
	static System.Void .cctor(); // 0x06f9ef44
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.AirdropData : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1606999539;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06f9f174
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f9f1dc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f9f268
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f9f2f4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f9f380
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06f9f5e8
	static System.Void .cctor(); // 0x06f9f8c8
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.Alpha3BucketAddWaterResult : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 131798110;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06f9fac4
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f9fb2c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f9fbb8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f9fc44
	System.Int64 get_PlantColId(); // 0x06f9fcd0
	System.Void set_PlantColId(System.Int64 value); // 0x06f9fd44
	System.Single get_Water(); // 0x06f9fdd0
	System.Void set_Water(System.Single value); // 0x06f9fe44
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f9fed0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fa0190
	static System.Void .cctor(); // 0x06fa04c8
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.Alpha3BuffData : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 2030943804;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fa065c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fa06c4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fa0750
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fa07dc
	System.Int32 get_BuffId(); // 0x06fa0868
	System.Void set_BuffId(System.Int32 value); // 0x06fa08dc
	System.Int64 get_EntityId(); // 0x06fa0968
	System.Void set_EntityId(System.Int64 value); // 0x06fa09dc
	System.Int32 get_OverlayCount(); // 0x06fa0a68
	System.Void set_OverlayCount(System.Int32 value); // 0x06fa0adc
	System.Int32 get_Level(); // 0x06fa0b68
	System.Void set_Level(System.Int32 value); // 0x06fa0bdc
	System.Int64 get_StartTime(); // 0x06fa0c68
	System.Void set_StartTime(System.Int64 value); // 0x06fa0cdc
	System.Int64 get_EndTime(); // 0x06fa0d68
	System.Void set_EndTime(System.Int64 value); // 0x06fa0ddc
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fa0e68
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fa11c4
	static System.Void .cctor(); // 0x06fa1558
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.Alpha3ElectricCircuitInterface : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 480635141;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fa17bc
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fa1824
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fa18b0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fa193c
	System.Int64 get_MapUnit(); // 0x06fa19c8
	System.Void set_MapUnit(System.Int64 value); // 0x06fa1a3c
	System.Int32 get_OpType(); // 0x06fa1ac8
	System.Void set_OpType(System.Int32 value); // 0x06fa1b3c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fa1bc8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fa1e8c
	System.Void .ctor(); // 0x06fa21c8
	static System.Void .cctor(); // 0x06fa2230
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.Alpha3ElectricCircuitSlot : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1179439140;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fa23f8
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fa2460
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fa24ec
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fa2578
	System.Int32 get_Id(); // 0x06fa2604
	System.Void set_Id(System.Int32 value); // 0x06fa2678
	System.Int64 get_MapUnit(); // 0x06fa2704
	System.Void set_MapUnit(System.Int64 value); // 0x06fa2778
	System.Int32 get_MapPort(); // 0x06fa2804
	System.Void set_MapPort(System.Int32 value); // 0x06fa2878
	System.String get_Name(); // 0x06fa2904
	System.Void set_Name(System.String value); // 0x06fa2978
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fa2a04
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fa2d18
	System.Void .ctor(); // 0x06fa3094
	static System.Void .cctor(); // 0x06fa30fc
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.SimpleCustom.ISnapshot<WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit>
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 796610892;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fa332c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fa3394
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fa3420
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fa35b4
	System.Int64 get_Id(); // 0x06fa3640
	System.Void set_Id(System.Int64 value); // 0x06fa36b4
	System.Int64 get_EntityId(); // 0x06fa3740
	System.Void set_EntityId(System.Int64 value); // 0x06fa37b4
	System.String get_Name(); // 0x06fa3840
	System.Void set_Name(System.String value); // 0x06fa38b4
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.ElectricFakeEntity> get_Units(); // 0x06fa3940
	System.Void set_Units(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.ElectricFakeEntity> value); // 0x06fa39e0
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.Alpha3ElectricUnitWire> get_Wires(); // 0x06fa3a6c
	System.Void set_Wires(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.Alpha3ElectricUnitWire> value); // 0x06fa3b0c
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int32,WizardGames.Soc.Common.CustomType.Alpha3ElectricCircuitSlot> get_SlotPortMap(); // 0x06fa3b98
	System.Void set_SlotPortMap(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int32,WizardGames.Soc.Common.CustomType.Alpha3ElectricCircuitSlot> value); // 0x06fa3c38
	WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.Alpha3ElectricCircuitInterface> get_CircuitInterface(); // 0x06fa3cc4
	System.Void set_CircuitInterface(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.Alpha3ElectricCircuitInterface> value); // 0x06fa3d64
	System.Int32 get_StorageNow(); // 0x06fa3df0
	System.Void set_StorageNow(System.Int32 value); // 0x06fa3e64
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x06fa3ef0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fa41dc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fa48b0
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06fa4d30
	static System.Object DeserializeAlpha3ElectricIntegratedCircuitContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fa52fc
	System.Void .ctor(); // 0x06fa548c
	WizardGames.Soc.Common.SimpleCustom.ISnapshot<WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit> MakeSnapshot(); // 0x06fa54f4
	System.Void ApplyCmd(WizardGames.Soc.Common.SimpleCustom.ICmd cmd); // 0x06fa555c
	System.Boolean GenRevertCmd(WizardGames.Soc.Common.SimpleCustom.ICmd cmd, WizardGames.Soc.Common.SimpleCustom.ICmd& rcmd); // 0x06fa55dc
	System.Boolean OnlineVerify(WizardGames.Soc.Common.SimpleCustom.ICmd cmd); // 0x06fa5668
	static System.Void .cctor(); // 0x06fa56e8
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.Alpha3ElectricUnitWire : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 797927723;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fa59e8
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fa5a50
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fa5adc
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fa5bb0
	System.Int64 get_Id(); // 0x06fa5c3c
	System.Void set_Id(System.Int64 value); // 0x06fa5cb0
	System.Int64 get_InputUnitId(); // 0x06fa5d3c
	System.Void set_InputUnitId(System.Int64 value); // 0x06fa5db0
	System.Int32 get_InputPortId(); // 0x06fa5e3c
	System.Void set_InputPortId(System.Int32 value); // 0x06fa5eb0
	System.Int64 get_OutputUnitId(); // 0x06fa5f3c
	System.Void set_OutputUnitId(System.Int64 value); // 0x06fa5fb0
	System.Int32 get_OutputPortId(); // 0x06fa603c
	System.Void set_OutputPortId(System.Int32 value); // 0x06fa60b0
	System.Int32 get_LineColor(); // 0x06fa613c
	System.Void set_LineColor(System.Int32 value); // 0x06fa61b0
	WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.CustomVector3> get_PointLst(); // 0x06fa623c
	System.Void set_PointLst(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.CustomVector3> value); // 0x06fa62dc
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x06fa6368
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fa64c8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fa6930
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06fa6d1c
	static System.Object DeserializeAlpha3ElectricUnitWireContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fa6f64
	System.Void .ctor(); // 0x06fa7034
	static System.Void .cctor(); // 0x06fa709c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.AppendingResetGradeData : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 822055975;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fa7334
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fa739c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fa7428
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fa74b4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fa7540
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fa77a8
	static System.Object DeserializeAppendingResetGradeDataContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fa7a88
	static System.Void .cctor(); // 0x06fa7b5c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.AppendingResetPartData : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 700390348;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fa7cf0
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fa7d58
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fa7de4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fa7e70
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fa7efc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fa8164
	static System.Object DeserializeAppendingResetPartDataContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fa8444
	static System.Void .cctor(); // 0x06fa8514
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.AsyncNode : WizardGames.Soc.Common.CustomType.BaseNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1267072933;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fa86a8
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06f94e04
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06f94f5c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06f950b4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fa88b4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fa8b1c
	static System.Void .cctor(); // 0x06fa8dfc
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.AttachCustomType : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 563441134;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fa8f90
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fa8ff8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fa9084
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fa9110
	System.Int64 get_Bzid(); // 0x06fa919c
	System.Void set_Bzid(System.Int64 value); // 0x06fa9210
	System.Int32 get_Count(); // 0x06fa929c
	System.Void set_Count(System.Int32 value); // 0x06fa9310
	System.Boolean get_Received(); // 0x06fa939c
	System.Void set_Received(System.Boolean value); // 0x06fa9410
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fa949c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fa9784
	System.String ToPrettyString(); // 0x06fa9ae4
	static System.Void .cctor(); // 0x06fa9c84
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BadgeTaskContainer : WizardGames.Soc.Common.CustomType.TaskContainer
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1275048162;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fa9e4c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fa9eb4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fa9f64
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06faa014
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06faa0c4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06faa600
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06faa9f8
	static System.Object DeserializeBadgeTaskContainerContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06faad8c
	static System.Void .cctor(); // 0x06faaf34
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BannedPlayerInfo : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1981079650;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fab29c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fab304
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fab390
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fab41c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fab4a8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fab710
	static System.Void .cctor(); // 0x06fab9f0
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BannedPlayerTerritoryInfo : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1258363876;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fabb84
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fabbec
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fabc78
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fabd04
	System.Single get_PosX(); // 0x06fabd90
	System.Void set_PosX(System.Single value); // 0x06fabe04
	System.Single get_PosY(); // 0x06fabe90
	System.Void set_PosY(System.Single value); // 0x06fabf04
	System.Single get_PosZ(); // 0x06fabf90
	System.Void set_PosZ(System.Single value); // 0x06fac004
	System.String get_PlayerName(); // 0x06fac090
	System.Void set_PlayerName(System.String value); // 0x06fac104
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fac190
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fac498
	static System.Void .cctor(); // 0x06fac800
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BaseItemNode : WizardGames.Soc.Common.CustomType.NodeBase, WizardGames.Soc.Share.Game.NodeSystem.IItemNode, WizardGames.Soc.Share.Game.NodeSystem.INode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 281960919;
	static System.Int32 StaticClassHash; // 0x8
	System.Int32 GetClassHash(); // 0x06faca64
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06facacc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06facb7c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06facc2c
	System.Single get_Condition(); // 0x06faccdc
	System.Void set_Condition(System.Single value); // 0x06facd50
	System.Single get_MaxCondition(); // 0x06facddc
	System.Void set_MaxCondition(System.Single value); // 0x06face50
	System.Boolean get_IsLocked(); // 0x06facedc
	System.Void set_IsLocked(System.Boolean value); // 0x06facf50
	System.Int64 get_SkinId(); // 0x06facfdc
	System.Void set_SkinId(System.Int64 value); // 0x06fad050
	System.Boolean get_IsEnterInventory(); // 0x06fad0dc
	System.Void set_IsEnterInventory(System.Boolean value); // 0x06fad150
	System.Boolean get_BanMoveOP(); // 0x06fad1dc
	System.Int64 get_ItemId(); // 0x06fad240
	WizardGames.Soc.Common.Data.DataItem.ItemConfig get_ItemConfig(); // 0x06fad2a8
	WizardGames.Soc.Common.Data.DataItem.ItemEntityType get_TypeId(); // 0x06fad3a8
	System.Boolean get_HasCondition(); // 0x06fad41c
	System.Boolean get_IsBroken(); // 0x06fad4b4
	System.Void .ctor(System.Int64 bizId, System.Int64 index); // 0x06fad538
	System.Boolean HasFlag(WizardGames.Soc.Common.Data.DataItem.ItemFlags flag); // 0x06fad658
	System.String ToPrettyString(); // 0x06fad700
	System.Int64 get_NodeId(); // 0x06fad99c
	System.Int64 get_ColId(); // 0x06fada0c
	System.Int64 get_ConfigId(); // 0x06fadb48
	WizardGames.Soc.Common.Data.DataItem.ItemConfig get_Config(); // 0x06fadbbc
	System.String get_ItemName(); // 0x06fadc20
	System.Int64 get_ItemContainerIndex(); // 0x06fadcb8
	System.Int64 get_HoldEntityId(); // 0x06faddf8
	System.Int32 get_Amount(); // 0x06fade8c
	System.Int32 get_MaxStackSize(); // 0x06fadef0
	WizardGames.Soc.Common.CustomType.DirectoryItemNode get_AsContainer(); // 0x06fadf54
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap get_ParentNode(); // 0x06fae000
	WizardGames.Soc.Common.CustomType.Alpha3ContainerClient get_ParentContainer(); // 0x06fae084
	System.Int32 get_Position(); // 0x06fae154
	System.Int64 get_BlueprintTargetItemId(); // 0x06fae1c0
	System.Collections.Generic.IDictionary<System.Int64,System.Int64> get_Contents(); // 0x06fae2a8
	System.Int32 get_ContentsCapcity(); // 0x06fae30c
	System.Int64 get_SceneEntityId(); // 0x06fae370
	System.Int64 get_CollectableEntityId(); // 0x06fae438
	System.Int32 GetAmount(System.Int64 cfgId); // 0x06fae510
	System.Boolean CanStack(WizardGames.Soc.Common.CustomType.BaseItemNode item); // 0x06fae5b8
	System.Boolean IsChildContainer(WizardGames.Soc.Common.CustomType.Alpha3ContainerClient containerClient); // 0x06fae704
	System.Boolean CanMoveTo(WizardGames.Soc.Common.CustomType.Alpha3ContainerClient containerClient, System.Int32 targetPos, System.Boolean allowStack); // 0x06fae840
	System.Boolean CanMoveToContainer(WizardGames.Soc.Common.CustomType.Alpha3ContainerClient newContainer, System.Int32 targetPos, System.Boolean allowStack); // 0x06faec38
	static System.Void .cctor(); // 0x06faf75c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BaseNode : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1079765361;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06faf848
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fa8710
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fa879c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fa8828
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06faf8b0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fafb18
	static System.Void .cctor(); // 0x06fafdf8
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BatchChangeSkinRecord : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 769926270;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06faff8c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fafff4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fb0080
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fb010c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fb0198
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fb0400
	static System.Object DeserializeBatchChangeSkinRecordContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fb06e0
	static System.Void .cctor(); // 0x06fb0804
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BatchUpgradeChildInfo : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1414683972;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fb0a68
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fb0ad0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fb0b5c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fb0be8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fb0c74
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fb0edc
	static System.Void .cctor(); // 0x06fb11bc
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BatchUpgradePartInfo : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1291879282;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fb1350
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fb13b8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fb1444
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fb14d0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fb155c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fb17c4
	static System.Void .cctor(); // 0x06fb1aa4
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BatchUpgradeRecord : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1467751138;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fb1cd4
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fb1d3c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fb1dc8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fb1e54
	System.Int64 get_FinishTs(); // 0x06fb1ee0
	System.Void set_FinishTs(System.Int64 value); // 0x06fb1f54
	System.Int32 get_TargetGrade(); // 0x06fb1fe0
	System.Void set_TargetGrade(System.Int32 value); // 0x06fb2054
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fb20e0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fb23a8
	static System.Object DeserializeBatchUpgradeRecordContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fb26e8
	static System.Void .cctor(); // 0x06fb2814
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BatteryItemNode : WizardGames.Soc.Common.CustomType.UniqueItemNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1442579114;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fb2b14
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fb2b7c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fb2c2c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fb2cdc
	System.Single get_CurrentPower(); // 0x06fb2d8c
	System.Void set_CurrentPower(System.Single value); // 0x06fb2e00
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fb2e8c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fb32b4
	static System.Void .cctor(); // 0x06fb36ec
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BattleSummary : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 609248502;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fb3a88
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fb3af0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fb3b7c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fb3ccc
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Int32> get_BattleData(); // 0x06fb3d58
	System.Void set_BattleData(WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Int32> value); // 0x06fb3df8
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.PartGradeCount> get_DestroyedContruction(); // 0x06fb3e84
	System.Void set_DestroyedContruction(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.PartGradeCount> value); // 0x06fb3f24
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Int32> get_DestroyedFurnishing(); // 0x06fb3fb0
	System.Void set_DestroyedFurnishing(WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Int32> value); // 0x06fb4050
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Int32> get_UsedExplosiveItems(); // 0x06fb40dc
	System.Void set_UsedExplosiveItems(WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Int32> value); // 0x06fb417c
	System.String get_Name(); // 0x06fb4208
	System.Void set_Name(System.String value); // 0x06fb427c
	System.String get_Portrait(); // 0x06fb4308
	System.Void set_Portrait(System.String value); // 0x06fb437c
	System.UInt32 get_PortraitFrame(); // 0x06fb4408
	System.Void set_PortraitFrame(System.UInt32 value); // 0x06fb447c
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x06fb4508
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fb4668
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fb4c98
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06fb50c4
	static System.Object DeserializeBattleSummaryContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fb5644
	static System.Void .cctor(); // 0x06fb5778
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BeastExperimentSampleTaskNode : WizardGames.Soc.Common.CustomType.PoiTaskNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1654491019;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fb5a10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fb5a78
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fb5b28
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fb5bd8
	System.Boolean get_HasPlacedTrap(); // 0x06fb5c88
	System.Void set_HasPlacedTrap(System.Boolean value); // 0x06fb5cfc
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fb5d88
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fb6214
	static System.Void .cctor(); // 0x06fb6668
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BeeBuzzContributeRecord : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 321151520;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fb699c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fb6a04
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fb6a90
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fb6b1c
	System.Int64 get_PlayerEntityId(); // 0x06fb6ba8
	System.Void set_PlayerEntityId(System.Int64 value); // 0x06fb6c1c
	System.Int64 get_TaskId(); // 0x06fb6ca8
	System.Void set_TaskId(System.Int64 value); // 0x06fb6d1c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fb6da8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fb706c
	static System.Void .cctor(); // 0x06fb7398
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BeeBuzzTaskContainer : WizardGames.Soc.Common.CustomType.TaskContainer
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1082962658;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fb752c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fb7594
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fb7644
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fb76f4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fb77a4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fb7ce0
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06fb80d8
	static System.Object DeserializeBeeBuzzTaskContainerContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fb846c
	static System.Void .cctor(); // 0x06fb8614
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BiologicalSampleTaskNode : WizardGames.Soc.Common.CustomType.PoiTaskNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 2047439651;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fb897c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fb89e4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fb8a94
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fb8b44
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fb8bf4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fb905c
	static System.Void .cctor(); // 0x06fb948c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BluePrintInfo : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1655857255;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fb978c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fb97f4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fb9880
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fb990c
	System.Int32 get_Count(); // 0x06fb9998
	System.Void set_Count(System.Int32 value); // 0x06fb9a0c
	System.Boolean get_Collect(); // 0x06fb9a98
	System.Void set_Collect(System.Boolean value); // 0x06fb9b0c
	System.Boolean get_Check(); // 0x06fb9b98
	System.Void set_Check(System.Boolean value); // 0x06fb9c0c
	System.Int32 get_CollectTime(); // 0x06fb9c98
	System.Void set_CollectTime(System.Int32 value); // 0x06fb9d0c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fb9d98
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fba0ac
	static System.Void .cctor(); // 0x06fba418
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BlueprintRootNode : WizardGames.Soc.Common.CustomType.SystemRootNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 494616719;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fba614
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fba67c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fba72c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fba7dc
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x06fba88c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fba9ec
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fbaf28
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06fbb334
	static System.Object DeserializeBlueprintRootNodeContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fbb6c8
	System.String ToTreeString(System.Int32 level); // 0x06fbb7ec
	static System.Void .cctor(); // 0x06fbbe8c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BoolNode : WizardGames.Soc.Common.CustomType.NodeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 697959808;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fbc0f0
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fbc158
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fbc208
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fbc2b8
	System.Boolean get_Value(); // 0x06fbc368
	System.Void set_Value(System.Boolean value); // 0x06fbc3dc
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fbc468
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fbc7b0
	static System.Void .cctor(); // 0x06fbcb50
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BriefPrivilegeInfo : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 940583491;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fbcd80
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fbcde8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fbce74
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fbcf8c
	System.Int32 get_IdentityType(); // 0x06fbd018
	System.Void set_IdentityType(System.Int32 value); // 0x06fbd08c
	WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int32> get_GroupIds(); // 0x06fbd118
	System.Void set_GroupIds(WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int32> value); // 0x06fbd1b8
	WizardGames.Soc.Common.CustomType.BriefTerritoryInfo get_TerritoryInfo(); // 0x06fbd244
	System.Void set_TerritoryInfo(WizardGames.Soc.Common.CustomType.BriefTerritoryInfo value); // 0x06fbd308
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fbd394
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fbd7c8
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06fbdb64
	static System.Object DeserializeBriefPrivilegeInfoContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fbddac
	static System.Void .cctor(); // 0x06fbde80
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BriefTerritoryInfo : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1096052555;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fbe048
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fbe0b0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fbe13c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fbe230
	System.String get_Name(); // 0x06fbe2bc
	System.Void set_Name(System.String value); // 0x06fbe330
	System.Int32 get_MaxWorkbenchLevel(); // 0x06fbe3bc
	System.Void set_MaxWorkbenchLevel(System.Int32 value); // 0x06fbe430
	System.Single get_ProtectMinutes(); // 0x06fbe4bc
	System.Void set_ProtectMinutes(System.Single value); // 0x06fbe530
	System.Single get_PosX(); // 0x06fbe5bc
	System.Void set_PosX(System.Single value); // 0x06fbe630
	System.Single get_PosY(); // 0x06fbe6bc
	System.Void set_PosY(System.Single value); // 0x06fbe730
	System.Single get_PosZ(); // 0x06fbe7bc
	System.Void set_PosZ(System.Single value); // 0x06fbe830
	System.Boolean get_ReputationCabinet(); // 0x06fbe8bc
	System.Void set_ReputationCabinet(System.Boolean value); // 0x06fbe930
	System.Int64 get_TerritoryCabinetId(); // 0x06fbe9bc
	System.Void set_TerritoryCabinetId(System.Int64 value); // 0x06fbea30
	System.Boolean get_ReputationCabinetHaveItem(); // 0x06fbeabc
	System.Void set_ReputationCabinetHaveItem(System.Boolean value); // 0x06fbeb30
	System.Boolean get_HaveSafetyBoxRemainingSupplies(); // 0x06fbebbc
	System.Void set_HaveSafetyBoxRemainingSupplies(System.Boolean value); // 0x06fbec30
	System.Boolean get_IsPlundering(); // 0x06fbecbc
	System.Void set_IsPlundering(System.Boolean value); // 0x06fbed30
	System.Boolean get_HasDebris(); // 0x06fbedbc
	System.Void set_HasDebris(System.Boolean value); // 0x06fbee30
	System.Boolean get_IsPrimaryTerritory(); // 0x06fbeebc
	System.Void set_IsPrimaryTerritory(System.Boolean value); // 0x06fbef30
	WizardGames.Soc.Common.CustomType.CommunityInfo get_CommunityInfo(); // 0x06fbefbc
	System.Void set_CommunityInfo(WizardGames.Soc.Common.CustomType.CommunityInfo value); // 0x06fbf080
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fbf10c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fbf5b4
	static System.Void .cctor(); // 0x06fbfa04
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BuffNode : WizardGames.Soc.Common.CustomType.NodeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 411398242;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fbfe08
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fbfe70
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fbff20
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fbffd0
	System.Int64 get_EndTime(); // 0x06fc0080
	System.Void set_EndTime(System.Int64 value); // 0x06fc00f4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fc0180
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fc04c8
	static System.Void .cctor(); // 0x06fc0858
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BuffRootNode : WizardGames.Soc.Common.CustomType.SystemRootNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 646551519;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fc0abc
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fc0b24
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fc0bd4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fc0c84
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x06fc0d34
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fc0e94
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fc13d0
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06fc17dc
	static System.Object DeserializeBuffRootNodeContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fc1b70
	static System.Void .cctor(); // 0x06fc1c94
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BuffTypeContainerNode : WizardGames.Soc.Common.CustomType.DirectoryNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 998648283;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fc1ef8
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fc1f60
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fc2010
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fc20c0
	System.Int32 get_BuffValue(); // 0x06fc2170
	System.Void set_BuffValue(System.Int32 value); // 0x06fc21e4
	System.Int32 get_AbsoluteBuffValue(); // 0x06fc2270
	System.Void set_AbsoluteBuffValue(System.Int32 value); // 0x06fc22e4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fc2370
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fc2800
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06fc2c00
	static System.Object DeserializeBuffTypeContainerNodeContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fc2e58
	static System.Void .cctor(); // 0x06fc2f2c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BuffValueInfo : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 2033356561;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fc31c4
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fc322c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fc32b8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fc3344
	System.Int32 get_BuffTenThousandth(); // 0x06fc33d0
	System.Void set_BuffTenThousandth(System.Int32 value); // 0x06fc3444
	System.Int32 get_BuffAbsoluteValue(); // 0x06fc34d0
	System.Void set_BuffAbsoluteValue(System.Int32 value); // 0x06fc3544
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fc35d0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fc3894
	static System.Void .cctor(); // 0x06fc3bc0
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BuildingPartBriefCore : WizardGames.Soc.Common.CustomType.BuildingPartBrief
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1851962690;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fc3d54
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fc3dbc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fc3ef4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fc402c
	System.Int32 get_Grade(); // 0x06fc4164
	System.Void set_Grade(System.Int32 value); // 0x06fc41d8
	System.Int64 get_AdditionBlockInfo(); // 0x06fc4264
	System.Void set_AdditionBlockInfo(System.Int64 value); // 0x06fc42d8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fc4364
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fc4b10
	static System.Void .cctor(); // 0x06fc521c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BuildingPartBriefExDoorFlag : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.CustomType.IBuildingPartBriefEx
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 166165365;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fc551c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fc5584
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fc5610
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fc569c
	System.Int32 get_Flag(); // 0x06fc5728
	System.Void set_Flag(System.Int32 value); // 0x06fc579c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fc5828
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fc5ac8
	System.Void CleanupData(WizardGames.Soc.Common.CustomType.BuildingPartBriefWithExtraData infoExtra); // 0x06fc5de0
	System.Void RefreshData(WizardGames.Soc.Common.CustomType.BuildingPartBriefWithExtraData infoExtra); // 0x06fc5e54
	System.Int32 GetAnimState(); // 0x06fc5f84
	System.Void Setup(); // 0x06fc6020
	static System.Void .cctor(); // 0x06fc6080
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BuildingPartBriefExGapReal : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1909474671;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fc61e0
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fc6248
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fc62d4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fc6360
	System.Boolean get_IsShowLeft(); // 0x06fc63ec
	System.Void set_IsShowLeft(System.Boolean value); // 0x06fc6460
	System.Single get_PosXLeft(); // 0x06fc64ec
	System.Void set_PosXLeft(System.Single value); // 0x06fc6560
	System.Single get_PosYLeft(); // 0x06fc65ec
	System.Void set_PosYLeft(System.Single value); // 0x06fc6660
	System.Single get_PosZLeft(); // 0x06fc66ec
	System.Void set_PosZLeft(System.Single value); // 0x06fc6760
	System.Int32 get_RotLeft(); // 0x06fc67ec
	System.Void set_RotLeft(System.Int32 value); // 0x06fc6860
	System.Boolean get_IsShowRight(); // 0x06fc68ec
	System.Void set_IsShowRight(System.Boolean value); // 0x06fc6960
	System.Single get_PosXRight(); // 0x06fc69ec
	System.Void set_PosXRight(System.Single value); // 0x06fc6a60
	System.Single get_PosYRight(); // 0x06fc6aec
	System.Void set_PosYRight(System.Single value); // 0x06fc6b60
	System.Single get_PosZRight(); // 0x06fc6bec
	System.Void set_PosZRight(System.Single value); // 0x06fc6c60
	System.Int32 get_RotRight(); // 0x06fc6cec
	System.Void set_RotRight(System.Int32 value); // 0x06fc6d60
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fc6dec
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fc71d0
	static System.Void .cctor(); // 0x06fc75d0
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BuildingPartBriefExGap : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.CustomType.IBuildingPartBriefEx
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 721282362;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fc7904
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fc796c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fc79f8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fc7aec
	WizardGames.Soc.Common.CustomType.BuildingPartBriefExGapReal get_Data(); // 0x06fc7b78
	System.Void set_Data(WizardGames.Soc.Common.CustomType.BuildingPartBriefExGapReal value); // 0x06fc7c3c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fc7cc8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fc7ff4
	System.Void RefreshData(WizardGames.Soc.Common.CustomType.BuildingPartBriefWithExtraData infoExtra); // 0x06fc8338
	System.Void CleanupData(WizardGames.Soc.Common.CustomType.BuildingPartBriefWithExtraData infoExtra); // 0x06fc8424
	System.Void Setup(); // 0x06fc8510
	static System.Void .cctor(); // 0x06fc8570
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BuildingPartBriefExWindmill : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.CustomType.IBuildingPartBriefEx, WizardGames.Soc.Common.CustomType.IBuildingPartBriefExSubMovableMesh
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 215065070;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 timerId; // 0x28
	WizardGames.Soc.Common.Component.OutsideDataSetComponent outsideDataSetComp; // 0x30
	WizardGames.Soc.SocClient.Manager.BuildingEntityInfo infoInner; // 0x38
	System.Single Yaw; // 0x40
	System.Single Pitch; // 0x44
	System.Int32 GetClassHash(); // 0x06fc86d0
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fc8738
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fc87cc
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fc8860
	System.Boolean get_HavePower(); // 0x06fc88f4
	System.Void set_HavePower(System.Boolean value); // 0x06fc8968
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fc89f4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fc8c94
	WizardGames.Soc.Common.Component.OutsideDataSetComponent get_OutsideDataSetComp(); // 0x06fc8fac
	WizardGames.Soc.SocClient.Manager.BuildingEntityInfo get_Info(); // 0x06fc9038
	System.Void Setup(); // 0x06fc9180
	System.Void CleanupData(WizardGames.Soc.Common.CustomType.BuildingPartBriefWithExtraData infoExtra); // 0x06fc9264
	System.Void RefreshData(WizardGames.Soc.Common.CustomType.BuildingPartBriefWithExtraData infoExtra); // 0x06fc930c
	System.Void TickRender(System.Int64 _); // 0x06fc9aa0
	System.Void RefreshRender(System.Boolean force); // 0x06fc9478
	static System.Void .cctor(); // 0x06fc9b1c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BuildingPartBriefExYawRoll : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.CustomType.IBuildingPartBriefEx, WizardGames.Soc.Common.CustomType.IBuildingPartBriefExSubMovableMesh
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 354428289;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	WizardGames.Soc.SocClient.Manager.BuildingEntityInfo infoInner; // 0x28
	System.Int32 GetClassHash(); // 0x06fc9c7c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fc9ce4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fc9d70
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fc9dfc
	System.Int32 get_Yaw(); // 0x06fc9e88
	System.Void set_Yaw(System.Int32 value); // 0x06fc9efc
	System.Int32 get_Roll(); // 0x06fc9f88
	System.Void set_Roll(System.Int32 value); // 0x06fc9ffc
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fca088
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fca34c
	WizardGames.Soc.SocClient.Manager.BuildingEntityInfo get_Info(); // 0x06fca678
	System.Void CleanupData(WizardGames.Soc.Common.CustomType.BuildingPartBriefWithExtraData infoExtra); // 0x06fca7c0
	System.Void RefreshData(WizardGames.Soc.Common.CustomType.BuildingPartBriefWithExtraData infoExtra); // 0x06fca840
	System.Void RefreshRender(System.Boolean force); // 0x06fca8bc
	System.Void Setup(); // 0x06fcaf78
	static System.Void .cctor(); // 0x06fcafd8
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BuildingPartBriefWithExtraData : WizardGames.Soc.Common.CustomType.BuildingPartBrief
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 76612871;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fcb16c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fcb1d4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fcb280
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fcb374
	WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Share.Framework.CustomTypeBase> get_ExtraDatas(); // 0x06fcb420
	System.Void set_ExtraDatas(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Share.Framework.CustomTypeBase> value); // 0x06fcb4c0
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x06fcb54c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fcb6ac
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fcbb40
	static System.Object DeserializeBuildingPartBriefWithExtraDataContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fcbf44
	static System.Void .cctor(); // 0x06fcc010
	static System.Void OnIntFieldChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Int32 oldValue, System.Int32 newValue); // 0x06fcc6d8
	static System.Void OnFloatFieldChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Single oldValue, System.Single newValue); // 0x06fcc868
	static System.Void OnBoolFieldChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Boolean oldValue, System.Boolean newValue); // 0x06fcc90c
	static System.Void OnCustomTypeFieldChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, WizardGames.Soc.Share.Framework.CustomTypeBase newValue, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue); // 0x06fcc9b0
	static System.Void OnGeneralPropChanged(WizardGames.Soc.Share.Framework.TypeBase customType); // 0x06fcc77c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BuildingPartBrief : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 861056642;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fcca54
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fc3e68
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fc3fa0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fc40d8
	System.Int64 get_EntityId(); // 0x06fc4ef0
	System.Void set_EntityId(System.Int64 value); // 0x06fc473c
	System.Int64 get_TemplateId(); // 0x06fc4f64
	System.Void set_TemplateId(System.Int64 value); // 0x06fc47c8
	System.Int32 get_PosX(); // 0x06fc4fd8
	System.Void set_PosX(System.Int32 value); // 0x06fc4854
	System.Int32 get_PosY(); // 0x06fc504c
	System.Void set_PosY(System.Int32 value); // 0x06fc48e0
	System.Int32 get_PosZ(); // 0x06fc50c0
	System.Void set_PosZ(System.Int32 value); // 0x06fc496c
	System.Int32 get_Rot(); // 0x06fc5134
	System.Void set_Rot(System.Int32 value); // 0x06fc49f8
	System.Int64 get_SkinId(); // 0x06fc51a8
	System.Void set_SkinId(System.Int64 value); // 0x06fc4a84
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fccabc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fcce44
	UnityEngine.Vector3 get_Pos(); // 0x06fcd1f4
	System.Single get_RotY(); // 0x06fcd4e8
	System.Single get_RotX(); // 0x06fcd558
	System.Single get_RotZ(); // 0x06fcd5c8
	System.Int64 get_RealTemplateId(); // 0x06fcd638
	System.Int64 get_RealSkinId(); // 0x06fcd6a4
	static System.Void .cctor(); // 0x06fcd710
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BuildingPrivilegeGroup : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1134036908;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fcd9a8
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fcda10
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fcda9c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fcdb88
	System.Int32 get_Id(); // 0x06fcdc14
	System.Void set_Id(System.Int32 value); // 0x06fcdc88
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.UInt64,System.Int32> get_Teammates(); // 0x06fcdd14
	System.Void set_Teammates(WizardGames.Soc.Share.Framework.BasicValueDictionary<System.UInt64,System.Int32> value); // 0x06fcddb4
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.UInt64,System.Int32> get_OtherMembers(); // 0x06fcde40
	System.Void set_OtherMembers(WizardGames.Soc.Share.Framework.BasicValueDictionary<System.UInt64,System.Int32> value); // 0x06fcdee0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fcdf6c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fce3b8
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06fce740
	static System.Object DeserializeBuildingPrivilegeGroupContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fcea80
	System.Boolean IsMember(System.UInt64 roleId); // 0x06fceb5c
	static System.Void .cctor(); // 0x06fcec2c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.BulletItemCustom : WizardGames.Soc.Common.CustomType.EmbeddedCustomBase, WizardGames.Soc.Common.Entity.IItemEntity, WizardGames.Soc.Common.Entity.IEmbeddedCustom, WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Share.Framework.IPredictType
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1788435784;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 TableId_Local; // 0x28
	System.Int32 GetClassHash(); // 0x06fcedf4
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fcee5c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fcef0c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fcefdc
	System.Int64 get_OwnerEntityId(); // 0x06fcf08c
	System.Void set_OwnerEntityId(System.Int64 value); // 0x06fcf100
	System.Int64 get_ItemUid(); // 0x06fcf18c
	System.Void set_ItemUid(System.Int64 value); // 0x06fcf200
	System.Int64 get_TableId(); // 0x06fcf28c
	System.Void set_TableId(System.Int64 value); // 0x06fcf300
	System.Int32 get_Amount(); // 0x06fcf38c
	System.Void set_Amount(System.Int32 value); // 0x06fcf400
	System.Single get_Condition(); // 0x06fcf48c
	System.Void set_Condition(System.Single value); // 0x06fcf500
	System.Single get_MaxCondition(); // 0x06fcf58c
	System.Void set_MaxCondition(System.Single value); // 0x06fcf600
	System.Int32 get_Position(); // 0x06fcf68c
	System.Void set_Position(System.Int32 value); // 0x06fcf700
	System.Int64 get_SkinId(); // 0x06fcf78c
	System.Void set_SkinId(System.Int64 value); // 0x06fcf800
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fcf88c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fcfc88
	WizardGames.Soc.Share.Framework.IPredictType GetNewInstance(System.Int64 id); // 0x06fd0090
	System.Void .ctor(System.Int64 id); // 0x06fd0130
	System.Boolean get_isBroken(); // 0x06fd01d8
	static System.Void .cctor(); // 0x06fd0248
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.CaveExplorationTaskNode : WizardGames.Soc.Common.CustomType.PoiTaskNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 476058778;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fd057c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fd05e4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fd0694
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fd0744
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fd07f4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fd0c5c
	static System.Void .cctor(); // 0x06fd108c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ChainsawItemNode : WizardGames.Soc.Common.CustomType.UniqueItemNode, WizardGames.Soc.Share.Game.NodeSystem.IHaveBulletItemNode, WizardGames.Soc.Share.Game.NodeSystem.INode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 179294352;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fd138c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fd13f4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fd14a4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fd1554
	System.Int32 get_BulletBizId(); // 0x06fd1604
	System.Void set_BulletBizId(System.Int32 value); // 0x06fd1678
	System.Int32 get_BulletAmount(); // 0x06fd1704
	System.Void set_BulletAmount(System.Int32 value); // 0x06fd1778
	System.Int32 get_SubClipConsume(); // 0x06fd1804
	System.Void set_SubClipConsume(System.Int32 value); // 0x06fd1878
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fd1904
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fd1d40
	static System.Void .cctor(); // 0x06fd215c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ChatMessageWithInfoChannel : WizardGames.Soc.Common.CustomType.ChatMessageWithInfo
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 692632620;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fd2560
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fd25c8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fd2720
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fd2878
	System.UInt64 get_ChannelId(); // 0x06fd29d0
	System.Void set_ChannelId(System.UInt64 value); // 0x06fd2a44
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fd2ad0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fd357c
	static System.Void .cctor(); // 0x06fd3ef4
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ChatMessageWithInfo : WizardGames.Soc.Common.CustomType.ChatMessage
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1565526864;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fd42c4
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fd2674
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fd27cc
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fd2924
	System.String get_CachedSenderName(); // 0x06fd3bc8
	System.Void set_CachedSenderName(System.String value); // 0x06fd31a8
	System.Int32 get_ReputationLevel(); // 0x06fd3c3c
	System.Void set_ReputationLevel(System.Int32 value); // 0x06fd3234
	System.Int32 get_CachedSenderLevel(); // 0x06fd3cb0
	System.Void set_CachedSenderLevel(System.Int32 value); // 0x06fd32c0
	System.String get_Portrait(); // 0x06fd3d24
	System.Void set_Portrait(System.String value); // 0x06fd334c
	System.UInt32 get_PortraitFrame(); // 0x06fd3d98
	System.Void set_PortraitFrame(System.UInt32 value); // 0x06fd33d8
	System.UInt32 get_ChatBubble(); // 0x06fd3e0c
	System.Void set_ChatBubble(System.UInt32 value); // 0x06fd3464
	System.Int32 get_MessageType(); // 0x06fd3e80
	System.Void set_MessageType(System.Int32 value); // 0x06fd34f0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fd44d0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fd4914
	static System.Void .cctor(); // 0x06fd4d60
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ChatMessage : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 2016193785;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fd50fc
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fd432c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fd43b8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fd4444
	System.Int64 get_Ts(); // 0x06fd3984
	System.Void set_Ts(System.Int64 value); // 0x06fd2eec
	System.Int64 get_S(); // 0x06fd39f8
	System.Void set_S(System.Int64 value); // 0x06fd2f78
	System.String get_Content(); // 0x06fd3a6c
	System.Void set_Content(System.String value); // 0x06fd3004
	System.String get_MetaData(); // 0x06fd3ae0
	System.Void set_MetaData(System.String value); // 0x06fd3090
	System.UInt64 get_RoleId(); // 0x06fd3b54
	System.Void set_RoleId(System.UInt64 value); // 0x06fd311c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fd5164
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fd549c
	static System.Void .cctor(); // 0x06fd582c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ChatSession : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1545116687;
	static System.Int32 StaticClassHash; // 0x8
	System.Int32 GetClassHash(); // 0x06fd5a5c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fd5ac4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fd5b50
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fd5bdc
	System.UInt64 get_ChannelId(); // 0x06fd5c68
	System.Void set_ChannelId(System.UInt64 value); // 0x06fd5cdc
	System.UInt32 get_CurrentSeq(); // 0x06fd5d68
	System.Void set_CurrentSeq(System.UInt32 value); // 0x06fd5ddc
	System.UInt32 get_LastReadSeq(); // 0x06fd5e68
	System.Void set_LastReadSeq(System.UInt32 value); // 0x06fd5edc
	System.Void .ctor(System.UInt64 channelId); // 0x06fd5f68
	static System.Void .cctor(); // 0x06fd5ff0
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ChristmasLightsCustom : WizardGames.Soc.Common.CustomType.PartEntityCustom
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1564185187;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fd60dc
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fd6144
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fd61f4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fd62ec
	WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.PointWithNormal> get_Points(); // 0x06fd639c
	System.Void set_Points(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.PointWithNormal> value); // 0x06fd643c
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x06fd64c8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fd6624
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fd69a4
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06fd6ce8
	static System.Object DeserializeChristmasLightsCustomContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fd6f2c
	static System.Void .cctor(); // 0x06fd6ff8
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ClientLoadingSuccessEventNode : WizardGames.Soc.Common.CustomType.EventNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1893743385;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fd7158
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fd71c0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fd7270
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fd7320
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fd73d0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fd7638
	static System.Object DeserializeClientLoadingSuccessEventNodeContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fd7918
	static System.Void .cctor(); // 0x06fd79ec
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ComboChildPartData : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 787708311;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fd7c1c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fd7c84
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fd7d10
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fd7d9c
	System.Int32 get_State(); // 0x06fd7e28
	System.Void set_State(System.Int32 value); // 0x06fd7e9c
	System.Int64 get_PartTemplateId(); // 0x06fd7f28
	System.Void set_PartTemplateId(System.Int64 value); // 0x06fd7f9c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fd8028
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fd82ec
	static System.Void .cctor(); // 0x06fd8628
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.CommonComposeNode : WizardGames.Soc.Common.CustomType.NodeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1322263589;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fd87bc
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fd8824
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fd88d4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fd8984
	System.Int32 get_Interval(); // 0x06fd8a34
	System.Void set_Interval(System.Int32 value); // 0x06fd8aa8
	System.Int32 get_Count(); // 0x06fd8b34
	System.Void set_Count(System.Int32 value); // 0x06fd8ba8
	System.Int32 get_TotalCount(); // 0x06fd8c34
	System.Void set_TotalCount(System.Int32 value); // 0x06fd8ca8
	System.Int64 get_EndTime(); // 0x06fd8d34
	System.Void set_EndTime(System.Int64 value); // 0x06fd8da8
	System.Int64 get_SkinId(); // 0x06fd8e34
	System.Void set_SkinId(System.Int64 value); // 0x06fd8ea8
	System.Int32 get_PendingCount(); // 0x06fd8f34
	System.Void set_PendingCount(System.Int32 value); // 0x06fd8fa8
	System.Int32 get_ComposeSourceMark(); // 0x06fd9034
	System.Void set_ComposeSourceMark(System.Int32 value); // 0x06fd90a8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fd9134
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fd9564
	static System.Object DeserializeCommonComposeNodeContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fd997c
	static System.Void .cctor(); // 0x06fd9a4c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.CommonComposeQueueNode : WizardGames.Soc.Common.CustomType.NodeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1124773202;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fd9de8
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fd9e50
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fd9f00
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fd9fec
	WizardGames.Soc.Share.Framework.BasicTypeList<System.Int64> get_Elements(); // 0x06fda09c
	System.Void set_Elements(WizardGames.Soc.Share.Framework.BasicTypeList<System.Int64> value); // 0x06fda13c
	System.Boolean get_Pending(); // 0x06fda1c8
	System.Void set_Pending(System.Boolean value); // 0x06fda23c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fda2c8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fda714
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06fdab00
	static System.Object DeserializeCommonComposeQueueNodeContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fdad48
	static System.Void .cctor(); // 0x06fdae1c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.CommonComposeRootNode : WizardGames.Soc.Common.CustomType.ItemSystemRootNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1377922443;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fdb0b4
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fdb11c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fdb1cc
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fdb27c
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x06fdb32c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fdb48c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fdb9c8
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06fdbdd4
	static System.Object DeserializeCommonComposeRootNodeContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fdc168
	static System.Void .cctor(); // 0x06fdc28c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.CommonPosRotData : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 349393555;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fdc4f0
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fdc558
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fdc5e4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fdc670
	System.Single get_PosX(); // 0x06fdc6fc
	System.Void set_PosX(System.Single value); // 0x06fdc770
	System.Single get_PosY(); // 0x06fdc7fc
	System.Void set_PosY(System.Single value); // 0x06fdc870
	System.Single get_PosZ(); // 0x06fdc8fc
	System.Void set_PosZ(System.Single value); // 0x06fdc970
	System.Single get_RotationX(); // 0x06fdc9fc
	System.Void set_RotationX(System.Single value); // 0x06fdca70
	System.Single get_RotationY(); // 0x06fdcafc
	System.Void set_RotationY(System.Single value); // 0x06fdcb70
	System.Single get_RotationZ(); // 0x06fdcbfc
	System.Void set_RotationZ(System.Single value); // 0x06fdcc70
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fdccfc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fdd040
	static System.Void .cctor(); // 0x06fdd3c0
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.CommunityInfo : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 569644666;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fdd624
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fdd68c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fdd718
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fdd7e0
	System.UInt64 get_CommunityID(); // 0x06fdd86c
	System.Void set_CommunityID(System.UInt64 value); // 0x06fdd8e0
	System.String get_CommunityName(); // 0x06fdd96c
	System.Void set_CommunityName(System.String value); // 0x06fdd9e0
	WizardGames.Soc.Share.Framework.BasicTypeList<System.Int32> get_CommunityIcons(); // 0x06fdda6c
	System.Void set_CommunityIcons(WizardGames.Soc.Share.Framework.BasicTypeList<System.Int32> value); // 0x06fddb0c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fddb98
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fddf60
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06fde2e8
	static System.Object DeserializeCommunityInfoContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fde530
	static System.Void .cctor(); // 0x06fde604
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ComoboUpgradeRecord : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1779529913;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fde7cc
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fde834
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fde8c0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fde94c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fde9d8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fdec40
	static System.Object DeserializeComoboUpgradeRecordContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fdef20
	static System.Void .cctor(); // 0x06fdefec
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ConstructionBlueprintBriefData : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 416657297;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fdf1b4
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fdf21c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fdf2a8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fdf334
	System.Int64 get_Id(); // 0x06fdf3c0
	System.Void set_Id(System.Int64 value); // 0x06fdf434
	System.Int32 get_Slot(); // 0x06fdf4c0
	System.Void set_Slot(System.Int32 value); // 0x06fdf534
	System.String get_Name(); // 0x06fdf5c0
	System.Void set_Name(System.String value); // 0x06fdf634
	System.Int32 get_PartCount(); // 0x06fdf6c0
	System.Void set_PartCount(System.Int32 value); // 0x06fdf734
	System.Int64 get_BornTime(); // 0x06fdf7c0
	System.Void set_BornTime(System.Int64 value); // 0x06fdf834
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fdf8c0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fdfbf8
	static System.Void .cctor(); // 0x06fdff88
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ConstructionGapLinkInfo : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 223016299;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fe01b8
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fe0220
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fe02ac
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fe0338
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fe03c4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fe062c
	static System.Void .cctor(); // 0x06fe090c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ConstructionItemCustom : WizardGames.Soc.Common.CustomType.EmbeddedCustomBase, WizardGames.Soc.Common.Entity.IHeldItemEntity, WizardGames.Soc.Common.Entity.IItemEntity, WizardGames.Soc.Common.Entity.IEmbeddedCustom, WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Share.Framework.IPredictType
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1919017694;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 <NextFireTime>k__BackingField; // 0x28
	System.Int32 GetClassHash(); // 0x06fe0aa0
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fe0b08
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fe0bb8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fe0c68
	System.Int64 get_OwnerEntityId(); // 0x06fe0d18
	System.Void set_OwnerEntityId(System.Int64 value); // 0x06fe0d8c
	System.Int64 get_ItemUid(); // 0x06fe0e18
	System.Void set_ItemUid(System.Int64 value); // 0x06fe0e8c
	System.Int64 get_TableId(); // 0x06fe0f18
	System.Void set_TableId(System.Int64 value); // 0x06fe0f8c
	System.Int32 get_Amount(); // 0x06fe1018
	System.Void set_Amount(System.Int32 value); // 0x06fe108c
	System.Single get_Condition(); // 0x06fe1118
	System.Void set_Condition(System.Single value); // 0x06fe118c
	System.Single get_MaxCondition(); // 0x06fe1218
	System.Void set_MaxCondition(System.Single value); // 0x06fe128c
	System.Int32 get_Position(); // 0x06fe1318
	System.Void set_Position(System.Int32 value); // 0x06fe138c
	System.Int32 get_TemplateId(); // 0x06fe1418
	System.Void set_TemplateId(System.Int32 value); // 0x06fe148c
	System.Int64 get_SkinId(); // 0x06fe1518
	System.Void set_SkinId(System.Int64 value); // 0x06fe158c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fe1618
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fe1a38
	WizardGames.Soc.Share.Framework.IPredictType GetNewInstance(System.Int64 id); // 0x06fe1e54
	System.Void .ctor(System.Int64 id); // 0x06fe1ef4
	System.Boolean get_isBroken(); // 0x06fe1f9c
	System.Void OnDeploy(); // 0x06fe200c
	System.Void OnHolster(); // 0x06fe206c
	System.Int64 get_NextFireTime(); // 0x06fe20cc
	System.Void set_NextFireTime(System.Int64 value); // 0x06fe2130
	static System.Void .cctor(); // 0x06fe21a8
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.WaitAndExeNode : WizardGames.Soc.Common.CustomType.BaseNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1772693924;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fe2510
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fe2578
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fe2628
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fe26d8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fe2788
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fe29f0
	static System.Void .cctor(); // 0x06fe2cd0
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.WaitByDayNode : WizardGames.Soc.Common.CustomType.BaseNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 601696350;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fe2f68
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fe2fd0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fe3080
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fe3130
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fe31e0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fe3448
	static System.Void .cctor(); // 0x06fe3728
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.WaitForSecondNode : WizardGames.Soc.Common.CustomType.BaseNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1432178162;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fe3a5c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fe3ac4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fe3b74
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fe3c24
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fe3cd4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fe3f3c
	static System.Void .cctor(); // 0x06fe421c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.RepeatWaitNode : WizardGames.Soc.Common.CustomType.BaseNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 375144900;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fe4480
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fe44e8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fe4598
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fe4648
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fe46f8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fe4960
	static System.Void .cctor(); // 0x06fe4c40
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.CorpseInventoryRootNode : WizardGames.Soc.Common.CustomType.HumanInventoryRootNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1812686119;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fe4f40
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fe4fa8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fe5058
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fe5108
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x06fe51b8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fe5318
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fe5854
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06fe5c60
	static System.Object DeserializeCorpseInventoryRootNodeContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fe5ff4
	static System.Void .cctor(); // 0x06fe6118
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.CountDirectoryNode : WizardGames.Soc.Common.CustomType.DirectoryNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1307137071;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fe637c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fe63e4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fe6494
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fe6544
	System.Int32 get_Count(); // 0x06fe65f4
	System.Void set_Count(System.Int32 value); // 0x06fe6668
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fe66f4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fe6b58
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06fe6f40
	static System.Object DeserializeCountDirectoryNodeContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fe7198
	static System.Void .cctor(); // 0x06fe726c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.CubeMiniGameRecord : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 2086656134;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fe74d0
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fe7538
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fe75c4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fe7698
	System.Int64 get_MiniGameId(); // 0x06fe7724
	System.Void set_MiniGameId(System.Int64 value); // 0x06fe7798
	WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.DragElement> get_Record(); // 0x06fe7824
	System.Void set_Record(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.DragElement> value); // 0x06fe78c4
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x06fe7950
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fe7ab0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fe7e54
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06fe81b8
	static System.Object DeserializeCubeMiniGameRecordContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fe8400
	System.Void .ctor(); // 0x06fe84d0
	static System.Void .cctor(); // 0x06fe8538
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.CubeMiniGameTaskNode : WizardGames.Soc.Common.CustomType.PoiTaskNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1602772977;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fe86cc
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fe8734
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fe87e4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fe88fc
	WizardGames.Soc.Common.CustomType.CubeMiniGameRecord get_CubeMiniGameRecord(); // 0x06fe89ac
	System.Void set_CubeMiniGameRecord(WizardGames.Soc.Common.CustomType.CubeMiniGameRecord value); // 0x06fe8a70
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fe8afc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fe8fe0
	static System.Void .cctor(); // 0x06fe9448
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.CustomBaseItem : WizardGames.Soc.Common.CustomType.EmbeddedCustomBase, WizardGames.Soc.Common.Entity.IItemEntity, WizardGames.Soc.Common.Entity.IEmbeddedCustom, WizardGames.Soc.Common.Entity.IEntity, WizardGames.Soc.Share.Framework.IPredictType
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1006178278;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 TableId_Local; // 0x28
	System.Collections.Generic.List<System.Int64> subscribeIds; // 0x30
	System.Int32 GetClassHash(); // 0x06fe977c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fe97e4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fe98e4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fe9a04
	System.Int64 get_OwnerEntityId(); // 0x06fe9b04
	System.Void set_OwnerEntityId(System.Int64 value); // 0x06fe9b78
	System.Int64 get_ItemUid(); // 0x06fe9c04
	System.Void set_ItemUid(System.Int64 value); // 0x06fe9c78
	System.Int64 get_TableId(); // 0x06fe9d04
	System.Void set_TableId(System.Int64 value); // 0x06fe9d78
	System.Int32 get_Amount(); // 0x06fe9e04
	System.Void set_Amount(System.Int32 value); // 0x06fe9e78
	System.Single get_Condition(); // 0x06fe9f04
	System.Void set_Condition(System.Single value); // 0x06fe9f78
	System.Single get_MaxCondition(); // 0x06fea004
	System.Void set_MaxCondition(System.Single value); // 0x06fea078
	System.Int32 get_TemplateId(); // 0x06fea104
	System.Void set_TemplateId(System.Int32 value); // 0x06fea178
	System.Int32 get_Position(); // 0x06fea204
	System.Void set_Position(System.Int32 value); // 0x06fea278
	System.Int64 get_SkinId(); // 0x06fea304
	System.Void set_SkinId(System.Int64 value); // 0x06fea378
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fea404
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fea824
	WizardGames.Soc.Share.Framework.IPredictType GetNewInstance(System.Int64 id); // 0x06feac40
	System.Void SubscribePropertyChange(WizardGames.Soc.Common.CustomType.CustomBaseItem target); // 0x06feade4
	System.Void UnSubscribePropertyChange(); // 0x06feb430
	System.Void OnOwnerEntityIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.CustomType.CustomBaseItem target); // 0x06feb594
	System.Void OnItemUidChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.CustomType.CustomBaseItem target); // 0x06feb63c
	System.Void OnAmountChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.CustomType.CustomBaseItem target); // 0x06feb6e4
	System.Void OnConditionChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.CustomType.CustomBaseItem target); // 0x06feb78c
	System.Void OnMaxConditionChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.CustomType.CustomBaseItem target); // 0x06feb834
	System.Void OnPositionChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue, WizardGames.Soc.Common.CustomType.CustomBaseItem target); // 0x06feb8dc
	System.Void OnSkinIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue, WizardGames.Soc.Common.CustomType.CustomBaseItem target); // 0x06feb984
	System.Void .ctor(System.Int64 id, System.Int32 entityType); // 0x06feace4
	System.Boolean get_isBroken(); // 0x06feba2c
	System.Int64 GetTableId_Local(); // 0x06feba9c
	static System.Void .cctor(); // 0x06febb00
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.CustomBaseItem.<>c__DisplayClass41_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.CustomBaseItem <>4__this; // 0x10
	WizardGames.Soc.Common.CustomType.CustomBaseItem target; // 0x18
	System.Void .ctor(); // 0x06feb3c8
	System.Void <SubscribePropertyChange>b__0(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x06febe68
	System.Void <SubscribePropertyChange>b__1(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x06febf14
	System.Void <SubscribePropertyChange>b__2(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x06febfc0
	System.Void <SubscribePropertyChange>b__3(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x06fec06c
	System.Void <SubscribePropertyChange>b__4(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x06fec118
	System.Void <SubscribePropertyChange>b__5(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x06fec1c4
	System.Void <SubscribePropertyChange>b__6(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x06fec270
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.CustomEventParam : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 628205195;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fec31c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fec384
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fec410
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fec49c
	WizardGames.Soc.Common.SimpleCustom.EEventParamsType get_ParamType(); // 0x06fec528
	System.Void set_ParamType(WizardGames.Soc.Common.SimpleCustom.EEventParamsType value); // 0x06fec59c
	System.Boolean get_BoolValue(); // 0x06fec628
	System.Void set_BoolValue(System.Boolean value); // 0x06fec69c
	System.Int64 get_LongValue(); // 0x06fec728
	System.Void set_LongValue(System.Int64 value); // 0x06fec79c
	System.Single get_FloatValue(); // 0x06fec828
	System.Void set_FloatValue(System.Single value); // 0x06fec89c
	System.String get_StringValue(); // 0x06fec928
	System.Void set_StringValue(System.String value); // 0x06fec99c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06feca28
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fecd5c
	static System.Void .cctor(); // 0x06fed108
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.CustomQueue : WizardGames.Soc.Share.Framework.CustomTypeBase, System.Collections.Generic.IEnumerable<WizardGames.Soc.Share.Framework.CustomTypeBase>, System.Collections.IEnumerable
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 398420779;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fed338
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fed3a0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fed42c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fed500
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int32,WizardGames.Soc.Share.Framework.CustomTypeBase> get_QueueData(); // 0x06fed58c
	System.Void set_QueueData(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int32,WizardGames.Soc.Share.Framework.CustomTypeBase> value); // 0x06fed62c
	System.Int32 get_EnqueueIndex(); // 0x06fed6b8
	System.Void set_EnqueueIndex(System.Int32 value); // 0x06fed72c
	System.Int32 get_DequeueIndex(); // 0x06fed7b8
	System.Void set_DequeueIndex(System.Int32 value); // 0x06fed82c
	System.Int32 get_Version(); // 0x06fed8b8
	System.Void set_Version(System.Int32 value); // 0x06fed92c
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x06fed9b8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fedb14
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fedf08
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06fee29c
	static System.Object DeserializeCustomQueueContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fee4e0
	WizardGames.Soc.Common.CustomType.CustomQueue.CustomQueueEnumerator GetEnumerator(); // 0x06fee5a8
	System.Collections.Generic.IEnumerator<WizardGames.Soc.Share.Framework.CustomTypeBase> System.Collections.Generic.IEnumerable<WizardGames.Soc.Share.Framework.CustomTypeBase>.GetEnumerator(); // 0x06fee6e0
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x06fee794
	static System.Void .cctor(); // 0x06fee848
}

// Client.Runtime
struct WizardGames.Soc.Common.CustomType.CustomQueue.CustomQueueEnumerator : System.ValueType, System.Collections.Generic.IEnumerator<WizardGames.Soc.Share.Framework.CustomTypeBase>, System.Collections.IEnumerator, System.IDisposable
{
	WizardGames.Soc.Common.CustomType.CustomQueue _q; // 0x10
	System.Int32 _version; // 0x18
	System.Int32 _index; // 0x1c
	WizardGames.Soc.Share.Framework.CustomTypeBase _currentElement; // 0x20
	System.Void .ctor(WizardGames.Soc.Common.CustomType.CustomQueue q); // 0x06fee62c
	System.Void Dispose(); // 0x06feea44
	System.Boolean MoveNext(); // 0x06feeab8
	WizardGames.Soc.Share.Framework.CustomTypeBase get_Current(); // 0x06feec08
	System.Object System.Collections.IEnumerator.get_Current(); // 0x06feed2c
	System.Void ThrowEnumerationNotStartedOrEnded(); // 0x06feec7c
	System.Void System.Collections.IEnumerator.Reset(); // 0x06feed90
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.CustomTypeExample : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1576460797;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06feee68
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06feeed0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06feef5c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fef024
	System.Int64 get_LongValue(); // 0x06fef0b0
	System.Void set_LongValue(System.Int64 value); // 0x06fef124
	WizardGames.Soc.Share.Framework.BasicTypeList<System.Int64> get_LongListValue(); // 0x06fef1b0
	System.Void set_LongListValue(WizardGames.Soc.Share.Framework.BasicTypeList<System.Int64> value); // 0x06fef250
	System.Single get_FloatValue(); // 0x06fef2dc
	System.Void set_FloatValue(System.Single value); // 0x06fef350
	System.Boolean get_BoolValue(); // 0x06fef3dc
	System.Void set_BoolValue(System.Boolean value); // 0x06fef450
	System.String get_StrValue(); // 0x06fef4dc
	System.Void set_StrValue(System.String value); // 0x06fef550
	System.Int64 get_Var(); // 0x06fef5dc
	System.Void set_Var(System.Int64 value); // 0x06fef650
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fef6dc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fefb14
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06fefefc
	static System.Object DeserializeCustomTypeExampleContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ff0144
	static System.Void .cctor(); // 0x06ff0218
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.CustomTypeForHashSet : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1387973798;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06ff047c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ff04e4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06ff0570
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06ff0638
	WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int64> get_Values(); // 0x06ff06c4
	System.Void set_Values(WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int64> value); // 0x06ff0764
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ff07f0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06ff0b70
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06ff0eb0
	static System.Object DeserializeCustomTypeForHashSetContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ff10f4
	static System.Void .cctor(); // 0x06ff11c4
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.CustomVector3List : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1925449691;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06ff1324
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ff138c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06ff1418
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06ff14ec
	WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.CustomVector3> get_List(); // 0x06ff1578
	System.Void set_List(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.CustomVector3> value); // 0x06ff1618
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x06ff16a4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ff1800
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06ff1b80
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06ff1ec4
	static System.Object DeserializeCustomVector3ListContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ff2108
	static System.Void .cctor(); // 0x06ff21d4
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.CustomVector3 : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1008441098;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06ff2334
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ff239c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06ff2428
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06ff24b4
	System.Single get_X(); // 0x06ff2540
	System.Void set_X(System.Single value); // 0x06ff25b4
	System.Single get_Y(); // 0x06ff2640
	System.Void set_Y(System.Single value); // 0x06ff26b4
	System.Single get_Z(); // 0x06ff2740
	System.Void set_Z(System.Single value); // 0x06ff27b4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ff2840
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06ff2b1c
	System.Void .ctor(); // 0x06ff2e58
	System.Void .ctor(System.Single x, System.Single y, System.Single z); // 0x06ff2ec0
	System.String ToString(); // 0x06ff2f7c
	static System.Void .cctor(); // 0x06ff3088
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DailyTaskContainer : WizardGames.Soc.Common.CustomType.TaskContainer
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 2082906203;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06ff3250
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ff32b8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06ff3368
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06ff3418
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ff34c8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06ff3a04
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06ff3dfc
	static System.Object DeserializeDailyTaskContainerContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ff4190
	static System.Void .cctor(); // 0x06ff4338
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DataObject : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 551988161;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06ff46d4
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ff473c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06ff47c8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06ff4854
	System.Byte get_Type(); // 0x06ff48e0
	System.Void set_Type(System.Byte value); // 0x06ff4954
	System.Int64 get_BasicTypeValue(); // 0x06ff49e0
	System.Void set_BasicTypeValue(System.Int64 value); // 0x06ff4a54
	System.String get_StringValue(); // 0x06ff4ae0
	System.Void set_StringValue(System.String value); // 0x06ff4b54
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ff4be0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06ff4ec8
	System.Int64 get_NodeId(); // 0x06ff5228
	static System.Void .cctor(); // 0x06ff528c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DeadSheepBuildingInfo : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1667634384;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06ff5454
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ff54bc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06ff5548
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06ff563c
	System.Int64 get_TerrPartEntityId(); // 0x06ff56c8
	System.Void set_TerrPartEntityId(System.Int64 value); // 0x06ff573c
	System.Int32 get_BuildingId(); // 0x06ff57c8
	System.Void set_BuildingId(System.Int32 value); // 0x06ff583c
	System.Int32 get_BuildingGroupId(); // 0x06ff58c8
	System.Void set_BuildingGroupId(System.Int32 value); // 0x06ff593c
	System.Int32 get_GridIndex(); // 0x06ff59c8
	System.Void set_GridIndex(System.Int32 value); // 0x06ff5a3c
	WizardGames.Soc.Common.CustomType.CustomVector3 get_Pos(); // 0x06ff5ac8
	System.Void set_Pos(WizardGames.Soc.Common.CustomType.CustomVector3 value); // 0x06ff5b8c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ff5c18
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06ff5fdc
	static System.Void .cctor(); // 0x06ff6398
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DeadSheepBuildingRecord : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 511898517;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06ff65c8
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ff6630
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06ff66bc
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06ff6748
	System.Int32 get_BuildingGroupId(); // 0x06ff67d4
	System.Void set_BuildingGroupId(System.Int32 value); // 0x06ff6848
	System.Int32 get_BuildingId(); // 0x06ff68d4
	System.Void set_BuildingId(System.Int32 value); // 0x06ff6948
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ff69d4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06ff6c98
	static System.Object DeserializeDeadSheepBuildingRecordContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ff6fc4
	static System.Void .cctor(); // 0x06ff70a0
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DeadSheepLoadingInfo : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 200701057;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06ff729c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ff7304
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06ff7390
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06ff741c
	System.Int32 get_NormalNum(); // 0x06ff74a8
	System.Void set_NormalNum(System.Int32 value); // 0x06ff751c
	System.Int32 get_TerritoryFightNum(); // 0x06ff75a8
	System.Void set_TerritoryFightNum(System.Int32 value); // 0x06ff761c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ff76a8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06ff796c
	static System.Void .cctor(); // 0x06ff7c98
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DeadSheepMission : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 155196738;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06ff7e2c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ff7e94
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06ff7f20
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06ff7fac
	System.Int32 get_TargetNum(); // 0x06ff8038
	System.Void set_TargetNum(System.Int32 value); // 0x06ff80ac
	System.Int32 get_AchieveNum(); // 0x06ff8138
	System.Void set_AchieveNum(System.Int32 value); // 0x06ff81ac
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ff8238
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06ff84fc
	static System.Void .cctor(); // 0x06ff8828
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DeadSheepPosInfo : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 2129820239;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06ff89bc
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ff8a24
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06ff8ab0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06ff8ba4
	System.Int64 get_EntityId(); // 0x06ff8c30
	System.Void set_EntityId(System.Int64 value); // 0x06ff8ca4
	System.Int64 get_TerrId(); // 0x06ff8d30
	System.Void set_TerrId(System.Int64 value); // 0x06ff8da4
	WizardGames.Soc.Common.CustomType.CustomVector3 get_Pos(); // 0x06ff8e30
	System.Void set_Pos(WizardGames.Soc.Common.CustomType.CustomVector3 value); // 0x06ff8ef4
	System.Int32 get_RegionIndex(); // 0x06ff8f80
	System.Void set_RegionIndex(System.Int32 value); // 0x06ff8ff4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ff9080
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06ff9420
	static System.Void .cctor(); // 0x06ff97c4
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DeadSheepRegion : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 2146496002;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06ff99c0
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ff9a28
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06ff9ab4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06ff9bc8
	System.Int32 get_Index(); // 0x06ff9c54
	System.Void set_Index(System.Int32 value); // 0x06ff9cc8
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.DeadSheepBuildingInfo> get_TerrToBuildingInfo(); // 0x06ff9d54
	System.Void set_TerrToBuildingInfo(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.DeadSheepBuildingInfo> value); // 0x06ff9df4
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int32,WizardGames.Soc.Common.CustomType.DeadSheepLoadingInfo> get_LoadingInfo(); // 0x06ff9e80
	System.Void set_LoadingInfo(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int32,WizardGames.Soc.Common.CustomType.DeadSheepLoadingInfo> value); // 0x06ff9f20
	System.Int64 get_TerritoryFightRefreshTs(); // 0x06ff9fac
	System.Void set_TerritoryFightRefreshTs(System.Int64 value); // 0x06ffa020
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x06ffa0ac
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ffa28c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06ffa740
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06ffab0c
	static System.Object DeserializeDeadSheepRegionContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ffae80
	static System.Void .cctor(); // 0x06ffaf84
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DeadSheepTerritoryInfo : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 192955158;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06ffb180
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ffb1e8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06ffb274
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06ffb368
	System.Int32 get_BuildingId(); // 0x06ffb3f4
	System.Void set_BuildingId(System.Int32 value); // 0x06ffb468
	WizardGames.Soc.Common.CustomType.CustomVector3 get_Pos(); // 0x06ffb4f4
	System.Void set_Pos(WizardGames.Soc.Common.CustomType.CustomVector3 value); // 0x06ffb5b8
	System.Boolean get_IsAttacked(); // 0x06ffb644
	System.Void set_IsAttacked(System.Boolean value); // 0x06ffb6b8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ffb744
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06ffbab8
	static System.Void .cctor(); // 0x06ffbe44
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DecayUnit : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 863996966;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06ffc00c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ffc074
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06ffc100
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06ffc18c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ffc218
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06ffc480
	static System.Void .cctor(); // 0x06ffc760
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DecomposeMachineRootNode : WizardGames.Soc.Common.CustomType.ItemSystemRootNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1462659300;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06ffc888
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ffc8f0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06ffc9a0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06ffca50
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x06ffcb00
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ffcc60
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06ffd19c
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06ffd5a8
	static System.Object DeserializeDecomposeMachineRootNodeContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ffd93c
	static System.Void .cctor(); // 0x06ffda60
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DictionaryLongBool : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.RuleGraph.IGraphContainer
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 957482777;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06ffdcc4
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ffdd2c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06ffddb8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06ffde80
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Boolean> get_Container(); // 0x06ffdf0c
	System.Void set_Container(WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Boolean> value); // 0x06ffdfac
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ffe038
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06ffe3b8
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06ffe6f8
	static System.Object DeserializeDictionaryLongBoolContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ffe93c
	WizardGames.Soc.Share.Framework.TypeBase GetContainer(); // 0x06ffea0c
	static System.Void .cctor(); // 0x06ffea70
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DictionaryLongCustomEventParam : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.RuleGraph.IGraphContainer
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 525968945;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06ffebd0
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ffec38
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06ffecc4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06ffed98
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.CustomEventParam> get_Container(); // 0x06ffee24
	System.Void set_Container(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.CustomEventParam> value); // 0x06ffeec4
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x06ffef50
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fff0ac
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06fff42c
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x06fff770
	static System.Object DeserializeDictionaryLongCustomEventParamContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fff9b4
	WizardGames.Soc.Share.Framework.TypeBase GetContainer(); // 0x06fffa80
	static System.Void .cctor(); // 0x06fffae4
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DictionaryLongCustomTypeExample : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.RuleGraph.IGraphContainer
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 770879837;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x06fffc44
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06fffcac
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x06fffd38
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x06fffe0c
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.CustomTypeExample> get_Container(); // 0x06fffe98
	System.Void set_Container(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.CustomTypeExample> value); // 0x06ffff38
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x06ffffc4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07000120
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x070004a0
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x070007e4
	static System.Object DeserializeDictionaryLongCustomTypeExampleContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07000a28
	WizardGames.Soc.Share.Framework.TypeBase GetContainer(); // 0x07000af4
	static System.Void .cctor(); // 0x07000b58
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DictionaryLongFloat : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.RuleGraph.IGraphContainer
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1096421507;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07000cb8
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07000d20
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07000dac
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07000e74
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Single> get_Container(); // 0x07000f00
	System.Void set_Container(WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Single> value); // 0x07000fa0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0700102c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x070013ac
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x070016ec
	static System.Object DeserializeDictionaryLongFloatContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07001930
	WizardGames.Soc.Share.Framework.TypeBase GetContainer(); // 0x07001a00
	static System.Void .cctor(); // 0x07001a64
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DictionaryLongInitStatPanelData : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.RuleGraph.IGraphContainer
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1707476891;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07001bc4
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07001c2c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07001cb8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07001d8c
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.InitStatPanelData> get_Container(); // 0x07001e18
	System.Void set_Container(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.InitStatPanelData> value); // 0x07001eb8
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x07001f44
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x070020a0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07002420
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x07002764
	static System.Object DeserializeDictionaryLongInitStatPanelDataContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x070029a8
	WizardGames.Soc.Share.Framework.TypeBase GetContainer(); // 0x07002a74
	static System.Void .cctor(); // 0x07002ad8
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DictionaryLongItemCount : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.RuleGraph.IGraphContainer
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1325549608;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07002c38
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07002ca0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07002d2c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07002e00
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.ItemCount> get_Container(); // 0x07002e8c
	System.Void set_Container(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.ItemCount> value); // 0x07002f2c
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x07002fb8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07003114
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07003494
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x070037d8
	static System.Object DeserializeDictionaryLongItemCountContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07003a1c
	WizardGames.Soc.Share.Framework.TypeBase GetContainer(); // 0x07003ae8
	static System.Void .cctor(); // 0x07003b4c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DictionaryLongLong : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.RuleGraph.IGraphContainer
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1180875020;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07003cac
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07003d14
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07003da0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07003e68
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Int64> get_Container(); // 0x07003ef4
	System.Void set_Container(WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Int64> value); // 0x07003f94
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07004020
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x070043a0
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x070046e0
	static System.Object DeserializeDictionaryLongLongContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07004924
	WizardGames.Soc.Share.Framework.TypeBase GetContainer(); // 0x070049f4
	static System.Void .cctor(); // 0x07004a58
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DictionaryLongMultiLangStringBuilder : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.RuleGraph.IGraphContainer
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 734603401;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07004bb8
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07004c20
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07004cac
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07004d80
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.MultiLangStringBuilder> get_Container(); // 0x07004e0c
	System.Void set_Container(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.MultiLangStringBuilder> value); // 0x07004eac
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x07004f38
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07005094
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07005414
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x07005758
	static System.Object DeserializeDictionaryLongMultiLangStringBuilderContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0700599c
	WizardGames.Soc.Share.Framework.TypeBase GetContainer(); // 0x07005a68
	static System.Void .cctor(); // 0x07005acc
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DictionaryLongMultiLangString : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.RuleGraph.IGraphContainer
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 259426402;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07005c2c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07005c94
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07005d20
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07005df4
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.MultiLangString> get_Container(); // 0x07005e80
	System.Void set_Container(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.MultiLangString> value); // 0x07005f20
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x07005fac
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07006108
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07006488
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x070067cc
	static System.Object DeserializeDictionaryLongMultiLangStringContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07006a10
	WizardGames.Soc.Share.Framework.TypeBase GetContainer(); // 0x07006adc
	static System.Void .cctor(); // 0x07006b40
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DictionaryLongSelectableTeamInfo : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.RuleGraph.IGraphContainer
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1542354281;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07006ca0
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07006d08
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07006d94
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07006e68
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.SelectableTeamInfo> get_Container(); // 0x07006ef4
	System.Void set_Container(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.SelectableTeamInfo> value); // 0x07006f94
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x07007020
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0700717c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x070074fc
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x07007840
	static System.Object DeserializeDictionaryLongSelectableTeamInfoContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07007a84
	WizardGames.Soc.Share.Framework.TypeBase GetContainer(); // 0x07007b50
	static System.Void .cctor(); // 0x07007bb4
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DictionaryLongStatDynamicFields : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.RuleGraph.IGraphContainer
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1146643311;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07007d14
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07007d7c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07007e08
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07007edc
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.StatDynamicFields> get_Container(); // 0x07007f68
	System.Void set_Container(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.StatDynamicFields> value); // 0x07008008
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x07008094
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x070081f0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07008570
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x070088b4
	static System.Object DeserializeDictionaryLongStatDynamicFieldsContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07008af8
	WizardGames.Soc.Share.Framework.TypeBase GetContainer(); // 0x07008bc4
	static System.Void .cctor(); // 0x07008c28
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DictionaryLongStatTeamData : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.RuleGraph.IGraphContainer
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1280108691;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07008d88
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07008df0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07008e7c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07008f50
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.StatTeamData> get_Container(); // 0x07008fdc
	System.Void set_Container(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.StatTeamData> value); // 0x0700907c
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x07009108
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07009264
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x070095e4
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x07009928
	static System.Object DeserializeDictionaryLongStatTeamDataContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07009b6c
	WizardGames.Soc.Share.Framework.TypeBase GetContainer(); // 0x07009c38
	static System.Void .cctor(); // 0x07009c9c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DictionaryLongString : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.RuleGraph.IGraphContainer
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 2132592965;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07009dfc
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07009e64
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07009ef0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07009fb8
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.String> get_Container(); // 0x0700a044
	System.Void set_Container(WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.String> value); // 0x0700a0e4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0700a170
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0700a4f0
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x0700a830
	static System.Object DeserializeDictionaryLongStringContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0700aa74
	WizardGames.Soc.Share.Framework.TypeBase GetContainer(); // 0x0700ab44
	static System.Void .cctor(); // 0x0700aba8
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DictionaryLongTableBoolFieldInfo : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.RuleGraph.IGraphContainer
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 601688454;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0700ad08
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0700ad70
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0700adfc
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0700aed0
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.TableBoolFieldInfo> get_Container(); // 0x0700af5c
	System.Void set_Container(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.TableBoolFieldInfo> value); // 0x0700affc
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x0700b088
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0700b1e4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0700b564
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x0700b8a8
	static System.Object DeserializeDictionaryLongTableBoolFieldInfoContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0700baec
	WizardGames.Soc.Share.Framework.TypeBase GetContainer(); // 0x0700bbb8
	static System.Void .cctor(); // 0x0700bc1c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DictionaryLongTableFieldInfo : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.RuleGraph.IGraphContainer
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 538558626;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0700bd7c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0700bde4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0700be70
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0700bf44
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.TableFieldInfo> get_Container(); // 0x0700bfd0
	System.Void set_Container(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.TableFieldInfo> value); // 0x0700c070
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x0700c0fc
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0700c258
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0700c5d8
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x0700c91c
	static System.Object DeserializeDictionaryLongTableFieldInfoContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0700cb60
	WizardGames.Soc.Share.Framework.TypeBase GetContainer(); // 0x0700cc2c
	static System.Void .cctor(); // 0x0700cc90
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DictionaryLongTableFloatArrayFieldInfo : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.RuleGraph.IGraphContainer
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 883020931;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0700cdf0
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0700ce58
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0700cee4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0700cfb8
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.TableFloatArrayFieldInfo> get_Container(); // 0x0700d044
	System.Void set_Container(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.TableFloatArrayFieldInfo> value); // 0x0700d0e4
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x0700d170
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0700d2cc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0700d64c
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x0700d990
	static System.Object DeserializeDictionaryLongTableFloatArrayFieldInfoContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0700dbd4
	WizardGames.Soc.Share.Framework.TypeBase GetContainer(); // 0x0700dca0
	static System.Void .cctor(); // 0x0700dd04
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DictionaryLongTableFloatFieldInfo : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.RuleGraph.IGraphContainer
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 207022724;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0700de64
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0700decc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0700df58
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0700e02c
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.TableFloatFieldInfo> get_Container(); // 0x0700e0b8
	System.Void set_Container(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.TableFloatFieldInfo> value); // 0x0700e158
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x0700e1e4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0700e340
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0700e6c0
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x0700ea04
	static System.Object DeserializeDictionaryLongTableFloatFieldInfoContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0700ec48
	WizardGames.Soc.Share.Framework.TypeBase GetContainer(); // 0x0700ed14
	static System.Void .cctor(); // 0x0700ed78
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DictionaryLongTableLongArrayFieldInfo : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.RuleGraph.IGraphContainer
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1096439660;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0700eed8
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0700ef40
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0700efcc
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0700f0a0
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.TableLongArrayFieldInfo> get_Container(); // 0x0700f12c
	System.Void set_Container(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.TableLongArrayFieldInfo> value); // 0x0700f1cc
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x0700f258
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0700f3b4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0700f734
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x0700fa78
	static System.Object DeserializeDictionaryLongTableLongArrayFieldInfoContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0700fcbc
	WizardGames.Soc.Share.Framework.TypeBase GetContainer(); // 0x0700fd88
	static System.Void .cctor(); // 0x0700fdec
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DictionaryLongTableLongFieldInfo : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.RuleGraph.IGraphContainer
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 58675809;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0700ff4c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0700ffb4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07010040
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07010114
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.TableLongFieldInfo> get_Container(); // 0x070101a0
	System.Void set_Container(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.TableLongFieldInfo> value); // 0x07010240
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x070102cc
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07010428
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x070107a8
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x07010aec
	static System.Object DeserializeDictionaryLongTableLongFieldInfoContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07010d30
	WizardGames.Soc.Share.Framework.TypeBase GetContainer(); // 0x07010dfc
	static System.Void .cctor(); // 0x07010e60
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DictionaryLongTableStringFieldInfo : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.RuleGraph.IGraphContainer
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1709284178;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07010fc0
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07011028
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x070110b4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07011188
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.TableStringFieldInfo> get_Container(); // 0x07011214
	System.Void set_Container(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.TableStringFieldInfo> value); // 0x070112b4
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x07011340
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0701149c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0701181c
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x07011b60
	static System.Object DeserializeDictionaryLongTableStringFieldInfoContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07011da4
	WizardGames.Soc.Share.Framework.TypeBase GetContainer(); // 0x07011e70
	static System.Void .cctor(); // 0x07011ed4
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DictionaryLongTableTextFieldInfo : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.RuleGraph.IGraphContainer
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1288492967;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07012034
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0701209c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07012128
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x070121fc
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.TableTextFieldInfo> get_Container(); // 0x07012288
	System.Void set_Container(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.TableTextFieldInfo> value); // 0x07012328
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x070123b4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07012510
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07012890
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x07012bd4
	static System.Object DeserializeDictionaryLongTableTextFieldInfoContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07012e18
	WizardGames.Soc.Share.Framework.TypeBase GetContainer(); // 0x07012ee4
	static System.Void .cctor(); // 0x07012f48
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DictionaryLongVector3 : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.RuleGraph.IGraphContainer
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 188565885;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x070130a8
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07013110
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0701319c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07013270
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.CustomVector3> get_Container(); // 0x070132fc
	System.Void set_Container(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.CustomVector3> value); // 0x0701339c
	WizardGames.Soc.Share.Framework.TypeBase CreateCustomProperty(System.Int32 propertyId, System.Object value); // 0x07013428
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07013584
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07013904
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x07013c48
	static System.Object DeserializeDictionaryLongVector3Container(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07013e8c
	WizardGames.Soc.Share.Framework.TypeBase GetContainer(); // 0x07013f58
	static System.Void .cctor(); // 0x07013fbc
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DigOutputInfo : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 146429894;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0701411c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07014184
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07014210
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0701429c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07014328
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07014590
	static System.Void .cctor(); // 0x07014870
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DirectoryItemNode : WizardGames.Soc.Common.CustomType.UniqueItemNode, WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap, WizardGames.Soc.Share.Game.NodeSystem.IItemContainerNode, WizardGames.Soc.Share.Game.NodeSystem.IDirectoryNode, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.Common.CustomType.NodeBase>>, System.Collections.IEnumerable, WizardGames.Soc.Share.Game.NodeSystem.INode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 274978340;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	WizardGames.Soc.Common.CustomType.Alpha3ContainerClient containerClient; // 0x28
	System.Func<System.Int64,WizardGames.Soc.Common.CustomType.NodeBase> _getCustomNodeFunc; // 0x30
	System.Int32 GetClassHash(); // 0x07014a6c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07014ad4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07014b84
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07014c70
	System.Int32 get_Capacity(); // 0x07014d20
	System.Void set_Capacity(System.Int32 value); // 0x07014d94
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Int64> get_ChildDict(); // 0x07014e20
	System.Void set_ChildDict(WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Int64> value); // 0x07014ec0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07014f4c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07015490
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x07015928
	static System.Object DeserializeDirectoryItemNodeContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07015b70
	WizardGames.Soc.Common.Data.DataItem.Container get_ContainerConfig(); // 0x07015c44
	System.Int32 get_Flags(); // 0x07015d88
	System.Int32 get_Stack(); // 0x07015dec
	System.Int32 get_MaxStackSize(); // 0x07015e60
	System.Collections.Generic.IDictionary<System.Int64,System.Int64> get_Contents(); // 0x07015ee0
	System.Int32 get_ContentsCapcity(); // 0x07015f44
	WizardGames.Soc.Common.CustomType.Alpha3ContainerClient get_Impl(); // 0x07015fa8
	System.Func<System.Int64,WizardGames.Soc.Common.CustomType.NodeBase> get_getCustomNodeFunc(); // 0x0701600c
	System.Void CreateContainerClient(); // 0x070160d0
	WizardGames.Soc.Share.Game.NodeSystem.INode GetChildNode(System.Int64 index); // 0x070161ac
	WizardGames.Soc.Common.CustomType.NodeBase GetChild(System.Int64 index); // 0x07016220
	System.Void AddAnyUpdateCallback(); // 0x07016368
	System.Collections.Generic.IDictionary<System.Int64,System.Int64> GetChildren(); // 0x07016488
	WizardGames.Soc.Common.CustomType.Alpha3ItemContainerEnumerator GetEnumerator(); // 0x070164ec
	System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.Common.CustomType.NodeBase>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.Common.CustomType.NodeBase>>.GetEnumerator(); // 0x070165a0
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x07016684
	System.String ToTreeString(System.Int32 level); // 0x0701670c
	static System.Void .cctor(); // 0x07016aa4
	WizardGames.Soc.Common.CustomType.NodeBase <get_getCustomNodeFunc>b__36_0(System.Int64 nodeId); // 0x07016e74
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DirectoryNode : WizardGames.Soc.Common.CustomType.NodeBase, WizardGames.Soc.Share.Game.NodeSystem.IDirectoryNode, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.Common.CustomType.NodeBase>>, System.Collections.IEnumerable, WizardGames.Soc.Share.Game.NodeSystem.INode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 135271262;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Func<System.Int64,WizardGames.Soc.Common.CustomType.NodeBase> _getCustomNodeFunc; // 0x28
	System.Int32 GetClassHash(); // 0x070170c8
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07017130
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x070171e0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x070172cc
	WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Int64> get_ChildDict(); // 0x0701737c
	System.Void set_ChildDict(WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Int64> value); // 0x0701741c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x070174a8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x070178d0
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x07017c9c
	static System.Object DeserializeDirectoryNodeContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07017ee4
	System.Int32 get_ChildCount(); // 0x07017fb8
	System.Func<System.Int64,WizardGames.Soc.Common.CustomType.NodeBase> get_getCustomNodeFunc(); // 0x07018040
	WizardGames.Soc.Common.CustomType.NodeBase GetChild(System.Int64 index); // 0x07018104
	System.String ToPrettyString(); // 0x070182a0
	System.String ToTreeString(System.Int32 level); // 0x0701838c
	System.String ToDetailedString(); // 0x07018724
	WizardGames.Soc.Share.Game.NodeSystem.IRootNode GetRootNode(); // 0x07018798
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x0701887c
	WizardGames.Soc.Common.CustomType.DirEnumerator<WizardGames.Soc.Common.CustomType.NodeBase> GetEnumerator(); // 0x07018904
	System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.Common.CustomType.NodeBase>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.Common.CustomType.NodeBase>>.GetEnumerator(); // 0x070189d0
	System.Collections.Generic.IDictionary<System.Int64,System.Int64> GetChildren(); // 0x07018ac8
	WizardGames.Soc.Share.Game.NodeSystem.EOpCode AddChildNode(WizardGames.Soc.Common.CustomType.NodeBase child); // 0x07018b2c
	System.Void RemoveChildNode(WizardGames.Soc.Common.CustomType.NodeBase child); // 0x07018cb8
	System.Void AddAnyUpdateCallback(); // 0x07018e18
	static System.Void .cctor(); // 0x07018f38
	WizardGames.Soc.Common.CustomType.NodeBase <get_getCustomNodeFunc>b__20_0(System.Int64 nodeId); // 0x07019168
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DirectoryWithBoolNode : WizardGames.Soc.Common.CustomType.DirectoryNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1130975652;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07019260
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x070192c8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07019374
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07019420
	System.Boolean get_Value(); // 0x070194cc
	System.Void set_Value(System.Boolean value); // 0x07019540
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x070195cc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07019a18
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x07019e04
	static System.Object DeserializeDirectoryWithBoolNodeContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0701a04c
	static System.Void .cctor(); // 0x0701a120
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DragElement : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1197230222;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0701a384
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0701a3ec
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0701a478
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0701a504
	System.Int64 get_Id(); // 0x0701a590
	System.Void set_Id(System.Int64 value); // 0x0701a604
	System.Int32 get_RowStartIndex(); // 0x0701a690
	System.Void set_RowStartIndex(System.Int32 value); // 0x0701a704
	System.Int32 get_ColumnStartIndex(); // 0x0701a790
	System.Void set_ColumnStartIndex(System.Int32 value); // 0x0701a804
	System.Int32 get_PosX(); // 0x0701a890
	System.Void set_PosX(System.Int32 value); // 0x0701a904
	System.Int32 get_PosZ(); // 0x0701a990
	System.Void set_PosZ(System.Int32 value); // 0x0701aa04
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0701aa90
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0701adc8
	System.Void .ctor(System.Int32 posX, System.Int32 posY); // 0x0701b14c
	static System.Void .cctor(); // 0x0701b200
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.DropConfig : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 2128798156;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0701b430
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0701b498
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0701b524
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0701b5b0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0701b63c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0701b8a4
	static System.Object DeserializeDropConfigContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0701bb84
	static System.Void .cctor(); // 0x0701bc54
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricBlueprintItemNode : WizardGames.Soc.Common.CustomType.UniqueItemNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 737743857;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0701bdb4
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0701be1c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0701becc
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0701bf7c
	System.Int64 get_ElectricDataId(); // 0x0701c02c
	System.Void set_ElectricDataId(System.Int64 value); // 0x0701c0a0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0701c12c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0701c56c
	static System.Void .cctor(); // 0x0701c9b8
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricBluePrintSystem : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 122375906;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0701cd54
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0701cdbc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0701ce48
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0701ced4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0701cf60
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0701d1c8
	System.Void .ctor(); // 0x0701d4a8
	static System.Void .cctor(); // 0x0701d510
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCAndSwitch : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 813857059;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 choosenInput; // 0x90
	System.Int32 maxPower; // 0x94
	System.Int32 minPower; // 0x98
	System.Int32 GetClassHash(); // 0x0701d638
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0701d6a0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0701d82c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0701da20
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0701dbac
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0701e0d8
	System.Void .ctor(); // 0x0701e4b4
	System.Boolean get_LightUpdateWhenIOUpdate(); // 0x0701e5f8
	System.Void CAndSwitchBaseUpdateFromInputInner(System.Int32 inputAmount, System.Int32 inputSlot, WizardGames.Soc.Common.CustomType.ElectricCBase outputUnit); // 0x0701e65c
	System.Int32 CAndSwitchBaseGetNeedRecursive(System.Int32 inputSlot, System.Collections.Generic.HashSet<System.Int64> listToUse); // 0x0701e7a0
	System.Void Cleanup(); // 0x0701e8b4
	System.Int32 DesiredPowerSlot(System.Int32 inputSlot); // 0x0701ea1c
	System.Int32 GetPassthroughAmount(System.Int32 outputSlot); // 0x0701ea9c
	System.Void UpdateHasPower(System.Int32 inputAmount, System.Int32 inputSlot); // 0x0701eb1c
	System.Void UpdateFromInputInner(System.Int32 inputAmount, System.Int32 inputSlot, WizardGames.Soc.Common.CustomType.ElectricCBase outputUnit); // 0x0701eba8
	System.Int32 GetNeedRecursive(System.Int32 inputSlot, System.Collections.Generic.HashSet<System.Int64> listToUse); // 0x0701ec4c
	System.Void UpdateLightState(); // 0x0701ecd8
	static System.Void .cctor(); // 0x0701ed40
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCAutoTurret : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1708758981;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0701eed4
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0701ef3c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0701efe8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0701f094
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0701f140
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0701f490
	System.Void .ctor(); // 0x0701f7f8
	System.Boolean get_HasTarget(); // 0x0701f880
	System.Boolean get_IsLowAmmo(); // 0x0701f914
	System.Boolean get_IsNoAmmo(); // 0x0701f9a8
	System.Int32 GetPassthroughAmount(System.Int32 outputSlot); // 0x0701fa3c
	System.Int32 DesiredPower(WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x0701fabc
	static System.Void .cctor(); // 0x0701fb3c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCBackupPowerIC : WizardGames.Soc.Common.CustomType.ElectricCIntegratedCircuit
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 2090256875;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	static WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit backUpPowerICBlueprint; // 0x18
	System.Int32 GetClassHash(); // 0x0701fcd0
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0701fd38
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0701fe90
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07020050
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x070201a8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0702082c
	System.Void .ctor(); // 0x07020cf4
	System.Boolean get_IsCustomCircuit(); // 0x07020e04
	System.Boolean get_LightUpdateWhenIOUpdate(); // 0x07020e68
	WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit GetTemplate(); // 0x07020ecc
	System.Void UpdateLightState(); // 0x07020f34
	static System.Void .cctor(); // 0x07020f9c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCBase : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 2135046969;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	WizardGames.Soc.Common.CustomType.IEntityWithElectric EntityAgent; // 0x28
	System.Int64 RootEntityId; // 0x30
	WizardGames.Soc.Common.Component.IFlagComp flagComp; // 0x38
	static System.Int32 Backtracking; // 0x18
	WizardGames.Soc.Common.Electric.IOSlotBase[] inputs; // 0x40
	WizardGames.Soc.Common.Electric.IOSlotBase[] outputs; // 0x48
	System.Int32[] currentEnergy; // 0x50
	System.Int32[] cachedOutputsUsed; // 0x58
	System.Action AfterUpdateHasPower; // 0x60
	System.Int64 electricUpdateTimerId; // 0x68
	System.Int64 BelongGroup; // 0x70
	System.Int64 BelongGroupCreateTime; // 0x78
	System.Int32 TopologyOrder; // 0x80
	System.Action OnLightFlagChangeAction; // 0x88
	System.Int32 GetClassHash(); // 0x07021200
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0701d74c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0701d8d8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0701dacc
	WizardGames.Soc.Common.CustomType.PartWireConnection get_PartWireConnection(); // 0x0701defc
	System.Void set_PartWireConnection(WizardGames.Soc.Common.CustomType.PartWireConnection value); // 0x0701dfc0
	System.Int32 get_LightState(); // 0x0701e440
	System.Void set_LightState(System.Int32 value); // 0x0701e04c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07021268
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x070215b8
	System.Void OnGoLoaded(); // 0x07021920
	System.Boolean ClearLine(System.Boolean isInput, System.Int32 slotId); // 0x07021ae0
	static System.Void .cctor(); // 0x07021bb4
	static System.Void OnLightFlagChange(WizardGames.Soc.Share.Framework.CustomTypeBase comp, System.Int32 oldVal, System.Int32 newVal); // 0x07021df4
	System.Void Init(); // 0x07021ed8
	System.Void PostInit(); // 0x07021ff4
	System.Void PostInitCommon(); // 0x070220f8
	System.Void PostInitLogic(); // 0x07022200
	System.Void Cleanup(); // 0x0701e924
	System.Void ClearLogic(); // 0x070222dc
	System.Void UpdateFromInputInner(System.Int32 inputAmount, System.Int32 inputSlot, WizardGames.Soc.Common.CustomType.ElectricCBase outputUnit); // 0x0701e6fc
	System.Void MarkDirty(); // 0x07022344
	System.Void MakePartConnection(System.Boolean isInput, System.Int32 slotId, WizardGames.Soc.Common.CustomType.ElectricCBase connectedEnt, System.Int32 connectSlotId, System.Int64 connectedToID); // 0x070224cc
	System.Void Clear(); // 0x07022268
	System.Void ClearConnections(); // 0x07022614
	WizardGames.Soc.Common.Electric.IOSlotBase TryGetSlot(System.Boolean input, System.Int32 slotId); // 0x07022794
	System.Int32 ConsumptionAmount(WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x0702283c
	System.Boolean IsRootEntity(); // 0x070228bc
	System.Int32 GetCurrentEnergy(WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x07022924
	System.Int32 CalculateCurrentEnergy(System.Int32 inputAmount, System.Int32 inputSlot, WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x070229a4
	System.Int32 MaximalPowerOutput(); // 0x07022a48
	System.Int32 GetPassthroughAmount(System.Int32 outputSlot); // 0x07022ab0
	System.Void SendChangedToRootUpdate(); // 0x07022b30
	System.Void UpdateHasPower(System.Int32 inputAmount, System.Int32 inputSlot); // 0x07022b98
	System.Boolean WantsPower(); // 0x07022c24
	System.ValueTuple<WizardGames.Soc.Common.CustomType.ElectricCBase,System.Int32,System.Int64> TransConnectedEntInfo(System.Boolean isInput, System.Int32 slotId); // 0x07022c8c
	System.Void OnCircuitChanged(System.Boolean forceUpdate); // 0x07022d30
	System.Void UpdateUsedOutputs(); // 0x07022db0
	System.Int32 DesiredPower(WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x07022e18
	System.Int32 DesiredPowerSlot(System.Int32 inputSlot); // 0x07022e98
	System.Boolean WantsPassthroughPower(); // 0x07022f18
	System.Boolean AllowDrainFrom(System.Int32 outputSlot); // 0x07022f80
	System.Boolean IsConnectedTo(WizardGames.Soc.Common.CustomType.ElectricCBase entity, System.Int32 slot, System.Int32 depth, System.Boolean defaultReturn); // 0x07023000
	System.Boolean ConsiderConnectedTo(WizardGames.Soc.Common.CustomType.ElectricCBase entity); // 0x070230b0
	System.Int32 UpdateDelayTime(System.Int64 seqNow); // 0x07023130
	WizardGames.Soc.Common.Electric.IValueSummary GetNeedSummary(); // 0x070231b0
	System.Int32 GetNeedRecursive(System.Int32 inputSlot, System.Collections.Generic.HashSet<System.Int64> listToUse); // 0x0701e828
	System.Boolean AllowLiquidPassthrough(WizardGames.Soc.Common.CustomType.ElectricCBase fromSource, WizardGames.Soc.Common.Algorithm.Vector3 worldPos, System.Boolean forPlacement); // 0x07023218
	System.Void SetFuelType(System.Int64 itemId, WizardGames.Soc.Common.CustomType.FluidicCContainer source); // 0x070232e0
	System.Void IOStateChanged(System.Int32 inputAmount, System.Int32 inputSlot); // 0x0702336c
	System.Void UpdateLightState(); // 0x070233f8
	System.Boolean IsSetLightFlag(System.Boolean input, System.Int32 slotIndex, System.Int32 powerAmount); // 0x07023460
	SocLogger get_Logger(); // 0x07023504
	System.Int64 get_ParentId(); // 0x07022404
	WizardGames.Soc.Common.Entity.PartEntity get_RootPartEntity(); // 0x07023594
	System.Void .ctor(); // 0x0701e53c
	System.Boolean get_IsShortCircuit(); // 0x070236e0
	System.Void set_IsShortCircuit(System.Boolean value); // 0x07023774
	System.Boolean get_HasPower(); // 0x07023820
	System.Void set_HasPower(System.Boolean value); // 0x070238b4
	System.Boolean get_HasWater(); // 0x07023960
	System.Void set_HasWater(System.Boolean value); // 0x070239f4
	System.Boolean get_IsOn(); // 0x07023aa0
	System.Void set_IsOn(System.Boolean value); // 0x07023b34
	System.Boolean get_IsBusy(); // 0x07023be0
	System.Void set_IsBusy(System.Boolean value); // 0x07023c74
	WizardGames.Soc.Common.Electric.IOSlotBase[] get_Inputs(); // 0x07023d20
	WizardGames.Soc.Common.Electric.IOSlotBase[] get_Outputs(); // 0x07023d84
	System.Int32 get_CurrentEnergy(); // 0x07023de8
	WizardGames.Soc.Common.Data.constraction.ElectricalItem get_Config(); // 0x07023e64
	System.Int32 get_consumptionAmount(); // 0x07023ef4
	System.Int32 get_WaterConsumptionAmount(); // 0x07023f64
	System.Int32 get_WaterOutputSpeed(); // 0x07023fd4
	System.Int32 get_maximalPowerOutput(); // 0x0702404c
	System.Int32 get_maxCapacity(); // 0x070240bc
	System.Boolean TryGetSlot(System.Boolean input, System.Int32 slotId, WizardGames.Soc.Common.Electric.IOSlotBase& slot); // 0x0702412c
	System.Void UpdateFromInput(System.Int32 inputAmount, System.Int32 inputSlot, WizardGames.Soc.Common.CustomType.ElectricCBase outputUnit); // 0x070241f4
	System.Void SendElectricNetworkUpdateImmediate(); // 0x07024280
	System.Boolean get_IsGravitySource(); // 0x070242e0
	System.Boolean get_DisregardGravityRestrictionsOnLiquid(); // 0x07024344
	System.Single get_LiquidPassthroughGravityThreshold(); // 0x070243a8
	System.Boolean get_BlockFluidDraining(); // 0x0702440c
	System.Boolean get_LightUpdateWhenIOUpdate(); // 0x07024470
	System.Void RegisterOnLightFlagChange(System.Action action); // 0x070244d4
	System.Void UnRegisterOnLightFlagChange(System.Action action); // 0x070245a8
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCBattery : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1009034144;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Single <RustWattSeconds>k__BackingField; // 0x90
	System.Boolean rechargeable; // 0x94
	System.Single maximumInboundEnergyRatio; // 0x98
	System.Single usageTimer; // 0x9c
	System.Single chargeTimer; // 0xa0
	System.Single checkTimer; // 0xa4
	System.Int64 totTimer; // 0xa8
	System.Single maxCapacitySeconds; // 0xb0
	System.Int32 activeDrain; // 0xb4
	System.Int32 GetClassHash(); // 0x0702467c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x070246e4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x070247a0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0702485c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07024918
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07024c68
	System.Single get_RustWattSeconds(); // 0x07024fd0
	System.Void set_RustWattSeconds(System.Single value); // 0x07025034
	System.Void .ctor(); // 0x070250ac
	System.Void BaseCleanup(); // 0x07025144
	System.Boolean IsRootEntity(); // 0x070251a8
	System.Void Cleanup(); // 0x07025210
	System.Void PostInitLogic(); // 0x07025278
	System.Void ClearLogic(); // 0x070252e8
	System.Void OnCircuitChanged(System.Boolean forceUpdate); // 0x07025358
	System.Void UpdateHasPower(System.Int32 inputAmount, System.Int32 inputSlot); // 0x070253e4
	System.Int32 GetPassthroughAmount(System.Int32 outputSlot); // 0x07025470
	System.Boolean WantsPower(); // 0x070254f0
	System.Int32 DesiredPower(WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x07025558
	WizardGames.Soc.Common.Electric.IValueSummary GetNeedSummary(); // 0x070255d8
	static System.Void .cctor(); // 0x07025640
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCBlocker : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1749866763;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	static System.Int32[] overHeadSeq; // 0x18
	static System.Int32[] overHeadTime; // 0x20
	System.Int32 overHeadIdx; // 0x90
	System.Int64 lastUpdateTime; // 0x98
	System.Int64 lastInverseTime; // 0xa0
	System.Int32 GetClassHash(); // 0x07025808
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07025870
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0702591c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x070259c8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07025a74
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07025dc4
	System.Void .ctor(); // 0x0702612c
	System.Boolean get_LightUpdateWhenIOUpdate(); // 0x070261b4
	System.Void PostInitLogic(); // 0x07026218
	System.Int32 GetPassthroughAmount(System.Int32 outputSlot); // 0x070262f4
	System.Boolean WantsPower(); // 0x070263d0
	System.Void UpdateHasPower(System.Int32 inputAmount, System.Int32 inputSlot); // 0x0702647c
	System.Void IOStateChanged(System.Int32 inputAmount, System.Int32 inputSlot); // 0x07026508
	System.Int32 UpdateDelayTime(System.Int64 seqNow); // 0x070265f0
	static System.Void .cctor(); // 0x07026670
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCBranchSmart : WizardGames.Soc.Common.CustomType.ElectricCBranch
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 288064794;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.HashSet<System.Int64> connectedList; // 0x90
	System.Int32 GetClassHash(); // 0x070268a0
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07026908
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07026aac
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07026c50
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07026df4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x070271f4
	System.Void .ctor(); // 0x070275e4
	System.Int32 MaximalPowerOutput(); // 0x07027740
	System.Void PostInitCommon(); // 0x070277a8
	System.Int32 GetPassthroughAmount(System.Int32 outputSlot); // 0x07027818
	System.Void SendChangedToRootUpdate(); // 0x07027898
	WizardGames.Soc.Common.Electric.IValueSummary GetNeedSummary(); // 0x07027900
	static System.Void .cctor(); // 0x07027968
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCBranch : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 818749283;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07027b30
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07026a00
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07026ba4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07026d48
	System.Int32 get_BranchAmount(); // 0x07027570
	System.Void set_BranchAmount(System.Int32 value); // 0x07027168
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07027b98
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07027f0c
	System.Boolean get_LightUpdateWhenIOUpdate(); // 0x07028288
	System.Void .ctor(); // 0x070276b8
	System.Int32 GetPassthroughAmount(System.Int32 outputSlot); // 0x070282ec
	WizardGames.Soc.Common.Electric.IValueSummary GetNeedSummary(); // 0x0702836c
	static System.Void .cctor(); // 0x070283d4
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCButton : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1558474530;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 emitPowerTimer; // 0x90
	System.Int64 timerId; // 0x98
	System.Int32 GetClassHash(); // 0x0702859c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07028604
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x070286b0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0702875c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07028808
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07028b58
	System.Void .ctor(); // 0x07028ec0
	System.Boolean get_HaveEmitPower(); // 0x07028f48
	System.Void CButtonBaseClearLogic(); // 0x07028fdc
	System.Int32 CButtonBaseConsumptionAmount(WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x07029040
	System.Int32 CButtonBaseGetPassthroughAmount(System.Int32 outputSlot); // 0x070290bc
	System.Void ClearLogic(); // 0x07029138
	System.Boolean WantsPower(); // 0x070291a0
	System.Int32 ConsumptionAmount(WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x07029208
	System.Int32 GetPassthroughAmount(System.Int32 outputSlot); // 0x07029288
	static System.Void .cctor(); // 0x07029308
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCChristmasLight : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 336741948;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0702949c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07029504
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x070295b0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0702965c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07029708
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07029a58
	System.Void .ctor(); // 0x07029dc0
	static System.Void .cctor(); // 0x07029e48
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCCombiner : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1632544853;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07029fdc
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0702a044
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0702a0f0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0702a19c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0702a248
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0702a598
	System.Void .ctor(); // 0x0702a900
	System.Boolean get_LightUpdateWhenIOUpdate(); // 0x0702a988
	System.Boolean IsRootEntity(); // 0x0702a9ec
	System.Boolean get_BlockFluidDraining(); // 0x0702aa50
	System.Int32 GetPassthroughAmount(System.Int32 outputSlot); // 0x0702aab4
	System.Void UpdateFromInputInner(System.Int32 inputAmount, System.Int32 inputSlot, WizardGames.Soc.Common.CustomType.ElectricCBase outputUnit); // 0x0702ab34
	static System.Void .cctor(); // 0x0702abec
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCCounter : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 70932220;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0702ad80
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0702ade8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0702ae94
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0702af40
	System.Int32 get_NumberNow(); // 0x0702afec
	System.Void set_NumberNow(System.Int32 value); // 0x0702b060
	System.Int32 get_CounterTarget(); // 0x0702b0ec
	System.Void set_CounterTarget(System.Int32 value); // 0x0702b160
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0702b1ec
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0702b58c
	System.Void .ctor(); // 0x0702b924
	System.Boolean get_incrementHasPower(); // 0x0702b9ac
	System.Void set_incrementHasPower(System.Boolean value); // 0x0702ba40
	System.Boolean get_decrementHasPower(); // 0x0702baec
	System.Void set_decrementHasPower(System.Boolean value); // 0x0702bb80
	System.Boolean get_clearHasPower(); // 0x0702bc2c
	System.Void set_clearHasPower(System.Boolean value); // 0x0702bcc0
	System.Boolean get_isCounterMode(); // 0x0702bd6c
	System.Boolean WantsPower(); // 0x0702be00
	System.Int32 GetPassthroughAmount(System.Int32 outputSlot); // 0x0702be68
	System.Void IOStateChanged(System.Int32 inputAmount, System.Int32 inputSlot); // 0x0702bee8
	static System.Void .cctor(); // 0x0702bf84
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCDoorController : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 112463074;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0702c180
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0702c1e8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0702c294
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0702c340
	System.Int64 get_DoorEntityId(); // 0x0702c3ec
	System.Void set_DoorEntityId(System.Int64 value); // 0x0702c460
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0702c4ec
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0702c860
	System.Void .ctor(); // 0x0702cbe8
	static System.Void .cctor(); // 0x0702cc70
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCElevator : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1198890139;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Action<System.Int32,System.Int32> IOPowerUpdateAction; // 0x90
	System.Int32 GetClassHash(); // 0x0702ce6c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0702ced4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0702cf80
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0702d02c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0702d0d8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0702d428
	System.Void .ctor(); // 0x0702d790
	System.Void IOStateChanged(System.Int32 inputAmount, System.Int32 inputSlot); // 0x0702d818
	static System.Void .cctor(); // 0x0702d8bc
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCFuelGenerator : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 973591800;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0702da50
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0702dab8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0702db64
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0702dc10
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0702dcbc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0702e00c
	System.Void .ctor(); // 0x0702e374
	System.Void PostInitLogic(); // 0x0702e3fc
	System.Void ClearLogic(); // 0x0702e46c
	System.Int32 GetCurrentEnergy(WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x0702e4dc
	System.Boolean IsRootEntity(); // 0x0702e55c
	System.Void IOStateChanged(System.Int32 inputAmount, System.Int32 inputSlot); // 0x0702e5f4
	static System.Void .cctor(); // 0x0702e690
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCHeater : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1472860499;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0702e824
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0702e88c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0702e938
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0702e9e4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0702ea90
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0702ede0
	System.Void .ctor(); // 0x0702f148
	static System.Void .cctor(); // 0x0702f1d0
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCIgniter : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 805641050;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0702f364
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0702f3cc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0702f478
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0702f524
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0702f5d0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0702f920
	System.Void .ctor(); // 0x0702fc88
	static System.Void .cctor(); // 0x0702fd10
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCIntegratedCircuit : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1280980477;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	static WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit blueprint; // 0x18
	System.Int32 GetClassHash(); // 0x0702fea4
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0701fde4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0701ff3c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x070200fc
	WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit get_IntegratedCircuit(); // 0x070205c4
	System.Void set_IntegratedCircuit(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit value); // 0x07020688
	System.String get_BlueprintName(); // 0x07020c0c
	System.Void set_BlueprintName(System.String value); // 0x07020714
	System.Int32 get_BlueprintStorage(); // 0x07020c80
	System.Void set_BlueprintStorage(System.Int32 value); // 0x070207a0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0702ff0c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07030328
	System.Void .ctor(); // 0x07020d7c
	static System.Int32 EncodeToPortId(System.Boolean input, System.Int32 slotId); // 0x07030708
	static System.Void DecodeToBoInt(System.Int32 index, System.Boolean& isInput, System.Int32& slotId); // 0x0703078c
	System.Boolean get_IsCustomCircuit(); // 0x07030820
	WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit GetTemplate(); // 0x07030884
	System.Void PostInitLogic(); // 0x070308ec
	System.Void ClearLogic(); // 0x0703095c
	System.ValueTuple<WizardGames.Soc.Common.CustomType.ElectricCBase,System.Int32,System.Int64> TransConnectedEntInfo(System.Boolean isInput, System.Int32 slotId); // 0x070309cc
	WizardGames.Soc.Common.Electric.IOSlotBase TryGetSlot(System.Boolean input, System.Int32 slotId); // 0x07030a70
	System.Int32 ConsumptionAmount(WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x07030afc
	System.Boolean IsConnectedTo(WizardGames.Soc.Common.CustomType.ElectricCBase entity, System.Int32 slot, System.Int32 depth, System.Boolean defaultReturn); // 0x07030b7c
	System.Void UpdateUsedOutputs(); // 0x07030c2c
	System.Int32 CIntegratedCircuitBaseConsumptionAmount(WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x07030c94
	System.ValueTuple<WizardGames.Soc.Common.CustomType.ElectricCBase,System.Int32,System.Int64> CIntegratedCircuitBaseTransConnectedEntInfo(System.Boolean isInput, System.Int32 slotId); // 0x07030d10
	static System.Void .cctor(); // 0x07030db0
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCLaserDetector : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 508211675;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Boolean someoneEnter; // 0x90
	System.Int32 GetClassHash(); // 0x07031014
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0703107c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07031128
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x070311d4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07031280
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x070315d0
	System.Void .ctor(); // 0x07031938
	System.Void UpdateHasPower(System.Int32 inputAmount, System.Int32 inputSlot); // 0x070319c0
	System.Int32 GetPassthroughAmount(System.Int32 outputSlot); // 0x07031a5c
	System.Boolean AllowDrainFrom(System.Int32 outputSlot); // 0x07031b34
	static System.Void .cctor(); // 0x07031be8
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCLiveSensor : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 719910407;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07031d7c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07031de4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07031e90
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07031f3c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07031fe8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07032338
	System.Void .ctor(); // 0x070326a0
	System.Int32 GetPassthroughAmount(System.Int32 outputSlot); // 0x07032728
	System.Boolean AllowDrainFrom(System.Int32 outputSlot); // 0x07032800
	static System.Void .cctor(); // 0x070328b4
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCLoad : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 893770399;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07032a48
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07032ab0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07032b5c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07032c08
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07032cb4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07033004
	System.Void .ctor(); // 0x0703336c
	System.Int32 ConsumptionAmount(WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x070333f4
	static System.Void .cctor(); // 0x07033470
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCMemoryCell : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 405468281;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 emitPowerTimer; // 0x90
	System.Int32 emitPower; // 0x98
	System.Int32 GetClassHash(); // 0x07033604
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0703366c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07033720
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x070337d4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07033888
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07033bd8
	System.Void .ctor(); // 0x07033f40
	System.Boolean get_HaveEmitPower(); // 0x07033fd0
	System.Void set_HaveEmitPower(System.Boolean value); // 0x07034064
	System.Boolean get_ChooseFlag2(); // 0x07034110
	System.Void set_ChooseFlag2(System.Boolean value); // 0x07034174
	System.Int32 get_chooseSlot(); // 0x070341f0
	System.Boolean get_LightUpdateWhenIOUpdate(); // 0x0703425c
	System.Void PostInitLogic(); // 0x070342c0
	System.Void ClearLogic(); // 0x0703436c
	System.Int32 GetPassthroughAmount(System.Int32 outputSlot); // 0x07034444
	System.Void UpdateHasPower(System.Int32 inputAmount, System.Int32 inputSlot); // 0x070344c4
	System.Void IOStateChanged(System.Int32 inputAmount, System.Int32 inputSlot); // 0x07034550
	System.Boolean AllowDrainFrom(System.Int32 outputSlot); // 0x070345ec
	static System.Void .cctor(); // 0x070346c4
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCMultiBranch : WizardGames.Soc.Common.CustomType.ElectricCIntegratedCircuit
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1637675389;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	static WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit multiBranchBlueprint; // 0x18
	System.Int32 GetClassHash(); // 0x07034858
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x070348c0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0703496c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07034a18
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07034ac4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07034ee0
	System.Void .ctor(); // 0x070352c0
	System.Boolean get_IsCustomCircuit(); // 0x07035348
	System.Boolean get_LightUpdateWhenIOUpdate(); // 0x070353ac
	WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit GetTemplate(); // 0x07035410
	System.Void UpdateLightState(); // 0x07035478
	static System.Void .cctor(); // 0x070354e0
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCMultiPortCombiner : WizardGames.Soc.Common.CustomType.ElectricCCombiner
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 613231192;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07035744
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x070357ac
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07035858
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07035904
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x070359b0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07035d00
	System.Void .ctor(); // 0x07036068
	static System.Void .cctor(); // 0x070360f0
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricConnectSystem : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1910878677;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07036284
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x070362ec
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07036378
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07036404
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07036490
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x070366f8
	System.Void .ctor(); // 0x070369d8
	static System.Void .cctor(); // 0x07036a40
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCOrSwitch : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 655579337;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 choosenInput; // 0x90
	System.Int32 maxPower; // 0x94
	System.Int32 GetClassHash(); // 0x07036b68
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07036bd0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07036c7c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07036d28
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07036dd4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07037124
	System.Void .ctor(); // 0x0703748c
	System.Boolean get_LightUpdateWhenIOUpdate(); // 0x07037514
	System.Void COrSwitchBaseUpdateFromInputInner(System.Int32 inputAmount, System.Int32 inputSlot, WizardGames.Soc.Common.CustomType.ElectricCBase outputUnit); // 0x07037578
	System.Void Cleanup(); // 0x07037618
	System.Int32 DesiredPowerSlot(System.Int32 inputSlot); // 0x07037688
	System.Int32 GetPassthroughAmount(System.Int32 outputSlot); // 0x07037708
	System.Void UpdateHasPower(System.Int32 inputAmount, System.Int32 inputSlot); // 0x07037788
	System.Void UpdateFromInputInner(System.Int32 inputAmount, System.Int32 inputSlot, WizardGames.Soc.Common.CustomType.ElectricCBase outputUnit); // 0x07037814
	static System.Void .cctor(); // 0x070378b8
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCPressurePad : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1548225316;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 emitPowerTimer; // 0x90
	System.Int32 GetClassHash(); // 0x07037a4c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07037ab4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07037b60
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07037c0c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07037cb8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07038008
	System.Boolean get_HaveEmitPower(); // 0x07038370
	System.Void .ctor(); // 0x07038404
	System.Void Cleanup(); // 0x0703848c
	System.Int32 GetPassthroughAmount(System.Int32 outputSlot); // 0x070384fc
	System.Boolean AllowDrainFrom(System.Int32 outputSlot); // 0x0703857c
	static System.Void .cctor(); // 0x070385fc
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCRandSwitch : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1951926346;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Boolean isThrough; // 0x90
	System.Int32 GetClassHash(); // 0x07038790
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x070387f8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x070388ac
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07038960
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07038a14
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07038d64
	System.Void .ctor(); // 0x070390cc
	System.Boolean get_LightUpdateWhenIOUpdate(); // 0x0703915c
	System.Boolean get_notOutputValue(); // 0x070391c0
	System.Void set_notOutputValue(System.Boolean value); // 0x07039254
	System.Boolean WantsPower(); // 0x07039300
	System.Int32 GetPassthroughAmount(System.Int32 outputSlot); // 0x07039368
	System.Void UpdateHasPower(System.Int32 inputAmount, System.Int32 inputSlot); // 0x070393e8
	System.Void IOStateChanged(System.Int32 inputAmount, System.Int32 inputSlot); // 0x07039474
	System.Void CRandSwitchBaseIOStateChanged(System.Int32 inputAmount, System.Int32 inputSlot); // 0x07039500
	static System.Void .cctor(); // 0x07039588
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCSearchLight : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1605371232;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x070399e4
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07039a4c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07039afc
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07039bac
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07039c5c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07039fbc
	System.Void .ctor(); // 0x0703a330
	static System.Void .cctor(); // 0x0703a3bc
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCSolarPanel : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1026618265;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0703a550
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0703a5b8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0703a668
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0703a718
	System.Int32 get_CurPower(); // 0x0703a7c8
	System.Void set_CurPower(System.Int32 value); // 0x0703a83c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0703a8c8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0703ac4c
	System.Void .ctor(); // 0x0703afd4
	System.Boolean IsRootEntity(); // 0x0703b060
	System.Int32 GetPassthroughAmount(System.Int32 outputSlot); // 0x0703b0c4
	static System.Void .cctor(); // 0x0703b144
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCSplitter : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1227636356;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0703b30c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0703b374
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0703b424
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0703b4d4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0703b584
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0703b8e4
	System.Void .ctor(); // 0x0703bc58
	System.Boolean get_BlockFluidDraining(); // 0x0703bce4
	static System.Void .cctor(); // 0x0703bd48
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCSwitch : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 874815927;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 timerId; // 0x90
	System.Int32 GetClassHash(); // 0x0703bedc
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0703bf44
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0703bff4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0703c0a4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0703c154
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0703c4b4
	System.Void .ctor(); // 0x0703c828
	System.Void CSwitchBaseClearLogic(); // 0x0703c8b4
	System.Int32 CSwitchBaseConsumptionAmount(WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x0703c91c
	System.Void CSwitchBaseIOStateChanged(System.Int32 inputAmount, System.Int32 inputSlot); // 0x0703c99c
	System.Void ClearLogic(); // 0x0703ca28
	System.Boolean WantsPower(); // 0x0703ca90
	System.Int32 ConsumptionAmount(WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x0703caf8
	System.Void IOStateChanged(System.Int32 inputAmount, System.Int32 inputSlot); // 0x0703cb78
	System.Int32 GetPassthroughAmount(System.Int32 outputSlot); // 0x0703cc04
	static System.Void .cctor(); // 0x0703cc84
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCTestGenerator : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 96230034;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0703ce18
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0703ce80
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0703cf30
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0703cfe0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0703d090
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0703d3f0
	System.Void .ctor(); // 0x0703d764
	System.Boolean IsRootEntity(); // 0x0703d7f0
	System.Int32 GetCurrentEnergy(WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x0703d888
	System.Int32 GetPassthroughAmount(System.Int32 outputSlot); // 0x0703d948
	static System.Void .cctor(); // 0x0703da00
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCTimer : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1377775339;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 timer; // 0x90
	System.Int32 GetClassHash(); // 0x0703db94
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0703dbfc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0703dcac
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0703dd5c
	System.Int32 get_TimerTime(); // 0x0703de0c
	System.Void set_TimerTime(System.Int32 value); // 0x0703de80
	System.Int64 get_FinishTime(); // 0x0703df0c
	System.Void set_FinishTime(System.Int64 value); // 0x0703df80
	System.Int64 get_LastStartTime(); // 0x0703e00c
	System.Void set_LastStartTime(System.Int64 value); // 0x0703e080
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0703e10c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0703e4e0
	System.Void .ctor(); // 0x0703e8a8
	System.Void CTimerBaseInit(); // 0x0703e934
	System.Void CTimerBaseClearLogic(); // 0x0703e99c
	System.Void CTimerBaseUpdateFromInputInner(System.Int32 inputAmount, System.Int32 inputSlot, WizardGames.Soc.Common.CustomType.ElectricCBase outputUnit); // 0x0703ea04
	System.Void CTimerBaseIOStateChanged(System.Int32 inputAmount, System.Int32 inputSlot); // 0x0703eaa8
	System.Int32 CTimerBaseConsumptionAmount(WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x0703eb34
	System.Void Init(); // 0x0703ebb4
	System.Void ClearLogic(); // 0x0703eca8
	System.Void UpdateFromInputInner(System.Int32 inputAmount, System.Int32 inputSlot, WizardGames.Soc.Common.CustomType.ElectricCBase outputUnit); // 0x0703ed10
	System.Void IOStateChanged(System.Int32 inputAmount, System.Int32 inputSlot); // 0x0703edb4
	System.Boolean WantsPower(); // 0x0703ee40
	System.Int32 ConsumptionAmount(WizardGames.Soc.Common.Electric.EIOSlotType type); // 0x0703eee4
	System.Int32 GetPassthroughAmount(System.Int32 outputSlot); // 0x0703eff8
	static System.Void .cctor(); // 0x0703f0d4
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCWindmill : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 76088887;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0703f304
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0703f36c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0703f41c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0703f4cc
	System.Single get_ServerWindSpeed(); // 0x0703f57c
	System.Void set_ServerWindSpeed(System.Single value); // 0x0703f5f0
	System.Int32 get_CurPower(); // 0x0703f67c
	System.Void set_CurPower(System.Int32 value); // 0x0703f6f0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0703f77c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0703fb28
	System.Void .ctor(); // 0x0703fed4
	System.Boolean get_NotVisible(); // 0x0703ff60
	System.Boolean IsRootEntity(); // 0x0703fff4
	static System.Void .cctor(); // 0x07040058
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricCXorSwitch : WizardGames.Soc.Common.CustomType.ElectricCBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1639708925;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 choosenInput; // 0x90
	System.Int32 maxPower; // 0x94
	System.Int32 minPower; // 0x98
	System.Int32 GetClassHash(); // 0x07040254
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x070402bc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0704036c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0704041c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x070404cc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0704082c
	System.Void .ctor(); // 0x07040ba0
	System.Boolean get_LightUpdateWhenIOUpdate(); // 0x07040c2c
	System.Void CXorSwitchBaseUpdateFromInputInner(System.Int32 inputAmount, System.Int32 inputSlot, WizardGames.Soc.Common.CustomType.ElectricCBase outputUnit); // 0x07040c90
	System.Void Cleanup(); // 0x07040d34
	System.Int32 DesiredPowerSlot(System.Int32 inputSlot); // 0x07040da8
	System.Int32 GetPassthroughAmount(System.Int32 outputSlot); // 0x07040e28
	System.Void UpdateHasPower(System.Int32 inputAmount, System.Int32 inputSlot); // 0x07040ea8
	System.Void UpdateFromInputInner(System.Int32 inputAmount, System.Int32 inputSlot, WizardGames.Soc.Common.CustomType.ElectricCBase outputUnit); // 0x07040f34
	System.Void UpdateLightState(); // 0x07040fd8
	static System.Void .cctor(); // 0x07041040
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricFakeEntity : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.CustomType.IEntityWithElectric, WizardGames.Soc.Common.Component.IFlagComp
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1187987795;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Boolean <IsLocalEntity>k__BackingField; // 0x28
	System.Action<System.Int32,System.Int32> OnFlagChanged; // 0x30
	System.Int32 GetClassHash(); // 0x070411d4
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704123c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x070412c8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x070413bc
	System.Int64 get_TemplateId(); // 0x07041448
	System.Void set_TemplateId(System.Int64 value); // 0x070414bc
	System.Int64 get_EntityId(); // 0x07041548
	System.Void set_EntityId(System.Int64 value); // 0x070415bc
	System.Int32 get_Flags(); // 0x07041648
	System.Void set_Flags(System.Int32 value); // 0x070416bc
	WizardGames.Soc.Common.CustomType.ElectricCBase get_ElectricC(); // 0x07041748
	System.Void set_ElectricC(WizardGames.Soc.Common.CustomType.ElectricCBase value); // 0x0704180c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07041898
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07041c38
	System.Void .ctor(); // 0x07041fdc
	System.Boolean get_IsLocalEntity(); // 0x07042044
	System.Void FrameworkClean(); // 0x070420a8
	T GetComponent<T>(System.Int32 componentId); // 0x052af1f0
	static System.Void .cctor(); // 0x07042108
	static System.Void OnFlagsChanged(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int32 oldVal, System.Int32 newVal); // 0x070423a0
	System.Void RegisterFlagChangeCallback(System.Action<System.Int32,System.Int32> callback); // 0x07042478
	System.Void UnRegisterFlagChangeCallback(System.Action<System.Int32,System.Int32> callback); // 0x0704255c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricUpdateGroupContext : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 678913840;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.CustomType.ElectricUpdateGroup> electricUpdateGroups; // 0x28
	System.Int32 electricGroupRepeatId; // 0x30
	System.Int32 GetClassHash(); // 0x07042640
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x070426a8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07042788
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07042868
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07042948
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07042bb0
	System.Void .ctor(); // 0x07042e90
	static System.Void .cctor(); // 0x07042f4c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricUpdateGroup : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 469624067;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 groupId; // 0x28
	System.Collections.Generic.HashSet<System.Int64> units; // 0x30
	static WizardGames.Soc.Common.CustomType.ElectricUpdateGroup.ProcessDicComp processDicComp; // 0x18
	System.Collections.Generic.SortedSet<System.Int64> _processDicNow; // 0x38
	static System.Int32 updNumPerFrame; // 0x20
	System.Int32 GetClassHash(); // 0x07043074
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x070430dc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07043240
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x070433a4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07043508
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07043770
	System.Int32 get_GroupSize(); // 0x07043a50
	static System.Collections.Generic.Dictionary<System.Int64,System.Int32> get_processOrderCache(); // 0x07043acc
	static System.Void .cctor(); // 0x07043b68
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricUpdateGroup.ProcessDicComp : System.Object, System.Collections.Generic.IComparer<System.Int64>
{
	
	System.Int32 Compare(System.Int64 a, System.Int64 b); // 0x07043d44
	System.Void .ctor(); // 0x07043cdc
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ElectricUpdateSystem : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 951914515;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.HashSet<System.Int64>[] processDics; // 0x28
	System.Collections.Generic.HashSet<System.Int64> updateVisedSet; // 0x30
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> processOrderCache; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.CustomType.ElectricUpdateGroup> needUpdateGroups; // 0x40
	System.Int64 <ElectricUpdateSeq>k__BackingField; // 0x48
	System.Int32 GetClassHash(); // 0x07043e6c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07043ed4
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x070441bc
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x070444a4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704478c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x070449f4
	System.Void .ctor(); // 0x07044cd4
	WizardGames.Soc.Common.CustomType.ElectricUpdateGroupContext get_updateGroups(); // 0x07044f98
	System.Int64 get_ElectricUpdateSeq(); // 0x07045038
	System.Void set_ElectricUpdateSeq(System.Int64 value); // 0x0704509c
	System.Collections.Generic.HashSet<System.Int64> get_ProcessDicNxtTimer(); // 0x07045114
	System.Int32 get_NextTimerIdx(); // 0x070451a0
	static System.Void .cctor(); // 0x0704525c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.EmbeddedCustomBase : WizardGames.Soc.Share.Framework.CustomTypeBase, WizardGames.Soc.Common.Entity.IEmbeddedCustom, WizardGames.Soc.Common.Entity.IEntity
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 762135483;
	static System.Int32 StaticClassHash; // 0x8
	static System.Func<System.Int64> idGenerator; // 0x10
	static System.Int32 MAX_LOOP_COUNT = 10;
	System.Int32 GetClassHash(); // 0x07045384
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x070453ec
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07045478
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07045504
	System.Int64 get_EntityId(); // 0x07045590
	System.Void set_EntityId(System.Int64 value); // 0x07045604
	System.Int32 get_EntityType(); // 0x07045690
	System.Void set_EntityType(System.Int32 value); // 0x07045704
	System.Void .ctor(System.Int32 entityType, System.Int64 id); // 0x07045790
	WizardGames.Soc.Common.Entity.IEntity get_RootParent(); // 0x0704587c
	System.Boolean get_IsAttachedToMgr(); // 0x07045948
	static System.Void .cctor(); // 0x07045a60
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.EmbeddedCustomBase.<>c : System.Object
{
	static WizardGames.Soc.Common.CustomType.EmbeddedCustomBase.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x07045bd8
	System.Void .ctor(); // 0x07045c3c
	System.Int64 <.cctor>b__23_0(); // 0x07045ca4
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.EncounteredPlayer : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1353314506;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07045d08
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07045d70
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07045dfc
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07045e88
	System.Int32 get_LastTs(); // 0x07045f14
	System.Void set_LastTs(System.Int32 value); // 0x07045f88
	System.UInt32 get_Reason(); // 0x07046014
	System.Void set_Reason(System.UInt32 value); // 0x07046088
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07046114
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x070463d8
	static System.Void .cctor(); // 0x07046714
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.EngineItemNode : WizardGames.Soc.Common.CustomType.DirectoryItemNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1746160427;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x070468a8
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07046910
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x070469c0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07046a70
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07046b20
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07047080
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x07047524
	static System.Object DeserializeEngineItemNodeContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704777c
	static System.Void .cctor(); // 0x07047850
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.EntityMarker : WizardGames.Soc.Common.CustomType.MarkerBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1954877726;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07047c20
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07047c88
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07047d38
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07047de8
	System.Int64 get_EntityId(); // 0x07047e98
	System.Void set_EntityId(System.Int64 value); // 0x07047f0c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07047f98
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07048430
	System.Void FromEJson(SimpleJSON.JSONNode json); // 0x0704885c
	static System.Object DeserializeEntityMarkerContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07048ab4
	static System.Void .cctor(); // 0x07048b88
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.EntityRecord : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 833955162;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07048e88
	System.Void .ctor(); // 0x07048ef0
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07048f58
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07048fe4
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07049070
	System.Int64 get_EntityId(); // 0x070490fc
	System.Void set_EntityId(System.Int64 value); // 0x07049170
	System.Int32 get_EntityType(); // 0x070491fc
	System.Void set_EntityType(System.Int32 value); // 0x07049270
	System.Int64 get_Ts(); // 0x070492fc
	System.Void set_Ts(System.Int64 value); // 0x07049370
	System.Int32 get_LodLevel(); // 0x070493fc
	System.Void set_LodLevel(System.Int32 value); // 0x07049470
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x070494fc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x07049810
	static System.Void .cctor(); // 0x07049b7c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.EquipmentDisplayData : WizardGames.Soc.Share.Framework.CustomTypeBase
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 475159815;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x07049d78
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x07049de0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x07049e6c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x07049ef8
	System.Int64 get_TableId(); // 0x07049f84
	System.Void set_TableId(System.Int64 value); // 0x07049ff8
	System.Int64 get_SkinId(); // 0x0704a084
	System.Void set_SkinId(System.Int64 value); // 0x0704a0f8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704a184
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0704a448
	System.Void .ctor(); // 0x0704a774
	System.Void .ctor(System.Int64 tableId, System.Int64 skinId); // 0x0704a7dc
	System.Void .ctor(WizardGames.Soc.Common.CustomType.EquipmentDisplayData other); // 0x0704a878
	static System.Void .cctor(); // 0x0704a924
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.ExampleEventNode : WizardGames.Soc.Common.CustomType.EventNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 91300488;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0704aab8
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704ab20
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0704ac7c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0704add8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704af34
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0704b19c
	static System.Object DeserializeExampleEventNodeContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704b47c
	static System.Void .cctor(); // 0x0704b560
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.GraphCustomEventNode : WizardGames.Soc.Common.CustomType.EventNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1144393757;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0704b894
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704b8fc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0704b9a8
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0704ba54
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704bb00
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0704bd68
	static System.Object DeserializeGraphCustomEventNodeContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704c048
	static System.Void .cctor(); // 0x0704c16c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.PlayerDieEventNode : WizardGames.Soc.Common.CustomType.EventNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1899043944;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0704c438
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704c4a0
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0704c54c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0704c5f8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704c6a4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0704c90c
	static System.Object DeserializePlayerDieEventNodeContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704cbec
	static System.Void .cctor(); // 0x0704ccc8
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.PlayerGetUpEventNode : WizardGames.Soc.Common.CustomType.EventNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1076540027;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0704cf60
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704cfc8
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0704d074
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0704d120
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704d1cc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0704d434
	static System.Object DeserializePlayerGetUpEventNodeContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704d714
	static System.Void .cctor(); // 0x0704d7e8
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.PlayerLoginEventNode : WizardGames.Soc.Common.CustomType.EventNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1417938447;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0704da18
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704da80
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0704db2c
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0704dbd8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704dc84
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0704deec
	static System.Object DeserializePlayerLoginEventNodeContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704e1cc
	static System.Void .cctor(); // 0x0704e2a0
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.PlayerOfflineEventNode : WizardGames.Soc.Common.CustomType.EventNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1817063010;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0704e504
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704e56c
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0704e618
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0704e6c4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704e770
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0704e9d8
	static System.Object DeserializePlayerOfflineEventNodeContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704ecb8
	static System.Void .cctor(); // 0x0704ed8c
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.PlayerRebornEventNode : WizardGames.Soc.Common.CustomType.EventNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 899411031;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0704efbc
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704f024
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0704f0d0
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0704f17c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704f228
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0704f490
	static System.Object DeserializePlayerRebornEventNodeContainer(MessagePack.MessagePackReader& reader, System.Int32 propertyId, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704f770
	static System.Void .cctor(); // 0x0704f844
}

// Client.Runtime
class WizardGames.Soc.Common.CustomType.NodeTestEventNode : WizardGames.Soc.Common.CustomType.EventNode
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 283099795;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 GetClassHash(); // 0x0704fa74
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704fadc
	System.Void .ctor(System.Int64 _, WizardGames.Soc.Share.Framework.ArrayDataSet ads); // 0x0704fb88
	System.Void .ctor(System.Boolean useless, SimpleJSON.JSONNode json); // 0x0704fc34
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x0704fce0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x0704ff48
	static System.Void .cctor(); // 0x07050228
