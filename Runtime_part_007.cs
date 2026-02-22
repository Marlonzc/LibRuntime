	System.Void OnTriggerEnter(UnityEngine.Collider co); // 0x06da2c48
	System.Void OnTriggerExit(UnityEngine.Collider co); // 0x06da2ef8
	System.Void OnEntityEnter(WizardGames.Soc.Common.Entity.IEntity ent, UnityEngine.Collider co); // 0x06da2cf0
	System.Void OnEntityLeave(WizardGames.Soc.Common.Entity.IEntity ent, UnityEngine.Collider co); // 0x06da2fa0
	System.Boolean OverlapCheck(System.Single check_scale); // 0x06da2274
	WizardGames.Soc.Common.Entity.IEntity GetEntityByCollider(UnityEngine.Collider collider); // 0x06da3070
	System.Void OnEntityDead(WizardGames.Soc.Common.Entity.IEntity ent, WizardGames.Soc.Common.Entity.IEntity source, WizardGames.Soc.Common.SimpleCustom.DamageDataEvent damageDataEvent); // 0x06da3294
	System.Boolean CanDefuse(WizardGames.Soc.Common.Entity.PlayerEntity player); // 0x06da34b4
	System.Void .ctor(); // 0x06da35d0
	static System.Void .cctor(); // 0x06da36f0
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.ConditionLoseData : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	System.Int64 EntityID; // 0x20
	System.Single ConditionLose; // 0x28
	static WizardGames.Soc.Common.Combat.ConditionLoseData TryAddConditionLoseData(WizardGames.Soc.Common.Entity.IItemEntity itemEntity, System.Single lose); // 0x06da37c4
	System.Void Dispose(); // 0x06da3980
	System.Void .ctor(); // 0x06da39f4
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.DamageTypesEx : System.Object
{
	
	static System.Void Add(WizardGames.Soc.Common.SimpleCustom.DamageTypeList damageTypeList, WizardGames.Soc.Common.Data.DamageInfo[] damageInfos, System.Single scale); // 0x06da3a5c
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.EscapeRequest : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	
	System.Void .ctor(); // 0x06da3b48
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.ExplosionRequest : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	System.Int32 Id; // 0x1c
	System.Single PosX; // 0x20
	System.Single PosY; // 0x24
	System.Single PosZ; // 0x28
	System.Int32 Num; // 0x2c
	System.String FpxPath; // 0x30
	System.Int64 OwnEntityID; // 0x38
	System.Int64 WeaponTableID; // 0x40
	System.Int64 WeaponSkinID; // 0x48
	System.Int64 AttachId; // 0x50
	System.Int32 AttachType; // 0x58
	System.Int64 LocalTime; // 0x60
	System.Void Dispose(); // 0x06da3bb0
	System.Void .ctor(); // 0x06da3c5c
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.FireRequest : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	WizardGames.Soc.Common.Entity.IEntity OwnerEntity; // 0x20
	System.Numerics.Vector3 Position; // 0x28
	System.Numerics.Vector3 Direction; // 0x34
	System.Single InitialVelocity; // 0x40
	System.Int64 OwnerEntityId; // 0x48
	System.Int32 Sequence; // 0x50
	System.Int64 WeaponId; // 0x58
	System.Int64 WeaponTableID; // 0x60
	System.Int32 PveAttFix; // 0x68
	System.Int32 AmmoTableID; // 0x6c
	System.Single DamageScale; // 0x70
	System.Int32 Index; // 0x74
	System.Boolean MagicBullet; // 0x78
	System.Boolean IsServerBullet; // 0x79
	System.Int64 SkinId; // 0x80
	System.Int64 LocalTime; // 0x88
	System.Int64 TargetEntityId; // 0x90
	System.Numerics.Vector3 CmdEyePosition; // 0x98
	static WizardGames.Soc.Common.Combat.FireRequest Generate(); // 0x06da3cc4
	System.Void Dispose(); // 0x06da3d3c
	System.Void .ctor(); // 0x06da3e0c
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.DamageTypeEntry : System.Object
{
	WizardGames.Soc.Common.SimpleCustom.DamageType type; // 0x10
	System.Single amount; // 0x14
	System.Void .ctor(); // 0x06da3e7c
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.HostileRequest : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	WizardGames.Soc.Common.Entity.IEntity entity; // 0x20
	System.Single totalTime; // 0x28
	System.Boolean active; // 0x2c
	System.Void Dispose(); // 0x06da3ee4
	System.Void .ctor(); // 0x06da3f64
}

// Client.Runtime
enum WizardGames.Soc.Common.Combat.HitDirection : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Combat.HitDirection Front = 8;
	static WizardGames.Soc.Common.Combat.HitDirection Back = 2;
	static WizardGames.Soc.Common.Combat.HitDirection Left = 4;
	static WizardGames.Soc.Common.Combat.HitDirection Right = 6;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Combat.HitPartSimple : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Combat.HitPartSimple head = 1;
	static WizardGames.Soc.Common.Combat.HitPartSimple torso = 2;
	static WizardGames.Soc.Common.Combat.HitPartSimple leg = 3;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.DeathAnimRequest : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	System.Int64 TargetID; // 0x20
	System.Numerics.Vector3 Direction; // 0x28
	System.Void Dispose(); // 0x06da3fcc
	System.Void .ctor(); // 0x06da4048
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.KillRequest : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	System.Int64 SourceId; // 0x20
	System.Int64 TargetId; // 0x28
	WizardGames.Soc.Common.SimpleCustom.DamageType DamageType; // 0x30
	System.Boolean IsHeadShot; // 0x34
	WizardGames.Soc.Common.SimpleCustom.DamageDataEvent DamageData; // 0x38
	System.Boolean FromWeapon; // 0x40
	System.Numerics.Vector3 Dir; // 0x44
	System.Int32 ColliderIndex; // 0x50
	WizardGames.Soc.Common.Combat.HitPart HitPart; // 0x54
	System.Numerics.Vector3 HitObjectPoint; // 0x58
	System.Int32 <LifeCycleFlagsOnRequest>k__BackingField; // 0x64
	System.Void set_LifeCycleFlagsOnRequest(System.Int32 value); // 0x06da40b0
	System.Void Dispose(); // 0x06da4128
	System.Void .ctor(); // 0x06da422c
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.OfflineRequest : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	
	System.Void .ctor(); // 0x06da429c
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.RebornRequest : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	System.Int64 PlayerId; // 0x20
	System.Numerics.Vector3 RebornPos; // 0x28
	System.Numerics.Quaternion RebornRot; // 0x34
	System.Void Dispose(); // 0x06da4304
	System.Void .ctor(); // 0x06da4390
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.UseItemRequest : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	System.UInt64 RoleId; // 0x20
	System.Int64 ItemUid; // 0x28
	System.Int64 TableId; // 0x30
	System.Int64 TargetEntityId; // 0x38
	System.Void Dispose(); // 0x06da43f8
	System.Void .ctor(); // 0x06da4468
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.UseItemAckRequest : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	System.Int32 OpCode; // 0x1c
	System.Int64 ItemUid; // 0x20
	System.Int64 ItemTableId; // 0x28
	System.Int32 Count; // 0x30
	System.Void Dispose(); // 0x06da44d0
	System.Void .ctor(); // 0x06da4544
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.PlayerSwitchHeldItemData : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	System.Int64 EntityID; // 0x20
	System.Int64 OldHeldItemID; // 0x28
	System.Int64 NewHeldItemID; // 0x30
	static SocLogger logger; // 0x0
	static WizardGames.Soc.Common.Combat.PlayerSwitchHeldItemData CreateSwitchReqeust(System.Int64 hostId, System.Int64 oldHeldItem, System.Int64 newHeldItem, System.Boolean isFp); // 0x06da45ac
	System.Void Dispose(); // 0x06da47b4
	System.Void .ctor(); // 0x06da4828
	static System.Void .cctor(); // 0x06da4890
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.SmartFireController : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Data.SmartFireEnableButton <EnabledButton>k__BackingField; // 0x10
	WizardGames.Soc.Common.Data.SmartFireType <CurrentType>k__BackingField; // 0x14
	WizardGames.Soc.Common.Entity.PlayerEntity Player; // 0x18
	System.Boolean InterruptAdsOn; // 0x20
	System.Boolean SmartFireAdsOff; // 0x21
	System.Boolean DisableByNormalScope; // 0x22
	WizardGames.Soc.Common.Data.SmartFireEnableButton <ActivingSmartFireButton>k__BackingField; // 0x24
	System.Void set_EnabledButton(WizardGames.Soc.Common.Data.SmartFireEnableButton value); // 0x06da4964
	WizardGames.Soc.Common.Data.SmartFireEnableButton get_EnabledButton(); // 0x06da49dc
	WizardGames.Soc.Common.Data.SmartFireType get_CurrentType(); // 0x06da4a40
	System.Void set_CurrentType(WizardGames.Soc.Common.Data.SmartFireType value); // 0x06da4aa4
	System.Void set_ActivingSmartFireButton(WizardGames.Soc.Common.Data.SmartFireEnableButton value); // 0x06da4b1c
	WizardGames.Soc.Common.Data.SmartFireEnableButton get_ActivingSmartFireButton(); // 0x06da4b94
	System.Void .ctor(WizardGames.Soc.Common.Entity.PlayerEntity player); // 0x06da4bf8
	System.Void SetEnabledButton(WizardGames.Soc.Common.Data.SmartFireEnableButton button); // 0x06da4dc8
	System.Void SetSmartFireType(WizardGames.Soc.Common.Data.SmartFireType type); // 0x06da4e90
	System.Boolean OnPressEnter(WizardGames.Soc.Common.Data.SmartFireEnableButton button); // 0x06da4fa4
	System.Boolean OnPressing(WizardGames.Soc.Common.Data.SmartFireEnableButton button); // 0x06da5350
	System.Boolean OnPressLeave(WizardGames.Soc.Common.Data.SmartFireEnableButton button); // 0x054c4f88
	System.Void CancelAdsOn(System.Boolean cancel_smartfire); // 0x06da5894
	System.Void Update(); // 0x055049cc
	System.Void Release(); // 0x06da5b1c
	static System.Void .cctor(); // 0x06da5b88
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.PlayerInteractiveDisplayData : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	System.Int64 EntityID; // 0x20
	System.Int32 NewInteractiveId; // 0x28
	static SocLogger logger; // 0x0
	static WizardGames.Soc.Common.Combat.PlayerInteractiveDisplayData CreateInteractiveDisplayReqeust(System.Int64 hostId, System.Int32 newInteractiveId); // 0x06da5c5c
	System.Void Dispose(); // 0x06da5e4c
	System.Void .ctor(); // 0x06da5ec0
	static System.Void .cctor(); // 0x06da5f28
}

