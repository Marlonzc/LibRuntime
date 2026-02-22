// Client.Runtime
class <Module> : 
{
	
	
}

// Client.Runtime
class Microsoft.CodeAnalysis.EmbeddedAttribute : System.Attribute
{
	
	System.Void .ctor(); // 0x057dc028
}

// Client.Runtime
class System.Runtime.CompilerServices.IsUnmanagedAttribute : System.Attribute
{
	
	System.Void .ctor(); // 0x057dc090
}

// Client.Runtime
class System.Runtime.CompilerServices.NullableAttribute : System.Attribute
{
	System.Byte[] NullableFlags; // 0x10
	System.Void .ctor(System.Byte Client.Runtime); // 0x057dc0f8
}

// Client.Runtime
class AndroidPerformanceData : System.Object, IPerformanceData
{
	static SocLogger Log; // 0x0
	UnityEngine.AndroidJavaObject Performancedata; // 0x10
	UnityEngine.AndroidJavaObject currentActivity; // 0x18
	System.Int32 Cores; // 0x20
	System.Void Init(); // 0x057dc1bc
	System.Single GetCpuUsage(); // 0x057dc390
	System.Single GetGPUMemoryUsage(); // 0x057dc52c
	System.Void BeginCpuUsageProfile(); // 0x057dc590
	System.Single EndCpuUsageProfile(); // 0x057dc78c
	System.Single[] EndCpuCoresUsageProfile(); // 0x057dc9a0
	System.Int32 GetNumberOfCores(); // 0x057dcbb4
	System.Single GetMemoryUsage(); // 0x057dcc18
	System.String GetGpuUsage(); // 0x057dcd30
	System.Void .ctor(); // 0x057dcee4
	static System.Void .cctor(); // 0x057dcf4c
}

// Client.Runtime
interface IPerformanceData : 
{
	
	System.Void Init(); // 0x055049cc
	System.Single GetCpuUsage(); // 0x054a5abc
	System.Single GetMemoryUsage(); // 0x054a5abc
	System.String GetGpuUsage(); // 0x054e7844
	System.Single GetGPUMemoryUsage(); // 0x054a5abc
	System.Int32 GetNumberOfCores(); // 0x0548ba98
	System.Void BeginCpuUsageProfile(); // 0x055049cc
	System.Single EndCpuUsageProfile(); // 0x054a5abc
	System.Single[] EndCpuCoresUsageProfile(); // 0x054e7844
}

// Client.Runtime
class PerformanceData : System.Object
{
	static SocLogger Log; // 0x0
	static System.String log_file; // 0x8
	static System.String log_file_mem; // 0x10
	static System.String log_file_underclocking; // 0x18
	static System.String appvonfigversion; // 0x20
	static System.String apppaltform; // 0x28
	static System.String appversiontype; // 0x30
	static PerformanceData.UnderclockingRecord underclockingRecord; // 0x38
	static IPerformanceData own; // 0x48
	static System.IO.StreamWriter sw; // 0x50
	static FpsCounter fpscounter; // 0x58
	static System.Collections.Generic.Dictionary<System.String,FpsCounter> stepfpscounters; // 0x60
	static System.Collections.Generic.Dictionary<System.String,System.Single> fpsdic; // 0x68
	static System.Single allframecount; // 0x70
	static System.Int32 frameindex; // 0x74
	static System.Boolean CanInit; // 0x78
	static System.String[] ProfilerCounter_size; // 0x80
	static System.String[] ProfilerCounter_count; // 0x88
	static System.IO.StreamWriter sw_mem; // 0x90
	static System.IO.StreamWriter sw_uc; // 0x98
	static System.Void Init(); // 0x057dd020
	static System.Void TryInitOwn(); // 0x057dd91c
	static System.Single GetCpuUsage(); // 0x057ddab0
	static System.Single GetMemoryUsage(); // 0x057ddbdc
	static System.String GetGpuUsage(); // 0x057ddd08
	static System.Single GetGPUMemoryUsage(); // 0x057dde48
	static System.Int32 GetNumberOfCores(); // 0x057ddf74
	static System.Void BeginCpuUsageProfile(); // 0x057de0a0
	static System.Single EndCpuUsageProfile(); // 0x057de1c8
	static System.Single[] EndCpuCoresUsageProfile(); // 0x057de2f4
	static System.Void Export(System.String log_str, System.Boolean isinit); // 0x057dd76c
	static System.Void Stop(); // 0x057de420
	static System.String GetResultInfo(); // 0x057de558
	static System.Void TickFps(); // 0x057de8dc
	static System.Int32 GetFps(); // 0x057deb4c
	static System.Void StartFrmaeCount(System.String step); // 0x057debfc
	static System.Void StopFrmaeCount(); // 0x057ded88
	static System.Void GetstepaverageFps(System.String stepname, System.String laststepname); // 0x057def20
	static System.Double GetGpuFrameTimeMs(); // 0x057df138
	static System.UInt64 GetGpuFrameTime(); // 0x057df1ac
	static System.Void ExportUnderclockingData(); // 0x057df25c
	static System.String InitCachePath(); // 0x057dd69c
	static System.Void .cctor(); // 0x057df548
}

// Client.Runtime
enum PerformanceData.EUnderclockingReason : System.Enum
{
	System.Int32 value__; // 0x10
	static PerformanceData.EUnderclockingReason NONE = 0;
	static PerformanceData.EUnderclockingReason LOW_BATTERY = 1;
	static PerformanceData.EUnderclockingReason HIGH_TEMPERATURE = 2;
	static PerformanceData.EUnderclockingReason OTHER_REASON = 3;
	
}

// Client.Runtime
enum PerformanceData.ETempUnderclockingLevel : System.Enum
{
	System.Int32 value__; // 0x10
	static PerformanceData.ETempUnderclockingLevel NONE = -1;
	static PerformanceData.ETempUnderclockingLevel NOT_LIMIT = 0;
	static PerformanceData.ETempUnderclockingLevel MILD_LIMIT = 1;
	static PerformanceData.ETempUnderclockingLevel HARD_LIMIT = 2;
	
}

// Client.Runtime
struct PerformanceData.UnderclockingRecord : System.ValueType
{
	PerformanceData.EUnderclockingReason reason; // 0x10
	PerformanceData.ETempUnderclockingLevel tempLevel; // 0x14
	System.Int32 underclockingLevel; // 0x18
	System.Int32 frameIndex; // 0x1c
	
}

// Client.Runtime
class PerformanceDataManager : System.Object
{
	static System.Threading.Thread PerfDataMonitorThreadHandle; // 0x0
	static System.Timers.Timer timer; // 0x8
	static System.Void StartPerfMonitor(); // 0x057dfb08
	static System.Void StopThread(); // 0x057dfde8
	static System.Void SendPerfMonitor(); // 0x057dff48
	static System.Void StopPerfMonitor(); // 0x057e0348
	static System.Void GetdataRepeat(); // 0x057e01fc
	static System.Void StopGetData(); // 0x057dfe94
	static System.Void GetData(System.Object sender, System.Timers.ElapsedEventArgs e); // 0x057dffb4
	static System.Void FrequencyReductionCallback(System.Collections.Generic.Dictionary<System.String,System.String> data); // 0x057e03a0
}

// Client.Runtime
class AimRangeUtil : System.Object
{
	
	static UnityEngine.Vector3 Rotate(System.Single progress0_1, UnityEngine.Vector3 forward, UnityEngine.Quaternion from, UnityEngine.Quaternion to, WizardGames.Soc.SocClient.Control.InputAdditional& additional); // 0x057e06dc
}

// Client.Runtime
class AttributionData : System.Object
{
	System.String attribution; // 0x10
	System.Void .ctor(); // 0x057e0960
}

// Client.Runtime
class NewBehaviourScript : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x057e09c8
}

// Client.Runtime
class WaterBottleItemNodeHelper : System.Object
{
	
	static WizardGames.Soc.Common.CustomType.BaseItemNode GetWaterItem(WizardGames.Soc.Common.CustomType.WaterBottleItemNode item); // 0x057e0a30
	static System.Int32 GetWaterAmount(WizardGames.Soc.Common.CustomType.WaterBottleItemNode item); // 0x057e0afc
}

// Client.Runtime
class MgrAce : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Int64 acetimer; // 0x18
	System.Boolean canGetAceData; // 0x20
	System.Int64 heartbeatTimer; // 0x28
	System.Byte[] aceCache; // 0x30
	System.Void Init(); // 0x055049cc
	System.Void Destroy(); // 0x057e0e00
	System.Void HeartBeat(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x057e0fc0
	System.Void CheckAceData(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x057e14bc
	System.Void OnRecvAceLobbyData(SimpleJSON.JSONNode jsonNode); // 0x057e1914
	System.Void OnRecvAceFeatureLobbyData(SimpleJSON.JSONNode jsonNode); // 0x057e1a88
	System.Void .ctor(); // 0x057e1c9c
	static System.Void .cctor(); // 0x057e1d0c
	System.Void <CheckAceData>b__11_0(SimpleJSON.JSONNode res); // 0x057e1de0
}

// Client.Runtime
class MgrAce.<>c : System.Object
{
	static MgrAce.<>c <>9; // 0x0
	static System.Action<SimpleJSON.JSONNode> <>9__10_0; // 0x8
	static System.Action<SimpleJSON.JSONNode> <>9__10_1; // 0x10
	static System.Action<SimpleJSON.JSONNode> <>9__11_1; // 0x18
	static System.Void .cctor(); // 0x057e1e60
	System.Void .ctor(); // 0x057e1ec4
	System.Void <HeartBeat>b__10_0(SimpleJSON.JSONNode res); // 0x057e1f2c
	System.Void <HeartBeat>b__10_1(SimpleJSON.JSONNode error); // 0x057e1fa0
	System.Void <CheckAceData>b__11_1(SimpleJSON.JSONNode error); // 0x057e20fc
}

// Client.Runtime
class OpenBox : UnityEngine.MonoBehaviour
{
	System.Collections.Generic.List<UnityEngine.GameObject> doorList; // 0x30
	System.Void .ctor(); // 0x057e2258
}

// Client.Runtime
struct UnitySkeletonDataNode : System.ValueType
{
	System.String bone_path; // 0x10
	System.Int32 bone_hash; // 0x18
	System.Int32 depth; // 0x1c
	
}

// Client.Runtime
struct UnitySkeletonData : System.ValueType
{
	UnitySkeletonDataNode[] Bones; // 0x10
	SerializableDictionary<System.String,System.Int32> Bone2IndexMap; // 0x18
	
}

// Client.Runtime
enum ECollisionFlag : System.Enum
{
	System.Int32 value__; // 0x10
	static ECollisionFlag eCOLLISION_SIDES = 1;
	static ECollisionFlag eCOLLISION_UP = 2;
	static ECollisionFlag eCOLLISION_DOWN = 4;
	
}

// Client.Runtime
class CCT : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	System.Boolean isGrounded; // 0x30
	System.Single slopLimit; // 0x34
	System.Single slopLimitCos; // 0x38
	System.Single curStepOffset; // 0x3c
	System.Single stepOffset; // 0x40
	System.Single minMoveDistanceSquared; // 0x44
	UnityEngine.Vector3 center; // 0x48
	System.Single skinWidth; // 0x54
	System.Single radius; // 0x58
	System.Single height; // 0x5c
	UnityEngine.Vector3 hitNormal; // 0x60
	UnityEngine.Vector3 hitPosition; // 0x6c
	System.Boolean STF_HIT_NON_WALKABLE; // 0x78
	UnityEngine.CapsuleCollider cc; // 0x80
	System.Boolean STF_WALK_EXPERIMENT; // 0x88
	UnityEngine.Vector3 SideVectorCache; // 0x8c
	UnityEngine.Vector3 upDir; // 0x98
	UnityEngine.Collider[] colliderResults; // 0xa8
	System.Boolean standingOnMoving; // 0xb0
	System.Int32 collideLayerMask; // 0xb4
	System.Int32 overlapLayer; // 0xb8
	System.Boolean overlpRecover; // 0xbc
	System.Single slopCheckDis; // 0xc0
	WizardGames.Soc.Common.Combat.ColliderConfig colliderConfig; // 0xc8
	System.Void Start(); // 0x057e230c
	System.Int32 Move(UnityEngine.Vector3 direction); // 0x057e2384
	System.Int32 InternalMove(UnityEngine.Vector3 direction); // 0x057e25a0
	System.Boolean CurPosCanSit(); // 0x057e3118
	System.Boolean doSweepTest(UnityEngine.Vector3 direction, System.Int32 max_iter, CCT.ESweepPass sweepPass, System.Int32& NbCollisions); // 0x057e2b80
	System.Single DistanceSquared(UnityEngine.Vector3 a, UnityEngine.Vector3 b); // 0x057e3520
	UnityEngine.Vector3 computeMTD(UnityEngine.Collider colliderA, UnityEngine.Collider colliderB); // 0x057e35f4
	System.Boolean isAlmostZero(UnityEngine.Vector3 v); // 0x057e2a74
	System.Void DecomposeVector(UnityEngine.Vector3 dir, UnityEngine.Vector3 upDir, UnityEngine.Vector3& noramlCompo, UnityEngine.Vector3& tangentCompo); // 0x057e2968
	System.Void .ctor(); // 0x057e385c
	static System.Void .cctor(); // 0x057e3984
}

// Client.Runtime
enum CCT.ESweepPass : System.Enum
{
	System.Int32 value__; // 0x10
	static CCT.ESweepPass SWEEP_PASS_UP = 0;
	static CCT.ESweepPass SWEEP_PASS_SIDE = 1;
	static CCT.ESweepPass SWEEP_PASS_DOWN = 2;
	
}

// Client.Runtime
enum EItemBreakReason : System.Enum
{
	System.Int32 value__; // 0x10
	static EItemBreakReason None = 0;
	static EItemBreakReason ItemDisable = 1;
	static EItemBreakReason ItemUnEquip = 2;
	static EItemBreakReason UseItem = 3;
	static EItemBreakReason UseItemDone = 4;
	static EItemBreakReason WeaponMiss = 5;
	static EItemBreakReason Dying = 6;
	static EItemBreakReason Wounded = 7;
	static EItemBreakReason Mount = 8;
	static EItemBreakReason NewbieTeachingGuide = 9;
	
}

// Client.Runtime
enum EItemDisableReason : System.Enum
{
	System.Int32 value__; // 0x10
	static EItemDisableReason None = 0;
	static EItemDisableReason Swim = 1;
	static EItemDisableReason Dive = 2;
	static EItemDisableReason Ground = 3;
	static EItemDisableReason Ladder = 4;
	static EItemDisableReason ModularCar = 5;
	static EItemDisableReason Boat = 6;
	static EItemDisableReason MiniCopter = 7;
	static EItemDisableReason Train = 8;
	static EItemDisableReason Kayak = 9;
	static EItemDisableReason Ch47 = 10;
	static EItemDisableReason Horse = 11;
	static EItemDisableReason AttackHelicopter = 12;
	static EItemDisableReason Mantle = 13;
	static EItemDisableReason Falling = 14;
	static EItemDisableReason Katyush = 15;
	static EItemDisableReason Zipline = 16;
	static EItemDisableReason Parachute = 17;
	static EItemDisableReason Driver = 18;
	static EItemDisableReason Safety = 19;
	static EItemDisableReason Others = 20;
	
}

// Client.Runtime
enum LandPoseSelectRule : System.Enum
{
	System.Int32 value__; // 0x10
	static LandPoseSelectRule Stand = 0;
	static LandPoseSelectRule Crouch = 1;
	static LandPoseSelectRule KeepLastStance = 2;
	
}

// Client.Runtime
class RaycastDetailColliderConfigSet : UnityEngine.MonoBehaviour
{
	UnityEngine.Transform[] colliders; // 0x30
	UnityEngine.Transform[] GetAllCollider(); // 0x057e3a58
	System.Void .ctor(); // 0x057e3abc
}

// Client.Runtime
class ViewKickCurve : UnityEngine.ScriptableObject
{
	UnityEngine.AnimationCurve _riseCurve; // 0x18
	UnityEngine.AnimationCurve _fallCurve; // 0x20
	UnityEngine.AnimationCurve get_RiseCurve(); // 0x057e3b54
	UnityEngine.AnimationCurve get_FallCurve(); // 0x057e3bb8
	System.Void OnValidate(); // 0x057e3c1c
	System.Void ClampCurveTime(UnityEngine.AnimationCurve curve); // 0x057e3c90
	System.Void .ctor(); // 0x057e3df8
}

// Client.Runtime
class Gemorty2DMath : System.Object
{
	static Gemorty2DMath _instance; // 0x0
	static Gemorty2DMath get_Instance(); // 0x057e3eb0
	System.Single Direction2EulerAngleY(UnityEngine.Vector2 LineStart, UnityEngine.Vector2 LineEnd); // 0x057e3fcc
	UnityEngine.Quaternion Direction2Quaternion(UnityEngine.Vector2 LineStart, UnityEngine.Vector2 LineEnd); // 0x057e40a4
	UnityEngine.Vector2 EulerAngleY2Direction(System.Single y); // 0x057e41e0
	System.Void .ctor(); // 0x057e3f64
}

// Client.Runtime
class NavMeshBakeSurface : System.Object
{
	UnityEngine.Vector3 Center; // 0x10
	UnityEngine.Vector3 Size; // 0x1c
	System.Void .ctor(); // 0x057e437c
}

// Client.Runtime
class BakeSurfaceEntry : System.Object
{
	System.String SceneName; // 0x10
	NavMeshBakeSurface Surface; // 0x18
	System.Void .ctor(); // 0x057e43e4
}

// Client.Runtime
class NavMeshBakeConfig : UnityEngine.ScriptableObject
{
	System.Collections.Generic.List<BakeSurfaceEntry> BakeSurfaceList; // 0x18
	System.Collections.Generic.Dictionary<System.String,BakeSurfaceEntry> BakeSurfaceDict; // 0x20
	System.Void InitializeDict(); // 0x057e4480
	System.Void AddScene(System.String sceneName); // 0x057e4648
	System.Boolean ContainsScene(System.String sceneName); // 0x057e4864
	System.Void .ctor(); // 0x057e4950
}

// Client.Runtime
class SwarmAITreeList : UnityEngine.ScriptableObject
{
	System.Collections.Generic.List<System.String> TreeNames; // 0x18
	System.Void .ctor(); // 0x057e4a5c
}

// Client.Runtime
enum BlueprintBuildState : System.Enum
{
	System.Int32 value__; // 0x10
	static BlueprintBuildState Normal = 0;
	static BlueprintBuildState Good = 1;
	static BlueprintBuildState Bad = 2;
	static BlueprintBuildState Good_InWater = 3;
	static BlueprintBuildState Bad_InWater = 4;
	
}

// Client.Runtime
class ConstructionBluePrint : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	System.String MapId; // 0x30
	System.Single maxBuildDistance; // 0x38
	System.Int32 blueprintId; // 0x3c
	UnityEngine.GameObject _socketFreeObj; // 0x40
	BlueprintBuildState _state; // 0x48
	ConstructionBlueprintPrefabMeshList blueprintMeshList; // 0x50
	WizardGames.Soc.Common.Unity.AreaCheck.CheckNodeBase[] checkNodeList; // 0x58
	System.Boolean canBuild; // 0x60
	WizardGames.Soc.Common.Unity.Construction.RuntimeSockets.BlueprintTerrainRuntimeSocket _terrainSocketRuntime; // 0x68
	WizardGames.AssetPool.AssetPoolHandle buildGood; // 0x70
	WizardGames.AssetPool.AssetPoolHandle buildgBad; // 0x78
	WizardGames.AssetPool.AssetPoolHandle buildGood_InWater; // 0x80
	WizardGames.AssetPool.AssetPoolHandle buildgBad_InWater; // 0x88
	System.Single socketOriginPosY; // 0x90
	System.Void Init(); // 0x057e4b10
	System.Void Awake(); // 0x057e5090
	System.Void InToShadowMode(); // 0x057e5028
	System.Void RaiseHoldingBlueprintByDirAndHeight(System.Int32 dir, System.Single step); // 0x057e5614
	System.Single get_MaxBuildDistance(); // 0x057e57c0
	WizardGames.Soc.Common.Unity.Construction.Placement DoPlacement(WizardGames.Soc.Common.Unity.Construction.BuildingTarget& target); // 0x057e5824
	System.Boolean CheckNodeList(System.Int32& errorInfo, System.String& errorParam); // 0x057e58b8
	System.Void RefreshBuildState(System.Int32& errorInfo, System.String& errorParam, System.Boolean isInWater); // 0x057e59e8
	System.Void SetBuildState(BlueprintBuildState state); // 0x057e51e8
	System.Void .ctor(); // 0x057e5b88
	static System.Void .cctor(); // 0x057e5bf0
}

// Client.Runtime
class ConstructionBlueprintPrefabMeshList : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.List<UnityEngine.MeshRenderer> meshList; // 0x30
	System.Collections.Generic.List<UnityEngine.MeshRenderer> get_MeshList(); // 0x057e5cc4
	System.Void Search(); // 0x057e5d28
	System.Void ClearAll(); // 0x057e6078
	System.Void .ctor(); // 0x057e6118
	static System.Void .cctor(); // 0x057e6180
}

// Client.Runtime
class BuildingProximity : UnityEngine.MonoBehaviour
{
	static System.Single CHECK_RADIUS = 2;
	static System.Single CHECK_FORGIVENESS = 0.012649999931454659;
	static System.Single FOUNDATION_WIDTH = 3.7950000762939453;
	static System.Single FOUNDATION_EXTENTS = 1.8975000381469727;
	System.Void OnDrawGizmosSelected(); // 0x057e6254
	System.Void DrawGizmosWithIns(UnityEngine.Transform partIns); // 0x057e62c8
	static System.Boolean Check(WizardGames.Soc.Common.Entity.PartEntity construction, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); // 0x057e637c
	static BuildingProximity.ProximityInfo GetProximity(WizardGames.Soc.Common.Component.ConstructionSocketBaseComponent socketComp1, UnityEngine.Vector3 position1, UnityEngine.Quaternion rotation1, WizardGames.Soc.Common.Component.ConstructionSocketBaseComponent socketComp2, UnityEngine.Vector3 position2, UnityEngine.Quaternion rotation2); // 0x057e6a00
	UnityEngine.Vector3 GetSelectPivot(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); // 0x057e6f94
	System.Void .ctor(); // 0x057e70a8
}

// Client.Runtime
struct BuildingProximity.ProximityInfo : System.ValueType
{
	System.Boolean hit; // 0x10
	System.Boolean connection; // 0x11
	Line line; // 0x14
	System.Single sqrDist; // 0x2c
	
}

// Client.Runtime
class ContainerCheckConfig : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	ContainerCheckConfig.ContainerCheckSlotConfig[] slotConfigs; // 0x30
	UnityEngine.RaycastHit[] hitResults; // 0x38
	System.Void OnDrawGizmosSelected(); // 0x057e7110
	System.Void DrawGizmosWithIns(UnityEngine.Transform partIns); // 0x057e7184
	System.Boolean CheckRayView(WizardGames.Soc.Common.Entity.PartEntity partEntity, UnityEngine.Ray viewRay, System.Boolean checkForward); // 0x057e731c
	System.Boolean IsPointInForwoarAndNoRaycast(UnityEngine.Vector3 point, UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 cameraforward, System.Int64 targetEntityId, System.Boolean checkForward); // 0x057e74e0
	System.Void .ctor(); // 0x057e7c30
	static System.Void .cctor(); // 0x057e7cc8
}

// Client.Runtime
class ContainerCheckConfig.ContainerCheckSlotConfig : System.Object
{
	UnityEngine.Vector3 handlePosition; // 0x10
	System.Void .ctor(); // 0x057e7d9c
}

// Client.Runtime
class GroundWatchConfig : UnityEngine.MonoBehaviour
{
	UnityEngine.LayerMask layers; // 0x30
	System.Single radius; // 0x34
	System.Void OnDrawGizmosSelected(); // 0x057e7e04
	System.Void .ctor(); // 0x057e7ee8
}

// Client.Runtime
class ConstructionConfigPoint : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x057e7f5c
}

// Client.Runtime
class ConstructionSkinNodeConfig : UnityEngine.MonoBehaviour
{
	UnityEngine.Transform LockTrans; // 0x30
	UnityEngine.Transform EffectSocketRootTrigger; // 0x38
	UnityEngine.Transform EffectSocketRootIdle; // 0x40
	System.Void .ctor(); // 0x057e7fc4
}

// Client.Runtime
class SocControlCurve : UnityEngine.ScriptableObject
{
	UnityEngine.AnimationCurve speedCurveX; // 0x18
	UnityEngine.AnimationCurve distanceCurveX; // 0x20
	UnityEngine.AnimationCurve speedCurveY; // 0x28
	UnityEngine.AnimationCurve distanceCurveY; // 0x30
	UnityEngine.AnimationCurve AimSnapSlowdownCoe; // 0x38
	System.Void .ctor(); // 0x057e802c
}

// Client.Runtime
interface IPredictHitTarget : 
{
	
	System.Void AddPredictHitTarget(System.Int64 entityID); // 0x055112ac
	System.Boolean HasPredictHitTarget(System.Int64 entityID); // 0x054c5f44
}

// Client.Runtime
class BaseParachuteGoCapsuleTrigger : UnityEngine.MonoBehaviour
{
	WizardGames.Soc.Common.Unity.Go.BaseParachuteGo baseParachuteGo; // 0x30
	System.Void Init(WizardGames.Soc.Common.Unity.Go.BaseParachuteGo _baseParachuteGo); // 0x057e8094
	System.Void OnTriggerEnter(UnityEngine.Collider collision); // 0x057e8114
	System.Void .ctor(); // 0x057e8194
}

// Client.Runtime
class ItemMod : UnityEngine.MonoBehaviour
{
	ItemMod[] siblingMods; // 0x30
	System.Void ModInit(); // 0x057e81fc
	System.Void .ctor(); // 0x057e8288
}

// Client.Runtime
class NavMeshTools : System.Object
{
	static SocLogger logger; // 0x0
	static System.Void CollectSourcesSync(UnityEngine.Bounds bounds, System.Int32 mask, UnityEngine.AI.NavMeshCollectGeometry geometry, System.Int32 area, System.Boolean useBakedTerrainMesh, System.Int32 cellSize, System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources, System.Action<System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>> append, System.Action callback, UnityEngine.Transform customNavMeshDataRoot); // 0x057e82f0
	static System.Void .cctor(); // 0x057e8680
}

// Client.Runtime
class BasePath : UnityEngine.MonoBehaviour
{
	System.Collections.Generic.List<BasePathNode> nodes; // 0x30
	System.Collections.Generic.List<PathInterestNode> interestZones; // 0x38
	System.Collections.Generic.List<PathSpeedZone> speedZones; // 0x40
	System.Void AddChildren(); // 0x057e8754
	System.Void ClearChildren(); // 0x057e8940
	static System.Void AutoGenerateLinks(BasePath path, System.Int32 layer); // 0x057e8b14
	System.Void GetNodesNear(UnityEngine.Vector3 point, System.Collections.Generic.List<BasePathNode>& nearNodes, System.Single dist); // 0x057e9094
	System.Void GetNodesNear(UnityEngine.Vector3 point, System.Collections.Generic.List<BasePathNode>& nearNodesBoth, System.Collections.Generic.List<BasePathNode>& nearNodesGun, System.Collections.Generic.List<BasePathNode>& nearNodesCannon, System.Collections.Generic.List<BasePathNode>& nearNodesAny, System.Single[] distBoth, System.Single[] distGun, System.Single[] distCannon, System.Single dist); // 0x057e9394
	BasePathNode GetClosestToPoint(UnityEngine.Vector3 point); // 0x057e9924
	PathInterestNode GetRandomInterestNodeAwayFrom(UnityEngine.Vector3 from, System.Single dist); // 0x057e9bdc
	System.Void .ctor(); // 0x057e9e34
}

// Client.Runtime
class BasePathNode : UnityEngine.MonoBehaviour
{
	BasePath Path; // 0x30
	System.Collections.Generic.List<BasePathNode> linked; // 0x38
	System.Boolean IsUsing; // 0x40
	System.Boolean straightaway; // 0x41
	System.Void .ctor(); // 0x057e9e9c
}

// Client.Runtime
class PathInterestNode : UnityEngine.MonoBehaviour
{
	System.Single <NextVisitTime>k__BackingField; // 0x30
	System.Single get_NextVisitTime(); // 0x057e9f04
	System.Void set_NextVisitTime(System.Single value); // 0x057e9f68
	System.Void OnDrawGizmos(); // 0x057e9fe0
	System.Void .ctor(); // 0x057ea07c
}

// Client.Runtime
class PathSpeedZone : UnityEngine.MonoBehaviour
{
	UnityEngine.Bounds bounds; // 0x30
	WizardGames.Soc.Common.Unity.Utility.OBB obbBounds; // 0x48
	System.Single maxVelocityPerSec; // 0x98
	WizardGames.Soc.Common.Unity.Utility.OBB WorldSpaceBounds(); // 0x057ea0e4
	System.Single GetMaxSpeed(); // 0x057ea240
	System.Void OnDrawGizmosSelected(); // 0x057ea2a4
	System.Void .ctor(); // 0x057ea3c8
}

// Client.Runtime
class SoundClass : UnityEngine.ScriptableObject
{
	UnityEngine.Audio.AudioMixerGroup output; // 0x18
	UnityEngine.Audio.AudioMixerGroup firstPersonOutput; // 0x20
	System.Boolean enableOcclusion; // 0x28
	System.Boolean playIfOccluded; // 0x29
	System.Single occlusionGain; // 0x2c
	UnityEngine.Audio.AudioMixerGroup occludedOutput; // 0x30
	System.Int32 globalVoiceMaxCount; // 0x38
	System.Int32 priority; // 0x3c
	System.Void .ctor(); // 0x057ea438
}

// Client.Runtime
class Model : UnityEngine.MonoBehaviour
{
	UnityEngine.SphereCollider collision; // 0x30
	UnityEngine.Transform rootBone; // 0x38
	UnityEngine.Transform headBone; // 0x40
	UnityEngine.Transform eyeBone; // 0x48
	UnityEngine.Animator animator; // 0x50
	UnityEngine.Transform[] boneTransforms; // 0x58
	System.String[] boneNames; // 0x60
	System.Int32 skin; // 0x68
	System.Void OnEnable(); // 0x057ea4bc
	System.Void BuildBoneDictionary(); // 0x057ea524
	System.Int32 GetSkin(); // 0x057ea5ac
	UnityEngine.Transform FindBoneInternal(System.String name); // 0x057ea610
	UnityEngine.Transform FindBone(System.String name); // 0x057ea6a8
	UnityEngine.Transform FindBone(System.UInt32 hash); // 0x057ea740
	System.UInt32 FindBoneID(UnityEngine.Transform transform); // 0x057ea7d8
	UnityEngine.Transform[] GetBones(); // 0x057ea870
	UnityEngine.Transform FindClosestBone(UnityEngine.Vector3 worldPos); // 0x057ea8f8
	System.Void .ctor(); // 0x057eaacc
}

// Client.Runtime
class SteerAngleCurveConfig : UnityEngine.ScriptableObject
{
	System.Boolean EnableSteerAngleForSpeed; // 0x18
	UnityEngine.AnimationCurve SteerAngleForSpeed; // 0x20
	System.Boolean EnableSteerSpeedForSpeed; // 0x28
	UnityEngine.AnimationCurve SteerSpeedForSpeed; // 0x30
	System.Void .ctor(); // 0x057eab34
}

// Client.Runtime
class CoverageQueryFlare : UnityEngine.MonoBehaviour
{
	System.Boolean isDynamic; // 0x30
	System.Boolean timeShimmer; // 0x31
	System.Boolean positionalShimmer; // 0x32
	System.Boolean rotate; // 0x33
	System.Single maxVisibleDistance; // 0x34
	System.Boolean lightScaled; // 0x38
	System.Single dotMin; // 0x3c
	System.Single dotMax; // 0x40
	System.Single coverageRadius; // 0x44
	System.Void .ctor(); // 0x057eaba8
}

// Client.Runtime
class BaseCombatEntity : BaseRustEntity
{
	ProtectionProperties baseProtection; // 0xf8
	System.Single startHealth; // 0x100
	System.Boolean ShowHealthInfo; // 0x104
	BaseCombatEntity.LifeState lifestate; // 0x108
	System.Boolean sendsHitNotification; // 0x10c
	System.Boolean sendsMeleeHitNotification; // 0x10d
	System.Boolean markAttackerHostile; // 0x10e
	System.Single _health; // 0x110
	System.Single _maxHealth; // 0x114
	BaseCombatEntity.Faction faction; // 0x118
	System.Single lastAttackedTime; // 0x11c
	UnityEngine.Vector3 <LastAttackedDir>k__BackingField; // 0x120
	System.Single lastDealtDamageTime; // 0x12c
	System.Int32 lastNotifyFrame; // 0x130
	Soc.Vehicle.DamageType lastDamage; // 0x134
	BaseRustEntity lastAttacker; // 0x138
	BaseRustEntity lastDealtDamageTo; // 0x140
	System.Boolean ResetLifeStateOnSpawn; // 0x148
	System.Single unHostileTime; // 0x14c
	BaseCombatEntity.ActionVolume <LastNoiseVolume>k__BackingField; // 0x150
	UnityEngine.Vector3 <LastNoisePosition>k__BackingField; // 0x154
	System.Single lastNoiseTime; // 0x160
	System.Boolean IsDead(); // 0x057eac2c
	System.Boolean IsAlive(); // 0x057eac98
	BaseCombatEntity.Faction GetFaction(); // 0x057ead04
	System.Boolean IsFriendly(BaseCombatEntity other); // 0x057ead68
	UnityEngine.Vector3 get_LastAttackedDir(); // 0x057eade0
	System.Void set_LastAttackedDir(UnityEngine.Vector3 value); // 0x057eae48
	System.Single get_SecondsSinceAttacked(); // 0x057eaee4
	System.Single get_SecondsSinceDealtDamage(); // 0x057eaf54
	System.Single get_healthFraction(); // 0x057eafc4
	System.Void ResetState(); // 0x057eb060
	System.Void DestroyShared(); // 0x057eb2d0
	System.Single GetThreatLevel(); // 0x057eb440
	System.Single PenetrationResistance(HitInfo info); // 0x057eb4a4
	System.Void ScaleDamage(HitInfo info); // 0x057eb56c
	Soc.Vehicle.HitArea SkeletonLookup(System.UInt32 boneID); // 0x057eb650
	System.Void Save(BaseNetworkable.SaveInfo info); // 0x057eb6e8
	System.Void PostServerLoad(); // 0x057eb824
	System.Void Load(BaseNetworkable.LoadInfo info); // 0x057eb9c4
	System.Single get_health(); // 0x057eba5c
	System.Void set_health(System.Single value); // 0x057eb18c
	System.Single Health(); // 0x057ebac0
	System.Single MaxHealth(); // 0x057ebbfc
	System.Single StartHealth(); // 0x057ebd3c
	System.Single StartMaxHealth(); // 0x057ebda0
	System.Void SetMaxHealth(System.Single newMax); // 0x057ebe04
	System.Void DoHitNotify(HitInfo info); // 0x057ebe8c
	System.Void OnAttacked(HitInfo info); // 0x057ebf24
	System.Void InitializeHealth(System.Single newhealth, System.Single newmax); // 0x057ebfbc
	System.Void OnHealthChanged(System.Single oldvalue, System.Single newvalue); // 0x057ec044
	System.Void Hurt(System.Single amount); // 0x057ec0c0
	System.Void Hurt(System.Single amount, Soc.Vehicle.DamageType type, BaseRustEntity attacker, System.Boolean useProtection); // 0x057ec148
	System.Void Hurt(HitInfo info); // 0x057ec208
	System.Void Hurt(WizardGames.Soc.Common.SimpleCustom.HitRequest hitRequest); // 0x057ec2a0
	System.Boolean IsHostile(); // 0x057ec314
	System.Void MarkHostileFor(System.Single duration); // 0x057ec394
	System.Void DebugHurt(HitInfo info); // 0x057ec424
	System.Void SetHealth(System.Single hp); // 0x057ec4bc
	System.Void Heal(System.Single amount); // 0x057ec554
	System.Void OnKilled(HitInfo info); // 0x057ec5ec
	System.Void Die(HitInfo info); // 0x057ec700
	System.Void DieInstantly(); // 0x057ec798
	System.Void UpdateSurroundings(); // 0x057eb3b8
	System.Single get_TimeSinceLastNoise(); // 0x057ec844
	BaseCombatEntity.ActionVolume get_LastNoiseVolume(); // 0x057ec8b4
	System.Void set_LastNoiseVolume(BaseCombatEntity.ActionVolume value); // 0x057ec918
	UnityEngine.Vector3 get_LastNoisePosition(); // 0x057ec990
	System.Void set_LastNoisePosition(UnityEngine.Vector3 value); // 0x057ec9f8
	System.Void MakeNoise(UnityEngine.Vector3 position, BaseCombatEntity.ActionVolume loudness); // 0x057eca94
	System.Boolean CanLastNoiseBeHeard(UnityEngine.Vector3 listenPosition, System.Single listenRange); // 0x057ecbec
	System.Void .ctor(); // 0x057ecd6c
}

