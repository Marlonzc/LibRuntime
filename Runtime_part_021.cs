// Client.Runtime
struct WizardGames.Soc.SocClient.SceneLoader.ClientSceneLoader.<LoadSceneAsync>d__0 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.Common.Unity.Scene.SceneName scene; // 0x30
	WizardGames.Soc.SocClient.SceneLoader.ClientSceneLoader.<>c__DisplayClass0_0 <>8__1; // 0x38
	System.Action onSuccess; // 0x40
	System.Runtime.CompilerServices.TaskAwaiter<System.ValueTuple<System.Boolean,System.String>> <>u__1; // 0x48
	System.Void MoveNext(); // 0x058cc3e8
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x058ccd30
}

// Client.Runtime
class WizardGames.Soc.SocClient.RuleGraph.RuleGraphDebug : UnityEngine.MonoBehaviour
{
	static WizardGames.Soc.SocClient.RuleGraph.RuleGraphDebug Instance; // 0x0
	System.Boolean isConnect; // 0x30
	System.Void Awake(); // 0x058ccdd4
	System.Void OnDestroy(); // 0x058ccf08
	static System.Void Init(); // 0x058cd038
	System.Void OnAddGraphDebugEntitySuccess(); // 0x058cd20c
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.GraphDebugInfo> GetDebugInfo(); // 0x058cd274
	System.Void AddListener(System.Action<WizardGames.Soc.Share.Framework.ECustomDictOpType,System.Int64,WizardGames.Soc.Common.CustomType.GraphDebugInfo> callback); // 0x058cd534
	System.Void RemoveListener(System.Action<WizardGames.Soc.Share.Framework.ECustomDictOpType,System.Int64,WizardGames.Soc.Common.CustomType.GraphDebugInfo> callback); // 0x058cd6a0
	System.Void HotUpdateGraphCfg(System.String fileName); // 0x058cd80c
	System.Void tryConnectDebug(); // 0x058cd3b8
	System.Void .ctor(); // 0x058cd930
}

// Client.Runtime
class WizardGames.Soc.SocClient.Reputation.MgrReputation : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> lv2BadgeSlot; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> nextUnlockDic; // 0x20
	System.Collections.Generic.HashSet<System.Int64> equipBadgeSet; // 0x28
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Reputation.BadgeSlotData> slotDataDic; // 0x30
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Reputation.BadgeData> badgeDataDic; // 0x38
	System.Collections.Generic.List<System.Int64> badgePath; // 0x40
	System.Collections.Generic.List<System.Int64> equipPath; // 0x48
	System.Collections.Generic.List<System.Int64> canGetRewardTasks; // 0x50
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Data.Reputation.ReputationBadgeConfig> taskIdToBadgeIdDIc; // 0x58
	System.Int32 reputationTaskId; // 0x60
	System.Boolean isOpenCabinetWnd; // 0x64
	System.Int32 <FatigueValue>k__BackingField; // 0x68
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.ReputRwdConfig>> rewardsPerLevel; // 0x70
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.Common.Data.itemReward.ItemDrop>> defaultRewardsPerLevel; // 0x78
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Reputation.ReputationLevelConfig> gameRewardList; // 0x80
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Reputation.ReputationLevelConfig> lobbyRewardList; // 0x88
	System.Boolean isOpenFromCabinet; // 0x90
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Reputation.BadgeData> badgeDatas; // 0x98
	System.Void InitSlotData(); // 0x058cd998
	System.Int32 GetMaxSlots(); // 0x058cda94
	System.Void InitTaskToBadgeInfo(); // 0x058cdaf8
	System.Void InitBadgeDataFromTable(); // 0x058cdce4
	System.Void RefreshSlotData(); // 0x058ce3f4
	System.Void GetSlos(System.Collections.Generic.List<WizardGames.Soc.SocClient.Reputation.BadgeSlotData>& list); // 0x058ce93c
	System.Void RegisterSlotData(); // 0x058cea38
	System.Void RefreshCompletedAndNotGetTask(); // 0x058ceb9c
	System.Void ShowUnlockNewBadge(System.Int64 taskId); // 0x058ced18
	System.Void GetBadges(System.Collections.Generic.List<WizardGames.Soc.SocClient.Reputation.BadgeData>& list, System.Int64 selectId); // 0x058ceebc
	System.Void GetBadgesByInventory(System.Collections.Generic.List<WizardGames.Soc.SocClient.Reputation.BadgeData>& list); // 0x058cf194
	WizardGames.Soc.SocClient.Reputation.BadgeData GetBadgeById(System.Int64 id); // 0x058cf578
	System.Void RegisterBadgeData(); // 0x058cf62c
	System.Void RefreshBadgeData(); // 0x058cf790
	System.Int32 GetUnlockSlotNum(); // 0x058cfcb8
	System.Boolean Equiped(System.Int64 id); // 0x058cfdfc
	System.Void ResetBadges(); // 0x058cfa78
	System.Void ResetSlots(); // 0x058ce7ac
	System.Int32 GetUnlockLevelBySlot(System.Int32 slot); // 0x058cff50
	System.Void RequestBadgeUnlock(System.Int64 badgeId); // 0x058d0080
	System.Void RequestBadgeEquip(System.Int64 badgeId, System.Int32 slot); // 0x058d0160
	System.Int32 GetUnlockBadgeNum(); // 0x058d024c
	System.Int32 GetUnEquippedBadgeNum(); // 0x058d0498
	System.Int32 GetCanUnlockBadgeNum(); // 0x058d0760
	System.Void set_FatigueValue(System.Int32 value); // 0x058d0998
	System.Int32 get_FatigueValue(); // 0x058d0a10
	WizardGames.Soc.Common.CustomType.BriefTerritoryInfo GetOpenCabinet(); // 0x058d0a74
	System.Boolean GetOpenCabinetDebris(); // 0x058d0df8
	System.String GetCabinetPosStr(); // 0x058d1178
	WizardGames.Soc.Common.Component.TerritoryCabinetComponent GetTerritoryCabinet(); // 0x058d1360
	System.Int64 GetCabinetId(); // 0x058d142c
	System.Void StartLooting(); // 0x058d15e8
	System.Void OnStartLootingBack(System.Int64 cabinetId); // 0x058d1744
	System.Void EndLooting(); // 0x058d17e4
	WizardGames.Soc.Common.Component.ReputationComponent GetReputationCom(); // 0x058d188c
	System.Int32 GetCabinetLevel(); // 0x058d1934
	System.Int32 GetInputContainerCount(System.Int64 itemId); // 0x058d1d68
	WizardGames.Soc.Common.CustomType.BaseItemNode GetInputContainerNode(System.Int64 itemId); // 0x058d1e58
	WizardGames.Soc.Common.CustomType.BaseItemNode GetOutputContainerNode(System.Int64 itemId); // 0x058d1f48
	System.Int64 GetConvertRemainingTime(); // 0x058d2038
	System.Int64 GetConverTimeByItem(System.Int32 itemId, System.Int32 count); // 0x058d2114
	System.Int32 GetPlayerReputationExp(System.Int32 allExp, System.Int32 level); // 0x058d2358
	System.Boolean CheckCommit(); // 0x058d24f8
	System.Void RequestFatigue(); // 0x058d2a2c
	System.Void UpdateFatigue(); // 0x058d2b60
	System.Void OnMissionChange(); // 0x058d2c58
	WizardGames.Soc.Common.Component.ReputationComponent get_ReputationCom(); // 0x058d2dd8
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int32,WizardGames.Soc.Common.CustomType.ReputationReward> get_GameRewardStateDic(); // 0x058d2ef4
	WizardGames.Soc.Share.Framework.BasicTypeHashSet<System.Int32> get_LobbyRewardStateList(); // 0x058d2f68
	System.Boolean CanGetGameReward(System.Int32 level); // 0x058d2fdc
	System.Int32 get_Level(); // 0x058cfd70
	System.Int32 get_ReputationMax(); // 0x058d2844
	System.Threading.Tasks.Task AfterEnterWorld(); // 0x058d314c
	System.Void OnInit(); // 0x058d3548
	System.Void Destroy(); // 0x058d3764
	System.Void InitRewardData(); // 0x058d3250
	System.Int32 GetReputationExpConverRatio(); // 0x058d398c
	System.Void OnBattleRewardChange(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.Int32 level, WizardGames.Soc.Common.CustomType.ReputationReward _); // 0x058d3c18
	System.Void OnLobbyRewardChange(WizardGames.Soc.Share.Framework.ECustomHashSetOpType opType, System.Int32 level); // 0x058d3d20
	System.Void OnReputationLevelChange(); // 0x058d3e14
	System.Void CleanUp(); // 0x058d3ed0
	System.Threading.Tasks.Task OnEnterWorld(); // 0x058d3f48
	System.Threading.Tasks.Task OnExitWorld(); // 0x058d3fb8
	System.Void InitRewardsPerLevelDara(); // 0x058d31f0
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Reward> GetDropRewardByDropId(System.Int32 dropId); // 0x058d4020
	System.Boolean CheckBadgeBoxRedDot(); // 0x058d4158
	System.Boolean CheckShowStoryInfoRed(); // 0x058d43a8
	System.Boolean CheckSelectBadgeRedDot(); // 0x058d4510
	System.Boolean CheckUnlockBadgeRedDot(); // 0x058d4738
	System.Boolean CheckCanGetReward(); // 0x058d47a8
	System.Void GetShowStageId(WizardGames.Soc.SocClient.Ui.UiReputationRewardWnd.ERepuationRewardType rewardType, System.Int32& level, System.Int32& stageId); // 0x058d4890
	System.Void .ctor(); // 0x058d4d50
	System.Void <RequestFatigue>b__60_0(SimpleJSON.JSONNode json); // 0x058d5320
}

