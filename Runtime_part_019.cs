}

// Client.Runtime
struct WizardGames.Soc.SocClient.PerfSightPlayerSettings : System.ValueType
{
	System.String AppId; // 0x10
	System.String ReportUrl; // 0x18
	System.Int32 SendIntervalMinutes; // 0x20
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.EHudState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.EHudState WakeUp = 100;
	static WizardGames.Soc.SocClient.EHudState BuildEmptyHand = 201;
	static WizardGames.Soc.SocClient.EHudState BuildCore = 202;
	static WizardGames.Soc.SocClient.EHudState BuildDeviceDeploy = 203;
	static WizardGames.Soc.SocClient.EHudState BuildBlueprint = 204;
	static WizardGames.Soc.SocClient.EHudState BuildChristmasLights = 205;
	static WizardGames.Soc.SocClient.EHudState BuildEdit = 206;
	static WizardGames.Soc.SocClient.EHudState BuildDeviceConnection = 207;
	static WizardGames.Soc.SocClient.EHudState BuildElectricStorage = 208;
	static WizardGames.Soc.SocClient.EHudState BuildDeployCommon = 209;
	static WizardGames.Soc.SocClient.EHudState BuildShortcutDeviceDeploy = 210;
	static WizardGames.Soc.SocClient.EHudState BuildShortcutChristmasLights = 211;
	static WizardGames.Soc.SocClient.EHudState BuildChangeSkin = 212;
	static WizardGames.Soc.SocClient.EHudState BuildCampingTentDeploy = 213;
	static WizardGames.Soc.SocClient.EHudState BuildEmptyHandPie = 219;
	static WizardGames.Soc.SocClient.EHudState BuildCorePie = 220;
	static WizardGames.Soc.SocClient.EHudState BuildDeviceDeployPie = 221;
	static WizardGames.Soc.SocClient.EHudState BuildBlueprintPie = 222;
	static WizardGames.Soc.SocClient.EHudState BuildChristmasLightsPie = 223;
	static WizardGames.Soc.SocClient.EHudState BuildEditPie = 224;
	static WizardGames.Soc.SocClient.EHudState BuildDeviceConnectionPie = 225;
	static WizardGames.Soc.SocClient.EHudState ActionOpenMirror = 301;
	static WizardGames.Soc.SocClient.EHudState ActionOpenTeleScope = 302;
	static WizardGames.Soc.SocClient.EHudState ActionSwim = 303;
	static WizardGames.Soc.SocClient.EHudState ActionZipline = 304;
	static WizardGames.Soc.SocClient.EHudState ActionAidSelf = 305;
	static WizardGames.Soc.SocClient.EHudState ActionAidOther = 306;
	static WizardGames.Soc.SocClient.EHudState ActionTeam = 307;
	static WizardGames.Soc.SocClient.EHudState StatusCrawl = 308;
	static WizardGames.Soc.SocClient.EHudState StatusIncap = 309;
	static WizardGames.Soc.SocClient.EHudState StatusDead = 310;
	static WizardGames.Soc.SocClient.EHudState Vehicle = 400;
	static WizardGames.Soc.SocClient.EHudState VehicleKayak = 401;
	static WizardGames.Soc.SocClient.EHudState HeldItem = 500;
	static WizardGames.Soc.SocClient.EHudState ObserverMode = 600;
	static WizardGames.Soc.SocClient.EHudState ReviewPackage = 601;
	static WizardGames.Soc.SocClient.EHudState PhotoMode = 602;
	static WizardGames.Soc.SocClient.EHudState PhotoModeMove = 603;
	static WizardGames.Soc.SocClient.EHudState PhotoModeHideAll = 604;
	static WizardGames.Soc.SocClient.EHudState ConstructionReportPhotoMode = 605;
	static WizardGames.Soc.SocClient.EHudState Newbie = 700;
	static WizardGames.Soc.SocClient.EHudState TeamMainQuestUnComplete = 701;
	static WizardGames.Soc.SocClient.EHudState AnchorModeFreePerspective = 702;
	static WizardGames.Soc.SocClient.EHudState AnchorModeFirstPerspective = 703;
	static WizardGames.Soc.SocClient.EHudState AnchorModeThirdPerspective = 704;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrHud : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger <Logger>k__BackingField; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.EHudState> setHudState; // 0x18
	System.Collections.Generic.List<System.Int32> setElemsToShow; // 0x20
	System.Collections.Generic.HashSet<System.Int32> allShowElems; // 0x28
	System.Collections.Generic.HashSet<System.Int32> allHideElems; // 0x30
	System.Collections.Generic.HashSet<System.Int32> setElemsToHideArea; // 0x38
	FairyGUI.GGraph GM_hideArea; // 0x40
	System.Int64 lastestHeldItemEntityId; // 0x48
	System.Boolean needToRefreshData; // 0x50
	System.Boolean showDirection; // 0x51
	static SocLogger get_Logger(); // 0x0770fe40
	System.Void Init(); // 0x0770fec8
	System.Threading.Tasks.Task OnEnterWorld(); // 0x054e7844
	System.Threading.Tasks.Task OnExitWorld(); // 0x054e7844
	System.Void RefreshHudData(); // 0x07711d2c
	System.Void ProcessHeldItemData(System.Collections.Generic.HashSet<System.Int32> tempShow, System.Collections.Generic.HashSet<System.Int32> tempHide); // 0x077124f0
	System.Void ProcessVehicleData(System.Collections.Generic.HashSet<System.Int32> tempShow, System.Collections.Generic.HashSet<System.Int32> tempHide); // 0x07712120
	System.Void ProcessNewbieData(System.Collections.Generic.HashSet<System.Int32> tempShow, System.Collections.Generic.HashSet<System.Int32> tempHide); // 0x07713028
	System.Void AttachState(WizardGames.Soc.SocClient.EHudState state); // 0x07710db8
	System.Void DetachState(WizardGames.Soc.SocClient.EHudState state); // 0x07713624
	System.Int64 GetVehicleTableId(System.Int64 mountableId); // 0x07713420
	System.Void OnSwitchHeldItemSuccess(System.Int64 oldHeldItemEntityId, System.Int64 newHeldItemEntityId); // 0x0771391c
	System.Void OnSeatChanged(System.Boolean isDriver, System.Int64 montableId); // 0x07713d74
	System.Void OnMountableChanged(System.Int64 montableId); // 0x07713f38
	System.Boolean CheckKayak(); // 0x07713ac0
	System.Void PoseDiveLeave(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x07714060
	System.Void OnEnterSwim(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x0771419c
	System.Void OnLeaveSwim(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x077142c0
	System.Void OnCharacterAdsStateChange(System.Int64 entityId, WizardGames.Soc.Common.Entity.PlayerAdsStateEnum oldState, WizardGames.Soc.Common.Entity.PlayerAdsStateEnum newState); // 0x077143e4
	System.Void OnTeleScopeStateChange(System.Boolean isOpen); // 0x077144d4
	System.Void OnDeadEnter(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x07714564
	System.Void OnDeadLeave(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x077146b8
	System.Void OnTeamMemberChange(WizardGames.Soc.Share.Framework.ECustomDictOpType changeType, System.UInt64 roleId, WizardGames.Soc.Common.CustomType.TeamMemberInfo oldMember); // 0x077147e8
	System.Void OnTeamMemberCleanUp(); // 0x07714948
	System.Void MissionChange(); // 0x077149b0
	System.Void BeforePhotoModeEnter(); // 0x07714a68
	System.Void AfterPhotoModeExit(); // 0x07714adc
	System.Void OnConstructionReportPhotoModeEntered(); // 0x07714b50
	System.Void OnConstructionReportPhotoModeExited(); // 0x07714bc4
	System.Void OnPhotoShowVehicleHud(); // 0x07714c38
	System.Void OnPhotoHideVehicleHud(); // 0x07714d4c
	System.Void OnPhotoHideAllUI(System.Boolean isHide); // 0x07714e60
	System.Void OnMainQuestMissionChanged(); // 0x07714ef0
	System.Collections.Generic.List<System.Int32> GetDisplayElems(); // 0x07714fb4
	System.Collections.Generic.HashSet<System.Int32> GetAllHidedElems(); // 0x07715018
	System.Collections.Generic.HashSet<System.Int32> GetHidedAreaElems(); // 0x0771507c
	System.Collections.Generic.List<WizardGames.Soc.SocClient.EHudState> CurrentActiveStates(); // 0x077150e0
	System.Void FillCurrentActiveStates(System.Collections.Generic.List<WizardGames.Soc.SocClient.EHudState> output); // 0x07715144
	System.Void OnUiShowAnimFinishEvent(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x0771533c
	System.Void OnUiHide(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x07715a68
	System.Void OnOnCameraStateChange(WizardGames.Soc.Common.Unity.CameraState lastCameraState, WizardGames.Soc.Common.Unity.CameraState nowCameraState); // 0x07715dac
	System.Void OnAnchorModeFreePerspective(); // 0x0771608c
	System.Void OnAnchorModeFirstPerspective(); // 0x07715e9c
	System.Void OnAnchorModeThirdPerspective(); // 0x07715f94
	System.Void OnFps30Update(); // 0x07716184
	System.Void ProcessNormalData(WizardGames.Soc.SocClient.EHudState state, System.Collections.Generic.HashSet<System.Int32> tempShow, System.Collections.Generic.HashSet<System.Int32> tempHide); // 0x07712d08
	System.Void SetHideArea(UnityEngine.Rect globalRectArea); // 0x07715464
	System.Void ResumeHideArea(); // 0x07715b04
	System.Void .ctor(); // 0x077162c8
	static System.Void .cctor(); // 0x07716474
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrHud.<>c__DisplayClass14_0 : System.Object
{
	System.Int32 time; // 0x10
	System.Int64 timerId; // 0x18
	WizardGames.Soc.SocClient.MgrHud <>4__this; // 0x20
	System.Void .ctor(); // 0x077168b8
	System.Void <OnEnterWorld>b__0(System.Int64 id, System.Object data, System.Boolean delete); // 0x07716920
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrHud.<>c__DisplayClass60_0 : System.Object
{
	UnityEngine.Rect globalRectArea; // 0x10
	WizardGames.Soc.SocClient.MgrHud <>4__this; // 0x20
	System.Void .ctor(); // 0x07716ba0
	System.Boolean <SetHideArea>b__0(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x07716c08
	System.Void <SetHideArea>b__1(WizardGames.Soc.Common.Unity.Ui.UiEditableElem trueElem); // 0x07716f94
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrHudCommon : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger <Logger>k__BackingField; // 0x0
	static SocLogger get_Logger(); // 0x07717088
	System.Void Init(); // 0x07717110
	System.Void ShowCountDown(System.Int32 msCountdown, System.String tips, FairyGUI.EventCallback0 onFinish, FairyGUI.EventCallback0 onClickCancel, FairyGUI.EventCallback0 onAbort, System.String iconUrl, System.Boolean autoHideWhenCancel); // 0x07717178
	System.Void AbortCountDown(); // 0x0771762c
	FairyGUI.GObject GetTipPlaceholderSmall(); // 0x07717770
	FairyGUI.GObject GetTipPlaceholderBig(); // 0x07717830
	System.Void .ctor(); // 0x077178f0
	static System.Void .cctor(); // 0x07717958
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrHudCommon.<>c__DisplayClass5_0 : System.Object
{
	FairyGUI.EventCallback0 onFinish; // 0x10
	WizardGames.Soc.SocClient.Ui.UiHudElemCountDown elem; // 0x18
	FairyGUI.EventCallback0 onClickCancel; // 0x20
	System.Boolean autoHideWhenCancel; // 0x28
	FairyGUI.EventCallback0 onAbort; // 0x30
	System.Void .ctor(); // 0x077175c4
	System.Void <ShowCountDown>b__0(); // 0x07717a2c
	System.Void <ShowCountDown>b__1(); // 0x07717b84
	System.Void <ShowCountDown>b__2(); // 0x07717cf0
}

// Client.Runtime
class WizardGames.Soc.SocClient.CtShareMessageCardFactory : System.Object
{
	
	static WizardGames.Soc.SocClient.Ui.IComChatShare CreateShareMessageCard(WizardGames.Soc.Common.Data.EChatShareTemplate ctrlType, WizardGames.Soc.SocClient.Ui.Binder.GameChat.ChatMainMessageBinder binder); // 0x07717e48
}

// Client.Runtime
class WizardGames.Soc.SocClient.MgrInventory : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger <Log>k__BackingField; // 0x0
	System.Single inventoryMainShowDiscardDargDistanceX; // 0x14
	System.Single inventoryMainShowDiscardDargDistanceY; // 0x18
	System.Single inventoryPcTipsExactPositionOffestX; // 0x1c
	System.Single inventoryPcTipsExactPositionOffestY; // 0x20
	UnityEngine.Vector2 inventoryFireUiShowDropAreaDragStartPos; // 0x24
	SOC.TA.PostProcessEffectController postProcessEffectController; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> getDeadPlayerItemsByCollectionIdRes; // 0x38
	System.Collections.Generic.List<System.Int64> inventoryPickDataIdList; // 0x40
	static System.Single[] get_inventoryPcMainShowDiscardDargDistance(); // 0x07717fdc
	static System.Single[] get_inventoryPcTipsExactPositionOffest(); // 0x077180bc
	System.Void SetBlurredSceneActiveState(System.Boolean isActive, UnityEngine.Camera camPlayerModel); // 0x0771819c
	System.Boolean IsOpenInventoryView(); // 0x077182fc
	System.Void .ctor(); // 0x077183e4
	static System.Void .cctor(); // 0x077185b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.ClientPlayerPrefs : System.Object
{
	static SocLogger logger; // 0x0
	static System.String GetUserKey(System.String oriKey); // 0x07718684
	static System.Void SetInt(System.String key, System.Int32 value, System.Boolean isCommon); // 0x0771889c
	static System.Int32 GetInt(System.String key, System.Int32 defaultValue, System.Boolean isCommon); // 0x07718978
	static System.Int32 GetInt(System.String key, System.Boolean isCommon); // 0x07718a58
	static System.Void SetString(System.String key, System.String value, System.Boolean isCommon); // 0x07718b2c
	static System.String GetString(System.String key, System.String defaultValue, System.Boolean isCommon); // 0x07718c08
	static System.String GetString(System.String key, System.Boolean isCommon); // 0x07718d04
	static System.Boolean HasKey(System.String key, System.Boolean isCommon); // 0x07718df4
	static System.Void DeleteKey(System.String key, System.Boolean isCommon); // 0x07718ec8
	static System.Void Save(); // 0x07718f98
	static System.Void .cctor(); // 0x07718ff4
}

// Client.Runtime
class WizardGames.Soc.SocClient.WorldResource.MgrGatherItemPickable : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> blackTimeDic; // 0x18
	System.Collections.Generic.List<System.Int64> removeKeyList; // 0x20
	System.Int64 pickSameItemTipEndTime; // 0x28
	System.Boolean isAutoPickSetting; // 0x30
	System.Boolean isClosePickSetting; // 0x31
	System.Boolean isDiePickAtTopSetting; // 0x32
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> autoPickSettingDic; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,System.Boolean> corpseCollectionIdDic; // 0x40
	System.Collections.Generic.List<System.Int64> corpseCollectionIdOrderList; // 0x48
	System.Collections.Generic.List<System.Int64> curCorpseCollectionIdList; // 0x50
	System.Collections.Generic.List<System.Int64> removeCorpseCollectionIdList; // 0x58
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.CorpseEntity> corpseEntitiesList; // 0x60
	static SocLogger Log; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.Share.Framework.IPositionEntity> tempEntitiesListForSort; // 0x68
	static System.Collections.Generic.IComparer<WizardGames.Soc.Share.Framework.IPositionEntity> DistanceComparer; // 0x8
	System.Single PickableDownwards; // 0x70
	System.Collections.Generic.List<System.Int64> deadPlayerCollectionIdOrderList; // 0x78
	System.Collections.Generic.Dictionary<System.Int64,System.Boolean> deadPlayerCollectionExistDic; // 0x80
	System.Boolean isOpenSceneItemList; // 0x88
	System.Boolean isUiOthersideNearByOpen; // 0x89
	System.Boolean isInventoryFull; // 0x8a
	UnityEngine.Vector3 myPlayerPosition; // 0x8c
	System.Int64 autoPickTime; // 0x98
	System.Int64 lastPickItemNodeId; // 0xa0
	System.Int32 curPickableItemCount; // 0xa8
	System.Action PickableItemCountChangeAction; // 0xb0
	System.Boolean isOpenListBefore; // 0xb8
	System.Boolean curNotInAnyBuildMode; // 0xb9
	System.Boolean isNeedRestore; // 0xba
	System.Int32 frameIndex; // 0xbc
	System.Action SceneItemViewSwitchAction; // 0xc0
	System.Boolean dataChangeRefreshSwitch; // 0xc8
	System.Int32 baseFrameIndex; // 0xcc
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> oldNodeIdToEntityIdDic; // 0xd0
	System.Collections.Generic.HashSet<WizardGames.Soc.Common.CustomType.BaseItemNode> oldPickableItems; // 0xd8
	System.Collections.Generic.HashSet<WizardGames.Soc.Common.CustomType.BaseItemNode> oldInteractPickItems; // 0xe0
	System.Collections.Generic.HashSet<System.Int64> oldCurCorpseCollectionIdList; // 0xe8
	System.Collections.Generic.HashSet<System.Int64> oldCurRewardBoxCollectionIdList; // 0xf0
	System.Boolean <NeedShowInventoryErrorTip>k__BackingField; // 0xf8
	System.Single _playerX; // 0xfc
	System.Single _playerY; // 0x100
	System.Single _playerZ; // 0x104
	System.Single _orginPlayerY; // 0x108
	System.Int32 NEAREST_BOX_COUNT; // 0x10c
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.BoxEntity> nearestBoxList; // 0x110
	System.Collections.Generic.HashSet<System.Int64> currentOperateBoxEntityIdSet; // 0x118
	System.Int64 lastReportTime; // 0x120
	System.Boolean lastReportEmpty; // 0x128
	System.Collections.Generic.HashSet<System.Int64> reportBoxList; // 0x130
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> pickItemLimit; // 0x138
	static System.Int32 ITEM_TYPE_MISC_POI_TASK; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> otherItemsNodeList; // 0x140
	System.Int64 currentLootEntityId; // 0x148
	System.String <LootingName>k__BackingField; // 0x150
	System.Func<WizardGames.Soc.Common.CustomType.ItemContainerNode,System.Boolean> <FilterProcess>k__BackingField; // 0x158
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.SceneItemEntity> sceneItemEntitiesList; // 0x160
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.CollectableEntity> collectableEntitiesList; // 0x168
	System.Collections.Generic.HashSet<System.Int64> collectableIdSet; // 0x170
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.ThrownEntity> thrownItemEntitiesList; // 0x178
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> nodeIdToEntityIdDic; // 0x180
	System.Collections.Generic.List<System.Int64> pickableEntityIdsList; // 0x188
	System.Int64 ClosestCollectableEntityId; // 0x190
	System.Collections.Generic.HashSet<System.Int64> pickableItemsSet; // 0x198
	System.Collections.Generic.HashSet<System.Int64> pickableItemsSetOld; // 0x1a0
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> pickableItems; // 0x1a8
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> interactPickItems; // 0x1b0
	System.Boolean ForceUpdatePickNextFrame; // 0x1b8
	WizardGames.Soc.SocClient.WorldResource.MgrGatherItemPickable.EntityData[] _entityBuffer; // 0x1c0
	System.Collections.Generic.List<System.Int64> _validEntities; // 0x1c8
	System.Single _nearestCollectableDist; // 0x1d0
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.BoxEntity> rewardBoxEntitiesList; // 0x1d8
	System.Collections.Generic.Dictionary<System.Int64,System.Boolean> rewardBoxCollectionIdDic; // 0x1e0
	System.Collections.Generic.List<System.Int64> rewardBoxDecorationCollectionIdOrderList; // 0x1e8
	System.Collections.Generic.List<System.Int64> rewardBoxCorpseCollectionIdOrderList; // 0x1f0
	System.Collections.Generic.List<System.Int64> curRewardBoxCollectionIdList; // 0x1f8
	System.Collections.Generic.List<System.Int64> removeRewardBoxCollectionIdList; // 0x200
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.BoxEntity> tempRangeInteractiveEntitiesList; // 0x208
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.BoxEntity> canRangeInteractiveBoxList; // 0x210
	System.String <RangeInteractiveBoxName>k__BackingField; // 0x218
	System.Collections.Generic.HashSet<System.Int64> rewardBoxIdSet; // 0x220
	System.Void ClearBlackListHandle(); // 0x077190c8
	System.Void UpdateBlackListHandle(); // 0x07719170
	System.Void AddToBlackList(System.Int64 itemTemplateId); // 0x07719550
	System.Boolean IsInBlackList(System.Int64 itemTemplateId); // 0x07719878
	System.Void OnEnterWorldSettingHandle(); // 0x077198f0
	System.Void OnExitWorldSettingHandle(); // 0x0771a184
	System.Void OnAutoPickSettingChange(System.Boolean isAutoPick); // 0x0771a3c0
	System.Void OnClosePickSettingChange(System.Boolean isClosePick); // 0x0771a43c
	System.Void OnDiePickAtTopSettingChange(System.Boolean isDiePickAtTop); // 0x0771a4b8
	System.Void OnPickUpSettingChange(System.Int32 typeId, System.Boolean autoPick); // 0x0771a534
	System.Void SetAutoPickSetting(System.Boolean isAutoPick); // 0x0771a618
	System.Boolean CheckAutoPick(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x0771a73c
	System.Void ClearCorpseHandle(); // 0x0771a8d4
	System.Void OnEnterWorldCorpseHandle(); // 0x0771a9a4
	System.Void OnExitWorldCorpseHandle(); // 0x0771aab0
	System.Void GetPlayerNearbyCorpseCollectionList(UnityEngine.Vector3 myPlayerPos, System.Single rangeDis, System.Single rangeDisUpY, System.Single rangeDisDownY); // 0x0771abbc
	System.Void OnRequestSubscribeAckCorpseHandle(System.Int64 entityId, System.Boolean success); // 0x0771baf8
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> get_PickableItems(); // 0x0771bc20
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> get_InteractPickItems(); // 0x0771bc84
	System.Collections.Generic.List<System.Int64> get_RewardBoxDecorationCollectionIdOrderList(); // 0x0771bce8
	System.Collections.Generic.Dictionary<System.Int64,System.Boolean> get_CorpseCollectionIdDic(); // 0x0771bd4c
	System.Collections.Generic.List<System.Int64> get_CorpseCollectionIdOrderList(); // 0x0771bdb0
	System.Collections.Generic.Dictionary<System.Int64,System.Boolean> get_RewardBoxCollectionIdDic(); // 0x0771be14
	System.Collections.Generic.List<System.Int64> get_RewardBoxCorpseCollectionIdOrderList(); // 0x0771be78
	System.Collections.Generic.List<System.Int64> get_DeadPlayerCollectionIdOrderList(); // 0x0771bedc
	System.Boolean get_IsAutoPickSetting(); // 0x0771bf40
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> get_AutoPickSettingDic(); // 0x0771bfa4
	System.Boolean get_IsOpenSceneItemList(); // 0x0771c008
	System.Void set_IsOpenSceneItemList(System.Boolean value); // 0x0771c06c
	System.Boolean get_IsUiOthersideNearByOpen(); // 0x0771c10c
	System.Int64 get_AutoPickTime(); // 0x0771c170
	System.Void set_AutoPickTime(System.Int64 value); // 0x0771c1d4
	System.Single get_PickableUpwardDetection(); // 0x0771c24c
	System.Single get_PickableParallelDetection(); // 0x0771c334
	System.Boolean get_IsInteractPick(); // 0x0771c41c
	System.Int32 get_FrameIndex(); // 0x0771c480
	System.Boolean get_NeedShowInventoryErrorTip(); // 0x0771c4e4
	System.Void set_NeedShowInventoryErrorTip(System.Boolean value); // 0x0771c548
	WizardGames.Soc.Common.Entity.PlayerEntity get_myPlayer(); // 0x0771c5c4
	WizardGames.Soc.Common.Component.PlayerPickUpComponent get_PickUpComponent(); // 0x0771c660
	System.Void Init(); // 0x0771c6f4
	System.Void CleanUp(); // 0x0771c764
	System.Threading.Tasks.Task OnEnterWorld(); // 0x0771cd08
	System.Threading.Tasks.Task OnExitWorld(); // 0x0771d30c
	System.Void Fps30Update(System.Int32 timeSinceLastUpdate); // 0x0771d69c
	System.Boolean PlayerStateCheck(); // 0x0771da2c
	System.Void ComparePickableData(); // 0x0771dcbc
	System.Void GetNearestKEntitiesInRange(UnityEngine.Vector3 pos, System.Single rangeDis, System.Single rangeDisUpY, System.Single rangeDisDownY); // 0x0771e934
	System.Void SelfAddRange(System.Collections.Generic.List<WizardGames.Soc.Common.Entity.SceneItemEntity> sceneItemEntitiesList, System.Collections.Generic.List<WizardGames.Soc.Common.Entity.CollectableEntity> collectableEntitiesList, System.Collections.Generic.List<WizardGames.Soc.Common.Entity.ThrownEntity> thrownItemEntitiesList, System.Collections.Generic.List<WizardGames.Soc.Common.Entity.CorpseEntity> corpseEntitiesList, System.Collections.Generic.List<WizardGames.Soc.Common.Entity.BoxEntity> rewardBoxEntitiesList); // 0x077213ac
	System.Void AddList<T>(System.Collections.Generic.List<T> list); // 0x052af1f0
	System.Void ClearEntitiesCollection(); // 0x077211d4
	System.Void RecordOldData(); // 0x0771e230
	System.Void ClearOldData(); // 0x0771cb78
	System.Void ClearData(); // 0x0771db9c
	System.Boolean CheckHasChanged(); // 0x07720adc
	WizardGames.Soc.Common.CustomType.BaseItemNode GetItemNodeByNodeId(System.Int64 nodeId); // 0x077215b8
	WizardGames.Soc.Common.Component.RootNodeComponent GetRootNodeByEntityId(System.Int64 entityId); // 0x077218b8
	System.Void PickItem(WizardGames.Soc.Common.CustomType.BaseItemNode item, System.Int64 itemUid, System.Int64 entityId); // 0x07721b2c
	System.Void PickItem(System.Int64 itemUid, System.Boolean isAutoPick); // 0x0772227c
	System.Int64 GetEntityIdToItemUid(System.Int64 itemUid); // 0x0772271c
	System.Void PickItem(System.Int64 extendBagNodeId, System.Int64 itemUid, System.Boolean isAutoPick); // 0x077227d0
	System.Boolean CheckCanPickUp(WizardGames.Soc.Common.CustomType.BaseItemNode item); // 0x07722d20
	System.Boolean TryPickFromOtherItems(System.Int64 itemUid); // 0x054c5f44
	System.Void PickItemFromCollection(System.Int64 colId, System.Int64 itemUid, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, System.Boolean isAutoPick); // 0x07723028
	System.Boolean InventoryIsFull(WizardGames.Soc.Common.CustomType.BaseItemNode item); // 0x07721d20
	static System.Boolean IsPoiTaskItem(System.Int64 itemBizId); // 0x0772327c
	System.Void ShowInventoryTip(System.Boolean isAutoPick, System.Boolean isSeed); // 0x07721f50
	System.Boolean GetIsInventoryFull(); // 0x077233c8
	System.Void OnDropItemFromBag(System.Int64 itemTemplateId, System.String nameStr, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x0772342c
	System.Void OnUiOthersideNearByOpen(System.Boolean isUiOthersideNearByOpen); // 0x07723758
	System.Void OnInventoryItemChange(); // 0x077237d4
	System.Boolean IsInPickableList(System.Int64 entityId); // 0x07723838
	System.Boolean IsInCollectableSet(System.Int64 entityId); // 0x07723944
	System.Boolean CanPick(UnityEngine.GameObject targetGo, UnityEngine.Vector3 targetPos); // 0x0771b520
	System.Boolean IsExpansionBackpacks(System.Int64 itemTemplateId); // 0x0772369c
	System.Void SetAutoPickCD(); // 0x077239e0
	System.Void TryAddToReportBoxList(System.Int64 id); // 0x07723b64
	System.Void TryReportNearbyBoxes(); // 0x07723c2c
	System.Boolean CheckBoxComponent(System.Int64 boxEntityId); // 0x07723db8
	System.Void RemoteCallPickItem(WizardGames.Soc.Common.SimpleCustom.SimulatorPickUpRequest req); // 0x077220ec
	System.Void set_LootingName(System.String value); // 0x07723f00
	System.String get_LootingName(); // 0x07723f80
	System.Func<WizardGames.Soc.Common.CustomType.ItemContainerNode,System.Boolean> get_FilterProcess(); // 0x07723fe4
	System.Void set_FilterProcess(System.Func<WizardGames.Soc.Common.CustomType.ItemContainerNode,System.Boolean> value); // 0x07724048
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> GetOtherItemsNodeList(); // 0x077240c8
	System.Boolean HandleContainer(WizardGames.Soc.Common.CustomType.ItemContainerNode container); // 0x07724264
	System.Boolean IsOtherItems(System.Int64 id, WizardGames.Soc.Common.CustomType.BaseItemNode& itemNode); // 0x07722e70
	System.Void StartPickListLooting(System.Int64 collectionID); // 0x07724710
	System.Void TryStopPickListLooting(); // 0x07724788
	System.Boolean IsPickListLooting(); // 0x0771e1c4
	System.Void ClearPickableHandle(); // 0x0771c858
	System.Void GetPlayerNearbyPickableItemModels(UnityEngine.Vector3 myPlayerPos, System.Single rangeDis, System.Single rangeDisUpY, System.Single rangeDisDownY); // 0x0771f048
	System.Void UpdateEntitiesInRange(UnityEngine.Vector3 playerPos, System.Single range, System.Single rangeUpY, System.Single rangeDownY); // 0x07724898
	System.Void ProcessAllEntities(System.Single range, System.Single rangeUpY, System.Single rangeDownY); // 0x07724978
	System.Int32 GetAllNearestEntities(System.Single range); // 0x07724de4
	System.Void FilterValidEntities(System.Int32 count, System.Single minY, System.Single maxY); // 0x0772515c
	System.Void ProcessThrownItems(System.Single range, System.Single rangeUpY, System.Single rangeDownY); // 0x07724a34
	System.Void ClearCollections(); // 0x0771cc64
	System.Void UpdateNearestCollectable(System.Int64 id, System.Single dist); // 0x077257b0
	System.Boolean IsValidPickable(System.Int64 id, System.Single y); // 0x07725604
	System.Single CalculateXZSqrDistance(System.Single x, System.Single z); // 0x0772540c
	System.Single CalculateFullSqrDistance(System.Single x, System.Single y, System.Single z); // 0x0772554c
	System.Void UpdateRecoveryInteractiveIdList(System.Collections.Generic.List<System.Int32> interactiveIdList, System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Ui.EInteractionType> typeSet); // 0x0772584c
	System.String GetRecoveryEntityName(); // 0x077259c4
	System.Void Recovery(); // 0x07725aac
	System.String get_RangeInteractiveBoxName(); // 0x07725bdc
	System.Void set_RangeInteractiveBoxName(System.String value); // 0x07725c40
	System.Void ClearRewardBoxHandle(); // 0x0771ca5c
	System.Void OnEnterWorldRewardBoxHandle(); // 0x0771cf1c
	System.Void OnExitWorldRewardBoxHandle(); // 0x0771d520
	System.Boolean IsRewardBoxId(System.Int64 templateId); // 0x07725cc0
	System.Void GetPlayerNearbyRewardBoxCollectionList(UnityEngine.Vector3 myPlayerPos, System.Single rangeDis, System.Single rangeDisUpY, System.Single rangeDisDownY); // 0x0771fefc
	System.Boolean CheckCanPickBox(WizardGames.Soc.Common.Entity.BoxEntity boxEntity, UnityEngine.Vector3 myPlayerPos, System.Single rangeDis, System.Single rangeDisUpY, System.Single rangeDisDownY); // 0x07725d90
	System.Collections.Generic.List<WizardGames.Soc.Common.Entity.BoxEntity> GetRangeInteractiveBoxList(); // 0x077262cc
	System.Boolean IdIsRangeInteractive(System.Int32 interactiveId); // 0x07726330
	System.Boolean IsRangeInteractiveEntity(System.Int64 entityId); // 0x07726614
	System.Void OnRequestSubscribeAckRewardBox(System.Int64 entityId, System.Boolean success); // 0x07726810
	System.Void SetCurrentOperateBoxEntityId(System.Collections.Generic.List<System.Int64> boxEntityIdList); // 0x07726ae0
	System.Void ClearCurrentOperateBoxEntityId(); // 0x07726ce4
	System.Void .ctor(); // 0x07726d68
	static System.Void .cctor(); // 0x07727770
}

// Client.Runtime
class WizardGames.Soc.SocClient.WorldResource.MgrGatherItemPickable.DistanceComparerByXZ : System.Object, System.Collections.Generic.IComparer<WizardGames.Soc.Share.Framework.IPositionEntity>
{
	static System.Single myPlayerPosX; // 0x0
	static System.Single myPlayerPosZ; // 0x4
	static System.Comparison<WizardGames.Soc.Share.Framework.IPositionEntity> DistanceComparsion; // 0x8
	static System.Void SetPlayerPosition(System.Single posX, System.Single posZ); // 0x07721514
	System.Int32 Compare(WizardGames.Soc.Share.Framework.IPositionEntity a, WizardGames.Soc.Share.Framework.IPositionEntity b); // 0x07727900
	static System.Single CalculateXZSqrDistanceStatic(System.Single x, System.Single z); // 0x07727b74
	System.Void .ctor(); // 0x07727898
	static System.Void .cctor(); // 0x07727c2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.WorldResource.MgrGatherItemPickable.DistanceComparerByXZ.<>c : System.Object
{
	static WizardGames.Soc.SocClient.WorldResource.MgrGatherItemPickable.DistanceComparerByXZ.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x07727d00
	System.Void .ctor(); // 0x07727d64
	System.Int32 <.cctor>b__7_0(WizardGames.Soc.Share.Framework.IPositionEntity a, WizardGames.Soc.Share.Framework.IPositionEntity b); // 0x07727dcc
}

// Client.Runtime
struct WizardGames.Soc.SocClient.WorldResource.MgrGatherItemPickable.EntityData : System.ValueType
{
	System.Int64 EntityId; // 0x10
	System.Single SqrDistance; // 0x18
	WizardGames.Soc.SocClient.WorldResource.MgrGatherItemPickable.EEntityType Type; // 0x1c
	System.Single PosY; // 0x20
	System.Void .ctor(System.Int64 id, System.Single dist, WizardGames.Soc.SocClient.WorldResource.MgrGatherItemPickable.EEntityType type, System.Single posY); // 0x077254a4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.WorldResource.MgrGatherItemPickable.EEntityType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.WorldResource.MgrGatherItemPickable.EEntityType SceneItem = 0;
	static WizardGames.Soc.SocClient.WorldResource.MgrGatherItemPickable.EEntityType Collectable = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.WorldResource.MgrGatherItemPickable.<>c__DisplayClass237_0 : System.Object
{
	System.Int64 removeCollectionId; // 0x10
	System.Void .ctor(); // 0x07726264
	System.Boolean <GetPlayerNearbyRewardBoxCollectionList>b__0(System.Int64 x); // 0x07728040
	System.Boolean <GetPlayerNearbyRewardBoxCollectionList>b__1(System.Int64 x); // 0x077280c0
	System.Boolean <GetPlayerNearbyRewardBoxCollectionList>b__2(System.Int64 x); // 0x07728140
}

// Client.Runtime
class WizardGames.Soc.SocClient.WorldResource.MgrWorldResource : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger <logger>k__BackingField; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.WorldResource.DropItemCombineData> dropItemCombineList; // 0x18
	UnityEngine.GameObject dropItemRoot; // 0x20
	System.String dropItemPrefabPath; // 0x28
	System.Int32 dropItemDestroyTime; // 0x30
	static SocLogger get_logger(); // 0x077281c0
	System.Void StartCombineSceneItem(WizardGames.Soc.Common.SimpleCustom.DropCombineEvent dropCombineEvent); // 0x07728248
	System.Void InitSceneItemGo(UnityEngine.GameObject mainGo, System.String dropPath, WizardGames.Soc.SocClient.WorldResource.DropCombineData dropCombineData); // 0x077289cc
	System.Void AddDropItemRemoveTimer(WizardGames.Soc.SocClient.WorldResource.DropItemCombineData dropItemCombineData); // 0x077290d0
	UnityEngine.Rigidbody CreateRigidbody(UnityEngine.GameObject MainGo); // 0x07728e70
	System.Void CreateDropItemGo(System.String path, UnityEngine.GameObject root, WizardGames.Soc.SocClient.WorldResource.DropCombineData dropCombineData, System.Action<UnityEngine.GameObject,System.String,WizardGames.Soc.SocClient.WorldResource.DropCombineData> loadFinishAction); // 0x077287d8
	System.Threading.Tasks.Task OnExitWorld(); // 0x07729368
	System.Void RenderUpdate(); // 0x077293fc
	System.Void UpdateDropItem(); // 0x07729460
	System.Void .ctor(); // 0x077298f0
	static System.Void .cctor(); // 0x077299ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.WorldResource.MgrWorldResource.<>c__DisplayClass10_0 : System.Object
{
	WizardGames.Soc.SocClient.WorldResource.MgrWorldResource <>4__this; // 0x10
	WizardGames.Soc.SocClient.WorldResource.DropItemCombineData dropItemCombineData; // 0x18
	System.Void .ctor(); // 0x07729298
	System.Void <AddDropItemRemoveTimer>b__0(System.Int64 id, System.Object data, System.Boolean delete); // 0x07729a44
}

// Client.Runtime
class WizardGames.Soc.SocClient.WorldResource.MgrWorldResource.<>c__DisplayClass12_0 : System.Object
{
	System.String path; // 0x10
	System.Void .ctor(); // 0x07729300
	System.Void <CreateDropItemGo>b__0(UnityEngine.GameObject obj, System.Object[] owner); // 0x07729b24
}

// Client.Runtime
class WizardGames.Soc.SocClient.WorldResource.MgrWorldResource.<>c__DisplayClass9_0 : System.Object
{
	System.String dropPath; // 0x10
	UnityEngine.GameObject mainGo; // 0x18
	System.Int64 combineEntityId; // 0x20
	WizardGames.Soc.SocClient.WorldResource.MgrWorldResource <>4__this; // 0x28
	UnityEngine.Rigidbody rigidbody; // 0x30
	System.Void .ctor(); // 0x07728e08
	System.Void <InitSceneItemGo>b__0(System.Int64 id, System.Object data, System.Boolean delete); // 0x07729cc4
}

// Client.Runtime
class WizardGames.Soc.SocClient.WorldResource.DropItemCombineData : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	UnityEngine.GameObject MainGo; // 0x10
	System.String prefabPath; // 0x18
	System.Boolean CanRemove; // 0x20
	System.Int64 combineEntityId; // 0x28
	WizardGames.Soc.Common.Entity.SceneItemEntity sceneItemEntity; // 0x30
	System.Single speed; // 0x38
	System.Single accelerationFactor; // 0x3c
	WizardGames.Soc.Common.Entity.SceneItemEntity get_SceneItemEntity(); // 0x07729f00
	System.Void RegisterData(System.String path, UnityEngine.GameObject go, System.Int64 toEntityId); // 0x07729e4c
	System.Void UpdatePosition(); // 0x077295b0
	System.Void Return(); // 0x0772a038
	System.Void OnGet(); // 0x0772a13c
	System.Void OnRelease(); // 0x0772a1e0
	System.Void OnDestroy(); // 0x0772a244
	System.Void .ctor(); // 0x0772a2a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.WorldResource.DropCombineData : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	System.Int64 ItemTemplateId; // 0x10
	System.Single PosX; // 0x18
	System.Single PosY; // 0x1c
	System.Single PosZ; // 0x20
	System.Single RotateX; // 0x24
	System.Single RotateY; // 0x28
	System.Single RotateZ; // 0x2c
	System.Int64 CombineEntityId; // 0x30
	System.Void CopyData(WizardGames.Soc.Common.SimpleCustom.DropCombineEvent combineEvent); // 0x07728724
	System.Void OnGet(); // 0x0772a318
	System.Void OnRelease(); // 0x0772a378
	System.Void OnDestroy(); // 0x0772a3d8
	System.Void .ctor(); // 0x0772a438
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Weapon.AccessoryManagerParams : System.ValueType
{
	WizardGames.Soc.Common.CustomType.WeaponCustom HostEntity; // 0x10
	System.Boolean IsFp; // 0x18
	WizardGames.Soc.SocClient.Weapon.IAccessoryHost Host; // 0x20
	System.Int32 ShowLayer; // 0x28
	System.Boolean IsCacheRenderer; // 0x2c
	static WizardGames.Soc.SocClient.Weapon.AccessoryManagerParams CreateParams(WizardGames.Soc.Common.CustomType.WeaponCustom weapon, WizardGames.Soc.SocClient.Weapon.IAccessoryHost host, System.Boolean fp, System.Int32 showLayer, System.Boolean isCacheRenderer); // 0x0772a4a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.AccessoryManager : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable, WizardGames.Soc.SocClient.Weapon.IAccessoryManager
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Weapon.AccessoryGo> _accessories; // 0x10
	System.Boolean isFp; // 0x18
	WizardGames.Soc.Common.CustomType.WeaponCustom hostEntity; // 0x20
	WizardGames.Soc.SocClient.Weapon.IAccessoryHost <Host>k__BackingField; // 0x28
	System.Int32 <ShowLayer>k__BackingField; // 0x30
	System.Boolean isHostDeploy; // 0x34
	System.Boolean isCacheRenderer; // 0x35
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Weapon.AccessoryGo> loadings; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Weapon.AccessoryGo> removeList; // 0x40
	System.Collections.Generic.List<System.Int64> changedMap; // 0x48
	static WizardGames.Soc.SocClient.Weapon.AccessoryManager GetAccessoryManager(WizardGames.Soc.SocClient.Weapon.AccessoryManagerParams p); // 0x0772a59c
	static System.Void Return(WizardGames.Soc.SocClient.Weapon.AccessoryManager manager); // 0x0772a6b8
	UnityEngine.GameObject get_hostGo(); // 0x0772a760
	System.Int64 get_TableID(); // 0x0772a874
	WizardGames.Soc.SocClient.Weapon.IAccessoryHost get_Host(); // 0x0772a8e4
	System.Void set_Host(WizardGames.Soc.SocClient.Weapon.IAccessoryHost value); // 0x0772a948
	System.Void set_ShowLayer(System.Int32 value); // 0x0772a9c8
	System.Int32 get_ShowLayer(); // 0x0772aa40
	System.Void Init(WizardGames.Soc.SocClient.Weapon.AccessoryManagerParams p); // 0x0772aaa4
	System.Void AddAccessory(WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom entity); // 0x0772b12c
	System.Void RemoveAccessory(System.Int64 entityId); // 0x0772b3e0
	System.Void SetShadowCastingMode(UnityEngine.Rendering.ShadowCastingMode mode); // 0x0772c2a4
	System.Void Update(System.Single dt); // 0x0772c634
	System.Void LateUpdate(System.Single dt); // 0x0772c83c
	System.Void QualityUpdate(); // 0x0772ca44
	System.Void OnHostDeploy(); // 0x0772cc38
	System.Void OnHostHolster(); // 0x0772ced0
	System.Boolean TryGetSlotAccessoryGo(WizardGames.Soc.Common.Data.DataItem.ItemSlot slot, WizardGames.Soc.SocClient.Weapon.AccessoryGo& go); // 0x0772d180
	System.Boolean TryGetTableAccessoryGo(System.Int64 tableId, WizardGames.Soc.SocClient.Weapon.AccessoryGo& go); // 0x0772d418
	System.Void OnAccessoryChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldAcc, WizardGames.Soc.Share.Framework.CustomTypeBase newAcc); // 0x0772d6b0
	System.Void OnPostAccessoryChange(); // 0x0772bbec
	System.Void UpdateVisible(System.Boolean visible); // 0x0772dc80
	System.Void OnAccessoryCreated(WizardGames.Soc.SocClient.Weapon.AccessoryGo acc); // 0x0772ded0
	System.Void OnAccessoryUsableChange(WizardGames.Soc.SocClient.Weapon.AccessoryGo acc, System.Boolean usable); // 0x0772e628
	System.Void Release(); // 0x0772e6a8
	System.Void OnGet(); // 0x0772e748
	System.Void OnRelease(); // 0x0772e7a8
	System.Void OnDestroy(); // 0x0772ed4c
	System.Void UpdateAlpha(); // 0x0772edac
	System.Void .ctor(); // 0x0772f168
	static System.Void .cctor(); // 0x0772f300
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Weapon.AccessoryGoCreateParam : System.ValueType
{
	WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom Entity; // 0x10
	System.Boolean Fp; // 0x18
	System.Boolean Self; // 0x19
	WizardGames.Soc.SocClient.Weapon.IAccessoryManager Manager; // 0x20
	System.String HangPoint; // 0x28
	System.Boolean IsCacheRender; // 0x30
	static WizardGames.Soc.SocClient.Weapon.AccessoryGoCreateParam Create(WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom acc, System.Boolean fp, System.Boolean self, WizardGames.Soc.SocClient.Weapon.IAccessoryManager host, System.String target, System.Boolean cacheRender); // 0x0772b6cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.AccessoryGo : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable, WizardGames.Soc.SocClient.Weapon.IAccessoryChangeHandle, WizardGames.Soc.SocClient.Player.HeldItem.IHeldItemBatchLoaderHandler
{
	SocLogger logger; // 0x10
	System.UInt64 loadIndex; // 0x18
	System.Boolean <Loaded>k__BackingField; // 0x20
	WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom <Entity>k__BackingField; // 0x28
	UnityEngine.GameObject <MainGo>k__BackingField; // 0x30
	WizardGames.Soc.SocClient.Weapon.BaseAccessoryController Controller; // 0x38
	WizardGames.Soc.Common.Data.part.PartBase <Table>k__BackingField; // 0x40
	WizardGames.Soc.Common.Data.part.PartAsset TbAsset; // 0x48
	System.String hangingTarget; // 0x50
	System.Boolean isSelf; // 0x58
	System.Boolean isFp; // 0x59
	WizardGames.Soc.SocClient.Weapon.IAccessoryManager manager; // 0x60
	WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent ObjectComponent; // 0x68
	System.Boolean isCacheRender; // 0x70
	System.Collections.Generic.List<UnityEngine.Renderer> cachedRenderers; // 0x78
	WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader Loader; // 0x80
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo> PrefabLoadInfos; // 0x88
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Player.HeldItem.HeldItemLoadInfo> AssetLoadInfos; // 0x90
	WizardGames.Soc.Common.Unity.Character.CharacterFovConfig SceneFovConfig; // 0x98
	WizardGames.Soc.Common.Unity.Character.CharacterFovConfig GunFovConfig; // 0xa0
	System.Collections.Generic.List<UnityEngine.Renderer> ModelRenderers; // 0xa8
	System.Boolean clone; // 0xb0
	System.Boolean get_Loaded(); // 0x0772f3d4
	System.Void set_Loaded(System.Boolean value); // 0x0772f438
	System.Void set_Entity(WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom value); // 0x0772f4b4
	WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom get_Entity(); // 0x0772f534
	WizardGames.Soc.SocClient.Weapon.IAccessoryHost get_Host(); // 0x0772f598
	System.Int64 get_HostTableId(); // 0x0772f664
	System.Void set_MainGo(UnityEngine.GameObject value); // 0x0772f72c
	UnityEngine.GameObject get_MainGo(); // 0x0772f7ac
	WizardGames.Soc.Common.Data.part.PartBase get_Table(); // 0x0772f810
	System.Void set_Table(WizardGames.Soc.Common.Data.part.PartBase value); // 0x0772f874
	static WizardGames.Soc.SocClient.Weapon.AccessoryGo CreateAccessoryGo(WizardGames.Soc.SocClient.Weapon.AccessoryGoCreateParam createParam); // 0x0772b7f4
	System.Void Init(WizardGames.Soc.SocClient.Weapon.AccessoryGoCreateParam createParam); // 0x0772f8f4
	System.Void Load(); // 0x0772fda0
	System.Void OnBatchLoaded(WizardGames.Soc.SocClient.Player.HeldItem.HeldItemBatchLoader loader); // 0x077307fc
	UnityEngine.Transform GetChildTransform(System.String name); // 0x07731d18
	System.Void Attach(); // 0x0772e5c8
	System.Void Dettach(); // 0x0772b8d4
	System.Void OnHostDeploy(); // 0x0772ce5c
	System.Void OnHostHolster(); // 0x0772d108
	System.Void Update(); // 0x0772c7c4
	System.Void LateUpdate(); // 0x0772c9cc
	System.Void QualityUpdate(); // 0x0772cbc0
	System.Void HookTo(System.String hangpoint); // 0x0772d8b0
	System.Void UpdateVisible(System.Boolean visible); // 0x0772de40
	System.Void OnStatusChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldStatus, System.Int32 newStatus); // 0x07731e70
	System.Void OnConditionChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldCondition, System.Single newCondition); // 0x07731f00
	System.Void OnSkinChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldSkin, System.Int64 newSkin); // 0x077320b8
	System.Void ClearMaterialsClone(); // 0x07732168
	System.Void OnFinishLoad(); // 0x07731990
	System.Void UpdateAlpha(); // 0x0772ef58
	System.Void Release(); // 0x0772b934
	System.Void OnGet(); // 0x07732208
	System.Void TryReleaseGoPool(); // 0x0773047c
	System.Void SetShadowCastingMode(UnityEngine.Rendering.ShadowCastingMode mode); // 0x0772c46c
	System.Void OnRelease(); // 0x07732268
	System.Void OnDestroy(); // 0x077323e4
	WizardGames.Soc.SocClient.Weapon.BaseAccessoryController CreateController(); // 0x07731204
	System.Void .ctor(); // 0x07732444
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.BaseAccessoryController : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable, WizardGames.Soc.SocClient.Weapon.IAccessoryChangeHandle
{
	SocLogger logger; // 0x10
	WizardGames.Soc.SocClient.Weapon.AccessoryGo <Accessory>k__BackingField; // 0x18
	static T Create<T>(WizardGames.Soc.SocClient.Weapon.AccessoryGo Acc); // 0x052af1f0
	System.Void set_Accessory(WizardGames.Soc.SocClient.Weapon.AccessoryGo value); // 0x07732634
	WizardGames.Soc.SocClient.Weapon.AccessoryGo get_Accessory(); // 0x077326b4
	System.Void Init(WizardGames.Soc.SocClient.Weapon.AccessoryGo Acc); // 0x07732718
	System.Void Release(); // 0x07732990
	System.Void OnHostDeploy(); // 0x07732a30
	System.Void OnHostHolster(); // 0x07732a90
	System.Void OnUpdate(); // 0x07732af0
	System.Void OnLateUpdate(); // 0x07732b50
	System.Void QualityUpdate(); // 0x07732bb0
	System.Void OnGet(); // 0x07732c10
	System.Void OnRelease(); // 0x07732c70
	System.Void OnDestroy(); // 0x07732e7c
	System.Void OnStatusChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldStatus, System.Int32 newStatus); // 0x07732edc
	System.Void OnConditionChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldCondition, System.Single newCondition); // 0x07732f6c
	System.Void OnSkinChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldSkin, System.Int64 newSkin); // 0x07732ffc
	System.Void UpdateVisible(System.Boolean visible); // 0x0773308c
	System.Void .ctor(); // 0x07733100
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.BaseFlashLightController : WizardGames.Soc.SocClient.Weapon.BaseAccessoryController
{
	UnityEngine.Transform Switch; // 0x20
	Effect.EffectItemHandle<Effect.EffectItem> lightEffectHandle; // 0x28
	WizardGames.Soc.SocClient.ClientLight.LightItem lightItem; // 0x38
	System.Boolean isSelf; // 0x40
	WizardGames.Soc.Common.Entity.PlayerEntity ownerPlayerEntity; // 0x48
	System.Boolean isFp; // 0x50
	System.Boolean isLightBlock; // 0x51
	System.Single lightRadius; // 0x54
	static WizardGames.Soc.SocClient.Weapon.BaseFlashLightController Create<T>(WizardGames.Soc.SocClient.Weapon.AccessoryGo Acc, System.Boolean isFp); // 0x052af1f0
	System.Void Init(WizardGames.Soc.SocClient.Weapon.AccessoryGo Acc, System.Boolean isFp); // 0x077331f8
	System.Void JudgeCreateLight(); // 0x077337ac
	System.Void QualityUpdate(); // 0x07733b08
	System.Void OnUpdate(); // 0x07733bac
	System.Void ResetLightItem(); // 0x07733f88
	System.Void OnHostDeploy(); // 0x07734150
	System.Void OnHostHolster(); // 0x077341d8
	System.Void OnConditionChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldCondition, System.Single newCondition); // 0x07734254
	System.Void OnStatusChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldStatus, System.Int32 newStatus); // 0x07734320
	System.Void ActiveLight(System.Boolean on); // 0x077343ec
	System.Boolean IsOn(); // 0x07734504
	System.Void OnRelease(); // 0x077347b8
	System.Void Release(); // 0x077348b8
	System.Void .ctor(); // 0x07734958
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.BaseLaserController : WizardGames.Soc.SocClient.Weapon.BaseAccessoryController
{
	UnityEngine.Transform Switch; // 0x20
	LaserBeam laser; // 0x28
	static WizardGames.Soc.SocClient.Weapon.BaseLaserController Create<T>(WizardGames.Soc.SocClient.Weapon.AccessoryGo Acc, System.Boolean isFp); // 0x052af1f0
	System.Void Init(WizardGames.Soc.SocClient.Weapon.AccessoryGo Acc, System.Boolean isFp); // 0x077349bc
	System.Void OnHostDeploy(); // 0x07734d68
	System.Void OnHostHolster(); // 0x07734de8
	System.Void OnConditionChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldCondition, System.Single newCondition); // 0x07734e50
	System.Void OnStatusChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldStatus, System.Int32 newStatus); // 0x07734f14
	System.Void ActiveLaser(System.Boolean on); // 0x07734cc0
	System.Void OnLateUpdate(); // 0x07734fd8
	System.Boolean IsOn(); // 0x07735064
	System.Void OnRelease(); // 0x07735330
	System.Void Release(); // 0x077353ec
	System.Void UpdateVisible(System.Boolean visible); // 0x0773548c
	System.Void .ctor(); // 0x07735520
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.MonsterFlashLightController : WizardGames.Soc.SocClient.Weapon.BaseFlashLightController
{
	System.Boolean isActive; // 0x58
	System.Void Init(WizardGames.Soc.SocClient.Weapon.AccessoryGo Acc, System.Boolean isFp); // 0x07735584
	System.Void Init(WizardGames.Soc.SocClient.Weapon.AccessoryGo Acc); // 0x07735b28
	System.Boolean IsOn(); // 0x07735d18
	System.Void OnUpdate(); // 0x07735e6c
	System.Void ActiveLight(System.Boolean on); // 0x07735f0c
	System.Void OnLocalStateChange(WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom.LocalStatusEnum old_state, WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom.LocalStatusEnum new_state); // 0x0773602c
	System.Void Release(); // 0x077360d0
	System.Void .ctor(); // 0x077362c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.MyFpFlashLightController : WizardGames.Soc.SocClient.Weapon.BaseFlashLightController
{
	WizardGames.Soc.Common.Syncronization.ELightSourceType lightSourceType; // 0x58
	System.Boolean isHostDeploy; // 0x5c
	System.Boolean delegated; // 0x5d
	System.Single checktick; // 0x60
	System.Void Init(WizardGames.Soc.SocClient.Weapon.AccessoryGo Acc); // 0x0773632c
	System.Void Init(WizardGames.Soc.SocClient.Weapon.AccessoryGo Acc, System.Boolean isFp); // 0x07736770
	System.Void OnUILightClickDelegate(System.Boolean on); // 0x07736840
	System.Void OnUpdate(); // 0x07736b18
	System.Void OnHostDeploy(); // 0x07736e84
	System.Void OnHostHolster(); // 0x07736f04
	System.Void OnRelease(); // 0x077370f4
	System.Void Release(); // 0x07737248
	System.Boolean IsOn(); // 0x077372e8
	System.Void CameraChangeState(WizardGames.Soc.Common.Unity.CameraState lastCameraState, WizardGames.Soc.Common.Unity.CameraState nowCameraState); // 0x07737450
	System.Void RemoveUIDelegate(System.Boolean checkValid); // 0x07736f78
	System.Void TryAddUIDelegate(); // 0x07736488
	System.Void .ctor(); // 0x077374f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.MyTpFlashLightController : WizardGames.Soc.SocClient.Weapon.BaseFlashLightController
{
	WizardGames.Soc.Common.Syncronization.ELightSourceType lightSourceType; // 0x58
	System.Boolean isHostDeploy; // 0x5c
	System.Void Init(WizardGames.Soc.SocClient.Weapon.AccessoryGo Acc); // 0x07737568
	System.Void Init(WizardGames.Soc.SocClient.Weapon.AccessoryGo Acc, System.Boolean isFp); // 0x077376dc
	System.Void OnRelease(); // 0x077377ac
	System.Void OnHostHolster(); // 0x077378f4
	System.Void OnHostDeploy(); // 0x0773795c
	System.Void Release(); // 0x077379c8
	System.Boolean IsOn(); // 0x07737a68
	System.Void CameraChangeState(WizardGames.Soc.Common.Unity.CameraState lastCameraState, WizardGames.Soc.Common.Unity.CameraState nowCameraState); // 0x07737bd0
	System.Void .ctor(); // 0x07737c74
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.MyFpBaseScopeController : WizardGames.Soc.SocClient.Weapon.BaseAccessoryController
{
	UnityEngine.GameObject ScopeSightImage; // 0x20
	UnityEngine.Transform SightLocator; // 0x28
	System.Void Init(WizardGames.Soc.SocClient.Weapon.AccessoryGo Acc); // 0x07737ce0
	System.Void Release(); // 0x077387c8
	System.Void OnUpdate(); // 0x07738868
	System.Void OnRelease(); // 0x077389c4
	System.Void .ctor(); // 0x07738b78
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.MyFpHSScopeController : WizardGames.Soc.SocClient.Weapon.MyFpBaseScopeController
{
	UnityEngine.Transform HSLens; // 0x30
	UnityEngine.Renderer HSLenRenderer; // 0x38
	System.Single bumpScale; // 0x40
	UnityEngine.Material DefaultMat; // 0x48
	System.UInt64 matTaskId; // 0x50
	WizardGames.AssetPool.AssetPoolHandle matAssetHandle; // 0x58
	System.Void Init(WizardGames.Soc.SocClient.Weapon.AccessoryGo Acc); // 0x07738bdc
	System.Void OnMatLoadFinish(System.UInt64 loaderId, Unity.Collections.LowLevel.Unsafe.UnsafeList<WizardGames.AssetPool.AssetGroupData> results); // 0x0773909c
	System.Void OnUpdate(); // 0x077393a8
	System.Void UpdateLensRenderer(System.Boolean open); // 0x07739284
	System.Void Release(); // 0x0773948c
	System.Void .ctor(); // 0x07739584
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.MyFpXScopeController : WizardGames.Soc.SocClient.Weapon.MyFpBaseScopeController
{
	UnityEngine.Transform FullScope; // 0x30
	UnityEngine.Transform AdsScope; // 0x38
	UnityEngine.MaterialPropertyBlock block; // 0x40
	UnityEngine.Renderer ScopeRenderer; // 0x48
	UnityEngine.Color basecolor; // 0x50
	System.Single k; // 0x60
	System.Single b; // 0x64
	System.Void Init(WizardGames.Soc.SocClient.Weapon.AccessoryGo Acc); // 0x077395f0
	System.Void OnUpdate(); // 0x07739aa4
	System.Void Release(); // 0x07739dd4
	System.Void .ctor(); // 0x07739f08
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.MyFpLaserController : WizardGames.Soc.SocClient.Weapon.BaseLaserController
{
	WizardGames.Soc.Common.Syncronization.ELightSourceType lightSourceType; // 0x30
	System.Boolean delegated; // 0x34
	System.Single checktick; // 0x38
	System.Void Init(WizardGames.Soc.SocClient.Weapon.AccessoryGo Acc); // 0x07739f7c
	System.Void OnUILightClickDelegate(System.Boolean on); // 0x0773a394
	System.Void OnUpdate(); // 0x0773a840
	System.Void OnHostDeploy(); // 0x0773abac
	System.Void OnHostHolster(); // 0x0773ac24
	System.Void OnRelease(); // 0x0773adf8
	System.Void Release(); // 0x0773af48
	System.Boolean IsOn(); // 0x0773afe8
	System.Void CameraChangeState(WizardGames.Soc.Common.Unity.CameraState lastCameraState, WizardGames.Soc.Common.Unity.CameraState nowCameraState); // 0x0773b14c
	System.Void RemoveUIDelegate(); // 0x0773ac90
	System.Void TryAddUIDelegate(); // 0x0773a0dc
	System.Void .ctor(); // 0x0773b1e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.MyTpLaserController : WizardGames.Soc.SocClient.Weapon.BaseLaserController
{
	WizardGames.Soc.Common.Syncronization.ELightSourceType lightSourceType; // 0x30
	System.Void Init(WizardGames.Soc.SocClient.Weapon.AccessoryGo Acc); // 0x0773b614
	System.Void OnRelease(); // 0x0773b76c
	System.Void Release(); // 0x0773b8b8
	System.Boolean IsOn(); // 0x0773b958
	System.Void CameraChangeState(WizardGames.Soc.Common.Unity.CameraState lastCameraState, WizardGames.Soc.Common.Unity.CameraState nowCameraState); // 0x0773bac0
	System.Void .ctor(); // 0x0773bb60
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Weapon.IAccessoryChangeHandle : 
{
	
	System.Void OnStatusChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldStatus, System.Int32 newStatus); // 0x05525bf4
	System.Void OnConditionChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Single oldCondition, System.Single newCondition); // 0x05527728
	System.Void OnSkinChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldSkin, System.Int64 newSkin); // 0x05527160
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Weapon.IAccessoryHost : 
{
	
	System.Void AfterAccessoryCreated(WizardGames.Soc.SocClient.Weapon.AccessoryGo acc); // 0x05523a54
	System.Boolean get_Deployed(); // 0x054c4760
	System.Boolean TryGetHangPoint(System.String pointName, UnityEngine.Transform& point); // 0x054e0cf4
	UnityEngine.GameObject get_AccessoryHostGo(); // 0x054e7844
	System.Void AccessoryChangePostProcess(WizardGames.Soc.SocClient.Weapon.AccessoryManager acc_manager, System.Collections.Generic.List<System.Int64> changeMap); // 0x0552af00
	System.Boolean TryGetWeaponAccessory(WizardGames.Soc.Common.Data.DataItem.ItemSlot slot, WizardGames.Soc.SocClient.Weapon.AccessoryGo& accessory); // 0x054c5a54
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Weapon.IAccessoryManager : 
{
	
	System.Int64 get_TableID(); // 0x054a4380
	WizardGames.Soc.SocClient.Weapon.IAccessoryHost get_Host(); // 0x054e7844
	System.Int32 get_ShowLayer(); // 0x0548ba98
	System.Void OnAccessoryCreated(WizardGames.Soc.SocClient.Weapon.AccessoryGo acc); // 0x05523a54
	System.Void OnAccessoryUsableChange(WizardGames.Soc.SocClient.Weapon.AccessoryGo acc, System.Boolean usable); // 0x0552af28
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.MgrAccessoryManagers : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Weapon.AccessoryManager> set; // 0x18
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Weapon.AccessoryManager> activeSet; // 0x20
	System.Void Init(); // 0x0773bbd0
	System.Threading.Tasks.Task OnExitWorld(); // 0x0773bc38
	System.Void CleanUp(); // 0x0773be54
	System.Void Add(WizardGames.Soc.SocClient.Weapon.AccessoryManager mgr); // 0x0773bec4
	System.Void Active(WizardGames.Soc.SocClient.Weapon.AccessoryManager mgr, System.Boolean active); // 0x0773bf60
	System.Void Update(System.Single dt); // 0x0773c074
	System.Void LateUpdate(System.Single dt); // 0x0773c1fc
	System.Void QualityUpdate(); // 0x0773c384
	System.Void Remove(WizardGames.Soc.SocClient.Weapon.AccessoryManager mgr); // 0x0773c4f4
	System.Void Clear(); // 0x0773bca8
	System.Void .ctor(); // 0x0773c5f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.AdsHideWeaponController : WizardGames.Soc.SocClient.Weapon.WeaponFxController
{
	WizardGames.Soc.Common.Entity.PlayerEntity <Owner>k__BackingField; // 0x18
	WizardGames.Soc.Common.CustomType.WeaponCustom Weapon; // 0x20
	WizardGames.Soc.Common.Data.gun.GunBase table; // 0x28
	System.Boolean valid; // 0x30
	System.Boolean visible; // 0x31
	static WizardGames.Soc.SocClient.Weapon.AdsHideWeaponController GetController(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.CustomType.WeaponCustom weapon); // 0x0773c6dc
	WizardGames.Soc.Common.Entity.PlayerEntity get_Owner(); // 0x0773caac
	System.Void set_Owner(WizardGames.Soc.Common.Entity.PlayerEntity value); // 0x0773cb10
	System.Boolean get_Active(); // 0x0773cb90
	System.Void Init(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.CustomType.WeaponCustom weapon); // 0x0773c7ac
	System.Void OnUpdate(System.Single dt); // 0x0773cf14
	System.Boolean CheckVisible(); // 0x0773cc78
	System.Void Return(); // 0x0773d0f8
	System.Void .ctor(); // 0x0773d228
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.Ak47TYKCController : WizardGames.Soc.SocClient.Weapon.WeaponFxController
{
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer <MyPlayer>k__BackingField; // 0x18
	WizardGames.Soc.Common.CustomType.WeaponCustom weapon; // 0x20
	UnityEngine.GameObject mainGo; // 0x28
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer get_MyPlayer(); // 0x0773d320
	System.Void set_MyPlayer(WizardGames.Soc.Common.Syncronization.MgrMyPlayer value); // 0x0773d384
	System.Boolean get_Active(); // 0x0773d404
	static WizardGames.Soc.SocClient.Weapon.Ak47TYKCController GetController(UnityEngine.GameObject _mainGo, WizardGames.Soc.Common.Syncronization.MgrMyPlayer player, WizardGames.Soc.Common.CustomType.WeaponCustom weapon); // 0x0773d4e4
	System.Void Init(); // 0x0773d62c
	System.Void OnAdsOn(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0773d794
	System.Void OnAdsOff(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x0773d8cc
	System.Void OnUpdate(System.Single dt); // 0x0773da00
	System.Void Return(); // 0x0773da74
	System.Void .ctor(); // 0x0773dc98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.BaseChainSawFxController : WizardGames.Soc.SocClient.Weapon.WeaponFxController
{
	System.Boolean valid; // 0x13
	WizardGames.Soc.Common.CustomType.MeleeCustom <Saw>k__BackingField; // 0x18
	UnityEngine.GameObject <Go>k__BackingField; // 0x20
	UnityEngine.Renderer renderer; // 0x28
	UnityEngine.MaterialPropertyBlock block; // 0x30
	System.Single totalOffset; // 0x38
	System.Void Init(System.Boolean fp); // 0x0773dd20
	WizardGames.Soc.Common.CustomType.MeleeCustom get_Saw(); // 0x0773e164
	System.Void set_Saw(WizardGames.Soc.Common.CustomType.MeleeCustom value); // 0x0773e1c8
	UnityEngine.GameObject get_Go(); // 0x0773e248
	System.Void set_Go(UnityEngine.GameObject value); // 0x0773e2ac
	System.Void OnUpdate(System.Single dt); // 0x0773e32c
	System.Single GetChainSpeed(); // 0x054a5abc
	System.Void .ctor(); // 0x0773e460
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.ChainSawSFXController : WizardGames.Soc.SocClient.Weapon.WeaponFxController
{
	WizardGames.Soc.Common.Entity.PlayerEntity <Owner>k__BackingField; // 0x18
	UnityEngine.GameObject SawGo; // 0x20
	WizardGames.Soc.Common.CustomType.MeleeCustom Saw; // 0x28
	System.Boolean isAttack; // 0x30
	System.Boolean HasAmmo; // 0x31
	System.String currentAudio; // 0x38
	System.Boolean hitting; // 0x40
	System.Int32 lastHitMat; // 0x44
	System.Collections.Generic.HashSet<System.Int64> subscribeIds; // 0x48
	static WizardGames.Soc.SocClient.Weapon.ChainSawSFXController GetController(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.CustomType.MeleeCustom saw, UnityEngine.GameObject go); // 0x0773e520
	WizardGames.Soc.Common.Entity.PlayerEntity get_Owner(); // 0x0773e874
	System.Void set_Owner(WizardGames.Soc.Common.Entity.PlayerEntity value); // 0x0773e8d8
	System.Boolean get_Active(); // 0x0773e958
	System.Void Init(); // 0x0773e668
	System.Void OnActive(System.Boolean active); // 0x0773ea30
	System.Void OnUpdate(System.Single dt); // 0x0773f0d0
	System.Void OnAttackSubStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x0773f460
	System.Void OnActionStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x0773f954
	System.Void PlayAudio(System.String eventname); // 0x0773f7e4
	System.Void StopAudio(); // 0x0773ef54
	System.Void Return(); // 0x0773fa80
	System.Void .ctor(); // 0x0773fee0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.PlayerChainSawFxController : WizardGames.Soc.SocClient.Weapon.BaseChainSawFxController
{
	WizardGames.Soc.Common.Entity.PlayerEntity <Owner>k__BackingField; // 0x40
	System.Boolean isSelf; // 0x48
	System.Boolean isFp; // 0x49
	UnityEngine.Transform fxRoot; // 0x50
	Effect.EffectItemHandle<Effect.EffectItem> fxWoodHandle; // 0x58
	Effect.EffectItemHandle<Effect.EffectItem> fxBloodHandle; // 0x68
	Effect.EffectItemHandle<Effect.EffectItem> fxSparkHandle; // 0x78
	System.Int32 lastHitMat; // 0x88
	System.Boolean isOn; // 0x8c
	System.Boolean hitting; // 0x8d
	System.Int64 subscribeId; // 0x90
	static WizardGames.Soc.SocClient.Weapon.PlayerChainSawFxController GetController(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.CustomType.MeleeCustom saw, UnityEngine.GameObject go, System.Boolean self, System.Boolean isFp); // 0x0773ffbc
	WizardGames.Soc.Common.Entity.PlayerEntity get_Owner(); // 0x077401d4
	System.Void set_Owner(WizardGames.Soc.Common.Entity.PlayerEntity value); // 0x07740238
	System.Void Init(System.Boolean fp); // 0x077402b8
	System.Boolean get_Active(); // 0x07740d94
	System.Void SetEffectsActive(System.Boolean active); // 0x07740f3c
	System.Void SetEffectActive(System.Int32 index); // 0x07741038
	System.Void OnActive(System.Boolean active); // 0x07741148
	System.Void DisableHitEffect(); // 0x07740d24
	System.Void CheckEffect(System.Int32 hitMat); // 0x077411d8
	System.Void OnAttackSubStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x077412bc
	System.Void OnUpdate(System.Single dt); // 0x07741554
	System.Void UpdateEffect(Effect.EffectItemHandle<Effect.EffectItem> handle); // 0x077416c0
	System.Single GetChainSpeed(); // 0x07741808
	System.Void Return(); // 0x07741a64
	System.Void .ctor(); // 0x07741d08
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.EokaPistolAddViewkickController : WizardGames.Soc.SocClient.Weapon.WeaponFxController
{
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer <MyPlayer>k__BackingField; // 0x18
	WizardGames.Soc.Common.CustomType.WeaponCustom weapon; // 0x20
	WizardGames.Soc.Common.Combat.Shoot.IShootFormula shootFormula; // 0x28
	Contexts.ClientContext context; // 0x30
	WizardGames.Soc.Common.DataSet.CommonDataSet<Share.Common.ObjPool.Alpha3PooledObjectBase> weaponEffectRequestSet; // 0x38
	static WizardGames.Soc.SocClient.Weapon.EokaPistolAddViewkickController GetController(WizardGames.Soc.Common.Syncronization.MgrMyPlayer player, WizardGames.Soc.Common.CustomType.WeaponCustom weapon); // 0x07741d7c
	System.Boolean get_Active(); // 0x077420bc
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer get_MyPlayer(); // 0x0774219c
	System.Void set_MyPlayer(WizardGames.Soc.Common.Syncronization.MgrMyPlayer value); // 0x07742200
	System.Void OnUpdate(System.Single dt); // 0x07742280
	System.Void OnEnqueue(Share.Common.ObjPool.Alpha3PooledObjectBase objectBase); // 0x077423ec
	System.Void OnTryFire(); // 0x077424c4
	System.Void Return(); // 0x07742860
	System.Void .ctor(); // 0x07742a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.FlameThrowerFxController : WizardGames.Soc.SocClient.Weapon.WeaponFxController
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Entity.PlayerEntity Player; // 0x18
	WizardGames.Soc.Common.CustomType.WeaponCustom Weapon; // 0x20
	System.Boolean isSelf; // 0x28
	System.Boolean isFp; // 0x29
	WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent Opc; // 0x30
	Effect.EffectItemHandle<Effect.EffectItem> MuzzleEffectHandle; // 0x38
	Effect.EffectItemHandle<Effect.EffectItem> FireEffectHandle; // 0x48
	System.Boolean attacking; // 0x58
	System.Boolean valid; // 0x59
	static WizardGames.Soc.SocClient.Weapon.FlameThrowerFxController GetController(WizardGames.Soc.Common.Entity.PlayerEntity Player, WizardGames.Soc.Common.CustomType.WeaponCustom weapon, WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent opc, System.Boolean self, System.Boolean isFp); // 0x07742b14
	System.Boolean get_Active(); // 0x07742f54
	System.Void Init(); // 0x07742c40
	System.Void OnUpdate(System.Single dt); // 0x07743180
	System.Void CheckEffectPlay(); // 0x07743054
	System.Void OnActive(System.Boolean active); // 0x07743210
	System.Void Return(); // 0x077432d0
	System.Void .ctor(); // 0x07743410
	static System.Void .cctor(); // 0x07743498
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.FlameMonsterThrowerFxController : WizardGames.Soc.SocClient.Weapon.WeaponFxController
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Entity.MonsterEntity Monster; // 0x18
	WizardGames.Soc.Common.CustomType.WeaponCustom Weapon; // 0x20
	System.Boolean isSelf; // 0x28
	System.Boolean isFp; // 0x29
	WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent Opc; // 0x30
	Effect.EffectItemHandle<Effect.EffectItem> MuzzleEffectHandle; // 0x38
	Effect.EffectItemHandle<Effect.EffectItem> FireEffectHandle; // 0x48
	System.Boolean attacking; // 0x58
	System.Boolean valid; // 0x59
	static WizardGames.Soc.SocClient.Weapon.FlameMonsterThrowerFxController GetController(WizardGames.Soc.Common.Entity.MonsterEntity monster, WizardGames.Soc.Common.CustomType.WeaponCustom weapon, WizardGames.Soc.Common.Unity.Combat.ObjectPointComponent opc, System.Boolean self, System.Boolean isFp); // 0x0774356c
	System.Boolean get_Active(); // 0x077439ac
	System.Void Init(); // 0x07743698
	System.Void OnUpdate(System.Single dt); // 0x07743b84
	System.Void CheckEffectPlay(); // 0x07743a58
	System.Void OnActive(System.Boolean active); // 0x07743c14
	System.Void Return(); // 0x07743cd4
	System.Void .ctor(); // 0x07743e14
	static System.Void .cctor(); // 0x07743e9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.HeldItemEffectController : WizardGames.Soc.SocClient.Weapon.WeaponFxController
{
	static SocLogger logger; // 0x0
	Effect.EffectItemHandle<Effect.EffectItem> effectHandle; // 0x18
	System.Action<System.Boolean,Effect.EffectItem,System.Object> onEffectLoaded; // 0x28
	WizardGames.Soc.Common.Entity.IEntity Owner; // 0x30
	System.Boolean isFp; // 0x38
	static WizardGames.Soc.SocClient.Weapon.HeldItemEffectController GetController(UnityEngine.GameObject root, WizardGames.Soc.Common.Entity.IEntity owner, WizardGames.Soc.Common.Entity.IHeldItemEntity heldItem, System.String locator, System.Int32 effId, System.Boolean fp); // 0x07743f70
	System.Void Init(UnityEngine.GameObject root, WizardGames.Soc.Common.Entity.IHeldItemEntity heldItem, System.String locator, System.Int32 effId); // 0x07744098
	System.Void OnEffectLoaded(System.Boolean success, Effect.EffectItem effectItem, System.Object o); // 0x077445c8
	System.Boolean get_Active(); // 0x07744690
	System.Void OnActive(System.Boolean active); // 0x07744820
	System.Void OnUpdate(System.Single dt); // 0x07744918
	System.Void Return(); // 0x0774498c
	System.Void .ctor(); // 0x07744ab0
	static System.Void .cctor(); // 0x07744b38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.HeldItemLightController : WizardGames.Soc.SocClient.Weapon.WeaponFxController
{
	WizardGames.Soc.SocClient.ClientLight.LightItem light; // 0x18
	System.Boolean isSelf; // 0x20
	System.Boolean isFp; // 0x21
	System.Int32 lightId; // 0x24
	UnityEngine.Transform parent; // 0x28
	static WizardGames.Soc.SocClient.Weapon.HeldItemLightController GetController(UnityEngine.GameObject root, System.Boolean isSelf, System.String locator, System.Int32 lightId, System.Boolean isFp); // 0x07744c0c
	System.Void Init(UnityEngine.GameObject root, System.Boolean self, System.String locator, System.Int32 lightId, System.Boolean isFp); // 0x07744d0c
	System.Boolean get_Active(); // 0x07745220
	System.Void OnActive(System.Boolean active); // 0x077452f8
	System.Void QualityUpdate(); // 0x0774539c
	System.Void JudgeCreateLight(); // 0x07744e78
	System.Void OnUpdate(System.Single dt); // 0x07745438
	System.Void Return(); // 0x077454ac
	System.Void .ctor(); // 0x077455b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.JackhammerSFXController : WizardGames.Soc.SocClient.Weapon.WeaponFxController
{
	WizardGames.Soc.Common.Entity.PlayerEntity <Owner>k__BackingField; // 0x18
	WizardGames.Soc.Common.CustomType.MeleeCustom Jackhammer; // 0x20
	System.Boolean isOn; // 0x28
	System.Int64 subscribeId; // 0x30
	static WizardGames.Soc.SocClient.Weapon.JackhammerSFXController GetController(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.CustomType.MeleeCustom jackhammer); // 0x0774563c
	WizardGames.Soc.Common.Entity.PlayerEntity get_Owner(); // 0x0774589c
	System.Void set_Owner(WizardGames.Soc.Common.Entity.PlayerEntity value); // 0x07745900
	System.Boolean get_Active(); // 0x07745980
	System.Void Init(); // 0x0774576c
	System.Void OnAttackSubStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Byte o, System.Byte n); // 0x07745a58
	System.Void OnActive(System.Boolean active); // 0x07745e9c
	System.Void OnUpdate(System.Single dt); // 0x07745f2c
	System.Void ActiveHammer(System.Boolean active); // 0x07745c48
	System.Void Return(); // 0x07745fa0
	System.Void .ctor(); // 0x077460c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.PaddleWaterFxController : WizardGames.Soc.SocClient.Weapon.WeaponFxController
{
	WizardGames.Soc.Common.Entity.PlayerEntity <Owner>k__BackingField; // 0x18
	WizardGames.Soc.Common.CustomType.MeleeCustom Paddle; // 0x20
	UnityEngine.GameObject Go; // 0x28
	System.Boolean isFp; // 0x30
	System.Boolean hasEffect; // 0x31
	UnityEngine.Transform _paddleFxLocator1; // 0x38
	UnityEngine.Transform _paddleFxLocator2; // 0x40
	System.Boolean _fxLoc1IsInWater; // 0x48
	System.Boolean _fxLoc2IsInWater; // 0x49
	System.Boolean valid; // 0x4a
	static WizardGames.Soc.SocClient.Weapon.PaddleWaterFxController GetController(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.CustomType.MeleeCustom paddle, UnityEngine.GameObject go, System.Boolean isFp); // 0x07746150
	WizardGames.Soc.Common.Entity.PlayerEntity get_Owner(); // 0x07746614
	System.Void set_Owner(WizardGames.Soc.Common.Entity.PlayerEntity value); // 0x07746678
	System.Boolean get_Active(); // 0x077466f8
	System.Void Init(); // 0x077462b4
	System.Void OnVehicleTypeChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int32 oldValue, System.Int32 newValue); // 0x07746908
	System.Void OnUpdate(System.Single dt); // 0x07746b6c
	System.Void GeneratePaddleFx(UnityEngine.Vector3 pos); // 0x07746de0
	System.Void CheckFxPos(UnityEngine.Vector3& pos1, UnityEngine.Vector3& pos2); // 0x07746c34
	System.Boolean NeedFx(UnityEngine.Vector3 pos, System.Boolean& lastIsInWater); // 0x0774706c
	System.Void Return(); // 0x07747170
	System.Void logErr(System.String err); // 0x077469a4
	System.Void .ctor(); // 0x07747388
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.RfTransmitterController : WizardGames.Soc.SocClient.Weapon.WeaponFxController
{
	WizardGames.Soc.Common.Entity.PlayerEntity Owner; // 0x18
	WizardGames.Soc.Common.CustomType.MeleeCustom transmitter; // 0x20
	UnityEngine.GameObject Go; // 0x28
	System.Boolean valid; // 0x30
	UnityEngine.Transform Locator; // 0x38
	System.Boolean isFp; // 0x40
	System.Boolean hasAudio; // 0x41
	static WizardGames.Soc.SocClient.Weapon.RfTransmitterController GetController(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.CustomType.MeleeCustom transmitter, UnityEngine.GameObject go, System.Boolean isFp); // 0x07747410
	System.Void Init(); // 0x0774752c
	System.Void PlayerAttackSubStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase playerEntity, System.Byte oldValue, System.Byte newValue); // 0x07747778
	System.Void ActiveTransmitter(System.Boolean active); // 0x07747a34
	System.Boolean get_Active(); // 0x07747c30
	System.Void OnActive(System.Boolean active); // 0x07747d14
	System.Void OnUpdate(System.Single dt); // 0x07747dc0
	System.Void Return(); // 0x07747e34
	System.Void .ctor(); // 0x07747fc8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.ThrownWeaponEffectController : WizardGames.Soc.SocClient.Weapon.WeaponFxController
{
	System.Boolean valid; // 0x13
	WizardGames.Soc.Common.Entity.PlayerEntity Owner; // 0x18
	WizardGames.Soc.Common.CustomType.ThrowWeaponCustom thrown; // 0x20
	UnityEngine.GameObject targetGo; // 0x28
	UnityEngine.Animator animator; // 0x30
	System.Boolean isFp; // 0x38
	System.String attachSound; // 0x40
	UnityEngine.GameObject emitterGo; // 0x48
	System.Single showFuseFpxProgress; // 0x50
	Effect.EffectItemHandle<Effect.EffectItem> attachEffectHandle; // 0x58
	System.Boolean arriveShowFuseProgress; // 0x68
	static WizardGames.Soc.SocClient.Weapon.ThrownWeaponEffectController GetController(WizardGames.Soc.Common.Entity.PlayerEntity owner, WizardGames.Soc.Common.CustomType.ThrowWeaponCustom thrown, UnityEngine.GameObject root, UnityEngine.Animator aniamtor, System.Boolean isFp); // 0x07748050
	System.Boolean get_Active(); // 0x0774865c
	System.Void Init(); // 0x07748184
	System.Void OnActive(System.Boolean active); // 0x07748cfc
	System.Void OnUpdate(System.Single dt); // 0x07748df8
	System.Boolean CanShow(); // 0x077487e8
	System.Void ActiveEffect(System.Boolean active); // 0x07748b24
	System.Void Return(); // 0x07748e6c
	System.Void logErr(System.String err); // 0x0774895c
	System.Void .ctor(); // 0x07748fe0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.TimedBombFxController : WizardGames.Soc.SocClient.Weapon.WeaponFxController
{
	WizardGames.Soc.Common.Entity.PlayerEntity Owner; // 0x18
	WizardGames.Soc.Common.CustomType.ThrowWeaponCustom thrown; // 0x20
	UnityEngine.GameObject Go; // 0x28
	System.Boolean valid; // 0x30
	UnityEngine.Transform Locator; // 0x38
	static WizardGames.Soc.SocClient.Weapon.TimedBombFxController GetController(WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.CustomType.ThrowWeaponCustom thrown, UnityEngine.GameObject go); // 0x07749094
	System.Void Init(); // 0x07749194
	System.Boolean get_Active(); // 0x077492c8
	System.Void OnActive(System.Boolean active); // 0x07749350
	System.Void OnUpdate(System.Single dt); // 0x077493fc
	System.Void Return(); // 0x07749470
	System.Void .ctor(); // 0x07749568
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.TorchFpLightController : WizardGames.Soc.SocClient.Weapon.WeaponFxController
{
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer <MyPlayer>k__BackingField; // 0x18
	WizardGames.Soc.Common.Entity.PlayerEntity Owner; // 0x20
	WizardGames.Soc.Common.CustomType.MeleeCustom Torch; // 0x28
	UnityEngine.GameObject Go; // 0x30
	System.Boolean valid; // 0x38
	System.Int64 timer; // 0x40
	UnityEngine.Transform Locator; // 0x48
	System.Int64 timerForSound; // 0x50
	System.String startSound; // 0x58
	static WizardGames.Soc.SocClient.Weapon.TorchFpLightController GetController(WizardGames.Soc.Common.Syncronization.MgrMyPlayer player, WizardGames.Soc.Common.CustomType.MeleeCustom torch, UnityEngine.GameObject go); // 0x077495f0
	WizardGames.Soc.Common.Syncronization.MgrMyPlayer get_MyPlayer(); // 0x07749974
	System.Void set_MyPlayer(WizardGames.Soc.Common.Syncronization.MgrMyPlayer value); // 0x077499d8
	System.Void Init(); // 0x0774973c
	System.Boolean get_Active(); // 0x07749a58
	System.Void OnActive(System.Boolean active); // 0x07749afc
	System.Void OnUpdate(System.Single dt); // 0x07749fc8
	System.Void Return(); // 0x0774a03c
	System.Void .ctor(); // 0x0774a18c
	System.Void <OnActive>b__16_0(System.Int64 id, System.Object data, System.Boolean delete); // 0x0774a238
	System.Void <OnActive>b__16_1(System.Int64 id, System.Object data, System.Boolean delete); // 0x0774a3bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.WaterBottleAnimController : WizardGames.Soc.SocClient.Weapon.WeaponFxController
{
	WizardGames.Soc.SocClient.Player.HeldItem.PlayerFpHeldItemGo _go; // 0x18
	WizardGames.Soc.Common.CustomType.HeldItemCustom heldItem; // 0x20
	WizardGames.Soc.Common.CustomType.WaterBottleItemNode waterBottle; // 0x28
	WizardGames.Soc.Common.CustomType.StackableItemNode water; // 0x30
	UnityEngine.Transform jointWater; // 0x38
	UnityEngine.Transform empty; // 0x40
	UnityEngine.Transform full; // 0x48
	System.Int32 capacity; // 0x50
	System.Int32 lastWaterCount; // 0x54
	System.Int64 waterSubscriveId; // 0x58
	System.Action<WizardGames.Soc.Share.Framework.ECustomDictOpType,System.Int64,System.Int64> onBottleContentChange; // 0x60
	static WizardGames.Soc.SocClient.Weapon.WaterBottleAnimController GetController(WizardGames.Soc.SocClient.Player.HeldItem.PlayerFpHeldItemGo helditemgo, WizardGames.Soc.Common.CustomType.WaterBottleItemNode waterbottle); // 0x0774a4b0
	System.Void Init(WizardGames.Soc.SocClient.Player.HeldItem.PlayerFpHeldItemGo helditemgo, WizardGames.Soc.Common.CustomType.WaterBottleItemNode waterbottle); // 0x0774a580
	System.Boolean get_Active(); // 0x0774a9a4
	System.Void UpdateJointWater(System.Int32 newV); // 0x0774aa08
	System.Void OnUpdate(System.Single dt); // 0x0774ac88
	System.Void Return(); // 0x0774ad9c
	System.Void .ctor(); // 0x0774aecc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.WeaponAmmoDisplayController : WizardGames.Soc.SocClient.Weapon.WeaponFxController
{
	System.Boolean fp; // 0x13
	WizardGames.Soc.Common.Entity.PlayerEntity player; // 0x18
	WizardGames.Soc.Common.Entity.MonsterEntity monster; // 0x20
	UnityEngine.GameObject weaponGo; // 0x28
	UnityEngine.Transform ammoRoot; // 0x30
	WizardGames.Soc.Common.CustomType.WeaponCustom weapon; // 0x38
	System.Int32 usingAmmo; // 0x40
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Weapon.WeaponAmmoGO> ammos; // 0x48
	System.Boolean valid; // 0x50
	System.Boolean currentShowing; // 0x51
	System.Boolean HasOutputErrorLog; // 0x52
	System.Text.StringBuilder ErrorLogBuilder; // 0x58
	System.Action OnAmmoChange; // 0x60
	static WizardGames.Soc.SocClient.Weapon.WeaponAmmoDisplayController GetController(UnityEngine.GameObject weaponGo, WizardGames.Soc.Common.Entity.PlayerEntity player, WizardGames.Soc.Common.CustomType.WeaponCustom weapon, System.Boolean isFp, System.Action onAmmoChange); // 0x0774af54
	static WizardGames.Soc.SocClient.Weapon.WeaponAmmoDisplayController GetController(UnityEngine.GameObject weaponGo, WizardGames.Soc.Common.Entity.MonsterEntity monster, WizardGames.Soc.Common.CustomType.WeaponCustom weapon, System.Boolean isFp); // 0x0774b378
	System.Boolean get_Active(); // 0x0774b494
	System.Void Init(); // 0x0774b088
	System.Void OnActive(System.Boolean active); // 0x0774b640
	System.Void OnUpdate(System.Single dt); // 0x0774b900
	System.Boolean CanShow(); // 0x0774c004
	System.Void SetAmmoActive(System.Int32 ammoID, System.Boolean active); // 0x0774ba10
	System.Void UpdateAlpha(); // 0x0774c430
	System.Void Return(); // 0x0774c828
	System.Void CheckAmmoSound(System.Int32 ammoID, System.Boolean active); // 0x0774c2d8
	System.Void .ctor(); // 0x0774caf0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.WeaponAmmoGO : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	System.String modelPath; // 0x10
	UnityEngine.GameObject mainGo; // 0x18
	Effect.EffectItemHandle<Effect.EffectItem> effectHandle; // 0x20
	System.Boolean isFp; // 0x30
	System.Boolean clone; // 0x31
	System.Collections.Generic.List<UnityEngine.Renderer> ModelRenderers; // 0x38
	static WizardGames.Soc.SocClient.Weapon.WeaponAmmoGO CreateAccessoryGo(System.Int64 entityId, UnityEngine.Transform parent, System.Boolean isFp, WizardGames.Soc.Common.Data.bullet.BulletBase table); // 0x0774c1e4
	System.Void Init(System.Int64 entityId, UnityEngine.Transform parent, System.Boolean isFp, WizardGames.Soc.Common.Data.bullet.BulletBase table); // 0x0774cc08
	System.Void SetActive(System.Boolean active); // 0x0774b820
	System.Void UpdateAlpha(); // 0x0774c5e8
	System.Void ClearMaterialsClone(); // 0x0774d1b0
	System.Void OnFinishLoad(); // 0x0774cf74
	System.Void OnGet(); // 0x0774d250
	System.Void OnRelease(); // 0x0774d2b0
	System.Void OnDestroy(); // 0x0774d3d4
	System.Void .ctor(); // 0x0774d434
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.WeaponFxController : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	static SocLogger logger; // 0x0
	System.Boolean <LastActive>k__BackingField; // 0x10
	System.Boolean isDeployed; // 0x11
	System.Boolean isRendererVisible; // 0x12
	System.Boolean get_LastActive(); // 0x0774d4e8
	System.Void set_LastActive(System.Boolean value); // 0x0774d54c
	System.Boolean get_Active(); // 0x054c4760
	System.Void Update(System.Single dt); // 0x0774d5c8
	System.Void OnActive(System.Boolean active); // 0x07748d84
	System.Void OnUpdate(System.Single dt); // 0x05513724
	System.Void Release(); // 0x0774d74c
	System.Void Return(); // 0x055049cc
	System.Void OnGet(); // 0x0774d8e0
	System.Void OnRelease(); // 0x0774da80
	System.Void OnDestroy(); // 0x0774db24
	System.Void OnDeploy(); // 0x0774db84
	System.Void OnHolster(); // 0x0774dbec
	System.Void SetRendererVisible(System.Boolean visible); // 0x0774dc50
	System.Void .ctor(); // 0x0773d2b0
	static System.Void .cctor(); // 0x0774dccc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Weapon.MgrWeaponFxController : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Weapon.WeaponFxController> set; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Weapon.WeaponFxController> tmp; // 0x20
	System.Void Init(); // 0x0774dda0
	System.Threading.Tasks.Task OnExitWorld(); // 0x0774de00
	System.Void CleanUp(); // 0x0774e050
	System.Void Add(WizardGames.Soc.SocClient.Weapon.WeaponFxController controller); // 0x0774d98c
	System.Void Update(System.Single dt); // 0x0774e0c0
	System.Boolean Remove(WizardGames.Soc.SocClient.Weapon.WeaponFxController controller); // 0x0774d844
	System.Void Clear(); // 0x0774de70
	System.Void .ctor(); // 0x0774e194
}

// Client.Runtime
class WizardGames.Soc.SocClient.Water.MgrWater : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Water.MgrWater.EPlayerInWaterState playerInWaterState; // 0x14
	WizardGames.Soc.SocClient.Water.MgrWater.EPlayerSeeWaterState playerSeeWaterState; // 0x18
	System.Int32 RiverInteractiveId; // 0x1c
	System.Int32 SeaInteractiveId; // 0x20
	static WizardGames.Soc.SocClient.Water.WaterAction action; // 0x8
	UnityEngine.RaycastHit[] raycastHitResults; // 0x28
	System.Single lastDrinkTime; // 0x30
	System.Int64 lastRiverTime; // 0x38
	System.Int64 lastSeaTime; // 0x40
	UnityEngine.Vector3 seeRiverPos; // 0x48
	System.Boolean CanOpenRipple; // 0x54
	InteractiveRippleSystem WaterRippleSystem; // 0x58
	static System.Comparison<UnityEngine.RaycastHit> raycastHitDistanceComparison; // 0x10
	System.Void Init(); // 0x0774e290
	System.Void CleanUp(); // 0x0774e4d0
	System.Void UpdateWaterStateByRaycast(); // 0x0774e678
	System.Void UpdateWaterStateByPos(UnityEngine.Vector3 pos); // 0x0774ec08
	System.Void SetPlayerInWaterState(WizardGames.Soc.SocClient.Water.MgrWater.EPlayerInWaterState newState); // 0x0774f200
	System.Void SetPlayerSeeWaterState(WizardGames.Soc.SocClient.Water.MgrWater.EPlayerSeeWaterState newState); // 0x0774eb50
	System.Void SetWaterRippleSystemOpen(System.Boolean open); // 0x0774f424
	System.Void InitWaterRippleSystem(InteractiveRippleSystem waterRippleSystem); // 0x0774f574
	static System.Single BodyInWater(System.Int64 entityId); // 0x0774f688
	System.Void RegisterWaterAction(System.Action func); // 0x0774fb30
	System.Void UnRegisterWaterAction(System.Action func); // 0x0774fcb8
	static System.Void NotifyWaterAction(); // 0x0774f368
	System.Void .ctor(); // 0x0774ff04
	static System.Void .cctor(); // 0x0774ffe4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Water.MgrWater.EPlayerInWaterState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Water.MgrWater.EPlayerInWaterState Sea = 0;
	static WizardGames.Soc.SocClient.Water.MgrWater.EPlayerInWaterState River = 1;
	static WizardGames.Soc.SocClient.Water.MgrWater.EPlayerInWaterState Ground = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Water.MgrWater.EPlayerSeeWaterState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Water.MgrWater.EPlayerSeeWaterState Sea = 0;
	static WizardGames.Soc.SocClient.Water.MgrWater.EPlayerSeeWaterState River = 1;
	static WizardGames.Soc.SocClient.Water.MgrWater.EPlayerSeeWaterState NotWater = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Water.MgrWater.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Water.MgrWater.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x07750148
	System.Void .ctor(); // 0x077501ac
	System.Int32 <.cctor>b__30_0(UnityEngine.RaycastHit hit1, UnityEngine.RaycastHit hit2); // 0x07750214
}

// Client.Runtime
class WizardGames.Soc.SocClient.Water.WaterAction : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	System.Action action; // 0x20
	static WizardGames.Soc.SocClient.Water.WaterAction Generate(); // 0x0774fc40
	System.Void Init(System.Action action); // 0x077502d8
	System.Void Invoke(); // 0x0774fe8c
	System.Boolean IsAction(System.Action action); // 0x0774fe0c
	System.Void .ctor(); // 0x07750358
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Voice.JoinVoiceRoomType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Voice.JoinVoiceRoomType None = 0;
	static WizardGames.Soc.SocClient.Voice.JoinVoiceRoomType Team = 1;
	static WizardGames.Soc.SocClient.Voice.JoinVoiceRoomType Range = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Voice.GVoiceRegion : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Voice.GVoiceRegion HK = 0;
	static WizardGames.Soc.SocClient.Voice.GVoiceRegion SG = 1;
	static WizardGames.Soc.SocClient.Voice.GVoiceRegion US = 2;
	static WizardGames.Soc.SocClient.Voice.GVoiceRegion DE = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Voice.MgrVoice : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	static System.String EnableGVoiceWwisePluginKey; // 0x8
	System.String ServerBattleId; // 0x18
	System.String MyOpenId; // 0x20
	System.Int32 maxTeamMemberNum; // 0x28
	System.Int32 maxGlobalMemberNum; // 0x2c
	System.Collections.Generic.Dictionary<System.Int32,System.String> teamMemberId2OpenId; // 0x30
	System.Collections.Generic.Dictionary<System.String,System.Int32> teamMember2Speak; // 0x38
	System.Collections.Generic.Dictionary<System.String,System.Int32> globalOpenId2MemberId; // 0x40
	System.Collections.Generic.Dictionary<System.Int32,System.String> globalMemberId2OpenId; // 0x48
	System.Collections.Generic.HashSet<System.String> globalSpeakMember; // 0x50
	gcloud_voice.GVoice _gVoice; // 0x58
	System.Single checkVoiceTimer; // 0x60
	System.String CurrentTeamRoomName; // 0x68
	System.String CurrentGlobalRoomName; // 0x70
	System.String TryJoinTeamRoomName; // 0x78
	System.Boolean RetryJoinTeamRoom; // 0x80
	System.String TryJoinGlobalRoomName; // 0x88
	System.Boolean RetryJoinRangeRoom; // 0x90
	System.Int64 PollTimer; // 0x98
	gcloud_voice.EVoiceChatAttenuationModel AttenuationModel; // 0xa0
	System.Single VoiceMinDistance; // 0xa4
	System.Single VoiceMaxDistance; // 0xa8
	System.Single VoiceRollOff; // 0xac
	System.Int32 roomMicStatus; // 0xb0
	WizardGames.Soc.SocClient.Voice.JoinVoiceRoomType micType; // 0xb4
	System.Boolean IsHoldToTalk; // 0xb8
	System.Action JoinGlobalRoomComplete; // 0xc0
	System.Action RetryJoinTeamRoomSuccess; // 0xc8
	System.Action RetryJoinGlobalRoomSuccess; // 0xd0
	gcloud_voice.RoomMembers[] teamMembersArray; // 0xd8
	gcloud_voice.RoomMembers[] globalMembersArray; // 0xe0
	System.Collections.Generic.List<System.Int32> lastTeamRangeMemberIdList; // 0xe8
	System.Int64 checkTeamRoomTimeoutId; // 0xf0
	System.Int64 checkRangeRoomTimeoutId; // 0xf8
	System.Boolean isDisconnected; // 0x100
	System.String[] czOpenIds; // 0x108
	WizardGames.Soc.SocClient.ClientChatBanInfo voiceBan; // 0x110
	System.Boolean lastReportError; // 0x118
	System.Int32 GameUiMicSelect; // 0x11c
	System.Int32 GameUiSpeakerSelect; // 0x120
	System.Int32 RetryJoinTeamMicSelect; // 0x124
	System.Int32 RetryJoinRangeMicSelect; // 0x128
	System.Boolean isInLobby; // 0x12c
	System.Boolean RangeVoiceChatEnhanced; // 0x12d
	System.Boolean TeamVoiceChatEnhanced; // 0x12e
	System.Boolean VoiceMessageChatEnhanced; // 0x12f
	System.Single lastChatEnhancedStatus; // 0x130
	System.Boolean micEnable; // 0x134
	System.Boolean isShowRealtimeWeakTip; // 0x135
	WizardGames.Soc.SocClient.Ui.ELobbyTeamVoiceType curType; // 0x138
	System.String curWorldTeamId; // 0x140
	System.Boolean setPositionSuc; // 0x148
	System.Boolean setForwardSuc; // 0x149
	System.Boolean setUpwardSuc; // 0x14a
	System.Boolean hasPermissionCallback; // 0x14b
	System.Boolean permissionCallbackResult; // 0x14c
	System.Action<System.Boolean> m_RequestPermissionCallback; // 0x150
	System.Boolean lastOpenMic; // 0x158
	System.String recordFileDir; // 0x160
	gcloud_voice.SpeechLanguageType[] pTargetLangs; // 0x168
	System.Int32[] fileBytes; // 0x170
	System.Single[] seconds; // 0x178
	System.Collections.Generic.Dictionary<System.String,System.String> fileId2FileNameDic; // 0x180
	System.Boolean isPlayingRecordFile; // 0x188
	System.String curPlayRecordPath; // 0x190
	WizardGames.Soc.SocClient.Voice.MgrVoice.UploadRecordFileCompleteHandler OnUploadRecordFileCompleteHandler; // 0x198
	WizardGames.Soc.SocClient.Voice.MgrVoice.DownloadRecordFileCompleteHandler OnDownloadRecordFileCompleteHandler; // 0x1a0
	WizardGames.Soc.SocClient.Voice.MgrVoice.SpeechTranslateHandler OnSpeechTranslateHandler; // 0x1a8
	WizardGames.Soc.SocClient.Voice.MgrVoice.PlayRecordFilCompleteHandler OnPlayRecordFilCompleteHandler; // 0x1b0
	System.Security.Cryptography.SHA1 sha1; // 0x1b8
	System.Boolean get_isOverSea(); // 0x077503c0
	gcloud_voice.IGCloudVoice get__voiceEngine(); // 0x07750434
	System.Boolean get_HasJoinTeamRoom(); // 0x077504a8
	System.Boolean get_HasJoinGlobalRoom(); // 0x0775051c
	System.Boolean get_IsMyMicOpen(); // 0x07750590
	System.Boolean get_hasInit(); // 0x077505fc
	System.Void .ctor(); // 0x0775066c
	System.Void Init(); // 0x07750c9c
	System.Void Destroy(); // 0x07750f1c
	System.Void OnAccountLogined(); // 0x07751060
	System.Void OnDataUpdate(); // 0x077511bc
	System.Void QuitAllVoiceRoom(); // 0x0775166c
	System.Boolean IsVoiceBand(); // 0x07751ad8
	System.Void ShowBandTips(); // 0x07751b90
	System.Void SetBanInfo(System.Int64 endTime, System.Int32 reason); // 0x07751ca0
	System.Void JoinAllVoiceRoom(); // 0x07751da8
	System.Threading.Tasks.Task OnEnterWorld(); // 0x07752234
	System.Threading.Tasks.Task OnExitWorld(); // 0x077527d4
	System.Void OnFastReconnected(); // 0x077529b0
	System.Void OnFastDisconnected(WizardGames.Soc.Common.Framework.Network.DisconnectReason reason); // 0x07752a18
	System.Void InitVoiceEngine(); // 0x07752a98
	static System.Void StartRecordingStatic(); // 0x0775467c
	static System.Void StopRecordingStatic(System.Int32 code); // 0x07754a6c
	System.Void OnEvent(gcloud_voice.GCloudVoiceEvent code, System.String info); // 0x07754de0
	System.Void EnableLog(System.Boolean enable); // 0x07753e5c
	System.Void SetVoiceEngine(gcloud_voice.IGCloudVoice engine); // 0x077535f8
	System.Void SetAppInfo(System.String appId, System.String appKey, System.String openId); // 0x077536e4
	System.Void SetOverseaVoiceRegion(System.Int32 voiceRegion); // 0x07755018
	System.Void SetServerUrl(System.String url); // 0x077539e4
	System.Void InitEngine(); // 0x07753c84
	System.Void Update(System.Int32 timeSinceLastUpdate); // 0x055056e8
	System.Void UpdateChatEnhanced(); // 0x077559c8
	System.Void SetChatEnhancedRTPCValue(System.Single rtpcValue); // 0x07750df0
	System.Void Update3d(); // 0x07755b48
	System.Void JoinTeamRoom(System.Boolean isRetryJoinRoom); // 0x07751fe4
	System.Void JoinWorldTeamRoom(System.Boolean isRetryJoinRoom); // 0x077585dc
	System.Void JoinWorldTeamRoom(System.Boolean isRetryJoinRoom, WizardGames.Soc.SocClient.Ui.ELobbyTeamVoiceType type); // 0x05523ad0
	System.Void QuitWorldTeamRoom(System.Boolean autoJoiinOther, WizardGames.Soc.SocClient.Ui.ELobbyTeamVoiceType ctype); // 0x077523f4
	System.Void JoinTeamRoom(System.String roomName, System.Boolean isRetryJoinRoom); // 0x0552af28
	System.Void CheckJoinTeamRoomTimeout(System.Int64 timerid, System.Object data, System.Boolean delete); // 0x077588d0
	System.Void SetMode(gcloud_voice.GCloudVoiceMode mode); // 0x07754000
	System.Void EnableMultiRoom(System.Boolean enable); // 0x07754264
	System.Void JoinRangeRoom(System.Boolean isRetryJoinRoom); // 0x07751e74
	System.Void JoinRangeRoom(System.String roomName, System.Boolean isRetryJoinRoom); // 0x07758a78
	System.Void CheckJoinRangeRoomTimeout(System.Int64 timerid, System.Object data, System.Boolean delete); // 0x077590d4
	System.Void Enable3DVoice(System.Boolean enable); // 0x0775927c
	System.Void Enable3DVoiceRoom(System.String roomName, System.Boolean enable); // 0x077570b4
	System.Void Set3DPosition(gcloud_voice.GVoice3DVector pos); // 0x077579d8
	System.Void Set3DForward(gcloud_voice.GVoice3DVector forward); // 0x07757bc4
	System.Void Set3DUpward(gcloud_voice.GVoice3DVector upward); // 0x07757db0
	System.Void Set3dDistProperties(gcloud_voice.EVoiceChatAttenuationModel model, System.Single minDistance, System.Single maxDistance, System.Single rolloff); // 0x07751388
	System.Void OnJoinRoomComplete(gcloud_voice.GCloudVoiceCompleteCode code, System.String roomName, System.Int32 memberID); // 0x0550fdd0
	System.Void SetTeamMemberVolume(); // 0x07759f38
	System.Void ForbidTeamMemberVoiceInRange(System.Boolean enable); // 0x07759aa0
	System.Int32 TestMic(); // 0x0775ad78
	System.Void TryOpenMic(System.Action<System.Boolean> permissionGrantedAction); // 0x0775ae08
	System.Void OpenMic(); // 0x07759638
	System.Void DisableAllRoomMic(); // 0x055049cc
	System.Void EnableRoomMicrophone(WizardGames.Soc.SocClient.Voice.JoinVoiceRoomType roomType, System.Boolean enable, System.Boolean needLog); // 0x0550f828
	System.Void EnableRoomSpeaker(WizardGames.Soc.SocClient.Voice.JoinVoiceRoomType roomType, System.Boolean enable, System.Boolean needLog); // 0x0550f828
	System.Void CloseMic(); // 0x0775b140
	System.Void OpenSpeaker(); // 0x07759460
	System.Void CloseSpeaker(); // 0x0775b318
	System.Void SetMicEnable(System.Boolean enable); // 0x0775b4f0
	System.Void SetPlayerVolume(System.String openId, System.UInt32 volume); // 0x0775a8b8
	System.Void SetSpeakerVolume(System.Int32 volume); // 0x0775b56c
	System.Void SetMicVolume(System.Int32 volume); // 0x0775b75c
	System.Void SetReportBufferTime(System.Int32 nTimeSec); // 0x07754498
	System.Void EnableReportALLAbroad(); // 0x0775a248
	System.Void EnableReportAll(); // 0x0775a424
	System.Void ReportAllPlayers(System.Boolean isLobby); // 0x0775b974
	System.Void QuitRoom(WizardGames.Soc.SocClient.Voice.JoinVoiceRoomType roomType); // 0x07751744
	System.Void OnQuitRoomComplete(gcloud_voice.GCloudVoiceCompleteCode code, System.String roomName, System.Int32 memberID); // 0x0775bfa4
	System.Void ClearTeamInfos(); // 0x0775c278
	System.Void ClearGlobalInfos(); // 0x0775c348
	System.Void OnDetectMemberVoice(System.String roomName, System.Int32 member, System.Int32 status); // 0x077565b0
	System.Int32 TryGetMemberVoiceState(System.String openId); // 0x0775c43c
	System.Boolean IsSpeaking(); // 0x07757358
	System.Boolean HasTeamMemberSpeaking(); // 0x07757400
	System.Boolean HasGlobalMemberSpeaking(); // 0x07757608
	System.Int32 DetectMyMic(); // 0x0775c554
	System.Void RoomMemberChangedCompleteHandler(gcloud_voice.GCloudVoiceCompleteCode code, System.String roomName, System.Int32 memberID, System.String openID); // 0x0775c5e0
	System.Void OnStatusUpdate(gcloud_voice.GCloudVoiceCompleteCode code, System.String roomname, System.Int32 memberid); // 0x0775cb0c
	System.Void OnApplyMessageKeyComplete(gcloud_voice.GCloudVoiceCompleteCode code); // 0x0775cd28
	System.Void OnReportPlayer(gcloud_voice.GCloudVoiceCompleteCode code, System.String strinfo); // 0x0775cee4
	System.Void OnSTTReport(gcloud_voice.GCloudVoiceCompleteCode code, System.String transtext, System.String openid, System.String fileid); // 0x0775d254
	System.Void ShowReportTip(gcloud_voice.GCloudVoiceCompleteCode code); // 0x0775cf90
	System.Void ShowReportErrorTip(gcloud_voice.GCloudVoiceErr code); // 0x0775bccc
	System.Void ForbidMemberVoice(System.Int32 member, System.Boolean enable, System.String roomName); // 0x0775aab8
	System.Void GetAllTeamMemberIds(); // 0x0775985c
	System.Int32 GetPlayerMicState(System.String openId); // 0x0775d320
	System.Void GetAllGlobalMemberIds(); // 0x0775a600
	System.Void OnApplicationPause(System.Boolean pauseStatus); // 0x0775d41c
	System.Void InitLobbyVoiceState(); // 0x077510d0
	static System.String get_RetryJoinRangeSpeakerSelect(); // 0x0775d4e0
	System.Void OpenGlobalSpeakerClick(); // 0x055049cc
	static System.String get_RetryJoinTeamSpeakerSelect(); // 0x0775d734
	System.Void OpenTeamSpeakerClick(); // 0x055049cc
	System.Void CloseSpeakerClick(); // 0x055049cc
	System.Void OpenGlobalMicroClick(); // 0x0775db20
	System.Void OpenTeamMicroClick(); // 0x0775dc14
	System.Void CloseMicClick(); // 0x0775dd3c
	System.Void OpenTeamMicroInternal(System.Boolean isSuccess); // 0x05523a7c
	System.Void OpenGlobalMicroInternal(System.Boolean isSuccess); // 0x05523a7c
	System.Void SwitchHoldTeamMicro(); // 0x0775e3cc
	System.Void SwitchHoldTeamMicroInternal(System.Boolean isSuccess); // 0x0775e4f4
	System.Void SwitchHoldGlobalMicro(); // 0x0775e760
	System.Void SwitchHoldGlobalMicroInternal(System.Boolean isSuccess); // 0x0775e854
	System.String GenerateShortFilename(System.String originalId); // 0x0775eac4
	System.Char ToHexChar(System.Int32 value); // 0x0775ed88
	System.Void StartRecordingOnGameBot(); // 0x0775470c
	System.Boolean StopRecording(); // 0x054c4760
	System.Void StopRecordingOnGameBot(System.Int32 code); // 0x055056e8
	System.Boolean UploadRecordedFile(WizardGames.Soc.SocClient.Voice.MgrVoice.UploadRecordFileCompleteHandler uploadComplete); // 0x0775f0e0
	System.Void DownloadRecordedFile(System.String fileId, WizardGames.Soc.SocClient.Voice.MgrVoice.DownloadRecordFileCompleteHandler downloadComplete); // 0x0775f2e8
	System.Boolean PlayRecordedFile(System.String fileId, WizardGames.Soc.SocClient.Voice.MgrVoice.PlayRecordFilCompleteHandler playComplete, System.Boolean autoDownload); // 0x0775f4f8
	System.Void StopPlayFile(); // 0x0775f8b4
	System.Boolean TryGetRecordFileLength(System.String fileId, System.Single& second); // 0x0775fa4c
	System.Void OnUploadRecordFileComplete(gcloud_voice.GCloudVoiceCompleteCode code, System.String filepath, System.String fileid); // 0x0775fe08
	System.Void OnDownloadRecordFileComplete(gcloud_voice.GCloudVoiceCompleteCode code, System.String filepath, System.String fileid); // 0x07760158
	System.Void OnPlayRecordFilComplete(gcloud_voice.GCloudVoiceCompleteCode code, System.String filepath); // 0x0776041c
	System.Void OnSpeechTranslate(gcloud_voice.GCloudVoiceCompleteCode ncode, System.String srctext, System.String targettext, System.String targetfileid, System.Int32 srcfileduration); // 0x07760624
	static System.Void .cctor(); // 0x07760968
}

// Client.Runtime
class WizardGames.Soc.SocClient.Voice.MgrVoice.UploadRecordFileCompleteHandler : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x07760b98
	System.Void Invoke(System.Boolean uploadResult, System.String fileid); // 0x07760c60
}

// Client.Runtime
class WizardGames.Soc.SocClient.Voice.MgrVoice.DownloadRecordFileCompleteHandler : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x07760cbc
	System.Void Invoke(System.Boolean downloadResult); // 0x07760d84
}

// Client.Runtime
class WizardGames.Soc.SocClient.Voice.MgrVoice.SpeechTranslateHandler : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x07760dd0
	System.Void Invoke(System.Boolean translateResult, System.String translatedText, System.Single seconds); // 0x07760e98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Voice.MgrVoice.PlayRecordFilCompleteHandler : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x07760f04
	System.Void Invoke(); // 0x07760fc8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Voice.MgrVoice.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Voice.MgrVoice.<>c <>9; // 0x0
	static gcloud_voice.IGCloudVoiceNotify.StreamSpeechToTextHandler <>9__84_0; // 0x8
	static System.Void .cctor(); // 0x0776100c
	System.Void .ctor(); // 0x07761070
	System.Void <InitVoiceEngine>b__84_0(gcloud_voice.GCloudVoiceCompleteCode code, System.Int32 error, System.String result, System.String path); // 0x077610d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Voice.MgrVoice.<>c__DisplayClass130_0 : System.Object
{
	System.Action<System.Boolean> permissionGrantedAction; // 0x10
	System.Action<System.Boolean> <>9__1; // 0x18
	System.Void .ctor(); // 0x077612a8
	System.Void <TryOpenMic>b__0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x07761310
	System.Void <TryOpenMic>b__1(System.Boolean result); // 0x07761448
}

// Client.Runtime
class WizardGames.Soc.SocClient.Voice.MgrVoice.<>c__DisplayClass214_0 : System.Object
{
	WizardGames.Soc.SocClient.Voice.MgrVoice <>4__this; // 0x10
	System.String fileId; // 0x18
	WizardGames.Soc.SocClient.Voice.MgrVoice.PlayRecordFilCompleteHandler playComplete; // 0x20
	System.Void .ctor(); // 0x077614dc
	System.Void <PlayRecordedFile>b__0(System.Boolean downloadResult); // 0x07761544
}

// Client.Runtime
class WizardGames.Soc.SocClient.Voice.MgrVoice.<>c__DisplayClass217_0 : System.Object
{
	WizardGames.Soc.SocClient.Voice.MgrVoice <>4__this; // 0x10
	System.String filePath; // 0x18
	System.Void .ctor(); // 0x077615e4
	System.Void <TryGetRecordFileLength>b__0(System.Boolean downloadResult); // 0x0776164c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Vehcle.MgrTrain : WizardGames.Soc.Common.Manager.MgrBase
{
	
	System.Void Init(); // 0x077618e8
	System.Void CleanUp(); // 0x07761950
	System.Void .ctor(); // 0x077619b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Utility.ClientDamageUtil : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.SocClient.Utility.ClientDamageUtil _instance; // 0x8
	System.Single duration; // 0x30
	System.Single radius; // 0x34
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Utility.ClientDamageUtil.DamageHitInfo> hitInfos; // 0x38
	UnityEngine.Pool.ObjectPool<UnityEngine.GameObject> spherePool; // 0x40
	UnityEngine.Pool.ObjectPool<UnityEngine.GameObject> cubePool; // 0x48
	static WizardGames.Soc.SocClient.Utility.ClientDamageUtil get_Instance(); // 0x07761a20
	static System.Void ProjectileHitDebug(WizardGames.Soc.Common.DebugGroup.DebugParameter debugParameter, UnityEngine.Vector3 pos, UnityEngine.Color color, System.Boolean isServer, System.String name); // 0x07761b84
	static UnityEngine.GameObject CreateSphere(); // 0x07762058
	static UnityEngine.GameObject CreateCube(); // 0x07762120
	System.Void Update(); // 0x077621e8
	System.Void .ctor(); // 0x077623e0
	static System.Void .cctor(); // 0x077625e8
	System.Boolean <Update>b__13_0(WizardGames.Soc.SocClient.Utility.ClientDamageUtil.DamageHitInfo info); // 0x077626bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Utility.ClientDamageUtil.DamageHitInfo : System.Object
{
	System.Single DeltaTime; // 0x10
	UnityEngine.Color Color; // 0x14
	UnityEngine.Vector3 Position; // 0x24
	UnityEngine.GameObject Prefab; // 0x30
	UnityEngine.Pool.ObjectPool<UnityEngine.GameObject> Pool; // 0x38
	System.Void .ctor(); // 0x07761ff0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Utility.ClientHeldItemUtil : System.Object
{
	static SocLogger logger; // 0x0
	static System.Boolean TryGetAccessoryHangPoint(WizardGames.Soc.SocClient.Weapon.IAccessoryHost host, WizardGames.Soc.Common.CustomType.WeaponCustom weapon, System.Int64 accId, System.String& point); // 0x0776280c
	static System.Int32 TryAttachAccessoryGoToTarget(UnityEngine.Transform accessory, UnityEngine.Transform target, System.String hangPointName, UnityEngine.Vector3 scale); // 0x07762c74
	static System.Void BindAccessoryHandle(WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom acc, WizardGames.Soc.SocClient.Weapon.IAccessoryChangeHandle handle); // 0x07763198
	static System.Void UnBindAccessoryHandle(WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom acc, WizardGames.Soc.SocClient.Weapon.IAccessoryChangeHandle handle); // 0x07763428
	static System.Boolean TryAttachAccessoryGoToTarget(UnityEngine.Transform accessory, UnityEngine.Transform target, UnityEngine.Vector3 scale); // 0x077636b8
	static System.Void CheckPartModel(System.Int64 weaponId, System.Int64 skinId, UnityEngine.Transform root, System.Collections.Generic.List<System.Int64> hasPart); // 0x07763b00
	static System.Boolean SilencerSelector(WizardGames.Soc.Common.CustomType.WeaponAccessoryItemCustom entity); // 0x07764028
	static System.Single GetADSTransitionLerp(System.Single maxlerp, System.Single transitiontime, WizardGames.Soc.SocClient.Player.IADSTransition transition); // 0x077640ac
	static System.Void .cctor(); // 0x07764214
}

// Client.Runtime
class WizardGames.Soc.SocClient.Utility.FpsCounter : UnityEngine.MonoBehaviour
{
	WizardGames.Soc.Common.Utility.Counter _counter; // 0x30
	System.DateTime _lastUpdate; // 0x38
	UnityEngine.UI.Text Label; // 0x40
	System.Void Update(); // 0x077642e8
	System.Void .ctor(); // 0x077646f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Utility.GameObjectUtil : System.Object
{
	static System.Collections.Generic.List<UnityEngine.MeshRenderer> tmp; // 0x0
	static T GetOrAddComponent<T>(UnityEngine.GameObject go); // 0x052af1f0
	static T GetOrAddComponent<T>(UnityEngine.Component component); // 0x052af1f0
	static System.Void .cctor(); // 0x07764794
}

// Client.Runtime
class WizardGames.Soc.SocClient.Utility.GenericGridManager : System.Object
{
	UnityEngine.Vector2 origin; // 0x10
	System.Int32 gridSize; // 0x18
	System.Int32 fullSize; // 0x1c
	System.Int32 gridCnt; // 0x20
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int64>> gridIndex2Elements; // 0x28
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> lookupTable; // 0x30
	System.Void .ctor(UnityEngine.Vector2 origin, System.Int32 gridSize, System.Int32 fullSize); // 0x0776482c
	System.Void Clear(); // 0x077649ec
	System.Int32 Add(WizardGames.Soc.SocClient.Utility.IGridElement e); // 0x07764c58
	System.Void Remove(WizardGames.Soc.SocClient.Utility.IGridElement e); // 0x077652a0
	System.Int32 Update(WizardGames.Soc.SocClient.Utility.IGridElement e); // 0x07765594
	System.Int32 CalculateGridIndexByPos(System.Single xWorldPos, System.Single yWorldPos); // 0x0776510c
	System.Int32 GetGridIndexElementBelongs(WizardGames.Soc.SocClient.Utility.IGridElement e); // 0x077657c4
	System.Void GetNearbyGridIndexes(System.Int32 targetIndex, System.Collections.Generic.List<System.Int32>& nearbyGridIndexes, System.Int32 step); // 0x077658ec
	System.Collections.Generic.List<System.Int64> GetGridElements(System.Int32 gridIndex); // 0x07765ac0
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Utility.IGridElement : 
{
	
	System.Int64 get_GridUniqueId(); // 0x054a4380
	System.Single get_WorldPosX(); // 0x054a5abc
	System.Single get_WorldPosZ(); // 0x054a5abc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Utility.InteractionUtil : System.Object
{
	static SocLogger logger; // 0x0
	static System.Single get_InteractionDistance(); // 0x07765b6c
	static System.Boolean CanCollectWater(); // 0x07765c4c
	static System.Boolean TryInteract(WizardGames.Soc.Common.Data.PlayerInteractiveId interactiveId, System.Int64 targetId); // 0x07766034
	static System.Boolean TryInteract(System.Int32 interactiveId, System.Int64 targetId); // 0x077660d4
	static System.Void StopInteract(WizardGames.Soc.Common.Data.PlayerInteractiveId interactive); // 0x07765f44
	static System.Void TryShowInteractiveProgress(WizardGames.Soc.Common.Entity.IHeldItemEntity helditem, System.Int32 ms, WizardGames.Soc.Common.Data.PlayerInteractiveId currentId); // 0x077662a4
	static System.Void .cctor(); // 0x077667b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Utility.InteractionUtil.<>c__DisplayClass7_0 : System.Object
{
	WizardGames.Soc.Common.Data.PlayerInteractiveId currentId; // 0x10
	System.Void .ctor(); // 0x07766748
	System.Void <TryShowInteractiveProgress>b__0(); // 0x07766884
}

// Client.Runtime
class WizardGames.Soc.SocClient.Utility.LobbyUtility : System.Object
{
	static SocLogger logger; // 0x0
	static System.Void SetPlayerExperienceGrade(System.Int32 score1, System.Int32 score2, System.Int32 score3); // 0x07766910
	static System.Void .cctor(); // 0x07766f70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Utility.LobbyUtility.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Utility.LobbyUtility.<>c <>9; // 0x0
	static System.Action<SimpleJSON.JSONNode> <>9__1_0; // 0x8
	static System.Void .cctor(); // 0x07767044
	System.Void .ctor(); // 0x077670a8
	System.Void <SetPlayerExperienceGrade>b__1_0(SimpleJSON.JSONNode ret); // 0x07767110
}

// Client.Runtime
class WizardGames.Soc.SocClient.Utility.DeviceInfo : System.Object
{
	System.String outerIp; // 0x10
	System.String osSystem; // 0x18
	System.String language; // 0x20
	System.Int32 scene; // 0x28
	System.String deviceId; // 0x30
	System.String qimei36; // 0x38
	System.String deviceModal; // 0x40
	System.String deviceVersion; // 0x48
	System.String deviceManufacturer; // 0x50
	System.String deviceLevel; // 0x58
	System.String clientVersion; // 0x60
	System.String telecomOper; // 0x68
	System.String country; // 0x70
	System.String systemSoftware; // 0x78
	System.String systemHardware; // 0x80
	System.String network; // 0x88
	System.Int32 ping; // 0x90
	System.String cpuHardware; // 0x98
	System.Int32 memory; // 0xa0
	System.String openGLRender; // 0xa8
	System.String openGLVersion; // 0xb0
	System.String ToJson(); // 0x077671d0
	System.Void .ctor(); // 0x07767238
}

// Client.Runtime
class WizardGames.Soc.SocClient.Utility.SystemUtil : System.Object
{
	static SocLogger logger; // 0x0
	static System.String wanIP; // 0x8
	static WizardGames.Soc.SocClient.Utility.DeviceInfo <CurInfo>k__BackingField; // 0x10
	static System.Boolean <IsGettingInfo>k__BackingField; // 0x18
	static System.Collections.Generic.HashSet<UnityEngine.Rendering.GraphicsDeviceType> OpenGLGraphicsDeviceTypes; // 0x20
	static System.Text.StringBuilder _sb; // 0x28
	static WizardGames.Soc.SocClient.Utility.DeviceInfo get_CurInfo(); // 0x077672a0
	static System.Boolean get_IsGettingInfo(); // 0x07767328
	static System.Void set_IsGettingInfo(System.Boolean value); // 0x077673b0
	static System.Threading.Tasks.Task<System.String> GetWanIp(); // 0x07767444
	static System.String GetLanguage(); // 0x07767568
	static System.String GetManufacturer(); // 0x07767624
	static System.Boolean IsOpenGLGraphicsDeviceType(); // 0x07767760
	static System.Threading.Tasks.Task<WizardGames.Soc.SocClient.Utility.DeviceInfo> PrepareDeviceInfo(); // 0x0776781c
	static System.String GetDeviceInfoString(System.Action<WizardGames.Soc.SocClient.Utility.DeviceInfo> modify); // 0x0776793c
	static System.String GetPlatformStr(); // 0x07767ac0
	static System.Int32 GetPlatformInt(); // 0x07767b30
	static System.Void .cctor(); // 0x07767b8c
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Utility.SystemUtil.<GetWanIp>d__14 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.String> <>t__builder; // 0x18
	UnityEngine.Networking.UnityWebRequest <webRequest>5__2; // 0x30
	UnityEngine.Networking.UnityWebRequestAsyncOperation <op>5__3; // 0x38
	System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1; // 0x40
	System.Void MoveNext(); // 0x07767dc4
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x077684a0
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Utility.SystemUtil.<PrepareDeviceInfo>d__19 : System.ValueType, System.Runtime.CompilerServices.IAsyncStateMachine
{
	System.Int32 <>1__state; // 0x10
	System.Runtime.CompilerServices.AsyncTaskMethodBuilder<WizardGames.Soc.SocClient.Utility.DeviceInfo> <>t__builder; // 0x18
	WizardGames.Soc.SocClient.Utility.DeviceInfo <>7__wrap1; // 0x30
	System.Runtime.CompilerServices.TaskAwaiter<System.String> <>u__1; // 0x38
	WizardGames.Soc.Common.Unity.Utility.SocPing <ping>5__3; // 0x40
	System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__2; // 0x48
	System.Void MoveNext(); // 0x07768558
	System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine); // 0x07769aa8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.ClusterHandler : System.Object
{
	SocLogger log; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Marker.IClusterMarker> clusterMarkers; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Marker.MarkerCluster> clusters; // 0x20
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Marker.IClusterMarker,WizardGames.Soc.SocClient.Marker.MarkerCluster> marker2ClusterLookup; // 0x28
	WizardGames.Soc.SocClient.Marker.IClusterMarkerStage stage; // 0x30
	System.Void .ctor(WizardGames.Soc.SocClient.Marker.IClusterMarkerStage stage); // 0x07769b60
	System.Boolean OnMarkerCreate(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x07769d84
	System.Void OnMarkerRemove(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0776a2d0
	System.Boolean JoinMarkerToCluster(WizardGames.Soc.SocClient.Marker.IClusterMarker marker, WizardGames.Soc.SocClient.Marker.MarkerCluster excludedCluster); // 0x07769f44
	System.Boolean ChangeMarkerPos(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0776a6b4
	System.Void RemoveMarkerFromCluster(WizardGames.Soc.SocClient.Marker.IClusterMarker marker); // 0x0776a3dc
	System.Void RebuildCluster(); // 0x0776a9e0
	System.Void UpdateClustersContainerPos(); // 0x0776ae94
	WizardGames.Soc.SocClient.Marker.MarkerCluster GetCluster(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0776b004
	System.Void Clear(); // 0x0776acc8
	System.Void Destroy(); // 0x0776b0e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.FilterHandler : System.Object
{
	WizardGames.Soc.SocClient.Marker.IFilterMarkerStage stage; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Marker.IFilterMarker> filterMarkers; // 0x18
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.Common.Data.MarkerType>> filterTypeMap; // 0x20
	System.Collections.Generic.List<System.Int32> curFilterGroups; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.MarkerType> curFilterTypes; // 0x30
	System.Void .ctor(WizardGames.Soc.SocClient.Marker.IFilterMarkerStage stage); // 0x0776b154
	System.Void OnMarkerCreate(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0776ba98
	System.Void OnMarkerRemove(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0776c0dc
	System.Void Refresh(System.Collections.Generic.List<System.Int32> groupIds); // 0x0776c1dc
	System.Void UpdateMarkerFilterStatus(WizardGames.Soc.SocClient.Marker.IFilterMarker marker); // 0x0776bcc8
	System.Void InitFilterTypeMap(); // 0x0776b338
	System.Void InitFilterType(); // 0x0776b714
	System.Void Destroy(); // 0x0776c6d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.FovHandler : System.Object
{
	WizardGames.Soc.SocClient.Marker.IMarkerStage stage; // 0x10
	WizardGames.Soc.SocClient.Utility.GenericGridManager gridManager; // 0x18
	System.Collections.Generic.List<System.Int32> nearbyGridCaches; // 0x20
	System.Int32 currentGrid; // 0x28
	System.Void .ctor(WizardGames.Soc.SocClient.Marker.IMarkerStage stage, System.Int32 fovSize); // 0x0776c7c0
	System.Void Destroy(); // 0x0776cb58
	System.Void OnMarkerCreate(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0776cbf0
	System.Void OnMarkerRemove(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0776cd30
	System.Void ChangeMarkerPos(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0776cdec
	System.Void UpdateFov(); // 0x0776cf84
	System.Void RefreshNearbyMarkers(System.Int32 currentIndex); // 0x0776d0b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.HudDirectionHandler : System.Object
{
	SocLogger log; // 0x10
	System.Single disOfAnchor; // 0x18
	WizardGames.Soc.SocClient.Marker.IMarkerStage stage; // 0x20
	System.Collections.Generic.Dictionary<FairyGUI.GComponent,WizardGames.Soc.SocClient.Marker.IMarker> orderedMarkersMap; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Marker.IMarker> orderedMarkers; // 0x30
	System.Collections.Generic.HashSet<WizardGames.Soc.SocClient.Marker.IMarker> showMarkers; // 0x38
	System.Int32 frameCheckIndex; // 0x40
	System.Collections.Generic.HashSet<System.Int64> markerIdsIsInitHide; // 0x48
	System.Void .ctor(WizardGames.Soc.SocClient.Marker.IMarkerStage stage, System.Single disOfAngel); // 0x0776d974
	System.Void OnMarkerCreate(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0776dc00
	System.Void OnMarkerRemove(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0776e550
	System.Void Update(); // 0x0776ea74
	System.Void RefreshAllMarkerPos(); // 0x0776ead8
	System.Boolean _RefreshMarkerXY(WizardGames.Soc.SocClient.Marker.IMarker marker, UnityEngine.Transform selfTransform, UnityEngine.Vector3 cameraPos); // 0x0776f5bc
	System.Boolean _CheckMarkerVisibleTick(WizardGames.Soc.SocClient.Marker.IMarker marker, UnityEngine.Vector3 cameraPos); // 0x0776f04c
	System.Boolean _CheckMarkerVisibleBase(WizardGames.Soc.SocClient.Marker.IMarker marker, UnityEngine.Vector3 cameraPos); // 0x0776fac4
	System.Void Destroy(); // 0x0776fcc4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.HudPositionHandler : System.Object
{
	SocLogger log; // 0x10
	UnityEngine.Vector2 limitRangeCenterLocal; // 0x18
	FairyGUI.GComponent markerContainer; // 0x20
	FairyGUI.GComponent visualBorder; // 0x28
	System.Collections.Generic.Dictionary<FairyGUI.GComponent,WizardGames.Soc.SocClient.Marker.IMarker> orderedMarkersMap; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Marker.IMarker> orderedMarkers; // 0x38
	System.Int32 frameCheckIndex; // 0x40
	UnityEngine.Transform myPlayerTransform; // 0x48
	UnityEngine.Transform playerCameraTransform; // 0x50
	System.Single semiMajorAxis; // 0x58
	System.Single semiMinorAxis; // 0x5c
	System.Single semiMajorAxisSquared; // 0x60
	System.Single semiMinorAxisSquared; // 0x64
	System.Boolean CheckMarkerVisible(WizardGames.Soc.SocClient.Marker.IMarker marker, UnityEngine.Vector3 cameraPos); // 0x0776fdd8
	System.Boolean CheckMarkerVisibleBase(WizardGames.Soc.SocClient.Marker.IMarker marker, UnityEngine.Vector3 cameraPos); // 0x07770514
	System.Void .ctor(FairyGUI.GComponent markerContainer, FairyGUI.GComponent visualBorder); // 0x077707cc
	System.Void OnMarkerCreate(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x07770ab0
	System.Void OnMarkerRemove(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x07771194
	System.Void OnFps10Update(); // 0x0777155c
	System.Void OnFpsUnlimitedUpdate(); // 0x077718b0
	System.Void RefreshMarkerVisible(); // 0x077716b0
	System.Void RefreshAllMarkerPos(); // 0x07771914
	System.Boolean RefreshMarkerXY(WizardGames.Soc.SocClient.Marker.IMarker marker, UnityEngine.Transform cameraTransform); // 0x07771bf4
	System.Void CheckMarkerInScreenCenter(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x07772794
	System.Void Destroy(); // 0x07772e48
	System.Void CachePoints(); // 0x07772f10
	UnityEngine.Vector2 GetWithInLimitRangePos(UnityEngine.Vector2 pos, System.Boolean& isOutside); // 0x07772d44
	System.Void <.ctor>b__11_0(System.Object _); // 0x077734fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.LevelHandler : System.Object
{
	WizardGames.Soc.SocClient.Ui.Map.MapBase map; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Marker.IMapLevelDependentMarker> levelMarkers; // 0x18
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Map.MapBase map); // 0x07773574
	System.Void OnMarkerCreate(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0777364c
	System.Void OnMarkerRemove(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x07773e2c
	System.Void UpdateAllMarkersStatus(); // 0x07773f2c
	System.Void UpdateMarkerStatus(WizardGames.Soc.SocClient.Marker.IMapLevelDependentMarker marker); // 0x07773804
	System.Void Destroy(); // 0x07774090
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.OrderHandler : System.Object
{
	SocLogger log; // 0x10
	WizardGames.Soc.SocClient.Marker.IMarkerStage stage; // 0x18
	System.Collections.Generic.Dictionary<FairyGUI.GComponent,WizardGames.Soc.SocClient.Marker.IMarker> orderedMarkersMap; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Marker.IMarker> orderedMarkers; // 0x28
	System.Void .ctor(WizardGames.Soc.SocClient.Marker.IMarkerStage stage); // 0x07774138
	System.Void OnMarkerCreate(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x07774304
	System.Void OnMarkerRemove(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x07774bec
	System.Void Destroy(); // 0x0777502c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.PositionHandler : System.Object
{
	WizardGames.Soc.SocClient.Marker.IMarkerStage stage; // 0x10
	System.Int32 outSideTopOffset; // 0x18
	System.Int32 outSideBottomOffset; // 0x1c
	System.Int32 outSideLeftOffset; // 0x20
	System.Int32 outSideRightOffset; // 0x24
	System.Void .ctor(WizardGames.Soc.SocClient.Marker.IMarkerStage stage); // 0x077750f8
	System.Void ProcessMarkerPos(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0777592c
	System.Void Destroy(); // 0x077760e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.ZoomHideHandler : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Marker.IZoomHideMarker> zoomHideMarkers; // 0x10
	WizardGames.Soc.SocClient.Marker.IMarkerStage stage; // 0x18
	System.Void .ctor(WizardGames.Soc.SocClient.Marker.IMarkerStage stage); // 0x0777614c
	System.Void OnMarkerCreate(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x07776224
	System.Void OnMarkerRemove(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x07776880
	System.Void UpdateMarkerZoomHideOnTrackOff(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x07776980
	System.Void UpdateMarkerZoomHide(); // 0x07776ac0
	System.Void UpdateMarkerZoomHide(WizardGames.Soc.SocClient.Marker.IZoomHideMarker marker); // 0x077763dc
	System.Void Destroy(); // 0x07776c24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.LobbyMapStage : System.Object, WizardGames.Soc.SocClient.Marker.IMarkerStage, WizardGames.Soc.SocClient.Marker.ISelectMarkerStage, WizardGames.Soc.SocClient.Marker.IMapLevelDependentMarkerStage
{
	SocLogger logger; // 0x10
	WizardGames.Soc.SocClient.Marker.OrderHandler orderHandler; // 0x18
	WizardGames.Soc.SocClient.Marker.LobbyPositionHandler positionHandler; // 0x20
	WizardGames.Soc.SocClient.Marker.LevelHandler levelHandler; // 0x28
	System.Boolean IsInited; // 0x30
	WizardGames.Soc.SocClient.Ui.Map.LobbyMap <Map>k__BackingField; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Marker.MarkerBaseData> markerDataMap; // 0x40
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Marker.GMarkerBase> markers; // 0x48
	WizardGames.Soc.Common.Data.MarkerDecoratorType <StageType>k__BackingField; // 0x50
	WizardGames.Soc.SocClient.Ui.Map.LobbyMap get_Map(); // 0x07776ccc
	System.Void set_Map(WizardGames.Soc.SocClient.Ui.Map.LobbyMap value); // 0x07776d30
	WizardGames.Soc.Common.Data.MarkerDecoratorType get_StageType(); // 0x07776db0
	System.Void set_StageType(WizardGames.Soc.Common.Data.MarkerDecoratorType value); // 0x07776e14
	FairyGUI.GComponent get_MarkerContainer(); // 0x07776e8c
	System.Single get_StageScale(); // 0x07776fc8
	WizardGames.Soc.SocClient.Ui.Map.SelectedMarkerInfo get_CurSelectedMarkerInfo(); // 0x07777078
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Map.LobbyMap map); // 0x07777164
	System.Void Init(); // 0x077773dc
	System.Void OnEnable(); // 0x077782f4
	System.Void OnDisable(); // 0x0777835c
	System.Void OnDestroy(); // 0x07778520
	System.Void OnMarkerCreate(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x077789e8
	System.Void ChangeMarkerPosition(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x07778cb0
	System.Void ChangeMarkerMapLevelStatus(WizardGames.Soc.SocClient.Marker.IMapLevelDependentMarker marker); // 0x07778d34
	System.Void OnMainMapViewScaleChanged(System.Single oldScale, System.Single newScale); // 0x07778db8
	System.Void OnMapLevelChanged(WizardGames.Soc.SocClient.Ui.Map.EMapLevel oldLevel, WizardGames.Soc.SocClient.Ui.Map.EMapLevel newLevel); // 0x07778f94
	System.Void ChangeMarkerSelectedStatus(); // 0x0777901c
	System.Void SelectMarker(System.Int64 id, System.Boolean isFromSidePanel); // 0x07779418
	System.Void DeSelectMarker(WizardGames.Soc.SocClient.Ui.Map.UpdateReason reason); // 0x077783c4
	System.Boolean CanCreateMarkerToStageByType(WizardGames.Soc.Common.Data.MarkerType type); // 0x07779678
	System.Void CreateMarker<T>(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData, System.Action<T> markerInitAction); // 0x052af1f0
	WizardGames.Soc.SocClient.Marker.GMarkerBase GetMarker(System.Int64 id); // 0x0777936c
	System.Boolean IsMarkerExist(System.Int64 id); // 0x07779818
	WizardGames.Soc.SocClient.Marker.MarkerBaseData GetMarkerDataById(System.Int64 id); // 0x077798c4
	System.Void CreateMonumentMarkerOnInit(); // 0x077778ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.LobbyMapStage.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Marker.LobbyMapStage.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Marker.MonumentMarker> <>9__44_0; // 0x8
	static System.Void .cctor(); // 0x077799f0
	System.Void .ctor(); // 0x07779a54
	System.Void <CreateMonumentMarkerOnInit>b__44_0(WizardGames.Soc.SocClient.Marker.MonumentMarker marker); // 0x07779abc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.LobbyPositionHandler : System.Object
{
	WizardGames.Soc.SocClient.Marker.IMarkerStage stage; // 0x10
	System.Int32 curMapTerrainWidth; // 0x18
	UnityEngine.Vector2 curMapOriPos; // 0x1c
	System.Void .ctor(WizardGames.Soc.SocClient.Marker.IMarkerStage stage); // 0x07777820
	System.Void SetLobbyMapInfo(System.Int32 width, UnityEngine.Vector2 oriPos); // 0x07779958
	System.Void ProcessMarkerPos(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x07778a8c
	System.Void Destroy(); // 0x0777897c
	UnityEngine.Vector2 TransformWorldPosToMap(UnityEngine.Vector3 worldPos, FairyGUI.GObject map, System.Single terrainSize); // 0x07779b48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MainMapObStage : WizardGames.Soc.SocClient.Marker.MarkerStage, WizardGames.Soc.SocClient.Marker.ISelectMarkerStage, WizardGames.Soc.SocClient.Marker.IMarkerStage, WizardGames.Soc.SocClient.Marker.IClusterMarkerStage, WizardGames.Soc.SocClient.Marker.IMapLevelDependentMarkerStage, WizardGames.Soc.SocClient.Marker.IFilterMarkerStage
{
	WizardGames.Soc.SocClient.Marker.OrderHandler orderHandler; // 0x80
	WizardGames.Soc.SocClient.Marker.PositionHandler positionHandler; // 0x88
	WizardGames.Soc.SocClient.Marker.ClusterHandler clusterHandler; // 0x90
	WizardGames.Soc.SocClient.Marker.ZoomHideHandler zoomHideHandler; // 0x98
	WizardGames.Soc.SocClient.Marker.LevelHandler levelHandler; // 0xa0
	WizardGames.Soc.SocClient.Marker.FilterHandler filterHandler; // 0xa8
	WizardGames.Soc.SocClient.Ui.Map.MainObMap <Map>k__BackingField; // 0xb0
	FairyGUI.GGroup bedCdGroup; // 0xb8
	WizardGames.Soc.SocClient.Ui.Map.GMarkerSelectedPanel <SelectedUiPanel>k__BackingField; // 0xc0
	System.Int64 remoteCallGetAllObsetverInfoTimerId; // 0xc8
	WizardGames.Soc.SocClient.Ui.Map.MainObMap get_Map(); // 0x07779c70
	System.Void set_Map(WizardGames.Soc.SocClient.Ui.Map.MainObMap value); // 0x07779cd4
	WizardGames.Soc.SocClient.Ui.Map.GMarkerSelectedPanel get_SelectedUiPanel(); // 0x07779d54
	System.Void set_SelectedUiPanel(WizardGames.Soc.SocClient.Ui.Map.GMarkerSelectedPanel value); // 0x07779db8
	FairyGUI.GComponent get_MarkerContainer(); // 0x07779e38
	WizardGames.Soc.SocClient.Ui.Marker.GuideLine get_trackLine(); // 0x07779f74
	System.Single get_StageScale(); // 0x0777a0b0
	System.Boolean get_IsMarkerFiltering(); // 0x0777a160
	WizardGames.Soc.SocClient.Ui.Map.SelectedMarkerInfo get_CurSelectedMarkerInfo(); // 0x0777a24c
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Map.MainObMap map); // 0x0777a338
	System.Void Init(); // 0x0777a544
	System.Void OnTickRemoteCallGetAllObsetverInfo(); // 0x055049cc
	System.Void OnRemoteCallGetAllObsetverInfoTick(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x0777b358
	System.Void ClearRemoteCallGetAllObsetverInfoTimerId(); // 0x0777b264
	System.Void OnEnable(); // 0x0777b464
	System.Void OnDisable(); // 0x0777b758
	System.Void OnDestroy(); // 0x0777b924
	System.Void CheckTrackLineActive(WizardGames.Soc.SocClient.Search.SearchResult searchResult, WizardGames.Soc.Common.Data.MarkerType markerType); // 0x0777bf9c
	System.Void OnMarkerCreate(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0777c13c
	System.Void OnMarkerRemove(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0777c858
	System.Void ChangeMarkerPosition(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0777cb0c
	System.Void ChangeMarkerMapLevelStatus(WizardGames.Soc.SocClient.Marker.IMapLevelDependentMarker marker); // 0x0777ccc8
	System.Void OnTrackCreate(System.Int64 uniqueId); // 0x0777c4e8
	System.Boolean CheckTargetMarkerVisible(); // 0x0777c040
	System.Void OnTrackRemove(System.Int64 uniqueId); // 0x0777ceac
	System.Void UpdateTrack(); // 0x0777cd4c
	System.Void OnFps30Update(); // 0x0777d244
	System.Void OnFps1Update(); // 0x0777d2b4
	System.Boolean TryGetMyPlayerPositionInStage(UnityEngine.Vector2& position); // 0x0777d31c
	System.Void OnMainMapViewScaleChanged(System.Single oldScale, System.Single newScale); // 0x0777d42c
	System.Void RefreshMarkerBriefInfoRange(System.Single newScale); // 0x0777b4f0
	System.Void OnMapLevelChanged(WizardGames.Soc.SocClient.Ui.Map.EMapLevel oldLevel, WizardGames.Soc.SocClient.Ui.Map.EMapLevel newLevel); // 0x0777d8f8
	System.Void UpdateSelectedMarkerInfoOnClusterRebuild(WizardGames.Soc.SocClient.Ui.Map.UpdateReason reason); // 0x0777d738
	System.Void UpdateSelectedMarkerInfoOnRemove(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0777c928
	System.Void UpdateSelectedMarkerInfoOnCreate(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0777c350
	System.Void ChangeMarkerSelectedStatus(); // 0x0777d998
	System.Boolean CheckNeedShowBedCdTips(WizardGames.Soc.SocClient.Marker.MarkerBedData data); // 0x0777df38
	System.Void SelectMarker(System.Int64 id, System.Boolean isFromSidePanel); // 0x0777e54c
	System.Void DeSelectMarker(WizardGames.Soc.SocClient.Ui.Map.UpdateReason reason); // 0x0777b7c8
	WizardGames.Soc.SocClient.Marker.MarkerCluster GetMarkerCluster(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0777cc2c
	System.Void MapDrag(); // 0x0777eb20
	System.Void <Init>b__26_0(System.Int64 id); // 0x0777ed54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.HudDirectionStage : WizardGames.Soc.SocClient.Marker.MarkerStage
{
	WizardGames.Soc.SocClient.Marker.HudDirectionHandler hudDirectionHandler; // 0x80
	FairyGUI.GComponent <MarkerContainer>k__BackingField; // 0x88
	System.Single disOfAnchor; // 0x90
	FairyGUI.GComponent get_MarkerContainer(); // 0x0777edd4
	System.Void .ctor(FairyGUI.GComponent container, System.Single disOfAngel); // 0x0777ee38
	System.Void Init(); // 0x0777ef30
	System.Void OnDestroy(); // 0x0777f214
	System.Void OnTrackCreate(System.Int64 id); // 0x0777f41c
	System.Void OnTrackRemove(System.Int64 id); // 0x0777f59c
	System.Void OnMarkerCreate(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0777f70c
	System.Void OnMarkerRemove(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0777f790
	System.Void OnFps30Update(); // 0x0777f814
	System.Void OnFps1Update(); // 0x0777f88c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.HudMarkerStage : WizardGames.Soc.SocClient.Marker.MarkerStage
{
	WizardGames.Soc.SocClient.Marker.HudPositionHandler hudPosHandler; // 0x80
	FairyGUI.GComponent <MarkerContainer>k__BackingField; // 0x88
	FairyGUI.GComponent visualBorder; // 0x90
	WizardGames.Soc.SocClient.Marker.MarkerExtensionLine markerExtensionLine; // 0x98
	FairyGUI.GComponent get_MarkerContainer(); // 0x0777f8ec
	System.Void .ctor(FairyGUI.GComponent container, FairyGUI.GComponent visualBorder, FairyGUI.GComponent markerExtensionLineCom); // 0x0777f950
	System.Void Init(); // 0x0777fa98
	System.Void OnDestroy(); // 0x0777fdf0
	System.Void OnTrackCreate(System.Int64 id); // 0x07780068
	System.Void OnTrackRemove(System.Int64 id); // 0x07780260
	System.Void OnMarkerCreate(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x07780430
	System.Void OnMarkerRemove(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x07780560
	System.Void OnFps10Update(); // 0x07780714
	System.Void OnFpsUnlimitedUpdate(); // 0x07780788
	System.Void OnFps1Update(); // 0x0778081c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.KatyushaMapStage : WizardGames.Soc.SocClient.Marker.MarkerStage, WizardGames.Soc.SocClient.Marker.IClusterMarkerStage, WizardGames.Soc.SocClient.Marker.IMarkerStage
{
	WizardGames.Soc.SocClient.Marker.OrderHandler orderHandler; // 0x80
	WizardGames.Soc.SocClient.Marker.PositionHandler positionHandler; // 0x88
	WizardGames.Soc.SocClient.Marker.ClusterHandler clusterHandler; // 0x90
	WizardGames.Soc.SocClient.Ui.Map.KatyushaMap <Map>k__BackingField; // 0x98
	System.Int64 katyushaMarkerId; // 0xa0
	WizardGames.Soc.SocClient.Ui.Map.KatyushaMap get_Map(); // 0x07780890
	System.Void set_Map(WizardGames.Soc.SocClient.Ui.Map.KatyushaMap value); // 0x077808f4
	FairyGUI.GComponent get_MarkerContainer(); // 0x07780974
	System.Single get_StageScale(); // 0x07780ab0
	WizardGames.Soc.SocClient.Ui.Marker.GuideLine get_trackLine(); // 0x07780b60
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Map.KatyushaMap map); // 0x07780c9c
	System.Void Init(); // 0x07780dd8
	System.Void OnDestroy(); // 0x0778114c
	System.Void OnMarkerCreate(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x07781408
	System.Void OnMarkerRemove(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0778149c
	System.Void OnFps30Update(); // 0x07781530
	System.Void OnFps1Update(); // 0x07781598
	System.Void OnMainMapViewScaleChanged(System.Single oldScale, System.Single newScale); // 0x07781600
	System.Void OnTrackCreate(System.Int64 uniqueId); // 0x0778198c
	System.Void KatyushaMarkerHide(); // 0x07781b8c
	System.Void OnTrackRemove(); // 0x07781c4c
	System.Void UpdateTrack(); // 0x07781880
	WizardGames.Soc.SocClient.Marker.MarkerCluster GetMarkerCluster(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x07781af0
	System.Boolean TryGetMyPlayerPositionInStage(UnityEngine.Vector2& position); // 0x07781d6c
	System.Void ChangeMarkerPosition(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x07781e7c
	System.Void MapDrag(); // 0x07781f00
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MainMapStage : WizardGames.Soc.SocClient.Marker.MarkerStage, WizardGames.Soc.SocClient.Marker.ISelectMarkerStage, WizardGames.Soc.SocClient.Marker.IMarkerStage, WizardGames.Soc.SocClient.Marker.IClusterMarkerStage, WizardGames.Soc.SocClient.Marker.IMapLevelDependentMarkerStage, WizardGames.Soc.SocClient.Marker.IFilterMarkerStage
{
	WizardGames.Soc.SocClient.Marker.OrderHandler orderHandler; // 0x80
	WizardGames.Soc.SocClient.Marker.PositionHandler positionHandler; // 0x88
	WizardGames.Soc.SocClient.Marker.ClusterHandler clusterHandler; // 0x90
	WizardGames.Soc.SocClient.Marker.ZoomHideHandler zoomHideHandler; // 0x98
	WizardGames.Soc.SocClient.Marker.LevelHandler levelHandler; // 0xa0
	WizardGames.Soc.SocClient.Marker.FilterHandler filterHandler; // 0xa8
	WizardGames.Soc.SocClient.Ui.Map.MainMap <Map>k__BackingField; // 0xb0
	FairyGUI.GGroup bedCdGroup; // 0xb8
	WizardGames.Soc.SocClient.Ui.Map.GMarkerSelectedPanel <SelectedUiPanel>k__BackingField; // 0xc0
	WizardGames.Soc.SocClient.Ui.Map.MainMap get_Map(); // 0x07782134
	System.Void set_Map(WizardGames.Soc.SocClient.Ui.Map.MainMap value); // 0x07782198
	WizardGames.Soc.SocClient.Ui.Map.GMarkerSelectedPanel get_SelectedUiPanel(); // 0x07782218
	System.Void set_SelectedUiPanel(WizardGames.Soc.SocClient.Ui.Map.GMarkerSelectedPanel value); // 0x0778227c
	FairyGUI.GComponent get_MarkerContainer(); // 0x077822fc
	WizardGames.Soc.SocClient.Ui.Marker.GuideLine get_trackLine(); // 0x07782438
	System.Single get_StageScale(); // 0x07782574
	System.Boolean get_IsMarkerFiltering(); // 0x07782624
	WizardGames.Soc.SocClient.Ui.Map.SelectedMarkerInfo get_CurSelectedMarkerInfo(); // 0x07782710
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Map.MainMap map); // 0x077827fc
	System.Void Init(); // 0x07782a08
	System.Void OnDisable(); // 0x077835b8
	System.Void OnDestroy(); // 0x0778377c
	System.Void CheckTrackLineActive(WizardGames.Soc.SocClient.Search.SearchResult searchResult, WizardGames.Soc.Common.Data.MarkerType markerType); // 0x07783dec
	System.Void OnMarkerCreate(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x07783f8c
	System.Void OnMarkerRemove(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x077846a8
	System.Void ChangeMarkerPosition(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0778495c
	System.Void ChangeMarkerMapLevelStatus(WizardGames.Soc.SocClient.Marker.IMapLevelDependentMarker marker); // 0x07784b18
	System.Void OnTrackCreate(System.Int64 uniqueId); // 0x07784338
	System.Boolean CheckTargetMarkerVisible(); // 0x07783e90
	System.Void OnTrackRemove(System.Int64 uniqueId); // 0x07784cfc
	System.Void UpdateTrack(); // 0x07784b9c
	System.Void OnFps30Update(); // 0x07785094
	System.Void OnFps1Update(); // 0x07785104
	System.Boolean TryGetMyPlayerPositionInStage(UnityEngine.Vector2& position); // 0x0778516c
	System.Void OnMainMapViewScaleChanged(System.Single oldScale, System.Single newScale); // 0x0778527c
	System.Void OnMapLevelChanged(WizardGames.Soc.SocClient.Ui.Map.EMapLevel oldLevel, WizardGames.Soc.SocClient.Ui.Map.EMapLevel newLevel); // 0x0778573c
	System.Void UpdateSelectedMarkerInfoOnClusterRebuild(WizardGames.Soc.SocClient.Ui.Map.UpdateReason reason); // 0x0778557c
	System.Void UpdateSelectedMarkerInfoOnRemove(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x07784778
	System.Void UpdateSelectedMarkerInfoOnCreate(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x077841a0
	System.Void ChangeMarkerSelectedStatus(); // 0x077857dc
	System.Boolean CheckNeedShowBedCdTips(WizardGames.Soc.SocClient.Marker.MarkerBedData data); // 0x07785d7c
	System.Void SelectMarker(System.Int64 id, System.Boolean isFromSidePanel); // 0x07786390
	System.Void DeSelectMarker(WizardGames.Soc.SocClient.Ui.Map.UpdateReason reason); // 0x07783620
	System.Void RefreshFilterGroup(System.Collections.Generic.List<System.Int32> groupIds); // 0x07786964
	WizardGames.Soc.SocClient.Marker.MarkerCluster GetMarkerCluster(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x07784a7c
	System.Void MapDrag(); // 0x07786a00
	System.Void <Init>b__26_0(System.Int64 id); // 0x07786c34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MiniMapStage : WizardGames.Soc.SocClient.Marker.MarkerStage, WizardGames.Soc.SocClient.Marker.IClusterMarkerStage, WizardGames.Soc.SocClient.Marker.IMarkerStage, WizardGames.Soc.SocClient.Marker.IMapLevelDependentMarkerStage
{
	WizardGames.Soc.SocClient.Marker.OrderHandler orderHandler; // 0x80
	WizardGames.Soc.SocClient.Marker.PositionHandler positionHandler; // 0x88
	WizardGames.Soc.SocClient.Marker.ClusterHandler clusterHandler; // 0x90
	WizardGames.Soc.SocClient.Marker.LevelHandler levelHandler; // 0x98
	WizardGames.Soc.SocClient.Marker.FovHandler fovHandler; // 0xa0
	WizardGames.Soc.SocClient.Ui.Map.MiniMap <Map>k__BackingField; // 0xa8
	System.Collections.Generic.HashSet<System.Int64> nearbyMarkerIds; // 0xb0
	UnityEngine.Transform myPlayerTransform; // 0xb8
	UnityEngine.Vector3 lastMyPlayerPos; // 0xc0
	WizardGames.Soc.SocClient.Ui.Map.MiniMap get_Map(); // 0x07786cb4
	System.Void set_Map(WizardGames.Soc.SocClient.Ui.Map.MiniMap value); // 0x07786d18
	FairyGUI.GComponent get_MarkerContainer(); // 0x07786d98
	WizardGames.Soc.SocClient.Ui.Marker.GuideLine get_trackLine(); // 0x07786ed4
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Map.MiniMap map); // 0x07787010
	System.Void Init(); // 0x077871cc
	System.Void OnDestroy(); // 0x07787b58
	System.Void CheckTrackLineActive(WizardGames.Soc.SocClient.Search.SearchResult searchResult, WizardGames.Soc.Common.Data.MarkerType markerType); // 0x07787f5c
	System.Void OnMarkerCreate(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x07788130
	System.Void OnMarkerRemove(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x07788644
	System.Void ChangeMarkerPosition(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x077886f8
	System.Void ChangeMarkerMapLevelStatus(WizardGames.Soc.SocClient.Marker.IMapLevelDependentMarker marker); // 0x0778879c
	System.Void OnTrackCreate(System.Int64 uniqueId); // 0x07788324
	System.Boolean CheckTargetMarkerVisible(); // 0x07788000
	System.Void OnTrackRemove(System.Int64 uniqueId); // 0x07788a10
	System.Void UpdateTrack(); // 0x077888bc
	System.Void OnFps30Update(); // 0x07788b80
	System.Void OnFps1Update(); // 0x07788bf0
	System.Void CheckNearbyMarkers(System.Boolean isForce); // 0x07788cc8
	System.Void CheckNearByMonument(); // 0x07788e40
	System.Void CheckNearBySubWay(); // 0x077893a0
	System.Void CheckNearbyTrainStop(); // 0x07789900
	System.Void CheckNearByShop(); // 0x07789e60
	System.Void OnMapLevelChanged(WizardGames.Soc.SocClient.Ui.Map.EMapLevel oldLevel, WizardGames.Soc.SocClient.Ui.Map.EMapLevel newLevel); // 0x0778a3c0
	System.Single GetMiniMapFovSize(); // 0x07787864
	WizardGames.Soc.SocClient.Marker.MarkerCluster GetMarkerCluster(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x07788820
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.RespawnMapStage : WizardGames.Soc.SocClient.Marker.MarkerStage, WizardGames.Soc.SocClient.Marker.ISelectMarkerStage, WizardGames.Soc.SocClient.Marker.IMarkerStage, WizardGames.Soc.SocClient.Marker.IClusterMarkerStage
{
	WizardGames.Soc.SocClient.Marker.OrderHandler orderHandler; // 0x80
	WizardGames.Soc.SocClient.Marker.PositionHandler positionHandler; // 0x88
	WizardGames.Soc.SocClient.Marker.ClusterHandler clusterHandler; // 0x90
	WizardGames.Soc.SocClient.Ui.Map.RespawnMap <Map>k__BackingField; // 0x98
	WizardGames.Soc.SocClient.Ui.Map.GMarkerSelectedPanel <SelectedUiPanel>k__BackingField; // 0xa0
	WizardGames.Soc.SocClient.Ui.Map.RespawnMap get_Map(); // 0x0778a774
	System.Void set_Map(WizardGames.Soc.SocClient.Ui.Map.RespawnMap value); // 0x0778a7d8
	WizardGames.Soc.SocClient.Ui.Map.GMarkerSelectedPanel get_SelectedUiPanel(); // 0x0778a858
	System.Void set_SelectedUiPanel(WizardGames.Soc.SocClient.Ui.Map.GMarkerSelectedPanel value); // 0x0778a8bc
	FairyGUI.GComponent get_MarkerContainer(); // 0x0778a93c
	System.Single get_StageScale(); // 0x0778aa78
	WizardGames.Soc.SocClient.Ui.Map.SelectedMarkerInfo get_CurSelectedMarkerInfo(); // 0x0778ab28
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Map.RespawnMap map); // 0x0778ac14
	System.Void Init(); // 0x0778ad44
	System.Void LocateMapToDeathPoint(); // 0x0778b404
	System.Void OnDisable(); // 0x0778b578
	System.Void OnDestroy(); // 0x0778b73c
	System.Void OnMarkerCreate(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0778ba80
	System.Void OnMarkerRemove(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0778bce0
	System.Void ChangeMarkerPosition(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0778bf6c
	System.Void OnFps30Update(); // 0x0778bfe0
	System.Void OnFps1Update(); // 0x0778c048
	System.Void OnMainMapViewScaleChanged(System.Single oldScale, System.Single newScale); // 0x0778c0b0
	System.Void UpdateSelectedMarkerInfoOnClusterRebuild(WizardGames.Soc.SocClient.Ui.Map.UpdateReason reason); // 0x0778c3a8
	System.Void UpdateSelectedMarkerInfoOnRemove(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0778bd88
	System.Void UpdateSelectedMarkerInfoOnCreate(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0778bb50
	System.Void ChangeMarkerSelectedStatus(); // 0x0778cab8
	System.Void SelectMarker(System.Int64 id, System.Boolean isFromSidePanel); // 0x0778d2f0
	System.Void DeSelectMarker(WizardGames.Soc.SocClient.Ui.Map.UpdateReason reason); // 0x0778b5e0
	WizardGames.Soc.SocClient.Marker.MarkerCluster GetMarkerCluster(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x0778c564
	System.Void MapDrag(); // 0x0778d738
	System.Void <Init>b__18_0(System.Int64 id); // 0x0778d970
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Marker.EClusterType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Marker.EClusterType None = 0;
	static WizardGames.Soc.SocClient.Marker.EClusterType Isolated = 1;
	static WizardGames.Soc.SocClient.Marker.EClusterType SameType = 2;
	static WizardGames.Soc.SocClient.Marker.EClusterType MixedType = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MarkerCluster : System.Object
{
	SocLogger log; // 0x10
	WizardGames.Soc.SocClient.Marker.IClusterMarkerStage stage; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Marker.IClusterMarker> memberMarkers; // 0x20
	UnityEngine.Vector2 centerWorldPosition; // 0x28
	WizardGames.Soc.SocClient.Marker.EClusterType <ClusterType>k__BackingField; // 0x30
	UnityEngine.Vector2 <CenterContainerPosition>k__BackingField; // 0x34
	WizardGames.Soc.SocClient.Marker.EClusterType get_ClusterType(); // 0x0778d9f0
	System.Void set_ClusterType(WizardGames.Soc.SocClient.Marker.EClusterType value); // 0x0778da54
	UnityEngine.Vector2 get_CenterContainerPosition(); // 0x0778dacc
	System.Void set_CenterContainerPosition(UnityEngine.Vector2 value); // 0x0778db2c
	System.Boolean get_Empty(); // 0x0778dbac
	System.Void Init(WizardGames.Soc.SocClient.Marker.IClusterMarkerStage stage); // 0x0778dc30
	System.Boolean JoinMarker(WizardGames.Soc.SocClient.Marker.IClusterMarker marker); // 0x0778dcb0
	System.Void RemoveMarker(WizardGames.Soc.SocClient.Marker.IClusterMarker marker); // 0x0778ec4c
	System.Boolean CheckMarkerCanStillInCluster(WizardGames.Soc.SocClient.Marker.IClusterMarker marker); // 0x0778f158
	System.Void UpdateCluster(); // 0x0778e234
	System.Boolean CheckCanCluster(WizardGames.Soc.SocClient.Marker.IMarker markerInCluster, WizardGames.Soc.SocClient.Marker.IMarker targetMarker); // 0x0778e0ac
	System.Boolean CheckMarkerFilterStatus(WizardGames.Soc.SocClient.Marker.IMarker markerA, WizardGames.Soc.SocClient.Marker.IMarker markerB); // 0x0778f31c
	System.Boolean CheckMarkerLevelStatus(WizardGames.Soc.SocClient.Marker.IMarker markerA, WizardGames.Soc.SocClient.Marker.IMarker markerB); // 0x0778f734
	System.Boolean CheckMarkerTrackingStatus(WizardGames.Soc.SocClient.Marker.IMarker markerA, WizardGames.Soc.SocClient.Marker.IMarker markerB); // 0x0778f55c
	System.Boolean CheckMerge(WizardGames.Soc.SocClient.Marker.IMarker markerA, WizardGames.Soc.SocClient.Marker.IMarker markerB); // 0x0778f8bc
	System.Boolean CheckStack(WizardGames.Soc.SocClient.Marker.IMarker markerA, WizardGames.Soc.SocClient.Marker.IMarker markerB); // 0x0778fc20
	System.Void UpdateClusterPosition(); // 0x0778fe08
	System.Void UpdateClusterContainerPosition(); // 0x0779038c
	System.Void UpdateClusterSort(); // 0x0778ce74
	System.Collections.Generic.List<System.Int64> GetMemberIds(); // 0x0778c604
	System.Boolean ContainsMarker(System.Int64 uniqueId); // 0x0778c8bc
	System.Void Destroy(); // 0x07790634
	System.Void ClearClusterMarkerState(WizardGames.Soc.SocClient.Marker.IClusterMarker marker); // 0x0778eed8
	System.Void .ctor(); // 0x077908cc
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Marker.FilterMarkerState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Marker.FilterMarkerState Filtered = 0;
	static WizardGames.Soc.SocClient.Marker.FilterMarkerState NoFiltered = 1;
	static WizardGames.Soc.SocClient.Marker.FilterMarkerState SelectedNoFiltered = 2;
	static WizardGames.Soc.SocClient.Marker.FilterMarkerState TrackingNoFiltered = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Marker.HideReason : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Marker.HideReason None = 0;
	static WizardGames.Soc.SocClient.Marker.HideReason ClusterMember = 1;
	static WizardGames.Soc.SocClient.Marker.HideReason MapLevelHide = 2;
	static WizardGames.Soc.SocClient.Marker.HideReason NoFilterHide = 4;
	static WizardGames.Soc.SocClient.Marker.HideReason TeamCombatMarkerHide = 8;
	static WizardGames.Soc.SocClient.Marker.HideReason FovHide = 16;
	static WizardGames.Soc.SocClient.Marker.HideReason InvalidData = 32;
	static WizardGames.Soc.SocClient.Marker.HideReason ExcelCfg = 64;
	static WizardGames.Soc.SocClient.Marker.HideReason TaskDefaultHide = 128;
	static WizardGames.Soc.SocClient.Marker.HideReason NotAmiAt = 256;
	static WizardGames.Soc.SocClient.Marker.HideReason ZoomHide = 512;
	static WizardGames.Soc.SocClient.Marker.HideReason OutsideMonumentHide = 1024;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Marker.LevelMarkerState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Marker.LevelMarkerState Normal = 0;
	static WizardGames.Soc.SocClient.Marker.LevelMarkerState Hide = 1;
	static WizardGames.Soc.SocClient.Marker.LevelMarkerState Transparent = 2;
	static WizardGames.Soc.SocClient.Marker.LevelMarkerState SelectedTransparent = 3;
	static WizardGames.Soc.SocClient.Marker.LevelMarkerState TrackingTransparent = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Marker.MarkerMapLevelRule : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Marker.MarkerMapLevelRule None = 0;
	static WizardGames.Soc.SocClient.Marker.MarkerMapLevelRule OnlyOnGround = 1;
	static WizardGames.Soc.SocClient.Marker.MarkerMapLevelRule OnlyUnderGround = 2;
	static WizardGames.Soc.SocClient.Marker.MarkerMapLevelRule OtherLevelHide = 3;
	static WizardGames.Soc.SocClient.Marker.MarkerMapLevelRule OtherLevelTransparent = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MarkerBaseData : System.Object
{
	WizardGames.Soc.Common.Data.MarkerType <Type>k__BackingField; // 0x10
	System.Int64 <Id>k__BackingField; // 0x18
	UnityEngine.Vector3 _curWorldPosition; // 0x20
	UnityEngine.Vector3 _curWorldRotation; // 0x2c
	WizardGames.Soc.Common.Data.MarkerType get_Type(); // 0x07790a1c
	System.Void set_Type(WizardGames.Soc.Common.Data.MarkerType value); // 0x07790a80
	System.Int64 get_Id(); // 0x07790af8
	System.Void set_Id(System.Int64 value); // 0x07790b5c
	System.Void .ctor(WizardGames.Soc.Common.Data.MarkerType type, System.Int64 id); // 0x07790bd4
	System.Void .ctor(WizardGames.Soc.Common.Data.MarkerType type, System.Int64 id, UnityEngine.Vector3 worldPosition); // 0x07790d4c
	UnityEngine.Vector3 get_CurWorldPosition(); // 0x07790ef4
	System.Void ForceUpdateWorldPosition(UnityEngine.Vector3 worldPosition); // 0x07790f58
	System.Void OnRelease(); // 0x07790ff0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MarkerBedData : WizardGames.Soc.SocClient.Marker.MarkerBaseData
{
	WizardGames.Soc.Common.CustomType.SleepingBagInfo bedInfo; // 0x38
	System.Action DoActionWhenBedInfoChange; // 0x40
	WizardGames.Soc.Common.CustomType.SleepingBagInfo get_BedInfo(); // 0x07791050
	System.Void set_BedInfo(WizardGames.Soc.Common.CustomType.SleepingBagInfo value); // 0x077910b4
	System.Void .ctor(WizardGames.Soc.Common.Data.MarkerType type, System.Int64 entityId, WizardGames.Soc.Common.CustomType.SleepingBagInfo bedInfo); // 0x077911a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MarkerCombatData : WizardGames.Soc.SocClient.Marker.MarkerBaseData
{
	WizardGames.Soc.Common.CustomType.MarkerBase ServerData; // 0x38
	System.Boolean isSelfCreated; // 0x40
	System.UInt64 creatorRoleId; // 0x48
	System.Boolean isConfirmedBySelf; // 0x50
	System.Int64 createTimeMSec; // 0x58
	System.Int32 lastUpdateFrameCount; // 0x60
	UnityEngine.Transform hudPositionTransform; // 0x68
	System.Boolean get_IsSelfCreated(); // 0x07791288
	System.UInt64 get_CreatorRoleId(); // 0x077912ec
	System.Boolean get_IsConfirmedBySelf(); // 0x07791350
	System.Boolean get_CanCancel(); // 0x07791444
	System.Void .ctor(WizardGames.Soc.Common.Data.MarkerType type, System.Int64 id, WizardGames.Soc.Common.CustomType.MarkerBase serverData); // 0x07791594
	System.Void .ctor(WizardGames.Soc.Common.Data.MarkerType type, System.Int64 id, UnityEngine.Vector3 pos); // 0x07791ab8
	UnityEngine.Vector3 get_CurWorldPosition(); // 0x07791ca8
	System.Void UpdateHudPositionTransform(); // 0x077917c0
	System.Void OnRelease(); // 0x07791fd4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MarkerDeathPointData : WizardGames.Soc.SocClient.Marker.MarkerBaseData
{
	System.Int32 CreateIndex; // 0x38
	System.Int64 CreateTime; // 0x40
	System.Boolean IsCfgSelfDestroy; // 0x48
	System.Int64 timerId; // 0x50
	System.Action DoActionWhenCfgSelfDestory; // 0x58
	System.Boolean IsNewest; // 0x60
	System.Int64 BoxEntityId; // 0x68
	WizardGames.Soc.Common.Entity.BoxEntity boxEntity; // 0x70
	WizardGames.Soc.Common.Entity.CorpseEntity corpseEntity; // 0x78
	System.Int64 boxTransformSubId; // 0x80
	System.Int64 corpseTransformSubId; // 0x88
	System.Action PosChangeAction; // 0x90
	System.Void .ctor(WizardGames.Soc.Common.Data.MarkerType type, WizardGames.Soc.Common.CustomType.PlayerDeathPoint point, System.Int32 createIndex); // 0x07792048
	System.Void CheckEntity(); // 0x07792500
	System.Void OnEntityCreate(WizardGames.Soc.Common.Entity.IEntity entity); // 0x077929ec
	System.Void OnEntityRemove(WizardGames.Soc.Common.Entity.IEntity entity); // 0x07792cdc
	System.Void Connect2BoxEntity(); // 0x07792778
	System.Void Connect2CorpseEntity(); // 0x077928bc
	System.Void CheckIsCfgSelfDestoryOnInit(); // 0x077922f8
	System.Void CheckCfgDestoryTime(System.Int64 awakeTime); // 0x07792ef4
	System.Void SetSelfDestoryStatus(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x0779329c
	System.Void ClearTimer(); // 0x07793194
	System.Void OnRelease(); // 0x0779335c
	System.Void <Connect2BoxEntity>b__20_0(WizardGames.Soc.Share.Framework.PositionChangeEvent entityPositionChange); // 0x077935c0
	System.Void <Connect2CorpseEntity>b__21_0(WizardGames.Soc.Share.Framework.PositionChangeEvent entityPositionChange); // 0x07793698
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MarkerEntityData : WizardGames.Soc.SocClient.Marker.MarkerBaseData
{
	System.Int32 lastUpdateFrameCount; // 0x38
	System.Int64 EntityId; // 0x40
	System.Int64 BornMonumentId; // 0x48
	System.Boolean <CanFindEntity>k__BackingField; // 0x50
	System.Boolean get_CanFindEntity(); // 0x07793770
	System.Void set_CanFindEntity(System.Boolean value); // 0x077937d4
	System.Void .ctor(WizardGames.Soc.Common.Data.MarkerType type, System.Int64 entityId); // 0x07793850
	System.Void .ctor(WizardGames.Soc.Common.Data.MarkerType type, System.Int64 entityId, UnityEngine.Vector3 worldPosition); // 0x077938f8
	System.Void .ctor(WizardGames.Soc.Common.Data.MarkerType type, System.Int64 entityId, UnityEngine.Vector3 worldPosition, System.Int32 monumentId); // 0x077939dc
	UnityEngine.Vector3 get_CurWorldPosition(); // 0x07793ad8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MarkerFlyData : WizardGames.Soc.SocClient.Marker.MarkerBaseData
{
	UnityEngine.Vector2 <FlyBeginPosition>k__BackingField; // 0x38
	UnityEngine.Vector2 get_FlyBeginPosition(); // 0x07793da0
	System.Void set_FlyBeginPosition(UnityEngine.Vector2 value); // 0x07793e00
	System.Void .ctor(WizardGames.Soc.Common.Data.MarkerType type, System.Int64 id, UnityEngine.Vector3 worldPosition, UnityEngine.Vector2 flyBeginPos); // 0x07793e80
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MarkerGameObjectData : WizardGames.Soc.SocClient.Marker.MarkerBaseData
{
	System.Int32 lastUpdateFrameCount; // 0x38
	System.String <Desc>k__BackingField; // 0x40
	UnityEngine.Transform markerObjectTransform; // 0x48
	System.String get_Desc(); // 0x07793fc8
	System.Void set_Desc(System.String value); // 0x0779402c
	System.Void .ctor(WizardGames.Soc.Common.Data.MarkerType type, System.Int64 id, System.String desc, UnityEngine.GameObject gameObject); // 0x077940ac
	UnityEngine.Vector3 get_CurWorldPosition(); // 0x0779428c
	System.Void OnRelease(); // 0x07794370
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MarkerGoldAirDropData : WizardGames.Soc.SocClient.Marker.MarkerBaseData
{
	System.Action InfoChangeAction; // 0x38
	System.Boolean IsLanded; // 0x40
	System.Int32 MoneyNum; // 0x44
	System.Void .ctor(WizardGames.Soc.Common.Data.MarkerType type, System.Int64 id, UnityEngine.Vector3 worldPosition, System.Boolean isLander, System.Int32 moneyNum); // 0x077943e4
	System.Void ReSetData(System.Boolean isLander); // 0x077944d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MarkerMonumentData : WizardGames.Soc.SocClient.Marker.MarkerBaseData
{
	WizardGames.Soc.Common.Data.monument.MonumentInformation MonumentInfo; // 0x38
	System.Single MonumentRotation; // 0x40
	System.Int32 MonumentEntityID; // 0x44
	System.Void .ctor(WizardGames.Soc.Common.Data.MarkerType type, System.Int64 entityId, UnityEngine.Vector3 worldPosition, WizardGames.Soc.Common.Data.monument.MonumentInformation info, System.Single monumentRotation, System.Int32 monumentId); // 0x07794574
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MarkerMyPlayerData : WizardGames.Soc.SocClient.Marker.MarkerPlayerData
{
	System.Int32 lastUpdateFrameCount; // 0x60
	System.Void .ctor(WizardGames.Soc.Common.Data.MarkerType type, System.Int64 entityId); // 0x07794678
	UnityEngine.Vector3 get_CurWorldPosition(); // 0x077947f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MarkerNameData : WizardGames.Soc.SocClient.Marker.MarkerBaseData
{
	System.String <Name>k__BackingField; // 0x38
	System.String get_Name(); // 0x077948e4
	System.Void set_Name(System.String value); // 0x07794948
	System.Void .ctor(WizardGames.Soc.Common.Data.MarkerType type, System.Int64 id, System.String name, UnityEngine.Vector3 pos); // 0x077949c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MarkerObPlayerData : WizardGames.Soc.SocClient.Marker.MarkerBaseData
{
	System.UInt64 obRoleId; // 0x38
	System.Single obMapScale; // 0x40
	System.Single obWorldRotateY; // 0x44
	System.Int32 lastUpdateRotateFrameCount; // 0x48
	System.Int32 lastUpdatePositionFrameCount; // 0x4c
	System.Void .ctor(WizardGames.Soc.Common.Data.MarkerType type, System.Int64 roleId, UnityEngine.Vector3 worldPosition, System.Single rotateY); // 0x07794b0c
	System.Void ForceUpdateWorldRotateY(System.Single rotateY); // 0x07794bec
	System.Void ForceUpdateObMapScale(System.Single newMapScale); // 0x07794c64
	UnityEngine.Vector3 get_CurWorldPosition(); // 0x07794cdc
	System.Single get_CurWorldRotateY(); // 0x07794de0
	System.Single get_CurMapScale(); // 0x07794ec0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MarkerObTerritoryCabinetData : WizardGames.Soc.SocClient.Marker.MarkerBaseData
{
	System.Single obMapScale; // 0x38
	System.Void .ctor(WizardGames.Soc.Common.Data.MarkerType type, System.Int64 id, UnityEngine.Vector3 worldPosition); // 0x07794f24
	System.Void ForceUpdateObMapScale(System.Single newMapScale); // 0x07794fe8
	System.Single get_CurMapScale(); // 0x07795060
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MarkerPlayerData : WizardGames.Soc.SocClient.Marker.MarkerEntityData
{
	System.UInt64 RoleId; // 0x58
	System.Void .ctor(WizardGames.Soc.Common.Data.MarkerType type, System.Int64 entityId, System.UInt64 roleId); // 0x07794754
	UnityEngine.Vector3 get_CurWorldPosition(); // 0x077950c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MarkerReportBanData : WizardGames.Soc.SocClient.Marker.MarkerBaseData
{
	System.String <PlayerName>k__BackingField; // 0x38
	System.String get_PlayerName(); // 0x077951c8
	System.Void set_PlayerName(System.String value); // 0x0779522c
	System.Void .ctor(System.Int64 id, UnityEngine.Vector3 worldPosition, System.String playerName); // 0x077952ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MarkerSDJTeamData : WizardGames.Soc.SocClient.Marker.MarkerBaseData
{
	System.Action InfoChangeAction; // 0x38
	System.String TeamName; // 0x40
	System.Int32 MoneyNum; // 0x48
	System.Void .ctor(WizardGames.Soc.Common.Data.MarkerType type, System.Int64 id, UnityEngine.Vector3 worldPosition, System.String teamName, System.Int32 moneyNum); // 0x077953d8
	System.Void ReSetData(System.String teamName, System.Int32 moneyNum); // 0x077954d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MarkerSearchData : WizardGames.Soc.SocClient.Marker.MarkerBaseData
{
	System.Int32 lastUpdateFrameCount; // 0x38
	WizardGames.Soc.SocClient.Search.SearchResult SearchResult; // 0x40
	System.Boolean Valid; // 0x48
	System.Action onResultChange; // 0x50
	System.Action onMarkerNameChange; // 0x58
	System.String SpecialMarkerName; // 0x60
	System.Boolean isTreeEntity; // 0x68
	System.Boolean <CanFindEntity>k__BackingField; // 0x69
	WizardGames.Soc.Common.Data.MarkerType markerType; // 0x6c
	System.Int64 get_EntityId(); // 0x07795584
	System.Boolean get_IsSearchEntity(); // 0x07795628
	System.Void set_CanFindEntity(System.Boolean value); // 0x077956cc
	System.Void .ctor(WizardGames.Soc.Common.Data.MarkerType type, WizardGames.Soc.SocClient.Search.SearchResult searchResult); // 0x07795748
	System.Void SearchResultUpdate(WizardGames.Soc.SocClient.Search.SearchResult searchResult); // 0x07795afc
	System.Void RrfreshSpecialMarkerName(); // 0x07795984
	UnityEngine.Vector3 get_CurWorldPosition(); // 0x07795d48
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Marker.IClusterMarker : , WizardGames.Soc.SocClient.Marker.ISelectMarker, WizardGames.Soc.SocClient.Marker.IMarker
{
	
	System.Boolean CanCluster(); // 0x054c4760
	System.Void set_ClusterCount(System.Int32 value); // 0x055056e8
	System.Void set_Role(WizardGames.Soc.SocClient.Marker.EClusterRole value); // 0x055056e8
	UnityEngine.Vector2 get_ClusterContainerPos(); // 0x054b8310
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Marker.EClusterRole : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Marker.EClusterRole None = 0;
	static WizardGames.Soc.SocClient.Marker.EClusterRole TopSingle = 1;
	static WizardGames.Soc.SocClient.Marker.EClusterRole TopMultiple = 2;
	static WizardGames.Soc.SocClient.Marker.EClusterRole Member = 3;
	
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Marker.IDistanceVisibleMarker : , WizardGames.Soc.SocClient.Marker.IMarker
{
	
	System.Void SetDistanceVisible(System.Boolean visible); // 0x05523a7c
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Marker.IFilterMarker : , WizardGames.Soc.SocClient.Marker.IMarker
{
	
	System.Boolean CanFilter(); // 0x054c4760
	WizardGames.Soc.SocClient.Marker.FilterMarkerState get_FilterState(); // 0x0548ba98
	System.Void set_FilterState(WizardGames.Soc.SocClient.Marker.FilterMarkerState value); // 0x055056e8
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Marker.IFlyMarker : , WizardGames.Soc.SocClient.Marker.IMarker
{
	
	UnityEngine.Vector2 get_FlyBeginPosition(); // 0x054b8310
	System.Single get_FlyProgress(); // 0x054a5abc
	System.Void set_FlyProgress(System.Single value); // 0x05513724
	System.Single get_FlyProgressIncrement(); // 0x054a5abc
	System.Void set_FlyProgressIncrement(System.Single value); // 0x05513724
	System.Int64 get_DelayFlyTime(); // 0x054a4380
	System.Int64 get_StayFlyTime(); // 0x054a4380
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Marker.IMapLevelDependentMarker : , WizardGames.Soc.SocClient.Marker.IMarker
{
	
	System.Boolean CanMapLevelDependent(); // 0x054c4760
	WizardGames.Soc.SocClient.Marker.LevelMarkerState get_LevelState(); // 0x0548ba98
	System.Void set_LevelState(WizardGames.Soc.SocClient.Marker.LevelMarkerState value); // 0x055056e8
	System.Boolean get_IsOnGround(); // 0x054c4760
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Marker.IMarker : 
{
	
	System.Int64 get_Id(); // 0x054a4380
	WizardGames.Soc.Common.Data.MarkerType get_MarkerType(); // 0x0548ba98
	WizardGames.Soc.SocClient.Marker.IMarkerStage get_AttachedStage(); // 0x054e7844
	UnityEngine.Vector3 get_WorldPosition(); // 0x054b1148
	UnityEngine.Vector2 get_ContainerPosition(); // 0x054b8310
	System.Void set_ContainerPosition(UnityEngine.Vector2 value); // 0x0551f630
	WizardGames.Soc.Common.Data.mapmark.NewMarker get_MarkerConfig(); // 0x054e7844
	WizardGames.Soc.SocClient.Marker.MarkerMapLevelRule get_LevelRule(); // 0x0548ba98
	FairyGUI.GComponent get_UiNode(); // 0x054e7844
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Marker.IOutsideStatusMarker : , WizardGames.Soc.SocClient.Marker.IMarker
{
	
	System.Void set_IsOutside(System.Boolean value); // 0x05523a7c
	System.Void SetRotateNodeVisible(System.Boolean visible); // 0x05523a7c
	System.Void SetRotation(System.Single rotation); // 0x05513724
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Marker.ISelectMarker : , WizardGames.Soc.SocClient.Marker.IMarker
{
	
	System.Boolean get_IsSelected(); // 0x054c4760
	System.Void set_IsSelected(System.Boolean value); // 0x05523a7c
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Marker.I1TickMarker : , WizardGames.Soc.SocClient.Marker.IMarker
{
	
	System.Void OnFps1Update(); // 0x055049cc
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Marker.I30TickMarker : , WizardGames.Soc.SocClient.Marker.IMarker
{
	
	System.Void OnFps30Update(); // 0x055049cc
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Marker.IUnlimitedTickMarker : , WizardGames.Soc.SocClient.Marker.IMarker
{
	
	System.Void OnUnlimitedUpdate(); // 0x055049cc
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Marker.IZoomHideMarker : , WizardGames.Soc.SocClient.Marker.IMarker
{
	
	System.Boolean CanZoomHide(); // 0x054c4760
	System.Boolean get_IsZoomHide(); // 0x054c4760
	System.Void set_IsZoomHide(System.Boolean value); // 0x05523a7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.GMarkerBase : System.Object, WizardGames.Soc.SocClient.Marker.IMarker
{
	SocLogger log; // 0x10
	WizardGames.Soc.SocClient.Marker.MarkerBaseData <MarkerData>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Marker.IMarkerStage <AttachedStage>k__BackingField; // 0x20
	System.Boolean <NeedOverflowHoverShow>k__BackingField; // 0x28
	System.Boolean <CurIsOverflowHoverShow>k__BackingField; // 0x29
	UnityEngine.Vector3 <WorldPosition>k__BackingField; // 0x2c
	WizardGames.Soc.SocClient.Marker.Ui.GMarkerComponentBaseBinder markerComponentBinder; // 0x38
	WizardGames.Soc.SocClient.Marker.HideReason hideReason; // 0x40
	WizardGames.Soc.SocClient.Marker.MarkerBaseData get_MarkerData(); // 0x07796060
	System.Void set_MarkerData(WizardGames.Soc.SocClient.Marker.MarkerBaseData value); // 0x077960c4
	System.Int64 get_Id(); // 0x07796144
	WizardGames.Soc.Common.Data.MarkerType get_MarkerType(); // 0x07796230
	WizardGames.Soc.SocClient.Marker.IMarkerStage get_AttachedStage(); // 0x0779631c
	System.Void set_AttachedStage(WizardGames.Soc.SocClient.Marker.IMarkerStage value); // 0x07796380
	System.Boolean get_NeedOverflowHoverShow(); // 0x07796400
	System.Void set_NeedOverflowHoverShow(System.Boolean value); // 0x07796464
	System.Boolean get_CurIsOverflowHoverShow(); // 0x077964e0
	System.Void set_CurIsOverflowHoverShow(System.Boolean value); // 0x07796544
	WizardGames.Soc.Common.Data.mapmark.NewMarker get_MarkerConfig(); // 0x077965c0
	System.Single get_IconLoaderScale(); // 0x0779679c
	WizardGames.Soc.Common.Data.mapmark.MarkerTemplate get_MarkerUiIconConfigByType(); // 0x077969dc
	UnityEngine.Vector3 get_WorldPosition(); // 0x07796cf0
	System.Void set_WorldPosition(UnityEngine.Vector3 value); // 0x07796d54
	UnityEngine.Vector2 get_ContainerPosition(); // 0x07796dec
	System.Void set_ContainerPosition(UnityEngine.Vector2 value); // 0x07796f38
	WizardGames.Soc.SocClient.Marker.MarkerMapLevelRule get_LevelRule(); // 0x07796fec
	FairyGUI.GComponent get_UiNode(); // 0x07796e94
	System.Void Init(); // 0x07797088
	System.Void SetPosDirty(); // 0x077971cc
	System.Boolean HasHideReason(WizardGames.Soc.SocClient.Marker.HideReason reason); // 0x077972f8
	System.Boolean OnlyHasHideReason(WizardGames.Soc.SocClient.Marker.HideReason reason); // 0x07797378
	System.Void AddHideReason(WizardGames.Soc.SocClient.Marker.HideReason reason); // 0x077973f8
	System.Void ClearHideReason(WizardGames.Soc.SocClient.Marker.HideReason reason); // 0x07797488
	System.Void OnHiddenReasonChanged(); // 0x07797518
	System.Void PlayShowEffect(); // 0x077975e0
	System.Void LoadLoopEffectNode(); // 0x07797684
	System.Void LoadTraceEffect(); // 0x07797c50
	System.String GetIconColor(); // 0x07798240
	System.Void RemoveTraceEffect(); // 0x07798360
	System.Void OnRemove(); // 0x07798728
	System.Void .ctor(); // 0x07798840
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.HudDirectionCombatMarker : WizardGames.Soc.SocClient.Marker.HudDirectionSimpleMarker
{
	
	WizardGames.Soc.SocClient.Marker.MarkerCombatData get_MarkerData(); // 0x07798938
	System.Boolean get_IsSelfCreated(); // 0x07798a30
	System.Void Init(); // 0x07798adc
	System.Void OnTeamMemberDictChange(WizardGames.Soc.Share.Framework.ECustomDictOpType changeType, System.UInt64 roleId, WizardGames.Soc.Common.CustomType.TeamMemberInfo oldMember); // 0x07798f90
	System.Void SetColor(); // 0x07798dcc
	System.Void OnRemove(); // 0x077990d0
	System.Void .ctor(); // 0x07799264
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.HudDirectionDeathPointMarker : WizardGames.Soc.SocClient.Marker.HudDirectionSimpleMarker
{
	
	WizardGames.Soc.SocClient.Marker.MarkerDeathPointData get_MarkerData(); // 0x0779932c
	System.Void Init(); // 0x07799424
	System.Void OnRefreshDeathPointMarker(System.Int64 id); // 0x0779968c
	System.Void HideSelfWhenCfgDestory(); // 0x07799804
	System.Void OnRemove(); // 0x0779986c
	System.Void .ctor(); // 0x07799a28
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.HudDirectionEntityMarker : WizardGames.Soc.SocClient.Marker.HudDirectionSimpleMarker, WizardGames.Soc.SocClient.Marker.I30TickMarker, WizardGames.Soc.SocClient.Marker.IMarker
{
	
	WizardGames.Soc.SocClient.Marker.MarkerEntityData get_MarkerData(); // 0x07799a8c
	System.Void Init(); // 0x07799b84
	System.Void OnFps30Update(); // 0x07799be8
	System.Void .ctor(); // 0x07799cec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.HudDirectionMissionMarker : WizardGames.Soc.SocClient.Marker.HudDirectionSearchMarker
{
	
	System.Void Init(); // 0x07799d50
	System.Void SetIconColor(); // 0x07799ee0
	System.Void .ctor(); // 0x07799f90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.HudDirectionSearchMarker : WizardGames.Soc.SocClient.Marker.HudDirectionSimpleMarker, WizardGames.Soc.SocClient.Marker.I30TickMarker, WizardGames.Soc.SocClient.Marker.IMarker
{
	static SocLogger Logger; // 0x0
	System.Boolean valid; // 0x44
	WizardGames.Soc.SocClient.Marker.MarkerSearchData get_MarkerData(); // 0x0779a07c
	System.Void Init(); // 0x07799dbc
	System.Void UpdateResult(); // 0x0779a174
	System.Void OnFps30Update(); // 0x0779a40c
	System.Void OnRemove(); // 0x0779a524
	System.Void .ctor(); // 0x0779a018
	static System.Void .cctor(); // 0x0779a644
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.HudDirectionSimpleMarker : WizardGames.Soc.SocClient.Marker.GMarkerBase
{
	
	WizardGames.Soc.SocClient.Marker.Ui.HudDirectionMarker_Binder get_UiMarker(); // 0x07799024
	System.Void Init(); // 0x07798bf8
	System.Void OnRemove(); // 0x077991e4
	System.Void .ctor(); // 0x077992c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.HudBpHouseCabinetMarker : WizardGames.Soc.SocClient.Marker.GMarkerBase, WizardGames.Soc.SocClient.Marker.IOutsideStatusMarker, WizardGames.Soc.SocClient.Marker.IMarker, WizardGames.Soc.SocClient.Marker.IDistanceVisibleMarker, WizardGames.Soc.SocClient.Marker.I30TickMarker, WizardGames.Soc.SocClient.Marker.IFlyMarker
{
	System.Int32 traceDistance; // 0x44
	UnityEngine.Transform selfTransform; // 0x48
	System.Boolean <IsOutside>k__BackingField; // 0x50
	UnityEngine.Vector2 <FlyBeginPosition>k__BackingField; // 0x54
	System.Single <FlyProgress>k__BackingField; // 0x5c
	System.Single <FlyProgressIncrement>k__BackingField; // 0x60
	System.Int64 <DelayFlyTime>k__BackingField; // 0x68
	System.Int64 <StayFlyTime>k__BackingField; // 0x70
	WizardGames.Soc.SocClient.Marker.MarkerFlyData get_MarkerData(); // 0x0779a718
	WizardGames.Soc.SocClient.Marker.Ui.HudMarkerSimple_Binder get_UiMarker(); // 0x0779a810
	System.Void set_IsOutside(System.Boolean value); // 0x0779a8bc
	UnityEngine.Vector2 get_FlyBeginPosition(); // 0x0779a938
	System.Void set_FlyBeginPosition(UnityEngine.Vector2 value); // 0x0779a998
	System.Single get_FlyProgress(); // 0x0779aa18
	System.Void set_FlyProgress(System.Single value); // 0x0779aa7c
	System.Single get_FlyProgressIncrement(); // 0x0779aaf4
	System.Void set_FlyProgressIncrement(System.Single value); // 0x0779ab58
	System.Int64 get_DelayFlyTime(); // 0x0779abd0
	System.Void set_DelayFlyTime(System.Int64 value); // 0x0779ac34
	System.Int64 get_StayFlyTime(); // 0x0779acac
	System.Void set_StayFlyTime(System.Int64 value); // 0x0779ad10
	System.Void SetDistanceVisible(System.Boolean visible); // 0x0779ad88
	System.Void Init(); // 0x0779aeb4
	System.Void SetFlyBeginPosition(UnityEngine.Vector2 pos); // 0x0779b218
	System.Void OnFps30Update(); // 0x0779b3b0
	System.Void SetRotateNodeVisible(System.Boolean visibel); // 0x0779b770
	System.Void SetRotation(System.Single rotation); // 0x0779b950
	System.Void OnRemove(); // 0x0779bb40
	System.Void .ctor(); // 0x0779bbc0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.HudCombatMarker : WizardGames.Soc.SocClient.Marker.GMarkerBase, WizardGames.Soc.SocClient.Marker.I30TickMarker, WizardGames.Soc.SocClient.Marker.IMarker, WizardGames.Soc.SocClient.Marker.IOutsideStatusMarker, WizardGames.Soc.SocClient.Marker.IDistanceVisibleMarker
{
	System.Single distance; // 0x44
	WizardGames.Soc.Common.Entity.IEntity entity; // 0x48
	UnityEngine.Vector3 tempPos; // 0x50
	System.Boolean <IsOutside>k__BackingField; // 0x5c
	WizardGames.Soc.SocClient.Marker.Ui.HudMarkerSimple_Binder get_UiMarker(); // 0x0779bc2c
	WizardGames.Soc.SocClient.Marker.MarkerCombatData get_MarkerData(); // 0x0779bcd8
	System.Boolean get_IsSelfCreated(); // 0x0779bdd0
	System.Boolean get_IsConfirmedBySelf(); // 0x0779be7c
	System.Boolean get_CanCancel(); // 0x0779beec
	System.Void set_IsOutside(System.Boolean value); // 0x0779bf5c
	System.Void Init(); // 0x0779bfd8
	System.Int64 GetEntityId(); // 0x0779c980
	System.Void SetDescription(); // 0x0779c680
	System.Single GetWorldDistance(); // 0x0779ca60
	System.Void SetDistanceVisible(System.Boolean visible); // 0x0779cc14
	System.Void RefreshDistanceAndIcon(); // 0x0779cd40
	System.Void OnFps30Update(); // 0x0779d02c
	System.Void SetPos(); // 0x0779d098
	System.Void SetRotateNodeVisible(System.Boolean visible); // 0x0779d1b0
	System.Void SetRotation(System.Single rotation); // 0x0779d390
	System.Void OnTeamMemberDictChange(WizardGames.Soc.Share.Framework.ECustomDictOpType changeType, System.UInt64 roleId, WizardGames.Soc.Common.CustomType.TeamMemberInfo oldMember); // 0x0779d580
	System.Void SetColor(); // 0x0779c424
	System.Void OnRemove(); // 0x0779d614
	System.Void .ctor(); // 0x0779d740
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.HudDeathPointMarker : WizardGames.Soc.SocClient.Marker.HudSimpleMarker
{
	
	WizardGames.Soc.SocClient.Marker.MarkerDeathPointData get_MarkerData(); // 0x0779d7ec
	System.Void Init(); // 0x0779d8e4
	System.Void OnRefreshDeathPointMarker(System.Int64 id); // 0x0779dff0
	System.Void HideSelfWhenCfgDestory(); // 0x0779e204
	System.Void OnRemove(); // 0x0779e26c
	System.Void .ctor(); // 0x0779e4a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.HudDebugFlyPlayerMarker : WizardGames.Soc.SocClient.Marker.GMarkerBase, WizardGames.Soc.SocClient.Marker.IOutsideStatusMarker, WizardGames.Soc.SocClient.Marker.IMarker, WizardGames.Soc.SocClient.Marker.I30TickMarker
{
	System.Boolean <IsOutside>k__BackingField; // 0x44
	WizardGames.Soc.SocClient.Marker.MarkerPlayerData get_MarkerData(); // 0x0779e578
	WizardGames.Soc.SocClient.Marker.Ui.HudMarkerPlayerDebug_Binder get_UiMarker(); // 0x0779e670
	System.Void set_IsOutside(System.Boolean value); // 0x0779e71c
	WizardGames.Soc.Common.Entity.PlayerEntity get_PlayerEntity(); // 0x0779e798
	System.Void Init(); // 0x0779e848
	System.Void OnFps30Update(); // 0x0779e9cc
	System.Void SetRotateNodeVisible(System.Boolean visibel); // 0x0779ecec
	System.Void SetRotation(System.Single rotation); // 0x0779ed60
	System.Void OnRemove(); // 0x0779edd4
	System.Void .ctor(); // 0x0779ee54
	System.Void <Init>b__10_0(Config.LobbyRoleInfo userInfo); // 0x0779eeb8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.HudEntityMarker : WizardGames.Soc.SocClient.Marker.GMarkerBase, WizardGames.Soc.SocClient.Marker.IOutsideStatusMarker, WizardGames.Soc.SocClient.Marker.IMarker, WizardGames.Soc.SocClient.Marker.IDistanceVisibleMarker, WizardGames.Soc.SocClient.Marker.I30TickMarker
{
	System.Int32 traceDistance; // 0x44
	UnityEngine.Transform selfTransform; // 0x48
	System.Boolean <IsOutside>k__BackingField; // 0x50
	WizardGames.Soc.SocClient.Marker.MarkerEntityData get_MarkerData(); // 0x0779f0f4
	WizardGames.Soc.SocClient.Marker.Ui.HudMarkerSimple_Binder get_UiMarker(); // 0x0779f1ec
	System.Void set_IsOutside(System.Boolean value); // 0x0779f298
	System.Void SetDistanceVisible(System.Boolean visible); // 0x0779f314
	System.Void Init(); // 0x0779f440
	System.Void OnFps30Update(); // 0x0779f760
	System.Void SetRotateNodeVisible(System.Boolean visibel); // 0x0779fb9c
	System.Void SetRotation(System.Single rotation); // 0x0779fd7c
	System.Void OnRemove(); // 0x0779ff6c
	System.Void .ctor(); // 0x0779ffec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.HudGoldAirDropMarker : WizardGames.Soc.SocClient.Marker.HudSimpleMarker
{
	
	WizardGames.Soc.SocClient.Marker.MarkerGoldAirDropData get_MarkerData(); // 0x077a0058
	System.Void Init(); // 0x077a0150
	System.Void RefreshStatus(); // 0x077a026c
	System.Void OnRemove(); // 0x077a0464
	System.Void .ctor(); // 0x077a0580
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.HudMissionMarker : WizardGames.Soc.SocClient.Marker.HudSearchMarker
{
	
	System.Void Init(); // 0x077a05e4
	System.Void SetIconColor(); // 0x077a08d8
	System.Void CheckNeedHideOnInit(); // 0x077a0ad0
	System.Void ShowTaskMarker(System.Int64 missionId, UnityEngine.Vector2 pos); // 0x077a0bb8
	System.Void OnRemove(); // 0x077a0dcc
	System.Void .ctor(); // 0x077a10b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.HudNpcHeadMarker : WizardGames.Soc.SocClient.Marker.GMarkerBase, WizardGames.Soc.SocClient.Marker.IOutsideStatusMarker, WizardGames.Soc.SocClient.Marker.IMarker, WizardGames.Soc.SocClient.Marker.I30TickMarker, WizardGames.Soc.SocClient.Marker.IUnlimitedTickMarker
{
	System.Boolean valid; // 0x44
	UnityEngine.Transform myPlayerTransform; // 0x48
	System.Int32 traceDistance; // 0x50
	System.Boolean <IsOutside>k__BackingField; // 0x54
	WizardGames.Soc.SocClient.Marker.MarkerSearchData get_MarkerData(); // 0x077a117c
	WizardGames.Soc.SocClient.Marker.Ui.HudMarkerSimple_Binder get_UiMarker(); // 0x077a1274
	System.Void set_IsOutside(System.Boolean value); // 0x077a1320
	System.Void Init(); // 0x077a139c
	System.Void UpdateResult(); // 0x077a18a4
	System.Void OnFps30Update(); // 0x077a1b30
	System.Void OnUnlimitedUpdate(); // 0x077a1f54
	System.Void RefreshDistance(); // 0x077a1b94
	System.Void SetRotateNodeVisible(System.Boolean visibel); // 0x077a206c
	System.Void SetRotation(System.Single rotation); // 0x077a224c
	System.Void OnRemove(); // 0x077a243c
	System.Void RefreshMarkerName(); // 0x077a19d4
	System.Void .ctor(); // 0x077a2604
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.HudPlayerMarker : WizardGames.Soc.SocClient.Marker.GMarkerBase, WizardGames.Soc.SocClient.Marker.IOutsideStatusMarker, WizardGames.Soc.SocClient.Marker.IMarker, WizardGames.Soc.SocClient.Marker.I30TickMarker
{
	System.Int32 traceDistance; // 0x44
	System.Boolean <IsOutside>k__BackingField; // 0x48
	UnityEngine.Color oriColor; // 0x4c
	UnityEngine.Transform myPlayerTransform; // 0x60
	WizardGames.Soc.SocClient.Marker.MarkerPlayerData get_MarkerData(); // 0x077a2670
	WizardGames.Soc.SocClient.Marker.Ui.HudMarkerPlayer_Binder get_UiMarker(); // 0x077a2768
	System.Void set_IsOutside(System.Boolean value); // 0x077a2814
	System.UInt64 get_roleId(); // 0x077a2890
	UnityEngine.Vector3 get_WorldPosition(); // 0x077a2904
	WizardGames.Soc.Common.Entity.PlayerEntity get_PlayerEntity(); // 0x077a2974
	System.Void Init(); // 0x077a2a20
	System.Void OnFps30Update(); // 0x077a2ea4
	System.Single GetDyingProgress(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x077a383c
	System.Single GetAidingProgress(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x077a398c
	System.Int32 GetPlayerTemplateId(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x077a36f8
	System.Void RefreshDistance(); // 0x077a3a80
	System.Void SetRotateNodeVisible(System.Boolean visibel); // 0x077a3dfc
	System.Void SetRotation(System.Single rotation); // 0x077a3fdc
	System.Void OnRemove(); // 0x077a41cc
	System.Void .ctor(); // 0x077a424c
	System.Void <Init>b__17_0(System.String playerName); // 0x077a42b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.HudSearchMarker : WizardGames.Soc.SocClient.Marker.HudStrongpointMarker
{
	System.Boolean valid; // 0x78
	WizardGames.Soc.SocClient.Marker.MarkerSearchData get_MarkerData(); // 0x077a44ec
	System.Void Init(); // 0x077a07b4
	System.Void UpdateResult(); // 0x077a49f8
	System.Void OnFps30Update(); // 0x077a4b28
	System.Void OnRemove(); // 0x077a0f94
	System.Void .ctor(); // 0x077a1118
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.HudSimpleMarker : WizardGames.Soc.SocClient.Marker.GMarkerBase, WizardGames.Soc.SocClient.Marker.IOutsideStatusMarker, WizardGames.Soc.SocClient.Marker.IMarker, WizardGames.Soc.SocClient.Marker.IDistanceVisibleMarker, WizardGames.Soc.SocClient.Marker.I30TickMarker
{
	System.Int32 traceDistance; // 0x44
	UnityEngine.Transform selfTransform; // 0x48
	System.Boolean <IsOutside>k__BackingField; // 0x50
	WizardGames.Soc.SocClient.Marker.Ui.HudMarkerSimple_Binder get_UiMarker(); // 0x0779df44
	System.Void set_IsOutside(System.Boolean value); // 0x077a50f4
	System.Void SetDistanceVisible(System.Boolean visible); // 0x077a5170
	System.Void Init(); // 0x0779dbe8
	System.Void OnFps30Update(); // 0x077a529c
	System.Void SetRotateNodeVisible(System.Boolean visibel); // 0x077a5718
	System.Void SetRotation(System.Single rotation); // 0x077a58f8
	System.Void OnRemove(); // 0x0779e428
	System.Void .ctor(); // 0x0779e50c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.HudStrongpointMarker : WizardGames.Soc.SocClient.Marker.GMarkerBase, WizardGames.Soc.SocClient.Marker.IOutsideStatusMarker, WizardGames.Soc.SocClient.Marker.IMarker, WizardGames.Soc.SocClient.Marker.IFlyMarker, WizardGames.Soc.SocClient.Marker.IDistanceVisibleMarker, WizardGames.Soc.SocClient.Marker.I30TickMarker
{
	System.Int32 traceDistance; // 0x44
	UnityEngine.Transform selfTransform; // 0x48
	System.Boolean <IsOutside>k__BackingField; // 0x50
	UnityEngine.Vector2 <FlyBeginPosition>k__BackingField; // 0x54
	System.Single <FlyProgress>k__BackingField; // 0x5c
	System.Single <FlyProgressIncrement>k__BackingField; // 0x60
	System.Int64 <DelayFlyTime>k__BackingField; // 0x68
	System.Int64 <StayFlyTime>k__BackingField; // 0x70
	WizardGames.Soc.SocClient.Marker.Ui.HudMarkerSimple_Binder get_UiMarker(); // 0x077a0a24
	System.Void set_IsOutside(System.Boolean value); // 0x077a5ae8
	System.Void SetDistanceVisible(System.Boolean visible); // 0x077a5b64
	UnityEngine.Vector2 get_FlyBeginPosition(); // 0x077a5c90
	System.Void set_FlyBeginPosition(UnityEngine.Vector2 value); // 0x077a5cf0
	System.Single get_FlyProgress(); // 0x077a5d70
	System.Void set_FlyProgress(System.Single value); // 0x077a5dd4
	System.Single get_FlyProgressIncrement(); // 0x077a5e4c
	System.Void set_FlyProgressIncrement(System.Single value); // 0x077a5eb0
	System.Int64 get_DelayFlyTime(); // 0x077a5f28
	System.Void set_DelayFlyTime(System.Int64 value); // 0x077a5f8c
	System.Int64 get_StayFlyTime(); // 0x077a6004
	System.Void set_StayFlyTime(System.Int64 value); // 0x077a6068
	System.Void Init(); // 0x077a45e4
	System.Void CheckIsNeedSetFlyPosition(); // 0x077a60e0
	System.Void SetFlyBeginPosition(UnityEngine.Vector2 pos); // 0x077a0ccc
	System.Void OnFps30Update(); // 0x077a4c48
	System.Void SetRotateNodeVisible(System.Boolean visibel); // 0x077a65c0
	System.Void SetRotation(System.Single rotation); // 0x077a67a0
	System.Void OnRemove(); // 0x077a5008
	System.Void .ctor(); // 0x077a5088
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.HudTeachingNpcHeadMarker : WizardGames.Soc.SocClient.Marker.GMarkerBase, WizardGames.Soc.SocClient.Marker.IOutsideStatusMarker, WizardGames.Soc.SocClient.Marker.IMarker, WizardGames.Soc.SocClient.Marker.I30TickMarker, WizardGames.Soc.SocClient.Marker.IUnlimitedTickMarker
{
	System.Boolean valid; // 0x44
	UnityEngine.Transform myPlayerTransform; // 0x48
	System.Int32 traceDistance; // 0x50
	System.Boolean <IsOutside>k__BackingField; // 0x54
	WizardGames.Soc.SocClient.Marker.MarkerGameObjectData get_MarkerData(); // 0x077a6990
	WizardGames.Soc.SocClient.Marker.Ui.HudMarkerPlayer_Binder get_UiMarker(); // 0x077a6a88
	System.Void set_IsOutside(System.Boolean value); // 0x077a6b34
	System.Void Init(); // 0x077a6bb0
	System.Void OnFps30Update(); // 0x077a6f94
	System.Void OnUnlimitedUpdate(); // 0x077a73b8
	System.Void RefreshDistance(); // 0x077a6ff8
	System.Void SetRotateNodeVisible(System.Boolean visibel); // 0x077a74bc
	System.Void SetRotation(System.Single rotation); // 0x077a769c
	System.Void SetSesc(System.String desc); // 0x077a788c
	System.Void OnRemove(); // 0x077a7a7c
	System.Void .ctor(); // 0x077a7ba0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.HudTerritoryCenterMarker : WizardGames.Soc.SocClient.Marker.HudSimpleMarker
{
	
	System.Void Init(); // 0x077a7c0c
	System.Void IsStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Boolean oldVal, System.Boolean newVal); // 0x077a7e4c
	System.Void OnRemove(); // 0x077a8288
	System.Void .ctor(); // 0x077a8488
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MarkerExtensionLine : System.Object
{
	FairyGUI.GComponent com; // 0x10
	FairyGUI.GTextField itemName; // 0x18
	FairyGUI.Controller distancePos; // 0x20
	FairyGUI.GTextField txtDistance; // 0x28
	WizardGames.Soc.SocClient.Marker.IMarker aimMarker; // 0x30
	FairyGUI.GComponent markerContainer; // 0x38
	UnityEngine.Vector2 screenCenterPos; // 0x40
	UnityEngine.Transform myPlayerTrans; // 0x48
	System.Int32 distance; // 0x50
	System.Void .ctor(FairyGUI.GComponent com, FairyGUI.GComponent container); // 0x077a84ec
	System.Void Dispose(); // 0x077a875c
	System.Void CurMarkerChange(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x077a8868
	System.Single GetDistanceToScreenCenter(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x077a8b50
	System.Void RefreshLineInfo(); // 0x077a8a90
	System.Void GetMarkerName(System.String& name); // 0x077a8cd0
	System.Void OnFpsUnlimitedUpdate(); // 0x077a9278
	System.Void SetPosition(); // 0x077a95ec
	System.Void RemoveMarker(System.Int64 markerId); // 0x077a9a6c
	System.Void SetVisible(System.Boolean value); // 0x077a9564
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.BedMarker : WizardGames.Soc.SocClient.Marker.MapSimpleMarker, WizardGames.Soc.SocClient.Marker.I1TickMarker, WizardGames.Soc.SocClient.Marker.IMarker
{
	System.Single cdTotalTime; // 0x6c
	FairyGUI.GImage cdImage; // 0x70
	FairyGUI.GTextField timeText; // 0x78
	WizardGames.Soc.SocClient.Marker.MarkerBedData get_MarkerData(); // 0x077a9b88
	System.Void Init(); // 0x077a9c80
	System.Void InitUiMarker(); // 0x077aa408
	System.Void OnFps1Update(); // 0x077aaf7c
	System.Void UpdateBedCdTime(); // 0x077a9f24
	System.Void UpdateBedPos(); // 0x077aafe0
	System.Void OnRemove(); // 0x077ab0d4
	System.Void .ctor(); // 0x077ab568
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.CarMarker : WizardGames.Soc.SocClient.Marker.MapSimpleMarker, WizardGames.Soc.SocClient.Marker.I1TickMarker, WizardGames.Soc.SocClient.Marker.IMarker
{
	
	WizardGames.Soc.SocClient.Marker.MarkerEntityData get_MarkerData(); // 0x077ab64c
	System.Void Init(); // 0x077ab744
	System.Void OnRemove(); // 0x077ab82c
	System.Void OnFps1Update(); // 0x077ab914
	System.Void .ctor(); // 0x077abcec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.CombatEntityMarker : WizardGames.Soc.SocClient.Marker.CombatMarker, WizardGames.Soc.SocClient.Marker.I30TickMarker, WizardGames.Soc.SocClient.Marker.IMarker
{
	
	System.Void OnFps30Update(); // 0x077abd50
	System.Void InitUiMarker(); // 0x077ac3d0
	System.Void .ctor(); // 0x077ac6e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.CombatMarker : WizardGames.Soc.SocClient.Marker.MapSimpleMarker
{
	
	WizardGames.Soc.SocClient.Marker.MarkerCombatData get_MarkerData(); // 0x077ac2d8
	System.Boolean get_IsSelfCreated(); // 0x077ac7a8
	System.Void Init(); // 0x077ac854
	System.Void RefreshVisible(); // 0x077ac9e0
	System.Void OnTeamMemberDictChange(WizardGames.Soc.Share.Framework.ECustomDictOpType changeType, System.UInt64 roleId, WizardGames.Soc.Common.CustomType.TeamMemberInfo oldMember); // 0x077acefc
	System.Void SetColor(); // 0x077acca0
	System.Void OnRemove(); // 0x077acf90
	System.Void .ctor(); // 0x077ac744
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.CustomNameMarker : WizardGames.Soc.SocClient.Marker.MapSimpleMarker
{
	
	WizardGames.Soc.SocClient.Marker.MarkerNameData get_MarkerData(); // 0x077ad10c
	System.Void Init(); // 0x077ad204
	System.Void .ctor(); // 0x077ad38c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.DeathPointMarker : WizardGames.Soc.SocClient.Marker.MapSimpleMarker
{
	
	WizardGames.Soc.SocClient.Marker.MarkerDeathPointData get_MarkerData(); // 0x077ad3f0
	System.Boolean get_isSelfDestroy(); // 0x077ad4e8
	System.Void Init(); // 0x077ad610
	System.Void PosChange(); // 0x077adab4
	System.Void UpdateMarker(); // 0x077ad864
	System.Void OnRefreshDeathPointMarker(System.Int64 id); // 0x077adba8
	System.Void OnRemove(); // 0x077adca8
	System.Void HideSelfWhenCfgDestory(); // 0x077adef4
	System.Void .ctor(); // 0x077adf74
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.GoldAirDropMarker : WizardGames.Soc.SocClient.Marker.MapSimpleMarker
{
	
	WizardGames.Soc.SocClient.Marker.MarkerGoldAirDropData get_MarkerData(); // 0x077adfd8
	System.Void Init(); // 0x077ae0d0
	System.Void InitUiMarker(); // 0x077ae3ec
	System.Void RefreshStatus(); // 0x077ae1f4
	System.Void OnRemove(); // 0x077ae5b0
	System.Void .ctor(); // 0x077ae6cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.KatyushaTargetMarker : WizardGames.Soc.SocClient.Marker.GMarkerBase
{
	System.Int64 timerId; // 0x48
	System.Int32 cdTime; // 0x50
	WizardGames.Soc.SocClient.Marker.Ui.MapMarkerKatyusha_Binder get_kUiMarker(); // 0x077ae730
	System.Void Init(); // 0x077ae7dc
	System.Void HideNode(); // 0x077aec04
	System.Void SetMarkerPosition(UnityEngine.Vector3 pos, System.Boolean isFiring); // 0x0551b6b0
	System.Void SetCdTime(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x077af52c
	System.Void SetProcessBarVisible(System.Single percent); // 0x077af23c
	System.Void ClearTimer(); // 0x077af420
	System.Void OnRemove(); // 0x077af644
	System.Void .ctor(); // 0x077af76c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MapSimpleMarker : WizardGames.Soc.SocClient.Marker.GMarkerBase, WizardGames.Soc.SocClient.Marker.IClusterMarker, WizardGames.Soc.SocClient.Marker.ISelectMarker, WizardGames.Soc.SocClient.Marker.IMarker, WizardGames.Soc.SocClient.Marker.IZoomHideMarker, WizardGames.Soc.SocClient.Marker.I30TickMarker, WizardGames.Soc.SocClient.Marker.IMapLevelDependentMarker, WizardGames.Soc.SocClient.Marker.IFilterMarker, WizardGames.Soc.SocClient.Utility.IGridElement
{
	System.Boolean isSelected; // 0x44
	System.Int32 clusterCount; // 0x48
	System.Boolean isZoomHide; // 0x4c
	WizardGames.Soc.SocClient.Marker.LevelMarkerState levelState; // 0x50
	WizardGames.Soc.SocClient.Marker.FilterMarkerState filterState; // 0x54
	WizardGames.Soc.SocClient.Marker.EClusterRole role; // 0x58
	System.Int32 traceDistance; // 0x5c
	UnityEngine.Transform selfTransform; // 0x60
	System.Boolean <IsOnGround>k__BackingField; // 0x68
	WizardGames.Soc.SocClient.Marker.Ui.MapMarkerSimple_Binder get_UiMarker(); // 0x077aaed0
	System.Int64 get_GridUniqueId(); // 0x077af7d8
	System.Single get_WorldPosX(); // 0x077af83c
	System.Single get_WorldPosZ(); // 0x077af8e4
	System.Void Init(); // 0x077a9da4
	System.Void InitUiMarker(); // 0x077aa7f8
	System.Void OnTrackChange(System.Int64 uniqueId); // 0x077afd08
	System.Void UpdateDistanceTextVisibleBase(); // 0x077afa98
	System.Void UpdateDistanceTextVisibleOfOverflowHoverShow(); // 0x077afd80
	System.Boolean CanCluster(); // 0x077aff18
	System.Boolean CanSelected(); // 0x077af990
	System.Boolean CanZoomHide(); // 0x077b0020
	System.Boolean CanMapLevelDependent(); // 0x077b0234
	System.Boolean CanFilter(); // 0x077b030c
	System.Boolean get_IsSelected(); // 0x077b0414
	System.Void set_IsSelected(System.Boolean value); // 0x077b0478
	System.Void MarkerSelected(); // 0x077b06c8
	System.Boolean get_IsZoomHide(); // 0x077b0728
	System.Void set_IsZoomHide(System.Boolean value); // 0x077b078c
	System.Void set_ClusterCount(System.Int32 value); // 0x077b0840
	System.Void set_Role(WizardGames.Soc.SocClient.Marker.EClusterRole value); // 0x077b09d0
	WizardGames.Soc.SocClient.Marker.LevelMarkerState get_LevelState(); // 0x077b0c4c
	System.Void set_LevelState(WizardGames.Soc.SocClient.Marker.LevelMarkerState value); // 0x077b0cb0
	WizardGames.Soc.SocClient.Marker.FilterMarkerState get_FilterState(); // 0x077b0ee8
	System.Void set_FilterState(WizardGames.Soc.SocClient.Marker.FilterMarkerState value); // 0x077b0f4c
	UnityEngine.Vector2 get_ClusterContainerPos(); // 0x077b1000
	System.Boolean get_IsOnGround(); // 0x077b117c
	System.Void set_IsOnGround(System.Boolean value); // 0x077b11e0
	System.Void OnFps30Update(); // 0x077abedc
	System.Void OnMarkerClick(); // 0x077b125c
	System.Void OnRemove(); // 0x077ab2e4
	System.Void .ctor(); // 0x077ab5d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MapSimpleObPlayerMarker : WizardGames.Soc.SocClient.Marker.GMarkerBase, WizardGames.Soc.SocClient.Marker.IClusterMarker, WizardGames.Soc.SocClient.Marker.ISelectMarker, WizardGames.Soc.SocClient.Marker.IMarker, WizardGames.Soc.SocClient.Marker.IZoomHideMarker, WizardGames.Soc.SocClient.Marker.IMapLevelDependentMarker, WizardGames.Soc.SocClient.Marker.IFilterMarker, WizardGames.Soc.SocClient.Utility.IGridElement
{
	System.Boolean isSelected; // 0x44
	System.Int32 clusterCount; // 0x48
	System.Boolean isZoomHide; // 0x4c
	WizardGames.Soc.SocClient.Marker.LevelMarkerState levelState; // 0x50
	WizardGames.Soc.SocClient.Marker.FilterMarkerState filterState; // 0x54
	WizardGames.Soc.SocClient.Marker.EClusterRole role; // 0x58
	System.Int32 traceDistance; // 0x5c
	UnityEngine.Transform selfTransform; // 0x60
	System.Boolean <IsOnGround>k__BackingField; // 0x68
	WizardGames.Soc.SocClient.Marker.Ui.ObMapMarkerPlayer_Binder get_UiMarker(); // 0x077b1814
	System.Int64 get_GridUniqueId(); // 0x077b18c0
	System.Single get_WorldPosX(); // 0x077b1924
	System.Single get_WorldPosZ(); // 0x077b19cc
	System.Void Init(); // 0x077b1a78
	System.Void InitUiMarker(); // 0x077b1bf8
	System.Void OnTrackChange(System.Int64 uniqueId); // 0x077b22f0
	System.Void set_ClusterCount(System.Int32 value); // 0x077b2364
	System.Boolean CanCluster(); // 0x077b23e8
	System.Boolean CanSelected(); // 0x077b21e8
	System.Boolean CanZoomHide(); // 0x077b24f0
	System.Boolean CanMapLevelDependent(); // 0x077b2704
	System.Boolean CanFilter(); // 0x077b27dc
	System.Boolean get_IsSelected(); // 0x077b28e4
	System.Void set_IsSelected(System.Boolean value); // 0x077b2948
	System.Void MarkerSelected(); // 0x077b29f4
	System.Boolean get_IsZoomHide(); // 0x077b2a54
	System.Void set_IsZoomHide(System.Boolean value); // 0x077b2ab8
	System.Void set_Role(WizardGames.Soc.SocClient.Marker.EClusterRole value); // 0x077b2b6c
	WizardGames.Soc.SocClient.Marker.LevelMarkerState get_LevelState(); // 0x077b2c20
	System.Void set_LevelState(WizardGames.Soc.SocClient.Marker.LevelMarkerState value); // 0x077b2c84
	WizardGames.Soc.SocClient.Marker.FilterMarkerState get_FilterState(); // 0x077b2ebc
	System.Void set_FilterState(WizardGames.Soc.SocClient.Marker.FilterMarkerState value); // 0x077b2f20
	UnityEngine.Vector2 get_ClusterContainerPos(); // 0x077b2fd4
	System.Boolean get_IsOnGround(); // 0x077b3150
	System.Void set_IsOnGround(System.Boolean value); // 0x077b31b4
	System.Void OnMarkerClick(); // 0x077b3230
	System.Void OnRemove(); // 0x077b37e8
	System.Void .ctor(); // 0x077b3a6c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MapSimpleObTerritoryCenterMarker : WizardGames.Soc.SocClient.Marker.GMarkerBase, WizardGames.Soc.SocClient.Marker.IClusterMarker, WizardGames.Soc.SocClient.Marker.ISelectMarker, WizardGames.Soc.SocClient.Marker.IMarker, WizardGames.Soc.SocClient.Marker.IZoomHideMarker, WizardGames.Soc.SocClient.Marker.IMapLevelDependentMarker, WizardGames.Soc.SocClient.Marker.IFilterMarker, WizardGames.Soc.SocClient.Utility.IGridElement
{
	System.Boolean isSelected; // 0x44
	System.Int32 clusterCount; // 0x48
	System.Boolean isZoomHide; // 0x4c
	WizardGames.Soc.SocClient.Marker.LevelMarkerState levelState; // 0x50
	WizardGames.Soc.SocClient.Marker.FilterMarkerState filterState; // 0x54
	WizardGames.Soc.SocClient.Marker.EClusterRole role; // 0x58
	System.Int32 traceDistance; // 0x5c
	UnityEngine.Transform selfTransform; // 0x60
	System.Boolean <IsOnGround>k__BackingField; // 0x68
	WizardGames.Soc.SocClient.Marker.Ui.ObMapMarkerTerritoryCabinet_Binder get_UiMarker(); // 0x077b3ae0
	System.Int64 get_GridUniqueId(); // 0x077b3b8c
	System.Single get_WorldPosX(); // 0x077b3bf0
	System.Single get_WorldPosZ(); // 0x077b3c98
	System.Void Init(); // 0x077b3d44
	System.Void InitUiMarker(); // 0x077b3ec4
	System.Void OnTrackChange(System.Int64 uniqueId); // 0x077b4480
	System.Void set_ClusterCount(System.Int32 value); // 0x077b44f4
	System.Boolean CanCluster(); // 0x077b4578
	System.Boolean CanSelected(); // 0x077b4378
	System.Boolean CanZoomHide(); // 0x077b4680
	System.Boolean CanMapLevelDependent(); // 0x077b4894
	System.Boolean CanFilter(); // 0x077b496c
	System.Boolean get_IsSelected(); // 0x077b4a74
	System.Void set_IsSelected(System.Boolean value); // 0x077b4ad8
	System.Void MarkerSelected(); // 0x077b4b84
	System.Boolean get_IsZoomHide(); // 0x077b4be4
	System.Void set_IsZoomHide(System.Boolean value); // 0x077b4c48
	System.Void set_Role(WizardGames.Soc.SocClient.Marker.EClusterRole value); // 0x077b4cfc
	WizardGames.Soc.SocClient.Marker.LevelMarkerState get_LevelState(); // 0x077b4db0
	System.Void set_LevelState(WizardGames.Soc.SocClient.Marker.LevelMarkerState value); // 0x077b4e14
	WizardGames.Soc.SocClient.Marker.FilterMarkerState get_FilterState(); // 0x077b504c
	System.Void set_FilterState(WizardGames.Soc.SocClient.Marker.FilterMarkerState value); // 0x077b50b0
	UnityEngine.Vector2 get_ClusterContainerPos(); // 0x077b5164
	System.Boolean get_IsOnGround(); // 0x077b52e0
	System.Void set_IsOnGround(System.Boolean value); // 0x077b5344
	System.Void OnMarkerClick(); // 0x077b53c0
	System.Void OnRemove(); // 0x077b57cc
	System.Void .ctor(); // 0x077b5a50
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MissionMarker : WizardGames.Soc.SocClient.Marker.SearchMarker
{
	
	System.Void Init(); // 0x077b5ac4
	System.Void SetIconColor(); // 0x077b5b34
	System.Void .ctor(); // 0x077b5c80
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MonumentMarker : WizardGames.Soc.SocClient.Marker.MapSimpleMarker
{
	System.Int64 curMonumentBoxId; // 0x70
	WizardGames.Soc.SocClient.Marker.MarkerMonumentData get_MarkerData(); // 0x077b5ce8
	WizardGames.Soc.Common.Data.monument.MonumentInformation get_info(); // 0x077b5de0
	System.Void InitUiMarker(); // 0x077b5e54
	WizardGames.Soc.Common.Data.monument.MonumentInformation GetInfo(); // 0x077b6124
	System.Void Init(); // 0x077b6188
	System.Void OnRemove(); // 0x077b6c54
	System.Void InitMonumentBox(); // 0x077b6248
	System.Void SubscribeMonumentBox(); // 0x077b697c
	System.Void UnSubscribeMonumentBox(); // 0x077b6d04
	System.Void RefreshBoxInfo(WizardGames.Soc.Share.Framework.ECustomHashSetOpType opType, System.Int64 id); // 0x077b7128
	System.Void SubscribeMonumentOpenStatus(); // 0x077b6ae8
	System.Void UnSubscribeMonumentOpenStatus(); // 0x077b6e70
	System.Void DynamicMonumentIdChanged(WizardGames.Soc.Share.Framework.CustomTypeBase _, System.Int32 oldValue, System.Int32 newValue); // 0x077b725c
	System.Void RefreshMonumentOpenStatus(); // 0x077b65e4
	System.Void RefreshBoxStatus(); // 0x077b6fdc
	System.Void .ctor(); // 0x077b72f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MyPlayerMarker : WizardGames.Soc.SocClient.Marker.PlayerMarker, WizardGames.Soc.SocClient.Marker.I1TickMarker, WizardGames.Soc.SocClient.Marker.IMarker, WizardGames.Soc.SocClient.Marker.IUnlimitedTickMarker
{
	System.Int32 currentIconId; // 0x50
	WizardGames.Soc.SocClient.Marker.MarkerMyPlayerData get_MarkerData(); // 0x077b735c
	System.Void Init(); // 0x077b7414
	System.Void InitUiMarker(); // 0x077b79ec
	System.Void UpdateMyState(WizardGames.Soc.Common.Entity.IEntity entity, System.Int32 oldValue, System.Int32 newValue); // 0x077b76d0
	System.Void OnRemove(); // 0x077b7bf8
	System.Void OnUnlimitedUpdate(); // 0x077b7d10
	System.Void OnFps1Update(); // 0x077b811c
	System.Void RefreshTeamAppearance(WizardGames.Soc.Share.Framework.ECustomDictOpType changeType, System.UInt64 roleId, WizardGames.Soc.Common.CustomType.TeamMemberInfo oldMember); // 0x077b83b4
	System.Void .ctor(); // 0x077b8598
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.ObserverObPlayerMarker : WizardGames.Soc.SocClient.Marker.MapSimpleObPlayerMarker, WizardGames.Soc.SocClient.Marker.I1TickMarker, WizardGames.Soc.SocClient.Marker.IMarker
{
	
	WizardGames.Soc.SocClient.Marker.MarkerObPlayerData get_MarkerData(); // 0x077b87a4
	WizardGames.Soc.SocClient.Marker.Ui.ObMapMarkerPlayer_Binder get_UiMarker(); // 0x077b889c
	System.Void Init(); // 0x077b8948
	System.Void InitUiMarker(); // 0x077b8ed0
	System.Void ResreshObPlayerMarkerBaseInfo(); // 0x077b89cc
	System.Void OnFps1Update(); // 0x077b956c
	System.Void RefreshPosAndRotate(); // 0x077b95e0
	System.Void RefreshObPlayerMarkerInfo(); // 0x077b9834
	System.Void RefrehObPlayerMarkerTeamIndex(WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo playerBriefInfo); // 0x077b9058
	System.Void RefreshObPlayerMarkerStatus(WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo playerBriefInfo); // 0x077b9dac
	System.Void RefreshMarkerBriefInfoRange(System.Single newScale); // 0x077ba1f8
	System.Void OnRemove(); // 0x077ba2d0
	System.Void .ctor(); // 0x077ba350
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.ObserverObTerritoryCenterMarker : WizardGames.Soc.SocClient.Marker.MapSimpleObTerritoryCenterMarker, WizardGames.Soc.SocClient.Marker.I1TickMarker, WizardGames.Soc.SocClient.Marker.IMarker
{
	
	WizardGames.Soc.SocClient.Marker.MarkerObTerritoryCabinetData get_MarkerData(); // 0x077ba3b8
	WizardGames.Soc.SocClient.Marker.Ui.ObMapMarkerTerritoryCabinet_Binder get_UiMarker(); // 0x077ba4b0
	System.Void Init(); // 0x077ba55c
	System.Void RefreshMarkerInfo(); // 0x077ba5cc
	WizardGames.Soc.SocClient.Marker.ObserverObTerritoryCenterMarker.ETerritoryCenterShowType GetTerritoryCenterShowType(); // 0x077bae78
	System.Void RefreshMarkName(); // 0x077bad48
	System.Void OnFps1Update(); // 0x077bb3cc
	System.String GetTerritoryName(); // 0x077bb194
	System.Void MarkerSelected(); // 0x077bb430
	System.Void OpenUiGameOBTerritoryInfoPanel(); // 0x077bb4a0
	System.Void RefreshMarkerBriefInfoRange(System.Single newScale); // 0x077bb644
	System.Void OnRemove(); // 0x077bb71c
	System.Void .ctor(); // 0x077bb79c
	System.Void <OpenUiGameOBTerritoryInfoPanel>b__12_0(WizardGames.Soc.SocClient.Ui.UiGameOBTerritoryInfo win); // 0x077bb804
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Marker.ObserverObTerritoryCenterMarker.ETerritoryCenterShowType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Marker.ObserverObTerritoryCenterMarker.ETerritoryCenterShowType Normal = 0;
	static WizardGames.Soc.SocClient.Marker.ObserverObTerritoryCenterMarker.ETerritoryCenterShowType Stair = 1;
	static WizardGames.Soc.SocClient.Marker.ObserverObTerritoryCenterMarker.ETerritoryCenterShowType Vfp = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.ObserverPlayerMarker : WizardGames.Soc.SocClient.Marker.MapSimpleMarker, WizardGames.Soc.SocClient.Marker.I1TickMarker, WizardGames.Soc.SocClient.Marker.IMarker
{
	
	System.Void Init(); // 0x077bb8e4
	System.Void OnFps1Update(); // 0x077bbd0c
	System.Void OnRemove(); // 0x077bbed0
	System.Void .ctor(); // 0x077bbf38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.ObserverTerritoryCenterMarker : WizardGames.Soc.SocClient.Marker.MapSimpleMarker
{
	
	System.Void Init(); // 0x077bbfa0
	System.String GetTerritoryName(); // 0x077bc0e0
	System.Void MarkerSelected(); // 0x077bc1f4
	System.Void OnRemove(); // 0x077bc334
	System.Void .ctor(); // 0x077bc39c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.OutpostRebornMarker : WizardGames.Soc.SocClient.Marker.MapSimpleMarker, WizardGames.Soc.SocClient.Marker.I1TickMarker, WizardGames.Soc.SocClient.Marker.IMarker
{
	System.Single cdTotalTime; // 0x6c
	FairyGUI.GImage cdImage; // 0x70
	FairyGUI.GTextField timeText; // 0x78
	System.Int64 unlockTime; // 0x80
	System.Void Init(); // 0x077bc404
	System.Void InitUiMarker(); // 0x077bc814
	System.Void OnFps1Update(); // 0x077bcad4
	System.Void UpdateBedCdTime(); // 0x077bc4c4
	System.Void OnRemove(); // 0x077bcb38
	System.Void .ctor(); // 0x077bcc9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.PlayerMarker : WizardGames.Soc.SocClient.Marker.GMarkerBase, WizardGames.Soc.SocClient.Marker.IMapLevelDependentMarker, WizardGames.Soc.SocClient.Marker.IMarker, WizardGames.Soc.SocClient.Marker.IFilterMarker
{
	WizardGames.Soc.SocClient.Marker.LevelMarkerState levelState; // 0x44
	WizardGames.Soc.SocClient.Marker.FilterMarkerState filterState; // 0x48
	System.Boolean <IsOnGround>k__BackingField; // 0x4c
	WizardGames.Soc.SocClient.Marker.MarkerPlayerData get_MarkerData(); // 0x077bcda0
	WizardGames.Soc.SocClient.Marker.Ui.MapMarkerPlayer_Binder get_UiMarker(); // 0x077bce98
	System.Void Init(); // 0x077bcf44
	System.Void InitUiMarker(); // 0x077bcfb4
	System.Void OnRemove(); // 0x077bd13c
	System.Boolean CanMapLevelDependent(); // 0x077bd1c4
	System.Boolean CanFilter(); // 0x077bd238
	System.Boolean get_IsOnGround(); // 0x077bd530
	System.Void set_IsOnGround(System.Boolean value); // 0x077bd594
	WizardGames.Soc.SocClient.Marker.LevelMarkerState get_LevelState(); // 0x077bd610
	System.Void set_LevelState(WizardGames.Soc.SocClient.Marker.LevelMarkerState value); // 0x077bd674
	WizardGames.Soc.SocClient.Marker.FilterMarkerState get_FilterState(); // 0x077bda24
	System.Void set_FilterState(WizardGames.Soc.SocClient.Marker.FilterMarkerState value); // 0x077bda88
	System.Void .ctor(); // 0x077bdb40
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.PurchasableVehicleMarker : WizardGames.Soc.SocClient.Marker.MapSimpleMarker, WizardGames.Soc.SocClient.Marker.I1TickMarker, WizardGames.Soc.SocClient.Marker.IMarker
{
	
	WizardGames.Soc.SocClient.Marker.MarkerEntityData get_MarkerData(); // 0x077bdba8
	System.Void Init(); // 0x077bdca0
	System.Void OnFps1Update(); // 0x077bdd94
	System.Void OnRemove(); // 0x077be008
	System.Void .ctor(); // 0x077be0f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.ReportBanMarker : WizardGames.Soc.SocClient.Marker.MapSimpleMarker
{
	
	System.Void Init(); // 0x077be15c
	System.Void RefreshPosition(System.Int64 markerId); // 0x077be274
	System.Void OnRemove(); // 0x077be3fc
	System.Void .ctor(); // 0x077be514
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.SDJTeamMarker : WizardGames.Soc.SocClient.Marker.MapSimpleMarker
{
	
	WizardGames.Soc.SocClient.Marker.MarkerSDJTeamData get_MarkerData(); // 0x077be57c
	System.Void Init(); // 0x077be674
	System.Void RefreshName(); // 0x077be79c
	System.Void OnRemove(); // 0x077be98c
	System.Void .ctor(); // 0x077beaac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.SearchMarker : WizardGames.Soc.SocClient.Marker.MapSimpleMarker, WizardGames.Soc.SocClient.Marker.I30TickMarker, WizardGames.Soc.SocClient.Marker.IMarker
{
	System.Boolean valid; // 0x69
	System.Boolean isInited; // 0x6a
	WizardGames.Soc.SocClient.Marker.MarkerSearchData get_MarkerData(); // 0x077beb14
	System.Void Init(); // 0x077bec0c
	System.Void UpdateResult(); // 0x077bedd4
	System.Void OnRemove(); // 0x077bf074
	System.Void OnFps30Update(); // 0x077bf228
	System.Void RefreshMarkerName(); // 0x077bef14
	System.Void .ctor(); // 0x077bf3d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.ShopMarker : WizardGames.Soc.SocClient.Marker.MapSimpleMarker
{
	
	System.Void Init(); // 0x077bf438
	System.Void RefreshPosition(System.Int64 shopId); // 0x077bf550
	System.Void OnRemove(); // 0x077bf6d8
	System.Void .ctor(); // 0x077bf7f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.TeammateMarker : WizardGames.Soc.SocClient.Marker.PlayerMarker, WizardGames.Soc.SocClient.Marker.ISelectMarker, WizardGames.Soc.SocClient.Marker.IMarker, WizardGames.Soc.SocClient.Marker.I1TickMarker, WizardGames.Soc.SocClient.Utility.IGridElement
{
	System.Int32 currentIconId; // 0x50
	System.Boolean isSelected; // 0x54
	System.UInt64 get_roleId(); // 0x077bf858
	System.Int64 get_GridUniqueId(); // 0x077bf8cc
	System.Single get_WorldPosX(); // 0x077bf934
	System.Single get_WorldPosZ(); // 0x077bf9dc
	System.Boolean get_IsSelected(); // 0x077bfa88
	System.Void set_IsSelected(System.Boolean value); // 0x077bfaec
	System.Int32 get_curIconId(); // 0x077bfc70
	System.Void set_curIconId(System.Int32 value); // 0x077bfcd4
	WizardGames.Soc.Common.Entity.PlayerEntity get_PlayerEntity(); // 0x077c0618
	System.Void Init(); // 0x077c06c4
	System.Void InitUiMarker(); // 0x077c10c8
	System.Void OnFps1Update(); // 0x077c1678
	System.Void OnTeamMemberChange(WizardGames.Soc.Share.Framework.ECustomDictOpType changeType, System.UInt64 roleId, WizardGames.Soc.Common.CustomType.TeamMemberInfo oldMember); // 0x077c1a18
	System.Void RefreshTeamAppearance(); // 0x077c1370
	System.Void UpdateProperties(); // 0x077c08e8
	System.Single GetDyingProgress(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x077c1d14
	System.Single GetAidingProgress(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x077c1c20
	System.Void OnRemove(); // 0x077c1e64
	System.Void .ctor(); // 0x077c1f80
	System.Void <InitUiMarker>b__19_0(System.String playerName); // 0x077c1fe4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.TerritoryCenterMarker : WizardGames.Soc.SocClient.Marker.MapSimpleMarker
{
	
	System.Void Init(); // 0x077c2218
	System.Void InitUiMarker(); // 0x077c2884
	System.Void IsStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase customType, System.Boolean oldVal, System.Boolean newVal); // 0x077c27f0
	System.Void RefreshTerritoryIconUrl(); // 0x077c28f4
	System.Void RefreshPosition(System.Int64 centerId); // 0x077c2e00
	System.String GetTerritoryName(); // 0x077c25fc
	System.Void MarkerSelected(); // 0x077c2f88
	System.Void OnRemove(); // 0x077c30c8
	System.Void .ctor(); // 0x077c33b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MarkerUtil : System.Object
{
	static SocLogger logger; // 0x0
	static System.String GetIconUrl(System.Int32 iconTemplateId, WizardGames.Soc.SocClient.Marker.MarkerBaseData data); // 0x077c0060
	static UnityEngine.Vector2 GetIconPivot(System.Int32 iconTemplateId); // 0x077c03cc
	static WizardGames.Soc.SocClient.Marker.MarkerMapLevelRule GetMarkerLevelRule(WizardGames.Soc.Common.Data.mapmark.NewMarker markerConfig); // 0x077c341c
	static System.Boolean IsClusterTypeMarker(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x077c3498
	static System.Boolean IsMergeTypeMarker(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x077c354c
	static System.Boolean IsStackTypeMarker(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x077c3634
	static System.Boolean IsSelectTypeMarker(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x077c3714
	static System.Boolean IsZoomHideTypeMarker(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x077c37fc
	static System.Boolean IsFilterTypeMarker(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x077bd448
	static System.Boolean IsOnlyShowOnTrack(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x077c38ec
	static System.Int32 CompareMarkerPriority(WizardGames.Soc.SocClient.Marker.IMarker markerA, WizardGames.Soc.SocClient.Marker.IMarker markerB); // 0x077c39cc
	static System.Boolean CanClusterRebuildByMapScale(System.Single oldMapScale, System.Single newMapScale, System.Single rangeMax, System.Single rangeMin); // 0x077c415c
	static UnityEngine.Vector2 GetRightCenterOffset(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x077c431c
	static System.Boolean IsPositionOnGround(UnityEngine.Vector3 checkPosition); // 0x077c1030
	static UnityEngine.Color GetTeamColor(System.UInt64 roleId); // 0x077c04e8
	static System.Int32 GetTeamMemberPosition(System.UInt64 roleId); // 0x077c1aac
	static System.Boolean CheckIsTreeSearch(System.Int64 searchId); // 0x077c448c
	static System.String GetMissionMarkerColor(System.Int64 missionId); // 0x077c465c
	static System.Boolean IsCombatMarkerType(WizardGames.Soc.Common.Data.MarkerType type); // 0x077c4828
	static System.Void .cctor(); // 0x077c4894
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MgrMarker : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Boolean isRemovedMarker; // 0x11
	System.Int64 buildCollapseMarkerId; // 0x18
	static SocLogger logger; // 0x0
	System.Boolean DisableCombatMarker; // 0x20
	System.String[] TeamMemberColors; // 0x28
	UnityEngine.Color TeamColor0; // 0x30
	UnityEngine.Color TeamColorEnemy; // 0x40
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.MarkerType,System.Single> combatMarkerVoiceTime; // 0x50
	System.Int64 createCombatMarkerCd; // 0x58
	static SocLogger <log>k__BackingField; // 0x8
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Marker.MarkerBaseData> markerDataMap; // 0x60
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.MarkerType,System.Collections.Generic.List<WizardGames.Soc.SocClient.Marker.MarkerBaseData>> type2MarkerDataList; // 0x68
	WizardGames.Soc.SocClient.Marker.MarkerBaseData <curTrackMarkerData>k__BackingField; // 0x70
	UnityEngine.Vector2 ScreenCenter; // 0x78
	System.Action<WizardGames.Soc.SocClient.Marker.MarkerBaseData> onDataCreate; // 0x80
	System.Action<System.Int64> onDataRemove; // 0x88
	System.Action<System.Int64> onCancelTrack; // 0x90
	System.Action<System.Int64> onCreateTrack; // 0x98
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> PatrolCarEntityId2RoadBeginPointId; // 0xa0
	System.Boolean markerDataHasInit; // 0xa8
	System.Int64 needClearBpHouseMarkerId; // 0xb0
	System.Boolean hideTeamCombatMarker; // 0xb8
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> Id2MonumentIdMap; // 0xc0
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> MonumentBiomeMap; // 0xc8
	System.Int32 BeforeIOTaskId; // 0xd0
	System.Int32 cacheDeadSheepTalentLevel; // 0xd4
	System.Collections.Generic.HashSet<System.UInt64> cacheTeammateRoleIds; // 0xd8
	System.Int64 sdjTeamMarkerTrackTimerId; // 0xe0
	UnityEngine.Vector3 curTrackTeamMarkerPos; // 0xe8
	System.Collections.Generic.HashSet<System.Int64> missionIdsNeedFlyAni; // 0xf8
	System.Action OnFlyMissionAdd; // 0x100
	System.Int64 needOutlineEntityId; // 0x108
	System.Void RefreshBuildCollapseMarker(WizardGames.Soc.Common.Entity.PartEntity partGo); // 0x077c4968
	System.Void RemoveBuildCollapseMarker(); // 0x077c55ec
	System.Void OnBuildCollapseInfoChange(System.Collections.Generic.List<WizardGames.Soc.Common.Entity.PartEntity> partGoes, System.Boolean isVirtual); // 0x077c58e4
	System.Void CreateCarMarkerInit(); // 0x077c5a60
	System.Void CreatePatrolStartMarker(System.Int64 vehicleEntityId); // 0x077c635c
	WizardGames.Soc.SocClient.Marker.MarkerEntityData GetCarMarkerDataByEntityId(System.Int64 entityId); // 0x077c5fa8
	System.Void RefreshPatrolCarInfo(WizardGames.Soc.Share.Framework.ECustomHashSetOpType opType, System.Int64 id); // 0x077c65ac
	System.Single get_pixelFactor(); // 0x077c67a8
	System.Single get_CombatMarker_AimRange(); // 0x077c686c
	System.Single get_CombatMarker_HudCircleRange3(); // 0x077c6974
	WizardGames.Soc.Common.Component.PlayerMarkComponent get_markComponent(); // 0x077c6a74
	System.Void CreateCombatMarkersOnInit(); // 0x077c6b40
	System.Void AddCombatMarker(System.Int64 uid, System.Int64 afterSeq); // 0x077c7050
	System.Void AddReviewCombatMarker(UnityEngine.Vector3 pos); // 0x077c7b44
	System.Boolean GetMyGoingToMarkerWorldPosition(UnityEngine.Vector3& worldPosition); // 0x077c7ce8
	System.Void CreateMapGoingToMarker(System.Single worldPosX, System.Single worldPosZ); // 0x077c7f70
	System.Void RemoveMapGoingToMarker(); // 0x077c8558
	System.Void OnCombatMarkerServerInfoChanged(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.Int64 key, WizardGames.Soc.Common.CustomType.MarkerBase oldValue); // 0x077c87ec
	System.Void PlayCombatMarkerVoice(WizardGames.Soc.SocClient.Marker.MarkerCombatData data); // 0x077c769c
	WizardGames.Soc.Common.Data.MarkerType GetMarkerTypeByEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x077c8bc8
	System.Void ReqAddCombatMarker(WizardGames.Soc.Common.Data.MarkerType type, System.Single x, System.Single y, System.Single z, System.Int64 entityId); // 0x077c8f50
	System.Void ReqAddCombatMarkerFollowPosition(WizardGames.Soc.Common.Data.MarkerType type, System.Single x, System.Single y, System.Single z); // 0x077c8034
	System.Void OperateOnMarkerByIMarker(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x077c9274
	WizardGames.Soc.SocClient.Ui.CombatMarkerOperateType GetOperateTypeByIMarker(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x077c95a4
	System.Void CreateCombatMarkerByRaycast(WizardGames.Soc.Common.Data.MarkerType type); // 0x077c96a8
	System.String GetMarkerIcon(WizardGames.Soc.Common.Data.MarkerType type); // 0x077c9964
	System.Void GetIconAndName(WizardGames.Soc.Common.Entity.IEntity entity, System.String& icon, System.String& name); // 0x077c9ae4
	WizardGames.Soc.Common.Data.DataItem.ItemConfig GetItemConfig(WizardGames.Soc.Common.Entity.IEntity entity); // 0x077c9f04
	static SocLogger get_log(); // 0x077ca1cc
	WizardGames.Soc.SocClient.Marker.MarkerBaseData get_curTrackMarkerData(); // 0x077ca254
	System.Void set_curTrackMarkerData(WizardGames.Soc.SocClient.Marker.MarkerBaseData value); // 0x077ca2b8
	System.Int64 get_CurTrackMarkerId(); // 0x077c406c
	System.Boolean get_HideTeamCombatMarker(); // 0x077ca338
	System.Void set_HideTeamCombatMarker(System.Boolean value); // 0x077ca39c
	System.Void Init(); // 0x077ca474
	System.Threading.Tasks.Task OnEnterWorld(); // 0x077ca62c
	System.Threading.Tasks.Task OnExitWorld(); // 0x077cb024
	System.Void InitMarkerDatas(); // 0x077cbd94
	System.Void OnPlayerAwake(); // 0x077cfc84
	System.Void InitObserverModeMarker(); // 0x077cfb38
	System.Void OnChangeLifeCycleFlags(WizardGames.Soc.Common.Entity.PlayerEntity serverEntity, System.Int32 newValue, System.Int32 oldValue); // 0x077cff90
	System.Void RemoveMarkerByType(WizardGames.Soc.Common.Data.MarkerType type); // 0x077c5e28
	System.Boolean IsMarkerDataExist(System.Int64 id); // 0x077c4b1c
	WizardGames.Soc.SocClient.Marker.MarkerBaseData GetMarkerDataById(System.Int64 id); // 0x077c4bb8
	System.Void AddDataToTypeList(WizardGames.Soc.SocClient.Marker.MarkerBaseData data); // 0x077d0568
	System.Void RemoveDataFromTypeList(WizardGames.Soc.SocClient.Marker.MarkerBaseData data); // 0x077d07fc
	System.Void AddMarkerData(WizardGames.Soc.SocClient.Marker.MarkerBaseData data); // 0x077c4c4c
	System.Void RemoveMarkerData(System.Int64 id); // 0x077c5654
	System.Boolean CanTrack(WizardGames.Soc.Common.Data.MarkerType type); // 0x077d1340
	System.Void CreateTrack(System.Int64 id); // 0x077d0b1c
	System.Void CancelTrack(System.Int64 id); // 0x077d0f74
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Marker.MarkerBaseData> GetMarkerDataListByType(WizardGames.Soc.Common.Data.MarkerType type); // 0x077c7584
	WizardGames.Soc.SocClient.Marker.MarkerBaseData GetMarkerOnlyOneByType(WizardGames.Soc.Common.Data.MarkerType type); // 0x077d15dc
	System.Collections.Generic.List<System.Int64> GetMarkerIdListByType(WizardGames.Soc.Common.Data.MarkerType type); // 0x077d0290
	WizardGames.Soc.Common.Data.mapmark.NewMarker GetMarkerConfig(WizardGames.Soc.Common.Data.MarkerType markerType); // 0x077c8974
	System.Void CleanUp(); // 0x077d16ac
	System.Void OnEntityCreate(WizardGames.Soc.Common.Entity.IEntity entity); // 0x077d1714
	System.Void OnEntityRemove(WizardGames.Soc.Common.Entity.IEntity entity); // 0x077d20a4
	System.Void AirdropBoxEntityCreate(WizardGames.Soc.Common.Entity.AirdropEntity entity); // 0x077d1aec
	System.Void CreateAirDropBoxMarkerData(WizardGames.Soc.Common.Entity.AirdropEntity airdropEntity); // 0x077d2320
	System.Void PurchasableVehicleEntityCreate(WizardGames.Soc.Common.Entity.VehicleEntity vehicleEntity, WizardGames.Soc.Common.Data.MarkerType markerType); // 0x077d1c9c
	System.Boolean VehicleEntityNeedMarker(WizardGames.Soc.Common.Entity.VehicleEntity vehicleEntity); // 0x077d1bf8
	System.Void PurchasableHorseEntityCreate(WizardGames.Soc.Common.Entity.HorseEntity horseEntity); // 0x077d254c
	System.Void CreateGlobalEntityMarkerData(WizardGames.Soc.Common.Entity.GlobalMarkerEntity entity); // 0x077d28f8
	System.Void CreateFlyPlayerMarker(System.Int64 entityId, System.UInt64 roleId); // 0x077d2b28
	System.Void RemoveFlyPlayerMarker(System.Int64 entityId); // 0x077d2be0
	System.Void RemoveAllFlyPlayerMarker(); // 0x077d2c5c
	System.Void CreateKatyushaMarker(System.Int64 id); // 0x077d2fec
	System.Void RemoveKatyushaMarker(System.Int64 id); // 0x077d3098
	System.Void RefreshMonumentGuidePoint(); // 0x077ce944
	System.Void GenerateMonumentAndSubWayMarker(); // 0x077cbff8
	static UnityEngine.Vector3 GetSubWayPosition(System.Int32 monumentId, System.Int32 subWayPointId); // 0x077d3114
	System.Void AddIOMarker(System.Int64 entityId, UnityEngine.Vector3 pos, WizardGames.Soc.Common.Data.IOInteractiveEnum.IOType ioType); // 0x077d33a8
	System.Void RemoveIOMarker(System.Int64 entityId); // 0x077d3640
	System.Void UpdateEnteredDeadSheepTerritoryMarkerDatas(); // 0x077cf178
	System.Void CreateGlobalShowDeadSheepTerritoryMarkerOnInit(); // 0x077d388c
	System.Void OnEnteredDeadSheepTerritoryChange(WizardGames.Soc.Share.Framework.ECustomHashSetOpType opType, System.Int64 terrId); // 0x077d3f20
	System.Void UpdateGlobalShowDeadSheepTerritoryInfo(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.Int64 terrId, WizardGames.Soc.Common.CustomType.DeadSheepTerritoryInfo oldInfo); // 0x077d45d8
	static WizardGames.Soc.Common.Data.MarkerType DeadSheepTerritoryLevel2MarkerType(System.Int32 level); // 0x077d36bc
	System.Boolean CheckMonumentHasBox(System.Int32 monumentEntityID, System.Int64 boxEntityId); // 0x077d4b74
	System.Void PatrollerMarkerOnInit(); // 0x077cfce8
	System.Void ObserverGetAllPlayer(); // 0x077d4dd4
	System.Void ObserverGetAllTerritory(); // 0x077d5240
	System.Void ObMarkerOnInit(); // 0x077cfe3c
	System.Void RemoteCallGetAllObsetverInfo(); // 0x077d4d20
	System.Void ObserverObGetAllPlayer(); // 0x077d55fc
	System.Void RemoveInvalidPlayerMarker(); // 0x077d5668
	System.Void RefreshValidPlayerMarker(); // 0x077d5864
	System.Void ObserverObGetAllTerritory(); // 0x077d5c28
	System.Void RemoveInvalidPartBaseMarker(); // 0x077d5c94
	System.Void RefreshValidPartBaseMarker(); // 0x077d5e90
	System.Void InitMyPlayerMarker(); // 0x077cc5e4
	System.Void PlayerEntityCreate(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x077d61b8
	System.Void OnTeamMemberDictChange(WizardGames.Soc.Share.Framework.ECustomDictOpType changeType, System.UInt64 roleId, WizardGames.Soc.Common.CustomType.TeamMemberInfo oldMember); // 0x077d6538
	System.Void RefreshTeammate(); // 0x077cc6c4
	System.Void CreateReportBanMarkerOnInit(); // 0x077d65cc
	System.Void UpdateBannedPlayerTerritoryInfo(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.Int64 territoryId, WizardGames.Soc.Common.CustomType.BannedPlayerTerritoryInfo oldInfo); // 0x077d6b70
	System.Void SaveAwakeTime(); // 0x077d00fc
	System.Void UpdateDeathPointCfgSelfDestoryTime(); // 0x077cdaa0
	System.Void CreateDeathPointMarker(System.Int64 ignoreId); // 0x077cd108
	System.Void OnDeathPointInfoChanged(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.Int64 id); // 0x077d739c
	System.Void RefreshPartBed(); // 0x077cdea4
	System.Void CreateOutpostMarker(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RespawnRebornPoint> datas); // 0x077d7430
	System.Void DoSomethingWhenPlayerEntityCreate(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x077d76e4
	System.Void CreateSDJTeamMarkerOnInit(); // 0x077d7834
	System.Void RefreshSDJTeamInfo(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.Int64 teamId, WizardGames.Soc.Common.CustomType.SouDaJianTeamInfo oldInfo); // 0x077d8540
	System.Void CreateGlodAirDropMarkerOnInit(); // 0x077d7d4c
	System.Void RefreshGlodAirDropInfo(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.Int64 id, WizardGames.Soc.Common.CustomType.GoldCoinAirdropData oldInfo); // 0x077d89bc
	System.Void SDJStageChange(); // 0x077d8df8
	System.Void CheckSDJTeamMarkerTrackTimer(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x05523a54
	System.Void CheckIsReachTargetTerritory(System.Int64 timerId, System.Object obj, System.Boolean _); // 0x077d8eec
	System.Void RemoveSDJTeamMarkerTrackTimer(); // 0x077cbc88
	System.Boolean NeedShowSDJMarker(System.Boolean& isBecauseEliminated); // 0x077d837c
	System.Void OnMarkerGetOrUpdateSearchResult(WizardGames.Soc.SocClient.Search.SearchResult searchResult, WizardGames.Soc.Common.Data.MarkerType markerType); // 0x077d920c
	System.Void OnSearchMarkerRemove(System.Int64 taskId, System.Int64 searchId); // 0x077d93c8
	System.Void AddMissionIdNeedPlayFlyAnimation(System.Int64 taskId); // 0x077d946c
	System.Void RemoveMissionIdNeedPlayFlyAnimation(System.Int64 taskId); // 0x077d955c
	System.Boolean IsMissionIdNeedPlayFlyAnimation(System.Int64 taskId); // 0x077d9634
	System.Void CreateShopOnInit(); // 0x077d96d0
	System.Void RefreshShopInfo(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.Int64 id, WizardGames.Soc.Common.CustomType.ShopInfo oldInfo); // 0x077d9bb8
	System.Void UpdateShopInfo(System.Int64 id, WizardGames.Soc.Common.CustomType.ShopInfo shopInfo); // 0x077d9e68
	System.Void UpdateShopPos(System.Int64 id, WizardGames.Soc.Common.CustomType.ShopInfo shopInfo); // 0x077da114
	System.Void CreateSlicePlayPositionMarker(System.Int64 uniqueId, UnityEngine.Vector3 pos, System.String nameStr); // 0x077da364
	System.Int64 CreateTeachingNpcHeadMarker(UnityEngine.GameObject gameObject, System.String desc); // 0x077da590
	System.Void RemoveTeachingNpcHeadMarker(System.Int64 id); // 0x077da664
	System.Void CreateTerritoryCenterMarkerOnInit(); // 0x077cec88
	System.Void OnTerritoryCenterAdd(System.Int64 centerId); // 0x077d71b0
	System.Void UpdateTerritoryCenterInfo(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.Int64 centerId, WizardGames.Soc.Common.CustomType.BriefPrivilegeInfo oldInfo); // 0x077da6e0
	System.Void OnTerritoryCenterRemove(System.Int64 centerId); // 0x077da958
	System.Void OnShowTerrGuild(WizardGames.Soc.Common.Entity.TerritoryEntity terrEnt); // 0x077da9d4
	System.Void OnSkinGoLoaded(System.Int64 entity); // 0x077daf80
	System.Void EnableOutline(); // 0x077dab48
	System.Void OnHideTerrGuild(WizardGames.Soc.Common.Entity.TerritoryEntity terrEnt); // 0x077db00c
	System.Void CreateBpHouseCabinetMarker(System.Int64 territoryId, UnityEngine.Vector3 pos); // 0x077dad70
	System.Void RemoveBpHouseCabinetMarker(System.Int64 territoryId); // 0x077db1a8
	System.Void .ctor(); // 0x077db2d4
	static System.Void .cctor(); // 0x077db73c
	System.Void <AirdropBoxEntityCreate>b__89_0(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x077db844
	System.Void <PurchasableHorseEntityCreate>b__93_1(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x077db93c
	System.Void <PurchasableHorseEntityCreate>b__93_0(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x077dbbf4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MgrMarker.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Marker.MgrMarker.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.CustomType.PlayerDeathPoint> <>9__139_0; // 0x8
	static System.Void .cctor(); // 0x077dbe74
	System.Void .ctor(); // 0x077dbed8
	System.Int32 <CreateDeathPointMarker>b__139_0(WizardGames.Soc.Common.CustomType.PlayerDeathPoint a, WizardGames.Soc.Common.CustomType.PlayerDeathPoint b); // 0x077dbf40
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MgrMarker.<>c__DisplayClass179_0 : System.Object
{
	WizardGames.Soc.SocClient.Marker.MgrMarker <>4__this; // 0x10
	System.Int64 id; // 0x18
	UnityEngine.Vector3 pos; // 0x20
	System.Void .ctor(); // 0x077db26c
	System.Void <CreateBpHouseCabinetMarker>b__0(UnityEngine.Vector2 flyBeginPos); // 0x077dc000
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MgrMarker.<>c__DisplayClass34_0 : System.Object
{
	System.Single x; // 0x10
	System.Single z; // 0x14
	System.Void .ctor(); // 0x077c920c
	System.Void <ReqAddCombatMarkerFollowPosition>b__0(System.Single terrainHeight); // 0x077dc2a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MgrMarker.<>c__DisplayClass91_0 : System.Object
{
	WizardGames.Soc.SocClient.Marker.MgrMarker <>4__this; // 0x10
	WizardGames.Soc.Common.Data.MarkerType markerType; // 0x18
	System.Void .ctor(); // 0x077d24e4
	System.Void <PurchasableVehicleEntityCreate>b__1(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Boolean oldValue, System.Boolean newValue); // 0x077dc374
	System.Void <PurchasableVehicleEntityCreate>b__0(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x077dc4c4
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Marker.IClusterMarkerStage : , WizardGames.Soc.SocClient.Marker.IMarkerStage
{
	
	WizardGames.Soc.SocClient.Marker.MarkerCluster GetMarkerCluster(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x054f9d14
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Marker.IFilterMarkerStage : , WizardGames.Soc.SocClient.Marker.IMarkerStage
{
	
	System.Boolean get_IsMarkerFiltering(); // 0x054c4760
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Marker.IMapLevelDependentMarkerStage : , WizardGames.Soc.SocClient.Marker.IMarkerStage
{
	
	System.Void ChangeMarkerMapLevelStatus(WizardGames.Soc.SocClient.Marker.IMapLevelDependentMarker marker); // 0x05523a54
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Marker.IMarkerStage : 
{
	
	WizardGames.Soc.Common.Data.MarkerDecoratorType get_StageType(); // 0x0548ba98
	WizardGames.Soc.SocClient.Marker.GMarkerBase GetMarker(System.Int64 id); // 0x054e931c
	FairyGUI.GComponent get_MarkerContainer(); // 0x054e7844
	System.Void ChangeMarkerPosition(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x05523a54
	System.Single get_StageScale(); // 0x054a5abc
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Marker.ISelectMarkerStage : , WizardGames.Soc.SocClient.Marker.IMarkerStage
{
	
	WizardGames.Soc.SocClient.Ui.Map.SelectedMarkerInfo get_CurSelectedMarkerInfo(); // 0x054e7844
	System.Void SelectMarker(System.Int64 markerId, System.Boolean isFromSidePanel); // 0x055128d8
	System.Void DeSelectMarker(WizardGames.Soc.SocClient.Ui.Map.UpdateReason reason); // 0x055056e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MarkerStage : System.Object, WizardGames.Soc.SocClient.Marker.IMarkerStage
{
	SocLogger log; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Marker.GMarkerBase> markers; // 0x18
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.MarkerType,System.Collections.Generic.List<WizardGames.Soc.SocClient.Marker.GMarkerBase>> markerGroups; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Marker.I1TickMarker> tick1Markers; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Marker.I30TickMarker> tick30Markers; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Marker.IUnlimitedTickMarker> tickUnlimitedMarkers; // 0x38
	WizardGames.Soc.Common.Data.MarkerDecoratorType <StageType>k__BackingField; // 0x40
	System.Boolean IsInited; // 0x44
	WizardGames.Soc.Common.Entity.PlayerEntity myplayer; // 0x48
	System.Collections.Generic.HashSet<System.UInt64> flyPlayerRoleIds; // 0x50
	System.Collections.Generic.Dictionary<System.Int64,System.UInt64> EntityId2RoleId; // 0x58
	System.UInt64 myRoleId; // 0x60
	System.Int32 distance; // 0x68
	System.Collections.Generic.HashSet<System.Int64> tempIds; // 0x70
	System.Int64 holdingConstructionId; // 0x78
	System.Void CreateAirdropMarkerOnStageInit(); // 0x077dc758
	System.Void CreateAirDropMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077dc8f4
	System.Void CreateBedMarkerOnStageInit(); // 0x077dca4c
	System.Void CreateOutpostRebornMarkerOnStageInit(); // 0x077dcd70
	System.Void CreateBedMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077dccdc
	System.Void CreateOutpostRebornMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077dcf0c
	System.Void CreateBuildCollapseMarkerOnInit(); // 0x077dcfa0
	System.Void CreateBuildCollapseMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077dd058
	System.Void CreatePatrolCarMarkerOnStageInit(); // 0x077dd0ec
	System.Void CreateMoveCarMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077dd454
	System.Void CreateRoadBeginPointMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077dd4e8
	System.Void CreateCombatMarkersOnStageInit(); // 0x077dd664
	System.Void CreateCombatMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077dddec
	FairyGUI.GComponent get_MarkerContainer(); // 0x054e7844
	WizardGames.Soc.Common.Data.MarkerDecoratorType get_StageType(); // 0x077ddfe0
	System.Void set_StageType(WizardGames.Soc.Common.Data.MarkerDecoratorType value); // 0x077de044
	System.Single get_StageScale(); // 0x077de0bc
	System.Void Init(); // 0x077de120
	System.Void OnEnable(); // 0x077de310
	System.Void OnDisable(); // 0x077de378
	System.Void OnDestroy(); // 0x077de3d8
	System.Void OnMarkerCreate(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x077de9e4
	System.Void OnMarkerRemove(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x077dea58
	System.Void OnMarkerDataCreate(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077deacc
	System.Void OnMarkerDataRemove(System.Int64 id); // 0x077e1294
	System.Void OnFpsUnlimitedUpdate(); // 0x077e1570
	System.Void OnFps30Update(); // 0x077e1744
	System.Void OnFps1Update(); // 0x077e1918
	System.Void ChangeMarkerPosition(WizardGames.Soc.SocClient.Marker.IMarker marker); // 0x077e1aec
	System.Void RemoveMarker(System.Int64 id); // 0x077e1310
	System.Void CreateMarker<T>(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x052af1f0
	System.Boolean CanCreateMarkerToStageByType(WizardGames.Soc.Common.Data.MarkerType type); // 0x077e1b60
	System.Boolean NeedOutOfFrameHover(WizardGames.Soc.Common.Data.MarkerDecoratorType ranges); // 0x077e1d00
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Marker.GMarkerBase> GetMarkerGroup(WizardGames.Soc.Common.Data.MarkerType type); // 0x077e1e08
	WizardGames.Soc.SocClient.Marker.GMarkerBase GetMarker(System.Int64 id); // 0x077e1eb4
	System.Boolean IsMarkerExist(System.Int64 id); // 0x077e1f60
	System.Void CreateDeathPointMarkersOnStageInit(); // 0x077e200c
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Marker.MarkerBaseData> FindLatestDeathPoint(System.Int32 num); // 0x077e2360
	System.Void CreateDeathPointMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077e05c4
	System.Void RemoveEarliestDeathPointMarker(); // 0x077e2608
	System.Void RefreshDebugFlyModePLayer(); // 0x077e2924
	System.Void CreateFlyPlayerMarkersOnInit(); // 0x077e36d8
	System.Void CreateFlyPlayerMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077e07c4
	System.Void CreateGlobalMarkerOnStageInit(); // 0x077e3874
	System.Void CreateGlobalMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077e00c0
	System.Void CreateMoveGlobalMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077e0218
	System.Void CreateIOMarkerOnStageInit(); // 0x077e3cac
	System.Void AddIOMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077e0370
	System.Void CreateKatyushaMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077e41b8
	System.Void CreateMonumentMarkerOnInit(); // 0x077e424c
	System.Void CreateMonumentMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077df504
	System.Void CreateMiniMapMonumentMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077e45b0
	System.Void CreateDirectionMonumentMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077e46a4
	System.Void CreateHudMonumentMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077e4798
	System.Void CreateSubWayMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077dfd54
	System.Void CreateMiniMapSubWayMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077e488c
	System.Void CreateTrainStopMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077dff44
	System.Void CreateMiniMapTrainStopMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077e4980
	System.Void CreateDirectionTrainStopMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077e4a74
	System.Void CreateHudTrainStopMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077e4b68
	System.Void CreateDeadSheepMarkerOnInit(); // 0x077e4c5c
	System.Void CreateDeadSheepMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077e0858
	System.Void CreateMonumentGuidePointMarkerOnStageInit(); // 0x077e5094
	System.Void CreateMonumentGuidePointMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077e04c8
	System.Void CreateMyPlayerOnStageInit(); // 0x077e5230
	System.Void CreateMyPlayer(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077def64
	System.Void CreateObserverObMarkerOnStageInit(); // 0x077e5318
	System.Void CreateObserverObPlayerMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData data); // 0x077e0cd4
	System.Void CreateObserverObTerritoryCenterMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData data); // 0x077e0dc4
	System.Void CreateObserverPatrolMarkerOnStageInit(); // 0x077e55a8
	System.Void CreateObserverPatrolPlayerMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData data); // 0x077e0bac
	System.Void CreateObserverPatrolTerritoryCenterMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData data); // 0x077e0c40
	System.Void CreatePurchasableVehicleMarkerOnStageInit(); // 0x077e5838
	System.Void CreatePurchasableVehicleMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077df680
	System.Void CreateReportBanMarkerOnStageInit(); // 0x077e5b9c
	System.Void CreateReportBanMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077df244
	System.Void CreateSDJTeamMarkerOnStageInit(); // 0x077e5d38
	System.Void CreateSDJTeamMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077e0eb4
	System.Void CreateGlodAirDropMarkerOnStageInit(); // 0x077e5ed4
	System.Void CreateGlodAirDropMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077e10a4
	System.Void CreateSearchOnStageInit(); // 0x077e6070
	System.Void CreateSearchMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077df7d8
	System.Void CreateMissionMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077df930
	System.Void CreateNpcHeadMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077dfa88
	System.Void CreateShopOnStageInit(); // 0x077e64a8
	System.Void CreateShopMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077df3cc
	System.Void CreateMiniMapShopMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077e6644
	System.Void CreateHudShopMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077e6738
	System.Void CreateSlicePlayPositionMarkerOnStageInit(); // 0x077e682c
	System.Void CreateSlicePlayPositionMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077e09d4
	System.Void CreateTeachingNpcMarkerOnStageInit(); // 0x077e69c8
	System.Void CreateTeachingNpcHeadMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077dfc60
	System.Void CreateTeammateMarkerOnInit(); // 0x077e6b64
	System.Void CreateTeammateMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077deff8
	System.Void CreateTerritoryCenterMarkerOnStageInit(); // 0x077e6d00
	System.Void CreateTerritoryCenterMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077df148
	System.Void CreateBpHouseCabinetMarkerOnStageInit(); // 0x077e6e9c
	System.Void CreateBpHouseCabinetMarker(WizardGames.Soc.SocClient.Marker.MarkerBaseData markerData); // 0x077df2d8
	System.Void .ctor(); // 0x077e7038
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MarkerStage.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Marker.MarkerStage.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Marker.MarkerBaseData> <>9__50_0; // 0x8
	static System.Void .cctor(); // 0x077e7580
	System.Void .ctor(); // 0x077e75e4
	System.Int32 <FindLatestDeathPoint>b__50_0(WizardGames.Soc.SocClient.Marker.MarkerBaseData a, WizardGames.Soc.SocClient.Marker.MarkerBaseData b); // 0x077e764c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.MarkerStage.<>c__DisplayClass59_0 : System.Object
{
	System.UInt64 roleId; // 0x10
	WizardGames.Soc.SocClient.Marker.MarkerStage <>4__this; // 0x18
	System.Void .ctor(); // 0x077e7744
	System.Boolean <RefreshDebugFlyModePLayer>b__0(System.Int64 index); // 0x077e77ac
	System.Boolean <RefreshDebugFlyModePLayer>b__1(System.Int64 index); // 0x077e7860
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.Ui.GMarkerComponentBaseBinder : System.Object
{
	FairyGUI.GComponent <UiNode>k__BackingField; // 0x10
	System.String get_ResUrl(); // 0x054e7844
	FairyGUI.GComponent get_UiNode(); // 0x077e7914
	System.Void set_UiNode(FairyGUI.GComponent value); // 0x077e7978
	System.Void Bind(); // 0x077e79f8
	System.Void OnRemove(); // 0x077e7b44
	System.Void .ctor(); // 0x077e7c5c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.Ui.HudDirectionMarker_Binder : WizardGames.Soc.SocClient.Marker.Ui.GMarkerComponentBaseBinder
{
	FairyGUI.GLoader loaderIcon; // 0x18
	System.String get_ResUrl(); // 0x077e7cc4
	System.Void Bind(); // 0x077e7d3c
	System.Void OnRemove(); // 0x077e7e2c
	System.Void .ctor(); // 0x077e7ea0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.Ui.HudMarkerPlayerDebug_Binder : WizardGames.Soc.SocClient.Marker.Ui.GMarkerComponentBaseBinder
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonGame.HudMarkerPlayerDebugBinder <MarkerBinder>k__BackingField; // 0x18
	System.String get_ResUrl(); // 0x077e7f04
	WizardGames.Soc.SocClient.Ui.Binder.CommonGame.HudMarkerPlayerDebugBinder get_MarkerBinder(); // 0x077e7f7c
	System.Void set_MarkerBinder(WizardGames.Soc.SocClient.Ui.Binder.CommonGame.HudMarkerPlayerDebugBinder value); // 0x077e7fe0
	System.Void Bind(); // 0x077e8060
	System.Void .ctor(); // 0x077e8198
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.Ui.HudMarkerPlayer_Binder : WizardGames.Soc.SocClient.Marker.Ui.GMarkerComponentBaseBinder
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonGame.HudMarkerPlayerBinder <MarkerBinder>k__BackingField; // 0x18
	System.String get_ResUrl(); // 0x077e81fc
	WizardGames.Soc.SocClient.Ui.Binder.CommonGame.HudMarkerPlayerBinder get_MarkerBinder(); // 0x077e8274
	System.Void set_MarkerBinder(WizardGames.Soc.SocClient.Ui.Binder.CommonGame.HudMarkerPlayerBinder value); // 0x077e82d8
	System.Void Bind(); // 0x077e8358
	System.Void .ctor(); // 0x077e8490
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.Ui.HudMarkerSimple_Binder : WizardGames.Soc.SocClient.Marker.Ui.GMarkerComponentBaseBinder
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonGame.HudMarkerSimpleBinder <MarkerBinder>k__BackingField; // 0x18
	System.String get_ResUrl(); // 0x077e84f4
	WizardGames.Soc.SocClient.Ui.Binder.CommonGame.HudMarkerSimpleBinder get_MarkerBinder(); // 0x077e856c
	System.Void set_MarkerBinder(WizardGames.Soc.SocClient.Ui.Binder.CommonGame.HudMarkerSimpleBinder value); // 0x077e85d0
	System.Void Bind(); // 0x077e8650
	System.Void .ctor(); // 0x077e8788
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.Ui.MapMarkerKatyusha_Binder : WizardGames.Soc.SocClient.Marker.Ui.GMarkerComponentBaseBinder
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonGame.MapMarkerKatyushaBinder <MarkerBinder>k__BackingField; // 0x18
	System.String get_ResUrl(); // 0x077e87ec
	WizardGames.Soc.SocClient.Ui.Binder.CommonGame.MapMarkerKatyushaBinder get_MarkerBinder(); // 0x077e8864
	System.Void set_MarkerBinder(WizardGames.Soc.SocClient.Ui.Binder.CommonGame.MapMarkerKatyushaBinder value); // 0x077e88c8
	System.Void Bind(); // 0x077e8948
	System.Void .ctor(); // 0x077e8a80
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.Ui.MapMarkerPlayer_Binder : WizardGames.Soc.SocClient.Marker.Ui.GMarkerComponentBaseBinder
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonGame.MapMarkerPlayerBinder <MarkerBinder>k__BackingField; // 0x18
	System.String get_ResUrl(); // 0x077e8ae4
	WizardGames.Soc.SocClient.Ui.Binder.CommonGame.MapMarkerPlayerBinder get_MarkerBinder(); // 0x077e8b5c
	System.Void set_MarkerBinder(WizardGames.Soc.SocClient.Ui.Binder.CommonGame.MapMarkerPlayerBinder value); // 0x077e8bc0
	System.Void Bind(); // 0x077e8c40
	System.Void .ctor(); // 0x077e8d78
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.Ui.MapMarkerSimple_Binder : WizardGames.Soc.SocClient.Marker.Ui.GMarkerComponentBaseBinder
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonGame.MapMarkerSimpleBinder <MarkerBinder>k__BackingField; // 0x18
	System.String get_ResUrl(); // 0x077e8ddc
	WizardGames.Soc.SocClient.Ui.Binder.CommonGame.MapMarkerSimpleBinder get_MarkerBinder(); // 0x077e8e54
	System.Void set_MarkerBinder(WizardGames.Soc.SocClient.Ui.Binder.CommonGame.MapMarkerSimpleBinder value); // 0x077e8eb8
	System.Void Bind(); // 0x077e8f38
	System.Void .ctor(); // 0x077e9070
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.Ui.ObMapMarkerPlayer_Binder : WizardGames.Soc.SocClient.Marker.Ui.GMarkerComponentBaseBinder
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonGame.ComMarkerPlayerBinder <MarkerBinder>k__BackingField; // 0x18
	System.String get_ResUrl(); // 0x077e90d4
	WizardGames.Soc.SocClient.Ui.Binder.CommonGame.ComMarkerPlayerBinder get_MarkerBinder(); // 0x077e914c
	System.Void set_MarkerBinder(WizardGames.Soc.SocClient.Ui.Binder.CommonGame.ComMarkerPlayerBinder value); // 0x077e91b0
	System.Void Bind(); // 0x077e9230
	System.Void .ctor(); // 0x077e9368
}

// Client.Runtime
class WizardGames.Soc.SocClient.Marker.Ui.ObMapMarkerTerritoryCabinet_Binder : WizardGames.Soc.SocClient.Marker.Ui.GMarkerComponentBaseBinder
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonGame.ComMarkerTerritoryCabinetBinder <MarkerBinder>k__BackingField; // 0x18
	System.String get_ResUrl(); // 0x077e93cc
	WizardGames.Soc.SocClient.Ui.Binder.CommonGame.ComMarkerTerritoryCabinetBinder get_MarkerBinder(); // 0x077e9444
	System.Void set_MarkerBinder(WizardGames.Soc.SocClient.Ui.Binder.CommonGame.ComMarkerTerritoryCabinetBinder value); // 0x077e94a8
	System.Void Bind(); // 0x077e9528
	System.Void .ctor(); // 0x077e9660
}

// Client.Runtime
class WizardGames.Soc.SocClient.Team.MgrGameTeam : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.UInt64,System.String> teamMemberNameDic; // 0x18
	System.Collections.Generic.HashSet<System.UInt64> unReadInviteInfoIds; // 0x20
	System.Collections.Generic.Dictionary<System.UInt64,WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.EquipmentDisplayData>> equipmentDisplayDataDic; // 0x28
	System.Collections.Generic.Dictionary<System.UInt64,WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.WeaponDisplayData>> weaponDisplayDataDic; // 0x30
	System.Collections.Generic.Dictionary<System.UInt64,System.Boolean> isNeedRefreshModelDic; // 0x38
	System.Boolean get_HasTeam(); // 0x077e96c4
	WizardGames.Soc.Common.Component.TeamComponent get_MyTeamComponent(); // 0x077e97a4
	System.Boolean get_IsCaptain(); // 0x077e984c
	System.Int32 get_MyDuty(); // 0x077e9960
	System.Void CleanUp(); // 0x077e9abc
	System.Boolean EqualTwoData(System.Int64 oldTableId, System.Int64 newTableId, System.Int64 oldSkinId, System.Int64 newSkinId); // 0x077e9b70
	System.Boolean EqualTwoEquipmentDisplayDatas(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.EquipmentDisplayData> oldDatas, WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.EquipmentDisplayData> newDatas); // 0x077e9c14
	System.Boolean EqualTwoWeaponDisplayDatas(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.WeaponDisplayData> oldDatas, WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.WeaponDisplayData> newDatas); // 0x077e9de4
	System.Void InitDisplayData(); // 0x077e9fb4
	System.Void UpdateDisplayData(); // 0x077ea5f0
	System.Void SendInvite(System.UInt64 roleId, System.Int32 type, WizardGames.Soc.SocClient.Ui.ETeamSource teamSource, System.String teamChangeEntrance); // 0x077eb050
	System.Void SendKickOut(System.UInt64 roleId); // 0x077eb31c
	System.Void SendLeaveTeam(); // 0x077eb414
	System.Void HandoverTeam(System.UInt64 roleId); // 0x077eb4f0
	System.Void ChangeDuty(System.UInt64 roleId, System.Boolean grant); // 0x077eb5d0
	System.Void SendAcceptInvite(System.UInt64 roleId, System.String teamChangeEntrance); // 0x077eb6bc
	System.Void SendRefuseInvite(System.UInt64 roleId); // 0x077eb9a4
	System.Void SendRefuseInviteAll(); // 0x077ebbc4
	System.Boolean HasOtherPlayerInTeam(); // 0x077ebf54
	System.Int32 GetTeamMemberCount(); // 0x077ec044
	System.Boolean IsIDExistinTeam(System.UInt64 roleId); // 0x077ec130
	System.Boolean IsTeamMateViaEntityId(System.Int64 entityid); // 0x077ec238
	System.Void KickoutTeam(System.UInt64 roleId, System.String name); // 0x077ec39c
	System.Void KickoutTeam(System.UInt64 roleId); // 0x077ec83c
	System.Void Handover(WizardGames.Soc.Common.CustomType.TeamMemberInfo member); // 0x077ecbe8
	System.Void GiveDuty(WizardGames.Soc.Common.CustomType.TeamMemberInfo member); // 0x077ed0a4
	System.Void TakeBackDuty(WizardGames.Soc.Common.CustomType.TeamMemberInfo member); // 0x077ed560
	System.Int32 GetStateByRoleId(System.UInt64 roleId); // 0x077eda1c
	WizardGames.Soc.Common.Entity.PlayerEntity GetPlayerEntity(System.UInt64 roleId); // 0x077edbd8
	System.Boolean IsOfflineInBattle(System.UInt64 roleId); // 0x077edc8c
	System.Boolean IsOtherAiding(System.UInt64 roleId); // 0x077edd28
	WizardGames.Soc.Common.CustomType.TeamMemberInfo GetMemberByRoleId(System.UInt64 roleId); // 0x077ede5c
	System.Void GetMemberName(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.UInt64 roleId, System.Action<System.String> callback); // 0x077ec99c
	System.Void GetMemberListName(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Collections.Generic.HashSet<System.String> roleIds, System.Action<System.Collections.Generic.List<System.String>> callback); // 0x077ee004
	System.Boolean IsForbidTeamEntry(); // 0x077ee6b4
	System.Boolean IsForbidTeamRecruit(); // 0x077ee790
	System.Boolean IsSinglePlayerMode(); // 0x077ee86c
	System.Void AddNewUnReadId(System.UInt64 roleId); // 0x077ee9a4
	System.Void RemoveUnReadId(System.UInt64 roleId); // 0x077eea80
	System.Void ClearUnReadIds(); // 0x077eeb5c
	System.Boolean IsInviteRedDot(); // 0x077eec20
	System.Boolean HasNewInGameImpeachInfo(); // 0x077eed2c
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo> GetUnReadInviteInfos(); // 0x077eef34
	System.Int32 CurTeamMaxMemberCount(); // 0x077ef4d4
	System.Int32 GetCurGamePlatform(); // 0x077ef5a0
	System.Void OpenImpeachPop(); // 0x077ef6f8
	System.Void OpenVotePop(); // 0x077efb14
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.VoteStatus> GetVoteDataList(); // 0x077efcc8
	System.Void CheckTeamImpeachState(); // 0x077f026c
	System.Boolean IsCaptainByRoleID(System.UInt64 roleId); // 0x077f03b0
	System.Boolean ApplicationPlayerIsSelf(); // 0x077f0494
	System.Void ResetImpeachPrefs(); // 0x077f05b0
	System.Void ResetVotePrefs(); // 0x077f0800
	System.Boolean IsAlreadyVote(); // 0x077f0a50
	System.Boolean IsValidInviteInfo(System.UInt64 roleId); // 0x077ef3b4
	System.Void .ctor(); // 0x077f0ba4
	static System.Void .cctor(); // 0x077f0db8
	System.Void <OpenVotePop>b__56_0(System.String captainName); // 0x077f0e8c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Team.MgrGameTeam.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Team.MgrGameTeam.<>c <>9; // 0x0
	static System.Action <>9__55_0; // 0x8
	static System.Action <>9__56_1; // 0x10
	static System.Action <>9__56_2; // 0x18
	static System.Void .cctor(); // 0x077f1298
	System.Void .ctor(); // 0x077f12fc
	System.Void <OpenImpeachPop>b__55_0(); // 0x077f1364
	System.Void <OpenVotePop>b__56_1(); // 0x077f141c
	System.Void <OpenVotePop>b__56_2(); // 0x077f14d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Team.MgrGameTeam.<>c__DisplayClass20_0 : System.Object
{
	System.UInt64 roleId; // 0x10
	WizardGames.Soc.SocClient.Team.MgrGameTeam <>4__this; // 0x18
	WizardGames.Soc.SocClient.Ui.ETeamSource teamSource; // 0x20
	System.Int32 type; // 0x24
	System.String teamChangeEntrance; // 0x28
	System.Void .ctor(); // 0x077eb2b4
	System.Void <SendInvite>b__0(SimpleJSON.JSONNode node); // 0x077f1594
}

// Client.Runtime
class WizardGames.Soc.SocClient.Team.MgrGameTeam.<>c__DisplayClass20_1 : System.Object
{
	System.String teamSourceStr; // 0x10
	WizardGames.Soc.SocClient.Team.MgrGameTeam.<>c__DisplayClass20_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x077f1d68
	System.Void <SendInvite>b__1(); // 0x077f1dd0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Team.MgrGameTeam.<>c__DisplayClass32_0 : System.Object
{
	System.UInt64 roleId; // 0x10
	System.Void .ctor(); // 0x077ec7d4
	System.Void <KickoutTeam>b__0(); // 0x077f1f78
}

// Client.Runtime
class WizardGames.Soc.SocClient.Team.MgrGameTeam.<>c__DisplayClass33_0 : System.Object
{
	System.UInt64 roleId; // 0x10
	System.Action <>9__1; // 0x18
	System.Void .ctor(); // 0x077ec934
	System.Void <KickoutTeam>b__0(System.String name); // 0x077f2014
	System.Void <KickoutTeam>b__1(); // 0x077f2430
}

// Client.Runtime
class WizardGames.Soc.SocClient.Team.MgrGameTeam.<>c__DisplayClass34_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.TeamMemberInfo member; // 0x10
	System.Void .ctor(); // 0x077ed03c
	System.Void <Handover>b__0(); // 0x077f24cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Team.MgrGameTeam.<>c__DisplayClass35_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.TeamMemberInfo member; // 0x10
	System.Void .ctor(); // 0x077ed4f8
	System.Void <GiveDuty>b__0(); // 0x077f2580
}

// Client.Runtime
class WizardGames.Soc.SocClient.Team.MgrGameTeam.<>c__DisplayClass36_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.TeamMemberInfo member; // 0x10
	System.Void .ctor(); // 0x077ed9b4
	System.Void <TakeBackDuty>b__0(); // 0x077f2638
}

// Client.Runtime
class WizardGames.Soc.SocClient.Team.MgrGameTeam.<>c__DisplayClass42_0 : System.Object
{
	WizardGames.Soc.SocClient.Team.MgrGameTeam <>4__this; // 0x10
	System.UInt64 roleId; // 0x18
	System.Action<System.String> callback; // 0x20
	System.Void .ctor(); // 0x077edf9c
	System.Void <GetMemberName>b__0(Config.LobbyRoleInfo userInfo); // 0x077f26f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Team.MgrGameTeam.<>c__DisplayClass43_0 : System.Object
{
	WizardGames.Soc.SocClient.Team.MgrGameTeam <>4__this; // 0x10
	System.Collections.Generic.List<System.String> nameList; // 0x18
	System.Action<System.Collections.Generic.List<System.String>> callback; // 0x20
	System.Void .ctor(); // 0x077ee64c
	System.Void <GetMemberListName>b__0(SimpleJSON.JSONArray jsonArray); // 0x077f28b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Map.MgrBattleReport : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger <Log>k__BackingField; // 0x0
	System.Int64 showEntityId; // 0x18
	System.Boolean finshWeekCheck; // 0x20
	System.Boolean sleepEnd; // 0x21
	System.Collections.Generic.Dictionary<System.UInt64,WizardGames.Soc.SocClient.RoleInfo> teamMemberDic; // 0x28
	System.Boolean newReport; // 0x30
	static SocLogger get_Log(); // 0x077f2b78
	System.Void GetMemberInfo(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.UInt64 roleId, System.Action<WizardGames.Soc.SocClient.RoleInfo> callback); // 0x077f2c00
	System.Void OnFps1Update(); // 0x077f2e34
	System.Void ShowBattleReportTip(); // 0x077f367c
	System.Void CheckBattleReport(); // 0x077f3d94
	System.Threading.Tasks.Task OnExitWorld(); // 0x077f4018
	System.String FormatDateTime(System.DateTime dateTime, System.String str); // 0x077f4088
	System.Void .ctor(); // 0x077f4148
	static System.Void .cctor(); // 0x077f41fc
	System.Boolean <OnFps1Update>b__9_0(); // 0x077f42d0
	System.Void <CheckBattleReport>b__11_0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x077f4338
}

// Client.Runtime
class WizardGames.Soc.SocClient.Map.MgrBattleReport.<>c__DisplayClass10_0 : System.Object
{
	System.Int64 defendReportId; // 0x10
	System.Int64 attackReportId; // 0x18
	System.Void .ctor(); // 0x077f3d2c
	System.Void <ShowBattleReportTip>b__0(); // 0x077f43d8
	System.Void <ShowBattleReportTip>b__1(); // 0x077f4468
}

// Client.Runtime
class WizardGames.Soc.SocClient.Map.MgrBattleReport.<>c__DisplayClass8_0 : System.Object
{
	System.UInt64 roleId; // 0x10
	WizardGames.Soc.SocClient.Map.MgrBattleReport <>4__this; // 0x18
	System.Action<WizardGames.Soc.SocClient.RoleInfo> callback; // 0x20
	System.Void .ctor(); // 0x077f2dcc
	System.Void <GetMemberInfo>b__0(Config.LobbyRoleInfo userInfo); // 0x077f44f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Map.InvitecodeInfo : System.Object
{
	System.String code; // 0x10
	System.UInt64 createTime; // 0x18
	System.Boolean isUsed; // 0x20
	System.UInt64 usedByRoleID; // 0x28
	System.UInt64 usedTime; // 0x30
	System.String nickName; // 0x38
	System.Void .ctor(SimpleJSON.JSONNode json); // 0x077f46e8
	System.Void .ctor(System.String code); // 0x077f48e4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Map.MgrKOL : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger <Log>k__BackingField; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Map.InvitecodeInfo> invitecodeInfos; // 0x18
	System.Byte selfPlayerState; // 0x20
	System.Single cachedTime; // 0x24
	static SocLogger get_Log(); // 0x077f4980
	System.Void GetInviteCodes(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action<System.Collections.Generic.List<WizardGames.Soc.SocClient.Map.InvitecodeInfo>> callback, System.Boolean immediateRequest, System.Action<SimpleJSON.JSONNode> errorCallBack); // 0x077f4a08
	System.Void ResetNusedInviteCodes(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action<System.Collections.Generic.List<WizardGames.Soc.SocClient.Map.InvitecodeInfo>> callback, System.Boolean immediateRequest, System.Action<SimpleJSON.JSONNode> errorCallBack); // 0x077f4e18
	System.Void GenerateInviteCodes(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Int32 count, System.Action<System.Collections.Generic.List<WizardGames.Soc.SocClient.Map.InvitecodeInfo>> callback, System.Boolean immediateRequest, System.Action<SimpleJSON.JSONNode> errorCallBack); // 0x077f52f0
	System.Void GetPlayers(); // 0x077f56b8
	System.Boolean SelfChatBan(); // 0x077f57c4
	System.Void .ctor(); // 0x077f598c
	static System.Void .cctor(); // 0x077f5a40
}

// Client.Runtime
class WizardGames.Soc.SocClient.Map.MgrKOL.<>c__DisplayClass7_0 : System.Object
{
	WizardGames.Soc.SocClient.Map.MgrKOL <>4__this; // 0x10
	System.Action<System.Collections.Generic.List<WizardGames.Soc.SocClient.Map.InvitecodeInfo>> callback; // 0x18
	System.Action<SimpleJSON.JSONNode> errorCallBack; // 0x20
	System.Void .ctor(); // 0x077f4db0
	System.Void <GetInviteCodes>b__0(SimpleJSON.JSONNode response); // 0x077f5b14
	System.Void <GetInviteCodes>b__1(SimpleJSON.JSONNode json); // 0x077f5f64
}

// Client.Runtime
class WizardGames.Soc.SocClient.Map.MgrKOL.<>c__DisplayClass8_0 : System.Object
{
	WizardGames.Soc.SocClient.Map.MgrKOL <>4__this; // 0x10
	WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule; // 0x18
	System.Action<System.Collections.Generic.List<WizardGames.Soc.SocClient.Map.InvitecodeInfo>> callback; // 0x20
	System.Action<SimpleJSON.JSONNode> errorCallBack; // 0x28
	System.Void .ctor(); // 0x077f5288
	System.Void <ResetNusedInviteCodes>b__0(SimpleJSON.JSONNode response); // 0x077f5ff0
	System.Void <ResetNusedInviteCodes>b__1(SimpleJSON.JSONNode json); // 0x077f6228
}

// Client.Runtime
class WizardGames.Soc.SocClient.Map.MgrKOL.<>c__DisplayClass9_0 : System.Object
{
	WizardGames.Soc.SocClient.Map.MgrKOL <>4__this; // 0x10
	System.Action<System.Collections.Generic.List<WizardGames.Soc.SocClient.Map.InvitecodeInfo>> callback; // 0x18
	System.Action<SimpleJSON.JSONNode> errorCallBack; // 0x20
	System.Void .ctor(); // 0x077f5650
	System.Void <GenerateInviteCodes>b__0(SimpleJSON.JSONNode response); // 0x077f62b4
	System.Void <GenerateInviteCodes>b__1(SimpleJSON.JSONNode json); // 0x077f6648
}

// Client.Runtime
class WizardGames.Soc.SocClient.Map.MgrMap : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger <Log>k__BackingField; // 0x0
	System.Single MapGestureScaleFactor; // 0x14
	System.Single MapGestureScaleReduceFactor; // 0x18
	System.Single MapGridLineMaxAlpha; // 0x1c
	System.Single MapGridLineMinAlpha; // 0x20
	System.Single MapGridLabelMaxAlpha; // 0x24
	System.Single MapGridLabelMinAlpha; // 0x28
	System.Single MapGridLineMedi; // 0x2c
	static UnityEngine.Color MapGrayColor; // 0x8
	static System.Single UnderGroundTriggerY; // 0x18
	UnityEngine.Texture tunnelMiniMapTexture; // 0x30
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.Map.EMapType,System.Boolean> UseTunnelMapDic; // 0x38
	System.Collections.Generic.Dictionary<System.Int32,System.String> rowGridNames; // 0x40
	System.Collections.Generic.Dictionary<System.Int32,System.String> columnGridNames; // 0x48
	static SocLogger get_Log(); // 0x077f66d4
	static System.Single get_MapDefaultScaleRatio(); // 0x077f675c
	static System.Single get_DeathMapDefaultScaleRatio(); // 0x077f683c
	static System.Single get_KatyushaMapDefaultScaleRatio(); // 0x077f691c
	static System.Single get_MapMaxScaleRatio(); // 0x077f69fc
	static System.Single get_MapMinScaleRatio(); // 0x077f6adc
	static System.Single get_DeathMapMaxScaleRatio(); // 0x077f6bbc
	static System.Single get_DeathMapMinScaleRatio(); // 0x077f6c9c
	static System.Single get_KatyushaMapMaxScaleRatio(); // 0x077f6d7c
	static System.Single get_KatyushaMapMinScaleRatio(); // 0x077f6e5c
	static System.Single get_MapScaleBtnClickStep(); // 0x077f6f3c
	static System.Int32 get_MapGridSize(); // 0x077f701c
	static System.Single get_DeathMapMoveAndScaleTime(); // 0x077f70fc
	static System.Single get_ObMapDefaultScaleRatio(); // 0x077f71dc
	static System.Single get_ObMapMaxScaleRatio(); // 0x077f72bc
	static System.Single get_ObMapMinScaleRatio(); // 0x077f739c
	static System.Single get_ObArrowMapMoveDistance(); // 0x077f747c
	System.Threading.Tasks.Task OnExitWorld(); // 0x077f755c
	FairyGUI.NTexture GetTunnelTexture(WizardGames.Soc.SocClient.Ui.Map.EMapType eMapType); // 0x077f760c
	System.Void ReleaseTunnelTexture(WizardGames.Soc.SocClient.Ui.Map.EMapType eMapType); // 0x077f7de0
	static UnityEngine.Vector2 TransformWorldPosToMap(UnityEngine.Vector3 worldPos, FairyGUI.GObject map); // 0x077f82a0
	static UnityEngine.Vector2 TransformWorldPosToMap(UnityEngine.Vector3 worldPos, UnityEngine.Vector2 mapSize); // 0x077f8550
	static UnityEngine.Vector3 TransformMapPosToWorld(FairyGUI.GObject map, UnityEngine.Vector2 posInMap); // 0x077f88e0
	System.String GetGridName(UnityEngine.Vector3 worldPosition); // 0x077f8d10
	System.String GetGridName(System.Int32 x, System.Int32 y); // 0x077f9014
	System.Void GenerateGridName(); // 0x077f9120
	System.Void CheckNeedPopRadarView(); // 0x077f9514
	System.Void SetRadarCompleted(); // 0x077f98e8
	System.Boolean GetRadarComplete(System.Int32 round); // 0x077f97a0
	System.Void OpenMainMap(); // 0x077f9a54
	System.Void CloseMainMap(); // 0x077f9c9c
	System.Boolean IsOpenMainMapUi(); // 0x077f9dd0
	System.Boolean IsObserverObMode(); // 0x077f9b80
	System.Void .ctor(); // 0x077f9ed8
	static System.Void .cctor(); // 0x077fa304
}

// Client.Runtime
class WizardGames.Soc.SocClient.Map.MgrMap.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Map.MgrMap.<>c <>9; // 0x0
	static FairyGUI.TimerCallback <>9__63_0; // 0x8
	static System.Void .cctor(); // 0x077fa4b0
	System.Void .ctor(); // 0x077fa514
	System.Void <CheckNeedPopRadarView>b__63_0(System.Object param); // 0x077fa57c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Map.MgrSoundPrint : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger <Log>k__BackingField; // 0x0
	System.Boolean isShowUi; // 0x11
	System.Boolean SettingShow; // 0x12
	System.Single Duration; // 0x14
	System.Single FreqSpace; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SoundUI.Sound> SoundPrints; // 0x20
	System.Int32 SoundPrintMax; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SoundUI.Sound> showList; // 0x30
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Data.SoundVisualization.SoundVisualizationEnumeration> SoundDic; // 0x38
	System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Ui.SoundUI.Sound> soundPool; // 0x40
	WizardGames.Soc.SocClient.Ui.SoundUI.Sound GetSound(); // 0x077fa5f4
	System.Void RemoveSound(WizardGames.Soc.SocClient.Ui.SoundUI.Sound sound); // 0x077fa6c8
	System.Void OnFpsUnlimitedUpdate(); // 0x077fa7b4
	System.Void AddSoundList(System.Collections.Generic.List<WizardGames.Soc.SocClient.Audio.WWise.AudioEventData> list); // 0x077fb17c
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SoundUI.Sound> GetShowList(); // 0x077fab8c
	System.Void Init(); // 0x077fbdb8
	System.Boolean AddSound(WizardGames.Soc.SocClient.Audio.WWise.AudioEventData soundEvent); // 0x077fb2f4
	System.Void RefreshSoundData(WizardGames.Soc.SocClient.Ui.SoundUI.Sound newSound); // 0x077fa9f4
	UnityEngine.Vector3 GetPos(UnityEngine.GameObject obj, UnityEngine.Vector3 pos); // 0x077fc248
	System.Void .ctor(); // 0x077fc380
	static System.Void .cctor(); // 0x077fc514
}

// Client.Runtime
class WizardGames.Soc.SocClient.Trigger.MonumentPreventBuildingData : System.Object
{
	System.Int64 monumentInstanceId; // 0x10
	UnityEngine.Vector3 pos; // 0x18
	UnityEngine.Vector3 size; // 0x24
	UnityEngine.Vector3 rot; // 0x30
	System.Void .ctor(); // 0x077fc5e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Trigger.MgrTrigger : WizardGames.Soc.Common.Manager.MgrBase
{
	static SocLogger logger; // 0x0
	static System.Boolean ShouldLoadTrigger; // 0x8
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Trigger.MonumentPreventBuildingData> monumentPreventBuildings; // 0x18
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<UnityEngine.BoxCollider>> dynamicColliders; // 0x20
	System.Action<WizardGames.Soc.Common.Entity.IEntity,System.Int32> mOnEntityEnterMonumentCallBack; // 0x28
	System.Action<WizardGames.Soc.Common.Entity.IEntity,System.Int32> mOnEntityLeaveMonumentCallBack; // 0x30
	System.Collections.Generic.HashSet<System.Int32> mInitedMonumentIds; // 0x38
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> monumentInstanceId2MonumentId; // 0x40
	static System.Collections.Generic.List<WizardGames.Soc.SocClient.Trigger.TriggerLightVolume> lightVolumeList; // 0x10
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,LightVolumeInfo>> lightVolumeInfoDict; // 0x48
	System.Collections.Generic.Dictionary<UnityEngine.Vector3,WizardGames.Soc.SocClient.Trigger.MonumentInfo> Position2Monument; // 0x50
	static System.Boolean _registeredCallBack; // 0x18
	static System.Collections.Generic.List<UnityEngine.MeshCollider> MeshColliders; // 0x20
	System.Threading.Tasks.Task OnEnterWorld(); // 0x077fc650
	System.Void RegisterCallBack(); // 0x077fc6c0
	System.Void SetupPosition2Monument(); // 0x077fca20
	System.Void UnregisterCallBack(); // 0x077fd0f0
	System.Threading.Tasks.Task OnExitWorld(); // 0x077fd44c
	System.Void Init(); // 0x077fd604
	System.Void LoadTriggerData(); // 0x077fd674
	System.Boolean GetMonumentCenter(System.Int32 monumentId, UnityEngine.Vector3& monumentPos); // 0x077fdc20
	System.Void LoadDetailTrigger(UnityEngine.GameObject gameObject, System.String name, System.Int32 monumentInstanceId); // 0x077fd9d8
	System.Boolean IsInitialed(); // 0x07800b70
	System.Void LoadLightVolumeData(UnityEngine.GameObject monument, WizardGames.Soc.Common.Data.monument.MonumentInformation monumentInfo, System.Int32 monumentInstanceID); // 0x077fddc4
	System.Void OnStreamingActivate(UnityEngine.GameObject cell, System.String originName); // 0x07800c30
	System.Void OnStreamingDeactivate(UnityEngine.GameObject cell); // 0x07802370
	System.Void CreateLightVolumeTrigger(UnityEngine.GameObject monument, WizardGames.Soc.Common.Data.monument.MonumentInformation ruin); // 0x07801280
	static System.Void DestroyLightVolumeTrigger(UnityEngine.GameObject monument); // 0x07802a1c
	System.Void CreateBuildingVolumeTrigger(UnityEngine.GameObject monument, WizardGames.Soc.Common.Data.monument.MonumentInformation ruin, System.String prefabName); // 0x07801ca4
	System.Void DestroyBuildingVolumeTrigger(UnityEngine.GameObject monument); // 0x07802db0
	System.Void CreateDynamicMonumentTrigger(UnityEngine.GameObject monument, WizardGames.Soc.Common.Data.monument.MonumentInformation ruin, System.Int32 instId); // 0x07800288
	UnityEngine.Mesh BuildBoxMesh(UnityEngine.Matrix4x4 matrix4X4); // 0x07802f44
	System.Void LoadPathPointData(UnityEngine.GameObject monument, WizardGames.Soc.Common.Data.monument.MonumentInformation monumentInfo, System.Int32 monumentId); // 0x077ff58c
	System.Void LoadBuildingVolumeData(UnityEngine.GameObject monument, WizardGames.Soc.Common.Data.monument.MonumentInformation monumentInfo, System.Int64 monumentInstanceId); // 0x077fe5e4
	System.Void RemoveBuildingVolumeData(UnityEngine.GameObject monument, System.String name, System.Int64 monumentInstanceId); // 0x07803190
	static System.Void LoadSafeAreaData(UnityEngine.GameObject monument, WizardGames.Soc.Common.Data.monument.MonumentInformation monumentInfo); // 0x077fe210
	static System.Void LoadActivationVolumeData(UnityEngine.GameObject monumentObject, WizardGames.Soc.Common.Data.monument.MonumentInformation monumentInfo, System.Int32 monumentId); // 0x077ffaac
	static System.Int32 GetActivationId(System.Int32 activationId, System.Int32 monumentId); // 0x07803248
	static System.Void LoadAreaBoxData(UnityEngine.GameObject monument, WizardGames.Soc.Common.Data.monument.MonumentInformation monumentInfo, System.Int32 monumentId); // 0x077feb94
	System.String GetBuildingVolumeMonumentName(System.String pveName); // 0x07803534
	System.Void CleanUp(); // 0x07803988
	System.Void OnEntityEnterMonument(WizardGames.Soc.Common.Entity.IEntity entity, System.Int32 monumentID); // 0x07803a18
	System.Void OnEntityLeaveMonument(WizardGames.Soc.Common.Entity.IEntity entity, System.Int32 monumentID); // 0x07803aac
	System.Int32 GetMonumentIdByInstanceId(System.Int32 monumentInstanceId); // 0x07803b40
	LightVolumeInfo GetLightVolumeInfo(System.Int32 monumentId, System.Int32 lightVolumeId); // 0x07803bd8
	UnityEngine.Vector3 TestPlayerTeleportToMonument(System.String monumentName, UnityEngine.Vector3 localPos); // 0x07803cd8
	System.Void .ctor(); // 0x07804308
	static System.Void .cctor(); // 0x0780456c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Trigger.MyPlayerTrigger : UnityEngine.MonoBehaviour
{
	static System.Type[] TriggerTypes; // 0x0
	System.Void OnTriggerEnter(UnityEngine.Collider co); // 0x07804704
	System.Void OnTriggerExit(UnityEngine.Collider co); // 0x07804c44
	System.Void .ctor(); // 0x07805184
	static System.Void .cctor(); // 0x078051ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Trigger.TriggerActivationVolume : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	System.Int32 activationId; // 0x30
	System.Boolean isEnter; // 0x34
	System.Void OnInit(System.Int32 id, System.Boolean enter); // 0x078032c4
	System.Void OnPlayerEnter(UnityEngine.Collider co, WizardGames.Soc.SocClient.Trigger.MyPlayerTrigger myPlayerTrigger); // 0x07804a6c
	System.Void OnPlayerLeave(UnityEngine.Collider co, WizardGames.Soc.SocClient.Trigger.MyPlayerTrigger myPlayerTrigger); // 0x07804fac
	System.Void .ctor(); // 0x0780535c
	static System.Void .cctor(); // 0x078053c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Trigger.TriggerAirWall : WizardGames.Soc.SocClient.Trigger.TriggerBase
{
	System.Int32 tipsId; // 0x38
	System.Void Init(System.Int32 TipsId); // 0x07805458
	System.Boolean InterestedInObject(WizardGames.Soc.Common.Entity.IEntity entity); // 0x07805738
	System.Void OnEntityEnter(WizardGames.Soc.Common.Entity.IEntity ent); // 0x078057f8
	System.Void .ctor(); // 0x07805b0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Trigger.TriggerBase : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.HashSet<WizardGames.Soc.Common.Entity.IEntity> entityContents; // 0x30
	System.Boolean get_HasAnyEntityContents(); // 0x07805bfc
	System.Boolean InterestedInObject(WizardGames.Soc.Common.Entity.IEntity entity); // 0x07805c84
	System.Void OnDisable(); // 0x07805cfc
	System.Void OnEntityEnter(WizardGames.Soc.Common.Entity.IEntity ent); // 0x07805a08
	System.Void OnEntityLeave(WizardGames.Soc.Common.Entity.IEntity ent); // 0x07805fc8
	System.Void OnObjectAdded(WizardGames.Soc.Common.Entity.IEntity entity); // 0x07806070
	System.Void OnObjectRemoved(WizardGames.Soc.Common.Entity.IEntity entity); // 0x078060f4
	System.Void RemoveInvalidEntities(); // 0x078063d4
	System.Void OnObjects(); // 0x07806c9c
	System.Void OnEmpty(); // 0x07806cfc
	System.Void RemoveEntity(WizardGames.Soc.Common.Entity.IEntity ent); // 0x0780690c
	System.Void OnTriggerEnter(UnityEngine.Collider co); // 0x07806d68
	System.Void OnTriggerEnter(WizardGames.Soc.Common.Entity.IEntity entity); // 0x07806f44
	System.Boolean SkipOnTriggerExit(WizardGames.Soc.Common.Entity.IEntity entity); // 0x07807240
	System.Void OnTriggerExit(UnityEngine.Collider co); // 0x078072b8
	System.Void OnTriggerExit(WizardGames.Soc.Common.Entity.IEntity entity); // 0x07805df8
	System.Void CleanUp(); // 0x07807494
	System.Void .ctor(); // 0x07805b94
	static System.Void .cctor(); // 0x078074f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Trigger.TriggerForce : WizardGames.Soc.SocClient.Trigger.TriggerBase
{
	System.Collections.Generic.HashSet<System.Int64> entityIds; // 0x38
	UnityEngine.Vector3 velocity; // 0x40
	UnityEngine.Vector3 velocityWorldSpace; // 0x4c
	UnityEngine.Vector3 gravityVel; // 0x58
	WizardGames.Soc.Common.Data.units.Carshredder Carshredder; // 0x68
	SocLogger logger; // 0x70
	System.Int32 forceId; // 0x78
	System.Collections.Generic.HashSet<System.Int32> InterestedTypeIds; // 0x80
	System.Void InitForce(System.Int64 shredderId, System.Int32 usedForceId); // 0x078075c8
	System.Void OnObjectAdded(WizardGames.Soc.Common.Entity.IEntity entity); // 0x0780783c
	System.Void OnObjectRemoved(WizardGames.Soc.Common.Entity.IEntity entity); // 0x078078c0
	System.Boolean InterestedInObject(WizardGames.Soc.Common.Entity.IEntity entity); // 0x07807b6c
	System.Void OnEntityEnter(WizardGames.Soc.Common.Entity.IEntity ent); // 0x07807ca4
	System.Void OnEntityLeave(WizardGames.Soc.Common.Entity.IEntity ent); // 0x07807ff4
	System.Void UpdateRbState(WizardGames.Soc.Common.Entity.IEntity ent, System.Boolean useGravity); // 0x07807de8
	System.Void UpdateRbState(UnityEngine.Rigidbody rigidbody, System.Boolean useGravity); // 0x07808144
	System.Void UpdateVelocity(); // 0x078081d4
	System.Void ApplyInheritedVelocity(WizardGames.Soc.Common.Entity.IEntity ent, UnityEngine.Vector3 worldVelocity); // 0x07807e64
	System.Void ApplyInheritedVelocityForPlayer(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity, UnityEngine.Vector3 worldVelocity); // 0x07808234
	System.Void ApplyInheritedVelocity(UnityEngine.Rigidbody rb, UnityEngine.Vector3 worldVelocity); // 0x078082d8
	System.Void .ctor(); // 0x078084e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Trigger.LightVolumeCfg : System.Object
{
	System.Int32 id; // 0x10
	UnityEngine.AnimationCurve mainLightIntensity; // 0x18
	UnityEngine.AnimationCurve environmentIntensity; // 0x20
	System.Boolean closeHideWaterFunc; // 0x28
	System.Boolean openShadowFunc; // 0x29
	System.Int32 todType; // 0x2c
	System.String customBakedTexturePath; // 0x30
	System.Void .ctor(); // 0x07808754
}

// Client.Runtime
class WizardGames.Soc.SocClient.Trigger.AmbientLightInfo : System.Object
{
	WizardGames.Soc.Common.Data.LightVolume LightVolume; // 0x10
	WizardGames.Soc.SocClient.Trigger.LightVolumeCfg Cfg; // 0x18
	System.Void .ctor(); // 0x07802edc
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Trigger.EMonumentInfoState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Trigger.EMonumentInfoState NONE = 0;
	static WizardGames.Soc.SocClient.Trigger.EMonumentInfoState ACTIVATE = 1;
	static WizardGames.Soc.SocClient.Trigger.EMonumentInfoState DEACTIVATE = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Trigger.MonumentInfo : System.Object
{
	UnityEngine.GameObject MonumentGo; // 0x10
	WizardGames.Soc.SocClient.Trigger.EMonumentInfoState State; // 0x18
	System.Void .ctor(); // 0x077fd088
}

// Client.Runtime
class WizardGames.Soc.SocClient.Trigger.TriggerLightVolume : UnityEngine.MonoBehaviour
{
	System.Collections.Generic.Dictionary<UnityEngine.Collider,WizardGames.Soc.SocClient.Trigger.AmbientLightInfo> ColliderDic; // 0x30
	WizardGames.Soc.SocClient.Trigger.AmbientLightInfo AmbientLightInfo; // 0x38
	WizardGames.Soc.SocClient.Trigger.LightVolumeCfg GetLightVolumeCfg(WizardGames.Soc.Common.Data.LightVolume ra); // 0x078087bc
	System.Void OnPlayerEnter(UnityEngine.Collider co, WizardGames.Soc.SocClient.Trigger.MyPlayerTrigger myPlayerTrigger); // 0x078048f0
	System.Void OnPlayerLeave(UnityEngine.Collider co, WizardGames.Soc.SocClient.Trigger.MyPlayerTrigger myPlayerTrigger); // 0x07804e30
	System.Void OnDestroy(); // 0x07808cf8
	System.Void .ctor(); // 0x07808d8c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Trigger.TriggerMonumentArea : WizardGames.Soc.SocClient.Trigger.TriggerBase
{
	System.String monumentName; // 0x38
	System.Int32 monumentId; // 0x40
	System.Int32 monumentTypeId; // 0x44
	System.Void Init(WizardGames.Soc.Common.Data.MonumentAreaVolume volume); // 0x07808e40
	System.Void OnEntityEnter(WizardGames.Soc.Common.Entity.IEntity ent); // 0x07808f98
	System.Void OnEntityLeave(WizardGames.Soc.Common.Entity.IEntity ent); // 0x07809088
	System.Void .ctor(); // 0x07809178
}

// Client.Runtime
class WizardGames.Soc.SocClient.TPNSPush.MgrPushNotice : WizardGames.Soc.Common.Manager.MgrBase
{
	SocLogger logger; // 0x18
	System.Boolean openTPNSPush; // 0x20
	System.String channel; // 0x28
	System.String fcmToken; // 0x30
	System.Void .ctor(); // 0x07809200
	System.Void OnAccountLogined(); // 0x078095c8
	System.Void OnPushBaseRetEvent(GUA.GUABaseResult baseRet); // 0x0780996c
	System.Void OnPushNotificationEvent(GUA.GUAPushResult pushRet); // 0x0780a1c8
	System.Void ParseCustomContentDict(System.String customContentDictJson); // 0x07809760
	System.Void DealWithPushNotificationClick(System.String action, System.String param); // 0x0780a650
	System.Void CleanUp(); // 0x0780ab34
	System.Void AddLocalNotification(System.Int32 id, System.Collections.Generic.Dictionary<System.String,System.String> customContent, System.DateTime dateTime, System.Int32 uniqueId, System.String[] param); // 0x0780ad3c
	System.Void AddLocalNotification(System.Int32 id, System.DateTime dateTime, System.Int32 uniqueId, System.String[] param); // 0x0780b5ec
	System.Void UpdateNotificationContent(WizardGames.Soc.Common.Data.common.OBJPushMessageContent pushMessageContent, GUA.GUALocalNotification message, System.Object[] param); // 0x0780b508
	System.Void DeleteLocalNotification(System.Int32 id); // 0x0780b69c
	System.Void <OnPushBaseRetEvent>b__14_0(SimpleJSON.JSONNode res); // 0x0780b7f0
	System.Void <OnPushBaseRetEvent>b__14_1(SimpleJSON.JSONNode error); // 0x0780b88c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Common.TestHttpServer : UnityEngine.MonoBehaviour
{
	System.Net.HttpListener _listener; // 0x30
	System.Threading.Thread _listenerThread; // 0x38
	static System.Int32 Port = 8089;
	static WizardGames.Soc.SocClient.Test.Common.TestLog Log; // 0x0
	System.Void Start(); // 0x0780b928
	System.Void StartServer(); // 0x0780b98c
	System.Void StopServer(); // 0x0780bc2c
	System.Void HandleIncomingConnections(); // 0x0780bcac
	System.Void ProcessRequest(System.Object listenerContext); // 0x0780be20
	System.Void OnDisable(); // 0x0780bfe0
	System.Void .ctor(); // 0x0780c044
	static System.Void .cctor(); // 0x0780c0ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Common.ClipBoardHelper : System.Object
{
	
	static System.String GetClipboardText(); // 0x0780c244
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Common.TestLog : System.Object
{
	SocLogger _; // 0x10
	System.Void .ctor(SocLogger log); // 0x0780c1b8
	System.Void SetSocLogger(System.Type type); // 0x0780c5c8
	System.Void Info(System.String msg); // 0x0780bba4
	System.Void Info(System.String head, System.String msg); // 0x0780c678
	System.Void Error(System.String msg); // 0x0780c7c4
	System.Void Error(System.String head, System.String msg); // 0x0780c84c
	System.Void Warn(System.String msg); // 0x0780c998
	System.Void Warn(System.String head, System.String msg); // 0x0780ca20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Test.Automation.MainTest : UnityEngine.MonoBehaviour
{
	static System.Collections.Generic.Dictionary<System.String,System.String> TestParameters; // 0x0