// Client.Runtime
enum BaseCombatEntity.LifeState : System.Enum
{
	System.Int32 value__; // 0x10
	static BaseCombatEntity.LifeState Alive = 0;
	static BaseCombatEntity.LifeState Dead = 1;
	
}

// Client.Runtime
enum BaseCombatEntity.Faction : System.Enum
{
	System.Int32 value__; // 0x10
	static BaseCombatEntity.Faction Default = 0;
	static BaseCombatEntity.Faction Player = 1;
	static BaseCombatEntity.Faction Bandit = 2;
	static BaseCombatEntity.Faction Scientist = 3;
	static BaseCombatEntity.Faction Horror = 4;
	
}

// Client.Runtime
enum BaseCombatEntity.ActionVolume : System.Enum
{
	System.Int32 value__; // 0x10
	static BaseCombatEntity.ActionVolume Quiet = 0;
	static BaseCombatEntity.ActionVolume Normal = 1;
	static BaseCombatEntity.ActionVolume Loud = 2;
	
}

// Client.Runtime
class BaseCorpse : BaseCombatEntity
{
	GameObjectRef prefabRagdoll; // 0x168
	BaseRustEntity parentEnt; // 0x170
	System.Void ServerInit(WizardGames.Soc.Common.Entity.IEntity entity, WizardGames.Soc.Common.Unity.Go.BaseEntityGo entityGo); // 0x057eceb4
	System.Void InitCorpse(BaseRustEntity pr); // 0x057ed0c8
	System.Boolean CanRemove(); // 0x057ed26c
	System.Void RemoveCorpse(); // 0x057ed2d0
	System.Void ResetRemovalTime(System.Single dur); // 0x057ed360
	System.Single GetRemovalTime(); // 0x057ed3f8
	System.Void ResetRemovalTime(); // 0x057ecfd4
	System.Void Save(BaseNetworkable.SaveInfo info); // 0x057ed480
	System.Void TakeChildren(BaseRustEntity takeChildrenFrom); // 0x057ed524
	System.Void ApplyInheritedVelocity(UnityEngine.Vector3 velocity); // 0x057ed5bc
	UnityEngine.Rigidbody SetupRigidBody(); // 0x057ecf4c
	System.Void Load(BaseNetworkable.LoadInfo info); // 0x057ed64c
	System.Void OnAttacked(HitInfo info); // 0x057ed6f0
	System.String Categorize(); // 0x057ed788
	System.Boolean ShouldInheritNetworkGroup(); // 0x057ed800
	System.Void .ctor(); // 0x057ed864
}

// Client.Runtime
class BaseRustEntity : BaseNetworkable
{
	static SocLogger logger; // 0x0
	BaseRustEntity creatorEntity; // 0x78
	System.Int32 ticksSinceStopped; // 0x80
	System.Int32 doneMovingWithoutARigidBodyCheck; // 0x84
	System.Boolean isCallingUpdateNetworkGroup; // 0x88
	WizardGames.Soc.Common.Entity.IEntity Entity; // 0x90
	WizardGames.Soc.Common.Unity.Go.BaseMountableGo EntityGo; // 0x98
	UnityEngine.Bounds bounds; // 0xa0
	GameObjectRef impactEffect; // 0xb8
	System.Boolean enableSaving; // 0xc0
	System.Boolean syncPosition; // 0xc1
	Model model; // 0xc8
	System.UInt32 parentBone; // 0xd0
	System.UInt64 skinID; // 0xd8
	System.Boolean HasBrain; // 0xe0
	System.String _name; // 0xe8
	System.UInt64 <OwnerID>k__BackingField; // 0xf0
	System.Single get_RealisticMass(); // 0x057ed8c8
	System.Void OnCollision(UnityEngine.Collision collision, BaseRustEntity hitEntity); // 0x057ed930
	System.Void ReceiveCollisionMessages(System.Boolean b); // 0x057ed9d0
	System.Boolean HasFlag(BaseRustEntity.Flags f); // 0x057eda68
	System.Boolean ParentHasFlag(BaseRustEntity.Flags f); // 0x057edb68
	System.Void CopyFlag(BaseRustEntity.Flags f, System.Int32 flagValue); // 0x057edc84
	System.Void SetFlag(BaseRustEntity.Flags f, System.Boolean b, System.Boolean recursive, System.Boolean networkupdate); // 0x057edd18
	System.Boolean IsOn(); // 0x057ee0b0
	System.Boolean IsOpen(); // 0x057ee118
	System.Boolean IsOnFire(); // 0x057ee180
	System.Boolean IsLocked(); // 0x057ee1e8
	System.Boolean IsDisabled(); // 0x057ee250
	System.Boolean IsBroken(); // 0x057ee2d8
	System.Boolean IsBusy(); // 0x057ee340
	System.Void OnFlagsChanged(BaseRustEntity.Flags old, BaseRustEntity.Flags next); // 0x057ee3a8
	System.Void SendNetworkUpdate_Flags(); // 0x057ee424
	System.Void ClientRPCWrite<T>(T arg); // 0x052af1f0
	UnityEngine.Vector3 GetLocalVelocityServer(); // 0x057ee4ac
	UnityEngine.Quaternion GetAngularVelocityServer(); // 0x057ee544
	System.Void EnableGlobalBroadcast(System.Boolean wants); // 0x057ee5dc
	System.Void EnableSaving(System.Boolean wants); // 0x057ee664
	System.Single get_PositionTickRate(); // 0x057ee6fc
	System.Boolean get_PositionTickFixedTime(); // 0x057ee764
	System.Void NetworkPositionTick(); // 0x057ee7c8
	System.Void TransformChanged(); // 0x057ee890
	System.Void DoMovingWithoutARigidBodyCheck(); // 0x057ee918
	System.Void Spawn(); // 0x057eeb54
	System.Void OnParentSpawning(); // 0x057eec18
	System.Void SpawnAsMapEntity(); // 0x057eeca0
	System.Void DoServerDestroy(); // 0x057eed28
	System.Void OnParentRemoved(); // 0x057eedb0
	System.Void OnInvalidPosition(); // 0x057eee18
	BaseCorpse DropCorpse(System.String strCorpsePrefab); // 0x057eefc0
	System.Void UpdateNetworkGroup(); // 0x057ef058
	System.Boolean ShouldNetworkTo(BasePlayer player); // 0x057ef0e0
	System.Void Push(UnityEngine.Vector3 velocity); // 0x057ef178
	System.Void ApplyInheritedVelocity(UnityEngine.Vector3 velocity); // 0x057ef204
	System.Void SetVelocity(UnityEngine.Vector3 velocity); // 0x057ef2b4
	System.Void SetAngularVelocity(UnityEngine.Vector3 velocity); // 0x057ef3ec
	UnityEngine.Vector3 GetDropPosition(); // 0x057ef524
	UnityEngine.Vector3 GetDropVelocity(); // 0x057ef59c
	System.Boolean OnStartBeingLooted(BasePlayer baseEntity); // 0x057ef678
	UnityEngine.Vector3 get_ServerPosition(); // 0x057ef6f0
	System.Void set_ServerPosition(UnityEngine.Vector3 value); // 0x057ef768
	UnityEngine.Quaternion get_ServerRotation(); // 0x057ef894
	System.Void set_ServerRotation(UnityEngine.Quaternion value); // 0x057ef90c
	System.String Admin_Who(); // 0x057efa40
	BasePlayer ToPlayer(); // 0x057efb44
	System.Boolean get_IsNpc(); // 0x057efba8
	System.Void InitShared(); // 0x057efc0c
	System.Void DestroyShared(); // 0x057eb354
	System.Void ResetState(); // 0x057eb0fc
	System.Single InheritedVelocityScale(); // 0x057efde4
	UnityEngine.Vector3 GetInheritedProjectileVelocity(); // 0x057efe48
	UnityEngine.Vector3 GetInheritedThrowVelocity(); // 0x057f010c
	UnityEngine.Vector3 GetInheritedDropVelocity(); // 0x057f0170
	UnityEngine.Vector3 GetParentVelocity(); // 0x057eff6c
	UnityEngine.Vector3 GetWorldVelocity(); // 0x057f0254
	UnityEngine.Vector3 GetLocalVelocity(); // 0x057f04c8
	UnityEngine.Quaternion GetAngularVelocity(); // 0x057f0414
	WizardGames.Soc.Common.Unity.Utility.OBB WorldSpaceBounds(); // 0x057f057c
	UnityEngine.Vector3 PivotPoint(); // 0x057f06d8
	UnityEngine.Vector3 CenterPoint(); // 0x057ed1e8
	UnityEngine.Vector3 ClosestPoint(UnityEngine.Vector3 position); // 0x057f0750
	UnityEngine.Vector3 TriggerPoint(); // 0x057f082c
	System.Single Distance(UnityEngine.Vector3 position); // 0x057f0890
	System.Single SqrDistance(UnityEngine.Vector3 position); // 0x057f09a8
	System.Single Distance(BaseRustEntity other); // 0x057f0a6c
	System.Single SqrDistance(BaseRustEntity other); // 0x057f0b04
	System.Single Distance2D(UnityEngine.Vector3 position); // 0x057f0b9c
	System.Single SqrDistance2D(UnityEngine.Vector3 position); // 0x057f0c80
	System.Single Distance2D(BaseRustEntity other); // 0x057f0d30
	System.Single SqrDistance2D(BaseRustEntity other); // 0x057f0dc8
	System.Boolean IsVisible(UnityEngine.Ray ray, System.Int32 layerMask, System.Single maxDistance); // 0x057f0e60
	System.Boolean IsVisibleSpecificLayers(UnityEngine.Vector3 position, UnityEngine.Vector3 target, System.Int32 layerMask, System.Single maxDistance); // 0x057f0f30
	System.Boolean IsVisible(UnityEngine.Vector3 position, UnityEngine.Vector3 target, System.Single maxDistance); // 0x057f11ac
	System.Boolean IsVisible(UnityEngine.Vector3 position, System.Single maxDistance); // 0x057f128c
	System.Boolean IsVisibleAndCanSee(UnityEngine.Vector3 position, System.Single maxDistance); // 0x057f13a0
	System.Boolean IsOlderThan(BaseRustEntity other); // 0x057f1530
	System.Boolean IsOutside(); // 0x057f15c8
	System.Boolean IsOutside(UnityEngine.Vector3 position); // 0x057f1660
	System.Single WaterFactor(); // 0x057f1710
	System.Single AirFactor(); // 0x057f1774
	System.Boolean BlocksWaterFor(BasePlayer player); // 0x057f1800
	System.Single Health(); // 0x057f1878
	System.Single MaxHealth(); // 0x057f18dc
	System.Single MaxVelocity(); // 0x057f1940
	System.Single BoundsPadding(); // 0x057f19a4
	System.Single PenetrationResistance(HitInfo info); // 0x057f1a0c
	GameObjectRef GetImpactEffect(HitInfo info); // 0x057f1a88
	System.Void OnAttacked(HitInfo info); // 0x057f1b00
	System.Boolean CanBeLooted(BasePlayer player); // 0x057f1b74
	BaseRustEntity GetEntity(); // 0x057f1bec
	System.String ToString(); // 0x057f1c50
	System.String Categorize(); // 0x057f1cd8
	System.Void Log(System.String str); // 0x057f1d50
	System.Void SetModel(Model mdl); // 0x057f1f98
	Model GetModel(); // 0x057f2064
	UnityEngine.Transform[] GetBones(); // 0x057f20c8
	UnityEngine.Transform FindBone(System.String strName); // 0x057f217c
	System.UInt32 FindBoneID(UnityEngine.Transform boneTransform); // 0x057f2250
	UnityEngine.Transform FindClosestBone(UnityEngine.Vector3 worldPos); // 0x057f234c
	System.UInt64 get_OwnerID(); // 0x057f2448
	System.Void set_OwnerID(System.UInt64 value); // 0x057f24ac
	System.Boolean ShouldBlockProjectiles(); // 0x057f2524
	System.Boolean ShouldInheritNetworkGroup(); // 0x057f2588
	System.Boolean SupportsChildDeployables(); // 0x057f25ec
	System.Void .ctor(); // 0x057ece20
	static System.Void .cctor(); // 0x057f270c
}

// Client.Runtime
enum BaseRustEntity.Flags : System.Enum
{
	System.Int32 value__; // 0x10
	static BaseRustEntity.Flags Placeholder = 1;
	static BaseRustEntity.Flags On = 2;
	static BaseRustEntity.Flags OnFire = 4;
	static BaseRustEntity.Flags Open = 8;
	static BaseRustEntity.Flags Locked = 16;
	static BaseRustEntity.Flags Failed = 32;
	static BaseRustEntity.Flags Disabled = 64;
	static BaseRustEntity.Flags Reserved1 = 128;
	static BaseRustEntity.Flags Reserved2 = 256;
	static BaseRustEntity.Flags Reserved3 = 512;
	static BaseRustEntity.Flags Reserved4 = 1024;
	static BaseRustEntity.Flags Reserved5 = 2048;
	static BaseRustEntity.Flags Broken = 4096;
	static BaseRustEntity.Flags Busy = 8192;
	static BaseRustEntity.Flags Reserved6 = 16384;
	static BaseRustEntity.Flags Reserved7 = 32768;
	static BaseRustEntity.Flags Reserved8 = 65536;
	static BaseRustEntity.Flags Reserved9 = 131072;
	static BaseRustEntity.Flags Reserved10 = 262144;
	static BaseRustEntity.Flags Reserved11 = 524288;
	static BaseRustEntity.Flags Starting = 1048576;
	
}

// Client.Runtime
class BaseRustEntity.RPC_Shared : System.Attribute
{
	
	System.Void .ctor(); // 0x057f27e0
}

// Client.Runtime
struct BaseRustEntity.RPCMessage : System.ValueType
{
	BasePlayer player; // 0x10
	
}

// Client.Runtime
class BaseRustEntity.RPC_Server : BaseRustEntity.RPC_Shared
{
	
	System.Void .ctor(); // 0x057f2848
}

// Client.Runtime
class BaseNetworkable : UnityEngine.MonoBehaviour
{
	System.UInt32 prefabID; // 0x30
	System.Boolean globalBroadcast; // 0x34
	System.Boolean <IsDestroyed>k__BackingField; // 0x35
	System.String _prefabName; // 0x38
	System.String _prefabNameWithoutExtension; // 0x40
	static System.Boolean isServersideEntity = true;
	BaseRustEntity parentEntity; // 0x48
	System.Collections.Generic.List<BaseRustEntity> children; // 0x50
	System.Boolean canTriggerParent; // 0x58
	System.Int32 creationFrame; // 0x5c
	System.Boolean isSpawned; // 0x60
	System.IO.MemoryStream _NetworkCache; // 0x68
	static System.Collections.Generic.Queue<System.IO.MemoryStream> EntityMemoryStreamPool; // 0x0
	System.IO.MemoryStream _SaveCache; // 0x70
	System.Boolean get_IsDestroyed(); // 0x057f28ac
	System.Void set_IsDestroyed(System.Boolean value); // 0x057f2910
	System.String get_PrefabName(); // 0x057f298c
	System.String get_ShortPrefabName(); // 0x057f2a40
	UnityEngine.Vector3 GetNetworkPosition(); // 0x057f2b00
	UnityEngine.Quaternion GetNetworkRotation(); // 0x057f2b78
	System.String InvokeString(); // 0x057f2bf0
	BaseRustEntity LookupPrefab(); // 0x057f2c78
	System.Boolean EqualNetID(BaseNetworkable other); // 0x057f2d00
	System.Boolean EqualNetID(System.UInt32 otherID); // 0x057f2d98
	System.Void ResetState(); // 0x057efd30
	System.Void Awake(); // 0x057f2e30
	System.Void InitShared(); // 0x057efc70
	System.Void DestroyShared(); // 0x057efcd0
	System.Void OnNetworkGroupChange(); // 0x057f2e90
	System.Void EntityDestroy(); // 0x057f2f18
	System.Void DoEntityDestroy(); // 0x057f2fa0
	System.Void SpawnShared(); // 0x057f3028
	System.Void Save(BaseNetworkable.SaveInfo info); // 0x057eb78c
	System.Void InitLoad(System.UInt32 entityID); // 0x057f30b0
	System.Void PreServerLoad(); // 0x057f3148
	System.Void Load(BaseNetworkable.LoadInfo info); // 0x057f31a8
	System.Void PostServerLoad(); // 0x057eb93c
	System.Boolean get_isServer(); // 0x057eb26c
	System.Boolean get_isClient(); // 0x057f1f34
	T ToServer<T>(); // 0x052af1f0
	BaseRustEntity GetParentEntity(); // 0x057f3240
	System.Boolean HasParent(); // 0x057f32a4
	System.Void AddChild(BaseRustEntity child); // 0x057f3338
	System.Void OnChildAdded(BaseRustEntity child); // 0x057f3464
	System.Void RemoveChild(BaseRustEntity child); // 0x057f34d8
	System.Void OnChildRemoved(BaseRustEntity child); // 0x057f3578
	System.Single GetNetworkTime(); // 0x057f35ec
	System.Void Spawn(); // 0x057eebb8
	System.Boolean IsFullySpawned(); // 0x057f3650
	System.Void ServerInit(WizardGames.Soc.Common.Entity.IEntity entity, WizardGames.Soc.Common.Unity.Go.BaseEntityGo entityGo); // 0x057ed04c
	System.Void KillMessage(); // 0x057f36b4
	System.Void AdminKill(); // 0x057f371c
	System.Void Kill(BaseNetworkable.DestroyMode mode); // 0x057ec668
	System.Void TerminateOnClient(BaseNetworkable.DestroyMode mode); // 0x057f3784
	System.Void TerminateOnServer(); // 0x057f381c
	System.Void DoServerDestroy(); // 0x057f38a4
	System.Boolean ShouldNetworkTo(BasePlayer player); // 0x057f3908
	System.Void SendNetworkGroupChange(); // 0x057f39a0
	System.Void SendNetworkUpdateImmediate(System.Boolean justCreated); // 0x057f3a28
	System.Void SendNetworkUpdate_Position(); // 0x057f3ac0
	System.Void ToStream(System.IO.Stream stream, BaseNetworkable.SaveInfo saveInfo); // 0x057f3b48
	System.Void ToStreamForNetwork(System.IO.Stream stream, BaseNetworkable.SaveInfo saveInfo); // 0x057f3be8
	System.Void InvalidateNetworkCache(); // 0x057f3c88
	System.IO.MemoryStream GetSaveCache(); // 0x057f3d10
	System.Void UpdateNetworkGroup(); // 0x057f3d98
	System.Void .ctor(); // 0x057f2650
	static System.Void .cctor(); // 0x057f3e20
}

// Client.Runtime
struct BaseNetworkable.SaveInfo : System.ValueType
{
	System.Boolean forDisk; // 0x10
	
}

// Client.Runtime
struct BaseNetworkable.LoadInfo : System.ValueType
{
	System.Boolean fromDisk; // 0x10
	
}

// Client.Runtime
enum BaseNetworkable.DestroyMode : System.Enum
{
	System.Byte value__; // 0x10
	static BaseNetworkable.DestroyMode None = 0;
	static BaseNetworkable.DestroyMode Gib = 1;
	
}

// Client.Runtime
class BaseNetworkableEx : System.Object
{
	
	static System.Boolean IsValid(BaseNetworkable ent); // 0x057f3eb8
}

// Client.Runtime
struct EntityRef : System.ValueType
{
	BaseRustEntity ent_cached; // 0x10
	System.UInt32 id_cached; // 0x18
	System.Boolean IsValid(System.Boolean serverside); // 0x057f3f40
	BaseRustEntity Get(System.Boolean serverside); // 0x057f3fc0
}

// Client.Runtime
class BasePlayer : System.Object
{
	System.UInt64 currentTeam; // 0x10
	System.Boolean sentInstrumentTeamAchievement; // 0x18
	System.Boolean sentSummerTeamAchievement; // 0x19
	static System.Int32 TEAMMATE_INSTRUMENT_COUNT_ACHIEVEMENT = 4;
	static System.Int32 TEAMMATE_SUMMER_FLOATING_COUNT_ACHIEVEMENT = 4;
	static System.String TEAMMATE_INSTRUMENT_ACHIEVEMENT = "TEAM_INSTRUMENTS";
	static System.String TEAMMATE_SUMMER_ACHIEVEMENT = "SUMMER_INFLATABLE";
	BasePlayer teamLeaderBuffer; // 0x20
	BaseMountable mounted; // 0x28
	System.Boolean isMounted; // 0x30
	System.Single nextSeatSwapTime; // 0x34
	System.UInt32 svActiveItemID; // 0x38
	System.Single NextChatTime; // 0x3c
	System.Single nextSuicideTime; // 0x40
	System.Single nextRespawnTime; // 0x44
	UnityEngine.Vector3 <estimatedVelocity>k__BackingField; // 0x48
	System.Single <estimatedSpeed>k__BackingField; // 0x54
	System.Single <estimatedSpeed2D>k__BackingField; // 0x58
	System.Int32 <secondsConnected>k__BackingField; // 0x5c
	System.Single <desyncTimeRaw>k__BackingField; // 0x60
	System.Single <desyncTimeClamped>k__BackingField; // 0x64
	UnityEngine.Vector3 viewAngles; // 0x68
	static System.Int32 MaxBotIdRange = 10000000;
	System.Single lastSubscriptionTick; // 0x74
	System.Single lastPlayerTick; // 0x78
	System.Single sleepStartTime; // 0x7c
	System.Single fallTickRate; // 0x80
	System.Single lastFallTime; // 0x84
	System.Single fallVelocity; // 0x88
	HitInfo cachedNonSuicideHitInfo; // 0x90
	System.Single cachedCraftLevel; // 0x98
	System.Single nextCheckTime; // 0x9c
	Soc.Vehicle.MountPointInfo CurrentSeat; // 0xa0
	BaseVehicleSeat BaseVehicleSeat; // 0xa8
	System.Boolean isServer; // 0xb0
	WizardGames.Soc.Common.Entity.IMountVehicleEntity mountVehicleEntity; // 0xb8
	UnityEngine.GameObject EntityGo; // 0xc0
	UnityEngine.CapsuleCollider playerCollider; // 0xc8
	UnityEngine.Rigidbody playerRigidbody; // 0xd0
	System.UInt64 userID; // 0xd8
	System.String UserIDString; // 0xe0
	System.Int32 gamemodeteam; // 0xe8
	System.Int32 reputation; // 0xec
	System.String _displayName; // 0xf0
	System.String _lastSetName; // 0xf8
	static System.Single crouchSpeed = 1.7000000476837158;
	static System.Single walkSpeed = 2.799999952316284;
	static System.Single runSpeed = 5.5;
	static System.Single crawlSpeed = 0.7200000286102295;
	BasePlayer.CapsuleColliderInfo playerColliderStanding; // 0x100
	BasePlayer.CapsuleColliderInfo playerColliderDucked; // 0x114
	BasePlayer.CapsuleColliderInfo playerColliderCrawling; // 0x128
	BasePlayer.CapsuleColliderInfo playerColliderLyingDown; // 0x13c
	ProtectionProperties cachedProtection; // 0x150
	System.Single nextColliderRefreshTime; // 0x158
	System.Boolean clothingBlocksAiming; // 0x15c
	System.Single clothingMoveSpeedReduction; // 0x160
	System.Single clothingWaterSpeedBonus; // 0x164
	System.Single clothingAccuracyBonus; // 0x168
	System.Boolean equippingBlocked; // 0x16c
	System.Single eggVision; // 0x170
	BaseRustEntity designingAIEntity; // 0x178
	BaseMountable GetMounted(); // 0x057f4058
	BaseVehicle GetMountedVehicle(); // 0x057f40bc
	System.Boolean CanMountMountablesNow(); // 0x057f41bc
	System.Void MountObject(BaseMountable mount, System.Int32 desiredSeat); // 0x057f4220
	System.Void EnsureDismounted(); // 0x057f42a8
	System.Void DismountObject(); // 0x057f4308
	System.Void MovePosition(UnityEngine.Vector3 newPos); // 0x057f4374
	System.Void SetPosition(UnityEngine.Vector3 position); // 0x057f4414
	WizardGames.Soc.Common.Entity.PlayerEntity get_PlayerEntity(); // 0x057f45f0
	System.Boolean IsOnGround(); // 0x057f46a0
	System.Void .ctor(); // 0x057f4728
}

// Client.Runtime
enum BasePlayer.CameraMode : System.Enum
{
	System.Int32 value__; // 0x10
	static BasePlayer.CameraMode FirstPerson = 0;
	static BasePlayer.CameraMode ThirdPerson = 1;
	static BasePlayer.CameraMode Eyes = 2;
	static BasePlayer.CameraMode FirstPersonWithArms = 3;
	static BasePlayer.CameraMode DeathCamClassic = 4;
	static BasePlayer.CameraMode Last = 3;
	
}

// Client.Runtime
struct BasePlayer.CapsuleColliderInfo : System.ValueType
{
	System.Single height; // 0x10
	System.Single radius; // 0x14
	UnityEngine.Vector3 center; // 0x18
	
}

// Client.Runtime
class PlayerModel : System.Object
{
	static System.Int32 speed; // 0x0
	static System.Int32 acceleration; // 0x4
	static System.Int32 rotationYaw; // 0x8
	static System.Int32 forward; // 0xc
	static System.Int32 right; // 0x10
	static System.Int32 up; // 0x14
	static System.Int32 ducked; // 0x18
	static System.Int32 grounded; // 0x1c
	static System.Int32 crawling; // 0x20
	static System.Int32 waterlevel; // 0x24
	static System.Int32 attack; // 0x28
	static System.Int32 attack_alt; // 0x2c
	static System.Int32 deploy; // 0x30
	static System.Int32 reload; // 0x34
	static System.Int32 throwWeapon; // 0x38
	static System.Int32 holster; // 0x3c
	static System.Int32 aiming; // 0x40
	static System.Int32 onLadder; // 0x44
	static System.Int32 posing; // 0x48
	static System.Int32 poseType; // 0x4c
	static System.Int32 relaxGunPose; // 0x50
	static System.Int32 vehicle_aim_yaw; // 0x54
	static System.Int32 vehicle_aim_speed; // 0x58
	static System.Int32 onPhone; // 0x5c
	static System.Int32 usePoseTransition; // 0x60
	static System.Int32 leftFootIK; // 0x64
	static System.Int32 rightFootIK; // 0x68
	static System.Int32 vehicleSteering; // 0x6c
	static System.Int32 sitReaction; // 0x70
	static System.Int32 forwardReaction; // 0x74
	static System.Int32 rightReaction; // 0x78
	static System.Void .cctor(); // 0x057f47b4
}

// Client.Runtime
enum PlayerModel.MountPoses : System.Enum
{
	System.Int32 value__; // 0x10
	static PlayerModel.MountPoses Chair = 0;
	static PlayerModel.MountPoses Driving = 1;
	static PlayerModel.MountPoses Horseback = 2;
	static PlayerModel.MountPoses HeliUnarmed = 3;
	static PlayerModel.MountPoses HeliArmed = 4;
	static PlayerModel.MountPoses HandMotorBoat = 5;
	static PlayerModel.MountPoses MotorBoatPassenger = 6;
	static PlayerModel.MountPoses SitGeneric = 7;
	static PlayerModel.MountPoses SitRaft = 8;
	static PlayerModel.MountPoses StandDrive = 9;
	static PlayerModel.MountPoses SitShootingGeneric = 10;
	static PlayerModel.MountPoses SitMinicopter_Pilot = 11;
	static PlayerModel.MountPoses SitMinicopter_Passenger = 12;
	static PlayerModel.MountPoses ArcadeLeft = 13;
	static PlayerModel.MountPoses ArcadeRight = 14;
	static PlayerModel.MountPoses SitSummer_Ring = 15;
	static PlayerModel.MountPoses SitSummer_BoogieBoard = 16;
	static PlayerModel.MountPoses SitCarPassenger = 17;
	static PlayerModel.MountPoses SitSummer_Chair = 18;
	static PlayerModel.MountPoses SitRaft_NoPaddle = 19;
	static PlayerModel.MountPoses Sit_SecretLab = 20;
	static PlayerModel.MountPoses Sit_Workcart = 21;
	static PlayerModel.MountPoses Sit_Cardgame = 22;
	static PlayerModel.MountPoses Sit_Crane = 23;
	static PlayerModel.MountPoses Sit_Snowmobile_Shooting = 24;
	static PlayerModel.MountPoses Sit_RetroSnowmobile_Shooting = 25;
	static PlayerModel.MountPoses Driving_Snowmobile = 26;
	static PlayerModel.MountPoses ZiplineHold = 27;
	static PlayerModel.MountPoses Sit_Locomotive = 28;
	static PlayerModel.MountPoses Standing = 128;
	
}

// Client.Runtime
class BaseMountable : BaseCombatEntity
{
	static SocLogger logger; // 0x0
	MountableData MountableData; // 0x168
	UnityEngine.Transform eyePositionOverride; // 0x170
	UnityEngine.Transform eyeCenterOverride; // 0x178
	UnityEngine.Vector2 pitchClamp; // 0x180
	UnityEngine.Vector2 yawClamp; // 0x188
	System.Boolean canWieldItems; // 0x190
	System.Boolean relativeViewAngles; // 0x191
	UnityEngine.Transform mountAnchor; // 0x198
	PlayerModel.MountPoses mountPose; // 0x1a0
	System.Single maxMountDistance; // 0x1a4
	UnityEngine.Transform[] dismountPositions; // 0x1a8
	System.Boolean checkPlayerLosOnMount; // 0x1b0
	System.Boolean disableMeshCullingForPlayers; // 0x1b1
	System.Boolean allowHeadLook; // 0x1b2
	System.Boolean modifiesPlayerCollider; // 0x1b3
	BasePlayer.CapsuleColliderInfo customPlayerCollider; // 0x1b4
	BaseMountable.MountStatType mountTimeStatType; // 0x1c8
	Soc.Vehicle.MountPointConfig MountPointConfig; // 0x1d0
	BaseMountable.MountGestureType allowedGestures; // 0x1d8
	System.Boolean canDrinkWhileMounted; // 0x1dc
	System.Boolean allowSleeperMounting; // 0x1dd
	System.Boolean animateClothInLocalSpace; // 0x1de
	BasePlayer.CameraMode MountedCameraMode; // 0x1e0
	System.Boolean isMobile; // 0x1e4
	System.Single SideLeanAmount; // 0x1e8
	BasePlayer _mounted; // 0x1f0
	static ListHashSet<BaseMountable> FixedUpdateMountables; // 0x8
	System.Int32 SeatIndex; // 0x1f8
	UnityEngine.Vector3 MountablePosition; // 0x1fc
	System.ValueTuple<UnityEngine.Vector3,System.Boolean> DismountPosition; // 0x208
	System.Void ClientInit(); // 0x057f4ddc
	System.Void VehicleClientTick(System.Int32 deltaTime); // 0x057f4e3c
	System.Boolean CanHoldItems(); // 0x057f4eb0
	BasePlayer.CameraMode GetMountedCameraMode(); // 0x057f4f14
	System.Boolean DirectlyMountable(); // 0x057f4f78
	UnityEngine.Transform GetEyeOverride(); // 0x057f4fdc
	UnityEngine.Quaternion GetMountedBodyAngles(); // 0x057f5090
	System.Boolean ModifiesThirdPersonCamera(); // 0x057f5110
	UnityEngine.Vector2 GetPitchClamp(); // 0x057f5174
	UnityEngine.Vector2 GetYawClamp(); // 0x057f51d8
	System.Boolean IsMounted(); // 0x057f523c
	UnityEngine.Vector3 EyePositionForPlayer(BasePlayer player, UnityEngine.Quaternion lookRot); // 0x057f52a0
	UnityEngine.Vector3 EyeCenterForPlayer(BasePlayer player, UnityEngine.Quaternion lookRot); // 0x057f5440
	System.Single WaterFactorForPlayer(BasePlayer player); // 0x057f55e0
	System.Single MaxVelocity(); // 0x057f5678
	System.Boolean PlayerIsMounted(BasePlayer player); // 0x057f5778
	BaseVehicle VehicleParent(); // 0x057f5810
	System.Void PostServerLoad(); // 0x057f5908
	BasePlayer GetMounted(); // 0x057f598c
	System.Void MounteeTookDamage(BasePlayer mountee, HitInfo info); // 0x057f59f0
	System.Boolean CanSwapToThis(BasePlayer player); // 0x057f5a6c
	System.Single get_PositionTickRate(); // 0x057f5ae4
	System.Void OnKilled(HitInfo info); // 0x057f5b4c
	System.Boolean AttemptMount(BasePlayer player, WizardGames.Soc.Common.Unity.Go.SeatType seatType, System.Int32& seatIndex, System.Boolean doMountChecks, System.Boolean reload); // 0x057f5bdc
	System.Int32 AttemptDismount(BasePlayer player); // 0x057f5e90
	UnityEngine.Vector3 MountPlayer(BasePlayer player); // 0x057f5cd4
	UnityEngine.Vector3 QuickMountPlayer(BasePlayer player); // 0x057f6288
	System.Void OnPlayerMounted(); // 0x057f643c
	System.Void OnPlayerDismounted(BasePlayer player); // 0x057f649c
	System.Void UpdateFullFlag(); // 0x057f6534
	System.Void DismountAllPlayers(); // 0x057f6738
	System.Int32 DismountPlayer(BasePlayer player, System.Boolean lite); // 0x057f5f18
	System.Boolean QuickDismountPlayer(BasePlayer player); // 0x057f67c0
	System.Int32 GetDismountPosition(BasePlayer player, UnityEngine.Vector3& dismountPoint, System.Boolean& isInsideMount); // 0x057f6904
	System.Void DoServerDestroy(); // 0x057f6df0
	static System.Void TestInput(InputState inputState); // 0x057f6eac
	System.Void TestInput2(InputState inputState, BasePlayer player); // 0x057f707c
	static System.Void FixedUpdateCycle(System.Int32 dt); // 0x057f7114
	System.Void VehicleFixedUpdate(System.Int32 dt); // 0x057f73ec
	System.Void VehicleFixedUpdateWhenSleep(System.Int32 dt); // 0x057f7460
	System.Void PostVehicleFixedUpdate(); // 0x057f74d4
	System.Void PlayerServerInput(WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld, InputState inputState, BasePlayer player); // 0x057f7534
	System.Void PlayerServerInput(WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, BasePlayer player); // 0x057f75c4
	System.Single GetComfort(); // 0x057f7654
	System.Void ScaleDamageForPlayer(BasePlayer player, HitInfo info); // 0x057f76b8
	System.Boolean get_IsSummerDlcVehicle(); // 0x057f7734
	System.Boolean IsInstrument(); // 0x057f7798
	static UnityEngine.Vector3 ConvertVector(UnityEngine.Vector3 vec); // 0x057f77fc
	System.Boolean get_BlocksDoors(); // 0x057f79d0
	System.Void .ctor(); // 0x057f7a34
	static System.Void .cctor(); // 0x057f7b68
}

