	System.Void SwitchMode(WizardGames.Soc.Common.Unity.Construction.ECoreColliderState targetState); // 0x07499764
	System.Void ReleaseAllCollider(); // 0x07498870
	System.Boolean AddToListAndIsFinish(WizardGames.Soc.Common.Unity.Construction.ColliderGoData colliderGoData, System.Collections.Generic.List<WizardGames.Soc.Common.Combat.ColliderConfig> configs); // 0x07499440
	UnityEngine.GameObject GetComboAssistGo(System.String tagName); // 0x07499950
	System.Void .ctor(); // 0x07499a90
	static System.Void .cctor(); // 0x07499bac
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.CoreConstructionGradeNode : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.Construction.CoreColliderData colliderData; // 0x30
	System.Void Init(WizardGames.Soc.Common.Unity.Construction.CoreColliderData colliderData); // 0x07499cd8
	System.Void .ctor(); // 0x07499d58
	static System.Void .cctor(); // 0x07499dc0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.GamePhysics : System.Object
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.Common.Unity.Utility.GamePhysicsSystem gamePhysicsSystem; // 0x8
	static System.Comparison<UnityEngine.RaycastHit> comparison; // 0x10
	static System.Comparison<WizardGames.Soc.Common.Combat.SocRaycastHit> comparisonSoc; // 0x18
	static System.Void Initialize(WizardGames.Soc.Common.Unity.Utility.GamePhysicsSystem system); // 0x07499e94
	static UnityEngine.Collider[] get_colBuffer(); // 0x07499f98
	static UnityEngine.RaycastHit[] get_hitBuffer(); // 0x0749a0d8
	static System.Boolean CheckSphere(UnityEngine.Vector3 position, System.Single radius, System.Int64 ignoreEntityId, System.Boolean& isCollideDebrisWall, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction triggerInteraction); // 0x0749a218
	static System.Boolean CheckOBB(WizardGames.Soc.Common.Unity.Utility.OBB obb, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction triggerInteraction); // 0x0749a778
	static System.Boolean CheckOBBAndEntity(WizardGames.Soc.Common.Unity.Utility.OBB obb, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction triggerInteraction, WizardGames.Soc.Common.Construction.ConstructionPartType ignorePartType, System.Boolean needGetGroundFromHitDetail, System.Int64 additionIgnoreEntityId); // 0x0749a8dc
	static WizardGames.Soc.Common.Entity.PartEntity CheckObbAndPartGo(WizardGames.Soc.Common.Unity.Utility.OBB obb, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction triggerInteraction, WizardGames.Soc.Common.Entity.PartEntity ignorePartGo); // 0x0749ac24
	static System.Boolean CheckOverlapDoor(WizardGames.Soc.Common.Unity.Utility.OBB obb); // 0x0749aec4
	static System.Boolean Verify(UnityEngine.RaycastHit hitInfo, WizardGames.Soc.Common.Entity.PartEntity ignoreEntity); // 0x0749b16c
	static System.Boolean Verify(UnityEngine.Collider collider, UnityEngine.Vector3 point, WizardGames.Soc.Common.Entity.PartEntity ignoreEntity); // 0x0749b27c
	static System.Void TraceAllUnordered(UnityEngine.Ray ray, System.Single radius, System.Collections.Generic.List<UnityEngine.RaycastHit> hits, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction triggerInteraction, WizardGames.Soc.Common.Entity.PartEntity ignoreEntity, System.Func<UnityEngine.RaycastHit,System.Boolean> ValidCheckAction, System.Boolean isPhysicsScene); // 0x0749b330
	static System.Boolean Trace(UnityEngine.Ray ray, System.Single radius, UnityEngine.RaycastHit& hitInfo, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction triggerInteraction, WizardGames.Soc.Common.Entity.PartEntity ignoreEntity); // 0x0749ba20
	static System.Void OverlapSphere(UnityEngine.Vector3 position, System.Single radius, System.Collections.Generic.List<UnityEngine.Collider> list, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction triggerInteraction); // 0x0749bd34
	static System.Void CapsuleSweep(UnityEngine.Vector3 position0, UnityEngine.Vector3 position1, System.Single radius, UnityEngine.Vector3 direction, System.Single distance, System.Collections.Generic.List<UnityEngine.RaycastHit> list, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction triggerInteraction); // 0x0749c058
	static System.Void OverlapCapsule(UnityEngine.Vector3 point0, UnityEngine.Vector3 point1, System.Single radius, System.Collections.Generic.List<UnityEngine.Collider> list, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction triggerInteraction); // 0x0749c410
	static System.Void OverlapOBB(WizardGames.Soc.Common.Unity.Utility.OBB obb, System.Collections.Generic.List<UnityEngine.Collider> list, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction triggerInteraction); // 0x0749c5a4
	static System.Void OverlapBounds(UnityEngine.Bounds bounds, System.Collections.Generic.List<UnityEngine.Collider> list, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction triggerInteraction); // 0x0749c974
	static System.Void BufferToList(System.Int32 count, System.Collections.Generic.List<UnityEngine.Collider> list); // 0x0749be7c
	static System.Int32 HandleTerrainCollision(UnityEngine.Vector3 position, System.Int32 layerMask); // 0x0749a6e4
	static System.Void HitBufferToList(System.Int32 count, System.Collections.Generic.List<UnityEngine.RaycastHit> list); // 0x0749c21c
	static System.Void TraceBoxAllUnordered(System.Collections.Generic.List<UnityEngine.RaycastHit> hits, UnityEngine.Vector3 center, UnityEngine.Vector3 halfsize, UnityEngine.Vector3 direction, UnityEngine.Quaternion orientation, System.Single maxDis, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction triggerInteraction, System.Boolean isPhysicsScene); // 0x0749cb40
	static System.Void Sort(System.Collections.Generic.List<UnityEngine.RaycastHit> hits); // 0x0749bc80
	static System.Void Sort(System.Collections.Generic.List<WizardGames.Soc.Common.Combat.SocRaycastHit> hits); // 0x0749cfa8
	static System.Void .cctor(); // 0x0749d05c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.GamePhysics.<>c : System.Object
{
	static WizardGames.Soc.Common.Unity.Construction.GamePhysics.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x0749d22c
	System.Void .ctor(); // 0x0749d290
	System.Int32 <.cctor>b__40_0(UnityEngine.RaycastHit a, UnityEngine.RaycastHit b); // 0x0749d2f8
	System.Int32 <.cctor>b__40_1(WizardGames.Soc.Common.Combat.SocRaycastHit a, WizardGames.Soc.Common.Combat.SocRaycastHit b); // 0x0749d3bc
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Construction.ISkinGoHandler : 
{
	
	System.Void OnSkinGoLoaded(UnityEngine.GameObject skinGo); // 0x05523a54
	System.Void OnSkinGoRemove(); // 0x055049cc
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Construction.IUiBtnHandler : 
{
	
	System.Void GetUiBtnListOutOfPerm(System.Collections.Generic.List<System.Int32> retList); // 0x05523a54
	System.Void GetUiBtnList(System.Collections.Generic.List<System.Int32> retList); // 0x05523a54
	System.Void GetUiBtnOverlayList(System.Collections.Generic.List<System.Int32> retList); // 0x05523a54
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x055056e8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.Placement : System.Object
{
	UnityEngine.Vector3 position; // 0x10
	UnityEngine.Quaternion rotation; // 0x1c
	WizardGames.Soc.Common.Unity.Construction.EPlaceState placeState; // 0x2c
	System.Boolean hasAttract; // 0x30
	System.Void .ctor(); // 0x0749d4f0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.RaycastDetailHitbox : System.Object
{
	static System.Collections.Generic.List<UnityEngine.RaycastHit> raycastHits; // 0x0
	static System.Int32 InvalidIndex; // 0x8
	static System.Collections.Generic.Dictionary<System.String,System.Int32> keyToPosIndex; // 0x10
	static System.Collections.Generic.List<UnityEngine.GameObject> mainGos; // 0x18
	static System.Boolean isInit; // 0x20
	static System.String detailHitbox; // 0x28
	static System.String RoughHitbox; // 0x30
	static System.String CommonHitbox; // 0x38
	static UnityEngine.Vector3 srcPoint; // 0x40
	static System.Int32 posOffset; // 0x4c
	static UnityEngine.Collider[] tempColliderArray; // 0x50
	static System.Void .cctor(); // 0x0749d558
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.Vis : System.Object
{
	static SocLogger logger; // 0x0
	static System.Int32 colCount; // 0x8
	static UnityEngine.Collider[] colBuffer; // 0x10
	static System.Collections.Generic.Dictionary<System.Int64,System.Int32> checkDict; // 0x18
	static System.Void Buffer(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction triggerInteraction); // 0x0749d7d0
	static System.Void Entities(UnityEngine.Vector3 position, System.Single radius, System.Collections.Generic.List<WizardGames.Soc.Common.Entity.PartEntity> list, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction triggerInteraction, System.String ignoreTag, System.String ignoreTag1); // 0x0749da34
	static System.Void .cctor(); // 0x0749de54
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SendMessageToEntityOnAnimationFinish : UnityEngine.StateMachineBehaviour
{
	System.String messageToSendToEntity; // 0x18
	System.Boolean bHasSend; // 0x20
	System.Void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, System.Int32 layerIndex); // 0x0749dfcc
	System.Void .ctor(); // 0x0749e188
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ConstructionGapConditionTest : System.Object
{
	static SocLogger <Logger>k__BackingField; // 0x0
	static System.Void .cctor(); // 0x0749e1f0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ConstructionGapModel : System.Object
{
	static SocLogger <Logger>k__BackingField; // 0x0
	WizardGames.Soc.Common.Unity.Construction.ConstructionGapConditionTest gapConditionTest; // 0x10
	WizardGames.Soc.Common.Unity.Construction.EnumGapPosType gapPosType; // 0x18
	UnityEngine.GameObject goGap; // 0x20
	WizardGames.Soc.Common.Combat.ColliderConfigSet colliderConfigSet; // 0x28
	System.UInt64 loadingId; // 0x30
	System.Int64 templateId; // 0x38
	UnityEngine.Vector3 localPosition; // 0x40
	UnityEngine.Quaternion localRotation; // 0x4c
	System.Boolean isShowNow; // 0x5c
	System.Int64 entityId; // 0x60
	WizardGames.Soc.Common.Entity.PartEntity partEntity; // 0x68
	WizardGames.Soc.SocClient.GpuInstance.GpuInstContainer gpuInstContainer; // 0x70
	System.Collections.Generic.Dictionary<UnityEngine.Renderer,UnityEngine.Material[]> _moveRecoverMats; // 0x78
	static UnityEngine.GameObject noEntityRootNode; // 0x8
	static SocLogger get_Logger(); // 0x0749e2c4
	System.Boolean get_isInLoading(); // 0x0749e34c
	System.Boolean get_HavePart(); // 0x0749e3b8
	System.Void set_LocalPosition(UnityEngine.Vector3 value); // 0x0749e424
	System.Void set_LocalRotation(UnityEngine.Quaternion value); // 0x0749e534
	System.Boolean get_IsShowNow(); // 0x0749e650
	System.Void set_IsShowNow(System.Boolean value); // 0x0749e6b4
	WizardGames.Soc.Common.Combat.ColliderConfigSet get_ColliderConfigSet(); // 0x0749e968
	System.Void .ctor(WizardGames.Soc.Common.Unity.Construction.EnumGapPosType gapPosType); // 0x0749ea38
	static System.Void OnLoadedStatic(UnityEngine.GameObject go, System.Object[] objects); // 0x0749eb10
	System.Void OnLoaded(); // 0x0749ec98
	System.Void SetupPartEntity(); // 0x0749f03c
	WizardGames.Soc.SocClient.GpuInstance.GpuInstContainer get_GpuInstContainer(); // 0x0749f37c
	System.Void GPUInstanceInit(); // 0x0749f288
	System.Void UpdateGPUInstance(); // 0x0749e798
	System.Void UpdateGapShowState(System.Boolean isShow, WizardGames.Soc.Common.Entity.PartEntity partEntity, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); // 0x0749f448
	static System.String GetPath(System.Int64 templateId); // 0x0749f7bc
	System.Void DestroyGoGap(WizardGames.Soc.Common.Entity.PartEntity _); // 0x0749f97c
	System.Void SetGapMaterialsToBuildMove(WizardGames.AssetPool.AssetPoolHandle moveMat); // 0x0749fb28
	System.Void MoveRecoverMats(); // 0x0749fd54
	static UnityEngine.GameObject get_NoEntityRootNode(); // 0x0749f128
	System.Boolean GrantShowToOutside(); // 0x074a0014
	System.Void UpdateGapShowStateWithoutEntity(System.Boolean isShow, System.Int64 entityId, System.Int64 templateId, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); // 0x074a0210
	static System.Void .cctor(); // 0x074a04f0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ConstructionGapSkin : System.Object
{
	
	System.Void OnGapStateChange(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x074a05c4
	System.Void DestroyGoGap(WizardGames.Soc.Common.Unity.Construction.EnumGapPosType gapPosType, WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x074a0690
	System.Void UpdateGPUInstance(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x074a079c
	System.Void SetGapMaterialsToBuildMove(System.Int64 entityId, WizardGames.AssetPool.AssetPoolHandle moveMat); // 0x074a084c
	System.Void MoveRecoverMats(System.Int64 entityId); // 0x074a0934
	System.Void .ctor(); // 0x074a0a0c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ConstructionGapConditionTestDrawGizmos : UnityEngine.MonoBehaviour
{
	WizardGames.Soc.Common.Component.PartGOUnityComponent partGoComponent; // 0x30
	WizardGames.Soc.Common.Unity.Utility.OBB obb; // 0x38
	System.Void OnDrawGizmos(); // 0x074a0a74
	System.Void .ctor(); // 0x074a0f84
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ConstructionGapInfoDrawInspector : UnityEngine.MonoBehaviour
{
	System.Boolean _isShowLeft; // 0x30
	System.Single _gapPosXLeft; // 0x34
	System.Single _gapPosZLeft; // 0x38
	System.Single _gapPosYLeft; // 0x3c
	System.Single _gapRotateXLeft; // 0x40
	System.Single _gapRotateYLeft; // 0x44
	System.Single _gapRotateZLeft; // 0x48
	System.Int64 _targetEntityIdLeft; // 0x50
	System.Int32 _targetGapIdLeft; // 0x58
	System.Int64 _dependEntityIdLeft; // 0x60
	System.Int32 _dependGapIdLeft; // 0x68
	System.Boolean _isShowRight; // 0x6c
	System.Single _gapPosXRight; // 0x70
	System.Single _gapPosZRight; // 0x74
	System.Single _gapPosYRight; // 0x78
	System.Single _gapRotateXRight; // 0x7c
	System.Single _gapRotateYRight; // 0x80
	System.Single _gapRotateZRight; // 0x84
	System.Int64 _targetEntityIdRight; // 0x88
	System.Int32 _targetGapIdRight; // 0x90
	System.Int64 _dependEntityIdRight; // 0x98
	System.Int32 _dependGapIdRight; // 0xa0
	System.Void UpdateGapInfo(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x074a0fec
	System.Void .ctor(); // 0x074a12d8
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Construction.EnumGapPosType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Construction.EnumGapPosType Left = 1;
	static WizardGames.Soc.Common.Unity.Construction.EnumGapPosType Right = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.GapPoint : UnityEngine.MonoBehaviour, WizardGames.Soc.Common.Unity.Construction.IConstructionCheckPoint
{
	WizardGames.Soc.Common.Unity.Construction.EnumGapPosType gapPosType; // 0x30
	System.Single outerRadius; // 0x34
	System.Single innerRadius; // 0x38
	UnityEngine.Bounds bounds; // 0x3c
	System.Type GetIndexedType(); // 0x074a1340
	System.Void OnDrawGizmosSelected(); // 0x074a13e4
	System.Void .ctor(); // 0x074a15c0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.MgrConstructionUnity : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger Log; // 0x0
	static System.Boolean DebugDraw; // 0x8
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> preloadAssets; // 0x18
	static System.Boolean ShowDebugInfo; // 0x9
	static System.String PlatFormAfterFix; // 0x10
	static SocLogger logger; // 0x18
	static System.Int32 NoPasswordPermInteractId; // 0x20
	System.Threading.Tasks.Task OnExitWorld(); // 0x074a1634
	System.String GetPveAreaNameByObjectName(System.String objectName); // 0x074a169c
	System.Boolean CheckPermissionByPos(WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask mask, System.Int64 playerEntityId, UnityEngine.Vector3 pos); // 0x074a1728
	System.Threading.Tasks.Task PreLoadTemplate(); // 0x074a1910
	System.Void .ctor(); // 0x074a1a10
	static System.Void .cctor(); // 0x074a1ac4
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Construction.MgrConstructionUnity.<PreLoadTemplate>d__19 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1; // 0x30
	System.Void MoveNext(); // 0x074a1c10
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x074a2028
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.AttractionPoint : UnityEngine.MonoBehaviour, WizardGames.Soc.Common.Unity.Construction.IConstructionCheckPoint
{
	System.String groupName; // 0x30
	System.Type GetIndexedType(); // 0x074a20cc
	System.Void .ctor(); // 0x074a2170
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ColliderInfo : UnityEngine.MonoBehaviour
{
	static WizardGames.Soc.Common.Unity.Construction.ColliderInfo.Flags FlagsNone = 0;
	static WizardGames.Soc.Common.Unity.Construction.ColliderInfo.Flags FlagsEverything = -1;
	static WizardGames.Soc.Common.Unity.Construction.ColliderInfo.Flags FlagsDefault = 15;
	WizardGames.Soc.Common.Unity.Construction.ColliderInfo.Flags flags; // 0x30
	System.Boolean HasFlag(WizardGames.Soc.Common.Unity.Construction.ColliderInfo.Flags f); // 0x074a21d8
	System.Void SetFlag(WizardGames.Soc.Common.Unity.Construction.ColliderInfo.Flags f, System.Boolean b); // 0x074a2258
	System.Void .ctor(); // 0x074a22ec
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Construction.ColliderInfo.Flags : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Construction.ColliderInfo.Flags Usable = 1;
	static WizardGames.Soc.Common.Unity.Construction.ColliderInfo.Flags Shootable = 2;
	static WizardGames.Soc.Common.Unity.Construction.ColliderInfo.Flags Melee = 4;
	static WizardGames.Soc.Common.Unity.Construction.ColliderInfo.Flags Opaque = 8;
	static WizardGames.Soc.Common.Unity.Construction.ColliderInfo.Flags Airflow = 16;
	static WizardGames.Soc.Common.Unity.Construction.ColliderInfo.Flags OnlyBlockBuildingBlock = 32;
	static WizardGames.Soc.Common.Unity.Construction.ColliderInfo.Flags Monument = 64;
	static WizardGames.Soc.Common.Unity.Construction.ColliderInfo.Flags Vehicle = 128;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ConstructionAnimationConfig : UnityEngine.MonoBehaviour
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.AnimationConfig> configs; // 0x30
	System.Void .ctor(); // 0x074a235c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.AnimationConfig : System.Object
{
	System.String clipName; // 0x10
	System.Single playSpeed; // 0x18
	System.Void .ctor(); // 0x074a23c4
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Construction.IConstructionCheckPoint : 
{
	
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ConstructionBase : UnityEngine.MonoBehaviour
{
	System.Boolean isSeparate; // 0x30
	WizardGames.Soc.Common.Construction.PartType PartType; // 0x34
	System.Int64 PartTemplateId; // 0x38
	WizardGames.Soc.Common.Entity.PartEntity parentPart; // 0x40
	System.Int64 editorId; // 0x48
	System.Int64 partGroupData; // 0x50
	System.Void .ctor(); // 0x074a2458
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ConstructionColliderInfo : UnityEngine.MonoBehaviour
{
	System.Boolean isDoor; // 0x30
	System.Void .ctor(); // 0x074a24c0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ConstructionConfig : UnityEngine.MonoBehaviour
{
	UnityEngine.Bounds bounds; // 0x30
	System.Boolean canPlaceAtMaxDistance; // 0x48
	System.Boolean grounded; // 0x49
	UnityEngine.Transform lockParent; // 0x50
	System.Int32 BallisticPropertyID; // 0x58
	System.Void OnDrawGizmosSelected(); // 0x074a2528
	System.Void .ctor(); // 0x074a2660
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.DecayPoint : UnityEngine.MonoBehaviour
{
	System.Single protection; // 0x30
	WizardGames.Soc.Common.Unity.Construction.SocketBase socket; // 0x38
	System.Void .ctor(); // 0x074a26c8
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Construction.IDeployVolumeCheckGo : 
{
	
	System.Int64 get_PartType(); // 0x054a4380
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Construction.EDeployVolumeIgnoreMasks : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Construction.EDeployVolumeIgnoreMasks Deploy = 1;
	static WizardGames.Soc.Common.Unity.Construction.EDeployVolumeIgnoreMasks Upgrade = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.DeployVolume : UnityEngine.MonoBehaviour
{
	UnityEngine.LayerMask layers; // 0x30
	WizardGames.Soc.Common.Unity.Construction.ColliderInfo.Flags ignore; // 0x34
	WizardGames.Soc.Common.Unity.Construction.DeployVolume.EntityMode entityMode; // 0x38
	WizardGames.Soc.Common.Construction.PartType[] partList; // 0x40
	WizardGames.Soc.Common.Construction.ConstructionPartType ignorePartType; // 0x48
	WizardGames.Soc.Common.Unity.Construction.EDeployVolumeIgnoreMasks funcIgnoreMask; // 0x4c
	static WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget tempTarget; // 0x0
	System.Boolean IsIgnoreCheck(System.Int32 funcIgnoreMask); // 0x074a2738
	System.Void DrawGizmosWithIns(UnityEngine.Transform partIns); // 0x074a27b8
	System.Boolean Check(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Int32 mask); // 0x074a282c
	System.Boolean Check(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, WizardGames.Soc.Common.Unity.Utility.OBB test, System.Int32 mask); // 0x074a290c
	System.Boolean CheckCapsule(System.Int64 checkerPartType, UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Single radius, System.Int32 layerMask, WizardGames.Soc.Common.Unity.Construction.DeployVolume volume, WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget& target, WizardGames.Soc.Share.Framework.EntityBase ignoreEntity); // 0x074a29fc
	System.Boolean CheckOBBWithOtherPlayer(WizardGames.Soc.Common.Unity.Utility.OBB obb, System.Int32 layerMask); // 0x074a3774
	System.Boolean CheckIfOverlapOtherCollider(WizardGames.Soc.Common.Unity.Construction.IDeployVolumeCheckGo partIns, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.String& extraInfo); // 0x074a3a58
	System.Boolean CheckIfOverlapOtherBuildingWithSimpleGameObject(WizardGames.Soc.Common.Unity.Construction.IDeployVolumeCheckGo partIns, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, UnityEngine.GameObject ignorePartGo, WizardGames.Soc.Common.Construction.PartType partType); // 0x074a3b40
	System.Boolean CheckIfOverlapOtherBuildingWithSimpleGameObject(WizardGames.Soc.Common.Unity.Construction.IDeployVolumeCheckGo partIns, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.LayerMask layerMask); // 0x074a3c4c
	System.Boolean CheckOBBWithOtherBuilding(WizardGames.Soc.Common.Unity.Construction.IDeployVolumeCheckGo partIns, WizardGames.Soc.Common.Unity.Utility.OBB obb, System.Int32 layerMask, UnityEngine.GameObject ignorePartGo, System.String& hitColliderName, WizardGames.Soc.Common.Construction.PartType partType, System.Boolean ignoreChildPart); // 0x074a3d34
	System.Collections.Generic.List<UnityEngine.Collider> GetCollideListToOtherBuilding(WizardGames.Soc.Common.Unity.Utility.OBB obb, System.Int32 layerMask); // 0x074a4078
	System.Boolean CheckCollider(System.Int64 checkerPartType, UnityEngine.Collider collider, WizardGames.Soc.Share.Framework.EntityBase ignoreEntity, UnityEngine.GameObject ignorePartGo, WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget& target, System.Boolean ignoreChildPart); // 0x074a2d3c
	System.Boolean CheckOBBWithOtherBuilding(System.Int64 checkerPartType, WizardGames.Soc.Common.Unity.Utility.OBB obb, System.Int32 layerMask, WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget& target, System.String& hitObjName, WizardGames.Soc.Share.Framework.EntityBase ignoreEntity, System.Boolean ignoreChildPart, System.String ignoreTag); // 0x074a4194
	UnityEngine.Collider CheckOBBWithPveArea(WizardGames.Soc.Common.Unity.Utility.OBB obb, System.Int32 layerMask); // 0x074a4480
	System.Boolean CheckIfOverlapOtherBuildingNoMono(System.Int64 partType, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget& target, WizardGames.Soc.Share.Framework.EntityBase ignoreEntity, System.String& hitObjName, System.Boolean ignoreChildPart, System.String ignoreTag); // 0x074a46ec
	System.Boolean CheckIfOverlapOtherPlayer(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale); // 0x074a4828
	UnityEngine.Collider CheckIfOverlapPveArea(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale); // 0x074a4918
	static System.Boolean CheckOBB(WizardGames.Soc.Common.Unity.Utility.OBB obb, System.Int32 layerMask, WizardGames.Soc.Common.Unity.Construction.DeployVolume volume, System.String& extraInfo); // 0x074a4a08
	static System.Boolean CheckBounds(UnityEngine.Bounds bounds, System.Int32 layerMask, WizardGames.Soc.Common.Unity.Construction.DeployVolume volume); // 0x074a502c
	static System.Boolean CheckFlags(System.Collections.Generic.List<UnityEngine.Collider> list, WizardGames.Soc.Common.Unity.Construction.DeployVolume volume); // 0x074a4cb4
	System.Void .ctor(); // 0x074a5158
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Construction.DeployVolume.EntityMode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Construction.DeployVolume.EntityMode ExcludeList = 0;
	static WizardGames.Soc.Common.Unity.Construction.DeployVolume.EntityMode IncludeList = 1;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.DeployVolumeCapsule : WizardGames.Soc.Common.Unity.Construction.DeployVolume
{
	UnityEngine.Vector3 center; // 0x50
	System.Single radius; // 0x5c
	System.Single height; // 0x60
	System.Void DrawGizmosWithIns(UnityEngine.Transform partIns); // 0x074a5244
	System.Boolean CheckIfOverlapOtherBuildingNoMono(System.Int64 partType, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget& target, WizardGames.Soc.Share.Framework.EntityBase ignoreEntity, System.String& hitInfo, System.Boolean ignoreChildPart, System.String ignoreTag); // 0x074a5368
	System.Void .ctor(); // 0x074a577c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.DeployVolumeEntityBoundsReverse : WizardGames.Soc.Common.Unity.Construction.DeployVolume
{
	UnityEngine.Bounds bounds; // 0x50
	System.Int32 get_layer(); // 0x074a582c
	System.Boolean CheckIfOverlapOtherBuildingNoMono(System.Int64 partType, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget& target, WizardGames.Soc.Share.Framework.EntityBase ignoreEntity, System.String& hitInfo, System.Boolean ignoreChildPart, System.String ignoreTag); // 0x074a58bc
	System.Boolean Check(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Int32 mask); // 0x074a5a8c
	System.Boolean Check(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, WizardGames.Soc.Common.Unity.Utility.OBB test, System.Int32 mask); // 0x074a631c
	System.Void .ctor(); // 0x074a640c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.DeployVolumeOBB : WizardGames.Soc.Common.Unity.Construction.DeployVolume
{
	UnityEngine.Bounds bounds; // 0x50
	System.Void DrawGizmosWithIns(UnityEngine.Transform partIns); // 0x074a6500
	WizardGames.Soc.Common.Unity.Utility.OBB GetOBB(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale); // 0x074a6644
	System.Boolean CheckIfOverlapOtherCollider(WizardGames.Soc.Common.Unity.Construction.IDeployVolumeCheckGo partIns, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.String& extraInfo); // 0x074a68b0
	System.Boolean CheckIfOverlapOtherBuildingWithSimpleGameObject(WizardGames.Soc.Common.Unity.Construction.IDeployVolumeCheckGo partIns, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, UnityEngine.GameObject ignorePartGo, WizardGames.Soc.Common.Construction.PartType partType); // 0x074a6a4c
	System.Boolean CheckIfOverlapOtherBuildingWithSimpleGameObject(WizardGames.Soc.Common.Unity.Construction.IDeployVolumeCheckGo partIns, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.LayerMask layerMask); // 0x074a6bd4
	System.Collections.Generic.List<UnityEngine.Collider> CheckIfOverlapOtherVirtualParts(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); // 0x074a6d98
	System.Boolean CheckIfOverlapOtherBuildingNoMono(System.Int64 partType, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget& target, WizardGames.Soc.Share.Framework.EntityBase ignoreEntity, System.String& hitObjName, System.Boolean ignoreChildPart, System.String ignoreTag); // 0x074a6f2c
	System.Boolean CheckIfOverlapOtherPlayer(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale); // 0x074a70d4
	UnityEngine.Collider CheckIfOverlapPveArea(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale); // 0x074a7280
	System.Boolean Check(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Int32 mask); // 0x074a7428
	System.Boolean Check(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, WizardGames.Soc.Common.Unity.Utility.OBB test, System.Int32 mask); // 0x074a76dc
	System.Void .ctor(); // 0x074a7990
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.DirectionProperties : UnityEngine.MonoBehaviour
{
	static System.Single radius = 200;
	UnityEngine.Bounds bounds; // 0x30
	WizardGames.Soc.Common.Unity.Construction.DirectionPropertiesRuntime GenerateRuntimeProperty(); // 0x074a7a84
	System.Void .ctor(); // 0x074a7d20
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.DirectionPropertiesRuntime : System.Object
{
	UnityEngine.Bounds bounds; // 0x10
	UnityEngine.Quaternion localRotation; // 0x28
	UnityEngine.Vector3 localCenter; // 0x38
	System.Void .ctor(UnityEngine.Bounds bounds, UnityEngine.Vector3 localCenter, UnityEngine.Quaternion localRotation); // 0x074a7c18
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.GroundCheckPoint : UnityEngine.MonoBehaviour
{
	System.Boolean inTerrain; // 0x30
	System.Void OnDrawGizmos(); // 0x074a7de0
	System.Void .ctor(); // 0x074a7e80
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.LerpBetweenPointsBoolBehavior : UnityEngine.MonoBehaviour
{
	WizardGames.Soc.Common.Unity.Construction.LerpBetweenPointsBool lerpBetweenPointsBool; // 0x30
	UnityEngine.Vector3 OffsetPoseLocal; // 0x38
	System.Single Speed; // 0x44
	System.Void Awake(); // 0x074a7ee8
	System.Void SetAtOffset(System.Boolean should); // 0x074a80f4
	System.Void OnDrawGizmosSelected(); // 0x074a83b4
	System.Void OnDestroy(); // 0x074a8468
	System.Void .ctor(); // 0x074a84e4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.LerpBetweenPointsBool : System.Object
{
	UnityEngine.Vector3 offsetPosLocal; // 0x10
	System.Single speed; // 0x1c
	System.Int32 updateRate; // 0x20
	UnityEngine.Vector3 targetPos; // 0x24
	UnityEngine.Vector3 initialPos; // 0x30
	UnityEngine.Transform targetTransform; // 0x40
	System.Action onSwitchOn; // 0x48
	System.Action onSwitchOff; // 0x50
	WizardGames.Soc.Common.TimerWheel.TimerCallback UpdateAction; // 0x58
	System.Int64 timer; // 0x60
	System.Boolean isMoving; // 0x68
	System.Action<System.Boolean> OnTimerStatusChanged; // 0x70
	System.Boolean get_IsMoving(); // 0x074a854c
	System.Void set_IsMoving(System.Boolean value); // 0x074a85b0
	System.Void .ctor(UnityEngine.Transform target, UnityEngine.Vector3 offsetPos, System.Single lerpSpeed); // 0x074a7fc0
	System.Void Finalize(); // 0x074a8638
	System.Void SetAtOffset(System.Boolean should, System.Boolean bImmediate); // 0x074a817c
	System.Void CancelTimer(); // 0x074a8718
	System.Void Update(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x074a87dc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.PreventBuildingConfig : UnityEngine.MonoBehaviour
{
	WizardGames.Soc.Common.Unity.Construction.DeployVolume.EntityMode entityMode; // 0x30
	WizardGames.Soc.Common.Construction.PartType[] partList; // 0x38
	System.Void .ctor(); // 0x074a8ac4
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Construction.SnapPanelType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Construction.SnapPanelType None = 0;
	static WizardGames.Soc.Common.Unity.Construction.SnapPanelType FloorUndersideUp = 1;
	static WizardGames.Soc.Common.Unity.Construction.SnapPanelType FloorUndersideDown = 2;
	static WizardGames.Soc.Common.Unity.Construction.SnapPanelType Foundation = 3;
	static WizardGames.Soc.Common.Unity.Construction.SnapPanelType WallFront = 4;
	static WizardGames.Soc.Common.Unity.Construction.SnapPanelType WallBack = 5;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SnapOffset : System.Object
{
	WizardGames.Soc.Common.Unity.Construction.SnapPanelType type; // 0x10
	System.Single offset; // 0x14
	System.Void .ctor(); // 0x074a8b2c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SnapPanel : UnityEngine.MonoBehaviour
{
	WizardGames.Soc.Common.Unity.Construction.SnapPanelType type; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.SnapOffset> offsetList; // 0x38
	System.Boolean TrySnapOn(WizardGames.Soc.Common.Unity.Construction.SnapPanelType type, System.Single& snapOnOffset); // 0x074a8b94
	System.Void .ctor(); // 0x074a8d2c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SnapPanel.<>c__DisplayClass3_0 : System.Object
{
	WizardGames.Soc.Common.Unity.Construction.SnapPanelType type; // 0x10
	System.Void .ctor(); // 0x074a8cc4
	System.Boolean <TrySnapOn>b__0(WizardGames.Soc.Common.Unity.Construction.SnapOffset x); // 0x074a8de0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.TransformationPartCheckBound : UnityEngine.MonoBehaviour
{
	UnityEngine.Bounds bounds; // 0x30
	System.Void OnDrawGizmosSelected(); // 0x074a8e6c
	System.Void .ctor(); // 0x074a8f90
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.WallCornerDisableBuildConfig : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x074a8ff8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ConstructionConditionalModel : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	System.Boolean isDefaultPart; // 0x30
	System.Int32 prefabId; // 0x34
	WizardGames.Soc.Common.Unity.Construction.ModelConditionTest[] conditions; // 0x38
	System.Int32 id; // 0x40
	System.Int64 gpuKey; // 0x48
	System.String get_Path(); // 0x074a9060
	System.Void Init(System.Int32 id); // 0x074978dc
	System.Void ShowInEditor(UnityEngine.Transform root); // 0x07497ac4
	System.Boolean ShowSync(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x07497c14
	System.Boolean RunTests(WizardGames.Soc.Common.Entity.PartEntity entity); // 0x074a9228
	System.Int64 GetGpuInstanceKey(); // 0x074a92f8
	System.Void .ctor(); // 0x074a9390
	static System.Void .cctor(); // 0x074a93f8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ModelConditionTest : UnityEngine.MonoBehaviour
{
	
	System.Boolean DoTestNew(WizardGames.Soc.Common.Entity.PartEntity cb); // 0x074a94cc
	static System.Boolean CheckSocketOccupied(WizardGames.Soc.Common.Entity.PartEntity ent, System.String socket); // 0x074a9544
	static System.Boolean CheckSocketOccupiedNew(WizardGames.Soc.Common.Entity.PartEntity ent, System.String socket); // 0x074a95f8
	System.Void .ctor(); // 0x074a9670
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ModelConditionTestAlwaysTrue : WizardGames.Soc.Common.Unity.Construction.ModelConditionTest
{
	
	System.Boolean DoTestNew(WizardGames.Soc.Common.Entity.PartEntity cb); // 0x074a96d8
	System.Void .ctor(); // 0x074a9750
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ModelConditionTestFalse : WizardGames.Soc.Common.Unity.Construction.ModelConditionTest
{
	WizardGames.Soc.Common.Unity.Construction.ConstructionConditionalModel reference; // 0x30
	System.Boolean DoTestNew(WizardGames.Soc.Common.Entity.PartEntity cb); // 0x074a97b4
	System.Void .ctor(); // 0x074a982c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ModelConditionTestFoundationSide : WizardGames.Soc.Common.Unity.Construction.ModelConditionTest
{
	static System.String square_south = "Foundation/SocketGroup/foundation-top/1";
	static System.String square_north = "Foundation/SocketGroup/foundation-top/3";
	static System.String square_west = "Foundation/SocketGroup/foundation-top/2";
	static System.String square_east = "Foundation/SocketGroup/foundation-top/4";
	static System.String triangle_south = "FoundationTriangle/SocketGroup/foundation-top/1";
	static System.String triangle_northwest = "FoundationTriangle/SocketGroup/foundation-top/2";
	static System.String triangle_northeast = "FoundationTriangle/SocketGroup/foundation-top/3";
	System.String socket; // 0x30
	System.Boolean isTriangle; // 0x38
	System.Void OnDrawGizmosSelected(); // 0x074a9890
	System.Void Start(); // 0x074a9970
	System.Boolean DoTestNew(WizardGames.Soc.Common.Entity.PartEntity ent); // 0x074a9bd4
	System.Void .ctor(); // 0x074a9c4c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRampHigh : WizardGames.Soc.Common.Unity.Construction.ModelConditionTest
{
	static System.String socket = "Ramp/SocketGroup/block-male/1";
	System.Void OnDrawGizmosSelected(); // 0x074a9cdc
	System.Boolean DoTestNew(WizardGames.Soc.Common.Entity.PartEntity ent); // 0x074a9dbc
	System.Void .ctor(); // 0x074a9e34
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRampLow : WizardGames.Soc.Common.Unity.Construction.ModelConditionTest
{
	static System.String socket = "Ramp/SocketGroup/block-male/1";
	System.Void OnDrawGizmosSelected(); // 0x074a9e98
	System.Boolean DoTestNew(WizardGames.Soc.Common.Entity.PartEntity ent); // 0x074a9f78
	System.Void .ctor(); // 0x074a9ff0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofBottom : WizardGames.Soc.Common.Unity.Construction.ModelConditionTest
{
	static System.String roof_square = "Roof/";
	static System.String roof_triangle = "RoofTriangle/";
	static System.String socket_bot_right = "SocketGroup/neighbour/3";
	static System.String socket_bot_left = "SocketGroup/neighbour/4";
	static System.String socket_top_right = "SocketGroup/neighbour/5";
	static System.String socket_top_left = "SocketGroup/neighbour/6";
	static System.String[] sockets_bot_right; // 0x0
	static System.String[] sockets_bot_left; // 0x8
	System.Void OnDrawGizmosSelected(); // 0x074aa054
	System.Boolean DoTestNew(WizardGames.Soc.Common.Entity.PartEntity ent); // 0x074aa134
	System.Void .ctor(); // 0x074aa1ac
	static System.Void .cctor(); // 0x074aa210
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofLeft : WizardGames.Soc.Common.Unity.Construction.ModelConditionTest
{
	WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofLeft.AngleType angle; // 0x30
	WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofLeft.ShapeType shape; // 0x34
	static System.String roof_square = "Roof/";
	static System.String roof_triangle = "RoofTriangle/";
	static System.String socket_right = "SocketGroup/neighbour/3";
	static System.String socket_left = "SocketGroup/neighbour/4";
	static System.String[] sockets_left; // 0x0
	System.Boolean get_IsConvex(); // 0x074aa384
	System.Boolean get_IsConcave(); // 0x074aa3f0
	System.Void OnDrawGizmosSelected(); // 0x074aa45c
	System.Boolean DoTestNew(WizardGames.Soc.Common.Entity.PartEntity cb); // 0x074aa53c
	System.Void .ctor(); // 0x074aa5b4
	static System.Void .cctor(); // 0x074aa620
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofLeft.AngleType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofLeft.AngleType None = -1;
	static WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofLeft.AngleType Straight = 0;
	static WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofLeft.AngleType Convex60 = 60;
	static WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofLeft.AngleType Convex90 = 90;
	static WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofLeft.AngleType Convex120 = 120;
	static WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofLeft.AngleType Concave30 = -30;
	static WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofLeft.AngleType Concave60 = -60;
	static WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofLeft.AngleType Concave90 = -90;
	static WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofLeft.AngleType Concave120 = -120;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofLeft.ShapeType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofLeft.ShapeType Any = -1;
	static WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofLeft.ShapeType Square = 0;
	static WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofLeft.ShapeType Triangle = 1;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofRight : WizardGames.Soc.Common.Unity.Construction.ModelConditionTest
{
	WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofRight.AngleType angle; // 0x30
	WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofRight.ShapeType shape; // 0x34
	static System.String roof_square = "Roof/";
	static System.String roof_triangle = "RoofTriangle/";
	static System.String socket_right = "SocketGroup/neighbour/3";
	static System.String socket_left = "SocketGroup/neighbour/4";
	static System.String[] sockets_right; // 0x0
	System.Boolean get_IsConvex(); // 0x074aa704
	System.Boolean get_IsConcave(); // 0x074aa770
	System.Void OnDrawGizmosSelected(); // 0x074aa7dc
	System.Boolean DoTestNew(WizardGames.Soc.Common.Entity.PartEntity entity); // 0x074aa8bc
	System.Void .ctor(); // 0x074aa934
	static System.Void .cctor(); // 0x074aa9a0
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofRight.AngleType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofRight.AngleType None = -1;
	static WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofRight.AngleType Straight = 0;
	static WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofRight.AngleType Convex60 = 60;
	static WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofRight.AngleType Convex90 = 90;
	static WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofRight.AngleType Convex120 = 120;
	static WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofRight.AngleType Concave30 = -30;
	static WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofRight.AngleType Concave60 = -60;
	static WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofRight.AngleType Concave90 = -90;
	static WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofRight.AngleType Concave120 = -120;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofRight.ShapeType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofRight.ShapeType Any = -1;
	static WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofRight.ShapeType Square = 0;
	static WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofRight.ShapeType Triangle = 1;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofTop : WizardGames.Soc.Common.Unity.Construction.ModelConditionTest
{
	static System.String roof_square = "Roof/";
	static System.String roof_triangle = "RoofTriangle/";
	static System.String socket_bot_right = "SocketGroup/neighbour/3";
	static System.String socket_bot_left = "SocketGroup/neighbour/4";
	static System.String socket_top_right = "SocketGroup/neighbour/5";
	static System.String socket_top_left = "SocketGroup/neighbour/6";
	static System.String[] sockets_top_right; // 0x0
	static System.String[] sockets_top_left; // 0x8
	System.Void OnDrawGizmosSelected(); // 0x074aaa84
	System.Boolean DoTestNew(WizardGames.Soc.Common.Entity.PartEntity ent); // 0x074aab64
	System.Void .ctor(); // 0x074aabdc
	static System.Void .cctor(); // 0x074aac40
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ModelConditionTestRoofTriangle : WizardGames.Soc.Common.Unity.Construction.ModelConditionTest
{
	static System.String socketName = "Roof/SocketGroup/wall-female/1";
	System.Boolean DoTestNew(WizardGames.Soc.Common.Entity.PartEntity ent); // 0x074aadb4
	System.Void .ctor(); // 0x074aae2c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ModelConditionTestSpiralStairs : WizardGames.Soc.Common.Unity.Construction.ModelConditionTest
{
	static System.String stairs_socket_female = "SocketGroup/stair-female/1";
	static System.String[] stairs_sockets_female; // 0x0
	static System.String floor_socket_female = "SocketGroup/floor-female/1";
	static System.String[] floor_sockets_female; // 0x8
	System.Void OnDrawGizmosSelected(); // 0x074aae90
	System.Boolean DoTestNew(WizardGames.Soc.Common.Entity.PartEntity ent); // 0x074aaf74
	System.Void .ctor(); // 0x074aafec
	static System.Void .cctor(); // 0x074ab050
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ModelConditionTestTrue : WizardGames.Soc.Common.Unity.Construction.ModelConditionTest
{
	WizardGames.Soc.Common.Unity.Construction.ConstructionConditionalModel reference; // 0x30
	System.Boolean DoTestNew(WizardGames.Soc.Common.Entity.PartEntity cb); // 0x074ab1c4
	System.Void .ctor(); // 0x074ab248
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ModelConditionTestWall : WizardGames.Soc.Common.Unity.Construction.ModelConditionTest
{
	
	System.Boolean DoTestNew(WizardGames.Soc.Common.Entity.PartEntity ent); // 0x074ab2ac
	System.Void .ctor(); // 0x074ab40c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ModelConditionTestWallAttachBottom : WizardGames.Soc.Common.Unity.Construction.ModelConditionTest
{
	static System.String socket = "SocketGroup/wall-male/1";
	System.Boolean DoTestNew(WizardGames.Soc.Common.Entity.PartEntity ent); // 0x074ab470
	static System.Boolean CheckConditionNew(WizardGames.Soc.Common.Entity.PartEntity ent); // 0x074ab4e8
	System.Void .ctor(); // 0x074ab54c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ModelConditionTestWallAttachMid : WizardGames.Soc.Common.Unity.Construction.ModelConditionTest
{
	
	System.Boolean DoTestNew(WizardGames.Soc.Common.Entity.PartEntity ent); // 0x074ab5b0
	System.Void .ctor(); // 0x074ab6ac
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ModelConditionTestWallAttachTop : WizardGames.Soc.Common.Unity.Construction.ModelConditionTest
{
	static System.String socket = "SocketGroup/wall-female/1";
	System.Boolean DoTestNew(WizardGames.Soc.Common.Entity.PartEntity ent); // 0x074ab710
	static System.Boolean CheckConditionNew(WizardGames.Soc.Common.Entity.PartEntity ent); // 0x074ab648
	System.Void .ctor(); // 0x074ab7a8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ModelConditionTestWallCornerLeft : WizardGames.Soc.Common.Unity.Construction.ModelConditionTest
{
	static System.String socket = "SocketGroup/stability/2";
	System.Boolean DoTestNew(WizardGames.Soc.Common.Entity.PartEntity ent); // 0x074ab80c
	System.Void .ctor(); // 0x074ab884
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ModelConditionTestWallCornerRight : WizardGames.Soc.Common.Unity.Construction.ModelConditionTest
{
	static System.String socket = "SocketGroup/stability/1";
	System.Boolean DoTestNew(WizardGames.Soc.Common.Entity.PartEntity ent); // 0x074ab8e8
	System.Void .ctor(); // 0x074ab960
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ModelConditionTestWallTriangleLeft : WizardGames.Soc.Common.Unity.Construction.ModelConditionTest
{
	static System.String socket_1 = "Wall/SocketGroup/wall-female/1";
	static System.String socket_2 = "Wall/SocketGroup/floor-female/1";
	static System.String socket_3 = "Wall/SocketGroup/floor-female/2";
	static System.String socket_4 = "Wall/SocketGroup/floor-female/3";
	static System.String socket_5 = "Wall/SocketGroup/floor-female/4";
	static System.String socket_6 = "Wall/SocketGroup/stability/1";
	static System.String socket = "Wall/SocketGroup/neighbour/1";
	System.Boolean DoTestNew(WizardGames.Soc.Common.Entity.PartEntity ent); // 0x074ab9c4
	static System.Boolean CheckConditionNew(WizardGames.Soc.Common.Entity.PartEntity ent); // 0x074ab344
	System.Void .ctor(); // 0x074aba3c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ModelConditionTestWallTriangleRight : WizardGames.Soc.Common.Unity.Construction.ModelConditionTest
{
	static System.String socket_1 = "Wall/SocketGroup/wall-female/1";
	static System.String socket_2 = "Wall/SocketGroup/floor-female/1";
	static System.String socket_3 = "Wall/SocketGroup/floor-female/2";
	static System.String socket_4 = "Wall/SocketGroup/floor-female/3";
	static System.String socket_5 = "Wall/SocketGroup/floor-female/4";
	static System.String socket_6 = "Wall/SocketGroup/stability/2";
	static System.String socket = "Wall/SocketGroup/neighbour/1";
	static System.Boolean CheckCondition(WizardGames.Soc.Common.Entity.PartEntity ent); // 0x074abaa0
	System.Boolean DoTestNew(WizardGames.Soc.Common.Entity.PartEntity ent); // 0x074abc14
	static System.Boolean CheckConditionNew(WizardGames.Soc.Common.Entity.PartEntity ent); // 0x074ab3a8
	System.Void .ctor(); // 0x074abc8c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.PartGoConfig : WizardGames.Soc.Common.Unity.GoConfig
{
	static System.Collections.Generic.Dictionary<System.String,System.String> namePointConfig; // 0x0
	static System.Collections.Generic.Dictionary<System.Type,WizardGames.Soc.Common.Unity.MonoBehaviourConfigItem> monoBehaviourConfig; // 0x8
	System.Void .ctor(UnityEngine.GameObject gameObject); // 0x074abcf0
	System.Collections.Generic.Dictionary<System.String,System.String> get_NamePointConfig(); // 0x074abd94
	System.Collections.Generic.Dictionary<System.Type,WizardGames.Soc.Common.Unity.MonoBehaviourConfigItem> get_MonoBehaviourConfig(); // 0x074abe24
	static System.Void .cctor(); // 0x074abeb4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ConstructionSocket : WizardGames.Soc.Common.Unity.Construction.SocketBase
{
	WizardGames.Soc.Common.Construction.EConstructionSocketType socketType; // 0xd8
	System.Int32 rotationDegrees; // 0xdc
	System.Int32 rotationOffset; // 0xe0
	System.Boolean restrictPlacementRotation; // 0xe4
	System.Boolean restrictPlacementAngle; // 0xe5
	System.Single angleAllowed; // 0xe8
	System.Boolean needFixRotation; // 0xec
	UnityEngine.GameObject wallCheckSocketNode; // 0xf0
	WizardGames.Soc.Common.Unity.Construction.ConstructionSocket combineLinkSocket; // 0xf8
	WizardGames.Soc.Common.Unity.Construction.ConstructionSocket shareCapacitySocket; // 0x100
	WizardGames.Soc.Common.Unity.Construction.ConstructionSocket switchToSocket; // 0x108
	System.Single support; // 0x110
	System.Boolean ignorePromixity; // 0x114
	System.Void DrawGizmosWithIns(UnityEngine.Transform partIns); // 0x074ac514
	System.Boolean TestTarget(WizardGames.Soc.Common.Unity.Construction.BuildingTarget target); // 0x074ac8bc
	WizardGames.Soc.Common.Construction.SocketConfigData ExportConfigData(); // 0x074aca60
	System.Boolean IsCompatible(WizardGames.Soc.Common.Unity.Construction.SocketBase socket); // 0x074acda8
	System.Boolean CanConnect(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, WizardGames.Soc.Common.Unity.Construction.SocketBase socket, UnityEngine.Vector3 socketPosition, UnityEngine.Quaternion socketRotation); // 0x074ad010
	System.Boolean CanConnect(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, WizardGames.Soc.Common.Unity.Construction.SocketBase socket, UnityEngine.Vector3 socketPosition, UnityEngine.Quaternion socketRotation, UnityEngine.Vector3 socketScale); // 0x074ad7e4
	System.Void .ctor(); // 0x074ae00c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ConstructionSocket_Elevator : WizardGames.Soc.Common.Unity.Construction.ConstructionSocket
{
	System.Int32 MaxFloor; // 0x118
	WizardGames.Soc.Common.Construction.SocketConfigData ExportConfigData(); // 0x074ae12c
	System.Boolean CanConnect(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, WizardGames.Soc.Common.Unity.Construction.SocketBase socket, UnityEngine.Vector3 socketPosition, UnityEngine.Quaternion socketRotation, UnityEngine.Vector3 socketScale); // 0x074ae1ac
	System.Void .ctor(); // 0x074ae494
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.NeighbourSocket : WizardGames.Soc.Common.Unity.Construction.SocketBase
{
	
	System.Void DrawGizmosWithIns(UnityEngine.Transform partIns); // 0x074ae500
	System.Boolean TestTarget(WizardGames.Soc.Common.Unity.Construction.BuildingTarget target); // 0x074ae5cc
	WizardGames.Soc.Common.Construction.SocketConfigData ExportConfigData(); // 0x074ae65c
	System.Boolean CanConnect(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, WizardGames.Soc.Common.Unity.Construction.SocketBase socket, UnityEngine.Vector3 socketPosition, UnityEngine.Quaternion socketRotation, UnityEngine.Vector3 socketScale); // 0x074ae6d4
	System.Void .ctor(); // 0x074aec98
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SocketBase : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	System.Boolean male; // 0x30
	System.Boolean maleDummy; // 0x31
	System.Boolean female; // 0x32
	System.Boolean femaleDummy; // 0x33
	System.Boolean monogamous; // 0x34
	UnityEngine.Vector3 worldForward; // 0x38
	UnityEngine.Vector3 localPosition; // 0x44
	UnityEngine.Vector3 localScale; // 0x50
	UnityEngine.Quaternion localRotation; // 0x5c
	System.String fullName; // 0x70
	System.String hierachyName; // 0x78
	System.UInt32 prefabID; // 0x80
	System.Int32 instanceID; // 0x84
	WizardGames.Soc.Common.Construction.ESocketSide SocketSide; // 0x88
	System.Boolean isServer; // 0x8c
	UnityEngine.Transform socketModParentNode; // 0x90
	WizardGames.Soc.Common.Unity.Construction.SocketMod[] socketMods; // 0x98
	System.Boolean needPermission; // 0xa0
	UnityEngine.Vector3 selectSize; // 0xa4
	UnityEngine.Vector3 selectCenter; // 0xb0
	System.String socketName; // 0xc0
	System.Int32 socketId; // 0xc8
	WizardGames.Soc.Common.Entity.PartEntity ParentConstruction; // 0xd0
	static System.Boolean flagDoCheckFalseNotice; // 0x8
	UnityEngine.Quaternion get_Rotation(); // 0x074aed20
	UnityEngine.Vector3 get_Position(); // 0x074aed98
	System.Void Init(); // 0x074aee10
	WizardGames.Soc.Common.Construction.SocketConfigData ExportConfigData(); // 0x074acc14
	WizardGames.Soc.Common.Unity.Construction.SocketModConfigData[] GetSocketModConfigDatas(); // 0x074aef3c
	WizardGames.Soc.Common.Unity.Construction.SocketModNoMono[] GetSocketModsNoMono(); // 0x074af0ec
	static System.String GetRecursiveName(UnityEngine.Transform transform, System.String strPrefix, System.String strEndName); // 0x074af364
	UnityEngine.Vector3 GetSelectPivot(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); // 0x074af634
	WizardGames.Soc.Common.Unity.Utility.OBB GetSelectBounds(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale); // 0x074ae994
	System.Boolean TestTarget(WizardGames.Soc.Common.Unity.Construction.BuildingTarget target); // 0x074ac990
	System.Boolean IsCompatible(WizardGames.Soc.Common.Unity.Construction.SocketBase socket); // 0x074aced4
	System.Boolean CanConnect(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, WizardGames.Soc.Common.Unity.Construction.SocketBase socket, UnityEngine.Vector3 socketPosition, UnityEngine.Quaternion socketRotation); // 0x074ad6cc
	System.Boolean CanConnect(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, WizardGames.Soc.Common.Unity.Construction.SocketBase socket, UnityEngine.Vector3 socketPosition, UnityEngine.Quaternion socketRotation, UnityEngine.Vector3 socketScale); // 0x074adec0
	WizardGames.Soc.Common.Unity.Construction.Placement DoPlacement(WizardGames.Soc.Common.Unity.Construction.BuildingTarget& target); // 0x074af748
	System.Void OnDrawGizmosSelected(); // 0x074af948
	System.Void DrawGizmosWithIns(UnityEngine.Transform partIns); // 0x074afa88
	static System.Void DoCheckFalseNotice(WizardGames.Soc.Common.Unity.Construction.SocketBase baseNode, WizardGames.Soc.Common.Unity.Construction.SocketMod mod); // 0x074afafc
	System.Void .ctor(); // 0x074ae0a4
	static System.Void .cctor(); // 0x074afc60
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SocketFree : WizardGames.Soc.Common.Unity.Construction.SocketBase
{
	static System.Boolean configUseAutoAbsorb; // 0x0
	UnityEngine.Vector3 idealPlacementNormal; // 0xd8
	System.Boolean useTargetNormal; // 0xe4
	System.Boolean blendAimAngle; // 0xe5
	System.Int32 targetNormalRange; // 0xe8
	System.Single autoAbsorbWidth; // 0xec
	System.Single autoAbsorbLength; // 0xf0
	System.Collections.Generic.List<UnityEngine.RaycastHit> hits; // 0xf8
	WizardGames.Soc.Common.Construction.SocketConfigData ExportConfigData(); // 0x074afd44
	System.Void DrawGizmosWithIns(UnityEngine.Transform partIns); // 0x074afe04
	System.Boolean TestTarget(WizardGames.Soc.Common.Unity.Construction.BuildingTarget target); // 0x074b0044
	System.Void .ctor(); // 0x074b00d8
	static System.Void .cctor(); // 0x074b0200
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SocketLock : WizardGames.Soc.Common.Unity.Construction.SocketBase
{
	UnityEngine.Vector3 idealPlacementNormal; // 0xd8
	System.Boolean useTargetNormal; // 0xe4
	System.Boolean blendAimAngle; // 0xe5
	System.Void DrawGizmosWithIns(UnityEngine.Transform partIns); // 0x074b024c
	System.Void .ctor(); // 0x074b0470
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.StabilitySocket : WizardGames.Soc.Common.Unity.Construction.SocketBase
{
	System.Single support; // 0xd8
	System.Void DrawGizmosWithIns(UnityEngine.Transform partIns); // 0x074b0540
	System.Boolean TestTarget(WizardGames.Soc.Common.Unity.Construction.BuildingTarget target); // 0x074b060c
	WizardGames.Soc.Common.Construction.SocketConfigData ExportConfigData(); // 0x074b069c
	System.Boolean CanConnect(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, WizardGames.Soc.Common.Unity.Construction.SocketBase socket, UnityEngine.Vector3 socketPosition, UnityEngine.Quaternion socketRotation, UnityEngine.Vector3 socketScale); // 0x074b071c
	System.Void .ctor(); // 0x074b09dc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.TerrainSocket : WizardGames.Soc.Common.Unity.Construction.SocketBase
{
	System.Single placementHeight; // 0xd8
	System.Boolean alignToNormal; // 0xdc
	System.Void DrawGizmosWithIns(UnityEngine.Transform partIns); // 0x074b0a6c
	WizardGames.Soc.Common.Construction.SocketConfigData ExportConfigData(); // 0x074b0eac
	System.Boolean TestTarget(WizardGames.Soc.Common.Unity.Construction.BuildingTarget target); // 0x074b0f34
	WizardGames.Soc.Common.Unity.Construction.Placement DoPlacement(WizardGames.Soc.Common.Unity.Construction.BuildingTarget& target); // 0x074b0fc8
	System.Void .ctor(); // 0x074b13dc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SocketMod : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.Construction.SocketBase baseSocket; // 0x30
	WizardGames.Soc.Common.Construction.SocketModType get_SocketModType(); // 0x074b1464
	System.String GetCheckFailedInfo(); // 0x074b14c8
	System.Void ModifyPlacement(WizardGames.Soc.Common.Unity.Construction.Placement place); // 0x074b17f0
	System.Void SetValue(System.String value); // 0x074b1864
	WizardGames.Soc.Common.Unity.Construction.SocketModConfigData ExportConfigData(); // 0x074b18d8
	System.String GetValue(); // 0x074b1a08
	UnityEngine.Vector3 GetInsPosition(WizardGames.Soc.Common.Entity.PartEntity InsGoTrans); // 0x074b1a6c
	UnityEngine.Quaternion GetInsRotation(WizardGames.Soc.Common.Entity.PartEntity InsGoTrans); // 0x074b1c0c
	UnityEngine.Vector3 GetInsScale(WizardGames.Soc.Common.Entity.PartEntity InsGoTrans); // 0x074b1d38
	System.Void OnDrawGizmosSelected(); // 0x074b1e18
	System.Void DrawGizmosWithIns(UnityEngine.Transform partIns); // 0x074b1f58
	System.Void .ctor(); // 0x074b1fcc
	static System.Void .cctor(); // 0x074b2034
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SocketModAngleCheck : WizardGames.Soc.Common.Unity.Construction.SocketMod
{
	System.Boolean wantsAngle; // 0x38
	UnityEngine.Vector3 worldNormal; // 0x3c
	System.Single withinDegrees; // 0x48
	WizardGames.Soc.Common.Construction.SocketModType get_SocketModType(); // 0x074b2108
	System.Void DrawGizmosWithIns(UnityEngine.Transform partIns); // 0x074b216c
	WizardGames.Soc.Common.Unity.Construction.SocketModConfigData ExportConfigData(); // 0x074b2294
	System.Void .ctor(); // 0x074b2324
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SocketModAreaCheck : WizardGames.Soc.Common.Unity.Construction.SocketMod
{
	UnityEngine.Bounds bounds; // 0x38
	UnityEngine.LayerMask layerMask; // 0x50
	System.Boolean wantsInside; // 0x54
	WizardGames.Soc.Common.Construction.ConstructionPartType ignorePartType; // 0x58
	System.Boolean getGroundLayerFromHitDetail; // 0x5c
	WizardGames.Soc.Common.Construction.SocketModType get_SocketModType(); // 0x074b2404
	System.Void DrawGizmosWithIns(UnityEngine.Transform partIns); // 0x074b2468
	WizardGames.Soc.Common.Unity.Construction.SocketModConfigData ExportConfigData(); // 0x074b256c
	System.Void .ctor(); // 0x074b260c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SocketModAttraction : WizardGames.Soc.Common.Unity.Construction.SocketMod
{
	static SocLogger logger; // 0x0
	System.Single outerRadius; // 0x38
	System.Single innerRadius; // 0x3c
	System.String groupName; // 0x40
	System.Boolean lockRotation; // 0x48
	System.Boolean ignoreRotationForRadiusCheck; // 0x49
	System.Int64 lastLockedEntity; // 0x50
	UnityEngine.Vector3 lastLockedEntityPos; // 0x58
	System.Single get_lockDistanceMul(); // 0x074b2754
	System.Single get_lockAttraction(); // 0x074b283c
	System.Single get_lockSwitchDistanceDelta(); // 0x074b2924
	WizardGames.Soc.Common.Construction.SocketModType get_SocketModType(); // 0x074b2a0c
	System.Void DrawGizmosWithIns(UnityEngine.Transform partIns); // 0x074b2a70
	System.Void ModifyPlacement(WizardGames.Soc.Common.Unity.Construction.Placement place); // 0x074b2bdc
	System.Void TryApplyPoint(WizardGames.Soc.Common.Entity.PartEntity cb, WizardGames.Soc.Common.Unity.Construction.AttractionPoint point, System.Single& closestLockDist, UnityEngine.Vector3 originalPlace, WizardGames.Soc.Common.Unity.Construction.Placement& place, System.Boolean isBindDist); // 0x074b3610
	System.Void ModifyByPointIgnoreRotation(WizardGames.Soc.Common.Entity.PartEntity cb, WizardGames.Soc.Common.Unity.Construction.AttractionPoint point, System.Single& closestLockDist, UnityEngine.Vector3 originalPlace, WizardGames.Soc.Common.Unity.Construction.Placement& place); // 0x074b39a8
	System.Void ModifyByPoint(WizardGames.Soc.Common.Entity.PartEntity cb, WizardGames.Soc.Common.Unity.Construction.AttractionPoint point, System.Single fraction, WizardGames.Soc.Common.Unity.Construction.Placement& place); // 0x074b3b94
	WizardGames.Soc.Common.Unity.Construction.SocketModConfigData ExportConfigData(); // 0x074b42e0
	System.Void .ctor(); // 0x074b4374
	static System.Void .cctor(); // 0x074b442c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SocketModInWater : WizardGames.Soc.Common.Unity.Construction.SocketMod
{
	System.Boolean wantsInWater; // 0x38
	WizardGames.Soc.Common.Construction.SocketModType get_SocketModType(); // 0x074b4500
	System.Void DrawGizmosWithIns(UnityEngine.Transform partIns); // 0x074b4564
	System.Boolean IsInWater(UnityEngine.Vector3 vPoint); // 0x074b467c
	WizardGames.Soc.Common.Unity.Construction.SocketModConfigData ExportConfigData(); // 0x074b4aa0
	System.Void .ctor(); // 0x074b4b18
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SocketModLockSlot : WizardGames.Soc.Common.Unity.Construction.SocketMod
{
	WizardGames.Soc.Common.Unity.Construction.SocketBase baseSocket; // 0x38
	WizardGames.Soc.Common.Construction.SocketModType get_SocketModType(); // 0x074b4ba8
	System.Void ModifyPlacement(WizardGames.Soc.Common.Unity.Construction.Placement place); // 0x074b4c0c
	System.Void .ctor(); // 0x074b4c80
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SocketModNotInDoor : WizardGames.Soc.Common.Unity.Construction.SocketMod
{
	UnityEngine.Bounds bounds; // 0x38
	WizardGames.Soc.Common.Construction.SocketModType get_SocketModType(); // 0x074b4d08
	System.Void DrawGizmosWithIns(UnityEngine.Transform partIns); // 0x074b4d6c
	WizardGames.Soc.Common.Unity.Construction.SocketModConfigData ExportConfigData(); // 0x074b4e60
	System.Void .ctor(); // 0x074b4ee0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SocketModSphereCheck : WizardGames.Soc.Common.Unity.Construction.SocketMod
{
	System.Single sphereRadius; // 0x38
	System.Boolean wantsCollide; // 0x3c
	UnityEngine.LayerMask layerMask; // 0x40
	WizardGames.Soc.Common.Construction.ConstructionPartType ignorePartType; // 0x44
	System.Boolean isCollideDebrisWall; // 0x48
	WizardGames.Soc.Common.Construction.SocketModType get_SocketModType(); // 0x074b5020
	System.Void DrawGizmosWithIns(UnityEngine.Transform partIns); // 0x074b5084
	WizardGames.Soc.Common.Unity.Construction.SocketModConfigData ExportConfigData(); // 0x074b51ac
	System.Void .ctor(); // 0x074b523c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SocketModTerrainCheck : WizardGames.Soc.Common.Unity.Construction.SocketMod
{
	System.Boolean wantsInTerrain; // 0x38
	System.Void OnDrawGizmosSelected(); // 0x074b52cc
	WizardGames.Soc.Common.Construction.SocketModType get_SocketModType(); // 0x074b5374
	System.Void DrawGizmosWithIns(UnityEngine.Transform partIns); // 0x074b53d8
	static System.Boolean IsInTerrain(UnityEngine.Vector3 vPoint); // 0x074b5524
	System.Void SetValue(System.String value); // 0x074b5938
	System.String GetValue(); // 0x074b5a40
	WizardGames.Soc.Common.Unity.Construction.SocketModConfigData ExportConfigData(); // 0x074b5b68
	System.Void .ctor(); // 0x074b5be0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SocketModAngleCheckNoMono : WizardGames.Soc.Common.Unity.Construction.SocketModNoMono
{
	
	UnityEngine.Vector3 get_WorldNormal(); // 0x074b5c70
	System.Single get_WithinDegrees(); // 0x074b5ce0
	System.Boolean DoCheck(WizardGames.Soc.Common.Unity.Construction.Placement place, System.Int64 ignoreEntityId); // 0x074b5d50
	System.Boolean DoCheck(UnityEngine.Vector3 pos, UnityEngine.Quaternion rotation, System.Int64 ignoreEntityId); // 0x074b5e10
	System.Void .ctor(); // 0x074b5fc0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SocketModAreaCheckNoMono : WizardGames.Soc.Common.Unity.Construction.SocketModNoMono
{
	
	UnityEngine.Bounds get_Bounds(); // 0x074b6028
	UnityEngine.LayerMask get_LayerMask(); // 0x074b60b8
	System.Boolean get_WantsInside(); // 0x074b6128
	WizardGames.Soc.Common.Construction.ConstructionPartType get_IgnorePartType(); // 0x074b6198
	static System.Boolean IsInArea(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Bounds bounds, UnityEngine.LayerMask layerMask, WizardGames.Soc.Common.Construction.ConstructionPartType ignorePartType, System.Int64 additionIgnoreEntityId); // 0x074b6208
	WizardGames.Soc.Common.Entity.PartEntity GetSocketCommonPartGo(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x074b63b4
	System.Boolean DoCheck(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Int64 ignoreEntityId); // 0x074b6570
	System.Boolean DoCheck(WizardGames.Soc.Common.Unity.Construction.Placement place, System.Int64 ignoredEntityId); // 0x074b6788
	System.Void .ctor(); // 0x074b6848
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SocketModAttractionNoMono : WizardGames.Soc.Common.Unity.Construction.SocketModNoMono
{
	static SocLogger logger; // 0x0
	System.Int64 lastLockedEntity; // 0x20
	UnityEngine.Vector3 lastLockedEntityPos; // 0x28
	System.Single get_OuterRadius(); // 0x074b68b0
	System.Single get_InnerRadius(); // 0x074b6920
	System.String get_GroupName(); // 0x074b6990
	System.Boolean get_LockRotation(); // 0x074b6a00
	System.Boolean get_IgnoreRotationForRadiusCheck(); // 0x074b6a70
	System.Single get_lockDistanceMul(); // 0x074b6ae0
	System.Single get_lockAttraction(); // 0x074b6bc8
	System.Single get_lockSwitchDistanceDelta(); // 0x074b6cb0
	System.Single get_attractYPosMul(); // 0x074b6d98
	System.Boolean DoCheck(WizardGames.Soc.Common.Unity.Construction.Placement place, System.Int64 ignoreEntityId); // 0x074b6e80
	System.Boolean DoCheck(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Int64 ignoreEntityId); // 0x074b6f00
	System.Void ModifyPlacement(WizardGames.Soc.Common.Unity.Construction.Placement place); // 0x074b6fe0
	System.Void TryApplyPoint(WizardGames.Soc.Common.Entity.PartEntity cb, WizardGames.Soc.Common.Unity.Construction.SocketModConfigData point, System.Single& closestLockDist, UnityEngine.Vector3 originalPlace, WizardGames.Soc.Common.Unity.Construction.Placement& place, System.Boolean isBindDist); // 0x074b7a70
	System.Void ModifyByPointIgnoreRotation(WizardGames.Soc.Common.Entity.PartEntity cb, WizardGames.Soc.Common.Unity.Construction.SocketModConfigData point, System.Single& closestLockDist, UnityEngine.Vector3 originalPlace, WizardGames.Soc.Common.Unity.Construction.Placement& place); // 0x074b7ec0
	System.Void ModifyByPoint(WizardGames.Soc.Common.Entity.PartEntity cb, WizardGames.Soc.Common.Unity.Construction.SocketModConfigData point, System.Single fraction, WizardGames.Soc.Common.Unity.Construction.Placement& place); // 0x074b809c
	System.Void .ctor(); // 0x074b87fc
	static System.Void .cctor(); // 0x074b8864
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SocketModInWaterNoMono : WizardGames.Soc.Common.Unity.Construction.SocketModNoMono
{
	static SocLogger logger; // 0x0
	System.Boolean get_WantsInWater(); // 0x074b8938
	System.Boolean IsInWater(UnityEngine.Vector3 vPoint); // 0x074b89a8
	System.Boolean DoCheck(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Int64 ignoreEntityId); // 0x074b8dd0
	System.Boolean DoCheck(WizardGames.Soc.Common.Unity.Construction.Placement place, System.Int64 ignoreEntityId); // 0x074b905c
	System.Void .ctor(); // 0x074b9138
	static System.Void .cctor(); // 0x074b9204
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SocketModNoMono : System.Object
{
	WizardGames.Soc.Common.Unity.Construction.SocketModConfigData _socketModConfigData; // 0x10
	WizardGames.Soc.Common.Construction.SocketModType socketModType; // 0x18
	UnityEngine.Vector3 get_LocalPosition(); // 0x074b8ef8
	UnityEngine.Quaternion get_LocalRotation(); // 0x074b92d8
	System.Void ApplyConfig(WizardGames.Soc.Common.Unity.Construction.SocketModConfigData configData); // 0x074b9348
	System.Void ModifyPlacement(WizardGames.Soc.Common.Unity.Construction.Placement place); // 0x074b93c8
	System.Boolean DoCheck(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Int64 ignoreEntityId); // 0x074b943c
	System.Boolean DoCheck(WizardGames.Soc.Common.Unity.Construction.Placement place, System.Int64 ignoreEntityId); // 0x074b952c
	UnityEngine.Vector3 GetInsPosition(WizardGames.Soc.Common.Entity.PartEntity InsGoTrans); // 0x074b95cc
	UnityEngine.Quaternion GetInsRotation(WizardGames.Soc.Common.Entity.PartEntity InsGoTrans); // 0x074b9754
	System.Void .ctor(); // 0x074b919c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SocketModNotInDoorNoMono : WizardGames.Soc.Common.Unity.Construction.SocketModNoMono
{
	
	UnityEngine.Bounds get_Bounds(); // 0x074b999c
	System.Boolean IsInDoor(UnityEngine.Vector3 vPoint, UnityEngine.Quaternion rotation); // 0x074b9a2c
	System.Boolean DoCheck(WizardGames.Soc.Common.Unity.Construction.Placement place, System.Int64 ignoreEntityId); // 0x074b9c58
	System.Boolean DoCheck(UnityEngine.Vector3 pos, UnityEngine.Quaternion rotation, System.Int64 ignoreEntityId); // 0x074b9cfc
	System.Void .ctor(); // 0x074b9e04
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SocketModSphereCheckNoMono : WizardGames.Soc.Common.Unity.Construction.SocketModNoMono
{
	System.Boolean isCollideDebrisWall; // 0x1c
	System.Single get_SphereRadius(); // 0x074b9e68
	System.Boolean get_WantsCollide(); // 0x074b9ed8
	UnityEngine.LayerMask get_LayerMask(); // 0x074b9f48
	System.Boolean DoCheck(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Int64 ignoreEntityId); // 0x074b9fb8
	System.Boolean DoCheck(WizardGames.Soc.Common.Unity.Construction.Placement place, System.Int64 ignoreEntityId); // 0x074ba168
	System.Void .ctor(); // 0x074ba240
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SocketModTerrainCheckNoMono : WizardGames.Soc.Common.Unity.Construction.SocketModNoMono
{
	
	System.Boolean get_WantsInTerrain(); // 0x074ba2a4
	static System.Boolean IsInTerrain(UnityEngine.Vector3 vPoint); // 0x074ba314
	System.Boolean DoCheck(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Int64 ignoreEntityId); // 0x074ba728
	System.Boolean DoCheck(WizardGames.Soc.Common.Unity.Construction.Placement place, System.Int64 ignoreEntityId); // 0x074ba858
	System.Void .ctor(); // 0x074ba930
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SocketModConfigData : System.Object
{
	UnityEngine.Vector3 localPosition; // 0x10
	UnityEngine.Quaternion localRotation; // 0x1c
	UnityEngine.Vector3 localScale; // 0x2c
	System.String nodeName; // 0x38
	WizardGames.Soc.Common.Construction.SocketModType socketModType; // 0x40
	System.Boolean wantsInTerrain; // 0x44
	System.Boolean wantsAngle; // 0x45
	UnityEngine.Vector3 worldNormal; // 0x48
	System.Single withinDegrees; // 0x54
	UnityEngine.Bounds bounds; // 0x58
	UnityEngine.LayerMask layerMask; // 0x70
	System.Boolean wantsInside; // 0x74
	WizardGames.Soc.Common.Construction.ConstructionPartType ignorePartType; // 0x78
	System.Boolean getGroundLayerFromHitDetail; // 0x7c
	System.Single outerRadius; // 0x80
	System.Single innerRadius; // 0x84
	System.String groupName; // 0x88
	System.Boolean lockRotation; // 0x90
	System.Boolean ignoreRotationForRadiusCheck; // 0x91
	System.Boolean wantsInWater; // 0x92
	System.Single sphereRadius; // 0x94
	System.Boolean wantsCollide; // 0x98
	System.Void .ctor(); // 0x074ba994
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.TemplateGoConfig : UnityEngine.MonoBehaviour, WizardGames.Soc.Common.Unity.IGoConfig
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.Construction.ConstructionBase ConstructionBase; // 0x30
	WizardGames.Soc.Common.Unity.Construction.ConstructionConfig ConstructionConfig; // 0x38
	WizardGames.Soc.Common.Unity.Construction.TransformationPartCheckBound PartCheckBound; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.Common.Construction.SocketConfigData> SocketConfigDatas; // 0x48
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.TemplateTransData> TemplateTransDatas; // 0x50
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.TemplateMonoData> TemplateMonoDatas; // 0x58
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.TemplateConstructionSkinData> TemplateConstructionSkinDatas; // 0x60
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.TemplateShatteredData> TemplateShatteredDatas; // 0x68
	System.Collections.Generic.List<UnityEngine.Vector3> TemplateWireFrontPathPoints; // 0x70
	System.Collections.Generic.List<UnityEngine.Vector3> TemplateWireBackPathPoints; // 0x78
	System.Boolean UseGpuInstance; // 0x80
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Construction.SocketConfigData> socketConfigDataDic; // 0x88
	System.Collections.Generic.Dictionary<System.Type,System.Collections.IList> templateMonoDics; // 0x90
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.SocketModNoMono> socketModNoMonos; // 0x98
	System.Boolean inited; // 0xa0
	System.Boolean WaitingDispose; // 0xa1
	System.Single LastUnUseTime; // 0xa4
	System.Int32 UseCount; // 0xa8
	System.String AssetPath; // 0xb0
	System.Boolean OnlyContainsFreeSocket(); // 0x074ba9fc
	WizardGames.Soc.Common.Construction.SocketConfigData GetSocketConfigDataBySocketId(System.Int32 socketId); // 0x074babb8
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.SocketModNoMono> GetSocketModeConfigDatas(); // 0x074bae48
	UnityEngine.Transform GetNamePointTrans(System.String pointName); // 0x074baeac
	T GetMono<T>(); // 0x052af1f0
	System.Collections.Generic.List<T> GetMonos<T>(); // 0x052af1f0
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.TemplateShatteredData> GetShatterPathDatas(); // 0x074bafb0
	System.Void Init(); // 0x074bb014
	System.Void InitSocketConfig(); // 0x074bb0a4
	System.Void InitSocketMods(); // 0x074bb2cc
	System.Void AddGradeConstructionSkin(WizardGames.Soc.Common.Unity.Construction.ConstructionSkin[] constructionSkins); // 0x074bb968
	System.Void InitConstructionSkinData(); // 0x074bb5a4
	WizardGames.Soc.Common.Unity.Construction.ConstructionSkin GetConditionalSkin(WizardGames.Soc.Common.Construction.ConstructionGrade grade, System.Int64 skinId); // 0x074bbd04
	System.Void Alloc(); // 0x074bbe2c
	System.Void Free(); // 0x074bbe98
	System.Void RefreshLastUseTime(); // 0x074bc024
	System.Void .ctor(); // 0x074bc0a8
	static System.Void .cctor(); // 0x074bc410
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.TemplateTransData : System.Object
{
	System.String transName; // 0x10
	UnityEngine.Transform transPoint; // 0x18
	System.Void .ctor(); // 0x074bc4e4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.TemplateMonoData : System.Object
{
	System.String typeName; // 0x10
	System.Collections.Generic.List<UnityEngine.Component> monos; // 0x18
	System.Void .ctor(); // 0x074bc54c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.TemplateConstructionSkinData : System.Object
{
	WizardGames.Soc.Common.Construction.ConstructionGrade grade; // 0x10
	System.Int64 skinId; // 0x18
	WizardGames.Soc.Common.Unity.Construction.ConstructionSkin constructionSkin; // 0x20
	System.Void .ctor(WizardGames.Soc.Common.Unity.Construction.ConstructionSkin constructionSkin); // 0x074bbb6c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.TemplateShatteredData : System.Object
{
	System.String path; // 0x10
	System.Int64 skinId; // 0x18
	System.Int32 grade; // 0x20
	System.Int32 prefabId; // 0x24
	UnityEngine.Vector3 pos; // 0x28
	UnityEngine.Quaternion rotation; // 0x34
	UnityEngine.Vector3 localScale; // 0x44
	UnityEngine.Vector3 lossyScale; // 0x50
	WizardGames.Soc.Common.Unity.Construction.EShatteredShowState showState; // 0x5c
	System.Void .ctor(); // 0x074bc600
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.AutoCloseDoorConfig : UnityEngine.MonoBehaviour
{
	System.Single closeTime; // 0x30
	System.Single PlayerCloseTime; // 0x34
	System.Single detectTime; // 0x38
	UnityEngine.LayerMask layers; // 0x3c
	System.Action<System.Boolean> onTriggerCloseDoor; // 0x40
	System.Single collidingTime; // 0x48
	System.Single autoOpenTime; // 0x4c
	System.Collections.Generic.HashSet<System.Int64> collidingEntities; // 0x50
	static System.Collections.Generic.HashSet<System.Int64> removeCollidingEntities; // 0x0
	System.Single get_CloseTimeOverride(); // 0x074bc668
	System.Void set_CloseTimeOverride(System.Single value); // 0x074bc6d8
	System.Void Start(); // 0x074bc750
	System.Void Tick(); // 0x074bc840
	System.Void .ctor(); // 0x074bc94c
	static System.Void .cctor(); // 0x074bca08
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.AutoOpenDoorConfig : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	System.Single offsetAngle; // 0x30
	UnityEngine.LayerMask layer; // 0x34
	System.Action onTriggerOpenDoor; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,System.Single> StayState; // 0x40
	System.Single MoveTowardDoorTimeThreshold; // 0x48
	System.Single MoveTowardDoorAngleThreshold; // 0x4c
	System.Boolean IsAutoOpenDoor; // 0x50
	System.Void add_onTriggerOpenDoor(System.Action value); // 0x074bcaa0
	System.Void remove_onTriggerOpenDoor(System.Action value); // 0x074bcb78
	System.Void OnTriggerEnter(UnityEngine.Collider co); // 0x074bcc50
	System.Void OnTriggerStay(UnityEngine.Collider co); // 0x074bd3c4
	WizardGames.Soc.Common.Entity.IEntity GetIEntity(UnityEngine.Collider co); // 0x074bce4c
	System.Boolean CheckMoveTowardDoor(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, UnityEngine.Transform playerTrans, UnityEngine.Transform doorTrans); // 0x074bcfd8
	System.Boolean CheckPlayerSpeedAngle(UnityEngine.Vector3 playerPos, UnityEngine.Vector3 speedDir, UnityEngine.Transform doorTrans); // 0x074bd7a8
	System.Boolean CheckPlayerAngle(UnityEngine.Transform playerTrans, UnityEngine.Transform doorTrans); // 0x074bda84
	UnityEngine.Vector3 PointToPlane(UnityEngine.Vector3 worldpos, UnityEngine.Vector3 targetPlanePos, UnityEngine.Vector3 planeNormal); // 0x074bdd64
	System.Void .ctor(); // 0x074bde78
	static System.Void .cctor(); // 0x074bdf54
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.LaserDetectorTrigger : UnityEngine.MonoBehaviour
{
	static SocLogger Logger; // 0x0
	UnityEngine.LayerMask layer; // 0x30
	System.Action<System.Boolean> SwitchLaserDetectorState; // 0x38
	System.Action LaserBeBlocked; // 0x40
	System.Collections.Generic.HashSet<UnityEngine.Collider> collSet; // 0x48
	UnityEngine.LayerMask blockLayer; // 0x50
	UnityEngine.BoxCollider boxCollider; // 0x58
	System.Void add_SwitchLaserDetectorState(System.Action<System.Boolean> value); // 0x074be028
	System.Void remove_SwitchLaserDetectorState(System.Action<System.Boolean> value); // 0x074be118
	System.Void add_LaserBeBlocked(System.Action value); // 0x074be208
	System.Void remove_LaserBeBlocked(System.Action value); // 0x074be2e0
	System.Void Awake(); // 0x074be3b8
	System.Void OnEnable(); // 0x074be4a8
	System.Void SetDetectedObj(UnityEngine.Collider collider); // 0x074be52c
	System.Void .ctor(); // 0x074be658
	static System.Void .cctor(); // 0x074be70c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.LiveSensorTrigger : UnityEngine.MonoBehaviour
{
	System.Action<WizardGames.Soc.Common.Entity.IEntity,System.Boolean> SwitchSensorState; // 0x30
	System.Int32 personNum; // 0x38
	ListHashSet<System.Int64> playerEntityIds; // 0x40
	System.Void add_SwitchSensorState(System.Action<WizardGames.Soc.Common.Entity.IEntity,System.Boolean> value); // 0x074be7e0
	System.Void remove_SwitchSensorState(System.Action<WizardGames.Soc.Common.Entity.IEntity,System.Boolean> value); // 0x074be8d0
	System.Void OnTriggerEnter(UnityEngine.Collider co); // 0x074be9c0
	System.Void OnTriggerExit(UnityEngine.Collider co); // 0x074bf1c4
	System.Void TriggerSensorState(WizardGames.Soc.Common.Entity.IEntity entity, System.Boolean state); // 0x074bee7c
	System.Void .ctor(); // 0x074bf680
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.PressurePadTrigger : UnityEngine.MonoBehaviour
{
	UnityEngine.LayerMask layer; // 0x30
	System.Action<System.Boolean> PressurePadTriggered; // 0x38
	System.Collections.Generic.HashSet<UnityEngine.Collider> collSet; // 0x40
	System.Void add_PressurePadTriggered(System.Action<System.Boolean> value); // 0x074bf738
	System.Void remove_PressurePadTriggered(System.Action<System.Boolean> value); // 0x074bf828
	System.Void OnTriggerEnter(UnityEngine.Collider co); // 0x074bf918
	System.Void OnTriggerExit(UnityEngine.Collider co); // 0x074bfa3c
	System.Void Tick(System.Int64 timerId); // 0x074bfb20
	System.Void .ctor(); // 0x074bffb4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.TriggerConfig : UnityEngine.MonoBehaviour
{
	System.Collections.Generic.List<UnityEngine.GameObject> target; // 0x30
	System.Void .ctor(); // 0x074c0068
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.TriggerConfigDataBase : UnityEngine.MonoBehaviour
{
	System.Single triggerSize; // 0x30
	System.Void .ctor(); // 0x074c00d0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.TriggerConfigDataComfort : WizardGames.Soc.Common.Unity.Construction.TriggerConfigDataBase
{
	System.Single baseComfort; // 0x34
	System.Single minComfortRange; // 0x38
	System.Void .ctor(); // 0x074c0138
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.TriggerConfigDataHeat : WizardGames.Soc.Common.Unity.Construction.TriggerConfigDataBase
{
	System.Single Temperature; // 0x34
	System.Single minSize; // 0x38
	System.Boolean sunlightBlocker; // 0x3c
	System.Single sunlightBlockAmount; // 0x40
	System.Single blockMinHour; // 0x44
	System.Single blockMaxHour; // 0x48
	System.Void .ctor(); // 0x074c01a8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.TriggerConfigWaitBind : UnityEngine.MonoBehaviour
{
	System.Action<UnityEngine.Collider> TriggerEnterAction; // 0x30
	System.Action<UnityEngine.Collider> TriggerExitAction; // 0x38
	System.Void OnTriggerEnter(UnityEngine.Collider other); // 0x074c0220
	System.Void OnTriggerExit(UnityEngine.Collider other); // 0x074c02ac
	System.Void .ctor(); // 0x074c0338
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Construction.TriggerEvent : System.ValueType
{
	WizardGames.Soc.Common.Combat.DamageTypeEntry[] damageArray; // 0x10
	System.Int32 buffId; // 0x18
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.TriggerData : UnityEngine.MonoBehaviour
{
	UnityEngine.LayerMask layer; // 0x30
	System.Boolean isSlowDown; // 0x34
	System.Single drag; // 0x38
	System.Boolean isProhibitJump; // 0x3c
	WizardGames.Soc.Common.Data.ReduceSpeedAction reduceSpeedAction; // 0x40
	System.Single repeatRate; // 0x48
	WizardGames.Soc.Common.Unity.Construction.TriggerEvent onEnterData; // 0x50
	WizardGames.Soc.Common.Unity.Construction.TriggerEvent onStayData; // 0x60
	WizardGames.Soc.Common.Unity.Construction.TriggerEvent onMoveData; // 0x70
	WizardGames.Soc.Common.Unity.Construction.TriggerEvent onExitData; // 0x80
	System.Action<WizardGames.Soc.Common.Entity.IEntity> onTriggerEnter; // 0x90
	System.Action<WizardGames.Soc.Common.Entity.IEntity> onTriggerExit; // 0x98
	System.Action onDisable; // 0xa0
	System.Void add_onTriggerEnter(System.Action<WizardGames.Soc.Common.Entity.IEntity> value); // 0x074c03a0
	System.Void remove_onTriggerEnter(System.Action<WizardGames.Soc.Common.Entity.IEntity> value); // 0x074c0490
	System.Void add_onTriggerExit(System.Action<WizardGames.Soc.Common.Entity.IEntity> value); // 0x074c0580
	System.Void remove_onTriggerExit(System.Action<WizardGames.Soc.Common.Entity.IEntity> value); // 0x074c0670
	System.Void add_onDisable(System.Action value); // 0x074c0760
	System.Void remove_onDisable(System.Action value); // 0x074c0838
	System.Void Awake(); // 0x074c0910
	WizardGames.Soc.Common.Entity.IEntity GetIEntity(UnityEngine.Collider co); // 0x074c09d4
	System.Void OnTriggerEnter(UnityEngine.Collider co); // 0x074c0c00
	System.Void OnTriggerExit(UnityEngine.Collider co); // 0x074c0cd8
	System.Void OnDisable(); // 0x074c0d78
	System.Void .ctor(); // 0x074c0df0
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Construction.EShatteredShowState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Construction.EShatteredShowState Default = 0;
	static WizardGames.Soc.Common.Unity.Construction.EShatteredShowState Open = 1;
	static WizardGames.Soc.Common.Unity.Construction.EShatteredShowState Always = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Construction.EPlaceState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState CanPlace = 0;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState NoSocketPoint = 1001;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState WithinPveArea = 1002;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState WithinRoad = 1003;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState NoPermission = 1004;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState NoUnderGround = 1005;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState EntityBlocked = 1006;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState TerrainBlocked = 1007;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState AirflowBlocked = 1009;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState Stability = 1010;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState Material = 1011;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState Distance = 1012;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState SightBlocked = 1013;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState BuildingsBlocked = 1014;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState BuildingsProximity = 1092;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState ToolAreaConflict = 1017;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState WaterBlocked = 1028;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState NoInWater = 1029;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState WrongAngle = 1030;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState MisPlaced = 1031;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState CollideDebrisWall = 1064;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState WallCornerDisableBuild = 1065;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState TooFarToMove = 1085;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState TooFarCantWire = 22083;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState NotHaveItem = 1074;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState PlayerIsHostile = 24004;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState IsBroken = 3010;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState NotUnlock = 1203;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState OverLimit = 22038;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState PersonalBuildLimit = 22109;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState WallMidRefuse = 24205;
	static WizardGames.Soc.Common.Unity.Construction.EPlaceState CannotCapturedDeadSheep = 24079;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Construction.EPartPosType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Construction.EPartPosType None = 0;
	static WizardGames.Soc.Common.Unity.Construction.EPartPosType ToolCupboard = 1;
	static WizardGames.Soc.Common.Unity.Construction.EPartPosType WorkBench = 2;
	static WizardGames.Soc.Common.Unity.Construction.EPartPosType SleepingBag = 3;
	static WizardGames.Soc.Common.Unity.Construction.EPartPosType PlantBox = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Construction.EInteractionDoorType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Construction.EInteractionDoorType OpenUiBtnID = 111;
	static WizardGames.Soc.Common.Unity.Construction.EInteractionDoorType CloseUiBtnID = 112;
	static WizardGames.Soc.Common.Unity.Construction.EInteractionDoorType KnockDoor = 130;
	static WizardGames.Soc.Common.Unity.Construction.EInteractionDoorType FakeOpen = 168;
	static WizardGames.Soc.Common.Unity.Construction.EInteractionDoorType FakeClose = 169;
	static WizardGames.Soc.Common.Unity.Construction.EInteractionDoorType OpenHatch = 134;
	static WizardGames.Soc.Common.Unity.Construction.EInteractionDoorType CloseHatch = 135;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Construction.EConstructionPrefabType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Construction.EConstructionPrefabType Default = 0;
	static WizardGames.Soc.Common.Unity.Construction.EConstructionPrefabType Prebuild = 1;
	static WizardGames.Soc.Common.Unity.Construction.EConstructionPrefabType Deployed = 2;
	static WizardGames.Soc.Common.Unity.Construction.EConstructionPrefabType Template = 3;
	static WizardGames.Soc.Common.Unity.Construction.EConstructionPrefabType Virtual = 4;
	static WizardGames.Soc.Common.Unity.Construction.EConstructionPrefabType Collider = 5;
	static WizardGames.Soc.Common.Unity.Construction.EConstructionPrefabType Skin = 6;
	static WizardGames.Soc.Common.Unity.Construction.EConstructionPrefabType SourceMesh = 7;
	static WizardGames.Soc.Common.Unity.Construction.EConstructionPrefabType Debris = 8;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Construction.EGetNearbyConstructionType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Construction.EGetNearbyConstructionType Reborn = 0;
	static WizardGames.Soc.Common.Unity.Construction.EGetNearbyConstructionType ClientRequest = 1;
	static WizardGames.Soc.Common.Unity.Construction.EGetNearbyConstructionType SuddenMove = 2;
	static WizardGames.Soc.Common.Unity.Construction.EGetNearbyConstructionType SyncEntityDone = 3;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.CommonConstructionUtils : System.Object
{
	static System.Single FOUNDATION_SIDE_LENGTH; // 0x0
	static SocLogger logger; // 0x8
	static System.Boolean PartMemoryOptEnable; // 0x10
	static System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.ConstructionConditionalModel> tmpConditionModules; // 0x18
	static System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.CheckConfigBase>> bufferedBlueprintConfigDict; // 0x20
	static WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget templateTarget; // 0x28
	static System.Single MaxRepairDistance; // 0xc0
	static System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.Construction.EPartPosType,System.Collections.Generic.HashSet<WizardGames.Soc.Common.Construction.PartType>> NeedSavePosParts; // 0xc8
	static System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.Construction.EPartPosType,System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Construction.PartType,System.Collections.Generic.Dictionary<System.Int64,UnityEngine.Vector3>>> partPosDataDict; // 0xd0
	static System.Text.StringBuilder StrBuilder; // 0xd8
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.AssetPool.AssetPoolHandle> materialDic; // 0xe0
	static UnityEngine.Collider[] _hits; // 0xe8
	static System.Collections.Generic.HashSet<System.Int64> _entityIdLst; // 0xf0
	static UnityEngine.RaycastHit[] raycastHitBuffer; // 0xf8
	static System.Int32 MaxCheckColliderNum; // 0x100
	static UnityEngine.Collider[] checkPartHitBuffer; // 0x108
	static System.Int32 SOCKET_POOL_DEFAULT_SIZE; // 0x110
	static System.Int32 SOCKET_POOL_MAX_SIZE; // 0x114
	static System.Int32 clentPartGoMaxSize; // 0x118
	static System.Boolean isInitPool; // 0x11c
	static System.Collections.Generic.List<System.Int32> comboChildGradList; // 0x120
	static System.Collections.Generic.HashSet<System.Int64> checkPartIDSet; // 0x128
	static System.Collections.Generic.List<System.Int64> tempChildPartTypes; // 0x130
	static System.Int64 nowMovingPartId; // 0x138
	static WizardGames.Soc.Common.Data.MgrTables editorTables; // 0x140
	static System.Single lastCheckTime; // 0x148
	static System.Single intervalTime; // 0x14c
	static System.Single expireTime; // 0x150
	static System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Construction.MeshRenderConfig> meshRenderGoMap; // 0x158
	static System.Collections.Generic.Dictionary<System.String,System.UInt64> loadingMeshRenderGoMap; // 0x160
	static System.Action<UnityEngine.GameObject,System.Object[]> loadMeshRenderConfigCallback; // 0x168
	static System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Construction.TemplateGoConfig> partTemplateGoDict; // 0x170
	static UnityEngine.GameObject partTemplateRoot; // 0x178
	static UnityEngine.GameObject bindGo; // 0x180
	static System.Void .cctor(); // 0x074c0e7c
	static System.Void InitPool(); // 0x074c16bc
	static System.Void InitPool<T>(System.Int32 maxSize, System.Int32 capacity); // 0x052af1f0
	static System.Boolean IsPartCanSwitchSocket(System.Int64 partType); // 0x074c1898
	static System.Void GetShatterPaths(System.Int64 partType, System.Int32 grade, System.Int64 skinId, System.Int64 additionInfo, WizardGames.Soc.Common.Unity.Construction.EShatteredShowState showState, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.TemplateShatteredData>& shatteredDatas); // 0x074c1998
	static System.Boolean IfHitAnySceneItemBox(UnityEngine.Vector3 position, UnityEngine.Vector3 size, UnityEngine.Quaternion rotation); // 0x074c237c
	static WizardGames.Soc.Common.Data.constraction.BuildingSkin GetBuildingSkinConfig(System.Int64 partId, System.Int64 skinId); // 0x074c2520
	static System.String GetSeparatePrefabPathByType(System.Int64 partId, WizardGames.Soc.Common.Unity.Construction.EConstructionPrefabType prefabType, System.Int64 skinId); // 0x074c27d8
	static System.String GetPartOriginSkinPrefabPath(System.Int64 partId, System.Int64 skinId, WizardGames.Soc.Common.Construction.ConstructionGrade grade); // 0x074c2944
	static System.Int32 GetAllPartHitNumByDistance(UnityEngine.Vector3 position, System.Single distance, System.Boolean includeVirtualPart); // 0x074c2bf4
	static System.Boolean CheckRoad(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Bounds bounds); // 0x074c2d40
	static System.Boolean CheckRoad(System.Int64 templateId, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot); // 0x074c319c
	static System.Boolean CheckPartVolume(System.Int64 templateId, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, System.Collections.Generic.List<System.Int64>& hitPartIdList, WizardGames.Soc.Common.Unity.Construction.CommonConstructionUtils.ECheckPartVolumeReason reason, System.Int64 ignoreEntityId, System.Int32 funcIgnoreMask, System.String ignoreTag); // 0x074c34e8
	static System.Boolean CheckPartSocketMods(System.Int64 templateId, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, System.Int64 ignoreEntityId); // 0x074c3da0
	static System.ValueTuple<System.Boolean,WizardGames.Soc.Common.Construction.ETransformPartRespCode> RequestCheckTransformationPartLegal(System.Int64 transformationPartId, System.Int64 targetPartType, System.Int32 grade, System.Int64 targetSkinId); // 0x074c448c
	static System.Boolean CheckPartTransformBoxArea(System.Int64 templateId, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, System.Single additionCheckDistance, System.Collections.Generic.List<System.Int64>& hitPartEntityIdList); // 0x074c4cd8
	static System.Void GetPartEntityListByHitNum(System.Int32 hitNum, System.Collections.Generic.List<WizardGames.Soc.Common.Entity.PartEntity>& entityList); // 0x074c5a2c
	static System.String GetFirstStoryNameUnlockCustomSlot(System.Int32 slotLevel); // 0x074c5d60
	static System.Void GetPartEntityIDListByHitNum(System.Int32 hitNum, System.Collections.Generic.List<System.Int64>& idList); // 0x074c61dc
	static System.Boolean IsPosUnderWater(UnityEngine.Vector3 vPoint); // 0x074c654c
	static System.Boolean IsPosNearAnyToolBox(UnityEngine.Vector3 pos, System.Single radius, System.Int64 ignoreEntityId); // 0x074c68f8
	static System.Void GetAllPartEntityByBoundsWithPhysics(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 hafExtends, System.Collections.Generic.List<WizardGames.Soc.Common.Entity.PartEntity>& list); // 0x074c6ad4
	static System.Int32 GetAllPartGoByBox(UnityEngine.Vector3 position, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion rotation); // 0x074c6c6c
	static System.Int32 GetAllPartGoByOBB(UnityEngine.Vector3 position, UnityEngine.Quaternion rot, UnityEngine.Vector3 halfExtends, UnityEngine.LayerMask layerMask); // 0x074c6dec
	static WizardGames.Soc.Common.Combat.ColliderConfig GetConstructionCollierConfig(UnityEngine.Collider collider); // 0x074c6f68
	static System.Void FindPartsByPosAndRotation(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3 halfExtends, System.Collections.Generic.List<System.Int64>& partIdList, System.Collections.Generic.HashSet<System.Int64> includeTypes, System.Int64 ignoreEntityId); // 0x074c5600
	static System.Void FindNearbyPartsByObb(WizardGames.Soc.Common.Unity.Utility.OBB obb, System.Collections.Generic.List<System.Int64>& idList, System.Collections.Generic.HashSet<System.Int64> includeTypes, System.Int64 ignoreEntityId); // 0x074c7154
	static WizardGames.Soc.Common.Entity.PartEntity GetPartEntityByID(System.Int64 entityId); // 0x074c705c
	static System.Boolean NeedSavePos(System.Int64 templateId); // 0x074c7280
	static WizardGames.Soc.Common.Unity.Construction.EPartPosType GetPartPosType(System.Int64 templateId); // 0x074c7470
	static System.Void RemovePartPos(System.Int64 partId, System.Int64 templateId); // 0x074c7664
	static System.Void SavePartPos(System.Int64 partId, System.Int64 templateId, UnityEngine.Vector3 pos); // 0x074c78cc
	static System.Void GetNearbyPartIdsByDistanceByPartPosType(WizardGames.Soc.Common.Unity.Construction.EPartPosType partPosType, UnityEngine.Vector3 pos, System.Single distance, System.Collections.Generic.List<System.Int64>& idList); // 0x074c7d18
	static System.Void GetNearbyPartIdsByDistanceByPartPosType(WizardGames.Soc.Common.Unity.Construction.EPartPosType partPosType, UnityEngine.Vector3 centerPos, System.Single distance, System.Single height, System.Collections.Generic.List<System.Int64>& idList); // 0x074c81c4
	static System.String GetExtraPrebuildPathById(System.Int64 partId, System.Int64 skinId); // 0x074c8674
	static System.String GetComboGroupPrebuildPathById(System.Int64 comboId); // 0x074c873c
	static System.Int64 GetSkinConfigId(System.Int64 partId, System.Int64 skinId); // 0x074c2748
	static System.Boolean IsInLayerMask(System.Int32 layer, UnityEngine.LayerMask layerMask); // 0x074c8894
	static System.Boolean CheckHitGround(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single distance); // 0x074c891c
	static UnityEngine.RaycastHit GetTerrainHitInfo(UnityEngine.Ray ray, System.Single maxBuildDistance, System.Boolean placeOnWater); // 0x074c8c48
	static WizardGames.AssetPool.AssetPoolHandle GetCommonConstructionMat(System.Int32 matId); // 0x074c8eac
	static System.String GetPartDebrisPrefabPathByType(System.Int64 partType); // 0x074c9270
	static System.Void ReleaseCommonConstructionMat(); // 0x074c9784
	static System.Boolean IsCoreConstruction(System.Int64 tempId); // 0x074c2ab0
	static System.Boolean IsSleepingBag(WizardGames.Soc.Common.Entity.PartEntity entity); // 0x074c997c
	static System.Boolean IsCanPickUpConstruction(System.Int64 tempId); // 0x074c99f0
	static WizardGames.Soc.Common.Construction.SocketRuntimeBase GetPartSocketByPool(WizardGames.Soc.Common.Data.part.SocketBehaviorType socketBehaviorType); // 0x074c9b48
	static WizardGames.Soc.Common.Unity.Construction.SocketModNoMono CreateSocketModNoMono(WizardGames.Soc.Common.Construction.SocketModType socketModType); // 0x074bb774
	static System.Void FindConstructionWithPhysicsByBounds(UnityEngine.Bounds obb, UnityEngine.Quaternion quaternion, System.Collections.Generic.List<System.Int64>& partIdList, UnityEngine.LayerMask layerMask, System.Int64 partTemplateId); // 0x074c9dc8
	static System.Void GetPartEntityListByHitBuffer(System.Int32 hitCount, System.Collections.Generic.List<System.Int64>& partIdList, System.Int64 partTemplateId); // 0x074c9ff4
	static System.Int64 GetPartEntityChildGroupId(WizardGames.Soc.Common.Entity.PartEntity parentPartEntity); // 0x074ca3b0
	static System.Boolean CheckDeployOverlapNoMono(WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget& target, System.Int64 partType, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, System.String& hitObjName, WizardGames.Soc.Share.Framework.EntityBase ignoreEntity, System.Boolean ignoreChildPart, System.Int32 funcIgnoreMask, System.String ignoreTag); // 0x074cab00
	static System.Void FindConstructionWithPhysics(UnityEngine.Vector3 pos, System.Single radius, System.Collections.Generic.List<System.Int64>& partIdList, System.Int64 partTemplateId); // 0x074cae24
	static WizardGames.Soc.Common.SimpleCustom.CheckConfigBase CreateCheckConfigByJsonData(LitJson.JsonData jsonData); // 0x074cafa8
	static WizardGames.Soc.Common.SimpleCustom.CheckConfigBase ConvertCheckConfigJsonBaseToCheckBase(WizardGames.Soc.Common.Construction.CheckConfigBaseJson checkConfigBaseJson); // 0x074cb098
	static System.Void LoadBlueprintDeployConfig(System.Int64 blueprintId, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.CheckConfigBase>& configs); // 0x074cb190
	static System.Boolean CheckBlueprintToolboxByConfig(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, WizardGames.Soc.Common.SimpleCustom.CheckConfigBase checkConfigToolbox, System.String& errorPhrase); // 0x074cb88c
	static System.Boolean CheckBlueprintRoadByConfig(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, WizardGames.Soc.Common.SimpleCustom.CheckConfigBase checkConfigRoad); // 0x074cbb30
	static System.Boolean CheckBlueprintPermissionByConfig(System.UInt64 roleId, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, WizardGames.Soc.Common.SimpleCustom.CheckConfigBase checkConfigPermission); // 0x074cc0d4
	static System.Boolean CheckBlueprintGroundByConfig(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, WizardGames.Soc.Common.SimpleCustom.CheckConfigBase checkConfigGround); // 0x074cc380
	static System.Boolean CheckBlueprintDeployPveByConfig(UnityEngine.Vector3 entityPos, UnityEngine.Quaternion rotation, WizardGames.Soc.Common.SimpleCustom.CheckConfigBase checkConfigPve, System.String& errorParam); // 0x074cc5bc
	static System.Boolean CheckBlueprintDeployAreaByConfig(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, WizardGames.Soc.Common.SimpleCustom.CheckConfigBase checkConfigArea, System.String& errorParam); // 0x074cca20
	static System.Boolean IsInEditorCheck(); // 0x074cd07c
	static System.Boolean DoBlueprintCheckByConfig(System.UInt64 roleId, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, WizardGames.Soc.Common.SimpleCustom.CheckConfigBase checkConfigBase, System.String& errorParam); // 0x074cd12c
	static System.Boolean GetAMiddlePosYBetweenUnderGroundPointAndUnGroundPoint(System.Int64 blueprintId, System.Single& middleY); // 0x074cd530
	static System.Boolean CheckConstructionBlueprintCheckConfigs(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.CheckConfigBase> checkConfigBases, System.UInt64 roleId, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, System.Int32& errorPhase, System.String& errorParam, System.Collections.Generic.HashSet<System.Int32> ignoreCheckTypes); // 0x074cd914
	static System.Boolean CheckConstructionBlueprintDeploy(System.Int64 blueprintId, System.UInt64 roleId, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Int32& errorPhase, System.String& errorParam, System.Collections.Generic.HashSet<System.Int32> ignoreCheckTypes, System.Boolean enableDebug); // 0x074cdc5c
	static WizardGames.Soc.Common.Entity.PartEntity GetPartByCollider(UnityEngine.Collider collider); // 0x074ce084
	static WizardGames.Soc.Common.Entity.IEntity GetIEntityByCollider(UnityEngine.Collider collider); // 0x074ce33c
	static WizardGames.Soc.Common.Data.MgrTables GetEditorTables(System.Boolean forceRefresh); // 0x074ce440
	static System.Void OnLowMemory(); // 0x074ce6e4
	static System.Void CheckDisposeCacheConfig(System.Boolean checkMeshRenderConfig, System.Boolean checkTemplate); // 0x074cf044
	static System.Void CheckDisposeMeshRenderConfig(); // 0x074ce7a4
	static System.Void CheckDisposeTemplateConfig(); // 0x074cec2c
	static WizardGames.Soc.Common.Unity.Construction.MeshRenderConfig GetMeshRenderConfigByPath(System.String path); // 0x074cf1a4
	static System.Void LoadMeshRenderConfigAsync(System.String path); // 0x074cf2b0
	static System.Void OnMeshRenderConfigLoadFinish(UnityEngine.GameObject obj, System.Object[] parameters); // 0x074cf4f0
	static System.String GetGradeMeshOuterColliderPath(System.Int64 partId, System.Int64 skinId); // 0x074cfa34
	static System.String GetGradeMeshRenderConfigPath(System.Int64 partId, System.Int64 skinId, WizardGames.Soc.Common.Construction.ConstructionGrade grade); // 0x074cfae0
	static System.String GetSplicingMeshRenderConfigPath(System.Int64 prefabId); // 0x074cfcf4
	static System.String GetGradeColliderPath(System.Int64 partId, System.Int64 skinId, WizardGames.Soc.Common.Construction.ConstructionGrade grade); // 0x074cffcc
	static System.String GetSplicingColliderPath(System.Int64 prefabId); // 0x074d00d8
	static System.Void ClearTemplateGoConfigData(); // 0x074d02cc
	static UnityEngine.GameObject get_PartTemplateRoot(); // 0x074cf8c0
	static System.Void InitPartRoot(); // 0x074d0a6c
	static UnityEngine.GameObject get_BindGo(); // 0x074c9134
	static System.Void PreLoadTemplate(); // 0x074d0ba0
	static WizardGames.Soc.Common.Unity.Construction.TemplateGoConfig GetPartTemplateConfig(System.Int64 partType); // 0x074c1f1c
	static WizardGames.Soc.Common.Construction.SocketConfigData GetPartSocketConfigData(System.Int64 partType, System.Int32 socketId); // 0x074d0e9c
	static System.Boolean OnlyContainsFreeSocket(System.Int64 partType); // 0x074d1074
	static System.Int64 GetNearWorkbench(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x074d1240
	static System.Boolean IsElectricDevice(System.Int64 templateId); // 0x074d14ac
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Construction.CommonConstructionUtils.ECheckPartVolumeReason : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Construction.CommonConstructionUtils.ECheckPartVolumeReason CreatePart = 0;
	static WizardGames.Soc.Common.Unity.Construction.CommonConstructionUtils.ECheckPartVolumeReason MovePart = 1;
	static WizardGames.Soc.Common.Unity.Construction.CommonConstructionUtils.ECheckPartVolumeReason TransformPart = 2;
	static WizardGames.Soc.Common.Unity.Construction.CommonConstructionUtils.ECheckPartVolumeReason ChangePart = 3;
	static WizardGames.Soc.Common.Unity.Construction.CommonConstructionUtils.ECheckPartVolumeReason ChangeSkin = 4;
	static WizardGames.Soc.Common.Unity.Construction.CommonConstructionUtils.ECheckPartVolumeReason Upgrade = 5;
	static WizardGames.Soc.Common.Unity.Construction.CommonConstructionUtils.ECheckPartVolumeReason RecoverPart = 6;
	static WizardGames.Soc.Common.Unity.Construction.CommonConstructionUtils.ECheckPartVolumeReason Repair = 7;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.CommonConstructionUtils.<>c : System.Object
{
	static WizardGames.Soc.Common.Unity.Construction.CommonConstructionUtils.<>c <>9; // 0x0
	static System.Func<System.String,System.String> <>9__135_0; // 0x8
	static System.Void .cctor(); // 0x074d15a4
	System.Void .ctor(); // 0x074d1608
	System.String <GetEditorTables>b__135_0(System.String configFileName); // 0x074d1670
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.GizmosUtil : System.Object
{
	
	static System.Void DrawWireCapsuleY(UnityEngine.Vector3 pos, System.Single radius, System.Single height); // 0x074d1768
	static System.Void DrawCapsuleY(UnityEngine.Vector3 pos, System.Single radius, System.Single height); // 0x074d1a2c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.MathUtilsUnityExt : System.Object
{
	
	static UnityEngine.Vector3 CV3ToUV3(WizardGames.Soc.Common.Algorithm.Vector3 v3); // 0x074c4c48
	static WizardGames.Soc.Common.Algorithm.Vector3 UV3ToCV3(UnityEngine.Vector3 v3); // 0x074bb644
	static UnityEngine.Vector3 BV3ToUV3(WizardGames.Soc.Common.Data.BeansVector3 v3); // 0x074d1b14
	static WizardGames.Soc.Common.Framework.Algorithm.Quaternion UV3ToCV3(UnityEngine.Quaternion q); // 0x074bb6d4
	static WizardGames.Soc.Common.SimpleCustom.SimpleVector3 UV3ToSV3(UnityEngine.Vector3 v3); // 0x074d1bb8
	static System.Collections.Generic.List<System.Single> UV3LstToFLst(System.Collections.Generic.List<UnityEngine.Vector3> vectors); // 0x074d1c78
	static UnityEngine.Vector3 ApplyLocalPosition(UnityEngine.Vector3 localPosition, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); // 0x074b8f68
	static UnityEngine.Quaternion ApplyLocalRotation(UnityEngine.Quaternion localRotation, UnityEngine.Quaternion rotation); // 0x074b9864
	static UnityEngine.Vector3 ApplyLocalScale(UnityEngine.Vector3 localScale, UnityEngine.Vector3 scale); // 0x074d1f64
	static UnityEngine.Matrix4x4 ApplyLocalMatrix(UnityEngine.Transform localTrans, UnityEngine.Transform trans); // 0x074d201c
	static WizardGames.Soc.Common.Combat.NestedListV3 ToNestedListV3(WizardGames.Soc.Common.Data.BeansWayPoints points); // 0x074d21a4
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Construction.ECoreColliderState : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.Common.Unity.Construction.ECoreColliderState None = 0;
	static WizardGames.Soc.Common.Unity.Construction.ECoreColliderState Entity = 1;
	static WizardGames.Soc.Common.Unity.Construction.ECoreColliderState Outer = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.MeshTRSData : System.Object
{
	UnityEngine.Mesh mesh; // 0x10
	UnityEngine.Matrix4x4 trs; // 0x18
	System.String NodeName; // 0x58
	UnityEngine.Vector3 localPos; // 0x60
	UnityEngine.Quaternion localRotation; // 0x6c
	UnityEngine.Vector3 get_LocalPos(); // 0x074d23f8
	System.Void set_LocalPos(UnityEngine.Vector3 value); // 0x074d245c
	UnityEngine.Quaternion get_LocalRotation(); // 0x074d24f4
	System.Void set_LocalRotation(UnityEngine.Quaternion value); // 0x074d2558
	System.Void .ctor(); // 0x074d25f8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.MeshRenderConfig : UnityEngine.MonoBehaviour
{
	static SocLogger Log; // 0x0
	UnityEngine.Rendering.Universal.InstanceRenderInfo.PrefabInfo prefabinfo; // 0x30
	static System.Int32 instanceId; // 0x8
	static System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.Dictionary<System.Int64,System.Int32>> idCacheDic; // 0x10
	static System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.KeyValuePair<System.Int64,System.Int64>> idOthersideCacheDic; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.MeshTRSData> meshdatas; // 0x48
	System.String assetPath; // 0x50
	System.Boolean WaitingDispose; // 0x58
	System.Single LastUnUseTime; // 0x5c
	System.Int32 UseCount; // 0x60
	System.Int64 gpuKey; // 0x68
	static System.Int64 s_GPU_Key; // 0x20
	UnityEngine.Rendering.Universal.InstanceRenderInfo.PrefabInfo anim1Prefabinfo; // 0x70
	UnityEngine.Rendering.Universal.InstanceRenderInfo.PrefabInfo anim2Prefabinfo; // 0x88
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.SubMovableMeshConfig> subNodes; // 0xa0
	static System.Int32 GenerateInstanceId(); // 0x074d2660
	static System.Int32 GetGpuRenderInstanceId(System.Int64 entityId, System.Int64 instObjId); // 0x074d26f0
	static System.Void StopRendering(System.Int32 instanceId); // 0x074d2984
	static System.Void ClearCache(); // 0x074d0794
	System.Void Init(); // 0x074cf94c
	System.Void CheckAssetMissing(); // 0x074d2bc0
	System.Boolean SafeCheckLodGroup(UnityEngine.Rendering.Universal.InstanceRenderInfo.LodGroupInfo[] lodGroupInfos, UnityEngine.Rendering.Universal.InstanceRenderInfo.LodGroupInfo[]& ret); // 0x074d3124
	System.Boolean SafeCheckAsset(UnityEngine.Rendering.Universal.InstanceRenderInfo.RendererInfo[] rendererInfos, UnityEngine.Rendering.Universal.InstanceRenderInfo.RendererInfo[]& ret); // 0x074d2e68
	UnityEngine.Rendering.Universal.InstanceRenderInfo GetInfo(System.Int64 entityId, WizardGames.Soc.Common.Component.ConstructionRenderData data, System.Int32 state); // 0x074d33d0
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.MeshTRSData> GetMeshDataList(); // 0x074d361c
	System.Void Alloc(); // 0x074d3680
	System.Void Free(); // 0x074d36ec
	System.Void RefreshLastUseTime(); // 0x074cf9b0
	UnityEngine.Rendering.Universal.InstanceRenderInfo GetGpuTreeInstanceRenderInfo(UnityEngine.Vector3 pos, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale); // 0x074d388c
	System.Void CreateLodGroupInfo(); // 0x074d3a54
	UnityEngine.Rendering.Universal.InstanceRenderInfo.LodGroupInfo GetLodGroupInfo(UnityEngine.LODGroup lodGroup, UnityEngine.Matrix4x4 prefabInv); // 0x074d3e20
	UnityEngine.Rendering.Universal.InstanceRenderInfo.RendererInfo GetRendererInfo(UnityEngine.Renderer renderer, UnityEngine.Matrix4x4 prefabInv); // 0x074d4404
	System.Int64 GetGpuInstanceKey(); // 0x074d4864
	static System.Int64 GenerateKey(); // 0x074d48f8
	System.Void .ctor(); // 0x074d4988
	static System.Void .cctor(); // 0x074d4a94
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.TransPRData : System.Object
{
	UnityEngine.Transform transform; // 0x10
	UnityEngine.Vector3 postion; // 0x18
	UnityEngine.Vector3 rotation; // 0x24
	UnityEngine.Vector3 scale; // 0x30
	System.Void .ctor(); // 0x074d4c40
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.OutsideAnimColliderConfig : UnityEngine.MonoBehaviour
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.TransPRData> defaultTRSInfo; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.TransPRData> anim1TRSInfo; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.TransPRData> anim2TRSInfo; // 0x40
	static System.Void Show(WizardGames.Soc.Common.Unity.Construction.OutsideAnimColliderConfig self, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.TransPRData> lst); // 0x074d4ca8
	System.Void ShowAnimByDoorFlag(System.Int32 flag); // 0x074d4fc0
	System.Void .ctor(); // 0x074d5070
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SubMovableMeshConfig : System.Object
{
	UnityEngine.Matrix4x4 TransToParent; // 0x10
	UnityEngine.Rendering.Universal.InstanceRenderInfo.PrefabInfo prefabinfo; // 0x50
	UnityEngine.Rendering.Universal.InstanceRenderInfo GetInfo(System.Int64 entityId, WizardGames.Soc.Common.Component.ConstructionRenderData data); // 0x074d50d8
	System.Void Submit(WizardGames.Soc.Common.Component.ConstructionRenderData data); // 0x074d5324
	static System.Void SubmitAllSub(WizardGames.Soc.Common.Component.ConstructionRenderData data); // 0x074d549c
	static System.Void CancelAllSub(WizardGames.Soc.Common.Component.ConstructionRenderData data); // 0x074d5820
	System.Void .ctor(); // 0x074d5a40
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SubMovableMeshConfigNodes : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x074d5aa8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.RuntimeSockets.BlueprintTerrainRuntimeSocket : System.Object
{
	UnityEngine.Quaternion localRotation; // 0x10
	UnityEngine.Vector3 LocalPosition; // 0x20
	System.Void Init(UnityEngine.Vector3 localPosition, UnityEngine.Quaternion localRotation); // 0x074d5b10
	WizardGames.Soc.Common.Unity.Construction.Placement DoPlacement(WizardGames.Soc.Common.Unity.Construction.BuildingTarget& target); // 0x074d5be8
	System.Void .ctor(); // 0x074d5f70
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Config.DigConfig : UnityEngine.MonoBehaviour
{
	UnityEngine.GameObject QuarryOutput; // 0x30
	UnityEngine.GameObject QuarryEngine; // 0x38
	UnityEngine.GameObject QuarryInput1; // 0x40
	UnityEngine.GameObject QuarryInput2; // 0x48
	UnityEngine.SkinnedMeshRenderer Render0; // 0x50
	UnityEngine.SkinnedMeshRenderer Render2; // 0x58
	UnityEngine.SkinnedMeshRenderer Render1; // 0x60
	UnityEngine.GameObject PumpjackOutput; // 0x68
	UnityEngine.GameObject PumpjackEngine; // 0x70
	UnityEngine.GameObject PumpjackInput1; // 0x78
	UnityEngine.GameObject PumpjackInput2; // 0x80
	UnityEngine.Transform PumpjackScroll; // 0x88
	System.Void .ctor(); // 0x074d5fd8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Config.MeshObstacle : System.Object
{
	UnityEngine.AI.NavMeshObstacleShape _shape; // 0x10
	UnityEngine.Vector3 _center; // 0x14
	UnityEngine.Vector3 _size; // 0x20
	System.Single _radius; // 0x2c
	System.Single _height; // 0x30
	System.Boolean _carving; // 0x34
	System.Boolean _carveOnlyStationary; // 0x35
	System.Single _carvingMoveThreshold; // 0x38
	System.Single _carvingTimeToStationary; // 0x3c
	System.Boolean _isStatic; // 0x40
	System.Void .ctor(); // 0x074d6040
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Config.MeshObstacleSet : System.Object
{
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Config.MeshObstacle> _obstacles; // 0x10
	System.Void .ctor(); // 0x074d60a8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Config.MeshObstaclePrefabConfig : System.Object
{
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Config.MeshObstacleSet> _obstacleSets; // 0x10
	System.String _prefab; // 0x18
	System.Void .ctor(); // 0x074d615c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Config.MeshObstacleConfig : Sirenix.OdinInspector.SerializedScriptableObject
{
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Config.MeshObstaclePrefabConfig> _obstaclePrefabConfigs; // 0x58
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Config.MeshObstaclePrefabConfig> get_ObstaclePrefabConfigs(); // 0x074d6210
	System.Void set_ObstaclePrefabConfigs(System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Config.MeshObstaclePrefabConfig> value); // 0x074d6274
	System.Void .ctor(); // 0x074d62f4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Config.MgrConfigPhysicsLayer : System.Object
{
	static System.Int32 LayerDefault; // 0x0
	static System.Int32 LayerIgnoreRaycast; // 0x4
	static System.Int32 LayerPlayerCapsule; // 0x8
	static System.Int32 LayerHorseBody; // 0xc
	static System.Int32 LayerHorseHead; // 0x10
	static System.Int32 LayerPlayerSleep; // 0x14
	static System.Int32 LayerHitDetail; // 0x18
	static System.Int32 LayerGround; // 0x1c
	static System.Int32 LayerConstruction; // 0x20
	static System.Int32 LayerSocket; // 0x24
	static System.Int32 LayerPreventBuilding; // 0x28
	static System.Int32 LayerRagDoll; // 0x2c
	static System.Int32 LayerSceneItem; // 0x30
	static System.Int32 LayerWater; // 0x34
	static System.Int32 LayerTrigger; // 0x38
	static System.Int32 LayerAI; // 0x3c
	static System.Int32 LayerInteraction; // 0x40
	static System.Int32 LayerVehicle; // 0x44
	static System.Int32 LayerIgnoreCollider; // 0x48
	static System.Int32 LayerUI; // 0x4c
	static System.Int32 LayerVirtualConstruction; // 0x50
	static System.Int32 LayerNature; // 0x54
	static System.Int32 LayerCollidingNothing; // 0x58
	static System.Int32 LayerStandAndHit; // 0x5c
	static System.Int32 LayerIgnoreSelf; // 0x60
	static System.Int32 MaskDefault; // 0x64
	static System.Int32 MaskIgnoreRayCast; // 0x68
	static System.Int32 MaskHitDetail; // 0x6c
	static System.Int32 MaskGround; // 0x70
	static System.Int32 MaskConstruction; // 0x74
	static System.Int32 MaskSocket; // 0x78
	static System.Int32 MaskRagDoll; // 0x7c
	static System.Int32 MaskSceneItem; // 0x80
	static System.Int32 MaskWater; // 0x84
	static System.Int32 MaskTrigger; // 0x88
	static System.Int32 MaskAI; // 0x8c
	static System.Int32 MaskInteraction; // 0x90
	static System.Int32 MaskPreventBuilding; // 0x94
	static System.Int32 MaskPlayerCapsule; // 0x98
	static System.Int32 MaskHorseBody; // 0x9c
	static System.Int32 MaskHorseHead; // 0xa0
	static System.Int32 MaskPlayerSleep; // 0xa4
	static System.Int32 MaskIgnoreCollider; // 0xa8
	static System.Int32 MaskVehicle; // 0xac
	static System.Int32 MaskVirtualConstruction; // 0xb0
	static System.Int32 MaskNature; // 0xb4
	static System.Int32 MaskCollidingNothing; // 0xb8
	static System.Int32 MaskStandAndHit; // 0xbc
	static System.Int32 MaskIgnoreSelf; // 0xc0
	static System.Int32 MaskEffect; // 0xc4
	static System.Int32 MaskCheckBatchRecoverConstruction; // 0xc8
	static System.Int32 MaskEntityLineOfSightCheck; // 0xcc
	static System.Int32 MaskRainFall; // 0xd0
	static System.Int32 MaskHit; // 0xd4
	static System.Int32 MaskProjectile; // 0xd8
	static System.Int32 MaskBomb; // 0xdc
	static System.Int32 MaskSceneExceptGround; // 0xe0
	static System.Int32 MaskAimSnap; // 0xe4
	static System.Int32 MaskScene; // 0xe8
	static System.Int32 CameraMaskScene; // 0xec
	static System.Int32 MaskCCMTD; // 0xf0
	static System.Int32 MaskCCMTDWithOutCon; // 0xf4
	static System.Int32 MaskTelescope; // 0xf8
	static System.Int32 MaskTerrain; // 0xfc
	static System.Int32 MaskMove; // 0x100
	static System.Int32 MaskCombatMarkerHit; // 0x104
	static System.Int32 MaskHorseMove; // 0x108
	static System.Int32 MaskNonHumanCorpseMove; // 0x10c
	static System.Int32 MaskHelicopterHover; // 0x110
	static System.Int32 MaskHelicopterMove; // 0x114
	static System.Int32 MaskSleep; // 0x118
	static System.Int32 MaskCheckCommonDeploy; // 0x11c
	static System.Int32 MaskPlayerRay; // 0x120
	static System.Int32 MaskHorseRay; // 0x124
	static System.Int32 MaskMountable; // 0x128
	static System.Int32 MaskPlayerCCT; // 0x12c
	static System.Int32 MaskPlayerLadderDown; // 0x130
	static System.Int32 MaskTpHeldItemHide; // 0x134
	static System.Int32 MaskMeleeRaycast; // 0x138
	static System.Int32 MaskMeleeBoxRaycast; // 0x13c
	static System.Int32 MaskMassiveMeleeHitBoxBlockCerti; // 0x140
	static System.Int32 MaskMassiveMeleeHitRayBlockCerti; // 0x144
	static System.Int32 MaskLinkSocket; // 0x148
	static System.Int32 MaskTerrainPlacement; // 0x14c
	static System.Int32 MaskWireTool; // 0x150
	static System.Int32 MaskTerrainPlacementComplex; // 0x154
	static System.Int32 MaskVehicleHit; // 0x158
	static System.Int32 MaskNavmesh; // 0x15c
	static System.Int32 MaskEditMode; // 0x160
	static System.Int32 MaskParachute; // 0x164
	static System.Int32 MaskDismountCheck; // 0x168
	static System.Int32 HorseCanEat; // 0x16c
	static System.Int32 StaticSolid; // 0x170
	static System.Int32 MagicFieldCheck; // 0x174
	static System.Int32 MaskTriggerHurtWallBlockCheck; // 0x178
	static System.Int32 CorpseFallDownCheck; // 0x17c
	static System.Int32 MaskTurretLine; // 0x180
	static System.Int32 MaskBlockLight; // 0x184
	static System.Int32 SceneItem; // 0x188
	static System.Int32 BoxItem; // 0x18c
	static System.Int32 TrainTrackLayer; // 0x190
	static System.Int32 MaskVehicleDynamicsGroundCheck; // 0x194
	static System.Int32 MaskHeadBlockCheck; // 0x198
	static System.Int32 MaskVehicleBlockCheck; // 0x19c
	static System.Int32 MaskHorseBodyBlockCheck; // 0x1a0
	static System.Int32 MaskVehicleWallHackingCheck; // 0x1a4
	static System.Int32 MaskVehicleFlyCheck; // 0x1a8
	static System.Int32 MaskLockingBlockCheck; // 0x1ac
	static System.Int32 MaskSleepGroupCheck; // 0x1b0
	static System.Int32 MaskDecal; // 0x1b4
	static System.Int32 Mask(System.Int32 layerIndex); // 0x074d63a8
	static System.Boolean MaskHasLayer(System.Int32 layerIndex, System.Int32 layerMask); // 0x074d6410
	static System.Boolean IsHurtLayer(System.Int32 layerIndex); // 0x074d64b8
	static System.Boolean IsEffectLayer(System.Int32 layerIndex); // 0x074d654c
	static System.Void .cctor(); // 0x074d65e0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Config.ActionTagPair : System.Object
{
	System.String ActionName; // 0x10
	System.Collections.Generic.List<System.String> ActionTagList; // 0x18
	System.Void .ctor(); // 0x074d6f20
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Config.MonsterBehaviorConfig : UnityEngine.ScriptableObject
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Config.ActionTagPair> ActionTagPairList; // 0x18
	System.Boolean ContainActionName(System.String actionName); // 0x074d6ff8
	System.Void ClearActionName(System.String actionName); // 0x074d7194
	System.Void AddActionTag(System.String actionName, System.String actionTag); // 0x074d75ec
	System.Void CreateActionTagList(System.String actionName); // 0x074d7a8c
	System.Boolean ContainsActionTag(System.String actionName, System.String actionTag); // 0x074d7c04
	System.Void .ctor(); // 0x074d80b0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Config.MonsterBehaviorConfig.<>c__DisplayClass2_0 : System.Object
{
	System.String actionName; // 0x10
	System.Func<WizardGames.Soc.Common.Unity.Config.ActionTagPair,System.Boolean> <>9__0; // 0x18
	System.Void .ctor(); // 0x074d7584
	System.Boolean <ClearActionName>b__0(WizardGames.Soc.Common.Unity.Config.ActionTagPair tag); // 0x074d8164
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Config.MonsterBehaviorConfig.<>c__DisplayClass3_0 : System.Object
{
	System.String actionName; // 0x10
	System.Func<WizardGames.Soc.Common.Unity.Config.ActionTagPair,System.Boolean> <>9__0; // 0x18
	System.Void .ctor(); // 0x074d7a24
	System.Boolean <AddActionTag>b__0(WizardGames.Soc.Common.Unity.Config.ActionTagPair tag); // 0x074d81ec
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Config.MonsterBehaviorConfig.<>c__DisplayClass5_0 : System.Object
{
	System.String actionName; // 0x10
	System.String actionTag; // 0x18
	System.Func<WizardGames.Soc.Common.Unity.Config.ActionTagPair,System.Boolean> <>9__1; // 0x20
	System.Void .ctor(); // 0x074d8048
	System.Boolean <ContainsActionTag>b__1(WizardGames.Soc.Common.Unity.Config.ActionTagPair tag); // 0x074d8274
	System.Boolean <ContainsActionTag>b__0(System.String tag); // 0x074d82fc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	SerializableDictionary<System.UInt64,UnityEngine.Transform> pointCache; // 0x30
	WizardGames.Soc.Common.Unity.Animation.SerializeBoneSkeletonTree serializeBoneTree; // 0x38
	KAnimation.Common.UnsafeBoneSkeletonTree originalBoneTree; // 0x40
	System.Int32 RootInstanceId; // 0x48
	System.Void Awake(); // 0x074d837c
	System.Void OnDestroy(); // 0x074d84ec
	static WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent ApplyObjectPointComponentToGo(UnityEngine.GameObject go); // 0x074d857c
	System.Void BuildNativeData(); // 0x074d83e0
	System.Void ForceRebuildData(); // 0x074d8864
	UnityEngine.Transform GetChildPoint(System.String inName, System.Boolean includeChildren); // 0x074d8ba0
	System.Int32 GetChildPointInstanceId(System.String inName, System.Boolean includeChildren); // 0x074d8fe8
	System.Int32 GetChildPointInstanceId(System.UInt64 inNameHash, System.Boolean includeChildren); // 0x074d8cc0
	System.Boolean TryGetChildPoint(System.String inName, UnityEngine.Transform& child, System.Boolean includeChildren); // 0x074d9080
	System.Boolean TryGetChildPointInstanceId(System.String inName, System.Int32& child, System.Boolean includeChildren); // 0x074d9558
	System.Boolean TryGetChildPointInstanceId(System.UInt64 inNameHash, System.Int32& child, System.Boolean includeChildren); // 0x074d9210
	System.Void Foreach(System.Func<UnityEngine.Transform,System.Boolean> transCbk); // 0x074d9608
	System.Void .ctor(); // 0x074d9b08
	static System.Void .cctor(); // 0x074d9c38
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.HeldItem.IWeaponClipHandle : 
{
	
	System.Void StartReloadLoop(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.Entity.IHaveBulletEntity weapon, System.Int64 seqID, System.Int32 maxAmmo); // 0x0552c3e8
	System.Void ReloadSetClip(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.Entity.IHaveBulletEntity weapon); // 0x0552af00
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.BaseFireWeaponController : WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.BaseHeldItemController
{
	
	System.Boolean CanFireWarm(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074d9cd0
	System.Boolean CanBowFire(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074d9eac
	System.Boolean CanFire(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x054dec74
	System.Void EnterFire(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074da55c
	System.Void DoFire(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x05523a54
	System.Boolean Firing(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dad58
	System.Boolean IsStepReloading(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074daf5c
	System.Boolean CanReload(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074db084
	System.Void BeginReload(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074db188
	WizardGames.Soc.Common.Entity.PlayerActionStateReloadEnum CheckNextReloadState(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074db344
	System.Void EnterReloadSubState(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams playerLogicParams, WizardGames.Soc.Common.Entity.PlayerActionStateReloadEnum state); // 0x074db444
	System.Int32 ReloadUpdate(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams playerLogicParams); // 0x074db998
	System.Int32 OnReloadStart(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams playerLogicParams); // 0x074dbabc
	System.Int32 OnReloadLoop(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams playerLogicParams); // 0x074dbd00
	System.Int32 OnReloadEnd(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams playerLogicParams); // 0x074dbde8
	System.Int32 OnReloadNone(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams playerLogicParams); // 0x074dbfa0
	System.Void DoReloadLoop(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dc018
	System.Boolean ReloadLooping(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dc268
	System.Boolean QuickDrawing(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dc2e8
	System.Boolean CanAdsOn(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dc534
	System.Int32 GetAdsOnTime(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dc71c
	System.Int32 GetAdsOffTime(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dc844
	System.Boolean CanBolt(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dc96c
	System.Void UpdateFireTime(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams, WizardGames.Soc.Common.CustomType.WeaponCustom weapon); // 0x074da63c
	System.Void OnDoFire(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x05523a54
	System.Void .ctor(); // 0x074dc9e4
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.FireState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.FireState NotReady = -1;
	static WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.FireState Allow = 0;
	static WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.FireState NeedReload = 1;
	static WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.FireState InInterval = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.ReloadState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.ReloadState NotReady = -1;
	static WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.ReloadState Allow = 0;
	static WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.ReloadState EmptyInventory = 1;
	static WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.ReloadState InInterval = 2;
	static WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.ReloadState WaitToEnd = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.ClipState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.ClipState ClipEmpty = 0;
	static WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.ClipState ClipIn01 = 1;
	static WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.ClipState ClipFull = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.BaseHeldItemController : System.Object
{
	static SocLogger logger; // 0x0
	static System.Collections.Concurrent.ConcurrentDictionary<System.Int64,WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.BaseHeldItemController> controllers; // 0x8
	static WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.BaseHeldItemController DefaultController; // 0x10
	System.Boolean CanSwitch(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dca70
	System.Void DoArrange(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dcb98
	System.Boolean Switching(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dcc0c
	System.Boolean QuickDrawing(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dccf0
	System.Void EnterFire(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dcd68
	System.Boolean CanFire(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dcddc
	System.Boolean CanFireWarm(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dce54
	System.Boolean CanBowFire(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dcecc
	System.Void DoFire(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dcf44
	System.Boolean Firing(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dcfb8
	System.Boolean CanReload(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dd030
	System.Void BeginReload(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dd0a8
	System.Int32 ReloadUpdate(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dd11c
	WizardGames.Soc.Common.Entity.PlayerActionStateReloadEnum CheckNextReloadState(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dd194
	System.Void EnterReloadSubState(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams playerLogicParams, WizardGames.Soc.Common.Entity.PlayerActionStateReloadEnum state); // 0x074dd20c
	System.Boolean IsStepReloading(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dd288
	System.Void DoReloadLoop(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dd300
	System.Boolean ReloadLooping(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dd374
	System.Boolean CanAttack(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dd3ec
	System.Void DoAttack(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x05523a54
	System.Boolean CanUse(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dd56c
	System.Boolean CanReceiveFireCmd(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dd5e4
	System.Void DoUse(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams, System.Boolean isCombo); // 0x0552af28
	System.Boolean Using(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dd76c
	System.Boolean CanThrow(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dd7e4
	System.Void DoThrow(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x05523a54
	System.Int32 GetAdsOnTime(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dd98c
	System.Int32 GetAdsOffTime(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dda04
	System.Boolean CanAdsOn(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dda7c
	System.Void DoAdsOn(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074ddaf4
	System.Boolean CanBolt(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074ddb68
	System.Boolean NeedStartUp(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074ddbe0
	System.Int32 GetReloadEndStateTime(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams, System.Int32& animatorStateTime); // 0x074ddc58
	static WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.BaseHeldItemController GetController(WizardGames.Soc.Common.Entity.IHeldItemEntity entity); // 0x074ddf8c
	System.Boolean DoReloadLooping(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074de76c
	System.Void CheckSetClip(WizardGames.Soc.Common.Entity.IHaveBulletEntity helditem, WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074de89c
	System.Void .ctor(); // 0x074dea34
	static System.Void .cctor(); // 0x074dea9c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.EokaPistolController : WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.BaseFireWeaponController
{
	
	System.Void EnterFire(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074debec
	System.Boolean CanFire(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x054dec74
	System.Boolean Firing(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dee10
	System.Void .ctor(); // 0x074de56c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.FlameThrowerController : WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.BaseFireWeaponController
{
	
	System.Boolean CanFire(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074df0ec
	System.Void EnterFire(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074df1a4
	System.Void DoFire(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074df2d0
	System.Boolean Firing(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074df474
	System.Void .ctor(); // 0x074de504
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.HeldItemController : WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.BaseHeldItemController
{
	
	System.Boolean CanUse(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074df768
	System.Boolean CanReceiveFireCmd(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074dfb78
	System.Void DoUse(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams, System.Boolean isCombo); // 0x074dfdfc
	System.Boolean Using(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074e03ec
	System.Void DoArrange(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074e04ec
	System.Boolean QuickDrawing(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074e0584
	System.Boolean CanThrow(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074e07d0
	System.Void DoThrow(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074e0b80
	System.Void .ctor(); // 0x074de65c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.SustainMeleeController : WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.BaseHeldItemController
{
	
	System.Boolean IsStepReloading(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074e0bfc
	System.Boolean CanReload(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074e0c74
	System.Void BeginReload(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074e0e1c
	WizardGames.Soc.Common.Entity.PlayerActionStateReloadEnum CheckNextReloadState(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074e1098
	System.Void EnterReloadSubState(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams playerLogicParams, WizardGames.Soc.Common.Entity.PlayerActionStateReloadEnum state); // 0x074e1198
	System.Int32 ReloadUpdate(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams playerLogicParams); // 0x074e14e4
	System.Int32 OnReloadLoop(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams playerLogicParams); // 0x074e1598
	System.Void DoReloadLoop(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074e1680
	System.Boolean ReloadLooping(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074e1914
	System.Boolean CanAttack(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074e1990
	System.Void DoAttack(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074e1cac
	System.Void DoArrange(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074e214c
	System.Boolean QuickDrawing(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074e2258
	System.Void EnterSubAttackState(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.CustomType.MeleeCustom melee, WizardGames.Soc.Common.Entity.PlayerAttackStateEnum state); // 0x074e2078
	System.Boolean NeedStartUp(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074e24a4
	System.Void .ctor(); // 0x074de5d4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.ThrowWeaponController : WizardGames.Soc.Common.Unity.HeldItem.HeldItemController.BaseHeldItemController
{
	
	System.Void DoArrange(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074e2650
	System.Boolean CanThrow(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074e26c4
	System.Void DoThrow(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x074e293c
	System.Void .ctor(); // 0x074de6e4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Vehicle.Parachute.ParachuteMeta : UnityEngine.ScriptableObject
{
	UnityEngine.AnimationCurve VelocityCurveFY; // 0x18
	UnityEngine.AnimationCurve VelocityCurveFZ; // 0x20
	UnityEngine.AnimationCurve VelocityCurveBY; // 0x28
	UnityEngine.AnimationCurve VelocityCurveBZ; // 0x30
	UnityEngine.AnimationCurve RotSpeedCurve; // 0x38
	System.Void .ctor(); // 0x074e29b8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Vehicle.Horse.HorseMeta : UnityEngine.ScriptableObject
{
	UnityEngine.AnimationCurve VelocityCurveF; // 0x18
	UnityEngine.AnimationCurve VelocityCurveB; // 0x20
	UnityEngine.AnimationCurve VelocityCurveTurnF; // 0x28
	UnityEngine.AnimationCurve VelocityCurveTurnB; // 0x30
	UnityEngine.AnimationCurve VelocityCurveTurnSprint; // 0x38
	System.Void .ctor(); // 0x074e2a20
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.SocAnimationManager : System.Object
{
	static System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Animation.ISocAnimationRuntime> SocRuntimes; // 0x0
	static WizardGames.Soc.Common.Unity.Animation.ISocAnimationRuntime SelfPlayer_FpRuntime; // 0x8
	static WizardGames.Soc.Common.Unity.Animation.ISocAnimationRuntime SelfPlayer_TpRuntime; // 0x10
	static System.Int64 SelfPlayerId; // 0x18
	static System.Func<WizardGames.Soc.Common.Unity.Animation.ISocAnimationRuntime> CreateSocAnimatorRuntime; // 0x20
	static System.Void InitSelfPlayer(System.Int64 Id); // 0x074e2a88
	static WizardGames.Soc.Common.Unity.Animation.ISocAnimationRuntime InitFp(System.Int64 entityId, UnityEngine.Animator animator); // 0x074e2bd4
	static WizardGames.Soc.Common.Unity.Animation.ISocAnimationRuntime Init(System.Int64 entityId, UnityEngine.Animator animator); // 0x074e2d58
	static WizardGames.Soc.Common.Unity.Animation.ISocAnimationRuntime Get(System.Int64 entityId); // 0x074e3078
	static WizardGames.Soc.Common.Unity.Animation.ISocAnimationRuntime GetFp(System.Int64 entityId); // 0x074e3188
	static System.Void Clear(); // 0x074e3240
	static System.Void Remove(System.Int64 entityId); // 0x074e36f8
	static WizardGames.Soc.Common.Unity.Animation.ISocAnimationRuntime InitHorse(System.Int64 entityId, UnityEngine.Animator animator); // 0x074e3994
	static WizardGames.Soc.Common.Unity.Animation.ISocAnimationRuntime InitParachute(System.Int64 entityId, UnityEngine.Animator animator); // 0x074e3bd0
	static System.Void .cctor(); // 0x074e3e0c
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Character.HitLocation : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Character.HitLocation None = 0;
	static WizardGames.Soc.Common.Unity.Character.HitLocation Sides = 1;
	static WizardGames.Soc.Common.Unity.Character.HitLocation Above = 2;
	static WizardGames.Soc.Common.Unity.Character.HitLocation Below = 4;
	
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Character.ICharacterController : 
{
	
	System.Void AddComponent(UnityEngine.GameObject colliderGo, WizardGames.Soc.Common.Data.character.TbChracterParameter cpTb); // 0x0552af00
	System.Void AddCollider(UnityEngine.GameObject colliderGo, WizardGames.Soc.Common.Data.character.TbChracterParameter cpTb); // 0x0552af00
	UnityEngine.Vector3 GetCenter(); // 0x054b1148
	System.Single GetHeight(); // 0x054a5abc
	System.Single GeSkinWidth(); // 0x054a5abc
	System.Single GetRadius(); // 0x054a5abc
	System.Boolean GetConstrainToGround(); // 0x054c4760
	UnityEngine.Vector3 GetUp(); // 0x054b1148
	System.Boolean GetIsGrounded(); // 0x054c4760
	UnityEngine.Vector3 GetPosition(System.Boolean isLocal); // 0x054b1f94
	System.Boolean GetEnable(); // 0x054c4760
	System.Void SetStepOffset(System.Single stepOffset); // 0x05513724
	UnityEngine.LayerMask GetCollisionLayers(); // 0x054a7c98
	UnityEngine.Vector3 GetLocalEulerAngles(); // 0x054b1148
	UnityEngine.Transform GetTransform(); // 0x054e7844
	System.Void SetExcludeLayers(UnityEngine.LayerMask layer); // 0x05514540
	System.Void SetLocalEulerAngles(UnityEngine.Vector3 euler); // 0x05514688
	System.Void SetCollisionLayer(UnityEngine.LayerMask layer); // 0x05514540
	System.Void SetLayer(UnityEngine.LayerMask layer); // 0x05514540
	System.Void SetHeight(System.Single height); // 0x05513724
	System.Void SetCenter(UnityEngine.Vector3 center); // 0x05514688
	System.Void SetTrigger(System.Boolean isTrigger); // 0x05523a7c
	System.Void SetConstrainToGround(System.Boolean constrainToGround); // 0x05523a7c
	System.Void SetPosition(UnityEngine.Vector3 pos, System.Boolean isLocal); // 0x0551b6b0
	System.Void SyncPose(); // 0x055049cc
	System.Int32 Move(UnityEngine.Vector3 moveVector, System.Single deltaTime); // 0x05494600
	System.Boolean FindGround(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Collider myCollider, UnityEngine.Collider lastGroundCollider, UnityEngine.Vector3& res, UnityEngine.Collider& collider, System.Boolean& hitLastCollider); // 0x054d3bd4
	System.Boolean FindGround(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3& res, UnityEngine.RaycastHit& raycastHit); // 0x054d3b50
	System.Void SetInPlatform(System.Boolean inPlatform); // 0x05523a7c
	System.Boolean GetInPlatform(); // 0x054c4760
	UnityEngine.CharacterController GetCC(); // 0x054e7844
	System.Void ComputeMTD(System.Int32 maxIter, UnityEngine.Collider overlapCollider); // 0x0550f6d4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.SocCharacterController : System.Object
{
	System.Collections.Generic.HashSet<WizardGames.Soc.Common.Unity.Character.SocCharacterController.LayerState> layerStates; // 0x10
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.Character.ICharacterController socCharacterController; // 0x18
	System.Single _height; // 0x20
	System.Single _radius; // 0x24
	System.Boolean _isGrounded; // 0x28
	UnityEngine.Vector3 _center; // 0x2c
	System.Single _skinWidth; // 0x38
	System.Boolean _isEnable; // 0x3c
	System.String _name; // 0x40
	System.Single _slopeLimit; // 0x48
	System.Single _stepOffset; // 0x4c
	System.Boolean _isLocalPosition; // 0x50
	UnityEngine.Vector3 _localPosition; // 0x54
	UnityEngine.Vector3 _position; // 0x60
	UnityEngine.LayerMask _layer; // 0x6c
	UnityEngine.LayerMask _excludeLayers; // 0x70
	System.Action<UnityEngine.Vector3> OnSetCenter; // 0x78
	System.Boolean isChangeHeight; // 0x80
	System.Boolean isChangeStepOffset; // 0x81
	System.Boolean isChangeLayer; // 0x82
	System.Boolean isChangePosition; // 0x83
	System.Boolean isChangeExcludeLayers; // 0x84
	static System.Single MAX_POSITION = 10000;
	static System.Single MIN_POSITION = -10000;
	[ThreadStatic] static System.Int32 mainThreadMark;
	System.Int32 temp; // 0x88
	System.Boolean get_IsInMainThread(); // 0x074e3ec0
	static System.Void SetMainThreadMark(); // 0x074e3f58
	System.Void .ctor(); // 0x074e4018
	System.Void AddComponent(UnityEngine.GameObject colliderGo, WizardGames.Soc.Common.Data.character.TbChracterParameter cpTb); // 0x074e41e8
	System.Void AddCollider(UnityEngine.GameObject colliderGo, WizardGames.Soc.Common.Data.character.TbChracterParameter cpTb); // 0x074e4a4c
	System.Void SetCollisionLayer(UnityEngine.LayerMask layer); // 0x074e4b30
	System.Void SetLayer(UnityEngine.LayerMask layer); // 0x074e4c0c
	UnityEngine.Vector3 GetCenter(); // 0x074e4d10
	System.Single GetHeight(); // 0x074e4d74
	System.Single GetSkinWidth(); // 0x074e4dd8
	System.Single GetRadius(); // 0x074e4e3c
	System.Boolean GetIsGrounded(); // 0x074e4ea0
	System.Void SetIsGrounded(System.Boolean g); // 0x074e4f04
	UnityEngine.Vector3 GetPosition(); // 0x074e4f80
	System.Boolean GetEnable(); // 0x074e4fec
	System.String GetName(); // 0x074e5050
	System.Boolean GetConstrainToGround(); // 0x074e50b4
	UnityEngine.Vector3 GetUp(); // 0x074e51f0
	System.Single GetSlopeLimit(); // 0x074e5360
	System.Single GetStepOffset(); // 0x074e53c4
	System.Void SetStepOffset(System.Single stepOffset); // 0x074e5428
	UnityEngine.LayerMask GetCollisionLayers(); // 0x074e4724
	UnityEngine.Vector3 GetLocalEulerAngles(); // 0x074e552c
	UnityEngine.Transform GetTransform(); // 0x074e55f8
	System.Void GetInVehicle(System.Int64 playerEntityId); // 0x074e56c4
	System.Void GetOutVehicle(); // 0x074e57a8
	System.Void RecordGetOutVehicle(System.Int64 playerEntityId); // 0x074e5810
	System.Void SetExcludeLayers(UnityEngine.LayerMask layerMask); // 0x074e58e8
	System.Void AddLayerState(WizardGames.Soc.Common.Unity.Character.SocCharacterController.LayerState _state); // 0x074e48bc
	System.Void RemoveLayerState(WizardGames.Soc.Common.Unity.Character.SocCharacterController.LayerState _state); // 0x074e4984
	UnityEngine.LayerMask GetExcludeLayerMask(); // 0x074e59f8
	System.Void EnterMantel(); // 0x074e5c84
	System.Void ExitMantel(); // 0x074e5cec
	System.Void SetEnable(System.Boolean enable); // 0x074e5d54
	System.Void SetConstrainToGround(System.Boolean constrainToGround); // 0x074e5e24
	System.Void SetPosition(UnityEngine.Vector3 pos, System.Boolean isLocal); // 0x074e5f00
	System.Void SetLocalEulerAngles(UnityEngine.Vector3 euler); // 0x074e6278
	System.Void SyncPose(); // 0x074e636c
	System.Int32 Move(UnityEngine.Vector3 moveVector, System.Single deltaTime); // 0x074e6438
	System.Void SetHeightAndCalCenter(System.Single height, System.Boolean fireMsg); // 0x074e6780
	System.Void SyncValueInMainThread(); // 0x074e6af8
	System.Void SetTrigger(System.Boolean isTrigger); // 0x074e6c80
	System.Boolean FindGround(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Collider myCollider, UnityEngine.Collider lastGroundCollider, UnityEngine.Vector3& res, UnityEngine.Collider& collider, System.Boolean& hitLastCollider); // 0x074e6d5c
	System.Boolean FindGround(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3& res, UnityEngine.RaycastHit& raycastHit); // 0x074e6ec0
	System.Void SetInPlatform(System.Boolean inPlatform); // 0x074e6ffc
	System.Boolean GetInPlatform(); // 0x074e710c
	UnityEngine.CharacterController GetCC(); // 0x074e47f0
	System.Void ComputeMTD(System.Int32 maxIter, UnityEngine.Collider overlapCollider); // 0x074e71d8
	static System.Void .cctor(); // 0x074e735c
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Character.SocCharacterController.LayerState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Character.SocCharacterController.LayerState Platform = 0;
	static WizardGames.Soc.Common.Unity.Character.SocCharacterController.LayerState Vehicle = 1;
	static WizardGames.Soc.Common.Unity.Character.SocCharacterController.LayerState Mantle = 2;
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.CcParams : System.ValueType
{
	System.Single SkinWidth; // 0x10
	System.Single SlopeLimit; // 0x14
	System.Single StepOffset; // 0x18
	System.Single Radius; // 0x1c
	System.Single CcHeight; // 0x20
	System.Single CcMinMoveDistance; // 0x24
	UnityEngine.Vector3 CcCenter; // 0x28
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.SocUnityCharacterController : System.Object, WizardGames.Soc.Common.Unity.Character.ICharacterController
{
	static SocLogger logger; // 0x0
	UnityEngine.GameObject colliderGo; // 0x10
	WizardGames.Soc.Common.Combat.ColliderConfig colliderConfig; // 0x18
	UnityEngine.CharacterController cc; // 0x20
	CCT cct; // 0x28
	UnityEngine.CharacterController CapsuleCollider; // 0x30
	UnityEngine.LayerMask layerMask; // 0x38
	UnityEngine.RaycastHit[] hits; // 0x40
	static System.Int32 MaxOverlapColliderCount; // 0x8
	static UnityEngine.Collider[] OverlapColliders; // 0x10
	System.Collections.Generic.List<UnityEngine.RaycastHit> hitList; // 0x48
	System.Boolean inPlatform; // 0x50
	System.Void AddComponent(UnityEngine.GameObject colliderGo, WizardGames.Soc.Common.Data.character.TbChracterParameter cpTb); // 0x074e7430
	System.Void AddCollider(UnityEngine.GameObject colliderGo, WizardGames.Soc.Common.Data.character.TbChracterParameter cpTb); // 0x074e7a6c
	System.Void SetCollisionLayer(UnityEngine.LayerMask layer); // 0x074e7d04
	System.Void SetLayer(UnityEngine.LayerMask layer); // 0x074e7d7c
	UnityEngine.Vector3 GetCenter(); // 0x074e7e60
	System.Single GetHeight(); // 0x074e7ed0
	System.Single GeSkinWidth(); // 0x074e7fbc
	System.Single GetRadius(); // 0x074e802c
	System.Boolean GetIsGrounded(); // 0x074e8118
	UnityEngine.Vector3 GetPosition(System.Boolean isLocal); // 0x074e81a8
	System.Boolean GetEnable(); // 0x074e829c
	System.Boolean GetConstrainToGround(); // 0x074e830c
	UnityEngine.Vector3 GetUp(); // 0x074e8370
	System.Void SetStepOffset(System.Single stepOffset); // 0x074e83ec
	UnityEngine.LayerMask GetCollisionLayers(); // 0x074e8474
	UnityEngine.Vector3 GetLocalEulerAngles(); // 0x074e84d8
	UnityEngine.Transform GetTransform(); // 0x074e8554
	System.Void SetExcludeLayers(UnityEngine.LayerMask layer); // 0x074e85c4
	System.Void SetConstrainToGround(System.Boolean constrainToGround); // 0x074e864c
	System.Void SetPosition(UnityEngine.Vector3 pos, System.Boolean isLocal); // 0x074e86c0
	System.Void SetLocalEulerAngles(UnityEngine.Vector3 euler); // 0x074e87c8
	System.Void SetInPlatform(System.Boolean ip); // 0x074e8880
	System.Boolean GetInPlatform(); // 0x074e88fc
	UnityEngine.CharacterController GetCC(); // 0x074e8960
	System.Void SyncPose(); // 0x074e89c4
	System.Int32 Move(UnityEngine.Vector3 moveVector, System.Single deltaTime); // 0x074e8a34
	System.Void SetHeight(System.Single height); // 0x074e8ba0
	System.Void SetCenter(UnityEngine.Vector3 center); // 0x074e8cd0
	System.Void SetTrigger(System.Boolean isTrigger); // 0x074e8e10
	System.Boolean FindGround(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Collider myCollider, UnityEngine.Collider lastGroundCollider, UnityEngine.Vector3& res, UnityEngine.Collider& collider, System.Boolean& hitLastCollider); // 0x074e8e84
	System.Boolean FindGround(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3& res, UnityEngine.RaycastHit& raycastHit); // 0x074e94e4
	System.Void ComputeGroundDistance(UnityEngine.Vector3 characterPosition, UnityEngine.Quaternion characterRotation, System.Single sweepRadius, System.Single sweepDistance, System.Single castDistance, WizardGames.Soc.Common.Unity.Character.SocUnityCharacterController.FindGroundResult& outGroundResult); // 0x074e9690
	System.Boolean GroundSweepTest(UnityEngine.Vector3 characterPosition, UnityEngine.Quaternion characterRotation, System.Single capsuleRadius, System.Single capsuleHalfHeight, System.Single sweepDistance, UnityEngine.RaycastHit& hitResult, System.Boolean& startPenetrating); // 0x074e9c58
	System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, UnityEngine.Vector3 castDirection, System.Single castDistance, System.Int32 castLayerMask, UnityEngine.RaycastHit& hitResult, System.Boolean& startPenetrating); // 0x074eaa0c
	System.Boolean IsWithinEdgeTolerance(UnityEngine.Vector3 characterPosition, UnityEngine.Vector3 inPoint, System.Single testRadius); // 0x074ea034
	WizardGames.Soc.Common.Unity.Character.HitLocation ComputeHitLocation(UnityEngine.Vector3 inNormal); // 0x074ea210
	System.Boolean IsWalkable(UnityEngine.Collider inCollider, UnityEngine.Vector3 inNormal); // 0x074ea300
	System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single distance, System.Int32 layerMask, UnityEngine.RaycastHit& hitResult, System.Single thickness); // 0x074ea5d4
	System.Void ComputeMTD(System.Int32 maxIter, UnityEngine.Collider overlapCollider); // 0x074eae78
	System.Int32 CharacterCollisionsOverlapScene(); // 0x074eafa4
	System.Void ComputeCapsuleRayPoints(System.Single height, System.Single radius, UnityEngine.Vector3 center, UnityEngine.Vector3 dir, UnityEngine.Vector3 position, UnityEngine.Vector3& capsuleDownCenter, UnityEngine.Vector3& capsuleUpCenter); // 0x074eb484
	System.Void SolvePenetration(UnityEngine.Collider[] overlappedColliders, System.Int32 count); // 0x074eb1c0
	System.Void .ctor(); // 0x074e4100
	static System.Void .cctor(); // 0x074eb5d8
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.SocUnityCharacterController.FindGroundResult : System.ValueType
{
	System.Boolean hitGround; // 0x10
	System.Boolean isWalkable; // 0x11
	UnityEngine.Vector3 position; // 0x14
	System.Single groundDistance; // 0x20
	UnityEngine.RaycastHit hitResult; // 0x24
	System.Boolean get_isWalkableGround(); // 0x074ea560
	UnityEngine.Vector3 get_normal(); // 0x074e9bf0
	System.Void SetFromSweepResult(System.Boolean hitGround, System.Boolean isWalkable, UnityEngine.Vector3 position, System.Single sweepDistance, UnityEngine.RaycastHit& inHit, UnityEngine.Vector3 surfaceNormal); // 0x074ea434
	System.Void SetFromRaycastResult(System.Boolean hitGround, System.Boolean isWalkable, UnityEngine.Vector3 position, System.Single sweepDistance, System.Single castDistance, UnityEngine.RaycastHit& inHit); // 0x074ea8e8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.SocUnityHorseController : System.Object, WizardGames.Soc.Common.Unity.Character.ICharacterController
{
	static SocLogger logger; // 0x0
	UnityEngine.GameObject colliderGo; // 0x10
	WizardGames.Soc.Common.Combat.ColliderConfig colliderConfig; // 0x18
	UnityEngine.CharacterController cc; // 0x20
	CCT cct; // 0x28
	UnityEngine.CapsuleCollider CapsuleCollider; // 0x30
	UnityEngine.LayerMask layerMask; // 0x38
	static System.Single SlideDownSlopeTestDistance = 1;
	static System.Single RaycastScaleDistance = 2;
	static System.Single kMaxGroundDistance = 0.10000000149011612;
	static System.Single kKindaSmallNumber = 0.00009999999747378752;
	static System.Single kShrinkScale = 0.8999999761581421;
	static System.Int32 kMaxCollisionCount = 8;
	static System.Single kSweepEdgeRejectDistance = 0.001500000013038516;
	static System.Single kShrinkScaleOverlap = 0.10000000149011612;
	static System.Single kHemisphereLimit = 0.009999999776482582;
	UnityEngine.RaycastHit[] hits; // 0x40
	System.Boolean inPlatform; // 0x48
	System.Void AddComponent(UnityEngine.GameObject colliderGo, WizardGames.Soc.Common.Unity.Character.CcParams ccParams); // 0x074eb6fc
	System.Void AddComponent(UnityEngine.GameObject colliderGo, WizardGames.Soc.Common.Data.character.TbChracterParameter cpTb); // 0x074eb8a0
	System.Void AddCollider(UnityEngine.GameObject colliderGo, WizardGames.Soc.Common.Data.character.TbChracterParameter cpTb); // 0x074ebf88
	System.Void SetCollisionLayer(UnityEngine.LayerMask layer); // 0x074ec184
	System.Void SetLayer(UnityEngine.LayerMask layer); // 0x074ec1fc
	UnityEngine.Vector3 GetCenter(); // 0x074ec2e0
	System.Single GetHeight(); // 0x074ec350
	System.Single GeSkinWidth(); // 0x074ec44c
	System.Single GetRadius(); // 0x074ec4bc
	System.Boolean GetIsGrounded(); // 0x074ec5b8
	UnityEngine.Vector3 GetPosition(System.Boolean isLocal); // 0x074ec648
	System.Boolean GetEnable(); // 0x074ec73c
	System.Boolean GetConstrainToGround(); // 0x074ec7ac
	UnityEngine.Vector3 GetUp(); // 0x074ec810
	System.Single GetStepOffset(); // 0x074ec88c
	System.Void SetStepOffset(System.Single stepOffset); // 0x074ec8fc
	UnityEngine.LayerMask GetCollisionLayers(); // 0x074ec984
	UnityEngine.Vector3 GetLocalEulerAngles(); // 0x074ec9e8
	UnityEngine.Transform GetTransform(); // 0x074eca64
	System.Void SetExcludeLayers(UnityEngine.LayerMask layer); // 0x074ecad4
	System.Void SetConstrainToGround(System.Boolean constrainToGround); // 0x074ecb5c
	System.Void SetPosition(UnityEngine.Vector3 pos, System.Boolean isLocal); // 0x074ecbd0
	System.Void SetLocalEulerAngles(UnityEngine.Vector3 euler); // 0x074eccd8
	System.Void SetInPlatform(System.Boolean ip); // 0x074ecd90
	System.Boolean GetInPlatform(); // 0x074ece0c
	UnityEngine.CharacterController GetCC(); // 0x074ece70
	System.Void SyncPose(); // 0x074eced4
	System.Int32 Move(UnityEngine.Vector3 moveVector, System.Single deltaTime); // 0x074ecf44
	System.Void SetHeight(System.Single height); // 0x074ed0b0
	System.Void SetCenter(UnityEngine.Vector3 center); // 0x074ed1fc
	System.Void SetTrigger(System.Boolean isTrigger); // 0x074ed33c
	System.Boolean FindGround(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Collider myCollider, System.Int64 entityId, UnityEngine.Collider lastGroundCollider, UnityEngine.Vector3& res, UnityEngine.Collider& collider, System.Boolean& hitLastCollider); // 0x074ed3b0
	System.Boolean FindGround(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Collider myCollider, UnityEngine.Collider lastGroundCollider, UnityEngine.Vector3& res, UnityEngine.Collider& collider, System.Boolean& hitLastCollider); // 0x074ed980
	System.Boolean FindSpecialGround(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Collider lastGroundCollider, UnityEngine.Vector3& res, UnityEngine.Collider& collider, System.Boolean& hitLastCollider); // 0x074edd30
	System.Boolean FindGround(UnityEngine.Vector3 pos, UnityEngine.Quaternion rot, UnityEngine.Vector3& res, UnityEngine.RaycastHit& raycastHit); // 0x074ee0e0
	System.Void ComputeGroundDistance(UnityEngine.Vector3 characterPosition, UnityEngine.Quaternion characterRotation, System.Single sweepRadius, System.Single sweepDistance, System.Single castDistance, WizardGames.Soc.Common.Unity.Character.SocUnityHorseController.FindGroundResult& outGroundResult); // 0x074ee28c
	System.Boolean GroundSweepTest(UnityEngine.Vector3 characterPosition, UnityEngine.Quaternion characterRotation, System.Single capsuleRadius, System.Single capsuleHalfHeight, System.Single sweepDistance, UnityEngine.RaycastHit& hitResult, System.Boolean& startPenetrating); // 0x074ee854
	System.Boolean BoxCast(UnityEngine.Vector3 center, UnityEngine.Vector3 halfExtents, UnityEngine.Quaternion orientation, UnityEngine.Vector3 castDirection, System.Single castDistance, System.Int32 castLayerMask, UnityEngine.RaycastHit& hitResult, System.Boolean& startPenetrating); // 0x074ef608
	System.Boolean IsWithinEdgeTolerance(UnityEngine.Vector3 characterPosition, UnityEngine.Vector3 inPoint, System.Single testRadius); // 0x074eec30
	WizardGames.Soc.Common.Unity.Character.HitLocation ComputeHitLocation(UnityEngine.Vector3 inNormal); // 0x074eee0c
	System.Boolean IsWalkable(UnityEngine.Collider inCollider, UnityEngine.Vector3 inNormal); // 0x074eeefc
	System.Boolean Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single distance, System.Int32 layerMask, UnityEngine.RaycastHit& hitResult, System.Single thickness); // 0x074ef1d0
	System.Void ComputeMTD(System.Int32 maxIter, UnityEngine.Collider overlapCollider); // 0x074efa74
	System.Void .ctor(); // 0x074efaf0
	static System.Void .cctor(); // 0x074efb88
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.SocUnityHorseController.FindGroundResult : System.ValueType
{
	System.Boolean hitGround; // 0x10
	System.Boolean isWalkable; // 0x11
	UnityEngine.Vector3 position; // 0x14
	System.Single groundDistance; // 0x20
	UnityEngine.RaycastHit hitResult; // 0x24
	System.Boolean get_isWalkableGround(); // 0x074ef15c
	UnityEngine.Vector3 get_normal(); // 0x074ee7ec
	System.Void SetFromSweepResult(System.Boolean hitGround, System.Boolean isWalkable, UnityEngine.Vector3 position, System.Single sweepDistance, UnityEngine.RaycastHit& inHit, UnityEngine.Vector3 surfaceNormal); // 0x074ef030
	System.Void SetFromRaycastResult(System.Boolean hitGround, System.Boolean isWalkable, UnityEngine.Vector3 position, System.Single sweepDistance, System.Single castDistance, UnityEngine.RaycastHit& inHit); // 0x074ef4e4
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.PlayerLadderAdsorbResult : System.ValueType
{
	Share.Entity.Interface.ILadderEntity ladderEntity; // 0x10
	WizardGames.Soc.Common.Unity.Go.ILadderGo ladderGo; // 0x18
	WizardGames.Soc.Common.Unity.Character.LadderCache ladderCache; // 0x20
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.LadderCache : System.ValueType
{
	System.Boolean Valid; // 0x10
	WizardGames.Soc.Common.Combat.AdsorbCollideConfig adsorbCollideConfig; // 0x18
	System.Int32 adsorbConfigIdx; // 0x20
	WizardGames.Soc.Common.State.Character.LadderTestDir testDir; // 0x24
	WizardGames.Soc.Common.Unity.Character.PlayerLadderAdsorbRule enterRule; // 0x28
	WizardGames.Soc.Common.Unity.Utility.OBB topEnterBounds; // 0x30
	WizardGames.Soc.Common.Unity.Utility.OBB bottomEnterbBounds; // 0x80
	WizardGames.Soc.Common.Unity.Utility.OBB bottomSourceBounds; // 0xd0
	WizardGames.Soc.Common.Unity.Utility.OBB ladderMoveableBounds; // 0x120
	WizardGames.Soc.Common.Unity.Utility.OBB ladderBounds; // 0x170
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Character.LadderSelectPoint : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Character.LadderSelectPoint Left = 0;
	static WizardGames.Soc.Common.Unity.Character.LadderSelectPoint Center = 1;
	static WizardGames.Soc.Common.Unity.Character.LadderSelectPoint Right = 2;
	static WizardGames.Soc.Common.Unity.Character.LadderSelectPoint CC = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Character.LadderSelectInOutPoint : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Character.LadderSelectInOutPoint None = 0;
	static WizardGames.Soc.Common.Unity.Character.LadderSelectInOutPoint In = 1;
	static WizardGames.Soc.Common.Unity.Character.LadderSelectInOutPoint Out = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.PlayerLadderAdsorbRule : System.Object
{
	WizardGames.Soc.Common.Unity.Animation.AnimationWarpingResType RootMotionType; // 0x10
	System.Single EnterLadderAngle; // 0x14
	System.Boolean EnableAngleInteractionTest; // 0x18
	System.Boolean FixNoInput; // 0x19
	SerializableDictionary<WizardGames.Soc.Common.Entity.PlayerPoseStateEnum,System.Int32> AnimMoveSpeedRatio; // 0x20
	System.Int32 AnimRotateSpeed; // 0x28
	System.Boolean EnableViewPitch; // 0x2c
	System.Boolean EnableViewYaw; // 0x2d
	System.Int32 AnimOffsetPitch; // 0x30
	System.Single MaxEnterHeight; // 0x34
	System.Boolean EnableRMCollideDetection; // 0x38
	System.Single MoveCollideThreshold; // 0x3c
	System.Single MoveTestThreshold; // 0x40
	System.Single ExtraDist; // 0x44
	System.Void .ctor(); // 0x074efc5c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.PlayerLadderLeaveRule : System.Object
{
	WizardGames.Soc.Common.Unity.Animation.AnimationWarpingResType RootMotionType; // 0x10
	System.Boolean EnableAnimYaw; // 0x14
	System.Boolean EnableRMCollideDetection; // 0x15
	System.Boolean DerivedSpeed; // 0x16
	System.Int32 LeaveCDForEnter; // 0x18
	System.Int32 LadderExitTolerance; // 0x1c
	System.Boolean CrouchTest; // 0x20
	System.Single CrouchTestThreshold; // 0x24
	System.Boolean TestPrediction; // 0x28
	System.Single TestPredictionDist; // 0x2c
	System.Single MoveTestThreshold; // 0x30
	System.Single MoveCollideThreshold; // 0x34
	System.Single ExtraDist; // 0x38
	System.Void .ctor(); // 0x074efd8c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.PlayerLadderConfig : UnityEngine.ScriptableObject
{
	UnityEngine.LayerMask LadderPreliminaryAdsorbLayer; // 0x18
	UnityEngine.LayerMask LadderPreliminaryCollideLayer; // 0x1c
	UnityEngine.LayerMask LadderTestCollideLayer; // 0x20
	UnityEngine.LayerMask LadderTestGroundLayer; // 0x24
	System.Boolean DbgRootMotionCheck; // 0x28
	System.Single DbgDrawTime; // 0x2c
	System.Single DbgDrawLineTime; // 0x30
	System.Int32 LadderCantMoveTipId; // 0x34
	System.Single EnterLadderHeight; // 0x38
	System.Single LadderFlipThreshold; // 0x3c
	System.Single FlyInMin; // 0x40
	System.Single FlyInMax; // 0x44
	System.Single SpeedTendencyTolerance; // 0x48
	System.Single MoveInThreshold; // 0x4c
	System.Single StepHeight; // 0x50
	System.Single StepUpForwardThreshold; // 0x54
	System.Single MovePredictDist; // 0x58
	System.Single MovePredictCoff; // 0x5c
	System.Single LeaveGroundVec; // 0x60
	System.Single DownLeaveHeight; // 0x64
	System.Boolean hasLadderLeaveSpeed; // 0x68
	System.Single LadderLeaveSpeed; // 0x6c
	System.Single LadderInstectThreshOld; // 0x70
	System.Single BotLeaveThreshOld; // 0x74
	System.Single LadderExtraTop; // 0x78
	System.Single LadderExtraBottom; // 0x7c
	System.Single LadderExtraLR; // 0x80
	System.Single LadderExtraThickness; // 0x84
	System.Single LadderMoveTestExtraThickness; // 0x88
	System.Single MoveToleranceEnterAngle; // 0x8c
	System.Boolean EnableTpMeshRot; // 0x90
	System.Single LadderFlipMeshUpOffset; // 0x94
	System.Int32 TpLadderVisibleFrame; // 0x98
	System.Single LadderTestTolerance; // 0x9c
	SerializableDictionary<WizardGames.Soc.Common.State.Character.LadderTestDir,WizardGames.Soc.Common.Unity.Character.PlayerLadderAdsorbRule> LadderPreliminaryRules; // 0xa0
	SerializableDictionary<WizardGames.Soc.Common.State.Character.LadderTestDir,WizardGames.Soc.Common.Unity.Character.PlayerLadderLeaveRule> LadderLeaveRules; // 0xa8
	System.Void .ctor(); // 0x074efe14
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.PlayerLoader : System.Object
{
	static SocLogger logger; // 0x0
	static System.Boolean UseNewLoad; // 0x8
	static WizardGames.Soc.Common.Unity.Character.PlayerLadderConfig LadderConfig; // 0x10
	static WizardGames.Soc.Common.SocGibConfig GibConfig; // 0x18
	static WizardGames.Soc.Common.Unity.Audio.SocAudioScriptConfig AudioConfig; // 0x20
	static WizardGames.Soc.Common.Unity.Character.PlayerRayCastConfig RayCastConfig; // 0x28
	static WizardGames.Soc.Common.Unity.Character.PlayerAutoDiveConfig AutoDiveConfig; // 0x30
	static UnityEngine.GameObject FpBoneGo; // 0x38
	static System.String fpBonePath; // 0x40
	static UnityEngine.GameObject tpBoneWithHeadGo; // 0x48
	static System.String tpbonePath; // 0x50
	static UnityEngine.GameObject CorpseBoneGo; // 0x58
	static System.String corpseBonePath; // 0x60
	static UnityEngine.GameObject CorpseLieDownGo; // 0x68
	static CommonUnity.Runtime.Character.Resource.SpeedWarpSerializedClipConfigScriptObj SpeedWarpSerializedClipConfig; // 0x70
	static System.String CharacterConfigPath; // 0x78
	static System.UInt64 GoLoadTaskId; // 0x80
	static System.UInt64 AssetLoadTaskId; // 0x88
	static WizardGames.AssetPool.WeakHandle CharacterConfigHandle; // 0x90
	static WizardGames.Soc.Common.Unity.Character.CharacterConfig CharacterConfig; // 0xa0
	static WizardGames.AssetPool.WeakHandle PlayerFpAvatarHandle; // 0xa8
	static WizardGames.AssetPool.WeakHandle PlayerTpAvatarHandle; // 0xb8
	static WizardGames.AssetPool.WeakHandle HorseAvatarHandle; // 0xc8
	static WizardGames.AssetPool.WeakHandle RayCastConfigHandle; // 0xd8
	static WizardGames.AssetPool.WeakHandle AudioConfigHandle; // 0xe8
	static WizardGames.AssetPool.WeakHandle GibConfigHandle; // 0xf8
	static WizardGames.AssetPool.WeakHandle LadderConfigHandle; // 0x108
	static WizardGames.AssetPool.WeakHandle PlayerAutoDiveConfigHandle; // 0x118
	static WizardGames.AssetPool.WeakHandle ThrowlineMatHandle; // 0x128
	static WizardGames.AssetPool.WeakHandle SpeedWarpSerializedClipConfigHandle; // 0x138
	static System.Collections.Generic.Dictionary<System.UInt64,ViewKickCurve> ViewKickCurveCache; // 0x148
	static System.Collections.Generic.List<WizardGames.AssetPool.WeakHandle> viewKickCurveHandle; // 0x150
	static WizardGames.AssetPool.WeakHandle AimSnapConfigHandle; // 0x158
	static WizardGames.Soc.SocClient.Auxiliary.AimSnapGlobalConfig AimSnapConfig; // 0x168
	static System.Boolean get_Preloaded(); // 0x074eff88
	static System.Void FillPersistentPaths(System.Collections.Generic.List<System.String>& GoPath, System.Collections.Generic.List<System.String>& AssetPath); // 0x074f003c
	static System.Int32 HandlePersistentGoLoaded(System.Int32 index, System.Collections.Generic.List<UnityEngine.GameObject> gos); // 0x074f0954
	static System.Int32 HandlePersistentAssetLoaded(System.Int32 index, Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.AssetPool.AssetGroupData> results); // 0x074f0a60
	static System.Void FillInGamePaths(System.Collections.Generic.List<System.String>& GoPath, System.Collections.Generic.List<System.String>& AssetPath); // 0x074f0c8c
	static System.Void FillViewKickCurvePaths(System.Collections.Generic.List<System.String>& AssetPath); // 0x074f1868
	static System.Int32 HandleViewKickCurveAssetLoaded(System.Int32 index, Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.AssetPool.AssetGroupData> results); // 0x074f1a2c
	static System.Void ReleasePersistent(); // 0x074f1c70
	static System.Void ReleaseLobby(); // 0x074f2078
	static System.Void ReleaseInGame(); // 0x074f2230
	static System.Void ClientPreloadLobby(); // 0x074f29c4
	static System.Void ClientPreloadInGame(); // 0x074f2ce8
	static System.Void onLoaded(System.UInt64 task, Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.AssetPool.AssetGroupData> results); // 0x074f2fb8
	static UnityEngine.GameObject GetSkeletonWithHead(); // 0x074f3424
	static UnityEngine.GameObject GetSkeletonFp(); // 0x074f36bc
	static System.String GetCorpseBonePath(System.Boolean isDieFromCrawl); // 0x074f3788
	static System.Void .cctor(); // 0x074f38e8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.PlayerLoader.<>c : System.Object
{
	static WizardGames.Soc.Common.Unity.Character.PlayerLoader.<>c <>9; // 0x0
	static System.Action<System.Collections.Generic.List<UnityEngine.GameObject>,System.Object[]> <>9__45_0; // 0x8
	static System.Action<System.UInt64,Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.AssetPool.AssetGroupData>> <>9__45_1; // 0x10
	static System.Action<System.Collections.Generic.List<UnityEngine.GameObject>,System.Object[]> <>9__46_0; // 0x18
	static System.Void .cctor(); // 0x074f3a70
	System.Void .ctor(); // 0x074f3ad4
	System.Void <ClientPreloadLobby>b__45_0(System.Collections.Generic.List<UnityEngine.GameObject> gos, System.Object[] ps); // 0x074f3b3c
	System.Void <ClientPreloadLobby>b__45_1(System.UInt64 id, Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.AssetPool.AssetGroupData> results); // 0x074f3bf0
	System.Void <ClientPreloadInGame>b__46_0(System.Collections.Generic.List<UnityEngine.GameObject> gos, System.Object[] ps); // 0x074f3cc8
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.PlayerRayCastContext<T> : System.ValueType, System.IEquatable<WizardGames.Soc.Common.Unity.Character.PlayerRayCastContext<T>>
{
	System.Boolean IsInit; // 0x0
	System.Int64[] IgnoreEntityIds; // 0x0
	System.UInt32 OutHitDataCount; // 0x0
	System.UInt32 OutObstacleCount; // 0x0
	UnityEngine.Vector3 InTestStart; // 0x0
	UnityEngine.Vector3 InTestDir; // 0x0
	System.Single InTestDistance; // 0x0
	UnityEngine.LayerMask InAllTestLayerMask; // 0x0
	UnityEngine.LayerMask InAllTestExcludeLayerMask; // 0x0
	System.Boolean Equals(WizardGames.Soc.Common.Unity.Character.PlayerRayCastContext<T> other); // 0x052af1f0
	System.Boolean Equals(System.Object obj); // 0x054dec74
	System.Int32 GetHashCode(); // 0x0548ba98
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.HitCastData : System.ValueType, System.IEquatable<WizardGames.Soc.Common.Unity.Character.HitCastData>
{
	System.Single Distance; // 0x10
	System.Int32 ResultIndex; // 0x14
	UnityEngine.Vector3 HitPoint; // 0x18
	System.ValueTuple<System.Int32,WizardGames.Soc.Common.Entity.IEntity,UnityEngine.GameObject> ParseCache; // 0x28
	System.Boolean Equals(WizardGames.Soc.Common.Unity.Character.HitCastData other); // 0x074f3dec
	System.Boolean Equals(System.Object obj); // 0x074f3f14
	System.Int32 GetHashCode(); // 0x074f3fec
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.PlayerRefRayCastContext<T> : System.ValueType, System.IEquatable<WizardGames.Soc.Common.Unity.Character.PlayerRefRayCastContext<T>>
{
	T[] OutObstacleData; // 0x0
	T[] OutHitDataList; // 0x0
	UnityEngine.RaycastHit[] CacheRayCastHits; // 0x0
	UnityEngine.RaycastHit[] CacheReverseRayCastHits; // 0x0
	WizardGames.Soc.Common.Unity.Character.HitCastData[] CacheCastHits; // 0x0
	System.Boolean Equals(WizardGames.Soc.Common.Unity.Character.PlayerRefRayCastContext<T> other); // 0x052af1f0
	System.Boolean Equals(System.Object obj); // 0x054dec74
	System.Int32 GetHashCode(); // 0x0548ba98
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.CameraHitConfig : UnityEngine.ScriptableObject
{
	SerializableDictionary<System.Int32,UnityEngine.AnimationCurve> HitFovCurve; // 0x18
	System.Void .ctor(); // 0x074f40f8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.CharacterAnimationConfig : System.Object
{
	System.Collections.Generic.List<KAnimation.RootMotionWarping.RootMotionWarpingData> MantleOnRootMotionList; // 0x10
	System.Collections.Generic.List<KAnimation.RootMotionWarping.RootMotionWarpingData> MantleOverRootMotionList; // 0x18
	System.Collections.Generic.List<KAnimation.RootMotionWarping.RootMotionWarpingData> LadderOverRootMotionList; // 0x20
	System.Collections.Generic.List<KAnimation.RootMotionWarping.RootMotionWarpingData> LadderInRootMotionList; // 0x28
	System.Collections.Generic.List<KAnimation.RootMotionWarping.RootMotionWarpingData> LadderBottomOverRootMotionList; // 0x30
	System.Collections.Generic.List<KAnimation.RootMotionWarping.RootMotionWarpingData> LadderBottomInRootMotionList; // 0x38
	System.Void .ctor(); // 0x074f4160
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.ClientWeaponClipInfo : System.Object
{
	CommonUnity.Runtime.Animation.AnimStrKey newClipName; // 0x10
	System.Int32 clipHash; // 0x20
	System.Void .ctor(); // 0x074f42d4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.SerializeListNestList<T> : System.Object
{
	System.String DisplayName; // 0x0
	System.Collections.Generic.List<T> list; // 0x0
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.ClientClipValue : System.Object
{
	SerializableDictionary<System.Int32,SerializableDictionary<System.Int32,WizardGames.Soc.Common.Unity.Character.ClientWeaponClipTRSValue>> ClipValues; // 0x10
	System.Void .ctor(); // 0x074f433c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.ClientWeaponClipTRSValue : System.Object
{
	UnityEngine.Vector3 pos; // 0x10
	UnityEngine.Quaternion rot; // 0x1c
	UnityEngine.Vector3 scale; // 0x2c
	System.Void .ctor(); // 0x074f43f0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.ClientWeaponBindingData : System.Object
{
	CommonUnity.Runtime.Animation.AnimKeyDict<WizardGames.Soc.Common.Unity.Character.ClientWeaponClipInfo> newBasicWeaponInfos; // 0x10
	System.Void .ctor(); // 0x074f4458
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.CharacterConfig : UnityEngine.ScriptableObject, UnityEngine.ISerializationCallbackReceiver
{
	UnityEngine.AnimationCurve FpJumpProj2ForwardInteriaCurve; // 0x18
	UnityEngine.AnimationCurve FpJumpProj2RightInteriaCurve; // 0x20
	CommonUnity.Runtime.Character.Resource.AnimCurveGroup AnimCurves; // 0x28
	CommonUnity.Runtime.Character.Resource.AnimStrGroup AnimStrGroup; // 0x30
	System.Single FpJumpStartInertialTime; // 0x38
	System.Single FpJumpKeepInertialTime; // 0x3c
	System.Single FpJumpClearInertialTime; // 0x40
	System.Single AnimEventAudioInterval; // 0x44
	UnityEngine.AnimationCurve TpJumpProj2ForwardInteriaCurve; // 0x48
	UnityEngine.AnimationCurve TpJumpProj2RightInteriaCurve; // 0x50
	System.Single TpJumpStartInertialTime; // 0x58
	System.Single TpJumpKeepInertialTime; // 0x5c
	System.Single TpJumpClearInertialTime; // 0x60
	System.Collections.Generic.List<SharedUnity.GameLocalBounds> EntityBounds; // 0x68
	System.Single PickUpLeftTimeThreshold; // 0x70
	System.Single PickUpRightTimeThreshold; // 0x74
	System.Single DoorLeftTimeThreshold; // 0x78
	System.Single DoorRightTimeThreshold; // 0x7c
	WizardGames.Editor.FpClipSettingCollections FpAniCollections; // 0x80
	WizardGames.Editor.TpClipSettingCollections TpAniCollections; // 0x88
	SerializableDictionary<CommonUnity.Runtime.Animation.AnimMoveEnum,CommonUnity.Runtime.Animation.AnimMoveSpeedConf> DefaultFpMoveSpeedConfs; // 0x90
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Character.SerializeListNestList<WizardGames.Soc.Common.Unity.ProcedureControlConf>> FpMoveSpeedMatchRules; // 0x98
	SerializableDictionary<System.String,System.String> AudioDict; // 0xa0
	UnityEngine.AnimationCurve Stand2CourchCurve; // 0xa8
	UnityEngine.AnimationCurve Stand2CourchSwapCurve; // 0xb0
	UnityEngine.AnimationCurve Crouch2StandCurve; // 0xb8
	UnityEngine.AnimationCurve Crouch2StandSwapCurve; // 0xc0
	UnityEngine.AnimationCurve TP2FPADSCurve; // 0xc8
	System.Single TP2FPADSFadeTime; // 0xd0
	UnityEngine.AnimationCurve RadiationCurve; // 0xd8
	UnityEngine.Vector2 RadiationCurveRegion; // 0xe0
	System.Single RadiationSaturation; // 0xe8
	System.Single RadiationIntensity; // 0xec
	System.Single RadiationAudioFade; // 0xf0
	System.Int32 WakeUpDuration; // 0xf4
	UnityEngine.Vector3 TpSleepCameraEuler; // 0xf8
	System.Single DyingCameraPitch; // 0x104
	UnityEngine.Vector3 HitPlayerObbPos; // 0x108
	UnityEngine.Vector3 HitPlayerObbSize; // 0x114
	WizardGames.Soc.Common.Unity.Vehicle.Horse.HorseMeta HorseMeta; // 0x120
	WizardGames.Soc.Common.Unity.Vehicle.Parachute.ParachuteMeta ParachuteMeta; // 0x128
	UnityEngine.AnimationCurve fov2CameraHitShakeRatio; // 0x130
	System.Single AdsFov; // 0x138
	System.Boolean OpenAdsFovCurve; // 0x13c
	System.Int32 TpCameraToDyingTime; // 0x140
	System.Int32 OpenDoorTime; // 0x144
	System.Int32 PickUpTime; // 0x148
	System.Int32 PickUpCold; // 0x14c
	UnityEngine.AnimationCurve WaterBottleScaleCurve; // 0x150
	System.Void OnBeforeSerialize(); // 0x074f450c
	System.Void OnAfterDeserialize(); // 0x074f456c
	System.Void .ctor(); // 0x074f45cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.CharacterFovConfig : UnityEngine.ScriptableObject
{
	UnityEngine.AnimationCurve AdsOnFov; // 0x18
	UnityEngine.AnimationCurve AdsOffFov; // 0x20
	System.Void .ctor(); // 0x074f497c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.CorrectEffectConfig : UnityEngine.ScriptableObject
{
	UnityEngine.AnimationCurve scaleCurve; // 0x18
	UnityEngine.AnimationCurve BulletFlyingEffectScaleCurve; // 0x20
	System.Void .ctor(); // 0x074f49e4
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Character.AutoDiveDetectionType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Character.AutoDiveDetectionType None = 0;
	static WizardGames.Soc.Common.Unity.Character.AutoDiveDetectionType RayCast = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Character.AutoDiveDetectionDir : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Character.AutoDiveDetectionDir Forward = 0;
	static WizardGames.Soc.Common.Unity.Character.AutoDiveDetectionDir Up = 1;
	static WizardGames.Soc.Common.Unity.Character.AutoDiveDetectionDir Down = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Character.AutoDivePreferDir : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Character.AutoDivePreferDir Up = 0;
	static WizardGames.Soc.Common.Unity.Character.AutoDivePreferDir Down = 1;
	static WizardGames.Soc.Common.Unity.Character.AutoDivePreferDir Auto = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.PlayerAutoDiveConfigStep : System.Object
{
	System.Single diveDirDist; // 0x10
	System.Boolean ShouldStep; // 0x14
	UnityEngine.LayerMask detectionLayer; // 0x18
	WizardGames.Soc.Common.Unity.Character.AutoDiveDetectionDir detectionDir; // 0x1c
	System.Void .ctor(); // 0x074f4a4c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.PlayerAutoDiveConfigStepGroup : System.Object
{
	System.Int32 stepCount; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Character.PlayerAutoDiveConfigStep> steps; // 0x18
	System.Void .ctor(); // 0x074f4ad8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.PlayerAutoDiveConfig : UnityEngine.ScriptableObject
{
	WizardGames.Soc.Common.Unity.Character.AutoDiveDetectionType detectionType; // 0x18
	WizardGames.Soc.Common.Unity.Character.AutoDivePreferDir equalChooseDir; // 0x1c
	System.Int32 detectionInterval; // 0x20
	UnityEngine.Vector3 PosOffset; // 0x24
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Character.PlayerAutoDiveConfigStepGroup> steps; // 0x30
	System.Void .ctor(); // 0x074f4b94
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Character.PlayerRayCastType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Character.PlayerRayCastType None = 0;
	static WizardGames.Soc.Common.Unity.Character.PlayerRayCastType RayCastAll = 1;
	static WizardGames.Soc.Common.Unity.Character.PlayerRayCastType SphereCast = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Character.PlayerRayCastDirectionType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Character.PlayerRayCastDirectionType None = 0;
	static WizardGames.Soc.Common.Unity.Character.PlayerRayCastDirectionType CameraForward = 1;
	static WizardGames.Soc.Common.Unity.Character.PlayerRayCastDirectionType BoneForward = 2;
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.PlayRayCastRule : System.ValueType, System.IEquatable<WizardGames.Soc.Common.Unity.Character.PlayRayCastRule>
{
	System.Int32 RayCastRuleId; // 0x10
	WizardGames.Soc.Common.Unity.Character.PlayerRayCastType RayCastType; // 0x14
	System.Boolean DrawRay; // 0x18
	System.Single DrawSize; // 0x1c
	System.Boolean RayInsideCheck; // 0x20
	UnityEngine.QueryTriggerInteraction QueryType; // 0x24
	UnityEngine.LayerMask LayerMask; // 0x28
	UnityEngine.Vector3 CustomAddtiveOffset; // 0x2c
	System.Single CustomAddtiveForwardOffset; // 0x38
	UnityEngine.LayerMask ExcludeLayerMask; // 0x3c
	System.String[] ExcludeTags; // 0x40
	System.Single ExcludeDistance; // 0x48
	System.Single RayCastDistance; // 0x4c
	WizardGames.Soc.Common.Unity.Character.PlayerRayCastDirectionType RayCastDirType; // 0x50
	System.String RayCastObjectName; // 0x58
	System.Single SphereCastRadius; // 0x60
	WizardGames.Soc.Common.Unity.Character.PlayerRayCastDirectionType SphereCastTestDirType; // 0x64
	System.String SphereCastObjectName; // 0x68
	System.Single SphereCastAngle; // 0x70
	System.Boolean Equals(WizardGames.Soc.Common.Unity.Character.PlayRayCastRule other); // 0x074f4ca8
	System.Int32 GetHashCode(); // 0x074f4d44
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.PlayerRayCastConfig : UnityEngine.ScriptableObject
{
	WizardGames.Soc.Common.Unity.Character.PlayRayCastRule[] TpRayCastRules; // 0x18
	WizardGames.Soc.Common.Unity.Character.PlayRayCastRule[] DefaultFPRule; // 0x20
	System.Int32 HitBufferCount; // 0x28
	System.Void .ctor(); // 0x074f4da8
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AimBoneProxy : System.ValueType
{
	CommonUnity.Runtime.Character.Bone _data; // 0x10
	MMapIntegration.MmapPtr<MMapIntegration.BoneMMap> _mmp; // 0x20
	System.Void Build(CommonUnity.Runtime.Character.Bone data); // 0x074f4e18
	System.Void Build(MMapIntegration.MmapPtr<MMapIntegration.BoneMMap> inMap); // 0x074f4ea0
	System.String BoneName_Get(); // 0x074f4f20
	System.Single Weight_Get(); // 0x074f502c
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AimIKDataContainerProxy : System.ValueType
{
	CommonUnity.Runtime.Character.AimIKDataContainer _data; // 0x10
	MMapIntegration.MmapPtr<MMapIntegration.AimIKDataContainerMMap> _header; // 0x18
	System.Void Build(CommonUnity.Runtime.Character.AimIKDataContainer container); // 0x074f50e4
	System.Void Build(MMapIntegration.MmapPtr<MMapIntegration.AimIKDataContainerMMap> inheader); // 0x074f5164
	System.Boolean TryGetData(CommonUnity.Runtime.Character.PhaseKey& phaseKey, WizardGames.Soc.Common.Unity.Character.AimIKDataProxy& outdata); // 0x074f51e4
	System.Boolean TryGetToggle(CommonUnity.Runtime.Character.PhaseKey& phaseKey, System.Boolean& toggle); // 0x074f5650
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AimIKDataProxy : System.ValueType
{
	CommonUnity.Runtime.Character.AimIKData _data; // 0x10
	MMapIntegration.MmapPtr<MMapIntegration.AimIKDataMMap> _mmp; // 0x30
	System.Void Build(CommonUnity.Runtime.Character.AimIKData indata); // 0x074f5a08
	System.Void Build(MMapIntegration.MmapPtr<MMapIntegration.AimIKDataMMap> indata); // 0x074f5aa4
	System.Single Weight(); // 0x074f5b24
	WizardGames.Soc.Common.Unity.Character.AimBoneProxy AimBone(); // 0x074f5bdc
	System.Int32 SpineBones_Count(); // 0x074f5d94
	WizardGames.Soc.Common.Unity.Character.AimBoneProxy SpineBones_Get(System.Int32 index); // 0x074f5e60
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy : System.ValueType, System.IDisposable
{
	System.IntPtr _curvePtr; // 0x10
	MMapIntegration.MmapPtr<MMapIntegration.AnimationCurveMMap> _mmp; // 0x18
	System.Void Build(UnityEngine.AnimationCurve curve, System.String _); // 0x074f60ac
	System.Void Build(WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy curve); // 0x074f617c
	System.Void Build(MMapIntegration.MmapPtr<MMapIntegration.AnimationCurveMMap> curveMMap); // 0x074f6220
	System.Single Evaluate(System.Single time); // 0x074f62a0
	System.Single _Evaluate(System.Single time); // 0x074f6320
	System.Void Dispose(); // 0x074f6440
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimPhaseDataProxy : System.ValueType
{
	CommonUnity.Runtime.Character.AnimPhaseData _phase; // 0x10
	MMapIntegration.MmapPtr<MMapIntegration.AnimPhaseDataMMap> _mmap; // 0x18
	System.Void Build(CommonUnity.Runtime.Character.AnimPhaseData phase); // 0x074f64f0
	System.Void Build(MMapIntegration.MmapPtr<MMapIntegration.AnimPhaseDataMMap> mmap); // 0x074f6568
	CommonUnity.Runtime.Character.AnimPhaseType GetPhaseType(); // 0x074f65e8
	System.Single GetNormalizedTime(); // 0x074f66a0
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.ClientClipValueDictProxy : System.ValueType
{
	SerializableDictionary<System.Int32,WizardGames.Soc.Common.Unity.Character.ClientWeaponClipTRSValue> _dictionary; // 0x10
	MMapIntegration.MmapPtr<MMapIntegration.MmapHashMap<MMapIntegration.ClientWeaponClipTRSValueMMap>> _mmap; // 0x18
	System.Void Build(SerializableDictionary<System.Int32,WizardGames.Soc.Common.Unity.Character.ClientWeaponClipTRSValue> dict); // 0x074f6758
	System.Void Build(MMapIntegration.MmapPtr<MMapIntegration.MmapHashMap<MMapIntegration.ClientWeaponClipTRSValueMMap>> dict); // 0x074f67d8
	System.Boolean TryGet(System.Int32 weaponHash, WizardGames.Soc.Common.Unity.Character.ClientWeaponClipTRSValueProxy& proxy); // 0x074f6858
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.ClientClipValueProxy : System.ValueType
{
	WizardGames.Soc.Common.Unity.Character.ClientClipValue _clipValue; // 0x10
	MMapIntegration.MmapPtr<MMapIntegration.ClientClipValueMMap> _mmap; // 0x18
	System.Void Build(WizardGames.Soc.Common.Unity.Character.ClientClipValue clipValue); // 0x074f6a88
	System.Void Build(MMapIntegration.MmapPtr<MMapIntegration.ClientClipValueMMap> metaData); // 0x074f6b08
	System.Boolean TryGet(System.Int32 poseHash, WizardGames.Soc.Common.Unity.Character.ClientClipValueDictProxy& proxy); // 0x074f6b88
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.ClientWeaponBindingDataProxy : System.ValueType
{
	WizardGames.Soc.Common.Unity.Character.ClientWeaponBindingData _data; // 0x10
	MMapIntegration.MmapPtr<MMapIntegration.ClientWeaponBindingDataMMap> _mmp; // 0x18
	System.Void Build(WizardGames.Soc.Common.Unity.Character.ClientWeaponBindingData data); // 0x074f6dc4
	System.Void Build(MMapIntegration.MmapPtr<MMapIntegration.ClientWeaponBindingDataMMap> metaDataProxy); // 0x074f6e44
	System.Int32 newBasicWeaponInfos_Count(); // 0x074f6ec4
	System.Boolean newBasicWeaponInfos_TryGetValue(System.String key, WizardGames.Soc.Common.Unity.Character.ClientWeaponClipInfoProxy& proxy); // 0x074f6fcc
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.ClientWeaponClipInfoProxy : System.ValueType
{
	WizardGames.Soc.Common.Unity.Character.ClientWeaponClipInfo _clip; // 0x10
	MMapIntegration.MmapPtr<MMapIntegration.ClientWeaponClipInfoMMap> _mmp; // 0x18
	System.Void Build(WizardGames.Soc.Common.Unity.Character.ClientWeaponClipInfo clipInfo); // 0x074f7224
	System.Void Build(MMapIntegration.MmapPtr<MMapIntegration.ClientWeaponClipInfoMMap> clipInfoMmap); // 0x074f72a4
	System.String newClipName_Get(); // 0x074f7324
	System.Int32 clipHash_Get(); // 0x074f7454
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.ClientWeaponClipTRSValueProxy : System.ValueType
{
	WizardGames.Soc.Common.Unity.Character.ClientWeaponClipTRSValue _clipTRSValue; // 0x10
	MMapIntegration.MmapPtr<MMapIntegration.ClientWeaponClipTRSValueMMap> _mmp; // 0x18
	System.Void Build(WizardGames.Soc.Common.Unity.Character.ClientWeaponClipTRSValue clipTRSValue); // 0x074f751c
	System.Void Build(MMapIntegration.MmapPtr<MMapIntegration.ClientWeaponClipTRSValueMMap> metaData); // 0x074f759c
	UnityEngine.Vector3 pos_Get(); // 0x074f761c
	UnityEngine.Quaternion rot_Get(); // 0x074f76ec
	UnityEngine.Vector3 scale_Get(); // 0x074f7878
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.MmpGlobal : System.Object
{
	static SocLogger logger; // 0x0
	static System.Boolean MmpGlobalTryGetValue<T>(MMapIntegration.MmapArray<T>& map, System.IntPtr filePtr, System.Int32 key, MMapIntegration.MmapPtr<T>& value); // 0x052af1f0
	static System.Boolean MmpGlobalTryGetValue_bystrKey<T>(MMapIntegration.MmapHashMap<T>& map, System.IntPtr baseptr, System.String key, T& value); // 0x052af1f0
	static System.Boolean MmpGlobalTryGetValue_byenumKey<T>(MMapIntegration.MmapHashMap<T>& map, System.IntPtr baseptr, CommonUnity.Runtime.Character.PhaseKey key, T& value); // 0x052af1f0
	static System.Boolean MmpGlobalTryGetValue<T>(MMapIntegration.MmapHashMap<T>& map, System.IntPtr filePtr, System.UInt64 key, MMapIntegration.MmapPtr<T>& value); // 0x052af1f0
	static System.Boolean MmpGlobalTryGetValue<T>(MMapIntegration.MmapHashMap<T>& map, System.IntPtr filePtr, System.String key, MMapIntegration.MmapPtr<T>& value); // 0x052af1f0
	static System.Boolean MmpGlobalTryGetValue<T>(MMapIntegration.MmapHashMap<T>& map, System.IntPtr filePtr, CommonUnity.Runtime.Character.PhaseKey key, MMapIntegration.MmapPtr<T>& value); // 0x052af1f0
	static System.Void .cctor(); // 0x074f7948
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.PhaseGroupScriptObjProxy : System.ValueType
{
	CommonUnity.Runtime.Character.PhaseGroupScriptObj _phaseSobj; // 0x10
	MMapIntegration.MmapPtr<MMapIntegration.PhaseGroupScriptObjMMap> _mmp; // 0x18
	System.Boolean isValid(); // 0x074f79e0
	System.Void Build(CommonUnity.Runtime.Character.PhaseGroupScriptObj scriptObj); // 0x074f7aa8
	System.Void Build(MMapIntegration.MmapPtr<MMapIntegration.PhaseGroupScriptObjMMap> mmapContainer); // 0x074f7b28
	System.Int32 GetPhaseCount(); // 0x074f7ba8
	WizardGames.Soc.Common.Unity.Character.AnimPhaseDataProxy GetPhase(System.Int32 index); // 0x074f7cc4
	System.Boolean FoundPhaseOffset(CommonUnity.Runtime.Character.AnimPhaseMatchKey key, System.Single& normalizedTime); // 0x074f806c
	System.Int32 GetPrePlayAudioTimeIndex(System.Single normalizedTime); // 0x074f84f8
	System.Single GetPrePlayAudioTime(System.Single normalizedTime); // 0x074f8658
	System.Void GetPlayAudioTimes(System.Single[]& audioLoopTimes, System.Single& firstTimestamp); // 0x074f87f0
	CommonUnity.Runtime.Character.AnimPhaseMatchKey GenerateMatchKey(System.Single normalizedTime); // 0x074f8a78
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.TpMetaAdditiveWeightProxy : System.ValueType
{
	WizardGames.Soc.Common.Unity.Character.TpMetaAdditiveWeight _weight; // 0x10
	MMapIntegration.MmapPtr<MMapIntegration.TpMetaAdditiveWeightMMap> _mmp; // 0x18
	System.Boolean isValid(); // 0x074f8fb4
	System.Void Build(WizardGames.Soc.Common.Unity.Character.TpMetaAdditiveWeight weight); // 0x074f907c
	System.Void Build(MMapIntegration.MmapPtr<MMapIntegration.TpMetaAdditiveWeightMMap> weight); // 0x074f90fc
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy AoWeightCurve_TryGet(System.Int32 index); // 0x074f917c
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy AoHorseWeightCurve_TryGet(System.Int32 index); // 0x074f94b4
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy IdleCrouchWeightCurve_TryGet(System.Int32 index); // 0x074f97ec
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy JogWeightCurve_TryGet(System.Int32 index); // 0x074f9b24
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy SprintWeightCurve_TryGet(System.Int32 index); // 0x074f9e5c
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy JumpWeightCurve_TryGet(System.Int32 index); // 0x074fa194
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy SwimIdleWeightCurve_TryGet(System.Int32 index); // 0x074fa4cc
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy SwimMoveWeightCurve_TryGet(System.Int32 index); // 0x074fa804
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy LLadderWeightCurve_TryGet(System.Int32 index); // 0x074fab3c
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.TpMetaDataProxy : System.ValueType
{
	MMapIntegration.MmapPtr<MMapIntegration.TpClipSettingMetaMMap> Header; // 0x10
	WizardGames.Editor.TpClipSettingMeta meta; // 0x20
	System.Boolean isValid(); // 0x074fae74
	System.String ToString(); // 0x074faf3c
	System.Void Build(System.String loadPath); // 0x074fafe0
	System.Void _Build(System.String loadPath); // 0x074fb0a8
	System.Void UnLoad(); // 0x074fb4c4
	WizardGames.Soc.Common.Unity.Character.ClientWeaponBindingDataProxy WeaponBindings_Get(); // 0x074fb534
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Stand2CrouchCurve_Get(); // 0x074fb734
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Stand2CrouchSwapCurve_Get(); // 0x074fb948
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Crouch2StandCurve_Get(); // 0x074fbb5c
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy Crouch2StandSwapCurve_Get(); // 0x074fbd70
	WizardGames.Soc.Common.Unity.Character.ClientClipValueProxy WeaponClipValue_Get(); // 0x074fbf84
	WizardGames.Soc.Common.Unity.Character.AimIKDataContainerProxy AimIKDataContainer_Get(); // 0x074fc184
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy JumpProj2RightInteriaCurve_Get(); // 0x074fc384
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy JumpProj2ForwardInteriaCurve_Get(); // 0x074fc598
	System.Boolean JumpInteriaOverride_Get(); // 0x074fc7ac
	System.Single JumpStartInertialTime_Get(); // 0x074fc8b8
	System.Single JumpKeepInertialTime_Get(); // 0x074fc9b8
	System.Single JumpClearInertialTime_Get(); // 0x074fcab8
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy TurnInPlaceLeftCurve_TryGet(); // 0x074fcbb8
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy TurnInPlaceRightCurve_TryGet(); // 0x074fcdcc
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy TurnInPlaceCrouchLeftCurve_TryGet(); // 0x074fcfe0
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy TurnInPlaceCrouchRightCurve_TryGet(); // 0x074fd1f4
	System.Boolean OcLayerWeightCollection_TryGet(WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EOverrideLayer key, WizardGames.Soc.Common.Unity.Character.TpMetaOverrideWeightProxy& weightproxy); // 0x074fd408
	System.Boolean LocomotionLayerWeightCollection_TryGet(WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer key, WizardGames.Soc.Common.Unity.Character.TpMetaLocomotionWeightProxy& weightProxy); // 0x074fd680
	System.Single OverrideLayerStateTime_TryGet(System.Int32 index); // 0x074fd8f8
	System.Boolean OverrideLayerStateLoop_TryGet(System.Int32 index); // 0x074fda98
	System.Single LocomotionLayerStateTime_TryGet(System.Int32 index); // 0x074fdc2c
	System.Boolean newTpWpnStringToHash_TryGet(System.String key, System.Int32& stateHash); // 0x074fddcc
	System.Int32 LocomotionSpecial_FindIndex(WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer layer); // 0x074fdf98
	System.Boolean AddLayerWeightCollection_TryGet(WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EAdditiveLayer key, WizardGames.Soc.Common.Unity.Character.TpMetaAdditiveWeightProxy& weightProxy); // 0x074fe148
	System.Boolean AudioDict_TryGet(System.String key, System.String& audioVal); // 0x074fe3c0
	System.Boolean NewPhaseKeyContainer_TryGet(CommonUnity.Runtime.Character.PhaseKey& key, WizardGames.Soc.Common.Unity.Character.PhaseGroupScriptObjProxy& mmpContainer); // 0x074fe5f0
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.TpMetaLocomotionWeightProxy : System.ValueType
{
	WizardGames.Soc.Common.Unity.Character.TpMetaLocomotionWeight _weight; // 0x10
	MMapIntegration.MmapPtr<MMapIntegration.TpMetaLocomotionWeightMMap> _mmp; // 0x18
	System.Void Build(WizardGames.Soc.Common.Unity.Character.TpMetaLocomotionWeight weight); // 0x074feac0
	System.Void Build(MMapIntegration.MmapPtr<MMapIntegration.TpMetaLocomotionWeightMMap> weight); // 0x074feb40
	System.Single TryGetWeight(System.Int32 index); // 0x074febc0
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.TpMetaOverrideWeightProxy : System.ValueType
{
	WizardGames.Soc.Common.Unity.Character.TpMetaOverrideWeight _weight; // 0x10
	MMapIntegration.MmapPtr<MMapIntegration.TpMetaOverrideWeightMMap> _mmp; // 0x18
	System.Boolean isValid(); // 0x074fedb0
	System.Void Build(WizardGames.Soc.Common.Unity.Character.TpMetaOverrideWeight weight); // 0x074fee78
	System.Void Build(MMapIntegration.MmapPtr<MMapIntegration.TpMetaOverrideWeightMMap> data); // 0x074feef8
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy AoWeightCurve_TryGet(System.Int32 index); // 0x074fef78
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy AoHorseWeightCurve_TryGet(System.Int32 index); // 0x074ff2b4
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy LIdleCrouchWeightCurve_TryGet(System.Int32 index); // 0x074ff5f0
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy LJogWeightCurve_TryGet(System.Int32 index); // 0x074ff92c
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy LSprintWeightCurve_TryGet(System.Int32 index); // 0x074ffc68
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy LJumpWeightCurve_TryGet(System.Int32 index); // 0x074fffa4
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy LSwimIdleWeightCurve_TryGet(System.Int32 index); // 0x075002e0
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy LSwimMoveWeightCurve_TryGet(System.Int32 index); // 0x0750061c
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy LLadderWeightCurve_TryGet(System.Int32 index); // 0x07500958
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy fastIdleStandWeightCurve_TryGet(System.Int32 index); // 0x07500c94
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy fastJogStandWeightCurve_TryGet(System.Int32 index); // 0x07500fd0
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy fastSprintWeightCurve_TryGet(System.Int32 index); // 0x0750130c
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy fastIdleCrouchWeightCurve_TryGet(System.Int32 index); // 0x07501648
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy fastJogCrouchWeightCurve_TryGet(System.Int32 index); // 0x07501984
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy fastJumpWeightCurve_TryGet(System.Int32 index); // 0x07501cc0
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy fastSwimIdleWeightCurve_TryGet(System.Int32 index); // 0x07501ffc
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy fastSwimJogWeightCurve_TryGet(System.Int32 index); // 0x07502338
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy fastSwimSprintWeightCurve_TryGet(System.Int32 index); // 0x07502674
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy fastLadderWeightCurve_TryGet(System.Int32 index); // 0x075029b0
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy fastHorseWeightCurve_TryGet(System.Int32 index); // 0x07502cec
	WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy fastVehicleWeightCurve_TryGet(System.Int32 index); // 0x07503028
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.TpMetaAdditiveWeight : UnityEngine.ScriptableObject
{
	CommonUnity.Runtime.Animation.AnimCurveKey[] LJogWeightCurve; // 0x18
	CommonUnity.Runtime.Animation.AnimCurveKey[] LSprintWeightCurve; // 0x20
	CommonUnity.Runtime.Animation.AnimCurveKey[] LJumpWeightCurve; // 0x28
	CommonUnity.Runtime.Animation.AnimCurveKey[] LSwimMoveWeightCurve; // 0x30
	CommonUnity.Runtime.Animation.AnimCurveKey[] LSwimIdleWeightCurve; // 0x38
	CommonUnity.Runtime.Animation.AnimCurveKey[] LIdleCrouchWeightCurve; // 0x40
	CommonUnity.Runtime.Animation.AnimCurveKey[] LLadderWeightCurve; // 0x48
	CommonUnity.Runtime.Animation.AnimCurveKey[] AoWeightCurve; // 0x50
	CommonUnity.Runtime.Animation.AnimCurveKey[] AoHorseWeightCurve; // 0x58
	System.Void .ctor(); // 0x07503364
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.TpMetaLocomotionWeight : UnityEngine.ScriptableObject
{
	WizardGames.Editor.SkeletonMaskWeightValue[] WeightList; // 0x18
	System.Void .ctor(); // 0x075034dc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.TpMetaOverrideWeight : UnityEngine.ScriptableObject
{
	CommonUnity.Runtime.Animation.AnimCurveKey[] fastIdleStandWeightCurve; // 0x18
	CommonUnity.Runtime.Animation.AnimCurveKey[] fastIdleCrouchWeightCurve; // 0x20
	CommonUnity.Runtime.Animation.AnimCurveKey[] fastJogStandWeightCurve; // 0x28
	CommonUnity.Runtime.Animation.AnimCurveKey[] fastJogCrouchWeightCurve; // 0x30
	CommonUnity.Runtime.Animation.AnimCurveKey[] fastSprintWeightCurve; // 0x38
	CommonUnity.Runtime.Animation.AnimCurveKey[] fastJumpWeightCurve; // 0x40
	CommonUnity.Runtime.Animation.AnimCurveKey[] fastSwimIdleWeightCurve; // 0x48
	CommonUnity.Runtime.Animation.AnimCurveKey[] fastSwimJogWeightCurve; // 0x50
	CommonUnity.Runtime.Animation.AnimCurveKey[] fastSwimSprintWeightCurve; // 0x58
	CommonUnity.Runtime.Animation.AnimCurveKey[] fastLadderWeightCurve; // 0x60
	CommonUnity.Runtime.Animation.AnimCurveKey[] fastHorseWeightCurve; // 0x68
	CommonUnity.Runtime.Animation.AnimCurveKey[] fastVehicleWeightCurve; // 0x70
	CommonUnity.Runtime.Animation.AnimCurveKey[] LJogWeightCurve; // 0x78
	CommonUnity.Runtime.Animation.AnimCurveKey[] LSprintWeightCurve; // 0x80
	CommonUnity.Runtime.Animation.AnimCurveKey[] LJumpWeightCurve; // 0x88
	CommonUnity.Runtime.Animation.AnimCurveKey[] LSwimMoveWeightCurve; // 0x90
	CommonUnity.Runtime.Animation.AnimCurveKey[] LSwimIdleWeightCurve; // 0x98
	CommonUnity.Runtime.Animation.AnimCurveKey[] LIdleCrouchWeightCurve; // 0xa0
	CommonUnity.Runtime.Animation.AnimCurveKey[] LLadderWeightCurve; // 0xa8
	CommonUnity.Runtime.Animation.AnimCurveKey[] AoWeightCurve; // 0xb0
	CommonUnity.Runtime.Animation.AnimCurveKey[] AoHorseWeightCurve; // 0xb8
	System.Void .ctor(); // 0x07503574
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.TpStand2CrouchConfig : UnityEngine.ScriptableObject
{
	UnityEngine.AnimationCurve Stand2CrouchDefaultCurve; // 0x18
	UnityEngine.AnimationCurve Stand2CrouchCurve; // 0x20
	UnityEngine.AnimationCurve Stand2CrouchSwapCurve; // 0x28
	UnityEngine.AnimationCurve Crouch2StandDefaultCurve; // 0x30
	UnityEngine.AnimationCurve Crouch2StandCurve; // 0x38
	UnityEngine.AnimationCurve Crouch2StandSwapCurve; // 0x40
	System.Void .ctor(); // 0x0750383c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.TpTipRotateConfig : UnityEngine.ScriptableObject
{
	UnityEngine.AnimationCurve TurnInPlaceLeftCurve; // 0x18
	UnityEngine.AnimationCurve TurnInPlaceRightCurve; // 0x20
	UnityEngine.AnimationCurve TurnInPlaceLeftCrouchCurve; // 0x28
	UnityEngine.AnimationCurve TurnInPlaceRightCrouchCurve; // 0x30
	System.Void .ctor(); // 0x07503994
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Character.IMantleDebug : 
{
	
	System.Boolean get_Init(); // 0x054c4760
	System.Void Draw(); // 0x055049cc
	System.Void Clear(); // 0x055049cc
	System.Void RefreshStepDebugData(WizardGames.Soc.Common.Unity.Character.EMantleStep step, System.Boolean isSuccess); // 0x0550f700
	System.Void ResetStepDebugData(WizardGames.Soc.Common.Unity.Character.EMantleStep step); // 0x055056e8
	System.Void RefreshStepDebugData(WizardGames.Soc.Common.Unity.Character.EMantleStep step, System.Int32 stepIndex, System.Boolean isSuccess, UnityEngine.Vector3 pointDown, UnityEngine.Vector3 pointUp, System.Single radius, UnityEngine.Vector3 forward, System.Single distance, UnityEngine.Vector3 hitPoint, UnityEngine.GameObject hitGameObject, System.Int32 extra); // 0x05506a98
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.MantleEmptyDebug : System.Object, WizardGames.Soc.Common.Unity.Character.IMantleDebug
{
	System.Boolean <Init>k__BackingField; // 0x10
	System.Boolean get_Init(); // 0x07503a9c
	System.Void Draw(); // 0x07503b00
	System.Void Clear(); // 0x07503b60
	System.Void RefreshStepDebugData(WizardGames.Soc.Common.Unity.Character.EMantleStep step, System.Boolean isSuccess); // 0x07503bc0
	System.Void ResetStepDebugData(WizardGames.Soc.Common.Unity.Character.EMantleStep step); // 0x07503c3c
	System.Void RefreshStepDebugData(WizardGames.Soc.Common.Unity.Character.EMantleStep step, System.Int32 stepIndex, System.Boolean isSuccess, UnityEngine.Vector3 pointDown, UnityEngine.Vector3 pointUp, System.Single radius, UnityEngine.Vector3 forward, System.Single distance, UnityEngine.Vector3 hitPoint, UnityEngine.GameObject hitGameObject, System.Int32 extra); // 0x07503cb0
	System.Void .ctor(); // 0x07503e00
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Character.EMantleStep : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Character.EMantleStep FirstBaseStep = 0;
	static WizardGames.Soc.Common.Unity.Character.EMantleStep BackwardBaseStep = 1;
	static WizardGames.Soc.Common.Unity.Character.EMantleStep SecondBaseStep = 2;
	static WizardGames.Soc.Common.Unity.Character.EMantleStep StartPoint = 3;
	static WizardGames.Soc.Common.Unity.Character.EMantleStep StandOnPoint = 4;
	static WizardGames.Soc.Common.Unity.Character.EMantleStep TraceTest = 5;
	static WizardGames.Soc.Common.Unity.Character.EMantleStep Sum = 6;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.MantleRaycast : System.Object
{
	static SocLogger logger; // 0x0
	static System.Int32 CapsuleCast(System.Int64 entityId, UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, System.Single radius, UnityEngine.Vector3 direction, UnityEngine.RaycastHit[] results, System.Single maxDistance, System.Int32 layerMask, UnityEngine.QueryTriggerInteraction queryTriggerInteraction, System.Boolean needIgnoreOverlap); // 0x07503e68
	static System.Void .cctor(); // 0x075041b0
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.MantleTestParams : System.ValueType
{
	System.Boolean bValid; // 0x10
	System.Boolean bOnGround; // 0x11
	System.Single CCSlopeLimit; // 0x14
	System.Single CCStepOffset; // 0x18
	System.Single CCSkinWidth; // 0x1c
	System.Single CCMinMoveDistance; // 0x20
	UnityEngine.Vector3 CCCenter; // 0x24
	System.Single CCRadius; // 0x30
	System.Single CCTestRadius; // 0x34
	System.Single CCHeight; // 0x38
	System.Single FallingTestDist; // 0x3c
	System.Single CfgBasicTestDist; // 0x40
	System.Single CfgBasicTestAngle; // 0x44
	System.Int32 CfgBasicTestAngleAccuracy; // 0x48
	System.Single CfgUpSweepTestDist; // 0x4c
	System.Single CfgThickNessDist; // 0x50
	System.Single CfgMantleOverFallingTestDist; // 0x54
	System.Single CfgMantleOverFallFloorTestDist; // 0x58
	System.Single CfgWidthTest; // 0x5c
	System.Single CfgCCTestRadius; // 0x60
	System.Single TestErrorThreshold; // 0x64
	System.Single DrawDebugTime; // 0x68
	System.Int32 TestLayer; // 0x6c
	System.Single[] CfgAdvanceTestHeights; // 0x70
	System.Single[] CfgAdvanceWorldTestHeights; // 0x78
	System.Single[] CfgAdvanceSwimTestHeights; // 0x80
	WizardGames.Soc.Common.Unity.Character.SocCharacterController CCOwner; // 0x88
	System.Single CCMantleOverHeight; // 0x90
	UnityEngine.Vector3 CCMantleOverCenter; // 0x94
	System.Single CCStandHeight; // 0xa0
	UnityEngine.Vector3 CCStandCenter; // 0xa4
	UnityEngine.Vector3 ColliderNormal; // 0xb0
	System.Single CfgMinMantleHeight; // 0xbc
	System.Single CfgLocationAllowStand; // 0xc0
	System.Single[] CfgIgnoreSlopeHeightOffset; // 0xc8
	System.Single CfgJumpMinHeight; // 0xd0
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.MantleTestResult : System.ValueType
{
	static System.Func<WizardGames.Soc.Common.Unity.Character.IMantleDebug> CreateDbg; // 0x0
	System.Boolean Success; // 0x10
	UnityEngine.Vector3 StartPoint; // 0x14
	UnityEngine.Vector3 BaseSuccessPos; // 0x20
	System.Boolean MantleOnSuccess; // 0x2c
	System.Boolean MantleOverStartSuccess; // 0x2d
	System.Boolean MantleOnFailIsForward; // 0x2e
	UnityEngine.Vector3 MantleOnPoint; // 0x30
	System.Int64 PlatformId; // 0x40
	UnityEngine.Vector3 MantleOnHitPoint; // 0x48
	UnityEngine.RaycastHit MantleHitData; // 0x54
	System.Boolean MantleOverSuccess; // 0x80
	UnityEngine.Vector3 MantleOverPoint; // 0x84
	UnityEngine.Vector3 MantleOverFloorPoint; // 0x90
	System.Boolean IsObstacleExistConstruction; // 0x9c
	WizardGames.Soc.Common.Unity.Character.IMantleDebug DrawDebug; // 0xa0
	static System.Void .cctor(); // 0x07504284
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.MantleTestResult.<>c : System.Object
{
	static WizardGames.Soc.Common.Unity.Character.MantleTestResult.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x07504354
	System.Void .ctor(); // 0x075043b8
	WizardGames.Soc.Common.Unity.Character.IMantleDebug <.cctor>b__17_0(); // 0x07504420
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.MantleTestCache : System.ValueType
{
	UnityEngine.RaycastHit[] CacheRaycastResults; // 0x10
	UnityEngine.Collider[] CacheOverlapResults; // 0x18
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.MantleTestModule : System.Object
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.Common.Unity.Character.MantleTestCache StaticCache; // 0x8
	static System.Collections.Generic.List<UnityEngine.Vector3> motionPositions; // 0x18
	static System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Collider> OverlapHitList; // 0x20
	static System.Void MantleTest(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams playerLogicParams, WizardGames.Soc.Common.Unity.Character.MantleTestParams& Params, WizardGames.Soc.Common.Unity.Character.MantleTestResult& OutResult); // 0x075044a8
	static System.Boolean MantlePosAdjTest(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams playerLogicParams, WizardGames.Soc.Common.Unity.Character.MantleTestParams& Params, WizardGames.Soc.Common.Unity.Character.MantleTestResult& OutResult, System.Int32 CurrentLayerMask, UnityEngine.Vector3 playerForward, UnityEngine.Vector3& CCUpVector, WizardGames.Soc.Common.Unity.Character.EMantleStep step); // 0x07505bdc
	static System.Void MantleOnPoseTest(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams playerLogicParams, WizardGames.Soc.Common.Unity.Character.MantleTestParams Params, WizardGames.Soc.Common.Unity.Character.MantleTestResult& OutResult, System.Int32 CurrentLayerMask, UnityEngine.Vector3& CCUpVector); // 0x0750813c
	static System.Void MoveTraceTest2(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams playerLogicParams, WizardGames.Soc.Common.Unity.Character.MantleTestParams Params, WizardGames.Soc.Common.Unity.Character.MantleTestResult& OutResult, UnityEngine.Vector3 CCUpVector, System.Int32 CurrentLayerMask, UnityEngine.Vector3 playerForward); // 0x075085e4
	static System.Boolean MantleOnOverStartTest(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams playerLogicParams, WizardGames.Soc.Common.Unity.Character.MantleTestParams& Params, WizardGames.Soc.Common.Unity.Character.MantleTestResult& OutResult, System.Int32 CurrentLayerMask, UnityEngine.Vector3 playerForward, UnityEngine.Quaternion playerRotation, UnityEngine.Vector3& CCUpVector, WizardGames.Soc.Common.Unity.Character.EMantleStep step); // 0x07506480
	static System.Boolean BaseMoveTest(WizardGames.Soc.Common.Unity.Character.MantleTestParams& Params, WizardGames.Soc.Common.Unity.Character.MantleTestResult& OutResult, UnityEngine.Vector3 playerForward, System.Int32 CurrentLayerMask, UnityEngine.Vector3& CCUpVector, UnityEngine.RaycastHit& FinalBasicHit, WizardGames.Soc.Common.Unity.Character.PlayerLogicParams playerLogicParams, WizardGames.Soc.Common.Unity.Character.EMantleStep step); // 0x07505334
	static System.Boolean IgnoreFloorTest(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x07505128
	static System.Boolean IgnoreForwardTest(WizardGames.Soc.Common.Unity.Character.PlayerLogicParams logicParams); // 0x0750bdac
	static System.Boolean MoveForwardTest(WizardGames.Soc.Common.Unity.Character.MantleTestParams& Params, WizardGames.Soc.Common.Unity.Character.MantleTestResult& OutResult, UnityEngine.Vector3 playerForward, System.Int32 CurrentLayerMask, UnityEngine.Vector3& CCUpVector, UnityEngine.RaycastHit& FinalBasicHit, System.Int32 CurrentFloorHitIndex, UnityEngine.Vector3 CurrentCCPosition, UnityEngine.Vector3& SimulatedCCPosition, UnityEngine.Vector3& LastMoveDirection, WizardGames.Soc.Common.Unity.Character.PlayerLogicParams playerLogicParams, WizardGames.Soc.Common.Unity.Character.EMantleStep step); // 0x0750ad3c
	static System.Boolean FloorTest(WizardGames.Soc.Common.Unity.Character.MantleTestParams Params, WizardGames.Soc.Common.Unity.Character.MantleTestResult& OutResult, System.Int32 CurrentLayerMask, UnityEngine.Vector3& CCUpVector, UnityEngine.Vector3& CurrentCCPosition, System.Int32& CurrentFloorHitIndex, WizardGames.Soc.Common.Unity.Character.PlayerLogicParams playerLogicParams, WizardGames.Soc.Common.Unity.Character.EMantleStep step); // 0x0750a7f4
	static System.Boolean MoveObstacleTest(WizardGames.Soc.Common.Unity.Character.MantleTestParams Params, WizardGames.Soc.Common.Unity.Character.MantleTestResult& OutResult, UnityEngine.Vector3 playerForward, System.Int32 CurrentLayerMask, UnityEngine.Vector3& CCUpVector, UnityEngine.Vector3& CurrentCCPosition, WizardGames.Soc.Common.Unity.Character.EMantleStep step); // 0x07509e64
	static System.Single GroundTest(WizardGames.Soc.Common.Unity.Character.SocCharacterController cm, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3& groundNormal, System.Boolean& isWalkableGround); // 0x07509a38
	static System.Void GetMantlePointOnPlatform(WizardGames.Soc.Common.Unity.Character.MantleTestResult& OutResult, UnityEngine.Collider collider); // 0x07509ce0
	static System.Void .cctor(); // 0x0750c458
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.MantleUtils : System.Object
{
	static SocLogger logger; // 0x0
	static System.Void CopyFromCC(WizardGames.Soc.Common.Unity.Character.MantleTestParams& Params, WizardGames.Soc.Common.Unity.Character.SocCharacterController cc); // 0x0750c67c
	static System.Single ComputeWalkableFloorY(System.Single InWalkableFloorAngle); // 0x0750c938
	static System.Single Distance2D(UnityEngine.Vector3 a, UnityEngine.Vector3 b); // 0x0750c364
	static System.Boolean IsWalkable(WizardGames.Soc.Common.Unity.Character.MantleTestParams& Params, UnityEngine.RaycastHit& Hit, System.Nullable<System.Single> WalkableFloorY); // 0x0750c214
	static System.Void ComputeGroundRampVector(WizardGames.Soc.Common.Unity.Character.MantleTestParams& Params, UnityEngine.RaycastHit& HitData, UnityEngine.Vector3& Delta, UnityEngine.Vector3& OutRampMovement); // 0x0750be6c
	static System.Void ComputeCapsuleRayPoints(System.Single height, System.Single radius, UnityEngine.Vector3 center, UnityEngine.Vector3& dir, UnityEngine.Vector3& position, UnityEngine.Vector3& capsuleDownCenter, UnityEngine.Vector3& capsuleUpCenter); // 0x075051e8
	static System.Void ComputeCapsuleLocByHit(WizardGames.Soc.Common.Unity.Character.MantleTestParams& Params, UnityEngine.Vector3& UpVector, UnityEngine.RaycastHit& HitData, UnityEngine.Vector3& TraceStart, UnityEngine.Vector3& TraceDirection, UnityEngine.Vector3& OutCapsuleLoc); // 0x0750c0a0
	static System.Void .cctor(); // 0x0750c9cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Character.SocOtherCharacterController : System.Object
{
	static System.Single CollisionOffset = 0.0010000000474974513;
	static System.Int32 MaxOverlapColliders = 10;
	UnityEngine.Collider[] PenetrationInfoColliders; // 0x10
	System.Single CcRadius; // 0x18
	System.Single CcSkinWidth; // 0x1c
	UnityEngine.Vector3 CcCenter; // 0x20
	System.Single CcHeight; // 0x2c
	System.Single SlopeLimit; // 0x30
	UnityEngine.LayerMask CollisionLayerMask; // 0x34
	UnityEngine.QueryTriggerInteraction TriggerQuery; // 0x38
	static UnityEngine.CapsuleCollider CapsuleCollider; // 0x0
	static UnityEngine.Rigidbody rigidbody; // 0x8
	static UnityEngine.GameObject Go; // 0x10
	UnityEngine.RaycastHit[] raycastHitCache; // 0x40
	System.Void .ctor(); // 0x0750caa0
	System.Boolean CapsuleCast(System.Int64 entityId, UnityEngine.Vector3 direction, System.Single distance, UnityEngine.Vector3 currentPosition, System.Boolean& smallRadiusHit, System.Boolean& bigRadiusHit, UnityEngine.RaycastHit& smallRadiusHitInfo, UnityEngine.RaycastHit& bigRadiusHitInfo, UnityEngine.Vector3 offsetPosition); // 0x07509668
	System.Void MoveAwayFromObstacle(UnityEngine.RaycastHit& hitInfoCapsule, UnityEngine.Vector3 direction, System.Single distance, System.Boolean hitSmallCapsule, UnityEngine.Vector3& currentPosition, System.Single limitDis); // 0x0750d388
	System.Void NewMoveAwayFromObstacle(UnityEngine.RaycastHit& hitInfoCapsule, UnityEngine.Vector3 direction, System.Single distance, System.Boolean hitSmallCapsule, UnityEngine.Vector3& currentPosition, System.Single limitDis); // 0x07509868
	System.Boolean SmallCapsuleCast(System.Int64 entityId, UnityEngine.Vector3 direction, System.Single distance, UnityEngine.RaycastHit& smallRadiusHitInfo, UnityEngine.Vector3 offsetPosition, UnityEngine.Vector3 currentPosition); // 0x0750cdec
	System.Boolean BigCapsuleCast(System.Int64 entityId, UnityEngine.Vector3 direction, System.Single distance, UnityEngine.RaycastHit& bigRadiusHitInfo, UnityEngine.Vector3 offsetPosition, UnityEngine.Vector3 currentPosition); // 0x0750d0b8
	UnityEngine.Vector3 GetTopSphereWorldPosition(UnityEngine.Vector3 position); // 0x0750dbb8
	UnityEngine.Vector3 GetBottomSphereWorldPosition(UnityEngine.Vector3 position); // 0x0750dcb8
	System.Void MovePosition(UnityEngine.Vector3 moveVector, System.Nullable<UnityEngine.Vector3> collideDirection, System.Nullable<UnityEngine.RaycastHit> hitInfo, UnityEngine.Vector3& currentPosition); // 0x0750d620
	System.Boolean GetPenetrationInfo(System.Single& getDistance, UnityEngine.Vector3& getDirection, UnityEngine.Vector3 currentPosition, System.Boolean includeSkinWidth, System.Nullable<UnityEngine.Vector3> offsetPosition, System.Nullable<UnityEngine.RaycastHit> hitInfo); // 0x0750d77c
	System.Boolean TestComputePenetration(UnityEngine.Collider[] colliders, UnityEngine.Vector3 offset, System.Boolean includeSkinWidth, UnityEngine.Vector3& currentPosition, System.Nullable<UnityEngine.RaycastHit> hitInfo, System.Boolean& result, UnityEngine.Vector3& localPos); // 0x0750ddb8
	System.Boolean ComputePenetration(UnityEngine.Vector3 positionOffset, UnityEngine.Collider collider, UnityEngine.Vector3 colliderPosition, UnityEngine.Quaternion colliderRotation, UnityEngine.Vector3& direction, System.Single& distance, System.Boolean includeSkinWidth, UnityEngine.Vector3 currentPosition); // 0x0750e1f8
	static System.Void Clear(); // 0x0750e530
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Character.AnimType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Character.AnimType None = 0;
	static WizardGames.Soc.Common.Unity.Character.AnimType ArrowIdle = 1;
	static WizardGames.Soc.Common.Unity.Character.AnimType NonArrowIdle = 2;
	static WizardGames.Soc.Common.Unity.Character.AnimType Pick = 3;
	static WizardGames.Soc.Common.Unity.Character.AnimType Fire = 4;
	static WizardGames.Soc.Common.Unity.Character.AnimType Cancel = 5;
	static WizardGames.Soc.Common.Unity.Character.AnimType AdsHold = 6;
	static WizardGames.Soc.Common.Unity.Character.AnimType Charge = 7;
	static WizardGames.Soc.Common.Unity.Character.AnimType ChargeReverse = 8;
	static WizardGames.Soc.Common.Unity.Character.AnimType ChargeFire = 9;
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimatorContext : System.ValueType, WizardGames.Soc.Common.Character.IAnimSpeedData
{
	System.Boolean HasMove; // 0x10
	System.Single MoveForward; // 0x14
	System.Single MoveRight; // 0x18
	System.Boolean bMySelf; // 0x1c
	System.Int64 ServerTime; // 0x20
	WizardGames.Soc.Common.Contexts.Context context; // 0x28
	WizardGames.Soc.Common.Entity.PlayerEntity PlayerEntity; // 0x30
	WizardGames.Soc.Common.Entity.IHeldItemEntity HeldItemEntity; // 0x38
	WizardGames.Soc.Common.Entity.IBaseMountableEntity VehicleEntity; // 0x40
	Soc.Vehicle.SeatStyleType SeatStyleType; // 0x48
	WizardGames.Soc.Common.SimpleCustom.UserCmd Cmd; // 0x50
	WizardGames.Soc.Common.Unity.Go.BaseMountableGo MountableGo; // 0x58
	System.Boolean nowFpVersion; // 0x60
	WizardGames.Soc.Common.Unity.Animation.ISocAnimationRuntime AnimatorWrapper; // 0x68
	UnityEngine.Animator weaponAnimator; // 0x70
	WizardGames.Soc.Common.Unity.Character.BlendTree2dSimpleDirectional JogStandPoseBT2D; // 0x78
	WizardGames.Soc.Common.Unity.Character.BlendTree2dSimpleDirectional JogCrouchPoseBT2D; // 0x80
	UnitySkeletonData TpSkeletonData; // 0x88
	WizardGames.Editor.TpSkeletonMaskData TpSkeletonMaskData; // 0x98
	WizardGames.Soc.Common.Entity.PlayerPoseStateEnum <PoseState>k__BackingField; // 0xa0
	WizardGames.Soc.Common.Entity.PlayerMoveStateEnum <MoveState>k__BackingField; // 0xa1
	WizardGames.Soc.Common.Entity.PlayerUnAliveStateEnum <UnAliveState>k__BackingField; // 0xa2
	WizardGames.Soc.Common.Entity.PlayerMoveLadderStateEnum <MoveLadderState>k__BackingField; // 0xa3
	WizardGames.Soc.Common.Entity.PlayerActionStateEnum <ActionState>k__BackingField; // 0xa4
	System.Single <SpeedX>k__BackingField; // 0xa8
	System.Single <SpeedZ>k__BackingField; // 0xac
	System.Single <SpeedY>k__BackingField; // 0xb0
	System.Single <RotateY>k__BackingField; // 0xb4
	System.Int64 <Interval>k__BackingField; // 0xb8
	Unity.Mathematics.quaternion <LadderQuat>k__BackingField; // 0xc0
	Unity.Mathematics.float3 <LadderNormal>k__BackingField; // 0xd0
	Unity.Mathematics.float3 <LadderForward>k__BackingField; // 0xdc
	Unity.Mathematics.float3 <LadderRight>k__BackingField; // 0xe8
	CommonUnity.Runtime.Animation.AnimMoveSpeedLocalCacheGroup MoveSpeedLocalCaches; // 0xf4
	CommonUnity.Runtime.Animation.AnimMoveSpeedConfGroup MoveSpeedConfList; // 0x1a8
	Unity.Collections.NativeArray<CommonUnity.Runtime.Animation.AnimProcedureCtrlJobConfGroup> MatchRules; // 0x338
	Unity.Collections.NativeArray<WizardGames.Soc.Common.Character.FpMaskWeightConfGroup> MaskArray; // 0x348
	System.Boolean Init; // 0x358
	WizardGames.Editor.FpClipSettingMeta <ApplyFpMeta>k__BackingField; // 0x360
	WizardGames.Editor.FpClipSettingMeta <CurrentFpMeta>k__BackingField; // 0x368
	System.Int32 AnimatorInstanceId; // 0x370
	WizardGames.Soc.Common.Utility.SpringDamper DampingX; // 0x378
	WizardGames.Soc.Common.Utility.SpringDamper DampingY; // 0x380
	WizardGames.Soc.Common.Utility.SpringDamper DampingZ; // 0x388
	WizardGames.Soc.Common.Unity.CameraStateController CameraStateController; // 0x390
	WizardGames.Soc.Common.Entity.PlayerPoseStateEnum get_PoseState(); // 0x0750e640
	System.Void set_PoseState(WizardGames.Soc.Common.Entity.PlayerPoseStateEnum value); // 0x0750e6a4
	WizardGames.Soc.Common.Entity.PlayerMoveStateEnum get_MoveState(); // 0x0750e71c
	System.Void set_MoveState(WizardGames.Soc.Common.Entity.PlayerMoveStateEnum value); // 0x0750e780
	WizardGames.Soc.Common.Entity.PlayerUnAliveStateEnum get_UnAliveState(); // 0x0750e7f8
	System.Void set_UnAliveState(WizardGames.Soc.Common.Entity.PlayerUnAliveStateEnum value); // 0x0750e85c
	WizardGames.Soc.Common.Entity.PlayerMoveLadderStateEnum get_MoveLadderState(); // 0x0750e8d4
	System.Void set_MoveLadderState(WizardGames.Soc.Common.Entity.PlayerMoveLadderStateEnum value); // 0x0750e938
	WizardGames.Soc.Common.Entity.PlayerActionStateEnum get_ActionState(); // 0x0750e9b0
	System.Void set_ActionState(WizardGames.Soc.Common.Entity.PlayerActionStateEnum value); // 0x0750ea14
	System.Single get_SpeedX(); // 0x0750ea8c
	System.Void set_SpeedX(System.Single value); // 0x0750eaf0
	System.Single get_SpeedZ(); // 0x0750eb68
	System.Void set_SpeedZ(System.Single value); // 0x0750ebcc
	System.Single get_SpeedY(); // 0x0750ec44
	System.Void set_SpeedY(System.Single value); // 0x0750eca8
	System.Single get_RotateY(); // 0x0750ed20
	System.Void set_RotateY(System.Single value); // 0x0750ed84
	System.Int64 get_Interval(); // 0x0750edfc
	System.Void set_Interval(System.Int64 value); // 0x0750ee60
	System.Void set_LadderQuat(Unity.Mathematics.quaternion value); // 0x0750eed8
	System.Void set_LadderNormal(Unity.Mathematics.float3 value); // 0x0750ef78
	System.Void set_LadderForward(Unity.Mathematics.float3 value); // 0x0750f010
	System.Void set_LadderRight(Unity.Mathematics.float3 value); // 0x0750f0a8
	WizardGames.Editor.FpClipSettingMeta get_ApplyFpMeta(); // 0x0750f140
	System.Void set_ApplyFpMeta(WizardGames.Editor.FpClipSettingMeta value); // 0x0750f1a4
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.FpClipLengthCollect : System.ValueType
{
	System.Boolean Init; // 0x10
	WizardGames.Soc.Common.Unity.Character.FpClipLength NowState; // 0x14
	WizardGames.Soc.Common.Unity.Character.FpClipLength LastState; // 0x4c
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.FpClipLength : System.ValueType
{
	WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer OcState; // 0x10
	WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer AddState; // 0x14
	WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer LocoState; // 0x18
	WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveSubLayer AddSubState; // 0x1c
	System.Single AniTime; // 0x20
	System.Single NowTime; // 0x24
	System.Boolean Start; // 0x28
	System.Single Percent; // 0x2c
	System.Single PlayRate; // 0x30
	System.Boolean IsLoop; // 0x34
	System.Single TransitionTime; // 0x38
	System.Int32 TransitionType; // 0x3c
	System.Single TransitionPercent; // 0x40
	System.Single DefaultTransitionTime; // 0x44
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersAnimal : System.ValueType, WizardGames.Soc.Common.Unity.Character.IAnimatorApply
{
	static System.Int32[] Base_Layer_AllHash; // 0x0
	static System.Int32[] Base_Layer_FullPathHash; // 0x8
	WizardGames.Soc.Common.Unity.Character.AnimParametersAnimal.FloatParams floatParams; // 0x10
	WizardGames.Soc.Common.Unity.Character.AnimParametersAnimal.BoolParams boolParams; // 0x1c
	WizardGames.Soc.Common.Unity.Character.AnimParametersAnimal.IntParams intParams; // 0x21
	System.Void SetFloat(System.Int32 offset, System.Single value); // 0x0750f224
	System.Single GetFloat(System.Int32 offset); // 0x0750f2b8
	System.Int32 GetInt(System.Int32 offset); // 0x0750f33c
	System.Boolean GetBool(System.Int32 offset); // 0x0750f3b4
	System.Void CopyParams(UnityEngine.OptimizationAnimatorParameterFlushMem& flushMem); // 0x0750f448
	System.Void ApplyToAnimator(UnityEngine.OptimizationAnimatorParameterFlushMem& flushMem); // 0x0750f578
	static System.Void .cctor(); // 0x0750f6a8
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersAnimal.FloatParams : System.ValueType
{
	System.Single walkSpeed; // 0x10
	System.Single speedFactor; // 0x14
	System.Single idle_type; // 0x18
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersAnimal.BoolParams : System.ValueType
{
	System.Boolean sleeping; // 0x10
	System.Boolean isMoving; // 0x11
	System.Boolean attack; // 0x12
	System.Boolean eat; // 0x13
	System.Boolean Death; // 0x14
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersAnimal.IntParams : System.ValueType
{
	
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersFp : System.ValueType, WizardGames.Soc.Common.Unity.Character.IAnimatorApply
{
	static System.Int32[] PoseLayer_AllHash; // 0x0
	static System.Int32[] PoseLayer_FullPathHash; // 0x8
	static System.Int32[] SightLayer_AllHash; // 0x10
	static System.Int32[] SightLayer_FullPathHash; // 0x18
	static System.Int32[] LocomotionLayer_AllHash; // 0x20
	static System.Int32[] LocomotionLayer_FullPathHash; // 0x28
	static System.Int32[] AdditiveLayer_AllHash; // 0x30
	static System.Int32[] AdditiveLayer_FullPathHash; // 0x38
	static System.Int32[] AdditiveSubLayer_AllHash; // 0x40
	static System.Int32[] AdditiveSubLayer_FullPathHash; // 0x48
	static System.Int32[] OverrideLayer_AllHash; // 0x50
	static System.Int32[] OverrideLayer_FullPathHash; // 0x58
	WizardGames.Soc.Common.Unity.Character.AnimParametersFp.FloatParams floatParams; // 0x10
	WizardGames.Soc.Common.Unity.Character.AnimParametersFp.BoolParams boolParams; // 0x140
	WizardGames.Soc.Common.Unity.Character.AnimParametersFp.IntParams intParams; // 0x141
	System.Void SetFloat(System.Int32 offset, System.Single value); // 0x0750f78c
	System.Single GetFloat(System.Int32 offset); // 0x0750f820
	System.Int32 GetInt(System.Int32 offset); // 0x0750f8a4
	System.Boolean GetBool(System.Int32 offset); // 0x0750f91c
	System.Void CopyParams(UnityEngine.OptimizationAnimatorParameterFlushMem& flushMem); // 0x0750f9a8
	System.Void ApplyToAnimator(UnityEngine.OptimizationAnimatorParameterFlushMem& flushMem); // 0x0750fad8
	static System.Void .cctor(); // 0x0750fc08
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EPoseLayer : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EPoseLayer Pose = 0;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EPoseLayer SprintPose = 1;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EPoseLayer SwimPose = 2;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EPoseLayer LadderPose = 3;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EPoseLayer DrivePose_basic_train_sit_drive_pose = 4;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EPoseLayer DrivePose_basic_boat_sit_drive_pose = 5;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EPoseLayer DrivePose_basic_parachute_drive_pose = 6;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EPoseLayer Sum = 7;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ESightLayer : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ESightLayer SightEmpty = 0;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ESightLayer SightMachine_Sight = 1;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ESightLayer SightMachine_AdsUp = 2;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ESightLayer SightMachine_AdsDown = 3;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ESightLayer SightMachine_AdsDownSettle = 4;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ESightLayer Sum = 5;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer LocomotionEmpty = 0;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer Swim = 1;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer HipStance = 2;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer SightJog = 3;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer MountableMove = 4;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer Mantle_MantleOnLow = 5;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer Mantle_MantleOnHigh = 6;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer HipMove_HipMoveEmpty = 7;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer HipMove_Jog = 8;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer HipMove_JogToSprint = 9;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer HipMove_Sprint = 10;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer HipMove_SprintToJog = 11;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer Jump_JumpEmpty = 12;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer Jump_Jump_NoSightJumpEmpty = 13;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer Jump_Jump_JumpStart = 14;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer Jump_Jump_JumpEnd = 15;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer Jump_Jump_JumpLoop = 16;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer Jump_SightJump_SightJumpEmpty = 17;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer Jump_SightJump_SightJumpStart = 18;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer Jump_SightJump_SightJumpLoop = 19;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer Jump_SightJump_SightJumpEnd = 20;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer Ladder_LadderMove = 21;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer Ladder_ladderLeave = 22;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer Parachute_ParachuteIdle = 23;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer Parachute_ParachuteEnd = 24;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer Parachute_ParachuteStart = 25;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer Parachute_ParachuteCut = 26;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer SightIdle = 27;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.ELocomotionLayer Sum = 28;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer AdditiveEmpty = 0;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer GunFire_Fire = 1;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer GunFire_SightFire = 2;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer MeleeAttack_Attack_U = 3;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer MeleeAttack_AttackHit_U = 4;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer MeleeAttack_Attack_R = 5;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer MeleeAttack_Attack_R2 = 6;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer MeleeAttack_Attack_C = 7;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer MeleeAttack_Attack_L2 = 8;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer MeleeAttack_Attack_L = 9;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer MeleeAttack_AttackHit_R = 10;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer MeleeAttack_AttackHit_R2 = 11;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer MeleeAttack_AttackHit_C = 12;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer MeleeAttack_AttackHit_L2 = 13;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer MeleeAttack_AttackHit_L = 14;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer Throw_ThrowStart = 15;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer Throw_ThrowFarLoop = 16;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer Throw_ThrowCancel = 17;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer Throw_FarThrow = 18;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer Throw_NearThrow = 19;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer Throw_ThrowNearLoop = 20;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer Throw_ThrowNearStart = 21;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer Throw_ThrowNearCancel = 22;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer SustainAttack_AttackStart = 23;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer SustainAttack_AttackLoop = 24;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer SustainAttack_AttackHitLoop = 25;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer SustainAttack_AttackEnd = 26;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer Bow_ArrowIdle = 27;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer Bow_CancelArrow = 28;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer Bow_PickArrow = 29;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer Bow_FireArrow = 30;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer Bow_BowEmpty = 31;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer Bow_ChargeLoop = 32;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer Bow_Charge = 33;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer Bow_ChargeReverse = 34;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer Bow_ChargeFireArrow = 35;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer Bow_BowFireMachine_BowFireStart = 36;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer Bow_BowFireMachine_BowFireLoop = 37;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer WaterBottle_Drink = 38;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer WaterBottle_Pour = 39;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer WaterBottle_CollectEnd = 40;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer WaterBottle_CollectLoop = 41;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer WaterBottle_CollectStart = 42;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer WaterBottle_ColletFill = 43;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer FireWarm_FireWarm = 44;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer FireWarm_FireWarmEnd = 45;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer FireWarm_FireWarmLoop = 46;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveLayer Sum = 47;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveSubLayer : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveSubLayer Empty = 0;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveSubLayer Recoil = 1;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EAdditiveSubLayer Sum = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer OverrideEmpty = 0;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer PickUpL = 1;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer OpenDoorL = 2;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer PickUpR = 3;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer OpenDoorR = 4;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer Draw = 5;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer QuickDraw = 6;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer Sleep = 7;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer Wave = 8;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer SwpieCard = 9;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer Inspection = 10;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer StartUp = 11;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer TryFire = 12;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer WakeUp = 13;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer Gesture = 14;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer Reload_ReloadStart = 15;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer Reload_ReloadEmpty = 16;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer Reload_ReloadEnd = 17;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer GunFireEnd_FireEnd = 18;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer GunFireEnd_SightFireEnd = 19;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer UseForOther_UseForOther = 20;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer UseForOther_UseForOtherHit = 21;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer UseItem_Use = 22;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersFp.EOverrideLayer Sum = 23;
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersFp.FloatParams : System.ValueType
{
	System.Single LerpStandCrouch; // 0x10
	System.Single BreathSpeed; // 0x14
	System.Single Speed; // 0x18
	System.Single SpeedX; // 0x1c
	System.Single SpeedZ; // 0x20
	System.Single MantleSpeed; // 0x24
	System.Single AdsProgressInverse; // 0x28
	System.Single ForSwimPose; // 0x2c
	System.Single MoveRight; // 0x30
	System.Single MoveForward; // 0x34
	System.Single UseExtraAnim; // 0x38
	System.Single ParachuteMoveSpeed; // 0x3c
	System.Single ParachuteRotateSpeed; // 0x40
	System.Single JumpLoopType; // 0x44
	System.Single LeftIKAutoCurve; // 0x48
	System.Single RightIKAutoCurve; // 0x4c
	System.Single stand_hit_attack_AutoPlayRate; // 0x50
	System.Single stand_adsdown_AutoPlayRate; // 0x54
	System.Single stand_adsup_AutoPlayRate; // 0x58
	System.Single stand_chargeup_AutoPlayRate; // 0x5c
	System.Single stand_chargedown_AutoPlayRate; // 0x60
	System.Single stand_hip_reloadend_AutoPlayRate; // 0x64
	System.Single stand_hip_reloadstart_AutoPlayRate; // 0x68
	System.Single stand_hip_reloadempty_AutoPlayRate; // 0x6c
	System.Single stand_sight_fireend_AutoPlayRate; // 0x70
	System.Single stand_hip_fireend_AutoPlayRate; // 0x74
	System.Single stand_hip_draw_AutoPlayRate; // 0x78
	System.Single stand_hip_fire_AutoPlayRate; // 0x7c
	System.Single JogDynamic_Action_WeightCurve; // 0x80
	System.Single JogSpine_Action_WeightCurve; // 0x84
	System.Single JogWeapon_Action_WeightCurve; // 0x88
	System.Single JogLeftArm_Action_WeightCurve; // 0x8c
	System.Single JogRightArm_Action_WeightCurve; // 0x90
	System.Single JogLClavicle_Action_WeightCurve; // 0x94
	System.Single JogHead_Action_WeightCurve; // 0x98
	System.Single JogRClavicle_Action_WeightCurve; // 0x9c
	System.Single SprintDynamic_Action_WeightCurve; // 0xa0
	System.Single SprintSpine_Action_WeightCurve; // 0xa4
	System.Single SprintWeapon_Action_WeightCurve; // 0xa8
	System.Single SprintLeftArm_Action_WeightCurve; // 0xac
	System.Single SprintRightArm_Action_WeightCurve; // 0xb0
	System.Single SprintHead_Action_WeightCurve; // 0xb4
	System.Single SprintRClavicle_Action_WeightCurve; // 0xb8
	System.Single SprintLClavicle_Action_WeightCurve; // 0xbc
	System.Single JumpDynamic_Action_WeightCurve; // 0xc0
	System.Single JumpSpine_Action_WeightCurve; // 0xc4
	System.Single JumpWeapon_Action_WeightCurve; // 0xc8
	System.Single JumpRightArm_Action_WeightCurve; // 0xcc
	System.Single JumpLeftArm_Action_WeightCurve; // 0xd0
	System.Single JumpLClavicle_Action_WeightCurve; // 0xd4
	System.Single JumpHead_Action_WeightCurve; // 0xd8
	System.Single JumpRClavicle_Action_WeightCurve; // 0xdc
	System.Single SwimSpine_Action_WeightCurve; // 0xe0
	System.Single SwimDynamic_Action_WeightCurve; // 0xe4
	System.Single SwimWeapon_Action_WeightCurve; // 0xe8
	System.Single SwimLeftArm_Action_WeightCurve; // 0xec
	System.Single SwimRightArm_Action_WeightCurve; // 0xf0
	System.Single SwimLClavicle_Action_WeightCurve; // 0xf4
	System.Single SwimHead_Action_WeightCurve; // 0xf8
	System.Single SwimRClavicle_Action_WeightCurve; // 0xfc
	System.Single stand_sight_jumpstart_AutoCurve; // 0x100
	System.Single stand_sight_jumpstart_AnimWeight_AutoCurve; // 0x104
	System.Single stand_sight_jumploop_AutoCurve; // 0x108
	System.Single stand_sight_jumploop_AnimWeight_AutoCurve; // 0x10c
	System.Single stand_sight_jumpend_AutoCurve; // 0x110
	System.Single stand_sight_jumpend_AnimWeight_AutoCurve; // 0x114
	System.Single stand_hip_jumpstart_AutoCurve; // 0x118
	System.Single stand_hip_jumpstart_AnimWeight_AutoCurve; // 0x11c
	System.Single stand_hip_jumploop_AutoCurve; // 0x120
	System.Single stand_hip_jumploop_AnimWeight_AutoCurve; // 0x124
	System.Single stand_hip_jumpend_AutoCurve; // 0x128
	System.Single stand_hip_jumpend_AnimWeight_AutoCurve; // 0x12c
	System.Single stand_hip_fireend_AutoCurve; // 0x130
	System.Single stand_hip_fireend_AnimWeight_AutoCurve; // 0x134
	System.Single stand_sight_fireend_AutoCurve; // 0x138
	System.Single stand_sight_fireend_AnimWeight_AutoCurve; // 0x13c
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersFp.BoolParams : System.ValueType
{
	System.Boolean Over; // 0x10
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersFp.IntParams : System.ValueType
{
	
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersFp_Extra : System.ValueType
{
	static System.Collections.Generic.Dictionary<System.String,System.Int32> floatOffsetMap; // 0x0
	static System.Collections.Generic.Dictionary<System.String,System.Int32> boolOffsetMap; // 0x8
	static System.Collections.Generic.Dictionary<System.String,System.Int32> intOffsetMap; // 0x10
	static System.Collections.Generic.Dictionary<System.Int32,System.String[]> AllClipCache; // 0x18
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32> StateSpeedPairs; // 0x20
	static System.Void .cctor(); // 0x0750ffc4
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersHorse : System.ValueType, WizardGames.Soc.Common.Unity.Character.IAnimatorApply
{
	static System.Int32 BaseLayer_LayerIndex = 0;
	static System.Int32 BaseLayer_Idles_Idle1_NameId = 790364397;
	static System.Int32 BaseLayer_Idles_Idle2_NameId = -1240116905;
	static System.Int32 BaseLayer_Idles_Idle3_NameId = -1055759935;
	static System.Int32 BaseLayer_Idles_Idle4_NameId = 1601631330;
	static System.Int32 BaseLayer_Idles_Idle5_NameId = 678544628;
	static System.Int32 BaseLayer_Jump_Neigh_NameId = 63632033;
	static System.Int32 BaseLayer_Jump_JumpForward_JumpForwardStart_NameId = -1808020744;
	static System.Int32 BaseLayer_Jump_JumpForward_JumpForwardAir_NameId = -177746440;
	static System.Int32 BaseLayer_Jump_JumpForward_JumpForwardEnd_NameId = 1241204402;
	static System.Int32 BaseLayer_Jump_JumpCanter_JumpCanterStart_NameId = -1280019310;
	static System.Int32 BaseLayer_Jump_JumpCanter_JumpCanterAir_NameId = 44714471;
	static System.Int32 BaseLayer_Jump_JumpCanter_JumpCanterEnd_NameId = -1103707475;
	static System.Int32 BaseLayer_Jump_JumpGallop_JumpGallopStart_NameId = 1803418445;
	static System.Int32 BaseLayer_Jump_JumpGallop_JumpGallopAir_NameId = -941270754;
	static System.Int32 BaseLayer_Jump_JumpGallop_JumpGallopEnd_NameId = 2071581268;
	static System.Int32 BaseLayer_Jump_JumpSprint_JumpSprintStart_NameId = -1405454089;
	static System.Int32 BaseLayer_Jump_JumpSprint_JumpSprintAir_NameId = 1408676625;
	static System.Int32 BaseLayer_Jump_JumpSprint_JumpSprintEnd_NameId = -278251429;
	static System.Int32 BaseLayer_Death_Death1_NameId = 1480695963;
	static System.Int32 BaseLayer_Death_Death2_NameId = -1052184287;
	static System.Int32 BaseLayer_Death_Death1Opp_NameId = -1524137597;
	static System.Int32 BaseLayer_Death_Death2Opp_NameId = -1215156627;
	static System.Int32 BaseLayer_Death_DeathGallop_NameId = -707722184;
	static System.Int32 BaseLayer_Fall_FallFromEdge_NameId = -1138185066;
	static System.Int32 BaseLayer_Fall_Fall_NameId = 1533177906;
	static System.Int32 BaseLayer_Damage_DamagedBackRight_NameId = 660014901;
	static System.Int32 BaseLayer_Damage_DamagedFrontLeft_NameId = 1535698814;
	static System.Int32 BaseLayer_Damage_DamagedRight_NameId = -1794690146;
	static System.Int32 BaseLayer_Damage_DamagedLeft_NameId = 64346204;
	static System.Int32 BaseLayer_Damage_DamagedBackLeft_NameId = -286630939;
	static System.Int32 BaseLayer_Damage_DamagedFrontRight_NameId = 1077882693;
	static System.Int32 BaseLayer_Locomotion_Landing_NameId = 545781641;
	static System.Int32 BaseLayer_Locomotion_Locomotion_NameId = -2089788878;
	static System.Int32 BaseLayer_Actions_Drink1_NameId = 1974056579;
	static System.Int32 BaseLayer_Actions_Drink2_NameId = -324999367;
	static System.Int32 OverLayer_LayerIndex = 1;
	static System.Int32 OverLayer_Empty_NameId = -1459219776;
	static System.Int32 OverLayer_Actions_Drink1_NameId = 1974056579;
	static System.Int32 OverLayer_Actions_Drink2_NameId = -324999367;
	static System.Int32 OverLayer_Attacks_AttackBackLegs_NameId = 2133172458;
	static System.Int32 AddLayer_LayerIndex = 2;
	static System.Int32 AddLayer_Null_NameId = -2047257743;
	static System.Int32 AddLayer_Damage_Moving_Damaged_Back_Right_NameId = -1692500592;
	static System.Int32 AddLayer_Damage_Moving_Damaged_Front_Left_NameId = -1656812002;
	static System.Int32 AddLayer_Damage_Moving_Damaged_Right_NameId = -170715966;
	static System.Int32 AddLayer_Damage_Moving_Damaged_Left_NameId = 1736200643;
	static System.Int32 AddLayer_Damage_Moving_Damaged_Back_Left_NameId = -1055660972;
	static System.Int32 AddLayer_Damage_Moving_Damaged_Front_Right_NameId = 223082996;
	static System.Collections.Generic.Dictionary<System.Int32,System.String[]> AllClipCache; // 0x0
	static System.Int32 Horizontal_Id = 475924382;
	static System.Int32 Vertical_Id = 1358960330;
	static System.Int32 StateFloat_Id = -1895855204;
	static System.Int32 SpeedMultiplier_Id = -382374917;
	static System.Int32 Mode_Id = 939059349;
	static System.Int32 DeadType_Id = -1278649787;
	static System.Collections.Generic.Dictionary<System.String,System.Int32> floatOffsetMap; // 0x8
	static System.Collections.Generic.Dictionary<System.String,System.Int32> boolOffsetMap; // 0x10
	static System.Collections.Generic.Dictionary<System.String,System.Int32> intOffsetMap; // 0x18
	WizardGames.Soc.Common.Unity.Character.AnimParametersHorse.FloatParams floatParams; // 0x10
	WizardGames.Soc.Common.Unity.Character.AnimParametersHorse.BoolParams boolParams; // 0x24
	WizardGames.Soc.Common.Unity.Character.AnimParametersHorse.IntParams intParams; // 0x28
	System.Void SetFloat(System.Int32 offset, System.Single value); // 0x07513c10
	System.Single GetFloat(System.Int32 offset); // 0x07513ca4
	System.Int32 GetInt(System.Int32 offset); // 0x07513d28
	System.Boolean GetBool(System.Int32 offset); // 0x07513dac
	System.Void CopyParams(UnityEngine.OptimizationAnimatorParameterFlushMem& flushMem); // 0x07513e38
	System.Void ApplyToAnimator(UnityEngine.OptimizationAnimatorParameterFlushMem& flushMem); // 0x07513fb0
	static System.Void .cctor(); // 0x07514128
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersHorse.FloatParams : System.ValueType
{
	System.Single Horizontal; // 0x10
	System.Single Vertical; // 0x14
	System.Single StateFloat; // 0x18
	System.Single SpeedMultiplier; // 0x1c
	System.Single DeadType; // 0x20
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersHorse.BoolParams : System.ValueType
{
	
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersHorse.IntParams : System.ValueType
{
	System.Int32 Mode; // 0x10
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersScientist : System.ValueType, WizardGames.Soc.Common.Unity.Character.IAnimatorApply
{
	static System.Int32 LocomotionLayer_LayerIndex = 0;
	static System.Int32 LocomotionLayer_LocomotionEmpty_NameId = -1844923080;
	static System.Int32 LocomotionLayer_LocomotionEmpty_NameId_FullPathHash = 692042140;
	static System.Int32 LocomotionLayer_Locomotion_LocomotionSprintF_NameId = 1128133182;
	static System.Int32 LocomotionLayer_Locomotion_LocomotionSprintF_NameId_FullPathHash = -2032892813;
	static System.Int32 LocomotionLayer_Locomotion_LeisureWalk_NameId = -141822608;
	static System.Int32 LocomotionLayer_Locomotion_LeisureWalk_NameId_FullPathHash = -1071676361;
	static System.Int32 LocomotionLayer_Locomotion_Locomotion_JogLStand_NameId = 585567996;
	static System.Int32 LocomotionLayer_Locomotion_Locomotion_JogLStand_NameId_FullPathHash = -99183610;
	static System.Int32 LocomotionLayer_Locomotion_Locomotion_JogRStand_NameId = 456879383;
	static System.Int32 LocomotionLayer_Locomotion_Locomotion_JogRStand_NameId_FullPathHash = -1010108435;
	static System.Int32 LocomotionLayer_Locomotion_Locomotion_JogBStand_NameId = 418213772;
	static System.Int32 LocomotionLayer_Locomotion_Locomotion_JogBStand_NameId_FullPathHash = -1071843978;
	static System.Int32 LocomotionLayer_Locomotion_Locomotion_JogFStand_NameId = -2089013862;
	static System.Int32 LocomotionLayer_Locomotion_Locomotion_JogFStand_NameId_FullPathHash = 1536014176;
	static System.Int32 LocomotionLayer_Idle_HipStandIdle_NameId = -579799716;
	static System.Int32 LocomotionLayer_Idle_HipStandIdle_NameId_FullPathHash = 993666640;
	static System.Int32 LocomotionLayer_Idle_HipCrouchIdle_NameId = -988766710;
	static System.Int32 LocomotionLayer_Idle_HipCrouchIdle_NameId_FullPathHash = -868181774;
	static System.Int32 LocomotionLayer_Idle_LeisureIdle_NameId = -1505871312;
	static System.Int32 LocomotionLayer_Idle_LeisureIdle_NameId_FullPathHash = -1884211329;
	static System.Int32 LocomotionLayer_Idle_LeisureIdle02_NameId = 1325546739;
	static System.Int32 LocomotionLayer_Idle_LeisureIdle02_NameId_FullPathHash = 1179793931;
	static System.Int32 LocomotionLayer_Idle_LeisureIdle03_NameId = 939854949;
	static System.Int32 LocomotionLayer_Idle_LeisureIdle03_NameId_FullPathHash = 827656861;
	static System.Int32 LocomotionLayer_Idle_LeisureIdle04_NameId = -1503553082;
	static System.Int32 LocomotionLayer_Idle_LeisureIdle04_NameId_FullPathHash = -1355702466;
	static System.Int32 LocomotionLayerDynamics_LayerIndex = 1;
	static System.Int32 PoseLayer_LayerIndex = 2;
	static System.Int32 PoseLayer_BattleIdlePose_NameId = -1072543522;
	static System.Int32 PoseLayer_BattleIdlePose_NameId_FullPathHash = 2001996215;
	static System.Int32 PoseLayer_VehiclePose_NameId = -1045713750;
	static System.Int32 PoseLayer_VehiclePose_NameId_FullPathHash = -745507367;
	static System.Int32 PoseLayer_ThrowPose_NameId = -1303198763;
	static System.Int32 PoseLayer_ThrowPose_NameId_FullPathHash = 1359833483;
	static System.Int32 PoseLayer_LeisureIdlePose_NameId = 934241798;
	static System.Int32 PoseLayer_LeisureIdlePose_NameId_FullPathHash = 58128827;
	static System.Int32 AdditiveLayer_LayerIndex = 3;
	static System.Int32 AdditiveLayer_AdditiveEmpty_NameId = 1401562295;
	static System.Int32 AdditiveLayer_AdditiveEmpty_NameId_FullPathHash = -351386880;
	static System.Int32 AdditiveLayer_Fire_NameId = -118708495;
	static System.Int32 AdditiveLayer_Fire_NameId_FullPathHash = 1073268597;
	static System.Int32 AdditiveLayer_Reload_NameId = -1525363869;
	static System.Int32 AdditiveLayer_Reload_NameId_FullPathHash = -1068629770;
	static System.Int32 AdditiveLayer_FireWarm_FireWarm_NameId = -1308370593;
	static System.Int32 AdditiveLayer_FireWarm_FireWarm_NameId_FullPathHash = -31404627;
	static System.Int32 AdditiveLayer_FireWarm_FireWarmLoop_NameId = 504963832;
	static System.Int32 AdditiveLayer_FireWarm_FireWarmLoop_NameId_FullPathHash = -392524382;
	static System.Int32 AdditiveLayer_FireWarm_FireWarmEnd_NameId = -1767754878;
	static System.Int32 AdditiveLayer_FireWarm_FireWarmEnd_NameId_FullPathHash = -1406455209;
	static System.Int32 OverrideLayer_LayerIndex = 4;
	static System.Int32 OverrideLayer_Death_NameId = 646380074;
	static System.Int32 OverrideLayer_Death_NameId_FullPathHash = -1100639876;
	static System.Int32 OverrideLayer_Empty_NameId = -1459219776;
	static System.Int32 OverrideLayer_Empty_NameId_FullPathHash = 837122454;
	static System.Int32 OverrideLayer_Show_NameId = -1841531329;
	static System.Int32 OverrideLayer_Show_NameId_FullPathHash = -1552442243;
	static System.Int32 OverrideLayer_Recourse02_NameId = -1811992661;
	static System.Int32 OverrideLayer_Recourse02_NameId_FullPathHash = -625538263;
	static System.Int32 OverrideLayer_BossAttack01_NameId = -1702288911;
	static System.Int32 OverrideLayer_BossAttack01_NameId_FullPathHash = -1354795359;
	static System.Int32 OverrideLayer_BossAttack02_NameId = 58749003;
	static System.Int32 OverrideLayer_BossAttack02_NameId_FullPathHash = 909518619;
	static System.Int32 OverrideLayer_BossAttack03_NameId = 1955021021;
	static System.Int32 OverrideLayer_BossAttack03_NameId_FullPathHash = 1093736333;
	static System.Int32 OverrideLayer_HeavyAttack_NameId = -1715759148;
	static System.Int32 OverrideLayer_HeavyAttack_NameId_FullPathHash = -1706803716;
	static System.Int32 OverrideLayer_Attack_NameId = 1080829965;
	static System.Int32 OverrideLayer_Attack_NameId_FullPathHash = -1023656025;
	static System.Int32 OverrideLayer_Draw_NameId = -792718799;
	static System.Int32 OverrideLayer_Draw_NameId_FullPathHash = -510920589;
	static System.Int32 OverrideLayer_Recourse01_NameId = 183926289;
	static System.Int32 OverrideLayer_Recourse01_NameId_FullPathHash = 1136548499;
	static System.Int32 OverrideLayer_FarThrow_FarThrowStart_NameId = 1305992225;
	static System.Int32 OverrideLayer_FarThrow_FarThrowStart_NameId_FullPathHash = 890674014;
	static System.Int32 OverrideLayer_FarThrow_FarThrowEnd_NameId = -1330683437;
	static System.Int32 OverrideLayer_FarThrow_FarThrowEnd_NameId_FullPathHash = 850107369;
	static System.Int32 OverrideLayer_FarThrow_FarThrowLoop_NameId = 39014088;
	static System.Int32 OverrideLayer_FarThrow_FarThrowLoop_NameId_FullPathHash = -992111744;
	static System.Int32 OverrideLayer_NearThrow_NearThrowStart_NameId = 395208238;
	static System.Int32 OverrideLayer_NearThrow_NearThrowStart_NameId_FullPathHash = 1767164941;
	static System.Int32 OverrideLayer_NearThrow_NearThrowEnd_NameId = 1725012840;
	static System.Int32 OverrideLayer_NearThrow_NearThrowEnd_NameId_FullPathHash = -618765768;
	static System.Int32 OverrideLayer_NearThrow_NearThrowLoop_NameId = 1580620342;
	static System.Int32 OverrideLayer_NearThrow_NearThrowLoop_NameId_FullPathHash = 903922747;
	static System.Int32 OverrideLayer_Bow_BowReload_NameId = 582945117;
	static System.Int32 OverrideLayer_Bow_BowReload_NameId_FullPathHash = -1593434280;
	static System.Int32 OverrideLayer_Bow_BowSightFire_NameId = -1962732158;
	static System.Int32 OverrideLayer_Bow_BowSightFire_NameId_FullPathHash = 602761493;
	static System.Int32 OverrideLayer_Bow_BowAdsUp_NameId = 1978270725;
	static System.Int32 OverrideLayer_Bow_BowAdsUp_NameId_FullPathHash = 528074258;
	static System.Int32 OverrideLayer_Bow_BowSightHold_NameId = -870903478;
	static System.Int32 OverrideLayer_Bow_BowSightHold_NameId_FullPathHash = 1694068189;
	static System.Int32 AimOffsetLayer_LayerIndex = 5;
	static System.Int32 AimOffsetLayer_EmptyAO_NameId = 1989885882;
	static System.Int32 AimOffsetLayer_EmptyAO_NameId_FullPathHash = -1929306888;
	static System.Int32 AimOffsetLayer_StandAO_NameId = 546766071;
	static System.Int32 AimOffsetLayer_StandAO_NameId_FullPathHash = -619913291;
	static System.Int32 AimOffsetLayer_CrouchAO_NameId = 285337957;
	static System.Int32 AimOffsetLayer_CrouchAO_NameId_FullPathHash = -1993845766;
	static System.Int32[] LocomotionLayer_AllHash; // 0x0
	static System.Int32[] LocomotionLayer_FullPathHash; // 0x8
	static System.Int32[] LocomotionLayerDynamics_AllHash; // 0x10
	static System.Int32[] LocomotionLayerDynamics_FullPathHash; // 0x18
	static System.Int32[] PoseLayer_AllHash; // 0x20
	static System.Int32[] PoseLayer_FullPathHash; // 0x28
	static System.Int32[] AdditiveLayer_AllHash; // 0x30
	static System.Int32[] AdditiveLayer_FullPathHash; // 0x38
	static System.Int32[] OverrideLayer_AllHash; // 0x40
	static System.Int32[] OverrideLayer_FullPathHash; // 0x48
	static System.Int32[] AimOffsetLayer_AllHash; // 0x50
	static System.Int32[] AimOffsetLayer_FullPathHash; // 0x58
	static System.Int32 VehicleType_Id = 2102376444;
	static System.Int32 DirectionLR_Id = 550538378;
	static System.Int32 DirectionFB_Id = -947358620;
	static System.Int32 VelocityF_Id = 1626884625;
	static System.Int32 VelocityR_Id = 2049089132;
	static System.Int32 VelocityB_Id = 1737854472;
	static System.Int32 VelocityL_Id = -2144492785;
	static System.Int32 LerpIdleLocomotion_Id = 1429905597;
	static System.Int32 LerpHipSight_Id = 203278598;
	static System.Int32 LerpCrouchStand_Id = 1235130411;
	static System.Int32 UpDown_Id = -1982187471;
	static System.Int32 WarmupAnimType_Id = -1901761102;
	static System.Int32 WarmupProgress_Id = 1304370533;
	static System.Int32 VelocityRF_Id = 163775685;
	static System.Int32 VelocityRB_Id = 246333660;
	static System.Int32 VelocityLB_Id = -621805821;
	static System.Int32 VelocityLF_Id = -578667750;
	static System.Int32 SightProgress_Id = -1509273285;
	static System.Int32 Blend_Id = 1784438316;
	WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.FloatParams floatParams; // 0x10
	WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.BoolParams boolParams; // 0x64
	WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.IntParams intParams; // 0x68
	System.Void SetFloat(System.Int32 offset, System.Single value); // 0x07514380
	System.Single GetFloat(System.Int32 offset); // 0x07514414
	System.Int32 GetInt(System.Int32 offset); // 0x07514498
	System.Boolean GetBool(System.Int32 offset); // 0x0751451c
	System.Void CopyParams(UnityEngine.OptimizationAnimatorParameterFlushMem& flushMem); // 0x075145a8
	System.Void ApplyToAnimator(UnityEngine.OptimizationAnimatorParameterFlushMem& flushMem); // 0x07514720
	static System.Void .cctor(); // 0x07514898
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.ELocomotionLayer : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.ELocomotionLayer LocomotionEmpty = 0;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.ELocomotionLayer Locomotion_LocomotionSprintF = 1;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.ELocomotionLayer Locomotion_LeisureWalk = 2;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.ELocomotionLayer Locomotion_Locomotion_JogLStand = 3;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.ELocomotionLayer Locomotion_Locomotion_JogRStand = 4;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.ELocomotionLayer Locomotion_Locomotion_JogBStand = 5;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.ELocomotionLayer Locomotion_Locomotion_JogFStand = 6;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.ELocomotionLayer Idle_HipStandIdle = 7;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.ELocomotionLayer Idle_HipCrouchIdle = 8;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.ELocomotionLayer Idle_LeisureIdle = 9;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.ELocomotionLayer Idle_LeisureIdle02 = 10;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.ELocomotionLayer Idle_LeisureIdle03 = 11;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.ELocomotionLayer Idle_LeisureIdle04 = 12;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.ELocomotionLayer Sum = 13;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EAdditiveLayer : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EAdditiveLayer AdditiveEmpty = 0;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EAdditiveLayer Fire = 1;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EAdditiveLayer Reload = 2;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EAdditiveLayer FireWarm_FireWarm = 3;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EAdditiveLayer FireWarm_FireWarmLoop = 4;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EAdditiveLayer FireWarm_FireWarmEnd = 5;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EAdditiveLayer Sum = 6;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EOverrideLayer : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EOverrideLayer Death = 0;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EOverrideLayer Empty = 1;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EOverrideLayer Show = 2;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EOverrideLayer Recourse02 = 3;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EOverrideLayer BossAttack01 = 4;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EOverrideLayer BossAttack02 = 5;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EOverrideLayer BossAttack03 = 6;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EOverrideLayer HeavyAttack = 7;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EOverrideLayer Attack = 8;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EOverrideLayer Draw = 9;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EOverrideLayer Recourse01 = 10;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EOverrideLayer FarThrow_FarThrowStart = 11;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EOverrideLayer FarThrow_FarThrowEnd = 12;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EOverrideLayer FarThrow_FarThrowLoop = 13;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EOverrideLayer NearThrow_NearThrowStart = 14;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EOverrideLayer NearThrow_NearThrowEnd = 15;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EOverrideLayer NearThrow_NearThrowLoop = 16;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EOverrideLayer Bow_BowReload = 17;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EOverrideLayer Bow_BowSightFire = 18;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EOverrideLayer Bow_BowAdsUp = 19;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EOverrideLayer Bow_BowSightHold = 20;
	static WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.EOverrideLayer Sum = 21;
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.FloatParams : System.ValueType
{
	System.Single VehicleType; // 0x10
	System.Single DirectionLR; // 0x14
	System.Single DirectionFB; // 0x18
	System.Single VelocityF; // 0x1c
	System.Single VelocityR; // 0x20
	System.Single VelocityB; // 0x24
	System.Single VelocityL; // 0x28
	System.Single LerpIdleLocomotion; // 0x2c
	System.Single LerpHipSight; // 0x30
	System.Single LerpCrouchStand; // 0x34
	System.Single UpDown; // 0x38
	System.Single LeftIKAutoCurve; // 0x3c
	System.Single RightIKAutoCurve; // 0x40
	System.Single HorseSpeacial_WeightCurve; // 0x44
	System.Single WarmupProgress; // 0x48
	System.Single VelocityRF; // 0x4c
	System.Single VelocityRB; // 0x50
	System.Single VelocityLB; // 0x54
	System.Single VelocityLF; // 0x58
	System.Single SightProgress; // 0x5c
	System.Single Blend; // 0x60
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.BoolParams : System.ValueType
{
	
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersScientist.IntParams : System.ValueType
{
	System.Int32 WarmupAnimType; // 0x10
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersScientist_Extra : System.ValueType
{
	static System.Collections.Generic.Dictionary<System.String,System.Int32> floatOffsetMap; // 0x0
	static System.Collections.Generic.Dictionary<System.String,System.Int32> boolOffsetMap; // 0x8
	static System.Collections.Generic.Dictionary<System.String,System.Int32> intOffsetMap; // 0x10
	static System.Collections.Generic.Dictionary<System.Int32,System.String[]> AllClipCache; // 0x18
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32> StateSpeedPairs; // 0x20
	static System.Void .cctor(); // 0x07514bfc
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse : System.ValueType, WizardGames.Soc.Common.Unity.Character.IAnimatorApply
{
	static System.Int32[] Base_Layer_AllHash; // 0x0
	static System.Int32[] Base_Layer_FullPathHash; // 0x8
	WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse.FloatParams floatParams; // 0x10
	WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse.BoolParams boolParams; // 0x20
	WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse.IntParams intParams; // 0x21
	System.Void SetFloat(System.Int32 offset, System.Single value); // 0x07516984
	System.Single GetFloat(System.Int32 offset); // 0x07516a18
	System.Int32 GetInt(System.Int32 offset); // 0x07516a9c
	System.Boolean GetBool(System.Int32 offset); // 0x07516b14
	System.Void CopyParams(UnityEngine.OptimizationAnimatorParameterFlushMem& flushMem); // 0x07516ba0
	System.Void ApplyToAnimator(UnityEngine.OptimizationAnimatorParameterFlushMem& flushMem); // 0x07516cd0
	static System.Void .cctor(); // 0x07516e00
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse.FloatParams : System.ValueType
{
	System.Single RotateSpeed; // 0x10
	System.Single MoveSpeed; // 0x14
	System.Single SpeedMultiplier; // 0x18
	System.Single HitIndex; // 0x1c
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse.BoolParams : System.ValueType
{
	
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersSocHorse.IntParams : System.ValueType
{
	
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersSocParachute : System.ValueType, WizardGames.Soc.Common.Unity.Character.IAnimatorApply
{
	static System.Int32[] Base_Layer_AllHash; // 0x0
	static System.Int32[] Base_Layer_FullPathHash; // 0x8
	static System.Int32[] Additive_Layer_AllHash; // 0x10
	static System.Int32[] Additive_Layer_FullPathHash; // 0x18
	WizardGames.Soc.Common.Unity.Character.AnimParametersSocParachute.FloatParams floatParams; // 0x10
	WizardGames.Soc.Common.Unity.Character.AnimParametersSocParachute.BoolParams boolParams; // 0x18
	WizardGames.Soc.Common.Unity.Character.AnimParametersSocParachute.IntParams intParams; // 0x19
	System.Void SetFloat(System.Int32 offset, System.Single value); // 0x07516ee4
	System.Single GetFloat(System.Int32 offset); // 0x07516f78
	System.Int32 GetInt(System.Int32 offset); // 0x07516ffc
	System.Boolean GetBool(System.Int32 offset); // 0x07517074
	System.Void CopyParams(UnityEngine.OptimizationAnimatorParameterFlushMem& flushMem); // 0x07517100
	System.Void ApplyToAnimator(UnityEngine.OptimizationAnimatorParameterFlushMem& flushMem); // 0x07517230
	static System.Void .cctor(); // 0x07517360
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersSocParachute.FloatParams : System.ValueType
{
	System.Single MoveSpeed; // 0x10
	System.Single RotateSpeed; // 0x14
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersSocParachute.BoolParams : System.ValueType
{
	
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersSocParachute.IntParams : System.ValueType
{
	
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Character.AnimParametersTp : System.ValueType, WizardGames.Soc.Common.Unity.Character.IAnimatorApply
{
	static System.Int32 LocomotionLayer_LayerIndex = 0;
	static System.Int32 LocomotionLayer_LocomotionEmpty_NameId = -1844923080;
	static System.Int32 LocomotionLayer_LocomotionEmpty_NameId_FullPathHash = 692042140;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_SprintF_NameId = 512446665;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_SprintF_NameId_FullPathHash = -879683665;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_JogFStand_NameId = -2089013862;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_JogFStand_NameId_FullPathHash = 1482940562;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_JogLStand_NameId = 585567996;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_JogLStand_NameId_FullPathHash = -101137420;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_JogRStand_NameId = 456879383;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_JogRStand_NameId_FullPathHash = -1071341537;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_JogBStand_NameId = 418213772;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_JogBStand_NameId_FullPathHash = -1007508860;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_JogFLStand_NameId = -1617885189;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_JogFLStand_NameId_FullPathHash = -1852731388;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_JogFRStand_NameId = -1504877552;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_JogFRStand_NameId_FullPathHash = -1471286289;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_JogBLStand_NameId = 1809720296;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_JogBLStand_NameId_FullPathHash = 1709093911;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_JogBRStand_NameId = 1375879171;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_JogBRStand_NameId_FullPathHash = 1543690236;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_WalkFStand_NameId = -677858979;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_WalkFStand_NameId_FullPathHash = -644340062;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_WalkFRStand_NameId = -1558587489;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_WalkFRStand_NameId_FullPathHash = -1911211899;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_WalkRStand_NameId = 1340076496;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_WalkRStand_NameId_FullPathHash = 1105159727;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_WalkBRStand_NameId = 1465316236;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_WalkBRStand_NameId_FullPathHash = 2052725910;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_WalkBLStand_NameId = 1854574695;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_WalkBLStand_NameId_FullPathHash = 1132887933;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_WalkBStand_NameId = 1275720523;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_WalkBStand_NameId_FullPathHash = 1107911860;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_WalkLStand_NameId = 1979945531;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_WalkLStand_NameId_FullPathHash = 2013464004;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_WalkFLStand_NameId = -1698319244;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_WalkFLStand_NameId_FullPathHash = -1211540626;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_CrouchFStand_NameId = 1157264751;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_CrouchFStand_NameId_FullPathHash = -1179287302;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_CrouchFRStand_NameId = 1801315547;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_CrouchFRStand_NameId_FullPathHash = -339358491;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_CrouchRStand_NameId = -591579678;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_CrouchRStand_NameId_FullPathHash = 569557111;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_CrouchBRStand_NameId = -1626160952;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_CrouchBRStand_NameId_FullPathHash = 529197302;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_CrouchBLStand_NameId = -1496407261;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_CrouchBLStand_NameId_FullPathHash = 643205917;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_CrouchBStand_NameId = -546621575;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_CrouchBStand_NameId_FullPathHash = 572834540;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_CrouchLStand_NameId = -446605815;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_CrouchLStand_NameId_FullPathHash = 405709724;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_CrouchFLStand_NameId = 1384220464;
	static System.Int32 LocomotionLayer_HipLocomotion_Locomotion_CrouchFLStand_NameId_FullPathHash = -770068722;
	static System.Int32 LocomotionLayer_Jump_JumpStart_NameId = 819769265;
	static System.Int32 LocomotionLayer_Jump_JumpStart_NameId_FullPathHash = 373001190;
	static System.Int32 LocomotionLayer_Jump_JumpEnd_NameId = -342501864;
	static System.Int32 LocomotionLayer_Jump_JumpEnd_NameId_FullPathHash = -1860616705;
	static System.Int32 LocomotionLayer_Jump_JumpLoop_NameId = 247361351;
	static System.Int32 LocomotionLayer_Jump_JumpLoop_NameId_FullPathHash = 816485495;
	static System.Int32 LocomotionLayer_HipStance_HipStandIdle_NameId = -579799716;
	static System.Int32 LocomotionLayer_HipStance_HipStandIdle_NameId_FullPathHash = -1225795367;
	static System.Int32 LocomotionLayer_HipStance_HipCrouchIdle_NameId = -988766710;
	static System.Int32 LocomotionLayer_HipStance_HipCrouchIdle_NameId_FullPathHash = 1487500936;
	static System.Int32 LocomotionLayer_HipStance_Stand2Crouch_NameId = -1995827411;
	static System.Int32 LocomotionLayer_HipStance_Stand2Crouch_NameId_FullPathHash = -493536600;
	static System.Int32 LocomotionLayer_HipStance_Crouch2Stand_NameId = -865381655;
	static System.Int32 LocomotionLayer_HipStance_Crouch2Stand_NameId_FullPathHash = -1477148820;
	static System.Int32 LocomotionLayer_HipStance_Stand2CrouchReady_NameId = -98727700;
	static System.Int32 LocomotionLayer_HipStance_Stand2CrouchReady_NameId_FullPathHash = -1593471668;
	static System.Int32 LocomotionLayer_HipStance_Crouch2StandReady_NameId = -1906740049;
	static System.Int32 LocomotionLayer_HipStance_Crouch2StandReady_NameId_FullPathHash = -717131505;
	static System.Int32 LocomotionLayer_HipStance_TurnInPlaceLStand_NameId = 595571626;
	static System.Int32 LocomotionLayer_HipStance_TurnInPlaceLStand_NameId_FullPathHash = 2020062730;
	static System.Int32 LocomotionLayer_HipStance_TurnInPlaceRStand_NameId = 446943297;
	static System.Int32 LocomotionLayer_HipStance_TurnInPlaceRStand_NameId_FullPathHash = 1102829025;
	static System.Int32 LocomotionLayer_HipStance_TurnInPlaceLCrouch_NameId = -1808766468;
	static System.Int32 LocomotionLayer_HipStance_TurnInPlaceLCrouch_NameId_FullPathHash = 1119736337;
	static System.Int32 LocomotionLayer_HipStance_TurnInPlaceRCrouch_NameId = -1546547601;
	static System.Int32 LocomotionLayer_HipStance_TurnInPlaceRCrouch_NameId_FullPathHash = 1968977282;
	static System.Int32 LocomotionLayer_Swim_SwimIdle_NameId = -2075136592;
	static System.Int32 LocomotionLayer_Swim_SwimIdle_NameId_FullPathHash = 125525495;
	static System.Int32 LocomotionLayer_Swim_Swim_SprintF_NameId = -1585976720;
	static System.Int32 LocomotionLayer_Swim_Swim_SprintF_NameId_FullPathHash = -1385081463;
	static System.Int32 LocomotionLayer_Swim_SwimF_NameId = 1200872387;
	static System.Int32 LocomotionLayer_Swim_SwimF_NameId_FullPathHash = -494001956;
	static System.Int32 LocomotionLayer_Swim_SwimFR_NameId = 1431166852;
	static System.Int32 LocomotionLayer_Swim_SwimFR_NameId_FullPathHash = -656355446;
	static System.Int32 LocomotionLayer_Swim_SwimR_NameId = 1565069246;
	static System.Int32 LocomotionLayer_Swim_SwimR_NameId_FullPathHash = -128650079;
	static System.Int32 LocomotionLayer_Swim_SwimBR_NameId = 824253056;
	static System.Int32 LocomotionLayer_Swim_SwimBR_NameId_FullPathHash = -1131672946;
	static System.Int32 LocomotionLayer_Swim_SwimBL_NameId = -886167581;
	static System.Int32 LocomotionLayer_Swim_SwimBL_NameId_FullPathHash = 1183004653;
	static System.Int32 LocomotionLayer_Swim_SwimB_NameId = 1090396122;
	static System.Int32 LocomotionLayer_Swim_SwimB_NameId_FullPathHash = -438049595;
	static System.Int32 LocomotionLayer_Swim_SwimL_NameId = -1488571683;
	static System.Int32 LocomotionLayer_Swim_SwimL_NameId_FullPathHash = 39569858;
	static System.Int32 LocomotionLayer_Swim_SwimFL_NameId = -1354571033;
	static System.Int32 LocomotionLayer_Swim_SwimFL_NameId_FullPathHash = 586150633;
	static System.Int32 LocomotionLayer_RiderLocomotion_RiderLocomotionNode_NameId = -1772057104;
	static System.Int32 LocomotionLayer_RiderLocomotion_RiderLocomotionNode_NameId_FullPathHash = -1094899278;
	static System.Int32 LocomotionLayer_RiderJump_Neigh_NameId = 63632033;
	static System.Int32 LocomotionLayer_RiderJump_Neigh_NameId_FullPathHash = -589201629;
	static System.Int32 LocomotionLayer_RiderJump_JumpForward_JumpForwardStart_NameId = -1808020744;
	static System.Int32 LocomotionLayer_RiderJump_JumpForward_JumpForwardStart_NameId_FullPathHash = -1573041958;
	static System.Int32 LocomotionLayer_RiderJump_JumpForward_JumpForwardLoop_NameId = 941574945;
	static System.Int32 LocomotionLayer_RiderJump_JumpForward_JumpForwardLoop_NameId_FullPathHash = 1037541259;
	static System.Int32 LocomotionLayer_RiderJump_JumpForward_JumpForwardEnd_NameId = 1241204402;
	static System.Int32 LocomotionLayer_RiderJump_JumpForward_JumpForwardEnd_NameId_FullPathHash = -2122776715;
	static System.Int32 LocomotionLayer_RiderJump_JumpCanter_JumpCanterStart_NameId = -1280019310;
	static System.Int32 LocomotionLayer_RiderJump_JumpCanter_JumpCanterStart_NameId_FullPathHash = -1049829031;
	static System.Int32 LocomotionLayer_RiderJump_JumpCanter_JumpCanterLoop_NameId = -1243575472;
	static System.Int32 LocomotionLayer_RiderJump_JumpCanter_JumpCanterLoop_NameId_FullPathHash = 1779615126;
	static System.Int32 LocomotionLayer_RiderJump_JumpCanter_JumpCanterEnd_NameId = -1103707475;
	static System.Int32 LocomotionLayer_RiderJump_JumpCanter_JumpCanterEnd_NameId_FullPathHash = 748144385;
	static System.Int32 LocomotionLayer_RiderJump_JumpGallop_JumpGallopStart_NameId = 1803418445;
	static System.Int32 LocomotionLayer_RiderJump_JumpGallop_JumpGallopStart_NameId_FullPathHash = 1402009805;
	static System.Int32 LocomotionLayer_RiderJump_JumpGallop_JumpGallopLoop_NameId = 1900318456;
	static System.Int32 LocomotionLayer_RiderJump_JumpGallop_JumpGallopLoop_NameId_FullPathHash = 1149618778;
	static System.Int32 LocomotionLayer_RiderJump_JumpGallop_JumpGallopEnd_NameId = 2071581268;
	static System.Int32 LocomotionLayer_RiderJump_JumpGallop_JumpGallopEnd_NameId_FullPathHash = 261458556;
	static System.Int32 LocomotionLayer_RiderJump_JumpSprint_JumpSprintStart_NameId = -1405454089;
	static System.Int32 LocomotionLayer_RiderJump_JumpSprint_JumpSprintStart_NameId_FullPathHash = -296628334;
	static System.Int32 LocomotionLayer_RiderJump_JumpSprint_JumpSprintLoop_NameId = -512786301;
	static System.Int32 LocomotionLayer_RiderJump_JumpSprint_JumpSprintLoop_NameId_FullPathHash = 943753642;
	static System.Int32 LocomotionLayer_RiderJump_JumpSprint_JumpSprintEnd_NameId = -278251429;
	static System.Int32 LocomotionLayer_RiderJump_JumpSprint_JumpSprintEnd_NameId_FullPathHash = 372886962;
	static System.Int32 LocomotionLayer_Mantle_MantleOnNear_NameId = 1474188419;
	static System.Int32 LocomotionLayer_Mantle_MantleOnNear_NameId_FullPathHash = -56230365;
	static System.Int32 LocomotionLayer_Mantle_MantleOnFar_NameId = 1464468290;
	static System.Int32 LocomotionLayer_Mantle_MantleOnFar_NameId_FullPathHash = -35784083;
	static System.Int32 LocomotionLayer_Ladder_UpEnter_NameId = 1496321240;
	static System.Int32 LocomotionLayer_Ladder_UpEnter_NameId_FullPathHash = 1606127133;
	static System.Int32 LocomotionLayer_Ladder_UpLeave_NameId = 2079345766;
	static System.Int32 LocomotionLayer_Ladder_UpLeave_NameId_FullPathHash = 2105265827;
	static System.Int32 LocomotionLayer_Ladder_DownEnter_NameId = -920753078;
	static System.Int32 LocomotionLayer_Ladder_DownEnter_NameId_FullPathHash = 2082843590;
	static System.Int32 LocomotionLayer_Ladder_DownLeave_NameId = -337761036;
	static System.Int32 LocomotionLayer_Ladder_DownLeave_NameId_FullPathHash = 1592126328;
	static System.Int32 LocomotionLayer_Ladder_LadderProcedureWait_NameId = -942165679;
	static System.Int32 LocomotionLayer_Ladder_LadderProcedureWait_NameId_FullPathHash = 1302468979;
	static System.Int32 LocomotionLayer_Ladder_LadderProcedureCrouchWait_NameId = 1954460954;
	static System.Int32 LocomotionLayer_Ladder_LadderProcedureCrouchWait_NameId_FullPathHash = -837940344;
	static System.Int32 LocomotionLayer_Ladder_LadderF_NameId = -919381169;
	static System.Int32 LocomotionLayer_Ladder_LadderF_NameId_FullPathHash = -809969270;
	static System.Int32 LocomotionLayer_Ladder_LadderFR_NameId = -1311920113;
	static System.Int32 LocomotionLayer_Ladder_LadderFR_NameId_FullPathHash = 1522863538;
	static System.Int32 LocomotionLayer_Ladder_LadderR_NameId = -739668174;
	static System.Int32 LocomotionLayer_Ladder_LadderR_NameId_FullPathHash = -714994185;
	static System.Int32 LocomotionLayer_Ladder_LadderBR_NameId = -710839029;
	static System.Int32 LocomotionLayer_Ladder_LadderBR_NameId_FullPathHash = 1051314358;
	static System.Int32 LocomotionLayer_Ladder_LadderBL_NameId = 799950952;
	static System.Int32 LocomotionLayer_Ladder_LadderBL_NameId_FullPathHash = -995691051;
	static System.Int32 LocomotionLayer_Ladder_LadderB_NameId = -832659626;
	static System.Int32 LocomotionLayer_Ladder_LadderB_NameId_FullPathHash = -925557357;
	static System.Int32 LocomotionLayer_Ladder_LadderL_NameId = 702984785;
	static System.Int32 LocomotionLayer_Ladder_LadderL_NameId_FullPathHash = 795685012;
	static System.Int32 LocomotionLayer_Ladder_LadderFL_NameId = 1271041388;
	static System.Int32 LocomotionLayer_Ladder_LadderFL_NameId_FullPathHash = -1597361967;
	static System.Int32 LocomotionLayer_Ladder_LadderIdle_NameId = -2127219591;
	static System.Int32 LocomotionLayer_Ladder_LadderIdle_NameId_FullPathHash = 1703854261;
	static System.Int32 LocomotionLayer_Parachute_ParachuteIdle_NameId = 1776377558;
	static System.Int32 LocomotionLayer_Parachute_ParachuteIdle_NameId_FullPathHash = -2137376063;
	static System.Int32 LocomotionLayer_Parachute_Start_NameId = 1589148299;
	static System.Int32 LocomotionLayer_Parachute_Start_NameId_FullPathHash = 2137672537;
	static System.Int32 LocomotionLayer_Parachute_Cut_NameId = -2000825827;
	static System.Int32 LocomotionLayer_Parachute_Cut_NameId_FullPathHash = 1273048263;
	static System.Int32 LocomotionLayer_Injured_ToInjured_NameId = -1454222948;
	static System.Int32 LocomotionLayer_Injured_ToInjured_NameId_FullPathHash = -261668440;
	static System.Int32 LocomotionLayer_Injured_InjuredIdle_NameId = 914324954;
	static System.Int32 LocomotionLayer_Injured_InjuredIdle_NameId_FullPathHash = -1864185988;
	static System.Int32 LocomotionLayer_Injured_InjuredF_NameId = 18897230;
	static System.Int32 LocomotionLayer_Injured_InjuredF_NameId_FullPathHash = -2029159886;
	static System.Int32 LocomotionLayer_Injured_InjuredFR_NameId = -972909669;
	static System.Int32 LocomotionLayer_Injured_InjuredFR_NameId_FullPathHash = -1623751761;
	static System.Int32 LocomotionLayer_Injured_InjuredR_NameId = 469404979;
	static System.Int32 LocomotionLayer_Injured_InjuredR_NameId_FullPathHash = -1646809521;
	static System.Int32 LocomotionLayer_Injured_InjuredBR_NameId = -1569827169;
	static System.Int32 LocomotionLayer_Injured_InjuredBR_NameId_FullPathHash = -77904213;
	static System.Int32 LocomotionLayer_Injured_InjuredBL_NameId = 1482779644;
	static System.Int32 LocomotionLayer_Injured_InjuredBL_NameId_FullPathHash = 22313928;
	static System.Int32 LocomotionLayer_Injured_InjuredB_NameId = 105749847;
	static System.Int32 LocomotionLayer_Injured_InjuredB_NameId_FullPathHash = -2141143509;
	static System.Int32 LocomotionLayer_Injured_InjuredL_NameId = -503992240;
	static System.Int32 LocomotionLayer_Injured_InjuredL_NameId_FullPathHash = 1742246700;
	static System.Int32 LocomotionLayer_Injured_InjuredFL_NameId = 1007529720;
	static System.Int32 LocomotionLayer_Injured_InjuredFL_NameId_FullPathHash = 1698217676;
	static System.Int32 LocomotionLayer_Drive_Idle_NameId = 2081823275;
	static System.Int32 LocomotionLayer_Drive_Idle_NameId_FullPathHash = -817908459;
	static System.Int32 LocomotionLayer_Drive_ModularDriveL_NameId = -453625544;
	static System.Int32 LocomotionLayer_Drive_ModularDriveL_NameId_FullPathHash = -1223439668;
	static System.Int32 LocomotionLayer_Drive_ModularDriveR_NameId = 519636059;
	static System.Int32 LocomotionLayer_Drive_ModularDriveR_NameId_FullPathHash = 1293744047;
	static System.Int32 LocomotionLayer_Drive_KayakDrive_NameId = 1574641187;
	static System.Int32 LocomotionLayer_Drive_KayakDrive_NameId_FullPathHash = -1946234812;
	static System.Int32 LocomotionLayer_Drive_KayakRaise_NameId = -1918865355;
	static System.Int32 LocomotionLayer_Drive_KayakRaise_NameId_FullPathHash = 1535491666;
	static System.Int32 LocomotionLayer_InCap_ToLieDown_NameId = -1602752648;
	static System.Int32 LocomotionLayer_InCap_ToLieDown_NameId_FullPathHash = -850133316;
	static System.Int32 LocomotionLayer_InCap_LieDownLoop_NameId = 1291237399;
	static System.Int32 LocomotionLayer_InCap_LieDownLoop_NameId_FullPathHash = -1982797941;
	static System.Int32 LocomotionLayer_Zipline_ZiplineStandIn_NameId = -881369104;
	static System.Int32 LocomotionLayer_Zipline_ZiplineStandIn_NameId_FullPathHash = -851791577;
	static System.Int32 LocomotionLayer_Zipline_ZiplineStandOut_NameId = -1784190781;
	static System.Int32 LocomotionLayer_Zipline_ZiplineStandOut_NameId_FullPathHash = -1927912870;
	static System.Int32 LocomotionLayer_Zipline_ZiplineSwitch_NameId = -1995702536;
	static System.Int32 LocomotionLayer_Zipline_ZiplineSwitch_NameId_FullPathHash = 1917859517;
	static System.Int32 LocomotionLayer_Zipline_ZiplineSlow_NameId = 1659958025;
	static System.Int32 LocomotionLayer_Zipline_ZiplineSlow_NameId_FullPathHash = -2092018731;
	static System.Int32 LocomotionLayer_Zipline_ZiplineFast_NameId = 1922157328;
	static System.Int32 LocomotionLayer_Zipline_ZiplineFast_NameId_FullPathHash = -1825608756;
	static System.Int32 LocomotionLayerDynamics_LayerIndex = 1;
	static System.Int32 PoseLayer_LayerIndex = 2;
	static System.Int32 PoseLayer_Pose_NameId = -1878465727;
	static System.Int32 PoseLayer_Pose_NameId_FullPathHash = -2126754163;
	static System.Int32 PoseLayer_SwimPose_NameId = 1750144218;
	static System.Int32 PoseLayer_SwimPose_NameId_FullPathHash = 1425037394;
	static System.Int32 PoseLayer_VehiclePose_NameId = -1045713750;
	static System.Int32 PoseLayer_VehiclePose_NameId_FullPathHash = -745507367;
	static System.Int32 PoseLayer_VehicleBackPose_NameId = 292280529;
	static System.Int32 PoseLayer_VehicleBackPose_NameId_FullPathHash = 632440684;
	static System.Int32 PoseLayer_ParachutePose_NameId = -2046842948;
	static System.Int32 PoseLayer_ParachutePose_NameId_FullPathHash = 2128803266;
	static System.Int32 AdditiveLayer_LayerIndex = 3;
	static System.Int32 AdditiveLayer_AdditiveEmpty_NameId = 1401562295;
	static System.Int32 AdditiveLayer_AdditiveEmpty_NameId_FullPathHash = -351386880;
	static System.Int32 AdditiveLayer_Fire_NameId = -118708495;
	static System.Int32 AdditiveLayer_Fire_NameId_FullPathHash = 1073268597;
	static System.Int32 AdditiveLayer_Bolt_NameId = -839757255;
	static System.Int32 AdditiveLayer_Bolt_NameId_FullPathHash = 182858685;
	static System.Int32 AdditiveLayer_TryFire_NameId = 561399107;
	static System.Int32 AdditiveLayer_TryFire_NameId_FullPathHash = -1586071485;
	static System.Int32 AdditiveLayer_Reload_ReloadFirst_NameId = -466491703;
	static System.Int32 AdditiveLayer_Reload_ReloadFirst_NameId_FullPathHash = -1771575805;
	static System.Int32 AdditiveLayer_Reload_ReloadEmpty_NameId = 512177498;
	static System.Int32 AdditiveLayer_Reload_ReloadEmpty_NameId_FullPathHash = 1825650064;
	static System.Int32 AdditiveLayer_Reload_ReloadEnd_NameId = 1089788533;
	static System.Int32 AdditiveLayer_Reload_ReloadEnd_NameId_FullPathHash = -105175484;
	static System.Int32 AdditiveLayer_Reload_ReloadLoop_NameId = 1024857006;
	static System.Int32 AdditiveLayer_Reload_ReloadLoop_NameId_FullPathHash = 1819368552;
	static System.Int32 AdditiveLayer_FireWarm_FireWarm_NameId = -1308370593;
	static System.Int32 AdditiveLayer_FireWarm_FireWarm_NameId_FullPathHash = -31404627;
	static System.Int32 AdditiveLayer_FireWarm_FireWarmLoop_NameId = 504963832;
	static System.Int32 AdditiveLayer_FireWarm_FireWarmLoop_NameId_FullPathHash = -392524382;
	static System.Int32 AdditiveLayer_FireWarm_FireWarmEnd_NameId = -1767754878;
	static System.Int32 AdditiveLayer_FireWarm_FireWarmEnd_NameId_FullPathHash = -1406455209;
	static System.Int32 OverrideLayer_LayerIndex = 4;
	static System.Int32 OverrideLayer_OverrideEmpty_NameId = -724301098;
	static System.Int32 OverrideLayer_OverrideEmpty_NameId_FullPathHash = -1081414283;
	static System.Int32 OverrideLayer_Ladder_NameId = 806467859;
	static System.Int32 OverrideLayer_Ladder_NameId_FullPathHash = -1300123975;
	static System.Int32 OverrideLayer_Bolt_NameId = -839757255;
	static System.Int32 OverrideLayer_Bolt_NameId_FullPathHash = -54937477;
	static System.Int32 OverrideLayer_Sleep_WakeUp_NameId = 837379829;
	static System.Int32 OverrideLayer_Sleep_WakeUp_NameId_FullPathHash = -846527772;
	static System.Int32 OverrideLayer_Sleep_Sleep_NameId = -822940248;
	static System.Int32 OverrideLayer_Sleep_Sleep_NameId_FullPathHash = 354320627;
	static System.Int32 OverrideLayer_Sleep_GoSleep_NameId = -307088461;
	static System.Int32 OverrideLayer_Sleep_GoSleep_NameId_FullPathHash = -2013368027;
	static System.Int32 OverrideLayer_Throw_ThrowStart_NameId = -1443334154;
	static System.Int32 OverrideLayer_Throw_ThrowStart_NameId_FullPathHash = -679602191;
	static System.Int32 OverrideLayer_Throw_ThrowNearLoop_NameId = 2138286657;
	static System.Int32 OverrideLayer_Throw_ThrowNearLoop_NameId_FullPathHash = 454750472;
	static System.Int32 OverrideLayer_Throw_ThrowFarLoop_NameId = 1040454119;
	static System.Int32 OverrideLayer_Throw_ThrowFarLoop_NameId_FullPathHash = 1022859518;
	static System.Int32 OverrideLayer_Throw_ThrowNearEnd_NameId = -1747625636;
	static System.Int32 OverrideLayer_Throw_ThrowNearEnd_NameId_FullPathHash = -1792618427;
	static System.Int32 OverrideLayer_Throw_ThrowFarEnd_NameId = -468410377;
	static System.Int32 OverrideLayer_Throw_ThrowFarEnd_NameId_FullPathHash = 2047773748;
	static System.Int32 OverrideLayer_InteractionFullBody_Perform_NameId = 375273948;
	static System.Int32 OverrideLayer_InteractionFullBody_Perform_NameId_FullPathHash = -570489341;
	static System.Int32 OverrideLayer_InteractionFullBody_Knock_NameId = -440200484;
	static System.Int32 OverrideLayer_InteractionFullBody_Knock_NameId_FullPathHash = -738455645;
	static System.Int32 OverrideLayer_InteractionHalfBody_Gesture_NameId = 1815970732;
	static System.Int32 OverrideLayer_InteractionHalfBody_Gesture_NameId_FullPathHash = 1935660754;
	static System.Int32 OverrideLayer_InteractionHalfBody_AidOther_NameId = -739920807;
	static System.Int32 OverrideLayer_InteractionHalfBody_AidOther_NameId_FullPathHash = 1682410039;
	static System.Int32 OverrideLayer_InteractionHalfBody_Inspection_NameId = -1230227627;
	static System.Int32 OverrideLayer_InteractionHalfBody_Inspection_NameId_FullPathHash = -1934369931;
	static System.Int32 OverrideLayer_InteractionHalfBody_Card_NameId = -1239009299;
	static System.Int32 OverrideLayer_InteractionHalfBody_Card_NameId_FullPathHash = 1756099773;
	static System.Int32 OverrideLayer_InteractionHalfBody_UseForOther_NameId = 1673104495;
	static System.Int32 OverrideLayer_InteractionHalfBody_UseForOther_NameId_FullPathHash = 1491972939;
	static System.Int32 OverrideLayer_InteractionHalfBody_Use_NameId = -1392735573;
	static System.Int32 OverrideLayer_InteractionHalfBody_Use_NameId_FullPathHash = -1700716730;
	static System.Int32 OverrideLayer_InteractionHalfBody_Drink_NameId = -864063531;
	static System.Int32 OverrideLayer_InteractionHalfBody_Drink_NameId_FullPathHash = -1479887902;
	static System.Int32 OverrideLayer_InteractionHalfBody_Pour_NameId = 1166131456;
	static System.Int32 OverrideLayer_InteractionHalfBody_Pour_NameId_FullPathHash = -1693711792;
	static System.Int32 OverrideLayer_InteractionHalfBody_OpenDoor_NameId = 207596745;
	static System.Int32 OverrideLayer_InteractionHalfBody_OpenDoor_NameId_FullPathHash = -1141009753;
	static System.Int32 OverrideLayer_InteractionHalfBody_PickUp_NameId = -743040919;
	static System.Int32 OverrideLayer_InteractionHalfBody_PickUp_NameId_FullPathHash = 1801455802;
	static System.Int32 OverrideLayer_InteractionHalfBody_UseForOtherHit_NameId = 77541552;
	static System.Int32 OverrideLayer_InteractionHalfBody_UseForOtherHit_NameId_FullPathHash = 251879782;
	static System.Int32 OverrideLayer_InteractionHalfBody_ItemUse_Start_NameId = 1589148299;
	static System.Int32 OverrideLayer_InteractionHalfBody_ItemUse_Start_NameId_FullPathHash = 916209127;
	static System.Int32 OverrideLayer_InteractionHalfBody_ItemUse_Loop_NameId = 23966416;
	static System.Int32 OverrideLayer_InteractionHalfBody_ItemUse_Loop_NameId_FullPathHash = -124180990;
	static System.Int32 OverrideLayer_InteractionHalfBody_ItemUse_End_NameId = 951154001;
	static System.Int32 OverrideLayer_InteractionHalfBody_ItemUse_End_NameId_FullPathHash = 1979369677;
	static System.Int32 OverrideLayer_Attack_Attack_L_NameId = -2087991292;
	static System.Int32 OverrideLayer_Attack_Attack_L_NameId_FullPathHash = 1766136596;
	static System.Int32 OverrideLayer_Attack_Attack_C_NameId = 322229653;
	static System.Int32 OverrideLayer_Attack_Attack_C_NameId_FullPathHash = -101054843;
	static System.Int32 OverrideLayer_Attack_Attack_R_NameId = 2038756711;
	static System.Int32 OverrideLayer_Attack_Attack_R_NameId_FullPathHash = -1823857033;
	static System.Int32 OverrideLayer_Attack_Attack_L2_NameId = 490467804;
	static System.Int32 OverrideLayer_Attack_Attack_L2_NameId_FullPathHash = 6696811;
	static System.Int32 OverrideLayer_Attack_Attack_R2_NameId = -914698749;
	static System.Int32 OverrideLayer_Attack_Attack_R2_NameId_FullPathHash = -735637324;
	static System.Int32 OverrideLayer_Attack_Attack_U_NameId = -404725564;
	static System.Int32 OverrideLayer_Attack_Attack_U_NameId_FullPathHash = 221164500;
	static System.Int32 OverrideLayer_Draw_DrawL_NameId = -60415458;
	static System.Int32 OverrideLayer_Draw_DrawL_NameId_FullPathHash = -777322568;
	static System.Int32 OverrideLayer_Draw_DrawR_NameId = 107552637;
	static System.Int32 OverrideLayer_Draw_DrawR_NameId_FullPathHash = 732283611;
	static System.Int32 OverrideLayer_Draw_QuickDrawR_NameId = -655689333;
	static System.Int32 OverrideLayer_Draw_QuickDrawR_NameId_FullPathHash = 1261225778;
	static System.Int32 OverrideLayer_SustainAttack_FireStart_NameId = 1064372174;