// Client.Runtime
enum WizardGames.Soc.Common.Combat.HitPart : System.Enum
{
	System.SByte value__; // 0x10
	static WizardGames.Soc.Common.Combat.HitPart InValid = -1;
	static WizardGames.Soc.Common.Combat.HitPart Head = 0;
	static WizardGames.Soc.Common.Combat.HitPart UpperBody = 1;
	static WizardGames.Soc.Common.Combat.HitPart LowerBody = 2;
	static WizardGames.Soc.Common.Combat.HitPart Everything = 3;
	static WizardGames.Soc.Common.Combat.HitPart Count = 4;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.Shoot.CurveFormula : System.Object, WizardGames.Soc.Common.Combat.Shoot.IFormula
{
	WizardGames.Soc.Common.Combat.Shoot.CurveFormulaData Data; // 0x10
	System.Single vkTargetValue; // 0x18
	System.Single vkLastValue; // 0x1c
	System.Single vkCurValue; // 0x20
	System.Boolean isRunning; // 0x24
	System.Boolean <Enable>k__BackingField; // 0x25
	System.Void SetFormulas(System.Int32 fireCount, System.Single peakScale); // 0x06da5ffc
	System.Boolean get_Enable(); // 0x06da60f0
	System.Void Start(System.Int32 during, System.Int32 seed); // 0x06da6154
	System.Single GetValue(System.Int32 during); // 0x06da6230
	System.Int32 GetFormulaCycleTime(); // 0x06da65b0
	System.Void Stop(); // 0x06da6654
	System.Void Clear(); // 0x06da66bc
	System.Void .ctor(); // 0x06da6730
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.Shoot.CurveFormulaData : System.Object
{
	System.Single[] vkValues; // 0x10
	System.Single upTime; // 0x18
	System.Single topPauseTime; // 0x1c
	System.Single downTime; // 0x20
	System.String curvePath; // 0x28
	System.UInt64 pathHash; // 0x30
	ViewKickCurve viewKickCurve; // 0x38
	System.Boolean isInit; // 0x40
	System.Single get_BeforeDownTime(); // 0x06da6548
	System.Void InitCurve(); // 0x06da67a0
	System.Void .ctor(); // 0x06da6900
}

// Client.Runtime
interface WizardGames.Soc.Common.Combat.Shoot.IFormula : 
{
	
	System.Void Start(System.Int32 during, System.Int32 seed); // 0x055057d4
	System.Single GetValue(System.Int32 during); // 0x054a5b8c
	System.Int32 GetFormulaCycleTime(); // 0x0548ba98
	System.Void Stop(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.Shoot.FormulaGroup : System.Object, WizardGames.Soc.Common.Combat.Shoot.IFormula
{
	static SocLogger logger; // 0x0
	System.Int32[] _stages; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.Combat.Shoot.Formula.SpringFormulaData>[] _stageFormulaDatas; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.Common.Combat.Shoot.IFormula> _formulas; // 0x20
	System.Int32 _lastStage; // 0x28
	System.Boolean <Enable>k__BackingField; // 0x2c
	System.Void .ctor(); // 0x06da6968
	System.Void SetStage(System.Int32[] stage); // 0x06da6a78
	System.Collections.Generic.List<WizardGames.Soc.Common.Combat.Shoot.Formula.SpringFormulaData> GetFormulaDatasViaStage(System.Int32 stage); // 0x06da6b30
	System.Collections.Generic.List<WizardGames.Soc.Common.Combat.Shoot.Formula.SpringFormulaData> SelectFormulaDatasViaPhase(System.Int32 stage); // 0x06da6d18
	System.Int32 GetStageViaFireCount(System.Int32 fireCount); // 0x06da6db4
	System.Void SetFormulas(System.Int32 fireCount, System.Single peakScale); // 0x06da6e60
	System.Void AddFormula(WizardGames.Soc.Common.Combat.Shoot.IFormula formula); // 0x06da7058
	System.Boolean get_Enable(); // 0x06da714c
	System.Void Start(System.Int32 during, System.Int32 seed); // 0x06da71b0
	System.Single GetValue(System.Int32 time); // 0x06da73f8
	System.Int32 GetFormulaCycleTime(); // 0x06da7658
	System.Void Stop(); // 0x06da78a0
	System.Void Clear(); // 0x06da7a78
	static System.Void .cctor(); // 0x06da7b1c
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.Shoot.MgrShootFormula : System.Object
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Combat.Shoot.SOCViewkickFormula> Formulas; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Combat.Shoot.SOCViewkickFormula> PreFormulas; // 0x18
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Combat.Shoot.GunSpreadParameter> GunSpreadParameters; // 0x20
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewKickFormulaData> ViewKickFormulaDatas; // 0x28
	WizardGames.Soc.Common.Contexts.Context _context; // 0x30
	System.Void .ctor(WizardGames.Soc.Common.Contexts.Context context); // 0x06da7bf0
	System.Void InitSpreadConfigData(); // 0x06da862c
	WizardGames.Soc.Common.Combat.Shoot.GunSpreadParameter GetGunSpreadParameterViaWeaponEntity(WizardGames.Soc.Common.CustomType.WeaponCustom weaponEntity); // 0x06da8a28
	WizardGames.Soc.Common.Combat.Shoot.GunSpreadParameter GetGunSpreadParameterViaSpreadId(System.Int32 spreadId); // 0x06da8ba0
	System.Void InitViewkickConfigData(); // 0x06da8018
	WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewKickFormulaData GetViewKickDataStructViaType(System.Int32 vkType); // 0x06da8d3c
	WizardGames.Soc.Common.Combat.Shoot.SOCViewkickFormula GetFormulaViaId(System.Int64 id, System.Boolean isPre); // 0x06da9278
	System.Void RemoveFormula(System.Int64 entityid); // 0x06da9834
	WizardGames.Soc.Common.Combat.Shoot.SOCViewkickFormula CreateViewkickFormulaViaWeapon(System.Int64 entityId, System.Boolean isPre); // 0x06da9394
	WizardGames.Soc.Common.Combat.Shoot.SOCViewkickFormula CreateViewkickFormula(System.Int32 vkType); // 0x06da99cc
	System.Void SetViewkickData<T>(WizardGames.Soc.Common.Combat.Shoot.FormulaGroup formulaGroup, WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickAxisData axisData); // 0x052af1f0
	System.Void SetViewkickData(WizardGames.Soc.Common.Combat.Shoot.CurveFormula curveFormula, WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickCurveData curveData); // 0x06da9c04
	static System.Void .cctor(); // 0x06da9d3c
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.Shoot.SOCShootFormula : System.Object, WizardGames.Soc.Common.Combat.Shoot.IShootFormula
{
	System.Int32[] primeNumber; // 0x10
	System.Numerics.Vector3 CalculateShootDir(System.Int32 time, System.Int32 deltaTime, System.Int32 seed, WizardGames.Soc.Common.Combat.Shoot.IShootParameter parameter, WizardGames.Soc.Common.Combat.Shoot.IShootState state, System.Single viewYaw, System.Single viewPitch, WizardGames.Soc.Common.Combat.Shoot.IKickFormula formula, System.Int32 index); // 0x06da9e10
	System.Void ShootPreProcess(System.Int32 time, System.Int32 deltaTime, System.Int32 seed, WizardGames.Soc.Common.Combat.Shoot.IShootParameter parameter, WizardGames.Soc.Common.Combat.Shoot.IShootState state, WizardGames.Soc.Common.Combat.Shoot.IKickFormula formula); // 0x06daa26c
	System.Void ShootPostProcess(WizardGames.Soc.Common.Combat.Shoot.GunSpreadParameter parameter, WizardGames.Soc.Common.Combat.Shoot.IShootState state); // 0x06daa7fc
	UnityEngine.Vector3 ToVector3(System.Int32 seed, System.Single pitch, System.Single yaw, System.Single spread, WizardGames.Soc.Common.Combat.Shoot.GunSpreadParameter parameter, System.Boolean isInAds); // 0x06daa04c
	System.Void SpreadViaAverage(System.Int32 seed, System.Single& x, System.Single& y); // 0x06dab17c
	System.Void SpreadViaCLT(System.Int32 seed, WizardGames.Soc.Common.Combat.Shoot.GunSpreadParameter parameter, System.Single& x, System.Single& y); // 0x06daaff8
	System.Single clt(System.Int32 seed, System.Int32 count); // 0x06dab2cc
	System.Void .ctor(); // 0x06dab3fc
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.Shoot.SOCViewkickFormula : WizardGames.Soc.Common.Combat.Shoot.IKickFormula, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	WizardGames.Soc.Common.Combat.Shoot.CurveFormula pitchCurveFormula; // 0x10
	WizardGames.Soc.Common.Combat.Shoot.CurveFormula yawCurveFormula; // 0x18
	WizardGames.Soc.Common.Combat.Shoot.FormulaGroup PitchFormula; // 0x20
	WizardGames.Soc.Common.Combat.Shoot.FormulaGroup YawFormula; // 0x28
	WizardGames.Soc.Common.Combat.Shoot.FormulaGroup RollFormula; // 0x30
	WizardGames.Soc.Common.Combat.Shoot.FormulaGroup TpRollFormula; // 0x38
	System.Int32 CurrentFireTime; // 0x40
	System.Int32 PitchFireCycleEndTime; // 0x44
	System.Boolean PitchRecoilDone; // 0x48
	System.Int32 YawFireCycleEndTime; // 0x4c
	System.Int32 PitchFireCycleTime; // 0x50
	System.Int32 YawFireCycleTime; // 0x54
	System.Boolean YawRecoilDone; // 0x58
	System.Int32 RollFireTime; // 0x5c
	UnityEngine.Vector2 ClearRecoilOffset; // 0x60
	System.Int32 lastFireCount; // 0x68
	static WizardGames.Soc.Common.Combat.Shoot.SOCViewkickFormula GetFormular(); // 0x06da9b70
	static System.Void Release(WizardGames.Soc.Common.Combat.Shoot.SOCViewkickFormula f); // 0x06da991c
	System.Void OnFire(System.Int32 time, System.Int32 seed, System.Int32 fireCount, UnityEngine.Vector3 peakScale); // 0x06daa4e4
	System.Single GetPitchValue(System.Int32 during); // 0x06dab648
	System.Single GetYawValue(System.Int32 during); // 0x06dab6fc
	System.Void StopPitchFormula(); // 0x06dab4b8
	System.Void StopYawFormula(); // 0x06dab540
	System.Int32 GetFireDuring(System.Int32 time); // 0x06dab7b0
	System.Int32 GetRollFireDuring(System.Int32 time); // 0x06dab5c8
	System.Void AddClearRecoilOffset(UnityEngine.Vector2 recoilOffset); // 0x06dab830
	System.Void OnGet(); // 0x06dab8b4
	System.Void OnRelease(); // 0x06dab914
	System.Void OnDestroy(); // 0x06dab9d4
	System.Void .ctor(); // 0x06daba34
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.Shoot.IKickFormula : System.Object
{
	
	System.Void .ctor(); // 0x06dabb8c
}

// Client.Runtime
interface WizardGames.Soc.Common.Combat.Shoot.IShootFormula : 
{
	
	System.Numerics.Vector3 CalculateShootDir(System.Int32 time, System.Int32 deltaTime, System.Int32 seed, WizardGames.Soc.Common.Combat.Shoot.IShootParameter parameter, WizardGames.Soc.Common.Combat.Shoot.IShootState state, System.Single viewYaw, System.Single viewPitch, WizardGames.Soc.Common.Combat.Shoot.IKickFormula kickFormula, System.Int32 index); // 0x054b1224
	System.Void ShootPreProcess(System.Int32 time, System.Int32 deltaTime, System.Int32 seed, WizardGames.Soc.Common.Combat.Shoot.IShootParameter parameter, WizardGames.Soc.Common.Combat.Shoot.IShootState state, WizardGames.Soc.Common.Combat.Shoot.IKickFormula formula); // 0x055061dc
	System.Void ShootPostProcess(WizardGames.Soc.Common.Combat.Shoot.GunSpreadParameter parameter, WizardGames.Soc.Common.Combat.Shoot.IShootState state); // 0x0552af00
}

// Client.Runtime
interface WizardGames.Soc.Common.Combat.Shoot.IShootParameter : 
{
	
	
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.Shoot.GunSpreadParameter : System.Object, WizardGames.Soc.Common.Combat.Shoot.IShootParameter
{
	System.Single Fire; // 0x10
	System.Single MaxSpread; // 0x14
	System.Single Recoil; // 0x18
	System.Single Stand; // 0x1c
	System.Single Moving; // 0x20
	System.Single OnMovingVehicle; // 0x24
	System.Single InAir; // 0x28
	System.Single Sprint; // 0x2c
	System.Single Crouch; // 0x30
	System.Single CrouchMove; // 0x34
	System.Single Rate; // 0x38
	System.Single ASDSpread; // 0x3c
	System.Single ADSFire; // 0x40
	System.Single ADSMaxSpread; // 0x44
	System.Single ADSOnMovingVehicle; // 0x48
	System.Single ADSInAirScale; // 0x4c
	System.Single ADSCrouchScale; // 0x50
	System.Single ADSRunScale; // 0x54
	System.Int32 XTimes; // 0x58
	System.Int32 YTimes; // 0x5c
	System.Single XOffset; // 0x60
	System.Single YOffset; // 0x64
	System.Single AdsSpreadAttenuatePercent; // 0x68
	System.Single CrouchOffset; // 0x6c
	System.Single StandOffset; // 0x70
	System.Void .ctor(); // 0x06da8988
}

// Client.Runtime
interface WizardGames.Soc.Common.Combat.Shoot.IShootState : 
{
	
	System.Int32 get_shotsFired(); // 0x0548ba98
	System.Single get_viewKickPeakScale(); // 0x054a5abc
	System.Single get_spread(); // 0x054a5abc
	System.Single get_shootSpread(); // 0x054a5abc
	System.Void set_shootSpread(System.Single value); // 0x05513724
	System.Single get_ammoSpreadScale(); // 0x054a5abc
	System.Single get_SpreadCorrection(); // 0x054a5abc
	System.Boolean get_IsInAds(); // 0x054c4760
	System.Single get_AdsSpreadScale(); // 0x054a5abc
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewKickFormulaData : System.Object
{
	WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickAxisData Pitch; // 0x10
	WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickAxisData Yaw; // 0x18
	WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickAxisData Roll; // 0x20
	WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickAxisData TpRoll; // 0x28
	WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickCurveData PitchCurveData; // 0x30
	WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickCurveData YawCurveData; // 0x38
	System.Void Handle(WizardGames.Soc.Common.Data.gun.GunViewkick gv); // 0x06da8e44
	System.Void Handle(WizardGames.Soc.Common.Data.gun.GunBaseViewkick gv); // 0x06da8f9c
	System.Void SortOut(); // 0x06da908c
	System.Void .ctor(); // 0x06da911c
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickAxisData : System.Object
{
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickDatas> _stages; // 0x10
	System.Int32[] Stages; // 0x18
	WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickDatas[] ViewkickDatasArray; // 0x20
	System.Void Handle(WizardGames.Soc.Common.Data.gun.GunViewkick gv); // 0x06dabbf4
	System.Void SortOut(); // 0x06dabd84
	WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickDatas GetViewkickDatas(System.Int32 stage); // 0x06dac2d4
	System.Void .ctor(); // 0x06dac1b8
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickAxisData.<>c : System.Object
{
	static WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickAxisData.<>c <>9; // 0x0
	static System.Func<System.Collections.Generic.KeyValuePair<System.Int32,WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickDatas>,System.Int32> <>9__5_0; // 0x8
	static System.Func<System.Collections.Generic.KeyValuePair<System.Int32,WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickDatas>,System.Int32> <>9__5_1; // 0x10
	static System.Func<System.Collections.Generic.KeyValuePair<System.Int32,WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickDatas>,WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickDatas> <>9__5_2; // 0x18
	static System.Void .cctor(); // 0x06dac744
	System.Void .ctor(); // 0x06dac7a8
	System.Int32 <SortOut>b__5_0(System.Collections.Generic.KeyValuePair<System.Int32,WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickDatas> p); // 0x06dac810
	System.Int32 <SortOut>b__5_1(System.Collections.Generic.KeyValuePair<System.Int32,WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickDatas> p); // 0x06dac89c
	WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickDatas <SortOut>b__5_2(System.Collections.Generic.KeyValuePair<System.Int32,WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickDatas> v); // 0x06dac928
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickDatas : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickData> _datas; // 0x10
	WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickData[] <Datas>k__BackingField; // 0x18
	WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickData[] get_Datas(); // 0x06dac9b4
	System.Void set_Datas(WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickData[] value); // 0x06daca18
	System.Void Handle(WizardGames.Soc.Common.Data.gun.GunViewkick gv); // 0x06dac3dc
	System.Void SortOut(); // 0x06dac504
	System.Void .ctor(); // 0x06dac690
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickData : System.Object
{
	WizardGames.Soc.Common.Combat.Shoot.Formula.SpringFormulaData _data; // 0x10
	WizardGames.Soc.Common.Combat.Shoot.Formula.SpringFormulaData get_SpringFormulaData(); // 0x06dacc88
	System.Void Handle(WizardGames.Soc.Common.Data.gun.GunViewkick gv); // 0x06dacb00
	System.Void SortOut(); // 0x06dacc28
	System.Void .ctor(); // 0x06daca98
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.Shoot.Viewkick.ViewkickCurveData : System.Object
{
	WizardGames.Soc.Common.Combat.Shoot.CurveFormulaData _curveData; // 0x10
	WizardGames.Soc.Common.Combat.Shoot.CurveFormulaData get_CurveFormulaData(); // 0x06dacd7c
	System.Void Handle(WizardGames.Soc.Common.Data.gun.GunBaseViewkick gv); // 0x06dabc84
	System.Void .ctor(); // 0x06dac26c
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.Shoot.Formula.InheritSpringFormula : WizardGames.Soc.Common.Combat.Shoot.Formula.SpringFormula
{
	System.Single inheritValue; // 0x44
	System.Void Start(System.Single during, System.Int32 seed); // 0x06dacde0
	System.Void Stop(); // 0x06dacf40
	System.Single GetValue(System.Single during); // 0x06dad010
	System.Void .ctor(); // 0x06dad180
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.Shoot.Formula.SpringFormula : System.Object, WizardGames.Soc.Common.Combat.Shoot.IFormula
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Combat.Shoot.Formula.SpringFormulaData Data; // 0x10
	System.Boolean <Enable>k__BackingField; // 0x18
	System.Single _peak; // 0x1c
	System.Single _cycle; // 0x20
	System.Single _phase; // 0x24
	System.Single _attenuation; // 0x28
	System.Single _attenuationDelayTime; // 0x2c
	System.Single _lifecycle; // 0x30
	System.Single _lifecycleEndRst; // 0x34
	System.Single _zeroReturnTime; // 0x38
	System.Single _formulaCycle; // 0x3c
	System.Boolean isRunning; // 0x40
	System.Boolean get_Enable(); // 0x06dad278
	System.Void Init(System.Int32 seed, WizardGames.Soc.Common.Combat.Shoot.Formula.SpringFormulaData data); // 0x06dad2dc
	System.Void Start(System.Int32 during, System.Int32 seed); // 0x06dad604
	System.Void Stop(); // 0x06dacfac
	System.Single GetValue(System.Int32 during); // 0x06dad6fc
	System.Int32 GetFormulaCycleTime(); // 0x06dad7ec
	System.Void Start(System.Single during, System.Int32 seed); // 0x06dace98
	System.Single GetValue(System.Single during); // 0x06dad0ac
	System.Single GetFormulaCycleTimeMs(); // 0x06dad884
	System.Single GetValue_Internal(System.Single during); // 0x06dad940
	System.Double formulaLifeCycle(System.Single during, System.Double rst); // 0x06dada08
	System.Double getAttenuation(System.Single during); // 0x06dadb50
	System.Double formulaZeroTime(System.Single during, System.Double rst); // 0x06dadbdc
	System.Void .ctor(); // 0x06dad208
	static System.Void .cctor(); // 0x06dadcdc
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.Shoot.Formula.SpringFormulaData : System.Object
{
	System.Boolean isCos; // 0x10
	System.Single peakMax; // 0x14
	System.Single peakMin; // 0x18
	System.Single peakScale; // 0x1c
	System.Boolean isPeakRandomDir; // 0x20
	System.Single cycle; // 0x24
	System.Boolean isCycleRandom; // 0x28
	System.Single cycleMax; // 0x2c
	System.Single cycleMin; // 0x30
	System.Single phase; // 0x34
	System.Boolean isPhaseRandom; // 0x38
	System.Single phaseMax; // 0x3c
	System.Single phaseMin; // 0x40
	System.Single attenuation; // 0x44
	System.Boolean isAttenuationRandom; // 0x48
	System.Single attenuationMax; // 0x4c
	System.Single attenuationMin; // 0x50
	System.Single attenuationDelayTime; // 0x54
	System.Single lifecycleMax; // 0x58
	System.Single lifecycleMin; // 0x5c
	System.Single zeroSpeed; // 0x60
	System.Boolean inherit; // 0x64
	System.Single maxGunKickPeak; // 0x68
	System.Single gunkickCenterX; // 0x6c
	System.Single gunkickCenterY; // 0x70
	System.Single gunkickCenterZ; // 0x74
	System.Boolean isSightLocator; // 0x78
	System.Void .ctor(); // 0x06daccec
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.Shoot.Formula.Viewkick.ViewkickPitchFormula : WizardGames.Soc.Common.Combat.Shoot.Formula.InheritSpringFormula
{
	
	System.Void .ctor(); // 0x06daddb0
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.Shoot.Formula.Viewkick.ViewkickRollFormula : WizardGames.Soc.Common.Combat.Shoot.Formula.SpringFormula
{
	System.Single _halfLifecycle; // 0x44
	System.Single _randomPeakTime; // 0x48
	System.Boolean hasRandomPeak; // 0x4c
	System.Single lifecycle; // 0x50
	System.Single attenuationDelayTime; // 0x54
	System.Single formulaCycle; // 0x58
	System.Boolean _isLoop; // 0x5c
	System.Void Init(System.Int32 seed, WizardGames.Soc.Common.Combat.Shoot.Formula.SpringFormulaData data); // 0x06dade14
	System.Void Start(System.Single during, System.Int32 seed); // 0x06dadebc
	System.Double formulaLifeCycle(System.Single during, System.Double rst); // 0x06dadf9c
	System.Double getAttenuation(System.Single during); // 0x06dae0c8
	System.Single GetFormulaCycleTimeMs(); // 0x06dae15c
	System.Void .ctor(); // 0x06dae218
}

// Client.Runtime
class WizardGames.Soc.Common.Combat.Shoot.Formula.Viewkick.ViewkickYawFormula : WizardGames.Soc.Common.Combat.Shoot.Formula.Viewkick.ViewkickPitchFormula
{
	
	System.Void .ctor(); // 0x06dae2a0
}

// Client.Runtime
enum WizardGames.Soc.Common.Bullet.TrajectoryType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Bullet.TrajectoryType Direct = 0;
	static WizardGames.Soc.Common.Bullet.TrajectoryType Melee = 1;
	static WizardGames.Soc.Common.Bullet.TrajectoryType Line = 2;
	static WizardGames.Soc.Common.Bullet.TrajectoryType Parabola = 3;
	static WizardGames.Soc.Common.Bullet.TrajectoryType Area = 4;
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.FpMaskWeightConfGroup : System.ValueType
{
	System.Int32 mask0; // 0x10
	System.Int32 mask1; // 0x14
	System.Int32 mask2; // 0x18
	System.Int32 mask3; // 0x1c
	System.Int32 mask4; // 0x20
	System.Int32 mask5; // 0x24
	System.Int32 mask6; // 0x28
	System.Int32 mask7; // 0x2c
	System.Int32 mask8; // 0x30
	System.Int32 mask9; // 0x34
	System.Int32 mask10; // 0x38
	System.Int32 mask11; // 0x3c
	System.Int32 mask12; // 0x40
	System.Int32 mask13; // 0x44
	System.Int32 mask14; // 0x48
	System.Int32 mask15; // 0x4c
	System.Int32 mask16; // 0x50
	System.Int32 mask17; // 0x54
	System.Int32 mask18; // 0x58
	System.Int32 mask19; // 0x5c
	System.Int32 mask20; // 0x60
	System.Int32 mask21; // 0x64
	System.Int32 mask22; // 0x68
	System.Int32 mask23; // 0x6c
	System.Int32 mask24; // 0x70
	System.Int32 mask25; // 0x74
	System.Int32 mask26; // 0x78
	System.Int32 mask27; // 0x7c
	System.Int32 mask28; // 0x80
	System.Int32 mask29; // 0x84
	System.Int32 mask30; // 0x88
	static System.Int32 get_Capacity(); // 0x06dae304
	System.Void Set(System.Int32 idx, System.Int32 value); // 0x06dae360
	System.Int32 Get(System.Int32 idx); // 0x06dae478
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.FpMaskWeightFloatGroup : System.ValueType
{
	System.Int32 mask0; // 0x10
	System.Int32 mask1; // 0x14
	System.Int32 mask2; // 0x18
	System.Int32 mask3; // 0x1c
	System.Int32 mask4; // 0x20
	System.Int32 mask5; // 0x24
	System.Int32 mask6; // 0x28
	System.Int32 mask7; // 0x2c
	System.Int32 mask8; // 0x30
	System.Int32 mask9; // 0x34
	System.Int32 mask10; // 0x38
	System.Int32 mask11; // 0x3c
	System.Int32 mask12; // 0x40
	System.Int32 mask13; // 0x44
	System.Int32 mask14; // 0x48
	System.Int32 mask15; // 0x4c
	System.Int32 mask16; // 0x50
	System.Int32 mask17; // 0x54
	System.Int32 mask18; // 0x58
	System.Int32 mask19; // 0x5c
	System.Int32 mask20; // 0x60
	System.Int32 mask21; // 0x64
	System.Int32 mask22; // 0x68
	System.Int32 mask23; // 0x6c
	System.Int32 mask24; // 0x70
	System.Int32 mask25; // 0x74
	System.Int32 mask26; // 0x78
	System.Int32 mask27; // 0x7c
	System.Int32 mask28; // 0x80
	System.Int32 mask29; // 0x84
	System.Int32 mask30; // 0x88
	static System.Int32 get_Capacity(); // 0x06dae57c
	System.Void Set(System.Int32 idx, System.Single value); // 0x06dae5d8
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.FpAniBoneMask : System.ValueType
{
	System.Single BaseLocator; // 0x10
	System.Single CameraLocator; // 0x14
	System.Single Bip01Spine; // 0x18
	System.Single Bip01LClavicle; // 0x1c
	System.Single Bip01Neck; // 0x20
	System.Single Bip01Head; // 0x24
	System.Single Bip01RClavicle; // 0x28
	System.Single BaseWeaponLocator; // 0x2c
	System.Single Bip01LUpperArm; // 0x30
	System.Single Bip01LForearm; // 0x34
	System.Single Bip01LHand; // 0x38
	System.Single Bip01RUpperArm; // 0x3c
	System.Single Bip01RForearm; // 0x40
	System.Single Bip01RHand; // 0x44
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.FpAniHeldItemWeight : System.ValueType
{
	WizardGames.Soc.Common.Character.FpAniBoneMask IdleWeight; // 0x10
	WizardGames.Soc.Common.Character.FpAniBoneMask JogWeight; // 0x48
	WizardGames.Soc.Common.Character.FpAniBoneMask Jog2SprintWeight; // 0x80
	WizardGames.Soc.Common.Character.FpAniBoneMask SprintWeight; // 0xb8
	WizardGames.Soc.Common.Character.FpAniBoneMask JumpWeight; // 0xf0
	WizardGames.Soc.Common.Character.FpAniBoneMask SwimWeight; // 0x128
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.FpMaskWeightRuntimeData : System.ValueType
{
	System.Single MaskTargetWeightFp; // 0x10
	System.Single MaskWeightSpeedFp; // 0x14
	System.Single MaskNowWeightFp; // 0x18
	System.Single MaskWeightTimeFp; // 0x1c
	System.Single MaskOverrideTargetWeightFp; // 0x20
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.FpMaskWeightRuntimeDataGroup : System.ValueType
{
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeDataGroup.DefaultGroup defaultGroup; // 0x10
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeDataGroup.SpineGroup spineGroup; // 0x38
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeDataGroup.LCaviGroup lcaviGroup; // 0x4c
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeDataGroup.HeadGroup headGroup; // 0x60
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeDataGroup.RCaviGroup rcaviGroup; // 0x88
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeDataGroup.WeaponGroup weaponGroup; // 0x9c
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeDataGroup.LeftArmGroup leftArmGroup; // 0xb0
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeDataGroup.RightArmGroup rightArmGroup; // 0xec
	static System.Int32 get_FullCapacity(); // 0x06dae6fc
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeData& Get(System.Int32 idx); // 0x06dae758
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.FpMaskWeightRuntimeDataGroup.DefaultGroup : System.ValueType
{
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeData baseLocator; // 0x10
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeData cameraLocator; // 0x24
	static System.Int32 get_Capacity(); // 0x06dae864
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeData& Get(System.Int32 idx); // 0x06dae8c0
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.FpMaskWeightRuntimeDataGroup.SpineGroup : System.ValueType
{
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeData spine; // 0x10
	static System.Int32 get_Capacity(); // 0x06dae9cc
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeData& Get(System.Int32 idx); // 0x06daea28
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.FpMaskWeightRuntimeDataGroup.LCaviGroup : System.ValueType
{
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeData lClavicle; // 0x10
	static System.Int32 get_Capacity(); // 0x06daeb34
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeData& Get(System.Int32 idx); // 0x06daeb90
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.FpMaskWeightRuntimeDataGroup.HeadGroup : System.ValueType
{
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeData neck; // 0x10
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeData head; // 0x24
	static System.Int32 get_Capacity(); // 0x06daec9c
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeData& Get(System.Int32 idx); // 0x06daecf8
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.FpMaskWeightRuntimeDataGroup.RCaviGroup : System.ValueType
{
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeData rClavicle; // 0x10
	static System.Int32 get_Capacity(); // 0x06daee04
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeData& Get(System.Int32 idx); // 0x06daee60
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.FpMaskWeightRuntimeDataGroup.WeaponGroup : System.ValueType
{
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeData baseWeaponLocator; // 0x10
	static System.Int32 get_Capacity(); // 0x06daef6c
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeData& Get(System.Int32 idx); // 0x06daefc8
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.FpMaskWeightRuntimeDataGroup.LeftArmGroup : System.ValueType
{
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeData lUpperArm; // 0x10
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeData lForearm; // 0x24
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeData lHand; // 0x38
	static System.Int32 get_Capacity(); // 0x06daf0d4
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeData& Get(System.Int32 idx); // 0x06daf130
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.FpMaskWeightRuntimeDataGroup.RightArmGroup : System.ValueType
{
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeData rUpperArm; // 0x10
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeData rForearm; // 0x24
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeData rHand; // 0x38
	static System.Int32 get_Capacity(); // 0x06daf23c
	WizardGames.Soc.Common.Character.FpMaskWeightRuntimeData& Get(System.Int32 idx); // 0x06daf298
}

// Client.Runtime
interface WizardGames.Soc.Common.Character.IAnimSpeedData : 
{
	
	System.Single get_SpeedX(); // 0x054a5abc
	System.Single get_SpeedY(); // 0x054a5abc
	System.Single get_SpeedZ(); // 0x054a5abc
	System.Single get_RotateY(); // 0x054a5abc
	WizardGames.Soc.Common.Entity.PlayerMoveStateEnum get_MoveState(); // 0x054c4760
	WizardGames.Soc.Common.Entity.PlayerPoseStateEnum get_PoseState(); // 0x054c4760
	WizardGames.Soc.Common.Entity.PlayerMoveLadderStateEnum get_MoveLadderState(); // 0x054c4760
	WizardGames.Soc.Common.Entity.PlayerUnAliveStateEnum get_UnAliveState(); // 0x054c4760
	WizardGames.Soc.Common.Entity.PlayerActionStateEnum get_ActionState(); // 0x054c4760
}

// Client.Runtime
enum WizardGames.Soc.Common.Character.ETpDebugBoneGroup : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Character.ETpDebugBoneGroup None = 0;
	static WizardGames.Soc.Common.Character.ETpDebugBoneGroup Group = 1;
	static WizardGames.Soc.Common.Character.ETpDebugBoneGroup Spine = 2;
	static WizardGames.Soc.Common.Character.ETpDebugBoneGroup LeftClav = 3;
	static WizardGames.Soc.Common.Character.ETpDebugBoneGroup RightClav = 4;
	static WizardGames.Soc.Common.Character.ETpDebugBoneGroup Head = 5;
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpAniPlayerDebugBone : System.ValueType
{
	Unity.Collections.FixedString64Bytes BoneName; // 0x10
	System.Int32 BonePathHash; // 0x50
	System.Single Weight; // 0x54
	WizardGames.Soc.Common.Character.ETpDebugBoneGroup Group; // 0x58
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpAniPlayerStateData : System.ValueType, WizardGames.Soc.Common.Character.IAnimSpeedData
{
	WizardGames.Soc.Common.Entity.PlayerPoseStateEnum <PoseState>k__BackingField; // 0x10
	WizardGames.Soc.Common.Entity.PlayerMoveStateEnum <MoveState>k__BackingField; // 0x11
	WizardGames.Soc.Common.Entity.PlayerUnAliveStateEnum <UnAliveState>k__BackingField; // 0x12
	WizardGames.Soc.Common.Entity.PlayerMoveLadderStateEnum <MoveLadderState>k__BackingField; // 0x13
	WizardGames.Soc.Common.Entity.PlayerActionStateEnum <ActionState>k__BackingField; // 0x14
	WizardGames.Soc.Common.Entity.PlayerMoveJumpStateEnum MoveJumpState; // 0x15
	WizardGames.Soc.Common.Entity.PlayerMoveSwimStateEnum MoveSwimState; // 0x16
	WizardGames.Soc.Common.Entity.PlayerActionStateReloadEnum ReloadState; // 0x17
	WizardGames.Soc.Common.Entity.PlayerAttackStateEnum AttackSubState; // 0x18
	WizardGames.Soc.Common.Entity.PlayerThrowState ThrowState; // 0x19
	WizardGames.Soc.Common.Entity.PlayerBowStateEnum BowState; // 0x1a
	WizardGames.Soc.Common.Entity.PlayerAdsStateEnum AdsState; // 0x1b
	WizardGames.Soc.Common.Entity.PlayerActionHoldStateEnum ActionHoldState; // 0x1c
	WizardGames.Soc.Common.Entity.PlayerPoseDyingStateEnum PoseDyingState; // 0x1d
	WizardGames.Soc.Common.Entity.PlayerMoveZiplineStateEnum MoveZiplineState; // 0x1e
	System.Int32 LadderMoveFlag; // 0x20
	WizardGames.Soc.Common.State.Character.LadderTestDir LadderEnterDir; // 0x24
	WizardGames.Soc.Common.State.Character.LadderTestDir LadderExitDir; // 0x28
	System.Boolean YawEnable; // 0x2c
	System.Int32 AnimMoveTime; // 0x30
	System.Int32 AnimTurnTime; // 0x34
	System.Int32 AnimRMTotalTime; // 0x38
	System.Int32 AnimSpeed; // 0x3c
	System.Single RootMotionSpeed; // 0x40
	Unity.Mathematics.quaternion LadderMoveQuat; // 0x44
	Unity.Mathematics.quaternion LadderQuat; // 0x54
	Unity.Mathematics.float3 LadderNormal; // 0x64
	Unity.Mathematics.float3 LadderForward; // 0x70
	Unity.Mathematics.float3 LadderRight; // 0x7c
	System.Boolean Disable2JumpLoop; // 0x88
	System.Single GestureIndex; // 0x8c
	System.Int64 MountableId; // 0x90
	System.Int32 VehicleType; // 0x98
	System.Int32 MountableType; // 0x9c
	System.Boolean IsDriver; // 0xa0
	System.Single <RotateY>k__BackingField; // 0xa4
	System.Single ViewYaw; // 0xa8
	System.Single CCHeight; // 0xac
	System.Single LastViewYaw; // 0xb0
	System.Single AdsOffsetProgress; // 0xb4
	System.Int64 CurrentWeaponId; // 0xb8
	System.Int32 Movement8Direction; // 0xc0
	System.Int32 Movement4Direction; // 0xc4
	System.Int32 RootMotionWarpingIndex; // 0xc8
	System.Boolean RootMotionRefresh; // 0xcc
	System.Boolean InputSprint; // 0xcd
	System.Single <SpeedX>k__BackingField; // 0xd0
	System.Single <SpeedZ>k__BackingField; // 0xd4
	System.Single <SpeedY>k__BackingField; // 0xd8
	System.Int64 PlayerEntityId; // 0xe0
	System.Int32 StateRecoveryReason; // 0xe8
	System.Boolean TryFire; // 0xec
	System.Single CmdPitch; // 0xf0
	System.Int32 AttackHitMat; // 0xf4
	System.Int32 UseHitIndex; // 0xf8
	System.Single MantleOnPlayRate; // 0xfc
	System.Int32 rmCurTime; // 0x100
	System.Single warmupProgress; // 0x104
	System.Int32 warmupAnimType; // 0x108
	System.Boolean InSkyDiving; // 0x10c
	System.Boolean IsDead; // 0x10d
	System.Single AimYaw; // 0x110
	System.Single InteractiveStateTime; // 0x114
	System.Boolean IsTp; // 0x118
	System.Boolean IsSelfAiding; // 0x119
	WizardGames.Soc.Common.Entity.PlayerPoseStateEnum get_PoseState(); // 0x06daf3a4
	System.Void set_PoseState(WizardGames.Soc.Common.Entity.PlayerPoseStateEnum value); // 0x06daf408
	WizardGames.Soc.Common.Entity.PlayerMoveStateEnum get_MoveState(); // 0x06daf480
	System.Void set_MoveState(WizardGames.Soc.Common.Entity.PlayerMoveStateEnum value); // 0x06daf4e4
	WizardGames.Soc.Common.Entity.PlayerUnAliveStateEnum get_UnAliveState(); // 0x06daf55c
	System.Void set_UnAliveState(WizardGames.Soc.Common.Entity.PlayerUnAliveStateEnum value); // 0x06daf5c0
	WizardGames.Soc.Common.Entity.PlayerMoveLadderStateEnum get_MoveLadderState(); // 0x06daf638
	System.Void set_MoveLadderState(WizardGames.Soc.Common.Entity.PlayerMoveLadderStateEnum value); // 0x06daf69c
	WizardGames.Soc.Common.Entity.PlayerActionStateEnum get_ActionState(); // 0x06daf714
	System.Void set_ActionState(WizardGames.Soc.Common.Entity.PlayerActionStateEnum value); // 0x06daf778
	System.Single get_RotateY(); // 0x06daf7f0
	System.Void set_RotateY(System.Single value); // 0x06daf854
	System.Single get_SpeedX(); // 0x06daf8cc
	System.Void set_SpeedX(System.Single value); // 0x06daf930
	System.Single get_SpeedZ(); // 0x06daf9a8
	System.Void set_SpeedZ(System.Single value); // 0x06dafa0c
	System.Single get_SpeedY(); // 0x06dafa84
	System.Void set_SpeedY(System.Single value); // 0x06dafae8
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpAniHeldItemData : System.ValueType
{
	System.Int64 CurrentWeaponTableId; // 0x10
	System.Int32 CurrentTableItemEnum; // 0x18
	WizardGames.Soc.Common.Data.DataItem.ItemEntityType CurrentTableItemType; // 0x1c
	System.Boolean DisplayOnLadder; // 0x20
	System.Int64 ItemLeftEntityId; // 0x28
	WizardGames.Soc.Common.Weapon.EquipType EquipType; // 0x30
	System.Int32 SlingSort; // 0x34
	System.Single MeleeAttackTime; // 0x38
	System.Int32 MeleeAttackIndex; // 0x3c
	System.Boolean FarThrow; // 0x40
	System.Boolean CanPlayHitAnim; // 0x41
	System.Boolean IsWarmupWeapon; // 0x42
	WizardGames.Soc.Common.Const.EHeldSocketType HoldType; // 0x44
	WizardGames.Soc.Common.Character.FpMetaData FpMetaData; // 0x48
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpAniBoneMask : System.ValueType
{
	System.Single Bip01; // 0x10
	System.Single Bip01Pelvis; // 0x14
	System.Single Bip01LThigh; // 0x18
	System.Single Bip01LCalf; // 0x1c
	System.Single Bip01RThigh; // 0x20
	System.Single Bip01RCalf; // 0x24
	System.Single Bip01Spine; // 0x28
	System.Single Bip01Spine1; // 0x2c
	System.Single Bip01Spine2; // 0x30
	System.Single Bip01LClavicle; // 0x34
	System.Single Bip01Neck; // 0x38
	System.Single Bip01Head; // 0x3c
	System.Single Bip01RClavicle; // 0x40
	System.Single BaseWeaponLocator; // 0x44
	System.Single Bip01LUpperArm; // 0x48
	System.Single Bip01LForearm; // 0x4c
	System.Single Bip01LHand; // 0x50
	System.Single Bip01RUpperArm; // 0x54
	System.Single Bip01RForearm; // 0x58
	System.Single Bip01RHand; // 0x5c
	static System.Int32 get_Capacity(); // 0x06dafb60
	System.Void Set(System.Int32 idx, System.Single value); // 0x06dafbbc
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpOcAniBoneCurveMask : System.ValueType
{
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01; // 0x10
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01Pelvis; // 0x28
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01LThigh; // 0x40
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01LCalf; // 0x58
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01RThigh; // 0x70
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01RCalf; // 0x88
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01Spine; // 0xa0
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01Spine1; // 0xb8
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01Spine2; // 0xd0
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01LClavicle; // 0xe8
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01Neck; // 0x100
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01Head; // 0x118
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01RClavicle; // 0x130
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy BaseWeaponLocator; // 0x148
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01LUpperArm; // 0x160
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01LForearm; // 0x178
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01LHand; // 0x190
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01RUpperArm; // 0x1a8
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01RForearm; // 0x1c0
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01RHand; // 0x1d8
	static System.Int32 get_Capacity(); // 0x06dafce0
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy& Get(System.Int32 index); // 0x06dafd3c
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpAoAniBoneCurveMask : System.ValueType
{
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01; // 0x10
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01Pelvis; // 0x28
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01LThigh; // 0x40
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01LCalf; // 0x58
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01RThigh; // 0x70
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01RCalf; // 0x88
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01Spine; // 0xa0
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01Spine1; // 0xb8
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01Spine2; // 0xd0
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01Neck; // 0xe8
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01Head; // 0x100
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01LClavicle; // 0x118
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01LUpperArm; // 0x130
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01LForearm; // 0x148
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01LHand; // 0x160
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01RClavicle; // 0x178
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy BaseWeaponLocator; // 0x190
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01RUpperArm; // 0x1a8
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01RForearm; // 0x1c0
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Bip01RHand; // 0x1d8
	static System.Int32 get_Capacity(); // 0x06dafe48
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy& Get(System.Int32 index); // 0x06dafea4
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.ClipMetaData : System.ValueType
{
	System.Int32 ClipNameHash; // 0x10
	System.Single AnimationTime; // 0x14
	System.Single AnimatorStateTime; // 0x18
	System.Single RecoveryPercentage; // 0x1c
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.FpMetaData : System.ValueType
{
	WizardGames.Soc.Common.Character.ClipMetaData DrawClipMetaData; // 0x10
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpClipLengthCollect : System.ValueType
{
	System.Boolean Init; // 0x10
	WizardGames.Soc.Common.Character.TpClipLength NowState; // 0x14
	WizardGames.Soc.Common.Character.TpClipLength LastState; // 0x34
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpClipLength : System.ValueType
{
	WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EOverrideLayer State; // 0x10
	WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer LocState; // 0x14
	System.Single AniTime; // 0x18
	System.Single NowTime; // 0x1c
	System.Boolean Start; // 0x20
	System.Single Percent; // 0x24
	System.Single PlayRate; // 0x28
	System.Boolean IsLoop; // 0x2c
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpVehicleSeatTbData : System.ValueType
{
	System.Boolean SeatTbIsOmnidirectional; // 0x10
	System.Single SeatTbFrontOverlapLeft; // 0x14
	System.Single SeatTbFrontOverlapRight; // 0x18
	System.Single SeatTbBackOverlapLeft; // 0x1c
	System.Single SeatTbBackOverlapRight; // 0x20
	System.Single SeatTbFrontAnimOverlapLeft; // 0x24
	System.Single SeatTbFrontAnimOverlapRight; // 0x28
	System.Single YawLeft; // 0x2c
	System.Single YawRight; // 0x30
	System.Single AnimYawLeft; // 0x34
	System.Single AnimYawRight; // 0x38
	WizardGames.Soc.Common.Data.LowerSeatPoseType LowerSeatPoseType; // 0x3c
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpAniVehicleData : System.ValueType
{
	System.Int32 SeatStyleType; // 0x10
	WizardGames.Soc.Common.Character.TpVehicleSeatTbData VehicleSeatTbData; // 0x14
	System.Single HorseVertical; // 0x44
	System.Single HorseHorizontal; // 0x48
	System.Single HorseLocomotionMultiplier; // 0x4c
	System.Single Slope; // 0x50
	System.Boolean HaveHorseData; // 0x54
	System.Single HorseLocomotionNormalizedTime; // 0x58
	System.Single SteerAngle; // 0x5c
	System.Int32 HorseAniType; // 0x60
	System.Int32 HorseJumpIndex; // 0x64
	System.Int32 HorseJumpType; // 0x68
	System.Int32 ParachuteState; // 0x6c
	System.Single ParachuteMoveSpeed; // 0x70
	System.Single ParachuteRotateSpeed; // 0x74
	System.Single MountableGoRotateY; // 0x78
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData : System.ValueType
{
	System.Single MaskTargetWeightTp; // 0x10
	System.Single MaskWeightSpeedTp; // 0x14
	System.Single MaskNowWeightTp; // 0x18
	System.Single MaskWeightTimeTp; // 0x1c
	System.Single MaskOverrideTargetWeightTp; // 0x20
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpMaskWeightFloatGroup : System.ValueType
{
	System.Single mask0; // 0x10
	System.Single mask1; // 0x14
	System.Single mask2; // 0x18
	System.Single mask3; // 0x1c
	System.Single mask4; // 0x20
	System.Single mask5; // 0x24
	System.Single mask6; // 0x28
	System.Single mask7; // 0x2c
	System.Single mask8; // 0x30
	System.Single mask9; // 0x34
	System.Single mask10; // 0x38
	System.Single mask11; // 0x3c
	System.Single mask12; // 0x40
	System.Single mask13; // 0x44
	System.Single mask14; // 0x48
	System.Single mask15; // 0x4c
	System.Single mask16; // 0x50
	System.Single mask17; // 0x54
	System.Single mask18; // 0x58
	System.Single mask19; // 0x5c
	System.Single mask20; // 0x60
	System.Single mask21; // 0x64
	System.Single mask22; // 0x68
	System.Single mask23; // 0x6c
	System.Single mask24; // 0x70
	System.Single mask25; // 0x74
	System.Single mask26; // 0x78
	System.Single mask27; // 0x7c
	System.Single mask28; // 0x80
	System.Single mask29; // 0x84
	System.Single mask30; // 0x88
	System.Single mask31; // 0x8c
	System.Single mask32; // 0x90
	System.Single mask33; // 0x94
	System.Single mask34; // 0x98
	System.Single mask35; // 0x9c
	System.Single mask36; // 0xa0
	System.Single mask37; // 0xa4
	static System.Int32 get_Capacity(); // 0x06daffb0
	System.Void Set(System.Int32 idx, System.Single value); // 0x06db000c
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpMaskWeightConfGroup : System.ValueType
{
	System.Int32 mask0; // 0x10
	System.Int32 mask1; // 0x14
	System.Int32 mask2; // 0x18
	System.Int32 mask3; // 0x1c
	System.Int32 mask4; // 0x20
	System.Int32 mask5; // 0x24
	System.Int32 mask6; // 0x28
	System.Int32 mask7; // 0x2c
	System.Int32 mask8; // 0x30
	System.Int32 mask9; // 0x34
	System.Int32 mask10; // 0x38
	System.Int32 mask11; // 0x3c
	System.Int32 mask12; // 0x40
	System.Int32 mask13; // 0x44
	System.Int32 mask14; // 0x48
	System.Int32 mask15; // 0x4c
	System.Int32 mask16; // 0x50
	System.Int32 mask17; // 0x54
	System.Int32 mask18; // 0x58
	System.Int32 mask19; // 0x5c
	System.Int32 mask20; // 0x60
	System.Int32 mask21; // 0x64
	System.Int32 mask22; // 0x68
	System.Int32 mask23; // 0x6c
	System.Int32 mask24; // 0x70
	System.Int32 mask25; // 0x74
	System.Int32 mask26; // 0x78
	System.Int32 mask27; // 0x7c
	System.Int32 mask28; // 0x80
	System.Int32 mask29; // 0x84
	System.Int32 mask30; // 0x88
	System.Int32 mask31; // 0x8c
	System.Int32 mask32; // 0x90
	System.Int32 mask33; // 0x94
	System.Int32 mask34; // 0x98
	System.Int32 mask35; // 0x9c
	System.Int32 mask36; // 0xa0
	System.Int32 mask37; // 0xa4
	static System.Int32 get_Capacity(); // 0x06db0130
	System.Void Set(System.Int32 idx, System.Int32 value); // 0x06db018c
	System.Int32 Get(System.Int32 idx); // 0x06db02a4
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup : System.ValueType
{
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup.DefaultGroup defaultGroup; // 0x10
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup.SpineGroup spineGroup; // 0x88
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup.Spine1Group spine1Group; // 0x9c
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup.Spine2Group spine2Group; // 0xb0
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup.LCaviGroup lcaviGroup; // 0xc4
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup.HeadGroup headGroup; // 0xd8
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup.RCaviGroup rcaviGroup; // 0x100
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup.WeaponGroup weaponGroup; // 0x114
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup.LeftArmGroup leftArmGroup; // 0x128
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup.RightArmGroup rightArmGroup; // 0x164
	static System.Int32 get_FullCapacity(); // 0x06db03a8
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData& Get(System.Int32 idx); // 0x06db0404
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup.DefaultGroup : System.ValueType
{
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData bip01; // 0x10
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData bip01Pelvis; // 0x24
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData lThigh; // 0x38
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData lCalf; // 0x4c
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData rThigh; // 0x60
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData rCalf; // 0x74
	static System.Int32 get_Capacity(); // 0x06db0510
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData& Get(System.Int32 idx); // 0x06db056c
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup.SpineGroup : System.ValueType
{
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData spine; // 0x10
	static System.Int32 get_Capacity(); // 0x06db0678
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData& Get(System.Int32 idx); // 0x06db06d4
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup.Spine1Group : System.ValueType
{
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData spine1; // 0x10
	static System.Int32 get_Capacity(); // 0x06db07e0
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData& Get(System.Int32 idx); // 0x06db083c
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup.Spine2Group : System.ValueType
{
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData spine2; // 0x10
	static System.Int32 get_Capacity(); // 0x06db0948
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData& Get(System.Int32 idx); // 0x06db09a4
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup.LCaviGroup : System.ValueType
{
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData lClavicle; // 0x10
	static System.Int32 get_Capacity(); // 0x06db0ab0
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData& Get(System.Int32 idx); // 0x06db0b0c
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup.HeadGroup : System.ValueType
{
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData neck; // 0x10
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData head; // 0x24
	static System.Int32 get_Capacity(); // 0x06db0c18
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData& Get(System.Int32 idx); // 0x06db0c74
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup.RCaviGroup : System.ValueType
{
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData rClavicle; // 0x10
	static System.Int32 get_Capacity(); // 0x06db0d80
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData& Get(System.Int32 idx); // 0x06db0ddc
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup.WeaponGroup : System.ValueType
{
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData baseWeaponLocator; // 0x10
	static System.Int32 get_Capacity(); // 0x06db0ee8
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData& Get(System.Int32 idx); // 0x06db0f44
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup.LeftArmGroup : System.ValueType
{
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData lUpperArm; // 0x10
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData lForearm; // 0x24
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData lHand; // 0x38
	static System.Int32 get_Capacity(); // 0x06db1050
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData& Get(System.Int32 idx); // 0x06db10ac
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup.RightArmGroup : System.ValueType
{
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData rUpperArm; // 0x10
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData rForearm; // 0x24
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData rHand; // 0x38
	static System.Int32 get_Capacity(); // 0x06db11b8
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData& Get(System.Int32 idx); // 0x06db1214
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpAoMaskWeightRuntimeDataGroup : System.ValueType
{
	WizardGames.Soc.Common.Character.TpAoMaskWeightRuntimeDataGroup.DefaultGroup defaultGroup; // 0x10
	WizardGames.Soc.Common.Character.TpAoMaskWeightRuntimeDataGroup.SpineGroup spineGroup; // 0x88
	WizardGames.Soc.Common.Character.TpAoMaskWeightRuntimeDataGroup.Spine1Group spine1Group; // 0x9c
	WizardGames.Soc.Common.Character.TpAoMaskWeightRuntimeDataGroup.Spine2Group spine2Group; // 0xb0
	WizardGames.Soc.Common.Character.TpAoMaskWeightRuntimeDataGroup.HeadGroup headGroup; // 0xc4
	WizardGames.Soc.Common.Character.TpAoMaskWeightRuntimeDataGroup.Hand handGroup; // 0xec
	static System.Int32 get_FullCapacity(); // 0x06db1320
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData& Get(System.Int32 idx); // 0x06db137c
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpAoMaskWeightRuntimeDataGroup.DefaultGroup : System.ValueType
{
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData bip01; // 0x10
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData bip01Pelvis; // 0x24
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData lThigh; // 0x38
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData lCalf; // 0x4c
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData rThigh; // 0x60
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData rCalf; // 0x74
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpAoMaskWeightRuntimeDataGroup.SpineGroup : System.ValueType
{
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData spine; // 0x10
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpAoMaskWeightRuntimeDataGroup.Spine1Group : System.ValueType
{
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData spine1; // 0x10
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpAoMaskWeightRuntimeDataGroup.Spine2Group : System.ValueType
{
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData spine2; // 0x10
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpAoMaskWeightRuntimeDataGroup.HeadGroup : System.ValueType
{
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData neck; // 0x10
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData head; // 0x24
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpAoMaskWeightRuntimeDataGroup.Hand : System.ValueType
{
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData lClavicle; // 0x10
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData lUpperArm; // 0x24
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData lForearm; // 0x38
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData lHand; // 0x4c
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData rClavicle; // 0x60
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData baseWeaponLocator; // 0x74
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData rUpperArm; // 0x88
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData rForearm; // 0x9c
	WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData rHand; // 0xb0
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpAniOverrideLayerWeight : System.ValueType, System.IDisposable
{
	WizardGames.Soc.Common.Character.TpOcAniBoneCurveMask IdleStandWeightCurve; // 0x10
	WizardGames.Soc.Common.Character.TpOcAniBoneCurveMask IdleCrouchWeightCurve; // 0x1f0
	WizardGames.Soc.Common.Character.TpOcAniBoneCurveMask JogStandWeightCurve; // 0x3d0
	WizardGames.Soc.Common.Character.TpOcAniBoneCurveMask JogCrouchWeightCurve; // 0x5b0
	WizardGames.Soc.Common.Character.TpOcAniBoneCurveMask SprintWeightCurve; // 0x790
	WizardGames.Soc.Common.Character.TpOcAniBoneCurveMask JumpWeightCurve; // 0x970
	WizardGames.Soc.Common.Character.TpOcAniBoneCurveMask SwimIdleWeightCurve; // 0xb50
	WizardGames.Soc.Common.Character.TpOcAniBoneCurveMask SwimJogWeightCurve; // 0xd30
	WizardGames.Soc.Common.Character.TpOcAniBoneCurveMask SwimSprintWeightCurve; // 0xf10
	WizardGames.Soc.Common.Character.TpOcAniBoneCurveMask LadderWeightCurve; // 0x10f0
	WizardGames.Soc.Common.Character.TpOcAniBoneCurveMask HorseWeightCurve; // 0x12d0
	WizardGames.Soc.Common.Character.TpOcAniBoneCurveMask VehicleWeightCurve; // 0x14b0
	System.Void Dispose(); // 0x06db1488
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpAniActionToLocoLayerWeight : System.ValueType
{
	WizardGames.Soc.Common.Character.TpOcAniBoneCurveMask IdleCrouchWeightCurve; // 0x10
	WizardGames.Soc.Common.Character.TpOcAniBoneCurveMask JogWeightCurve; // 0x1f0
	WizardGames.Soc.Common.Character.TpOcAniBoneCurveMask SprintWeightCurve; // 0x3d0
	WizardGames.Soc.Common.Character.TpOcAniBoneCurveMask JumpWeightCurve; // 0x5b0
	WizardGames.Soc.Common.Character.TpOcAniBoneCurveMask SwimIdleWeightCurve; // 0x790
	WizardGames.Soc.Common.Character.TpOcAniBoneCurveMask SwimMoveWeightCurve; // 0x970
	WizardGames.Soc.Common.Character.TpOcAniBoneCurveMask LadderWeightCurve; // 0xb50
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.TpAniActionToAoLayerWeight : System.ValueType
{
	WizardGames.Soc.Common.Character.TpAoAniBoneCurveMask WeightCurve; // 0x10
	WizardGames.Soc.Common.Character.TpAoAniBoneCurveMask HorseWeightCurve; // 0x1f0
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.HorseRMData : System.ValueType
{
	System.Int32 AnimatorInstanceId; // 0x10
	System.Single DeltaTime; // 0x14
	System.Int32 CmdSequence; // 0x18
	System.Single Slope; // 0x1c
	System.Single Horizontal; // 0x20
	System.Single Vertical; // 0x24
	System.Single StateFloat; // 0x28
	System.Single SpeedMultiplier; // 0x2c
	System.Int32 State; // 0x30
	System.Int32 Mode; // 0x34
	System.Int32 LastState; // 0x38
	System.Int32 LastMode; // 0x3c
	System.Boolean StateOn; // 0x40
	System.Boolean ModeOn; // 0x41
	System.Int32 ModeStatus; // 0x44
	System.Single DeadType; // 0x48
	WizardGames.Soc.Common.Character.StateRuntimeData AniStateData; // 0x50
	WizardGames.Soc.Common.Character.StateRuntimeData[] AniStateDetailData; // 0x80
	WizardGames.Soc.Common.Character.GraphLogicParams[] AniGraphLogicParams; // 0x88
	WizardGames.Soc.Common.Character.StateRuntimeData ModeStateData; // 0x90
	WizardGames.Soc.Common.Character.StateRuntimeData[] ModeStateDetailData; // 0xc0
	WizardGames.Soc.Common.Character.GraphLogicParams[] ModeGraphLogicParams; // 0xc8
	System.Single[] AvatarRot; // 0xd0
	WizardGames.Soc.Common.Character.RootMotionResult ResultData; // 0xd8
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.RootMotionResult : System.ValueType
{
	System.Single[] DeltaPos; // 0x10
	System.Single[] DeltaRot; // 0x18
	System.Single[] RootPos; // 0x20
	System.Single[] RootRot; // 0x28
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.GraphLogicParams : System.ValueType
{
	System.Boolean FirstEnter; // 0x10
	System.Boolean DoTransition; // 0x11
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.StateRuntimeData : System.ValueType
{
	System.Int32 NowState; // 0x10
	System.Int32 NowStateHashTag; // 0x14
	System.Int32 PrevState; // 0x18
	System.Single[] StateWeights; // 0x20
	System.Single[] NowTime; // 0x28
	System.Single[] PrevTime; // 0x30
	WizardGames.Soc.Common.Character.BlendTreeInfo[] BlendData; // 0x38
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Character.BlendTreeInfo : System.ValueType
{
	System.Single StateDuration; // 0x10
	System.Single[] BlendWeights; // 0x18
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Character.ESafeAreaType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Character.ESafeAreaType Inside = 0;
	static WizardGames.Soc.Common.Character.ESafeAreaType Between = 1;
	static WizardGames.Soc.Common.Character.ESafeAreaType Outside = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Algorithm.ByteStack : System.Object
{
	System.UInt64 <State>k__BackingField; // 0x10
	System.UInt64 get_State(); // 0x06db14e8
	System.Void set_State(System.UInt64 value); // 0x06db154c
	System.Void .ctor(System.UInt64 s); // 0x06db15c4
	System.Nullable<System.Byte> Pop(); // 0x06db167c
}

// Client.Runtime
class WizardGames.Soc.Common.Algorithm.CustomVectorExt : System.Object
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.Common.SimpleCustom.SimpleVector3 ToSimpleV3(WizardGames.Soc.Common.Algorithm.Vector3 v3); // 0x06db17fc
	static System.Void .cctor(); // 0x06db1920
}

// Client.Runtime
class WizardGames.Soc.Common.AirDrop.AirDropBoxCollider : UnityEngine.MonoBehaviour
{
	WizardGames.Soc.Common.Unity.Go.BaseBoxGo go; // 0x30
	System.Void Init(WizardGames.Soc.Common.Unity.Go.BaseBoxGo boxGo); // 0x06db19f4
	System.Void OnCollisionEnter(UnityEngine.Collision collision); // 0x06db1a74
	System.Void .ctor(); // 0x06db1b18
}

// Client.Runtime
enum WizardGames.Soc.Common.Runtime.MapLoadType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Runtime.MapLoadType Normal = 0;
	static WizardGames.Soc.Common.Runtime.MapLoadType Debug = 1;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Runtime.RuntimeEnvironment : System.Object
{
	static System.Int32 CurrentRuntimeEnvironment; // 0x0
	static WizardGames.Soc.Common.Runtime.MapLoadType CurrentMapLoadType; // 0x4
	static WizardGames.Soc.Common.Framework.Network.Endpoint CurrentEndPoint; // 0x8
	static System.Boolean IsLocalNet; // 0xc
	
}

// Client.Runtime
class WizardGames.Soc.Common.Runtime.Level.SocNavMeshObstacle : UnityEngine.MonoBehaviour
{
	SocLogger logger; // 0x30
	UnityEngine.AI.NavMeshObstacleShape Shape; // 0x38
	UnityEngine.Vector3 Center; // 0x3c
	UnityEngine.Vector3 Size; // 0x48
	System.Single Radius; // 0x54
	System.Single Height; // 0x58
	System.Boolean Carving; // 0x5c
	System.Boolean CarveOnlyStationary; // 0x5d
	System.Single CarvingMoveThreshold; // 0x60
	System.Single CarvingTimeToStationary; // 0x64
	System.Boolean IsStatic; // 0x68
	WizardGames.Soc.Common.Entity.IEntity ownerEntity; // 0x70
	WizardGames.Soc.Common.Unity.Go.IEntityGo ownerEntityGo; // 0x78
	UnityEngine.AI.NavMeshObstacle m_NavMeshObstacle; // 0x80
	WizardGames.Soc.Common.Entity.IEntity get_OwnerEntity(); // 0x06db1b80
	UnityEngine.Vector3 get_WorldCenter(); // 0x06db1be4
	System.Single get_WorldRadius(); // 0x06db1cb8
	System.Single get_WorldHeight(); // 0x06db1d1c
	System.Void Refresh(WizardGames.Soc.Common.Entity.IEntity entity, WizardGames.Soc.Common.Unity.Go.IEntityGo entityGo); // 0x06db1d80
	System.Boolean IsMoving(); // 0x06db2074
	System.Void Clear(); // 0x06db214c
	System.Void UpdateObstacleStatus(System.Boolean newState); // 0x06db21d4
	System.Void CopyObstacleProperty(System.Boolean newState); // 0x06db1f08
	System.Boolean IsEnabled(); // 0x06db22c8
	System.Void ForceUpdate(); // 0x06db2384
	System.Void .ctor(); // 0x06db2464
}

// Client.Runtime
class WizardGames.Soc.Common.Runtime.Level.SocNavMeshObstacleSet : UnityEngine.MonoBehaviour
{
	SocLogger logger; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.Runtime.Level.SocNavMeshObstacle> SocNavMeshObstaclesList; // 0x38
	WizardGames.Soc.Common.Entity.IEntity ownerEntity; // 0x40
	WizardGames.Soc.Common.Unity.Go.IEntityGo ownerEntityGo; // 0x48
	UnityEngine.AI.NavMeshHit hitArea; // 0x50
	System.Collections.Generic.HashSet<WizardGames.Soc.Common.Runtime.Level.SocNavMeshObstacle> m_UnavailableNavMeshObstacles; // 0x78
	System.Collections.Generic.List<WizardGames.Soc.Common.Runtime.Level.SocNavMeshObstacle> m_ObstacleToRemove; // 0x80
	System.Single m_AgentHeight; // 0x88
	System.Int64 timer; // 0x90
	System.Int64 get_EntityId(); // 0x06db2ef0
	System.Boolean Fps1Update(); // 0x06db2fc8
	System.Void AddObstacle(WizardGames.Soc.Common.Runtime.Level.SocNavMeshObstacle obstacle); // 0x06db36f4
	System.Boolean HavObstacle(); // 0x06db37e8
	System.Boolean IsMoving(); // 0x06db386c
	System.Void Refresh(WizardGames.Soc.Common.Entity.IEntity entity, WizardGames.Soc.Common.Unity.Go.IEntityGo entityGo); // 0x06db3a34
	System.Boolean CanEnableObstacle(WizardGames.Soc.Common.Runtime.Level.SocNavMeshObstacle obstacle); // 0x06db3374
	System.Boolean EnableObstacle(System.Boolean force); // 0x06db3c2c
	System.Void DisableObstacle(); // 0x06db3e6c
	System.Void Clear(); // 0x06db4024
	System.String SocObstacleSetInfo(); // 0x06db44d4
	System.Void ForceUpdate(); // 0x06db490c
	System.Void .ctor(); // 0x06db4abc
}

// Client.Runtime
interface WizardGames.Soc.Common.ActionExecutor.IActionExecutor : 
{
	
	System.Void Execute(System.Int64 targetEntityId, WizardGames.Soc.Common.Data.ActionBase actionBase, WizardGames.Soc.Common.ActionExecutor.ActionParams actionParams); // 0x05512cd0
}

// Client.Runtime
class WizardGames.Soc.Common.ActionExecutor.ActionParams : System.Object
{
	
	
}

// Client.Runtime
class WizardGames.Soc.Common.ActionExecutor.MgrBaseActionExecutor : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger Log; // 0x0
	static WizardGames.Soc.Common.ActionExecutor.MgrBaseActionExecutor <Instance>k__BackingField; // 0x8
	WizardGames.Soc.Common.ObjPool.ObjectPool<System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.ActionBase,WizardGames.Soc.Common.ActionExecutor.ActionParams>> ActionParamsMapPool; // 0x18
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.ActionExecutor.IActionExecutor> actionExecutorMap; // 0x20
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> actionNeedParamMap; // 0x28
	static WizardGames.Soc.Common.ActionExecutor.MgrBaseActionExecutor get_Instance(); // 0x06db4c9c
	static System.Void set_Instance(WizardGames.Soc.Common.ActionExecutor.MgrBaseActionExecutor value); // 0x06db4d24
	System.Void Init(); // 0x06db4db8
	System.Void ExecuteAction<T>(System.Int64 targetEntityId, T actionBase, WizardGames.Soc.Common.ActionExecutor.ActionParams actionParams); // 0x052af1f0
	System.Void ExecuteActions<T>(System.Int64 targetEntityId, System.Collections.Generic.List<T> actionBaseList, System.Collections.Generic.Dictionary<T,WizardGames.Soc.Common.ActionExecutor.ActionParams> actionParamsMap); // 0x052af1f0
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.ActionBase> Transfer2Actions(System.Int32[] actionIdList); // 0x06db4ec0
	System.Void RegisterActionExecutor(); // 0x055049cc
	System.Void .ctor(); // 0x06db50dc
	static System.Void .cctor(); // 0x06db5240
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.AccessorySimple : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 TableId; // 0x10
	System.Int64 SkinId; // 0x18
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06db5314
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06db53a8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06db55b0
	static System.Void .cctor(); // 0x06db5874
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ActionCfg : WizardGames.Soc.Common.SimpleCustom.NodeCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 Input0; // 0x20
	System.Int32 Output0; // 0x24
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06db5a08
	static WizardGames.Soc.Common.SimpleCustom.ActionCfg ActionCfgConstructor(); // 0x06db5ab0
	System.Void .ctor(); // 0x06db5b30
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06db5bbc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06db5e14
	static System.Void .cctor(); // 0x06db6104
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.AirDropWorldResource : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 entityId; // 0x10
	System.Int64 templateId; // 0x18
	System.Single posx; // 0x20
	System.Single posy; // 0x24
	System.Single posz; // 0x28
	System.Single rotx; // 0x2c
	System.Single roty; // 0x30
	System.Single rotz; // 0x34
	System.Int32 spawnType; // 0x38
	System.Int64 spawnLinkId; // 0x40
	System.Int64 planeEntityId; // 0x48
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06db6300
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06db6394
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06db66b4
	static System.Void .cctor(); // 0x06db6a34
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.Alpha3PlantArgs : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 SrcIndex; // 0x10
	System.Int64 DstIndex; // 0x18
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06db6d9c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06db6e30
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06db7038
	System.Void .ctor(); // 0x06db72fc
	static System.Void .cctor(); // 0x06db7364
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.Alpha3PopMsgParam : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 239984911;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 MuilLanIndex; // 0x10
	System.String DirectStr; // 0x18
	System.UInt64 RoleId; // 0x20
	System.Int32 MsgType; // 0x28
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06db74f8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06db758c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06db77e4
	System.Void .ctor(System.String directStr); // 0x06db7ae0
	static System.Void .cctor(); // 0x06db7b74
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.AsyncCfg : WizardGames.Soc.Common.SimpleCustom.NodeCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06db7d70
	static WizardGames.Soc.Common.SimpleCustom.AsyncCfg AsyncCfgConstructor(); // 0x06db7e18
	System.Void .ctor(); // 0x06db7e98
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06db7f24
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06db813c
	static System.Void .cctor(); // 0x06db8404
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.AudioDataEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 AudioEvent; // 0x38
	System.Int32 SourceEntityType; // 0x3c
	System.Int64 ExtraEntityId; // 0x40
	System.Int32 ExtraEntityType; // 0x48
	System.Int64 ExtraTableId; // 0x50
	System.Int32 PlayType; // 0x58
	System.Int32 SpaceType; // 0x5c
	System.Int32 PosType; // 0x60
	System.Single PosY; // 0x64
	System.String WwiseEventName; // 0x68
	System.Int32 IntParameter; // 0x70
	System.Int64 LongParameter; // 0x78
	System.Int64 ExtraSkinId; // 0x80
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06db8598
	System.Int32 GetClassHash(); // 0x06db8644
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06db86ac
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06db89f0
	System.Void .ctor(); // 0x06db8d54
	System.Void Dispose(); // 0x06db8de0
	static WizardGames.Soc.Common.SimpleCustom.AudioDataEvent NewEvent(); // 0x06db8e8c
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06db8f4c
	static System.Void .cctor(); // 0x06db904c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.AutoTurretEventData : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 OwnerId; // 0x38
	System.Int64 WeaponEntityId; // 0x40
	System.Boolean IsOn; // 0x48
	System.Int32 AutoTurretEventType; // 0x4c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06db94b8
	System.Int32 GetClassHash(); // 0x06db9564
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06db95cc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06db9878
	System.Void .ctor(); // 0x06db9bb8
	static WizardGames.Soc.Common.SimpleCustom.AutoTurretEventData NewEvent(); // 0x06db9c44
	System.Void Dispose(); // 0x06db9d04
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06db9d78
	static System.Void .cctor(); // 0x06db9e38
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.BattleButonTLogInfo : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 BattleButtonId; // 0x10
	System.Int32 BattleButtonGroup; // 0x14
	System.Int32 BattleButtonCount; // 0x18
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dba0d0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dba164
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dba38c
	System.Void .ctor(); // 0x06dba664
	static System.Void .cctor(); // 0x06dba6cc
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.BattleLogInOutTLogInfo : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.UInt64 RoleID; // 0x10
	System.Int64 BattleLogClientStartTime; // 0x18
	System.Collections.Generic.List<System.Int64> BattleLogSvrEquipList; // 0x20
	System.Int64 BattleLogTeamID; // 0x28
	System.Int32 BattleLogKillCount; // 0x30
	System.Int32 BattleLogGunKillingTimes; // 0x34
	System.Int32 BattleLogMeleeKillTimes; // 0x38
	System.Int32 BattleLogGunHitTimes; // 0x3c
	System.Int32 BattleLogGunShotTimes; // 0x40
	System.Single BattleLogDamageAmount; // 0x44
	System.Single BattleLogGunDamageAmount; // 0x48
	System.Single BattleLogMeleeDamageAmount; // 0x4c
	System.Single BattleLogShootHitRateRecently; // 0x50
	System.Single BattleLogShootHeadShotRateRecently; // 0x54
	System.Single BattleLogFullHitRate; // 0x58
	System.Single BattleLogFullHeadShotRate; // 0x5c
	System.Single BattleLogHitPlayerRateRecently; // 0x60
	System.Int32 BattleLogConsecutiveHeadShot; // 0x64
	System.Int32 BattleLogKillDistanceRecently; // 0x68
	System.Int32 BattleLogSpeedRecently; // 0x6c
	System.Int32 BattleLogKillCountRecently; // 0x70
	System.Text.StringBuilder builder; // 0x78
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dba894
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dba9ac
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dbadc4
	System.Void OnGet(); // 0x06dbb1bc
	System.Void OnRelease(); // 0x06dbb21c
	System.Void OnDestroy(); // 0x06dbb2b8
	static System.Void .cctor(); // 0x06dbb318
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.BeeBuzzPlayerEvent : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 beeBuzzId; // 0x10
	System.Int32 eventType; // 0x18
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dbb888
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dbb91c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dbbb28
	static System.Void .cctor(); // 0x06dbbdf0
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.BoxHpZeroEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dbbf84
	System.Int32 GetClassHash(); // 0x06dbc030
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dbc098
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dbc2c0
	System.Void Dispose(); // 0x06dbc598
	System.Void .ctor(); // 0x06dbc600
	static WizardGames.Soc.Common.SimpleCustom.BoxHpZeroEvent NewEvent(); // 0x06dbc68c
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06dbc704
	static System.Void .cctor(); // 0x06dbc7ac
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.BulletCreateEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 Id; // 0x38
	System.Int64 SkinId; // 0x40
	System.Int64 TableId; // 0x48
	System.Int64 HeldItemTableId; // 0x50
	System.Single PosY; // 0x58
	System.Numerics.Vector3 Velocity; // 0x5c
	System.Numerics.Vector3 Acceleration; // 0x68
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dbc974
	System.Int32 GetClassHash(); // 0x06dbca20
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dbca88
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dbce40
	System.Void .ctor(); // 0x06dbd218
	static WizardGames.Soc.Common.SimpleCustom.BulletCreateEvent NewEvent(); // 0x06dbd2a4
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06dbd31c
	System.Void Dispose(); // 0x06dbd404
	static System.Void .cctor(); // 0x06dbd46c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.BulletDestroyEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 Id; // 0x38
	System.Single PosY; // 0x40
	System.Numerics.Vector3 EndPosition; // 0x44
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dbd7a0
	System.Int32 GetClassHash(); // 0x06dbd84c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dbd8b4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dbdbac
	System.Void .ctor(); // 0x06dbdf2c
	static WizardGames.Soc.Common.SimpleCustom.BulletDestroyEvent NewEvent(); // 0x06dbdfb8
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06dbe030
	System.Void Dispose(); // 0x06dbe0f8
	static System.Void .cctor(); // 0x06dbe160
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.BulletRequestData : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Single DirectionX; // 0x10
	System.Single DirectionY; // 0x14
	System.Single DirectionZ; // 0x18
	System.Single PositionX; // 0x1c
	System.Single PositionY; // 0x20
	System.Single PositionZ; // 0x24
	System.Single InitialVelocity; // 0x28
	System.Int64 OwnerEntityId; // 0x30
	System.Int64 OwnerTableId; // 0x38
	System.Int64 HeldItemEntityID; // 0x40
	System.Int32 Sequence; // 0x48
	System.Int64 LagCompensationTime; // 0x50
	System.Single LogicPositionX; // 0x58
	System.Single LogicPositionY; // 0x5c
	System.Single LogicPositionZ; // 0x60
	System.Single DamageScale; // 0x64
	System.Int64 WeaponTableId; // 0x68
	System.Int64 AmmoTableId; // 0x70
	System.Int32 BulletIndex; // 0x78
	System.Boolean MagicBullet; // 0x7c
	System.Boolean IsServerBullet; // 0x7d
	System.Single SourcePositionX; // 0x80
	System.Single SourcePositionY; // 0x84
	System.Single SourcePositionZ; // 0x88
	System.Int32 SourceMonumentId; // 0x8c
	System.Single SourceAdsProgress; // 0x90
	System.Int32 SourceMoveState; // 0x94
	System.Int32 SourcePoseState; // 0x98
	System.Int64 SkinId; // 0xa0
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dbe3c4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dbe460
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dbe8a4
	static System.Void .cctor(); // 0x06dbec70
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.CarData : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1811088193;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Single PosX; // 0x10
	System.Single PosY; // 0x14
	System.Single PosZ; // 0x18
	System.Single RotX; // 0x1c
	System.Single RotY; // 0x20
	System.Single RotZ; // 0x24
	System.Single VelX; // 0x28
	System.Single VelY; // 0x2c
	System.Single VelZ; // 0x30
	System.Single AngVelX; // 0x34
	System.Single AngVelY; // 0x38
	System.Single AngVelZ; // 0x3c
	System.Int64 MountableId; // 0x40
	System.Single SteerAngle; // 0x48
	System.Single GasPedal; // 0x4c
	System.Int32 TotalStartTime; // 0x50
	System.Int32 RevSpeed; // 0x54
	System.Int32 Flag; // 0x58
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dbf380
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dbf414
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dbf774
	static System.Void .cctor(); // 0x06dbfadc
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.CheckBlueprintCreateLegalData : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 blueprintId; // 0x10
	WizardGames.Soc.Common.SimpleCustom.SimpleVector3 position; // 0x18
	System.Single rotateY; // 0x20
	System.Collections.Generic.HashSet<System.Int32> ignoreCheckTypes; // 0x28
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dbffb0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc0044
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dc0358
	static System.Void .cctor(); // 0x06dc06cc
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.CheckConfigBase : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
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
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc08c8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc095c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dc0cd8
	System.Void .ctor(); // 0x06dc1054
	static System.Void .cctor(); // 0x06dc10bc
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.CheckPartLegalData : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 partTemplateId; // 0x10
	System.Int64 skinId; // 0x18
	WizardGames.Soc.Common.SimpleCustom.SimpleVector3 position; // 0x20
	WizardGames.Soc.Common.SimpleCustom.SimpleVector3 eulerAngle; // 0x28
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc15c4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc1658
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dc1924
	static System.Void .cctor(); // 0x06dc1c34
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ClientSwitchEventFp : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Single Delaytime; // 0x38
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc1e30
	System.Int32 GetClassHash(); // 0x06dc1edc
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc1f44
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dc216c
	System.Void .ctor(); // 0x06dc2444
	static WizardGames.Soc.Common.SimpleCustom.ClientSwitchEventFp NewEvent(); // 0x06dc24d0
	static WizardGames.Soc.Common.SimpleCustom.ClientSwitchEventFp NewEvent(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, System.Single delaytime); // 0x06dc2548
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06dc2668
	static System.Void .cctor(); // 0x06dc2718
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ClientSwitchEventTp : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc28e0
	System.Int32 GetClassHash(); // 0x06dc298c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc29f4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dc2c1c
	System.Void .ctor(); // 0x06dc2ef4
	static WizardGames.Soc.Common.SimpleCustom.ClientSwitchEventTp NewEvent(); // 0x06dc2f80
	static WizardGames.Soc.Common.SimpleCustom.ClientSwitchEventTp NewEvent(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06dc2ff8
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06dc3100
	static System.Void .cctor(); // 0x06dc31a8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ClientSyncTimeData : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 WorldTime; // 0x10
	System.Int64 TimeOffset; // 0x18
	System.Int64 Now; // 0x20
	System.Int64 MsSinceStartup; // 0x28
	System.Int64 MsSinceLogicStart; // 0x30
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc3370
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc3404
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dc3658
	static System.Void .cctor(); // 0x06dc3964
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ComboPartInfo : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 ParentCount; // 0x10
	System.Int64 ParentTemplateId; // 0x18
	System.Int32 ParentGrade; // 0x20
	System.Int64 ComboGroupId; // 0x28
	System.Collections.Generic.List<System.Int64> AliveChildren; // 0x30
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc3b94
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc3c28
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dc3f0c
	static System.Void .cctor(); // 0x06dc4278
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ComboTemplateGrades : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> GradesInfo; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc44a8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc453c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dc47a0
	System.Void .ctor(); // 0x06dc4aa8
	static System.Void .cctor(); // 0x06dc4b5c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ConstructionBlueprintCheckConfigData : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
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
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc4cbc
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc4d50
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dc50cc
	static System.Void .cctor(); // 0x06dc5448
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ConstructionBlueprintMeshData : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 Id; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.SimpleVector3> Vertices; // 0x18
	System.Collections.Generic.List<System.Int32> Triangles; // 0x20
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc5950
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc59e4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dc5ce8
	System.Void .ctor(); // 0x06dc6060
	static System.Void .cctor(); // 0x06dc60c8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ConstructionBlueprintSaveData : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 TemplateId; // 0x10
	System.Int64 EntityId; // 0x18
	System.Single PosX; // 0x20
	System.Single PosY; // 0x24
	System.Single PosZ; // 0x28
	System.Single RotationX; // 0x2c
	System.Single RotationY; // 0x30
	System.Single RotationZ; // 0x34
	System.Int32 Grade; // 0x38
	System.Single Stability; // 0x3c
	System.Int32 SkinId; // 0x40
	System.Collections.Generic.List<System.Int64> ChildIdList; // 0x48
	System.Int64 ParentId; // 0x50
	System.Int64 ChildGroupId; // 0x58
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc6290
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc6324
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dc66b0
	static System.Void .cctor(); // 0x06dc6a64
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ConstructionBlueprintSaveOriginData : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 EntityId; // 0x10
	System.Int64 TemplateId; // 0x18
	System.Int32 Grade; // 0x20
	System.Int64 ChildPartType; // 0x28
	System.Single ChildPosX; // 0x30
	System.Single ChildPosY; // 0x34
	System.Single ChildPosZ; // 0x38
	System.Single ChildAngleX; // 0x3c
	System.Single ChildAngleY; // 0x40
	System.Single ChildAngleZ; // 0x44
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc6e68
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc6efc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dc7200
	static System.Void .cctor(); // 0x06dc756c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ConstructionBlueprintSaveSummaryData : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 TemplateId; // 0x10
	System.Int32 Num; // 0x18
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc78a0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc7934
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dc7b40
	static System.Void .cctor(); // 0x06dc7e08
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ControlCfg : WizardGames.Soc.Common.SimpleCustom.NodeCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc7f9c
	static WizardGames.Soc.Common.SimpleCustom.ControlCfg ControlCfgConstructor(); // 0x06dc8044
	System.Void .ctor(); // 0x06dc80c4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc8150
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dc8368
	static System.Void .cctor(); // 0x06dc8630
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.CreateBoxRequest : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 EntityId; // 0x10
	System.Int64 TemplateId; // 0x18
	System.Single PosX; // 0x20
	System.Single PosY; // 0x24
	System.Single PosZ; // 0x28
	System.Single RotateX; // 0x2c
	System.Single RotateY; // 0x30
	System.Single RotateZ; // 0x34
	System.Int32 SpawnType; // 0x38
	System.Int64 SpawnLinkId; // 0x40
	System.Int64 SourceEntityId; // 0x48
	System.Int64 SourceEntityTemplateId; // 0x50
	System.Int32 SourceEntityTypeId; // 0x58
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc87c4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc8858
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dc8b54
	static System.Void .cctor(); // 0x06dc8e94
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.CreateCorpseEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 CorpseEntityId; // 0x38
	System.Int32 DeadType; // 0x40
	System.Numerics.Vector3 Dir; // 0x44
	System.Numerics.Vector3 HitPoint; // 0x50
	System.Int32 HitPart; // 0x5c
	System.Int32 ColliderIndex; // 0x60
	System.String ColliderName; // 0x68
	System.Int32 CorpseType; // 0x70
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc9264
	System.Int32 GetClassHash(); // 0x06dc9310
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dc9378
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dc9758
	System.Void .ctor(); // 0x06dc9b58
	static WizardGames.Soc.Common.SimpleCustom.CreateCorpseEvent NewEvent(); // 0x06dc9be4
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06dc9c5c
	static System.Void .cctor(); // 0x06dc9d60
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.CreateCorpseRequest : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 HostEntityId; // 0x10
	System.Int32 TemplateId; // 0x18
	System.Single PosX; // 0x1c
	System.Single PosY; // 0x20
	System.Single PosZ; // 0x24
	System.Single RotateX; // 0x28
	System.Single RotateY; // 0x2c
	System.Single RotateZ; // 0x30
	System.Single VelocityX; // 0x34
	System.Single VelocityY; // 0x38
	System.Single VelocityZ; // 0x3c
	System.Int64 KillPlayerId; // 0x40
	System.Boolean IsPlayer; // 0x48
	System.Int32 DeadType; // 0x4c
	System.Boolean IsTriggeredByTrap; // 0x50
	System.Numerics.Vector3 Dir; // 0x54
	System.Numerics.Vector3 HitPoint; // 0x60
	System.Int32 HitPart; // 0x6c
	System.Int32 ColliderIndex; // 0x70
	System.String ColliderName; // 0x78
	System.Boolean IsGibs; // 0x80
	System.Int64 PlatformId; // 0x88
	System.Single LocalPosX; // 0x90
	System.Single LocalPosY; // 0x94
	System.Single LocalPosZ; // 0x98
	System.Single LocalRotX; // 0x9c
	System.Single LocalRotY; // 0xa0
	System.Single LocalRotZ; // 0xa4
	System.Boolean IsDieFromCrawl; // 0xa8
	WizardGames.Soc.Common.Entity.ECorpseTypeEnum CorpseType; // 0xac
	System.Int64 HostTemplateId; // 0xb0
	System.Int32 HitDamageType; // 0xb8
	System.Int32 SourceEntityTypeId; // 0xbc
	System.Int64 PoiLinkedPlayerId; // 0xc0
	System.Int64 PoiLinkedTaskId; // 0xc8
	System.Int64 HoldItemId; // 0xd0
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dca0c8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dca15c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dca6f8
	static System.Void .cctor(); // 0x06dcab84
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.CreateMonsterRequest : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 TemplateId; // 0x10
	System.Single PosX; // 0x14
	System.Single PosY; // 0x18
	System.Single PosZ; // 0x1c
	System.Single RotateY; // 0x20
	System.Boolean SpecialSpawn; // 0x24
	System.Int32 MonumentId; // 0x28
	System.Int64 TargetId; // 0x30
	System.Single SummonMonsterMaxDis; // 0x38
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dcb3e4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dcb478
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dcb764
	static System.Void .cctor(); // 0x06dcbad0
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.CreatePartAndPlayAudioEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 PartType; // 0x38
	System.Int32 Grade; // 0x40
	System.Single PosY; // 0x44
	System.Boolean IsBlueprint; // 0x48
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dcbdd0
	System.Int32 GetClassHash(); // 0x06dcbe7c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dcbee4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dcc190
	System.Void Dispose(); // 0x06dcc4d0
	System.Void .ctor(); // 0x06dcc538
	static WizardGames.Soc.Common.SimpleCustom.CreatePartAndPlayAudioEvent NewEvent(); // 0x06dcc5c4
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06dcc63c
	static System.Void .cctor(); // 0x06dcc704
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.CreatePartInfo : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 targetPartId; // 0x10
	System.Int64 itemUid; // 0x18
	System.Int64 markId; // 0x20
	System.Int32 grade; // 0x28
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dcc99c
	static WizardGames.Soc.Common.SimpleCustom.CreatePartInfo CreatePartInfoConstructor(); // 0x06dccc7c
	System.Void .ctor(); // 0x06dcccfc
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dcca30
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dccd64
	static System.Void .cctor(); // 0x06dcd054
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.CreateShopParam : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 EntityId; // 0x10
	System.Int64 ShopId; // 0x18
	System.Single PosX; // 0x20
	System.Single PosY; // 0x24
	System.Single PosZ; // 0x28
	System.Single RotX; // 0x2c
	System.Single RotY; // 0x30
	System.Int32 SpawnType; // 0x34
	System.Int64 SpawnLinkId; // 0x38
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dcd2b4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dcd348
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dcd630
	static System.Void .cctor(); // 0x06dcd990
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.DamageDataEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 SourcePlayerId; // 0x38
	System.Int64 TargetId; // 0x40
	System.Int32 HitPartInt; // 0x48
	System.Single Damage; // 0x4c
	System.Single DirX; // 0x50
	System.Single DirY; // 0x54
	System.Single DirZ; // 0x58
	System.Int32 KillType; // 0x5c
	System.Single HitPointX; // 0x60
	System.Single HitPointY; // 0x64
	System.Single HitPointZ; // 0x68
	System.Int32 SourceType; // 0x6c
	System.Int32 TargetType; // 0x70
	System.Int32 DamageType; // 0x74
	System.Int64 SourceTableId; // 0x78
	System.Int64 WeaponTableId; // 0x80
	System.Int64 WeaponId; // 0x88
	System.Int64 WeaponSkinId; // 0x90
	System.String TargetName; // 0x98
	System.Single Distance; // 0xa0
	System.Int32 DamageRelation; // 0xa4
	System.Int64 TargetRoleId; // 0xa8
	System.Single SourcePositionX; // 0xb0
	System.Single SourcePositionY; // 0xb4
	System.Single SourcePositionZ; // 0xb8
	System.Boolean HasSourcePosition; // 0xbc
	System.Int64 AmmoTableId; // 0xc0
	System.Int64 SourceClientTime; // 0xc8
	System.Byte DamageBuff; // 0xd0
	System.Int32 HitByEntityType; // 0xd4
	System.Int32 NewHp; // 0xd8
	System.Numerics.Vector3 SourcePosition; // 0xdc
	System.Int64 SourceRoleId; // 0xe8
	System.Int32 SourceMonumentId; // 0xf0
	System.Int32 SourceTeamMemberCount; // 0xf4
	System.Single SourceAdsProgress; // 0xf8
	System.Int32 SourceMoveState; // 0xfc
	System.Boolean IsMagicBullet; // 0x100
	System.Numerics.Vector3 TargetPosition; // 0x104
	System.Int32 TargetTeamMemberCount; // 0x110
	System.Int32 TargetMonumentId; // 0x114
	System.Int64 TargetTableId; // 0x118
	System.Int32 DamageCompass; // 0x120
	System.Int32 OldHp; // 0x124
	System.Int64 HitTime; // 0x128
	System.Int32 HeldItemType; // 0x130
	System.Int64 DamageTargetTeamID; // 0x138
	System.Int32 DamageTargetIsOnline; // 0x140
	System.Int32 DamageTargetCurrentWeapon; // 0x144
	System.Int32 DamageSourcePoseStatus; // 0x148
	System.Int64 DamageSourceTeamID; // 0x150
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dcdc90
	System.Int32 GetClassHash(); // 0x06dcdd3c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dcdda4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dce254
	System.Void .ctor(); // 0x06dce660
	static WizardGames.Soc.Common.SimpleCustom.DamageDataEvent NewEvent(); // 0x06dce6ec
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06dce764
	System.Void Dispose(); // 0x06dce970
	WizardGames.Soc.Common.Combat.HitPart get_HitPart(); // 0x06dcea88
	static System.Void .cctor(); // 0x06dceaec
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.DamageInstance : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 DamageRelation; // 0x10
	System.Int64 TargetEntityId; // 0x18
	System.Int32 TargetEntityType; // 0x20
	System.Int64 TargetEntityTableId; // 0x28
	System.Int32 Distance; // 0x30
	System.Int64 WeaponTemplateId; // 0x38
	System.Collections.Generic.List<System.Int64> WeaponPartsTemplateId; // 0x40
	System.Int64 BulletTemplateId; // 0x48
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dcf2ec
	static WizardGames.Soc.Common.SimpleCustom.DamageInstance DamageInstanceConstructor(); // 0x06dcf6c8
	System.Void .ctor(); // 0x06dcf748
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dcf380
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dcf7b0
	static System.Void .cctor(); // 0x06dcfb58
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.DamageTLogInfo : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 DamageTargetEntityType; // 0x10
	System.Int64 DamageTargetEntityId; // 0x18
	System.UInt64 DamageTargetVRoleID; // 0x20
	System.Int32 DamageTargetRoleRegisterTime; // 0x28
	System.Int32 DamageTargetRoleReputation; // 0x2c
	System.String DamageTargetDeviceLevel; // 0x30
	System.Int32 DamageTargetTeamNumber; // 0x38
	System.Numerics.Vector3 DamageTargetLocation; // 0x3c
	System.Int32 DamageTargetLocationMonument; // 0x48
	System.Int32 DamageTargetDead; // 0x4c
	System.Int32 DamageTargetBody; // 0x50
	System.Int32 DamageTargetDirection; // 0x54
	System.Single DamageTargetDamage; // 0x58
	System.Int64 DamageTargetHitTime; // 0x60
	System.Int32 DamageTargetHPstart; // 0x68
	System.Int32 DamageTargetHPEnd; // 0x6c
	System.Int32 DamageSourceEntityType; // 0x70
	System.Int64 DamageSourceEntityId; // 0x78
	System.UInt64 DamageSourceVRoleID; // 0x80
	System.Int32 DamageSourceRoleRegisterTime; // 0x88
	System.Int32 DamageSourceRoleReputation; // 0x8c
	System.String DamageSourceDeviceLevel; // 0x90
	System.Int32 DamageSourceTeamNumber; // 0x98
	System.Numerics.Vector3 DamageSourceLocation; // 0x9c
	System.Int32 DamageSourceLocationMonument; // 0xa8
	System.Single DamageSourceShootType; // 0xac
	System.Int32 DamageSourceShootStatus; // 0xb0
	System.Int32 DamageSourceWeaponId; // 0xb4
	System.Int32 DamageSourceBulletId; // 0xb8
	System.Boolean DamageSourceShootAbsorption; // 0xbc
	System.Int64 DamageSourceClientStartTime; // 0xc0
	System.Int32 DamageSourceFlowID; // 0xc8
	System.Int32 DamageSourceWeaponType; // 0xcc
	System.Int32 DamageSourceLastHitTime; // 0xd0
	System.Int64 DamageTargetTeamID; // 0xd8
	System.Int32 DamageTargetIsOnline; // 0xe0
	System.Int32 DamageTargetCurrentWeapon; // 0xe4
	System.Int32 DamageSourcePoseStatus; // 0xe8
	System.Int64 DamageSourceTeamID; // 0xf0
	System.Int32 DamageDistance; // 0xf8
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dcfe24
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dcfeec
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dd04d4
	System.Void OnGet(); // 0x06dd098c
	System.Void OnRelease(); // 0x06dd09ec
	System.Void OnDestroy(); // 0x06dd0af8
	static System.Void .cctor(); // 0x06dd0b58
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.DamageTypeList : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.List<System.Single> Types; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dd1478
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dd1558
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dd17bc
	System.Void .ctor(); // 0x06dd1ac4
	System.Void Set(WizardGames.Soc.Common.SimpleCustom.DamageType index, System.Single amount); // 0x06dd1c08
	System.Single Get(WizardGames.Soc.Common.SimpleCustom.DamageType index); // 0x06dd1cbc
	System.Void Add(WizardGames.Soc.Common.SimpleCustom.DamageType index, System.Single amount); // 0x06dd1d58
	System.Void Clear(); // 0x06dd1df8
	static System.Void .cctor(); // 0x06dd1eb0
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.DataPortCfg : WizardGames.Soc.Common.SimpleCustom.PortCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	WizardGames.Soc.Common.SimpleCustom.PortDataType DataType; // 0x20
	WizardGames.Soc.Common.SimpleCustom.ValueCfg DefaultValue; // 0x28
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dd2010
	static WizardGames.Soc.Common.SimpleCustom.DataPortCfg DataPortCfgConstructor(); // 0x06dd20b8
	System.Void .ctor(); // 0x06dd2138
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dd21c4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dd247c
	static System.Void .cctor(); // 0x06dd279c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.DestroyPartGoEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 PartEntityId; // 0x38
	System.Single PosY; // 0x40
	System.Single RotateX; // 0x44
	System.Single RotateY; // 0x48
	System.Single RotateZ; // 0x4c
	System.Int64 TemplateId; // 0x50
	System.Int32 Grade; // 0x58
	System.Int64 SkinId; // 0x60
	System.Int64 AdditionInfo; // 0x68
	System.Int64 LastAttackPlayerId; // 0x70
	System.Int32 ShowState; // 0x78
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dd2998
	System.Int32 GetClassHash(); // 0x06dd2a44
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dd2aac
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dd2dbc
	System.Void Dispose(); // 0x06dd3104
	System.Void .ctor(); // 0x06dd318c
	static WizardGames.Soc.Common.SimpleCustom.DestroyPartGoEvent NewEvent(); // 0x06dd3218
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06dd3290
	static System.Void .cctor(); // 0x06dd3380
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.DestroySnapShotEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 EntityType; // 0x38
	System.Int64 EntityId; // 0x40
	System.Single PosY; // 0x48
	System.Int32 IntParam; // 0x4c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dd3784
	System.Int32 GetClassHash(); // 0x06dd3830
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dd3898
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dd3b40
	System.Void Dispose(); // 0x06dd3e74
	System.Void .ctor(); // 0x06dd3edc
	static WizardGames.Soc.Common.SimpleCustom.DestroySnapShotEvent NewEvent(); // 0x06dd3f68
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06dd3fe0
	static System.Void .cctor(); // 0x06dd40a8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.DropCombineEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 ItemTemplateId; // 0x38
	System.Single PosY; // 0x40
	System.Single RotateX; // 0x44
	System.Single RotateY; // 0x48
	System.Single RotateZ; // 0x4c
	System.Int64 CombineEntityId; // 0x50
	System.Int64 SkinId; // 0x58
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dd4340
	System.Int32 GetClassHash(); // 0x06dd43ec
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dd4454
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dd4758
	System.Void Dispose(); // 0x06dd4ab8
	System.Void .ctor(); // 0x06dd4b20
	static WizardGames.Soc.Common.SimpleCustom.DropCombineEvent NewEvent(); // 0x06dd4bac
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06dd4c24
	static System.Void .cctor(); // 0x06dd4cf4
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.EffectDataEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.String EffectPath; // 0x38
	System.Int32 TemplateId; // 0x40
	System.Single PosY; // 0x44
	System.Single ForwardX; // 0x48
	System.Single ForwardY; // 0x4c
	System.Single ForwardZ; // 0x50
	System.Single RotateAngleX; // 0x54
	System.Single RotateAngleY; // 0x58
	System.Single RotateAngleZ; // 0x5c
	System.Int32 RelativeTo; // 0x60
	System.Single Scale; // 0x64
	System.Int32 Event; // 0x68
	System.Int64 IntParam; // 0x70
	System.String EffectSound; // 0x78
	System.Int32 ExtraEffect; // 0x80
	System.Int64 LongParam; // 0x88
	System.String StringParam; // 0x90
	System.Numerics.Vector3 Velocity; // 0x98
	System.Numerics.Vector3 Acceleration; // 0xa4
	System.Single DecalScale; // 0xb0
	System.Int64 EntityId; // 0xb8
	System.String EffectState; // 0xc0
	System.Int64 OwnerId; // 0xc8
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dd5028
	System.Int32 GetClassHash(); // 0x06dd50e8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dd5150
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dd5614
	System.Void .ctor(); // 0x06dd5a3c
	static WizardGames.Soc.Common.SimpleCustom.EffectDataEvent NewEvent(); // 0x06dd5adc
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06dd5b54
	System.Void Dispose(); // 0x06dd5ca8
	static System.Void .cctor(); // 0x06dd5dc8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ElectricCmdBase : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.ICmd
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dd6408
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dd65c0
	System.Void .ctor(); // 0x06dd6840
	System.Boolean OfflineVerify(); // 0x054c4760
	System.Boolean OnlineVerify_IC(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit); // 0x054dec74
	System.Void ApplyCmd_IC(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit); // 0x05523a54
	System.Boolean GenRevertCmd(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit, WizardGames.Soc.Common.SimpleCustom.ICmd& rcmd); // 0x054e0cf4
	System.Void ClearCache(); // 0x06dd68a8
	static System.Void .cctor(); // 0x06dd6908
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ElectricCmd_Multi : WizardGames.Soc.Common.SimpleCustom.ElectricCmdBase
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.ElectricCmdBase> cmdBaseList; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dd6a30
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dd6b20
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dd6cd8
	System.Void .ctor(); // 0x06dd6f58
	System.Boolean OfflineVerify(); // 0x06dd702c
	System.Boolean OnlineVerify_IC(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit); // 0x06dd7090
	System.Void ApplyCmd_IC(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit); // 0x06dd7108
	System.Void ClearCache(); // 0x06dd7294
	System.Boolean GenRevertCmd(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit, WizardGames.Soc.Common.SimpleCustom.ICmd& rcmd); // 0x06dd740c
	static System.Void .cctor(); // 0x06dd749c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ElevatorData : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.String AudioName; // 0x38
	System.Int64 BuildingPrivilegeEntityId; // 0x40
	System.Single PosY; // 0x48
	System.Boolean Force; // 0x4c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dd75c4
	System.Int32 GetClassHash(); // 0x06dd7694
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dd76fc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dd79b4
	System.Void Dispose(); // 0x06dd7cf4
	System.Void .ctor(); // 0x06dd7d5c
	static WizardGames.Soc.Common.SimpleCustom.ElevatorData NewEvent(); // 0x06dd7e0c
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06dd7e84
	static System.Void .cctor(); // 0x06dd7f48
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.EntityBriefInfo : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.UInt64 RoleId; // 0x10
	System.Int64 CurrentBadgeId; // 0x18
	System.Int32 ReputationLevel; // 0x20
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dd81e0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dd8274
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dd849c
	System.String ToString(); // 0x06dd8780
	static System.Void .cctor(); // 0x06dd8854
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.EquipmentSimple : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 TableId; // 0x10
	System.Int64 SkinId; // 0x18
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dd8a1c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dd8ab0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dd8cb8
	static System.Void .cctor(); // 0x06dd8f7c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.EventCfg : WizardGames.Soc.Common.SimpleCustom.NodeCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 Output0; // 0x20
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dd9110
	static WizardGames.Soc.Common.SimpleCustom.EventCfg EventCfgConstructor(); // 0x06dd91b8
	System.Void .ctor(); // 0x06dd9238
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dd92c4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dd94f8
	static System.Void .cctor(); // 0x06dd97d0
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.FireDataEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent, WizardGames.Soc.Common.Cache.ICacheObject
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 FireEvent; // 0x38
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dd9998
	System.Int32 GetClassHash(); // 0x06dd9a44
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dd9aac
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dd9cf8
	System.Void .ctor(); // 0x06dd9fe8
	static WizardGames.Soc.Common.SimpleCustom.FireDataEvent NewEvent(); // 0x06dda074
	static WizardGames.Soc.Common.SimpleCustom.FireDataEvent NewEvent(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, System.Int64 fireEvent); // 0x06dda0ec
	System.Void Dispose(); // 0x06dda208
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06dda278
	static System.Void .cctor(); // 0x06dda328
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.FlowPortCfg : WizardGames.Soc.Common.SimpleCustom.PortCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 TargetNodeId; // 0x20
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dda524
	static WizardGames.Soc.Common.SimpleCustom.FlowPortCfg FlowPortCfgConstructor(); // 0x06dda5cc
	System.Void .ctor(); // 0x06dda64c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dda6d8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dda914
	static System.Void .cctor(); // 0x06ddabec
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.GameEndResultDetailData : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.String RoleId; // 0x10
	System.Int64 KillNum; // 0x18
	System.Int64 DestroyConstructionNum; // 0x20
	System.Int64 GetScrapItemNum; // 0x28
	System.Int64 GetIntelItemNum; // 0x30
	System.Int64 ConstructAndUpgradeConstructionNum; // 0x38
	System.Int64 OnlineTimeSec; // 0x40
	System.Int64 ReputationLevel; // 0x48
	System.Int64 ReputationLevelTimeStamp; // 0x50
	System.Collections.Generic.List<System.Int64> ReputationBadge; // 0x58
	System.Int32 NewBieTaskFlag; // 0x60
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ddadb4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ddaeb8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06ddb25c
	static System.Void .cctor(); // 0x06ddb644
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.GameTimeParam : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 DaySeconds; // 0x10
	System.Int32 SunriseSecond; // 0x14
	System.Int32 DaySecond; // 0x18
	System.Int32 SunsetSecond; // 0x1c
	System.Int32 NightSecond; // 0x20
	System.Int32 StartSecond; // 0x24
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ddb9ac
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ddba40
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06ddbcc4
	System.Void .ctor(WizardGames.Soc.Common.SimpleCustom.GameTimeParam other); // 0x06ddbfec
	static System.Void .cctor(); // 0x06ddc084
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.GradeCountInfo : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> GradeCount; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ddc2e8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ddc37c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06ddc5e0
	static System.Void .cctor(); // 0x06ddc8e8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.GraphInputCfg : WizardGames.Soc.Common.SimpleCustom.NodeCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.FlowPortCfg> GraphFlowInputPorts; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.DataPortCfg> GraphDataInputPorts; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.FlowPortCfg> NodeFlowOutputPorts; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.VarGuidPortCfg> NodeDataOutputPorts; // 0x38
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ddca48
	static WizardGames.Soc.Common.SimpleCustom.GraphInputCfg GraphInputCfgConstructor(); // 0x06ddcaf0
	System.Void .ctor(); // 0x06ddcb70
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ddcbfc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06ddd020
	static System.Void .cctor(); // 0x06ddd434
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.GraphNodeExecutorBase : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ddd698
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ddd71c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06ddd8d4
	System.Void .ctor(); // 0x06dddb54
	static System.Void .cctor(); // 0x06dddbbc
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.GraphNodeInfo : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 GraphInstanceId; // 0x10
	System.Int64 ContextId; // 0x18
	System.Int64 NodeInstanceId; // 0x20
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dddce4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dddd78
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dddfa0
	System.String ToString(); // 0x06dde278
	static System.Void .cctor(); // 0x06dde378
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.GraphOutputCfg : WizardGames.Soc.Common.SimpleCustom.NodeCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.FlowPortCfg> GraphFlowOutputPorts; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.DataPortCfg> GraphDataOutputPorts; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.FlowPortCfg> NodeFlowInputPorts; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.DataPortCfg> NodeDataInputPorts; // 0x38
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dde540
	static WizardGames.Soc.Common.SimpleCustom.GraphOutputCfg GraphOutputCfgConstructor(); // 0x06dde5e8
	System.Void .ctor(); // 0x06dde668
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dde6f4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06ddeb04
	static System.Void .cctor(); // 0x06ddeed0
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.GunshipEvent : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	WizardGames.Soc.Common.SimpleCustom.EGunshipEvent State; // 0x10
	System.Int32 leftMins; // 0x14
	System.String KillPlayerName; // 0x18
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ddf134
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ddf1c8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06ddf3fc
	static System.Void .cctor(); // 0x06ddf6d4
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.GunTrapFireEventDataSingle : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int16 DirX; // 0x10
	System.Int16 DirY; // 0x12
	System.Int16 DirZ; // 0x14
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ddf89c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ddf930
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06ddfb58
	static System.Void .cctor(); // 0x06ddfe30
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.GunTrapFireEventData : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 OwnerId; // 0x38
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ddfff8
	System.Int32 GetClassHash(); // 0x06de00a4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06de010c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06de0358
	System.Void .ctor(); // 0x06de0648
	static WizardGames.Soc.Common.SimpleCustom.GunTrapFireEventData NewEvent(); // 0x06de06d4
	System.Void Dispose(); // 0x06de074c
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06de07c0
	static System.Void .cctor(); // 0x06de0868
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.HitRequest : Share.Common.ObjPool.Alpha3PooledObjectBase, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 SourceId; // 0x20
	System.Int64 TargetId; // 0x28
	System.Int32 TargetType; // 0x30
	System.Int32 HitPartInt; // 0x34
	System.Numerics.Vector3 Direction; // 0x38
	System.Numerics.Vector3 Point; // 0x44
	System.Numerics.Vector3 Normal; // 0x50
	System.Int64 BackUpHitTableId; // 0x60
	WizardGames.Soc.Common.SimpleCustom.DamageTypeList RawDamageTypes; // 0x68
	WizardGames.Soc.Common.SimpleCustom.DamageTypeList DamageTypes; // 0x70
	System.Boolean IgnoreProtection; // 0x78
	System.Numerics.Vector3 OBBPoint; // 0x7c
	System.Int32 PveAttFix; // 0x88
	System.Boolean FromPool; // 0x8c
	System.Int64 HitTime; // 0x90
	System.Numerics.Vector3 HitVelocity; // 0x98
	System.Boolean Ricochet; // 0xa4
	System.Single GatherDamage; // 0xa8
	System.Int32 BonusLevel; // 0xac
	System.Int32 ColliderIndex; // 0xb0
	System.Int32 BallisticPropertyID; // 0xb4
	System.Single Distance; // 0xb8
	System.Boolean IsHitFakeMonster; // 0xbc
	System.Numerics.Vector3 OffsetPoint; // 0xc0
	System.Numerics.Vector3 OffsetQuaternion; // 0xcc
	System.Numerics.Vector3 SourcePosition; // 0xd8
	System.Boolean HasSourcePosition; // 0xe4
	System.Single SourceAdsProgress; // 0xe8
	System.Int32 SourceMoveState; // 0xec
	System.Boolean SourceIsMagic; // 0xf0
	System.Int32 SourceMonumentId; // 0xf4
	System.Int64 AttackStartTime; // 0xf8
	System.Int32 SourcePoseState; // 0x100
	System.Int32 WaysToDieID; // 0x104
	System.Byte DamageBuff; // 0x108
	System.Boolean IsPropagateDamage; // 0x109
	System.Boolean IsThisFrameHandle; // 0x10a
	WizardGames.Soc.Common.Entity.IEntity SourceEntity; // 0x110
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.HitSourceInfo> HitSources; // 0x118
	System.Int32 Sequence; // 0x120
	System.Int32 PartRate; // 0x124
	WizardGames.Soc.Common.Data.DamageRelation DamageRelation; // 0x128
	System.Int64 WeaponSkinId; // 0x130
	WizardGames.Soc.Common.Combat.ColliderMaterialEnum MaterialType; // 0x138
	WizardGames.Soc.Common.Combat.ColliderMaterialEnum EffectMaterialType; // 0x139
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06de0a64
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06de0bbc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06de1080
	WizardGames.Soc.Common.Combat.HitPart get_HitPart(); // 0x06de14c0
	System.Void set_HitPart(WizardGames.Soc.Common.Combat.HitPart value); // 0x06de1524
	System.Void .ctor(); // 0x06de15a0
	static WizardGames.Soc.Common.SimpleCustom.HitRequest Generate(System.Int64 sourceId); // 0x06de16cc
	System.Void SetTarget(System.Int64 entityId, System.Int32 entityType); // 0x06de17b0
	System.Void TryRelease(); // 0x06de1834
	System.Boolean get_IsGather(); // 0x06de18d4
	System.Void AddSource(System.Int64 entityId, System.Int32 entityType, System.Int64 tableId); // 0x06de1940
	System.Void UpdateEffectMaterialType(WizardGames.Soc.Common.Entity.IEntity target); // 0x06de1aa0
	System.Boolean TryGetHitSourceByType(System.Int32 entityType, WizardGames.Soc.Common.SimpleCustom.HitSourceInfo& info); // 0x06de1b38
	System.Boolean TryGetTableIDByType(System.Int32 entityType, System.Int64& tableId); // 0x06de1c58
	System.Void Dispose(); // 0x06de1d70
	System.Int64 get_WeaponTableId(); // 0x06de1ffc
	System.Int64 get_ProjectileTableId(); // 0x06de20e8
	static System.Void .cctor(); // 0x06de2184
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.HitSoundDataEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Single PosY; // 0x38
	System.Int64 TargetID; // 0x40
	System.Int32 TargetType; // 0x48
	System.Int32 SfxSourceEntityType; // 0x4c
	System.Int64 SfxSourceTableId; // 0x50
	System.Int32 HitPart; // 0x58
	System.Int32 Material; // 0x5c
	System.Int64 WeaponSkinID; // 0x60
	System.Int64 TargetTableID; // 0x68
	System.Boolean IsHeadShot; // 0x70
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06de2520
	System.Int32 GetClassHash(); // 0x06de25d8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06de2640
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06de2940
	System.Void .ctor(); // 0x06de2c8c
	static WizardGames.Soc.Common.SimpleCustom.HitSoundDataEvent NewEvent(); // 0x06de2d24
	System.Void Dispose(); // 0x06de2d9c
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06de2e2c
	static System.Void .cctor(); // 0x06de2f10
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ICCmd_ICRename : WizardGames.Soc.Common.SimpleCustom.ElectricCmdBase
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.String Name; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06de32e0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06de3384
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06de3580
	System.Void .ctor(); // 0x06de382c
	System.Void ApplyCmd_IC(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit); // 0x06de38b4
	System.Boolean GenRevertCmd(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit, WizardGames.Soc.Common.SimpleCustom.ICmd& rcmd); // 0x06de393c
	System.Boolean OfflineVerify(); // 0x06de3a18
	System.Boolean OnlineVerify_IC(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit); // 0x06de3a7c
	static System.Void .cctor(); // 0x06de3af4
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ICCmd_InterfaceAdd : WizardGames.Soc.Common.SimpleCustom.ElectricCmdBase
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	WizardGames.Soc.Common.CustomType.Alpha3ElectricCircuitInterface eInterface; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06de3c54
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06de3cf8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06de3f44
	System.Void .ctor(); // 0x06de4214
	System.Void ApplyCmd_IC(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit); // 0x06de429c
	System.Boolean GenRevertCmd(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit, WizardGames.Soc.Common.SimpleCustom.ICmd& rcmd); // 0x06de4344
	System.Boolean OfflineVerify(); // 0x06de44b4
	System.Boolean OnlineVerify_IC(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit); // 0x06de4518
	static System.Void .cctor(); // 0x06de45b0
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ICCmd_InterfaceRemove : WizardGames.Soc.Common.SimpleCustom.ElectricCmdBase
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 UnitId; // 0x10
	System.Int32 OpType; // 0x18
	WizardGames.Soc.Common.CustomType.Alpha3ElectricCircuitInterface cInterface; // 0x20
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06de4710
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06de47b4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06de49c0
	System.Void .ctor(); // 0x06de442c
	System.Void ApplyCmd_IC(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit); // 0x06de4c88
	System.Boolean GenRevertCmd(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit, WizardGames.Soc.Common.SimpleCustom.ICmd& rcmd); // 0x06de4d20
	System.Boolean OfflineVerify(); // 0x06de4e3c
	System.Boolean OnlineVerify_IC(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit); // 0x06de4ea0
	System.Void ClearCache(); // 0x06de4f38
	static System.Void .cctor(); // 0x06de4fac
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ICCmd_InterfaceRename : WizardGames.Soc.Common.SimpleCustom.ElectricCmdBase
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.String Name; // 0x10
	System.Int64 UnitId; // 0x18
	System.Int32 OpType; // 0x20
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06de5140
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06de51e4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06de5418
	System.Void ApplyCmd_IC(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit); // 0x06de56fc
	System.Boolean GenRevertCmd(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit, WizardGames.Soc.Common.SimpleCustom.ICmd& rcmd); // 0x06de5794
	System.Boolean OfflineVerify(); // 0x06de5834
	System.Boolean OnlineVerify_IC(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit); // 0x06de5898
	static System.Void .cctor(); // 0x06de5930
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ICCmd_SlotBind : WizardGames.Soc.Common.SimpleCustom.ElectricCmdBase
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 slotId; // 0x10
	WizardGames.Soc.Common.CustomType.Alpha3ElectricCircuitSlot Slot; // 0x18
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06de5af8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06de5b9c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06de5e04
	System.Void .ctor(); // 0x06de60f0
	System.Void ApplyCmd_IC(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit); // 0x06de6178
	System.Boolean GenRevertCmd(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit, WizardGames.Soc.Common.SimpleCustom.ICmd& rcmd); // 0x06de6210
	System.Boolean OfflineVerify(); // 0x06de632c
	System.Boolean OnlineVerify_IC(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit); // 0x06de6390
	static System.Void .cctor(); // 0x06de6408
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ICCmd_SlotRename : WizardGames.Soc.Common.SimpleCustom.ElectricCmdBase
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.String Name; // 0x10
	System.Int32 SlotId; // 0x18
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06de659c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06de6640
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06de6858
	System.Void .ctor(); // 0x06de6b20
	System.Void ApplyCmd_IC(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit); // 0x06de6ba8
	System.Boolean GenRevertCmd(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit, WizardGames.Soc.Common.SimpleCustom.ICmd& rcmd); // 0x06de6c70
	System.Boolean OfflineVerify(); // 0x06de6d9c
	System.Boolean OnlineVerify_IC(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit); // 0x06de6e00
	static System.Void .cctor(); // 0x06de6ea8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ICCmd_UnitAdd : WizardGames.Soc.Common.SimpleCustom.ElectricCmdBase
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	WizardGames.Soc.Common.CustomType.ElectricFakeEntity Unit; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06de703c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06de70e0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06de732c
	System.Void .ctor(); // 0x06de75fc
	System.Void ApplyCmd_IC(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit); // 0x06de7684
	System.Boolean GenRevertCmd(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit, WizardGames.Soc.Common.SimpleCustom.ICmd& rcmd); // 0x06de7ae0
	System.Boolean OfflineVerify(); // 0x06de7bb4
	System.Boolean OnlineVerify_IC(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit); // 0x06de7c18
	static System.Void .cctor(); // 0x06de7ce8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ICCmd_UnitRemove : WizardGames.Soc.Common.SimpleCustom.ElectricCmdBase
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 UnitId; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06de7f94
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06de803c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06de822c
	System.Void .ctor(); // 0x06de84d8
	System.Void ApplyCmd_IC(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit); // 0x06de8564
	System.Boolean GenRevertCmd(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit, WizardGames.Soc.Common.SimpleCustom.ICmd& rcmd); // 0x06de92b4
	System.Boolean OfflineVerify(); // 0x06de9344
	System.Boolean OnlineVerify_IC(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit); // 0x06de93a8
	static System.Void .cctor(); // 0x06de9450
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ICCmd_WireAdd : WizardGames.Soc.Common.SimpleCustom.ElectricCmdBase
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	WizardGames.Soc.Common.CustomType.Alpha3ElectricUnitWire Wire; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06de95b0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06de9658
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06de98a4
	System.Void .ctor(); // 0x06de9b74
	System.Void ApplyCmd_IC(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit); // 0x06de9c00
	System.Void FillRevertCmd(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit, WizardGames.Soc.Common.SimpleCustom.ElectricCmd_Multi revertCmd); // 0x06de9c98
	System.Boolean GenRevertCmd(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit, WizardGames.Soc.Common.SimpleCustom.ICmd& rcmd); // 0x06de9d38
	System.Boolean OfflineVerify(); // 0x06de9f6c
	System.Boolean OnlineVerify_IC(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit); // 0x06dea024
	static System.Void .cctor(); // 0x06dea0bc
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ICCmd_WireRemove : WizardGames.Soc.Common.SimpleCustom.ElectricCmdBase
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 UnitId; // 0x10
	System.Int32 PortId; // 0x18
	WizardGames.Soc.Common.CustomType.Alpha3ElectricUnitWire wire; // 0x20
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dea21c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dea2c4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dea4d0
	System.Void .ctor(); // 0x06de9ee0
	System.Void ApplyCmd_IC(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit); // 0x06dea798
	System.Boolean GenRevertCmd(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit, WizardGames.Soc.Common.SimpleCustom.ICmd& rcmd); // 0x06dea830
	System.Boolean OfflineVerify(); // 0x06dea94c
	System.Boolean OnlineVerify_IC(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit); // 0x06dea9b0
	System.Void ClearCache(); // 0x06deaa48
	static System.Void .cctor(); // 0x06deaac0
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.IntDictionaryData : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> Inner; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06deac54
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06deace8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06deaf4c
	static System.Void .cctor(); // 0x06deb254
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.IntHashSetData : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.HashSet<System.Int32> Inner; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06deb3b4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06deb448
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06deb6ac
	System.Void .ctor(); // 0x06deb9b4
	static System.Void .cctor(); // 0x06deba68
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.IntListData : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.List<System.Int32> Inner; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06debbc8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06debc5c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06debec0
	static System.Void .cctor(); // 0x06dec1c8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.KillPlayerNodeExecutor : WizardGames.Soc.Common.SimpleCustom.GraphNodeExecutorBase
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 PlayerEntityId; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dec328
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dec3d0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dec5c0
	static System.Void .cctor(); // 0x06dec86c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.KOLPlayerInfo : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.String NickName; // 0x10
	System.String Portrait; // 0x18
	System.UInt32 PortraitFrame; // 0x20
	System.Int32 Level; // 0x24
	System.Byte PlayerState; // 0x28
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dec9cc
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06deca60
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06deccdc
	static System.Void .cctor(); // 0x06decff4
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.LifeCycleFlagEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 LifeCycleFlags; // 0x38
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ded224
	System.Int32 GetClassHash(); // 0x06ded2d0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06ded338
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06ded584
	System.Void .ctor(); // 0x06ded880
	static WizardGames.Soc.Common.SimpleCustom.LifeCycleFlagEvent NewEvent(); // 0x06ded90c
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06ded984
	System.Void Dispose(); // 0x06deda38
	static System.Void .cctor(); // 0x06dedaa8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ListIntCustom : System.Object, WizardGames.Soc.Common.Cache.IPooledObject, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Common.SimpleCustom.ListIntCustom> Pool; // 0x18
	System.Collections.Generic.List<System.Int32> Data; // 0x10
	System.Boolean <IsReturn>k__BackingField; // 0x18
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dedca4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dedd38
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dedf9c
	System.Void .ctor(); // 0x06dee2a4
	System.Boolean get_IsReturn(); // 0x06dee358
	System.Void set_IsReturn(System.Boolean value); // 0x06dee3bc
	System.Void ReturnToPool(); // 0x06dee438
	static System.Void .cctor(); // 0x06dee50c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.LoginBaseInfo : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 VoiceRegion; // 0x10
	System.Int32 BattleId; // 0x14
	System.Int32 XMapOffset; // 0x18
	System.Int32 ZMapOffset; // 0x1c
	System.Int32 GridSize; // 0x20
	System.Int32 XSize; // 0x24
	System.Int32 ZSize; // 0x28
	System.Boolean IsObserver; // 0x2c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dee6c4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dee758
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06deea28
	System.Void .ctor(); // 0x06deed68
	System.String ToString(); // 0x06deedd0
	static System.Void .cctor(); // 0x06def034
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.LoginInfo : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 RpcVersion; // 0x10
	System.Int32 EntityVersionVerifyCode; // 0x14
	System.Int32 RpcCustomTypeVersion; // 0x18
	System.Int32 NetworkVersion; // 0x1c
	System.Int64 ResourceVersion; // 0x20
	System.Int64 PeerLocalTimeMs; // 0x28
	System.String ReportData2; // 0x30
	System.String OpenId; // 0x38
	System.String Channel; // 0x40
	System.String PlatId; // 0x48
	System.String ChannelId; // 0x50
	System.Int32 LanguageId; // 0x58
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06def300
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06def394
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06def6fc
	System.Void .ctor(); // 0x06defa88
	static System.Void .cctor(); // 0x06defaf0
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.LoginResult : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Boolean Success; // 0x10
	System.Int32 Code; // 0x14
	System.UInt64 RoleId; // 0x18
	System.Int64 Param; // 0x20
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06defe8c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06deff20
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06df0170
	static System.Void .cctor(); // 0x06df0478
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.MagicFieldCreateEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 TemplateId; // 0x38
	System.Single PosY; // 0x3c
	System.Boolean IsBullet; // 0x40
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df0674
	System.Int32 GetClassHash(); // 0x06df0720
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df0788
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06df0a10
	System.Void .ctor(); // 0x06df0d38
	static WizardGames.Soc.Common.SimpleCustom.MagicFieldCreateEvent NewEvent(); // 0x06df0dc4
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06df0e3c
	System.Void Dispose(); // 0x06df0f00
	static System.Void .cctor(); // 0x06df0f78
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.MakePlayerRebornNodeExecutor : WizardGames.Soc.Common.SimpleCustom.GraphNodeExecutorBase
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 PlayerEntityId; // 0x10
	WizardGames.Soc.Common.SimpleCustom.SimpleVector3 Center; // 0x18
	System.Single Range; // 0x20
	System.Boolean IsOnGround; // 0x24
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df11dc
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df1284
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06df1530
	static System.Void .cctor(); // 0x06df1858
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.MedalRecordInfo : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 MedalId; // 0x10
	System.Int32 Level; // 0x14
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df1a54
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df1ae8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06df1cf4
	static System.Void .cctor(); // 0x06df1fb8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.MeleeHitData : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1035387324;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 TargetID; // 0x10
	System.Int32 ColliderIndex; // 0x18
	System.Numerics.Vector3 Point; // 0x1c
	System.Numerics.Vector3 HitNormal; // 0x28
	System.Int32 MaterialType; // 0x34
	System.Single Damage; // 0x38
	System.Int32 BonusLevel; // 0x3c
	System.UInt32 Hash; // 0x40
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df214c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df21e8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06df2568
	System.Void OnGet(); // 0x06df2938
	System.Void OnRelease(); // 0x06df2998
	System.Void OnDestroy(); // 0x06df29f8
	System.Void .ctor(); // 0x06df2a58
	System.Boolean ValueEquals(WizardGames.Soc.Common.SimpleCustom.MeleeHitData other); // 0x06df2ac8
	static WizardGames.Soc.Common.SimpleCustom.MeleeHitData MakeHitData(WizardGames.Soc.Common.SimpleCustom.HitRequest hit); // 0x06df2c10
	static System.Void .cctor(); // 0x06df2d9c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.MergeMagicFieldEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.List<System.Int64> MergeMagicFieldIDList; // 0x38
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df3068
	System.Int32 GetClassHash(); // 0x06df3114
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df317c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06df3444
	System.Void .ctor(); // 0x06df379c
	static WizardGames.Soc.Common.SimpleCustom.MergeMagicFieldEvent NewEvent(); // 0x06df3828
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06df38a0
	static System.Void .cctor(); // 0x06df3954
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.MonsterBulletRequestData : Share.Common.ObjPool.Alpha3PooledObjectBase, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Single DirectionX; // 0x1c
	System.Single DirectionY; // 0x20
	System.Single DirectionZ; // 0x24
	System.Single PositionX; // 0x28
	System.Single PositionY; // 0x2c
	System.Single PositionZ; // 0x30
	System.Single InitialVelocity; // 0x34
	System.Int64 OwnerEntityId; // 0x38
	System.Int64 OwnerTableId; // 0x40
	System.Int64 HeldItemEntityID; // 0x48
	System.Int32 Sequence; // 0x50
	System.Int64 LagCompensationTime; // 0x58
	System.Single LogicPositionX; // 0x60
	System.Single LogicPositionY; // 0x64
	System.Single LogicPositionZ; // 0x68
	System.Single DamageScale; // 0x6c
	System.Int64 WeaponTableId; // 0x70
	System.Int64 AmmoTableId; // 0x78
	System.Int32 BulletIndex; // 0x80
	System.Boolean MagicBullet; // 0x84
	System.Boolean IsServerBullet; // 0x85
	System.Int32 PveAttFix; // 0x88
	System.Single SourcePositionX; // 0x8c
	System.Single SourcePositionY; // 0x90
	System.Single SourcePositionZ; // 0x94
	System.Int64 TargetEntityId; // 0x98
	System.Single TargetPredictionPosX; // 0xa0
	System.Single TargetPredictionPosY; // 0xa4
	System.Single TargetPredictionPosZ; // 0xa8
	System.Int32 SourceMonumentId; // 0xac
	System.Single SourceAdsProgress; // 0xb0
	System.Int32 SourceMoveState; // 0xb4
	System.Int32 SourcePoseState; // 0xb8
	System.Int64 SkinId; // 0xc0
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df3b50
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df3bec
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06df4094
	System.Void .ctor(); // 0x06df4488
	static System.Void .cctor(); // 0x06df44f8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.MonsterFireDataSingle : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int16 DirX; // 0x10
	System.Int16 DirY; // 0x12
	System.Int16 DirZ; // 0x14
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df4cf8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df4d8c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06df4fb4
	static System.Void .cctor(); // 0x06df528c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.MonsterFireEventData : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 OwnerId; // 0x38
	System.Int32 SlotId; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.MonsterFireDataSingle> BulletDataArray; // 0x48
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.MonsterBulletRequestData> BulletRequestData; // 0x50
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df5454
	System.Int32 GetClassHash(); // 0x06df5508
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df5570
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06df5900
	System.Void .ctor(); // 0x06df5ce8
	static WizardGames.Soc.Common.SimpleCustom.MonsterFireEventData NewEvent(); // 0x06df5d7c
	System.Void Dispose(); // 0x06df5e3c
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06df5eb8
	static System.Void .cctor(); // 0x06df5f8c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.MonsterFireRequest : Share.Common.ObjPool.Alpha3PooledObjectBase, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 EntityId; // 0x20
	System.Int64 TargetId; // 0x28
	System.Int64 TargetVehicleId; // 0x30
	System.Int32 Sequence; // 0x38
	System.Boolean NoTargetShoot; // 0x3c
	System.Single MuzzlePosX; // 0x40
	System.Single MuzzlePosY; // 0x44
	System.Single MuzzlePosZ; // 0x48
	System.Single ShootType; // 0x4c
	System.Single ShootPosX; // 0x50
	System.Single ShootPosY; // 0x54
	System.Single ShootPosZ; // 0x58
	System.Single TargetPredictionPosX; // 0x5c
	System.Single TargetPredictionPosY; // 0x60
	System.Single TargetPredictionPosZ; // 0x64
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df6224
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df62b8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06df65e0
	System.Void .ctor(); // 0x06df693c
	System.Void Dispose(); // 0x06df69a4
	static System.Void .cctor(); // 0x06df6a0c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.MonumentEventCustomData : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 ActionId; // 0x10
	System.Int64 EventId; // 0x18
	System.Int32 MonumentId; // 0x20
	System.Int64 EntityId; // 0x28
	System.Int64 StartTime; // 0x30
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df6e44
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df6ed8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06df7140
	System.Void .ctor(); // 0x06df7440
	static System.Void .cctor(); // 0x06df74a8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.MonumentTaskState : Share.Common.ObjPool.Alpha3PooledObjectBase, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 taskID; // 0x1c
	System.Int32 taskState; // 0x20
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df76d8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df776c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06df7978
	System.Void .ctor(); // 0x06df7c3c
	static System.Void .cctor(); // 0x06df7ca4
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.MovePlayersNodeExecutor : WizardGames.Soc.Common.SimpleCustom.GraphNodeExecutorBase
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 PlayerEntityId; // 0x10
	WizardGames.Soc.Common.SimpleCustom.SimpleVector3 Center; // 0x18
	System.Single RotY; // 0x20
	System.Single Range; // 0x24
	System.Boolean IsOnGround; // 0x28
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df7e38
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df7ee0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06df81a8
	static System.Void .cctor(); // 0x06df84e0
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.NodeCfg : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 Id; // 0x10
	System.String DebugTypeName; // 0x18
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df8710
	static WizardGames.Soc.Common.SimpleCustom.NodeCfg NodeCfgConstructor(); // 0x06df8794
	System.Void .ctor(); // 0x06df8814
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df887c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06df8a94
	static System.Void .cctor(); // 0x06df8d5c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.OpenDoorEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df8ef0
	System.Int32 GetClassHash(); // 0x06df8f9c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df9004
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06df922c
	System.Void .ctor(); // 0x06df9504
	static WizardGames.Soc.Common.SimpleCustom.OpenDoorEvent NewEvent(); // 0x06df9590
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06df9608
	System.Void Dispose(); // 0x06df96b0
	static System.Void .cctor(); // 0x06df9718
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.PickAndDropSuccessEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 ItemTemplateId; // 0x38
	System.Boolean IsDrop; // 0x40
	System.Single PosY; // 0x44
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df98e0
	System.Int32 GetClassHash(); // 0x06df998c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06df99f4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06df9c7c
	System.Void Dispose(); // 0x06df9f98
	System.Void .ctor(); // 0x06dfa000
	static WizardGames.Soc.Common.SimpleCustom.PickAndDropSuccessEvent NewEvent(); // 0x06dfa08c
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06dfa104
	static System.Void .cctor(); // 0x06dfa1c4
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.PickUpEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dfa428
	System.Int32 GetClassHash(); // 0x06dfa4d4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dfa53c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dfa764
	System.Void Dispose(); // 0x06dfaa3c
	System.Void .ctor(); // 0x06dfaaa4
	static WizardGames.Soc.Common.SimpleCustom.PickUpEvent NewEvent(); // 0x06dfab30
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06dfaba8
	static System.Void .cctor(); // 0x06dfac50
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.PlayerBriefInfo : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.String Name; // 0x10
	System.String Portrait; // 0x18
	System.UInt64 RoleId; // 0x20
	System.Boolean IsOnline; // 0x28
	System.Int32 Level; // 0x2c
	System.UInt32 PortraitFrame; // 0x30
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dfae18
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dfaeac
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dfb148
	System.Void .ctor(System.UInt64 roleId, System.String name, System.String portrait, System.Boolean isOnline, System.UInt32 portraitFrame, System.Int32 level); // 0x06dfb47c
	static System.Void .cctor(); // 0x06dfb56c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.PlayerDisplaySimple : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.EquipmentSimple> EquipmentDisplayDatas; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.WeaponSimple> WeaponDisplayDatas; // 0x18
	System.UInt64 RoleId; // 0x20
	System.Int32 Sex; // 0x28
	System.Int32 FaceId; // 0x2c
	System.Int32 HairId; // 0x30
	System.Int32 HairColorId; // 0x34
	System.Boolean PlayStartAnim; // 0x38
	System.Boolean PlaySpecialIdleAnim; // 0x39
	System.String Name; // 0x40
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dfb7d0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dfb864
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dfbc60
	static System.Void .cctor(); // 0x06dfc08c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.PlayerInteractiveEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 InteractiveID; // 0x38
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dfc3c0
	System.Int32 GetClassHash(); // 0x06dfc46c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dfc4d4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dfc720
	System.Void .ctor(); // 0x06dfca1c
	static WizardGames.Soc.Common.SimpleCustom.PlayerInteractiveEvent NewEvent(); // 0x06dfcaa8
	System.Void Dispose(); // 0x06dfcb20
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06dfcb90
	static System.Void .cctor(); // 0x06dfcc40
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.PlayKnockDoorAudioEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 KnockDoorAudioIndex; // 0x38
	System.Int64 PartEntityId; // 0x40
	System.Single PosY; // 0x48
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dfce3c
	System.Int32 GetClassHash(); // 0x06dfcee8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dfcf50
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dfd1d4
	System.Void Dispose(); // 0x06dfd4f0
	System.Void .ctor(); // 0x06dfd558
	static WizardGames.Soc.Common.SimpleCustom.PlayKnockDoorAudioEvent NewEvent(); // 0x06dfd5e4
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06dfd65c
	static System.Void .cctor(); // 0x06dfd71c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.PlayLockEffectEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 EffectType; // 0x38
	System.Int64 ParentPartEntityId; // 0x40
	System.Single PosY; // 0x48
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dfd980
	System.Int32 GetClassHash(); // 0x06dfda2c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dfda94
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dfdd18
	System.Void Dispose(); // 0x06dfe034
	System.Void .ctor(); // 0x06dfe09c
	static WizardGames.Soc.Common.SimpleCustom.PlayLockEffectEvent NewEvent(); // 0x06dfe128
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06dfe1a0
	static System.Void .cctor(); // 0x06dfe260
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.PlayPartSkinAnimationEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 EntityId; // 0x38
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dfe4c4
	System.Int32 GetClassHash(); // 0x06dfe570
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dfe5d8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dfe824
	System.Void Dispose(); // 0x06dfeb14
	System.Void .ctor(); // 0x06dfeb7c
	static WizardGames.Soc.Common.SimpleCustom.PlayPartSkinAnimationEvent NewEvent(); // 0x06dfec08
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06dfec80
	static System.Void .cctor(); // 0x06dfed30
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.PortCfg : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.String Name; // 0x10
	System.String DisplayName; // 0x18
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dfef2c
	static WizardGames.Soc.Common.SimpleCustom.PortCfg PortCfgConstructor(); // 0x06dfefb0
	System.Void .ctor(); // 0x06dff030
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dff098
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dff2b8
	static System.Void .cctor(); // 0x06dff57c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ProjectileHitData : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 562145862;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 ProjectileIdentifier; // 0x10
	System.Int64 TargetID; // 0x18
	System.Int32 ColliderIndex; // 0x20
	System.Numerics.Vector3 Point; // 0x24
	System.Numerics.Vector3 HitNormal; // 0x30
	System.Numerics.Vector3 OffsetPoint; // 0x3c
	System.Numerics.Vector3 OffsetQuaternion; // 0x48
	System.Numerics.Vector3 OBBPoint; // 0x54
	System.Int32 MaterialType; // 0x60
	System.Int32 BallasticID; // 0x64
	System.UInt32 Hash; // 0x68
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dff710
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06dff7a4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06dffc38
	System.Void .ctor(); // 0x06e00044
	System.Boolean ValueEquals(WizardGames.Soc.Common.SimpleCustom.ProjectileHitData other); // 0x06e000ac
	System.Void OnGet(); // 0x06e00284
	System.Void OnRelease(); // 0x06e002e4
	System.Void OnDestroy(); // 0x06e00344
	static System.Void .cctor(); // 0x06e003a4
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.PureGoDataEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent, WizardGames.Soc.Common.Cache.ICacheObject
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 TargetId; // 0x38
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e0070c
	System.Int32 GetClassHash(); // 0x06e007b8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e00820
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e00a6c
	System.Void .ctor(); // 0x06e00d68
	static WizardGames.Soc.Common.SimpleCustom.PureGoDataEvent NewEvent(); // 0x06e00df4
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06e00e6c
	System.Void Dispose(); // 0x06e00f1c
	static System.Void .cctor(); // 0x06e00f84
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.QuickDrawEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e01180
	System.Int32 GetClassHash(); // 0x06e0122c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e01294
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e014bc
	System.Void Dispose(); // 0x06e01794
	System.Void .ctor(); // 0x06e017fc
	static WizardGames.Soc.Common.SimpleCustom.QuickDrawEvent NewEvent(); // 0x06e01888
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06e01900
	static System.Void .cctor(); // 0x06e019a8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.RecoverPartResult : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 TerrId; // 0x10
	System.Int32 Code; // 0x18
	System.Collections.Generic.List<System.Int64> Param; // 0x20
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e01b70
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e01c04
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e01ea8
	static System.Void .cctor(); // 0x06e021e8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.RegisterBattleServerModel : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 OnlineNum; // 0x10
	System.Int32 QueueNum; // 0x14
	System.Int32 SaveTime; // 0x18
	System.String Country; // 0x20
	System.Int32 MapId; // 0x28
	System.String ServerName; // 0x30
	System.String ServerIp; // 0x38
	System.Collections.Generic.List<System.Int32> ServerFlags; // 0x40
	System.Int32 CleanupFlag; // 0x48
	System.Int32 MaxOnlineNum; // 0x4c
	System.Int32 MaxTotalNum; // 0x50
	System.Int32 PlayStage; // 0x54
	System.Int32 BattleId; // 0x58
	System.Int32 TcpPort; // 0x5c
	System.Int32 UdpPort; // 0x60
	System.Int32 TotalNum; // 0x64
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e023b0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e02444
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e02810
	System.Void .ctor(); // 0x06e02bc8
	static System.Void .cctor(); // 0x06e02c30
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.RegisterServiceAckParam : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 MapId; // 0x10
	System.Int32 BattleId; // 0x14
	System.Int32 XSize; // 0x18
	System.Int32 ZSize; // 0x1c
	System.Int32 GridSize; // 0x20
	System.Int32 XMapOffset; // 0x24
	System.Int32 ZMapOffset; // 0x28
	System.UInt32 SimulatorIdSequence; // 0x2c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e0309c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e03130
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e033fc
	static System.Void .cctor(); // 0x06e0373c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ReplayUserCmd : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.Cache.IPooledObject
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.Common.SimpleCustom.ReplayUserCmd> pool; // 0x18
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
	System.Single JoystickYaw; // 0x50
	System.Single GunkickYaw; // 0x54
	System.Single GunkickPitch; // 0x58
	System.Int32 ReloadAmmoId; // 0x5c
	System.Int64 ReloadAmmoNodeId; // 0x60
	System.UInt64 ButtonBits1; // 0x68
	System.UInt64 ButtonBits2; // 0x70
	System.Byte InteractionType; // 0x78
	System.Single MagicYawOffset; // 0x7c
	System.Single MagicPitchOffset; // 0x80
	System.Single LittleEyeGoPosX; // 0x84
	System.Single LittleEyeGoPosY; // 0x88
	System.Single LittleEyeGoPosZ; // 0x8c
	System.Single PosX; // 0x90
	System.Single PosY; // 0x94
	System.Single PosZ; // 0x98
	System.Boolean NeedClientAuthority; // 0x9c
	System.Int64 PlatformId; // 0xa0
	System.Single PlatformX; // 0xa8
	System.Single PlatformY; // 0xac
	System.Single PlatformZ; // 0xb0
	System.Int32 CollisionFlags; // 0xb4
	System.Boolean IsGrounded; // 0xb8
	System.Single NormalX; // 0xbc
	System.Single NormalY; // 0xc0
	System.Single NormalZ; // 0xc4
	System.Int64 ClientAuthorityTimeAck; // 0xc8
	System.Byte PoseState; // 0xd0
	System.Byte MoveState; // 0xd1
	System.Byte MoveJumpState; // 0xd2
	System.Byte MoveSwimState; // 0xd3
	System.Byte MoveLadderState; // 0xd4
	System.Byte MoveMantleState; // 0xd5
	System.Byte AdsState; // 0xd6
	System.Int32 SwipeCardIndex; // 0xd8
	System.Single JoystickPercent; // 0xdc
	System.Boolean MagicBulletFlag; // 0xe0
	System.Boolean <IsReturn>k__BackingField; // 0xe1
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e03a08
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e03a9c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e04060
	System.Boolean get_IsReturn(); // 0x06e044dc
	System.Void set_IsReturn(System.Boolean value); // 0x06e04540
	System.Void .ctor(); // 0x06e045bc
	System.Void Dispose(); // 0x06e04624
	System.Void ReturnToPool(); // 0x06e046d0
	System.Void CopyToCmd(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x06e0478c
	static System.Void .cctor(); // 0x06e049b0
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ResetPlayerState : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 SourceEntityType; // 0x10
	System.Byte PoseState; // 0x14
	WizardGames.Soc.Common.SimpleCustom.SimpleVector3 Pos; // 0x18
	System.Single MoveYaw; // 0x20
	System.Single ViewYaw; // 0x24
	System.Single ViewPitch; // 0x28
	System.Single Hp; // 0x2c
	System.Single Calories; // 0x30
	System.Single Hydration; // 0x34
	System.Single RadiationPoison; // 0x38
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e054a8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e0553c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e0589c
	static System.Void .cctor(); // 0x06e05f0c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.RootMotionData : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 286576957;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Single RTPosX0; // 0x10
	System.Single RTPosY0; // 0x14
	System.Single RTPosZ0; // 0x18
	System.Single RTRotY0; // 0x1c
	System.Single RTPosX1; // 0x20
	System.Single RTPosY1; // 0x24
	System.Single RTPosZ1; // 0x28
	System.Single RTRotY1; // 0x2c
	System.Single RTPosX2; // 0x30
	System.Single RTPosY2; // 0x34
	System.Single RTPosZ2; // 0x38
	System.Single RTRotY2; // 0x3c
	System.Single RTPosX3; // 0x40
	System.Single RTPosY3; // 0x44
	System.Single RTPosZ3; // 0x48
	System.Single RTRotY3; // 0x4c
	System.Single RTPosX4; // 0x50
	System.Single RTPosY4; // 0x54
	System.Single RTPosZ4; // 0x58
	System.Single RTRotY4; // 0x5c
	System.Boolean WantCrouchPose; // 0x60
	System.Boolean MantleOnPlatform; // 0x61
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e06240
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e062d4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e0668c
	System.Void .ctor(); // 0x06e06a08
	System.Void Clear(); // 0x06e06a70
	System.Void DeepCopy(WizardGames.Soc.Common.SimpleCustom.RootMotionData rootMotionData); // 0x06e06ae4
	System.Boolean ValueEquals(WizardGames.Soc.Common.SimpleCustom.RootMotionData rootMotionData); // 0x06e06b90
	static System.Void .cctor(); // 0x06e06d68
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.RuleGraphCfg : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 Id; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.NodeCfg> NodeCfgList; // 0x18
	System.Collections.Generic.List<System.Int32> EventList; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.VariableCfg> VarList; // 0x28
	WizardGames.Soc.Common.SimpleCustom.EServerType ServerType; // 0x30
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e0730c
	static WizardGames.Soc.Common.SimpleCustom.RuleGraphCfg RuleGraphCfgConstructor(); // 0x06e07744
	System.Void .ctor(); // 0x06e077c4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e073a0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e0782c
	static System.Void .cctor(); // 0x06e07c18
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.RuleGraphCopy : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.NodeCfg> Nodes; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.RuleGraphEdgeCopy> Edges; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.VariableCfg> Variables; // 0x20
	WizardGames.Soc.Common.SimpleCustom.SocRuleGraphEditorSettings EditorSettings; // 0x28
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e07e48
	static WizardGames.Soc.Common.SimpleCustom.RuleGraphCopy RuleGraphCopyConstructor(); // 0x06e082bc
	System.Void .ctor(); // 0x06e0833c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e07edc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e083a4
	static System.Void .cctor(); // 0x06e08b84
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.RuleGraphEdgeCopy : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.String SrcNodeId; // 0x10
	System.String SrcPortId; // 0x18
	System.String DstNodeId; // 0x20
	System.String DstPortId; // 0x28
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e08d80
	static WizardGames.Soc.Common.SimpleCustom.RuleGraphEdgeCopy RuleGraphEdgeCopyConstructor(); // 0x06e09084
	System.Void .ctor(); // 0x06e09104
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e08e14
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e0916c
	static System.Void .cctor(); // 0x06e09468
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.RunGraphCfg : WizardGames.Soc.Common.SimpleCustom.NodeCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.String GraphPath; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.FlowPortCfg> GraphFlowInputPorts; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.FlowPortCfg> GraphFlowOutputPorts; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.DataPortCfg> GraphDataInputPorts; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.VarGuidPortCfg> GraphDataOutputPorts; // 0x40
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e09664
	static WizardGames.Soc.Common.SimpleCustom.RunGraphCfg RunGraphCfgConstructor(); // 0x06e0970c
	System.Void .ctor(); // 0x06e0978c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e09818
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e09c64
	static System.Void .cctor(); // 0x06e0a090
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SearchPlayerInfo : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.UInt64 RoleId; // 0x10
	System.String Name; // 0x18
	System.String Portrait; // 0x20
	System.Int32 Level; // 0x28
	System.UInt32 PortraitFrame; // 0x2c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e0a328
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e0a3bc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e0a638
	static System.Void .cctor(); // 0x06e0a950
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SecAimFlowTLogInfo : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 BattleLogClientStartTime; // 0x10
	System.String AimTime; // 0x18
	System.String ShotCDTime; // 0x20
	System.Int32 ShotCount; // 0x28
	System.Int32 ShotHitCount; // 0x2c
	System.Int32 ShotHeadHitCount; // 0x30
	System.Int32 ShotPersonHitCount; // 0x34
	System.Int32 ShotPersonKillCount; // 0x38
	System.String HitDistance; // 0x40
	System.String HitEachDistance; // 0x48
	System.String HitAngle; // 0x50
	System.String HitEachCdTime; // 0x58
	System.String HitPartInfo; // 0x60
	System.String AimPose; // 0x68
	System.String SightType; // 0x70
	System.Int32 ViewingHeightMax; // 0x78
	System.Int32 ViewingHeightMin; // 0x7c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e0ab80
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e0acc4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e0b05c
	System.Void OnGet(); // 0x06e0b3bc
	System.Void OnRelease(); // 0x06e0b41c
	System.Void OnDestroy(); // 0x06e0b538
	static System.Void .cctor(); // 0x06e0b598
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SetPlayerInvincibleNodeExecutor : WizardGames.Soc.Common.SimpleCustom.GraphNodeExecutorBase
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 PlayerEntityId; // 0x10
	System.Boolean IsInvincible; // 0x18
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e0ba38
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e0bae0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e0bcf0
	static System.Void .cctor(); // 0x06e0bfb8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SetPlayerStatusNodeExecutor : WizardGames.Soc.Common.SimpleCustom.GraphNodeExecutorBase
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 PlayerEntityId; // 0x10
	WizardGames.Soc.Common.SimpleCustom.ResetPlayerState ResetData; // 0x18
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e0c14c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e0c1f4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e0c45c
	static System.Void .cctor(); // 0x06e0c740
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ShowUpkeepInfoToClientEvent : WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Single KeepTime; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> Amounts; // 0x40
	System.Int64 BuildingPrivilegeEntityId; // 0x48
	System.Single PosY; // 0x50
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e0c8d4
	System.Int32 GetClassHash(); // 0x06e0c9cc
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e0ca34
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e0cd58
	System.Void Dispose(); // 0x06e0d0ec
	System.Void .ctor(); // 0x06e0d154
	static WizardGames.Soc.Common.SimpleCustom.ShowUpkeepInfoToClientEvent NewEvent(); // 0x06e0d22c
	WizardGames.Soc.Common.SimpleCustom.AbstractLocationBasedEvent Clone(); // 0x06e0d2a4
	static System.Void .cctor(); // 0x06e0d378
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SimBotSpawnRecord : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 BotTemplateId; // 0x10
	System.Int64 OreTemplateId; // 0x18
	System.Single InnerRange; // 0x20
	System.Single OuterRange; // 0x24
	System.Int32 BotType; // 0x28
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e0d610
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e0d6a4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e0d90c
	static System.Void .cctor(); // 0x06e0dc18
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SimpleCreatePartData : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 partType; // 0x10
	WizardGames.Soc.Common.SimpleCustom.SimpleVector3 pos; // 0x18
	WizardGames.Soc.Common.SimpleCustom.SimpleVector3 angle; // 0x20
	System.Int64 targetPartId; // 0x28
	System.Int32 targetSocketId; // 0x30
	System.Int32 holdingPartInChargeSocketId; // 0x34
	System.Int64 itemUid; // 0x38
	System.Int64 markId; // 0x40
	System.Boolean requestCreateRelatedPart; // 0x48
	System.Int32 grade; // 0x4c
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e0de48
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e0dedc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e0e264
	System.Void .ctor(); // 0x06e0e5fc
	static System.Void .cctor(); // 0x06e0e664
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SimpleDataObject : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Byte Type; // 0x10
	System.Int64 BasicValue; // 0x18
	System.String StringValue; // 0x20
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e0e998
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e0ea2c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e0ec60
	System.Void .ctor(); // 0x06e0ef44
	static System.Void .cctor(); // 0x06e0efac
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.CustomEventParamCfg : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable, WizardGames.Soc.Common.RuleGraph.IConvert<WizardGames.Soc.Share.Framework.CustomTypeBase>
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	WizardGames.Soc.Common.SimpleCustom.EEventParamsType ParamType; // 0x10
	System.Boolean BoolValue; // 0x14
	System.Int64 LongValue; // 0x18
	System.Single FloatValue; // 0x20
	System.String StringValue; // 0x28
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e0f174
	static WizardGames.Soc.Common.SimpleCustom.CustomEventParamCfg CustomEventParamCfgConstructor(); // 0x06e0f480
	System.Void .ctor(); // 0x06e0f500
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e0f208
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e0f568
	System.Void CopyFrom(WizardGames.Soc.Share.Framework.CustomTypeBase _); // 0x06e0f88c
	static System.Void .cctor(); // 0x06e0f9b4
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.CustomTypeExampleCfg : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable, WizardGames.Soc.Common.RuleGraph.IConvert<WizardGames.Soc.Share.Framework.CustomTypeBase>
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 LongValue; // 0x10
	System.Collections.Generic.List<System.Int64> LongListValue; // 0x18
	System.Single FloatValue; // 0x20
	System.Boolean BoolValue; // 0x24
	System.String StrValue; // 0x28
	System.Int64 Var; // 0x30
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e0fbe4
	static WizardGames.Soc.Common.SimpleCustom.CustomTypeExampleCfg CustomTypeExampleCfgConstructor(); // 0x06e0ff84
	System.Void .ctor(); // 0x06e10004
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e0fc78
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e1006c
	System.Void CopyFrom(WizardGames.Soc.Share.Framework.CustomTypeBase _); // 0x06e103fc
	static System.Void .cctor(); // 0x06e10580
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.InitStatPanelDataCfg : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable, WizardGames.Soc.Common.RuleGraph.IConvert<WizardGames.Soc.Share.Framework.CustomTypeBase>
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1441409456;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	WizardGames.Soc.Common.SimpleCustom.EStatPanelDisplayableMode Mode; // 0x10
	WizardGames.Soc.Common.SimpleCustom.MultiLangStringBuilderCfg Title; // 0x18
	System.Int64 StatRoleIds; // 0x20
	System.Int64 RoleIdToTeamId; // 0x28
	System.Boolean EnableRanking; // 0x30
	System.Int64 RoleRanking; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.StatTeamDataCfg> TeamDatas; // 0x40
	System.Int64 TeamIdToPoints; // 0x48
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.StatDynamicFieldsCfg> StatDynamicField; // 0x50
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e107e4
	static WizardGames.Soc.Common.SimpleCustom.InitStatPanelDataCfg InitStatPanelDataCfgConstructor(); // 0x06e10c98
	System.Void .ctor(); // 0x06e10d18
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e10878
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e10d80
	static WizardGames.Soc.Common.SimpleCustom.InitStatPanelDataCfg op_Implicit(WizardGames.Soc.Common.CustomType.InitStatPanelData source); // 0x06e114e4
	System.Void CopyFrom(WizardGames.Soc.Share.Framework.CustomTypeBase _); // 0x06e11594
	static System.Void .cctor(); // 0x06e11864
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.ItemCountCfg : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable, WizardGames.Soc.Common.RuleGraph.IConvert<WizardGames.Soc.Share.Framework.CustomTypeBase>
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int32 ItemId; // 0x10
	System.Int32 Count; // 0x14
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e11b64
	static WizardGames.Soc.Common.SimpleCustom.ItemCountCfg ItemCountCfgConstructor(); // 0x06e11e04
	System.Void .ctor(); // 0x06e11e84
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e11bf8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e11eec
	System.Void CopyFrom(WizardGames.Soc.Share.Framework.CustomTypeBase _); // 0x06e121b0
	static System.Void .cctor(); // 0x06e1228c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.MultiLangStringBuilderCfg : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable, WizardGames.Soc.Common.RuleGraph.IConvert<WizardGames.Soc.Share.Framework.CustomTypeBase>
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 471419359;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	WizardGames.Soc.Common.SimpleCustom.MultiLangStringCfg Fmt; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.MultiLangStringCfg> Args; // 0x18
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e12420
	static WizardGames.Soc.Common.SimpleCustom.MultiLangStringBuilderCfg MultiLangStringBuilderCfgConstructor(); // 0x06e12794
	System.Void .ctor(); // 0x06e12814
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e124b4
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e111a8
	static WizardGames.Soc.Common.SimpleCustom.MultiLangStringBuilderCfg op_Implicit(WizardGames.Soc.Common.CustomType.MultiLangStringBuilder source); // 0x06e117b4
	System.Void CopyFrom(WizardGames.Soc.Share.Framework.CustomTypeBase _); // 0x06e12b54
	static System.Void .cctor(); // 0x06e12d84
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.MultiLangStringCfg : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable, WizardGames.Soc.Common.RuleGraph.IConvert<WizardGames.Soc.Share.Framework.CustomTypeBase>
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1919309399;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	WizardGames.Soc.Common.SimpleCustom.EMultiLangStrType StrType; // 0x10
	System.String NormalText; // 0x18
	System.Int32 L10NIndex; // 0x20
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e12f18
	static WizardGames.Soc.Common.SimpleCustom.MultiLangStringCfg MultiLangStringCfgConstructor(); // 0x06e131e0
	System.Void .ctor(); // 0x06e13260
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e12fac
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e1287c
	static WizardGames.Soc.Common.SimpleCustom.MultiLangStringCfg op_Implicit(WizardGames.Soc.Common.CustomType.MultiLangString source); // 0x06e12cd4
	System.Void CopyFrom(WizardGames.Soc.Share.Framework.CustomTypeBase _); // 0x06e132c8
	System.String get_IntermediateText(); // 0x06e133c0
	static System.Void .cctor(); // 0x06e134f4
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.NodeIdCfg : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable, WizardGames.Soc.Common.RuleGraph.IConvert<WizardGames.Soc.Share.Framework.CustomTypeBase>
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 Identify; // 0x10
	System.String NodeName; // 0x18
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e136bc
	static WizardGames.Soc.Common.SimpleCustom.NodeIdCfg NodeIdCfgConstructor(); // 0x06e13968
	System.Void .ctor(); // 0x06e139e8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e13750
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e13a50
	System.Void CopyFrom(WizardGames.Soc.Share.Framework.CustomTypeBase _); // 0x06e13d18
	static System.Void .cctor(); // 0x06e13e0c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SelectableTeamInfoCfg : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable, WizardGames.Soc.Common.RuleGraph.IConvert<WizardGames.Soc.Share.Framework.CustomTypeBase>
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 TeamId; // 0x10
	WizardGames.Soc.Common.SimpleCustom.MultiLangStringBuilderCfg TeamName; // 0x18
	System.Int64 TeamSize; // 0x20
	System.String EventAfterJoin; // 0x28
	System.String BackgroundImagePath; // 0x30
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e13fa0
	static WizardGames.Soc.Common.SimpleCustom.SelectableTeamInfoCfg SelectableTeamInfoCfgConstructor(); // 0x06e14308
	System.Void .ctor(); // 0x06e14388
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e14034
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e143f0
	System.Void CopyFrom(WizardGames.Soc.Share.Framework.CustomTypeBase _); // 0x06e1471c
	static System.Void .cctor(); // 0x06e1488c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.StatDynamicFieldsCfg : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable, WizardGames.Soc.Common.RuleGraph.IConvert<WizardGames.Soc.Share.Framework.CustomTypeBase>
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 1805969431;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	WizardGames.Soc.Common.SimpleCustom.MultiLangStringBuilderCfg StatName; // 0x10
	System.Int64 VarName; // 0x18
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e14abc
	static WizardGames.Soc.Common.SimpleCustom.StatDynamicFieldsCfg StatDynamicFieldsCfgConstructor(); // 0x06e14db8
	System.Void .ctor(); // 0x06e14e38
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e14b50
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e14ea0
	System.Void CopyFrom(WizardGames.Soc.Share.Framework.CustomTypeBase _); // 0x06e15184
	static System.Void .cctor(); // 0x06e152a0
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.StatTeamDataCfg : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable, WizardGames.Soc.Common.RuleGraph.IConvert<WizardGames.Soc.Share.Framework.CustomTypeBase>
{
	static SocLogger logger; // 0x0
	static System.Int32 CLASS_HASH = 2045726179;
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 TeamId; // 0x10
	WizardGames.Soc.Common.SimpleCustom.MultiLangStringCfg TeamName; // 0x18
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e15434
	static WizardGames.Soc.Common.SimpleCustom.StatTeamDataCfg StatTeamDataCfgConstructor(); // 0x06e15730
	System.Void .ctor(); // 0x06e157b0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e154c8
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e15818
	System.Void CopyFrom(WizardGames.Soc.Share.Framework.CustomTypeBase _); // 0x06e15afc
	static System.Void .cctor(); // 0x06e15c24
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.TableBoolFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.TableFieldInfoCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e15db8
	static WizardGames.Soc.Common.SimpleCustom.TableBoolFieldInfoCfg TableBoolFieldInfoCfgConstructor(); // 0x06e15ec4
	System.Void .ctor(); // 0x06e15f44
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e15fcc
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e16248
	System.Void CopyFrom(WizardGames.Soc.Share.Framework.CustomTypeBase _); // 0x06e16554
	static System.Void .cctor(); // 0x06e16708
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.TableFieldInfoCfg : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable, WizardGames.Soc.Common.RuleGraph.IConvert<WizardGames.Soc.Share.Framework.CustomTypeBase>
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	WizardGames.Soc.Common.SimpleCustom.ETableType TableType; // 0x10
	System.String Table; // 0x18
	System.String Field; // 0x20
	System.Int64 Key; // 0x28
	System.Int32 FieldHash; // 0x30
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e16938
	static WizardGames.Soc.Common.SimpleCustom.TableFieldInfoCfg TableFieldInfoCfgConstructor(); // 0x06e169bc
	System.Void .ctor(); // 0x06e15e5c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e16a3c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e16cb8
	System.Void CopyFrom(WizardGames.Soc.Share.Framework.CustomTypeBase _); // 0x06e165e4
	static System.Void .cctor(); // 0x06e16fc4
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.TableFloatArrayFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.TableFieldInfoCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e171f4
	static WizardGames.Soc.Common.SimpleCustom.TableFloatArrayFieldInfoCfg TableFloatArrayFieldInfoCfgConstructor(); // 0x06e17298
	System.Void .ctor(); // 0x06e17318
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e173a0
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e1761c
	System.Void CopyFrom(WizardGames.Soc.Share.Framework.CustomTypeBase _); // 0x06e17928
	static System.Void .cctor(); // 0x06e179b8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.TableFloatFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.TableFieldInfoCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e17be8
	static WizardGames.Soc.Common.SimpleCustom.TableFloatFieldInfoCfg TableFloatFieldInfoCfgConstructor(); // 0x06e17c8c
	System.Void .ctor(); // 0x06e17d0c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e17d94
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e18010
	System.Void CopyFrom(WizardGames.Soc.Share.Framework.CustomTypeBase _); // 0x06e1831c
	static System.Void .cctor(); // 0x06e183ac
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.TableLongArrayFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.TableFieldInfoCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e185dc
	static WizardGames.Soc.Common.SimpleCustom.TableLongArrayFieldInfoCfg TableLongArrayFieldInfoCfgConstructor(); // 0x06e18680
	System.Void .ctor(); // 0x06e18700
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e18788
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e18a04
	System.Void CopyFrom(WizardGames.Soc.Share.Framework.CustomTypeBase _); // 0x06e18d10
	static System.Void .cctor(); // 0x06e18da0
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.TableLongFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.TableFieldInfoCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e18fd0
	static WizardGames.Soc.Common.SimpleCustom.TableLongFieldInfoCfg TableLongFieldInfoCfgConstructor(); // 0x06e19074
	System.Void .ctor(); // 0x06e190f4
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e1917c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e193f8
	System.Void CopyFrom(WizardGames.Soc.Share.Framework.CustomTypeBase _); // 0x06e19704
	static System.Void .cctor(); // 0x06e19794
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.TableStringFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.TableFieldInfoCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e199c4
	static WizardGames.Soc.Common.SimpleCustom.TableStringFieldInfoCfg TableStringFieldInfoCfgConstructor(); // 0x06e19a68
	System.Void .ctor(); // 0x06e19ae8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e19b70
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e19dec
	System.Void CopyFrom(WizardGames.Soc.Share.Framework.CustomTypeBase _); // 0x06e1a0f8
	static System.Void .cctor(); // 0x06e1a188
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.TableTextFieldInfoCfg : WizardGames.Soc.Common.SimpleCustom.TableFieldInfoCfg
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e1a3b8
	static WizardGames.Soc.Common.SimpleCustom.TableTextFieldInfoCfg TableTextFieldInfoCfgConstructor(); // 0x06e1a45c
	System.Void .ctor(); // 0x06e1a4dc
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e1a564
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e1a7e0
	System.Void CopyFrom(WizardGames.Soc.Share.Framework.CustomTypeBase _); // 0x06e1aaec
	static System.Void .cctor(); // 0x06e1ab7c
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.VariableIdCfg : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable, WizardGames.Soc.Common.RuleGraph.IConvert<WizardGames.Soc.Share.Framework.CustomTypeBase>
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 VarId; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e1adac
	static WizardGames.Soc.Common.SimpleCustom.VariableIdCfg VariableIdCfgConstructor(); // 0x06e1b030
	System.Void .ctor(); // 0x06e1b0b0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e1ae40
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e1b118
	System.Void CopyFrom(WizardGames.Soc.Share.Framework.CustomTypeBase _); // 0x06e1b3c4
	static System.Void .cctor(); // 0x06e1b490
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SimpleVector3 : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable, WizardGames.Soc.Common.RuleGraph.IConvert<WizardGames.Soc.Common.CustomType.CustomVector3>
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Single X; // 0x10
	System.Single Y; // 0x14
	System.Single Z; // 0x18
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e1b5f0
	static WizardGames.Soc.Common.SimpleCustom.SimpleVector3 SimpleVector3Constructor(); // 0x06e1b8ac
	System.Void .ctor(); // 0x06e1b92c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e1b684
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e05c34
	System.Void .ctor(System.Single x, System.Single y, System.Single z); // 0x06e1b994
	System.String ToString(); // 0x06e1ba38
	System.Void CopyFrom(WizardGames.Soc.Common.CustomType.CustomVector3 t); // 0x06e1bb38
	static System.Void .cctor(); // 0x06e1bbe0
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SimulatorCheckChangePartChildData : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 PartType; // 0x10
	WizardGames.Soc.Common.SimpleCustom.SimpleVector3 Position; // 0x18
	WizardGames.Soc.Common.SimpleCustom.SimpleVector3 EulerAngle; // 0x20
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e1bda8
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e1be3c
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e1c0e4
	static System.Void .cctor(); // 0x06e1c3d8
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SimulatorPickUpRequest : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.Int64 EntityId; // 0x10
	System.Int64 ItemNodeId; // 0x18
	System.Collections.Generic.List<System.Int64> TargetPath; // 0x20
	System.Boolean WithConfirm; // 0x28
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e1c5a0
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e1c634
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e1c900
	System.Void .ctor(); // 0x06e1cc58
	static System.Void .cctor(); // 0x06e1ccc0
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SocGraphBasicEditorSettings : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	WizardGames.Soc.Common.SimpleCustom.SimpleVector3 Position; // 0x10
	WizardGames.Soc.Common.SimpleCustom.SimpleVector3 Scale; // 0x18
	System.String SelectedNodeGuid; // 0x20
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e1cebc
	static WizardGames.Soc.Common.SimpleCustom.SocGraphBasicEditorSettings SocGraphBasicEditorSettingsConstructor(); // 0x06e1d200
	System.Void .ctor(); // 0x06e1d280
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e1cf50
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e1d2e8
	static System.Void .cctor(); // 0x06e1d5dc
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SocGroupEditorSettings : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.String GroupGuid; // 0x10
	System.String Title; // 0x18
	System.Single ColorR; // 0x20
	System.Single ColorG; // 0x24
	System.Single ColorB; // 0x28
	System.Single ColorA; // 0x2c
	WizardGames.Soc.Common.SimpleCustom.SimpleVector3 Position; // 0x30
	WizardGames.Soc.Common.SimpleCustom.SimpleVector3 Size; // 0x38
	System.Collections.Generic.List<System.String> NodeIds; // 0x40
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e1d7a4
	static WizardGames.Soc.Common.SimpleCustom.SocGroupEditorSettings SocGroupEditorSettingsConstructor(); // 0x06e1dc1c
	System.Void .ctor(); // 0x06e1dc9c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e1d838
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e1dd04
	static System.Void .cctor(); // 0x06e1e0d4
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SocNodeEditorSettings : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.String NodeGuid; // 0x10
	WizardGames.Soc.Common.SimpleCustom.SimpleVector3 Position; // 0x18
	System.String Note; // 0x20
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e1e3d4
	static WizardGames.Soc.Common.SimpleCustom.SocNodeEditorSettings SocNodeEditorSettingsConstructor(); // 0x06e1e6fc
	System.Void .ctor(); // 0x06e1e77c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e1e468
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e1e7e4
	static System.Void .cctor(); // 0x06e1eadc
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SocRuleGraphEditorSettings : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	WizardGames.Soc.Common.SimpleCustom.SocGraphBasicEditorSettings BasicEditorSettings; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.SocNodeEditorSettings> NodeEditorSettings; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.SocVariableEditorSettings> VariableEditorSettings; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.SocGroupEditorSettings> GroupEditorSettings; // 0x28
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e1eca4
	static WizardGames.Soc.Common.SimpleCustom.SocRuleGraphEditorSettings SocRuleGraphEditorSettingsConstructor(); // 0x06e1f118
	System.Void .ctor(); // 0x06e1f198
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e1ed38
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e08794
	static System.Void .cctor(); // 0x06e1f200
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SocValueCfgCopy : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	WizardGames.Soc.Common.SimpleCustom.ValueCfg Value; // 0x10
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e1f3fc
	static WizardGames.Soc.Common.SimpleCustom.SocValueCfgCopy SocValueCfgCopyConstructor(); // 0x06e1f6dc
	System.Void .ctor(); // 0x06e1f75c
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e1f490
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e1f7c4
	static System.Void .cctor(); // 0x06e1fa94
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SocVariableEditorSettings : System.Object, WizardGames.Soc.Common.Framework.Types.ISerializeType, WizardGames.Soc.Common.SimpleCustom.IJsonSerializable
{
	static SocLogger logger; // 0x0
	static System.Int32 StaticClassHash; // 0x8
	static System.String[] PropNameArray; // 0x10
	System.String VarGuid; // 0x10
	System.String Name; // 0x18
	System.Boolean ViewExpanded; // 0x20
	System.Void .ctor(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e1fbf4
	static WizardGames.Soc.Common.SimpleCustom.SocVariableEditorSettings SocVariableEditorSettingsConstructor(); // 0x06e1fec8
	System.Void .ctor(); // 0x06e1ff48
	System.Void DeserializeCore(MessagePack.MessagePackReader& reader, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode); // 0x06e1fc88
	System.Void SerializeCore(MessagePack.MessagePackWriter& writer, WizardGames.Soc.Common.Framework.Const.ESerializeMode mode, System.Int32 templateHashValue); // 0x06e1ffb0
	static System.Void .cctor(); // 0x06e20288
}

// Client.Runtime
class WizardGames.Soc.Common.SimpleCustom.SpawnHorseNodeExecutor : WizardGames.Soc.Common.SimpleCustom.GraphNodeExecutorBase