// Client.Runtime
enum BaseMountable.MountStatType : System.Enum
{
	System.Int32 value__; // 0x10
	static BaseMountable.MountStatType None = 0;
	static BaseMountable.MountStatType Boating = 1;
	static BaseMountable.MountStatType Flying = 2;
	static BaseMountable.MountStatType Driving = 3;
	
}

// Client.Runtime
enum BaseMountable.MountGestureType : System.Enum
{
	System.Int32 value__; // 0x10
	static BaseMountable.MountGestureType None = 0;
	static BaseMountable.MountGestureType UpperBody = 1;
	
}

// Client.Runtime
class MountableData : System.Object
{
	System.Int32 DeltaTime; // 0x10
	System.Void .ctor(); // 0x057f7b00
}

// Client.Runtime
class BaseVehicle : BaseMountable
{
	UnityEngine.GameObject RendererGo; // 0x218
	WizardGames.Soc.Common.Unity.Go.BaseVehicleGo VehicleGo; // 0x220
	WizardGames.Soc.Common.Vehicle.BaseFuelComponent BaseFuelComponent; // 0x228
	System.Boolean IsAuthority; // 0x230
	UnityEngine.AnimationCurve SpeedAudioCurve; // 0x238
	UnityEngine.AnimationCurve RevSpeedAudioCurve; // 0x240
	System.Single minCollisionDamageForce; // 0x248
	System.Single maxCollisionDamageForce; // 0x24c
	System.Single MIN_COLLISION_DAMAGE; // 0x250
	System.Single MAX_COLLISION_DAMAGE; // 0x254
	System.Single collisionDamageMultiplier; // 0x258
	System.Int32 collisionEffectTbId; // 0x25c
	System.Single CollisionEffectSpeedThreshOld; // 0x260
	WizardGames.Soc.Common.Unity.Audio.GameAudioConf CollisionAudioConf; // 0x268
	System.Single CollisionAudioSpeedThreshOld; // 0x280
	System.Int32 MotionEffectTbId; // 0x284
	System.String MotionEffectAttachName; // 0x288
	System.Single MotionEffectSpeedThreshOld; // 0x290
	System.Collections.Generic.Dictionary<System.ValueTuple<WizardGames.Soc.Common.Entity.IEntity,WizardGames.Soc.Common.Entity.IEntity>,BaseVehicle.DamageInfo> damageSinceLastTick; // 0x298
	static SocLogger logger; // 0x0
	System.Boolean mountChaining; // 0x2a0
	BaseVehicle.ClippingCheckMode clippingChecks; // 0x2a4
	System.Boolean shouldShowHudHealth; // 0x2a8
	System.Boolean ignoreDamageFromOutside; // 0x2a9
	System.Single ClientPosX; // 0x2ac
	System.Single ClientPosY; // 0x2b0
	System.Single ClientPosZ; // 0x2b4
	UnityEngine.Rigidbody rigidBody; // 0x2b8
	System.Collections.Generic.List<BaseVehicle.MountPointInfo> mountPoints; // 0x2c0
	System.Boolean doClippingAndVisChecks; // 0x2c8
	System.Single explosionEffectThreshold; // 0x2cc
	System.Single explosionForceMultiplier; // 0x2d0
	System.Single explosionForceMax; // 0x2d4
	static BaseRustEntity.Flags Flag_OnlyOwnerEntry = 16;
	static BaseRustEntity.Flags Flag_Headlights = 2048;
	static BaseRustEntity.Flags Flag_Stationary = 32768;
	static BaseRustEntity.Flags Flag_SeatsFull = 524288;
	SocVehicle.Scripts.Entity.Vehicle.GroundVehicleAudio AudioComp; // 0x2d8
	System.Collections.Generic.List<System.Int32> DriverSeatIndexes; // 0x2e0
	System.Collections.Generic.List<System.Int32> PassengerSeatIndexes; // 0x2e8
	System.Collections.Generic.List<System.Int32> AllSeatIndexes; // 0x2f0
	System.Collections.Generic.List<BaseVehicle> childVehicles; // 0x2f8
	TriggerHurtNotChild[] hurtTriggers; // 0x300
	static System.Single MIN_TIME_BETWEEN_PUSHES = 1;
	TimeSince timeSinceLastPush; // 0x308
	System.Boolean prevSleeping; // 0x30c
	System.Single nextCollisionFXTime; // 0x310
	System.Collections.Generic.Queue<BasePlayer> recentDrivers; // 0x318
	System.Action clearRecentDriverAction; // 0x320
	static UnityEngine.WaitForSeconds WaitForSeconds; // 0x8
	System.Single safeAreaRadius; // 0x328
	UnityEngine.Vector3 safeAreaOrigin; // 0x32c
	System.Single spawnTime; // 0x338
	System.Collections.Generic.List<UnityEngine.Transform> temp; // 0x340
	System.Collections.Generic.List<System.Boolean> tempIsInsideMount; // 0x348
	System.Collections.Generic.List<System.Int32> checkedIndex; // 0x350
	System.Single MinForceDistance; // 0x358
	System.Single MaxForceDistance; // 0x35c
	System.Void ClientLightsChanged(System.Boolean headlightsOn, System.Boolean brakesOn); // 0x057f7c98
	WizardGames.Soc.Common.Entity.IBaseVehicleEntity get_VehicleEntity(); // 0x057f7d14
	System.Void PopMessage(System.Int64 playerEntityId, System.Int32 msgId); // 0x057f7db4
	System.Boolean IsStationary(); // 0x057f7e5c
	System.Boolean IsMoving(); // 0x057f7ec4
	System.Boolean get_IsMovingOrOn(); // 0x057f7f38
	System.Single get_RealisticMass(); // 0x057f7fb8
	System.Single GetSpeed(); // 0x057f8074
	System.Boolean ShouldPlayEffect(UnityEngine.Collision collision, WizardGames.Soc.Common.Unity.Go.BaseEntityGo hitEntity); // 0x057f82a4
	System.Void TryPlayHitEffect(WizardGames.Soc.Common.Entity.IEntity hitEntity, BaseVehicle.DamageInfo info); // 0x057f84fc
	System.Void TryPlayRepairSuccessSound(); // 0x057f88a0
	System.Void Awake(); // 0x057f8c24
	System.Void Init(); // 0x057f8c90
	System.Void InitShared(); // 0x057f90e0
	System.Void DoCollisionDamage(); // 0x057f914c
	System.Single QueueCollisionDamage(WizardGames.Soc.Common.Entity.IEntity hitSource, WizardGames.Soc.Common.Entity.IEntity hitTarget, System.Single forceMagnitude, UnityEngine.Vector3 HitPoint); // 0x057f91ac
	System.Boolean IgnoreSleep(); // 0x057f9474
	System.Void NoDriverInput(); // 0x057f94d8
	System.Void DriverInput(WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld, WizardGames.Soc.Common.SimpleCustom.UserCmd inputState, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x057f9538
	System.Boolean IsSeatTypeFull(WizardGames.Soc.Common.Unity.Go.SeatType seatType); // 0x057f95c8
	System.Boolean PlayerIsMounted(BasePlayer player); // 0x057f977c
	System.Boolean CanPushNow(BasePlayer pusher); // 0x057f9814
	System.Boolean HasMountPoints(); // 0x057f9898
	System.Boolean IsMounted(); // 0x057f9908
	System.Boolean CanBeLooted(BasePlayer player); // 0x057f9a3c
	System.Boolean IsFlipped(); // 0x057f9b28
	System.Boolean IsVehicleRoot(); // 0x057f9c10
	System.Boolean DirectlyMountable(); // 0x057f9c74
	BaseVehicle VehicleParent(); // 0x057f9cd8
	System.Void OnChildAdded(BaseRustEntity child); // 0x057f9d3c
	System.Void OnChildRemoved(BaseRustEntity child); // 0x057f9ee4
	BaseVehicle.Enumerable get_allMountPoints(); // 0x057f9ff8
	System.Int32 AttemptDismount(BasePlayer player); // 0x0549a128
	System.Boolean IsDriverSeat(System.Int32 index); // 0x057fa6a0
	System.Int32 GetSeatCount(WizardGames.Soc.Common.Unity.Go.SeatType seatType); // 0x057fa734
	System.Void SwitchSeat4Rust(System.Int32 oldIndex, System.Int32 newIndx, BasePlayer basePlayer); // 0x057fa7f4
	System.Void QuickDismountSeat4Rust(System.Int32 oldIndex, BasePlayer basePlayer); // 0x057fa8ec
	System.Void QuickMountSeat4Rust(System.Int32 oldIndex, System.Int32 newIndx, BasePlayer basePlayer); // 0x057fa9b4
	System.Boolean IsWheelsGrounded(WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo mgrGo); // 0x057faa80
	System.Void ClearWheelsGroundedInfo(); // 0x057faaf8
	System.Single GetMaxHorizontalSpeed(); // 0x057fab58
	System.Void CopyFlags(System.Int32 flagValue); // 0x057fabbc
	System.Boolean get_IsEngineOn(); // 0x057fac4c
	System.Boolean get_AlwaysAllowBradleyTargeting(); // 0x057facb4
	System.Boolean get_RecentlyPushed(); // 0x057fad18
	System.Void OnAttacked(HitInfo info); // 0x057fad90
	System.Void PostServerLoad(); // 0x057faf80
	System.Void Save(BaseNetworkable.SaveInfo info); // 0x057fb150
	System.Void Load(BaseNetworkable.LoadInfo info); // 0x057fb1f4
	System.Single GetNetworkTime(); // 0x057fb298
	System.Boolean get_PositionTickFixedTime(); // 0x057fb2fc
	System.Boolean AnyMounted(); // 0x057fb360
	System.Void UpdateVelocity(); // 0x057fb3c4
	System.Void CheckHurtTriggersActive(System.Boolean isSleep); // 0x057fb428
	System.Void VehicleFixedUpdate(System.Int32 dt); // 0x057fb57c
	System.Void UpdateEntityVelocity(); // 0x057fb614
	UnityEngine.Vector3 GetLocalVelocityServer(); // 0x057fb8b0
	UnityEngine.Quaternion GetAngularVelocityServer(); // 0x057fb9a0
	System.Int32 StartingFuelUnits(); // 0x057fbb10
	System.Boolean InSafeZone(); // 0x057fbb74
	static System.Boolean InSafeZone(System.Collections.Generic.List<Soc.Vehicle.TriggerBase> triggers, UnityEngine.Vector3 position); // 0x057fbbfc
	System.Void CheckSeatsForClipping(System.Boolean fullBodyCheck, System.Int32 mask); // 0x057fbdbc
	System.Void MounteeTookDamage(BasePlayer mountee, HitInfo info); // 0x057fbe5c
	System.Void DismountAllPlayers(); // 0x057fbed8
	System.Void ServerInit(WizardGames.Soc.Common.Entity.IEntity entity, WizardGames.Soc.Common.Unity.Go.BaseEntityGo entityGo); // 0x057fbf38
	System.Boolean CanDeactiveHurtTriggers(); // 0x057fc0f0
	System.Void SpawnSubEntities(); // 0x057fc154
	System.Boolean AdminFixUp(System.Int32 tier); // 0x057fc1b8
	System.Void OnPhysicsNeighbourChanged(); // 0x057fc27c
	System.Void CheckAndSpawnMountPoints(); // 0x057fb0c8
	System.Void Spawn(); // 0x057fc334
	System.Void Hurt(HitInfo info); // 0x057fc398
	System.Void Hurt(WizardGames.Soc.Common.SimpleCustom.HitRequest hitRequest); // 0x057fc40c
	System.Collections.IEnumerator DelayedExplosionForce(System.Single explosionForce, UnityEngine.Vector3 closestPoint); // 0x057fc59c
	System.Int32 NumMounted(); // 0x057f99cc
	System.Int32 MaxMounted(); // 0x057fc704
	System.Boolean HasDriver(); // 0x057fc774
	System.Boolean IsDriver(BasePlayer player); // 0x057fc860
	BasePlayer GetPlayerDamageInitiator(); // 0x057fc908
	System.Boolean get_CanSwapSeats(); // 0x057fc990
	System.Void SwapSeats(BasePlayer player, System.Int32 targetSeat); // 0x057fc9f4
	System.Boolean HasDriverMountPoints(); // 0x057fca94
	System.Boolean OnlyOwnerAccessible(); // 0x057fcb04
	System.Boolean IsDespawnEligable(); // 0x057fcb6c
	System.Void SetupOwner(BasePlayer owner, UnityEngine.Vector3 newSafeAreaOrigin, System.Single newSafeAreaRadius); // 0x057fcc0c
	System.Void ClearOwnerEntry(); // 0x057faff4
	System.Boolean IsSafe(); // 0x057fae4c
	System.Void ScaleDamageForPlayer(BasePlayer player, HitInfo info); // 0x057fccf0
	BaseMountable GetIdealMountPoint(UnityEngine.Vector3 eyePos, UnityEngine.Vector3 pos, BasePlayer playerFor); // 0x057fcda0
	System.Boolean MountEligable(BasePlayer player); // 0x057fce80
	System.Void PlayerMounted(BasePlayer player, BaseMountable seat); // 0x057fcef8
	System.Void PrePlayerDismount(BasePlayer player, BaseMountable seat); // 0x057fcf74
	System.Void PlayerDismounted(BasePlayer player, BaseMountable seat); // 0x057fcff0
	System.Void TryShowCollisionFX(UnityEngine.Collision collision, GameObjectRef effectGO); // 0x057fd06c
	System.Void TryShowCollisionFX(UnityEngine.Vector3 contactPoint, GameObjectRef effectGO); // 0x057fd138
	System.Void UpdateFullFlag(); // 0x057f663c
	System.Void ClearRecentDriver(); // 0x057fd1dc
	System.Boolean AttemptMount(BasePlayer player, WizardGames.Soc.Common.Unity.Go.SeatType seatType, System.Int32& seatIndex, System.Boolean doMountChecks, System.Boolean reload); // 0x057fd23c
	Soc.Vehicle.MountPointInfo GetIdealMountPointFor(BasePlayer player, WizardGames.Soc.Common.Unity.Go.SeatType seatType, System.Int32& seatIndex); // 0x057fd8d8
	System.Int32 GetDismountPosition(BasePlayer player, UnityEngine.Vector3& dismountPoint, System.Boolean& isInside); // 0x057fda30
	System.Void WantsPush(BasePlayer player, System.Single pushForceFactor); // 0x057fe718
	System.Void DoPushAction(BasePlayer player, System.Single pushForceFactor); // 0x057fe9e4
	System.Void PlayPushSound(); // 0x057ff4f4
	System.Void AdditionalPushForce(BasePlayer player); // 0x057fee60
	System.Void .ctor(); // 0x057ff554
	static System.Void .cctor(); // 0x057ff8e8
}

// Client.Runtime
class BaseVehicle.DamageInfo : System.Object
{
	System.Single Damage; // 0x10
	UnityEngine.Vector3 HitPoint; // 0x14
	System.Single Speed; // 0x20
	System.Void .ctor(); // 0x057f940c
}

// Client.Runtime
enum BaseVehicle.ClippingCheckMode : System.Enum
{
	System.Int32 value__; // 0x10
	static BaseVehicle.ClippingCheckMode OnMountOnly = 0;
	static BaseVehicle.ClippingCheckMode Always = 1;
	static BaseVehicle.ClippingCheckMode AlwaysHeadOnly = 2;
	
}

// Client.Runtime
class BaseVehicle.MountPointInfo : System.Object
{
	System.Boolean isDriver; // 0x10
	UnityEngine.Vector3 pos; // 0x14
	UnityEngine.Vector3 rot; // 0x20
	System.String bone; // 0x30
	UnityEngine.Transform Transform; // 0x38
	BaseMountable mountable; // 0x40
	System.Void .ctor(); // 0x057ffa08
}

// Client.Runtime
struct BaseVehicle.Enumerable : System.ValueType, System.Collections.Generic.IEnumerable<BaseVehicle.MountPointInfo>, System.Collections.IEnumerable
{
	BaseVehicle _vehicle; // 0x10
	System.Void .ctor(BaseVehicle vehicle); // 0x057fa078
	BaseVehicle.Enumerator GetEnumerator(); // 0x057ffa94
	System.Collections.Generic.IEnumerator<BaseVehicle.MountPointInfo> System.Collections.Generic.IEnumerable<BaseVehicle.MountPointInfo>.GetEnumerator(); // 0x057ffc90
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x057ffd3c
}

// Client.Runtime
struct BaseVehicle.Enumerator : System.ValueType, System.Collections.Generic.IEnumerator<BaseVehicle.MountPointInfo>, System.Collections.IEnumerator, System.IDisposable
{
	BaseVehicle _vehicle; // 0x10
	BaseVehicle.Enumerator.State _state; // 0x18
	System.Int32 _index; // 0x1c
	System.Int32 _childIndex; // 0x20
	BaseVehicle.Enumerator.Box _enumerator; // 0x28
	BaseVehicle.MountPointInfo <Current>k__BackingField; // 0x30
	BaseVehicle.MountPointInfo get_Current(); // 0x057ffde8
	System.Void set_Current(BaseVehicle.MountPointInfo value); // 0x057ffe4c
	System.Void .ctor(BaseVehicle vehicle); // 0x057ffb1c
	System.Boolean MoveNext(); // 0x057ffecc
	System.Object System.Collections.IEnumerator.get_Current(); // 0x05800378
	System.Void Dispose(); // 0x05800318
	System.Void Reset(); // 0x05800410
}

// Client.Runtime
enum BaseVehicle.Enumerator.State : System.Enum
{
	System.Int32 value__; // 0x10
	static BaseVehicle.Enumerator.State Direct = 0;
	static BaseVehicle.Enumerator.State EnterChild = 1;
	static BaseVehicle.Enumerator.State EnumerateChild = 2;
	static BaseVehicle.Enumerator.State Finished = 3;
	
}

// Client.Runtime
class BaseVehicle.Enumerator.Box : System.Object
{
	BaseVehicle.Enumerator Value; // 0x10
	System.Void .ctor(); // 0x058002b0
}

// Client.Runtime
class BaseVehicle.<>c__DisplayClass171_0 : System.Object
{
	BaseVehicle <>4__this; // 0x10
	BasePlayer player; // 0x18
	System.Void .ctor(); // 0x057fe97c
	System.Void <WantsPush>b__0(System.Int64 _, System.Object __, System.Boolean ___); // 0x05800498
}

// Client.Runtime
class BaseVehicle.<DelayedExplosionForce>d__137 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	BaseVehicle <>4__this; // 0x20
	System.Single explosionForce; // 0x28
	UnityEngine.Vector3 closestPoint; // 0x2c
	System.Void .ctor(System.Int32 <>1__state); // 0x057fc680
	System.Void System.IDisposable.Dispose(); // 0x05800548
	System.Boolean MoveNext(); // 0x058005a8
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x058006a0
	System.Void System.Collections.IEnumerator.Reset(); // 0x05800704
	System.Object System.Collections.IEnumerator.get_Current(); // 0x0580078c
}

// Client.Runtime
class BaseVehicleMountPoint : BaseMountable
{
	
	System.Boolean DirectlyMountable(); // 0x058007f0
	BaseVehicle VehicleParent(); // 0x05800854
	System.Boolean BlocksWaterFor(BasePlayer player); // 0x05800a58
	System.Single WaterFactorForPlayer(BasePlayer player); // 0x05800b3c
	System.Single AirFactor(); // 0x05800c20
	System.Void .ctor(); // 0x05800cf0
}

// Client.Runtime
class BaseVehicleSeat : BaseVehicleMountPoint
{
	System.Single mountedAnimationSpeed; // 0x218
	System.Boolean sendClientInputToVehicleParent; // 0x21c
	System.Boolean forcePlayerModelUpdate; // 0x21d
	System.Void ScaleDamageForPlayer(BasePlayer player, HitInfo info); // 0x05800d78
	System.Void MounteeTookDamage(BasePlayer mountee, HitInfo info); // 0x05800e60
	System.Void PlayerServerInput(WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld, InputState inputState, BasePlayer player); // 0x05800f48
	System.Void .ctor(); // 0x05801064
}

// Client.Runtime
class BasicCar : BaseVehicle
{
	BasicCar.VehicleWheel[] wheels; // 0x360
	System.Single brakePedal; // 0x368
	System.Single gasPedal; // 0x36c
	System.Single steering; // 0x370
	UnityEngine.Transform centerOfMass; // 0x378
	UnityEngine.Transform steeringWheel; // 0x380
	System.Single motorForceConstant; // 0x388
	System.Single brakeForceConstant; // 0x38c
	System.Single GasLerpTime; // 0x390
	System.Single SteeringLerpTime; // 0x394
	UnityEngine.Transform driverEye; // 0x398
	UnityEngine.Transform chairAnchorTest; // 0x3a0
	UnityEngine.Transform engineOffset; // 0x3a8
	static System.Boolean chairtest; // 0x0
	System.Single throttle; // 0x3b0
	System.Single brake; // 0x3b4
	System.Single MaxVelocity(); // 0x058010c8
	UnityEngine.Vector3 EyePositionForPlayer(BasePlayer player, UnityEngine.Quaternion viewRot); // 0x05801130
	System.Void ServerInit(WizardGames.Soc.Common.Entity.IEntity entity, WizardGames.Soc.Common.Unity.Go.BaseEntityGo entityGo); // 0x05801264
	System.Void SpawnChairTest(); // 0x058013a4
	System.Void VehicleFixedUpdate(System.Int32 dt); // 0x0580142c
	System.Void DoSteering(); // 0x05801544
	System.Void ConvertInputToThrottle(); // 0x058014e4
	System.Void ApplyForceAtWheels(); // 0x05801654
	System.Void PushWheelColliderSetting(BasicCar.VehicleWheel wheel, System.Boolean isPushing); // 0x058019f8
	System.Void NoDriverInput(); // 0x05801ad4
	System.Void PlayerServerInput(WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld, InputState inputState, BasePlayer player); // 0x05801bd4
	System.Void PlayerServerInput(WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld, WizardGames.Soc.Common.SimpleCustom.UserCmd inputState, BasePlayer player); // 0x05801d98
	System.Void DriverInput(WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld, WizardGames.Soc.Common.SimpleCustom.UserCmd inputState, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x05801e88
	System.Void DriverInput(WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld, InputState inputState, BasePlayer player); // 0x05801c74
	System.Void .ctor(); // 0x05801ff4
}

// Client.Runtime
class BasicCar.VehicleWheel : System.Object
{
	UnityEngine.Transform shock; // 0x10
	UnityEngine.WheelCollider wheelCollider; // 0x18
	UnityEngine.Transform wheel; // 0x20
	UnityEngine.Transform axle; // 0x28
	System.Boolean steerWheel; // 0x30
	System.Boolean brakeWheel; // 0x31
	System.Boolean powerWheel; // 0x32
	System.Void .ctor(); // 0x0580208c
}

// Client.Runtime
class BaseBoat : BaseVehicle
{
	static BaseRustEntity.Flags Flag_EngineOn = 128;
	static BaseRustEntity.Flags Flag_ThrottleOn = 256;
	static BaseRustEntity.Flags Flag_TurnLeft = 512;
	static BaseRustEntity.Flags Flag_TurnRight = 1024;
	static BaseRustEntity.Flags Flag_Submerged = 2048;
	static BaseRustEntity.Flags Flag_HasFuel = 16384;
	static BaseRustEntity.Flags Flag_RecentlyPushed = 65536;
	System.Single engineThrust; // 0x360
	System.Single steeringScale; // 0x364
	System.Single _gasPedal; // 0x368
	System.Single steering; // 0x36c
	UnityEngine.Transform thrustPoint; // 0x370
	UnityEngine.Transform centerOfMass; // 0x378
	WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Buoyancy.Buoyancy buoyancyComp; // 0x380
	System.Single splashAccentFrequencyMin; // 0x388
	System.Single splashAccentFrequencyMax; // 0x38c
	System.Single turnPitchModScale; // 0x390
	System.Single tiltPitchModScale; // 0x394
	System.Single waterSpeedDivisor; // 0x398
	UnityEngine.Transform effectLocator; // 0x3a0
	TimeSince startedFlip; // 0x3a8
	System.Int64 _timerId; // 0x3b0
	System.Single get_gasPedal(); // 0x058020fc
	System.Void set_gasPedal(System.Single value); // 0x05802160
	System.Single GetSpeed(); // 0x05802250
	System.Void InitShared(); // 0x058024fc
	System.Void ServerInit(WizardGames.Soc.Common.Entity.IEntity entity, WizardGames.Soc.Common.Unity.Go.BaseEntityGo entityGo); // 0x05802560
	System.Void NoDriverInput(); // 0x05802808
	System.Void PlayerServerInput(WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, BasePlayer player); // 0x058029ec
	System.Void DriverInput(WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld, WizardGames.Soc.Common.SimpleCustom.UserCmd inputState, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x05802b00
	System.Boolean EngineOn(); // 0x05802d64
	System.Void InvalidateNetworkCache(); // 0x05802df4
	System.Void DoFlippedAction(BasePlayer player); // 0x05802e54
	System.Void FlipMonitor(); // 0x05803100
	System.Void PlayPushSound(); // 0x05803344
	System.Void VehicleFixedUpdate(System.Int32 dt); // 0x058033a4
	System.Void VehicleFixedUpdateWhenSleep(System.Int32 dt); // 0x05803d2c
	System.Void CheckIsFlipped(); // 0x05803c38
	System.Void PreventFlipping(System.Int32 dt); // 0x05803868
	System.Single RL(); // 0x05803db0
	System.Void WakeUp(); // 0x05803e88
	System.Void CopyFlags(System.Int32 flagValue); // 0x05803fb0
	System.Void .ctor(); // 0x0580407c
	System.Void <DoFlippedAction>b__33_0(System.Int64 id, System.Object data, System.Boolean delete); // 0x05804128
}

// Client.Runtime
class CarPhysicsViewData : System.Object
{
	System.Single inputSteerAngle; // 0x10
	System.Single steerReductionPercent; // 0x14
	System.Single steerAngleLimit; // 0x18
	System.Single speedFactor; // 0x1c
	System.Single speedAngleFactor; // 0x20
	System.Single assistedSteerAngle; // 0x24
	System.Single targetSteerAngle; // 0x28
	System.Single lerpMultiplier; // 0x2c
	System.Single lerpSpeed; // 0x30
	System.Single DriveWheelVelocity; // 0x34
	System.Single DriveWheelSlip; // 0x38
	System.Single SteerAngle; // 0x3c
	System.Single SteerAngleSpeed; // 0x40
	System.Single Speed; // 0x44
	System.Boolean IsGrounded; // 0x48
	System.Single RigidbodyMass; // 0x4c
	System.Single SpeedAngle; // 0x50
	System.Single GetThrottleInput; // 0x54
	System.Single GetBrakeInput; // 0x58
	System.Single GetSteerInput; // 0x5c
	System.Boolean GetSteerModInput; // 0x60
	System.Single GetMaxForwardSpeed; // 0x64
	System.Single GetMaxDriveForce; // 0x68
	System.Single DriveForceMultiplier; // 0x6c
	System.Single GetAdjustedDriveForce; // 0x70
	System.Single GetModifiedDrag; // 0x74
	System.Single Drag; // 0x78
	System.Single AngularDrag; // 0x7c
	System.Single GetWheelsMidPos; // 0x80
	WheelViewData[] WheelViewDatas; // 0x88
	System.Void .ctor(); // 0x058041bc
}

// Client.Runtime
class WheelViewData : System.Object
{
	System.String Name; // 0x10
	System.Single downforce; // 0x18
	System.Single forceDistance; // 0x1c
	UnityEngine.Vector2 localRigForce; // 0x20
	UnityEngine.Vector2 localVelocity; // 0x28
	System.Single angularVelocity; // 0x30
	UnityEngine.Vector2 tyreForce; // 0x34
	UnityEngine.Vector2 tyreSlip; // 0x3c
	UnityEngine.Vector3 velocity; // 0x44
	System.Single velocityLength; // 0x50
	UnityEngine.Vector3 forwardDir; // 0x54
	UnityEngine.Vector3 sidewaysDir; // 0x60
	UnityEngine.Vector3 forwardForce; // 0x6c
	UnityEngine.Vector3 sidewaysForce; // 0x78
	System.Single demandedForce; // 0x84
	System.Single rawTyreForceY; // 0x88
	System.Single tyreForceY; // 0x8c
	System.Single forwardForceLength; // 0x90
	System.Single sidewaysForceLength; // 0x94
	System.Void Update(ServerWheelData wd); // 0x05804224
	System.Void .ctor(); // 0x058043ac
}

// Client.Runtime
class CarSettings : System.Object
{
	System.Single rollingResistance; // 0x10
	System.Single antiRoll; // 0x14
	System.Boolean tankSteering; // 0x18
	System.Single maxSteerAngle; // 0x1c
	System.Boolean steeringAssist; // 0x20
	System.Single steeringAssistRatio; // 0x24
	System.Boolean steeringLimit; // 0x28
	System.Single minSteerLimitAngle; // 0x2c
	System.Single minSteerLimitSpeed; // 0x30
	System.Single rearWheelSteer; // 0x34
	System.Single steerMinLerpSpeed; // 0x38
	System.Single steerMaxLerpSpeed; // 0x3c
	System.Single steerReturnLerpSpeed; // 0x40
	System.Single maxDriveSlip; // 0x44
	System.Single driveForceToMaxSlip; // 0x48
	System.Single reversePercentSpeed; // 0x4c
	System.Single brakeForceMultiplier; // 0x50
	System.Single handlingBias; // 0x54
	System.Boolean get_canSleep(); // 0x05804884
	System.Void .ctor(); // 0x058048e8
}

// Client.Runtime
class CarWheel : System.Object
{
	UnityEngine.WheelCollider wheelCollider; // 0x10
	System.Single tyreFriction; // 0x18
	System.Boolean steerWheel; // 0x1c
	System.Boolean brakeWheel; // 0x1d
	System.Boolean powerWheel; // 0x1e
	System.Void .ctor(); // 0x0580499c
}

// Client.Runtime
class ServerWheelData : System.Object
{
	CarWheel wheel; // 0x10
	UnityEngine.Transform wheelColliderTransform; // 0x18
	UnityEngine.WheelCollider wheelCollider; // 0x20
	System.Boolean isGrounded; // 0x28
	System.Single downforce; // 0x2c
	System.Single forceDistance; // 0x30
	UnityEngine.WheelHit hit; // 0x38
	UnityEngine.Vector2 localRigForce; // 0x80
	UnityEngine.Vector2 localVelocity; // 0x88
	System.Single angularVelocity; // 0x90
	UnityEngine.Vector3 origin; // 0x94
	UnityEngine.Vector2 tyreForce; // 0xa0
	UnityEngine.Vector2 tyreSlip; // 0xa8
	UnityEngine.Vector3 velocity; // 0xb0
	System.Boolean isBraking; // 0xbc
	System.Boolean hasThrottleInput; // 0xbd
	System.Boolean isFrontWheel; // 0xbe
	System.Boolean isLeftWheel; // 0xbf
	UnityEngine.Vector3 forwardForce; // 0xc0
	UnityEngine.Vector3 sidewaysForce; // 0xcc
	System.Single demandedForce; // 0xd8
	System.Single rawTyreForceY; // 0xdc
	System.Single tyreForceY; // 0xe0
	System.Single forwardForceLength; // 0xe4
	System.Single sidewaysForceLength; // 0xe8
	Soc.Vehicle.Util.WheelGroundChecker WheelGroundChecker; // 0xf0
	System.Void .ctor(); // 0x05804a14
}

// Client.Runtime
class CarPhysics<TCar> : System.Object
{
	CarPhysicsViewData ViewData; // 0x0
	System.Single <DriveWheelVelocity>k__BackingField; // 0x0
	System.Single <DriveWheelSlip>k__BackingField; // 0x0
	System.Single <SteerAngle>k__BackingField; // 0x0
	System.Single <TankThrottleLeft>k__BackingField; // 0x0
	System.Single <TankThrottleRight>k__BackingField; // 0x0
	ServerWheelData[] wheelData; // 0x0
	TCar car; // 0x0
	UnityEngine.Transform transform; // 0x0
	UnityEngine.Rigidbody rBody; // 0x0
	CarSettings vehicleSettings; // 0x0
	System.Single speedAngle; // 0x0
	System.Boolean wasSleeping; // 0x0
	System.Boolean hasDriver; // 0x0
	System.Boolean hadDriver; // 0x0
	System.Single lastMovingTime; // 0x0
	UnityEngine.WheelFrictionCurve zeroFriction; // 0x0
	UnityEngine.Vector3 prevLocalCOM; // 0x0
	System.Single midWheelPos; // 0x0
	static System.Boolean WHEEL_HIT_CORRECTION = true;
	static System.Single SLEEP_SPEED = 0.25;
	static System.Single SLEEP_DELAY = 10;
	static System.Single AIR_DRAG = 0.25;
	static System.Single DEFAULT_GROUND_GRIP = 0.75;
	static System.Single ROAD_GROUND_GRIP = 1;
	static System.Single ICE_GROUND_GRIP = 0.25;
	System.Boolean slowSpeedExitFlag; // 0x0
	static System.Single SLOW_SPEED_EXIT_SPEED = 4;
	TimeSince timeSinceWaterCheck; // 0x0
	System.Single get_DriveWheelVelocity(); // 0x054a5abc
	System.Void set_DriveWheelVelocity(System.Single value); // 0x05513724
	System.Single get_DriveWheelSlip(); // 0x054a5abc
	System.Void set_DriveWheelSlip(System.Single value); // 0x05513724
	System.Single get_SteerAngle(); // 0x054a5abc
	System.Void set_SteerAngle(System.Single value); // 0x05513724
	System.Single get_TankThrottleLeft(); // 0x054a5abc
	System.Void set_TankThrottleLeft(System.Single value); // 0x05513724
	System.Single get_TankThrottleRight(); // 0x054a5abc
	System.Void set_TankThrottleRight(System.Single value); // 0x05513724
	System.Boolean get_InSlowSpeedExitMode(); // 0x054c4760
	System.Void .ctor(TCar car, UnityEngine.Transform transform, UnityEngine.Rigidbody rBody, CarSettings vehicleSettings); // 0x052af1f0
	System.Void FixedUpdate(System.Single dt, System.Single speed); // 0x05513850
	System.Boolean IsGrounded(System.Boolean useCollider); // 0x054deca4
	System.Void COMChanged(); // 0x055049cc
	System.Void ComputeSteerAngle(System.Single throttleInput, System.Single steerInput, System.Single dt, System.Single speed); // 0x05513a20
	System.Single GetWheelForceDistance(UnityEngine.WheelCollider col); // 0x054a6f88
	System.Void UpdateSuspension(ServerWheelData wd); // 0x05523a54
	System.Void AdjustHitForces(System.Int32 groundedWheels, System.Single neutralForcePerWheel); // 0x05508338
	System.Void UpdateLocalFrame(ServerWheelData wd, System.Single dt); // 0x05527688
	System.Void ComputeTyreForces(ServerWheelData wd, System.Single speed, System.Single maxDriveForce, System.Single maxSpeed, System.Single throttleInput, System.Single steerInput, System.Single brakeInput, System.Single driveForceMultiplier); // 0x055278ac
	System.Void ComputeTankSteeringThrottle(System.Single throttleInput, System.Single steerInput, System.Single speed); // 0x055139e8
	System.Single ComputeDriveForce(System.Single speed, System.Single absSpeed, System.Single demandedForce, System.Single maxForce, System.Single maxForwardSpeed, System.Single driveForceMultiplier); // 0x054a60d8
	System.Void ComputeOverallForces(); // 0x055049cc
	static System.Single ComputeCombinedSlip(UnityEngine.Vector2 localVelocity, UnityEngine.Vector2 tyreSlip); // 0x054a59c8
	System.Void ApplyTyreForces(ServerWheelData wd, System.Single throttleInput, System.Single steerInput, System.Single speed); // 0x055277c8
	UnityEngine.Vector3 GetSidewaysForceAppPoint(ServerWheelData wd, UnityEngine.Vector3 contactPoint); // 0x054b2120
	System.Single GetTankSteerInvert(System.Single throttleInput, System.Single speed); // 0x054a5f60
	ServerWheelData <.ctor>g__AddWheel|47_0(CarWheel wheel, CarPhysics.<>c__DisplayClass47_0<TCar>& Client.Runtime); // 0x054fbfdc
}

// Client.Runtime
interface CarPhysics.ICar<TCar> : 
{
	
