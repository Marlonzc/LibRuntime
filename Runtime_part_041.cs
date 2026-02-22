	System.Single currentDayValue; // 0x9c
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> readingOccurences; // 0xa0
	System.Void Init(); // 0x06c5810c
	System.Void Tick(); // 0x06c58238
	System.Void ReadAndUpdateEnvironment(); // 0x06c58318
	System.Void ReadEnvironment(); // 0x06c58a30
	System.Void UpdateCurrentEnvironment(); // 0x06c58e9c
	System.Int32 GetMostCommonReading(System.Collections.Generic.List<System.Int32> readings); // 0x06c58f1c
	System.Void UpdateBaseSound(System.Single crossFadeTimeOverride); // 0x06c58468
	WizardGames.Soc.SocClient.Audio.AmbienceDefinition GetBaseSound(System.Single crossFadeTimeOverride); // 0x06c5914c
	System.Void SetWaterSate(System.Boolean isUnderWater); // 0x06c597d4
	System.Boolean IsUnderWater(); // 0x06c59524
	System.Void PlayAudio(WizardGames.Soc.SocClient.Audio.AmbienceDefinition ambience); // 0x06c592e8
	System.Void StopAudio(WizardGames.Soc.SocClient.Audio.AmbienceDefinition ambience); // 0x06c59b74
	System.Single GetScore(WizardGames.Soc.SocClient.Audio.AmbienceDefinition definition, System.Single rain, System.Single snow, System.Single wind, System.Boolean underground); // 0x06c59928
	System.Void PlayStings(System.Collections.Generic.List<WizardGames.Soc.SocClient.Audio.AmbienceDefinition> stings); // 0x06c58568
	System.Void UpdateDayNightRTPC(); // 0x06c58744
	System.Void UpdateElevationRTPC(); // 0x06c5890c
	System.Void .ctor(); // 0x06c59cb0
	static System.Void .cctor(); // 0x06c59ecc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.AmbienceDecorEmitter : WizardGames.Soc.SocClient.Audio.AmbienceEmitter
{
	System.Boolean isPlaying; // 0x40
	System.Void Tick(); // 0x06c59f64
	System.Void Stop(); // 0x06c5a104
	System.Void PlaySound(); // 0x06c59fdc
	System.Void .ctor(); // 0x06c5a1c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.AmbienceEmitter : System.Object
{
	System.Boolean active; // 0x10
	UnityEngine.GameObject emitterGO; // 0x18
	WizardGames.Soc.SocClient.Audio.AmbienceEmitterData data; // 0x20
	System.Single cameraDistanceSq; // 0x28
	UnityEngine.BoundingSphere boundingSphere; // 0x2c
	System.Single deactivateTime; // 0x3c
	System.Void Init(); // 0x06c581d8
	System.Void Tick(); // 0x06c5a228
	System.Void Stop(); // 0x06c5a288
	System.Void .ctor(); // 0x06c57688
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.AmbienceEmitterData : System.Object
{
	System.Int32 id; // 0x10
	System.String eventName; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Audio.AmbienceDefinition> baseAmbienceList; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Audio.AmbienceDefinition> stingList; // 0x28
	System.Boolean isAboveWater; // 0x30
	System.Boolean isFollowCamera; // 0x31
	System.Boolean isBaseEmitter; // 0x32
	System.Void .ctor(); // 0x06c5a2e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.DecorColliderPool : System.Object
{
	System.Collections.Generic.Queue<UnityEngine.GameObject> availableObjects; // 0x10
	System.Void Clear(); // 0x06c5a350
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.MovementSoundTriggerDataPool : System.Object
{
	System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Audio.MovementSoundTriggerData> availableObjects; // 0x10
	System.Int32 maxPoolSize; // 0x18
	System.Void .ctor(System.Int32 maxPoolSize); // 0x06c5a460
	WizardGames.Soc.SocClient.Audio.MovementSoundTriggerData Get(System.String soundEvent, UnityEngine.Vector3 center, System.Single radius); // 0x06c5a530
	System.Void Return(WizardGames.Soc.SocClient.Audio.MovementSoundTriggerData obj); // 0x06c5a8a8
	System.Void Clear(); // 0x06c5a974
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.AmbienceManager : System.Object
{
	UnityEngine.GameObject <MyEntityObj>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Audio.PlayerAkGameObj <MyPlayerAkComponent>k__BackingField; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Audio.AmbienceEmitterData> emitterDatas; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Audio.AmbienceEmitter> emitters; // 0x28
	static System.Collections.Generic.List<WizardGames.Soc.SocClient.Audio.AmbAudioDecorPrecomputeSpawn> spawns; // 0x0
	UnityEngine.GameObject decorColliderRoot; // 0x30
	System.String decorColliderRootName; // 0x38
	static System.String DecorColliderGoName; // 0x8
	WizardGames.Soc.Stl.SocDict<System.Int32,WizardGames.Soc.SocClient.Audio.MovementSoundTriggerData> decorDataDict; // 0x40
	WizardGames.Soc.Stl.SocDict<System.Int32,System.String> instanceIdToPoolKeyMap; // 0x48
	WizardGames.Soc.Stl.SocDict<System.String,WizardGames.Soc.SocClient.Audio.DecorColliderPool> decorColliderPools; // 0x50
	UnityEngine.Transform poolRoot; // 0x58
	WizardGames.Soc.SocClient.Audio.MovementSoundTriggerDataPool triggerDataPool; // 0x60
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Audio.MovementSoundTrigger> soundTriggers; // 0x68
	UnityEngine.GameObject get_MyEntityObj(); // 0x06c5a9f8
	System.Void set_MyEntityObj(UnityEngine.GameObject value); // 0x06c5aa5c
	WizardGames.Soc.SocClient.Audio.PlayerAkGameObj get_MyPlayerAkComponent(); // 0x06c5aadc
	System.Void set_MyPlayerAkComponent(WizardGames.Soc.SocClient.Audio.PlayerAkGameObj value); // 0x06c5ab40
	static WizardGames.Soc.SocClient.Audio.AmbienceEmitter CreateEmitter<T>(UnityEngine.GameObject gameObject, WizardGames.Soc.SocClient.Audio.AmbienceEmitterData ambienceEmitterData); // 0x052af1f0
	System.Void Init(); // 0x06c5abc0
	System.Void Release(); // 0x06c5bc80
	System.Void ClearAllPools(); // 0x06c5bad0
	System.Void AddEmitter(WizardGames.Soc.SocClient.Audio.AmbienceEmitter emitter); // 0x06c5c33c
	System.Void RemoveEmitter(WizardGames.Soc.SocClient.Audio.AmbienceEmitter emitter); // 0x06c56f84
	System.Void CreateEmitters(UnityEngine.GameObject gameObject); // 0x06c5c494
	System.Void ClearEmitters(); // 0x06c5bf44
	static System.Void CreateSpawns(UnityEngine.GameObject gameObject); // 0x06c5c6e0
	static System.Void ClearSpawns(); // 0x06c5c15c
	System.Void AddDecorCollider(System.Int32 instanceId, UnityEngine.GameObject gameObject, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale); // 0x06c5cc4c
	System.Void RemoveDecorCollider(System.Int32 instanceId); // 0x06c5d244
	System.Void AddMovementTrigger(WizardGames.Soc.SocClient.Audio.MovementSoundTrigger trigger); // 0x06c5d40c
	System.Void RemoveMovementTrigger(WizardGames.Soc.SocClient.Audio.MovementSoundTrigger trigger); // 0x06c5d4a8
	System.Void Tick(); // 0x06c5d544
	System.Void LoadAmbienceBaseEmitterData(); // 0x06c5b0a4
	static UnityEngine.AnimationCurve Vec3ArrayToAnimationCurve(WizardGames.Soc.Common.Algorithm.Vector3[] vec3Array); // 0x06c5df5c
	System.Void InitMyEntityObj(); // 0x06c5d794
	System.Void .ctor(); // 0x06c5e0c0
	static System.Void .cctor(); // 0x06c5e344
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.AmbienceSpawnEmitters : System.Object
{
	static System.Int32 baseEmitterCount; // 0x0
	static System.Int32 baseEmitterDistance; // 0x4
	static System.Void CreateMyPlayerEmitter(UnityEngine.GameObject gameObject, WizardGames.Soc.SocClient.Audio.AmbienceEmitterData ambienceEmitterData, System.Collections.Generic.List<WizardGames.Soc.SocClient.Audio.AmbienceEmitter>& emitters); // 0x06c5cacc
	static System.Void .cctor(); // 0x06c5e408
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.MovementSoundTrigger : UnityEngine.MonoBehaviour
{
	System.String Sound; // 0x30
	UnityEngine.Collider collider; // 0x38
	static UnityEngine.Vector3 offset; // 0x0
	System.Collections.Generic.HashSet<UnityEngine.GameObject> Contents; // 0x40
	System.Collections.Generic.Dictionary<UnityEngine.GameObject,UnityEngine.Vector3> LastPositionByObject; // 0x48
	static System.Single MAX_DISTANCE = 2;
	System.Boolean isPlaying; // 0x50
	System.Void OnTriggerEnter(UnityEngine.Collider other); // 0x06c5e458
	System.Void OnTriggerExit(UnityEngine.Collider other); // 0x06c5e6ac
	System.Void OnPlayerEnter(UnityEngine.GameObject other); // 0x06c5e5b8
	System.Void OnPlayerExit(UnityEngine.GameObject other); // 0x06c5e80c
	System.Void Tick(System.Boolean force); // 0x06c5e9c0
	System.Void PlaySound(UnityEngine.GameObject obj); // 0x06c5edcc
	static UnityEngine.Vector3 GetObjPosition(UnityEngine.GameObject obj); // 0x06c5e8dc
	System.Void OnEndOfEvent(); // 0x06c5eee8
	System.Void .ctor(); // 0x06c5ef4c
	static System.Void .cctor(); // 0x06c5f058
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.MovementSoundTriggerData : System.Object
{
	System.String soundEventName; // 0x10
	UnityEngine.Bounds bounds; // 0x18
	UnityEngine.Vector3 position; // 0x30
	Sphere sphereBounds; // 0x3c
	System.Void .ctor(System.String soundEvent, UnityEngine.Vector3 center, System.Single radius); // 0x06c5a78c
	System.Void Reset(System.String soundEvent, UnityEngine.Vector3 center, System.Single radius); // 0x06c5a67c
	System.Boolean get_IsValid(); // 0x06c5f0ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.MovementSoundTriggerBVHAdapter : System.Object, Wwise.Wooduan.BVH.Adapter.IBVHNodeAdapter<WizardGames.Soc.SocClient.Audio.MovementSoundTriggerData>
{
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Audio.MovementSoundTriggerData,Wwise.Wooduan.BVH.BVHNode<WizardGames.Soc.SocClient.Audio.MovementSoundTriggerData>> _triggerToLeafMap; // 0x10
	Wwise.Wooduan.BVH.BVH<WizardGames.Soc.SocClient.Audio.MovementSoundTriggerData> <BVH>k__BackingField; // 0x18
	Wwise.Wooduan.BVH.BVH<WizardGames.Soc.SocClient.Audio.MovementSoundTriggerData> get_BVH(); // 0x06c5f120
	System.Void set_BVH(Wwise.Wooduan.BVH.BVH<WizardGames.Soc.SocClient.Audio.MovementSoundTriggerData> value); // 0x06c5f184
	UnityEngine.Vector3 GetObjPosition(WizardGames.Soc.SocClient.Audio.MovementSoundTriggerData obj); // 0x06c5f204
	System.Void MapObjectToBVHLeaf(WizardGames.Soc.SocClient.Audio.MovementSoundTriggerData obj, Wwise.Wooduan.BVH.BVHNode<WizardGames.Soc.SocClient.Audio.MovementSoundTriggerData> leaf); // 0x06c5f280
	UnityEngine.Bounds GetObjBounds(WizardGames.Soc.SocClient.Audio.MovementSoundTriggerData obj); // 0x06c5f328
	System.Void UnmapObject(WizardGames.Soc.SocClient.Audio.MovementSoundTriggerData obj); // 0x06c5f3bc
	Wwise.Wooduan.BVH.BVHNode<WizardGames.Soc.SocClient.Audio.MovementSoundTriggerData> GetLeaf(WizardGames.Soc.SocClient.Audio.MovementSoundTriggerData obj); // 0x06c5f458
	System.Void .ctor(); // 0x06c5f50c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.MovementSoundTriggerBVHManager : System.Object
{
	static Wwise.Wooduan.BVH.BVH<WizardGames.Soc.SocClient.Audio.MovementSoundTriggerData> bvh; // 0x0
	static UnityEngine.Vector3 offset; // 0x8
	static System.Boolean isPlaying; // 0x14
	static WizardGames.Soc.SocClient.Audio.MovementSoundTriggerBVHAdapter _adapter; // 0x18
	static UnityEngine.Vector3 _lastPlayerPosition; // 0x20
	static System.Collections.Generic.List<Wwise.Wooduan.BVH.BVHNode<WizardGames.Soc.SocClient.Audio.MovementSoundTriggerData>> _queryResults; // 0x30
	static System.Boolean isInDecorLastTime; // 0x38
	static System.Void Init(); // 0x06c5af78
	static System.Void Destroy(); // 0x06c5be58
	static System.Void AddTrigger(WizardGames.Soc.SocClient.Audio.MovementSoundTriggerData triggerData); // 0x06c5cf90
	static System.Void RemoveTrigger(WizardGames.Soc.SocClient.Audio.MovementSoundTriggerData triggerData); // 0x06c5d358
	static System.Void Tick(); // 0x06c5da8c
	static System.Void ProcessTrigger(WizardGames.Soc.SocClient.Audio.MovementSoundTriggerData triggerData, UnityEngine.Vector3 playerPosition); // 0x06c5f6b4
	static System.Void CheckPlayerMovement(WizardGames.Soc.SocClient.Audio.MovementSoundTriggerData triggerData, UnityEngine.Vector3 currentPosition, System.Boolean force); // 0x06c5f7ec
	static System.Void PlaySound(WizardGames.Soc.SocClient.Audio.MovementSoundTriggerData triggerData, UnityEngine.GameObject obj); // 0x06c5f9b4
	static System.Void OnSoundEnd(); // 0x06c5fb04
	static UnityEngine.Vector3 GetObjPosition(WizardGames.Soc.Common.Entity.PlayerEntity obj); // 0x06c5f5c4
	static System.Void .cctor(); // 0x06c5fb8c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.HorseAnimationEvent : UnityEngine.MonoBehaviour
{
	WizardGames.Soc.Common.Unity.Go.ClientSocHorseGo horseGo; // 0x30
	WizardGames.Soc.Common.Entity.HorseEntity horseEntity; // 0x38
	System.Int64 driveEntityId; // 0x40
	UnityEngine.Transform neckTransform; // 0x48
	UnityEngine.Transform footLTransform; // 0x50
	UnityEngine.Transform footRTransform; // 0x58
	UnityEngine.Transform footLFTransform; // 0x60
	UnityEngine.Transform footRFTransform; // 0x68
	System.Single lastFootLTRoll; // 0x70
	System.Single lastFootRTRoll; // 0x74
	System.Single lastFootLFRoll; // 0x78
	System.Single lastFootRFRoll; // 0x7c
	System.Boolean canFootLTCreateEffect; // 0x80
	System.Boolean canFootRTCreateEffect; // 0x81
	System.Boolean canFootLFCreateEffect; // 0x82
	System.Boolean canFootRFCreateEffect; // 0x83
	System.Int32 lastSootEffectId; // 0x84
	WizardGames.Soc.Common.Combat.ColliderMaterialEnum lastColliderMaterial; // 0x88
	Effect.EffectItemHandle<Effect.FollowEffect> sootEffectItemHandle; // 0x90
	System.Single playGruntSoundMinInterval; // 0xa0
	System.Single playGruntSoundMaxInterval; // 0xa4
	System.Single playSaddleSoundMinInterval; // 0xa8
	System.Single playSaddleSoundMaxInterval; // 0xac
	System.Single nextPlayGruntSoundTime; // 0xb0
	System.Single playGruntSoundTimer; // 0xb4
	System.Single nextPlaySaddleSoundTime; // 0xb8
	System.Single playSaddleSoundTimer; // 0xbc
	System.Int32 lastFrameNum; // 0xc0
	System.Int32 footLeftCount; // 0xc4
	System.Int64 verticalSubscribeId; // 0xc8
	System.Boolean isGrounded; // 0xd0
	static System.Single TickRate = 0.1666666716337204;
	System.Single tickTimer; // 0xd4
	System.Void Update(); // 0x055049cc
	System.Void SetData(WizardGames.Soc.Common.Entity.HorseEntity entity, WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent objectPointComponent); // 0x06c608f4
	System.Void Release(); // 0x06c60c40
	System.Void HorseVerticalChange(); // 0x055049cc
	System.Void PlaySootEffect(); // 0x06c60678
	System.Void StopSootEffect(); // 0x06c605b8
	System.Int32 GetSootEffectId(WizardGames.Soc.Common.Combat.ColliderMaterialEnum& materialEnum); // 0x06c6080c
	System.Void JudgePlayFootEffect(); // 0x055049cc
	System.Void PlayFootEffect(UnityEngine.AnimationEvent animationEvent); // 0x05523a54
	System.Void PlayFrontFootSound(); // 0x06c618f8
	System.Void PlayAnimationEvent(UnityEngine.AnimationEvent animationEvent); // 0x06c61b74
	System.Void PlayFootEffect_Internal(UnityEngine.Transform footTransform); // 0x06c6146c
	WizardGames.Soc.Common.Combat.ColliderMaterialEnum GetUnderPositionMaterial(UnityEngine.Vector3 position); // 0x06c60d44
	System.Void .ctor(); // 0x06c61dc8
	System.Void <PlayFrontFootSound>b__43_0(WizardGames.Soc.SocClient.Audio.WWise.AudioEventData eventData, System.Object obj); // 0x06c61e44
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.Process_SignificanceAudioRaycast : Process_SignifiancePlayerBase
{
	System.Collections.Generic.Dictionary<System.Int64,UnityEngine.Vector3> PlayersLastPosition; // 0xb0
	System.Void Init(WizardGames.Soc.Common.Contexts.Context context, System.Int32 PoolSize, SignifianceBucketConf& InBucketConf, SignifianceScoreConf& InScoreConf, System.Collections.Generic.Dictionary<System.Int32,System.Int32> InEntityBaseScore, System.Func<System.Int32,SignifianceBucketConf> InFuncGetBucketConf); // 0x06c61f70
	System.Boolean TryCalcScoreDict(System.Collections.Generic.Dictionary<System.Int64,System.Int32>& scoreDict); // 0x06c62094
	System.Int32 GetEntityBaseScore(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x06c62acc
	System.Void .ctor(); // 0x06c62cb0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.RTPCName : System.Object
{
	static System.String DayNight; // 0x0
	static System.String SpatialAudioLevel; // 0x8
	static System.String Outdoor; // 0x10
	static System.String FloorRelativeHeight; // 0x18
	static System.String Occlusion; // 0x20
	static System.String Elevation; // 0x28
	static System.String AmbVolume; // 0x30
	static System.String RemotePlayerPriority; // 0x38
	static System.String Speed; // 0x40
	static System.String ComunVoiceDuckMaster; // 0x48
	static System.Void .cctor(); // 0x06c62d18
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.StateGroup : System.Object
{
	static System.String MusicMonument; // 0x0
	static System.String MuicBombHome; // 0x8
	static System.String FootStepGroup; // 0x10
	static System.String HealthPoints; // 0x18
	static System.Void .cctor(); // 0x06c62f08
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.StateGroup.AmbienceUnderWater : System.Object
{
	static System.String StateGroup; // 0x0
	static System.String NormalState; // 0x8
	static System.String UnderWaterState; // 0x10
	static System.Void .cctor(); // 0x06c62ff8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.EventName : System.Object
{
	static System.String AmbRoomLP; // 0x0
	static System.String Amb3DSea; // 0x8
	static System.String Amb3DRiver; // 0x10
	static System.String AmbOn; // 0x18
	static System.String AmbOff; // 0x20
	static System.String MUMonument; // 0x28
	static System.String MUBombHome; // 0x30
	static System.Void .cctor(); // 0x06c630b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.AudioGlobalConfig : System.Object
{
	static System.Single FootstepMaxDistanceSqrt; // 0x0
	static System.Single SpatialAudioMaxDistanceSqrt; // 0x4
	static System.Single OcclusionMaxDistance; // 0x8
	static System.Void .cctor(); // 0x06c63228
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.SwitchConstValue : System.Object
{
	static System.String Boots; // 0x0
	static System.String Barefoot; // 0x8
	static System.String Crouch; // 0x10
	static System.Void .cctor(); // 0x06c63280
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.EmitterName : System.Object
{
	static System.String Ambience; // 0x0
	static System.Void .cctor(); // 0x06c63340
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.ClientAudioUtility : System.Object
{
	static SocLogger logger; // 0x0
	static System.Void StopSoundImmediate(WizardGames.Soc.Common.Unity.Audio.GameAudioConf& audioConf, UnityEngine.Transform transform, System.Single fadetime); // 0x06c633a8
	static System.Void OnWarmupProgressUpdate(WizardGames.Soc.Share.Framework.CustomTypeBase entity, UnityEngine.GameObject go, System.Single oldValue, System.Single newValue); // 0x06c6357c
	static System.Void .cctor(); // 0x06c6388c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.AdaptiveLayeredStrategy : System.Object, WizardGames.Soc.SocClient.Audio.IRayStrategy
{
	UnityEngine.Vector3[] phaseOneDirections; // 0x10
	UnityEngine.Vector3[] phaseTwoDirections; // 0x18
	System.Single[] weights; // 0x20
	System.String get_StrategyName(); // 0x06c63960
	System.Int32 get_TotalDirectionCount(); // 0x06c639d8
	System.Void Initialize(); // 0x06c63a3c
	UnityEngine.Vector3 GetDirection(System.Int32 index); // 0x06c63ef0
	System.Void .ctor(); // 0x06c63fbc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.CustomStrategy : System.Object, WizardGames.Soc.SocClient.Audio.IRayStrategy
{
	static SocLogger Logger; // 0x0
	System.String get_StrategyName(); // 0x06c64024
	WizardGames.Soc.SocClient.Audio.EnclosureDetectConfig get_RayConfig(); // 0x06c6409c
	System.Int32 get_TotalDirectionCount(); // 0x06c64134
	System.Void Initialize(); // 0x06c641c4
	UnityEngine.Vector3 GetDirection(System.Int32 index); // 0x06c64224
	System.Void .ctor(); // 0x06c64450
	static System.Void .cctor(); // 0x06c644b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.CustomRayData : System.Object
{
	UnityEngine.Vector3 direction; // 0x10
	System.Single weight; // 0x1c
	System.Void .ctor(UnityEngine.Vector3 dir, System.Single w); // 0x06c64538
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.EnclosureDetectConfig : System.Object
{
	System.String configName; // 0x10
	System.String description; // 0x18
	WizardGames.Soc.SocClient.Audio.RayStrategyType strategyType; // 0x20
	System.Int32 raysPerFrame; // 0x24
	System.Single maxRayDistance; // 0x28
	System.Int32 accumulationFrames; // 0x2c
	UnityEngine.LayerMask raycastMask; // 0x30
	System.Boolean smoothTransition; // 0x34
	System.Single smoothSpeed; // 0x38
	System.Single skyWeight; // 0x3c
	System.Single wallWeight; // 0x40
	System.Single inRoomLimit; // 0x44
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Audio.CustomRayData> customRays; // 0x48
	System.Void InitializeCustomRays(); // 0x06c64698
	System.Void .ctor(); // 0x06c64bdc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.EnclosureDetectConfigIO : System.Object
{
	static SocLogger Logger; // 0x0
	static System.String SaveDirectoryRuntime; // 0x8
	static System.String SaveDirectory; // 0x10
	static WizardGames.Soc.SocClient.Audio.EnclosureDetectConfig LoadConfig(System.String fileName, UnityEngine.TextAsset& textAsset); // 0x06c64fb8
	static System.Void UnloadConfig(UnityEngine.TextAsset config); // 0x06c65360
	static System.Void .cctor(); // 0x06c65400
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Audio.RayStrategyType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Audio.RayStrategyType SixAxisDiagonal = 0;
	static WizardGames.Soc.SocClient.Audio.RayStrategyType Icosahedron = 1;
	static WizardGames.Soc.SocClient.Audio.RayStrategyType EnclosureOptimized = 2;
	static WizardGames.Soc.SocClient.Audio.RayStrategyType AdaptiveLayered = 3;
	static WizardGames.Soc.SocClient.Audio.RayStrategyType Custom = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.EnclosureDetector : System.Object
{
	static SocLogger Logger; // 0x0
	WizardGames.Soc.SocClient.Audio.EnclosureDetectConfig config; // 0x10
	UnityEngine.TextAsset configAsset; // 0x18
	WizardGames.Soc.SocClient.Audio.IRayStrategy currentStrategy; // 0x20
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Audio.RayStrategyType,WizardGames.Soc.SocClient.Audio.IRayStrategy> strategies; // 0x28
	WizardGames.Soc.SocClient.Audio.RayData[] rayDataCache; // 0x30
	System.Int32 currentRayIndex; // 0x38
	UnityEngine.RaycastHit[] raycastHitBuffer; // 0x40
	WizardGames.Soc.SocClient.Audio.EnclosureResult currentResult; // 0x48
	System.Single smoothedLevel; // 0x58
	static WizardGames.Soc.SocClient.Audio.EnclosureDetector _instance; // 0x8
	System.Int32 get_EnclosureLevel(); // 0x06c65548
	static WizardGames.Soc.SocClient.Audio.EnclosureDetector get_Instance(); // 0x06c65680
	System.Void Init(); // 0x06c657f0
	System.Void Destroy(); // 0x06c65e9c
	System.Void LoadDefaultConfig(); // 0x06c65c28
	System.Void Update(); // 0x06c662f8
	System.Void InitializeStrategies(); // 0x06c658a0
	System.Void SwitchStrategy(WizardGames.Soc.SocClient.Audio.RayStrategyType type); // 0x06c65f70
	System.Void CastSingleRay(); // 0x06c66418
	WizardGames.Soc.SocClient.Audio.EnclosureResult CalculateEnclosureResult(); // 0x06c666a4
	System.ValueTuple<System.Single,System.Single> CalculateEnclosureValue(); // 0x06c67414
	System.Single CalculateCompositeScore(System.Single skyOpenness, System.Single wallDensity); // 0x06c67618
	System.Int32 ConvertScoreToLevel(System.Single score); // 0x06c676d0
	UnityEngine.Vector3 GetTargetPosition(); // 0x06c67174
	System.Void .ctor(); // 0x06c65758
	static System.Void .cctor(); // 0x06c6784c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.EnclosureOptimizedStrategy : System.Object, WizardGames.Soc.SocClient.Audio.IRayStrategy
{
	UnityEngine.Vector3[] directions; // 0x10
	System.Single[] weights; // 0x18
	System.String get_StrategyName(); // 0x06c678cc
	System.Int32 get_TotalDirectionCount(); // 0x06c67944
	System.Void Initialize(); // 0x06c679a8
	UnityEngine.Vector3 GetDirection(System.Int32 index); // 0x06c67a08
	System.Void .ctor(); // 0x06c66c30
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.IcosahedronStrategy : System.Object, WizardGames.Soc.SocClient.Audio.IRayStrategy
{
	UnityEngine.Vector3[] directions; // 0x10
	System.Single[] weights; // 0x18
	System.String get_StrategyName(); // 0x06c67aac
	System.Int32 get_TotalDirectionCount(); // 0x06c67b24
	System.Void Initialize(); // 0x06c67b88
	UnityEngine.Vector3 GetDirection(System.Int32 index); // 0x06c68080
	System.Void .ctor(); // 0x06c66bc8
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Audio.IRayStrategy : 
{
	
	System.String get_StrategyName(); // 0x054e7844
	System.Int32 get_TotalDirectionCount(); // 0x0548ba98
	UnityEngine.Vector3 GetDirection(System.Int32 index); // 0x054b1178
	System.Void Initialize(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.RayData : System.Object
{
	static System.Int32 maxCount; // 0x0
	System.Int32 hitCount; // 0x10
	System.Int32 missCount; // 0x14
	System.Collections.Generic.Queue<System.Boolean> results; // 0x18
	System.Single GetHitRate(); // 0x06c677c8
	System.Void SlideWindow(); // 0x06c68124
	System.Void AddHit(); // 0x06c672dc
	System.Void AddMiss(); // 0x06c67378
	System.Void .ctor(); // 0x06c670c0
	static System.Void .cctor(); // 0x06c68250
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Audio.EnclosureResult : System.ValueType
{
	System.Int32 level; // 0x10
	System.Single skyOpenness; // 0x14
	System.Single wallDensity; // 0x18
	System.Single rawScore; // 0x1c
	System.String ToString(); // 0x06c6829c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.SixAxisDiagonalStrategy : System.Object, WizardGames.Soc.SocClient.Audio.IRayStrategy
{
	UnityEngine.Vector3[] directions; // 0x10
	System.Single[] weights; // 0x18
	System.String get_StrategyName(); // 0x06c683b0
	System.Int32 get_TotalDirectionCount(); // 0x06c68428
	System.Void Initialize(); // 0x06c6848c
	UnityEngine.Vector3 GetDirection(System.Int32 index); // 0x06c684ec
	System.Void .ctor(); // 0x06c6674c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.MonsterGunSoundData : System.Object
{
	UnityEngine.GameObject gameObject; // 0x10
	System.UInt32 playingId; // 0x18
	System.Single startEventTime; // 0x1c
	System.Void OnBeginFireEvent(UnityEngine.GameObject emitter, System.String wwiseEvent); // 0x06c68590
	System.Boolean TryResetPlayingAudioEvent(); // 0x06c687e0
	System.Void StopEvent(); // 0x06c68870
	System.Void OnPostEventFinishedCallBack(WizardGames.Soc.SocClient.Audio.WWise.AudioEventData inAudioEventDataData, System.Object cookie); // 0x06c689ac
	System.Void .ctor(); // 0x06c68a38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.GunSoundData : System.Object
{
	System.Int64 weaponId; // 0x10
	System.Int64 entityId; // 0x18
	UnityEngine.GameObject Emitter; // 0x20
	System.String wwiseEvent; // 0x28
	System.UInt32 playingId; // 0x30
	WizardGames.Soc.Common.Unity.Audio.AudioGrp_ShotMode shotMode; // 0x34
	WizardGames.Soc.Common.Unity.Audio.AudioGrp_LoopMode loopStatus; // 0x38
	System.Boolean IsEnd; // 0x3c
	System.Single lastFireEventTime; // 0x40
	System.Void OnBeginFireEvent(System.Int64 weaponId, System.String wwiseEvent, WizardGames.Soc.Common.Unity.Audio.AudioGrp_ShotMode shotMode); // 0x06c68aa0
	System.Void OnPostEventFinishedCallBack(WizardGames.Soc.SocClient.Audio.WWise.AudioEventData inAudioEventDataData, System.Object cookie); // 0x06c691a0
	System.Void OnEndFireEvent(); // 0x06c6922c
	System.Boolean TryResetPlayingAudioEvent(); // 0x06c69330
	System.Void CheckForceStopFiringSound(); // 0x06c693c0
	System.Void FireChangeLoopMode(); // 0x06c68dd0
	System.Void FinishFire(); // 0x06c692b0
	System.Void ResetData(); // 0x06c69534
	System.Void Delete(); // 0x06c6959c
	System.Void StopEvent(); // 0x06c68d24
	System.Void OnGunSoundMarker(); // 0x06c6962c
	System.Void .ctor(); // 0x06c69778
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.GunSoundManager : System.Object
{
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Audio.GunSoundData> gunSoundDataDict; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Audio.GunSoundData> removeSoundDataList; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Audio.MonsterGunSoundData> monsterGunSoundDataList; // 0x20
	System.Void Initialize(); // 0x06c697e0
	System.Void OnFireEvent(System.Int64 entityId, System.Int64 weaponId, UnityEngine.GameObject emitter, System.String eventName, WizardGames.Soc.Common.Unity.Audio.AudioGrp_ShotMode shotMode, WizardGames.Soc.Common.Unity.Audio.AudioGrp_LoopMode loopStatus); // 0x06c699e8
	System.Void OnMonsterFireEvent(UnityEngine.GameObject emitter, System.String eventName); // 0x06c69bcc
	System.Void Update(); // 0x06c69d34
	System.Void .ctor(); // 0x06c6a1b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.MgrAudio : WizardGames.Soc.Common.Unity.Audio.MgrAudioBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Audio.GunSoundManager gunSoundManager; // 0x18
	WizardGames.Soc.SocClient.Audio.AmbienceManager ambienceManager; // 0x20
	System.Boolean IsRustFire; // 0x28
	System.Boolean IsTestAudio; // 0x29
	System.Boolean bEnableFootstepBucket; // 0x2a
	System.UInt32 BGMPlayingId; // 0x2c
	System.UInt32 BombHomeBGMPlayingId; // 0x30
	System.Void Init(); // 0x06c6a218
	System.Void Destroy(); // 0x06c6a5b4
	System.Void SetMaxVoicesLimit(System.Int32 maxVoicesLimit); // 0x06c6a61c
	System.Void SetVolumeThreshold(System.Int32 volumeThreshold); // 0x06c6a6e8
	System.Void InitCamera(); // 0x06c6a7b4
	System.Void SetRTPCValue(System.String RTPCName, System.Single value, UnityEngine.GameObject emitter); // 0x06c6a8ec
	System.Void SetAmbValue(System.Single value); // 0x06c6a9b0
	System.Void SetAmbEnable(System.Boolean enable); // 0x06c6aa50
	System.Void PlayFireEvent(System.Int64 entityId, System.Int64 weaponId, UnityEngine.GameObject emitterGo, System.String audioEventName, WizardGames.Soc.Common.Unity.Audio.AudioGrp_ShotMode shotMode, WizardGames.Soc.Common.Unity.Audio.AudioGrp_LoopMode loopStatus, UnityEngine.Vector3 spatialPos); // 0x06c6ab74
	System.Void SetMusicVolume(System.Single value); // 0x06c6ae6c
	System.Void SetSoundVolume(System.Single value); // 0x06c6af7c
	System.Void SetMasterVolume(System.Single value); // 0x06c6b08c
	System.Void SetUIVolume(System.Single value); // 0x06c6b19c
	System.Void SetQuickTalkVolume(System.Single value); // 0x06c6b2ac
	System.Void MusicEnabled(System.Boolean isTurnOn); // 0x06c6b3bc
	System.Void SoundEnabled(System.Boolean isTurnOn); // 0x06c6b45c
	System.Void MasterEnable(System.Boolean isTurnOn); // 0x06c6b4fc
	System.Void UIEnable(System.Boolean isTurnOn); // 0x06c6b59c
	System.Void QuickTalkEnable(System.Boolean isTurnOn); // 0x06c6b63c
	AkGameObj GetAkGameObj(UnityEngine.GameObject gameObject); // 0x06c6b6dc
	static System.Void PlayAudioEventAsync(System.String eventName); // 0x06c6b7cc
	static System.Void PlayAudioEventAsync(System.String eventName, UnityEngine.GameObject gameObject, System.String group, System.String switchState, WizardGames.Soc.SocClient.Audio.WWise.AudioEventData.PostEventFinishedCallback postEventStartedCallback, WizardGames.Soc.SocClient.Audio.WWise.AudioEventData.PostEventFinishedCallback postEventFinishedCallback, System.Int64 entityId, System.Object cookie); // 0x06c686cc
	static System.Void PlayAudioEventAsync(System.String eventName, UnityEngine.Vector3 pos, System.String group, System.String switchState, WizardGames.Soc.SocClient.Audio.WWise.AudioEventData.PostEventFinishedCallback postEventStartedCallback, WizardGames.Soc.SocClient.Audio.WWise.AudioEventData.PostEventFinishedCallback postEventFinishedCallback, System.Int64 entityId, System.Single audioPlayTime, System.Object cookie); // 0x06c6b880
	static System.Void PlayAudioEventAsync(System.String eventName, UnityEngine.GameObject gameObject, AkCallbackType callbackType, WizardGames.Soc.SocClient.Audio.WWise.AudioEventData.EPlayType playType, System.Action callbackAction, WizardGames.Soc.SocClient.Audio.WWise.AudioEventData.PostEventFinishedCallback postEventStartedCallback, WizardGames.Soc.SocClient.Audio.WWise.AudioEventData.PostEventFinishedCallback postEventFinishedCallback, System.Int64 entityId, System.Object cookie); // 0x06c68f84
	static System.Void PauseEvent(System.String eventName, UnityEngine.GameObject emitter, System.Single fadeOutTime); // 0x06c6b9c0
	static System.Void ResumeEvent(System.String eventName, UnityEngine.GameObject emitter, System.Single fadeInTime); // 0x06c6ba7c
	static UnityEngine.GameObject GetAudioEmitter(UnityEngine.Vector3 position, System.Boolean useSpatialAudio); // 0x06c6bb38
	static System.Int64 GetSoundOwnerId(UnityEngine.GameObject gameObject); // 0x06c6bc00
	static System.Void OnAudioPlay(System.String eventName, UnityEngine.Vector3 position, WizardGames.Soc.SocClient.Audio.WWise.AudioEventData.EPosType posType, UnityEngine.GameObject gameObject, System.Int64 entityId); // 0x06c6909c
	System.UInt32 PlayAudioEvent(UnityEngine.GameObject gameObject, System.String eventName, System.String group, System.String switchState); // 0x06c6ad7c
	System.Void SetAudioSwitch(UnityEngine.GameObject gameObject, System.String group, System.String switchState); // 0x06c69470
	System.Void SetAudioState(System.String group, System.String state, UnityEngine.GameObject source); // 0x06c6bf40
	System.Boolean IsSwitchAt(System.String switchGroup, System.String switchState, UnityEngine.GameObject emitter); // 0x06c6c004
	System.Void StopWwiseAudio(System.UInt32 playingId); // 0x06c6890c
	System.Void StopWwiseEvent(System.String eventName, UnityEngine.GameObject emitter, System.Single fadeOutTime); // 0x06c6c0c8
	System.Threading.Tasks.Task OnEnterWorld(); // 0x054e7844
	System.Threading.Tasks.Task OnExitWorld(); // 0x054e7844
	System.Void OnDeadEnter(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x06c6c598
	System.Void OnDeadLeave(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x06c6c740
	System.Void PlayVehicleRepairSuccessSound(System.Int64 entityId); // 0x06c6c8e8
	System.Void .ctor(); // 0x06c6cb2c
	static System.Void .cctor(); // 0x06c6cbc0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Audio.PlayerAkGameObj : AkGameObj
{
	WizardGames.Soc.Common.Unity.Go.ClientPlayerGo _player; // 0xc8
	System.Void SetData(WizardGames.Soc.Common.Unity.Go.ClientPlayerGo player); // 0x06c6cc94
	UnityEngine.Vector3 GetPosition(); // 0x06c6cd8c
	System.Void .ctor(); // 0x06c6ced8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Animation.AnimationCurveRefHandle : System.Object
{
	UnityEngine.AnimationCurve Curve; // 0x10
	System.Int32 refCnt; // 0x18
	System.Void .ctor(); // 0x06c6cf40
}

// Client.Runtime
class WizardGames.Soc.SocClient.Animation.SocAnimCache : System.Object
{
	static System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip,UnityEngine.AnimationClip>> overrides; // 0x0
	static WizardGames.Soc.Common.Unity.Animation.SMBAnimData FpSMB; // 0x8
	static System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Unity.Animation.SMBAnimData> TpSmbGroup; // 0x10
	static CommonUnity.Runtime.Animation.ClientAnim fpAnimData; // 0x18
	static System.Collections.Generic.Dictionary<System.Int64,CommonUnity.Runtime.Animation.ClientAnim> TpAnimGroup; // 0x20
	static System.Collections.Generic.Dictionary<System.Int32,CommonUnity.Runtime.Animation.ClientAnimatorCache> animtorCache; // 0x28
	static System.Collections.Generic.Dictionary<System.IntPtr,WizardGames.Soc.SocClient.Animation.AnimationCurveRefHandle> CurveCache; // 0x30
	static CommonUnity.Runtime.Animation.ClientAnimatorCache GetOrCreateAnimatorCache(UnityEngine.Animator animator); // 0x06c6cfa8
	static CommonUnity.Runtime.Animation.ClientAnimatorCache GetOrCreateAnimatorCache(System.Int32 animatorId); // 0x06c6d144
	static System.Void AddCurve(UnityEngine.AnimationCurve curve); // 0x06c6d288
	static System.Void RemoveCurve(System.IntPtr curvePtr); // 0x06c6d420
	static System.Void Clear(); // 0x06c6d54c
	static System.Void .cctor(); // 0x06c6d9e4
}

// Client.Runtime
class WizardGames.Soc.SocClient.ActionExecutor.ClientLadderAPI : System.Object
{
	static SocLogger logger; // 0x0
	static System.Void Init(); // 0x06c6dbe8
	static System.Void OnUiClickLadder(WizardGames.Soc.SocClient.Ui.ELadderClickEvent clickEvent); // 0x06c6dce0
	static System.Void Destroy(); // 0x06c6dfdc
	static System.Void .cctor(); // 0x06c6e0d4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.ActionExecutor.BattleItemCheckRule : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.ActionExecutor.BattleItemCheckRule CanUse = 0;
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.ActionExecutor.BattleItemCheckParams : System.ValueType
{
	System.Int64 entityId; // 0x10
	System.Int64 tableId; // 0x18
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.ActionExecutor.BattleItemCheckResult : System.ValueType
{
	EItemDisableReason Reason; // 0x10
	System.Boolean CanSwitch; // 0x14
	System.Boolean get_IsSuccess(); // 0x06c6e1a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.ActionExecutor.HeldItemAPI : System.Object
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.SocClient.ActionExecutor.HeldItemCacheContext _context; // 0x8
	static WizardGames.Soc.SocClient.ActionExecutor.BattleItemCheckResult CheckItemByRule(WizardGames.Soc.SocClient.ActionExecutor.BattleItemCheckRule rule, System.Int64 tableId); // 0x06c6e21c
	static WizardGames.Soc.SocClient.ActionExecutor.BattleItemCheckResult CheckItemByRule(WizardGames.Soc.SocClient.ActionExecutor.BattleItemCheckRule rule, WizardGames.Soc.SocClient.ActionExecutor.BattleItemCheckParams checkParams); // 0x06c6e308
	static System.Void Init(); // 0x054fd168
	static System.Void EquipWeapon(System.Int64 oldEquipId, System.Int64 newEquipId); // 0x054fe8c8
	static System.Void Dispose(); // 0x054fd168
	static System.Void ForceDirty(); // 0x054fd168
	static System.Void Update(); // 0x054fd168
	static System.Void PostUpdate(WizardGames.Soc.SocClient.ActionExecutor.BattleItemUsableCache cache); // 0x055049cc
	static System.Void .cctor(); // 0x06c70b00
}

// Client.Runtime
class WizardGames.Soc.SocClient.ActionExecutor.BattleItemUsableCache : System.Object
{
	System.Nullable<WizardGames.Soc.Common.Data.DataItem.ItemArea> EntityArea; // 0x10
	System.Boolean CanUse; // 0x18
	EItemDisableReason Reason; // 0x1c
	System.Int64 ItemTableId; // 0x20
	System.Boolean inited; // 0x28
	System.Boolean TryUpdateUsable(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, System.Nullable<WizardGames.Soc.Common.Data.DataItem.ItemArea> itemarea); // 0x054e0c84
	System.Void .ctor(); // 0x06c71088
}

// Client.Runtime
class WizardGames.Soc.SocClient.ActionExecutor.HeldItemCacheContext : System.Object
{
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.ActionExecutor.BattleItemUsableCache> ItemUsableCaches; // 0x10
	System.Collections.Generic.HashSet<System.Int64> UsableDirtyItemIds; // 0x18
	System.Boolean InitUsable; // 0x20
	System.Boolean Dirty; // 0x21
	System.Void Init(); // 0x06c6e664
	System.Void UpdateItemUsable(System.Int64 targetId); // 0x06c6f508
	System.Void Clear(); // 0x06c6ea28
	System.Void .ctor(); // 0x06c6e5fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.ActionExecutor.MgrClientActionExecutor : WizardGames.Soc.Common.ActionExecutor.MgrBaseActionExecutor
{
	
	System.Void RegisterActionExecutor(); // 0x06c710f0
	System.Void .ctor(); // 0x06c71298
}

// Client.Runtime
class WizardGames.Soc.SocClient.ActionExecutor.PlayEffectExecutor : System.Object, WizardGames.Soc.Common.ActionExecutor.IActionExecutor
{
	static SocLogger logger; // 0x0
	System.Void Execute(System.Int64 targetId, WizardGames.Soc.Common.Data.ActionBase actionBase, WizardGames.Soc.Common.ActionExecutor.ActionParams actionParams); // 0x06c71324
	System.Void .ctor(); // 0x06c71230
	static System.Void .cctor(); // 0x06c716ac
}

// Client.Runtime
class <PrivateImplementationDetails> : System.Object
{
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 038658D4BD137139A5BD11D5492991D42994BB1639217F9F9C53BE8D4BD7F87D; // 0x0
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 093A2EC27C56653691EB7DA04ED0081A289221392A5A4BAE1221AED06F9CAEA5; // 0x18
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 0C1B8C42ECCDA6A536D65E587E0E2C84CA0BE2053761EC2153AAF5004FB4B97C; // 0x28
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 0C9E05F5966919B1EF177F5B2C6AAAC38B5C77CFE33BA9C25AFCE52948EBC2E2; // 0x54
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 0D6607001398B4F0B0F584E6EF881C201F50BFC4E8E5691A4A20B109C3E85BE8; // 0x64
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=388 0E66290612B0EC90F75E0576F31E4AE6AFBCBA5CC474E98FC8BCED93ED25B144; // 0x94
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 0FC1BF142AB9B69911BAF9AAC14B2888249E1EDD7EEEB4DDF4C4B792FA2C4CB5; // 0x218
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 1972761DF6B9E75804DD0B5123A00C0C0BCE9C2AB10C359038270356AD5D476F; // 0x224
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 1B8E1F9C575D616318E76AFC872970DD4751C1EC5FB162C46CFAFA946121F81D; // 0x240
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 1BE87C0991AC04D6D78729ED1751AF91BB1F5C67CCA742C90ACCA4046BFC105C; // 0x260
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 1D85C18E1D32E52B7BF2FBF0A0148CC825262804ADEC17348B24F2504ED1E4C5; // 0x26c
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=96 23E0B72672FAAA037127AB34F828A096E2779581DBD12D9A9EBF3414F75B60EA; // 0x2c8
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 274CF6A74CD9E4B79D562BBB1E0C70CBD4BFD3CFAC500BD787938BF5085CCC80; // 0x328
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 29450C28965E40169F99DF16D769673DF9CE8F7D5EFB3959EC81642AD034502E; // 0x340
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 2A7012D26AC3359FC95FDC6C7D068DAE42FD949475DF1E6F48074D679C94B103; // 0x354
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 2B69BDEF2023F18B5E5D14F098A03CA40ACB96C835D9FC3A917DD84C053F0E25; // 0x360
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 2C41EBF13D4FEEC3C0D221A929A5D3A3B5CD147FEA519E595B743D659EC7A3A8; // 0x394
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 2E22B7F66D3AB0C103F4C76DAB100637AA6238533A1C80FDD6CE32EFC77A2AF4; // 0x3a0
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 30330C71DA9D286F1B2F1FE32729C5982C0BCC9A9358B4388DEDC59FED85DF01; // 0x3ac
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 318348E593EAD7B568EFC75871430E6177C189867EF5EC33CDECC22F92D60BE9; // 0x3bc
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=112 3865E2834591EF3FB069AC1B98D41D756BB90D9D45E7B693C4FCF850641483F8; // 0x3f4
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 38A66BED3C5AB3CD094BD0E366BEC44FC30945BD4B54AD39538B88FFFE79C166; // 0x464
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 3E820574818A9DA25808D70D52BB3F1A2CE38344DDD353093E133E76F0F1070C; // 0x48c
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 417454EFAA8CEC72B1986400FD26A13803975A25A58894FEFAE85C7C47AA35ED; // 0x4a4
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 44C0EDF241B9BB8F4A2E3E1C77869A118D885919AE1A96CC76966B9305A15C5D; // 0x4b0
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=112 47E47ECCB8298AB9D832E26A4A9E9B65901FCEE5213430FAE9FFFFD2887C0B4E; // 0x4bc
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 4DBB3250353F5BB0CE005809614AD7FE2E183E3E15645AADFFBBE3ECB53EE124; // 0x52c
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 4EBAE3BA5F5C4CA175E526A1F72854701F77F9C49463869B4325721A61D03284; // 0x538
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 520C2C8072AF592057302F8B842CF6B42DEB544112290090EE43692A12AF362C; // 0x544
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 53BFB09A8803B408833184310D7A89203A1665BF87CC3BDF75E5CD512C94352D; // 0x558
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 56AC6FDE9F6744D68AF84E79489D7E3D51C064CD80C6ABF344A6765D334002F4; // 0x584
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 573FEB7B754F49D8C6777CA1811291FD52ECE31DC2D21CD933BBCFFDA3F615E0; // 0x594
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 583A4D27359901480ECFD24F964F7CEF60E5771480301B94340900A45AEADC21; // 0x5a0
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 5C70E82F1AA94F954DE898ED60AEA5697582704EF54538699E42C807F5DFB6B3; // 0x5b8
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 5E6B90074C277FAF95C6713DEA0866FB8BC76E86B979136D7BA8AA32B249FA05; // 0x614
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 600F16C94146F640FE5FA4325992B398CC3695EE3256A7EF056B5F2C5D7D8A12; // 0x624
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 61F9756A16B63992D78ADA2F16501F2635B04D1EBCCC7D32705682929651980A; // 0x638
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=180 64C17E223E6F2DEFFADD2E7148300E987BE1A565F2C888FB0F8C769FF5B00B5D; // 0x668
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 66FBFD1C9C88BE49737AD2652A6E49B16A097CCBF3282E03A00B1F01D71EF09D; // 0x71c
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 6BCFD69920C1C24456CDDF62986FF60BA5A240B3CF4CC33A3B899297CAF4D231; // 0x734
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 6C9B7308D94C487B8F1D82348F890FF6BE15D5E3C5765E4F909D74A4ED7EF7C3; // 0x740
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 76D5609992E8C8609325F0F42380418DCD495FF40CE8C47EA6D16AA00489D642; // 0x750
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 7995499A977E22CD1A23C22367F56804E4DD54193E6BFACC851EA2A071EDCD39; // 0x75c
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 7DC7F158DFB8102F36F6DF3AEFC5A36429F2DDFA8683AC2A14BDAEA25FA6DD8B; // 0x78c
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 7E620CCBBFE1254FB7150FD73A2D4F62C37897F3AA5CDC9D44CFF4B027BE9F5B; // 0x7a4
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 80C1FC66A1AD7AB61BA049CA60276ED63C5D02E2C470C6D08C4005246CAD55C1; // 0x7b0
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 82AA167EE73107066B56803315231691C93ECCAB14262B4FC7266FC72789D0BD; // 0x7c0
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 8307A3F61AC439ABA0D0E7CCF041DEA173697E734775BD1D4BB0BD524FE37031; // 0x7cc
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=112 88A5490F27396CB0C4858F2B5D9D8825844C21B27C09CF03193C07122E971A61; // 0x80c
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=212 88B2CB3B5E05E343E53AA0A4273C616037FEE0196D2E21502D99FFD0C54DE7B2; // 0x87c
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 8A854FDCDBAEB2FE4703556AA90945A04AD5F47AB56D4C1B189F9169596995FC; // 0x950
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 8E36EF1674062018C93EE8CAB6F78FAB8E2D5DC86A705C7637C8089745AF7914; // 0x95c
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 9079F99E4E1BD45EE49AA47972BF3EFAEC402B4ABEF7BDE466E55AC392DB0F8C; // 0x968
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 923335162FCB66EA30E77E9DDAB7A578D3F83149EF035C388B32DEECD4644279; // 0x980
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=96 9523A8968B883D87F6D2814BCA9BD4933C52DB347420050531B23CDD0E9C6C91; // 0x9b4
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=188 953449A6B9E19642286B141BB56D734A69D65A3F0268EA43840AD60820B67EA2; // 0xa14
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 962D0A6954A594AED9254D6BED3E5ED3EE0181A40143F330A7A57660FFE2C003; // 0xad0
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=420 984D5091504B4AB01BD5C13A4C3BEF62326CE7209940CF85684FF92FAE6853AB; // 0xaec
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 98B9AEE7F43BF7E5C6984B31A1EEB6682313160526577B2C7208044A56839F27; // 0xc90
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 9C5081D62BE5D9545021E043EA681F2C6CA67973883CB0DE0A192A89E253B0E2; // 0xca4
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=156 9E627C1E4B7FBA50E85EA26EFCB182FBBCD17A011980EA70EE21918C10FFA51C; // 0xcd8
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 A3718549859263CBE60C2B7BBB39D486A18C6613874C8B6BFD9DCF37306271CE; // 0xd74
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 A4953AD5C6F3D90D4F921BB3A8F8419F9B64C29982D806626E9F6C7A7E6BDD05; // 0xd84
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 A57E3E9A58CC62EA13B9369F5F004F72F06CE3203D05BD34948773075A199D5C; // 0xd90
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 A589705FB6173393394DF960F6B8B46E232974C1A1AB313EABB8DF42469BCA33; // 0xdbc
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 A7DF1CC4F070690D9CA9D738A41A37EF42EFDBD7B0A3EEA81E6E9BB2E66E0F00; // 0xdd4
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 A8A59AE8FAEA33E89A449ADD4D462B997D459C357243EE1B9ADF658506765B22; // 0xde8
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 A9BD7C0F250F3206BEB045671AB4171F27A46862F4E06B634C803653ABCE3D78; // 0xdf8
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 AA63EF165ACB367F9CADD33EDF44B9416F7279A4E72C01B5B6EC2A90084C40B0; // 0xe20
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 AB8873867A85D704C5D9DF479C92AB6AF5FA94605FBCF9F6618A2A9D35F28DB3; // 0xe30
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 AE33D015344C5A395AAE6F59139E3C65F0E51FE1E9625685C2C0EF0E4C89C47D; // 0xe44
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=510 B2D7F9A24D36D8D9C34F819CDAF4C3621AEAB37F1F101B0B50608C242000DCE4; // 0xe50
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 B31FEA3127C3E7F39FCF7C98D2080D9D2F656C8D44B66F9B27B2DF0A38950FA9; // 0x104e
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 B33C3F2CCB85061758575BA530C0F4BCCB10DDC22BBE9948108D1A0BD6C3A236; // 0x108e
	static System.Int64 B4BCAC3C8C4F70F4831D7A63D3A275D0A9CD2A150AC80A728EA8A16D6BC39BCB; // 0x10b0
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=192 B6133A2C5545EE33DECC059EAA26E2BE0CE853054F67599396DAEE62FA84B61C; // 0x10b8
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 B767878065379B5CD991511D9381DBC197D5D5EEFF6CFA08EDA85ED0BD76078A; // 0x1178
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 BC2211C844F32ED582E861452604EB3E3D1D15DE7EC610D63DB948E880494984; // 0x118c
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 BCBC01A5036673E493422616677A83718EDFE475D3E938B1A879903FFB2A05A0; // 0x119c
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=188 BD4E770AD9E9BEEE9B3D474FDE0DC8E3F4F510FE2289DAD66E2B4E971C0341A8; // 0x11a8
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 BDD2BAEC2C3548E24C0B7044F5997C70A957B8F4931942535BFA8E7DFE7B616B; // 0x1264
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 C1B4B7F2893BB40556AB60D88101762AC23D1AC3AE3AD3E0C3B211D796E51830; // 0x127c
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 C8F135065492794314BE7945723DC0DEC19DE68E655C5E2CDE5E10332A10C593; // 0x1290
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 CABD38625BCDC77E29779911DDE686AC15E845970DAB5C5EA5A336FBB825AD55; // 0x12bc
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=84 CB4D16C6ECDAC52A8E250C7377BF1D9D7B4B89071C141942232AF3F799CFABA9; // 0x12d4
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 CC2338287C028EE84CDCF4B5A971C0B2303B54CA7808B97D9C6A03CC8A8A2716; // 0x1328
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=512 CCB0205485A8CADF60BBBB5561134441676D32EE97B108F7F65A707B34340871; // 0x133c
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 CCFCB6FB2DB2B4A6BC824B6043EC0CF1ADFA992D25E48414681E7D7E75975E10; // 0x153c
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 CD01F2D7DD324BF27B57EB35A9D72A4861F71A915D4168A6E655377A51AD5DA1; // 0x154c
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 CD9A54ED1F18BF97DB08914E280EA7349E11CA2C4885A4D8052552CEBA84208D; // 0x156c
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 CEB8A1E28D22921006650EEAE7DF43AD59610CB2C8D7BBD8794AA8BCCAE0156F; // 0x1584
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 D167B421EDAA6C6483471D6D3656AF3D984CA34DB157D990A090F782CE03358A; // 0x1598
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 D252CAC237656C50BA523F10050FF1B0CA780D71EEA31F88D96E0695BC674BCD; // 0x15bc
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 D4FDBD27F2F064D6DA59AD1ABA55259655680CB4ABAFEE9A09A006CCE0296091; // 0x15d0
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 D54EDDA986279DDAC65634231CF7CAA0BA40C04CF2EEEC2CB2C0B1F6F075076B; // 0x15ec
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 DAADB7F0561F01453D61C116B92D78E479F1D0A33351A47AE218108AAF22E249; // 0x162c
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=160 DC6AE9512BB3AF24ACEB9E678593CBF1FAF050107DDA40578FEC321E6AAA2DA0; // 0x1638
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 DCBB075E6F923CA1AA92C889A3AF2FE9CB506D1164F0EF64722DA29F085EFE9D; // 0x16d8
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=420 E25B83A1CF626D83030C0ABE866A4D2C54B4E17792A4D91F24BDF135B2123D26; // 0x16e8
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 E2E2033AE7E19D680599D4EB0A1359A2B48EC5BAAC75066C317FBF85159C54EF; // 0x188c
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 E37B32408AB4FF031FAAD47BC91093BD84D60FE77D3E6259C972DEFAF1C64976; // 0x18a4
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 E3D25E7590EDD76206831801F67D1EE231D8B90A2BB4BFE31A152BE21D2F536C; // 0x18b0
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 E492237B56EEE39C0FD835D3A44B86CC5B2D8BC3CC78D451AB7BAE3A5B07A49B; // 0x18d4
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=212 EB5F3001B9785D1972095E6CEF1F65A8D2013E70996CE2CCF6C52DFF8DC90ABF; // 0x18f8
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 EB949415A1179FF7865E343E5B3A79485BD0E44325C28121AE4588E17A073103; // 0x19cc
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 ECBA2122156A808BDE18081D84D63AB3A825436FF2F22F485E81059F94C2D48D; // 0x19e4
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 EDBAAF16D3C2B9F3CDF97D787E4239DD224E7B8F58E1F7059F9B8AA74545C7CB; // 0x19fc
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 EDF1B0AD8B11A3C8EEA98D4BC38883EC3799FE67F757423196BF4CA42F7BC8BE; // 0x1a0c
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 F5750D5BC801F4D0F2E7CC2F84806554D03FBB25E55E77D859918796B652E6A4; // 0x1a9c
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=140 F5DBDDD03DAF4DC4F7D3CA97069884BD941E596F644C99B608B7190850FD690B; // 0x1aa8
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 F69A0928047E7ABF8DA6AAD9078915641287F9C04576340423C1B8D342895032; // 0x1b34
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=84 F7AE58B863F08E25A2D75CF11654561F3F3F06EE05CC990C4DEC3BA7D601CB03; // 0x1b44
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=96 FA4B7DACF3D8C32EB14882D78E4DD69BDE25897C55C5CB9F07461BBD26C19EFA; // 0x1b98
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=100 FAD9FD9A11DD2E5B68652BF2735AEE51C6F5B5B07DE6B611DC5F3F2715366360; // 0x1bf8
	static System.Int64 FC8CBCD0FFA2324D0A5B5A618B834D49CC1E57386A9C4D5BDD3B7F99EBF0BCEF; // 0x1c60
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 FDA443F3799189289F33B0EC746241A3B52A640BBEA4BC83C323BD0B3643B00B; // 0x1c68
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 FDE2AEEAEE6E1097F812A86342D178FFDC552CC24C0559A02B25524E9BF49D88; // 0x1c74
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 FFB510E39A6066CAB1757A049B1E861EEF06F51D9C2654154F1550849E645312; // 0x1c94
	static <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 FFCD168F8E1B9368DB923B4681449ED48FBBD9BAB646294F3EEE13A21BE8175A; // 0x1cbc
	static System.UInt32 ComputeStringHash(System.String s); // 0x06c71780
	static System.Void ThrowSwitchExpressionException(System.Object unmatchedValue); // 0x06c71848
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=84 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=92 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=96 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=100 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=112 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=140 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=156 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=160 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=180 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=188 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=192 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=212 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=388 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=420 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=510 : System.ValueType
{
	
	
}

// Client.Runtime
struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=512 : System.ValueType
{
	
	
}

// Client.Runtime
class __JobReflectionRegistrationOutput__634015576441986764 : System.Object
{
	
	static System.Void CreateJobReflectionData(); // 0x06c718d4
	static System.Void EarlyInit(); // 0x06c71b6c
}