// Client.Runtime
class WizardGames.Soc.SocClient.Reputation.MgrReputation.<>c__DisplayClass20_0 : System.Object
{
	WizardGames.Soc.Common.Component.ReputationComponent comp; // 0x10
	System.Int64 weightA; // 0x18
	System.Int64 weightB; // 0x20
	System.Void .ctor(); // 0x058cf510
	System.Int32 <GetBadgesByInventory>b__0(WizardGames.Soc.SocClient.Reputation.BadgeData a, WizardGames.Soc.SocClient.Reputation.BadgeData b); // 0x058d53dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Reputation.BadgeData : System.Object
{
	WizardGames.Soc.Common.Data.Reputation.ReputationBadgeConfig <Config>k__BackingField; // 0x10
	WizardGames.Soc.Common.CustomType.ReputationBadgeNode <Node>k__BackingField; // 0x18
	WizardGames.Soc.Common.Data.Play.QuestPhase <TaskCfg>k__BackingField; // 0x20
	WizardGames.Soc.Common.Data.Reputation.ReputationBadgeConfig get_Config(); // 0x058d573c
	System.Void set_Config(WizardGames.Soc.Common.Data.Reputation.ReputationBadgeConfig value); // 0x058d57a0
	WizardGames.Soc.Common.CustomType.ReputationBadgeNode get_Node(); // 0x058d5820
	System.Void set_Node(WizardGames.Soc.Common.CustomType.ReputationBadgeNode value); // 0x058d5884
	WizardGames.Soc.Common.Data.Play.QuestPhase get_TaskCfg(); // 0x058d5904
	System.Void set_TaskCfg(WizardGames.Soc.Common.Data.Play.QuestPhase value); // 0x058d5968
	System.Void .ctor(WizardGames.Soc.Common.Data.Reputation.ReputationBadgeConfig cfg); // 0x058ce1f4
	System.Void Refresh(WizardGames.Soc.Common.CustomType.ReputationBadgeNode badge); // 0x058cfc04
	System.Boolean get_Valid(); // 0x058d568c
	System.Boolean get_IsUnlocked(); // 0x058d03e8
	System.Boolean get_IsEquiped(); // 0x058d0658
	System.Boolean get_CanUnlock(); // 0x058d08fc
	System.Boolean get_NumLimited(); // 0x058d59e8
	System.Boolean get_LevelLimited(); // 0x058d5b34
	System.Boolean get_CanShow(); // 0x058cf130
	System.Int32 get_Progress(); // 0x058d5c2c
	System.String get_ProgressStr(); // 0x058d5dbc
	System.Void Reset(); // 0x058cfe98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Reputation.BadgeSlotData : System.Object
{
	WizardGames.Soc.Common.CustomType.ReputationBadgeSlotNode node; // 0x10
	System.Int64 slot; // 0x18
	System.Void .ctor(System.Int64 slot); // 0x058d64f4
	System.Void Refresh(WizardGames.Soc.Common.CustomType.ReputationBadgeSlotNode data); // 0x058d6578
	System.Void Reset(); // 0x058d65f8
	System.Boolean get_IsEquiped(); // 0x058d6664
	System.Boolean get_IsUnlocked(); // 0x058d66d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.DampingMixerMotion : System.Object, WizardGames.Soc.SocClient.Player.ILogicMotion, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	WizardGames.Soc.SocClient.Player.ILogicMotion CurrentMotion; // 0x10
	System.Single LastValue; // 0x18
	System.Single Blend; // 0x1c
	System.Single progress; // 0x20
	static WizardGames.Soc.SocClient.Player.DampingMixerMotion Create(); // 0x058d677c
	System.Void SetMotion(WizardGames.Soc.SocClient.Player.ILogicMotion motion, System.Single blend); // 0x058d6810
	System.Void Update(System.Single dt); // 0x058d69ac
	System.Single GetValue(); // 0x058d6aa0
	System.Void Release(); // 0x058d6bd4
	System.Void OnGet(); // 0x058d6cf0
	System.Void OnRelease(); // 0x058d6d50
	System.Void OnDestroy(); // 0x058d6db0
	System.Void .ctor(); // 0x058d6e10
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Player.IDampingGear : 
{
	
	System.Single GetGearValue(WizardGames.Soc.SocClient.Player.DampingMotion motion); // 0x054a6f88
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Player.DampingMotionParams : System.ValueType
{
	System.Single Amplitude; // 0x10
	System.Single RigidityRatio; // 0x14
	System.Single DampingRatio; // 0x18
	System.Single InitialPhase; // 0x1c
	System.Boolean isCos; // 0x20
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.DampingMotion : System.Object, WizardGames.Soc.SocClient.Player.ILogicMotion, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	WizardGames.Soc.Common.Utility.DampingProcessor DampingProcessor; // 0x10
	WizardGames.Soc.SocClient.Player.DampingMotionParams <Params>k__BackingField; // 0x20
	System.Single <Elapsed>k__BackingField; // 0x34
	WizardGames.Soc.SocClient.Player.IDampingGear Gear; // 0x38
	static WizardGames.Soc.SocClient.Player.DampingMotion Create(WizardGames.Soc.SocClient.Player.DampingMotionParams dampingParams); // 0x058d6e78
	System.Void set_Params(WizardGames.Soc.SocClient.Player.DampingMotionParams value); // 0x058d70c8
	WizardGames.Soc.SocClient.Player.DampingMotionParams get_Params(); // 0x058d715c
	System.Void set_Elapsed(System.Single value); // 0x058d71e0
	System.Single get_Elapsed(); // 0x058d7258
	System.Void Init(WizardGames.Soc.SocClient.Player.DampingMotionParams p); // 0x058d6f58
	System.Void SetGear(WizardGames.Soc.SocClient.Player.IDampingGear gear); // 0x058d72bc
	System.Void Update(System.Single dt); // 0x058d733c
	System.Single GetValue(); // 0x058d74e8
	System.Void Release(); // 0x058d7658
	System.Void OnGet(); // 0x058d7754
	System.Void OnRelease(); // 0x058d77b4
	System.Void OnDestroy(); // 0x058d7814
	System.Void .ctor(); // 0x058d7874
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.FpHeldItemBreatheMotionController : System.Object
{
	WizardGames.Soc.SocClient.Player.DampingMixerMotion xMixerMotion; // 0x10
	WizardGames.Soc.SocClient.Player.DampingMixerMotion yMixerMotion; // 0x18
	System.Int64 BreathStartTime; // 0x20
	WizardGames.Soc.Common.Data.gun.Gunsway BreatheConfig; // 0x28
	System.Void Init(); // 0x055049cc
	System.Void Release(); // 0x055049cc
	System.Void OnCharacterAdsStateChange(System.Int64 entityId, WizardGames.Soc.Common.Entity.PlayerAdsStateEnum oldState, WizardGames.Soc.Common.Entity.PlayerAdsStateEnum newState); // 0x058d7e6c
	System.Void OnMoveStateChangeAction(System.Int64 entityId, WizardGames.Soc.Common.Entity.PlayerMoveStateEnum oldState, WizardGames.Soc.Common.Entity.PlayerMoveStateEnum newState); // 0x058d8164
	WizardGames.Soc.SocClient.Player.ILogicMotion GetMotion(System.Int32 vsId, System.Single rate); // 0x058d8008
	System.Void OnHeldItemChange(WizardGames.Soc.Common.Entity.IHeldItemEntity helditem); // 0x058d7b00
	System.Void UpdateBreathe(System.Single dt); // 0x058d8288
	System.Void .ctor(); // 0x058d84a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.FpHeldItemMoveMotionController : System.Object, WizardGames.Soc.SocClient.Player.IDampingGear
{
	System.Single Transition; // 0x10
	System.Single xozSpeed; // 0x14
	WizardGames.Soc.Common.Data.gun.GunMovesway MoveSwayConfig; // 0x18
	WizardGames.Soc.SocClient.Player.DampingMotion xDampingMotion; // 0x20
	WizardGames.Soc.SocClient.Player.DampingMotion yDampingMotion; // 0x28
	WizardGames.Soc.SocClient.Player.DampingMotion pitchDampingMotion; // 0x30
	WizardGames.Soc.SocClient.Player.DampingMotion yawDampingMotion; // 0x38
	System.Void Init(); // 0x055049cc
	System.Void ResetData(); // 0x058d8b54
	System.Void Release(); // 0x055049cc
	System.Void OnCharacterAdsStateChange(System.Int64 entityId, WizardGames.Soc.Common.Entity.PlayerAdsStateEnum oldState, WizardGames.Soc.Common.Entity.PlayerAdsStateEnum newState); // 0x058d8dc8
	System.Void OnMoveStateChangeAction(System.Int64 entityId, WizardGames.Soc.Common.Entity.PlayerMoveStateEnum oldState, WizardGames.Soc.Common.Entity.PlayerMoveStateEnum newState); // 0x058d8e58
	System.Void OnHeldItemChange(WizardGames.Soc.Common.Entity.IHeldItemEntity helditem); // 0x058d8704
	System.Boolean GetGunSwayConfig(System.Int32 id, WizardGames.Soc.Common.Data.gun.GunGunsway& config); // 0x058d8ee8
	System.Boolean GetViewSwayConfig(System.Int32 id, WizardGames.Soc.Common.Data.gun.GunViewsway& config); // 0x058d9010
	System.Single GetGearValue(WizardGames.Soc.SocClient.Player.DampingMotion motion); // 0x058d9138
	System.Void Update(System.Single dt); // 0x05513724
	System.Void .ctor(); // 0x058d99b8
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Player.ILogicMotion : 
{
	
	System.Void Update(System.Single dt); // 0x05513724
	System.Single GetValue(); // 0x054a5abc
	System.Void Release(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.ADSAnimController : System.Object
{
	WizardGames.Soc.Common.Entity.PlayerEntity playerEntity; // 0x10
	UnityEngine.Transform cameraLocator; // 0x18
	UnityEngine.Transform viewPoint; // 0x20
	UnityEngine.Transform directionLocator; // 0x28
	WizardGames.Editor.FpClipSettingMeta Setting; // 0x30
	UnityEngine.Matrix4x4 Sight2Root; // 0x38
	UnityEngine.Matrix4x4 Root2Attach; // 0x78
	UnityEngine.Vector3 initDirectorLP; // 0xb8
	UnityEngine.Quaternion initDirectorLQ; // 0xc4
	UnityEngine.Vector3 initScale; // 0xd4
	UnityEngine.Matrix4x4 InitS2D; // 0xe0
	UnityEngine.Vector3 AdsCamOffset; // 0x120
	UnityEngine.Vector3 lastDAnimpos; // 0x12c
	UnityEngine.Vector3 lastDRealpos; // 0x138
	System.Boolean UseAnim; // 0x144
	System.Boolean UseDetail; // 0x145
	System.Boolean ZWithGunFovChange; // 0x146
	System.Single ZOffset; // 0x148
	System.Single AdsUpZChangeStart; // 0x14c
	System.Single AdsUpZChangeEnd; // 0x150
	System.Single AdsDownZChangeStart; // 0x154
	System.Single AdsDownZChangeEnd; // 0x158
	System.Single zstart; // 0x15c
	System.Single zend; // 0x160
	UnityEngine.Vector3 DirectorFromLocalPosition; // 0x164
	UnityEngine.Quaternion DirectorFromLocalRotation; // 0x170
	WizardGames.Soc.SocClient.Player.ADSAnimTransition AnimTransition; // 0x180
	UnityEngine.Vector3 <FinalADSDirectionLocalPosition>k__BackingField; // 0x188
	UnityEngine.Vector3 <FinalADSDirectionLocalEular>k__BackingField; // 0x194
	System.Single AnimLerpDuration; // 0x1a0
	System.Single AnimLerpProgress; // 0x1a4
	UnityEngine.Vector3 get_FinalADSDirectionLocalPosition(); // 0x058d9a20
	System.Void set_FinalADSDirectionLocalPosition(UnityEngine.Vector3 value); // 0x058d9a88
	UnityEngine.Vector3 get_FinalADSDirectionLocalEular(); // 0x058d9b24
	System.Void set_FinalADSDirectionLocalEular(UnityEngine.Vector3 value); // 0x058d9b8c
	System.Void Init(); // 0x058d9c28
	System.Void ResetAds(); // 0x058d9e20
	System.Void OnUpdateAdsProperty(WizardGames.Soc.SocClient.Player.HeldItem.PlayerFpWeaponGo weapon); // 0x058da0a0
	System.Void SwitchADS(WizardGames.Soc.Common.Entity.PlayerAdsStateEnum oldState, WizardGames.Soc.Common.Entity.PlayerAdsStateEnum newState); // 0x058daf60
	System.Void Update(System.Single dt); // 0x058db4a8
	System.Void LateUpdate(WizardGames.Soc.SocClient.Player.IADSTransition gunFovTrans, System.Single gunfovlerp); // 0x05527688
	System.Void DirectionLocatorRealOffset(UnityEngine.Vector3 scale, UnityEngine.Vector3 posOffset, UnityEngine.Quaternion rotOffset, UnityEngine.Vector3& realPosOffset, UnityEngine.Quaternion& realRotOffset); // 0x058dc8b8
	System.Void .ctor(); // 0x058dcb44
	static System.Single <OnUpdateAdsProperty>g__calc|39_0(System.Single real, System.Single origin); // 0x058daed4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.ADSAnimTransition : System.Object, WizardGames.Soc.SocClient.Player.IADSTransition
{
	static SocLogger logger; // 0x0
	System.Boolean <IsADSOn>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Player.ADSTransitionFactor Factor; // 0x18
	System.Boolean get_IsADSOn(); // 0x058dcd78
	System.Void set_IsADSOn(System.Boolean value); // 0x058dcddc
	System.Single get_RawProgress(); // 0x058db404
	System.Single get_TransitionProgress(); // 0x058db700
	System.Single get_ADSPosition(); // 0x058db7a4
	System.Void Init(System.Boolean isOn, System.Single transitionTime, System.Single startProgress); // 0x058d9e98
	System.Void Update(System.Single dt); // 0x058db67c
	System.Void .ctor(); // 0x058dccdc
	static System.Void .cctor(); // 0x058dd320
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.ADSFovTransition : System.Object, WizardGames.Soc.SocClient.Player.IFovTransition, WizardGames.Soc.SocClient.Player.IADSTransition
{
	static SocLogger logger; // 0x0
	System.Boolean <IsADSOn>k__BackingField; // 0x10
	System.Single <FOV>k__BackingField; // 0x14
	System.Single <BlendInDuration>k__BackingField; // 0x18
	System.Single From; // 0x1c
	System.Single To; // 0x20
	WizardGames.Soc.SocClient.Player.ADSTransitionFactor Factor; // 0x28
	System.Boolean get_IsADSOn(); // 0x058dd3f4
	System.Void set_IsADSOn(System.Boolean value); // 0x058dd458
	System.Single get_FOV(); // 0x058dd4d4
	System.Void set_FOV(System.Single value); // 0x058dd538
	System.Single get_BlendInDuration(); // 0x058dd5b0
	System.Void set_BlendInDuration(System.Single value); // 0x058dd614
	System.Void Init(System.Boolean isOn, System.Single from, System.Single to, System.Single transitionTime, System.Single startProgress, System.Single blendInDuration, UnityEngine.AnimationCurve curve); // 0x058dd68c
	System.Void Update(System.Single dt); // 0x058ddab4
	System.Single get_RawProgress(); // 0x058ddbf8
	System.Single get_ADSPosition(); // 0x058ddc9c
	System.Void .ctor(); // 0x058ddde8
	static System.Void .cctor(); // 0x058dde84
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.ADSTransitionFactor : System.Object
{
	System.Single <Progress>k__BackingField; // 0x10
	System.Single <TransitionProgress>k__BackingField; // 0x14
	System.Single TransitionTime; // 0x18
	UnityEngine.AnimationCurve TransitionCurve; // 0x20
	System.Single get_Progress(); // 0x058ddf58
	System.Void set_Progress(System.Single value); // 0x058ddfbc
	System.Single get_TransitionProgress(); // 0x058de034
	System.Void set_TransitionProgress(System.Single value); // 0x058de098
	System.Void Init(System.Single transitionTime, System.Single startProgress, UnityEngine.AnimationCurve curve); // 0x058dce58
	System.Void Update(System.Single dt); // 0x058dcf50
	System.Void .ctor(); // 0x058dd2b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItemFovController : System.Object
{
	static SocLogger logger; // 0x0
	System.Single LastFov; // 0x10
	System.Single <FOV>k__BackingField; // 0x14
	WizardGames.Soc.SocClient.Player.IFovTransition transition; // 0x18
	System.Single blendTime; // 0x20
	System.Single get_FOV(); // 0x058de110
	System.Void set_FOV(System.Single value); // 0x058de174
	System.Single get_BlendProgress(); // 0x058de1ec
	System.Void SetFOV(System.Single fov); // 0x058de3a8
	System.Void SetTransition(WizardGames.Soc.SocClient.Player.IFovTransition transition); // 0x058de584
	System.Void Update(System.Single dt); // 0x058de654
	System.Void .ctor(); // 0x058de8f4
	static System.Void .cctor(); // 0x058de95c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItemFovTransition : System.Object, WizardGames.Soc.SocClient.Player.IFovTransition
{
	System.Single <FOV>k__BackingField; // 0x10
	System.Single <BlendInDuration>k__BackingField; // 0x14
	System.Single get_FOV(); // 0x058dea30
	System.Void set_FOV(System.Single value); // 0x058dea94
	System.Single get_BlendInDuration(); // 0x058deb0c
	System.Void set_BlendInDuration(System.Single value); // 0x058deb70
	System.Void .ctor(System.Single fov, System.Single blendInDuration); // 0x058debe8
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Player.IADSTransition : 
{
	
	System.Single get_RawProgress(); // 0x054a5abc
	System.Single get_ADSPosition(); // 0x054a5abc
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Player.IFovTransition : 
{
	
	System.Single get_FOV(); // 0x054a5abc
	System.Single get_BlendInDuration(); // 0x054a5abc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.PlayerBoneManager : System.Object
{
	WizardGames.Soc.Common.Entity.PlayerEntity playerEntity; // 0x10
	UnityEngine.Transform cameraLocator; // 0x18
	UnityEngine.Transform directionLocator; // 0x20
	UnityEngine.Transform viewPoint; // 0x28
	UnityEngine.Transform baseLocator; // 0x30
	UnityEngine.Transform accessoriesHat; // 0x38
	UnityEngine.Vector3 directionAngle; // 0x40
	UnityEngine.Vector3 directionPosition; // 0x4c
	UnityEngine.Vector3 SightLocatorOffset; // 0x58
	System.Boolean valid; // 0x64
	UnityEngine.Vector3 initDirectorLP; // 0x68
	UnityEngine.Quaternion initDirectorLQ; // 0x74
	Unity.Mathematics.double4x4 initS2D; // 0x88
	UnityEngine.Quaternion initS2Drot; // 0x108
	UnityEngine.Vector3 dprepos; // 0x118
	UnityEngine.Vector3 dprepos1; // 0x124
	UnityEngine.Vector3 sprepos; // 0x130
	System.Void .ctor(); // 0x058ded10
	System.Void Init(); // 0x058dedc0
	System.Void InitBone(); // 0x058dee30
	System.Void Release(); // 0x058df0b4
	System.Void AddDirectionAngle(UnityEngine.Vector3& angle); // 0x058df118
	System.Void AddDirectionPosition(UnityEngine.Vector3& pos); // 0x058d840c
	System.Void LateUpdateDirectionLocator(); // 0x058df1ac
	System.Void ResetDirectionLocator(); // 0x058df324
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.PlayerGrassInteractiveManager : UnityEngine.MonoBehaviour
{
	System.Single height; // 0x30
	System.Single radius; // 0x34
	System.Single touchBendingStrength; // 0x38
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer myPlayer; // 0x40
	WizardGames.Soc.Common.Entity.PlayerEntity playerEntity; // 0x48
	UnityEngine.Vector3 lastPos; // 0x50
	System.Void Init(); // 0x058df430
	System.Void Update(); // 0x058df4f0
	System.Void OnDestroy(); // 0x058df6e0
	System.Void .ctor(); // 0x058df74c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.BaseFpInteractiveDisplayNode : System.Object, WizardGames.Soc.SocClient.Player.Interactive.IInteractiveDisplayNode, WizardGames.Soc.Common.ObjPool.IRecyclable, WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemBatchLoaderHandler
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo PlayerGo; // 0x10
	UnityEngine.GameObject bindGo; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo> AssetLoadInfos; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo> PrefabLoadInfos; // 0x28
	WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader loader; // 0x30
	WizardGames.Soc.Common.Data.character.PlayerInteractiveState <Config>k__BackingField; // 0x38
	System.Single EnterTime; // 0x40
	WizardGames.Soc.Common.Data.character.PlayerInteractiveState get_Config(); // 0x058df7cc
	System.Void set_Config(WizardGames.Soc.Common.Data.character.PlayerInteractiveState value); // 0x058df830
	System.Void Init(WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058df8b0
	System.Void FillResPath(System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& assets, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& prefabs); // 0x058df9dc
	System.Void OnBatchLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader load); // 0x05523a54
	System.Void OnInit(); // 0x058dff90
	System.Void OnEnter(); // 0x058dfff0
	System.Void OnUpdate(System.Single dt); // 0x058e0194
	System.Void OnExit(); // 0x058e0208
	System.Void ClearLoadInfos(); // 0x058e06fc
	System.Void Release(); // 0x058e08d0
	System.Void OnGet(); // 0x058e0970
	System.Void OnRelease(); // 0x058e09d0
	System.Void OnDestroy(); // 0x058e0ad8
	System.Void .ctor(); // 0x058e0b38
	static System.Void .cctor(); // 0x058e0c1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeCollectWater : WizardGames.Soc.SocClient.Player.Interactive.BaseFpInteractiveDisplayNode
{
	System.Boolean valid; // 0x44
	System.Int32 state; // 0x48
	System.Single stateStartTime; // 0x4c
	WizardGames.Soc.Common.CustomType.WaterBottleItemNode Bottle; // 0x50
	System.Int64 subscribeid; // 0x58
	static WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeCollectWater Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058e0cf0
	System.Void OnInit(); // 0x058e0dc0
	System.Void OnEnter(); // 0x058e1364
	System.Void OnUpdate(System.Single dt); // 0x058e145c
	System.Void OnSubStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase player, System.Byte oldstate, System.Byte newstate); // 0x058e19d0
	System.Void OnExit(); // 0x058e1bbc
	System.Void Release(); // 0x058e1dd0
	System.Void .ctor(); // 0x058e1ef0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeCure : WizardGames.Soc.SocClient.Player.Interactive.BaseFpInteractiveDisplayNode
{
	System.Int64 subscribeid; // 0x48
	System.Int64 entityId; // 0x50
	WizardGames.Soc.Common.Data.holdItem.MedicalBase medicalBase; // 0x58
	System.Boolean valid; // 0x60
	WizardGames.Soc.Common.Entity.IHeldItemEntity helditem; // 0x68
	static WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeCure Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058e1f78
	System.Void OnInit(); // 0x058e2048
	System.Void OnEnter(); // 0x058e2410
	System.Void OnExit(); // 0x058e269c
	System.Void Release(); // 0x058e29a4
	System.Void OnSubStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase player, System.Byte oldstate, System.Byte newstate); // 0x058e2abc
	System.Void .ctor(); // 0x058e2fa0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeDrinkWater : WizardGames.Soc.SocClient.Player.Interactive.BaseFpInteractiveDisplayNode
{
	
	static WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeDrinkWater Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058e3028
	System.Void OnEnter(); // 0x058e30f8
	System.Void OnExit(); // 0x058e3368
	System.Void Release(); // 0x058e3598
	System.Void .ctor(); // 0x058e3638
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeGesture : WizardGames.Soc.SocClient.Player.Interactive.BaseFpInteractiveDisplayNode
{
	
	static WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeGesture Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058e36c0
	System.Void Release(); // 0x058e3790
	System.Void .ctor(); // 0x058e3838
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeGugujiCard : WizardGames.Soc.SocClient.Player.Interactive.BaseFpInteractiveDisplayNode
{
	
	static WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeGugujiCard Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058e38c0
	System.Void OnEnter(); // 0x058e3990
	System.Void OnExit(); // 0x058e3d90
	System.Void Release(); // 0x058e3e74
	System.Void .ctor(); // 0x058e3f14
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeGugujiMsg : WizardGames.Soc.SocClient.Player.Interactive.BaseFpInteractiveDisplayNode
{
	UnityEngine.GameObject Card; // 0x48
	Effect.EffectItemHandle<Effect.EffectItem> followEffectHandle; // 0x50
	static WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeGugujiMsg Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058e3f9c
	System.Void FillResPath(System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& assets, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& prefabs); // 0x058e406c
	System.Void OnBatchLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader load); // 0x058e420c
	System.Void Release(); // 0x058e4798
	System.Void .ctor(); // 0x058e48ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeInspection : WizardGames.Soc.SocClient.Player.Interactive.BaseFpInteractiveDisplayNode
{
	System.String inspectionSound; // 0x48
	static WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeInspection Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058e4934
	System.Void OnInit(); // 0x058e4a04
	System.Void OnEnter(); // 0x058e4c6c
	System.Void OnExit(); // 0x055049cc
	System.Void Release(); // 0x058e5904
	System.Void .ctor(); // 0x058e59a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeInspection.<>c__DisplayClass3_0 : System.Object
{
	WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerFpHeldItemGo helditego; // 0x10
	WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeInspection <>4__this; // 0x18
	System.Void .ctor(); // 0x058e5330
	System.Void <OnEnter>b__0(System.Int64 id, System.Object data, System.Boolean delete); // 0x058e5a2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeNewbieGuguji : WizardGames.Soc.SocClient.Player.Interactive.BaseFpInteractiveDisplayNode
{
	System.Int32 state; // 0x44
	System.Int64 subscribeid; // 0x48
	System.Single stateStartTime; // 0x50
	static WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeNewbieGuguji Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058e5e40
	System.Void OnInit(); // 0x058e5f10
	System.Void OnEnter(); // 0x058e6044
	System.Void OnUpdate(System.Single dt); // 0x058e61d8
	System.Void OnSubStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase player, System.Byte oldstate, System.Byte newstate); // 0x058e6418
	System.Void OnExit(); // 0x058e6544
	System.Void Release(); // 0x058e6668
	System.Void .ctor(); // 0x058e6770
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeOpenDoor : WizardGames.Soc.SocClient.Player.Interactive.BaseFpInteractiveDisplayNode
{
	System.Boolean played; // 0x44
	static WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeOpenDoor Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058e67f8
	System.Void OnEnter(); // 0x058e68c8
	System.Void OnExit(); // 0x058e6b70
	System.Void Release(); // 0x058e6c68
	System.Void .ctor(); // 0x058e6d0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodePickup : WizardGames.Soc.SocClient.Player.Interactive.BaseFpInteractiveDisplayNode
{
	System.Boolean played; // 0x44
	static WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodePickup Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058e6d94
	System.Void OnEnter(); // 0x058e6e64
	System.Void OnExit(); // 0x058e7104
	System.Void Release(); // 0x058e71fc
	System.Void .ctor(); // 0x058e72a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodePourWater : WizardGames.Soc.SocClient.Player.Interactive.BaseFpInteractiveDisplayNode
{
	System.Boolean valid; // 0x44
	System.Int32 state; // 0x48
	WizardGames.Soc.Common.CustomType.WaterBottleItemNode Bottle; // 0x50
	static WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodePourWater Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058e7328
	System.Void OnInit(); // 0x058e73f8
	System.Void OnEnter(); // 0x058e77a4
	System.Void OnUpdate(System.Single dt); // 0x058e78a4
	System.Void OnExit(); // 0x058e7918
	System.Void Release(); // 0x058e7a14
	System.Void .ctor(); // 0x058e7acc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodePushVehicle : WizardGames.Soc.SocClient.Player.Interactive.BaseFpInteractiveDisplayNode
{
	
	static WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodePushVehicle Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058e7b54
	System.Void Release(); // 0x058e7c24
	System.Void .ctor(); // 0x058e7cc4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeRepair : WizardGames.Soc.SocClient.Player.Interactive.BaseFpInteractiveDisplayNode
{
	UnityEngine.GameObject Hammer; // 0x48
	static WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeRepair Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058e7d4c
	System.Void FillResPath(System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& assets, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& prefabs); // 0x058e7e1c
	System.Void OnBatchLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader load); // 0x058e807c
	System.Void Release(); // 0x058e8554
	System.Void .ctor(); // 0x058e8604
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeSpray : WizardGames.Soc.SocClient.Player.Interactive.BaseFpInteractiveDisplayNode
{
	UnityEngine.GameObject can; // 0x48
	Effect.EffectItemHandle<Effect.EffectItem> followEffectHandle; // 0x50
	static WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeSpray Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058e868c
	System.Void FillResPath(System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& assets, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& prefabs); // 0x058e875c
	System.Void OnBatchLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader load); // 0x058e88c4
	System.Void Release(); // 0x058e8da0
	System.Void .ctor(); // 0x058e8eb4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeSwipeCard : WizardGames.Soc.SocClient.Player.Interactive.BaseFpInteractiveDisplayNode
{
	UnityEngine.GameObject Card; // 0x48
	static WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeSwipeCard Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058e8f3c
	System.Void OnInit(); // 0x058e900c
	System.Void FillResPath(System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& assets, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& prefabs); // 0x058e9200
	System.Void OnBatchLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader load); // 0x058e94ec
	System.Void OnEnter(); // 0x058e98c0
	System.Void OnExit(); // 0x058e99a0
	System.Void Release(); // 0x058e9ad4
	System.Void .ctor(); // 0x058e9b84
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeTelescope : WizardGames.Soc.SocClient.Player.Interactive.BaseFpInteractiveDisplayNode
{
	System.Int32 state; // 0x44
	System.Int64 subscribeid; // 0x48
	System.Single stateStartTime; // 0x50
	static WizardGames.Soc.SocClient.Player.Interactive.FpInteractiveDisNodeTelescope Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058e9c0c
	System.Void OnInit(); // 0x058e9cdc
	System.Void OnEnter(); // 0x058e9e10
	System.Void OnUpdate(System.Single dt); // 0x058e9f04
	System.Void OnSubStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase player, System.Byte oldstate, System.Byte newstate); // 0x058ea144
	System.Void OnExit(); // 0x058ea5b8
	System.Void ResetTelescopeDisplay(); // 0x058ea278
	System.Void Release(); // 0x058ea6e4
	System.Void .ctor(); // 0x058ea7ec
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Player.Interactive.IInteractiveDisplayNode : 
{
	
	System.Void OnEnter(); // 0x055049cc
	System.Void OnUpdate(System.Single dt); // 0x05513724
	System.Void OnExit(); // 0x055049cc
	System.Void Release(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.PlayerInteractiveDisplayController : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.Go.BasePlayerGo BasePlayerGo; // 0x10
	WizardGames.Soc.SocClient.Player.Interactive.IInteractiveDisplayNode CurrentNode; // 0x18
	System.Void Init(WizardGames.Soc.Common.Unity.Go.BasePlayerGo host); // 0x058ea874
	System.Void StartInteractive(System.Int32 interactiveID); // 0x058ea95c
	System.Void Update(System.Single dt); // 0x058eac68
	System.Void OnGet(); // 0x058ead50
	System.Void OnRelease(); // 0x058eadb0
	System.Void OnDestroy(); // 0x058eaf08
	System.Void Release(); // 0x055049cc
	WizardGames.Soc.SocClient.Player.Interactive.IInteractiveDisplayNode CreateInteractiveNode(System.Int32 interactiveId); // 0x054e7c9c
	System.Void .ctor(); // 0x058eaf68
	static System.Void .cctor(); // 0x058eafd0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.PlayerInteractiveFpDisplayController : WizardGames.Soc.SocClient.Player.Interactive.PlayerInteractiveDisplayController
{
	
	static WizardGames.Soc.SocClient.Player.Interactive.PlayerInteractiveFpDisplayController GetController(WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo host); // 0x058eb0a4
	WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo get_PlayerGo(); // 0x058eb15c
	System.Void Release(); // 0x058eb20c
	WizardGames.Soc.SocClient.Player.Interactive.IInteractiveDisplayNode CreateInteractiveNode(System.Int32 interactiveId); // 0x058eb2ac
	System.Void .ctor(); // 0x058eb694
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.PlayerInteractiveTpDisplayController : WizardGames.Soc.SocClient.Player.Interactive.PlayerInteractiveDisplayController
{
	
	static WizardGames.Soc.SocClient.Player.Interactive.PlayerInteractiveTpDisplayController GetController(WizardGames.Soc.Common.Unity.Go.ClientPlayerGo host); // 0x058eb71c
	WizardGames.Soc.Common.Unity.Go.ClientPlayerGo get_PlayerGo(); // 0x058eb7d4
	System.Void Release(); // 0x058eb884
	WizardGames.Soc.SocClient.Player.Interactive.IInteractiveDisplayNode CreateInteractiveNode(System.Int32 interactiveId); // 0x058eb924
	System.Void .ctor(); // 0x058ec950
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.BaseTpInteractiveDisplayNode : System.Object, WizardGames.Soc.SocClient.Player.Interactive.IInteractiveDisplayNode, WizardGames.Soc.Common.ObjPool.IRecyclable, WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemBatchLoaderHandler
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.Go.ClientPlayerGo PlayerGo; // 0x10
	WizardGames.Soc.Common.Data.character.PlayerInteractiveState <Config>k__BackingField; // 0x18
	UnityEngine.GameObject bindGo; // 0x20
	WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader loader; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo> AssetLoadInfos; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo> PrefabLoadInfos; // 0x38
	System.Single EnterTime; // 0x40
	static WizardGames.Soc.SocClient.Player.Interactive.BaseTpInteractiveDisplayNode Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058ec880
	WizardGames.Soc.Common.Data.character.PlayerInteractiveState get_Config(); // 0x058ecb04
	System.Void set_Config(WizardGames.Soc.Common.Data.character.PlayerInteractiveState value); // 0x058ecb68
	System.Void Init(WizardGames.Soc.Common.Unity.Go.ClientPlayerGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058ec9d8
	System.Void FillResPath(System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& assets, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& prefabs); // 0x058ecbe8
	System.Void OnBatchLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader load); // 0x05523a54
	System.Void OnInit(); // 0x058ed420
	System.Void OnEnter(); // 0x058ed480
	System.Void OnUpdate(System.Single dt); // 0x058ed614
	System.Void OnExit(); // 0x055049cc
	System.Void ClearLoadInfos(); // 0x058eda94
	System.Void Release(); // 0x058edc68
	System.Void OnGet(); // 0x058edd08
	System.Void OnRelease(); // 0x058edd68
	System.Void OnDestroy(); // 0x058ede70
	System.Void .ctor(); // 0x058eded0
	static System.Void .cctor(); // 0x058edfb4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodeCollectWater : WizardGames.Soc.SocClient.Player.Interactive.BaseTpInteractiveDisplayNode
{
	System.Boolean valid; // 0x44
	WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EOverrideLayer state; // 0x48
	System.Single stateStartTime; // 0x4c
	System.Int64 subscribeid; // 0x50
	static WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodeCollectWater Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058ec060
	System.Void OnInit(); // 0x058ee088
	System.Void OnEnter(); // 0x058ee264
	System.Void OnUpdate(System.Single dt); // 0x058ee37c
	System.Void OnSubStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase player, System.Byte oldstate, System.Byte newstate); // 0x058ee540
	System.Void OnExit(); // 0x058ee6a0
	System.Void Release(); // 0x058ee7b4
	System.Void .ctor(); // 0x058ee8c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodeCure : WizardGames.Soc.SocClient.Player.Interactive.BaseTpInteractiveDisplayNode
{
	System.Int64 subscribeid; // 0x48
	WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EOverrideLayer state; // 0x50
	static WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodeCure Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058ec610
	System.Void OnInit(); // 0x058ee948
	System.Void OnEnter(); // 0x058eea7c
	System.Void OnExit(); // 0x058eebec
	System.Void Release(); // 0x058eecec
	System.Void OnSubStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase player, System.Byte oldstate, System.Byte newstate); // 0x058eedf0
	System.Void .ctor(); // 0x058ef0e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodeDrinkWater : WizardGames.Soc.SocClient.Player.Interactive.BaseTpInteractiveDisplayNode
{
	System.Int32 state; // 0x44
	static WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodeDrinkWater Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058ebf90
	System.Void OnEnter(); // 0x058ef168
	System.Void OnUpdate(System.Single dt); // 0x058ef26c
	System.Void OnExit(); // 0x058ef310
	System.Void Release(); // 0x058ef40c
	System.Void .ctor(); // 0x058ef4b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodeGesture : WizardGames.Soc.SocClient.Player.Interactive.BaseTpInteractiveDisplayNode
{
	
	static WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodeGesture Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058ec2d0
	System.Void OnInit(); // 0x058ef538
	System.Void Release(); // 0x058ef59c
	System.Void .ctor(); // 0x058ef644
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodeGugujiCard : WizardGames.Soc.SocClient.Player.Interactive.BaseTpInteractiveDisplayNode
{
	
	static WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodeGugujiCard Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058ec470
	System.Void OnEnter(); // 0x058ef6cc
	System.Void OnExit(); // 0x058ef7cc
	System.Void Release(); // 0x058ef8c8
	System.Void .ctor(); // 0x058ef968
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodeGugujiMsg : WizardGames.Soc.SocClient.Player.Interactive.BaseTpInteractiveDisplayNode
{
	UnityEngine.GameObject Card; // 0x48
	static WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodeGugujiMsg Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058ec540
	System.Void FillResPath(System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& assets, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& prefabs); // 0x058ef9f0
	System.Void OnBatchLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader load); // 0x058efb90
	System.Void Release(); // 0x058f0090
	System.Void .ctor(); // 0x058f0198
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodeInspection : WizardGames.Soc.SocClient.Player.Interactive.BaseTpInteractiveDisplayNode
{
	
	static WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodeInspection Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058ec130
	System.Void OnEnter(); // 0x058f0220
	System.Void OnExit(); // 0x058f0674
	System.Void Release(); // 0x058f0770
	System.Void .ctor(); // 0x058f0810
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodeOpenDoor : WizardGames.Soc.SocClient.Player.Interactive.BaseTpInteractiveDisplayNode
{
	System.Boolean played; // 0x44
	static WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodeOpenDoor Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058ebec0
	System.Void OnEnter(); // 0x058f0898
	System.Void OnExit(); // 0x058f0b44
	System.Void Release(); // 0x058f0c54
	System.Void .ctor(); // 0x058f0cf8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodePickup : WizardGames.Soc.SocClient.Player.Interactive.BaseTpInteractiveDisplayNode
{
	System.Boolean played; // 0x44
	static WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodePickup Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058ebd20
	System.Void OnEnter(); // 0x058f0d80
	System.Void OnExit(); // 0x058f102c
	System.Void Release(); // 0x058f113c
	System.Void .ctor(); // 0x058f11e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodePourWater : WizardGames.Soc.SocClient.Player.Interactive.BaseTpInteractiveDisplayNode
{
	System.Int32 state; // 0x44
	static WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodePourWater Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058ec200
	System.Void OnEnter(); // 0x058f1268
	System.Void OnUpdate(System.Single dt); // 0x058f136c
	System.Void OnExit(); // 0x058f1410
	System.Void Release(); // 0x058f150c
	System.Void .ctor(); // 0x058f15b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodePushVehicle : WizardGames.Soc.SocClient.Player.Interactive.BaseTpInteractiveDisplayNode
{
	
	static WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodePushVehicle Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058ec6e0
	System.Void Release(); // 0x058f1638
	System.Void .ctor(); // 0x058f16e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodeRepair : WizardGames.Soc.SocClient.Player.Interactive.BaseTpInteractiveDisplayNode
{
	UnityEngine.GameObject Hammer; // 0x48
	static WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodeRepair Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058ec7b0
	System.Void FillResPath(System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& assets, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& prefabs); // 0x058f1768
	System.Void OnBatchLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader load); // 0x058f19c8
	System.Void Release(); // 0x058f1e8c
	System.Void .ctor(); // 0x058f1f94
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodeSwipeCard : WizardGames.Soc.SocClient.Player.Interactive.BaseTpInteractiveDisplayNode
{
	UnityEngine.GameObject Card; // 0x48
	static WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodeSwipeCard Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058ebdf0
	System.Void FillResPath(System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& assets, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& prefabs); // 0x058f201c
	System.Void OnBatchLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader load); // 0x058f2308
	System.Void OnEnter(); // 0x058f26d4
	System.Void OnExit(); // 0x058f27d4
	System.Void Release(); // 0x058f28d0
	System.Void .ctor(); // 0x058f29d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodeTelescope : WizardGames.Soc.SocClient.Player.Interactive.BaseTpInteractiveDisplayNode
{
	WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EOverrideLayer state; // 0x44
	System.Int64 subscribeid; // 0x48
	System.Single stateStartTime; // 0x50
	static WizardGames.Soc.SocClient.Player.Interactive.TpInteractiveDisNodeTelescope Create(WizardGames.Soc.Common.Unity.Go.ClientPlayerGo go, WizardGames.Soc.Common.Data.character.PlayerInteractiveState config); // 0x058ec3a0
	System.Void OnInit(); // 0x058f2a60
	System.Void OnEnter(); // 0x058f2b94
	System.Void OnUpdate(System.Single dt); // 0x058f2cac
	System.Void OnSubStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase player, System.Byte oldstate, System.Byte newstate); // 0x058f2ecc
	System.Void OnExit(); // 0x058f3020
	System.Void Release(); // 0x058f3188
	System.Void .ctor(); // 0x058f3290
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Player.HeldItem.BagUsePurposes : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Player.HeldItem.BagUsePurposes None = -1;
	static WizardGames.Soc.SocClient.Player.HeldItem.BagUsePurposes Normal = 0;
	static WizardGames.Soc.SocClient.Player.HeldItem.BagUsePurposes PlantBoxAddWater = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.BagHeldItemUseController : System.Object
{
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer myPlayer; // 0x10
	System.Int64 bagUsingItemId; // 0x18
	WizardGames.Soc.Common.Data.PlayerInteractiveId interactiveReq; // 0x20
	WizardGames.Soc.SocClient.Player.HeldItem.BagUsePurposes interactPurpose; // 0x24
	System.Int64 toInteractTargetId; // 0x28
	System.Collections.Generic.HashSet<System.Int64> subscribeIds; // 0x30
	System.Void .ctor(WizardGames.Soc.Common.Syncronization.MgrMyPlayer myplayer); // 0x058f3318
	System.Void OnCurrentHeldItemChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldId, System.Int64 newId); // 0x058f354c
	System.Void OnInteractiveIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase custom, System.Int32 oldValue, System.Int32 newValue); // 0x058f3d2c
	System.Void Release(); // 0x058f3e68
	System.Boolean TryUseBagHeldItem(WizardGames.Soc.Common.CustomType.BaseItemNode item, System.Int64 targetId, WizardGames.Soc.SocClient.Player.HeldItem.BagUsePurposes purpose); // 0x058f3a6c
	System.Void CmdTick(WizardGames.Soc.Common.SimpleCustom.UserCmd cmd); // 0x058f4118
	System.Void DoInteract(); // 0x058f43a8
	WizardGames.Soc.Common.Data.PlayerInteractiveId GetInteractiveID(System.Int64 tableId, WizardGames.Soc.SocClient.Player.HeldItem.BagUsePurposes purpose); // 0x058f4020
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.BaseHostHeldItemGoController : System.Object
{
	static System.Collections.Generic.HashSet<System.Int32> NonPreloadItemIndex; // 0x0
	static SocLogger logger; // 0x8
	WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemHostGo <Host>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo <CurrentHeldItem>k__BackingField; // 0x18
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo> heldItems; // 0x20
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo> loadingHeldItems; // 0x28
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo> removableGos; // 0x30
	System.Int64 timer; // 0x38
	System.Int32 checkUnheldedTick; // 0x40
	System.Int64 <SwitchingOrHeldedItem>k__BackingField; // 0x48
	System.Single HolsterCacheTime; // 0x50
	static System.Boolean NonPreload(System.Int32 index); // 0x058f4454
	WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemHostGo get_Host(); // 0x058f4508
	System.Void set_Host(WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemHostGo value); // 0x058f456c
	WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo get_CurrentHeldItem(); // 0x058f45ec
	System.Void set_CurrentHeldItem(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo value); // 0x058f4650
	System.Int64 get_SwitchingOrHeldedItem(); // 0x058f46d0
	System.Void set_SwitchingOrHeldedItem(System.Int64 value); // 0x058f4734
	System.Boolean get_EnableCache(); // 0x054c4760
	System.Void .ctor(WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemHostGo host); // 0x05523a54
	System.Void StartSwitchHeldItem(WizardGames.Soc.Common.Entity.IHeldItemEntity entity); // 0x058f4a8c
	System.Void StartSwitchToUnarmed(); // 0x058f5960
	System.Void DoSwitchHeldItemGo(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo go); // 0x058f4fe8
	System.Void HeldItemGoChange(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo go, System.Boolean deploy); // 0x058f4db8
	System.Boolean TryGetHeldItemGo<T>(System.Int64 entityID, T& heldItemGo); // 0x052af1f0
	System.Boolean TryGetCurrentHeldItemGo<T>(T& heldItemGo); // 0x052af1f0
	WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo AddGo(WizardGames.Soc.Common.Entity.IHeldItemEntity entity); // 0x058f5440
	System.Void OnGoCreated(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo go); // 0x058f5f20
	System.Void MarkAsRemovable(System.Int64 entityid); // 0x058f617c
	System.Void DoRemovableClear(); // 0x058f5cc4
	System.Void CheckRemoveUnhelded(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x058f6294
	System.Void CheckRemoveUnhelded(); // 0x058f6410
	System.Void Release(); // 0x058f6934
	WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo CreateHeldItemGo(WizardGames.Soc.Common.Entity.IHeldItemEntity entity, WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemHostGo host); // 0x054fbfdc
	System.Void QualityUpdate(); // 0x058f6ddc
	static System.Void .cctor(); // 0x058f6f8c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerHeldItemGo : WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo
{
	WizardGames.Soc.Common.Entity.PlayerEntity <PlayerEntity>k__BackingField; // 0xd0
	UnityEngine.Animator <HeldItemAnimator>k__BackingField; // 0xd8
	System.Collections.Generic.List<UnityEngine.AnimatorOverrideController> HostAnimatorControllers; // 0xe0
	System.Collections.Generic.List<WizardGames.AssetPool.AssetPoolHandle> HostHandleAnimatorControllers; // 0xe8
	System.Collections.Generic.List<UnityEngine.AnimatorOverrideController> HeldItemAnimatorControllers; // 0xf0
	System.Single curIdlePose; // 0xf8
	WizardGames.Soc.Common.Entity.PlayerEntity get_PlayerEntity(); // 0x058f7120
	System.Void set_PlayerEntity(WizardGames.Soc.Common.Entity.PlayerEntity value); // 0x058f7184
	System.Boolean get_IsSelf(); // 0x058f7204
	UnityEngine.Animator get_HeldItemAnimator(); // 0x058f7348
	System.Void set_HeldItemAnimator(UnityEngine.Animator value); // 0x058f73ac
	System.Void SetHostAnimCtrl(WizardGames.Soc.Common.Unity.Animation.ISocAnimationRuntime runtime, System.Int32 index); // 0x058f742c
	System.Void Init(WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerHeldItemGo.BasePlayerHeldItemGoParams goParams); // 0x058f760c
	System.Void OnGoLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader loader); // 0x058f7c74
	System.Void CreateFxControllers(); // 0x058f833c
	System.Void ClearLoaderRes(); // 0x058f839c
	UnityEngine.AnimatorCullingMode GetAnimatorCullingMode(); // 0x058f8c8c
	System.Void SetIdlePose(System.Single val); // 0x058f8cf0
	System.Void UpdateIdlePose(WizardGames.Soc.Common.CustomType.WeaponCustom weaponCustom); // 0x058f8df4
	System.Void OnWarmupProgressUpdate(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x058f8f70
	System.Void UpdatePrachutePose(); // 0x058f9084
	System.Void PlayGugujiCardSwitchEffect(); // 0x058f93f0
	System.Void OnHolster(); // 0x058f95fc
	System.Boolean GetWeaponCanHanging(); // 0x058f9970
	System.Void .ctor(); // 0x058f9cf8
	System.Void <PlayGugujiCardSwitchEffect>b__25_0(System.Int64 id, System.Object data, System.Boolean delete); // 0x058f9ef0
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerHeldItemGo.BasePlayerHeldItemGoParams : System.ValueType
{
	WizardGames.Soc.Common.Entity.IHeldItemEntity Entity; // 0x10
	WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemHostGo Host; // 0x18
	WizardGames.Soc.Common.Entity.PlayerEntity Player; // 0x20
	WizardGames.Soc.SocClient.Player.HeldItem.BaseHostHeldItemGoController Controller; // 0x28
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.HeldItemGo : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable, WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemBatchLoaderHandler
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Entity.IHeldItemEntity <HeldItemEntity>k__BackingField; // 0x10
	UnityEngine.GameObject <MainGo>k__BackingField; // 0x18
	UnityEngine.Transform <MainTransform>k__BackingField; // 0x20
	WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent <ObjectComponent>k__BackingField; // 0x28
	WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader LoadingLoader; // 0x30
	WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader CurrentLoader; // 0x38
	System.Collections.Generic.List<UnityEngine.Renderer> ModelRenderers; // 0x40
	System.Collections.Generic.List<UnityEngine.Renderer> BaseRenderers; // 0x48
	UnityEngine.Transform HeldItemRoot; // 0x50
	UnityEngine.Transform HeldItemJoints; // 0x58
	UnityEngine.Transform HeldItemModels; // 0x60
	UnityEngine.Transform HeldItemFxDisplay; // 0x68
	System.Boolean _modelRenderDirty; // 0x70
	System.Boolean BaseRendererDirty; // 0x71
	System.Boolean _renderDirty; // 0x72
	System.Collections.Generic.List<UnityEngine.Renderer> AllPossibleRenderers; // 0x78
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Weapon.WeaponFxController> fxControllers; // 0x80
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo> PrefabLoadInfos; // 0x88
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo> AssetLoadInfos; // 0x90
	System.Collections.Generic.HashSet<System.Int64> SubscribeIds; // 0x98
	System.Collections.Generic.HashSet<System.String> PlayingSound; // 0xa0
	System.Boolean finishLoad; // 0xa8
	Effect.EffectItemHandle<Effect.EffectItem> followEffectHandle; // 0xb0
	System.Int64 get_EntityId(); // 0x058e1250
	WizardGames.Soc.Common.Entity.IHeldItemEntity get_HeldItemEntity(); // 0x058f9fcc
	System.Void set_HeldItemEntity(WizardGames.Soc.Common.Entity.IHeldItemEntity value); // 0x058fa030
	WizardGames.Soc.Share.Framework.CustomTypeBase get_Alpha3Custom(); // 0x058f9700
	System.Int64 get_TableID(); // 0x058e22fc
	UnityEngine.GameObject get_MainGo(); // 0x058fa0b0
	System.Void set_MainGo(UnityEngine.GameObject value); // 0x058fa114
	UnityEngine.Transform get_MainTransform(); // 0x058fa194
	System.Void set_MainTransform(UnityEngine.Transform value); // 0x058fa1f8
	WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent get_ObjectComponent(); // 0x058fa278
	System.Void set_ObjectComponent(WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent value); // 0x058fa2dc
	System.Void set_ModelRendererDirty(System.Boolean value); // 0x058fa35c
	System.Collections.Generic.IEnumerable<UnityEngine.Renderer> get_ModelRendererItor(); // 0x058fa3fc
	System.Collections.Generic.List<UnityEngine.Renderer> get_BaseRendererItor(); // 0x058fa510
	System.Void set_AllPossibleRendererDirty(System.Boolean value); // 0x058fa624
	System.Collections.Generic.List<UnityEngine.Renderer> get_AllPossibleRendererItor(); // 0x058fa6c4
	System.Void SubscribePropertyChange(); // 0x055049cc
	System.Void DoLoad(); // 0x058fa864
	System.Void FillResPath(System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& prefabs, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& assets); // 0x0552af00
	System.Void OnBatchLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader loader); // 0x058faae8
	System.Void OnFinishLoad(); // 0x058fb448
	System.Void PlayEffect(System.Int32 effectTableId); // 0x058e3b18
	System.Void OnGoLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader loader); // 0x05523a54
	System.Void OnGoCreated(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader loader); // 0x05523a54
	System.Void CreateFxControllers(); // 0x055049cc
	System.Void UpdateVisible(); // 0x055049cc
	System.Void UpdateAttach(); // 0x055049cc
	System.Void OnInit(); // 0x058fb4b0
	System.Void PlayOrStopSound(System.String sound, System.Boolean play); // 0x058e570c
	System.Void OnSkinChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldSkin, System.Int64 newSkin); // 0x058fb510
	System.Void QualityUpdate(); // 0x058fb5c0
	System.Void Release(); // 0x055049cc
	System.Void OnGet(); // 0x058fb620
	System.Void ResetVisible(); // 0x058fb680
	System.Void OnRelease(); // 0x058fb964
	System.Void ClearLoadInfos(); // 0x058fa914
	System.Void ClearLoaderRes(); // 0x058f87f4
	System.Void OnDestroy(); // 0x058fbba4
	System.Void .ctor(); // 0x058fbc04
	static System.Void .cctor(); // 0x058fbe90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo : WizardGames.Soc.SocClient.Player.HeldItem.HeldItemGo
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Player.HeldItem.BaseHostHeldItemGoController <HostHeldItemGoController>k__BackingField; // 0xc0
	System.Single StartSwitchTime; // 0xc8
	WizardGames.Soc.SocClient.Player.HeldItem.BaseHostHeldItemGoController get_HostHeldItemGoController(); // 0x058fbf64
	System.Void set_HostHeldItemGoController(WizardGames.Soc.SocClient.Player.HeldItem.BaseHostHeldItemGoController value); // 0x058fbfc8
	WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemHostGo get_Host(); // 0x058fc048
	System.Void Init(WizardGames.Soc.Common.Entity.IHeldItemEntity entity, WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemHostGo host, WizardGames.Soc.SocClient.Player.HeldItem.BaseHostHeldItemGoController controller); // 0x058f7700
	System.Void OnGoCreated(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader loader); // 0x058fc134
	System.Void Deploy(); // 0x058f5bf0
	System.Void Holster(); // 0x058f5e60
	System.Void OnDeploy(); // 0x058fc1fc
	System.Void OnHolster(); // 0x058f97f8
	System.Void QualityUpdate(); // 0x058fc388
	System.Void .ctor(); // 0x058f9e68
	static System.Void .cctor(); // 0x058fc530
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.BaseMonsterHeldItemGo : WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo
{
	WizardGames.Soc.SocClient.Go.MonsterGo <HostMonsterGo>k__BackingField; // 0xd0
	WizardGames.Soc.Common.Unity.Character.TpMetaDataProxy ClipSettings; // 0xd8
	WizardGames.Soc.Common.Entity.MonsterEntity <MonsterEntity>k__BackingField; // 0xf0
	UnityEngine.Animator <HeldItemAnimator>k__BackingField; // 0xf8
	UnityEngine.AnimatorOverrideController HostAnimatorController; // 0x100
	WizardGames.AssetPool.AssetPoolHandle hostAnimatorHandle; // 0x108
	UnityEngine.AnimatorOverrideController HeldItemAnimatorController; // 0x110
	WizardGames.Soc.SocClient.Go.MonsterGo get_HostMonsterGo(); // 0x058fc604
	System.Void set_HostMonsterGo(WizardGames.Soc.SocClient.Go.MonsterGo value); // 0x058fc668
	WizardGames.Soc.Common.Entity.MonsterEntity get_MonsterEntity(); // 0x058fc6e8
	System.Void set_MonsterEntity(WizardGames.Soc.Common.Entity.MonsterEntity value); // 0x058fc74c
	UnityEngine.Animator get_HeldItemAnimator(); // 0x058fc7cc
	System.Void set_HeldItemAnimator(UnityEngine.Animator value); // 0x058fc830
	System.Void Init(WizardGames.Soc.SocClient.Player.HeldItem.BaseMonsterHeldItemGo.MonsterHeldItemGoParams goParams); // 0x058fc8b0
	System.Void CreateFxControllers(); // 0x058fc9a4
	System.Void OnInit(); // 0x058fca04
	System.Void OnGoLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader loader); // 0x058fcb18
	System.Void UpdateAttach(); // 0x058fd468
	System.Void ClearLoaderRes(); // 0x058fdd58
	System.Void UpdateVisible(); // 0x058fdf18
	System.String GetHostAnimatorController(); // 0x058fdf78
	System.Void OnDeploy(); // 0x058fe394
	System.Void .ctor(); // 0x058fe6b0
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Player.HeldItem.BaseMonsterHeldItemGo.MonsterHeldItemGoParams : System.ValueType
{
	WizardGames.Soc.Common.Entity.IHeldItemEntity Entity; // 0x10
	WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemHostGo Host; // 0x18
	WizardGames.Soc.Common.Entity.MonsterEntity Monster; // 0x20
	WizardGames.Soc.SocClient.Player.HeldItem.BaseHostHeldItemGoController Controller; // 0x28
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.MonsterHeldItemGo : WizardGames.Soc.SocClient.Player.HeldItem.BaseMonsterHeldItemGo
{
	WizardGames.Soc.Common.CustomType.HeldItemCustom <HeldItemCustom>k__BackingField; // 0x118
	static WizardGames.Soc.SocClient.Player.HeldItem.MonsterHeldItemGo Create(WizardGames.Soc.SocClient.Player.HeldItem.BaseMonsterHeldItemGo.MonsterHeldItemGoParams goParams); // 0x058fe8c8
	WizardGames.Soc.Common.CustomType.HeldItemCustom get_HeldItemCustom(); // 0x058fea50
	System.Void set_HeldItemCustom(WizardGames.Soc.Common.CustomType.HeldItemCustom value); // 0x058feab4
	System.Void SubscribePropertyChange(); // 0x058feb34
	System.Void FillResPath(System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& prefabs, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& assets); // 0x058fec88
	System.Void Release(); // 0x058ff1e4
	System.Void .ctor(); // 0x058ff284
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.MonsterMeleeGo : WizardGames.Soc.SocClient.Player.HeldItem.BaseMonsterHeldItemGo
{
	WizardGames.Soc.Common.CustomType.MeleeCustom <MeleeCustom>k__BackingField; // 0x118
	static WizardGames.Soc.SocClient.Player.HeldItem.MonsterMeleeGo Create(WizardGames.Soc.SocClient.Player.HeldItem.BaseMonsterHeldItemGo.MonsterHeldItemGoParams goParams); // 0x058ff2ec
	WizardGames.Soc.Common.CustomType.MeleeCustom get_MeleeCustom(); // 0x058ff474
	System.Void set_MeleeCustom(WizardGames.Soc.Common.CustomType.MeleeCustom value); // 0x058ff4d8
	System.Void SubscribePropertyChange(); // 0x058ff558
	System.Void FillResPath(System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& prefabs, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& assets); // 0x058ff6ac
	System.Void Release(); // 0x058ffde4
	System.Void .ctor(); // 0x058ffe84
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.MonsterTrowWeaponGo : WizardGames.Soc.SocClient.Player.HeldItem.BaseMonsterHeldItemGo
{
	WizardGames.Soc.Common.CustomType.ThrowWeaponCustom <ThrowWeaponCustom>k__BackingField; // 0x118
	static WizardGames.Soc.SocClient.Player.HeldItem.MonsterTrowWeaponGo Create(WizardGames.Soc.SocClient.Player.HeldItem.BaseMonsterHeldItemGo.MonsterHeldItemGoParams goParams); // 0x058ffeec
	WizardGames.Soc.Common.CustomType.ThrowWeaponCustom get_ThrowWeaponCustom(); // 0x05900074
	System.Void set_ThrowWeaponCustom(WizardGames.Soc.Common.CustomType.ThrowWeaponCustom value); // 0x059000d8
	System.Void SubscribePropertyChange(); // 0x05900158
	System.Void FillResPath(System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& prefabs, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& assets); // 0x059002ac
	System.Void OnGoLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader loader); // 0x0590072c
	System.Void Release(); // 0x05900ba4
	System.Void .ctor(); // 0x05900c44
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.MonsterUseItemGo : WizardGames.Soc.SocClient.Player.HeldItem.BaseMonsterHeldItemGo
{
	WizardGames.Soc.Common.CustomType.UseItemCustom <UseItemCustom>k__BackingField; // 0x118
	static WizardGames.Soc.SocClient.Player.HeldItem.MonsterUseItemGo Create(WizardGames.Soc.SocClient.Player.HeldItem.BaseMonsterHeldItemGo.MonsterHeldItemGoParams goParams); // 0x05900cac
	WizardGames.Soc.Common.CustomType.UseItemCustom get_UseItemCustom(); // 0x05900e34
	System.Void set_UseItemCustom(WizardGames.Soc.Common.CustomType.UseItemCustom value); // 0x05900e98
	System.Void SubscribePropertyChange(); // 0x05900f18
	System.Void FillResPath(System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& prefabs, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& assets); // 0x0590106c
	System.Void Release(); // 0x0590160c
	System.Void .ctor(); // 0x059016ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.MonsterWeaponGo : WizardGames.Soc.SocClient.Player.HeldItem.BaseMonsterHeldItemGo, WizardGames.Soc.SocClient.Weapon.IAccessoryHost
{
	WizardGames.Soc.Common.CustomType.WeaponCustom <WeaponCustom>k__BackingField; // 0x118
	WizardGames.Soc.SocClient.Weapon.AccessoryManager <TpAccessoryManager>k__BackingField; // 0x120
	static WizardGames.Soc.SocClient.Player.HeldItem.MonsterWeaponGo Create(WizardGames.Soc.SocClient.Player.HeldItem.BaseMonsterHeldItemGo.MonsterHeldItemGoParams goParams); // 0x05901714
	WizardGames.Soc.Common.CustomType.WeaponCustom get_WeaponCustom(); // 0x0590189c
	System.Void set_WeaponCustom(WizardGames.Soc.Common.CustomType.WeaponCustom value); // 0x05901900
	System.Void set_TpAccessoryManager(WizardGames.Soc.SocClient.Weapon.AccessoryManager value); // 0x05901980
	WizardGames.Soc.SocClient.Weapon.AccessoryManager get_TpAccessoryManager(); // 0x05901a00
	System.Void SubscribePropertyChange(); // 0x05901a64
	System.Void FillResPath(System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& prefabs, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& assets); // 0x05901d54
	System.Void CreateFxControllers(); // 0x0590248c
	System.Void OnGoLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader loader); // 0x059028ec
	System.Void OnDeploy(); // 0x05902ab0
	System.Void OnWarmupProgressUpdate(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x05902b78
	System.Void OnWeaponAttackStateChanged(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int32 oldValue, System.Int32 newValue); // 0x05902c8c
	System.Void OnHolster(); // 0x059030c4
	System.Void Release(); // 0x05903234
	System.Void ClearLoaderRes(); // 0x059034a4
	UnityEngine.GameObject get_AccessoryHostGo(); // 0x059035e4
	System.Void AccessoryChangePostProcess(WizardGames.Soc.SocClient.Weapon.AccessoryManager acc_manager, System.Collections.Generic.List<System.Int64> changeList); // 0x0590367c
	System.Boolean TryGetWeaponAccessory(WizardGames.Soc.Common.Data.DataItem.ItemSlot slot, WizardGames.Soc.SocClient.Weapon.AccessoryGo& accessory); // 0x059036f8
	System.Void AfterAccessoryCreated(WizardGames.Soc.SocClient.Weapon.AccessoryGo acc); // 0x05903830
	System.Boolean get_Deployed(); // 0x059038a4
	System.Boolean TryGetHangPoint(System.String pointName, UnityEngine.Transform& point); // 0x05903a28
	System.Void .ctor(); // 0x05903b04
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerFpHeldItemGo : WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerHeldItemGo, UnityEngine.Timeline.IControlPlayableAssetHook
{
	WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo <ClientPlayerFpGo>k__BackingField; // 0x100
	WizardGames.Editor.FpClipSettingMeta ClipSettings; // 0x108
	UnityEngine.MaterialPropertyBlock block; // 0x110
	System.Boolean <FpCrossSwitch>k__BackingField; // 0x118
	UnityEngine.Playables.PlayableDirector PlayableDirector; // 0x120
	WizardGames.AssetPool.AssetPoolHandle metaHandle; // 0x128
	System.Boolean clone; // 0x130
	WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo get_ClientPlayerFpGo(); // 0x05903b6c
	System.Void set_ClientPlayerFpGo(WizardGames.Soc.Common.Unity.Go.ClientPlayerFpGo value); // 0x05903bd0
	System.Boolean get_FpCrossSwitch(); // 0x05903c50
	System.Void set_FpCrossSwitch(System.Boolean value); // 0x05903cb4
	WizardGames.Soc.Common.Entity.PlayerEntity get_MyEntityServer(); // 0x05903d30
	System.Void OnInit(); // 0x05903dcc
	System.Void OnGoLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader loader); // 0x05903eec
	System.Void OnHolster(); // 0x05904d48
	System.Void UpdateAttach(); // 0x05904e08
	System.Void UpdateVisible(); // 0x05905280
	System.Void ClearMaterialsClone(); // 0x05905abc
	System.Void OnFinishLoad(); // 0x05905b20
	System.Void UpdateAlpha(); // 0x05905690
	UnityEngine.AnimatorCullingMode GetAnimatorCullingMode(); // 0x05905d0c
	System.Void SetFpCrossSwitch(System.Boolean crossswitch); // 0x05905d70
	System.Void SetRendererVisible(System.Boolean visible); // 0x05906054
	System.Void ClearLoaderRes(); // 0x05906350
	System.Boolean TryGetOverrideSourceGameObject(UnityEngine.Timeline.ControlPlayableAsset asset, UnityEngine.Transform& obj); // 0x05906624
	System.Void .ctor(); // 0x05906704
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.PlayerFpCharmGo : System.Object
{
	UnityEngine.MaterialPropertyBlock block; // 0x10
	UnityEngine.GameObject MainGo; // 0x18
	System.Boolean _renderDirty; // 0x20
	System.Collections.Generic.List<UnityEngine.Renderer> AllPossibleRenderers; // 0x28
	static WizardGames.Soc.SocClient.Player.HeldItem.PlayerFpCharmGo Create(UnityEngine.GameObject charmGo, UnityEngine.Transform locatorCharm); // 0x059067ac
	System.Collections.Generic.List<UnityEngine.Renderer> get_AllPossibleRendererItor(); // 0x05906a48
	System.Void Init(UnityEngine.Transform locatorCharm); // 0x05906888
	System.Void SetFpCrossSwitch(System.Boolean crossswitch); // 0x05906b5c
	System.Void SetRendererVisible(System.Boolean visible); // 0x05906dec
	System.Void Release(); // 0x05906fbc
	System.Void .ctor(); // 0x059070ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.PlayerFpHeldItemGo : WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerFpHeldItemGo
{
	WizardGames.Soc.Common.CustomType.HeldItemCustom <HeldItemCustom>k__BackingField; // 0x138
	System.String EmptyStr; // 0x140
	static WizardGames.Soc.SocClient.Player.HeldItem.PlayerFpHeldItemGo Create(WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerHeldItemGo.BasePlayerHeldItemGoParams goParams); // 0x059071ac
	WizardGames.Soc.Common.CustomType.HeldItemCustom get_HeldItemCustom(); // 0x05907334
	System.Void set_HeldItemCustom(WizardGames.Soc.Common.CustomType.HeldItemCustom value); // 0x05907398
	System.Void SubscribePropertyChange(); // 0x05907418
	System.Void FillResPath(System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& prefabs, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& assets); // 0x0590756c
	System.Void OnGoLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader loader); // 0x05907db8
	System.Void CreateFxControllers(); // 0x05907e34
	System.Void Release(); // 0x0590801c
	System.Void .ctor(); // 0x059080bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.PlayerFpMeleeGo : WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerFpHeldItemGo
{
	WizardGames.Soc.Common.CustomType.MeleeCustom <MeleeCustom>k__BackingField; // 0x138
	static WizardGames.Soc.SocClient.Player.HeldItem.PlayerFpMeleeGo Create(WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerHeldItemGo.BasePlayerHeldItemGoParams goParams); // 0x05908144
	WizardGames.Soc.Common.CustomType.MeleeCustom get_MeleeCustom(); // 0x059082cc
	System.Void set_MeleeCustom(WizardGames.Soc.Common.CustomType.MeleeCustom value); // 0x05908330
	System.Void SubscribePropertyChange(); // 0x059083b0
	System.Void OnDeploy(); // 0x059085d8
	System.Void FillResPath(System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& prefabs, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& assets); // 0x0590891c
	System.Void OnGoLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader loader); // 0x0590917c
	System.Void CreateFxControllers(); // 0x059091f8
	System.Void OnMeleeBroken(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x05909c9c
	System.Void Release(); // 0x0590a0a8
	System.Void .ctor(); // 0x0590a148
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.PlayerFpTrowWeaponGo : WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerFpHeldItemGo
{
	WizardGames.Soc.Common.CustomType.ThrowWeaponCustom <ThrowWeaponCustom>k__BackingField; // 0x138
	static WizardGames.Soc.SocClient.Player.HeldItem.PlayerFpTrowWeaponGo Create(WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerHeldItemGo.BasePlayerHeldItemGoParams goParams); // 0x0590a1ac
	WizardGames.Soc.Common.CustomType.ThrowWeaponCustom get_ThrowWeaponCustom(); // 0x0590a334
	System.Void set_ThrowWeaponCustom(WizardGames.Soc.Common.CustomType.ThrowWeaponCustom value); // 0x0590a398
	System.Void SubscribePropertyChange(); // 0x0590a418
	System.Void FillResPath(System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& prefabs, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& assets); // 0x0590a56c
	System.Void CreateFxControllers(); // 0x0590adb4
	System.Void OnDeploy(); // 0x0590b214
	System.Void OnHolster(); // 0x0590b2f4
	System.Void Release(); // 0x0590b398
	System.Void .ctor(); // 0x0590b438
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.PlayerFpUseItemGo : WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerFpHeldItemGo
{
	WizardGames.Soc.Common.CustomType.UseItemCustom <UseItemCustom>k__BackingField; // 0x138
	static WizardGames.Soc.SocClient.Player.HeldItem.PlayerFpUseItemGo Create(WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerHeldItemGo.BasePlayerHeldItemGoParams goParams); // 0x0590b49c
	WizardGames.Soc.Common.CustomType.UseItemCustom get_UseItemCustom(); // 0x0590b624
	System.Void set_UseItemCustom(WizardGames.Soc.Common.CustomType.UseItemCustom value); // 0x0590b688
	System.Void SubscribePropertyChange(); // 0x0590b708
	System.Void FillResPath(System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& prefabs, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& assets); // 0x0590b85c
	System.Void Release(); // 0x0590c0a4
	System.Void .ctor(); // 0x0590c144
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.PlayerFpWeaponGo : WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerFpHeldItemGo, WizardGames.Soc.SocClient.Weapon.IAccessoryHost
{
	WizardGames.Soc.Common.CustomType.WeaponCustom <SourceWeaponCustom>k__BackingField; // 0x138
	WizardGames.Soc.Common.CustomType.WeaponCustom <WeaponCustom>k__BackingField; // 0x140
	WizardGames.Soc.Common.Data.gun.GunBase <GunTable>k__BackingField; // 0x148
	WizardGames.Soc.SocClient.Weapon.AccessoryManager <FpAccessoryManager>k__BackingField; // 0x150
	WizardGames.Soc.Common.Unity.Character.CharacterFovConfig _sceneFovConfig; // 0x158
	WizardGames.Soc.Common.Unity.Character.CharacterFovConfig _gunFovConfig; // 0x160
	System.Boolean hasCharm; // 0x168
	System.String skinCharmFpModelPath; // 0x170
	WizardGames.Soc.SocClient.Player.HeldItem.PlayerFpCharmGo fpCharmGo; // 0x178
	static WizardGames.Soc.SocClient.Player.HeldItem.PlayerFpWeaponGo Create(WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerHeldItemGo.BasePlayerHeldItemGoParams goParams); // 0x0590c1a8
	System.Void set_SourceWeaponCustom(WizardGames.Soc.Common.CustomType.WeaponCustom value); // 0x0590c47c
	WizardGames.Soc.Common.CustomType.WeaponCustom get_WeaponCustom(); // 0x0590c4fc
	System.Void set_WeaponCustom(WizardGames.Soc.Common.CustomType.WeaponCustom value); // 0x0590c560
	WizardGames.Soc.Common.Data.gun.GunBase get_GunTable(); // 0x0590c5e0
	System.Void set_GunTable(WizardGames.Soc.Common.Data.gun.GunBase value); // 0x0590c644
	System.Void set_FpAccessoryManager(WizardGames.Soc.SocClient.Weapon.AccessoryManager value); // 0x0590c6c4
	WizardGames.Soc.SocClient.Weapon.AccessoryManager get_FpAccessoryManager(); // 0x0590c744
	WizardGames.Soc.Common.Unity.Character.CharacterFovConfig get_SceneFovConfig(); // 0x0590c7a8
	WizardGames.Soc.Common.Unity.Character.CharacterFovConfig get_GunFovConfig(); // 0x0590c91c
	System.Void OnInit(); // 0x0590ca90
	System.Void SubscribePropertyChange(); // 0x0590cc40
	System.Void FlushSkinCharm(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.TypeBase oldValue, WizardGames.Soc.Share.Framework.TypeBase newValue); // 0x0590cfa4
	System.Void FillResPath(System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& prefabs, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& assets); // 0x0590d1bc
	System.Void OnGoLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader loader); // 0x0590df4c
	System.Void OnDeploy(); // 0x055049cc
	System.Void OnHolster(); // 0x0590e83c
	System.Void SetFpCrossSwitch(System.Boolean crossswitch); // 0x0590e914
	System.Void SetRendererVisible(System.Boolean visible); // 0x0590e9b0
	System.Void CreateFxControllers(); // 0x0590ea4c
	System.Void UpdateVisible(); // 0x0590f43c
	System.Void Release(); // 0x0590f5ac
	System.Void ClearLoaderRes(); // 0x0590f768
	UnityEngine.GameObject get_AccessoryHostGo(); // 0x0590f8a0
	System.Void AccessoryChangePostProcess(WizardGames.Soc.SocClient.Weapon.AccessoryManager acc_manager, System.Collections.Generic.List<System.Int64> changeList); // 0x0590f938
	System.Boolean TryGetWeaponAccessory(WizardGames.Soc.Common.Data.DataItem.ItemSlot slot, WizardGames.Soc.SocClient.Weapon.AccessoryGo& accessory); // 0x0590fc88
	System.Void AfterAccessoryCreated(WizardGames.Soc.SocClient.Weapon.AccessoryGo acc); // 0x0590fdc0
	System.Boolean get_Deployed(); // 0x0590fe34
	System.Boolean TryGetHangPoint(System.String pointName, UnityEngine.Transform& point); // 0x0590ffb8
	System.Void OnWeaponBroken(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldValue, System.Single newValue); // 0x05910094
	System.Void .ctor(); // 0x059104a0
	System.Void <CreateFxControllers>b__35_0(); // 0x05910504
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.PlayerHostFpHeldItemGoController : WizardGames.Soc.SocClient.Player.HeldItem.PlayerHostHeldItemGoController
{
	
	System.Void .ctor(WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemHostGo host, WizardGames.Soc.Common.Entity.PlayerEntity Player, System.Boolean isFp); // 0x05910614
	WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo CreateHeldItemGo(WizardGames.Soc.Common.Entity.IHeldItemEntity entity, WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemHostGo host); // 0x05911ce0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerTpHeldItemGo : WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerHeldItemGo
{
	WizardGames.Soc.Common.Unity.Go.ClientPlayerGo <PlayerGo>k__BackingField; // 0x100
	WizardGames.Soc.Common.Unity.Character.TpMetaDataProxy ClipSettings; // 0x108
	WizardGames.Soc.Common.Unity.Go.ClientPlayerGo get_PlayerGo(); // 0x05911f20
	System.Void set_PlayerGo(WizardGames.Soc.Common.Unity.Go.ClientPlayerGo value); // 0x05911f84
	System.Void OnInit(); // 0x05912004
	System.Void OnGoLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader loader); // 0x05912120
	System.Void RefreshShadow(); // 0x059126bc
	System.Void SetShadowCastingMode(UnityEngine.GameObject go, UnityEngine.Rendering.ShadowCastingMode mode); // 0x05912864
	System.Void UpdateAttach(); // 0x059129ec
	System.Void UpdateVisible(); // 0x05912e7c
	System.Void OnDeploy(); // 0x05913708
	System.Void OnHolster(); // 0x0591389c
	System.Void ClearLoaderRes(); // 0x05913a34
	System.Void .ctor(); // 0x05913cb4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.PlayerTpHeldItemGo : WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerTpHeldItemGo
{
	WizardGames.Soc.Common.CustomType.HeldItemCustom <HeldItemCustom>k__BackingField; // 0x120
	static WizardGames.Soc.SocClient.Player.HeldItem.PlayerTpHeldItemGo Create(WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerHeldItemGo.BasePlayerHeldItemGoParams goParams); // 0x05913d1c
	WizardGames.Soc.Common.CustomType.HeldItemCustom get_HeldItemCustom(); // 0x05913ea4
	System.Void set_HeldItemCustom(WizardGames.Soc.Common.CustomType.HeldItemCustom value); // 0x05913f08
	System.Void SubscribePropertyChange(); // 0x05913f88
	System.Void FillResPath(System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& prefabs, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& assets); // 0x059140dc
	System.Void Release(); // 0x0591491c
	System.Void .ctor(); // 0x059149bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.PlayerTpMeleeGo : WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerTpHeldItemGo
{
	WizardGames.Soc.Common.CustomType.MeleeCustom <MeleeCustom>k__BackingField; // 0x120
	static WizardGames.Soc.SocClient.Player.HeldItem.PlayerTpMeleeGo Create(WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerHeldItemGo.BasePlayerHeldItemGoParams goParams); // 0x05914a20
	WizardGames.Soc.Common.CustomType.MeleeCustom get_MeleeCustom(); // 0x05914ba8
	System.Void set_MeleeCustom(WizardGames.Soc.Common.CustomType.MeleeCustom value); // 0x05914c0c
	System.Void SubscribePropertyChange(); // 0x05914c8c
	System.Void FillResPath(System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& prefabs, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& assets); // 0x05914de0
	System.Void CreateFxControllers(); // 0x05915620
	System.Void Release(); // 0x05916270
	System.Void .ctor(); // 0x05916310
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.PlayerTpTrowWeaponGo : WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerTpHeldItemGo
{
	WizardGames.Soc.Common.CustomType.ThrowWeaponCustom <ThrowWeaponCustom>k__BackingField; // 0x120
	UnityEngine.Collider collider; // 0x128
	static WizardGames.Soc.SocClient.Player.HeldItem.PlayerTpTrowWeaponGo Create(WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerHeldItemGo.BasePlayerHeldItemGoParams goParams); // 0x05916374
	WizardGames.Soc.Common.CustomType.ThrowWeaponCustom get_ThrowWeaponCustom(); // 0x059164fc
	System.Void set_ThrowWeaponCustom(WizardGames.Soc.Common.CustomType.ThrowWeaponCustom value); // 0x05916560
	System.Void SubscribePropertyChange(); // 0x059165e0
	System.Void FillResPath(System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& prefabs, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& assets); // 0x05916734
	System.Void CreateFxControllers(); // 0x05916f74
	System.Void OnGoLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader loader); // 0x05917434
	System.Void ClearLoaderRes(); // 0x0591758c
	System.Void Release(); // 0x05917654
	System.Void .ctor(); // 0x059176f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.PlayerTpUseItemGo : WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerTpHeldItemGo
{
	WizardGames.Soc.Common.CustomType.UseItemCustom <UseItemCustom>k__BackingField; // 0x120
	static WizardGames.Soc.SocClient.Player.HeldItem.PlayerTpUseItemGo Create(WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerHeldItemGo.BasePlayerHeldItemGoParams goParams); // 0x05917758
	WizardGames.Soc.Common.CustomType.UseItemCustom get_UseItemCustom(); // 0x059178e0
	System.Void set_UseItemCustom(WizardGames.Soc.Common.CustomType.UseItemCustom value); // 0x05917944
	System.Void SubscribePropertyChange(); // 0x059179c4
	System.Void FillResPath(System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& prefabs, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& assets); // 0x05917b18
	System.Void Release(); // 0x05918358
	System.Void .ctor(); // 0x059183f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.PlayerTpWeaponGo : WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerTpHeldItemGo, WizardGames.Soc.SocClient.Weapon.IAccessoryHost
{
	WizardGames.Soc.Common.CustomType.WeaponCustom <WeaponCustom>k__BackingField; // 0x120
	WizardGames.Soc.SocClient.Weapon.AccessoryManager <TpAccessoryManager>k__BackingField; // 0x128
	System.Boolean hasCharm; // 0x130
	static WizardGames.Soc.SocClient.Player.HeldItem.PlayerTpWeaponGo Create(WizardGames.Soc.SocClient.Player.HeldItem.BasePlayerHeldItemGo.BasePlayerHeldItemGoParams goParams); // 0x0591845c
	WizardGames.Soc.Common.CustomType.WeaponCustom get_WeaponCustom(); // 0x059185e4
	System.Void set_WeaponCustom(WizardGames.Soc.Common.CustomType.WeaponCustom value); // 0x05918648
	System.Void set_TpAccessoryManager(WizardGames.Soc.SocClient.Weapon.AccessoryManager value); // 0x059186c8
	WizardGames.Soc.SocClient.Weapon.AccessoryManager get_TpAccessoryManager(); // 0x05918748
	System.Void SubscribePropertyChange(); // 0x059187ac
	System.Void FillResPath(System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& prefabs, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo>& assets); // 0x059189d4
	System.Void CreateFxControllers(); // 0x05919540
	System.Void OnGoLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader loader); // 0x05919a0c
	System.Void OnDeploy(); // 0x05919f64
	System.Void OnHolster(); // 0x0591a078
	System.Void Release(); // 0x0591a13c
	System.Void ClearLoaderRes(); // 0x0591a284
	UnityEngine.GameObject get_AccessoryHostGo(); // 0x0591a3bc
	System.Void AccessoryChangePostProcess(WizardGames.Soc.SocClient.Weapon.AccessoryManager acc_manager, System.Collections.Generic.List<System.Int64> changeList); // 0x0591a454
	System.Boolean TryGetWeaponAccessory(WizardGames.Soc.Common.Data.DataItem.ItemSlot slot, WizardGames.Soc.SocClient.Weapon.AccessoryGo& accessory); // 0x0591a4ec
	System.Void AfterAccessoryCreated(WizardGames.Soc.SocClient.Weapon.AccessoryGo acc); // 0x0591a624
	System.Boolean get_Deployed(); // 0x0591a698
	System.Boolean TryGetHangPoint(System.String pointName, UnityEngine.Transform& point); // 0x0591a81c
	System.Void .ctor(); // 0x0591a8f8
	System.Void <CreateFxControllers>b__12_0(); // 0x0591a95c
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemHostGo : 
{
	
	WizardGames.Soc.Common.Entity.IEntity get_HostEntity(); // 0x054e7844
	WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent get_ObjectComponent(); // 0x054e7844
	WizardGames.Soc.Common.Entity.IHeldItemEntity GetHeldItemEntity(System.Int64 entityID); // 0x054e931c
	System.Void StartSwitchHeldItem(WizardGames.Soc.Common.Entity.IHeldItemEntity entity); // 0x05523a54
	System.Void OnHeldItemDeploy(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo heldItem); // 0x05523a54
	System.Void OnHeldItemHolster(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo heldItem); // 0x05523a54
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemAssetLoaderHandler : 
{
	
	System.Void OnAssetLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemAssetLoader loader); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.HeldItemAssetLoader : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable, WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemSingleLoader
{
	System.Int32 <LoadIndex>k__BackingField; // 0x10
	UnityEngine.Object <Asset>k__BackingField; // 0x18
	WizardGames.AssetPool.AssetPoolHandle AssetHandle; // 0x20
	WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemAssetLoaderHandler <Handler>k__BackingField; // 0x28
	System.UInt64 task; // 0x30
	System.String <assetPath>k__BackingField; // 0x38
	UnityEngine.GameObject tmpGo; // 0x40
	static WizardGames.Soc.SocClient.Player.HeldItem.HeldItemAssetLoader CreateLoader(WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemAssetLoaderHandler handler, WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo info, System.Int32 index); // 0x0591a9c8
	System.Int32 get_LoadIndex(); // 0x0591ace0
	System.Void set_LoadIndex(System.Int32 value); // 0x0591ad44
	UnityEngine.Object get_Asset(); // 0x0591adbc
	WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemAssetLoaderHandler get_Handler(); // 0x0591ae20
	System.Void set_Handler(WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemAssetLoaderHandler value); // 0x0591ae84
	System.String get_assetPath(); // 0x0591af04
	System.Void set_assetPath(System.String value); // 0x0591af68
	System.Void Load(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo info); // 0x0591aba4
	System.Void OnNewLoadFinish(System.UInt64 loaderId, Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.AssetPool.AssetGroupData> results); // 0x0591afe8
	System.Void Release(); // 0x0591b224
	System.Void OnGet(); // 0x0591b2c4
	System.Void OnRelease(); // 0x0591b324
	System.Void OnDestroy(); // 0x0591b508
	System.Void .ctor(); // 0x0591b568
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemBatchLoaderHandler : 
{
	
	System.Void OnBatchLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader loader); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	System.String Path; // 0x10
	System.Int32 InstanceTypeId; // 0x18
	System.Int32 Priority; // 0x1c
	static WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo Create(System.String path, System.Int32 instanceTypeId, System.Int32 priority); // 0x058ff108
	System.Void OnGet(); // 0x0591b5d8
	System.Void OnRelease(); // 0x0591b638
	System.Void OnDestroy(); // 0x0591b6c0
	System.Void .ctor(); // 0x0591b720
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable, WizardGames.Soc.SocClient.Player.HeldItem.IGameObjectLoaderHandler, WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemAssetLoaderHandler
{
	SocLogger logger; // 0x10
	WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemBatchLoaderHandler <Handler>k__BackingField; // 0x18
	System.Collections.Generic.Dictionary<System.Int32,UnityEngine.GameObject> GameObjects; // 0x20
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader.AssetInfo> Assets; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemSingleLoader> loaders; // 0x30
	System.Int32 loadFlag; // 0x38
	System.Int32 loadCheckFlag; // 0x3c
	System.Int32 prefabCount; // 0x40
	static WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader CreateLoader(WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemBatchLoaderHandler handler, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo> prefabs, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo> assets); // 0x0591b788
	WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemBatchLoaderHandler get_Handler(); // 0x0591be10
	System.Void set_Handler(WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemBatchLoaderHandler value); // 0x0591be74
	System.Boolean get_Finish(); // 0x0591bef4
	System.Void Init(System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo> prefabs, System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo> assets); // 0x0591b8bc
	System.Void Release(); // 0x0591c34c
	System.Void OnGet(); // 0x0591c6d0
	System.Void OnRelease(); // 0x0591c730
	System.Void OnDestroy(); // 0x0591c790
	System.Void OnGameObjectLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemGameObjectLoader loader); // 0x0591c7f0
	System.Void OnAssetLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemAssetLoader loader); // 0x0591c990
	System.Void CheckLoader(); // 0x0591c214
	System.Void .ctor(); // 0x0591ccb4
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader.AssetInfo : System.ValueType
{
	System.Boolean Valid; // 0x10
	System.String loadPath; // 0x18
	UnityEngine.Object asset; // 0x20
	WizardGames.AssetPool.AssetPoolHandle assetHandle; // 0x28
	
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Player.HeldItem.IGameObjectLoaderHandler : 
{
	
	System.Void OnGameObjectLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemGameObjectLoader loader); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.HeldItemGameObjectLoader : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable, WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemSingleLoader
{
	static SocLogger logger; // 0x0
	System.Int32 <LoadIndex>k__BackingField; // 0x10
	UnityEngine.GameObject <GameObject>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Player.HeldItem.IGameObjectLoaderHandler <Handler>k__BackingField; // 0x20
	System.UInt64 taskId; // 0x28
	System.String assetPath; // 0x30
	static WizardGames.Soc.SocClient.Player.HeldItem.HeldItemGameObjectLoader CreateLoader(WizardGames.Soc.SocClient.Player.HeldItem.IGameObjectLoaderHandler handler, WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo info, System.Int32 index); // 0x0591bf60
	System.Int32 get_LoadIndex(); // 0x0591d03c
	System.Void set_LoadIndex(System.Int32 value); // 0x0591d0a0
	UnityEngine.GameObject get_GameObject(); // 0x0591d118
	System.Void set_GameObject(UnityEngine.GameObject value); // 0x0591d17c
	WizardGames.Soc.SocClient.Player.HeldItem.IGameObjectLoaderHandler get_Handler(); // 0x0591d1fc
	System.Void set_Handler(WizardGames.Soc.SocClient.Player.HeldItem.IGameObjectLoaderHandler value); // 0x0591d260
	System.Void Load(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo info); // 0x0591ceb4
	System.Void OnGoLoaded(UnityEngine.GameObject go, System.Object[] ps); // 0x0591d2e0
	System.Void Release(); // 0x0591d48c
	System.Void OnGet(); // 0x0591d6c8
	System.Void OnRelease(); // 0x0591d728
	System.Void OnDestroy(); // 0x0591d834
	System.Void .ctor(); // 0x0591d894
	static System.Void .cctor(); // 0x0591d904
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemSingleLoader : 
{
	
	System.Void Release(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.ALocalCustomWrapper : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.CustomType.EmbeddedCustomBase S; // 0x10
	WizardGames.Soc.Common.CustomType.EmbeddedCustomBase L; // 0x18
	System.Void Release(); // 0x0591d9d8
	System.Boolean CompareHistory(System.Int64 cmd, WizardGames.Soc.Common.Entity.HistoryWeaponEntity archiveHistory, WizardGames.Soc.Common.Entity.IItemEntity server, System.String& rst); // 0x054c6818
	System.Void RollBack(WizardGames.Soc.Common.Entity.IItemEntity server); // 0x05523a54
	System.Void .ctor(); // 0x0591db7c
	static System.Void .cctor(); // 0x0591dbe4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.LocalWeaponCustomWrapper : WizardGames.Soc.SocClient.Player.HeldItem.ALocalCustomWrapper
{
	WizardGames.Soc.Common.CustomType.WeaponCustom <Source>k__BackingField; // 0x20
	WizardGames.Soc.Common.CustomType.WeaponCustom <Local>k__BackingField; // 0x28
	System.Collections.Generic.HashSet<System.Int64> HeldItemSubscribeIds; // 0x30
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Player.HeldItem.ALocalCustomWrapper> accessories; // 0x38
	WizardGames.Soc.Common.CustomType.WeaponCustom get_Source(); // 0x0591dcb8
	System.Void set_Source(WizardGames.Soc.Common.CustomType.WeaponCustom value); // 0x0591dd1c
	WizardGames.Soc.Common.CustomType.WeaponCustom get_Local(); // 0x0591dd9c
	System.Void set_Local(WizardGames.Soc.Common.CustomType.WeaponCustom value); // 0x0591de00
	System.Void .ctor(WizardGames.Soc.Common.CustomType.WeaponCustom source, WizardGames.Soc.Common.CustomType.WeaponCustom local); // 0x0591de80
	System.Void OnMaxConditionChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single o, System.Single n); // 0x0591f6dc
	System.Void OnClipCapcityChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldCap, System.Int32 newCap); // 0x0591f7c4
	System.Void OnSkinChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldSkin, System.Int64 newSkin); // 0x0591f8ac
	System.Void OnClipChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldClip, System.Int32 newClip); // 0x0591f994
	System.Void OnAccessoryChange0(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldAcc, WizardGames.Soc.Share.Framework.CustomTypeBase newAcc); // 0x0591fb28
	System.Void OnAccessoryChange1(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldAcc, WizardGames.Soc.Share.Framework.CustomTypeBase newAcc); // 0x0591febc
	System.Void OnAccessoryChange2(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldAcc, WizardGames.Soc.Share.Framework.CustomTypeBase newAcc); // 0x05920250
	System.Void OnAccessoryChange3(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldAcc, WizardGames.Soc.Share.Framework.CustomTypeBase newAcc); // 0x059205e4
	System.Void Release(); // 0x05920978
	System.Boolean CompareHistory(System.Int64 cmd, WizardGames.Soc.Common.Entity.HistoryWeaponEntity archiveHistory, WizardGames.Soc.Common.Entity.IItemEntity server, System.String& rst); // 0x05920ef0
	System.Void RollBack(WizardGames.Soc.Common.Entity.IItemEntity server); // 0x059214c0
	System.Boolean AccChange(WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom local, WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom server); // 0x05921ee4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.LocalMeleeCustomWrapper : WizardGames.Soc.SocClient.Player.HeldItem.ALocalCustomWrapper
{
	WizardGames.Soc.Common.CustomType.MeleeCustom <Source>k__BackingField; // 0x20
	WizardGames.Soc.Common.CustomType.MeleeCustom <Local>k__BackingField; // 0x28
	System.Collections.Generic.HashSet<System.Int64> HeldItemSubscribeIds; // 0x30
	WizardGames.Soc.Common.CustomType.MeleeCustom get_Source(); // 0x05921f94
	System.Void set_Source(WizardGames.Soc.Common.CustomType.MeleeCustom value); // 0x05921ff8
	WizardGames.Soc.Common.CustomType.MeleeCustom get_Local(); // 0x05922078
	System.Void set_Local(WizardGames.Soc.Common.CustomType.MeleeCustom value); // 0x059220dc
	System.Void .ctor(WizardGames.Soc.Common.CustomType.MeleeCustom source, WizardGames.Soc.Common.CustomType.MeleeCustom local); // 0x0592215c
	System.Void OnMaxConditionChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single o, System.Single n); // 0x05922728
	System.Void OnSkinChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldSkin, System.Int64 newSkin); // 0x05922810
	System.Void OnClipChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldClip, System.Int32 newClip); // 0x059228f8
	System.Void Release(); // 0x05922a8c
	System.Boolean CompareHistory(System.Int64 cmd, WizardGames.Soc.Common.Entity.HistoryWeaponEntity archiveHistory, WizardGames.Soc.Common.Entity.IItemEntity server, System.String& rst); // 0x05922ec0
	System.Void RollBack(WizardGames.Soc.Common.Entity.IItemEntity server); // 0x0592346c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.LocalUseItemCustomWrapper : WizardGames.Soc.SocClient.Player.HeldItem.ALocalCustomWrapper
{
	WizardGames.Soc.Common.CustomType.UseItemCustom <Source>k__BackingField; // 0x20
	WizardGames.Soc.Common.CustomType.UseItemCustom <Local>k__BackingField; // 0x28
	System.Collections.Generic.HashSet<System.Int64> HeldItemSubscribeIds; // 0x30
	WizardGames.Soc.Common.CustomType.UseItemCustom get_Source(); // 0x059237dc
	System.Void set_Source(WizardGames.Soc.Common.CustomType.UseItemCustom value); // 0x05923840
	WizardGames.Soc.Common.CustomType.UseItemCustom get_Local(); // 0x059238c0
	System.Void set_Local(WizardGames.Soc.Common.CustomType.UseItemCustom value); // 0x05923924
	System.Void .ctor(WizardGames.Soc.Common.CustomType.UseItemCustom source, WizardGames.Soc.Common.CustomType.UseItemCustom local); // 0x059239a4
	System.Void OnMaxConditionChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single o, System.Single n); // 0x05923ea8
	System.Void OnSkinChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldSkin, System.Int64 newSkin); // 0x05923f90
	System.Void Release(); // 0x05924078
	System.Boolean CompareHistory(System.Int64 cmd, WizardGames.Soc.Common.Entity.HistoryWeaponEntity archiveHistory, WizardGames.Soc.Common.Entity.IItemEntity server, System.String& rst); // 0x059244ac
	System.Void RollBack(WizardGames.Soc.Common.Entity.IItemEntity server); // 0x059248b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.LocalThrowWeaponCustomWrapper : WizardGames.Soc.SocClient.Player.HeldItem.ALocalCustomWrapper
{
	WizardGames.Soc.Common.CustomType.ThrowWeaponCustom <Source>k__BackingField; // 0x20
	WizardGames.Soc.Common.CustomType.ThrowWeaponCustom <Local>k__BackingField; // 0x28
	System.Collections.Generic.HashSet<System.Int64> HeldItemSubscribeIds; // 0x30
	WizardGames.Soc.Common.CustomType.ThrowWeaponCustom get_Source(); // 0x05924ab0
	System.Void set_Source(WizardGames.Soc.Common.CustomType.ThrowWeaponCustom value); // 0x05924b14
	WizardGames.Soc.Common.CustomType.ThrowWeaponCustom get_Local(); // 0x05924b94
	System.Void set_Local(WizardGames.Soc.Common.CustomType.ThrowWeaponCustom value); // 0x05924bf8
	System.Void .ctor(WizardGames.Soc.Common.CustomType.ThrowWeaponCustom source, WizardGames.Soc.Common.CustomType.ThrowWeaponCustom local); // 0x05924c78
	System.Void OnMaxConditionChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single o, System.Single n); // 0x05925304
	System.Void OnIsRFDetonationChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x059253ec
	System.Void OnSkinChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldSkin, System.Int64 newSkin); // 0x059254d4
	System.Void Release(); // 0x059255bc
	System.Boolean CompareHistory(System.Int64 cmd, WizardGames.Soc.Common.Entity.HistoryWeaponEntity archiveHistory, WizardGames.Soc.Common.Entity.IItemEntity server, System.String& rst); // 0x059259f0
	System.Void RollBack(WizardGames.Soc.Common.Entity.IItemEntity server); // 0x05925df4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.LocalHeldItemCustomWrapper : WizardGames.Soc.SocClient.Player.HeldItem.ALocalCustomWrapper
{
	WizardGames.Soc.Common.CustomType.HeldItemCustom <Source>k__BackingField; // 0x20
	WizardGames.Soc.Common.CustomType.HeldItemCustom <Local>k__BackingField; // 0x28
	System.Collections.Generic.HashSet<System.Int64> HeldItemSubscribeIds; // 0x30
	WizardGames.Soc.Common.CustomType.HeldItemCustom get_Source(); // 0x05925ff4
	System.Void set_Source(WizardGames.Soc.Common.CustomType.HeldItemCustom value); // 0x05926058
	WizardGames.Soc.Common.CustomType.HeldItemCustom get_Local(); // 0x059260d8
	System.Void set_Local(WizardGames.Soc.Common.CustomType.HeldItemCustom value); // 0x0592613c
	System.Void .ctor(WizardGames.Soc.Common.CustomType.HeldItemCustom source, WizardGames.Soc.Common.CustomType.HeldItemCustom local); // 0x059261bc
	System.Void OnMaxConditionChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single o, System.Single n); // 0x05926788
	System.Void OnSkinChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldSkin, System.Int64 newSkin); // 0x05926870
	System.Void OnCollectChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldV, System.Int32 newV); // 0x05926958
	System.Void Release(); // 0x05926a40
	System.Boolean CompareHistory(System.Int64 cmd, WizardGames.Soc.Common.Entity.HistoryWeaponEntity archiveHistory, WizardGames.Soc.Common.Entity.IItemEntity server, System.String& rst); // 0x05926e74
	System.Void RollBack(WizardGames.Soc.Common.Entity.IItemEntity server); // 0x05927278
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.LocalBaseCustomWrapper : WizardGames.Soc.SocClient.Player.HeldItem.ALocalCustomWrapper
{
	WizardGames.Soc.Common.CustomType.EmbeddedCustomBase <Source>k__BackingField; // 0x20
	WizardGames.Soc.Common.CustomType.EmbeddedCustomBase <Local>k__BackingField; // 0x28
	System.Collections.Generic.HashSet<System.Int64> HeldItemSubscribeIds; // 0x30
	WizardGames.Soc.Common.CustomType.EmbeddedCustomBase get_Source(); // 0x05927478
	System.Void set_Source(WizardGames.Soc.Common.CustomType.EmbeddedCustomBase value); // 0x059274dc
	WizardGames.Soc.Common.CustomType.EmbeddedCustomBase get_Local(); // 0x0592755c
	System.Void set_Local(WizardGames.Soc.Common.CustomType.EmbeddedCustomBase value); // 0x059275c0
	System.Void .ctor(WizardGames.Soc.Common.CustomType.EmbeddedCustomBase source, WizardGames.Soc.Common.CustomType.EmbeddedCustomBase local); // 0x05927640
	System.Void Release(); // 0x05927994
	System.Boolean CompareHistory(System.Int64 cmd, WizardGames.Soc.Common.Entity.HistoryWeaponEntity archiveHistory, WizardGames.Soc.Common.Entity.IItemEntity server, System.String& rst); // 0x05927dc8
	System.Void RollBack(WizardGames.Soc.Common.Entity.IItemEntity server); // 0x05927e64
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.LocalWeaponAccessoryItemCustomWrapper : WizardGames.Soc.SocClient.Player.HeldItem.ALocalCustomWrapper
{
	WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom <Source>k__BackingField; // 0x20
	WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom <Local>k__BackingField; // 0x28
	System.Collections.Generic.HashSet<System.Int64> HeldItemSubscribeIds; // 0x30
	WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom get_Source(); // 0x05927ed8
	System.Void set_Source(WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom value); // 0x05927f3c
	WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom get_Local(); // 0x05927fbc
	System.Void set_Local(WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom value); // 0x05928020
	System.Void .ctor(WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom source, WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom local); // 0x0591f064
	System.Void OnMaxConditionChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single o, System.Single n); // 0x059280a0
	System.Void OnStatusChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldStatus, System.Int32 newStatus); // 0x05928188
	System.Void OnConditionChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldCondition, System.Single newCondition); // 0x05928270
	System.Void OnSkinChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldSkin, System.Int64 newSkin); // 0x05928358
	System.Void Release(); // 0x05928440
	System.Boolean CompareHistory(System.Int64 cmd, WizardGames.Soc.Common.Entity.HistoryWeaponEntity archiveHistory, WizardGames.Soc.Common.Entity.IItemEntity server, System.String& rst); // 0x05928874
	System.Void RollBack(WizardGames.Soc.Common.Entity.IItemEntity server); // 0x05928910
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.LocalHeldItemEntityController : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Entity.PlayerEntity <Source>k__BackingField; // 0x10
	WizardGames.Soc.Common.Entity.PlayerEntity <Target>k__BackingField; // 0x18
	System.Collections.Generic.HashSet<System.Int64> HeldItemSubscribeIds; // 0x20
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Player.HeldItem.ALocalCustomWrapper> HeldItemWrappers; // 0x28
	static T Clone<T>(WizardGames.Soc.Share.Framework.IPredictType source); // 0x052af1f0
	WizardGames.Soc.Common.Entity.PlayerEntity get_Source(); // 0x05928984
	System.Void set_Source(WizardGames.Soc.Common.Entity.PlayerEntity value); // 0x059289e8
	WizardGames.Soc.Common.Entity.PlayerEntity get_Target(); // 0x05928a68
	System.Void set_Target(WizardGames.Soc.Common.Entity.PlayerEntity value); // 0x05928acc
	System.Void .ctor(WizardGames.Soc.Common.Entity.PlayerEntity source, WizardGames.Soc.Common.Entity.PlayerEntity target); // 0x05928b4c
	System.Void Link(WizardGames.Soc.Common.Entity.PlayerEntity source, WizardGames.Soc.Common.Entity.PlayerEntity target); // 0x05928c84
	System.Void DisLink(); // 0x0592b138
	WizardGames.Soc.Common.Entity.IItemEntity UpdateData(WizardGames.Soc.Common.Entity.IItemEntity old, WizardGames.Soc.Common.Entity.IItemEntity current); // 0x0592a57c
	System.Void OnNullHandChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase pre, WizardGames.Soc.Share.Framework.CustomTypeBase cur); // 0x0592b5bc
	System.Void OnHeldItemChange1(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase pre, WizardGames.Soc.Share.Framework.CustomTypeBase cur); // 0x0592b770
	System.Void OnHeldItemChange2(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase pre, WizardGames.Soc.Share.Framework.CustomTypeBase cur); // 0x0592b8dc
	System.Void OnHeldItemChange3(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase pre, WizardGames.Soc.Share.Framework.CustomTypeBase cur); // 0x0592ba48
	System.Void OnHeldItemChange4(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase pre, WizardGames.Soc.Share.Framework.CustomTypeBase cur); // 0x0592bbb4
	System.Void OnHeldItemChange5(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase pre, WizardGames.Soc.Share.Framework.CustomTypeBase cur); // 0x0592bd20
	System.Void OnHeldItemChange6(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase pre, WizardGames.Soc.Share.Framework.CustomTypeBase cur); // 0x0592be8c
	System.Void OnHeldItemChange7(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase pre, WizardGames.Soc.Share.Framework.CustomTypeBase cur); // 0x0592bff8
	System.Void OnHeldItemChange8(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase pre, WizardGames.Soc.Share.Framework.CustomTypeBase cur); // 0x0592c164
	System.Void OnHeldItemChangeItemModel(WizardGames.Soc.Share.Framework.AbstractCustomList.ECustomListOpType<WizardGames.Soc.Common.CustomType.EmbeddedCustomBase> customListOpType, System.Int32 index, WizardGames.Soc.Common.CustomType.EmbeddedCustomBase value); // 0x0592c2d0
	System.Void OnHeldItemChangeHidden(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase pre, WizardGames.Soc.Share.Framework.CustomTypeBase cur); // 0x0592c9d4
	System.Boolean TryGetWrapper(System.Int64 id, WizardGames.Soc.SocClient.Player.HeldItem.ALocalCustomWrapper& wrapper); // 0x0592ccfc
	System.Boolean TryGetHeldItem(System.Int64 id, WizardGames.Soc.Common.CustomType.EmbeddedCustomBase& entity); // 0x0592cda4
	System.Void OnReconnect(WizardGames.Soc.Common.Entity.PlayerEntity source); // 0x0592ce98
	System.Boolean CheckItemChanged(WizardGames.Soc.Common.Entity.IItemEntity sourceitem, WizardGames.Soc.Common.Entity.IItemEntity targetitem); // 0x0592dcf8
	System.Void Release(); // 0x0592de58
	static System.Void .cctor(); // 0x0592df70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.MonsterHostHeldItemGoController : WizardGames.Soc.SocClient.Player.HeldItem.BaseHostHeldItemGoController
{
	WizardGames.Soc.Common.Entity.MonsterEntity <HostMonster>k__BackingField; // 0x58
	System.Collections.Generic.HashSet<System.Int64> subscribeIDs; // 0x60
	WizardGames.Soc.Common.Entity.MonsterEntity get_HostMonster(); // 0x0592e044
	System.Void set_HostMonster(WizardGames.Soc.Common.Entity.MonsterEntity value); // 0x0592e0a8
	System.Void .ctor(WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemHostGo host, WizardGames.Soc.Common.Entity.MonsterEntity monster); // 0x0592e128
	System.Void OnCurrentHeldItemChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int64 oldValue, System.Int64 newValue); // 0x0592e784
	System.Boolean get_EnableCache(); // 0x0592e920
	System.Void Release(); // 0x0592e984
	WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo CreateHeldItemGo(WizardGames.Soc.Common.Entity.IHeldItemEntity entity, WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemHostGo host); // 0x0592eb88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.PlayerHostHeldItemGoController : WizardGames.Soc.SocClient.Player.HeldItem.BaseHostHeldItemGoController
{
	WizardGames.Soc.Common.Entity.PlayerEntity <HostPlayer>k__BackingField; // 0x58
	System.Boolean <IsFp>k__BackingField; // 0x60
	System.Collections.Generic.HashSet<System.Int64> subscribeIDs; // 0x68
	System.Collections.Generic.HashSet<System.Int64> tmp; // 0x70
	System.Boolean canCache; // 0x78
	WizardGames.Soc.Common.Entity.PlayerEntity get_HostPlayer(); // 0x0592edc8
	System.Void set_HostPlayer(WizardGames.Soc.Common.Entity.PlayerEntity value); // 0x0592ee2c
	System.Boolean get_IsFp(); // 0x0592eeac
	System.Void set_IsFp(System.Boolean value); // 0x0592ef10
	System.Boolean get_EnableCache(); // 0x0592ef8c
	System.Void .ctor(WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemHostGo host, WizardGames.Soc.Common.Entity.PlayerEntity Player, System.Boolean isFp); // 0x059106b4
	System.Void OnHeldItemChanged(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase pre, WizardGames.Soc.Share.Framework.CustomTypeBase cur); // 0x0592f114
	System.Void OnHeldItemChangeItemModel(WizardGames.Soc.Share.Framework.AbstractCustomList.ECustomListOpType<WizardGames.Soc.Common.CustomType.EmbeddedCustomBase> customListOpType, System.Int32 index, WizardGames.Soc.Common.CustomType.EmbeddedCustomBase value); // 0x0592f348
	System.Void Release(); // 0x0592f6c8
	WizardGames.Soc.SocClient.Player.HeldItem.HeldItemWithHostGo CreateHeldItemGo(WizardGames.Soc.Common.Entity.IHeldItemEntity entity, WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemHostGo host); // 0x0592fa48
	System.Void SetCacheEnable(System.Boolean enable, System.Boolean fromGm); // 0x0592fc88
	System.Void OnLowMemory(); // 0x0592fe24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Player.HeldItem.ThrowParabolaController : System.Object, WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemBatchLoaderHandler
{
	UnityEngine.GameObject Root; // 0x10
	UnityEngine.LineRenderer Parabola; // 0x18
	UnityEngine.GameObject ThrowLineEndPoint; // 0x20
	WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader batchLoader; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo> PrefabLoadInfos; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo> AssetLoadInfos; // 0x38
	System.Collections.Generic.List<UnityEngine.Vector3> points; // 0x40
	WizardGames.AssetPool.AssetPoolHandle MatHandle; // 0x48
	UnityEngine.RaycastHit[] raycastHits; // 0x50
	System.Collections.Generic.List<WizardGames.Soc.Common.Combat.SocRaycastHit> hitList; // 0x58
	System.Collections.Generic.List<UnityEngine.RaycastHit> tempHits; // 0x60
	UnityEngine.Vector3[] pointsArray; // 0x68
	System.Void Init(UnityEngine.Transform myplayer); // 0x0592fe90
	System.Void OnBatchLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader loader); // 0x05930170
	System.Void Update(); // 0x05930294
	System.Void Release(); // 0x05931520
	System.Boolean TryGetColliderEntityId(UnityEngine.GameObject colliderGo, WizardGames.Soc.Common.Entity.IEntity& entity, System.Int64& entityId, System.Int32& entityType); // 0x0593175c
	System.Boolean FilterRaycastHit(UnityEngine.GameObject colliderGo); // 0x05931998
	System.Boolean GetRaycastHit(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, System.Single maxDistance, System.Single radius, System.Int32 layerMask, UnityEngine.Vector3& hitPoint, System.Single& hitDistance); // 0x05931c20
	UnityEngine.Vector3[] GetParabolaPoints(UnityEngine.Vector3 startPos, System.Numerics.Vector3 velocity, System.Single checkRadius, System.Int32 layerMask, System.Boolean& isShow, System.Single& Dis); // 0x05930ec0
	System.Void .ctor(); // 0x0593245c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Player.Animation.ESnapEvent : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Player.Animation.ESnapEvent Draw = 1;
	static WizardGames.Soc.SocClient.Player.Animation.ESnapEvent QuickDraw = 2;
	static WizardGames.Soc.SocClient.Player.Animation.ESnapEvent Fire = 3;
	static WizardGames.Soc.SocClient.Player.Animation.ESnapEvent OpenDoor = 4;
	static WizardGames.Soc.SocClient.Player.Animation.ESnapEvent PickUp = 5;
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Player.Animation.SnapEventData : System.ValueType
{
	System.Boolean bFromServer; // 0x10
	System.Int64 SourceId; // 0x18
	WizardGames.Soc.SocClient.Player.Animation.ESnapEvent SnapEvent; // 0x20
	System.Int64 Param1; // 0x28
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Player.Animation.TpAniConstData : System.ValueType
{
	System.Single PaddleRowDriveAnimLerp; // 0x10
	Unity.Mathematics.float3 VectorForward; // 0x14
	Unity.Mathematics.float3 VectorUp; // 0x20
	System.Single LocomotionLerpSpeed; // 0x2c
	System.Single PitchLimitAngle; // 0x30
	System.Single LadderLeftRotAngle; // 0x34
	System.Single LadderRightRotAngle; // 0x38
	System.Single LadderTurnAngle; // 0x3c
	System.Single LadderRightAniRotAngle; // 0x40
	System.Single LadderLeftAniRotAngle; // 0x44
	System.Single WalkSpeed; // 0x48
	System.Single StandCCHeight; // 0x4c
	System.Single LerpStandCrouchTime; // 0x50
	System.Single CharacterStandHeight; // 0x54
	System.Single CharacterCrouchHeight; // 0x58
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData : System.ValueType
{
	static SocLogger logger; // 0x0
	System.Int32 AnimatorInstanceId; // 0x10
	System.Int32 NowInstanceId; // 0x14
	System.Int64 MasterEntityId; // 0x18
	System.Int64 EntityId; // 0x20
	System.Int32 TimeFrame; // 0x28
	System.Boolean UroSkip; // 0x2c
	WizardGames.Soc.Common.Character.TpAniPlayerStateData PlayerStateData; // 0x30
	WizardGames.Soc.Common.Character.TpAniHeldItemData HeldItemData; // 0x140
	WizardGames.Soc.Common.Character.TpAniVehicleData VehicleData; // 0x188
	static System.Void Init(UnityEngine.Animator animator, WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& data, System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Character.TpVehicleSeatTbData> tpVehicleSeatTbData, WizardGames.Soc.Common.Entity.PlayerEntity entity, WizardGames.Soc.Common.Entity.PlayerEntity masterEntity); // 0x0552e1cc
	static System.Void RunLandTolerant(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& data, WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x05523a54
	static System.Void .cctor(); // 0x059512a8
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData : System.ValueType, System.IDisposable
{
	static SocLogger logger; // 0x0
	Unity.Collections.NativeArray<WizardGames.Soc.Common.Character.TpAniBoneMask> LocomotionLayerWeightArray; // 0x10
	Unity.Collections.NativeArray<System.Single> OverrideLayerTimeArray; // 0x20
	Unity.Collections.NativeArray<System.Boolean> OverrideLayerStateLoopArray; // 0x30
	Unity.Collections.NativeArray<System.Single> LocomotionLayerTimeArray; // 0x40
	Unity.Collections.NativeArray<System.Boolean> LocomotionLayerSpecialArray; // 0x50
	Unity.Collections.NativeArray<System.Single> IkLocomotionLeft; // 0x60
	Unity.Collections.NativeArray<System.Single> IkLocomotionRight; // 0x70
	Unity.Collections.NativeArray<System.Single> IkLocomotionHorse; // 0x80
	Unity.Collections.NativeArray<System.Single> IkAdditiveLeft; // 0x90
	Unity.Collections.NativeArray<System.Single> IkAdditiveRight; // 0xa0
	Unity.Collections.NativeArray<System.Single> IkAdditiveHorse; // 0xb0
	Unity.Collections.NativeArray<System.Single> IkOverrideLeft; // 0xc0
	Unity.Collections.NativeArray<System.Single> IkOverrideRight; // 0xd0
	Unity.Collections.NativeArray<System.Single> IkOverrideHorse; // 0xe0
	System.IntPtr ActionToAoWeightAnimationCurves; // 0xf0
	System.IntPtr ActionToLocoWeightAnimationCurves; // 0xf8
	System.IntPtr OverrideWeightAnimationCurves; // 0x100
	System.IntPtr TurnInPlaceYawnCurves; // 0x108
	System.IntPtr StandCrouchLerpCurves; // 0x110
	System.Boolean IsChange; // 0x118
	static System.Void Init(WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& data, CommonUnity.Runtime.Animation.ClientAnim anim, WizardGames.Soc.Common.Entity.PlayerEntity entity, WizardGames.Soc.Common.Entity.PlayerEntity masterEntity); // 0x0595137c
	static System.Void UpdateLocomotionLayerWeightArray(CommonUnity.Runtime.Animation.ClientAnim anim); // 0x05951550
	static System.Void UpdateLayerStateTimeAndLoop(CommonUnity.Runtime.Animation.ClientAnim anim); // 0x05951884
	static System.Void UpdateLocomotionSpecial(CommonUnity.Runtime.Animation.ClientAnim anim); // 0x05951de0
	static System.Void UpdateActionToAoLayerWeightArray(CommonUnity.Runtime.Animation.ClientAnim anim); // 0x0595215c
	static System.Void UpdateActionToLocoLayerWeightArray(CommonUnity.Runtime.Animation.ClientAnim anim); // 0x05952c90
	static System.Void UpdateOverrideWeightAnimationCurves(CommonUnity.Runtime.Animation.ClientAnim anim); // 0x05953cac
	static System.Void UpdateTurnInPlaceYawCurve(CommonUnity.Runtime.Animation.ClientAnim anim); // 0x0595494c
	static System.Void UpdateStandCrouchLerpCurve(CommonUnity.Runtime.Animation.ClientAnim anim); // 0x05954e34
	static System.Void UpdateIkSamples(CommonUnity.Runtime.Animation.ClientAnim anim); // 0x0595531c
	static System.Void EnsureIkArray(Unity.Collections.NativeArray<System.Single>& arr, System.Int32 length); // 0x05955b20
	static System.Void SampleLayer<TEnum>(SerializableDictionary<TEnum,CommonUnity.Runtime.Character.Resource.IkCurveEntry> dict, Unity.Collections.NativeArray<System.Single> leftArr, Unity.Collections.NativeArray<System.Single> rightArr, Unity.Collections.NativeArray<System.Single> horseArr, System.Int32 sampleCount); // 0x052af1f0
	static System.Single SafeEval(UnityEngine.AnimationCurve curve, System.Single t); // 0x05955c3c
	static System.Void SetBoneWeightCurve(WizardGames.Soc.Common.Character.TpOcAniBoneCurveMask& aniBoneMask, System.Func<System.Int32,WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy> callback); // 0x059559c4
	static System.Void SetAoBoneWeightCurve(WizardGames.Soc.Common.Character.TpAoAniBoneCurveMask& aniBoneMask, System.Func<System.Int32,WizardGames.Soc.Common.Unity.Character.AnimationCurveProxy> callback); // 0x05955868
	static System.Void DynamicsExpandNativeArrayCapacity<T>(System.IntPtr& dataArray, System.Int32& realSize, System.Int32 dataSize); // 0x052af1f0
	static System.Void SetMaskWeight(WizardGames.Soc.Common.Character.TpAniBoneMask& aniBoneMask, WizardGames.Editor.SkeletonMaskWeightValue[] weightDics); // 0x05955798
	static System.Void SetMaskWeight(WizardGames.Soc.Common.Character.TpAniBoneMask& aniBoneMask, WizardGames.Soc.Common.Unity.Character.TpMetaLocomotionWeightProxy weightProxy); // 0x059556cc
	System.Void Dispose(); // 0x05955ce4
	static System.Void .cctor(); // 0x05955d44
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData : System.ValueType
{
	System.Int64 EntityId; // 0x10
	WizardGames.Soc.Common.Entity.TpAniPlayerLocalData PlayerLocalData; // 0x18
	WizardGames.Soc.Common.Unity.Character.AnimParametersTp AnimParams; // 0xc60
	WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData.TpIkResult IkLocomotion; // 0xd30
	WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData.TpIkResult IkAdditive; // 0xd3c
	WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData.TpIkResult IkOverride; // 0xd48
	static System.Void Init1(WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& data, Contexts.ClientContext context, WizardGames.Soc.Common.Entity.PlayerEntity entity, System.Boolean master, System.Int32 deltaTime, System.Boolean needUpdateMeta, UnityEngine.Animator animator); // 0x0552d360
	static System.Void Init2(WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& data, Contexts.ClientContext context, WizardGames.Soc.Common.Entity.PlayerEntity entity, System.Boolean master, System.Int32 deltaTime, System.Boolean needUpdateMeta, UnityEngine.Animator animator); // 0x0552d360
	static System.Void CopyTo(WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData data, WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x055045a0
	static System.Void SetFrame(WizardGames.Soc.Common.Entity.PlayerEntity entity, System.Boolean master, System.Int32 deltaTime, System.Boolean needUpdateMeta, UnityEngine.Animator animator); // 0x05523bcc
	static System.Void SetTime(WizardGames.Soc.Common.Entity.PlayerEntity entity, System.Int32 deltaTime); // 0x055056e8
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData.TpIkResult : System.ValueType
{
	System.Single Left; // 0x10
	System.Single Right; // 0x14
	System.Single Horse; // 0x18
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Player.Animation.TpAnimationJob : System.ValueType, Unity.Jobs.IJobParallelFor
{
	Unity.Collections.NativeArray<WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData> tpAnimationJobDataArray; // 0x10
	WizardGames.Soc.SocClient.Player.Animation.TpAniConstData tpConstData; // 0x20
	Unity.Collections.NativeArray<WizardGames.Soc.Common.Character.TpMaskWeightConfGroup> MaskArray; // 0x70
	Unity.Collections.NativeArray<WizardGames.Soc.Common.Character.TpMaskWeightConfGroup> AoMaskArray; // 0x80
	Unity.Collections.NativeArray<WizardGames.Soc.SocClient.Player.Animation.SnapEventData> snapEventDataArray; // 0x90
	Unity.Collections.NativeArray<WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData> tpAnimationResultJobDataArray; // 0xa0
	System.IntPtr TpAnimationNestedArrayJobData; // 0xb0
	System.Boolean ShouldTransitFromSnapshotPose; // 0xb8
	System.Int64 SelfEntityId; // 0xc0
	System.Int32 SnapEventCount; // 0xc8
	static System.ValueTuple<WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer,System.Int32>[] MoveLadderEnumCache; // 0x0
	static System.ValueTuple<WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer,System.Int32>[] MoveSwimEnumCache; // 0x8
	static System.ValueTuple<WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer,System.Int32>[] MoveInjuredEnumCache; // 0x10
	static System.ValueTuple<WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer,System.Int32>[] MoveJogEnumCache; // 0x18
	static System.ValueTuple<WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer,System.Int32>[] MoveWalkEnumCache; // 0x20
	static System.ValueTuple<WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer,System.Int32>[] MoveCrouchEnumCache; // 0x28
	System.Void UpdateAdditiveLayer(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, Unity.Collections.NativeArray<WizardGames.Soc.SocClient.Player.Animation.SnapEventData>& snapEventArray); // 0x05932b90
	System.Void ToAdditiveLayerState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, System.Int32 stateInt, WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EAdditiveLayer eAdditiveLayer, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime, System.Single playRate); // 0x05933038
	System.Single GetStateNormalizedTimeAdditiveLayer(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, System.Int32 stateIndex); // 0x059333a8
	System.Int32 GetAddStateHash(WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData); // 0x0593353c
	System.Void UpdateAddLayerLogicFrame_Params(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05932d98
	System.Void UpdateAddLayerLogicFrame_Tick(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, Unity.Collections.NativeArray<WizardGames.Soc.SocClient.Player.Animation.SnapEventData>& snapEventArray); // 0x05932e30
	System.Void UpdateFire(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, Unity.Collections.NativeArray<WizardGames.Soc.SocClient.Player.Animation.SnapEventData> snapEventArray); // 0x059335d0
	System.Void UpdateBolt(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, Unity.Collections.NativeArray<WizardGames.Soc.SocClient.Player.Animation.SnapEventData> snapEventArray); // 0x059338a0
	System.Void UpdateTryFire(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05933b88
	System.Void UpdateFireWarm(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams); // 0x05933cdc
	System.Void UpdateReload(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams); // 0x05933f70
	System.Void UpdateAddLayerLogicFrame_ToRender(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05932f7c
	System.Void UpdateAddLayerRenderFrame_StatePercent(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05932d00
	System.Void UpdateAOLayer(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05934380
	System.Void ToAoLayerState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, System.Int32 stateInt, WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EAimOffsetLayer eAimOffsetLayer, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime, System.Single playRate); // 0x05934ebc
	System.Single GetAnimationPitch(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, System.Single pitchLimitAngle); // 0x05935024
	System.Void UpdateAOLayerLogicFrame_Params(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05934780
	System.Void UpdateAOLayerLogicFrame_Tick(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05934850
	System.Void ChangeAoType(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EAimOffsetLayer nowTpAo, WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EAimOffsetLayer nextTpAo, System.Single transitionTime); // 0x059356f4
	System.Void UpdateSightProgress(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x059350d0
	System.Void UpdateAOLayerRenderFrame_Tick_IdleAo(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05934dec
	System.Void UpdateAOLayerRenderFrame_Tick_Other(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05934d1c
	System.Void UpdateUpDown(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x059345d4
	System.Void UpdateIdleAo(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05935bb0
	System.Void UpdateLadderYaw(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05935e40
	System.Void UpdateAoWeightLayer(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x059364e8
	System.Void GetActionAoWeight(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05936618
	WizardGames.Soc.Common.Character.TpAniActionToAoLayerWeight GetActionToAoLayerWeightByAddType(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData); // 0x05936b64
	WizardGames.Soc.Common.Character.TpAniActionToAoLayerWeight GetActionToAoLayerWeightByOcType(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData); // 0x05936ed8
	System.Boolean GetDetailWeightByLocoState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Character.TpAniActionToAoLayerWeight& tpAniActionToAoLayerWeight, WizardGames.Soc.Common.Character.TpAoAniBoneCurveMask& tpAniBoneMask); // 0x05936c2c
	System.Void SetAoOverrideTargetWeightTp(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Character.TpAoAniBoneCurveMask& boneMask, System.Single time, System.Boolean have); // 0x05936d64
	System.Void Execute(System.Int32 index); // 0x05937260
	System.Void CrossFadeInFixedTimeUnSafe(System.Int32 animatorInstanceId, System.Int32 stateInt, System.Single transitionTime, System.Int32 layer, System.Single normalizeTime, System.Single normalizedTransitionTime, UnityEngine.TransitionBlendMode transitionBlendMode, System.Boolean transitFromSnapshotPose); // 0x059331a8
	System.Void CrossFadeUnSafe(System.Int32 animatorInstanceId, System.Int32 stateInt, System.Single transitionTime, System.Int32 layer, System.Single normalizeTime, System.Single normalizedTransitionTime, UnityEngine.TransitionBlendMode transitionBlendMode, System.Boolean transitFromSnapshotPose); // 0x059332a8
	System.Void BeforeUpdate(WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData); // 0x05937538
	System.Boolean Approximately(System.Single a, System.Single b, System.Single epsilon); // 0x0593644c
	System.Single Angle(Unity.Mathematics.float3 from, Unity.Mathematics.float3 to); // 0x05938240
	System.Single SignedAngle(Unity.Mathematics.float3 from, Unity.Mathematics.float3 to, Unity.Mathematics.float3 axis); // 0x0593841c
	System.Single SmoothStep(System.Single from, System.Single to, System.Single t); // 0x0593859c
	System.Single Repeat(System.Single t, System.Single length); // 0x0593868c
	System.Single DeltaAngle(System.Single current, System.Single target); // 0x0593637c
	System.Single Clamp01(System.Single value); // 0x0593878c
	static System.Single SampleIk(Unity.Collections.NativeArray<System.Single>& samples, System.Int32 enumIndex, System.Single normTime); // 0x05938834
	System.Void UpdateIkLayers(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData); // 0x05938020
	System.Void UpdateIkLocomotion(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nested); // 0x059389a4
	System.Void UpdateIkAdditive(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nested); // 0x05938b6c
	System.Void UpdateIkOverride(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nested); // 0x05938d34
	System.Single Lerp(System.Single a, System.Single b, System.Single t); // 0x05935ae4
	System.Single ClampAngleTo180(System.Single angle); // 0x05939074
	System.Void AfterUpdate(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0593810c
	System.Single GetStateNormalizedTime(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, System.Int32 layerIndex, System.Int32 stateHash); // 0x05933458
	System.Void UpdateLocomotionLayer(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x059375d8
	System.Void SetLocomotionLayerWeightByState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Character.TpAniBoneMask boneMask, System.Single time, System.Boolean defaultValue, System.Boolean maxTime); // 0x05939c44
	System.Void ToLocomotionLayerState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, System.Int32 stateInt, WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer eLocomotionLayer, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime, System.Boolean defaultValue, System.Boolean ocBoneFlag, WizardGames.Soc.Common.Character.TpAniBoneMask ocAniBoneMask, System.Boolean transitFromSnapshotPose, System.Single playRate, System.Boolean skipWeight, System.Boolean changeState, System.Boolean needComparse); // 0x05939df4
	System.Void ChangeLocomotionLayerTime(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer nowStateType, System.Single playRate); // 0x0593a270
	System.Boolean InLocomotionLadder(WizardGames.Soc.Common.Entity.TpLadderEnum eEnum); // 0x0593a394
	System.Boolean InLocomotionLadder(WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer eLocomotionLayer); // 0x05935448
	System.Boolean InLocomotionMantle(WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer eLocomotionLayer); // 0x059353c8
	System.Boolean InLocomotionIdle(WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer eLocomotionLayer); // 0x0593a314
	System.Boolean InLocomotionJog(WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer eLocomotionLayer); // 0x059355dc
	System.Boolean InLocomotionSprint(WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer eLocomotionLayer); // 0x05935560
	System.Boolean InLocomotionAir(WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer eLocomotionLayer); // 0x05935674
	System.Boolean InLocomotionSwimIdle(WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer eLocomotionLayer); // 0x0593a410
	System.Boolean InLocomotionSwimJog(WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer eLocomotionLayer); // 0x0593a48c
	System.Boolean InLocomotionSwimSprint(WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer eLocomotionLayer); // 0x0593a50c
	System.Boolean InLocomotionRiderLocomotion(WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer eLocomotionLayer); // 0x059371e4
	System.Boolean InLocomotionRiderJump(WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer eLocomotionLayer); // 0x05937164
	System.Boolean InLocomotionRiderHalter(WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer eLocomotionLayer); // 0x059370e8
	System.Boolean InLocomotionParachute(WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer eLocomotionLayer); // 0x0593a588
	System.Boolean InLocomotionInjured(WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer eLocomotionLayer); // 0x0593a608
	System.Boolean InLocomotionInjuredMove(WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer eLocomotionLayer); // 0x0593a698
	System.Boolean InLocomotionInCap(WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer eLocomotionLayer); // 0x0593a718
	System.Boolean InLocomotionDrive(WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer eLocomotionLayer); // 0x0593a798
	System.Boolean InLocomotionZipline(WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer eLocomotionLayer); // 0x0593a818
	System.Boolean InLocomotionEmpty(WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer eLocomotionLayer); // 0x0593a898
	System.Int32 GetTpHorseJumpType(WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer eLocomotionLayer); // 0x0593a914
	System.Single GetStateNormalizedTimeLocomotionLayer(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, System.Int32 stateHash); // 0x05938fc4
	System.Int32 GetLocomotionStateHash(WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData); // 0x05938efc
	System.Void UpdateLocomotionLayerLogicFrame_ParamsBefore(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x059391bc
	System.Void UpdateLocomotionLayerLogicFrame_ParamsAfter(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05939a68
	System.Void UpdateLocomotionLayerLogicFrame_Tick(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x059392a4
	System.Boolean GoToLocomotionEmpty_Sleep(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Boolean& inState); // 0x0593b6c0
	System.Void UpdateLocomotionEmpty_Sleep(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0593d374
	System.Boolean GoToInjuredState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Boolean& inState); // 0x0593b844
	System.Void UpdateInjuredState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0593d40c
	System.Boolean GoToZiplineState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Boolean& inState); // 0x0593ba8c
	System.Void UpdateZiplineState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0593d570
	System.Boolean GoToRiderState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Boolean& inState); // 0x0593bd04
	System.Void UpdateRiderState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0593dc24
	System.Boolean GotoParachuteState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Boolean& inState); // 0x0593bff8
	System.Void UpdateParachuteState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0593de54
	System.Boolean IsDriverState(UnityEngine.AnimatorStateInfo info); // 0x05941518
	System.Boolean GoToDriveState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Boolean& inState); // 0x0593c17c
	System.Void UpdateDriveState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0593e2fc
	System.Boolean GoToMountState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Boolean& inState); // 0x0593c728
	System.Void UpdateMountState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0593eebc
	System.Boolean GoToSwimState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Boolean& inState); // 0x0593c87c
	System.Void UpdateSwimState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0593ef54
	System.Boolean GoToLadderState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Boolean& inState); // 0x0593cbd0
	System.Void UpdateLadderState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0593f0f8
	System.Boolean GoToMantleState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Boolean& inState); // 0x0593cd64
	System.Void UpdateMantleState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0593f21c
	System.Boolean GoToJumpState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Boolean& inState); // 0x0593cee4
	System.Void UpdateJumpState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0593f52c
	System.Boolean GoToJogState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Boolean& inState); // 0x0593d0d8
	System.Void UpdateJogState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0593ff34
	System.Void UpdateSprintState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05940210
	System.Boolean GoToIdleState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0593d254
	System.Void UpdateIdleState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05940464
	System.Void UpdateLocomotionLayerLogicFrame_ToRender(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05939b50
	System.Void UpdateCrawlState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05940574
	System.Void UpdateLieDownState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05940850
	System.Void UpdateRiderLocomotion(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Boolean isRide); // 0x05940c1c
	System.Void UpdateRiderHalter(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Boolean isRide); // 0x05940e38
	System.Void UpdateRiderJump(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Boolean isRide); // 0x05941054
	System.Void ToRiderJumpState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x05940a60
	System.Void UpdateSwimIdleState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x059419c8
	System.Void UpdateSwimJogState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05941dc8
	System.Void UpdateSwimSprintState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x059422ac
	System.Void LogicToStandDetailState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Single transitionTime, System.Boolean fixTime); // 0x05941634
	System.Boolean ToStandDetailState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData constData, System.Single transitionTime, System.Boolean fixTime); // 0x05945358
	System.Void CommonStandCrouchChangeLogic(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer& nextType, System.Single& normalizeTime, System.Single& transitionTime); // 0x05945edc
	System.Void ToHorseJumpStartState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x05944ed8
	System.Void ToHorseJumpLoopState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x05945058
	System.Void ToHorseJumpEndState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x059451d8
	System.Void KeepingHorseJumpState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x05944d80
	System.Void ToParachuteLocomotion(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x059412d8
	System.Void SwitchSwimLocomotion(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x05941700
	System.Void SwitchHipLocomotion(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x05943d70
	System.Void ToLocomotionInjuredMove(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, System.Int32 move8Dir, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime, System.Boolean SkipWeight, System.Boolean changeState); // 0x0594454c
	System.Void ToLocomotionSwimMove(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, System.Int32 move8Dir, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime, System.Boolean SkipWeight, System.Boolean changeState); // 0x05946390
	System.Void ToLocomotionLadderMove(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, System.Int32 move8Dir, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime, System.Boolean SkipWeight, System.Boolean changeState); // 0x05946df4
	System.Void ToLocomotionWalkMove(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Int32 move8Dir, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime, System.Boolean SkipWeight, System.Boolean changeState); // 0x05946560
	System.Void ToLocomotionJogMove(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Int32 move8Dir, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime, System.Boolean SkipWeight, System.Boolean changeState); // 0x0594683c
	System.Void ToLocomotionCrouchMove(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Int32 move8Dir, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime, System.Boolean SkipWeight, System.Boolean changeState); // 0x05946b18
	System.Void UpdateNewLadderState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05942770
	static System.Int32 GetDirectionCode(System.Int32 fb, System.Int32 lr); // 0x05946fc4
	System.Void ToRootMotionWarpingState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData); // 0x05943884
	System.Void ToJumpState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime); // 0x05943a84
	WizardGames.Soc.Common.Character.TpAniBoneMask GetLocomotionLayerBone(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp.ELocomotionLayer eLocomotionLayer); // 0x0593a1b0
	System.Void UpdateLocomotionLayerCommonParams(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0593ae7c
	System.Void UpdateMoveDirectionInCharacterCoordinate(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams); // 0x0593afb4
	System.Void CalculateMoveSpeed(WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.Common.Entity.TpAniPlayerLocalData& playerLocalData, WizardGames.Soc.Common.Character.TpAniPlayerStateData& playerStateData); // 0x0594471c
	System.Void CalculateLadderSpeed(WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.Common.Entity.TpAniPlayerLocalData& playerLocalData, WizardGames.Soc.Common.Character.TpAniPlayerStateData& playerStateData); // 0x059470f0
	System.Void UpdateJumpDir(WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.Common.Character.TpAniPlayerStateData playerStateData); // 0x059443f8
	System.Void UpdateLerpStandCrouch(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0593a9a8
	System.Void UpdateLocomotionLayerRenderFrame_StatePercent(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05939124
	System.Void UpdateLocomotionLayerRenderFrame_Tick(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05939824
	System.Void UpdateLocomotionLayerRenderFrame_Late(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x059399a0
	System.Void ResetTurnInPlaceData(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData); // 0x05947928
	System.Void UpdateLocomotionWeightLayer(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05937aa8
	System.Void OnSwitchWeaponLocomotionWeight(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05947a60
	System.Void GetActionLocomotionWeight(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05947cec
	WizardGames.Soc.Common.Character.TpAniActionToLocoLayerWeight GetActionToLocoLayerWeightByAddType(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData); // 0x05948448
	WizardGames.Soc.Common.Character.TpAniActionToLocoLayerWeight GetActionToLocoLayerWeightByOcType(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData); // 0x0594893c
	System.Boolean GetOverrideLayerWeightByState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Character.TpAniActionToLocoLayerWeight& tpAniActionToLocoLayerWeight, WizardGames.Soc.Common.Character.TpOcAniBoneCurveMask& tpAniBoneMask); // 0x05948510
	System.Void SetOverrideTargetWeightTp(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Character.TpOcAniBoneCurveMask& boneMask, System.Single time, System.Boolean have); // 0x0594872c
	System.Void UpdateOverrideLayer(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, Unity.Collections.NativeArray<WizardGames.Soc.SocClient.Player.Animation.SnapEventData>& snapEventArray); // 0x05937914
	System.Void ChangeOverrideLayerTime(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EOverrideLayer nowStateType, System.Single normalizeTime, System.Boolean fixedTime, System.Single playRate); // 0x059492d4
	System.Boolean CanOcActionInLadder(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EOverrideLayer toOverrideLayer); // 0x05949440
	System.Void ToOverrideLayerState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, System.Int32 stateInt, WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EOverrideLayer eOverrideLayer, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime, System.Single playRate); // 0x059494f4
	System.Boolean IsBow(WizardGames.Soc.Common.Unity.Defines.TableItemEnum itemType); // 0x05934300
	WizardGames.Soc.Common.Unity.Character.AnimType GetCurrentBowType(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& tpAnimationJobData, System.Boolean want); // 0x0594975c
	System.Single GetStateNormalizedTimeOverrideLayer(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, System.Int32 stateIndex); // 0x05937038
	System.Int32 GetOverStateHash(WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData); // 0x05936fa4
	System.Void UpdateOverLayerLogicFrame_Params(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05948bec
	System.Void UpdateOverLayerLogicFrame_Tick(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, Unity.Collections.NativeArray<WizardGames.Soc.SocClient.Player.Animation.SnapEventData>& snapEventArray); // 0x05948ed0
	System.Void UpdateEmpty(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x059499c8
	System.Void UpdateSleep(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05949a60
	System.Void UpdateBow(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05949ed0
	System.Void UpdateBoltInOc(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, Unity.Collections.NativeArray<WizardGames.Soc.SocClient.Player.Animation.SnapEventData> snapEventArray); // 0x0594b7e4
	System.Boolean WantToBowState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0594c490
	System.Void UpdateThrow(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0594a420
	System.Void UpdateSustainAttack(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0594a9c8
	System.Void UpdateInteraction(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0594ad9c
	System.Void UpdateAttack(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, Unity.Collections.NativeArray<WizardGames.Soc.SocClient.Player.Animation.SnapEventData> snapEventArray); // 0x0594b11c
	System.Void UpdateDraw(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, Unity.Collections.NativeArray<WizardGames.Soc.SocClient.Player.Animation.SnapEventData> snapEventArray); // 0x0594bae0
	System.Void UpdateQuickDraw(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, Unity.Collections.NativeArray<WizardGames.Soc.SocClient.Player.Animation.SnapEventData> snapEventArray); // 0x0594be54
	System.Void UpdateLadder(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0594c094
	System.Void UpdateHorseMount(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0594c258
	System.Void UpdateOverLayerLogicFrame_Late(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05949124
	System.Void SwitchAoWeightFlag(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0594c6b8
	System.Void UpdateReloadInOc(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams); // 0x0594b438
	System.Void UpdateOverLayerLogicFrame_ToRender(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x059491f4
	System.Void UpdateOverLayerRenderFrame_StatePercent(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05948a08
	System.Void UpdateOverrideLayerWeightLayer(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05937e50
	WizardGames.Soc.Common.Character.TpAniOverrideLayerWeight GetOverrideLayerWeightByOcType(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData); // 0x0594c7a8
	System.Void GetLastOverrideLayerWeightByOcType(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Character.TpAniOverrideLayerWeight& tpAniOverrideLayerWeight); // 0x0594c87c
	WizardGames.Soc.Common.Character.TpOcAniBoneCurveMask GetOverrideLayerWeightByState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Character.TpAniOverrideLayerWeight& tpAniOverrideLayerWeight); // 0x0594c960
	System.Boolean GetWeightTransitionTime(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, System.Single& time); // 0x0594ccf8
	System.Void SetOverrideLayerWeightByState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Character.TpOcAniBoneCurveMask& boneMask, System.Single time, System.Boolean change); // 0x0594cde0
	System.Void UpdatePoseLayer(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x059377d8
	System.Void ToPoseLayerState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, System.Int32 stateInt, WizardGames.Soc.Common.Unity.Character.AnimParametersTp.EPoseLayer ePoseLayer, System.Single transitionTime, System.Single normalizeTime, System.Boolean fixTime, System.Single playRate); // 0x0594d654
	System.Int32 GetVehicleType(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Boolean& driver, System.Boolean& passenger); // 0x05935268
	System.Boolean IsPaddle(WizardGames.Soc.Common.Unity.Defines.TableItemEnum targetWeaponEnum); // 0x0594d7c0
	System.Boolean ShouldToVehicleAimOffsetPose(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, System.Int32 vehicleType, System.Boolean isPassenger); // 0x0594d840
	System.Boolean ShouldToParachutePose(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData); // 0x0594d9b8
	System.Void UpdatePoseLayerLogicParams(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0594d2a4
	System.Void UpdateVehicleUpperBodyType(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0594da80
	System.Void UpdateVehicleLowerBodyType(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0594dba0
	System.Void OverrideLerpStandCrouch(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05944324
	System.Void UpdateVehicleType(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0594dc44
	System.Void UpdateLerpIdleLocomotion(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0594dd3c
	System.Void UpdatePoseLayerLogicFrameTick(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0594d3bc
	System.Boolean GoToPoseState_Sleep(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Boolean& inState); // 0x0594df00
	System.Boolean GoToVehiclePoseState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Boolean& inState); // 0x0594e0c4
	System.Boolean GoToSwimPoseState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Boolean& inState); // 0x0594e240
	System.Boolean GoToParachutePoseState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Boolean& inState); // 0x0594e410
	System.Boolean GoToPoseState(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData, System.Boolean& inState); // 0x0594e560
	System.Void UpdatePoseLayerRenderParams(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0594d584
	System.Void UpdateAimYawMountAAimYawBackMount(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0594e6d8
	System.Void FullRotation(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0594e80c
	System.Void NonFullRotation(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0594ec4c
	System.Void UpdatePoseWeightLayer(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05937c10
	System.Void SwitchPoseWeightFlag(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x0594f184
	System.Void UpdateTurnInPlaceLogic(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x059476bc
	System.Single ApplyTurnInPlaceAnim(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationNestedArrayJobData& nestedArrayJobData, WizardGames.Soc.Common.Unity.Character.AnimParametersTp& animParams, WizardGames.Soc.SocClient.Player.Animation.TpAniConstData& constData); // 0x05946124
	System.Void UpdateCommonMaskWeight(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, System.Int32 fullCapacity, Unity.Collections.NativeArray<WizardGames.Soc.Common.Character.TpMaskWeightConfGroup>& maskArray, WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup& group, System.Int32 layerIndex); // 0x0594cf9c
	System.Void UpdateAoMaskWeight(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, System.Int32 fullCapacity, Unity.Collections.NativeArray<WizardGames.Soc.Common.Character.TpMaskWeightConfGroup>& maskArray, WizardGames.Soc.Common.Character.TpAoMaskWeightRuntimeDataGroup& group, System.Int32 layerIndex); // 0x0593685c
	System.Void UpdateLocomotionMaskWeight(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, System.Int32 fullCapacity, Unity.Collections.NativeArray<WizardGames.Soc.Common.Character.TpMaskWeightConfGroup>& maskArray, WizardGames.Soc.Common.Character.TpMaskWeightRuntimeDataGroup& group, System.Int32 layerBaseIndex, System.Int32 layerAddIndex); // 0x05947f50
	System.Boolean LerpBoneWeight(WizardGames.Soc.SocClient.Player.Animation.TpAnimationJobData& jobData, WizardGames.Soc.SocClient.Player.Animation.TpAnimationResultJobData& resultJobData, WizardGames.Soc.Common.Character.TpMaskWeightRuntimeData& weightRuntime, WizardGames.Soc.Common.Character.TpMaskWeightConfGroup& maskBoneHash); // 0x0594f248
	static System.Void .cctor(); // 0x0594f3c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Plant.MgrPlant : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Plant.PlantSeedData> inventorySeedList; // 0x18
	WizardGames.Soc.SocClient.Ui.UIPlantScreenEffect plantScreenEffect; // 0x20
	System.Int32 <MagicNum>k__BackingField; // 0x28
	System.Int32 maxHybridPointNum; // 0x2c
	System.Collections.Generic.Dictionary<System.Int32,System.Int64> slot2NodeItemIdDic; // 0x30
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> nodeItemId2NumDic; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> nodeItemId2SeedIdDic; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.Alpha3PlantArgs> batchPlantParam; // 0x48
	System.Int32 get_InventoryTotalWater(); // 0x059563f8
	System.Int32 get_InventoryTotalManure(); // 0x05956590
	System.Void Init(); // 0x059566dc
	System.Void CleanUp(); // 0x0595683c
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Plant.PlantSeedData> GetInventoryTotalSeeds(); // 0x05956a3c
	System.Int32 SortSeeds(WizardGames.Soc.SocClient.Plant.PlantSeedData a, WizardGames.Soc.SocClient.Plant.PlantSeedData b); // 0x059573d4
	System.Void TryOpenWindow(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x059577cc
	System.Void PlayScreenFx(WizardGames.Soc.SocClient.Ui.UIPlantScreenEffect.EPlayPlantScreenEffectType plantScreenEffectType); // 0x05958524
	System.Void set_MagicNum(System.Int32 value); // 0x05958674
	System.Void InitHybridData(); // 0x0595674c
	System.Void PrePlant(System.Int32 slot, System.Int64 seedId, System.Int64 nodeItemId); // 0x059586ec
	System.Void CancelPrePlant(System.Int32 slot); // 0x05958a30
	System.Int32 GetPrePlantNum(System.Int64 nodeItemId); // 0x05958c58
	System.Int64 GetPrePlantNodeItemId(System.Int32 slot); // 0x05958d0c
	System.Int64 GetPrePlantSeedId(System.Int32 slot); // 0x05958dc0
	System.Void RequestPlant(WizardGames.Soc.SocClient.Plant.PlantBoxData plantBox); // 0x05958e84
	System.Int64 GetSeedNodeIndex(System.Int64 nodeItemId); // 0x0595932c
	System.Void ResetPrePlant(); // 0x059599e4
	System.Void .ctor(); // 0x05959ab0
	static System.Void .cctor(); // 0x05959cc4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Plant.MgrPlant.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Plant.MgrPlant.<>c <>9; // 0x0
	static System.Action <>9__11_1; // 0x8
	static System.Void .cctor(); // 0x05959d98
	System.Void .ctor(); // 0x05959dfc
	System.Void <TryOpenWindow>b__11_1(); // 0x05959e64
}

// Client.Runtime
class WizardGames.Soc.SocClient.Plant.MgrPlant.<>c__DisplayClass11_0 : System.Object
{
	WizardGames.Soc.SocClient.Plant.PlantBoxData plantBox; // 0x10
	WizardGames.Soc.Common.CustomType.BaseItemNode curItem; // 0x18
	System.Void .ctor(); // 0x05958200
	System.Void <TryOpenWindow>b__0(System.Boolean isSucess); // 0x05959ef4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Plant.MgrPlant.<>c__DisplayClass4_0 : System.Object
{
	System.Int32 inventoryTotalWater; // 0x10
	System.Void .ctor(); // 0x05956528
	System.Boolean <get_InventoryTotalWater>b__0(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05959fd8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Plant.HybridData : System.Object
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.List<System.Int32> SlotToPlantIndexs; // 0x10
	System.Collections.Generic.List<System.Int32> SlotPoints; // 0x18
	System.Collections.Generic.List<Assets.Scripts.Plant.PlantBoxItemData> hybridPlantDatas; // 0x20
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Single>> hybridPlantGeneProbDic; // 0x28
	System.Int32 slotCapacity; // 0x30
	System.Collections.Generic.List<System.Single> geneWeightTempList; // 0x38
	System.Void ResetData(); // 0x0595a0d4
	System.Void Refresh(System.Collections.Generic.List<Assets.Scripts.Plant.PlantBoxItemData> plantDatas); // 0x0595a290
	System.Void CalculateGeneProbability(); // 0x0595a318
	static System.Void .cctor(); // 0x0595aa0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Plant.PlantBoxData : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Component.PlantBoxComponent plantBoxComponent; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,Assets.Scripts.Plant.PlantBoxItemData> plantDic; // 0x18
	WizardGames.Soc.Share.Framework.BasicTypeList<System.Int32> manualLst; // 0x20
	WizardGames.Soc.Common.Data.Plant.PlantBoxConfig get_plantBoxCfg(); // 0x0595aae0
	System.Int64 get_EntityId(); // 0x059584b4
	System.Int32 get_Water(); // 0x0595abf0
	System.Void Init(WizardGames.Soc.Common.Component.PlantBoxComponent plantBoxComponent); // 0x0595ac60
	Assets.Scripts.Plant.PlantBoxItemData GetPlantData(System.Int64 idx); // 0x05959278
	System.Int32 GetPlantDataIndex(Assets.Scripts.Plant.PlantBoxItemData plantBoxItemData); // 0x0595b1b8
	System.Boolean HasAnyPlant(); // 0x0595b374
	System.Boolean CanManure(System.Boolean showFailedTips); // 0x0595b404
	System.Boolean CanWater(System.Boolean showFailedTips); // 0x0595b7ec
	System.Boolean CanHarvest(); // 0x0595b988
	System.Boolean CanSeed(System.Boolean showFailedTips); // 0x05958314
	System.Void UpdatePlants(WizardGames.Soc.Common.Component.PlantBoxComponent plantBox, System.Boolean isFireMsg); // 0x0595ad04
	System.Void RequestPlant(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.Alpha3PlantArgs> argList); // 0x0595959c
	System.Void RequestManure(System.Collections.Generic.List<System.Int32> slots); // 0x0595bb78
	System.Void RequestWater(); // 0x0595bfd0
	System.Void RequestHarvest(System.Int32 idx); // 0x0595c344
	System.Void RequestRemove(System.Int32 idx); // 0x0595c724
	System.Void RequestHybridizeFinish(System.Int32 magicNum, WizardGames.Soc.Share.Framework.BasicTypeList<System.Int32> pointIndexes, WizardGames.Soc.Share.Framework.BasicTypeList<System.Int32> pointValues, System.Int32 result); // 0x0595c9c4
	System.Void OnGet(); // 0x0595cc98
	System.Void OnRelease(); // 0x0595ccf8
	System.Void OnDestroy(); // 0x0595cee8
	System.Void .ctor(); // 0x0595cf48
	static System.Void .cctor(); // 0x0595d054
}

// Client.Runtime
class WizardGames.Soc.SocClient.Plant.PlantBoxData.<>c__DisplayClass12_0 : System.Object
{
	WizardGames.Soc.SocClient.Plant.PlantBoxData <>4__this; // 0x10
	Assets.Scripts.Plant.PlantBoxItemData plantBoxItemData; // 0x18
	System.Void .ctor(); // 0x0595b30c
	System.Boolean <GetPlantDataIndex>b__0(System.Int64 index); // 0x0595d128
}

// Client.Runtime
class WizardGames.Soc.SocClient.Plant.PlantSeedData : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	WizardGames.Soc.Common.CustomType.BaseItemNode <Seed>k__BackingField; // 0x10
	System.Int64 <CreateTime>k__BackingField; // 0x18
	WizardGames.Soc.Common.CustomType.BaseItemNode get_Seed(); // 0x0595d1dc
	System.Void set_Seed(WizardGames.Soc.Common.CustomType.BaseItemNode value); // 0x0595d240
	System.Int64 get_CreateTime(); // 0x0595d2c0
	System.Void set_CreateTime(System.Int64 value); // 0x0595d324
	System.Void Init(WizardGames.Soc.Common.CustomType.BaseItemNode seed); // 0x05957278
	System.Boolean get_LastUsed(); // 0x0595765c
	System.Int32 SeedAmount(System.Boolean isSelected); // 0x0595d39c
	System.Void OnGet(); // 0x0595d564
	System.Void OnRelease(); // 0x0595d614
	System.Void OnDestroy(); // 0x0595d674
	System.Void .ctor(); // 0x0595d6d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.PersistentData.BasePersistentData : System.Object
{
	
	System.Void OnInitOrReset(); // 0x0595d73c
	System.Void OnLoad(); // 0x0595d79c
	System.Void OnWillSave(); // 0x0595d7fc
	System.Void .ctor(); // 0x0595d85c
}

// Client.Runtime
class WizardGames.Soc.SocClient.PersistentData.SerializableDictionary<TKey,TValue> : System.Collections.Generic.Dictionary<TKey,TValue>, UnityEngine.ISerializationCallbackReceiver
{
	System.Collections.Generic.List<TKey> keys; // 0x0
	System.Collections.Generic.List<TValue> values; // 0x0
	System.Void OnBeforeSerialize(); // 0x055049cc
	System.Void OnAfterDeserialize(); // 0x055049cc
	System.Void .ctor(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.PersistentData.CommonAccountPersistentData : WizardGames.Soc.SocClient.PersistentData.BasePersistentData
{
	System.String lastSelectRespawnInfo; // 0x10
	System.String lastJoinSvrInfo; // 0x18
	System.Boolean isNewbieFinished; // 0x20
	WizardGames.Soc.SocClient.PersistentData.SerializableDictionary<System.String,System.Int32> friendRequestCD; // 0x28
	System.Boolean isNewbieRecommendSelectModeFinished; // 0x30
	System.Void OnInitOrReset(); // 0x0595d8c4
	System.Void .ctor(); // 0x0595d9a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.PersistentData.CommonGamePersistentData : WizardGames.Soc.SocClient.PersistentData.BasePersistentData
{
	System.Int64 lastGameTaskId; // 0x10
	System.Int64 lastUseSeedId; // 0x18
	System.Collections.Generic.List<System.Int64> finishedGuideBp; // 0x20
	System.Collections.Generic.List<System.Int64> AwakeTimes; // 0x28
	WizardGames.Soc.SocClient.PersistentData.SerializableDictionary<System.Int64,System.Int64> terrGuildDic; // 0x30
	System.Int64 lastMissionBookId; // 0x38
	System.Int64 lastSurvivalJudgeId; // 0x40
	System.Void OnInitOrReset(); // 0x0595da58
	System.Void .ctor(); // 0x0595db10
}

// Client.Runtime
class WizardGames.Soc.SocClient.PersistentData.MgrPersistentData : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger log; // 0x0
	System.String serverId; // 0x18
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.PersistentData.PersistentDataType,WizardGames.Soc.SocClient.PersistentData.BasePersistentData> accountPersistentDataDic; // 0x20
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.PersistentData.PersistentDataType,WizardGames.Soc.SocClient.PersistentData.BasePersistentData> gamePersistentDataDic; // 0x28
	System.String saveFileDir; // 0x30
	System.String saveJsonFileDir; // 0x38
	System.String curAccountFileDir; // 0x40
	System.String curGameFileDir; // 0x48
	System.Boolean isAccountLoaded; // 0x50
	System.Boolean isGameLoaded; // 0x51
	System.Void .ctor(); // 0x0595dc48
	System.Threading.Tasks.Task OnEnterWorld(); // 0x0595def8
	System.Void CleanUp(); // 0x0595e1a0
	System.Void LoadAll(System.String id, WizardGames.Soc.SocClient.PersistentData.PersistentDataBindingType lifeType); // 0x0595dfa4
	System.Void Load(WizardGames.Soc.SocClient.PersistentData.PersistentDataType persistentDataType, WizardGames.Soc.SocClient.PersistentData.PersistentDataBindingType lifeType, System.String fileDir); // 0x0595e3d4
	T GetAccountSaveData<T>(WizardGames.Soc.SocClient.PersistentData.PersistentDataType persistentDataType); // 0x052af1f0
	T GetGameSaveData<T>(WizardGames.Soc.SocClient.PersistentData.PersistentDataType persistentDataType); // 0x052af1f0
	T GetSaveData<T>(WizardGames.Soc.SocClient.PersistentData.PersistentDataType persistentDataType, WizardGames.Soc.SocClient.PersistentData.PersistentDataBindingType lifeType); // 0x052af1f0
	System.Void ModityCommonAccountValue(System.Action<WizardGames.Soc.SocClient.PersistentData.CommonAccountPersistentData> modity, System.Boolean saveImmediately); // 0x0595e778
	WizardGames.Soc.SocClient.PersistentData.CommonAccountPersistentData GetCommonAccountData(); // 0x0595e8d0
	WizardGames.Soc.SocClient.PersistentData.CommonGamePersistentData GetCommonGameData(); // 0x0595e950
	System.Void Reset(WizardGames.Soc.SocClient.PersistentData.PersistentDataBindingType lifeType); // 0x0595e214
	System.Void SaveAccountData(WizardGames.Soc.SocClient.PersistentData.PersistentDataType persistentDataType); // 0x0595e850
	System.Void SaveGameData(WizardGames.Soc.SocClient.PersistentData.PersistentDataType persistentDataType); // 0x0595ef64
	System.Void Save(WizardGames.Soc.SocClient.PersistentData.PersistentDataType persistentDataType, WizardGames.Soc.SocClient.PersistentData.PersistentDataBindingType lifeType); // 0x0595e9d0
	static System.Void .cctor(); // 0x0595efe4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.PersistentData.PersistentDataType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.PersistentData.PersistentDataType Common = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.PersistentData.PersistentDataBindingType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.PersistentData.PersistentDataBindingType Account = 0;
	static WizardGames.Soc.SocClient.PersistentData.PersistentDataBindingType Game = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Entity.MgrEntity : WizardGames.Soc.Common.Unity.Entity.BaseUnityMgrEntity
{
	SocLogger logger; // 0xa0
	System.Collections.Generic.HashSet<WizardGames.Soc.Common.Entity.IEntity> tryTriggerShortcutsEventNextFrame; // 0xa8
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PlayerEntity> PlayerColliderEntities; // 0xb0
	System.Collections.Generic.Dictionary<System.UInt64,WizardGames.Soc.Common.Entity.PlayerEntity> RoleId2PlayerEntity; // 0xb8
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.MonsterEntity> MonsterColliderEntities; // 0xc0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.PartEntity> PartColliderEntities; // 0xc8
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.Entity.TrainCarEntity> TrainCarEntities; // 0xd0
	System.Collections.Generic.Dictionary<System.String,System.Int32> EntityTypeStrToTableIdDic; // 0xd8
	System.Collections.Generic.List<System.Int64> OnDisconnectEntityIds; // 0xe0
	System.Action<System.Collections.Generic.List<System.Int64>,System.Boolean> OnDisconnectEvent; // 0xe8
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Share.Framework.EntityBase> localNewEntities; // 0xf0
	System.Action<WizardGames.Soc.Common.Entity.IEntity,System.Boolean> OnAddEntityEvent; // 0xf8
	System.Action<WizardGames.Soc.Common.Entity.IEntity,System.Boolean> OnRemoveEntityEvent; // 0x100
	WizardGames.Soc.Common.Entity.Collection.EntitySetCollection LocalCollection; // 0x108
	static System.Collections.Generic.HashSet<System.Int64> ProcessedChange; // 0x0
	System.Int32 get_MonsterCount(); // 0x0595f0b8
	System.Void Init(); // 0x0595f13c
	System.Threading.Tasks.Task OnExitWorld(); // 0x0595f58c
	System.Void CleanUp(); // 0x0595f7f4
	WizardGames.Soc.Common.Entity.PlayerEntity GetPlayerEntity(System.Int64 entityId); // 0x0595f9a0
	WizardGames.Soc.Common.Entity.MonsterEntity GetMonsterEntity(System.Int64 entityId); // 0x0595fa4c
	WizardGames.Soc.Common.Entity.PartEntity GetPartEntity(System.Int64 entityId); // 0x05958268
	System.Void OnCreateEntity(WizardGames.Soc.Common.Entity.IEntity entity, System.Boolean master); // 0x0595faf8
	WizardGames.Soc.Common.Entity.PlayerEntity GetEntityByRoleId(System.UInt64 roleId); // 0x05960b24
	System.Void AfterRemoveEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x05960bd8
	System.Void EntitySetAddHandle(WizardGames.Soc.Common.Entity.IEntity entity, System.Boolean local); // 0x059618ec
	System.Void EntitySetAddHandleLocalOnly(WizardGames.Soc.Common.Entity.IEntity entity); // 0x05960a68
	System.Void EntitySetRemoveHandleLocalOnly(WizardGames.Soc.Common.Entity.IEntity entity); // 0x059619b8
	System.Void EntitySetRemoveHandle(WizardGames.Soc.Common.Entity.IEntity entity, System.Boolean local); // 0x05961a74
	WizardGames.Soc.Common.Entity.IEntity GetEntityViaType(System.Type EntityType, System.Int64 Id, System.Boolean local); // 0x05961bbc
	System.Collections.Generic.Dictionary<System.Int64,T> GetEntitiesViaType<T>(System.Boolean local); // 0x052af1f0
	System.Collections.Generic.Dictionary<System.Int64,T> GetEntitiesViaInterface<T>(System.Boolean local); // 0x052af1f0
	System.Void OnFps30Update(System.Single dt); // 0x05961c88
	System.Void TryTriggerShortcusEvent(WizardGames.Soc.Common.Entity.IEntity entity); // 0x05961e3c
	System.Void ClearOnDisconnect(System.Boolean force); // 0x05962014
	System.Void GetEntitiesInRange<T>(System.Collections.Generic.List<T> result, System.Single posX, System.Single posZ, System.Single radius, System.Action<T> process); // 0x052af1f0
	System.Void ParseFullSnapshot(WizardGames.Soc.Common.SimpleCustom.Snapshot snapshot, WizardGames.Soc.Common.Synchronization.SnapshotIncremental snapshotIncremental); // 0x059625e4
	System.Void ParseIncrementalSnapshot(WizardGames.Soc.Common.Synchronization.SnapshotIncremental inc); // 0x0596294c
	System.Void .ctor(); // 0x05963364
	static System.Void .cctor(); // 0x059636f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Entity.MgrPPV : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger Logger; // 0x0
	static System.String ppvBaseName; // 0x8
	System.Collections.Generic.Dictionary<System.String,UnityEngine.GameObject> ppvDict; // 0x18
	System.Collections.Generic.Dictionary<System.String,System.Int32> ppvIdDict; // 0x20
	System.Collections.Generic.Dictionary<System.String,System.Boolean> ppvStates; // 0x28
	SOC.TA.PostProcessEffectController PostProcessEffectController; // 0x30
	UnityEngine.Rendering.Volume RenderVolume; // 0x38
	UnityEngine.Rendering.Volume PPVBaseVolume; // 0x40
	SOC.TA.FullScreenUiRenderingController FullScreenController; // 0x48
	UnityEngine.GameObject FullScreenUI; // 0x50
	System.Void Init(); // 0x0596378c
	System.Void CleanUp(); // 0x05963a94
	System.Threading.Tasks.Task OnEnterWorld(); // 0x05963afc
	System.Threading.Tasks.Task AfterEnterWorld(); // 0x05963b64
	System.Threading.Tasks.Task OnExitWorld(); // 0x05964310
	System.Void InitConfigFromTable(); // 0x059637fc
	System.Void BindGo(); // 0x05963bd4
	System.Void TrySetPPV(System.String ppvName, System.Boolean isActive); // 0x05964378
	System.Void RefreshPPV(UnityEngine.AzureSky.AzureWeatherPresetEnum weather); // 0x0596457c
	System.Boolean CanSetPPV(System.String name); // 0x05964988
	System.Boolean CanSetPPV(UnityEngine.AzureSky.AzureWeatherPresetEnum weather, System.String name); // 0x05964818
	System.Void MarkPPVActive(System.String ppvName, System.Boolean isActive); // 0x05964400
	System.Threading.Tasks.Task SetColorLookUp(System.Int32 index); // 0x05964bec
	System.Void .ctor(); // 0x05964d18
	static System.Void .cctor(); // 0x05964e24
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Entity.MgrPPV.<SetColorLookUp>d__22 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder; // 0x18
	System.Int32 index; // 0x30
	WizardGames.Soc.SocClient.Entity.MgrPPV <>4__this; // 0x38
	UnityEngine.Rendering.Universal.ColorLookup <colorLookup>5__2; // 0x40
	System.String <texPath>5__3; // 0x48
	System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Texture2D> <>u__1; // 0x50
	System.Void MoveNext(); // 0x05964f28
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x05965bd0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Entity.EntTypeCacheRegister : System.Object
{
	
	static System.Void .cctor(); // 0x05965c74
	static System.Void Init(); // 0x0596ee9c
	static System.Void CreateEntityCacheTypes(System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.List<System.Type>>& entityInterfaceMap, System.Collections.Generic.Dictionary<System.Type,System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet>>& entityToSetMakerMap); // 0x05965d84
}

// Client.Runtime
class WizardGames.Soc.SocClient.Entity.EntTypeCacheRegister.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Entity.EntTypeCacheRegister.<>c <>9; // 0x0
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_0; // 0x8
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_1; // 0x10
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_2; // 0x18
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_3; // 0x20
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_4; // 0x28
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_5; // 0x30
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_6; // 0x38
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_7; // 0x40
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_8; // 0x48
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_9; // 0x50
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_10; // 0x58
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_11; // 0x60
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_12; // 0x68
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_13; // 0x70
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_14; // 0x78
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_15; // 0x80
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_16; // 0x88
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_17; // 0x90
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_18; // 0x98
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_19; // 0xa0
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_20; // 0xa8
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_21; // 0xb0
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_22; // 0xb8
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_23; // 0xc0
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_24; // 0xc8
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_25; // 0xd0
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_26; // 0xd8
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_27; // 0xe0
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_28; // 0xe8
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_29; // 0xf0
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_30; // 0xf8
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_31; // 0x100
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_32; // 0x108
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_33; // 0x110
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_34; // 0x118
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_35; // 0x120
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_36; // 0x128
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_37; // 0x130
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_38; // 0x138
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_39; // 0x140
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_40; // 0x148
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_41; // 0x150
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_42; // 0x158
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_43; // 0x160
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_44; // 0x168
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_45; // 0x170
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_46; // 0x178
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_47; // 0x180
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_48; // 0x188
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_49; // 0x190
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_50; // 0x198
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_51; // 0x1a0
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_52; // 0x1a8
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_53; // 0x1b0
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_54; // 0x1b8
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_55; // 0x1c0
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_56; // 0x1c8
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_57; // 0x1d0
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_58; // 0x1d8
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_59; // 0x1e0
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_60; // 0x1e8
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_61; // 0x1f0
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_62; // 0x1f8
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_63; // 0x200
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_64; // 0x208
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_65; // 0x210
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_66; // 0x218
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_67; // 0x220
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_68; // 0x228
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_69; // 0x230
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_70; // 0x238
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_71; // 0x240
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_72; // 0x248
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_73; // 0x250
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_74; // 0x258
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_75; // 0x260
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_76; // 0x268
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_77; // 0x270
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_78; // 0x278
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_79; // 0x280
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_80; // 0x288
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_81; // 0x290
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_82; // 0x298
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_83; // 0x2a0
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_84; // 0x2a8
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_85; // 0x2b0
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_86; // 0x2b8
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_87; // 0x2c0
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_88; // 0x2c8
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_89; // 0x2d0
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_90; // 0x2d8
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_91; // 0x2e0
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_92; // 0x2e8
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_93; // 0x2f0
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_94; // 0x2f8
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_95; // 0x300
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_96; // 0x308
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_97; // 0x310
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_98; // 0x318
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_99; // 0x320
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_100; // 0x328
	static System.Func<WizardGames.Soc.Common.Entity.EntityCollection.EntitySet> <>9__2_101; // 0x330
	static System.Void .cctor(); // 0x0596eef4
	System.Void .ctor(); // 0x0596ef58
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_0(); // 0x0596efc0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_1(); // 0x0596f060
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_2(); // 0x0596f100
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_3(); // 0x0596f1a0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_4(); // 0x0596f240
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_5(); // 0x0596f2e0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_6(); // 0x0596f380
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_7(); // 0x0596f420
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_8(); // 0x0596f4c0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_9(); // 0x0596f560
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_10(); // 0x0596f600
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_11(); // 0x0596f6a0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_12(); // 0x0596f740
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_13(); // 0x0596f7e0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_14(); // 0x0596f880
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_15(); // 0x0596f920
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_16(); // 0x0596f9c0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_17(); // 0x0596fa60
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_18(); // 0x0596fb00
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_19(); // 0x0596fba0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_20(); // 0x0596fc40
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_21(); // 0x0596fce0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_22(); // 0x0596fd80
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_23(); // 0x0596fe20
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_24(); // 0x0596fec0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_25(); // 0x0596ff60
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_26(); // 0x05970000
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_27(); // 0x059700a0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_28(); // 0x05970140
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_29(); // 0x059701e0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_30(); // 0x05970280
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_31(); // 0x05970320
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_32(); // 0x059703c0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_33(); // 0x05970460
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_34(); // 0x05970500
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_35(); // 0x059705a0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_36(); // 0x05970640
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_37(); // 0x059706e0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_38(); // 0x05970780
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_39(); // 0x05970820
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_40(); // 0x059708c0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_41(); // 0x05970960
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_42(); // 0x05970a00
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_43(); // 0x05970aa0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_44(); // 0x05970b40
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_45(); // 0x05970be0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_46(); // 0x05970c80
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_47(); // 0x05970d20
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_48(); // 0x05970dc0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_49(); // 0x05970e60
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_50(); // 0x05970f00
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_51(); // 0x05970fa0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_52(); // 0x05971040
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_53(); // 0x059710e0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_54(); // 0x05971180
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_55(); // 0x05971220
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_56(); // 0x059712c0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_57(); // 0x05971360
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_58(); // 0x05971400
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_59(); // 0x059714a0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_60(); // 0x05971540
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_61(); // 0x059715e0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_62(); // 0x05971680
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_63(); // 0x05971720
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_64(); // 0x059717c0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_65(); // 0x05971860
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_66(); // 0x05971900
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_67(); // 0x059719a0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_68(); // 0x05971a40
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_69(); // 0x05971ae0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_70(); // 0x05971b80
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_71(); // 0x05971c20
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_72(); // 0x05971cc0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_73(); // 0x05971d60
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_74(); // 0x05971e00
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_75(); // 0x05971ea0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_76(); // 0x05971f40
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_77(); // 0x05971fe0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_78(); // 0x05972080
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_79(); // 0x05972120
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_80(); // 0x059721c0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_81(); // 0x05972260
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_82(); // 0x05972300
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_83(); // 0x059723a0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_84(); // 0x05972440
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_85(); // 0x059724e0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_86(); // 0x05972580
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_87(); // 0x05972620
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_88(); // 0x059726c0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_89(); // 0x05972760
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_90(); // 0x05972800
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_91(); // 0x059728a0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_92(); // 0x05972940
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_93(); // 0x059729e0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_94(); // 0x05972a80
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_95(); // 0x05972b20
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_96(); // 0x05972bc0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_97(); // 0x05972c60
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_98(); // 0x05972d00
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_99(); // 0x05972da0
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_100(); // 0x05972e40
	WizardGames.Soc.Common.Entity.EntityCollection.EntitySet <CreateEntityCacheTypes>b__2_101(); // 0x05972ee0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Entity.MgrTOD : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger Logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int32,System.Single> transitionTimeDict; // 0x18
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> priorityDict; // 0x20
	UnityEngine.AzureSky.AzureWeatherPresetEnum curWeather; // 0x28
	System.Collections.Generic.Dictionary<UnityEngine.AzureSky.AzureWeatherPresetEnum,System.Int32> weatherPresetDict; // 0x30
	System.UInt64 priorityBits; // 0x38
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> refCountDict; // 0x40
	System.Void Init(); // 0x05972f80
	System.Void CleanUp(); // 0x059735fc
	System.Threading.Tasks.Task OnEnterWorld(); // 0x059736f8
	System.Threading.Tasks.Task OnExitWorld(); // 0x05973e54
	System.Void InitConfigFromTable(); // 0x05972ff0
	System.Void ReleaseConfig(); // 0x0597366c
	System.Void RegisterTod(UnityEngine.AzureSky.AzureWeatherPresetEnum weather, WizardGames.Soc.SocClient.Entity.ERegSrc source, UnityEngine.AzureSky.EAzureControllerPresetEnum preset); // 0x05973ac4
	System.Void UnregisterTod(UnityEngine.AzureSky.AzureWeatherPresetEnum weather, WizardGames.Soc.SocClient.Entity.ERegSrc source); // 0x05974534
	System.Boolean GetValidPriority(System.Int32 tod, System.Int32& priority); // 0x05973f6c
	UnityEngine.AzureSky.AzureWeatherPresetEnum GetWeather(); // 0x05964a78
	System.Void ChangeWeatherTo(UnityEngine.AzureSky.AzureWeatherPresetEnum weather, System.Int32 newPreset); // 0x059740e0
	System.Single GetTransitTime(UnityEngine.AzureSky.AzureWeatherPresetEnum from, UnityEngine.AzureSky.AzureWeatherPresetEnum to); // 0x05974a18
	static System.Int32 GetTransitionIndex(System.Int32 from, System.Int32 to); // 0x05973ed4
	System.Int32 GetHighestPriority(); // 0x05974058
	UnityEngine.AzureSky.AzureWeatherPresetEnum GetHighestPriorityWeather(); // 0x05974850
	System.Void .ctor(); // 0x05974b0c
	static System.Void .cctor(); // 0x05974b74
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Entity.ERegSrc : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Entity.ERegSrc None = 0;
	static WizardGames.Soc.SocClient.Entity.ERegSrc Self = 1;
	static WizardGames.Soc.SocClient.Entity.ERegSrc AmbientLight = 2;
	static WizardGames.Soc.SocClient.Entity.ERegSrc Backpack = 3;
	static WizardGames.Soc.SocClient.Entity.ERegSrc LiftingPlatform = 4;
	static WizardGames.Soc.SocClient.Entity.ERegSrc MallTimeline = 5;
	static WizardGames.Soc.SocClient.Entity.ERegSrc MallModelPreview = 6;
	static WizardGames.Soc.SocClient.Entity.ERegSrc GameTeamPreviewBg = 7;
	static WizardGames.Soc.SocClient.Entity.ERegSrc UIModel = 8;
	static WizardGames.Soc.SocClient.Entity.ERegSrc ConstructionPreview = 9;
	static WizardGames.Soc.SocClient.Entity.ERegSrc PreviewSceneCut = 10;
	static WizardGames.Soc.SocClient.Entity.ERegSrc BattlePass = 11;
	static WizardGames.Soc.SocClient.Entity.ERegSrc lobbyStage = 12;
	static WizardGames.Soc.SocClient.Entity.ERegSrc UIBase = 13;
	static WizardGames.Soc.SocClient.Entity.ERegSrc UILotteryDraw = 14;
	static WizardGames.Soc.SocClient.Entity.ERegSrc UIMailBuy = 15;
	static WizardGames.Soc.SocClient.Entity.ERegSrc UIPlayerModel = 16;
	static WizardGames.Soc.SocClient.Entity.ERegSrc UICommonPreview = 17;
	static WizardGames.Soc.SocClient.Entity.ERegSrc UIInventoryOthersidePanel = 18;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Newbie.FakeNPCPathData : UnityEngine.ScriptableObject
{
	System.Int64[] pathIds; // 0x18
	System.Int64[] pathLens; // 0x20
	UnityEngine.Vector3[] pathsPoints; // 0x28
	System.Void BuildFromDict(System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<UnityEngine.Vector3>> pathDict); // 0x05974ec4
	System.Void GetPathDict(System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<UnityEngine.Vector3>>& pathDict); // 0x059752f4
	System.Void .ctor(); // 0x0597554c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.FakeNPC : System.Object
{
	static System.Int32 maxLookAtAngelVertical; // 0x0
	static System.Int32 maxLookAtAngelHorizontal; // 0x4
	static System.Single inSightLookAtWeight; // 0x8
	static System.Single outSightLookAtWeight; // 0xc
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> TaskNum2State; // 0x10
	System.Int64 modelId; // 0x18
	WizardGames.Soc.Common.Data.ETimelineTag TimelineTag; // 0x20
	System.Int32 TimelineTagId; // 0x24
	System.Int32 RemotePlayerPriority; // 0x28
	System.String idleAnimState; // 0x30
	System.String moveAnimState; // 0x38
	System.String preAnimState; // 0x40
	System.Single crossFadeTime; // 0x48
	System.Boolean enableLookAtIK; // 0x4c
	System.Boolean needBrake; // 0x4d
	System.Boolean isMoveTask; // 0x4e
	UnityEngine.GameObject mainGo; // 0x50
	UnityEngine.Animator animator; // 0x58
	WizardGames.AssetPool.AssetPoolHandle animatorControllerHandle; // 0x60
	RootMotion.FinalIK.LookAtIK lookAtIK; // 0x68
	RootMotion.FinalIK.LookAtController lookAtController; // 0x70
	UnityEngine.CapsuleCollider npcTrigger; // 0x78
	WizardGames.Soc.Common.Data.Play.NewbieModelConfig config; // 0x80
	System.Int64 beforeAnimTimeoutId; // 0x88
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Trigger.CommonTriggerNewbieEvent> triggers; // 0x90
	System.Boolean hasUpdated; // 0x98
	WizardGames.Soc.SocClient.Timeline.ENPCMoveState MoveState; // 0x9c
	FakeNpcBindingGoCom fakeNpcBindingGoCom; // 0xa0
	static SocLogger <logger>k__BackingField; // 0x10
	System.Boolean <IsActive>k__BackingField; // 0xa8
	static UnityEngine.Vector3 groundUpVec; // 0x18
	static System.Single groundMaxDis; // 0x24
	static System.Single fixedTransitTime; // 0x28
	static System.Single stopTurnToIdleTime; // 0x2c
	static System.Single scale90; // 0x30
	static System.Single scale135; // 0x34
	static System.Single scale180; // 0x38
	static System.Single basicRunAnimSpeed; // 0x3c
	System.Int32 curIndex; // 0xac
	System.Boolean isLoop; // 0xb0
	System.Boolean isPathReady; // 0xb1
	System.Boolean isAutoGround; // 0xb2
	System.Boolean hasFinishMove; // 0xb3
	System.Single curSpeed; // 0xb4
	System.Single maxMovingSpeed; // 0xb8
	System.Single acceleration; // 0xbc
	System.Single angleSpeed; // 0xc0
	System.Single brakeDistance; // 0xc4
	System.Single crossDistY; // 0xc8
	System.Single crossDistZ; // 0xcc
	System.Single maxStopDistance; // 0xd0
	System.Single maxRestartDistace; // 0xd4
	UnityEngine.Quaternion finalRot; // 0xd8
	UnityEngine.Quaternion targetRot; // 0xe8
	WizardGames.Soc.SocClient.Timeline.EMoveType curMoveType; // 0xf8
	WizardGames.Soc.SocClient.Timeline.EMoveType overrideMoveType; // 0xfc
	System.Collections.Generic.List<UnityEngine.Vector3> path; // 0x100
	UnityEngine.Vector3 curMovingDirXZ; // 0x108
	UnityEngine.Vector3 brakingDirXZ; // 0x114
	UnityEngine.Vector3 crossStartPos; // 0x120
	UnityEngine.Vector3 crossEndPos; // 0x12c
	System.Single jumpMaxHeight; // 0x138
	System.Single RotationScale; // 0x13c
	System.Single BrakeScale; // 0x140
	System.Single CrossYScale; // 0x144
	System.Single CrossFlatScale; // 0x148
	static SocLogger get_logger(); // 0x059755b4
	System.Boolean get_IsActive(); // 0x0597563c
	System.Void set_IsActive(System.Boolean value); // 0x059756a0
	System.Void .ctor(WizardGames.Soc.Common.Data.Play.NewbieModelConfig conf, UnityEngine.GameObject go); // 0x0597571c
	System.Void LoadNpcModel(); // 0x059761a4
	System.Void InitModelAfterLoad(); // 0x05976414
	System.Void SetActiveState(System.Boolean active, System.Boolean force); // 0x05975bc4
	System.Void UpdateState(System.Int64 taskNum); // 0x05976804
	System.Void OnTriggerStateChange(WizardGames.Soc.Common.Unity.Trigger.CommonTriggerNewbieEvent trigger, System.Boolean isEnter, WizardGames.Soc.Common.Data.ENewbieTrigger tType); // 0x05977830
	System.Void SetActive(System.Boolean isActive); // 0x05975f00
	System.Void SetTrigger(System.Boolean enable); // 0x05977a6c
	System.Void InitState(); // 0x05975de0
	System.Void OnAwake(); // 0x05977da8
	System.Void BindLookAtIK(); // 0x05977ef8
	System.Void EnableLookAtIK(System.Boolean enable); // 0x05976f40
	System.Void SwitchLookAtIKState(System.Boolean enable, UnityEngine.GameObject target); // 0x059782ac
	System.Void UpdateLookAtIK(); // 0x059784f4
	System.Void TempDisableLookAtIK(); // 0x05978920
	System.Void TryRecoverLookAtIK(); // 0x059789d4
	System.Void OnEnterTimeline(); // 0x05978ab8
	System.Void OnLeaveTimeline(); // 0x05978b90
	System.Void TryBindAnimatorController(System.Boolean hasController); // 0x059771b0
	System.Void UnloadMainGo(); // 0x05978c58
	System.Void Clear(); // 0x05978f0c
	System.Boolean TryGetTankComp(WizardGames.Soc.SocClient.Timeline.NewbieTankMoveComp& comp); // 0x05978fd4
	System.Void UpdateStateByLatestTask(System.Int64 currentTask); // 0x059792dc
	UnityEngine.GameObject get_HudPosGo(); // 0x059795fc
	UnityEngine.Vector3 get_Position(); // 0x059796b0
	UnityEngine.Quaternion get_Rotation(); // 0x059797ac
	WizardGames.Soc.SocClient.Timeline.EMoveType get_CurMoveType(); // 0x059798a8
	System.String GetCrouchAnim(WizardGames.Soc.SocClient.Timeline.EMoveType moveType); // 0x0597990c
	System.Void UpdateLocomotionState(System.Int32 deltaTime); // 0x059799b8
	System.Void SetMoveConfig(WizardGames.Soc.Common.Data.Play.NewbieModelState config); // 0x05977630
	System.Void DoMove(WizardGames.Soc.Common.Data.Play.NewbieModelState config); // 0x05977778
	System.Void SetBeforeMove(System.String state); // 0x0597b138
	System.Void UpdateBeforeMoveState(System.Int32 deltaTime); // 0x05979c04
	System.Void SetStartTurnState(System.Int32 index, System.Boolean turnInPlace); // 0x0597b44c
	System.Void UpdateStartTurnState(System.Int32 deltaTime); // 0x05979d0c
	System.Void SetMoveState(System.Int32 index); // 0x0597bb48
	System.Void SetMoveTransitState(System.Int32 index, System.Boolean toCrouch); // 0x0597c198
	System.Void UpdateMoveState(System.Int32 deltaTime); // 0x05979e80
	System.Void UpdateMoveTransitState(System.Int32 deltaTime); // 0x05979f18
	System.Void OverrideMoveType(WizardGames.Soc.SocClient.Timeline.EMoveType moveType, System.Boolean needTransit); // 0x059779b8
	System.Void ChangeMoveType(WizardGames.Soc.SocClient.Timeline.EMoveType moveType, System.Boolean needTransit); // 0x0597ccdc
	System.Void ForceChangeMoveType(WizardGames.Soc.SocClient.Timeline.EMoveType moveType, System.Single transitTime, System.Boolean stateChange); // 0x0597be00
	System.Void UpdateJump(); // 0x0597c434
	System.Void SetBrakingState(UnityEngine.Vector3 dirXZ); // 0x0597cf20
	System.Void UpdateBrakingState(System.Int32 deltaTime); // 0x0597a0d4
	System.Void SetStopTurnState(); // 0x0597d38c
	System.Void UpdateStopTurnState(System.Int32 deltaTime); // 0x0597a448
	System.Void UpdateIdleState(System.Int32 deltaTime); // 0x0597a740
	System.Void SetCrossState(); // 0x0597af48
	System.Void UpdateCrossState(System.Int32 deltaTime); // 0x0597a83c
	System.Void RequestMove(WizardGames.Soc.Common.Algorithm.Vector3 destPos); // 0x0597dbf4
	System.Void RequestMultipleMove(WizardGames.Soc.Common.Algorithm.Vector3[] posList); // 0x0597a954
	System.Void MoveAlongPath(System.Collections.Generic.List<UnityEngine.Vector3> destinyPosList, System.Boolean loop); // 0x0597df48
	System.Void InitMove(System.Single transitionTime); // 0x0597652c
	System.Void TransitToIdle(System.Single transitionTime); // 0x0597d8c0
	System.Boolean TryTurnBeforeMove(System.Boolean turnInPlace); // 0x0597b6b0
	System.Boolean TryTurnBeforeStop(); // 0x0597d550
	System.Void UpdateTransform(System.Int32 dTime); // 0x0597c624
	System.Boolean CheckNearPlayer(System.Single maxDistance); // 0x0597e204
	System.Void TryContinueMove(); // 0x0597db3c
	static UnityEngine.Quaternion StepRotate(UnityEngine.Quaternion curRot, UnityEngine.Quaternion targetRot, System.Single angleSpeed, System.Single dTime); // 0x0597d1ec
	UnityEngine.Vector3 GroundSample(UnityEngine.Vector3 position); // 0x0597741c
	static System.Void .cctor(); // 0x0597e490
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Timeline.EMoveType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Timeline.EMoveType NONE = 0;
	static WizardGames.Soc.SocClient.Timeline.EMoveType WALK = 1;
	static WizardGames.Soc.SocClient.Timeline.EMoveType RUN = 2;
	static WizardGames.Soc.SocClient.Timeline.EMoveType CROUCH = 3;
	static WizardGames.Soc.SocClient.Timeline.EMoveType JUMP = 4;
	static WizardGames.Soc.SocClient.Timeline.EMoveType CROUCH2 = 5;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Timeline.ENPCMoveState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Timeline.ENPCMoveState Idle = 0;
	static WizardGames.Soc.SocClient.Timeline.ENPCMoveState BeforeMove = 1;
	static WizardGames.Soc.SocClient.Timeline.ENPCMoveState StartTurn = 2;
	static WizardGames.Soc.SocClient.Timeline.ENPCMoveState Moving = 3;
	static WizardGames.Soc.SocClient.Timeline.ENPCMoveState Braking = 4;
	static WizardGames.Soc.SocClient.Timeline.ENPCMoveState StopTurn = 5;
	static WizardGames.Soc.SocClient.Timeline.ENPCMoveState Cross = 6;
	static WizardGames.Soc.SocClient.Timeline.ENPCMoveState MovingTransit = 7;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.FakeNPCAnimComp : UnityEngine.MonoBehaviour
{
	static SocLogger <logger>k__BackingField; // 0x0
	static System.Single audioDist; // 0x8
	static System.Single brakingCompensateFactor; // 0xc
	System.Int64 modelId; // 0x30
	WizardGames.Soc.SocClient.Timeline.FakeNPC fakeNpc; // 0x38
	UnityEngine.Animator animator; // 0x40
	static SocLogger get_logger(); // 0x0597e604
	System.Void Start(); // 0x0597e68c
	System.Void OnAnimatorMove(); // 0x0597e76c
	System.Void FireAnimEvent(System.Int32 id); // 0x0597ec24
	System.Boolean IsTeammate(); // 0x0597f1bc
	System.Void .ctor(); // 0x0597f238
	static System.Void .cctor(); // 0x0597f2a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.NewbieHelicopterMoveComp : UnityEngine.MonoBehaviour
{
	static SocLogger <logger>k__BackingField; // 0x0
	static SocLogger get_logger(); // 0x0597f38c
	System.Void Start(); // 0x0597f414
	System.Void .ctor(); // 0x0597f51c
	static System.Void .cctor(); // 0x0597f584
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.NewbieTankMoveComp : UnityEngine.MonoBehaviour
{
	static SocLogger <logger>k__BackingField; // 0x0
	System.Single speed; // 0x30
	UnityEngine.GameObject leftWheel; // 0x38
	UnityEngine.GameObject rightWheel; // 0x40
	System.Boolean isMoving; // 0x48
	UnityEngine.Material trend; // 0x50
	UnityEngine.Vector3 targetPos; // 0x58
	System.Single totalOffset; // 0x64
	Effect.EffectItemHandle<Effect.FollowEffect> rightWheelEffect; // 0x68
	Effect.EffectItemHandle<Effect.FollowEffect> leftWheelEffect; // 0x78
	static SocLogger get_logger(); // 0x0597f658
	static System.Int32 get_effectId(); // 0x0597f6e0
	System.Void Start(); // 0x0597f7d0
	System.Void Update(); // 0x0597fcc4
	System.Void MoveToPos(UnityEngine.Vector3 dest); // 0x059801b0
	System.Void Move(); // 0x0598024c
	System.Void StopMove(); // 0x05980680
	System.Void OnStopMoving(); // 0x059800c4
	System.Void .ctor(); // 0x059806f8
	static System.Void .cctor(); // 0x05980768
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.AudioTrigger : UnityEngine.MonoBehaviour
{
	
	System.Void PlayAudio(System.Single param); // 0x0598083c
	System.Void .ctor(); // 0x0598090c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.ActivationData : System.Object
{
	UnityEngine.ExposedReference<UnityEngine.GameObject> node; // 0x10
	UnityEngine.GameObject runtimeNode; // 0x20
	System.String nodePath; // 0x28
	System.Boolean activateOnStart; // 0x30
	System.Boolean deactivateOnEnd; // 0x31
	System.Void .ctor(); // 0x05980974
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.ActivationClipAsset : UnityEngine.Playables.PlayableAsset, WizardGames.Soc.Common.Unity.Timeline.ISocClipAsset, UnityEngine.Timeline.ITimelineClipAsset
{
	UnityEngine.ExposedReference<UnityEngine.GameObject> anchor; // 0x18
	WizardGames.Soc.Common.Data.ETimelineTag anchorTag; // 0x28
	System.Int32 anchorTagId; // 0x2c
	WizardGames.Soc.SocClient.Timeline.ActivationData[] activationDataList; // 0x30
	WizardGames.Soc.Common.Unity.Timeline.ESocClipType get_ClipType(); // 0x059809e4
	UnityEngine.Timeline.ClipCaps get_clipCaps(); // 0x05980a48
	UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner); // 0x05980aac
	System.Void .ctor(); // 0x05980c44
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.ActivationClipBehavior : UnityEngine.Playables.PlayableBehaviour
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Timeline.ActivationData[] activationDataList; // 0x10
	System.Boolean <FirstPlay>k__BackingField; // 0x18
	System.Void Init(WizardGames.Soc.SocClient.Timeline.ActivationData[] data); // 0x05980cac
	System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x05980d2c
	System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x05981084
	System.Void .ctor(); // 0x059813e4
	static System.Void .cctor(); // 0x05981454
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.ActivationColorWeaponClipAsset : UnityEngine.Playables.PlayableAsset, WizardGames.Soc.Common.Unity.Timeline.ISocClipAsset, UnityEngine.Timeline.ITimelineClipAsset
{
	UnityEngine.ExposedReference<UnityEngine.GameObject> anchor; // 0x18
	WizardGames.Soc.Common.Data.ETimelineTag anchorTag; // 0x28
	System.Int32 anchorTagId; // 0x2c
	WizardGames.Soc.SocClient.Timeline.ActivationData[] activationDataList; // 0x30
	WizardGames.Soc.Common.Unity.Timeline.ESocClipType get_ClipType(); // 0x05981528
	UnityEngine.Timeline.ClipCaps get_clipCaps(); // 0x0598158c
	UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner); // 0x059815f0
	System.Void .ctor(); // 0x05981788
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.ActivationClipBehavior2 : UnityEngine.Playables.PlayableBehaviour
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Timeline.ActivationData[] activationDataList; // 0x10
	System.Boolean <FirstPlay>k__BackingField; // 0x18
	static UnityEngine.MaterialPropertyBlock waterFillingMaterialPropertyBlock; // 0x8
	UnityEngine.GameObject curTimelineFpWeapon; // 0x20
	UnityEngine.GameObject curTimelineTpWeapon; // 0x28
	static UnityEngine.Color color0Value; // 0x10
	static UnityEngine.Color color1Value; // 0x20
	static UnityEngine.Color color2Value; // 0x30
	static UnityEngine.Color[] weaponColorArr1; // 0x40
	static UnityEngine.Color[] weaponColorArr2; // 0x48
	static UnityEngine.Color[] weaponColorArr3; // 0x50
	System.Void Init(WizardGames.Soc.SocClient.Timeline.ActivationData[] data); // 0x059817f0
	System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable); // 0x05981870
	System.Void OnPlayableCreate(UnityEngine.Playables.Playable playable); // 0x05981cd8
	System.Void FillWaterFillingProperty(UnityEngine.GameObject obj); // 0x0598193c
	System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x05981e74
	System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x05982668
	static UnityEngine.Color[] GetColorArr(System.Int32 ewc); // 0x05982344
	System.Int32 GetNextColorIndex(System.Int32 index); // 0x059822c4
	static System.Void SwitchWeaponColors(UnityEngine.GameObject go, UnityEngine.Color[] colors); // 0x05982414
	System.Void .ctor(); // 0x059829c8
	static System.Void .cctor(); // 0x05982a38
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Timeline.ActivationClipBehavior2.EWEAPON_COLOR : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Timeline.ActivationClipBehavior2.EWEAPON_COLOR Color1 = 0;
	static WizardGames.Soc.SocClient.Timeline.ActivationClipBehavior2.EWEAPON_COLOR Color2 = 1;
	static WizardGames.Soc.SocClient.Timeline.ActivationClipBehavior2.EWEAPON_COLOR Color3 = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.ActivationClipBehavior2.<>c__DisplayClass14_0 : System.Object
{
	UnityEngine.MeshRenderer meshRenderer; // 0x10
	System.Single internalTime; // 0x18
	System.Single totalTime; // 0x1c
	System.Void .ctor(); // 0x05981e0c
	System.Void <FillWaterFillingProperty>b__0(System.Int64 id, System.Object _, System.Boolean delete); // 0x05982c90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.AnimationClipAsset : UnityEngine.Timeline.AnimationPlayableAsset, WizardGames.Soc.Common.Unity.Timeline.ISocClipAsset
{
	
	WizardGames.Soc.Common.Unity.Timeline.ESocClipType get_ClipType(); // 0x05982df0
	System.Void .ctor(); // 0x05982e54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.AudioClipBehaviour : UnityEngine.Playables.PlayableBehaviour
{
	static SocLogger logger; // 0x0
	System.Single currentDuration; // 0x10
	System.Single currentDurationProportion; // 0x14
	System.Boolean eventIsPlaying; // 0x18
	System.Boolean fadeinTriggered; // 0x19
	System.Boolean fadeoutTriggered; // 0x1a
	System.Single previousEventStartTime; // 0x1c
	System.Boolean <FirstPlay>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.Timeline.AudioClipBehaviour.Actions requiredActions; // 0x24
	AK.Wwise.Event akEvent; // 0x28
	System.String AudioEventName; // 0x30
	System.Single eventDurationMax; // 0x38
	System.Single eventDurationMin; // 0x3c
	System.Single blendInDuration; // 0x40
	System.Single blendOutDuration; // 0x44
	System.Single easeInDuration; // 0x48
	System.Single easeOutDuration; // 0x4c
	AkCurveInterpolation blendInCurve; // 0x50
	AkCurveInterpolation blendOutCurve; // 0x54
	UnityEngine.GameObject eventObject; // 0x58
	System.Boolean retriggerEvent; // 0x60
	System.Boolean wasScrubbingAndRequiresRetrigger; // 0x61
	System.Boolean StopEventAtClipEnd; // 0x62
	System.Boolean PrintDebugInformation; // 0x63
	System.Void CallbackHandler(System.Object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info); // 0x05982ee0
	System.Boolean IsScrubbing(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x05982ff8
	System.Void PrintInfo(System.String FunctionName, UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x05983158
	System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x05983408
	System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x059838e0
	System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x05983bb4
	System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData); // 0x05983e24
	System.Boolean ShouldPlay(UnityEngine.Playables.Playable playable); // 0x059835d0
	System.Void CheckForFadeInFadeOut(UnityEngine.Playables.Playable playable); // 0x05983724
	System.Void CheckForFadeOut(UnityEngine.Playables.Playable playable, System.Double currentClipTime); // 0x059837fc
	System.Void TriggerFadeIn(UnityEngine.Playables.Playable playable); // 0x059842c8
	System.Void TriggerFadeOut(UnityEngine.Playables.Playable playable); // 0x05984410
	System.Void StopEvent(System.Int32 transition); // 0x05983d7c
	System.Boolean PostEvent(); // 0x05984530
	System.Void RetriggerEvent(UnityEngine.Playables.Playable playable); // 0x059841f4
	System.Single GetProportionalTime(UnityEngine.Playables.Playable playable); // 0x05983a78
	System.Single SeekToTime(UnityEngine.Playables.Playable playable); // 0x059840e4
	System.Void .ctor(); // 0x0598461c
	static System.Void .cctor(); // 0x05984698
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Timeline.AudioClipBehaviour.Actions : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Timeline.AudioClipBehaviour.Actions None = 0;
	static WizardGames.Soc.SocClient.Timeline.AudioClipBehaviour.Actions Playback = 1;
	static WizardGames.Soc.SocClient.Timeline.AudioClipBehaviour.Actions Retrigger = 2;
	static WizardGames.Soc.SocClient.Timeline.AudioClipBehaviour.Actions DelayedStop = 4;
	static WizardGames.Soc.SocClient.Timeline.AudioClipBehaviour.Actions Seek = 8;
	static WizardGames.Soc.SocClient.Timeline.AudioClipBehaviour.Actions FadeIn = 16;
	static WizardGames.Soc.SocClient.Timeline.AudioClipBehaviour.Actions FadeOut = 32;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.AudioClipAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset
{
	System.String AudioEventName; // 0x18
	AK.Wwise.Event akEvent; // 0x20
	AkCurveInterpolation blendInCurve; // 0x28
	AkCurveInterpolation blendOutCurve; // 0x2c
	System.Single eventDurationMax; // 0x30
	System.Single eventDurationMin; // 0x34
	UnityEngine.Timeline.TimelineClip owningClip; // 0x38
	System.Boolean retriggerEvent; // 0x40
	System.Boolean UseWwiseEventDuration; // 0x41
	System.Boolean PrintDebugInformation; // 0x42
	System.Boolean StopEventAtClipEnd; // 0x43
	UnityEngine.Timeline.ClipCaps UnityEngine.Timeline.ITimelineClipAsset.get_clipCaps(); // 0x0598476c
	WizardGames.Soc.Common.Unity.Timeline.ESocClipType get_ClipType(); // 0x059847d0
	UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner); // 0x05984834
	System.Void .ctor(); // 0x05984a98
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Timeline.CameraClipData : System.ValueType
{
	System.Single StartFov; // 0x10
	System.Single EndFov; // 0x14
	UnityEngine.AnimationCurve FovCurve; // 0x18
	WizardGames.Soc.Common.Data.ETimelineTag FollowTag; // 0x20
	System.Int32 FollowTagId; // 0x24
	System.String LocatorInPath; // 0x28
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.CameraClipAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset, WizardGames.Soc.Common.Unity.Timeline.ISocClipAsset
{
	System.Single StartFov; // 0x18
	System.Single EndFov; // 0x1c
	UnityEngine.AnimationCurve FovCurve; // 0x20
	WizardGames.Soc.Common.Data.ETimelineTag followTag; // 0x28
	System.Int32 followTagId; // 0x2c
	UnityEngine.ExposedReference<UnityEngine.GameObject> cameraLocator; // 0x30
	UnityEngine.GameObject runtimeLocator; // 0x40
	System.String locatorInPath; // 0x48
	WizardGames.Soc.Common.Unity.Timeline.ESocClipType get_ClipType(); // 0x05984b74
	UnityEngine.Timeline.ClipCaps get_clipCaps(); // 0x05984bd8
	UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner); // 0x05984c3c
	System.Void .ctor(); // 0x059850cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.CameraClipBehaviour : UnityEngine.Playables.PlayableBehaviour
{
	static SocLogger logger; // 0x0
	System.Single startFov; // 0x10
	System.Single endFov; // 0x14
	UnityEngine.AnimationCurve fovCurve; // 0x18
	WizardGames.Soc.Common.Data.ETimelineTag followTag; // 0x20
	System.Int32 followTagId; // 0x24
	UnityEngine.GameObject cameraLocator; // 0x28
	UnityEngine.Camera sceneCamera; // 0x30
	System.String locatorInPath; // 0x38
	static UnityEngine.Playables.ScriptPlayable<WizardGames.Soc.SocClient.Timeline.CameraClipBehaviour> Create(UnityEngine.Playables.PlayableGraph graph); // 0x05984e10
	System.Void Init(WizardGames.Soc.SocClient.Timeline.CameraClipData data, UnityEngine.GameObject locator, UnityEngine.GameObject runtimeLocator); // 0x05984ecc
	System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x05985168
	System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x059855f0
	System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData); // 0x059857c4
	System.Void .ctor(); // 0x05985924
	static System.Void .cctor(); // 0x059859c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.CameraClipPlaneClipAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset, WizardGames.Soc.Common.Unity.Timeline.ISocClipAsset
{
	System.Single nearClipPlane; // 0x18
	System.Single farClipPlane; // 0x1c
	WizardGames.Soc.Common.Unity.Timeline.ESocClipType get_ClipType(); // 0x05985a94
	UnityEngine.Timeline.ClipCaps get_clipCaps(); // 0x05985af8
	UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner); // 0x05985b5c
	System.Void .ctor(); // 0x05985e14
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.CameraClipPlaneClipBehaviour : UnityEngine.Playables.PlayableBehaviour
{
	static SocLogger logger; // 0x0
	UnityEngine.Camera sceneCamera; // 0x10
	System.Single nearClipPlane; // 0x18
	System.Single farClipPlane; // 0x1c
	System.Single lastNearClipPlane; // 0x20
	System.Single lastFarClipPlane; // 0x24
	static UnityEngine.Playables.ScriptPlayable<WizardGames.Soc.SocClient.Timeline.CameraClipPlaneClipBehaviour> Create(UnityEngine.Playables.PlayableGraph graph); // 0x05985ca4
	System.Void Init(System.Single near, System.Single far); // 0x05985d60
	System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x0598603c
	System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x059861f0
	System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData); // 0x05986460
	System.Void GetSceneCamera(); // 0x05985e88
	System.Void SetClipPlane(); // 0x059860f0
	System.Void ResetClipPlane(); // 0x05986388
	System.Void .ctor(); // 0x05986500
	static System.Void .cctor(); // 0x05986568
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Timeline.EControlType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Timeline.EControlType Move = 1;
	static WizardGames.Soc.SocClient.Timeline.EControlType Camera = 2;
	static WizardGames.Soc.SocClient.Timeline.EControlType Hierarchy = 4;
	static WizardGames.Soc.SocClient.Timeline.EControlType ViewAngle = 8;
	static WizardGames.Soc.SocClient.Timeline.EControlType Model = 16;
	static WizardGames.Soc.SocClient.Timeline.EControlType UI = 32;
	static WizardGames.Soc.SocClient.Timeline.EControlType All = 63;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.ChangeControllerClipAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset, WizardGames.Soc.Common.Unity.Timeline.ISocClipAsset
{
	WizardGames.Soc.SocClient.Timeline.EControlType ControlType; // 0x18
	WizardGames.Soc.SocClient.Timeline.TimelineControlData ControlData; // 0x20
	WizardGames.Soc.Common.Unity.Timeline.ESocClipType get_ClipType(); // 0x0598663c
	UnityEngine.Timeline.ClipCaps get_clipCaps(); // 0x059866a0
	UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner); // 0x05986704
	System.Void .ctor(); // 0x059869b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.ChangeControllerClipBehavior : UnityEngine.Playables.PlayableBehaviour
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Timeline.EControlType ControlType; // 0x10
	WizardGames.Soc.SocClient.Timeline.TimelineControlData ControlData; // 0x18
	System.Boolean <FirstPlay>k__BackingField; // 0x38
	System.Boolean get_FirstPlay(); // 0x05986a24
	System.Void set_FirstPlay(System.Boolean value); // 0x05986a88
	static UnityEngine.Playables.ScriptPlayable<WizardGames.Soc.SocClient.Timeline.ChangeControllerClipBehavior> Create(UnityEngine.Playables.PlayableGraph graph); // 0x05986858
	System.Void InitBehavior(WizardGames.Soc.SocClient.Timeline.EControlType controlType, WizardGames.Soc.SocClient.Timeline.TimelineControlData controlData); // 0x05986914
	System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x05986b04
	System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x059871c8
	System.Void GetControlAction(System.Action<WizardGames.Soc.SocClient.Timeline.TimelineControlData,System.Boolean>& action); // 0x05986d44
	System.Void ChangeMove(WizardGames.Soc.SocClient.Timeline.TimelineControlData controlData, System.Boolean enable); // 0x05987570
	System.Void ChangeView(WizardGames.Soc.SocClient.Timeline.TimelineControlData controlData, System.Boolean enable); // 0x05987630
	System.Void ChangeHierarchy(WizardGames.Soc.SocClient.Timeline.TimelineControlData controlData, System.Boolean enable); // 0x05987894
	System.Void ChangeModel(WizardGames.Soc.SocClient.Timeline.TimelineControlData controlData, System.Boolean enable); // 0x05987af4
	System.Void ChangeCamera(WizardGames.Soc.SocClient.Timeline.TimelineControlData controlData, System.Boolean enable); // 0x05988020
	System.Void ChangeUI(WizardGames.Soc.SocClient.Timeline.TimelineControlData controlData, System.Boolean enable); // 0x0598831c
	System.Boolean HasControlType(WizardGames.Soc.SocClient.Timeline.EControlType dstType); // 0x059874f0
	System.Boolean CanPlay(); // 0x05986c40
	System.Void BehaviorPauseAction(UnityEngine.Playables.FrameData info); // 0x059873fc
	System.Void .ctor(); // 0x05988508
	static System.Void .cctor(); // 0x05988580
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Timeline.TimelineControlData : System.ValueType
{
	System.Single MinYaw; // 0x10
	System.Single MaxYaw; // 0x14
	System.Single MinPitch; // 0x18
	System.Single MaxPitch; // 0x1c
	System.Boolean CameraMoveMode; // 0x20
	System.Boolean HoldMode; // 0x21
	WizardGames.Soc.Common.Data.ActionName[] allowActions; // 0x28
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.EffectClipAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset, WizardGames.Soc.Common.Unity.Timeline.ISocClipAsset
{
	static SocLogger logger; // 0x0
	static System.Int32 k_MaxRandInt = 10000;
	static System.Collections.Generic.List<UnityEngine.Playables.PlayableDirector> k_EmptyDirectorsList; // 0x8
	static System.Collections.Generic.List<UnityEngine.ParticleSystem> k_EmptyParticlesList; // 0x10
	static System.Collections.Generic.HashSet<UnityEngine.ParticleSystem> s_SubEmitterCollector; // 0x18
	UnityEngine.GameObject Prefab; // 0x18
	UnityEngine.ExposedReference<UnityEngine.GameObject> EffectAnchor; // 0x20
	WizardGames.Soc.Common.Data.ETimelineTag anchorTag; // 0x30
	System.Int32 anchorTagId; // 0x34
	System.String pathInPrefab; // 0x38
	UnityEngine.GameObject RuntimeEffectAnchor; // 0x40
	System.Boolean UseTransform; // 0x48
	System.Boolean UseLocalTransform; // 0x49
	UnityEngine.Vector3 RuntimeEffectPosition; // 0x4c
	UnityEngine.Quaternion RuntimeEffectRotation; // 0x58
	UnityEngine.Vector3 RuntimeEffectScale; // 0x68
	System.Boolean sustainAfterTimeline; // 0x74
	System.Boolean updateParticle; // 0x75
	System.UInt32 particleRandomSeed; // 0x78
	System.Boolean updateDirector; // 0x7c
	System.Boolean updateITimeControl; // 0x7d
	System.Boolean searchHierarchy; // 0x7e
	System.Boolean active; // 0x7f
	UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState postPlayback; // 0x80
	UnityEngine.Playables.PlayableAsset m_ControlDirectorAsset; // 0x88
	System.Double m_Duration; // 0x90
	System.Boolean m_SupportLoop; // 0x98
	static System.Collections.Generic.HashSet<UnityEngine.Playables.PlayableDirector> s_ProcessedDirectors; // 0x20
	static System.Collections.Generic.HashSet<UnityEngine.GameObject> s_CreatedPrefabs; // 0x28
	System.Boolean <controllingDirectors>k__BackingField; // 0x99
	System.Boolean <controllingParticles>k__BackingField; // 0x9a
	WizardGames.Soc.Common.Unity.Timeline.ESocClipType get_ClipType(); // 0x05988654
	System.Boolean get_controllingDirectors(); // 0x059886b8
	System.Void set_controllingDirectors(System.Boolean value); // 0x0598871c
	System.Boolean get_controllingParticles(); // 0x05988798
	System.Void set_controllingParticles(System.Boolean value); // 0x059887fc
	System.Void OnEnable(); // 0x05988878
	System.Double get_duration(); // 0x059888f4
	UnityEngine.Timeline.ClipCaps get_clipCaps(); // 0x05988958
	UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go); // 0x059889c0
	static UnityEngine.Playables.Playable ConnectPlayablesToMixer(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> playables); // 0x0598b12c
	System.Void CreateActivationPlayable(UnityEngine.GameObject root, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> outplayables); // 0x0598a0c4
	System.Void SearchHierarchyAndConnectParticleSystem(System.Collections.Generic.IEnumerable<UnityEngine.ParticleSystem> particleSystems, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> outplayables); // 0x0598a7a0
	System.Void SearchHierarchyAndConnectDirector(System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableDirector> directors, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> outplayables, System.Boolean disableSelfReferences); // 0x0598a294
	static System.Void SearchHierarchyAndConnectControlableScripts(System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour> controlableScripts, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> outplayables); // 0x0598acec
	static System.Void ConnectMixerAndPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable mixer, UnityEngine.Playables.Playable playable, System.Int32 portIndex); // 0x0598b2e0
	System.Collections.Generic.IList<T> GetComponent<T>(UnityEngine.GameObject gameObject); // 0x052af1f0
	static System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour> GetControlableScripts(UnityEngine.GameObject root); // 0x0598ac48
	System.Void UpdateDurationAndLoopFlag(System.Collections.Generic.IList<UnityEngine.Playables.PlayableDirector> directors, System.Collections.Generic.IList<UnityEngine.ParticleSystem> particleSystems); // 0x059897fc
	System.Collections.Generic.IList<UnityEngine.ParticleSystem> GetControllableParticleSystems(UnityEngine.GameObject go); // 0x05989654
	static System.Void GetControllableParticleSystems(UnityEngine.Transform t, System.Collections.Generic.ICollection<UnityEngine.ParticleSystem> roots, System.Collections.Generic.HashSet<UnityEngine.ParticleSystem> subEmitters); // 0x0598b774
	static System.Void CacheSubEmitters(UnityEngine.ParticleSystem ps, System.Collections.Generic.HashSet<UnityEngine.ParticleSystem> subEmitters); // 0x0598b9a8
	System.Void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver); // 0x0598baf8
	static System.Void PreviewParticles(UnityEngine.Timeline.IPropertyCollector driver, System.Collections.Generic.IEnumerable<UnityEngine.ParticleSystem> particles); // 0x0598be28
	static System.Void PreviewActivation(UnityEngine.Timeline.IPropertyCollector driver, System.Collections.Generic.IEnumerable<UnityEngine.GameObject> objects); // 0x0598c294
	static System.Void PreviewTimeControl(UnityEngine.Timeline.IPropertyCollector driver, UnityEngine.Playables.PlayableDirector director, System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour> scripts); // 0x0598c614
	static System.Void PreviewDirectors(UnityEngine.Timeline.IPropertyCollector driver, System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableDirector> directors); // 0x0598ca44
	System.Void .ctor(); // 0x0598ce20
	static System.Void .cctor(); // 0x0598cf88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.EffectClipAsset.<GetControlableScripts>d__52 : System.Object, System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.MonoBehaviour>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	UnityEngine.MonoBehaviour <>2__current; // 0x18
	System.Int32 <>l__initialThreadId; // 0x20
	UnityEngine.GameObject root; // 0x28
	UnityEngine.GameObject <>3__root; // 0x30
	UnityEngine.MonoBehaviour[] <>7__wrap1; // 0x38
	System.Int32 <>7__wrap2; // 0x40
	System.Void .ctor(System.Int32 <>1__state); // 0x0598b50c
	System.Void System.IDisposable.Dispose(); // 0x0598d214
	System.Boolean MoveNext(); // 0x0598d274
	UnityEngine.MonoBehaviour System.Collections.Generic.IEnumerator<UnityEngine.MonoBehaviour>.get_Current(); // 0x0598d400
	System.Void System.Collections.IEnumerator.Reset(); // 0x0598d464
	System.Object System.Collections.IEnumerator.get_Current(); // 0x0598d4ec
	System.Collections.Generic.IEnumerator<UnityEngine.MonoBehaviour> System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour>.GetEnumerator(); // 0x0598d550
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(); // 0x0598d620
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Timeline.DiscreteTime : System.ValueType, System.IComparable
{
	static WizardGames.Soc.SocClient.Timeline.DiscreteTime kMaxTime; // 0x0
	System.Int64 m_DiscreteTime; // 0x10
	System.Void .ctor(System.Int64 time); // 0x0598d684
	System.Void .ctor(System.Double time); // 0x0598d6fc
	WizardGames.Soc.SocClient.Timeline.DiscreteTime OneTickAfter(); // 0x0598b628
	System.Int32 CompareTo(System.Object obj); // 0x0598d880
	System.Boolean Equals(WizardGames.Soc.SocClient.Timeline.DiscreteTime other); // 0x0598d944
	System.Boolean Equals(System.Object obj); // 0x0598d9c4
	static System.Int64 DoubleToDiscreteTime(System.Double time); // 0x0598d7a0
	static System.Double ToDouble(System.Int64 time); // 0x0598dab8
	static System.Double op_Explicit(WizardGames.Soc.SocClient.Timeline.DiscreteTime b); // 0x0598b6ec
	static WizardGames.Soc.SocClient.Timeline.DiscreteTime op_Explicit(System.Double time); // 0x0598b59c
	System.String ToString(); // 0x0598db28
	System.Int32 GetHashCode(); // 0x0598dba8
	static System.Void .cctor(); // 0x0598dc28
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.EffectClipBehaviour : UnityEngine.Playables.PlayableBehaviour
{
	System.Single m_LastPlayableTime; // 0x10
	System.Single m_LastParticleTime; // 0x14
	System.UInt32 m_RandomSeed; // 0x18
	System.Boolean sustainAfterTimeline; // 0x1c
	UnityEngine.ParticleSystem <particleSystem>k__BackingField; // 0x20
	static UnityEngine.Playables.ScriptPlayable<WizardGames.Soc.SocClient.Timeline.EffectClipBehaviour> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.ParticleSystem component, System.Boolean sustain); // 0x0598b40c
	static UnityEngine.Playables.ScriptPlayable<WizardGames.Soc.SocClient.Timeline.EffectClipBehaviour> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.ParticleSystem component); // 0x0598dcc4
	UnityEngine.ParticleSystem get_particleSystem(); // 0x0598df40
	System.Void set_particleSystem(UnityEngine.ParticleSystem value); // 0x0598dfa4
	System.Void Initialize(UnityEngine.ParticleSystem ps); // 0x0598de2c
	static System.Void SetRandomSeed(UnityEngine.ParticleSystem particleSystem); // 0x0598e024
	System.Void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData data); // 0x0598e188
	System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x0598e680
	System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x0598e724
	System.Void Simulate(System.Single time, System.Boolean restart); // 0x0598e490
	System.Void .ctor(); // 0x0598e7c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.HierarchyClipAsset : UnityEngine.Playables.PlayableAsset, WizardGames.Soc.Common.Unity.Timeline.ISocClipAsset, UnityEngine.Timeline.ITimelineClipAsset
{
	
	WizardGames.Soc.Common.Unity.Timeline.ESocClipType get_ClipType(); // 0x0598e844
	UnityEngine.Timeline.ClipCaps get_clipCaps(); // 0x0598e8a8
	UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner); // 0x0598e90c
	System.Void .ctor(); // 0x0598ea90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.HierarchyClipBehaviour : UnityEngine.Playables.PlayableBehaviour
{
	
	System.Void .ctor(); // 0x0598ea28
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.PostProcessEffectClip : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset, WizardGames.Soc.Common.Unity.Timeline.ISocClipAsset
{
	WizardGames.Soc.Common.Unity.Timeline.EPostProcessEffectType effectType; // 0x18
	UnityEngine.AnimationCurve blankScreenCurve; // 0x20
	System.Int32 FullScreenId; // 0x28
	UnityEngine.Texture2D Image; // 0x30
	UnityEngine.Color fullScreenColor; // 0x38
	UnityEngine.AnimationCurve dissolveProgressCurve; // 0x48
	UnityEngine.Vector2 radialBlurCenter; // 0x50
	UnityEngine.AnimationCurve radialBlurRadiusCurve; // 0x58
	System.Int32 radialBlurLoop; // 0x60
	UnityEngine.Rendering.Universal.MotionBlurQuality motionBlurQuality; // 0x64
	UnityEngine.AnimationCurve motionBlurIntensityCurve; // 0x68
	System.Single motionBlurClamp; // 0x70
	System.Boolean isFollowObject; // 0x74
	WizardGames.Soc.Common.Data.ETimelineTag followTag; // 0x78
	System.Int32 followTagId; // 0x7c
	UnityEngine.Vector3 blastWindPos; // 0x80
	UnityEngine.AnimationCurve blastRangeCurve; // 0x90
	UnityEngine.AnimationCurve blastPowerCurve; // 0x98
	UnityEngine.AnimationCurve blastLeafPowerCurve; // 0xa0
	UnityEngine.AnimationCurve blastLeafShakeCurve; // 0xa8
	UnityEngine.Rendering.Universal.DepthOfFieldMode depthOfFieldMode; // 0xb0
	System.Single depthOfFieldStartDistance; // 0xb4
	System.Single depthOfFieldEndDistance; // 0xb8
	UnityEngine.AnimationCurve depthOfFieldMaxRadiusCurve; // 0xc0
	UnityEngine.Material fullScreenMaterial; // 0xc8
	UnityEngine.Gradient fullScreenGradient; // 0xd0
	UnityEngine.AnimationCurve fullScreenColorIntensityCurve; // 0xd8
	UnityEngine.AnimationCurve fullScreenDissolveIntensityCurve; // 0xe0
	UnityEngine.AnimationCurve fullScreenDistortionIntensityCurve; // 0xe8
	UnityEngine.AnimationCurve fullScreenUCurve; // 0xf0
	UnityEngine.AnimationCurve fullScreenVCurve; // 0xf8
	UnityEngine.Timeline.ClipCaps get_clipCaps(); // 0x0598eaf8
	WizardGames.Soc.Common.Unity.Timeline.ESocClipType get_ClipType(); // 0x0598eb5c
	UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go); // 0x0598ebc0
	System.Void .ctor(); // 0x0598f070
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.PostProcessEffectClipBehaviour : UnityEngine.Playables.PlayableBehaviour
{
	static SocLogger logger; // 0x0
	static System.Single intensityMagicNumber; // 0x8
	WizardGames.Soc.Common.Unity.Timeline.EPostProcessEffectType EffectType; // 0x10
	UnityEngine.AnimationCurve blankScreenCurve; // 0x18
	UnityEngine.Texture2D Image; // 0x20
	System.Int32 FullScreenId; // 0x28
	UnityEngine.Color fullScreenColor; // 0x2c
	UnityEngine.AnimationCurve dissolveProgressCurve; // 0x40
	UnityEngine.Vector2 radialBlurCenter; // 0x48
	UnityEngine.AnimationCurve radialBlurRadiusCurve; // 0x50
	System.Int32 radialBlurLoop; // 0x58
	UnityEngine.Rendering.Universal.MotionBlurQuality motionBlurQuality; // 0x5c
	UnityEngine.AnimationCurve motionBlurIntensityCurve; // 0x60
	System.Single motionBlurClamp; // 0x68
	System.Boolean isFollowObject; // 0x6c
	WizardGames.Soc.Common.Data.ETimelineTag followTag; // 0x70
	System.Int32 followTagId; // 0x74
	UnityEngine.Vector3 blastWindPos; // 0x78
	UnityEngine.AnimationCurve blastRangeCurve; // 0x88
	UnityEngine.AnimationCurve blastPowerCurve; // 0x90
	UnityEngine.AnimationCurve blastLeafPowerCurve; // 0x98
	UnityEngine.AnimationCurve blastLeafShakeCurve; // 0xa0
	UnityEngine.Rendering.Universal.DepthOfFieldMode depthOfFieldMode; // 0xa8
	System.Single depthOfFieldStartDistance; // 0xac
	System.Single depthOfFieldEndDistance; // 0xb0
	UnityEngine.AnimationCurve depthOfFieldMaxRadiusCurve; // 0xb8
	UnityEngine.Material fullScreenMaterial; // 0xc0
	UnityEngine.Gradient fullScreenGradient; // 0xc8
	UnityEngine.AnimationCurve fullScreenColorIntensityCurve; // 0xd0
	UnityEngine.AnimationCurve fullScreenDissolveIntensityCurve; // 0xd8
	UnityEngine.AnimationCurve fullScreenDistortionIntensityCurve; // 0xe0
	UnityEngine.AnimationCurve fullScreenUCurve; // 0xe8
	UnityEngine.AnimationCurve fullScreenVCurve; // 0xf0
	static System.String defaultImageName; // 0x10
	static SOC.TA.PostProcessEffectController postProcessEffectController; // 0x18
	static UnityEngine.GameObject fullScreenUI; // 0x20
	static UnityEngine.Rendering.Volume renderVolume; // 0x28
	static UnityEngine.Rendering.Volume ppvBaseVolume; // 0x30
	static SOC.TA.FullScreenUiRenderingController fullScreenUiRenderingController; // 0x38
	UnityEngine.GameObject followObject; // 0xf8
	System.Boolean <FirstPlay>k__BackingField; // 0x100
	System.Boolean get_FirstPlay(); // 0x0598f300
	System.Void set_FirstPlay(System.Boolean value); // 0x0598f364
	static UnityEngine.Playables.ScriptPlayable<WizardGames.Soc.SocClient.Timeline.PostProcessEffectClipBehaviour> Create(UnityEngine.Playables.PlayableGraph graph, WizardGames.Soc.Common.Unity.Timeline.EPostProcessEffectType effectType); // 0x0598ef3c
	static System.Void BindStaticObjects(); // 0x0598f3e0
	System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData); // 0x0598fcf8
	System.Void SwitchState(System.Boolean enabled); // 0x05990f48
	System.Void SwitchBlinkState(System.Boolean enabled); // 0x05991118
	System.Void SwitchBlankScreenState(System.Boolean enabled); // 0x059911d8
	System.Void SwitchLenDistortionState(System.Boolean enabled); // 0x05991348
	System.Void SwitchImageState(System.Boolean enabled); // 0x05991490
	System.Void SwitchDissolveState(System.Boolean enabled); // 0x0599167c
	System.Void SwitchRadialBlurState(System.Boolean enabled); // 0x05991830
	System.Void SwitchMotionBlurState(System.Boolean enabled); // 0x059919b8
	System.Void SwitchBlastWindState(System.Boolean enabled); // 0x05991b40
	System.Void SwitchDepthOfFieldState(System.Boolean enabled); // 0x05991d00
	System.Void SwitchFullScreenMaterialState(System.Boolean enabled); // 0x05991eac
	System.Void UpdateBlink(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData); // 0x0598ff5c
	System.Void UpdateBlankScreen(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData); // 0x059900b8
	System.Void UpdateDissolve(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData); // 0x0599027c
	System.Void UpdateRadialBlur(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData); // 0x05990438
	System.Void UpdateMotionBlur(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData); // 0x059905f4
	System.Void UpdateBlastWindState(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData); // 0x059907c8
	System.Void UpdateDepthOfField(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData); // 0x05990a24
	System.Void UpdateFullScreenMaterial(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData); // 0x05990be0
	static UnityEngine.Color CalculateAdjustedColor(UnityEngine.Color inputColor, System.Single intensity); // 0x059921c4
	System.Void HideAllEffect(); // 0x0598fae8
	System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x0599229c
	System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x05992474
	System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable); // 0x0599270c
	static System.Single GetProgress(UnityEngine.Playables.Playable playable); // 0x059920ec
	System.Boolean CanPlay(); // 0x05992378
	System.Void BehaviorPauseAction(UnityEngine.Playables.FrameData info); // 0x05992618
	System.Void .ctor(); // 0x059927a4
	static System.Void .cctor(); // 0x05992814
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.SocPrefabControlPlayable : UnityEngine.Playables.PlayableBehaviour
{
	static SocLogger logger; // 0x0
	UnityEngine.GameObject m_Prefab; // 0x10
	UnityEngine.GameObject m_Instance; // 0x18
	System.Boolean isSustain; // 0x20
	System.Boolean cached; // 0x21
	UnityEngine.Vector3 instPos; // 0x24
	UnityEngine.Quaternion instRot; // 0x30
	UnityEngine.Vector3 instScale; // 0x40
	static UnityEngine.Playables.ScriptPlayable<WizardGames.Soc.SocClient.Timeline.SocPrefabControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject prefabGameObject, UnityEngine.Transform parentTransform, System.Boolean sustain); // 0x05989524
	static UnityEngine.Playables.ScriptPlayable<WizardGames.Soc.SocClient.Timeline.SocPrefabControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject prefabGameObject, UnityEngine.Transform parentTransform); // 0x05992924
	UnityEngine.GameObject get_prefabInstance(); // 0x05993074
	UnityEngine.GameObject Initialize(UnityEngine.GameObject prefabGameObject, UnityEngine.Transform parentTransform); // 0x05992aa0
	System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable); // 0x0599342c
	System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x05993678
	System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x05993778
	static System.Void SetHideFlagsRecursive(UnityEngine.GameObject gameObject); // 0x059930d8
	System.Void CacheTranform(); // 0x05993984
	System.Void .ctor(); // 0x05993a98
	static System.Void .cctor(); // 0x05993b00
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.SubtitleClip : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset, WizardGames.Soc.Common.Unity.Timeline.ISocClipAsset
{
	System.Int32 SubtitleId; // 0x18
	UnityEngine.Timeline.ClipCaps get_clipCaps(); // 0x05993bd4
	UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go); // 0x05993c38
	System.Void .ctor(); // 0x05993e50
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.SubtitleClipBehaviour : UnityEngine.Playables.PlayableBehaviour
{
	static SocLogger logger; // 0x0
	System.Int32 subtitleId; // 0x10
	System.Boolean isValid; // 0x14
	System.Boolean isTrigger; // 0x15
	static UnityEngine.Playables.ScriptPlayable<WizardGames.Soc.SocClient.Timeline.SubtitleClipBehaviour> Create(UnityEngine.Playables.PlayableGraph graph, System.Int32 subtitleId); // 0x05993d4c
	System.Void Init(System.Int32 inSubtitleId); // 0x05993ec0
	System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData); // 0x05994270
	System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x05994530
	System.Boolean SafeCheck(); // 0x05993f48
	System.Void .ctor(); // 0x05994650
	static System.Void .cctor(); // 0x059946b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.FadeInOutPlayable : UnityEngine.Playables.PlayableBehaviour
{
	UnityEngine.ParticleSystem[] particleSystems; // 0x10
	System.Collections.Generic.Dictionary<UnityEngine.ParticleSystem,UnityEngine.ParticleSystem.MinMaxGradient> originGradients; // 0x18
	WizardGames.Soc.SocClient.Timeline.FadeInOutType fadeInOutType; // 0x20
	System.Single fadeInDuration; // 0x24
	System.Single fadeOutDuration; // 0x28
	System.Single m_LastPlayableTime; // 0x2c
	static UnityEngine.Playables.ScriptPlayable<WizardGames.Soc.SocClient.Timeline.FadeInOutPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.ParticleSystem[] particleSystems, System.Single fadeInDuration, System.Single fadeOutDuration, WizardGames.Soc.SocClient.Timeline.FadeInOutType fadeInOutType); // 0x0599478c
	System.Void Initialize(); // 0x059948d0
	System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable); // 0x05994ac4
	System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData); // 0x05994d14
	System.Void .ctor(); // 0x05995018
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.ScreenEffectPlayable : UnityEngine.Playables.PlayableBehaviour
{
	UnityEngine.GameObject screenEffect; // 0x10
	UnityEngine.Vector3 localPosition; // 0x18
	UnityEngine.Vector3 localRotation; // 0x24
	static UnityEngine.Playables.ScriptPlayable<WizardGames.Soc.SocClient.Timeline.ScreenEffectPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject gameObject, UnityEngine.Vector3 localPosition, UnityEngine.Vector3 localRotation); // 0x05995088
	System.Void InitEffect(); // 0x05995254
	System.Void .ctor(); // 0x059954e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.SocControlPlayable : UnityEngine.Playables.PlayableBehaviour
{
	UnityEngine.GameObject effect; // 0x10
	System.Boolean screenEffect; // 0x18
	System.Boolean follow; // 0x19
	UnityEngine.Vector3 localPosition; // 0x1c
	UnityEngine.Vector3 localRotation; // 0x28
	static UnityEngine.Playables.ScriptPlayable<WizardGames.Soc.SocClient.Timeline.SocControlPlayable> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject gameObject, WizardGames.Soc.SocClient.Timeline.SocControlPlayableAsset config); // 0x05995708
	System.Void InitScreenEffect(); // 0x05995bac
	System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x05995df8
	System.Void .ctor(); // 0x05995eec
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Timeline.FadeInOutType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Timeline.FadeInOutType None = 0;
	static WizardGames.Soc.SocClient.Timeline.FadeInOutType FadeIn = 1;
	static WizardGames.Soc.SocClient.Timeline.FadeInOutType FadeOut = 2;
	static WizardGames.Soc.SocClient.Timeline.FadeInOutType FadeInThenOut = 3;
	static WizardGames.Soc.SocClient.Timeline.FadeInOutType FadeOutThenIn = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.SocControlPlayableAsset : UnityEngine.Timeline.ControlPlayableAsset
{
	static SocLogger logger; // 0x0
	System.Boolean screenEffect; // 0x63
	System.Boolean Follow; // 0x64
	UnityEngine.Vector3 localPosition; // 0x68
	UnityEngine.Vector3 localRotation; // 0x74
	WizardGames.Soc.SocClient.Timeline.FadeInOutType fadeInOutType; // 0x80
	System.Single fadeInDuration; // 0x84
	System.Single fadeOutDuration; // 0x88
	System.Void CustomCreatePlayable(UnityEngine.GameObject sourceObject, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> playables); // 0x05995f5c
	System.Void CreateFadeInOutPlayable(UnityEngine.ParticleSystem[] particles, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> playables); // 0x0599629c
	System.Void CreateScreenEffectPlayable(UnityEngine.GameObject sourceObject, UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.List<UnityEngine.Playables.Playable> outplayables); // 0x05996444
	System.Void .ctor(); // 0x059965f0
	static System.Void .cctor(); // 0x059966ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.SocControlTrack : UnityEngine.Timeline.ControlTrack
{
	
	System.Void .ctor(); // 0x059967c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.TimelineEventListenerClipAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset, WizardGames.Soc.Common.Unity.Timeline.ISocClipAsset
{
	WizardGames.Soc.SocClient.Timeline.TimelineEventListenerData EventData; // 0x18
	WizardGames.Soc.Common.Unity.Timeline.ESocClipType get_ClipType(); // 0x05996828
	UnityEngine.Timeline.ClipCaps get_clipCaps(); // 0x0599688c
	UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner); // 0x059968f0
	System.Void .ctor(); // 0x05996b1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.TimelineEventListenerClipBehavior : UnityEngine.Playables.PlayableBehaviour
{
	WizardGames.Soc.SocClient.Timeline.TimelineEventListenerData eventData; // 0x10
	System.Boolean <FirstPlay>k__BackingField; // 0x18
	System.Boolean get_FirstPlay(); // 0x05996b84
	System.Void set_FirstPlay(System.Boolean value); // 0x05996be8
	static UnityEngine.Playables.ScriptPlayable<WizardGames.Soc.SocClient.Timeline.TimelineEventListenerClipBehavior> Create(UnityEngine.Playables.PlayableGraph graph); // 0x05996a60
	System.Void Init(WizardGames.Soc.SocClient.Timeline.TimelineEventListenerData data); // 0x05996c64
	System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x05996cdc
	System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x05996f3c
	System.Boolean CanPlay(); // 0x05996e38
	System.Void BehaviorPauseAction(UnityEngine.Playables.FrameData info); // 0x0599701c
	System.Void .ctor(); // 0x05997110
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Timeline.ETimelineEventListenerType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Timeline.ETimelineEventListenerType None = 0;
	static WizardGames.Soc.SocClient.Timeline.ETimelineEventListenerType Guide = 1;
	static WizardGames.Soc.SocClient.Timeline.ETimelineEventListenerType Button_Green = 2;
	static WizardGames.Soc.SocClient.Timeline.ETimelineEventListenerType Button_Red = 3;
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Timeline.TimelineEventListenerData : System.ValueType, System.IEquatable<WizardGames.Soc.SocClient.Timeline.TimelineEventListenerData>
{
	WizardGames.Soc.SocClient.Timeline.ETimelineEventListenerType EventListenerType; // 0x10
	System.Int32 GuideId; // 0x14
	System.Boolean Equals(WizardGames.Soc.SocClient.Timeline.TimelineEventListenerData other); // 0x05997180
	System.Boolean Equals(System.Object obj); // 0x05997218
	System.Int32 GetHashCode(); // 0x059972dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.TimelineEventListenerTrackAsset : UnityEngine.Timeline.TrackAsset, WizardGames.Soc.Common.Unity.Timeline.ISocTrackAsset
{
	WizardGames.Soc.Common.Data.ETimelineTag Tag; // 0xa0
	WizardGames.Soc.Common.Unity.Timeline.ESocTrackType get_TrackType(); // 0x05997384
	WizardGames.Soc.Common.Data.ETimelineTag GetTag(); // 0x059973e8
	UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount); // 0x0599744c
	System.Void .ctor(); // 0x05997548
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.TimelineEventListenerTrackBehavior : UnityEngine.Playables.PlayableBehaviour
{
	
	System.Void .ctor(); // 0x059975d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.MgrClientTimeline : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	static System.Boolean EnableServerTimeout; // 0x8
	System.Boolean IsPlaying; // 0x11
	System.Boolean hasInterrupted; // 0x12
	System.Boolean hasCameraInfo; // 0x13
	System.Int64 currentTimelineId; // 0x18
	UnityEngine.Playables.DirectorWrapMode currentWrapMode; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.Common.Unity.Timeline.ISocClipAsset> clipsNeedHandle; // 0x28
	static System.String cameraLocatorName; // 0x10
	System.Boolean ControlCamera; // 0x30
	System.Boolean StoryState; // 0x31
	System.Boolean CameraStoryStateEnding; // 0x32
	UnityEngine.Transform CameraLocator; // 0x38
	UnityEngine.Transform CameraLocatorTransition; // 0x40
	UnityEngine.Vector3 cameraSmoothInitPos; // 0x48
	UnityEngine.Quaternion cameraSmoothInitRot; // 0x54
	System.Single CameraSmoothProgress; // 0x64
	System.Single nearClipPlane; // 0x68
	System.Single farClipPlane; // 0x6c
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.AssetPool.AssetPoolHandle> AllTimelines; // 0x70
	System.Collections.Generic.HashSet<UnityEngine.GameObject> sustainedEffect; // 0x78
	System.Collections.Generic.Dictionary<System.Int64,UnityEngine.GameObject> tagGos; // 0x80
	System.Collections.Generic.Dictionary<System.Int64,System.String> tagToPath; // 0x88
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> tagToModel; // 0x90
	UnityEngine.GameObject root; // 0x98
	UnityEngine.GameObject effectRoot; // 0xa0
	UnityEngine.GameObject effectPool; // 0xa8
	UnityEngine.GameObject npcRoot; // 0xb0
	UnityEngine.GameObject FakePlayer; // 0xb8
	UnityEngine.Playables.PlayableDirector director; // 0xc0
	static System.String TimelineRoot; // 0x18
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Timeline.TimelineEventListenerData> timelineEventListenerSet; // 0xc8
	System.Int64 timelineCheckStopTimer; // 0xd0
	static System.Collections.Generic.Dictionary<System.Int64,System.Tuple<System.Int64,System.Int64>> timelinePreloadTask; // 0x20
	static System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.HashSet<System.Int64>> taskPreloadModel; // 0x28
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<System.Int64>> modelToTask; // 0xd8
	System.Collections.Generic.HashSet<WizardGames.Soc.Common.Data.ETimelineTag> playerTag; // 0xe0
	static WizardGames.Soc.SocClient.Timeline.EReleaseType defaultReleaseType; // 0x30
	static System.Boolean AlwaysHold; // 0x34
	static System.Boolean TimelineAssetPreloadFlag; // 0x35
	static WizardGames.Soc.SocClient.Timeline.TimelineResRef timelineResRef; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Timeline.ResInfo> resInfos; // 0xe8
	System.Collections.Generic.HashSet<System.Int64> currentTimelineRes; // 0xf0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Timeline.EReleaseType> resReleaseTypes; // 0xf8
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<System.String>> timelineAnimationPaths; // 0x100
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<System.String>> timelineEffectPaths; // 0x108
	System.Collections.Generic.HashSet<System.String> sustainedEffectPrefabs; // 0x110
	System.Collections.Generic.Dictionary<System.String,UnityEngine.GameObject> effectPrefabs; // 0x118
	System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Timeline.PreloadInfo> preloadingQueue; // 0x120
	System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Timeline.PreloadInfo> unloadingQueue; // 0x128
	System.Collections.Generic.HashSet<System.Int64> curLoadingIds; // 0x130
	System.Collections.Generic.HashSet<System.Int64> curUnloadingIds; // 0x138
	System.Collections.Generic.HashSet<System.Int64> preloadWhitelist; // 0x140
	System.Diagnostics.Stopwatch stopWatch; // 0x148
	static System.Double loadWarnTimeMs; // 0x40
	static WizardGames.AssetPool.AssetPoolHandle timelineResRefHandle; // 0x48
	System.Boolean get_EnableMode(); // 0x0599763c
	UnityEngine.Playables.DirectorWrapMode WrapMode(System.Int64 timelineId); // 0x059976c4
	System.Void InitRootObjects(); // 0x059977d8
	System.Threading.Tasks.Task OnEnterWorld(); // 0x05997c28
	System.Void OnPlayerLoaded(); // 0x05998310
	System.Threading.Tasks.Task OnExitWorld(); // 0x059984f8
	System.Void OnFastDisconnected(WizardGames.Soc.Common.Framework.Network.DisconnectReason reason); // 0x059997e8
	System.Void OnFastReconnected(); // 0x05999a54
	System.Void TryPlayTimeline(System.Int64 timelineId); // 0x05999afc
	System.Void TryStopTimeline(System.Int64 timelineId); // 0x0599a174
	System.Void PlayTimeline(System.Int64 timelineId); // 0x05999da8
	System.Void BindTimelineAsset(System.Int64 timelineId); // 0x0599a518
	System.Void PlayTimelineAfterBinding(System.Int64 timelineId); // 0x0599cb14
	System.Void OnTimelineReachEnd(UnityEngine.Playables.PlayableDirector playableDirector); // 0x0599d364
	System.Void OnTimelineStopped(UnityEngine.Playables.PlayableDirector playableDirector); // 0x0599d504
	System.Void TimelineTryPause(); // 0x0599988c
	System.Void TimelineFinish(System.Int64 timelineId); // 0x05998624
	System.Void UIRecoverOnTimelineFinish(); // 0x0599df24
	System.Void HoldModeAddStopTimer(); // 0x055049cc
	System.Void HoldModeRemoveStopTimer(); // 0x05999510
	System.Void CheckTimelineStop(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x0599e92c
	System.Void HideFakePlayer(); // 0x0599d9ec
	System.Void SustainEffect(); // 0x0599db28
	System.Void OnViewGuideChange(System.Int32 guideId); // 0x0599ec10
	System.Void OnTimelineUpdatePlayableStatus(WizardGames.Soc.SocClient.Timeline.TimelineEventListenerData eventListenerData); // 0x0599edfc
	System.Void SetFakePlayerScale(UnityEngine.Vector3 scale); // 0x0599eb08
	System.Void UpdateTimelineCameraState(System.Boolean controlCamera, System.Boolean storyState); // 0x0599eebc
	System.Void InitEndingCamera(System.Int64 timelineId); // 0x0599e234
	System.Boolean UpdateEndingCamera(System.Single deltaTime); // 0x0599ef48
	System.Void UpdateTimelineStatus(System.Boolean enable); // 0x0599ed44
	System.Void BindTrackRes(System.Int64 timelineId); // 0x0599a9c8
	System.Void BindClipRes(System.Int64 timelineId); // 0x0599bf9c
	System.Void BindHierarchyTrack(WizardGames.Soc.SocClient.Timeline.HierarchyTrackAsset track); // 0x0599fe48
	static UnityEngine.Animator GetAnimatorViaGameObject(UnityEngine.GameObject go); // 0x059a0a78
	static UnityEngine.GameObject FindChildByPath(UnityEngine.Transform parent, System.String path); // 0x059a059c
	static System.Int64 EncodeTag(WizardGames.Soc.Common.Data.ETimelineTag tag, System.Int32 tagId); // 0x059a0864
	static System.ValueTuple<WizardGames.Soc.Common.Data.ETimelineTag,System.Int32> DecodeTag(System.Int64 tagId); // 0x059a0b80
	System.Void ReturnCutSceneMainGo(System.Collections.Generic.List<WizardGames.Soc.Common.Data.ActionName> actions); // 0x059a0c1c
	System.Void GetCutSceneMainGo(System.Boolean cameraMoveMode, System.Collections.Generic.List<WizardGames.Soc.Common.Data.ActionName> actions); // 0x059a0cfc
	System.Void TrySaveCameraInfo(); // 0x0599a3d0
	System.Void TryRecoverCameraInfo(); // 0x0599d898
	System.Void PreloadAssets(); // 0x059980d4
	System.Void AddListener(); // 0x05998140
	System.Void RemoveListener(); // 0x05999618
	System.Void ReleaseRes(); // 0x05999484
	System.Void ReleaseAllTagGosAndTasks(); // 0x059a231c
	System.Void ReleaseRootObjects(); // 0x059a2648
	System.Void ReleasePreAssets(); // 0x059a1fd4
	System.Void ReleasePreloadedEffects(); // 0x059a2874
	System.Void RegisterTag(WizardGames.Soc.Common.Data.ETimelineTag tag, System.Int32 id, UnityEngine.GameObject gameObject, System.String prefabPath); // 0x059983d0
	System.Void UnregisterTag(WizardGames.Soc.Common.Data.ETimelineTag tag, System.Int32 id); // 0x059a2ae8
	System.String GetPathByTag(WizardGames.Soc.Common.Data.ETimelineTag tag, System.Int32 id); // 0x059a2e48
	UnityEngine.GameObject GetPreloadedEffect(UnityEngine.GameObject prefab); // 0x059a2f1c
	System.Void ReturnEffect(UnityEngine.GameObject prefab, UnityEngine.GameObject effect, System.Boolean isSustain); // 0x059a3154
	static System.Void PlayEffectOnGameObject(UnityEngine.GameObject effectObject); // 0x059a33b0
	static System.Void OpenUiRemoteControl(WizardGames.Soc.SocClient.Ui.UiRemoteControl.EWinState winState); // 0x059a3474
	System.Void ChangeTimelineSpeed(System.Single speed); // 0x059a35a8
	System.Void JumpToEnd(); // 0x0599a090
	System.Void InitNewbieParams(); // 0x05997d20
	System.Void InitNewbieModelConfig(); // 0x059a36ac
	System.Void NewbieAddListener(); // 0x059a1b1c
	System.Void NewbieRemoveListener(); // 0x059a1c28
	System.Void NewbieTimelinePlay(); // 0x0599ca70
	System.Void NewbieTimelineFinish(); // 0x0599e890
	System.Void LoadNewbieSceneGo(); // 0x05997d94
	System.Void LoadSingleSceneGo(System.Int64 modelId); // 0x059a4420
	static System.Void UnloadSingleSceneGo(System.Int64 modelId); // 0x059a44e0
	System.Boolean NewbieBindAnimationTrack(System.Int64 timelineId, WizardGames.Soc.Common.Unity.Timeline.ISocTrackAsset socTrack, WizardGames.Soc.Common.Data.ETimelineTag tag, System.Int32 tagId); // 0x0599f3e0
	System.Void InitTaskToModels(); // 0x059a393c
	System.Void InitNewbieTaskToTimeline(); // 0x059a3ee0
	System.Void ReleaseNewbieTaskData(); // 0x059993b0
	System.Int64 GetLatestValidTaskId(System.Int64 modelId, System.Int64 curTaskId, System.Boolean& isEqual); // 0x059a4684
	System.Int64 GetLastValidTaskId(System.Int64 modelId, System.Int64 curTaskId); // 0x059a47e0
	System.Void OnRemoteClick(System.Int32 btnNum); // 0x059a490c
	System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Timeline.PreloadInfo> LoadingQueue(System.Boolean isLoad); // 0x059a4a44
	System.Void InitTimelineAssetResPath(); // 0x059a0de8
	System.Void Update(System.Single deltaTime); // 0x059a4dfc
	System.Void UpdateTask(System.Int64 taskId, System.Boolean isAwake); // 0x059a4f6c
	System.Void PreloadTimelineAssets(); // 0x059a1440
	System.Boolean LoadSingleTimelineAsset(System.Int64 id, System.String resPath); // 0x0599cd80
	System.Void UnloadSingleTimelineAsset(System.Int64 id, System.Boolean forceUnload); // 0x059a5d90
	System.Void ModelLoadOnTaskChange(System.Int64 taskId); // 0x059a5b2c
	System.Void AddModelToUnloadQueue(System.Int64 modelId); // 0x059a6230
	System.Void AddTaskPreloadModel(WizardGames.Soc.Common.Data.Play.NewbieModelConfig config); // 0x059a4290
	System.Void ReleaseResInfo(); // 0x059a27a8
	UnityEngine.GameObject GetObjectViaTag(WizardGames.Soc.Common.Data.ETimelineTag tag, System.Int32 tagId, WizardGames.Soc.SocClient.Timeline.EReqSource source); // 0x0599fa1c
	UnityEngine.GameObject GetOrCreateHierarchyTag(WizardGames.Soc.Common.Data.ETimelineTag tag, System.Int32 tagId); // 0x059a632c
	System.Int64 InstModelFromConfig(WizardGames.Soc.Common.Data.Play.NewbieModelConfig conf); // 0x059a6470
	System.Void ReleaseCurrentTimelineModels(); // 0x0599e060
	System.Void AddRef(System.Int64 modelId, WizardGames.Soc.SocClient.Timeline.EReqSource source); // 0x059a6a38
	System.Void RemoveRef(WizardGames.Soc.Common.Data.ETimelineTag tag, System.Int32 tagId, WizardGames.Soc.SocClient.Timeline.EReqSource source); // 0x059a6dcc
	static System.Int32 CalcRefCount(System.Int32 inputCount, System.Boolean isAdd, WizardGames.Soc.SocClient.Timeline.EReqSource source); // 0x059a7200
	System.Void LoadOrUnloadOnTaskChange(System.Int64 taskId, System.Int64 timelineId); // 0x059a52c4
	System.Void AddToLoadingQueue(System.Int64 timelineId, System.Boolean isLoad); // 0x0599893c
	System.Void UpdateAllLoadingTasks(); // 0x059a594c
	System.Void UpdateAllUnloadingTasks(); // 0x059a1df4
	System.Void UpdateLoadingTask(System.Boolean isLoad); // 0x059a4e84
	System.Void UpdateLoadingTaskImpl(WizardGames.Soc.SocClient.Timeline.PreloadInfo preloadInfo, System.Boolean isLoad); // 0x059a7294
	System.Void ClearCamera(UnityEngine.GameObject go, System.Int64 modelId); // 0x059a6d50
	System.Boolean LoadResRefHandle(); // 0x059a4ac8
	System.Void ReleaseAllHandle(); // 0x059a1d34
	System.Void .ctor(); // 0x059a7a44
	static System.Void .cctor(); // 0x059a80f4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Timeline.EReqSource : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Timeline.EReqSource TIMELINE = 0;
	static WizardGames.Soc.SocClient.Timeline.EReqSource NPC = 1;
	static WizardGames.Soc.SocClient.Timeline.EReqSource OTHERS = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Timeline.ELoadType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Timeline.ELoadType ALWAYS_LOAD = 0;
	static WizardGames.Soc.SocClient.Timeline.ELoadType LOAD_ON_PLAY = 1;
	static WizardGames.Soc.SocClient.Timeline.ELoadType LOAD_ON_ENTER = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Timeline.EReleaseType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Timeline.EReleaseType HOLD = 0;
	static WizardGames.Soc.SocClient.Timeline.EReleaseType IMMEDIATE = 1;
	static WizardGames.Soc.SocClient.Timeline.EReleaseType DELAY = 2;
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Timeline.ResInfo : System.ValueType
{
	System.Int64 ModelId; // 0x10
	System.Single LastActiveTime; // 0x18
	WizardGames.Soc.SocClient.Timeline.EReleaseType ReleaseType; // 0x1c
	System.Int32 RefCount; // 0x20
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Timeline.EPreloadType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Timeline.EPreloadType ANIMATION = 0;
	static WizardGames.Soc.SocClient.Timeline.EPreloadType EFFECT = 1;
	static WizardGames.Soc.SocClient.Timeline.EPreloadType TIMELINE = 2;
	static WizardGames.Soc.SocClient.Timeline.EPreloadType MODEL = 3;
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Timeline.PreloadInfo : System.ValueType
{
	System.Int64 ID; // 0x10
	System.String Path; // 0x18
	WizardGames.Soc.SocClient.Timeline.EPreloadType Type; // 0x20
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.MoveClipAsset : UnityEngine.Playables.PlayableAsset, WizardGames.Soc.Common.Unity.Timeline.ISocClipAsset, UnityEngine.Timeline.ITimelineClipAsset
{
	System.Boolean HasStartTransform; // 0x18
	UnityEngine.Vector3 StartPos; // 0x1c
	UnityEngine.Vector3 EndPos; // 0x28
	UnityEngine.Quaternion StartRot; // 0x34
	UnityEngine.Quaternion EndRot; // 0x44
	System.Boolean CanMovePosX; // 0x54
	System.Boolean CanMovePosY; // 0x55
	System.Boolean CanMovePosZ; // 0x56
	System.Boolean CanMoveRotY; // 0x57
	System.Boolean CanMoveRotXZ; // 0x58
	System.Boolean MoveCamera; // 0x59
	UnityEngine.AnimationCurve Curve; // 0x60
	WizardGames.Soc.Common.Unity.Timeline.ESocClipType get_ClipType(); // 0x059a82f8
	UnityEngine.Timeline.ClipCaps get_clipCaps(); // 0x059a835c
	UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner); // 0x059a83c0
	System.Void .ctor(); // 0x059a85ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.MoveClipBehaviour : UnityEngine.Playables.PlayableBehaviour
{
	System.Boolean HasStartTransform; // 0x10
	UnityEngine.Vector3 StartPos; // 0x14
	UnityEngine.Vector3 EndPos; // 0x20
	UnityEngine.Quaternion StartRot; // 0x2c
	UnityEngine.Quaternion EndRot; // 0x3c
	System.Boolean CanMovePosX; // 0x4c
	System.Boolean CanMovePosY; // 0x4d
	System.Boolean CanMovePosZ; // 0x4e
	System.Boolean CanMoveRotY; // 0x4f
	System.Boolean CanMoveRotXZ; // 0x50
	UnityEngine.AnimationCurve Curve; // 0x58
	System.Boolean MoveCamera; // 0x60
	System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x059a865c
	System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x059a8904
	System.Void .ctor(); // 0x059a8584
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.MoveTrackAsset : UnityEngine.Timeline.TrackAsset, WizardGames.Soc.Common.Unity.Timeline.ISocTrackAsset
{
	WizardGames.Soc.Common.Data.ETimelineTag Tag; // 0xa0
	System.Int32 TagId; // 0xa4
	WizardGames.Soc.Common.Unity.Timeline.ESocTrackType get_TrackType(); // 0x059a8a74
	WizardGames.Soc.Common.Data.ETimelineTag GetTag(); // 0x059a8ad8
	System.Int32 GetTagId(); // 0x059a8b3c
	System.Void BindTrack(); // 0x059a8ba0
	UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount); // 0x059a8c28
	System.Void .ctor(); // 0x059a8d98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.MoveTrackBehaviour : UnityEngine.Playables.PlayableBehaviour
{
	static UnityEngine.AnimationCurve defaultCurve; // 0x0
	System.Boolean shouldInitTransform; // 0x10
	UnityEngine.Vector3 startPos; // 0x14
	UnityEngine.Quaternion startRot; // 0x20
	System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData); // 0x059a8e24
	UnityEngine.Quaternion CalculateRotationY(UnityEngine.Quaternion rot1, UnityEngine.Quaternion rot2, System.Single progress); // 0x059a9584
	UnityEngine.Quaternion CalculateRotationXYZ(UnityEngine.Quaternion rot1, UnityEngine.Quaternion rot2, System.Single progress); // 0x059a9830
	System.Void InitializeAtFirstFrame(UnityEngine.Transform trackBinding); // 0x059a9348
	static WizardGames.Soc.SocClient.Timeline.MoveClipBehaviour GetMoveClipBehaviour(UnityEngine.Playables.Playable playable); // 0x059a93f8
	static UnityEngine.AnimationCurve GetCurve(WizardGames.Soc.SocClient.Timeline.MoveClipBehaviour moveClipBehaviour); // 0x059a94e8
	System.Void .ctor(); // 0x059a991c
	static System.Void .cctor(); // 0x059a998c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.ColorChangePlan : UnityEngine.ScriptableObject
{
	UnityEngine.Color[] ColorArray; // 0x18
	System.Void .ctor(); // 0x059a99f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.GameboyChangeScreenImageBehaviour : WizardGames.Soc.SocClient.Timeline.SpecialEffectBehaviour
{
	UnityEngine.Material[] materialArray; // 0x20
	static UnityEngine.Playables.ScriptPlayable<WizardGames.Soc.SocClient.Timeline.GameboyChangeScreenImageBehaviour> Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Material[] _materialArray); // 0x059a9a90
	System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x059a9b98
	System.Void ChangeScreenImage(WizardGames.Soc.SocClient.Timeline.SpecialEffectFuncTag[] specialEffectFuncTags, UnityEngine.Material material); // 0x059a9d20
	System.Void .ctor(); // 0x059a9ec8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.GunChangeColorBehaviour : WizardGames.Soc.SocClient.Timeline.SpecialEffectBehaviour
{
	static UnityEngine.MaterialPropertyBlock waterFillingMaterialPropertyBlock; // 0x0
	static UnityEngine.MaterialPropertyBlock colorMaterialPropertyBlock; // 0x8
	static System.Int32 WaterFillingId; // 0x10
	static System.Int32 Color0Id; // 0x14
	static System.Int32 Color1Id; // 0x18
	static System.Int32 Color2Id; // 0x1c
	WizardGames.Soc.SocClient.Timeline.ColorChangePlan colorChangePlan; // 0x20
	System.Boolean get_changeTpWeapon(); // 0x059a9fb8
	static UnityEngine.Playables.ScriptPlayable<WizardGames.Soc.SocClient.Timeline.GunChangeColorBehaviour> Create(UnityEngine.Playables.PlayableGraph graph, WizardGames.Soc.SocClient.Timeline.ColorChangePlan colorChangePlan); // 0x059aa01c
	System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable); // 0x059aa124
	System.Void FillWaterFillingProperty(WizardGames.Soc.SocClient.Timeline.SpecialEffectFuncTag[] specialEffectFuncTags); // 0x059aa1b8
	System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x059aa78c
	System.Void SwitchWeaponColors(WizardGames.Soc.SocClient.Timeline.SpecialEffectFuncTag[] specialEffectFuncTags, System.Int32 index); // 0x059aa90c
	System.Void .ctor(); // 0x059aac50
	static System.Void .cctor(); // 0x059aacd8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.GunChangeColorBehaviour.<>c__DisplayClass11_0 : System.Object
{
	WizardGames.Soc.SocClient.Timeline.SpecialEffectFuncTag specialEffectFuncTag; // 0x10
	System.Single internalTime; // 0x18
	System.Single totalTime; // 0x1c
	System.Void .ctor(); // 0x059aa5fc
	System.Void <FillWaterFillingProperty>b__0(System.Int64 id, System.Object _, System.Boolean delete); // 0x059aae4c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.SpecialEffectBehaviour : UnityEngine.Playables.PlayableBehaviour
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Timeline.SpecialEffectFuncTag[] curTimelineFpTags; // 0x10
	WizardGames.Soc.SocClient.Timeline.SpecialEffectFuncTag[] curTimelineTpTags; // 0x18
	System.Boolean get_changeTpWeapon(); // 0x059aaf94
	System.Void OnPlayableCreate(UnityEngine.Playables.Playable playable); // 0x059aaff8
	System.Void OnPlayableDestroy(UnityEngine.Playables.Playable playable); // 0x059aa550
	System.Void .ctor(); // 0x059a9f50
	static System.Void .cctor(); // 0x059ab240
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Timeline.SpecialEffectFuncType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Timeline.SpecialEffectFuncType ChangeColor = 0;
	static WizardGames.Soc.SocClient.Timeline.SpecialEffectFuncType ChangeScreenImage = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.SpecialEffectFuncClipAsset : UnityEngine.Playables.PlayableAsset
{
	WizardGames.Soc.SocClient.Timeline.SpecialEffectFuncType specialEffectFuncType; // 0x18
	UnityEngine.Material[] materialArray; // 0x20
	UnityEngine.ExposedReference<WizardGames.Soc.SocClient.Timeline.ColorChangePlan> colorChangePlanER; // 0x28
	UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner); // 0x059ab314
	System.Void .ctor(); // 0x059ab4d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.SpecialEffectFuncTag : UnityEngine.MonoBehaviour
{
	UnityEngine.MaterialPropertyBlock recordPropertyBlock; // 0x30
	UnityEngine.Renderer renderer; // 0x38
	UnityEngine.MaterialPropertyBlock get_RecordPropertyBlock(); // 0x059ab53c
	UnityEngine.Renderer get_Renderer(); // 0x059ab5a0
	System.Void Awake(); // 0x059ab604
	System.Void OnEnable(); // 0x059ab690
	System.Void SetPropertyBlock(UnityEngine.MaterialPropertyBlock block); // 0x059aa6f8
	System.Void GetPropertyBlock(UnityEngine.MaterialPropertyBlock block); // 0x059aa664
	System.Void .ctor(); // 0x059ab724
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.SpecialEffectFuncTrack : UnityEngine.Timeline.TrackAsset
{
	
	System.Void .ctor(); // 0x059ab7c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.TimelineDebug : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x059ab850
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.TimelineEditorTable : System.Object
{
	static System.Func<System.String,System.String> UnityConfigLoader; // 0x0
	static System.String <DataPath>k__BackingField; // 0x8
	static WizardGames.Soc.Common.Data.Play.TbSubtitle TbSubtitle; // 0x10
	static System.String get_DataPath(); // 0x059ab8b8
	static System.Void set_DataPath(System.String value); // 0x059ab930
	static System.Void Init(System.String overrideDataPath); // 0x059ab9b4
	static System.Boolean CheckSubTitleTable(System.Int32 subtitleId); // 0x059abea8
	static System.Boolean TryLoadConfig(System.String configFileName, SimpleJSON.JSONNode& outputJson); // 0x059abb1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.TimelineResCollection : UnityEngine.ScriptableObject
{
	System.Collections.Generic.List<UnityEngine.GameObject> effectPrefabs; // 0x18
	System.Collections.Generic.List<UnityEngine.AnimationClip> animClips; // 0x20
	System.Void AddResource(System.Collections.Generic.List<UnityEngine.AnimationClip> animationClipList, System.Collections.Generic.List<UnityEngine.GameObject> effectPrefabList); // 0x059abf84
	System.Void .ctor(); // 0x059ac37c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.ResData : System.Object
{
	System.Collections.Generic.List<System.String> effectPaths; // 0x10
	System.Collections.Generic.List<System.String> animPaths; // 0x18
	System.Void .ctor(System.Collections.Generic.List<System.String> effects, System.Collections.Generic.List<System.String> anims); // 0x059ac488
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.TimelineResRef : UnityEngine.ScriptableObject
{
	SerializableDictionary<System.String,WizardGames.Soc.SocClient.Timeline.ResData> resDict; // 0x18
	System.Collections.Generic.List<System.String> sustainedEffects; // 0x20
	System.Void AddOrRefreshTimeline(UnityEngine.Timeline.TimelineAsset timeline, System.Collections.Generic.List<System.String> animPaths, System.Collections.Generic.List<System.String> effectPaths, System.Collections.Generic.List<System.String> sustainedEffectPaths); // 0x059ac52c
	System.Void .ctor(); // 0x059ac884
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.ActivationColorWeaponTrackAsset : UnityEngine.Timeline.TrackAsset
{
	
	WizardGames.Soc.Common.Unity.Timeline.ESocTrackType get_TrackType(); // 0x059ac938
	System.Void .ctor(); // 0x059ac99c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.ActivationTrackAsset : UnityEngine.Timeline.TrackAsset, WizardGames.Soc.Common.Unity.Timeline.ISocTrackAsset
{
	
	WizardGames.Soc.Common.Unity.Timeline.ESocTrackType get_TrackType(); // 0x059aca28
	UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount); // 0x059aca8c
	System.Void .ctor(); // 0x059acb88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.ActivationTrackMixerBehaviour : UnityEngine.Playables.PlayableBehaviour
{
	
	System.Void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, System.Object playerData); // 0x059acc14
	System.Void .ctor(); // 0x059accb4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.AnimationTrackAsset : UnityEngine.Timeline.AnimationTrack, WizardGames.Soc.Common.Unity.Timeline.ISocTrackAsset
{
	WizardGames.Soc.Common.Data.ETimelineTag Tag; // 0x130
	System.Int32 TagId; // 0x134
	WizardGames.Soc.Common.Unity.Timeline.ESocTrackType get_TrackType(); // 0x059acd1c
	WizardGames.Soc.Common.Data.ETimelineTag GetTag(); // 0x059acd80
	System.Int32 GetTagId(); // 0x059acde4
	System.Void BindTrack(); // 0x059ace48
	System.Void .ctor(); // 0x059aced0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.AudioTrackAsset : UnityEngine.Timeline.TrackAsset, WizardGames.Soc.Common.Unity.Timeline.ISocTrackAsset
{
	
	UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount); // 0x059acf5c
	System.Void .ctor(); // 0x059ad378
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.AudioTrackBehaviour : UnityEngine.Playables.PlayableBehaviour
{
	static SocLogger logger; // 0x0
	System.Void .ctor(); // 0x059ad404
	static System.Void .cctor(); // 0x059ad46c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.CameraClipPlaneTrackAsset : UnityEngine.Timeline.TrackAsset, WizardGames.Soc.Common.Unity.Timeline.ISocTrackAsset
{
	WizardGames.Soc.Common.Data.ETimelineTag Tag; // 0xa0
	WizardGames.Soc.Common.Unity.Timeline.ESocTrackType get_TrackType(); // 0x059ad540
	WizardGames.Soc.Common.Data.ETimelineTag GetTag(); // 0x059ad5a4
	UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount); // 0x059ad608
	System.Void .ctor(); // 0x059ad704
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.CameraClipPlaneTrackBehaviour : UnityEngine.Playables.PlayableBehaviour
{
	
	System.Void .ctor(); // 0x059ad798
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.CameraTrackAsset : UnityEngine.Timeline.TrackAsset, WizardGames.Soc.Common.Unity.Timeline.ISocTrackAsset
{
	WizardGames.Soc.Common.Data.ETimelineTag Tag; // 0xa0
	WizardGames.Soc.Common.Unity.Timeline.ESocTrackType get_TrackType(); // 0x059ad800
	WizardGames.Soc.Common.Data.ETimelineTag GetTag(); // 0x059ad864
	UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount); // 0x059ad8c8
	System.Void .ctor(); // 0x059ad9c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.CameraTrackBehaviour : UnityEngine.Playables.PlayableBehaviour
{
	static UnityEngine.AnimationCurve defaultCurve; // 0x0
	System.Void .ctor(); // 0x059ada58
	static System.Void .cctor(); // 0x059adac0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.ChangeControllerTrackAsset : UnityEngine.Timeline.TrackAsset, WizardGames.Soc.Common.Unity.Timeline.ISocTrackAsset
{
	WizardGames.Soc.Common.Data.ETimelineTag Tag; // 0xa0
	WizardGames.Soc.Common.Unity.Timeline.ESocTrackType get_TrackType(); // 0x059adb2c
	WizardGames.Soc.Common.Data.ETimelineTag GetTag(); // 0x059adb90
	UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount); // 0x059adbf4
	System.Void .ctor(); // 0x059adcf0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.ChangeControllerTrackBehavior : UnityEngine.Playables.PlayableBehaviour
{
	
	System.Void .ctor(); // 0x059add7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.EffectTrackAsset : UnityEngine.Timeline.TrackAsset, WizardGames.Soc.Common.Unity.Timeline.ISocTrackAsset
{
	
	WizardGames.Soc.Common.Unity.Timeline.ESocTrackType get_TrackType(); // 0x059adde4
	UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount); // 0x059ade48
	System.Void .ctor(); // 0x059adf44
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.EffectTrackBehaviour : UnityEngine.Playables.PlayableBehaviour
{
	
	System.Void .ctor(); // 0x059adfd0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.HierarchyTrackAsset : UnityEngine.Timeline.TrackAsset, WizardGames.Soc.Common.Unity.Timeline.ISocTrackAsset
{
	WizardGames.Soc.Common.Data.ETimelineTag Tag; // 0xa0
	System.Int32 TagId; // 0xa4
	UnityEngine.Vector3 StartPos; // 0xa8
	UnityEngine.Quaternion StartRot; // 0xb4
	UnityEngine.GameObject ParentObject; // 0xc8
	UnityEngine.GameObject[] ChildObjects; // 0xd0
	System.Collections.Generic.List<UnityEngine.Transform> OriginalParents; // 0xd8
	WizardGames.Soc.Common.Unity.Timeline.HierarchyTrackData[] ChildrenData; // 0xe0
	WizardGames.Soc.Common.Unity.Timeline.ESocTrackType get_TrackType(); // 0x059ae038
	WizardGames.Soc.Common.Data.ETimelineTag GetTag(); // 0x059ae09c
	System.Int32 GetTagId(); // 0x059ae100
	System.Void BindTrack(); // 0x059ae164
	System.Void SetParentObject(UnityEngine.GameObject parentObject); // 0x059ae1ec
	System.Void SetChildrenObjects(UnityEngine.GameObject[] childObjects); // 0x059a08e0
	UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Int32 inputCount); // 0x059ae26c
	System.Void .ctor(); // 0x059ae3dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.HierarchyTrackBehaviour : UnityEngine.Playables.PlayableBehaviour
{
	UnityEngine.GameObject ParentObject; // 0x10
	UnityEngine.GameObject[] ChildObjects; // 0x18
	System.Collections.Generic.List<UnityEngine.Transform> OriginalParents; // 0x20
	System.Void InitHierarchy(); // 0x059ae538
	System.Void RemoveHierarchy(); // 0x059ae754
	System.Void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x059ae8a0
	System.Void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info); // 0x059ae954
	System.Void .ctor(); // 0x059aea08
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.PostProcessEffectTrackAsset : UnityEngine.Timeline.TrackAsset, WizardGames.Soc.Common.Unity.Timeline.ISocTrackAsset
{
	WizardGames.Soc.Common.Data.ETimelineTag Tag; // 0xa0
	System.Int32 TagId; // 0xa4
	WizardGames.Soc.Common.Unity.Timeline.ESocTrackType get_TrackType(); // 0x059aeabc
	WizardGames.Soc.Common.Data.ETimelineTag GetTag(); // 0x059aeb20
	System.Int32 GetTagId(); // 0x059aeb84
	System.Void BindTrack(); // 0x059aebe8
	System.Void .ctor(); // 0x059aec70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Timeline.SubtitleTrackAsset : UnityEngine.Timeline.TrackAsset, WizardGames.Soc.Common.Unity.Timeline.ISocTrackAsset
{
	
	WizardGames.Soc.Common.Unity.Timeline.ESocTrackType get_TrackType(); // 0x059aed04
	System.Void .ctor(); // 0x059aed68
}

// Client.Runtime
class WizardGames.Soc.SocClient.Monument.MonumentAudioAction : WizardGames.Soc.Common.Unity.Monument.BaseMonumentAction
{
	SocLogger logger; // 0xb8
	UnityEngine.Vector3 actionPos; // 0xc0
	WizardGames.Soc.Common.MonumentPath.BaseWayInfo path; // 0xcc
	System.Collections.Generic.List<System.UInt32> audioIds; // 0xf8
	System.String audioEvent; // 0x100
	System.Single audioPlayTime; // 0x108
	UnityEngine.Vector3 get_fromPos(); // 0x059aedf4
	static WizardGames.Soc.SocClient.Monument.MonumentAudioAction Generate(); // 0x059aef68
	System.Boolean Executor(WizardGames.Soc.Common.Unity.Monument.MonumentActionParams actionParams, System.String& error); // 0x059af01c
	System.Void PostAudioEventCallback(WizardGames.Soc.SocClient.Audio.WWise.AudioEventData audioEventDataData, System.Object obj); // 0x059af3c8
	System.Boolean BaseCheck(UnityEngine.Vector3 fromPos, UnityEngine.Vector3 toPos); // 0x059af86c
	System.Void Release(); // 0x059af990
	System.Void Update(); // 0x059afa00
	System.Void StopAudio(); // 0x059af6c4
	System.Void .ctor(); // 0x059afcc0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Monument.MonumentAudioAction.<>c__DisplayClass10_0 : System.Object
{
	WizardGames.Soc.SocClient.Audio.WWise.AudioEventData audioEventDataData; // 0x10
	System.Void .ctor(); // 0x059af65c
	System.Void <PostAudioEventCallback>b__0(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x059afe74
}

// Client.Runtime
class WizardGames.Soc.SocClient.Monument.MonumentEffectAction : WizardGames.Soc.Common.Unity.Monument.BaseMonumentAction
{
	SocLogger logger; // 0xb8
	UnityEngine.Vector3 actionPos; // 0xc0
	WizardGames.Soc.Common.MonumentPath.BaseWayInfo path; // 0xcc
	System.Collections.Generic.List<Effect.EffectItemHandle<Effect.EffectItem>> effectItems; // 0xf8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.ClientLight.LightItem> lightItems; // 0x100
	System.Int32 effectId; // 0x108
	System.Int32 lightId; // 0x10c
	UnityEngine.Vector3 get_fromPos(); // 0x059aff4c
	static WizardGames.Soc.SocClient.Monument.MonumentEffectAction Generate(); // 0x059b00c0
	System.Boolean Executor(WizardGames.Soc.Common.Unity.Monument.MonumentActionParams actionParams, System.String& error); // 0x059b01cc
	System.Void Release(); // 0x059b05ac
	System.Boolean BaseCheck(UnityEngine.Vector3 fromPos, UnityEngine.Vector3 toPos); // 0x059b0828
	System.Void Update(); // 0x059b094c
	System.Void RemoveEffect(); // 0x059b061c
	System.Void .ctor(); // 0x059b0d4c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Monument.MonumentUIAction : WizardGames.Soc.Common.Unity.Monument.BaseMonumentAction
{
	System.Int32 errorLogCnt; // 0xb8
	System.Text.StringBuilder stringConnection; // 0xc0
	System.Int32 tipsId; // 0xc8
	System.Int32 tipsType; // 0xcc
	WizardGames.Soc.SocClient.Monument.MonumentUIAction.EUITypeEnum uiType; // 0xd0
	System.Int64 delayShowTime; // 0xd8
	WizardGames.Soc.Common.Entity.BoxEntity ownerEntity; // 0xe0
	WizardGames.Soc.SocClient.Go.ClientPasswordBoxGo ownerGo; // 0xe8
	System.Action OnUIUpdate; // 0xf0
	System.Int64 subscribeId; // 0xf8
	System.Boolean isAlive; // 0x100
	System.Boolean isWounded; // 0x101
	System.Boolean get_playerStateCheck(); // 0x059b0f34
	UnityEngine.Vector3 get_fromPos(); // 0x059b0fb0
	System.Void Init(WizardGames.Soc.Common.Unity.Monument.MonumentActionParams actionParams, WizardGames.Soc.Common.Data.MonumentEventDataBase dataBase); // 0x059b1124
	System.Void OnLifeCycleFlagsChange(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, System.Int32 oldValue, System.Int32 newValue); // 0x059b1330
	static WizardGames.Soc.SocClient.Monument.MonumentUIAction Generate(); // 0x059b14c8
	System.Boolean Executor(WizardGames.Soc.Common.Unity.Monument.MonumentActionParams actionParams, System.String& error); // 0x059b1590
	System.Void OnEntityCreate(WizardGames.Soc.Common.Entity.IEntity entity); // 0x059b1de8
	System.Void OnEntityRemove(WizardGames.Soc.Common.Entity.IEntity entity); // 0x059b1fbc
	System.Void OnGoRemove(System.Int64 id); // 0x059b20d0
	System.Void OnGoCreate(WizardGames.Soc.Common.Unity.Go.IEntityGo go); // 0x059b2230
	System.Void Update(); // 0x059b24a4
	System.Boolean BaseCheck(UnityEngine.Vector3 fromPos, UnityEngine.Vector3 toPos); // 0x059b2cfc
	System.Void ShowUI(); // 0x059b2624
	System.Void ShowStrongResumeTime(WizardGames.Soc.SocClient.Ui.ComOngoingTip tip); // 0x059b2e48
	System.Void ShowWeakResumeTime(WizardGames.Soc.SocClient.Ui.ComOngoingTip tip); // 0x059b3178
	System.Void Release(); // 0x059b34a8
	System.Void .ctor(); // 0x059b3a90
	System.Boolean <ShowUI>b__27_0(); // 0x059b3b00
	System.Boolean <ShowUI>b__27_1(); // 0x059b3b8c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Monument.MonumentUIAction.EUITypeEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Monument.MonumentUIAction.EUITypeEnum InValid = 0;
	static WizardGames.Soc.SocClient.Monument.MonumentUIAction.EUITypeEnum Weak = 1;
	static WizardGames.Soc.SocClient.Monument.MonumentUIAction.EUITypeEnum Strong = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Http.EHttpReqModule : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Http.EHttpReqModule Unknown = 0;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule SocHttpClient = 1;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule GM = 2;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule Lobby = 3;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule Login = 4;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule Hud = 5;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule Setting = 6;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule Chat = 7;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule MsgTip = 8;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule LobbyFriend = 9;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule GameTeam = 10;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule LobbyTeam = 11;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule TempFriend = 12;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule TeamFriend = 13;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule LobbySkin = 14;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule AntiAddiction = 15;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule Questionnaire = 16;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule Mail = 17;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule Map = 18;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule Guide = 19;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule Reputation = 20;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule ReputationReward = 21;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule RoleMain = 22;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule Recruit = 23;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule ChatRecruit = 24;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule ShareRecruit = 25;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule HistoryBattle = 26;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule ItemTips = 27;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule TeamInvite = 28;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule TeamHall = 29;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule VendingMachine = 30;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule SurvivalManual = 31;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule Rank = 32;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule AddFriend = 33;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule CreateRole = 34;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule ReputationLevelReward = 35;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule CoinList = 36;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule LobbyPlayerInfo = 37;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule ServerList = 38;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule LobbyShop = 39;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule DeleteHistoryBattle = 40;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule GameModeSelect = 41;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule SurprisePlay = 42;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule Report = 43;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule QQAchievement = 44;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule GameVoice = 45;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule PlayerInfoCard = 46;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule Respawn = 47;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule DeadInfo = 48;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule NewbieLevel = 49;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule CheckGameState = 50;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule MarkerTeammate = 51;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule MarkerHUD = 52;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule ACEData = 53;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule ACEHearBeat = 54;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule LobbyStash = 55;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule Tribe = 56;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule CommonInvite = 57;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule CommonShare = 58;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule TechTree = 59;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule Mall = 60;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule RedDot = 61;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule MainQuest = 62;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule Talent = 63;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule BattleReport = 64;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule PlayerBlueprint = 65;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule AppPush = 66;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule BattlePass = 67;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule ConstructionHarmonyPhoto = 68;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule TerritoryCenterPermission = 69;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule SleepingBag = 70;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule ChangeContainerName = 71;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule Medal = 72;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule Season = 73;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule FriendGift = 74;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule Lottery = 75;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule InviteCode = 76;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule Construction = 77;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule CommunityCardJoinBattle = 78;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule Union = 79;
	static WizardGames.Soc.SocClient.Http.EHttpReqModule LobbyModifyPerfence = 80;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Http.SocHttpReq : System.Object
{
	System.String Url; // 0x10
	System.Boolean IsPost; // 0x18
	System.Boolean IsLogin; // 0x19
	WizardGames.Soc.SocClient.Http.EHttpReqModule Module; // 0x1c
	System.Boolean DisposeAfterFinish; // 0x20
	SimpleJSON.JSONObject PostParam; // 0x28
	System.Action<SimpleJSON.JSONNode> OnSuccess; // 0x30
	System.Action<SimpleJSON.JSONNode> OnError; // 0x38
	System.Boolean ShowErrorPop; // 0x40
	System.Boolean KeyLog; // 0x41
	UnityEngine.Networking.UnityWebRequest ReqClient; // 0x48
	System.Void .ctor(); // 0x059b3c18
}

// Client.Runtime
class WizardGames.Soc.SocClient.Http.SocHttpClient : System.Object
{
	static SocLogger logger; // 0x0
	static System.Collections.Concurrent.ConcurrentQueue<WizardGames.Soc.SocClient.Http.SocHttpReq> reqQueue; // 0x8
	static System.Text.StringBuilder urlBuilder; // 0x10
	static System.Threading.CancellationTokenSource consumeCts; // 0x18
	static System.String BearerToken; // 0x20
	static System.Boolean isRequesting; // 0x28
	static System.Boolean get_IsReqValid(); // 0x059b3c88
	static System.Int32 get_WaitingReqCount(); // 0x059b3d48
	static System.Void Create(System.String token); // 0x059b3df0
	static System.Void OnDispose(); // 0x059b4138
	static System.Void SetToken(System.String token); // 0x059b4034
	static System.Void Dispose(System.String logoutPath, System.Action<SimpleJSON.JSONNode> onLogout); // 0x059b4258
	static System.Void AddReq(WizardGames.Soc.SocClient.Http.SocHttpReq req); // 0x059b4488
	static System.Void CallReqOnError(WizardGames.Soc.SocClient.Http.SocHttpReq req, SimpleJSON.JSONNode ret); // 0x059b483c
	static System.Void CallReqOnSuccess(WizardGames.Soc.SocClient.Http.SocHttpReq req, SimpleJSON.JSONNode ret); // 0x059b49fc
	static System.Void DealReq(); // 0x054fd168
	static System.String ContactURLParams(System.String path, System.Collections.Generic.IDictionary<System.String,System.String> param); // 0x059b4bbc
	static System.String ContactURLParams(System.String path, System.String key, System.Collections.Generic.IList<System.String> param); // 0x059b5130
	static System.String ContactURLParams(System.String path, System.Collections.Generic.Dictionary<System.String,System.String> param, System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.String>> arraryParam); // 0x059b5690
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
class WizardGames.Soc.SocClient.Http.SocHttpClient.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Http.SocHttpClient.<>c <>9; // 0x0
	static System.Action <>9__10_0; // 0x8
	static System.Void .cctor(); // 0x059b5dd4
	System.Void .ctor(); // 0x059b5e38
	System.Void <Create>b__10_0(); // 0x059b5ea0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Http.SocHttpClient.<>c__DisplayClass15_0 : System.Object
{
	WizardGames.Soc.SocClient.Http.SocHttpReq req; // 0x10
	SimpleJSON.JSONNode ret; // 0x18
	System.Void .ctor(); // 0x059b4994
	System.Void <CallReqOnError>b__0(); // 0x059b5f54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Http.SocHttpClient.<>c__DisplayClass16_0 : System.Object
{
	WizardGames.Soc.SocClient.Http.SocHttpReq req; // 0x10
	SimpleJSON.JSONNode ret; // 0x18
	System.Void .ctor(); // 0x059b4b54
	System.Void <CallReqOnSuccess>b__0(); // 0x059b5fd8
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Http.SocHttpClient.<DealReq>d__18 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Http.SocHttpReq <req>5__2; // 0x38
	Assets.Scripts.MicroServiceClient.MicroServiceClient <msClient>5__3; // 0x40
	System.String <strModule>5__4; // 0x48
	System.Threading.Tasks.Task <reqTimeoutTask>5__5; // 0x50
	UnityEngine.Networking.UnityWebRequestAsyncOperation <operation>5__6; // 0x58
	System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1; // 0x60
	System.Void MoveNext(); // 0x055049cc
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconDownloader : System.Object
{
	System.Int32 _timeout; // 0x10
	System.Int32 _failedTryAgain; // 0x14
	WizardGames.Soc.SocClient.PlatformPlayerInfo.IWebRequester _requester; // 0x18
	WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconDownloader.ESteps _steps; // 0x20
	WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconDownloader.EStatus _status; // 0x24
	System.String _lastestNetError; // 0x28
	System.Int64 _lastestHttpCode; // 0x30
	System.String _requestURL; // 0x38
	System.Boolean _isAbort; // 0x40
	System.UInt64 _latestDownloadBytes; // 0x48
	System.Single _latestDownloadRealtime; // 0x50
	System.Single _tryAgainTimer; // 0x54
	System.Single <DownloadProgress>k__BackingField; // 0x58
	System.UInt64 <DownloadedBytes>k__BackingField; // 0x60
	System.Void set_DownloadProgress(System.Single value); // 0x059b6e7c
	System.Void set_DownloadedBytes(System.UInt64 value); // 0x059b6ef4
	System.UInt64 get_DownloadedBytes(); // 0x059b6f6c
	System.Void .ctor(System.String url, System.Int32 failedTryAgain, System.Int32 timeout); // 0x059b6fd0
	System.Void SendRequest(System.Object[] args); // 0x059b70ac
	System.Void Update(); // 0x059b7130
	System.Void Abort(); // 0x059b79f8
	System.Boolean IsDone(); // 0x059b776c
	System.Boolean HasError(); // 0x059b7b10
	System.String GetLastError(); // 0x059b7b7c
	System.Void CheckTimeout(); // 0x059b7844
	UnityEngine.Texture2D GetTexture2D(); // 0x059b7c44
}

// Client.Runtime
enum WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconDownloader.EStatus : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconDownloader.EStatus None = 0;
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconDownloader.EStatus Succeed = 1;
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconDownloader.EStatus Failed = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconDownloader.ESteps : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconDownloader.ESteps None = 0;
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconDownloader.ESteps PrepareDownload = 1;
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconDownloader.ESteps CreateDownloader = 2;
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconDownloader.ESteps CheckDownload = 3;
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconDownloader.ESteps TryAgain = 4;
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconDownloader.ESteps Done = 5;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconHandle : System.Object
{
	WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconProvider <Provider>k__BackingField; // 0x10
	System.Action<WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconHandle> _callback; // 0x18
	UnityEngine.Texture2D get_Texture2D(); // 0x059b7d10
	System.Void set_Provider(WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconProvider value); // 0x059b7f60
	WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconProvider get_Provider(); // 0x059b7fe0
	System.Void .ctor(WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconProvider provider); // 0x059b8044
	System.Void InvokeCallback(); // 0x059b8104
	System.Void add_Completed(System.Action<WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconHandle> value); // 0x059b8190
	System.Void remove_Completed(System.Action<WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconHandle> value); // 0x059b83fc
	System.Boolean get_IsValidWithWarning(); // 0x059b7e10
	System.Void ReleaseInternal(); // 0x059b84fc
	System.Boolean get_IsValid(); // 0x059b87ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconLoader : System.Object
{
	System.Int32 <RefCount>k__BackingField; // 0x10
	System.String <Url>k__BackingField; // 0x18
	System.String <RoleId>k__BackingField; // 0x20
	WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconLoader.EStatus <Status>k__BackingField; // 0x28
	System.String <LastError>k__BackingField; // 0x30
	System.Boolean <IsDestroyed>k__BackingField; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconProvider> _providers; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconProvider> _removeList; // 0x48
	System.Boolean <IsForceDestroyComplete>k__BackingField; // 0x50
	WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconLoader.ESteps _steps; // 0x54
	WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconDownloader _downloader; // 0x58
	System.Void set_RefCount(System.Int32 value); // 0x059b88fc
	System.Int32 get_RefCount(); // 0x059b8974
	System.Void set_Url(System.String value); // 0x059b89d8
	System.String get_Url(); // 0x059b8a58
	System.Void set_RoleId(System.String value); // 0x059b8abc
	System.String get_RoleId(); // 0x059b8b3c
	System.Void set_Status(WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconLoader.EStatus value); // 0x059b8ba0
	WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconLoader.EStatus get_Status(); // 0x059b8c18
	System.Void set_LastError(System.String value); // 0x059b8c7c
	System.String get_LastError(); // 0x059b8cfc
	System.Void set_IsDestroyed(System.Boolean value); // 0x059b8d60
	System.Void set_IsForceDestroyComplete(System.Boolean value); // 0x059b8ddc
	System.Void .ctor(System.String roleId, System.String url); // 0x059b8e58
	System.Void Release(); // 0x059b90b8
	System.Boolean IsDone(); // 0x059b91b4
	System.Void Update(); // 0x059b92a8
	UnityEngine.Texture2D GetTexture2D(); // 0x059b9758
	System.Void Destroy(); // 0x059b97c4
	System.Void ForceDestroyComplete(); // 0x059b98d4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconLoader.EStatus : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconLoader.EStatus None = 0;
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconLoader.EStatus Succeed = 1;
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconLoader.EStatus Failed = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconLoader.ESteps : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconLoader.ESteps None = 0;
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconLoader.ESteps Download = 1;
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconLoader.ESteps CheckDownload = 2;
	static WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconLoader.ESteps Done = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconProvider : System.Object, System.Collections.IEnumerator
{
	System.Action<WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconProvider> _callback; // 0x10
	System.Boolean IsFinish; // 0x18
	WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconProvider.EOperationStatus <Status>k__BackingField; // 0x1c
	System.String <Error>k__BackingField; // 0x20
	System.Single <Progress>k__BackingField; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconHandle> _handles; // 0x30
	System.Int32 <RefCount>k__BackingField; // 0x38
	WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconLoader <OwnerIcon>k__BackingField; // 0x40
	System.String <RoleId>k__BackingField; // 0x48
	System.Boolean <IsDestroyed>k__BackingField; // 0x50
	UnityEngine.Texture2D <Texture2D>k__BackingField; // 0x58
	System.Boolean <IsForceDestroyComplete>k__BackingField; // 0x60
	WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconProvider.ESteps _steps; // 0x64
	System.Threading.Tasks.TaskCompletionSource<System.Object> _taskCompletionSource; // 0x68
	WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconProvider.EOperationStatus get_Status(); // 0x059b9988
	System.Void set_Status(WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconProvider.EOperationStatus value); // 0x059b99ec
	System.Void set_Error(System.String value); // 0x059b9a64
	System.Void set_Progress(System.Single value); // 0x059b9ae4
	System.Void set_RefCount(System.Int32 value); // 0x059b9b5c
	System.Int32 get_RefCount(); // 0x059b9bd4
	System.Void set_OwnerIcon(WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconLoader value); // 0x059b9c38
	WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconLoader get_OwnerIcon(); // 0x059b9cb8
	System.Void set_RoleId(System.String value); // 0x059b9d1c
	System.String get_RoleId(); // 0x059b9d9c
	System.Void set_IsDestroyed(System.Boolean value); // 0x059b9e00
	System.Boolean get_IsDestroyed(); // 0x059b9e7c
	System.Void set_Texture2D(UnityEngine.Texture2D value); // 0x059b9ee0
	UnityEngine.Texture2D get_Texture2D(); // 0x059b9f60
	System.Void set_IsForceDestroyComplete(System.Boolean value); // 0x059b9fc4
	System.Boolean get_IsDone(); // 0x059b8300
	System.Void .ctor(System.String roleId, System.String url); // 0x059ba040
	System.Void ReleaseAllHandles(); // 0x059ba378
	System.Void ForceDestroyComplete(); // 0x059ba438
	System.Void SetStart(); // 0x059ba4ec
	System.Void SetFinish(); // 0x059ba5a0
	System.Void OnUpdate(); // 0x059ba6a0
	System.Void InvokeCompletion(System.String error, WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconProvider.EOperationStatus status); // 0x059ba994
	WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconHandle CreateHandle(); // 0x059bac20
	System.Void ReleaseHandle(WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconHandle handle); // 0x059b8624
	System.Void Destroy(); // 0x059badc0
	System.Boolean System.Collections.IEnumerator.MoveNext(); // 0x059bb034
	System.Void System.Collections.IEnumerator.Reset(); // 0x059bb0a4