	System.Single GetSteerAngleForSpeed(System.Single steerAngle, System.Single speed, System.Single maxSpeed); // 0x054a6018
	VehicleTerrainHandler.Surface get_OnSurface(); // 0x0548ba98
	System.Single GetThrottleInput(); // 0x054a5abc
	System.Single GetBrakeInput(); // 0x054a5abc
	System.Single GetSteerInput(); // 0x054a5abc
	System.Boolean GetSteerModInput(); // 0x054c4760
	System.Single GetMaxForwardSpeed(); // 0x054a5abc
	System.Single GetMaxDriveForce(); // 0x054a5abc
	System.Single GetAdjustedDriveForce(System.Single absSpeed, System.Single topSpeed); // 0x054a5f60
	System.Single GetModifiedDrag(); // 0x054a5abc
	CarWheel[] GetWheels(); // 0x054e7844
	System.Single GetWheelsMidPos(); // 0x054a5abc
}

// Client.Runtime
struct CarPhysics.<>c__DisplayClass47_0<TCar> : System.ValueType
{
	CarPhysics<TCar> <>4__this; // 0x0
	UnityEngine.Transform transform; // 0x0
	
}

// Client.Runtime
class GanRaoDanComponent : UnityEngine.MonoBehaviour
{
	UnityEngine.Transform[] GanRaoDanPoints; // 0x30
	UnityEngine.Transform[] FirePointPoints; // 0x38
	System.Void .ctor(); // 0x05804a7c
}

// Client.Runtime
class GroundVehicle : BaseVehicle, IEngineControllerUser, TriggerHurtNotChild.IHurtTriggerUser
{
	GameObjectRef fuelStoragePrefab; // 0x360
	UnityEngine.Transform waterloggedPoint; // 0x368
	GameObjectRef collisionEffect; // 0x370
	System.Single engineStartupTime; // 0x378
	System.Single FORCE_MULTIPLIER; // 0x37c
	System.Single DAMAGE_MULTIPLIER; // 0x380
	System.Single DRAG_FORCE; // 0x384
	System.Single MIN_TIME_BETWEEN_COLLISION_DAMAGE; // 0x388
	VehicleEngineController<GroundVehicle> engineController; // 0x390
	System.Single nextCollisionDamageTime; // 0x398
	System.Single dragMod; // 0x39c
	System.Single dragModDuration; // 0x3a0
	TimeSince timeSinceDragModSet; // 0x3a4
	UnityEngine.Vector3 get_Velocity(); // 0x05804b30
	System.Single get_DriveWheelVelocity(); // 0x054a5abc
	System.Boolean get_LightsAreOn(); // 0x05804dc8
	VehicleEngineController.EngineState<GroundVehicle> get_CurEngineState(); // 0x05804e34
	System.Void InitShared(); // 0x05804eb8
	System.Void OnFlagsChanged(BaseRustEntity.Flags old, BaseRustEntity.Flags next); // 0x05804fbc
	System.Single GetSpeed(); // 0x05805074
	System.Single GetMaxForwardSpeed(); // 0x054a5abc
	System.Single GetThrottleInput(); // 0x054a5abc
	System.Single GetBrakeInput(); // 0x054a5abc
	System.Boolean CanPushNow(BasePlayer pusher); // 0x058053ac
	System.Void ServerInit(WizardGames.Soc.Common.Entity.IEntity entity, WizardGames.Soc.Common.Unity.Go.BaseEntityGo entityGo); // 0x05805444
	System.Void OnEngineStartFailed(); // 0x055049cc
	System.Boolean MeetsEngineRequirements(); // 0x054c4760
	System.Boolean EngineIsAlive(); // 0x054c4760
	System.Void ServerFlagsChanged(BaseRustEntity.Flags old, BaseRustEntity.Flags next); // 0x058054ec
	System.Void OnCollisionEnter(UnityEngine.Collision collision); // 0x05805568
	System.Void UpdateVelocity(); // 0x05805a18
	System.Void VehicleFixedUpdate(System.Int32 dt); // 0x05805a80
	System.Void DoCollisionDamage(); // 0x05805b4c
	System.Single GetPlayerDamageMultiplier(); // 0x05805da4
	System.Void OnHurtTriggerOccupant(WizardGames.Soc.Common.Unity.Go.BaseEntityGo hurtEntity, WizardGames.Soc.Common.SimpleCustom.DamageType damageType, System.Single damageTotal); // 0x05805e1c
	System.Void DoCollisionDamage(WizardGames.Soc.Common.Entity.IEntity sourceEntity, WizardGames.Soc.Common.Entity.IEntity targetEntity, System.Single damage); // 0x05805ff8
	System.Void ProcessCollision(UnityEngine.Collision collision); // 0x05805604
	System.Single GetModifiedDrag(); // 0x058063b0
	System.Void OnChildAdded(BaseRustEntity child); // 0x05806468
	System.Void SetTempDrag(System.Single drag, System.Single duration); // 0x05805f48
	System.Void .ctor(); // 0x058064e8
}

// Client.Runtime
class BaseHelicopterVehicle : BaseVehicle
{
	System.Single engineThrustMax; // 0x360
	UnityEngine.Vector3 torqueScale; // 0x364
	UnityEngine.Transform com; // 0x370
	UnityEngine.GameObject[] killTriggers; // 0x378
	System.Collections.Generic.List<UnityEngine.Transform> GroundPoints; // 0x380
	System.Collections.Generic.List<UnityEngine.Transform> GroundEffects; // 0x388
	GameObjectRef serverGibs; // 0x390
	GameObjectRef explosionEffect; // 0x398
	GameObjectRef fireBall; // 0x3a0
	GameObjectRef impactEffectSmall; // 0x3a8
	GameObjectRef impactEffectLarge; // 0x3b0
	UnityEngine.GameObject EngineSound; // 0x3b8
	System.Single rotorGainModSmoothing; // 0x3c0
	System.Single engineGainMin; // 0x3c4
	System.Single engineGainMax; // 0x3c8
	System.Single thwopGainMin; // 0x3cc
	System.Single thwopGainMax; // 0x3d0
	System.Single currentThrottle; // 0x3d4
	System.Single avgThrust; // 0x3d8
	System.Single liftDotMax; // 0x3dc
	System.Single altForceDotMin; // 0x3e0
	System.Single liftFraction; // 0x3e4
	System.Single thrustLerpSpeed; // 0x3e8
	System.Single avgTerrainHeight; // 0x3ec
	static BaseRustEntity.Flags Flag_InternalLights = 16384;
	BaseHelicopterVehicle.HelicopterInputState currentInputState; // 0x3f0
	System.Single lastPlayerInputTime; // 0x3f8
	System.Single hoverForceScale; // 0x3fc
	UnityEngine.Vector3 damageTorque; // 0x400
	System.Single nextDamageTime; // 0x40c
	System.Single nextEffectTime; // 0x410
	System.Single pendingImpactDamage; // 0x414
	System.Single GetServiceCeiling(); // 0x05806590
	System.Single MaxVelocity(); // 0x058065f8
	System.Void ServerInit(WizardGames.Soc.Common.Entity.IEntity entity, WizardGames.Soc.Common.Unity.Go.BaseEntityGo entityGo); // 0x05806660
	System.Single MouseToBinary(System.Single amount); // 0x05806714
	System.Void PilotInput(InputState inputState, BasePlayer player); // 0x058067a0
	System.Void PilotInput(WizardGames.Soc.Common.SimpleCustom.UserCmd inputState, BasePlayer player); // 0x058069d0
	System.Void PlayerServerInput(WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld, InputState inputState, BasePlayer player); // 0x05806b6c
	System.Void PlayerServerInput(WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld, WizardGames.Soc.Common.SimpleCustom.UserCmd inputState, BasePlayer player); // 0x05806c3c
	System.Void SetDefaultInputState(); // 0x05806cf8
	System.Boolean IsEnginePowered(); // 0x05806ee0
	System.Void VehicleFixedUpdate(System.Int32 dt); // 0x05806f44
	System.Boolean ShouldApplyHoverForce(); // 0x05807078
	System.Boolean ShouldApplyAltForce(); // 0x058070dc
	System.Boolean ShouldApplyliftForce(); // 0x05807140
	System.Boolean IsEngineOn(); // 0x058071a4
	System.Void ClearDamageTorque(); // 0x05807208
	System.Void SetDamageTorque(UnityEngine.Vector3 newTorque); // 0x05807320
	System.Void AddDamageTorque(UnityEngine.Vector3 torqueToAdd); // 0x058073bc
	System.Void MovementUpdate(System.Int32 dt); // 0x05807460
	System.Void DelayedImpactDamage(WizardGames.Soc.Common.Entity.IEntity sourceEntity); // 0x05807b38
	System.Boolean CollisionDamageEnabled(); // 0x05807d68
	System.Void ProcessCollision(UnityEngine.Collision collision); // 0x05807dcc
	System.Void OnCollisionEnter(UnityEngine.Collision collision); // 0x05808374
	System.Void OnKilled(HitInfo info); // 0x058083e8
	System.Void Update(); // 0x05808480
	System.Void UpdateEffects(); // 0x058084e4
	System.Void .ctor(); // 0x05808544
}

// Client.Runtime
class BaseHelicopterVehicle.HelicopterInputState : System.Object
{
	System.Single throttle; // 0x10
	System.Single roll; // 0x14
	System.Single yaw; // 0x18
	System.Single pitch; // 0x1c
	System.Boolean groundControl; // 0x20
	System.Void Reset(); // 0x05806968
	System.Void .ctor(); // 0x058086bc
}

// Client.Runtime
class BaseHelicopterVehicle.<>c__DisplayClass51_0 : System.Object
{
	BaseHelicopterVehicle <>4__this; // 0x10
	WizardGames.Soc.Common.Entity.IEntity sourceEntity; // 0x18
	System.Void .ctor(); // 0x0580830c
	System.Void <ProcessCollision>b__0(System.Int64 id, System.Object data, System.Boolean delete); // 0x05808724
}

// Client.Runtime
class ch47Animator : UnityEngine.MonoBehaviour
{
	UnityEngine.Animator animator; // 0x30
	System.Boolean bottomDoorOpen; // 0x38
	System.Boolean landingGearDown; // 0x39
	System.Boolean leftDoorOpen; // 0x3a
	System.Boolean rightDoorOpen; // 0x3b
	System.Boolean rearDoorOpen; // 0x3c
	System.Boolean rearDoorExtensionOpen; // 0x3d
	UnityEngine.Transform rearRotorBlade; // 0x40
	UnityEngine.Transform frontRotorBlade; // 0x48
	System.Single rotorBladeSpeed; // 0x50
	System.Single wheelTurnSpeed; // 0x54
	System.Single wheelTurnAngle; // 0x58
	UnityEngine.SkinnedMeshRenderer[] blurredRotorBlades; // 0x60
	UnityEngine.SkinnedMeshRenderer[] RotorBlades; // 0x68
	System.Boolean blurredRotorBladesEnabled; // 0x70
	System.Single blurSpeedThreshold; // 0x74
	UnityEngine.Vector3 frontRotorAngle; // 0x78
	UnityEngine.Vector3 rearRotorAngle; // 0x84
	System.Void Start(); // 0x058087c4
	System.Void SetDropDoorOpen(System.Boolean isOpen); // 0x058088c8
	System.Void OnCH47ScientistLanded(System.Boolean landed); // 0x05808944
	System.Void Update(); // 0x058089d0
	System.Void LateUpdate(); // 0x05808bc8
	System.Void .ctor(); // 0x05808cec
}

// Client.Runtime
class CH47Helicopter : BaseHelicopterVehicle
{
	UnityEngine.GameObject ClientGameObject; // 0x418
	UnityEngine.GameObject ServerGameObject; // 0x420
	System.Void ServerInit(WizardGames.Soc.Common.Entity.IEntity entity, WizardGames.Soc.Common.Unity.Go.BaseEntityGo entityGo); // 0x05808d5c
	System.Void ClientInit(); // 0x05808dfc
	System.Void .ctor(); // 0x05808f9c
}

// Client.Runtime
class CH47HelicopterAIController : CH47Helicopter
{
	System.Single maxTiltAngle; // 0x428
	System.Single AiAltitudeForce; // 0x42c
	System.Single hoverHeight; // 0x430
	System.Single currentDesiredAltitude; // 0x434
	System.Boolean aimDirOverride; // 0x438
	UnityEngine.Vector3 aimDirection; // 0x43c
	System.Boolean dynamicObstacleAvoidance; // 0x448
	UnityEngine.Vector3 LandingTargetPos; // 0x44c
	UnityEngine.Vector3 LandingTargetRot; // 0x458
	UnityEngine.Vector3 currentMoveTarget; // 0x464
	UnityEngine.Vector3 finalMoveTarget; // 0x470
	System.Boolean CanHurtMonster; // 0x47c
	UnityEngine.GameObject MainGunBasePivot; // 0x480
	UnityEngine.GameObject MainGunPitchAndYawPivot; // 0x488
	UnityEngine.GameObject LeftGunBasePivot; // 0x490
	UnityEngine.GameObject LeftGunYawPivot; // 0x498
	UnityEngine.GameObject LeftGunPitchPivot; // 0x4a0
	UnityEngine.GameObject RightGunBasePivot; // 0x4a8
	UnityEngine.GameObject RightGunYawPivot; // 0x4b0
	UnityEngine.GameObject RightGunPitchPivot; // 0x4b8
	UnityEngine.Transform MainGunMuzzle; // 0x4c0
	UnityEngine.Transform LeftGunMuzzle; // 0x4c8
	UnityEngine.Transform RightGunMuzzle; // 0x4d0
	UnityEngine.Transform LeftMissileMuzzle; // 0x4d8
	UnityEngine.Transform RightMissileMuzzle; // 0x4e0
	UnityEngine.Transform FXSocket01; // 0x4e8
	UnityEngine.Transform FXSocket05; // 0x4f0
	UnityEngine.Vector3 GetCurrentMoveTarget(); // 0x05809000
	UnityEngine.Vector3 GetFinalMoveTarget(); // 0x05809068
	UnityEngine.Vector3 GetAimDirectionOverride(); // 0x058090d0
	UnityEngine.Vector3 GetPosition(); // 0x05809138
	System.Void SetDynamicObstacleAvoidance(System.Boolean on); // 0x058091b0
	System.Void SetLandingTarget(UnityEngine.Vector3 targetPos, UnityEngine.Vector3 targetRot); // 0x0580922c
	System.Void SetFinalMoveTarget(UnityEngine.Vector3 position); // 0x058092f8
	System.Void EnableFacingOverride(System.Boolean enabled); // 0x05809394
	System.Void SetAimDirection(UnityEngine.Vector3 dir); // 0x05809410
	System.Void SetHoverHeight(System.Single height); // 0x058094ac
	System.Single GetHoverHeight(); // 0x05809524
	System.Void CalculateDesiredAltitude(); // 0x05809588
	System.Void SetDefaultInputState(); // 0x05809640
	System.Void MaintainAIAltutide(); // 0x058096a0
	System.Void .ctor(); // 0x05809840
}

// Client.Runtime
class ListComponent<T> : ListComponent
{
	static ListHashSet<T> InstanceList; // 0x0
	System.Void Setup(); // 0x055049cc
	System.Void Clear(); // 0x055049cc
	static System.Void RunOnAll(System.Action<T> toRun); // 0x055049cc
	System.Void .ctor(); // 0x055049cc
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
class ListComponent : UnityEngine.MonoBehaviour
{
	
