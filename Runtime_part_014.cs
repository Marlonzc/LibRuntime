	static WizardGames.Soc.Common.Unity.AnimSpeedSetType R = 1;
	static WizardGames.Soc.Common.Unity.AnimSpeedSetType FR = 2;
	static WizardGames.Soc.Common.Unity.AnimSpeedSetType BR = 3;
	static WizardGames.Soc.Common.Unity.AnimSpeedSetType B = 4;
	static WizardGames.Soc.Common.Unity.AnimSpeedSetType BL = 5;
	static WizardGames.Soc.Common.Unity.AnimSpeedSetType FL = 6;
	static WizardGames.Soc.Common.Unity.AnimSpeedSetType L = 7;
	static WizardGames.Soc.Common.Unity.AnimSpeedSetType XZ = 8;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.ValueCompareRule : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.ValueCompareRule Equal = 0;
	static WizardGames.Soc.Common.Unity.ValueCompareRule NotEqual = 1;
	static WizardGames.Soc.Common.Unity.ValueCompareRule Greater = 2;
	static WizardGames.Soc.Common.Unity.ValueCompareRule Less = 3;
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.ProcedureControlConf : System.ValueType
{
	static SocLogger logger; // 0x0
	static System.String[] MoveStateEnums; // 0x8
	static System.String[] PoseStateEnums; // 0x10
	static System.String[] PassiveStateEnums; // 0x18
	static System.String[] UnAliveStateEnums; // 0x20
	static System.String[] ActionStateEnums; // 0x28
	static System.String[] MoveLadderStateEnums; // 0x30
	static System.String[] Empty; // 0x38
	static System.String MoveStateEnumName; // 0x40
	static System.String PoseStateEnumName; // 0x48
	static System.String PassiveStateEnumName; // 0x50
	static System.String UnAliveStateEnumName; // 0x58
	static System.String ActionStateEnumName; // 0x60
	static System.String MoveLadderStateEnumName; // 0x68
	static System.Type[] SupportTypes; // 0x70
	static System.String[] SupportDisplayTypes; // 0x78
	WizardGames.Soc.Common.Unity.StateApplyType CmpType; // 0x10
	System.String StateType; // 0x18
	System.String State; // 0x20
	System.Int32 StateIntValue; // 0x28
	System.String Param; // 0x30
	System.String ParamValue; // 0x38
	WizardGames.Soc.Common.Unity.AnimSpeedSetType SpeedSetType; // 0x40
	WizardGames.Soc.Common.Unity.StateApplyRule ApplyRule; // 0x44
	WizardGames.Soc.Common.Unity.ValueCompareRule ValueRule; // 0x48
	CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConf ToAnimProcedureCtrlJobConf(); // 0x07332110
	static System.Void .cctor(); // 0x07332384
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.VehicleCameraType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.VehicleCameraType GroundVehicle = 0;
	static WizardGames.Soc.Common.Unity.VehicleCameraType AirVehicle = 1;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.VehicleCameraParams : UnityEngine.MonoBehaviour
{
	WizardGames.Soc.Common.Unity.VehicleCameraType cameraType; // 0x30
	UnityEngine.Transform targetPoint; // 0x38
	System.Single target2RootDis; // 0x40
	UnityEngine.Vector3 passengerLookAtOffset; // 0x44
	System.Single maxRollAngle; // 0x50
	System.Single maxPitchAngle; // 0x54
	System.Single LastTime; // 0x58
	System.Single lerpRateNow; // 0x5c
	System.Single tpPitchMax; // 0x60
	System.Single tpPitchMin; // 0x64
	System.Single tpYawMax; // 0x68
	System.Single tpYawMin; // 0x6c
	System.Single tpBestYaw; // 0x70
	System.Single tpBestPitch; // 0x74
	System.Int32 tpBack2BestViewTime; // 0x78
	System.Single tpBack2BestViewVelocity; // 0x7c
	System.Single tpYawFrequency; // 0x80
	System.Single tpYawInterpSpeed; // 0x84
	System.Single tpYawSpringRatio; // 0x88
	System.Boolean tpYawBInterpConstant; // 0x8c
	System.Single tpPitchFrequency; // 0x90
	System.Single tpPitchInterpSpeed; // 0x94
	System.Single tpPitchSpringRatio; // 0x98
	System.Boolean tpPitchBInterpConstant; // 0x9c
	System.Int32 timeToDriverViewOnHorseAfterFire; // 0xa0
	System.Single fpPitchMax; // 0xa4
	System.Single fpPitchMin; // 0xa8
	System.Single fpYawMax; // 0xac
	System.Single fpYawMin; // 0xb0
	System.Single fpBestYaw; // 0xb4
	System.Single fpBestPitch; // 0xb8
	System.Int32 fpBack2BestViewTime; // 0xbc
	System.Single fpBack2BestViewVelocity; // 0xc0
	System.Single fpYawFrequency; // 0xc4
	System.Single fpYawInterpSpeed; // 0xc8
	System.Single fpYawSpringRatio; // 0xcc
	System.Boolean fpYawBInterpConstant; // 0xd0
	System.Single fpPitchFrequency; // 0xd4
	System.Single fpPitchInterpSpeed; // 0xd8
	System.Single fpPitchSpringRatio; // 0xdc
	System.Boolean fpPitchBInterpConstant; // 0xe0
	System.Single tpPitchMaxPC; // 0xe4
	System.Single tpPitchMinPC; // 0xe8
	System.Single tpYawMaxPC; // 0xec
	System.Single tpYawMinPC; // 0xf0
	System.Single tpBestYawPC; // 0xf4
	System.Single tpBestPitchPC; // 0xf8
	System.Int32 tpBack2BestViewTimePC; // 0xfc
	System.Single tpBack2BestViewVelocityPC; // 0x100
	System.Single tpYawFrequencyPC; // 0x104
	System.Single tpYawInterpSpeedPC; // 0x108
	System.Single tpYawSpringRatioPC; // 0x10c
	System.Boolean tpYawBInterpConstantPC; // 0x110
	System.Single tpPitchFrequencyPC; // 0x114
	System.Single tpPitchInterpSpeedPC; // 0x118
	System.Single tpPitchSpringRatioPC; // 0x11c
	System.Boolean tpPitchBInterpConstantPC; // 0x120
	System.Single fpPitchMaxPC; // 0x124
	System.Single fpPitchMinPC; // 0x128
	System.Single fpYawMaxPC; // 0x12c
	System.Single fpYawMinPC; // 0x130
	System.Single fpBestYawPC; // 0x134
	System.Single fpBestPitchPC; // 0x138
	System.Int32 fpBack2BestViewTimePC; // 0x13c
	System.Single fpBack2BestViewVelocityPC; // 0x140
	System.Single fpYawFrequencyPC; // 0x144
	System.Single fpYawInterpSpeedPC; // 0x148
	System.Single fpYawSpringRatioPC; // 0x14c
	System.Boolean fpYawBInterpConstantPC; // 0x150
	System.Single fpPitchFrequencyPC; // 0x154
	System.Single fpPitchInterpSpeedPC; // 0x158
	System.Single fpPitchSpringRatioPC; // 0x15c
	System.Boolean fpPitchBInterpConstantPC; // 0x160
	System.Void OnEnable(); // 0x07332a94
	System.Void .ctor(); // 0x07332c04
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.CaveLift : UnityEngine.MonoBehaviour
{
	UnityEngine.Transform bucketTransform; // 0x30
	UnityEngine.Transform planeTransform; // 0x38
	UnityEngine.Transform wheelTransform; // 0x40
	System.Void .ctor(); // 0x07332d1c
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.EntityState : System.ValueType
{
	WizardGames.Soc.Common.Entity.PlayerMoveStateEnum MoveState; // 0x10
	WizardGames.Soc.Common.Entity.PlayerPoseStateEnum PoseState; // 0x11
	WizardGames.Soc.Common.Entity.PlayerPassiveStateEnum PassiveState; // 0x12
	WizardGames.Soc.Common.Entity.PlayerUnAliveStateEnum UnAliveState; // 0x13
	WizardGames.Soc.Common.Entity.PlayerActionStateEnum ActionState; // 0x14
	WizardGames.Soc.Common.Entity.PlayerMoveLadderStateEnum MoveLadderState; // 0x15
	System.Void Reset(); // 0x0731c484
	System.Void ApplyFromEntity(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x0731fa30
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.BodyBoundsConfig : UnityEngine.MonoBehaviour
{
	UnityEngine.Bounds Bounds; // 0x30
	System.Single Distance(UnityEngine.Vector3 position); // 0x07332d84
	UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 position); // 0x07332e9c
	WizardGames.Soc.Common.Unity.Utility.OBB WorldSpaceOBB(); // 0x07332f6c
	System.Void RefreshBoundsByColliders(); // 0x073330c8
	static WizardGames.Soc.Common.Unity.BodyBoundsConfig AddBodyBoundsConfigByColliders(UnityEngine.GameObject gameObject); // 0x073336b0
	System.Void OnDrawGizmosSelected(); // 0x07333748
	System.Void .ctor(); // 0x07333880
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.CommonDeploySocket : UnityEngine.MonoBehaviour
{
	UnityEngine.Transform socketModParentNode; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.DeploySocketModBase> socketMods; // 0x38
	UnityEngine.Vector3 idealPlacementNormal; // 0x40
	System.Boolean useTargetNormal; // 0x4c
	System.Void Awake(); // 0x073338e8
	System.Boolean CheckSocketMods(UnityEngine.Vector3 parentPosition, UnityEngine.Quaternion parentRotation); // 0x07333a0c
	WizardGames.Soc.Common.Unity.Construction.Placement DoPlacement(WizardGames.Soc.Common.Unity.Construction.PlaceTarget& target); // 0x07333c2c
	System.Void .ctor(); // 0x073340fc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.DeployObj : UnityEngine.MonoBehaviour, WizardGames.Soc.Common.Unity.Construction.IDeployVolumeCheckGo
{
	System.Boolean CanPlaceAtMaxDistance; // 0x30
	System.Single MaxPlaceDistance; // 0x34
	WizardGames.Soc.Common.Unity.CommonDeploySocket Socket; // 0x38
	System.Int64 EntityId; // 0x40
	System.Boolean placeOnWater; // 0x48
	UnityEngine.Renderer[] MeshList; // 0x50
	WizardGames.Soc.Common.Unity.Construction.DeployVolume[] Volumes; // 0x58
	WizardGames.AssetPool.AssetPoolHandle redTransMat; // 0x60
	WizardGames.AssetPool.AssetPoolHandle blueTransMat; // 0x68
	System.Boolean CanRotateBeforePlace; // 0x70
	System.Single RotationAmount; // 0x74
	UnityEngine.RaycastHit[] hitBuffer; // 0x78
	WizardGames.Soc.Common.Construction.FreeSocketRuntime freeSocketRuntime; // 0x80
	System.Void IntoDeployMode(); // 0x073341ac
	System.Int64 WizardGames.Soc.Common.Unity.Construction.IDeployVolumeCheckGo.get_PartType(); // 0x073342f8
	System.Boolean CheckDeployOverlap(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot); // 0x0733435c
	System.Boolean CheckCanPlace(WizardGames.Soc.Common.Unity.Construction.PlaceTarget target); // 0x073344d4
	System.Boolean CheckSightBlock(WizardGames.Soc.Common.Unity.Construction.PlaceTarget& target); // 0x0733460c
	System.Void SetRenderersMaterial(UnityEngine.Renderer[] renderers, WizardGames.AssetPool.AssetPoolHandle material); // 0x07334834
	System.Void SetEditMatBlue(); // 0x0733428c
	System.Void SetEditMatRed(); // 0x073349a0
	System.Boolean UpdatePlacement(UnityEngine.Vector3 playerPos, WizardGames.Soc.Common.Unity.Construction.PlaceTarget& target); // 0x07334a0c
	System.Void .ctor(); // 0x07334c7c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.DeploySocketModBase : UnityEngine.MonoBehaviour
{
	
	System.Boolean DoCheck(UnityEngine.Vector3 parentPosition, UnityEngine.Quaternion parentRotation); // 0x07334d1c
	System.Void .ctor(); // 0x07334dfc
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.IRepairAble : 
{
	
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.MonoBehaviourConfigItem : System.Object
{
	System.String findPath; // 0x10
	System.Int32 maxDepth; // 0x18
	System.Boolean justFirst; // 0x1c
	System.Void .ctor(); // 0x07334e64
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.IGoConfig : 
{
	
	T GetMono<T>(); // 0x052af1f0
	System.Collections.Generic.List<T> GetMonos<T>(); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.GoConfig : System.Object, WizardGames.Soc.Common.Unity.IGoConfig
{
	static SocLogger logger; // 0x0
	System.Boolean <Inited>k__BackingField; // 0x10
	UnityEngine.GameObject <go>k__BackingField; // 0x18
	System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform> namePointsDic; // 0x20
	System.Collections.Generic.Dictionary<System.Type,System.Collections.IList> monoDic; // 0x28
	static System.Collections.Generic.Queue<System.Collections.Generic.KeyValuePair<System.Int32,UnityEngine.Transform>> tempTransQueue; // 0x8
	System.Boolean get_Inited(); // 0x07334ecc
	System.Void set_Inited(System.Boolean value); // 0x07334f30
	UnityEngine.GameObject get_go(); // 0x07334fac
	System.Void set_go(UnityEngine.GameObject value); // 0x07335010
	System.Boolean get_IsGoReady(); // 0x07335090
	System.Void .ctor(UnityEngine.GameObject gameObject); // 0x0733516c
	System.Void Init(); // 0x0733538c
	System.Collections.Generic.Dictionary<System.String,System.String> get_NamePointConfig(); // 0x054e7844
	System.Collections.Generic.Dictionary<System.Type,WizardGames.Soc.Common.Unity.MonoBehaviourConfigItem> get_MonoBehaviourConfig(); // 0x054e7844
	UnityEngine.Transform GetNamedPointTrans(System.String pointName, System.Int32 depth); // 0x0733548c
	T GetMono<T>(); // 0x052af1f0
	System.Collections.Generic.List<T> GetMonos<T>(); // 0x052af1f0
	static System.Void .cctor(); // 0x07335844
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.LagCompensationDebugInfo : System.Object
{
	WizardGames.Soc.Common.Unity.Utility.OBB OBB; // 0x10
	System.Single duration; // 0x60
	System.Single cd; // 0x64
	UnityEngine.Vector3 HitPoint; // 0x68
	UnityEngine.Vector3 PlayerPos; // 0x74
	System.Int64 rendertime; // 0x80
	System.Void .ctor(); // 0x07335970
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.LagCompensationDebugger : UnityEngine.MonoBehaviour
{
	static WizardGames.Soc.Common.Unity.LagCompensationDebugger Instance; // 0x0
	UnityEngine.Material mat; // 0x30
	System.Single Duration; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.LagCompensationDebugInfo> DebugInfos; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.LagCompensationDebugInfo> removeable; // 0x48
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.LagCompensationDebugger.LabelInfo> labels; // 0x50
	static System.Collections.Generic.Dictionary<System.UInt64,System.Boolean> EntityOpen; // 0x8
	System.Void Awake(); // 0x073359d8
	System.Void Update(); // 0x07335ae4
	System.Void AddOBBInfo(WizardGames.Soc.Common.Unity.LagCompensationDebugInfo info); // 0x073361e8
	static System.Void AddLabalInfo(UnityEngine.Vector3 pos, System.String label, System.Single time, UnityEngine.Color color); // 0x073362e8
	static System.Void DrawOBB(WizardGames.Soc.Common.Unity.Utility.OBB obb); // 0x07335f28
	static System.Void OpenDebugger<T>(System.Boolean open); // 0x052af1f0
	static System.Boolean get_IsDebuggerOpen(); // 0x07336510
	System.Void .ctor(); // 0x07336674
	static System.Void .cctor(); // 0x073367b8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.LagCompensationDebugger.LabelInfo : System.Object
{
	UnityEngine.Vector3 pos; // 0x10
	System.String label; // 0x20
	System.Single time; // 0x28
	UnityEngine.Color color; // 0x2c
	System.Void .ctor(); // 0x0733660c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.LagCompensationDebugger.<>c : System.Object
{
	static WizardGames.Soc.Common.Unity.LagCompensationDebugger.<>c <>9; // 0x0
	static System.Predicate<WizardGames.Soc.Common.Unity.LagCompensationDebugger.LabelInfo> <>9__9_0; // 0x8
	static System.Void .cctor(); // 0x07336848
	System.Void .ctor(); // 0x073368ac
	System.Boolean <Update>b__9_0(WizardGames.Soc.Common.Unity.LagCompensationDebugger.LabelInfo e); // 0x07336914
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.BasePhotoState : System.Object, WizardGames.Soc.Common.Unity.IPhotoState
{
	static SocLogger logger; // 0x0
	UnityEngine.Camera <SceneCamera>k__BackingField; // 0x10
	UnityEngine.Camera get_SceneCamera(); // 0x0733699c
	System.Void set_SceneCamera(UnityEngine.Camera value); // 0x07336a00
	System.Void OnCreate(); // 0x07336a80
	System.Void OnDestroy(); // 0x07336b44
	System.Void OnEnter(UnityEngine.GameObject go, UnityEngine.Transform followTrans); // 0x07336ba4
	System.Void OnLeave(System.Boolean atOnce); // 0x07336c20
	System.Void LateUpdate(); // 0x07336c94
	System.Void Rotate(UnityEngine.Vector2 value); // 0x07336cf4
	System.Void Roll(UnityEngine.Vector2 value, System.Boolean isBegan, System.Boolean isTouching); // 0x07336d70
	System.Void Translate(UnityEngine.Vector2 value, System.Boolean isBegan, System.Boolean isTouching); // 0x07336e08
	System.Void MyPlayerRotate(UnityEngine.Vector2 value, System.Boolean isBegan, System.Boolean isTouching); // 0x07336ea0
	System.Void RigRadiusScale(UnityEngine.Vector2 value, System.Boolean isBegan, System.Boolean isTouching); // 0x07336f38
	System.Void Reset(); // 0x07336fd0
	System.Void SetCameraCollider(UnityEngine.GameObject go); // 0x07337030
	System.Void .ctor(); // 0x073371e4
	static System.Void .cctor(); // 0x0733724c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.DollyTrackPhotoState : WizardGames.Soc.Common.Unity.BasePhotoState
{
	static SocLogger logger; // 0x0
	System.Boolean IsSpeedAdaptive; // 0x18
	UnityEngine.Vector2 _offsetRatio; // 0x1c
	UnityEngine.GameObject _dollyTrackGo; // 0x28
	UnityEngine.GameObject _virtualCameraGo; // 0x30
	Cinemachine.CinemachineVirtualCamera _virtualCamera; // 0x38
	Cinemachine.CinemachineDollyCart _dollyCart; // 0x40
	Cinemachine.CinemachineSmoothPath _dollyTrackPath; // 0x48
	Cinemachine.CinemachineBasicMultiChannelPerlin _myCameraPerlin; // 0x50
	System.Boolean _isPlayingOver; // 0x58
	System.Single _moveSpeed; // 0x5c
	System.Single _curMoveSpeed; // 0x60
	WizardGames.Soc.Common.Unity.PathLookAtPoint _lookAtTarget; // 0x68
	System.Boolean get_HasLookAtTarget(); // 0x07337320
	System.Boolean get_IsPlaying(); // 0x0733738c
	System.Void OnCreate(); // 0x07337444
	System.Void OnDestroy(); // 0x07337614
	System.Void OnEnter(UnityEngine.GameObject go, UnityEngine.Transform followTrans); // 0x07337770
	System.Void OnLeave(System.Boolean atOnce); // 0x07337b78
	System.Void LateUpdate(); // 0x07337ca8
	System.Void UpdateFocusDistance(); // 0x07337ef0
	System.Void AdjustMoveSpeed(); // 0x07338250
	System.Void SetAdaptiveSpeed(System.Boolean isAdaptive); // 0x0733842c
	System.Void SetupDollyTrack(Cinemachine.CinemachineSmoothPath dollyTrackPath); // 0x073384a8
	System.Void ChangeMovingStatus(); // 0x07338668
	System.Void StartDollyTrack(System.Boolean restart); // 0x07338784
	System.Void StopDollyTrack(); // 0x073388b4
	System.Void SetLookAtTarget(WizardGames.Soc.Common.Unity.PathLookAtPoint lookAtTarget); // 0x073389bc
	System.Void ResetLookAtTarget(); // 0x07338b80
	System.Void SetMoveSpeed(System.Single speed); // 0x07338cd8
	System.Void SetOffsetRatio(UnityEngine.Vector2 offsetRatio); // 0x07338dbc
	System.Void SetNoiseAmplitude(System.Single amplitude); // 0x07338ea8
	System.Void .ctor(); // 0x07338fe0
	static System.Void .cctor(); // 0x073390a8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.FPPhotoState : WizardGames.Soc.Common.Unity.BasePhotoState
{
	static SocLogger logger; // 0x0
	Cinemachine.CinemachineVirtualCamera _virtualCamera; // 0x18
	System.Void OnCreate(); // 0x0733917c
	System.Void OnDestroy(); // 0x073391e0
	System.Void OnEnter(UnityEngine.GameObject go, UnityEngine.Transform followTrans); // 0x07339254
	System.Void OnLeave(System.Boolean atOnce); // 0x0733958c
	System.Void LateUpdate(); // 0x0733962c
	System.Void UpdateFocusDistance(System.Single value); // 0x073396a0
	System.Void .ctor(); // 0x07339904
	static System.Void .cctor(); // 0x0733998c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.FreePhotoState : WizardGames.Soc.Common.Unity.BasePhotoState
{
	static SocLogger logger; // 0x0
	UnityEngine.GameObject _virtualCameraGo; // 0x18
	Cinemachine.CinemachineVirtualCamera _virtualCamera; // 0x20
	Cinemachine.CinemachineCollider _cameraCollider; // 0x28
	UnityEngine.GameObject _dumpyFollowObject; // 0x30
	UnityEngine.Vector2 _myPlayerRotateValue; // 0x38
	System.Boolean _isMyPlayerRotate; // 0x40
	UnityEngine.Vector2 _translateValue; // 0x44
	System.Boolean _isTranslating; // 0x4c
	UnityEngine.Vector2 _rotateValue; // 0x50
	System.Boolean _isRotating; // 0x58
	System.Single _pitch; // 0x5c
	System.Single _yaw; // 0x60
	System.Void OnCreate(); // 0x07339a60
	System.Void OnDestroy(); // 0x07339b2c
	System.Void OnEnter(UnityEngine.GameObject go, UnityEngine.Transform trans); // 0x07339c10
	System.Void OnLeave(System.Boolean atOnce); // 0x0733a11c
	System.Void MyPlayerRotate(UnityEngine.Vector2 value, System.Boolean isBegan, System.Boolean isTouching); // 0x0733a228
	System.Void HandleMyPlayerRotate(); // 0x0733a2e8
	System.Void Translate(UnityEngine.Vector2 value, System.Boolean isBegan, System.Boolean isTouching); // 0x0733a3a0
	System.Void HandleTranslate(); // 0x0733a4ec
	System.Void Rotate(UnityEngine.Vector2 value); // 0x0733a850
	System.Void HandleRotate(); // 0x0733a8e8
	System.Void LateUpdate(); // 0x0733aaa4
	System.Void UpdateFocusDistance(); // 0x0733ab48
	System.Void .ctor(); // 0x0733af20
	static System.Void .cctor(); // 0x0733afa8
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.IPhotoState : 
{
	
	System.Void OnCreate(); // 0x055049cc
	System.Void OnDestroy(); // 0x055049cc
	System.Void OnEnter(UnityEngine.GameObject go, UnityEngine.Transform followTrans); // 0x0552af00
	System.Void OnLeave(System.Boolean atOnce); // 0x05523a7c
	System.Void LateUpdate(); // 0x055049cc
	System.Void Rotate(UnityEngine.Vector2 value); // 0x0551f630
	System.Void Roll(UnityEngine.Vector2 value, System.Boolean isBegan, System.Boolean isTouching); // 0x0551fd40
	System.Void Translate(UnityEngine.Vector2 value, System.Boolean isBegan, System.Boolean isTouching); // 0x0551fd40
	System.Void MyPlayerRotate(UnityEngine.Vector2 value, System.Boolean isBegan, System.Boolean isTouching); // 0x0551fd40
	System.Void RigRadiusScale(UnityEngine.Vector2 value, System.Boolean isBegan, System.Boolean isTouching); // 0x0551fd40
	System.Void Reset(); // 0x055049cc
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.EPhotoControlEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.EPhotoControlEnum MOVE = 0;
	static WizardGames.Soc.Common.Unity.EPhotoControlEnum ROLL = 1;
	static WizardGames.Soc.Common.Unity.EPhotoControlEnum ROTATE = 2;
	static WizardGames.Soc.Common.Unity.EPhotoControlEnum WHEEL = 3;
	static WizardGames.Soc.Common.Unity.EPhotoControlEnum RESET = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.EPhotoControlPhaseEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.EPhotoControlPhaseEnum Begin = 0;
	static WizardGames.Soc.Common.Unity.EPhotoControlPhaseEnum Move = 1;
	static WizardGames.Soc.Common.Unity.EPhotoControlPhaseEnum End = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.MgrPhoto : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger _logger; // 0x0
	WizardGames.Soc.SocClient.Ui.UiPhoto Ui; // 0x18
	WizardGames.Soc.Common.Unity.PhotoStateController <PhotoStateController>k__BackingField; // 0x20
	System.Boolean <IsPhotoEnabled>k__BackingField; // 0x28
	UnityEngine.Camera SceneCamera; // 0x30
	Cinemachine.CinemachineBrain.UpdateMethod _beforeUpdateMethod; // 0x38
	UnityEngine.Rendering.Volume _dofVolume; // 0x40
	UnityEngine.Rendering.Volume _filterVolume; // 0x48
	UnityEngine.Rendering.VolumeProfile _dofVolumeProfile; // 0x50
	System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Rendering.VolumeProfile> _filterVolumeProfileDict; // 0x58
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Unity.PhotoTemplateData> _templateDataDict; // 0x60
	WizardGames.Soc.Common.Unity.PhotoTemplateData _defaultTemplateData; // 0x68
	System.Boolean _isFirstApplyTemplateData; // 0xa0
	System.Boolean _isTakingShot; // 0xa1
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.PhotoStateEnum,UnityEngine.GameObject> _virtualCameraGoDict; // 0xa8
	WizardGames.Soc.Common.Unity.PhotoData _defaultPhotoData; // 0xb0
	UnityEngine.GameObject bindGo; // 0xb8
	WizardGames.Soc.Common.Unity.PhotoData SavedPhotoData; // 0xc0
	System.Boolean _isFirstEntered; // 0xc8
	System.Boolean _isJoystickTouching; // 0xc9
	System.String _axisNameX; // 0xd0
	System.String _axisNameY; // 0xd8
	WizardGames.Soc.Common.Unity.PhotoStateEnum _photoStateToEnter; // 0xe0
	WizardGames.Soc.Common.Unity.PhotoStateEnum _lastLeavedState; // 0xe4
	WizardGames.Soc.Common.Unity.PhotoStateEnum _defaultState; // 0xe8
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> _uiLayerVisibleDict; // 0xf0
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> _uiLayerVisibleDictForTakeShot; // 0xf8
	System.Int32 _cachedGameViewMode; // 0x100
	System.Boolean IsAdminByGm; // 0x104
	UnityEngine.Vector2 _joystickInput; // 0x108
	WizardGames.Soc.SocClient.Ui.MoveState _joystickMoveState; // 0x110
	System.Boolean _isPCActionCalled; // 0x114
	System.Single _defNearClipPlane; // 0x118
	WizardGames.Soc.Common.Unity.DollyTrackController _dollyTrackController; // 0x120
	WizardGames.Soc.Common.Unity.PhotoStateController get_PhotoStateController(); // 0x0733b07c
	System.Boolean get_IsPhotoEnabled(); // 0x0733b0e0
	System.Void set_IsPhotoEnabled(System.Boolean value); // 0x0733b144
	UnityEngine.Rendering.Volume get_DofVolume(); // 0x0733b1c0
	Cinemachine.CinemachineBrain get__cinemachineBrain(); // 0x0733b224
	WizardGames.Soc.Common.Unity.PhotoStateEnum get_LastState(); // 0x0733b2b0
	System.Void Init(); // 0x055049cc
	System.Void Destroy(); // 0x0733bd2c
	System.Void CleanUp(); // 0x055049cc
	System.Void BuildStateSwitchEvent(System.Boolean isInBuildMode); // 0x0733c7a8
	System.Void LateUpdate(); // 0x0733c9b8
	System.Void ChangeState(WizardGames.Soc.Common.Unity.PhotoStateEnum stateEnum); // 0x0733cf24
	System.Threading.Tasks.Task AfterEnterWorld(); // 0x0733d458
	System.Threading.Tasks.Task OnExitWorld(); // 0x0733e2b8
	System.Void InitCinemachineBrain(); // 0x0733d8d4
	System.Void InitPhotoData(); // 0x0733da2c
	System.Void InitDofVolume(); // 0x0733db08
	System.Void LoadDofVolumeProfile(); // 0x0733e708
	System.Void InitTemplateData(); // 0x0733dc74
	System.Void InitFilterVolume(); // 0x0733dbb4
	System.Void LoadfilterVolumeProfileDict(); // 0x0733ea08
	UnityEngine.Rendering.Volume InitVolume(System.String name); // 0x0733e7e4
	System.Void UnloadVolumeProfile(); // 0x0733e674
	System.Void UnloadPhotoData(); // 0x0733e5f8
	System.Void InitVirtualCameras(System.String path, WizardGames.Soc.Common.Unity.PhotoStateEnum stateEnum); // 0x0733e1ac
	System.Void InitVirtualCameras(System.String path, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.PhotoStateEnum> stateList); // 0x0733e094
	System.Boolean IsReady(); // 0x0733eae4
	System.Void UnloadVirtualCameras(); // 0x0733e41c
	System.Boolean CheckRedDots(); // 0x0733f6a8
	System.Void TakeShot(); // 0x0733f70c
	System.Void PreTakeShot(); // 0x0733f8c8
	System.Void AfterTakeShot(); // 0x0733fcf4
	System.Single GetFocusDistanceSliderValue(System.Single value); // 0x0733fd68
	System.Void OnPhotoModeEntered(); // 0x0733fe00
	System.Void OnPhotoModeExited(); // 0x07340edc
	System.Void HideAllLayers(System.Boolean isHide, System.Boolean isFilterInput); // 0x07340b14
	System.Void HideCertainUi(System.Boolean isHide); // 0x073420e0
	System.Boolean CheckCertainUi(System.String uiName); // 0x07342330
	System.Void HideAllLayersForTakeShot(System.Boolean isHide, System.Boolean isFilterInput); // 0x0733f940
	System.Boolean ChangeTo(WizardGames.Soc.Common.Unity.PhotoStateEnum targetState); // 0x07342400
	System.Boolean ChangeToTrack(WizardGames.Soc.Common.Unity.PhotoStateEnum targetState); // 0x0734283c
	System.Boolean ChangeToLast(); // 0x073428d0
	System.Boolean ChangeFp(); // 0x07342940
	System.Boolean ChangeTp(); // 0x073429a8
	System.Void OnPhotoFpEntered(); // 0x07342a10
	System.Void OnPhotoTpEntered(); // 0x07342eb0
	System.Void ApplyFocalLengthScale(); // 0x07337a70
	System.Void ApplyFocalLengthScale(System.Single scale); // 0x07343080
	System.Void SetFov(System.Single fov); // 0x07341dc4
	System.Void ApplyTemplate(System.Int32 index, System.Boolean isReset); // 0x07343184
	System.Void ApplyGesture(System.Int64 index, System.Boolean isReset); // 0x07343698
	System.Void ApplyFilter(System.Int32 index, System.Boolean isReset); // 0x0734380c
	System.Void ApplyAperture(System.Int32 value); // 0x073438f0
	System.Void ApplyIsManualFocus(System.Boolean value); // 0x07343a00
	System.Void ApplyRealFocalLength(System.Single value); // 0x07343c68
	System.Void ApplyFocusDistance(System.Single value); // 0x07343d78
	System.Void ApplyHideSelf(System.Boolean value); // 0x073414c4
	System.Void ApplyHideTeam(System.Boolean value); // 0x07341978
	System.Void OnTeamMemberChange(WizardGames.Soc.Share.Framework.ECustomDictOpType changeType, System.UInt64 roleId, WizardGames.Soc.Common.CustomType.TeamMemberInfo oldMember); // 0x07343eac
	System.Void ApplyHideEnemy(System.Boolean value); // 0x07340614
	System.Void OnPhotoDataChanged(WizardGames.Soc.Common.Unity.EPhotoDataEnum dataType, WizardGames.Soc.Common.Unity.PhotoData data, System.Boolean isReset); // 0x073440e8
	System.Void OnPhotoControlChanged(WizardGames.Soc.Common.Unity.EPhotoControlEnum controlEnum, WizardGames.Soc.Common.Unity.EPhotoControlPhaseEnum phaseEnum, UnityEngine.Vector2 value, System.Boolean isTouching); // 0x0734432c
	System.Void BlockMouseInput(System.Boolean enabled); // 0x073444c0
	System.Void CameraTranslate(UnityEngine.Vector2 value, WizardGames.Soc.SocClient.Ui.MoveState state); // 0x0734512c
	UnityEngine.Vector2 CalcTranslation(); // 0x0733cc10
	System.Void DoCameraTranslate(UnityEngine.Vector2 value); // 0x0733ccd4
	System.Void CameraRotate(UnityEngine.Vector2 value); // 0x07345268
	System.Void OnPhotoControlReset(); // 0x0734549c
	System.Void CameraWheelMove(UnityEngine.Vector2 value, WizardGames.Soc.Common.Unity.EPhotoControlPhaseEnum phaseEnum, System.Boolean isTouching); // 0x07344ecc
	System.Void CameraWheelMovePC(); // 0x073456ac
	System.Void CameraJoystickMove(UnityEngine.Vector2 value, WizardGames.Soc.Common.Unity.EPhotoControlPhaseEnum phaseEnum, System.Boolean isTouching); // 0x073447ac
	System.Void CameraJoystickRoll(UnityEngine.Vector2 value, WizardGames.Soc.Common.Unity.EPhotoControlPhaseEnum phaseEnum, System.Boolean isTouching); // 0x07344a0c
	System.Void PlayerJoystickRotate(UnityEngine.Vector2 value, WizardGames.Soc.Common.Unity.EPhotoControlPhaseEnum phaseEnum, System.Boolean isTouching); // 0x07344c6c
	System.Boolean IsBlockTpRotationInput(); // 0x0734570c
	System.Void OnDyingEnter(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x07345908
	System.Void OnFastReconnected(); // 0x073459bc
	System.Void OnMountableChanged(System.Int64 mountableId); // 0x07345a68
	System.Void OnSeatChanged(System.Boolean isDriver, System.Int64 mountableId); // 0x07345b50
	System.Void OnMonumentChange(System.Boolean isEnter); // 0x07345c40
	WizardGames.Soc.Common.Unity.PhotoStateEnum GetPhotoStateEnum(); // 0x0733f024
	WizardGames.Soc.Common.Unity.PhotoStateEnum CheckCanSwitchState(WizardGames.Soc.Common.Unity.PhotoStateEnum stateToSwitch); // 0x07342550
	System.Boolean CheckInTerritory(); // 0x0733f3ec
	System.Void OnTerritoryEnter(System.Int64 terrId); // 0x07345e1c
	System.Void OnMyPermChanged(); // 0x0734612c
	System.Void OnBuildModeEnter(); // 0x0733c834
	System.Void OnHostileChanged(); // 0x073462cc
	System.Boolean IsForbidTip(System.Int32 id); // 0x07346460
	System.Void OnUiOpen(WizardGames.Soc.Common.Unity.Ui.WindowComBase com); // 0x07346608
	System.Void UpdateFocusDistance(System.Single value); // 0x07342ae4
	System.Void InitFocalLength(System.Boolean isFp); // 0x07342c68
	System.Boolean CheckAdminAuthority(); // 0x0733f32c
	System.Boolean IsShowGestureNavBarRedDot(); // 0x073468dc
	System.Boolean ChangeFree(); // 0x07346b1c
	System.Boolean ChangeTrack(WizardGames.Soc.SocClient.Ui.DollyTrackCameraSettings data); // 0x07346b84
	System.Boolean IsFreeMode(); // 0x0733cb0c
	System.Boolean IsTrackMode(); // 0x07346f14
	System.Void OnPhotoFreeEntered(); // 0x07347018
	System.Void OnPhotoFreeLeaved(); // 0x073471b8
	System.Void OnPhotoTrackEntered(); // 0x07347234
	System.Void OnPhotoTrackLeaved(); // 0x073472ac
	System.Boolean IsDollyTrackCameraPlaying(); // 0x07347324
	System.Void SetupDollyTrackCamera(WizardGames.Soc.SocClient.Ui.DollyTrackCameraSettings data); // 0x07346c44
	System.Void SetMoveForwardOrNot(); // 0x07347484
	System.Void SetDollyTrackCameraState(System.Boolean moving); // 0x073475e0
	System.Void PlaceWayPoint(); // 0x0734777c
	System.Void RemoveWayPoint(); // 0x073477f4
	System.Void ResetWayPoint(); // 0x0734786c
	System.Void UpdateWayPoint(); // 0x073478e4
	System.Void MoveWayPoint(); // 0x0734795c
	System.Void PlaceLookAtPoint(); // 0x073479d4
	System.Void AttachLookAtPoint(); // 0x07347a4c
	System.Boolean ChangeDollyTrackLooping(); // 0x07347ac4
	System.Void StartDollyTrackCameraUsingUiSetting(); // 0x07347bb4
	System.Void .ctor(); // 0x07347c2c
	static System.Void .cctor(); // 0x07347ed8
	System.Void <LoadDofVolumeProfile>b__63_0(System.UInt64 arg1, Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.AssetPool.AssetGroupData> result); // 0x07347fac
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.MgrPhoto.<>c : System.Object
{
	static WizardGames.Soc.Common.Unity.MgrPhoto.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.UiPhoto> <>9__81_0; // 0x8
	static System.Void .cctor(); // 0x07348188
	System.Void .ctor(); // 0x073481ec
	System.Void <OnPhotoModeEntered>b__81_0(WizardGames.Soc.SocClient.Ui.UiPhoto win); // 0x07348254
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.MgrPhoto.<>c__DisplayClass61_0 : System.Object
{
	WizardGames.Soc.Common.Unity.MgrPhoto <>4__this; // 0x10
	WizardGames.Soc.Common.Data.Photo.PhotoConstant tb; // 0x18
	System.Void .ctor(); // 0x073482c8
	System.Void <InitPhotoData>b__0(System.UInt64 arg1, Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.AssetPool.AssetGroupData> result); // 0x07348330
	System.Void <InitPhotoData>b__1(System.UInt64 arg1, Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.AssetPool.AssetGroupData> result); // 0x073484a4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.MgrPhoto.<>c__DisplayClass66_0 : System.Object
{
	WizardGames.Soc.Common.Data.Photo.PhotoFilter filterData; // 0x10
	WizardGames.Soc.Common.Unity.MgrPhoto <>4__this; // 0x18
	System.Void .ctor(); // 0x073485a4
	System.Void <LoadfilterVolumeProfileDict>b__0(System.UInt64 arg1, Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.AssetPool.AssetGroupData> result); // 0x0734860c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.MgrPhoto.<>c__DisplayClass70_0 : System.Object
{
	WizardGames.Soc.Common.Unity.PhotoStateEnum stateEnum; // 0x10
	System.String path; // 0x18
	WizardGames.Soc.Common.Unity.MgrPhoto <>4__this; // 0x20
	System.Void .ctor(); // 0x0734874c
	System.Void <InitVirtualCameras>b__0(UnityEngine.GameObject go, System.Object[] objs); // 0x073487b4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.MgrPhoto.<>c__DisplayClass71_0 : System.Object
{
	System.String path; // 0x10
	WizardGames.Soc.Common.Unity.MgrPhoto <>4__this; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.PhotoStateEnum> stateList; // 0x20
	System.Void .ctor(); // 0x07348b04
	System.Void <InitVirtualCameras>b__0(UnityEngine.GameObject go, System.Object[] objs); // 0x07348b6c
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.MgrPhoto.<InitPhotoData>d__61 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.Common.Unity.MgrPhoto <>4__this; // 0x38
	System.Void MoveNext(); // 0x07349060
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x0734938c
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.MgrPhoto.<InitVirtualCameras>d__70 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.Common.Unity.PhotoStateEnum stateEnum; // 0x38
	System.String path; // 0x40
	WizardGames.Soc.Common.Unity.MgrPhoto <>4__this; // 0x48
	System.Void MoveNext(); // 0x0734940c
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x07349710
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.MgrPhoto.<InitVirtualCameras>d__71 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	System.String path; // 0x38
	WizardGames.Soc.Common.Unity.MgrPhoto <>4__this; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.PhotoStateEnum> stateList; // 0x48
	System.Void MoveNext(); // 0x07349790
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x07349a9c
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.MgrPhoto.<LoadDofVolumeProfile>d__63 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.Common.Unity.MgrPhoto <>4__this; // 0x38
	System.Void MoveNext(); // 0x07349b1c
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x07349d80
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.MgrPhoto.<LoadfilterVolumeProfileDict>d__66 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.Common.Unity.MgrPhoto <>4__this; // 0x38
	System.Void MoveNext(); // 0x07349e00
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x0734a1e0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.DollyTrackController : System.Object
{
	static SocLogger logger; // 0x0
	UnityEngine.GameObject DollyTrackGo; // 0x10
	Cinemachine.CinemachineSmoothPath DollyTrackPath; // 0x18
	System.Boolean _hasLookAtPoint; // 0x20
	System.Boolean _enableAdaptiveSpeed; // 0x21
	System.Single _pathCameraSpeed; // 0x24
	System.Boolean _isLookingAtTarget; // 0x28
	System.Single _lookAtTargetSpeed; // 0x2c
	WizardGames.Soc.Common.Unity.PathLookAtPoint _pathLookAtPoint; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.PathWayPoint> _pathWayPoints; // 0x38
	WizardGames.Soc.Common.Unity.PathReferencePoint _pathReferencePoint; // 0x40
	UnityEngine.LineRenderer _pathLineRenderer; // 0x48
	System.Boolean _isDollyTrackEditorMode; // 0x50
	System.Boolean get_HasLookAtPoint(); // 0x0734a260
	System.Boolean get__isPathLooping(); // 0x0734a2c4
	System.Void set__isPathLooping(System.Boolean value); // 0x0734a378
	System.Void Init(); // 0x0734a4a0
	System.Void Clear(); // 0x0734af54
	System.Void Reset(); // 0x0734b72c
	System.Void LateUpdate(); // 0x0734b878
	System.Void ResetPath(); // 0x0734b2b4
	System.Void SetDollyTrackEditorMode(System.Boolean mode); // 0x0734c048
	System.Void TryPlaceWayPoint(); // 0x0734c9c0
	System.Void AddWayPoint(WizardGames.Soc.Common.Unity.PathWayPoint wayPoint); // 0x0734d158
	System.Void TryRemoveWayPoint(); // 0x0734d450
	System.Void RemoveWayPoint(WizardGames.Soc.Common.Unity.PathWayPoint wayPoint); // 0x0734d5bc
	System.Void ResetAllWayPoints(); // 0x0734d910
	System.Void UpdateWayPoint(); // 0x0734da74
	System.Void TryMoveWayPoint(); // 0x0734dcec
	System.Void TryPickUpPoint(); // 0x0734db98
	System.Void TryPutDownPoint(); // 0x0734da08
	System.Void PlaceLookAtPoint(); // 0x0734e0ec
	System.Void PlaceLookAtPointAt(UnityEngine.Vector3 position, UnityEngine.Vector3 direction); // 0x0734e4d4
	System.Void TryAttachLookAtPoint(); // 0x0734e62c
	System.Boolean CanSetPathLooping(); // 0x0734ea14
	System.Boolean SetPathLooping(System.Boolean looping); // 0x0734eb30
	System.Boolean IsPathLooping(); // 0x0734ebe4
	WizardGames.Soc.Common.Unity.PathLookAtPoint GetLookAtPoint(); // 0x0734ec48
	System.Void UpdateLineRenderer(); // 0x0734bca8
	Cinemachine.CinemachineSmoothPath GetDollyTrackPath(); // 0x0734ed1c
	System.Boolean IsDollyTrackValid(); // 0x0734ee1c
	System.Void RecordLookAtPointPosition(); // 0x0734f0c4
	System.Void RestoreLookAtPointPosition(); // 0x0734f24c
	System.Void .ctor(); // 0x0734f3e8
	static System.Void .cctor(); // 0x0734f4b4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.PathLookAtPoint : System.Object
{
	UnityEngine.GameObject go; // 0x10
	UnityEngine.GameObject _attachedTarget; // 0x18
	UnityEngine.Vector3 _moveDir; // 0x20
	System.Single _moveSpeed; // 0x2c
	UnityEngine.Transform _root; // 0x30
	UnityEngine.Vector3 _recordedPosition; // 0x38
	UnityEngine.Vector3 get_Position(); // 0x0734f548
	System.Boolean get_HasAttached(); // 0x0734f640
	System.Void Init(); // 0x0734acd0
	System.Void Clear(); // 0x0734b0cc
	System.Void LateUpdate(); // 0x0734f6d0
	System.Void Show(); // 0x0734c634
	System.Void Hide(); // 0x0734ae9c
	System.Void SetPlacement(UnityEngine.Vector3 position, UnityEngine.Vector3 direction); // 0x0734e338
	System.Void AttachTo(UnityEngine.GameObject target); // 0x0734e858
	System.Void SetMoveSpeed(System.Single speed); // 0x0734f800
	System.Void RecordPosition(); // 0x0734f18c
	System.Void TryRestorePosition(); // 0x0734f314
	System.Void Detach(); // 0x0734b798
	System.Void .ctor(); // 0x0734ac28
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.PathReferencePoint : System.Object
{
	static SocLogger logger; // 0x0
	UnityEngine.GameObject go; // 0x10
	WizardGames.Soc.Common.Unity.PathWayPoint CurrentWayPoint; // 0x18
	System.Single DetectRadius; // 0x20
	System.Int32 DetectLayerMask; // 0x24
	WizardGames.Soc.Common.Unity.PathWayPoint _detectedWayPoint; // 0x28
	System.Int64 _detectedEntityId; // 0x30
	UnityEngine.Collider[] _colliderBuffer; // 0x38
	UnityEngine.Vector3 get_Position(); // 0x0734ce30
	UnityEngine.Vector3 get_Forward(); // 0x0734e2bc
	System.Void Init(UnityEngine.Camera parent); // 0x0734a97c
	System.Void Clear(); // 0x0734b580
	System.Void Show(); // 0x0734c360
	System.Void Hide(); // 0x0734c6ec
	System.Void LateUpdate(); // 0x0734b900
	System.Void ResetDetectedResult(); // 0x0734f8b0
	WizardGames.Soc.Common.Unity.PathWayPoint TryGetDetectedWayPoint(); // 0x0734fa20
	System.Int64 TryGetDetectedEntityId(); // 0x0734fa84
	System.Boolean IsTakingWayPoint(); // 0x0734cd9c
	System.Boolean PickUpWayPoint(WizardGames.Soc.Common.Unity.PathWayPoint wayPoint); // 0x0734de0c
	System.Boolean PutDownWayPoint(); // 0x0734e038
	System.Void .ctor(); // 0x0734a8c0
	static System.Void .cctor(); // 0x0734fae8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.PathWayPoint : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	UnityEngine.GameObject go; // 0x30
	Cinemachine.CinemachineSmoothPath _dollyTrack; // 0x38
	System.Int32 Index; // 0x40
	System.Int32 TotalCount; // 0x44
	UnityEngine.Vector3 get_Position(); // 0x0734ceac
	System.Void Init(UnityEngine.GameObject go, UnityEngine.Vector3 position, Cinemachine.CinemachineSmoothPath dollyTrack); // 0x0734cfa4
	System.Void Clear(); // 0x0734beac
	System.Void ChangePosition(UnityEngine.Vector3 position); // 0x0734f928
	System.Void SetIndex(System.Int32 newIndex, System.Int32 totalCount); // 0x0734d3c8
	System.Void Show(); // 0x0734c52c
	System.Void Hide(); // 0x0734c8b8
	System.Void .ctor(); // 0x0734fbbc
	static System.Void .cctor(); // 0x0734fc2c
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.EPhotoDataEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.EPhotoDataEnum TEMPLATE_INDEX = 0;
	static WizardGames.Soc.Common.Unity.EPhotoDataEnum GESTURE_INDEX = 1;
	static WizardGames.Soc.Common.Unity.EPhotoDataEnum FILTER_INDEX = 2;
	static WizardGames.Soc.Common.Unity.EPhotoDataEnum FOCAL_LENGTH_SCALE = 3;
	static WizardGames.Soc.Common.Unity.EPhotoDataEnum APERTURE = 4;
	static WizardGames.Soc.Common.Unity.EPhotoDataEnum REAL_FOCAL_LENGTH = 5;
	static WizardGames.Soc.Common.Unity.EPhotoDataEnum IS_MANUAL_FOCUS = 6;
	static WizardGames.Soc.Common.Unity.EPhotoDataEnum FOCUS_DISTANCE = 7;
	static WizardGames.Soc.Common.Unity.EPhotoDataEnum HIDE_SELF = 8;
	static WizardGames.Soc.Common.Unity.EPhotoDataEnum HIDE_TEAM = 9;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.PhotoData : UnityEngine.ScriptableObject, UnityEngine.ISerializationCallbackReceiver
{
	System.Int32 templateIndex; // 0x18
	System.Int64 gestureIndex; // 0x20
	System.Int32 filterIndex; // 0x28
	System.Single minFocalLengthScale; // 0x2c
	System.Single maxFocalLengthScale; // 0x30
	System.Single curFocalLengthScale; // 0x34
	System.Int32 minAperture; // 0x38
	System.Int32 maxAperture; // 0x3c
	System.Int32 curAperture; // 0x40
	System.Int32 timePercent; // 0x44
	System.Int32 timeScale; // 0x48
	System.Single longitude; // 0x4c
	System.Single latitude; // 0x50
	System.Boolean hideSelf; // 0x54
	System.Boolean hideTeam; // 0x55
	UnityEngine.Vector2 translate; // 0x58
	System.Single roll; // 0x60
	System.Single yAxis; // 0x64
	System.Single rigRadiusScale; // 0x68
	System.Single realFocalLength; // 0x6c
	System.Boolean isManualFocus; // 0x70
	System.Single focusDistance; // 0x74
	System.Void OnBeforeSerialize(); // 0x0734fd00
	System.Void OnAfterDeserialize(); // 0x0734fd60
	System.Void CopyFrom(WizardGames.Soc.Common.Unity.PhotoData other); // 0x0734fdc0
	System.Void .ctor(); // 0x0734feac
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.PhotoStateController : System.Object
{
	WizardGames.Soc.Common.Unity.IPhotoState <CurStateIns>k__BackingField; // 0x10
	WizardGames.Soc.Common.Unity.PhotoStateEnum <PreState>k__BackingField; // 0x18
	WizardGames.Soc.Common.Unity.PhotoStateEnum <CurState>k__BackingField; // 0x1c
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.PhotoStateEnum,WizardGames.Soc.Common.Unity.IPhotoState> _states; // 0x20
	System.Action<WizardGames.Soc.Common.Unity.PhotoStateEnum,WizardGames.Soc.Common.Unity.PhotoStateEnum> OnPhotoStateChanged; // 0x28
	System.Boolean _isStatesInited; // 0x30
	WizardGames.Soc.Common.Unity.IPhotoState get_CurStateIns(); // 0x0734ff4c
	System.Void set_CurStateIns(WizardGames.Soc.Common.Unity.IPhotoState value); // 0x0734ffb0
	WizardGames.Soc.Common.Unity.PhotoStateEnum get_PreState(); // 0x07350030
	System.Void set_PreState(WizardGames.Soc.Common.Unity.PhotoStateEnum value); // 0x07350094
	WizardGames.Soc.Common.Unity.PhotoStateEnum get_CurState(); // 0x0735010c
	System.Void set_CurState(WizardGames.Soc.Common.Unity.PhotoStateEnum value); // 0x07350170
	System.Void TryInitPhotoState(); // 0x073501e8
	System.Void Destroy(); // 0x073505ac
	System.Void OnExit(); // 0x07350850
	System.Void ChangeState(WizardGames.Soc.Common.Unity.PhotoStateEnum stateEnum, UnityEngine.GameObject go, UnityEngine.Transform followTrans); // 0x07350ab8
	System.Boolean CheckCanChangeState(WizardGames.Soc.Common.Unity.PhotoStateEnum stateEnum, WizardGames.Soc.Common.Unity.IPhotoState& state); // 0x07350e88
	WizardGames.Soc.Common.Unity.IPhotoState GetPhotoState(WizardGames.Soc.Common.Unity.PhotoStateEnum stateEnum); // 0x07350378
	System.Void LateUpdate(); // 0x073510a4
	System.Void .ctor(); // 0x073511c0
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.PhotoStateEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.PhotoStateEnum NONE = 0;
	static WizardGames.Soc.Common.Unity.PhotoStateEnum FP = 1;
	static WizardGames.Soc.Common.Unity.PhotoStateEnum TP = 2;
	static WizardGames.Soc.Common.Unity.PhotoStateEnum FREE = 3;
	static WizardGames.Soc.Common.Unity.PhotoStateEnum TRACK = 4;
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.PhotoTemplateData : System.ValueType
{
	System.Single AxisValueX; // 0x10
	System.Single AxisValueY; // 0x14
	System.Single TopRigHeight; // 0x18
	System.Single MidRigHeight; // 0x1c
	System.Single BottomRigHeight; // 0x20
	System.Single TopRigRadius; // 0x24
	System.Single MidRigRadius; // 0x28
	System.Single BottomRigRadius; // 0x2c
	System.Single FocalLengthScale; // 0x30
	UnityEngine.Vector2 Translate; // 0x34
	System.Single Roll; // 0x3c
	System.Single RigRadiusScale; // 0x40
	System.Single Pitch; // 0x44
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.TPPhotoState : WizardGames.Soc.Common.Unity.BasePhotoState
{
	static SocLogger logger; // 0x0
	Cinemachine.CinemachineFreeLook _virtualCamera; // 0x18
	Cinemachine.CinemachineCollider _cameraCollider; // 0x20
	UnityEngine.Vector2 _translateValue; // 0x28
	System.Boolean _isTranslating; // 0x30
	System.Boolean _isFirstTranslate; // 0x31
	System.Single _lastAngle; // 0x34
	UnityEngine.Vector2 _myPlayerRotateValue; // 0x38
	System.Boolean _isMyPlayerRotate; // 0x40
	System.Single[] _defaultRigHeight; // 0x48
	System.Single[] _defaultRigRadius; // 0x50
	WizardGames.Soc.Common.Unity.PhotoTemplateData _templateData; // 0x58
	System.Boolean _needToApplyTemplate; // 0x90
	System.String _axisNameX; // 0x98
	System.Void OnCreate(); // 0x07351274
	System.Void OnDestroy(); // 0x073512dc
	System.Void OnEnter(UnityEngine.GameObject go, UnityEngine.Transform followTrans); // 0x07351344
	System.Void OnLeave(System.Boolean atOnce); // 0x0735184c
	System.Void ResetParam(); // 0x073517ac
	System.Void Rotate(UnityEngine.Vector2 value); // 0x07351954
	System.Void Roll(UnityEngine.Vector2 value, System.Boolean isBegan, System.Boolean isTouching); // 0x07351c00
	System.Single GetAngle(UnityEngine.Vector2 value); // 0x07351d78
	System.Void Translate(UnityEngine.Vector2 value, System.Boolean isBegan, System.Boolean isTouching); // 0x07351e24
	System.Void HandleTranslate(); // 0x07351ef4
	System.Void MyPlayerRotate(UnityEngine.Vector2 value, System.Boolean isBegan, System.Boolean isTouching); // 0x07352350
	System.Void HandleMyPlayerRotate(); // 0x07352414
	System.Void RigRadiusScale(UnityEngine.Vector2 value, System.Boolean isBegan, System.Boolean isTouching); // 0x07352588
	System.Void Reset(); // 0x073527a4
	System.Void LateUpdate(); // 0x073528f8
	System.Void UpdateFocusDistance(); // 0x07352be0
	System.Void ApplyTemplate(WizardGames.Soc.Common.Unity.PhotoTemplateData data); // 0x07352fb8
	System.Void HandleApplyTemplate(WizardGames.Soc.Common.Unity.PhotoTemplateData data); // 0x073529e0
	System.Void ApplyTranslateAndRoll(WizardGames.Soc.Common.Unity.PhotoData data); // 0x073533e8
	System.Void ApplyRigRadiusScale(System.Single rigRadiusScale); // 0x07353298
	System.Single[] GetDefaultRigHeight(); // 0x073534d4
	System.Single[] GetDefaultRigRadius(); // 0x07353538
	System.Single[] GetDefaultAxisValue(); // 0x0735359c
	System.Void ApplyYaw(System.Single yaw); // 0x07353068
	System.Void .ctor(); // 0x07350f94
	static System.Void .cctor(); // 0x07353650
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.MgrRes : WizardGames.Soc.Common.Manager.MgrBase
{
	CommonUnity.Runtime.Animation.AnimHandleCacheGroup AnimHandleCacheGroup; // 0x18
	System.Void .ctor(); // 0x07353724
	System.Void Init(); // 0x073537c4
	System.Void CleanUp(); // 0x0735382c
	System.Threading.Tasks.Task OnEnterWorld(); // 0x073538a8
	System.Threading.Tasks.Task OnExitWorld(); // 0x073539a8
	System.Void UpdateUnLimit(); // 0x07353aa8
	System.Void Update(); // 0x07353b08
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.MgrRes.<>c : System.Object
{
	static WizardGames.Soc.Common.Unity.MgrRes.<>c <>9; // 0x0
	static System.Action<System.Single> <>9__8_0; // 0x8
	static System.Action<System.Single> <>9__8_1; // 0x10
	static System.Action<System.Single> <>9__9_0; // 0x18
	static System.Action<System.Single> <>9__9_1; // 0x20
	static System.Void .cctor(); // 0x07353b90
	System.Void .ctor(); // 0x07353bf4
	System.Void <OnEnterWorld>b__8_0(System.Single x); // 0x07353c5c
	System.Void <OnEnterWorld>b__8_1(System.Single x); // 0x07353d78
	System.Void <OnExitWorld>b__9_0(System.Single x); // 0x07353e94
	System.Void <OnExitWorld>b__9_1(System.Single x); // 0x07353fb0
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.MgrRes.<OnEnterWorld>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x30
	System.Void MoveNext(); // 0x073540cc
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x073545e0
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.MgrRes.<OnExitWorld>d__9 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x30
	System.Void MoveNext(); // 0x07354684
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x07354b98
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.EventDispatcherDebuger : FairyGUI.BaseEventDispatcherDebuger
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.HashSet<System.String> enableDebugEvent; // 0x20
	System.Collections.Generic.Dictionary<System.Object,System.String> nameCache; // 0x28
	System.Collections.Generic.List<FairyGUI.BaseEventDispatcherDebuger.DebugInfo> debugList; // 0x30
	System.Collections.Generic.Stack<FairyGUI.BaseEventDispatcherDebuger.DebugInfo> debugStack; // 0x38
	System.Single bubbleStartTime; // 0x40
	System.Comparison<FairyGUI.BaseEventDispatcherDebuger.DebugInfo> comparison; // 0x48
	System.Int32 <SumBubbleCost>k__BackingField; // 0x50
	System.Boolean SkipNextCost; // 0x54
	System.Text.StringBuilder costStrBuilder; // 0x58
	System.Boolean get_HasInfo(); // 0x07354c3c
	System.Int32 get_SumBubbleCost(); // 0x07354cc0
	System.Void set_SumBubbleCost(System.Int32 value); // 0x07354d24
	System.Void Reset(); // 0x07354d9c
	System.Boolean StartBubble(System.String strType); // 0x07354ee0
	System.Void EndBubble(); // 0x07354ffc
	System.String GetBridgeDesc(System.Object bridge); // 0x07355128
	System.Void StartInternal(FairyGUI.BaseEventDispatcherDebuger.DebugType eventType, System.Object bridge); // 0x07355408
	System.Void EndInternal(FairyGUI.BaseEventDispatcherDebuger.DebugType eventType, System.Object bridge); // 0x07355500
	System.Void StartCapture(System.Object bridge); // 0x07355860
	System.Void EndCapture(System.Object bridge); // 0x073558e0
	System.Void StartNormal(System.Object bridge); // 0x07355960
	System.Void EndNormal(System.Object bridge); // 0x073559e0
	System.Collections.Generic.List<FairyGUI.BaseEventDispatcherDebuger.DebugInfo> GetSortedCostList(); // 0x07355a60
	System.String GetCostMsg(System.Object eventTarget, System.String eventType); // 0x07355af0
	System.Void .ctor(); // 0x07355fd0
	static System.Void .cctor(); // 0x0735630c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.EventDispatcherDebuger.<>c : System.Object
{
	static WizardGames.Soc.Common.Unity.Ui.EventDispatcherDebuger.<>c <>9; // 0x0
	static System.Comparison<FairyGUI.BaseEventDispatcherDebuger.DebugInfo> <>9__27_0; // 0x8
	static System.Void .cctor(); // 0x073563e0
	System.Void .ctor(); // 0x07356444
	System.Int32 <.ctor>b__27_0(FairyGUI.BaseEventDispatcherDebuger.DebugInfo a, FairyGUI.BaseEventDispatcherDebuger.DebugInfo b); // 0x073564ac
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate_Input : 
{
	
	System.Void OnFpsUnlimitedUpdate_Input(System.Single dt); // 0x05513724
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate : 
{
	
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05513724
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Ui.IUiFps30Update : 
{
	
	System.Void OnFps30Update(System.Single dt); // 0x05513724
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Ui.IUiFps10Update : 
{
	
	System.Void OnFps10Update(System.Single dt); // 0x05513724
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Ui.IUiFps2Update : 
{
	
	System.Void OnFps2Update(System.Single dt); // 0x05513724
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Ui.IUiFps1Update : 
{
	
	System.Void OnFps1Update(System.Single dt); // 0x05513724
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Ui.IUiStopLooting : 
{
	
	System.Void StopLooting(); // 0x055049cc
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Ui.IUiTriggerGuide : 
{
	
	System.Boolean TriggerGuide(); // 0x054c4760
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.LayerWindowCache : WizardGames.Soc.Common.Unity.Ui.UiLoopCache
{
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Ui.WindowComBase> name2Window; // 0x78
	System.Int32 get_WinCount(); // 0x07356564
	System.Collections.Generic.List<System.Object> FillForeachList(System.Collections.Generic.List<System.Object> res); // 0x073565e8
	System.Void ClearAllInst(); // 0x07356788
	System.Void AppendInst(System.Object obj); // 0x0735698c
	System.Void RemoveInst(System.String uiName); // 0x07356f18
	WizardGames.Soc.Common.Unity.Ui.WindowComBase GetWindowInst(System.String uiName); // 0x07357234
	System.Void .ctor(); // 0x07357310
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Ui.ELoopType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Ui.ELoopType FpsUnlimited = 0;
	static WizardGames.Soc.Common.Unity.Ui.ELoopType FpsUnlimited_Input = 1;
	static WizardGames.Soc.Common.Unity.Ui.ELoopType Fps30 = 2;
	static WizardGames.Soc.Common.Unity.Ui.ELoopType Fps10 = 3;
	static WizardGames.Soc.Common.Unity.Ui.ELoopType Fps2 = 4;
	static WizardGames.Soc.Common.Unity.Ui.ELoopType Fps1 = 5;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.LayerComBase : FairyGUI.GComponent
{
	System.Action<System.Object,System.Single> extendFps1Loop; // 0x288
	WizardGames.Soc.Common.Unity.Ui.LayerWindowCache winCaches; // 0x290
	System.Collections.Generic.Dictionary<System.String,System.String> strCaches; // 0x298
	System.Collections.Generic.HashSet<WizardGames.Soc.Common.Unity.Ui.WindowComBase> toAutoRemoveWindow; // 0x2a0
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Ui.WindowComBase> listWindowForTimeSort; // 0x2a8
	System.Comparison<WizardGames.Soc.Common.Unity.Ui.WindowComBase> winTimeSorter; // 0x2b0
	System.Collections.Generic.List<System.Object> listForWinForeach; // 0x2b8
	WizardGames.Soc.Common.Unity.Ui.MgrUiBase mgr; // 0x2c0
	System.Action<System.Object> onLayerVisibleChanged; // 0x2c8
	System.Int32 maxWinCount; // 0x2d0
	System.Int32 <LayerOrder>k__BackingField; // 0x2d4
	System.Int32 <LayerID>k__BackingField; // 0x2d8
	System.Collections.Generic.HashSet<System.String> hideRecord; // 0x2e0
	System.Int32 get_LayerOrder(); // 0x073578f0
	System.Void set_LayerOrder(System.Int32 value); // 0x07357954
	System.Int32 get_LayerID(); // 0x073579cc
	System.Void set_LayerID(System.Int32 value); // 0x07357a30
	System.Void .ctor(WizardGames.Soc.Common.Unity.Ui.MgrUiBase uiMgr, System.Int32 id, System.Int32 order); // 0x07357aa8
	System.String ToString(); // 0x07357d74
	System.Void HandleLayerVisibleChanged(System.Object winObj); // 0x07357edc
	System.Void HandleVisibleChanged(); // 0x07358010
	WizardGames.Soc.Common.Unity.Ui.WindowComBase GetWinow(System.String uiName); // 0x073580f4
	System.Boolean AddWindow(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x073581ac
	System.Boolean ShowWindowPreCheck(System.String uiName); // 0x07358300
	System.Void ShowWindow(System.String uiName, System.Boolean immediately); // 0x07358378
	System.Void DoHideWindow(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x07358420
	System.Boolean HideWindowPreCheck(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x073584b4
	System.Void HideWindow(System.String uiName, System.Boolean immediately); // 0x0735852c
	System.Void ForeachWindows(System.Action<WizardGames.Soc.Common.Unity.Ui.WindowComBase> action); // 0x0735878c
	System.Void DestoryWindowInst(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x073589a0
	System.Void RemoveWindowImmediately(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x07359190
	System.Void DoRemoveWindow(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x0735957c
	System.Void RemoveWindow(System.String uiName, System.Boolean immediately); // 0x07359604
	System.Void DoClearLayer(); // 0x073598c0
	System.Void ClearLayer(System.Boolean handleWinHideRecover); // 0x07359920
	System.Void DoOpenWindow(WizardGames.Soc.Common.Unity.Ui.WindowComBase win, System.Boolean immediately); // 0x07359c78
	System.Void OnCommonUpdate(System.Single dt, System.Collections.Generic.List<System.Object> updateList, System.Action<System.Object,System.Single> updateAction, WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x07359da8
	System.Void OnFpsUnlimitedUpdateLayer(System.Single dt); // 0x0735a464
	System.Void OnFpsUnlimitedUpdateLayer_Input(System.Single dt); // 0x0735a570
	System.Void OnFps30UpdateLayer(System.Single dt); // 0x0735a67c
	System.Void OnFps10UpdateLayer(System.Single dt); // 0x0735a788
	System.Void OnFps2UpdateLayer(System.Single dt); // 0x0735a894
	System.Void OnFps1UpdateLayer(System.Single dt); // 0x0735a9a0
	System.Void DoRemoveOutOfDateWindows(); // 0x0735abd8
	System.Void RemoveOutOfDateWins(System.Boolean forceTime); // 0x0735ae60
	System.Void CheckAndAutoRemoveWins(WizardGames.Soc.Common.Unity.Ui.WindowComBase winExcept); // 0x0735b180
	System.Int32 WinOpenedNum(); // 0x0735b8ec
	System.Void CheckAllWinAdapt(); // 0x0735b964
	System.Void <OnFps1UpdateLayer>b__44_0(System.Object win, System.Single dt); // 0x0735bbd4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.LayerComBase.<>c : System.Object
{
	static WizardGames.Soc.Common.Unity.Ui.LayerComBase.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__47_0; // 0x8
	static System.Void .cctor(); // 0x0735bd38
	System.Void .ctor(); // 0x0735bd9c
	System.Int32 <CheckAndAutoRemoveWins>b__47_0(WizardGames.Soc.Common.Unity.Ui.WindowComBase a, WizardGames.Soc.Common.Unity.Ui.WindowComBase b); // 0x0735be04
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.LayerComBase.<>c__DisplayClass29_0 : System.Object
{
	WizardGames.Soc.Common.Unity.Ui.LayerComBase <>4__this; // 0x10
	WizardGames.Soc.Common.Unity.Ui.WindowComBase win; // 0x18
	System.Void .ctor(); // 0x07358724
	System.Void <HideWindow>b__0(); // 0x0735bf2c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.LayerComBase.<>c__DisplayClass34_0 : System.Object
{
	WizardGames.Soc.Common.Unity.Ui.LayerComBase <>4__this; // 0x10
	WizardGames.Soc.Common.Unity.Ui.WindowComBase win; // 0x18
	System.Void .ctor(); // 0x07359858
	System.Void <RemoveWindow>b__0(); // 0x0735bfa8
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Ui.LayerRuler : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Ui.LayerRuler Overlay = 0;
	static WizardGames.Soc.Common.Unity.Ui.LayerRuler StackCover = 1;
	static WizardGames.Soc.Common.Unity.Ui.LayerRuler Mutex = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.LayerComFactory : System.Object
{
	
	static WizardGames.Soc.Common.Unity.Ui.LayerComBase CreateLayer(WizardGames.Soc.Common.Unity.Ui.MgrUiBase uiMgr, WizardGames.Soc.Common.Unity.Ui.LayerRuler ruler, System.Int32 id, System.Int32 order); // 0x0735c024
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.LayerComMutex : WizardGames.Soc.Common.Unity.Ui.LayerComBase
{
	WizardGames.Soc.Common.Unity.Ui.WindowComBase winMutex; // 0x2e8
	System.Void .ctor(WizardGames.Soc.Common.Unity.Ui.MgrUiBase uiMgr, System.Int32 id, System.Int32 order); // 0x0735c32c
	System.Boolean AddWindow(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x0735c3cc
	System.Void ShowWindow(System.String uiName, System.Boolean immediately); // 0x0735c500
	System.Void DoClearLayer(); // 0x0735c5e0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.LayerComStackCover : WizardGames.Soc.Common.Unity.Ui.LayerComBase
{
	System.Collections.Generic.Stack<WizardGames.Soc.Common.Unity.Ui.WindowComBase> winStack; // 0x2e8
	System.Collections.Generic.Stack<WizardGames.Soc.Common.Unity.Ui.WindowComBase> winStackForRemove; // 0x2f0
	System.Collections.Generic.HashSet<System.String> extraStackWins; // 0x2f8
	System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.HashSet<System.String>> extraStackRec; // 0x300
	System.String curRecoverWinName; // 0x308
	System.Int32 get_GetWindowStackCount(); // 0x0735c64c
	System.Void .ctor(WizardGames.Soc.Common.Unity.Ui.MgrUiBase uiMgr, System.Int32 id, System.Int32 order); // 0x0735c16c
	System.Boolean ShowWindowPreCheck(System.String uiName); // 0x0735c6c8
	System.Boolean HandleWinBeforeStackPush(WizardGames.Soc.Common.Unity.Ui.WindowComBase toPush, System.String newUiName, System.Boolean isExtra); // 0x0735ca70
	System.Void ShowWindow(System.String uiName, System.Boolean immediately); // 0x0735cc70
	System.Boolean IsTopWinOpen(); // 0x0735d5c4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase GetTopWinOpen(); // 0x0735d678
	System.Void DoClearLayer(); // 0x0735d71c
	System.Void DoOpenWindow(WizardGames.Soc.Common.Unity.Ui.WindowComBase win, System.Boolean immediately); // 0x0735d7b0
	System.Void HandleWinAfterStackPop(WizardGames.Soc.Common.Unity.Ui.WindowComBase toPop); // 0x0735d45c
	System.Void RecoverStackTopWindow(WizardGames.Soc.Common.Unity.Ui.WindowComBase curShowWin); // 0x0735d8c8
	System.Boolean HideWindowPreCheck(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x0735dfc0
	System.Void RemoveWindowImmediately(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x0735e110
	System.Void DoRemoveWindow(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x0735e1e8
	System.Void HideWindowDirectly(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x0735d000
	System.Collections.Generic.List<System.String> PopWinStackToBottomWin(System.Boolean popAll); // 0x0735e47c
	System.Boolean HasExitBreakWindow(); // 0x0735ed60
	System.Void HandleExtraStackWinHide(System.String curHideWin, System.String curCoverWin); // 0x0735d080
	System.Void HandleExtraStackWinRecover(System.String recoverWin); // 0x0735dcc8
	System.Void ClearAllExtraStackWins(); // 0x0735ea34
	System.Void AppendToExtraStack(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x0735f150
	System.Void RemoveFromExtraStack(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x0735f29c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.UIRegisterInfo : System.Object
{
	WizardGames.Soc.Common.Data.Ui.Window <WinInfo>k__BackingField; // 0x10
	System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <Creater>k__BackingField; // 0x18
	WizardGames.Soc.Common.Data.Ui.Window get_WinInfo(); // 0x0735f4c4
	System.Void set_WinInfo(WizardGames.Soc.Common.Data.Ui.Window value); // 0x0735f528
	System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> get_Creater(); // 0x0735f5a8
	System.Void set_Creater(System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> value); // 0x0735f60c
	System.Boolean get_IsValid(); // 0x0735f68c
	System.Void .ctor(WizardGames.Soc.Common.Data.Ui.Window winInfo, System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> creater); // 0x0735f78c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.UiLoopCache : System.Object
{
	System.Collections.Generic.List<System.Object> fpsUnlimitedUpdateList_Input; // 0x10
	System.Collections.Generic.List<System.Object> fpsUnlimitedUpdateList; // 0x18
	System.Collections.Generic.List<System.Object> fps30UpdateList; // 0x20
	System.Collections.Generic.List<System.Object> fps10UpdateList; // 0x28
	System.Collections.Generic.List<System.Object> fps2UpdateList; // 0x30
	System.Collections.Generic.List<System.Object> fps1UpdateList; // 0x38
	System.Collections.Generic.List<System.Object> listForUpdate; // 0x40
	System.Action<System.Object,System.Single> DoFpsUnlimitedUpdate_Input; // 0x48
	System.Action<System.Object,System.Single> DoFpsUnlimitedUpdate; // 0x50
	System.Action<System.Object,System.Single> DoFps30Update; // 0x58
	System.Action<System.Object,System.Single> DoFps10Update; // 0x60
	System.Action<System.Object,System.Single> DoFps2Update; // 0x68
	System.Action<System.Object,System.Single> DoFps1Update; // 0x70
	System.Void ClearAllInst(); // 0x07356814
	System.Void ClearTemp(); // 0x0735f8c8
	System.Void AppendInst(System.Object inst); // 0x07356b20
	System.Void RemoveInst(System.Object inst); // 0x07357024
	System.Collections.Generic.List<System.Object> GetLoopListInternal(System.Collections.Generic.IEnumerable<System.Object> srcList, System.Collections.Generic.List<System.Object> resList); // 0x073566a8
	System.Collections.Generic.List<System.Object> get_LoopFpsUnlimitedList_Input(); // 0x0735a610
	System.Collections.Generic.List<System.Object> get_LoopFpsUnlimitedList(); // 0x0735a504
	System.Collections.Generic.List<System.Object> get_LoopFps30List(); // 0x0735a71c
	System.Collections.Generic.List<System.Object> get_LoopFps10List(); // 0x0735a828
	System.Collections.Generic.List<System.Object> get_LoopFps2List(); // 0x0735a934
	System.Collections.Generic.List<System.Object> get_LoopFps1List(); // 0x0735ab70
	System.Void .ctor(); // 0x073573c0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.UiLoopCache.<>c : System.Object
{
	static WizardGames.Soc.Common.Unity.Ui.UiLoopCache.<>c <>9; // 0x0
	static System.Action<System.Object,System.Single> <>9__30_0; // 0x8
	static System.Action<System.Object,System.Single> <>9__30_1; // 0x10
	static System.Action<System.Object,System.Single> <>9__30_2; // 0x18
	static System.Action<System.Object,System.Single> <>9__30_3; // 0x20
	static System.Action<System.Object,System.Single> <>9__30_4; // 0x28
	static System.Action<System.Object,System.Single> <>9__30_5; // 0x30
	static System.Void .cctor(); // 0x0735f96c
	System.Void .ctor(); // 0x0735f9d0
	System.Void <.ctor>b__30_0(System.Object obj, System.Single dt); // 0x0735fa38
	System.Void <.ctor>b__30_1(System.Object obj, System.Single dt); // 0x0735fb54
	System.Void <.ctor>b__30_2(System.Object obj, System.Single dt); // 0x0735fc70
	System.Void <.ctor>b__30_3(System.Object obj, System.Single dt); // 0x0735fd8c
	System.Void <.ctor>b__30_4(System.Object obj, System.Single dt); // 0x0735fea8
	System.Void <.ctor>b__30_5(System.Object obj, System.Single dt); // 0x0735ffc4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.EscAction : System.Object
{
	
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.MgrUiBase : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.String,System.Int32> packageRefCount; // 0x18
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Unity.Ui.LayerComBase> id2Layer; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Ui.LayerComBase> allLayers; // 0x28
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Ui.UIRegisterInfo> name2UiRegisterInfos; // 0x30
	System.Collections.Generic.HashSet<System.Int32> persistentLayers; // 0x38
	System.Collections.Generic.HashSet<System.String> persistentPackages; // 0x40
	System.Int32 cachedScreenSizeVer; // 0x48
	System.Int32 foldScreenState; // 0x4c
	UnityEngine.ScreenOrientation cachedScreenOrientation; // 0x50
	System.Boolean isInClear; // 0x54
	System.Boolean removePackageWhenUIRemove; // 0x55
	System.Int32 <WinOutOfDateTime>k__BackingField; // 0x58
	System.Boolean bLoadFromAb; // 0x5c
	System.Boolean <logFguiPackRef>k__BackingField; // 0x5d
	System.Collections.Generic.HashSet<System.String> tempPackFilter; // 0x60
	System.Collections.Generic.HashSet<System.String> curLoadProxyPacks; // 0x68
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Ui.MgrUiBase.CustomPackageLoader> specialPackageLoader; // 0x70
	System.Int32 openFullScreenUIGCCount; // 0x78
	System.Collections.Generic.HashSet<System.String> disaleSceneCamRenderRecord; // 0x80
	System.Boolean disableSceneCamRendererAfterSetQuality; // 0x88
	FairyGUI.FGUIGoPool <goPool>k__BackingField; // 0x90
	System.Boolean <IsInGame>k__BackingField; // 0x98
	System.Collections.Generic.Dictionary<System.String,System.UInt32> proxyPackPostfixCheck; // 0xa0
	System.Boolean <EnableMemToPerformance>k__BackingField; // 0xa8
	System.Collections.Generic.Dictionary<System.String,System.Single> WinOpenCostRec; // 0xb0
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Ui.EscAction> EscStack; // 0xb8
	System.Boolean EnablePackageItemDynamic; // 0xc0
	System.Collections.Generic.HashSet<System.String> SkipActDebugWins; // 0xc8
	System.Collections.Generic.HashSet<System.String> WinCacheWhiteListForIOS; // 0xd0
	WizardGames.Soc.SocClient.Ui.UiActionDebugInfo <ActionDebugInfo>k__BackingField; // 0xd8
	UiLoopCostDebuger <FPS1LoopCostDebuger>k__BackingField; // 0xe0
	WizardGames.Soc.Common.Unity.Ui.MgrUiBase.EProxyPostfix ProxyPostfix; // 0xe8
	System.Int32 get_WinOutOfDateTime(); // 0x073600e0
	System.Int32 get_DesignW(); // 0x0548ba98
	System.Int32 get_DesignH(); // 0x0548ba98
	System.String get_ResPath(); // 0x054e7844
	System.String get_DefaultFont(); // 0x054e7844
	WizardGames.Soc.Common.Unity.Event.MgrMsg get_eventCenter(); // 0x054e7844
	System.Boolean get_logFguiPackRef(); // 0x07360144
	FairyGUI.FGUIGoPool get_goPool(); // 0x073601a8
	System.Void set_goPool(FairyGUI.FGUIGoPool value); // 0x0736020c
	System.Boolean get_IsInGame(); // 0x0736028c
	System.Void set_IsInGame(System.Boolean value); // 0x073602f0
	System.Boolean get_EnableMemToPerformance(); // 0x0736036c
	WizardGames.Soc.SocClient.Ui.UiActionDebugInfo get_ActionDebugInfo(); // 0x073603d0
	System.Void set_ActionDebugInfo(WizardGames.Soc.SocClient.Ui.UiActionDebugInfo value); // 0x07360434
	System.Boolean get_EnableActionDebug(); // 0x073604b4
	System.Void set_EnableActionDebug(System.Boolean value); // 0x07360564
	WizardGames.Soc.Common.Unity.Ui.EventDispatcherDebuger get_EventDispatcherDebuger(); // 0x0736075c
	System.Boolean get_EnableEventDispatcherDebuger(); // 0x07360838
	System.Void set_EnableEventDispatcherDebuger(System.Boolean value); // 0x073608d0
	UiLoopCostDebuger get_FPS1LoopCostDebuger(); // 0x07360a14
	System.Void set_FPS1LoopCostDebuger(UiLoopCostDebuger value); // 0x07360a78
	System.Boolean get_EnableFps1LoopCostDebuger(); // 0x0735aac0
	System.Void set_EnableFps1LoopCostDebuger(System.Boolean value); // 0x07360af8
	System.Void FPS1CostDebugStartCall(System.String key); // 0x07360cbc
	System.Void FPS1CostDebugEndCall(System.String key); // 0x07360da4
	System.Void Init(); // 0x07360e8c
	System.Void HookGameQualityChange(); // 0x073611b0
	System.Void EnableFGUIGoPool(System.Int32 normalSize, System.Int32 withRendererSize); // 0x07361498
	System.Void RegisterSpecialPackageLoader(); // 0x073618d0
	System.Boolean NeedRecActDebugInfo(System.String uiName); // 0x07358d84
	System.Void ClearAllWindow(System.Boolean alsoClearPersistent); // 0x07361930
	System.Threading.Tasks.Task OnEnterWorld(); // 0x07362374
	System.Threading.Tasks.Task OnExitWorld(); // 0x07362484
	System.Void CleanUp(); // 0x07362594
	WizardGames.Soc.Common.Unity.Ui.LayerComBase CreateLayer(WizardGames.Soc.Common.Unity.Ui.LayerRuler ruler, System.Int32 id, System.Int32 order, System.Boolean isPersistent, System.String desc); // 0x07362614
	WizardGames.Soc.Common.Unity.Ui.LayerComBase CreateLayer(System.Int32 ruler, System.Int32 id, System.Int32 order, System.Boolean isPersistent, System.String desc); // 0x07362b74
	WizardGames.Soc.Common.Unity.Ui.LayerComBase GetLayerByID(System.Int32 id); // 0x07362dec
	System.Void RegisterCom<T>(System.String pack, System.String com); // 0x052af1f0
	WizardGames.Soc.Common.Unity.Ui.UIRegisterInfo RegisterUI(WizardGames.Soc.Common.Data.Ui.Window winInfo); // 0x07362ec8
	WizardGames.Soc.Common.Unity.Ui.UIRegisterInfo RegisterUI(System.Func<WizardGames.Soc.Common.Unity.Ui.WindowComBase> creator, WizardGames.Soc.Common.Data.Ui.Window winInfo); // 0x07362ffc
	WizardGames.Soc.Common.Unity.Ui.UIRegisterInfo GetUIRegisterInfo(System.String uiName); // 0x07363258
	System.String GetBundleName(System.String packageName, System.String proxyPostfix); // 0x0736334c
	System.Void AddPackageRef(System.String packageName, System.String tag); // 0x07363454
	System.Boolean PackageFilter(System.String packName); // 0x07363730
	FairyGUI.UIPackage LoadPackage_DefaultAB(System.String packageName, System.String proxyPostfix); // 0x0736380c
	FairyGUI.UIPackage LoadPackage_DefaultEditor(System.String resPath, System.String packageName, System.String proxyPostfix); // 0x07363b38
	FairyGUI.UIPackage LoadOnePackageInternal(System.String packageName, System.String postfix, System.Boolean& fromCache); // 0x07363de4
	FairyGUI.UIPackage LoadOnePackage(System.String packageName, System.Boolean ignoreFilter, System.String postfix, System.String tag); // 0x07363fd0
	System.Void AddToProxyPackPostfixCheck(System.String packName, WizardGames.Soc.Common.Unity.Ui.MgrUiBase.EProxyPostfix postfix, System.Boolean res); // 0x07364ad4
	System.Boolean TryGetProxyPackPostfixCheck(System.String packName, WizardGames.Soc.Common.Unity.Ui.MgrUiBase.EProxyPostfix postfix, System.Boolean& res); // 0x07364c08
	System.Boolean TryGetPlatformProxyPackName(System.String packName, System.String& redirectName, System.String& postfix); // 0x07364344
	System.Boolean TryGetProxyPostfixOfPack(System.String packName, System.String& postfix); // 0x07364d18
	FairyGUI.UIPackage AddPackage(System.String name, System.Boolean ignoreFilter, System.String postfix, System.String tag); // 0x07364618
	System.Void SwicthBranch(); // 0x07364eb0
	System.Void ReleaseOnePackage(System.String name, System.String tag); // 0x07364fdc
	System.Void ReleasePackage(System.String name, System.String tag); // 0x073592d4
	System.Void HandleWinFullScreenLoading(WizardGames.Soc.Common.Unity.Ui.LayerComBase layer, WizardGames.Soc.Common.Unity.Ui.WindowComBase win, System.Boolean showLoading); // 0x07365518
	System.Void TryRecordToOpaqueWin(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x0735cf04
	System.Void DisableSceneCamRenderWrap(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x07365b84
	System.Void TryRemoveFromOpaqueWin(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x07366160
	System.Void RecoverSceneCamRenderWrap(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x0736625c
	System.Void HandleWinOptimization(WizardGames.Soc.Common.Unity.Ui.LayerComBase layer, WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x07366414
	System.Void RecoverWinOptimization(WizardGames.Soc.Common.Unity.Ui.LayerComBase layer, WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x07366758
	System.Void DisableSceneCamRender(UnityEngine.Camera specificCam); // 0x07365d3c
	System.Void RecoverSceneCamRender(UnityEngine.Camera specificCam); // 0x07361d28
	System.Void PreHideLayersForHideBelowOptLevel(WizardGames.Soc.Common.Unity.Ui.WindowComBase win, System.Int32 exceptLayer); // 0x07366ac8
	WizardGames.Soc.Common.Unity.Ui.WindowComBase GetWindow(System.String uiName, System.Action<WizardGames.Soc.Common.Unity.Ui.LayerComBase,WizardGames.Soc.Common.Unity.Ui.WindowComBase> dealFindCache); // 0x0735ee98
	T GetWindowT<T>(System.String uiName); // 0x052af1f0
	WizardGames.Soc.Common.Unity.Ui.LayerComBase GetLayerByUiName(System.String uiName); // 0x07366e80
	System.Void CheckAndAutoRemoveWinsOfAllLayer(WizardGames.Soc.Common.Unity.Ui.WindowComBase winExcept, System.Boolean forceGC); // 0x07366fc8
	System.Void HandleWinShowAnimFinished(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x073676ec
	System.Void HandleWinOnHideOrRemove(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x07367804
	System.UInt64 OnWindowOperationStart(System.String uiName, WizardGames.Soc.Common.Profile.EProfileFunc operation); // 0x07367910
	System.Void OnWindowOperationEnd(System.String uiName, System.UInt64 t, WizardGames.Soc.Common.Profile.EProfileFunc operation, System.String key); // 0x07367c08
	WizardGames.Soc.Common.Unity.Ui.WindowComBase OpenWindowInternal(System.String uiName, System.Action<WizardGames.Soc.Common.Unity.Ui.WindowComBase> onWinEnabled, System.Boolean immediately, WizardGames.Soc.SocClient.Manager.EUiOpenTriggerType triggerType, WizardGames.Soc.SocClient.Manager.EUiJumpSource jumpSource); // 0x073656b4
	WizardGames.Soc.Common.Unity.Ui.WindowComBase OpenWindow(System.String uiName, System.Action<WizardGames.Soc.Common.Unity.Ui.WindowComBase> onWinEnabled, System.Boolean immediately, WizardGames.Soc.SocClient.Manager.EUiOpenTriggerType triggerType, WizardGames.Soc.SocClient.Manager.EUiJumpSource jumpSource); // 0x0735defc
	T OpenWindowT<T>(System.String uiName, System.Action<T> onWinEnabled, System.Boolean immediately, WizardGames.Soc.SocClient.Manager.EUiOpenTriggerType triggerType, WizardGames.Soc.SocClient.Manager.EUiJumpSource jumpSource); // 0x052af1f0
	System.Boolean CheckWinIsInCacheWhiteList(System.String uiName); // 0x073687ec
	System.Boolean HideWindow(System.String uiName, System.Boolean immediately); // 0x0735c8bc
	System.Boolean RemoveWindow(System.String uiName, System.Boolean immediately); // 0x0735f018
	System.Boolean IsWindowOpen(System.String uiName); // 0x07368864
	System.Void OnFpsUnlimitedUpdateUI(System.Single dt); // 0x07368900
	System.Void OnFpsUnlimitedUpdateUI_Input(System.Single dt); // 0x07368c54
	System.Void OnFps30UpdateUI(System.Single dt); // 0x07368de4
	System.Void OnFps10UpdateUI(System.Single dt); // 0x07368f74
	System.Void OnFps2UpdateUI(System.Single dt); // 0x07369480
	System.Void OnFps1UpdateUI(System.Single dt); // 0x07369610
	System.Void OnLowMemory(); // 0x073697d4
	System.Boolean IsNeedAdaption(); // 0x07369190
	System.Boolean LoadWindow(System.String uiName); // 0x07367ef0
	System.Void AppendWinToFullScreenExtraStack(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x07369950
	System.Void RemoveWinFromFullScreenExtraStack(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x07369a68
	System.Collections.Generic.Dictionary<System.String,System.Single> GetWinOpenCostRec(); // 0x07369b80
	System.Void ClearWinOpenCostRec(); // 0x07369be4
	System.Void AddUIFps1CustomProfiler(System.String key, System.UInt64 start, System.Boolean cond); // 0x0736756c
	System.Void AddUICustomProfiler(System.String key, System.String uiName, System.UInt64 start, System.Boolean cond); // 0x07358f90
	System.Boolean CheckWindowUnlock(System.String uiName, System.Boolean showLockedHit); // 0x07367dfc
	System.Void RegisterAllWindow(); // 0x055049cc
	System.Void RegisterAllComs(); // 0x055049cc
	System.Void CreateAllLayers(); // 0x055049cc
	System.Void CreateCustomPopupLayer(); // 0x07369c68
	System.Void DoGamePreLoad(); // 0x07369cc8
	System.Void DoLobbyPreLoad(); // 0x07369d28
	System.Void BrforeWindowAddToStage(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x07369d88
	System.Void BrforeWindowRemoveFromStage(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x07369dfc
	System.Void OnWindowAddToStage(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x07369e70
	System.Void WindowStateChangeEvent(WizardGames.Soc.Common.Unity.Ui.WindowComBase win, System.Boolean isOpen); // 0x0736a5ec
	System.Void OnWindowRemoveFromStage(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x0736a668
	System.Boolean IsWindowPersistent(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x0736ac44
	System.Void AddEscStack(WizardGames.Soc.SocClient.Manager.EEscCloseName name, System.Func<System.Boolean> callback, System.Int32 layer, System.Boolean canAllEsc); // 0x0736acbc
	WizardGames.Soc.Common.Unity.Ui.EscAction AddEscStack(System.String uiName, System.Func<System.Boolean> callback, System.Int32 layer, System.Boolean canAllEsc); // 0x0736a550
	WizardGames.Soc.Common.Unity.Ui.EscAction RemoveEscStack(WizardGames.Soc.SocClient.Manager.EEscCloseName name); // 0x0736ad54
	WizardGames.Soc.Common.Unity.Ui.EscAction RemoveEscStack(System.String uiName); // 0x0736abcc
	System.Boolean IsTopOfEscStack(System.String uiName); // 0x0736adcc
	System.Void OnFGUIComCreated(FairyGUI.GComponent com); // 0x0736ae44
	System.Void ForEachUINode(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x0736af00
	WizardGames.Soc.Common.Data.WinOptLevel GetWinOptLevel(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x07365a6c
	System.Boolean GetCloseUpScalingMode(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x0736b0b0
	System.Boolean GetSkipFrameUpdate(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x0736b1c8
	System.Void .ctor(); // 0x0736b2e0
	static System.Void .cctor(); // 0x0736b640
	System.Void <HookGameQualityChange>b__82_0(); // 0x0736b714
	System.Void <HookGameQualityChange>b__82_1(); // 0x0736b820
	System.Threading.Tasks.Task <>n__0(); // 0x0736b930
	System.Threading.Tasks.Task <>n__1(); // 0x0736b998
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Ui.MgrUiBase.EProxyPostfix : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Ui.MgrUiBase.EProxyPostfix _PC = 0;
	static WizardGames.Soc.Common.Unity.Ui.MgrUiBase.EProxyPostfix _Mobile = 1;
	static WizardGames.Soc.Common.Unity.Ui.MgrUiBase.EProxyPostfix MAX = 16;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.MgrUiBase.CustomPackageLoader : System.Object
{
	System.Func<System.String,System.Boolean,System.String,FairyGUI.UIPackage> LoadFunc; // 0x10
	System.Func<System.String,System.Boolean,System.String,System.Boolean> CheckFunc; // 0x18
	System.Void .ctor(); // 0x0736bc58
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.MgrUiBase.<>c : System.Object
{
	static WizardGames.Soc.Common.Unity.Ui.MgrUiBase.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.Unity.Ui.LayerComBase> <>9__80_0; // 0x8
	static System.Action <>9__82_2; // 0x10
	static FairyGUI.UIPackage.LoadResource <>9__104_0; // 0x18
	static System.Void .cctor(); // 0x0736bcc0
	System.Void .ctor(); // 0x0736bd24
	System.Int32 <Init>b__80_0(WizardGames.Soc.Common.Unity.Ui.LayerComBase a, WizardGames.Soc.Common.Unity.Ui.LayerComBase b); // 0x0736bd8c
	System.Void <HookGameQualityChange>b__82_2(); // 0x0736bea0
	System.Object <LoadPackage_DefaultEditor>b__104_0(System.String name, System.String extension, System.Type type, FairyGUI.DestroyMethod& destroyMethod); // 0x0736bf04
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.MgrUiBase.<>c__95<T> : System.Object
{
	static WizardGames.Soc.Common.Unity.Ui.MgrUiBase.<>c__95<T> <>9; // 0x0
	static FairyGUI.UIObjectFactory.GComponentCreator <>9__95_0; // 0x8
	static System.Void .cctor(); // 0x054fd168
	System.Void .ctor(); // 0x055049cc
	FairyGUI.GComponent <RegisterCom>b__95_0(); // 0x054e7844
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.MgrUiBase.<>c__DisplayClass103_0 : System.Object
{
	WizardGames.Soc.Common.Unity.Ui.MgrUiBase <>4__this; // 0x10
	System.String proxyPostfix; // 0x18
	System.Void .ctor(); // 0x0736bfa8
	System.Void <LoadPackage_DefaultAB>b__0(FairyGUI.UIPackage pkg); // 0x0736c010
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.MgrUiBase.<>c__DisplayClass136_0 : System.Object
{
	System.String uiName; // 0x10
	WizardGames.Soc.SocClient.Manager.EUiOpenTriggerType triggerType; // 0x18
	WizardGames.Soc.SocClient.Manager.EUiJumpSource jumpSource; // 0x1c
	System.Single startOpenTime; // 0x20
	WizardGames.Soc.Common.Unity.Ui.MgrUiBase <>4__this; // 0x28
	System.Action<WizardGames.Soc.Common.Unity.Ui.WindowComBase> onWinEnabled; // 0x30
	System.Boolean immediately; // 0x38
	System.Void .ctor(); // 0x0736c184
	System.Void <OpenWindowInternal>b__0(WizardGames.Soc.Common.Unity.Ui.LayerComBase layer, WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x0736c1ec
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.MgrUiBase.<>c__DisplayClass138_0<T> : System.Object
{
	System.Action<T> onWinEnabled; // 0x0
	System.Void .ctor(); // 0x055049cc
	System.Void <OpenWindowT>b__0(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.MgrUiBase.<>c__DisplayClass142_0 : System.Object
{
	WizardGames.Soc.Common.Unity.Ui.MgrUiBase <>4__this; // 0x10
	System.String uiName; // 0x18
	System.Boolean immediately; // 0x20
	System.Boolean success; // 0x21
	System.Void .ctor(); // 0x0736c73c
	System.Void <HideWindow>b__0(WizardGames.Soc.Common.Unity.Ui.LayerComBase layer, WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x0736c7a4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.MgrUiBase.<>c__DisplayClass143_0 : System.Object
{
	WizardGames.Soc.Common.Unity.Ui.MgrUiBase <>4__this; // 0x10
	System.String uiName; // 0x18
	System.Boolean immediately; // 0x20
	System.Boolean success; // 0x21
	System.Void .ctor(); // 0x0736ca74
	System.Void <RemoveWindow>b__0(WizardGames.Soc.Common.Unity.Ui.LayerComBase layer, WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x0736cadc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.MgrUiBase.<>c__DisplayClass182_0 : System.Object
{
	WizardGames.Soc.Common.Unity.Ui.WindowComBase win; // 0x10
	System.Void .ctor(); // 0x0736ccbc
	System.Void <ForEachUINode>b__0(FairyGUI.GObject ctrl); // 0x0736cd24
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.MgrUiBase.<>c__DisplayClass97_0 : System.Object
{
	WizardGames.Soc.Common.Data.Ui.Window winInfo; // 0x10
	WizardGames.Soc.Common.Unity.Ui.MgrUiBase <>4__this; // 0x18
	System.Void .ctor(); // 0x0736cf08
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <RegisterUI>b__0(); // 0x0736cf70
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Ui.MgrUiBase.<OnEnterWorld>d__89 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.Common.Unity.Ui.MgrUiBase <>4__this; // 0x30
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x38
	System.Void MoveNext(); // 0x0736d0b0
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x0736d3a4
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Ui.MgrUiBase.<OnExitWorld>d__90 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.Common.Unity.Ui.MgrUiBase <>4__this; // 0x30
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x38
	System.Void MoveNext(); // 0x0736d448
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x0736d738
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.ProfileTypeDictionary : System.Object
{
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Profile.EProfileFunc> LayerIdToFpsUnlimitedUpdate; // 0x0
	static System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Profile.EProfileFunc> UiNameToFpsUnlimitedUpdate; // 0x8
	static System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Profile.EProfileFunc> UiNameToShowWindow; // 0x10
	static System.Void .cctor(); // 0x0736d7dc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.WindowComBase : FairyGUI.GComponent
{
	static SocLogger logger; // 0x0
	FairyGUI.GComponent contentPane; // 0x288
	System.Boolean hasCalledInit; // 0x290
	System.Boolean hasCalledEnable; // 0x291
	System.Boolean recDebugInfo; // 0x292
	System.Collections.Generic.HashSet<FairyGUI.Transition> anims; // 0x298
	System.Collections.Generic.Dictionary<FairyGUI.Transition,FairyGUI.PlayCompleteCallback> animCallbacks; // 0x2a0
	System.Boolean unlockContainerUpdateOnAnim; // 0x2a8
	WizardGames.Soc.Common.Unity.Ui.MgrUiBase mgr; // 0x2b0
	System.Collections.Generic.HashSet<System.String> customFlags; // 0x2b8
	System.Boolean isAtLeastShowOnce; // 0x2c0
	System.String <uiName>k__BackingField; // 0x2c8
	WizardGames.Soc.Common.Data.Ui.Window <WinInfo>k__BackingField; // 0x2d0
	System.Action<WizardGames.Soc.Common.Unity.Ui.WindowComBase> doAfterEnabled; // 0x2d8
	System.Boolean StopRemoveCountDown; // 0x2e0
	System.Single <LastHideTime>k__BackingField; // 0x2e4
	System.Single StartOpenTime; // 0x2e8
	System.Boolean CanTouchWhileAnim; // 0x2ec
	System.Boolean ChangeScreenVerOnExit; // 0x2ed
	System.Boolean autoShowGuide; // 0x2ee
	UnityEngine.AzureSky.AzureWeatherPresetEnum preTODEnum; // 0x2f0
	System.Int32 prePresetCtrl; // 0x2f4
	System.Collections.Generic.List<System.String> exceptSkyRenderList; // 0x2f8
	WizardGames.Soc.SocClient.Ui.ComTopBar comTopBar; // 0x300
	System.Boolean rootTouchable; // 0x308
	FairyGUI.GComponent <ComRoot>k__BackingField; // 0x310
	FairyGUI.GObject topBarCom; // 0x318
	System.Single factor; // 0x320
	System.Single safeAreaWidth; // 0x324
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.Event.EventDefine,System.Action> addedEventsHandler; // 0x328
	System.Collections.Generic.HashSet<FairyGUI.GObject> needCheckUnlockCtrls; // 0x330
	System.Boolean get_IsInited(); // 0x07372314
	System.String get_uiName(); // 0x07372378
	System.Void set_uiName(System.String value); // 0x073723dc
	WizardGames.Soc.Common.Data.Ui.Window get_WinInfo(); // 0x0737245c
	System.Void set_WinInfo(WizardGames.Soc.Common.Data.Ui.Window value); // 0x073724c0
	System.Single get_LastHideTime(); // 0x07372540
	System.Void set_LastHideTime(System.Single value); // 0x073725a4
	System.Boolean get_RootFairyBatch(); // 0x0737261c
	WizardGames.Soc.Common.Unity.Ui.LayerComBase get_Layer(); // 0x07372680
	System.Boolean get_IsHalfScreenWin(); // 0x073727a0
	System.Boolean get_IsAddToStage(); // 0x07372898
	System.Void set_ContentPane(FairyGUI.GComponent value); // 0x07372948
	FairyGUI.GComponent get_ContentPane(); // 0x073731a8
	FairyGUI.GComponent get_ComRoot(); // 0x0737320c
	System.Void set_ComRoot(FairyGUI.GComponent value); // 0x07373270
	FairyGUI.Container get_ContentContainer(); // 0x073732f0
	UnityEngine.GameObject get_GameObject(); // 0x073733e0
	System.Boolean get_IsValid(); // 0x073734cc
	System.Boolean get_IsActive(); // 0x0736c9a8
	System.Boolean get_IsVisible(); // 0x07373754
	System.Boolean get_IsPlayingShowAnim(); // 0x07373988
	System.Boolean get_IsPlayingHideAnim(); // 0x07373af4
	System.Boolean get_IsValidComTopBar(); // 0x07373c60
	System.Void ComTopBarExit(); // 0x07373ccc
	System.Void .ctor(); // 0x07373d44
	WizardGames.Soc.Common.Unity.Ui.WindowComBase BindMgr(WizardGames.Soc.Common.Unity.Ui.MgrUiBase uiMgr); // 0x0736d028
	System.Void DoInit(); // 0x07374064
	System.Void DoEnable(); // 0x073743e4
	System.Void DoDisable(); // 0x073745b4
	System.Void DoDestroy(); // 0x073747c8
	System.Void DoShowAnimFinish(); // 0x07374a24
	System.Void BreakInput(); // 0x07374bec
	System.Void SafeAddToStage(); // 0x07374d48
	System.Void SafeRemoveFromStage(); // 0x07375380
	System.Void OnAddedToStage(); // 0x07374edc
	System.Void OnRemoveFromStage(); // 0x07375508
	System.Void ClearAfterEnableCallback(); // 0x07375ecc
	System.Void ForceSetWindowOutOfDate(); // 0x07375f38
	System.Void SetUIBaseInfo(System.String name, WizardGames.Soc.Common.Data.Ui.Window info, FairyGUI.GComponent home); // 0x07375fec
	System.String ToString(); // 0x073761cc
	System.Void SetUITouchable(System.Boolean on); // 0x07376234
	System.Void DoWithAnimBetter(FairyGUI.Transition tween, FairyGUI.PlayCompleteCallback opt, System.Single delay); // 0x073759c0
	System.Boolean StopAnimIfPlaying(FairyGUI.Transition anim, System.Boolean setToComplete, System.Boolean processCallback); // 0x07375838
	FairyGUI.Transition GetShowAnim(); // 0x07373a28
	FairyGUI.Transition GetHideAnim(); // 0x07373b94
	System.Void SetCustomFlag(System.String[] keys); // 0x073763c0
	System.Boolean HasCustomFlag(System.String key, System.Boolean removeAfterGet); // 0x07375710
	System.Void RemoveCustomFlag(System.String key); // 0x07376514
	System.Boolean CanAutoRemove(); // 0x073765bc
	System.Boolean CheckOutOfDate(); // 0x07376698
	System.Void RefreshWinSafeArea(); // 0x073767d4
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x07376980
	System.Void TryHidePopup(); // 0x07376adc
	System.Void HideSelf(System.Boolean immediately); // 0x07376a04
	System.Void RemoveSelf(System.Boolean immediately); // 0x073752a8
	System.Void OpenSelf(System.Boolean immediately); // 0x07376b50
	System.Void SetTopmost(); // 0x07376c34
	System.Void OnInit(); // 0x07376d38
	System.Void OnEnable(); // 0x07376d98
	System.Void OnShowAnimFinish(); // 0x07376df8
	System.Void OnDisable(); // 0x07376e58
	System.Void OnDestroy(); // 0x07376eb8
	System.Void OnLayerVisibleChanged(System.Boolean layerVisible); // 0x07376f18
	System.Void OnHideByLayerStack(System.String coverUiName); // 0x07376f8c
	System.Void OnShowByLayerStack(); // 0x07377000
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x07377060
	FairyGUI.GObject GetGuideObjByID(System.Int64 id); // 0x073770d8
	FairyGUI.GObject GetGuideObjByIDArray(System.Collections.Generic.List<System.Int64> idArray); // 0x07377150
	System.Boolean CanGuideState(System.String state); // 0x073771c8
	UnityEngine.Rect GetHalfScreenHideArea(); // 0x07377240
	FairyGUI.GObject GetFillBg(System.String fillName, System.String resUrl, System.Int32 index); // 0x073773f4
	System.Void RemoveFillBg(System.String fillName); // 0x0737750c
	System.Void FillBackground(); // 0x073775bc
	System.Void CalculateMonitorRootAdaption(UnityEngine.Vector2 rootSize, UnityEngine.Vector2 rootPos, UnityEngine.Vector2& adapteSize, UnityEngine.Vector2& adaptePos); // 0x07377fb8
	System.Void SwitchWeather(); // 0x07378350
	System.Void RecoverTODOnExit(); // 0x07378960
	System.Void InitFactor(); // 0x07373148
	System.Void MakeRootScaleAdaption(System.Single factor); // 0x07378d34
	System.Void MakeMonitorRootAdaption(); // 0x07378fac
	System.Void MakeFullScreen(); // 0x073792e0
	System.Void WinPlatformInit(); // 0x0737941c
	System.Int32[] GetLodConfigInfo(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x07378860
	System.Void AddSkipHotKey(); // 0x073757d8
	System.Void RemoveSkipHotKey(); // 0x07375e6c
	System.Void SetClickAnywhere(FairyGUI.GObject clickCom, FairyGUI.GObject skipObj, FairyGUI.EventCallback1 callback, FairyGUI.GObject[] hideObjs, System.Int32 guideId, System.Boolean useAdd); // 0x0737954c
	FairyGUI.GButton GetCloseButton(FairyGUI.GObject closeObj, FairyGUI.GObject escCloseObj, System.Boolean resizeAdjust); // 0x07379664
	System.Boolean PreCheckPass(WizardGames.Soc.Common.Unity.Event.EventDefine ev); // 0x07379704
	System.Void RegisterEvent(WizardGames.Soc.Common.Unity.Event.EventDefine ev, System.Action action, System.Boolean listenWhenDisable); // 0x07379960
	System.Void RegisterEvent<T1>(WizardGames.Soc.Common.Unity.Event.EventDefine ev, System.Action<T1> action, System.Boolean listenWhenDisable); // 0x052af1f0
	System.Void RegisterEvent<T1,T2>(WizardGames.Soc.Common.Unity.Event.EventDefine ev, System.Action<T1,T2> action, System.Boolean listenWhenDisable); // 0x052af1f0
	System.Void RegisterEvent<T1,T2,T3>(WizardGames.Soc.Common.Unity.Event.EventDefine ev, System.Action<T1,T2,T3> action, System.Boolean listenWhenDisable); // 0x052af1f0
	System.Void UnregisterEvent(WizardGames.Soc.Common.Unity.Event.EventDefine ev); // 0x07379be0
	System.Void UnregisterAllEvent(); // 0x07379d14
	System.Void AddNeedCheckUnlockCtrl(FairyGUI.GObject ctrl); // 0x0736cdd4
	System.Void RemoveNeedCheckUnlockCtrl(FairyGUI.GObject ctrl); // 0x07379edc
	System.Void TraverseUINode(FairyGUI.GComponent root, System.Action<FairyGUI.GObject> checkAction); // 0x07379f88
	System.Void TryReigsterUnlockEvent(); // 0x0736c658
	System.Void HandleUnlockConditionChange(); // 0x0737a17c
	System.Void HandleUnlockSingleCtrl(FairyGUI.GObject ctrl); // 0x0737a3d8
	static System.Void .cctor(); // 0x0737a540
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.WindowComBase.<>c : System.Object
{
	static WizardGames.Soc.Common.Unity.Ui.WindowComBase.<>c <>9; // 0x0
	static System.Action<FairyGUI.TouchInfo> <>9__76_0; // 0x8
	static System.Void .cctor(); // 0x0737a614
	System.Void .ctor(); // 0x0737a678
	System.Void <BreakInput>b__76_0(FairyGUI.TouchInfo touch); // 0x0737a6e0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.WindowComBase.<>c__DisplayClass137_0 : System.Object
{
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <>4__this; // 0x10
	System.Action action; // 0x18
	WizardGames.Soc.Common.Unity.Event.EventDefine ev; // 0x20
	System.Action newCallback; // 0x28
	System.Void .ctor(); // 0x07379b78
	System.Void <RegisterEvent>b__0(); // 0x0737a784
	System.Void <RegisterEvent>b__1(); // 0x0737a810
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.WindowComBase.<>c__DisplayClass138_0<T1> : System.Object
{
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <>4__this; // 0x0
	System.Action<T1> action; // 0x0
	WizardGames.Soc.Common.Unity.Event.EventDefine ev; // 0x0
	System.Action<T1> newCallback; // 0x0
	System.Void .ctor(); // 0x055049cc
	System.Void <RegisterEvent>b__0(T1 p1); // 0x052af1f0
	System.Void <RegisterEvent>b__1(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.WindowComBase.<>c__DisplayClass139_0<T1,T2> : System.Object
{
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <>4__this; // 0x0
	System.Action<T1,T2> action; // 0x0
	WizardGames.Soc.Common.Unity.Event.EventDefine ev; // 0x0
	System.Action<T1,T2> newCallback; // 0x0
	System.Void .ctor(); // 0x055049cc
	System.Void <RegisterEvent>b__0(T1 p1, T2 p2); // 0x052af1f0
	System.Void <RegisterEvent>b__1(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.WindowComBase.<>c__DisplayClass140_0<T1,T2,T3> : System.Object
{
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <>4__this; // 0x0
	System.Action<T1,T2,T3> action; // 0x0
	WizardGames.Soc.Common.Unity.Event.EventDefine ev; // 0x0
	System.Action<T1,T2,T3> newCallback; // 0x0
	System.Void .ctor(); // 0x055049cc
	System.Void <RegisterEvent>b__0(T1 p1, T2 p2, T3 p3); // 0x052af1f0
	System.Void <RegisterEvent>b__1(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.WindowComBase.<>c__DisplayClass86_0 : System.Object
{
	WizardGames.Soc.Common.Unity.Ui.WindowComBase <>4__this; // 0x10
	FairyGUI.Transition tween; // 0x18
	System.Boolean skipFramePre; // 0x20
	System.Boolean lockFramePre; // 0x21
	System.Void .ctor(); // 0x07376358
	System.Void <DoWithAnimBetter>b__0(); // 0x0737a8a4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.ElemCache : WizardGames.Soc.Common.Unity.Ui.UiLoopCache
{
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Unity.Ui.UiEditableElem> id2Elem; // 0x78
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Unity.Ui.UiEditableElem.UiEditableElemVisibleHandler> id2ElemVisibleHandler; // 0x80
	System.Collections.Generic.List<System.Object> FillForeachList(System.Collections.Generic.List<System.Object> res); // 0x0737ab04
	System.Void ClearAllInst(); // 0x0737abc8
	System.Void AppendInst(System.Object obj); // 0x0737ac7c
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem GetElem(System.Int32 elemId); // 0x0737af34
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem.UiEditableElemVisibleHandler GetVisibleHandler(System.Int32 elemId); // 0x0737b010
	System.Void .ctor(); // 0x0737b0ec
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.UiEditable : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate_Input, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	System.Action<System.Object,System.Single> extendFps1Loop; // 0x338
	System.Collections.Generic.HashSet<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> autoDestoryNodeElems; // 0x340
	WizardGames.Soc.Common.Unity.Ui.UiEditableScheme schemeMgr; // 0x348
	FairyGUI.GComponent objElemsRoot; // 0x350
	WizardGames.Soc.Common.Unity.Ui.ElemCache elemCache; // 0x358
	System.Collections.Generic.Dictionary<System.String,System.Int32> name2Id; // 0x360
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> canAddElems; // 0x368
	System.Collections.Generic.List<System.Object> listForForeach; // 0x370
	System.Boolean elemsNotifyState; // 0x378
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem <CurEditElem>k__BackingField; // 0x380
	System.Boolean IsEditMode; // 0x388
	System.Boolean <IsInDestory>k__BackingField; // 0x389
	static System.Boolean <EnableElemCache>k__BackingField; // 0x0
	System.Boolean get_RootFairyBatch(); // 0x0737b1f8
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem get_CurEditElem(); // 0x0737b25c
	System.Void set_CurEditElem(WizardGames.Soc.Common.Unity.Ui.UiEditableElem value); // 0x0737b2c0
	System.Boolean get_IsInDestory(); // 0x0737b340
	System.Void set_IsInDestory(System.Boolean value); // 0x0737b3a4
	static System.Boolean get_EnableElemCache(); // 0x0737b420
	static System.Void set_EnableElemCache(System.Boolean value); // 0x0737b4a8
	System.Void OnInit(); // 0x0737b53c
	System.Void CheckElemCacheEnable(); // 0x0737bb40
	System.Void OnEnable(); // 0x0737bc90
	System.Void OnDisable(); // 0x0737c1dc
	System.Void OnCommonUpdate(System.Single dt, System.Collections.Generic.List<System.Object> updateList, System.Action<System.Object,System.Single> updateAction); // 0x0737c320
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x0737c6a8
	System.Void OnFpsUnlimitedUpdate_Input(System.Single dt); // 0x0737c748
	System.Void OnFps30Update(System.Single dt); // 0x0737c7e8
	System.Void OnFps10Update(System.Single dt); // 0x0737c888
	System.Void OnFps1Update(System.Single dt); // 0x0737c928
	System.Void UpdateAutoDestoryNodeElems(); // 0x0737ca94
	System.Void AppendToAutoDestory(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x0737d05c
	System.Void RemoveFromAutoDestory(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x0737d10c
	System.Void OnLayerVisibleChanged(System.Boolean layerVisible); // 0x0737d1bc
	System.Void OnDestroy(); // 0x0737d4bc
	WizardGames.Soc.Common.Unity.Ui.UiEditableScheme CreateSchemeMgr(); // 0x054e7844
	System.Void RegisterElem(System.String typeName, System.String name, System.Int32 id); // 0x0737d640
	System.Void RegisterElem(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem, System.String name, System.Int32 id); // 0x0737d738
	System.Void RegisterAllElemTypes(); // 0x055049cc
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem DoBindNode2Elem(FairyGUI.GObject objNode); // 0x0737d8a0
	System.Void CollectAndBindElems(); // 0x0737b7c0
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem GetElem(System.Int32 id); // 0x0737de24
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem GetElem(System.String name); // 0x0737dea8
	System.Void ForEachElem(System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem,System.Boolean> elemFilter, System.Action<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> elemProcessTure, System.Action<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> elemProcessFalse); // 0x0737bdd8
	System.Void SortElems(); // 0x0737b968
	System.Void OnElemSelected(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x0737dfa8
	System.Void OnElemClick(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x0737e1c4
	System.Void OnElemTouchStart(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x0737e238
	System.Void ApplyDefaultScheme(System.Int32 index); // 0x0737e2ac
	System.Void ApplyCustomScheme(System.Int32 index, System.Boolean needShowForbid); // 0x0737e514
	System.Void StartEdit(System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem,System.Boolean> elemFilter); // 0x0737e744
	System.Void HideElemInCustomMode(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x0737e934
	System.Void EndEdit(System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem,System.Boolean> elemFilter); // 0x0737ebf8
	System.Void ForeachSlave2Lead(System.Int32 slave, System.Int32 lead); // 0x0737ee40
	System.Boolean IsDirty(); // 0x0737ef10
	System.Void .ctor(); // 0x0737f258
	static System.Void .cctor(); // 0x0737f3c4
	System.Void <OnFps1Update>b__38_0(System.Object elem, System.Single dt); // 0x0737f410
	System.Void <OnDestroy>b__43_0(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x0737f574
	System.Int32 <SortElems>b__54_0(FairyGUI.GObject a, FairyGUI.GObject b); // 0x0737f9c8
	System.Void <ApplyDefaultScheme>b__59_0(System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Ui.UiEditableElemStatus> dic); // 0x0737fab0
	System.Void <StartEdit>b__62_0(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x0737fc2c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.UiEditable.<>c : System.Object
{
	static WizardGames.Soc.Common.Unity.Ui.UiEditable.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__31_0; // 0x8
	static System.Action<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__32_0; // 0x10
	static System.Action<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__62_1; // 0x18
	static System.Void .cctor(); // 0x0737fdc8
	System.Void .ctor(); // 0x0737fe2c
	System.Void <OnEnable>b__31_0(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x0737fe94
	System.Void <OnDisable>b__32_0(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x0737ff14
	System.Void <StartEdit>b__62_1(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x0737ff94
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.UiEditable.<>c__DisplayClass59_0 : System.Object
{
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Ui.UiEditableElemStatus> dic; // 0x10
	WizardGames.Soc.Common.Unity.Ui.UiEditable <>4__this; // 0x18
	System.Void .ctor(); // 0x0737fbc4
	System.Void <ApplyDefaultScheme>b__1(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x07380020
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.UiEditable.<>c__DisplayClass60_0 : System.Object
{
	WizardGames.Soc.Common.Unity.Ui.UiEditable <>4__this; // 0x10
	System.Boolean needShowForbid; // 0x18
	System.Action<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> <>9__1; // 0x20
	System.Void .ctor(); // 0x0737e6dc
	System.Void <ApplyCustomScheme>b__0(System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Ui.UiEditableElemStatus> dic); // 0x0738029c
	System.Void <ApplyCustomScheme>b__1(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x0738038c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.UiEditableElem : System.Object
{
	static SocLogger logger; // 0x0
	System.Int64 autoRemoveTimerId; // 0x10
	FairyGUI.GComponent <elemNode>k__BackingField; // 0x18
	FairyGUI.GLoader nodeLoader; // 0x20
	System.String <DynamicLoadPath>k__BackingField; // 0x28
	System.String dynamicLoadPack; // 0x30
	System.Boolean IsDynamicLoadEnable; // 0x38
	WizardGames.Soc.Common.Unity.Ui.UiEditable board; // 0x40
	System.Boolean <IsInited>k__BackingField; // 0x48
	System.Int32 <Id>k__BackingField; // 0x4c
	System.Int32 <Layer>k__BackingField; // 0x50
	System.Int32 <Order>k__BackingField; // 0x54
	System.Boolean <IsElemEnable>k__BackingField; // 0x58
	System.Boolean <CanUpdateWhenHide>k__BackingField; // 0x59
	System.Action<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> onElemShow; // 0x60
	System.Action<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> onElemHide; // 0x68
	WizardGames.Soc.Common.Data.FGUIUpdateType updateType; // 0x70
	System.Boolean CanSetUpdateMode; // 0x74
	FairyGUI.GComponent editorCom; // 0x78
	System.Boolean <KeepInstanceOnHide>k__BackingField; // 0x80
	System.Boolean IsForceHideByArea; // 0x81
	FairyGUI.GComponent editorComAnchor; // 0x88
	FairyGUI.GObject objHide; // 0x90
	FairyGUI.GObject objSelect; // 0x98
	FairyGUI.Controller ctrlEdit; // 0xa0
	FairyGUI.Transition animSelect; // 0xa8
	FairyGUI.Transition animUnSelect; // 0xb0
	FairyGUI.Transition animForbid; // 0xb8
	FairyGUI.Transition animUnForbid; // 0xc0
	System.String CustomStatusData; // 0xc8
	UnityEngine.Vector2 v2TouchStart; // 0xd0
	UnityEngine.Vector2 scaleOnInit; // 0xd8
	System.Boolean isDirty; // 0xe0
	System.Boolean <CanOption>k__BackingField; // 0xe1
	System.Boolean <CustomControl>k__BackingField; // 0xe2
	System.Boolean <IsOptionOn>k__BackingField; // 0xe3
	System.Boolean <IsInEdit>k__BackingField; // 0xe4
	System.Boolean Touchable; // 0xe5
	System.Boolean RejectRecoverStatus; // 0xe6
	FairyGUI.GComponent get_elemNode(); // 0x073806ec
	System.Void set_elemNode(FairyGUI.GComponent value); // 0x07380750
	System.String get_DynamicLoadPath(); // 0x073807d0
	System.Void set_DynamicLoadPath(System.String value); // 0x07380834
	System.String get_NodeName(); // 0x073808b4
	System.Boolean get_IsInited(); // 0x07380c94
	System.Void set_IsInited(System.Boolean value); // 0x07380cf8
	System.Int32 get_Id(); // 0x07380d74
	System.Void set_Id(System.Int32 value); // 0x07380dd8
	System.Int32 get_Layer(); // 0x07380e50
	System.Void set_Layer(System.Int32 value); // 0x07380eb4
	System.Int32 get_Order(); // 0x07380f2c
	System.Void set_Order(System.Int32 value); // 0x07380f90
	System.Int32 get_SortWeight(); // 0x07381008
	System.Boolean get_IsNodeValid(); // 0x07380a1c
	System.Boolean get_IsElemEnable(); // 0x07381104
	System.Void set_IsElemEnable(System.Boolean value); // 0x07381168
	System.Boolean get_IsGameLogicValid(); // 0x0737c5f8
	System.Void set_CanUpdateWhenHide(System.Boolean value); // 0x073811e4
	System.Boolean get_CanUpdateWhenHide(); // 0x07381260
	System.Void set_KeepInstanceOnHide(System.Boolean value); // 0x073812c4
	System.Boolean get_KeepInstanceOnHide(); // 0x07381340
	System.Void SetID(System.Int32 id); // 0x073813a4
	System.Void SetNode(WizardGames.Soc.Common.Unity.Ui.UiEditable uiBoard, FairyGUI.GComponent uiNode); // 0x07381590
	System.Void ResizeNodeLoader(System.Single width, System.Single height); // 0x0738183c
	System.Void SetNodeLoader(WizardGames.Soc.Common.Unity.Ui.UiEditable uiBoard, FairyGUI.GLoader uiNodeLoader); // 0x07381b08
	FairyGUI.GComponent TryGetNode(); // 0x0737e9e8
	FairyGUI.GLoader TryGetLoader(); // 0x07381e64
	System.Void SetUpdateMode(WizardGames.Soc.Common.Data.FGUIUpdateType update); // 0x07381ec8
	System.Void SetUpdateModeWithTypeCheck(WizardGames.Soc.Common.Data.FGUIUpdateType toSet, WizardGames.Soc.Common.Data.FGUIUpdateType typeCheck); // 0x0738179c
	System.Void SetUpdateModeIfLock(WizardGames.Soc.Common.Data.FGUIUpdateType toSet); // 0x0738201c
	System.Void ResetUpdateMode(); // 0x0738209c
	System.Boolean CreateDynamicBeforeShow(); // 0x07382104
	System.Void OnDynamicLoaded(System.Boolean isValid); // 0x0738284c
	System.Boolean InitUi(); // 0x073828c0
	System.Void SetElemShow(); // 0x07382f38
	System.Void DoShowProcess(); // 0x0738331c
	System.Void Show(); // 0x07383c6c
	System.Boolean OnShowCheck(); // 0x07383cd0
	System.Void OnShow(); // 0x07383d34
	System.Void SetElemHide(); // 0x073834c0
	System.Void DoHideProcess(); // 0x07383d94
	System.Void Hide(); // 0x07383edc
	System.Boolean OnHideCheck(); // 0x07383f40
	System.Void OnHide(); // 0x07383fa4
	System.Void DoDestory(); // 0x0737f758
	System.Void DestoryDynamicNode(); // 0x0737cd30
	System.Void CheckCtrlsNeedUnlock(FairyGUI.GObject parent); // 0x07382de0
	System.Boolean CheckCtrlsNeedUnlock_Internal(FairyGUI.GObject parent); // 0x07384004
	System.Void AddNeedCheckUnlockCtrl(FairyGUI.GObject ctrl); // 0x073841a4
	System.Void PushSelfToElemRemoveQueue(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x07384254
	System.Void DoOnElemShow(System.Action<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> callback, System.Boolean callIfAlreadyShow); // 0x07384318
	System.Void DoOnElemHide(System.Action<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> callback, System.Boolean callIfAlreadyHide); // 0x073844f4
	System.Void UnregisterElemEvent(System.Action<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> showCallback, System.Action<WizardGames.Soc.Common.Unity.Ui.UiEditableElem> hideCallback); // 0x073846d0
	System.Void SetElemBtnClick(FairyGUI.GObject btn, FairyGUI.EventCallback1 act, System.Boolean useAdd); // 0x0738482c
	System.Void HandleBoardInit(); // 0x07384a4c
	System.Void HandleBoardDestory(); // 0x07384ab0
	System.Void HandleBoardEnable(); // 0x0737d3e8
	System.Void HandleBoardDisable(); // 0x0737d458
	System.Void OnBoardInit(); // 0x07384be0
	System.Void OnBoardEnable(); // 0x07384c40
	System.Void OnBoardDisable(); // 0x07384ca0
	System.Void OnBoardDestroy(); // 0x07384d00
	System.Void OnUiCreate(FairyGUI.GComponent node); // 0x07384d60
	System.Void OnUiDestroy(); // 0x07384dd4
	System.Void OnEnable(); // 0x07384e34
	System.Void OnDisable(); // 0x07384e94
	System.Void SetScaleOnInit(System.Single scale); // 0x07384ef4
	FairyGUI.GObject get_statusTarget(); // 0x0737db80
	System.Boolean get_CanEdit(); // 0x07384fac
	System.Boolean get_CanEditBeforeShow(); // 0x07385010
	System.Boolean get_CanSetPos(); // 0x07385074
	System.Boolean get_CanOption(); // 0x073850d8
	System.Void set_CanOption(System.Boolean value); // 0x0738513c
	System.Boolean get_CustomControl(); // 0x073851b8
	System.Boolean get_IsOptionOn(); // 0x0738521c
	System.Void set_IsOptionOn(System.Boolean value); // 0x07385280
	System.Boolean get_IsShowWhenEdit(); // 0x073852fc
	System.Boolean get_IsInEdit(); // 0x07385360
	System.Void set_IsInEdit(System.Boolean value); // 0x073853c4
	System.Single get_ScaleFactor(); // 0x07385440
	System.Void SetEditNodes(); // 0x073854c0
	System.Void LoadEditEffectNodes(); // 0x07385984
	System.Void ClearEditNodes(); // 0x07385d74
	System.Void SetSelectBoxVisible(System.Boolean visible); // 0x07385e70
	System.Void SetHideBoxVisible(System.Boolean visible); // 0x0737ea94
	System.Void OnElemClick(FairyGUI.EventContext context); // 0x07385f80
	System.Void SelectEffect(System.Boolean isOn); // 0x0738602c
	System.Void OnElemEditMoveBegin(FairyGUI.EventContext context); // 0x0738616c
	System.Void OnElemEditMoving(FairyGUI.EventContext context); // 0x0738626c
	System.Void OnElemEditMoveEnd(FairyGUI.EventContext context); // 0x07386320
	System.Void OnElemEditResize(); // 0x073863f0
	System.Void StartEdit(); // 0x07386450
	System.Void SetScale(System.Single scale); // 0x07386610
	System.Single GetMaxScaleFactor(); // 0x07386720
	System.Boolean UpdateSafePosition(System.Boolean onlyCheck); // 0x07386c64
	System.Single SafePositionAjustXMin(System.Single xMin); // 0x07387940
	System.Single SafePositionAjustXMax(System.Single xMax); // 0x073879b8
	System.Single SafePositionAjustYMin(System.Single yMin); // 0x07387a30
	System.Single SafePositionAjustYMax(System.Single yMax); // 0x07387aa8
	System.Void SetPos(System.Single x, System.Single y); // 0x07387b20
	System.Void SetAlpha(System.Single alpha); // 0x07387cc0
	System.Single GetAlpha(); // 0x07387de0
	System.Void SetOptionState(System.Boolean on); // 0x07387e8c
	System.Void SetStatus(WizardGames.Soc.Common.Unity.Ui.UiEditableElemStatus status, System.Boolean reset); // 0x0738803c
	System.Void UpdateStatus(WizardGames.Soc.Common.Unity.Ui.UiEditableElemStatus status); // 0x07388178
	System.Void .ctor(); // 0x073883e0
	static System.Void .cctor(); // 0x0738848c
	System.Void <SetElemBtnClick>b__91_0(FairyGUI.EventContext ctx); // 0x07388560
	System.Void <SetElemBtnClick>b__91_1(FairyGUI.EventContext ctx); // 0x073885dc
	System.Void <SetEditNodes>b__156_0(FairyGUI.EventContext context); // 0x07388658
	System.Void <SetEditNodes>b__156_1(FairyGUI.EventContext context); // 0x073886f4
	System.Void <SetEditNodes>b__156_2(FairyGUI.EventContext context); // 0x07388790
	System.Void <SetSelectBoxVisible>b__160_0(); // 0x0738882c
	System.Void <SetHideBoxVisible>b__161_0(); // 0x073888a0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.UiEditableElem.UiEditableElemVisibleHandler : System.Object
{
	WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem; // 0x10
	System.Void .ctor(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x0737aea8
	System.Void Show(); // 0x07388914
	System.Void Hide(); // 0x07388980
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.UiEditableElemStatus : System.Object
{
	System.Int32 PosxX100; // 0x10
	System.Int32 PosyX100; // 0x14
	System.Boolean OptionOn; // 0x18
	System.Int32 ScaleX100; // 0x1c
	System.Int32 AlphaX100; // 0x20
	System.Int32 Anchor; // 0x24
	System.String CustomStatusData; // 0x28
	System.Void .ctor(); // 0x073889ec
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Ui.UiEditableScheme : System.Object
{
	System.Int32 <SchemeIndex>k__BackingField; // 0x10
	System.Int32 DefaultIndex; // 0x14
	System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Ui.UiEditableElemStatus>> defaultSchemes; // 0x18
	System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Ui.UiEditableElemStatus>> customScheme; // 0x20
	System.Int32 get_SchemeIndex(); // 0x07388a54
	System.Void set_SchemeIndex(System.Int32 value); // 0x07388ab8
	System.Void ReadDefaultConfig(); // 0x055049cc
	System.Void ReadCustomConfig(); // 0x07388b30
	System.Void WriteCustomConfig(System.Action success, System.Action error); // 0x07388b90
	System.Void CacheCustomConfig(); // 0x07388c0c
	System.Void ApplyCustomScheme(System.Int32 index, System.Action<System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Ui.UiEditableElemStatus>> process); // 0x07388c6c
	System.Void ApplyDefaultScheme(System.Int32 index, System.Action<System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Ui.UiEditableElemStatus>> process); // 0x0737e42c
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Ui.UiEditableElemStatus> GetDefaultScheme(System.Int32 index); // 0x07388dfc
	WizardGames.Soc.Common.Unity.Ui.UiEditableElemStatus GetElemStatusDefaultOnly(System.Int32 id, System.Int32 index); // 0x0737dd08
	WizardGames.Soc.Common.Unity.Ui.UiEditableElemStatus GetElemStatusCustomOnly(System.Int32 id); // 0x07388ecc
	WizardGames.Soc.Common.Unity.Ui.UiEditableElemStatus GetElemStatus(System.Int32 id); // 0x0737dc20
	System.Void .ctor(); // 0x073890f4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Pandora.PandoraMessageHandler : System.Object
{
	static SocLogger logger; // 0x0
	static System.String AutoShowId; // 0x8
	static System.Collections.Generic.Dictionary<System.String,System.Func<System.String>> getUserInfoHandlers; // 0x10
	static System.Collections.Generic.Dictionary<System.String,System.String> shareResMsg; // 0x18
	static System.Collections.Generic.Dictionary<System.String,System.String> gameEventMessage; // 0x20
	static System.Collections.Generic.Dictionary<System.String,System.String> showHideMessage; // 0x28
	static System.Collections.Generic.Dictionary<System.String,System.String> getUserInfoMessage; // 0x30
	static System.Collections.Generic.Dictionary<System.String,System.String> getNotchHeightMessage; // 0x38
	static System.Collections.Generic.Dictionary<System.String,System.String> getClipboardMessage; // 0x40
	static System.Collections.Generic.Dictionary<System.String,System.String> payResultMessageMobile; // 0x48
	static System.Boolean isSharing; // 0x50
	static System.String shareBigPicAppId; // 0x58
	static System.String shareBigPicAppName; // 0x60
	static System.Void HandleShowEntrance(System.Collections.Generic.Dictionary<System.String,System.String> message); // 0x073891a0
	static System.Void HandleOpenUrl(System.Collections.Generic.Dictionary<System.String,System.String> message); // 0x073897b0
	static System.Void HandleGoSystem(System.Collections.Generic.Dictionary<System.String,System.String> message); // 0x07389a60
	static System.Void HandleGoPandora(System.Collections.Generic.Dictionary<System.String,System.String> message); // 0x0738a0b0
	static System.Void HandleShowItemTip(System.Collections.Generic.Dictionary<System.String,System.String> message); // 0x0738a4e4
	static System.Void HandleShowRedpoint(System.Collections.Generic.Dictionary<System.String,System.String> message); // 0x0738abe0
	static System.Void HandleCloseApp(System.Collections.Generic.Dictionary<System.String,System.String> message); // 0x0738af28
	static System.Void HandleSendMessage(System.Collections.Generic.Dictionary<System.String,System.String> message); // 0x0738b048
	static System.Void HandleShare(System.Collections.Generic.Dictionary<System.String,System.String> message); // 0x0738b598
	static System.Void HandleShareArkMessageToQQInSilence(System.Collections.Generic.Dictionary<System.String,System.String> message); // 0x0738bae8
	static System.String GetInformGameShareResMessage(System.String content, System.String result, System.String shareType); // 0x0738c104
	static System.String GetInformGameEventMessage(System.String gameEvent, System.String content, System.String extend); // 0x0738c290
	static System.Void HandleGetUserInfo(System.Collections.Generic.Dictionary<System.String,System.String> message); // 0x0738c41c
	static System.Void HandleGetUserInfoResult(System.String appId, System.String content, System.String source); // 0x0738c9c8
	static System.Void ProcessUserInfoMessage(System.String[] keys, System.String appId, System.String source); // 0x0738c6c0
	static System.String GetUserExperience(); // 0x0738cb90
	static System.String GetUserName(); // 0x0738cc30
	static System.String GetRoleLevel(); // 0x0738cccc
	static System.String GetNextExperience(); // 0x0738cd6c
	static System.String GetSceneId(); // 0x0738cf40
	static System.Void HandlePlaySound(System.Collections.Generic.Dictionary<System.String,System.String> message); // 0x0738cff8
	static System.Void HandleSwitchGameBgSound(System.Collections.Generic.Dictionary<System.String,System.String> message); // 0x0738d0cc
	static System.Void HandleGetNotchHeight(System.Collections.Generic.Dictionary<System.String,System.String> message); // 0x0738d208
	static System.Void HandleGetNotchHeightResult(System.String appId, System.String content); // 0x0738d330
	static System.Void HandleShowTextTip(System.Collections.Generic.Dictionary<System.String,System.String> message); // 0x0738d46c
	static System.Void HandleShowReceivedItem(System.Collections.Generic.Dictionary<System.String,System.String> message); // 0x0738d600
	static System.Void HandleSetClipboard(System.Collections.Generic.Dictionary<System.String,System.String> message); // 0x0738dbc8
	static System.Void HandleGetClipboard(System.Collections.Generic.Dictionary<System.String,System.String> message); // 0x0738dd28
	static System.Void HandleGetClipboardResult(System.String appId, System.String content); // 0x0738de2c
	static System.Void HandleMidasPay(System.Collections.Generic.Dictionary<System.String,System.String> message); // 0x0738df68
	static System.Void MidasPayCallbackMobile(System.String appId, System.String appName, WizardGames.Soc.SDK.MidasWrapper.EPayResult result, System.String message); // 0x0738e498
	static System.Void MidasPayCallbackPC(System.String appId, System.String appName, WizardGames.Soc.SDK.MidasWrapper.EPayResult result, System.String message); // 0x0738e768
	static System.Void HandleSlideEntrance(System.Collections.Generic.Dictionary<System.String,System.String> message); // 0x0738e96c
	static System.Void OpenActCenter(System.String content); // 0x0738f078
	static System.Void HandleShareBigPic(System.Collections.Generic.Dictionary<System.String,System.String> message); // 0x0738f2d8
	static System.Void OnShareCompleted(WizardGames.Soc.SocClient.Ui.UiCommonSharePop.EShareType type); // 0x0738f934
	static System.Void OnCloseShare(); // 0x0738fd4c
	static System.Void HandleShareBigPicResult(System.String appId, System.String appName, System.String result); // 0x0738fa60
	static System.Void .cctor(); // 0x0738ff54
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Pandora.PandoraMessageHandler.<>c__DisplayClass38_0 : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RewardData> rewardDataList; // 0x10
	System.Void .ctor(); // 0x0738db60
	System.Void <HandleShowReceivedItem>b__0(WizardGames.Soc.SocClient.Ui.UiCommonRewardPop win); // 0x073907cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Pandora.PandoraMessageHandler.<>c__DisplayClass47_0 : System.Object
{
	System.String content; // 0x10
	System.Void .ctor(); // 0x0738ee00
	System.Void <HandleSlideEntrance>b__0(); // 0x07390870
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Pandora.WindowConfigParameter : System.Object
{
	System.Int32 containerType; // 0x10
	System.Void .ctor(); // 0x073908fc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Pandora.WindowConfig : System.Object
{
	WizardGames.Soc.Common.Unity.Pandora.WindowConfigParameter parameter; // 0x10
	System.Void .ctor(); // 0x07390964
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Pandora.ViewDataExtraInfo : System.Object
{
	WizardGames.Soc.Common.Unity.Pandora.WindowConfig windowConfig; // 0x10
	System.Void .ctor(); // 0x073909cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Pandora.GameletViewData : System.Object
{
	System.String appId; // 0x10
	System.String extraInfo; // 0x18
	System.Void .ctor(); // 0x07390a34
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Pandora.PandoraSettings : System.Object
{
	System.Boolean enableLog; // 0x10
	com.vasd.gamelet.PandoraEnv GetPandoraEnv(); // 0x07390a9c
	System.Void .ctor(); // 0x07390b1c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Pandora.GCloudMSDKData : System.Object
{
	System.String OpenId; // 0x10
	System.String Token; // 0x18
	System.Int32 ChannelId; // 0x20
	System.Void .ctor(); // 0x07390b8c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Pandora.PandoraBannerData : WizardGames.Soc.SocClient.Manager.CustomBannerData
{
	System.DateTime StartTime; // 0x38
	System.DateTime EndTime; // 0x40
	System.Boolean IsRegisted; // 0x48
	System.Void .ctor(); // 0x0738ee68
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Pandora.EPandoraEntryID : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Pandora.EPandoraEntryID ActivityCenter = 0;
	static WizardGames.Soc.Common.Unity.Pandora.EPandoraEntryID AutoShow = 1;
	static WizardGames.Soc.Common.Unity.Pandora.EPandoraEntryID FirstRecharge = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Pandora.PandoraWrapper : System.Object
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.Common.Unity.Pandora.PandoraSettings settings; // 0x8
	static WizardGames.Soc.Common.Unity.Pandora.PandoraWrapper instance; // 0x10
	static System.Collections.Generic.Dictionary<System.String,System.Action<System.Collections.Generic.Dictionary<System.String,System.String>>> pandoraToGameMsgHandlers; // 0x18
	static System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Data.LanguageId,System.String> pandoraToLanguageIdMap; // 0x20
	System.Collections.Generic.Dictionary<System.String,System.String> EntranceData; // 0x10
	System.Boolean isLobbyInit; // 0x18
	System.Boolean isAutoShowReady; // 0x19
	System.String actCenterAppId; // 0x20
	System.Boolean isActCenterShowReddot; // 0x28
	System.String sdkTestAppId; // 0x30
	System.Boolean isInited; // 0x38
	System.Boolean isOpened; // 0x39
	System.String msdkData; // 0x40
	UnityEngine.GameObject eventSystemGo; // 0x48
	System.Collections.Generic.Dictionary<System.String,System.String> userData; // 0x50
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> uiPandoraMapToViewNumMap; // 0x58
	System.Collections.Generic.Dictionary<System.Int32,System.String> layerTypeMap; // 0x60
	System.Collections.Generic.HashSet<System.String> activePandoraWindows; // 0x68
	System.Collections.Generic.Dictionary<System.String,System.String> openAppArgs; // 0x70
	System.Collections.Generic.List<FairyGUI.NTexture> nTextures; // 0x78
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Pandora.PandoraBannerData> bannerDataMap; // 0x80
	static System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Pandora.PandoraAppState> AppDict; // 0x28
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Data.common.OBJPandoraAppConfig> pandoraAppConfigMap; // 0x88
	static System.Collections.Generic.Dictionary<System.Int32,System.String> AccountTypeMap; // 0x30
	static WizardGames.Soc.Common.Unity.Pandora.PandoraWrapper get_Instance(); // 0x07389654
	System.Void .ctor(); // 0x07390bf4
	System.Void Init(); // 0x07390eb0
	System.Void OpenGamelet(); // 0x07391cdc
	System.Void CloseGamelet(); // 0x0739256c
	System.Void Destroy(); // 0x07392638
	System.Void Update(); // 0x07392b18
	System.Void AddBannerData(System.String bannerName, WizardGames.Soc.Common.Unity.Pandora.PandoraBannerData data); // 0x0738eed0
	System.Void OnInitLobby(); // 0x07393028
	System.Void OnDestroyLobby(); // 0x073931d8
	System.Void SetAutoShowReady(System.String autoShowId); // 0x0738972c
	System.Void AutoShowApp(System.String autoShowId); // 0x073930c4
	System.Void LoadSettings(); // 0x073917fc
	System.Void SetGCloudMSDKData(System.String json); // 0x0739323c
	System.Void RefreshUserData(WizardGames.Soc.Common.Unity.Pandora.GCloudMSDKData data); // 0x07391e88
	System.Void OnSDKMessage(System.String message); // 0x073934dc
	System.Void OnRefreshUserData(); // 0x07393824
	System.Void RefreshUserData(); // 0x07393888
	System.Void OnViewCreated(UnityEngine.GameObject gameObject, System.String data); // 0x0739398c
	System.Void OnViewAboutToDestroy(UnityEngine.GameObject gameObject, System.String data); // 0x07393d48
	System.Void OnReportData(System.String eventName, System.Collections.Generic.Dictionary<System.String,System.String> eventInfo); // 0x073944d0
	System.Void InformGameEvent(System.String gameEvent, System.String content, System.String extend); // 0x0739454c
	System.Void InformGameEvent(System.String appId, System.String gameEvent, System.String content, System.String extend); // 0x07394604
	System.Void InformGameShareRes(System.String content, System.String result, System.String shareType); // 0x073947f4
	System.Void OpenApp(System.String appId, System.String args, WizardGames.Soc.SocClient.Manager.EUiOpenTriggerType triggerType); // 0x0738f124
	System.Void OpenApp(System.String appId, System.String page, System.String jumpParams); // 0x0738a298
	System.Void CloseApp(System.String appId); // 0x07389f7c
	System.String GetPlatId(); // 0x073932bc
	System.String GetAccountType(System.Int32 msdkChannelId); // 0x07393334
	System.String GetAreaId(System.Int32 msdkChannelId); // 0x0739342c
	System.Boolean IsPandoraNeedShowReddot(WizardGames.Soc.Common.Unity.Pandora.EPandoraEntryID pandoraEntryID); // 0x07394944
	System.Boolean IsPandoraNeedShowReddot(System.String appId); // 0x07394ca0
	System.Boolean IsPandoraEntryShow(WizardGames.Soc.Common.Unity.Pandora.EPandoraEntryID pandoraEntryID); // 0x07394d8c
	System.Boolean IsPandoraEntryShow(System.String appId); // 0x07394e78
	System.Void OnClickPandoraEntry(WizardGames.Soc.Common.Unity.Pandora.EPandoraEntryID pandoraEntryID); // 0x07394fd0
	System.Void OpenPandoraEntry(System.String appId, System.String openArgs); // 0x0739506c
	System.Boolean OverrideImageLoading(System.String url, System.Int32 textureId, System.Action<com.pixui.PxDrawableAsset,System.String> onComplete); // 0x0739516c
	System.Void InitPandoraAppIds(); // 0x073918b4
	WizardGames.Soc.Common.Data.common.OBJPandoraAppConfig GetPandoraConfigByConstName(WizardGames.Soc.Common.Unity.Pandora.EPandoraEntryID pandoraEntryID); // 0x07394a44
	static System.Void .cctor(); // 0x07395774
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Pandora.PandoraAppState : System.Object
{
	System.String Name; // 0x10
	System.Boolean IsShowRedPoint; // 0x18
	System.Boolean IsReady; // 0x19
	System.Void .ctor(); // 0x073956e8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Trigger.CommonTriggerBase : UnityEngine.MonoBehaviour
{
	static SocLogger Logger; // 0x0
	System.Collections.Generic.HashSet<WizardGames.Soc.Common.Entity.IEntity> entityContents; // 0x30
	System.Boolean get_HasAnyEntityContents(); // 0x07396414
	System.Boolean InterestedInObject(WizardGames.Soc.Common.Entity.IEntity entity); // 0x0739649c
	System.Void OnDisable(); // 0x07396514
	System.Void OnObjectAdded(WizardGames.Soc.Common.Entity.IEntity entity); // 0x073968d4
	System.Void OnObjectRemoved(WizardGames.Soc.Common.Entity.IEntity entity); // 0x073969d8
	System.Void OnEntityLeave(WizardGames.Soc.Common.Entity.IEntity entity); // 0x07396a4c
	System.Void RemoveInvalidEntities(); // 0x07396b24
	System.Void OnObjects(); // 0x073973ec
	System.Void OnEmpty(); // 0x0739744c
	System.Void RemoveEntity(WizardGames.Soc.Common.Entity.IEntity ent); // 0x0739705c
	System.Void OnTriggerEnter(UnityEngine.Collider co); // 0x073974ac
	System.Void OnTriggerExit(UnityEngine.Collider co); // 0x0739751c
	System.Void OnTriggerEnterImpl(UnityEngine.Collider co); // 0x07397590
	System.Void OnEntityEnter(WizardGames.Soc.Common.Entity.IEntity entity); // 0x07397860
	System.Boolean SkipOnTriggerExit(WizardGames.Soc.Common.Entity.IEntity entity); // 0x07397b5c
	System.Void OnTriggerExitImpl(UnityEngine.Collider co); // 0x07397bd4
	System.Void OnTriggerExit(WizardGames.Soc.Common.Entity.IEntity entity); // 0x07396744
	System.Void CleanUp(); // 0x07397e9c
	System.Void .ctor(); // 0x07397efc
	static System.Void .cctor(); // 0x07397f64
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Trigger.ETriggerEventType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Trigger.ETriggerEventType NONE = 0;
	static WizardGames.Soc.Common.Unity.Trigger.ETriggerEventType MINI_GAME = 1;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Trigger.CommonTriggerEvent : WizardGames.Soc.Common.Unity.Trigger.CommonTriggerBase
{
	static SocLogger logger; // 0x0
	System.Int32 triggerId; // 0x38
	System.Int32 eventId; // 0x3c
	System.String monumentName; // 0x40
	System.Int32 monumentId; // 0x48
	WizardGames.Soc.Common.Unity.Trigger.ETriggerEventType triggerType; // 0x4c
	static WizardGames.Soc.Common.Unity.Trigger.CommonTriggerEvent CreateEventVolume(UnityEngine.Transform parent, WizardGames.Soc.Common.Data.EventVolumeData data, System.String mName, System.Int32 mId); // 0x07398038
	System.Void Init(); // 0x07398370
	System.Boolean InterestedInObject(WizardGames.Soc.Common.Entity.IEntity entity); // 0x073984f0
	System.Void OnEntityEnter(WizardGames.Soc.Common.Entity.IEntity ent); // 0x073985b0
	System.Void OnEntityLeave(WizardGames.Soc.Common.Entity.IEntity ent); // 0x07398638
	System.Void .ctor(); // 0x073986c0
	static System.Void .cctor(); // 0x07398758
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Trigger.CommonTriggerManger : WizardGames.Soc.Common.Unity.Trigger.CommonTriggerBase
{
	System.Boolean IsEmpty; // 0x38
	WizardGames.Soc.Common.Entity.IOEntity iOEntity; // 0x40
	WizardGames.Soc.Common.Unity.Go.BaseIOGo baseIOGo; // 0x48
	System.Void Init(WizardGames.Soc.Common.Entity.IOEntity iOEntity, WizardGames.Soc.Common.Unity.Go.BaseIOGo baseIO); // 0x0739882c
	System.Boolean InterestedInObject(WizardGames.Soc.Common.Entity.IEntity entity); // 0x073988c4
	System.Void OnObjects(); // 0x073989c4
	System.Void OnEntityEnter(WizardGames.Soc.Common.Entity.IEntity entity); // 0x07398a28
	System.Void OnEnable(); // 0x07398b0c
	System.Void OnDisable(); // 0x07398bdc
	System.Void OnEntityLeave(WizardGames.Soc.Common.Entity.IEntity entity); // 0x07398cb4
	System.Void OnEntityDead(WizardGames.Soc.Common.Entity.IEntity ent, WizardGames.Soc.Common.Entity.IEntity source, WizardGames.Soc.Common.SimpleCustom.DamageDataEvent damageDataEvent); // 0x07398df8
	System.Void OnEmpty(); // 0x07398ed0
	System.Void .ctor(); // 0x07398f50
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Trigger.CommonTriggerNewbieEvent : WizardGames.Soc.Common.Unity.Trigger.CommonTriggerBase
{
	static SocLogger logger; // 0x0
	static System.Int64 NEWBIE_ENTITY = -999999;
	static System.Collections.Generic.HashSet<System.Int64> specialIds; // 0x8
	System.Int32 areaBoxId; // 0x38
	WizardGames.Soc.Common.Data.ENewbieTrigger triggerType; // 0x3c
	System.Void Init(System.Int32 _areaBoxId); // 0x07398fd8
	System.Boolean InterestedInObject(WizardGames.Soc.Common.Entity.IEntity entity); // 0x07399394
	System.Void OnTriggerEnterImpl(UnityEngine.Collider co); // 0x07399454
	System.Void OnTriggerExitImpl(UnityEngine.Collider co); // 0x07399934
	System.Void OnEntityEnter(WizardGames.Soc.Common.Entity.IEntity ent); // 0x07399e14
	System.Void OnEntityLeave(WizardGames.Soc.Common.Entity.IEntity ent); // 0x07399f3c
	System.Void OnObjectEnter(UnityEngine.Collider co, System.Int64 specialCode); // 0x07399814
	System.Void OnObjectLeave(UnityEngine.Collider co, System.Int64 specialCode); // 0x07399cf4
	System.Void .ctor(); // 0x07399fc4
	static System.Void .cctor(); // 0x0739a04c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Trigger.ForceMapping : System.Object
{
	System.Int32 ForceId; // 0x10
	UnityEngine.GameObject ForceGo; // 0x18
	System.Void .ctor(); // 0x0739a1a8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Trigger.TriggerParam : UnityEngine.MonoBehaviour
{
	UnityEngine.Vector3 velocity; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Trigger.ForceMapping> ForceList; // 0x40
	System.Void .ctor(); // 0x0739a210
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Timeline.TimelineSettings : System.Object
{
	
	static System.Boolean get_IsPreviewMode(); // 0x0739a310
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Timeline.HierarchyTrackData : System.ValueType
{
	WizardGames.Soc.Common.Data.ETimelineTag Tag; // 0x10
	System.Int32 Id; // 0x14
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Timeline.ESocTrackType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Timeline.ESocTrackType Base = 0;
	static WizardGames.Soc.Common.Unity.Timeline.ESocTrackType MoveTrack = 1;
	static WizardGames.Soc.Common.Unity.Timeline.ESocTrackType AnimationTrack = 2;
	static WizardGames.Soc.Common.Unity.Timeline.ESocTrackType CameraTrack = 4;
	static WizardGames.Soc.Common.Unity.Timeline.ESocTrackType SubtitleTrack = 5;
	static WizardGames.Soc.Common.Unity.Timeline.ESocTrackType PostProcessEffectTrack = 6;
	static WizardGames.Soc.Common.Unity.Timeline.ESocTrackType EffectTrack = 7;
	static WizardGames.Soc.Common.Unity.Timeline.ESocTrackType EventTrack = 8;
	static WizardGames.Soc.Common.Unity.Timeline.ESocTrackType EventListenerTrack = 9;
	static WizardGames.Soc.Common.Unity.Timeline.ESocTrackType ControllerTrack = 10;
	static WizardGames.Soc.Common.Unity.Timeline.ESocTrackType AudioTrack = 11;
	static WizardGames.Soc.Common.Unity.Timeline.ESocTrackType HierarchyTrack = 12;
	static WizardGames.Soc.Common.Unity.Timeline.ESocTrackType CameraClipPlaneTrack = 13;
	static WizardGames.Soc.Common.Unity.Timeline.ESocTrackType ActivationTrack = 14;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Timeline.ESocClipType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Timeline.ESocClipType Base = 0;
	static WizardGames.Soc.Common.Unity.Timeline.ESocClipType MoveClip = 1;
	static WizardGames.Soc.Common.Unity.Timeline.ESocClipType AnimationClip = 2;
	static WizardGames.Soc.Common.Unity.Timeline.ESocClipType CameraFovClip = 4;
	static WizardGames.Soc.Common.Unity.Timeline.ESocClipType SubtitleClip = 5;
	static WizardGames.Soc.Common.Unity.Timeline.ESocClipType PostProcessEffectClip = 6;
	static WizardGames.Soc.Common.Unity.Timeline.ESocClipType EffectClip = 7;
	static WizardGames.Soc.Common.Unity.Timeline.ESocClipType AudioClip = 8;
	static WizardGames.Soc.Common.Unity.Timeline.ESocClipType EventClip = 9;
	static WizardGames.Soc.Common.Unity.Timeline.ESocClipType EventListenerClip = 10;
	static WizardGames.Soc.Common.Unity.Timeline.ESocClipType ControllerClip = 11;
	static WizardGames.Soc.Common.Unity.Timeline.ESocClipType HierarchyClip = 12;
	static WizardGames.Soc.Common.Unity.Timeline.ESocClipType CameraClipPlaneClip = 13;
	static WizardGames.Soc.Common.Unity.Timeline.ESocClipType ActivationClip = 14;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Timeline.EPostProcessEffectType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Timeline.EPostProcessEffectType None = 0;
	static WizardGames.Soc.Common.Unity.Timeline.EPostProcessEffectType Blink = 1;
	static WizardGames.Soc.Common.Unity.Timeline.EPostProcessEffectType BlankScreen = 2;
	static WizardGames.Soc.Common.Unity.Timeline.EPostProcessEffectType LenDistortion = 3;
	static WizardGames.Soc.Common.Unity.Timeline.EPostProcessEffectType Image = 4;
	static WizardGames.Soc.Common.Unity.Timeline.EPostProcessEffectType Dissolve = 5;
	static WizardGames.Soc.Common.Unity.Timeline.EPostProcessEffectType MotionBlur = 6;
	static WizardGames.Soc.Common.Unity.Timeline.EPostProcessEffectType RadialBlur = 7;
	static WizardGames.Soc.Common.Unity.Timeline.EPostProcessEffectType BlastWind = 8;
	static WizardGames.Soc.Common.Unity.Timeline.EPostProcessEffectType DepthOfField = 9;
	static WizardGames.Soc.Common.Unity.Timeline.EPostProcessEffectType FullScreenMaterial = 10;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Timeline.ETimelineEventType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Timeline.ETimelineEventType None = 0;
	static WizardGames.Soc.Common.Unity.Timeline.ETimelineEventType HideWeaponElem = 1;
	static WizardGames.Soc.Common.Unity.Timeline.ETimelineEventType ShowWeaponElem = 2;
	static WizardGames.Soc.Common.Unity.Timeline.ETimelineEventType ResetPlayerStatus = 3;
	static WizardGames.Soc.Common.Unity.Timeline.ETimelineEventType ShowRemoteRed = 4;
	static WizardGames.Soc.Common.Unity.Timeline.ETimelineEventType ShowRemoteGreen = 5;
	static WizardGames.Soc.Common.Unity.Timeline.ETimelineEventType ShowUIAndFireElem = 6;
	static WizardGames.Soc.Common.Unity.Timeline.ETimelineEventType HideWeapon = 7;
	static WizardGames.Soc.Common.Unity.Timeline.ETimelineEventType ChangeWeather = 8;
	static WizardGames.Soc.Common.Unity.Timeline.ETimelineEventType ShowCurtain = 9;
	static WizardGames.Soc.Common.Unity.Timeline.ETimelineEventType HideCurtain = 10;
	static WizardGames.Soc.Common.Unity.Timeline.ETimelineEventType SwitchWeapon = 11;
	static WizardGames.Soc.Common.Unity.Timeline.ETimelineEventType ShowFireBtnGuide = 12;
	static WizardGames.Soc.Common.Unity.Timeline.ETimelineEventType SoundPrint = 13;
	static WizardGames.Soc.Common.Unity.Timeline.ETimelineEventType TelescopeUI = 14;
	static WizardGames.Soc.Common.Unity.Timeline.ETimelineEventType PlaySpeedChange = 15;
	static WizardGames.Soc.Common.Unity.Timeline.ETimelineEventType LogoUI = 16;
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Timeline.TimelineEventData : System.ValueType
{
	WizardGames.Soc.Common.Unity.Timeline.ETimelineEventType EventType; // 0x10
	System.Int32 PlayerStateId; // 0x14
	System.Single PlaySpeed; // 0x18
	System.Boolean NeedFastForward; // 0x1c
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Timeline.SoundPrintData : System.ValueType
{
	System.Boolean UsingEntityId; // 0x10
	System.Int64 EntityId; // 0x18
	WizardGames.Soc.Common.Data.ETimelineTag Tag; // 0x20
	System.Int32 TagId; // 0x24
	System.String SoundEventName; // 0x28
	System.String MovingChildPath; // 0x30
	System.Boolean PlayOnce; // 0x38
	System.String SoundSwitchGroup; // 0x40
	System.String SoundSwitchState; // 0x48
	
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Timeline.ISocClipAsset : 
{
	
	WizardGames.Soc.Common.Unity.Timeline.ESocClipType get_ClipType(); // 0x0739a3d8
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Timeline.ISocTrackAsset : 
{
	
	WizardGames.Soc.Common.Unity.Timeline.ESocTrackType get_TrackType(); // 0x0739a43c
	WizardGames.Soc.Common.Data.ETimelineTag GetTag(); // 0x0739a4a0
	System.Int32 GetTagId(); // 0x0739a504
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Timeline.TimelineEventClipAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset, WizardGames.Soc.Common.Unity.Timeline.ISocClipAsset
{
	WizardGames.Soc.Common.Unity.Timeline.TimelineEventData EventData; // 0x18
	WizardGames.Soc.Common.Unity.Timeline.SoundPrintData SoundPrintData; // 0x28
	WizardGames.Soc.Common.Unity.Timeline.ESocClipType get_ClipType(); // 0x0739a568
	UnityEngine.Timeline.ClipCaps get_clipCaps(); // 0x0739a5cc
	UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner); // 0x0739a630
	System.Void .ctor(); // 0x0739a91c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Timeline.TimelineEventClipBehavior : UnityEngine.Playables.PlayableBehaviour
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.Timeline.TimelineEventData eventData; // 0x10
	WizardGames.Soc.Common.Unity.Timeline.SoundPrintData soundPrintData; // 0x20
	System.Boolean <FirstPlay>k__BackingField; // 0x60
	System.Boolean get_FirstPlay(); // 0x0739a984
	System.Void set_FirstPlay(System.Boolean value); // 0x0739a9e8
	static UnityEngine.Playables.ScriptPlayable<WizardGames.Soc.Common.Unity.Timeline.TimelineEventClipBehavior> Create(UnityEngine.Playables.PlayableGraph graph); // 0x0739a794
	System.Void Init(WizardGames.Soc.Common.Unity.Timeline.TimelineEventData data, WizardGames.Soc.Common.Unity.Timeline.SoundPrintData soundData); // 0x0739a850
	System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x0739aa64
	System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x0739b38c
	System.Void OnViewGuideChange(System.Int32 guideId); // 0x0739baa8
	System.Boolean CanPlay(); // 0x0739b288
	System.Void BehaviorPauseAction(UnityEngine.Playables.FrameData info); // 0x0739b9b4
	System.Void .ctor(); // 0x0739bb68
	static System.Void .cctor(); // 0x0739bbd8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Timeline.TimelineEventTrackAsset : UnityEngine.Timeline.TrackAsset, WizardGames.Soc.Common.Unity.Timeline.ISocTrackAsset
{
	WizardGames.Soc.Common.Data.ETimelineTag Tag; // 0xa0
	WizardGames.Soc.Common.Unity.Timeline.ESocTrackType get_TrackType(); // 0x0739bcac
	WizardGames.Soc.Common.Data.ETimelineTag GetTag(); // 0x0739bd10
	UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount); // 0x0739bd74
	System.Void .ctor(); // 0x0739be70
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Timeline.TimelineEventTrackBehavior : UnityEngine.Playables.PlayableBehaviour
{
	
	System.Void .ctor(); // 0x0739befc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Systems.WeaponSpreadSystem : System.Object, WizardGames.Soc.Common.Systems.IUserCmdSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Combat.Shoot.MgrShootFormula mgrShootFormula; // 0x10
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x0739bf64
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x0739c034
	System.Single UpdateAdsSpread(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.Combat.Shoot.GunSpreadParameter shootParameter, WizardGames.Soc.Common.CustomType.WeaponCustom weaponCustom, System.Single spreadScale, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x0739c920
	System.Single UpdateShootSpread(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.Combat.Shoot.GunSpreadParameter shootParameter, WizardGames.Soc.Common.CustomType.WeaponCustom weaponCustom, System.Single spreadScale, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x0739c6ec
	System.Boolean InMovingMountale(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x0739cf4c
	System.Single UpdateMoveSpread(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.Combat.Shoot.GunSpreadParameter shootParameter, System.Single moveSpread, System.Single spreadScale, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x0739c460
	System.Void OnDestroy(); // 0x0739d2b8
	System.Void .ctor(); // 0x0739d318
	static System.Void .cctor(); // 0x0739d380
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Systems.BaseHeldItemThrowSystem : System.Object, WizardGames.Soc.Common.Systems.IUserCmdSystem, WizardGames.Soc.Common.Systems.ISystem
{
	
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x0739d454
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x0739d4c8
	System.Void OnDestroy(); // 0x0739e1e4
	System.Void .ctor(); // 0x0739e244
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Systems.BaseThrowWeaponUseSystem : System.Object, WizardGames.Soc.Common.Systems.IUserCmdSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger logger; // 0x0
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x0739e2ac
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x0739e320
	System.Void OnDestroy(); // 0x0739fd80
	System.Void .ctor(); // 0x0739fde0
	static System.Void .cctor(); // 0x0739fe48
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Systems.EHeldItemExecutePhase : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Systems.EHeldItemExecutePhase CheckStay = 0;
	static WizardGames.Soc.Common.Unity.Systems.EHeldItemExecutePhase End = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Systems.EHeldItemBehaviourType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Systems.EHeldItemBehaviourType Empty = 0;
	static WizardGames.Soc.Common.Unity.Systems.EHeldItemBehaviourType Equip = 1;
	static WizardGames.Soc.Common.Unity.Systems.EHeldItemBehaviourType ADS = 2;
	static WizardGames.Soc.Common.Unity.Systems.EHeldItemBehaviourType Bolt = 3;
	static WizardGames.Soc.Common.Unity.Systems.EHeldItemBehaviourType Fire = 4;
	static WizardGames.Soc.Common.Unity.Systems.EHeldItemBehaviourType Reload = 5;
	static WizardGames.Soc.Common.Unity.Systems.EHeldItemBehaviourType Inspect = 6;
	static WizardGames.Soc.Common.Unity.Systems.EHeldItemBehaviourType Throw = 7;
	static WizardGames.Soc.Common.Unity.Systems.EHeldItemBehaviourType Hold = 8;
	static WizardGames.Soc.Common.Unity.Systems.EHeldItemBehaviourType MeleeAttack = 9;
	static WizardGames.Soc.Common.Unity.Systems.EHeldItemBehaviourType Use = 10;
	static WizardGames.Soc.Common.Unity.Systems.EHeldItemBehaviourType CCUpdate = 11;
	static WizardGames.Soc.Common.Unity.Systems.EHeldItemBehaviourType End = 12;
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Systems.HeldItemExecuteResult : System.ValueType
{
	System.Boolean bSuccess; // 0x10
	System.Nullable<System.Int32> NextState; // 0x14
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Systems.HeldItemExecuteParams : System.ValueType
{
	WizardGames.Soc.Common.Unity.Systems.EHeldItemBehaviourType BehaviourType; // 0x10
	WizardGames.Soc.Common.Unity.Systems.EHeldItemExecutePhase PhaseType; // 0x14
	WizardGames.Soc.Common.Weapon.ERunFrameType FrameType; // 0x18
	WizardGames.Soc.Common.Weapon.ERunServerType ServerType; // 0x1c
	WizardGames.Soc.Common.Contexts.Context CurrentContext; // 0x20
	WizardGames.Soc.Common.SimpleCustom.UserCmd CurrentCmd; // 0x28
	WizardGames.Soc.Common.Entity.PlayerEntity CurrentPlayer; // 0x30
	WizardGames.Soc.Common.Entity.IHeldItemEntity CurrentWeapon; // 0x38
	WizardGames.Soc.Common.Data.holdItem.MeleeBase CurrentMeleeTable; // 0x40
	WizardGames.Soc.Common.Data.Throw.ThrowWeapon CurrentThrowWeaponTable; // 0x48
	WizardGames.Soc.Common.Data.gun.GunBase CurrentGunTable; // 0x50
	WizardGames.Soc.Common.Data.bullet.BulletBase CurrentBulletTable; // 0x58
	WizardGames.Soc.Common.Data.holdItem.HoldItemBase CurrentItemTable; // 0x60
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Systems.HeldItemSystemUtils : System.Object
{
	static SocLogger logger; // 0x0
	static System.Boolean IsControlByNewWeaponSys(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams playerLogicParams); // 0x0739ff1c
	static System.Boolean IsBow(System.Int64 tableID); // 0x0739ffa8
	static System.Boolean IsBow(WizardGames.Soc.Common.Unity.Defines.TableItemEnum itemType); // 0x073a0044
	static System.Boolean IsPaddle(System.Int64 tableID); // 0x073a00b0
	static System.Boolean IsParachute(System.Int64 tableID); // 0x073a0128
	static System.Boolean IsWoodenHammer(System.Int64 tableID); // 0x073a0198
	static WizardGames.Soc.Common.Entity.IHeldItemEntity FindCurrentHeldItem(WizardGames.Soc.Common.Contexts.Context CurrentCtx, WizardGames.Soc.Common.Entity.PlayerEntity CurPlayerEntity); // 0x0739e150
	static System.Boolean BuildPhaseParamsFromLogic(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams LogicParams, WizardGames.Soc.Common.Unity.Systems.EHeldItemBehaviourType BehaviourType, WizardGames.Soc.Common.Unity.Systems.EHeldItemExecutePhase Phase, WizardGames.Soc.Common.Unity.Systems.HeldItemExecuteParams& OutExecuteParams); // 0x073a020c
	static System.Void SetNormalResult(WizardGames.Soc.Common.Unity.Systems.HeldItemExecuteResult& OutResult, System.Boolean bSuccess); // 0x073a0f24
	static System.Void SetCameraAnimationType(WizardGames.Soc.Common.Entity.PlayerEntity CurrentPlayer, System.String CameraAnimationType); // 0x073a0fa0
	static System.Boolean ClientReloadWorkbenchCheck(WizardGames.Soc.Common.Entity.PlayerEntity Player, WizardGames.Soc.Common.CustomType.WeaponCustom Weapon, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, System.Boolean showTip); // 0x073a1264
	static System.Boolean ReloadWorkbenchCheck(WizardGames.Soc.Common.Entity.PlayerEntity Player, WizardGames.Soc.Common.CustomType.WeaponCustom Weapon, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x073a140c
	static System.Void .cctor(); // 0x073a174c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Systems.MgrWeapon : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Systems.MgrWeapon.WeaponGoAndAniLoadFlag> myWaitFinishDicFp; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Systems.MgrWeapon.WeaponGoAndAniLoadFlag> myWaitFinishDicTp; // 0x20
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Systems.MgrWeapon.WeaponGoAndAniLoadFlag> waitFinishDicTp; // 0x28
	System.Void .ctor(); // 0x073a1820
	System.Void Init(); // 0x073a1928
	System.Threading.Tasks.Task OnEnterWorld(); // 0x073a1988
	System.Threading.Tasks.Task OnExitWorld(); // 0x073a1a80
	static System.Void .cctor(); // 0x073a1b90
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Systems.MgrWeapon.WeaponGoAndAniLoadFlag : System.ValueType
{
	System.Int64 ItemId; // 0x10
	System.Boolean WeaponGo; // 0x18
	System.Boolean PlayerAni; // 0x19
	System.Boolean weaponAni; // 0x1a
	System.Boolean weaponAniUpdate; // 0x1b
	WizardGames.Soc.Common.Unity.Systems.MgrWeapon.WeaponFinishPara WeaponGoFinishPara; // 0x20
	System.Action<WizardGames.Soc.Common.Unity.Systems.MgrWeapon.WeaponFinishPara> WeaponGoCallBack; // 0xb8
	WizardGames.Soc.Common.Unity.Systems.MgrWeapon.WeaponFinishPara PlayerAniFinishPara; // 0xc0
	System.Action<WizardGames.Soc.Common.Unity.Systems.MgrWeapon.WeaponFinishPara> WeaponAniCallBack; // 0x158
	WizardGames.Soc.Common.Unity.Systems.MgrWeapon.WeaponFinishPara WeaponGoUnLoadFinishPara; // 0x160
	System.Action<WizardGames.Soc.Common.Unity.Systems.MgrWeapon.WeaponFinishPara> WeaponGoUnLoadCallBack; // 0x1f8
	System.Action<WizardGames.Soc.Common.Unity.Systems.MgrWeapon.WeaponFinishPara> WeaponClipAnCtrlCallBack; // 0x200
	WizardGames.Soc.Common.Unity.Systems.MgrWeapon.WeaponFinishPara WeaponAniFinishPara; // 0x208
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Systems.MgrWeapon.WeaponFinishPara : System.ValueType
{
	System.String WeaponHandName; // 0x10
	System.String WeaponLocatorName; // 0x18
	WizardGames.Soc.Common.Entity.IHeldItemEntity HeldItemEntity; // 0x20
	WizardGames.Soc.Common.Entity.IBaseMountableEntity MountableEntity; // 0x28
	WizardGames.Soc.Common.Entity.PlayerEntity PlayerEntity; // 0x30
	UnityEngine.AnimatorOverrideController AOverrideController; // 0x38
	WizardGames.Soc.Common.Entity.IItemEntity ItemEntity; // 0x40
	WizardGames.Soc.Common.Unity.Go.BaseEntityGo EntityGo; // 0x48
	WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent WeaponPointComponent; // 0x50
	WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent PlayerGoPoint; // 0x58
	UnityEngine.Animator weaponanimator; // 0x60
	UnityEngine.AnimatorOverrideController weaponanimatorController; // 0x68
	System.Int32 frame; // 0x70
	System.Int64 EntityId; // 0x78
	System.Int64 CurrentSkinId; // 0x80
	System.Int64 CurrentWeaponId; // 0x88
	System.Int64 CurrentWeaponTableId; // 0x90
	WizardGames.Soc.Common.Weapon.ShowEquipPos ShowEquipPos; // 0x98
	System.Action<System.Int64,WizardGames.Soc.Common.Weapon.ShowEquipPos> MyTpGoCallBack; // 0xa0
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Systems.MgrWeapon.<OnEnterWorld>d__8 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	System.Void MoveNext(); // 0x073a1c24
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x073a1cb8
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Systems.MgrWeapon.<OnExitWorld>d__9 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.Common.Unity.Systems.MgrWeapon <>4__this; // 0x30
	System.Void MoveNext(); // 0x073a1d5c
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x073a1f00
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Systems.HorseAnimatorRenderSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer mgrMyPlayer; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.HorseEntity> horseEntities; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.HorseEntity> localHorseEntities; // 0x20
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x073a1fa4
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x073a2008
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x073a2174
	System.Void ProcessAnimation(WizardGames.Soc.Common.Entity.HorseEntity entity, WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime); // 0x073a2488
	System.Boolean IsAnimatorInitialized(WizardGames.Soc.Common.Unity.Animation.ISocAnimationRuntime animator); // 0x073a26b4
	WizardGames.Soc.Common.Unity.Horse.AnimatorHorseContext CreateAnimatorContext(WizardGames.Soc.Common.Entity.HorseEntity entity, WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Unity.Animation.ISocAnimationRuntime animator); // 0x073a28b4
	System.Void OnDestroy(); // 0x073a2aa0
	System.Void .ctor(); // 0x073a2b00
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Systems.ParachuteAnimatorRenderSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer mgrMyPlayer; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.ParachuteEntity> parachuteEntities; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.ParachuteEntity> localParachuteEntities; // 0x20
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x073a2b68
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x073a2bcc
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x073a2d38
	System.Void BindTie(WizardGames.Soc.Common.Entity.ParachuteEntity entity, WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime); // 0x073a3364
	System.Void ProcessAnimation(WizardGames.Soc.Common.Entity.ParachuteEntity entity, WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime); // 0x073a3144
	System.Boolean IsAnimatorInitialized(WizardGames.Soc.Common.Unity.Animation.ISocAnimationRuntime animator); // 0x073a3614
	WizardGames.Soc.Common.Unity.Utility.Parachute.Animation.AnimatorParachuteContext CreateAnimatorContext(WizardGames.Soc.Common.Entity.ParachuteEntity entity, WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Unity.Animation.ISocAnimationRuntime animator); // 0x073a3814
	System.Void OnDestroy(); // 0x073a3910
	System.Void .ctor(); // 0x073a3970
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Systems.PlayerFpAnimatorRenderSystem : System.Object, WizardGames.Soc.Common.Systems.IBaseSystem, WizardGames.Soc.Common.Systems.ISystem
{
	SocLogger logger; // 0x10
	WizardGames.Soc.Common.Synchronization.MgrTime mgrTime; // 0x18
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer mgrMyPlayer; // 0x20
	WizardGames.Soc.SocClient.Go.MgrEntityGo mgrEntityGo; // 0x28
	WizardGames.Soc.Common.Unity.Character.BlendTree2dSimpleDirectional JogStandPoseBT2D; // 0x30
	WizardGames.Soc.Common.Unity.Character.BlendTree2dSimpleDirectional JogCrouchPoseBT2D; // 0x38
	WizardGames.Soc.Common.Utility.SpringDamper DampingX; // 0x40
	WizardGames.Soc.Common.Utility.SpringDamper DampingY; // 0x48
	WizardGames.Soc.Common.Utility.SpringDamper DampingZ; // 0x50
	WizardGames.Soc.Common.Unity.Character.AnimParametersFp animParametersFp; // 0x58
	System.Single leftSpeed; // 0x18c
	System.Boolean isReviewFinish; // 0x190
	CommonUnity.Runtime.Animation.AnimMoveSpeedLocalCacheGroup MoveSpeedLocalCaches; // 0x194
	CommonUnity.Runtime.Animation.AnimMoveSpeedConfGroup MoveSpeedConfList; // 0x248
	Unity.Collections.NativeArray<CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConfGroup> MatchRules; // 0x3d8
	System.Boolean inited; // 0x3e8
	Unity.Collections.NativeArray<WizardGames.Soc.Common.Character.FpMaskWeightConfGroup> maskArray; // 0x3f0
	WizardGames.Soc.Common.Profile.EProfileFunc get_ProfileFuncEnum(); // 0x073a39d8
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05523a54
	System.Void OnLeaveReviewAction(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x073a4420
	System.Void OnDestroy(); // 0x055049cc
	static CommonUnity.Runtime.Animation.AnimMoveSpeedConf GetFpMoveSpeedConf(System.Int32 tableId, System.Int32 skinId, CommonUnity.Runtime.Animation.AnimMoveEnum moveEnum); // 0x073a45c0
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, System.Int32 deltaTime, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x05526948
	System.Void DefaultFpAniBoneMask(WizardGames.Soc.Common.Character.FpAniBoneMask& fpAniBoneMask); // 0x073a63b8
	static System.Boolean RefreshLadderData(WizardGames.Soc.Common.Entity.PlayerEntity curPlayer, WizardGames.Soc.Common.Unity.Character.AnimatorContext& animatorContext); // 0x073a5e18
	System.Void SetMaskWeight(WizardGames.Soc.Common.Character.FpAniBoneMask& aniBoneMask, WizardGames.Editor.SkeletonMaskWeightValue[] weightDics); // 0x073a62c4
	System.Void .ctor(); // 0x073a6440
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Systems.Weapon.BowPhaseHeldItemSystem : System.Object
{
	static SocLogger logger; // 0x0
	static System.Action<WizardGames.Soc.Common.Entity.PlayerBowStateEnum> PlayAimAnim; // 0x8
	static System.Void OnADSCheckStay(WizardGames.Soc.Common.Unity.Systems.HeldItemExecuteParams& UpdateParams, WizardGames.Soc.Common.Unity.Systems.HeldItemExecuteResult& OutResult); // 0x073a64f8
	static System.Void UpdateADSProgress(WizardGames.Soc.Common.Unity.Systems.HeldItemExecuteParams UpdateParams, System.Boolean bInADS); // 0x073a6948
	static System.Void OnFireCheckStay(WizardGames.Soc.Common.Unity.Systems.HeldItemExecuteParams& UpdateParams, WizardGames.Soc.Common.Unity.Systems.HeldItemExecuteResult& OutResult); // 0x073a6ebc
	static System.Void OnEmptyCheckStay(WizardGames.Soc.Common.Unity.Systems.HeldItemExecuteParams& UpdateParams, WizardGames.Soc.Common.Unity.Systems.HeldItemExecuteResult& OutResult); // 0x073a7ed0
	static System.Void SetBowState(WizardGames.Soc.Common.Entity.PlayerEntity CurPlayer, WizardGames.Soc.Common.Entity.PlayerBowStateEnum state); // 0x073a6b2c
	static System.Void ResetBowWeaponData(WizardGames.Soc.Common.Entity.PlayerEntity CurPlayer, WizardGames.Soc.Common.CustomType.WeaponCustom CurrentWeapon, WizardGames.Soc.Common.Unity.Contexts.UnityContext CurUnityCtx); // 0x073a791c
	static System.Void CheckBowDrawTrigger(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x073a8d40
	static System.Void ReloadInterrupt(WizardGames.Soc.Common.Entity.PlayerEntity CurPlayer, WizardGames.Soc.Common.CustomType.WeaponCustom CurrentWeapon, WizardGames.Soc.Common.Unity.Contexts.UnityContext CurUnityCtx); // 0x073a8910
	static System.Boolean CanCharge(WizardGames.Soc.Common.Unity.Systems.HeldItemExecuteParams& UpdateParams); // 0x073a8b68
	static System.Boolean CanCharge(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams& p); // 0x073a8e00
	static System.Boolean IsInCharge(WizardGames.Soc.Common.Entity.PlayerEntity player); // 0x073a6e1c
	static System.Void GetScale(WizardGames.Soc.Common.Unity.Systems.HeldItemExecuteParams& UpdateParams, System.Single drawProgress, System.Single chargeProgress, WizardGames.Soc.Common.CustomType.WeaponCustom weapon); // 0x073a89a4
	static System.Void Clear(); // 0x073a91b4
	static System.Void .cctor(); // 0x073a9240
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Systems.Weapon.CommonHeldItemSystem : System.Object
{
	static SocLogger logger; // 0x0
	static System.Boolean CanBreak(WizardGames.Soc.Common.Unity.Systems.HeldItemExecuteParams& UpdateParams, WizardGames.Soc.Common.Unity.Systems.HeldItemExecuteResult& OutResult); // 0x073a7714
	static WizardGames.Soc.Common.Entity.PlayerActionStateReloadEnum CheckNextReloadState(WizardGames.Soc.Common.Unity.Systems.HeldItemExecuteParams& UpdateParams); // 0x073aa014
	static System.Boolean CanReload(WizardGames.Soc.Common.Unity.Systems.HeldItemExecuteParams& UpdateParams); // 0x073a7a4c
	static System.Boolean CanReloadLoopContinue(WizardGames.Soc.Common.Entity.IHaveBulletEntity weapon); // 0x073aa4ac
	static System.Boolean CanSwitch(WizardGames.Soc.Common.Unity.Systems.HeldItemExecuteParams& UpdateParams); // 0x073a9314
	static WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.ClipState CurrentClipState(WizardGames.Soc.Common.Entity.IHaveBulletEntity CurrentWeapon); // 0x073aa83c
	static WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.ReloadState CurrentReloadState(WizardGames.Soc.Common.Entity.IHaveBulletEntity CurrentWeapon, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x073aa58c
	static System.Boolean CanFire(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.Entity.IHeldItemEntity helditem, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, System.Int32 interval, System.Int32 clientTime); // 0x054e0ec0
	static WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.FireState CurrentFireState(WizardGames.Soc.Common.Entity.IHaveBulletEntity CurrentWeapon, System.Int32 interval, System.UInt32 clientTime); // 0x0739d054
	static System.Boolean HasFireCmd(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x073aa984
	static System.Single RefreshStateTime(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams playerLogicParams, System.Single[] animBuffer); // 0x073aaae0
	static System.Single RefreshStateTime(WizardGames.Soc.Common.Entity.PlayerEntity entity, WizardGames.Soc.Common.Entity.IHeldItemEntity heldItem, System.Single[] animBuffer); // 0x073aaba4
	static System.Boolean CanHoldInMantle(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x073ab1f0
	static System.Int32 ReShowTypeInMantle(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x073ab298
	static System.Void .cctor(); // 0x073ab340
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Systems.Weapon.CommonRiflePhaseHeldItemSystem : System.Object
{
	static SocLogger logger; // 0x0
	static System.Void DoReload(WizardGames.Soc.Common.Entity.IHaveBulletEntity CurrentWeapon, WizardGames.Soc.Common.Entity.PlayerEntity Player, WizardGames.Soc.Common.SimpleCustom.UserCmd Cmd, WizardGames.Soc.Common.Unity.HeldItem.IWeaponClipHandle WeaponClipHandle); // 0x073ab95c
	static System.Void GetReloadEmptyStateTime(WizardGames.Soc.Common.Entity.IHaveBulletEntity currentWeapon, WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x073abdd8
	static System.Void .cctor(); // 0x073ac138
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Systems.UserCmdSystem.InteractiveChangeListenSystem : System.Object, WizardGames.Soc.Common.Systems.IUserCmdSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger logger; // 0x0
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x05523a54
	static System.Void OnInteractiveChange(WizardGames.Soc.Common.Entity.PlayerEntity entity, System.Int32 newId); // 0x073ac324
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x073ac41c
	System.Void OnDestroy(); // 0x055049cc
	System.Void .ctor(); // 0x073ac5b8
	static System.Void .cctor(); // 0x073ac620
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Systems.UserCmdSystem.MeleeAttackSystem : System.Object, WizardGames.Soc.Common.Systems.IUserCmdSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.Contexts.UnityContext UnityContext; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.HitRequest> hitCandidates; // 0x18
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x073ac6f4
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x0552e1cc
	System.Void OnDestroy(); // 0x073ad134
	System.Void CollectHit(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, UnityEngine.Vector3 origin, UnityEngine.Vector3 shoot_dir, WizardGames.Soc.Common.Entity.MeleeAttackRequest mp, WizardGames.Soc.Common.Contexts.Context context, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.HitRequest>& candidates); // 0x0552cac0
	System.Void ProcessHit(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Entity.MeleeAttackRequest mp, WizardGames.Soc.Common.Contexts.Context context, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.HitRequest> candidates); // 0x0552ce28
	System.Void .ctor(); // 0x073ad194
	static System.Void .cctor(); // 0x073ad248
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Systems.UserCmdSystem.PlayerCureSystem : System.Object, WizardGames.Soc.Common.Systems.IUserCmdSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.Contexts.UnityContext UnityContext; // 0x10
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x073ad31c
	System.Void OnDestroy(); // 0x073ad41c
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x073ad47c
	System.Void .ctor(); // 0x073ad968
	static System.Void .cctor(); // 0x073ad9d0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Systems.UserCmdSystem.PlayerHeldItemConsumeSystem : System.Object, WizardGames.Soc.Common.Systems.IUserCmdSystem, WizardGames.Soc.Common.Systems.ISystem
{
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.IConditionConsumeEntity> consumes; // 0x10
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x073adaa4
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x073adb74
	System.Void OnDestroy(); // 0x073adc78
	System.Void .ctor(); // 0x073adcd8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Systems.UserCmdSystem.WeaponFireEndSystem : System.Object, WizardGames.Soc.Common.Systems.IUserCmdSystem, WizardGames.Soc.Common.Systems.ISystem
{
	
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x073add40
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x073addb4
	System.Void OnDestroy(); // 0x073ae040
	System.Void .ctor(); // 0x073ae0a0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Systems.UserCmdSystem.WeaponFireSystem : System.Object, WizardGames.Soc.Common.Systems.IUserCmdSystem, WizardGames.Soc.Common.Systems.ISystem
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Combat.Shoot.IShootFormula shootFormula; // 0x10
	WizardGames.Soc.Common.Combat.Shoot.MgrShootFormula mgrShootFormula; // 0x18
	WizardGames.Soc.Common.Unity.Contexts.UnityContext UnityContext; // 0x20
	System.Single clearRecoilPitch; // 0x28
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x073ae108
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x0552e1cc
	System.Void OnDestroy(); // 0x073b019c
	System.Void .ctor(); // 0x073b01fc
	static System.Void .cctor(); // 0x073b0264
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Systems.UserCmdSystem.WeaponLateSystem : System.Object, WizardGames.Soc.Common.Systems.IUserCmdSystem, WizardGames.Soc.Common.Systems.ISystem
{
	
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x073b0338
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x073b03ac
	System.Void OnDestroy(); // 0x073b0500
	System.Void .ctor(); // 0x073b0560
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Systems.UserCmdSystem.WeaponPreSystem : System.Object, WizardGames.Soc.Common.Systems.IUserCmdSystem, WizardGames.Soc.Common.Systems.ISystem
{
	
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x073b05c8
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x073b0724
	System.Void OnDestroy(); // 0x073b07bc
	System.Void .ctor(); // 0x073b081c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Systems.UserCmdSystem.MyHeldItemConditionSystem : System.Object, WizardGames.Soc.Common.Systems.IUserCmdSystem, WizardGames.Soc.Common.Systems.ISystem
{
	WizardGames.Soc.Common.DataSet.CommonDataSet<Share.Common.ObjPool.Alpha3PooledObjectBase> itemEntityConditionSet; // 0x10
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer myPlayer; // 0x18
	System.Void OnCreate(WizardGames.Soc.Common.Contexts.Context context); // 0x073b0884
	System.Void OnUpdate(WizardGames.Soc.Common.Contexts.Context context, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld); // 0x073b0978
	System.Void OnDestroy(); // 0x073b0e44
	System.Void .ctor(); // 0x073b0ea4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Synchronization.MessagePack : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	static System.Boolean serializerRegistered; // 0x8
	static System.Void Initialize(); // 0x073b0f0c
	System.Void .ctor(); // 0x073b1238
	static System.Void .cctor(); // 0x073b12a0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Synchronization.PlayerDebugger : System.Object
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.Common.Unity.Synchronization.PlayerDebugger <Instance>k__BackingField; // 0x8
	static WizardGames.Soc.Common.Unity.Synchronization.PlayerDebugger get_Instance(); // 0x073b1384
	System.Void .ctor(); // 0x073b140c
	System.Void SwitchSnapshot(WizardGames.Soc.Common.Synchronization.SnapshotIncremental snapshot, System.Int64 myEntityId); // 0x073b1474
	System.Boolean ContainsPlayerMovement(System.Int64 myEntityId, System.Boolean& my, System.Boolean& other); // 0x073b1734
	static System.Void .cctor(); // 0x073b1aa4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Synchronization.SnapshotReceiverDebugger : System.Object
{
	static SocLogger logger; // 0x0
	System.Void .ctor(); // 0x073b1b9c
	static System.Void .cctor(); // 0x073b1c04
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Scene.SceneName : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Scene.SceneName None = 0;
	static WizardGames.Soc.Common.Unity.Scene.SceneName Login = 1;
	static WizardGames.Soc.Common.Unity.Scene.SceneName Hall = 2;
	static WizardGames.Soc.Common.Unity.Scene.SceneName GameSpace = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Scene.SceneLoadingStatus : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Scene.SceneLoadingStatus NotStarted = 0;
	static WizardGames.Soc.Common.Unity.Scene.SceneLoadingStatus Loading = 1;
	static WizardGames.Soc.Common.Unity.Scene.SceneLoadingStatus LoadCompleted = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Scene.MgrScene : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.Scene.SceneName curScene; // 0x14
	System.Int32 <GameSpaceSceneId>k__BackingField; // 0x18
	System.Action<System.String> BeforeEnterGameSceneFunc; // 0x20
	System.Action OnGameSceneReadyFunc; // 0x28
	System.Action BeforeExitGameSceneFunc; // 0x30
	System.Action AfterExitGameSceneFunc; // 0x38
	System.Action OnLobbySceneReadyFunc; // 0x40
	System.Action OnSceneLoadFinishFunc; // 0x48
	WizardGames.Soc.Common.Unity.Scene.SceneLoadingStatus <LoadingStatus>k__BackingField; // 0x50
	System.Action<System.String,System.Single> onSetLoadHind; // 0x58
	System.Func<System.Int32,System.String> textTranslater; // 0x60
	WizardGames.Soc.Common.Unity.Scene.SceneName changingScene; // 0x68
	WizardGames.Soc.Common.Unity.Scene.SceneName get_CurScene(); // 0x073b1cd8
	System.Void set_CurScene(WizardGames.Soc.Common.Unity.Scene.SceneName value); // 0x073b1d3c
	System.Int32 get_GameSpaceSceneId(); // 0x073b1db4
	System.Void set_GameSpaceSceneId(System.Int32 value); // 0x073b1e18
	WizardGames.Soc.Common.Unity.Scene.SceneLoadingStatus get_LoadingStatus(); // 0x073b1e90
	System.Void set_LoadingStatus(WizardGames.Soc.Common.Unity.Scene.SceneLoadingStatus value); // 0x073b1ef4
	System.Boolean get_IsChangingScenen(); // 0x073b1f6c
	System.Void Init(); // 0x073b1fd8
	System.Void SetLoadingHintWithKey(System.Int32 key, System.Single progress, System.String[] vals); // 0x073b2108
	WizardGames.Soc.Common.Unity.Scene.SceneConfig GetSceneConfig(WizardGames.Soc.Common.Unity.Scene.SceneName scene); // 0x073b2214
	static System.Void UnLoadSceneBundleFile(WizardGames.Soc.Common.Unity.Scene.SceneConfig cfg); // 0x073b2554
	static WizardGames.Soc.Common.Unity.AssetBundleMgr.SocAssetBundleAdapter get_bundleAdapterLoader(); // 0x073b28c4
	static System.Threading.Tasks.Task<System.ValueTuple<System.Boolean,System.String>> LoadSceneBundleFile(WizardGames.Soc.Common.Unity.Scene.SceneConfig cfg); // 0x073b2a6c
	static System.Threading.Tasks.Task<System.Boolean> LoadConfigScene(System.String mainSceneName); // 0x073b2bb0
	System.Threading.Tasks.Task WorldLoadComplete(); // 0x073b2cf4
	System.Void ChangeSceneDummy(); // 0x073b2e04
	System.Threading.Tasks.Task ShowLoadingScene(); // 0x073b2e84
	static System.Boolean IsLoadLocalMap(); // 0x073b2f94
	System.Threading.Tasks.Task UnloadCurScene(); // 0x073b2ff0
	System.Boolean IsAlreadyInScene(WizardGames.Soc.Common.Unity.Scene.SceneName scene); // 0x073b3104
	System.Void ClearChangeingScene(); // 0x073b31dc
	System.Threading.Tasks.Task<System.ValueTuple<System.Boolean,System.String>> ChangeSceneAsync(WizardGames.Soc.Common.Unity.Scene.SceneName scene); // 0x073b3240
	System.Void .ctor(); // 0x073b339c
	static System.Void .cctor(); // 0x073b340c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Scene.MgrScene.<>c : System.Object
{
	static WizardGames.Soc.Common.Unity.Scene.MgrScene.<>c <>9; // 0x0
	static Protocol.Load.BundleLoadProgress <>9__37_0; // 0x8
	static Protocol.Load.BundleLoadProgress <>9__44_0; // 0x10
	static System.Void .cctor(); // 0x073b34e0
	System.Void .ctor(); // 0x073b3544
	System.Void <LoadSceneBundleFile>b__37_0(System.UInt64 bundle, System.Single progress); // 0x073b35ac
	System.Void <ShowLoadingScene>b__44_0(System.UInt64 bundle, System.Single progress); // 0x073b36e0
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Scene.MgrScene.<ChangeSceneAsync>d__50 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.ValueTuple<System.Boolean,System.String>> <>t__builder; // 0x18
	WizardGames.Soc.Common.Unity.Scene.SceneName scene; // 0x30
	WizardGames.Soc.Common.Unity.Scene.MgrScene <>4__this; // 0x38
	WizardGames.Soc.Common.Unity.Scene.SceneConfig <cfgNow>5__2; // 0x40
	System.Boolean <bLoadLocalMap>5__3; // 0x48
	System.String <sName>5__4; // 0x50
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x58
	System.DateTime <unloadTimeout>5__5; // 0x60
	System.Runtime.CompilerServices.TaskAwaiter<System.ValueTuple<System.Boolean,System.String>> <>u__2; // 0x68
	UnityEngine.AsyncOperation <op>5__6; // 0x70
	System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__3; // 0x78
	System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__4; // 0x80
	System.Void MoveNext(); // 0x073b37bc
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x073b5aa0
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Scene.MgrScene.<LoadConfigScene>d__40 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder; // 0x18
	System.String mainSceneName; // 0x30
	System.String <configSceneName>5__2; // 0x38
	UnityEngine.AsyncOperation <loadingOp>5__3; // 0x40
	System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1; // 0x48
	System.Void MoveNext(); // 0x073b5b58
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x073b62d0
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Scene.MgrScene.<LoadSceneBundleFile>d__37 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.ValueTuple<System.Boolean,System.String>> <>t__builder; // 0x18
	WizardGames.Soc.Common.Unity.Scene.SceneConfig cfg; // 0x30
	System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.AssetBundle> <>u__1; // 0x38
	System.Void MoveNext(); // 0x073b6388
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x073b68a8
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Scene.MgrScene.<ShowLoadingScene>d__44 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.Common.Unity.Scene.MgrScene <>4__this; // 0x30
	UnityEngine.AsyncOperation <loadingOp>5__2; // 0x38
	System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.AssetBundle> <>u__1; // 0x40
	System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__2; // 0x48
	System.Void MoveNext(); // 0x073b6960
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x073b71e4
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Scene.MgrScene.<UnloadCurScene>d__46 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.Common.Unity.Scene.MgrScene <>4__this; // 0x30
	WizardGames.Soc.Common.Unity.Scene.SceneConfig <cfg>5__2; // 0x38
	System.String <cSceneName>5__3; // 0x40
	UnityEngine.AsyncOperation <unloadOp>5__4; // 0x48
	System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1; // 0x50
	System.Runtime.CompilerServices.TaskAwaiter <>u__2; // 0x58
	System.Void MoveNext(); // 0x073b7288
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x073b7de4
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Scene.MgrScene.<WorldLoadComplete>d__41 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.Common.Unity.Scene.MgrScene <>4__this; // 0x30
	System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1; // 0x38
	System.Void MoveNext(); // 0x073b7e88
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x073b8194
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Scene.SceneConfigData : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Scene.SceneConfig> SceneConfigs; // 0x10
	System.Void .ctor(); // 0x073b8238
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Scene.SceneConfig : System.Object
{
	System.Int32 Id; // 0x10
	System.String SceneName; // 0x18
	System.String ScenePath; // 0x20
	System.String SceneNameGPUDriven; // 0x28
	System.Boolean IsInAssetBundle; // 0x30
	System.Boolean IsInMapAssetBundle; // 0x31
	System.String AssetBundleFileName; // 0x38
	System.String AssetBundleFileNameGPUDriven; // 0x40
	System.String Desc; // 0x48
	System.Boolean HaveConfigScene; // 0x50
	System.Boolean ShouldUnloadAssetBundleAfterLoad; // 0x51
	System.String[] preloadAssetClient; // 0x58
	System.String[] preloadGoInPoolClient; // 0x60
	System.Int32[] preloadItemIdClient; // 0x68
	System.String GetSceneName(); // 0x073b27c8
	System.String GetAssetBundleFileName(); // 0x073b2970
	System.Boolean IsLoadFromAssetBundle(); // 0x073b82a0
	System.Void .ctor(); // 0x073b8304
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Scene.SceneConfigManager : System.Object
{
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Unity.Scene.SceneConfig> SceneInfoMap; // 0x0
	static System.Void Init(); // 0x073b2044
	static System.Void SetConfig(WizardGames.Soc.Common.Unity.Scene.SceneConfigData config); // 0x073b8374
	static WizardGames.Soc.Common.Unity.Scene.SceneConfig GetSceneConfig(System.Int32 id); // 0x073b248c
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Scene.SceneConfigManager.<Init>d__2 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.TextAsset> <>u__1; // 0x38
	System.Void MoveNext(); // 0x073b8600
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x073b88cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.ObjPool.MidApi : System.Object
{
	
	static T Get<T>(System.UInt64 inId); // 0x052af1f0
	static System.Void Free(System.UInt64 inId); // 0x073b0d6c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.AnimationClipNode : WizardGames.Soc.Common.Unity.Playable.AnimationNode
{
	UnityEngine.AnimationClip clip; // 0xe0
	System.Boolean playAutomatic; // 0xe8
	System.Boolean canLoop; // 0xe9
	System.Boolean forceUpdate; // 0xea
	WizardGames.Soc.Common.Unity.Playable.OperationData operationData; // 0xf0
	WizardGames.Soc.Common.Unity.Playable.PlayableNode Instantiate(UnityEngine.Playables.PlayableGraph playableGraph, WizardGames.Soc.Common.Unity.Playable.PlayableController playableController, WizardGames.Soc.Common.Unity.Playable.PlayableNode parentPlayableNode); // 0x073b894c
	WizardGames.Soc.Common.Unity.Playable.NodeWithOperationValue GetConnectNodeOperationValueDic(); // 0x073b8c34
	System.Collections.Generic.Dictionary<System.String,System.Int32> GetAllConnectClipNodes(); // 0x073b8f20
	System.String GetOperationType(); // 0x073b8e40
	System.String GetOperationValue(); // 0x073b8eb0
	System.String GetParameter1D(); // 0x073b8ff0
	System.String[] GetParameter2D(); // 0x073b9054
	System.Void .ctor(); // 0x073b9120
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.AnimationLayerMixerNode : WizardGames.Soc.Common.Unity.Playable.AnimationNode
{
	WizardGames.Soc.Common.Unity.Playable.AnimationNode[] inputs; // 0xe0
	System.Void OnInputChanged(); // 0x073b9218
	WizardGames.Soc.Common.Unity.Playable.PlayableNode Instantiate(UnityEngine.Playables.PlayableGraph playableGraph, WizardGames.Soc.Common.Unity.Playable.PlayableController playableController, WizardGames.Soc.Common.Unity.Playable.PlayableNode parentPlayableNode); // 0x073b93f0
	WizardGames.Soc.Common.Unity.Playable.NodeWithOperationValue GetConnectNodeOperationValueDic(); // 0x073b99f8
	System.Collections.Generic.Dictionary<System.String,System.Int32> GetAllConnectClipNodes(); // 0x073b9d9c
	System.String GetParameter1D(); // 0x073ba3a8
	System.String[] GetParameter2D(); // 0x073ba518
	System.Void .ctor(); // 0x073ba738
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.AnimationLayerMixerNode.<>c__DisplayClass4_0 : System.Object
{
	System.Collections.Generic.Dictionary<System.String,System.Int32> dic; // 0x10
	System.Func<System.Collections.Generic.KeyValuePair<System.String,System.Int32>,System.Boolean> <>9__0; // 0x18
	System.Void .ctor(); // 0x073ba2ac
	System.Boolean <GetAllConnectClipNodes>b__0(System.Collections.Generic.KeyValuePair<System.String,System.Int32> item); // 0x073ba79c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.AnimationMixerNode : WizardGames.Soc.Common.Unity.Playable.AnimationNode
{
	WizardGames.Soc.Common.Unity.Playable.AnimationNode[] inputs; // 0xe0
	System.Void OnInputChanged(); // 0x073ba858
	WizardGames.Soc.Common.Unity.Playable.PlayableNode Instantiate(UnityEngine.Playables.PlayableGraph playableGraph, WizardGames.Soc.Common.Unity.Playable.PlayableController playableController, WizardGames.Soc.Common.Unity.Playable.PlayableNode parentPlayableNode); // 0x073ba9c4
	WizardGames.Soc.Common.Unity.Playable.NodeWithOperationValue GetConnectNodeOperationValueDic(); // 0x073bafc4
	System.Collections.Generic.Dictionary<System.String,System.Int32> GetAllConnectClipNodes(); // 0x073bb514
	System.String GetParameter1D(); // 0x073bba34
	System.String[] GetParameter2D(); // 0x073bbb38
	System.Void .ctor(); // 0x073bbce0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.AnimationMixerNode.<>c__DisplayClass3_0 : System.Object
{
	WizardGames.Soc.Common.Unity.Playable.NodeWithOperationValue dic; // 0x10
	System.Func<System.String,System.Boolean> <>9__0; // 0x18
	System.Void .ctor(); // 0x073bb4ac
	System.Boolean <GetConnectNodeOperationValueDic>b__0(System.String itemKey); // 0x073bbd44
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.AnimationMixerNode.<>c__DisplayClass4_0 : System.Object
{
	System.Collections.Generic.Dictionary<System.String,System.Int32> dic; // 0x10
	System.Func<System.Collections.Generic.KeyValuePair<System.String,System.Int32>,System.Boolean> <>9__0; // 0x18
	System.Void .ctor(); // 0x073bb9cc
	System.Boolean <GetAllConnectClipNodes>b__0(System.Collections.Generic.KeyValuePair<System.String,System.Int32> item); // 0x073bbdf4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.AnimationNode : XNode.Node
{
	System.String nodeName; // 0x30
	WizardGames.Soc.Common.Unity.Playable.MixerType subMixType; // 0x38
	WizardGames.Soc.Common.Unity.Playable.MixerType nowMixType; // 0x3c
	System.Single transitionTime; // 0x40
	System.String subBleed1D; // 0x48
	System.String bleed1D; // 0x50
	System.Single bleedParameter1D; // 0x58
	System.String subBleed2DX; // 0x60
	System.String subBleed2DY; // 0x68
	System.String bleed2DX; // 0x70
	System.String bleed2DY; // 0x78
	UnityEngine.Vector2 bleedParameter2D; // 0x80
	System.Single weight; // 0x88
	System.Single speed; // 0x8c
	UnityEngine.AvatarMask avatarMask; // 0x90
	System.Boolean additive; // 0x98
	WizardGames.Soc.Common.Unity.Playable.AnimationNode output; // 0xa0
	System.Boolean boolTrigger; // 0xa8
	System.String boolName; // 0xb0
	System.Boolean boolValue; // 0xb8
	WizardGames.Soc.Common.Unity.Playable.NodeWithOperationValue _operationValueValueDic; // 0xc0
	System.Collections.Generic.Dictionary<System.String,System.Int32> _connectClipNodes; // 0xc8
	System.String _curParameter1D; // 0xd0
	System.String[] _curParameter2D; // 0xd8
	WizardGames.Soc.Common.Unity.Playable.NodeWithOperationValue get_OperationValueValueDic(); // 0x073b9d0c
	System.Collections.Generic.Dictionary<System.String,System.Int32> get_ConnectClipNodes(); // 0x073ba314
	System.String get_CurParameter1D(); // 0x073bbeb0
	System.String[] get_CurParameter2D(); // 0x073bbf4c
	System.Object GetValue(XNode.NodePort port); // 0x073bbfe8
	System.Void OnInputChanged(); // 0x073b9384
	System.Void OnCreateConnection(XNode.NodePort from, XNode.NodePort to); // 0x073bc060
	System.Void OnRemoveConnection(XNode.NodePort port); // 0x073bc0e8
	WizardGames.Soc.Common.Unity.Playable.PlayableNode Instantiate(UnityEngine.Playables.PlayableGraph playableGraph, WizardGames.Soc.Common.Unity.Playable.PlayableController playableController, WizardGames.Soc.Common.Unity.Playable.PlayableNode parentPlayableNode); // 0x073bc168
	WizardGames.Soc.Common.Unity.Playable.NodeWithOperationValue GetConnectNodeOperationValueDic(); // 0x073bc388
	System.Collections.Generic.Dictionary<System.String,System.Int32> GetAllConnectClipNodes(); // 0x073bc414
	System.Boolean HaveBoolTrigger(); // 0x073bc4b4
	System.String GetParameter1D(); // 0x073bc518
	System.String[] GetParameter2D(); // 0x073bc590
	System.Void .ctor(); // 0x073b9184
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.AnimationOutputNode : XNode.Node
{
	WizardGames.Soc.Common.Unity.Playable.AnimationNode[] inputs; // 0x30
	System.Void OnInputChanged(); // 0x073bc670
	System.Void OnCreateConnection(XNode.NodePort from, XNode.NodePort to); // 0x073bc7d4
	System.Void OnRemoveConnection(XNode.NodePort port); // 0x073bc854
	WizardGames.Soc.Common.Unity.Playable.PlayableOutputNode Instantiate(UnityEngine.Playables.PlayableGraph playableGraph, UnityEngine.Animator animator, WizardGames.Soc.Common.Unity.Playable.PlayableController playableController); // 0x073bc8cc
	System.Void .ctor(); // 0x073bcf70
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.AnimationValueNode : XNode.Node
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Playable.OperationValue> operationValues; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Playable.BoolType> boolValue; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Playable.ParameterType> parameter; // 0x40
	System.Object GetValue(XNode.NodePort port); // 0x073bcffc
	System.Collections.Generic.List<System.String> GetAllOperationTypes(); // 0x073bd074
	System.Void .ctor(); // 0x073bd1d0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.AnimationValueNode.<>c : System.Object
{
	static WizardGames.Soc.Common.Unity.Playable.AnimationValueNode.<>c <>9; // 0x0
	static System.Func<WizardGames.Soc.Common.Unity.Playable.OperationValue,System.String> <>9__4_0; // 0x8
	static System.Void .cctor(); // 0x073bd25c
	System.Void .ctor(); // 0x073bd2c0
	System.String <GetAllOperationTypes>b__4_0(WizardGames.Soc.Common.Unity.Playable.OperationValue item); // 0x073bd328
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.PlayableController : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.Playable.PlayableOverride playableOverride; // 0x30
	UnityEngine.Animator animator; // 0x38
	System.Boolean playAutomatic; // 0x40
	System.Boolean unityUpdate; // 0x41
	UnityEngine.Playables.PlayableGraph _playableGraph; // 0x48
	WizardGames.Soc.Common.Unity.Playable.PlayableNodeGraph _playableNodeGraph; // 0x58
	WizardGames.Soc.Common.Unity.Playable.PlayableOutputNode _playableOutputNode; // 0x60
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Playable.AnimationNode> _allNodes; // 0x68
	System.Collections.Generic.Dictionary<System.String,System.Boolean> _triggerBool; // 0x70
	System.Collections.Generic.Dictionary<System.String,System.Single> _parameters; // 0x78
	System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,System.Boolean>> _operationValues; // 0x80
	System.Collections.Generic.Dictionary<System.String,UnityEngine.AnimationClip> _allClipNodes; // 0x88
	System.Collections.Generic.Dictionary<System.String,System.String> _currentValue; // 0x90
	UnityEngine.Vector2 _tempParameters; // 0x98
	System.Boolean _isPlaying; // 0xa0
	System.Collections.Generic.Dictionary<System.String,System.String> get_CurrentValue(); // 0x073bd3a8
	System.Void Start(); // 0x073bd40c
	System.Void StartPlayableController(WizardGames.Soc.Common.Unity.Playable.PlayableOverride playableOverride, UnityEngine.Animator animator); // 0x073bd610
	System.Void InitPlayableController(); // 0x073bd4e8
	System.Void InitPlayableGraph(System.String playableName); // 0x073bd6b0
	System.Void InitPlayableValues(); // 0x073bd734
	System.Void CreateOutputNode(); // 0x073be194
	System.Void StartPlayable(); // 0x073be2c4
	System.Void SetCurrentOperationValue(System.String type, System.String value, System.Boolean needForceUpdate); // 0x073be7ac
	System.Boolean GetOperationValueNeedForce(System.String type, System.String value); // 0x073bea18
	System.Void SetOperationValueNeedForce(System.String type, System.String value, System.Boolean needForceUpdate); // 0x073be8bc
	System.Void SetParameterValue(System.String parameterName, System.Single value); // 0x073beb5c
	System.Void SetBoolValue(System.String boolName, System.Boolean value); // 0x073bec50
	System.Boolean IsExistBoolValue(System.String boolName); // 0x073bed18
	System.Boolean GetBoolValue(System.String boolName); // 0x073bedb4
	System.Single GetParametersValue(System.String parameterName); // 0x073bee74
	UnityEngine.Vector2 GetParametersValue(System.String[] parameterName); // 0x073bef50
	System.Boolean HaveClipNode(System.String nodeName); // 0x073bf09c
	UnityEngine.AnimationClip GetClipNodeClip(System.String nodeName); // 0x073bf138
	System.Void SetSpeed(System.String nodeName, System.Single speed); // 0x073bf214
	System.Single GetClipLength(System.String nodeName); // 0x073bf2fc
	System.Void UpdateGraphLogic(System.Int32 nowTick, System.Single deltaTime); // 0x073bf4f8
	System.Void ApplyPresentationState(System.Int32 nowTick, System.Single deltaTime); // 0x073bf74c
	System.Void Destroy(); // 0x073bfb6c
	System.Void .ctor(); // 0x073bfd70
	static System.Void .cctor(); // 0x073bfdd8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.PlayableClipNode : WizardGames.Soc.Common.Unity.Playable.PlayableNode
{
	System.Single _time; // 0x70
	System.Boolean _needForceUpdate; // 0x74
	System.Void .ctor(WizardGames.Soc.Common.Unity.Playable.AnimationNode animationNode, UnityEngine.Playables.PlayableGraph playableGraph, WizardGames.Soc.Common.Unity.Playable.PlayableController playableController, WizardGames.Soc.Common.Unity.Playable.PlayableNode parentPlayableNode); // 0x073b8a20
	System.Void UpdatePresentationState(System.Boolean firstUpdate, System.Int32 nowTick, System.Single deltaTime); // 0x073bfeac
	System.Void ApplyPresentationState(System.Int32 nowTick, System.Single deltaTime); // 0x073c01dc
	System.Void Shutdown(); // 0x073c0708
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.PlayableLayerMixerNode : WizardGames.Soc.Common.Unity.Playable.PlayableNode
{
	System.String _curOperationValue; // 0x70
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> _curOperationValueIndex; // 0x78
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> _curNonOperationValueIndex; // 0x80
	System.String _lastOperationValueString; // 0x88
	System.Single animPhase1D; // 0x90
	System.Single blendedClipLength1D; // 0x94
	System.Single animPhase2D; // 0x98
	System.Single blendedClipLength2D; // 0x9c
	System.Boolean _inMixer; // 0xa0
	System.Boolean _firstUpdate; // 0xa1
	System.String _cacheLastOperationValueString; // 0xa8
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> _cacheFirstUpdate; // 0xb0
	System.Void .ctor(WizardGames.Soc.Common.Unity.Playable.AnimationNode animationNode, UnityEngine.Playables.PlayableGraph playableGraph, WizardGames.Soc.Common.Unity.Playable.PlayableController playableController, WizardGames.Soc.Common.Unity.Playable.PlayableNode parentPlayableNode); // 0x073b94c4
	System.Void UpdatePresentationState(System.Boolean firstUpdate, System.Int32 nowTick, System.Single deltaTime); // 0x073c093c
	System.Void ApplyPresentationState(System.Int32 nowTick, System.Single deltaTime); // 0x073c18d0
	System.Void Shutdown(); // 0x073c26d8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.PlayableMixerNode : WizardGames.Soc.Common.Unity.Playable.PlayableNode
{
	System.Int32 _curOperationValueIndex; // 0x70
	System.Int32 _perOperationValueIndex; // 0x74
	System.String _lastOperationValueString; // 0x78
	System.Single animPhase1D; // 0x80
	System.Single blendedClipLength1D; // 0x84
	System.Single animPhase2D; // 0x88
	System.Single blendedClipLength2D; // 0x8c
	System.Boolean _inMixer; // 0x90
	System.Boolean _firstUpdate; // 0x91
	System.String _cacheLastOperationValueString; // 0x98
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> _cacheFirstUpdate; // 0xa0
	System.Void .ctor(WizardGames.Soc.Common.Unity.Playable.AnimationNode animationNode, UnityEngine.Playables.PlayableGraph playableGraph, WizardGames.Soc.Common.Unity.Playable.PlayableController playableController, WizardGames.Soc.Common.Unity.Playable.PlayableNode parentPlayableNode); // 0x073baa98
	System.Void UpdatePresentationState(System.Boolean firstUpdate, System.Int32 nowTick, System.Single deltaTime); // 0x073c27d4
	System.Void ApplyPresentationState(System.Int32 nowTick, System.Single deltaTime); // 0x073c3208
	System.Void Shutdown(); // 0x073c395c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.PlayableNode : System.Object
{
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Unity.Playable.PlayableNode> connectPlayableNodes; // 0x10
	WizardGames.Soc.Common.Unity.Playable.MixerType mixerType; // 0x18
	WizardGames.Soc.Common.Unity.Playable.SimpleTransition<UnityEngine.Playables.Playable> simpleTransition; // 0x20
	WizardGames.Soc.Common.Unity.Playable.BleedTree1D bleedTree1D; // 0x28
	WizardGames.Soc.Common.Unity.Playable.BlendTree2DSimpleDirectional bleedTree2D; // 0x30
	WizardGames.Soc.Common.Unity.Playable.AnimationNode animationNode; // 0x38
	UnityEngine.Playables.Playable animationPlayable; // 0x40
	WizardGames.Soc.Common.Unity.Playable.PlayableController playableController; // 0x50
	WizardGames.Soc.Common.Unity.Playable.PlayableNode parentPlayableNode; // 0x58
	UnityEngine.Playables.PlayableGraph _playableGraph; // 0x60
	System.Void .ctor(WizardGames.Soc.Common.Unity.Playable.AnimationNode animationNode, UnityEngine.Playables.PlayableGraph playableGraph, WizardGames.Soc.Common.Unity.Playable.PlayableController playableController, WizardGames.Soc.Common.Unity.Playable.PlayableNode parentPlayableNode); // 0x073bc23c
	System.Void InitMixerType(); // 0x073c07b4
	System.Void UpdatePresentationState(System.Boolean firstUpdate, System.Int32 nowTick, System.Single deltaTime); // 0x073c4220
	System.Void Shutdown(); // 0x073c42b0
	System.Void GetPlayableOutput(System.Int32 portId, UnityEngine.Playables.Playable& playable, System.Int32& playablePort); // 0x073c4310
	System.Void ApplyPresentationState(System.Int32 nowTick, System.Single deltaTime); // 0x073c43ac
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.PlayableOutputNode : System.Object
{
	UnityEngine.Animations.AnimationPlayableOutput _animationPlayableOutput; // 0x10
	UnityEngine.Animations.AnimationLayerMixerPlayable _animationLayerMixer; // 0x20
	WizardGames.Soc.Common.Unity.Playable.AnimationOutputNode _animationOutputNode; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Playable.PlayableNode> _playableDefaultNodesLayers; // 0x38
	WizardGames.Soc.Common.Unity.Playable.PlayableController _playableController; // 0x40
	System.Void .ctor(WizardGames.Soc.Common.Unity.Playable.AnimationOutputNode animationOutputNode, UnityEngine.Playables.PlayableGraph playableGraph, UnityEngine.Animator animator, WizardGames.Soc.Common.Unity.Playable.PlayableController playableController); // 0x073bc9a0
	System.Void UpdateGraphLogic(System.Int32 nowTick, System.Single deltaTime); // 0x073bf5ac
	System.Void ApplyPresentationState(System.Int32 nowTick, System.Single deltaTime); // 0x073bf800
	System.Void Shutdown(); // 0x073bfbfc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.PlayableNodeGraph : XNode.NodeGraph
{
	
	WizardGames.Soc.Common.Unity.Playable.AnimationOutputNode GetOutputNode(); // 0x073be620
	WizardGames.Soc.Common.Unity.Playable.AnimationValueNode GetValueNode(); // 0x073be494
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Playable.AnimationNode> GetAllPlayableNodes(); // 0x073be338
	System.Void .ctor(); // 0x073c4434
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.PlayableNodeGraph.<>c : System.Object
{
	static WizardGames.Soc.Common.Unity.Playable.PlayableNodeGraph.<>c <>9; // 0x0
	static System.Predicate<XNode.Node> <>9__0_0; // 0x8
	static System.Predicate<XNode.Node> <>9__1_0; // 0x10
	static System.Func<WizardGames.Soc.Common.Unity.Playable.AnimationNode,System.String> <>9__2_0; // 0x18
	static System.Void .cctor(); // 0x073c449c
	System.Void .ctor(); // 0x073c4500
	System.Boolean <GetOutputNode>b__0_0(XNode.Node x); // 0x073c4568
	System.Boolean <GetValueNode>b__1_0(XNode.Node x); // 0x073c4628
	System.String <GetAllPlayableNodes>b__2_0(WizardGames.Soc.Common.Unity.Playable.AnimationNode item); // 0x073c46e8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.PlayableOverride : UnityEngine.ScriptableObject
{
	WizardGames.Soc.Common.Unity.Playable.PlayableNodeGraph playableNodeGraph; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Playable.AnimationClipInfo> animationClipInfos; // 0x20
	System.Void Init(); // 0x073c4768
	System.Void Apply(); // 0x073c4c38
	System.Void .ctor(); // 0x073c4db0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.BleedTree1D : System.Object
{
	WizardGames.Soc.Common.Unity.Playable.PlayableNode mainNode; // 0x10
	System.Single[] positions; // 0x18
	System.Single[] weights; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Playable.AnimationClipNode> nodes; // 0x28
	System.Single blendedClipLength; // 0x30
	System.Boolean footIk; // 0x34
	System.Void .ctor(WizardGames.Soc.Common.Unity.Playable.PlayableNode node); // 0x073c3a58
	System.Single SetBlendPosition(System.Single position, System.Boolean updateGraph); // 0x073c1368
	System.Void UpdateGraph(); // 0x073c2518
	System.Void CalculateWeights(System.Single[] positionArray, System.Single[]& weightArray, System.Single blendParam); // 0x073c4e18
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.BlendTree2DSimpleDirectional : System.Object
{
	WizardGames.Soc.Common.Unity.Playable.PlayableNode mainNode; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Playable.AnimationClipNode> nodes; // 0x18
	UnityEngine.Vector2[] positions; // 0x20
	System.Single[] weights; // 0x28
	System.Single blendedClipLength; // 0x30
	System.Boolean footIk; // 0x34
	System.Void .ctor(WizardGames.Soc.Common.Unity.Playable.PlayableNode node); // 0x073c3e20
	System.Single SetBlendPosition(UnityEngine.Vector2 position, System.Boolean updateGraph); // 0x073c1608
	System.Void UpdateGraph(); // 0x073c25f8
	static System.Void CalculateWeights(UnityEngine.Vector2[] positionArray, System.Single[]& weightArray, UnityEngine.Vector2 blendParam); // 0x073c500c
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Playable.MixerType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Playable.MixerType None = 0;
	static WizardGames.Soc.Common.Unity.Playable.MixerType Linear = 1;
	static WizardGames.Soc.Common.Unity.Playable.MixerType Bleed1D = 2;
	static WizardGames.Soc.Common.Unity.Playable.MixerType Bleed2D = 3;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.OperationValue : System.Object
{
	System.String operationTypeName; // 0x10
	System.Collections.Generic.List<System.String> operationTypeValues; // 0x18
	System.Void .ctor(); // 0x073c54e0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.OperationData : System.Object
{
	System.String operationType; // 0x10
	System.String operationValue; // 0x18
	System.Void .ctor(); // 0x073c5548
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.NodeWithOperationValue : System.Object
{
	System.String nodeName; // 0x10
	System.String operationType; // 0x18
	System.Collections.Generic.Dictionary<System.String,System.Int32> operationValue; // 0x20
	System.Void .ctor(WizardGames.Soc.Common.Unity.Playable.AnimationNode node); // 0x073b8d54
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.BoolType : System.Object
{
	System.String boolName; // 0x10
	System.Boolean boolValue; // 0x18
	System.Void .ctor(); // 0x073c55b0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.ParameterType : System.Object
{
	System.String parameterName; // 0x10
	System.Single parameterValue; // 0x18
	System.Void .ctor(); // 0x073c5618
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.AnimationClipInfo : System.Object
{
	System.String name; // 0x10
	UnityEngine.AnimationClip animationClip; // 0x18
	System.Void .ctor(); // 0x073c4bd0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Playable.SimpleTransition<U> : System.Object
{
	System.Int32[] ports; // 0x0
	U target; // 0x0
	System.Void .ctor(U target, System.Int32 portCount); // 0x052af1f0
	System.Void Update(System.Int32 activePort, System.Single blendVelocity, System.Single deltaTime); // 0x055083e0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Parachute.ParachuteInstanceLogicParallelState<T,TEnum> : WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicState
{
	System.Collections.Generic.Dictionary<System.Type,WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicStateController> SubStateControllers; // 0x0
	TEnum _stateEnum; // 0x0
	System.Int32 _stateValue; // 0x0
	static System.Object SyncObj; // 0x0
	static T _instance; // 0x8
	System.Void set_StateEnum(TEnum value); // 0x052af1f0
	System.Void .ctor(); // 0x055049cc
	static T get_Instance(); // 0x052af1f0
	System.Boolean CanEnter(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams parachuteLogicParams); // 0x054dec74
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams parachuteLogicParams); // 0x05523a54
	System.Int32 Update(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams parachuteLogicParams); // 0x0549a128
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams parachuteLogicParams); // 0x05523a54
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Parachute.ParachuteInstanceLogicStateController<T,TEnum> : WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicStateController
{
	System.Collections.Generic.Dictionary<TEnum,WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicState> States; // 0x0
	static T _instance; // 0x0
	static T get_Instance(); // 0x052af1f0
	System.Void RegisterState(TEnum stateEnum, WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicState state); // 0x052af1f0
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicState : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicStateController <StateController>k__BackingField; // 0x10
	System.Void set_StateController(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicStateController value); // 0x073c5680
	System.Boolean CanEnter(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams logicParams); // 0x073c5700
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams logicParams); // 0x073c5778
	System.Int32 Update(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams logicParams); // 0x073c57ec
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams logicParams); // 0x073c5864
	System.Void .ctor(); // 0x073c58d8
	static System.Void .cctor(); // 0x073c5940
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicStateController : System.Object
{
	static SocLogger logger; // 0x0
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams para); // 0x073c5a14
	System.Int32 Update(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams para); // 0x073c5a88
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams para); // 0x073c5b00
	System.Void .ctor(); // 0x073c5b74
	static System.Void .cctor(); // 0x073c5bdc
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Parachute.EParachuteMoveState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Parachute.EParachuteMoveState Start = 0;
	static WizardGames.Soc.Common.Unity.Parachute.EParachuteMoveState Cut = 1;
	static WizardGames.Soc.Common.Unity.Parachute.EParachuteMoveState Fall = 2;
	static WizardGames.Soc.Common.Unity.Parachute.EParachuteMoveState End = 3;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams : System.Object
{
	WizardGames.Soc.Common.Entity.ParachuteEntity ParachuteEntity; // 0x10
	WizardGames.Soc.Common.SimpleCustom.UserCmd Cmd; // 0x18
	UnityEngine.Transform MainGo; // 0x20
	WizardGames.Soc.Common.Unity.Go.MountableAuthoritySide AuthoritySide; // 0x28
	System.Boolean FirstEnter; // 0x2c
	System.Boolean IsEnter; // 0x2d
	System.Void .ctor(); // 0x073c5cb0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Parachute.MoveStateCut : WizardGames.Soc.Common.Unity.Parachute.ParachuteInstanceLogicParallelState<WizardGames.Soc.Common.Unity.Parachute.MoveStateCut,WizardGames.Soc.Common.Unity.Parachute.EParachuteMoveState>
{
	
	System.Void .ctor(); // 0x073c5d50
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams parachuteLogicParams); // 0x073c5e14
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams parachuteLogicParams); // 0x073c60a8
	System.Int32 Update(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams parachuteLogicParams); // 0x073c62a0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Parachute.MoveStateEnd : WizardGames.Soc.Common.Unity.Parachute.ParachuteInstanceLogicParallelState<WizardGames.Soc.Common.Unity.Parachute.MoveStateEnd,WizardGames.Soc.Common.Unity.Parachute.EParachuteMoveState>
{
	
	System.Void .ctor(); // 0x073c63c4
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams parachuteLogicParams); // 0x073c6488
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams parachuteLogicParams); // 0x073c671c
	System.Int32 Update(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams parachuteLogicParams); // 0x073c6914
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Parachute.MoveStateFall : WizardGames.Soc.Common.Unity.Parachute.ParachuteInstanceLogicParallelState<WizardGames.Soc.Common.Unity.Parachute.MoveStateFall,WizardGames.Soc.Common.Unity.Parachute.EParachuteMoveState>
{
	
	System.Void .ctor(); // 0x073c6c10
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams parachuteLogicParams); // 0x073c6cd4
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams parachuteLogicParams); // 0x073c6ecc
	System.Int32 Update(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams parachuteLogicParams); // 0x073c70c4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Parachute.MoveStateStart : WizardGames.Soc.Common.Unity.Parachute.ParachuteInstanceLogicParallelState<WizardGames.Soc.Common.Unity.Parachute.MoveStateStart,WizardGames.Soc.Common.Unity.Parachute.EParachuteMoveState>
{
	
	System.Void .ctor(); // 0x073c713c
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams parachuteLogicParams); // 0x073c7200
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams parachuteLogicParams); // 0x073c7494
	System.Int32 Update(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams parachuteLogicParams); // 0x073c768c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Parachute.ParachuteStateController : WizardGames.Soc.Common.Unity.Parachute.ParachuteInstanceLogicStateController<WizardGames.Soc.Common.Unity.Parachute.ParachuteStateController,WizardGames.Soc.Common.Unity.Parachute.EParachuteMoveState>
{
	WizardGames.Soc.Common.Unity.Character.State.Event.MgrStateEvent _mgrStateEvent; // 0x18
	System.Void .ctor(); // 0x073c776c
	System.Void OnEnter(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams logicParams); // 0x073c799c
	System.Void ChangeState(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams logicParams, System.Int32 stateEnum); // 0x073c7a28
	System.Void OnLeave(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams logicParams); // 0x073c7b80
	System.Int32 Update(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams logicParams); // 0x073c7bfc
	System.Int32 CommonCheck(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams logicParams); // 0x073c7d14
	static System.Boolean IsLanded(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams parachuteLogicParams); // 0x073c7db0
	static System.Boolean IsCutTrigger(WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams parachuteLogicParams); // 0x073c7e24
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Parachute.ParachuteGoPredict : System.Object
{
	WizardGames.Soc.Common.Unity.Parachute.ParachuteLogicParams LogicParams; // 0x10
	System.Void PredictInit(System.String name); // 0x073c7e98
	System.Void PredictEnter(); // 0x073c7f3c
	System.Void PredictLeave(); // 0x073c80cc
	System.Void PredictUpdate(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, ClientParachuteGo parachute); // 0x073c8420
	System.Void .ctor(); // 0x073c8568
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Parachute.ParachuteGoPredict.<>c : System.Object
{
	static WizardGames.Soc.Common.Unity.Parachute.ParachuteGoPredict.<>c <>9; // 0x0
	static WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__3_0; // 0x8
	static System.Void .cctor(); // 0x073c85d0
	System.Void .ctor(); // 0x073c8634
	System.Void <PredictLeave>b__3_0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x073c869c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Soc.Common.Unity.Runtime.Safety.SafeArea : System.Object
{
	UnityEngine.Vector3 position; // 0x10
	System.String name; // 0x20
	System.Single inRadius; // 0x28
	System.Single outRadius; // 0x2c
	System.Single upperHeight; // 0x30
	System.Single lowerHeight; // 0x34
	System.Single upperOffset; // 0x38
	System.Single lowerOffset; // 0x3c
	System.Void .ctor(UnityEngine.GameObject monument, UnityEngine.Vector3 pos, System.String nameInput, System.Single inRadiusInput, System.Single outRadiuInput, System.Single upperHeightInput, System.Single lowerHeightInput, System.Single upperOffsetInput, System.Single lowerOffsetInput); // 0x073c87c4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Soc.Common.Unity.Runtime.Safety.SafeAreaFuns : System.Object
{
	static System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Soc.Common.Unity.Runtime.Safety.SafeArea> safeAreas; // 0x0
	static WizardGames.Soc.Common.Character.ESafeAreaType GetSafeEnum(UnityEngine.Vector3 point); // 0x073c8924
	static WizardGames.Soc.Common.Unity.Soc.Common.Unity.Runtime.Safety.SafeAreaFuns.SafeInfo GetNearestSafeAreaInfo(UnityEngine.Vector3 point); // 0x073c8be0
	static System.Void .cctor(); // 0x073c9040
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Soc.Common.Unity.Runtime.Safety.SafeAreaFuns.EHostileHintType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Soc.Common.Unity.Runtime.Safety.SafeAreaFuns.EHostileHintType None = 0;
	static WizardGames.Soc.Common.Unity.Soc.Common.Unity.Runtime.Safety.SafeAreaFuns.EHostileHintType Info = 1;
	static WizardGames.Soc.Common.Unity.Soc.Common.Unity.Runtime.Safety.SafeAreaFuns.EHostileHintType Warning = 2;
	static WizardGames.Soc.Common.Unity.Soc.Common.Unity.Runtime.Safety.SafeAreaFuns.EHostileHintType Error1 = 3;
	static WizardGames.Soc.Common.Unity.Soc.Common.Unity.Runtime.Safety.SafeAreaFuns.EHostileHintType Error2 = 4;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Soc.Common.Unity.Runtime.Safety.SafeAreaFuns.SafeInfo : System.Object
{
	WizardGames.Soc.Common.Character.ESafeAreaType isInSafe; // 0x10
	System.Int32 index; // 0x14
	System.Single distance; // 0x18
	System.Void .ctor(); // 0x073c8fc4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Monument.BaseMonumentAction : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	SocLogger logger; // 0x20
	System.Int64 StartTime; // 0x28
	System.Single ExecuteDistance; // 0x30
	System.Int64 Duration; // 0x38
	System.Boolean IsPlaying; // 0x40
	WizardGames.Soc.Common.Unity.Monument.MonumentActionParams ActionParams; // 0x48
	UnityEngine.Vector3 MonumentPos; // 0x98
	WizardGames.Soc.Common.Unity.Manager.MgrMonumentEventBase owner; // 0xa8
	WizardGames.Soc.Common.Data.MonumentEventDataBase BaseActionData; // 0xb0
	System.Boolean Executor(WizardGames.Soc.Common.Unity.Monument.MonumentActionParams actionParams, System.String& error); // 0x073c90d8
	System.Void Init(WizardGames.Soc.Common.Unity.Monument.MonumentActionParams actionParams, WizardGames.Soc.Common.Data.MonumentEventDataBase dataBase); // 0x073c9318
	System.Boolean BaseCheck(UnityEngine.Vector3 fromPos, UnityEngine.Vector3 toPos); // 0x073c9414
	System.Void Update(); // 0x073c9550
	System.Void Release(); // 0x073c9674
	System.Int32 GetResumeTime(); // 0x073c971c
	System.Void .ctor(); // 0x073c97cc
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Monument.MonumentActionParams : System.ValueType
{
	WizardGames.Soc.Common.Unity.Manager.MgrMonumentEventBase EventMgr; // 0x10
	System.Int64 EventInstanceId; // 0x18
	System.Int32 ActionId; // 0x20
	System.Int64 EventId; // 0x28
	System.Int32 MonumentId; // 0x30
	System.Int64 EntityId; // 0x38
	System.Single PosX; // 0x40
	System.Single PosY; // 0x44
	System.Single PosZ; // 0x48
	System.Single RotX; // 0x4c
	System.Single RotY; // 0x50
	System.Single RotZ; // 0x54
	System.Int64 StartTime; // 0x58
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Monument.MonumentEventParams : System.ValueType
{
	System.Int64 InstanceId; // 0x10
	System.Int64 EventId; // 0x18
	System.Int32 MonumentId; // 0x20
	System.Int64 EntityId; // 0x28
	System.Int64 StartTime; // 0x30
	System.Int32 Duration; // 0x38
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Monster.AiManagerParams : System.Object
{
	static System.Boolean nav_wait; // 0x0
	static System.Boolean nav_disable; // 0x1
	static System.Boolean setdestination_navmesh_failsafe; // 0x2
	static System.Boolean ai_dormant; // 0x3
	static System.Single ai_to_player_distance_wakeup_range; // 0x4
	static System.Int32 nav_obstacles_carve_state; // 0x8
	static System.Int32 ai_dormant_max_wakeup_per_tick; // 0xc
	static System.Single ai_htn_player_tick_budget; // 0x10
	static System.Single ai_htn_player_junkpile_tick_budget; // 0x14
	static System.Single ai_htn_animal_tick_budget; // 0x18
	static System.Boolean ai_htn_use_agency_tick; // 0x1c
	static System.Int32 get_pathfindingIterationsPerFrame(); // 0x073c991c
	static System.Void .cctor(); // 0x073c9978
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Monster.GeneralConfig : UnityEngine.MonoBehaviour
{
	UnityEngine.Transform EyePos; // 0x30
	UnityEngine.Transform HpPoint; // 0x38
	UnityEngine.Transform LaserPos; // 0x40
	UnityEngine.Transform RagdollBoneTrans; // 0x48
	System.Collections.Generic.List<UnityEngine.SkinnedMeshRenderer> meshRenderers; // 0x50
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Monster.Point.MonsterPointBinder> PointBinders; // 0x58
	UnityEngine.Transform GunPitch; // 0x60
	UnityEngine.Transform GunYaw; // 0x68
	UnityEngine.Transform TurretRotateStartPos; // 0x70
	UnityEngine.Transform TurretRotateEndPos; // 0x78
	UnityEngine.Transform FirePoint; // 0x80
	UnityEngine.Transform WeaponSocket; // 0x88
	UnityEngine.Transform TurretShell; // 0x90
	System.Collections.Generic.List<UnityEngine.Transform> FirePointChildren; // 0x98
	TriggerHurtNotChild triggerHurtNotChild; // 0xa0
	SerializableDictionary<System.String,UnityEngine.Transform> boneDic; // 0xa8
	System.Void .ctor(); // 0x073c99f0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Monster.MonsterConfig : UnityEngine.MonoBehaviour
{
	UnityEngine.AnimationCurve HandIkCurve; // 0x30
	System.Void .ctor(); // 0x073c9bac
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Monster.MonsterConstParamCommon : System.Object
{
	static System.Boolean EnableMonsterFireLog; // 0x0
	static System.Single SleepThreshold; // 0x4
	static System.Single WakeupThreshold; // 0x8
	static UnityEngine.Vector3 TerrainAdditionSize; // 0xc
	static System.Boolean MonsterInvincible; // 0x18
	static System.Void .cctor(); // 0x073c9c14
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Monster.MonsterConstParamCommon.BehaviorType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Monster.MonsterConstParamCommon.BehaviorType Scientist = 1;
	static WizardGames.Soc.Common.Unity.Monster.MonsterConstParamCommon.BehaviorType Animal = 2;
	static WizardGames.Soc.Common.Unity.Monster.MonsterConstParamCommon.BehaviorType Turret = 3;
	static WizardGames.Soc.Common.Unity.Monster.MonsterConstParamCommon.BehaviorType Tank = 4;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Monster.MonsterTimeCountDown : System.Object
{
	System.String CdName; // 0x10
	System.Single CdInterval; // 0x18
	System.Single MinInterval; // 0x1c
	System.Single MaxInterval; // 0x20
	System.Single StartTime; // 0x24
	System.String EventName; // 0x28
	System.Boolean CdComplete(); // 0x073c9c74
	System.Void ResetCd(System.Boolean start); // 0x073c9d38
	System.Void StartCd(); // 0x073c9e3c
	System.Void RandomInterval(); // 0x073c9dcc
	System.Void .ctor(); // 0x073c9ee4
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Monster.MonsterMoveConfig : System.ValueType
{
	WizardGames.Soc.Common.Entity.MonsterEntity.MonsterMoveType MoveType; // 0x10
	WizardGames.Soc.Common.State.Monster.EMonsterDirectionType DirectionType; // 0x14
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Monster.MonsterUtility : System.Object
{
	static UnityEngine.RaycastHit[] RaycastHitBuff; // 0x0
	static System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.RaycastHit>> RaycastHitsPool; // 0x8
	static SocLogger logger; // 0x10
	static System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.Monster.MonsterUtility.EMonsterMoveReason,WizardGames.Soc.Common.Unity.Monster.MonsterMoveConfig> MonsterMoveConfig; // 0x18
	static System.Collections.Generic.HashSet<WizardGames.Soc.Common.Unity.Monster.MonsterUtility.FlagType> AutoResetFlag; // 0x20
	static System.Collections.Generic.Dictionary<System.String,UnityEngine.GameObject> Roots; // 0x28
	static System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,UnityEngine.Vector3>> MonsterBoneMapRot; // 0x30
	static System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,UnityEngine.Vector3>> MonsterBoneMapPos; // 0x38
	static System.Collections.Generic.List<UnityEngine.GameObject> manualGos; // 0x40
	static System.Void .cctor(); // 0x073c9f80
	static System.Void InitMonsterMoveConfig(); // 0x073ca2dc
	static System.Void TrySpawnPrefabUseOrigin(System.String path, System.Int32 count); // 0x073ca5d4
	static System.Void TrySpawnPrefabUsePool(System.String path, System.Int32 count); // 0x073cac08
	static System.Void TrySpawnPrefab(System.String path, System.Int32 count, System.Int32 method); // 0x073cb144
	static System.Void ClearPrefabs(); // 0x073cb234
	static UnityEngine.Quaternion Slerp(UnityEngine.Quaternion from, UnityEngine.Quaternion to, System.Single speed); // 0x073cb410
	static System.String GenerateRandomBotName(System.Int32& index0, System.Int32& index1); // 0x073cb51c
	static System.Boolean MonsterCanGenerateHitRequest(WizardGames.Soc.Common.Entity.MonsterEntity srcEntity, WizardGames.Soc.Common.Entity.MonsterEntity dstEntity); // 0x073cb754
	static WizardGames.Soc.Common.Data.EMonsterCampDamageType GetMonsterDamageType(WizardGames.Soc.Common.Entity.MonsterEntity srcEntity, WizardGames.Soc.Common.Entity.MonsterEntity dstEntity); // 0x073cb800
	static System.String GetMonsterAnimator(WizardGames.Soc.Common.Entity.MonsterEntity monsterEntity, System.Boolean useDefault); // 0x073cb9a4
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Monster.MonsterUtility.EMonsterMoveReason : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Monster.MonsterUtility.EMonsterMoveReason Idle = 0;
	static WizardGames.Soc.Common.Unity.Monster.MonsterUtility.EMonsterMoveReason Roam = 1;
	static WizardGames.Soc.Common.Unity.Monster.MonsterUtility.EMonsterMoveReason SplitStep = 2;
	static WizardGames.Soc.Common.Unity.Monster.MonsterUtility.EMonsterMoveReason Trace = 3;
	static WizardGames.Soc.Common.Unity.Monster.MonsterUtility.EMonsterMoveReason Patrol = 4;
	static WizardGames.Soc.Common.Unity.Monster.MonsterUtility.EMonsterMoveReason ToCover = 5;
	static WizardGames.Soc.Common.Unity.Monster.MonsterUtility.EMonsterMoveReason Flee = 6;
	static WizardGames.Soc.Common.Unity.Monster.MonsterUtility.EMonsterMoveReason Feed = 7;
	static WizardGames.Soc.Common.Unity.Monster.MonsterUtility.EMonsterMoveReason ChaseMove = 8;
	static WizardGames.Soc.Common.Unity.Monster.MonsterUtility.EMonsterMoveReason ForceMove = 9;
	static WizardGames.Soc.Common.Unity.Monster.MonsterUtility.EMonsterMoveReason FindEntity = 10;
	static WizardGames.Soc.Common.Unity.Monster.MonsterUtility.EMonsterMoveReason MoveToPosition = 11;
	static WizardGames.Soc.Common.Unity.Monster.MonsterUtility.EMonsterMoveReason AvoidAOE = 12;
	static WizardGames.Soc.Common.Unity.Monster.MonsterUtility.EMonsterMoveReason FleeToPosition = 13;
	static WizardGames.Soc.Common.Unity.Monster.MonsterUtility.EMonsterMoveReason BattleSplitForward = 21;
	static WizardGames.Soc.Common.Unity.Monster.MonsterUtility.EMonsterMoveReason Retreat = 22;
	static WizardGames.Soc.Common.Unity.Monster.MonsterUtility.EMonsterMoveReason SplitToCover = 23;
	static WizardGames.Soc.Common.Unity.Monster.MonsterUtility.EMonsterMoveReason SplitForceMove = 24;
	static WizardGames.Soc.Common.Unity.Monster.MonsterUtility.EMonsterMoveReason ToEntity = 25;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Monster.MonsterUtility.FlagType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Monster.MonsterUtility.FlagType None = 0;
	static WizardGames.Soc.Common.Unity.Monster.MonsterUtility.FlagType Aggression = 2;
	static WizardGames.Soc.Common.Unity.Monster.MonsterUtility.FlagType Sleep = 4;
	static WizardGames.Soc.Common.Unity.Monster.MonsterUtility.FlagType CanNotFlee = 8;
	static WizardGames.Soc.Common.Unity.Monster.MonsterUtility.FlagType Wild = 16;
	static WizardGames.Soc.Common.Unity.Monster.MonsterUtility.FlagType Retreat = 32;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Monster.NavMeshProcess : UnityEngine.MonoBehaviour
{
	static System.String BakeConfigPath; // 0x0
	static SocLogger logger; // 0x8
	static System.String SavePathPrefix; // 0x10
	System.Int32 NavMeshAgentTypeIndex; // 0x30
	System.String DefaultAreaName; // 0x38
	System.Int32 AsyncTerrainNavMeshBakeCellSize; // 0x40
	System.Int32 AsyncTerrainNavMeshBakeCellHeight; // 0x44
	System.String NotWalkableLayer; // 0x48
	UnityEngine.Bounds Bounds; // 0x50
	UnityEngine.AI.NavMeshData NavMeshData; // 0x68
	UnityEngine.AI.NavMeshDataInstance NavMeshDataInstance; // 0x70
	UnityEngine.LayerMask LayerMask; // 0x74
	UnityEngine.AI.NavMeshCollectGeometry NavMeshCollectGeometry; // 0x78
	UnityEngine.AI.NavMeshBuildSettings buildSettings; // 0x7c
	static System.Boolean use_baked_terrain_mesh; // 0x18
	System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources; // 0xc0
	UnityEngine.AsyncOperation BuildingOperation; // 0xc8
	System.Boolean HasBuildOperationStarted; // 0xd0
	System.Diagnostics.Stopwatch BuildTimer; // 0xd8
	System.Int32 defaultArea; // 0xe0
	System.Int32 agentTypeId; // 0xe4
	System.Boolean BuildComplete; // 0xe8
	System.Boolean SendServiceReady; // 0xe9
	UnityEngine.AI.NavMeshDataInstance meshInstance; // 0xec
	System.String sceneName; // 0xf0
	System.Boolean get_IsBuilding(); // 0x073cc2b4
	System.Void OnEnable(); // 0x073cc330
	System.Void Init(); // 0x073cc474
	System.Void StartProcess(UnityEngine.Bounds bounds); // 0x073cc5c0
	System.Void UpdateNavMeshSync(); // 0x073cc984
	System.Void SyncUpdateNavMesh(UnityEngine.Bounds bounds); // 0x073cc70c
	System.Boolean PreloadNavmesh(); // 0x073cce90
	System.Void ModifyMeshUpload(); // 0x073cd09c
	System.Void OnDisable(); // 0x073cd358
	System.Void UpdateNavMeshAsync(); // 0x073cd3c0
	System.Void AppendModifierVolumes(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources); // 0x073cd6f8
	System.Void FinishBuildingNavmesh(System.Boolean preLoad, System.Boolean sync); // 0x073ccc70
	System.Void .ctor(); // 0x073cd76c
	static System.Void .cctor(); // 0x073cd890
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Monster.UnitySpawnConfig : UnityEngine.MonoBehaviour
{
	SocLogger logger; // 0x30
	UnityEngine.Collider[] hitBuffer; // 0x38
	System.Single Radius; // 0x40
	System.Single MinDistance; // 0x44
	System.Int32 MaxPoints; // 0x48
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Monster.UnitySpawnConfig.SpawnPoint> spawnPoints; // 0x50
	System.Collections.Generic.IReadOnlyList<WizardGames.Soc.Common.Unity.Monster.UnitySpawnConfig.SpawnPoint> get_SpawnPoints(); // 0x073cd9d0
	System.Void AddSpawnPoint(UnityEngine.Vector3 position); // 0x073cda34
	System.Void ClearAllSpawnPoints(); // 0x073cdc20
	System.Boolean IsPositionValid(UnityEngine.Vector3 position, System.Collections.Generic.List<UnityEngine.Vector3> existingPoints); // 0x073cdcc4
	System.Void GenerateRandomPoints(); // 0x073cdf34
	UnityEngine.Vector3 RandomPos(UnityEngine.Transform root, System.Boolean checkNav); // 0x073ce134
	System.Void ReleaseOwner(); // 0x073ce404
	System.Void OnInit(); // 0x073ce56c
	System.Void .ctor(); // 0x073ce6d4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Monster.UnitySpawnConfig.SpawnPoint : System.Object
{
	UnityEngine.Vector3 LocalPosition; // 0x10
	System.Boolean IsUsed; // 0x1c
	System.Int32 Index; // 0x20
	System.Void .ctor(); // 0x073cdbb8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Monster.Point.BinderIndex : UnityEngine.MonoBehaviour
{
	System.Int32 index; // 0x30
	System.Void .ctor(); // 0x073ce874
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Monster.Point.BindingPointData : System.Object
{
	WizardGames.Soc.Common.Data.Monster.PointName pointName; // 0x10
	UnityEngine.Matrix4x4 pointCenterLocal; // 0x14
	System.Int32 priority; // 0x54
	UnityEngine.Matrix4x4[] shootPointArray; // 0x58
	System.Single[] shootRadiusArray; // 0x60
	System.Void .ctor(); // 0x073ce8dc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Monster.Point.BindingPointGroup : System.Object
{
	UnityEngine.Matrix4x4 ShootBasePoint; // 0x10
	WizardGames.Soc.Common.Unity.Monster.Point.BindingPointData[] PointList; // 0x50
	System.Void .ctor(); // 0x073ce944
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Monster.Point.MonsterBindingPoint : UnityEngine.ScriptableObject
{
	WizardGames.Soc.Common.Unity.Monster.Point.BindingPointGroup[] groups; // 0x18
	static WizardGames.Soc.Common.Unity.Monster.Point.BindingPointGroup GetAssetFromMono(WizardGames.Soc.Common.Unity.Monster.Point.MonsterPointBinder mono); // 0x073ce9ac
	static System.Void BuildGroupFromAsset(UnityEngine.GameObject prefabRoot, WizardGames.Soc.Common.Unity.Monster.Point.MonsterBindingPoint asset); // 0x073cee40
	static UnityEngine.GameObject CreateNewPoint(UnityEngine.GameObject parent, System.String goName, UnityEngine.Matrix4x4 transMatrix); // 0x073cf644
	System.Void .ctor(); // 0x073cf8a4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Monster.Point.MonsterPointBinderData : System.Object
{
	WizardGames.Soc.Common.Data.Monster.PointName pointName; // 0x10
	UnityEngine.Transform pointCenter; // 0x18
	System.Int32 priority; // 0x20
	System.Int32 UseCount; // 0x24
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Monster.Point.MonsterPointShootData> shootPointDatas; // 0x28
	System.Void .ctor(); // 0x073cf7c8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Monster.Point.MonsterPointShootData : System.Object
{
	UnityEngine.Transform shootPoint; // 0x10
	System.Single radius; // 0x18
	System.Void .ctor(); // 0x073cf830
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Monster.Point.MonsterPointBinder : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	System.Boolean ShowPoint1; // 0x30
	System.Boolean ShowPoint2; // 0x31
	System.Int32 ArrayIndex; // 0x34
	UnityEngine.Transform ShootBasePoint; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Monster.Point.MonsterPointBinderData> PointList; // 0x40
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Unity.Monster.Point.MonsterPointBinderData> mPointMap; // 0x48
	UnityEngine.GameObject mBindRootObj; // 0x50
	System.Void Awake(); // 0x073cf90c
	WizardGames.Soc.Common.Unity.Monster.Point.MonsterPointBinderData GetPoint(WizardGames.Soc.Common.Data.Monster.PointName targetPointName); // 0x073cfa78
	static WizardGames.Soc.Common.Unity.Monster.Point.MonsterPointBinder GetPointBinder(WizardGames.Soc.Common.Unity.Go.IPointBinderGo binderGo, System.Int32 pointIdx); // 0x073cfb54
	System.Void .ctor(); // 0x073cfd40
	static System.Void .cctor(); // 0x073cfdf4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Monster.State.AimationState.SocMonsterAnimatorParameters : System.Object
{
	static System.Int32 BlendX; // 0x0
	static System.Int32 BlendY; // 0x4
	static System.Int32 BattleState; // 0x8
	static System.Int32 PoseState; // 0xc
	static System.Int32 ShelterState; // 0x10
	static System.Int32 SwitchProp; // 0x14
	static System.Int32 MoveState; // 0x18
	static System.Int32 Show; // 0x1c
	static System.Int32 Roll; // 0x20
	static System.Int32 Sprint; // 0x24
	static System.Int32 Death; // 0x28
	static System.Int32 Recourse; // 0x2c
	static System.Int32 Collapse; // 0x30
	static System.Int32 UseProp; // 0x34
	static System.Int32 Throw; // 0x38
	static System.Int32 Reload; // 0x3c
	static System.Int32 ShootAttack; // 0x40
	static System.Int32 Walk; // 0x44
	static System.Int32 Run; // 0x48
	static System.Int32 ShowType; // 0x4c
	static System.Int32 StandTurn; // 0x50
	static System.Int32 EnterTurn; // 0x54
	static System.Int32 CoverBack; // 0x58
	static System.Int32 Attack; // 0x5c
	static System.Int32 Eat; // 0x60
	static System.Int32 Sleeping; // 0x64
	static System.Int32 IsMoving; // 0x68
	static System.Int32 WalkSpeed; // 0x6c
	static System.Int32 SpeedFactor; // 0x70
	static System.Int32 UpDown; // 0x74
	static System.Int32 WakeUpLayer; // 0x78
	static System.Int32 GunShoot; // 0x7c
	static System.Int32 BowShoot; // 0x80
	static System.Int32 Idle_type; // 0x84
	static System.Int32 ParamSpeed; // 0x88
	static System.Int32 ParamMouthOpen; // 0x8c
	static System.Collections.Generic.Dictionary<System.String,System.Int32> AnimalAnimatorLayer; // 0x90
	static System.Collections.Generic.Dictionary<System.String,System.Int32> HumanAnimatorLayer; // 0x98
	static System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.String,System.Int32>> AnimatorLayer; // 0xa0
	static System.Int32 GetLayerIndex(System.Int32 type, System.String animName); // 0x073cfec8
	static System.Void .cctor(); // 0x073cfff0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Monster.State.AimationState.Mgr.MgrMonsterAnimation : WizardGames.Soc.Common.Manager.MgrBase
{
	
	System.Void Init(); // 0x073d0868
	System.Threading.Tasks.Task OnExitWorld(); // 0x073d08d0
	static System.Void Remove(System.Int64 entityId); // 0x073d0938
	static WizardGames.Soc.Common.Unity.Animation.ISocAnimationRuntime Init(System.Int64 entityId, UnityEngine.Animator animator); // 0x073d09c4
	System.Void .ctor(); // 0x073d0a68
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Monster.Animation.AnimalAnimatorContext : System.ValueType
{
	WizardGames.Soc.Common.Entity.MonsterEntity MonsterEntity; // 0x10
	System.Int64 Interval; // 0x18
	WizardGames.Soc.Common.Unity.Animation.ISocAnimationRuntime AnimatorWrapper; // 0x20
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Monster.Animation.TankConfig : System.ValueType
{
	System.Boolean IsNight; // 0x10
	System.Int64 Time; // 0x18
	System.Boolean IsMoving; // 0x20
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Monster.Animation.TankAnimLogic : System.Object
{
	System.Int32 moveSpeed; // 0x10
	System.Int32 speedFactor; // 0x14
	System.Single moveSpeedVal; // 0x18
	System.Single speedFactorVal; // 0x1c
	System.Single traceThickness; // 0x20
	System.Boolean useWheelYOrigin; // 0x24
	System.Int64 lastUpdateTime; // 0x28
	UnityEngine.Ray ray; // 0x30
	System.Single traceLineMax; // 0x48
	System.Int32 cachedMask; // 0x4c
	System.Single angularVelocity; // 0x50
	UnityEngine.Vector3 lastForward; // 0x54
	WizardGames.Soc.Common.Unity.Go.BaseMonsterGo monsterGo; // 0x60
	WizardGames.Soc.Common.Entity.MonsterEntity monsterEntity; // 0x68
	UnityEngine.Vector3 desiredAimVector; // 0x70
	UnityEngine.Vector3 desiredTopTurretAimVector; // 0x7c
	WizardGames.Soc.Common.Unity.Monster.Animation.TankConfiguration tankConfiguration; // 0x88
	System.Void OnUpdate(); // 0x073d0ad0
	UnityEngine.Vector3 GetAimPoint(System.Int64 entityId); // 0x073d15e4
	System.Void OnInit(WizardGames.Soc.Common.Unity.Go.BaseMonsterGo monsterGo, System.Int64 time); // 0x073d16cc
	UnityEngine.Quaternion TurretLookRotation(UnityEngine.Vector3 approximateForward, UnityEngine.Vector3 exactUp, UnityEngine.Vector3 axis); // 0x073d17b4
	System.Void DoWeaponAiming(System.Int64 time); // 0x073d1338
	System.Void AimWeaponAt(UnityEngine.Transform yaw, UnityEngine.Transform pitch, UnityEngine.Vector3 direction, UnityEngine.Vector3 dst, System.Single minPitch, System.Single maxPitch, System.Single maxYaw, System.Single deltaTime, System.Single speed); // 0x073d196c
	System.Void CalculateAnimVelocity(System.Int64 time); // 0x073d0bb4
	System.Void UpdateHeights(); // 0x073d0f04
	System.Void .ctor(); // 0x073d1f48
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Monster.Animation.TankConfiguration : UnityEngine.MonoBehaviour
{
	UnityEngine.Animator MainBodyAnimator; // 0x30
	UnityEngine.GameObject Turret; // 0x38
	UnityEngine.GameObject MainCannon; // 0x40
	UnityEngine.GameObject MainCannonMuzzle; // 0x48
	UnityEngine.GameObject MainGun; // 0x50
	UnityEngine.GameObject MainGunMuzzle; // 0x58
	UnityEngine.GameObject SubGunYaw; // 0x60
	UnityEngine.GameObject SubGunPitch; // 0x68
	UnityEngine.GameObject SubGunMuzzle; // 0x70
	System.Boolean UpdateHeight; // 0x78
	System.Single HeightFudge; // 0x7c
	System.Single MaxShockDist; // 0x80
	UnityEngine.Transform[] WheelBones; // 0x88
	UnityEngine.Vector3[] VecShocksOffsetPosition; // 0x90
	UnityEngine.Vector3[] WheelBoneOrigin; // 0x98
	UnityEngine.GameObject LeftLight; // 0xa0
	UnityEngine.GameObject RightLight; // 0xa8
	UnityEngine.GameObject LeftWheel; // 0xb0
	UnityEngine.GameObject RightWheel; // 0xb8
	UnityEngine.GameObject Exhaust; // 0xc0
	UnityEngine.GameObject Damage; // 0xc8
	System.Void Awake(); // 0x073d2060
	UnityEngine.GameObject GetFireGo(System.Int32 slotId); // 0x073d222c
	UnityEngine.GameObject GetWeaponGo(System.Int32 slotId); // 0x073d22d0
	UnityEngine.Transform GetFireTrans(System.Int32 slotId); // 0x073d2374
	UnityEngine.Vector3 GetFirePos(System.Int32 slotId); // 0x073d2434
	UnityEngine.Vector3 GetFireBackUpPos(System.Int32 slotId); // 0x073d2538
	System.Void .ctor(); // 0x073d263c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Monster.Animation.TreadEffect : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Go.MonsterGo MonsterGo; // 0x10
	WizardGames.Soc.Common.Entity.MonsterEntity MonsterEntity; // 0x18
	WizardGames.Soc.Common.Unity.Monster.Animation.TankConfiguration TankConfiguration; // 0x20
	UnityEngine.GameObject leftLight; // 0x28
	UnityEngine.GameObject rightLight; // 0x30
	UnityEngine.GameObject leftWheel; // 0x38
	UnityEngine.GameObject rightWheel; // 0x40
	UnityEngine.GameObject exhaust; // 0x48
	UnityEngine.GameObject damage; // 0x50
	System.Single rotationOffset; // 0x58
	UnityEngine.Vector3 vecLastPosition; // 0x5c
	UnityEngine.Quaternion vecLastRotation; // 0x68
	System.Single forwardSpeed; // 0x78
	Effect.EffectItemHandle<Effect.FollowEffect> leftLightEffect; // 0x80
	Effect.EffectItemHandle<Effect.FollowEffect> rightLightEffect; // 0x90
	Effect.EffectItemHandle<Effect.FollowEffect> rightWheelEffect; // 0xa0
	Effect.EffectItemHandle<Effect.FollowEffect> leftWheelEffect; // 0xb0
	Effect.EffectItemHandle<Effect.FollowEffect> healthEffect1; // 0xc0
	Effect.EffectItemHandle<Effect.FollowEffect> healthEffect2; // 0xd0
	Effect.EffectItemHandle<Effect.FollowEffect> exhaustEffect; // 0xe0
	WizardGames.Soc.SocClient.ClientLight.LightItem leftLightItem; // 0xf0
	WizardGames.Soc.SocClient.ClientLight.LightItem rightLightItem; // 0xf8
	System.Int32 healthState; // 0x100
	UnityEngine.Renderer renderer; // 0x108
	System.Boolean valid; // 0x110
	UnityEngine.MaterialPropertyBlock block; // 0x118
	System.Single totalOffset; // 0x120
	UnityEngine.Material left_tread; // 0x128
	UnityEngine.Material right_tread; // 0x130
	UnityEngine.Material both_tread; // 0x138
	UnityEngine.Material[] materials; // 0x140
	System.Int64 lastUpdateTime; // 0x148
	System.Void StopTankEffect(Effect.EffectItemHandle<Effect.FollowEffect>& effectItemHandle); // 0x073d26b8
	System.Void StopAllEffect(); // 0x073d27b0
	System.Void UpdateLightEffect(System.Boolean isNight); // 0x073d28e4
	System.Void OnInit(WizardGames.Soc.SocClient.Go.MonsterGo go); // 0x073d2df8
	System.Void GetTreadEffectMat(); // 0x073d3218
	System.Void UpdateHealthState(); // 0x073d3660
	System.Void OnUpdate(WizardGames.Soc.Common.Unity.Monster.Animation.TankConfig cfg); // 0x073d3adc
	System.Boolean HasWheelEffect(); // 0x073d43c0
	System.Void UpdateWheelEffect(WizardGames.Soc.Common.Unity.Monster.Animation.TankConfig cfg); // 0x073d3d58
	System.Void UpdateTreadDirtEffects(WizardGames.Soc.Common.Unity.Monster.Animation.TankConfig cfg); // 0x073d3bd4
	System.Void CalculateOffset(WizardGames.Soc.Common.Unity.Monster.Animation.TankConfig cfg); // 0x073d446c
	System.Void OnHostDestroy(System.Boolean isDead); // 0x073d4a14
	System.Void AudioOnStart(); // 0x073d3080
	System.Void UpdateAudioEvent(WizardGames.Soc.Common.Unity.Monster.Animation.TankConfig cfg); // 0x073d42a4
	System.Void AudioOnDestroy(); // 0x073d4c2c
	System.Void .ctor(); // 0x073d4dc4
	static System.Void .cctor(); // 0x073d4e40
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJob : System.ValueType, Unity.Jobs.IJobParallelFor
{
	Unity.Collections.NativeArray<WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData> jobDataArray; // 0x10
	Unity.Collections.NativeArray<WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData> jobResultDataArray; // 0x20
	WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobConstData jobConstData; // 0x30
	Unity.Collections.NativeArray<WizardGames.Soc.Common.Character.TpMaskWeightConfGroup> MaskArray; // 0x38
	Unity.Collections.NativeArray<WizardGames.Soc.Common.Character.TpMaskWeightConfGroup> AoMaskArray; // 0x48
	System.IntPtr HumanoidAnimationNestedArrayJobData; // 0x58
	System.Void UpdateAdditiveLayer(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, WizardGames.Soc.Common.Unity.Character.AnimParametersScientist& animParams, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobConstData constData); // 0x073d4f14
	System.Boolean IsBow(WizardGames.Soc.Common.Unity.Defines.TableItemEnum itemType); // 0x073d5190
	WizardGames.Soc.Common.Entity.MonsterEntity.EAdditiveLayerState GetNextAdditiveLayerState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData); // 0x073d50f0
	System.Void ToEmptyState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073d5210
	System.Void UpdateFireState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData); // 0x073d5304
	System.Void ToFireState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073d56a0
	System.Void UpdateFireWarmState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData); // 0x073d555c
	System.Void ToReloadState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073d5464
	System.Void UpdateIkAdditive(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData& jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultJobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationNestedArrayJobData& nested); // 0x073d5798
	System.Single GetStateNormalizedTimeAdditiveLayer(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData& jobData, System.Int32 stateIndex); // 0x073d5a10
	System.Int32 GetAddStateHash(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultJobData); // 0x073d5928
	System.Void UpdateAimOffsetLayer(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, WizardGames.Soc.Common.Unity.Character.AnimParametersScientist& animParams, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobConstData constData); // 0x073d5d98
	System.Void SwitchAimOffset(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, WizardGames.Soc.Common.Unity.Character.AnimParametersScientist& animParams); // 0x073d5e84
	System.Void ToCrouchAOState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073d5fdc
	System.Void ToStandAOState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073d60d4
	System.Void ToEmptyAOState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073d61cc
	System.Void Execute(System.Int32 index); // 0x073d62c0
	static System.Single SampleIk(Unity.Collections.NativeArray<System.Single>& samples, System.Int32 enumIndex, System.Single normTime); // 0x073d5a9c
	System.Void UpdateIkLayers(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData& jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultJobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationNestedArrayJobData& nestedArrayJobData); // 0x073d783c
	System.Void UpdateIkLocomotion(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData& jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultJobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationNestedArrayJobData& nested); // 0x073d79e4
	System.Boolean Approximately(System.Single a, System.Single b, System.Single epsilon); // 0x073d7e38
	System.Void UpdateWarmupWeaponLayer(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, WizardGames.Soc.Common.Unity.Character.AnimParametersScientist& animParams, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobConstData constData); // 0x073d7278
	System.Void AfterUpdate(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersScientist& animParams, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobConstData constData); // 0x073d7904
	System.Single Clamp01(System.Single value); // 0x073d5c0c
	System.Boolean UpdateCommonMaskWeight(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultJobData, System.Int32 fullCapacity, Unity.Collections.NativeArray<WizardGames.Soc.Common.Character.TpMaskWeightConfGroup> maskArray, WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup& group, System.Int32 layerIndex); // 0x073d7ed4
	System.Void UpdateLocomotionLayer(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, WizardGames.Soc.Common.Unity.Character.AnimParametersScientist& animParams, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobConstData constData); // 0x073d662c
	System.Single GetStateNormalizedTimeLocomotionLayer(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData& jobData, System.Int32 stateHash); // 0x073d7dac
	System.Single GetStateNormalizedTime(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData& jobData, System.Int32 layerIndex, System.Int32 stateHash); // 0x073d5cb4
	System.Int32 GetLocomotionStateHash(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultJobData); // 0x073d7d18
	WizardGames.Soc.Common.Entity.MonsterEntity.ELocomotionLayerState GetNextLocomotionLayerState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single& transitionTime); // 0x073d844c
	System.Void ToLocomotionEmptyState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073d8310
	System.Void ToLeisureWalkState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073d85fc
	System.Void ToBattleIdleState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073d8c60
	System.Void ToLeisureIdleState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073d8da0
	System.Void ToLeisureIdle2State(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073d8ee0
	System.Void ToLeisureIdle3State(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073d9020
	System.Void ToLeisureIdle4State(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073d9160
	System.Void ToCrouchIdleState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073d92a0
	System.Void SwitchLocomotion(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobConstData constData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073d873c
	System.Void UpdateNormalizeSpeed(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Character.AnimParametersScientist& animParams, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobConstData& constData, WizardGames.Soc.Common.Entity.HumanoidAnimLocalData& localData); // 0x073d9a54
	System.Single LerpValue(CommonUnity.Runtime.Animation.AnimMoveSpeedLerpMode LerpMode, System.Single lastSpeed, System.Single Speed, System.Single dt, System.Single LerpSpeed); // 0x073da768
	static System.Single ClampZero(System.Single value); // 0x073da8c8
	System.Void ToFStandLocomotionState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073da258
	System.Void ToBStandLocomotionState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073da4e0
	System.Void ToLStandLocomotionState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073da624
	System.Void ToRStandLocomotionState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073da39c
	System.Void ToSprintLocomotionState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073d93e0
	System.Void SetLocomotionLayerWeightByState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultJobData, WizardGames.Soc.Common.Character.TpAniBoneMask boneMask, System.Single time, System.Boolean defaultValue, System.Boolean maxTime); // 0x073da0d4
	System.Void UpdateMoveDirectionInCharacterCoordinate(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultJobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobConstData constData, WizardGames.Soc.Common.Unity.Character.AnimParametersScientist& animParams); // 0x073d955c
	System.Single SmoothStep(System.Single from, System.Single to, System.Single t); // 0x073da950
	System.Void UpdateLocomotionWeightLayer(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, WizardGames.Soc.Common.Unity.Character.AnimParametersScientist& animParams, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobConstData constData, Unity.Collections.NativeArray<WizardGames.Soc.Common.Character.TpMaskWeightConfGroup>& MaskArray); // 0x073d7340
	System.Void OnSwitchWeaponLocomotionWeight(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData); // 0x073daa40
	System.Void GetActionLocomotionWeight(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobConstData constData); // 0x073dab40
	System.Void SetOverrideTargetWeightTp(WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData& weightRuntime, System.Single targetWeight); // 0x073db360
	System.Void UpdateLocomotionMaskWeight(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultJobData, System.Int32 fullCapacity, Unity.Collections.NativeArray<WizardGames.Soc.Common.Character.TpMaskWeightConfGroup> maskArray, WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup& group, System.Int32 layerBaseIndex, System.Int32 layerAddIndex); // 0x073daec8
	System.Boolean LerpBoneWeight(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultJobData, WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData& weightRuntime, WizardGames.Soc.Common.Character.TpMaskWeightConfGroup maskBoneHash); // 0x073d81ac
	System.Void UpdateOverrideLayer(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, WizardGames.Soc.Common.Unity.Character.AnimParametersScientist& animParams, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobConstData constData); // 0x073d6dcc
	WizardGames.Soc.Common.Entity.MonsterEntity.EOverrideLayerState GetNextOverrideLayerState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData); // 0x073db930
	System.Void ToOverrideEmptyState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073dbf44
	System.Void ToDeathState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073db494
	System.Void ToOverrideNearThrowState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073dc228
	System.Void ToOverrideFarThrowState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073dc130
	System.Void ToAttackState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073dba6c
	System.Void ToBossAttack1State(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073dbb64
	System.Void ToBossAttack2State(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073dbc5c
	System.Void ToBossAttack3State(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073dbd54
	System.Void ToHeavyAttackState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073dbe4c
	System.Void ToDrawState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073dc038
	System.Void ToRecourseState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073dc320
	System.Void ToShowState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073dc42c
	System.Void UpdateBowState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, WizardGames.Soc.Common.Unity.Character.AnimParametersScientist& animParams); // 0x073db58c
	System.Void ToBowFireStartState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073dc524
	System.Void ToBowFireLoopState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073dc61c
	System.Void ToBowFireArrowState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073dc714
	System.Void ToBowPickArrowState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073dc80c
	System.Void UpdateOverrideLayerWeightLayer(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersScientist& animParams, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobConstData constData); // 0x073d764c
	System.Void UpdateIkOverride(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData& jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultJobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationNestedArrayJobData& nested); // 0x073d7b74
	System.Int32 GetIkOverrideEnumIdx(WizardGames.Soc.Common.Entity.MonsterEntity.EOverrideLayerState state); // 0x073dca2c
	System.Single GetStateNormalizedTimeOverrideLayer(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData& jobData, System.Int32 stateIndex); // 0x073dc9a0
	System.Int32 GetOverStateHash(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultJobData); // 0x073dc904
	System.Void UpdatePoseLayer(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, WizardGames.Soc.Common.Unity.Character.AnimParametersScientist& animParams, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobConstData constData); // 0x073d69c8
	WizardGames.Soc.Common.Entity.MonsterEntity.EPoseLayerState GetNextPoseLayerState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData); // 0x073dcab8
	System.Single GetTransitionTime(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData resultData, WizardGames.Soc.Common.Entity.MonsterEntity.EPoseLayerState nextState); // 0x073dcbc4
	System.Void ToBattleIdlePoseState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073dcc9c
	System.Void ToLeisureIdlePoseState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073dcda4
	System.Void ToVehiclePoseState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073dcea8
	System.Void ToThrowPoseState(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x073dcfb0
	System.Void LerpCrouchStand(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, WizardGames.Soc.Common.Unity.Character.AnimParametersScientist& animParams); // 0x073dd0b8
	System.Void LerpHipSight(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, WizardGames.Soc.Common.Unity.Character.AnimParametersScientist& animParams); // 0x073dd214
	System.Void CalculateStand2LocoLerpProgress(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultData, WizardGames.Soc.Common.Unity.Character.AnimParametersScientist& animParams, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobConstData constData); // 0x073d6c44
	System.Void UpdatePoseWeightLayer(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData jobData, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersScientist& animParams, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobConstData constData); // 0x073d7494
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Monster.Animation.OverrideLayerCacheData : System.ValueType
{
	WizardGames.Soc.Common.Entity.MonsterEntity.EOverrideLayerState OverrideLayerState; // 0x10
	System.Single RepresentantWeight; // 0x14
	System.Int32 UpdateIndex; // 0x18
	System.Int32 AnimatorInstanceId; // 0x1c
	System.Int32 ApplyInstanceId; // 0x20
	System.Boolean SwitchTpAnimator; // 0x24
	System.Boolean WasLerping; // 0x25
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Monster.Animation.LocomotionStateCacheData : System.ValueType
{
	WizardGames.Soc.Common.State.Monster.EMonsterMoveState MoveState; // 0x10
	System.Int32 MoveDetail; // 0x14
	System.Int32 BattleState; // 0x18
	WizardGames.Soc.Common.State.Monster.EMonsterPoseState PoseState; // 0x1c
	WizardGames.Soc.Common.State.Monster.EMonsterActionState ActionState; // 0x1d
	System.Int32 IdleAnimType; // 0x20
	System.Int64 HeldItemId; // 0x28
	WizardGames.Soc.Common.Entity.MonsterEntity.ELocomotionLayerState CurrentLocomotionLayerState; // 0x30
	System.Int32 UpdateIndex; // 0x34
	System.Int32 AnimatorInstanceId; // 0x38
	System.Int32 ApplyInstanceId; // 0x3c
	System.Boolean SwitchTpAnimator; // 0x40
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidStateData : System.ValueType
{
	WizardGames.Soc.Common.State.Monster.EMonsterPoseState PoseState; // 0x10
	WizardGames.Soc.Common.State.Monster.EMonsterMoveState MoveState; // 0x11
	WizardGames.Soc.Common.State.Monster.EMonsterActionState ActionState; // 0x12
	WizardGames.Soc.Common.State.Monster.EMonsterLifeState MonsterLifeState; // 0x13
	WizardGames.Soc.Common.State.Monster.EMonsterAttackState AttackState; // 0x14
	System.Byte MoveDetail; // 0x15
	WizardGames.Soc.Common.Entity.MonsterEntity.MonsterBattleState BattleState; // 0x18
	System.Int64 CurrentWeaponTableId; // 0x20
	WizardGames.Soc.Common.Unity.Defines.TableItemEnum CurrentTableItemEnum; // 0x28
	WizardGames.Soc.Common.Data.DataItem.ItemEntityType CurrentItemEntityType; // 0x2c
	System.Single SpeedX; // 0x30
	System.Single SpeedZ; // 0x34
	System.Single RotateY; // 0x38
	System.Single UpDownAngle; // 0x3c
	WizardGames.Soc.Common.State.Monster.EMonsterDirectionType DirectionType; // 0x40
	System.Boolean FireAtThisFrame; // 0x41
	System.Boolean IsWarmupWeapon; // 0x42
	WizardGames.Soc.Common.CustomType.WarmAnimType WarmupWeaponAnimType; // 0x43
	System.Single WarmupWeaponProgress; // 0x44
	System.Int32 IdleAnimType; // 0x48
	System.UInt16 NormalAttackType; // 0x4c
	System.Int64 MeleeAttackTS; // 0x50
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidHeldItemData : System.ValueType
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
	System.Int32 TpAniOcWeightIndex; // 0x48
	System.Int32 OcTimeIndex; // 0x4c
	System.Int32 LocTimeIndex; // 0x50
	System.Int32 LocTimSpecialIndex; // 0x54
	System.Int32 TpAniTipCurveIndex; // 0x58
	System.Boolean HasLeisureState; // 0x5c
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobConstData : System.ValueType
{
	System.Single LocomotionLerpSpeed; // 0x10
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationNestedArrayJobData : System.ValueType, System.IDisposable
{
	Unity.Collections.NativeArray<System.Single> IkLocomotionLeft; // 0x10
	Unity.Collections.NativeArray<System.Single> IkLocomotionRight; // 0x20
	Unity.Collections.NativeArray<System.Single> IkLocomotionHorse; // 0x30
	Unity.Collections.NativeArray<System.Single> IkAdditiveLeft; // 0x40
	Unity.Collections.NativeArray<System.Single> IkAdditiveRight; // 0x50
	Unity.Collections.NativeArray<System.Single> IkAdditiveHorse; // 0x60
	Unity.Collections.NativeArray<System.Single> IkOverrideLeft; // 0x70
	Unity.Collections.NativeArray<System.Single> IkOverrideRight; // 0x80
	Unity.Collections.NativeArray<System.Single> IkOverrideHorse; // 0x90
	System.Void Dispose(); // 0x073dd368
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData : System.ValueType
{
	static SocLogger logger; // 0x0
	System.UInt16 Index; // 0x10
	System.Int32 AnimatorInstanceId; // 0x14
	System.Int32 Interval; // 0x18
	WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidStateData StateData; // 0x20
	WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidHeldItemData HeldItemData; // 0x68
	static System.Void Init(UnityEngine.Animator animator, WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobData& data, Contexts.ClientContext context, CommonUnity.Runtime.Animation.ClientAnim anim, WizardGames.Soc.Common.Entity.MonsterEntity entity, System.Int32 deltaTime, System.UInt16 index); // 0x073dd3c8
	static System.Single GetUpDown(WizardGames.Soc.Common.Entity.MonsterEntity entity); // 0x073ddc1c
	static System.Void UpdateIkSamples(CommonUnity.Runtime.Animation.ClientAnim anim); // 0x073dd86c
	static System.Void EnsureIkArray(Unity.Collections.NativeArray<System.Single>& arr, System.Int32 length); // 0x073dddf4
	static System.Void SampleLayer<TEnum>(SerializableDictionary<TEnum,CommonUnity.Runtime.Character.Resource.IkCurveEntry> dict, Unity.Collections.NativeArray<System.Single> leftArr, Unity.Collections.NativeArray<System.Single> rightArr, Unity.Collections.NativeArray<System.Single> horseArr, System.Int32 sampleCount); // 0x052af1f0
	static System.Single SafeEval(UnityEngine.AnimationCurve curve, System.Single t); // 0x073ddf10
	static System.Void .cctor(); // 0x073ddfb8
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData : System.ValueType
{
	static SocLogger logger; // 0x0
	System.Int64 EntityId; // 0x10
	WizardGames.Soc.Common.Entity.HumanoidAnimLocalData HumanoidAnimLocalData; // 0x18
	WizardGames.Soc.Common.Unity.Character.AnimParametersScientist TpParameters; // 0xd20
	WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData.TpIkResult IkLocomotion; // 0xd7c
	WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData.TpIkResult IkAdditive; // 0xd88
	WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData.TpIkResult IkOverride; // 0xd94
	static System.Void Init(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData& data, Contexts.ClientContext context, WizardGames.Soc.Common.Entity.MonsterEntity entity, System.Int32 deltaTime, UnityEngine.Animator animator); // 0x073de08c
	static System.Void CopyTo(WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData data, WizardGames.Soc.Common.Entity.MonsterEntity entity); // 0x073de3e0
	static System.Void SetFrame(WizardGames.Soc.Common.Entity.MonsterEntity entity, System.Int32 deltaTime, UnityEngine.Animator animator); // 0x073de298
	static System.Void SetTime(WizardGames.Soc.Common.Entity.MonsterEntity entity, System.Int32 deltaTime); // 0x073de1e4
	static System.Void .cctor(); // 0x073de51c
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Monster.Animation.HumanoidAnimationJobResultData.TpIkResult : System.ValueType
{
	System.Single Left; // 0x10
	System.Single Right; // 0x14
	System.Single Horse; // 0x18
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Monster.Animation.MonsterTurretLine : UnityEngine.MonoBehaviour
{
	WizardGames.Soc.SocClient.Go.MonsterGo monsterGo; // 0x30
	System.Int32 MaxDistance; // 0x38
	WizardGames.Soc.Common.Unity.Monster.Animation.MonsterTurretLine.LineData[] lineDatas; // 0x40
	WizardGames.Soc.Common.Unity.Monster.Animation.MonsterTurretLine.LineData curLine; // 0x48
	UnityEngine.GameObject lineRootGo; // 0x50
	UnityEngine.GameObject endPointRootGo; // 0x58
	UnityEngine.RaycastHit[] hits; // 0x60
	UnityEngine.RaycastHit hitData; // 0x68
	System.Void Init(WizardGames.Soc.SocClient.Go.MonsterGo monsterGo); // 0x073de5f0
	System.Void SetLineType(System.Int32 index); // 0x073de77c
	System.Void RenderUpdate(); // 0x073deabc
	System.Void CheckEndPoint(); // 0x073deb20
	System.String GetLineInfo(); // 0x073df140
	System.Void .ctor(); // 0x073df45c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Monster.Animation.MonsterTurretLine.LineData : System.Object
{
	UnityEngine.Transform point; // 0x10
	UnityEngine.Transform lineRoot; // 0x18
	UnityEngine.Transform endPointRoot; // 0x20
	UnityEngine.LineRenderer[] LRs; // 0x28
	System.Void .ctor(); // 0x073df4fc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Manager.McCommonUnity : System.Object
{
	static WizardGames.Soc.Common.Framework.Network.ThreadTaskManager ThreadTask; // 0x0
	static WizardGames.Soc.Common.Unity.Scene.MgrScene Scene; // 0x8
	static WizardGames.Soc.Common.Unity.MgrRes Res; // 0x10
	static WizardGames.Soc.Common.Framework.Network.WebSocketNoticeManager WebSocket; // 0x18
	static WizardGames.Soc.Common.Unity.Audio.MgrAudioBase AudioBase; // 0x20
	static WizardGames.Soc.Common.Unity.Manager.MgrMaterial Material; // 0x28
	static WizardGames.Soc.Common.Unity.Manager.MgrEvent Event; // 0x30
	static WizardGames.Soc.Common.Unity.Manager.MgrMapConfig MapConfig; // 0x38
	static WizardGames.Soc.Common.Synchronization.MgrSnapshotReceiver SnapshotReceiver; // 0x40
	static WizardGames.Soc.Common.TimerWheel.TimerWheel TimerWheel; // 0x48
	static WizardGames.Soc.Common.Unity.Systems.MgrWeapon Weapon; // 0x50
	static WizardGames.Soc.Common.Unity.Construction.MgrConstructionUnity Construction; // 0x58
	static WizardGames.Soc.Common.Syncronization.MgrPhysicsScene PhysicsScene; // 0x60
	static WizardGames.Soc.Common.Data.MgrTables get_Tables(); // 0x073df564
	static System.Void InitAddonManager(); // 0x073df5ec
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Manager.McCommonUnity.<>c : System.Object
{
	static WizardGames.Soc.Common.Unity.Manager.McCommonUnity.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__15_0; // 0x8
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__15_1; // 0x10
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__15_2; // 0x18
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__15_3; // 0x20
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__15_4; // 0x28
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__15_5; // 0x30
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__15_6; // 0x38
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__15_7; // 0x40
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__15_8; // 0x48
	static System.Action<WizardGames.Soc.Common.Manager.MgrBase> <>9__15_9; // 0x50
	static System.Void .cctor(); // 0x073dfecc
	System.Void .ctor(); // 0x073dff30
	System.Void <InitAddonManager>b__15_0(WizardGames.Soc.Common.Manager.MgrBase mgr); // 0x073dff98
	System.Void <InitAddonManager>b__15_1(WizardGames.Soc.Common.Manager.MgrBase mgr); // 0x073e00c0
	System.Void <InitAddonManager>b__15_2(WizardGames.Soc.Common.Manager.MgrBase mgr); // 0x073e01e8
	System.Void <InitAddonManager>b__15_3(WizardGames.Soc.Common.Manager.MgrBase mgr); // 0x073e0310
	System.Void <InitAddonManager>b__15_4(WizardGames.Soc.Common.Manager.MgrBase mgr); // 0x073e0438
	System.Void <InitAddonManager>b__15_5(WizardGames.Soc.Common.Manager.MgrBase mgr); // 0x073e0560
	System.Void <InitAddonManager>b__15_6(WizardGames.Soc.Common.Manager.MgrBase mgr); // 0x073e0688
	System.Void <InitAddonManager>b__15_7(WizardGames.Soc.Common.Manager.MgrBase mgr); // 0x073e07c4
	System.Void <InitAddonManager>b__15_8(WizardGames.Soc.Common.Manager.MgrBase mgr); // 0x073e08ec
	System.Void <InitAddonManager>b__15_9(WizardGames.Soc.Common.Manager.MgrBase mgr); // 0x073e0a14
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Manager.MgrCollider : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Stl.SocDict<UnityEngine.GameObject,WizardGames.Soc.Common.Combat.ColliderConfig> ColliderConfigCache; // 0x18
	System.Collections.Generic.HashSet<System.Int32> managerEntityTypes; // 0x20
	WizardGames.Soc.Stl.SocDict<System.Int64,WizardGames.Soc.Common.Combat.ColliderConfigSet> colliderConfigSets; // 0x28
	System.Void Init(); // 0x073e0b3c
	System.Threading.Tasks.Task OnExitWorld(); // 0x073e0e0c
	System.Threading.Tasks.Task OnEnterWorld(); // 0x073e0eb0
	System.Void CleanUp(); // 0x073e0f68
	System.Void OnColliderGoRemove(System.Int64 entityId); // 0x073e101c
	System.Void UpdateConstructionColliderSetCollection(System.Int64 entityId, WizardGames.Soc.Common.Entity.PartEntity entity, WizardGames.Soc.Common.Combat.ColliderConfigSet colliderConfigSet, System.Collections.Generic.List<WizardGames.Soc.Common.Combat.ColliderConfig> configs); // 0x073e115c
	System.Void UpdateTreeControlColliderSet(System.Int64 entityId, WizardGames.Soc.Common.Combat.ColliderConfigSet colliderConfigSet); // 0x073e14d8
	System.Void UpdateEntityColliderSet(WizardGames.Soc.Common.Entity.IEntity entity, WizardGames.Soc.Common.Unity.Go.BaseEntityGo baseEntityGo, System.Boolean isMyself); // 0x073e1800
	System.Void AddColliderConfigSet(WizardGames.Soc.Stl.SocDict<System.Int64,WizardGames.Soc.Common.Combat.ColliderConfigSet> configSets, WizardGames.Soc.Common.Entity.IEntity entity, WizardGames.Soc.Common.Unity.Go.BaseEntityGo go, System.Boolean isMyself); // 0x073e1d10
	System.Boolean FilterEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x073e2448
	WizardGames.Soc.Common.Combat.ColliderConfigSet GetColliderConfigSet(WizardGames.Soc.Common.Entity.IEntity entity, WizardGames.Soc.Common.Unity.Go.BaseEntityGo go); // 0x073e21cc
	UnityEngine.GameObject GetCollider(System.Int64 entityId, System.Int32 colliderIndex); // 0x073e25d0
	WizardGames.Soc.Common.Combat.ColliderConfigSet GetColliderSet(System.Int64 entityId); // 0x073e2720
	System.Void .ctor(); // 0x073e27cc
	static System.Void .cctor(); // 0x073e2884
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Manager.GameObjectExtensions : System.Object
{
	
	static System.Boolean TryGetColliderConfig(UnityEngine.GameObject go, WizardGames.Soc.Common.Combat.ColliderConfig& colliderConfig); // 0x073e2b90
	static WizardGames.Soc.Common.Combat.ColliderConfig GetColliderConfig(UnityEngine.GameObject go); // 0x073e2ed4
	static WizardGames.Soc.Common.Combat.ColliderConfig GetColliderConfigCore(UnityEngine.GameObject go); // 0x073e2c8c
	static System.Void RemoveColliderConfig(UnityEngine.GameObject go); // 0x073e2f38
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Manager.MgrEvent : WizardGames.Soc.Common.Manager.MgrBase
{
	
	System.Void .ctor(); // 0x073e30a0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Manager.MgrMapConfig : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	static SocLogger Log; // 0x8
	System.Collections.Generic.Dictionary<System.Int32,UnityEngine.GameObject> _id2AirWall; // 0x18
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Data.LadderData>> LadderDataDict; // 0x20
	System.Collections.Generic.List<System.Int32> ToCloseAirWall; // 0x28
	System.Collections.Generic.List<System.Int32> CloseAirWall; // 0x30
	System.Void LoadMapConfigData(System.Int32 mapId); // 0x073e3108
	System.Void ClearMapConfigData(); // 0x073e352c
	System.Void LoadMonumentSpawnData(); // 0x073e4ebc
	System.Void LoadMonumentSpawnData(System.Int32 monumentInstanceId, System.String monumentName); // 0x073e50a8
	System.Void ClearMonumentSpawnData(); // 0x073e54c4
	System.Void LoadAirWallData(System.Int32 mapId); // 0x073e35f8
	System.Void ClearAirWallData(System.Boolean isInit); // 0x073e32a8
	System.Void LoadAreaBoxData(System.Int32 mapId); // 0x073e416c
	System.Void ClearAreaBoxData(); // 0x073e4c94
	System.Void LoadPointGroupData(System.Int32 mapId); // 0x073e45ec
	System.Void ClearPointGroupData(); // 0x073e4d78
	System.Void LoadEventVolumeData(System.Int32 mapId); // 0x073e4c20
	System.Void ClearEventVolumeData(); // 0x073e4e5c
	System.Void TurnAirWall(System.Int32 airWallId, System.Boolean turnOn); // 0x073e5548
	System.Void Destroy(); // 0x073e57f8
	System.Void .ctor(); // 0x073e587c
	static System.Void .cctor(); // 0x073e5a04
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Manager.MgrMaterial : WizardGames.Soc.Common.Manager.MgrBase
{
	System.String WwiseMaterialGroup; // 0x18
	System.Func<UnityEngine.Vector3,System.Int32> GetTerrainMaterial; // 0x20
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Combat.ColliderMaterialEnum> terrainTypeMap; // 0x28
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Combat.ColliderMaterialEnum> sceneMaterialTypeMap; // 0x30
	System.Void Init(); // 0x073e5b0c
	WizardGames.Soc.Common.Combat.ColliderMaterialEnum GetMaterialByTerrainData(System.Int32 typeIndex); // 0x073e6390
	WizardGames.Soc.Common.Combat.ColliderMaterialEnum GetMaterial(UnityEngine.Collider collider, UnityEngine.Vector3 pos); // 0x073e643c
	WizardGames.Soc.Common.Combat.ColliderMaterialEnum GetMaterial(UnityEngine.Collider collider, UnityEngine.Vector3 pos, UnityEngine.GameObject colliderGo); // 0x073e66e4
	System.Int32 GetEffectByMaterial(System.Int64 tableId, WizardGames.Soc.Common.Combat.ColliderMaterialEnum materialEnum); // 0x073e6984
	System.Single GetEffectScaleByMaterial(System.Int64 tableId, WizardGames.Soc.Common.Combat.ColliderMaterialEnum materialEnum); // 0x073e6c6c
	System.String GetWwiseMaterialState(WizardGames.Soc.Common.Combat.ColliderMaterialEnum materialEnum); // 0x073e6f18
	static System.Int32 TempMaterialMapFromTable(WizardGames.Soc.Common.Combat.ColliderMaterialEnum e); // 0x073e70ec
	System.Void InitMaterialMap(); // 0x073e5b7c
	System.Void .ctor(); // 0x073e71a0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Manager.MgrMonumentEventBase : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Collections.Generic.Dictionary<System.Int32,System.Func<WizardGames.Soc.Common.Unity.Monument.BaseMonumentAction>> monumentActionExecutorMap; // 0x18
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Monument.BaseMonumentAction>> allMonumentActions; // 0x20
	System.Collections.Generic.List<System.UInt64> removedActions; // 0x28
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.Monument.MonumentEventParams,System.Collections.Generic.List<System.UInt64>> allMonumentEvents; // 0x30
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.Monument.MonumentActionParams currentActionParams; // 0x38
	WizardGames.Soc.Common.SimpleCustom.MonumentEventCustomData monumentEventCustomData; // 0x88
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.MonumentEventCustomData> cachedEventCustomDatas; // 0x90
	System.Void RegisterActionExecutor(); // 0x073e722c
	System.Threading.Tasks.Task OnEnterWorld(); // 0x073e728c
	System.Threading.Tasks.Task OnExitWorld(); // 0x073e7308
	WizardGames.Soc.Common.Data.monument.MonumentEventData BaseCheck(System.Int32 monumentId, System.Int64 eventId); // 0x073e7670
	System.Void RemoveEvent(System.Int32 monumentId, System.Int64 eventId); // 0x073e76f0
	System.Void TriggerEvent(System.Int32 monumentId, System.Int64 eventId, System.Int64 entityId, System.Int64 startTime); // 0x073e776c
	System.Void OnActionExecuteSuccess(WizardGames.Soc.Common.Unity.Monument.MonumentActionParams actionParams, System.UInt64 monumentActionMid); // 0x073e7d1c
	System.Void CacheTriggerEvent(WizardGames.Soc.Common.SimpleCustom.MonumentEventCustomData eventCustomData); // 0x073e7da8
	System.Void AddActionToBeRemoved(System.UInt64 monumentActionMid); // 0x073e7e9c
	System.Void RemoveAction(WizardGames.Soc.Common.Unity.Monument.MonumentActionParams actionParams, System.UInt64 actionMid); // 0x073e7f88
	System.Void RemoveAction(); // 0x073e8014
	System.Void .ctor(); // 0x073e8210
	static System.Void .cctor(); // 0x073e845c
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Main.LoopType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Main.LoopType None = 0;
	static WizardGames.Soc.Common.Unity.Main.LoopType Application = 1;
	static WizardGames.Soc.Common.Unity.Main.LoopType GameSpace = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Main.UnityMainLoop : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
