	static WizardGames.Soc.Common.Unity.Main.UnityMainLoop <GameLoopInstance>k__BackingField; // 0x8
	static WizardGames.Soc.Common.Unity.Main.UnityMainLoop <AppLoopInstance>k__BackingField; // 0x10
	System.Boolean <IsLoopActive>k__BackingField; // 0x30
	static WizardGames.Soc.Common.Unity.Main.UnityMainLoop get_GameLoopInstance(); // 0x073e8530
	static System.Void set_GameLoopInstance(WizardGames.Soc.Common.Unity.Main.UnityMainLoop value); // 0x073e85b8
	static WizardGames.Soc.Common.Unity.Main.UnityMainLoop get_AppLoopInstance(); // 0x073e864c
	static System.Void set_AppLoopInstance(WizardGames.Soc.Common.Unity.Main.UnityMainLoop value); // 0x073e86d4
	static System.Boolean get_IsInGameLoop(); // 0x073e8768
	WizardGames.Soc.Common.Unity.Main.LoopType get__loopType(); // 0x073e8964
	System.Boolean get_IsLoopActive(); // 0x073e89c8
	System.Void set_IsLoopActive(System.Boolean value); // 0x073e8a2c
	System.Void OnLoopActiveChanged(System.Boolean bActive); // 0x073e8aa8
	System.Void SetLoopActive(System.Boolean bActive); // 0x073e8b1c
	static System.Void EnterGameSpace(); // 0x073e9868
	static System.Void EnterApplicationSpace(); // 0x073e99f0
	System.Threading.Tasks.Task ExitWorld(); // 0x073e9c34
	System.Void OnFps1Update(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x073e9d34
	System.Void OnFps2Update(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x073e9dc4
	System.Void OnBeforeUpdate(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x073e9e54
	System.Void OnAfterUpdate(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x073e9ee4
	System.Void OnFps10Update(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x073e9f74
	System.Void OnFps20Update(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x073ea004
	System.Void OnFps30Update(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x073ea094
	System.Void OnFpsUnlimitedUpdate(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x073ea124
	System.Void OnFpsUnlimitedUpdate_Input(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x073ea1b4
	System.Void OnFps60Update(System.Int32 timeSinceLastUpdate, System.Int32 timeToNextUpdate, System.Int32 targetFps); // 0x073ea244
	System.Void Start(); // 0x073ea2d4
	System.Void Awake(); // 0x073ea3f4
	System.Void OnDestroy(); // 0x073ea8d4
	System.Void Update(); // 0x073eacb0
	System.Void LateUpdate(); // 0x073ead90
	System.Void OnLateUpdate(); // 0x073eaf3c
	System.Void OnFrameEnd(); // 0x073eaf9c
	System.Void .ctor(); // 0x073eb024
	static System.Void .cctor(); // 0x073eb08c
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Main.UnityMainLoop.<ExitWorld>d__21 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	System.Runtime.CompilerServices.TaskAwaiter <>u__1; // 0x30
	System.Void MoveNext(); // 0x073eb160
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x073eb3a8
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.LightData.ELightSourceType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.LightData.ELightSourceType Construction = 0;
	static WizardGames.Soc.Common.Unity.LightData.ELightSourceType HeldItem = 1;
	static WizardGames.Soc.Common.Unity.LightData.ELightSourceType WeaponAccessory = 2;
	static WizardGames.Soc.Common.Unity.LightData.ELightSourceType Equip = 3;
	
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.LightData.LightItemData : System.ValueType
{
	UnityEngine.Light Light; // 0x10
	System.Int64 EntityId; // 0x18
	System.Boolean IgnoreSelf; // 0x20
	System.Boolean IsAdd; // 0x21
	WizardGames.Soc.Common.Unity.LightData.ELightSourceType SourceType; // 0x24
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Hit.HitInfoCollector : System.Object
{
	System.Collections.Generic.List<UnityEngine.RaycastHit> cache; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.Combat.SocRaycastHit> socCache; // 0x18
	System.Int32 ModifyHitInfo(WizardGames.Soc.Common.Entity.PlayerEntity attacker, WizardGames.Soc.Common.Contexts.Context context, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.HitRequest>& candidates); // 0x054a3fb4
	System.Void Draw(WizardGames.Soc.Common.Entity.PlayerEntity attacker, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.HitRequest> candidates); // 0x073eb44c
	System.Void Clear(); // 0x073eb4c8
	System.Void Release(); // 0x073eb58c
	System.Void .ctor(); // 0x073eb5ec
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Hit.MeleeSingleBoxCastCollector : WizardGames.Soc.Common.Unity.Hit.HitInfoCollector
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.Common.Unity.Hit.MeleeSingleBoxCastCollector collector; // 0x8
	UnityEngine.Vector3 eyePos; // 0x20
	UnityEngine.Vector3 shootDir; // 0x2c
	UnityEngine.Vector3 from; // 0x38
	UnityEngine.Vector3 direction; // 0x44
	UnityEngine.Vector3 halfSize; // 0x50
	UnityEngine.Quaternion orientation; // 0x5c
	UnityEngine.Vector3 center; // 0x6c
	System.Single angle; // 0x78
	System.Single maxDis; // 0x7c
	WizardGames.Soc.Common.Data.holdItem.MeleeHitBox boxInfo; // 0x80
	WizardGames.Soc.Common.Data.holdItem.MeleeBase table; // 0x88
	UnityEngine.Vector3[] startVertices; // 0x90
	UnityEngine.Vector3[] endVertices; // 0x98
	static WizardGames.Soc.Common.Unity.Hit.HitInfoCollector GetCollector(UnityEngine.Vector3 eyePos, UnityEngine.Vector3 shootDir, WizardGames.Soc.Common.Data.holdItem.MeleeHitBox boxInfo, WizardGames.Soc.Common.Data.holdItem.MeleeBase table, System.Single maxDis); // 0x073eb6f8
	System.Int32 ModifyHitInfo(WizardGames.Soc.Common.Entity.PlayerEntity attacker, WizardGames.Soc.Common.Contexts.Context context, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.HitRequest>& candidates); // 0x073ebccc
	System.Void Draw(WizardGames.Soc.Common.Entity.PlayerEntity attacker, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.HitRequest> candidates); // 0x073ed240
	System.Void .ctor(); // 0x073ebc1c
	static System.Void .cctor(); // 0x073ed2bc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Hit.RayCastCollector : WizardGames.Soc.Common.Unity.Hit.HitInfoCollector
{
	static WizardGames.Soc.Common.Unity.Hit.RayCastCollector collector; // 0x0
	UnityEngine.Ray ray; // 0x20
	System.Single dis; // 0x38
	System.Int32 layerMask; // 0x3c
	System.Int32 blockLayer; // 0x40
	static WizardGames.Soc.Common.Unity.Hit.HitInfoCollector GetCollector(UnityEngine.Ray ray, System.Single dis, System.Int32 layerMask, System.Int32 blockLayer); // 0x073ed390
	System.Int32 ModifyHitInfo(WizardGames.Soc.Common.Entity.PlayerEntity attacker, WizardGames.Soc.Common.Contexts.Context context, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.HitRequest>& candidates); // 0x073ed538
	System.Void Draw(WizardGames.Soc.Common.Entity.PlayerEntity attacker, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.HitRequest> candidates); // 0x073edfd8
	System.Void .ctor(); // 0x073ed4d4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Hit.HitInfoFilter : System.Object
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.HitRequest> copy; // 0x10
	System.Int32 ModifyHitInfo(WizardGames.Soc.Common.Entity.PlayerEntity attacker, WizardGames.Soc.Common.Contexts.Context context, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.HitRequest>& candidates); // 0x054a3fb4
	System.Void Clear(); // 0x073ee054
	System.Void Release(); // 0x073ee0b4
	System.Void .ctor(); // 0x073ee114
	static System.Void .cctor(); // 0x073ee1c8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Hit.MeleeMassiveHitFilter : WizardGames.Soc.Common.Unity.Hit.HitInfoFilter
{
	static WizardGames.Soc.Common.Unity.Hit.MeleeMassiveHitFilter filter; // 0x0
	UnityEngine.Ray raycastAxis; // 0x18
	WizardGames.Soc.Common.CustomType.MeleeCustom melee; // 0x30
	System.Boolean isMassive; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.HitRequest> copy; // 0x40
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.SimpleCustom.HitRequest> bestEntityCandidates; // 0x48
	static WizardGames.Soc.Common.Unity.Hit.MeleeMassiveHitFilter GetFilter(UnityEngine.Ray ray, WizardGames.Soc.Common.CustomType.MeleeCustom melee, System.Boolean isMassive); // 0x073ee29c
	System.Int32 ModifyHitInfo(WizardGames.Soc.Common.Entity.PlayerEntity attacker, WizardGames.Soc.Common.Contexts.Context context, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.HitRequest>& candidates); // 0x073ee518
	System.Boolean CompareFomular(UnityEngine.Vector3 pre, UnityEngine.Vector3 cur, System.Single prek, System.Single curk); // 0x073eebdc
	System.Single Getk(System.Int32 entityType); // 0x073eea34
	System.Void FilterSingleBest(WizardGames.Soc.Common.Contexts.Context context, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.HitRequest>& candidates); // 0x073eefb8
	System.Void Clear(); // 0x073ef36c
	System.Void .ctor(); // 0x073ee3ec
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Hit.HitInfoFiller : System.Object
{
	static WizardGames.Soc.Common.Unity.Hit.HitInfoFiller filler; // 0x0
	static SocLogger logger; // 0x8
	UnityEngine.Ray origin; // 0x10
	WizardGames.Soc.Common.CustomType.MeleeCustom melee; // 0x28
	static WizardGames.Soc.Common.Unity.Hit.HitInfoFiller GetFilter(UnityEngine.Ray ray, WizardGames.Soc.Common.CustomType.MeleeCustom melee); // 0x073ef440
	System.Int32 ModifyHitInfo(WizardGames.Soc.Common.Entity.PlayerEntity attacker, WizardGames.Soc.Common.Contexts.Context context, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.HitRequest>& candidates); // 0x073ef5f0
	System.Void Release(); // 0x073efbb0
	System.Void .ctor(); // 0x073ef588
	static System.Void .cctor(); // 0x073efc10
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Hit.IHitTargetFilter : 
{
	
	System.Boolean Ignore(WizardGames.Soc.Common.Entity.IEntity target); // 0x054dec74
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Hit.PlayerBulletPlatformHitTargetFilter : System.Object, WizardGames.Soc.Common.Unity.Hit.IHitTargetFilter
{
	static WizardGames.Soc.Common.Unity.Hit.PlayerBulletPlatformHitTargetFilter _instance; // 0x0
	WizardGames.Soc.Common.Entity.PlayerEntity Player; // 0x10
	WizardGames.Soc.Common.Entity.Ability.IProjectile Projectile; // 0x18
	static WizardGames.Soc.Common.Unity.Hit.PlayerBulletPlatformHitTargetFilter get_Instance(); // 0x073efce0
	static WizardGames.Soc.Common.Unity.Hit.PlayerBulletPlatformHitTargetFilter GetTargetFilter(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.Entity.Ability.IProjectile projectile); // 0x073efdfc
	System.Boolean Ignore(WizardGames.Soc.Common.Entity.IEntity target); // 0x073efea0
	System.Void .ctor(); // 0x073efd94
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Hit.HitUtil : System.Object
{
	static SocLogger logger; // 0x0
	static UnityEngine.RaycastHit[] hitBuffer; // 0x8
	static System.Collections.Generic.List<UnityEngine.RaycastHit> hitBufferList; // 0x10
	static System.Boolean CanReachHit(System.Int64 attacker, UnityEngine.Vector3 origin, WizardGames.Soc.Common.Combat.SocRaycastHit hit, System.Int32 blockLayerMask, UnityEngine.Transform hitCollider); // 0x073ecac8
	static UnityEngine.Vector3 GetRicochetForward(UnityEngine.Vector3 velocity, UnityEngine.Vector3 normal, System.Single angle); // 0x073f01f8
	static System.Boolean TryGetModifiedHitFxId(WizardGames.Soc.Common.Entity.IEntity target, WizardGames.Soc.Common.Combat.ColliderMaterialEnum effectMat, System.Int32 hitPart, System.Int32 Hiteffect, System.Int32& FxID); // 0x073f0458
	static System.Boolean IsHitAbiotic(WizardGames.Soc.Common.Entity.IEntity targetEntity); // 0x073f0650
	static System.Void .cctor(); // 0x073f08d4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.GoLoader.EntityAssetsLoadFinishCallback : System.Object, Share.Common.ObjPool.IPooledObjectNew, WizardGames.Soc.Common.Unity.ObjPool.IAsyncLoadAssetsFinishCallback
{
	System.UInt64 LoadingTaskId; // 0x10
	WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator Creator; // 0x18
	WizardGames.Soc.Common.Unity.GoLoader.EntityGoFactory Factory; // 0x48
	System.UInt64 <Mid>k__BackingField; // 0x50
	System.Boolean <IsReturn>k__BackingField; // 0x58
	System.Boolean <CareThreadSafe>k__BackingField; // 0x59
	System.UInt64 get_Mid(); // 0x073f0a40
	System.Void set_Mid(System.UInt64 value); // 0x073f0aa4
	System.Boolean get_IsReturn(); // 0x073f0b1c
	System.Void set_IsReturn(System.Boolean value); // 0x073f0b80
	System.Boolean get_CareThreadSafe(); // 0x073f0bfc
	System.Void set_CareThreadSafe(System.Boolean value); // 0x073f0c60
	System.Void ReturnToPool(); // 0x073f0cdc
	System.Void OnLoadFinish(System.Collections.Generic.List<UnityEngine.Object> assets); // 0x073f0e58
	System.Void .ctor(); // 0x073f1750
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.GoLoader.DelegateCreateEntityGo : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x073f17b8
	WizardGames.Soc.Common.Unity.Go.BaseEntityGo Invoke(WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f1890
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.GoLoader.CreateEntityGoFunc<T> : System.ValueType
{
	static WizardGames.Soc.Common.Unity.GoLoader.DelegateCreateEntityGo Creator; // 0x0
	static WizardGames.Soc.Common.Unity.Go.BaseEntityGo CreateEntityGo(WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x054e7844
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator : System.ValueType
{
	WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo Mgr; // 0x10
	WizardGames.Soc.Common.Entity.IEntity Entity; // 0x18
	UnityEngine.GameObject Root; // 0x20
	WizardGames.Soc.Common.Unity.GoLoader.DelegateCreateEntityGo Creator; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> Assets; // 0x30
	System.Int32 Priority; // 0x38
	System.Boolean IsAsync; // 0x3c
	System.Boolean FromNet; // 0x3d
	System.Void Init(WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo mgr, WizardGames.Soc.Common.Entity.IEntity entity); // 0x073f18dc
	System.Void Clear(); // 0x073f0d54
	System.Boolean IsValid(); // 0x073f1ab4
	System.Void AddAsset(System.String assetKey, WizardGames.Soc.Common.Unity.ObjPool.EAssetType assetType, WizardGames.Soc.Common.Unity.ObjPool.EAssetReleaseMode releaseMode); // 0x073f1b68
	System.Void AddNonReleaseAsset(UnityEngine.Object asset, WizardGames.Soc.Common.Unity.ObjPool.EAssetType assetType); // 0x073f1cf4
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.GoLoader.CachedEntityGo : System.ValueType
{
	WizardGames.Soc.Common.Unity.Go.BaseEntityGo EntityGo; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> Assets; // 0x18
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.GoLoader.EntityGoFactory : System.Object
{
	static SocLogger Logger; // 0x0
	WizardGames.Soc.Common.Unity.GoLoader.IMakeEntityGoCreator MakeCreator; // 0x10
	WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo Mgr; // 0x18
	WizardGames.Soc.Stl.SocDict<System.Int64,WizardGames.Soc.Common.Unity.GoLoader.CachedEntityGo> EntityToCachedMap; // 0x20
	WizardGames.Soc.Stl.SocDict<System.Int64,WizardGames.Soc.Common.Unity.GoLoader.EntityAssetsLoadFinishCallback> EntityToLoadCallbackMap; // 0x28
	WizardGames.Soc.Stl.SocDict<UnityEngine.GameObject,System.Int64> GoToEntityIdMap; // 0x30
	System.Void .ctor(WizardGames.Soc.Common.Unity.GoLoader.IMakeEntityGoCreator makeCreator, WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo mgr); // 0x073f1e60
	System.Void OnDestroy(); // 0x073f200c
	WizardGames.Soc.Common.Unity.Go.IEntityGo Create(WizardGames.Soc.Common.Entity.IEntity entity, System.Boolean fromNet); // 0x073f2634
	WizardGames.Soc.Common.Unity.Go.IEntityGo LoadAssetsAndCreateEntityGo(WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f2af4
	WizardGames.Soc.Common.Unity.Go.IEntityGo CreateEntityGo(WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f10b8
	System.Boolean Remove(System.Int64 entityId); // 0x073f3000
	System.Void Clear(); // 0x073f21b8
	System.Boolean CreateAsync(WizardGames.Soc.Common.Entity.IEntity entity, System.Boolean fromNet); // 0x073f374c
	System.Boolean CancelAsync(System.Int64 entityId); // 0x073f3604
	static System.Void .cctor(); // 0x073f3cb0
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.GoLoader.IMakeEntityGoCreator : 
{
	
	System.Boolean MakeCreator(WizardGames.Soc.Common.Entity.IEntity entity, System.Boolean fromNet, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x054e0d88
	System.Void OnDestroy(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.GoLoader.MakeEntityGoCreatorClient : System.Object, WizardGames.Soc.Common.Unity.GoLoader.IMakeEntityGoCreator
{
	WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo Mgr; // 0x10
	System.Void .ctor(WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo mgr); // 0x073f3d84
	System.Void OnDestroy(); // 0x073f3e10
	System.Boolean MakeCreator(WizardGames.Soc.Common.Entity.IEntity entity, System.Boolean fromNet, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f3e7c
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.PlayerEntity ent, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f5298
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.MonsterEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f5450
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.TreeEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f56c0
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.TargetEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f57bc
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.ParachuteEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f58b8
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.DecalEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f59d8
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.OreEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f5ad4
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.BoxEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f5f2c
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.AirdropEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f6118
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.MushroomEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f6238
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.CarshredderEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f7540
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.CollectableEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f6e04
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.ElevatorEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f725c
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.DigEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f763c
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.CaveLiftEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f7140
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.IOEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f7020
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.KatyushaEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f7420
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.MonumentEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f7d2c
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.MagicFieldEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f7e4c
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.VehicleEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f6700
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.HorseEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f6990
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.UcmCarEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f6a8c
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.ModularCarEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f6870
	static System.Boolean GetCreator(WizardGames.Soc.Common.CustomType.VehicleModuleCustom entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f869c
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.SpecializedVehicleEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f87bc
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.ZiplineEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f8168
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.NPCEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f7858
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.SceneItemEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f6f00
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.ShopEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f8048
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.TempCofferEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f775c
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.ThrownEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f6334
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.BulletEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f6454
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.CarEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f6680
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.TrainBarricadeEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f85a0
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.TrainCarEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f84a4
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.TrapEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f7954
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.PartEntity ent, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f5d14
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.PartDebrisEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f5e10
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.CorpseEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f5bf4
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.AirDropPlaneEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f7c0c
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.StorageDebrisEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f88b8
	static System.Boolean GetCreator(WizardGames.Soc.Common.CustomType.HeldItemCustom entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f7fc8
	static System.Boolean GetCreator(WizardGames.Soc.Common.CustomType.MeleeCustom entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f6c08
	static System.Boolean GetCreator(WizardGames.Soc.Common.CustomType.ThrowWeaponCustom entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f7f48
	static System.Boolean GetCreator(WizardGames.Soc.Common.CustomType.UseItemCustom entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f6c88
	static System.Boolean GetCreator(WizardGames.Soc.Common.CustomType.WeaponCustom entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f6b88
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.EffectEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f6d08
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.InteractionEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f8288
	static System.Boolean GetCreator(WizardGames.Soc.Common.Entity.MissileEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f83a8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.GoLoader.ThrowWeaponOnCollision : UnityEngine.MonoBehaviour
{
	WizardGames.Soc.Common.Entity.ThrownEntity Entity; // 0x30
	UnityEngine.Rigidbody Rb; // 0x38
	System.Boolean bClientSelf; // 0x40
	System.Action<UnityEngine.GameObject,WizardGames.Soc.Common.Entity.ThrownEntity,UnityEngine.Rigidbody,UnityEngine.Collision> OnHit; // 0x48
	System.Void .ctor(); // 0x073f8ed4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseAirDropPlaneGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo, WizardGames.Soc.Common.Unity.Go.ISmoothGo
{
	Go.GoComp.SmoothComp <SmoothComp>k__BackingField; // 0x68
	System.Void .ctor(); // 0x073f8f3c
	WizardGames.Soc.Common.Entity.AirDropPlaneEntity get_PlaneEntity(); // 0x073f902c
	WizardGames.Soc.Common.Entity.IEntity get_GetEntity(); // 0x073f9124
	Go.GoComp.SmoothComp get_SmoothComp(); // 0x073f91bc
	System.Void set_SmoothComp(Go.GoComp.SmoothComp value); // 0x073f9220
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseBoxGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo, WizardGames.Soc.Common.Unity.Go.ISmoothGo
{
	static SocLogger <log>k__BackingField; // 0x0
	WizardGames.Soc.Common.Data.units.TreasureBox boxData; // 0x68
	System.Boolean m_ManualAddRigid; // 0x70
	Go.GoComp.SmoothComp <SmoothComp>k__BackingField; // 0x78
	System.Collections.Generic.HashSet<System.Int64> damageableSubscribeIds; // 0x80
	System.Boolean canColliderWithVehicle; // 0x88
	System.Int64 openTimerID; // 0x90
	System.Single rotationTime; // 0x98
	System.Single elapsedTime; // 0x9c
	UnityEngine.Quaternion openStartRotation; // 0xa0
	UnityEngine.Quaternion openTargetRotation; // 0xb0
	WizardGames.Soc.Common.Unity.Monster.GeneralConfig <GeneralConfig>k__BackingField; // 0xc0
	OpenBox openBox; // 0xc8
	static SocLogger get_log(); // 0x073f92a0
	WizardGames.Soc.Common.Entity.BoxEntity get_BoxEntity(); // 0x073f9328
	WizardGames.Soc.Common.Entity.IEntity get_GetEntity(); // 0x073f9420
	Go.GoComp.SmoothComp get_SmoothComp(); // 0x073f94b8
	System.Void set_SmoothComp(Go.GoComp.SmoothComp value); // 0x073f951c
	WizardGames.Soc.Common.Unity.Monster.GeneralConfig get_GeneralConfig(); // 0x073f959c
	System.Void set_GeneralConfig(WizardGames.Soc.Common.Unity.Monster.GeneralConfig value); // 0x073f9600
	System.Void .ctor(); // 0x073f9680
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x073f9774
	System.Void SetMainGo(UnityEngine.GameObject mainGo, System.Boolean isBaseOnly); // 0x073f9bc8
	System.Void OnTargetEntityIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, System.Int64 oldValue, System.Int64 newValue); // 0x073fa6b4
	System.Void PlayBoxAnim(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Boolean oldValue, System.Boolean newValue); // 0x073fa9ac
	System.Void OpenDoorTick(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x073faa3c
	System.Void CancelOpenTimer(); // 0x073fac10
	System.Void SetColliderWithVehicle(System.Boolean isCollide); // 0x073fa7c4
	System.Void Remove(); // 0x073fac70
	static WizardGames.Soc.Common.Data.units.TreasureBox GetBoxData(System.Int64 templateId); // 0x073f9938
	System.Void ResetOpenBox(); // 0x073fafd8
	static System.Void .cctor(); // 0x073fb24c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseCarGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo, WizardGames.Soc.Common.Unity.Go.ISmoothGo
{
	Go.GoComp.SmoothComp <SmoothComp>k__BackingField; // 0x68
	WizardGames.Soc.Common.Entity.IEntity get_GetEntity(); // 0x073fb320
	Go.GoComp.SmoothComp get_SmoothComp(); // 0x073fb3b8
	System.Void set_SmoothComp(Go.GoComp.SmoothComp value); // 0x073fb41c
	WizardGames.Soc.Common.Entity.CarEntity get_CarEntity(); // 0x073fb49c
	System.Void .ctor(); // 0x073fb590
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseCarshredderGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo
{
	WizardGames.Soc.Common.Entity.CarshredderEntity <CarshredderEntity>k__BackingField; // 0x68
	WizardGames.Soc.Common.Entity.CarshredderEntity get_CarshredderEntity(); // 0x073fb618
	System.Void set_CarshredderEntity(WizardGames.Soc.Common.Entity.CarshredderEntity value); // 0x073fb67c
	WizardGames.Soc.Common.Data.units.Carshredder get_TbCarshredder(); // 0x073fb6fc
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x073fb844
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x073fb978
	System.Void .ctor(); // 0x073fbc20
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseCaveLiftGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo, WizardGames.Soc.Common.Unity.Go.ISmoothGo, WizardGames.Soc.Common.Unity.Go.IPlatformGo
{
	static SocLogger <log>k__BackingField; // 0x0
	System.Single secondsToTake; // 0x64
	WizardGames.Soc.Common.Unity.CaveLift caveLift; // 0x68
	Go.GoComp.SmoothComp <SmoothComp>k__BackingField; // 0x70
	static SocLogger get_log(); // 0x073fbca8
	UnityEngine.Transform get_bucketTransform(); // 0x073fbd30
	UnityEngine.Transform get_MovingTransform(); // 0x073fbda0
	WizardGames.Soc.Common.Entity.IEntity get_GetEntity(); // 0x073fbe04
	Go.GoComp.SmoothComp get_SmoothComp(); // 0x073fbe9c
	System.Void set_SmoothComp(Go.GoComp.SmoothComp value); // 0x073fbf00
	WizardGames.Soc.Common.Data.units.CaveLiftConfig get_TbCaveLift(); // 0x073fbf80
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.CaveLiftEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x073f8c64
	WizardGames.Soc.Common.Entity.CaveLiftEntity get_CaveLiftEntity(); // 0x073fc0a0
	System.Void .ctor(); // 0x073fc194
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x073fc21c
	UnityEngine.Transform GetPlaneTransform(); // 0x073fc4dc
	System.Void Remove(); // 0x073fc54c
	static System.Void .cctor(); // 0x073fc618
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseCollectableGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo, WizardGames.Soc.Common.Unity.Go.IPickableGo, WizardGames.Soc.Common.Unity.Go.IEntityGo
{
	static SocLogger <Log>k__BackingField; // 0x0
	System.Int32 <PickableDetectionDis>k__BackingField; // 0x64
	System.Int32 get_PickableDetectionDis(); // 0x073fc6ec
	WizardGames.Soc.Common.Entity.CollectableEntity get_CollectableEntity(); // 0x073fc750
	System.Void .ctor(); // 0x073fc844
	System.Void SetMainGo(UnityEngine.GameObject obj); // 0x073fc8d4
	System.Boolean CanPick(UnityEngine.Vector3 playerPos); // 0x073fca38
	static System.Void .cctor(); // 0x073fcfec
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseConstructionLiftGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo
{
	
	WizardGames.Soc.Common.Entity.ElevatorEntity get_ElevatorEntity(); // 0x073fd0c0
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x073fd1b4
	System.Void Update(); // 0x073fd244
	System.Void UpdatePositionRotation(); // 0x073fd2a8
	System.Void .ctor(); // 0x073fd400
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseCorpseGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo
{
	static SocLogger <log>k__BackingField; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.Common.Combat.ColliderConfig> colliderConfigs; // 0x68
	UnityEngine.Rigidbody <Rigidbody>k__BackingField; // 0x70
	System.Boolean OriginKinematic; // 0x78
	System.Boolean canCollectCorpse; // 0x79
	System.Int64 SubscribeIdRemainHp; // 0x80
	WizardGames.Soc.Common.Entity.CorpseEntity CorpseEntity; // 0x88
	WizardGames.Soc.Common.Unity.Entity.IdHolder idholder; // 0x90
	WizardGames.Soc.Common.Data.units.Corpse corpseData; // 0x98
	static SocLogger get_log(); // 0x073fd488
	UnityEngine.Rigidbody get_Rigidbody(); // 0x073fd510
	System.Void set_Rigidbody(UnityEngine.Rigidbody value); // 0x073fd574
	System.Boolean IsChinaVersion(); // 0x073fd5f4
	System.Void .ctor(); // 0x073fd658
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x073fd744
	System.Void SetMainGo(UnityEngine.GameObject mainGo, System.Boolean isBaseOnly); // 0x073fdb58
	System.Void SetGatherSettings(); // 0x073fe08c
	System.Void Clear(); // 0x073fe2a8
	System.Void Remove(); // 0x073fe418
	System.Void OnRemainHpChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Single oldValue, System.Single newValue); // 0x073fdfc8
	static WizardGames.Soc.Common.Data.units.Corpse GetCorpseData(System.Int64 templateId); // 0x073fd8c8
	System.Void InitPhysics(); // 0x073fe484
	static System.Void .cctor(); // 0x073fe688
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Go.DigType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Go.DigType Quarry = 0;
	static WizardGames.Soc.Common.Unity.Go.DigType Pump = 1;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseDigGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo, WizardGames.Soc.Common.Unity.Go.ILadderGo
{
	WizardGames.Soc.Common.Combat.AdsorbCollideConfig[] <adsorbCollideConfigs>k__BackingField; // 0x68
	WizardGames.Soc.Common.Unity.Go.DigType type; // 0x70
	UnityEngine.Animator animator; // 0x78
	UnityEngine.GameObject animatorGo; // 0x80
	WizardGames.Soc.Common.Combat.AdsorbCollideConfig[] get_adsorbCollideConfigs(); // 0x073fe720
	System.Void set_adsorbCollideConfigs(WizardGames.Soc.Common.Combat.AdsorbCollideConfig[] value); // 0x073fe784
	Share.Entity.Interface.ILadderEntity get_LadderEntity(); // 0x073fe804
	WizardGames.Soc.Common.Entity.DigEntity get_DigEntity(); // 0x073fe8c4
	WizardGames.Soc.Common.Data.Play.DigProperty get_TbDig(); // 0x073fe9b8
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x073feac0
	System.Void SetMainGo(UnityEngine.GameObject obj); // 0x073feb80
	System.Void .ctor(); // 0x073fef40
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseElevatorGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo
{
	System.Int32 kUpdateAnimatorActiveStateTimeStamp; // 0x64
	System.String DoorAnimParam; // 0x68
	static SocLogger <log>k__BackingField; // 0x0
	System.Single ElevatorBtnPressedStart; // 0x70
	System.Single ElevatorBtnPressedEnd; // 0x74
	System.Single ElevatorBtnMovePerTick; // 0x78
	static SocLogger get_log(); // 0x073fefc8
	WizardGames.Soc.Common.Entity.ElevatorEntity get_ElevatorEntity(); // 0x073ff050
	WizardGames.Soc.Common.Data.units.ElevatorInteractive get_TbElevatorInteractive(); // 0x073ff144
	WizardGames.Soc.Common.Data.units.ElevatorInteractiveComponent get_TbElevatorInteractiveComponent(); // 0x073ff24c
	System.Void .ctor(); // 0x073ff354
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x073ff424
	System.Boolean IsMainElevator(); // 0x073ff588
	System.Boolean IsElevatorInsideBtn(); // 0x073ff5f8
	System.Boolean IsElevatorOutsideBtn(); // 0x073ff678
	System.Boolean IsDoor(); // 0x073ff6f8
	static System.Void .cctor(); // 0x073ff778
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Go.IEquipOwnerGo : 
{
	
	System.Void UpdateEquips(System.Collections.Generic.List<System.Int64> equipTables, System.Collections.Generic.Dictionary<System.Int64,System.Int64> skins); // 0x0552af00
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseEntityGo : System.Object, WizardGames.Soc.Common.Unity.Go.IEntityGo, Share.Common.ObjPool.IPooledObjectNew
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Entity.IEntity <Entity>k__BackingField; // 0x10
	UnityEngine.GameObject _mainGo; // 0x18
	UnityEngine.Transform _mainTransform; // 0x20
	System.Action RemoveEntityGo; // 0x28
	System.String <PrefabPath>k__BackingField; // 0x30
	WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent <ObjectComponent>k__BackingField; // 0x38
	UnityEngine.Rigidbody <Rigid>k__BackingField; // 0x40
	UnityEngine.GameObject InitRoot; // 0x48
	System.Boolean <CreateByNet>k__BackingField; // 0x50
	System.Boolean LoadSuccess; // 0x51
	System.UInt64 <Mid>k__BackingField; // 0x58
	System.Boolean <IsReturn>k__BackingField; // 0x60
	System.Boolean <CareThreadSafe>k__BackingField; // 0x61
	System.Int64 get_EntityId(); // 0x073ff84c
	WizardGames.Soc.Common.Entity.IEntity get_Entity(); // 0x073ff96c
	System.Void set_Entity(WizardGames.Soc.Common.Entity.IEntity value); // 0x073ff9d0
	UnityEngine.GameObject GetColliderRoot(); // 0x073ffa50
	System.Void ParentRemove(); // 0x073ffab4
	UnityEngine.GameObject get_MainGo(); // 0x073f2e60
	System.Void set_MainGo(UnityEngine.GameObject value); // 0x073ffb14
	UnityEngine.Transform get_MainTransform(); // 0x073fa514
	System.String get_PrefabPath(); // 0x073ffbf4
	System.Void set_PrefabPath(System.String value); // 0x073ffc58
	WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent get_ObjectComponent(); // 0x073ffcd8
	System.Void set_ObjectComponent(WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent value); // 0x073ffd3c
	UnityEngine.Rigidbody get_Rigid(); // 0x073ffdbc
	System.Void set_Rigid(UnityEngine.Rigidbody value); // 0x073ffe20
	System.Boolean get_CreateByNet(); // 0x073ffea0
	System.Void set_CreateByNet(System.Boolean value); // 0x073fff04
	System.Void .ctor(); // 0x073f8fc4
	System.Boolean HasMainGo(); // 0x073fff80
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x073fffe4
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x073f9858
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x073fa420
	System.Void SetupScreenbox(); // 0x07400094
	System.Void DelGuGeNode(System.String nodeName); // 0x074000f4
	System.Void Update(); // 0x07400168
	System.Void UpdateOn1Fps(System.Int64 time); // 0x074001c8
	System.Void Remove(); // 0x073fae84
	System.Boolean IsMountableOfflineKeepMove(); // 0x0740023c
	System.Void OnEntityRemove(); // 0x074002a0
	System.UInt64 get_Mid(); // 0x07400358
	System.Void set_Mid(System.UInt64 value); // 0x074003bc
	System.Boolean get_IsReturn(); // 0x07400434
	System.Void set_IsReturn(System.Boolean value); // 0x07400498
	System.Boolean get_CareThreadSafe(); // 0x07400514
	System.Void set_CareThreadSafe(System.Boolean value); // 0x07400578
	System.Void ReturnToPool(); // 0x074005f4
	System.Void OnEntityChanged(WizardGames.Soc.Common.Entity.IEntity entity); // 0x07400654
	System.Void SetSmoothProp(); // 0x07400708
	static System.Void .cctor(); // 0x07400768
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseInteractionGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo
{
	
	System.Void .ctor(); // 0x07400800
	WizardGames.Soc.Common.Entity.InteractionEntity get_InterEntity(); // 0x07400888
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x07400980
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseIOGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo, WizardGames.Soc.Common.Unity.Go.ILadderGo
{
	WizardGames.Soc.Common.Combat.AdsorbCollideConfig[] <adsorbCollideConfigs>k__BackingField; // 0x68
	System.Boolean InCloseCD; // 0x70
	UnityEngine.Transform RotateTransform; // 0x78
	WizardGames.Soc.Common.Unity.Trigger.CommonTriggerManger TriggerManger; // 0x80
	System.Single elapsedTime; // 0x88
	System.Int64 openTimerID; // 0x90
	System.Single rotationTime; // 0x98
	UnityEngine.Quaternion openStartRotation; // 0x9c
	UnityEngine.Quaternion openTargetRotation; // 0xac
	WizardGames.Soc.Common.Combat.AdsorbCollideConfig[] get_adsorbCollideConfigs(); // 0x07400c94
	System.Void set_adsorbCollideConfigs(WizardGames.Soc.Common.Combat.AdsorbCollideConfig[] value); // 0x07400cf8
	WizardGames.Soc.Common.Combat.AdsorbCollideConfig get_adsorbCollideConfig(); // 0x07400d78
	Share.Entity.Interface.ILadderEntity get_LadderEntity(); // 0x07400ecc
	WizardGames.Soc.Common.Entity.IOEntity get_IOEntity(); // 0x07400f8c
	System.Void .ctor(); // 0x07401080
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x07401168
	static System.Void SetLadderConfig(WizardGames.Soc.Common.Combat.AdsorbCollideConfig config, WizardGames.Soc.Common.Data.LadderData data); // 0x07401c34
	static WizardGames.Soc.Common.Data.units.IOInteractive GetIOData(System.Int64 templateId); // 0x07401a04
	System.Void Remove(); // 0x074021d8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseKatyushaGo : WizardGames.Soc.Common.Unity.Go.BaseMountableGo
{
	static SocLogger <log>k__BackingField; // 0x0
	UnityEngine.Transform[] missilesTransform; // 0x150
	UnityEngine.Vector3 sitPoint; // 0x158
	UnityEngine.Quaternion sitRotation; // 0x164
	UnityEngine.Vector3 curDir; // 0x174
	UnityEngine.Vector3 targetDir; // 0x180
	UnityEngine.GameObject hRotator; // 0x190
	UnityEngine.GameObject vRotator; // 0x198
	System.Single timer; // 0x1a0
	System.Single yRotatSpeed; // 0x1a4
	System.Single xRotatSpeed; // 0x1a8
	static SocLogger get_log(); // 0x074022a8
	WizardGames.Soc.Common.Data.units.KatyushaConfig get_TbKatyusha(); // 0x07402330
	WizardGames.Soc.Common.Entity.KatyushaEntity get_KatyushaEntity(); // 0x07402450
	System.Void .ctor(); // 0x07402544
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x07402608
	System.Void SetVehicleInfo(); // 0x07402ad8
	System.Void InitProperty(); // 0x07402b38
	UnityEngine.Vector3 GetMountPos(System.Int32 index); // 0x07402b98
	UnityEngine.Quaternion GetMountRotation(System.Int32 index); // 0x07402c10
	System.Int32 GetEntityType(); // 0x07402c8c
	System.Boolean IsDriverSeat(System.Int32 index); // 0x07402cf0
	System.Void SetPlayerIdViaSeatIndex(System.Int32 seatIndex, System.Int64 value); // 0x07402d68
	static System.Void .cctor(); // 0x07402de4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseMagicFieldGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo, WizardGames.Soc.Common.Unity.Go.ISmoothGo
{
	Go.GoComp.SmoothComp <SmoothComp>k__BackingField; // 0x68
	WizardGames.Soc.Common.Entity.MagicFieldEntity get_MagicFieldEntity(); // 0x07402eb8
	WizardGames.Soc.Common.Entity.IEntity get_GetEntity(); // 0x07402fac
	Go.GoComp.SmoothComp get_SmoothComp(); // 0x07403044
	System.Void set_SmoothComp(Go.GoComp.SmoothComp value); // 0x074030a8
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x07403128
	System.Void .ctor(); // 0x07403288
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Go.IEntityGo> Gos; // 0x18
	WizardGames.Soc.Common.Unity.GoLoader.EntityGoFactory GoFactory; // 0x20
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.ThrownEntity> ClientThrownGos; // 0x28
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> ClientThrownGosIdToSeq; // 0x30
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Go.IEntityGo> PredictGos; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.IEntity> HasPredictGoEntities; // 0x40
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> ServerEntityIdToClient; // 0x48
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Go.ISmoothGo> SmoothGos; // 0x50
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Go.ISmoothGo> UpdateSmoothGos; // 0x58
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Go.IMoveColliderGo> ColliderGos; // 0x60
	System.Collections.Generic.Dictionary<System.String,UnityEngine.GameObject> Roots; // 0x68
	System.Collections.Generic.Dictionary<System.Int64,System.String> goRootNameDic; // 0x70
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<System.Int64>> ChildIdDic; // 0x78
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Go.IMoveGo> MoveGos; // 0x80
	static System.Action<WizardGames.Soc.Common.Unity.Go.BaseEntityGo> OnGoLoadedCallback; // 0x8
	System.Collections.Generic.IList<System.Int64> _removeList; // 0x88
	System.Boolean bIsClient; // 0x90
	System.Int64 ClientOwnerId; // 0x98
	System.Int32 smoothLod; // 0xa0
	WizardGames.Soc.Common.Utility.Counter ParseIncrementalTimer; // 0xa8
	WizardGames.Soc.Common.Utility.Counter CreateGoTimer; // 0xb0
	WizardGames.Soc.Common.Utility.Counter UpdateGoTimer; // 0xb8
	WizardGames.Soc.Common.Utility.Counter RemoveGoTimer; // 0xc0
	System.Void AddChild(System.Int64 parent, System.Int64 child); // 0x07403310
	System.Void RemoveChild(System.Int64 parent); // 0x0740353c
	System.Void RemoveSingleChild(System.Int64 parent, WizardGames.Soc.Common.Entity.IEntity childEntity); // 0x07403820
	System.Boolean CreateGo(WizardGames.Soc.Common.Entity.IEntity entity, System.Boolean fromNet); // 0x07403a14
	System.Void AddEntityGo(System.Int32 entityTypeId, WizardGames.Soc.Common.Unity.Go.IEntityGo go, System.Int64 entityID); // 0x05510064
	System.Void AfterCreate(WizardGames.Soc.Common.Unity.Go.IEntityGo go, System.Boolean createByNet); // 0x0552af28
	UnityEngine.GameObject GetRootByEntityType(System.Int32 entityType, System.Int64 templateId); // 0x07403ab0
	System.Void BeforeRemove(WizardGames.Soc.Common.Unity.Go.IEntityGo go); // 0x07403ef8
	System.Void Init(); // 0x074041a0
	System.Void Destroy(); // 0x07404208
	System.Threading.Tasks.Task OnExitWorld(); // 0x07404270
	System.Void OnGoLoaded(WizardGames.Soc.Common.Unity.Go.BaseEntityGo go); // 0x074042d8
	WizardGames.Soc.Common.Unity.Go.IEntityGo GetGo(System.Int64 entityId); // 0x07404ee0
	T GetGo<T>(System.Int64 entityId); // 0x052af1f0
	System.Boolean TyrGetGo<T>(System.Int64 entityId, T& go); // 0x052af1f0
	WizardGames.Soc.Common.Unity.Go.IMoveColliderGo GetMoveColliderGo(System.Int64 entityId); // 0x07404f8c
	System.Int64 GetEntityIdByGo(UnityEngine.GameObject go); // 0x07405038
	UnityEngine.GameObject GetRoot(System.String name); // 0x073f89b4
	System.Void AddClientThrownEntity(WizardGames.Soc.Common.Entity.ThrownEntity thrownEntity); // 0x074050ec
	System.Void RemoveClientThrownEntity(System.Int64 id); // 0x07405348
	System.Boolean LinkClientPredictEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x0740541c
	System.Boolean CreateOrUpdateGo(WizardGames.Soc.Common.Entity.IEntity entity, System.Boolean createByNet); // 0x074057b4
	System.Boolean RemoveGo(System.Int64 entityId); // 0x07405bb8
	System.Boolean OnRemoveGo(System.Int64 entityId); // 0x07405c58
	System.Boolean IsAdd2RemoveList(WizardGames.Soc.Common.Unity.Go.IEntityGo go); // 0x07405ef0
	System.Void UpdateFull(System.Int64 snapshotSequence, System.Int64 snapshotWorldTime, System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Share.Framework.EntityBase> entities, System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.IEmbeddedCustom> embedded); // 0x07405f68
	System.Void UpdateIncremental(System.Int64 snapshotSequence, System.Int64 snapshotWorldTime, System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Share.Framework.EntityBase> newEntities, System.Collections.Generic.Dictionary<System.Int64,System.Int32> updateEntities, System.Collections.Generic.Dictionary<System.Int64,System.Int32> removeEntities, System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.IEmbeddedCustom> addEmbedded, System.Collections.Generic.HashSet<WizardGames.Soc.Common.Entity.IEmbeddedCustom> removeEmbedded); // 0x07406c20
	System.Void UpdateEntities(System.Collections.Generic.Dictionary<System.Int64,System.Int32> updateEntities); // 0x07407184
	System.Void NewEntities(System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Share.Framework.EntityBase> newEntities, System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.IEmbeddedCustom> addEmbedded); // 0x074074bc
	System.Void RemoveEntities(System.Collections.Generic.Dictionary<System.Int64,System.Int32> removeEntities, System.Collections.Generic.HashSet<WizardGames.Soc.Common.Entity.IEmbeddedCustom> removeEmbedded); // 0x07407b38
	System.Void CreateWhenGoExist(WizardGames.Soc.Common.Entity.IEntity entity, WizardGames.Soc.Common.Unity.Go.IEntityGo entityGo); // 0x07408070
	System.Void .ctor(); // 0x074080ec
	static System.Void .cctor(); // 0x07408600
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseMissileGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo, WizardGames.Soc.Common.Unity.Go.ISmoothGo
{
	Go.GoComp.SmoothComp <SmoothComp>k__BackingField; // 0x68
	System.Int32 order; // 0x70
	System.Void .ctor(); // 0x07432ab4
	WizardGames.Soc.Common.Entity.MissileEntity get_MissileEntity(); // 0x07432b40
	WizardGames.Soc.Common.Entity.IEntity get_GetEntity(); // 0x07432c38
	Go.GoComp.SmoothComp get_SmoothComp(); // 0x07432cd0
	System.Void set_SmoothComp(Go.GoComp.SmoothComp value); // 0x07432d34
	UnityEngine.Vector3 GetCurDir(); // 0x07432db4
	WizardGames.Soc.Common.Data.units.KatyushaMissile get_TbKatyushaMissile(); // 0x07432ecc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseModularCarGo : WizardGames.Soc.Common.Unity.Go.BaseVehicleGo
{
	static SocLogger <Logger>k__BackingField; // 0x0
	ModularCar ModularCar; // 0x170
	System.Int64 PushEndTimeStamp; // 0x178
	System.Int64 LifterAutoParkingFailedTimeStamp; // 0x180
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.Common.Unity.Go.BaseVehicleModuleGo> VehicleModuleGoes; // 0x188
	UnityEngine.LODGroup lodGroup; // 0x190
	UnityEngine.WheelCollider[] _wheelColliders; // 0x198
	WizardGames.Soc.Common.Entity.ModularCarEntity get_ModularCarEntity(); // 0x07432fd4
	System.Void set_ModularCarEntity(WizardGames.Soc.Common.Entity.ModularCarEntity value); // 0x074330c8
	System.Single get_SteerAngle(); // 0x0743317c
	System.Boolean get_IsPredictable(); // 0x07433258
	System.Void set_MaxHorizontalSpeed(System.Single value); // 0x074332bc
	System.Void .ctor(); // 0x07433330
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x0743348c
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x0743363c
	System.Void InitProperty(); // 0x07433a70
	System.Void AddVehicleModuleGo(System.Int32 socketIndex, WizardGames.Soc.Common.Unity.Go.BaseVehicleModuleGo vehicleModuleGo); // 0x07433bf4
	System.Void RemoveVehicleModuleGo(System.Int32 socketIndex); // 0x07433c9c
	System.Boolean HasDriver(); // 0x07433d38
	System.Void Sleep(WizardGames.Soc.Common.Unity.Go.MountableSleepReason reason); // 0x07433efc
	System.Void WakeUp(WizardGames.Soc.Common.Unity.Go.MountableWakeupReason reason); // 0x074343bc
	System.Void CreateVehicleModuleEntity(System.Int64 templateId, System.Int32 socketIndex); // 0x07434714
	System.Boolean CanMountPlayer(System.Int64 playerId, WizardGames.Soc.Common.Unity.Go.SeatType seatType, System.Int32 seatIndex); // 0x07434ecc
	System.Int32 GetMountPointCount(); // 0x07434f70
	System.Int32 GetMountedCount(); // 0x07435144
	System.Boolean HasMountPoints(); // 0x07435318
	System.Void CheckDecay(); // 0x074354dc
	System.Boolean IsSeatTypeFull(WizardGames.Soc.Common.Unity.Go.SeatType seatType); // 0x0743573c
	System.Boolean HasDriverSeat(); // 0x07435924
	System.Boolean HasPassengerSeat(); // 0x07435af0
	System.Void FixedUpdateWithModules(System.Int32 deltaTime); // 0x07435cbc
	System.Boolean CanMove(); // 0x074360b4
	System.Boolean IsSameMountable(System.Int64 entityId); // 0x0743614c
	System.Void Remove(); // 0x07436448
	System.Void Clear(); // 0x074364b4
	System.Void ReleaseFromLifter(); // 0x074365e0
	System.Boolean CanRepairViaHealth(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x07436684
	WizardGames.Soc.Common.Unity.Go.BaseVehicleModuleGo GetFirstDamagedModuleGo(); // 0x07436928
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> GetRepairConsume(System.Single& recoverHp, System.Int32& totalItems); // 0x07436cc0
	static System.Void .cctor(); // 0x07436da0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseMonsterGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo, WizardGames.Soc.Common.Unity.Go.ISmoothGo
{
	Go.GoComp.SmoothComp <SmoothComp>k__BackingField; // 0x68
	UnityEngine.Transform modelTransform; // 0x70
	UnityEngine.Collider modelCollider; // 0x78
	UnityEngine.GameObject centerBoxBoundsGo; // 0x80
	WizardGames.Soc.Common.Unity.Monster.GeneralConfig GeneralConfig; // 0x88
	UnityEngine.GameObject EquipWeaponGo; // 0x90
	WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo weaponGo; // 0x98
	UnityEngine.GameObject <RotateGo>k__BackingField; // 0xa0
	WizardGames.Soc.Common.Entity.MonsterEntity MonsterEntity; // 0xa8
	System.Int64 transformChangeEventHandle; // 0xb0
	System.Int64 hpSubscribeId; // 0xb8
	System.Action<WizardGames.Soc.Share.Framework.PositionChangeEvent> transformChangeEvent; // 0xc0
	System.Action<WizardGames.Soc.Share.Framework.CustomTypeBase,System.Single,System.Single> hpChangeEvent; // 0xc8
	WizardGames.Soc.Common.Entity.IEntity get_GetEntity(); // 0x07436e74
	Go.GoComp.SmoothComp get_SmoothComp(); // 0x07436f0c
	System.Void set_SmoothComp(Go.GoComp.SmoothComp value); // 0x07436f70
	UnityEngine.GameObject get_RotateGo(); // 0x07436ff0
	System.Void set_RotateGo(UnityEngine.GameObject value); // 0x07437054
	System.Void .ctor(); // 0x074370d4
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x07437168
	System.Void SetRotateGo(); // 0x07437918
	System.Void AddRigidBody(); // 0x07437764
	System.Void Clear(); // 0x074379e0
	System.Void Remove(); // 0x07437b48
	System.Void OnTransformChange(WizardGames.Soc.Share.Framework.PositionChangeEvent e); // 0x07437bb8
	System.Void UpdatePosition(); // 0x07437c3c
	System.Boolean IsPositionalEntity(System.Int64 eid); // 0x07437d50
	UnityEngine.Vector3 GetEntityPos(System.Int64 entityId); // 0x07437dc8
	System.Void OnHpChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Single oldValue, System.Single newValue); // 0x07437e74
	System.Void GetCacheData(); // 0x07437f04
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseMonumentGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo
{
	WizardGames.Soc.Common.Entity.MonumentEntity MonumentEntity; // 0x68
	System.Void .ctor(); // 0x07437fe8
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x07438074
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Go.MountableAuthoritySide : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Go.MountableAuthoritySide Server = 0;
	static WizardGames.Soc.Common.Unity.Go.MountableAuthoritySide Client = 1;
	static WizardGames.Soc.Common.Unity.Go.MountableAuthoritySide BothSide = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseMountableGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo, WizardGames.Soc.Common.Unity.Go.IMountable, WizardGames.Soc.Common.Unity.Go.ISmoothGo, WizardGames.Soc.Common.Unity.Go.IPointBinderGo
{
	System.Int64 ResetSeq; // 0x68
	WizardGames.Soc.Common.Unity.Go.MountableAuthoritySide authoritySide; // 0x70
	System.Boolean <IsAuthority>k__BackingField; // 0x74
	System.Boolean LastIsAuthority; // 0x75
	static SocLogger logger; // 0x0
	Go.GoComp.SmoothRendererNodeComp <SmoothRendererNodeComp>k__BackingField; // 0x78
	WizardGames.Soc.Common.Unity.VehicleCameraParams VehicleCameraParams; // 0x80
	WizardGames.Soc.Common.Unity.Go.VehicleIKParams VehicleIKParams; // 0x88
	WizardGames.Soc.Common.Data.Vehicle.VehicleInfo VehicleInfo; // 0x90
	WizardGames.Soc.Common.Data.VehicleType VehicleType; // 0x98
	WizardGames.Soc.Common.Unity.Go.PIDController posPidController; // 0xa0
	System.Int32 NoneAuthoritySideLerpCountDownMs; // 0xa8
	System.Int32 ForceServerAuthorityCounter; // 0xac
	System.Boolean hasPassenger; // 0xb0
	Soc.Vehicle.MountPointConfig MountPointConfig; // 0xb8
	System.Int64 _mounted; // 0xc0
	Go.GoComp.SmoothComp <SmoothComp>k__BackingField; // 0xc8
	System.Boolean LoadFinished; // 0xd0
	System.Single <MaxHorizontalSpeed>k__BackingField; // 0xd4
	System.Boolean <IsSleep>k__BackingField; // 0xd8
	System.Int64 <LastTransformChangedTime>k__BackingField; // 0xe0
	System.Single <LastPosX>k__BackingField; // 0xe8
	System.Single <LastPosY>k__BackingField; // 0xec
	System.Single <LastPosZ>k__BackingField; // 0xf0
	System.Single <LastRotX>k__BackingField; // 0xf4
	System.Single <LastRotY>k__BackingField; // 0xf8
	System.Single <LastRotZ>k__BackingField; // 0xfc
	System.Single <LastHp>k__BackingField; // 0x100
	System.Single <YawRotSpeed>k__BackingField; // 0x104
	System.Nullable<System.Single> lastAirSpeedY; // 0x108
	System.Nullable<UnityEngine.Vector3> lastVelocity; // 0x110
	System.Int64 SkipLegalCheckTime; // 0x120
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Monster.Point.MonsterPointBinder> <PointBinders>k__BackingField; // 0x128
	System.Int32 <BinderResId>k__BackingField; // 0x130
	WizardGames.Soc.Common.SimpleCustom.CarData lastClientAuthorityData; // 0x138
	System.Int64 <NextDecayTime>k__BackingField; // 0x140
	static System.Int32 HorseAutoRun2SprintFuel = 8;
	static System.Int32 HorseExitSprintIntoRunFuel = 1;
	static System.Single HorseCanSprintMinFuel; // 0x8
	static SocLogger <Logger>k__BackingField; // 0x10
	System.Boolean InWater; // 0x148
	System.Single Deapth; // 0x14c
	System.Boolean get_IsPredictable(); // 0x07438200
	System.Boolean get_UseFixedFrameTimeWhenPredict(); // 0x07438264
	System.Void set_AuthoritySide(WizardGames.Soc.Common.Unity.Go.MountableAuthoritySide value); // 0x074382c8
	System.Boolean get_IsAuthority(); // 0x07438798
	System.Void set_IsAuthority(System.Boolean value); // 0x074387fc
	System.Void OnAuthorityChanged(); // 0x07438878
	System.Boolean get_IsForceServerAuthority(); // 0x074388d8
	WizardGames.Soc.Common.Unity.Go.MountableAuthoritySide GetAuthoritySide(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x07438a1c
	System.Void OnSmooth(System.Int32 deltaTime); // 0x07438c0c
	System.Void Predict(System.Int32 deltaTime, WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, System.Int32 physicTickTime, System.Int32 allPhysicTime); // 0x07438c80
	System.Void ClientFixVelocity(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x07438d18
	System.Void UpdateCmd(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x074396b4
	Go.GoComp.SmoothRendererNodeComp get_SmoothRendererNodeComp(); // 0x0743a010
	System.Void set_SmoothRendererNodeComp(Go.GoComp.SmoothRendererNodeComp value); // 0x0743a074
	WizardGames.Soc.Common.Entity.IBaseMountableEntity get_MountableEntity(); // 0x074386b0
	System.Single get_VehicleFuel(); // 0x0743a0f4
	WizardGames.Soc.Common.Entity.IEntity get_GetEntity(); // 0x0743a168
	Go.GoComp.SmoothComp get_SmoothComp(); // 0x0743a200
	System.Void set_SmoothComp(Go.GoComp.SmoothComp value); // 0x0743a264
	System.Int64 get_TemplateId(); // 0x0743a2e4
	System.Void set_MaxHorizontalSpeed(System.Single value); // 0x0743a3b8
	System.Single get_SteerAngle(); // 0x0743a430
	System.Boolean get_IsSleep(); // 0x0743a494
	System.Void set_IsSleep(System.Boolean value); // 0x0743a4f8
	System.Void set_LastTransformChangedTime(System.Int64 value); // 0x0743a574
	System.Single get_YawRotSpeed(); // 0x0743a5ec
	System.Void set_YawRotSpeed(System.Single value); // 0x0743a650
	WizardGames.Soc.Common.Unity.Go.BaseMountableGo get_ParentGo(); // 0x0743a6c8
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Monster.Point.MonsterPointBinder> get_PointBinders(); // 0x0743a72c
	System.Void .ctor(); // 0x0743a790
	System.Void LodUpdate(System.Int32 deltaTime); // 0x0743a824
	System.Void UnlimitedUpdate(System.Int32 deltaTime); // 0x0743a898
	static System.String GetPrefabPath(WizardGames.Soc.Common.Entity.IBaseMountableEntity entity); // 0x0743a90c
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.IBaseMountableEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x0743ae50
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x0743359c
	System.Void SetMainGo(UnityEngine.GameObject obj); // 0x0743af38
	System.Boolean TryLerpWhenNoneAuthority(System.Int32 deltaTime, System.Single& PosX, System.Single& PosY, System.Single& PosZ, System.Single& RotX, System.Single& RotY, System.Single& RotZ); // 0x0743b394
	System.Void OnAfterInit(); // 0x0743b97c
	System.Void RefreshFuelConsumption(); // 0x0743b9e0
	System.Void SetVehicleInfo(); // 0x0743ba40
	System.Void PlayShatteredEffect(); // 0x0743bd4c
	System.Void Clear(); // 0x0743c02c
	System.Void Remove(); // 0x0743c0e8
	System.Void FixedUpdate(System.Int32 dt); // 0x0743c158
	System.Boolean HasDriver(); // 0x0743c1cc
	System.Int32 get_DriversCount(); // 0x07438b30
	System.Int32 GetEntityType(); // 0x0743c2b8
	System.Boolean GetSpeedUp(); // 0x0743c3cc
	System.Void TryWakeUp(WizardGames.Soc.Common.Unity.Go.MountableWakeupReason reason); // 0x0743c430
	System.Void WakeUp(WizardGames.Soc.Common.Unity.Go.MountableWakeupReason reason); // 0x0743c568
	System.Void TrySleep(WizardGames.Soc.Common.Unity.Go.MountableSleepReason reason); // 0x0743caf8
	System.Void Sleep(WizardGames.Soc.Common.Unity.Go.MountableSleepReason reason); // 0x0743cbc8
	System.Single get_MaxHp(); // 0x07436bec
	System.Single get_Hp(); // 0x07436b18
	System.Single GetCurrentFuel(); // 0x0743d0b4
	System.Boolean CanSprint(); // 0x0743d188
	System.Void RecordPosAndRot(System.Int32 totalFrameTime, System.Int32 cmdSequence); // 0x0743d244
	System.Void RunSmoothRendererNodeComp(System.Int32 deltaTime); // 0x0743d328
	UnityEngine.Vector3 ConvertWorldPosFromMainGo2RenderGo(UnityEngine.Vector3 worldPos); // 0x0743d3f4
	UnityEngine.Quaternion GetRendererRotation(); // 0x0743d680
	System.Boolean get_Visible(); // 0x0743d8a8
	UnityEngine.GameObject GetRenderGo(); // 0x0743d9a8
	System.String GetMountableDisplayName(); // 0x0743db4c
	System.Boolean CanLockInteractive(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0743dcf0
	System.Boolean CanRepairInteractive(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0743dd68
	System.Boolean CanVehicleEngineAndOilInteractive(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0743df30
	System.Boolean CanVehicleStorageInteractive(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0743dfa8
	System.Boolean CanVehicleOperationInteractive(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0743e020
	System.Void PopMessage(System.UInt64 _roleId, System.Int32 type, System.Int32 msgId, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.Alpha3PopMsgParam> lanParams); // 0x0743e0c4
	System.Void PopMessage(System.Int64 entityId, System.Int32 type, System.Int32 msgId, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.Alpha3PopMsgParam> lanParams); // 0x0743e1b0
	System.Void InitProperty(); // 0x07433af0
	System.Void CheckDecay(); // 0x0743e29c
	System.Void OnClientPlayerMounted(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0743e2fc
	System.Void OnClientPlayerDismounted(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0743e370
	System.Void OnClientSwitchSeat(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, System.Int32 oldSeatIndex, System.Int32 newSeatIndex); // 0x0743e4c8
	System.Void ResetViewWhenOnMount(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0743e5a0
	static System.Void ResetViewWhenOnDismount(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0743e40c
	System.Void OnAdsChangedWhenOnMount(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, WizardGames.Soc.Common.Entity.PlayerAdsStateEnum oldState, WizardGames.Soc.Common.Entity.PlayerAdsStateEnum newState); // 0x0743e854
	Soc.Vehicle.SeatStyleType GetSeatStyleType(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0743e8f8
	WizardGames.Soc.Common.Unity.CameraState GetSeatCameraState(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0743ea2c
	WizardGames.Soc.Common.Unity.CameraState GetViewWhenOnMountReadTable(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0743e75c
	System.Boolean CanMove(); // 0x0743eb60
	System.Void ClientLateTick(System.Int32 deltaTime); // 0x0743ebc4
	System.Void InitMountPointConfig(); // 0x055049cc
	System.Boolean CanMountPlayer(System.Int64 playerId, WizardGames.Soc.Common.Unity.Go.SeatType seatType, System.Int32 seatIndex); // 0x0743ed44
	System.Void SetPlayerIdViaSeatIndex(System.Int32 seatIndex, System.Int64 value); // 0x0743edd8
	System.Int64 GetPlayerIdViaSeatIndex(System.Int32 seatIndex); // 0x0743ef64
	UnityEngine.Vector3 GetMountPos(System.Int32 index); // 0x0743f048
	UnityEngine.Vector3 GetMountPosFpOffset(System.Int32 index); // 0x0743f11c
	Soc.Vehicle.MountPointInfo GetMountPointInfo(System.Int32 seatIndex); // 0x0743f1e8
	System.Boolean ApplyMountRotation(); // 0x0743f2a8
	System.Boolean OnlyApplyYaw(); // 0x0743f30c
	UnityEngine.Quaternion GetMountRotation(System.Int32 index); // 0x0743f370
	System.Boolean IsDriverSeat(System.Int32 index); // 0x0743f444
	System.Boolean IsSeatTypeFull(WizardGames.Soc.Common.Unity.Go.SeatType seatType); // 0x0743f520
	System.Int32 GetSeatCount(WizardGames.Soc.Common.Unity.Go.SeatType seatType); // 0x0743f5f8
	System.Int32 GetEmptySeatCount(); // 0x0743f6d0
	System.Boolean IsSeatHasBeenToked(System.Int32 seatIndex); // 0x0743f78c
	System.Boolean HasAnyMounted(); // 0x0743f890
	System.Boolean HasMountPoints(); // 0x0743f964
	System.Int32 GetMountPointCount(); // 0x0743f9f0
	System.Int32 GetMountedCount(); // 0x0743fa74
	System.Boolean HasDriverSeat(); // 0x0743fdd8
	System.Boolean HasPassengerSeat(); // 0x0743fe58
	System.Boolean IsSameMountable(System.Int64 entityId); // 0x07436348
	System.Boolean get_IsInfluentHeightWater(); // 0x0743fed8
	System.Boolean get_IsFloodedHeightWater(); // 0x0743ff64
	System.Boolean CheckInWater(); // 0x0743fff0
	System.Boolean IsOnWater(); // 0x0744031c
	System.Boolean IsInWater(UnityEngine.Vector3 pos, System.Single& deep); // 0x0744021c
	System.Int64 get_WorldTime(); // 0x074405b8
	WizardGames.Soc.Common.Unity.Go.MountableAreaType GetMountableArea(); // 0x07440654
	WizardGames.Soc.Common.Unity.Go.MountableAreaType GetMountableArea(WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo, UnityEngine.Vector3 pos); // 0x07440940
	System.Boolean IsInSafeArea(UnityEngine.Vector3 pos); // 0x07440a20
	System.Boolean IsOutside(WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo, UnityEngine.Vector3 position); // 0x07440af0
	System.Int64 GetMountableRenderTransform(System.Int64 renderTime, UnityEngine.Vector3& pos, UnityEngine.Vector3& rot, System.Int32& V); // 0x07440da0
	static System.Void .cctor(); // 0x07440f08
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.PIDController : System.Object
{
	System.Single kp; // 0x10
	System.Single ki; // 0x14
	System.Single kd; // 0x18
	UnityEngine.Vector3 integral; // 0x1c
	UnityEngine.Vector3 previousError; // 0x28
	System.Void .ctor(System.Single kp, System.Single ki, System.Single kd); // 0x0743b674
	UnityEngine.Vector3 Update(UnityEngine.Vector3 targetPoint, UnityEngine.Vector3 processVariable, System.Single deltaTime); // 0x0743b768
	System.Void Reset(); // 0x0743b8cc
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Go.MountableSleepReason : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Go.MountableSleepReason PosNotChanged = 0;
	static WizardGames.Soc.Common.Unity.Go.MountableSleepReason ClientAuthority = 1;
	static WizardGames.Soc.Common.Unity.Go.MountableSleepReason ServerAuthority = 2;
	static WizardGames.Soc.Common.Unity.Go.MountableSleepReason LifterGrabbed = 3;
	static WizardGames.Soc.Common.Unity.Go.MountableSleepReason OnAfterInit = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Go.MountableWakeupReason : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Go.MountableWakeupReason EnterOtherVehicleTrigger = 0;
	static WizardGames.Soc.Common.Unity.Go.MountableWakeupReason OnAfterInit = 1;
	static WizardGames.Soc.Common.Unity.Go.MountableWakeupReason Push = 2;
	static WizardGames.Soc.Common.Unity.Go.MountableWakeupReason Collision = 3;
	static WizardGames.Soc.Common.Unity.Go.MountableWakeupReason HorseOnDestroy = 4;
	static WizardGames.Soc.Common.Unity.Go.MountableWakeupReason GotDriver = 5;
	static WizardGames.Soc.Common.Unity.Go.MountableWakeupReason ExplosionDamage = 6;
	static WizardGames.Soc.Common.Unity.Go.MountableWakeupReason HorseHpChange = 7;
	static WizardGames.Soc.Common.Unity.Go.MountableWakeupReason TriggerTrainCollisions = 8;
	static WizardGames.Soc.Common.Unity.Go.MountableWakeupReason TriggerWakeupVehicle = 9;
	static WizardGames.Soc.Common.Unity.Go.MountableWakeupReason HorseFollow = 10;
	static WizardGames.Soc.Common.Unity.Go.MountableWakeupReason HorseFeed = 11;
	static WizardGames.Soc.Common.Unity.Go.MountableWakeupReason HorseGetHit = 12;
	static WizardGames.Soc.Common.Unity.Go.MountableWakeupReason ApplyLastClientAuthorityData = 13;
	static WizardGames.Soc.Common.Unity.Go.MountableWakeupReason IsNotGrounded = 14;
	static WizardGames.Soc.Common.Unity.Go.MountableWakeupReason ServerInput = 15;
	static WizardGames.Soc.Common.Unity.Go.MountableWakeupReason ClientAuthority = 16;
	static WizardGames.Soc.Common.Unity.Go.MountableWakeupReason LifterReleased = 17;
	static WizardGames.Soc.Common.Unity.Go.MountableWakeupReason AutoParking = 18;
	static WizardGames.Soc.Common.Unity.Go.MountableWakeupReason RemoveAirWall = 19;
	static WizardGames.Soc.Common.Unity.Go.MountableWakeupReason HorseFall = 20;
	static WizardGames.Soc.Common.Unity.Go.MountableWakeupReason SyncMountableVelocity = 21;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Go.MountableAreaType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Go.MountableAreaType Inside = 0;
	static WizardGames.Soc.Common.Unity.Go.MountableAreaType Outside = 1;
	static WizardGames.Soc.Common.Unity.Go.MountableAreaType SafeZone = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseMushroomGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo
{
	
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.MushroomEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x074410bc
	WizardGames.Soc.Common.Entity.MushroomEntity get_MushroomEntity(); // 0x07441158
	System.Void .ctor(); // 0x0744124c
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x074412d8
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x07441464
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseNPCGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo
{
	WizardGames.Soc.Common.ObjPool.PoolConfig<UnityEngine.GameObject> poolConfig; // 0x68
	UnityEngine.Animator Animator; // 0xa0
	UnityEngine.Transform modelTransform; // 0xa8
	WizardGames.Soc.Common.Entity.NPCEntity get_NPCEntity(); // 0x074415ec
	WizardGames.Soc.Common.Data.units.NPC get_NPCCfg(); // 0x074416e0
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x074417e8
	System.Void .ctor(); // 0x07441a08
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseOreGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo
{
	static SocLogger <log>k__BackingField; // 0x0
	static System.Int32 StageCount; // 0x8
	WizardGames.Soc.Common.Unity.Go.OreConfig oreConfig; // 0x68
	System.Collections.Generic.List<System.Single> stageFractions; // 0x70
	System.Int32 currentStage; // 0x78
	System.Boolean <IsHit>k__BackingField; // 0x7c
	System.Int64 entityId; // 0x80
	static SocLogger get_log(); // 0x07441b2c
	System.Boolean get_IsHit(); // 0x07441bb4
	System.Void set_IsHit(System.Boolean value); // 0x07441c18
	System.Int64 get_EntityId(); // 0x07441c94
	WizardGames.Soc.Common.Entity.OreEntity get_OreEntity(); // 0x07441cf8
	System.Void .ctor(); // 0x07441dec
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x07441f04
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x07442024
	System.Void OnEntityHpChange(System.Single oldHp, System.Single newHp); // 0x074421a8
	System.Void PlayOreShatter(); // 0x07442328
	System.Void Clear(); // 0x07442388
	System.Void Remove(); // 0x07442470
	System.Void InitialOreModelStage(); // 0x074424ec
	System.Void SwitchStage(System.Single fraction, System.Boolean isInit); // 0x07442df0
	System.Void RefreshHpChange(); // 0x074432b0
	System.Void RefreshState(); // 0x07443310
	static WizardGames.Soc.Common.Data.units.GatherResourcesOre GetOreData(System.Int64 templateId); // 0x07442b60
	static System.Void .cctor(); // 0x07443370
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseParachuteGo : WizardGames.Soc.Common.Unity.Go.BaseMountableGo, WizardGames.Soc.Common.Unity.Go.ISmoothGo
{
	Go.GoComp.SmoothComp <SmoothComp>k__BackingField; // 0x150
	static SocLogger <Log>k__BackingField; // 0x0
	System.Int64 templateId; // 0x158
	System.Int64 entityId; // 0x160
	Go.GoComp.SmoothComp get_SmoothComp(); // 0x07443458
	System.Void set_SmoothComp(Go.GoComp.SmoothComp value); // 0x074434bc
	WizardGames.Soc.Common.Entity.ParachuteEntity get_ParachuteEntity(); // 0x0744353c
	System.Int64 get_EntityId(); // 0x07443630
	System.Boolean IsMountableOfflineKeepMove(); // 0x07443694
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.ParachuteEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x074436f8
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x07443990
	System.Void SetMainGo(UnityEngine.GameObject obj); // 0x07443b34
	System.Void Clear(); // 0x07443e78
	System.Void OnTriggerEnter(UnityEngine.Collider collison); // 0x07443ed8
	System.Void Remove(); // 0x07443f4c
	System.Void .ctor(); // 0x07443fb8
	static System.Void .cctor(); // 0x07444040
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BasePartDebrisGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo
{
	static System.Action<WizardGames.Soc.Common.Unity.Go.BasePartDebrisGo> OnPartDebrisGoCreate; // 0x0
	static System.Action<System.Int64> OnPartDebrisGoRemove; // 0x8
	static System.Void add_OnPartDebrisGoCreate(System.Action<WizardGames.Soc.Common.Unity.Go.BasePartDebrisGo> value); // 0x07444114
	static System.Void remove_OnPartDebrisGoCreate(System.Action<WizardGames.Soc.Common.Unity.Go.BasePartDebrisGo> value); // 0x0744421c
	static System.Void add_OnPartDebrisGoRemove(System.Action<System.Int64> value); // 0x07444324
	static System.Void remove_OnPartDebrisGoRemove(System.Action<System.Int64> value); // 0x07444430
	WizardGames.Soc.Common.Entity.PartDebrisEntity get_parentDebrisEntity(); // 0x0744453c
	System.Void set_Visible(System.Boolean value); // 0x07444634
	static System.Boolean GetEntityAssets(WizardGames.Soc.Common.Entity.PartDebrisEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x074446c4
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x074448b4
	System.Void Remove(); // 0x07444cec
	System.Void SetMainGo(UnityEngine.GameObject obj); // 0x07444a78
	System.Void .ctor(); // 0x07444da4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BasePartGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo, WizardGames.Soc.Common.Unity.Go.ILadderGo
{
	WizardGames.Soc.Common.Combat.AdsorbCollideConfig[] _adsorbCollideConfigs; // 0x68
	WizardGames.Soc.Common.Entity.PartEntity get_parentPartEntity(); // 0x07444e30
	WizardGames.Soc.Common.Combat.AdsorbCollideConfig[] get_adsorbCollideConfigs(); // 0x07444f28
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.PartEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x07444fec
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x074452b0
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x07445450
	System.Void .ctor(); // 0x0744562c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BasePlayerGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo, WizardGames.Soc.Common.Unity.Go.ISmoothGo
{
	static UnityEngine.GameObject _ccRoot; // 0x0
	WizardGames.Soc.Common.Entity.PlayerEntity <PlayerEntity>k__BackingField; // 0x68
	UnityEngine.Animator <PlayerAnimator>k__BackingField; // 0x70
	UnityEngine.Transform RootBone; // 0x78
	Go.GoComp.SmoothComp <SmoothComp>k__BackingField; // 0x80
	System.Int64 selfHpSubscribe; // 0x88
	static UnityEngine.GameObject get_CcRoot(); // 0x074456b8
	WizardGames.Soc.Common.Entity.PlayerEntity get_PlayerEntity(); // 0x074457d0
	System.Void set_PlayerEntity(WizardGames.Soc.Common.Entity.PlayerEntity value); // 0x07445834
	UnityEngine.Animator get_PlayerAnimator(); // 0x074458b4
	System.Void set_PlayerAnimator(UnityEngine.Animator value); // 0x07445918
	WizardGames.Soc.Common.Entity.IEntity get_GetEntity(); // 0x07445998
	Go.GoComp.SmoothComp get_SmoothComp(); // 0x07445a30
	System.Void set_SmoothComp(Go.GoComp.SmoothComp value); // 0x07445a94
	System.Void .ctor(); // 0x07445b14
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x07445ba8
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x07445ce0
	System.Void SubscribePropertyChange(); // 0x07445f44
	System.Void UnSubscribePropertyChange(); // 0x074461c8
	System.Void Remove(); // 0x07446430
	System.Void OnNameChangeCallback(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.String oldName, System.String newName); // 0x074464a0
	System.Void OnHpChangeCallback(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldHp, System.Single newHp); // 0x07446530
	System.Void OnStaminaChangeCallback(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldStamina, System.Single newStamina); // 0x074465c0
	System.Void Update(); // 0x07446650
	System.Void UpdatePosition(); // 0x074466c0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseSceneItemGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo, WizardGames.Soc.Common.Unity.Go.ISmoothGo, WizardGames.Soc.Common.Unity.Go.IPickableGo, WizardGames.Soc.Common.Unity.Go.IEntityGo
{
	static SocLogger <Log>k__BackingField; // 0x0
	System.Int32 <PickableDetectionDis>k__BackingField; // 0x64
	static System.Int32 LayerMask; // 0x8
	Go.GoComp.SmoothComp <SmoothComp>k__BackingField; // 0x68
	System.Int32 get_PickableDetectionDis(); // 0x07446720
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.SceneItemEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x07446784
	static System.String GetPrefabPath(WizardGames.Soc.Common.Entity.SceneItemEntity entity); // 0x07446888
	WizardGames.Soc.Common.Entity.SceneItemEntity get_SceneItemEntity(); // 0x07446aec
	WizardGames.Soc.Common.Entity.IEntity get_GetEntity(); // 0x07446be0
	Go.GoComp.SmoothComp get_SmoothComp(); // 0x07446c78
	System.Void set_SmoothComp(Go.GoComp.SmoothComp value); // 0x07446cdc
	System.Void .ctor(); // 0x07446d5c
	System.Boolean CanPick(UnityEngine.Vector3 playerPos); // 0x07446df0
	static System.Void .cctor(); // 0x074474c4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseShopGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo, WizardGames.Soc.Common.Unity.Go.ISmoothGo
{
	Go.GoComp.SmoothComp <SmoothComp>k__BackingField; // 0x68
	WizardGames.Soc.Common.Entity.ShopEntity get_ShopEntity(); // 0x074475ec
	System.Void .ctor(); // 0x074476e0
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x0744776c
	System.Void Update(); // 0x074478c0
	System.Void Remove(); // 0x07447920
	WizardGames.Soc.Common.Entity.IEntity get_GetEntity(); // 0x074479e0
	Go.GoComp.SmoothComp get_SmoothComp(); // 0x07447a78
	System.Void set_SmoothComp(Go.GoComp.SmoothComp value); // 0x07447adc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseSocHorseGo : WizardGames.Soc.Common.Unity.Go.BaseMountableGo, WizardGames.Soc.Common.Unity.Go.ISmoothGo
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Entity.HorseEntity HorseEntity; // 0x150
	WizardGames.Soc.Common.Unity.Character.SocUnityHorseController SocColliderCc; // 0x158
	UnityEngine.GameObject ColliderGo; // 0x160
	static UnityEngine.GameObject _ccRoot; // 0x8
	System.Int64 hpSubscribeId; // 0x168
	System.Boolean LastIsFloodedHeightWater; // 0x170
	WizardGames.Soc.Common.Entity.PlayerEntity DriverEntity; // 0x178
	UnityEngine.GameObject HorseHead; // 0x180
	UnityEngine.GameObject HorseBack; // 0x188
	UnityEngine.GameObject HitCapsule; // 0x190
	static UnityEngine.GameObject get_CcRoot(); // 0x07447b5c
	System.Void set_MaxHorizontalSpeed(System.Single value); // 0x07447ca0
	System.Single get_VehicleFuel(); // 0x054a5abc
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x07447d88
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x07447e9c
	System.Void OnAfterInit(); // 0x07448180
	System.Void SetEnable(System.Boolean enable); // 0x07448610
	System.Void Remove(); // 0x074486e0
	System.Void Clear(); // 0x0744874c
	System.Void AddFieldChangeListen(); // 0x07448840
	System.Void RemoveFieldChangeListen(); // 0x074488a0
	System.Void InitProperty(); // 0x055049cc
	System.Void InitLocalProperty(); // 0x055049cc
	System.Void SetVehicleInfo(); // 0x055049cc
	System.Boolean get_IsPredictable(); // 0x07448e60
	System.Void WaterUpdate(); // 0x07448ec4
	System.Void ExitInFloodedHeightWater(); // 0x07448fdc
	System.Void OnInFloodedHeightWater(); // 0x0744903c
	System.Void EnterInFloodedHeightWater(); // 0x0744909c
	System.Void Sleep(WizardGames.Soc.Common.Unity.Go.MountableSleepReason reason); // 0x074490fc
	System.Void WakeUp(WizardGames.Soc.Common.Unity.Go.MountableWakeupReason reason); // 0x07449178
	System.Void InitColliderCc(); // 0x07448200
	System.Void UpdateHorseRiderCc(System.Boolean isRiding); // 0x0744925c
	System.Void PrePredict(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, System.Boolean needUpdate); // 0x0552af28
	System.Void .ctor(); // 0x07449548
	static System.Void .cctor(); // 0x074495d0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseStorageDebrisGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo
{
	
	WizardGames.Soc.Common.Entity.StorageDebrisEntity get_parentStorageDebrisEntity(); // 0x074496a4
	static System.Boolean GetEntityAssets(WizardGames.Soc.Common.Entity.StorageDebrisEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x0744979c
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x074499fc
	System.Void SetMainGo(UnityEngine.GameObject obj); // 0x07449b88
	System.Void RefreshTransformInfo(); // 0x07449cfc
	System.Void .ctor(); // 0x07449e60
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseTargetGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo, WizardGames.Soc.Common.Unity.Go.ISmoothGo
{
	Go.GoComp.SmoothComp <SmoothComp>k__BackingField; // 0x68
	static SocLogger <Log>k__BackingField; // 0x0
	System.Collections.Generic.HashSet<System.Int64> damageableSubscribeIds; // 0x70
	System.Int64 templateId; // 0x78
	System.Int64 entityId; // 0x80
	WizardGames.Soc.SocSimulator.TargetHpComp targetHpComp; // 0x88
	WizardGames.Soc.SocSimulator.TargetMoveComp targetMoveComp; // 0x90
	WizardGames.Soc.Common.Entity.IEntity get_GetEntity(); // 0x07449eec
	Go.GoComp.SmoothComp get_SmoothComp(); // 0x07449f84
	System.Void set_SmoothComp(Go.GoComp.SmoothComp value); // 0x07449fe8
	WizardGames.Soc.Common.Entity.TargetEntity get_TargetEntity(); // 0x0744a068
	System.Int64 get_EntityId(); // 0x0744a15c
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x0744a1c0
	System.Void SetMainGo(UnityEngine.GameObject obj); // 0x0744a360
	System.Void OnHpChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Single oldValue, System.Single newValue); // 0x0744a758
	System.Void OnMaxHpChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Single oldValue, System.Single newValue); // 0x0744a820
	System.Void Clear(); // 0x0744a8e8
	System.Void Remove(); // 0x0744aac0
	System.Void .ctor(); // 0x0744ab30
	static System.Void .cctor(); // 0x0744ac08
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseTempCofferGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo
{
	
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.TempCofferEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x0744acdc
	WizardGames.Soc.Common.Entity.TempCofferEntity get_TempCofferEntity(); // 0x0744af54
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0744b048
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x0744b1d4
	System.Void .ctor(); // 0x0744b344
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseThrownEntityGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo, WizardGames.Soc.Common.Unity.Go.ISmoothGo, WizardGames.Soc.Common.Unity.Go.IServerEntity, WizardGames.Soc.Common.Unity.Go.IPickableGo, WizardGames.Soc.Common.Unity.Go.IEntityGo
{
	UnityEngine.Vector3 vehiclePos; // 0x64
	UnityEngine.Vector3 vehicleRot; // 0x70
	UnityEngine.Vector3 historyVehiclePos; // 0x7c
	UnityEngine.Vector3 historyVehicleRot; // 0x88
	System.Single deltaRotY; // 0x94
	static UnityEngine.Pool.ObjectPool<UnityEngine.GameObject> TempGoPool; // 0x0
	System.Int32 <PickableDetectionDis>k__BackingField; // 0x98
	Go.GoComp.SmoothComp <SmoothComp>k__BackingField; // 0xa0
	WizardGames.Soc.Common.Entity.ThrownEntity serverThrownEntity; // 0xa8
	UnityEngine.GameObject serverThrownGO; // 0xb0
	Go.GoComp.SmoothComp serverSmoothComp; // 0xb8
	WizardGames.Soc.Common.Component.PhysicsMoveComponent physicsMoveComponent; // 0xc0
	System.Boolean canAdsorption; // 0xc8
	System.Int64 lastPlaySoundTime; // 0xd0
	System.Boolean OnGetUseCorrdinateTrans(); // 0x0744b3d0
	UnityEngine.Vector3 OnGetNewPos(UnityEngine.Vector3 historyPos); // 0x0744b434
	UnityEngine.Vector3 OnGetNewVelocity(UnityEngine.Vector3 historyVelocity); // 0x0744b654
	UnityEngine.Vector3 OnGetHistoryVelocity(UnityEngine.Vector3 newVelocity); // 0x0744b730
	UnityEngine.Vector3 OnGetRelativePos(UnityEngine.Vector3 historyPos); // 0x0744b810
	UnityEngine.Vector3 GetRotatedLocalVector3(UnityEngine.Vector3 beginV3, UnityEngine.Vector3 endV3, System.Single deltaRotateY); // 0x0744b4f8
	UnityEngine.Vector3 InverseTransformPoint(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 worldPosition); // 0x0744b92c
	System.Int32 get_PickableDetectionDis(); // 0x0744bae4
	WizardGames.Soc.Common.Entity.IEntity get_GetEntity(); // 0x0744bb48
	Go.GoComp.SmoothComp get_SmoothComp(); // 0x0744bd10
	System.Void set_SmoothComp(Go.GoComp.SmoothComp value); // 0x0744bd74
	WizardGames.Soc.Common.Entity.ThrownEntity get_ThrownEntity(); // 0x0744bc1c
	static System.String GetDropModelPath(WizardGames.Soc.Common.Entity.ThrownEntity entity); // 0x0744bdf4
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.ThrownEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x0744bef4
	System.Void SetServerEntity(WizardGames.Soc.Common.Entity.ThrownEntity serverEntity); // 0x0744c1a8
	System.Void UpdateServerSmoothData(System.Int64 lastServerTime); // 0x0744c490
	System.Void .ctor(); // 0x0744c5b0
	System.Boolean HasMainGo(); // 0x0744c644
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x0744c6a8
	System.Void StartPhysicsMove(); // 0x0744c7fc
	System.Void AfterSyncTransform(); // 0x0744d3b0
	System.Void OnAttached(System.Int64 attachId, System.Int32 attachType, System.Boolean isAttach); // 0x0744d50c
	System.Void AfterStopMove(); // 0x0744d670
	System.Void OnLandGround(WizardGames.Soc.Common.Combat.SocRaycastHit hitInfo, UnityEngine.Collider baseCollider); // 0x0744d6d0
	System.Void OnPhysicsMove(System.Single costTime, System.Boolean isLand); // 0x0744dc20
	System.Void OnCollisionHit(WizardGames.Soc.Common.Combat.SocRaycastHit hitInfo); // 0x0744def0
	System.Void ClearEffect(); // 0x0744e134
	System.Void PlaySoundOnHit(); // 0x0744e194
	System.Void ParentRemove(); // 0x0744e1f4
	System.Void Clear(); // 0x0744e26c
	System.Void Remove(); // 0x0744e420
	System.Void Update(); // 0x0744e49c
	System.Boolean CanPick(UnityEngine.Vector3 playerPos); // 0x0744e4fc
	static System.Void .cctor(); // 0x0744e590
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Go.BaseThrownEntityGo.TriggerModeEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Go.BaseThrownEntityGo.TriggerModeEnum Time = 1;
	static WizardGames.Soc.Common.Unity.Go.BaseThrownEntityGo.TriggerModeEnum Collision = 2;
	static WizardGames.Soc.Common.Unity.Go.BaseThrownEntityGo.TriggerModeEnum FindFloor = 3;
	static WizardGames.Soc.Common.Unity.Go.BaseThrownEntityGo.TriggerModeEnum Fuse = 4;
	static WizardGames.Soc.Common.Unity.Go.BaseThrownEntityGo.TriggerModeEnum RFDetonation = 5;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseThrownEntityGo.<>c : System.Object
{
	static WizardGames.Soc.Common.Unity.Go.BaseThrownEntityGo.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x0744e6cc
	System.Void .ctor(); // 0x0744e730
	UnityEngine.GameObject <.cctor>b__61_0(); // 0x0744e798
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseTrainBarricadeGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo
{
	WizardGames.Soc.Common.Data.units.TrainBarricade config; // 0x68
	WizardGames.Soc.Common.Entity.TrainBarricadeEntity <TrainBarricadeEntity>k__BackingField; // 0x70
	WizardGames.Soc.Common.Entity.TrainBarricadeEntity get_TrainBarricadeEntity(); // 0x0744e824
	System.Void set_TrainBarricadeEntity(WizardGames.Soc.Common.Entity.TrainBarricadeEntity value); // 0x0744e888
	System.Void .ctor(); // 0x0744e908
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x0744e994
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x0744ebc0
	System.Void Update(); // 0x0744ee9c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseTrainCarGo : WizardGames.Soc.Common.Unity.Go.BaseVehicleGo
{
	
	System.Boolean get_IsPredictable(); // 0x0744eefc
	WizardGames.Soc.Common.Entity.TrainCarEntity get_TrainCarEntity(); // 0x0744084c
	System.Void .ctor(); // 0x0744ef60
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x0744efe8
	System.Boolean CanMove(); // 0x0744f198
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Go.BaseTrainCarGo.EngineSpeeds : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Go.BaseTrainCarGo.EngineSpeeds Rev_Hi = 0;
	static WizardGames.Soc.Common.Unity.Go.BaseTrainCarGo.EngineSpeeds Rev_Med = 1;
	static WizardGames.Soc.Common.Unity.Go.BaseTrainCarGo.EngineSpeeds Rev_Lo = 2;
	static WizardGames.Soc.Common.Unity.Go.BaseTrainCarGo.EngineSpeeds Zero = 3;
	static WizardGames.Soc.Common.Unity.Go.BaseTrainCarGo.EngineSpeeds Fwd_Lo = 4;
	static WizardGames.Soc.Common.Unity.Go.BaseTrainCarGo.EngineSpeeds Fwd_Med = 5;
	static WizardGames.Soc.Common.Unity.Go.BaseTrainCarGo.EngineSpeeds Fwd_Hi = 6;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseTrapGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo
{
	
	WizardGames.Soc.Common.Entity.TrapEntity get_TrapEntity(); // 0x0744f240
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.TrapEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x0744f334
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0744f630
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x0744f7d4
	System.Void .ctor(); // 0x0744f958
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseTreeGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo
{
	static SocLogger <Log>k__BackingField; // 0x0
	System.Int64 templateId; // 0x68
	System.Int64 entityId; // 0x70
	WizardGames.Soc.Common.Entity.TreeEntity get_TreeEntity(); // 0x0744f9e4
	System.Int64 get_EntityId(); // 0x0744fad8
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x0744fb3c
	System.Void SetMainGo(UnityEngine.GameObject obj); // 0x0744fcdc
	System.Void OnHpChangeCallback(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldHp, System.Single newHp); // 0x0744ff38
	System.Void Remove(); // 0x07450000
	System.Void .ctor(); // 0x074500f4
	static System.Void .cctor(); // 0x07450180
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseUcmCarGo : WizardGames.Soc.Common.Unity.Go.BaseEntityGo, WizardGames.Soc.Common.Unity.Go.ISmoothGo
{
	Go.GoComp.SmoothComp <SmoothComp>k__BackingField; // 0x68
	WizardGames.Soc.Common.Entity.IEntity get_GetEntity(); // 0x07450254
	Go.GoComp.SmoothComp get_SmoothComp(); // 0x074502ec
	System.Void set_SmoothComp(Go.GoComp.SmoothComp value); // 0x07450350
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.UcmCarEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x074503d0
	WizardGames.Soc.Common.Entity.UcmCarEntity get_CarEntity(); // 0x0745046c
	System.Void .ctor(); // 0x07450560
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x074505ec
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x07450778
	System.Void Update(); // 0x0745083c
	System.Void UpdatePosition(); // 0x074508a0
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Go.SeatType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Go.SeatType NoLimit = 0;
	static WizardGames.Soc.Common.Unity.Go.SeatType Driver = 1;
	static WizardGames.Soc.Common.Unity.Go.SeatType Passenger = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseVehicleGo : WizardGames.Soc.Common.Unity.Go.BaseMountableGo, WizardGames.Soc.Common.Unity.Go.ISmoothGo, WizardGames.Soc.Common.Unity.IRepairAble
{
	static SocLogger <Logger>k__BackingField; // 0x0
	static System.Single MinRollBackDistance = 7;
	static System.Single MaxRollBackDistance = 12;
	static System.Single MinRollBackVelocity = 12.5;
	static System.Single MaxRollBackVelocity = 30;
	static System.Int32 RollBackForceServerAuthorityDuration = 5000;
	BaseVehicle BaseVehicle; // 0x150
	WizardGames.Soc.Common.Vehicle.VehicleGroundCheck VehicleGroundCheck; // 0x158
	WizardGames.Soc.Common.Vehicle.BaseFuelComponent BaseFuelComponent; // 0x160
	System.Int64 WhenDismountNextDecayTime; // 0x168
	static System.Collections.Generic.List<System.Single> RpcParamsList; // 0x8
	static SocLogger get_Logger(); // 0x0745097c
	WizardGames.Soc.Common.Entity.IBaseVehicleEntity get_VehicleEntity(); // 0x07450a04
	System.Boolean get_IsPredictable(); // 0x07450aec
	UnityEngine.Vector3 get_Velocity(); // 0x07450b88
	System.Void SetMainGo(UnityEngine.GameObject obj); // 0x07433820
	System.Void OnAfterInit(); // 0x07450f24
	System.Void InitServerSide(); // 0x07450f98
	System.Void SetBaseVehicleIsAuthority(System.Boolean isAuthority); // 0x07450e44
	System.Void WakeUp(WizardGames.Soc.Common.Unity.Go.MountableWakeupReason reason); // 0x07434664
	System.Void RefreshFuelConsumption(); // 0x0745112c
	System.Void OnAuthorityChanged(); // 0x0745118c
	static UnityEngine.Quaternion GetDiffAngleQuaternion(UnityEngine.Quaternion source, UnityEngine.Quaternion target); // 0x07439564
	System.Void FixedUpdate(System.Int32 dt); // 0x074512ac
	System.Boolean get_IsEngineOn(); // 0x07451344
	System.Void CheckDecay(); // 0x074356a0
	System.Void OpenVehicleLight(System.Boolean isOpen); // 0x07451400
	System.Void UpdateVehicleLight(); // 0x07451518
	System.Void Sleep(WizardGames.Soc.Common.Unity.Go.MountableSleepReason reason); // 0x07434224
	System.Boolean CanMove(); // 0x07451628
	System.Boolean GetCarLightArea(); // 0x07451780
	System.Void OnSmooth(System.Int32 deltaTime); // 0x07451854
	System.Void Remove(); // 0x0743654c
	System.Boolean CanMountPlayer(System.Int64 playerId, WizardGames.Soc.Common.Unity.Go.SeatType seatType, System.Int32 seatIndex); // 0x07451a68
	System.Boolean CanRepair(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x07451b14
	System.Boolean CanRepairViaHealth(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x07436730
	System.Boolean CanRepairAfterAttacked(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x07451bb8
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> GetRepairConsume(System.Single& recoverHp, System.Int32& totalItems); // 0x07451e54
	System.Void .ctor(); // 0x07433404
	static System.Void .cctor(); // 0x07451fcc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseVehicleModuleGo : WizardGames.Soc.Common.Unity.Go.BaseVehicleGo, WizardGames.Soc.Common.Unity.Go.ISmoothGo
{
	static SocLogger <Logger>k__BackingField; // 0x0
	WizardGames.Soc.Common.CustomType.VehicleModuleCustom VehicleModuleCustom; // 0x170
	BaseVehicleModule VehicleModule; // 0x178
	WizardGames.Soc.Common.Unity.Go.BaseModularCarGo ModularCarGo; // 0x180
	WizardGames.Soc.Common.Data.Vehicle.VehicleModule ModuleInfo; // 0x188
	static SocLogger get_Logger(); // 0x07452508
	System.Boolean get_IsPredictable(); // 0x07452590
	WizardGames.Soc.Common.Unity.Go.BaseMountableGo get_ParentGo(); // 0x074525f4
	System.Void set_MaxHorizontalSpeed(System.Single value); // 0x07452658
	System.Void .ctor(); // 0x074526cc
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x07452754
	System.Void OnHpChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x07452868
	static System.Void GetEntityAssets(WizardGames.Soc.Common.CustomType.VehicleModuleCustom entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x07452b48
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x07452db4
	System.Void SetVehicleInfo(); // 0x07453044
	System.Void InitProperty(); // 0x07453248
	UnityEngine.GameObject LinkModuleWithModularCar(WizardGames.Soc.Common.Entity.IVehicleModuleCustom vme, WizardGames.Soc.Common.Unity.Go.IEntityGo carGo); // 0x074532a8
	System.Void Clear(); // 0x07453554
	System.Void Remove(); // 0x074536c4
	System.Void SleepFromModularCar(WizardGames.Soc.Common.Unity.Go.MountableSleepReason reason); // 0x074341a8
	System.Void WakeUpFromModularCar(WizardGames.Soc.Common.Unity.Go.MountableWakeupReason reason); // 0x074345e8
	System.Void WakeUp(WizardGames.Soc.Common.Unity.Go.MountableWakeupReason reason); // 0x07453730
	System.Boolean CanMountPlayer(System.Int64 playerId, WizardGames.Soc.Common.Unity.Go.SeatType seatType, System.Int32 seatIndex); // 0x07453a78
	System.Boolean HasAnyMounted(); // 0x07453b20
	System.Void CheckDecay(); // 0x07453b90
	System.Void RefreshFuelConsumption(); // 0x07453c00
	System.Boolean IsVehicleFunctionValid(WizardGames.Soc.Common.Data.VehicleFunctionType vehicleFunctionType); // 0x07453c60
	System.Void OnEngineItemChanged(System.Int32 id, WizardGames.Soc.Common.Entity.IItemEntity itemEntity); // 0x07453d38
	System.Void OpenVehicleLight(System.Boolean isOpen); // 0x07453e10
	System.Boolean GetWindowStateViaSeatIndex(System.Int32 seatIndex); // 0x07453ea0
	System.Boolean IsSeatTypeFullViaModule(WizardGames.Soc.Common.Unity.Go.SeatType seatType); // 0x07453f60
	System.Boolean IsSeatTypeFull(WizardGames.Soc.Common.Unity.Go.SeatType seatType); // 0x07453fdc
	System.Boolean IsSameMountable(System.Int64 entityId); // 0x0745405c
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> GetRepairConsume(System.Single& recoverHp, System.Int32& totalItems); // 0x07454100
	System.Boolean CanRepairViaHealth(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x074543f0
	static System.Void .cctor(); // 0x07454470
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseVehicleModuleGo.<>c__DisplayClass16_0 : System.Object
{
	VehicleModuleEngine vehicleModuleEngine; // 0x10
	System.Void .ctor(); // 0x07452ae0
	System.Void <OnHpChange>b__0(System.Int64 id, System.Object data, System.Boolean delete); // 0x07454544
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseZiplineGo : WizardGames.Soc.Common.Unity.Go.BaseMountableGo, WizardGames.Soc.Common.Unity.Go.ISmoothGo
{
	UnityEngine.Vector2 pitchClamp; // 0x150
	UnityEngine.Vector2 yawClamp; // 0x158
	UnityEngine.Transform mountAnchor; // 0x160
	System.Single maxMountDistance; // 0x168
	UnityEngine.Transform[] dismountPositions; // 0x170
	WizardGames.Soc.Common.Unity.CameraState mountedCameraMode; // 0x178
	UnityEngine.Transform handle; // 0x180
	UnityEngine.Transform leftHandle; // 0x188
	UnityEngine.Transform rightHandle; // 0x190
	System.Single MoveSpeed; // 0x198
	System.Single ForwardAdditive; // 0x19c
	System.Single SpeedUpTime; // 0x1a0
	System.Boolean LimitedSpeedUp; // 0x1a4
	UnityEngine.AnimationCurve MountPositionCurve; // 0x1a8
	UnityEngine.AnimationCurve MountRotationCurve; // 0x1b0
	System.Single MountEaseInTime; // 0x1b8
	System.Int64 ForwardZiplineID; // 0x1c0
	System.Single mountTime; // 0x1c8
	System.Single currentTravelDistance; // 0x1cc
	static System.Int32 ZipTimes; // 0x0
	static UnityEngine.Vector3 Offset; // 0x4
	System.Int32 ziplineIndex; // 0x1d0
	System.Single percent; // 0x1d4
	System.Single distance; // 0x1d8
	WizardGames.Soc.Common.Entity.ZiplineEntity get_ZiplineEntity(); // 0x074545e4
	System.Boolean IsMountableOfflineKeepMove(); // 0x074546d8
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.ZiplineEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x0745473c
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x07454850
	System.Void SetVehicleInfo(); // 0x07454a8c
	System.Boolean ZiplineInFinish(); // 0x07454aec
	System.Int32 GetEntityType(); // 0x07454bb4
	System.Void Clear(); // 0x07454c18
	System.Void Remove(); // 0x07454c88
	UnityEngine.Vector3 GetMountPos(System.Int32 index); // 0x07454cf4
	UnityEngine.Transform GetLefltHandle(); // 0x07454e68
	UnityEngine.Transform GetRightHandle(); // 0x07454ecc
	System.Boolean GetSpeedUp(); // 0x07454f30
	UnityEngine.Quaternion GetMountRotation(System.Int32 index); // 0x07454fa4
	System.Void .ctor(); // 0x0745505c
	static System.Void .cctor(); // 0x07455174
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.CarTrigger : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x074551d0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.CharacterTrigger : UnityEngine.MonoBehaviour
{
	
	System.Void OnControllerColliderHit(UnityEngine.ControllerColliderHit hit); // 0x07455238
	System.Void .ctor(); // 0x074552ec
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.HorseSmoothRenderNodeComp : Go.GoComp.SmoothRendererNodeComp
{
	
	System.Void .ctor(WizardGames.Soc.Common.Unity.Go.BaseMountableGo mountableGo, UnityEngine.Transform rendererNode, System.Boolean updatePos, UnityEngine.Transform root); // 0x07455354
	System.Void SetPositionAndRotation(System.Int32 deltaTime); // 0x07455428
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Go.IEntityGo : 
{
	
	System.Int64 get_EntityId(); // 0x054a4380
	WizardGames.Soc.Common.Entity.IEntity get_Entity(); // 0x054e7844
	UnityEngine.GameObject get_MainGo(); // 0x054e7844
	UnityEngine.Transform get_MainTransform(); // 0x054e7844
	System.Void ParentRemove(); // 0x055049cc
	System.Void UpdateOn1Fps(System.Int64 time); // 0x055112ac
	System.Void Update(); // 0x055049cc
	System.Void OnEntityRemove(); // 0x055049cc
	System.Void OnEntityChanged(WizardGames.Soc.Common.Entity.IEntity entity); // 0x05523a54
	System.Boolean IsMountableOfflineKeepMove(); // 0x054c4760
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Go.ILadderGo : 
{
	
	WizardGames.Soc.Common.Combat.AdsorbCollideConfig[] get_adsorbCollideConfigs(); // 0x054e7844
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Go.IMountable : 
{
	
	UnityEngine.Vector3 GetMountPos(System.Int32 index); // 0x054b1178
	UnityEngine.Quaternion GetMountRotation(System.Int32 index); // 0x054b4a44
	System.Boolean ApplyMountRotation(); // 0x054c4760
	System.Boolean IsSeatTypeFull(WizardGames.Soc.Common.Unity.Go.SeatType seatType); // 0x054c4f88
	System.Int32 GetEmptySeatCount(); // 0x0548ba98
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Go.IMoveColliderGo : 
{
	
	System.Void set_ColliderDirty(System.Boolean value); // 0x05523a7c
	System.Void UpdateCollider(System.Int32 lod); // 0x055056e8
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Go.IMoveGo : 
{
	
	
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Go.IPickableGo : , WizardGames.Soc.Common.Unity.Go.IEntityGo
{
	
	System.Boolean CanPick(UnityEngine.Vector3 playerPos); // 0x054c6f54
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Go.IPlatformGo : 
{
	
	UnityEngine.Transform GetPlaneTransform(); // 0x054e7844
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Go.IPointBinderGo : 
{
	
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Monster.Point.MonsterPointBinder> get_PointBinders(); // 0x054e7844
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Go.IServerEntity : 
{
	
	System.Void SetServerEntity(WizardGames.Soc.Common.Entity.ThrownEntity serverEntity); // 0x05523a54
	System.Void UpdateServerSmoothData(System.Int64 lastServerTime); // 0x055112ac
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Go.ISmoothGo : 
{
	
	WizardGames.Soc.Common.Entity.IEntity get_GetEntity(); // 0x054e7844
	Go.GoComp.SmoothComp get_SmoothComp(); // 0x054e7844
	System.Void set_SmoothComp(Go.GoComp.SmoothComp value); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.MonsterTrigger : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x07455b54
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BindParams : System.Object
{
	UnityEngine.Transform SourceTransform; // 0x10
	System.String TargetBoneName; // 0x18
	System.Void .ctor(); // 0x07455bbc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.ParachuteBind : UnityEngine.MonoBehaviour
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Go.BindParams> Binds; // 0x30
	WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent obc; // 0x38
	System.Void BindPlayer(WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent obc); // 0x07455c24
	System.Void Unbind(); // 0x07455ca4
	System.Void LateUpdate(); // 0x07455d10
	System.Void .ctor(); // 0x07456014
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.PrefabGo : System.Object
{
	System.String PrefabPath; // 0x10
	UnityEngine.GameObject Go; // 0x18
	UnityEngine.GameObject _prefab; // 0x20
	UnityEngine.MeshRenderer Renderer; // 0x28
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Go.IKEffectPoint : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Go.IKEffectPoint LeftHand = 0;
	static WizardGames.Soc.Common.Unity.Go.IKEffectPoint RightHand = 1;
	static WizardGames.Soc.Common.Unity.Go.IKEffectPoint LeftFoot = 2;
	static WizardGames.Soc.Common.Unity.Go.IKEffectPoint RightFoot = 3;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.VehicleIKParam : System.Object
{
	WizardGames.Soc.Common.Unity.Go.IKEffectPoint point; // 0x10
	UnityEngine.Transform target; // 0x18
	UnityEngine.Transform Tptarget; // 0x20
	System.Void .ctor(); // 0x0745607c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.VehicleRotateParam : System.Object
{
	WizardGames.Soc.Common.Unity.Go.IKEffectPoint bodyPart; // 0x10
	UnityEngine.Transform rotTrans; // 0x18
	System.Single targetPitch; // 0x20
	System.Single defaultPitch; // 0x24
	System.Single rotSpeed; // 0x28
	System.Void .ctor(); // 0x074560e4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.VehicleIKParams : UnityEngine.MonoBehaviour
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Go.VehicleIKParam> IKPoints; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Go.VehicleRotateParam> RotateParams; // 0x38
	System.Void .ctor(); // 0x0745614c
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Go.HitBoxInfo : System.ValueType
{
	UnityEngine.Vector3 Position; // 0x10
	UnityEngine.Quaternion Rotation; // 0x1c
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.BaseHitBoxComp : WizardGames.Soc.Common.Combat.HitBoxComp
{
	System.Collections.Generic.Dictionary<System.String,UnityEngine.Collider> hitBoxColliders; // 0x40
	UnityEngine.GameObject hitBoxGo; // 0x48
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Go.HitBoxInfo> hitBoxInfos; // 0x50
	UnityEngine.GameObject baseGo; // 0x58
	System.Collections.Generic.Dictionary<System.String,UnityEngine.GameObject> childGos; // 0x60
	System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform> Bones; // 0x68
	System.Int32 get_Id(); // 0x074561b4
	System.Void .ctor(UnityEngine.GameObject baseGo, WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType physicsSceneType, System.String path); // 0x07456218
	System.Void InitHitBoxComp(WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType physicsSceneType, System.String path); // 0x0745631c
	System.Void InitHitBoxCompCallBack(WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType physicsSceneType, UnityEngine.GameObject hitBoxGo); // 0x074564dc
	System.Void OnLoaded(); // 0x07456974
	System.Boolean GetHitBoxInfo(); // 0x07456cd0
	System.Void ApplyToHitBox(); // 0x07456d34
	UnityEngine.Vector3 GetPointWithHitBox(UnityEngine.Vector3 localPosition); // 0x07457050
	UnityEngine.Vector3 GetLocalPointWithHitBox(UnityEngine.Vector3 position); // 0x07457190
	UnityEngine.Vector3 GetDirectionWithHitBoxByLocalSpace(UnityEngine.Vector3 localDirection); // 0x074572d0
	UnityEngine.Vector3 GetLocalSpaceDirectionWithHitBoxByWorldSpace(UnityEngine.Vector3 direction); // 0x07457410
	UnityEngine.GameObject GetBaseChildByName(System.String name); // 0x07457550
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.HitBoxCommonComp : WizardGames.Soc.Common.Unity.Go.BaseHitBoxComp
{
	
	System.Void .ctor(UnityEngine.GameObject baseGo, WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType physicsSceneType, System.String path); // 0x07457600
	System.Boolean GetHitBoxInfo(); // 0x074576a0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.HitBoxUtility : System.Object
{
	static System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType,WizardGames.Soc.Common.Unity.Go.HitBoxUtility.HitGoAddSceneCallback> HitGoAddSceneCallbacks; // 0x0
	static System.Collections.Generic.Dictionary<System.String,System.UInt64> LoadingTaskIds; // 0x8
	static System.Void ClientLoadHitBoxGos(WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType physicsSceneType, System.String path, System.Action<WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType,UnityEngine.GameObject,System.String> callback, WizardGames.Soc.Common.Unity.Go.HitBoxUtility.HitGoAddSceneCallback hitGoAddSceneCallback); // 0x074579a8
	static System.Void AddHitGoAddSceneCallback(WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType physicsSceneType, WizardGames.Soc.Common.Unity.Go.HitBoxUtility.HitGoAddSceneCallback hitGoAddSceneCallback); // 0x07457bf8
	static System.Void .cctor(); // 0x07457da8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.HitBoxUtility.HitGoAddSceneCallback : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x07456414
	System.Void Invoke(WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType physicsSceneType, UnityEngine.GameObject hitBoxGo); // 0x07457e98
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.HitBoxUtility.<>c__DisplayClass3_0 : System.Object
{
	System.String path; // 0x10
	System.Action<WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType,UnityEngine.GameObject,System.String> callback; // 0x18
	WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType physicsSceneType; // 0x20
	WizardGames.Soc.Common.Unity.Go.HitBoxUtility.HitGoAddSceneCallback hitGoAddSceneCallback; // 0x28
	System.Void .ctor(); // 0x07457b90
	System.Void <ClientLoadHitBoxGos>b__0(UnityEngine.GameObject go, System.Object[] param); // 0x07457ef4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.OreConfig : UnityEngine.MonoBehaviour
{
	static SocLogger <log>k__BackingField; // 0x0
	System.Collections.Generic.List<UnityEngine.GameObject> oreStages; // 0x30
	static SocLogger get_log(); // 0x07458118
	System.Void InitStage(System.Int32 stageCount); // 0x074427c8
	System.Void .ctor(); // 0x074581a0
	static System.Void .cctor(); // 0x07458254
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.ClientBaseCarGo : WizardGames.Soc.Common.Unity.Go.BaseCarGo
{
	System.Int64 ctrlPlayerId; // 0x70
	System.Void Clear(); // 0x07458328
	System.Void Remove(); // 0x074588f4
	System.Void .ctor(); // 0x07458964
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.ClientPartGo : WizardGames.Soc.Common.Unity.Go.BasePartGo
{
	CommonUnity.Runtime.Construction.Misc.ConstructionOutline constructionOutline; // 0x70
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x074589cc
	System.Void .ctor(); // 0x07458b0c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo : WizardGames.Soc.Common.Unity.Go.BasePlayerGo, WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemHostGo, UnityEngine.Timeline.IControlPlayableAssetHook
{
	UnityEngine.GameObject <skeletonGo>k__BackingField; // 0x90
	WizardGames.Soc.SocClient.GoLoader.PartModelController PartModelController; // 0x98
	UnityEngine.Light NightVisionLight; // 0xa0
	UnityEngine.Transform <FpCameraLocator>k__BackingField; // 0xa8
	UnityEngine.Transform <NeckBone>k__BackingField; // 0xb0
	System.Boolean FpCrossSwitch; // 0xb8
	System.Boolean ForceUpdateCross; // 0xb9
	UnityEngine.MaterialPropertyBlock block; // 0xc0
	System.Collections.Generic.HashSet<System.Int64> subscribeIDs; // 0xc8
	System.UInt64 proxyHandleId; // 0xd0
	WizardGames.Soc.Common.Unity.Animation.TimelinePlayer <TimelinePlayer>k__BackingField; // 0xd8
	System.Boolean shouldCross; // 0xe0
	System.Action<UnityEngine.Renderer> TryUpdateCrossSwitchRenderCbkAction; // 0xe8
	WizardGames.Soc.SocClient.Player.HeldItem.PlayerHostFpHeldItemGoController <HeldItemGoController>k__BackingField; // 0xf0
	WizardGames.Soc.SocClient.Player.Interactive.PlayerInteractiveFpDisplayController <PlayerInteractiveDisplayController>k__BackingField; // 0xf8
	static WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo CreateClientPlayerFpGo(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x07458b70
	static System.Void DestroyClientPlayerFpGo(WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo entityGo); // 0x07458e44
	static System.Boolean GetEntityAssets(WizardGames.Soc.Common.Entity.PlayerEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x07458cec
	UnityEngine.GameObject get_skeletonGo(); // 0x07459b48
	System.Void set_skeletonGo(UnityEngine.GameObject value); // 0x07459bac
	UnityEngine.Transform get_FpCameraLocator(); // 0x07459c2c
	System.Void set_FpCameraLocator(UnityEngine.Transform value); // 0x07459c90
	UnityEngine.Transform get_NeckBone(); // 0x07459d10
	System.Void set_NeckBone(UnityEngine.Transform value); // 0x07459d74
	WizardGames.Soc.Common.Unity.Animation.TimelinePlayer get_TimelinePlayer(); // 0x07459df4
	System.Void set_TimelinePlayer(WizardGames.Soc.Common.Unity.Animation.TimelinePlayer value); // 0x07459e58
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x07459ed8
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x05523a54
	System.Void InitAnimator(); // 0x0745af74
	System.Void InitPartController(); // 0x0745aacc
	System.Void OnMoveStateChangeAction(System.Int64 entityId, WizardGames.Soc.Common.Entity.PlayerMoveStateEnum oldState, WizardGames.Soc.Common.Entity.PlayerMoveStateEnum newState); // 0x0745b9a4
	System.Void OnNightVisionActive(System.Boolean enable); // 0x0745be7c
	System.Void OnNightVisionLightChange(System.Single intensity); // 0x0745bfc4
	System.Void DoPutOnAction(System.Int64 equipId, System.Int32 position); // 0x0745c098
	System.Void DoTakeOffAction(System.Int64 equipId, System.Int32 position); // 0x0745c29c
	System.Void ReleaseNVL(); // 0x0745c31c
	System.Void UpdateEquips(System.Collections.Generic.List<System.Int64> equips, System.Collections.Generic.Dictionary<System.Int64,System.Int64> skins); // 0x0745c408
	System.Void ShowAllEquips(System.Boolean show); // 0x0745c4a8
	System.Void SetVisible(System.Boolean show); // 0x0745b7d0
	System.Void OnFpEquipChange(System.Int64 id, System.Boolean on); // 0x0745c540
	System.Void SetPosition(UnityEngine.Vector3 pos); // 0x0745c5c4
	System.Void SetRotation(UnityEngine.Quaternion quaternion); // 0x0745c75c
	System.Void SetLocalPosition(UnityEngine.Vector3 pos); // 0x0745c900
	System.Void SetLocalEulerAngles(UnityEngine.Vector3 euler); // 0x0745cb58
	System.Void SetLocalScale(UnityEngine.Vector3 scale); // 0x0745ccf0
	UnityEngine.Vector3 GetLocalScale(); // 0x0745ce88
	System.Void SetGoVisible(System.Boolean visible); // 0x074587f8
	System.Void Update(); // 0x0745d014
	System.Void UpdateSMBLogicParams(); // 0x0745d0e8
	System.Void LateUpdate(System.Single dt); // 0x0745d5a4
	System.Void TryUpdateCrossSwitchRenderCbk(UnityEngine.Renderer rd); // 0x0745dcb8
	System.Void TryUpdateCrossSwitch(); // 0x0745d61c
	System.Void OnMountableIdChanged(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x0745ddb0
	System.Void Clear(); // 0x055049cc
	System.Void Remove(); // 0x0745de88
	WizardGames.Soc.SocClient.Player.HeldItem.PlayerHostFpHeldItemGoController get_HeldItemGoController(); // 0x0745def4
	System.Void set_HeldItemGoController(WizardGames.Soc.SocClient.Player.HeldItem.PlayerHostFpHeldItemGoController value); // 0x0745df58
	WizardGames.Soc.Common.Entity.IEntity get_HostEntity(); // 0x0745dfd8
	WizardGames.Soc.Common.Entity.IBaseMountableEntity get_MountableEntity(); // 0x0745d45c
	WizardGames.Soc.Common.Entity.IHeldItemEntity GetHeldItemEntity(System.Int64 entityID); // 0x0745e070
	System.Void StartSwitchHeldItem(WizardGames.Soc.Common.Entity.IHeldItemEntity entity); // 0x0745e13c
	System.Void OnHeldItemDeploy(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo heldItem); // 0x05523a54
	System.Void OnHeldItemHolster(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo heldItem); // 0x0745f568
	System.Boolean TryGetHeldItemGo<T>(System.Int64 entityID, T& heldItemGo); // 0x052af1f0
	System.Boolean TryGetCurrentHeldItemGo<T>(T& heldItemGo); // 0x052af1f0
	WizardGames.Soc.SocClient.Player.Interactive.PlayerInteractiveFpDisplayController get_PlayerInteractiveDisplayController(); // 0x0745f5dc
	System.Void set_PlayerInteractiveDisplayController(WizardGames.Soc.SocClient.Player.Interactive.PlayerInteractiveFpDisplayController value); // 0x0745f640
	System.Void RefreshSMB(WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerHeldItemGo heldItemGo); // 0x0745eca4
	System.Boolean TryGetOverrideSourceGameObject(UnityEngine.Timeline.ControlPlayableAsset asset, UnityEngine.Transform& obj); // 0x0745f6c0
	System.Void .ctor(); // 0x0745f7a0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.ClientPlayerGo : WizardGames.Soc.Common.Unity.Go.BasePlayerGo, WizardGames.Soc.Common.Unity.Go.IMoveColliderGo, WizardGames.Soc.Common.Unity.Go.IEquipOwnerGo, WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemHostGo, UnityEngine.Timeline.IControlPlayableAssetHook
{
	WizardGames.Soc.Common.Unity.Animation.AnimTransformHandle ViewGoHandle; // 0x90
	WizardGames.Soc.SocClient.GoLoader.BackWeaponMgr BackWeaponMgr; // 0xb0
	System.Boolean <IsMaster>k__BackingField; // 0xb8
	UnityEngine.GameObject <ColliderGo>k__BackingField; // 0xc0
	UnityEngine.Transform <ColliderTransform>k__BackingField; // 0xc8
	WizardGames.Soc.Common.Unity.Utility.SocAnimOptimizationType current_anim_optimize_type; // 0xd0
	UnityEngine.Transform HeadBone; // 0xd8
	UnityEngine.Transform BodyBone; // 0xe0
	UnityEngine.Transform SpineBone; // 0xe8
	UnityEngine.Transform LeftFootBone; // 0xf0
	UnityEngine.Transform RightFootBone; // 0xf8
	UnityEngine.Transform Bip01Neck; // 0x100
	WizardGames.Soc.Common.Entity.PlayerEntity ServerPlayerEntity; // 0x108
	WizardGames.Soc.SocClient.GoLoader.PartModelController PartModelController; // 0x110
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Syncronization.WearEquipChange.IWearEquipHandler> wearEquipHandler; // 0x118
	System.Collections.Generic.List<WizardGames.Soc.Common.Syncronization.WearEquipChange.IWearEquipHandler> activeEquipHandlers; // 0x120
	UnityEngine.Light NightVisionLight; // 0x128
	System.Int64 logicStateSubscribeId; // 0x130
	System.Int64 mountableTypeSubscribeId; // 0x138
	WizardGames.Soc.Common.Unity.Character.SocCharacterController SocCharacterController; // 0x140
	UnityEngine.Collider PreventBuilding; // 0x148
	System.Boolean oldIsObserverLoading; // 0x150
	WizardGames.Soc.SocClient.GoLoader.PlayerTpRelativeFunctionMgr <TpRelativeFunctionMgr>k__BackingField; // 0x158
	WizardGames.Soc.SocClient.GoLoader.PlayerSwimRipplingFx playerSwimRipplingFx; // 0x160
	Go.PureGo.PureGoItem _card; // 0x168
	WizardGames.Soc.Common.Unity.Entity.IdHolder IdHolder; // 0x170
	System.Int64 posChangeEventHandle; // 0x178
	System.Collections.Generic.HashSet<System.Int64> subscribeIDs; // 0x180
	System.Int64 tempSubscribeId; // 0x188
	RootMotion.FinalIK.LookAtIK LookAtIK; // 0x190
	RootMotion.FinalIK.LookAtController LookAtController; // 0x198
	UnityEngine.GameObject LittleEyeLookAtGo; // 0x1a0
	UnityEngine.Vector3 LittleEyeGoInitPos; // 0x1a8
	System.Single LittleEyeGoYaw; // 0x1b4
	System.Single LittleEyeGoPitch; // 0x1b8
	System.Boolean isUsed; // 0x1bc
	System.Boolean isFirstLoaded; // 0x1bd
	System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip,UnityEngine.AnimationClip>> Overrides; // 0x1c0
	static System.String BasicPoseName = "basic_stand_hip_pose";
	WizardGames.Soc.Common.Unity.Animation.TimelinePlayer <TimelinePlayer>k__BackingField; // 0x1c8
	System.Int64 subscribe2; // 0x1d0
	System.Int32 _lastFrame; // 0x1d8
	System.Boolean needUpdateLittleEyeGoPos; // 0x1dc
	System.Int32 <ColliderLod>k__BackingField; // 0x1e0
	System.Boolean <ColliderDirty>k__BackingField; // 0x1e4
	System.Boolean PrintLog; // 0x1e5
	WizardGames.Soc.SocClient.Player.Interactive.PlayerInteractiveTpDisplayController <PlayerInteractiveDisplayController>k__BackingField; // 0x1e8
	WizardGames.Soc.SocClient.Player.HeldItem.PlayerHostHeldItemGoController <HostHeldItemGoController>k__BackingField; // 0x1f0
	System.Int32 cacheLoopPlayAudioSyncSmbInsId; // 0x1f8
	System.Single[] cachePlayAudioTimes; // 0x200
	System.Single cachePrePlayAudioTime; // 0x208
	System.Int32 cachePrePlayAudioTimeIndex; // 0x20c
	System.Boolean localBlockedState; // 0x210
	System.Boolean tpHeldItemAabbInited; // 0x211
	UnityEngine.SkinnedMeshRenderer tpHeldItemMainSmr; // 0x218
	System.Collections.Generic.List<UnityEngine.Vector3> tpHeldItemWorldPoints; // 0x220
	System.Collections.Generic.HashSet<System.Int64> ccSubscribeIDs; // 0x228
	System.Int64 mantleTimerId; // 0x230
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.PlayerEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x0745fc9c
	System.Boolean get_IsMaster(); // 0x0745fe90
	System.Void set_IsMaster(System.Boolean value); // 0x0745fef4
	UnityEngine.GameObject get_ColliderGo(); // 0x0745ff70
	System.Void set_ColliderGo(UnityEngine.GameObject value); // 0x0745ffd4
	UnityEngine.Transform get_ColliderTransform(); // 0x07460054
	System.Void set_ColliderTransform(UnityEngine.Transform value); // 0x074600b8
	System.Boolean get_Visible(); // 0x07460138
	WizardGames.Soc.SocClient.GoLoader.PlayerTpRelativeFunctionMgr get_TpRelativeFunctionMgr(); // 0x074603d0
	System.Void set_TpRelativeFunctionMgr(WizardGames.Soc.SocClient.GoLoader.PlayerTpRelativeFunctionMgr value); // 0x07460434
	System.Boolean get_colliderPosFollowModel(); // 0x074604b4
	WizardGames.Soc.Common.Unity.Animation.TimelinePlayer get_TimelinePlayer(); // 0x07460644
	System.Void set_TimelinePlayer(WizardGames.Soc.Common.Unity.Animation.TimelinePlayer value); // 0x074606a8
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x07460728
	System.Void SetMainGo(UnityEngine.GameObject mainGo, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x074608bc
	System.Void SetGo(UnityEngine.GameObject mainGo); // 0x074619a8
	System.Void AfterMyGoCreated(); // 0x07465920
	System.Void AfterOtherGoCreated(); // 0x07465e2c
	System.Void OnPlatformIdChanged(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int64 oldVal, System.Int64 newVal); // 0x0746793c
	System.Void InitEvent(); // 0x07464c0c
	System.Void OnCustomizeChange(WizardGames.Soc.Share.Framework.CustomTypeBase custom, System.Int32 oldValue, System.Int32 newValue); // 0x07467c14
	System.Void OnSexChange(WizardGames.Soc.Share.Framework.CustomTypeBase custom, System.Int32 oldValue, System.Int32 newValue); // 0x07467e54
	System.Void OnOtherSexChange(WizardGames.Soc.Share.Framework.CustomTypeBase custom, System.Int32 oldValue, System.Int32 newValue); // 0x07468204
	System.Void OnFaceIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase custom, System.Int32 oldValue, System.Int32 newValue); // 0x074682f8
	System.Void OnHairIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase custom, System.Int32 oldValue, System.Int32 newValue); // 0x07468440
	System.Void OnHairColorIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase custom, System.Int32 oldValue, System.Int32 newValue); // 0x07468588
	System.Void RefreshCustomize(); // 0x07467d00
	System.Void Remove(); // 0x074686d0
	System.Void OnPosChangeCallback(WizardGames.Soc.Share.Framework.PositionChangeEvent e); // 0x07469d28
	System.Void SetPreventBuildingEnabled(); // 0x074665bc
	System.Boolean TryGetGoByName(System.String GoName, UnityEngine.Transform& obj); // 0x0746a0dc
	System.Void GenerateBoneMap(); // 0x07466734
	System.Void TryAddAudioComponent(WizardGames.Soc.Common.Entity.IEntity entity, System.Boolean isFp); // 0x07464b20
	System.Void ChangeSexAudioState(); // 0x07467fa4
	System.Void InitPartController(); // 0x0746220c
	System.Void InitAnimator(System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x07462c04
	System.Void ReTargetEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x0746a4cc
	System.Void UpdatePosition(); // 0x0746a580
	UnityEngine.Vector3 CalcRelativePos(System.Single offset, UnityEngine.Transform trans, UnityEngine.Vector3 relativeVec); // 0x0746b694
	System.Void UpdateCollider(); // 0x07463d24
	System.Void OnObserverChanged(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x0746b7ec
	System.Void OnMoveStateChanged(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Common.Entity.PlayerMoveStateEnum oldMoveStateEnum, WizardGames.Soc.Common.Entity.PlayerMoveStateEnum newMoveStateEnum); // 0x0746bc40
	System.Void OnObserverLoadingFinishTimeChanged(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x0746bf3c
	System.Void UpdateOtherPlayerObserver(); // 0x0746afa4
	System.Void PostShowAction(System.Boolean show); // 0x0746c2b4
	System.Void SetVisible(System.Boolean show); // 0x0746c484
	System.Void DeathAnimRotate(WizardGames.Soc.Common.Entity.PlayerEntity entity, UnityEngine.Transform tpGoTransform); // 0x0746adec
	System.Void ShowAllEquips(System.Boolean show); // 0x0746c524
	System.Void UpdateEquips(System.Collections.Generic.List<System.Int64> equips, System.Collections.Generic.Dictionary<System.Int64,System.Int64> skins); // 0x0746c5bc
	System.Void UpdateCullingMode(); // 0x0746a280
	System.Void DoPutOnAction(System.Int64 equipId, System.Int32 position); // 0x0746c744
	System.Void DoTakeOffAction(System.Int64 equipId, System.Int32 position); // 0x0746cb90
	System.Void OnPartModelLoadFinished(UnityEngine.GameObject go); // 0x0746cf00
	System.Void DoChangeSameEquipAction(System.Int64 equipId); // 0x0746d05c
	System.Void OnUIModelShow(System.Boolean show); // 0x0746d180
	System.Void CameraChangeState(WizardGames.Soc.Common.Unity.CameraState lastCameraState, WizardGames.Soc.Common.Unity.CameraState nowCameraState); // 0x0746d340
	System.Void OnNightVisionActive(System.Boolean enable); // 0x0746d5ac
	System.Void OnNightVisionLightChange(System.Single intensity); // 0x0746d744
	System.Void ReleaseNVL(); // 0x0746cdd8
	System.Void Update(); // 0x055049cc
	System.Void UpdateSMBLogicParams(); // 0x0746de74
	System.Void OnLateUpdate(); // 0x055049cc
	System.Void OnCharacterStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte oldValue, System.Byte newValue); // 0x07466cb0
	System.Void OnMoveStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte oldValue, System.Byte newValue); // 0x07466f04
	System.Void OnCommonStateRecoveryChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 o, System.Int32 n); // 0x0746ec10
	System.Void OnMountableIdChanged(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x0746f038
	System.Void OnFlagsChanged(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x05525bf4
	System.Void GenerateCard(System.Int32 cardTableId); // 0x0746f4c0
	System.Void ReleaseCard(); // 0x0746f644
	System.Void InitLookAtIk(); // 0x074646cc
	System.Void InitLittleEyeGoPos(UnityEngine.Vector3 forward); // 0x0746f6c0
	System.Void SetLittleEyePos(UnityEngine.Vector3 orientation, UnityEngine.Vector3 initOffset, System.Single eyePitch, System.Single eyeYaw, System.Single dt); // 0x0746f938
	System.Void SetLittleEyePos(System.Single pitch, System.Single yaw, System.Single dt); // 0x074700d0
	System.Void SendNowLittleEyeGoCmd(System.Boolean sendZero); // 0x074706b0
	System.Void LittleEyeGoCmd(UnityEngine.Vector3 pos); // 0x0746f860
	System.Void OnLittleEyeGoPosChanged(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x07470784
	System.Void UpdateLittleEyeGoPosition(); // 0x0746e860
	System.Void CloseLittleEyeGo(); // 0x0747083c
	System.Void Clear(); // 0x07468740
	System.Void set_ColliderDirty(System.Boolean value); // 0x07470d78
	System.Void UpdateCollider(System.Int32 lod); // 0x07470df4
	WizardGames.Soc.SocClient.Player.Interactive.PlayerInteractiveTpDisplayController get_PlayerInteractiveDisplayController(); // 0x07470e6c
	System.Void set_PlayerInteractiveDisplayController(WizardGames.Soc.SocClient.Player.Interactive.PlayerInteractiveTpDisplayController value); // 0x07470ed0
	WizardGames.Soc.SocClient.Player.HeldItem.PlayerHostHeldItemGoController get_HostHeldItemGoController(); // 0x07470f50
	System.Void set_HostHeldItemGoController(WizardGames.Soc.SocClient.Player.HeldItem.PlayerHostHeldItemGoController value); // 0x07470fb4
	WizardGames.Soc.Common.Entity.IEntity get_HostEntity(); // 0x07471034
	WizardGames.Soc.Common.Entity.IBaseMountableEntity get_MountableEntity(); // 0x0746e220
	WizardGames.Soc.Common.Entity.IHeldItemEntity GetHeldItemEntity(System.Int64 entityID); // 0x074710cc
	System.Void StartSwitchHeldItem(WizardGames.Soc.Common.Entity.IHeldItemEntity entity); // 0x07471198
	System.Void OnHeldItemDeploy(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo heldItem); // 0x05523a54
	System.Void OnHeldItemHolster(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo heldItem); // 0x07471e84
	System.Void RecordSMBAnimData(); // 0x07471ff0
	System.Boolean TryGetHeldItemGo<T>(System.Int64 entityID, T& heldItemGo); // 0x052af1f0
	System.Boolean TryGetCurrentHeldItemGo<T>(T& heldItemGo); // 0x052af1f0
	System.Void RefreshSMB(WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerHeldItemGo heldItemGo); // 0x07471db0
	WizardGames.Soc.Common.Unity.Animation.SMBAnimData LoadSmb(WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerHeldItemGo heldItemGo); // 0x07472180
	System.Void RefreshSMB(WizardGames.Soc.Common.Unity.Animation.SMBAnimData smbAnimData, WizardGames.Soc.Common.Unity.Character.CharacterConfig PlayerConfig, WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerHeldItemGo heldItemGo); // 0x07472574
	System.Void SetAnimatorEnable(System.Boolean enable); // 0x07470994
	System.Collections.Generic.List<UnityEngine.Vector3> GetPossibleLeftRightVectors(); // 0x07472f00
	System.Boolean TryGetOverrideSourceGameObject(UnityEngine.Timeline.ControlPlayableAsset asset, UnityEngine.Transform& obj); // 0x0747362c
	System.Void RegisterEvent(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x074676e8
	System.Void UnRegisterEvent(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x07470bcc
	System.Void OnCcPoseStateChanged(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Common.Entity.PlayerPoseStateEnum oldMoveStateEnum, WizardGames.Soc.Common.Entity.PlayerPoseStateEnum newMoveStateEnum); // 0x0747370c
	System.Void OnCcMoveStateChanged(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Common.Entity.PlayerMoveStateEnum oldMoveStateEnum, WizardGames.Soc.Common.Entity.PlayerMoveStateEnum newMoveStateEnum); // 0x0746755c
	System.Void .ctor(); // 0x0747382c
	System.Void <GetPossibleLeftRightVectors>g__InitMainSkinnedMesh|173_0(); // 0x07473338
	System.Void <OnCcMoveStateChanged>b__180_0(System.Int64 id, System.Object data, System.Boolean delete); // 0x07473a78
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.ClientPlayerGo.<>c : System.Object
{
	static WizardGames.Soc.Common.Unity.Go.ClientPlayerGo.<>c <>9; // 0x0
	static System.Predicate<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip,UnityEngine.AnimationClip>> <>9__88_0; // 0x8
	static System.Void .cctor(); // 0x07473b18
	System.Void .ctor(); // 0x07473b7c
	System.Boolean <UpdatePosition>b__88_0(System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip,UnityEngine.AnimationClip> x); // 0x07473be4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.ClientHitBoxHorseComp : WizardGames.Soc.Common.Unity.Go.BaseHitBoxComp
{
	
	System.Void .ctor(UnityEngine.GameObject baseGo, WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType physicsSceneType, System.String path); // 0x07473c9c
	System.Boolean GetHitBoxInfo(); // 0x07473d40
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.ClientHitBoxScientistComp : WizardGames.Soc.Common.Unity.Go.BaseHitBoxComp
{
	
	System.Void .ctor(UnityEngine.GameObject baseGo, WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType physicsSceneType, System.String path, System.Int64 eid); // 0x074743d8
	System.Boolean GetHitBoxInfo(); // 0x07474484
	System.Void OnLoaded(); // 0x074747cc
	System.Void ApplyToHitBox(); // 0x07474b68
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.ClientHitBoxTpComp : WizardGames.Soc.Common.Unity.Go.BaseHitBoxComp
{
	
	System.Void .ctor(UnityEngine.GameObject baseGo, WizardGames.Soc.Common.Syncronization.PhysicsSceneEntityType physicsSceneType, System.String path, System.Int64 eid); // 0x0746a420
	System.Boolean GetHitBoxInfo(); // 0x07474e84
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.ClientSocHorseGo : WizardGames.Soc.Common.Unity.Go.BaseSocHorseGo, WizardGames.Soc.Common.Unity.Go.IEquipOwnerGo
{
	WizardGames.Soc.Common.Entity.HorseEntity ServerEntity; // 0x198
	UnityEngine.Animator Animator; // 0x1a0
	UnityEngine.Transform LeftFootIK; // 0x1a8
	UnityEngine.Transform RightFootIK; // 0x1b0
	UnityEngine.Transform PassengerLeftFootIK; // 0x1b8
	UnityEngine.Transform PassengerRightFootIK; // 0x1c0
	UnityEngine.GameObject RenderGo; // 0x1c8
	UnityEngine.GameObject AnimatorGo; // 0x1d0
	UnityEngine.Transform LeftIkEffect; // 0x1d8
	UnityEngine.Transform RightIkEffect; // 0x1e0
	WizardGames.Soc.SocClient.Go.VehicleTrigger vehicleTrigger; // 0x1e8
	WizardGames.Soc.SocClient.Audio.HorseAnimationEvent horseAnimationEvent; // 0x1f0
	System.Collections.Generic.List<UnityEngine.SkinnedMeshRenderer> hairRenderers; // 0x1f8
	WizardGames.Soc.SocClient.GoLoader.PartModelController PartModelController; // 0x200
	System.Collections.Generic.List<System.Int64> equipTableIds; // 0x208
	System.Collections.Generic.List<System.Int64> damageCompSubscribeId; // 0x210
	WizardGames.Soc.Common.Unity.Horse.IK.HorseAniLateJob JobLateUpdate; // 0x218
	UnityEngine.Playables.PlayableGraph LateGraph; // 0x250
	UnityEngine.Animations.AnimationScriptPlayable LatePlayable; // 0x260
	WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent <RenderObjectPoint>k__BackingField; // 0x270
	WizardGames.Soc.Common.Unity.Go.ClientHitBoxHorseComp hitBoxHorseComp; // 0x278
	System.UInt64 breedSkinLoadTask; // 0x280
	System.Collections.Generic.List<WizardGames.AssetPool.AssetPoolHandle> breedSkinHandles; // 0x288
	WizardGames.Soc.Common.Entity.IEntity get_GetEntity(); // 0x074751cc
	WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent get_RenderObjectPoint(); // 0x07475230
	System.Void set_RenderObjectPoint(WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent value); // 0x07475294
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x07475314
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x0552af00
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.IBaseMountableEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x07476944
	System.Void SetMainGo(UnityEngine.GameObject mainGo, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x07475908
	System.Void InitAnimator(UnityEngine.RuntimeAnimatorController controller); // 0x07476de4
	System.Void OnAfterInit(); // 0x055049cc
	System.Void SetEnable(System.Boolean enable); // 0x07477854
	System.Void Remove(); // 0x074778f8
	System.Void Clear(); // 0x07477968
	System.Void AddFieldChangeListen(); // 0x055049cc
	System.Void OnStartJump(WizardGames.Soc.Common.Entity.HorseEntity horseEntity); // 0x074788a8
	System.Void OnDriverIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x07478798
	System.Void RemoveFieldChangeListen(); // 0x055049cc
	System.Void OnMaxHpChange(WizardGames.Soc.Common.Component.DamageableComponent server, System.Single oldValue, System.Single newValue, WizardGames.Soc.Common.Component.DamageableComponent local); // 0x0747905c
	System.Void OnHpChange(WizardGames.Soc.Common.Component.DamageableComponent server, System.Single oldHp, System.Single nowHp, WizardGames.Soc.Common.Component.DamageableComponent local); // 0x07479108
	System.Void OnSeat12IdChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x05527160
	System.Boolean CanVehicleStorageInteractive(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x074792dc
	System.Void UnlimitedUpdate(System.Int32 deltaTime); // 0x07479354
	System.String GetMountableDisplayName(); // 0x07479430
	WizardGames.Soc.Common.Unity.Go.MountableAuthoritySide GetAuthoritySide(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x07479564
	System.Void ClientBreedSkinInit(); // 0x07477348
	System.Void OnBreedSkinLoadFinish(System.UInt64 loaderId, Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.AssetPool.AssetGroupData> results); // 0x07479690
	System.Void UpdateEquips(System.Collections.Generic.List<System.Int64> curEquipTableIds, System.Collections.Generic.Dictionary<System.Int64,System.Int64> skins); // 0x07476b68
	UnityEngine.Quaternion GetMountRotation(System.Int32 index); // 0x07479b84
	System.Boolean ApplyMountRotation(); // 0x07479cc0
	UnityEngine.Vector3 GetMountPos(System.Int32 index); // 0x07479d24
	System.Void UpdateCmd(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd, WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x07479df8
	System.Void BuildJob(System.Int64 entityId, UnityEngine.Animator animator); // 0x07476ff8
	System.Void BuildHitBox(WizardGames.Soc.Common.Unity.Go.BaseHitBoxComp hitBoxComp); // 0x07474074
	System.Void .ctor(); // 0x0747a168
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.ClientSocHorseGo.<>c__DisplayClass37_0 : System.Object
{
	WizardGames.Soc.Common.Unity.Go.ClientSocHorseGo <>4__this; // 0x10
	WizardGames.Soc.Common.Entity.IHitableEntity hitable; // 0x18
	WizardGames.Soc.Common.Component.DamageableComponent damageable; // 0x20
	System.Void .ctor(); // 0x07478730
	System.Void <AddFieldChangeListen>b__0(WizardGames.Soc.Share.Framework.CustomTypeBase server, System.Single oldValue, System.Single newValue); // 0x0747a340
	System.Void <AddFieldChangeListen>b__1(WizardGames.Soc.Share.Framework.CustomTypeBase server, System.Single oldValue, System.Single newValue); // 0x0747a438
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Go.MonumentGo : WizardGames.Soc.Common.Unity.Go.BaseMonumentGo
{
	static SocLogger <log>k__BackingField; // 0x0
	WizardGames.Soc.Common.Data.units.MonumentTemplateID MonumentTemplateID; // 0x70
	System.Collections.Generic.List<WizardGames.Soc.Procedural.BiomeFit> _biomeFits; // 0x78
	System.Int64 _transformSubId; // 0x80
	static SocLogger get_log(); // 0x0747a530
	static System.Void GetEntityAssets(WizardGames.Soc.Common.Entity.MonumentEntity entity, WizardGames.Soc.Common.Unity.GoLoader.EntityGoCreator& creator); // 0x0747a5b8
	System.Void Spawn(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.ObjPool.EntityAsset> assets); // 0x0747a830
	System.Void OnInit(WizardGames.Soc.Common.Entity.IEntity entity, UnityEngine.GameObject root); // 0x0747a9b8
	System.Void SetMainGo(UnityEngine.GameObject mainGo); // 0x0747aad4
	System.Void OnTransformChange(WizardGames.Soc.Share.Framework.PositionChangeEvent obj); // 0x0747af78
	System.Void PostProcess(); // 0x0747b0c8
	System.Void Remove(); // 0x0747b27c
	System.Void Clear(); // 0x0747b6e8
	System.Void ReturnEffect(); // 0x0747b510
	System.Void .ctor(); // 0x0747b7a0
	static System.Void .cctor(); // 0x0747b854
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Effect.EffectHideObjData : System.ValueType
{
	UnityEngine.GameObject hideObj; // 0x10
	System.Boolean originalShowState; // 0x18
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Effect.EffectProfile : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	SerializableDictionary<UnityEngine.ParticleSystem,WizardGames.Soc.Common.Unity.Effect.ParticleSystemState> particleSystemStateDictionary; // 0x30
	System.Collections.Generic.List<UnityEngine.ParticleSystem> particleList; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Effect.ParticleSystemState> particleSystemStates; // 0x40
	UnityEngine.Transform vfxTransform; // 0x48
	UnityEngine.Bounds bounds; // 0x50
	UnityEngine.LineRenderer lineRenderer; // 0x68
	UnityEngine.TrailRenderer trailRenderer; // 0x70
	System.Boolean isProceduralEffect; // 0x78
	System.Int32 liveTime; // 0x7c
	System.Int32 curLODLevel; // 0x80
	UnityEngine.Rendering.Universal.OcclusionCulling.OcclusionCullingRegister ocRegister; // 0x88
	System.Boolean isFollowEffect; // 0x90
	System.Boolean isDecal; // 0x91
	System.Boolean canBoundsUpdate; // 0x92
	System.Boolean isVisible; // 0x93
	System.Collections.Generic.Dictionary<UnityEngine.ParticleSystem,UnityEngine.ParticleSystem.MinMaxCurve> particleOriginLifeTime; // 0x98
	System.Boolean useLODGroupDistance; // 0xa0
	System.Single lodGroupScreenPercentages; // 0xa4
	System.Boolean LODModule; // 0xa8
	WizardGames.Soc.Common.Unity.Effect.LODEffectGroup lodEffectGroup; // 0xb0
	System.Int32 lodBias; // 0xb8
	System.Boolean DissipateModule; // 0xbc
	System.Collections.Generic.List<UnityEngine.ParticleSystem> noDissipateParticles; // 0xc0
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Effect.PSDissipateData> particleDissipateData; // 0xc8
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Effect.EffectHideObjData> mHideObjs; // 0xd0
	System.Single dissipateTime; // 0xd8
	System.Collections.Generic.List<UnityEngine.ParticleSystem> fadeParticles; // 0xe0
	System.Collections.Generic.List<UnityEngine.Rendering.Universal.DecalProjector> fadeoutDecalProjectors; // 0xe8
	System.Single fadeinTime; // 0xf0
	System.Single fadeoutTime; // 0xf4
	System.Boolean RateOverLODModule; // 0xf8
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Effect.ParticleSystemLODItem> PSlodItemList; // 0x100
	System.Boolean UseSkipFrameUpdateEffect; // 0x108
	System.Boolean bindSkipFrameWithLod; // 0x109
	System.Int32 skipUpdateFrame; // 0x10c
	System.Boolean refreshInEditor; // 0x110
	System.Int32 get_CurLODLevel(); // 0x0747b928
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Effect.LODEffect> get_lodList(); // 0x0747b98c
	System.Void Awake(); // 0x0747b9fc
	System.Void OnEnable(); // 0x0747bc30
	System.Void OnDisable(); // 0x0747bce0
	System.Void Play(System.Int32 lodLevel); // 0x0747bd90
	System.Void Pause(); // 0x0747cdb0
	System.Int32 GetParticleSystemCount(System.Int32 wantLodLevel); // 0x0747d0cc
	System.Int32 GetGoCount(System.Int32 wantLodLevel); // 0x0747d1c4
	System.Int32 GetLiveTime(); // 0x0747d2bc
	System.Void ShowOrHideEffect(System.Boolean visible); // 0x0747d320
	System.Void SetLayer(System.Int32 layer); // 0x0747d4ac
	System.Void SetEffectType(System.Boolean followEffect, System.Boolean decalEffect); // 0x0747d660
	System.Void SetSimulationSpeed(System.Single speed); // 0x0747d6ec
	System.Void SetPSPrewarm(System.Boolean value); // 0x0747d8a0
	UnityEngine.Transform FindChildRecursion(UnityEngine.Transform root, System.String name); // 0x0747da54
	System.Void RefreshPS(); // 0x0747dbb4
	System.Void SetParticleLifeTime(UnityEngine.ParticleSystem particle, System.Single deltaTime); // 0x0747cbdc
	System.Void RecordParticleLifeTime(UnityEngine.ParticleSystem ps, UnityEngine.ParticleSystem.MinMaxCurve lifeTimeCurve); // 0x0747e0d0
	System.Void RecoverParticleLiftTime(UnityEngine.ParticleSystem ps); // 0x0747dfc0
	System.Void RefreshBasicModule(); // 0x0747e1f8
	System.Void SetEffectLODLevel(System.Int32 lodLevel); // 0x0747f350
	System.Void ResetLodState(System.Int32 newLodLevel, System.Single deltaTime, System.Single nowTime); // 0x0747caa0
	System.Void UpdateLodState(); // 0x0747d3a0
	System.Void SyncMaxShowDistance(UnityEngine.LODGroup[] lodGroup); // 0x0747f3e0
	System.Void ClearLODGroupDistance(); // 0x0747f530
	System.Single GetMinScreenPercentages(); // 0x0747f594
	System.Int32 CalLodLevel(System.Single screenPercentage); // 0x0747f684
	System.Void UpdateLodObjectSize(); // 0x0747f7bc
	System.Void RefreshLOD(); // 0x0747e7bc
	System.Void AddLodEffect(UnityEngine.Transform lodTransform, System.Single distance); // 0x0747f8c4
	System.Void UpdatePSEmissionLOD(); // 0x0747c6d4
	System.Void UpdatePSEmissionLODDissipate(System.Single time); // 0x0747fde8
	System.Void RefreshParticleDissipate(); // 0x0748001c
	System.Void RecordParticleEmissionOriginData(); // 0x0747ef5c
	System.Void RefreshRateOverLODModule(); // 0x0747f0cc
	System.Void RecordSingleParticleDissipateData(UnityEngine.ParticleSystem ps); // 0x07480390
	System.Void ResetDissipateData(); // 0x0748125c
	System.Void OnDissipateModuleChanged(); // 0x07481640
	System.Void StartDissipate(); // 0x074816d4
	System.Void GenerateHideGameObjectData(); // 0x07480b84
	System.Void SetGameObjectShowHideState(UnityEngine.GameObject obj, System.Collections.Generic.List<UnityEngine.GameObject> dissipateObjs, System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Collections.Generic.List<UnityEngine.GameObject>> parentInfoDic); // 0x07481b74
	System.Collections.Generic.List<UnityEngine.GameObject> GetObjParentData(UnityEngine.GameObject obj); // 0x07481994
	System.Boolean CheckOCVisable(); // 0x07481ed4
	System.Void ResetAABB(); // 0x0747c15c
	static System.Void DecomposeMatrix(UnityEngine.Matrix4x4 m, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation, UnityEngine.Vector3& scale); // 0x07481f84
	System.Boolean NeedUpdateBounds(); // 0x07482270
	System.Void UpdateBounds(); // 0x074822e4
	System.Void UpdateDissipate(System.Single progress); // 0x07482464
	System.Boolean HasFadeInPS(); // 0x0747c414
	System.Void UpdateFadePS(System.Single progress); // 0x0747c490
	System.Void OnDrawGizmosSelected(); // 0x074826a8
	System.Void Clear(); // 0x07482850
	System.Void OnDestroy(); // 0x074828b4
	System.Void .ctor(); // 0x07482974
	static System.Void .cctor(); // 0x07482b28
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Effect.EffectProfile.<>c__DisplayClass72_0 : System.Object
{
	UnityEngine.ParticleSystem system; // 0x10
	System.Void .ctor(); // 0x07482c60
	System.Boolean <RefreshParticleDissipate>b__0(WizardGames.Soc.Common.Unity.Effect.PSDissipateData data); // 0x07482cc8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Effect.EffectTransformData : System.Object
{
	System.String parentRootName; // 0x10
	UnityEngine.Transform effectTransform; // 0x18
	UnityEngine.Vector3 localPosition; // 0x20
	UnityEngine.Quaternion localRotation; // 0x2c
	UnityEngine.Vector3 localScale; // 0x3c
	System.Void UpdateTransform(WizardGames.Soc.Common.Unity.Animation.TpEffectParentBoneHandle tpBoneHandle); // 0x07482d7c
	System.Void .ctor(); // 0x07482f58
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Effect.EffectTransformDataCache : UnityEngine.MonoBehaviour
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Effect.EffectTransformData> effectTransformCaches; // 0x30
	System.Void AddEffect(WizardGames.Soc.Common.Unity.Effect.EffectProfile effectProfile); // 0x07482fc0
	System.Void .ctor(); // 0x07483170
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Effect.LODEffect : System.Object
{
	UnityEngine.GameObject lodParent; // 0x10
	System.Single MaxDistance; // 0x18
	System.Single screenPercentages; // 0x1c
	UnityEngine.ParticleSystem[] particleSystems; // 0x20
	UnityEngine.GameObject[] gameObjects; // 0x28
	System.Nullable<System.Boolean> lastLodActive; // 0x30
	System.Nullable<System.Boolean> lastCanShow; // 0x32
	System.Single startTime; // 0x34
	System.Single tmpNowTime; // 0x38
	System.Void DistanceToScreenPercentage(System.Single ObjectSize); // 0x07483224
	System.Void ResetLodState(WizardGames.Soc.Common.Unity.Effect.EffectProfile effectProfile, System.Boolean lodActive, System.Single deltaTime, System.Single nowTime); // 0x074832b4
	System.Void UpdateLodState(WizardGames.Soc.Common.Unity.Effect.EffectProfile effectProfile, System.Boolean lodActive, System.Boolean canShow, System.Single nowTime); // 0x074835bc
	System.Void InitParticleActive(WizardGames.Soc.Common.Unity.Effect.EffectProfile effectProfile, UnityEngine.ParticleSystem particleSystem, System.Boolean active); // 0x07483488
	System.Void UpdateParticle(WizardGames.Soc.Common.Unity.Effect.EffectProfile effectProfile, UnityEngine.ParticleSystem particleSystem, System.Boolean lodActive, System.Boolean canShow); // 0x0748385c
	System.Void UpdateParticleLod(WizardGames.Soc.Common.Unity.Effect.ParticleSystemState particleSystemState, UnityEngine.ParticleSystem particleSystem, System.Boolean lodActive); // 0x07483ae4
	System.Void UpdateParticleShow(WizardGames.Soc.Common.Unity.Effect.ParticleSystemState particleSystemState, UnityEngine.ParticleSystem particleSystem, System.Boolean show); // 0x07483d18
	System.Void .ctor(); // 0x07483ee8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Effect.LODEffectGroup : System.Object
{
	System.Single ObjectSize; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Effect.LODEffect> lodList; // 0x18
	System.Void UpdateLodEffect(); // 0x07483f50
	System.Void .ctor(); // 0x07484010
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Effect.ParticleSystemRateOverItem : System.Object
{
	UnityEngine.ParticleSystem ParticleSystem; // 0x10
	UnityEngine.ParticleSystem.MinMaxCurve RateOverTime; // 0x18
	UnityEngine.ParticleSystem.MinMaxCurve RateOverDistance; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Effect.SerializableBurst> Bursts; // 0x58
	System.Int32 MaxParticles; // 0x60
	System.Void .ctor(); // 0x074840c8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Effect.ParticleSystemLODItem : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Effect.ParticleSystemRateOverItem> PSRateOverItems; // 0x10
	System.Single MaxDistance; // 0x18
	System.Void .ctor(); // 0x07484130
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Effect.CullingMode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Effect.CullingMode PauseAndResume = 0;
	static WizardGames.Soc.Common.Unity.Effect.CullingMode StopAndPlay = 1;
	static WizardGames.Soc.Common.Unity.Effect.CullingMode Stop = 2;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Effect.ParticleSystemState : System.Object
{
	UnityEngine.ParticleSystemRenderer particleSystemRenderer; // 0x10
	WizardGames.Soc.Common.Unity.Effect.CullingMode cullingMode; // 0x18
	System.Void .ctor(); // 0x07484198
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Effect.PSDissipateData : System.Object
{
	System.Boolean enabled; // 0x10
	UnityEngine.ParticleSystem.MinMaxCurve rateOverTime; // 0x18
	System.Single rateOverTimeMultiplier; // 0x38
	UnityEngine.ParticleSystem.MinMaxCurve rateOverDistance; // 0x40
	System.Single rateOverDistanceMultiplier; // 0x60
	System.Int32 burstCount; // 0x64
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Effect.SerializableBurst> bursts; // 0x68
	UnityEngine.ParticleSystem.MinMaxCurve dissipate; // 0x70
	UnityEngine.ParticleSystem.MinMaxCurve dissipateDistance; // 0x90
	UnityEngine.ParticleSystem particle; // 0xb0
	System.Void .ctor(); // 0x07484200
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Effect.SerializableBurst : System.ValueType
{
	System.Single time; // 0x10
	UnityEngine.ParticleSystem.MinMaxCurve count; // 0x18
	System.Int16 minCount; // 0x38
	System.Int16 maxCount; // 0x3a
	System.Int32 cycleCount; // 0x3c
	System.Single repeatInterval; // 0x40
	System.Single probability; // 0x44
	System.Void .ctor(UnityEngine.ParticleSystem.Burst burst); // 0x07484268
	UnityEngine.ParticleSystem.Burst GetBurst(); // 0x0748437c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Effect.SkipFrameUpdateEffect : System.Object
{
	
	static System.Void SetSkipUpdateFrame(UnityEngine.ParticleSystem ps, System.Int32 skipCount); // 0x074839dc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Effect.SuitPropDataCache : UnityEngine.MonoBehaviour
{
	System.Collections.Generic.List<UnityEngine.Transform> effectTransforms; // 0x30
	System.Collections.Generic.List<UnityEngine.Transform> effectRootTransforms; // 0x38
	System.Collections.Generic.List<UnityEngine.Transform> suitPropTransforms; // 0x40
	static SocLogger logger; // 0x0
	System.Void SimpleRefresh(); // 0x07484480
	System.Void Refresh(); // 0x07484840
	System.Void .ctor(); // 0x074849dc
	static System.Void .cctor(); // 0x07484ae4
	System.Boolean <Refresh>b__5_0(UnityEngine.Transform joint); // 0x07484b7c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Extension.ListEx : System.Object
{
	
	static System.Void Remove<T>(Unity.Collections.LowLevel.Unsafe.UnsafeList<T> list, T& element); // 0x052af1f0
	static System.Void AddFastRange<T>(System.Collections.Generic.List<T> list, T[] others); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Extension.Matrix4x4Extension : System.Object
{
	
	static UnityEngine.Vector3 GetForward(UnityEngine.Matrix4x4 matrix); // 0x07484cd4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Extension.QuaternionExtension : System.Object
{
	
	static UnityEngine.Vector3 Froward(UnityEngine.Quaternion q); // 0x07484d58
	static UnityEngine.Vector3 Up(UnityEngine.Quaternion q); // 0x07484e14
	static UnityEngine.Vector3 Right(UnityEngine.Quaternion q); // 0x07484ed0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Extension.SystemVector3Extension : System.Object
{
	
	static UnityEngine.Vector3 ToVector3(System.Numerics.Vector3 sv3); // 0x07484f8c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Extension.TransformExtension : System.Object
{
	
	static System.Void Normalize(UnityEngine.Transform transform); // 0x0748501c
	static System.Void LocalNormalize(UnityEngine.Transform transform); // 0x07485144
	static System.String GetRecursiveName(UnityEngine.Transform transform, System.String strEndName); // 0x0748526c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Extension.Vector3Extension : System.Object
{
	
	static UnityEngine.Vector3 Scale(UnityEngine.Vector3 v, System.Single scale); // 0x074853e4
	static UnityEngine.Vector3 Add(UnityEngine.Vector3 v, UnityEngine.Vector3 add); // 0x07485474
	static System.Numerics.Vector3 ToVector3(UnityEngine.Vector3 uv3); // 0x0748551c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Extend.ComponentEx : System.Object
{
	
	static T[] GetComponentsInChildrenByPool<T>(UnityEngine.Component comp); // 0x052af1f0
	static T[] GetComponentsInChildrenByPool<T>(UnityEngine.Component comp, System.Boolean includeInactive); // 0x052af1f0
	static System.Collections.Generic.List<T> GetComponentListInChildrenByPool<T>(UnityEngine.Component comp); // 0x052af1f0
	static System.Collections.Generic.List<T> GetComponentListInChildrenByPool<T>(UnityEngine.Component comp, System.Boolean includeInactive); // 0x052af1f0
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Event.EventTag : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Event.EventTag Lobby = 0;
	static WizardGames.Soc.Common.Unity.Event.EventTag Game = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Event.EventDefine : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiOpenEvent = 0;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiShowAnimFinishEvent = 1;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LayerOpenEvent = 2;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiHideEvent = 3;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ScreenSizeChange = 4;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LayerHideEvent = 5;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiInventoryAnyUpdate = 6;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiInventoryMainUpdate = 7;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiInventoryBeltUpdate = 8;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiInventoryWearUpdate = 9;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiInventoryOpen = 10;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ChangeBuildMode = 11;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnShopDataChanged = 12;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ConstructionDestroyCurAimPart = 13;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ConstructionCancelSelectUpgradeLevel = 14;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ConstructionSelectToRepair = 15;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ConstructionSelectToPickup = 16;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ConstructionSelectToClearWire = 17;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ConstructionSelectToDestroy = 18;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ConstructionRepairCurAimPart = 19;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ConstructionUpgradeCurAimPart = 20;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ConstructionClearWireAimPart = 21;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ConstructionSelectUpgradeLevel = 22;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ConstructionDoorStateChange = 23;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ConstructionBlueprintCdChange = 24;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BuildPanelSelectChange = 25;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BuildItemCancelSelect = 26;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BuildModeCancelEvent = 27;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiBuildPanelSelectMode = 28;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiBuildPanelSelectTag = 29;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiBuildPanelRecoverState = 30;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiBuildPanelSelectWireTag = 31;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiFoldScreenChange = 32;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiLoginInit = 33;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiLobbyInit = 34;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyPlayerInfoInited = 35;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyLoginFail = 36;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyLoginRetry = 37;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyLoginSuccess = 38;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbySelectServer = 39;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbySdkFinish = 40;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyQueryServerFinish = 41;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TimerReset = 42;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnTLogReportPlayerLoginPrepared = 43;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BuildPopTipAlphaChange = 44;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BuildPanelRefresh = 45;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BuildEditDelete = 46;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BuildDeployMoveFinish = 47;
	static WizardGames.Soc.Common.Unity.Event.EventDefine WireToolWireStateChange = 48;
	static WizardGames.Soc.Common.Unity.Event.EventDefine WireToolPendingSlotRefresh = 49;
	static WizardGames.Soc.Common.Unity.Event.EventDefine WireToolPendingSlotChange = 50;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BuildSkinBatchChange = 51;
	static WizardGames.Soc.Common.Unity.Event.EventDefine SwitchManualWire = 52;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BuildFirstModeChange = 53;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BuildStateSwitchEvent = 54;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BuildModeChange = 55;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BuildPartTransformChange = 56;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PartLastMoveTimeChange = 57;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BuildPieOptionSelect = 58;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BuildPanelRefreshPie = 59;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BuildPieItemDataChange = 60;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BuildHoldItemChange = 61;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BuildPieMenuCloseEvent = 62;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BuildCpWithToolCupboardChange = 63;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PieMenuSelectedAnim = 64;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PieMenuVisibleChange = 65;
	static WizardGames.Soc.Common.Unity.Event.EventDefine HitShowHp = 66;
	static WizardGames.Soc.Common.Unity.Event.EventDefine AimShowHp = 67;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PlayerStateChange = 68;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnMyPlayerDie = 69;
	static WizardGames.Soc.Common.Unity.Event.EventDefine WireToolBuildModeRefreshBatteryInfo = 70;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ProtectionUpdated = 71;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BatchRecoverCostData = 72;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BatchUpgradeConstructionData = 73;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BatchUpgradeConstructionChange = 74;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ShowUpkeepCostInfo = 75;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateResearchComposeInfo = 76;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPlayMemberChange = 77;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnChangePlayCollectionMembers = 78;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ServerStageUpdate = 79;
	static WizardGames.Soc.Common.Unity.Event.EventDefine CloseUiSelectCamp = 80;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RefreshServerListAfterRequest = 81;
	static WizardGames.Soc.Common.Unity.Event.EventDefine CoreConstructionBuildModeClickConstructionType = 82;
	static WizardGames.Soc.Common.Unity.Event.EventDefine CoreBuildUiItemClick = 83;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ClearHoldingConstruction = 84;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ConstructionConfirmBuildOk = 85;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ConstructionCampingTentConfirm = 86;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ConstructionCampingTentCancel = 87;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ConstructionRotateAimPart = 88;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ConstructionChangeSkinOver = 89;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ConstructionSkinChanged = 90;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ConstructionMoveSuc = 91;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BuildItemSelect = 92;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ShowBombHomeTip = 93;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PlayMemberInfoChangeEvent = 94;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PlayerNumChangeEvent = 95;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BombHomeGameOver = 96;
	static WizardGames.Soc.Common.Unity.Event.EventDefine SyncBombHomeTime = 97;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BombHomeCleanup = 98;
	static WizardGames.Soc.Common.Unity.Event.EventDefine HitEntity = 99;
	static WizardGames.Soc.Common.Unity.Event.EventDefine HitEntityPredict = 100;
	static WizardGames.Soc.Common.Unity.Event.EventDefine Damage = 101;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiSelectCableColorUseColor = 102;
	static WizardGames.Soc.Common.Unity.Event.EventDefine DefaultCableColorBySwitchSubMode = 103;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ChangeWireColorAck = 104;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ShowCupboardTip = 105;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiClickInventory = 106;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiHideAllInventoryIcons = 107;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiItemTipsDetailClick = 108;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiPlayerLootUpdate = 109;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiPickableDataChange = 110;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiQuickLootStateChanged = 111;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiQuickLootFinished = 112;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiQuickDropStateChanged = 113;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiQuickMoveStateChanged = 114;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiQuickDropFinished = 115;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiQuickPutOneFinished = 116;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiQuickLootBagFull = 117;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiShowInventoryDropArea = 118;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiItemDragEnd = 119;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiCraftQueueUpdate = 120;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiBlueprintUpdate = 121;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiCraftQueueCancelFail = 122;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UTechTreeNodeStateUpdate = 123;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiClickItemTips = 124;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiClothChoose = 125;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiClothUnChoose = 126;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiItemDragStart = 127;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiItemClick = 128;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiItemDoubleClick = 129;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiPlayerLootOvenUpdate = 130;
	static WizardGames.Soc.Common.Unity.Event.EventDefine AutoTurretModeChange = 131;
	static WizardGames.Soc.Common.Unity.Event.EventDefine AutoTurretSwitchChange = 132;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiPlayerLootDecomposeUpdate = 133;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiPlayerLootDecomposeAnyUpdate = 134;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiPlayerLootDigUpdate = 135;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiPlayerLootComposterStateUpdate = 136;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiPlayerLootComposterAnyUpdate = 137;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ComItemIconChoose = 138;
	static WizardGames.Soc.Common.Unity.Event.EventDefine DoResearchBenchOpenResponse = 139;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnChatRecvMessage = 140;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnChatRecvListMessage = 141;
	static WizardGames.Soc.Common.Unity.Event.EventDefine DeployCampingTentResult = 142;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnRecvTotalMessage = 143;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnChatHudChangeEvent = 144;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnQuickTeamChatSendSuccess = 145;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnQuickNearbyChat = 146;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnSelfRecommendSent = 147;
	static WizardGames.Soc.Common.Unity.Event.EventDefine QuickBubbleReturnPool = 148;
	static WizardGames.Soc.Common.Unity.Event.EventDefine SwitchTeamInfo = 149;
	static WizardGames.Soc.Common.Unity.Event.EventDefine StartReload = 150;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ReloadSetClip = 151;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ClientReloadCdFinish = 152;
	static WizardGames.Soc.Common.Unity.Event.EventDefine AidingOtherEvent = 153;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnChangeWireSlotInfo = 154;
	static WizardGames.Soc.Common.Unity.Event.EventDefine WireToolBuildModeOnChangeWireSlot = 155;
	static WizardGames.Soc.Common.Unity.Event.EventDefine WireToolBuildModeChangeWireColour = 156;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnHudStateChanged = 157;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnHudRootCaptureTouch = 158;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnHudRootCaptureTouchExcludeJoyStick = 159;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnChatChannelModify = 160;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnGetMultiPlayerBriefInfo = 161;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnCloseChatMain = 162;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdatePlayerHudMsgIdList = 163;
	static WizardGames.Soc.Common.Unity.Event.EventDefine WireToolBuildModeClearWire = 164;
	static WizardGames.Soc.Common.Unity.Event.EventDefine WireToolBuildModeSlotPowerChange = 165;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ComboConstructionSelect = 166;
	static WizardGames.Soc.Common.Unity.Event.EventDefine EditTargetForceRefresh = 167;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BuildBluePrintLockTip = 168;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BuildCustomBluePrintDataChange = 169;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ComboConstructionSelectUpgradeTarget = 170;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RespawnRebornPointRefresh = 171;
	static WizardGames.Soc.Common.Unity.Event.EventDefine CloseAllMutexDyingWindow = 172;
	static WizardGames.Soc.Common.Unity.Event.EventDefine CloseAllMutexRespawnWindow = 173;
	static WizardGames.Soc.Common.Unity.Event.EventDefine DoGamePreLoad = 174;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ObserverEnterWorld = 175;
	static WizardGames.Soc.Common.Unity.Event.EventDefine WireToolBuildModeOnClickAdd = 176;
	static WizardGames.Soc.Common.Unity.Event.EventDefine WireToolBuildModeOnPressRemove = 177;
	static WizardGames.Soc.Common.Unity.Event.EventDefine WireToolBuildModeOnReleaseRemove = 178;
	static WizardGames.Soc.Common.Unity.Event.EventDefine WireToolBuildModeFinishWire = 179;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnWireCreate = 180;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PowerLightDeploySuccess = 181;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PowerLightFinishDeploy = 182;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnClickBed = 183;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnClickBedCDGroup = 184;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnClickBedClusteringGroup = 185;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BlankClickOnMap = 186;
	static WizardGames.Soc.Common.Unity.Event.EventDefine EnterOverviewMode = 187;
	static WizardGames.Soc.Common.Unity.Event.EventDefine FitMapScaleAndPosForCDGroups = 188;
	static WizardGames.Soc.Common.Unity.Event.EventDefine EnterDyingState = 189;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiRespawnCdListActive = 190;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnTrackDeathPoint = 191;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateWeaponSpread = 192;
	static WizardGames.Soc.Common.Unity.Event.EventDefine AidBtnStateChange = 193;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ShortcutsItemEntityChange = 194;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ShortcutsChooseMenuStateChange = 195;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiLoadingDisable = 196;
	static WizardGames.Soc.Common.Unity.Event.EventDefine CloseManModel = 197;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiHideAllItemDetailIcons = 198;
	static WizardGames.Soc.Common.Unity.Event.EventDefine HudInEdit = 199;
	static WizardGames.Soc.Common.Unity.Event.EventDefine HoldingConstructionInfoChange = 200;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PartContainerLinkUpdate = 201;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TouchThroughSettingChange = 202;
	static WizardGames.Soc.Common.Unity.Event.EventDefine MonsterRemoveWeaponAudio = 203;
	static WizardGames.Soc.Common.Unity.Event.EventDefine SwitchWeather = 204;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateSingleMission = 205;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateSingleMissionCount = 206;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateMissionMarker = 207;
	static WizardGames.Soc.Common.Unity.Event.EventDefine MissionGuideDataChange = 208;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateTreasureBoxMissionMarker = 209;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateTreasureHuntMissionMarker = 210;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateRefreshTreasureTask = 211;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateTreasureTaskPanel = 212;
	static WizardGames.Soc.Common.Unity.Event.EventDefine AddTaskDoneNotify = 213;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateFreeModeTask = 214;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateTrackMissionId = 215;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateMonumentTrackId = 216;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateMonumentTypeId = 217;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateMonumentMission = 218;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ShowTaskMarkerFlyAnimation = 219;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TutorialFinishNewbieMissionCG = 220;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateDailyMission = 221;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateFactionLevel = 222;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateFactionMission = 223;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateFactionReward = 224;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TutorialFinishSubtitle = 225;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TutorialFinishTimeline = 226;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TutorialStartCartoon = 227;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TutorialFinishCartoon = 228;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TutorialFinishShowUi = 229;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TutorialStoryModeChanged = 230;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TutorialStoryNodeChanged = 231;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TutorialFinishViewGuide = 232;
	static WizardGames.Soc.Common.Unity.Event.EventDefine HitFakeMonster = 233;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TutorialClickRemoteControl = 234;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TimelineUpdatePlayableStatus = 235;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TimelineShowSound = 236;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TimelineStopSound = 237;
	static WizardGames.Soc.Common.Unity.Event.EventDefine CloseTelescope = 238;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TelescopeInteExit = 239;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TimelineStartPlaying = 240;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TimelineFinishPlaying = 241;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TimelineUseTelescope = 242;
	static WizardGames.Soc.Common.Unity.Event.EventDefine SetTeachingNpcMarkerDesc = 243;
	static WizardGames.Soc.Common.Unity.Event.EventDefine NewbieShowRemoteControl = 244;
	static WizardGames.Soc.Common.Unity.Event.EventDefine NextViewGuide = 245;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateSeedBackpack = 246;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnUpdateBombHomeOfflineMembers = 247;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnUpdateBombHomeOfflineStage = 248;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnUpdateBombHomeOfflineStageTime = 249;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnUpdateBombHomeOfflineBattleId = 250;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnUpdateBombHomeOfflineInitScore = 251;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnUpdateBombHomeOfflineIncomeScore = 252;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnUpdateBombHomeOfflineCostScore = 253;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnUpdateBombHomeOfflinePlayTime = 254;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnRecvBombHomeOfflineStart = 255;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnRecvBombHomeOfflineStop = 256;
	static WizardGames.Soc.Common.Unity.Event.EventDefine KatyushaGetAimPoint = 257;
	static WizardGames.Soc.Common.Unity.Event.EventDefine SubscribeAck = 258;
	static WizardGames.Soc.Common.Unity.Event.EventDefine SmallGeneratorUpdate = 259;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnKatyushaLaunchStateChanged = 260;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnKatyushaMissileNumChanged = 261;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnUpdateReputationName = 262;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RecoverVirtualPart = 263;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RecoverAllParts = 264;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ClientPartGoRemove = 265;
	static WizardGames.Soc.Common.Unity.Event.EventDefine MultiPlayerBriefInfosGetReply = 266;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PlayerSearchResultGetReply = 267;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PermPlayerInfoCacheDirty = 268;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPermCenterMembersCacheRefresh = 269;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPermDeleteFromGroup = 270;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiPermPlayerSearchResultCacheDirty = 271;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPermAcceptJoinCb = 272;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPermRejectJoinCb = 273;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPermPassivelyAddToGroup = 274;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPermPassivelyDeleteFromGroup = 275;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPermDeleteMemberCompletely = 276;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPermHubRenamed = 277;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPermApplyListChanged = 278;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPermAdminChanged = 279;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPermGroupChanged = 280;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPermApplyResultChanged = 281;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPermGroupCreatedAck = 282;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnMyPermChanged = 283;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnNearbyCorpseChange = 284;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnNearbyRewardBoxChange = 285;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnNearbyCollectionChanged = 286;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnAutoPickSettingChange = 287;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnClosePickSettingChange = 288;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnDiePickAtTopSettingChange = 289;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPickUpSettingChange = 290;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateMonumentGuidePoint = 291;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdatePlantWater = 292;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PlantSuccess = 293;
	static WizardGames.Soc.Common.Unity.Event.EventDefine WaterSuccess = 294;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ManureSuccess = 295;
	static WizardGames.Soc.Common.Unity.Event.EventDefine HarvestSuccess = 296;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RemovePlantSuccess = 297;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdatePlantsInfo = 298;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PlantDefaultPageToSeedPage = 299;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PlantBoxModelSelectedSlot = 300;
	static WizardGames.Soc.Common.Unity.Event.EventDefine DetailPageSelectedSlot = 301;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PlantPageSelectedSlot = 302;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ManurePageSelectedSlot = 303;
	static WizardGames.Soc.Common.Unity.Event.EventDefine SelectMultipleSlotWhenOpenManurePage = 304;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PrePlant = 305;
	static WizardGames.Soc.Common.Unity.Event.EventDefine CancelPrePlant = 306;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnHybridizeStart = 307;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnHybridizeFinish = 308;
	static WizardGames.Soc.Common.Unity.Event.EventDefine HudBlockElemChange = 309;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ShopPurchaseSuccess = 310;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateShopMallInfo = 311;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyCoinUpdate = 312;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdatePickItemsNum = 313;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnDropItemFromBag = 314;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnGetMultiPlayerNames = 315;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnUiOthersideNearByOpen = 316;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnUiInteractiveListVisibleChange = 317;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnLobbyStepChange = 318;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateBedInfo = 319;
	static WizardGames.Soc.Common.Unity.Event.EventDefine InventoryMainSelectType = 320;
	static WizardGames.Soc.Common.Unity.Event.EventDefine HideEntryList = 321;
	static WizardGames.Soc.Common.Unity.Event.EventDefine EnterConstructionBlueprintMode = 322;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ExitConstructionBlueprintMode = 323;
	static WizardGames.Soc.Common.Unity.Event.EventDefine SelectConstructionBlueprint = 324;
	static WizardGames.Soc.Common.Unity.Event.EventDefine StartWujiTurn = 325;
	static WizardGames.Soc.Common.Unity.Event.EventDefine StopWujiTurn = 326;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RaiseStart = 327;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RaiseEnd = 328;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RaiseStep = 329;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TryGuideRespawn = 330;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TryGuideEnterState = 331;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TryGuideNight = 332;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TryGuideGetItem = 333;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TryGuideOpenOrnament = 334;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TryGuideAirdrop = 335;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TryGuideEnterMonument = 336;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TryGuideInterface = 337;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TryGuideHandheldProp = 338;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TryGuideCollection = 339;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TryGuidePlaceDecoration = 340;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TryGuideSafetyBoxActived = 341;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TryGuideSafetyBoxDestroy = 342;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TryManualInterface = 343;
	static WizardGames.Soc.Common.Unity.Event.EventDefine FinishGetPlayerData = 344;
	static WizardGames.Soc.Common.Unity.Event.EventDefine EndGuideStepClose = 345;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UnlockManual = 346;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BreakGuide = 347;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TryAutoEquipItem = 348;
	static WizardGames.Soc.Common.Unity.Event.EventDefine GuideFinishTrainingStateChanged = 349;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateEquips = 350;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateItemNode = 351;
	static WizardGames.Soc.Common.Unity.Event.EventDefine AddItemNode = 352;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RemoveItemNode = 353;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ShowUsingItemLoading = 354;
	static WizardGames.Soc.Common.Unity.Event.EventDefine HideUsingItemLoading = 355;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ShowEscapeLoadingBar = 356;
	static WizardGames.Soc.Common.Unity.Event.EventDefine HideEscapeLoadingBar = 357;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateSwipeCardGameState = 358;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BlinkInventoryItemsByCond = 359;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BlinkInventoryItemsByCondNoScroll = 360;
	static WizardGames.Soc.Common.Unity.Event.EventDefine VendingMachineLootCountChange = 361;
	static WizardGames.Soc.Common.Unity.Event.EventDefine VendingMachineGoodsOrPriceItemChange = 362;
	static WizardGames.Soc.Common.Unity.Event.EventDefine VendingMachineOpenSelectItem = 363;
	static WizardGames.Soc.Common.Unity.Event.EventDefine VendingMachineSelectItem = 364;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ItemDetailGoBlueprint = 365;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnBatchUpgradeStatusChange = 366;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnBatchUpgradeFinish = 367;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnTerrCenterRemoved = 368;
	static WizardGames.Soc.Common.Unity.Event.EventDefine HidePermissionCenterEffect = 369;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ChangePermissionCenterEffect = 370;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LoadGameSpaceScene = 371;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamStartGame = 372;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamUpdateMode = 373;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamTeamNotice = 374;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnFriendRequestSend = 375;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamMemberUpdate = 376;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateTeamPermission = 377;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamInviteNotify = 378;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LoobyTeamReadyNotify = 379;
	static WizardGames.Soc.Common.Unity.Event.EventDefine AppointServerSoonOpenNotice = 380;
	static WizardGames.Soc.Common.Unity.Event.EventDefine AppointServerOpenNotice = 381;
	static WizardGames.Soc.Common.Unity.Event.EventDefine AddTeamMemberNotice = 382;
	static WizardGames.Soc.Common.Unity.Event.EventDefine CreateLobbyTeamNotice = 383;
	static WizardGames.Soc.Common.Unity.Event.EventDefine AppointmentTeamTimeOutNotice = 384;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamReconnectedNotice = 385;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamSelfLeaveNotice = 386;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamMemberLeaveNotice = 387;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamDataInitNotice = 388;
	static WizardGames.Soc.Common.Unity.Event.EventDefine AppointmentLobbyTeamDataInitNotice = 389;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamMemberMatchStateChangeNotice = 390;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnUpdateLobbyTeamMemberDisplay = 391;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamMatchStateCancelNotice = 392;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamFakeMathingNotice = 393;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamFakeMathingTimeOutNotice = 394;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamCancelFakeMathingNotice = 395;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamSwitchTeamNotice = 396;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamMatchGuideAnimNotice = 397;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamUpdateMemberNotice = 398;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamOpenMultipleMatchTimeNotice = 399;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamSelectMultipleMatchNotice = 400;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamOnTeamTurnToMultipleWarzoneMatchMemberNotice = 401;
	static WizardGames.Soc.Common.Unity.Event.EventDefine CloseShareListPanel = 402;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamSelectModeInfoNotice = 403;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamChangeModeIDNotice = 404;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamPreferenceListChangeNotice = 405;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamFakeMatchExtendTimeNotice = 406;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamUpdateTeamMemberNotice = 407;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamInviteAgreeCallbackNotice = 408;
	static WizardGames.Soc.Common.Unity.Event.EventDefine JoinOldBattleNotice = 409;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnLobbyStashDataChange = 410;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnLobbyStashItemTimeOutNotice = 411;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ShowUiResTitleNotice = 412;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnReputationRewardItemClicked = 413;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnUnlockReputationRewardClicked = 414;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnEntityBriefInfoAck = 415;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnRewardIconClickedToSelect = 416;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnExitReputationEditMode = 417;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnReplaceRewardAck = 418;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnReputationCallDrop = 419;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnGetReputationLevel = 420;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnGetReputationReward = 421;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateBadgeSlotInfo = 422;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateBadgeInfo = 423;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnBadgeTaskChange = 424;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ReputationLevelChange = 425;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ReputationLevelHideChange = 426;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ReputationBadgeWearChange = 427;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnReputationRecordsChange = 428;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnReputationRewardDictChange = 429;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnReputationFatigueValueChange = 430;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnOutputContainChange = 431;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnInputContainChange = 432;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnReputationEfficiencyChange = 433;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnCabineLevelChange = 434;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ReloadBulletEnd = 435;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ReloadBulletStart = 436;
	static WizardGames.Soc.Common.Unity.Event.EventDefine CombatMarkerAddOrRemove = 437;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnSearchBattlePlayRoleIds = 438;
	static WizardGames.Soc.Common.Unity.Event.EventDefine AcceptInvite = 439;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnHandleBattleTeamRedNotice = 440;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnTeamMemberOnlineChange = 441;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnTeamEntityClientCleanUp = 442;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnCheckTeammateTerritoryCabinetAck = 443;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ImpeachStateChange = 444;
	static WizardGames.Soc.Common.Unity.Event.EventDefine VoteRolesChange = 445;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnTeammateLoginNotice = 446;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnTeamUpdateDisplayData = 447;
	static WizardGames.Soc.Common.Unity.Event.EventDefine SearchPlayerError = 448;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnStartLootingAck = 449;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnSwitchLootingAck = 450;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OtherSideChooseNext = 451;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OtherSideMoveItemToPathAck = 452;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OtherSideMoveItemToPathFailure = 453;
	static WizardGames.Soc.Common.Unity.Event.EventDefine HorseUnEquipSuccess = 454;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OvenQueueDataUpdate = 455;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OvenQueueClaimUpdate = 456;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OvenQueueCancelUpdate = 457;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OvenQueueMove = 458;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OvenNameUpdate = 459;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OvenLootingIdsUpdate = 460;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyPublishRecruitNotice = 461;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyAgreeAppleforNotice = 462;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyAddRecruitNotice = 463;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyRecruitChange = 464;
	static WizardGames.Soc.Common.Unity.Event.EventDefine GameRecruitListChange = 465;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyRecruitMembersChange = 466;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PublishRecruitViewRequestFocus = 467;
	static WizardGames.Soc.Common.Unity.Event.EventDefine GameToLobbyRecruitDeleteNotice = 468;
	static WizardGames.Soc.Common.Unity.Event.EventDefine GameRecruitDeleteNotice = 469;
	static WizardGames.Soc.Common.Unity.Event.EventDefine SelfGameRecruitChange = 470;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PublishGameRecruitSuccess = 471;
	static WizardGames.Soc.Common.Unity.Event.EventDefine JumpToGameTeamTab = 472;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ReqGameRecruitListResult = 473;
	static WizardGames.Soc.Common.Unity.Event.EventDefine GameApplyInfosChange = 474;
	static WizardGames.Soc.Common.Unity.Event.EventDefine NewRecruitmentApplicationNotify = 475;
	static WizardGames.Soc.Common.Unity.Event.EventDefine CloseApplyJoinView = 476;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ItemChangeSafeBoxAck = 477;
	static WizardGames.Soc.Common.Unity.Event.EventDefine StateChangeSafeBoxAck = 478;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TriggerPutInAll = 479;
	static WizardGames.Soc.Common.Unity.Event.EventDefine SafeBoxTriggerToEmpty = 480;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnEnterTerritory = 481;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnExitTerritory = 482;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnTerritoryAtted = 483;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BackpackJumpToCraft = 484;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RefreshItemTips = 485;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiResHandleCurPanelChange = 486;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UserInfoUpdate = 487;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UserInfoUpdateReq = 488;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ChangePlayerNameNotice = 489;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ChangeNameError = 490;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ChangePlayerHeadIconNotice = 491;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RefreshChangeNameCDNotice = 492;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnFriendChange = 493;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnFriendRequestNumChange = 494;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnFriendRequestChange = 495;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnTempFriendChange = 496;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RequestRoleArchiveSuccesNotice = 497;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPlatformFriendChange = 498;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnFriendIntimacyChange = 499;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnUpdateAppPrivilege = 500;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnUpdateAeBonusCardInfo = 501;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnQueryRecoverInfo = 502;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ReceiveElectricalData = 503;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ReceiveElectricalDataWithSlots = 504;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnWireBuildModeChangeSubMode = 505;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnSidePanelSubviewItemSelect = 506;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnSidePanelSubviewCreate = 507;
	static WizardGames.Soc.Common.Unity.Event.EventDefine MainMapEnableNotify = 508;
	static WizardGames.Soc.Common.Unity.Event.EventDefine AddIOInfo = 509;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RemoveIOInfo = 510;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateSafetyBoxMarker = 511;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RpcCreateCombatMarker = 512;
	static WizardGames.Soc.Common.Unity.Event.EventDefine HideTeamCombatMarkerFlagChanged = 513;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TeamMemberDictChange = 514;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnTeammateLogout = 515;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TeamEntityClientInit = 516;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ReviewCreateCombatMarker = 517;
	static WizardGames.Soc.Common.Unity.Event.EventDefine CloseSetRFUi = 518;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RefreshBuildCollapseMarker = 519;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RemoveBuildCollapseMarker = 520;
	static WizardGames.Soc.Common.Unity.Event.EventDefine AddHoldingConstructionMarker = 521;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RemoveHoldingConstructionMarker = 522;
	static WizardGames.Soc.Common.Unity.Event.EventDefine MarkerInScreenCenter = 523;
	static WizardGames.Soc.Common.Unity.Event.EventDefine CreateHudCombatMarker = 524;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RemoveHudCombatMarker = 525;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RefreshShopMarkerPosition = 526;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RefreshPartBaseMarkerPosition = 527;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RefreshReportBanMarkerPosition = 528;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ForceShowMarkerDetail = 529;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ForceHideMarkerDetail = 530;
	static WizardGames.Soc.Common.Unity.Event.EventDefine CancelSelectMarker = 531;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RefreshDeathPointMarker = 532;
	static WizardGames.Soc.Common.Unity.Event.EventDefine MailInfoChange = 533;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ShowMailRewardPanel = 534;
	static WizardGames.Soc.Common.Unity.Event.EventDefine MyTribeInfosChange = 535;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TribeMemberInfoChange = 536;
	static WizardGames.Soc.Common.Unity.Event.EventDefine MyTribeDetailInfoChange = 537;
	static WizardGames.Soc.Common.Unity.Event.EventDefine MyTribeLampCustomTitlesChange = 538;
	static WizardGames.Soc.Common.Unity.Event.EventDefine MyEquipTribeLampChange = 539;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UnionMainBgHide = 540;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UnionInfoChange = 541;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UnionMembersChange = 542;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UnionIconSelect = 543;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UnionGroupRefresh = 544;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UnionLeave = 545;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateCurrentWeekRank = 546;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateLastWeekRank = 547;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PackUpPickList = 548;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BtnTpsSwitchUpdated = 549;
	static WizardGames.Soc.Common.Unity.Event.EventDefine Interactive2LabelShow = 550;
	static WizardGames.Soc.Common.Unity.Event.EventDefine CloseFocusInfoNotice = 551;
	static WizardGames.Soc.Common.Unity.Event.EventDefine HudOpenStatesChange = 552;
	static WizardGames.Soc.Common.Unity.Event.EventDefine HudWeaponIconClipForceRefresh = 553;
	static WizardGames.Soc.Common.Unity.Event.EventDefine HudWeaponIconDragStart = 554;
	static WizardGames.Soc.Common.Unity.Event.EventDefine HudWeaponIconDragEnd = 555;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnHudMakeFullScreen = 556;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RefreshChatUi = 557;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiSettingOpen = 558;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiSettingRootCaptureTouch = 559;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiBattleReportCaptureTouch = 560;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateResearchBench = 561;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateResearchBenchBlueprint = 562;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BedPlayerSearchNotice = 563;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RepairBenchContainerChange = 564;
	static WizardGames.Soc.Common.Unity.Event.EventDefine KatyushaCdStateChange = 565;
	static WizardGames.Soc.Common.Unity.Event.EventDefine KatyushaStateChange = 566;
	static WizardGames.Soc.Common.Unity.Event.EventDefine HitEntityDamageEmitFont = 567;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TpHeldItemBlocked = 568;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ChangeGMOpenNotice = 569;
	static WizardGames.Soc.Common.Unity.Event.EventDefine QuickActHightLightBackpack = 570;
	static WizardGames.Soc.Common.Unity.Event.EventDefine QuickActHightLightEquip = 571;
	static WizardGames.Soc.Common.Unity.Event.EventDefine QuickActHightLightWeapon = 572;
	static WizardGames.Soc.Common.Unity.Event.EventDefine QuickActHightLightTool = 573;
	static WizardGames.Soc.Common.Unity.Event.EventDefine QuickActHightLightOther = 574;
	static WizardGames.Soc.Common.Unity.Event.EventDefine QuickActAcceptDragBackpack = 575;
	static WizardGames.Soc.Common.Unity.Event.EventDefine QuickActAcceptDragEquip = 576;
	static WizardGames.Soc.Common.Unity.Event.EventDefine QuickActAcceptDragWeapon = 577;
	static WizardGames.Soc.Common.Unity.Event.EventDefine QuickActAcceptDragTool = 578;
	static WizardGames.Soc.Common.Unity.Event.EventDefine QuickActAcceptDragOther = 579;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OpenUIDyingNotice = 580;
	static WizardGames.Soc.Common.Unity.Event.EventDefine CloseUIDyingNotice = 581;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiInventorySuitState = 582;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiInventoryBatchDropSelectAll = 583;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiInventoryBatchDropSelectOne = 584;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnTriggerDataLoadFinish = 585;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RefreshUiActDebugInfo = 586;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PartTransformationOver = 587;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ElemEntryListHide = 588;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ElemEntryListShow = 589;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnSoftDisconnected = 590;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiUpdateExtendPackIcon = 591;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnReconnectFailed = 592;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PhysicsSimulate = 593;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnFastReconnected = 594;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ServerChangeTime = 595;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnMyPlayerEntityCreate = 596;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnStartGameErrorCallbackNotice = 597;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ForceUpdateEquip = 598;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TryStartEngine = 599;
	static WizardGames.Soc.Common.Unity.Event.EventDefine DebugEndBubble = 600;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ShadowCacheChange = 601;
	static WizardGames.Soc.Common.Unity.Event.EventDefine CenterRouletteOpen = 602;
	static WizardGames.Soc.Common.Unity.Event.EventDefine CenterRouletteClose = 603;
	static WizardGames.Soc.Common.Unity.Event.EventDefine MyPlayerOnHurt = 604;
	static WizardGames.Soc.Common.Unity.Event.EventDefine Battle_ItemUsableUpdate = 605;
	static WizardGames.Soc.Common.Unity.Event.EventDefine Ui_MyPlayer_HeldItemSwitchSuccess = 606;
	static WizardGames.Soc.Common.Unity.Event.EventDefine AfterHUDSwitchHeldItem = 607;
	static WizardGames.Soc.Common.Unity.Event.EventDefine VehicleModuleHpChange = 608;
	static WizardGames.Soc.Common.Unity.Event.EventDefine VehicleAutoDriveChange = 609;
	static WizardGames.Soc.Common.Unity.Event.EventDefine CampingTentLogoutSuccess = 610;
	static WizardGames.Soc.Common.Unity.Event.EventDefine SafetyStateChange = 611;
	static WizardGames.Soc.Common.Unity.Event.EventDefine SeatChange = 612;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TeleScopeOnAimFinish = 613;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TeleScopeOffAimFinish = 614;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TeleScopeStateChange = 615;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BlueprintCreatComplete = 616;
	static WizardGames.Soc.Common.Unity.Event.EventDefine GetTeamMemberDisplayInfoAck = 617;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnHideItemTips = 618;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnHideSubItemTips = 619;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyOnReconnected = 620;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnRejectLobbyInvite = 621;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnRejectAllTeamInvite = 622;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TeamMessageShieldChanged = 623;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TeamTipsChanged = 624;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TeamMessagePopTabClicked = 625;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnShowTerrGuild = 626;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnHideTerrGuild = 627;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnWireCreateLinkInfo = 628;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnStoryTaskReceiveTaskResult = 629;
	static WizardGames.Soc.Common.Unity.Event.EventDefine DeadSheepStateChanged = 630;
	static WizardGames.Soc.Common.Unity.Event.EventDefine CheckWireHaveElectricity = 631;
	static WizardGames.Soc.Common.Unity.Event.EventDefine WireSlotComboBoxChange = 632;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LevelOrExpChanged = 633;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TipsBubbleStart = 634;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TipsBubbleEnd = 635;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PreloadSceneModelFinish = 636;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PlayerSelfDisplayDataUpdate = 637;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PlayerCustomizeChange = 638;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnStoryStageChange = 639;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UseCardAllowed = 640;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BagUseCardAllowed = 641;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RefreshPandoraEntryState = 642;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RefreshPandoraEntryRedDot = 643;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnVoiceBand = 644;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnLiftingPlatformOperationNotify = 645;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnBeeBuzzTaskChange = 646;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnBeeBuzzDataChange = 647;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PlaySurvivalEffect = 648;
	static WizardGames.Soc.Common.Unity.Event.EventDefine WireModeChange = 649;
	static WizardGames.Soc.Common.Unity.Event.EventDefine InterruptPickListMsg = 650;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ProactivelyExitBuildMode = 651;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnSkinGoLoaded = 652;
	static WizardGames.Soc.Common.Unity.Event.EventDefine AfterAnimBegin = 653;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BeforeAnimBegin = 654;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BeforeSkin = 655;
	static WizardGames.Soc.Common.Unity.Event.EventDefine WeaponOnDeploy = 656;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OpenEntryList = 657;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TriggerBtnInteractiveIdChange = 658;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LadderStateChange = 659;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LadderBtnClickEvent = 660;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPlayerIsLocking = 661;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnLockableEntitiesChange = 662;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnLockingEntityChange = 663;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPartEntityInit = 664;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPartEntityTransChangeAtTransformAfter = 665;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnLadderTransformChange = 666;
	static WizardGames.Soc.Common.Unity.Event.EventDefine HotKeySettingChanged = 667;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateHotKeyTips = 668;
	static WizardGames.Soc.Common.Unity.Event.EventDefine HotKeySideGuideChanged = 669;
	static WizardGames.Soc.Common.Unity.Event.EventDefine HotKeyCenterGuideChanged = 670;
	static WizardGames.Soc.Common.Unity.Event.EventDefine IsInGameChanged = 671;
	static WizardGames.Soc.Common.Unity.Event.EventDefine HotKeyInputStateChanged = 672;
	static WizardGames.Soc.Common.Unity.Event.EventDefine SkipHotKeyPressInterrupt = 673;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LongPressHotKeyResponse = 674;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UnlockConditionChange = 675;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ParachuteStateChange = 676;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnLittleEyeEntered = 677;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnLittleEyeExited = 678;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnChoseSuitPlan = 679;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnChoseWeaponPlan = 680;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnShowWeaponPlan = 681;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnResetWeaponPlan = 682;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BeforePhotoModeEnter = 683;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPhotoModeEntered = 684;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPhotoModeExited = 685;
	static WizardGames.Soc.Common.Unity.Event.EventDefine AfterPhotoModeExit = 686;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPhotoFpEntered = 687;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPhotoTpEntered = 688;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPhotoFreeEntered = 689;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPhotoFreeLeaved = 690;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPhotoPathLoopChange = 691;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPhotoTrackEntered = 692;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPhotoTrackLeaved = 693;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPhotoShowVehicleHud = 694;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPhotoHideVehicleHud = 695;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPhotoHideAllUI = 696;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPhotoDataChanged = 697;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPhotoControlChanged = 698;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnPhotoControlReset = 699;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PhotoUIUpdate = 700;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnScreenCaptureFinished = 701;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnCurrencyUpdate = 702;
	static WizardGames.Soc.Common.Unity.Event.EventDefine MallBundleInfoUpdate = 703;
	static WizardGames.Soc.Common.Unity.Event.EventDefine MallInfoUpdate = 704;
	static WizardGames.Soc.Common.Unity.Event.EventDefine MallItemIdInfoUpdate = 705;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnDisplayDataUpdate = 706;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ComOngoingDisappearNotice = 707;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnChangeRoleAvatar = 708;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ComItemTipDisappearNotice = 709;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ComLeftInfoTipDisappearNotice = 710;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnSkinPlanChange = 711;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnGetGestureData = 712;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnGetSpraysData = 713;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnEquipColorSkin = 714;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnEquipHangings = 715;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnUnlockColorSkinReward = 716;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnUpGradeColorSkin = 717;
	static WizardGames.Soc.Common.Unity.Event.EventDefine SettingValueChanged = 718;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ModifyScreenSettingCountChange = 719;
	static WizardGames.Soc.Common.Unity.Event.EventDefine SettingQualityChangedMobile = 720;
	static WizardGames.Soc.Common.Unity.Event.EventDefine SettingEffectQualityChanged = 721;
	static WizardGames.Soc.Common.Unity.Event.EventDefine QualityMemoryViewStateChanged = 722;
	static WizardGames.Soc.Common.Unity.Event.EventDefine MobileQualityLevelChange = 723;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnFireStateChange = 724;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiLobbyMainAnimFinish = 725;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnConstructionReportPhotoModeEntered = 726;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnConstructionReportPhotoModeExited = 727;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TalentRewardReceived = 728;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ForceLevelExpUpdate = 729;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TalentUpdate = 730;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyBattleServerDataUpdate = 731;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LayerComStackCoverUpdate = 732;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnAdminOpen = 733;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnAdminClose = 734;
	static WizardGames.Soc.Common.Unity.Event.EventDefine AdminUIUpdate = 735;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnTouchBegin = 736;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RippleSystemInit = 737;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateBattlePassInfo = 738;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateBattlePassReward = 739;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateWeeklySeasonPoints = 740;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateSeasonTask = 741;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnGetCosReportTempCredential = 742;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnCosReportTooFrequency = 743;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnGetOutsideCreatorId = 744;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ObserverGetAllTerritory = 745;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ObserverGetTerritoryDetail = 746;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ObserverGetAllPlayer = 747;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ObserverGetPlayerDetail = 748;
	static WizardGames.Soc.Common.Unity.Event.EventDefine BuildPanelExpandState = 749;
	static WizardGames.Soc.Common.Unity.Event.EventDefine DeadCameraEvent = 750;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RedDotPulled = 751;
	static WizardGames.Soc.Common.Unity.Event.EventDefine MedalLevelCount = 752;
	static WizardGames.Soc.Common.Unity.Event.EventDefine MedalMaxLevel = 753;
	static WizardGames.Soc.Common.Unity.Event.EventDefine MedalTaskUndate = 754;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RecentStyleScore = 755;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TribeTipChanged = 756;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UnionTipChanged = 757;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnStyleMedalLevelCount = 758;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TopBarReportSelect = 759;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ReportInfoUpdate = 760;
	static WizardGames.Soc.Common.Unity.Event.EventDefine EncounteredPlayersUpdate = 761;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiShowLogo = 762;
	static WizardGames.Soc.Common.Unity.Event.EventDefine DeleteBattleServerSuccessNotice = 763;
	static WizardGames.Soc.Common.Unity.Event.EventDefine GachaInfoUpdate = 764;
	static WizardGames.Soc.Common.Unity.Event.EventDefine DrawGachaInfoUpdate = 765;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyTeamVoiceChange = 766;
	static WizardGames.Soc.Common.Unity.Event.EventDefine HotKeyPressed = 767;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UiSettingChangeSafeArea = 768;
	static WizardGames.Soc.Common.Unity.Event.EventDefine GetSettleStyleRankPointsSwitch = 769;
	static WizardGames.Soc.Common.Unity.Event.EventDefine DeleteSettleSwitchSuccess = 770;
	static WizardGames.Soc.Common.Unity.Event.EventDefine SetSettleSwitchSuccess = 771;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PlayerHomePageSwitch = 772;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ClaimMoveAimFinish = 773;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LotteryShopExchange = 774;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LotteryProgressReward = 775;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LotteryInitBGMBank = 776;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TalentLevelUp = 777;
	static WizardGames.Soc.Common.Unity.Event.EventDefine TalentReset = 778;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnSecondaryInteractionListVisibleChange = 779;
	static WizardGames.Soc.Common.Unity.Event.EventDefine MgrInputSystemReady = 780;
	static WizardGames.Soc.Common.Unity.Event.EventDefine PickEquipmentSuccessCallback = 781;
	static WizardGames.Soc.Common.Unity.Event.EventDefine CloseLotteryInnerVideo = 782;
	static WizardGames.Soc.Common.Unity.Event.EventDefine IsInLotteryProgress = 783;
	static WizardGames.Soc.Common.Unity.Event.EventDefine InLotteryQuickPurchase = 784;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ShowCloseDoorAnimationCompleted = 785;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnInteractiveListChanged = 786;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnUpdatePickUpList = 787;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnOpenViewFromInteractiveList = 788;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OpenBoxByLooting = 789;
	static WizardGames.Soc.Common.Unity.Event.EventDefine AutoOpenDoorStateChanged = 790;
	static WizardGames.Soc.Common.Unity.Event.EventDefine IsShortcutsDeployMode = 791;
	static WizardGames.Soc.Common.Unity.Event.EventDefine IsLotteryDrawLineEnd = 792;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ResetLotteryInnerVideoPlayer = 793;
	static WizardGames.Soc.Common.Unity.Event.EventDefine CustomBannerUpdate = 794;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ScreenshotSuccessful = 795;
	static WizardGames.Soc.Common.Unity.Event.EventDefine SeasonRankCallBack = 796;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateKOLPlayerInfo = 797;
	static WizardGames.Soc.Common.Unity.Event.EventDefine UpdateAllKOLPlayerInfo = 798;
	static WizardGames.Soc.Common.Unity.Event.EventDefine CheckNotificationPermission = 799;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnShowHpBarChanged = 800;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OneSharePopQuit = 801;
	static WizardGames.Soc.Common.Unity.Event.EventDefine LobbyModelSceneQualityChanged = 802;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnBattleReportUpdate = 803;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnClickTeamTip = 804;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnMallSkinShopComplete = 805;
	static WizardGames.Soc.Common.Unity.Event.EventDefine HotKeyBuildGuideChanged = 806;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnAnchorModeFreePerspective = 807;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnAnchorModeFirstPerspective = 808;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnAnchorModeThirdPerspective = 809;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnEnterActivationVolume = 810;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnExitActivationVolume = 811;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnSouDJStageChange = 812;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnSouDJStateChange = 813;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnSouDJRankListUpdate = 814;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnSouDJTeamDetailInfoUpdate = 815;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnSouDJIsEliminated = 816;
	static WizardGames.Soc.Common.Unity.Event.EventDefine RefreshLobbySkinRedDot = 817;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnSuitAnimPlayEnd = 818;
	static WizardGames.Soc.Common.Unity.Event.EventDefine ItemTipsJumpToUi = 819;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnApplicationFocusChanged = 820;
	static WizardGames.Soc.Common.Unity.Event.EventDefine HotKeyCenterInteractiveVisible = 821;
	static WizardGames.Soc.Common.Unity.Event.EventDefine OnAddOneGuideToUIView = 822;
	static WizardGames.Soc.Common.Unity.Event.EventDefine SetTouchBeginToHud = 823;
	static WizardGames.Soc.Common.Unity.Event.EventDefine SetTouchBeginToMoveView = 824;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Event.MgrMsg : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.Event.EventTag eventTag; // 0x14
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.Event.EventDefine,System.Int32> clearEventCount; // 0x18
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.Event.EventDefine,System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Event.InvokableActionBase>> registerEvents; // 0x20
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.Event.EventDefine,WizardGames.Soc.Common.Unity.Event.EventParamBase> eventParams; // 0x28
	System.Collections.Generic.Queue<WizardGames.Soc.Common.Unity.Event.EventParamBase> fireQueue; // 0x30
	System.Void RecordMsgCount(System.String key); // 0x074855ac
	System.Void MarkTag(WizardGames.Soc.Common.Unity.Event.EventTag tag); // 0x07485620
	System.Void ClearEventsOfTag(WizardGames.Soc.Common.Unity.Event.EventTag tag); // 0x07485798
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Event.InvokableActionBase> GetRegisteredActionList(WizardGames.Soc.Common.Unity.Event.EventDefine eventName); // 0x074861a8
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Event.InvokableActionBase> GetActionListFromPool(); // 0x07485f68
	System.Void ReturnActionListToPool(System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Event.InvokableActionBase> list); // 0x07486004
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Event.InvokableActionBase> CloneThenGetActionList(WizardGames.Soc.Common.Unity.Event.EventDefine eventName); // 0x0748625c
	System.Void CheckForEventRemoval(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Event.InvokableActionBase> actionList); // 0x074860b8
	System.Void CleanUp(); // 0x07486324
	System.Void DoUpdate(); // 0x074863d8
	System.Void AddListener(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, WizardGames.Soc.Common.Unity.Event.InvokableActionBase invokableAction); // 0x07486790
	System.Void AddListener(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, System.Action action); // 0x07486904
	System.Void AddListener<T1>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, System.Action<T1> action); // 0x052af1f0
	System.Void AddListener<T1,T2>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, System.Action<T1,T2> action); // 0x052af1f0
	System.Void AddListener<T1,T2,T3>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, System.Action<T1,T2,T3> action); // 0x052af1f0
	System.Void AddListener<T1,T2,T3,T4>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, System.Action<T1,T2,T3,T4> action); // 0x052af1f0
	System.Void AddListener<T1,T2,T3,T4,T5>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, System.Action<T1,T2,T3,T4,T5> action); // 0x052af1f0
	System.Void FireMsgAtOnce(WizardGames.Soc.Common.Unity.Event.EventDefine eventName); // 0x07486a70
	System.Void FireMsgAtOnce<T1>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, T1 arg1); // 0x052af1f0
	System.Void FireMsgAtOnce<T1,T2>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, T1 arg1, T2 arg2); // 0x052af1f0
	System.Void FireMsgAtOnce<T1,T2,T3>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, T1 arg1, T2 arg2, T3 arg3); // 0x052af1f0
	System.Void FireMsgAtOnce<T1,T2,T3,T4>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, T1 arg1, T2 arg2, T3 arg3, T4 arg4); // 0x052af1f0
	System.Void FireMsgAtOnce<T1,T2,T3,T4,T5>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5); // 0x052af1f0
	System.Void FireMsg(WizardGames.Soc.Common.Unity.Event.EventDefine eventName); // 0x07486d48
	System.Void FireMsg<T1>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, T1 p1); // 0x052af1f0
	System.Void FireMsg<T1,T2>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, T1 p1, T2 p2); // 0x052af1f0
	System.Void FireMsg<T1,T2,T3>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, T1 p1, T2 p2, T3 p3); // 0x052af1f0
	System.Void FireMsg<T1,T2,T3,T4>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, T1 p1, T2 p2, T3 p3, T4 p4); // 0x052af1f0
	System.Void FireMsg<T1,T2,T3,T4,T5>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5); // 0x052af1f0
	System.Void RemoveListener(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, System.Action action); // 0x07486efc
	System.Void RemoveListener<T1>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, System.Action<T1> action); // 0x052af1f0
	System.Void RemoveListener<T1,T2>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, System.Action<T1,T2> action); // 0x052af1f0
	System.Void RemoveListener<T1,T2,T3>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, System.Action<T1,T2,T3> action); // 0x052af1f0
	System.Void RemoveListener<T1,T2,T3,T4>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, System.Action<T1,T2,T3,T4> action); // 0x052af1f0
	System.Void RemoveListener<T1,T2,T3,T4,T5>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, System.Action<T1,T2,T3,T4,T5> action); // 0x052af1f0
	System.Void .ctor(); // 0x0748712c
	static System.Void .cctor(); // 0x074872e8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Event.InvokableActionBase : System.Object
{
	WizardGames.Soc.Common.Unity.Event.EventTag eventTag; // 0x10
	System.Void Clear(); // 0x055049cc
	System.Void .ctor(); // 0x074873bc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Event.InvokableAction : WizardGames.Soc.Common.Unity.Event.InvokableActionBase
{
	static SocLogger logger; // 0x0
	System.Action m_Action; // 0x18
	System.Void Initialize(WizardGames.Soc.Common.Unity.Event.EventTag tag, System.Action action); // 0x074869e4
	System.Void Invoke(); // 0x07486cd0
	System.Boolean IsAction(System.Action action); // 0x074870ac
	System.Void Clear(); // 0x07487424
	System.Void .ctor(); // 0x074874d4
	static System.Void .cctor(); // 0x07487538
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Event.InvokableAction<T1> : WizardGames.Soc.Common.Unity.Event.InvokableActionBase
{
	System.Action<T1> m_Action; // 0x0
	System.Void Initialize(WizardGames.Soc.Common.Unity.Event.EventTag tag, System.Action<T1> action); // 0x0550f6d4
	System.Void Invoke(T1 arg1); // 0x052af1f0
	System.Boolean IsAction(System.Action<T1> action); // 0x054dec74
	System.Void Clear(); // 0x055049cc
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Event.InvokableAction<T1,T2> : WizardGames.Soc.Common.Unity.Event.InvokableActionBase
{
	System.Action<T1,T2> m_Action; // 0x0
	System.Void Initialize(WizardGames.Soc.Common.Unity.Event.EventTag tag, System.Action<T1,T2> action); // 0x0550f6d4
	System.Void Invoke(T1 arg1, T2 arg2); // 0x052af1f0
	System.Boolean IsAction(System.Action<T1,T2> action); // 0x054dec74
	System.Void Clear(); // 0x055049cc
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Event.InvokableAction<T1,T2,T3> : WizardGames.Soc.Common.Unity.Event.InvokableActionBase
{
	System.Action<T1,T2,T3> m_Action; // 0x0
	System.Void Initialize(WizardGames.Soc.Common.Unity.Event.EventTag tag, System.Action<T1,T2,T3> action); // 0x0550f6d4
	System.Void Invoke(T1 arg1, T2 arg2, T3 arg3); // 0x052af1f0
	System.Boolean IsAction(System.Action<T1,T2,T3> action); // 0x054dec74
	System.Void Clear(); // 0x055049cc
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Event.InvokableAction<T1,T2,T3,T4> : WizardGames.Soc.Common.Unity.Event.InvokableActionBase
{
	System.Action<T1,T2,T3,T4> m_Action; // 0x0
	System.Void Initialize(WizardGames.Soc.Common.Unity.Event.EventTag tag, System.Action<T1,T2,T3,T4> action); // 0x0550f6d4
	System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4); // 0x052af1f0
	System.Boolean IsAction(System.Action<T1,T2,T3,T4> action); // 0x054dec74
	System.Void Clear(); // 0x055049cc
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Event.InvokableAction<T1,T2,T3,T4,T5> : WizardGames.Soc.Common.Unity.Event.InvokableActionBase
{
	System.Action<T1,T2,T3,T4,T5> m_Action; // 0x0
	System.Void Initialize(WizardGames.Soc.Common.Unity.Event.EventTag tag, System.Action<T1,T2,T3,T4,T5> action); // 0x0550f6d4
	System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5); // 0x052af1f0
	System.Boolean IsAction(System.Action<T1,T2,T3,T4,T5> action); // 0x054dec74
	System.Void Clear(); // 0x055049cc
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Event.EventParamBase : System.Object
{
	WizardGames.Soc.Common.Unity.Event.EventDefine msg; // 0x10
	WizardGames.Soc.Common.Unity.Event.EventDefine get_Msg(); // 0x0748760c
	System.Void Fire(WizardGames.Soc.Common.Unity.Event.MgrMsg mgr); // 0x05523a54
	System.Void ReturnToPool(); // 0x055049cc
	System.Void .ctor(); // 0x07487670
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Event.EventParam : WizardGames.Soc.Common.Unity.Event.EventParamBase
{
	
	System.Void Set(WizardGames.Soc.Common.Unity.Event.EventDefine msg); // 0x074876d8
	System.Void Fire(WizardGames.Soc.Common.Unity.Event.MgrMsg mgr); // 0x07487750
	System.Void ReturnToPool(); // 0x074877d4
	System.Void .ctor(); // 0x07487874
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Event.EventParam<T1> : WizardGames.Soc.Common.Unity.Event.EventParamBase
{
	T1 p1; // 0x0
	System.Void Set(WizardGames.Soc.Common.Unity.Event.EventDefine msg, T1 p1); // 0x052af1f0
	System.Void Fire(WizardGames.Soc.Common.Unity.Event.MgrMsg mgr); // 0x05523a54
	System.Void ReturnToPool(); // 0x055049cc
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Event.EventParam<T1,T2> : WizardGames.Soc.Common.Unity.Event.EventParamBase
{
	T1 p1; // 0x0
	T2 p2; // 0x0
	System.Void Set(WizardGames.Soc.Common.Unity.Event.EventDefine msg, T1 p1, T2 p2); // 0x052af1f0
	System.Void Fire(WizardGames.Soc.Common.Unity.Event.MgrMsg mgr); // 0x05523a54
	System.Void ReturnToPool(); // 0x055049cc
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Event.EventParam<T1,T2,T3> : WizardGames.Soc.Common.Unity.Event.EventParamBase
{
	T1 p1; // 0x0
	T2 p2; // 0x0
	T3 p3; // 0x0
	System.Void Set(WizardGames.Soc.Common.Unity.Event.EventDefine msg, T1 p1, T2 p2, T3 p3); // 0x052af1f0
	System.Void Fire(WizardGames.Soc.Common.Unity.Event.MgrMsg mgr); // 0x05523a54
	System.Void ReturnToPool(); // 0x055049cc
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Event.EventParam<T1,T2,T3,T4> : WizardGames.Soc.Common.Unity.Event.EventParamBase
{
	T1 p1; // 0x0
	T2 p2; // 0x0
	T3 p3; // 0x0
	T4 p4; // 0x0
	System.Void Set(WizardGames.Soc.Common.Unity.Event.EventDefine msg, T1 p1, T2 p2, T3 p3, T4 p4); // 0x052af1f0
	System.Void Fire(WizardGames.Soc.Common.Unity.Event.MgrMsg mgr); // 0x05523a54
	System.Void ReturnToPool(); // 0x055049cc
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Event.EventParam<T1,T2,T3,T4,T5> : WizardGames.Soc.Common.Unity.Event.EventParamBase
{
	T1 p1; // 0x0
	T2 p2; // 0x0
	T3 p3; // 0x0
	T4 p4; // 0x0
	T5 p5; // 0x0
	System.Void Set(WizardGames.Soc.Common.Unity.Event.EventDefine msg, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5); // 0x052af1f0
	System.Void Fire(WizardGames.Soc.Common.Unity.Event.MgrMsg mgr); // 0x05523a54
	System.Void ReturnToPool(); // 0x055049cc
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Event.MsgHandler : System.Object
{
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.Event.EventDefine,System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Event.MsgHandler.ActionBase>> eventDic; // 0x10
	WizardGames.Soc.Common.Unity.Event.MgrMsg mgrMsg; // 0x18
	System.Void .ctor(WizardGames.Soc.Common.Unity.Event.MgrMsg mgr); // 0x074878d8
	System.Void AddListener(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, WizardGames.Soc.Common.Unity.Event.MsgHandler.ActionBase actionWrap); // 0x074879b0
	System.Void AddListener(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, System.Action action); // 0x07487be4
	System.Void AddListener<T1>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, System.Action<T1> action); // 0x052af1f0
	System.Void AddListener<T1,T2>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, System.Action<T1,T2> action); // 0x052af1f0
	System.Void AddListener<T1,T2,T3>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, System.Action<T1,T2,T3> action); // 0x052af1f0
	System.Void AddListener<T1,T2,T3,T4>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, System.Action<T1,T2,T3,T4> action); // 0x052af1f0
	System.Void RemoveListener(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, System.Action action); // 0x07487e30
	System.Void RemoveListener<T1>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, System.Action<T1> action); // 0x052af1f0
	System.Void RemoveListener<T1,T2>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, System.Action<T1,T2> action); // 0x052af1f0
	System.Void RemoveListener<T1,T2,T3>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, System.Action<T1,T2,T3> action); // 0x052af1f0
	System.Void RemoveListener<T1,T2,T3,T4>(WizardGames.Soc.Common.Unity.Event.EventDefine eventName, System.Action<T1,T2,T3,T4> action); // 0x052af1f0
	System.Void Clear(); // 0x07488074
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Event.MsgHandler.ActionBase : System.Object
{
	WizardGames.Soc.Common.Unity.Event.EventDefine actionName; // 0x10
	System.Void Remove(); // 0x055049cc
	System.Void .ctor(); // 0x0748826c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Event.MsgHandler.ActionWrap : WizardGames.Soc.Common.Unity.Event.MsgHandler.ActionBase
{
	System.Action action; // 0x18
	System.Action<WizardGames.Soc.Common.Unity.Event.EventDefine,System.Action> OnRemove; // 0x20
	System.Void add_OnRemove(System.Action<WizardGames.Soc.Common.Unity.Event.EventDefine,System.Action> value); // 0x07487d40
	System.Void remove_OnRemove(System.Action<WizardGames.Soc.Common.Unity.Event.EventDefine,System.Action> value); // 0x074882d4
	System.Void Remove(); // 0x074883c4
	System.Void .ctor(); // 0x07488444
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Event.MsgHandler.ActionWrap<T1> : WizardGames.Soc.Common.Unity.Event.MsgHandler.ActionBase
{
	System.Action<T1> action; // 0x0
	System.Action<WizardGames.Soc.Common.Unity.Event.EventDefine,System.Action<T1>> OnRemove; // 0x0
	System.Void add_OnRemove(System.Action<WizardGames.Soc.Common.Unity.Event.EventDefine,System.Action<T1>> value); // 0x05523a54
	System.Void remove_OnRemove(System.Action<WizardGames.Soc.Common.Unity.Event.EventDefine,System.Action<T1>> value); // 0x05523a54
	System.Void Remove(); // 0x055049cc
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Event.MsgHandler.ActionWrap<T1,T2> : WizardGames.Soc.Common.Unity.Event.MsgHandler.ActionBase
{
	System.Action<T1,T2> action; // 0x0
	System.Action<WizardGames.Soc.Common.Unity.Event.EventDefine,System.Action<T1,T2>> OnRemove; // 0x0
	System.Void add_OnRemove(System.Action<WizardGames.Soc.Common.Unity.Event.EventDefine,System.Action<T1,T2>> value); // 0x05523a54
	System.Void remove_OnRemove(System.Action<WizardGames.Soc.Common.Unity.Event.EventDefine,System.Action<T1,T2>> value); // 0x05523a54
	System.Void Remove(); // 0x055049cc
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Event.MsgHandler.ActionWrap<T1,T2,T3> : WizardGames.Soc.Common.Unity.Event.MsgHandler.ActionBase
{
	System.Action<T1,T2,T3> action; // 0x0
	System.Action<WizardGames.Soc.Common.Unity.Event.EventDefine,System.Action<T1,T2,T3>> OnRemove; // 0x0
	System.Void add_OnRemove(System.Action<WizardGames.Soc.Common.Unity.Event.EventDefine,System.Action<T1,T2,T3>> value); // 0x05523a54
	System.Void remove_OnRemove(System.Action<WizardGames.Soc.Common.Unity.Event.EventDefine,System.Action<T1,T2,T3>> value); // 0x05523a54
	System.Void Remove(); // 0x055049cc
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Event.MsgHandler.ActionWrap<T1,T2,T3,T4> : WizardGames.Soc.Common.Unity.Event.MsgHandler.ActionBase
{
	System.Action<T1,T2,T3,T4> action; // 0x0
	System.Action<WizardGames.Soc.Common.Unity.Event.EventDefine,System.Action<T1,T2,T3,T4>> OnRemove; // 0x0
	System.Void add_OnRemove(System.Action<WizardGames.Soc.Common.Unity.Event.EventDefine,System.Action<T1,T2,T3,T4>> value); // 0x05523a54
	System.Void remove_OnRemove(System.Action<WizardGames.Soc.Common.Unity.Event.EventDefine,System.Action<T1,T2,T3,T4>> value); // 0x05523a54
	System.Void Remove(); // 0x055049cc
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Environment.ClimateParameters : System.Object
{
	UnityEngine.AnimationCurve Temperature; // 0x10
	System.Void .ctor(); // 0x074884a8
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Environment.TOD_CycleParameters : System.Object
{
	System.Single Hour; // 0x10
	System.Int32 Day; // 0x14
	System.Int32 Month; // 0x18
	System.Int32 Year; // 0x1c
	System.Void .ctor(); // 0x07488510
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Environment.GlobalWorldParameterConfig : UnityEngine.MonoBehaviour
{
	System.Single DayLengthInMinutes; // 0x30
	System.Boolean UseTimeCurve; // 0x34
	System.Boolean ProgressTime; // 0x35
	UnityEngine.AnimationCurve TimeCurve; // 0x38
	WizardGames.Soc.Common.Unity.Environment.TOD_CycleParameters ServerStartTime; // 0x40
	System.Single SunriseTime; // 0x48
	System.Single DayTime; // 0x4c
	System.Single SunsetTime; // 0x50
	System.Single NightTime; // 0x54
	WizardGames.Soc.Common.Unity.Environment.ClimateParameters Arid; // 0x58
	WizardGames.Soc.Common.Unity.Environment.ClimateParameters Temperate; // 0x60
	WizardGames.Soc.Common.Unity.Environment.ClimateParameters Tundra; // 0x68
	WizardGames.Soc.Common.Unity.Environment.ClimateParameters Arctic; // 0x70
	System.Void .ctor(); // 0x07488594
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Entity.BaseUnityMgrEntity : WizardGames.Soc.Common.Entity.BaseMgrLocalEntity
{
	
	System.Void .ctor(); // 0x07488640
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Entity.IdHolder : UnityEngine.MonoBehaviour
{
	System.Int64 id; // 0x30
	WizardGames.Soc.Common.Entity.IEntity entity; // 0x38
	System.Int64 get_ID(); // 0x074886cc
	WizardGames.Soc.Common.Entity.IEntity get_Entity(); // 0x07488730
	System.Void Init(System.Int64 id); // 0x07488794
	System.Void SetEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x0748880c
	System.Void .ctor(); // 0x0748888c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Electric.IOConfig : UnityEngine.MonoBehaviour
{
	WizardGames.Soc.Common.Unity.Electric.IOSlotConfig[] inputs; // 0x30
	WizardGames.Soc.Common.Unity.Electric.IOSlotConfig[] outputs; // 0x38
	System.Void OnDrawGizmosSelected(); // 0x074888f4
	System.Void DrawGizmosWithIns(UnityEngine.Transform partIns); // 0x07488968
	System.Void .ctor(); // 0x07488be0
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Electric.IOSlotConfig : System.Object
{
	System.Int32 slotId; // 0x10
	System.String niceName; // 0x18
	System.Int32 languageId; // 0x20
	WizardGames.Soc.Common.Electric.EIOSlotType type; // 0x24
	System.Boolean isSignal; // 0x28
	System.Boolean rootConnectionsOnly; // 0x29
	System.Boolean mustTag; // 0x2a
	System.String tag; // 0x30
	System.Int32 tagIdx; // 0x38
	UnityEngine.Vector3 handlePosition; // 0x3c
	UnityEngine.Vector3 handleEuler; // 0x48
	System.Void .ctor(); // 0x07488c48
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Electric.IOSlot : WizardGames.Soc.Common.Electric.IOSlotBase
{
	WizardGames.Soc.Common.Unity.Electric.ClientIOLine <line>k__BackingField; // 0x78
	System.Int32 <slotIndex>k__BackingField; // 0x80
	WizardGames.Soc.Common.Unity.Electric.ClientIOLine get_line(); // 0x07488cd4
	System.Void set_line(WizardGames.Soc.Common.Unity.Electric.ClientIOLine value); // 0x07488d38
	System.Int32 get_slotIndex(); // 0x07488db8
	System.Void set_slotIndex(System.Int32 value); // 0x07488e1c
	System.Void Clear(); // 0x07488e94
	System.Void CleanUpLines(); // 0x07488f94
	System.Void UpdateLines(UnityEngine.Vector3[] linePoints); // 0x07489278
	System.Void SetIOLine(WizardGames.Soc.Common.Unity.Electric.ClientIOLine line); // 0x07489590
	System.Void .ctor(); // 0x07489644
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Electric.WireColour : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Electric.WireColour Default = 1;
	static WizardGames.Soc.Common.Unity.Electric.WireColour White = 2;
	static WizardGames.Soc.Common.Unity.Electric.WireColour Red = 3;
	static WizardGames.Soc.Common.Unity.Electric.WireColour Green = 4;
	static WizardGames.Soc.Common.Unity.Electric.WireColour Blue = 5;
	static WizardGames.Soc.Common.Unity.Electric.WireColour Yellow = 6;
	static WizardGames.Soc.Common.Unity.Electric.WireColour Cyan = 7;
	static WizardGames.Soc.Common.Unity.Electric.WireColour Orange = 8;
	static WizardGames.Soc.Common.Unity.Electric.WireColour Rose = 9;
	static WizardGames.Soc.Common.Unity.Electric.WireColour Purple = 10;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Electric.ClientIOLine : UnityEngine.MonoBehaviour
{
	UnityEngine.LineRenderer Line; // 0x30
	WizardGames.Soc.Common.Unity.Electric.WireColour color; // 0x38
	UnityEngine.Color lineColor; // 0x3c
	System.Collections.Generic.List<UnityEngine.Material> mats; // 0x50
	static UnityEngine.Material flowMat; // 0x0
	System.String prefabPath; // 0x58
	UnityEngine.MaterialPropertyBlock block; // 0x60
	static System.Int32 BaseColor; // 0x8
	static System.Int32 EmissionColor; // 0xc
	static System.Int32 MainColor; // 0x10
	UnityEngine.Color emissionColorGreen; // 0x68
	UnityEngine.Color defaultEmissionColor; // 0x78
	System.Boolean isHavePower; // 0x88
	System.Boolean isTimer; // 0x89
	System.Boolean isCheckingIO; // 0x8a
	System.Void InitLine(WizardGames.Soc.Common.Unity.Electric.WireColour wireColor, UnityEngine.Color lineColor, System.String path); // 0x074896ac
	System.Void SetFlowColor(UnityEngine.Color color); // 0x07489d28
	System.Void WireSuccessEmission(); // 0x07489f40
	System.Void EnableWireEmission(System.Action action); // 0x07489fec
	System.Void DisableWireEmission(); // 0x0748a304
	System.Void SetVisible(System.Boolean visible); // 0x07489508
	System.Void AddPosition(UnityEngine.Vector3 worldPos); // 0x0748a3f4
	System.Void Clear(); // 0x0748a50c
	System.Void Return(); // 0x07489138
	System.Void UdpateLineState(); // 0x07489e30
	UnityEngine.Vector3 GetLastPlacedNodePosition(); // 0x0748a580
	System.Single GetLength(); // 0x0748a684
	System.Void RemoveLastPosition(); // 0x0748a818
	System.Void SetPositions(UnityEngine.Vector3[] positions); // 0x07489420
	System.Int32 get_PositionCount(); // 0x0748a8c4
	System.Void .ctor(); // 0x0748a934
	static System.Void .cctor(); // 0x0748a9a4
	System.Void <WireSuccessEmission>b__17_0(); // 0x0748aa74
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Electric.ClientIOLine.<>c__DisplayClass18_0 : System.Object
{
	WizardGames.Soc.Common.Unity.Electric.ClientIOLine <>4__this; // 0x10
	System.Action action; // 0x18
	System.Void .ctor(); // 0x0748a29c
	UnityEngine.Color <EnableWireEmission>b__0(); // 0x0748aad8
	System.Void <EnableWireEmission>b__1(UnityEngine.Color temp); // 0x0748ab48
	System.Void <EnableWireEmission>b__2(); // 0x0748ac60
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Electric.ElectricUtilsUnity : System.Object
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.Common.Unity.Electric.IOSlot GetAlpha3IOSlotByGO(WizardGames.Soc.Common.Unity.Electric.IOSlotConfig config); // 0x0748acd8
	static System.Void GetAlpha3IOSlotsByGO(WizardGames.Soc.Common.Unity.Electric.IOConfig ioConfig, WizardGames.Soc.Common.Electric.IOSlotBase[]& inputs, WizardGames.Soc.Common.Electric.IOSlotBase[]& outputs); // 0x0748af44
	static System.Void GetAlpha3IOSlotsByGO_FillArray(WizardGames.Soc.Common.Unity.Electric.IOSlotConfig[] slotLst, System.Boolean isInput, WizardGames.Soc.Common.Electric.IOSlotBase[]& array); // 0x0748b098
	static System.Void .cctor(); // 0x0748b364
}

// Client.Runtime
enum WizardGames.Soc.Common.Unity.Defines.TableItemEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None = 0;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum HoldItem_blueprint = 1;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_wooden_door = 2;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_double_wooden_door = 3;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Tool_Cabinet = 4;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_metal_door = 5;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_double_metal_door = 6;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_password = 7;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_wooden_ladder = 8;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_wooden_barricade = 9;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_metal_barricade = 10;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_wooden_barrier = 11;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_wooden_high_door = 12;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_wooden_wall = 13;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_stone_high_gate = 14;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_stone_wall = 15;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_prison_gate = 16;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_prison_bars = 17;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Horizontal_metal_blast_holes = 18;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Longitudinal_metal_blast_holes = 19;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_steel_door = 20;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_key_lock = 21;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Double_steel_doors = 22;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Shutter_doors = 23;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_factory_door = 24;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_solid_wood_shutters = 25;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_tempered_glass_windows = 26;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_tempered_glass_window = 27;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_metal_fence = 28;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_wooden_fence = 29;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_iron_mesh_floor = 30;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Triangular_iron_mesh_floor = 31;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_chain_link_fence = 32;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Iron_mesh_fence_gate = 33;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_wooden_sales_window = 34;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_metal_window = 35;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Wooden_Spiked_Barricades = 36;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Sandbag_Barricades = 37;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_concrete_barricade = 38;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_stone_barricade = 39;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_rope_net = 40;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_folding_ladder = 41;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Triangular_folding_ladder = 42;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_watchtower = 43;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_reputation_converter = 44;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_wooden_ground_thorn = 45;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_furnace = 46;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_refinery = 47;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_campfire = 48;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_First_class_workbench = 49;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Secondary_Workbench = 50;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Three_level_workbench = 51;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_wooden_storage_box = 52;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_large_storage_box = 53;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_melting_pot = 54;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_campfire_bucket = 55;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_fireplace = 56;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_grill = 57;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_decomposition_machine = 58;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_sleeping_bag = 59;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_research_bench = 60;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Modulation_desk = 61;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_repair_stand = 62;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_small_dew_collector = 63;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_large_dew_collector = 64;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_bed = 65;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Special_ornament_A = 66;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Special_ornament_B = 67;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Large_planting_box = 68;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_small_planter_box = 69;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Compost_machine = 70;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_RF_pager = 71;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_fluid_combiner = 72;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_fluid_separator = 73;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_beer_barrel = 74;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Sprinklers = 75;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_vending_machine = 76;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_bone_fragments = 77;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_animal_fat = 78;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_leather = 79;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_wolf_skull = 80;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_sulfur = 81;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_metal_ore = 82;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Advanced_Metal_Ore = 83;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Stone = 84;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_advanced_metal = 85;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_low_quality_fuel = 86;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_gunpowder = 87;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_rifle_body = 88;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_submachine_gun_body = 89;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_metal_spring = 90;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_tarpaulin = 91;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_sewing_kit = 92;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_metal_shards = 93;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_sulfur_ore = 94;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_water = 95;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_brine = 96;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_wood = 97;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_charcoal = 98;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_cloth = 99;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_fuse = 100;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_scrap = 101;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_road_sign = 102;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_crude = 103;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Metal_tube = 104;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_dynamite = 105;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Security_camera = 106;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_diesel_fuel = 107;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_laptop = 108;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_electronic_parts = 109;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_empty_gas_tank = 110;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_gear = 111;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_metal_blade = 112;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_rope = 113;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Semi_automatic_gun_body = 114;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Metal_plate = 115;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_empty_bean_can = 116;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_empty_tuna_can = 117;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_plant_fibres = 118;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_fertilizer = 119;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_horse_manure = 120;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_mask = 121;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_sunglasses = 122;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_wooden_helmet = 123;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_hoodie = 124;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_jacket = 125;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_road_marking_gloves = 126;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_Pants = 127;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_road_sign_skirt = 128;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_boots = 129;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_leather_boots = 130;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_coffee_can_helmet = 131;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_road_sign_jacket = 132;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_Bone_Helm = 133;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_metal_mask = 134;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_riot_helmet = 135;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_fur_cloak = 136;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_fur_vest = 137;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_metal_breastplate = 138;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_wooden_breastplate = 139;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_shirt = 140;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_wooden_leg_armor = 141;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_linen_shoes = 142;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_Bone_Armor = 143;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_animal_skin_pants = 144;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_leather_gloves = 145;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_miner_hat = 146;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_Junior_expansion_backpack = 147;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_oxygen_cylinder = 148;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_Wetsuit = 149;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_diving_mask = 150;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_linen_shirt = 151;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_linen_hood = 152;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_diving_fins = 153;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_linen_pants = 154;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_linen_gloves = 155;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_baseball_cap = 156;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_Baotou_hat = 157;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_round_hat = 158;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_Long_sleeved_shirt = 159;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_snow_jacket = 160;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_Vest = 161;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_tube_top = 162;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_tactical_gloves = 163;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_sarong = 164;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_shorts = 165;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_heavy_duty_helmet = 166;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_Heavy_plate_armor = 167;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_Heavy_leg_armor = 168;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_candle_cap = 169;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_Simple_headgear = 170;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_purple_sunglasses = 171;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_night_vision_goggles = 172;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_wolf_headdress = 173;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_Iron_bucket_helmet = 174;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_bearded = 175;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_scarecrow_hood = 176;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_party_hat = 177;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_glowing_eyes = 178;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_lumberjack_hoodie = 179;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_Jumpsuits = 180;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_Intermediate_expansion_backpack = 181;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_GM_expansion_backpack = 182;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_Chemical_suit = 183;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_Polar_outfit = 184;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_Polar_Scientist_Set = 185;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_Robber_Guard_Outfit = 186;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_nomadic_outfit = 187;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_mummy_suit = 188;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_ninja_suit = 189;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_Premium_horseshoes = 190;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Wear_Ordinary_horseshoe = 191;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_Pickaxe = 192;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_torch = 193;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_rock = 194;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_stone_ax = 195;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_stone_pick = 196;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_iron_ax = 197;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_round_ax = 198;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_Scrap_Pickaxe = 199;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_scrap_hammer = 200;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_chainsaw = 201;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_electric_pick = 202;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_wooden_hammer = 203;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_Wiring_tool = 204;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_drum = 205;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_RF_transmitter = 206;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_AK_47_assault_rifle = 207;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_MP5A4 = 208;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_crossbow = 209;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_rocket_launcher = 210;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_hunting_bow = 211;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_double_barrel_shotgun = 212;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_L96_sniper_rifle = 213;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_homemade_light_machine_gun = 214;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_semi_automatic_pistol = 215;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_bolt_action_rifle = 216;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_semi_automatic_rifle = 217;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_Harpoon_gun = 218;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_compound_bow = 219;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_earthen_pistol = 220;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_flamethrower = 221;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_revolver = 222;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_single_barrel_shotgun = 223;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_LR_300_assault_rifle = 224;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_homemade_submachine_gun = 225;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_thompson_submachine_gun = 226;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_nail_gun = 227;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_M39_rifle = 228;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_pump_action_shotgun = 229;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_Spas_12_shotgun = 230;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_M249 = 231;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_grenade_launcher = 232;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_Type_17_pistol = 233;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_M92_pistol = 234;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_python_revolver = 235;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_AK_new_specifications = 236;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_Armed_tank_main_gun = 237;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_Armed_tank_submachine_gun = 238;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_scrap_sword = 239;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_wooden_spear = 240;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_mace = 241;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_Machete = 242;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_stone_spear = 243;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_paddle = 244;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_Paddle__non_functional_ = 245;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_dagger = 246;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_Bone_Blade = 247;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_bone_rod = 248;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_long_sword = 249;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_baseball_bat = 250;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Melee_Scrap_meat_cleaver = 251;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum WeaponAccessory_8x_scope = 252;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum WeaponAccessory_Holographic_Sight = 253;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum WeaponAccessory_tactical_flashlight = 254;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum WeaponAccessory_Expansion_magazine = 255;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum WeaponAccessory_16x_scope = 256;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum WeaponAccessory_Brake = 257;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum WeaponAccessory_supercharger = 258;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum WeaponAccessory_silencer = 259;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum WeaponAccessory_laser_sight = 260;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum WeaponAccessory_homemade_scope = 261;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum ThrowItem_F1_Fragmentation_Grenade = 262;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum ThrowItem_Molotov_cocktail = 263;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum ThrowItem_time_bomb = 264;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum ThrowItem_signal_flare = 265;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum ThrowItem_Bean_Can_Ray = 266;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum ThrowItem_vehicle_call_smoke_bomb = 267;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum ThrowItem_Speedboat_Summons_Smoke_Bombs = 268;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum ThrowItem_Bean_Can_Explosive_Packets = 269;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Bullet_5_56mm_rifle_ammunition = 270;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Bullet_5_56_mm_high_explosive_ammunition = 271;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Bullet_5_56_mm_combustible_ammunition = 272;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Bullet_5_56_mm_high_velocity_ammunition = 273;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Bullet_pistol_ammo = 274;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Bullet_combustible_pistol_ammo = 275;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Bullet_Velocity_Pistol_Ammo = 276;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Bullet_12_gauge_shot = 277;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Bullet_12_gauge_buckshot = 278;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Bullet_12_gauge_combustible_shotgun = 279;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Bullet_rocket_missile = 280;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Bullet_smoke_rocket = 281;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Bullet_incendiary_rocket = 282;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Bullet_high_speed_rocket = 283;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Bullet_wooden_arrow = 284;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Bullet_burning_arrow = 285;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Bullet_high_speed_arrow = 286;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Bullet_bone_arrow = 287;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Bullet_Harpoon_ammunition = 288;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Bullet_Nail_gun_ammo = 289;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Bullet_handmade_ammunition = 290;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Bullet_40mm_grenade = 291;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Bullet_40mm_smoke_grenade = 292;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Bullet_40mm_shotgun = 293;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Bullet_MLRS = 294;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_test_generator = 295;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Wind_Turbines = 296;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_solar_panel = 297;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_small_fuel_generator = 298;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_large_battery = 299;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_medium_battery = 300;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_small_battery = 301;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_switch = 302;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_power_separator = 303;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_interceptor = 304;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_serializer = 305;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_OR_gate = 306;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_line_splitter = 307;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_storage_unit = 308;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_random_gate = 309;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_button = 310;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_counter = 311;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Smart_separator = 312;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Test_integrated_circuits = 313;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_timer = 314;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_AND_gate = 315;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_AND_or_gate = 316;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_multi_port_combiner = 317;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Multi_port_separator = 318;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_time_switch = 319;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Backup_fuel_power_integrated_circuit = 320;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_ceiling_light = 321;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_automatic_turret = 322;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_siren_light = 323;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Electric_heaters = 324;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Luxurious_Christmas_lights = 325;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_door_controller = 326;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Electric_Furnace = 327;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_flash = 328;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_industrial_wall_light = 329;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Green_Industrial_Wall_Light = 330;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_red_industrial_wall_light = 331;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_lighter = 332;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_life_sensor = 333;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_laser_sensor = 334;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Pressure_Sensor = 335;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_vehicle_lift = 336;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_elevator = 337;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_searchlight = 338;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_radio_frequency_broadcaster = 339;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_RF_receiver = 340;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_fluid_switch = 341;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_Electric_water_purifier = 342;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Construction_water_pump = 343;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_green_card = 344;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_blue_card = 345;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_red_card = 346;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_aiming_module = 347;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum WeaponAccessory_Advanced_carburetor = 348;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum WeaponAccessory_Advanced_crankshaft = 349;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum WeaponAccessory_Premium_Piston = 350;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum WeaponAccessory_Premium_spark_plug = 351;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum WeaponAccessory_Advanced_air_valve = 352;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum WeaponAccessory_Intermediate_carburetor = 353;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum WeaponAccessory_Intermediate_crankshaft = 354;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum WeaponAccessory_Intermediate_piston = 355;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum WeaponAccessory_Intermediate_spark_plug = 356;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum WeaponAccessory_Intermediate_air_valve = 357;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum WeaponAccessory_Low_stage_carburetor = 358;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum WeaponAccessory_Lower_stage_crankshaft = 359;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum WeaponAccessory_Low_level_piston = 360;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum WeaponAccessory_Low_grade_spark_plug = 361;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum WeaponAccessory_Low_level_valve = 362;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_raw_pork = 363;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_roasted_pork = 364;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_raw_bear_meat = 365;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_raw_chicken = 366;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_raw_venison = 367;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_raw_wolf_meat = 368;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_raw_meat = 369;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Grilled_Bear_Meat = 370;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_grilled_chicken = 371;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_cooked_venison = 372;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_roasted_wolf_meat = 373;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_grilled_human_flesh = 374;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Maggots = 375;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_earthworm = 376;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_raw_horsemeat = 377;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Grilled_horse_meat = 378;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_cactus_meat = 379;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_mushroom = 380;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_corn = 381;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_pumpkin = 382;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Potato = 383;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_black_berries = 384;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_blue_berries = 385;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_green_berries = 386;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_red_berries = 387;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_white_berries = 388;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_yellow_berries = 389;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_canned_beans = 390;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_canned_tuna = 391;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_pickles = 392;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_chocolate_bar = 393;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Oatmeal_Cookies = 394;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum HoldItem_Water_bottle = 395;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_blueberry = 396;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_black_raspberry = 397;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_apple = 398;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_circuit_blueprint = 399;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Use_medical_syringe = 400;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Use_hemostatic_syringe = 401;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Use_nutrition_syringe = 402;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Use_medical_kit = 403;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Use_bandage = 404;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_anti_radiation_drugs = 405;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Seed_blueberry_seeds = 406;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Seed_flax_seeds = 407;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Seed_potato_seeds = 408;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Seed_pumpkin_seeds = 409;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Seed_corn_seeds = 410;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Seed_white_berry_seeds = 411;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Seed_yellow_berry_seeds = 412;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Seed_green_berry_seeds = 413;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Seed_black_berry_seeds = 414;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Seed_red_berry_seeds = 415;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Obtain_the_metal_fragment_quest_treasure_map = 416;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Bow_and_arrow_making_quest_treasure_map = 417;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Scrap_scavenger_mission_treasure_map = 418;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Hunting_mission_treasure_map = 419;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Encrypted_information__less_ = 420;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Encrypted_Intelligence__medium_ = 421;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Encrypted_Intelligence__Large_ = 422;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Decode_the_intelligence_tape = 423;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_outsider_temporary_currency = 424;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawings__Architectural_Drawings = 425;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Wooden_Door = 426;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprints__Double_Wooden_Doors = 427;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Tool_Cabinet = 428;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Metal_Door = 429;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Double_Metal_Doors = 430;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Code_Lock = 431;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Wooden_Ladder = 432;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Wooden_Barricades = 433;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Metal_Barricades = 434;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Wooden_Barrier = 435;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Tall_Wood_Door = 436;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__High_Wall_of_Wood = 437;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Stone_High_Gate = 438;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__High_Stone_Wall = 439;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Prison_Iron_Gate = 440;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Prison_Bars = 441;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Transverse_Metal_Blast_Hole = 442;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_drawing__Longitudinal_metal_blast_hole = 443;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Steel_Door = 444;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Key_Lock = 445;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Double_Steel_Doors = 446;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprints__Roll_up_Doors = 447;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Factory_Door = 448;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprints__Solid_Wood_Blinds = 449;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprints__Tempered_Glass_Windows = 450;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Metal_Guardrail = 451;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Wooden_Guardrail = 452;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Iron_Mesh_Flooring = 453;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Triangular_Iron_Mesh_Floor = 454;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Iron_Mesh_Fence = 455;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Iron_Mesh_Fence_Gate = 456;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Wooden_Sales_Window = 457;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Metal_Sales_Window = 458;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Wooden_Spiked_Barricade = 459;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Sandbag_Barricades = 460;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Concrete_Barricades = 461;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Stone_Barricades = 462;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Rope_Net = 463;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Folding_Ladder = 464;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Triangular_Folding_Ladder = 465;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Watchtower = 466;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Reputation_Converter = 467;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Wooden_Ground_Thorn = 468;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Crucible = 469;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Refinery = 470;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Campfire = 471;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Level_1_Workbench = 472;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Secondary_Workbench = 473;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Level_3_Workbench = 474;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Wooden_Storage_Crate = 475;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Large_Storage_Chest = 476;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__The_Melting_Pot = 477;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Bonfire_Barrel = 478;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Fireplace = 479;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Grill = 480;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Disintegrator = 481;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Sleeping_Bag = 482;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Research_Bench = 483;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Modulation_Station = 484;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Repair_Bench = 485;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Small_Dew_Collector = 486;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Large_Dew_Collector = 487;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Bed = 488;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Special_Ornament_A = 489;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Special_Ornament_B = 490;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Large_Planter_Box = 491;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Small_Planter_Box = 492;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Compost_Machine = 493;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Radio_Pager = 494;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Fluid_Combiner = 495;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Fluid_Separator = 496;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Beer_Barrel = 497;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Sprinkler = 498;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Low_Quality_Fuel = 499;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Gunpowder = 500;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Rifle_Body = 501;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Submachine_Gun_Body = 502;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Metal_Spring = 503;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Tarpaulin = 504;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Sewing_Kit = 505;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawings__Road_Signs = 506;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Metal_Pipe = 507;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Explosives = 508;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprints__Surveillance_Cameras = 509;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Diesel = 510;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Laptop = 511;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawings__Electronic_Components = 512;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Empty_Gas_Can = 513;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Gears = 514;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Metal_Blade = 515;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Rope = 516;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Semi_automatic_gun_body = 517;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Metal_Plate = 518;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Fuse = 519;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Empty_Bean_Can = 520;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Empty_Tuna_Can = 521;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Wolf_Skull = 522;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Mask = 523;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Sunglasses = 524;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Wooden_Helmet = 525;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Hoodie = 526;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Jacket = 527;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprints__Road_Sign_Gloves = 528;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Pants = 529;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Road_Sign_Pavement = 530;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Boots = 531;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Hide_Boots = 532;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Coffee_Can_Helmet = 533;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Blueprint__Signpost_Jacket = 534;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Bone_Helm = 535;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Metal_Mask = 536;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Riot_Helmet = 537;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Hide_Cloak = 538;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Hide_Vest = 539;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Metal_Breastplate = 540;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Wooden_Breastplate = 541;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Shirt = 542;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Wooden_Leg_Armor = 543;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Burlap_Shoes = 544;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Beast_Bone_Armor = 545;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Hide_Pants = 546;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Leather_Gloves = 547;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Miners_Hat = 548;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Primary_Expansion_Backpack = 549;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Oxygen_Cylinder = 550;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Wetsuit = 551;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Diving_Mask = 552;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Linen_Shirt = 553;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Linen_Hood = 554;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Diving_Fins = 555;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Linen_Pants = 556;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Linen_Gloves = 557;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Baseball_Cap = 558;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Baotou_Hat = 559;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Round_Hat = 560;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Long_Sleeve_Shirt = 561;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Snow_Jacket = 562;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Vest = 563;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Tube_Top = 564;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Tactical_Gloves = 565;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Sarong = 566;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Shorts = 567;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Heavy_Helmet = 568;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Heavy_Plate_Armor = 569;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Heavy_Leg_Armor = 570;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Candle_Cap = 571;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Simple_Hood = 572;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Purple_Sunglasses = 573;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Night_Vision_Goggles = 574;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Wolf_Headgear = 575;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Iron_Barrel_Helmet = 576;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Bearded = 577;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Scarecrow_Hood = 578;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Party_Hat = 579;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Glowing_Eyes = 580;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Lumberjack_Hoodie = 581;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Jumpsuit = 582;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Intermediate_Expansion_Backpack = 583;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Chemical_Protective_Suit = 584;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Polar_Outfit = 585;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprints__Polar_Scientist_Set = 586;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Bandit_Guard_Outfit = 587;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Nomad_Outfit = 588;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprints__Mummy_Set = 589;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Ninja_Suit = 590;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Premium_Horseshoe = 591;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Common_Horseshoe = 592;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Iron_Pickaxe = 593;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Torch = 594;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Rock = 595;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Stone_Ax = 596;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Stone_Pickaxe = 597;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Iron_Ax = 598;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Round_Ax = 599;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprints__Scrap_Pickaxe = 600;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Scrap_Hammer = 601;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Chainsaw = 602;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Electric_Pickaxe = 603;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Wooden_Hammer = 604;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawings__Wiring_Tools = 605;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Iron_Barrel = 606;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__RF_Transmitter = 607;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__AK_47_Assault_Rifle = 608;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_drawing__MP5A4 = 609;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Crossbow = 610;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Rocket_Launcher = 611;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Hunting_Bow = 612;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Double_Barrel_Shotgun = 613;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__L96_Sniper_Rifle = 614;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Homemade_Light_Machine_Gun = 615;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Semi_Automatic_Pistol = 616;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Bolt_Action_Rifle = 617;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Semi_Automatic_Rifle = 618;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Harpoon_Gun = 619;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Compound_Bow = 620;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Homemade_Pistol = 621;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Flamethrower = 622;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Revolver = 623;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Single_Barrel_Shotgun = 624;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__LR_300_Assault_Rifle = 625;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Homemade_Submachine_Gun = 626;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Thompson_Submachine_Gun = 627;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Nail_Gun = 628;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_drawings__AK_new_specifications = 629;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Scrap_Sword = 630;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Wooden_Spear = 631;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Mace = 632;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Machete = 633;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Stone_Spear = 634;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Paddle = 635;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Paddle__non_functional_ = 636;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Dagger = 637;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__8x_Scope = 638;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Holographic_Sight = 639;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Tactical_Flashlight = 640;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Expanded_Magazine = 641;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__16x_Scope = 642;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Muzzle_Brake = 643;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Supercharger = 644;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Silencer = 645;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Laser_Sight = 646;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Homemade_Scope = 647;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__F1_Fragmentation_Grenade = 648;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Molotov_cocktail = 649;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Time_Bomb = 650;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Flare = 651;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Beancan_Thunder = 652;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Vehicle_summons_smoke_grenades = 653;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Speedboat_summons_smoke_bombs = 654;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__M39_Rifle = 655;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Pump_Action_Shotgun = 656;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Spas_12_Shotgun = 657;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_drawing__M249 = 658;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Grenade_Launcher = 659;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Type_17_Pistol = 660;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__M92_Pistol = 661;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Python_Revolver = 662;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Bean_Can_Explosive_Packet = 663;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__5_56mm_Rifle_Ammunition = 664;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__5_56_mm_high_explosive_ammunition = 665;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__5_56mm_Combustible_Ammunition = 666;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__5_56mm_High_Velocity_Ammunition = 667;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Pistol_Ammo = 668;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Combustible_Pistol_Ammo = 669;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__High_Velocity_Pistol_Ammunition = 670;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__12_Gauge_Shotgun = 671;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__12_Gauge_Lead_Bullet = 672;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__12_gauge_flammable_shotshell = 673;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Rocket = 674;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Smoke_Rocket = 675;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Incendiary_Rockets = 676;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__High_Velocity_Rocket = 677;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Wooden_Arrows = 678;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Burning_Arrow = 679;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Velocity_Arrow = 680;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Bone_Arrows = 681;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Harpoon_Ammunition = 682;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Nail_Gun_Ammo = 683;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Multiple_Rocket_Launcher = 684;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Crafted_Ammunition = 685;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__40mm_Grenade = 686;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__40mm_Smoke_Grenade = 687;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__40mm_Shotgun = 688;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Test_Generator = 689;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprints__Wind_Turbine = 690;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Solar_Panels = 691;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Small_Fuel_Generator = 692;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Large_Battery = 693;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Medium_Battery = 694;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Small_Battery = 695;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Switch = 696;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Power_Splitter = 697;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Interceptor = 698;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Series_Connector = 699;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__OR_Gate = 700;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Line_Splitter = 701;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Storage_Unit = 702;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Random_Door = 703;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Button = 704;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Counter = 705;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Smart_Separator = 706;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Testing_Integrated_Circuits = 707;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Timer = 708;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__AND_Gate = 709;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__AND_OR_Gate = 710;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprints__Ceiling_Light = 711;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Auto_Turret = 712;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Siren_Light = 713;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Electric_Heater = 714;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprints__Luxurious_Christmas_Lights = 715;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Gate_Controller = 716;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Electric_Furnace = 717;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Flash = 718;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Industrial_Wall_Light = 719;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Green_Industrial_Wall_Light = 720;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Red_Industrial_Wall_Light = 721;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Ignition = 722;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Life_Sensor = 723;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Laser_Sensor = 724;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Pressure_Sensor = 725;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Vehicle_Lift = 726;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Elevator = 727;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Searchlight = 728;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__RF_Broadcaster = 729;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__RF_Receiver = 730;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Fluid_Switch = 731;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Electric_Water_Purifier = 732;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Water_Pump = 733;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Green_Card = 734;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Blue_Card = 735;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Red_Card = 736;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Targeting_Module = 737;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Medical_Syringe = 738;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Hemostatic_Syringe = 739;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Nutritional_Syringe = 740;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Med_Kit = 741;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Bandage = 742;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Anti_radiation_drug = 743;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawings__Workbench_Collection = 744;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Linen_Clothing = 745;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprints__Decorative_Clothing = 746;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Braid = 747;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Beast_Bone_Clothing = 748;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Throw_Explosives = 749;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Semi_Auto_Pistol_Set = 750;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Single_Barrel_Shotgun_Set = 751;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Compound_Bow_Set = 752;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprints__Semi_Automatic_Rifle_Set = 753;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprints__Crossbow_Set = 754;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Living_Set = 755;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Warm_Clothing = 756;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Clothing_Basic_Materials = 757;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Iron_Cutting_Tool = 758;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_drawing__basic_equipment_materials = 759;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Road_Sign_Clothing = 760;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__High_Wooden_Wall = 761;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Power_Switch_Set = 762;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprints__Basic_Circuit_Component_Kit = 763;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Gun_Materials = 764;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Advanced_Ammunition_Combinations = 765;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Sheet__Syringe = 766;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Advanced_Cutting_Tools = 767;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__Metal_Blast_Hole = 768;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint__AK47_Suit = 769;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprints__Rocket_Launcher_Set = 770;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum None_Blueprint_Drawing__Electrical_Harvesting_Tools = 771;
	static WizardGames.Soc.Common.Unity.Defines.TableItemEnum Weapon_Homing_Missile_Launcher = 1000;
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Defines.TableItemEnumMap : System.Object
{
	static System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Defines.TableItemEnum> EnumMap; // 0x0
	static System.Void .cctor(); // 0x0748b438
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Defines.ItemEntityTypeMap : System.Object
{
	static System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Data.DataItem.ItemEntityType> EnumMap; // 0x0
	static System.Void .cctor(); // 0x0748f4c4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.DebugLog.SocDebug : System.Object
{
	static SocLogger logger; // 0x0
	static System.Void VehicleError(System.String log); // 0x074937a0
	static System.Void MassiveHitLog(System.String log); // 0x07493840
	static System.Void .cctor(); // 0x07493908
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Corpse.CorpseBuoyancy : UnityEngine.MonoBehaviour
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Utility.SocVehicle.Scripts.Buoyancy.Buoyancy> buoyancyList; // 0x30
	System.Boolean useUnderWaterDrag; // 0x38
	System.Boolean needCycle; // 0x39
	System.Void FixedUpdate(); // 0x074939dc
	System.Void UpdateCycle(System.Boolean enable); // 0x07493b5c
	System.Void StartCycle(); // 0x07493bd8
	System.Void CloseCycle(); // 0x07493c40
	System.Void CreateBuoyancy(); // 0x07493ca4
	System.Void .ctor(); // 0x07493f44
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Contexts.SyncSmbStepAudioData : System.ValueType
{
	System.Int64 entityId; // 0x10
	System.Boolean isFp; // 0x18
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Contexts.UnityContext : WizardGames.Soc.Common.Contexts.Context
{
	WizardGames.Soc.Common.Unity.Go.BaseMgrEntityGo BaseMgrEntityGo; // 0xc8
	WizardGames.Soc.Common.Entity.BaseMgrEntity BaseMgrEntity; // 0xd0
	WizardGames.Soc.Common.Combat.Shoot.MgrShootFormula MgrShootFormula; // 0xd8
	WizardGames.Soc.Common.Unity.Manager.MgrCollider MgrCollider; // 0xe0
	WizardGames.Soc.Common.DataSet.CommonDataSet<WizardGames.Soc.Common.Unity.LightData.LightItemData> LightItemDataSet; // 0xe8
	System.Void .ctor(); // 0x07493ff8
	System.Void Clear(); // 0x0749412c
}

// Client.Runtime
interface WizardGames.Soc.Common.Unity.Construction.IBinaryAnimationPlayer : 
{
	
	System.Void Play(System.Boolean op, System.Boolean bImmediate); // 0x074941d4
	System.Void Play(System.Int32 op, System.Boolean bImmediate); // 0x0550f700
	System.Boolean get_Enable(); // 0x054c4760
	System.Void set_Enable(System.Boolean value); // 0x05523a7c
	System.Boolean get_IsPlaying(); // 0x054c4760
	System.Action<System.Boolean> get_OnEnabledChanged(); // 0x054e7844
	System.Void set_OnEnabledChanged(System.Action<System.Boolean> value); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.DoorAnimatorPlayer : System.Object, WizardGames.Soc.Common.Unity.Construction.IBinaryAnimationPlayer
{
	UnityEngine.Animator _animator; // 0x10
	System.Action<System.Boolean> <OnEnabledChanged>k__BackingField; // 0x18
	System.Boolean get_Enable(); // 0x074942b4
	System.Void set_Enable(System.Boolean value); // 0x0749432c
	System.Boolean get_IsPlaying(); // 0x07494478
	System.Action<System.Boolean> get_OnEnabledChanged(); // 0x074944dc
	System.Void set_OnEnabledChanged(System.Action<System.Boolean> value); // 0x07494540
	System.Void .ctor(UnityEngine.Animator animator); // 0x074945c0
	System.Void Play(System.Int32 trueOp, System.Boolean bImmediate); // 0x0749464c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.BinaryAnimationPlayer : System.Object, WizardGames.Soc.Common.Unity.Construction.IBinaryAnimationPlayer
{
	UnityEngine.Animation _animation; // 0x10
	WizardGames.Soc.Common.Unity.Construction.ConstructionAnimationConfig _animationConfig; // 0x18
	System.String trueOpName; // 0x20
	System.String falseOpName; // 0x28
	System.Action<System.Boolean> <OnEnabledChanged>k__BackingField; // 0x30
	System.Boolean get_Enable(); // 0x0749477c
	System.Void set_Enable(System.Boolean value); // 0x074947f4
	System.Boolean get_IsPlaying(); // 0x07494940
	System.Action<System.Boolean> get_OnEnabledChanged(); // 0x074949b8
	System.Void set_OnEnabledChanged(System.Action<System.Boolean> value); // 0x07494a1c
	System.Void .ctor(UnityEngine.Animation animation, System.String trueOpName, System.String falseOpName); // 0x07494a9c
	System.Void Play(System.Int32 trueOp, System.Boolean bImmediate); // 0x07494bb4
	UnityEngine.AnimationState GetAnimationState(System.String name); // 0x07494d30
	System.Single GetAnimationPlaySpeed(System.String name); // 0x07494e74
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.TwoDirDoorAnimatorPlayer : System.Object, WizardGames.Soc.Common.Unity.Construction.IBinaryAnimationPlayer
{
	UnityEngine.Animation _animation; // 0x10
	WizardGames.Soc.Common.Unity.Construction.ConstructionAnimationConfig _animationConfig; // 0x18
	System.Collections.Generic.List<System.String> opNames; // 0x20
	System.Action<System.Boolean> <OnEnabledChanged>k__BackingField; // 0x28
	System.Boolean get_Enable(); // 0x07495088
	System.Void set_Enable(System.Boolean value); // 0x07495100
	System.Boolean get_IsPlaying(); // 0x0749524c
	System.Action<System.Boolean> get_OnEnabledChanged(); // 0x074952c4
	System.Void set_OnEnabledChanged(System.Action<System.Boolean> value); // 0x07495328
	System.Void .ctor(UnityEngine.Animation animation, System.Collections.Generic.List<System.String> opNames); // 0x074953a8
	System.Void Play(System.Int32 opName, System.Boolean bImmediate); // 0x0749549c
	UnityEngine.AnimationState GetAnimationState(System.String name); // 0x0749565c
	System.Single GetAnimationPlaySpeed(System.String name); // 0x074957a0
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Construction.PlaceTarget : System.ValueType
{
	System.Boolean valid; // 0x10
	UnityEngine.Ray ray; // 0x14
	WizardGames.Soc.Common.Unity.DeployObj go; // 0x30
	System.Boolean onTerrain; // 0x38
	UnityEngine.Vector3 position; // 0x3c
	UnityEngine.Vector3 normal; // 0x48
	UnityEngine.Vector3 rotation; // 0x54
	UnityEngine.Vector3 rotationOffset; // 0x60
	WizardGames.Soc.Common.Entity.PlayerEntity player; // 0x70
	WizardGames.Soc.Common.Unity.Construction.EPlaceState placeState; // 0x78
	WizardGames.Soc.Common.Unity.Construction.SocketBase holdingInChargeSocket; // 0x80
	WizardGames.Soc.Common.Unity.Construction.SocketBase socket; // 0x88
	System.Void SetTargetPlaceState(WizardGames.Soc.Common.Unity.Construction.EPlaceState state); // 0x074959b4
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Construction.RuntimeBuildingTarget : System.ValueType
{
	System.Boolean valid; // 0x10
	UnityEngine.Ray ray; // 0x14
	WizardGames.Soc.Common.Entity.PartEntity construction; // 0x30
	WizardGames.Soc.Common.Construction.SocketRuntimeBase Socket; // 0x38
	System.Int32 HoldingInChargeSocketId; // 0x40
	System.Boolean onTerrain; // 0x44
	UnityEngine.Vector3 position; // 0x48
	UnityEngine.Vector3 normal; // 0x54
	UnityEngine.Vector3 rotation; // 0x60
	WizardGames.Soc.Common.Entity.PlayerEntity player; // 0x70
	System.Boolean hasNoBuildAPermission; // 0x78
	WizardGames.Soc.Common.Unity.Construction.EPlaceState placeState; // 0x7c
	System.String pveColliderName; // 0x80
	System.Boolean stabilityPassCheck; // 0x88
	System.Int64 blockedTempleteId; // 0x90
	WizardGames.Soc.Common.Construction.PartType DebrisPartType; // 0x98
	System.Boolean isRotated; // 0x9c
	WizardGames.Soc.Common.Construction.PartType holdingPartType; // 0xa0
	WizardGames.Soc.Common.Framework.Algorithm.Quaternion GetWorldRotation(System.Boolean female); // 0x07495a34
	UnityEngine.Vector3 GetWorldPosition(); // 0x07495cc8
	System.Void SetTargetPlaceState(WizardGames.Soc.Common.Unity.Construction.EPlaceState state, System.Boolean force); // 0x07495edc
}

// Client.Runtime
struct WizardGames.Soc.Common.Unity.Construction.BuildingTarget : System.ValueType
{
	System.Boolean valid; // 0x10
	UnityEngine.Ray ray; // 0x14
	WizardGames.Soc.Common.Entity.PartEntity construction; // 0x30
	WizardGames.Soc.Common.Unity.Construction.SocketBase socket; // 0x38
	System.Boolean onTerrain; // 0x40
	UnityEngine.Vector3 position; // 0x44
	UnityEngine.Vector3 normal; // 0x50
	UnityEngine.Vector3 rotation; // 0x5c
	UnityEngine.Vector3 rotationOffset; // 0x68
	WizardGames.Soc.Common.Entity.PlayerEntity player; // 0x78
	System.Boolean hasNoBuildAPermission; // 0x80
	WizardGames.Soc.Common.Unity.Construction.EPlaceState placeState; // 0x84
	System.String pveColliderName; // 0x88
	System.Boolean stabilityPassCheck; // 0x90
	System.Boolean isForceSocket; // 0x91
	
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ColliderGoData : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	UnityEngine.GameObject colliderGo; // 0x20
	WizardGames.Soc.Common.Unity.Construction.CoreColliderData coreColliderData; // 0x28
	System.String ColliderPath; // 0x30
	static SocLogger logger; // 0x0
	System.UInt64 _loadPrefabAsyncId; // 0x38
	System.Boolean isLoading; // 0x40
	WizardGames.Soc.Common.Combat.ConstructionColliderConfigCollection configCollection; // 0x48
	System.Void .ctor(); // 0x07495f68
	System.Void OnColliderLoadFinish(UnityEngine.GameObject go, System.Object[] arg); // 0x07495fd0
	System.Void SetParent(); // 0x07496258
	System.Void SetPosAndRotation(); // 0x07496404
	System.Void SetScale(); // 0x0749619c
	System.Void OnLoadSuccess(); // 0x0749651c
	System.Void LoadCollider(); // 0x074967a8
	System.Void InitColliderGoMonoInfo(UnityEngine.GameObject go); // 0x07496100
	System.Void Clear(); // 0x07496a4c
	System.Void CancelLoad(); // 0x07496b7c
	System.Void GetColliderConfigs(System.Collections.Generic.List<WizardGames.Soc.Common.Combat.ColliderConfig> configs); // 0x07496c1c
	System.Void ReleaseToPool(); // 0x07496df4
	static System.Void .cctor(); // 0x07496e88
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.BaseColliderGoData : WizardGames.Soc.Common.Unity.Construction.ColliderGoData
{
	
	System.Void .ctor(); // 0x07496f5c
	static WizardGames.Soc.Common.Unity.Construction.BaseColliderGoData Generate(); // 0x07496fe4
	System.Void SetParent(); // 0x0749705c
	System.Void SetPosAndRotation(); // 0x07497144
	System.Void OnLoadSuccess(); // 0x074971a4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.GradeColliderGoData : WizardGames.Soc.Common.Unity.Construction.ColliderGoData
{
	
	System.Void .ctor(); // 0x074974e4
	static WizardGames.Soc.Common.Unity.Construction.GradeColliderGoData Generate(); // 0x0749756c
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.SplicingColliderGoData : WizardGames.Soc.Common.Unity.Construction.ColliderGoData
{
	UnityEngine.Vector3 localPos; // 0x50
	UnityEngine.Quaternion localRotation; // 0x5c
	System.Void .ctor(); // 0x074975e4
	static WizardGames.Soc.Common.Unity.Construction.SplicingColliderGoData Generate(); // 0x0749766c
	System.Void SetPosAndRotation(); // 0x074976e4
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.ConstructionSkin : UnityEngine.MonoBehaviour
{
	System.Boolean UseDefaultSkin; // 0x30
	WizardGames.Soc.Common.Unity.Construction.ConstructionConditionalModel[] conditionModules; // 0x38
	System.Boolean isInit; // 0x40
	WizardGames.Soc.Common.Unity.Construction.ConstructionConditionalModel[] get_ConditionModules(); // 0x0749778c
	System.Void Init(); // 0x074977f0
	System.Void ShowInEditor(UnityEngine.Transform root); // 0x074979f8
	System.Void RefreshSync(WizardGames.Soc.Common.Entity.PartEntity entity); // 0x07497b38
	System.Void GetAsyncLoadTargetsList(System.Int64 additionInfo, System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.ConstructionConditionalModel>& loadTargets); // 0x07497d2c
	System.Void GetLoadTargetIndexList(System.Int64 additionBlockInfo, System.Collections.Generic.List<System.Int32> loadTargetIndexList); // 0x07497ebc
	System.Void .ctor(); // 0x07498014
}

// Client.Runtime
class WizardGames.Soc.Common.Unity.Construction.CoreColliderData : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	static SocLogger logger; // 0x0
	static System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.ConstructionConditionalModel> tmpConditionModules; // 0x8
	WizardGames.Soc.Common.Entity.PartEntity partEntity; // 0x20
	WizardGames.Soc.Common.Combat.ColliderConfigSet_Construction_Core colliderConfigSet; // 0x28
	System.SByte curGrade; // 0x30
	System.Int64 curSkinId; // 0x38
	System.Int64 curAdditionBlockInfo; // 0x40
	System.Boolean haveBaseColliderGoData; // 0x48
	WizardGames.Soc.Common.Unity.Construction.ColliderGoData baseColliderGoData; // 0x50
	System.Boolean haveGradeColliderGoData; // 0x58
	WizardGames.Soc.Common.Unity.Construction.ColliderGoData gradeColliderGoData; // 0x60
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.SplicingColliderGoData> splicingColliderDatas; // 0x68
	WizardGames.Soc.Common.Unity.Construction.ECoreColliderState ColliderState; // 0x70
	System.Int64 TemplateId; // 0x78
	System.Int64 EntityId; // 0x80
	System.Int32 Grade; // 0x88
	System.Int64 SkinId; // 0x90
	System.Int64 AdditionBlockInfo; // 0x98
	UnityEngine.Vector3 position; // 0xa0
	UnityEngine.Quaternion rotation; // 0xac
	UnityEngine.GameObject doorAssistGo; // 0xc0
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Construction.ColliderGoData> removeColliderDatas; // 0xc8
	UnityEngine.Transform get_ColliderRootTrans(); // 0x07496348
	System.Void Init(); // 0x0749807c
	System.Void Clear(); // 0x074983e4
	System.Void ClearUnityInfo(); // 0x07498768
	System.Void RefreshCollider(); // 0x07498964
	System.Void RefreshPosAndRotation(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); // 0x07498b68
	System.Void LoadGradeCollider(System.String colliderPath); // 0x07498cec
	System.Void RemoveBaseCollider(); // 0x074986cc
	System.Void LoadBaseCollider(); // 0x074981cc
	System.Void OnBaseColliderLoaded(); // 0x0749721c
	System.Void RefreshGradeCollider(); // 0x07498a28
	System.Void AddGradeCollider(); // 0x07498ea8
	System.Void RemoveGradeCollider(); // 0x0749851c
	System.Void RefreshSplicingCollider(); // 0x07498ac0
	System.Void AddSplicingCollider(); // 0x07498f80
	System.Void RemoveSplicingCollider(); // 0x074985b8
	System.Void RefreshColliderSet(); // 0x07496588
	System.Void ReleaseColliderData(WizardGames.Soc.Common.Unity.Construction.ColliderGoData colliderGoData); // 0x07498db4
	static WizardGames.Soc.Common.Unity.Construction.CoreColliderData Generate(); // 0x074994e0
	System.Void ReleaseToPool(); // 0x07499558