	System.Void Setup(); // 0x055049cc
	System.Void Clear(); // 0x055049cc
	System.Void OnEnable(); // 0x05809954
	System.Void OnDisable(); // 0x058099b4
	System.Void .ctor(); // 0x05809a14
}

// Client.Runtime
class MiniCopter : BaseHelicopterVehicle, IEngineControllerUser
{
	GameObjectRef fuelStoragePrefab; // 0x418
	System.Single fuelPerSec; // 0x420
	System.Single fuelGaugeMax; // 0x424
	System.Single cachedFuelFraction; // 0x428
	UnityEngine.AnimationCurve UpAccelerateCurve; // 0x430
	UnityEngine.AnimationCurve DownAccelerateCurve; // 0x438
	System.Single UpMaxSpeedNew; // 0x440
	System.Single DownMaxSpeedNew; // 0x444
	System.Single UpMaxAccNew; // 0x448
	System.Single DownMaxAccNew; // 0x44c
	System.Single VerticalSlowdownAcc; // 0x450
	System.Single VerticalBreakAcc; // 0x454
	System.Single DisturbancePeriod; // 0x458
	System.Single DisturbanceAmplitude; // 0x45c
	UnityEngine.AnimationCurve HorizontalAccCurve; // 0x460
	UnityEngine.AnimationCurve HorizontalSlowdownCurve; // 0x468
	UnityEngine.AnimationCurve HorizontalSpeedCurve; // 0x470
	System.Single MaxHorizontalSpeed; // 0x478
	System.Single MaxHorizontalAcc; // 0x47c
	System.Single MaxHorizontalSlowdown; // 0x480
	System.Single HorizontalBreakAcc; // 0x484
	WizardGames.Soc.Common.Utility.SpringDamperMono springDamperRoll; // 0x488
	WizardGames.Soc.Common.Utility.SpringDamperMono springDamperPitch; // 0x490
	WizardGames.Soc.Common.Utility.SpringDamperMono springDamperYaw; // 0x498
	UnityEngine.AnimationCurve RollJoystickCurve; // 0x4a0
	System.Single RollMaxAngle; // 0x4a8
	UnityEngine.AnimationCurve PitchJoystickCurve; // 0x4b0
	System.Single PitchMaxAngle; // 0x4b8
	UnityEngine.AnimationCurve ViewPitchCurve; // 0x4c0
	UnityEngine.AnimationCurve CameraPitchSpeedCurve; // 0x4c8
	System.Single CameraPitchSpeedMax; // 0x4d0
	UnityEngine.Transform waterSample; // 0x4d8
	UnityEngine.WheelCollider leftWheel; // 0x4e0
	UnityEngine.WheelCollider rightWheel; // 0x4e8
	UnityEngine.WheelCollider frontWheel; // 0x4f0
	Soc.Vehicle.Util.WheelGroundChecker[] wheelGroundCheckers; // 0x4f8
	UnityEngine.Transform leftWheelTrans; // 0x500
	UnityEngine.Transform rightWheelTrans; // 0x508
	UnityEngine.Transform frontWheelTrans; // 0x510
	System.Single cachedrotation_left; // 0x518
	System.Single cachedrotation_right; // 0x51c
	System.Single cachedrotation_front; // 0x520
	UnityEngine.Transform joystickPositionLeft; // 0x528
	UnityEngine.Transform joystickPositionRight; // 0x530
	UnityEngine.Transform leftFootPosition; // 0x538
	UnityEngine.Transform rightFootPosition; // 0x540
	UnityEngine.AnimationCurve bladeEngineCurve; // 0x548
	UnityEngine.Animator animator; // 0x550
	System.Single maxRotorSpeed; // 0x558
	System.Single timeUntilMaxRotorSpeed; // 0x55c
	System.Single rotorBlurThreshold; // 0x560
	System.String mainRotorBlur; // 0x568
	System.String rearRotorBlur; // 0x570
	System.String rearWing; // 0x578
	System.String lever; // 0x580
	System.Single rearWingRotScale; // 0x588
	System.Single motorForceConstant; // 0x58c
	System.Single brakeForceConstant; // 0x590
	UnityEngine.GameObject preventBuildingObject; // 0x598
	static System.Single population; // 0x0
	static System.Single outsidedecayminutes; // 0x4
	static System.Single insidedecayminutes; // 0x8
	VehicleEngineController<MiniCopter> _engineController; // 0x5a0
	WizardGames.Soc.Common.Train.MiniCopterEffectConfig EffectConfig; // 0x5a8
	System.Single CopterHpDamage; // 0x5b0
	System.Single CopterLowFuel; // 0x5b4
	System.Int32[] RevSpeedConf; // 0x5b8
	System.Int32[] RevAcSpeedConfPerFrame; // 0x5c0
	System.Int32[,,] _revSpeedConf; // 0x5c8
	System.Int32[,,] _revAcSpeedConfPerFrame; // 0x5d0
	UnityEngine.AnimationCurve startCurve; // 0x5d8
	System.Int32 startTime; // 0x5e0
	System.Single maxHeight; // 0x5e4
	System.Single upAccSpeed; // 0x5e8
	System.Single upMaxSpeed; // 0x5ec
	System.Single upBrakeAccSpeed; // 0x5f0
	System.Single downAccSpeed; // 0x5f4
	System.Single downMaxSpeed; // 0x5f8
	System.Single downBrakeAccSpeed; // 0x5fc
	System.Single fallMaxSpeed; // 0x600
	System.Single forwardAccSpeed; // 0x604
	System.Single forwardMaxSpeed; // 0x608
	System.Single forwardBrakeAccSpeed; // 0x60c
	System.Single backAccSpeed; // 0x610
	System.Single backMaxSpeed; // 0x614
	System.Single backBrakeAccSpeed; // 0x618
	System.Single rightLeftAccSpeed; // 0x61c
	System.Single rightLeftMaxSpeed; // 0x620
	System.Single rightLeftBrakeAccSpeed; // 0x624
	System.Single maxSpeed; // 0x628
	System.Single dirExemptAngle; // 0x62c
	System.Single verticalTiltAngle; // 0x630
	System.Single forwardPitch; // 0x634
	System.Single backPitch; // 0x638
	System.Single pitchMax; // 0x63c
	System.Single pitchAngularVelocity; // 0x640
	System.Single leftRoll; // 0x644
	System.Single rightRoll; // 0x648
	System.Single rollMax; // 0x64c
	System.Single rollAngularVelocity; // 0x650
	System.Single yawAngularVelocity; // 0x654
	System.Single reverserAngularVelocity; // 0x658
	System.Single deflect2ZeroAngularVelocity; // 0x65c
	WizardGames.Soc.Common.Combat.ColliderConfigSet colliderConfigSet; // 0x660
	UnityEngine.Transform[] rayCastPoints; // 0x668
	System.Single autoAvoidDis; // 0x670
	UnityEngine.Transform autoAvoidTransform; // 0x678
	System.Single autoAvoidHitDis; // 0x680
	System.Single hLodDistance; // 0x684
	System.Single windMaxStrength; // 0x688
	MiniCopter.MiniCopterInputState _currentInputState; // 0x690
	System.Boolean _pitchIsReverse; // 0x698
	System.Single _pitchReverseTargetDegree; // 0x69c
	System.Boolean _rollIsReverse; // 0x6a0
	System.Single _rollReverseTargetDegree; // 0x6a4
	System.Boolean isPushing; // 0x6a8
	System.Boolean lastForward; // 0x6a9
	UnityEngine.RaycastHit[] _raycastHits; // 0x6b0
	System.Boolean _isAboveAutoAvoidDis; // 0x6b8
	System.Boolean _lastCheckUp; // 0x6b9
	System.Int32 _pushTime; // 0x6bc
	System.Boolean lastStarted; // 0x6c0
	static SocLogger logger; // 0x10
	System.Single cachedPitch; // 0x6c4
	System.Single cachedYaw; // 0x6c8
	System.Single cachedRoll; // 0x6cc
	System.Single GetFuelFraction(); // 0x05809a7c
	System.Int32 StartingFuelUnits(); // 0x05809af4
	System.Void OnChildAdded(BaseRustEntity child); // 0x05809b58
	System.Boolean get_IsStartingUp(); // 0x05809c28
	VehicleEngineController.EngineState<MiniCopter> get_CurEngineState(); // 0x05809d3c
	VehicleEngineController<MiniCopter> get_engineController(); // 0x05809e50
	WizardGames.Soc.Common.Entity.VehicleEntity get_VehicleEntity(); // 0x05809eb4
	System.Single get__verticalTilRadin(); // 0x05809f6c
	System.Boolean Grounded(); // 0x05809fe8
	System.Boolean IsWheelsGrounded(WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo mgrGo); // 0x0580a07c
	System.Void ClearWheelsGroundedInfo(); // 0x0580a15c
	System.Boolean IgnoreSleep(); // 0x0580a214
	static T[,,] OneD_3<T>(T[] obj, System.Int32 len, System.Int32 wid); // 0x052af1f0
	System.Void InitShared(); // 0x0580a294
	System.Single GetServiceCeiling(); // 0x0580a40c
	System.Boolean IsValidSAMTarget(System.Boolean staticRespawn); // 0x0580a474
	System.Void PilotInput(InputState inputState, BasePlayer player); // 0x0580a508
	System.Void UpdateEffects(); // 0x0580a710
	System.Void UpdateRevSpeed(WizardGames.Soc.Common.SimpleCustom.UserCmd inputState); // 0x0580a770
	System.Void PilotInput(WizardGames.Soc.Common.SimpleCustom.UserCmd inputState, BasePlayer player); // 0x0580a9c8
	System.Boolean CheckAutoUp(); // 0x0580ad00
	System.Void SetDir(System.Single joystickYaw, System.Boolean hasMove, System.Single targetYaw, System.Int16& forwardBack, System.Int16& rightLeft); // 0x0580b198
	System.Void SetReverseBool(System.Boolean& isReverse, System.Single& target, System.Boolean res, System.Single targetDegree); // 0x0580b680
	System.Single CalcJoystickYawAfterExempt(System.Single joystickYaw); // 0x0580b0a8
	System.Void NoDriverInput(); // 0x0580b730
	System.Boolean IsStarted(); // 0x0580a948
	System.Void VehicleFixedUpdate(System.Int32 dt); // 0x0580b7a8
	System.Void Check(System.Int32 dt); // 0x0580b994
	System.Void CheckGround(); // 0x0580bab4
	System.Void CheckPush(System.Int32 dt); // 0x0580ba18
	System.Void MovementUpdate(System.Int32 dt); // 0x0580bb3c
	System.Single CalcSpeed(System.Single currentVelocity, System.Single desiredVelocity, System.Single maxSpeed, UnityEngine.AnimationCurve accCurve, UnityEngine.AnimationCurve slowDownCurve, System.Single breakAcc, System.Single dt); // 0x0580c884
	System.Single CalcVerticalAcc(System.Single verticalSpeed, System.Int32 dir, System.Boolean& isBreak); // 0x0580ca0c
	System.Single GetDisturbanceFactor(); // 0x0580cb98
	UnityEngine.Vector2 GetHorizontalVelocity(UnityEngine.Vector3 velocity, System.Single dt); // 0x0580cc84
	System.Void HasDriverMove2(System.Single dt, System.Boolean justStarted); // 0x0580c090
	System.Void HasDriverMove(System.Single dt); // 0x0580cf90
	System.Single Damp(System.Single now, System.Single target, System.Single dt, System.Boolean isYaw, WizardGames.Soc.Common.Utility.SpringDamperMono damper, System.Boolean useTarget); // 0x0580e1b8
	System.Void HasDriveRot2(System.Single dt, System.Boolean justStarted); // 0x0580c2e4
	System.Void HasDriveRot(System.Single dt); // 0x0580e3e4
	System.Single CalcYaw(System.Single now, System.Single target, System.Single dt); // 0x0580e95c
	System.Single NormalizeYaw(System.Single yaw); // 0x0580b524
	System.Single NormalizePitchRoll(System.Single degree); // 0x0580b5d0
	System.Single CalcTargetDegree(System.Int16 dir, System.Single positiveValue, System.Single negativeValue); // 0x0580e750
	System.Single CalcTargetVelocity(System.Int16 dir, System.Single value); // 0x0580e7fc
	System.Single CalcDegree(System.Single nowDegree, System.Single targetDegree, System.Single angularV, System.Single dt); // 0x0580e894
	System.Single CalcReverseDegree(System.Single now, System.Single target, System.Single dt); // 0x0580e67c
	System.Single CalcHorizontalAccSpeed(); // 0x0580d460
	System.Single CalcMaxSpeed(UnityEngine.Vector3 forward, UnityEngine.Vector3 v); // 0x0580dde4
	System.Single CalcVerticalAccSpeed(); // 0x0580d5b4
	UnityEngine.Vector3 CalcOperationAccSpeed(UnityEngine.Vector3 hAccSpeed, UnityEngine.Vector3 vAccSpeed); // 0x0580d640
	UnityEngine.Vector3 Brake(UnityEngine.Vector3 v); // 0x0580d764
	System.Void NoDriverMove(System.Single dt); // 0x0580c640
	System.Void NoDriverRot(System.Single dt); // 0x0580c7c4
	System.Void CalcStartTime(System.Int32 dt); // 0x0580be54
	System.Void SetDefaultInputState(); // 0x0580ea80
	System.Void ApplyForceAtWheels(); // 0x0580bd30
	System.Void ApplyWheelForce(UnityEngine.WheelCollider wheel, System.Single gasScale, System.Single brakeScale, System.Single turning); // 0x0580ec80
	System.Boolean ShouldApplyHoverForce(); // 0x0580eef8
	System.Boolean IsEngineOn(); // 0x0580ef60
	System.Boolean MeetsEngineRequirements(); // 0x0580efc4
	System.Boolean EngineIsAlive(); // 0x0580f0d8
	System.Void Invoke(System.Action action, System.Single time); // 0x0580f158
	System.Void CancelInvoke(System.Action action); // 0x0580f200
	System.Void OnEngineStartFailed(); // 0x0580f298
	System.Void UpdateCOM(); // 0x0580f2f8
	System.Void Save(BaseNetworkable.SaveInfo info); // 0x0580f37c
	System.Void DismountAllPlayers(); // 0x0580f424
	System.Void DoPushAction(BasePlayer player, System.Single pushForceFactor); // 0x0580f484
	System.Void DisablePushing(); // 0x0580f5d0
	System.Single RemapValue(System.Single toUse, System.Single maxRemap); // 0x0580f634
	System.Void Load(BaseNetworkable.LoadInfo info); // 0x0580f6b4
	System.Boolean CanPushNow(BasePlayer pusher); // 0x0580f75c
	System.Single GetMaxHorizontalSpeed(); // 0x0580f814
	System.Void .ctor(); // 0x0580f878
	static System.Void .cctor(); // 0x0580fd94
	System.Void <DoPushAction>b__197_0(System.Int64 id, System.Object data, System.Boolean delete); // 0x0580fe88
}

// Client.Runtime
class MiniCopter.MiniCopterInputState : System.Object
{
	System.Int16 UpDown; // 0x10
	System.Int16 ForwardBack; // 0x12
	System.Int16 RightLeft; // 0x14
	System.Single JoystickYaw; // 0x18
	System.Boolean HasMove; // 0x1c
	System.Single Yaw; // 0x20
	System.Single ViewPitch; // 0x24
	System.Single JoystickPercent; // 0x28
	System.Void Reset(); // 0x0580ac90
	System.Void .ctor(); // 0x0580fd2c
}

// Client.Runtime
class BaseModularVehicle : GroundVehicle
{
	System.Collections.Generic.List<Rust.Modular.ModularVehicleSocket> moduleSockets; // 0x3a8
	UnityEngine.Transform centreOfMassTransform; // 0x3b0
	UnityEngine.Transform waterSample; // 0x3b8
	UnityEngine.LODGroup lodGroup; // 0x3c0
	System.Boolean ScanAllRenderInlcudeInAcitve; // 0x3c8
	UnityEngine.AnimationCurve DefaultHpCurve; // 0x3d0
	System.Collections.Generic.List<BaseVehicleModule> <AttachedModuleEntities>k__BackingField; // 0x3d8
	System.Single _mass; // 0x3e0
	System.Single <TotalMass>k__BackingField; // 0x3e4
	System.Boolean <HasInited>k__BackingField; // 0x3e8
	static BaseRustEntity.Flags FLAG_KINEMATIC = 16384;
	Rust.Modular.ItemModVehicleModule AssociatedItemDef; // 0x3f0
	System.Collections.Generic.Dictionary<BaseVehicleModule,System.Action> moduleAddActions; // 0x3f8
	System.Single originalMass; // 0x400
	Rust.Modular.ModuleSocketController SocketController; // 0x408
	System.Boolean inEditableLocation; // 0x410
	System.Boolean prevEditable; // 0x411
	System.Boolean immuneToDecay; // 0x412
	UnityEngine.Vector3 realLocalCOM; // 0x414
	Item AssociatedItemInstance; // 0x420
	System.Boolean disablePhysics; // 0x428
	System.Void ClientLightsChanged(System.Boolean headlightsOn, System.Boolean brakesOn); // 0x0580ff24
	UnityEngine.Vector3 get_CentreOfMass(); // 0x0581027c
	System.Int32 get_NumAttachedModules(); // 0x058102ec
	System.Boolean get_HasAnyModules(); // 0x058103ac
	System.Collections.Generic.List<BaseVehicleModule> get_AttachedModuleEntities(); // 0x05810474
	System.Int32 get_TotalSockets(); // 0x058104d8
	System.Int32 get_NumFreeSockets(); // 0x05810554
	System.Single get_Mass(); // 0x0581075c
	System.Single get_TotalMass(); // 0x058107ec
	System.Void set_TotalMass(System.Single value); // 0x05810850
	System.Boolean get_IsKinematic(); // 0x058108c8
	System.Boolean get_IsLockable(); // 0x05810934
	System.Boolean get_HasInited(); // 0x05810998
	System.Void set_HasInited(System.Boolean value); // 0x058109fc
	System.Boolean get_IsEditableNow(); // 0x05810a78
	System.Void InitShared(); // 0x05810b98
	System.Boolean TryDeduceSocketIndex(BaseVehicleModule addedModule, System.Int32& index); // 0x058114bc
	System.Void AddMass(System.Single moduleMass, UnityEngine.Vector3 moduleCOM, UnityEngine.Vector3 moduleWorldPos); // 0x05810f04
	System.Void RemoveMass(System.Single moduleMass, UnityEngine.Vector3 moduleCOM, UnityEngine.Vector3 moduleWorldPos); // 0x058118a8
	System.Boolean TryGetModuleAt(System.Int32 socketIndex, BaseVehicleModule& result); // 0x05811af0
	Rust.Modular.ModularVehicleSocket GetSocket(System.Int32 index); // 0x05811da8
	System.Boolean CanPushNow(BasePlayer pusher); // 0x05811e74
	System.Void OnChildAdded(BaseRustEntity childEntity); // 0x05811f1c
	System.Void OnChildRemoved(BaseRustEntity childEntity); // 0x05812170
	System.Void ModuleEntityAdded(BaseVehicleModule addedModule); // 0x05812248
	System.Void ModuleEntityRemoved(BaseVehicleModule removedModule); // 0x05812bb0
	System.Void RefreshModulesExcept(BaseVehicleModule ignoredModule); // 0x058129a8
	WizardGames.Soc.Common.Entity.ModularCarEntity get_ModularCarEntity(); // 0x05812f0c
	System.Void set_ModularCarEntity(WizardGames.Soc.Common.Entity.ModularCarEntity value); // 0x05812fb8
	System.Void OnModuleAdded(BaseVehicleModule module); // 0x05813038
	System.Void OnModuleRemoved(BaseVehicleModule module); // 0x05813448
	UnityEngine.Transform GetSocketRoot(System.Int32 socketIndex); // 0x058139f4
	System.Void ServerInit(WizardGames.Soc.Common.Entity.IEntity entity, WizardGames.Soc.Common.Unity.Go.BaseEntityGo entityGo); // 0x05813b10
	System.Void PreServerLoad(); // 0x05813c20
	System.Void PostServerLoad(); // 0x05813c88
	System.Void DoServerDestroy(); // 0x05813d0c
	System.Single MaxVelocity(); // 0x05813d74
	System.Boolean IsComplete(); // 0x054c4760
	System.Boolean CouldBeEdited(); // 0x05810b04
	System.Void DisablePhysics(); // 0x05813dfc
	System.Void EnablePhysics(); // 0x05813e78
	System.Void VehicleFixedUpdate(System.Int32 dt); // 0x05813ef0
	System.Boolean MountEligable(BasePlayer player); // 0x05813fc8
	System.Void Save(BaseNetworkable.SaveInfo info); // 0x05814114
	UnityEngine.Vector3 GetCOMMultiplier(); // 0x054b1148
	System.Void ModuleHurt(BaseVehicleModule hurtModule, HitInfo info); // 0x0552af00
	System.Void ModuleReachedZeroHealth(); // 0x055049cc
	System.Boolean TryAddModule(Item moduleItem, System.Int32 socketIndex); // 0x05814194
	System.Boolean TryAddModule(Item moduleItem); // 0x05814524
	System.Boolean ModuleCanBeAdded(Item moduleItem, System.Int32 socketIndex, System.String& failureReason); // 0x05814388
	BaseVehicleModule CreatePhysicalModuleEntity(Item moduleItem, Rust.Modular.ItemModVehicleModule itemModModule, System.Int32 socketIndex); // 0x05814644
	System.Void SetUpModule(BaseVehicleModule moduleEntity, Item moduleItem); // 0x058147bc
	Item GetVehicleItem(System.UInt32 itemUID); // 0x05814858
	BaseVehicleModule GetModuleForItem(Item item); // 0x058148f0
	System.Void SetMass(System.Single mass); // 0x058116bc
	System.Void SetCOM(UnityEngine.Vector3 com); // 0x058117d8
	System.Void .ctor(); // 0x05814acc
}

// Client.Runtime
class BaseModularVehicle.<>c__DisplayClass48_0 : System.Object
{
	BaseModularVehicle <>4__this; // 0x10
	BaseVehicleModule module; // 0x18
	System.Void .ctor(); // 0x05812108
	System.Void <OnChildAdded>b__0(); // 0x05814be4
}

// Client.Runtime
class BaseVehicleModule : BaseVehicle
{
	WizardGames.Soc.Common.Entity.IVehicleModuleCustom Entity; // 0x360
	BaseVehicleModule.DestroyMode destroyMode; // 0x368
	System.Boolean UseCustomHPCurve; // 0x369
	UnityEngine.AnimationCurve CustomHpCurve; // 0x370
	TimeSince TimeSinceAddedToVehicle; // 0x378
	UnityEngine.Transform centreOfMassTransform; // 0x380
	System.Single mass; // 0x388
	BaseVehicleModule.VisualGroup visualGroup; // 0x38c
	System.Boolean DbgLog; // 0x390
	System.Collections.Generic.List<SocVehicle.Scripts.Light.VehicleLight> lights; // 0x398
	BaseModularVehicle <Vehicle>k__BackingField; // 0x3a0
	System.Int32 <FirstSocketIndex>k__BackingField; // 0x3a8
	BaseVehicleModule.LODLevel[] lodRenderers; // 0x3b0
	System.Collections.Generic.List<Rust.Modular.ConditionalObject> conditionals; // 0x3b8
	Rust.Modular.VehicleModuleSlidingComponent[] slidingComponents; // 0x3c0
	ConditionalGibbable conditionalGibbable; // 0x3c8
	System.Single prevRefreshHealth; // 0x3d0
	System.Boolean prevRefreshVehicleIsDead; // 0x3d4
	System.Boolean prevRefreshVehicleIsLockable; // 0x3d5
	Item AssociatedItemInstance; // 0x3d8
	System.Boolean <PropagateDamage>k__BackingField; // 0x3e0
	static System.Single TIME_BETWEEN_LOCK_REFRESH = 1;
	System.Void VehicleClientTick(System.Int32 deltaTime); // 0x05814c60
	System.Void ClientOnLoad(); // 0x05814d30
	System.Void OnFlagsChanged(BaseRustEntity.Flags old, BaseRustEntity.Flags next); // 0x0581507c
	BaseModularVehicle get_Vehicle(); // 0x05815108
	System.Void set_Vehicle(BaseModularVehicle value); // 0x0581516c
	System.Int32 get_FirstSocketIndex(); // 0x058151ec
	System.Void set_FirstSocketIndex(System.Int32 value); // 0x05815250
	UnityEngine.Vector3 get_CentreOfMass(); // 0x05812938
	System.Single get_Mass(); // 0x058152c8
	System.Boolean get_IsOnAVehicle(); // 0x05814fa0
	System.Boolean get_HasSeating(); // 0x0581532c
	System.Boolean get_HasAnEngine(); // 0x05815390
	ConditionalGibbable get_ConditionalGibbable(); // 0x058153f4
	System.Void AfterPartLoaded(UnityEngine.GameObject partGo); // 0x05815458
	System.Void InitShared(); // 0x058155a4
	System.Void RefreshParameters(); // 0x05815614
	System.Void ModuleAdded(BaseModularVehicle vehicle, System.Int32 firstSocketIndex); // 0x05815784
	System.Void SetLightState(System.Boolean headlightsOn, System.Boolean brakesOn); // 0x058100f8
	System.Void ModuleRemoved(); // 0x058158dc
	System.Void OtherVehicleModulesChanged(); // 0x05812ea4
	System.Void OnEngineStateChanged(VehicleEngineController.EngineState<GroundVehicle> oldState, VehicleEngineController.EngineState<GroundVehicle> newState); // 0x058159e8
	System.Single MaxHealth(); // 0x05815a64
	System.Single StartHealth(); // 0x05815acc
	System.Int32 GetNumSocketsTaken(); // 0x05810684
	System.Single GetMaxDriveForce(); // 0x05815b30
	System.Void RefreshConditionals(System.Boolean canGib); // 0x0581115c
	System.Void PostConditionalRefresh(); // 0x05816af0
	System.Void RefreshConditional(Rust.Modular.ConditionalObject conditional, System.Boolean canGib); // 0x05815b94
	System.Boolean TryGetAdjacentModuleInFront(BaseVehicleModule& result); // 0x05816b50
	System.Boolean TryGetAdjacentModuleBehind(BaseVehicleModule& result); // 0x05816dcc
	System.Boolean InSameVisualGroupAs(BaseVehicleModule moduleEntity, Rust.Modular.ConditionalObject.AdjacentMatchType matchType); // 0x05816c98
	System.Boolean PlayerIsLookingAtUsable(System.String lookingAtColldierName, System.String usableColliderName); // 0x05816f20
	System.Void RefreshConditionalGibbable(UnityEngine.MeshRenderer[] meshRenderers); // 0x05816fb8
	System.Void Load(BaseNetworkable.LoadInfo info); // 0x0581716c
	System.Boolean IsVehicleRoot(); // 0x058171ec
	Rust.Modular.ModularVehicleSocket.SocketLocationType GetLocationType(); // 0x05817250
	System.Boolean get_PropagateDamage(); // 0x05817398
	System.Void set_PropagateDamage(System.Boolean value); // 0x058173fc
	System.Void NonUserSpawn(); // 0x05817478
	System.Void VehicleFixedUpdate(System.Int32 dt); // 0x058174d8
	System.Void UpdateEntityVelocity(); // 0x058175dc
	System.Void Hurt(HitInfo info); // 0x05817888
	System.Void OnHealthChanged(System.Single oldValue, System.Single newValue); // 0x0581797c
	System.Boolean CanBeMovedNowOnVehicle(); // 0x05817a34
	System.Single GetAdjustedDriveForce(System.Single absSpeed, System.Single topSpeed); // 0x05817a98
	System.Void AdminKill(); // 0x05817b18
	System.Void OnPlayerDismountedVehicle(BasePlayer player); // 0x05817be4
	System.Void .ctor(); // 0x05817c58
}

// Client.Runtime
enum BaseVehicleModule.DestroyMode : System.Enum
{
	System.Byte value__; // 0x10
	static BaseVehicleModule.DestroyMode None = 0;
	static BaseVehicleModule.DestroyMode Gib = 1;
	
}

// Client.Runtime
enum BaseVehicleModule.VisualGroup : System.Enum
{
	System.Int32 value__; // 0x10
	static BaseVehicleModule.VisualGroup None = 0;
	static BaseVehicleModule.VisualGroup Engine = 1;
	static BaseVehicleModule.VisualGroup Cabin = 2;
	static BaseVehicleModule.VisualGroup Flatbed = 3;
	
}

// Client.Runtime
class BaseVehicleModule.LODLevel : System.Object
{
	UnityEngine.Renderer[] renderers; // 0x10
	System.Void .ctor(); // 0x05817d50
}

// Client.Runtime
class ModularCar : BaseModularVehicle, VehicleChassisVisuals.IClientWheelUser<ModularCar>, CarPhysics.ICar<ModularCar>
{
	VehicleChassisVisuals.ClientWheelData<ModularCar> <WheelDataFL>k__BackingField; // 0x430
	VehicleChassisVisuals.ClientWheelData<ModularCar> <WheelDataFR>k__BackingField; // 0x438
	VehicleChassisVisuals.ClientWheelData<ModularCar> <WheelDataRL>k__BackingField; // 0x440
	VehicleChassisVisuals.ClientWheelData<ModularCar> <WheelDataRR>k__BackingField; // 0x448
	System.Single clientDriveWheelSlip; // 0x450
	TimeSince timeSinceLastUpdate; // 0x454
	TimeSince timeSinceFailedStartAttempt; // 0x458
	TimeSince timeSinceEnginePerfCheck; // 0x45c
	System.Boolean cachedEngineLowPerf; // 0x460
	static System.Single FAILED_START_LIGHT_TIME = 1;
	System.Boolean wasBraking; // 0x461
	CarPhysicsViewData ViewData; // 0x468
	UnityEngine.AnimationCurve ForwardForceCurve; // 0x470
	ModularCarChassisVisuals chassisVisuals; // 0x478
	VisualCarWheel wheelFL; // 0x480
	VisualCarWheel wheelFR; // 0x488
	VisualCarWheel wheelRL; // 0x490
	VisualCarWheel wheelRR; // 0x498
	CarSettings carSettings; // 0x4a0
	System.Single hurtTriggerMinSpeed; // 0x4a8
	TriggerHurtNotChild hurtTriggerFront; // 0x4b0
	TriggerHurtNotChild hurtTriggerRear; // 0x4b8
	ProtectionProperties immortalProtection; // 0x4c0
	ProtectionProperties mortalProtection; // 0x4c8
	ModularCar.SpawnSettings spawnSettings; // 0x4d0
	UnityEngine.MeshRenderer[] damageShowingRenderers; // 0x4d8
	static System.Single population; // 0x0
	static System.Single outsidedecayminutes; // 0x4
	static BUTTON RapidSteerButton = 128;
	VehicleEngineController.EngineState<GroundVehicle> lastSetEngineState; // 0x4e0
	System.Single cachedFuelFraction; // 0x4e4
	static SocLogger logger; // 0x8
	SteerAngleCurveConfig SteerAngleCurveConfig; // 0x4e8
	ListDictionary<System.Int64,ModularCar.DriverSeatInputs> driverSeatInputs; // 0x4f0
	CarPhysics<ModularCar> carPhysics; // 0x4f8
	VehicleTerrainHandler serverTerrainHandler; // 0x500
	CarWheel[] wheels; // 0x508
	System.Single lastEngineOnTime; // 0x510
	static System.Single DECAY_TICK_TIME = 60;
	static System.Single INSIDE_DECAY_MULTIPLIER = 0.10000000149011612;
	static System.Single CORPSE_DECAY_MINUTES = 5;
	UnityEngine.Vector3 prevPosition; // 0x514
	UnityEngine.Quaternion prevRotation; // 0x520
	System.Single prevFixedUpdateTime; // 0x530
	System.Single deathDamageCounter; // 0x534
	static System.Single DAMAGE_TO_GIB = 600;
	TimeSince timeSinceDeath; // 0x538
	static System.Single IMMUNE_TIME = 1;
	UnityEngine.Vector3 groundedCOMMultiplier; // 0x53c
	UnityEngine.Vector3 airbourneCOMMultiplier; // 0x548
	UnityEngine.Vector3 prevCOMMultiplier; // 0x554
	System.Int32 LastCmdSqe; // 0x560
	VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataFL(); // 0x05817db8
	System.Void set_WheelDataFL(VehicleChassisVisuals.ClientWheelData<ModularCar> value); // 0x05817e1c
	VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataFR(); // 0x05817e9c
	System.Void set_WheelDataFR(VehicleChassisVisuals.ClientWheelData<ModularCar> value); // 0x05817f00
	VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataRL(); // 0x05817f80
	System.Void set_WheelDataRL(VehicleChassisVisuals.ClientWheelData<ModularCar> value); // 0x05817fe4
	VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataRR(); // 0x05818064
	System.Void set_WheelDataRR(VehicleChassisVisuals.ClientWheelData<ModularCar> value); // 0x058180c8
	System.Void ClientInit(); // 0x05818148
	System.Void VehicleClientTick(System.Int32 deltaTime); // 0x058186d4
	System.Void OnClientTickStopped(); // 0x058188bc
	System.Boolean IsBraking(); // 0x05818840
	System.Boolean HasAnEngineAtLowPerformance(); // 0x05818944
	System.Boolean HasLowFuel(); // 0x05818c6c
	System.Boolean HadRecentFailedEngineStart(); // 0x05818d5c
	System.Int64 GetOwnerID(); // 0x05818e74
	System.Single get_DriveWheelVelocity(); // 0x05819024
	System.Single get_DriveWheelSlip(); // 0x058190fc
	System.Single get_SteerAngle(); // 0x058191d4
	System.Single get_MaxSteerAngle(); // 0x058192ac
	System.Void InitShared(); // 0x0581931c
	System.Single MaxHealth(); // 0x05819380
	System.Single StartHealth(); // 0x05819408
	System.Single TotalHealth(); // 0x05819490
	System.Single TotalMaxHealth(); // 0x058195fc
	System.Single GetMaxForwardSpeed(); // 0x05819768
	System.Void OnFlagsChanged(BaseRustEntity.Flags old, BaseRustEntity.Flags next); // 0x05819920
	System.Single GetThrottleInput(); // 0x05819c44
	System.Single GetBrakeInput(); // 0x05819e1c
	System.Single GetMaxDriveForce(); // 0x05819848
	System.Single GetFuelFraction(); // 0x05818ce4
	System.Boolean PlayerHasUnlockPermission(BasePlayer player); // 0x05819ff4
	System.Boolean PlayerCanDestroyLock(BasePlayer player, BaseVehicleModule viaModule); // 0x0581a06c
	System.Boolean CanBeLooted(BasePlayer player); // 0x0581a0ec
	System.Boolean CanPushNow(BasePlayer pusher); // 0x0581a190
	System.Boolean RefreshEngineState(); // 0x058199c8
	System.Void OnEngineStateChanged<T>(VehicleEngineController.EngineState<T> newState); // 0x052af1f0
	System.Single RollOffDriveForce(System.Single driveForce, System.Int32 index); // 0x0581a20c
	System.Void RefreshChassisProtectionState(); // 0x0581a344
	System.Void ModuleEntityAdded(BaseVehicleModule addedModule); // 0x0581a410
	System.Void ModuleEntityRemoved(BaseVehicleModule removedModule); // 0x0581a494
	System.Boolean IsWheelsGrounded(WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo mgrGo); // 0x0581a518
	System.Void ClearWheelsGroundedInfo(); // 0x0581a60c
	System.Boolean get_AlwaysAllowBradleyTargeting(); // 0x0581a6d4
	VehicleTerrainHandler.Surface get_OnSurface(); // 0x0581a738
	System.Void ServerInit(WizardGames.Soc.Common.Entity.IEntity entity, WizardGames.Soc.Common.Unity.Go.BaseEntityGo entityGo); // 0x0581a7ac
	System.Void DoServerDestroy(); // 0x0581aaf0
	System.Void PostServerLoad(); // 0x0581ab64
	System.Single GetSteerInput(); // 0x0581abfc
	System.Boolean GetSteerModInput(); // 0x0581ad4c
	System.Single GetSteerAngleForSpeed(System.Single steerAngle, System.Single speed, System.Single maxSpeed); // 0x0581ae80
	System.Single GetSteerSpeedForSpeed(System.Single steerSpeed, System.Single speed, System.Single maxSpeed); // 0x0581af14
	System.Void VehicleFixedUpdate(System.Int32 dt); // 0x0581b048
	System.Void VehicleFixedUpdateWhenSleep(System.Int32 dt); // 0x0581b838
	System.Void PlayerServerInput(WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld, WizardGames.Soc.Common.SimpleCustom.UserCmd inputState, BasePlayer player); // 0x0581b8e0
	System.Void PlayerServerInput(WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld, InputState inputState, BasePlayer player); // 0x0581bc98
	System.Void PlayerDismounted(BasePlayer player, BaseMountable seat); // 0x0581bd28
	System.Void Save(BaseNetworkable.SaveInfo info); // 0x0581c018
	System.Void Hurt(HitInfo info); // 0x0581c094
	System.Void TickFuel(System.Single fuelUsedPerSecond); // 0x0581c114
	System.Boolean MountEligable(BasePlayer player); // 0x0581c1b0
	System.Boolean IsComplete(); // 0x0581c22c
	System.Void DoDecayDamage(System.Single damage); // 0x0581c42c
	System.Single GetAdjustedDriveForce(System.Single absSpeed, System.Single topSpeed); // 0x0581c4a0
	System.Boolean HasAnyEngines(); // 0x0581c2cc
	System.Boolean HasAnyWorkingEngines(); // 0x0581c64c
	System.Boolean MeetsEngineRequirements(); // 0x0581c6bc
	System.Boolean EngineIsAlive(); // 0x0581c73c
	System.Boolean HasDriver(); // 0x0581c9b8
	System.Void OnEngineStartFailed(); // 0x0581cb3c
	CarWheel[] GetWheels(); // 0x0581cb9c
	System.Single GetWheelsMidPos(); // 0x0581cd34
	System.Boolean AdminFixUp(System.Int32 tier); // 0x0581ce24
	System.Void ModuleHurt(BaseVehicleModule hurtModule, HitInfo info); // 0x0581d014
	System.Void ModuleReachedZeroHealth(); // 0x0581d190
	System.Void OnKilled(HitInfo info); // 0x0581d3e4
	System.Void RestoreVelocity(UnityEngine.Vector3 vel); // 0x0581d468
	UnityEngine.Vector3 GetCOMMultiplier(); // 0x0581d5a0
	System.Void UpdateClients(); // 0x0581d654
	System.Void DecayTick(); // 0x0581d704
	System.Void SpawnPreassignedModules(); // 0x0581a90c
	System.Void CreateModuleEntity(Rust.Modular.ItemModVehicleModule moduleItemDef, System.Int32 socketIndex); // 0x0581d9ec
	System.Void HandleAdminBonus(); // 0x0581dac4
	System.Void RPC_OpenFuel(BaseRustEntity.RPCMessage msg); // 0x0581db8c
	System.Void ScaleDamageForPlayer(BasePlayer player, HitInfo info); // 0x0581dc14
	System.Void .ctor(); // 0x0581dca0
	static System.Void .cctor(); // 0x0581ddbc
}

// Client.Runtime
class ModularCar.SpawnSettings : System.Object
{
	System.Boolean useSpawnSettings; // 0x10
	ModularCarPresetConfig[] configurationOptions; // 0x18
	System.Single minStartHealthPercent; // 0x20
	System.Single maxStartHealthPercent; // 0x24
	ModularCar.SpawnSettings.AdminBonus adminBonus; // 0x28
	System.Void .ctor(); // 0x0581dea8
}

// Client.Runtime
enum ModularCar.SpawnSettings.AdminBonus : System.Enum
{
	System.Int32 value__; // 0x10
	static ModularCar.SpawnSettings.AdminBonus None = 0;
	static ModularCar.SpawnSettings.AdminBonus T1PlusFuel = 1;
	static ModularCar.SpawnSettings.AdminBonus T2PlusFuel = 2;
	static ModularCar.SpawnSettings.AdminBonus T3PlusFuel = 3;
	
}

// Client.Runtime
class ModularCar.DriverSeatInputs : System.Object
{
	System.Single steerInput; // 0x10
	System.Boolean steerMod; // 0x14
	System.Single brakeInput; // 0x18
	System.Single throttleInput; // 0x1c
	System.Void .ctor(); // 0x0581bc30
}

// Client.Runtime
class ModularCar.<>c : System.Object
{
	static ModularCar.<>c <>9; // 0x0
	static System.Func<BaseVehicleModule,System.Single> <>9__145_0; // 0x8
	static System.Void .cctor(); // 0x0581df1c
	System.Void .ctor(); // 0x0581df80
	System.Single <DecayTick>b__145_0(BaseVehicleModule module); // 0x0581dfe8
}

// Client.Runtime
class ModularCarChassisVisuals : VehicleChassisVisuals<ModularCar>
{
	UnityEngine.Transform frontAxle; // 0x48
	UnityEngine.Transform rearAxle; // 0x50
	ModularCarChassisVisuals.Steering steering; // 0x58
	ModularCarChassisVisuals.LookAtTarget transmission; // 0x60
	ModularCar modularCar; // 0x68
	System.Void Init(ModularCar owner, VehicleChassisVisuals.ClientWheelData<ModularCar>[] clientWheelData); // 0x0581e074
	System.Void PreWheelUpdateTick(); // 0x0581e124
	System.Void PostWheelUpdateTick(System.Boolean instant, System.Boolean isCloseToCamera, System.Single steer, System.Single dt); // 0x0581e184
	System.Void UpdateWheelVisuals(VehicleChassisVisuals.ClientWheelData<ModularCar> wheelData, System.Boolean isOn, System.Single steer, System.Single dt); // 0x0581e8c0
	System.Void UpdateAxle(UnityEngine.Transform axle, VehicleChassisVisuals.ClientWheelData<ModularCar> wheelDataL, VehicleChassisVisuals.ClientWheelData<ModularCar> wheelDataR, System.Single dt, System.Boolean instant); // 0x0581e414
	System.Void LookAt(ModularCarChassisVisuals.LookAtTarget lookAt); // 0x0581e6e4
	System.Void .ctor(); // 0x0581ea7c
}

// Client.Runtime
class ModularCarChassisVisuals.Steering : System.Object
{
	UnityEngine.Transform steerL; // 0x10
	UnityEngine.Transform steerR; // 0x18
	ModularCarChassisVisuals.LookAtTarget steerRodL; // 0x20
	ModularCarChassisVisuals.LookAtTarget steerRodR; // 0x28
	ModularCarChassisVisuals.LookAtTarget steeringArm; // 0x30
	System.Void .ctor(); // 0x0581eaf8
}

// Client.Runtime
class ModularCarChassisVisuals.LookAtTarget : System.Object
{
	UnityEngine.Transform aim; // 0x10
	UnityEngine.Transform target; // 0x18
	UnityEngine.Vector3 angleAdjust; // 0x20
	System.Void .ctor(); // 0x0581eb60
}

// Client.Runtime
class ModularCarPresetConfig : UnityEngine.ScriptableObject
{
	Rust.Modular.ItemModVehicleModule[] socketItemDefs; // 0x18
	System.Void .ctor(); // 0x0581ebc8
}

// Client.Runtime
class VehicleModuleCamper : VehicleModuleSeating
{
	GameObjectRef SleepingBagEntity; // 0x468
	UnityEngine.Transform[] SleepingBagPoints; // 0x470
	GameObjectRef LockerEntity; // 0x478
	UnityEngine.Transform LockerPoint; // 0x480
	GameObjectRef BbqEntity; // 0x488
	UnityEngine.Transform BbqPoint; // 0x490
	GameObjectRef StorageEntity; // 0x498
	UnityEngine.Transform StoragePoint; // 0x4a0
	System.Boolean wasLoaded; // 0x4a8
	System.Void ResetState(); // 0x0581ec30
	System.Void ModuleAdded(BaseModularVehicle vehicle, System.Int32 firstSocketIndex); // 0x0581eca0
	UnityEngine.Vector3 ModifySeatPositionLocalSpace(System.Int32 index, UnityEngine.Vector3 desiredPos); // 0x0581ee5c
	System.Void PostServerLoad(); // 0x0581efbc
	System.Void Spawn(); // 0x0581f030
	System.Boolean CanBeMovedNowOnVehicle(); // 0x0581f098
	System.Void PostConditionalRefresh(); // 0x0581f0fc
	System.Void DoServerDestroy(); // 0x0581f160
	System.Boolean CanBeLooted(BasePlayer player); // 0x0581f1c8
	System.Boolean IsOnThisModule(BasePlayer player); // 0x0581f264
	System.Void .ctor(); // 0x0581f2fc
}

// Client.Runtime
class VehicleModuleEngine : VehicleModuleStorage
{
	VehicleModuleEngine.Engine engine; // 0x480
	System.Boolean <IsUsable>k__BackingField; // 0x488
	System.Single <PerformanceFractionAcceleration>k__BackingField; // 0x48c
	System.Single <PerformanceFractionTopSpeed>k__BackingField; // 0x490
	System.Single <PerformanceFractionFuelEconomy>k__BackingField; // 0x494
	System.Single <OverallPerformanceFraction>k__BackingField; // 0x498
	static System.Single FORCE_MULTIPLIER = 12.75;
	static System.Single HEALTH_PERFORMANCE_FRACTION = 0.25;
	static System.Single LOW_PERFORMANCE_THRESHOLD = 0.5;
	static System.Single MIN_FORCE_BIAS = 0.00019999999494757503;
	static System.Single MAX_FORCE_BIAS = 0.699999988079071;
	System.Boolean get_HasAnEngine(); // 0x0581f3cc
	System.Boolean get_IsUsable(); // 0x0581f430
	System.Void set_IsUsable(System.Boolean value); // 0x0581f494
	System.Single get_PerformanceFractionAcceleration(); // 0x0581f510
	System.Void set_PerformanceFractionAcceleration(System.Single value); // 0x0581f574
	System.Single get_PerformanceFractionTopSpeed(); // 0x0581f5ec
	System.Void set_PerformanceFractionTopSpeed(System.Single value); // 0x0581f650
	System.Single get_PerformanceFractionFuelEconomy(); // 0x0581f6c8
	System.Void set_PerformanceFractionFuelEconomy(System.Single value); // 0x0581f72c
	System.Single get_OverallPerformanceFraction(); // 0x0581f7a4
	System.Void set_OverallPerformanceFraction(System.Single value); // 0x0581f808
	System.Boolean get_AtLowPerformance(); // 0x05818bb8
	System.Boolean get_AtPeakPerformance(); // 0x0581f880
	System.Int32 get_KW(); // 0x0581f9a0
	System.Boolean get_EngineIsOn(); // 0x0581fa10
	System.Void InitShared(); // 0x0581fb58
	System.Void PlaySound(VehicleEngineController.EngineState<GroundVehicle> oldState, VehicleEngineController.EngineState<GroundVehicle> newState); // 0x0581fbbc
	System.Void OnEngineStateChanged(VehicleEngineController.EngineState<GroundVehicle> oldState, VehicleEngineController.EngineState<GroundVehicle> newState); // 0x05820040
	System.Single GetMaxDriveForce(); // 0x058208d4
	System.Void RefreshPerformanceStats(); // 0x05820228
	System.Single GetPerformanceFraction(System.Single statBoostPercent); // 0x058209a0
	System.Void VehicleFixedUpdate(System.Int32 dt); // 0x05820a90
	System.Single GetAdjustedDriveForce(System.Single absSpeed, System.Single topSpeed); // 0x05820ce8
	System.Boolean AdminFixUp(System.Int32 tier); // 0x05820e10
	System.Void .ctor(); // 0x05820e90
}

// Client.Runtime
class VehicleModuleEngine.ParticleSystemContainer : System.Object
{
	UnityEngine.Transform transform; // 0x10
	System.Void .ctor(); // 0x05820f60
}

// Client.Runtime
class VehicleModuleEngine.Engine : System.Object
{
	System.Int32 engineKW; // 0x10
	System.Single idleFuelPerSec; // 0x14
	System.Single maxFuelPerSec; // 0x18
	VehicleModuleEngine.ParticleSystemContainer[] engineParticles; // 0x20
	System.String[] exhaustSmokeName; // 0x28
	System.String[] exhaustBackfireName; // 0x30
	System.Single exhaustSmokeMinOpacity; // 0x38
	System.Single exhaustSmokeMaxOpacity; // 0x3c
	System.Single exhaustSmokeChangeRate; // 0x40
	System.Void .ctor(); // 0x05820fc8
}

// Client.Runtime
class VehicleModuleSeating : BaseVehicleModule
{
	ProtectionProperties passengerProtection; // 0x3e8
	UnityEngine.GameObject LockGo; // 0x3f0
	static BaseRustEntity.Flags FLAG_HORN = 65536;
	VehicleModuleSeating.Seating seating; // 0x3f8
	UnityEngine.Vector3 steerAngle; // 0x400
	UnityEngine.Vector3 accelAngle; // 0x40c
	UnityEngine.Vector3 brakeAngle; // 0x418
	UnityEngine.Vector3 speedometerAngle; // 0x424
	UnityEngine.Vector3 fuelAngle; // 0x430
	System.Single steerPercent; // 0x43c
	System.Single throttlePercent; // 0x440
	System.Single brakePercent; // 0x444
	System.Nullable<System.Boolean> checkEngineLightOn; // 0x448
	System.Nullable<System.Boolean> fuelLightOn; // 0x44a
	ModularCar <Car>k__BackingField; // 0x450
	System.Int32 last_seq; // 0x458
	BasePlayer hornPlayer; // 0x460
	System.Boolean get_HasSeating(); // 0x0582104c
	ModularCar get_Car(); // 0x058210d0
	System.Void set_Car(ModularCar value); // 0x05821134
	System.Boolean get_IsOnACar(); // 0x058211b4
	System.Boolean get_DoorsAreLockable(); // 0x05821290
	System.Void OnFlagsChanged(BaseRustEntity.Flags old, BaseRustEntity.Flags next); // 0x05821300
	System.Boolean IsOnThisModule(BasePlayer player); // 0x05821388
	System.Boolean HasADriverSeat(); // 0x05821558
	System.Void ModuleAdded(BaseModularVehicle vehicle, System.Int32 firstSocketIndex); // 0x0581ed28
	System.Void ModuleRemoved(); // 0x058216c8
	System.Boolean PlayerCanDestroyLock(BasePlayer player); // 0x05821788
	BaseVehicleSeat GetSeatAtIndex(System.Int32 index); // 0x05821800
	System.Void ScaleDamageForPlayer(BasePlayer player, HitInfo info); // 0x058218f4
	BaseVehicle VehicleParent(); // 0x058219ec
	System.Void PlayerServerInput(WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld, WizardGames.Soc.Common.SimpleCustom.UserCmd inputState, BasePlayer player); // 0x05821a9c
	System.Void PlayerServerInput(WizardGames.Soc.Common.Synchronization.IChangeWorld changeWorld, InputState inputState, BasePlayer player); // 0x05821d54
	System.Void OnPlayerDismountedVehicle(BasePlayer player); // 0x05821df8
	UnityEngine.Vector3 ModifySeatPositionLocalSpace(System.Int32 index, UnityEngine.Vector3 desiredPos); // 0x0581ef14
	System.Void OnEngineStateChanged(VehicleEngineController.EngineState<GroundVehicle> oldState, VehicleEngineController.EngineState<GroundVehicle> newState); // 0x058201a0
	System.Void .ctor(); // 0x0581f360
}

// Client.Runtime
class VehicleModuleSeating.MountHotSpot : System.Object
{
	UnityEngine.Transform transform; // 0x10
	UnityEngine.Vector2 size; // 0x18
	System.Void .ctor(); // 0x05821ec0
}

// Client.Runtime
class VehicleModuleSeating.Seating : System.Object
{
	System.Boolean doorsAreLockable; // 0x10
	BaseVehicle.MountPointInfo[] mountPoints; // 0x18
	UnityEngine.Transform steeringWheel; // 0x20
	UnityEngine.Transform accelPedal; // 0x28
	UnityEngine.Transform brakePedal; // 0x30
	UnityEngine.Transform steeringWheelLeftGrip; // 0x38
	UnityEngine.Transform steeringWheelRightGrip; // 0x40
	UnityEngine.Transform accelPedalGrip; // 0x48
	UnityEngine.Transform brakePedalGrip; // 0x50
	VehicleModuleSeating.MountHotSpot[] mountHotSpots; // 0x58
	UnityEngine.Transform speedometer; // 0x60
	UnityEngine.Transform fuelGauge; // 0x68
	UnityEngine.Renderer dashboardRenderer; // 0x70
	System.Int32 checkEngineLightMatIndex; // 0x78
	UnityEngine.Color checkEngineLightEmission; // 0x7c
	System.Int32 fuelLightMatIndex; // 0x8c
	UnityEngine.Color fuelLightEmission; // 0x90
	System.Void .ctor(); // 0x05821f28
}

// Client.Runtime
class VehicleModuleStorage : VehicleModuleSeating
{
	VehicleModuleStorage.Storage storage; // 0x468
	EntityRef storageUnitInstance; // 0x470
	System.Void Load(BaseNetworkable.LoadInfo info); // 0x05821fa8
	System.Boolean CanBeLooted(BasePlayer player); // 0x05822024
	System.Void Spawn(); // 0x05822108
	System.Void PostServerLoad(); // 0x058222c8
	System.Void NonUserSpawn(); // 0x05822330
	System.Void DoServerDestroy(); // 0x05822390
	System.Void Save(BaseNetworkable.SaveInfo info); // 0x058223f8
	System.Void CreateStorageEntity(); // 0x058221b0
	System.Void DestroyStorageEntity(); // 0x05822478
	System.Boolean CanBeMovedNowOnVehicle(); // 0x058225e4
	System.Void .ctor(); // 0x05820efc
}

// Client.Runtime
class VehicleModuleStorage.Storage : System.Object
{
	GameObjectRef storageUnitPrefab; // 0x10
	UnityEngine.Transform storageUnitPoint; // 0x18
	System.Void .ctor(); // 0x067bcac8
}

// Client.Runtime
class VehicleModuleTaxi : VehicleModuleStorage
{
	UnityEngine.SphereCollider kickButtonCollider; // 0x480
	System.Single maxKickVelocity; // 0x488
	UnityEngine.Vector3 get_KickButtonPos(); // 0x067bcb30
	System.Boolean CanKickPassengers(BasePlayer player); // 0x067bcc58
	System.Void .ctor(); // 0x067bccf0
}

// Client.Runtime
class VisualCarWheel : CarWheel
{
	UnityEngine.Transform visualWheel; // 0x20
	UnityEngine.Transform visualWheelSteering; // 0x28
	System.Boolean visualPowerWheel; // 0x30
	UnityEngine.ParticleSystem snowFX; // 0x38
	UnityEngine.ParticleSystem sandFX; // 0x40
	UnityEngine.ParticleSystem dirtFX; // 0x48
	UnityEngine.ParticleSystem asphaltFX; // 0x50
	UnityEngine.ParticleSystem waterFX; // 0x58
	UnityEngine.ParticleSystem snowSpinFX; // 0x60
	UnityEngine.ParticleSystem sandSpinFX; // 0x68
	UnityEngine.ParticleSystem dirtSpinFX; // 0x70
	UnityEngine.ParticleSystem asphaltSpinFX; // 0x78
	System.Void .ctor(); // 0x067bcd60
}

// Client.Runtime
class VehicleChassisVisuals<T> : UnityEngine.MonoBehaviour
{
	T owner; // 0x0
	VehicleChassisVisuals.ClientWheelData<T>[] <clientWheelData>k__BackingField; // 0x0
	System.Single prevSteer; // 0x0
	System.Boolean isStopped; // 0x0
	System.Boolean isActive; // 0x0
	System.Boolean isRotateActive; // 0x0
	VehicleChassisVisuals.ClientWheelData<T>[] get_clientWheelData(); // 0x054e7844
	System.Void set_clientWheelData(VehicleChassisVisuals.ClientWheelData<T>[] value); // 0x05523a54
	System.Void Init(T owner, VehicleChassisVisuals.ClientWheelData<T>[] clientWheelData); // 0x052af1f0
	System.Void UpdateTick(System.Single dt, System.Boolean instantForced); // 0x05514150
	System.Boolean IsGrounded(); // 0x054c4760
	System.Void PreWheelUpdateTick(); // 0x055049cc
	System.Void UpdateWheelVisuals(VehicleChassisVisuals.ClientWheelData<T> wheelData, System.Boolean isOn, System.Single steer, System.Single dt); // 0x0552b14c
	System.Void PostWheelUpdateTick(System.Boolean instant, System.Boolean isCloseToCamera, System.Single steer, System.Single dt); // 0x05524290
	System.Single CalculateWheelSlip(); // 0x054a5abc
	System.Void UpdateWheelSuspensionData(VehicleChassisVisuals.ClientWheelData<T> wheelData, UnityEngine.Vector3 traceSource, System.Nullable<UnityEngine.Vector3> traceSource2); // 0x055291bc
	System.Single GetWheelRotation(VehicleChassisVisuals.ClientWheelData<T> wheelData, System.Boolean receivingDriveWheelVels, System.Single dt); // 0x054a7324
	static System.Void UpdateSteerRotation(UnityEngine.Transform t, System.Single steer, System.Int32 axis); // 0x05513754
	static System.Void ShowTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData, System.Single throttleInput); // 0x05513724
	static System.Void ShowTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData, System.Single throttleInput, System.Single speed, System.Single minSpeed); // 0x055139e8
	static System.Void ShowTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData, System.Boolean isOnWater, System.Single spinSlip, WizardGames.Soc.Procedural.TerrainConfig.GroundType groundType, System.Single throttleInput); // 0x05523de4
	static System.Void ShowTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData, System.Boolean isOnWater, System.Single spinSlip, WizardGames.Soc.Procedural.TerrainConfig.GroundType groundType, System.Single throttleInput, System.Single speed, System.Single minSpeed); // 0x05523e1c
	System.Void UpdateTickStopped(); // 0x055049cc
	System.Void StopAll(); // 0x055049cc
	static System.Void StopTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData); // 0x055049cc
	System.Void .ctor(); // 0x055049cc
	static System.Boolean <UpdateWheelSuspensionData>g__GetSuspensionHit|19_0(UnityEngine.Vector3 ts, UnityEngine.RaycastHit& hit, VehicleChassisVisuals.<>c__DisplayClass19_0<T>& Client.Runtime); // 0x054c2da8
}

