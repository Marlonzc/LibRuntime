	static System.Void CalJumpAnimSpeed(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy forwardCurve, WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy rightCurve, System.Single& outforwardspeed, System.Single& outrightspeed, System.Single& outpitch, System.Single& outroll); // 0x0761b67c
	static System.Void EnableAnimationOptimize(UnityEngine.Animator animator, WizardGames.Soc.Common.Unity.Utility.AnimSignificantParameters& SignificantParameters); // 0x0761b900
	static System.Void DisableAnimationOptimize(UnityEngine.Animator animator); // 0x0761c044
	static WizardGames.Soc.Common.Unity.Character.ClientWeaponBindingDataProxy GetWeaponAccessoryAnimList(WizardGames.Soc.Common.Entity.IEntity Owner, WizardGames.Soc.Common.Entity.IHeldItemEntity Weapon, System.Boolean fp, System.String& keywords); // 0x0761c128
	static WizardGames.Soc.Common.Unity.Character.ClientWeaponBindingDataProxy GetWeaponAccessoryAnimList(WizardGames.Soc.Common.Entity.IEntity Owner, System.Int64 weaponTbId, System.Int64 weaponSkinId, System.Boolean fp, System.String& keywords); // 0x0761c318
	static System.Boolean HeldInLadderWithIk(WizardGames.Soc.Common.Entity.PlayerEntity player, System.Boolean& leftIk); // 0x0761c898
	static System.Int32 GetPlayDirection(System.Single CurWeight, System.Single LastWeight, System.Single CurTime, System.Single LastTime); // 0x0761c9f0
	static WizardGames.Soc.Common.Const.EHeldSocketType GetHeldItemSocketType(WizardGames.Soc.Common.Entity.IHeldItemEntity weapon, System.Boolean bIsFirstPerson); // 0x0761cb38
	static WizardGames.Soc.Common.Const.EHeldSocketTypeInHorse GetWeaponHeldSocketTypeInHorse(WizardGames.Soc.Common.Entity.IHeldItemEntity weapon); // 0x0761cf78
	static System.Void BuildMatrix(UnityEngine.Vector3& LocalPosFloat, UnityEngine.Quaternion& LocalRotFloat, UnityEngine.Vector3& LocalScaleFloat, Unity.Mathematics.double4x4& OutResult); // 0x0761d2c4
	static Unity.Mathematics.double4x4 GetWorldMatrixByMathematics(UnityEngine.Transform TargetTrans); // 0x0761d454
	static Unity.Mathematics.double4x4 GetMatrixByMathematics(UnityEngine.Transform TargetTrans, UnityEngine.Transform target); // 0x0761d4f8
	static UnityEngine.Matrix4x4 GetMatrixInPath(UnityEngine.Transform from, UnityEngine.Transform target); // 0x0761d828
	static Unity.Mathematics.double4x4 GetWorldMatrixByMathematics(UnityEngine.Transform TargetTrans, Unity.Mathematics.double4x4 matrix); // 0x0761db54
	static Mathd.Matrix4x4d GetWorldMatrix(UnityEngine.Transform TargetTrans); // 0x0761ded8
	static System.Void UpdateClipRate(WizardGames.Soc.Common.Entity.PlayerEntity player, UnityEngine.AnimatorOverrideController controller, System.Int64 tableID, System.Int64 skinID); // 0x0761e210
	static System.Void TransformParentByChild(UnityEngine.Transform Parent, UnityEngine.Transform locator, UnityEngine.Transform Target, UnityEngine.Vector3& parentWP, UnityEngine.Quaternion& parentWQ); // 0x0761e9cc
	static WizardGames.Soc.Common.Unity.Character.AnimType GetCurrentBowType(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x0761ed5c
	static System.Void TransformParentByChild(UnityEngine.Transform Parent, UnityEngine.Transform locator, UnityEngine.Transform Target, Unity.Mathematics.double3& parentWP, UnityEngine.Quaternion& parentWQ); // 0x0761eea8
	static System.Single GetStateNormalizedTime(System.Int32 animatorInstanceId, System.Int32 layerIndex, System.Int32 stateIndex); // 0x0761f290
	static System.Boolean MergeMaskWeightData(WizardGames.Soc.Common.Character.TpMaskWeightConfGroup singleMaskData, System.Single singleWeight, WizardGames.Soc.Common.Character.TpMaskWeightConfGroup& allMaskData, WizardGames.Soc.Common.Character.TpMaskWeightFloatGroup& allWeightData); // 0x0761f394
	static System.Void CommitMaskWeightData(System.Int32 animatorInstanceId, WizardGames.Soc.Common.Character.TpMaskWeightConfGroup& allMaskData, WizardGames.Soc.Common.Character.TpMaskWeightFloatGroup& allWeightData, System.Int32 layer); // 0x0761f554
	static System.Boolean MergeMaskWeightDataFp(WizardGames.Soc.Common.Character.FpMaskWeightConfGroup singleMaskData, System.Single singleWeight, WizardGames.Soc.Common.Character.FpMaskWeightConfGroup& allMaskData, WizardGames.Soc.Common.Character.FpMaskWeightFloatGroup& allWeightData); // 0x0761f680
	static System.Void CommitMaskWeightDataFp(System.Int32 animatorInstanceId, WizardGames.Soc.Common.Character.FpMaskWeightConfGroup& allMaskData, WizardGames.Soc.Common.Character.FpMaskWeightFloatGroup& allWeightData, System.Int32 layer); // 0x0761f840
	static System.Void .cctor(); // 0x0761f96c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Utility.SocEquipUtility : System.Object
{
	static SocLogger logger; // 0x0
	static System.Void GetWeaponInfo(System.Int64 weaponTableId, System.String& weaponHandName, System.String& weaponLocatorName, WizardGames.Soc.Common.Const.EHeldSocketType& socketType, WizardGames.Soc.Common.Weapon.ShowEquipPos equipPos, System.Boolean isFp); // 0x0761fa70
	static System.Void GetMonsterWeaponInfo(WizardGames.Soc.Common.Entity.IHeldItemEntity heldItem, System.String& WeaponHandName, System.String& WeaponLocatorName, System.String& PrefabPath, WizardGames.Soc.Common.Const.EHeldSocketType& SocketType); // 0x0761fee4
	static System.UInt64 Equip(WizardGames.Soc.Common.Entity.IHeldItemEntity item, System.String path, System.Boolean isFp, System.Action<WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent> cb); // 0x0762014c
	static System.Boolean ChangeAnchorPosAndRot(System.String weaponHandName, WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent source, System.Int64 weaponTableId, WizardGames.Soc.Common.Entity.IBaseMountableEntity baseMountableEntity); // 0x0762045c
	static System.Void .cctor(); // 0x076207d0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Utility.SocEquipUtility.<>c__DisplayClass4_0 : System.Object
{
	System.Boolean isFp; // 0x10
	System.Action<WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent> cb; // 0x18
	System.Void .ctor(); // 0x076203f4
	System.Void <Equip>b__0(UnityEngine.GameObject go, System.Object[] objects); // 0x076208a4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Utility.SocPing : System.Object
{
	UnityEngine.Ping ping; // 0x10
	System.String address; // 0x18
	System.Int32 timeout; // 0x20
	System.Diagnostics.Stopwatch lastTime; // 0x28
	static SocLogger logger; // 0x0
	System.Boolean get_IsDone(); // 0x076209f0
	System.Void .ctor(System.String address, System.Int32 timeout); // 0x07620ad4
	System.Boolean GetPingNum(System.Int32& num, System.Boolean restart); // 0x07620c08
	System.Void Destroy(); // 0x07621210
	static UnityEngine.Color GetPingColor(System.Int32 num); // 0x07621298
	static System.String GetPingText(System.Int32 num); // 0x0762137c
	static System.Void .cctor(); // 0x07621474
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Utility.SocUnityConstName : System.Object
{
	static System.Int32 Normal_Idle_Hash; // 0x0
	static System.Int32 beltspeedID; // 0x4
	static System.Int32 adsboltWeightCurve; // 0x8
	static System.Int32 boltWeightCurve; // 0xc
	static System.Int32 adsboltAutoCurve; // 0x10
	static System.Int32 boltAutoCurve; // 0x14
	static System.Int32 stand_hip_jumpstart_Curve; // 0x18
	static System.Int32 stand_hip_jumploop_Curve; // 0x1c
	static System.Int32 stand_hip_jumpend_Curve; // 0x20
	static System.Int32 stand_sight_jumpstart_Curve; // 0x24
	static System.Int32 stand_sight_jumploop_Curve; // 0x28
	static System.Int32 stand_sight_jumpend_Curve; // 0x2c
	static System.Int32 stand_hip_jumpstart_CurveWeight; // 0x30
	static System.Int32 stand_hip_jumploop_CurveWeight; // 0x34
	static System.Int32 stand_hip_jumpend_CurveWeight; // 0x38
	static System.Int32 stand_sight_jumpstart_CurveWeight; // 0x3c
	static System.Int32 stand_sight_jumploop_CurveWeight; // 0x40
	static System.Int32 stand_sight_jumpend_CurveWeight; // 0x44
	static System.Int32 JogDynamicWeight_WeightCruve; // 0x48
	static System.Int32 JogSpineWeight_WeightCruve; // 0x4c
	static System.Int32 JogLClavicleWeight_WeightCruve; // 0x50
	static System.Int32 JogHeadWeight_WeightCruve; // 0x54
	static System.Int32 JogRClavicleWeight_WeightCruve; // 0x58
	static System.Int32 JogWeaponWeight_WeightCruve; // 0x5c
	static System.Int32 JogLeftArmWeight_WeightCruve; // 0x60
	static System.Int32 JogRightArmWeight_WeightCruve; // 0x64
	static System.Int32 SprintDynamicWeight_WeightCruve; // 0x68
	static System.Int32 SprintSpineWeight_WeightCruve; // 0x6c
	static System.Int32 SprintLClavicleWeight_WeightCruve; // 0x70
	static System.Int32 SprintHeadWeight_WeightCruve; // 0x74
	static System.Int32 SprintRClavicleWeight_WeightCruve; // 0x78
	static System.Int32 SprintWeaponWeight_WeightCruve; // 0x7c
	static System.Int32 SprintLeftArmWeight_WeightCruve; // 0x80
	static System.Int32 SprintRightArmWeight_WeightCruve; // 0x84
	static System.Int32 JumpDynamicWeight_WeightCruve; // 0x88
	static System.Int32 JumpSpineWeight_WeightCruve; // 0x8c
	static System.Int32 JumpLClavicleWeight_WeightCruve; // 0x90
	static System.Int32 JumpHeadWeight_WeightCruve; // 0x94
	static System.Int32 JumpRClavicleWeight_WeightCruve; // 0x98
	static System.Int32 JumpWeaponWeight_WeightCruve; // 0x9c
	static System.Int32 JumpLeftArmWeight_WeightCruve; // 0xa0
	static System.Int32 JumpRightArmWeight_WeightCruve; // 0xa4
	static System.Int32 SwimDynamicWeight_WeightCruve; // 0xa8
	static System.Int32 SwimSpineWeight_WeightCruve; // 0xac
	static System.Int32 SwimLClavicleWeight_WeightCruve; // 0xb0
	static System.Int32 SwimHeadWeight_WeightCruve; // 0xb4
	static System.Int32 SwimRClavicleWeight_WeightCruve; // 0xb8
	static System.Int32 SwimWeaponWeight_WeightCruve; // 0xbc
	static System.Int32 SwimLeftArmWeight_WeightCruve; // 0xc0
	static System.Int32 SwimRightArmWeight_WeightCruve; // 0xc4
	static System.Int32 HorseSpeacialWeightCurve; // 0xc8
	static System.Void .cctor(); // 0x07621548
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Utility.ThreadUtil : System.Object
{
	static System.Int32 mainThreadId; // 0x0
	static System.Void InitThreadId(); // 0x07621f30
	static System.Boolean get_IsMainThread(); // 0x07621fc0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Utility.UnityDefaultLogAppender : log4net.Appender.AppenderSkeleton
{
	static SocLogger logger; // 0x0
	static System.String UnityContext = "unity:context";
	static System.Int32 ErrorLevel; // 0x8
	static System.Int32 WarnLevel; // 0xc
	System.Void Append(log4net.Core.LoggingEvent loggingEvent); // 0x07622058
	System.Void .ctor(); // 0x076220cc
	static System.Void .cctor(); // 0x07622158
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Utility.UnityUtility : System.Object
{
	static SocLogger Logger; // 0x0
	static System.Boolean IsFirstPersonCamera(WizardGames.Soc.Common.Unity.CameraState NowCameraState); // 0x076222ac
	static UnityEngine.Vector3 Vector3Range(System.Single x, System.Single y); // 0x07622318
	static UnityEngine.Transform ResetLocal(UnityEngine.Transform transform); // 0x076223d8
	static UnityEngine.Transform GetChildDeep(UnityEngine.Transform transform, System.String name); // 0x07622508
	static System.Void CombineGoByAnchor(WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent source, WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent destination, System.String sourceAnchorName, System.String destinationAnchorName, WizardGames.Soc.Common.Entity.IEntity entity, System.Boolean bSetParent, WizardGames.Editor.FpClipSettingMeta fpMeta, WizardGames.Soc.Common.Unity.Character.TpMetaDataProxy tpMeta, System.Int64 weaponTableId); // 0x076226c4
	static System.String GetNowIdlePoseName(System.Int64 weaponTableId); // 0x07623848
	static System.String GetNowIdlePoseName(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x076238d4
	static System.Boolean GetSourceInvMatrix(WizardGames.Soc.Common.Unity.Character.ClientClipValueProxy clipValues, System.String idlePoseName, WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent source, UnityEngine.Transform sourceAnchor, System.String& logRes, UnityEngine.Matrix4x4& inv); // 0x07623430
	static UnityEngine.Matrix4x4 GetSourceInvMatrix(UnityEngine.Transform sourceAnchor, WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent source); // 0x07623a48
	static UnityEngine.Transform TryGetChildPointTrans(UnityEngine.Transform transform, System.String name); // 0x07623d44
	static UnityEngine.Transform GetChildPointTrans(UnityEngine.Transform transform, System.String name, System.Boolean includeChildren); // 0x07623e48
	static System.Void ClientSetCcPosition(WizardGames.Soc.Common.Unity.Character.SocCharacterController cc, UnityEngine.Vector3 pos, WizardGames.Soc.Common.Entity.PlayerEntity entity, System.Boolean isLocal); // 0x07623f54
	static System.Void VectorToAngle(UnityEngine.Vector3 v, System.Double& yaw, System.Double& pitch); // 0x076243cc
	static System.Boolean IsVisibleInCameraByPoint(UnityEngine.Vector3 pos, UnityEngine.Camera camera); // 0x07624548
	static UnityEngine.Vector3 damper_exponential(UnityEngine.Vector3 from, UnityEngine.Vector3 to, System.Single para, System.Single dt, System.Single ft); // 0x07624680
	static System.Single damper_exponential(System.Single x, System.Single g, System.Single para, System.Single dt, System.Single ft); // 0x076247cc
	static UnityEngine.Vector2 GetPosOnUi(UnityEngine.Vector3 worldPos, UnityEngine.Camera sceneCamera, System.Boolean convert2Local); // 0x076248a8
	static System.Single ConstrainAngle(System.Single angle, System.Single min, System.Single max); // 0x076249a4
	static System.Single CalcYawDelta(System.Single now, System.Single target); // 0x07624b4c
	static System.Single YawClamp(System.Single now, System.Single curFrameAddYaw, System.Single forward, System.Single forwardDelta, System.Single min, System.Single max, System.Boolean isAddMountYaw); // 0x07624c30
	static System.Boolean IsDestroyed(UnityEngine.GameObject gameObject); // 0x07624e74
	static System.Boolean ColliderIgnoreHurt(UnityEngine.Collider collider); // 0x07624f14
	static System.Void CapsuleColliderEndCaps(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Single direction, System.Single customRadius, UnityEngine.Vector3 customCenter, System.Single customHeight, UnityEngine.Vector3& startEndCap, UnityEngine.Vector3& endEndCap); // 0x07625074
	static System.Void SetLayer(UnityEngine.GameObject parent, System.Int32 layer, System.Boolean includeChildren); // 0x07625394
	static System.Void Resize<T>(System.Collections.Generic.List<T> list, System.Int32 size, T element); // 0x052af1f0
	static System.Void PreloadCorpse(System.Int32[] corpseIds, System.Boolean canClear); // 0x076254b4
	static System.Boolean isZero(UnityEngine.Vector3 vector3); // 0x07625980
	static System.Void .cctor(); // 0x07625a30
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Utility.UnityUtility.<>c__DisplayClass55_0 : System.Object
{
	WizardGames.Soc.Common.Data.units.Corpse corpseData; // 0x10
	System.Void .ctor(); // 0x07625918
	System.Void <PreloadCorpse>b__0(UnityEngine.GameObject go, System.Object[] ob); // 0x07625b04
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Utility.WoundUtil : System.Object
{
	static SocLogger logger; // 0x0
	static System.Int64 WoundEndTime(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x07625c0c
	static System.Int64 AidCompleteDuration(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x07625e4c
	static System.Int64 AidDuration(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0762607c
	static System.Void .cctor(); // 0x0762616c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Shared.ListComponent<T> : WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Shared.ListComponent
{
	static ListHashSet<T> InstanceList; // 0x0
	System.Void Setup(); // 0x055049cc
	System.Void Clear(); // 0x055049cc
	static System.Void RunOnAll(System.Action<T> toRun); // 0x055049cc
	System.Void .ctor(); // 0x055049cc
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Shared.ListComponent : UnityEngine.MonoBehaviour
{
	
	System.Void Setup(); // 0x055049cc
	System.Void Clear(); // 0x055049cc
	System.Void OnEnable(); // 0x07626240
	System.Void OnDisable(); // 0x076262a0
	System.Void .ctor(); // 0x07626300
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Entity.Vehicle.Boat.BoatMoveDir : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Entity.Vehicle.Boat.BoatMoveDir None = 0;
	static WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Entity.Vehicle.Boat.BoatMoveDir Forward = 1;
	static WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Entity.Vehicle.Boat.BoatMoveDir ForwardRight = 2;
	static WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Entity.Vehicle.Boat.BoatMoveDir Right = 3;
	static WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Entity.Vehicle.Boat.BoatMoveDir BackRight = 4;
	static WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Entity.Vehicle.Boat.BoatMoveDir Back = 5;
	static WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Entity.Vehicle.Boat.BoatMoveDir BackLeft = 6;
	static WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Entity.Vehicle.Boat.BoatMoveDir Left = 7;
	static WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Entity.Vehicle.Boat.BoatMoveDir ForwardLeft = 8;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Entity.Vehicle.Boat.Kayak : BaseBoat
{
	System.Collections.Generic.List<UnityEngine.Transform> leftForcePoints; // 0x3b8
	System.Collections.Generic.List<UnityEngine.Transform> rightForcePoints; // 0x3c0
	System.Single multiDriverPaddleForceMultiplier; // 0x3c8
	System.Single forwardBackPaddleForce; // 0x3cc
	System.Single forwardBackInterval; // 0x3d0
	System.Single forwardBackRotatePaddleForce; // 0x3d4
	System.Single sidePaddleForce; // 0x3d8
	System.Single sideDirInterval; // 0x3dc
	System.Single sideDirRotatePaddleForce; // 0x3e0
	System.Single leftRightInterval; // 0x3e4
	System.Single leftRightRotatePaddleForce; // 0x3e8
	System.Single[] _playerPaddleCoolDowns; // 0x3f0
	System.Boolean[] _rightRowInForwardAndBack; // 0x3f8
	static System.Single onePersonDrag = 0.05000000074505806;
	static System.Single twoPersonDrag = 0.10000000149011612;
	System.Void DriverInput(WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld, WizardGames.Soc.Common.SimpleCustom.UserCmd inputState, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x07626368
	WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Entity.Vehicle.Boat.BoatMoveDir GetDir(WizardGames.Soc.Common.SimpleCustom.UserCmd inputState); // 0x07626f74
	System.Boolean GetForceInformation(WizardGames.Soc.Common.SimpleCustom.UserCmd inputState, System.Int32 seatIndex, System.Boolean& forceBack, System.Boolean& forceRight, System.Boolean& paddleRight, System.Single& rotateForce, System.Boolean& useForce, System.Boolean& isSide); // 0x07626948
	System.Void VehicleFixedUpdate(System.Int32 dt); // 0x07627234
	System.Single CalculateDesiredDrag(); // 0x076272d4
	System.Boolean IsPlayerHoldingPaddle(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x076268b4
	System.Int32 MountedNum(); // 0x07626c4c
	UnityEngine.Vector3 GetPaddlePoint(System.Int32 seatIndex, System.Boolean isRight); // 0x07626db4
	System.Void DoPushAction(BasePlayer player, System.Single pushForceFactor); // 0x0762735c
	System.Void OnCollisionEnter(UnityEngine.Collision c); // 0x076277c0
	System.Boolean IsInWater(); // 0x076276fc
	System.Single GetMaxHorizontalSpeed(); // 0x076279b0
	System.Void .ctor(); // 0x07627a90
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Entity.Vehicle.Boat.MotorRowBoat : BaseBoat
{
	System.Single angularDragBase; // 0x3b8
	System.Single angularDragVelocity; // 0x3bc
	System.Single landDrag; // 0x3c0
	System.Single waterDrag; // 0x3c4
	System.Single offAxisDrag; // 0x3c8
	System.Single offAxisDot; // 0x3cc
	System.Single currentEngineRotation; // 0x3d0
	System.Single propellerRotationSpeed; // 0x3d4
	UnityEngine.Transform engineLeftHandPosition; // 0x3d8
	UnityEngine.Transform engineRotate; // 0x3e0
	UnityEngine.Transform propellerRotate; // 0x3e8
	static System.Single submergeFractionMinimum = 0.8500000238418579;
	System.Single _lastHadDriverTime; // 0x3f0
	System.Boolean _dying; // 0x3f4
	System.Single fuelPerSec; // 0x3f8
	TimeSince timeSinceLastUsedFuel; // 0x3fc
	System.Boolean isStarting; // 0x400
	System.Single effectScale; // 0x404
	System.Single forwardEffectHeight; // 0x408
	System.Single backEffectHeight; // 0x40c
	System.Int32 LastCmdSqe; // 0x410
	System.Void ServerInit(WizardGames.Soc.Common.Entity.IEntity entity, WizardGames.Soc.Common.Unity.Go.BaseEntityGo entityGo); // 0x07627ba4
	System.Boolean EngineOn(); // 0x07627c30
	System.Single TimeSinceDriver(); // 0x07627c9c
	System.Void DriverInput(WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld, WizardGames.Soc.Common.SimpleCustom.UserCmd inputState, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x07627d0c
	System.Void TryStartEngine(); // 0x07627f28
	System.Void FinishEngineStart(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x07628044
	System.Void EngineToggle(System.Boolean wantsOn); // 0x07627e64
	System.Void SetEngineOn(System.Boolean wantsOn); // 0x076281ec
	System.Void SetFlags(); // 0x07628308
	System.Void UpdateDrag(); // 0x07628554
	System.Void UpdateEngineRotation(System.Single s, System.Single g); // 0x0762883c
	System.Void VehicleFixedUpdate(System.Int32 dt); // 0x07628a8c
	System.Void CheckStopEngine(); // 0x07628bcc
	System.Void DoPushAction(BasePlayer player, System.Single pushForceFactor); // 0x07628c74
	System.Single GetMaxHorizontalSpeed(); // 0x07629104
	System.Boolean get_IsEngineOn(); // 0x0762919c
	System.Void .ctor(); // 0x07629208
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Buoyancy.WaterInfo : System.ValueType
{
	System.Boolean IsValid; // 0x10
	System.Single CurrentDepth; // 0x14
	System.Single OverallDepth; // 0x18
	System.Single SurfaceLevel; // 0x1c
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Buoyancy.Buoyancy : ListComponent<WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Buoyancy.Buoyancy>
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Buoyancy.BuoyancyPoint[] points; // 0x30
	UnityEngine.Rigidbody rigidBody; // 0x38
	System.Single buoyancyScale; // 0x40
	System.Single flowMovementScale; // 0x44
	System.Single requiredSubmergedFraction; // 0x48
	System.Boolean useUnderwaterDrag; // 0x4c
	System.Single underwaterDrag; // 0x50
	System.Single <timeOutOfWater>k__BackingField; // 0x54
	System.Action<System.Boolean> SubmergedChanged; // 0x58
	System.Single SubmergedFraction; // 0x60
	UnityEngine.Vector3 lastPosition; // 0x64
	UnityEngine.Quaternion lastRotation; // 0x70
	WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Buoyancy.Buoyancy.BuoyancyPointData[] _pointData; // 0x80
	UnityEngine.Vector2[] _pointPositionArray; // 0x88
	UnityEngine.Vector2[] _pointPositionUVArray; // 0x90
	System.Single[] _pointTerrainHeightArray; // 0x98
	System.Single[] _pointWaterHeightArray; // 0xa0
	System.Single _defaultDrag; // 0xa8
	System.Single _defaultAngularDrag; // 0xac
	System.Single _timeInWater; // 0xb0
	WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Buoyancy.WaterInfo _waterInfo; // 0xb4
	System.Single AngleBetweenForwardAndForce; // 0xc4
	System.Single _testTimeAcc; // 0xc8
	static System.Single TestInterval = 5;
	static System.Single TestDistance = 1000;
	System.Boolean isUpdate; // 0xcc
	System.Single get_timeOutOfWater(); // 0x076292ac
	System.Void set_timeOutOfWater(System.Single value); // 0x07629310
	System.Void Sleep(); // 0x07629388
	System.Void Wake(); // 0x076294b4
	static System.Void CycleAll(System.Single dt); // 0x076295e0
	System.Void DoCycle(System.Single dt); // 0x07629768
	System.Void SetDrag(System.Boolean isSubmerged); // 0x076299dc
	System.Void EnsurePointsInitialized(); // 0x07629b28
	System.Void CreateDefaultBuoyancyPoint(); // 0x07629dbc
	System.Void CreateBuoyancyPointsCacheData(); // 0x07629fe4
	System.Void UpdateBuoyancyPointsData(); // 0x0762a14c
	System.Void UpdateBuoyancyPointData(System.Int32 index); // 0x0762a294
	System.Void UpdateBuoyancyPointsCurveValues(); // 0x0762a454
	System.Void SetVelocityYOffset(System.Int32 index, System.Single vLen); // 0x0762a6bc
	System.Void SetAngleYOffset(System.Int32 index, System.Single angle); // 0x0762a7b4
	System.Void UpdateBuoyancyPointsPos(); // 0x0762a8ac
	System.Void UpdateBuoyancyPointsTerrainAndWaterHeight(); // 0x0762acf8
	System.Void UpdateBuoyancyPointsCacheData(); // 0x0762b0dc
	System.Void UpdateBuoyancyPointWaterInfo(System.Int32 index); // 0x0762b150
	System.Single CalcUpForce(WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Buoyancy.BuoyancyPoint p); // 0x0762b244
	System.Int32 AddForce(); // 0x0762b7d8
	System.Void UpdateSubmergedParams(System.Int32 numSubmerged, System.Single dt); // 0x0762ba98
	System.Void BuoyancyFixedUpdate(System.Single dt); // 0x07629824
	System.Void .ctor(); // 0x0762bc5c
	static System.Void .cctor(); // 0x0762bd14
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Buoyancy.Buoyancy.BuoyancyPointData : System.ValueType
{
	UnityEngine.Transform Transform; // 0x10
	UnityEngine.Vector3 LocalPosition; // 0x18
	UnityEngine.Vector3 RootToPoint; // 0x24
	UnityEngine.Vector3 Position; // 0x30
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Buoyancy.BuoyancyPoint : UnityEngine.MonoBehaviour
{
	System.Single buoyancyForce; // 0x30
	System.Single size; // 0x34
	System.Single waveScale; // 0x38
	System.Single waveFrequency; // 0x3c
	System.Boolean doSplashEffects; // 0x40
	System.Single RandomOffset; // 0x44
	System.Boolean WasSubmergedLastFrame; // 0x48
	System.Single _nextSplashTime; // 0x4c
	System.Boolean useVCurve; // 0x50
	System.Single velocity; // 0x54
	UnityEngine.AnimationCurve velocityAndYOffsetCurve; // 0x58
	System.Single velocityYOffset; // 0x60
	System.Boolean useAngleCurve; // 0x64
	System.Single angleBetweenForwardAndForce; // 0x68
	UnityEngine.AnimationCurve angleAndYOffsetCurve; // 0x70
	System.Single angleYOffset; // 0x78
	System.Single yOffset; // 0x7c
	static UnityEngine.Color GizmoColour; // 0x0
	System.Void Start(); // 0x0762bde8
	System.Void OnDrawGizmos(); // 0x0762be5c
	System.Void .ctor(); // 0x0762bf2c
	static System.Void .cctor(); // 0x0762bfa8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Utility.Parachute.Animation.AcParametersParachute : System.Object
{
	static SocLogger logger; // 0x0
	static System.Void RenderUpdate(WizardGames.Soc.Common.Unity.Utility.Parachute.Animation.AnimatorParachuteContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocParachute& animParams); // 0x0762bff8
	static System.Void UpdateBaseLayer(WizardGames.Soc.Common.Unity.Utility.Parachute.Animation.AnimatorParachuteContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocParachute& animParams); // 0x0762c098
	static System.Void UpdateParachute(WizardGames.Soc.Common.Unity.Utility.Parachute.Animation.AnimatorParachuteContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocParachute& animParams); // 0x05523a54
	static System.Void UpdateSpeedParams(WizardGames.Soc.Common.Unity.Utility.Parachute.Animation.AnimatorParachuteContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocParachute& animParams); // 0x0762c37c
	static System.Void ToState(WizardGames.Soc.Common.Unity.Utility.Parachute.Animation.AnimatorParachuteContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocParachute& animParas, System.Int32 layerIndex, System.Int32 stateIndex, WizardGames.Soc.Common.Unity.Parachute.EParachuteMoveState animType, System.Single transitionTime, System.Boolean fixTime); // 0x05525d4c
	static System.Void .cctor(); // 0x0762c5c4
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Utility.Parachute.Animation.AnimatorParachuteContext : System.ValueType
{
	WizardGames.Soc.Common.Contexts.Context context; // 0x10
	WizardGames.Soc.Common.Entity.ParachuteEntity ParachuteEntity; // 0x18
	System.Int32 Interval; // 0x20
	WizardGames.Soc.Common.Unity.Animation.ISocAnimationRuntime AnimatorWrapper; // 0x28
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Utility.Modules.SocArraySortHelper<T> : System.Object
{
	
	static System.Void Sort(T[] keys, System.Int32 index, System.Int32 length, System.Comparison<T> comparer); // 0x05506970
	static System.Int32 FloorLog2PlusOne(System.Int32 n); // 0x05485fb4
	static System.Void IntrospectiveSort(T[] keys, System.Int32 left, System.Int32 length, System.Comparison<T> comparer); // 0x05506970
	static System.Void IntroSort(T[] keys, System.Int32 lo, System.Int32 hi, System.Int32 depthLimit, System.Comparison<T> comparer); // 0x05505fa0
	static System.Void InsertionSort(T[] keys, System.Int32 lo, System.Int32 hi, System.Comparison<T> comparer); // 0x05506970
	static System.Int32 PickPivotAndPartition(T[] keys, System.Int32 lo, System.Int32 hi, System.Comparison<T> comparer); // 0x0548c090
	static System.Void Heapsort(T[] keys, System.Int32 lo, System.Int32 hi, System.Comparison<T> comparer); // 0x05506970
	static System.Void SwapIfGreater(T[] keys, System.Comparison<T> comparer, System.Int32 a, System.Int32 b); // 0x05525bf4
	static System.Void Swap(T[] a, System.Int32 i, System.Int32 j); // 0x055057d4
	static System.Void DownHeap(T[] keys, System.Int32 i, System.Int32 n, System.Int32 lo, System.Comparison<T> comparer); // 0x05505fa0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Utility.Mag.MagDynamic : UnityEngine.MonoBehaviour
{
	System.Single DebugRotateSpeed; // 0x30
	System.Single rotateSpeedFactor; // 0x34
	System.Single DebugRotateSpeedThread; // 0x38
	System.Boolean enableDebug; // 0x3c
	UnityEngine.Vector3 Debugvelocity; // 0x40
	System.Int32 CheckInternal; // 0x4c
	UnityEngine.GameObject magGameObject; // 0x50
	WizardGames.Soc.Common.Weapon.MagPhysicsData magPhysicsData; // 0x58
	UnityEngine.BoxCollider boxCollider; // 0x80
	UnityEngine.Rigidbody rb; // 0x88
	WizardGames.Soc.Common.Unity.MgrCamera mgrCamera; // 0x90
	System.Boolean isExMag; // 0x98
	System.Boolean isEnable; // 0x99
	System.Single elapsedTime; // 0x9c
	UnityEngine.Vector3 lastPosition; // 0xa0
	System.Int32 lastFrame; // 0xac
	System.Void Init(UnityEngine.GameObject _magGameObject, WizardGames.Soc.Common.Weapon.MagPhysicsData _magPhysicsData, WizardGames.Soc.Common.Unity.MgrCamera _mgrCamera, System.Boolean _isEx); // 0x0762c698
	UnityEngine.Vector3 CalcMagRotationVelocity(System.Single linearSpeed); // 0x0762cb44
	UnityEngine.Vector3 CalcMagLaunchVelocity(); // 0x0762c9cc
	System.Void Update(); // 0x0762ccf0
	System.Void OnCollisionStay(UnityEngine.Collision collision); // 0x0762cf90
	System.Void .ctor(); // 0x0762d158
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Utility.Indicator.CpuIndicator : System.Object
{
	System.String <Measurement>k__BackingField; // 0x10
	Unity.Profiling.ProfilerRecorder FrameTimeRecorder; // 0x18
	Unity.Profiling.ProfilerRecorder MainThreadRecorder; // 0x20
	Unity.Profiling.ProfilerRecorder RenderRecorder; // 0x28
	Unity.Profiling.ProfilerRecorder ScriptRecorder; // 0x30
	Unity.Profiling.ProfilerRecorder AnimationRecorder; // 0x38
	Unity.Profiling.ProfilerRecorder AnimationFixedRecorder; // 0x40
	Unity.Profiling.ProfilerRecorder AnimationBeginRecorder; // 0x48
	Unity.Profiling.ProfilerRecorder AnimationEndRecorder; // 0x50
	Unity.Profiling.ProfilerRecorder ParticleRecorder; // 0x58
	Unity.Profiling.ProfilerRecorder PhysicsRecorder; // 0x60
	Unity.Profiling.ProfilerRecorder UrpRecorder; // 0x68
	Unity.Profiling.ProfilerRecorder MainCameraRecorder; // 0x70
	Unity.Profiling.ProfilerRecorder StageCameraRecorder; // 0x78
	WizardGames.Soc.Common.Indicator.IndicatorData data; // 0x80
	System.String get_Measurement(); // 0x0762d1dc
	System.Void set_Measurement(System.String value); // 0x0762d240
	System.Void .ctor(System.String measurement); // 0x0762d2c0
	System.Void Collect(System.Collections.Generic.IList<WizardGames.Soc.Common.Indicator.IndicatorData> list); // 0x0762d744
	Unity.Profiling.ProfilerRecorder CreateRecorder(Unity.Profiling.ProfilerCategory category, System.String name); // 0x0762d6b4
	System.Single NsToMs(System.Double ns); // 0x0762da44
	System.Double GetAverageValueAndReset(Unity.Profiling.ProfilerRecorder recorder); // 0x0762d8f8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Utility.Indicator.MemoryIndicator : System.Object
{
	System.String <Measurement>k__BackingField; // 0x10
	Unity.Profiling.ProfilerRecorder SystemRecorder; // 0x18
	Unity.Profiling.ProfilerRecorder ReservedRecroder; // 0x20
	Unity.Profiling.ProfilerRecorder UsedRecorder; // 0x28
	Unity.Profiling.ProfilerRecorder MeshRecorder; // 0x30
	Unity.Profiling.ProfilerRecorder TextureRecorder; // 0x38
	Unity.Profiling.ProfilerRecorder AnimationRecorder; // 0x40
	Unity.Profiling.ProfilerRecorder MaterialRecorder; // 0x48
	Unity.Profiling.ProfilerRecorder AudioRecorder; // 0x50
	Unity.Profiling.ProfilerRecorder RenderTextureRecorder; // 0x58
	Unity.Profiling.ProfilerRecorder SceneObjectRecorder; // 0x60
	Unity.Profiling.ProfilerRecorder GameObjectRecorder; // 0x68
	Unity.Profiling.ProfilerRecorder ObjectRecorder; // 0x70
	Unity.Profiling.ProfilerRecorder GfxUsedRecorder; // 0x78
	Unity.Profiling.ProfilerRecorder GfxReservedRecorder; // 0x80
	WizardGames.Soc.Common.Indicator.IndicatorData data; // 0x88
	System.String get_Measurement(); // 0x0762dac8
	System.Void set_Measurement(System.String value); // 0x0762db2c
	System.Void .ctor(System.String measurement); // 0x0762dbac
	System.Void Collect(System.Collections.Generic.IList<WizardGames.Soc.Common.Indicator.IndicatorData> list, System.Boolean simple); // 0x0762e07c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Utility.Indicator.UnityLogIndicator : System.Object
{
	System.String <Measurement>k__BackingField; // 0x10
	WizardGames.Soc.Common.Utility.Counter Error; // 0x18
	WizardGames.Soc.Common.Utility.Counter Warn; // 0x20
	WizardGames.Soc.Common.Utility.Counter Info; // 0x28
	WizardGames.Soc.Common.Indicator.IndicatorData data; // 0x30
	System.String get_Measurement(); // 0x0762e54c
	System.Void set_Measurement(System.String value); // 0x0762e5b0
	System.Void .ctor(System.String measurement); // 0x0762e630
	System.Void logReceived(System.String condition, System.String stacktrace, UnityEngine.LogType type); // 0x0762e8e4
	System.Void Collect(System.Collections.Generic.IList<WizardGames.Soc.Common.Indicator.IndicatorData> list); // 0x0762e9d4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Utility.Define.GameEnumUtils : System.Object
{
	
	static System.Boolean HasBitFlag(System.Int32 value, WizardGames.Soc.Common.State.Character.LadderMoveType testFlag); // 0x0762ec0c
	static System.Int32 AddBitFlag(System.Int32 value, WizardGames.Soc.Common.State.Character.LadderMoveType flag); // 0x0762ec88
	static System.Int32 RemoveBitFlag(System.Int32 value, WizardGames.Soc.Common.State.Character.LadderMoveType flag); // 0x0762ed00
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum GetItemEnum(System.Int64 TableId); // 0x076206f8
	static WizardGames.Soc.Common.Data.DataItem.ItemEntityType GetItemEntityType(System.Int64 TableId); // 0x0762ed78
	static System.Boolean IsSustainMelee(System.Int64 tableId); // 0x0762ee50
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Horse.AcParametersHorse : System.Object
{
	static SocLogger logger; // 0x0
	static System.Void RenderUpdate(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams); // 0x0762eee8
	static System.Void UpdateBaseLayer(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams); // 0x0762ef88
	static System.Void UpdateHorseDead(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams); // 0x05523a54
	static System.Void UpdateHorseIdle(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams); // 0x05523a54
	static System.Void UpdateHorseLocomotion(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams); // 0x05523a54
	static System.Void UpdateHorseJump(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams); // 0x05523a54
	static System.Void UpdateHorseStop(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams); // 0x05523a54
	static System.Void UpdateHorseEat(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams); // 0x05523a54
	static System.Void UpdateHorseGetHit(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams); // 0x05523a54
	static System.Int32 GetJumpType(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams); // 0x07631414
	static System.Single GetJumpEndNormalizedTime(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams); // 0x054a6f88
	static System.Void OtherStateToIdle(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams); // 0x07630c1c
	static System.Void OtherStateToJump(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams); // 0x0763097c
	static System.Void OtherStateToLocomotion(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams); // 0x07630820
	static System.Void OtherStateToGoToDead(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams); // 0x076304e8
	static System.Void OtherStateToDead(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams); // 0x07630598
	static System.Void OtherStateToHalter(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams); // 0x076308d0
	static System.Void OtherStateToEat(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams); // 0x07630abc
	static System.Void OtherStateToGetHit(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams); // 0x07630b6c
	static System.Void ToIdleState(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams, System.Int32 index, System.Single transitionTime, System.Boolean fixTime); // 0x055263d0
	static System.Void ToLocomotionState(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams, System.Int32 index, System.Single transitionTime, System.Boolean fixTime); // 0x055263d0
	static System.Void ToJumpStartState(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams, System.Int32 index, System.Single transitionTime, System.Boolean fixTime); // 0x055263d0
	static System.Void ToJumpLoopState(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams, System.Int32 index, System.Single transitionTime, System.Boolean fixTime); // 0x055263d0
	static System.Void ToJumpEndState(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams, System.Int32 index, System.Single transitionTime, System.Boolean fixTime); // 0x055263d0
	static System.Void ToGoToDeadState(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams, System.Int32 index, System.Single transitionTime, System.Boolean fixTime); // 0x055263d0
	static System.Void ToDeadState(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams, System.Int32 index, System.Single transitionTime, System.Boolean fixTime); // 0x055263d0
	static System.Void ToHalterState(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams, System.Int32 index, System.Single transitionTime, System.Boolean fixTime); // 0x055263d0
	static System.Void ToEatState(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams, System.Int32 index, System.Single transitionTime, System.Boolean fixTime); // 0x055263d0
	static System.Void ToGetHitState(WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext& animatorContext, WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse& animParams, System.Int32 index, System.Single transitionTime, System.Boolean fixTime); // 0x055263d0
	static System.Void .cctor(); // 0x07631f84
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext : System.ValueType
{
	WizardGames.Soc.Common.Contexts.Context context; // 0x10
	WizardGames.Soc.Common.Entity.HorseEntity HorseEntity; // 0x18
	System.Int32 Interval; // 0x20
	WizardGames.Soc.Common.Unity.Animation.ISocAnimationRuntime AnimatorWrapper; // 0x28
	WizardGames.Soc.Common.Data.Vehicle.TbHorsePropertyFactor Tb; // 0x30
	WizardGames.Soc.Common.Unity.Vehicle.Horse.HorseMeta HorseMeta; // 0x38
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Horse.HorseInstanceLogicParallelState<T,TEnum> : WizardGames.Soc.Common.Unity.Horse.HorseLogicState
{
	System.Collections.Generic.Dictionary<System.Type,WizardGames.Soc.Common.Unity.Horse.HorseLogicStateController> SubStateControllers; // 0x0
	TEnum _stateEnum; // 0x0
	System.Int32 _stateValue; // 0x0
	static System.Object SyncObj; // 0x0
	static T _instance; // 0x8
	System.Void set_StateEnum(TEnum value); // 0x052af1f0
	System.Void .ctor(); // 0x055049cc
	static T get_Instance(); // 0x052af1f0
	System.Boolean CanEnter(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x054dec74
	System.Void RegisterStateController(System.Type key, WizardGames.Soc.Common.Unity.Horse.HorseLogicStateController value); // 0x0552af00
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x05523a54
	System.Void RollBack(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams, WizardGames.Soc.Common.Entity.HorseEntity serverEntity); // 0x0552af00
	System.Int32 Update(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0549a128
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x05523a54
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Horse.HorseInstanceLogicStateController<T,TEnum> : WizardGames.Soc.Common.Unity.Horse.HorseLogicStateController
{
	System.Collections.Generic.Dictionary<TEnum,WizardGames.Soc.Common.Unity.Horse.HorseLogicState> States; // 0x0
	static T _instance; // 0x0
	static T get_Instance(); // 0x052af1f0
	System.Void RegisterState(TEnum stateEnum, WizardGames.Soc.Common.Unity.Horse.HorseLogicState state); // 0x052af1f0
	System.Void Rollback(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams, WizardGames.Soc.Common.Entity.HorseEntity serverEntity); // 0x0552af00
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Horse.HorseLogicState : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.Horse.HorseLogicStateController StateController; // 0x10
	static System.Boolean NeedServerAuthorityCheck; // 0x8
	static UnityEngine.RaycastHit[] RaycastCache; // 0x10
	static UnityEngine.Collider[] ColliderCache; // 0x18
	System.Boolean CanEnter(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x07632058
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x076320d0
	System.Void OnRollBackEnter(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x07632144
	System.Int32 Update(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x076321b8
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x07632230
	System.Void OnRollBackLeave(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x076322a4
	System.Void RollBack(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams, WizardGames.Soc.Common.Entity.HorseEntity serverEntity); // 0x07632318
	System.Void PrepareRayCastGroundJobData(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x07632394
	System.Void CapsuleCenterUpAndDown(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams, UnityEngine.Vector3 pos, UnityEngine.Vector3& capsuleDownCenter, UnityEngine.Vector3& capsuleUpCenter); // 0x07632ae0
	System.Void CapsuleCenterUpAndDownSpecial(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams, UnityEngine.Vector3 pos, UnityEngine.Vector3& capsuleDownCenter, UnityEngine.Vector3& capsuleUpCenter); // 0x07632c80
	System.Void CommonLocomotionVelocity(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams, System.Single canSprintFuel, UnityEngine.Vector3& wantVelocity, System.Single& rotateSpeed, System.Single& aniRotateSpeed, System.Single& rotateY); // 0x05527b68
	System.Void InAirLocomotionVelocity(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams, UnityEngine.Vector3& wantVelocity, System.Single& rotateSpeed, System.Single& aniRotateSpeed, System.Single& rotateY); // 0x076338b0
	UnityEngine.Vector3 CCMove(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams, UnityEngine.Vector3 wantVelocity); // 0x054b2120
	System.Void CalculateMove(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams, UnityEngine.Vector3 deltaPos, System.Single rotateSpeed, System.Single aniRotateSpeed, System.Single rotateY, UnityEngine.Vector3 wantVelocity, System.Boolean applyRealY); // 0x0763445c
	System.Void CalcGroundNormal(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x05523a54
	System.Boolean IsOtherCollider(UnityEngine.Collider collider, WizardGames.Soc.Common.Entity.HorseEntity entity); // 0x076354f4
	System.Void CCRotate(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x07635650
	System.Boolean CanIdle(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763588c
	System.Boolean CanRun(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x07635914
	System.Void BackToEmpty(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x05523a54
	System.Boolean CanSprint(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams, System.Single sprintFuel); // 0x054e00b8
	System.Boolean CanJump(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x054dec74
	System.Boolean CanHalter(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x07635ec4
	System.Boolean CanFall(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x07636238
	System.Boolean CanFollow(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x076363f8
	System.Boolean CanEat(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763648c
	System.Boolean CanGetHit(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x054dec74
	System.Void .ctor(); // 0x076365f8
	static System.Void .cctor(); // 0x07636660
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Horse.HorseLogicStateController : System.Object
{
	static SocLogger logger; // 0x0
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x07636a34
	System.Int32 Update(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x07636aa8
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x07636b20
	System.Void Rollback(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams, WizardGames.Soc.Common.Entity.HorseEntity serverEntity); // 0x07636b94
	System.Void .ctor(); // 0x07636c10
	static System.Void .cctor(); // 0x07636c78
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Horse.EHorseMoveState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Horse.EHorseMoveState Idle = 0;
	static WizardGames.Soc.Common.Unity.Horse.EHorseMoveState Run = 1;
	static WizardGames.Soc.Common.Unity.Horse.EHorseMoveState Sprint = 2;
	static WizardGames.Soc.Common.Unity.Horse.EHorseMoveState Jump = 3;
	static WizardGames.Soc.Common.Unity.Horse.EHorseMoveState Halter = 4;
	static WizardGames.Soc.Common.Unity.Horse.EHorseMoveState Follow = 5;
	static WizardGames.Soc.Common.Unity.Horse.EHorseMoveState Eat = 6;
	static WizardGames.Soc.Common.Unity.Horse.EHorseMoveState GetHit = 7;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Horse.EHorseUnAlive : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Horse.EHorseUnAlive None = 0;
	static WizardGames.Soc.Common.Unity.Horse.EHorseUnAlive Dead = 1;
	static WizardGames.Soc.Common.Unity.Horse.EHorseUnAlive GoToDead = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Horse.EHorseState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Horse.EHorseState Active = 0;
	static WizardGames.Soc.Common.Unity.Horse.EHorseState UnActive = 1;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Horse.HorseGoPredict : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.Horse.HorseLogicParams LogicParams; // 0x10
	System.Void PredictInit(System.String name); // 0x07636d4c
	System.Void PredictEnter(); // 0x07636ef8
	System.Void PredictLeave(); // 0x07636f98
	System.Void PredictUpdate(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, System.Boolean rollBack, WizardGames.Soc.Common.Unity.Go.ClientSocHorseGo horseGo); // 0x0552b278
	System.Void SyncServerEntityModel(WizardGames.Soc.Common.Entity.PlayerEntity serverEntity); // 0x07637e3c
	System.Void RollbackCmd(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x07637f90
	System.Void Rollback(WizardGames.Soc.Common.Entity.HorseEntity serverEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x07638020
	System.Void DebugInfo(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams, System.Boolean rollback); // 0x0552af28
	System.Void .ctor(); // 0x07638178
	static System.Void .cctor(); // 0x076381e0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Horse.HorseLogicParams : System.Object
{
	WizardGames.Soc.Common.Entity.HorseEntity HorseEntity; // 0x10
	WizardGames.Soc.Common.SimpleCustom.UserCmd Cmd; // 0x18
	WizardGames.Soc.Common.SimpleCustom.UserCmd LastCmd; // 0x20
	WizardGames.Soc.Common.SimpleCustom.HorseCmdIntention CmdIntention; // 0x28
	UnityEngine.Transform MainGo; // 0x30
	WizardGames.Soc.Common.Unity.Character.SocUnityHorseController Cc; // 0x38
	System.Boolean FirstEnter; // 0x40
	System.Boolean IsEnter; // 0x41
	WizardGames.Soc.Common.Data.Vehicle.TbHorsePropertyFactor Tb; // 0x48
	WizardGames.Soc.Common.Unity.Go.MountableAuthoritySide AuthoritySide; // 0x50
	System.Boolean IsAuthority; // 0x54
	System.Boolean LastIsAuthority; // 0x55
	UnityEngine.Collider LastGroundCollider; // 0x58
	System.Boolean InImmutableGround; // 0x60
	UnityEngine.Vector3 LastPos; // 0x64
	System.Single LastRotateY; // 0x70
	WizardGames.Soc.Common.Entity.PlayerEntity DriverEntity; // 0x78
	System.Int32 DebugInfo1; // 0x80
	System.Int32 DebugInfo2; // 0x84
	System.Boolean CanClientAuthority; // 0x88
	System.Int32 commandIndex; // 0x8c
	System.Int32 commandGroundIndex; // 0x90
	System.Boolean commandGroundJob; // 0x94
	WizardGames.Soc.Common.Unity.Go.ClientSocHorseGo HorseGo; // 0x98
	System.Void .ctor(); // 0x07636df0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Horse.MoveStateController : WizardGames.Soc.Common.Unity.Horse.HorseInstanceLogicStateController<WizardGames.Soc.Common.Unity.Horse.MoveStateController,WizardGames.Soc.Common.Unity.Horse.EHorseMoveState>
{
	System.Int32 CommandGroundCount; // 0x18
	UnityEngine.CapsulecastCommand[] CapsuleCastCommandArray; // 0x20
	UnityEngine.RaycastHit[] CapsuleCastHitResultArray; // 0x28
	System.Void .ctor(); // 0x076382b4
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763865c
	System.Int32 Update(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x07638858
	System.Void ChangeState(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams, System.Int32 stateEnum); // 0x07638700
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x076389b4
	System.Void Rollback(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams, WizardGames.Soc.Common.Entity.HorseEntity serverEntity); // 0x07638a30
	System.Void ChangeStateRollBack(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams, System.Int32 oldStateEnum, System.Int32 newStateEnum); // 0x07638ee8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Horse.MoveStateEat : WizardGames.Soc.Common.Unity.Horse.HorseInstanceLogicParallelState<WizardGames.Soc.Common.Unity.Horse.MoveStateEat,WizardGames.Soc.Common.Unity.Horse.EHorseMoveState>
{
	
	System.Void .ctor(); // 0x076391d0
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x07639294
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763936c
	System.Int32 Update(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763941c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Horse.MoveStateFollow : WizardGames.Soc.Common.Unity.Horse.HorseInstanceLogicParallelState<WizardGames.Soc.Common.Unity.Horse.MoveStateFollow,WizardGames.Soc.Common.Unity.Horse.EHorseMoveState>
{
	UnityEngine.RaycastHit[] hits; // 0x28
	System.Void .ctor(); // 0x07639624
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x05523a54
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x05523a54
	System.Void OnRollBackEnter(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x05523a54
	System.Int32 Update(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x076399b4
	System.Boolean BreakFollow(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x054dec74
	System.Boolean WantFollow(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams, UnityEngine.Vector3& wantDir); // 0x054e0cf4
	System.Boolean FollowDistanceCheck(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams, WizardGames.Soc.Share.Framework.IPositionEntity target, System.Single dis); // 0x0763b59c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Horse.MoveStateGetHit : WizardGames.Soc.Common.Unity.Horse.HorseInstanceLogicParallelState<WizardGames.Soc.Common.Unity.Horse.MoveStateGetHit,WizardGames.Soc.Common.Unity.Horse.EHorseMoveState>
{
	
	System.Void .ctor(); // 0x0763b820
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x05523a54
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763b9c0
	System.Int32 Update(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763ba70
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Horse.MoveStateHalter : WizardGames.Soc.Common.Unity.Horse.HorseInstanceLogicParallelState<WizardGames.Soc.Common.Unity.Horse.MoveStateHalter,WizardGames.Soc.Common.Unity.Horse.EHorseMoveState>
{
	
	System.Void .ctor(); // 0x0763bc8c
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763bd50
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763be10
	System.Int32 Update(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763bea4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Horse.MoveStateIdle : WizardGames.Soc.Common.Unity.Horse.HorseInstanceLogicParallelState<WizardGames.Soc.Common.Unity.Horse.MoveStateIdle,WizardGames.Soc.Common.Unity.Horse.EHorseMoveState>
{
	
	System.Void .ctor(); // 0x0763c2dc
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763c3a0
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763c434
	System.Int32 Update(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0549a128
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Horse.MoveStateJump : WizardGames.Soc.Common.Unity.Horse.HorseInstanceLogicParallelState<WizardGames.Soc.Common.Unity.Horse.MoveStateJump,WizardGames.Soc.Common.Unity.Horse.EHorseMoveState>
{
	
	System.Void .ctor(); // 0x0763c75c
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x05523a54
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x05523a54
	System.Int32 Update(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763cc64
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Horse.MoveStateRun : WizardGames.Soc.Common.Unity.Horse.HorseInstanceLogicParallelState<WizardGames.Soc.Common.Unity.Horse.MoveStateRun,WizardGames.Soc.Common.Unity.Horse.EHorseMoveState>
{
	
	System.Void .ctor(); // 0x0763d03c
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763d100
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763d194
	System.Int32 Update(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0549a128
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Horse.MoveStateSprint : WizardGames.Soc.Common.Unity.Horse.HorseInstanceLogicParallelState<WizardGames.Soc.Common.Unity.Horse.MoveStateSprint,WizardGames.Soc.Common.Unity.Horse.EHorseMoveState>
{
	
	System.Void .ctor(); // 0x0763d570
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763d634
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763d6c8
	System.Int32 Update(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763d75c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Horse.HorseStateActive : WizardGames.Soc.Common.Unity.Horse.HorseInstanceLogicParallelState<WizardGames.Soc.Common.Unity.Horse.HorseStateActive,WizardGames.Soc.Common.Unity.Horse.EHorseState>
{
	
	System.Void .ctor(); // 0x0763d964
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763dad4
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763db78
	System.Int32 Update(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763dc0c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Horse.HorseStateController : WizardGames.Soc.Common.Unity.Horse.HorseInstanceLogicStateController<WizardGames.Soc.Common.Unity.Horse.HorseStateController,WizardGames.Soc.Common.Unity.Horse.EHorseState>
{
	WizardGames.Soc.Common.Unity.Character.State.Event.MgrStateEvent _mgrStateEvent; // 0x18
	static WizardGames.Soc.Common.Unity.Character.State.Event.MgrStateEvent get_Event(); // 0x0763989c
	System.Void .ctor(); // 0x0763dcd8
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763de60
	System.Int32 Update(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763e06c
	System.Void ChangeState(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams, System.Int32 stateEnum); // 0x0763df14
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763e170
	System.Void Rollback(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams, WizardGames.Soc.Common.Entity.HorseEntity serverEntity); // 0x0763e1fc
	System.Void ChangeStateRollBack(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams, System.Int32 oldStateEnum, System.Int32 newStateEnum); // 0x0763e308
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Horse.HorseStateUnActive : WizardGames.Soc.Common.Unity.Horse.HorseInstanceLogicParallelState<WizardGames.Soc.Common.Unity.Horse.HorseStateUnActive,WizardGames.Soc.Common.Unity.Horse.EHorseState>
{
	
	System.Void .ctor(); // 0x0763e5f0
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763e760
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763e804
	System.Int32 Update(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763e898
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Horse.HorseStateDead : WizardGames.Soc.Common.Unity.Horse.HorseInstanceLogicParallelState<WizardGames.Soc.Common.Unity.Horse.HorseStateDead,WizardGames.Soc.Common.Unity.Horse.EHorseUnAlive>
{
	
	System.Void .ctor(); // 0x0763e944
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763ea08
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763ea9c
	System.Int32 Update(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763eb30
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Horse.HorseStateGoToDead : WizardGames.Soc.Common.Unity.Horse.HorseInstanceLogicParallelState<WizardGames.Soc.Common.Unity.Horse.HorseStateGoToDead,WizardGames.Soc.Common.Unity.Horse.EHorseUnAlive>
{
	
	System.Void .ctor(); // 0x0763ebb8
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763ec7c
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763ed3c
	System.Int32 Update(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763edd0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Horse.HorseStateUnAliveNone : WizardGames.Soc.Common.Unity.Horse.HorseInstanceLogicParallelState<WizardGames.Soc.Common.Unity.Horse.HorseStateUnAliveNone,WizardGames.Soc.Common.Unity.Horse.EHorseUnAlive>
{
	
	System.Void .ctor(); // 0x0763eeb4
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763ef78
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763f00c
	System.Int32 Update(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763f0a0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Horse.UnAliveStateController : WizardGames.Soc.Common.Unity.Horse.HorseInstanceLogicStateController<WizardGames.Soc.Common.Unity.Horse.UnAliveStateController,WizardGames.Soc.Common.Unity.Horse.EHorseUnAlive>
{
	
	System.Void .ctor(); // 0x0763f148
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763f2ec
	System.Int32 Update(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763f4e8
	System.Void ChangeState(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams, System.Int32 stateEnum); // 0x0763f390
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams); // 0x0763f5ec
	System.Void Rollback(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams, WizardGames.Soc.Common.Entity.HorseEntity serverEntity); // 0x0763f668
	System.Void ChangeStateRollBack(WizardGames.Soc.Common.Unity.Horse.HorseLogicParams logicParams, System.Int32 oldStateEnum, System.Int32 newStateEnum); // 0x0763f774
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Horse.IK.HorseAniContext : System.ValueType
{
	System.Boolean IsValid; // 0x10
	System.Int64 EntityId; // 0x18
	System.Boolean IKEnable; // 0x20
	System.Int32 CurAnimatorId; // 0x24
	WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent DriverOp; // 0x28
	WizardGames.Soc.Common.Unity.Animation.TwoBoneIKHandle[] TwoBoneIKHandles; // 0x30
	WizardGames.Soc.Common.Unity.Animation.TwoBoneIKEffector[] TwoBoneIKEffectors; // 0x38
	WizardGames.Soc.Common.Unity.Animation.TpBoneHandle[] TpPlayerBoneHandles; // 0x40
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Horse.IK.HorseAniLateJob : System.ValueType, UnityEngine.Animations.IAnimationJob
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.Horse.IK.HorseAniContext Context; // 0x10
	System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream); // 0x0763fa5c
	System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream); // 0x07640844
	System.Void ProcessTpBonesInfo(UnityEngine.Animations.AnimationStream& steam); // 0x0763ff14
	System.Void ResetTwoBoneIKJob(); // 0x0764008c
	System.Void SetupIK(); // 0x07640110
	System.Void SetupHandle(WizardGames.Soc.Common.Unity.Animation.TwoBoneIKHandle& handle, System.String topName, System.String midName, System.String lowName); // 0x07640b0c
	System.Boolean IsEffectorValid(WizardGames.Soc.Common.Unity.Animation.EHorseIKTarget target); // 0x07640278
	System.Void SetEffector(WizardGames.Soc.Common.Unity.Animation.EHorseIKTarget target, System.Int32 effectorId, System.Int32 playerRootInstId, System.Single weight, System.String locatorBoneName, System.String attachBoneName, System.Int32 attachBoneInstId); // 0x07640318
	static System.Void .cctor(); // 0x07640ccc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.FootstepSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Animation.FootstepSystem.FootstepStateTracker> _trackers; // 0x10
	static System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.Animation.FootstepSystem.PhaseCacheKey,WizardGames.Soc.Common.Unity.Character.PhaseGroupScriptObjProxy> _phaseCache; // 0x8
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32> _locomotionHashToIndex; // 0x10
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x07640d60
	static System.Void .cctor(); // 0x07640dc4
	System.Boolean ShouldProcessFootsteps(WizardGames.Soc.Common.Unity.Animation.FootstepSystem.FootstepStateTracker tracker); // 0x0764105c
	System.Boolean IsEntityWithinFootstepRange(WizardGames.Soc.Common.Entity.MonsterEntity entity); // 0x07641384
	System.Boolean IsEntityWithinFootstepRange(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x07641224
	WizardGames.Soc.Common.Unity.Character.TpMetaDataProxy ResolvePlayerMeta(WizardGames.Soc.Common.Unity.Animation.FootstepSystem.FootstepStateTracker tracker, WizardGames.Soc.Common.Entity.PlayerEntity player); // 0x0764155c
	WizardGames.Soc.Common.Unity.Character.TpMetaDataProxy ResolveMonsterMeta(WizardGames.Soc.Common.Unity.Animation.FootstepSystem.FootstepStateTracker tracker, WizardGames.Soc.Common.Entity.MonsterEntity monster); // 0x0764193c
	static System.Boolean WeaponEquals(WizardGames.Soc.Common.Weapon.WeaponUnique& a, WizardGames.Soc.Common.Weapon.WeaponUnique& b); // 0x07641890
	static System.Boolean TryGetCachedPhaseGroup(System.Int32 animHash, CommonUnity.Runtime.Character.PhaseKeySource source, WizardGames.Soc.Common.Unity.Character.PhaseGroupScriptObjProxy& proxy); // 0x07641c20
	static System.Void CachePhaseGroup(System.Int32 animHash, CommonUnity.Runtime.Character.PhaseKeySource source, WizardGames.Soc.Common.Unity.Character.PhaseGroupScriptObjProxy& proxy); // 0x07641db4
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x07641ee4
	System.Void OnDestroy(); // 0x076420e4
	System.Void OnEntityCreate(WizardGames.Soc.Common.Entity.IEntity entity); // 0x076422dc
	System.Void OnEntityRemove(WizardGames.Soc.Common.Entity.IEntity entity); // 0x0764277c
	System.Boolean IsPlayerWalking(WizardGames.Soc.Common.Entity.PlayerEntity player); // 0x076428a0
	System.Single GetAnimSpeed(WizardGames.Soc.Common.Entity.PlayerEntity player, System.Int32 animHash); // 0x07642a14
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x07642bd4
	System.Void .ctor(); // 0x07643b94
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.FootstepSystem.FootstepStateTracker : System.Object
{
	System.Int64 EntityId; // 0x10
	WizardGames.Soc.Share.Framework.EntityBase Entity; // 0x18
	System.Boolean isSelf; // 0x20
	System.Int32 CurrentAnimHash; // 0x24
	System.Single[] AudioTimestamps; // 0x28
	System.Int32 NextTimestampIndex; // 0x30
	System.Single TimeSinceLastStep; // 0x34
	System.Boolean FirstUpdate; // 0x38
	System.Single TimeInIdleState; // 0x3c
	System.Single PreservedTimeSinceLastStep; // 0x40
	System.Int32 PreservedNextTimestampIndex; // 0x44
	System.Boolean WasStepping; // 0x48
	System.Single FirstTimestamp; // 0x4c
	System.Boolean IsFreshAnimation; // 0x50
	System.Boolean HasPlayedFirstStep; // 0x51
	WizardGames.Soc.Common.Weapon.WeaponUnique LastWeaponUnique; // 0x54
	System.Boolean HasCachedWeapon; // 0x60
	WizardGames.Soc.Common.Unity.Character.TpMetaDataProxy CachedMeta; // 0x68
	System.Void .ctor(); // 0x0764270c
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.FootstepSystem.PhaseCacheKey : System.ValueType, System.IEquatable<WizardGames.Soc.Common.Unity.Animation.FootstepSystem.PhaseCacheKey>
{
	System.Int32 AnimHash; // 0x10
	CommonUnity.Runtime.Character.PhaseKeySource Source; // 0x14
	System.Void .ctor(System.Int32 animHash, CommonUnity.Runtime.Character.PhaseKeySource source); // 0x07641d34
	System.Boolean Equals(WizardGames.Soc.Common.Unity.Animation.FootstepSystem.PhaseCacheKey other); // 0x07643c48
	System.Boolean Equals(System.Object obj); // 0x07643ce0
	System.Int32 GetHashCode(); // 0x07643da4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.LobbyClientAnimReceiver : UnityEngine.MonoBehaviour
{
	System.Boolean fp; // 0x30
	UnityEngine.Transform HeldItemGo; // 0x38
	System.Int64 heldtableId; // 0x40
	System.Int64 heldskinId; // 0x48
	Animation.AnimBehCache animBehCache; // 0x50
	System.Void Start(); // 0x07643e14
	System.Void TriggerInterruptEvent(UnityEngine.AnimationClip clip); // 0x07643fb0
	System.Void FireAnimEvent(UnityEngine.AnimationEvent animationEvent); // 0x0764419c
	System.Void .ctor(); // 0x0764448c
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.NewLogicAnimEvent : System.ValueType
{
	System.Boolean Fp; // 0x10
	System.Int32 AnimEvTbId; // 0x14
	System.Int64 EntityId; // 0x18
	System.Boolean Interrupt; // 0x20
	System.Single TriggerTime; // 0x24
	UnityEngine.Transform TriggerGo; // 0x28
	UnityEngine.AnimationClip TriggerClip; // 0x30
	System.Int32 TriggerStateHash; // 0x38
	System.Boolean fromSyncSmb; // 0x3c
	System.Boolean EqualData(WizardGames.Soc.Common.Unity.Animation.NewLogicAnimEvent& OtherEvent); // 0x0764452c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.NewClientAnimReceiver : UnityEngine.MonoBehaviour
{
	System.Boolean Fp; // 0x30
	System.Int64 EntityId; // 0x38
	static WizardGames.Soc.Common.Unity.Animation.NewClientAnimReceiver SetupAnimReceiver(UnityEngine.Component component); // 0x07644654
	System.Void FireAnimEvent(UnityEngine.AnimationEvent animationEvent); // 0x07644754
	System.Void FireAnimEvent(UnityEngine.AnimationEvent animationEvent, System.Int32 hash, UnityEngine.AnimationClip clip); // 0x076449d8
	System.Void PlaySoundOnEntity(System.String audioEventName); // 0x07644c30
	System.Void .ctor(); // 0x07644f58
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.NewClientAnimReceiver.<>c__DisplayClass5_0 : System.Object
{
	WizardGames.Soc.Common.Combat.ColliderMaterialEnum materialEnum; // 0x10
	System.Void .ctor(); // 0x07644ef0
	System.Void <PlaySoundOnEntity>b__0(WizardGames.Soc.SocClient.Audio.WWise.AudioEventData eventData, System.Object obj); // 0x07644fc8
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.OptLateUpdateContext : System.ValueType
{
	System.Boolean IsValid; // 0x10
	System.Boolean IsFp; // 0x11
	System.Int64 EntityId; // 0x18
	System.Boolean IKEnable; // 0x20
	System.Int64 WeaponId; // 0x28
	System.Int32 CurAnimatorId; // 0x30
	WizardGames.Soc.Common.Unity.Animation.TwoBoneIKHandle[] TwoBoneIKHandles; // 0x38
	WizardGames.Soc.Common.Unity.Animation.TwoBoneIKEffector[] TwoBoneIKEffectors; // 0x40
	WizardGames.Soc.Common.Unity.Animation.LookAtIKJobHandle LookAtIKJobHandle; // 0x48
	WizardGames.Soc.Common.Unity.Animation.AimIKJobHandle AimIKJobHandle; // 0x50
	System.Boolean LookAtBlending; // 0x58
	System.Boolean LookAtEnableLast; // 0x59
	System.Single LookAtTime; // 0x5c
	WizardGames.Soc.Common.Unity.Animation.TpBoneHandle[] TpPlayerBoneHandles; // 0x60
	System.Collections.Generic.List<System.String> TpEffectParentBones; // 0x68
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Animation.TpEffectParentBoneHandle> TpEffectParentBoneHandles; // 0x70
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.OptLateUpdatePlayableMB : System.Object, RootMotion.FinalIK.ILookAtIKPlayable
{
	static SocLogger logger; // 0x0
	System.Boolean isFp; // 0x10
	System.Int32 bindAnimatorId; // 0x14
	UnityEngine.Playables.PlayableGraph LateGraph; // 0x18
	WizardGames.Soc.Common.Unity.Animation.OptSocAnimLateUpdateJob JobLateUpdate; // 0x28
	UnityEngine.Animations.AnimationScriptPlayable LatePlayable; // 0xd0
	System.Void Build(System.Int64 entityId, UnityEngine.Animator animator, System.Boolean fp); // 0x076450d0
	System.Void CleanUp(); // 0x07645d60
	System.Void BuildHitBox(WizardGames.Soc.Common.Unity.Go.BaseHitBoxComp hitBoxComp); // 0x07645994
	System.Void SetLookAtIKEnabled(System.Boolean enabled); // 0x07645ef0
	System.Void SetupLookAtIKJob(RootMotion.FinalIK.ILookAtBone head, RootMotion.FinalIK.ILookAtBone[] spines, RootMotion.FinalIK.ILookAtBone[] eyes); // 0x07645f78
	System.Void SetLookAtIKJobData(RootMotion.FinalIK.LookAtIKJobData lookAtJobData); // 0x07646564
	System.Void SetupEffectParentJobHandle(System.Collections.Generic.List<WizardGames.Soc.SocClient.GoLoader.PartModel> partModels); // 0x07646620
	System.Void ClearEffectParentJobHandle(); // 0x07646bcc
	System.Void .ctor(); // 0x07646ca8
	static System.Void .cctor(); // 0x07646d18
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Animation.EIKTarget : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Animation.EIKTarget LeftHand = 0;
	static WizardGames.Soc.Common.Unity.Animation.EIKTarget RightHand = 1;
	static WizardGames.Soc.Common.Unity.Animation.EIKTarget LeftFoot = 2;
	static WizardGames.Soc.Common.Unity.Animation.EIKTarget RightFoot = 3;
	static WizardGames.Soc.Common.Unity.Animation.EIKTarget Count = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Animation.EHorseIKTarget : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Animation.EHorseIKTarget LeftFoot = 0;
	static WizardGames.Soc.Common.Unity.Animation.EHorseIKTarget RightFoot = 1;
	static WizardGames.Soc.Common.Unity.Animation.EHorseIKTarget Count = 2;
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.TwoBoneIKHandle : System.ValueType
{
	WizardGames.Soc.Common.Unity.Animation.AnimTransformHandle Top; // 0x10
	WizardGames.Soc.Common.Unity.Animation.AnimTransformHandle Mid; // 0x30
	WizardGames.Soc.Common.Unity.Animation.AnimTransformHandle Low; // 0x50
	System.Boolean IsValid(UnityEngine.Animations.AnimationStream& stream); // 0x07646dec
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.TpBoneHandle : System.ValueType
{
	System.String BoneName; // 0x10
	WizardGames.Soc.Common.Unity.Animation.AnimTransformHandle Handle; // 0x18
	WizardGames.Soc.Common.Unity.Go.HitBoxInfo HitBoxInfo; // 0x38
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.TpEffectParentBoneHandle : System.ValueType
{
	System.String BoneName; // 0x10
	WizardGames.Soc.Common.Unity.Animation.AnimTransformHandle Handle; // 0x18
	UnityEngine.Matrix4x4 LocalToWorldMatrix; // 0x38
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.AnimTransformHandle : System.ValueType
{
	static SocLogger logger; // 0x0
	System.Boolean IsValid; // 0x10
	System.Boolean IsStream; // 0x11
	UnityEngine.Animations.TransformSceneHandle SceneHandle; // 0x14
	UnityEngine.Animations.TransformStreamHandle StreamHandle; // 0x1c
	System.String BindTargetName; // 0x28
	System.Boolean CheckValid(UnityEngine.Animations.AnimationStream& stream); // 0x07646ee0
	System.Void BindStream(System.String bindName, UnityEngine.Animator animator); // 0x07645de0
	System.Void BindStream(System.String bindName, System.Int32 animatorId); // 0x07640bf8
	UnityEngine.Quaternion GetRotation(UnityEngine.Animations.AnimationStream& stream); // 0x07646fd0
	UnityEngine.Quaternion GetLocalRotation(UnityEngine.Animations.AnimationStream& stream); // 0x076409ec
	System.Void SetLocalPosition(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3 pos); // 0x076470f0
	System.Void SetLocalRotation(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion rotation); // 0x07647218
	System.Void SetRotation(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Quaternion rotation); // 0x07647350
	UnityEngine.Vector3 GetLocalPosition(UnityEngine.Animations.AnimationStream& stream); // 0x076408cc
	UnityEngine.Matrix4x4 GetLocalToWorldMatrix(UnityEngine.Animations.AnimationStream& stream); // 0x076474a0
	UnityEngine.Matrix4x4 GetLocalToParentMatrix(UnityEngine.Animations.AnimationStream& stream); // 0x076475d8
	UnityEngine.Quaternion GetWorldRotation(UnityEngine.Animations.AnimationStream& stream); // 0x07647710
	UnityEngine.Vector3 GetPosition(UnityEngine.Animations.AnimationStream& stream); // 0x07647830
	System.Void SetPosition(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3 pos); // 0x07647918
	static System.Void .cctor(); // 0x07647a58
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.TwoBoneIKEffector : System.ValueType
{
	System.Boolean IsValid; // 0x10
	System.Single Weight; // 0x14
	System.Int32 Target; // 0x18
	System.Int32 EffectorId; // 0x1c
	System.String EffectorName; // 0x20
	System.Int32 EffectorRootId; // 0x28
	System.String EffectorRootName; // 0x30
	System.Int32 EffectorRootParentId; // 0x38
	System.String EffectorRootParentName; // 0x40
	System.Int32 AttachBoneId; // 0x48
	WizardGames.Soc.Common.Unity.Animation.AnimTransformHandle AttachBoneHandle; // 0x50
	WizardGames.Soc.Common.Unity.Animation.AnimTransformHandle LocatorBoneHandle; // 0x70
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.LookAtBoneHandle : System.ValueType
{
	System.String BoneName; // 0x10
	UnityEngine.Vector3 Axis; // 0x18
	UnityEngine.Vector3 BaseForwardOffsetEuler; // 0x24
	WizardGames.Soc.Common.Unity.Animation.AnimTransformHandle BoneHandle; // 0x30
	System.Boolean IsValid(UnityEngine.Animations.AnimationStream stream); // 0x07647aec
	UnityEngine.Vector3 GetForward(UnityEngine.Animations.AnimationStream& stream); // 0x07647b90
	System.Void LookAt(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3 direction, System.Single weight); // 0x07647c40
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.LookAtBoneCache : System.ValueType
{
	RootMotion.FinalIK.ILookAtBone BoneData; // 0x10
	System.String BoneName; // 0x18
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.LookAtIKJobHandle : System.Object
{
	System.Boolean LookAtIKEnabled; // 0x10
	System.Boolean Init; // 0x11
	System.Boolean HasExpectation; // 0x12
	WizardGames.Soc.Common.Unity.Animation.LookAtBoneCache[] expectationSpines; // 0x18
	WizardGames.Soc.Common.Unity.Animation.LookAtBoneCache[] expectationEyes; // 0x20
	WizardGames.Soc.Common.Unity.Animation.LookAtBoneCache expectationHead; // 0x28
	RootMotion.FinalIK.LookAtIKJobData LookAtJobData; // 0x38
	WizardGames.Soc.Common.Unity.Animation.LookAtBoneHandle HeadHandle; // 0xb8
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Animation.LookAtBoneHandle> SpineHandles; // 0xf8
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Animation.LookAtBoneHandle> EyeHandles; // 0x100
	System.Void Setup(RootMotion.FinalIK.ILookAtBone head, RootMotion.FinalIK.ILookAtBone[] spines, RootMotion.FinalIK.ILookAtBone[] eyes); // 0x07646020
	System.Void SetupLookAtBoneHandles(System.Int32 animatorId, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Animation.LookAtBoneHandle> handles, WizardGames.Soc.Common.Unity.Animation.LookAtBoneCache[] bones); // 0x07647e30
	System.Boolean SetupLookAtBoneHandle(System.Int32 animatorId, WizardGames.Soc.Common.Unity.Animation.LookAtBoneHandle& handle, WizardGames.Soc.Common.Unity.Animation.LookAtBoneCache& bone); // 0x07647fb0
	System.Void .ctor(); // 0x076458a8
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.AimBoneHandle : System.ValueType
{
	System.String BoneName; // 0x10
	UnityEngine.Vector3 Axis; // 0x18
	WizardGames.Soc.Common.Unity.Animation.AnimTransformHandle BoneHandle; // 0x28
	System.Single BoneWeight; // 0x48
	System.Boolean IsValid(UnityEngine.Animations.AnimationStream stream); // 0x0764821c
	UnityEngine.Vector3 GetForward(UnityEngine.Animations.AnimationStream& stream); // 0x076482c0
	System.Void RotateToTarget(UnityEngine.Animations.AnimationStream& stream, UnityEngine.Vector3 axis, UnityEngine.Vector3 target, System.Single weight); // 0x07648370
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.AimIKJobHandle : System.Object
{
	System.Int32 MaxIterations; // 0x10
	System.Single Tolerance; // 0x14
	RootMotion.FinalIK.AimIKJobData AimJobData; // 0x18
	WizardGames.Soc.Common.Unity.Animation.AimBoneHandle AimHandle; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Animation.AimBoneHandle> SpineHandles; // 0x78
	System.Single switchWeight; // 0x80
	System.Single switchWeightV; // 0x84
	System.Single switchSmoothTime; // 0x88
	UnityEngine.Vector3 TargetAimPos; // 0x8c
	System.Single posLerpProgress; // 0x98
	System.Boolean SetupAimBoneHandle(System.Int32 animatorId, WizardGames.Soc.Common.Unity.Animation.AimBoneHandle& handle, WizardGames.Soc.Common.Unity.Character.AimBoneProxy bone); // 0x0764867c
	System.Void .ctor(); // 0x07645910
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.IKCalculator : System.Object
{
	
	static System.Void CalcTwoBoneIK(UnityEngine.Animations.AnimationStream& stream, WizardGames.Soc.Common.Unity.Animation.TwoBoneIKHandle ikHandle, WizardGames.Soc.Common.Unity.Animation.TwoBoneIKEffector ikEffector, System.Int32 target, System.Boolean needLocatorBoneHandle); // 0x07640474
	static System.Void SolveTwoBoneIK(UnityEngine.Animations.AnimationStream& stream, WizardGames.Soc.Common.Unity.Animation.TwoBoneIKHandle ikHandle, UnityEngine.Matrix4x4 effectorMatrix, System.Single weight); // 0x076487bc
	static System.Double TriangleAngle(System.Double aLen, System.Double aLen1, System.Double aLen2); // 0x076496f4
	static Unity.Mathematics.quaternion FromToRotation(UnityEngine.Vector3 fromDirection, UnityEngine.Vector3 toDirection); // 0x07649810
	static System.Void CalcLookAtIK(UnityEngine.Animations.AnimationStream& stream, WizardGames.Soc.Common.Unity.Animation.LookAtIKJobHandle& ikHandle, RootMotion.FinalIK.LookAtIKJobData& ikJobData); // 0x07649a84
	static System.Void SolveLookAtSpines(UnityEngine.Animations.AnimationStream& stream, WizardGames.Soc.Common.Unity.Animation.LookAtIKJobHandle& ikHandle, RootMotion.FinalIK.LookAtIKJobData& ikJobData); // 0x07649b54
	static System.Void SolveLookAtHead(UnityEngine.Animations.AnimationStream& stream, WizardGames.Soc.Common.Unity.Animation.LookAtIKJobHandle& ikHandle, RootMotion.FinalIK.LookAtIKJobData& ikJobData); // 0x07649eac
	static System.Void SolveLookAtEyes(UnityEngine.Animations.AnimationStream& stream, WizardGames.Soc.Common.Unity.Animation.LookAtIKJobHandle& ikHandle, RootMotion.FinalIK.LookAtIKJobData& ikJobData); // 0x0764a298
	static UnityEngine.Vector3[] GetForwards(UnityEngine.Vector3[]& forwards, UnityEngine.Vector3 baseForward, UnityEngine.Vector3 targetForward, System.Int32 bones, System.Single clamp, System.Single ikPositionWeight, System.Int32 clampSmoothing, UnityEngine.AnimationCurve spineWeightCurve); // 0x0764a8c0
	static System.Void CalcAimIK(UnityEngine.Animations.AnimationStream& stream, WizardGames.Soc.Common.Unity.Animation.AimIKJobHandle& ikHandle, RootMotion.FinalIK.AimIKJobData& ikJobData); // 0x0764ac80
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.OptSocAnimLateUpdateJob : System.ValueType, UnityEngine.Animations.IAnimationJob
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.Animation.OptLateUpdateContext Context; // 0x10
	WizardGames.Soc.Common.Unity.Animation.AnimTransformHandle PelvisHandle; // 0x78
	WizardGames.Soc.Common.Unity.Animation.AnimTransformHandle RootHandle; // 0x98
	System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream); // 0x0764b12c
	System.Void ProcessPrepareJump(UnityEngine.Animations.AnimationStream stream); // 0x0764b24c
	System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream); // 0x0764c080
	System.Void PostProcessProcedureAnim(UnityEngine.Animations.AnimationStream& stream); // 0x0764c198
	System.Void ProcessJumpOnAnim(WizardGames.Soc.Common.Entity.PlayerEntity player, UnityEngine.Animations.AnimationStream& stream); // 0x0552af00
	System.Void ProcessJumpOnRM(WizardGames.Soc.Common.Entity.PlayerEntity player, UnityEngine.Animations.AnimationStream& stream); // 0x0552af00
	static System.Void ResetJumpPoseData(WizardGames.Soc.Common.Entity.PlayerEntity player); // 0x055049cc
	System.Void ProcessMantle(WizardGames.Soc.Common.Entity.PlayerEntity cur_player, UnityEngine.Animations.AnimationStream& stream); // 0x0552af00
	System.Void CalcTpPosInFpView(WizardGames.Soc.Common.Unity.Animation.AnimTransformHandle& ViewGoHandle, UnityEngine.Animations.AnimationStream& stream); // 0x0764f0dc
	System.Void PostProcessIKAnim(UnityEngine.Animations.AnimationStream& stream); // 0x0764c340
	System.Void InitLookAtIK(); // 0x0764f5d4
	System.Void InitAimIK(WizardGames.Soc.Common.Entity.PlayerEntity p, UnityEngine.Animations.AnimationStream& stream); // 0x0552af00
	System.Void UpdatePlayerIK(WizardGames.Soc.Common.Entity.PlayerEntity cur_player, WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent objectComponent, UnityEngine.Animations.AnimationStream& stream); // 0x0764f338
	System.Void UpdateMonsterNormalHandsIK(WizardGames.Soc.Common.Entity.MonsterEntity monsterEntity, UnityEngine.Animations.AnimationStream& stream); // 0x0764ff34
	Animation.AnimBehCache TryGetAnimCache(System.Int64 entityId); // 0x07652b78
	System.Void UpdateNormalHandsIK(WizardGames.Soc.Common.Entity.PlayerEntity cur_player, WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent objectComponent, UnityEngine.Animations.AnimationStream& stream); // 0x0552d210
	System.Boolean Update4IkOnVehicle(WizardGames.Soc.Common.Entity.PlayerEntity cur_player, WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent objectComponent); // 0x07650a38
	System.Void UpdateZiplineTpHandIK(WizardGames.Soc.Common.Entity.PlayerEntity cur_player, WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent objectComponent, UnityEngine.Animations.AnimationStream& stream); // 0x07651090
	System.Boolean UpdateRideFootIKForSelfTP(WizardGames.Soc.Common.Entity.PlayerEntity cur_player, WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent objectComponent, UnityEngine.Animations.AnimationStream& stream); // 0x07652840
	System.Void SetupIK(); // 0x07650800
	System.Void SetupHandle(WizardGames.Soc.Common.Unity.Animation.TwoBoneIKHandle& handle, System.String topName, System.String midName, System.String lowName); // 0x07653004
	System.Void ResetTwoBoneIKJob(); // 0x0764f2a4
	System.Boolean IsEffectorValid(WizardGames.Soc.Common.Unity.Animation.EIKTarget target); // 0x07650ff0
	System.Void SetEffector(WizardGames.Soc.Common.Unity.Animation.EIKTarget target, System.Int32 effectorId, System.Int32 weaponRootInstId, System.Single weight, System.String locatorBoneName, System.String attachBoneName, System.Int32 attachBoneInstId); // 0x07652ce8
	System.Void ProcessTwoBoneIK(UnityEngine.Animations.AnimationStream& stream); // 0x0764c770
	System.Void ProcessLookAtIK(UnityEngine.Animations.AnimationStream& stream); // 0x0764c88c
	System.Void ProcessAimIK(UnityEngine.Animations.AnimationStream& stream); // 0x0764ca2c
	System.Int32 GetVehicleType(WizardGames.Soc.Common.Entity.PlayerEntity entity, System.Boolean& driver, System.Boolean& passenger); // 0x07652e64
	System.Void ProcessTpBonesInfo(UnityEngine.Animations.AnimationStream& steam); // 0x0764cb50
	System.Void ProcessTpEffectParentInfo(UnityEngine.Animations.AnimationStream& stream); // 0x0764ccd0
	static System.Void .cctor(); // 0x076530f0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.RoleAnimStateMachineBeh : UnityEngine.StateMachineBehaviour
{
	static SocLogger logger; // 0x0
	System.Boolean IsLodDisable(WizardGames.Soc.Common.Unity.Animation.SMBAnimData AnimData); // 0x07653520
	WizardGames.Soc.Common.Unity.Animation.SMBAnimData FoundSmb(UnityEngine.Animator animator); // 0x0765361c
	System.Void OnStateEnterThreadSafe(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex); // 0x076538c4
	System.Void OnStateExitBeginThreadSafe(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex); // 0x07653fb4
	System.Boolean TryPlayWeaponClip(WizardGames.Soc.Common.Unity.Animation.SMBAnimData AnimData, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex); // 0x07653aac
	System.Boolean PlayWeaponIdleClip(WizardGames.Soc.Common.Unity.Animation.SMBAnimData AnimData, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex); // 0x076540cc
	static System.Void ResetToIdle(WizardGames.Soc.Common.Unity.Animation.SMBAnimData AnimData, System.Single normalizedTime); // 0x07654698
	System.Void .ctor(); // 0x07654864
	static System.Void .cctor(); // 0x076548cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.SimpleAnimationPlayable : UnityEngine.MonoBehaviour
{
	UnityEngine.Playables.PlayableGraph _graph; // 0x30
	UnityEngine.Animator _animator; // 0x40
	UnityEngine.Animations.AnimationClipPlayable _clipPlayable; // 0x48
	UnityEngine.AnimationClip _currentClip; // 0x58
	System.Single _currentTime; // 0x60
	System.Void Init(); // 0x076549a0
	System.Void Play(UnityEngine.AnimationClip clip); // 0x07654b04
	System.Void OnDestroy(); // 0x07654c58
	System.Void SetTime(System.Single time); // 0x07654ce8
	System.Void .ctor(); // 0x07654dc0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.SkinnedMeshRendererBoneData : UnityEngine.MonoBehaviour
{
	System.String RootBoneName; // 0x30
	System.String[] BoneNames; // 0x38
	System.Void .ctor(); // 0x07654e28
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.SocAnimatorRuntime : System.Object, WizardGames.Soc.Common.Unity.Animation.ISocAnimationRuntime
{
	static SocLogger logger; // 0x0
	System.Int64 EntityId; // 0x10
	System.Int32 LastCtrlVersion; // 0x18
	UnityEngine.Animator cur_animator; // 0x20
	System.Boolean HasInit(); // 0x07654e90
	System.Void Clear(); // 0x07654f88
	System.Void Init(System.Int64 entityId, UnityEngine.Animator animator); // 0x07654ff4
	System.Void SwitchRuntimeAnimatorController(WizardGames.AssetPool.AssetPoolHandle aoc); // 0x07655240
	System.Void SwitchRuntimeAnimatorController(UnityEngine.RuntimeAnimatorController aoc); // 0x07655308
	UnityEngine.Animator GetAnimator(); // 0x076554a8
	System.Void SetAnimation(WizardGames.Soc.Common.Unity.Character.AnimParametersAnimal& param); // 0x0765550c
	System.Single GetStateNormalizedTime(System.Int32 LayerIndex, System.Int32 StateName); // 0x07655674
	System.Single GetCurveValue(System.Int32 name_idx); // 0x076557d8
	System.Void SetAnimation<T>(T& param); // 0x052af1f0
	System.Void SetServiceAnimation(System.Int32 name, System.Int32 layer, System.Single normalizedTime); // 0x07655938
	System.Void SetServiceAnimationCrossFade(System.Int32 name, System.Int32 layer, System.Single normalizedTimeTransition, System.Single normalizedTime); // 0x07655a7c
	System.Void SetServiceAnimationCrossFadeInFixedTime(System.Int32 name, System.Int32 layer, System.Single normalizedTimeTransition, System.Single normalizedTime); // 0x07655c18
	System.Void SetUpdate(System.Single deltaTime); // 0x07655db4
	System.Void Disable(); // 0x07655ed4
	System.Void Enable(); // 0x07655fd8
	System.Void .ctor(); // 0x076560dc
	static System.Void .cctor(); // 0x07656144
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.HashToStateName : System.Object
{
	static System.Collections.Generic.Dictionary<System.Int32,System.String> _hashToStateNameMap; // 0x0
	static System.String GetStateName(System.Int32 hash); // 0x076561d8
	static System.Void .cctor(); // 0x076562c8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.StateToAnimHashMapper : System.Object
{
	static System.Collections.Generic.Dictionary<System.Int32,System.Single> LocomotionLayer_AnimLengthMap; // 0x0
	static System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.Animation.StateToAnimHashMapper.PlayerStateKey,System.Int32> _playerStateToHashMap; // 0x8
	static System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.Animation.StateToAnimHashMapper.MonsterStateKey,System.Int32> _monsterStateToHashMap; // 0x10
	static System.Boolean TryGetHash(WizardGames.Soc.Common.Entity.PlayerEntity player, System.Boolean iswalking, System.Int32& hash); // 0x0765696c
	static System.Boolean TryGetHash(WizardGames.Soc.Common.Entity.MonsterEntity monster, System.Int32& hash); // 0x07656b70
	static System.Boolean GetStateName(System.Int32 hash, System.String& stateName); // 0x07656cdc
	static System.Void .cctor(); // 0x07656dac
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.StateToAnimHashMapper.PlayerStateKey : System.ValueType, System.IEquatable<WizardGames.Soc.Common.Unity.Animation.StateToAnimHashMapper.PlayerStateKey>
{
	WizardGames.Soc.Common.Entity.PlayerMoveStateEnum PlayerMoveState; // 0x10
	WizardGames.Soc.Common.Entity.PlayerPoseStateEnum PlayerPoseState; // 0x11
	System.Int32 PlayerMovement8Direction; // 0x14
	System.Boolean IsWalking; // 0x18
	System.Void .ctor(WizardGames.Soc.Common.Entity.PlayerEntity player, System.Boolean iswalking); // 0x07656ab4
	System.Boolean Equals(WizardGames.Soc.Common.Unity.Animation.StateToAnimHashMapper.PlayerStateKey other); // 0x07657650
	System.Boolean Equals(System.Object obj); // 0x07657710
	System.Int32 GetHashCode(); // 0x076577d8
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.StateToAnimHashMapper.MonsterStateKey : System.ValueType, System.IEquatable<WizardGames.Soc.Common.Unity.Animation.StateToAnimHashMapper.MonsterStateKey>
{
	WizardGames.Soc.Common.Entity.MonsterEntity.ELocomotionLayerState LocomotionLayerState; // 0x10
	WizardGames.Soc.Common.Entity.MonsterEntity.ELocomotionDir LocomotionDir; // 0x14
	System.Void .ctor(WizardGames.Soc.Common.Entity.MonsterEntity monster); // 0x07656c54
	System.Boolean Equals(WizardGames.Soc.Common.Unity.Animation.StateToAnimHashMapper.MonsterStateKey other); // 0x076578a0
	System.Boolean Equals(System.Object obj); // 0x07657938
	System.Int32 GetHashCode(); // 0x076579fc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.SyncSmb : UnityEngine.StateMachineBehaviour
{
	
	WizardGames.Soc.Common.Unity.Animation.SMBAnimData FoundSmb(UnityEngine.Animator animator); // 0x07657aa0
	System.Void TrySavePhase(UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, WizardGames.Soc.Common.Unity.Animation.SMBAnimData animData); // 0x07657d48
	System.Void RunPhaseMatch(CommonUnity.Runtime.Character.PhaseKeySource phasekey, System.Int32 animatorId, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, WizardGames.Soc.Common.Unity.Character.PhaseGroupScriptObjProxy AnimPhaseMap, CommonUnity.Runtime.Character.AnimPhaseMatchKey matchKey, WizardGames.Soc.Common.Unity.Animation.SMBAnimData animData); // 0x076592bc
	System.Void RunPhaseMatch(CommonUnity.Runtime.Character.PhaseKeySource phasekey, System.Int32& animatorId, UnityEngine.AnimatorStateInfo& stateInfo, System.Int32& layerIndex, WizardGames.Soc.Common.Unity.Character.TpMetaDataProxy meta, CommonUnity.Runtime.Character.AnimPhaseMatchKey& matchKey, WizardGames.Soc.Common.Unity.Animation.SMBAnimData animData); // 0x076596b0
	static System.Void SavePhaseOffset(CommonUnity.Runtime.Character.PhaseKeySource keySource, UnityEngine.AnimatorStateInfo& stateInfo, System.Int32& layerIndex, WizardGames.Soc.Common.Unity.Character.TpMetaDataProxy meta, WizardGames.Soc.Common.Unity.Animation.SMBAnimData animData); // 0x07658c24
	static System.Void SavePhaseOffset(CommonUnity.Runtime.Character.PhaseKeySource keySource, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex, WizardGames.Soc.Common.Unity.Character.PhaseGroupScriptObjProxy animPhaseObj, WizardGames.Soc.Common.Unity.Animation.SMBAnimData animData); // 0x07658640
	System.Void OnStateEnterThreadSafe(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex); // 0x07659b0c
	System.Void OnStateExitBeginThreadSafe(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex); // 0x0765a8d4
	System.Void FireStepAudioMsg(WizardGames.Soc.Common.Unity.Animation.SMBAnimData animData); // 0x0765ae20
	System.Void .ctor(); // 0x0765b014
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.PostTimelineAnimatorRecordJob : System.ValueType, UnityEngine.Animations.IAnimationJob
{
	WizardGames.Soc.Common.Unity.Animation.ITimelinePostAnimJobProcessor Processor; // 0x10
	System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream); // 0x0765b07c
	System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream); // 0x0765b1b8
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.PostTimelineAnimMixJob : System.ValueType, UnityEngine.Animations.IAnimationJob
{
	WizardGames.Soc.Common.Unity.Animation.ITimelinePostAnimJobProcessor Processor; // 0x10
	System.Void ProcessAnimation(UnityEngine.Animations.AnimationStream stream); // 0x0765b240
	System.Void ProcessRootMotion(UnityEngine.Animations.AnimationStream stream); // 0x0765b380
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.TimelineAnimationWeight : UnityEngine.ScriptableObject, WizardGames.Soc.Common.Unity.Animation.ITimelineWeight
{
	static System.Collections.Generic.Dictionary<System.Int32,System.String> boneIndex2NameMap; // 0x0
	WizardGames.Editor.SkeletonMaskWeightValue[] WeightList; // 0x18
	System.Void RefreshHandles(System.Int32 animatorId, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Animation.TimelineBoneHandle>& handles); // 0x0765b408
	System.Void .ctor(); // 0x0765b7f8
	static System.Void .cctor(); // 0x0765b890
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.TimelineBoneHandle : System.ValueType
{
	Unity.Mathematics.float3 recordlocalposition; // 0x10
	Unity.Mathematics.quaternion recordlocalrotation; // 0x1c
	WizardGames.Soc.Common.Unity.Animation.AnimTransformHandle bonehandle; // 0x30
	System.Single weight; // 0x50
	System.Void Bind(System.Int32 animatorId, System.String name); // 0x0765b748
	System.Void SetWeight(System.Single weight); // 0x0765bc7c
	System.Void Record(UnityEngine.Animations.AnimationStream stream); // 0x0765bcf4
	System.Void Blend(UnityEngine.Animations.AnimationStream stream); // 0x0765bde4
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Animation.TimelineSource : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Animation.TimelineSource None = -1;
	static WizardGames.Soc.Common.Unity.Animation.TimelineSource Interactive = 0;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.TimelinePlayer : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	static SocLogger logger; // 0x0
	UnityEngine.GameObject MainGo; // 0x10
	UnityEngine.Animator Animator; // 0x18
	WizardGames.Soc.Common.Unity.Animation.TimelinePostAnimProcessor PostProcessor; // 0x20
	WizardGames.Soc.Common.Unity.Animation.TimelineSource <TimelineSource>k__BackingField; // 0x28
	static WizardGames.Soc.Common.Unity.Animation.TimelinePlayer Create(UnityEngine.GameObject maingo, UnityEngine.Animator animator); // 0x0765bf60
	WizardGames.Soc.Common.Unity.Animation.TimelineSource get_TimelineSource(); // 0x0765c10c
	System.Void set_TimelineSource(WizardGames.Soc.Common.Unity.Animation.TimelineSource value); // 0x0765c170
	System.Void Init(UnityEngine.GameObject maingo, UnityEngine.Animator animator); // 0x0765c030
	System.Void PlayTimeline(UnityEngine.Playables.PlayableAsset timeline, WizardGames.Soc.Common.Unity.Animation.TimelineAnimationWeight weightConfig, WizardGames.Soc.Common.Unity.Animation.TimelineSource source, System.Boolean loop); // 0x0765c2a0
	System.Void StopTimeline(WizardGames.Soc.Common.Unity.Animation.TimelineSource source); // 0x0765cd34
	System.Void OnGet(); // 0x0765d8c8
	System.Void OnRelease(); // 0x0765d928
	System.Void OnDestroy(); // 0x0765d9f8
	System.Void .ctor(); // 0x0765da58
	static System.Void .cctor(); // 0x0765dac0
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Animation.ITimelineWeight : 
{
	
	System.Void RefreshHandles(System.Int32 animatorId, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Animation.TimelineBoneHandle>& handles); // 0x0550f6d4
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Animation.ITimelinePostAnimJobProcessor : 
{
	
	System.Void Record(UnityEngine.Animations.AnimationStream stream); // 0x0551c138
	System.Void Blend(UnityEngine.Animations.AnimationStream stream); // 0x0551c138
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.TimelinePostAnimProcessor : System.Object, WizardGames.Soc.Common.Unity.Animation.ITimelinePostAnimJobProcessor, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	static SocLogger logger; // 0x0
	UnityEngine.Playables.PlayableGraph AnimatorRecordGraph; // 0x10
	WizardGames.Soc.Common.Unity.Animation.PostTimelineAnimatorRecordJob animatorRecordJob; // 0x20
	UnityEngine.Playables.PlayableGraph AnimMixGraph; // 0x28
	WizardGames.Soc.Common.Unity.Animation.PostTimelineAnimMixJob animMixJob; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Animation.TimelineBoneHandle> handles; // 0x40
	UnityEngine.Animations.AnimationPlayableOutput recordoutput; // 0x48
	UnityEngine.Animations.AnimationPlayableOutput mixoutput; // 0x58
	WizardGames.Soc.Common.Unity.Animation.ITimelineWeight Config; // 0x68
	System.Int32 startframe; // 0x70
	static WizardGames.Soc.Common.Unity.Animation.TimelinePostAnimProcessor Create(UnityEngine.Animator animator); // 0x0765c1e8
	System.Void Init(UnityEngine.Animator animator); // 0x0765db94
	System.Void BindAnimationWeight(System.Int32 animatorId, WizardGames.Soc.Common.Unity.Animation.ITimelineWeight config); // 0x0765cb04
	System.Void Record(UnityEngine.Animations.AnimationStream stream); // 0x0765ddfc
	System.Void Blend(UnityEngine.Animations.AnimationStream stream); // 0x0765df68
	System.Void StartProcess(); // 0x0765cc1c
	System.Void StopProcess(); // 0x0765d7b8
	System.Void OnGet(); // 0x0765e08c
	System.Void OnRelease(); // 0x0765e0ec
	System.Void OnDestroy(); // 0x0765e1a4
	System.Void .ctor(); // 0x0765e204
	static System.Void .cctor(); // 0x0765e2b8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.TwoBoneIKComponentAutoUpdate : WizardGames.Soc.Common.Unity.Animation.TwoBoneIKComponent
{
	UnityEngine.Transform IKPoint; // 0x50
	UnityEngine.Transform WeaponLocatorInRole; // 0x58
	System.Single weight; // 0x60
	System.Void ForceUpdate(); // 0x0765e38c
	System.Void LateUpdate(); // 0x0765e3f0
	System.Void Disable(); // 0x0765e7d4
	System.Void .ctor(); // 0x0765e868
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.TwoBoneIKComponent : UnityEngine.MonoBehaviour
{
	System.String IKName; // 0x30
	UnityEngine.Transform top; // 0x38
	UnityEngine.Transform mid; // 0x40
	UnityEngine.Transform low; // 0x48
	System.Void UpdateIK(UnityEngine.Transform effectorHandle, System.Single weight); // 0x0765e934
	System.Void UpdateIK(Unity.Mathematics.double4x4 EffectorMatrix, System.Single weight); // 0x0765e680
	System.Void UpdateIKWithScale(UnityEngine.Transform effector, UnityEngine.Transform offset, System.Single weight); // 0x0765fd9c
	System.Void UpdateIK(UnityEngine.Matrix4x4 EffectorMatrix); // 0x0766013c
	System.Void .ctor(); // 0x0765e8cc
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.TwoBoneIKJob : System.ValueType
{
	
	static System.Double TriangleAngle(System.Double aLen, System.Double aLen1, System.Double aLen2); // 0x076602c0
	static Unity.Mathematics.quaternion FromToRotation(Unity.Mathematics.double3 fromDirection, Unity.Mathematics.double3 toDirection); // 0x076603dc
	static System.Void Solve(UnityEngine.Transform topHandle, UnityEngine.Transform midHandle, UnityEngine.Transform lowHandle, UnityEngine.Transform effectorHandle, System.Single weight); // 0x0765ea90
	static System.Void SolveWithScaleD(UnityEngine.Transform upperHandle, UnityEngine.Transform midHandle, UnityEngine.Transform lowHandle, UnityEngine.Transform effector, Unity.Mathematics.double3 desiredEffPos, UnityEngine.Quaternion desiredEffRot, System.Single weight); // 0x076605cc
	static System.Void SolveWithScale(UnityEngine.Transform upperHandle, UnityEngine.Transform midHandle, UnityEngine.Transform lowHandle, UnityEngine.Transform effector, UnityEngine.Vector3 desiredEffPos, UnityEngine.Quaternion desiredEffRot, System.Single weight); // 0x07661bb4
	static System.Void SolveWithScaleAndOffset(UnityEngine.Transform upperHandle, UnityEngine.Transform midHandle, UnityEngine.Transform lowHandle, UnityEngine.Transform effector, UnityEngine.Transform offset, System.Single weight); // 0x0765fee0
	static System.Void Solve(UnityEngine.Transform topHandle, UnityEngine.Transform midHandle, UnityEngine.Transform lowHandle, Unity.Mathematics.double4x4 EffectorMatrix, System.Single weight); // 0x0765eb9c
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Animation.ISocAnimationRuntime : 
{
	
	System.Boolean HasInit(); // 0x054c4760
	System.Void Init(System.Int64 entityId, UnityEngine.Animator animator); // 0x055128b0
	System.Void SetAnimation<T>(T& param); // 0x052af1f0
	UnityEngine.Animator GetAnimator(); // 0x054e7844
	System.Void SetAnimation(WizardGames.Soc.Common.Unity.Character.AnimParametersAnimal& param); // 0x05523a54
	System.Void SetServiceAnimation(System.Int32 name, System.Int32 layer, System.Single normalizedTime); // 0x055063e0
	System.Void SetServiceAnimationCrossFade(System.Int32 name, System.Int32 layer, System.Single normalizedTimeTransition, System.Single normalizedTime); // 0x0550645c
	System.Void SetServiceAnimationCrossFadeInFixedTime(System.Int32 name, System.Int32 layer, System.Single normalizedTimeTransition, System.Single normalizedTime); // 0x0550645c
	System.Single GetStateNormalizedTime(System.Int32 LayerName, System.Int32 StateName); // 0x054a5bc0
	System.Void SwitchRuntimeAnimatorController(UnityEngine.RuntimeAnimatorController aoc); // 0x05523a54
	System.Void SwitchRuntimeAnimatorController(WizardGames.AssetPool.AssetPoolHandle aoc); // 0x05519098
	System.Void SetUpdate(System.Single deltaTime); // 0x05513724
	System.Void Clear(); // 0x055049cc
	System.Void Disable(); // 0x055049cc
	System.Void Enable(); // 0x055049cc
	System.Single GetCurveValue(System.Int32 name_idx); // 0x054a5b8c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.AnimWarpingSystemUtils : System.Object
{
	static SocLogger logger; // 0x0
	static UnityEngine.Vector3[] CachedPos3Array; // 0x8
	static UnityEngine.Vector3[] CachedRot3Array; // 0x10
	static System.Collections.Generic.List<KAnimation.RootMotionWarping.RootMotionWarpingData> resList; // 0x18
	static System.Void InitRes(); // 0x07662e94
	static System.Void Clear(); // 0x076630f0
	static System.Void CheckRefreshRootMotionData(WizardGames.Soc.Common.Entity.PlayerEntity selfPlayer); // 0x0766323c
	static System.Void CalculateRootMotionCcMotion(WizardGames.Soc.Common.Unity.Animation.SocMantleWarpData& Data, System.Int32 TargetTimeMS, UnityEngine.Vector3& OutPosition); // 0x07663ee8
	static System.Void CalculateRootMotionCcMotionWithMantle(WizardGames.Soc.Common.Unity.Animation.SocMantleWarpData& Data, System.Int32 TargetTimeMS, System.Int32 rootMotionWarpingIndex, UnityEngine.Vector3& OutPosition); // 0x07664174
	static KAnimation.RootMotionWarping.RootMotionWarpingData FindRootMotion(WizardGames.Soc.Common.Entity.PlayerEntity selfPlayer, System.Int32 resNumber); // 0x07664504
	static System.Boolean GetRootMotionStartEndPos(WizardGames.Soc.Common.Entity.PlayerEntity selfPlayer, WizardGames.Soc.Common.Unity.Animation.AnimationWarpingResType animType, System.Int32& data_size, UnityEngine.Vector3& startPos, UnityEngine.Vector3& endPos); // 0x076637f8
	static System.Boolean GetSelectWarpingData(WizardGames.Soc.Common.Entity.PlayerEntity selfPlayer); // 0x076649b0
	static System.Void PreGetRootMotionData(WizardGames.Soc.Common.Entity.PlayerEntity selfPlayer, WizardGames.Soc.Common.Unity.Animation.AnimationWarpingResType resType); // 0x07663d44
	static System.Void PreGetRootMotionDataDetail(WizardGames.Soc.Common.Entity.PlayerEntity selfPlayer, WizardGames.Soc.Common.Unity.Animation.AnimationWarpingResType resType); // 0x07665058
	static System.Int32 GetRootMotionPose(WizardGames.Soc.Common.Entity.PlayerEntity selfPlayer, WizardGames.Soc.Common.Unity.Animation.AnimationWarpingResType resType); // 0x07666010
	static System.Void PoseSearchRootMotion(UnityEngine.Vector3 fromPosition, UnityEngine.Vector3 toPosition, WizardGames.Soc.Common.Entity.PlayerEntity entity, WizardGames.Soc.Common.Unity.Animation.AnimationWarpingResType resTypeKey, KAnimation.RootMotionWarping.RootMotionWarpingData& selectData, System.Int32& resNumber, System.Boolean findMaxHigh); // 0x076663fc
	static System.Boolean PoseSearchRootMotion(System.Collections.Generic.List<KAnimation.RootMotionWarping.RootMotionWarpingData> resList, System.Int32& selectIndex, UnityEngine.Vector3 fromPosition, UnityEngine.Vector3 toPosition, System.Boolean findMaxHigh); // 0x076669e8
	static System.Boolean RefreshRootMotionData(WizardGames.Soc.Common.Entity.PlayerEntity selfPlayer, UnityEngine.Vector3[] targetPositionList, UnityEngine.Vector3[] targetRotationList, System.Int32 data_size, System.Boolean enable_rot); // 0x07665354
	static System.Void .cctor(); // 0x07666f54
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.SerializeBoneSkeletonTreeNode : System.Object
{
	System.Int32 BoneIndex; // 0x10
	System.Int32 ParentIndex; // 0x14
	System.String BoneName; // 0x18
	System.Void .ctor(); // 0x076671d0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.SerializeBoneSkeletonTree : System.Object
{
	WizardGames.Soc.Common.Unity.Animation.SerializeBoneSkeletonTreeNode[] Nodes; // 0x10
	SerializableDictionary<System.String,System.Int32> BoneName2IndexMap; // 0x18
	UnityEngine.Transform[] AllTransforms; // 0x20
	UnityEngine.Transform root; // 0x28
	System.Void Clear(); // 0x07667238
	System.Void CopyTo(KAnimation.Common.UnsafeBoneSkeletonTree& tree); // 0x076672d4
	System.Void .ctor(); // 0x0766787c
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.SMBAnimClipInfo : System.ValueType, System.IEquatable<WizardGames.Soc.Common.Unity.Animation.SMBAnimClipInfo>
{
	System.Int32 ClipId; // 0x10
	System.String ClipName; // 0x18
	System.Boolean Equals(WizardGames.Soc.Common.Unity.Animation.SMBAnimClipInfo other); // 0x076678e4
	System.Int32 GetHashCode(); // 0x0766796c
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.SMBAnimLogicParams : System.ValueType
{
	System.Boolean UseExtraDraw; // 0x10
	System.Single ADSProgress; // 0x14
	System.Int32 Clips; // 0x18
	WizardGames.Soc.Common.Weapon.EHeldItem HeldItemType; // 0x1c
	System.String WeaponKeywords; // 0x20
	System.Boolean is_paddle; // 0x28
	System.Boolean in_keyak; // 0x29
	System.Boolean useSubCrl; // 0x2a
	System.Boolean is_crossbow; // 0x2b
	System.Boolean useFullBucket; // 0x2c
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Animation.SMBClipType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Animation.SMBClipType FpClip = 0;
	static WizardGames.Soc.Common.Unity.Animation.SMBClipType TpClip = 1;
	static WizardGames.Soc.Common.Unity.Animation.SMBClipType MonsterClip = 2;
	static WizardGames.Soc.Common.Unity.Animation.SMBClipType MonsterBowClip = 3;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.AnimPhaseMatchData : System.Object
{
	CommonUnity.Runtime.Character.AnimPhaseMatchKey MatchKey; // 0x10
	System.Int32 syncStateHash; // 0x20
	System.Boolean isSync; // 0x24
	System.Int32 updatedStateHash; // 0x28
	System.Int64 updatedFrameNumber; // 0x30
	System.Int32 lastExitStateHash; // 0x38
	System.Int64 lastExitFrameNumber; // 0x40
	System.Void .ctor(); // 0x076679d0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.SMBAnimData : System.Object
{
	System.Boolean Fp; // 0x10
	System.Int32 AnimatorId; // 0x14
	System.Int64 FrameNumber; // 0x18
	System.Single TransitionTime; // 0x20
	System.Int32 IdleHash; // 0x24
	System.Int64 OwnerEntityId; // 0x28
	WizardGames.Soc.Common.Entity.PlayerCharacterTypeEnum CharacterType; // 0x30
	System.Int64 WeaponEntityId; // 0x38
	System.Int64 WeaponTableId; // 0x40
	System.Int64 WeaponSkinId; // 0x48
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.HashSet<System.Int32>> EnterTriggerHashSet; // 0x50
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Unity.Animation.AnimPhaseMatchData> PhaseMatchKeyMap; // 0x58
	System.Collections.Generic.HashSet<System.Int32> ExitTriggerHashSet; // 0x60
	System.Int32 LastPlayingHash; // 0x68
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> LayerIndexMap; // 0x70
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Animation.SMBAnimClipInfo>> WeaponBindingData; // 0x78
	System.Int32 WeaponAnimatorInstId; // 0x80
	WizardGames.Soc.Common.Unity.Animation.SMBAnimLogicParams LogicParams; // 0x88
	System.Int32 loopPlayAudioSyncSmbInsId; // 0xa8
	System.Single[] playAudioTimes; // 0xb0
	System.Int32 prePlayAudioTimeIndex; // 0xb8
	System.Single prePlayAudioTime; // 0xbc
	System.Int32 GetFpIdlePoseName(WizardGames.Editor.FpClipSettingMeta clipSettingMeta); // 0x07654310
	System.Int32 GetTpIdlePoseName(WizardGames.Soc.Common.Unity.Character.TpMetaDataProxy clipSettingMeta); // 0x0765457c
	System.Void .ctor(); // 0x07667a38
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Animation.AnimationWarpingResType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Animation.AnimationWarpingResType None = 0;
	static WizardGames.Soc.Common.Unity.Animation.AnimationWarpingResType MantleOn = 1;
	static WizardGames.Soc.Common.Unity.Animation.AnimationWarpingResType MantleOver = 2;
	static WizardGames.Soc.Common.Unity.Animation.AnimationWarpingResType LadderTopOver = 3;
	static WizardGames.Soc.Common.Unity.Animation.AnimationWarpingResType LadderTopIn = 4;
	static WizardGames.Soc.Common.Unity.Animation.AnimationWarpingResType LadderBottomIn = 5;
	static WizardGames.Soc.Common.Unity.Animation.AnimationWarpingResType LadderBottomOver = 6;
	static WizardGames.Soc.Common.Unity.Animation.AnimationWarpingResType End = 7;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Animation.RootMotionWarpingIndexEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Animation.RootMotionWarpingIndexEnum None = 0;
	static WizardGames.Soc.Common.Unity.Animation.RootMotionWarpingIndexEnum MantleOnLowNear = 1;
	static WizardGames.Soc.Common.Unity.Animation.RootMotionWarpingIndexEnum MantleOnLowFar = 11;
	static WizardGames.Soc.Common.Unity.Animation.RootMotionWarpingIndexEnum MantleOnHighNear = 21;
	static WizardGames.Soc.Common.Unity.Animation.RootMotionWarpingIndexEnum MantleOnHighFar = 31;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.SocAnimationWarpingData : System.Object, Src.Animation.ISocAnimWarpingData
{
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.Animation.AnimationWarpingResType,System.Collections.Generic.List<KAnimation.RootMotionWarping.RootMotionWarpingData>> WarpingResMap; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Animation.SocMantleWarpData> MantleWarpDataMap; // 0x18
	WizardGames.Soc.Common.Unity.Animation.SocMantleWarpData GetMantleData(System.Int64 entityId); // 0x076636f4
	System.Void .ctor(); // 0x07667b18
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.SocMantleWarpData : System.Object
{
	System.Boolean BValid; // 0x10
	System.Boolean JobInit; // 0x11
	UnityEngine.Matrix4x4 CCStartInWS; // 0x14
	UnityEngine.Matrix4x4 ConvertMatrix; // 0x54
	UnityEngine.Matrix4x4 CCTargetInWS; // 0x94
	System.Int32 ResNumber; // 0xd4
	System.Single HorizontalSpeed; // 0xd8
	System.Single VerticalSpeed; // 0xdc
	UnityEngine.Vector3[] MotionList; // 0xe0
	UnityEngine.Quaternion[] RotationList; // 0xe8
	UnityEngine.Vector3[] EntityPositionList; // 0xf0
	UnityEngine.Quaternion[] EntityRotationList; // 0xf8
	KAnimation.RootMotionWarping.RootMotionWarpJob RootMotionAnimationJob; // 0x100
	KAnimation.RootMotionWarping.RootMotionWarpingData SelectWarpingData; // 0x1f8
	System.Int32 GetDurationBySpeed(); // 0x076640b8
	System.Boolean isFinished(System.Int32 currentTime); // 0x07667c28
	System.Void Reset(); // 0x07664fdc
	System.Void .ctor(); // 0x07667aa0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.SocAnimOptimizer : UnityEngine.MonoBehaviour
{
	WizardGames.Soc.Common.Unity.Utility.SocAnimOptimizationType AnimType; // 0x30
	System.Int64 EntityId; // 0x38
	UnityEngine.Animator OwnAnimator; // 0x40
	System.Void Start(); // 0x07667cac
	System.Void RefreshOptimization(); // 0x07667d40
	System.Void .ctor(); // 0x07667df0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.TransformCacheComponent : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	SerializableDictionary<System.String,UnityEngine.Transform> TransCache; // 0x30
	System.Void Awake(); // 0x07667e60
	System.Void OnDestroy(); // 0x07668200
	UnityEngine.Transform GetTransForm(System.String Name); // 0x07668284
	System.Void RefreshCache(); // 0x07667ec4
	System.Void .ctor(); // 0x07668338
	static System.Void .cctor(); // 0x076683ec
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBone : UnityEngine.MonoBehaviour
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBone.Particle> m_Particles; // 0x30
	System.String m_tag; // 0x38
	System.Boolean useBoneReference; // 0x40
	UnityEngine.Transform boneRoot; // 0x48
	System.String boneRootName; // 0x50
	System.Boolean m_IsChain; // 0x58
	UnityEngine.Transform m_EndBone; // 0x60
	System.String boneEndName; // 0x68
	System.Single m_Inert; // 0x70
	UnityEngine.AnimationCurve m_InertDistrib; // 0x78
	System.Single m_InertObj; // 0x80
	UnityEngine.AnimationCurve m_InertObjDistrib; // 0x88
	System.Single m_Damping; // 0x90
	UnityEngine.AnimationCurve m_DampingDistrib; // 0x98
	System.Single m_Elasticity; // 0xa0
	UnityEngine.AnimationCurve m_ElasticityDistrib; // 0xa8
	System.Single m_Stiffness; // 0xb0
	UnityEngine.AnimationCurve m_StiffnessDistrib; // 0xb8
	UnityEngine.Vector3 m_Gravity; // 0xc0
	UnityEngine.Vector3 m_ConstForce; // 0xcc
	System.Single m_ConstWindFactor; // 0xd8
	System.Single m_WindFactor; // 0xdc
	System.Single m_WindFreqFactor; // 0xe0
	UnityEngine.Vector3 m_WindDirection; // 0xe4
	UnityEngine.Vector3 m_WindNoise; // 0xf0
	System.Single m_Radius; // 0xfc
	UnityEngine.AnimationCurve m_RadiusDistrib; // 0x100
	UnityEngine.Vector3 m_ColOffset; // 0x108
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneCollider> m_Colliders; // 0x118
	System.Collections.Generic.List<System.String> m_ColliderNames; // 0x120
	System.Int32 m_MaxBoneChainLength; // 0x128
	UnityEngine.Transform meshBone; // 0x130
	System.Boolean IsValid(); // 0x076684c0
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBone.Particle> GetParticles(); // 0x07668554
	System.Int32 AddChild(UnityEngine.Transform parent, System.Int32 parentIdx, System.Boolean isDynamic, System.Int32 depth); // 0x076685b8
	System.Void CalculateBones(); // 0x07668c48
	System.String GetBoneRootName(); // 0x076690b8
	System.Single get_Elasticity(); // 0x07669128
	System.Void set_Elasticity(System.Single value); // 0x0766918c
	System.Single get_Inert(); // 0x07669204
	System.Void set_Inert(System.Single value); // 0x07669268
	System.Single get_Damping(); // 0x076692e0
	System.Void set_Damping(System.Single value); // 0x07669344
	System.Single get_Stiffness(); // 0x076693bc
	System.Void set_Stiffness(System.Single value); // 0x07669420
	static System.Void CopyPhysicsBone(WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBone ori, WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBone& dest); // 0x07669498
	System.Boolean UpdateExternalSourceCollider(UnityEngine.Transform root); // 0x07669664
	System.Collections.Generic.List<UnityEngine.Transform> GetBoneChildList(UnityEngine.Transform t); // 0x07668a64
	System.Void .ctor(); // 0x076699f4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBone.Particle : System.Object
{
	System.Boolean isDynamic; // 0x10
	UnityEngine.Transform m_Transform; // 0x18
	System.Int32 m_ParentIndex; // 0x20
	UnityEngine.Vector3 v; // 0x24
	UnityEngine.Vector3 virtualPos; // 0x30
	UnityEngine.Quaternion initLocalRot; // 0x3c
	UnityEngine.Vector3 initLocalPos; // 0x4c
	UnityEngine.Transform rootBone; // 0x58
	UnityEngine.Quaternion worldRot; // 0x60
	WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBone boneGroupInfo; // 0x70
	UnityEngine.Matrix4x4 localToWorld; // 0x78
	System.Int32 depth; // 0xb8
	System.Void .ctor(); // 0x07668bd0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneCollider : UnityEngine.MonoBehaviour
{
	System.Single m_Radius; // 0x30
	System.Single m_Height; // 0x34
	UnityEngine.Vector3 m_Center; // 0x38
	WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.ColliderType m_ColType; // 0x44
	WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.ColDirectionType m_Direction; // 0x48
	System.Boolean m_IsPositiveDirection; // 0x4c
	System.Void .ctor(); // 0x07669af0
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.PhysicsBone.RendererBoneIndex : System.ValueType
{
	System.String bonePath; // 0x10
	UnityEngine.SkinnedMeshRenderer renderer; // 0x18
	System.Int32 boneIndex; // 0x20
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneDataCache : UnityEngine.MonoBehaviour
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBone> PhysicsBoneComponents; // 0x30
	System.Collections.Generic.List<UnityEngine.Transform> PhysicsBoneRoot; // 0x38
	System.Collections.Generic.List<System.String> PhysicsBoneRootParentName; // 0x40
	System.Collections.Generic.List<UnityEngine.SkinnedMeshRenderer> PhysicsBoneRenderer; // 0x48
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneGroup> PhysicsBoneGroups; // 0x50
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Animation.PhysicsBone.RendererBoneIndex> RendererBoneIndexCache; // 0x58
	System.Collections.Generic.List<UnityEngine.Transform> BackupBoneRoot; // 0x60
	System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Animation.PhysicsBone.RendererBoneIndex>> _rendererBoneIndexDict; // 0x68
	static System.Int32 _BackUpPrefixLen; // 0x0
	System.Void ClearCache(); // 0x07669b68
	System.Boolean RepairMissingBones(); // 0x07669cb4
	System.Void BuildRendererBoneIndexDict(); // 0x0766a358
	System.Void .ctor(); // 0x0766a6dc
	static System.Void .cctor(); // 0x0766a898
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneGroup : UnityEngine.MonoBehaviour
{
	System.Boolean DebugMode; // 0x30
	System.Boolean useMultiSkineedMeshRenderer; // 0x31
	UnityEngine.SkinnedMeshRenderer skinnedMeshRenderer; // 0x38
	System.Collections.Generic.List<UnityEngine.SkinnedMeshRenderer> skinnedMeshRenderers; // 0x40
	System.Boolean useLodGroup; // 0x48
	System.Single blendInTime; // 0x4c
	System.Single maxBlendRate; // 0x50
	System.Boolean needSwitchOtherMesh; // 0x54
	System.Single cullingDistance; // 0x58
	System.Collections.Generic.List<UnityEngine.SkinnedMeshRenderer> normalSkinnedMeshRenderList; // 0x60
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneCollider> colliders; // 0x68
	System.Int32 boneNumbers; // 0x70
	WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.PhysicsBoneStaticBuffer[] physicsBoneStaticArray; // 0x78
	WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.PhysicsBoneRuntimeBuffer[] physicsBoneRuntimeArray; // 0x80
	WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.RenderBonesBuffer[] renderBonesArray; // 0x88
	WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.ColliderIndies[] colliderIndiesArray; // 0x90
	UnityEngine.Transform[] ParentTransforms; // 0x98
	UnityEngine.Transform[] boneTransforms; // 0xa0
	System.Int32[] boneOptTransofrmIndex; // 0xa8
	System.Int32 bufferOffset; // 0xb0
	System.Int32 colliderBufferOffset; // 0xb4
	System.Int32 maxBoneChainLength; // 0xb8
	System.Single blendedTime; // 0xbc
	WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager mgr; // 0xc0
	UnityEngine.Coroutine initFuncCoroutine; // 0xc8
	System.Boolean isActive; // 0xd0
	System.Boolean _isPause; // 0xd1
	UnityEngine.Transform _cullingDetailParent; // 0xd8
	System.Collections.Generic.List<UnityEngine.ComputeShader> modifySkinPoseShaderList; // 0xe0
	System.Collections.Generic.List<System.Int32[]> skinPoseOffsetArrayList; // 0xe8
	System.Collections.Generic.List<UnityEngine.ComputeBuffer> skinPoseOffsetBufferList; // 0xf0
	SocLogger logger; // 0xf8
	System.Void InitBones(); // 0x0766a904
	System.Void InitColliderIndies(System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneCollider> boneColliders, System.Int32 boneIdx, System.Boolean isDynamic); // 0x0766c184
	System.Int32 GetColliderNum(); // 0x0766c4f8
	System.Void RuntimeInit(); // 0x0766c574
	static UnityEngine.SkinnedMeshRenderer GetLodRenderByIndex(UnityEngine.SkinnedMeshRenderer renderLod0, System.Int32 lodIndex); // 0x0766d124
	System.Void FlushRuntimeData(WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.PhysicsBoneRuntimeBuffer[]& array, System.Int32 offset); // 0x0766d298
	System.Void FlushBufferData(WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.PhysicsBoneStaticBuffer[]& boneStaticArrays, WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.RenderBonesBuffer[]& renderArrays, System.Int32 offset); // 0x0766d6a8
	System.Void FlushColliderIndiesData(WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.ColliderIndies[]& outputColliderIndiesArray); // 0x0766d860
	System.Void UpdateRenderBuffer(UnityEngine.ComputeBuffer& renderBuffer); // 0x0766d974
	UnityEngine.Material[] GetMaterials(UnityEngine.Renderer renderer); // 0x0766dca4
	System.Void UpdateRenderOffset(); // 0x0766dd28
	System.Void PrepareBoneInputJobData(UnityEngine.Jobs.TransformAccessArray& objTransformArray, UnityEngine.Jobs.TransformAccessArray& boneRootTransformArray, UnityEngine.Jobs.TransformAccessArray& boneTransformArray); // 0x0766df04
	System.Void PrepareColliderInputJobData(UnityEngine.Jobs.TransformAccessArray& colliderTransformArray, Unity.Collections.NativeArray<WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.ColliderInfoBuffer>& colliderInfoArray); // 0x0766e098
	System.Boolean NeedBlendIn(); // 0x0766e2d0
	System.Void UpdateBlendInRate(System.Single dtime); // 0x0766e34c
	System.Void Awake(); // 0x0766e560
	System.Void Init(); // 0x0766e604
	System.Collections.IEnumerator InitCoroutine(); // 0x0766e7c4
	System.Void OnDestroy(); // 0x0766e86c
	System.Void RefreshConfigData(); // 0x0766ec68
	System.Collections.IEnumerator _addGroup(); // 0x0766ed98
	UnityEngine.SkinnedMeshRenderer GetSkinnedMeshRenderer(); // 0x0766ee40
	UnityEngine.GameObject GetGameObject(); // 0x0766eec8
	System.Int32 GetBoneNumbers(); // 0x0766ef30
	System.Int32 GetBufferOffset(); // 0x0766ef94
	System.Void SetBufferOffset(System.Int32 offset); // 0x0766eff8
	System.Int32 GetColBufferOffset(); // 0x0766f070
	System.Void SetColBufferOffset(System.Int32 offset); // 0x0766f0d4
	System.Int32 GetMaxBoneChainLength(); // 0x0766f14c
	System.Boolean CheckMeshVisible(); // 0x0766f1b0
	System.Void SetPause(System.Boolean isPause); // 0x0766f328
	System.Boolean IsPause(); // 0x0766f3a4
	System.Void OnPaused(); // 0x0766f408
	System.Void OnResumed(); // 0x0766f584
	System.Void SetEnable(System.Boolean enable); // 0x0766ed18
	System.Void SetEnable(System.Boolean enable, System.Boolean force); // 0x0766f5ec
	UnityEngine.Transform GetCullingParent(); // 0x0766f9c0
	System.Void SetCullingParent(UnityEngine.Transform parent); // 0x0766fa24
	System.Void OnDisable(); // 0x0766faa4
	System.Void OnEnable(); // 0x0766fb0c
	System.Void OnRecycle(); // 0x0766fb74
	System.Void debug_setEnable(); // 0x0766fbdc
	System.Void debug_setDisable(); // 0x0766fc44
	System.Void SwitchPhyLOD(System.Boolean isPhyLOD); // 0x0766f94c
	System.Single GetCullingDistance(); // 0x0766fcac
	System.Boolean get_IsUseMultiSkineedMeshRenderer(); // 0x0766fd20
	System.Void set_IsUseMultiSkineedMeshRenderer(System.Boolean value); // 0x0766fd84
	UnityEngine.SkinnedMeshRenderer get_SkinnedMeshRenderer(); // 0x0766fe00
	System.Collections.Generic.List<UnityEngine.SkinnedMeshRenderer> get_SkinnedMeshRenderers(); // 0x0766d06c
	System.Void .ctor(); // 0x0766fe64
	System.Boolean <InitCoroutine>b__49_0(); // 0x0766ff2c
	System.Boolean <_addGroup>b__52_0(); // 0x0766ffe8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneGroup.<>c : System.Object
{
	static WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneGroup.<>c <>9; // 0x0
	static System.Predicate<WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBone> <>9__32_0; // 0x8
	static System.Void .cctor(); // 0x07670580
	System.Void .ctor(); // 0x076705e4
	System.Boolean <InitBones>b__32_0(WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBone c); // 0x0767064c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneGroup.<>c__DisplayClass32_0 : System.Object
{
	WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBone.Particle p; // 0x10
	System.Void .ctor(); // 0x076706f4
	System.Boolean <InitBones>b__1(System.String t); // 0x0767075c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneGroup.<>c__DisplayClass33_0 : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneCollider> boneColliders; // 0x10
	System.Int32 i; // 0x18
	System.Predicate<WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneCollider> <>9__0; // 0x20
	System.Void .ctor(); // 0x076707f8
	System.Boolean <InitColliderIndies>b__0(WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneCollider t); // 0x07670860
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneGroup.<>c__DisplayClass75_0 : System.Object
{
	
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneGroup.<InitCoroutine>d__49 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneGroup <>4__this; // 0x20
	System.Void .ctor(System.Int32 <>1__state); // 0x07670938
	System.Void System.IDisposable.Dispose(); // 0x076709bc
	System.Boolean MoveNext(); // 0x07670a1c
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x07670b44
	System.Void System.Collections.IEnumerator.Reset(); // 0x07670ba8
	System.Object System.Collections.IEnumerator.get_Current(); // 0x07670c30
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneGroup.<_addGroup>d__52 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneGroup <>4__this; // 0x20
	System.Void .ctor(System.Int32 <>1__state); // 0x07670c94
	System.Void System.IDisposable.Dispose(); // 0x07670d18
	System.Boolean MoveNext(); // 0x07670d78
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x07671110
	System.Void System.Collections.IEnumerator.Reset(); // 0x07671174
	System.Object System.Collections.IEnumerator.get_Current(); // 0x076711fc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager : System.Object
{
	static WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager _instance; // 0x0
	static SocLogger logger; // 0x8
	static System.Int32 SizeOfColliderPerBone = 6;
	System.Int32 SizeOfStaticBoneBuffer; // 0x10
	System.Int32 SizeOfRuntimeBoneBuffer; // 0x14
	System.Int32 SizeOfInputBoneBuffer; // 0x18
	System.Int32 SizeOfRenderBoneBuffer; // 0x1c
	System.Int32 SizeOfColliderBuffer; // 0x20
	System.Int32 SizeOfColliderIndiesBuffer; // 0x24
	System.Int32 SizeOfColliderLerpBuffer; // 0x28
	System.Int32 m_updateRate; // 0x2c
	static System.Int32 ThreadNumPerGroup = 32;
	static System.Int32 MaxBoneNum = 4096;
	System.Int32 threadGroupNum; // 0x30
	System.Int32 simulateGroupNum; // 0x34
	System.Int32 colBufferSize; // 0x38
	System.Int32 colliderSimBufferSize; // 0x3c
	System.Boolean isInitialized; // 0x40
	System.Int32 maxBoneChainLength; // 0x44
	System.Single lastUpdateTime; // 0x48
	System.Single totalUpdateTime; // 0x4c
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneGroup> physicsBoneGroups; // 0x50
	System.Collections.Generic.HashSet<System.Int32> pauseGroup; // 0x58
	System.Collections.Generic.List<System.Int32> addedGroup; // 0x60
	System.Collections.Generic.List<System.Int32> removedGroup; // 0x68
	System.Collections.Generic.List<System.Int32> blendInGroup; // 0x70
	UnityEngine.ComputeShader calShader; // 0x78
	UnityEngine.ComputeShader modifySkinPoseShader; // 0x80
	UnityEngine.ComputeBuffer physicsBoneStaticBuffer; // 0x88
	UnityEngine.ComputeBuffer physicsBoneInputBuffer; // 0x90
	UnityEngine.ComputeBuffer colliderIndiesBuffer; // 0x98
	UnityEngine.ComputeBuffer renderBonesBuffer; // 0xa0
	UnityEngine.ComputeBuffer physicsBoneRuntimeBuffer_A; // 0xa8
	UnityEngine.ComputeBuffer physicsBoneRuntimeBuffer_B; // 0xb0
	UnityEngine.ComputeBuffer colliderBuffer; // 0xb8
	UnityEngine.ComputeBuffer colliderLerpBuffer; // 0xc0
	UnityEngine.ComputeBuffer swapBuffer; // 0xc8
	WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.PhysicsBoneStaticBuffer[] physicsBoneStaticArray; // 0xd0
	WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.PhysicsBoneRuntimeBuffer[] physicsBoneRuntimeArray; // 0xd8
	WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.RenderBonesBuffer[] renderBonesArray; // 0xe0
	WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.ColliderIndies[] colliderIndiesArray; // 0xe8
	WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.ColliderLerpBuffer[] colliderLerpArray; // 0xf0
	System.Int32[] swapArray; // 0xf8
	WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.BufferAllocManageUnit boneBufferUnit; // 0x100
	WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.BufferAllocManageUnit colliderBufferUnit; // 0x108
	System.Int32 frameStepNameID; // 0x110
	System.Int32 frameCountNameID; // 0x114
	System.Int32 iterTimes; // 0x118
	System.Single sceneWindFactor; // 0x11c
	System.Int32 VerletIntegrationKernelID; // 0x120
	System.Int32 SloveConstraintKernelID; // 0x124
	System.Int32 ModifyParentRotationKernelID; // 0x128
	System.Int32 UpdateLerpDataKernelID; // 0x12c
	System.Int32 SwapRuntimeBufferKernelID; // 0x130
	System.Int32 UpdateColliderLerpDataKernelID; // 0x134
	System.Boolean disablePhysicsBone; // 0x138
	System.Boolean circuitBreakerFlag; // 0x139
	UnityEngine.Jobs.TransformAccessArray ObjTransformArray; // 0x140
	UnityEngine.Jobs.TransformAccessArray BoneRootTransformArray; // 0x148
	UnityEngine.Jobs.TransformAccessArray BoneTransformArray; // 0x150
	UnityEngine.Jobs.TransformAccessArray ColliderTransformArray; // 0x158
	Unity.Collections.NativeArray<WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.PhysicsBoneInputBuffer> BoneInputNativeArray; // 0x160
	Unity.Collections.NativeArray<WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.ColliderInfoBuffer> ColliderNativeArray; // 0x170
	static Unity.Profiling.ProfilerMarker _processPrevFrameMarker; // 0x10
	static Unity.Profiling.ProfilerMarker _processBufferChangeMarker; // 0x18
	static Unity.Profiling.ProfilerMarker _updateBonesMarker; // 0x20
	static Unity.Profiling.ProfilerMarker _flushInputDataMarker; // 0x28
	static Unity.Profiling.ProfilerMarker _setBufferDataMarker; // 0x30
	System.Int32 frameCount; // 0x180
	static WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager get_physicsBoneManagerInstance(); // 0x07671260
	System.Void .ctor(); // 0x07671340
	System.Void Init(); // 0x07671684
	System.Void InitBuffers(); // 0x076717c0
	System.Void AddGroup(WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneGroup group); // 0x07670ea4
	System.Void RemoveGroup(WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneGroup group); // 0x07672534
	System.Void ProcessBufferChange(); // 0x076728ec
	System.Void CheckResizeColliderBuffer(); // 0x07673710
	System.Void CheckResizeBoneBuffer(); // 0x07673278
	System.Void ResizeBackupBuffer(); // 0x07673820
	System.Void ResizeTransformAccessArray(System.Int32 newSize); // 0x07673a78
	System.Void ResizeColliderTransformAccessArray(System.Int32 newSize); // 0x07673b88
	System.Void FlushBackupRuntimeBuffer(); // 0x07673c58
	System.Void UpdateRuntimeBufferData(); // 0x07673388
	System.Void UpdateSwapBuffer(); // 0x07673520
	System.Void UpdatePauseGroup(); // 0x07673cdc
	System.Void ProcessPrevFrameChange(); // 0x07674188
	System.Void UpdateBlendInGroups(System.Single dtime); // 0x07674bac
	System.Void UpdateBones(System.Single dtime); // 0x07674d40
	System.Void Clear(); // 0x0767531c
	System.Void LateUpdate(); // 0x076754d0
	System.Void OnDispose(); // 0x076755e8
	System.Boolean IsRemoveListEmpty(); // 0x0767568c
	System.Boolean IsRemoveListContains(System.Int32 instanceId); // 0x07675710
	System.Boolean IsBoneBufferLayoutChanged(); // 0x076757ac
	static UnityEngine.Rendering.Universal.UniversalRendererData GetRendererData(); // 0x0767581c
	static UnityEngine.ComputeShader GetPhysicsBoneUpdateShader(); // 0x07672314
	static UnityEngine.ComputeShader GetModifySkinShader(); // 0x076723f0
	static System.Void .cctor(); // 0x076759cc
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.ColliderIndies : System.ValueType
{
	System.Int32 offset; // 0x10
	System.Int32 index0; // 0x14
	System.Int32 index1; // 0x18
	System.Int32 index2; // 0x1c
	System.Int32 index3; // 0x20
	System.Int32 index4; // 0x24
	System.Int32 index5; // 0x28
	System.Void .ctor(System.Int32[] val); // 0x07675bfc
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.PhysicsBoneStaticBuffer : System.ValueType
{
	System.Int32 m_ParentIndex; // 0x10
	System.Int32 m_NoiseRandNum; // 0x14
	System.Single m_Elasticity; // 0x18
	System.Single m_Damping; // 0x1c
	System.Single m_Inert; // 0x20
	System.Single m_InertObj; // 0x24
	System.Single m_Stiffness; // 0x28
	System.Single m_Radius; // 0x2c
	System.Single m_WindFactor; // 0x30
	System.Single m_WindConstFactor; // 0x34
	System.Single m_WindFreqFactor; // 0x38
	System.Single m_boneRootLength; // 0x3c
	UnityEngine.Vector3 initLocalPos; // 0x40
	UnityEngine.Vector3 m_LocalGravity; // 0x4c
	UnityEngine.Vector3 m_Gravity; // 0x58
	UnityEngine.Vector3 m_ConstForce; // 0x64
	UnityEngine.Vector3 m_ColOffset; // 0x70
	UnityEngine.Vector3 m_WindDirection; // 0x7c
	UnityEngine.Vector3 m_WindNoise; // 0x88
	UnityEngine.Vector4 initLocalRot; // 0x94
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.PhysicsBoneRuntimeBuffer : System.ValueType
{
	UnityEngine.Vector3 virtualPos; // 0x10
	UnityEngine.Vector3 prevPos; // 0x1c
	UnityEngine.Vector3 prevLerpObjPos; // 0x28
	UnityEngine.Vector3 prevLerpBonePos; // 0x34
	UnityEngine.Matrix4x4 localToWorld; // 0x40
	UnityEngine.Matrix4x4 prevLerpRootMat; // 0x80
	UnityEngine.Matrix4x4 lerpRootMat; // 0xc0
	UnityEngine.Vector3 rootShiftOffset; // 0x100
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.PhysicsBoneInputBuffer : System.ValueType
{
	UnityEngine.Matrix4x4 boneRootMatrix; // 0x10
	UnityEngine.Vector3 objPos; // 0x50
	UnityEngine.Vector3 bonePos; // 0x5c
	UnityEngine.Vector3 initLocalPos; // 0x68
	UnityEngine.Vector4 initLocalRot; // 0x74
	UnityEngine.Vector4 objRot; // 0x84
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.RenderBonesBuffer : System.ValueType
{
	UnityEngine.Matrix4x4 LocalToShiftWorld; // 0x10
	UnityEngine.Vector3 rootShiftOffset; // 0x50
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.ColliderType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.ColliderType Sphere = 0;
	static WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.ColliderType Plane = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.ColDirectionType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.ColDirectionType X = 0;
	static WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.ColDirectionType Y = 1;
	static WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.ColDirectionType Z = 2;
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.ColliderInfoBuffer : System.ValueType
{
	WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.ColliderType colType; // 0x10
	WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.ColDirectionType direction; // 0x14
	System.Int32 isPositiveDirection; // 0x18
	UnityEngine.Matrix4x4 localToWorld; // 0x1c
	System.Single radius; // 0x5c
	System.Single height; // 0x60
	UnityEngine.Vector3 center; // 0x64
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.ColliderLerpBuffer : System.ValueType
{
	UnityEngine.Matrix4x4 prevLerpedL2W; // 0x10
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.FreeBlockType : System.Object
{
	System.Int32 size; // 0x10
	System.Int32 startIdx; // 0x14
	WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.FreeBlockType next; // 0x18
	System.Void .ctor(); // 0x07675cf0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.AllocatedBlockType : System.Object
{
	System.Int32 size; // 0x10
	System.Int32 startIdx; // 0x14
	System.Int32 userId; // 0x18
	WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.AllocatedBlockType next; // 0x20
	System.Void .ctor(); // 0x07675d58
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.BufferAllocManageUnit : System.Object
{
	WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.FreeBlockType firstFreeBlock; // 0x10
	WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.AllocatedBlockType firstAllocBlock; // 0x18
	System.Boolean bufferLayoutChanged; // 0x20
	System.Boolean bufferSizeChanged; // 0x21
	System.Int32 totalBlockNum; // 0x24
	System.Int32 MaxBlockNum; // 0x28
	System.Void .ctor(System.Int32 maxBlockNum); // 0x07671580
	System.Void resetFlags(); // 0x07672d8c
	System.Int32 AllocateBlock(System.Int32 id, System.Int32 allocSize); // 0x07673044
	System.Void FreeBlock(System.Int32 id); // 0x07672df0
	System.Void CheckRearrange(); // 0x076731cc
	System.Void RearrangeBlocks(); // 0x07675dc0
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.UpdateObjectTransformJob : System.ValueType, UnityEngine.Jobs.IJobParallelForTransform
{
	Unity.Collections.NativeArray<WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.PhysicsBoneInputBuffer> Output; // 0x10
	System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform); // 0x07675ebc
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.UpdateBoneRootTransformJob : System.ValueType, UnityEngine.Jobs.IJobParallelForTransform
{
	Unity.Collections.NativeArray<WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.PhysicsBoneInputBuffer> Output; // 0x10
	System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform); // 0x07676024
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.UpdateBoneTransformJob : System.ValueType, UnityEngine.Jobs.IJobParallelForTransform
{
	Unity.Collections.NativeArray<WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.PhysicsBoneInputBuffer> Output; // 0x10
	System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform); // 0x07676124
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.UpdateColliderTransformJob : System.ValueType, UnityEngine.Jobs.IJobParallelForTransform
{
	Unity.Collections.NativeArray<WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.ColliderInfoBuffer> Output; // 0x10
	System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform); // 0x076762b8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.<>c__DisplayClass95_0 : System.Object
{
	System.Int32 instanceID; // 0x10
	System.Void .ctor(); // 0x076724cc
	System.Boolean <AddGroup>b__0(System.Int32 x); // 0x076763b8
	System.Boolean <AddGroup>b__1(System.Int32 x); // 0x07676438
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneManager.<>c__DisplayClass96_0 : System.Object
{
	System.Int32 instanceID; // 0x10
	System.Void .ctor(); // 0x07672884
	System.Boolean <RemoveGroup>b__0(System.Int32 x); // 0x076764b8
	System.Boolean <RemoveGroup>b__1(System.Int32 x); // 0x07676538
	System.Boolean <RemoveGroup>b__2(System.Int32 x); // 0x076765b8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneSocketAdapter : UnityEngine.MonoBehaviour
{
	WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBone template; // 0x30
	UnityEngine.Vector3 physicsBoneOffset; // 0x38
	System.Collections.Generic.Dictionary<System.Int32,UnityEngine.GameObject> physicsBoneGroupMap; // 0x48
	System.Collections.Generic.Dictionary<System.Int32,UnityEngine.GameObject> meshGOMap; // 0x50
	System.Void Awake(); // 0x07676638
	System.Void OnTransformChildrenChanged(); // 0x07676710
	System.Void Add(System.Int32 meshGameObjectId); // 0x07676c54
	System.Void Remove(System.Int32 meshGameObjectId); // 0x07676b58
	System.Void CreatePhysicsBoneGroup(UnityEngine.GameObject meshGO); // 0x07676cfc
	System.Void .ctor(); // 0x076771d8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.PhysicsBone.PhysicsBoneUpdateComp : UnityEngine.MonoBehaviour
{
	
	System.Void LateUpdate(); // 0x07677240
	System.Void OnDestroy(); // 0x076772d0
	System.Void .ctor(); // 0x07677360
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.PhysicsBone.ScenePBWindFactor : UnityEngine.MonoBehaviour
{
	System.Single WindFactor; // 0x30
	System.Void OnEnable(); // 0x076773c8
	System.Void OnDisable(); // 0x0767745c
	System.Void .ctor(); // 0x07677510
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Animation.NewBones.NewBoneTagCache : UnityEngine.MonoBehaviour
{
	System.Collections.Generic.List<UnityEngine.Transform> NewBoneRoot; // 0x30
	System.Collections.Generic.List<System.String> NewBoneRootParentName; // 0x38
	System.Void ClearCache(); // 0x07677580
	System.Void TryBuildNewBoneTagCache(); // 0x0767765c
	System.Void .ctor(); // 0x0767788c
}

// Client.Runtime
class WizardGames.Soc.Common.Profile.SocProfilerCommonFunc : System.Object, WizardGames.Soc.Common.Profile.IProfilerCommonFunc
{
	
	System.Void .ctor(); // 0x07677998
	System.UInt64 Get_GpuTime(); // 0x07677a00
	System.Int32 GetFrameRate(); // 0x07677a88
}

// Client.Runtime
class WizardGames.Soc.Common.Profile.EntToFuncTypeMapRegister : System.Object
{
	
	static System.Void RegisterFuncTypeMap(); // 0x07677b78
}

// Client.Runtime
class WizardGames.Soc.Common.Profile.DelayedTaskProfiler : System.Object
{
	SocLogger Logger; // 0x10
	System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.KeyValuePair<System.String,System.Int32>> TaskToCallNameMap; // 0x18
	System.Collections.Generic.Dictionary<System.String,System.Int32> CallNameToKeyMap; // 0x20
	System.Text.RegularExpressions.Regex TaskNameRegex; // 0x28
	UnityEngine.Object.DelayedCallback DelayedCall; // 0x30
	UnityEngine.DelayedTaskEndCallback DelayedTask; // 0x38
	System.Type TaskType; // 0x40
	System.Reflection.FieldInfo TaskField; // 0x48
	System.Void .ctor(); // 0x07678c18
	System.Void Begin(System.Single delayedTaskThresholdMs, System.Single delayedCallThresholdMs); // 0x07678e84
	System.Void End(); // 0x07679138
	System.Collections.Generic.KeyValuePair<System.String,System.Int32> GetTaskCallName(System.Object delegateState); // 0x0767927c
	System.Void OnDelayedTaskEnd(System.Object delegateState, System.Int64 ticks); // 0x076796cc
	System.Void OnDelayedCallEnd(System.String callName, System.String objectName, System.Int32 callType, System.Single durationMs); // 0x07679910
}

// Client.Runtime
class WizardGames.Soc.Common.Profile.MgrProfiler : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Action<UnityEngine.Rendering.Universal.EUrpFunc> _beginUrpSample; // 0x18
	System.Action<UnityEngine.Rendering.Universal.EUrpFunc> _endUrpSample; // 0x20
	System.Action<EWwiseFunc> beginWwiseSample; // 0x28
	System.Action<EWwiseFunc> endWwiseSample; // 0x30
	WizardGames.Soc.Common.Profile.DelayedTaskProfiler delayedTaskProfiler; // 0x38
	WizardGames.Soc.Common.Profile.UiProfiler uiProfiler; // 0x40
	System.Boolean isEnterWorld; // 0x48
	static System.Collections.Generic.Dictionary<System.String,System.Int32> perfExcludeSource; // 0x0
	static System.Collections.Generic.Dictionary<System.String,System.Int32> _newBeginPerfExcludeSource; // 0x8
	static System.Collections.Generic.Dictionary<System.String,System.Int32> _newEndPerfExcludeSource; // 0x10
	System.Void Init(); // 0x07679d10
	System.Void CleanUp(); // 0x07679f34
	System.Threading.Tasks.Task OnExitWorld(); // 0x0767a0b4
	System.Void OnEnterWorldCompletely(); // 0x0767a2f0
	System.Void StartProfiler(); // 0x0767a35c
	System.Void StopProfiler(WizardGames.Soc.Common.Profile.MgrProfiler.EExitMode mode); // 0x0767a184
	System.Void ChangeQualityLevel(System.Int32 fps, WizardGames.Soc.RMQualityLevel level, System.Boolean needPostInfo); // 0x0767a424
	System.Void OnCrashEvent(System.Int32 methodId, System.Int32 crashType); // 0x0767a6b4
	System.Void OnApplicationQuit(); // 0x0767a7dc
	System.Void EnableDelayedTaskProfiler(System.Boolean enable); // 0x0767a8e4
	System.Void EnableUIProfiler(System.Boolean enable); // 0x0767a9c4
	static System.Void BeginPerfExclude(System.String source); // 0x0767b01c
	static System.Void EndPerfExclude(System.String source); // 0x0767b230
	static System.Collections.Generic.Dictionary<System.String,System.Int32> CollectNewBeginPerfExclude(); // 0x0767b4a8
	static System.Collections.Generic.Dictionary<System.String,System.Int32> CollectNewEndPerfExclude(); // 0x0767b5ec
	static System.Void OnBeginUrpSample(UnityEngine.Rendering.Universal.EUrpFunc func); // 0x0767b730
	static System.Void OnEndUrpSample(UnityEngine.Rendering.Universal.EUrpFunc func); // 0x0767b8a4
	static System.Void OnBeginWwiseSample(EWwiseFunc func); // 0x0767b964
	static System.Void OnEndWwiseSample(EWwiseFunc func); // 0x0767bad8
	System.Void .ctor(); // 0x0767bb98
	static System.Void .cctor(); // 0x0767bd40
}

// Client.Runtime
enum WizardGames.Soc.Common.Profile.MgrProfiler.EExitMode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Profile.MgrProfiler.EExitMode EXIT_WORLD = 0;
	static WizardGames.Soc.Common.Profile.MgrProfiler.EExitMode EXIT_APP = 1;
	static WizardGames.Soc.Common.Profile.MgrProfiler.EExitMode EXIT_CRASH = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Profile.MgrProfiler.<>c : System.Object
{
	static WizardGames.Soc.Common.Profile.MgrProfiler.<>c <>9; // 0x0
	static FairyGUI.TimerCallback <>9__23_0; // 0x8
	static System.Void .cctor(); // 0x0767be28
	System.Void .ctor(); // 0x0767be8c
	System.Void <EnableUIProfiler>b__23_0(System.Object data); // 0x0767bef4
}

// Client.Runtime
class WizardGames.Soc.Common.Profile.ProfilerRegEvent : System.Object
{
	
	static System.Void OnEnable(WizardGames.Soc.Common.Profile.IProfiler profiler); // 0x0767bfa8
	static System.Void OnExport(WizardGames.Soc.Common.Profile.IProfiler profiler); // 0x0767c0e0
	static System.Void OnDisable(WizardGames.Soc.Common.Profile.IProfiler profiler); // 0x0767c4d8
	static System.Void OnFrameEnd(WizardGames.Soc.Common.Profile.IProfiler profiler); // 0x0767c544
	static System.Void InitCustomNames(WizardGames.Soc.Common.Profile.IProfiler profiler); // 0x0767c948
}

// Client.Runtime
class WizardGames.Soc.Common.Profile.SimplifiedProfilerConfig : System.Object
{
	static System.Int32 MaxSpikeCount; // 0x0
	static System.Int32 MaxLowFrameCount; // 0x4
	static WizardGames.Soc.Common.Profile.EProfileFunc[] FilteredMarks; // 0x8
	static System.Void .cctor(); // 0x0767d324
}

// Client.Runtime
class WizardGames.Soc.Common.Profile.SocProfileUtil : System.Object
{
	static System.Collections.Generic.Dictionary<UnityEngine.Rendering.Universal.EUrpFunc,WizardGames.Soc.Common.Profile.EProfileFunc> UrpToProfileFunc; // 0x0
	static System.Collections.Generic.Dictionary<EWwiseFunc,WizardGames.Soc.Common.Profile.EProfileFunc> WiseToProfileFunc; // 0x8
	static WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFunc(UnityEngine.Rendering.Universal.EUrpFunc urpFunc); // 0x0767b7f0
	static WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFunc(EWwiseFunc wwiseFunc); // 0x0767ba24
	static System.Void .cctor(); // 0x0767d3cc
}

// Client.Runtime
class WizardGames.Soc.Common.Profile.UiEventProfiler : FairyGUI.BaseUiEventProfiler
{
	SocLogger Logger; // 0x18
	System.Collections.Generic.Dictionary<System.String,System.Int32> CallNameToKeyMap; // 0x20
	System.Void .ctor(); // 0x0767adac
	System.Void AddEventCustom(System.String eventName, System.Single timeCost, System.Boolean needToLimit); // 0x0767da60
}

// Client.Runtime
class WizardGames.Soc.Common.Profile.UiProfiler : System.Object
{
	SocLogger Logger; // 0x10
	System.Collections.Generic.Dictionary<System.String,System.Int32> CallNameToKeyMap; // 0x18
	System.Boolean _isUiProfilerBegan; // 0x20
	System.Single fps1UpdateCostTimeThr; // 0x24
	System.Single mgrUiCostTimeThr; // 0x28
	System.Void .ctor(); // 0x0767acbc
	System.Void Begin(); // 0x0767af00
	System.Void End(); // 0x0767af90
	System.Boolean IsUiProfilerBegan(); // 0x0767dcfc
	System.Void AddFps1UpdateUICustom(System.String uiName, System.Single timeCost); // 0x0767dd60
	System.Void AddMgrUICustom(System.String uiName, System.Single timeCost); // 0x0767e060
	System.Void AddUICustom(System.String uiName, System.Single timeCost, System.String profileSpikeConf); // 0x0767de2c
}

// Client.Runtime
class WizardGames.Soc.Common.Profile.UnityProfileFuncReg : System.Object
{
	
	static System.Void Reg(); // 0x0767e12c
}

// Client.Runtime
class WizardGames.Soc.AdaptivePerformance.AdaptiveFrameTimeTracker : System.Object
{
	WizardGames.Soc.AdaptivePerformance.FrameTiming m_FrameTiming; // 0x10
	WizardGames.Soc.AdaptivePerformance.ArrayAverage m_IncreaseTimePercents; // 0x18
	WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceSettings m_Settings; // 0x20
	System.Single m_FrameTimeTrend; // 0x28
	System.Single m_PercentDropFrame; // 0x2c
	System.Single m_PercentHeavyDropFrame; // 0x30
	System.Single m_PercentGreaterThanAverageFrame; // 0x34
	System.Void .ctor(WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceMonitor monitor, WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceSettings settings); // 0x0767e4e8
	System.Void Reset(); // 0x0767e890
	WizardGames.Soc.AdaptivePerformance.EScaleMode Update(System.Single time); // 0x0767eb4c
	System.Void OnTargetFrameRateChanged(System.Int32 targetFrameRate); // 0x0767f0d4
}

// Client.Runtime
class WizardGames.Soc.AdaptivePerformance.BottleneckUtil : System.Object
{
	
	static WizardGames.Soc.AdaptivePerformance.EScaleTarget DetermineBottleneck(WizardGames.Soc.AdaptivePerformance.EScaleTarget prevTarget, System.Single averageCpuFrameTime, System.Single averageGpuFrametime, System.Single averageOverallFrametime, System.Single targetFrameTime); // 0x0767f238
	static System.Boolean HittingFrameRateLimit(System.Single actualFrameTime, System.Single thresholdFactor, System.Single targetFrameTime); // 0x0767f3e0
}

// Client.Runtime
class WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceIndexer : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceScalar> m_Scalers; // 0x10
	WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceTracker m_Tracker; // 0x18
	WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceSettings m_Settings; // 0x20
	System.Void .ctor(WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceTracker tracker, WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceSettings settings); // 0x0767f494
	System.Void Reset(); // 0x0767f6e0
	System.Void Update(WizardGames.Soc.AdaptivePerformance.EScaleMode mode, WizardGames.Soc.AdaptivePerformance.EScaleTarget target); // 0x0767f7a4
}

// Client.Runtime
class WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceLogger : System.Object
{
	static SocLogger Log; // 0x0
	static System.Void .cctor(); // 0x0767f99c
}

// Client.Runtime
class WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceManager : System.Object
{
	WizardGames.Soc.AdaptivePerformance.EScaleMode SupportScaleMode; // 0x10
	WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceMonitor Monitor; // 0x18
	WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceTracker Tracker; // 0x20
	WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceIndexer Indexer; // 0x28
	WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceSettings Settings; // 0x30
	static WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceManager Instance; // 0x0
	static System.Void .cctor(); // 0x0767fa70
	System.Void .ctor(); // 0x0767faec
	static System.String get_DefaultSettingsFileName(); // 0x0767fec4
	System.Void Init(); // 0x0767fb5c
	System.Void Reset(); // 0x07680380
	System.Void Update(); // 0x076807d0
}

// Client.Runtime
enum WizardGames.Soc.AdaptivePerformance.EMonitorMode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.AdaptivePerformance.EMonitorMode Thermal = 1;
	static WizardGames.Soc.AdaptivePerformance.EMonitorMode FrameRate = 2;
	static WizardGames.Soc.AdaptivePerformance.EMonitorMode Default = 1;
	
}

// Client.Runtime
class WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceMonitor : System.Object
{
	System.Int32 m_FrameCount; // 0x10
	System.Single m_OverallFrameTimeAccu; // 0x14
	WizardGames.Soc.AdaptivePerformance.ArrayAverage m_OverallFrameTime; // 0x18
	WizardGames.Soc.AdaptivePerformance.ArrayAverage m_GpuFrameTime; // 0x20
	WizardGames.Soc.AdaptivePerformance.ArrayAverage m_CpuFrameTime; // 0x28
	WizardGames.Soc.AdaptivePerformance.CpuTimeProvider m_CpuTimeProvider; // 0x30
	WizardGames.Soc.AdaptivePerformance.GpuTimeProvider m_GpuTimeProvider; // 0x38
	System.Action<System.Int32> m_TargetFrameRateChangeEvent; // 0x40
	WizardGames.Soc.AdaptivePerformance.EMonitorMode MonitorMode; // 0x48
	WizardGames.Soc.AdaptivePerformance.ThermalMetrics ThermalMetrics; // 0x4c
	WizardGames.Soc.AdaptivePerformance.FrameTiming FrameTiming; // 0x60
	System.Boolean get_IsFrameFully(); // 0x07680e48
	System.Void Reset(); // 0x0768040c
	System.Void Update(); // 0x076809f4
	System.Void AddTargetFrameRateChangeEvent(System.Action<System.Int32> evt); // 0x0767e74c
	System.Void .ctor(); // 0x07680070
}

// Client.Runtime
class WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceScalar : System.Object
{
	System.Boolean Enabled; // 0x10
	WizardGames.Soc.AdaptivePerformance.EScaleMode SupportMode; // 0x14
	WizardGames.Soc.AdaptivePerformance.EScaleTarget Target; // 0x18
	System.Int32 MaxLevel; // 0x1c
	System.Int32 MinLevel; // 0x20
	System.Int32 CurrentLevel; // 0x24
	System.Boolean ChangeLevel(WizardGames.Soc.AdaptivePerformance.EScaleMode mode, WizardGames.Soc.AdaptivePerformance.EScaleTarget target); // 0x0767f89c
	System.Void Reset(); // 0x07681274
	System.Void OnLevelChanged(System.Int32 fromLevel, System.Int32 toLevel); // 0x076812ec
	System.Void .ctor(); // 0x07681368
}

// Client.Runtime
class WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceIndexerSettings : System.Object
{
	System.Boolean Enable; // 0x10
	System.Single ThermalActionDelay; // 0x14
	System.Single PerformanceActionDelay; // 0x18
	System.Single PercentAsDropFrame; // 0x1c
	System.Void .ctor(); // 0x076813d0
}

// Client.Runtime
class WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceScalarSettings : System.Object
{
	WizardGames.Soc.AdaptivePerformance.AdaptiveRMQuality RmQuality; // 0x10
	WizardGames.Soc.AdaptivePerformance.AdaptivePowerThrottling PowerThrottling; // 0x18
	System.Void InitDefault(); // 0x07681454
	System.Collections.Generic.List<WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceScalar> GetScalars(); // 0x0767f55c
	System.Void .ctor(); // 0x07681608
}

// Client.Runtime
class WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceSettings : System.Object
{
	WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceIndexerSettings IndexerSettings; // 0x10
	WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceScalarSettings ScalarSettings; // 0x18
	System.Void InitDefault(); // 0x0767ff9c
	System.Void .ctor(); // 0x0767ff34
}

// Client.Runtime
class WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceTracker : System.Object
{
	WizardGames.Soc.AdaptivePerformance.FrameTiming frameTiming; // 0x10
	WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceMonitor monitor; // 0x18
	WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceSettings settings; // 0x20
	WizardGames.Soc.AdaptivePerformance.AdaptiveThermalTracker thermalTracker; // 0x28
	WizardGames.Soc.AdaptivePerformance.AdaptiveFrameTimeTracker frameTimeTracker; // 0x30
	WizardGames.Soc.AdaptivePerformance.EScaleTarget ScaleTarget; // 0x38
	WizardGames.Soc.AdaptivePerformance.EScaleMode ThermalScaleMode; // 0x3c
	WizardGames.Soc.AdaptivePerformance.EScaleMode FrameScaleMode; // 0x40
	WizardGames.Soc.AdaptivePerformance.EScaleMode ScaleMode; // 0x44
	System.Single ActionTime; // 0x48
	System.Void .ctor(WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceMonitor monitor_, WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceSettings settings_); // 0x07680214
	System.Void Reset(); // 0x07680724
	System.Void Update(); // 0x07680cf0
}

// Client.Runtime
class WizardGames.Soc.AdaptivePerformance.AdaptiveThermalTracker : System.Object
{
	System.Single m_ScaleSlowTime; // 0x10
	System.Single m_ScaleFastTime; // 0x14
	System.Single m_ActionDeltaTime; // 0x18
	WizardGames.Soc.AdaptivePerformance.MgrThermal.EThermalManagementLevel m_ThermalLevel; // 0x1c
	WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceMonitor m_Monitor; // 0x20
	System.Void .ctor(WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceMonitor monitor, WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceSettings settings); // 0x07681670
	System.Void Reset(); // 0x07681734
	WizardGames.Soc.AdaptivePerformance.EScaleMode Update(System.Single time); // 0x07681798
}

// Client.Runtime
class WizardGames.Soc.AdaptivePerformance.ArrayAverage : System.Object
{
	System.Single[] m_Values; // 0x10
	System.Int32 m_NumValues; // 0x18
	System.Int32 m_LastIndex; // 0x1c
	System.Single m_AverageValue; // 0x20
	System.Void .ctor(System.Int32 capcity); // 0x0767e698
	System.Int32 get_Capcity(); // 0x0767e96c
	System.Boolean get_IsFrameFully(); // 0x0767eefc
	System.Single GetAverageOr(System.Single defaultValue); // 0x0767ef78
	System.Single GetMostRecentValueOr(System.Single defaultValue); // 0x07681090
	System.Single GetGreaterValuePercent(System.Single value); // 0x0767f000
	System.Void AddValue(System.Single newValue); // 0x0767edf0
	System.Void Reset(); // 0x0767eab4
	System.Void Resize(System.Int32 capcity); // 0x0767e9dc
}

// Client.Runtime
class WizardGames.Soc.AdaptivePerformance.BatteryGetter : System.Object
{
	static UnityEngine.AndroidJavaObject Getter; // 0x0
	static System.Void .cctor(); // 0x07681918
	static System.Void Init(); // 0x0768191c
	static System.Single get_Level(); // 0x07681d28
	static UnityEngine.BatteryStatus get_Status(); // 0x07681e64
}

// Client.Runtime
class WizardGames.Soc.AdaptivePerformance.CpuTimeProvider : System.Object
{
	
	System.Single get_CpuFrameTime(); // 0x07681004
	System.Void .ctor(); // 0x0768113c
}

// Client.Runtime
class WizardGames.Soc.AdaptivePerformance.GpuTimeProvider : System.Object
{
	
	System.Single get_GpuFrameTime(); // 0x07680f78
	System.Void .ctor(); // 0x076811a4
}

// Client.Runtime
enum WizardGames.Soc.AdaptivePerformance.EScaleTarget : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.AdaptivePerformance.EScaleTarget None = 0;
	static WizardGames.Soc.AdaptivePerformance.EScaleTarget CPU = 1;
	static WizardGames.Soc.AdaptivePerformance.EScaleTarget GPU = 2;
	static WizardGames.Soc.AdaptivePerformance.EScaleTarget FrameRate = 4;
	static WizardGames.Soc.AdaptivePerformance.EScaleTarget All = 7;
	
}

// Client.Runtime
enum WizardGames.Soc.AdaptivePerformance.EScaleMode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.AdaptivePerformance.EScaleMode None = 0;
	static WizardGames.Soc.AdaptivePerformance.EScaleMode ScaleUp = 1;
	static WizardGames.Soc.AdaptivePerformance.EScaleMode ScaleDownSlow = 2;
	static WizardGames.Soc.AdaptivePerformance.EScaleMode ScaleDownFast = 4;
	static WizardGames.Soc.AdaptivePerformance.EScaleMode ScaleDown = 6;
	static WizardGames.Soc.AdaptivePerformance.EScaleMode ScaleAll = 65535;
	
}

// Client.Runtime
class WizardGames.Soc.AdaptivePerformance.FrameTiming : System.Object
{
	System.Single CurrentFrameTime; // 0x10
	System.Single AverageFrameTime; // 0x14
	System.Single CurrentGpuFrameTime; // 0x18
	System.Single AverageGpuFrameTime; // 0x1c
	System.Single CurrentCpuFrameTime; // 0x20
	System.Single AverageCpuFrameTime; // 0x24
	System.Single TargetFrameTime; // 0x28
	System.Int32 TargetFrameRate; // 0x2c
	System.Void .ctor(); // 0x0768120c
}

// Client.Runtime
struct WizardGames.Soc.AdaptivePerformance.ThermalMetrics : System.ValueType
{
	WizardGames.Soc.AdaptivePerformance.WarningLevel <WarningLevel>k__BackingField; // 0x10
	WizardGames.Soc.AdaptivePerformance.ThermalObserver.EThermalStatus <ThermalStatus>k__BackingField; // 0x14
	System.Single <TemperatureLevel>k__BackingField; // 0x18
	System.Single <TemperatureTrend>k__BackingField; // 0x1c
	System.Void set_WarningLevel(WizardGames.Soc.AdaptivePerformance.WarningLevel value); // 0x07681fc0
	System.Void set_ThermalStatus(WizardGames.Soc.AdaptivePerformance.ThermalObserver.EThermalStatus value); // 0x07682038
	System.Void set_TemperatureLevel(System.Single value); // 0x076820b0
	System.Void set_TemperatureTrend(System.Single value); // 0x07682128
}

// Client.Runtime
enum WizardGames.Soc.AdaptivePerformance.WarningLevel : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.AdaptivePerformance.WarningLevel NoWarning = 0;
	static WizardGames.Soc.AdaptivePerformance.WarningLevel ThrottlingImminent = 1;
	static WizardGames.Soc.AdaptivePerformance.WarningLevel Throttling = 2;
	
}

// Client.Runtime
class WizardGames.Soc.AdaptivePerformance.MgrThermal : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	static System.Boolean GMDisableAFKDecreaseFrameRate; // 0x8
	System.Int32 _thermalState; // 0x14
	System.Single _thermalHeadroom; // 0x18
	System.Int32 _thermalStateCache; // 0x1c
	WizardGames.Soc.AdaptivePerformance.MgrThermal.EThermalManagementLevel _thermalManagementLevel; // 0x20
	System.Boolean _isPowerSavingMode; // 0x24
	System.Int32 _basicFrameRate; // 0x28
	WizardGames.Soc.AdaptivePerformance.MgrThermal.EStrategyEnableCondition _thermalDecFPSCondition; // 0x2c
	WizardGames.Soc.AdaptivePerformance.MgrThermal.EStrategyEnableCondition _afkDecFPSCondition; // 0x30
	System.DateTime _lastLightLevelTime; // 0x38
	System.DateTime _lastSeriousLevelTime; // 0x40
	System.Single _frameRateScale; // 0x48
	System.Single _AFKFrameRateScale; // 0x4c
	System.Boolean _isAFKStatus; // 0x50
	System.Boolean get_InLobby(); // 0x07682258
	System.Int32 get_ThermalState(); // 0x076822f4
	System.Int32 get_ThermalStateCache(); // 0x07682358
	System.Single get_ThermalHeadroom(); // 0x076823bc
	WizardGames.Soc.AdaptivePerformance.MgrThermal.EThermalManagementLevel get_ThermalManagementLevel(); // 0x07682420
	System.Void Init(); // 0x07682484
	System.Threading.Tasks.Task OnExitWorld(); // 0x07682760
	static System.Void HandleThermalStateChange(System.Int32 state); // 0x076821a0
	System.Void OnFpsUnlimitedUpdate(); // 0x0768283c
	System.Boolean IsEnableThermalStateDecFrameRate(); // 0x07682f10
	System.Boolean IsEnableAFKDecFrameRate(); // 0x07682fa0
	System.Void OnFps1Update(); // 0x07683064
	System.Void OnThermalManagementLevelChanged(); // 0x07683648
	System.Void ExecuteAFKStrategy(); // 0x076828c0
	System.Void UpdateFrameRate(); // 0x07682c3c
	System.Void ResetFrameRate(); // 0x076827d0
	System.Int32 GetFrameRateLevel(System.Int32 targetFrameRate); // 0x07683858
	System.Void ExecutePowerSavingStrategy(System.Int32 frameRateLevel); // 0x07683a5c
	WizardGames.Soc.AdaptivePerformance.MgrThermal.EThermalManagementLevel CalcThermalManagementLevel(); // 0x07683548
	static WizardGames.Soc.AdaptivePerformance.MgrThermal.EThermalState ThermalStatusFromThermalHeadroom(System.Single thermalHeadroom); // 0x07683c74
	System.Void .ctor(); // 0x07683d24
	static System.Void .cctor(); // 0x07683dd0
}

// Client.Runtime
enum WizardGames.Soc.AdaptivePerformance.MgrThermal.EThermalManagementLevel : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.AdaptivePerformance.MgrThermal.EThermalManagementLevel NONE = 0;
	static WizardGames.Soc.AdaptivePerformance.MgrThermal.EThermalManagementLevel LIGHT = 1;
	static WizardGames.Soc.AdaptivePerformance.MgrThermal.EThermalManagementLevel SERIOUS = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.AdaptivePerformance.MgrThermal.EStrategyEnableCondition : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.AdaptivePerformance.MgrThermal.EStrategyEnableCondition ENABLE = 1;
	static WizardGames.Soc.AdaptivePerformance.MgrThermal.EStrategyEnableCondition FOLLOW = 2;
	static WizardGames.Soc.AdaptivePerformance.MgrThermal.EStrategyEnableCondition DISABLE = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.AdaptivePerformance.MgrThermal.EThermalState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.AdaptivePerformance.MgrThermal.EThermalState THERMAL_STATUS_NONE = 0;
	static WizardGames.Soc.AdaptivePerformance.MgrThermal.EThermalState THERMAL_STATUS_LIGHT = 1;
	static WizardGames.Soc.AdaptivePerformance.MgrThermal.EThermalState THERMAL_STATUS_MODERATE = 2;
	static WizardGames.Soc.AdaptivePerformance.MgrThermal.EThermalState THERMAL_STATUS_SEVERE = 3;
	static WizardGames.Soc.AdaptivePerformance.MgrThermal.EThermalState THERMAL_STATUS_CRITICAL = 4;
	static WizardGames.Soc.AdaptivePerformance.MgrThermal.EThermalState THERMAL_STATUS_EMERGENCY = 5;
	static WizardGames.Soc.AdaptivePerformance.MgrThermal.EThermalState THERMAL_STATUS_SHUTDOWN = 6;
	
}

// Client.Runtime
class WizardGames.Soc.AdaptivePerformance.AdaptivePowerThrottling : WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceScalar
{
	
	System.Void Reset(); // 0x07683eb4
	System.Void OnLevelChanged(System.Int32 fromLevel, System.Int32 toLevel); // 0x07683f24
	System.Void .ctor(); // 0x076815a4
}

// Client.Runtime
class WizardGames.Soc.AdaptivePerformance.AdaptivePowerThrottling.<>c : System.Object
{
	static WizardGames.Soc.AdaptivePerformance.AdaptivePowerThrottling.<>c <>9; // 0x0
	static System.Action <>9__1_0; // 0x8
	static System.Void .cctor(); // 0x07684298
	System.Void .ctor(); // 0x076842fc
	System.Void <OnLevelChanged>b__1_0(); // 0x07684364
}

// Client.Runtime
class WizardGames.Soc.AdaptivePerformance.AdaptiveRMQuality : WizardGames.Soc.AdaptivePerformance.AdaptivePerformanceScalar
{
	
	System.Void Reset(); // 0x07684494
	System.Void OnLevelChanged(System.Int32 fromLevel, System.Int32 toLevel); // 0x07684504
	System.Void .ctor(); // 0x07681540
}

// Client.Runtime
class WizardGames.Soc.AdaptivePerformance.AdaptiveRMQuality.<>c : System.Object
{
	static WizardGames.Soc.AdaptivePerformance.AdaptiveRMQuality.<>c <>9; // 0x0
	static System.Action <>9__1_0; // 0x8
	static System.Void .cctor(); // 0x07684864
	System.Void .ctor(); // 0x076848c8
	System.Void <OnLevelChanged>b__1_0(); // 0x07684930
}

// Client.Runtime
class WizardGames.Soc.AdaptivePerformance.ThermalObserver : System.Object
{
	static WizardGames.Soc.AdaptivePerformance.ThermalObserver Instance; // 0x0
	UnityEngine.AndroidJavaObject _observer; // 0x10
	WizardGames.Soc.AdaptivePerformance.ThermalObserver.EThermalStatus _lastThermalStatus; // 0x18
	static System.Int32 UpdateThermalHeadroomInterval; // 0x8
	System.Boolean _isThermalSupported; // 0x1c
	static System.Void .cctor(); // 0x07684be0
	System.Void Init(); // 0x07684cd8
	static System.Single get_ThermalHeadroomCache(); // 0x07683228
	static System.Int32 get_ThermalStatusCache(); // 0x076833b8
	static WizardGames.Soc.AdaptivePerformance.ThermalObserver.EThermalStatus get_LastThermalStatus(); // 0x07680ee4
	System.Single GetThermalHeadroom(System.Int32 sec); // 0x07685418
	System.Void .ctor(); // 0x07684c68
}

// Client.Runtime
enum WizardGames.Soc.AdaptivePerformance.ThermalObserver.EThermalStatus : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.AdaptivePerformance.ThermalObserver.EThermalStatus Unknown = -1;
	static WizardGames.Soc.AdaptivePerformance.ThermalObserver.EThermalStatus None = 0;
	static WizardGames.Soc.AdaptivePerformance.ThermalObserver.EThermalStatus Light = 1;
	static WizardGames.Soc.AdaptivePerformance.ThermalObserver.EThermalStatus Moderate = 2;
	static WizardGames.Soc.AdaptivePerformance.ThermalObserver.EThermalStatus Severe = 3;
	static WizardGames.Soc.AdaptivePerformance.ThermalObserver.EThermalStatus Critical = 4;
	static WizardGames.Soc.AdaptivePerformance.ThermalObserver.EThermalStatus Emergency = 5;
	static WizardGames.Soc.AdaptivePerformance.ThermalObserver.EThermalStatus Shutdown = 6;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientChatBanInfo : System.Object
{
	System.Int64 EndTime; // 0x10
	System.Int32 Reason; // 0x18
	System.Int64 UpdateTime; // 0x20
	System.Void .ctor(); // 0x07685570
}

// Client.Runtime
enum WizardGames.Soc.SocClient.EChatChannelType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.EChatChannelType Personal = 0;
	static WizardGames.Soc.SocClient.EChatChannelType World = 1;
	static WizardGames.Soc.SocClient.EChatChannelType Team = 2;
	static WizardGames.Soc.SocClient.EChatChannelType Appointment = 3;
	static WizardGames.Soc.SocClient.EChatChannelType Tribe = 4;
	static WizardGames.Soc.SocClient.EChatChannelType Union = 5;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.EChatCategory : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.EChatCategory World = 0;
	static WizardGames.Soc.SocClient.EChatCategory Personal = 1;
	static WizardGames.Soc.SocClient.EChatCategory Team = 2;
	static WizardGames.Soc.SocClient.EChatCategory Tribe = 3;
	static WizardGames.Soc.SocClient.EChatCategory Union = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.EChannelTypeOrderType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.EChannelTypeOrderType Inplace = 0;
	static WizardGames.Soc.SocClient.EChannelTypeOrderType Insert = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.EClientChatMessageType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.EClientChatMessageType Normal = 0;
	static WizardGames.Soc.SocClient.EClientChatMessageType SystemMessage = 1;
	static WizardGames.Soc.SocClient.EClientChatMessageType SystemBanMessage = 2;
	static WizardGames.Soc.SocClient.EClientChatMessageType TeamRecruitMessage = 3;
	static WizardGames.Soc.SocClient.EClientChatMessageType TribeSystemMessage = 4;
	static WizardGames.Soc.SocClient.EClientChatMessageType VoiceMessage = 5;
	static WizardGames.Soc.SocClient.EClientChatMessageType FriendGiftMessage = 6;
	static WizardGames.Soc.SocClient.EClientChatMessageType Emoji = 7;
	static WizardGames.Soc.SocClient.EClientChatMessageType TribeAnnouncement = 8;
	static WizardGames.Soc.SocClient.EClientChatMessageType ShareMessage = 9;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientChatMessage : System.Object
{
	System.Int64 RoleId; // 0x10
	System.String GroupId; // 0x18
	System.String channelId; // 0x20
	System.UInt32 Id; // 0x28
	System.String MessageMeta; // 0x30
	System.String MessageContent; // 0x38
	System.Int32 ChatBubbleId; // 0x40
	System.Int32 PortraitFrame; // 0x44
	System.Int64 TimeInfo; // 0x48
	WizardGames.Soc.SocClient.EClientChatMessageType msgType; // 0x50
	System.Int32 reputationLevel; // 0x54
	System.Boolean get_IsSelf(); // 0x076855d8
	System.Void .ctor(); // 0x07685680
	System.Void .ctor(WizardGames.Soc.Common.CustomType.ChatMessage message); // 0x076856f0
	System.Void .ctor(System.String content, System.UInt64 roleId, System.Int64 timeInfo, System.String meta, System.Boolean isIngame); // 0x07685a60
	System.Void SetMessageContent(System.String str, System.String meta); // 0x076857c8
	System.Void SetMessageContent(System.String str, System.Boolean isIngame); // 0x07685b7c
	System.String DrawChatMessage(System.Boolean roleName, System.Boolean shortMessage, System.Boolean nameAbbreviation); // 0x07686244
	System.String MakeEmoji(System.String viewMsg); // 0x07686c38
	static System.String GetProvider(WizardGames.Soc.SocClient.ClientChatMessage message); // 0x07686fc8
	static System.String WeekEnumToString(System.DayOfWeek day); // 0x07687124
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientChatMessageFactory : System.Object
{
	
	static SimpleJSON.JSONObject CreateSelfRoleInfo(); // 0x076872f4
	static System.String GetSHA256Hash(System.String input); // 0x07685fb8
	static System.String CreateMessage(System.String content, WizardGames.Soc.SocClient.EClientChatMessageType messageType, System.Boolean isIngame, System.String& meta); // 0x07687ab4
	static System.String CreateEmojiMessage(System.String content, WizardGames.Soc.SocClient.EClientChatMessageType messageType, System.Boolean isIngame, System.String& meta); // 0x07687d28
	static System.String CreateVoiceMessage(System.String content, WizardGames.Soc.SocClient.EClientChatMessageType messageType, System.Int32 time, System.Boolean isIngame, System.String& meta); // 0x07687ff8
	static System.String CreateTeamMessage(System.Boolean needAudit, System.String teamId, System.Int32 modeId, WizardGames.Soc.SocClient.Ui.ERecruitType eRecruitType, SimpleJSON.JSONArray membersJson, System.Int32 maxMember, System.Boolean isIngame, System.String& meta); // 0x0768831c
	static System.String CreateShareMessage(WizardGames.Soc.SocClient.ClientChatShareInfo shareInfo, System.Boolean isIngame, System.String& meta); // 0x076889f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientChatRoomFactory : System.Object
{
	
	static WizardGames.Soc.SocClient.IClientChatRoom CreateRoom(System.String channelId, System.UInt32 remoteSeq, System.UInt32 lastReadSeq); // 0x07688f5c
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientChatShareInfo : System.Object
{
	WizardGames.Soc.Common.Data.EChatShareScene shareScene; // 0x10
	System.String customContent; // 0x18
	WizardGames.Soc.SocClient.SystemContent systemContent; // 0x20
	System.Int32 itemId; // 0x38
	System.String itemIconUrl; // 0x40
	System.String param; // 0x48
	System.Void .ctor(); // 0x07689660
}

// Client.Runtime
struct WizardGames.Soc.SocClient.SystemContent : System.ValueType
{
	System.String text; // 0x10
	System.Int32 contentID; // 0x18
	System.String[] args; // 0x20
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientChatUtils : System.Object
{
	
	static System.Int32 get_GlobalMessageCacheMax(); // 0x07689774
	static System.Int32 GetChannelOrder(System.String channelId); // 0x07689854
	static WizardGames.Soc.SocClient.EChatCategory GetChannelCategory(System.String channelId); // 0x076898cc
	static WizardGames.Soc.SocClient.EChatCategory GetChannelCategory(WizardGames.Soc.SocClient.EChatChannelType chatChannelType); // 0x07689934
	static WizardGames.Soc.SocClient.EChatChannelType GetChannelType(System.String channelId); // 0x07689150
	static System.String GetChannelCategoryName(WizardGames.Soc.SocClient.EChatCategory channelCategory); // 0x076899b4
	static System.Int32 GetChannelTypeCapacity(WizardGames.Soc.SocClient.EChatChannelType channelType); // 0x07689ad4
	static WizardGames.Soc.SocClient.EChannelTypeOrderType GetChannelTypeOrderType(WizardGames.Soc.SocClient.EChatChannelType channelType); // 0x07689bd0
	static System.Single GetSendMessageCD(System.String channelId); // 0x07689c38
	static System.Boolean GetShowMessageCDNotice(System.String channelId); // 0x07689e88
	static System.Boolean GetClearOnSwitchNeedSave(System.String channelId); // 0x07689f10
	static System.Boolean GetClearOnSwitch(System.String channelId); // 0x07689fc8
	static System.String GetChannelName(System.String channelId); // 0x0768a048
	static System.String GetChannelColor(System.String channelId); // 0x0768a178
	static System.String GetChannelRelationship(System.String channelId); // 0x0768a280
}

// Client.Runtime
class WizardGames.Soc.SocClient.Deque_RandomAccess<T> : System.Object
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,T> dic; // 0x0
	System.Int32 capacity; // 0x0
	System.Int64 <Offset>k__BackingField; // 0x0
	System.Int32 get_Capacity(); // 0x0548ba98
	System.Void set_Capacity(System.Int32 value); // 0x055056e8
	System.Int64 get_Offset(); // 0x054a4380
	System.Void set_Offset(System.Int64 value); // 0x055112ac
	System.Int32 get_Count(); // 0x0548ba98
	System.Void .ctor(System.Int32 capacity, System.Int64 offset); // 0x05507378
	T get_Item(System.Int32 index); // 0x052af1f0
	T GetByRealIdx(System.Int64 idx); // 0x052af1f0
	System.Int32 GetIdxByRealIdx(System.Int64 idx); // 0x0548c86c
	System.Int64 GetRealIdxByIdx(System.Int32 idx); // 0x054a4454
	System.Boolean get_IsEmpty(); // 0x054c4760
	System.Boolean get_IsFull(); // 0x054c4760
	T get_Back(); // 0x052af1f0
	System.Void Clear(); // 0x055049cc
	System.Void Resize(System.Int32 capacity, System.Boolean silent); // 0x0550f700
	System.Void ResetOffset(System.Int64 offset); // 0x055112ac
	System.Int64 PushBack(T value); // 0x052af1f0
	T PopBack(); // 0x052af1f0
	T PopFront(); // 0x052af1f0
	System.Void Remove(System.Func<T,System.Boolean> needRemove); // 0x05523a54
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrChat : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.IClientChatRoom> chatRooms; // 0x18
	System.Int64 worldChatChannel; // 0x20
	System.Collections.Generic.Dictionary<System.UInt64,WizardGames.Soc.SocClient.RoleInfo> roleIdDic; // 0x28
	System.Collections.Generic.Dictionary<System.UInt64,WizardGames.Soc.SocClient.RoleInfo> systemRoleDic; // 0x30
	WizardGames.Soc.SocClient.ClientChatBanInfo chatBan; // 0x38
	System.Collections.Generic.List<System.Collections.Generic.List<System.String>> roomCategoryLst; // 0x40
	WizardGames.Soc.SocClient.Deque_RandomAccess<WizardGames.Soc.SocClient.ClientChatMessage> totalMessageQueue; // 0x48
	System.String serverBattleId; // 0x50
	System.UInt64 roleId; // 0x58
	System.Boolean IsInLobby; // 0x60
	System.Collections.Generic.HashSet<System.UInt64> personalBriefRoleIds; // 0x68
	WizardGames.Soc.SocClient.ClientChatMessage reportMessage; // 0x70
	static System.Comparison<WizardGames.Soc.SocClient.ClientChatMessage> CompareByTime; // 0x8
	static System.UInt64 removeWorldChatMsgRoleId; // 0x10
	static System.Func<WizardGames.Soc.SocClient.ClientChatMessage,System.Boolean> InnerRemoveWorldChatMsgPending; // 0x18
	LZ4Sharp.LZ4Decompressor64 lz4Decompressor; // 0x78
	System.Int64 get_WorldChatChannel(); // 0x0768a3a8
	System.String get_privateCacheFileName(); // 0x0768a40c
	System.String get_lobbyTeamCacheFileName(); // 0x0768a4c8
	System.Void OnAccountLogined(); // 0x0768a584
	System.Void OnAccountEnterLobby(); // 0x0768aa38
	System.Void OnFastReconnected(); // 0x0768abd4
	System.Void OnLobbyTeamMemberLeaveNotice(System.String roleId, System.Boolean isAppointment); // 0x0768b574
	System.Void RefreshTeamChannel(); // 0x0768b5f4
	System.Void RefreshTribeChannel(); // 0x0768c494
	System.Void RefreshUnionChannel(); // 0x0768cfd8
	System.Void OnAccountLogout(); // 0x0768d5a0
	System.Void Initialize(); // 0x0768d904
	System.Boolean IsChatBand(); // 0x054c4760
	WizardGames.Soc.SocClient.IClientChatRoom GetRoom(System.String channelId, System.Boolean createIfNotExist); // 0x0768addc
	System.Void ShowBandTips(); // 0x0768de40
	System.Void RequestMuteStatus(); // 0x0768df50
	System.Collections.Generic.List<System.String> GetFriendPersonalChannels(); // 0x0768e1ec
	System.Void OnMuteStatusChange(SimpleJSON.JSONNode node); // 0x0768e4c0
	System.Void SetBanInfo(System.Int64 endTime, System.Int32 reason); // 0x0768e84c
	System.Threading.Tasks.Task OnEnterWorld(); // 0x0768e8dc
	System.Threading.Tasks.Task OnExitWorld(); // 0x0768eafc
	System.Void EnterLobbyInit(System.Boolean isFirstInit); // 0x0768a93c
	System.Void EnterBattleInit(); // 0x0768e9fc
	System.Void OnTeamMemberChange(WizardGames.Soc.Share.Framework.ECustomDictOpType changeType, System.UInt64 roleId, WizardGames.Soc.Common.CustomType.TeamMemberInfo oldMember); // 0x0769041c
	System.Void OnWorldChatChannelIdChanged(System.Int64 newChannel); // 0x07690598
	System.Void ExitClear(System.Boolean stilInGame); // 0x0768d7cc
	System.Void OnGetPersonalBrieflistMessage(SimpleJSON.JSONNode node); // 0x07690708
	System.Void CreateRoom(WizardGames.Soc.Common.CustomType.ChatSession session); // 0x0768be38
	System.Void CreateRoom(SimpleJSON.JSONNode roomNode); // 0x07691410
	WizardGames.Soc.SocClient.IClientChatRoom CreateRoom(System.String channelId); // 0x0768ce04
	System.Void CreateRoomOver(WizardGames.Soc.SocClient.IClientChatRoom room); // 0x076917d0
	System.Void ClearChannel(System.String channelId, System.Int64 offset); // 0x07691df8
	System.Void RemoveRoom(System.String channelId); // 0x0768bbf0
	System.Void MoveChannelToTop(System.String channelId); // 0x0769198c
	System.Void Save(System.Boolean isSaveBattle); // 0x0768ec20
	System.Void SaveChatData(System.Collections.Generic.List<WizardGames.Soc.SocClient.ClientChatMessage> chatList, System.Collections.Generic.List<WizardGames.Soc.SocClient.RoleInfo> roleList, System.String fileName); // 0x076920ac
	System.Void Load(System.Boolean isLoadBattle, System.Boolean isFirstLoad); // 0x0768f718
	WizardGames.Soc.SocClient.MgrChat.SaveStruct LoadChatData(System.String fileName); // 0x076922c8
	System.Void AddOrUpdateRoleBriefInfo(WizardGames.Soc.Common.SimpleCustom.PlayerBriefInfo playerBriefInfo, System.Int32 reputationLevel); // 0x07692508
	System.Void AddOrUpdateRoleInfo(SimpleJSON.JSONNode jsonNode, System.Boolean isFullInfo); // 0x07692744
	System.Void OnGetRoleInfo(WizardGames.Soc.Common.SimpleCustom.PlayerBriefInfo info); // 0x07692ef4
	WizardGames.Soc.SocClient.RoleInfo GetRoleInfo(System.UInt64 roleId, System.Action callback); // 0x076930b0
	System.Void OnGetRolesInfo(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.PlayerBriefInfo> infoLst); // 0x076937bc
	System.Void GetRolesInfo(System.Collections.Generic.List<System.UInt64> lst); // 0x07693974
	WizardGames.Soc.SocClient.RoleInfo UpdateSelfInfo(); // 0x07693248
	System.Int32 CheckUnseen(WizardGames.Soc.SocClient.EChatCategory channelCategory, System.String blockId); // 0x076939fc
	System.Int32 CheckRedDot(); // 0x07693cf4
	System.Void OnCreateChannel(System.String channelId); // 0x07691b2c
	System.Void SortChannel(System.String channelId); // 0x0769419c
	System.Void GetRoleInfoLobbyCallBack(SimpleJSON.JSONArray retArray); // 0x0769449c
	System.Void RemoteCallGetMultiPlayerInfo(System.Collections.Generic.List<System.UInt64> roleIds, System.Action callback); // 0x076934cc
	System.Void RemoveWorldChatMsg(System.UInt64 roleId); // 0x07694664
	System.Void RecvTotalMessage(WizardGames.Soc.SocClient.ClientChatMessage msg, System.Boolean autoIncrease); // 0x0768aeb4
	System.Void CompensateMessage(WizardGames.Soc.SocClient.ClientChatMessage msg); // 0x076949b0
	System.Void RecvTribeMessage(System.String tribeId, WizardGames.Soc.SDK.InGameMsgContent msg); // 0x07694ab8
	System.Void RecvUnionMessage(System.UInt64 unionId, WizardGames.Soc.SDK.InGameMsgContent msg); // 0x07694f88
	System.Void PullMsgCallBack(System.String ingameGroupId, System.Collections.Generic.List<WizardGames.Soc.SDK.InGameMsgContent> msgs); // 0x076954a0
	System.Void InGameErrorCallBack(System.String ingameGroupId, System.Int32 errorCode); // 0x07695580
	System.Void AddMemberInGame(System.String inGameGroupID, System.String roleId); // 0x07695640
	System.Void RemoveMemberInGame(System.String inGameGroupID, System.String roleId); // 0x07695720
	System.Void DestoryInGameGroup(System.String inGameGroupID); // 0x07695800
	System.Void SendShareMessage(System.String channelId, WizardGames.Soc.SocClient.ClientChatShareInfo shareInfo, System.Action successCallback); // 0x076958d0
	System.String GetSystemContentText(SimpleJSON.JSONNode jsonNode); // 0x07695cb4
	System.String ConcatArgs(System.String oriContent, SimpleJSON.JSONArray args); // 0x07695f24
	System.Void ReqBattleReport(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.String battleServerID, System.Int64 reportId, System.Action<WizardGames.Soc.Common.CustomType.PlunderReport> callback, System.Action failCallback); // 0x0769644c
	WizardGames.Soc.Common.CustomType.PlunderReport CreateReport(System.Int64 reportId, System.Byte[] reportBytes); // 0x076967d8
	WizardGames.Soc.Common.CustomType.PlunderReportData DecompressReportData(System.Int64 reportId, System.Byte[] readonlyBytes); // 0x076968c4
	System.Void .ctor(); // 0x076972dc
	static System.Void .cctor(); // 0x07697540
}

// Client.Runtime
struct WizardGames.Soc.SocClient.MgrChat.SaveStruct : System.ValueType
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.ClientChatMessage> chatList; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.RoleInfo> roleList; // 0x18
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrChat.<>c : System.Object
{
	static WizardGames.Soc.SocClient.MgrChat.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.ClientChatMessage> <>9__54_0; // 0x8
	static System.Void .cctor(); // 0x07697710
	System.Void .ctor(); // 0x07697774
	System.Int32 <Load>b__54_0(WizardGames.Soc.SocClient.ClientChatMessage a, WizardGames.Soc.SocClient.ClientChatMessage b); // 0x076977dc
	System.Int32 <.cctor>b__94_0(WizardGames.Soc.SocClient.ClientChatMessage x, WizardGames.Soc.SocClient.ClientChatMessage y); // 0x07697870
	System.Boolean <.cctor>b__94_1(WizardGames.Soc.SocClient.ClientChatMessage msg); // 0x07697904
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrChat.<>c__DisplayClass24_0 : System.Object
{
	System.Collections.Generic.KeyValuePair<System.String,WizardGames.Soc.SocClient.IClientChatRoom> channel; // 0x10
	System.Void .ctor(); // 0x0768cf04
	System.Boolean <RefreshTribeChannel>b__0(WizardGames.Soc.SocClient.Ui.TribeInfo t); // 0x076979f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrChat.<>c__DisplayClass49_0 : System.Object
{
	System.String channelId; // 0x10
	System.Void .ctor(); // 0x07692044
	System.Boolean <RemoveRoom>b__0(WizardGames.Soc.SocClient.ClientChatMessage msg); // 0x07697acc
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrChat.<>c__DisplayClass69_0 : System.Object
{
	WizardGames.Soc.SocClient.MgrChat <>4__this; // 0x10
	System.Action callback; // 0x18
	System.Void .ctor(); // 0x076945fc
	System.Void <RemoteCallGetMultiPlayerInfo>b__0(SimpleJSON.JSONArray node); // 0x07697b58
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrChat.<>c__DisplayClass89_0 : System.Object
{
	System.Int64 reportId; // 0x10
	System.Action failCallback; // 0x18
	WizardGames.Soc.SocClient.MgrChat <>4__this; // 0x20
	System.Action<WizardGames.Soc.Common.CustomType.PlunderReport> callback; // 0x28
	System.Void .ctor(); // 0x07696770
	System.Void <ReqBattleReport>b__0(SimpleJSON.JSONNode info); // 0x07697c04
	System.Void <ReqBattleReport>b__1(SimpleJSON.JSONNode node); // 0x07697ec8
}

// Client.Runtime
class WizardGames.Soc.SocClient.RoleInfo : Config.LobbyRoleInfo
{
	System.Int64 longRoleId; // 0x110
	System.String roleAvatarString; // 0x118
	System.Boolean isRoleOnline; // 0x120
	System.Int32 givenPermissions; // 0x124
	System.String messageContent; // 0x128
	System.Int32 reputationLevel; // 0x130
	System.Int32 styleID; // 0x134
	System.Int32 rankPoint; // 0x138
	System.String GetAvatarUrl(); // 0x07697f60
	System.Void SetChatSimpleData(SimpleJSON.JSONNode jsonNode); // 0x07692b34
	System.Void .ctor(); // 0x0768a878
}

// Client.Runtime
class WizardGames.Soc.SocClient.BaseClientChatRoom : System.Object, WizardGames.Soc.SocClient.IClientChatRoom
{
	SocLogger logger; // 0x10
	WizardGames.Soc.SocClient.EChatChannelType <ChannelType>k__BackingField; // 0x18
	System.String channelId; // 0x20
	System.Boolean <IsOpen>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Deque_RandomAccess<WizardGames.Soc.SocClient.ClientChatMessage> <ChatMessages>k__BackingField; // 0x30
	WizardGames.Soc.SocClient.ClientChatMessage <FinalMsg>k__BackingField; // 0x38
	System.Boolean <IsMessageBrief>k__BackingField; // 0x40
	System.UInt32 <RemoteSeq>k__BackingField; // 0x44
	System.UInt32 <LastReadSeq>k__BackingField; // 0x48
	System.Boolean <HaveNotSeenTeamInvite>k__BackingField; // 0x4c
	System.Single <NxtSendTime>k__BackingField; // 0x50
	WizardGames.Soc.SocClient.EChatChannelType get_ChannelType(); // 0x07697fe8
	System.Void set_ChannelType(WizardGames.Soc.SocClient.EChatChannelType value); // 0x0769804c
	System.String get_ChannelId(); // 0x076980c4
	System.Void set_ChannelId(System.String value); // 0x07698128
	System.Boolean get_IsOpen(); // 0x07698210
	System.Void set_IsOpen(System.Boolean value); // 0x07698274
	WizardGames.Soc.SocClient.Deque_RandomAccess<WizardGames.Soc.SocClient.ClientChatMessage> get_ChatMessages(); // 0x076982f0
	System.Void set_ChatMessages(WizardGames.Soc.SocClient.Deque_RandomAccess<WizardGames.Soc.SocClient.ClientChatMessage> value); // 0x07698354
	System.Void set_FinalMsg(WizardGames.Soc.SocClient.ClientChatMessage value); // 0x076983d4
	System.Boolean get_IsMessageBrief(); // 0x07698454
	System.Void set_IsMessageBrief(System.Boolean value); // 0x076984b8
	System.UInt32 get_RemoteSeq(); // 0x07698534
	System.Void set_RemoteSeq(System.UInt32 value); // 0x07698598
	System.UInt32 get_LastReadSeq(); // 0x07698610
	System.Void set_LastReadSeq(System.UInt32 value); // 0x07698674
	System.Boolean get_HaveNotSeenTeamInvite(); // 0x076986ec
	System.Void set_HaveNotSeenTeamInvite(System.Boolean value); // 0x07698750
	System.UInt32 get_CurrentSeq(); // 0x076987cc
	System.UInt32 get_UnseenCount(); // 0x07698920
	System.UInt32 get_UnRecvCount(); // 0x07698a18
	System.Int32 get_MessageCount(); // 0x07698ad0
	System.Single get_NxtSendTime(); // 0x07698b98
	System.Void set_NxtSendTime(System.Single value); // 0x07698bfc
	System.Void .ctor(System.String channelId, System.UInt32 remoteSeq, System.UInt32 lastReadSeq); // 0x07698c74
	System.Void OnReceiveMsg(WizardGames.Soc.SocClient.ClientChatMessage msg); // 0x05523a54
	System.String GetRoomName(System.Boolean withRelationship, System.Action<System.String> action); // 0x054f9f80
	System.Void OnClose(); // 0x055049cc
	System.Void OnUpdate(); // 0x055049cc
	System.Boolean ExceuteSendMsg(System.String msgContent, System.String msgMeta, System.Action callback); // 0x054e13bc
	System.Void SetReadSeqToLatest(); // 0x055049cc
	System.Boolean SendMsg(System.String msgContent, System.String msgMeta, System.Action callback); // 0x07699140
	System.Void ReceiveMsg(WizardGames.Soc.SocClient.ClientChatMessage msg, System.Boolean autoIncrease); // 0x076993b8
	System.Void RequestUnRecvMessage(System.Action getCallback); // 0x07699744
	System.Void ClearUnseen(); // 0x076997d8
	System.Void UpdateSeq(System.UInt32 remoteSeq, System.UInt32 lastReadSeq); // 0x07698ef8
	System.Void Close(); // 0x076998e0
	System.Void Update(); // 0x076999a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientChatRoomAppointmentTeam : WizardGames.Soc.SocClient.BaseClientChatRoom
{
	
	System.Void .ctor(System.String channelId, System.UInt32 remoteSeq, System.UInt32 lastReadSeq); // 0x076893e0
	System.String GetRoomName(System.Boolean withRelationship, System.Action<System.String> action); // 0x07699a08
	System.Void OnClose(); // 0x07699acc
	System.Void OnUpdate(); // 0x07699b2c
	System.Boolean ExceuteSendMsg(System.String msgContent, System.String msgMeta, System.Action callback); // 0x07699b8c
	System.Void SetReadSeqToLatest(); // 0x0769a0ac
	System.Void OnReceiveMsg(WizardGames.Soc.SocClient.ClientChatMessage msg); // 0x0769a10c
	System.Void ClearUnseen(); // 0x0769a180
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientChatRoomAppointmentTeam.<>c__DisplayClass5_0 : System.Object
{
	System.Action callback; // 0x10
	System.Void .ctor(); // 0x0769a044
	System.Void <ExceuteSendMsg>b__0(SimpleJSON.JSONNode node); // 0x0769a244
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientChatRoomPersonal : WizardGames.Soc.SocClient.BaseClientChatRoom
{
	
	System.Void .ctor(System.String channelId, System.UInt32 remoteSeq, System.UInt32 lastReadSeq); // 0x07689480
	System.String GetRoomName(System.Boolean withRelationship, System.Action<System.String> action); // 0x0769a2dc
	System.Boolean ExceuteSendMsg(System.String msgContent, System.String msgMeta, System.Action callback); // 0x0769a798
	System.Void SetReadSeqToLatest(); // 0x0769ac54
	System.Void OnReceiveMsg(WizardGames.Soc.SocClient.ClientChatMessage msg); // 0x0769aec4
	System.Void OnClose(); // 0x0769af38
	System.Void OnUpdate(); // 0x0769af9c
	System.Void RequestUnRecvMessage(System.Action getCallback); // 0x0769affc
	System.Void OnGetPersonalDetailMessage(SimpleJSON.JSONNode chatroom); // 0x0769b34c
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientChatRoomPersonal.<>c : System.Object
{
	static WizardGames.Soc.SocClient.ClientChatRoomPersonal.<>c <>9; // 0x0
	static System.Action <>9__1_1; // 0x8
	static System.Action<SimpleJSON.JSONNode> <>9__2_0; // 0x10
	static System.Comparison<WizardGames.Soc.SocClient.ClientChatMessage> <>9__9_0; // 0x18
	static System.Void .cctor(); // 0x0769bec4
	System.Void .ctor(); // 0x0769bf28
	System.Void <GetRoomName>b__1_1(); // 0x0769bf90
	System.Void <ExceuteSendMsg>b__2_0(SimpleJSON.JSONNode result); // 0x0769bff0
	System.Int32 <OnGetPersonalDetailMessage>b__9_0(WizardGames.Soc.SocClient.ClientChatMessage x, WizardGames.Soc.SocClient.ClientChatMessage y); // 0x0769c11c
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientChatRoomPersonal.<>c__DisplayClass1_0 : System.Object
{
	WizardGames.Soc.SocClient.ClientChatRoomPersonal <>4__this; // 0x10
	System.Boolean withRelationship; // 0x18
	System.Action<System.String> action; // 0x20
	System.Void .ctor(); // 0x0769a730
	System.Void <GetRoomName>b__0(); // 0x0769c1b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientChatRoomPersonal.<>c__DisplayClass8_0 : System.Object
{
	WizardGames.Soc.SocClient.ClientChatRoomPersonal <>4__this; // 0x10
	System.Action getCallback; // 0x18
	System.Void .ctor(); // 0x0769b2e4
	System.Void <RequestUnRecvMessage>b__0(SimpleJSON.JSONNode json); // 0x0769c404
	System.Void <RequestUnRecvMessage>b__1(SimpleJSON.JSONNode json); // 0x0769c4f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientChatRoomTeam : WizardGames.Soc.SocClient.BaseClientChatRoom
{
	
	System.Void .ctor(System.String channelId, System.UInt32 remoteSeq, System.UInt32 lastReadSeq); // 0x07689340
	System.String GetRoomName(System.Boolean withRelationship, System.Action<System.String> action); // 0x0769c59c
	System.Void OnClose(); // 0x0769c660
	System.Void OnUpdate(); // 0x0769c6c4
	System.Boolean ExceuteSendMsg(System.String msgContent, System.String msgMeta, System.Action callback); // 0x0769c724
	System.Void SetReadSeqToLatest(); // 0x0769cc00
	System.Void OnReceiveMsg(WizardGames.Soc.SocClient.ClientChatMessage msg); // 0x0769cd5c
	System.Void RequestUnRecvMessage(System.Action getCallback); // 0x0769cdd0
	System.Void ClearUnseen(); // 0x0769cf6c
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientChatRoomTribe : WizardGames.Soc.SocClient.BaseClientChatRoom
{
	WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo; // 0x58
	WizardGames.Soc.SocClient.Ui.TribeInfo get_TribeInfo(); // 0x0769d030
	System.Void .ctor(System.String channelId, System.UInt32 remoteSeq, System.UInt32 lastReadSeq); // 0x07689520
	System.Void ForceClearTribeInfo(); // 0x0768cf6c
	System.UInt32 get_UnseenCount(); // 0x0769d14c
	System.UInt32 GetUnseenCount(); // 0x0769d1b0
	System.String GetRoomName(System.Boolean withRelationship, System.Action<System.String> action); // 0x0769d248
	System.Boolean ExceuteSendMsg(System.String msgContent, System.String msgMeta, System.Action callback); // 0x0769d328
	System.Void CheckAddActiveScore(WizardGames.Soc.SocClient.EClientChatMessageType msgType); // 0x0769d5d8
	System.Void OnReceiveMsg(WizardGames.Soc.SocClient.ClientChatMessage msg); // 0x0769d7b0
	System.Void SetReadSeqToLatest(); // 0x0769d824
	System.Void OnClose(); // 0x0769d884
	System.Void OnUpdate(); // 0x0769d8e4
	System.Void ClearUnseen(); // 0x0769d944
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientChatRoomUnion : WizardGames.Soc.SocClient.BaseClientChatRoom
{
	
	WizardGames.Soc.SocClient.Ui.UnionInfo get_unionInfo(); // 0x0769da08
	System.Void .ctor(System.String channelId, System.UInt32 remoteSeq, System.UInt32 lastReadSeq); // 0x076895c0
	System.Void OnReceiveMsg(WizardGames.Soc.SocClient.ClientChatMessage msg); // 0x0769dad8
	System.String GetRoomName(System.Boolean withRelationship, System.Action<System.String> action); // 0x0769db4c
	System.Void OnClose(); // 0x0769dc2c
	System.Void OnUpdate(); // 0x0769dc8c
	System.Boolean ExceuteSendMsg(System.String msgContent, System.String msgMeta, System.Action callback); // 0x0769dcec
	System.Void SetReadSeqToLatest(); // 0x0769dea0
	System.Void ClearUnseen(); // 0x0769df00
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientChatRoomWorld : WizardGames.Soc.SocClient.BaseClientChatRoom
{
	
	System.UInt32 get_UnseenCount(); // 0x0769dfc4
	System.Void .ctor(System.String channelId, System.UInt32 remoteSeq, System.UInt32 lastReadSeq); // 0x076892a0
	System.String GetRoomName(System.Boolean withRelationship, System.Action<System.String> action); // 0x0769e028
	System.Void OnClose(); // 0x0769e0ec
	System.Void OnUpdate(); // 0x0769e14c
	System.Boolean ExceuteSendMsg(System.String msgContent, System.String msgMeta, System.Action callback); // 0x0769e1ac
	System.Void SetReadSeqToLatest(); // 0x0769e77c
	System.Void OnReceiveMsg(WizardGames.Soc.SocClient.ClientChatMessage msg); // 0x0769e7dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientChatRoomWorld.<>c__DisplayClass7_0 : System.Object
{
	System.Action callback; // 0x10
	System.Void .ctor(); // 0x0769e714
	System.Void <ExceuteSendMsg>b__0(SimpleJSON.JSONNode result); // 0x0769e8bc
}

// Client.Runtime
interface WizardGames.Soc.SocClient.IClientChatRoom : 
{
	
	WizardGames.Soc.SocClient.EChatChannelType get_ChannelType(); // 0x0548ba98
	System.String get_ChannelId(); // 0x054e7844
	System.Boolean get_IsMessageBrief(); // 0x054c4760
	System.Void set_IsMessageBrief(System.Boolean value); // 0x05523a7c
	System.UInt32 get_RemoteSeq(); // 0x054e1e74
	System.UInt32 get_LastReadSeq(); // 0x054e1e74
	System.Void set_LastReadSeq(System.UInt32 value); // 0x05524bbc
	System.UInt32 get_CurrentSeq(); // 0x054e1e74
	System.UInt32 get_UnseenCount(); // 0x054e1e74
	System.Int32 get_MessageCount(); // 0x0548ba98
	System.Boolean get_HaveNotSeenTeamInvite(); // 0x054c4760
	System.Single get_NxtSendTime(); // 0x054a5abc
	WizardGames.Soc.SocClient.Deque_RandomAccess<WizardGames.Soc.SocClient.ClientChatMessage> get_ChatMessages(); // 0x054e7844
	System.String GetRoomName(System.Boolean withRelationship, System.Action<System.String> callback); // 0x054f9f80
	System.Boolean SendMsg(System.String msgContent, System.String msgMeta, System.Action callback); // 0x054e13bc
	System.Void ReceiveMsg(WizardGames.Soc.SocClient.ClientChatMessage msg, System.Boolean autoIncrease); // 0x0552af28
	System.Void SetReadSeqToLatest(); // 0x055049cc
	System.Void RequestUnRecvMessage(System.Action getCallback); // 0x05523a54
	System.Void ClearUnseen(); // 0x055049cc
	System.Void UpdateSeq(System.UInt32 remoteSeq, System.UInt32 lastReadSeq); // 0x05524f68
	System.Void Close(); // 0x055049cc
	System.Void Update(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrLootCollection : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Action<System.Boolean> OnStartLootingAck; // 0x18
	System.Action OnStopLootingAck; // 0x20
	System.Int64 WillLootingEntityId; // 0x28
	System.Action<System.Int64,System.Collections.Generic.List<System.Int64>> OnSwitchLootingAckAction; // 0x30
	WizardGames.Soc.SocClient.Ui.DigContainerType GlobalDigContainerType; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,System.String> playerNameDic; // 0x40
	System.String preSetLootName; // 0x48
	WizardGames.Soc.Common.Component.PlayerLootingComponent get_LootingComponent(); // 0x0769e954
	WizardGames.Soc.Common.Component.RootNodeComponent get_CurLootingRoot(); // 0x0769ea08
	WizardGames.Soc.Share.Framework.EntityBase get_CurLootingEntity(); // 0x0769ea9c
	System.Threading.Tasks.Task AfterEnterWorld(); // 0x0769eb50
	System.Threading.Tasks.Task OnExitWorld(); // 0x0769ece4
	System.Void OnFinishGuide(System.Int32 guideId); // 0x0769ee9c
	System.Void OnGetMultiPlayerNames(System.Collections.Generic.Dictionary<System.Int64,System.String> playerIds2Names); // 0x0769ef3c
	System.String GetPlayerName(System.Int64 playerId); // 0x0769f114
	System.String get_LootName(); // 0x0769f1e0
	static WizardGames.Soc.Common.Entity.PartEntity get_CurLootingPartEntity(); // 0x0769f5bc
	System.Void PreSetLootName(System.String lootName); // 0x0769f6ac
	WizardGames.Soc.Common.CustomType.ItemContainerNode GetLootContainerByIndex(System.Int32 id); // 0x0769f4dc
	System.Boolean HasLootContainer(); // 0x0769f72c
	WizardGames.Soc.Common.CustomType.BaseItemNode GetLootItemByNodeId(System.Int64 uid); // 0x0769faf8
	System.Void ForeachContainer(System.Func<WizardGames.Soc.Common.CustomType.ItemContainerNode,System.Boolean> process); // 0x0769fc14
	static System.Boolean IterateContainer(WizardGames.Soc.Share.Game.NodeSystem.IDirectoryNode node, System.Func<WizardGames.Soc.Common.CustomType.ItemContainerNode,System.Boolean> func); // 0x0769ffa8
	System.Void PickItem(WizardGames.Soc.Common.CustomType.BaseItemNode item, System.Int64 tarContainer, System.Int64 tarIndex); // 0x076a03a8
	System.Boolean IsCurLootCanPutItemsIn(); // 0x076a08ec
	System.Boolean IsCurLootCanMoveItemsOut(); // 0x076a0bdc
	static System.Boolean CheckPartType(WizardGames.Soc.Common.Construction.PartType partType); // 0x076a0d40
	System.Void SwitchLooting(System.Int64 collectionId, System.String uiName, System.Int32 uiType); // 0x076a0ddc
	System.Void SwitchLooting(System.Int64 collectionId, System.Collections.Generic.List<System.Int64> containerIds); // 0x076a1338
	System.Void OnSwitchLootingAck(System.Boolean success, System.Int64 collectionId, System.Collections.Generic.List<System.Int64> collectionIds); // 0x076a14b0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ClientCollectionItem> GetCollentions(System.Int64 collectionId, System.String uiName, System.Int32 uiType); // 0x076a10b4
	WizardGames.Soc.SocClient.Ui.ClientCollectionItem GetCollention(System.Int64 collectionId, System.String uiName, System.Int32 uiType); // 0x076a18a4
	System.Collections.Generic.List<System.Int64> GetEntityIds(System.Int64 collectionId); // 0x076a15f4
	System.Void ClientOnStopLotting(); // 0x076a1984
	System.Void .ctor(); // 0x076a1a48
	static System.Void .cctor(); // 0x076a1afc
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrLootCollection.<>c__DisplayClass32_0 : System.Object
{
	System.Boolean canMoveIn; // 0x10
	System.Void .ctor(); // 0x076a0b74
	System.Boolean <IsCurLootCanPutItemsIn>b__0(WizardGames.Soc.Common.CustomType.ItemContainerNode container); // 0x076a1bd0
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrLootCollection.<>c__DisplayClass33_0 : System.Object
{
	System.Boolean canMoveOut; // 0x10
	System.Void .ctor(); // 0x076a0cd8
	System.Boolean <IsCurLootCanMoveItemsOut>b__0(WizardGames.Soc.Common.CustomType.ItemContainerNode container); // 0x076a1c78
}

// Client.Runtime
class WizardGames.Soc.SocClient.HotfixCenter : System.Object
{
	static WizardGames.Soc.SocClient.HotfixCenter Instance; // 0x0
	System.Boolean isInited; // 0x10
	WizardGames.Soc.SocClient.HotfixCenter.EStatus currentStatus; // 0x14
	System.UInt32 codeDownloadNumber; // 0x18
	System.UInt32 codeChannelId; // 0x1c
	System.String codeUrl; // 0x20
	System.String codeVersion; // 0x28
	System.String codeMd5; // 0x30
	System.String codeDstDir; // 0x38
	System.String hotfixCodePath; // 0x40
	System.String hotfixCodeMd5; // 0x48
	SimpleJSON.JSONNode hotfixTableNode; // 0x50
	static System.Void .cctor(); // 0x076a1d14
	System.Void Init(); // 0x076a1de0
	System.Void Hotfix(); // 0x076a2524
	System.Void ReapplyTableHotfix(); // 0x076a3cc4
	System.Void PostHotfixCode(); // 0x076a3c64
	System.Void OnHotfixFailed(WizardGames.Soc.SocClient.EHotfixResult result); // 0x076a2d98
	System.Int32 ShouldHotfixCode(); // 0x076a3dd8
	System.Void OnMessageReceived(SimpleJSON.JSONNode rootNode); // 0x076a4208
	System.Void SetCurrentStatus(WizardGames.Soc.SocClient.HotfixCenter.EStatus s); // 0x076a4830
	System.Void StartDownloadCode(); // 0x076a28f0
	System.Void EndDownloadCode(WizardGames.Soc.Common.Download.DownloadResult result); // 0x076a4994
	System.Void RegisterHotfixLoop(); // 0x076a21c8
	static System.Void OnHotfix(); // 0x076a4df8
	static System.Void OnCodeDownloadCompleted(WizardGames.Soc.Common.Download.DownloadResult result); // 0x076a4e88
	System.Void .ctor(); // 0x076a1d78
}

// Client.Runtime
enum WizardGames.Soc.SocClient.HotfixCenter.EStatus : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.HotfixCenter.EStatus PENDING = 0;
	static WizardGames.Soc.SocClient.HotfixCenter.EStatus INIT_DOWNLOADER = 1;
	static WizardGames.Soc.SocClient.HotfixCenter.EStatus DOWNLOADING_CODE = 2;
	static WizardGames.Soc.SocClient.HotfixCenter.EStatus READY = 3;
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.HotfixCenter.CodeInfo : System.ValueType
{
	System.String version; // 0x10
	System.String md5; // 0x18
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.HotfixCenter.<>c : System.Object
{
	static WizardGames.Soc.SocClient.HotfixCenter.<>c <>9; // 0x0
	static System.Action <>9__21_0; // 0x8
	static System.Void .cctor(); // 0x076a4f4c
	System.Void .ctor(); // 0x076a4fb0
	System.Void <OnHotfixFailed>b__21_0(); // 0x076a5018
}

// Client.Runtime
class WizardGames.Soc.SocClient.HotfixCode : System.Object
{
	
	static System.Int32 SortAssets(UnityEngine.TextAsset[] assets, System.String[]& names, System.Span<System.Int32>& sortedIndices); // 0x076a50c4
	static WizardGames.Soc.SocClient.EHotfixResult Hotfix(System.String codePath); // 0x076a31bc
}

// Client.Runtime
struct WizardGames.Soc.SocClient.HotfixCode.ScopeAssetBundleLoader : System.ValueType, System.IDisposable
{
	UnityEngine.AssetBundle Ab; // 0x10
	System.Void .ctor(System.String codePath); // 0x076a5480
	System.Void Dispose(); // 0x076a550c
}

// Client.Runtime
class WizardGames.Soc.SocClient.HotfixCode.<>c__DisplayClass2_0 : System.Object
{
	System.Byte[] asmBytes; // 0x10
	System.Void .ctor(); // 0x076a5418
	System.Byte[] <Hotfix>b__0(System.String n); // 0x076a55c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.HotfixLogger : System.Object
{
	static SocLogger Logger; // 0x0
	static System.Void .cctor(); // 0x076a5640
}

// Client.Runtime
enum WizardGames.Soc.SocClient.EHotfixResult : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.EHotfixResult Success = 0;
	static WizardGames.Soc.SocClient.EHotfixResult MessageFormatError = 1;
	static WizardGames.Soc.SocClient.EHotfixResult DownloadUrlEmpty = 2;
	static WizardGames.Soc.SocClient.EHotfixResult DownloadChannelZero = 3;
	static WizardGames.Soc.SocClient.EHotfixResult DownloadExceededRetryCount = 10;
	static WizardGames.Soc.SocClient.EHotfixResult DownloadMissingCode = 11;
	static WizardGames.Soc.SocClient.EHotfixResult DownloadMissingCodeInfo = 12;
	static WizardGames.Soc.SocClient.EHotfixResult DownloadMissMatchCodeVersion = 13;
	static WizardGames.Soc.SocClient.EHotfixResult DownloadUnknownContent = 14;
	static WizardGames.Soc.SocClient.EHotfixResult HotfixTableFailed = 20;
	static WizardGames.Soc.SocClient.EHotfixResult HotfixCodeLoadFailed = 21;
	static WizardGames.Soc.SocClient.EHotfixResult HotfixAssemblyMissingInfo = 22;
	static WizardGames.Soc.SocClient.EHotfixResult HotfixAssemblyFailed = 23;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.HotfixTable : System.Object
{
	
	static WizardGames.Soc.SocClient.EHotfixResult Hotfix(SimpleJSON.JSONNode hotfix); // 0x076a2a5c
	static System.Void HotfixTableByKey(SimpleJSON.JSONNode hotfix, System.String key); // 0x076a5714
}

// Client.Runtime
class WizardGames.Soc.SocClient.MallUtils : System.Object
{
	
	static WizardGames.Soc.SocClient.MallItemAdapter ToAdapter(WizardGames.Soc.Common.Data.mall.OBJMall mallItem); // 0x076a58e8
	static WizardGames.Soc.SocClient.MallItemAdapter ToAdapter(WizardGames.Soc.Common.Data.mall.OBJRecharge rechargeItem); // 0x076a59a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrMall : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Boolean enableDebugLog; // 0x11
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.mall.OBJHotSale> allHotSales; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.mall.OBJMallGacha> allGachas; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.mall.OBJBundle> allBundles; // 0x28
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.mall.MallShelfType,System.Collections.Generic.List<WizardGames.Soc.SocClient.MallItemAdapter>> allMallItems; // 0x30
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.mall.MallShelfType,System.Collections.Generic.List<WizardGames.Soc.SocClient.MallItemAdapter>> shelfSplitMallItems; // 0x38
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.MallItemAdapter> cfgId2AdapterDic; // 0x40
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.MallItemAdapter> resId2AdapterDic; // 0x48
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> tempSoldOutRec; // 0x50
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.HashSet<System.Int32>> bundleBuyInfos; // 0x58
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> mallItemBuyInfos; // 0x60
	System.Collections.Generic.Dictionary<System.String,System.Int32> propId2RechargeIdDic; // 0x68
	System.Collections.Generic.Dictionary<System.Int32,System.Single> lastBundleBuyTime; // 0x70
	System.Collections.Generic.Dictionary<System.Int32,System.Single> lastMallBuyTime; // 0x78
	System.Collections.Generic.List<System.String> listForRequest; // 0x80
	System.Int32 curBuyMallItemId; // 0x88
	System.Int32 curBuyBundleId; // 0x8c
	System.Int32 lastBuyBundleId; // 0x90
	System.Boolean isFromRewardPop; // 0x94
	System.Action OnResponseMallItemInfoExtCallback; // 0x98
	System.Action OnResponseBuyMallItemExtCallback; // 0xa0
	System.Collections.Generic.HashSet<System.String> hasPlayedFullScreenVideo; // 0xa8
	System.Int32 lastBuyMallItemShopId; // 0xb0
	System.Boolean isRequestCurrency; // 0xb4
	System.Action OnUpdateMallSkinShopComplete; // 0xb8
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Manager.CustomBannerData> customBanners; // 0xc0
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.mall.ENUMBuyLimitType,System.Int32> limitType2LanID; // 0xc8
	System.String curTimelineShowPath; // 0xd0
	UnityEngine.GameObject curTimelineShowGo; // 0xd8
	UnityEngine.Playables.PlayableDirector curTimelinePlayer; // 0xe0
	System.Boolean isShow; // 0xe8
	System.Boolean ActiveLotteryDrawRedDot(); // 0x076a5a60
	System.Boolean MallShopRedDot(); // 0x076a5cac
	System.Void Init(); // 0x055049cc
	System.Void InitData(); // 0x076a5d80
	System.Void Destroy(); // 0x055049cc
	System.Void AppendToShelfSplitData(WizardGames.Soc.Common.Data.mall.MallShelfType shelf, WizardGames.Soc.SocClient.MallItemAdapter adapter); // 0x076a64c4
	System.Void SplitMallItemsViaShelfType(); // 0x076a5de4
	WizardGames.Soc.SocClient.MallItemAdapter GetItemAdapterByCfgId(System.Int32 id); // 0x054e7c9c
	WizardGames.Soc.SocClient.MallItemAdapter GetItemAdapterByResId(System.Int32 id); // 0x054e7c9c
	System.Void OnAccountLogout(); // 0x076a67c0
	System.Void OnAccountEnterLobby(); // 0x055049cc
	System.Void PullBundleBuyInfo(System.Action callback); // 0x076a6ab0
	System.Void ClearAllCache(); // 0x076a6824
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.mall.OBJHotSale> GetAllActiveHotSales(); // 0x054e7844
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.mall.OBJMallGacha> GetAllActiceGachas(System.Boolean onlyShow); // 0x054f9d40
	System.Collections.Generic.List<System.Int32> GetAllActiveLotteryIds(); // 0x054e7844
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.mall.OBJBundle> GetAllActiveBundles(); // 0x054e7844
	System.Collections.Generic.List<WizardGames.Soc.SocClient.MallItemAdapter> GetAllActiveMallItems(WizardGames.Soc.Common.Data.mall.MallShelfType shelf); // 0x054e7c9c
	System.Boolean GetRemainTimeDesc(System.TimeSpan offset, System.String& desc); // 0x076a8bec
	System.Boolean GetRemainTimeDesc(System.String serverTimeStr, System.String& desc); // 0x076a8d44
	System.Void GetBundlePrices(WizardGames.Soc.Common.Data.mall.OBJBundle bundle, System.Int32& originPrice, System.Int32& curPrice); // 0x076a8e74
	System.Boolean IsBundleSoldOut(WizardGames.Soc.Common.Data.mall.OBJBundle bundle); // 0x076a911c
	System.Boolean IsBundleItemSoldOut(WizardGames.Soc.Common.Data.mall.OBJBundle bundle, System.Int32 sellGoodId); // 0x076a92fc
	System.Boolean IsInBuyRequestCD(System.Int32 id, System.Boolean isBundle, System.Boolean showTips); // 0x076a93fc
	System.Void UpdateBuyRequestCD(System.Int32 id, System.Boolean isBundle); // 0x076a9640
	System.Void RequestBuyBundle(System.Int32 bundleId, System.Int32 sellGoodsId); // 0x055057d4
	System.Void OnResponseBuyBundle(SimpleJSON.JSONNode ret); // 0x076a9a64
	System.Void RequestBundleBuyInfo(System.Collections.Generic.List<System.String> bundleIds, System.Action callback); // 0x076a715c
	System.Void RequestBundleBuyInfo(System.Int32 bundleID, System.Boolean isFromRewardPop); // 0x076a9d20
	System.Void OnResposeBundleBuyInfo(SimpleJSON.JSONNode ret); // 0x05523a54
	System.Void RequestMallItemInfo(System.Action callback); // 0x076aa6cc
	System.Void OnResponseMallItemInfo(SimpleJSON.JSONNode ret); // 0x076aa8d0
	System.Void RequestBuyMallItem(System.Int32 mallId, System.Int32 num, System.Action successCall, System.Action<SimpleJSON.JSONNode> faildCall); // 0x05507058
	System.Void OnResponseBuyMallItem(SimpleJSON.JSONNode ret); // 0x076ab490
	System.Int32 GetMallItemLimitBuyCount(WizardGames.Soc.SocClient.MallItemAdapter mallItem); // 0x076ab7d4
	System.Boolean HasMallItemPurchaseCondition(WizardGames.Soc.Common.Data.mall.OBJMall mallItem, WizardGames.Soc.Common.Data.mall.ENUMConditionType& conditionType, System.String& conditionStr); // 0x076ab8dc
	System.String GetMallItemConditionDesc(WizardGames.Soc.Common.Data.mall.OBJMall mallItem); // 0x076ab9c8
	System.Boolean CheckPurchaseConditionValid(WizardGames.Soc.Common.Data.mall.OBJMall mallItem); // 0x076abd34
	System.Boolean HasMultiCurrencyCost(WizardGames.Soc.Common.Data.mall.OBJMall mallItem, System.Collections.Generic.List<System.Tuple<System.Int32,System.Int32>>& costList); // 0x076abf4c
	System.Void GetMallItemLimitBuyInfo(WizardGames.Soc.SocClient.MallItemAdapter mallItem, System.Boolean& isLimit, System.Boolean& showLimit, System.String& prefix); // 0x076ac2e0
	System.Boolean IsMallItemSoldOut(WizardGames.Soc.SocClient.MallItemAdapter mallItem); // 0x076a8abc
	System.Boolean TryGetMallItemDiscount(WizardGames.Soc.SocClient.MallItemAdapter adapter, System.Int32& discountInPercent); // 0x076ac5c0
	System.Void AppendToPlayedFullScreenVideo(System.String videoName); // 0x076ac8f8
	System.Boolean HasPlayedFullScreenVideo(System.String videoName); // 0x076ac9e8
	System.Int32 GetCurBuyBundleId(); // 0x076aca90
	System.Void RegisterCustomBanner(WizardGames.Soc.SocClient.Manager.CustomBannerData data, System.Boolean modify); // 0x076acaf4
	System.Void UnregisterCustomBanner(System.String name); // 0x076acc74
	System.Collections.Generic.Dictionary.ValueCollection<System.String,WizardGames.Soc.SocClient.Manager.CustomBannerData> GetAllCustomBanners(); // 0x076acd8c
	WizardGames.Soc.SocClient.ECurrencyEnoughType IsEnoughCurrency(System.Int32 currencyId1, System.Int32 needNum1, System.Int32 currencyId2, System.Int32 needNum2); // 0x076ace18
	System.Void GetMallSkinStatus(System.Int32 skinID); // 0x055056e8
	System.Void ShowTimeline(System.String path, System.Action onShow); // 0x0552af00
	System.Void HideTimeline(); // 0x076ae270
	System.Void ReleaseTimeline(); // 0x076ae0e0
	System.Void .ctor(); // 0x076ae368
	static System.Void .cctor(); // 0x076ae5e4
	System.Int32 <GetAllActiveMallItems>b__45_0(WizardGames.Soc.SocClient.MallItemAdapter a, WizardGames.Soc.SocClient.MallItemAdapter b); // 0x054a3b30
	System.Void <OnResposeBundleBuyInfo>b__57_0(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrMall.<>c : System.Object
{
	static WizardGames.Soc.SocClient.MgrMall.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.Data.mall.OBJHotSale> <>9__41_0; // 0x8
	static System.Comparison<WizardGames.Soc.Common.Data.mall.OBJMallGacha> <>9__42_0; // 0x10
	static System.Comparison<System.Int32> <>9__43_0; // 0x18
	static System.Comparison<WizardGames.Soc.Common.Data.mall.OBJBundle> <>9__44_0; // 0x20
	static System.Void .cctor(); // 0x076f33b4
	System.Void .ctor(); // 0x076f3418
	System.Int32 <GetAllActiveHotSales>b__41_0(WizardGames.Soc.Common.Data.mall.OBJHotSale a, WizardGames.Soc.Common.Data.mall.OBJHotSale b); // 0x054a3b30
	System.Int32 <GetAllActiceGachas>b__42_0(WizardGames.Soc.Common.Data.mall.OBJMallGacha a, WizardGames.Soc.Common.Data.mall.OBJMallGacha b); // 0x054a3b30
	System.Int32 <GetAllActiveLotteryIds>b__43_0(System.Int32 a, System.Int32 b); // 0x0548bebc
	System.Int32 <GetAllActiveBundles>b__44_0(WizardGames.Soc.Common.Data.mall.OBJBundle a, WizardGames.Soc.Common.Data.mall.OBJBundle b); // 0x054a3b30
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrMall.<>c__DisplayClass53_0 : System.Object
{
	WizardGames.Soc.SocClient.MgrMall <>4__this; // 0x10
	System.Int32 bundleId; // 0x18
	System.Int32 sellGoodsId; // 0x1c
	System.Void .ctor(); // 0x055049cc
	System.Void <RequestBuyBundle>b__0(System.Boolean result); // 0x05523a7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrMall.<>c__DisplayClass60_0 : System.Object
{
	WizardGames.Soc.SocClient.MgrMall <>4__this; // 0x10
	System.Int32 mallId; // 0x18
	System.Int32 num; // 0x1c
	System.Action successCall; // 0x20
	System.Action<SimpleJSON.JSONNode> faildCall; // 0x28
	System.Void .ctor(); // 0x055049cc
	System.Void <RequestBuyMallItem>b__0(System.Boolean result); // 0x05523a7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrMall.<>c__DisplayClass77_0 : System.Object
{
	WizardGames.Soc.SocClient.MgrMall <>4__this; // 0x10
	WizardGames.Soc.SocClient.MallItemAdapter adapter; // 0x18
	WizardGames.Soc.SocClient.MallSkinData mallSkinData; // 0x20
	System.Int32 skinID; // 0x28
	System.Predicate<WizardGames.Soc.Common.Data.mall.sellGood> <>9__2; // 0x30
	System.Void .ctor(); // 0x055049cc
	System.Void <GetMallSkinStatus>b__1(); // 0x055049cc
	System.Boolean <GetMallSkinStatus>b__0(WizardGames.Soc.Common.Data.mall.OBJBundle s); // 0x054dec74
	System.Boolean <GetMallSkinStatus>b__2(WizardGames.Soc.Common.Data.mall.sellGood g); // 0x054dec74
	System.Boolean <GetMallSkinStatus>b__3(WizardGames.Soc.Common.Data.mall.sellGood sg); // 0x054dec74
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrMall.<>c__DisplayClass77_1 : System.Object
{
	WizardGames.Soc.Common.Data.mall.OBJBundle bundleData; // 0x10
	WizardGames.Soc.SocClient.MgrMall.<>c__DisplayClass77_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x055049cc
	System.Void <GetMallSkinStatus>b__4(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrMall.<>c__DisplayClass82_0 : System.Object
{
	WizardGames.Soc.SocClient.MgrMall <>4__this; // 0x10
	System.Action onShow; // 0x18
	UnityEngine.Camera cam; // 0x20
	System.Void .ctor(); // 0x055049cc
	System.Void <ShowTimeline>b__0(UnityEngine.GameObject _, UnityEngine.GameObject _); // 0x0552af00
}

// Client.Runtime
class WizardGames.Soc.SocClient.MallItemAdapter : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	WizardGames.Soc.Common.Data.mall.OBJMall mallCfg; // 0x10
	WizardGames.Soc.Common.Data.mall.OBJRecharge rechargeCfg; // 0x18
	System.Int32 <ID>k__BackingField; // 0x20
	System.String <Name>k__BackingField; // 0x28
	System.String <Desc>k__BackingField; // 0x30
	System.String <Icon>k__BackingField; // 0x38
	System.Int32 <Sequence>k__BackingField; // 0x40
	System.Boolean <ShowBigger>k__BackingField; // 0x44
	System.Single <DiscountPrice>k__BackingField; // 0x48
	System.Single <OriginPrice>k__BackingField; // 0x4c
	System.Boolean <HasDiscount>k__BackingField; // 0x50
	System.String <ShowStartTime>k__BackingField; // 0x58
	System.String <SellStartTime>k__BackingField; // 0x60
	System.String <SellEndTime>k__BackingField; // 0x68
	System.Boolean <DirectBuy>k__BackingField; // 0x70
	WizardGames.Soc.Common.Data.mall.ENUMBuyLimitType <ResetLimitType>k__BackingField; // 0x74
	System.Int32 <LimitNum>k__BackingField; // 0x78
	System.String <DiscountStartTime>k__BackingField; // 0x80
	System.String <DiscountEndTime>k__BackingField; // 0x88
	System.Int32 <GetResourceID>k__BackingField; // 0x90
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.common.BTuple2> <Freebies>k__BackingField; // 0x98
	System.Int32 <ShowModel>k__BackingField; // 0xa0
	System.String <ShopLink>k__BackingField; // 0xa8
	System.String <LinButtonDesc>k__BackingField; // 0xb0
	System.Int32 <EnableMultiNum>k__BackingField; // 0xb8
	System.Int32 <UseNow>k__BackingField; // 0xbc
	System.Single <GoodsNum>k__BackingField; // 0xc0
	System.Int32 <ShopLevel>k__BackingField; // 0xc4
	System.Int32 get_ID(); // 0x076f45ac
	System.Void set_ID(System.Int32 value); // 0x076f4610
	System.String get_Name(); // 0x076f4688
	System.Void set_Name(System.String value); // 0x076f46ec
	System.String get_Desc(); // 0x076f476c
	System.Void set_Desc(System.String value); // 0x076f47d0
	System.String get_Icon(); // 0x076f4850
	System.Void set_Icon(System.String value); // 0x076f48b4
	System.Int32 get_Sequence(); // 0x076f4934
	System.Void set_Sequence(System.Int32 value); // 0x076f4998
	System.Boolean get_ShowBigger(); // 0x076f4a10
	System.Void set_ShowBigger(System.Boolean value); // 0x076f4a74
	System.Single get_DiscountPrice(); // 0x076f4af0
	System.Void set_DiscountPrice(System.Single value); // 0x076f4b54
	System.Single get_OriginPrice(); // 0x076f4bcc
	System.Void set_OriginPrice(System.Single value); // 0x076f4c30
	System.Boolean get_HasDiscount(); // 0x076f4ca8
	System.Void set_HasDiscount(System.Boolean value); // 0x076f4d0c
	System.String get_ShowStartTime(); // 0x076f4d88
	System.Void set_ShowStartTime(System.String value); // 0x076f4dec
	System.String get_SellStartTime(); // 0x076f4e6c
	System.Void set_SellStartTime(System.String value); // 0x076f4ed0
	System.String get_SellEndTime(); // 0x076f4f50
	System.Void set_SellEndTime(System.String value); // 0x076f4fb4
	System.Boolean get_DirectBuy(); // 0x076f5034
	System.Void set_DirectBuy(System.Boolean value); // 0x076f5098
	WizardGames.Soc.Common.Data.mall.ENUMBuyLimitType get_ResetLimitType(); // 0x076f5114
	System.Void set_ResetLimitType(WizardGames.Soc.Common.Data.mall.ENUMBuyLimitType value); // 0x076f5178
	System.Int32 get_LimitNum(); // 0x076f51f0
	System.Void set_LimitNum(System.Int32 value); // 0x076f5254
	System.String get_DiscountStartTime(); // 0x076f52cc
	System.Void set_DiscountStartTime(System.String value); // 0x076f5330
	System.String get_DiscountEndTime(); // 0x076f53b0
	System.Void set_DiscountEndTime(System.String value); // 0x076f5414
	System.Int32 get_GetResourceID(); // 0x076f5494
	System.Void set_GetResourceID(System.Int32 value); // 0x076f54f8
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.common.BTuple2> get_Freebies(); // 0x076f5570
	System.Void set_ShowModel(System.Int32 value); // 0x076f55d4
	System.Void set_ShopLink(System.String value); // 0x076f564c
	System.Void set_LinButtonDesc(System.String value); // 0x076f56cc
	System.Int32 get_EnableMultiNum(); // 0x076f574c
	System.Void set_EnableMultiNum(System.Int32 value); // 0x076f57b0
	System.Void set_UseNow(System.Int32 value); // 0x076f5828
	System.Single get_GoodsNum(); // 0x076f58a0
	System.Void set_GoodsNum(System.Single value); // 0x076f5904
	System.Int32 get_ShopLevel(); // 0x076f597c
	System.Void set_ShopLevel(System.Int32 value); // 0x076f59e0
	System.Boolean get_IsTokenPurchase(); // 0x076f5a58
	System.Boolean get_IsDirectPurchase(); // 0x076f5ac4
	System.Void Refresh(WizardGames.Soc.Common.Data.mall.OBJMall cfg); // 0x076f5b30
	System.Void Refresh(WizardGames.Soc.Common.Data.mall.OBJRecharge cfg); // 0x076f6584
	System.Void OnGet(); // 0x076f7028
	System.Void OnRelease(); // 0x076f7088
	System.Void OnDestroy(); // 0x076f7a74
	System.Void .ctor(); // 0x076f7ad4
}

// Client.Runtime
class WizardGames.Soc.SocClient.MallSkinData : System.Object
{
	System.Int32 SkinID; // 0x10
	System.Int32 SellGoodId; // 0x14
	System.Int32 CurrencyConstId; // 0x18
	System.Single OriginalPrice; // 0x1c
	System.Single Price; // 0x20
	System.Int32 ShopID; // 0x24
	System.Int32 BuyNum; // 0x28
	WizardGames.Soc.SocClient.EMallSKinStatus Status; // 0x2c
	WizardGames.Soc.SocClient.EMallShopType mallShopType; // 0x30
	System.String ProbID; // 0x38
	WizardGames.Soc.SocClient.EMallCostType CostType; // 0x40
	System.Collections.Generic.List<System.Tuple<System.Int32,System.Int32>> CostList; // 0x48
	System.Int32[] JumpId; // 0x50
	System.Boolean get_HasDiscount(); // 0x076f7b88
	System.String get_CurrencyIcon(); // 0x076f7c08
	System.Void .ctor(); // 0x076f7d00
}

// Client.Runtime
enum WizardGames.Soc.SocClient.EMallSKinStatus : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.EMallSKinStatus None = 0;
	static WizardGames.Soc.SocClient.EMallSKinStatus IsLimitTime = 1;
	static WizardGames.Soc.SocClient.EMallSKinStatus IsLimitCount = 2;
	static WizardGames.Soc.SocClient.EMallSKinStatus IsLimitCondition = 3;
	static WizardGames.Soc.SocClient.EMallSKinStatus CanBuy = 4;
	static WizardGames.Soc.SocClient.EMallSKinStatus CanJump = 5;
	static WizardGames.Soc.SocClient.EMallSKinStatus InValid = 6;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.EMallShopType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.EMallShopType None = 0;
	static WizardGames.Soc.SocClient.EMallShopType ShopItem = 1;
	static WizardGames.Soc.SocClient.EMallShopType BundleItem = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.EMallCostType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.EMallCostType None = 0;
	static WizardGames.Soc.SocClient.EMallCostType SingleCurrency = 1;
	static WizardGames.Soc.SocClient.EMallCostType MultiCurrency = 2;
	static WizardGames.Soc.SocClient.EMallCostType Cash = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.ECurrencyEnoughType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.ECurrencyEnoughType Enough = 0;
	static WizardGames.Soc.SocClient.ECurrencyEnoughType CurrencyOne_NotEnough = 1;
	static WizardGames.Soc.SocClient.ECurrencyEnoughType CurrencyTwo_NotEnough = 2;
	static WizardGames.Soc.SocClient.ECurrencyEnoughType Both_NotEnough = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.EBpGrade : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.EBpGrade Free = 0;
	static WizardGames.Soc.SocClient.EBpGrade Premium = 1;
	static WizardGames.Soc.SocClient.EBpGrade Collector = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrBattlePass : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.OBJBattlePassLevelReward> curBpAllRwds; // 0x18
	WizardGames.Soc.SocClient.MgrBattlePass.BpUserData curBpUserData; // 0x20
	System.Tuple<System.Int32,System.Int32> waitForLvUpPopup; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.ReleaseElements> emptyResList; // 0x30
	System.Collections.Generic.HashSet<System.Int32> hasBoughtLvPackIds; // 0x38
	System.Boolean <InInfoRequest>k__BackingField; // 0x40
	System.Boolean IsBuyingLevel; // 0x41
	System.Boolean isRequestCurrency; // 0x42
	System.Boolean get_InInfoRequest(); // 0x076f7d9c
	System.Void set_InInfoRequest(System.Boolean value); // 0x076f7e00
	System.Int32 get_BattlePassID(); // 0x076f7e7c
	WizardGames.Soc.SocClient.EBpGrade get_Grade(); // 0x076f7ef0
	System.Int32 get_Level(); // 0x076f7f64
	System.Int32 get_Exp(); // 0x076f7fd8
	System.Int32 get_ExpWeekAmount(); // 0x076f804c
	System.Void OnAccountLogout(); // 0x055049cc
	WizardGames.Soc.Common.Data.Play.OBJBattlePassBasicInfo GetCurActiveBP(); // 0x076f81d0
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.OBJBattlePassLevelReward> GetCurBpAllRwds(); // 0x076f844c
	System.Void GetResListOfLvRwd(WizardGames.Soc.Common.Data.Play.OBJBattlePassLevelReward rwd, System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.ReleaseElements>& freeItems, System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.ReleaseElements>& payItems); // 0x076f8770
	System.Boolean IsCurLvReceived(System.Int32 lv); // 0x076f8974
	System.Boolean HasRewardToReceive(); // 0x076f8a74
	System.Void UpdateRewardLevelsInfo(SimpleJSON.JSONNode mapNode); // 0x076f8cbc
	System.Void HandleErrorCode(SimpleJSON.JSONNode ret); // 0x076f8ea8
	System.Boolean CheckBuyLevelNextFlow(); // 0x076f925c
	System.Boolean CheckLevelUpPopup(System.Int32 oldLv, System.Int64 oldExp); // 0x076f9344
	System.Void RefreshBpRedDotSteate(); // 0x076f94d0
	System.Void RequestBattlePassInfo(); // 0x055049cc
	System.Void OnResponseBattlePassInfo(SimpleJSON.JSONNode ret); // 0x076f9578
	System.Void RequestReceiveReward(System.Int32 lv); // 0x076f999c
	System.Void OnResponseReceiveReward(SimpleJSON.JSONNode ret); // 0x076f9c80
	System.Void OnPushBattlePassInfoChange(SimpleJSON.JSONNode push); // 0x076f9e1c
	System.Void AppendToHasBoughtLvPackId(System.Int32 id); // 0x076fa2f4
	System.Boolean CheckHasBoughtLvPackId(System.Int32 id); // 0x076fa3e4
	System.Void RequestAllcurrency(); // 0x055049cc
	System.Void .ctor(); // 0x076fa48c
	System.Void <RequestBattlePassInfo>b__35_0(SimpleJSON.JSONNode ret); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrBattlePass.BpUserData : System.Object
{
	System.Int32 BattlePassID; // 0x10
	System.Int32 Grade; // 0x14
	System.Int32 Level; // 0x18
	System.Int32 Exp; // 0x1c
	System.Int32 RewardAllReceivedLevel; // 0x20
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> RewardReceivedLevels; // 0x28
	System.Int32 ExpWeekAmount; // 0x30
	System.Void .ctor(); // 0x076f9934
}

// Client.Runtime
enum WizardGames.Soc.SocClient.EShareScene : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.EShareScene Invite = 1;
	static WizardGames.Soc.SocClient.EShareScene PlayTogetherInvite = 2;
	static WizardGames.Soc.SocClient.EShareScene PlayTogetherRecall = 3;
	static WizardGames.Soc.SocClient.EShareScene TeamInvite = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrFriendShare : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.String shareImagePath; // 0x18
	System.Boolean isDiffAccount; // 0x20
	System.Action<System.Int32> OnShareSuccessAction; // 0x28
	System.Void Init(); // 0x076fa60c
	System.Void CleanUp(); // 0x076fa770
	System.Void OnAccountEnterLobby(); // 0x076fa8d4
	System.Void OnFriendRetEvent(System.String baseRetJson); // 0x076fb2bc
	System.Void InformShareResToPandora(SimpleJSON.JSONNode baseRet); // 0x076fb6e8
	System.Void OnQuereyFriendEvent(System.String ret); // 0x076fbd78
	System.Void OnLoginWakeUp(System.String baseRetJson); // 0x076faa8c
	System.Void SetDiffAccount(); // 0x076fc7f8
	System.Boolean HandleDiffAccount(SimpleJSON.JSONNode baseRet); // 0x076fbee4
	System.Void RequestQQArkJson(WizardGames.Soc.SocClient.EShareScene sceneId, System.Action<SimpleJSON.JSONNode> successCallback, System.Action<SimpleJSON.JSONNode> errorCallback); // 0x076fc930
	System.Void CustomSendMessage(WizardGames.Soc.SDK.Adatper.SDKFriendReqType friendReqType, System.String openID, System.String title, System.String desc, System.String imagePath, System.String thumbPath, System.String mediaPath, System.String link, System.String extraJson); // 0x076fcec4
	System.Void SendImage(System.String imagePath, System.String openID); // 0x076fd0d8
	System.Void SendInvite(System.String title, System.String desc, System.String gameData, System.String extraJson, System.String openID, System.String link, WizardGames.Soc.SDK.Adatper.SDKFriendReqType friendReqType, WizardGames.Soc.SocClient.EShareScene sceneId); // 0x076fd270
	System.Void CustomShare(WizardGames.Soc.SDK.Adatper.SDKFriendReqType friendReqType, System.String openID, System.String title, System.String desc, System.String imagePath, System.String thumbPath, System.String mediaPath, System.String link, System.String extraJson); // 0x076fd70c
	System.Void ShareImage(System.String imagePath); // 0x076fd920
	UnityEngine.Texture2D CreateQRCode(System.String url, System.Int32 size); // 0x076fdaac
	System.String CreateDeeplink(System.Collections.Generic.Dictionary<System.String,System.String> parameters); // 0x076fdcf4
	System.Void .ctor(); // 0x076fe0c8
	static System.Void .cctor(); // 0x076fe15c
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrFriendShare.<>c : System.Object
{
	static WizardGames.Soc.SocClient.MgrFriendShare.<>c <>9; // 0x0
	static System.Action<SimpleJSON.JSONNode> <>9__17_1; // 0x8
	static System.Void .cctor(); // 0x076fe230
	System.Void .ctor(); // 0x076fe294
	System.Void <SendInvite>b__17_1(SimpleJSON.JSONNode error); // 0x076fe2fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrFriendShare.<>c__DisplayClass12_0 : System.Object
{
	System.Boolean diffAccount; // 0x10
	System.Void .ctor(); // 0x076fc860
	System.Void <HandleDiffAccount>b__0(); // 0x076fe3f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrFriendShare.<>c__DisplayClass12_1 : System.Object
{
	System.String plat; // 0x10
	System.Void .ctor(); // 0x076fc8c8
	System.Void <HandleDiffAccount>b__1(); // 0x076fe454
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrFriendShare.<>c__DisplayClass13_0 : System.Object
{
	System.Action<SimpleJSON.JSONNode> successCallback; // 0x10
	System.Action<SimpleJSON.JSONNode> errorCallback; // 0x18
	System.Void .ctor(); // 0x076fce5c
	System.Void <RequestQQArkJson>b__0(SimpleJSON.JSONNode result); // 0x076fe5e4
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrFriendShare.<>c__DisplayClass17_0 : System.Object
{
	System.String title; // 0x10
	System.String desc; // 0x18
	System.String gameData; // 0x20
	System.String openID; // 0x28
	System.String link; // 0x30
	System.Void .ctor(); // 0x076fd6a4
	System.Void <SendInvite>b__0(SimpleJSON.JSONNode arkJSON); // 0x076fe95c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.ESeasonPicBoxTipState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.ESeasonPicBoxTipState Team = 0;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.ESeasonFirstOpenTpye : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.ESeasonFirstOpenTpye Medal = 0;
	static WizardGames.Soc.SocClient.ESeasonFirstOpenTpye Lobby = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.SeasonTaskData : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	System.Int32 taskId; // 0x10
	System.Int64 curVal; // 0x18
	System.Int64 maxVal; // 0x20
	WizardGames.Soc.SocClient.EMainQuestMissionState state; // 0x28
	WizardGames.Soc.Common.Data.task.OBJTask taskCfg; // 0x30
	System.Int32 get_TaskId(); // 0x076feb0c
	System.Int64 get_CurVal(); // 0x076feb70
	System.Int64 get_MaxVal(); // 0x076febd4
	WizardGames.Soc.SocClient.EMainQuestMissionState get_State(); // 0x076fec38
	System.Void Refresh(System.Int32 taskId, System.Int32 state, System.Int64 curVal, System.Int64 maxVal); // 0x076fec9c
	System.Void OnGet(); // 0x076fee4c
	System.Void OnRelease(); // 0x076feeac
	System.Void OnDestroy(); // 0x076fef18
	System.Void .ctor(); // 0x076fef78
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrSeason : WizardGames.Soc.Common.Manager.MgrBase
{
	SocLogger logger; // 0x18
	static System.String SeasonSaveKey; // 0x0
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.ESeasonPicBoxTipState,System.Int32> seasonPicBoxTipMap; // 0x20
	System.Int32 currWeeklySeasonPoints; // 0x28
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.SeasonTaskData> seasonTaskDatas; // 0x30
	System.Collections.Generic.List<System.Int32> medalTaskIds; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.SeasonTaskData> seasonMedalDatas; // 0x40
	System.Int64 lastTimestamp; // 0x48
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.SeasonRankData> rankDataDic; // 0x50
	System.Collections.Generic.Dictionary<System.UInt64,WizardGames.Soc.SocClient.Ui.SeasonRankEquipItemData> equipItemDataDic; // 0x58
	System.Collections.Generic.Dictionary<System.UInt64,WizardGames.Soc.SocClient.Ui.SeasonRankAppearanceData> appearanceDataDic; // 0x60
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RewardData> tempRewardDataList; // 0x68
	System.Int32 get_SeasonId(); // 0x076fefe8
	System.Int32 get_SeasonPoints(); // 0x076ff0c0
	System.String get_CurrentSeasonName(); // 0x076ff164
	System.String get_CurrentRankName(); // 0x076ff298
	System.Int32 get_CurrRankId(); // 0x076ff3cc
	System.Int32 get_CurrLargeRankId(); // 0x076ff5b8
	System.Int32 get_CurrSeasonHistoryMaxLargeRankId(); // 0x076ff7a4
	System.Boolean get_IsSeasonLastDay(); // 0x076ffe00
	System.Void OnAccountLogout(); // 0x076fffc8
	System.Void CleanUp(); // 0x077000ac
	System.String GetSeasonTimeDesc(); // 0x0770011c
	WizardGames.Soc.Common.Data.Play.OBJSeasonRank GetSeasonRankId(System.Int32 point); // 0x07700698
	WizardGames.Soc.Common.Data.Play.OBJSeasonLargeRank GetSeasonLargeRankId(System.Int32 point); // 0x07700828
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.ReleaseElements> GetResListOfRankSeasonRwd(System.Int32 largeRankId, System.String& showImgUri); // 0x077009b8
	System.Boolean HaveRankReward(); // 0x07700b8c
	System.Boolean HaveLargeRankReward(System.Int32 largeRankId); // 0x07700d6c
	System.Boolean HaveMedalReward(); // 0x07700e90
	System.Void GetResListOfRankRwd(System.Int32 largeRankId, System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.ReleaseElements>& reward, WizardGames.Soc.Common.Data.task.OBJTask& taskCfg); // 0x077010a8
	System.Int32 get_CurrShowMedalTaskId(); // 0x07701390
	System.Boolean IsSeasonFirstOpen(WizardGames.Soc.SocClient.ESeasonFirstOpenTpye openTpye, System.Boolean saveState); // 0x077015d8
	System.Int32 get_SeasonTaskGroupId(); // 0x077017c0
	System.Int32 get_SeasonMedalTaskGroupId(); // 0x077018c8
	System.Void ClearSeasonTask(); // 0x077019d0
	WizardGames.Soc.SocClient.EMainQuestMissionState GetLargeRankSeasonTaskState(System.Int32 largeRankId, WizardGames.Soc.Common.Data.task.OBJTask& taskCfg); // 0x076ff92c
	WizardGames.Soc.SocClient.SeasonTaskData GetSeasonTaskData(System.Int32 taskId); // 0x07701bb0
	System.Void ClearMedalTask(); // 0x07701c64
	WizardGames.Soc.SocClient.SeasonTaskData GetMedalTaskData(System.Int32 taskId); // 0x07701524
	System.Collections.Generic.List<System.Int32> GetMedalTaskIds(); // 0x07701e44
	System.Void InitMedalTaskIds(); // 0x07701ea8
	System.Void TryRequestLobbySeasonTask(System.Action successCb); // 0x0770207c
	System.Void RequestReceiveReward(System.Int32 groupId, System.Int32 taskId, System.Action callback); // 0x07702418
	System.Void RequestSeasonPointsCounterInfo(); // 0x077027e4
	System.Void OnResponseSeasonPointsCounterInfo(SimpleJSON.JSONNode ret); // 0x07702b08
	System.Void HandleErrorCode(SimpleJSON.JSONNode ret); // 0x07702db8
	System.Int64 get_clearDataTime(); // 0x07702f2c
	System.Void CheckClearSeasonRank(); // 0x0770301c
	System.Void ClearSeasonRank(); // 0x07700038
	System.Void ClearSeasonRankInfo(); // 0x077030d0
	System.Void RequestSeasonRankInfo(System.String boardName, System.Int32 startIndex, System.Int32 stopIndex, WizardGames.Soc.SocClient.Ui.ERefreshDataReason refreshDataReason); // 0x07703694
	System.Void RequestSeasonRankFriendSeasonPointInfo(System.String boardName, WizardGames.Soc.SocClient.Ui.ERefreshDataReason refreshDataReason); // 0x07703c70
	System.Void ClearSeasonRankEquipInfo(); // 0x07703284
	System.Void RequestSeasonRankEquipInfo(System.UInt64 roleId, System.Action<WizardGames.Soc.SocClient.Ui.SeasonRankEquipItemData> callback); // 0x07703ec4
	System.Void ClearSeasonRankAppearanceInfo(); // 0x0770348c
	System.Void RequestUserInfo(System.UInt64 roleId, System.Action<WizardGames.Soc.SocClient.Ui.SeasonRankAppearanceData> callback); // 0x07704270
	System.Void OnPushSeasonLevelChange(SimpleJSON.JSONNode push); // 0x0770453c
	System.Void .ctor(); // 0x07704784
	static System.Void .cctor(); // 0x07704af0
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrSeason.<>c : System.Object
{
	static WizardGames.Soc.SocClient.MgrSeason.<>c <>9; // 0x0
	static System.Action<SimpleJSON.JSONNode> <>9__57_1; // 0x8
	static System.Void .cctor(); // 0x07704b58
	System.Void .ctor(); // 0x07704bbc
	System.Void <RequestReceiveReward>b__57_1(SimpleJSON.JSONNode errorNode); // 0x07704c24
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrSeason.<>c__DisplayClass56_0 : System.Object
{
	WizardGames.Soc.SocClient.MgrSeason <>4__this; // 0x10
	System.Action successCb; // 0x18
	System.Void .ctor(); // 0x077023b0
	System.Void <TryRequestLobbySeasonTask>b__0(SimpleJSON.JSONNode ret); // 0x07704c98
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrSeason.<>c__DisplayClass57_0 : System.Object
{
	WizardGames.Soc.SocClient.MgrSeason <>4__this; // 0x10
	System.Action callback; // 0x18
	System.Void .ctor(); // 0x0770277c
	System.Void <RequestReceiveReward>b__0(SimpleJSON.JSONNode ret); // 0x077054b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrSeason.<>c__DisplayClass68_0 : System.Object
{
	WizardGames.Soc.SocClient.MgrSeason <>4__this; // 0x10
	System.String boardName; // 0x18
	WizardGames.Soc.SocClient.Ui.ERefreshDataReason refreshDataReason; // 0x20
	System.Void .ctor(); // 0x07703c08
	System.Void <RequestSeasonRankInfo>b__0(SimpleJSON.JSONNode ret); // 0x07705560
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrSeason.<>c__DisplayClass72_0 : System.Object
{
	WizardGames.Soc.SocClient.MgrSeason <>4__this; // 0x10
	System.UInt64 roleId; // 0x18
	System.Action<WizardGames.Soc.SocClient.Ui.SeasonRankEquipItemData> callback; // 0x20
	System.Void .ctor(); // 0x07704208
	System.Void <RequestSeasonRankEquipInfo>b__0(SimpleJSON.JSONNode ret); // 0x077057c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrSeason.<>c__DisplayClass75_0 : System.Object
{
	System.UInt64 roleId; // 0x10
	WizardGames.Soc.SocClient.MgrSeason <>4__this; // 0x18
	System.Action<WizardGames.Soc.SocClient.Ui.SeasonRankAppearanceData> callback; // 0x20
	System.Void .ctor(); // 0x077044d4
	System.Void <RequestUserInfo>b__0(SimpleJSON.JSONArray retArray); // 0x077059e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrMission : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	static System.Int64[] interestedPoiTaskTypes; // 0x8
	System.Int64 oldMissionId; // 0x18
	System.Collections.Generic.List<System.Int64> dailyMissionIdsLst; // 0x20
	System.Collections.Generic.List<System.Int64> inProgressDailyMissionLst; // 0x28
	System.Collections.Generic.List<System.Int64> notGetRewardDailyMissionLst; // 0x30
	System.Collections.Generic.List<System.Int64> completedDailyMissionLst; // 0x38
	System.Collections.Generic.List<System.Int64> inProgressDailyMissionRewardLst; // 0x40
	System.Collections.Generic.List<System.Int64> notGetRewardDailyMissionRewardLst; // 0x48
	System.Collections.Generic.List<System.Int64> completedDailyMissionRewardLst; // 0x50
	System.Collections.Generic.List<System.Int64> tempScoreLst; // 0x58
	System.Collections.Generic.List<WizardGames.Soc.SocClient.DeadSheepMissionData> DeadSheepMissionList; // 0x60
	WizardGames.Soc.SocClient.DeadSheepMissionData[] deadSheepMissionPool; // 0x68
	System.Collections.Generic.List<System.Int64> rewardBoxTaskIds; // 0x70
	System.Collections.Generic.List<System.Int64> treasureTaskIds; // 0x78
	System.Int64 boxTaskSelectId; // 0x80
	System.Collections.Generic.Dictionary<System.Int32,System.Int64> pointTaskIdsDic; // 0x88
	System.Int64 selectId; // 0x90
	System.Int64 interactionEntityId; // 0x98
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> id2FactionDic; // 0xa0
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> sub2MainDic; // 0xa8
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> faction2MaxLevelDic; // 0xb0
	System.Collections.Generic.List<System.Int32> factionLst; // 0xb8
	System.Collections.Generic.Dictionary<System.Int32,System.UInt32> faction2LevelDic; // 0xc0
	System.Collections.Generic.Dictionary<System.Int32,System.UInt32> faction2ExpDic; // 0xc8
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.MainQuestData> inProgressMainQuestMissionDic; // 0xd0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.MainQuestData> notGetRewardMainQuestMissionDic; // 0xd8
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.MainQuestData> completedMainQuestMissionDic; // 0xe0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.MainQuestData> lockMainQuestMissionDic; // 0xe8
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.MainQuestData> invalidMainQuestMissionDic; // 0xf0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.MainQuestData> lobbyInGameMainQuestMissionDic; // 0xf8
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.MainQuestData> roundMainQuestMissionDic; // 0x100
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.MainQuestData> lockRoundMainQuestMissionDic; // 0x108
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>> levelUnlockMainQuestDic; // 0x110
	System.Collections.Generic.List<WizardGames.Soc.SocClient.MainQuestData> tempMainQuestMissionLst; // 0x118
	System.Collections.Generic.List<WizardGames.Soc.SocClient.MainQuestData> traceMainQusetMissionLst; // 0x120
	System.Collections.Generic.List<System.Int64> toRemoveLst; // 0x128
	System.Int32 <LastStage>k__BackingField; // 0x130
	System.Collections.Generic.List<WizardGames.Soc.SocClient.MainQuestData> LastMainQuest; // 0x138
	System.Boolean <RewardReceive>k__BackingField; // 0x140
	System.Int64 <LastSurvivalMissionShowId>k__BackingField; // 0x148
	static System.Boolean waitGuideFinishTraining; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.MainQuestData> tempFactionLst; // 0x150
	System.Boolean <IsSkipNewbieAction>k__BackingField; // 0x158
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.MonumentMissionRemoteData>> monumentMissionDataDic; // 0x160
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> taskId2GroupIdDic; // 0x168
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> groupId2MonumentId; // 0x170
	System.Int32 <monumentTrackGroupId>k__BackingField; // 0x178
	System.Int32 <monumentTrackTaskId>k__BackingField; // 0x17c
	System.Int32 monumentTypeId; // 0x180
	WizardGames.Soc.SocClient.NewbieMissionRemoteData <NewbieRemoteData>k__BackingField; // 0x188
	WizardGames.Soc.SocClient.NewbieMissionLocalData NewbieLocalData; // 0x190
	System.Collections.Generic.List<System.Int64> taskPath; // 0x198
	System.Collections.Generic.List<System.Int64> searchLst; // 0x1a0
	System.Int32[] newbieInfoTask; // 0x1a8
	System.Collections.Generic.HashSet<System.String> tempGuideItemLst; // 0x1b0
	System.Int64 hideMissionId; // 0x1b8
	System.Int64 storyModeMissionId; // 0x1c0
	System.Boolean inStory; // 0x1c8
	System.Boolean isStoryMode; // 0x1c9
	System.Boolean finishGuideWhenClickScreen; // 0x1ca
	System.Int32 finishGuideIdWhenClickScreen; // 0x1cc
	System.Int32 NewBieLevelTaskId; // 0x1d0
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.HashSet<System.Int32>> NewBieLevelMissionId2UnLockHudElemIds; // 0x1d8
	System.Collections.Generic.List<System.Int32> manualShowNodeOnStory; // 0x1e0
	System.Collections.Generic.HashSet<System.Int64> needShowTipTasks; // 0x1e8
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> treasureTimer; // 0x1f0
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> treasureEndTimer; // 0x1f8
	System.Int64 lastAcceptPoiTaskId; // 0x200
	static System.Void .cctor(); // 0x076aebec
	System.Void Init(); // 0x076aed2c
	System.Void OnAccountLogined(); // 0x076afb10
	System.Void OnAccountEnterLobby(); // 0x076afc14
	System.Threading.Tasks.Task OnEnterWorld(); // 0x076b037c
	System.Threading.Tasks.Task OnExitWorld(); // 0x076b145c
	System.Void OnAccountLogout(); // 0x076b232c
	System.Void CleanUp(); // 0x076b2450
	System.Void RefreshPointAndBoxTaskNotGetReward(); // 0x076b2868
	System.Void OnCreateOrUpdateMission(WizardGames.Soc.Common.CustomType.TaskNode task); // 0x076b3438
	System.Void OnClearMission(System.Boolean isNewBiew); // 0x076b3ef4
	System.Boolean GetTaskResult(System.Int64 taskId, System.Int64 subTaskId); // 0x076b4270
	System.Boolean GetTaskResult(System.Int64 taskId); // 0x076b5b68
	System.Int32 GetTaskCount(System.Int64 taskId, System.Boolean isNewbie); // 0x076b5fac
	System.Int32 GetTaskCount(System.Int64 taskId, System.Int64 subTaskId, System.Int32 type); // 0x076b4660
	System.Collections.Generic.List<System.Int64> GetTasksByType(System.Int64 index, WizardGames.Soc.Common.Data.MainTaskType taskType); // 0x076b61f4
	WizardGames.Soc.Common.CustomType.TaskNode GetTaskById(System.Int64 taskId, System.Int64 index, WizardGames.Soc.Common.Data.MainTaskType taskType); // 0x076b6658
	WizardGames.Soc.Common.CustomType.TaskNode GetTaskById(System.Int64 taskId, System.Int32 taskType); // 0x076b6928
	System.Void GetSortedPoiTasks(System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.PoiTaskNode> taskNodes); // 0x076b6c38
	System.Void GetTraceSortedPoiTasks(System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.PoiTaskNode> taskNodes); // 0x076b70b8
	System.Boolean PlayIdCheck(WizardGames.Soc.Common.Data.Play.MissionTab missionTabData); // 0x076b7574
	System.Void TryShowTrackTips(System.Int64 oldTrackId, System.Int64 newTrackId); // 0x076b76dc
	System.Void InitDailyTask(WizardGames.Soc.Common.CustomType.SystemRootNode systemRoot); // 0x076b7a0c
	System.Void RefreshInProgressDailyMission(); // 0x076b87ac
	System.Void RefreshNotGetRewardDailyMission(); // 0x076b8c94
	System.Void RefreshCompletedDailyMission(); // 0x076b9198
	System.Int32 HasDailyMissionReward(); // 0x076b96e8
	System.Void GetDailyMissionLstByType(WizardGames.Soc.Common.Data.DailyTaskType taskType, System.Collections.Generic.List<System.Int64>& lst); // 0x076b9790
	System.Void GetTraceDailyMissionLstByType(WizardGames.Soc.Common.Data.DailyTaskType taskType, System.Collections.Generic.List<System.Int64>& lst); // 0x076b9f1c
	System.Int32 GetTotalDailyMissionScore(); // 0x076ba438
	System.Int32 CompareRewardMission(System.Int64 a, System.Int64 b); // 0x076ba854
	System.Int32 CompareNormalMission(System.Int64 a, System.Int64 b); // 0x076ba9e0
	WizardGames.Soc.SocClient.EDailyMissionState GetNormalDailyMissionState(System.Int64 id); // 0x076bac18
	WizardGames.Soc.SocClient.EDailyMissionState GetMedalDailyMissionState(System.Int64 id); // 0x076ba768
	System.Boolean IsDailyMissionTracked(System.Int64 id); // 0x076bad04
	System.Boolean IsDailyMissionTracked(); // 0x076bae10
	System.Boolean get_ShowDeadSheepMission(); // 0x076baf34
	System.Void RefreshDeadSheepMissions(); // 0x076bb008
	System.Boolean IsGetReward(System.Int64 taskId, System.Int64 taskNodeIndex); // 0x076bb698
	System.Boolean IsCompleted(System.Int64 taskId); // 0x076bb8c4
	System.Int32 HasPointTaskReward(); // 0x076bbacc
	System.Boolean IsTaskInProgress(System.Int64 taskId); // 0x076bbd6c
	System.Collections.Generic.Dictionary<System.Int32,System.Int64> RefreshPointTaskIds(); // 0x076b326c
	System.Collections.Generic.List<System.Int64> SortListByStatus(System.Collections.Generic.List<System.Int64> list); // 0x076bbf90
	System.Collections.Generic.List<System.Int64> RefreshBoxRewardTaskIds(); // 0x076b29a4
	System.Int32 HasBoxTaskReward(); // 0x076bc078
	System.Boolean get_HasBoxTaskTracked(); // 0x076bc264
	System.Boolean HasBoxTask(System.Int64 id); // 0x076bc37c
	System.Boolean get_HasPointTaskTracked(); // 0x076bc424
	System.Boolean get_HasTreasuretTaskTracked(); // 0x076bc548
	System.Boolean get_IsBoxTaskUnlock(); // 0x076bc66c
	System.Int32 GetPointTaskCompetedNum(); // 0x076bc774
	System.Collections.Generic.List<System.Int64> RefreshTreasureTaskIds(); // 0x076b3968
	System.Void ShowBurWeaponTaskInteraction(System.Int64 id, System.Int64 interactionEntityId); // 0x076bc7d8
	System.Void BurWeaponFinished(); // 0x076bc960
	System.Int32 get_LastStage(); // 0x076bcaac
	System.Void set_LastStage(System.Int32 value); // 0x076bcb10
	System.Boolean get_RewardReceive(); // 0x076bcb88
	System.Void set_RewardReceive(System.Boolean value); // 0x076bcbec
	System.Int64 get_LastSurvivalMissionShowId(); // 0x076bcc68
	System.Void set_LastSurvivalMissionShowId(System.Int64 value); // 0x076bcccc
	static System.Boolean get_WaitGuideFinishTraining(); // 0x076bcd44
	static System.Void set_WaitGuideFinishTraining(System.Boolean value); // 0x076b224c
	System.Void InitMainQuest(WizardGames.Soc.Common.CustomType.SystemRootNode systemRoot); // 0x076bcdcc
	System.Boolean get_IsMainQuestTracked(); // 0x076c02d4
	System.Boolean IsMainQuestFactionTracked(System.Int32 factionId); // 0x076c0418
	System.Int64 GetMainQuestTrackIdByFaction(System.Int32 factionId); // 0x076c05a0
	System.Int32 GetNotGetRewardAndCompeleteMainQuestByFaction(System.Int32 factionId); // 0x076c12b8
	System.Boolean GetTrackFactionId(System.Int32& factionId); // 0x076c1758
	System.Void RefreshSingleFactionMission(System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.MainQuestData> dic, System.Int64 taskId, System.Int32 state); // 0x076be630
	System.Void RefreshInProgressMainQuestMission(); // 0x076c18cc
	System.Void RefreshNotGetRewardMainQuestMission(); // 0x076c2108
	System.Void RefreshCompletedMainQuestMission(); // 0x076c2938
	System.Void RefreshInvalidMainQuestMission(); // 0x076c3090
	System.Void RefreshMainQuestTableInfo(); // 0x076af234
	System.Void GetFactionMissionLst(System.Int32 faction, System.Collections.Generic.List<WizardGames.Soc.SocClient.MainQuestData>& missionLst); // 0x076c06d0
	System.Void GetTrackMainQuestMissionLst(System.Int32 faction, System.Collections.Generic.List<WizardGames.Soc.SocClient.MainQuestData>& missionLst); // 0x076c3778
	System.Void GetInProgressFactionMissionLst(System.Int32 faction, System.Collections.Generic.List<WizardGames.Soc.SocClient.MainQuestData>& missionLst); // 0x076c3ed4
	System.Void RefreshMainQuestRoundMission(); // 0x076be894
	System.Void RefreshMainQuestLockandLobbyMission(); // 0x076bf8cc
	System.Int32 SortMission(WizardGames.Soc.SocClient.MainQuestData a, WizardGames.Soc.SocClient.MainQuestData b); // 0x076c45fc
	System.Collections.Generic.List<System.Int32> GetSortedFactionLst(System.Boolean excludeWeekly); // 0x076c4850
	System.Int32 SortFaction(System.Int32 a, System.Int32 b); // 0x076c4c3c
	System.Boolean get_IsMainQuestUnlocked(); // 0x076c4de0
	System.UInt32 GetFactionLevel(System.Int32 id); // 0x076c50a4
	System.UInt32 GetFactionExp(System.Int32 id); // 0x076c5158
	System.Boolean IsFactionEntryUnlock(System.Int32 id); // 0x076c520c
	System.Int32 GetLevel(); // 0x076c44b0
	System.Int32 HasMainQuestFaction1RedDot(); // 0x076c5544
	System.Int32 HasMainQuestFaction2RedDot(); // 0x076c5738
	System.Int32 GetFaction(System.Int64 taskId); // 0x076c592c
	System.Boolean TryGetMainId(System.Int32 taskId, System.Int64& main); // 0x076c4554
	System.Int32 HasMainQuestFaction3RedDot(); // 0x076c5bc8
	System.Int32 HasMainQuestFaction4RedDot(); // 0x076c5e48
	WizardGames.Soc.SocClient.MainQuestData GetMainQuestDataById(System.Int32 id); // 0x076c14dc
	System.Void UnsubscribeMainQuestMission(); // 0x076b1ebc
	System.Void ClearMainQuestMission(); // 0x076b16d0
	System.Void RequestFactionLevel(System.Action successCb); // 0x076afcd4
	System.Void OnRecvMainQuestLevelAndExp(SimpleJSON.JSONNode ret); // 0x076c5ff4
	System.Void TryRequestLobbyMainQuestMission(System.Action successCb); // 0x076afeb8
	System.Void RequestLobbyGetMainQuestRewards(System.Int32 groupId, System.Int32 taskId, System.Action successCb); // 0x076c6200
	System.Void RequestReceiveAdvisorReward(); // 0x076c6558
	System.Boolean IsMainQuestTrainingFinished(System.Int32 id); // 0x076c6788
	System.Boolean IsMainQuestTrainingStart(System.Int32 id); // 0x076c53bc
	System.Int32 GetMainQuestTrainingStage(System.Int32 factionId); // 0x076c6a38
	System.Void RefreshMainQuestRedDotWhenChangeLevel(); // 0x076c6b60
	System.Void GetAllMainQuestIds(System.Collections.Generic.List<System.Int64>& lst); // 0x076c6cfc
	System.Void OnTrainingFinished(); // 0x076c6dd8
	System.Boolean get_IsSkipNewbieAction(); // 0x076c6eac
	System.Void set_IsSkipNewbieAction(System.Boolean value); // 0x076c6f10
	System.Void OnSkipNewbieAction(); // 0x076c6f8c
	System.Boolean get_IsTrainingEntryOpen(); // 0x076c70b0
	System.Boolean get_IsMainQuestMissionSwitchOn(); // 0x076c4eb4
	System.Int64[] GetFactionStageTasks(System.Int32 faction, System.Int32 stage); // 0x076c13c4
	System.Int32 GetFactionStageTaskCount(System.Int32 faction); // 0x076c7530
	System.Boolean IsFactionStageComplete(System.Int32 missionId, System.Int32& stage); // 0x076c773c
	System.Int32 GetFactionTipsId(System.Int32 factionId, System.Int32 stage); // 0x076c78d4
	System.Void OpenSurvivalBook(); // 0x076c79a0
	System.Int32 get_monumentTrackGroupId(); // 0x076c8520
	System.Void set_monumentTrackGroupId(System.Int32 value); // 0x076c8584
	System.Int32 get_monumentTrackTaskId(); // 0x076c85fc
	System.Void set_monumentTrackTaskId(System.Int32 value); // 0x076c8660
	System.Int32 MonumentTaskState(System.Int32 taskId, System.Int32 taskState); // 0x076c86d8
	WizardGames.Soc.SocClient.MonumentMissionRemoteData GetMonumentRemoteData(System.Int32 id); // 0x076c87c0
	System.Boolean get_HasMonumentTrackMission(); // 0x076c88ec
	System.Collections.Generic.List<WizardGames.Soc.SocClient.MonumentMissionRemoteData> GetTrackShowedMissions(); // 0x076c89dc
	System.Void InitDataFromMonumentTable(); // 0x076aeda4
	System.Void OnUpdateMonumentTypeId(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 a, System.Int32 b); // 0x076c905c
	System.Void TrackMonumentTask(System.Int32 taskID); // 0x076c94f4
	System.Void UpdateMonumentTrackInfo(System.Int32 groupId, System.Int32 taskId); // 0x076c96f0
	System.Void ClearMonumentCache(); // 0x076b253c
	System.Void UpdateMonumentMissionState(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.MonumentTaskState> taskStateList); // 0x076c9844
	System.Boolean get_AllMonumentTaskFinished(); // 0x076c8c5c
	System.Void OnMonumentTypeIdChanged(); // 0x076c9258
	System.Void RequestMonumentTaskState(System.Collections.Generic.List<System.Int32> taskGroupIds); // 0x076c9f5c
	System.Void SubscriptionMonumentTasksGroup(System.Collections.Generic.List<System.Int32> taskGroupIds); // 0x076c9e48
	System.Void UnSubscriptionMonumentTasksGroup(System.Collections.Generic.List<System.Int32> taskGroupIds); // 0x076c9d34
	WizardGames.Soc.SocClient.NewbieMissionRemoteData get_NewbieRemoteData(); // 0x076ca070
	System.Void set_NewbieRemoteData(WizardGames.Soc.SocClient.NewbieMissionRemoteData value); // 0x076ca0d4
	System.Boolean get_HasMission(); // 0x076b5efc
	System.Int32 get_newbieTaskId(); // 0x076ca154
	System.Boolean get_IsNewbieTracked(); // 0x076ca408
	System.Collections.Generic.List<System.Int64> GetCurPhaseTasks(); // 0x076ca570
	System.Collections.Generic.List<System.Int64> GetSearchLst(); // 0x076ca690
	System.Void InitNewbieLocalData(); // 0x076b1028
	System.Int32 GetNewbieMissionProgress(System.Int64 taskId); // 0x076cabc4
	System.Boolean IsTrackItem(System.Int32 queryId, System.Int32 combaId, System.Int32 grade); // 0x076caf28
	System.Void RequestTrack(System.Int32 id); // 0x076cb718
	System.Void RequestTrigger(System.Int32 id); // 0x076cb888
	System.Void RequestCancelTrack(System.Int32 id); // 0x076cb968
	System.Boolean HasSelectedItem(System.Int32[]& bpIds); // 0x076cbac0
	System.Boolean IsTrackCraftFirstTab(System.Int32 firstTabId); // 0x076cbdd4
	System.Boolean IsTrackCraftSecondTab(System.Int32 secondTabId); // 0x076cc40c
	System.Boolean IsTrackTechTreeFirstTab(System.Int32 firstTabId); // 0x076cca6c
	System.Boolean IsTrackTechTreeSecondTab(System.Int32 secondTabId); // 0x076cd064
	System.Boolean HasSelectedRecipe(System.Int32[]& recipeDataIds); // 0x076cd668
	System.Void FinishSelectItem(System.Int64 missionId); // 0x076cd9a4
	System.Boolean TryGuideIfHasMisson(System.Int32 guideId, System.Int32 stepId); // 0x076cdb48
	System.Boolean get_IsStoryMode(); // 0x076cdd34
	System.Void TryFinishGuideWhenClickScreen(); // 0x076cdd98
	System.Void ResetClickScreenState(); // 0x076cdfc4
	System.Void HideElemsOnStory(); // 0x076ce030
	System.Void RecoverElemsOnStory(); // 0x076ce1b8
	System.Void EnterStoryMode(); // 0x076ce2e8
	System.Void ExitStoryMode(); // 0x076ce470
	System.Boolean CheckVisibleOnStory(System.Int32 id); // 0x076ce578
	System.Boolean CheckHudVisibleOnStory(System.Int32 id); // 0x076ce6c4
	System.Boolean CheckWindowVisibleOnStory(System.String uiName); // 0x076ce808
	System.Void ShowWeaponElem(); // 0x076ce94c
	System.Void ShowWeaponElemAndFireElem(); // 0x076cea84
	System.Void ShowFireElem(System.Int32 tutorialId); // 0x076ceb5c
	System.Void InitLockHueElemIdsInNewBieLevel(); // 0x076b0520
	System.Void ClearNewBieLockElemIdsDicData(); // 0x076b164c
	WizardGames.Soc.Common.CustomType.PoiTaskContainer get_taskContainer(); // 0x076ced4c
	System.Void RequestAcceptPoiTask(System.Int64 id); // 0x076cee68
	System.Void RequestSubmitPoiTask(System.Int64 id); // 0x076cf3ac
	System.Void RequestAbandonPoiTask(System.Int64 id); // 0x076cf574
	System.Void RequestRefreshSinglePoiTask(System.Int64 id); // 0x076cf854
	System.Void RefreshTreasureTimer(); // 0x076cfb04
	System.Void ShowTaskLeftTimeTip(); // 0x076d06d4
	System.Void TaskLeftTimeTip(System.Int64 id, System.Object data, System.Boolean isDelete); // 0x076d078c
	System.Void TaskEndTip(System.Int64 id, System.Object data, System.Boolean isDelete); // 0x076d0b2c
	System.Int32 HasTreasureHuntTaskReward(); // 0x076d0d38
	System.Int32 HasBeeBuzzTaskReward(); // 0x076d0df0
	System.Boolean MissionExist(System.Int64 id); // 0x076cf27c
	System.Int64 GetTrapAnimalEntityId(); // 0x076d0ea8
	System.Void .ctor(); // 0x076d1218
	System.Int32 <SortListByStatus>b__65_0(System.Int64 a, System.Int64 b); // 0x076d1f68
	System.Void <RequestReceiveAdvisorReward>b__173_0(SimpleJSON.JSONNode ret); // 0x076d20b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrMission.<>c : System.Object
{
	static WizardGames.Soc.SocClient.MgrMission.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.CustomType.PoiTaskNode> <>9__23_0; // 0x8
	static System.Comparison<WizardGames.Soc.Common.CustomType.PoiTaskNode> <>9__24_0; // 0x10
	static System.Action<SimpleJSON.JSONNode> <>9__172_1; // 0x18
	static System.Action<SimpleJSON.JSONNode> <>9__173_1; // 0x20
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMissionBook> <>9__193_2; // 0x28
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMissionBook> <>9__193_3; // 0x30
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMissionBook> <>9__193_4; // 0x38
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMissionBook> <>9__193_0; // 0x40
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMissionBook> <>9__193_1; // 0x48
	static System.Comparison<WizardGames.Soc.Common.Data.Play.QuestPhase> <>9__282_0; // 0x50
	static System.Void .cctor(); // 0x07705c78
	System.Void .ctor(); // 0x07705cdc
	System.Int32 <GetSortedPoiTasks>b__23_0(WizardGames.Soc.Common.CustomType.PoiTaskNode x, WizardGames.Soc.Common.CustomType.PoiTaskNode y); // 0x07705d44
	System.Int32 <GetTraceSortedPoiTasks>b__24_0(WizardGames.Soc.Common.CustomType.PoiTaskNode x, WizardGames.Soc.Common.CustomType.PoiTaskNode y); // 0x07705e04
	System.Void <RequestLobbyGetMainQuestRewards>b__172_1(SimpleJSON.JSONNode errorNode); // 0x07705ec4
	System.Void <RequestReceiveAdvisorReward>b__173_1(SimpleJSON.JSONNode errorNode); // 0x07705f38
	System.Void <OpenSurvivalBook>b__193_2(WizardGames.Soc.SocClient.Ui.UiMissionBook win); // 0x07705fac
	System.Void <OpenSurvivalBook>b__193_3(WizardGames.Soc.SocClient.Ui.UiMissionBook win); // 0x07706034
	System.Void <OpenSurvivalBook>b__193_4(WizardGames.Soc.SocClient.Ui.UiMissionBook win); // 0x077060bc
	System.Void <OpenSurvivalBook>b__193_0(WizardGames.Soc.SocClient.Ui.UiMissionBook win); // 0x07706144
	System.Void <OpenSurvivalBook>b__193_1(WizardGames.Soc.SocClient.Ui.UiMissionBook win); // 0x077061cc
	System.Int32 <InitLockHueElemIdsInNewBieLevel>b__282_0(WizardGames.Soc.Common.Data.Play.QuestPhase a, WizardGames.Soc.Common.Data.Play.QuestPhase b); // 0x07706254
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrMission.<>c__DisplayClass169_0 : System.Object
{
	WizardGames.Soc.SocClient.MgrMission <>4__this; // 0x10
	System.Action successCb; // 0x18
	System.Void .ctor(); // 0x077062e8
	System.Void <RequestFactionLevel>b__0(SimpleJSON.JSONNode ret); // 0x07706350
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrMission.<>c__DisplayClass171_0 : System.Object
{
	WizardGames.Soc.SocClient.MgrMission <>4__this; // 0x10
	System.Action successCb; // 0x18
	System.Void .ctor(); // 0x07706928
	System.Void <TryRequestLobbyMainQuestMission>b__0(SimpleJSON.JSONNode ret); // 0x07706990
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrMission.<>c__DisplayClass172_0 : System.Object
{
	System.Action successCb; // 0x10
	System.Void .ctor(); // 0x077078cc
	System.Void <RequestLobbyGetMainQuestRewards>b__0(SimpleJSON.JSONNode ret); // 0x07707934
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrMission.<>c__DisplayClass292_0 : System.Object
{
	System.Int64 id; // 0x10
	System.Void .ctor(); // 0x077079cc
	System.Void <RequestAbandonPoiTask>b__0(); // 0x07707a34
}

// Client.Runtime
enum WizardGames.Soc.SocClient.EDailyMissionState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.EDailyMissionState Invalid = 0;
	static WizardGames.Soc.SocClient.EDailyMissionState InProgress = 1;
	static WizardGames.Soc.SocClient.EDailyMissionState NotGetReward = 2;
	static WizardGames.Soc.SocClient.EDailyMissionState Complete = 3;
	static WizardGames.Soc.SocClient.EDailyMissionState Failed = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.EMainQuestMissionState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.EMainQuestMissionState None = 0;
	static WizardGames.Soc.SocClient.EMainQuestMissionState Invalid = 1;
	static WizardGames.Soc.SocClient.EMainQuestMissionState InProgress = 2;
	static WizardGames.Soc.SocClient.EMainQuestMissionState NotGetReward = 3;
	static WizardGames.Soc.SocClient.EMainQuestMissionState Complete = 4;
	static WizardGames.Soc.SocClient.EMainQuestMissionState Lock = 5;
	static WizardGames.Soc.SocClient.EMainQuestMissionState LobbyInGame = 6;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.MainQuestData : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	System.Int64 curVal; // 0x10
	System.Int64 maxVal; // 0x18
	System.Int32 taskId; // 0x20
	System.Int32 <FactionId>k__BackingField; // 0x24
	System.Int32 <GroupID>k__BackingField; // 0x28
	System.Int32 <RoundID>k__BackingField; // 0x2c
	System.Collections.Generic.List<WizardGames.Soc.SocClient.MainQuestData> subMissions; // 0x30
	System.Collections.Generic.SortedDictionary<System.Int32,WizardGames.Soc.SocClient.MainQuestData> roundMissions; // 0x38
	System.Boolean <IsRound>k__BackingField; // 0x40
	WizardGames.Soc.SocClient.EMainQuestMissionState state; // 0x44
	System.Int64 get_CurVal(); // 0x07707bf8
	System.Int64 get_MaxVal(); // 0x07708568
	System.Int32 get_TaskId(); // 0x077082e4
	System.Int32 get_FactionId(); // 0x077087f4
	System.Void set_FactionId(System.Int32 value); // 0x07708858
	System.Int32 get_GroupID(); // 0x077088d0
	System.Void set_GroupID(System.Int32 value); // 0x07708934
	System.Int32 get_RoundID(); // 0x077089ac
	System.Void set_RoundID(System.Int32 value); // 0x07708a10
	System.Boolean get_IsRound(); // 0x07708a88
	System.Void set_IsRound(System.Boolean value); // 0x07708aec
	WizardGames.Soc.SocClient.EMainQuestMissionState get_State(); // 0x07708090
	System.Void SetComplete(); // 0x07708b68
	System.String GetRoundStr(); // 0x07708dcc
	System.Boolean get_IsTracked(); // 0x07709048
	System.Void Refresh(System.Int32 taskId, System.Int32 state, System.Int64 curVal); // 0x07707224
	System.Collections.Generic.List<WizardGames.Soc.SocClient.MainQuestData> get_SubMissions(); // 0x077091a4
	System.Void AddSub(WizardGames.Soc.SocClient.MainQuestData sub); // 0x077076a0
	System.Void AddRound(WizardGames.Soc.SocClient.MainQuestData weekly); // 0x07709208
	System.Void OnGet(); // 0x07709438
	System.Void OnRelease(); // 0x07709498
	System.Void OnDestroy(); // 0x07709644
	System.Void .ctor(); // 0x077096a4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.EDeadSheepMissionType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.EDeadSheepMissionType Territory = 1;
	static WizardGames.Soc.SocClient.EDeadSheepMissionType Inner = 2;
	static WizardGames.Soc.SocClient.EDeadSheepMissionType Outer = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.EDeadSheepMissionState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.EDeadSheepMissionState Normal = 0;
	static WizardGames.Soc.SocClient.EDeadSheepMissionState Debris = 1;
	static WizardGames.Soc.SocClient.EDeadSheepMissionState Deserted = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.DeadSheepMissionData : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	System.String Title; // 0x10
	System.String Description; // 0x18
	WizardGames.Soc.SocClient.EDeadSheepMissionType Type; // 0x20
	System.Int32 Achieve; // 0x24
	System.Int32 Target; // 0x28
	System.Int64 RemainTime; // 0x30
	WizardGames.Soc.SocClient.EDeadSheepMissionState State; // 0x38
	System.Void OnGet(); // 0x077097b0
	System.Void OnRelease(); // 0x07709810
	System.Void OnDestroy(); // 0x07709870
	System.Void .ctor(); // 0x077098d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.MonumentMissionRemoteData : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	System.Int32 taskId; // 0x10
	System.Int32 taskState; // 0x14
	System.Void Refresh(WizardGames.Soc.Common.SimpleCustom.MonumentTaskState data); // 0x07709938
	System.Void OnGet(); // 0x077099bc
	System.Void OnRelease(); // 0x07709a24
	System.Void OnDestroy(); // 0x07709a84
	System.Void .ctor(); // 0x07709ae4
}

// Client.Runtime
class WizardGames.Soc.SocClient.NewbieMissionLocalData : System.Object
{
	System.Collections.Generic.SortedDictionary<System.Int64,System.Collections.Generic.List<System.Int64>> phaseTasksDic; // 0x10
	System.Void Clear(); // 0x07709b4c
	System.Void .ctor(); // 0x07709bd0
}

// Client.Runtime
class WizardGames.Soc.SocClient.NewbieMissionLocalData.SortMission : System.Object, System.Collections.Generic.IComparer<System.Int64>
{
	
	System.Int32 Compare(System.Int64 a, System.Int64 b); // 0x07709d20
	System.Void .ctor(); // 0x07709cb8
}

// Client.Runtime
class WizardGames.Soc.SocClient.NewbieMissionRemoteData : System.Object
{
	WizardGames.Soc.Common.CustomType.TaskNode task; // 0x10
	System.Int64 get_TrackId(); // 0x07709ec4
	System.Int64 get_Id(); // 0x07709f88
	System.Void Refresh(WizardGames.Soc.Common.CustomType.TaskNode task); // 0x0770a000
	System.Void .ctor(); // 0x0770a080
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrPerfSight : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Boolean NeedAutoFin; // 0x11
	System.Boolean _isInit; // 0x12
	System.Boolean _isLevelBegan; // 0x13
	System.Boolean _isFocus; // 0x14
	System.Int32 _sendIntervalSeconds; // 0x18
	System.Int32 _sendWaitingSeconds; // 0x1c
	System.Int32 _currentLevelId; // 0x20
	System.Int32 _levelId; // 0x24
	System.String _levelName; // 0x28
	System.String _sceneName; // 0x30
	System.Int32 _rtt; // 0x38
	System.Int32 _fps; // 0x3c
	System.Boolean _isTagBegan; // 0x40
	System.Boolean _hasPostedServerInfo; // 0x41
	WizardGames.Soc.SocClient.MgrPerfSight.PerfSightTag _tag; // 0x48
	WizardGames.Soc.SocClient.MgrPerfSight.EDeviceConfigStatus _deviceConfigStatus; // 0x58
	System.Int32 _deviceConfigVersion; // 0x5c
	System.Int32 _hasChangedQualityFps; // 0x60
	WizardGames.Soc.SocClient.MgrPerfSight.ETApmGameObjectStatus _TApmGameObjectStatus; // 0x64
	System.Boolean _isFirstCheck; // 0x68
	UnityEngine.GameObject _TApmGameObject; // 0x70
	UnityEngine.Component _ApmFrameProcessor; // 0x78
	WizardGames.Soc.RMQualityLevel QualityLevel; // 0x80
	System.Int32 QualityLevelPC; // 0x84
	WizardGames.Soc.SocClient.MgrPerfSight.PerfTimeInfo _timeInfo; // 0x88
	System.String AppId; // 0xb0
	WizardGames.Soc.SocClient.MgrPerfSight.DeviceLevelInfo _deviceLevelInfo; // 0xb8
	System.Int64 _beginTime; // 0xc0
	System.Collections.Generic.List<System.String> _qualityPCKeys; // 0xc8
	System.String _DisplayResolution; // 0xd0
	System.String _DisplayMode; // 0xd8
	System.String _VSync; // 0xe0
	System.Void Init(); // 0x0770a0e8
	System.Void OnAccountLogined(); // 0x0770a5c0
	System.Void OnLoadLevelCompleted(); // 0x0770a780
	System.Void OnWorldExit(); // 0x0770a984
	System.Void OnApplicationFocusChanged(System.Boolean focus); // 0x0770ac60
	System.Boolean OnApplicationQuit(); // 0x0770ad98
	System.Void OnApplicationCrash(); // 0x0770ae8c
	System.Void BeginLevel(System.String name); // 0x0770af2c
	System.Void PostQualitySettings(); // 0x0770ba68
	System.Void EndLevel(); // 0x0770aa24
	System.Void SetQuality(System.Int32 fps, WizardGames.Soc.RMQualityLevel qualityLevel, System.Boolean needPostInfo); // 0x0770be14
	System.Void ChangeTag(System.String tag, WizardGames.Soc.SocClient.MgrPerfSight.ETagType tagType); // 0x0770c2ec
	System.Void CheckTApmGameObject(); // 0x0770c40c
	System.Void Update(); // 0x0770c688
	System.Void PostQualityInfo(); // 0x0770c240
	System.Void PostLevelInfo(); // 0x0770b3fc
	System.Void PostValue(System.Collections.Generic.List<WizardGames.Soc.Common.Indicator.IndicatorData> dataList); // 0x0770c7ec
	System.Single GetAspectRatio(); // 0x0770cc50
	System.String GetScreenLayout(); // 0x0770cdd4
	System.Single GetDeviceSize(); // 0x0770d13c
	System.Void PostDeviceInfo(); // 0x0770b56c
	System.Void PostServerInfo(); // 0x0770d47c
	System.Void PostValue(WizardGames.Soc.Common.Indicator.IndicatorData data); // 0x0770c8cc
	System.Int32 GetDeviceLevel(); // 0x0770d7f0
	System.Boolean IsDevicePad(System.String content); // 0x0770eff4
	System.Void CacheDeviceLevel(System.Int32 deviceLevel); // 0x0770f35c
	System.Boolean UpdateServerDeviceConfig(System.String configPath, System.String md5Url, System.String configUrl); // 0x0770e2c4
	System.String GetDefaultConfigContent(System.String configName); // 0x0770e70c
	System.Collections.Generic.List<System.String> GetConfigureList(System.String content); // 0x0770edc8
	System.Int32 GetConfigVersion(System.String content); // 0x0770ebdc
	System.Void .ctor(); // 0x0770f790
	static System.Void .cctor(); // 0x0770fd6c
}

// Client.Runtime
struct WizardGames.Soc.SocClient.MgrPerfSight.PerfSightTag : System.ValueType
{
	System.String fpsQualityTag; // 0x10
	System.String stepTag; // 0x18
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.MgrPerfSight.PerfTimeInfo : System.ValueType
{
	System.Nullable<System.DateTime> startTime; // 0x10
	System.Nullable<System.DateTime> endTime; // 0x20
	System.Boolean isStartTimeValid; // 0x30
	System.Boolean isEndTimeValid; // 0x31
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.MgrPerfSight.ETagType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.MgrPerfSight.ETagType FpsQualityTag = 0;
	static WizardGames.Soc.SocClient.MgrPerfSight.ETagType stepTag = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.MgrPerfSight.EDeviceConfigStatus : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.MgrPerfSight.EDeviceConfigStatus None = 0;
	static WizardGames.Soc.SocClient.MgrPerfSight.EDeviceConfigStatus Local = 1;
	static WizardGames.Soc.SocClient.MgrPerfSight.EDeviceConfigStatus Remote = 2;
	static WizardGames.Soc.SocClient.MgrPerfSight.EDeviceConfigStatus RemoteCache = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.MgrPerfSight.ETApmGameObjectStatus : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.MgrPerfSight.ETApmGameObjectStatus Normal = 0;
	static WizardGames.Soc.SocClient.MgrPerfSight.ETApmGameObjectStatus Destroied = 1;
	static WizardGames.Soc.SocClient.MgrPerfSight.ETApmGameObjectStatus Disable = 2;
	static WizardGames.Soc.SocClient.MgrPerfSight.ETApmGameObjectStatus FrameComponentDestroied = 3;
	static WizardGames.Soc.SocClient.MgrPerfSight.ETApmGameObjectStatus FrameComponentDisable = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrPerfSight.DeviceLevelInfo : System.Object
{
	System.Single defaultLevel; // 0x10
	System.Single gpuLevel; // 0x14
	System.Single level0; // 0x18
	System.Single gpuCheckMin; // 0x1c
	System.Single gpuCheckMax; // 0x20
	System.Single segmentation; // 0x24
	System.Single segmentationOther; // 0x28
	System.Single deviceSize; // 0x2c
	System.Single aspectRatio; // 0x30
	System.String screenLayout; // 0x38
	System.Void .ctor(); // 0x0770fcd8
