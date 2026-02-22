class WizardGames.Soc.SocClient.GoLoader.Proxy.ProxyMgr : System.Object
{
	static WizardGames.Soc.SocClient.GoLoader.Proxy.ProxyMgr Instance; // 0x0
	static System.Void .cctor(); // 0x0690cf50
	System.Int32 GetProxyLv(System.UInt64 handleId); // 0x068ff128
	System.Void .ctor(); // 0x0690cfb4
}

// Client.Runtime
class WizardGames.Soc.SocClient.GoLoader.Proxy.Proxy_Base : System.Object, Share.Common.ObjPool.IPooledObjectNew
{
	UnityEngine.GameObject MainGo; // 0x10
	UnityEngine.Transform MainTransform; // 0x18
	System.UInt64 <Mid>k__BackingField; // 0x20
	System.Boolean <IsReturn>k__BackingField; // 0x28
	System.Boolean <CareThreadSafe>k__BackingField; // 0x29
	System.UInt64 get_Mid(); // 0x0690d01c
	System.Void set_Mid(System.UInt64 value); // 0x0690d080
	System.Boolean get_IsReturn(); // 0x0690d0f8
	System.Void set_IsReturn(System.Boolean value); // 0x0690d15c
	System.Boolean get_CareThreadSafe(); // 0x0690d1d8
	System.Void set_CareThreadSafe(System.Boolean value); // 0x0690d23c
	System.Void ReturnToPool(); // 0x0690d2b8
	System.Void .ctor(); // 0x069058b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel : WizardGames.Soc.SocClient.GoLoader.Proxy.Proxy_Base
{
	System.Int32 PerformanceBudget; // 0x2c
	System.Int32 PerformanceUsedScore; // 0x30
	System.Int64 MemoryBudget; // 0x38
	System.Int64 MemoryUsed; // 0x40
	System.Boolean BridleVisible; // 0x48
	System.Int64 TemplateId; // 0x50
	WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseData CurData; // 0x58
	WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseRendererData CurDataRenderer; // 0x78
	Unity.Collections.LowLevel.Unsafe.UnsafeRingQueue<WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate> CurOperateList; // 0xb8
	Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseLoadingData> CurLoadingList; // 0xd8
	Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseLoadedAssetData> CurLoadedList; // 0xf0
	Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate> CurWaitList; // 0x108
	Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOpDependencyData> CurWaitRegDepList; // 0x120
	System.Action<System.UInt64,WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseViewLevel> OnDowngradeCbk; // 0x138
	System.Action<System.UInt64,WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseViewLevel> OnUpgradeCbk; // 0x140
	System.Action<System.UInt64,WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate>[] OnOperateCbk; // 0x148
	static SocLogger logger; // 0x0
	static System.Collections.Generic.List<WizardGames.AssetPool.AssetPoolHandle> _tempAssetList; // 0x8
	static System.Collections.Generic.HashSet<System.UInt64> _bridleEquipIds; // 0x10
	System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform[]> _originalBonesCache; // 0x150
	static System.UInt64 Allocate(System.Int64 mainEntityId, WizardGames.Soc.SocClient.GoLoader.ModelType modelType, UnityEngine.GameObject mainGo); // 0x0690d318
	static System.Void Free(System.UInt64 mid); // 0x0690dc28
	static System.Void Execute(System.UInt64 mid, WizardGames.Soc.SocClient.GoLoader.HorseOperateType operateType, System.UInt64 p1, System.UInt64 p2, System.UInt64 p3, System.Boolean immediate); // 0x0690dcc4
	static System.Void SetBridleVisible(System.UInt64 mid, System.Boolean visible); // 0x0690e9f8
	static System.Void SetAllPartsVisible(System.UInt64 mid, System.Boolean visible); // 0x0690ecd8
	static WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseViewLevel _GetExpectViewLevel(System.Int32 lodLv); // 0x0690ef9c
	WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseViewLevel _GetExpectViewLevel(); // 0x0690f104
	System.Void _Init(System.Int64 mainEntityId, WizardGames.Soc.SocClient.GoLoader.ModelType modelType, UnityEngine.GameObject mainGo); // 0x0690d44c
	System.Void ReturnToPool(); // 0x0690f2bc
	System.Void _PushOperate(WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate operate); // 0x0690de10
	System.Void _ExecuteOperate(); // 0x0690dee8
	System.String _GetHorseControllerPath(); // 0x0691031c
	System.String _GetHorsePartPath(WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate operate); // 0x0691139c
	System.Void _SetAnimCtrl(WizardGames.AssetPool.AssetPoolHandle handle, WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate operate); // 0x06910c60
	System.Void _RegisterDependencyOps(); // 0x0690f220
	System.Void _HandleBridleVisibility(WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate operate, UnityEngine.GameObject go); // 0x069123f8
	System.Void _RefreshBridleVisibility(); // 0x0690eacc
	System.Void _RecoverLODGroup(UnityEngine.GameObject go); // 0x0691277c
	System.Void _RegisterWaitOp(WizardGames.Soc.SocClient.GoLoader.HorseOperateType mainOp, WizardGames.Soc.SocClient.GoLoader.HorseOperateType childOp); // 0x06912234
	System.Boolean _ShouldWait(WizardGames.Soc.SocClient.GoLoader.HorseOperateType mainOp, WizardGames.Soc.SocClient.GoLoader.HorseOperateType waitOp); // 0x06912898
	System.Void _ExecuteWaitOp(WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate operate); // 0x06910ee0
	System.Void _RemoveAllWaitOp(WizardGames.Soc.SocClient.GoLoader.HorseOperateType operateType); // 0x06911298
	WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseLoadedAssetData _GetLoadedData(WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate operate); // 0x06911644
	System.Boolean _TryRemoveLoadedAsset(WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate operate, WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseLoadedAssetData& data); // 0x06911b0c
	System.Void _CancelPreviousLoading(WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate operate); // 0x069105b0
	WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseLoadingData _GetLoadingData(WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate operate); // 0x06912998
	System.Void _LoadGo(WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate operate, System.String loadPath, System.Action<UnityEngine.GameObject,System.Object[]> cb); // 0x06911774
	System.Void _LoadAsset(WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate loadOp, System.String loadPath, System.IntPtr onLoaded); // 0x069108bc
	System.Void _RecordLoadingJob(WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate loadOp, System.UInt64 jobId, WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.LoaderType loaderType, System.String loadPath); // 0x06912ad8
	WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseLoadedAssetData _RecordLoadedAsset(WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate loadOp, WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseLoadingData loadingData, UnityEngine.GameObject go); // 0x06912d84
	System.Void _ClearLoadingList(); // 0x0690f660
	System.Int32 _GetLoadPriority(WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate operate); // 0x06912c94
	System.Void _OnGoLoaded(UnityEngine.GameObject go, WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate operate, WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseLoadedAssetData& loadedAssetData); // 0x06912fe0
	System.Void _RemoveRecordLoadingJob(WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate operate); // 0x069133f8
	System.Void _RebindBones(UnityEngine.GameObject partGo, UnityEngine.Transform mainRoot); // 0x06913524
	System.Void _RestoreBones(UnityEngine.GameObject partGo); // 0x0690f7e4
	UnityEngine.Transform _FindChildRecursive(UnityEngine.Transform parent, System.String name); // 0x06913f88
	System.Void _InvokeOpCbk(WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate operate); // 0x069100d0
	System.Void _SetAllPartsVisible(System.Boolean visible); // 0x0690eda8
	System.Void _ApplyNewBones(UnityEngine.GameObject go); // 0x069140d4
	System.Void _ResetNewBones(UnityEngine.GameObject go); // 0x0690fe44
	System.Void _ApplyPhysicsBone(UnityEngine.GameObject go); // 0x0691457c
	System.Void _ResetPhysicsBone(UnityEngine.GameObject go); // 0x0690faa8
	System.Void _InvokeCleanCbk(WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseLoadedAssetData data, WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate operate); // 0x06911f14
	static System.Void _OnSwitchController(WizardGames.AssetPool.CSharpAny proxyAny, WizardGames.AssetPool.CSharpAny opAny, WizardGames.AssetPool.AssetPoolHandle handle, System.Boolean success); // 0x0691490c
	System.Void .ctor(); // 0x06914c0c
	static System.Void .cctor(); // 0x06914c78
}

// Client.Runtime
enum WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseViewLevel : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseViewLevel Default = 0;
	static WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseViewLevel Medium = 1;
	static WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseViewLevel Low = 2;
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate : System.ValueType, System.IEquatable<WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate>
{
	WizardGames.Soc.SocClient.GoLoader.HorseOperateType OperateType; // 0x10
	System.UInt64 Lparam1; // 0x18
	System.UInt64 Lparam2; // 0x20
	System.UInt64 LParam3; // 0x28
	System.Double OpCreateTime; // 0x30
	System.Void Dispose(); // 0x0691529c
	System.Boolean Equals(WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate other); // 0x06915310
	System.Int32 GetHashCode(); // 0x069153e0
	System.String ToString(); // 0x069154a4
}

// Client.Runtime
struct WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseData : System.ValueType
{
	System.Int64 mainEntityId; // 0x10
	System.Int64 TemplateId; // 0x18
	System.Boolean Valid; // 0x20
	System.Boolean IsMaster; // 0x21
	System.Int32 mainEntityType; // 0x24
	WizardGames.Soc.SocClient.GoLoader.ModelType modelType; // 0x28
	WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseViewLevel ViewLevel; // 0x2c
	System.Void Dispose(); // 0x06915730
}

// Client.Runtime
enum WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.LoaderType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.LoaderType AssetLoader = 0;
	static WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.LoaderType GoLoader = 1;
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOpDependencyData : System.ValueType
{
	WizardGames.Soc.SocClient.GoLoader.HorseOperateType sourceOp; // 0x10
	System.Nullable<WizardGames.Soc.SocClient.GoLoader.HorseOperateType> singleWaitOp; // 0x14
	Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.Soc.SocClient.GoLoader.HorseOperateType> waitOps; // 0x20
	System.Void AddWaitOp(WizardGames.Soc.SocClient.GoLoader.HorseOperateType operateType); // 0x069157a8
	System.Boolean Contains(WizardGames.Soc.SocClient.GoLoader.HorseOperateType opType); // 0x06915990
	System.Void Dispose(); // 0x06915aa8
}

// Client.Runtime
struct WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseLoadingData : System.ValueType
{
	WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.LoaderType LoaderType; // 0x10
	System.UInt64 loadHash; // 0x18
	System.UInt64 loadingJobId; // 0x20
	WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate operate; // 0x28
	System.Boolean Valid; // 0x50
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseLoadedAssetData : System.ValueType
{
	System.UInt64 assetInstanceId; // 0x10
	System.UInt64 loadHash; // 0x18
	WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.LoaderType LoaderType; // 0x20
	System.Boolean Valid; // 0x24
	WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate operate; // 0x28
	UnityEngine.GameObject GetGo(); // 0x06915b44
}

// Client.Runtime
struct WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseRendererData : System.ValueType
{
	System.Boolean Valid; // 0x10
	System.Int32 animatorId; // 0x14
	WizardGames.AssetPool.AssetPoolHandle animCtrlHandle; // 0x18
	Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseGameObjectRenderer> loadedGos; // 0x20
	Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorsePartRenderers> equipParts; // 0x38
	System.Void Create(); // 0x06915c1c
	System.Void Dispose(); // 0x06915d60
}

// Client.Runtime
struct WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseSharedMaterial : System.ValueType
{
	System.Int32 MaterialId; // 0x10
	Unity.Collections.FixedString128Bytes MaterialName; // 0x14
	UnityEngine.Material GetMaterial(); // 0x0691617c
	System.Void Build(UnityEngine.Material material); // 0x06916260
}

// Client.Runtime
struct WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseMaterial : System.ValueType
{
	WizardGames.AssetPool.AssetPoolHandle MaterialAsset; // 0x10
	WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate OperationSource; // 0x18
	Unity.Collections.FixedString64Bytes MaterialName; // 0x40
	System.Void Dispose(); // 0x06916360
}

// Client.Runtime
struct WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseRenderer : System.ValueType
{
	System.Int32 RenderId; // 0x10
	UnityEngine.Rendering.ShadowCastingMode shadowCastingMode; // 0x14
	System.UInt32 renderingLayerMask; // 0x18
	WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate OperationSource; // 0x20
	System.Int32 skinnedRootBone; // 0x48
	System.Int32 skinQuality; // 0x4c
	Unity.Collections.LowLevel.Unsafe.UnsafeList<System.Int32> skinnedBones; // 0x50
	Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseSharedMaterial> RendererSharedMaterials; // 0x68
	Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseMaterial> RendererMaterials; // 0x80
	UnityEngine.Renderer GetRenderer(); // 0x069163c8
	System.Void Build(WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate op, UnityEngine.Renderer renderer); // 0x069164ac
	System.Void Create(); // 0x06916988
	System.Void Dispose(); // 0x06916b28
}

// Client.Runtime
struct WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseGameObjectRenderer : System.ValueType
{
	UnityEngine.Vector3 localPosition; // 0x10
	UnityEngine.Quaternion localRotation; // 0x1c
	System.Int32 layer; // 0x2c
	WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseLoadedAssetData loadedData; // 0x30
	System.Void Build(WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseLoadedAssetData inLoadedAssetData); // 0x06917268
	System.Void Dispose(); // 0x06915f54
}

// Client.Runtime
struct WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorsePartRenderers : System.ValueType
{
	WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate OperationSource; // 0x10
	Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseRenderer> renderers; // 0x38
	System.Void BuildRenderers(WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate op, WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseLoadedAssetData loadedGo, UnityEngine.GameObject go); // 0x06917394
	System.Void Create(); // 0x06917608
	System.Void Dispose(); // 0x06916048
}

// Client.Runtime
class WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.<>c__DisplayClass41_0 : System.Object
{
	WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseOperate operate; // 0x10
	WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel <>4__this; // 0x38
	System.Void .ctor(); // 0x069176d8
	System.Void <_ExecuteOperate>b__0(UnityEngine.GameObject go, System.Object[] objs); // 0x06917740
}

// Client.Runtime
class WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.HorseModel_GoCleaner : System.Object
{
	static System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.GoLoader.HorseOperateType,System.Action<WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseLoadedAssetData>> OperateTypeToLoaderTypeMap; // 0x0
	static System.Void ReleaseProxy(WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel proxyHorseModel); // 0x06917cd0
	static System.Void ReleaseProxyPostProcess(WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel proxyHorseModel); // 0x06917d30
	static System.Void ReleaseMain(WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseLoadedAssetData asset); // 0x06917d90
	static System.Void ReleaseEquip(WizardGames.Soc.SocClient.GoLoader.Proxy.Horse.Proxy_HorseModel.HorseLoadedAssetData asset); // 0x06917e90
	static System.Void .cctor(); // 0x06917f90
}

// Client.Runtime
class WizardGames.Soc.SocClient.GoLoader.Proxy.Handle.ProxyModel_GoCleaner : System.Object
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.GoLoader.PartModelOperateType,System.Action<WizardGames.Soc.SocClient.GoLoader.Proxy_PartModel.PartModelLoadedAssetData>> OperateTypeToLoaderTypeMap; // 0x8
	static System.Void ReleaseProxy(WizardGames.Soc.SocClient.GoLoader.Proxy_PartModel proxyPartModel); // 0x069180e8
	static System.Void ReleaseProxyPostProcess(WizardGames.Soc.SocClient.GoLoader.Proxy_PartModel proxyPartModel); // 0x06918148
	static System.Void ReleaseHaris(WizardGames.Soc.SocClient.GoLoader.Proxy_PartModel.PartModelLoadedAssetData asset); // 0x069181a8
	static System.Void ReleaseNakedParts(WizardGames.Soc.SocClient.GoLoader.Proxy_PartModel.PartModelLoadedAssetData asset); // 0x069182b0
	static System.Void ReleaseEquipParts(WizardGames.Soc.SocClient.GoLoader.Proxy_PartModel.PartModelLoadedAssetData asset); // 0x069183b8
	static System.Void .cctor(); // 0x069184c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.StateMachine.BaseIOAction : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Entity.IOEntity iOEntity; // 0x10
	WizardGames.Soc.Common.Unity.Go.BaseIOGo baseIOGo; // 0x18
	System.Boolean isInit; // 0x20
	System.Boolean openIOActionDebug; // 0x21
	System.Boolean CanOwnAction(System.Int32 stateID); // 0x0691895c
	System.Void Init(WizardGames.Soc.Common.Entity.IOEntity ioEntity, WizardGames.Soc.Common.Unity.Go.BaseIOGo baseIOGO, System.Int32 stateID, System.Int32 preStateID); // 0x069189d4
	System.Void OnEnter(); // 0x06918a94
	System.Void Execute(); // 0x06918af4
	System.Void Exit(System.Int32 nextStateID); // 0x06918b54
	WizardGames.Soc.Common.Data.units.IOInteractiveState GetIOInteractiveStateCfg(System.Int32 stateID); // 0x06918bc8
	System.Void LogError(System.String context); // 0x06918e00
	System.Void LogWarning(System.String context); // 0x06918ecc
	System.Void .ctor(); // 0x06918f98
	static System.Void .cctor(); // 0x06919000
}

// Client.Runtime
class WizardGames.Soc.SocClient.StateMachine.HideTargetGoAction : WizardGames.Soc.SocClient.StateMachine.BaseIOAction
{
	System.String[] hideGoPaths; // 0x28
	WizardGames.Soc.SocClient.Go.IOGo iOGo; // 0x30
	System.Boolean CanOwnAction(System.Int32 stateID); // 0x069190d4
	System.Void Init(WizardGames.Soc.Common.Entity.IOEntity ioEntity, WizardGames.Soc.Common.Unity.Go.BaseIOGo baseIOGo, System.Int32 stateID, System.Int32 preStateID); // 0x06919174
	System.Void Execute(); // 0x069193d4
	System.Void .ctor(); // 0x0691945c
}

// Client.Runtime
class WizardGames.Soc.SocClient.StateMachine.MaterialChangeAction : WizardGames.Soc.SocClient.StateMachine.BaseIOAction
{
	System.Collections.Generic.Dictionary<System.String,System.String> matChangeInfo; // 0x28
	WizardGames.Soc.SocClient.Go.IOGo iOGo; // 0x30
	System.Boolean CanOwnAction(System.Int32 stateID); // 0x069194e4
	System.Void Init(WizardGames.Soc.Common.Entity.IOEntity ioEntity, WizardGames.Soc.Common.Unity.Go.BaseIOGo baseIOGo, System.Int32 stateID, System.Int32 preStateID); // 0x06919584
	System.Void Execute(); // 0x0691998c
	System.Void .ctor(); // 0x06919b90
}

// Client.Runtime
class WizardGames.Soc.SocClient.StateMachine.PlayAnimationAction : WizardGames.Soc.SocClient.StateMachine.BaseIOAction
{
	System.String animationkey; // 0x28
	System.Int32 animationValue; // 0x30
	WizardGames.Soc.SocClient.Go.IOGo iOGo; // 0x38
	System.Boolean CanOwnAction(System.Int32 stateID); // 0x06919c68
	System.Void Init(WizardGames.Soc.Common.Entity.IOEntity ioEntity, WizardGames.Soc.Common.Unity.Go.BaseIOGo baseIOGO, System.Int32 stateID, System.Int32 preStateID); // 0x06919d08
	System.Void Execute(); // 0x0691a04c
	System.Void .ctor(); // 0x0691a0d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.StateMachine.PlayAnimationByHandAction : WizardGames.Soc.SocClient.StateMachine.BaseIOAction
{
	WizardGames.Soc.SocClient.Go.IOGo iOGo; // 0x28
	System.String animationkey; // 0x30
	System.Int32 animationValue; // 0x38
	System.Single rotationTime; // 0x3c
	UnityEngine.Quaternion openStartRotation; // 0x40
	UnityEngine.Quaternion openTargetRotation; // 0x50
	System.Boolean CanOwnAction(System.Int32 stateID); // 0x0691a180
	System.Void Init(WizardGames.Soc.Common.Entity.IOEntity ioEntity, WizardGames.Soc.Common.Unity.Go.BaseIOGo baseIOGO, System.Int32 stateID, System.Int32 preStateID); // 0x0691a254
	System.Void Execute(); // 0x0691a504
	System.Void .ctor(); // 0x0691a588
}

// Client.Runtime
class WizardGames.Soc.SocClient.StateMachine.PlayAudioAction : WizardGames.Soc.SocClient.StateMachine.BaseIOAction
{
	System.String audioWwiseEvent; // 0x28
	System.Int32 preStateID; // 0x30
	WizardGames.Soc.SocClient.Go.IOGo ioGo; // 0x38
	System.Boolean CanOwnAction(System.Int32 stateID); // 0x0691a640
	System.Void Init(WizardGames.Soc.Common.Entity.IOEntity ioEntity, WizardGames.Soc.Common.Unity.Go.BaseIOGo baseIOGO, System.Int32 stateID, System.Int32 preStateID); // 0x0691a6e0
	System.Void Execute(); // 0x0691a848
	System.Void .ctor(); // 0x0691a8e4
}

// Client.Runtime
class WizardGames.Soc.SocClient.StateMachine.PlayEffectAction : WizardGames.Soc.SocClient.StateMachine.BaseIOAction
{
	System.Int32 mEffectID; // 0x24
	System.String mEffectRoot; // 0x28
	Effect.EffectItemHandle<Effect.EffectItem> mEffectHandle; // 0x30
	System.Boolean CanOwnAction(System.Int32 stateID); // 0x0691a99c
	System.Void Init(WizardGames.Soc.Common.Entity.IOEntity ioEntity, WizardGames.Soc.Common.Unity.Go.BaseIOGo baseIOGO, System.Int32 stateID, System.Int32 preStateID); // 0x0691aa34
	System.Void Execute(); // 0x0691ab0c
	System.Void Exit(System.Int32 nextStateID); // 0x0691abe4
	System.Void .ctor(); // 0x0691acc4
}

// Client.Runtime
class WizardGames.Soc.SocClient.StateMachine.ShowTargetGoAction : WizardGames.Soc.SocClient.StateMachine.BaseIOAction
{
	System.String[] showGoPaths; // 0x28
	WizardGames.Soc.SocClient.Go.IOGo iOGo; // 0x30
	System.Boolean CanOwnAction(System.Int32 stateID); // 0x0691ad4c
	System.Void Init(WizardGames.Soc.Common.Entity.IOEntity ioEntity, WizardGames.Soc.Common.Unity.Go.BaseIOGo baseIOGo, System.Int32 stateID, System.Int32 preStateID); // 0x0691adec
	System.Void Execute(); // 0x0691b0f8
	System.Void .ctor(); // 0x0691b180
}

// Client.Runtime
class WizardGames.Soc.SocClient.StateMachine.IOState : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.StateMachine.BaseIOAction> allActions; // 0x10
	WizardGames.Soc.Common.Entity.IOEntity iOEntity; // 0x18
	WizardGames.Soc.SocClient.Go.IOGo iOGO; // 0x20
	System.Int32 curStateID; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.StateMachine.BaseIOAction> ownActions; // 0x30
	System.Action<System.Int32> onStateChanged; // 0x38
	System.Void ChangeState(WizardGames.Soc.Common.Entity.IOEntity ioEntity, WizardGames.Soc.SocClient.Go.IOGo iOGo, System.Int32 stateID); // 0x0691b208
	System.Void SetStateActionsData(System.Int32 preStateID); // 0x0691b4f0
	System.Void OnStateEnter(); // 0x0691b768
	System.Void OnStateExit(System.Int32 nextStateID); // 0x0691b350
	System.Void Release(); // 0x0691b8e8
	System.Void .ctor(); // 0x0691b950
}

// Client.Runtime
class WizardGames.Soc.SocClient.Shatter.MgrBoxShatter : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Boolean collectionCheck; // 0x11
	System.Int32 poolDefaultSize; // 0x14
	System.Int32 poolMaxSize; // 0x18
	UnityEngine.GameObject boxShatterRoot; // 0x20
	System.Collections.Generic.Dictionary<System.Int64,UnityEngine.GameObject> timer2ShatterObjDic; // 0x28
	System.Collections.Generic.Dictionary<System.Int64,System.String> timer2ShatterPathDic; // 0x30
	System.Void Init(); // 0x0691bdf0
	System.Void CleanUp(); // 0x0691be58
	UnityEngine.GameObject GetBoxShatterGO(System.String shatterPath); // 0x0691c2f0
	System.Void CheckShatterRoot(); // 0x0691c3e0
	UnityEngine.GameObject CreateBoxShatter(System.String shatterPath, UnityEngine.Vector3 pos, System.Int32 shatterDestroyTime, UnityEngine.Quaternion rotation); // 0x0691c528
	System.Void OnShatterDestroy(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x0691c0a4
	System.Void .ctor(); // 0x0691c924
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.BoxGo : WizardGames.Soc.Common.Unity.Go.BaseBoxGo
{
	Effect.EffectItemHandle<Effect.FollowEffect> airDropEffect; // 0xd0
	WizardGames.Soc.SocClient.ClientLight.LightItem lightItem; // 0xe0
	UnityEngine.Transform parachutePoint; // 0xe8
	UnityEngine.Transform fx_socket_01; // 0xf0
	UnityEngine.GameObject parachuteGo; // 0xf8
	UnityEngine.Vector3 targetPosition; // 0x100
	UnityEngine.Quaternion targetRotation; // 0x10c
	static System.String InCircle; // 0x0
	static System.String OutCircle; // 0x8
	static System.String ControllerName; // 0x10
	System.Boolean initTip; // 0x11c
	System.Int64 timerID; // 0x120
	System.Int64 transformSubId; // 0x128
	System.Int32 tickSpan; // 0x130
	System.String shatterPath; // 0x138
	System.Int32 shatterDestroyTime; // 0x140
	System.Boolean isCreateGib; // 0x144
	System.Int64 lastMoveTime; // 0x148
	System.Boolean isMoving; // 0x150
	Effect.EffectItemHandle<Effect.EffectItem> _effect; // 0x158
	System.Collections.Generic.Dictionary<UnityEngine.Renderer,UnityEngine.Material> _cacheMaterialDic; // 0x168
	UnityEngine.Material _material; // 0x170
	System.Int64 _timerEffectRelease; // 0x178
	WizardGames.Soc.Common.Component.ActivationComponent ActivationComp; // 0x180
	WizardGames.Soc.Common.Entity.BoxEntity get_EntityRef(); // 0x0691ca40
	WizardGames.Soc.Common.Component.GpuInstComponent get_gpuInst(); // 0x0691caa8
	System.Boolean IsShowInventory(); // 0x0691cb40
	System.Void .ctor(); // 0x0691cba4
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.BoxEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x0691ccb8
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0691cf30
	System.Void SetActivationComp(); // 0x0691d0c4
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x05523a54
	System.Void ChangeMaterial(); // 0x0691e98c
	System.Void ChangeMaterialBack(); // 0x0691ea6c
	System.Void OnNextOpenTsChange(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, System.Int64 oldValue, System.Int64 newValue); // 0x0691e44c
	System.Void OnTransformChange(WizardGames.Soc.Share.Framework.PositionChangeEvent e); // 0x0691e2e0
	System.Void SetSmoothProp(); // 0x0691efcc
	System.Void PlayBoxAnim(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Boolean oldValue, System.Boolean newValue); // 0x0552b2a8
	System.Void SetMoving(); // 0x0691ef20
	System.Void InitAirBox(); // 0x0691db2c
	System.Void InitDropBox(); // 0x0691debc
	System.Void UpdateAirBoxState(); // 0x0691f324
	System.Void UpdateAirLightOffOn(System.Boolean isMorning); // 0x0691f44c
	System.Boolean IsAirDropBox(); // 0x0691f6c0
	System.Void MoveTick(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x0691f840
	System.Void InitBoxInfo(); // 0x0691fb1c
	System.Void CreateBoxShatter(); // 0x0691fc4c
	System.Void OpenBoxByRPC(System.Int64 boxEntityId); // 0x0691fdec
	static System.Void CloseLootView(System.Int64 lootingEntityId); // 0x069200ac
	System.Void Clear(); // 0x069202c8
	System.Void CancelTimer(); // 0x06920abc
	System.Void CancelOpenTimer(); // 0x06920c48
	System.Void RemoveEventTransformChange(); // 0x06920bc0
	System.Void Remove(); // 0x06920d4c
	System.Void CheckMoveStop(); // 0x0691f9a0
	System.Void EnableOutline(UnityEngine.Color color, System.Single dilateShift, System.Single blurShift, System.Int32 lodLevel); // 0x06920dbc
	System.Void DisableOutline(); // 0x06921024
	System.Void OnRenderConditionChange(); // 0x0691dff4
	System.Boolean CanAddToGPURenderer(); // 0x069211f8
	System.Boolean CanRemoveFromGPURenderer(); // 0x06921320
	static System.Void .cctor(); // 0x069213d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.BoxGo.<>c__DisplayClass38_0 : System.Object
{
	WizardGames.Soc.Common.Entity.BoxEntity boxEntity; // 0x10
	System.Void .ctor(); // 0x0691dac4
	System.Void <SetMainGo>b__0(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x06921490
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.BoxGo.<>c__DisplayClass41_0 : System.Object
{
	WizardGames.Soc.SocClient.Go.BoxGo <>4__this; // 0x10
	System.String failSound; // 0x18
	System.Void .ctor(); // 0x0691eeb8
	System.Void <OnNextOpenTsChange>b__0(System.Int64 id, System.Object data, System.Boolean delete); // 0x06921714
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Go.BoxGo.<ChangeMaterial>d__39 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Go.BoxGo <>4__this; // 0x38
	System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Material> <>u__1; // 0x40
	System.Void MoveNext(); // 0x069218e0
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x06922108
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.ClientPasswordBoxGo : WizardGames.Soc.SocClient.Go.BoxGo
{
	static System.Int32 secInMinute; // 0x0
	System.Int32 countDownTickSpan; // 0x188
	System.Int64 countDownTimer; // 0x190
	FairyGUI.GTextField passwordBoxCountDown; // 0x198
	static System.String uiRootKey; // 0x8
	static System.String computerRootKey; // 0x10
	static System.String defaultContextKey; // 0x18
	static System.String countDownKey; // 0x20
	static System.String redPromptKey; // 0x28
	static System.String greenPromptKey; // 0x30
	static System.String showAnimStr; // 0x38
	System.Int32 curPasswordBoxStage; // 0x1a0
	System.Int64 countdownFinishServerWorldTimeMs; // 0x1a8
	System.Boolean isStartCountDown; // 0x1b0
	UnityEngine.GameObject uiRoot; // 0x1b8
	UnityEngine.GameObject computerRoot; // 0x1c0
	UnityEngine.GameObject redPromptObj; // 0x1c8
	UnityEngine.GameObject greenPromptObj; // 0x1d0
	FairyGUI.UIPanel boxPasswordPanel; // 0x1d8
	FairyGUI.Controller statusCtrl; // 0x1e0
	WizardGames.Soc.Common.Combat.ColliderConfig computerCC; // 0x1e8
	System.String computerHitEffectPointPath; // 0x1f0
	UnityEngine.Transform computerHitEffectPoint; // 0x1f8
	FairyGUI.Transition show_anim; // 0x200
	System.Void .ctor(); // 0x06922188
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0692223c
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x069223c8
	System.Void InitBoxInfo(); // 0x06922abc
	System.Void SetPasswordBoxCountDownData(); // 0x06923394
	System.String GetTimeContext(System.Int64 timeMs); // 0x069234c0
	System.Void OnCountDownFinishTimeChanged(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int64 oldValue, System.Int64 newValue); // 0x069228d0
	System.Void OnBoxStateIDChanged(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int32 oldValue, System.Int32 newValue); // 0x069229d0
	System.Void InitPasswordBoxUI(); // 0x0692286c
	System.Void OnPasswordBoxStateChanged(); // 0x055049cc
	System.Void OnCountDownStart(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x06923af4
	System.Void Clear(); // 0x06923bf8
	System.Void Remove(); // 0x06923ee4
	System.Boolean IsShowInventory(); // 0x06923f50
	System.Void UpdatePasswordState(); // 0x06923b88
	System.Void UpdatePasswordBoxCountdown(System.Boolean passwordCountdown); // 0x06923fbc
	System.String GetPasswordCountDown(); // 0x06924074
	System.Void OnComputerHit(); // 0x06924120
	static System.Void .cctor(); // 0x06924298
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.BulletTraceFx : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	WizardGames.Soc.Common.Entity.BulletEntity Entity; // 0x10
	System.String prefabPath; // 0x18
	System.Boolean isSelf; // 0x20
	System.Boolean isValid; // 0x21
	UnityEngine.Transform FxParent; // 0x28
	UnityEngine.GameObject FxGo; // 0x30
	WizardGames.Soc.Common.Unity.Effect.EffectProfile FxProfile; // 0x38
	UnityEngine.Transform FxTransform; // 0x40
	UnityEngine.Vector3 InitWorldPos; // 0x48
	System.Single ShowDis; // 0x54
	System.UInt64 _loadPrefabAsyncId; // 0x58
	System.Boolean isCreateByEffect; // 0x60
	Effect.EffectItemHandle<Effect.EffectItem> dragItemHandle; // 0x68
	Effect.FollowEffect tailFx; // 0x78
	System.Boolean isParticleFx; // 0x80
	WizardGames.Soc.Common.Data.bullet.TracerBullet traceTb; // 0x88
	WizardGames.Soc.Common.Data.bullet.BulletBase bulletTb; // 0x90
	System.Int64 subscribeid; // 0x98
	System.Action<System.Boolean,Effect.EffectItem,System.Object> onDragEffectLoadCompleted; // 0xa0
	static SocLogger logger; // 0x0
	System.Action<System.Boolean,Effect.EffectItem> OnDragLoadFinish; // 0xa8
	static WizardGames.Soc.SocClient.Go.BulletTraceFx CreateBulletTraceFx(WizardGames.Soc.Common.Entity.BulletEntity bullet, UnityEngine.Transform parent, System.Boolean isSelf); // 0x06924408
	System.Void .ctor(); // 0x055049cc
	System.Void Init(WizardGames.Soc.Common.Entity.BulletEntity bullet, UnityEngine.Transform parent); // 0x0552af00
	System.Void OnDestroyEffect(WizardGames.Soc.Share.Framework.CustomTypeBase arg1, System.Boolean oldValue, System.Boolean newValue); // 0x06925b18
	System.Void OnDragEffectLoadCompleted(System.Boolean success, Effect.EffectItem effectItem, System.Object o); // 0x06925c10
	System.Void OnLoaded(UnityEngine.GameObject go, System.Object[] ps); // 0x0552af00
	System.Void CreateDrag(WizardGames.Soc.Common.Data.bullet.TracerBullet dragTb, UnityEngine.Transform parent); // 0x0552af00
	System.Void DragLoadFinish(System.Boolean suc, Effect.EffectItem item); // 0x05524154
	System.Void Update(); // 0x055049cc
	System.Void UpdateShow(); // 0x055049cc
	System.Void UpdateBulletGoScale(); // 0x055049cc
	System.Void Release(); // 0x06926520
	System.Void OnGet(); // 0x069265c0
	System.Void OnRelease(); // 0x055049cc
	System.Void OnDestroy(); // 0x06926c7c
	static System.Void .cctor(); // 0x06926cdc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.ClientBulletGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo, WizardGames.Soc.Common.Unity.Go.ISmoothGo
{
	WizardGames.Soc.Common.Entity.BulletEntity <BulletEntity>k__BackingField; // 0x68
	WizardGames.Soc.SocClient.Go.BulletTraceFx BulletFx; // 0x70
	System.Single bornTime; // 0x78
	System.Int32 lastFrame; // 0x7c
	System.Collections.Generic.HashSet<System.Int64> SubscribeIds; // 0x80
	System.Action<WizardGames.Soc.Share.Framework.CustomTypeBase,System.Single,System.Single> transformChanged; // 0x88
	Go.GoComp.SmoothComp <SmoothComp>k__BackingField; // 0x90
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.BulletEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x06926db0
	WizardGames.Soc.Common.Entity.BulletEntity get_BulletEntity(); // 0x06926e50
	System.Void set_BulletEntity(WizardGames.Soc.Common.Entity.BulletEntity value); // 0x06926eb4
	System.Single get_ExistTime(); // 0x06926f34
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x06926fa4
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x0692712c
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x069272d8
	System.Void OnTransformChanged(WizardGames.Soc.Share.Framework.CustomTypeBase data, System.Single oldValue, System.Single newValue); // 0x06927e28
	System.Void Clear(); // 0x06928264
	System.Void Remove(); // 0x069285c0
	WizardGames.Soc.Common.Entity.IEntity get_GetEntity(); // 0x06928630
	Go.GoComp.SmoothComp get_SmoothComp(); // 0x069286c8
	System.Void set_SmoothComp(Go.GoComp.SmoothComp value); // 0x0692872c
	System.Void SetSmoothProp(); // 0x069287ac
	System.Void CheckBulletLoopSoundOn(); // 0x06928088
	System.Void CheckBulletLoopSoundOff(); // 0x06928484
	System.Void .ctor(); // 0x0692897c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.CarshredderGo : WizardGames.Soc.Common.Unity.Go.BaseCarshredderGo
{
	System.Collections.Generic.Dictionary<UnityEngine.GameObject,WizardGames.Soc.SocClient.Trigger.TriggerForce> goForceList; // 0x70
	System.Int64 timerID; // 0x78
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.CarshredderEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x06928a58
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x06928cd0
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x05523a54
	System.Void InitTriggerParam(); // 0x06929180
	System.Void Tick(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x06929490
	System.Void ManualRemoveCollider(WizardGames.Soc.Common.Entity.IEntity ent); // 0x06929640
	System.Void AudioEvent(System.String audioEventName, System.Boolean stop); // 0x06929028
	System.Void Remove(); // 0x069297dc
	System.Void .ctor(); // 0x069298b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.CaveLiftGo : WizardGames.Soc.Common.Unity.Go.BaseCaveLiftGo
{
	System.Int64 movingTimerHandle; // 0x78
	System.Collections.Generic.List<System.Int32> interactiveIDs; // 0x80
	static System.String movingTimerMark; // 0x0
	UnityEngine.Transform get_wheelTransform(); // 0x06929968
	System.Void .ctor(); // 0x069299d8
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x06929ab8
	System.Void OnUiBtnClicked(System.Int32 id); // 0x06929dd0
	System.Collections.Generic.List<System.Int32> GetInteractiveID(); // 0x06929f38
	System.Void Remove(); // 0x0692a070
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x06929c44
	System.Void Clear(); // 0x0692a0e0
	System.Void MovingDirectionChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int32 oldValue, System.Int32 newValue); // 0x0692a248
	System.Void MovingStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Boolean oldValue, System.Boolean newValue); // 0x0692a460
	System.Void UpdateTransform(WizardGames.Soc.Common.Entity.ISmoothCloneEntity smoothEntity); // 0x0692a54c
	static System.Void .cctor(); // 0x0692a740
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.ClientCH47Go : WizardGames.Soc.SocClient.Go.ClientVehicleGo
{
	Effect.EffectItemHandle<Effect.EffectItem> GroundEffectHandler; // 0x1b8
	WizardGames.Soc.Common.Data.units.HelicopterBehavior HelicopterBehavior; // 0x1c8
	CH47HelicopterAIController AIController; // 0x1d0
	WizardGames.Soc.Common.Entity.VehicleEntity mVehicleEntity; // 0x1d8
	System.Boolean triggerFallAudio; // 0x1e0
	System.Int64 hpSubscribeId; // 0x1e8
	System.Boolean get_IsPredictable(); // 0x0692a7a8
	System.Void LodUpdate(System.Int32 deltaTime); // 0x0692a80c
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0692ab84
	System.Void SubscribePropertyChange(); // 0x0692b3dc
	System.Void UnsubscribePropertyChange(); // 0x0692b4f8
	System.Void SetMainGo(UnityEngine.GameObject obj); // 0x0692aef8
	System.Void OnHpChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Single oldValue, System.Single newValue); // 0x05527728
	System.Void UpdatePassengerPositionOnMount(); // 0x0692b610
	System.Void Clear(); // 0x055049cc
	System.Void Remove(); // 0x0692bb54
	System.Void InitAudio(); // 0x0692b040
	System.Void StopAudio(); // 0x0692b918
	UnityEngine.Transform GetMuzzleTransformByGunnerId(System.Int64 entityId); // 0x0692bbc4
	System.Void OnAIHeliLanded(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x0692befc
	System.Void .ctor(); // 0x0692c088
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.ClientCollectableGo : WizardGames.Soc.Common.Unity.Go.BaseCollectableGo
{
	
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.CollectableEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x0692c11c
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0692c394
	System.Void Remove(); // 0x0692c524
	System.Single get_PosX(); // 0x0692c780
	System.Single get_PosY(); // 0x0692c804
	System.Single get_PosZ(); // 0x0692c888
	System.Void .ctor(); // 0x0692c90c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.ClientConstructionLiftGo : WizardGames.Soc.Common.Unity.Go.BaseConstructionLiftGo, WizardGames.Soc.Common.Unity.Go.ISmoothGo
{
	UnityEngine.Transform rayTrigger; // 0x68
	UnityEngine.Ray viewRay; // 0x70
	System.Collections.Generic.List<System.Int32> interactiveIDs; // 0x88
	Go.GoComp.SmoothComp <SmoothComp>k__BackingField; // 0x90
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x0692c998
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.ElevatorEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x0692ca5c
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0692cb70
	System.Collections.Generic.List<System.Int32> GetInteractiveID(); // 0x0692ccfc
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x0692d158
	System.Void UpdatePositionRotation(); // 0x0692d3b4
	WizardGames.Soc.Common.Entity.IEntity get_GetEntity(); // 0x0692d780
	Go.GoComp.SmoothComp get_SmoothComp(); // 0x0692d818
	System.Void set_SmoothComp(Go.GoComp.SmoothComp value); // 0x0692d87c
	System.Void .ctor(); // 0x0692d8fc
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Go.ClientConstructionLiftGo.EElevatorUiId : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Go.ClientConstructionLiftGo.EElevatorUiId Up = 235;
	static WizardGames.Soc.SocClient.Go.ClientConstructionLiftGo.EElevatorUiId Down = 236;
	static WizardGames.Soc.SocClient.Go.ClientConstructionLiftGo.EElevatorUiId Top = 237;
	static WizardGames.Soc.SocClient.Go.ClientConstructionLiftGo.EElevatorUiId Bottom = 238;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.ClientModularCarGo : WizardGames.Soc.Common.Unity.Go.BaseModularCarGo
{
	WizardGames.Soc.Common.Entity.ModularCarEntity serverModularCarEntity; // 0x1a0
	System.Boolean IsCarLightAreOn; // 0x1a8
	System.Collections.Generic.List<System.Int64> damageCompSubscribeId; // 0x1b0
	static BasePlayer basePlayer; // 0x0
	WizardGames.Soc.Common.Entity.IEntity get_GetEntity(); // 0x0692d9b0
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.ModularCarEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x0692da14
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0692dcc8
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x0692e544
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x0552af00
	System.Void OnLockPlayerRoleIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.UInt64 oldValue, System.UInt64 newValue); // 0x0692ed8c
	System.Void OnDriverIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x0692efd0
	System.Void OnAfterInit(); // 0x0692e91c
	System.Void LodUpdate(System.Int32 deltaTime); // 0x0692f154
	System.Void UnlimitedUpdate(System.Int32 deltaTime); // 0x0692f350
	System.Void SteupChassisVisualsActive(); // 0x0692f21c
	System.Void AddVehicleModuleGo(System.Int32 socketIndex, WizardGames.Soc.Common.Unity.Go.BaseVehicleModuleGo vehicleModuleGo); // 0x0692f488
	System.Void RemoveVehicleModuleGo(System.Int32 socketIndex); // 0x0692f590
	System.Void LightChanged(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x0692f6c8
	System.Void OnMaxHpChange(WizardGames.Soc.Common.Component.DamageableComponent server, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Component.DamageableComponent local); // 0x0692f9cc
	System.Void OnHpChange(WizardGames.Soc.Common.Component.DamageableComponent server, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Component.DamageableComponent local); // 0x0692fa78
	System.Void Clear(); // 0x0692fb24
	System.Void Remove(); // 0x0692fff4
	System.String GetMountableDisplayName(); // 0x06930064
	System.Boolean CanLockInteractive(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06930128
	System.Boolean CanRepairInteractive(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0693031c
	System.Boolean CanVehicleEngineAndOilInteractive(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x069303d0
	System.Boolean CanVehicleEngineAndOilInteractive(WizardGames.Soc.Common.Entity.IVehicleModuleCustom IVehicleModuleCustom); // 0x0693058c
	System.Void Predict(System.Int32 deltaTime, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, System.Int32 physicTickTime, System.Int32 allPhysicTime); // 0x06930764
	WizardGames.Soc.Common.Unity.Go.MountableAuthoritySide GetAuthoritySide(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x069308e0
	System.Void .ctor(); // 0x06930c80
	static System.Void .cctor(); // 0x06930d58
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.ClientModularCarGo.<>c__DisplayClass9_0 : System.Object
{
	WizardGames.Soc.SocClient.Go.ClientModularCarGo <>4__this; // 0x10
	WizardGames.Soc.Common.Entity.IHitableEntity hitable; // 0x18
	WizardGames.Soc.Common.Component.ModularCarDamageableComponent damageable; // 0x20
	System.Void .ctor(); // 0x0692ed24
	System.Void <OnInit>b__0(WizardGames.Soc.Share.Framework.CustomTypeBase server, System.Single oldValue, System.Single newValue); // 0x06930dd4
	System.Void <OnInit>b__1(WizardGames.Soc.Share.Framework.CustomTypeBase server, System.Single oldValue, System.Single newValue); // 0x06930ecc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.ClientOreGo : WizardGames.Soc.Common.Unity.Go.BaseOreGo
{
	WizardGames.Soc.Common.Unity.Go.OreConfig prefabOreConfig; // 0x88
	static System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Collections.Generic.List<UnityEngine.MeshRenderer>> shatterMeshRenderDic; // 0x0
	static System.Collections.Generic.Dictionary<System.Int64,UnityEngine.Material> shatterMatDic; // 0x8
	System.UInt64 loadShatteredAsyncId; // 0x90
	WizardGames.Soc.Common.Component.GpuInstComponent get_gpuInst(); // 0x06930fc4
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.OreEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x0693105c
	static System.Void ClearShatteredCatchData(); // 0x06931358
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0693142c
	System.Void SetMainGo(UnityEngine.GameObject mainGo, System.String mainPath); // 0x069315d4
	System.Void RefreshHpChange(); // 0x06931e28
	System.Void RefreshState(); // 0x06931ee0
	System.Void RefreshGpuinst(); // 0x06932048
	System.Void Clear(); // 0x069321cc
	System.Void PlayOreShatter(); // 0x06932398
	System.Void ShatteredGoLoadFinish(UnityEngine.GameObject instGo, System.Object[] owner); // 0x06932b7c
	System.Void SetShatterMaterial(System.Int64 tempId, UnityEngine.GameObject shatterGameObject); // 0x06933014
	System.Void .ctor(); // 0x0693338c
	static System.Void .cctor(); // 0x06933418
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.ClientOreGo.<>c__DisplayClass17_0 : System.Object
{
	RayFire.RayfireBomb rootRigidBomb; // 0x10
	System.String path; // 0x18
	UnityEngine.GameObject instGo; // 0x20
	System.Void .ctor(); // 0x06932fac
	System.Void <ShatteredGoLoadFinish>b__0(); // 0x06933508
	System.Void <ShatteredGoLoadFinish>b__1(); // 0x069335c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.ClientSceneItemGo : WizardGames.Soc.Common.Unity.Go.BaseSceneItemGo
{
	WizardGames.Soc.Common.Unity.Effect.EffectProfile effectProfile; // 0x70
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x069336c0
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x0693384c
	System.Boolean CanPick(UnityEngine.Vector3 playerPos); // 0x06933d7c
	System.Void Remove(); // 0x06934404
	System.Void .ctor(); // 0x06934564
	System.Void <Remove>b__4_0(UnityEngine.GameObject root); // 0x069345f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.ClientSpecializedVehicleGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo, WizardGames.Soc.Common.Unity.Go.ISmoothGo
{
	Go.GoComp.SmoothComp <SmoothComp>k__BackingField; // 0x68
	System.Int64 transformChangeEventHandle; // 0x70
	WizardGames.Soc.Common.SpecializedVehicle _specializedVehicle; // 0x78
	System.Int64 _curPatrolStateSubscribeId; // 0x80
	System.Int64 _curPatrolMoveSubscribeId; // 0x88
	System.Boolean _isNight; // 0x90
	UnityEngine.Quaternion _frontLeftWheelRelativeRotation; // 0x94
	UnityEngine.Quaternion _frontRightWheelRelativeRotation; // 0xa4
	UnityEngine.Quaternion _transformRotation; // 0xb4
	System.Single _targetTurning; // 0xc4
	System.Single _vehicleRotationX; // 0xc8
	System.Single _vehicleRotationY; // 0xcc
	System.Collections.Generic.List<System.UInt32> audioIds; // 0xd0
	WizardGames.Soc.Common.Component.PatrolComponent _patrolComp; // 0xd8
	UnityEngine.Transform _rootBone; // 0xe0
	WizardGames.Soc.Common.Entity.SpecializedVehicleEntity get_SpecializedVehicleEntity(); // 0x06934680
	WizardGames.Soc.Common.Entity.IEntity get_GetEntity(); // 0x06934778
	Go.GoComp.SmoothComp get_SmoothComp(); // 0x06934810
	System.Void set_SmoothComp(Go.GoComp.SmoothComp value); // 0x06934874
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.SpecializedVehicleEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x069348f4
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x06934a78
	System.Void PostEventFinishedCallback(WizardGames.Soc.SocClient.Audio.WWise.AudioEventData audioeventdata, System.Object obj); // 0x0693531c
	System.Void ComponentInit(); // 0x06934ee8
	System.Void InitVariable(); // 0x06935018
	System.Void OnCurPatrolMoveChanged(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Boolean oldValue, System.Boolean newValue); // 0x069354c8
	System.Void OnCurPatrolStateChanged(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int32 oldValue, System.Int32 newValue); // 0x06935414
	System.Void SetDestroying(); // 0x069355d8
	System.Void SetSmoothProp(); // 0x06935690
	System.Void UpdateTransform(); // 0x069356f8
	System.Void SpecializedVehicleWheelRot(); // 0x0693599c
	System.Void UpdatePassenger(); // 0x06935f5c
	static System.Void UpdateTurretMonster(UnityEngine.Vector3 position, WizardGames.Soc.SocClient.Go.TurretMonsterGo turretMonsterGo, UnityEngine.Quaternion rotation); // 0x069370e8
	System.Void UpdateLightShowStateByTimePerid(); // 0x06937050
	System.Void SetLightStageState(System.Boolean isNight); // 0x069372a0
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x06934e5c
	System.Void StopAudio(); // 0x06937444
	System.Void Clear(); // 0x06937618
	System.Void Remove(); // 0x06937698
	System.Void .ctor(); // 0x06937884
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.ClientTempCofferGo : WizardGames.Soc.Common.Unity.Go.BaseTempCofferGo
{
	
	System.Void .ctor(); // 0x069379e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.ClientThrownEntityGo : WizardGames.Soc.Common.Unity.Go.BaseThrownEntityGo, WizardGames.Soc.Common.Unity.Go.ISmoothGo, WizardGames.Soc.Common.Unity.Go.IServerEntity, WizardGames.Soc.Common.Unity.Go.IPickableGo, WizardGames.Soc.Common.Unity.Go.IEntityGo
{
	System.String SoundPreBoomPath; // 0xd8
	Effect.EffectItemHandle<Effect.EffectItem> attachEffectHandle; // 0xe0
	Effect.EffectItemHandle<Effect.FollowEffect> followEffectHandle; // 0xf0
	System.String attachSound; // 0x100
	WizardGames.Soc.SocClient.Ui.ThrownTipData _thrownTipData; // 0x108
	UnityEngine.Transform hitBox; // 0x110
	WizardGames.Soc.Common.Data.Display.ThrowDisplay thrownDisplayTb; // 0x118
	System.Collections.Generic.LinkedList<WizardGames.Soc.Common.Entity.HistoryThrowEntity> predictResultHistory; // 0x120
	System.Int64 lastSaveHistoryTime; // 0x128
	System.Single lastCompareMoveTime; // 0x130
	System.Boolean useServerPos; // 0x134
	System.Boolean useServerPosWhenServerHit; // 0x135
	System.Single lastSaveMoveTime; // 0x138
	WizardGames.Soc.Common.Combat.TriggerWrap fuseTrigger; // 0x140
	UnityEngine.GameObject emitterGo; // 0x148
	WizardGames.Soc.Common.CustomType.IItemWithFrequency transmitterHeldItem; // 0x150
	System.Single flashingTimer; // 0x158
	static System.Single flashingTime = 0.10000000149011612;
	System.Int32 updateThrowUITimer; // 0x15c
	static System.Int32 updateThrowUITime = 200;
	System.Boolean showThrowTipUI; // 0x160
	System.Boolean showRFDetonationUI; // 0x161
	System.Boolean IsPredictEntity(); // 0x06937a48
	System.Int64 GetServerEntityId(); // 0x06937af8
	System.Boolean CanDefuse(); // 0x06937ba0
	System.Boolean IsFuseSetup(); // 0x06937cc4
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x06937db0
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x06937f3c
	System.Void LoadEffect(); // 0x06938924
	System.Void LoadRFTriggeredEffect(WizardGames.Soc.Common.Entity.ThrownEntity thrownEntity); // 0x069390d4
	System.Void ClearRFTriggeredEffect(WizardGames.Soc.Common.Entity.ThrownEntity thrownEntity); // 0x06939258
	System.Void RFTriggeredChanged(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, System.Boolean oldValue, System.Boolean newValue); // 0x069393c8
	System.Void SetServerEntity(WizardGames.Soc.Common.Entity.ThrownEntity serverEntity); // 0x069394f4
	System.Void RefreshColliderConfig(); // 0x06939ea8
	System.Void FollowEffectIdChanged(WizardGames.Soc.Share.Framework.CustomTypeBase arg1, System.Int32 oldValue, System.Int32 newValue); // 0x069399e0
	System.Void CanPickUpChanged(WizardGames.Soc.Share.Framework.CustomTypeBase arg1, System.Boolean oldValue, System.Boolean newValue); // 0x06939d44
	System.Void DurationChanged(WizardGames.Soc.Share.Framework.CustomTypeBase arg1, System.Single oldValue, System.Single newValue); // 0x06939fc8
	System.Void OnSwitchWeaponSuccess(System.Int64 oldWeaponId, System.Int64 weaponID); // 0x0693a334
	System.Void UpdateTransmitterNode(WizardGames.Soc.Common.Entity.IHeldItemEntity heldItemEntity); // 0x06939b78
	System.Void InitFuseTrigger(); // 0x069398fc
	System.Void OnFuseSetup(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x0693a428
	System.Void TrySetupLandMine(); // 0x06938408
	System.Void TrySyncPosition(); // 0x0693a4bc
	System.Void OnEntityCountChange(System.Int32 oldValue, System.Int32 newValue); // 0x0693a6d8
	System.Void ClearEffect(); // 0x0693a928
	System.Void Clear(); // 0x0693aacc
	System.Void ShowRFFlashing(); // 0x0693b6c0
	System.Void SavePredictHistory(); // 0x0693b81c
	System.Void RemovePredictHistory(System.Single time, System.Boolean clearAll); // 0x0693b230
	WizardGames.Soc.Common.Entity.HistoryThrowEntity FindHistoryThrowEntity(System.Single time); // 0x0693beb0
	System.Void ComparePredictResult(); // 0x0693c010
	System.Void Update(); // 0x0693c3c4
	System.Void UpdateSmoothPosition(System.Int32 interval); // 0x0693cb20
	System.Void UpdateThrowUI(System.Int32 interval); // 0x0693c4ec
	System.Boolean CanPick(UnityEngine.Vector3 playerPos); // 0x0693db28
	System.Void CalculatePosAndForward(); // 0x0693d194
	System.Void CalculateServerPosAndForward(); // 0x0693d5bc
	System.Void OnCollisionHit(WizardGames.Soc.Common.Combat.SocRaycastHit hitInfo); // 0x0693e04c
	System.Void HideAndStopMove(); // 0x0693e3d0
	System.Void PlaySoundOnHit(); // 0x0693e4bc
	System.Void PlaySoundOnFuse(); // 0x0693a774
	System.Void .ctor(); // 0x0693e6d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.ClientTreeGo : WizardGames.Soc.Common.Unity.Go.BaseTreeGo
{
	
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.TreeEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x0693e7f4
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0693eab0
	System.Void SetMainGo(UnityEngine.GameObject obj); // 0x0693ec3c
	System.Void Remove(); // 0x0693ee14
	System.Single get_PosX(); // 0x0693eed8
	System.Single get_PosY(); // 0x0693ef5c
	System.Single get_PosZ(); // 0x0693efe0
	System.Void .ctor(); // 0x0693f064
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.ClientVehicleGo : WizardGames.Soc.Common.Unity.Go.BaseVehicleGo
{
	static BasePlayer basePlayer; // 0x0
	WizardGames.Soc.Common.Entity.VehicleEntity serverEntity; // 0x170
	WizardGames.Soc.Common.Entity.VehicleEntity clientEntity; // 0x178
	System.Collections.Generic.List<System.Int64> damageCompSubscribeId; // 0x180
	System.Boolean HasPreloadCorpse; // 0x188
	Effect.EffectItemHandle<Effect.FollowEffect> boatEffectStable; // 0x190
	Effect.EffectItemHandle<Effect.FollowEffect> boatEffectMove; // 0x1a0
	System.Action _renderUpdate; // 0x1b0
	WizardGames.Soc.Common.Entity.IEntity get_GetEntity(); // 0x0693f0f0
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0693f154
	System.Void SetMainGo(UnityEngine.GameObject obj); // 0x0693facc
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x0552af00
	System.Void OnDriverIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x06940344
	System.Void OnAfterInit(); // 0x0693fe64
	System.Void Predict(System.Int32 deltaTime, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, System.Int32 physicTickTime, System.Int32 allPhysicTime); // 0x06940688
	WizardGames.Soc.Common.Unity.Go.MountableAuthoritySide GetAuthoritySide(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06940818
	System.Void LodUpdate(System.Int32 deltaTime); // 0x069409f0
	System.Boolean IsValid(); // 0x06940adc
	System.Void UnlimitedUpdate(System.Int32 deltaTime); // 0x0694105c
	System.Void OnBoatSpawn(); // 0x069404c8
	System.Void OnCH47ScientistSpawn(); // 0x069405d0
	System.Void MotorRowBoatRenderUpdate(); // 0x06941198
	System.Void HandleBoatFx(BaseBoat boat, System.Int32 stableTableId, System.Int32 moveTableId, System.Single moveSpeed, UnityEngine.Transform waterDetectTrans, UnityEngine.Transform followTrans); // 0x069414c0
	System.Void KayakRenderUpdate(); // 0x06941d9c
	System.Void MiniCopterClientRenderUpdate(); // 0x06941fa4
	System.Void MiniCopterPedalRot(); // 0x06942a00
	System.Void MiniCopterWheelRot(MiniCopter miniCopter); // 0x06942590
	System.Void MiniCopterUpdateWindShader(MiniCopter miniCopter); // 0x069423cc
	System.Void MiniCopterChangeHLod(MiniCopter miniCopter); // 0x06942080
	System.Boolean CanVehicleEngineAndOilInteractive(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06942d90
	System.Boolean CanVehicleStorageInteractive(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06942f30
	System.Boolean CanRepairInteractive(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x069430d8
	System.Void OnMaxHpChange(WizardGames.Soc.Common.Component.DamageableComponent server, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Component.DamageableComponent local); // 0x069431b0
	System.Void OnHpChange(WizardGames.Soc.Common.Component.DamageableComponent server, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Component.DamageableComponent local); // 0x06943614
	System.Void HandleHpAndMaxHpChange(WizardGames.Soc.Common.Component.DamageableComponent local); // 0x06943268
	System.Void Clear(); // 0x069436cc
	System.Void Remove(); // 0x06943cd8
	System.Void .ctor(); // 0x06943d48
	static System.Void .cctor(); // 0x06943e20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.ClientVehicleGo.<>c__DisplayClass10_0 : System.Object
{
	WizardGames.Soc.SocClient.Go.ClientVehicleGo <>4__this; // 0x10
	WizardGames.Soc.Common.Entity.IHitableEntity hitable; // 0x18
	WizardGames.Soc.Common.Component.VehicleDamageableComponent damageable; // 0x20
	System.Void .ctor(); // 0x069402dc
	System.Void <OnInit>b__0(WizardGames.Soc.Share.Framework.CustomTypeBase server, System.Single oldValue, System.Single newValue); // 0x06943e9c
	System.Void <OnInit>b__1(WizardGames.Soc.Share.Framework.CustomTypeBase server, System.Single oldValue, System.Single newValue); // 0x06943f94
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.ClientVehicleModuleGo : WizardGames.Soc.Common.Unity.Go.BaseVehicleModuleGo
{
	UnityEngine.GameObject lockGo; // 0x190
	WizardGames.Soc.Common.Data.Vehicle.VehicleModule tbVehicleModule; // 0x198
	System.String partPath; // 0x1a0
	UnityEngine.GameObject partGo; // 0x1a8
	System.UInt64 partAsyncId; // 0x1b0
	static BasePlayer basePlayer; // 0x0
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0694408c
	System.Void WaitModularCar(UnityEngine.GameObject mainGo); // 0x06944390
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x06944218
	System.Void OnHpChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x06945088
	System.Void OnDriverIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x069451c8
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x06944bec
	System.Void UpdateRendererAndLod(); // 0x0694534c
	System.Void OnPartLoaded(UnityEngine.GameObject go, System.Object[] param); // 0x06945a70
	System.Void AddPart(); // 0x069457a8
	System.Void SetLockGoActive(System.Boolean active); // 0x069456d4
	System.Void OnAfterInit(); // 0x06944f80
	System.Void LightChanged(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x06945e18
	System.Void Clear(); // 0x06945ebc
	System.Void Remove(); // 0x06946330
	System.Void LodUpdate(System.Int32 deltaTime); // 0x069463a0
	System.Void UnlimitedUpdate(System.Int32 deltaTime); // 0x06946758
	System.Void ModularCarPedalRot(); // 0x0694645c
	System.Boolean CanMove(); // 0x069468e0
	UnityEngine.GameObject LinkModuleWithModularCar(WizardGames.Soc.Common.Entity.IVehicleModuleCustom vme, WizardGames.Soc.Common.Unity.Go.IEntityGo carGo); // 0x06944858
	System.Boolean CanLockInteractive(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06946950
	System.Boolean CanRepairInteractive(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x069469d0
	System.Boolean CanVehicleEngineAndOilInteractive(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06946a50
	System.Boolean CanVehicleStorageInteractive(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06946ad0
	System.String GetMountableDisplayName(); // 0x06946c64
	System.Boolean HasDriverSeat(); // 0x06946cd4
	System.Boolean HasPassengerSeat(); // 0x06946d44
	System.Void Predict(System.Int32 deltaTime, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, System.Int32 physicTickTime, System.Int32 allPhysicTime); // 0x06946db4
	WizardGames.Soc.Common.Unity.Go.MountableAuthoritySide GetAuthoritySide(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x06946f34
	System.Void .ctor(); // 0x0694711c
	static System.Void .cctor(); // 0x069471a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.ClientVehicleModuleGo.<>c__DisplayClass7_0 : System.Object
{
	WizardGames.Soc.SocClient.Go.ClientVehicleModuleGo <>4__this; // 0x10
	UnityEngine.GameObject mainGo; // 0x18
	System.Void .ctor(); // 0x069447f0
	System.Void <WaitModularCar>b__0(System.Int64 id, System.Object data, System.Boolean delete); // 0x06947224
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.ClientZiplineGo : WizardGames.Soc.Common.Unity.Go.BaseZiplineGo
{
	UnityEngine.Transform speedUpFx; // 0x1e0
	System.Boolean speedup; // 0x1e8
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x069472c4
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x0694745c
	System.Void Update(); // 0x069478f4
	System.Void UpdateRender(); // 0x069476ec
	UnityEngine.Vector3 GetMountPos(System.Int32 index); // 0x06947964
	UnityEngine.Quaternion GetMountRotation(System.Int32 index); // 0x06947e44
	System.Void Clear(); // 0x06947f30
	System.Void Remove(); // 0x06948084
	System.Void .ctor(); // 0x069480f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.CorpseGo : WizardGames.Soc.Common.Unity.Go.BaseCorpseGo, WizardGames.Soc.Common.Unity.Go.ISmoothGo, WizardGames.Soc.Common.Unity.Go.IEquipOwnerGo
{
	static System.Collections.Generic.Dictionary<System.Int64,System.Int32> PlayerWearItemCountDic; // 0x0
	static System.String DeathStateName = "DeadState";
	WizardGames.Soc.SocClient.Go.MonsterGo hostMonster; // 0xa0
	UnityEngine.GameObject Root; // 0xa8
	UnityEngine.Transform interaction; // 0xb0
	UnityEngine.Transform modelTransform; // 0xb8
	WizardGames.Soc.Common.Unity.Monster.GeneralConfig generalConfig; // 0xc0
	WizardGames.Soc.Common.Unity.Corpse.CorpseBuoyancy buoyancy; // 0xc8
	UnityEngine.Transform allRootTrans; // 0xd0
	UnityEngine.Transform centerTrans; // 0xd8
	System.Boolean needBlend; // 0xe0
	WizardGames.Soc.Common.Entity.ICorpseableEntity CorpseableEntity; // 0xe8
	UnityEngine.Bounds checkCollsionBounds; // 0xf0
	UnityEngine.Animator corpseAnimator; // 0x108
	System.Boolean needUpdateBone; // 0x110
	System.Int64 transformChangedId; // 0x118
	System.Boolean playDeathAnim; // 0x120
	WizardGames.Soc.SocClient.GoLoader.PartModelController partModelController; // 0x128
	System.Int32 <SmoothLod>k__BackingField; // 0x130
	Go.GoComp.SmoothComp <SmoothComp>k__BackingField; // 0x138
	WizardGames.Soc.Common.Data.tips.HighLightConfig get_highLightConfig(); // 0x06948180
	WizardGames.Soc.Common.Entity.CorpseEntity get_corpseEntity(); // 0x0694828c
	UnityEngine.Bounds get_CheckCollisionBounds(); // 0x06948384
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.CorpseEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x06948408
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x06948810
	System.Void SetMainGo(UnityEngine.GameObject mainGo, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x06948dc4
	System.Void InitPlayerCorpseGo(System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x069491ac
	System.Void InitMonsterCorpseGo(); // 0x06949884
	System.Void PlayAnimatorState(System.String animatorStateName, System.Single normalizedTime); // 0x06949ab8
	System.Void .ctor(); // 0x0694a0e4
	System.Void PackCorpse(); // 0x06949ca4
	System.Void UnPackCorpse(); // 0x0694a170
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x06948a78
	System.Void UpdateBoneTransform(); // 0x06949d20
	System.Void UpdateEquips(System.Collections.Generic.List<System.Int64> equipTables, System.Collections.Generic.Dictionary<System.Int64,System.Int64> skins); // 0x0694a2a0
	System.Void Clear(); // 0x0694a35c
	System.Void Remove(); // 0x0694a65c
	System.Boolean IsChinaVersion(); // 0x0694a6cc
	System.Void UpdateEntityAttributes(); // 0x06948f80
	System.Void UpdateRemainHp(WizardGames.Soc.Share.Framework.CustomTypeBase data, System.Single oldValue, System.Single newValue); // 0x0694a7b4
	System.Void OnTransformChanged(WizardGames.Soc.Share.Framework.PositionChangeEvent e); // 0x0694a878
	UnityEngine.Vector3 GetMyPlayerPosition(); // 0x0694aa94
	System.Void UpdateOn1Fps(System.Int64 time); // 0x0694abc8
	System.Void UpdateAnimDeathState(); // 0x0694ad98
	System.Void DeathStable(); // 0x0694b17c
	System.Void CheckCorpse(); // 0x0694ae5c
	System.Boolean IsReadyForCorpseRender(); // 0x0694b224
	System.Boolean ShouldSkipSmooth(); // 0x0694b37c
	System.Void InitPhysics(); // 0x0694b420
	WizardGames.Soc.Common.Entity.IEntity get_GetEntity(); // 0x0694b4e4
	Go.GoComp.SmoothComp get_SmoothComp(); // 0x0694b57c
	System.Void set_SmoothComp(Go.GoComp.SmoothComp value); // 0x0694b5e0
	static System.Void .cctor(); // 0x0694b660
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.DigGo : WizardGames.Soc.Common.Unity.Go.BaseDigGo
{
	UnityEngine.GameObject engine; // 0x88
	UnityEngine.GameObject output; // 0x90
	UnityEngine.GameObject input1; // 0x98
	UnityEngine.GameObject input2; // 0xa0
	System.Single boundingXZ; // 0xa8
	System.Single boundingY; // 0xac
	UnityEngine.Renderer meshRenderer; // 0xb0
	UnityEngine.Material scrollMaterial; // 0xb8
	System.Int32 _deltaUvHash; // 0xc0
	System.Single beltSpeed; // 0xc4
	System.Single idleBeltSpeed; // 0xc8
	System.Single setBeltSpeed; // 0xcc
	System.Single lastChangeSpeedTime; // 0xd0
	FxEvent fxEvent; // 0xd8
	System.Single digMaxSpeed; // 0xe0
	System.Single digTimeSec; // 0xe4
	System.Collections.Generic.List<UnityEngine.GameObject> listInteractionObj; // 0xe8
	static System.String quarryAudioPath; // 0x0
	static System.String pumpjackAudioPath; // 0x8
	System.Int64 speedChangeTimerHandle; // 0xf0
	System.Int64 scrollChangeTimerHandle; // 0xf8
	System.Single totalOffset; // 0x100
	WizardGames.Soc.Common.Unity.Config.DigConfig digConfig; // 0x108
	static SocLogger logger; // 0x10
	System.Void .ctor(); // 0x0694b6fc
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.DigEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x0694b7dc
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0694ba54
	System.Void SetMainGo(UnityEngine.GameObject obj); // 0x05523a54
	System.Void SetRenderBounds(UnityEngine.SkinnedMeshRenderer skinMeshRenderer); // 0x0694c8dc
	System.Void DigStateChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Boolean oldValue, System.Boolean newValue); // 0x0694cae8
	System.Void OnIdleBeltSpeedChange(System.Single speed); // 0x05513724
	System.Void ScrollSpeedChangeCb(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x0694d160
	System.Void TryCancelSpeedChangeTimer(); // 0x0694d058
	System.Void TryCancelScrollChangeTimer(); // 0x0694c9e0
	System.Void BeltSpeedChangeCb(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x0694d2cc
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x0694d4fc
	System.Collections.Generic.List<UnityEngine.GameObject> GetInteraction(); // 0x0694d808
	System.Void Clear(); // 0x0694db08
	System.Void Remove(); // 0x0694dd00
	static System.Void .cctor(); // 0x0694dd70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.DisposalTrigger : UnityEngine.MonoBehaviour
{
	WizardGames.Soc.SocClient.Go.ClientThrownEntityGo EntityGo; // 0x30
	UnityEngine.Collider collider; // 0x38
	WizardGames.Soc.Common.Combat.ColliderConfig colliderConfig; // 0x40
	System.Boolean Init; // 0x48
	System.Void OnEnable(); // 0x0694dea8
	System.Void OnDisable(); // 0x0694df60
	System.Void BindEntity(WizardGames.Soc.SocClient.Go.ClientThrownEntityGo go); // 0x0694e0ec
	System.Void OnTriggerEnter(UnityEngine.Collider co); // 0x0694e16c
	System.Void OnTriggerEnter(); // 0x0694e3b8
	System.Void OnTriggerExit(UnityEngine.Collider co); // 0x0694e620
	System.Void OnTriggerExit(); // 0x0694e8fc
	System.Void ClearInteractive(); // 0x0694dfd8
	System.Void .ctor(); // 0x0694e960
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.EffectGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo, WizardGames.Soc.Common.Unity.Go.ISmoothGo
{
	Effect.EffectItem EffectItem; // 0x68
	System.String _goName; // 0x70
	Go.GoComp.SmoothComp <SmoothComp>k__BackingField; // 0x78
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.EffectEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x0694e9c8
	WizardGames.Soc.Common.Entity.EffectEntity get_EffectEntity(); // 0x0694ea68
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0694eb5c
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x0694ece8
	System.Void Remove(); // 0x0694edc8
	WizardGames.Soc.Common.Entity.IEntity get_GetEntity(); // 0x0694ee50
	Go.GoComp.SmoothComp get_SmoothComp(); // 0x0694eee8
	System.Void set_SmoothComp(Go.GoComp.SmoothComp value); // 0x0694ef4c
	System.Void UpdatePosition(); // 0x0694efcc
	System.Void .ctor(); // 0x0694f19c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.ElevatorGo : WizardGames.Soc.Common.Unity.Go.BaseElevatorGo, WizardGames.Soc.Common.Unity.Go.ISmoothGo
{
	System.Collections.Generic.Dictionary<System.String,UnityEngine.GameObject> cacheGoDic; // 0x80
	System.Collections.Generic.Dictionary<System.String,UnityEngine.MeshRenderer> cacheMeshRendererDic; // 0x88
	System.Collections.Generic.Dictionary<System.String,UnityEngine.Material> cacheMaterialDic; // 0x90
	UnityEngine.Animator animator; // 0x98
	UnityEngine.GameObject btnPressed; // 0xa0
	UnityEngine.GameObject Root; // 0xa8
	System.Int64 disableTimer; // 0xb0
	static System.String btnPressTimerMark; // 0x0
	System.Int64 btnPressedTimerHandle; // 0xb8
	UnityEngine.GameObject airWall; // 0xc0
	System.Boolean isMoving; // 0xc8
	Go.GoComp.SmoothComp <SmoothComp>k__BackingField; // 0xd0
	System.Void .ctor(); // 0x0694f228
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.ElevatorEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x0694f3c8
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0694f6ac
	System.Void Clear(); // 0x0694fbf8
	System.Void Remove(); // 0x06950158
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x0694f838
	System.Void SubscribePropertyChange(); // 0x06950518
	System.Void UnsubscribePropertyChange(); // 0x0694ff28
	System.Void InitElevatorInfo(); // 0x06950254
	System.Void OnGoAdd(WizardGames.Soc.Common.Unity.Go.IEntityGo entityGo); // 0x06951004
	System.Void PackHostElevator(WizardGames.Soc.Common.Unity.Go.IEntityGo entityGo); // 0x06950dec
	System.Void EnableBtnBox(System.Boolean enabled); // 0x06950bd4
	System.Collections.Generic.List<System.Int32> GetInteractiveID(); // 0x06951298
	System.Void ShowWeakTips(System.Int32 tipsId); // 0x069515bc
	System.Void AudioEvent(System.String audioEventName, System.Boolean stop); // 0x069516e0
	System.Void ResetCb(System.Int64& timerId); // 0x069519b4
	System.Void TryCancelBtnPressedTimer(); // 0x0694fec0
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x06951ad4
	System.Void OnMoveStart(); // 0x069501c8
	System.Void CheckMoveFinish(); // 0x06951bd4
	System.Void OnElevatorMoveFinish(System.Boolean force); // 0x06951d00
	System.Void OnSetBtnPressed(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldState, System.Boolean newState); // 0x06951ed4
	System.Void SetBtnPressed(); // 0x055049cc
	System.Void BtnPressedCb(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x06951f8c
	System.Void SetDoorOpen(System.Boolean open); // 0x06952210
	System.Void DisableAnimator(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x0695263c
	System.Void OnEndPosYChanged(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldState, System.Single newState); // 0x06952a90
	System.Void OnEndPosYChanged(System.Boolean initOpen); // 0x06950af0
	System.Void OnSetDoorOpen(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldState, System.Boolean newState); // 0x06950748
	WizardGames.Soc.Common.Entity.IEntity get_GetEntity(); // 0x06952b44
	Go.GoComp.SmoothComp get_SmoothComp(); // 0x06952bdc
	System.Void set_SmoothComp(Go.GoComp.SmoothComp value); // 0x06952c40
	static System.Void .cctor(); // 0x06952cc0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.FuseTrigger : UnityEngine.MonoBehaviour
{
	System.Collections.Generic.HashSet<System.Int64> entitySet; // 0x30
	WizardGames.Soc.SocClient.Go.ClientThrownEntityGo owner; // 0x38
	System.Void BindEntity(WizardGames.Soc.SocClient.Go.ClientThrownEntityGo go); // 0x06952d28
	System.Void Overlap(); // 0x06952da8
	System.Void OnTriggerEnter(UnityEngine.Collider co); // 0x0695302c
	System.Void OnTriggerExit(UnityEngine.Collider co); // 0x0695349c
	System.Void ShowOnGoingTip(); // 0x06953894
	System.Void OnEntityEnter(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06953208
	System.Void OnEntityExit(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06953678
	System.Void OnDisable(); // 0x069539b0
	System.Void .ctor(); // 0x06953c24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.InteractionGo : WizardGames.Soc.Common.Unity.Go.BaseInteractionGo
{
	System.Int64 interactTimerId; // 0x68
	System.Int64 _trainUnloadCountChange; // 0x70
	System.Collections.Generic.List<Effect.EffectItem> _effects; // 0x78
	System.String _unloadPipeAudio; // 0x80
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Data.units.InteractObj get_TemplateData(); // 0x06953cd8
	System.Int32 get_InteractType(); // 0x06953de4
	System.Single get_InteractiveCd(); // 0x06953e58
	System.Boolean get_interruptible(); // 0x06953ecc
	System.Void .ctor(); // 0x06953f40
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.InteractionEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x06954028
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x069542a0
	System.Void OnTrainUnloadCountChange(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, System.Int32 oldValue, System.Int32 newValue); // 0x06954774
	System.Void ClearEffects(); // 0x06954f30
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x06954600
	System.Boolean InteractionCheck(); // 0x06955120
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x069552c8
	System.Void LeaveScope(); // 0x0695623c
	System.Void StopInteract(); // 0x069562bc
	System.Void Clear(); // 0x069564dc
	System.Void Remove(); // 0x069566c8
	static System.Void .cctor(); // 0x06956738
	System.Void <OnUiBtnClicked>b__21_0(); // 0x0695680c
	System.Void <OnUiBtnClicked>b__21_1(); // 0x069569c8
	System.Void <OnUiBtnClicked>b__21_2(); // 0x06956b48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.IOGo : WizardGames.Soc.Common.Unity.Go.BaseIOGo
{
	WizardGames.Soc.SocClient.StateMachine.IOState curIOState; // 0xc0
	System.Int32 curStateID; // 0xc8
	System.Int32 preStateID; // 0xcc
	System.Collections.Generic.Dictionary<System.String,UnityEngine.GameObject> cacheGoDic; // 0xd0
	System.Collections.Generic.Dictionary<System.String,UnityEngine.MeshRenderer> cacheMeshRendererDic; // 0xd8
	System.Collections.Generic.Dictionary<System.String,WizardGames.AssetPool.AssetPoolHandle> cacheMaterialDic; // 0xe0
	UnityEngine.Animation mAnimationCom; // 0xe8
	static System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.ComWorldFlagIO> iOHudDic; // 0x0
	System.String curPlayWwiseEvent; // 0xf0
	System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform> mCacheTransform; // 0xf8
	System.String kSocketRootPath; // 0x100
	UnityEngine.Transform mSocketTrans; // 0x108
	System.Boolean mIsInitOutLineCom; // 0x110
	WizardGames.Soc.Common.Data.IOInteractiveEnum.IOType ioType; // 0x114
	EPOOutline.Outlinable outlinable; // 0x118
	static SocLogger <log>k__BackingField; // 0x8
	UnityEngine.Vector3 ioEntityPos; // 0x120
	System.Single hudCheckDistance; // 0x12c
	UnityEngine.Vector3 ioRenderPosYOffset; // 0x130
	System.Collections.Generic.HashSet<System.String> loadingMatQueue; // 0x140
	System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.String>> waitingChangeMatRenderDic; // 0x148
	UnityEngine.Rendering.Universal.ObjectRenderInfo renderInfo; // 0x150
	WizardGames.Soc.Common.Entity.IOEntity get_ioEntity(); // 0x06956cc8
	WizardGames.Soc.Common.Component.GpuInstComponent get_gpuInst(); // 0x06956dc0
	WizardGames.Soc.Common.Data.units.IOInteractiveHUD get_HudConfig(); // 0x06956e58
	System.Int64 GetFirstInactivatedIOID(); // 0x06957124
	WizardGames.Soc.SocClient.Go.IOGo GetInputIOGoInSameLevelSeparate(WizardGames.Soc.SocClient.Go.IOGo curIOGo); // 0x0695728c
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.IOEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x0695752c
	System.Void Clear(); // 0x069577a4
	System.Void Remove(); // 0x06957d08
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x06957d78
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x06957f00
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x06957ff8
	System.Void UpdateEntityAttributes(); // 0x06958688
	System.Void OnIsShowElectricShockChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Boolean oldValue, System.Boolean newValue); // 0x0695873c
	System.Void OnStateIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int32 oldValue, System.Int32 newValue); // 0x069588e8
	System.Void CheckOutLineCom(); // 0x0695847c
	System.Void ShowHideTargetGo(System.String[] goPaths, System.Boolean isShow); // 0x06958e44
	System.Void ChangeMaterial(System.String materialPath, System.String meshRenderPath); // 0x0695905c
	System.Void ChangeMaterial(System.String materialPath, WizardGames.AssetPool.AssetPoolHandle matHandle); // 0x06959174
	System.Void SetMaterial(System.String meshRenderPath, WizardGames.AssetPool.AssetPoolHandle material); // 0x06959338
	System.Void SetAnimatorParam(System.String key, System.Int32 value); // 0x069595e0
	System.Collections.Generic.List<System.Int32> GetInteractiveID(); // 0x069599d4
	System.Collections.Generic.List<System.Int32> GetShowInteractiveID(); // 0x06959ae0
	System.Void Tick(); // 0x06959d2c
	System.Void UpdateAnimationActiveState(); // 0x06959f34
	System.Void CheckIsNeedRemoveHud(); // 0x06958be0
	System.Boolean CheckAndShowHUD(); // 0x0695a0dc
	System.Boolean IsCameraFrontVisible(UnityEngine.Vector3 worldPos, UnityEngine.Transform camTransform); // 0x0695a504
	System.Boolean CheckBlock(); // 0x0695a70c
	System.Void PlayAudio(System.String audioWwiseEvent); // 0x0695aa08
	Effect.EffectItemHandle<Effect.EffectItem> PlayEffect(System.Int32 effectID, System.String effectRoot); // 0x0695aafc
	System.Void OpenCloseDoor(System.Int32 animationValue); // 0x055056e8
	System.Void OpenDoorTick(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x0695b140
	System.Void CloseDoorTick(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x0695b368
	System.Void CancelOpenTimer(); // 0x0695b264
	System.Boolean get_needGpuRender(); // 0x06957c98
	System.Void EnableOutline(UnityEngine.Color color, System.Single dilateShift, System.Single blurShift, System.Int32 lodLevel); // 0x0695b48c
	System.Void DisableOutline(); // 0x0695b6f4
	System.Void OnRenderConditionChange(); // 0x069585b8
	System.Boolean CanAddToGPURenderer(System.Boolean isDefault); // 0x0695b9d0
	System.Boolean CanRemoveFromGPURenderer(System.Boolean isDefault); // 0x0695bab0
	System.Boolean StateIsDefault(); // 0x0695b8c8
	System.Void OnOutlineCreateOrDestroy(System.Boolean enable); // 0x0695bb90
	System.Void .ctor(); // 0x0695bd50
	static System.Void .cctor(); // 0x0695c098
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.IOGo.<>c__DisplayClass48_0 : System.Object
{
	WizardGames.Soc.SocClient.Go.IOGo <>4__this; // 0x10
	System.String materialPath; // 0x18
	System.Void .ctor(); // 0x0695c948
	System.Void <ChangeMaterial>b__0(System.UInt64 loaderId, Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.AssetPool.AssetGroupData> results); // 0x0695c9b0
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Go.IOGo.<ChangeMaterial>d__48 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Go.IOGo <>4__this; // 0x38
	System.String materialPath; // 0x40
	System.String meshRenderPath; // 0x48
	System.Void MoveNext(); // 0x0695cb2c
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x0695d050
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.KatyushaGo : WizardGames.Soc.Common.Unity.Go.BaseKatyushaGo
{
	System.Boolean isPlaying; // 0x1ac
	System.Boolean isRotating; // 0x1ad
	System.Boolean isInLaunchCd; // 0x1ae
	System.Boolean vfxON; // 0x1af
	UnityEngine.Transform VFXTransform; // 0x1b0
	UnityEngine.GameObject aimingModule; // 0x1b8
	System.Single rotationDuration; // 0x1c0
	UnityEngine.GameObject[] missiles; // 0x1c8
	Effect.EffectItemHandle<Effect.FollowEffect> cdEffectItemHandle; // 0x1d0
	static SocLogger clientLog; // 0x0
	System.Single xAngle; // 0x1e0
	System.Single yAngle; // 0x1e4
	UnityEngine.Transform[] missilesVFXTransform; // 0x1e8
	static System.String vfxTimerStr; // 0x8
	static System.String katyushaLaunchCdTimerStr; // 0x10
	static System.String katyushaRotationTimerStr; // 0x18
	System.Int64 rotationCbHandle; // 0x1f0
	System.Int64 launchCdTimerId; // 0x1f8
	System.Collections.Generic.List<System.Int64> missileIds; // 0x200
	System.Boolean IsInLaunchCd(); // 0x0695d0d0
	System.Void .ctor(); // 0x0695d134
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x0695d284
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.KatyushaEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x0695d4bc
	System.Void Clear(); // 0x0695d85c
	System.Void Remove(); // 0x0695de90
	System.Void TryCancelRotationTimer(); // 0x0695dd84
	System.Void AudioEvent(System.String audioEventName, System.Boolean isStop); // 0x0695df00
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0695e058
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x0695e1f0
	System.Void ServerChangeTime(); // 0x0695ef2c
	System.Void InitLaunchState(); // 0x0695eba0
	System.Void DirChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Single oldValue, System.Single newValue); // 0x0695f508
	System.Void LaunchStateChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Boolean oldValue, System.Boolean newValue); // 0x0695fa58
	System.Void PlayerDyingCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int64 oldValue, System.Int64 newValue); // 0x0695fd44
	System.Void NextAllowLaunchTimeChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int64 oldValue, System.Int64 newValue); // 0x0695fdd4
	System.Void OnLaunchCdEnd(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x0695f134
	System.Void MissileCountChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int32 oldValue, System.Int32 newValue); // 0x06960308
	System.Void AimingModuleChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Boolean oldValue, System.Boolean newValue); // 0x069608f4
	System.Void RotateCartridge(UnityEngine.Vector3 newTargetDir); // 0x05514688
	System.Void CartridgeRotatingCb(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x06960b18
	System.Void OnCartridgeRotatingEnd(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x06960fb0
	System.Void StopCdEffect(); // 0x0696015c
	System.Void OnVFXOn(); // 0x0695fb94
	System.Void VFXTimerCb(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x069611cc
	System.Void PlayKatyushaCoolDownVFX(System.Boolean isInit); // 0x0695f2a0
	System.Void OnClientPlayerMounted(WizardGames.Soc.Common.Entity.PlayerEntity player); // 0x0696126c
	System.Void OnClientPlayerDismounted(WizardGames.Soc.Common.Entity.PlayerEntity player); // 0x06961750
	static System.Void .cctor(); // 0x06961b7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.MagicFieldGo : WizardGames.Soc.Common.Unity.Go.BaseMagicFieldGo
{
	System.Boolean isPlayAudio; // 0x70
	System.String wwiseEvent; // 0x78
	System.Single audioFadeTime; // 0x80
	Effect.EffectItemHandle<Effect.FollowEffect> mEffectItemHandle; // 0x88
	System.Boolean IsDestroyByMerge; // 0x98
	System.Void .ctor(); // 0x06961cd8
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.MagicFieldEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x06961d64
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x06961e04
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x06961f90
	System.Int32 GetEffectId(WizardGames.Soc.Common.Data.Combat.SkillSpellField config); // 0x06962324
	System.Void Remove(); // 0x069623f4
	System.Void Clear(); // 0x06962464
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.MgrEntityGo : WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo
{
	static SocLogger logger; // 0x0
	DelayedInstantiateComp DelayedInst; // 0xc8
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Go.IEntityGo>> entityGos; // 0xd0
	System.Collections.Generic.List<System.Int32> TickIn1Fps; // 0xd8
	System.Action<WizardGames.Soc.Common.Unity.Go.IEntityGo> <OnGoAdd>k__BackingField; // 0xe0
	System.Action<System.Int64> <OnGoRemove>k__BackingField; // 0xe8
	System.Collections.Generic.Dictionary<UnityEngine.Collider,System.Int64> _hitColliders; // 0xf0
	System.Int32 colliderLod; // 0xf8
	System.Action<WizardGames.Soc.Common.Unity.Go.IEntityGo> get_OnGoAdd(); // 0x069625b8
	System.Void set_OnGoAdd(System.Action<WizardGames.Soc.Common.Unity.Go.IEntityGo> value); // 0x0696261c
	System.Action<System.Int64> get_OnGoRemove(); // 0x0696269c
	System.Void set_OnGoRemove(System.Action<System.Int64> value); // 0x06962700
	System.Void Init(); // 0x06962780
	System.Void ClearCallbacks(); // 0x06962b24
	System.Void Destroy(); // 0x06962ef8
	System.Void OnWeaponCreate(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06962f9c
	System.Threading.Tasks.Task OnEnterWorld(); // 0x069630f0
	System.Threading.Tasks.Task OnExitWorld(); // 0x0696316c
	System.Void UpdateFull(System.Int64 snapshotSequence, System.Int64 snapshotWorldTime, System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Share.Framework.EntityBase> entities, System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.IEmbeddedCustom> embedded); // 0x06963240
	System.Void NewEntities(System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Share.Framework.EntityBase> newEntities, System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.IEmbeddedCustom> addEmbedded); // 0x06963770
	System.Void RemoveEntities(System.Collections.Generic.Dictionary<System.Int64,System.Int32> removeEntities, System.Collections.Generic.HashSet<WizardGames.Soc.Common.Entity.IEmbeddedCustom> removeEmbedded); // 0x06963840
	System.Boolean CreateGo(WizardGames.Soc.Common.Entity.IEntity entity, System.Boolean fromNet); // 0x069638d4
	System.Void OnGoLoaded(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go); // 0x06963c70
	System.Void AddEntityGo(System.Int32 entityTypeId, WizardGames.Soc.Common.Unity.Go.IEntityGo go, System.Int64 entityID); // 0x06964380
	System.Void CreateWhenGoExist(WizardGames.Soc.Common.Entity.IEntity entity, WizardGames.Soc.Common.Unity.Go.IEntityGo entityGo); // 0x0696457c
	WizardGames.Soc.Common.Unity.Go.IEntityGo GetTargetTypeGo(System.Int32 entityType, System.Int64 entityId); // 0x06964af4
	System.Boolean RemoveGo(System.Int64 entityId); // 0x06964c28
	System.Boolean OnRemoveGo(System.Int64 entityId); // 0x06964cec
	System.Boolean ClearGo(); // 0x06965368
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Go.IEntityGo> GetTargetTypeGos(System.Int32 entityType); // 0x069657dc
	System.Void AfterCreate(WizardGames.Soc.Common.Unity.Go.IEntityGo go, System.Boolean createByNet); // 0x06965890
	System.Void BeforeRemove(WizardGames.Soc.Common.Unity.Go.IEntityGo go); // 0x06965df8
	System.Boolean IsImmediateEntity(System.Int32 entityType); // 0x06966858
	System.Void UpdateMoveCollider(System.Collections.Generic.Dictionary<System.Int64,System.Int32> changedEntity); // 0x06966924
	System.Void CheckPredictEntityError(System.Int64 cmdAck); // 0x06966d28
	System.Void UpdateAiAnimation10Fps(System.Int64 time); // 0x06967230
	System.Void UpdateOn1Fps(System.Int64 time); // 0x0696741c
	System.Void UpdateOn30Fps(System.Int64 time); // 0x069676b8
	System.Void UpdateAiAnimation30Fps(System.Int64 time); // 0x0696773c
	System.String GetRootName(System.Int64 entityId); // 0x06967928
	System.Boolean IsAdd2RemoveList(WizardGames.Soc.Common.Unity.Go.IEntityGo go); // 0x069679f4
	System.Void OnDisConnect(System.Collections.Generic.List<System.Int64> entityIdList, System.Boolean force); // 0x06967b20
	System.Void RemoveRootName(System.Int64 entityId); // 0x069652cc
	System.Void .ctor(); // 0x06967c20
	static System.Void .cctor(); // 0x06967eb8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.MonsterGo : WizardGames.Soc.Common.Unity.Go.BaseMonsterGo, WizardGames.Soc.Common.Unity.Go.ISmoothGo, WizardGames.Soc.Common.Unity.Go.IMoveColliderGo, WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemHostGo
{
	static System.Collections.Generic.Dictionary<System.Int64,System.Diagnostics.Stopwatch> LoadAssetTimer; // 0x0
	static System.Boolean LoadAssetTimerEnable; // 0x8
	static SocLogger <log>k__BackingField; // 0x10
	static System.Boolean FireLog; // 0x18
	UnityEngine.Animator CurAnimator; // 0xd0
	WizardGames.Soc.Common.Unity.Monster.MonsterTimeCountDown idleTimeCountDown; // 0xd8
	static System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Monster.MonsterTimeCountDown>> MonsterGroupTimeCountDowns; // 0x20
	UnityEngine.BoxCollider screenBoxCollider; // 0xe0
	System.Single lastUpdatePosTime; // 0xe8
	UnityEngine.Vector3 lastAnimationPos; // 0xec
	System.Boolean enterDead; // 0xf8
	System.Collections.Generic.Dictionary<System.String,UnityEngine.Vector3> musclePos; // 0x100
	WizardGames.Soc.Common.Unity.Corpse.CorpseBuoyancy corpseBuoyancy; // 0x108
	System.Action<UnityEngine.Vector3> RootBoneChangeAction; // 0x110
	UnityEngine.Vector3 LastRootPos; // 0x118
	UnityEngine.Vector3 CurRootPos; // 0x124
	WizardGames.Soc.Common.Unity.Monster.Animation.MonsterTurretLine turretLine; // 0x130
	WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent RotatePitchGoPoint; // 0x138
	WizardGames.Soc.SocClient.Player.HeldItem.MonsterHostHeldItemGoController <HostHeldItemGoController>k__BackingField; // 0x140
	System.Collections.Generic.Dictionary<UnityEngine.SkinnedMeshRenderer,System.UInt32> meshRenderLayerDict; // 0x148
	System.Collections.Generic.Dictionary<UnityEngine.Renderer,UnityEngine.Material[]> recoverMats; // 0x150
	System.Collections.Generic.List<Effect.FollowEffect> followEffects; // 0x158
	WizardGames.AssetPool.AssetPoolHandle wildMatHandle; // 0x160
	WizardGames.AssetPool.AssetPoolHandle animHandle; // 0x168
	WizardGames.AssetPool.AssetPoolHandle deathAnimHandle; // 0x170
	WizardGames.Soc.Common.Unity.Utility.SocAnimOptimizationType current_anim_optimize_type; // 0x178
	System.Boolean HasAnimator; // 0x17c
	UnityEngine.GameObject <EquipWeaponFirePoint>k__BackingField; // 0x180
	UnityEngine.GameObject weaponPartGo; // 0x188
	UnityEngine.Transform weaponLightTrans; // 0x190
	System.String weaponGoPath; // 0x198
	System.String weaponAccesseryPath; // 0x1a0
	WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent weaponPointCom; // 0x1a8
	WizardGames.Soc.Common.Unity.Entity.IdHolder MonsterIdHolder; // 0x1b0
	WizardGames.Soc.Common.Data.units.MonsterTankBehavior TbTankBehavior; // 0x1b8
	WizardGames.Soc.SocClient.Go.CorpseGo CorpseGo; // 0x1c0
	System.Boolean IsSwitch2CorpseAC; // 0x1c8
	System.Int32 tickSpan; // 0x1cc
	System.Int64 timerId; // 0x1d0
	System.Int64 LastEnterAimTime; // 0x1d8
	UnityEngine.RaycastHit raycastHit; // 0x1e0
	UnityEngine.Vector3 groundSamplePos; // 0x20c
	System.Int64 lastFarSampleTime; // 0x218
	System.Int32 LastFireFrameCount; // 0x220
	WizardGames.Soc.Common.Component.ActivationComponent ActivationComp; // 0x228
	WizardGames.Soc.Common.Data.units.MonsterGunPara <TbGunParam>k__BackingField; // 0x230
	WizardGames.Soc.Common.Data.units.MonsterGunPara <TbGunParam2>k__BackingField; // 0x238
	WizardGames.Soc.Common.Data.units.MonsterGunPara <TbGunParam3>k__BackingField; // 0x240
	WizardGames.Soc.SocClient.GoLoader.PartModelController mPartModelCtrl; // 0x248
	System.Action<WizardGames.Soc.Share.Framework.CustomTypeBase,System.Int64,System.Int64> weaponIdChangeEvent; // 0x250
	System.Action<WizardGames.Soc.Share.Framework.CustomTypeBase,System.Int32,System.Int32> behaviorTemplateIdChangeEvent; // 0x258
	System.Action<WizardGames.Soc.Share.Framework.CustomTypeBase,System.Int64,System.Int64> mountableIdChangeEvent; // 0x260
	System.Action<WizardGames.Soc.Share.Framework.CustomTypeBase,System.Boolean,System.Boolean> wildChangeEvent; // 0x268
	System.Action<WizardGames.Soc.Share.Framework.CustomTypeBase,System.Byte,System.Byte> attackStateChangeEvent; // 0x270
	System.Action<WizardGames.Soc.Share.Framework.CustomTypeBase,System.Boolean,System.Boolean> activeStatusChangeEvent; // 0x278
	System.Action<WizardGames.Soc.Share.Framework.CustomTypeBase,System.Int32,System.Int32> deathAnimValueChangeEvent; // 0x280
	System.Action<UnityEngine.GameObject> partModelLoadedEvent; // 0x288
	System.Int32 <ColliderLod>k__BackingField; // 0x290
	System.Boolean <ColliderDirty>k__BackingField; // 0x294
	WizardGames.Soc.Common.Unity.Go.PrefabGo ViewGo; // 0x298
	WizardGames.Soc.Common.Unity.Go.PrefabGo ColliderGo; // 0x2a0
	UnityEngine.Vector3 moveLerpVelocity; // 0x2a8
	UnityEngine.Vector3 sampleLerpVelocity; // 0x2b4
	System.Int32 cacheLoopPlayAudioSyncSmbInsId; // 0x2c0
	System.Single[] cachePlayAudioTimes; // 0x2c8
	System.Single cachePrePlayAudioTime; // 0x2d0
	System.Int32 cachePrePlayAudioTimeIndex; // 0x2d4
	static SocLogger get_log(); // 0x06967f8c
	WizardGames.Soc.Common.Entity.IEntity get_HostEntity(); // 0x06968014
	WizardGames.Soc.SocClient.Player.HeldItem.MonsterHostHeldItemGoController get_HostHeldItemGoController(); // 0x069680ac
	System.Void set_HostHeldItemGoController(WizardGames.Soc.SocClient.Player.HeldItem.MonsterHostHeldItemGoController value); // 0x06968110
	UnityEngine.GameObject get_EquipWeaponFirePoint(); // 0x06968190
	System.Void set_EquipWeaponFirePoint(UnityEngine.GameObject value); // 0x069681f4
	System.Single get_LossyRadius(); // 0x06968274
	WizardGames.Soc.Common.Data.units.Monster get_TbMonster(); // 0x069683e0
	WizardGames.Soc.Common.Data.units.MonsterGunPara get_TbGunParam(); // 0x069684e4
	System.Void set_TbGunParam(WizardGames.Soc.Common.Data.units.MonsterGunPara value); // 0x06968548
	WizardGames.Soc.Common.Data.units.MonsterGunPara get_TbGunParam2(); // 0x069685c8
	System.Void set_TbGunParam2(WizardGames.Soc.Common.Data.units.MonsterGunPara value); // 0x0696862c
	WizardGames.Soc.Common.Data.units.MonsterGunPara get_TbGunParam3(); // 0x069686ac
	System.Void set_TbGunParam3(WizardGames.Soc.Common.Data.units.MonsterGunPara value); // 0x06968710
	System.Boolean get_IsVisible(); // 0x06968790
	static System.Void ProcessAssetTimer(WizardGames.Soc.Common.Entity.MonsterEntity entity, System.Int32 step, System.Boolean start, System.Boolean remove); // 0x06968b50
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.MonsterEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x06968fc8
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x069690f8
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x06969394
	System.Void SetMainGo(UnityEngine.GameObject obj, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0552af00
	System.Void InitColliderTrans(); // 0x0696c4e8
	System.Void OnEnterActivationVolume(System.Int32 activationId); // 0x0696c6bc
	System.Void OnExitActivationVolume(System.Int32 activationId); // 0x0696c900
	System.Void AddIdleAudio(); // 0x0696b630
	System.Void AddClientHitBoxComp(); // 0x0696b0d0
	System.Void SubscribeEntityField(); // 0x0696af10
	System.Void set_ColliderLod(System.Int32 value); // 0x0696cb5c
	System.Void set_ColliderDirty(System.Boolean value); // 0x0696cbd4
	System.Int64 get_EntityId(); // 0x06968a30
	System.Void .ctor(); // 0x0696cc50
	System.Void PostShowAction(System.Boolean show); // 0x0696ceb8
	System.Void UpdateHumanidAvatar(); // 0x0696a788
	System.Boolean get_Visible(); // 0x0696cf88
	System.Void OnPartModelLoadFinished(UnityEngine.GameObject go); // 0x0696d170
	System.Void OnInit(); // 0x0696a140
	System.Void OnCtrlOpLoaded(System.UInt64 id, WizardGames.Soc.SocClient.GoLoader.Proxy_PartModel.PartModelOperate op); // 0x0696d8a0
	System.Void OnCtrlUpdated(); // 0x0696dad8
	System.Void EquipIdsChangeCallback(WizardGames.Soc.Share.Framework.AbstractCustomList.ECustomListOpType<System.Int64> customListOpType, System.Int32 index, System.Int64 value); // 0x0696e160
	System.Void InitAttackHelicopterMonster(); // 0x0696b4c0
	System.Void UpdateBuoyancyProp(System.Boolean enable); // 0x0696d76c
	System.Void RegisterGameObjectComponent(System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0696e1f4
	System.Void AnimatorEnable(System.Boolean enable); // 0x0696dec4
	System.Void ClearWeaponAudio(); // 0x0696e5ec
	System.Void Clear(); // 0x0696ea4c
	System.Void ResetWarmupWeapon(); // 0x0696f850
	System.Void CancelTimer(); // 0x0696f74c
	System.Void Remove(); // 0x0696f928
	System.Void UpdatePosition(); // 0x0696faac
	System.Void SubscribeEntityPropertyChange(); // 0x0696fb54
	System.Void InitEntityProperty(); // 0x0696ae2c
	System.Void UnsubscribeEntityPropertyChange(); // 0x0696ffec
	System.Void OnMonsterAttackStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Byte oldValue, System.Byte newValue); // 0x06970168
	System.Void StopWeaponAudio(); // 0x069704dc
	System.Void OnMonsterActiveStatusChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Boolean oldValue, System.Boolean newValue); // 0x069706e4
	System.Void OnDeathAnimValueChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int32 oldValue, System.Int32 newValue); // 0x06970790
	System.Void Switch2AnimatorDeathController(); // 0x069708d8
	System.Void OnWildChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Boolean oldValue, System.Boolean newValue); // 0x0696bbbc
	System.Void OnMountableIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int64 oldValue, System.Int64 newValue); // 0x06970a40
	System.Void OnHpChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Single oldValue, System.Single newValue); // 0x06970ae0
	System.Void OnClientHpChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Single oldValue, System.Single newValue); // 0x0696fcd0
	System.Boolean NeedUpdateAnimatorStateMachine(); // 0x054c4760
	System.Void OnWeaponIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int64 oldValue, System.Int64 newValue); // 0x0696fe90
	System.Void UpdateWeapon(); // 0x0696c830
	System.Void OnBehaviorTemplateIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int32 oldValue, System.Int32 newValue); // 0x0696ff4c
	System.Void OnTransformChange(WizardGames.Soc.Share.Framework.PositionChangeEvent e); // 0x06971368
	System.Void OnHeldItemHolster(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo heldItem); // 0x06971430
	System.Void StartSwitchHeldItem(WizardGames.Soc.Common.Entity.IHeldItemEntity entity); // 0x06971690
	System.Void RecordSMBAnimData(); // 0x0697157c
	System.Void RefreshAnimCfg(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo heldItem); // 0x06971768
	System.Void RefreshCommonCfg(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo heldItem); // 0x06972474
	System.Void OnHeldItemDeploy(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo heldItem); // 0x069729f4
	WizardGames.Soc.Common.Entity.IHeldItemEntity GetHeldItemEntity(System.Int64 entityID); // 0x06972a7c
	System.Boolean TryGetCurrentHeldItemGo<T>(T& heldItemGo); // 0x052af1f0
	System.Void RefreshSMB(WizardGames.Soc.SocClient.Player.HeldItem.BaseMonsterHeldItemGo heldItemGo); // 0x069723a0
	WizardGames.Soc.Common.Unity.Animation.SMBAnimData LoadSmb(WizardGames.Soc.SocClient.Player.HeldItem.BaseMonsterHeldItemGo heldItemGo); // 0x06972af4
	System.Void RefreshSMB(WizardGames.Soc.Common.Unity.Animation.SMBAnimData smbAnimData, WizardGames.Soc.Common.Unity.Character.CharacterConfig PlayerConfig, WizardGames.Soc.SocClient.Player.HeldItem.BaseMonsterHeldItemGo heldItemGo); // 0x06972ea0
	System.Void GroundSample(); // 0x0697354c
	System.Void BindCorpse(WizardGames.Soc.SocClient.Go.CorpseGo corpse); // 0x0697399c
	System.Void UpdateCollider(System.Int32 lod); // 0x06973b00
	System.Void UpdateAnimation(System.Int64 time); // 0x06973b74
	System.Void UpdateAnimationParams(); // 0x06973dd8
	System.Void UpdateAnimationMoveInfo(); // 0x06973e44
	System.Void UpdateAnimationAimOffsetInfo(); // 0x06974038
	System.Void UpdateAnimationUnlimited(System.Int64 time); // 0x069744d4
	System.Boolean GetEntityPosition(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.Vector3& position); // 0x0697463c
	System.Boolean GetEntityIkTargetPos(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.Vector3& position); // 0x06974374
	UnityEngine.Vector3 GetTargetPlayerAimPos(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x06974880
	UnityEngine.Vector3 GetTargetPlayerHeightVector(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x06974eb8
	System.Void UpdateAnimDeathState(System.Int64 time); // 0x06973bf0
	System.Void UpdateBehaviorTemplate(); // 0x06970ce4
	System.Void ProcessOldGunParam(); // 0x06975230
	System.Void RefreshGunParam(WizardGames.Soc.Common.CustomType.WeaponCustom weaponEntity); // 0x06970f04
	System.Void UnEquipWeapon(); // 0x0697540c
	System.Void DoWeaponPartAttach(UnityEngine.GameObject accessory, UnityEngine.GameObject weapon, WizardGames.Soc.Common.Data.part.PartBase table, UnityEngine.Vector3 scale); // 0x06975534
	System.Void UpdateWeaponPartGo(); // 0x069755f4
	System.Void PlayFireEffect(System.Int32 slotId); // 0x0697580c
	WizardGames.Soc.Common.Data.units.MonsterGunPara GetTbGunParam(WizardGames.Soc.Common.Entity.MonsterEntity.MonsterHeldItemSlot slot); // 0x06975c70
	System.Boolean UpdateTurretLine(); // 0x06975dbc
	System.Void UpdateOn1Fps(System.Int64 time); // 0x069760b0
	System.Void Tick(); // 0x06976638
	System.Boolean CdComplete(System.String cdName, System.String& eventName); // 0x0697669c
	System.Void ResetCountDown(System.String cdName); // 0x069768c8
	System.Void TryPlayIdleAudio(); // 0x069763b0
	System.Void SetSmoothProp(); // 0x06976a2c
	WizardGames.Soc.Common.Data.units.MonsterGunPara GetGunParam(System.Int32 slotId); // 0x06976c5c
	System.Void OnDeathStable(); // 0x06975034
	UnityEngine.Vector3 GetWeaponFirePos(System.Int32 slotId); // 0x06976da8
	UnityEngine.Transform GetWeaponFireTrans(System.Int32 slotId); // 0x06977118
	UnityEngine.GameObject GetFireGo(System.Int32 slotId); // 0x0697726c
	System.Boolean IsPositionalEntity(System.Int64 eid); // 0x069772e4
	UnityEngine.Vector3 GetEntityPos(System.Int64 entityId); // 0x069773c0
	System.Void ChangeMats(WizardGames.AssetPool.AssetPoolHandle newMat); // 0x06977668
	System.Void RecoverMats(); // 0x06977960
	System.Void RemoveEffect(); // 0x0696f55c
	static System.Void .cctor(); // 0x06977b14
	System.Void <SetMainGo>b__89_0(System.Int64 id, System.Object data, System.Boolean delete); // 0x06977cb4
	System.Void <Switch2AnimatorDeathController>b__137_0(System.UInt64 loaderId, Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.AssetPool.AssetGroupData> results); // 0x06977d54
	System.Void <UpdateBehaviorTemplate>b__177_0(System.UInt64 loaderId, Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.AssetPool.AssetGroupData> results); // 0x06977e7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.AutoTurretMonsterGo : WizardGames.Soc.SocClient.Go.TurretMonsterGo
{
	UnityEngine.GameObject rotateYawGo; // 0x2f8
	UnityEngine.GameObject rotatePitchGo; // 0x300
	UnityEngine.GameObject rotateShellGo; // 0x308
	UnityEngine.GameObject TurretRotateEndPos; // 0x310
	UnityEngine.GameObject TurretRotateStartPos; // 0x318
	WizardGames.Soc.Common.CustomType.WeaponCustom curWeaponEntity; // 0x320
	System.Boolean isRotateDone; // 0x328
	System.Boolean immediate; // 0x329
	System.Int32 preMode; // 0x32c
	System.Boolean startRotating; // 0x330
	UnityEngine.Renderer[] meshList; // 0x338
	System.Void .ctor(); // 0x06977f9c
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0697800c
	System.Void SetMainGo(UnityEngine.GameObject obj, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0697819c
	System.Void RegisterGameObjectComponent(System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0697913c
	System.Void CollectMeshList(); // 0x06978360
	System.Void UpdateAnimation(System.Int64 time); // 0x069794a4
	System.Void Tick(); // 0x06979518
	UnityEngine.Vector3 GetTargetPos(WizardGames.Soc.Common.Unity.Go.IEntityGo targetGo); // 0x06979f18
	System.Void OnSwitchStateChange(); // 0x0697a2f8
	System.Void UpdateClientRot(System.Boolean isOn); // 0x06978454
	System.Void SubscribeEntityPropertyChange(); // 0x0697a520
	System.Void UnsubscribeEntityPropertyChange(); // 0x0697a6cc
	System.Void OnTransitionModeChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int32 oldValue, System.Int32 newValue); // 0x0697a878
	System.Void OnAttackModeChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int32 oldValue, System.Int32 newValue); // 0x0697a924
	System.Void OnOriginYChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Single oldValue, System.Single newValue); // 0x0697a9d0
	System.Void RotateDoneRpc(); // 0x0697a394
	System.Void OnHeldItemDeploy(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo heldItem); // 0x0697ab30
	System.Void UpdateWeaponShell(); // 0x0697afa4
	System.Void EquipAccessoryWeapon(); // 0x0697abc8
	System.Void UpdateWeaponState(WizardGames.Soc.Common.CustomType.WeaponCustom weapon, System.Boolean effect); // 0x0697b150
	System.Void UpdateTurretParam(); // 0x06978fe0
	System.Void ClientUpdateGunParam(System.Int32 gunTempId); // 0x0697b34c
	System.Void UpdateAiParam(System.Int32 weaponTb); // 0x0697b8f4
	System.Void SetLineType(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int64 oldValue, System.Int64 newValue); // 0x0697b9d0
	System.Boolean CheckRenderNeedChange(UnityEngine.Renderer renderer); // 0x0697bb0c
	System.Void ChangeMats(WizardGames.AssetPool.AssetPoolHandle newMat); // 0x0697bbc4
	System.Void Remove(); // 0x0697becc
	System.Void DrawHighLight(WizardGames.Soc.SocClient.Manager.EPartHighlightType partHighlightType); // 0x0697bf4c
	System.Void Highlight(UnityEngine.Renderer renderer, WizardGames.Soc.SocClient.Manager.EPartHighlightType highlightType); // 0x0697c0c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.FlakTurretMonsterGo : WizardGames.Soc.SocClient.Go.MonsterGo
{
	UnityEngine.GameObject _rotateYawGo; // 0x2d8
	UnityEngine.GameObject _rotatePitchGo; // 0x2e0
	UnityEngine.Animator _animator; // 0x2e8
	System.Single curTime; // 0x2f0
	System.Boolean firstEnter; // 0x2f4
	System.Single lastAngle; // 0x2f8
	System.Single lastYaw; // 0x2fc
	System.Single updateInterval; // 0x300
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0697c73c
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x0697c8c8
	System.Void SetMainGo(UnityEngine.GameObject obj, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0697c960
	System.Void SubscribeEntityPropertyChange(); // 0x0697cb90
	System.Void UnsubscribeEntityPropertyChange(); // 0x0697cbf4
	System.Void UpdatePosition(); // 0x0697cc58
	System.Void UpdateAnimation(System.Int64 time); // 0x0697cd2c
	System.Void OnHeldItemDeploy(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo heldItem); // 0x0697cda0
	System.Void SetSmoothProp(); // 0x0697d218
	System.Void Tick(); // 0x0697d2d8
	System.Void UpdateRotation(); // 0x0697d368
	System.Void .ctor(); // 0x0697d8a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.SharkMonsterGo : WizardGames.Soc.SocClient.Go.MonsterGo
{
	System.Single _currentMouthOpen; // 0x2d8
	System.Single lastUpdateTime; // 0x2dc
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0697ddf0
	System.Void UpdateAnimation(System.Int64 time); // 0x0697dee0
	System.Void .ctor(); // 0x0697e0a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.TurretMonsterGo : WizardGames.Soc.SocClient.Go.MonsterGo
{
	UnityEngine.GameObject lineGo; // 0x2d8
	UnityEngine.Transform laserPos; // 0x2e0
	System.Boolean isPlayRotateAudio; // 0x2e8
	System.Boolean firstEnter; // 0x2e9
	System.UInt64 lineAsyncId; // 0x2f0
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0697e134
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x0697e2c0
	System.Void SetMainGo(UnityEngine.GameObject obj, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0697e35c
	System.Void GroundSample(); // 0x0697e764
	System.Void OnLineLoadFinish(UnityEngine.GameObject obj, System.Object[] param); // 0x0697e7c4
	System.Void SubscribeEntityPropertyChange(); // 0x0697e998
	System.Void UnsubscribeEntityPropertyChange(); // 0x0697ea68
	System.Void UpdatePosition(); // 0x0697eb38
	System.Void UpdateAnimation(System.Int64 time); // 0x0697ec0c
	System.Void OnHeldItemDeploy(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo heldItem); // 0x0697ec80
	System.Void SetSmoothProp(); // 0x0697ef74
	System.Void Tick(); // 0x0697f038
	System.Void ManualUpdatePosition(); // 0x0697ffac
	System.Void UpdateRotation(); // 0x0697f09c
	System.Void PlayRotateAudio(UnityEngine.Quaternion targetRotation, System.Boolean start, System.Boolean end); // 0x069802ec
	System.Void SetLineType(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int64 oldValue, System.Int64 newValue); // 0x06980728
	System.Void Clear(); // 0x06980834
	System.Void Remove(); // 0x06980a2c
	System.Void .ctor(); // 0x06980a9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.NPCGo : WizardGames.Soc.Common.Unity.Go.BaseNPCGo
{
	System.Collections.Generic.List<System.Int64> npcEquips; // 0xb0
	WizardGames.Soc.SocClient.GoLoader.PartModelController mPartModelCtrl; // 0xb8
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.NPCEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x06980b30
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x06980da8
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x06980f34
	System.Void InitHumanidAvatar(); // 0x06980fbc
	System.Void OnPartModelLoadFinished(UnityEngine.GameObject go); // 0x069819b0
	System.Void Clear(); // 0x06981a98
	System.Void Remove(); // 0x06981cc8
	System.Void .ctor(); // 0x06981d38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.ShopGo : WizardGames.Soc.Common.Unity.Go.BaseShopGo
{
	System.String uiRootKey; // 0x70
	System.String uiFlagRootKey; // 0x78
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Go.ShopGoNormalPanelUI> shopGoNormalUIs; // 0x80
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Go.ShopGoFlagPanelUI> shopGoFlagUIs; // 0x88
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Item.ShopList> shopItemList; // 0x90
	System.Int64 timerID; // 0x98
	System.Boolean isUse; // 0xa0
	System.Int32 iconShowIndex; // 0xa4
	static System.Int32 CRTisRed; // 0x0
	System.Int64 hudTimerId; // 0xa8
	WizardGames.Soc.Common.Component.ShopComponent get_shopComponent(); // 0x06981dec
	System.Void .ctor(); // 0x06981e7c
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.ShopEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x06982034
	System.Void InitUIComponent(); // 0x069822ac
	System.Void PlayAudio(System.Boolean isPlay); // 0x069831d8
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x06983324
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x05523a54
	System.Void InitShowItemInfo(); // 0x06983828
	System.Void Tick(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x06983ca8
	System.Void TickHudRotation(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x0698433c
	System.Void OnUseStateChanged(); // 0x06984724
	System.Void Update(); // 0x06984dec
	System.Void Clear(); // 0x06984e5c
	System.Void Remove(); // 0x06985468
	System.Void SetSmoothProp(); // 0x069854d8
	static System.Void .cctor(); // 0x069855e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.ShopGoNormalPanelUI : System.Object
{
	static SocLogger logger; // 0x0
	System.String iconLoaderKey; // 0x10
	System.String saleNumTextKey; // 0x18
	System.String priceNumTexttKey; // 0x20
	System.String priceItemTextKey; // 0x28
	System.String showUseStateAnimKey; // 0x30
	System.String useStateLoopAnimKey; // 0x38
	System.String hideUseStateAnimKey; // 0x40
	System.String soldOutGroupKey; // 0x48
	System.String noUseGroupKey; // 0x50
	System.String showControlKey; // 0x58
	UnityEngine.GameObject uiRoot; // 0x60
	FairyGUI.GLoader iconLoader; // 0x68
	FairyGUI.GTextField saleNumText; // 0x70
	FairyGUI.GTextField priceNumText; // 0x78
	FairyGUI.GTextField priceItemText; // 0x80
	FairyGUI.GGroup soldOutGroup; // 0x88
	FairyGUI.GGroup noUseGroup; // 0x90
	FairyGUI.Controller showController; // 0x98
	FairyGUI.Transition showUseStateAnim; // 0xa0
	FairyGUI.Transition useStateLoopAnim; // 0xa8
	FairyGUI.Transition hideUseStateAnim; // 0xb0
	FairyGUI.GLoader flagIconLoader; // 0xb8
	FairyGUI.GImage iconBg; // 0xc0
	System.Void .ctor(UnityEngine.GameObject uiRoot); // 0x069828cc
	System.Void ClearUI(); // 0x06985274
	System.Void StopShowUseStateAnim(); // 0x06984b74
	System.Void StopUseStateLoopAnim(); // 0x06984bdc
	System.Void StopHideUseStateAnim(); // 0x06984c44
	System.Void StopAnim(FairyGUI.Transition anim); // 0x06985648
	System.Void PlayShowUseStateAnim(); // 0x06984cac
	System.Void OnShowAnimPlayComplete(); // 0x06985728
	System.Void PlayHideUseStateAnim(); // 0x06984d7c
	System.Void TickUpdate(WizardGames.Soc.Common.Data.Item.ShopList showData, WizardGames.Soc.Common.Component.ShopComponent shopComponent); // 0x06983ea8
	static System.Void .cctor(); // 0x06985798
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.ShopGoFlagPanelUI : System.Object
{
	static SocLogger logger; // 0x0
	System.String iconLoaderKey; // 0x10
	System.String bgKey; // 0x18
	UnityEngine.GameObject uiFlagRoot; // 0x20
	FairyGUI.GLoader iconLoader; // 0x28
	FairyGUI.GImage iconBg; // 0x30
	System.Void .ctor(UnityEngine.GameObject uiFlagRoot); // 0x06982e24
	System.Void ClearUI(); // 0x069853dc
	System.Void ShowIcon(System.Int64 id); // 0x06983058
	static System.Void .cctor(); // 0x0698586c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.TrainBarricadeGo : WizardGames.Soc.Common.Unity.Go.BaseTrainBarricadeGo
{
	System.String shatterPath; // 0x78
	System.Int32 shatterDestroyTime; // 0x80
	System.Boolean isCreateGib; // 0x84
	System.Int64 mSmokeEffectCd; // 0x88
	System.Int64 mNextPlaySmokeEffectTimeStamp; // 0x90
	UnityEngine.Transform mSmokeEffectRoot; // 0x98
	System.String kSmokeEffectRootPath; // 0xa0
	System.Int64 hpSubscribeId; // 0xa8
	System.Void .ctor(); // 0x06985940
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.TrainBarricadeEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x06985a0c
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x06985c84
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x06985e0c
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x06985ea8
	System.Void OnHpChangedCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldVal, System.Single newVal); // 0x0698604c
	System.Void PlaySmokeEffect(); // 0x069860fc
	System.Void Clear(); // 0x069863b0
	System.Void Remove(); // 0x069864ac
	System.Void CreateShatter(); // 0x0698651c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.TrainCarGo : WizardGames.Soc.Common.Unity.Go.BaseTrainCarGo
{
	SocLogger mLogger; // 0x170
	WizardGames.Soc.Common.Train.TrainCar mTrainCarCom; // 0x178
	UnityEngine.Vector3 bogieRotation; // 0x180
	UnityEngine.Vector3 prevWheelRotation; // 0x18c
	System.Boolean wasBraking; // 0x198
	System.String shatterPath; // 0x1a0
	System.Int32 shatterDestroyTime; // 0x1a8
	System.Boolean isCreateGib; // 0x1ac
	System.Collections.Generic.List<Effect.EffectItemHandle<Effect.FollowEffect>> mSparkEffectHandleList; // 0x1b0
	System.Single kEngineMaxRSpeed; // 0x1b8
	System.String kUIRootKey; // 0x1c0
	System.String kFuelTextKey; // 0x1c8
	System.String kThrottleTextKey; // 0x1d0
	System.String kCollisionWarningKey; // 0x1d8
	System.String kLeftSwitchGroupKey; // 0x1e0
	System.String kRightSwitchGroupKey; // 0x1e8
	System.String kTrainHeadPath; // 0x1f0
	UnityEngine.GameObject mTrainHeadGo; // 0x1f8
	UnityEngine.GameObject mUIRoot; // 0x200
	FairyGUI.GTextField mFuelGText; // 0x208
	FairyGUI.GTextField mThrottleGText; // 0x210
	FairyGUI.GObject mCollisionWarningGObject; // 0x218
	FairyGUI.GObject mLeftSwitchGroupGObject; // 0x220
	FairyGUI.GObject mRightSwitchGroupGObject; // 0x228
	System.Single mMaxSpeed; // 0x230
	System.Int64 tickHandler; // 0x238
	System.Single kPressureNeedleMaxAngle; // 0x240
	System.Single kSpeedNeedleMaxAngle; // 0x244
	System.Int32 mPressureNeedleUnitAngle; // 0x248
	System.Collections.Generic.List<Effect.EffectItemHandle<Effect.FollowEffect>> mCarLightsEffectItem; // 0x250
	System.Collections.Generic.List<WizardGames.Soc.SocClient.ClientLight.LightItem> mCarLight; // 0x258
	System.Collections.Generic.Dictionary<System.Int32,Effect.EffectItem> effectItems; // 0x260
	System.Int64 hpSubscribeId; // 0x268
	UnityEngine.Renderer[] mRenderers; // 0x270
	System.Boolean mIsPlayMovementStart; // 0x278
	System.Void .ctor(); // 0x06986824
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.TrainCarEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x06986bdc
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x06986f48
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x069870e0
	System.Void OnUiBtnClicked(System.Int32 btnId); // 0x06987eac
	System.Void InitOnSpawn(); // 0x055049cc
	System.Void OnTrainUnloadPercentageCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Single oldValue, System.Single newValue); // 0x06988c34
	System.Void OnHpChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldHp, System.Single newHp); // 0x0698837c
	System.Void InitUICom(); // 0x06987ff0
	System.Boolean IsEngineStarted(WizardGames.Soc.Common.Entity.TrainEngineStateEnum engineState); // 0x06988d30
	System.Void InitUIShowStatus(); // 0x06988240
	System.Void InitTrainStatus(); // 0x06988bac
	System.Void OnTrainVelocityChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Single oldValue, System.Single newValue); // 0x06989320
	System.Void OnHasHazardsChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Boolean oldValue, System.Boolean newValue); // 0x0698952c
	System.Void OnThrottleFractionChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int32 oldValue, System.Int32 newValue); // 0x069896a4
	System.String GetThrottleStrByVal(System.Int32 throttleFractionVal); // 0x06988db4
	System.Single GetThrottleFractionPositiveVal(System.Int32 throttleFractionVal); // 0x069899c8
	System.Single GetThrottleFraction(System.Int32 throttleFraction); // 0x06989a54
	System.Void OnTrainCollisionStateChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int32 oldValue, System.Int32 newValue); // 0x06989ae0
	System.Void OnTrainTrackSelectionChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int32 oldValue, System.Int32 newValue); // 0x06989c68
	System.Void OnTrainEngineStateChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Byte oldValue, System.Byte newValue); // 0x06989d28
	System.Void OnTrainFuelChangeCallBack(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Single oldValue, System.Single newValue); // 0x06989ddc
	System.Void Tick(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x06989f74
	System.Void UpdateWheelVisuals(UnityEngine.Vector3 localVelocity, System.Single frontBogieYRot, System.Single rearBogieYRot); // 0x0698a8d0
	System.Boolean UpdateBraking(System.Single forwardSpeed); // 0x0698abd4
	System.Void SetSparks(System.Boolean play); // 0x0698accc
	System.Void ResetSparkEffect(); // 0x0698b084
	System.Void SetBogieRotation(UnityEngine.Transform pivot, System.Single yAngle, System.Boolean canRotate); // 0x0698aad4
	System.Void UpdateControlLeverVisuals(); // 0x0698a37c
	System.Void LodUpdate(System.Int32 deltaTime); // 0x0698b20c
	System.Void Clear(); // 0x0698b418
	System.Boolean get_Visible(); // 0x0698c0e8
	System.Void Remove(); // 0x0698c1f0
	System.Void StopAllAudio(); // 0x0698bc3c
	System.Void CreateShatter(); // 0x0698c260
	System.Void OnCarLightChanged(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Boolean oldValue, System.Boolean newValue); // 0x0698c608
	System.Void ChangeCarLightState(System.Boolean isOpen); // 0x06988ea0
	System.Void ReleaseCarLights(); // 0x0698bea8
	System.Boolean CanVehicleEngineAndOilInteractive(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0698c6a0
	System.Boolean CanVehicleStorageInteractive(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0698c718
	System.Void OnClientPlayerMounted(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0698c790
	System.Void OnClientPlayerDismounted(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0698c844
	System.Void ResetViewWhenOnMount(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0698c928
	System.Void TryInitTrainHeadGo(); // 0x06987d54
	UnityEngine.GameObject get_TrainHeadGo(); // 0x0698c9e0
	System.Boolean CanRepairInteractive(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0698ca4c
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> GetRepairConsume(System.Single& recoverHp, System.Int32& totalItems); // 0x0698ce30
}

// Client.Runtime
class WizardGames.Soc.SocClient.Go.VehicleTrigger : UnityEngine.MonoBehaviour
{
	WizardGames.Soc.Common.Combat.ColliderConfig _colliderConfig; // 0x30
	UnityEngine.Collider _collider; // 0x38
	Vehicle.MgrVehicle _mgrVehicle; // 0x40
	WizardGames.Soc.Common.Entity.IBaseMountableEntity _entity; // 0x48
	System.Int64 _entityId; // 0x50
	System.Boolean Init; // 0x58
	WizardGames.Soc.Common.Entity.IBaseMountableEntity get_Entity(); // 0x0698d484
	System.Void OnEnable(); // 0x0698d634
	System.Void OnDisable(); // 0x0698d754
	System.Void UpdateEntityId(); // 0x0698d558
	System.Void CheckInteraction(); // 0x0698d8a8
	System.Boolean InCollider(UnityEngine.Collider collider, UnityEngine.Vector3 position); // 0x0698daf8
	System.Void OnPlayerEnter(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0698dd40
	System.Void OnPlayerExit(); // 0x0698d80c
	System.Void .ctor(); // 0x0698e034
}

// Client.Runtime
class WizardGames.Soc.SocClient.Gathering.BaseHitMarker : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	static SocLogger logger; // 0x0
	UnityEngine.GameObject mainGo; // 0x10
	WizardGames.Soc.Common.Unity.Go.IEntityGo resourceEntityGo; // 0x18
	System.Int32 markerId; // 0x20
	System.String markerPath; // 0x28
	System.Boolean isAlive; // 0x30
	WizardGames.Soc.Common.Unity.Effect.EffectProfile effectProfile; // 0x38
	System.Boolean IsHitMarker(WizardGames.Soc.Common.SimpleCustom.HitRequest data); // 0x0698e09c
	System.Void Init(WizardGames.Soc.Common.Unity.Go.IEntityGo go); // 0x0698e114
	System.Void CreateGo(); // 0x0698e1fc
	UnityEngine.Vector3 GetPosition(); // 0x0698e4b8
	System.Void UpdateMarker(WizardGames.Soc.Common.SimpleCustom.HitRequest data); // 0x0698e59c
	System.Void OnGet(); // 0x0698e610
	System.Void OnRelease(); // 0x0698e670
	System.Void OnDestroy(); // 0x0698e71c
	System.Void .ctor(); // 0x0698e788
	static System.Void .cctor(); // 0x0698e7f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Gathering.MgrGathering : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Gathering.BaseHitMarker> hitMarkerDict; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Gathering.OreMarker> OreMarkerDict; // 0x20
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.OreEntity> NearOreDict; // 0x28
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> resourceBonusLevelDict; // 0x30
	WizardGames.Soc.Common.Utility.Grid<WizardGames.Soc.Common.Entity.OreEntity> OreEntityGrid; // 0x38
	System.Boolean UseGrid; // 0x40
	System.Boolean ForceUpdate; // 0x41
	System.Void Init(); // 0x0698e8c4
	System.Void OnOreEntityLodChange(WizardGames.Soc.Common.Entity.OreEntity oreEntity); // 0x0698ecb0
	WizardGames.Soc.SocClient.Gathering.BaseHitMarker CheckMarker(System.Int64 entityId, System.Int32 entityType); // 0x0698ee70
	System.Void AddOrRemoveOreEntity(System.Boolean isAdd, WizardGames.Soc.Common.Entity.OreEntity oreEntity); // 0x0698f2b0
	System.Void CreateOreMarker(WizardGames.Soc.Common.Entity.IEntity entity, WizardGames.Soc.Common.Unity.Go.IEntityGo entityGo); // 0x0698f484
	System.Void RemoveMarker(System.Int64 entityId); // 0x0698f9ac
	System.Void UpdateHitMarker(System.Int64 entityId); // 0x0698fbd4
	System.Void OreStageChange(UnityEngine.GameObject oreStageGo, WizardGames.Soc.Common.Entity.OreEntity entity); // 0x0698fc94
	System.Void CheckBonusLevel(System.Int64 entityId); // 0x0699002c
	System.Boolean IsOpenUIWin(); // 0x06990108
	System.Int32 GetBonusLevel(WizardGames.Soc.Common.SimpleCustom.HitRequest hitData); // 0x06990318
	System.Void PlayHitAudio(System.Boolean hitMarker, WizardGames.Soc.Common.SimpleCustom.HitRequest data); // 0x06990508
	System.Boolean TreeCanHaveAndHasNoRedMarker(WizardGames.Soc.Common.SimpleCustom.HitRequest data); // 0x06990780
	System.Void .ctor(); // 0x069909b0
	static System.Void .cctor(); // 0x06990a20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Gathering.OreMarker : WizardGames.Soc.SocClient.Gathering.BaseHitMarker
{
	static SocLogger logger; // 0x0
	System.Int32 ID_Brightness; // 0x40
	static System.Collections.Generic.Dictionary<System.Int64,UnityEngine.Matrix4x4> s_MarkerPosDict; // 0x8
	System.Single hitRadius; // 0x44
	UnityEngine.Vector3 lastNodeDir; // 0x48
	UnityEngine.MeshCollider meshCollider; // 0x58
	UnityEngine.Renderer[] renderers; // 0x60
	UnityEngine.MaterialPropertyBlock materialPropertyBlock; // 0x68
	System.Int64 delayTimerId; // 0x70
	System.Void Init(WizardGames.Soc.Common.Unity.Go.IEntityGo go); // 0x06990af4
	System.Void SetData(WizardGames.Soc.Common.Unity.Go.IEntityGo gameObject); // 0x06990b88
	System.Void CreateGo(); // 0x06990c08
	System.Void DelayUpdateMarkerNew(); // 0x0698f758
	System.Void PhysicsSimulateCallback(); // 0x06990cb8
	System.Boolean CheckOCVisable(); // 0x06990db8
	System.Boolean IsHitMarker(WizardGames.Soc.Common.SimpleCustom.HitRequest data); // 0x06990e40
	System.Void UpdateMarker(WizardGames.Soc.Common.SimpleCustom.HitRequest data); // 0x06991040
	System.Void ShowMarker(System.Boolean isShow); // 0x06992360
	System.Void SetScale(System.Single scale); // 0x06992454
	System.Void SetBrightness(System.Single brightness); // 0x0699253c
	System.Void OnDestroy(); // 0x06992624
	UnityEngine.Vector3 RandomCircle(System.Single distance, System.Boolean allowInside); // 0x069920ac
	UnityEngine.MeshCollider GetCurrentMeshCollider(); // 0x06991fb4
	UnityEngine.Vector3 GetDirToMe(UnityEngine.Vector3 aimDir, UnityEngine.Vector3 dirToMe); // 0x069921e8
	System.Void .ctor(); // 0x069927d0
	static System.Void .cctor(); // 0x06992904
}

// Client.Runtime
class WizardGames.Soc.SocClient.Gathering.TreeMarker : WizardGames.Soc.SocClient.Gathering.BaseHitMarker
{
	System.Single hitRadius; // 0x40
	System.Single radius; // 0x44
	System.Single minY; // 0x48
	System.Boolean isRefresh; // 0x4c
	System.Int64 liveTimer; // 0x50
	System.Int32 debugindex; // 0x58
	System.Void Init(WizardGames.Soc.Common.Unity.Go.IEntityGo go); // 0x06992a34
	System.Boolean IsHitMarker(WizardGames.Soc.Common.SimpleCustom.HitRequest data); // 0x06992b68
	System.Void UpdateMarker(WizardGames.Soc.Common.SimpleCustom.HitRequest data); // 0x06992d58
	System.Int32 FindRedMark(UnityEngine.Vector3 normal, UnityEngine.Vector3 tangent, System.Single radius, System.Single radian, UnityEngine.Vector3 damagePos, UnityEngine.RaycastHit& hit); // 0x069935b8
	System.Void OnDestroy(); // 0x06993c24
	System.Void AddMarkerTimer(); // 0x06993aa8
	System.Void CancelMarkerTimer(); // 0x069939a0
	System.Void .ctor(); // 0x06993c90
	System.Void <AddMarkerTimer>b__12_0(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x06993d2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Main.SocClientReplayLoop : WizardGames.Soc.SocClient.Main.SocClientMainLoop
{
	
	System.Void Start(); // 0x06993e18
	System.Void OnFps30Update(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x06993ef8
	System.Int32 OnLogicDynamicUpdate(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x0699400c
	System.Void .ctor(); // 0x06994584
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Main.SocClientReplayLoop.<Start>d__0 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Main.SocClientReplayLoop <>4__this; // 0x38
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x40
	WizardGames.Soc.SocClient.GoLoader.LoadFullSnapshotProgress <loadSnapshotProgress>5__2; // 0x48
	System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__2; // 0x50
	System.Void MoveNext(); // 0x06994610
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x06995b08
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Main.EReplayState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Main.EReplayState None = 0;
	static WizardGames.Soc.SocClient.Main.EReplayState DownloadingReplayFile = 1;
	static WizardGames.Soc.SocClient.Main.EReplayState LoadingReplayFile = 2;
	static WizardGames.Soc.SocClient.Main.EReplayState InitMgr = 3;
	static WizardGames.Soc.SocClient.Main.EReplayState ClearLobbyMgr = 4;
	static WizardGames.Soc.SocClient.Main.EReplayState SceneLoading = 5;
	static WizardGames.Soc.SocClient.Main.EReplayState Preload = 6;
	static WizardGames.Soc.SocClient.Main.EReplayState LoadSuccess = 7;
	static WizardGames.Soc.SocClient.Main.EReplayState StartReplay = 8;
	static WizardGames.Soc.SocClient.Main.EReplayState EndReplay = 9;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Main.SocReplayMgr : System.Object
{
	static WizardGames.Soc.SocClient.Main.SocReplayMgr _; // 0x0
	static SocLogger Logger; // 0x8
	WizardGames.Soc.SocClient.Main.EReplayState State; // 0x10
	WizardGames.Soc.SocClient.Relay.ReplayFileDownloader Downloader; // 0x18
	System.String CurrentFileName; // 0x20
	System.Boolean CanPredict; // 0x28
	System.Boolean IsPreloadFinish; // 0x29
	System.Int32 LastCmdAck; // 0x2c
	System.Collections.Generic.List<WizardGames.Soc.Common.Framework.Network.BasePacket> PacketsBeforeLoadingSuccessAck; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.Framework.Network.BasePacket> PacketsAfterLoadingSuccessAck; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.Common.Framework.Network.BasePacket> PacketsDelayEntityAck; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.Common.Framework.Network.BasePacket> PacketsCmds; // 0x48
	System.Collections.Generic.Queue<System.ValueTuple<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.Framework.Network.BasePacket>>> PacketsQueue; // 0x50
	System.Int32 MapId; // 0x58
	System.Boolean IsInitMgr; // 0x5c
	System.Int32 CurGameModeID; // 0x60
	System.Boolean isLoadingScene; // 0x64
	System.Int64 LastLogicFrame; // 0x68
	WizardGames.Soc.Common.Main.Loop.CustomLoop Fps30Loop; // 0x70
	WizardGames.Soc.Common.Main.Loop.CustomLoop FpsUnlimitedLoop; // 0x78
	System.Void OnFps30Update(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x06995b88
	System.Void OnFpsUnlimitedUpdate(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x06997cfc
	System.Void UpdateReplayFileDownload(System.Single delta); // 0x06995d64
	System.Void UpdateReplayFileLoad(System.Single delta); // 0x06995e08
	System.Void UpdateInitMgr(System.Single delta); // 0x06996850
	System.Void UpdateClearLobbyMgr(System.Single delta); // 0x06997108
	System.Void UpdatePreload(System.Single delta); // 0x069976cc
	System.Void UpdateLoadSuccess(System.Single delta); // 0x06997954
	System.Void UpdateSceneLoading(System.Single delta); // 0x06997640
	System.Void UpdateReplay(System.Single delta); // 0x06997a18
	System.Void BlockPreloading(); // 0x0699802c
	System.Void UpdateNetWork(); // 0x06997de0
	System.Void UpdateReplayEnd(System.Single delta); // 0x06997c70
	System.Void StartReplay(); // 0x06998b24
	System.Void StartReplay(System.String InSvrName, System.String InRoleName, System.String InTime); // 0x06998ca0
	System.Void StartReplay(System.String fileName); // 0x06998d78
	System.Void AddLoop(); // 0x06998e40
	System.Void RemoveLoop(); // 0x06999128
	System.Void OnConfigApplyFinished(System.Collections.Generic.Dictionary<System.String,System.String> remoteConfigData); // 0x069991c4
	System.Void OnReplayFileDownloaded(); // 0x06998684
	System.Void OnReplayFileLoaded(); // 0x06998898
	System.Void OnSceneLoadingFinished(); // 0x06999340
	System.Void OnLoginSceneLoadingFinished(); // 0x069993ac
	System.Void OnLoadSuccess(); // 0x06995aa0
	System.Void OnReplayEnd(); // 0x06998608
	System.Threading.Tasks.Task LoadGameSceneAsync(); // 0x06998900
	System.Threading.Tasks.Task LoadLoginSceneAsync(); // 0x06998a14
	static System.Void CreateReplayMainLoop(); // 0x0699941c
	System.Void .ctor(); // 0x0699952c
	static System.Void .cctor(); // 0x06999710
}

// Client.Runtime
class WizardGames.Soc.SocClient.Main.SocReplayMgr.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Main.SocReplayMgr.<>c <>9; // 0x0
	static Framework.Replay.ReplayUtils.OnGetMcTarget<WizardGames.Soc.SocClient.Network.SocClientService> <>9__25_0; // 0x8
	static Framework.Replay.ReplayUtils.OnGetMcTarget<WizardGames.Soc.SocClient.Indicator.MgrIndicator> <>9__25_1; // 0x10
	static Framework.Replay.ReplayUtils.OnGetMcTarget<WizardGames.Soc.Common.Synchronization.MgrTime> <>9__25_2; // 0x18
	static Framework.Replay.ReplayUtils.OnGetMcTarget<WizardGames.Soc.SocClient.Indicator.MgrIndicator> <>9__47_0; // 0x20
	static Framework.Replay.ReplayUtils.OnGetMcTarget<WizardGames.Soc.Common.Synchronization.MgrTime> <>9__47_1; // 0x28
	static Framework.Replay.ReplayUtils.OnGetMcTarget<WizardGames.Soc.SocClient.Network.SocClientService> <>9__47_2; // 0x30
	static System.Void .cctor(); // 0x06999814
	System.Void .ctor(); // 0x06999878
	WizardGames.Soc.SocClient.Network.SocClientService& <UpdateInitMgr>b__25_0(); // 0x069998e0
	WizardGames.Soc.SocClient.Indicator.MgrIndicator& <UpdateInitMgr>b__25_1(); // 0x06999970
	WizardGames.Soc.Common.Synchronization.MgrTime& <UpdateInitMgr>b__25_2(); // 0x06999a00
	WizardGames.Soc.SocClient.Indicator.MgrIndicator& <LoadLoginSceneAsync>b__47_0(); // 0x06999a90
	WizardGames.Soc.Common.Synchronization.MgrTime& <LoadLoginSceneAsync>b__47_1(); // 0x06999b20
	WizardGames.Soc.SocClient.Network.SocClientService& <LoadLoginSceneAsync>b__47_2(); // 0x06999bb0
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Main.SocReplayMgr.<LoadGameSceneAsync>d__46 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Main.SocReplayMgr <>4__this; // 0x30
	System.Runtime.CompilerServices.TaskAwaiter<System.ValueTuple<System.Boolean,System.String>> <>u__1; // 0x38
	System.Runtime.CompilerServices.TaskAwaiter <>u__2; // 0x40
	System.Void MoveNext(); // 0x06999c40
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x0699a20c
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Main.SocReplayMgr.<LoadLoginSceneAsync>d__47 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Main.SocReplayMgr <>4__this; // 0x30
	System.Runtime.CompilerServices.TaskAwaiter<System.ValueTuple<System.Boolean,System.String>> <>u__1; // 0x38
	System.Void MoveNext(); // 0x0699a2b0
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x0699b0e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Main.Hall : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x0699b18c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Main.SocClientApplicationLoop : WizardGames.Soc.Common.Unity.Main.UnityMainLoop
{
	static SocLogger logger; // 0x0
	System.String ServerIP; // 0x38
	System.Boolean isSceneLoaded; // 0x40
	static System.Boolean isOnline; // 0x8
	static WizardGames.Soc.SocClient.Log.SocClientLogService ClientLogService; // 0x10
	static System.Action OnEnterLobbyScene; // 0x18
	static System.Action LateUpdateAction; // 0x20
	WizardGames.Soc.Common.Unity.Main.LoopType get__loopType(); // 0x0699b1f4
	System.Void Awake(); // 0x055049cc
	static UnityEngine.AzureSky.AzureWeatherPresetEnum RemapWeathrPreset(UnityEngine.AzureSky.AzureWeatherPresetEnum weather); // 0x0699b9c0
	static System.Void InitProfiler(); // 0x0699bc0c
	static System.Void RestartApp(); // 0x0699bcbc
	System.Void Start(); // 0x0699bd3c
	System.Void CheckDll(); // 0x0699be18
	System.Void OnDestroy(); // 0x0699be78
	System.Void OnSceneHasLoaded(); // 0x0699c068
	static System.Void CreateEffectManager(); // 0x0699c144
	static System.Void CreateGameMainLoop(); // 0x0699c254
	System.Void BeforeExitGameScene(); // 0x0699c3b4
	System.Void AfterExitGameScene(); // 0x0699c788
	static System.Void OnLobbySceneReady(); // 0x0699cc38
	System.Void OnFpsUnlimitedUpdate(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x0699d004
	System.Void OnFps30Update(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x0699d78c
	System.Void OnFps10Update(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x0699d948
	System.Void OnFps2Update(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x0699da50
	System.Void OnFps1Update(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x0699db40
	System.Void DeviceMemoryMonitor(); // 0x0699dda0
	System.Void InitErrorLogFormatter(); // 0x0699de28
	System.Void OnSceneLoaded(UnityEngine.SceneManagement.Scene iScene, UnityEngine.SceneManagement.LoadSceneMode iMode); // 0x0699e01c
	System.Void OnSceneUnloaded(UnityEngine.SceneManagement.Scene iScene); // 0x0699e098
	System.Void OnApplicationPause(System.Boolean pauseStatus); // 0x0699e10c
	System.Void FireBeforeSkinSystem(); // 0x0699e49c
	System.Void OnApplicationQuit(); // 0x0699e570
	System.Void LogoutWhenApplicationQuit(); // 0x0699ec2c
	System.Void OnLateUpdate(); // 0x0699ec8c
	System.Void .ctor(); // 0x0699edc4
	static System.Void .cctor(); // 0x0699ee80
}

// Client.Runtime
class WizardGames.Soc.SocClient.Main.SocClientApplicationLoop.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Main.SocClientApplicationLoop.<>c <>9; // 0x0
	static System.Func<WizardGames.Soc.Common.Unity.Animation.ISocAnimationRuntime> <>9__9_0; // 0x8
	static System.Action <>9__21_1; // 0x10
	static System.Action <>9__21_0; // 0x18
	static System.Func<System.String> <>9__28_0; // 0x20
	static System.Func<System.String> <>9__28_1; // 0x28
	static System.Void .cctor(); // 0x0699f1e0
	System.Void .ctor(); // 0x0699f244
	WizardGames.Soc.Common.Unity.Animation.ISocAnimationRuntime <Awake>b__9_0(); // 0x0699f2ac
	System.Void <OnLobbySceneReady>b__21_0(); // 0x0699f338
	System.Void <OnLobbySceneReady>b__21_1(); // 0x0699f54c
	System.String <InitErrorLogFormatter>b__28_0(); // 0x0699f618
	System.String <InitErrorLogFormatter>b__28_1(); // 0x0699f850
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Main.SocClientApplicationLoop.<OnSceneHasLoaded>d__16 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Main.SocClientApplicationLoop <>4__this; // 0x38
	System.Void MoveNext(); // 0x0699fab4
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x0699fbfc
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Main.SocClientApplicationLoop.<Start>d__13 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Main.SocClientApplicationLoop <>4__this; // 0x38
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x40
	System.Runtime.CompilerServices.TaskAwaiter<WizardGames.Soc.SocClient.Utility.DeviceInfo> <>u__2; // 0x48
	System.Void MoveNext(); // 0x0699fc7c
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x069a0dac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Main.SocClientMainLoop : WizardGames.Soc.Common.Unity.Main.UnityMainLoop
{
	static SocLogger logger; // 0x0
	System.Int32 allPhsicsTime; // 0x34
	System.Int32 FrameTime; // 0x38
	System.Int32 HighFrameTimeChangeTime; // 0x3c
	System.Int32 TimeRemainder; // 0x40
	System.Int32 PhysicsTimeRemainder; // 0x44
	System.Single lastLowMemoryCleanTime; // 0x48
	static System.Int64 lastNetWorkUpdateTs; // 0x8
	System.Int64 lastTouchTime; // 0x50
	System.Boolean isNoTouch; // 0x58
	System.Int32 horseRealTimeDelta; // 0x5c
	System.String[] newbiePreUI; // 0x60
	System.String[] newbiePreOpenUI; // 0x68
	static System.Single <AppMaxUsageMemForUIPlay>k__BackingField; // 0x10
	System.Collections.Generic.HashSet<System.String> monsterAssetsPath; // 0x70
	System.Collections.Generic.List<System.String> commonAssetsPath; // 0x78
	System.Int32 TickCount; // 0x80
	System.Int32 TickTimeTotal; // 0x84
	System.Int32 avgTimeSince; // 0x88
	System.Int32 _lastFrameTime; // 0x8c
	Systems.ClientChangeWorld changeWorld; // 0x90
	static WritableString positionStr; // 0x18
	static System.Action<Systems.ClientChangeWorld> LateUpdate_SystemOnCmd; // 0x28
	static System.Action<Systems.ClientChangeWorld> LateUpdate_System; // 0x30
	static System.Action<Systems.ClientChangeWorld> AfterAnimBegin_System; // 0x38
	static System.Action<Systems.ClientChangeWorld> BeforeAnimBegin_System; // 0x40
	static System.Action<WizardGames.Soc.SocClient.Main.SocClientMainLoop> LateUpdate_MyPlayer; // 0x48
	static System.Action LateUpdate_Construction; // 0x50
	static System.Action LateUpdate_Photo; // 0x58
	static System.Action LateUpdate_Admin; // 0x60
	static System.Action LateUpdate_NetWorkMonitor; // 0x68
	static System.Action<System.Int32> OnFpsUnlimitedUpdate_UpdateService; // 0x70
	static System.Action OnFpsUnlimitedUpdate_UpdateTimer; // 0x78
	static System.Action OnFpsUnlimitedUpdate_SnapshotReceiver; // 0x80
	static System.Action<System.Int32> OnFpsUnlimitedUpdate_UI; // 0x88
	static System.Action<System.Int32> OnFpsUnlimitedUpdate_Input; // 0x90
	static System.Action OnFpsUnlimitedUpdate_SnapshotEvent; // 0x98
	static System.Action OnFpsUnlimitedUpdate_Construction_RenderUpdate; // 0xa0
	static System.Action OnFpsUnlimitedUpdate_Construction_RenderAndColliderQueueUpdate; // 0xa8
	static System.Action<System.Int32,Systems.ClientChangeWorld> OnFpsUnlimitedUpdate_System_Update; // 0xb0
	static System.Func<System.Int32,System.Int32,System.Int32,WizardGames.Soc.SocClient.Main.SocClientMainLoop,System.Int32> OnFpsUnlimitedUpdate_OnLogicDynamicUpdate; // 0xb8
	static System.Action<System.Int32,Systems.ClientChangeWorld> OnFpsUnlimitedUpdate_CameraAndPlayerUpdate; // 0xc0
	static System.Action<System.Int32> OnFpsUnlimitedUpdate_PredictGoUpdate; // 0xc8
	static System.Action<System.Int32> OnFpsUnlimitedUpdate_NewbieLevelUpdate; // 0xd0
	static System.Action<System.Int32> OnFps10Update_TimelineUpdate; // 0xd8
	static System.Action OnFpsUnlimitedUpdate_ParabolaAndCheckPredictError; // 0xe0
	static System.Action<Systems.ClientChangeWorld> OnFpsUnlimitedUpdate_RenderUserCmdSystemUpdate; // 0xe8
	static System.Action<System.Int32,Systems.ClientChangeWorld> OnFpsUnlimitedUpdate_SystemOnRenderUpdate; // 0xf0
	static System.Action<WizardGames.Soc.SocClient.Main.SocClientMainLoop,System.Int32> OnFpsUnlimitedUpdate_SendCmd; // 0xf8
	static System.Action OnFpsUnlimitedUpdate_LocalSnapshotEvent; // 0x100
	static System.Action OnFpsUnlimitedUpdate_ObjRender; // 0x108
	static System.Action OnFpsUnlimitedUpdate_EntityCareStates; // 0x110
	static System.Action OnFpsUnlimitedUpdate_IndicatorUpdate; // 0x118
	static System.Action OnFpsUnlimitedUpdate_SettingUpdate; // 0x120
	static System.Action<System.Int32> OnFixedFps30Update_UI; // 0x128
	static System.Action OnFps30Update_Hud; // 0x130
	static System.Action OnFixedFps30Update_Construction_LogicUpdate; // 0x138
	static System.Action OnFixedUnlimitedUpdate_WorldResource_RenderUpdate; // 0x140
	static System.Action<System.Int32,System.Int32,System.Int32> OnFixedFps30Update_PredictMove; // 0x148
	static System.Action OnFixedFps30Update_UserCmdSystemGroup; // 0x150
	static System.Action<Systems.ClientChangeWorld> OnFixedFps30Update_PostUserCmdSystemGroup; // 0x158
	static System.Action OnFixedFps30Update_UpdateAiAnimation30Fps; // 0x160
	static System.Action OnFps30Update_Msg; // 0x168
	static System.Action<System.Int32> OnFps30Update_GatherItemPickable; // 0x170
	static System.Action<System.Int32> OnFps30Update_EntityInstiante; // 0x178
	static System.Action OnFps10Update_AIUpdate; // 0x180
	static System.Action<System.Int32,Systems.ClientChangeWorld> OnFps10Update_SYS; // 0x188
	static System.Action<System.Int32> OnFps10Update_WorldFlag; // 0x190
	static System.Action<System.Int32> OnFps10Update_UI; // 0x198
	static System.Action OnFps1Update_BattleReportCheck; // 0x1a0
	static System.Action OnFps10Update_PowerOptimization; // 0x1a8
	static System.Action<System.Int32> OnFps10Update_Enhance; // 0x1b0
	static System.Action OnFps10Update_DynLight; // 0x1b8
	static System.Action OnFps1Update_Guide; // 0x1c0
	static System.Action OnFps1Update_DisposeMeshRenderConfig; // 0x1c8
	static System.Action OnFps10Update_VehicleTrigger; // 0x1d0
	static System.Action OnFps10Update_Signifiance; // 0x1d8
	static System.Action OnFps10Update_Water; // 0x1e0
	static System.Action OnFps10Update_HudMsg; // 0x1e8
	static System.Action OnFps10Update_Other; // 0x1f0
	static System.Action OnFps2Update_Marker; // 0x1f8
	static System.Action<System.Int32> OnFps2Update_UI; // 0x200
	static System.Action OnFps2Update_PermCenter; // 0x208
	static System.Action<System.Int32> OnFps2Update_QuickActBubble; // 0x210
	static System.Action OnFps1Update_Go; // 0x218
	static System.Action OnFps1Update_Marker; // 0x220
	static System.Action OnFps30Update_Res; // 0x228
	static System.Action<System.Int32> OnFps30Update_Voice; // 0x230
	static System.Action<System.Int32> OnFps1Update_SDK; // 0x238
	static System.Action<System.Int32> OnFps1Update_RemoteCallPing; // 0x240
	static System.Action<System.Int32> OnFps1Update_UI; // 0x248
	static System.Action OnFps1Update_PowerOptimization; // 0x250
	static System.Action OnFps1Update_PermCenter; // 0x258
	static System.Action OnFps1Update_TreeControl; // 0x260
	static System.Action OnFps1Update_MonumentPreventBuildings; // 0x268
	static System.Action<System.Int32> OnFps1Update_ReportData; // 0x270
	static System.Action OnFps1Update_Setting; // 0x278
	static System.Action<System.Int32> OnAfterUpdate_AimAdsorb; // 0x280
	static System.Action<System.Int32,Systems.ClientChangeWorld> OnAfterUpdate_System; // 0x288
	static System.Action Client_FixedUpdate; // 0x290
	static System.Action OnFps1Update_WireControl; // 0x298
	static System.Action OnAfterUpdate_WireControl; // 0x2a0
	static System.Action OnFps1Update_Thermal; // 0x2a8
	static System.Action OnFpsUnlimitedUpdate_Thermal; // 0x2b0
	static System.Action OnFpsUnlimitedUpdate_SoundPrint; // 0x2b8
	WizardGames.Soc.Common.Unity.Main.LoopType get__loopType(); // 0x069a0e2c
	static System.Single get_AppMaxUsageMemForUIPlay(); // 0x069a0e90
	static System.Void set_AppMaxUsageMemForUIPlay(System.Single value); // 0x069a0f18
	System.Void Start(); // 0x069a0fb4
	System.Void OnDestroy(); // 0x069a1098
	System.Void PreloadWeaponOrItem(System.Int64 templateId, System.Int64 skinId); // 0x069a16b8
	System.Threading.Tasks.Task PreloadCharacterBeltAsset(); // 0x069a1cd4
	System.Void PreloadMonsterAsset(); // 0x069a1de8
	System.Void PreloadCommonAssetsPath(); // 0x069a2324
	System.Threading.Tasks.Task PreloadAssets(); // 0x069a2650
	System.Void CachePreloadGameObjects(System.String prefabPath, System.Int32 maxSize); // 0x069a2760
	System.Void PreLoadTeammateDefaultModel(); // 0x069a29f0
	System.Void PreloadConstructionAssets(); // 0x069a2ca0
	System.Void Update(); // 0x069a31c0
	System.Void ProfileAndExecute(WizardGames.Soc.Common.Profile.EProfileFunc mark, System.Action act); // 0x069a3228
	System.Void ProfileAndExecute<T1>(WizardGames.Soc.Common.Profile.EProfileFunc mark, System.Action<T1> act, T1 param1); // 0x052af1f0
	System.Void ProfileAndExecute<T1,T2>(WizardGames.Soc.Common.Profile.EProfileFunc mark, System.Action<T1,T2> act, T1 param1, T2 param2); // 0x052af1f0
	System.Void ProfileAndExecute<T1,T2,T3>(WizardGames.Soc.Common.Profile.EProfileFunc mark, System.Action<T1,T2,T3> act, T1 param1, T2 param2, T3 param3); // 0x052af1f0
	R ProfileAndExecute<R,T1,T2,T3,T4>(WizardGames.Soc.Common.Profile.EProfileFunc mark, System.Func<T1,T2,T3,T4,R> act, T1 param1, T2 param2, T3 param3, T4 param4); // 0x052af1f0
	System.Void OnLateUpdate(); // 0x069a3480
	System.Void FireAfterAnimBeginSystem(); // 0x069a3778
	System.Void FireBeginAnimBeginSystem(); // 0x069a382c
	System.Void OnFrameEnd(); // 0x069a38e0
	System.Void OnFpsUnlimitedUpdate(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x069a3990
	static System.Void CameraAndPlayerUpdate(System.Int32 timeSinceLastUpdate); // 0x069a416c
	System.Void SendCmd(System.Int32 interval); // 0x069a443c
	System.Int32 OnLogicDynamicUpdate(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x069a4750
	System.Void PostSynamicLogicFrameTime(); // 0x069a58a8
	System.Void ClientDynamicLogicFrameTime(System.Int32 timeSinceLastUpdate, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x069a4d18
	System.Int32 PostCorrectFrameTime(System.Int32 frametime, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x0548c2dc
	System.Void CheckDynamicFrameTime(); // 0x069a592c
	System.Void OnFps30Update(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x069a5a0c
	System.Void OnFps10Update(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x069a5c58
	System.Void OnFps2Update(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x069a5eac
	System.Void OnFps1Update(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x069a5ff8
	System.Void OnAfterUpdate(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x069a634c
	System.Void FixedUpdate(); // 0x069a6480
	static System.Int32 MaterialGetter(UnityEngine.Vector3 pos); // 0x069a6518
	static System.Void UpdateWorldTime(); // 0x069a6718
	static System.Void UpdateCrashSight(); // 0x069a6834
	System.Void DeviceMemoryMonitor(); // 0x069a627c
	System.Threading.Tasks.Task ExitWorld(); // 0x069a6e54
	System.Void OnApplicationPause(System.Boolean pauseStatus); // 0x069a6ebc
	System.Void OnApplicationQuit(); // 0x069a7518
	System.Void OnLowMemory(); // 0x069a7884
	System.Void .ctor(); // 0x069a7ca8
	static System.Void .cctor(); // 0x069a8010
}

// Client.Runtime
class WizardGames.Soc.SocClient.Main.SocClientMainLoop.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Main.SocClientMainLoop.<>c <>9; // 0x0
	static System.Action<FairyGUI.TouchInfo> <>9__66_0; // 0x8
	static System.Void .cctor(); // 0x069a9d5c
	System.Void .ctor(); // 0x069a9dc0
	System.Void <OnApplicationPause>b__66_0(FairyGUI.TouchInfo touch); // 0x069a9e28
	System.Void <.cctor>b__153_0(Systems.ClientChangeWorld cw); // 0x069a9ecc
	System.Void <.cctor>b__153_1(Systems.ClientChangeWorld cw); // 0x069aa008
	System.Void <.cctor>b__153_2(Systems.ClientChangeWorld cw); // 0x069aa124
	System.Void <.cctor>b__153_3(Systems.ClientChangeWorld cw); // 0x069aa240
	System.Void <.cctor>b__153_4(WizardGames.Soc.SocClient.Main.SocClientMainLoop mainloop); // 0x069aa35c
	System.Void <.cctor>b__153_5(); // 0x069aa730
	System.Void <.cctor>b__153_6(); // 0x069aa7d0
	System.Void <.cctor>b__153_7(); // 0x069aa874
	System.Void <.cctor>b__153_8(); // 0x069aa918
	System.Void <.cctor>b__153_9(System.Int32 deltaTime); // 0x069aa9b4
	System.Void <.cctor>b__153_10(); // 0x069aae10
	System.Void <.cctor>b__153_11(); // 0x069ab4a0
	System.Void <.cctor>b__153_12(System.Int32 deltaTime); // 0x069ab5c4
	System.Void <.cctor>b__153_13(System.Int32 deltaTime); // 0x069ab69c
	System.Void <.cctor>b__153_14(); // 0x069abc28
	System.Void <.cctor>b__153_15(); // 0x069abcd8
	System.Void <.cctor>b__153_16(); // 0x069abd70
	System.Void <.cctor>b__153_17(System.Int32 deltaTime, Systems.ClientChangeWorld cw); // 0x0550f6d4
	System.Int32 <.cctor>b__153_18(System.Int32 deltaTime, System.Int32 timeToNext, System.Int32 fps, WizardGames.Soc.SocClient.Main.SocClientMainLoop mainLoop); // 0x069ac35c
	System.Void <.cctor>b__153_19(System.Int32 deltaTime, Systems.ClientChangeWorld cw); // 0x069ac418
	System.Void <.cctor>b__153_20(System.Int32 deltaTime); // 0x069ac714
	System.Void <.cctor>b__153_21(System.Int32 deltaTime); // 0x069ac7c0
	System.Void <.cctor>b__153_22(System.Int32 deltaTime); // 0x069ac880
	System.Void <.cctor>b__153_23(); // 0x069ac940
	System.Void <.cctor>b__153_24(Systems.ClientChangeWorld cw); // 0x069ac9f8
	System.Void <.cctor>b__153_25(System.Int32 deltaTime, Systems.ClientChangeWorld cw); // 0x069acdb4
	System.Void <.cctor>b__153_26(WizardGames.Soc.SocClient.Main.SocClientMainLoop loop, System.Int32 ft); // 0x069ace78
	System.Void <.cctor>b__153_27(); // 0x069acf04
	System.Void <.cctor>b__153_28(); // 0x069acf64
	System.Void <.cctor>b__153_29(); // 0x069ad000
	System.Void <.cctor>b__153_30(); // 0x069ad0a4
	System.Void <.cctor>b__153_31(); // 0x069ad140
	System.Void <.cctor>b__153_32(System.Int32 deltaTime); // 0x069ad1dc
	System.Void <.cctor>b__153_33(); // 0x069ad298
	System.Void <.cctor>b__153_34(); // 0x069ad33c
	System.Void <.cctor>b__153_35(); // 0x069ad3d4
	System.Void <.cctor>b__153_36(System.Int32 ft, System.Int32 timeSinceLastUpdate, System.Int32 physicsUpdateCount); // 0x069ad478
	System.Void <.cctor>b__153_37(); // 0x069ada24
	System.Void <.cctor>b__153_38(Systems.ClientChangeWorld cw); // 0x069add50
	System.Void <.cctor>b__153_39(); // 0x069ae084
	System.Void <.cctor>b__153_40(); // 0x069ae168
	System.Void <.cctor>b__153_41(System.Int32 deltaTime); // 0x069ae204
	System.Void <.cctor>b__153_42(System.Int32 deltaTime); // 0x069ae2c4
	System.Void <.cctor>b__153_43(); // 0x069ae394
	System.Void <.cctor>b__153_44(System.Int32 deltaTime, Systems.ClientChangeWorld cw); // 0x069ae478
	System.Void <.cctor>b__153_45(System.Int32 deltaTime); // 0x069ae540
	System.Void <.cctor>b__153_46(System.Int32 deltaTime); // 0x069ae600
	System.Void <.cctor>b__153_47(); // 0x069ae6bc
	System.Void <.cctor>b__153_48(); // 0x069ae760
	System.Void <.cctor>b__153_49(System.Int32 deltaTime); // 0x069ae7fc
	System.Void <.cctor>b__153_50(); // 0x069ae8bc
	System.Void <.cctor>b__153_51(); // 0x069ae91c
	System.Void <.cctor>b__153_52(); // 0x069ae9b8
	System.Void <.cctor>b__153_53(); // 0x069aea48
	System.Void <.cctor>b__153_54(); // 0x069aeaec
	System.Void <.cctor>b__153_55(); // 0x069aebbc
	System.Void <.cctor>b__153_56(); // 0x069aec58
	System.Void <.cctor>b__153_57(); // 0x069aed04
	System.Void <.cctor>b__153_58(); // 0x069aeda0
	System.Void <.cctor>b__153_59(System.Int32 deltaTime); // 0x069aee00
	System.Void <.cctor>b__153_60(); // 0x069aeebc
	System.Void <.cctor>b__153_61(System.Int32 dt); // 0x069aef60
	System.Void <.cctor>b__153_62(); // 0x069af020
	System.Void <.cctor>b__153_63(); // 0x069af104
	System.Void <.cctor>b__153_64(); // 0x069af164
	System.Void <.cctor>b__153_65(System.Int32 deltaTime); // 0x069af1f0
	System.Void <.cctor>b__153_66(System.Int32 deltaTime); // 0x069af2d4
	System.Void <.cctor>b__153_67(System.Int32 deltaTime); // 0x069af3d0
	System.Void <.cctor>b__153_68(System.Int32 deltaTime); // 0x069af4fc
	System.Void <.cctor>b__153_69(); // 0x069af624
	System.Void <.cctor>b__153_70(); // 0x069af6c0
	System.Void <.cctor>b__153_71(); // 0x069af764
	System.Void <.cctor>b__153_72(); // 0x069af808
	System.Void <.cctor>b__153_73(System.Int32 timeSinceLastUpdate); // 0x069af8ac
	System.Void <.cctor>b__153_74(); // 0x069af9b8
	System.Void <.cctor>b__153_75(System.Int32 deltaTime); // 0x069afa64
	System.Void <.cctor>b__153_76(System.Int32 deltaTime, Systems.ClientChangeWorld cw); // 0x069afad8
	System.Void <.cctor>b__153_77(); // 0x069afb9c
	System.Void <.cctor>b__153_78(); // 0x069afc74
	System.Void <.cctor>b__153_79(); // 0x069afd18
	System.Void <.cctor>b__153_80(); // 0x069afdbc
	System.Void <.cctor>b__153_81(); // 0x069afe58
	System.Void <.cctor>b__153_82(); // 0x069afef4
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Main.SocClientMainLoop.<PreloadAssets>d__27 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Main.SocClientMainLoop <>4__this; // 0x30
	WizardGames.Soc.Common.Unity.Scene.SceneConfig <sceneCfg>5__2; // 0x38
	System.Int32[] <>7__wrap2; // 0x40
	System.Int32 <>7__wrap3; // 0x48
	System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1; // 0x4c
	System.Void MoveNext(); // 0x069aff90
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x069b1288
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Main.SocClientMainLoop.<PreloadCharacterBeltAsset>d__22 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Main.SocClientMainLoop <>4__this; // 0x30
	System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int64,WizardGames.Soc.Common.CustomType.NodeBase>> <>7__wrap1; // 0x38
	System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1; // 0x40
	System.Void MoveNext(); // 0x069b132c
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x069b1ac4
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Main.SocClientMainLoop.<Start>d__19 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Main.SocClientMainLoop <>4__this; // 0x38
	Assets.Scripts.MicroServiceClient.MicroServiceClient <microSvr>5__2; // 0x40
	WizardGames.Soc.SocClient.Network.SocClientService <localService>5__3; // 0x48
	System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1; // 0x50
	System.Runtime.CompilerServices.TaskAwaiter <>u__2; // 0x58
	WizardGames.Soc.SocClient.GoLoader.LoadFullSnapshotProgress <loadSnapshotProgress>5__4; // 0x60
	System.Void MoveNext(); // 0x069b1b68
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x069b40c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Main.SocClientMainLoopOffline : WizardGames.Soc.Common.Unity.Main.UnityMainLoop
{
	Systems.ClientChangeWorld changeWorld; // 0x38
	WizardGames.Soc.Common.Entity.PlayerEntity serverPlayerEntity; // 0x40
	System.Int32 FrameTime; // 0x48
	System.Int32 TimeRemainder; // 0x4c
	System.Int32 itemPosIndex; // 0x50
	WizardGames.Soc.Common.Unity.Main.LoopType get__loopType(); // 0x069b4144
	System.Void Start(); // 0x069b41a8
	System.Void ChangeWeapon(System.Int64 tableId); // 0x069b4288
	System.Void ChangeDeployItem(System.Int64 tableId); // 0x069b48d8
	System.Void OnFpsUnlimitedUpdate(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x069b4b44
	System.Void Update(); // 0x069b5ad4
	System.Void OnLateUpdate(); // 0x069b5bdc
	System.Void InputUpdate(); // 0x069b5b44
	System.Void OnFixedFps30Update(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x069b52e8
	System.Void OnFps30Update(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x069b5d70
	System.Void OnFps10Update(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x069b5e94
	System.Void OnFps1Update(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x069b5f9c
	System.Void OnAfterUpdate(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x069b60d0
	System.Void MyPlayerLoadSuccess(); // 0x069b61f4
	System.Int32 MaterialGetter(UnityEngine.Vector3 pos); // 0x069b64b4
	System.Void .ctor(); // 0x069b65fc
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Main.SocClientMainLoopOffline.<Start>d__7 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Main.SocClientMainLoopOffline <>4__this; // 0x38
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x40
	System.Void MoveNext(); // 0x069b66e0
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x069b76b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Relay.Record : System.Object
{
	static SocLogger logger; // 0x0
	static System.Int32 MapId; // 0x8
	static WizardGames.Soc.Share.Framework.RecordInfo RecordInfo; // 0x10
	static System.IO.FileStream fs; // 0x18
	static System.IO.StreamReader sw; // 0x20
	static System.Int32 consumed; // 0x28
	static System.Byte[] buffer; // 0x30
	static System.Collections.Concurrent.ConcurrentQueue<System.ValueTuple<System.Int64,System.Collections.Generic.Queue<WizardGames.Soc.Common.Framework.Network.BasePacket>>> <DecodedPackets>k__BackingField; // 0x38
	static System.Collections.Generic.Queue<WizardGames.Soc.Common.Framework.Network.BasePacket> packets; // 0x40
	static System.Threading.Thread recordThread; // 0x48
	static System.Threading.EventWaitHandle ewh; // 0x50
	static System.Boolean isError; // 0x58
	static System.Int32 waitCnt; // 0x5c
	static System.Int32 <decodedCount>k__BackingField; // 0x60
	static System.Int32 <totalCount>k__BackingField; // 0x64
	static System.Boolean <isFinished>k__BackingField; // 0x68
	static System.Collections.Concurrent.ConcurrentQueue<System.ValueTuple<System.Int64,System.Collections.Generic.Queue<WizardGames.Soc.Common.Framework.Network.BasePacket>>> get_DecodedPackets(); // 0x069b7738
	static System.Int32 get_decodedCount(); // 0x069b77c0
	static System.Void set_decodedCount(System.Int32 value); // 0x069b7848
	static System.Int32 get_totalCount(); // 0x069b78d8
	static System.Void set_totalCount(System.Int32 value); // 0x069b7960
	static System.Boolean get_isFinished(); // 0x069b79f0
	static System.Void set_isFinished(System.Boolean value); // 0x069b7a78
	static System.Void StartReadRecord(System.String path); // 0x069b7b0c
	static System.Void ReadRecord(System.String path); // 0x069b7ccc
	static System.Void DecodeOnePacket(); // 0x069b8284
	static System.Void Update(); // 0x069b8c44
	static System.ValueTuple<System.Int64,System.Collections.Generic.Queue<WizardGames.Soc.Common.Framework.Network.BasePacket>> GetDecodedPackets(); // 0x069b925c
	static System.ValueTuple<System.Boolean,System.Int32,WizardGames.Soc.Common.Framework.Network.BasePacket> DeserializeRecord(MessagePack.MessagePackReader& reader, System.Byte[] buffer); // 0x069b86bc
	static System.Boolean CheckRecord(System.String path); // 0x054c4760
	static System.Void Clear(); // 0x069b9160
	static System.Void .cctor(); // 0x069b9bf4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Relay.Record.<>c__DisplayClass29_0 : System.Object
{
	System.String path; // 0x10
	System.Void .ctor(); // 0x069b7c64
	System.Void <StartReadRecord>b__0(); // 0x069b9e0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Relay.ReplayFileDownloader : System.Object
{
	static SocLogger Logger; // 0x0
	System.String FileName; // 0x10
	System.String FilePath; // 0x18
	System.Boolean Update(System.Single delta); // 0x069b9e9c
	System.Void DownloadFile(System.String fileName); // 0x069b9f74
	System.String GetDownloadUrl(System.String fileName); // 0x069ba158
	System.String GetSavePath(System.String fileName); // 0x069ba080
	System.Void .ctor(); // 0x069ba1ec
	static System.Void .cctor(); // 0x069ba254
}

// Client.Runtime
class WizardGames.Soc.SocClient.Framework.AsyncTaskBase : System.Object
{
	
	System.Void ExcuteFunc(); // 0x055049cc
	System.Void .ctor(); // 0x069ba328
}

// Client.Runtime
class WizardGames.Soc.SocClient.Framework.AsyncTaskQueue<T> : System.Object
{
	static SocLogger logger; // 0x0
	System.Collections.Concurrent.ConcurrentQueue<T> taskQueue; // 0x0
	System.Int32 excuteTaskCount; // 0x0
	System.Int32 <TooManyTasksWarningCount>k__BackingField; // 0x0
	System.Int32 get_TooManyTasksWarningCount(); // 0x0548ba98
	System.Void PostAsyncTask(T task); // 0x052af1f0
	System.Int32 ProcessAsyncTask(System.Boolean doneAll); // 0x0549a158
	System.Void .ctor(); // 0x055049cc
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
class WizardGames.Soc.SocClient.Framework.PostToKcpTask : WizardGames.Soc.SocClient.Framework.AsyncTaskBase
{
	
	System.Void .ctor(); // 0x069ba390
}

// Client.Runtime
class WizardGames.Soc.SocClient.Framework.KcpThread : WizardGames.Soc.SocClient.Framework.ThreadBase<WizardGames.Soc.SocClient.Framework.PostToKcpTask>
{
	WizardGames.Soc.SocClient.Network.KcpClient kcpClient; // 0x28
	System.String ipAddress; // 0x30
	System.Int32 port; // 0x38
	System.Void .ctor(System.String ipAddress, System.Int32 port, WizardGames.Soc.SocClient.Network.KcpClient client); // 0x069ba3f4
	System.Boolean Boot(); // 0x069ba4e8
	System.Void Loop(); // 0x069ba60c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Framework.OnDataReceivedTask : WizardGames.Soc.SocClient.Framework.PostToKcpTask, WizardGames.Soc.Common.Cache.IPooledObject
{
	static WizardGames.Soc.Common.Cache.PoolWithLock<WizardGames.Soc.SocClient.Framework.OnDataReceivedTask> pool; // 0x0
	System.ArraySegment<System.Byte> data; // 0x10
	WizardGames.Soc.Common.Framework.Network.Impl.UdpBuffer socketInfo; // 0x20
	WizardGames.Soc.SocClient.Network.KcpClient host; // 0x28
	System.Boolean <IsReturn>k__BackingField; // 0x30
	System.Boolean get_IsReturn(); // 0x069ba83c
	System.Void set_IsReturn(System.Boolean value); // 0x069ba8a0
	static WizardGames.Soc.SocClient.Framework.OnDataReceivedTask GetFromPool(System.ArraySegment<System.Byte>& data, WizardGames.Soc.Common.Framework.Network.Impl.UdpBuffer info, WizardGames.Soc.SocClient.Network.KcpClient host); // 0x069ba91c
	System.Void ExcuteFunc(); // 0x069baa28
	System.Void ReturnToPool(); // 0x069baaac
	System.Void .ctor(); // 0x069babec
	static System.Void .cctor(); // 0x069bac50
}

// Client.Runtime
class WizardGames.Soc.SocClient.Framework.SimpleTask : WizardGames.Soc.SocClient.Framework.PostToKcpTask
{
	static SocLogger logger; // 0x0
	System.Action action; // 0x10
	System.Void .ctor(System.Action action); // 0x069bacf0
	System.Void ExcuteFunc(); // 0x069bad78
	static System.Void .cctor(); // 0x069baed0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Framework.ThreadBase<T> : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Framework.AsyncTaskQueue<T> <Queue>k__BackingField; // 0x0
	System.Threading.Thread thread; // 0x0
	System.Int32 State; // 0x0
	WizardGames.Soc.SocClient.Framework.AsyncTaskQueue<T> get_Queue(); // 0x054e7844
	System.Boolean Boot(); // 0x054c4760
	System.Void Loop(); // 0x055049cc
	System.Void .ctor(); // 0x055049cc
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
class WizardGames.Soc.SocClient.Framework.ThreadHelper : System.Object
{
	static SocLogger logger; // 0x0
	static System.Void PostToKcpThread(WizardGames.Soc.SocClient.Framework.PostToKcpTask task); // 0x069bafa4
	static System.Void .cctor(); // 0x069bb228
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Electric.IICCmdClient : 
{
	
	System.Void ApplyCmd_Client(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Electric.ICCmd_UnitAddClient : WizardGames.Soc.Common.SimpleCustom.ICCmd_UnitAdd, WizardGames.Soc.SocClient.Electric.IICCmdClient
{
	System.Int64 localEntityId; // 0x18
	System.Void ApplyCmd_Client(); // 0x069bb2fc
	System.Boolean GenRevertCmd(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit, WizardGames.Soc.Common.SimpleCustom.ICmd& rcmd); // 0x069bb584
	System.Void .ctor(); // 0x069bb6e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Electric.ICCmd_UnitRemoveClient : WizardGames.Soc.Common.SimpleCustom.ICCmd_UnitRemove, WizardGames.Soc.SocClient.Electric.IICCmdClient
{
	
	System.Void ApplyCmd_Client(); // 0x069bb76c
	System.Boolean GenRevertCmd(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit, WizardGames.Soc.Common.SimpleCustom.ICmd& rcmd); // 0x069bbc7c
	System.Void .ctor(); // 0x069bb654
}

// Client.Runtime
class WizardGames.Soc.SocClient.Electric.ICCmd_WireAddClient : WizardGames.Soc.Common.SimpleCustom.ICCmd_WireAdd, WizardGames.Soc.SocClient.Electric.IICCmdClient
{
	
	System.Void ApplyCmd_Client(); // 0x069bbd0c
	System.Boolean GenRevertCmd(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit, WizardGames.Soc.Common.SimpleCustom.ICmd& rcmd); // 0x069bbd6c
	System.Void .ctor(); // 0x069bbfa4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Electric.ICCmd_WireRemoveClient : WizardGames.Soc.Common.SimpleCustom.ICCmd_WireRemove, WizardGames.Soc.SocClient.Electric.IICCmdClient
{
	
	System.Void ApplyCmd_Client(); // 0x069bc030
	System.Boolean GenRevertCmd(WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit circuit, WizardGames.Soc.Common.SimpleCustom.ICmd& rcmd); // 0x069bc1d0
	System.Void .ctor(); // 0x069bbf18
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Electric.DrinkWaterMixin : System.ValueType
{
	System.Single lastDrink; // 0x10
	System.Void OnUiBtnClicked(WizardGames.Soc.Common.Component.ElectricBaseComponent electricComp, System.Int32 btnId, WizardGames.Soc.Common.Construction.PartType partType); // 0x069bc2ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Fx.FxUnderwater : System.Object
{
	System.Boolean lastCameraInWater; // 0x10
	WizardGames.Soc.SocClient.Water.MgrWater.EPlayerInWaterState lastPlayerInWaterState; // 0x14
	UnityEngine.GameObject PPV_UnderWater; // 0x18
	static System.String ppvName; // 0x0
	System.Single todSkyAtmosphereFogginess; // 0x20
	System.Single todSkyAtmosphereFogHeight; // 0x24
	System.Single todSkyAtmosphereFogTransition; // 0x28
	UnityEngine.Gradient todSkyDayFogColor; // 0x30
	System.Single todSkyDayLightIntensity; // 0x38
	System.Single todSkyDayShadowStrength; // 0x3c
	System.Single todSkyDayAmbientMultiplier; // 0x40
	System.Single todSkyDayReflectionMultiplier; // 0x44
	UnityEngine.Gradient todSkyNightFogColor; // 0x48
	System.Single todSkyNightLightIntensity; // 0x50
	System.Single todSkyNightShadowStrength; // 0x54
	System.Single todSkyNightAmbientMultiplier; // 0x58
	System.Single todSkyNightReflectionMultiplier; // 0x5c
	UnityEngine.AnimationCurve todSkyFogCurve; // 0x60
	static System.Single TickInterval = 0.20000000298023224;
	System.Single deltaTime; // 0x68
	System.Single lastHeadHeight; // 0x6c
	System.Boolean playedUnderWaterEffect; // 0x70
	System.Single deleteUnderWaterPrefabTick; // 0x74
	static System.Single blendUnderWaterHeight = 0.30000001192092896;
	System.Action<System.Boolean> cameraInWaterChangeAction; // 0x78
	System.Collections.Generic.List<UnityEngine.ParticleSystem> particles; // 0x80
	UnityEngine.GameObject underwaterEffect; // 0x88
	System.String underwaterEffectPath; // 0x90
	UnityEngine.Rendering.Volume UnderWarterVolume; // 0x98
	UnityEngine.GameObject PPV_All; // 0xa0
	System.Boolean get_CameraInWater(); // 0x069bc52c
	System.Void Start(); // 0x069bc590
	System.Void Clean(); // 0x069bc854
	System.Void RemoveUnderWaterEffect(); // 0x069bc930
	System.Void InitUnderWaterEffect(); // 0x069bca34
	System.Void PlayParticles(); // 0x069bcbf8
	System.Void StopParticles(); // 0x069bcdf4
	System.Void InitPostProcess(); // 0x069bc6d8
	System.Void OnDiveGlassWear(System.Boolean wear); // 0x069bcfc0
	System.Void SetPPV(System.Boolean cameraInWater); // 0x069bd0e0
	System.Void SetWaterQueue(System.Boolean cameraInWater); // 0x069bd1d4
	System.Void SetPostProcessVisible(System.Boolean cameraInWater); // 0x069bd304
	System.Void OnUIModelShow(System.Boolean isShow); // 0x069bd4a0
	System.Void Update(System.Boolean forceUpdate); // 0x069bd534
	System.Void .ctor(); // 0x069bdc8c
	static System.Void .cctor(); // 0x069bdd48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Effect.WeaponEffectData.WeaponEffectData : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	System.Int64 PlayerEntityId; // 0x20
	System.Int64 WeaponEntityId; // 0x28
	System.Int64 WeaponTableId; // 0x30
	System.Int64 WeaponSkinId; // 0x38
	System.Int32 SlotId; // 0x40
	System.Int32 Trigger; // 0x44
	System.Boolean MultiWeapon; // 0x48
	static System.Void AddRequest(System.Int64 playerEntityId, System.Int64 weaponId, System.Int64 weaponTableId, System.Int64 skinId, System.Int32 trigger); // 0x069bddb0
	static System.Void AddRequest(System.Int64 playerEntityId, System.Int64 weaponId, System.Int64 weaponTableId, System.Int64 skinId, System.Int32 trigger, System.Int32 slotId, System.Boolean multiWeapon); // 0x069bdec4
	System.Void .ctor(); // 0x069bdffc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Effect.CorrectedEffectData.CorrectedEffectData : System.Object
{
	UnityEngine.Transform effectTrans; // 0x10
	System.Void .ctor(); // 0x069be06c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Effect.CorrectedEffectData.CorrectedEffectDataSet : System.Object
{
	System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Effect.CorrectedEffectData.CorrectedEffectData> CorrectedEffectDatas; // 0x10
	System.Void .ctor(); // 0x069be0d4
	WizardGames.Soc.SocClient.Effect.CorrectedEffectData.CorrectedEffectData Pop(); // 0x069be188
	System.Void Add(UnityEngine.Transform effectTrans); // 0x069be234
	System.Boolean HasData(); // 0x069be324
	System.Void ReleaseCorrectedEffectData(WizardGames.Soc.SocClient.Effect.CorrectedEffectData.CorrectedEffectData data); // 0x069be3a8
}

// Client.Runtime
enum WizardGames.Soc.SocClient.DynamicLight.ELightState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.DynamicLight.ELightState OFF = 0;
	static WizardGames.Soc.SocClient.DynamicLight.ELightState ON = 1;
	static WizardGames.Soc.SocClient.DynamicLight.ELightState FLICKERING = 2;
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.DynamicLight.LightStateConfig : System.ValueType
{
	System.Int64 taskId; // 0x10
	WizardGames.Soc.SocClient.DynamicLight.ELightState lightState; // 0x18
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.DynamicLight.LightFlickering : UnityEngine.MonoBehaviour
{
	static System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.DynamicLight.LightFlickering> instances; // 0x0
	static System.Int32 EmissionColor; // 0x8
	UnityEngine.Light lightCom; // 0x30
	UnityEngine.GameObject[] lightObjects; // 0x38
	System.Single minIntensity; // 0x40
	System.Single maxIntensity; // 0x44
	System.Int32 smoothing; // 0x48
	WizardGames.Soc.SocClient.DynamicLight.ELightState defaultState; // 0x4c
	WizardGames.Soc.SocClient.DynamicLight.ELightState lightState; // 0x50
	WizardGames.Soc.SocClient.DynamicLight.ELightState targetState; // 0x54
	WizardGames.Soc.SocClient.DynamicLight.LightStateConfig[] taskConfig; // 0x58
	System.Single holdingProb; // 0x60
	System.Single holdingMinTime; // 0x64
	System.Single holdingMaxTime; // 0x68
	System.Collections.Generic.Queue<System.Single> smoothQueue; // 0x70
	System.Single lastSum; // 0x78
	System.Boolean isHolding; // 0x7c
	System.Single holdingTime; // 0x80
	System.Single holdingTimeLimit; // 0x84
	UnityEngine.Material[] instanceMats; // 0x88
	static System.Void UpdateAllLights(System.Int64 taskId); // 0x069be45c
	System.Void Start(); // 0x069be754
	System.Void InitLightObject(); // 0x069be888
	System.Void Update(); // 0x069beb50
	System.Void UpdateLight(System.Int64 taskId); // 0x069be5f8
	System.Void SetLightState(WizardGames.Soc.SocClient.DynamicLight.ELightState state); // 0x069bef60
	System.Void UpdateFlicker(); // 0x069bec50
	System.Void SetLightIntensity(System.Single value); // 0x069bedc0
	System.Void TryHoldFlicker(); // 0x069befd8
	System.Void OnEnable(); // 0x069bf068
	System.Void OnDisable(); // 0x069bf11c
	System.Void .ctor(); // 0x069bf1d0
	static System.Void .cctor(); // 0x069bf260
}

// Client.Runtime
class WizardGames.Soc.SocClient.Device.DeviceInfo : System.Object
{
	System.String <Id>k__BackingField; // 0x10
	System.String <DeviceName>k__BackingField; // 0x18
	System.String <DeviceModel>k__BackingField; // 0x20
	System.String <GraphicsName>k__BackingField; // 0x28
	System.String <FormatGraphicsName>k__BackingField; // 0x30
	System.String <GraphicsType>k__BackingField; // 0x38
	System.String <GraphicsMemorySize>k__BackingField; // 0x40
	System.String <GraphicsVersion>k__BackingField; // 0x48
	System.String <ProcessorType>k__BackingField; // 0x50
	System.String <OSVersion>k__BackingField; // 0x58
	static System.String ProcessorTypeCache; // 0x0
	static System.String OSVersionCache; // 0x8
	System.String get_Id(); // 0x069bf328
	System.Void set_Id(System.String value); // 0x069bf38c
	System.String get_DeviceName(); // 0x069bf40c
	System.Void set_DeviceName(System.String value); // 0x069bf470
	System.String get_DeviceModel(); // 0x069bf4f0
	System.Void set_DeviceModel(System.String value); // 0x069bf554
	System.String get_GraphicsName(); // 0x069bf5d4
	System.Void set_GraphicsName(System.String value); // 0x069bf638
	System.Void set_FormatGraphicsName(System.String value); // 0x069bf6b8
	System.String get_GraphicsType(); // 0x069bf738
	System.Void set_GraphicsType(System.String value); // 0x069bf79c
	System.String get_GraphicsMemorySize(); // 0x069bf81c
	System.Void set_GraphicsMemorySize(System.String value); // 0x069bf880
	System.String get_GraphicsVersion(); // 0x069bf900
	System.Void set_GraphicsVersion(System.String value); // 0x069bf964
	System.String get_ProcessorType(); // 0x069bf9e4
	System.Void set_ProcessorType(System.String value); // 0x069bfa48
	System.String get_OSVersion(); // 0x069bfac8
	System.Void set_OSVersion(System.String value); // 0x069bfb2c
	static WizardGames.Soc.SocClient.Device.DeviceInfo Collect(); // 0x069bfbac
	static System.String GetCPUName(); // 0x069c00f8
	static System.String GetOSVersion(); // 0x069c02d4
	System.Void .ctor(); // 0x069c0090
}

// Client.Runtime
class WizardGames.Soc.SocClient.Device.Util.DeviceInfoUtil : System.Object
{
	static SocLogger Log; // 0x0
	static System.String get_DeviceModel(); // 0x069e8b2c
	static System.String FormatGraphicsName(System.String name); // 0x069e8b88
	static System.Void .cctor(); // 0x069e8cc4
}

// Client.Runtime
class WizardGames.Soc.SocClient.DebugTools.VTDebugRuntimeTuner : UnityEngine.MonoBehaviour
{
	static System.String GameObjectName = "[VTDebugRuntimeTuner]";
	System.Int32 vtMaxMipLevel; // 0x30
	System.Single terrainLodBias; // 0x34
	System.Single terrainDetailDistance; // 0x38
	System.Single terrainDetailRatio; // 0x3c
	System.Boolean autoApplyWhenChanged; // 0x40
	System.Boolean showWindow; // 0x41
	UnityEngine.Rect windowRect; // 0x44
	UnityEngine.Vector2 scrollPos; // 0x54
	System.Int32 lastVtMaxMipLevel; // 0x5c
	System.Single lastTerrainLodBias; // 0x60
	System.Single lastTerrainDetailDistance; // 0x64
	System.Single lastTerrainDetailRatio; // 0x68
	static WizardGames.Soc.SocClient.DebugTools.VTDebugRuntimeTuner CreateOrGet(); // 0x069e8d98
	System.Void ToggleVisible(); // 0x069e913c
	System.Void Start(); // 0x069e91a8
	System.Void Update(); // 0x069e920c
	System.Void OnGUI(); // 0x069e98d4
	System.Void DrawWindow(System.Int32 id); // 0x069e9a18
	System.Void InitializeFromRuntime(); // 0x069e8f08
	System.Void ApplyAll(); // 0x069ea45c
	static System.Void ApplyVtMaxMipLevel(System.Int32 value); // 0x069e9468
	static System.Void ApplyTerrainLodBias(System.Single value); // 0x069e9500
	static System.Void ApplyTerrainDetailDistance(System.Single value); // 0x069e9618
	static System.Void ApplyTerrainDetailRatio(System.Single value); // 0x069e9730
	static System.Void RefreshVT(); // 0x069e9848
	System.Void .ctor(); // 0x069ea508
}

// Client.Runtime
class WizardGames.Soc.SocClient.GameDebug.Gunkick_Debug : UnityEngine.MonoBehaviour
{
	static UnityEngine.Matrix4x4 GunGlobalMat; // 0x0
	static UnityEngine.Matrix4x4 TransformMat; // 0x40
	UnityEngine.Matrix4x4 _GunGlobalMat; // 0x30
	UnityEngine.Matrix4x4 _TransformMat; // 0x70
	System.Void Update(); // 0x069ea5d4
	System.Void .ctor(); // 0x069ea674
}

// Client.Runtime
class WizardGames.Soc.SocClient.GameDebug.ShortcutsBeltDebug : System.Object
{
	static System.Boolean isShowLog; // 0x0
	static System.Void Info(SocLogger logger, System.String message, System.Boolean force); // 0x069ea6dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.GameDebug.TransformView : UnityEngine.MonoBehaviour
{
	UnityEngine.Vector3 forward; // 0x30
	UnityEngine.Vector3 right; // 0x3c
	UnityEngine.Vector3 up; // 0x48
	UnityEngine.Vector3 GlobalPosition; // 0x54
	UnityEngine.Quaternion LocalRotation; // 0x60
	UnityEngine.Quaternion GlobalRotation; // 0x70
	UnityEngine.Matrix4x4 GlobalMat; // 0x80
	System.Void Update(); // 0x069ea884
	System.Void .ctor(); // 0x069eaa48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Corpse.CorpseRenderData : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	System.Int64 CorpseEntityId; // 0x20
	System.Int32 ColliderIndex; // 0x28
	UnityEngine.Vector3 HitDir; // 0x2c
	UnityEngine.Vector3 HitPoint; // 0x38
	System.Int64 HostEntityId; // 0x48
	System.Int32 DeathAnimValue; // 0x50
	System.String AnimatorPath; // 0x58
	System.Int32 DeadType; // 0x60
	System.Int32 CorpseType; // 0x64
	System.Int64 DeadTime; // 0x68
	static WizardGames.Soc.SocClient.Corpse.CorpseRenderData New(); // 0x069eaab0
	System.Void Dispose(); // 0x069eab28
	System.Void .ctor(); // 0x069eabec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Corpse.CorpseUtils : System.Object
{
	static SocLogger logger; // 0x0
	static System.Void GetDeathParamValue(System.Collections.Generic.List<System.Int32> tmpDeathParamList, System.Int32 deathAnimValue, System.Int32 deathId); // 0x069eac54
	static WizardGames.Soc.Common.Combat.HitPartSimple GetHitPartSimple(System.Int32 deathAnimValue); // 0x069eafe0
	static System.Int32 GetPose(System.Int32 deathAnimValue); // 0x069eb044
	static System.Int32 GetPlayerDeadType(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.Entity.CorpseEntity corpseEntity); // 0x069eb0a8
	static System.Int32 GetMonsterDeadType(WizardGames.Soc.Common.Entity.MonsterEntity monsterEntity, WizardGames.Soc.Common.Entity.CorpseEntity corpseEntity); // 0x069eb224
	static System.Void .cctor(); // 0x069eb2ec
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Corpse.DeathConditionEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Corpse.DeathConditionEnum Root = 0;
	static WizardGames.Soc.SocClient.Corpse.DeathConditionEnum Bone = 1;
	static WizardGames.Soc.SocClient.Corpse.DeathConditionEnum DeathType = 2;
	static WizardGames.Soc.SocClient.Corpse.DeathConditionEnum PoseType = 3;
	static WizardGames.Soc.SocClient.Corpse.DeathConditionEnum Body = 4;
	static WizardGames.Soc.SocClient.Corpse.DeathConditionEnum Direction = 5;
	static WizardGames.Soc.SocClient.Corpse.DeathConditionEnum Move = 6;
	static WizardGames.Soc.SocClient.Corpse.DeathConditionEnum AnimPath = 7;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Corpse.DeathConditionNode : System.Object
{
	WizardGames.Soc.SocClient.Corpse.DeathConditionEnum NodeType; // 0x10
	System.Int32 NodeValue; // 0x14
	System.String AnimPath; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Corpse.DeathConditionNode> ChildNodeList; // 0x20
	System.Void .ctor(WizardGames.Soc.SocClient.Corpse.DeathConditionEnum nodeType, System.Int32 value, System.String path); // 0x069eb3c0
	System.Boolean TryAddChildNode(WizardGames.Soc.Common.Data.Death.DeathAnimationConfig table, System.Int32 currentValue); // 0x069eb4dc
	System.String TryGetDeathAnim(System.Int32 depth, System.Collections.Generic.List<System.Int32> paramList, System.Boolean needRandom); // 0x069eb908
	System.Int32 GetNextValueByDeathCondition(WizardGames.Soc.Common.Data.Death.DeathAnimationConfig table, WizardGames.Soc.SocClient.Corpse.DeathConditionEnum type, WizardGames.Soc.SocClient.Corpse.DeathConditionEnum& nextType); // 0x069eb7ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Corpse.MgrCorpse : WizardGames.Soc.Common.Manager.MgrBase
{
	WizardGames.Soc.SocClient.Corpse.DeathConditionNode rootDeathAnimNode; // 0x18
	System.Collections.Generic.HashSet<System.Int64> HasRenderEventCorpses; // 0x20
	System.Void Init(); // 0x069ebbf0
	System.Void CleanUp(); // 0x069ebf18
	System.String TryGetDeathAnim(System.Int32 depth, System.Collections.Generic.List<System.Int32> paramList, System.Boolean needRandom); // 0x069ebfa8
	System.Void InitDeathAnimData(); // 0x069ebcb0
	System.Void .ctor(); // 0x069ec050
}

// Client.Runtime
class WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition : UnityEngine.ScriptableObject
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition.AnimDefinition> AnimDefinitionList; // 0x18
	System.Void .ctor(); // 0x069ec0b8
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition.PoseType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition.PoseType Stand = 0;
	static WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition.PoseType Crouch = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition.BodyType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition.BodyType UpperBody = 0;
	static WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition.BodyType LowerBody = 1;
	static WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition.BodyType Head = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition.DirectionType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition.DirectionType Front = 0;
	static WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition.DirectionType Back = 1;
	static WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition.DirectionType Left = 2;
	static WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition.DirectionType Right = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition.BaseDefinition : System.Object
{
	System.Collections.Generic.List<UnityEngine.AnimationClip> AnimationClips; // 0x10
	System.Void .ctor(); // 0x069ec120
}

// Client.Runtime
class WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition.DirectionDefinition : System.Object
{
	WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition.DirectionType Direction; // 0x10
	WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition.BaseDefinition StandDefinition; // 0x18
	WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition.BaseDefinition MovingDefinition; // 0x20
	System.Void .ctor(); // 0x069ec188
}

// Client.Runtime
class WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition.BodyDefinition : System.Object
{
	WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition.BodyType BodyType; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition.DirectionDefinition> DirectionDefinitions; // 0x18
	System.Void .ctor(); // 0x069ec1f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition.PoseDefinition : System.Object
{
	WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition.PoseType PoseType; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition.BodyDefinition> BodyDefinitions; // 0x18
	System.Void .ctor(); // 0x069ec258
}

// Client.Runtime
class WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition.AnimDefinition : System.Object
{
	System.Int32 ID; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Corpse.PlayerDeathAnimDefinition.PoseDefinition> PoseDefinitions; // 0x18
	System.Void .ctor(); // 0x069ec6b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Control.ControlAction : System.Object
{
	WizardGames.Soc.Common.Data.ActionName <Name>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Control.IActionExecutor executor; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Control.KeyBase> keyBinding; // 0x20
	WizardGames.Soc.SocClient.Control.UiVirtualKey <uiKey>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Control.InputSystemKey <InputSystemKey>k__BackingField; // 0x30
	WizardGames.Soc.Common.Data.ActionName get_Name(); // 0x069ecb08
	System.Void set_Name(WizardGames.Soc.Common.Data.ActionName value); // 0x069ecb6c
	WizardGames.Soc.SocClient.Control.UiVirtualKey get_uiKey(); // 0x069ecbe4
	System.Void set_uiKey(WizardGames.Soc.SocClient.Control.UiVirtualKey value); // 0x069ecc48
	WizardGames.Soc.SocClient.Control.InputSystemKey get_InputSystemKey(); // 0x069eccc8
	System.Void set_InputSystemKey(WizardGames.Soc.SocClient.Control.InputSystemKey value); // 0x069ecd2c
	System.Void .ctor(WizardGames.Soc.Common.Data.ActionName actionName, WizardGames.Soc.SocClient.Control.InputSystemKey inputSystemKey, WizardGames.Soc.SocClient.Control.UiVirtualKey uiKey); // 0x069ecdac
	static System.Void ClearKeyConflict(); // 0x069ed0a4
	System.Void BindExecutor(WizardGames.Soc.SocClient.Control.IActionExecutor executor); // 0x069ed350
	System.Void UnBindExecutor(WizardGames.Soc.SocClient.Control.IActionExecutor executor); // 0x069ed3ec
	System.Void SetUiKeyPressed(); // 0x069ed48c
	System.Void ResetKeyBindingPressInfo(); // 0x069ed58c
	System.Void ModifyUiVirtualKey(WizardGames.Soc.SocClient.Control.KeyResponse keyResponse); // 0x069ed700
	System.Void Execute(WizardGames.Soc.Common.SimpleCustom.UserCmd userCmd); // 0x069ed9a8
	System.Boolean CheckKeyResponseLogic(); // 0x069edbd4
	System.Void OnActiveChanged(System.Boolean active); // 0x069ee2f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Control.ControlAction.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Control.ControlAction.<>c <>9; // 0x0
	static System.Predicate<WizardGames.Soc.SocClient.Control.KeyBase> <>9__21_0; // 0x8
	static System.Void .cctor(); // 0x069ee44c
	System.Void .ctor(); // 0x069ee4b0
	System.Boolean <ModifyUiVirtualKey>b__21_0(WizardGames.Soc.SocClient.Control.KeyBase keyBase); // 0x069ee518
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Control.KeyResponse : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Control.KeyResponse PressDown = 0;
	static WizardGames.Soc.SocClient.Control.KeyResponse PressUp = 1;
	static WizardGames.Soc.SocClient.Control.KeyResponse Press = 2;
	static WizardGames.Soc.SocClient.Control.KeyResponse LongPress = 3;
	static WizardGames.Soc.SocClient.Control.KeyResponse DoubleClick = 4;
	static WizardGames.Soc.SocClient.Control.KeyResponse ScrollWheelUp = 5;
	static WizardGames.Soc.SocClient.Control.KeyResponse ScrollWheelDown = 6;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Control.Device : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Control.Device Pc = 0;
	static WizardGames.Soc.SocClient.Control.Device Mobile = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Control.MouseKeyName : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Control.MouseKeyName Left = 0;
	static WizardGames.Soc.SocClient.Control.MouseKeyName Right = 1;
	static WizardGames.Soc.SocClient.Control.MouseKeyName Middle = 2;
	static WizardGames.Soc.SocClient.Control.MouseKeyName ScrollWheelUp = 3;
	static WizardGames.Soc.SocClient.Control.MouseKeyName ScrollWheelDown = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Control.CustomInteraction : System.Object, UnityEngine.InputSystem.IInputInteraction<System.Single>, UnityEngine.InputSystem.IInputInteraction
{
	WizardGames.Soc.SocClient.Control.ETriggerMode mode; // 0x10
	System.Single duration; // 0x14
	System.Single interval; // 0x18
	System.Double startTime; // 0x20
	System.Double lastTickTime; // 0x28
	System.Boolean started; // 0x30
	System.Void Process(UnityEngine.InputSystem.InputInteractionContext& context); // 0x069ee5d8
	System.Void Reset(); // 0x069ee9f4
	System.Boolean IsModifierValid(); // 0x069ee87c
	static System.Void RegisterCustomInteraction(); // 0x069eea58
	System.Void .ctor(); // 0x069eeb04
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Control.IActionExecutor : 
{
	
	System.Boolean PreExecute(WizardGames.Soc.Common.Data.ActionName actionName, WizardGames.Soc.Common.SimpleCustom.UserCmd userCmd, System.Boolean isKeyResponse); // 0x054c5da4
	System.Void Execute(WizardGames.Soc.Common.Data.ActionName actionName, WizardGames.Soc.Common.SimpleCustom.UserCmd userCmd, System.Boolean isKeyResponse); // 0x05510620
	System.Void OnActionActiveChanged(WizardGames.Soc.Common.Data.ActionName actionName, System.Boolean active); // 0x0550f700
}

// Client.Runtime
class WizardGames.Soc.SocClient.Control.InputSystemKey : WizardGames.Soc.SocClient.Control.KeyBase
{
	UnityEngine.InputSystem.InputAction <Action>k__BackingField; // 0x10
	System.Boolean detectPressing; // 0x18
	System.Boolean <IsMouseKey>k__BackingField; // 0x19
	UnityEngine.InputSystem.InputAction get_Action(); // 0x069eeb6c
	System.Void set_Action(UnityEngine.InputSystem.InputAction value); // 0x069eebd0
	System.Boolean get_IsMouseKey(); // 0x069eec50
	System.Void set_IsMouseKey(System.Boolean value); // 0x069eecb4
	System.Void .ctor(UnityEngine.InputSystem.InputAction action, System.Boolean isDetectPressing, System.Boolean isMouseKey); // 0x069eed30
	System.Boolean CheckKeyResponse(); // 0x069eeeec
	System.Void ResetKeyPressInfo(); // 0x069ef00c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Control.KeyBase : System.Object
{
	
	System.Boolean CheckKeyResponse(); // 0x054c4760
	System.Void ResetKeyPressInfo(); // 0x055049cc
	System.Void .ctor(); // 0x069eee84
}

// Client.Runtime
class WizardGames.Soc.SocClient.Control.KeyboardKey : WizardGames.Soc.SocClient.Control.KeyBase
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.HashSet<UnityEngine.KeyCode> <conflict>k__BackingField; // 0x8
	System.Collections.Generic.Dictionary<UnityEngine.KeyCode,WizardGames.Soc.SocClient.Control.KeyPressInfo> keyPressInfos; // 0x10
	System.Collections.Generic.Dictionary<UnityEngine.KeyCode,WizardGames.Soc.SocClient.Control.KeyResponse> keyResponses; // 0x18
	static System.Collections.Generic.HashSet<UnityEngine.KeyCode> get_conflict(); // 0x069ef06c
	static System.Void ClearConflict(); // 0x069ed148
	System.Void ResetKeyPressInfo(); // 0x069ef0f4
	System.Boolean CheckKeyResponse(); // 0x069ef38c
	static System.Void .cctor(); // 0x069efbd8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Control.KeyPressInfo : System.Object
{
	System.Boolean <IsDirty>k__BackingField; // 0x10
	System.Boolean isLastFramePressed; // 0x11
	System.Boolean isCurrentFramePressed; // 0x12
	System.Single pressedContinuedTime; // 0x14
	System.Single recentPressDownTime; // 0x18
	System.Int32 clickCount; // 0x1c
	System.Boolean get_IsDirty(); // 0x069efd04
	System.Void set_IsDirty(System.Boolean value); // 0x069efd68
	System.Boolean IsLongPressed(); // 0x069efafc
	System.Boolean IsDoubleClick(); // 0x069efb6c
	System.Boolean IsPressUp(); // 0x069efa80
	System.Boolean IsPress(); // 0x069efde4
	System.Boolean IsPressDown(); // 0x069efa0c
	System.Void Reset(); // 0x069ef280
	System.Void UpdateInfo(System.Boolean isCurrentFramePressed); // 0x069ef8c0
	System.Void .ctor(); // 0x069efe48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Control.LobbyActionControl : System.Object, WizardGames.Soc.SocClient.Control.IActionExecutor
{
	static SocLogger Logger; // 0x0
	System.Int32 GestureIndex; // 0x10
	System.Boolean PreExecute(WizardGames.Soc.Common.Data.ActionName actionName, WizardGames.Soc.Common.SimpleCustom.UserCmd userCmd, System.Boolean isKeyResponse); // 0x069efeb0
	System.Void Execute(WizardGames.Soc.Common.Data.ActionName actionName, WizardGames.Soc.Common.SimpleCustom.UserCmd userCmd, System.Boolean isKeyResponse); // 0x069f0450
	System.Void OnActionActiveChanged(WizardGames.Soc.Common.Data.ActionName actionName, System.Boolean active); // 0x069f04e0
	System.Void .ctor(); // 0x069f055c
	static System.Void .cctor(); // 0x069f05cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Control.MainActionControl : System.Object, WizardGames.Soc.SocClient.Control.IActionExecutor
{
	static SocLogger Logger; // 0x0
	System.Boolean isCurstorPressed; // 0x10
	System.Int32 GestureIndex; // 0x14
	System.Void OnActionActiveChanged(WizardGames.Soc.Common.Data.ActionName actionName, System.Boolean active); // 0x069f06a0
	System.Boolean PreExecute(WizardGames.Soc.Common.Data.ActionName actionName, WizardGames.Soc.Common.SimpleCustom.UserCmd userCmd, System.Boolean isKeyResponse); // 0x069f071c
	System.Void Execute(WizardGames.Soc.Common.Data.ActionName actionName, WizardGames.Soc.Common.SimpleCustom.UserCmd userCmd, System.Boolean isKeyResponse); // 0x05510620
	System.Void .ctor(); // 0x069f1838
	static System.Void .cctor(); // 0x069f18a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Control.MgrControl : WizardGames.Soc.SocClient.Control.MgrControlBase
{
	System.Boolean <IsOpenUIViewCtl>k__BackingField; // 0x50
	System.Boolean <IsCloseUIViewCtlSelf>k__BackingField; // 0x51
	System.Boolean IsLittleEyeEnable; // 0x52
	System.Boolean <ControlEnabled>k__BackingField; // 0x53
	System.Boolean <RotateEnabled>k__BackingField; // 0x54
	System.Boolean <TouchControlEnabled>k__BackingField; // 0x55
	System.Boolean <KeyControlEnabled>k__BackingField; // 0x56
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.ActionName> UnblockableActionNames; // 0x58
	WizardGames.Soc.SocClient.Control.TouchInput _touchInput; // 0x60
	System.Boolean get_IsOpenUIViewCtl(); // 0x069f197c
	System.Void set_IsOpenUIViewCtl(System.Boolean value); // 0x069f19e0
	System.Boolean get_IsCloseUIViewCtlSelf(); // 0x069f1a5c
	System.Void set_IsCloseUIViewCtlSelf(System.Boolean value); // 0x069f1ac0
	System.Boolean get_ControlEnabled(); // 0x069f1b3c
	System.Void set_ControlEnabled(System.Boolean value); // 0x069f1ba0
	System.Boolean get_RotateEnabled(); // 0x069f1c1c
	System.Void set_RotateEnabled(System.Boolean value); // 0x069f1c80
	System.Boolean get_TouchControlEnabled(); // 0x069f1cfc
	System.Void set_TouchControlEnabled(System.Boolean value); // 0x069f1d60
	System.Boolean get_KeyControlEnabled(); // 0x069f1ddc
	System.Void set_KeyControlEnabled(System.Boolean value); // 0x069f1e40
	WizardGames.Soc.SocClient.Control.MoveControl get_MoveControl(); // 0x069f1ebc
	WizardGames.Soc.SocClient.Control.RotationControl get_RotationControl(); // 0x069f1f8c
	WizardGames.Soc.SocClient.Control.TouchInput get_TouchInput(); // 0x069f205c
	System.Void Init(); // 0x069f22c4
	System.Void Destroy(); // 0x069f2b14
	System.Void InitUnblockableActionNames(); // 0x069f2830
	System.Void DoBind(); // 0x069f33d0
	System.Void UnBind(); // 0x069f2c08
	System.Void CollectPcMoveInput(); // 0x069f3b0c
	System.Void CollectInput(); // 0x069f437c
	System.Void TryRunActionList(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x069f44c4
	System.Void LittleEyeProcess(); // 0x069f46ec
	System.Void DisableControl(); // 0x069f58e0
	System.Void EnableControl(WizardGames.Soc.Common.Data.EActionGroup actionGroup); // 0x069f59a0
	System.Void DisableRotate(); // 0x069f637c
	System.Void EnableRotate(); // 0x069f642c
	System.Void ExecuteActionAtName(WizardGames.Soc.Common.Data.ActionName actionName); // 0x069f64e0
	System.Void ChangeControlMap(System.Boolean mouseClickFire2); // 0x069f66cc
	System.Void ChangeKeyMapToDefault(); // 0x069f68c4
	System.Void InterruptAutoRun(); // 0x069f6980
	System.Boolean AutoRunProcess(UnityEngine.Vector2& inputPos); // 0x069f404c
	System.Void .ctor(); // 0x069f69e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Control.MgrControlBase : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Control.ControlAction> executeList; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Control.ControlAction> activedActions; // 0x20
	System.Collections.Generic.HashSet<WizardGames.Soc.Common.Data.ActionName> activedActionsSet; // 0x28
	WizardGames.Soc.Common.Data.EActionGroup <LastActionGroup>k__BackingField; // 0x30
	WizardGames.Soc.Common.Data.EActionGroup <ActivedActionGroup>k__BackingField; // 0x34
	System.Int32 currentRunEnvIndex; // 0x38
	System.Boolean needResetDevice; // 0x3c
	System.Boolean disableAllAction; // 0x3d
	System.Collections.Generic.HashSet<WizardGames.Soc.Common.Data.ActionName> whiteListAction; // 0x40
	System.IDisposable sub; // 0x48
	System.Void set_LastActionGroup(WizardGames.Soc.Common.Data.EActionGroup value); // 0x069f6c74
	WizardGames.Soc.Common.Data.EActionGroup get_ActivedActionGroup(); // 0x069f6cec
	System.Void set_ActivedActionGroup(WizardGames.Soc.Common.Data.EActionGroup value); // 0x069f6d50
	System.Void Init(); // 0x069f25cc
	System.Void Destroy(); // 0x069f303c
	System.Void OnFocusChanged(System.Boolean hasFocus); // 0x069f6dc8
	System.Void ResetDeviceIfNeeded(); // 0x069f6fec
	System.Void DoBind(); // 0x069f3810
	System.Void CollectInput(); // 0x069f70fc
	System.Void SetActionGroup(WizardGames.Soc.Common.Data.EActionGroup actionGroup, System.Boolean force); // 0x069f5ab4
	System.Void SetRunEnvIndex(System.Int32 index, System.Boolean force); // 0x069f27b4
	System.Boolean CanActionExecute(WizardGames.Soc.Common.Data.ActionName actionName); // 0x069f4ae0
	System.Boolean CanPerformAction(WizardGames.Soc.Common.Data.ActionName horizontal, WizardGames.Soc.Common.Data.ActionName vertical); // 0x069f429c
	System.Void DisableAllActionExcept(System.Collections.Generic.List<WizardGames.Soc.Common.Data.ActionName> actions); // 0x069f715c
	System.Void DisableAllAction(); // 0x069f71f8
	System.Void EnableAllAction(); // 0x069f7284
	System.Void AddWiteListAction(System.Collections.Generic.List<WizardGames.Soc.Common.Data.ActionName> actions); // 0x069f730c
	System.Void .ctor(); // 0x069f6afc
	static System.Void .cctor(); // 0x069f74e4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Control.MgrControlBase.AnyButtonPressObserver : System.Object, System.IObserver<UnityEngine.InputSystem.InputControl>
{
	static WizardGames.Soc.SocClient.Control.MgrControlBase.AnyButtonPressObserver Instance; // 0x0
	System.Void OnNext(UnityEngine.InputSystem.InputControl control); // 0x069f75b8
	System.Void OnError(System.Exception error); // 0x069f76ac
	System.Void OnCompleted(); // 0x069f7720
	System.Void .ctor(); // 0x069f7780
	static System.Void .cctor(); // 0x069f77e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Control.MgrControlLobby : WizardGames.Soc.SocClient.Control.MgrControlBase
{
	static SocLogger logger; // 0x0
	System.Void Init(); // 0x069f784c
	System.Threading.Tasks.Task OnExitWorld(); // 0x069f7b60
	System.Void OnMgrInputSystemReady(); // 0x069f7a10
	System.Void DoBind(); // 0x069f7c64
	System.Void CollectInput(); // 0x069f7f88
	System.Void Destroy(); // 0x069f8218
	System.Void .ctor(); // 0x069f85c8
	static System.Void .cctor(); // 0x069f8650
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Control.ETriggerMode : System.Enum
{
	System.Byte value__; // 0x10
	static WizardGames.Soc.SocClient.Control.ETriggerMode Tap = 0;
	static WizardGames.Soc.SocClient.Control.ETriggerMode Press = 1;
	static WizardGames.Soc.SocClient.Control.ETriggerMode Release = 2;
	static WizardGames.Soc.SocClient.Control.ETriggerMode LongPress = 3;
	static WizardGames.Soc.SocClient.Control.ETriggerMode Hold = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Control.MgrInputSystem : WizardGames.Soc.Common.Manager.MgrBase
{
	SocInputSystemControl <InputSystemControl>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Control.Device <CurrentDevice>k__BackingField; // 0x20
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.ActionName,WizardGames.Soc.SocClient.Control.ControlAction> <RegisteredActions>k__BackingField; // 0x28
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.EActionGroup,System.Collections.Generic.List<WizardGames.Soc.Common.Data.ActionName>> <RegisteredActionGroups>k__BackingField; // 0x30
	WizardGames.Soc.SocClient.Control.LobbyActionControl <LobbyActionControl>k__BackingField; // 0x38
	WizardGames.Soc.SocClient.Control.MainActionControl <MainActionControl>k__BackingField; // 0x40
	WizardGames.Soc.SocClient.Control.MoveControl <MoveControl>k__BackingField; // 0x48
	WizardGames.Soc.SocClient.Control.RotationControl <RotationControl>k__BackingField; // 0x50
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.ActionName,System.String> inputActionsEnumNameDic; // 0x58
	SocInputSystemControl get_InputSystemControl(); // 0x069f8724
	System.Void set_InputSystemControl(SocInputSystemControl value); // 0x069f8788
	WizardGames.Soc.SocClient.Control.Device get_CurrentDevice(); // 0x069f8808
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.ActionName,WizardGames.Soc.SocClient.Control.ControlAction> get_RegisteredActions(); // 0x069f886c
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.EActionGroup,System.Collections.Generic.List<WizardGames.Soc.Common.Data.ActionName>> get_RegisteredActionGroups(); // 0x069f88d0
	WizardGames.Soc.SocClient.Control.LobbyActionControl get_LobbyActionControl(); // 0x069f8934
	WizardGames.Soc.SocClient.Control.MainActionControl get_MainActionControl(); // 0x069f8998
	WizardGames.Soc.SocClient.Control.MoveControl get_MoveControl(); // 0x069f89fc
	WizardGames.Soc.SocClient.Control.RotationControl get_RotationControl(); // 0x069f8a60
	System.Void Init(); // 0x069f8ac4
	System.Threading.Tasks.Task OnEnterWorld(); // 0x069f9fa4
	System.Void InitRebindKey(); // 0x069fa13c
	System.Void CreateAction(); // 0x069f8d40
	System.Void CreateActionGroup(); // 0x069f94c8
	System.Void BindActionExecutor(WizardGames.Soc.Common.Data.ActionName actionName, WizardGames.Soc.SocClient.Control.IActionExecutor executor); // 0x069f38e4
	System.Void UnBindActionExecutor(WizardGames.Soc.Common.Data.ActionName actionName, WizardGames.Soc.SocClient.Control.IActionExecutor executor); // 0x069f39f8
	System.Void ModifyUiVirtualKey(WizardGames.Soc.Common.Data.ActionName actionName, WizardGames.Soc.SocClient.Control.KeyResponse keyResponses); // 0x069f67b0
	WizardGames.Soc.SocClient.Control.ControlAction GetActionAtName(WizardGames.Soc.Common.Data.ActionName actionName); // 0x069f65d4
	System.Void CollectInputActions(); // 0x069fa1a0
	System.Void LoadInputActionData(); // 0x069f9ce4
	UnityEngine.InputSystem.InputAction GetInputAction(System.String actionName); // 0x069fa308
	UnityEngine.InputSystem.InputAction GetInputAction(WizardGames.Soc.Common.Data.ActionName actionName); // 0x069f0328
	System.String GetInputActionAssetName(); // 0x069fa200
	static System.Boolean CheckPlatform(WizardGames.Soc.Common.Data.Ui.ActionRegister cfg); // 0x069f3870
	System.Void .ctor(); // 0x069fa564
	static System.Void .cctor(); // 0x069fac58
}

// Client.Runtime
class WizardGames.Soc.SocClient.Control.MgrInputSystem.ActionRegisterComparer : System.Object, System.Collections.Generic.IComparer<WizardGames.Soc.Common.Data.Ui.ActionRegister>
{
	static WizardGames.Soc.SocClient.Control.MgrInputSystem.ActionRegisterComparer Instance; // 0x0
	System.Int32 Compare(WizardGames.Soc.Common.Data.Ui.ActionRegister x, WizardGames.Soc.Common.Data.Ui.ActionRegister y); // 0x069fad2c
	System.Void .ctor(); // 0x069fae1c
	static System.Void .cctor(); // 0x069fae84
}

// Client.Runtime
class WizardGames.Soc.SocClient.Control.MgrRebindKey : WizardGames.Soc.Common.Manager.MgrBase
{
	
	System.Void .ctor(); // 0x069faee8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Control.MouseKey : WizardGames.Soc.SocClient.Control.KeyBase
{
	static System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Control.MouseKeyName> <Conflict>k__BackingField; // 0x0
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Control.MouseKeyName,WizardGames.Soc.SocClient.Control.KeyPressInfo> keyPressInfos; // 0x10
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Control.MouseKeyName,WizardGames.Soc.SocClient.Control.KeyResponse> keyResponses; // 0x18
	static System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Control.MouseKeyName> get_Conflict(); // 0x069faf50
	static System.Void ClearConflict(); // 0x069ed24c
	System.Void ResetKeyPressInfo(); // 0x069fafd8
	System.Boolean CheckKeyResponse(); // 0x069fb164
	System.Boolean IsPressAfterUIHitFilter(WizardGames.Soc.SocClient.Control.MouseKeyName mouseKeyName); // 0x069fb6d8
	static System.Void .cctor(); // 0x069fb81c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Control.MoveControl : System.Object, WizardGames.Soc.SocClient.Control.IActionExecutor
{
	static SocLogger logger; // 0x0
	System.Int32 lastRecordCmdSequence; // 0x10
	System.Boolean lastRecordCmdMoveForward; // 0x14
	System.Boolean lastRecordCmdMoveBackward; // 0x15
	System.Boolean lastRecordCmdMoveLeft; // 0x16
	System.Boolean lastRecordCmdMoveRight; // 0x17
	System.Boolean lastRecordCmdUp; // 0x18
	System.Boolean lastRecordCmdDown; // 0x19
	UnityEngine.Vector2 joystickInput; // 0x1c
	System.Single inputAngle; // 0x24
	System.Single joystickPercent; // 0x28
	WizardGames.Soc.Common.Data.ActionName inputVerticalDirect; // 0x2c
	WizardGames.Soc.Common.Data.ActionName inputHorizontalDirect; // 0x30
	WizardGames.Soc.SocClient.Ui.MoveState moveState; // 0x34
	System.Boolean isOrigin; // 0x38
	System.Boolean <EnableMove>k__BackingField; // 0x39
	System.Single <JoyStickYawOffset>k__BackingField; // 0x3c
	System.Boolean get_EnableMove(); // 0x069fb8b4
	System.Single get_JoyStickYawOffset(); // 0x069fb918
	System.Void set_JoyStickYawOffset(System.Single value); // 0x069fb97c
	System.Boolean PreExecute(WizardGames.Soc.Common.Data.ActionName actionName, WizardGames.Soc.Common.SimpleCustom.UserCmd userCmd, System.Boolean isKeyResponse); // 0x069fb9f4
	System.Void Execute(WizardGames.Soc.Common.Data.ActionName actionName, WizardGames.Soc.Common.SimpleCustom.UserCmd userCmd, System.Boolean isKeyResponse); // 0x069fba88
	System.Void OnActionActiveChanged(WizardGames.Soc.Common.Data.ActionName actionName, System.Boolean active); // 0x069fc3bc
	System.Void UpdateJoystickData(UnityEngine.Vector2 input, System.Single angle, WizardGames.Soc.Common.Data.ActionName direct, WizardGames.Soc.Common.Data.ActionName hDirect, WizardGames.Soc.SocClient.Ui.MoveState state, System.Boolean origin, System.Single percent); // 0x069f40c4
	System.Single CalcMoveYaw(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x069fc1b4
	System.Void .ctor(); // 0x069fa7b0
	static System.Void .cctor(); // 0x069fc438
}

// Client.Runtime
class WizardGames.Soc.SocClient.Control.InputAdditional : System.Object
{
	System.Single Yaw; // 0x10
	System.Single Pitch; // 0x14
	System.Single InputVelocityCoe; // 0x18
	System.Void Reset(); // 0x069fc50c
	static WizardGames.Soc.SocClient.Control.InputAdditional op_Addition(WizardGames.Soc.SocClient.Control.InputAdditional left, WizardGames.Soc.SocClient.Control.InputAdditional right); // 0x069fc574
	System.Void .ctor(); // 0x069fc618
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Control.BlockCoeType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Control.BlockCoeType Speed = 0;
	static WizardGames.Soc.SocClient.Control.BlockCoeType Distance = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Control.MoveDir : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Control.MoveDir Horizontal = 0;
	static WizardGames.Soc.SocClient.Control.MoveDir Vertical = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Control.RotationControl : System.Object, WizardGames.Soc.SocClient.Control.IActionExecutor
{
	static SocLogger logger; // 0x0
	System.Single targetAspectRatioH; // 0x10
	System.Boolean _isPCMode; // 0x14
	SocControlCurve controlCurve; // 0x18
	UnityEngine.GameObject bindGo; // 0x20
	System.Int32 _controlInstanceId; // 0x28
	WizardGames.Soc.Common.Utility.Counter counter; // 0x30
	UnityEngine.Vector2 onceDragDis; // 0x38
	System.Collections.Generic.List<UnityEngine.Vector2> mouseHistory; // 0x40
	System.Collections.Generic.List<UnityEngine.Vector2> mouseHistorySameDir; // 0x48
	System.Single _yaw; // 0x50
	System.Single _pitch; // 0x54
	System.Single temp; // 0x58
	System.Boolean isOpenGyro; // 0x5c
	System.Single disableYaw; // 0x60
	System.Single disablePitch; // 0x64
	System.Single <PitchLimitAngle>k__BackingField; // 0x68
	System.Single TotalYaw; // 0x6c
	System.Single TotalPitch; // 0x70
	System.Text.StringBuilder LogStr; // 0x78
	System.Action<System.Single,System.Single> OnCollectLittleEyeInput; // 0x80
	System.Boolean <IsCloseGyroSelf>k__BackingField; // 0x88
	System.Boolean <IsOpenGyroOnlyAdsOn>k__BackingField; // 0x89
	System.Boolean <GyroVerticalInverse>k__BackingField; // 0x8a
	System.Boolean <GyroHorizontalInverse>k__BackingField; // 0x8b
	System.Boolean <EnableBlockCoe>k__BackingField; // 0x8c
	System.Single <AngleConst>k__BackingField; // 0x90
	System.Single <LittleEyeAngleConst>k__BackingField; // 0x94
	System.Single[] <WeightCoe>k__BackingField; // 0x98
	System.Single Dpi; // 0xa0
	System.Int32 enableBits; // 0xa4
	System.Single LerpRate; // 0xa8
	System.Single FirstMoveRate; // 0xac
	System.Single MinOffset; // 0xb0
	System.Boolean SmoothWithDir; // 0xb4
	System.Single SmoothPopAngle; // 0xb8
	System.Boolean UseSmoothPop; // 0xbc
	System.Single <Sx>k__BackingField; // 0xc0
	System.Single <Ax>k__BackingField; // 0xc4
	System.Single <Km1>k__BackingField; // 0xc8
	System.Single <Gm1>k__BackingField; // 0xcc
	System.Single <Lx>k__BackingField; // 0xd0
	System.Single HorizontalIgnoreOffset; // 0xd4
	UnityEngine.Vector2[] <BlockCoeDistanceX>k__BackingField; // 0xd8
	UnityEngine.Vector2[] <BlockCoeSpeedX>k__BackingField; // 0xe0
	WizardGames.Soc.SocClient.Control.BlockCoeType <MoveBlockCoeTypeX>k__BackingField; // 0xe8
	System.Single <Sy>k__BackingField; // 0xec
	System.Single <Ay>k__BackingField; // 0xf0
	System.Single <Kf1>k__BackingField; // 0xf4
	System.Single <Gf1>k__BackingField; // 0xf8
	System.Single <Ly>k__BackingField; // 0xfc
	System.Single VerticalIgnoreOffset; // 0x100
	UnityEngine.Vector2[] <BlockCoeDistanceY>k__BackingField; // 0x108
	UnityEngine.Vector2[] <BlockCoeSpeedY>k__BackingField; // 0x110
	WizardGames.Soc.SocClient.Control.BlockCoeType <MoveBlockCoeTypeY>k__BackingField; // 0x118
	System.Collections.Generic.Dictionary<System.Int64,System.Single> Km; // 0x120
	System.Collections.Generic.Dictionary<System.Int64,System.Single> Kf; // 0x128
	System.Collections.Generic.Dictionary<System.Int64,System.Single> Gm; // 0x130
	System.Collections.Generic.Dictionary<System.Int64,System.Single> Gf; // 0x138
	System.Single <LittleEyeSx>k__BackingField; // 0x140
	System.Single LittleEyeK; // 0x144
	System.Single <LittleEyeSy>k__BackingField; // 0x148
	System.Single LittleEyeYaw; // 0x14c
	System.Boolean EnableYawLimit; // 0x150
	System.Single _yawLimitMax; // 0x154
	System.Single _yawLimitMin; // 0x158
	System.Boolean EnablePitchLimit; // 0x15c
	System.Single _pitchLimitMax; // 0x160
	System.Single _pitchLimitMin; // 0x164
	System.Single _curFrameAddYaw; // 0x168
	System.Single _lastMountGoForward; // 0x16c
	System.Boolean[] isFirstMountSeat; // 0x170
	WizardGames.Soc.Common.Utility.SpringDamper _vehicleDampingYaw; // 0x178
	WizardGames.Soc.Common.Utility.SpringDamper _vehicleDampingPitch; // 0x180
	System.Single _touchEndTime; // 0x188
	System.Boolean _firstBack2BestView; // 0x18c
	System.Single decline_rate; // 0x190
	UnityEngine.Vector2 InputDelta; // 0x194
	UnityEngine.Vector2 FactoredInputDelta; // 0x19c
	System.Boolean get_IsPCMode(); // 0x069fc680
	System.Single get_Yaw(); // 0x069fc6e4
	System.Void set_Yaw(System.Single value); // 0x069fc770
	System.Single get_Pitch(); // 0x069fc7f0
	System.Void set_Pitch(System.Single value); // 0x069fc878
	System.Single get_PitchLimitAngle(); // 0x069fc8f8
	System.Void set_PitchLimitAngle(System.Single value); // 0x069fc95c
	System.Void add_OnCollectLittleEyeInput(System.Action<System.Single,System.Single> value); // 0x069fc9d4
	System.Void remove_OnCollectLittleEyeInput(System.Action<System.Single,System.Single> value); // 0x069fcac4
	System.Boolean get_IsOpenGyro(); // 0x069fcbb4
	System.Void set_IsOpenGyro(System.Boolean value); // 0x069fcc18
	System.Boolean get_IsCloseGyroSelf(); // 0x069fcf50
	System.Void set_IsCloseGyroSelf(System.Boolean value); // 0x069fcfb4
	System.Void UpdateGyroInterval(); // 0x069fcdb0
	System.Boolean get_IsOpenGyroOnlyAdsOn(); // 0x069fd030
	System.Void set_IsOpenGyroOnlyAdsOn(System.Boolean value); // 0x069fd094
	System.Boolean get_GyroVerticalInverse(); // 0x069fd110
	System.Void set_GyroVerticalInverse(System.Boolean value); // 0x069fd174
	System.Boolean get_GyroHorizontalInverse(); // 0x069fd1f0
	System.Void set_GyroHorizontalInverse(System.Boolean value); // 0x069fd254
	System.Boolean get_EnableBlockCoe(); // 0x069fd2d0
	System.Void set_EnableBlockCoe(System.Boolean value); // 0x069fd334
	System.Single get_AngleConst(); // 0x069fd3b0
	System.Void set_AngleConst(System.Single value); // 0x069fd414
	System.Single get_LittleEyeAngleConst(); // 0x069fd48c
	System.Void set_LittleEyeAngleConst(System.Single value); // 0x069fd4f0
	System.Boolean get_Enable(); // 0x069fd568
	System.Single[] get_WeightCoe(); // 0x069fd5d8
	System.Single get_Sx(); // 0x069fd63c
	System.Void set_Sx(System.Single value); // 0x069fd6a0
	System.Single get_Ax(); // 0x069fd718
	System.Void set_Ax(System.Single value); // 0x069fd77c
	System.Single get_Km1(); // 0x069fd7f4
	System.Void set_Km1(System.Single value); // 0x069fd858
	System.Single get_Gm1(); // 0x069fd8d0
	System.Void set_Gm1(System.Single value); // 0x069fd934
	System.Single get_Lx(); // 0x069fd9ac
	System.Void set_Lx(System.Single value); // 0x069fda10
	System.Void set_BlockCoeDistanceX(UnityEngine.Vector2[] value); // 0x069fda88
	System.Void set_BlockCoeSpeedX(UnityEngine.Vector2[] value); // 0x069fdb08
	WizardGames.Soc.SocClient.Control.BlockCoeType get_MoveBlockCoeTypeX(); // 0x069fdb88
	System.Void set_MoveBlockCoeTypeX(WizardGames.Soc.SocClient.Control.BlockCoeType value); // 0x069fdbec
	System.Single get_Sy(); // 0x069fdc64
	System.Void set_Sy(System.Single value); // 0x069fdcc8
	System.Single get_Ay(); // 0x069fdd40
	System.Void set_Ay(System.Single value); // 0x069fdda4
	System.Single get_Kf1(); // 0x069fde1c
	System.Void set_Kf1(System.Single value); // 0x069fde80
	System.Single get_Gf1(); // 0x069fdef8
	System.Void set_Gf1(System.Single value); // 0x069fdf5c
	System.Single get_Ly(); // 0x069fdfd4
	System.Void set_Ly(System.Single value); // 0x069fe038
	System.Void set_BlockCoeDistanceY(UnityEngine.Vector2[] value); // 0x069fe0b0
	System.Void set_BlockCoeSpeedY(UnityEngine.Vector2[] value); // 0x069fe130
	WizardGames.Soc.SocClient.Control.BlockCoeType get_MoveBlockCoeTypeY(); // 0x069fe1b0
	System.Void set_MoveBlockCoeTypeY(WizardGames.Soc.SocClient.Control.BlockCoeType value); // 0x069fe214
	System.Single get_LittleEyeSx(); // 0x069fe28c
	System.Void set_LittleEyeSx(System.Single value); // 0x069fe2f0
	System.Single get_LittleEyeAx(); // 0x069fe368
	System.Single get_LittleEyeSy(); // 0x069fe400
	System.Void set_LittleEyeSy(System.Single value); // 0x069fe464
	System.Single get_LittleEyeAy(); // 0x069fe4dc
	System.Void AddMouseHistory(UnityEngine.Vector2 pos, System.Boolean isPc, System.Single horizonIgnoreOffset, System.Single verticalIgnoreOffset); // 0x069fe574
	System.Void .ctor(); // 0x069fa858
	System.Void OnDestory(); // 0x069f3198
	System.Void OnDataUpdate(); // 0x069fe93c
	System.Void InitData(); // 0x069fa060
	System.Void SetAngleConst(System.Single angle); // 0x069fea24
	System.Void SetLittleEyeAngleConst(System.Single angle); // 0x069fec14
	UnityEngine.Vector2 SmoothWeight(); // 0x069fee04
	System.Boolean IsTurningHorizontal(); // 0x069ff8a8
	System.Boolean IsTurningRight(); // 0x069ffbb0
	System.Boolean IsTurningLeft(); // 0x069ff9f8
	System.Boolean IsTurningVertical(); // 0x069ff950
	System.Boolean IsTurningUp(); // 0x069ffc8c
	System.Boolean IsTurningDown(); // 0x069ffad4
	System.Void CollectInput(UnityEngine.Vector2 delta, System.Single deltaTime, System.Boolean isPc); // 0x069f4b58
	System.Void CollectInputLittleEye1(UnityEngine.Vector2 smooth); // 0x069f5564
	System.Void CollectInputForPhoto(UnityEngine.Vector2 delta); // 0x06a005c8
	System.Void AddView(System.Single pitch, System.Single yaw); // 0x06a00660
	System.Single GetScopeK(System.Boolean isGyro); // 0x069fff80
	System.Void Update(); // 0x06a008cc
	System.Void SetIsOpenGyro(System.Int32 param); // 0x06a00bfc
	System.Single GetAdsState(System.Boolean isGyro); // 0x06a006f0
	System.Single CalcK(WizardGames.Soc.Common.Entity.PlayerActionStateEnum actionStateEnum, System.Boolean isGyro); // 0x06a01028
	System.Single CalcTelescopeK(System.Boolean isGyro); // 0x06a00d58
	System.Single CalcFovRatio(WizardGames.Soc.SocClient.Weapon.AccessoryGo scope, System.Int64 weaponTableId); // 0x06a012a8
	System.Void GetBlockCoe(WizardGames.Soc.SocClient.Control.BlockCoeType blockCoeType, WizardGames.Soc.SocClient.Control.MoveDir moverDir, System.Single& blockCoe, System.Single deltaX, System.Single deltaTime); // 0x069ffd68
	System.Void NormalizeEuler(); // 0x06a003ec
	System.Boolean PreExecute(WizardGames.Soc.Common.Data.ActionName actionName, WizardGames.Soc.Common.SimpleCustom.UserCmd userCmd, System.Boolean isKeyResponse); // 0x06a01804
	System.Void Execute(WizardGames.Soc.Common.Data.ActionName actionName, WizardGames.Soc.Common.SimpleCustom.UserCmd userCmd, System.Boolean isKeyResponse); // 0x06a01898
	System.Void OnActionActiveChanged(WizardGames.Soc.Common.Data.ActionName actionName, System.Boolean active); // 0x06a01b94
	System.Void InitIsFirstMountSeat(); // 0x06a01c10
	System.Void CheckMount(WizardGames.Soc.Common.SimpleCustom.UserCmd userCmd); // 0x06a01cb0
	System.Int32 GetSeatIndex(WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo); // 0x06a01f18
	System.Int32 GetModularCarIndex(WizardGames.Soc.Common.Unity.Go.BaseVehicleModuleGo baseVehicleModuleGo, System.Int32 index); // 0x06a02ff8
	System.Boolean IsReleased(); // 0x06a032cc
	System.Void LimitDriverPitchYaw(WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo, System.Boolean isTp); // 0x06a02068
	System.Void LimitPassengerPitchYaw(WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo, System.Boolean isTp); // 0x06a02a40
	System.Void ResetDamp(WizardGames.Soc.Common.Unity.VehicleCameraType cameraType, System.Single dt, System.Single maxTouchTime); // 0x06a033e4
	System.Single Damp(System.Single now, System.Single target, System.Single dt, System.Boolean isYaw, WizardGames.Soc.Common.Utility.SpringDamper damper, System.Single yawInterpSpeed, System.Single pitchInterpSpeed); // 0x06a035a8
	System.Boolean IsAddMountYaw(WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo, System.Int32 seatIndex, System.Boolean isTp); // 0x06a034e8
	System.Void RotationUpdate(WizardGames.Soc.Common.SimpleCustom.UserCmd userCmd); // 0x06a01930
	System.Void AddAdditional(WizardGames.Soc.SocClient.Control.InputAdditional add, System.Int32 tag); // 0x06a037e8
	System.Void EndInput(); // 0x06a0396c
	System.Single LimitPitch(System.Single pitch); // 0x06a01588
	System.Void ResetInput(); // 0x06a03a04
	System.Void RestDisableInput(); // 0x06a03a78
	UnityEngine.Vector2 GetInputDeltaWithSmoothDamp(UnityEngine.Vector2 targetPos, UnityEngine.Vector2 lastPos, UnityEngine.Vector2& lerpPos, System.Single dt, System.Single lerpRate, System.Single firstMoveRate, System.Boolean isFirst); // 0x06a03adc
	System.Boolean EnableLimitYawScene(System.Single min, System.Single max); // 0x06a03cd0
	System.Boolean EnableLimitYaw(System.Single yaw); // 0x06a03da0
	System.Void DisableLimitYaw(); // 0x06a03e70
	System.Void AddYaw(System.Single delta); // 0x06a00234
	System.Boolean EnableLimitPitchScene(System.Single min, System.Single max); // 0x06a03ed4
	System.Boolean EnableLimitPitch(System.Single value); // 0x06a03fa4
	System.Void DisableLimitPitch(); // 0x06a04038
	System.Void AddPitch(System.Single delta); // 0x06a00324
	System.Boolean NeedLimitPitch(); // 0x06a014d8
	System.Void SetEnable(WizardGames.Soc.SocClient.Control.RotationControl.EnableSource source, System.Boolean enable, System.Boolean enableBlock); // 0x06a0409c
	System.Void CorrectPitchYaw(WizardGames.Soc.Common.SimpleCustom.UserCmd userCmd, System.Single dt); // 0x06a0415c
	UnityEngine.Vector3 get_Forward(); // 0x06a045c8
	static System.Void .cctor(); // 0x06a046d8
	System.Void <InitData>b__202_0(System.UInt64 arg1, Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.AssetPool.AssetGroupData> result); // 0x06a047ac
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Control.RotationControl.EnableSource : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Control.RotationControl.EnableSource MeleeAttackAim = 0;
	static WizardGames.Soc.SocClient.Control.RotationControl.EnableSource SwipeCardAim = 1;
	static WizardGames.Soc.SocClient.Control.RotationControl.EnableSource PoseDying = 2;
	static WizardGames.Soc.SocClient.Control.RotationControl.EnableSource UnActiveEnter = 3;
	static WizardGames.Soc.SocClient.Control.RotationControl.EnableSource Timeline = 4;
	static WizardGames.Soc.SocClient.Control.RotationControl.EnableSource CameraPreview = 5;
	static WizardGames.Soc.SocClient.Control.RotationControl.EnableSource Count = 6;
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Control.RotationControl.<InitData>d__202 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Control.RotationControl <>4__this; // 0x38
	System.Void MoveNext(); // 0x06a048a4
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x06a06668
}

// Client.Runtime
class WizardGames.Soc.SocClient.Control.TouchData : System.Object
{
	UnityEngine.Vector2 Pos; // 0x10
	System.Int32 TouchId; // 0x18
	System.Boolean IsBegin; // 0x1c
	UnityEngine.Vector2 DeltaPos; // 0x20
	System.Single DeltaTime; // 0x28
	WizardGames.Soc.SocClient.Ui.UiMoveView _moveView; // 0x30
	System.Boolean _isStartInForbidArea; // 0x38
	System.Boolean get_IsStartInForbidArea(); // 0x06a066e8
	System.Void set_IsStartInForbidArea(System.Boolean value); // 0x06a06780
	System.Void .ctor(); // 0x06a067fc
	System.Void Begin(WizardGames.Soc.SocClient.Ui.UiMoveView moveView); // 0x06a068c8
	System.Void Move(); // 0x06a069bc
	System.Void End(); // 0x06a06a1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Control.TouchInput : System.Object
{
	static SocLogger Log; // 0x0
	WizardGames.Soc.SocClient.Control.TouchData[] _touches; // 0x10
	UnityEngine.Touch[] _uTouchCache; // 0x18
	System.Int32 _touchCount; // 0x20
	UnityEngine.Vector2 _touchPosition; // 0x24
	System.Boolean IsUpdate; // 0x2c
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> _isFirstMoveDict; // 0x30
	System.Int32 _nowTouchId; // 0x38
	System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Vector2> touchHistory; // 0x40
	System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Vector2> targetPos; // 0x48
	System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Vector2> deltaList; // 0x50
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> _touchId2StartForbidArea; // 0x58
	System.Collections.Generic.HashSet<System.Int32> _touchBeginIds; // 0x60
	System.Int32[] _touchIds; // 0x68
	System.Single TargetDpi; // 0x70
	System.Single Tolerance; // 0x74
	System.Single _lasTimetouchMove; // 0x78
	System.Single get_UiMoveViewHeight(); // 0x06a06a80
	WizardGames.Soc.SocClient.Ui.UiHud get_HudWindow(); // 0x06a06b20
	System.Void Init(); // 0x069f2908
	System.Void Update(System.Single dt); // 0x06a06c28
	System.Void UpdateTouchID(); // 0x06a06d5c
	System.Void UpdateTouchPosition(); // 0x06a06fb4
	System.Void PcUpdate(System.Single dt); // 0x06a07178
	System.Void MobileUpdate(System.Single dt); // 0x06a0746c
	System.Void OnTouchBegin(UnityEngine.Vector2 pos, System.Int32 touchId, System.Boolean isStartInForbidArea); // 0x06a08414
	System.Void OnTouchMove(WizardGames.Soc.SocClient.Control.TouchData touch, System.Single dt); // 0x06a07b74
	System.Void OnTouchEnd(WizardGames.Soc.SocClient.Control.TouchData touch); // 0x06a08720
	UnityEngine.Vector2 GetActualScreenPos(UnityEngine.Vector2 pos); // 0x06a089b4
	System.Boolean IsNowTouchId(System.Int32 touchId, System.Boolean isStartInForbidArea); // 0x06a08a50
	System.Int32 CalcNowTouchId(); // 0x06a08b08
	System.Void ClearTouchHistory(); // 0x06a08e9c
	System.Void Begin(System.Int32 touchId, System.Boolean useForbidArea); // 0x06a08f20
	System.Void End(); // 0x06a08cc4
	System.Void TouchDataSync(UnityEngine.Touch uTouch, System.Boolean isFirst); // 0x06a09260
	System.Void .ctor(); // 0x069f20fc
	static System.Void .cctor(); // 0x06a096f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Control.UiVirtualKey : WizardGames.Soc.SocClient.Control.KeyBase
{
	WizardGames.Soc.SocClient.Control.KeyPressInfo keyPressInfo; // 0x10
	WizardGames.Soc.SocClient.Control.KeyResponse keyResponse; // 0x18
	System.Boolean pressed; // 0x1c
	System.Void Press(); // 0x06a0a3b0
	System.Void ResetKeyPressInfo(); // 0x06a0a420
	System.Boolean CheckKeyResponse(); // 0x06a0a494
	System.Void .ctor(WizardGames.Soc.SocClient.Control.KeyResponse keyResponse); // 0x06a0a698
	System.Void ModifyKey(WizardGames.Soc.SocClient.Control.KeyResponse keyResponse); // 0x06a0a758
}

// Client.Runtime
struct WizardGames.Soc.SocClient.ConstructionHarmonyPhoto.ScreenShootInfo_CHP : System.ValueType
{
	UnityEngine.Vector3 pos; // 0x10
	System.Single dist; // 0x1c
	System.Single hight; // 0x20
	System.Single yAngle; // 0x24
	System.Single xAngle; // 0x28
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.ConstructionHarmonyPhoto.ConstructionHarmonyPhotoCamera : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.SocClient.ConstructionHarmonyPhoto.ConstructionHarmonyPhotoCamera Instance; // 0x8
	static System.Int32 PRE_SCREEN_SHOOT_WAIT_COUNT = 2;
	static System.Int32 AFT_SCREEN_SHOOT_WAIT_COUNT = 1;
	UnityEngine.Transform CameraNode; // 0x30
	System.String dayStr; // 0x38
	System.String timeStr; // 0x40
	System.Int32 waitCount; // 0x48
	System.Boolean havePlaceCamera; // 0x4c
	System.Int32 photoIdx; // 0x50
	System.Collections.Generic.Queue<WizardGames.Soc.SocClient.ConstructionHarmonyPhoto.ScreenShootInfo_CHP> waitScreenShootQueue; // 0x58
	System.Boolean waitForFirstDrawData; // 0x60
	static System.Int32 get_separate(); // 0x06a0a7e8
	static System.Single get_distanceMul(); // 0x06a0a8ec
	System.Void .ctor(); // 0x06a0a9dc
	static System.Void .cctor(); // 0x06a0aa90
}

// Client.Runtime
class WizardGames.Soc.SocClient.ConstructionHarmonyPhoto.PhotoClientConfig : System.Object
{
	static System.Text.StringBuilder contentBeforeLogInit; // 0x0
	static SocLogger logger; // 0x8
	System.Int32 PhotoSeparate; // 0x10
	System.Single PhotoDistanceMul; // 0x14
	static WizardGames.Soc.SocClient.ConstructionHarmonyPhoto.PhotoClientConfig <Instance>k__BackingField; // 0x10
	static WizardGames.Soc.SocClient.ConstructionHarmonyPhoto.PhotoClientConfig get_Instance(); // 0x06a0ab78
	static System.Void .cctor(); // 0x06a0ac00
}

// Client.Runtime
class WizardGames.Soc.SocClient.ConstructionHarmonyPhoto.SocConstructionHarmonyPhoto : WizardGames.Soc.Common.Unity.Main.UnityMainLoop
{
	static WizardGames.Soc.SocClient.ConstructionHarmonyPhoto.SocConstructionHarmonyPhoto Instance; // 0x0
	WizardGames.Soc.Common.Unity.Main.LoopType get__loopType(); // 0x06a0ad1c
	System.Void Awake(); // 0x06a0ad80
	System.Void .ctor(); // 0x06a0ae40
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.BuildingEntityInfo : WizardGames.Soc.SocClient.Manager.GpuInstanceInfo
{
	System.Int64 skinId; // 0x68
	System.Int32 grade; // 0x70
	System.Int32 state; // 0x74
	System.Int64 AdditionBlockInfo; // 0x78
	UnityEngine.Color emissionColor; // 0x80
	System.Boolean haveOutsidePart; // 0x90
	System.Boolean haveEntityPart; // 0x91
	System.Boolean haveRenderComp; // 0x92
	System.Boolean haveColliderCompSkinGo; // 0x93
	System.Collections.Generic.List<WizardGames.Soc.Common.Combat.ColliderConfigSet> splicingColliderConfigSets; // 0x98
	System.Collections.Generic.List<WizardGames.Soc.Common.Component.ConstructionRenderData> renderDatas; // 0xa0
	static System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.ConstructionConditionalModel> tmpConditionModules; // 0x0
	static SocLogger logger; // 0x8
	System.Boolean needUpdateChange; // 0xa8
	System.Boolean needReload; // 0xa9
	System.Boolean needSubmitChange; // 0xaa
	System.Int64 TerritoryId; // 0xb0
	System.Void SetSkinId(System.Int64 skinId); // 0x06a0aecc
	System.Void SetPos(UnityEngine.Vector3 pos); // 0x06a0b038
	System.Void SetRotation(UnityEngine.Quaternion rotation); // 0x06a0b15c
	System.Void SetGrade(System.Int32 grade); // 0x06a0b274
	System.Void SetState(System.Int32 state); // 0x06a0b304
	System.Void SetAdditionBlockInfo(System.Int64 additionBlockInfo); // 0x06a0b39c
	System.Void SetEmissionColor(UnityEngine.Color emissionColor); // 0x06a0b42c
	System.Void SetTemplateId(System.Int64 templateId); // 0x06a0b51c
	System.Void RefreshShow(); // 0x06a0b5b4
	System.Void Clear(); // 0x06a0bb10
	System.Void EnableOutline(UnityEngine.Color color, System.Single dilateShift, System.Single blurShift, System.Int32 lodLevel); // 0x06a0bd10
	System.Void DisableOutline(); // 0x06a0bebc
	System.Void RefreshRender(); // 0x06a0ba00
	System.Void QueueRefreshRender(); // 0x06a0c130
	System.Void AddRenderObject(); // 0x06a0c52c
	System.Void RemoveRenderObject(); // 0x06a0d030
	System.Void UpdateGpuRenderInfo(); // 0x06a0c31c
	System.Void SubmitSkinGoGpuRenderInfo(); // 0x06a0c218
	System.Void ClearRenderDatas(); // 0x06a0bc18
	System.Void AcquireTemplateGoConfig(); // 0x06a0b690
	System.Void ReleaseTemplateGoConfig(); // 0x06a0af70
	System.Void RefreshCollider(); // 0x06a0b794
	static WizardGames.Soc.SocClient.Manager.BuildingEntityInfo Generate(); // 0x06a0d40c
	System.Void ReleaseToPool(); // 0x06a0d49c
	System.Void .ctor(); // 0x06a0d6a8
	static System.Void .cctor(); // 0x06a0d7d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.EnterBuildModeTask : System.Object
{
	WizardGames.Soc.Common.Data.EBuildThirdModeType TargetThirdModeType; // 0x10
	System.Action onBeforeEnterAction; // 0x18
	System.Action onAfterEnterAction; // 0x20
	System.Boolean get_HasAppointMode(); // 0x06a0d910
	System.Void Set(WizardGames.Soc.Common.Data.EBuildThirdModeType targetThirdModeType, System.Action onBeforeEnterCallback, System.Action onAfterEnterCallback); // 0x06a0d97c
	System.Void Execute(System.Boolean isBefore); // 0x06a0da2c
	System.Void Clear(); // 0x06a0dad0
	System.Void .ctor(); // 0x06a0db50
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.ERaiseBlueprintState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.ERaiseBlueprintState None = 0;
	static WizardGames.Soc.SocClient.Manager.ERaiseBlueprintState WaitToRaise = 1;
	static WizardGames.Soc.SocClient.Manager.ERaiseBlueprintState Raising = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrConstruction : WizardGames.Soc.Common.Unity.Construction.MgrConstructionUnity
{
	static System.Single ShorPressTime; // 0x0
	static System.Single RaiseStep; // 0x4
	static System.Single RaiseGap; // 0x8
	System.Int32 currentRaiseDir; // 0x20
	WizardGames.Soc.Stl.SocDict<System.Int64,WizardGames.Soc.SocClient.Manager.BuildingEntityInfo> buildingEntityMaps; // 0x28
	UnityEngine.Vector3 lastPlayerPos; // 0x30
	System.Int32 lastGetPlayerPosFrameCount; // 0x3c
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> outsideUpdateEntity; // 0x40
	System.Collections.Generic.HashSet<System.Int64> outsideUpdateEntityThisFrameData; // 0x48
	System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<WizardGames.Soc.Common.Component.ConstructionRenderData>> loadingRenderDatas; // 0x50
	System.Collections.Generic.HashSet<WizardGames.Soc.Common.CustomType.IBuildingPartBriefEx> buildingPartBriefExSet; // 0x58
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.CustomType.BuildingPartBrief> briefShortcutDic; // 0x60
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Construction.ConstructionGapModel> gapLeftDictionary; // 0x68
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Construction.ConstructionGapModel> gapRightDictionary; // 0x70
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Manager.EConstructionMatType,WizardGames.AssetPool.AssetPoolHandle> _materials; // 0x78
	System.Boolean LockMatIsInit; // 0x80
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Construction.CoreColliderData> _colliderDataDict; // 0x88
	static SocLogger logger; // 0x10
	static UnityEngine.Vector3 ConstructionScale; // 0x18
	static System.Boolean RecoverPartFunctionEnable; // 0x24
	static System.Boolean WallSnapFix; // 0x25
	System.Boolean ComboConstructionSelect; // 0x90
	System.Boolean IsShowUiloadingGmSwitch; // 0x91
	static System.Single NumberOfScale; // 0x28
	static System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.Dictionary<System.String,System.Int64>> ConstructionPartNumDictDatas; // 0x30
	System.String exportNumDictDataPath; // 0x98
	System.Int32 <MaxShatterCount>k__BackingField; // 0xa0
	System.Boolean isEditing; // 0xa4
	System.Boolean isPlacing; // 0xa5
	System.Boolean isExitAfterPlacing; // 0xa6
	UnityEngine.Ray viewRay; // 0xa8
	WizardGames.Soc.Common.SimpleCustom.SimpleVector3 viewRayPos; // 0xc0
	UnityEngine.Vector3 importPartFixPos; // 0xc8
	UnityEngine.Vector3 playerReconnectPos; // 0xd4
	System.Action OnRecoverConstructionsAroudPos; // 0xe0
	System.Boolean isRecoverPreCreateConstruction; // 0xe8
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> waitRecoverPreCreateConstructionDict; // 0xf0
	System.Int64 startRecoverTime; // 0xf8
	System.Int32 maxWaitRecoverTime; // 0x100
	WizardGames.Soc.SocClient.Ui.UiLoading uiRecoverConstructionCover; // 0x108
	WizardGames.Soc.SocClient.Manager.CheckTerritoryCabinetHandle checkTerritoryCabinetHandle; // 0x110
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Manager.LockEffectQueueData> lockEffectBuffer; // 0x118
	static System.Int32 CreatePartNumPerFrame; // 0x38
	System.Int32 curTurnRecoverMaxPartNum; // 0x120
	System.Boolean curTurnStreamingCompeleted; // 0x124
	WizardGames.Soc.SocClient.Construction.BuildMode.WaitBuildData waitBuildBufferPart; // 0x128
	System.Action HoldingConstructionShowCallBack; // 0x130
	System.Boolean canShowHadLockTip; // 0x138
	System.Collections.Generic.HashSet<System.Int64> StorageDebrisSet; // 0x140
	System.Boolean constructionBanned; // 0x148
	System.Action IsBannedConstruction; // 0x150
	System.Action NotBannedConstruction; // 0x158
	System.Boolean <HasClickDeleteBtn>k__BackingField; // 0x160
	System.Collections.Generic.HashSet<System.Int64> wireUpdateSet; // 0x168
	System.Boolean <IsChangeWireColor>k__BackingField; // 0x170
	UnityEngine.GameObject doorGuideGameObject; // 0x178
	UnityEngine.GameObject toolCupboardGuideGameObject; // 0x180
	System.UInt64 doorGuideLoadAsyncId; // 0x188
	System.UInt64 toolCupboardGuideLoadAsyncId; // 0x190
	static WizardGames.Soc.SocClient.Manager.BuildGuideItemData WallUpgradeGuideData; // 0x40
	static WizardGames.Soc.SocClient.Manager.BuildGuideItemData BuildWallDoorwayDoorData; // 0x68
	System.Collections.Generic.Dictionary<System.Int64,System.Single> itemWeight; // 0x198
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode>> ItemIdToNodeDic; // 0x1a0
	System.Boolean IsFromBackpackUseDeploy; // 0x1a8
	System.Int64 TargetTempId; // 0x1b0
	System.Int64 TargetNodeId; // 0x1b8
	WizardGames.Soc.Common.Data.EBuildThirdModeType targetModeType; // 0x1c0
	System.Collections.Generic.HashSet<System.Int64> waitToRefreshMeshEntityIds; // 0x1c8
	static SocLogger Logger; // 0x90
	System.Boolean IsEnableSecondModeRecord; // 0x1d0
	System.Boolean <AutoConnection>k__BackingField; // 0x1d1
	System.Boolean cpWithToolCupboard; // 0x1d2
	System.Boolean EnableHitExitBuild; // 0x1d3
	WizardGames.Soc.Common.Unity.Event.MsgHandler msgHandler; // 0x1d8
	WizardGames.Soc.SocClient.Manager.BuildListOperation BuildListOperation; // 0x1e0
	WizardGames.Soc.SocClient.Manager.BuildPieOperation BuildPieOperation; // 0x1e8
	WizardGames.Soc.SocClient.Manager.BuildOperationBase <CurBuildOperation>k__BackingField; // 0x1f0
	System.Int64 customBPSubscribeId; // 0x1f8
	System.Collections.Generic.List<System.Int32> damageExitBuildEntityTypeList; // 0x200
	System.Collections.Generic.List<System.Int32> buildHoldItemList; // 0x208
	WizardGames.Soc.SocClient.Manager.EnterBuildModeTask enterBuildModeTask; // 0x210
	WizardGames.AssetPool.AssetPoolHandle _moveMat; // 0x218
	System.Int64 _moveRecoverId; // 0x220
	System.Collections.Generic.List<UnityEngine.Collider> _moveRecoverTriggers; // 0x228
	System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Int32> _moveRecoverConstructionColliders; // 0x230
	System.Collections.Generic.Dictionary<UnityEngine.Renderer,UnityEngine.Material[]> _moveRecoverMats; // 0x238
	System.Int64 <waitingMoveFinishPartId>k__BackingField; // 0x240
	UnityEngine.Collider[] checkManagedParts; // 0x248
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PartEntity> managedPartsBeforeMove; // 0x250
	System.Collections.Generic.Dictionary<System.Int64,System.Single> itemAmountsBeforeMove; // 0x258
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PartEntity> oldManagedPartsAfterMove; // 0x260
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PartEntity> newManagedPartsAfterMove; // 0x268
	System.Collections.Generic.Queue<WizardGames.Soc.Common.Electric.CachedConnectedInfo> cachedConnectionLst; // 0x270
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Manager.OuterDeployColliderGoData> outerDeployColliderDatas; // 0x278
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Manager.HotKeyCenterGuideData> hotKeyCenterGuideDic; // 0x280
	System.Diagnostics.Stopwatch Timer; // 0x288
	System.Single MaxTime_Ms; // 0x290
	System.Single CurTimeLeft; // 0x294
	System.Int32 loadMeshCount; // 0x298
	System.Int32 loadColliderCount; // 0x29c
	System.Int32 maxLoadCount; // 0x2a0
	System.Int32 maxLoadSkinGoCount; // 0x2a4
	System.Int32 maxLoadColliderGoCount; // 0x2a8
	System.Int32 renderOuterCount; // 0x2ac
	System.Int32 renderEntityCount; // 0x2b0
	System.Int32 maxRenderQueueCount; // 0x2b4
	System.Int32 maxRenderEntityCount; // 0x2b8
	System.Int32 loadSkinGoCount; // 0x2bc
	UnityEngine.Vector3 oldPlayerPos; // 0x2c0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Manager.WaitRefreshTerritoryInfo> waitRefreshTerrMap; // 0x2d0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.WaitRefreshTerritoryInfo> terrList; // 0x2d8
	WizardGames.Soc.Common.Entity.PartEntity curTargetEntity; // 0x2e0
	WizardGames.Soc.Common.Entity.PartEntity tempTargetEntity; // 0x2e8
	System.Action<WizardGames.Soc.Common.Entity.PartEntity> onTargetChangeAction; // 0x2f0
	System.Collections.Generic.HashSet<System.Action<WizardGames.Soc.Common.Entity.PartEntity>> subscribers; // 0x2f8
	WizardGames.Soc.SocClient.Manager.EditTargetPartData EditTargetPart; // 0x300
	System.Boolean isUpgradeOrRemould; // 0x308
	System.Single timer; // 0x30c
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.PartEntity> CollapsePartGoes; // 0x310
	System.Collections.Generic.HashSet<System.String> activeBuildUiPackageKeys; // 0x318
	System.Boolean hadLoadBuildPackage; // 0x320
	System.Int64 releaseBuildPackageTimerId; // 0x328
	System.String BuildIconPackageName; // 0x330
	System.Int64 curVirtualPartParentId; // 0x338
	System.Collections.Generic.List<System.Int64> virtualPartTypes; // 0x340
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Construction.VirtualPartObj> virtualPartGos; // 0x348
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> virtualPartRecoverConsume; // 0x350
	System.Boolean isConfirmDoubleCheck; // 0x358
	System.Int64 curAssistPartId; // 0x360
	System.Boolean isAssistInteractiveTarget; // 0x368
	System.Collections.Generic.List<System.Int64> defendToolBoxIdList; // 0x370
	System.Boolean BlueprintInCD(System.Int64 curHoldingBlueprintType); // 0x06a0dbb8
	UnityEngine.Vector3 GetPlayerPos(); // 0x06a0dd38
	System.Void AddOrUpdateBuildingEntityInfo(WizardGames.Soc.Common.CustomType.BuildingPartBrief buildingPart, System.Int64 territoryId); // 0x06a0de98
	System.Void RemoveBuildingEntity(System.Int64 entityId); // 0x06a0e428
	System.Boolean IsOutsidePart(System.Int64 entityId); // 0x06a0e4c4
	System.Boolean HaveBuildingInfo(System.Int64 entityId); // 0x06a0e584
	WizardGames.Soc.SocClient.Manager.BuildingEntityInfo GetBuildingEntityInfo(System.Int64 entityId, System.Boolean addIfNotPresent); // 0x06a0e300
	System.Void RemoveBuildingEntityInfo(WizardGames.Soc.SocClient.Manager.BuildingEntityInfo buildingEntityInfo); // 0x06a0bfe4
	System.Void NeedUpdateOutsidePart(System.Int64 entityId, System.Int64 territoryId); // 0x06a0e630
	System.Void CleanupOutsideUpdate(); // 0x06a0e774
	System.Boolean TryGetOutsideDataComp(System.Int64 id, WizardGames.Soc.Common.Component.OutsideDataSetComponent& outsideComp); // 0x06a0e7f8
	System.Void OutsidePartDealTick(); // 0x06a0e96c
	System.Void LoadMeshRenderConfigAsync(WizardGames.Soc.Common.Component.ConstructionRenderData renderData); // 0x06a0ce94
	System.Void OnMeshRenderConfigLoadedComplete(System.String path, WizardGames.Soc.Common.Unity.Construction.MeshRenderConfig meshRenderConfig); // 0x06a0ef38
	System.Void BuildingPartBriefExWaitUpdate(WizardGames.Soc.Common.CustomType.IBuildingPartBriefEx buildingPartBriefEx); // 0x06a0f158
	System.Void BuildingPartBriefExTick(); // 0x06a0f1f4
	System.Void BuildingPartBriefExCleanup(); // 0x06a0f658
	System.Boolean TryGetBuildingPartBrief(System.Int64 entityId, WizardGames.Soc.Common.CustomType.BuildingPartBrief& brief); // 0x06a0f9fc
	System.Void RegisterInfoShortcut(WizardGames.Soc.Common.CustomType.BuildingPartBrief info); // 0x06a0faa4
	System.Void UnRegisterInfoShortcut(WizardGames.Soc.Common.CustomType.BuildingPartBrief info); // 0x06a0fdac
	System.Void GapCleanup(); // 0x06a0f708
	System.Void GapStateRefresh(WizardGames.Soc.Common.CustomType.BuildingPartBriefWithExtraData infoExtra, WizardGames.Soc.Common.CustomType.BuildingPartBriefExGap exGap); // 0x06a100a0
	System.Void GapStateRefresh(WizardGames.Soc.Common.Entity.PartEntity entity, WizardGames.Soc.Common.Component.ConstructionGapComponent gapComponent); // 0x06a1068c
	System.Void UpdateGPUInstance(WizardGames.Soc.Common.Entity.PartEntity entity); // 0x06a10ab0
	System.Void GrantConstructionGapsToOutside(System.Int64 entityId); // 0x06a10bf8
	System.ValueTuple<WizardGames.Soc.Common.Unity.Construction.ConstructionGapModel,WizardGames.Soc.Common.Unity.Construction.ConstructionGapModel> GetGapModels(System.Int64 entityId); // 0x06a10d3c
	System.Void PrepareMats(); // 0x06a10e30
	System.Void PrepareMatById(System.Int32 id); // 0x06a10f00
	System.Void ReleaseMats(); // 0x06a111bc
	WizardGames.AssetPool.AssetPoolHandle GetPartMatByType(WizardGames.Soc.SocClient.Manager.EConstructionMatType type); // 0x06a11244
	System.Void SwitchColliderMode(System.Int64 entityId, WizardGames.Soc.Common.Unity.Construction.ECoreColliderState targetState); // 0x06a113e4
	System.Void RemoveColliderGo(System.Int64 entityId); // 0x06a114b8
	System.Void RequestClearColliderFromEntity(System.Int64 templateId, System.Int64 entityId); // 0x06a116f4
	System.Void RefreshCoreColliderPos(WizardGames.Soc.SocClient.Manager.BuildingEntityInfo buildingEntityInfo); // 0x06a11a48
	System.Void RefreshCoreColliderSet(WizardGames.Soc.SocClient.Manager.BuildingEntityInfo buildingEntityInfo); // 0x06a11d2c
	WizardGames.Soc.Common.Unity.Construction.CoreColliderData GetCoreColliderData(WizardGames.Soc.SocClient.Manager.BuildingEntityInfo buildingEntityInfo); // 0x06a11c98
	WizardGames.Soc.Common.Unity.Construction.CoreColliderData GetCoreColliderNode(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06a120e4
	WizardGames.Soc.Common.Unity.Construction.CoreColliderData GetCoreColliderNode(System.Int64 entityId, System.Int64 templateId, System.Int64 skinId, System.Int32 grade, System.Int64 additionBlockInfo, WizardGames.Soc.Common.Unity.Construction.ECoreColliderState colliderState); // 0x06a11f78
	static UnityEngine.GameObject get_OuterColliderRoot(); // 0x06a12238
	System.Int32 get_MaxShatterCount(); // 0x06a122e4
	System.Void set_MaxShatterCount(System.Int32 value); // 0x06a12348
	System.Void add_OnRecoverConstructionsAroudPos(System.Action value); // 0x06a123c0
	System.Void remove_OnRecoverConstructionsAroudPos(System.Action value); // 0x06a12498
	WizardGames.Soc.SocClient.Construction.BuildMode.WaitBuildData get_RequestCreateBuffer(); // 0x06a12570
	System.Void set_RequestCreateBuffer(WizardGames.Soc.SocClient.Construction.BuildMode.WaitBuildData value); // 0x06a125d4
	System.Void Init(); // 0x06a12654
	System.Void RefreshShatterMaxCount(); // 0x06a12fa8
	System.Void OnEntityCreate(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06a13414
	System.Void OnEntityRemove(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06a13920
	System.String GetPveAreaNameByObjectName(System.String objectName); // 0x06a13e30
	UnityEngine.Ray get_CurrentPlayerViewRay(); // 0x06a13ee4
	WizardGames.Soc.Common.SimpleCustom.SimpleVector3 get_ViewRayPos(); // 0x06a13f68
	System.Threading.Tasks.Task OnEnterWorld(); // 0x06a13fcc
	System.Void OnCameraMove(UnityEngine.Matrix4x4 matrix4X4); // 0x06a140dc
	System.Threading.Tasks.Task OnExitWorld(); // 0x06a14310
	System.Void CleanUp(); // 0x06a14c60
	System.Boolean IsNormalPlayMode(); // 0x06a13728
	System.Threading.Tasks.Task AfterEnterWorld(); // 0x06a14df8
	System.Void AddListener(); // 0x06a14f08
	System.Void RemoveListener(); // 0x06a14918
	System.Void StopWaitCreatePartsAroundPos(System.Boolean isForce); // 0x06a15048
	System.Void RecordPlayerPos(); // 0x06a15188
	System.Void OnSoftReconnect(); // 0x06a15244
	System.Void CheckStopWaitCover(); // 0x06a154cc
	System.Void OnStreamingCompleted(); // 0x06a15604
	System.Void ShowLoading(); // 0x06a156b0
	System.Void ClearUiLoadingCache(); // 0x06a158fc
	System.Void StartCoverToRecoverBuilding(); // 0x06a15968
	System.Void ProcessLoadingCover(); // 0x06a15b80
	System.Void OnGetConstructionListAroundSuddenMovePos(System.Collections.Generic.List<System.Int64> partEntityIdList, WizardGames.Soc.Common.Unity.Construction.EGetNearbyConstructionType type); // 0x06a15bf8
	System.Void SetFixImportPosOver(System.Single x, System.Single y, System.Single z); // 0x06a15fc0
	System.Void RenderUpdate(); // 0x06a16108
	System.Void LateUpdate(); // 0x06a161e4
	System.Void LogicUpdate(); // 0x06a162c0
	System.Void CheckCreatePartBuffer(); // 0x06a163f0
	System.Boolean HasEnoughMaterials(System.Collections.Generic.Dictionary<System.Int64,System.Int32> consumeItem); // 0x06a16d74
	System.Void CheckAndRemoveWaitList(System.Int64 entityId); // 0x06a16f90
	System.Void RemoveConstruction(System.Int64 entityId); // 0x06a172d8
	System.Void OnPartDeployUpgradeOver(System.Int64 partEntityId, System.Int32 info); // 0x06a1734c
	System.Boolean PartChangeSkin(System.Int64 entityId, System.Int64 skinId, System.Boolean changeDefault); // 0x06a17614
	System.Boolean IsSkinChangeCD(System.Int64 entityId, System.Single& costTime, System.Single& endTime, System.Single& cdTime); // 0x06a17e88
	System.Int64 GetPartDefaultSkinId(System.Int64 templateId); // 0x06a182a0
	System.Void OnPartChangeSkinOver(System.Int64 partEntityId, System.Int64 targetSkinId, System.Int32 info); // 0x06a1836c
	System.Void PlaySkinEffect(System.Int64 partType, UnityEngine.Vector3 effectPos, System.Int64 entityId, System.Int64 skinId); // 0x06a18b34
	System.Void TryChangeCurAimPartDirection(System.Int64 partEntityId); // 0x06a18eb4
	System.Void RequestChangePartDirection(System.Int64 partEntityId); // 0x06a19234
	System.Void CreatComboPartOver(System.Int32 result, System.Int64 markId); // 0x06a19330
	System.Void CreatPartOver(System.Int32 result, System.Int64 markId, System.Int64 itemUid, System.Int64 templateId, System.String extraInfo, System.Int64 extraParam); // 0x06a19520
	System.Void DeployCampingTentComplete(System.Boolean result); // 0x06a1a458
	System.Void RepairPartFailedResources(System.Collections.Generic.Dictionary<System.Int64,System.Int32> items); // 0x06a1a66c
	System.Void RemoveMyPartsByGm(); // 0x06a1a790
	System.Void InputUpdate(); // 0x06a1a854
	System.Boolean CheckPermissionByPos(WizardGames.Soc.Common.Construction.EBuildingPrivilegeMask mask, System.Int64 playerEntityId, UnityEngine.Vector3 pos); // 0x06a1a8b4
	System.Void LoadConstructionNumConfig(); // 0x06a12c14
	System.Boolean CheckCountLimit(System.String partPath, System.Int64& partType, WizardGames.Soc.Share.Framework.BasicValueDictionary<System.Int64,System.Int32>& retPartsCount); // 0x06a1aa40
	System.Void RecoverConstruction(System.String partPath, System.String configPath, System.Single x, System.Single y, System.Single z, System.Single rotateY); // 0x06a1b080
	System.Boolean GetAndRefreshBanState(System.Boolean slience); // 0x06a180ec
	System.Boolean get_HasClickDeleteBtn(); // 0x06a1b390
	System.Void set_HasClickDeleteBtn(System.Boolean value); // 0x06a1b3f4
	System.Void TryRotateCurAimConstruction(); // 0x06a1b470
	System.Void TryRemoveAimedConstruction(WizardGames.Soc.Common.Entity.PartEntity targetPartEntity); // 0x06a1b55c
	System.Void ConfirmRequestDestroyPart(WizardGames.Soc.Common.Entity.PartEntity removePart); // 0x06a1b89c
	System.Void RequestDestroyPart(System.Int64 partId); // 0x06a1bd3c
	System.Void RequestPickupPart(System.Int64 partId); // 0x06a1c0ac
	System.Boolean CheckPartWillDestroy(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06a1bf20
	System.Boolean CheckPermission(WizardGames.Soc.Common.Construction.EPrivilegeType privilegeType, WizardGames.Soc.Common.Entity.PartEntity partEntity, System.Boolean silent); // 0x06a1c290
	System.Boolean CheckPermissionByPartEx(WizardGames.Soc.Common.Construction.EPrivilegeType privilegeType, WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06a1bc3c
	static System.Boolean get_IsIgnoreClientConstructionValidPending(); // 0x06a1c3c8
	static System.Boolean get_IsIgnorePermissionCheck(); // 0x06a1c424
	WizardGames.Soc.SocClient.Construction.BuildMode.WireTool get_WireTool(); // 0x06a1c480
	System.Boolean get_IsChangeWireColor(); // 0x06a1c510
	System.Void set_IsChangeWireColor(System.Boolean value); // 0x06a1c574
	WizardGames.Soc.SocClient.Construction.BuildMode.IBuildWireMode get_BuildWireMode(); // 0x06a1c5f0
	System.Void WireRefresh(System.Int64 partID); // 0x06a1c784
	System.Void WireUpdate(); // 0x06a16b04
	System.String get_doorPath(); // 0x06a1c878
	System.String get_toolCupboardPath(); // 0x06a1c960
	System.Void TriggerGuideCommon(); // 0x06a1ca48
	WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase FindGuideBuildData(WizardGames.Soc.SocClient.Manager.BuildGuideItemData guideData); // 0x06a1d394
	System.Void HandleBuildGuide(System.Single[] posConfig, System.Single[] rotConfig, UnityEngine.GameObject& guideObj, System.String path, System.Boolean isDoor); // 0x06a1ce38
	UnityEngine.Vector3 GetVectorFromConfig(System.Single[] configArray); // 0x06a1d8f0
	System.ValueTuple<UnityEngine.Vector3,UnityEngine.Vector3> GetConstructionBpPosAndRot(); // 0x06a1d608
	System.Void LoadGuideGoFinish(UnityEngine.GameObject go, UnityEngine.Vector3 pos, UnityEngine.Vector3 rot, WizardGames.Soc.SocClient.Manager.EGuideType guideType); // 0x06a1d9b4
	System.Void ReleaseDoorOrToolCupboardGuide(WizardGames.Soc.SocClient.Manager.EGuideType guideType); // 0x06a14998
	System.Void ReleaseGuide(System.UInt64& loadAsyncId, UnityEngine.GameObject& guideGameObject, System.String path); // 0x06a1dca8
	System.Void OnInventoryItemChange(); // 0x06a1df60
	System.Void DoBuildItemUse(WizardGames.Soc.Common.CustomType.BaseItemNode item, System.Boolean selected, System.Int64 templateId, System.Boolean isFromBackpack, WizardGames.Soc.Common.CustomType.BaseItemNode newSelectItem); // 0x06a1e20c
	System.Void DoBuildItemUse(System.Int64 nodeId, System.Int64 tempId, System.Boolean isFromBackpack); // 0x06a1e358
	System.Void AfterEnterModeAction(); // 0x06a1e8f8
	System.Void RefreshItemNodes(); // 0x06a1e098
	System.Boolean GetBuildItemData(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x06a1ed38
	System.Void SortItemNodeData(); // 0x06a1eb30
	System.Int32 SortItemNodeCommodity(WizardGames.Soc.Common.CustomType.BaseItemNode a, WizardGames.Soc.Common.CustomType.BaseItemNode b); // 0x06a1f17c
	System.Int32 SortBuildItemCommodity(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase a, WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase b); // 0x06a1f338
	System.Void CleanupRefreshMesh(); // 0x06a14d74
	System.Void WaitToRefreshMesh(System.Int64 entityId); // 0x06a1f6e4
	System.Void ProcessRefreshMesh(); // 0x06a16648
	System.Boolean get_AutoConnection(); // 0x06a1f780
	System.Void set_AutoConnection(System.Boolean value); // 0x06a1f7e4
	System.Boolean get_CpWithToolCupboard(); // 0x06a1f860
	System.Void set_CpWithToolCupboard(System.Boolean value); // 0x06a1f8c4
	WizardGames.Soc.SocClient.Manager.BuildOperationBase get_CurBuildOperation(); // 0x06a1f980
	System.Void set_CurBuildOperation(WizardGames.Soc.SocClient.Manager.BuildOperationBase value); // 0x06a1f9e4
	System.Boolean get_IsBlueprintBuildMode(); // 0x06a1fa64
	System.Boolean get_IsEmptyHandMode(); // 0x06a1fb20
	System.Boolean get_IsDeployMode(); // 0x06a1fbdc
	System.Boolean get_IsBuildWireMode(); // 0x06a1fc98
	System.Boolean get_IsBuildSkinMode(); // 0x06a1fd54
	System.Boolean get_IsBuildCoreMode(); // 0x06a1fe10
	System.Boolean get_IsInBuildMode(); // 0x06a1fecc
	System.Boolean get_IsShortcutsDeployMode(); // 0x06a1ff88
	System.Boolean get_IsInBuildModeWithoutShortcuts(); // 0x06a20044
	System.Boolean get_IsInBuildEditMode(); // 0x06a20100
	System.Boolean get_IsInUiDeployBuildMode(); // 0x06a1dfdc
	System.Boolean get_IsInRepairMode(); // 0x06a201bc
	System.Boolean get_IsInElectricDeployMode(); // 0x06a20278
	System.Boolean get_IsCampingTentDeployMode(); // 0x06a20334
	System.Boolean get_IsInDeployMoveMode(); // 0x06a203f0
	System.Boolean get_IsInBuildPlaceMode(); // 0x06a204ac
	System.Boolean get_IsListOperation(); // 0x06a1c6d0
	WizardGames.Soc.SocClient.Construction.BuildMode.IBuildMode get_CurrentMode(); // 0x06a13d40
	WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase get_CurBuildItemData(); // 0x06a20568
	System.Void BuildModeInit(); // 0x06a2061c
	System.Void BuildModeDestroy(); // 0x06a147f8
	System.Void SubscribeConstructionProperties(); // 0x06a20c6c
	System.Void OnConstructionBriefDataInitedChanged(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Boolean oldValue, System.Boolean newValue); // 0x06a20e2c
	System.Void OnEnterTerritory(System.Int64 territoryEntityId); // 0x06a21000
	System.Void OnExitTerritory(System.Int64 territoryEntityId); // 0x06a210cc
	System.Void OnClearWireAimPart(); // 0x06a21198
	System.Void PlayerStateAction(System.Int32 stateId); // 0x06a21274
	System.Void TriggerGuide(); // 0x06a21340
	System.Void EnterDeployCampingTent(); // 0x06a21404
	System.ValueTuple<System.Boolean,System.Int32> GetBuildHoldItemInfo(System.Int64 weaponId); // 0x06a214d8
	System.Void OnHandleDamage(WizardGames.Soc.Common.SimpleCustom.DamageDataEvent data); // 0x06a21aac
	System.Void ExitBuildModeState(); // 0x06a1e70c
	System.Void EnterBuildModeWithTask(WizardGames.Soc.Common.Data.EBuildThirdModeType thirdModeType, System.Boolean isAppoint, System.Action onBeforeEnterCallback, System.Action onAfterEnterCallback); // 0x06a1e830
	WizardGames.Soc.Common.Data.EBuildThirdModeType GetPieThirdModeTypeByListThirdMode(WizardGames.Soc.Common.Data.EBuildThirdModeType thirdModeType); // 0x06a21c98
	System.Void SwitchBuildOperation(System.Boolean toListOperation); // 0x06a22054
	System.Void EnterBuildMode(WizardGames.Soc.Common.Data.EBuildFirstModeType firstModeType, WizardGames.Soc.Common.Data.EBuildSecondModeType secondModeType, WizardGames.Soc.Common.Data.EBuildThirdModeType thirdModeType); // 0x06a224cc
	System.Void TryRepair(System.Int64 targetEntityId); // 0x06a22598
	System.Void TryRepair(System.Collections.Generic.List<System.Int64> trainCarEntityIds); // 0x06a226ec
	System.Void CreateBlueprintPartsOver(System.Int32 result, System.Int64 param); // 0x06a22958
	System.Void EnterBuildModeWithTaskImpl(WizardGames.Soc.Common.Data.EBuildThirdModeType thirdModeType, System.Boolean isAppoint, System.Action onBeforeEnterCallback, System.Action onAfterEnterCallback); // 0x06a21d34
	System.Void ClearItemUseData(); // 0x06a21c30
	System.Void OnWeaponSwitchSuccess(System.Int64 oldWeaponId, System.Int64 weaponId); // 0x06a22f90
	System.Void SetCurBuildItemData(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData, System.Boolean refreshUi); // 0x06a23774
	System.Boolean IsCanUpgradeOrRemould(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase itemData); // 0x06a23844
	System.Boolean IsUsePCUi(); // 0x06a239dc
	WizardGames.AssetPool.AssetPoolHandle get_MoveMat(); // 0x06a23a40
	System.Void MoveRecoverTriggers(); // 0x06a23af0
	System.Void MoverRecoverConstructionColliders(); // 0x06a23ce8
	System.Void MoveRecoverMats(); // 0x06a23f20
	System.Void MoverRecoverCleanup(); // 0x06a24158
	System.Boolean TurnToWaitMove(WizardGames.Soc.Common.Entity.PartEntity part); // 0x06a24548
	static System.Boolean FalseBoolAction(); // 0x06a2525c
	System.Void TurnBackFromWaitMove(WizardGames.Soc.Common.Entity.PartEntity part); // 0x06a24218
	System.Boolean ClickMove(WizardGames.Soc.Common.Entity.PartEntity part, WizardGames.Soc.Common.Algorithm.Vector3 pos, WizardGames.Soc.Common.Algorithm.Vector3 angle, System.Collections.Generic.Dictionary<System.Int64,System.Single>& incDecayCost); // 0x06a252b8
	System.Void ConfirmMove(WizardGames.Soc.Common.Entity.PartEntity part, WizardGames.Soc.Common.Algorithm.Vector3 pos, WizardGames.Soc.Common.Algorithm.Vector3 angle); // 0x06a26320
	System.Int64 get_waitingMoveFinishPartId(); // 0x06a26da0
	System.Void set_waitingMoveFinishPartId(System.Int64 value); // 0x06a26e04
	System.Void MoveFinish(System.Int64 partId); // 0x06a26e7c
	System.Void ClearMoveCache(); // 0x06a2721c
	System.Void CacheBeforeMove(System.Int64 terrId, UnityEngine.Vector3 firstPos); // 0x06a272e4
	System.Boolean CheckCanMove(WizardGames.Soc.Common.Entity.PartEntity partGo, UnityEngine.Vector3 targetPos, System.Collections.Generic.Dictionary<System.Int64,System.Single> incDecayCost); // 0x06a2567c
	System.Void GetManagedParts(System.Int64 terrId, UnityEngine.Vector3 checkPos, System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PartEntity> oldMangedParts, System.Int32& oldManagedCoreCount, System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PartEntity> newManagedParts, System.Int32& newMangedCoreCount); // 0x06a276c8
	System.Collections.Generic.Dictionary<System.Int64,System.Single> CalcDecayCost(System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PartEntity> newMangedParts, System.Int32 newManagedCoreCount, System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PartEntity> newManagedParts, System.Int32 newMangedCoreCount); // 0x06a27d3c
	System.Void TryDealElectricMove(WizardGames.Soc.Common.Entity.PartEntity part); // 0x06a265d4
	System.Void AddCachedConnection(System.Int64 entityId, System.Boolean isInput, System.Int32 slotId, WizardGames.Soc.Common.CustomType.WireSlotInfoWithLine info); // 0x06a282f8
	System.Void RecoverCachedConnections(); // 0x06a16950
	System.Void MoveDeployOver(System.Int64 entityId, System.Int32 result, System.Collections.Generic.List<System.Int64> args); // 0x06a28458
	System.Void RequestRemoveDeployColliderObject(System.Int64 entityId); // 0x06a28b5c
	System.Void RefreshOuterDeployColliderSet(WizardGames.Soc.SocClient.Manager.BuildingEntityInfo buildingEntityInfo); // 0x06a28d68
	System.Void RefreshOuterDeployColliderPos(WizardGames.Soc.SocClient.Manager.BuildingEntityInfo buildingEntityInfo); // 0x06a2914c
	WizardGames.Soc.SocClient.Manager.OuterDeployColliderGoData GetOuterColliderData(System.Int64 entityId); // 0x06a29014
	WizardGames.Soc.SocClient.Manager.HotKeyCenterGuideData GetBuildHotKeyCenterGuideData(WizardGames.Soc.SocClient.Ui.UiHudElem hudElem, System.Boolean isCreateIfNotExist); // 0x06a29218
	System.Void ResetUpdateInfo(); // 0x06a29298
	System.Void AddRenderOuterCount(); // 0x06a29324
	System.Void AddRenderEntityCount(); // 0x06a29390
	System.Void AddLoadSkinGoCount(); // 0x06a293fc
	System.Void AddLoadMeshCount(); // 0x06a29468
	System.Void AddLoadColliderCount(); // 0x06a11688
	System.Int32 GetWaitRenderCount(System.Int64 terrId); // 0x06a294d4
	System.Boolean IsOneFrameMax(); // 0x06a29714
	System.Boolean IsRenderMax(); // 0x06a297a8
	System.Boolean IsRenderEntityMax(); // 0x06a298a0
	System.Boolean IsLoadMax(); // 0x06a29820
	System.Boolean IsLoadSkinGoMax(); // 0x06a29910
	System.Boolean IsLoadColliderGoMax(); // 0x06a29994
	System.Void RenderAndColliderQueueUpdate(); // 0x06a29a18
	System.Void UpdateTerritoryDistance(System.Boolean force); // 0x06a29bc8
	WizardGames.Soc.SocClient.Manager.WaitRefreshTerritoryInfo GetWaitTerrInfo(System.Int64 territoryId); // 0x06a29560
	System.Void AddWaitRefreshRender(System.Int64 entityId, System.Int64 territoryId); // 0x06a0c098
	System.Void AddWaitLoadSkinGoEntity(System.Int64 entityId, System.Int64 territoryId); // 0x06a29e48
	System.Void AddWaitRefreshPos(System.Int64 entityId, System.Int64 templateId, System.Int64 territoryId); // 0x06a0d35c
	System.Void AddWaitRefreshColliderSet(System.Int64 entityId, System.Int64 templateId, System.Int64 territoryId); // 0x06a0d2ac
	WizardGames.Soc.Common.Entity.PartEntity get_CurTargetEntity(); // 0x06a29ee0
	System.Void add_onTargetChangeAction(System.Action<WizardGames.Soc.Common.Entity.PartEntity> value); // 0x06a29f44
	System.Void remove_onTargetChangeAction(System.Action<WizardGames.Soc.Common.Entity.PartEntity> value); // 0x06a2a034
	System.Single get_time(); // 0x06a2a124
	System.Void PartUpgradeOrRemouldOver(System.Int64 entityId); // 0x06a2a20c
	System.Void AddTargetChangeEvent(System.Action<WizardGames.Soc.Common.Entity.PartEntity> action); // 0x06a2a45c
	System.Void RemoveTargetChangeEvent(System.Action<WizardGames.Soc.Common.Entity.PartEntity> action); // 0x06a2a570
	System.Void UpdateRaycastTarget(System.Collections.Generic.List<WizardGames.Soc.SocClient.Systems.HitObjData> hitObjDataList, WizardGames.Soc.SocClient.Systems.HitObjData obstacle); // 0x06a2a630
	System.Void SetTargetEntity(WizardGames.Soc.Common.Entity.PartEntity targetEntity, System.Boolean isUpgradeOrRemould); // 0x06a2a348
	System.Void UpdateTargetEntity(System.Boolean setNull, System.Boolean isUpgradeOrRemould); // 0x06a1378c
	System.Void UpdateTargetEntity(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06a2aa34
	System.Void TargetPartChangeEvent(); // 0x06a2a9d0
	System.Boolean ShouldLoadBuildUiPackage(); // 0x06a2ab5c
	System.Void SetBuildUiPackageRegistration(System.String key, System.Boolean show); // 0x06a2abf0
	System.Void AddBuildUiPackageKey(System.String key); // 0x06a2ae98
	System.Void RemoveBuildUiPackageKey(System.String key); // 0x06a2b040
	System.Void AddBuildIconPackage(); // 0x06a2b1ec
	System.Void ReleaseBuildIconPackage(); // 0x06a2b36c
	System.Boolean get_HasVirtualPartGo(); // 0x06a2b5c4
	System.Void RecoverPartOver(System.Int32 resultCode, System.Int64 partId); // 0x06a2b670
	System.Void ClearCurrentVirtualPartData(); // 0x06a2b70c
	System.Void RemoveCurrentVirtualPartGo(); // 0x06a2b804
	System.Void DoubleCheckConfirm(); // 0x06a2ba58
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> GetVirtualPartRecoverConsume(); // 0x06a2c49c
	System.Void OnRequestRecoverVirtualPart(); // 0x06a2bacc
	System.Boolean CanShowVirtualPartGo(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06a2c688
	System.Boolean CanShowInteractiveId(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06a2cea8
	System.Boolean IsCurrentComboPartGo(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06a2d228
	System.Void SetVirtualPartData(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06a2d32c
	WizardGames.Soc.SocClient.Construction.VirtualPartObj CreateVirtualPart(WizardGames.Soc.SocClient.Manager.VirtualPartData data); // 0x06a2dd30
	System.Void CreatePartChildVirtualGo(WizardGames.Soc.Common.Entity.PartEntity parentPart); // 0x06a2d910
	WizardGames.Soc.SocClient.Manager.ComboChildPartData GetComboChildPartWorldPos(UnityEngine.Vector3 parentPos, UnityEngine.Vector3 parentEulerAngle, System.Int64 childPartType); // 0x06a2de68
	System.Void VirtualPartStateRefresh(); // 0x06a13820
	System.Void AssistInteractiveComboPart(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06a2e33c
	System.Void ComboPartStateChangeCallback(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06a2e278
	System.Boolean CheckComboPartState(WizardGames.Soc.Common.Entity.PartEntity partEntity, System.Boolean clearCurrentVirtualPart); // 0x06a2e080
	System.Boolean CanShowVirtualPart(); // 0x06a2c9a4
	System.Void OnHudOpenStatesChanged(); // 0x06a2e520
	System.Numerics.Vector2 GetAllDefendToolBoxHPInfo(); // 0x06a2e5a0
	System.Void RenderPoolSaveForCHP(WizardGames.Soc.Common.Component.ConstructionRenderData renderData); // 0x06a0f0e4
	System.Void .ctor(); // 0x06a2e7fc
	static System.Void .cctor(); // 0x06a2f974
	System.Threading.Tasks.Task <>n__0(); // 0x06a2fbac
	System.Threading.Tasks.Task <>n__1(); // 0x06a2fc14
	System.Void <GetAndRefreshBanState>b__175_0(); // 0x06a2fc7c
	System.Void <GetAndRefreshBanState>b__175_1(); // 0x06a2fce4
	System.Void <ReleaseBuildIconPackage>b__448_0(System.Int64 a, System.Object b, System.Boolean c); // 0x06a2fd48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrConstruction.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Manager.MgrConstruction.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Manager.WaitRefreshTerritoryInfo> <>9__405_0; // 0x8
	static System.Void .cctor(); // 0x06a2ff60
	System.Void .ctor(); // 0x06a2ffc4
	System.Int32 <UpdateTerritoryDistance>b__405_0(WizardGames.Soc.SocClient.Manager.WaitRefreshTerritoryInfo item1, WizardGames.Soc.SocClient.Manager.WaitRefreshTerritoryInfo item2); // 0x06a3002c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrConstruction.<>c__DisplayClass183_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrConstruction <>4__this; // 0x10
	WizardGames.Soc.Common.Entity.PartEntity removePart; // 0x18
	System.Void .ctor(); // 0x06a300c8
	System.Void <ConfirmRequestDestroyPart>b__0(); // 0x06a30130
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrConstruction.<>c__DisplayClass218_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrConstruction <>4__this; // 0x10
	UnityEngine.Vector3 targetPos; // 0x18
	UnityEngine.Vector3 targetRot; // 0x24
	System.Boolean isDoor; // 0x30
	System.Void .ctor(); // 0x06a301f8
	System.Void <HandleBuildGuide>b__0(UnityEngine.GameObject go, System.Object[] obj); // 0x06a30260
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Manager.MgrConstruction.<AfterEnterWorld>d__126 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Manager.MgrConstruction <>4__this; // 0x30
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x38
	System.Void MoveNext(); // 0x06a3030c
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x06a305c0
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Manager.MgrConstruction.<OnEnterWorld>d__121 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Manager.MgrConstruction <>4__this; // 0x30
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x38
	System.Void MoveNext(); // 0x06a30664
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x06a30998
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.GpuInstanceInfo : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	static SocLogger logger; // 0x0
	System.Int64 EntityId; // 0x20
	System.Int64 TemplateId; // 0x28
	WizardGames.Soc.Common.Unity.Construction.TemplateGoConfig templateGoConfig; // 0x30
	UnityEngine.Vector3 pos; // 0x38
	UnityEngine.Quaternion rotation; // 0x44
	UnityEngine.Vector3 scale; // 0x54
	System.Boolean enable; // 0x60
	System.Void AddRenderObject(); // 0x06a30a3c
	System.Void RemoveRenderObject(); // 0x06a30a9c
	System.Void SetTemplateId(System.Int64 templateId); // 0x06a30afc
	System.Void ReleaseToPool(); // 0x06a30b74
	System.Void .ctor(); // 0x06a30d78
	static System.Void .cctor(); // 0x06a30de0
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.EConstructionMatType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.EConstructionMatType Normal = 0;
	static WizardGames.Soc.SocClient.Manager.EConstructionMatType BuildGood = 1;
	static WizardGames.Soc.SocClient.Manager.EConstructionMatType BuildBad = 2;
	static WizardGames.Soc.SocClient.Manager.EConstructionMatType BuildOrange = 3;
	static WizardGames.Soc.SocClient.Manager.EConstructionMatType BuildGood_InWater = 4;
	static WizardGames.Soc.SocClient.Manager.EConstructionMatType BuildBad_InWater = 5;
	static WizardGames.Soc.SocClient.Manager.EConstructionMatType BuildOrange_InWater = 6;
	static WizardGames.Soc.SocClient.Manager.EConstructionMatType EditUpdate = 7;
	static WizardGames.Soc.SocClient.Manager.EConstructionMatType EditDelete = 8;
	static WizardGames.Soc.SocClient.Manager.EConstructionMatType VirtualPart = 9;
	static WizardGames.Soc.SocClient.Manager.EConstructionMatType MidState = 10;
	static WizardGames.Soc.SocClient.Manager.EConstructionMatType MoveVirtual = 11;
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Manager.LockEffectQueueData : System.ValueType
{
	System.Int64 entityId; // 0x10
	System.Int64 effectTime; // 0x18
	System.Int32 effectType; // 0x20
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.EPartHighlightType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.EPartHighlightType NormalEdit = 0;
	static WizardGames.Soc.SocClient.Manager.EPartHighlightType WaitRemove = 1;
	static WizardGames.Soc.SocClient.Manager.EPartHighlightType Recovering = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.CheckTerritoryCabinetHandle : System.Object
{
	
	System.Void .ctor(); // 0x06a30eb4
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Manager.BuildGuideItemData : System.ValueType
{
	System.Int32 FirstTagId; // 0x10
	System.Int32 SecondTagId; // 0x14
	System.Int32 Grade; // 0x18
	System.Int64 DataTemplateId; // 0x20
	System.Boolean IsCombo; // 0x28
	System.Int64 ChildGroupId; // 0x30
	System.Boolean Compare(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData); // 0x06a30f1c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Manager.EGuideType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Manager.EGuideType All = 0;
	static WizardGames.Soc.SocClient.Manager.EGuideType Door = 1;
	static WizardGames.Soc.SocClient.Manager.EGuideType ToolCupboard = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.OuterDeployColliderGoData : System.Object
{
	static SocLogger logger; // 0x0
	System.Int64 EntityId; // 0x10
	System.Int64 TemplateId; // 0x18
	System.Int64 SkinId; // 0x20
	System.Int32 state; // 0x28
	UnityEngine.Vector3 pos; // 0x2c
	UnityEngine.Quaternion rotation; // 0x38
	System.UInt64 _loadPrefabAsyncId; // 0x48
	System.String deployPrefabPath; // 0x50
	UnityEngine.GameObject deployColliderGo; // 0x58
	WizardGames.Soc.Common.Combat.ColliderConfigSet deployColliderConfigSet; // 0x60
	WizardGames.Soc.Common.Combat.ConstructionColliderConfigCollection deployConfigCollection; // 0x68
	System.Int64 _currentSkinId; // 0x70
	WizardGames.Soc.Common.Unity.Construction.OutsideAnimColliderConfig deployColliderGoAnimComp; // 0x78
	System.Void Clear(); // 0x06a310d4
	System.Void CheckReloadDeployColliderObject(); // 0x06a311c0
	System.Void AddDeployColliderObject(); // 0x06a313dc
	System.Void OnOutColliderLoadFinish(UnityEngine.GameObject go, System.Object[] arg); // 0x06a31c58
	System.Boolean SetColliderGoTransData(); // 0x06a32088
	System.Void RefreshColliderGoSet(); // 0x06a32200
	System.Void SetupAnimCollider(); // 0x06a326e4
	System.Void UpdateAnimCollider(); // 0x06a32798
	System.Void RemoveDeployColliderObject(); // 0x06a318f0
	System.Void CancelColliderAsyncLoad(); // 0x06a32854
	System.Void .ctor(); // 0x06a328f8
	static System.Void .cctor(); // 0x06a32960
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.WaitRefreshTerritoryInfo : System.Object
{
	static SocLogger logger; // 0x0
	System.Int64 TerrId; // 0x10
	System.Single distanceToPlayer; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Manager.WaitRefreshRenderInfo> waitRefreshRenderEntityMap; // 0x20
	System.Collections.Generic.Queue<System.Int64> updateQueue_Outer; // 0x28
	System.Collections.Generic.Queue<System.Int64> updateQueue_Entity; // 0x30
	System.Collections.Generic.HashSet<System.Int64> waitLoadSkinGoEntityIds; // 0x38
	System.Collections.Generic.Queue<System.Int64> updateQueue_SkinGo; // 0x40
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Manager.WaitRefreshColliderInfo> waitRefreshColliderEntityMap; // 0x48
	System.Collections.Generic.Queue<System.Int64> updateQueueNear_Collider; // 0x50
	System.Void RefreshDistance(UnityEngine.Vector3 playerPos); // 0x06a32a34
	System.Void Update(); // 0x06a32be8
	System.Boolean CanRelease(); // 0x06a33aa0
	System.Void Clear(); // 0x06a33b5c
	System.Int32 get_WaitRenderCount(); // 0x06a33bbc
	System.Void AddWaitRefreshRender(System.Int64 entityId); // 0x06a33c48
	WizardGames.Soc.SocClient.Manager.WaitRefreshRenderInfo GetWaitRefreshRenderInfo(System.Int64 entityId); // 0x06a33d18
	System.Void RenderQueueUpdate_Outer(); // 0x06a32c64
	System.Void RenderQueueUpdate_Entity(); // 0x06a33040
	System.Void AddWaitLoadSkinGoEntity(System.Int64 entityId); // 0x06a33f28
	System.Void SkinGoQueueUpdate(); // 0x06a333d8
	System.Void AddWaitRefreshPos(System.Int64 entityId, System.Int64 templateId); // 0x06a34000
	System.Void AddWaitRefreshColliderSet(System.Int64 entityId, System.Int64 templateId); // 0x06a341f4
	WizardGames.Soc.SocClient.Manager.WaitRefreshColliderInfo GetWaitRefreshColliderInfo(System.Int64 entityId); // 0x06a3409c
	System.Void ColliderQueueUpdate(); // 0x06a33738
	System.Void RemoveCollider(WizardGames.Soc.SocClient.Manager.WaitRefreshColliderInfo waitRefreshInfo); // 0x06a342f8
	System.Void RefreshCollider(WizardGames.Soc.SocClient.Manager.WaitRefreshColliderInfo waitRefreshInfo, WizardGames.Soc.SocClient.Manager.BuildingEntityInfo buildingEntityInfo); // 0x06a34448
	System.Void .ctor(); // 0x06a34624
	static System.Void .cctor(); // 0x06a3484c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.WaitRefreshColliderInfo : System.Object
{
	System.Int64 EntityId; // 0x10
	System.Int64 TemplateId; // 0x18
	System.Boolean RefreshPos; // 0x20
	System.Boolean RefreshColliderSet; // 0x21
	System.Void Clear(); // 0x06a34290
	System.Void .ctor(); // 0x06a34920
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.WaitRefreshRenderInfo : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	System.Int64 EntityId; // 0x20
	System.Boolean InTerritoryOuterQueue; // 0x28
	System.Boolean InTerritoryEntityQueue; // 0x29
	System.Void Clear(); // 0x06a34988
	static WizardGames.Soc.SocClient.Manager.WaitRefreshRenderInfo Generate(); // 0x06a33e04
	System.Void ReleaseToPool(); // 0x06a33e94
	System.Void .ctor(); // 0x06a349f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.EditTargetPartData : System.Object
{
	static SocLogger Logger; // 0x0
	WizardGames.Soc.Common.Entity.PartEntity ParentPartEntity; // 0x10
	System.Collections.Generic.List<System.Int64> ChildEntityIds; // 0x18
	System.Int32 Grade; // 0x20
	System.Boolean IsComboPart; // 0x24
	System.Int64 ParentId; // 0x28
	System.Int64 ParentPartType; // 0x30
	System.Int64 ChildGroupId; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.PartEntity> CurTargetPartEntities; // 0x40
	WizardGames.Soc.SocClient.Go.AutoTurretMonsterGo <AutoTurretMonsterGo>k__BackingField; // 0x48
	System.Boolean IsUpgradeOrRemould; // 0x50
	WizardGames.Soc.SocClient.Go.AutoTurretMonsterGo get_AutoTurretMonsterGo(); // 0x06a34a58
	System.Void set_AutoTurretMonsterGo(WizardGames.Soc.SocClient.Go.AutoTurretMonsterGo value); // 0x06a34abc
	System.Boolean get_HasTargetPartEntity(); // 0x06a34b3c
	System.Void SetTargetPartEntity(WizardGames.Soc.Common.Entity.PartEntity partEntity, System.Boolean isUpgradeOrRemould); // 0x06a34ba8
	System.Int64 GetChildGroupId(); // 0x06a35370
	System.Void RefreshTargetPartEntities(); // 0x06a35464
	System.Void EnterEditMode(); // 0x06a357fc
	System.Void OutOfEditMode(); // 0x06a359ec
	System.Void DrawHighLight(System.Boolean isWaitRemoving); // 0x06a35b6c
	System.Boolean DataCheck(WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase buildItemData); // 0x06a35e08
	System.Void Clear(); // 0x06a35234
	System.Void .ctor(); // 0x06a35f48
	static System.Void .cctor(); // 0x06a3605c
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Manager.VirtualPartData : System.ValueType
{
	System.Int64 TemplateId; // 0x10
	UnityEngine.Vector3 Position; // 0x18
	UnityEngine.Vector3 EulerAngle; // 0x24
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Manager.ComboChildPartData : System.ValueType
{
	UnityEngine.Vector3 Position; // 0x10
	UnityEngine.Vector3 EulerAngle; // 0x1c
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrElectricLocal : WizardGames.Soc.Common.Manager.MgrBase, WizardGames.Soc.Common.SimpleCustom.ISnapshot<WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit>
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PartEntity> _virtualPartGoDict; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,System.Action> _virtualPartGoRecoverDic; // 0x20
	WizardGames.Soc.Common.Entity.PartEntity <BoardNow>k__BackingField; // 0x28
	WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit <icNow>k__BackingField; // 0x30
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> IdMapperICLocal; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> IdMapperLocalIC; // 0x40
	WizardGames.Soc.Common.SimpleCustom.ICCmdDealer cmdDealer; // 0x48
	WizardGames.Soc.Common.Manager.ElectricICStorageNode storageNode; // 0x50
	WizardGames.Soc.SocClient.Ui.UiHudElemICSlot icSlot; // 0x58
	System.Boolean isInEdit; // 0x60
	System.Boolean isWaitingEdit; // 0x61
	System.Int64 blueprintItemId; // 0x68
	static WizardGames.Soc.SocClient.Manager.MgrElectricLocal get_Instance(); // 0x06a36130
	System.Void Init(); // 0x06a361b8
	System.Void CleanUp(); // 0x06a36220
	System.Boolean TryGetVirtualPartGo(System.Int64 entityId, WizardGames.Soc.Common.Entity.PartEntity& go); // 0x06a3688c
	System.Void CleanupLocalPart(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06a36600
	System.Void RemoveLocalPart(System.Int64 entityId); // 0x06a36974
	WizardGames.Soc.Common.Entity.PartEntity get_BoardNow(); // 0x06a36a54
	System.Void set_BoardNow(WizardGames.Soc.Common.Entity.PartEntity value); // 0x06a36ab8
	WizardGames.Soc.Common.Entity.PartEntity GetBackBoard(); // 0x06a36b38
	System.Void ColliderDeal(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06a36ee8
	System.Void ApplySlots(); // 0x06a37338
	System.Void ApplySlot(WizardGames.Soc.Common.CustomType.Alpha3ElectricCircuitSlot slot); // 0x06a37618
	WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit get_icNow(); // 0x06a378dc
	WizardGames.Soc.Common.SimpleCustom.ISnapshot<WizardGames.Soc.Common.CustomType.Alpha3ElectricIntegratedCircuit> MakeSnapshot(); // 0x06a37940
	System.Void ApplyCmd(WizardGames.Soc.Common.SimpleCustom.ICmd cmd); // 0x06a379f4
	System.Boolean GenRevertCmd(WizardGames.Soc.Common.SimpleCustom.ICmd cmd, WizardGames.Soc.Common.SimpleCustom.ICmd& rcmd); // 0x06a37b5c
	System.Boolean OnlineVerify(WizardGames.Soc.Common.SimpleCustom.ICmd cmd); // 0x06a37c58
	System.Void AddUnit(UnityEngine.Vector3 position, WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget buildingTarget); // 0x06a37d24
	System.Void RemoveUnit(WizardGames.Soc.Common.Entity.PartEntity aimedPart); // 0x06a37f8c
	System.Void MoveUnit(WizardGames.Soc.Common.Entity.PartEntity aimedPart, UnityEngine.Vector3 newPos); // 0x06a38204
	System.Void AddWire(System.Int64 inputId, System.Int32 inputIndex, System.Int64 outputId, System.Int32 outputIndex, WizardGames.Soc.Common.Unity.Electric.WireColour color, System.Collections.Generic.List<UnityEngine.Vector3> linePositions); // 0x06a382fc
	System.Void RemoveWire(System.Int64 entityId, System.Int32 index, System.Boolean isInput); // 0x06a385c8
	System.Void ApplyCmdToDealer(WizardGames.Soc.Common.SimpleCustom.ICmd cmd); // 0x06a37ed4
	System.Void PrepareICEdit(System.Int64 itemId); // 0x06a38748
	System.Void UpdateEdit(); // 0x06a381a4
	System.Void ExitEdit(); // 0x06a364a4
	System.Void .ctor(); // 0x06a38888
	static System.Void .cctor(); // 0x06a38a8c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrElectricLocal.<>c__DisplayClass18_0 : System.Object
{
	UnityEngine.Collider collider; // 0x10
	System.Void .ctor(); // 0x06a372d0
	System.Void <ColliderDeal>b__0(); // 0x06a38b60
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.MgrPlayerBlueprintData : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger Logger; // 0x0
	System.Action<System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.ConstructionBlueprintBriefData>> OnFetchBlueprintBriefDataListEventHandler; // 0x18
	System.Action<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.ConstructionBlueprintSaveData>> OnFetchBlueprintPartDataListEventHandler; // 0x20
	System.UInt64 currentBriefDataOwnerRoleId; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.ConstructionBlueprintBriefData> _briefDataList; // 0x30
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.CheckConfigBase>> _constructionCheckDataDict; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.ConstructionBlueprintSaveData>> _constructionSaveDataDict; // 0x40
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> _bpFoundationCountDict; // 0x48
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.ConstructionBlueprintSaveOriginData>> _constructionOriginDataDict; // 0x50
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.Dictionary<System.Int64,System.Int32>> _constructionSummaryDataDict; // 0x58
	System.Collections.Generic.HashSet<System.Int64> ignoreValidCheckPartType; // 0x60
	System.Action<System.Int64,UnityEngine.GameObject> OnGetBlueprintMeshGoEventHandler; // 0x68
	UnityEngine.Transform _holdingRoot; // 0x70
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.ConstructionBlueprintMeshData> _constructionMeshDataDict; // 0x78
	System.Void add_OnFetchBlueprintBriefDataListEventHandler(System.Action<System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.ConstructionBlueprintBriefData>> value); // 0x06a38bd4
	System.Void remove_OnFetchBlueprintBriefDataListEventHandler(System.Action<System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.ConstructionBlueprintBriefData>> value); // 0x06a38cc4
	System.Void add_OnFetchBlueprintPartDataListEventHandler(System.Action<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.ConstructionBlueprintSaveData>> value); // 0x06a38db4
	System.Void remove_OnFetchBlueprintPartDataListEventHandler(System.Action<System.Int64,System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.ConstructionBlueprintSaveData>> value); // 0x06a38ea4
	System.Void Init(); // 0x06a38f94
	System.Void RequestBriefDataListAsync(); // 0x06a38ffc
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.ConstructionBlueprintBriefData> GetBriefDataListInGame(); // 0x06a39950
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.ConstructionBlueprintSaveOriginData> GetOriginDataDictByEntityId(System.Int64 blueprintId); // 0x06a39f6c
	System.Boolean BlueprintHasOriginData(System.Int64 blueprintId); // 0x06a3a10c
	System.Boolean CheckPlayerBpDataValid(System.Int64 blueprintId); // 0x06a3a208
	System.Int32 GetFoundationCount(System.Int64 id); // 0x06a3a974
	WizardGames.Soc.Common.CustomType.ConstructionBlueprintBriefData GetBriefDataById(System.Int64 id); // 0x06a3ace8
	System.Void RequestPartDataByIDAsync(System.Int64 id); // 0x06a3afe4
	System.Void PullBriefDataListFromLobby(); // 0x06a397c0
	System.Void PullPartSaveDataBySlotFromLobby(System.Int32 slot); // 0x06a3b2f8
	System.Void PullPartSaveDataByBlueprintIdFromLobby(System.Int64 blueprintId); // 0x06a3b4bc
	System.Void OnPartDataListGetFromLobby(SimpleJSON.JSONNode node); // 0x06a3b658
	System.Void OnBriefDataListGetFromLobby(SimpleJSON.JSONNode node); // 0x06a3c5e8
	System.Void add_OnGetBlueprintMeshGoEventHandler(System.Action<System.Int64,UnityEngine.GameObject> value); // 0x06a3cecc
	System.Void remove_OnGetBlueprintMeshGoEventHandler(System.Action<System.Int64,UnityEngine.GameObject> value); // 0x06a3cfbc
	UnityEngine.Transform GetRoot(); // 0x06a3d0ac
	System.String GetHoldingObjectName(System.Int64 id); // 0x06a3d1b0
	UnityEngine.GameObject CreateADeployMeshGo(System.String name); // 0x06a3d25c
	UnityEngine.GameObject CreateAMeshGoByMeshData(WizardGames.Soc.Common.SimpleCustom.ConstructionBlueprintMeshData meshData); // 0x06a3d374
	System.String GetLocalMeshDataFilePath(System.Int64 id); // 0x06a3d5a8
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.CheckConfigBase> GetCheckConfigListById(System.Int64 blueprintId); // 0x06a3d69c
	System.Void OnFetchBlueprintToCreateMeshGo(System.Int64 blueprintId, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.ConstructionBlueprintSaveData> dataList); // 0x06a3d7f0
	System.String GetMeshPathByPartType(System.Int64 partType); // 0x06a3e320
	System.Void GenerateMeshDataAndGoByBlueprintId(System.Int64 blueprintId); // 0x06a3d99c
	System.Void SaveMeshDataToAsset(WizardGames.Soc.Common.SimpleCustom.ConstructionBlueprintMeshData meshData); // 0x06a3e530
	System.Void CreateHoldingGoAfterLocalPartDataExist(System.Int64 id); // 0x06a3e880
	System.Void RequestBlueprintHoldingGoAsync(System.Int64 id); // 0x06a3f1b4
	System.Void .ctor(); // 0x06a3f3b0
	static System.Void .cctor(); // 0x06a3f598
}

// Client.Runtime
class WizardGames.Soc.SocClient.Manager.BuildListOperation : WizardGames.Soc.SocClient.Manager.BuildOperationBase
{
	WizardGames.Soc.Common.Data.EBuildFirstModeType <CurrentFirstModeType>k__BackingField; // 0x2c
	WizardGames.Soc.Common.Data.EBuildSecondModeType <CurrentSecondModeType>k__BackingField; // 0x30
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>> firstModeSecondModeDict; // 0x38
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.EBuildSecondModeType,System.Collections.Generic.List<WizardGames.Soc.Common.Data.EBuildThirdModeType>> secondModeThirdModeDict; // 0x40
	WizardGames.Soc.Common.Data.EBuildFirstModeType previousFirstModeType; // 0x48
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.EBuildFirstModeType,WizardGames.Soc.Common.Data.EBuildSecondModeType> secondModeSelectedDict; // 0x50
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.EBuildSecondModeType,WizardGames.Soc.Common.Data.EBuildThirdModeType> thirdModeSelectedDict; // 0x58
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.EBuildSecondModeType,WizardGames.Soc.SocClient.Ui.SelectedBuildData> SecondModeSelectedDataDict; // 0x60
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Construction.BuildTagData> DiscardSecondTagList; // 0x68
	System.Collections.Generic.List<System.Int32> FirstTagList; // 0x70
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Construction.BuildTagData> BuildTagDataList; // 0x78
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>> FirstTagToSecondTagDict; // 0x80
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.Construction.BuildTagData,System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase>> SecondTagToBuildItemDataDict; // 0x88
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Construction.PartViewDataBase> BuildItemMarkerDataLst; // 0x90
	System.Boolean clearTargetSelectionAfterUse; // 0x98
	WizardGames.Soc.SocClient.Ui.SelectedBuildData targetSelectedBuildData; // 0xa0
	System.Boolean isPlaceGuide; // 0xa8
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.EBuildSecondModeType,System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.SelectedBuildData>>> SelectedDataDict; // 0xb0
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.EBuildSecondModeType,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> FirstTagSelectedSecondTagDict; // 0xb8
	System.Boolean LastChangeIsUpgrade; // 0xc0
	System.Int32 LastUpgradeGrade; // 0xc4
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.SelectedBuildData> BuildModifyDataDict; // 0xc8
	System.Int64 editorGrade; // 0xd0
	System.Boolean isHaveRecommend; // 0xd8
	WizardGames.Soc.SocClient.Ui.SelectedBuildData selectedBuildDataRecommend; // 0xe0
	WizardGames.Soc.SocClient.Ui.SelectedBuildData upgradeSelectedBuildData; // 0xe8