// Client.Runtime
interface VehicleChassisVisuals.IClientWheelUser<T> : 
{
	
	UnityEngine.Vector3 get_Velocity(); // 0x054b1148
	System.Single get_DriveWheelVelocity(); // 0x054a5abc
	System.Single get_SteerAngle(); // 0x054a5abc
	System.Single get_MaxSteerAngle(); // 0x054a5abc
}

// Client.Runtime
class VehicleChassisVisuals.ClientWheelData<T> : System.Object
{
	VisualCarWheel wheel; // 0x0
	UnityEngine.Vector3 vehicleLocalPos; // 0x0
	UnityEngine.Vector3 restingLocalPos; // 0x0
	UnityEngine.RaycastHit hit; // 0x0
	System.Boolean isGrounded; // 0x0
	System.Boolean isOnWater; // 0x0
	System.Single spinSlip; // 0x0
	WizardGames.Soc.Procedural.TerrainConfig.GroundType groundType; // 0x0
	UnityEngine.Vector3 latestWorldPos; // 0x0
	System.Single extension; // 0x0
	System.Single prevExtension; // 0x0
	System.Single extensionPercent; // 0x0
	System.Boolean leftWheel; // 0x0
	System.Boolean get_isOnHardGround(); // 0x054c4760
	System.Void .ctor(VisualCarWheel wheel, UnityEngine.Transform vehicleTransform, System.Boolean leftWheel); // 0x0552d23c
}

// Client.Runtime
struct VehicleChassisVisuals.<>c__DisplayClass19_0<T> : System.ValueType
{
	UnityEngine.Vector3 vehicleDown; // 0x0
	System.Single wheelRadius; // 0x0
	System.Single suspensionDistance; // 0x0
	
}

// Client.Runtime
interface IEngineControllerUser : 
{
	
	System.Void OnEngineStartFailed(); // 0x055049cc
	System.Boolean MeetsEngineRequirements(); // 0x054c4760
	System.Boolean EngineIsAlive(); // 0x054c4760
}

// Client.Runtime
class VehicleEngineController<TOwner> : System.Object
{
	WizardGames.Soc.Common.Vehicle.BaseFuelComponent BaseFuelComponent; // 0x0
	TOwner owner; // 0x0
	System.Boolean isServer; // 0x0
	System.Single engineStartupTime; // 0x0
	UnityEngine.Transform waterloggedPoint; // 0x0
	BaseRustEntity.Flags engineStartingFlag; // 0x0
	System.Int64 timerId; // 0x0
	System.Int64 LastPopMessageTime; // 0x0
	VehicleEngineController.EngineState<TOwner> get_CurEngineState(); // 0x0548ba98
	System.Boolean get_IsOn(); // 0x054c4760
	System.Boolean get_IsOff(); // 0x054c4760
	System.Boolean get_IsStarting(); // 0x054c4760
	System.Boolean get_IsStartingOrOn(); // 0x054c4760
	System.Void .ctor(TOwner owner, System.Boolean isServer, System.Single engineStartupTime, GameObjectRef fuelStoragePrefab, UnityEngine.Transform waterloggedPoint, BaseRustEntity.Flags engineStartingFlag); // 0x052af1f0
	System.Void TryStartEngine(BasePlayer player); // 0x05523a54
	System.Void FinishStartingEngine(); // 0x055049cc
	System.Void StopEngine(); // 0x055049cc
	System.Boolean CheckEngineState(); // 0x054c4760
	System.Void EngineFailReason(System.Int32 reason, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0550f6d4
	System.Void PopMessage(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, System.Int32 msgId); // 0x05525b70
	System.Boolean CanRunEngine(System.Int32& reason); // 0x054dec74
	System.Boolean IsWaterlogged(); // 0x054c4760
	System.Int32 TickFuel(System.Single fuelPerSecond); // 0x0548ccf8
	System.Void CancelEngineStart(); // 0x055049cc
	System.Void <TryStartEngine>b__19_0(System.Int64 id, System.Object data, System.Boolean delete); // 0x05512cfc
}

// Client.Runtime
enum VehicleEngineController.EngineState<TOwner> : System.Enum
{
	System.Int32 value__; // 0x0
	static VehicleEngineController.EngineState<TOwner> Off = 0;
	static VehicleEngineController.EngineState<TOwner> Starting = 1;
	static VehicleEngineController.EngineState<TOwner> On = 2;
	
}

// Client.Runtime
class VehicleTerrainHandler : System.Object
{
	System.String CurGroundPhysicsMatName; // 0x10
	VehicleTerrainHandler.Surface OnSurface; // 0x18
	System.Boolean IsGrounded; // 0x1c
	System.Single RayLength; // 0x20
	System.String[] TerrainRoad; // 0x28
	static System.Single SECONDS_BETWEEN_TERRAIN_SAMPLE = 0.25;
	TimeSince timeSinceTerrainCheck; // 0x30
	BaseVehicle vehicle; // 0x38
	System.Void .ctor(BaseVehicle vehicle); // 0x067bcdd0
	System.Void FixedUpdate(); // 0x067bcfa0
	System.Void DoTerrainCheck(); // 0x067bd040
	System.Boolean GetOnRoad(System.String physicMat); // 0x067bd388
}

// Client.Runtime
enum VehicleTerrainHandler.Surface : System.Enum
{
	System.Int32 value__; // 0x10
	static VehicleTerrainHandler.Surface Default = 0;
	static VehicleTerrainHandler.Surface Road = 1;
	static VehicleTerrainHandler.Surface Snow = 2;
	static VehicleTerrainHandler.Surface Ice = 3;
	static VehicleTerrainHandler.Surface Sand = 4;
	static VehicleTerrainHandler.Surface Frictionless = 5;
	
}

// Client.Runtime
class FlashlightBeam : UnityEngine.MonoBehaviour
{
	UnityEngine.Vector2 scrollDir; // 0x30
	UnityEngine.Vector3 localEndPoint; // 0x38
	UnityEngine.LineRenderer beamRenderer; // 0x48
	System.Void .ctor(); // 0x067bd454
}

// Client.Runtime
class HitInfo : System.Object
{
	BaseRustEntity Initiator; // 0x10
	BaseRustEntity WeaponPrefab; // 0x18
	System.Boolean DoHitEffects; // 0x20
	System.Boolean DoDecals; // 0x21
	System.Boolean IsPredicting; // 0x22
	System.Boolean UseProtection; // 0x23
	System.Boolean DidHit; // 0x24
	BaseRustEntity HitEntity; // 0x28
	System.UInt32 HitBone; // 0x30
	System.UInt32 HitPart; // 0x34
	System.UInt32 HitMaterial; // 0x38
	UnityEngine.Vector3 HitPositionWorld; // 0x3c
	UnityEngine.Vector3 HitPositionLocal; // 0x48
	UnityEngine.Vector3 HitNormalWorld; // 0x54
	UnityEngine.Vector3 HitNormalLocal; // 0x60
	UnityEngine.Vector3 PointStart; // 0x6c
	UnityEngine.Vector3 PointEnd; // 0x78
	System.Int32 ProjectileID; // 0x84
	System.Int32 ProjectileHits; // 0x88
	System.Single ProjectileDistance; // 0x8c
	System.Single ProjectileIntegrity; // 0x90
	System.Single ProjectileTravelTime; // 0x94
	System.Single ProjectileTrajectoryMismatch; // 0x98
	UnityEngine.Vector3 ProjectileVelocity; // 0x9c
	UnityEngine.PhysicMaterial material; // 0xa8
	Soc.Vehicle.DamageTypeList damageTypes; // 0xb0
	System.Boolean CanGather; // 0xb8
	System.Boolean DidGather; // 0xb9
	System.Single gatherScale; // 0xbc
	
}

// Client.Runtime
class RealmedRemove : UnityEngine.MonoBehaviour
{
	UnityEngine.GameObject[] removedFromClient; // 0x30
	UnityEngine.Component[] removedComponentFromClient; // 0x38
	UnityEngine.GameObject[] removedFromServer; // 0x40
	UnityEngine.Component[] removedComponentFromServer; // 0x48
	UnityEngine.Component[] doNotRemoveFromServer; // 0x50
	UnityEngine.Component[] doNotRemoveFromClient; // 0x58
	System.Void Start(); // 0x067bd4c8
	System.Boolean ShouldDelete(UnityEngine.Component comp, System.Boolean client, System.Boolean server); // 0x067bd65c
	System.Void .ctor(); // 0x067bd74c
}

// Client.Runtime
class TriggerBanditZone : Soc.Vehicle.TriggerBase
{
	
	System.Single GetBanditZoneLevel(UnityEngine.Vector3 pos); // 0x067bd7b4
	System.Void .ctor(); // 0x067bd848
}

// Client.Runtime
class TriggerHurtNotChild : Soc.Vehicle.TriggerBase
{
	TriggerHurtNotChild.ActiveSpeedType activeSpeedType; // 0x48
	System.Single HurtTriggerMinSpeed; // 0x4c
	UnityEngine.GameObject WallCheckPoint; // 0x50
	static UnityEngine.RaycastHit[] hits; // 0x0
	System.Boolean IgnoreSleep; // 0x58
	System.Single DamagePerSecond; // 0x5c
	System.Single DamageTickRate; // 0x60
	System.Single DamageDelay; // 0x64
	WizardGames.Soc.Common.SimpleCustom.DamageType damageType; // 0x68
	System.Boolean ignoreNPC; // 0x6c
	System.Single npcMultiplier; // 0x70
	System.Boolean ignoreCorpse; // 0x74
	System.Single resourceMultiplier; // 0x78
	System.Boolean triggerHitImpacts; // 0x7c
	System.Boolean RequireUpAxis; // 0x7d
	BaseRustEntity SourceEntity; // 0x80
	WizardGames.Soc.Common.Entity.IEntity SocSourceEntity; // 0x88
	System.Boolean UseSourceEntityDamageMultiplier; // 0x90
	System.Boolean ignoreAllVehicleMounted; // 0x91
	System.Single activationDelay; // 0x94
	System.Int64 SourceEntityId; // 0x98
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.Go.BaseEntityGo,System.Single> entryTimes; // 0xa0
	TimeSince timeSinceAcivation; // 0xa8
	WizardGames.Soc.Common.Unity.Go.BaseEntityGo _entityGo; // 0xb0
	System.Int64 _timerId; // 0xb8
	System.Collections.Generic.Dictionary<System.Int64,UnityEngine.Collider> copiedContents; // 0xc0
	System.Void Init(WizardGames.Soc.Common.Entity.IEntity entity, WizardGames.Soc.Common.Unity.Go.BaseEntityGo entityGo); // 0x067bd8d4
	WizardGames.Soc.Common.Unity.Go.BaseEntityGo get_EntityGo(); // 0x067bd9ec
	System.Void CheckActive(System.Boolean isSleep, System.Single speed); // 0x067bdb54
	UnityEngine.GameObject InterestedInObject(UnityEngine.Collider obj); // 0x067bdd48
	UnityEngine.GameObject OnTriggerEnterFilter(UnityEngine.GameObject go, UnityEngine.Collider obj); // 0x067be0b0
	System.Boolean HitOther(UnityEngine.RaycastHit hit); // 0x067be5ec
	System.Void OnObjects(); // 0x067be7d4
	System.Void OnEntityEnter(WizardGames.Soc.Common.Unity.Go.BaseEntityGo ent, UnityEngine.Collider col); // 0x067bee9c
	System.Void OnEntityLeave(WizardGames.Soc.Common.Unity.Go.BaseEntityGo ent); // 0x067befe0
	System.Void OnEmpty(); // 0x067bf08c
	System.Void OnEnable(); // 0x067bf0f0
	System.Void OnDisable(); // 0x067bf160
	System.Void CancelInvoke(); // 0x067bedf4
	System.Boolean IsInterested(WizardGames.Soc.Common.Unity.Go.BaseEntityGo ent); // 0x067bf1d0
	System.Void HandleDamage(System.Int64 entityId, UnityEngine.Collider col, TriggerHurtNotChild.IHurtTriggerUser hurtTriggerUser); // 0x067bf5a4
	System.Void OnTick(); // 0x067be954
	System.Int64 GetEntityId(); // 0x067bf480
	TriggerHurtNotChild.IHurtTriggerUser GetHurtTriggerUser(); // 0x067bf954
	System.Void .ctor(); // 0x067bfa38
	static System.Void .cctor(); // 0x067bfb3c
	System.Void <OnObjects>b__35_0(System.Int64 id, System.Object data, System.Boolean delete); // 0x067bfbb0
}

// Client.Runtime
enum TriggerHurtNotChild.ActiveSpeedType : System.Enum
{
	System.Int32 value__; // 0x10
	static TriggerHurtNotChild.ActiveSpeedType Vector = 0;
	static TriggerHurtNotChild.ActiveSpeedType Scalar = 1;
	
}

// Client.Runtime
interface TriggerHurtNotChild.IHurtTriggerUser : 
{
	
	System.Void OnHurtTriggerOccupant(WizardGames.Soc.Common.Unity.Go.BaseEntityGo hurtEntity, WizardGames.Soc.Common.SimpleCustom.DamageType damageType, System.Single damageTotal); // 0x055262f0
}

// Client.Runtime
class TriggerPlayerForce : Soc.Vehicle.TriggerBase
{
	UnityEngine.BoxCollider triggerCollider; // 0x48
	System.Single pushVelocity; // 0x50
	System.Boolean requireUpAxis; // 0x54
	static System.Single HACK_DISABLE_TIME = 4;
	System.Int64 _timerId; // 0x58
	UnityEngine.GameObject InterestedInObject(UnityEngine.Collider obj); // 0x067bfc44
	System.Void OnObjects(); // 0x067bfd9c
	System.Void OnEmpty(); // 0x067c0178
	System.Void OnDisable(); // 0x067c0284
	System.Void CancelInvoke(); // 0x067c01e8
	System.Void OnEntityLeave(WizardGames.Soc.Common.Unity.Go.BaseEntityGo ent); // 0x067c02f4
	System.Void HackDisableTick(); // 0x067bfedc
	System.Void FixedUpdate(); // 0x067c0568
	UnityEngine.Vector3 GetPushVelocity(UnityEngine.GameObject obj); // 0x067c07f8
	System.Boolean IsInterested(System.Int64 entityId, WizardGames.Soc.Common.Unity.Go.BaseEntityGo& entityGo); // 0x067c0374
	System.Void .ctor(); // 0x067c0aa0
	System.Void <OnObjects>b__6_0(System.Int64 id, System.Object data, System.Boolean delete); // 0x067c0b34
}

// Client.Runtime
class TriggerSafeZone : Soc.Vehicle.TriggerBase
{
	static System.Collections.Generic.List<TriggerSafeZone> allSafeZones; // 0x0
	System.Single maxDepth; // 0x48
	System.Single maxAltitude; // 0x4c
	UnityEngine.Collider <triggerCollider>k__BackingField; // 0x50
	UnityEngine.Collider get_triggerCollider(); // 0x067c0bc8
	System.Void set_triggerCollider(UnityEngine.Collider value); // 0x067c0c2c
	System.Void Awake(); // 0x067c0cac
	System.Void OnEnable(); // 0x067c0d88
	System.Void OnDisable(); // 0x067c0e90
	System.Boolean PassesHeightChecks(UnityEngine.Vector3 entPos); // 0x067c0f50
	System.Single GetSafeLevel(UnityEngine.Vector3 pos); // 0x067c1044
	System.Void .ctor(); // 0x067c10f8
	static System.Void .cctor(); // 0x067c1190
}

// Client.Runtime
class VehicleLiftDetectTrigger : Soc.Vehicle.TriggerBase
{
	
	WizardGames.Soc.Common.Unity.Go.BaseEntityGo GetEntityGo(UnityEngine.Collider col); // 0x067c1228
	UnityEngine.GameObject InterestedInObject(UnityEngine.Collider collider); // 0x067c13c4
	System.Void .ctor(); // 0x067c14f4
}

// Client.Runtime
class VehicleLiftOccupantTrigger : Soc.Vehicle.TriggerBase
{
	WizardGames.Soc.Common.Unity.Go.BaseModularCarGo <carOccupant>k__BackingField; // 0x48
	System.Action OnEntityLeaveHandler; // 0x50
	System.Single POS_SNAP_SPEED; // 0x58
	System.Single ROT_SNAP_SPEED; // 0x5c
	WizardGames.Soc.Common.Unity.Go.BaseModularCarGo get_carOccupant(); // 0x067c1580
	System.Void set_carOccupant(WizardGames.Soc.Common.Unity.Go.BaseModularCarGo value); // 0x067c15e4
	System.Void OnDisable(); // 0x067c1664
	UnityEngine.GameObject InterestedInObject(UnityEngine.Collider obj); // 0x067c1790
	System.Void OnEntityEnter(WizardGames.Soc.Common.Unity.Go.BaseEntityGo ent, UnityEngine.Collider col); // 0x067c1914
	System.Void OnEntityLeave(WizardGames.Soc.Common.Unity.Go.BaseEntityGo ent); // 0x067c1aa8
	System.Void RemoveColliderByEntityGo(WizardGames.Soc.Common.Unity.Go.BaseEntityGo entityGo); // 0x067c1e40
	System.Void .ctor(); // 0x067c1f90
}

// Client.Runtime
enum BUTTON : System.Enum
{
	System.Int32 value__; // 0x10
	static BUTTON FORWARD = 2;
	static BUTTON BACKWARD = 4;
	static BUTTON LEFT = 8;
	static BUTTON RIGHT = 16;
	static BUTTON JUMP = 32;
	static BUTTON DUCK = 64;
	static BUTTON SPRINT = 128;
	static BUTTON USE = 256;
	static BUTTON FIRE_PRIMARY = 1024;
	static BUTTON FIRE_SECONDARY = 2048;
	static BUTTON RELOAD = 8192;
	static BUTTON FIRE_THIRD = 134217728;
	
}

// Client.Runtime
class InputState : System.Object
{
	Soc.Vehicle.InputMessage current; // 0x10
	Soc.Vehicle.InputMessage previous; // 0x18
	System.Int32 SwallowedButtons; // 0x20
	System.Boolean IsDown(BUTTON btn); // 0x067c2028
	System.Boolean WasDown(BUTTON btn); // 0x067c20c4
}

// Client.Runtime
class Item : System.Object
{
	System.Single condition; // 0x10
	System.Single maxCondition; // 0x14
	Rust.Modular.ItemModVehicleModule info; // 0x18
	System.Int32 position; // 0x20
	System.Action<Item> OnDirty; // 0x28
	
}

// Client.Runtime
class LineRendererActivate : UnityEngine.MonoBehaviour
{
	
	System.Void OnEnable(); // 0x067c2154
	System.Void .ctor(); // 0x067c21e4
}

// Client.Runtime
class TerrainCollisionProxy : UnityEngine.MonoBehaviour
{
	UnityEngine.WheelCollider[] colliders; // 0x30
	System.Void .ctor(); // 0x067c224c
}

// Client.Runtime
class SedanWheelSmoke : UnityEngine.MonoBehaviour
{
	UnityEngine.ParticleSystem[] tireSmoke; // 0x30
	UnityEngine.ParticleSystem[] tireWaterSplash; // 0x38
	UnityEngine.ParticleSystem[] tireWaterSplash_Extra; // 0x40
	System.Boolean[] wheelTouching; // 0x48
	System.Void .ctor(); // 0x067c22b4
}

// Client.Runtime
class BuildingGrade : UnityEngine.ScriptableObject
{
	BuildingGrade.Enum type; // 0x18
	System.Single baseHealth; // 0x1c
	UnityEngine.PhysicMaterial physicMaterial; // 0x20
	ProtectionProperties damageProtecton; // 0x28
	System.Void .ctor(); // 0x067c231c
}

// Client.Runtime
enum BuildingGrade.Enum : System.Enum
{
	System.Int32 value__; // 0x10
	static BuildingGrade.Enum None = -1;
	static BuildingGrade.Enum Twigs = 0;
	static BuildingGrade.Enum Wood = 1;
	static BuildingGrade.Enum Stone = 2;
	static BuildingGrade.Enum Metal = 3;
	static BuildingGrade.Enum TopTier = 4;
	static BuildingGrade.Enum Count = 5;
	
}

// Client.Runtime
class BufferList<T> : System.Object, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
{
	System.Int32 count; // 0x0
	T[] buffer; // 0x0
	System.Int32 get_Count(); // 0x0548ba98
	T[] get_Buffer(); // 0x054e7844
	T get_Item(System.Int32 index); // 0x052af1f0
	System.Void set_Item(System.Int32 index, T value); // 0x052af1f0
	System.Void .ctor(System.Int32 capacity); // 0x055056e8
	System.Void Add(T element); // 0x052af1f0
	System.Void RemoveUnordered(System.Int32 index); // 0x055056e8
	System.Void Clear(); // 0x055049cc
	BufferList.Enumerator<T> GetEnumerator(); // 0x052af1f0
	System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator(); // 0x054e7844
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x054e7844
}

// Client.Runtime
struct BufferList.Enumerator<T> : System.ValueType, System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
{
	BufferList<T> list; // 0x0
	System.Int32 index; // 0x0
	System.Void .ctor(BufferList<T> list); // 0x05523a54
	System.Boolean MoveNext(); // 0x054c4760
	System.Void Reset(); // 0x055049cc
	T get_Current(); // 0x052af1f0
	System.Object System.Collections.IEnumerator.get_Current(); // 0x054e7844
	System.Void Dispose(); // 0x055049cc
}

// Client.Runtime
class ListDictionary<TKey,TVal> : System.Object, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TVal>>, System.Collections.IEnumerable
{
	System.Collections.Generic.Dictionary<TKey,System.Int32> key2idx; // 0x0
	System.Collections.Generic.Dictionary<System.Int32,TKey> idx2key; // 0x0
	BufferList<TKey> keys; // 0x0
	BufferList<TVal> vals; // 0x0
	System.Void .ctor(); // 0x055049cc
	System.Void .ctor(System.Int32 capacity); // 0x055056e8
	System.Void Add(TKey key, TVal val); // 0x052af1f0
	System.Boolean Contains(TKey key); // 0x052af1f0
	System.Boolean Remove(TKey key); // 0x052af1f0
	System.Void Remove(System.Int32 idx_remove, TKey key_remove); // 0x052af1f0
	System.Boolean TryGetValue(TKey key, TVal& val); // 0x052af1f0
	System.Collections.Generic.KeyValuePair<TKey,TVal> GetByIndex(System.Int32 idx); // 0x052af1f0
	TVal get_Item(TKey key); // 0x052af1f0
	BufferList<TVal> get_Values(); // 0x054e7844
	System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TVal>> GetEnumerator(); // 0x054e7844
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x054e7844
}

// Client.Runtime
class ListDictionary.<GetEnumerator>d__23<TKey,TVal> : System.Object, System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TVal>>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x0
	System.Collections.Generic.KeyValuePair<TKey,TVal> <>2__current; // 0x0
	ListDictionary<TKey,TVal> <>4__this; // 0x0
	System.Int32 <i>5__2; // 0x0
	System.Void .ctor(System.Int32 <>1__state); // 0x055056e8
	System.Void System.IDisposable.Dispose(); // 0x055049cc
	System.Boolean MoveNext(); // 0x054c4760
	System.Collections.Generic.KeyValuePair<TKey,TVal> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TVal>>.get_Current(); // 0x052af1f0
	System.Void System.Collections.IEnumerator.Reset(); // 0x055049cc
	System.Object System.Collections.IEnumerator.get_Current(); // 0x054e7844
}

// Client.Runtime
class ListHashSet<T> : System.Object, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>
{
	System.Collections.Generic.Dictionary<T,System.Int32> val2idx; // 0x0
	System.Collections.Generic.Dictionary<System.Int32,T> idx2val; // 0x0
	BufferList<T> vals; // 0x0
	System.Void .ctor(System.Int32 capacity); // 0x055056e8
	System.Void Add(T val); // 0x052af1f0
	System.Boolean Contains(T val); // 0x052af1f0
	System.Boolean Remove(T val); // 0x052af1f0
	System.Void RemoveAt(System.Int32 idx); // 0x055056e8
	System.Int32 IndexOf(T item); // 0x052af1f0
	System.Void Insert(System.Int32 index, T item); // 0x052af1f0
	System.Void Clear(); // 0x055049cc
	System.Void Remove(System.Int32 idx_remove, T val_remove); // 0x052af1f0
	System.Void CopyTo(T[] array, System.Int32 arrayIndex); // 0x05525b70
	BufferList<T> get_Values(); // 0x054e7844
	System.Int32 get_Count(); // 0x0548ba98
	System.Boolean get_IsReadOnly(); // 0x054c4760
	T get_Item(System.Int32 index); // 0x052af1f0
	System.Void set_Item(System.Int32 index, T value); // 0x052af1f0
	ListHashSet.Enumerator<T> GetEnumerator(); // 0x052af1f0
	System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator(); // 0x054e7844
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x054e7844
}

// Client.Runtime
struct ListHashSet.Enumerator<T> : System.ValueType, System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
{
	BufferList<T> list; // 0x0
	System.Int32 index; // 0x0
	System.Void .ctor(ListHashSet<T> set); // 0x05523a54
	System.Boolean MoveNext(); // 0x054c4760
	System.Void Reset(); // 0x055049cc
	T get_Current(); // 0x052af1f0
	System.Object System.Collections.IEnumerator.get_Current(); // 0x054e7844
	System.Void Dispose(); // 0x055049cc
}

// Client.Runtime
class ProtectionProperties : UnityEngine.ScriptableObject
{
	System.String comments; // 0x18
	System.Single density; // 0x20
	System.Single[] amounts; // 0x28
	System.Void OnValidate(); // 0x067c2384
	System.Void Clear(); // 0x067c24b4
	System.Void Add(System.Single amount); // 0x067c2550
	System.Void Add(Soc.Vehicle.DamageType index, System.Single amount); // 0x067c2608
	System.Void Add(ProtectionProperties other, System.Single scale); // 0x067c26bc
	System.Void Multiply(System.Single multiplier); // 0x067c27b8
	System.Void Multiply(Soc.Vehicle.DamageType index, System.Single multiplier); // 0x067c2870
	System.Void Scale(Soc.Vehicle.DamageTypeList damageList, System.Single ProtectionAmount); // 0x067c2924
	System.Single Get(Soc.Vehicle.DamageType damageType); // 0x067c2a34
	System.Void .ctor(); // 0x067c2acc
}

// Client.Runtime
class RecoilProperties : UnityEngine.ScriptableObject
{
	System.Single recoilYawMin; // 0x18
	System.Single recoilYawMax; // 0x1c
	System.Single recoilPitchMin; // 0x20
	System.Single recoilPitchMax; // 0x24
	System.Single timeToTakeMin; // 0x28
	System.Single timeToTakeMax; // 0x2c
	System.Single ADSScale; // 0x30
	System.Single movementPenalty; // 0x34
	System.Single clampPitch; // 0x38
	UnityEngine.AnimationCurve pitchCurve; // 0x40
	UnityEngine.AnimationCurve yawCurve; // 0x48
	System.Boolean useCurves; // 0x50
	System.Boolean curvesAsScalar; // 0x51
	System.Int32 shotsUntilMax; // 0x54
	System.Single maxRecoilRadius; // 0x58
	System.Boolean overrideAimconeWithCurve; // 0x5c
	System.Single aimconeCurveScale; // 0x60
	UnityEngine.AnimationCurve aimconeCurve; // 0x68
	UnityEngine.AnimationCurve aimconeProbabilityCurve; // 0x70
	RecoilProperties newRecoilOverride; // 0x78
	RecoilProperties GetRecoil(); // 0x067c2b6c
	System.Void .ctor(); // 0x067c2c10
}

// Client.Runtime
class SkinReplacement : System.Object
{
	SkinReplacement.SkinType skinReplacementType; // 0x10
	GameObjectRef targetReplacement; // 0x18
	System.Void .ctor(); // 0x067c3024
}

// Client.Runtime
enum SkinReplacement.SkinType : System.Enum
{
	System.Int32 value__; // 0x10
	static SkinReplacement.SkinType NONE = 0;
	static SkinReplacement.SkinType Hands = 1;
	static SkinReplacement.SkinType Head = 2;
	static SkinReplacement.SkinType Feet = 3;
	static SkinReplacement.SkinType Torso = 4;
	static SkinReplacement.SkinType Legs = 5;
	
}

// Client.Runtime
class SteamDLCItem : UnityEngine.ScriptableObject
{
	System.Int32 id; // 0x18
	System.Int32 dlcAppID; // 0x1c
	System.Boolean bypassLicenseCheck; // 0x20
	System.Boolean HasLicense(System.UInt64 steamid); // 0x067c308c
	System.Boolean CanUse(BasePlayer player); // 0x067c3124
	System.Void .ctor(); // 0x067c31dc
}

// Client.Runtime
class SteamInventoryCategory : UnityEngine.ScriptableObject
{
	System.Boolean canBeSoldToOtherUsers; // 0x18
	System.Boolean canBeTradedWithOtherUsers; // 0x19
	System.Boolean isCommodity; // 0x1a
	SteamInventoryCategory.Price price; // 0x1c
	SteamInventoryCategory.DropChance dropChance; // 0x20
	System.Boolean CanBeInCrates; // 0x24
	System.Void .ctor(); // 0x067c3244
}

// Client.Runtime
enum SteamInventoryCategory.Price : System.Enum
{
	System.Int32 value__; // 0x10
	static SteamInventoryCategory.Price CannotBuy = 0;
	static SteamInventoryCategory.Price VLV25 = 1;
	static SteamInventoryCategory.Price VLV50 = 2;
	static SteamInventoryCategory.Price VLV75 = 3;
	static SteamInventoryCategory.Price VLV100 = 4;
	static SteamInventoryCategory.Price VLV150 = 5;
	static SteamInventoryCategory.Price VLV200 = 6;
	static SteamInventoryCategory.Price VLV250 = 7;
	static SteamInventoryCategory.Price VLV300 = 8;
	static SteamInventoryCategory.Price VLV350 = 9;
	static SteamInventoryCategory.Price VLV400 = 10;
	static SteamInventoryCategory.Price VLV450 = 11;
	static SteamInventoryCategory.Price VLV500 = 12;
	static SteamInventoryCategory.Price VLV550 = 13;
	static SteamInventoryCategory.Price VLV600 = 14;
	static SteamInventoryCategory.Price VLV650 = 15;
	static SteamInventoryCategory.Price VLV700 = 16;
	static SteamInventoryCategory.Price VLV750 = 17;
	static SteamInventoryCategory.Price VLV800 = 18;
	static SteamInventoryCategory.Price VLV850 = 19;
	static SteamInventoryCategory.Price VLV900 = 20;
	static SteamInventoryCategory.Price VLV950 = 21;
	static SteamInventoryCategory.Price VLV1000 = 22;
	static SteamInventoryCategory.Price VLV1100 = 23;
	static SteamInventoryCategory.Price VLV1200 = 24;
	static SteamInventoryCategory.Price VLV1300 = 25;
	static SteamInventoryCategory.Price VLV1400 = 26;
	static SteamInventoryCategory.Price VLV1500 = 27;
	static SteamInventoryCategory.Price VLV1600 = 28;
	static SteamInventoryCategory.Price VLV1700 = 29;
	static SteamInventoryCategory.Price VLV1800 = 30;
	static SteamInventoryCategory.Price VLV1900 = 31;
	static SteamInventoryCategory.Price VLV2000 = 32;
	static SteamInventoryCategory.Price VLV2500 = 33;
	static SteamInventoryCategory.Price VLV3000 = 34;
	static SteamInventoryCategory.Price VLV3500 = 35;
	static SteamInventoryCategory.Price VLV4000 = 36;
	static SteamInventoryCategory.Price VLV4500 = 37;
	static SteamInventoryCategory.Price VLV5000 = 38;
	static SteamInventoryCategory.Price VLV6000 = 39;
	static SteamInventoryCategory.Price VLV7000 = 40;
	static SteamInventoryCategory.Price VLV8000 = 41;
	static SteamInventoryCategory.Price VLV9000 = 42;
	static SteamInventoryCategory.Price VLV10000 = 43;
	
}

// Client.Runtime
enum SteamInventoryCategory.DropChance : System.Enum
{
	System.Int32 value__; // 0x10
	static SteamInventoryCategory.DropChance NeverDrop = 0;
	static SteamInventoryCategory.DropChance VeryRare = 1;
	static SteamInventoryCategory.DropChance Rare = 2;
	static SteamInventoryCategory.DropChance Common = 3;
	static SteamInventoryCategory.DropChance VeryCommon = 4;
	static SteamInventoryCategory.DropChance ExtremelyRare = 5;
	
}

// Client.Runtime
class SteamInventoryItem : UnityEngine.ScriptableObject
{
	System.Int32 id; // 0x18
	UnityEngine.Sprite icon; // 0x20
	SteamInventoryItem.Category category; // 0x28
	SteamInventoryItem.SubCategory subcategory; // 0x2c
	SteamInventoryCategory steamCategory; // 0x30
	System.Boolean isLimitedTimeOffer; // 0x38
	System.Boolean PreventBreakingDown; // 0x39
	System.String itemname; // 0x40
	System.UInt64 workshopID; // 0x48
	SteamDLCItem DlcItem; // 0x50
	System.Boolean forceCraftableItemDesc; // 0x58
	System.Boolean HasUnlocked(System.UInt64 playerId); // 0x067c32b4
	System.Void .ctor(); // 0x067c3388
}

// Client.Runtime
enum SteamInventoryItem.Category : System.Enum
{
	System.Int32 value__; // 0x10
	static SteamInventoryItem.Category None = 0;
	static SteamInventoryItem.Category Clothing = 1;
	static SteamInventoryItem.Category Weapon = 2;
	static SteamInventoryItem.Category Decoration = 3;
	static SteamInventoryItem.Category Crate = 4;
	static SteamInventoryItem.Category Resource = 5;
	
}

// Client.Runtime
enum SteamInventoryItem.SubCategory : System.Enum
{
	System.Int32 value__; // 0x10
	static SteamInventoryItem.SubCategory None = 0;
	static SteamInventoryItem.SubCategory Shirt = 1;
	static SteamInventoryItem.SubCategory Pants = 2;
	static SteamInventoryItem.SubCategory Jacket = 3;
	static SteamInventoryItem.SubCategory Hat = 4;
	static SteamInventoryItem.SubCategory Mask = 5;
	static SteamInventoryItem.SubCategory Footwear = 6;
	static SteamInventoryItem.SubCategory Weapon = 7;
	static SteamInventoryItem.SubCategory Misc = 8;
	static SteamInventoryItem.SubCategory Crate = 9;
	static SteamInventoryItem.SubCategory Resource = 10;
	static SteamInventoryItem.SubCategory CrateUncraftable = 11;
	
}

// Client.Runtime
class StringPool : System.Object
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.Dictionary<System.UInt32,System.String> toString; // 0x8
	static System.Boolean initialized; // 0x10
	static System.UInt32 closest; // 0x14
	static System.Void Init(); // 0x067c33f8
	static System.String Get(System.UInt32 i); // 0x067c3478
	static System.UInt32 Get(System.String str); // 0x067c3660
	static System.Void .cctor(); // 0x067c36e8
}

// Client.Runtime
class Underwear : UnityEngine.ScriptableObject
{
	System.String shortname; // 0x18
	UnityEngine.Sprite icon; // 0x20
	UnityEngine.Sprite iconFemale; // 0x28
	SkinReplacement[] replacementsMale; // 0x30
	SkinReplacement[] replacementsFemale; // 0x38
	SteamInventoryItem steamItem; // 0x40
	SteamDLCItem steamDLC; // 0x48
	System.Boolean adminOnly; // 0x50
	System.UInt32 GetID(); // 0x067c37cc
	System.Boolean HasMaleParts(); // 0x067c3858
	System.Boolean HasFemaleParts(); // 0x067c38d0
	System.Boolean ValidForPlayer(BasePlayer player); // 0x067c3948
	static System.Boolean IsFemale(BasePlayer player); // 0x067c3a18
	static System.Boolean Validate(Underwear underwear, BasePlayer player); // 0x067c3ae0
	System.Void .ctor(); // 0x067c3b78
}

// Client.Runtime
class UnderwearManifest : UnityEngine.ScriptableObject
{
	static SocLogger logger; // 0x0
	static UnderwearManifest instance; // 0x8
	System.Collections.Generic.List<Underwear> underwears; // 0x18
	static UnderwearManifest Get(); // 0x067c3c04
	System.Void PrintManifest(); // 0x067c3d44
	Underwear GetUnderwear(System.UInt32 id); // 0x067c4024
	System.Void .ctor(); // 0x067c41c0
	static System.Void .cctor(); // 0x067c4228
}

// Client.Runtime
class GameObjectRef : ResourceRef<UnityEngine.GameObject>
{
	UnityEngine.GameObject Prefab; // 0x20
	System.String path; // 0x28
	System.Void .ctor(); // 0x067c42fc
}

// Client.Runtime
class ResourceRef<T> : System.Object
{
	System.String guid; // 0x0
	T _cachedObject; // 0x0
	System.Boolean get_isValid(); // 0x054c4760
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class TestMono_SocketFreeAutoAbsorb : UnityEngine.MonoBehaviour, UnityEngine.ISerializationCallbackReceiver
{
	static System.Boolean EnableFunc; // 0x0
	static System.Single AbsorbWidth; // 0x4
	static System.Single AbsorbLength; // 0x8
	System.Boolean enableFunc; // 0x30
	System.Single absorbWidth; // 0x34
	System.Single absorbLength; // 0x38
	System.Void OnAfterDeserialize(); // 0x067c4378
	System.Void OnBeforeSerialize(); // 0x067c4414
	System.Void .ctor(); // 0x067c44b0
	static System.Void .cctor(); // 0x067c4524
}

// Client.Runtime
class TestMono_SocketModAttraction : UnityEngine.MonoBehaviour, UnityEngine.ISerializationCallbackReceiver
{
	static System.Boolean EnableFunc; // 0x0
	static System.Single LockDistanceMul; // 0x4
	static System.Single LockAttractionBase; // 0x8
	static System.Single LockSwitchDistanceDelta; // 0xc
	static System.Single ExterHighSlideSens; // 0x10
	System.Boolean enableFunc; // 0x30
	System.Single lockDistanceMul; // 0x34
	System.Single lockAttractionBase; // 0x38
	System.Single lockSwitchDistanceDelta; // 0x3c
	System.Single exterHighSlideSens; // 0x40
	System.Void .ctor(); // 0x067c4578
	System.Void OnAfterDeserialize(); // 0x067c4760
	System.Void OnBeforeSerialize(); // 0x067c47fc
	static System.Void .cctor(); // 0x067c4898
}

// Client.Runtime
class TestMono_SolarPanelLight : UnityEngine.MonoBehaviour, UnityEngine.ISerializationCallbackReceiver
{
	System.Single Hour; // 0x30
	UnityEngine.Vector3 SunDirectProgram; // 0x34
	UnityEngine.Vector3 SunDirectGameObject; // 0x40
	UnityEngine.GameObject SolarPanel; // 0x50
	UnityEngine.Vector3 PanelNormal; // 0x58
	UnityEngine.Vector3 SunDirect; // 0x64
	System.Single PowerMax; // 0x70
	System.Single PowerDot; // 0x74
	System.Single PowerMul; // 0x78
	System.Int32 PowerNow; // 0x7c
	System.Void OnAfterDeserialize(); // 0x067c48ec
	System.Void OnBeforeSerialize(); // 0x067c494c
	UnityEngine.Vector3 UpdateCelestials(); // 0x067c4d0c
	UnityEngine.Vector3 OrbitalToLocal(System.Single theta, System.Single phi); // 0x067c4fc0
	System.Void .ctor(); // 0x067c507c
}

// Client.Runtime
class CollectionEx : System.Object
{
	
	static System.Boolean IsNullOrEmpty<T>(System.Collections.Generic.ICollection<T> collection); // 0x052af1f0
	static System.Boolean IsEmpty<T>(System.Collections.Generic.ICollection<T> collection); // 0x052af1f0
}

// Client.Runtime
class SerializableDictionary<TKey,TValue> : System.Object, System.Collections.Generic.IDictionary<TKey,TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>, System.Collections.IEnumerable, System.Collections.IDictionary, System.Collections.ICollection, UnityEngine.ISerializationCallbackReceiver, System.Runtime.Serialization.IDeserializationCallback
{
	System.Collections.Generic.Dictionary<TKey,TValue> m_dict; // 0x0
	TKey[] m_keys; // 0x0
	TValue[] m_values; // 0x0
	System.Void .ctor(); // 0x055049cc
	System.Void .ctor(System.Collections.Generic.IEqualityComparer<TKey> comparer); // 0x05523a54
	System.Void OnAfterDeserialize(); // 0x055049cc
	System.Void OnBeforeSerialize(); // 0x055049cc
	System.Collections.Generic.ICollection<TKey> get_Keys(); // 0x054e7844
	System.Collections.Generic.ICollection<TValue> get_Values(); // 0x054e7844
	System.Int32 get_Count(); // 0x0548ba98
	System.Boolean get_IsReadOnly(); // 0x054c4760
	TValue get_Item(TKey key); // 0x052af1f0
	System.Void set_Item(TKey key, TValue value); // 0x052af1f0
	System.Void Add(TKey key, TValue value); // 0x052af1f0
	System.Boolean ContainsKey(TKey key); // 0x052af1f0
	System.Boolean Remove(TKey key); // 0x052af1f0
	System.Boolean TryGetValue(TKey key, TValue& value); // 0x052af1f0
	System.Void Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item); // 0x052af1f0
	System.Void Clear(); // 0x055049cc
	System.Boolean Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item); // 0x052af1f0
	System.Void CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, System.Int32 arrayIndex); // 0x05525b70
	System.Boolean Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item); // 0x052af1f0
	System.Collections.Generic.Dictionary.Enumerator<TKey,TValue> GetEnumerator(); // 0x052af1f0
	System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(); // 0x054e7844
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x054e7844
	System.Boolean get_IsFixedSize(); // 0x054c4760
	System.Collections.ICollection System.Collections.IDictionary.get_Keys(); // 0x054e7844
	System.Collections.ICollection System.Collections.IDictionary.get_Values(); // 0x054e7844
	System.Boolean get_IsSynchronized(); // 0x054c4760
	System.Object get_SyncRoot(); // 0x054e7844
	System.Object get_Item(System.Object key); // 0x054f9d14
	System.Void set_Item(System.Object key, System.Object value); // 0x0552af00
	System.Void System.Collections.IDictionary.Add(System.Object key, System.Object value); // 0x0552af00
	System.Boolean Contains(System.Object key); // 0x054dec74
	System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator(); // 0x054e7844
	System.Void Remove(System.Object key); // 0x05523a54
	System.Void CopyTo(System.Array array, System.Int32 index); // 0x05525b70
	System.Void OnDeserialization(System.Object sender); // 0x05523a54
}

// Client.Runtime
class CommonDeployConfig : UnityEngine.MonoBehaviour
{
	UnityEngine.GameObject meshRoot; // 0x30
	System.Void .ctor(); // 0x067c50ec
}

// Client.Runtime
class IgnorePrebuildShader : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x067c5154
}

// Client.Runtime
struct Line : System.ValueType
{
	UnityEngine.Vector3 point0; // 0x10
	UnityEngine.Vector3 point1; // 0x1c
	System.Void .ctor(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1); // 0x067c51bc
}

// Client.Runtime
class PartGoConfigDebug : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.IGoConfig config; // 0x30
	System.Int64 entityId; // 0x38
	System.Collections.Generic.List<PartGoConfigDebug_ToggleItem<System.Int32>> sockets; // 0x40
	System.Collections.Generic.List<PartGoConfigDebug_ToggleItem<System.Int32>> socketMods; // 0x48
	System.Collections.Generic.List<PartGoConfigDebug_ToggleItem<System.Int32>> deployVolumes; // 0x50
	System.Collections.Generic.List<PartGoConfigDebug_ToggleItem<System.String>> namedPoints; // 0x58
	System.Collections.Generic.List<PartGoConfigDebug_ToggleItem<System.Int32>> virtualPartPrevent; // 0x60
	PartGoConfigDebug_ToggleItem<System.Int32> ioConfig; // 0x68
	System.Void OnDrawGizmos(); // 0x067c527c
	System.Void Draw(); // 0x067c52e0
	System.Void Test(); // 0x067c6174
	WizardGames.Soc.Common.Entity.PartEntity GetPartEntity(); // 0x067c6274
	System.Void BindCurrentPart(); // 0x067c63cc
	System.Void BindSockets(); // 0x067c6604
	System.Void DrawGizmos_Sockets(); // 0x067c536c
	System.Void BindSocketMods(); // 0x067c68a0
	System.Void DrawGizmos_SocketMods(); // 0x067c55ec
	System.Void BindDeployVolume(); // 0x067c6b68
	System.Void DrawGizmos_DeployVolume(); // 0x067c586c
	System.Void BindNamedPoint(); // 0x067c6e30
	System.Void DrawGizmos_NamedPoint(); // 0x067c5aec
	System.Void BindVirtualPartPrevent(); // 0x067c6edc
	System.Void DrawGizmos_VirtualPartPrevent(); // 0x067c5b4c
	System.Void BindIOConfig(); // 0x067c73f4
	System.Void DrawGizmos_IOConfig(); // 0x067c600c
	System.Void .ctor(); // 0x067c758c
	static System.Void .cctor(); // 0x067c7768
}

// Client.Runtime
class PartGoConfigDebug_ToggleItem<T> : System.Object
{
	System.Boolean Enabled; // 0x0
	System.String Label; // 0x0
	T id; // 0x0
	System.Void SetData(T getterId, System.String name); // 0x052af1f0
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class TextMeshLanguageSetting : UnityEngine.MonoBehaviour
{
	System.Int32 languageKey; // 0x30
	System.Boolean isBold; // 0x34
	System.Void Start(); // 0x067c783c
	System.Void .ctor(); // 0x067c7a04
}

// Client.Runtime
class SocInputSystemControl : System.Object, UnityEngine.InputSystem.IInputActionCollection2, UnityEngine.InputSystem.IInputActionCollection, System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputAction>, System.Collections.IEnumerable, System.IDisposable
{
	static SocLogger logger; // 0x0
	UnityEngine.InputSystem.InputActionAsset m_Asset; // 0x10
	UnityEngine.InputSystem.InputActionAsset get_asset(); // 0x067c7a6c
	System.Void .ctor(); // 0x067c7ad0
	System.Void Init(); // 0x067c7b38
	System.Void Dispose(); // 0x067c7e10
	System.Nullable<UnityEngine.InputSystem.InputBinding> get_bindingMask(); // 0x067c7eb4
	System.Void set_bindingMask(System.Nullable<UnityEngine.InputSystem.InputBinding> value); // 0x067c7f84
	System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> get_devices(); // 0x067c8080
	System.Void set_devices(System.Nullable<UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputDevice>> value); // 0x067c814c
	UnityEngine.InputSystem.Utilities.ReadOnlyArray<UnityEngine.InputSystem.InputControlScheme> get_controlSchemes(); // 0x067c823c
	System.Boolean Contains(UnityEngine.InputSystem.InputAction action); // 0x067c82f0
	System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputAction> GetEnumerator(); // 0x067c83bc
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x067c8470
	System.Void Enable(); // 0x067c84d4
	System.Void Disable(); // 0x067c8588
	System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBinding> get_bindings(); // 0x067c863c
	UnityEngine.InputSystem.InputAction FindAction(System.String actionNameOrId, System.Boolean throwIfNotFound); // 0x067c86f0
	System.Int32 FindBinding(UnityEngine.InputSystem.InputBinding bindingMask, UnityEngine.InputSystem.InputAction& action); // 0x067c87c8
	UnityEngine.InputSystem.InputActionMap get_InputActionMap(); // 0x067c88d0
	static System.Void .cctor(); // 0x067c895c
}

// Client.Runtime
class SocWeaponRecoilCurve : UnityEngine.ScriptableObject
{
	UnityEngine.AnimationCurve WeaponRecoilCurve; // 0x18
	System.Void .ctor(); // 0x067c8a30
}

// Client.Runtime
class Dig_Dubug : UnityEngine.MonoBehaviour
{
	System.Single maxSpeed; // 0x30
	System.Single time; // 0x34
	System.Void .ctor(); // 0x067c8a98
}

// Client.Runtime
enum DevicePermissionType : System.Enum
{
	System.Int32 value__; // 0x10
	static DevicePermissionType Microphone = 0;
	static DevicePermissionType WebCam = 1;
	static DevicePermissionType Notification = 2;
	
}

// Client.Runtime
class DevicePermissionMgr : System.Object
{
	static DevicePermissionMgr inst; // 0x0
	System.Threading.SynchronizationContext _mainThread; // 0x10
	static SocLogger logger; // 0x8
	System.Action<System.Boolean> m_RequestPermissionCallback; // 0x18
	System.Action<System.Boolean> m_RequestPermissionStateCallback; // 0x20
	static System.Int32 Notification_Permission_Version; // 0x10
	UnityEngine.Android.PermissionCallbacks m_PermissionCallbacks; // 0x28
	System.Boolean m_IsGetAllPermission; // 0x30
	System.Collections.Generic.List<System.String> m_PermissionDeniedAndDontAskAgainList; // 0x38
	static DevicePermissionMgr GetInstance(); // 0x067c8b0c
	System.Void .ctor(); // 0x067c8bec
	System.Void InitPermissionCallbacks(); // 0x067c8cb8
	System.Void FirstRequestUserPermissions(); // 0x067c8e4c
	System.String TransferUserPermissions(DevicePermissionType permission); // 0x067c8f28
	System.Boolean HasUserAuthorizedPermission(DevicePermissionType permission); // 0x067c9018
	System.Void HasNotificationPermission(System.Action<System.Boolean> requestPermissionCallback); // 0x067c909c
	System.Int32 GetAndroidApiLevel(); // 0x067c91c8
	System.Void TryRequestUserPermission(DevicePermissionType permission, System.Action<System.Boolean> requestPermissionCallback); // 0x067c9398
	System.Void OnPermissionDenied(System.String permission); // 0x067c94c4
	System.Void OnPermissionGranted(System.String permission); // 0x067c965c
	System.Void OnPermissionDeniedAndDontAskAgain(System.String permission); // 0x067c987c
	static System.Void .cctor(); // 0x067c9a60
}

// Client.Runtime
class LightComData : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	System.Int32 lightLayer; // 0x30
	System.Int32 lightSubLayer; // 0x34
	UnityEngine.Light lightCom; // 0x38
	System.Single distance; // 0x40
	System.Int32 priority; // 0x44
	UnityEngine.LightShadows defaultShadowType; // 0x48
	System.Boolean ignoreHeight; // 0x4c
	System.Boolean mIsActive; // 0x4d
	System.Single mInitIntensityVal; // 0x50
	System.Single mInitEmissionRange; // 0x54
	LightComData.ELightStatus mCurLightStatus; // 0x58
	LightComData.ELightAnimStatus mCurLightAnimStatus; // 0x5c
	System.Single mIntensityTransitionTime; // 0x60
	System.Single mTransitionStartVal; // 0x64
	System.Single mTransitionTime; // 0x68
	System.Boolean mIsRangeDirty; // 0x6c
	UnityEngine.Vector3 mPrePos; // 0x70
	System.Int32 shadowDeviceLevel; // 0x7c
	System.Int32 showShadowLayer; // 0x80
	UnityEngine.Vector3 cacheTransformPos; // 0x84
	System.Int32 cacheTransPosFrame; // 0x90
	System.Boolean isStatic; // 0x94
	UnityEngine.Vector3 get_CacheTransformPosition(); // 0x067c9b44
	System.Void set_CacheTransformPosition(UnityEngine.Vector3 value); // 0x067c9bec
	System.Int32 get_ShowShadowLayer(); // 0x067c9c7c
	System.Void set_ShowShadowLayer(System.Int32 value); // 0x067c9ce0
	System.Int32 GetShadowDeviceLevel(); // 0x067c9d58
	System.Void SetShadowDeviceLevel(System.Int32 level); // 0x067c9dbc
	System.Boolean get_Enabled(); // 0x067c9e34
	System.Int32 get_LightType(); // 0x067c9ec4
	System.Void Awake(); // 0x067c9f80
	System.Void OnEnable(); // 0x067ca29c
	System.Void OnDisable(); // 0x067ca408
	System.Void SetActiveState(System.Boolean active); // 0x067ca540
	System.Void SetLightEmissionRange(System.Single range); // 0x067ca688
	System.Void ResetLightEmissionRange(); // 0x067ca764
	System.Boolean GetGridPos(UnityEngine.Vector3& pos); // 0x067ca7e8
	System.Void Update(); // 0x067ca8e4
	System.Void OnDestroy(); // 0x067caa54
	System.Void .ctor(); // 0x067cabcc
	static System.Void .cctor(); // 0x067caca8
}

// Client.Runtime
enum LightComData.ELightStatus : System.Enum
{
	System.Int32 value__; // 0x10
	static LightComData.ELightStatus Enable = 0;
	static LightComData.ELightStatus Disable = 1;
	static LightComData.ELightStatus None = 2;
	
}

// Client.Runtime
enum LightComData.ELightAnimStatus : System.Enum
{
	System.Int32 value__; // 0x10
	static LightComData.ELightAnimStatus None = 0;
	static LightComData.ELightAnimStatus Playing = 1;
	
}

// Client.Runtime
class LightGroupComData : UnityEngine.MonoBehaviour
{
	LightGroupComData.ELightShowStage mLightShowStage; // 0x30
	System.Void Awake(); // 0x067cad7c
	System.Void OnDestroy(); // 0x067cae08
	System.Void SetLightState(System.Boolean enable); // 0x067cae94
	System.Void .ctor(); // 0x067caf24
}

// Client.Runtime
enum LightGroupComData.ELightShowStage : System.Enum
{
	System.Int32 value__; // 0x10
	static LightGroupComData.ELightShowStage Day = 1;
	static LightGroupComData.ELightShowStage Night = 2;
	
}

// Client.Runtime
class EditorCachePool : UnityEngine.MonoBehaviour
{
	System.Collections.Generic.List<UnityEngine.Object> CacheObjects; // 0x30
	System.Collections.Generic.Dictionary<System.String,UnityEngine.Object> cacheObjectDict; // 0x38
	static EditorCachePool Instance; // 0x0
	System.Void Awake(); // 0x067caf8c
	System.Void .ctor(); // 0x067cb05c
}

// Client.Runtime
class FxEvent : UnityEngine.MonoBehaviour
{
	UnityEngine.Transform VFXTransform; // 0x30
	System.Int64 entityId; // 0x38
	System.Void PlayVFX(); // 0x067cb168
	System.Void .ctor(); // 0x067cb3f4
}

// Client.Runtime
class LaserBeam : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	static SocLogger logger; // 0x0
	System.Int64 OwnerID; // 0x10
	UnityEngine.Transform Emitter; // 0x18
	System.Boolean isMonster; // 0x20
	System.Boolean Initialized; // 0x21
	UnityEngine.Transform FpCam; // 0x28
	UnityEngine.GameObject laserObject; // 0x30
	UnityEngine.LineRenderer beamRenderer; // 0x38
	UnityEngine.GameObject dotObject; // 0x40
	UnityEngine.Renderer dotRenderer; // 0x48
	Effect.EffectItemHandle<Effect.EffectItem> laserEffectItemHandle; // 0x50
	Effect.EffectItemHandle<Effect.EffectItem> dotEffectItemHandle; // 0x60
	UnityEngine.GameObject sniperAimObject; // 0x70
	UnityEngine.Animator sniperAimAnimator; // 0x78
	System.Boolean isPlayingAimAnimation; // 0x80
	System.Boolean isPlayingIdleAnimation; // 0x81
	System.Single aimAnimationDuration; // 0x84
	System.Single animationShootPercentage; // 0x88
	UnityEngine.MeshRenderer sniperHaloRender; // 0x90
	UnityEngine.MeshRenderer sniperDotRenderer; // 0x98
	UnityEngine.MeshRenderer sniperFlareRenderer; // 0xa0
	UnityEngine.LineRenderer sniperLineRender; // 0xa8
	Effect.EffectItemHandle<Effect.EffectItem> monsterSniperAimHandle; // 0xb0
	System.Boolean isHiding; // 0xc0
	System.Single maxDistance; // 0xc4
	System.Single stillBlendFactor; // 0xc8
	System.Single movementBlendFactor; // 0xcc
	System.Single movementThreshhold; // 0xd0
	System.Single aimToBarrelBlendFrac; // 0xd4
	System.Collections.Generic.List<UnityEngine.RaycastHit> tempHits; // 0xd8
	System.Boolean active; // 0xe0
	static LaserBeam CreateLaserBeam(System.Int64 topOwnerID, UnityEngine.Transform emitter, System.Boolean isfp); // 0x067cb45c
	static System.Void Release(LaserBeam laser); // 0x067cb9fc
	System.Void InitPlayer(System.Int64 topOwnerID, UnityEngine.Transform emitter, System.Boolean isFp); // 0x067cb748
	System.Void InitMonster(System.Int64 topOwnerID, UnityEngine.Transform emitter); // 0x067cb5c8
	System.Void OnGet(); // 0x067cba9c
	System.Void OnRelease(); // 0x067cbafc
	System.Void OnDestroy(); // 0x067cbcd4
	System.Void SetActive(System.Boolean active); // 0x067cbd34
	System.Void hideLaser(System.Boolean hide); // 0x067cbe88
	System.Void UpdateLaser(System.Single deltaTime); // 0x067cbfe8
	System.Void UpdatePlayerLaser(System.Single deltaTime); // 0x067cc9e8
	System.Boolean GetNearstHitPointWithOutScreenBox(UnityEngine.Ray r, System.Single maxDistance, System.Int32 lay, UnityEngine.Vector3& hitPoint); // 0x067ce02c
	System.Void UpdateSelfLaser(UnityEngine.Vector3& dotPos, System.Single deltaTime); // 0x067ccdb0
	System.Void UpdateOthersLaser(UnityEngine.Vector3& dotPos, System.Single deltaTime); // 0x067cd80c
	System.Void UpdateMonsterLaser(System.Single deltaTime); // 0x067cc084
	System.Void .ctor(); // 0x067ce3b8
	static System.Void .cctor(); // 0x067ce484
	System.Void <InitPlayer>b__28_0(System.Boolean success, Effect.EffectItem effectItem, System.Object o); // 0x067ce558
	System.Void <InitPlayer>b__28_1(System.Boolean success, Effect.EffectItem effectItem, System.Object o); // 0x067ce664
	System.Void <InitMonster>b__29_0(System.Boolean success, Effect.EffectItem effectItem, System.Object o); // 0x067ce820
}

// Client.Runtime
class RotLensflare : UnityEngine.MonoBehaviour
{
	System.Single rotationSpeed; // 0x30
	System.Single rotation; // 0x34
	System.Int32 _customRotationID; // 0x38
	System.Void Update(); // 0x067cebf0
	System.Void .ctor(); // 0x067cec88
}

// Client.Runtime
class VFX_Dispaly : UnityEngine.MonoBehaviour
{
	System.Single timeInterval; // 0x30
	UnityEngine.GameObject[] displayList; // 0x38
	System.Single time; // 0x40
	System.Int32 num; // 0x44
	System.Void Start(); // 0x067ced20
	System.Void Update(); // 0x067cee10
	System.Void .ctor(); // 0x067cef2c
}

// Client.Runtime
class ChangeMainColor : UnityEngine.MonoBehaviour
{
	WizardGames.Soc.SocClient.Timeline.ColorChangePlan colorChangePlan; // 0x30
	System.Void OnBecameVisible(); // 0x067cef9c
	System.Void .ctor(); // 0x067cf134
}

// Client.Runtime
class ClientParachuteGo : WizardGames.Soc.Common.Unity.Go.BaseParachuteGo
{
	UnityEngine.Animator Animator; // 0x168
	WizardGames.Soc.Common.Entity.ParachuteEntity ServerEntity; // 0x170
	WizardGames.Soc.Common.Unity.Go.ParachuteBind BincComponent; // 0x178
	UnityEngine.Renderer[] renderers; // 0x180
	System.Collections.Generic.List<System.Int64> damageCompSubscribeId; // 0x188
	WizardGames.Soc.SocClient.Ui.UiHudElemJoystick _joyStick; // 0x190
	System.Single startTime; // 0x198
	UnityEngine.Vector3 startVelocity; // 0x19c
	UnityEngine.Vector3 basicVelocity; // 0x1a8
	System.Boolean joyStickShow; // 0x1b4
	ClientParachuteGo.EJoystickInOutState joystickInOutState; // 0x1b8
	System.Single lastInputX; // 0x1bc
	System.Single lastInputY; // 0x1c0
	UnityEngine.Vector3 lastVelocity; // 0x1c4
	System.Single lastYaw; // 0x1d0
	System.Single lastRotSpeed; // 0x1d4
	System.Single sinAngle; // 0x1d8
	System.Boolean needProcessOnce; // 0x1dc
	System.Single needProceeStrength; // 0x1e0
	System.Boolean isTriggerEnter; // 0x1e4
	WizardGames.Soc.Common.Entity.IEntity get_GetEntity(); // 0x067cf19c
	WizardGames.Soc.SocClient.Ui.UiHudElemJoystick get_joyStick(); // 0x067cf200
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x067cf29c
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x067cf4c0
	System.Boolean CanMove(); // 0x067d0850
	System.Void SetMainGo(UnityEngine.GameObject obj, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x067cf7b4
	System.Void Predict(System.Int32 deltaTime, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, System.Int32 physicTickTime, System.Int32 allPhysicTime); // 0x067d0a54
	System.Void StartMove(System.Single dt); // 0x067d0d20
	UnityEngine.Vector2 GetDirXZ(System.Single yaw); // 0x067d092c
	System.Void TryShowJoyStick(System.Boolean show, System.Boolean snapXY); // 0x067d2ae0
	System.Void JoyStickShowHideUpdate(); // 0x067d0ecc
	System.Single GetXZSpeed(UnityEngine.Vector3 velocity); // 0x067d2df8
	System.Void CheckPlayAudio(System.Single percent); // 0x067d2ed0
	System.Void InputMove(System.Single dt, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, System.Single strength); // 0x067d1060
	System.Boolean get_IsPredictable(); // 0x067d310c
	System.Void UpdateCmd(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x067d3170
	WizardGames.Soc.Common.Unity.Go.MountableAuthoritySide GetAuthoritySide(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x067d399c
	System.Void Remove(); // 0x067d3a84
	System.Void PlayShatterAnim(); // 0x067d3f5c
	System.Void LoadFinish(UnityEngine.GameObject obj, System.Object[] owner); // 0x067d43bc
	System.Void BrokenFinishCallback(System.Single delayTime, System.Action callback); // 0x067d48dc
	System.Void AddFieldChangeListen(); // 0x055049cc
	System.Void RemoveFieldChangeListen(); // 0x067d3c98
	System.Void OnMaxHpChange(WizardGames.Soc.Common.Component.DamageableComponent server, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Component.DamageableComponent local); // 0x067d4a4c
	System.Void OnHpChange(WizardGames.Soc.Common.Component.DamageableComponent server, System.Single oldHp, System.Single nowHp, WizardGames.Soc.Common.Component.DamageableComponent local); // 0x067d4af8
	System.Void OnMoveStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x067d4ba4
	System.Void OnStateTimeChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x067d4dac
	System.Void SetVisible(System.Boolean visible); // 0x067d02f0
	System.Boolean OnlyApplyYaw(); // 0x067d4ec8
	System.Void OnTriggerEnter(UnityEngine.Collider collison); // 0x067d4f2c
	System.Void .ctor(); // 0x067d5050
}

// Client.Runtime
enum ClientParachuteGo.EJoystickInOutState : System.Enum
{
	System.Int32 value__; // 0x10
	static ClientParachuteGo.EJoystickInOutState In = 0;
	static ClientParachuteGo.EJoystickInOutState Off = 1;
	
}

// Client.Runtime
class ClientParachuteGo.<>c : System.Object
{
	static ClientParachuteGo.<>c <>9; // 0x0
	static System.Action<UnityEngine.GameObject,System.Object[]> <>9__52_0; // 0x8
	static System.Void .cctor(); // 0x067d51b4
	System.Void .ctor(); // 0x067d5218
	System.Void <PlayShatterAnim>b__52_0(UnityEngine.GameObject obj, System.Object[] owner); // 0x067d5280
}

// Client.Runtime
class ClientParachuteGo.<>c__DisplayClass53_0 : System.Object
{
	UnityEngine.Animator animator; // 0x10
	System.Object[] owner; // 0x18
	UnityEngine.GameObject obj; // 0x20
	System.Void .ctor(); // 0x067d4874
	System.Void <LoadFinish>b__0(); // 0x067d5370
}

// Client.Runtime
class ClientParachuteGo.<>c__DisplayClass55_0 : System.Object
{
	ClientParachuteGo <>4__this; // 0x10
	WizardGames.Soc.Common.Entity.IHitableEntity hitable; // 0x18
	WizardGames.Soc.Common.Component.DamageableComponent damageable; // 0x20
	System.Void .ctor(); // 0x067d49e4
	System.Void <AddFieldChangeListen>b__0(WizardGames.Soc.Share.Framework.CustomTypeBase server, System.Single oldValue, System.Single newValue); // 0x067d5474
	System.Void <AddFieldChangeListen>b__1(WizardGames.Soc.Share.Framework.CustomTypeBase server, System.Single oldValue, System.Single newValue); // 0x067d556c
}

// Client.Runtime
struct ClientParachuteGo.<BrokenFinishCallback>d__54 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	System.Single delayTime; // 0x38
	System.Action callback; // 0x40
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x48
	System.Void MoveNext(); // 0x067d5664
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x067d58a4
}

// Client.Runtime
class ClientTargetGo : WizardGames.Soc.Common.Unity.Go.BaseTargetGo
{
	WizardGames.Soc.SocClient.GoLoader.PartModelController PartModelController; // 0x98
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.TargetEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x067d5924
	WizardGames.Soc.Common.Component.GpuInstComponent get_gpuInst(); // 0x067d5bac
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x067d5c44
	System.Void InitPartController(); // 0x067d64bc
	System.Void SetMainGo(UnityEngine.GameObject obj); // 0x067d5dd0
	System.Void Remove(); // 0x067d6764
	System.Void .ctor(); // 0x067d6914
}

// Client.Runtime
class DecalGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo
{
	WizardGames.Soc.Common.Entity.DecalEntity <DecalEntity>k__BackingField; // 0x68
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.DecalEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x067d69a0
	WizardGames.Soc.Common.Entity.DecalEntity get_DecalEntity(); // 0x067d6ad8
	System.Void set_DecalEntity(WizardGames.Soc.Common.Entity.DecalEntity value); // 0x067d6b3c
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x067d6bbc
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x067d6d44
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x067d6f18
	System.Void OnTransChange(System.Int64 entityId, UnityEngine.Vector3 pos, UnityEngine.Vector3 rot); // 0x067d7898
	System.Void Clear(); // 0x067d7e34
	System.Void Remove(); // 0x067d7e94
	System.Void Update(); // 0x067d7f04
	System.Void .ctor(); // 0x067d7f6c
}

// Client.Runtime
class DelayedInstantiateComp : System.Object
{
	static SocLogger Logger; // 0x0
	System.Boolean IsInit; // 0x10
	System.Boolean IsValid; // 0x11
	System.Int32 LastPlayerIdx; // 0x14
	WizardGames.Soc.Common.Framework.Algorithm.Vector2i PlayerGridIdx; // 0x18
	Recti NearbyRect; // 0x20
	SignifianceGrid<DelayedInstantiateCell> Grid; // 0x30
	Unity.Collections.NativeParallelHashSet<System.Int32> LastNearbyList; // 0x38
	Unity.Collections.NativeParallelHashSet<System.Int32> CurNearbyList; // 0x48
	Unity.Collections.NativeParallelHashMap<System.Int64,System.Int32> Entity2CellIdx; // 0x58
	Unity.Collections.NativeParallelHashSet<System.Int64> DelayedRemoveEntityList; // 0x68
	PriorityQueue<System.Int32> SortedCellResult; // 0x78
	PriorityQueue<System.Int32> TempSortedCellResult; // 0x80
	PriorityQueue<System.Int64> SortedEntityInCellResult; // 0x88
	System.Diagnostics.Stopwatch Timer; // 0x90
	System.Single CurDuration; // 0x98
	System.Single CurTimeLeft; // 0x9c
	System.Single GameDuration; // 0xa0
	System.Action<System.Int32,System.Int32> FpsChangedFunc; // 0xa8
	WizardGames.Soc.Common.Unity.Character.State.Event.Callback<WizardGames.Soc.Common.Entity.PlayerEntity> PlayerDeadFunc; // 0xb0
	WizardGames.Soc.Common.Unity.Character.State.Event.Callback<WizardGames.Soc.Common.Entity.PlayerEntity> PlayerRebornFunc; // 0xb8
	System.Void Init(); // 0x055049cc
	System.Void Clear(); // 0x055049cc
	System.Void SetGameDuration(System.Single duration); // 0x067d8c1c
	System.Void SetCurrentDuration(System.Single duration); // 0x067d85f0
	static System.Single CalcDuration(System.Single fps); // 0x067d8cb4
	System.Void OnFpsChanged(System.Int32 lastFps, System.Int32 currFps); // 0x067d8d38
	System.Void OnPlayerDead(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x067d8dfc
	System.Void OnPlayerReborn(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x067d8ea8
	System.Boolean UpdateDealDelateAndInstantiate(); // 0x067d8f24
	System.Void Update(); // 0x067d9814
	System.Boolean InstantiateEntity(PriorityQueue<System.Int64> InQueue, DelayedInstantiateCell InCell, System.Diagnostics.Stopwatch InWatch, System.Single InCurDuration, System.Single& OutInterval); // 0x067da9b8
	System.Boolean InstantiateEmbeddedEntity(PriorityQueue<System.Int64> InQueue, DelayedInstantiateCell InCell, System.Diagnostics.Stopwatch InWatch, System.Single InCurDuration, System.Single& OutInterval); // 0x067daefc
	System.Void UpdateEntities(System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Share.Framework.EntityBase> inNewEntities, System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.IEmbeddedCustom> newEmbedded); // 0x067db868
	System.Boolean TryInitGrid(UnityEngine.Rect InTerrainRect, System.Int32 InGridSize, System.Int32 CellSize, SignifianceGrid<DelayedInstantiateCell>& OutGrid); // 0x067da794
	System.Void RemoveEntities(System.Collections.Generic.Dictionary<System.Int64,System.Int32> removeEntities, System.Collections.Generic.HashSet<WizardGames.Soc.Common.Entity.IEmbeddedCustom> removeEmbedded); // 0x067dd654
	System.Boolean RemoveEntityFromCell(System.Int64 entityId); // 0x067ddba8
	System.Void RemoveEntityDelayed(System.Int64 entityId); // 0x067dd970
	System.Boolean RemoveEntitiesImmediate(System.Diagnostics.Stopwatch InWatch, System.Single InCurDuration, System.Single& OutInterval); // 0x067d9040
	UnityEngine.Vector2 GetEntityPos(WizardGames.Soc.Common.Entity.IEntity InEntity); // 0x067dd4bc
	System.Boolean IsGlobalEntity(System.Int32 InEntityTypeId); // 0x067dd428
	System.Void .ctor(); // 0x067ddcb8
	static System.Void .cctor(); // 0x067ddea8
}

// Client.Runtime
class DelayedInstantiateComp.<>c : System.Object
{
	static DelayedInstantiateComp.<>c <>9; // 0x0
	static System.Func<DelayedInstantiateCell> <>9__21_0; // 0x8
	static System.Action<DelayedInstantiateCell> <>9__21_1; // 0x10
	static System.Void .cctor(); // 0x06d404e0
	System.Void .ctor(); // 0x06d40544
	DelayedInstantiateCell <Init>b__21_0(); // 0x06d405ac
	System.Void <Init>b__21_1(DelayedInstantiateCell cell); // 0x06d406d4
}

// Client.Runtime
class DelayedInstantiateCell : System.Object
{
	System.Int32 Idx; // 0x10
	System.Boolean IsInit; // 0x14
	UnityEngine.Vector2 Pos; // 0x18
	System.Int32 EntityCount; // 0x20
	System.Int32 EmbeddedEntityCount; // 0x24
	System.Int32 InstantiatedEntityCount; // 0x28
	Unity.Collections.NativeParallelHashMap<System.Int64,System.Int32> EntityDic; // 0x30
	Unity.Collections.NativeParallelHashMap<System.Int64,System.Int32> EmbeddedEntityDic; // 0x40
	Unity.Collections.NativeParallelHashSet<System.Int64> InstantiatedEntity; // 0x50
	System.Boolean IsEmpty(); // 0x06d408cc
	System.Void Init(System.Int32 InIdx, UnityEngine.Vector2 InPos); // 0x06d4094c
	System.Void FillEntityInQueue(PriorityQueue<System.Int64> InQueue); // 0x06d40ab0
	System.Void FillEmbeddedInQueue(PriorityQueue<System.Int64> InQueue); // 0x06d40d18
	System.Void FillAllEntity(Unity.Collections.NativeParallelHashSet<System.Int64>& InList); // 0x06d40f80
	System.Void Clear(); // 0x06d40754
	System.Void Add(System.Int64 InId, System.Int32 InTypeId); // 0x06d414a8
	System.Void AddEmbedded(System.Int64 InId, System.Int32 InTypeId); // 0x06d4155c
	System.Void InstantiateEntity(System.Int64 InId); // 0x06d41610
	System.Boolean TryRemoveEntity(System.Int64 InId, System.Int32& OutPriority); // 0x06d41730
	System.Boolean Remove(System.Int64 InId); // 0x06d41818
	System.Void .ctor(); // 0x06d40634
}

// Client.Runtime
class DelayedInstPriorityMapLoader : System.Object
{
	static System.Int32 MaxPriority; // 0x0
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32> TypeIdToPriority; // 0x8
	static System.Void Init(); // 0x06d41954
	static System.Int32 GetDelayedInstPriority(System.Int32 typeId); // 0x06d41d30
	static System.Int32 GetDelayedInstPriority(System.Int64 eId); // 0x06d41de0
	static System.Int32 GetDelayedInstPriority(System.Int32 entityType, System.Int64 ownerEntityId); // 0x06d423ac
	static System.Int32 GetDelayedInstPriority(WizardGames.Soc.Common.Entity.IItemEntity entity); // 0x06d41efc
	static System.Int32 GetDelayedInstPriority(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06d42084
	static System.Void .cctor(); // 0x06d42508
}

// Client.Runtime
class ModuleParts : UnityEngine.MonoBehaviour
{
	UnityEngine.GameObject LockGo; // 0x30
	System.Void .ctor(); // 0x06d425ac
}

// Client.Runtime
class TankMonsterGo : WizardGames.Soc.SocClient.Go.MonsterGo
{
	WizardGames.Soc.Common.Unity.Monster.Animation.TankAnimLogic TankAnimLogic; // 0x2d8
	WizardGames.Soc.Common.Unity.Monster.Animation.TankConfiguration TankConfiguration; // 0x2e0
	WizardGames.Soc.Common.Unity.Monster.Animation.TankConfig TankConfig; // 0x2e8
	WizardGames.Soc.Common.Unity.Monster.Animation.TreadEffect TreadEffect; // 0x300
	System.Single treadThreshold; // 0x308
	UnityEngine.Vector3 lastPosition; // 0x30c
	UnityEngine.Vector3 lastForward; // 0x318
	Effect.EffectItemHandle<Effect.EffectItem> summonEffect; // 0x328
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x06d42614
	System.Void SubscribeEntityPropertyChange(); // 0x06d42bb4
	System.Void UnsubscribeEntityPropertyChange(); // 0x06d42cec
	System.Void OnEffectDisappearChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Boolean oldValue, System.Boolean newValue); // 0x06d42e24
	System.Void OnSummonChanged(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Boolean oldValue, System.Boolean newValue); // 0x06d42fbc
	System.Void SetMainGo(UnityEngine.GameObject mainGo, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x06d427a4
	UnityEngine.Vector3 GetWeaponFirePos(System.Int32 slotId); // 0x06d43590
	UnityEngine.Transform GetWeaponFireTrans(System.Int32 slotId); // 0x06d4369c
	UnityEngine.GameObject GetFireGo(System.Int32 slotId); // 0x06d43774
	System.Void OnHpChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Single oldValue, System.Single newValue); // 0x06d4384c
	UnityEngine.Vector3 GetEntityPos(System.Int64 entityId); // 0x06d43af8
	System.Int32 UpdateWeaponGunParam(WizardGames.Soc.Common.Data.units.MonsterTankBehavior behaviorTemplate, WizardGames.Soc.Common.Entity.MonsterEntity.MonsterHeldItemSlot slot); // 0x06d43150
	System.Void UpdatePosition(); // 0x06d43fa8
	System.Void UpdateAnimationUnlimited(System.Int64 time); // 0x06d4407c
	System.Void Tick(); // 0x06d440f0
	System.Void ReleaseEffect(); // 0x06d42ed0
	System.Void ReleaseWeaponEffectData(WizardGames.Soc.Common.CustomType.EmbeddedCustomBase owner); // 0x06d4452c
	System.Void Remove(); // 0x06d44610
	System.Void .ctor(); // 0x06d44768
}

// Client.Runtime
class PartModelVisible : UnityEngine.MonoBehaviour
{
	UnityEngine.LODGroup rootLODGroup; // 0x30
	System.Void OnBecameVisible(); // 0x06d44800
	System.Void .ctor(); // 0x06d448b8
}

// Client.Runtime
enum ERenderControlMode : System.Enum
{
	System.Int32 value__; // 0x10
	static ERenderControlMode CONTROL_NONE = 0;
	static ERenderControlMode CONTROL_GAME_OBJECT = 1;
	static ERenderControlMode CONTROL_PART_MODEL = 2;
	static ERenderControlMode CONTROL_ALL = 3;
	
}

// Client.Runtime
class RendererItem : System.Object
{
	System.Int32 Visible; // 0x10
	System.Int32 CurLodLvl; // 0x14
	UnityEngine.Rendering.Universal.OcclusionCulling.OcclusionCullingRegister OcRegister; // 0x18
	System.Collections.Generic.List<UnityEngine.Renderer> Renders; // 0x20
	System.Collections.Generic.List<UnityEngine.LODGroup> Lod; // 0x28
	WizardGames.Soc.SocClient.GoLoader.PartModelController PartCtrl; // 0x30
	ERenderControlMode ControlMode; // 0x38
	SignifianceEntityResultBehaviour Result; // 0x40
	static RendererItem NewRenderItem(); // 0x06d44920
	System.Void Clear(); // 0x06d44b1c
	System.Void UpdateOcclusion(UnityEngine.Vector3 worldPos, UnityEngine.Vector3 worldRot, SharedUnity.GameLocalBounds bounds); // 0x06d44cb4
	ESignifianceVisibleStatus GetVisibleStatus(UnityEngine.Plane[] frustumPlanes); // 0x06d44e5c
	System.Void .ctor(); // 0x06d449a0
}

// Client.Runtime
class RendererHandlerCharacter : System.Object
{
	static SocLogger logger; // 0x0
	static UnityEngine.Pool.ObjectPool<RendererItem> ItemPool; // 0x8
	System.Collections.Generic.Dictionary<System.Int64,RendererItem> RendererItems; // 0x10
	System.Int32 MaxLodLimit; // 0x18
	UnityEngine.Plane[] FrustumPlanes; // 0x20
	System.Void CalculateFrustumPlanes(); // 0x06d45120
	System.Boolean IsOcclusion(System.Int64 entityId); // 0x06d45218
	System.Void OnAdd_Debug(System.Int64 id, RendererItem item); // 0x06d452e4
	System.Void OnRemove_Debug(System.Int64 id, RendererItem item); // 0x06d4551c
	System.Void Add(System.Int64 InEntityId, UnityEngine.GameObject Obj, WizardGames.Soc.SocClient.GoLoader.PartModelController ctrl, SignifianceEntityResultBehaviour result); // 0x06d45754
	System.Void Remove(System.Int64 InEntityId); // 0x06d45dd8
	System.Void ForceLod(System.Int64 InEntityId, System.Int32 InLodLvl); // 0x06d461d8
	System.Void SetVisibility(System.Int64 InEntityId, System.Boolean InVisible); // 0x06d46754
	System.Boolean CheckVisible(System.Int64 InEntityId); // 0x06d46bd8
	System.Void Clear(); // 0x06d46f00
	System.Void SetMaxLodLimit(System.Int32 maxLodLimit); // 0x06d47110
	System.Void .ctor(); // 0x06d47188
	static System.Void .cctor(); // 0x06d47270
}

// Client.Runtime
class DebugViewsAutoProfiler : UnityEngine.MonoBehaviour, GraphicsTest.DebugViewsController.ICustomProfiler
{
	System.String caseName; // 0x30
	System.String stepName; // 0x38
	System.Boolean useCaseName; // 0x40
	System.Boolean withoutClient; // 0x41
	System.Int32 expectedFPS; // 0x44
	System.Void Awake(); // 0x06d47410
	System.Void Start(); // 0x06d47544
	System.Void OnDestroy(); // 0x06d476ec
	System.Void StartProfile(); // 0x06d47820
	System.Void EndProfile(); // 0x06d47b98
	static System.Void OnBeginUrpSample(UnityEngine.Rendering.Universal.EUrpFunc func); // 0x06d47c20
	static System.Void OnEndUrpSample(UnityEngine.Rendering.Universal.EUrpFunc func); // 0x06d47ce4
	System.Void .ctor(); // 0x06d47da8
}

// Client.Runtime
class GetPartBuilding : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	System.Int32 frameDelay; // 0x30
	System.Boolean setZJPos; // 0x34
	System.Void Update(); // 0x06d47e4c
	System.Void .ctor(); // 0x06d48280
	static System.Void .cctor(); // 0x06d482f0
}

// Client.Runtime
class GuideLines : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	static System.Single DeltaY; // 0x8
	UnityEngine.Vector3 target; // 0x30
	System.Collections.Generic.List<UnityEngine.Vector3> multipleTargets; // 0x40
	System.Int32 curTargetIndex; // 0x48
	System.Int32 pathNodeNum; // 0x4c
	System.Single lineScale; // 0x50
	System.Single curvature; // 0x54
	System.Collections.Generic.HashSet<System.Int32> groundFreeIds; // 0x58
	static System.Boolean EnableNewGuide; // 0xc
	System.Single sampleStep; // 0x60
	System.Single smoothStep; // 0x64
	System.Single maxSampleDist; // 0x68
	UnityEngine.Material mat; // 0x70
	UnityEngine.AnimationCurve alphaCurve; // 0x78
	UnityEngine.LineRenderer rend; // 0x80
	System.Boolean needUpdateOnce; // 0x88
	System.Collections.Generic.List<UnityEngine.Vector3> targetList; // 0x90
	UnityEngine.Vector3[] targetArrayWithHeight; // 0x98
	UnityEngine.Vector3[] sampleArray; // 0xa0
	System.Collections.Generic.List<UnityEngine.Vector3> sampleList; // 0xa8
	System.Collections.Generic.List<UnityEngine.Vector3> unsampleList; // 0xb0
	UnityEngine.ParticleSystem m_ParticleSystem; // 0xb8
	UnityEngine.ParticleSystem.Particle[] m_Particles; // 0xc0
	UnityEngine.Color rendColor; // 0xc8
	System.Void Start(); // 0x06d483c4
	System.Void OnDisable(); // 0x06d4870c
	System.Void OnEnable(); // 0x06d487c8
	System.Void Tick(); // 0x06d48884
	System.Void CalculateTotalPathOnce(); // 0x06d48610
	System.Void TickWithHeightMap(); // 0x06d49260
	System.Void ParticleUpdate(); // 0x06d48c3c
	System.Single GetAlphaPercent(); // 0x06d4937c
	System.Void SetTargetPos(UnityEngine.Vector3 pos); // 0x06d49434
	System.Void SetMultipleTargets(System.Collections.Generic.List<UnityEngine.Vector3> targetPosList, System.Int32 curIndex); // 0x06d494cc
	System.Void SetCurveDir(System.Single dir); // 0x06d496f8
	System.Single CheckPointSide(UnityEngine.Vector3 originPos, UnityEngine.Vector3 targetPos, UnityEngine.Vector3 Pos); // 0x06d497c0
	UnityEngine.Vector3[] SampleAlongMultiplePath(); // 0x06d48fa0
	UnityEngine.Vector3[] SmoothLine(UnityEngine.Vector3[] inputPoints, System.Boolean[]& groundMarks, System.Single segmentSize); // 0x06d498b8
	static System.Single DistanceY(UnityEngine.Vector3 a, UnityEngine.Vector3 b); // 0x06d4a1e8
	static UnityEngine.Vector3 GetGroundPos(UnityEngine.Vector3 input, System.Boolean hasHeightLimit, System.Single maxHeight); // 0x06d4a030
	System.Void .ctor(); // 0x06d4a2dc
	static System.Void .cctor(); // 0x06d4a4c0
}

// Client.Runtime
class ProfilerRecorderData : UnityEngine.MonoBehaviour
{
	Unity.Profiling.ProfilerRecorder verticesRecorder; // 0x30
	Unity.Profiling.ProfilerRecorder trianglesRecorder; // 0x38
	Unity.Profiling.ProfilerRecorder drawCallsRecorder; // 0x40
	Unity.Profiling.ProfilerRecorder setPassCallsRecorder; // 0x48
	System.Int32 playerVisibleCount; // 0x50
	System.Int32 monsterVisibleCount; // 0x54
	System.Int32 vehicleVisibleCount; // 0x58
	System.Int32 totalRandonEntityCount; // 0x5c
	System.Void OnEnable(); // 0x06d4a5b4
	System.Void OnDisable(); // 0x06d4a700
	System.Void CalVisibleNum(); // 0x06d4a78c
	System.Void Update(); // 0x06d4b1d0
	System.Void GetDrawCall(); // 0x06d4b2bc
	System.Void .ctor(); // 0x06d4b8ac
}

// Client.Runtime
class LightVolumeInfo : System.Object
{
	System.String customBakedTexturePath; // 0x10
	System.Void Init(WizardGames.Soc.Common.Data.LightVolume lightVolume); // 0x06d4b914
	System.Void .ctor(); // 0x06d4b99c
}

// Client.Runtime
class LobbpCamFOVScaler : UnityEngine.MonoBehaviour
{
	
	System.Void Awake(); // 0x06d4ba04
	System.Void .ctor(); // 0x06d4bbec
}

// Client.Runtime
class MgrGamePyhsicsSystem : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger <logger>k__BackingField; // 0x0
	WizardGames.Soc.Common.Unity.Utility.GamePhysicsSystem gamePhysicsSystem; // 0x18
	static SocLogger get_logger(); // 0x06d4bc54
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06d4bcdc
	System.Threading.Tasks.Task OnExitWorld(); // 0x06d4bdec
	System.Void CleanUp(); // 0x06d4bf8c
	System.Void Setup(); // 0x06d4bff0
	System.Void DoCleanup(); // 0x06d4be5c
	System.Void .ctor(); // 0x06d4c1e0
	static System.Void .cctor(); // 0x06d4c248
	System.Threading.Tasks.Task <>n__0(); // 0x06d4c2e0
}

// Client.Runtime
struct MgrGamePyhsicsSystem.<OnEnterWorld>d__4 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	MgrGamePyhsicsSystem <>4__this; // 0x30
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x38
	System.Void MoveNext(); // 0x06d4c348
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x06d4c570
}

// Client.Runtime
class MgrSocTpAnim : WizardGames.Soc.Common.Manager.MgrBase
{
	
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06d4c614
	System.Threading.Tasks.Task OnExitWorld(); // 0x06d4c67c
	System.Void CleanUp(); // 0x06d4c6e4
	System.Void .ctor(); // 0x06d4c778
}

// Client.Runtime
class MonsterSkinBinder : UnityEngine.MonoBehaviour
{
	UnityEngine.Transform TargetRootBone; // 0x30
	System.Void Awake(); // 0x06d4c7e0
	System.Void MapBones(UnityEngine.SkinnedMeshRenderer[] meshRenderers, UnityEngine.Transform targetTrans); // 0x06d4c8dc
	System.Void .ctor(); // 0x06d4cc38
}

// Client.Runtime
class LoginStepHelper : System.Object
{
	static System.Boolean ProcessReconnect; // 0x0
	static SocLogger Log; // 0x8
	static System.Action game2LobbyCb; // 0x10
	static System.Void JoinDynamicGame(SimpleJSON.JSONNode node); // 0x06d4cca0
	static System.Void RequestGiveUpBattle(); // 0x06d4db4c
	static System.Void RequestGiveUpBattleWhenBackToLobby(System.Boolean skipUiProcess); // 0x06d4df24
	static System.Void RequestReconnectBattle(); // 0x06d4e17c
	static System.Void RequestReconnectBattleWhenBackToLobby(System.Boolean skipUiProcess); // 0x06d4e448
	static System.Void RequestGuideInfo(System.Int32 onlineStatus); // 0x06d4e718
	static System.Void JoinLobby(); // 0x06d4e948
	static System.Void EnterFreshmanFightLineup(System.Action<SimpleJSON.JSONNode> onSuccess); // 0x06d4ebbc
	static System.Void SkipFreshmanFightLineup(System.Action onSuccess); // 0x06d4ec98
	static System.Void HandleOnlineStatus(System.Boolean showTips, System.Boolean force, System.Boolean skipUiProcess); // 0x06d4ef40
	static System.Void HandleOnlineStatus(); // 0x06d4f508
	static System.Void SetGame2LobbyCb(System.Action cb); // 0x06d4f8a8
	static System.Void CheckTeamMatchingNeedJoinBattle(); // 0x06d4f93c
	static System.Void OnHandleOnlineStatusError(); // 0x06d4fc38
	static System.Void GetLobbyDataBattleReturnToLobby(); // 0x06d4f320
	static System.Void .cctor(); // 0x06d504a8
}

// Client.Runtime
class LoginStepHelper.<>c : System.Object
{
	static LoginStepHelper.<>c <>9; // 0x0
	static System.Action<SimpleJSON.JSONNode> <>9__3_0; // 0x8
	static System.Action <>9__3_2; // 0x10
	static System.Action<SimpleJSON.JSONNode> <>9__3_1; // 0x18
	static System.Action <>9__4_3; // 0x20
	static System.Action<SimpleJSON.JSONNode> <>9__5_0; // 0x28
	static System.Action<SimpleJSON.JSONNode> <>9__5_1; // 0x30
	static System.Action<SimpleJSON.JSONNode> <>9__6_0; // 0x38
	static System.Action <>9__7_3; // 0x40
	static System.Action <>9__8_0; // 0x48
	static System.Action <>9__10_3; // 0x50
	static System.Action <>9__12_4; // 0x58
	static System.Action <>9__12_5; // 0x60
	static System.Action <>9__12_7; // 0x68
	static System.Action<SimpleJSON.JSONNode> <>9__12_1; // 0x70
	static System.Action<SimpleJSON.JSONNode> <>9__13_2; // 0x78
	static System.Action <>9__13_5; // 0x80
	static System.Action<SimpleJSON.JSONNode> <>9__13_0; // 0x88
	static System.Action<SimpleJSON.JSONNode> <>9__13_1; // 0x90
	static System.Action<SimpleJSON.JSONNode> <>9__16_0; // 0x98
	static System.Action<SimpleJSON.JSONNode> <>9__16_1; // 0xa0
	static System.Action <>9__17_0; // 0xa8
	static System.Action <>9__17_1; // 0xb0
	static System.Void .cctor(); // 0x06d505a4
	System.Void .ctor(); // 0x06d50608
	System.Void <RequestGiveUpBattle>b__3_0(SimpleJSON.JSONNode ret); // 0x06d50670
	System.Void <RequestGiveUpBattle>b__3_1(SimpleJSON.JSONNode errorNode); // 0x06d50918
	System.Void <RequestGiveUpBattle>b__3_2(); // 0x06d50e1c
	System.Void <RequestGiveUpBattleWhenBackToLobby>b__4_3(); // 0x06d50ea4
	System.Void <RequestReconnectBattle>b__5_0(SimpleJSON.JSONNode ret); // 0x06d50f4c
	System.Void <RequestReconnectBattle>b__5_1(SimpleJSON.JSONNode errorNode); // 0x06d51010
	System.Void <RequestReconnectBattleWhenBackToLobby>b__6_0(SimpleJSON.JSONNode ret); // 0x06d51310
	System.Void <RequestGuideInfo>b__7_3(); // 0x06d513d4
	System.Void <JoinLobby>b__8_0(); // 0x06d5145c
	System.Void <EnterFreshmanFightLineup>b__10_3(); // 0x06d516e4
	System.Void <HandleOnlineStatus>b__12_4(); // 0x06d5178c
	System.Void <HandleOnlineStatus>b__12_5(); // 0x06d51a14
	System.Void <HandleOnlineStatus>b__12_7(); // 0x06d51acc
	System.Void <HandleOnlineStatus>b__12_1(SimpleJSON.JSONNode errorNode); // 0x06d51b54
	System.Void <HandleOnlineStatus>b__13_0(SimpleJSON.JSONNode res); // 0x06d51c54
	System.Void <HandleOnlineStatus>b__13_2(SimpleJSON.JSONNode ret); // 0x06d51fc0
	System.Void <HandleOnlineStatus>b__13_5(); // 0x06d52224
	System.Void <HandleOnlineStatus>b__13_1(SimpleJSON.JSONNode errorNode); // 0x06d522ac
	System.Void <CheckTeamMatchingNeedJoinBattle>b__16_0(SimpleJSON.JSONNode res); // 0x06d523ac
	System.Void <CheckTeamMatchingNeedJoinBattle>b__16_1(SimpleJSON.JSONNode errorNode); // 0x06d52598
	System.Void <OnHandleOnlineStatusError>b__17_0(); // 0x06d52704
	System.Void <OnHandleOnlineStatusError>b__17_1(); // 0x06d527ac
}

// Client.Runtime
class LoginStepHelper.<>c__DisplayClass10_0 : System.Object
{
	System.Action<SimpleJSON.JSONNode> onSuccess; // 0x10
	System.Action <>9__2; // 0x18
	System.Void .ctor(); // 0x06d52854
	System.Void <EnterFreshmanFightLineup>b__0(SimpleJSON.JSONNode ret); // 0x06d528bc
	System.Void <EnterFreshmanFightLineup>b__1(SimpleJSON.JSONNode errorNode); // 0x06d529d4
	System.Void <EnterFreshmanFightLineup>b__2(); // 0x06d52f08
}

// Client.Runtime
class LoginStepHelper.<>c__DisplayClass11_0 : System.Object
{
	System.Action onSuccess; // 0x10
	System.Void .ctor(); // 0x06d4eed8
	System.Void <SkipFreshmanFightLineup>b__0(SimpleJSON.JSONNode ret); // 0x06d52f94
}

// Client.Runtime
class LoginStepHelper.<>c__DisplayClass12_0 : System.Object
{
	System.Boolean skipUiProcess; // 0x10
	System.Boolean showTips; // 0x11
	System.Boolean force; // 0x12
	System.Action<SimpleJSON.JSONNode> <>9__2; // 0x18
	System.Void .ctor(); // 0x06d4f2b8
	System.Void <HandleOnlineStatus>b__0(SimpleJSON.JSONNode res); // 0x06d530d8
	System.Void <HandleOnlineStatus>b__2(SimpleJSON.JSONNode ret); // 0x06d5347c
}

// Client.Runtime
class LoginStepHelper.<>c__DisplayClass12_1 : System.Object
{
	System.Int32 onlineStatus; // 0x10
