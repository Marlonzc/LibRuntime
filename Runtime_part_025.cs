	WizardGames.Soc.SocClient.Ui.UiHudElem <>4__this; // 0x10
	FairyGUI.GButton button; // 0x18
	System.Single radius; // 0x20
	System.Void .ctor(); // 0x05c9833c
	System.Void <ExpandClickRange>b__0(FairyGUI.EventContext context); // 0x05c9dd20
	System.Void <ExpandClickRange>b__1(FairyGUI.EventContext context); // 0x05c9dda8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudElemCustomHeldCtrl : WizardGames.Soc.SocClient.Ui.UiHudElem
{
	
	System.Void HandleBoardInit(); // 0x05c9e124
	System.Void HandleBoardDestory(); // 0x05c9e35c
	System.Void RegeistEventByTag(); // 0x05c9e194
	System.Void UnregistEvent(); // 0x05c9e3cc
	System.Void BeforePhotoModeEnter(); // 0x05c9e594
	System.Void AfterPhotoModeExit(); // 0x05c9e5f8
	System.Void OnSwitchWeaponSuccess(System.Int64 oldWeaponId, System.Int64 weaponID); // 0x05c9e69c
	System.Void OnWeaponEquip(System.Int64 oldWeaponId, System.Int64 weaponID); // 0x05c9ea9c
	System.Boolean CheckHideEquip(System.Int64 weaponId, System.Int64 weaponTableId); // 0x05c9eb18
	System.Void .ctor(); // 0x05c9ec1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudScheme : WizardGames.Soc.Common.Unity.Ui.UiEditableScheme
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Unity.Ui.UiEditable board; // 0x28
	static System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Ui.UiEditableElemStatus>>> CloudSaveChangedScheme; // 0x8
	static System.Int32 CloudSaveSchemeIndex; // 0x10
	System.Int32 playId; // 0x30
	System.Void .ctor(WizardGames.Soc.Common.Unity.Ui.UiEditable editableBoard, System.Int32 playId); // 0x05c9ef6c
	System.Void ReadDefaultConfig(); // 0x05c9f130
	System.Void CreateSlaveStatus(System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Ui.UiEditableElemStatus> dict); // 0x05c9f678
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Ui.UiEditableElemStatus> GetDefaultConfig(System.String path); // 0x05c9f4d8
	System.Void ReadCustomConfig(); // 0x05c9f864
	System.Void WriteCustomConfig(System.Action success, System.Action error); // 0x05c9fe90
	System.Void CacheCustomConfig(); // 0x05ca046c
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Ui.UiEditableElemStatus> GetCustomConfig(System.Int32 index, System.String userName, System.Int32 id); // 0x05c9fcf8
	static System.Void .cctor(); // 0x05ca05ac
	System.Void <CacheCustomConfig>b__13_0(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x05ca06e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudScheme.<>c__DisplayClass12_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHudScheme <>4__this; // 0x10
	System.Action success; // 0x18
	System.Action error; // 0x20
	System.Void .ctor(); // 0x05ca0404
	System.Void <WriteCustomConfig>b__0(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x05ca0a80
	System.Void <WriteCustomConfig>b__1(); // 0x05ca0e28
	System.Void <WriteCustomConfig>b__2(); // 0x05ca0ea0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudScheme.<>c__DisplayClass9_0 : System.Object
{
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.Common.Unity.Ui.UiEditableElemStatus> dict; // 0x10
	System.Void .ctor(); // 0x05c9f7fc
	System.Void <CreateSlaveStatus>b__0(System.Int32 slave, System.Int32 lead); // 0x05ca0f18
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonVideo : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonVideo.UiCommonVideoBinder videoBinder; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.CommonVideo.RootCommonVideoBinder rootBinder; // 0x340
	WizardGames.Soc.SocClient.Ui.ComVideo comVideo; // 0x348
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x350
	System.Void OnInit(); // 0x05ca102c
	System.Void PlayVideo(System.String path, System.String title, System.Boolean isLoop); // 0x05ca13bc
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05ca1558
	System.Void .ctor(); // 0x05ca15d8
	System.Void <OnInit>b__4_0(); // 0x05ca1664
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPieMenu : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.GamePieMenu.ComPieMenuBinder comPieMenuBinder; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.PieOptionData> itemsData; // 0x18
	System.Single radius; // 0x20
	System.Int32 curSelectedIndex; // 0x24
	System.Action<System.Int32> onOptionSelected; // 0x28
	System.Single get_anglePerItem(); // 0x05ca16d8
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.GamePieMenu.ComPieMenuBinder menuBinder, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.PieOptionData> itemsData, System.Action<System.Int32> callback); // 0x05ca1764
	System.Boolean IsValid(); // 0x05ca1a40
	System.Void OnFps30Update(); // 0x05ca1b24
	System.Void OnFpsUnlimitedUpdate(); // 0x05ca1d14
	System.Void HandleOptionSelectedView(); // 0x05ca1ba0
	System.Void HandleOptionSelectedEvent(); // 0x05ca1d78
	System.Void RefreshSelectOption(System.Int32 selectIndex); // 0x05ca1f50
	System.Void UpdateLayout(); // 0x05ca25a4
	System.Void OnItemRender(System.Int32 index, FairyGUI.GObject itemObj); // 0x05ca2724
	UnityEngine.Vector2 CalculateCirclePoint(UnityEngine.Vector2 center, System.Single pieRadius, System.Single angleDegrees); // 0x05ca24e4
	static System.Void .cctor(); // 0x05ca2940
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPieView : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	WizardGames.Soc.SocClient.Ui.Binder.GamePieMenu.UiPieViewBinder pieViewBinder; // 0x338
	WizardGames.Soc.SocClient.Ui.UiPieMenu uiPieMenu; // 0x340
	System.Int32 itemCount; // 0x348
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.PieOptionData> ItemsData; // 0x350
	System.Void OnInit(); // 0x05ca2a14
	System.Void OnEnable(); // 0x05ca2e40
	System.Void OnDisable(); // 0x05ca2ec0
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05ca2f28
	System.Void OnOptionSelectCallBack(System.Int32 index); // 0x05ca2fb8
	System.Void OnFps30Update(System.Single dt); // 0x05ca3038
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05ca30c4
	System.Void .ctor(); // 0x05ca3150
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiAction : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GList listActions; // 0x338
	FairyGUI.GButton btnWave; // 0x340
	WizardGames.Soc.SocClient.Ui.UiHudElemBtnAction btnAction; // 0x348
	FairyGUI.GObject mainBtnBg; // 0x350
	System.Void OnInit(); // 0x05ca3228
	System.Void OnHudBlockElemChange(); // 0x05ca3894
	System.Void OnListeningCloseWindow(UnityEngine.Vector2 uiPos); // 0x05ca3980
	System.Void LoadListActions(); // 0x05ca34ac
	System.Void BtnGestureOnClick(System.Int32 index); // 0x05ca3b48
	System.Void OnGestureClick(System.Int32 index); // 0x05ca3bcc
	System.Void BtnWaveOnClick(); // 0x05ca3cd4
	System.Void OnClickWave(); // 0x05ca3d40
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05ca3eb0
	System.Void CloseWindow(); // 0x05ca38f8
	System.Void OnDestroy(); // 0x05ca3f28
	System.Void .ctor(); // 0x05ca4034
	System.Void <LoadListActions>b__7_0(FairyGUI.EventContext ctx); // 0x05ca40c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiAction.<>c__DisplayClass7_0 : System.Object
{
	System.Int32 j; // 0x10
	WizardGames.Soc.SocClient.Ui.UiAction <>4__this; // 0x18
	System.Void .ctor(); // 0x05ca3ae0
	System.Void <LoadListActions>b__1(FairyGUI.EventContext ctx); // 0x05ca4138
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiActionDebugInfo : System.Object
{
	System.String uiName; // 0x10
	System.Single onEnableTime; // 0x18
	System.Single onDisableTime; // 0x1c
	System.Single onDisposeTime; // 0x20
	System.Single LoadPackTime; // 0x24
	System.Single CreateTime; // 0x28
	System.Single OnInitTime; // 0x2c
	System.Single OnDestroyTime; // 0x30
	System.Boolean FromCache; // 0x34
	System.Boolean HideOrRemove; // 0x35
	System.String get_UiName(); // 0x05ca41bc
	System.Void set_UiName(System.String value); // 0x05ca4220
	System.Single get_OnEnableTime(); // 0x05ca434c
	System.Void set_OnEnableTime(System.Single value); // 0x05ca43b0
	System.Single get_OnDisableTime(); // 0x05ca4468
	System.Void set_OnDisableTime(System.Single value); // 0x05ca44cc
	System.Single get_OnDisposeTime(); // 0x05ca4584
	System.Void set_OnDisposeTime(System.Single value); // 0x05ca45e8
	System.Void Clear(); // 0x05ca42d0
	System.Void .ctor(); // 0x05ca46a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiActionDebug : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GTextField textUiName; // 0x338
	FairyGUI.GTextField textActInfo; // 0x340
	FairyGUI.GTextField textPoolInfo; // 0x348
	System.Text.StringBuilder actInfoStr; // 0x350
	System.Void OnInit(); // 0x05ca4708
	System.Void RefreshPoolInfo(); // 0x05ca4b8c
	System.Void RefreshActInfo(); // 0x05ca4e10
	System.Void OnDisable(); // 0x05ca53e8
	System.Void .ctor(); // 0x05ca5494
	System.Void <OnInit>b__4_0(); // 0x05ca5558
	System.Void <OnInit>b__4_1(); // 0x05ca55c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiActionExpansion : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update, WizardGames.Soc.SocClient.Ui.IJumpToUIWindow
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.UiActionExpansionBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.UiBuzzOperation uiBuzzOperation; // 0x340
	WizardGames.Soc.SocClient.Ui.UiTreasureHuntTask uiTreasureHuntTask; // 0x348
	WizardGames.Soc.SocClient.Ui.UiDailyMission uiDailyMission; // 0x350
	System.Collections.Generic.List<Assets.Scripts.UI.Window.UI.UiMission.MissionTabData> tabDataList; // 0x358
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.MissionTabType,System.Int32> missionType2TabIndex; // 0x360
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x368
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x370
	System.Int32 selectedTabIndex; // 0x378
	static System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.MissionTabType,WizardGames.Soc.SocClient.Ui.RedDotType> redType; // 0x8
	static System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.MissionTabType,System.Int32> ctrlIdx; // 0x10
	System.Action closeCb; // 0x380
	WizardGames.Soc.Common.CustomType.PoiTaskContainer get_taskContainer(); // 0x05ca56e4
	System.Void OnInit(); // 0x05ca5800
	System.Void JumpToTab(System.Int32 tabIndex); // 0x05ca6d20
	System.Void JumpToTabByMissionType(WizardGames.Soc.Common.Data.MissionTabType missionTabType); // 0x05ca6dbc
	System.Void JumpToDaily(System.Int32 missionId); // 0x05ca6ea0
	System.Void ShowActionPanel(System.Int32 selectedTabIndex); // 0x05ca6a34
	System.Void LoadTabData(); // 0x05ca631c
	System.Void OnEnable(); // 0x05ca6f40
	System.Void OnDisable(); // 0x05ca6fcc
	System.Void OnDestroy(); // 0x05ca7078
	static WizardGames.Soc.SocClient.Ui.UiActionExpansion Open(); // 0x05ca70fc
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05ca71cc
	System.Void OnFps1Update(System.Single dt); // 0x05ca7290
	System.Void JumpToUIWindow(WizardGames.Soc.SocClient.Ui.JumpData jumpData); // 0x05ca7318
	System.Void .ctor(); // 0x05ca73d8
	static System.Void .cctor(); // 0x05ca750c
	System.String <OnInit>b__12_1(); // 0x05ca7734
	System.Boolean <OnInit>b__12_2(); // 0x05ca7930
	System.Void <OnInit>b__12_3(); // 0x05ca7a3c
	System.Void <OnInit>b__12_0(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x05ca7bdc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiActionExpansion.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiActionExpansion.<>c <>9; // 0x0
	static System.Comparison<Assets.Scripts.UI.Window.UI.UiMission.MissionTabData> <>9__17_0; // 0x8
	static System.Void .cctor(); // 0x05ca7d2c
	System.Void .ctor(); // 0x05ca7d90
	System.Int32 <LoadTabData>b__17_0(Assets.Scripts.UI.Window.UI.UiMission.MissionTabData a, Assets.Scripts.UI.Window.UI.UiMission.MissionTabData b); // 0x05ca7df8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComActiveMallBg : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyActiveMall.ComBgBinder bgBinder; // 0x10
	FairyGUI.GLoader loaderKV; // 0x18
	WizardGames.Soc.SocClient.Ui.ComVideo comVideo; // 0x20
	FairyGUI.Controller ctrlStyle; // 0x28
	System.String curStyle; // 0x30
	System.Action onVideoFinished; // 0x38
	UnityEngine.Coroutine coVideoAutoPlay; // 0x40
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.LobbyActiveMall.ComBgBinder bgBinder); // 0x05ca7eb8
	System.Void ClearPreContent(System.Boolean disposeRes); // 0x05ca8180
	System.Void ClearAllContent(System.Boolean playBgAnim); // 0x05ca8748
	System.Void SetCurStyle(System.String style); // 0x05ca8688
	System.Void SetKV(System.String url); // 0x05ca88c4
	System.Void OnVideoPrepareCompleted(UnityEngine.Video.VideoPlayer player); // 0x05ca8a58
	System.Void OnVideoLoopPointReached(UnityEngine.Video.VideoPlayer player); // 0x05ca8b18
	System.Void StopVideo(System.Boolean callFinished); // 0x05ca8540
	System.Void StopVideoAutoPlay(UnityEngine.MonoBehaviour env); // 0x05ca835c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ActiveMallLotteryDrawPage : WizardGames.Soc.SocClient.Ui.ActiveMallPageBase
{
	WizardGames.Soc.Common.Data.common.OBJConditionSwitch conditionSwitch; // 0x30
	WizardGames.Soc.SocClient.Ui.Binder.LobbyActiveMall.RootActiveMall_LotteryDrawPageBinder lotteryDrawContentBinder; // 0x38
	WizardGames.Soc.SocClient.Ui.Binder.LobbyActiveMall.BtnBuyBinder btnBuyBinder; // 0x40
	WizardGames.Soc.SocClient.Ui.Binder.LobbyActiveMall.BtnBuyBinder btnBuy2Binder; // 0x48
	FairyGUI.GTextField countDownTxt; // 0x50
	WizardGames.Soc.Common.Data.mall.OBJActiveMallTab currTabCfg; // 0x58
	WizardGames.Soc.SocClient.Ui.Utils.WindowCDTime windowCDTime; // 0x60
	System.Void OnLoaderCreate(FairyGUI.GComponent com); // 0x05ca8bc0
	System.Void OnRefresh(WizardGames.Soc.Common.Data.mall.OBJActiveMallTab tabCfg); // 0x05ca9294
	System.Void OnLotteryBtn(); // 0x05caa784
	System.Void OnLotteryTenBtn(); // 0x05caac8c
	System.Void OnPlayBtn(); // 0x05caad74
	System.Boolean CheckLotteryButton(System.Int32 times); // 0x05caa86c
	System.Void OnDetailBtn(); // 0x05caadd4
	System.Void OnClickLotteryDetail(); // 0x05caae90
	System.Void RefreshLotteryBtn(); // 0x05caa318
	System.Void OnShow(WizardGames.Soc.Common.Data.mall.OBJActiveMallTab tabCfg); // 0x05caafbc
	System.Void OnHide(); // 0x05cab2dc
	System.Void OnDrawGachaInfoUpdate(System.Int32 lotteryID); // 0x05cab5f4
	System.Void OnGachaInfoUpdate(); // 0x05cab678
	System.Void OnMallItemIdInfoUpdate(System.Int32 mallItemShopId); // 0x05cab6e8
	System.Void OnCloseLotteryInnerVideo(); // 0x05cab76c
	System.Void OnResetInnerVideoPlayer(); // 0x05cab874
	System.Void .ctor(); // 0x05cab8e4
	System.Void <OnClickLotteryDetail>b__19_0(WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreview win); // 0x05cab9e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ActiveMallPageBase : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComLazyLoader lazyLoader; // 0x10
	WizardGames.Soc.Common.Unity.Ui.WindowComBase uiMain; // 0x18
	FairyGUI.GComponent comRoot; // 0x20
	System.Boolean isActive; // 0x28
	WizardGames.Soc.SocClient.Ui.ActiveMallPageBase BindLoader(WizardGames.Soc.Common.Unity.Ui.WindowComBase main, WizardGames.Soc.SocClient.Ui.ComLazyLoader loader); // 0x05cabab8
	System.Void OnLoaderCreate(FairyGUI.GComponent com); // 0x05cabbf8
	System.Void OnLoaderDestory(); // 0x05cabc78
	System.Void OnShow(WizardGames.Soc.Common.Data.mall.OBJActiveMallTab tabCfg); // 0x05cab26c
	System.Void OnHide(); // 0x05cab594
	System.Void OnRefresh(WizardGames.Soc.Common.Data.mall.OBJActiveMallTab tabCfg); // 0x05caa2a4
	System.Void OnPlayShowAnim(); // 0x05cabce4
	System.Void OnFps1Update(); // 0x05cabd44
	System.Void Show(WizardGames.Soc.Common.Data.mall.OBJActiveMallTab tabCfg); // 0x05cabda4
	System.Void Hide(); // 0x05cabe78
	System.Void .ctor(); // 0x05cab980
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ActiveMallShopPage : WizardGames.Soc.SocClient.Ui.ActiveMallPageBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyActiveMall.RootActiveMall_ShopPageBinder pageRoot; // 0x30
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.LobbyActiveMall.ListItemShopPageSpecialBinder> itemBinders; // 0x38
	System.Single biggerItemWidth; // 0x40
	System.Single smallItemWidth; // 0x44
	System.Int64 showAnimTimerId; // 0x48
	System.Boolean hasAddPack; // 0x50
	System.Int32 curScrollIndex; // 0x54
	System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Ui.ActiveMallShopPage.MallListData> mallListDataPool; // 0x58
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ActiveMallShopPage.MallListData> allListDatas; // 0x60
	WizardGames.Soc.Common.Data.mall.OBJActiveMallTab currTabCfg; // 0x68
	System.Void OnLoaderCreate(FairyGUI.GComponent com); // 0x05cabef4
	System.Void OnLoaderDestory(); // 0x05cac1e8
	System.Void AddMallItemRefPacks(); // 0x05cac284
	System.Void ReleaseMallItemRefPacks(); // 0x05cac39c
	System.Void OnShow(WizardGames.Soc.Common.Data.mall.OBJActiveMallTab tabCfg); // 0x05cac4a0
	System.Void OnHide(); // 0x05cac76c
	System.Void OnPlayShowAnim(); // 0x05cac904
	System.Void OnMallItemInfoUpdate(); // 0x05cac9c8
	System.Void OnRefresh(WizardGames.Soc.Common.Data.mall.OBJActiveMallTab tabCfg); // 0x05caca38
	WizardGames.Soc.SocClient.Ui.ActiveMallShopPage.MallListData GetMallListDataFromPool(System.Boolean isBig, WizardGames.Soc.SocClient.MallItemAdapter mallData1, WizardGames.Soc.SocClient.MallItemAdapter mallData2); // 0x05cad1d4
	System.Void ReturnMallListDatasToPool(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ActiveMallShopPage.MallListData> datas); // 0x05cad368
	System.Void CollectListDatasAndRefresh(WizardGames.Soc.Common.Data.mall.MallShelfType shelf); // 0x05cacca4
	System.Void FillRowOfListDatas(System.Boolean isBig); // 0x05cad638
	System.Void JumpShopItemMallBuy(WizardGames.Soc.SocClient.MallItemAdapter adapter); // 0x05cad884
	System.Void OnClickShopItem(WizardGames.Soc.SocClient.MallItemAdapter adapter); // 0x05cadb08
	System.Void OnClickShopItemBuy(WizardGames.Soc.SocClient.MallItemAdapter adapter); // 0x05cadcc4
	System.Void SetShopItem(WizardGames.Soc.SocClient.Ui.Binder.LobbyActiveMall.ListItemShopPageItemSpecialBinder itemBinder, WizardGames.Soc.SocClient.MallItemAdapter adapter); // 0x05cae030
	System.Void OnShopItemListItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05caf4c0
	System.Void .ctor(); // 0x05caf760
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ActiveMallShopPage.MallListData : System.Object
{
	WizardGames.Soc.SocClient.MallItemAdapter mallData1; // 0x10
	WizardGames.Soc.SocClient.MallItemAdapter mallData2; // 0x18
	System.Boolean isBig; // 0x20
	System.Void Clear(); // 0x05cad5b4
	System.Void .ctor(); // 0x05cad300
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ActiveMallShopPage.<>c__DisplayClass29_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ActiveMallShopPage <>4__this; // 0x10
	WizardGames.Soc.SocClient.MallItemAdapter adapter; // 0x18
	System.Void .ctor(); // 0x05caf458
	System.Void <SetShopItem>b__0(); // 0x05caf818
	System.Void <SetShopItem>b__1(FairyGUI.EventContext context); // 0x05caf888
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiActiveMall : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update, WizardGames.Soc.SocClient.Ui.IJumpToUIWindow
{
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.mall.ActiveMallPageType,System.Func<WizardGames.Soc.SocClient.Ui.ActiveMallPageBase>> pageRegister; // 0x338
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.mall.ActiveMallPageType,WizardGames.Soc.SocClient.Ui.ComLazyLoader> pageLazyLoaders; // 0x340
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.mall.ActiveMallPageType,WizardGames.Soc.SocClient.Ui.ActiveMallPageBase> pages; // 0x348
	WizardGames.Soc.SocClient.Ui.Binder.LobbyActiveMall.UiActiveMallBinder uiBinder; // 0x350
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x358
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x360
	WizardGames.Soc.SocClient.Ui.ComActiveMallBg <ComBg>k__BackingField; // 0x368
	WizardGames.Soc.Common.Data.mall.OBJActiveMallTab currTabCfg; // 0x370
	WizardGames.Soc.SocClient.Ui.ComActiveMallBg get_ComBg(); // 0x05caf91c
	System.Void set_ComBg(WizardGames.Soc.SocClient.Ui.ComActiveMallBg value); // 0x05caf980
	System.Void OnInit(); // 0x05cafa00
	System.Void InitNavBar(); // 0x05cb01b4
	System.Void OnClickTab(WizardGames.Soc.SocClient.Ui.NavBarData tab, System.Boolean isBtnClick); // 0x05cb0834
	System.Void HideCurrentPage(); // 0x05cb0bf8
	System.Void OnFps1Update(System.Single dt); // 0x05cb0cc0
	System.Void OnDestroy(); // 0x05cb0d88
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05cb0e8c
	System.Void JumpToUIWindow(WizardGames.Soc.SocClient.Ui.JumpData jumpData); // 0x05cb0f0c
	System.Void OnEnable(); // 0x05cb0f80
	System.Void RecoverTODOnExit(); // 0x05cb1158
	System.Void .ctor(); // 0x05cb11b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiActiveMall.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiActiveMall.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.Data.mall.OBJActiveMallTab> <>9__12_0; // 0x8
	static System.Func<WizardGames.Soc.SocClient.Ui.ActiveMallPageBase> <>9__21_0; // 0x10
	static System.Func<WizardGames.Soc.SocClient.Ui.ActiveMallPageBase> <>9__21_1; // 0x18
	static System.Void .cctor(); // 0x05cb14b0
	System.Void .ctor(); // 0x05cb1514
	System.Int32 <InitNavBar>b__12_0(WizardGames.Soc.Common.Data.mall.OBJActiveMallTab a, WizardGames.Soc.Common.Data.mall.OBJActiveMallTab b); // 0x05cb157c
	WizardGames.Soc.SocClient.Ui.ActiveMallPageBase <.ctor>b__21_0(); // 0x05cb1620
	WizardGames.Soc.SocClient.Ui.ActiveMallPageBase <.ctor>b__21_1(); // 0x05cb16a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiAdmin : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GComponent _content; // 0x338
	WizardGames.Soc.SocClient.Ui.UiRightNavBar _rightNavBar; // 0x340
	WizardGames.Soc.SocClient.Ui.UiPanel _panel; // 0x348
	FairyGUI.Controller _panelController; // 0x350
	System.Void InitComponents(); // 0x05cb1730
	System.Void OnInit(); // 0x05cb1af8
	System.Void OnEnable(); // 0x05cb1bf0
	System.Void OnDisable(); // 0x05cb1c7c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05cb1ce4
	System.Void OnClose(); // 0x05cb1d6c
	System.Void OnDestroy(); // 0x05cb1e44
	System.Void RegisterEvents(); // 0x05cb1b70
	System.Void UnRegisterEvents(); // 0x05cb1f08
	System.Void OnRightNavBtnClicked(System.Int32 index, System.Boolean isOtherBtnClicked); // 0x05cb1f88
	System.Void ResetAlpha(); // 0x05cb2144
	System.Void .ctor(); // 0x05cb2550
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiAdminComBase : System.Object
{
	FairyGUI.GComponent Root; // 0x10
	WizardGames.Soc.SocClient.Ui.UiAdmin Parent; // 0x18
	System.Void InitComponents(); // 0x05cb25dc
	System.Void OnEnable(); // 0x05cb263c
	System.Void RegisterEvents(); // 0x05cb269c
	System.Void UnregisterEvents(); // 0x05cb26fc
	System.Void Destroy(); // 0x05cb275c
	System.Void OnClose(); // 0x05cb27bc
	System.Void .ctor(); // 0x05cb281c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiClose : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GButton btnClose; // 0x338
	System.Void OnInit(); // 0x05cb2884
	System.Void OnDisable(); // 0x05cb29e8
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05cb2d30
	System.Void OnBtnCloseClick(); // 0x05cb2da8
	System.Void ResetAlpha(); // 0x05cb2a58
	System.Void .ctor(); // 0x05cb2e14
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPanel : WizardGames.Soc.SocClient.Ui.UiAdminComBase
{
	FairyGUI.GButton _btnInvincible; // 0x20
	FairyGUI.GButton _btnFlyMode; // 0x28
	FairyGUI.GList _listFillBag; // 0x30
	FairyGUI.GButton _btnShowHint; // 0x38
	FairyGUI.GTextField _txtAlpha; // 0x40
	FairyGUI.GSlider _sliderAlpha; // 0x48
	FairyGUI.GButton _btnResetTime; // 0x50
	FairyGUI.GButton _btnPlayTime; // 0x58
	FairyGUI.GSlider _sliderTime; // 0x60
	FairyGUI.GButton _btnTimeScale; // 0x68
	FairyGUI.GButton _btnSunPos; // 0x70
	FairyGUI.GTextField _txtLongitude; // 0x78
	FairyGUI.GSlider _sliderLongitude; // 0x80
	FairyGUI.GTextField _txtLatitude; // 0x88
	FairyGUI.GSlider _sliderLatitude; // 0x90
	FairyGUI.GTextField _txtShadowDistance; // 0x98
	FairyGUI.GSlider _sliderShadowDistance; // 0xa0
	FairyGUI.Controller _sunPosController; // 0xa8
	static System.Collections.Generic.List<System.Int32> UiAlphaLayerList; // 0x0
	FairyGUI.GList _listVehicle; // 0xb0
	FairyGUI.GList _listAnimal; // 0xb8
	FairyGUI.GList _listMonster; // 0xc0
	FairyGUI.Controller _pageController; // 0xc8
	FairyGUI.GTextInput _inputSearch; // 0xd0
	FairyGUI.GButton _btnSearchClear; // 0xd8
	FairyGUI.GButton _btnSearchConfirm; // 0xe0
	FairyGUI.Controller _searchController; // 0xe8
	FairyGUI.GList _listCategory; // 0xf0
	FairyGUI.GList _listItem; // 0xf8
	FairyGUI.GButton _btnAddOne; // 0x100
	FairyGUI.GButton _btnAddTen; // 0x108
	FairyGUI.GButton _btnAddN; // 0x110
	WizardGames.Soc.SocClient.Ui.UiCounter _counter; // 0x118
	FairyGUI.Controller _counterController; // 0x120
	System.Int32 _selectedCategoryId; // 0x128
	System.Int64 _targetItemId; // 0x130
	System.Void InitComponentsBasic(); // 0x05cb2ea0
	System.Void DestroyBasic(); // 0x05cb3a3c
	System.Void OnCloseBasic(); // 0x05cb3a9c
	System.Void RegisterEventsBasic(); // 0x05cb3afc
	System.Void UnregisterEventsBasic(); // 0x05cb3c08
	System.Void OnAdminUIUpdate(System.Single time); // 0x05cb3d14
	System.Void RefreshPageBasic(); // 0x05cb3f98
	System.Void RefreshFillBagList(); // 0x05cb41a0
	System.Void RefreshLayerAlpha(); // 0x05cb437c
	System.Void RefreshTime(); // 0x05cb4558
	System.Void RefreshSunPos(); // 0x05cb4688
	System.String TodmString(System.Single value); // 0x05cb49e8
	System.Void RefreshShadowDistance(); // 0x05cb478c
	System.Void OnSliderShadowDistanceChanged(FairyGUI.EventContext context); // 0x05cb4b3c
	System.Void OnSliderLatitudeChanged(FairyGUI.EventContext context); // 0x05cb4e40
	System.Void OnSliderLongitudeChanged(FairyGUI.EventContext context); // 0x05cb4f9c
	System.Void OnBtnSunPosClicked(FairyGUI.EventContext context); // 0x05cb50f8
	System.Void OnBtnTimeScaleClicked(FairyGUI.EventContext context); // 0x05cb51f0
	System.Void OnSliderTimeChanged(FairyGUI.EventContext context); // 0x05cb5370
	System.Void SetTextTime(System.Double time); // 0x05cb3df4
	System.Void OnBtnPlayTimeClicked(FairyGUI.EventContext context); // 0x05cb5514
	System.Void OnBtnResetTimeClicked(FairyGUI.EventContext context); // 0x05cb5600
	System.Void OnSliderAlphaChanged(FairyGUI.EventContext context); // 0x05cb56f8
	System.Void ResetAlpha(); // 0x05cb21b0
	System.Void OnBtnShowHintClicked(FairyGUI.EventContext context); // 0x05cb5bbc
	System.Void OnFillBagBtnClicked(System.Int32 id); // 0x05cb5da4
	System.Void OnBtnFlyModeClicked(FairyGUI.EventContext context); // 0x05cb6228
	System.Void OnBtnInvincibleClicked(FairyGUI.EventContext context); // 0x05cb6430
	System.Boolean CheckDebugEnable(); // 0x05cb4d98
	System.Void InitComponentsCreate(); // 0x05cb662c
	System.Void DestroyCreate(); // 0x05cb73f8
	System.Void OnCloseCreate(); // 0x05cb7458
	System.Void RegisterEventsCreate(); // 0x05cb74b8
	System.Void UnregisterEventsCreate(); // 0x05cb7518
	System.Void RefreshPageCreate(); // 0x05cb7578
	System.Void InitVehicleList(); // 0x05cb679c
	System.Void OnVehicleBtnClicked(System.Int64 id, WizardGames.Soc.Common.Data.VehicleType vehicleType); // 0x05cb78dc
	System.Void SpawnVehicle(System.Int64 id); // 0x05cb7d24
	System.Void SpawnModularCar(System.Int64 id); // 0x05cb7978
	System.Void InitAnimalList(); // 0x05cb6bd8
	System.Void OnAnimalBtnClicked(System.Int64 id); // 0x05cb802c
	System.Void InitMonsterList(); // 0x05cb6fe8
	System.Void OnMonsterBtnClicked(System.Int64 id); // 0x05cb8368
	System.Void SpawnMonster(System.Int64 id); // 0x05cb80a8
	System.Void InitComponents(); // 0x05cb83e4
	System.Void Destroy(); // 0x05cb8c40
	System.Void OnClose(); // 0x05cb8d38
	System.Void RegisterEvents(); // 0x05cb8e14
	System.Void UnregisterEvents(); // 0x05cb8ef0
	System.Void ShowPageByIndex(System.Int32 index); // 0x05cb2088
	System.Void RefreshPage(System.Int32 index); // 0x05cb8fcc
	System.Void UpdateListHeight(FairyGUI.GList gList, System.Int32 columnCount, System.Int32 spacingCount); // 0x05cb76e8
	System.Void InitComponentsItem(); // 0x05cb849c
	System.Void DestroyItem(); // 0x05cb8cbc
	System.Void OnCloseItem(); // 0x05cb8db4
	System.Void RegisterEventsItem(); // 0x05cb8e90
	System.Void UnregisterEventsItem(); // 0x05cb8f6c
	System.Void RefreshPageItem(); // 0x05cb9090
	System.Void RefreshCategoryList(); // 0x05cb90f0
	System.Void OnCategoryBtnClicked(System.Int32 id, System.Boolean isSelected); // 0x05cb9c18
	System.Void RefreshItemList(); // 0x05cb960c
	System.Void OnItemBtnClicked(System.Int64 id); // 0x05cb9e88
	System.Void OnInputSearchChanged(FairyGUI.EventContext context); // 0x05cb9f1c
	System.Void OnBtnSearchConfirmClicked(FairyGUI.EventContext context); // 0x05cb9fa4
	System.Void OnBtnSearchClearClicked(FairyGUI.EventContext context); // 0x05cba034
	System.Void OnBtnAddOneClicked(FairyGUI.EventContext context); // 0x05cba0f4
	System.Void OnBtnAddTenClicked(FairyGUI.EventContext context); // 0x05cba35c
	System.Void OnBtnAddNClicked(FairyGUI.EventContext context); // 0x05cba3f4
	System.Void OnConfirmKeyPad(System.Int32 num); // 0x05cba538
	System.Void OnCancelKeyPad(FairyGUI.EventContext context); // 0x05cba5d0
	System.Void RequestItem(System.Int32 num); // 0x05cba18c
	System.Void .ctor(); // 0x05cb1a4c
	static System.Void .cctor(); // 0x05cba644
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPanel.<>c__DisplayClass100_0 : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ItemInfo> itemList; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPanel <>4__this; // 0x18
	System.Void .ctor(); // 0x05cb9d68
	System.Void <RefreshItemList>b__0(System.Int32 index, FairyGUI.GObject item); // 0x05cba874
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPanel.<>c__DisplayClass100_1 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ItemInfo data; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPanel.<>c__DisplayClass100_0 CS$<>8__locals1; // 0x30
	System.Void .ctor(); // 0x05cbab38
	System.Void <RefreshItemList>b__1(FairyGUI.EventContext _); // 0x05cbaba0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPanel.<>c__DisplayClass27_0 : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Admin.AdminItem> tb; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPanel <>4__this; // 0x18
	System.Void .ctor(); // 0x05cb4980
	System.Void <RefreshFillBagList>b__0(System.Int32 index, FairyGUI.GObject item); // 0x05cbac2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPanel.<>c__DisplayClass27_1 : System.Object
{
	WizardGames.Soc.Common.Data.Admin.AdminItem data; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPanel.<>c__DisplayClass27_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x05cbae24
	System.Void <RefreshFillBagList>b__1(FairyGUI.EventContext _); // 0x05cbae8c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPanel.<>c__DisplayClass59_0 : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.VehicleInfoAdmin> vehicleList; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPanel <>4__this; // 0x18
	System.Void .ctor(); // 0x05cb75d8
	System.Void <InitVehicleList>b__0(System.Int32 index, FairyGUI.GObject item); // 0x05cbaf20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPanel.<>c__DisplayClass59_1 : System.Object
{
	WizardGames.Soc.SocClient.Ui.VehicleInfoAdmin data; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPanel.<>c__DisplayClass59_0 CS$<>8__locals1; // 0x28
	System.Void .ctor(); // 0x05cbb118
	System.Void <InitVehicleList>b__1(FairyGUI.EventContext _); // 0x05cbb180
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPanel.<>c__DisplayClass63_0 : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.MonsterInfoAdmin> animalList; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPanel <>4__this; // 0x18
	System.Void .ctor(); // 0x05cb7f38
	System.Void <InitAnimalList>b__0(System.Int32 index, FairyGUI.GObject item); // 0x05cbb210
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPanel.<>c__DisplayClass63_1 : System.Object
{
	WizardGames.Soc.SocClient.Ui.MonsterInfoAdmin data; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPanel.<>c__DisplayClass63_0 CS$<>8__locals1; // 0x20
	System.Void .ctor(); // 0x05cbb3f0
	System.Void <InitAnimalList>b__1(FairyGUI.EventContext _); // 0x05cbb458
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPanel.<>c__DisplayClass65_0 : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.MonsterInfoAdmin> monsterList; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPanel <>4__this; // 0x18
	System.Void .ctor(); // 0x05cb8300
	System.Void <InitMonsterList>b__0(System.Int32 index, FairyGUI.GObject item); // 0x05cbb4e4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPanel.<>c__DisplayClass65_1 : System.Object
{
	WizardGames.Soc.SocClient.Ui.MonsterInfoAdmin data; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPanel.<>c__DisplayClass65_0 CS$<>8__locals1; // 0x20
	System.Void .ctor(); // 0x05cbb6c4
	System.Void <InitMonsterList>b__1(FairyGUI.EventContext _); // 0x05cbb72c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPanel.<>c__DisplayClass98_0 : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ItemInfo> itemList; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPanel <>4__this; // 0x18
	System.Void .ctor(); // 0x05cb9af8
	System.Void <RefreshCategoryList>b__0(System.Int32 index, FairyGUI.GObject item); // 0x05cbb7b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPanel.<>c__DisplayClass98_1 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ItemInfo data; // 0x10
	FairyGUI.GButton btn; // 0x30
	WizardGames.Soc.SocClient.Ui.UiPanel.<>c__DisplayClass98_0 CS$<>8__locals1; // 0x38
	System.Void .ctor(); // 0x05cbb9fc
	System.Void <RefreshCategoryList>b__1(FairyGUI.EventContext _); // 0x05cbba64
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.MonsterInfoAdmin : System.ValueType
{
	System.Int64 Id; // 0x10
	System.String Name; // 0x18
	System.Void .ctor(System.Int64 id, System.String name); // 0x05cb7fa0
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.VehicleInfoAdmin : System.ValueType
{
	System.Int64 Id; // 0x10
	System.String Name; // 0x18
	WizardGames.Soc.Common.Data.VehicleType VehicleType; // 0x20
	System.Void .ctor(System.Int64 id, System.String name, WizardGames.Soc.Common.Data.VehicleType vehicleType); // 0x05cb7640
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.ItemInfo : System.ValueType
{
	System.Int32 Id; // 0x10
	System.Int64 LongId; // 0x18
	System.String Name; // 0x20
	System.String Icon; // 0x28
	System.Void .ctor(System.Int32 id, System.String name); // 0x05cb9b60
	System.Void .ctor(System.Int64 id, System.String name, System.String icon); // 0x05cb9dd0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRightNavBar : WizardGames.Soc.SocClient.Ui.UiAdminComBase
{
	FairyGUI.GList _btnList; // 0x20
	FairyGUI.GComponent _closeBtn; // 0x28
	System.Collections.Generic.List<System.String> _btnDataList; // 0x30
	System.Int32 _lastIndex; // 0x38
	System.Boolean _isSelected; // 0x3c
	System.Boolean _isFold; // 0x3d
	System.Void InitComponents(); // 0x05cbbb4c
	System.Void Destroy(); // 0x05cbbee0
	System.Void OnEnable(); // 0x05cbbfa0
	System.Void OnClose(); // 0x05cbc14c
	System.Void RegisterEvents(); // 0x05cbc23c
	System.Void UnregisterEvents(); // 0x05cbc2a0
	System.Void InitBtnListData(); // 0x05cbbcbc
	System.Void OnCloseBtnClicked(); // 0x05cbc304
	System.Void RefreshBtnList(); // 0x05cbc048
	System.Void OnBtnClicked(System.Int32 index); // 0x05cbc370
	System.Void ResetBtn(System.Int32 index); // 0x05cbc4cc
	System.Void .ctor(); // 0x05cb198c
	System.Void <RefreshBtnList>b__14_0(System.Int32 index, FairyGUI.GObject item); // 0x05cbc5c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRightNavBar.<>c__DisplayClass14_0 : System.Object
{
	System.Int32 index; // 0x10
	WizardGames.Soc.SocClient.Ui.UiRightNavBar <>4__this; // 0x18
	System.Void .ctor(); // 0x05cbc7b4
	System.Void <RefreshBtnList>b__1(FairyGUI.EventContext _); // 0x05cbc81c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiAgeAdvice : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	
	System.Void OnInit(); // 0x05cbc8a0
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05cbcb04
	System.Void .ctor(); // 0x05cbcb84
	System.Void <OnInit>b__0_0(); // 0x05cbcc10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiAimAssist : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	System.Boolean toGun; // 0x338
	System.Boolean isAttack; // 0x339
	FairyGUI.GComponent rootNode; // 0x340
	FairyGUI.GList listNavigationTabs; // 0x348
	FairyGUI.Controller controller; // 0x350
	FairyGUI.Controller controller2; // 0x358
	FairyGUI.GButton btnSwitch; // 0x360
	FairyGUI.GButton btnSave; // 0x368
	FairyGUI.GButton btnPrint; // 0x370
	FairyGUI.GButton btnMain; // 0x378
	FairyGUI.GButton[] btns; // 0x380
	FairyGUI.GButton btnAimObject; // 0x388
	FairyGUI.GList listAimTabs; // 0x390
	FairyGUI.GButton[] btnAims; // 0x398
	FairyGUI.GTextInput AimAssistPercent; // 0x3a0
	FairyGUI.GTextInput AimAssistTime; // 0x3a8
	FairyGUI.GTextInput FireSnapDistance; // 0x3b0
	FairyGUI.GTextInput AimAssistFar; // 0x3b8
	FairyGUI.GTextInput MinDistance; // 0x3c0
	FairyGUI.GTextInput MaxDistance; // 0x3c8
	FairyGUI.GTextInput ScopeSnapDelay; // 0x3d0
	FairyGUI.GTextInput ScopeSnapSpeed; // 0x3d8
	FairyGUI.GTextInput ScopeSnapDisLimit; // 0x3e0
	FairyGUI.GTextInput ScopeInterruptAimSpeed; // 0x3e8
	FairyGUI.GButton onFireButton; // 0x3f0
	FairyGUI.GButton onAdsButton; // 0x3f8
	FairyGUI.GButton offFireButton; // 0x400
	FairyGUI.GTextInput FollowAimDis; // 0x408
	FairyGUI.GList fireSnapBones; // 0x410
	FairyGUI.GTextInput fireSnapBoneWidth; // 0x418
	FairyGUI.GTextInput fireSnapBoneHeight; // 0x420
	FairyGUI.GTextInput fireSnapBoneDuckWidth; // 0x428
	FairyGUI.GTextInput fireSnapBoneDuckHeight; // 0x430
	FairyGUI.GTextInput fireSnapBoneLRoffset; // 0x438
	FairyGUI.GTextInput fireSnapBoneUDoffset; // 0x440
	FairyGUI.GTextInput[] firstGroup; // 0x448
	System.String currentfireSnapBoneName; // 0x450
	FairyGUI.GButton selectfireSnapBoneName; // 0x458
	FairyGUI.GList slowDownBones; // 0x460
	FairyGUI.GTextInput slowDownBoneWidth; // 0x468
	FairyGUI.GTextInput slowDownBoneHeight; // 0x470
	FairyGUI.GTextInput slowDownBoneDuckWidth; // 0x478
	FairyGUI.GTextInput slowDownBoneDuckHeight; // 0x480
	FairyGUI.GTextInput slowDownBoneLRoffset; // 0x488
	FairyGUI.GTextInput slowDownBoneUDoffset; // 0x490
	FairyGUI.GTextInput[] secondGroup; // 0x498
	System.String currentslowDownBoneName; // 0x4a0
	FairyGUI.GButton selectslowDownBoneName; // 0x4a8
	FairyGUI.GSlider SlowAimMinRate; // 0x4b0
	FairyGUI.GList scopeBones; // 0x4b8
	FairyGUI.GTextInput scopeBoneWidth; // 0x4c0
	FairyGUI.GTextInput scopeBoneHeight; // 0x4c8
	FairyGUI.GTextInput scopeBoneDuckWidth; // 0x4d0
	FairyGUI.GTextInput scopeBoneDuckHeight; // 0x4d8
	FairyGUI.GTextInput scopeBoneLRoffset; // 0x4e0
	FairyGUI.GTextInput scopeBoneUDoffset; // 0x4e8
	FairyGUI.GTextInput[] thirdGroup; // 0x4f0
	System.String currentscopeBoneName; // 0x4f8
	FairyGUI.GButton selectscopeBoneName; // 0x500
	FairyGUI.GList followBones; // 0x508
	FairyGUI.GTextInput followBoneWidth; // 0x510
	FairyGUI.GTextInput followBoneHeight; // 0x518
	FairyGUI.GTextInput followBoneDuckWidth; // 0x520
	FairyGUI.GTextInput followBoneDuckHeight; // 0x528
	FairyGUI.GTextInput followBoneLRoffset; // 0x530
	FairyGUI.GTextInput followBoneUDoffset; // 0x538
	FairyGUI.GTextInput[] forthGroup; // 0x540
	System.String currentfollowBoneName; // 0x548
	FairyGUI.GButton selectfollowBoneName; // 0x550
	FairyGUI.GButton[] fireSnapBonesBtn; // 0x558
	FairyGUI.GButton[] slowDownBonesBtn; // 0x560
	FairyGUI.GButton[] scopeBonesBtn; // 0x568
	FairyGUI.GButton[] followBonesBtn; // 0x570
	FairyGUI.GTextInput[] minDis; // 0x578
	FairyGUI.GTextInput[] maxDis; // 0x580
	FairyGUI.GTextInput[] angle; // 0x588
	FairyGUI.GTextInput[] rate; // 0x590
	FairyGUI.GButton btnAttackOrThrow; // 0x598
	FairyGUI.GList aimObj; // 0x5a0
	FairyGUI.GButton aimObjName; // 0x5a8
	FairyGUI.GButton[] btnAimObj; // 0x5b0
	FairyGUI.GList hitBoxList; // 0x5b8
	FairyGUI.GButton hitBox; // 0x5c0
	FairyGUI.GButton[] btnHitBox; // 0x5c8
	System.Int32 currentIndex; // 0x5d0
	WizardGames.Soc.Common.Data.AimRangeConfig[] firstdata; // 0x5d8
	WizardGames.Soc.Common.Data.AimRangeTargetConfig[] seconddata; // 0x5e0
	FairyGUI.GButton getAimObj; // 0x5e8
	System.Int32 currentAimIndex; // 0x5f0
	FairyGUI.GButton btnClose; // 0x5f8
	static System.Action<System.Boolean> startStateChange; // 0x0
	static System.Action<System.Int32> resetBoneConfig; // 0x8
	System.Int64 currentWeaponId; // 0x600
	WizardGames.Soc.SocClient.Auxiliary.AimSnap.EditorAimSnapData currentData; // 0x608
	System.Void OnInit(); // 0x05cbcc84
	System.Void Init(FairyGUI.GComponent contentPanel); // 0x05cbce18
	System.Void OnDestroy(); // 0x05cc0354
	System.Void DataShow(System.Int64 oldId, System.Int64 currentWeaponId); // 0x05cbffac
	System.Void SetTextValue(WizardGames.Soc.SocClient.Auxiliary.AimSnap.EditorAimSnapData currentData); // 0x05cc0460
	System.Void SaveTextValue(WizardGames.Soc.SocClient.Auxiliary.AimSnap.EditorAimSnapData& currentData); // 0x05cc13f8
	System.Void SetAllBonesData(System.Int32 id); // 0x05cc078c
	System.Void SetBoneTextData(System.String[] Datas, FairyGUI.GTextInput[] Groups); // 0x05cc25e8
	System.Void SaveAllBonesData(); // 0x05cc1ab8
	System.Void SetMagicBulletData(); // 0x05cc109c
	System.Void setMagicfirstData(); // 0x05cc26cc
	System.Void setHitBoxData(); // 0x05cc2b84
	System.Void SaveDataToFile(); // 0x05cc2f10
	System.String getObjName(System.Int32 id); // 0x05cc01b0
	System.Int32 getGoId(); // 0x05cc42ac
	System.Void .ctor(); // 0x05cc45a4
	System.Void <Init>b__96_0(FairyGUI.EventContext context); // 0x05cc46b4
	System.Void <Init>b__96_1(FairyGUI.EventContext context); // 0x05cc47e0
	System.Void <Init>b__96_2(FairyGUI.EventContext context); // 0x05cc48b8
	System.Void <Init>b__96_3(FairyGUI.EventContext context); // 0x05cc4930
	System.Void <Init>b__96_4(FairyGUI.EventContext context); // 0x05cc49b0
	System.Void <Init>b__96_5(FairyGUI.EventContext context); // 0x05cc4ac4
	System.Void <Init>b__96_6(FairyGUI.EventContext context); // 0x05cc4c38
	System.Void <Init>b__96_7(FairyGUI.EventContext context); // 0x05cc4e14
	System.Void <Init>b__96_8(FairyGUI.EventContext context); // 0x05cc4ff0
	System.Void <Init>b__96_9(FairyGUI.EventContext context); // 0x05cc51cc
	System.Void <Init>b__96_10(); // 0x05cc53a8
	System.Void <Init>b__96_11(FairyGUI.EventContext context); // 0x05cc547c
	System.Void <Init>b__96_12(FairyGUI.EventContext context); // 0x05cc5570
	System.Void <Init>b__96_13(FairyGUI.EventContext context); // 0x05cc57a0
	System.Void <setMagicfirstData>b__105_0(FairyGUI.EventContext context); // 0x05cc5d74
	System.Void <setHitBoxData>b__106_0(FairyGUI.EventContext context); // 0x05cc5f84
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiAnnouncement : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	SocLogger <Logger>k__BackingField; // 0x338
	FairyGUI.GList listTabs; // 0x340
	FairyGUI.Controller ctrlSize; // 0x348
	WizardGames.Soc.SocClient.Ui.UiAnnouncementContentBase textContent; // 0x350
	WizardGames.Soc.SocClient.Ui.UiAnnouncementContentBase picContent; // 0x358
	FairyGUI.Controller ctrlStyle; // 0x360
	System.Collections.Generic.List<System.Object> curAnnouncements; // 0x368
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiAnnouncementContentBase> contents; // 0x370
	System.Object curSelect; // 0x378
	System.Object preferSelect; // 0x380
	FairyGUI.GButton btnNoPopToday; // 0x388
	FairyGUI.GButton comEmpty; // 0x390
	FairyGUI.GButton btnGoto; // 0x398
	FairyGUI.GComponent comTextContent; // 0x3a0
	SocLogger get_Logger(); // 0x05cee044
	System.Void OnInit(); // 0x05cee0a8
	System.Void SetBtnNoPopToday(System.Boolean visible); // 0x05ceefc4
	System.Void GoToUrl(); // 0x05cef2a0
	System.String GetCurStrUrl(); // 0x05ceed20
	System.Void OnEnable(); // 0x05cef350
	System.Void RecordBtnNoPopToday(); // 0x05cef95c
	System.Void OnDisable(); // 0x05cefb24
	System.Void OnDestroy(); // 0x05cefbd8
	System.Void TabRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05cefd00
	System.Void OnClickTab(System.Object info); // 0x05ceffb8
	System.Void OnGetAnnouncements(); // 0x05cef3c8
	System.Void SetData(System.Object info); // 0x05cf0410
	System.Void UpdateScrollArrow(); // 0x05cef75c
	System.Void .ctor(); // 0x05cf06b8
	System.Void <OnInit>b__17_1(FairyGUI.EventContext ctx); // 0x05cf07e0
	System.Void <OnInit>b__17_2(FairyGUI.EventContext ctx); // 0x05cf0860
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiAnnouncement.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiAnnouncement.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.UiAnnouncementContentBase> <>9__17_0; // 0x8
	static System.Void .cctor(); // 0x05cf08e0
	System.Void .ctor(); // 0x05cf0944
	System.Void <OnInit>b__17_0(WizardGames.Soc.SocClient.Ui.UiAnnouncementContentBase c); // 0x05cf09ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiAnnouncement.<>c__DisplayClass25_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiAnnouncement <>4__this; // 0x10
	System.Object info; // 0x18
	System.Void .ctor(); // 0x05ceff50
	System.Void <TabRenderer>b__0(); // 0x05cf0a30
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiAnnouncementContentBase : System.Object
{
	FairyGUI.GComponent comRoot; // 0x10
	System.Void SetActive(System.Boolean active); // 0x05cf0388
	System.Boolean SetData(System.Object info); // 0x05cf0aa0
	System.Void .ctor(); // 0x05cf0b18
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiAnnouncementPicContent : WizardGames.Soc.SocClient.Ui.UiAnnouncementContentBase
{
	FairyGUI.GList picList; // 0x18
	System.String picJumpUrl; // 0x20
	System.Void .ctor(FairyGUI.GComponent root); // 0x05ceec4c
	System.Boolean SetData(System.Object info); // 0x05cf0b80
	System.Void OnClickPic(); // 0x05cf0dfc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiAnnouncementPicContent.<>c__DisplayClass3_0 : System.Object
{
	System.Collections.Generic.List<System.ValueTuple<System.String,System.String>> pics; // 0x10
	WizardGames.Soc.SocClient.Ui.UiAnnouncementPicContent <>4__this; // 0x18
	System.Void .ctor(); // 0x05cf0d94
	System.Void <SetData>b__0(System.Int32 index, FairyGUI.GObject item); // 0x05cf0ea8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiAnnouncementTextContent : WizardGames.Soc.SocClient.Ui.UiAnnouncementContentBase
{
	FairyGUI.GRichTextField textTitle; // 0x18
	FairyGUI.GRichTextField textContent; // 0x20
	System.String strUrl; // 0x28
	System.Int32 updateTime; // 0x30
	WizardGames.Soc.SocClient.Ui.SocHtmlPageContext pageCtx; // 0x38
	System.Void .ctor(FairyGUI.GComponent root); // 0x05ceea68
	System.Boolean SetData(System.Object info); // 0x05cf1120
	System.Void OnClickLink(FairyGUI.EventContext context); // 0x05cf12d0
	System.Void OnDestroy(); // 0x05cefc90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBattleData : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiBattleReport parent; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameRansackTheHouse.ComCombatDataNEWBinder binder; // 0x18
	System.Boolean showReportBtn; // 0x20
	WizardGames.Soc.Common.CustomType.PlunderReport report; // 0x28
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.GameRansackTheHouse.ComCombatDataNEWBinder com, WizardGames.Soc.SocClient.Ui.UiBattleReport parent); // 0x05cf13bc
	System.Void DefendItemRender(System.Int32 index, FairyGUI.GObject item); // 0x05cf164c
	System.Void RefreshInfo(); // 0x05cf1b60
	System.Void AttackItemRender(System.Int32 index, FairyGUI.GObject item); // 0x05cf1f7c
	System.Void SetReportBtn(System.Boolean show); // 0x05cf269c
	System.Void RefreshReportBtn(); // 0x05cf1be0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBattleData.<>c__DisplayClass4_0 : System.Object
{
	FairyGUI.GComponent com; // 0x10
	System.UInt64 roleId; // 0x18
	WizardGames.Soc.SocClient.Ui.ComBattleData <>4__this; // 0x20
	System.Void .ctor(); // 0x05cf1af8
	System.Void <DefendItemRender>b__0(WizardGames.Soc.SocClient.RoleInfo info); // 0x05cf271c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBattleData.<>c__DisplayClass4_1 : System.Object
{
	WizardGames.Soc.SocClient.RoleInfo info; // 0x10
	WizardGames.Soc.SocClient.Ui.ComBattleData.<>c__DisplayClass4_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x05cf2b98
	System.Void <DefendItemRender>b__1(); // 0x05cf2c00
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBattleData.<>c__DisplayClass7_0 : System.Object
{
	FairyGUI.GComponent com; // 0x10
	System.UInt64 roleId; // 0x18
	WizardGames.Soc.SocClient.Ui.ComBattleData <>4__this; // 0x20
	FairyGUI.GObject item; // 0x28
	FairyGUI.GObject number; // 0x30
	WizardGames.Soc.Common.CustomType.BattleSummary data; // 0x38
	System.Void .ctor(); // 0x05cf2634
	System.Void <AttackItemRender>b__0(WizardGames.Soc.SocClient.RoleInfo info); // 0x05cf2d20
	System.Void <AttackItemRender>b__1(); // 0x05cf3200
	System.Void <AttackItemRender>b__2(); // 0x05cf42f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBattleData.<>c__DisplayClass7_1 : System.Object
{
	WizardGames.Soc.SocClient.RoleInfo info; // 0x10
	WizardGames.Soc.SocClient.Ui.ComBattleData.<>c__DisplayClass7_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x05cf3198
	System.Void <AttackItemRender>b__3(); // 0x05cf4950
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBattleLog : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiBattleReport parent; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameRansackTheHouse.ComDetailsOfTheFlowBinder binder; // 0x18
	FairyGUI.GList filterList; // 0x20
	System.Collections.Generic.List<System.Boolean> setting; // 0x28
	System.Collections.Generic.List<System.String> settingName; // 0x30
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>> dic; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.Share.Framework.CustomTypeBase> curList; // 0x40
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.GameRansackTheHouse.ComDetailsOfTheFlowBinder com, WizardGames.Soc.SocClient.Ui.UiBattleReport parent); // 0x05cf4a70
	System.Void ItemRender(System.Int32 index, FairyGUI.GObject item); // 0x05cf5364
	System.Void OnFilterItemClick(FairyGUI.EventContext context); // 0x05cf5f58
	System.Void RefreshInfo(); // 0x05cf66a8
	System.Void RefreshData(); // 0x05cf611c
	System.Void FilterItemRender(System.Int32 index, FairyGUI.GObject item); // 0x05cf670c
	System.Void <.ctor>b__6_0(); // 0x05cf6848
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBattleLog.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.ComBattleLog.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Share.Framework.CustomTypeBase> <>9__11_0; // 0x8
	static System.Void .cctor(); // 0x05cf69b0
	System.Void .ctor(); // 0x05cf6a14
	System.Int32 <RefreshData>b__11_0(WizardGames.Soc.Share.Framework.CustomTypeBase a, WizardGames.Soc.Share.Framework.CustomTypeBase b); // 0x05cf6a7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBattleLog.<>c__DisplayClass8_0 : System.Object
{
	FairyGUI.GTextField text; // 0x10
	System.Void .ctor(); // 0x05cf5d50
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBattleLog.<>c__DisplayClass8_1 : System.Object
{
	WizardGames.Soc.Common.CustomType.PlunderPlayerFlowData data; // 0x10
	WizardGames.Soc.SocClient.Ui.ComBattleLog.<>c__DisplayClass8_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x05cf5db8
	System.Void <ItemRender>b__0(WizardGames.Soc.SocClient.RoleInfo info); // 0x05cf6b90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBattleLog.<>c__DisplayClass8_2 : System.Object
{
	System.String name1; // 0x10
	WizardGames.Soc.SocClient.Ui.ComBattleLog.<>c__DisplayClass8_1 CS$<>8__locals2; // 0x18
	System.Void .ctor(); // 0x05cf6cfc
	System.Void <ItemRender>b__1(WizardGames.Soc.SocClient.RoleInfo info2); // 0x05cf6d64
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBattleLog.<>c__DisplayClass8_3 : System.Object
{
	WizardGames.Soc.Common.CustomType.PlunderBuffFlowData data; // 0x10
	WizardGames.Soc.SocClient.Ui.ComBattleLog.<>c__DisplayClass8_0 CS$<>8__locals3; // 0x18
	System.Void .ctor(); // 0x05cf5e20
	System.Void <ItemRender>b__2(WizardGames.Soc.SocClient.RoleInfo info); // 0x05cf7008
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBattleLog.<>c__DisplayClass8_4 : System.Object
{
	WizardGames.Soc.Common.CustomType.PlunderAIDamageFlowData data; // 0x10
	WizardGames.Soc.SocClient.Ui.ComBattleLog.<>c__DisplayClass8_0 CS$<>8__locals4; // 0x18
	System.Void .ctor(); // 0x05cf5e88
	System.Void <ItemRender>b__3(WizardGames.Soc.SocClient.RoleInfo info); // 0x05cf727c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBattleLog.<>c__DisplayClass8_5 : System.Object
{
	WizardGames.Soc.Common.CustomType.PlunderConstructionDestroyFlowData data; // 0x10
	WizardGames.Soc.SocClient.Ui.ComBattleLog.<>c__DisplayClass8_0 CS$<>8__locals5; // 0x18
	System.Void .ctor(); // 0x05cf5ef0
	System.Void <ItemRender>b__4(WizardGames.Soc.SocClient.RoleInfo info); // 0x05cf7574
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBattleReport : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.UiBattleReport parent; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameRansackTheHouse.ComBattleReportDataBinder binder; // 0x18
	FairyGUI.GTree treeNew; // 0x20
	FairyGUI.GTreeNode rootNodeNew; // 0x28
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar itemNavBar; // 0x30
	System.Int32 curItemTabId; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ItemData> ItemDatas; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ItemData> showItemList; // 0x48
	static System.String folderItemPath; // 0x8
	static System.String childItemPath; // 0x10
	System.Int32 curSelectTabIndex; // 0x50
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ItemData> attackerUsedExplosiveList; // 0x58
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> attackerUsedExplosiveItems; // 0x60
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> repairConsume; // 0x68
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.BuildingData> destroyedContruction; // 0x70
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> destroyedFurnishing; // 0x78
	WizardGames.Soc.Share.Framework.CustomValueDictionary<System.UInt64,WizardGames.Soc.Common.CustomType.BattleSummary> dic; // 0x80
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.GameRansackTheHouse.ComBattleReportDataBinder com, WizardGames.Soc.SocClient.Ui.UiBattleReport parent); // 0x05cf797c
	System.Void RenderTreeNode(FairyGUI.GTreeNode node, FairyGUI.GComponent obj); // 0x05cf8314
	System.Void IconItemRender(System.Int32 index, FairyGUI.GObject item); // 0x05cf8948
	System.Void OnClickListItem(FairyGUI.EventContext context); // 0x05cf8c60
	System.Void SelectRightInfo(System.Int32 curSelectTabIndex); // 0x05cf8e50
	System.Void TabItemRender(System.Int32 index, FairyGUI.GObject item); // 0x05cf90a8
	System.Void RefreshInfo(); // 0x05cf91cc
	System.Void RefreshPlunderItems(); // 0x05cfa824
	System.Void InitItemNavBar(); // 0x05cfa568
	System.Void OnClickItemNavBarItem(WizardGames.Soc.SocClient.Ui.NavBarData navData, System.Boolean btnClicked); // 0x05cfb194
	System.Void InitGTree(); // 0x05cf9470
	System.Void CalculateData(); // 0x05cfb458
	FairyGUI.GTreeNode InitGTreeFolder(System.String name); // 0x05cfc614
	FairyGUI.GTreeNode GetGTreeNode(System.Boolean isFolder, WizardGames.Soc.SocClient.Ui.TreeData siteItemInfo); // 0x05cfc774
	System.Void RefreshLeft(); // 0x05cf9a14
	System.String FormatTime(System.Int64 time); // 0x05cfc930
	System.Int32 GetNum(WizardGames.Soc.Share.Framework.CustomValueDictionary<System.UInt64,WizardGames.Soc.Common.CustomType.BattleSummary> dic, System.Int32 type); // 0x05cfcef8
	System.Int32 GetSelfBattleData(System.Int32 type); // 0x05cfca90
	System.Void RefreshItemInfo(WizardGames.Soc.SocClient.Ui.Binder.GameRansackTheHouse.ComOverviewNEWBinder item, System.Int32 type, System.String title, System.String param, System.Collections.Generic.Dictionary<System.Int64,System.Int32> param2); // 0x05cfcbe0
	System.Void ExplosiveItemRender(System.Int32 index, FairyGUI.GObject item); // 0x05cfd2a8
	System.Void OnClickShowDetail(FairyGUI.EventContext context); // 0x05cfd5f4
	static System.Void .cctor(); // 0x05cfdcb8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBattleReport.<>c__DisplayClass13_0 : System.Object
{
	WizardGames.Soc.Common.Data.DataItem.ItemConfig itemDropCfg; // 0x10
	FairyGUI.GObject item; // 0x18
	System.Void .ctor(); // 0x05cf8bf8
	System.Void <IconItemRender>b__0(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05cfdde4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBattleReport.<>c__DisplayClass21_0 : System.Object
{
	System.Int32 tabId; // 0x10
	System.Void .ctor(); // 0x05cfb3f0
	System.Boolean <OnClickItemNavBarItem>b__0(WizardGames.Soc.SocClient.Ui.ItemData item); // 0x05cfdef0
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.ItemData : System.ValueType, System.IComparable<WizardGames.Soc.SocClient.Ui.ItemData>
{
	System.Int64 ItemId; // 0x10
	System.Int32 Num; // 0x18
	System.Int32 Weight; // 0x1c
	System.Boolean IsSpecial; // 0x20
	System.Int32 TabId; // 0x24
	System.Int32 WeightedValue; // 0x28
	System.Void .ctor(System.Int64 itemId, System.Int32 num, System.Int32 weight, System.Int32 tabId, System.Boolean isSpecial); // 0x05cfb0d0
	System.Int32 CompareTo(WizardGames.Soc.SocClient.Ui.ItemData other); // 0x05cfdf80
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.TreeData : System.ValueType
{
	System.Int64 id; // 0x10
	System.Int32 type; // 0x18
	System.Int32 num; // 0x1c
	System.Int32 grade; // 0x20
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.BuildingData : System.Object
{
	System.Int64 id; // 0x10
	System.Int32 num; // 0x18
	System.Int32 grade; // 0x1c
	System.Void .ctor(); // 0x05cfc8c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiAttackRecord : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger log; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.GameRansackTheHouse.UiRecordBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x340
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x348
	System.Int32 selectedTabIndex; // 0x350
	System.Collections.Generic.List<WizardGames.Soc.Share.Framework.CustomTypeBase> attackInfos; // 0x358
	System.Collections.Generic.List<WizardGames.Soc.Share.Framework.CustomTypeBase> defendInfos; // 0x360
	System.Collections.Generic.List<WizardGames.Soc.Share.Framework.CustomTypeBase> curListData; // 0x368
	System.Int64 showAnimTimerId; // 0x370
	System.Void OnInit(); // 0x05cfe03c
	System.Void RefreshPanel(); // 0x05cfec44
	System.Void OnEnable(); // 0x05cfecb4
	System.Void InitData(); // 0x05cfe67c
	System.Void RenderListItem(System.Int32 index, FairyGUI.GObject obj); // 0x05cfed70
	System.Void ShowActionPanel(System.Int32 selectedTabIndex); // 0x05cfebc0
	System.Void RefreshList(); // 0x05d002fc
	System.Void OnDisable(); // 0x05d0089c
	System.Void RefreshTitle(System.Int32 selectedTabIndex); // 0x05cffe60
	System.Void LoadTabData(); // 0x05cfe9c4
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05d00a48
	WizardGames.Soc.Common.Data.constraction.DeadSheepLevel GetDeadSheepLevel(System.Int32 deadSheepBuildingId); // 0x05cffc2c
	System.Void .ctor(); // 0x05d00ac8
	static System.Void .cctor(); // 0x05d00b54
	System.Void <OnInit>b__8_0(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x05d00c28
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiAttackRecord.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiAttackRecord.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Share.Framework.CustomTypeBase> <>9__11_0; // 0x8
	static System.Comparison<WizardGames.Soc.Share.Framework.CustomTypeBase> <>9__11_1; // 0x10
	static System.Void .cctor(); // 0x05d00ce0
	System.Void .ctor(); // 0x05d00d44
	System.Int32 <InitData>b__11_0(WizardGames.Soc.Share.Framework.CustomTypeBase a, WizardGames.Soc.Share.Framework.CustomTypeBase b); // 0x05d00dac
	System.Int32 <InitData>b__11_1(WizardGames.Soc.Share.Framework.CustomTypeBase a, WizardGames.Soc.Share.Framework.CustomTypeBase b); // 0x05d00ec8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiAttackRecord.<>c__DisplayClass12_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.GameRansackTheHouse.ComRecordBinder item; // 0x10
	WizardGames.Soc.Common.CustomType.PlunderReportBriefInfo data; // 0x18
	System.Void .ctor(); // 0x05cffbc4
	System.Void <RenderListItem>b__0(FairyGUI.EventContext ctx); // 0x05d00fe4
	System.Void <RenderListItem>b__1(FairyGUI.EventContext ctx); // 0x05d01220
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBattleReport : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger log; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.GameRansackTheHouse.UiBattleReportBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x340
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar topNavBar; // 0x348
	System.Boolean isAttacker; // 0x350
	System.Boolean isWin; // 0x351
	WizardGames.Soc.SocClient.Ui.ComBattleReport battleReport; // 0x358
	WizardGames.Soc.SocClient.Ui.ComBattleLog battleLog; // 0x360
	WizardGames.Soc.SocClient.Ui.ComBattleData battleData; // 0x368
	System.Int32 curTopBarId; // 0x370
	WizardGames.Soc.Common.CustomType.PlunderReport report; // 0x378
	System.Void OnInit(); // 0x05d0135c
	System.Void OnRootTouchBeginCapture(FairyGUI.EventContext context); // 0x05d01c40
	System.Void ShowReportBtn(System.Boolean show); // 0x05d01d98
	System.Void OnClickSharePicture(); // 0x05d01e38
	System.Void OnClickShareToChat(); // 0x05d02028
	System.Void InitTopNavBarData(); // 0x05d024d4
	System.Void OnClickTopNavBarItem(WizardGames.Soc.SocClient.Ui.NavBarData navData, System.Boolean btnClicked); // 0x05d02794
	System.Void OnDisable(); // 0x05d02af8
	System.Void OnDestroy(); // 0x05d02b8c
	System.Void RefreshPanel(WizardGames.Soc.Common.CustomType.PlunderReport report); // 0x05d02c50
	System.Void ShowPanel(System.Int32 tabId); // 0x05d02884
	static System.Void Open(System.Int64 id); // 0x05d01120
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05d02d70
	System.Void .ctor(); // 0x05d02df0
	static System.Void .cctor(); // 0x05d02e8c
	System.Void <OnInit>b__9_0(); // 0x05d02f60
	System.Void <OnClickSharePicture>b__12_0(); // 0x05d02fcc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBattleReport.<>c__DisplayClass13_0 : System.Object
{
	System.Int64 reportId; // 0x10
	WizardGames.Soc.SocClient.Ui.UiBattleReport <>4__this; // 0x18
	System.Void .ctor(); // 0x05d0246c
	System.Void <OnClickShareToChat>b__0(System.String channelId); // 0x05d03104
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHoverItemTips : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger log; // 0x0
	FairyGUI.GList list; // 0x338
	FairyGUI.GGraph touchHideBg; // 0x340
	System.Collections.Generic.List<System.String> icons; // 0x348
	System.Collections.Generic.List<System.String> names; // 0x350
	System.Collections.Generic.List<System.String> nums; // 0x358
	System.Boolean topAlign; // 0x360
	System.Void OnInit(); // 0x05d03208
	System.Void ItemRender(System.Int32 index, FairyGUI.GObject item); // 0x05d034e4
	System.Void RefreshWin(UnityEngine.Vector2 pos, UnityEngine.Vector2 size, System.Collections.Generic.List<System.String> icons, System.Collections.Generic.List<System.String> names, System.Collections.Generic.List<System.String> nums); // 0x05d036b8
	System.Void CalculatePosistion(UnityEngine.Vector2 pos, UnityEngine.Vector2 size); // 0x05d03a28
	System.Void SetUseTopAlign(System.Boolean useTopAlign); // 0x05d03d14
	static System.Void ShowTip(UnityEngine.Vector2 pos, UnityEngine.Vector2 size, System.Collections.Generic.List<System.String> icons, System.Collections.Generic.List<System.String> names, System.Collections.Generic.List<System.String> nums, System.Boolean useTopAlign); // 0x05cf4104
	static System.Void CloseWindow(); // 0x05d03df8
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05d03ea8
	System.Void .ctor(); // 0x05d03f28
	static System.Void .cctor(); // 0x05d03fb4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHoverItemTips.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiHoverItemTips.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__3_0; // 0x8
	static System.Void .cctor(); // 0x05d04088
	System.Void .ctor(); // 0x05d040ec
	System.Void <OnInit>b__3_0(); // 0x05d04154
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHoverItemTips.<>c__DisplayClass12_0 : System.Object
{
	System.Boolean useTopAlign; // 0x10
	UnityEngine.Vector2 pos; // 0x14
	UnityEngine.Vector2 size; // 0x1c
	System.Collections.Generic.List<System.String> icons; // 0x28
	System.Collections.Generic.List<System.String> names; // 0x30
	System.Collections.Generic.List<System.String> nums; // 0x38
	System.Void .ctor(); // 0x05d03d90
	System.Void <ShowTip>b__0(WizardGames.Soc.SocClient.Ui.UiHoverItemTips c); // 0x05d041d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettlement : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.GameRansackTheHouse.UiSettlementBinder uiBinder; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.GameRansackTheHouse.ComSettlementBinder settlementBinder; // 0x340
	System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Ui.UiSettlement.SettlementTipData> pendingTips; // 0x348
	WizardGames.Soc.SocClient.Ui.UiSettlement.SettlementTipData currentTip; // 0x350
	System.Int64 timerId; // 0x358
	static System.Int32 Raid; // 0x0
	static System.Int32 DefenseRaid; // 0x4
	System.Void OnInit(); // 0x05d042b8
	System.Void OnEnable(); // 0x05d0440c
	System.Void OnDisable(); // 0x05d044e8
	System.Void EnqueueTip(System.String title, System.String content, System.Single showTimeSeconds); // 0x05d04710
	System.Void ShowNextTip(); // 0x05d048e4
	System.Void StartTimer(System.Single seconds); // 0x05d04aac
	System.Void CancelTimer(); // 0x05d04604
	static System.Void ShowTip(System.String title, System.String content, System.Single showTimeSeconds); // 0x05d04d2c
	static System.Void ShowTip(System.Int32 tipId); // 0x05d04ef4
	static System.Int64 GetCurrentPlunderDurationMs(); // 0x05d051a4
	static System.Int64 GetCurrentDefensePlunderDurationMs(); // 0x05d055fc
	static System.String FormatDuration(System.Int64 durationMs); // 0x05d05410
	System.Void .ctor(); // 0x05d05818
	static System.Void .cctor(); // 0x05d058f8
	System.Void <StartTimer>b__12_0(System.Int64 id, System.Object data, System.Boolean needDelete); // 0x05d05948
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettlement.SettlementTipData : System.Object
{
	System.String Title; // 0x10
	System.String Content; // 0x18
	System.Single Duration; // 0x20
	System.Void .ctor(); // 0x05d0487c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InvitationContent : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyBattlefieldManagement.InvitationCodeContentBinder binder; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Map.InvitecodeInfo> data; // 0x18
	WizardGames.Soc.Common.Component.PlayerKOLComponent component; // 0x20
	static SocLogger <Log>k__BackingField; // 0x0
	static SocLogger get_Log(); // 0x05d059f4
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.LobbyBattlefieldManagement.InvitationCodeContentBinder binder); // 0x05d05a7c
	System.Void OpenGenerateTip(); // 0x05d05f1c
	System.Void ItemRender(System.Int32 index, FairyGUI.GObject item); // 0x05d064a4
	System.Void Refresh(System.Collections.Generic.List<WizardGames.Soc.SocClient.Map.InvitecodeInfo> data); // 0x05d06a10
	static System.Void .cctor(); // 0x05d070cc
	System.Void <.ctor>b__6_0(); // 0x05d071a0
	System.Void <.ctor>b__6_1(); // 0x05d072a0
	System.Void <.ctor>b__6_2(); // 0x05d074c4
	System.Void <.ctor>b__6_3(); // 0x05d07880
	System.Void <OpenGenerateTip>b__7_1(); // 0x05d07aa4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InvitationContent.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.InvitationContent.<>c <>9; // 0x0
	static System.Action <>9__7_0; // 0x8
	static System.Comparison<WizardGames.Soc.SocClient.Map.InvitecodeInfo> <>9__9_0; // 0x10
	static System.Void .cctor(); // 0x05d07ca0
	System.Void .ctor(); // 0x05d07d04
	System.Void <OpenGenerateTip>b__7_0(); // 0x05d07d6c
	System.Int32 <Refresh>b__9_0(WizardGames.Soc.SocClient.Map.InvitecodeInfo a, WizardGames.Soc.SocClient.Map.InvitecodeInfo b); // 0x05d07e24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InvitationContent.<>c__DisplayClass8_0 : System.Object
{
	WizardGames.Soc.SocClient.Map.InvitecodeInfo codeInfo; // 0x10
	System.String roleId; // 0x18
	System.String name; // 0x20
	System.Void .ctor(); // 0x05d069a8
	System.Void <ItemRender>b__0(); // 0x05d07f24
	System.Void <ItemRender>b__1(); // 0x05d07fe8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.KOLPlayerData : System.Object
{
	WizardGames.Soc.Common.SimpleCustom.KOLPlayerInfo player; // 0x10
	System.UInt64 roleId; // 0x18
	System.Void .ctor(); // 0x05d08184
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.KOLPlayerManageItem : System.Object
{
	System.Int32 type; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.KOLPlayerData> players; // 0x18
	System.Void .ctor(); // 0x05d081ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ManagementContent : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyBattlefieldManagement.ManagementContentBinder binder; // 0x10
	FairyGUI.GComponent comSearch; // 0x18
	WizardGames.Soc.SocClient.Ui.ComComboBox comComboBox; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.KOLPlayerManageItem> datas; // 0x28
	WizardGames.Soc.Common.Component.PlayerKOLComponent component; // 0x30
	FairyGUI.GTextInput textInput; // 0x38
	System.UInt64 serverOwnerId; // 0x40
	System.Collections.Generic.Dictionary<System.UInt64,WizardGames.Soc.Common.SimpleCustom.KOLPlayerInfo> allData; // 0x48
	System.Collections.Generic.Dictionary<System.UInt64,WizardGames.Soc.Common.SimpleCustom.KOLPlayerInfo> curDic; // 0x50
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.KOLPlayerData> adminlist; // 0x58
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.KOLPlayerData> normallist; // 0x60
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.KOLPlayerData> list; // 0x68
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.LobbyBattlefieldManagement.ManagementContentBinder binder); // 0x05d08254
	System.Void BindComSearch(); // 0x05d089d0
	System.Void ClearSearch(); // 0x05d08ce8
	System.Void OnClickSearch(System.String name); // 0x05d08d94
	System.Void OnComComboBoxClick(System.Int32 index); // 0x05d09d18
	System.Void RefreshData(System.Collections.Generic.Dictionary<System.UInt64,WizardGames.Soc.Common.SimpleCustom.KOLPlayerInfo> dic, System.Boolean isAll); // 0x05d0904c
	System.Void ItemRender(System.Int32 index, FairyGUI.GObject item); // 0x05d0a138
	System.Void PlayerItemRender(System.Int32 index, FairyGUI.GObject item); // 0x05d0a634
	System.Boolean IsServerOwner(System.UInt64 roleId); // 0x05d0a040
	System.Boolean IsOnline(System.Byte PlayerState); // 0x05d0b5a4
	System.Boolean IsChatDisabled(System.Byte PlayerState); // 0x05d0b694
	System.Boolean IsLoginDisabled(System.Byte PlayerState); // 0x05d0b61c
	System.Boolean IsAdmin(System.Byte PlayerState); // 0x05d0a0c0
	System.Boolean IsNormal(System.Byte PlayerState, System.UInt64 roleId); // 0x05d0b774
	System.Void <.ctor>b__7_0(); // 0x05d0b884
	System.Void <BindComSearch>b__8_0(FairyGUI.EventContext ctx); // 0x05d0b9bc
	System.Void <BindComSearch>b__8_1(); // 0x05d0bab8
	System.Void <BindComSearch>b__8_2(); // 0x05d0bc5c
	System.Boolean <OnComComboBoxClick>b__12_0(System.Byte a); // 0x05d0bd88
	System.Boolean <OnComComboBoxClick>b__12_1(System.Byte a); // 0x05d0be04
	System.Boolean <OnComComboBoxClick>b__12_2(System.Byte a); // 0x05d0be80
	System.Boolean <OnComComboBoxClick>b__12_3(System.Byte a); // 0x05d0bf08
	System.Boolean <OnComComboBoxClick>b__12_4(System.Byte a); // 0x05d0bf84
	System.Int32 <RefreshData>b__19_0(WizardGames.Soc.SocClient.Ui.KOLPlayerData a, WizardGames.Soc.SocClient.Ui.KOLPlayerData b); // 0x05d0c000
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ManagementContent.<>c__DisplayClass21_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ManagementContent <>4__this; // 0x10
	FairyGUI.GObject item; // 0x18
	WizardGames.Soc.SocClient.Ui.KOLPlayerData data; // 0x20
	FairyGUI.GButton btn; // 0x28
	System.Action <>9__7; // 0x30
	System.Action <>9__8; // 0x38
	System.Action <>9__9; // 0x40
	System.Action <>9__10; // 0x48
	System.Action <>9__11; // 0x50
	System.Action <>9__12; // 0x58
	System.Action <>9__17; // 0x60
	System.Action <>9__18; // 0x68
	System.Action <>9__19; // 0x70
	System.Void .ctor(); // 0x05d0b53c
	System.Void <PlayerItemRender>b__0(); // 0x05d0c174
	System.Void <PlayerItemRender>b__7(); // 0x05d0c424
	System.Void <PlayerItemRender>b__1(); // 0x05d0c4ac
	System.Void <PlayerItemRender>b__8(); // 0x05d0c840
	System.Void <PlayerItemRender>b__2(); // 0x05d0c8c8
	System.Void <PlayerItemRender>b__9(); // 0x05d0cb78
	System.Void <PlayerItemRender>b__3(); // 0x05d0cc00
	System.Void <PlayerItemRender>b__10(); // 0x05d0ceb0
	System.Void <PlayerItemRender>b__4(); // 0x05d0cf38
	System.Void <PlayerItemRender>b__11(); // 0x05d0d1e8
	System.Void <PlayerItemRender>b__5(); // 0x05d0d270
	System.Void <PlayerItemRender>b__12(); // 0x05d0d520
	System.Void <PlayerItemRender>b__13(); // 0x05d0d5a8
	System.Void <PlayerItemRender>b__17(); // 0x05d0d858
	System.Void <PlayerItemRender>b__14(); // 0x05d0d8e0
	System.Void <PlayerItemRender>b__18(); // 0x05d0db90
	System.Void <PlayerItemRender>b__15(); // 0x05d0dc18
	System.Void <PlayerItemRender>b__19(); // 0x05d0dec8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ManagementContent.<>c__DisplayClass21_1 : System.Object
{
	System.Collections.Generic.List<System.String> titles; // 0x10
	System.Collections.Generic.List<System.Action> actions; // 0x18
	WizardGames.Soc.SocClient.Ui.ManagementContent.<>c__DisplayClass21_0 CS$<>8__locals1; // 0x20
	System.Void .ctor(); // 0x05d0b70c
	System.Void <PlayerItemRender>b__6(); // 0x05d0df50
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ManagementContent.<>c__DisplayClass21_2 : System.Object
{
	System.Collections.Generic.List<System.String> titles; // 0x10
	System.Collections.Generic.List<System.Action> actions; // 0x18
	WizardGames.Soc.SocClient.Ui.ManagementContent.<>c__DisplayClass21_0 CS$<>8__locals2; // 0x20
	System.Void .ctor(); // 0x05d0b81c
	System.Void <PlayerItemRender>b__16(); // 0x05d0e30c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBattlefieldManagement : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyBattlefieldManagement.UiBattlefieldManagementBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x340
	WizardGames.Soc.SocClient.Ui.InvitationContent invitation; // 0x348
	WizardGames.Soc.SocClient.Ui.ManagementContent manageContent; // 0x350
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x358
	WizardGames.Soc.Common.Component.PlayerKOLComponent component; // 0x360
	System.Int32 curFirstTabId; // 0x368
	System.Void OnInit(); // 0x05d0e438
	System.Void OnEnable(); // 0x05d0edf0
	System.Void RefreshInvitation(); // 0x05d0ee98
	System.Void RefreshCode(System.Collections.Generic.List<WizardGames.Soc.SocClient.Map.InvitecodeInfo> list); // 0x05d0efac
	System.Void OnClickSecTab(WizardGames.Soc.SocClient.Ui.NavBarData data); // 0x05d0f030
	System.Void OnClickFirstTab(WizardGames.Soc.SocClient.Ui.NavBarData data); // 0x05d0f210
	System.Void .ctor(); // 0x05d0f320
	System.Void <OnInit>b__6_0(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x05d0f3ac
	System.Void <OnInit>b__6_1(System.Collections.Generic.Dictionary<System.UInt64,WizardGames.Soc.Common.SimpleCustom.KOLPlayerInfo> dic); // 0x05d0f540
	System.Void <OnInit>b__6_2(System.Collections.Generic.Dictionary<System.UInt64,WizardGames.Soc.Common.SimpleCustom.KOLPlayerInfo> dic); // 0x05d0f5d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBtnList : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger log; // 0x0
	FairyGUI.GList list; // 0x338
	System.Collections.Generic.List<System.String> titles; // 0x340
	System.Collections.Generic.List<System.Action> actions; // 0x348
	System.Action closeCallBack; // 0x350
	System.Void OnInit(); // 0x05d0f660
	System.Void OnEnable(); // 0x05d0f7e0
	System.Void OnDisable(); // 0x05d0f8c0
	System.Void OnTouchBegin(FairyGUI.EventContext context); // 0x05d0fa30
	System.Void ItemRender(System.Int32 index, FairyGUI.GObject item); // 0x05d0fc3c
	System.Void RefreshWin(UnityEngine.Vector2 pos, UnityEngine.Vector2 size, System.Collections.Generic.List<System.String> titles, System.Collections.Generic.List<System.Action> actions); // 0x05d0fe2c
	System.Void CalculatePosistion(UnityEngine.Vector2 pos, UnityEngine.Vector2 size); // 0x05d10178
	static System.Void ShowTip(UnityEngine.Vector2 pos, UnityEngine.Vector2 size, System.Collections.Generic.List<System.String> titles, System.Collections.Generic.List<System.Action> actions, System.Action closeCallBack); // 0x05d0e07c
	System.Void DoCloseCallBack(); // 0x05d0f9a8
	static System.Void CloseWindow(); // 0x05d1044c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05d104fc
	System.Void .ctor(); // 0x05d1057c
	static System.Void .cctor(); // 0x05d10608
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBtnList.<>c__DisplayClass13_0 : System.Object
{
	UnityEngine.Vector2 pos; // 0x10
	UnityEngine.Vector2 size; // 0x18
	System.Collections.Generic.List<System.String> titles; // 0x20
	System.Collections.Generic.List<System.Action> actions; // 0x28
	System.Action closeCallBack; // 0x30
	System.Void .ctor(); // 0x05d1088c
	System.Void <ShowTip>b__0(WizardGames.Soc.SocClient.Ui.UiBtnList c); // 0x05d108f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBtnList.<>c__DisplayClass7_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiBtnList <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Void .ctor(); // 0x05d10994
	System.Void <ItemRender>b__0(); // 0x05d109fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGenerateInviteCode : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.ComModal comModel; // 0x338
	WizardGames.Soc.SocClient.Ui.ComSliderBarBtn slideBar; // 0x340
	FairyGUI.GTextField maxGenerateNum; // 0x348
	System.Void OnInit(); // 0x05d10ad0
	static System.Void OpenTip(System.String title, System.Int32 max, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ModalBtnInfo> btns); // 0x05d10da0
	System.Void Refresh(System.String title, System.Int32 max, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ModalBtnInfo> btns); // 0x05d10f7c
	System.Void .ctor(); // 0x05d111b4
	System.Void <Refresh>b__5_0(); // 0x05d11240
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGenerateInviteCode.<>c__DisplayClass4_0 : System.Object
{
	System.String title; // 0x10
	System.Int32 max; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ModalBtnInfo> btns; // 0x20
	System.Void .ctor(); // 0x05d10f14
	System.Void <OpenTip>b__0(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05d112ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBattlePassPreviewBg : System.Object
{
	static SocLogger <Log>k__BackingField; // 0x0
	WizardGames.Soc.SocClient.Ui.ComSceneModel comSceneModel; // 0x10
	System.Int32 curShowId; // 0x18
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> modelShowCfg; // 0x20
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> equips; // 0x28
	UnityEngine.AzureSky.AzureWeatherPresetEnum lastAzureType; // 0x30
	WizardGames.Soc.SocClient.Ui.ModelConfig playerModelConfig; // 0x38
	static SocLogger get_Log(); // 0x05d11384
	System.Void Init(FairyGUI.GComponent com); // 0x05d1140c
	System.Void Destory(); // 0x05d11664
	System.Int32 SwitchBgId(System.Int32 id); // 0x05d1171c
	System.Void OnEnable(); // 0x05d1192c
	System.Void OnDisable(); // 0x05d119c8
	WizardGames.Soc.Common.Data.Play.OBJBattlePassShowBg GetBgCfg(WizardGames.Soc.Common.Data.resource.ENUMResourceType resType, WizardGames.Soc.Common.Data.resource.ENUMSkinType skinType); // 0x05d11b24
	System.Void RefreshModel(System.Int32 id, System.Boolean refresh); // 0x05d11d4c
	System.ValueTuple<UnityEngine.AzureSky.AzureWeatherPresetEnum,UnityEngine.AzureSky.EAzureControllerPresetEnum> GetAzureType(System.Int32 skinId); // 0x05d12774
	System.Void ShowSkinModel(System.Int32 id, WizardGames.Soc.Common.Data.resource.OBJGenaral cfg); // 0x05d12908
	System.Boolean IsNeedToShowFixedPackPlayerModel(WizardGames.Soc.Common.Data.resource.OBJGenaral resCfg, System.Collections.Generic.Dictionary<System.Int32,System.Int32> res, System.Int32& sex); // 0x05d12b54
	System.Boolean IsNeedToShowPlayerModel(WizardGames.Soc.Common.Data.resource.OBJGenaral resCfg, System.Collections.Generic.Dictionary<System.Int32,System.Int32> res); // 0x05d121d0
	System.Boolean IsNeedToShowCostumeSuitModel(WizardGames.Soc.Common.Data.resource.OBJGenaral resCfg, System.Collections.Generic.Dictionary<System.Int32,System.Int32> res); // 0x05d12424
	WizardGames.Soc.SocClient.Ui.ModelConfig GetModelConfigByResId(System.Int32 resId); // 0x05d12edc
	System.Void Hide(); // 0x05d11a58
	System.Void .ctor(); // 0x05d13188
	static System.Void .cctor(); // 0x05d13358
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBattlePass : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	static System.Int32 lastViewResId; // 0x0
	static System.Int32 lastClickLv; // 0x4
	static System.Int32 lastShowLv; // 0x8
	static System.Int32 lastShowExp; // 0xc
	static System.Boolean NeedRefreshLvPackState; // 0x10
	WizardGames.Soc.Common.Data.Play.OBJBattlePassBasicInfo curBPCfg; // 0x338
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.OBJBattlePassLevelReward> curAllRewards; // 0x340
	FairyGUI.Margin rwdListOriMargin; // 0x348
	UnityEngine.Vector2 rwdListOriSoftness; // 0x358
	System.Int32 fListRightSideOffset; // 0x360
	System.Single fListXSoftnessOffset; // 0x364
	System.Boolean needReCheckStageRwd; // 0x368
	System.Int32 lastStageRwdLv; // 0x36c
	WizardGames.Soc.SocClient.Ui.ComResIcon curClickIcon; // 0x370
	System.Boolean isShowingItemTips; // 0x378
	System.Boolean lookAtCurLvRwdOnRefresh; // 0x379
	System.Boolean hasEnabled; // 0x37a
	System.Boolean needCheckExpAddAnim; // 0x37b
	WizardGames.Soc.Common.Data.Play.OBJBattlePassLevelPack curCanBuyLvPack; // 0x380
	UnityEngine.Coroutine coExpAdd; // 0x388
	WizardGames.Soc.SocClient.Ui.ComTopBar comTopBar; // 0x390
	WizardGames.Soc.SocClient.Ui.Binder.LobbyBattlePass.RootBattlePassContentBinder contentBinder; // 0x398
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.LobbyBattlePass.ListItemLevelBinder> listItemBinder; // 0x3a0
	FairyGUI.GObjectPool rwdNodePool; // 0x3a8
	FairyGUI.GButton btnPreview; // 0x3b0
	WizardGames.Soc.SocClient.Ui.ComBattlePassPreviewBg comBg; // 0x3b8
	System.Void OnInit(); // 0x05d1342c
	System.Void OnDestroy(); // 0x05d14cb4
	System.Void InitTopBar(); // 0x05d1426c
	System.Void InitRwdList(); // 0x05d1437c
	System.Void OnEnable(); // 0x055049cc
	System.Void OnDisable(); // 0x05d1533c
	System.Collections.IEnumerator CoExpAddTo(System.Int32 end); // 0x05d1562c
	System.Void StartExpAddCo(System.Int32 end); // 0x05d15194
	System.Void StopExpAddCo(UnityEngine.MonoBehaviour mono); // 0x05d1547c
	WizardGames.Soc.SocClient.Ui.Binder.LobbyBattlePass.ListItemLevelBinder GetListItemLevelBinder(FairyGUI.GObject obj); // 0x05d1576c
	System.Void SetBpRewardNode(FairyGUI.GObject obj, WizardGames.Soc.Common.Data.Play.OBJBattlePassLevelReward rwd, System.Boolean isFromStageNode); // 0x05d158e8
	WizardGames.Soc.Common.Data.Play.OBJBattlePassLevelReward GetBpStageReward(); // 0x05d16658
	System.Void RefreshBpStageRewardNode(); // 0x05d16cd0
	System.Void BpRewardRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x05d17150
	System.Void ChooseAndScrollToCurLvRwd(); // 0x05d1722c
	System.Void Refresh(); // 0x05d14a50
	System.Void RefreshBpInfo(); // 0x05d17548
	System.Void RefreshBpReward(); // 0x05d179c8
	System.Void RefreshLvPackBtn(); // 0x05d17d4c
	System.Void RefreshRwdInfo(WizardGames.Soc.Common.Data.resource.OBJGenaral rwd, System.Boolean isFree); // 0x05d18bac
	System.Void RefreshReformBtn(); // 0x05d14f0c
	System.Void RefreshLvInfo(); // 0x05d181ac
	System.Void RefreshBtnState(); // 0x05d188bc
	System.Void OnFps10Update(System.Single dt); // 0x05d19068
	System.Void CheckItemTipsClose(); // 0x05d153dc
	System.Void OnClickUiRoot(); // 0x05d190fc
	System.Void OnClickTitleHelp(); // 0x05d19160
	System.Void OnScrollPanelMove(FairyGUI.EventContext ctx); // 0x05d19414
	System.Void OnClickPreview(FairyGUI.EventContext ctx); // 0x05d19490
	System.Void OnClickReform(); // 0x05d197e8
	System.Void OnClickStageRwdIcon(System.Int32 lv, System.Int32 resId); // 0x05d198ec
	System.Void OnClickResIcon(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon, System.Int32 lv, System.Boolean isFree); // 0x05d16468
	System.Void OnClickBuyExp(); // 0x05d19a4c
	System.Void OnClickTask(); // 0x05d19bf8
	System.Void OnClickMall(); // 0x05d19d04
	System.Void OnClickRewardView(); // 0x05d19df4
	System.Void OnClickUnlock(); // 0x05d19eb8
	System.Void OnClickGetAllReward(); // 0x05d19f7c
	System.Void OnClickLevelPack(); // 0x05d1a01c
	System.Void OnUpdateBattlePassReward(); // 0x05d1ac28
	System.Void OnUiHide(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05d1ace4
	System.Void OnShowByLayerStack(); // 0x05d1adf4
	static System.Void ClearStaticInfo(); // 0x05d174b8
	System.Void .ctor(); // 0x05d1ae64
	static System.Void .cctor(); // 0x05d1aef8
	System.Void <InitTopBar>b__30_0(FairyGUI.EventContext ctx); // 0x05d1af48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBattlePass.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiBattlePass.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMainQuestDetail> <>9__61_0; // 0x8
	static System.Void .cctor(); // 0x05d1afc8
	System.Void .ctor(); // 0x05d1b02c
	System.Void <OnClickTask>b__61_0(WizardGames.Soc.SocClient.Ui.UiMainQuestDetail win); // 0x05d1b094
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBattlePass.<>c__DisplayClass31_0 : System.Object
{
	FairyGUI.GObjectPool rwdPool; // 0x10
	WizardGames.Soc.SocClient.Ui.UiBattlePass <>4__this; // 0x18
	System.Void .ctor(); // 0x05d14d2c
	FairyGUI.GObject <InitRwdList>b__0(System.String url); // 0x05d1b11c
	System.Void <InitRwdList>b__1(FairyGUI.GObject obj); // 0x05d1b1ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBattlePass.<>c__DisplayClass38_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiBattlePass <>4__this; // 0x10
	WizardGames.Soc.Common.Data.Play.OBJBattlePassLevelReward rwd; // 0x18
	System.Action<WizardGames.Soc.SocClient.Ui.ComBaseIcon> <>9__3; // 0x20
	System.Void .ctor(); // 0x05d16398
	FairyGUI.GObject <SetBpRewardNode>b__0(System.String url); // 0x05d1b2a4
	System.Void <SetBpRewardNode>b__1(FairyGUI.GObject obj); // 0x05d1b33c
	System.Void <SetBpRewardNode>b__3(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05d1b3d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBattlePass.<>c__DisplayClass38_1 : System.Object
{
	WizardGames.Soc.Common.Data.resource.OBJGenaral resCfg; // 0x10
	System.Boolean isFree; // 0x18
	WizardGames.Soc.SocClient.Ui.UiBattlePass.<>c__DisplayClass38_0 CS$<>8__locals1; // 0x20
	System.Void .ctor(); // 0x05d16400
	System.Void <SetBpRewardNode>b__2(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05d1b48c
	System.Void <SetBpRewardNode>b__4(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05d1b52c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBattlePass.<>c__DisplayClass46_0 : System.Object
{
	WizardGames.Soc.SocClient.MallItemAdapter mallItemAdapter; // 0x10
	System.Int32 packId; // 0x18
	FairyGUI.GButton btn; // 0x20
	WizardGames.Soc.SocClient.Ui.UiBattlePass <>4__this; // 0x28
	WizardGames.Soc.Common.Data.Play.OBJBattlePassLevelPack packCfg; // 0x30
	System.Void .ctor(); // 0x05d18b44
	System.Void <RefreshLvPackBtn>b__0(); // 0x05d1b5c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBattlePass.<CoExpAddTo>d__34 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Ui.UiBattlePass <>4__this; // 0x20
	System.Int32 end; // 0x28
	FairyGUI.GProgressBar <progress>5__2; // 0x30
	FairyGUI.Transition <transAdding>5__3; // 0x38
	System.Void .ctor(System.Int32 <>1__state); // 0x05d156e8
	System.Void System.IDisposable.Dispose(); // 0x05d1b718
	System.Boolean MoveNext(); // 0x05d1b778
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x05d1ba5c
	System.Void System.Collections.IEnumerator.Reset(); // 0x05d1bac0
	System.Object System.Collections.IEnumerator.get_Current(); // 0x05d1bb48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBattlePassBuyLevel : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyBattlePass.RootBattlePassBuyContentBinder contentBinder; // 0x338
	FairyGUI.GLabel labelFromLevel; // 0x340
	FairyGUI.GLabel labelToLevel; // 0x348
	WizardGames.Soc.SocClient.Ui.ComPriceBtn btnPrice; // 0x350
	WizardGames.Soc.Common.Data.Play.OBJBattlePassBasicInfo curBPCfg; // 0x358
	System.Int32 expCountPerItem; // 0x360
	System.Int32 pricePerItem; // 0x364
	System.Int32 curBuyMallItemCount; // 0x368
	System.Int32 curSumPrice; // 0x36c
	System.Int32 curAddLvs; // 0x370
	WizardGames.Soc.Common.Data.resource.OBJGenaral curCurrencyCfg; // 0x378
	WizardGames.Soc.SocClient.MallItemAdapter curBuyMallItem; // 0x380
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> canGetRwdsDic; // 0x388
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.OBJGenaral> canGetRwdsList; // 0x390
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.resource.ENUMSkinType,System.Int32> skinTypeWeight; // 0x398
	System.Void OnInit(); // 0x05d1bbac
	System.Void OnUiOpenEvent(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05d1c814
	System.Void InitLvTabs(); // 0x05d1c390
	System.Void AppendRwdInfo(WizardGames.Soc.Common.Data.resource.ReleaseElements info); // 0x05d1c91c
	System.Int32 GetRwdSkinWeight(WizardGames.Soc.Common.Data.resource.OBJGenaral res); // 0x05d1ca18
	System.Int32 RwdCompare(WizardGames.Soc.Common.Data.resource.OBJGenaral a, WizardGames.Soc.Common.Data.resource.OBJGenaral b); // 0x05d1cb64
	System.Void Refresh(System.Int32 addLv); // 0x05d1cc48
	System.Void OnRwdItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x05d1d53c
	System.Void OnClickResIcon(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05d1d770
	System.Void OnSelectLv(WizardGames.Soc.SocClient.Ui.NavBarData tab, System.Boolean userClick); // 0x05d1d918
	System.Void OnConfirmBuy(); // 0x05d1d9ec
	System.Void OnClickBuy(); // 0x05d1ddc8
	System.Void .ctor(); // 0x05d1e0b0
	System.Void <OnInit>b__15_0(); // 0x05d1e2b8
	System.Void <OnConfirmBuy>b__25_1(System.String urlParams); // 0x05d1e324
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBattlePassBuyLevel.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiBattlePassBuyLevel.<>c <>9; // 0x0
	static System.Action<SimpleJSON.JSONNode> <>9__25_0; // 0x8
	static System.Action<WizardGames.Soc.SDK.MidasWrapper.EPayResult,System.String> <>9__25_2; // 0x10
	static System.Void .cctor(); // 0x05d1e504
	System.Void .ctor(); // 0x05d1e568
	System.Void <OnConfirmBuy>b__25_0(SimpleJSON.JSONNode ret); // 0x05d1e5d0
	System.Void <OnConfirmBuy>b__25_2(WizardGames.Soc.SDK.MidasWrapper.EPayResult result, System.String msg); // 0x05d1e680
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBattlePasslevelPack : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyBattlePass.UiBattlePasslevelPackBinder uiBinder; // 0x338
	WizardGames.Soc.Common.Data.Play.OBJBattlePassLevelPack curPack; // 0x340
	System.Void OnInit(); // 0x05d1e73c
	System.Void OnEnable(); // 0x05d1eb28
	System.Void SetData(WizardGames.Soc.Common.Data.Play.OBJBattlePassLevelPack pack); // 0x05d1a114
	System.Void OnClickBuy(); // 0x05d1ebd0
	System.Void .ctor(); // 0x05d1f0d8
	System.Void <OnInit>b__2_0(FairyGUI.EventContext ctx); // 0x05d1f164
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBattlePasslevelPack.<>c__DisplayClass5_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiBattlePasslevelPack <>4__this; // 0x10
	WizardGames.Soc.SocClient.MallItemAdapter mallItemAdapter; // 0x18
	System.Action<WizardGames.Soc.SDK.MidasWrapper.EPayResult,System.String> <>9__2; // 0x20
	System.Void .ctor(); // 0x05d1f070
	System.Void <OnClickBuy>b__1(); // 0x05d1f1e4
	System.Void <OnClickBuy>b__0(System.String urlParams); // 0x05d1f2dc
	System.Void <OnClickBuy>b__2(WizardGames.Soc.SDK.MidasWrapper.EPayResult result, System.String msg); // 0x05d1f474
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBattlePassPayNew : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Data.Play.OBJBattlePassBasicInfo baseConfig; // 0x338
	WizardGames.Soc.SocClient.MallItemAdapter curBuyMallItem; // 0x340
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.BattlePassBuyRewardData> rewardsList; // 0x348
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.OBJBattlePassDisplayRewards> rewardsSmallList; // 0x350
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.OBJBattlePassDisplayRewards> rewardsLargeList; // 0x358
	System.Boolean isInPurchaseing; // 0x360
	WizardGames.Soc.SocClient.Ui.EBattlePassPayType payType; // 0x364
	WizardGames.Soc.Common.Data.resource.OBJGenaral currencyConfig; // 0x368
	WizardGames.Soc.SocClient.Ui.Binder.LobbyBattlePass.RootBattlePassPayContentNewBinder contentBinder; // 0x370
	WizardGames.Soc.SocClient.Ui.Binder.LobbyBattlePass.UiBattlePassPayNewBinder binder; // 0x378
	WizardGames.Soc.SocClient.Ui.Binder.LobbyBattlePass.BtnBuyNewBinder advanceBuyBtn; // 0x380
	WizardGames.Soc.SocClient.Ui.Binder.LobbyBattlePass.BtnEliteBuyBinder eliteBuyBtn; // 0x388
	FairyGUI.GButton advanceQuilityBtn; // 0x390
	FairyGUI.GButton eliteQuilityBtn; // 0x398
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.LobbyBattlePass.ListItemRewadAllBinder> listItemBinderMap; // 0x3a0
	System.Void OnInit(); // 0x05d1f57c
	System.Void OnEnable(); // 0x05d200e4
	System.Void OnDisable(); // 0x05d206b4
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05d20728
	System.Void RefreshData(); // 0x05d207a8
	System.Void BuyBattlePass(System.Int32 ChargeID); // 0x05d20824
	System.Void OnConfirmBuy(); // 0x055049cc
	System.Void OnClickReward(System.Int32 rewardId, FairyGUI.GComponent rewardItemCom); // 0x05d21198
	System.Void GetRewardList(WizardGames.Soc.SocClient.Ui.EBattlePassPayType type); // 0x05d21324
	System.Void InitUI(FairyGUI.GComponent ContentPane); // 0x05d1f794
	System.Void SwitchDisplayUI(WizardGames.Soc.SocClient.Ui.EBattlePassPayType payType); // 0x05d20158
	System.Void RefreshRewardItem(FairyGUI.GObject item, FairyGUI.GComponent com, WizardGames.Soc.SocClient.Ui.BattlePassBuyRewardData data); // 0x05d224a8
	System.Void OnRewardItemRender(System.Int32 index, FairyGUI.GObject item); // 0x05d23244
	System.Void RefreshBuyButton(); // 0x05d21b50
	System.Void .ctor(); // 0x05d2332c
	static System.Void .cctor(); // 0x05d234d8
	System.Void <OnConfirmBuy>b__16_1(); // 0x05d235ac
	System.Void <OnConfirmBuy>b__16_0(System.String urlParams); // 0x05d23618
	System.Void <OnConfirmBuy>b__16_2(WizardGames.Soc.SDK.MidasWrapper.EPayResult result, System.String msg); // 0x05d23794
	System.Void <InitUI>b__26_0(FairyGUI.EventContext context); // 0x05d23820
	System.Void <InitUI>b__26_1(FairyGUI.EventContext context); // 0x05d238a8
	System.Void <InitUI>b__26_2(FairyGUI.EventContext context); // 0x05d2397c
	System.Void <InitUI>b__26_3(FairyGUI.EventContext context); // 0x05d239f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBattlePassPayNew.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiBattlePassPayNew.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.Data.Play.OBJBattlePassDisplayRewards> <>9__18_0; // 0x8
	static System.Comparison<WizardGames.Soc.Common.Data.Play.OBJBattlePassDisplayRewards> <>9__18_1; // 0x10
	static System.Void .cctor(); // 0x05d23a74
	System.Void .ctor(); // 0x05d23ad8
	System.Int32 <GetRewardList>b__18_0(WizardGames.Soc.Common.Data.Play.OBJBattlePassDisplayRewards a, WizardGames.Soc.Common.Data.Play.OBJBattlePassDisplayRewards b); // 0x05d23b40
	System.Int32 <GetRewardList>b__18_1(WizardGames.Soc.Common.Data.Play.OBJBattlePassDisplayRewards a, WizardGames.Soc.Common.Data.Play.OBJBattlePassDisplayRewards b); // 0x05d23bd4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBattlePassPayNew.<>c__DisplayClass28_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiBattlePassPayNew <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.LobbyBattlePass.ListItemRewadAllBinder itemBinder; // 0x18
	WizardGames.Soc.Common.Data.Play.OBJBattlePassDisplayRewards config; // 0x20
	System.Void .ctor(); // 0x05d23170
	System.Void <RefreshRewardItem>b__0(FairyGUI.EventContext content); // 0x05d23c68
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EBattlePassPayType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EBattlePassPayType None = 0;
	static WizardGames.Soc.SocClient.Ui.EBattlePassPayType Advance = 1;
	static WizardGames.Soc.SocClient.Ui.EBattlePassPayType Elite = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.BattlePassBuyRewardData : System.Object
{
	WizardGames.Soc.Common.Data.Play.OBJBattlePassDisplayRewards rewardConfig; // 0x10
	System.Int32 tipStatus; // 0x18
	System.Boolean get_IsEmpty(); // 0x05d231d8
	System.Void .ctor(); // 0x05d21ae8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.BattlePassReward : System.Object
{
	System.Int32 id; // 0x10
	System.Int32 num; // 0x14
	System.Int32 level; // 0x18
	WizardGames.Soc.Common.Data.resource.OBJGenaral cfg; // 0x20
	WizardGames.Soc.Common.Data.resource.OBJGenaral get_Cfg(); // 0x05d23d50
	System.Void .ctor(); // 0x05d23e6c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBattlePassPreview : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyBattlePass.UiBattlePassPreviewBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComBattlePassPreviewBg bg; // 0x340
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x348
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x350
	System.Int32 curViewResId; // 0x358
	System.Int32 curIndex; // 0x35c
	System.Int32 battlePassId; // 0x360
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.resource.ENUMResourceType,System.Int32> resourceTypeWeight; // 0x368
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.resource.ENUMSkinType,System.Int32> skinTypeWeight; // 0x370
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.BattlePassReward> advancedRewards; // 0x378
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.BattlePassReward> normalRewards; // 0x380
	System.Void InitUIComponent(); // 0x05d23ed4
	System.Void OnDestroy(); // 0x05d25624
	System.Void OnClickBuyBtn(FairyGUI.EventContext context); // 0x05d2569c
	System.Void ShowRes(WizardGames.Soc.SocClient.Ui.BattlePassReward reward, System.Boolean isFree); // 0x05d25570
	System.Void OnClickItem(FairyGUI.EventContext context); // 0x05d25e28
	System.Void ItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x05d2614c
	System.Void InitData(); // 0x05d24d74
	System.Int32 SortReward(WizardGames.Soc.SocClient.Ui.BattlePassReward a, WizardGames.Soc.SocClient.Ui.BattlePassReward b); // 0x05d26308
	System.Int32 GetWeight(WizardGames.Soc.SocClient.Ui.BattlePassReward a); // 0x05d26450
	System.Void RefreshBtnState(); // 0x05d26668
	System.Void LoadTabData(); // 0x05d24bf8
	System.Void OnInit(); // 0x05d2697c
	System.Void OnEnable(); // 0x05d269ec
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05d26d44
	System.Void OnDisable(); // 0x05d26e10
	System.Void Dispose(); // 0x05d26e88
	System.Boolean RefreshRwdInfo(WizardGames.Soc.SocClient.Ui.BattlePassReward reward, System.Boolean isFree); // 0x05d25774
	System.Void RefreshReformBtn(); // 0x05d26a84
	System.Void OnClickPreviewBtn(); // 0x05d26ef0
	System.Void OnClickReform(); // 0x05d27020
	System.Void .ctor(); // 0x05d270d8
	System.Void <InitUIComponent>b__9_0(FairyGUI.EventContext context); // 0x05d27538
	System.Void <InitUIComponent>b__9_1(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x05d275b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBigTitlePanel : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	WizardGames.Soc.SocClient.Ui.Binder.GameSlicePlay.UiBigTitlePanelBinder binder; // 0x338
	System.Int64 canCloseTimerId; // 0x340
	System.Int64 autoCloseTimerId; // 0x348
	System.Action CloseCallback; // 0x350
	System.Void InitUIComponent(); // 0x05d278cc
	System.Void OnInit(); // 0x05d279b0
	System.Void OnEnable(); // 0x05d27ca4
	System.Void OnFps10Update(System.Single dt); // 0x05d27d04
	System.Void RegisterEvents(); // 0x05d27a28
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05d27d78
	static System.Void ShowBigTitlePanel(Systems.ServerBigTitleData data); // 0x05d27f6c
	System.Void Show(Systems.ServerBigTitleData data); // 0x05d280f4
	System.Void OnDisable(); // 0x05d2868c
	static System.Void HideBigTitlePanel(); // 0x05d28810
	FairyGUI.GButton GetCloseButton(); // 0x05d27e78
	System.Void .ctor(); // 0x05d288c0
	System.Void <Show>b__12_0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x05d2894c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBigTitlePanel.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiBigTitlePanel.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__9_0; // 0x8
	static WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__12_1; // 0x10
	static System.Void .cctor(); // 0x05d289f4
	System.Void .ctor(); // 0x05d28a58
	System.Void <RegisterEvents>b__9_0(FairyGUI.EventContext ctx); // 0x05d28ac0
	System.Void <Show>b__12_1(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x05d28b34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSlicePlayTip : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GRichTextField titleText; // 0x338
	FairyGUI.GRichTextField timeText; // 0x340
	FairyGUI.GRichTextField nameText; // 0x348
	FairyGUI.GRichTextField HPText; // 0x350
	FairyGUI.GProgressBar hpBar; // 0x358
	FairyGUI.Controller hpShowCtrl; // 0x360
	System.Int64 timeDuration; // 0x368
	System.Int64 timeStartTime; // 0x370
	System.Int64 timerId; // 0x378
	System.Int64 HPTimerId; // 0x380
	System.Int64 targetEntityId; // 0x388
	System.String entityName; // 0x390
	static SocLogger Log; // 0x0
	System.Void OnInit(); // 0x05d28bc4
	static System.Void ShowSlicePlayTipTitle(System.Int64 duration, System.Int64 startTime, System.String timeColor, System.String title, System.String titleColor); // 0x05d28e48
	System.Void OnDisable(); // 0x05d29414
	System.Void ShowTimeTitle(System.Int64 duration, System.Int64 startTime, System.String timeColor, System.String title, System.String titleColor); // 0x05511db4
	System.Void UpdateTime(System.Int64 timeId, System.Object callbackData, System.Boolean needDelete); // 0x05d295bc
	System.Void ShowHPInfo(System.Int64 targetEntityId, System.String title); // 0x05d29768
	System.Void ShowHPInfo(System.String title, System.Single maxHP, System.Single curHP); // 0x05527728
	System.Void UpdateHPTime(System.Int64 timeId, System.Object callbackData, System.Boolean needDelete); // 0x05d29d78
	static System.Void ShowSlicePlayTipHPInfo(System.Int64 targetEntityId, System.String title); // 0x05d2a048
	System.Void .ctor(); // 0x05d2a1e8
	static System.Void .cctor(); // 0x05d2a2b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBombHomeOfflineStatistics : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GList playerLst; // 0x338
	FairyGUI.GButton exitBtn; // 0x340
	FairyGUI.GButton continueBtn; // 0x348
	FairyGUI.GTextField totalIncomeScoreTxt; // 0x350
	FairyGUI.GTextField totalCostScoreTxt; // 0x358
	FairyGUI.GTextField totalIncomeRateTxt; // 0x360
	FairyGUI.GTextField mopUpTxt; // 0x368
	FairyGUI.GTextField timeTxt; // 0x370
	FairyGUI.GTextField totalScoreTxt; // 0x378
	FairyGUI.GTextField playerNameTxt; // 0x380
	FairyGUI.GTextField titleTxt; // 0x388
	System.Int64 curSetScore; // 0x390
	System.Int64 timerId; // 0x398
	FairyGUI.GComponent panelRoot; // 0x3a0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.BombHomeOfflineStatisticsItemData> playerDataLst; // 0x3a8
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,FairyGUI.GObject>> playerItemDic; // 0x3b0
	System.Void OnInit(); // 0x05d2a384
	System.Void OnEnable(); // 0x055049cc
	System.Void OnDisable(); // 0x05d2afb0
	System.Void OnDestroy(); // 0x05d2b0b0
	System.Void OnTimer(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x05d2b148
	System.Void RefreshPlayerLst(); // 0x05d2a990
	System.Void RefreshIncomeScore(); // 0x05d2b21c
	System.Void RefreshCostScore(); // 0x05d2b27c
	System.Void OnRenderPlayerItem(System.Int32 index, FairyGUI.GObject obj); // 0x05d2b2dc
	System.Void OnClickContinue(); // 0x05d2bacc
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05d2bba0
	System.String GetTimeDesc(); // 0x05d2adb8
	System.String GetTitleDesc(); // 0x05d2aea4
	static System.Void CloseWindow(); // 0x05d2bb2c
	static WizardGames.Soc.SocClient.Ui.UiBombHomeOfflineStatistics GetWindow(); // 0x05d2bc78
	System.Void .ctor(); // 0x05d2bd38
	System.Void <OnInit>b__16_0(); // 0x05d2be70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.BombHomeOfflineStatisticsItemData : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	System.String <Name>k__BackingField; // 0x10
	System.Int32 <IncomeScore>k__BackingField; // 0x18
	System.Int32 <CostScore>k__BackingField; // 0x1c
	System.String <IncomeRate>k__BackingField; // 0x20
	System.Int32 <DeathNum>k__BackingField; // 0x28
	System.Int32 <Damage>k__BackingField; // 0x2c
	System.Int32 <Score>k__BackingField; // 0x30
	System.String get_Name(); // 0x05d2bee4
	System.Int32 get_IncomeScore(); // 0x05d2bf48
	System.Int32 get_CostScore(); // 0x05d2bfac
	System.String get_IncomeRate(); // 0x05d2c010
	System.Int32 get_DeathNum(); // 0x05d2c074
	System.Int32 get_Damage(); // 0x05d2c0d8
	System.Int32 get_Score(); // 0x05d2c13c
	System.Void OnGet(); // 0x05d2c1a0
	System.Void OnRelease(); // 0x05d2c200
	System.Void OnDestroy(); // 0x05d2c260
	System.Void .ctor(); // 0x05d2c2c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBombHomeSettlementPersonal : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GTextField resultText; // 0x338
	FairyGUI.GTextField statusText; // 0x340
	FairyGUI.GButton btnBottom; // 0x348
	FairyGUI.GTextField btnBottomText; // 0x350
	FairyGUI.GList infoList; // 0x358
	WizardGames.Soc.SocClient.Ui.ComAvatarSquare selfProfile; // 0x360
	FairyGUI.GTextField selfNameText; // 0x368
	FairyGUI.GTextField selfRankingText; // 0x370
	FairyGUI.GList headerLabelList; // 0x378
	FairyGUI.GList selfInfoList; // 0x380
	FairyGUI.GComponent personalCom; // 0x388
	FairyGUI.Controller resultController; // 0x390
	FairyGUI.Controller selfRankingController; // 0x398
	System.Int64 graphEntityId; // 0x3a0
	WizardGames.Soc.Common.SimpleCustom.InitStatPanelDataCfg panelConfig; // 0x3a8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo> dataByPerson; // 0x3b0
	WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo selfData; // 0x3b8
	System.Int64 panelOpenTime; // 0x3f8
	System.Int64 canCloseTime; // 0x400
	System.Int64 autoCloseTime; // 0x408
	System.Int32 curProcessContentIndex; // 0x410
	System.Boolean hasSelfData; // 0x414
	System.Int32 selfRank; // 0x418
	System.Int64 settlementUpdateTimerId; // 0x420
	System.Void OnInit(); // 0x055049cc
	System.Void SetSettlementMode(System.Int32 mode, System.String title, System.String desc, System.Int32 canCloseTime, System.Int32 autoCloseTime); // 0x05510898
	System.Void OnSettlementModeUpdate(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x05d2d008
	System.Void OnClickReturnToLobby(); // 0x05d2d2f4
	System.Void OnDisable(); // 0x05d2d3ac
	System.Void UpdatePanel(); // 0x05d2cbbc
	System.Void ProcessDataByPerson(); // 0x05d2d4b8
	System.Void OnUserInfoBack(SimpleJSON.JSONArray jsonArray); // 0x05d2d7ac
	System.Void ShowPanel(); // 0x05d2e290
	System.Void PersonalListRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05d2e684
	System.Void OnClickReportBtn(System.String name, System.Int64 roleId); // 0x05d2ee7c
	System.Void ContentItemLabelRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05d2efa4
	System.Void ContentItemLabelSelfRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05d2f13c
	System.Void HeaderLabelRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05d2f2a4
	System.Void .ctor(); // 0x05d2f448
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBombHomeSettlementPersonal.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiBombHomeSettlementPersonal.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo> <>9__32_0; // 0x8
	static System.Void .cctor(); // 0x05d2f528
	System.Void .ctor(); // 0x05d2f58c
	System.Int32 <OnUserInfoBack>b__32_0(WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo a, WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo b); // 0x05d2f5f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBombHomeSettlementPersonal.<>c__DisplayClass34_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiBombHomeSettlementPersonal <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo info; // 0x18
	System.Void .ctor(); // 0x05d2ee14
	System.Void <PersonalListRenderer>b__0(FairyGUI.EventContext ctx); // 0x05d2f6ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBombHomeSettlementTeam : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GTextField resultText; // 0x338
	FairyGUI.GTextField statusText; // 0x340
	FairyGUI.GButton btnBottom; // 0x348
	FairyGUI.GTextField btnBottomText; // 0x350
	FairyGUI.GTextField defensePointsText; // 0x358
	FairyGUI.GTextField attackPointsText; // 0x360
	FairyGUI.GTextField defenseTeamText; // 0x368
	FairyGUI.GTextField attackTeamText; // 0x370
	FairyGUI.GList defensePlayerList; // 0x378
	FairyGUI.GList attackPlayerList; // 0x380
	FairyGUI.GList headerLabelList; // 0x388
	FairyGUI.Controller resultController; // 0x390
	FairyGUI.Controller attackTeamScoreController; // 0x398
	FairyGUI.Controller defenseTeamScoreController; // 0x3a0
	System.Int64 graphEntityId; // 0x3a8
	WizardGames.Soc.Common.SimpleCustom.InitStatPanelDataCfg panelConfig; // 0x3b0
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo>> dataByTeam; // 0x3b8
	System.Int64 panelOpenTime; // 0x3c0
	System.Int64 canCloseTime; // 0x3c8
	System.Int64 autoCloseTime; // 0x3d0
	System.Int64 curProcessTeamId; // 0x3d8
	System.Int32 curProcessContentIndex; // 0x3e0
	System.Int64 settlementUpdateTimerId; // 0x3e8
	System.Void OnInit(); // 0x055049cc
	System.Void SetSettlementMode(System.Int32 mode, System.String title, System.String desc, System.Int32 canCloseTime, System.Int32 autoCloseTime); // 0x05510898
	System.Void UpdatePanel(); // 0x05d2fee8
	System.Void ProcessDataByTeam(); // 0x05d30334
	System.Void OnUserInfoBack(SimpleJSON.JSONArray jsonArray); // 0x05d30628
	System.Void ShowPanel(); // 0x05d310dc
	System.Void OnSettlementModeUpdate(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x05d31684
	System.Void OnClickReturnToLobby(); // 0x05d31984
	System.Void TeamListRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05d31a3c
	System.Void OnClickReportBtn(System.String name, System.Int64 roleId); // 0x05d32208
	System.Void ContentItemLabelRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05d32330
	System.Void HeaderLabelRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05d324ec
	System.Void .ctor(); // 0x05d32690
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBombHomeSettlementTeam.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiBombHomeSettlementTeam.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo> <>9__27_0; // 0x8
	static System.Void .cctor(); // 0x05d32e3c
	System.Void .ctor(); // 0x05d32ea0
	System.Int32 <OnUserInfoBack>b__27_0(WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo a, WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo b); // 0x05d32f08
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBombHomeSettlementTeam.<>c__DisplayClass31_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiBombHomeSettlementTeam <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo info; // 0x18
	System.Void .ctor(); // 0x05d32fc0
	System.Void <TeamListRenderer>b__0(FairyGUI.EventContext ctx); // 0x05d33028
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBombHomeStatisticPersonal : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GTextField statusText; // 0x338
	FairyGUI.GButton btnClose; // 0x340
	FairyGUI.GList infoList; // 0x348
	WizardGames.Soc.SocClient.Ui.ComAvatarSquare selfProfile; // 0x350
	FairyGUI.GTextField selfNameText; // 0x358
	FairyGUI.GTextField selfRankingText; // 0x360
	FairyGUI.GList headerLabelList; // 0x368
	FairyGUI.GList selfInfoList; // 0x370
	FairyGUI.GComponent personalCom; // 0x378
	FairyGUI.Controller selfRankingController; // 0x380
	System.Int64 graphEntityId; // 0x388
	WizardGames.Soc.Common.SimpleCustom.InitStatPanelDataCfg panelConfig; // 0x390
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo> dataByPerson; // 0x398
	WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo selfData; // 0x3a0
	System.Int64 panelOpenTime; // 0x3e0
	System.Int32 curProcessContentIndex; // 0x3e8
	System.Int64 panelUpdateTimerId; // 0x3f0
	System.Boolean hasSelfData; // 0x3f8
	System.Int32 selfRank; // 0x3fc
	System.Void OnInit(); // 0x055049cc
	System.Void OnClickCloseBtn(); // 0x05d33ae4
	System.Void OnPanelUpdate(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x05d33b50
	System.Void OnDisable(); // 0x05d33be4
	System.Void UpdatePanel(); // 0x05d33928
	System.Void ProcessDataByPerson(); // 0x05d33cf0
	System.Void OnUserInfoBack(SimpleJSON.JSONArray jsonArray); // 0x05d33fe4
	System.Void ShowPanel(); // 0x05d34ac8
	System.Void PersonalListRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05d34ebc
	System.Void OnClickReportBtn(System.String name, System.Int64 roleId); // 0x05d356b4
	System.Void ContentItemLabelRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05d357dc
	System.Void ContentItemLabelSelfRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05d35974
	System.Void HeaderLabelRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05d35adc
	System.Void .ctor(); // 0x05d35c80
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBombHomeStatisticPersonal.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiBombHomeStatisticPersonal.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo> <>9__28_0; // 0x8
	static System.Void .cctor(); // 0x05d35d60
	System.Void .ctor(); // 0x05d35dc4
	System.Int32 <OnUserInfoBack>b__28_0(WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo a, WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo b); // 0x05d35e2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBombHomeStatisticPersonal.<>c__DisplayClass30_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiBombHomeStatisticPersonal <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo info; // 0x18
	System.Void .ctor(); // 0x05d3564c
	System.Void <PersonalListRenderer>b__0(FairyGUI.EventContext ctx); // 0x05d35ee4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBombHomeStatistics : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GList attackLst; // 0x338
	FairyGUI.GList defendLst; // 0x340
	FairyGUI.GTextField attackNumTxt; // 0x348
	FairyGUI.GTextField defendNumTxt; // 0x350
	FairyGUI.GButton closeBtn; // 0x358
	FairyGUI.GButton exitBtn; // 0x360
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.BombHomeAttackStatisticsItemData> attackMemberLst; // 0x368
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.BombHomeDefendStatisticsItemData> defendMemberLst; // 0x370
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,FairyGUI.GObject>> attackItemDic; // 0x378
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,FairyGUI.GObject>> defendItemDic; // 0x380
	System.Void OnInit(); // 0x05d35f6c
	System.Void OnDestroy(); // 0x05d3644c
	System.Void RefreshPlayMemberInfo(); // 0x05d363ec
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05d36684
	System.Void OnClickExit(); // 0x05d3676c
	static System.Void OpenWindow(); // 0x05d36830
	static System.Void CloseWindow(); // 0x05d366f8
	static WizardGames.Soc.SocClient.Ui.UiBombHomeStatistics GetWindow(); // 0x05d36900
	System.Void OnRenderAttackMemItem(System.Int32 index, FairyGUI.GObject obj); // 0x05d369c0
	System.Void OnRenderDefendMemItem(System.Int32 index, FairyGUI.GObject obj); // 0x05d37184
	System.Void .ctor(); // 0x05d3794c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.BombHomeAttackStatisticsItemData : System.Object
{
	System.String <name>k__BackingField; // 0x10
	System.String <portrait>k__BackingField; // 0x18
	System.Int32 <kill>k__BackingField; // 0x20
	System.Int32 <destroyBuildingCount>k__BackingField; // 0x24
	System.Int32 <death>k__BackingField; // 0x28
	System.Int32 <damagePlayer>k__BackingField; // 0x2c
	System.Int32 <damagePart>k__BackingField; // 0x30
	System.UInt64 <RoleId>k__BackingField; // 0x38
	System.String get_name(); // 0x05d37af8
	System.String get_portrait(); // 0x05d37b5c
	System.Int32 get_kill(); // 0x05d37bc0
	System.Int32 get_destroyBuildingCount(); // 0x05d37c24
	System.Int32 get_death(); // 0x05d37c88
	System.Int32 get_damagePlayer(); // 0x05d37cec
	System.Int32 get_damagePart(); // 0x05d37d50
	System.UInt64 get_RoleId(); // 0x05d37db4
	System.Void .ctor(); // 0x05d37e18
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.BombHomeDefendStatisticsItemData : System.Object
{
	System.String name; // 0x10
	System.String <portrait>k__BackingField; // 0x18
	System.Int32 <kill>k__BackingField; // 0x20
	System.Int32 <assist>k__BackingField; // 0x24
	System.Int32 <death>k__BackingField; // 0x28
	System.Int32 <damagePlayer>k__BackingField; // 0x2c
	System.Int32 <damagePart>k__BackingField; // 0x30
	System.UInt64 <RoleId>k__BackingField; // 0x38
	System.String get_portrait(); // 0x05d37e80
	System.Int32 get_kill(); // 0x05d37ee4
	System.Int32 get_assist(); // 0x05d37f48
	System.Int32 get_death(); // 0x05d37fac
	System.Int32 get_damagePlayer(); // 0x05d38010
	System.Int32 get_damagePart(); // 0x05d38074
	System.UInt64 get_RoleId(); // 0x05d380d8
	System.Void .ctor(); // 0x05d3813c
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo : System.ValueType
{
	System.String Name; // 0x10
	System.Boolean IsSelf; // 0x18
	System.Int64 RoleId; // 0x20
	System.Int32 Level; // 0x28
	System.String Portrait; // 0x30
	System.Int32 FrameId; // 0x38
	System.Int64 Ranking; // 0x40
	System.Collections.Generic.List<System.Int64> DynamicFields; // 0x48
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBombHomeStatisticsB2 : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.Controller modeController; // 0x338
	FairyGUI.Controller statusController; // 0x340
	FairyGUI.Controller bgController; // 0x348
	FairyGUI.GComponent personalContent; // 0x350
	FairyGUI.GList teamPointsList; // 0x358
	FairyGUI.GList teamNoPointsList; // 0x360
	FairyGUI.GTextField statusText; // 0x368
	FairyGUI.GButton btnBottom; // 0x370
	FairyGUI.GTextField btnBottomText; // 0x378
	FairyGUI.GTextField victoryText; // 0x380
	FairyGUI.GTextField failureText; // 0x388
	System.Int64 graphEntityId; // 0x390
	WizardGames.Soc.Common.SimpleCustom.InitStatPanelDataCfg panelConfig; // 0x398
	System.Int64 curProcessTeamId; // 0x3a0
	System.Int32 curProcessContentIndex; // 0x3a8
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo>> dataByTeam; // 0x3b0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo> dataByPerson; // 0x3b8
	WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo selfData; // 0x3c0
	System.Boolean hasSelfData; // 0x400
	System.Int32 selfRank; // 0x404
	System.Int64 panelOpenTime; // 0x408
	System.Int64 settlementUpdateTimerId; // 0x410
	System.Int64 panelUpdateTimerId; // 0x418
	System.Boolean isSettleMode; // 0x420
	static SocLogger logger; // 0x0
	System.Void OnInit(); // 0x055049cc
	System.Void OnClickCloseBtn(); // 0x05d38bb8
	System.Void OnClickReturnToLobby(); // 0x05d38c88
	System.Void OnPanelUpdate(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x05d38d40
	System.Void OnDisable(); // 0x05d38df0
	System.Void UpdatePanel(); // 0x05d389cc
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05d39574
	System.Void ProcessDataByTeam(); // 0x05d39280
	System.Void OnTeamUserInfoBack(SimpleJSON.JSONArray jsonArray); // 0x05d3960c
	System.Void ProcessDataByPerson(); // 0x05d38f8c
	System.Void OnPersonUserInfoBack(SimpleJSON.JSONArray jsonArray); // 0x05d3a580
	System.Void ShowInTeamNoPointsMode(); // 0x05d3a290
	System.Void ShowInTeamPointsMode(); // 0x05d3a408
	System.Void TeamListRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05d3b698
	System.Void ShowInPersonalMode(); // 0x05d3b05c
	System.Void HeaderLabelRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05d3c0d4
	System.Void ContentItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05d3c278
	System.Void ContentItemLabelRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05d3c81c
	System.Void ContentItemLabelSelfRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05d3c9c0
	System.Void SetHeaderTeamNoPoints(FairyGUI.GComponent header); // 0x05d3bda4
	System.Void SetHeaderTeamPointsMode(FairyGUI.GComponent header); // 0x05d3beb4
	System.Void SetHeaderPersonalMode(FairyGUI.GComponent header); // 0x05d3bfc4
	System.Void .ctor(); // 0x05d3cae8
	static System.Void .cctor(); // 0x05d3cc18
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBombHomeStatisticsB2.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiBombHomeStatisticsB2.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo> <>9__37_0; // 0x8
	static System.Comparison<WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo> <>9__39_0; // 0x10
	static System.Void .cctor(); // 0x05d3ccec
	System.Void .ctor(); // 0x05d3cd50
	System.Int32 <OnTeamUserInfoBack>b__37_0(WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo a, WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo b); // 0x05d3cdb8
	System.Int32 <OnPersonUserInfoBack>b__39_0(WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo a, WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo b); // 0x05d3ce70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBombHomeStatisticTeam : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GTextField statusText; // 0x338
	FairyGUI.GButton btnBottom; // 0x340
	FairyGUI.GButton btnClose; // 0x348
	FairyGUI.GTextField defensePointsText; // 0x350
	FairyGUI.GTextField attackPointsText; // 0x358
	FairyGUI.GTextField defenseTeamText; // 0x360
	FairyGUI.GTextField attackTeamText; // 0x368
	FairyGUI.GList defensePlayerList; // 0x370
	FairyGUI.GList attackPlayerList; // 0x378
	FairyGUI.GList headerLabelList; // 0x380
	FairyGUI.Controller attackTeamScoreController; // 0x388
	FairyGUI.Controller defenseTeamScoreController; // 0x390
	System.Int64 graphEntityId; // 0x398
	WizardGames.Soc.Common.SimpleCustom.InitStatPanelDataCfg panelConfig; // 0x3a0
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo>> dataByTeam; // 0x3a8
	System.Int64 panelOpenTime; // 0x3b0
	System.Int64 curProcessTeamId; // 0x3b8
	System.Int32 curProcessContentIndex; // 0x3c0
	System.Int64 panelUpdateTimerId; // 0x3c8
	System.Void OnInit(); // 0x055049cc
	System.Void OnClickCloseBtn(); // 0x05d3d894
	System.Void OnPanelUpdate(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x05d3d900
	System.Void OnDisable(); // 0x05d3d994
	System.Void UpdatePanel(); // 0x05d3d6d8
	System.Void ProcessDataByTeam(); // 0x05d3daa0
	System.Void OnUserInfoBack(SimpleJSON.JSONArray jsonArray); // 0x05d3dd94
	System.Void ShowPanel(); // 0x05d3e848
	System.Void TeamListRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05d3ee20
	System.Void OnClickReportBtn(System.String name, System.Int64 roleId); // 0x05d3f650
	System.Void ContentItemLabelRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05d3f778
	System.Void HeaderLabelRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05d3f934
	System.Void .ctor(); // 0x05d3fad8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBombHomeStatisticTeam.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiBombHomeStatisticTeam.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo> <>9__28_0; // 0x8
	static System.Void .cctor(); // 0x05d3fbb8
	System.Void .ctor(); // 0x05d3fc1c
	System.Int32 <OnUserInfoBack>b__28_0(WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo a, WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo b); // 0x05d3fc84
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBombHomeStatisticTeam.<>c__DisplayClass30_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiBombHomeStatisticTeam <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.MemberStatisticsInfo info; // 0x18
	System.Void .ctor(); // 0x05d3f5e8
	System.Void <TeamListRenderer>b__0(FairyGUI.EventContext ctx); // 0x05d3fd3c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBombHomeStatus : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	System.Int64 graphEntityId; // 0x338
	System.Boolean isCountDown; // 0x340
	System.Int64 targetIds; // 0x348
	System.Int64 countDownStartTsSec; // 0x350
	System.Int64 countDownSecond; // 0x358
	WizardGames.Soc.Common.SimpleCustom.EProgressBarType progressBarType; // 0x360
	FairyGUI.GList statusList; // 0x368
	FairyGUI.GComponent line; // 0x370
	FairyGUI.GTextField timeText; // 0x378
	FairyGUI.GTextField residentTargetText; // 0x380
	FairyGUI.GTextField tempStateText; // 0x388
	FairyGUI.Controller tempStateController; // 0x390
	FairyGUI.Controller countdownController; // 0x398
	System.Int64 timerId; // 0x3a0
	System.Int64 timeDuration; // 0x3a8
	System.Int64 timeStartTime; // 0x3b0
	System.Boolean targetInited; // 0x3b8
	static System.Void TryOpenWindow(System.Int64 graphEntityId, System.Boolean isCountDown, System.Int64 targetIds, System.Int64 countDownStartTsSec, System.Int64 countDownSecond, WizardGames.Soc.Common.SimpleCustom.EProgressBarType progressType); // 0x05d3fdc4
	System.Void OnInit(); // 0x05d40110
	System.Void OnDestroy(); // 0x05d40708
	System.Void InitData(System.Int64 graphEntityId, System.Boolean isCountDown, System.Int64 targetIds, System.Int64 countDownStartTsSec, System.Int64 countDownSecond, WizardGames.Soc.Common.SimpleCustom.EProgressBarType type); // 0x05d3ff50
	System.Void OnHotKey(); // 0x055049cc
	System.Void ShowTimeTitle(System.Int64 duration, System.Int64 startTime); // 0x05511848
	System.Void UpdateTime(System.Int64 timeId, System.Object callbackData, System.Boolean needDelete); // 0x05d40e7c
	System.Void OnClickStatus(); // 0x055049cc
	System.Void OnDisable(); // 0x05d412d0
	System.Void OnTargetIdsChange(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.Int64 a, WizardGames.Soc.Share.Framework.TypeBase b); // 0x05d413e0
	System.Void UpdateTargetStatus(); // 0x05d40a94
	System.Void StatusListRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05d41474
	System.Void ShowResidentTargetTip(WizardGames.Soc.Common.CustomType.MultiLangStringBuilder text); // 0x05d417b4
	System.Void HideResidentTargetTip(); // 0x05d418b8
	System.Void ShowTempStateTip(WizardGames.Soc.Common.CustomType.MultiLangStringBuilder text); // 0x05d4192c
	System.Void HideTempStateTip(); // 0x05d41a30
	System.Void .ctor(); // 0x05d41aa4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBubbleMsg : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GRichTextField contentText; // 0x338
	System.Void OnInit(); // 0x05d41b30
	System.Void .ctor(); // 0x05d41cb8
	System.Void <OnInit>b__1_0(); // 0x05d41d44
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBuzzOperation : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.UiBuzzOperationBinder content; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.MissionData> missionsList; // 0x18
	System.Collections.Generic.List<System.Int32> levelPoints; // 0x20
	System.Int32 maxPoints; // 0x28
	System.Collections.Generic.List<FairyGUI.GImage> lines; // 0x30
	System.Collections.Generic.List<FairyGUI.GLabel> lvTexts; // 0x38
	System.Collections.Generic.IList<System.Int64> inProgressIds; // 0x40
	System.Collections.Generic.IList<System.Int64> completedAndNotGetRewardIds; // 0x48
	System.Collections.Generic.IList<System.Int64> completedIds; // 0x50
	System.Collections.Generic.List<System.Int64> playerIdList; // 0x58
	System.Collections.Generic.HashSet<System.Int64> playerIds; // 0x60
	System.Boolean isQueryPlayerName; // 0x68
	System.Collections.Generic.Dictionary<System.Int64,System.String> playerNames; // 0x70
	FairyGUI.GTweener gTweener; // 0x78
	FairyGUI.GTweenCallback1 UpdatePorgressCallback; // 0x80
	WizardGames.Soc.SocClient.Ui.UiItemChoose _uiItemChoose; // 0x88
	WizardGames.Soc.SocClient.Ui.ItemChooseData _currentData; // 0x90
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.BeeBuzzLevel> _rewards; // 0x98
	System.Int32 _currentSelected; // 0xa0
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.UiBuzzOperationBinder binder); // 0x05d41db0
	System.Void LoadRewards(); // 0x05d42870
	System.Void RefreshRedDot(); // 0x05d44914
	System.Void OnDestory(); // 0x05d451dc
	System.Boolean HasTeam(); // 0x05d4546c
	WizardGames.Soc.Common.Component.BeeBuzzComponent GetBeeBuzzComponent(); // 0x05d45508
	System.Void OnTeamDataChange(WizardGames.Soc.Share.Framework.ECustomDictOpType changeType, System.UInt64 roleId, WizardGames.Soc.Common.CustomType.TeamMemberInfo oldMember); // 0x05d45608
	System.Void OnBeeBuzzTaskChange(); // 0x05d4586c
	System.Void DoTweenShowPorgress(System.Int32 startValue, System.Int32 endValue); // 0x05d458e0
	System.Void OnBeeBuzzDataChange(System.Int32 id, System.Int32 oldValue, System.Int32 newValue); // 0x05d45ad4
	System.Void OnGetMultiPlayerNames(System.Collections.Generic.Dictionary<System.Int64,System.String> playerNames); // 0x05d45ce4
	System.Void PopRiskRecord(); // 0x05d45ed4
	System.Void InitUIText(); // 0x05d4306c
	System.String GetText(System.Int32 configId); // 0x05d44bac
	System.Void RefreshBtnState(); // 0x05d447d0
	System.Void InitProgressUI(); // 0x05d43380
	System.Void RefreshProgress(); // 0x05d45c4c
	System.Void SetProgressValue(System.Single percent); // 0x05d4663c
	System.Void SetPoint(System.Int32 point); // 0x05d46774
	System.Void SetLvStatus(System.Int32 pointValue); // 0x05d468dc
	System.Int32 GetPointValue(); // 0x05d45160
	System.Void LoadAllMissions(); // 0x05d42590
	WizardGames.Soc.SocClient.Ui.EMissionStatus GetMissionStatus(System.Int32 missionId); // 0x05d46be4
	System.Void RefreshTaskData(); // 0x05d47190
	System.Void GetTaskByType(System.Collections.Generic.IList<System.Int64> res, System.Int64 index); // 0x05d475c0
	System.Void RefreshMissions(); // 0x05d446f4
	System.Void RenderTaskItem(System.Int32 index, FairyGUI.GObject obj); // 0x05d47948
	static System.String GetActionPointUrl(); // 0x05d44ec0
	System.Void OnBtnRiskRecordClick(); // 0x05d483f4
	System.String GetResetTime(); // 0x05d44ce0
	System.Void OnBtnExchangeClick(); // 0x05d488ec
	System.Void RefreshExchangeUI(); // 0x05d456a4
	System.Void RefreshCancelBtnCallback(FairyGUI.GButton obj); // 0x05d48d4c
	System.Void RefreshConfirmBtnCallback(FairyGUI.GButton obj); // 0x05d48dc0
	System.Void RefreshConfirmBtnState(WizardGames.Soc.SocClient.Ui.ComBtnKeyTipsAction btnConfirm); // 0x05d48e84
	System.Void OnConfirmClickCallback(System.Int32 index); // 0x05d491c8
	System.Void OnClaimMissionClick(System.Int32 missionId); // 0x05d4972c
	System.Void OnGoMissionClick(System.Int32 missionId); // 0x05d49954
	System.Void .ctor(); // 0x05d49c14
	static System.Void .cctor(); // 0x05d49f20
	System.Void <OnInit>b__19_0(); // 0x05d49ff4
	System.Void <OnInit>b__19_1(); // 0x05d4a184
	System.Void <OnInit>b__19_2(FairyGUI.GTweener tweener); // 0x05d4a308
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBuzzOperation.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiBuzzOperation.<>c <>9; // 0x0
	static System.Action <>9__30_0; // 0x8
	static System.Void .cctor(); // 0x05d4a558
	System.Void .ctor(); // 0x05d4a5bc
	System.Void <PopRiskRecord>b__30_0(); // 0x05d4a624
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBuzzOperation.<>c__DisplayClass21_0 : System.Object
{
	System.Int32 pointValue; // 0x10
	System.Void .ctor(); // 0x05d44fd0
	System.Boolean <RefreshRedDot>b__0(WizardGames.Soc.SocClient.Ui.ItemChooseInfo item); // 0x05d4a684
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBuzzOperation.<>c__DisplayClass45_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiBuzzOperation <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.MissionData missionData; // 0x18
	System.Void .ctor(); // 0x05d4838c
	System.Void <RenderTaskItem>b__0(); // 0x05d4a720
	System.Void <RenderTaskItem>b__1(); // 0x05d4a790
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.MissionData : System.ValueType
{
	System.Int32 Id; // 0x10
	System.String Title; // 0x18
	System.Int32 Rewards; // 0x20
	WizardGames.Soc.SocClient.Ui.EMissionStatus Status; // 0x24
	System.Void .ctor(System.Int32 id, System.String title, System.Int32 rewards, WizardGames.Soc.SocClient.Ui.EMissionStatus status); // 0x05d46b34
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EMissionStatus : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EMissionStatus None = -1;
	static WizardGames.Soc.SocClient.Ui.EMissionStatus InProgress = 0;
	static WizardGames.Soc.SocClient.Ui.EMissionStatus Finished = 1;
	static WizardGames.Soc.SocClient.Ui.EMissionStatus Calimed = 2;
	static WizardGames.Soc.SocClient.Ui.EMissionStatus NotStart = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBuzzOperationExchange : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.UiBuzzOperationExchangeRootBinder rootBinder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x340
	System.Int32 currentSelected; // 0x348
	System.Int32 MSG_ID; // 0x34c
	System.Collections.Generic.List<System.Action> btnCallbacks; // 0x350
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.BeeBuzzLevel> rewards; // 0x358
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.UiBuzzOperationExchange.ToolTipsBinder> toolTipsBinders; // 0x360
	System.Void OnInit(); // 0x05d4a800
	System.Void RefreshBtnState(); // 0x05d4b574
	System.Void LoadRewards(); // 0x05d4b110
	WizardGames.Soc.Common.Data.Play.BeeBuzzLevel GetRewardsConfig(System.Int32 index); // 0x05d4bbd0
	System.Void OnTeamDataChange(WizardGames.Soc.Share.Framework.ECustomDictOpType changeType, System.UInt64 roleId, WizardGames.Soc.Common.CustomType.TeamMemberInfo oldMember); // 0x05d4bc9c
	System.Void OnBeeBuzzTaskChange(); // 0x05d4bd38
	System.Void OnUiOpenEvent(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05d4bda4
	System.Void SetDefaultSelected(); // 0x05d4b498
	System.Void OnShowAnimFinish(); // 0x05d4bea4
	System.Void SetPointValue(); // 0x05d4b380
	System.Int32 GetPointValue(); // 0x05d4bb58
	System.Void InitUIText(); // 0x05d4af3c
	System.String GetResetTime(); // 0x05d4c2d8
	System.String GetText(System.Int32 configId); // 0x05d4c1a4
	System.Void OnExchangeItemClick(FairyGUI.EventContext context); // 0x05d4c4b8
	System.Void RenderExchangeItem(System.Int32 index, FairyGUI.GObject obj); // 0x05d4c7d4
	System.Void OnCloseClick(); // 0x05d4cf00
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05d4cf6c
	System.Void OnBtnExchangeClick(); // 0x05d4cff0
	System.Void .ctor(); // 0x05d4d3c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBuzzOperationExchange.ToolTipsBinder : System.Object, WizardGames.Soc.SocClient.Ui.Utils.IToolTips
{
	FairyGUI.GComponent Target; // 0x10
	FairyGUI.GComponent Item; // 0x18
	WizardGames.Soc.Common.Data.DataItem.ItemConfig ItemConfig; // 0x20
	System.Int32 Index; // 0x28
	System.Void .ctor(FairyGUI.GComponent target); // 0x05d4d604
	System.Void ShowTips(FairyGUI.EventContext context); // 0x05d4d690
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBuzzOperationExchange.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiBuzzOperationExchange.<>c <>9; // 0x0
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.UiBuzzOperationExchange.ToolTipsBinder> <>9__27_0; // 0x8
	static System.Void .cctor(); // 0x05d4d7b4
	System.Void .ctor(); // 0x05d4d818
	WizardGames.Soc.SocClient.Ui.UiBuzzOperationExchange.ToolTipsBinder <.ctor>b__27_0(FairyGUI.GComponent c); // 0x05d4d880
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBuzzUtil : System.Object
{
	
	static WizardGames.Soc.Common.Data.MarkerType POIEventId2MarkeType(System.Int32 poiRuleId); // 0x05d46f90
	static System.Boolean HasTeam(); // 0x05d450cc
	static System.Boolean IsCaptain(); // 0x05d45038
	static WizardGames.Soc.Common.Component.BeeBuzzComponent GetSelfBuzzComponent(); // 0x05d49680
	static WizardGames.Soc.Common.Component.BeeBuzzComponent GetTeamBuzzComponent(); // 0x05d4d920
	static System.Int64 GetExchangedCardId(); // 0x05d44f30
	static WizardGames.Soc.Common.Component.BeeBuzzComponent GetBeeBuzzComponent(); // 0x05d4c0b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCampingTentCountdown : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GComponent comRoot; // 0x338
	WizardGames.Soc.SocClient.Ui.ComCountdown comCountdown; // 0x340
	System.Void OnInit(); // 0x05d4da04
	System.Void OnEnable(); // 0x05d4dccc
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05d4e124
	System.Void CancelCampintTent(); // 0x05d4e1a8
	System.Void OnDisable(); // 0x05d4e258
	System.Void SyncCountdownStateWithHud(); // 0x05d4df80
	System.Void OnCountdownFinish(); // 0x05d4e390
	System.Void HandleAppPush(); // 0x05d4e430
	System.Void OnDeployCampingTentResult(System.Boolean success); // 0x05d4e934
	System.Void OnCampingTentLogoutSuccess(); // 0x05d4eb44
	System.Void OnEnable_Platform(); // 0x05d4dedc
	System.Void OnDisable_Platform(); // 0x05d4e2ec
	System.Void .ctor(); // 0x05d4ec9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCampingTentCountdown.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiCampingTentCountdown.<>c <>9; // 0x0
	static System.Action <>9__10_0; // 0x8
	static System.Action <>9__11_0; // 0x10
	static System.Void .cctor(); // 0x05d4ed28
	System.Void .ctor(); // 0x05d4ed8c
	System.Void <OnDeployCampingTentResult>b__10_0(); // 0x05d4edf4
	System.Void <OnCampingTentLogoutSuccess>b__11_0(); // 0x05d4ee94
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCartoon : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.GameCartoon.UiCartoonBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComVideo videoPlayer; // 0x340
	System.String audioName; // 0x348
	System.Int64 delayShowCloseBtnTimerID; // 0x350
	System.Void OnInit(); // 0x05d4ef3c
	System.Void OnEnable(); // 0x05d4f3bc
	System.Void OnDisable(); // 0x05d4fb80
	System.Void OnDestroy(); // 0x05d4fdd4
	System.Void MakeFullScreen(); // 0x05d4fe54
	System.Void PlayVideo(); // 0x05d4f794
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05d5003c
	static WizardGames.Soc.SocClient.Ui.UiCartoon OpenWindow(System.Action<WizardGames.Soc.SocClient.Ui.UiCartoon> cb); // 0x05d50268
	static System.Void CloseWindow(); // 0x05d4ff28
	static WizardGames.Soc.SocClient.Ui.UiCartoon GetWindow(); // 0x05d50394
	System.Void .ctor(); // 0x05d50454
	System.Void <OnInit>b__4_0(); // 0x05d5050c
	System.Void <OnEnable>b__5_0(System.Int64 id, System.Object data, System.Boolean delete); // 0x05d50580
	System.Void <PlayVideo>b__9_0(UnityEngine.Video.VideoPlayer player); // 0x05d506f0
	System.Void <PlayVideo>b__9_2(System.Object param); // 0x05d507d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCartoon.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiCartoon.<>c <>9; // 0x0
	static System.Action<UnityEngine.Video.VideoPlayer> <>9__9_1; // 0x8
	static System.Void .cctor(); // 0x05d508c8
	System.Void .ctor(); // 0x05d5092c
	System.Void <PlayVideo>b__9_1(UnityEngine.Video.VideoPlayer player); // 0x05d50994
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatCategoryItem : FairyGUI.GButton
{
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.BtnCategoryBinder binder; // 0x318
	WizardGames.Soc.SocClient.Ui.ComRedDot redDot; // 0x320
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05d50a08
	System.Void Draw(System.Int32 redCount, System.Int32 chanel); // 0x05d50bd8
	System.Void .ctor(); // 0x05d50d10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatChannelItem : FairyGUI.GButton
{
	System.Boolean successConstructed; // 0x311
	FairyGUI.Controller channelTypeCtrl; // 0x318
	WizardGames.Soc.SocClient.Ui.ComNameMedal channelName; // 0x320
	FairyGUI.GRichTextField lastChat; // 0x328
	FairyGUI.Controller redPointController; // 0x330
	WizardGames.Soc.SocClient.Ui.ComRedDot redDot; // 0x338
	WizardGames.Soc.SocClient.Ui.ComAvatarSquare avatar; // 0x340
	System.String channelId; // 0x348
	System.String strNoMsg; // 0x350
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.BtnChannelBinder binder; // 0x358
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05d50d78
	System.Void Draw(System.String cId, System.String selectedChannel, System.Action onUpdRolesInfo); // 0x05d513a8
	System.Void SetChannelRedPointState(WizardGames.Soc.SocClient.IClientChatRoom room, System.String selectedChannel); // 0x05d51828
	System.Void .ctor(); // 0x05d51cf0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatInput : FairyGUI.GComponent
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComChatInputBinder binder; // 0x288
	WizardGames.Soc.SocClient.IClientChatRoom chatRoom; // 0x290
	WizardGames.Soc.SocClient.Ui.UiChatMain uiChatMain; // 0x298
	WizardGames.Soc.SocClient.Ui.UiChatVoice chatVoice; // 0x2a0
	WizardGames.Soc.SocClient.Ui.UiChatEmoji chatEmoji; // 0x2a8
	FairyGUI.GLabel txtSendCd; // 0x2b0
	FairyGUI.Controller sendBtnTipsController; // 0x2b8
	System.Action<System.Boolean> showEmojiAction; // 0x2c0
	System.Collections.Generic.Dictionary<System.String,System.String> inputMessageCache; // 0x2c8
	System.Single cdtimeLeft; // 0x2d0
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05d523b0
	System.Void SendChatEmojiMessage(System.String obj); // 0x05523a54
	System.Void AddEmojiInput(System.String obj); // 0x05d54de0
	System.Void HideChatVoice(); // 0x05d55134
	System.Void OnAppointmentTeamClick(FairyGUI.EventContext context); // 0x05d552d8
	System.Void OnLobbyTeamClick(FairyGUI.EventContext context); // 0x05d55a6c
	System.Void OnGameTeamClick(FairyGUI.EventContext context); // 0x05d55edc
	System.Void ShareGameTeamToChatRoom(); // 0x05d55fe8
	System.Void Update(); // 0x05d56604
	System.Void SetInputMessage(System.String str); // 0x05d534f0
	System.Void BindCategory(WizardGames.Soc.SocClient.EChatCategory chatCategory); // 0x05d57d28
	System.Void BindChannel(WizardGames.Soc.SocClient.IClientChatRoom room); // 0x05d57f0c
	System.Void ToggleCreateTeamPanel(); // 0x05d5571c
	System.Void SendChatVoiceMessage(System.String message); // 0x05523a54
	System.Void SendMessage(); // 0x055049cc
	System.Void MessageInCD(); // 0x05d54cd0
	System.Void OnDisable(); // 0x05d59848
	System.Void OnEnable(); // 0x05d598ac
	System.Void RefreshChatCd(System.Single timeLeft); // 0x05d57b60
	System.Boolean CanEditInput(); // 0x05d59f4c
	System.Void .ctor(); // 0x05d5a064
	static System.Void .cctor(); // 0x05d5a118
	System.Void <ConstructFromXML>b__10_0(); // 0x05d5a1ec
	System.Void <ConstructFromXML>b__10_1(); // 0x05d5a2fc
	System.Void <ConstructFromXML>b__10_2(); // 0x05d5a434
	System.Void <ConstructFromXML>b__10_3(); // 0x05d5a6cc
	System.Void <OnLobbyTeamClick>b__15_0(); // 0x05d5a7f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatInput.<>c__DisplayClass14_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComChatInput <>4__this; // 0x10
	WizardGames.Soc.SocClient.Manager.LobbyTeamData teamData; // 0x18
	System.Void .ctor(); // 0x05d556b4
	System.Void <OnAppointmentTeamClick>b__0(SimpleJSON.JSONArray jsonArrayInfo); // 0x05d5abc0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatInput.<>c__DisplayClass15_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.LobbyTeamData teamData; // 0x10
	WizardGames.Soc.SocClient.Ui.ComChatInput <>4__this; // 0x18
	System.Void .ctor(); // 0x05d55e74
	System.Void <OnLobbyTeamClick>b__1(SimpleJSON.JSONArray jsonArrayInfo); // 0x05d5afe8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatInput.<>c__DisplayClass15_1 : System.Object
{
	WizardGames.Soc.SocClient.Manager.LobbyTeamData teamData; // 0x10
	WizardGames.Soc.SocClient.Ui.ComChatInput <>4__this; // 0x18
	System.Void .ctor(); // 0x05d5ab58
	System.Void <OnLobbyTeamClick>b__2(SimpleJSON.JSONArray jsonArrayInfo); // 0x05d5b3f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatInput.<>c__DisplayClass17_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComChatInput <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.ERecruitType recruitType; // 0x18
	System.Void .ctor(); // 0x05d5659c
	System.Void <ShareGameTeamToChatRoom>b__0(SimpleJSON.JSONArray jsonArrayInfo); // 0x05d5b808
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Ui.IComChat : 
{
	
	System.Void Draw(WizardGames.Soc.SocClient.ClientChatMessage nowMessage, WizardGames.Soc.SocClient.ClientChatMessage preMessage, WizardGames.Soc.SocClient.Ui.UiChatMain uiChatMain); // 0x0552d210
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatMainMessage : FairyGUI.GComponent, WizardGames.Soc.SocClient.Ui.IComChat
{
	System.Boolean successConstructed; // 0x288
	WizardGames.Soc.SocClient.Ui.ComChatHead headLeft; // 0x290
	WizardGames.Soc.SocClient.Ui.ComChatHead headRight; // 0x298
	WizardGames.Soc.SocClient.Ui.ComChatTime time; // 0x2a0
	WizardGames.Soc.SocClient.Ui.ComNameMedal leftName; // 0x2a8
	WizardGames.Soc.SocClient.Ui.ComNameMedal rightName; // 0x2b0
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ChatMainMessageBinder binder; // 0x2b8
	System.String defaultSelfMsgBgUrlLeft; // 0x2c0
	System.String defaultOtherMsgBgUrlLeft; // 0x2c8
	WizardGames.Soc.SocClient.ClientChatMessage curMessage; // 0x2d0
	SimpleJSON.JSONNode curJSONContent; // 0x2d8
	WizardGames.Soc.SocClient.Ui.UiChatMain uiChatMain; // 0x2e0
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05d5bc28
	System.Void Draw(WizardGames.Soc.SocClient.ClientChatMessage nowMessage, WizardGames.Soc.SocClient.ClientChatMessage preMessage, WizardGames.Soc.SocClient.Ui.UiChatMain uiChatMain); // 0x05d5c66c
	System.String MakeEmoji(System.String viewMsg); // 0x05d5df2c
	System.Void ResolveShareMessageData(WizardGames.Soc.SocClient.ClientChatMessage message, WizardGames.Soc.SocClient.ClientChatMessage preMessage, WizardGames.Soc.SocClient.Ui.UiChatMain uiChatMain); // 0x05d60dbc
	System.Void ResolveEmojiMessageData(WizardGames.Soc.SocClient.ClientChatMessage message); // 0x05d5ff3c
	System.Void ResolveTribeAnnouncementMessageData(WizardGames.Soc.SocClient.ClientChatMessage message, System.String content); // 0x05d60588
	System.Void ResolveTribeLamp(WizardGames.Soc.SocClient.ClientChatMessage message, System.Boolean isTribeChannel, WizardGames.Soc.SocClient.RoleInfo roleInfo); // 0x05d60958
	System.Void ResolveVoiceMessageData(WizardGames.Soc.SocClient.ClientChatMessage message); // 0x05d5e2bc
	System.Void ResolveTeamData(WizardGames.Soc.SocClient.ClientChatMessage message); // 0x05d5e9ac
	System.Void OnTeamRecruitItemClick(FairyGUI.EventContext context); // 0x05d61124
	System.Void TeamAvatarListRenderFunc(System.Int32 index, FairyGUI.GObject item); // 0x05d61d6c
	System.Void SetReputationLevel(WizardGames.Soc.SocClient.RoleInfo role, System.Int32 level); // 0x05d5dc2c
	System.Void ResolveFriendGiftData(WizardGames.Soc.SocClient.ClientChatMessage message); // 0x05d5f49c
	System.Void .ctor(); // 0x05d622e4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatMainMessage.<>c__DisplayClass13_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiChatMain uiChatMain; // 0x10
	WizardGames.Soc.SocClient.ClientChatMessage nowMessage; // 0x18
	System.Void .ctor(); // 0x05d5d724
	System.Void <Draw>b__0(FairyGUI.EventContext ctx); // 0x05d624b0
	System.Void <Draw>b__1(FairyGUI.EventContext ctx); // 0x05d625b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatMainMessage.<>c__DisplayClass19_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComChatMainMessage <>4__this; // 0x10
	System.String recordFileId; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComConversionBinder voiceBinder; // 0x20
	System.Void .ctor(); // 0x05d610bc
	System.Void <ResolveVoiceMessageData>b__0(); // 0x05d62640
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatMainMessage.<>c__DisplayClass21_0 : System.Object
{
	SimpleJSON.JSONNode teamId; // 0x10
	System.Void .ctor(); // 0x05d61bcc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatMainMessage.<>c__DisplayClass21_1 : System.Object
{
	SimpleJSON.JSONObject param; // 0x10
	WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo; // 0x18
	WizardGames.Soc.SocClient.Ui.ComChatMainMessage.<>c__DisplayClass21_0 CS$<>8__locals1; // 0x20
	System.Action<System.Boolean> <>9__1; // 0x28
	System.Void .ctor(); // 0x05d61c34
	System.Void <OnTeamRecruitItemClick>b__0(System.String str, SimpleJSON.JSONArray tagArray); // 0x05d629a8
	System.Void <OnTeamRecruitItemClick>b__1(System.Boolean isSuccess); // 0x05d62b98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatMainMessage.<>c__DisplayClass21_2 : System.Object
{
	System.Int64 teamIdlong; // 0x10
	System.Void .ctor(); // 0x05d61c9c
	System.Void <OnTeamRecruitItemClick>b__2(System.String str, SimpleJSON.JSONArray tagArray); // 0x05d62cb4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatMainMessage.<>c__DisplayClass21_3 : System.Object
{
	WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo; // 0x10
	WizardGames.Soc.SocClient.Ui.ComChatMainMessage.<>c__DisplayClass21_0 CS$<>8__locals2; // 0x18
	System.Void .ctor(); // 0x05d61d04
	System.Void <OnTeamRecruitItemClick>b__3(System.Boolean isSuccess); // 0x05d62eb0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatMainMessage.<>c__DisplayClass23_0 : System.Object
{
	System.Boolean isPrivateChat; // 0x10
	System.Void .ctor(); // 0x05d62048
	System.Void <SetReputationLevel>g__deal|0(WizardGames.Soc.SocClient.Ui.UiChat chat); // 0x05d63084
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatMainMessage.<>c__DisplayClass24_0 : System.Object
{
	WizardGames.Soc.SocClient.ClientChatMessage message; // 0x10
	System.Void .ctor(); // 0x05d6227c
	System.Void <ResolveFriendGiftData>b__0(); // 0x05d63198
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatMainMessage.<>c__DisplayClass24_1 : System.Object
{
	LobbyFriend.FriendInfo selectedFriend; // 0x10
	System.Void .ctor(); // 0x05d63574
	System.Void <ResolveFriendGiftData>b__1(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05d635dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatTime : System.Object
{
	FairyGUI.Controller timeController; // 0x10
	FairyGUI.GTextField timeText; // 0x18
	System.Void Init(FairyGUI.GComponent com); // 0x05d5c494
	System.Void SetTimeText(WizardGames.Soc.SocClient.ClientChatMessage nowMessage, WizardGames.Soc.SocClient.ClientChatMessage preMessage); // 0x05d5d78c
	System.Void .ctor(); // 0x05d62448
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatHead : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComAvatarSquare com; // 0x10
	System.Void Init(FairyGUI.GComponent com); // 0x05d5c56c
	System.Void Draw(FairyGUI.GObject parentObj, System.UInt64 roleId, System.String avatarUrl, System.Int32 level, System.Int32 frameId, WizardGames.Soc.SocClient.ClientChatMessage nowMessage); // 0x05d5dd4c
	System.Void .ctor(); // 0x05d623e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatHead.<>c__DisplayClass2_0 : System.Object
{
	WizardGames.Soc.SocClient.ClientChatMessage nowMessage; // 0x10
	System.Void .ctor(); // 0x05d636b4
	System.Void <Draw>b__0(); // 0x05d6371c
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Ui.IComChatShare : 
{
	
	System.Void Render(WizardGames.Soc.SocClient.ClientChatMessage nowMessage, WizardGames.Soc.SocClient.ClientChatMessage preMessage, WizardGames.Soc.SocClient.Ui.UiChatMain uiChatMain); // 0x0552d210
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatShareBaseCard : System.Object, WizardGames.Soc.SocClient.Ui.IComChatShare
{
	SimpleJSON.JSONNode curJsonContent; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ChatMainMessageBinder binder; // 0x18
	WizardGames.Soc.Common.Data.system.ChatShareScene chatShareScene; // 0x20
	SocLogger logger; // 0x28
	System.Void Render(WizardGames.Soc.SocClient.ClientChatMessage nowMessage, WizardGames.Soc.SocClient.ClientChatMessage preMessage, WizardGames.Soc.SocClient.Ui.UiChatMain uiChatMain); // 0x05d637bc
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.GameChat.ChatMainMessageBinder binder); // 0x05d63a30
	System.String GetMessageContent(WizardGames.Soc.SocClient.ClientChatMessage message); // 0x05d63b4c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatShareNormalCard : WizardGames.Soc.SocClient.Ui.ComChatShareBaseCard
{
	
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.GameChat.ChatMainMessageBinder binder); // 0x05d63c88
	System.Void Render(WizardGames.Soc.SocClient.ClientChatMessage nowMessage, WizardGames.Soc.SocClient.ClientChatMessage preMessage, WizardGames.Soc.SocClient.Ui.UiChatMain uiChatMain); // 0x05d63d04
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatShareTextWithTitleCard : WizardGames.Soc.SocClient.Ui.ComChatShareBaseCard
{
	
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.GameChat.ChatMainMessageBinder binder); // 0x05d640a8
	System.Void Render(WizardGames.Soc.SocClient.ClientChatMessage nowMessage, WizardGames.Soc.SocClient.ClientChatMessage preMessage, WizardGames.Soc.SocClient.Ui.UiChatMain uiChatMain); // 0x05d64124
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatShareTextWithItemCard : WizardGames.Soc.SocClient.Ui.ComChatShareBaseCard
{
	
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.GameChat.ChatMainMessageBinder binder); // 0x05d64604
	System.Void Render(WizardGames.Soc.SocClient.ClientChatMessage nowMessage, WizardGames.Soc.SocClient.ClientChatMessage preMessage, WizardGames.Soc.SocClient.Ui.UiChatMain uiChatMain); // 0x05d64680
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatShareTextWithItemCard.<>c__DisplayClass1_0 : System.Object
{
	WizardGames.Soc.Common.Data.resource.OBJGenaral item; // 0x10
	WizardGames.Soc.SocClient.Ui.ComResIcon resIcon; // 0x18
	System.Void .ctor(); // 0x05d65118
	System.Void <Render>b__0(WizardGames.Soc.SocClient.Ui.ComBaseIcon resicon); // 0x05d65180
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatShareTextWithJumpCard : WizardGames.Soc.SocClient.Ui.ComChatShareBaseCard
{
	
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.GameChat.ChatMainMessageBinder binder); // 0x05d65298
	System.Void Render(WizardGames.Soc.SocClient.ClientChatMessage nowMessage, WizardGames.Soc.SocClient.ClientChatMessage preMessage, WizardGames.Soc.SocClient.Ui.UiChatMain uiChatMain); // 0x05d65314
	System.Void OpenBattleReport(System.Int32 reportId, System.String battleServerId); // 0x05d65ebc
	System.String GetMessageContent(WizardGames.Soc.SocClient.ClientChatMessage message); // 0x05d65ccc
	System.Void <Render>b__1_0(); // 0x05d661c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatShareTextWithJumpCard.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.ComChatShareTextWithJumpCard.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.Common.CustomType.PlunderReport> <>9__2_0; // 0x8
	static System.Void .cctor(); // 0x05d66278
	System.Void .ctor(); // 0x05d662dc
	System.Void <OpenBattleReport>b__2_0(WizardGames.Soc.Common.CustomType.PlunderReport report); // 0x05d66344
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatShareTextWithJumpCard.<>c__DisplayClass1_0 : System.Object
{
	System.Int32 reportId; // 0x10
	System.String battleServerId; // 0x18
	WizardGames.Soc.SocClient.Ui.ComChatShareTextWithJumpCard <>4__this; // 0x20
	System.Void .ctor(); // 0x05d65e54
	System.Void <Render>b__1(); // 0x05d66518
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatShareTextWithJumpCard.<>c__DisplayClass2_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComChatShareTextWithJumpCard <>4__this; // 0x10
	System.Int32 reportId; // 0x18
	System.String battleServerId; // 0x20
	System.Void .ctor(); // 0x05d66160
	System.Void <OpenBattleReport>b__1(); // 0x05d6658c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatShareTextWithJumpCard.<>c__DisplayClass2_1 : System.Object
{
	WizardGames.Soc.Common.CustomType.PlunderReport report; // 0x10
	System.Void .ctor(); // 0x05d664b0
	System.Void <OpenBattleReport>b__2(WizardGames.Soc.SocClient.Ui.UiBattleReport win); // 0x05d666d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatShareRecommendCard : WizardGames.Soc.SocClient.Ui.ComChatShareBaseCard
{
	
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.GameChat.ChatMainMessageBinder binder); // 0x05d66760
	System.Void Render(WizardGames.Soc.SocClient.ClientChatMessage nowMessage, WizardGames.Soc.SocClient.ClientChatMessage preMessage, WizardGames.Soc.SocClient.Ui.UiChatMain uiChatMain); // 0x05d667dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatShareRecommendCard.<>c__DisplayClass1_0 : System.Object
{
	WizardGames.Soc.SocClient.ClientChatMessage nowMessage; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComMessage_RecommendBinder recommendBinder; // 0x18
	System.String teamChangeEntrance; // 0x20
	System.Void .ctor(); // 0x05d672ec
	System.Void <Render>b__0(); // 0x05d67354
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatSystemBanMessage : FairyGUI.GComponent, WizardGames.Soc.SocClient.Ui.IComChat
{
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComSystemMessageBinder binder; // 0x288
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05d675a0
	System.Void Draw(WizardGames.Soc.SocClient.ClientChatMessage nowMessage, WizardGames.Soc.SocClient.ClientChatMessage preMessage, WizardGames.Soc.SocClient.Ui.UiChatMain uiChatMain); // 0x05d67670
	System.Void .ctor(); // 0x05d6778c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatSystemMessage : FairyGUI.GComponent, WizardGames.Soc.SocClient.Ui.IComChat
{
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComSystemMessageBinder binder; // 0x288
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05d677f4
	System.Void Draw(WizardGames.Soc.SocClient.ClientChatMessage nowMessage, WizardGames.Soc.SocClient.ClientChatMessage preMessage, WizardGames.Soc.SocClient.Ui.UiChatMain uiChatMain); // 0x05d678c4
	System.Void .ctor(); // 0x05d679e0
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EChatTribeGroupType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EChatTribeGroupType SYSTEM = 0;
	static WizardGames.Soc.SocClient.Ui.EChatTribeGroupType CREATED_BY_MYSELF = 1;
	static WizardGames.Soc.SocClient.Ui.EChatTribeGroupType CREATED_BY_OTHERS = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatTribeChannelGroup : FairyGUI.GComponent
{
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.BtnChannel_InterestGroupBinder binder; // 0x288
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeInfo> tribeInfos; // 0x290
	System.Action<WizardGames.Soc.SocClient.Ui.TribeInfo> itemClickCallback; // 0x298
	FairyGUI.GList get_ChannelList(); // 0x05d67a48
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05d67aec
	System.Void OnItemClick(FairyGUI.EventContext context); // 0x05d67e24
	System.Void OnExpandBtnClick(FairyGUI.EventContext context); // 0x05d68000
	System.Void OnItemRenderFunc(System.Int32 index, FairyGUI.GObject item); // 0x05d68174
	System.Void Draw(WizardGames.Soc.SocClient.Ui.EChatTribeGroupType groupType, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeInfo> tribeInfos, System.Action<WizardGames.Soc.SocClient.Ui.TribeInfo> itemClickCallback); // 0x05d68d08
	System.Void .ctor(); // 0x05d695ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComChatTribeChannelItem : FairyGUI.GButton
{
	System.String channelId; // 0x318
	System.String strNoMsg; // 0x320
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.BtnChannel_InterestGroupItemBinder binder; // 0x328
	WizardGames.Soc.SocClient.Ui.ComRedDot redDot; // 0x330
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05d69654
	System.Void Draw(WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo, System.Int32 redCount, System.Boolean isUnreadTeamRed); // 0x05d684ec
	System.Void .ctor(); // 0x05d69868
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChatEmoji : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComChatEmojiNewBinder binder; // 0x10
	System.Action<System.String> addEmoji; // 0x18
	System.Action<System.String> sendAction; // 0x20
	System.Int32 selectedTabIndex; // 0x28
	System.Collections.Generic.List<System.Int32> tabList; // 0x30
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.OBJEmoji>> tabDictionary; // 0x38
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComChatEmojiNewBinder binder, System.Action<System.String> addEmoji, System.Action<System.String> sendAction); // 0x05d543a8
	System.Void ShowEmoji(System.Int32 index); // 0x05d69938
	System.Void Init(); // 0x05d59cb4
	System.Void InitData(); // 0x05d69c58
	System.Void EmojiSmallItemRender(System.Int32 index, FairyGUI.GObject item); // 0x05d6a44c
	System.Void EmojiBigItemRender(System.Int32 index, FairyGUI.GObject item); // 0x05d6a5cc
	System.Void EmojiPackageItemRender(System.Int32 index, FairyGUI.GObject item); // 0x05d6a74c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChatEmoji.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiChatEmoji.<>c <>9; // 0x0
	static System.Comparison<System.Int32> <>9__11_0; // 0x8
	static System.Comparison<WizardGames.Soc.Common.Data.resource.OBJEmoji> <>9__11_1; // 0x10
	static System.Void .cctor(); // 0x05d6a8dc
	System.Void .ctor(); // 0x05d6a940
	System.Int32 <InitData>b__11_0(System.Int32 a, System.Int32 b); // 0x05d6a9a8
	System.Int32 <InitData>b__11_1(WizardGames.Soc.Common.Data.resource.OBJEmoji a, WizardGames.Soc.Common.Data.resource.OBJEmoji b); // 0x05d6ab34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChatEmoji.<>c__DisplayClass6_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComChatEmojiNewBinder binder; // 0x10
	WizardGames.Soc.SocClient.Ui.UiChatEmoji <>4__this; // 0x18
	System.Action<System.String> sendAction; // 0x20
	System.Action<System.String> addEmoji; // 0x28
	System.Void .ctor(); // 0x05d698d0
	System.Void <.ctor>b__0(FairyGUI.EventContext context); // 0x05d6abc8
	System.Void <.ctor>b__1(FairyGUI.EventContext context); // 0x05d6ad20
	System.Void <.ctor>b__2(FairyGUI.EventContext context); // 0x05d6af48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChatVoice : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComConvertBinder binder; // 0x10
	System.Boolean speaking; // 0x18
	System.Action closeAction; // 0x20
	System.Action<System.String> sendAction; // 0x28
	System.String recordFileId; // 0x30
	System.Single voiceTime; // 0x38
	System.Int64 timerId; // 0x40
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComConvertBinder binder, System.Action closeAction, System.Action<System.String> sendAction); // 0x05d5405c
	System.Void CancelVoice(); // 0x05d6b1d8
	System.Void ClearTimer(); // 0x05d6b25c
	System.Void Hide(); // 0x05d55274
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChatVoice.<>c__DisplayClass6_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiChatVoice <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComConvertBinder binder; // 0x18
	System.Action<System.String> sendAction; // 0x20
	System.Action closeAction; // 0x28
	WizardGames.Soc.SocClient.Voice.MgrVoice.UploadRecordFileCompleteHandler <>9__3; // 0x30
	WizardGames.Soc.SocClient.Voice.MgrVoice.UploadRecordFileCompleteHandler <>9__4; // 0x38
	System.Void .ctor(); // 0x05d6b170
	System.Void <.ctor>b__0(); // 0x05d6b364
	System.Void <.ctor>b__1(); // 0x05d6b3d0
	System.Void <.ctor>b__3(System.Boolean result, System.String fileid); // 0x05d6b568
	System.Void <.ctor>b__2(); // 0x05d6b5f8
	System.Void <.ctor>b__4(System.Boolean result, System.String fileid); // 0x05d6b708
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChat : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	WizardGames.Soc.SocClient.Ui.UiChatMain uiChatMain; // 0x338
	WizardGames.Soc.SocClient.Ui.ComChatInput chatInput; // 0x340
	FairyGUI.GComponent comChatMain; // 0x348
	WizardGames.Soc.SocClient.Ui.UiChatRecruit uiChatRecruit; // 0x350
	FairyGUI.GList chatChannelCategoryLst; // 0x358
	WizardGames.Soc.SocClient.EChatCategory selectedChannelCategory; // 0x360
	FairyGUI.GList chatChannelList; // 0x368
	FairyGUI.GList tribeChannelList; // 0x370
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.EChatTribeGroupType,System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeInfo>> tribeGroupData; // 0x378
	System.String selectedChannel; // 0x380
	System.String lastSelectedTribeChannel; // 0x388
	FairyGUI.GComponent comChatRecruit; // 0x390
	FairyGUI.GButton btnBackRecruit; // 0x398
	FairyGUI.Controller ctrlRecruitStatus; // 0x3a0
	System.Boolean isOpenRecruit; // 0x3a8
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.UiChatBinder uiChatBinder; // 0x3b0
	System.Boolean cacheKeyboardInput; // 0x3b8
	static System.String innerOpenChannelId; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.UiChat> InnerOpenWindow; // 0x8
	static System.Action<WizardGames.Soc.SocClient.Ui.UiChat> InnerRefreshChatMain; // 0x10
	System.Boolean isNeedRefreshLst; // 0x3b9
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x05d6b8d0
	System.Void OnInit(); // 0x05d6b950
	System.Void OnChatMaskClick(); // 0x05d6e2a4
	System.Void OnAddTribeGroupClick(FairyGUI.EventContext context); // 0x05d6e318
	System.Void OnDestroy(); // 0x05d6e3a0
	System.Void OnEnable(); // 0x05d6e81c
	System.Void OnDisable(); // 0x05d6ef2c
	System.Void OnTouchBegin(FairyGUI.EventContext context); // 0x05d6f3bc
	System.Void OnUiOpen(WizardGames.Soc.Common.Unity.Ui.WindowComBase com); // 0x05d6fc68
	System.Void OnHudBlockElemChange(WizardGames.Soc.SocClient.Ui.UiHudElem uiHudElem); // 0x05d6fd60
	System.Void OnHudRootCaptureTouchExcludeJoyStick(UnityEngine.Vector2 screen); // 0x05d6fde0
	System.Void OnHideByLayerStack(System.String coverUiName); // 0x05d6ff50
	System.Void OpenRecruit(); // 0x05d6ffd0
	static System.String get_ChatUiPath(); // 0x05d70088
	static System.Void GetWindowWithCallback(System.Boolean openIfNot, System.Action<WizardGames.Soc.SocClient.Ui.UiChat> callback, WizardGames.Soc.SocClient.Manager.EUiOpenTriggerType triggerType); // 0x05d620b0
	static System.Void OpenWindowAndJumpToTribeChannl(System.String tribeId); // 0x05d70150
	static System.Void OpenWindow(System.String channelId, WizardGames.Soc.SocClient.Manager.EUiOpenTriggerType triggerType); // 0x05d7029c
	static System.Void CloseWindow(); // 0x05d70364
	System.Void OnOpen(System.String channelId); // 0x05d70430
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05d70b2c
	System.Void OnChatChannelModify(); // 0x05d71b98
	System.Void OpenChannel(System.String channelId, System.Boolean autoSwitch); // 0x05d707d8
	System.Void ChangeCategorySelect(WizardGames.Soc.SocClient.EChatCategory channelCategory); // 0x05d6d9c0
	WizardGames.Soc.SocClient.EChatCategory GetSelectedChannelCategory(); // 0x05d71e74
	System.String GetSelectedChannelId(); // 0x05d71ed8
	System.Void RefreshLst(); // 0x05d71f3c
	System.Void RefreshTribeGroupData(System.Collections.Generic.List<System.String> allTribeChannels, System.String selectChannel, System.Int32& currentTribeGroup, System.Int32& currentTribeChannel); // 0x05d72928
	System.Void ChatChannelCategoryItemRendererFunc(System.Int32 index, FairyGUI.GObject obj); // 0x05d72e50
	System.Void ClickChannelCategory(FairyGUI.EventContext context); // 0x05d72f9c
	System.Void RefreshRecruitPanel(); // 0x05d6ec7c
	System.Void SendGameTeamShareInfo(); // 0x05d7355c
	System.Void ChatChannelItemRendererFunc(System.Int32 index, FairyGUI.GObject obj); // 0x05d735d0
	System.Void TribeChannelItemRendererFunc(System.Int32 index, FairyGUI.GObject obj); // 0x05d7380c
	System.Void ClickChannel(FairyGUI.EventContext context); // 0x05d73978
	System.Void OnClickTribeChannel(WizardGames.Soc.SocClient.Ui.TribeInfo info); // 0x05d73c48
	System.Void OnFps10Update(System.Single dt); // 0x05d73ddc
	System.Void OnUpdRolesInfo(); // 0x05d7418c
	System.Void RepeatRequireRolesInfo(System.Object _); // 0x05d6dfa4
	System.Void .ctor(); // 0x05d7428c
	static System.Void .cctor(); // 0x05d74464
	System.Void <OnInit>b__18_0(System.Boolean show); // 0x05d745a0
	System.Void <OnInit>b__18_1(); // 0x05d74714
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChat.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiChat.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x05d747a0
	System.Void .ctor(); // 0x05d74804
	System.Void <.cctor>b__63_0(WizardGames.Soc.SocClient.Ui.UiChat uiChat); // 0x05d7486c
	System.Void <.cctor>b__63_1(WizardGames.Soc.SocClient.Ui.UiChat uiChat); // 0x05d74928
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChatMain : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.UiChat uiChat; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameChat.ChatMainBinder binder; // 0x18
	FairyGUI.GList chatMainLst; // 0x20
	FairyGUI.GButton btnPreMessage; // 0x28
	FairyGUI.GButton btnNewMessage; // 0x30
	FairyGUI.GObject hotField; // 0x38
	System.Boolean isScroll; // 0x40
	System.Single topMaxHide; // 0x44
	WizardGames.Soc.SocClient.IClientChatRoom chatRoom; // 0x48
	System.String curVoiceRecordFileId; // 0x50
	FairyGUI.Controller lastCtrl; // 0x58
	FairyGUI.GButton btnSelfRecommend; // 0x60
	FairyGUI.Controller btnSelfRecommendCtrl; // 0x68
	FairyGUI.Controller btnSelfRecommendEffectCtrl; // 0x70
	System.Int64 nextSelfRecommendTime; // 0x78
	System.Collections.Generic.List<System.Int64> selfRecommendSendTimes; // 0x80
	System.Boolean needUnseenRefresh; // 0x88
	System.UInt32 preMessageUpIdx; // 0x8c
	System.UInt32 preMessageDownIdx; // 0x90
	System.UInt32 preAnnouncementIdx; // 0x94
	System.Void ClearTopMax(); // 0x05d74dc4
	System.UInt32 get_PreMessageNum(); // 0x05d74e28
	System.UInt32 get_DownMessageNum(); // 0x05d75270
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiChat uiChat, FairyGUI.GComponent com); // 0x05d6cd24
	System.Void OnEnable(); // 0x05d6ec1c
	System.Void OnDestory(); // 0x05d6e560
	System.Void Update(); // 0x05d74010
	System.Void OnClickAnnouncementBtn(); // 0x05d76290
	System.Void RefreshTribeAnnouncement(WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo); // 0x05d7683c
	System.Void RefreshUnionAnnouncement(); // 0x05d76b48
	System.Void ScrollToAnnouncement(); // 0x05d7659c
	System.Void TribeBtnNotDisTurbSwitch(); // 0x05d76fd0
	System.Void MessageCountUpdate(); // 0x05d75b04
	System.Void OnChannelModified(); // 0x05d772a4
	System.Void BindCategory(WizardGames.Soc.SocClient.EChatCategory channelCategory); // 0x05d71c64
	System.Void BindChannel(WizardGames.Soc.SocClient.IClientChatRoom room); // 0x05d70c60
	System.Void RecvMessage(WizardGames.Soc.SocClient.ClientChatMessage msg); // 0x05d77400
	System.Void RecvListMessage(WizardGames.Soc.SocClient.ClientChatMessage msg); // 0x05d77750
	System.Void RefreshListToBottom(); // 0x05d7786c
	System.Void RefreshMsgList(); // 0x05d74208
	System.Void RefreshChatMain(); // 0x05d749b8
	System.Void RefreshUnseen(); // 0x05d754d4
	System.Void ChatMainMessageItemRendererFunc(System.Int32 index, FairyGUI.GObject obj); // 0x05d77ab8
	System.Void ScrollBottom(); // 0x05d77610
	System.Void InitSelfRecommend(FairyGUI.GButton button); // 0x05d75348
	System.Void LoadSelfRecommendCooldown(); // 0x05d77d30
	System.Void SaveSelfRecommendCooldown(); // 0x05d77e98
	System.Void NotifyChannelChanged(); // 0x05d71c00
	System.Boolean CanSendSelfRecommend(); // 0x05d77fa0
	System.Void UpdateSelfRecommendButtonState(); // 0x05d75f98
	System.Boolean ShouldShowSelfRecommendButton(); // 0x05d78038
	System.Void OnLobbyLoginSuccess(); // 0x05d78328
	System.Boolean IsSendSelfRecommend(); // 0x05d78178
	System.Void OnSelfRecommendClick(FairyGUI.EventContext context); // 0x05d783c8
	System.Void OnSelfRecommendSent(); // 0x05d78558
	System.Void preMessageInit(WizardGames.Soc.SocClient.IClientChatRoom room); // 0x05d778f8
	System.Void OnMessageLinkClicked(WizardGames.Soc.SocClient.ClientChatMessage msg, FairyGUI.EventContext context); // 0x05d62538
	System.String SpecialChatItemProvider(System.Int32 index); // 0x05d788bc
	System.Void PlayVoice(System.String recordFileId, WizardGames.Soc.SocClient.Ui.Binder.GameChat.ComConversionBinder voiceBinder); // 0x05d626b8
	System.Void CloseVoice(); // 0x05d6f2d4
	static System.Void .cctor(); // 0x05d78a50
	System.Void <.ctor>b__28_0(); // 0x05d78b24
	System.Void <.ctor>b__28_1(); // 0x05d78b8c
	System.Void <.ctor>b__28_2(); // 0x05d78c64
	System.Void <.ctor>b__28_3(); // 0x05d78d9c
	System.Void <.ctor>b__28_4(); // 0x05d78f30
	System.Void <.ctor>b__28_5(); // 0x05d78fa8
	System.Void <.ctor>b__28_6(); // 0x05d790cc
	System.Void <.ctor>b__28_7(); // 0x05d79374
	System.Void <RefreshChatMain>b__46_0(System.String name); // 0x05d79470
	System.Void <PlayVoice>b__64_0(); // 0x05d7953c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChatMain.<>c__DisplayClass41_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiChatMain <>4__this; // 0x10
	WizardGames.Soc.SocClient.IClientChatRoom room; // 0x18
	System.Void .ctor(); // 0x05d79a04
	System.Void <BindChannel>b__0(); // 0x05d79a6c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChatMain.<>c__DisplayClass60_0 : System.Object
{
	System.Int64 nowSec2; // 0x10
	System.Int32 nMinutes; // 0x18
	System.Void .ctor(); // 0x05d79c58
	System.Boolean <OnSelfRecommendSent>b__0(System.Int64 t); // 0x05d79cc0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChatRecruit : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiChat winMain; // 0x10
	FairyGUI.GComponent node; // 0x18
	FairyGUI.GList listRecruit; // 0x20
	FairyGUI.GButton btnPublish; // 0x28
	FairyGUI.GButton btnMore; // 0x30
	FairyGUI.Controller controller; // 0x38
	FairyGUI.GButton btnNormalType; // 0x40
	FairyGUI.GButton btnAppointmentType; // 0x48
	WizardGames.Soc.SocClient.Ui.ComComboBox filterMode; // 0x50
	System.Collections.Generic.HashSet<System.String> roleIdList; // 0x58
	WizardGames.Soc.SocClient.Ui.UiChatRecruit.ERecruitType curRecruitType; // 0x60
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RecruitData> recruitDatas; // 0x68
	System.Int64 timerId; // 0x70
	System.Int64 lastReqGameRecruitTime; // 0x78
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.UiChatRecruit.playerInfo> roleId2PlayerInfo; // 0x80
	System.Single listHeightOffset_btn; // 0x88
	System.Single listHeightOffset_tabTitle; // 0x8c
	System.Int32 modeId; // 0x90
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RecruitData> cache; // 0x98
	System.Collections.Generic.List<System.String> teamIds; // 0xa0
	System.Boolean get_isAppointment(); // 0x054c4760
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiChat uiChat, FairyGUI.GComponent com); // 0x0552af00
	System.Void InitComBox(); // 0x055049cc
	System.Void ComBoxChange(System.Int32 index); // 0x055056e8
	System.Void InitTypeBtns(); // 0x055049cc
	System.Void UpdateTypeBtnsCtrl(); // 0x055049cc
	System.Void TypeChange(WizardGames.Soc.SocClient.Ui.UiChatRecruit.ERecruitType type, System.Boolean isInit); // 0x0550f700
	System.Void OnClickMore(); // 0x055049cc
	System.Void OnClickPublish(); // 0x05d7be84
	System.Void OnRecruitNotice(SimpleJSON.JSONNode json, System.String clearTeamId, System.Boolean isAppointment); // 0x05d7bf68
	System.Void OnGameRecruitListChange(); // 0x055049cc
	System.Void RefreshChatRecruit(System.Boolean forceScroll); // 0x05523a7c
	System.Void RefreshList(); // 0x055049cc
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RecruitData> GetRecruitDatas(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RecruitData> datas); // 0x054f9d14
	System.Void RefreshPublishBtnStatus(); // 0x055049cc
	System.Void OnRecruitDelete(System.String teamId, System.String serverId); // 0x05d7c3e0
	System.Void TimerCallBack(System.Int64 timerId, System.Object _, System.Boolean delete); // 0x05512cfc
	System.Void ClearTimer(); // 0x055049cc
	System.Void OnEnable(); // 0x05d7c960
	System.Void OnDisable(); // 0x05d7cc40
	System.Void OnDestory(); // 0x05d7ced8
	System.Void RecruitItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x0550f6d4
	System.Void <.ctor>b__21_0(FairyGUI.EventContext ctx); // 0x05523a54
	System.Void <.ctor>b__21_1(FairyGUI.EventContext ctx); // 0x05523a54
	System.Void <InitTypeBtns>b__25_0(FairyGUI.EventContext ctx); // 0x05523a54
	System.Void <InitTypeBtns>b__25_1(FairyGUI.EventContext ctx); // 0x05523a54
	System.Void <TimerCallBack>b__40_0(SimpleJSON.JSONNode jsonNode); // 0x05523a54
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiChatRecruit.ERecruitType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiChatRecruit.ERecruitType Lobby = 0;
	static WizardGames.Soc.SocClient.Ui.UiChatRecruit.ERecruitType Appointment = 1;
	static WizardGames.Soc.SocClient.Ui.UiChatRecruit.ERecruitType GameToLobby = 2;
	static WizardGames.Soc.SocClient.Ui.UiChatRecruit.ERecruitType Game = 3;
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiChatRecruit.playerInfo : System.ValueType
{
	System.String roleid; // 0x10
	System.String name; // 0x18
	System.String portrait; // 0x20
	System.Int32 portraitFrame; // 0x28
	System.Int32 level; // 0x2c
	System.Collections.Generic.List<System.Int32> gameStyleIDs; // 0x30
	System.Int32 styleId; // 0x38
	System.Int32 rankPoint; // 0x3c
	Config.EUserPrivacy userPrivacy; // 0x40
	System.Int32 seasonPoints; // 0x44
	System.Void SetPlayerInfo(SimpleJSON.JSONNode jsonNode); // 0x05d7e5c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChatRecruit.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiChatRecruit.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.UiCommonTeamBattle> <>9__29_0; // 0x8
	static System.Void .cctor(); // 0x05d7ea04
	System.Void .ctor(); // 0x05d7ea68
	System.Void <OnClickMore>b__29_0(WizardGames.Soc.SocClient.Ui.UiCommonTeamBattle ui); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChatRecruit.<>c__DisplayClass29_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ETeamTabType type; // 0x10
	System.Void .ctor(); // 0x055049cc
	System.Void <OnClickMore>b__1(WizardGames.Soc.SocClient.Ui.UiCommonTeamLobby win); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChatRecruit.<>c__DisplayClass33_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiChatRecruit <>4__this; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RecruitData> newDatas; // 0x18
	System.Boolean forceScroll; // 0x20
	System.Void .ctor(); // 0x055049cc
	System.Void <RefreshChatRecruit>b__0(SimpleJSON.JSONArray jsonArray); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChatRecruit.<>c__DisplayClass45_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiChatRecruit <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.RecruitData recruitData; // 0x18
	System.String teamId; // 0x20
	System.Action<System.String,SimpleJSON.JSONArray> <>9__1; // 0x28
	System.Action<System.Boolean> <>9__2; // 0x30
	System.Void .ctor(); // 0x055049cc
	System.Void <RecruitItemRenderer>b__0(FairyGUI.EventContext ctx); // 0x05523a54
	System.Void <RecruitItemRenderer>b__1(System.String str, SimpleJSON.JSONArray tagArray); // 0x0552af00
	System.Void <RecruitItemRenderer>b__2(System.Boolean isSuccess); // 0x05523a7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.CombatSuitDataCtr : System.Object
{
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ESuiteGroup,System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SuiteItemData>> suiteEquipDataDic; // 0x10
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.EAmmoType,System.Int32>> ammoDataDic; // 0x18
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.EAmmoType,System.Int32>> curWeaponHaveAmmoDataDic; // 0x20
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SuiteWeaponAccessoryItemData>> accessoryDic; // 0x28
	System.Void RefreshData(System.Int32 euipmentId); // 0x05d7f904
	System.Void DealAmmoData(System.Int32 euipmentId); // 0x05d7ff60
	System.Void DealAccessoryData(System.Int32 euipmentId); // 0x05d80558
	System.Void DealGroupData(System.Int32 euipmentId); // 0x05d80abc
	System.Void DealWeaponHaveAmmoData(); // 0x05d812d8
	System.Void FillItem(); // 0x05d81338
	System.Void FillAmmo(); // 0x05d827e0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SuiteItemData> GetSuiteEquipDataListByGroupId(WizardGames.Soc.SocClient.Ui.ESuiteGroup suiteGroup); // 0x05d83598
	System.Void Clear(); // 0x05d7f9b8
	System.Void .ctor(); // 0x05d836b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.CombatSuitDataCtr.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.CombatSuitDataCtr.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.SuiteAmmoItemData> <>9__14_0; // 0x8
	static System.Void .cctor(); // 0x05d83838
	System.Void .ctor(); // 0x05d8389c
	System.Int32 <FillAmmo>b__14_0(WizardGames.Soc.SocClient.Ui.SuiteAmmoItemData a, WizardGames.Soc.SocClient.Ui.SuiteAmmoItemData b); // 0x05d83904
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ESuiteGroup : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ESuiteGroup None = 0;
	static WizardGames.Soc.SocClient.Ui.ESuiteGroup RemoteWeaponGroup = 1;
	static WizardGames.Soc.SocClient.Ui.ESuiteGroup ThrowWeaponGroup = 2;
	static WizardGames.Soc.SocClient.Ui.ESuiteGroup EpuipGroup = 3;
	static WizardGames.Soc.SocClient.Ui.ESuiteGroup SupplyGroup = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SuiteAmmoItemData : System.Object
{
	System.Int32 weaponIndex; // 0x10
	WizardGames.Soc.SocClient.Ui.EAmmoType ammoType; // 0x14
	System.Int32 curHaveCount; // 0x18
	System.Int32 count; // 0x1c
	System.String iconPath; // 0x20
	System.Void .ctor(System.Int32 weaponIndex, WizardGames.Soc.SocClient.Ui.EAmmoType ammoType, System.Int32 count, System.Int32 curHaveCount); // 0x05d8340c
	System.Void Init(); // 0x05d834b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SuiteWeaponAccessoryItemData : System.Object
{
	System.Int32 weaponIndex; // 0x10
	System.Int64 itemId; // 0x18
	WizardGames.Soc.Common.Data.DataItem.ItemSlot accessorySlot; // 0x20
	System.String iconPath; // 0x28
	System.Boolean isFlagEmpty; // 0x30
	System.String flagEmptyIconPath; // 0x38
	System.Void .ctor(System.Int32 weaponIndex, WizardGames.Soc.Common.Data.DataItem.ItemSlot accessorySlot, System.Int64 itemId); // 0x05d82ebc
	System.Void Init(); // 0x05d82f64
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SuiteItemData : System.Object
{
	System.Int64 itemId; // 0x10
	System.Int32 itemCount; // 0x18
	WizardGames.Soc.SocClient.Ui.ESuiteGroup suiteGroup; // 0x1c
	System.String iconPath; // 0x20
	System.Boolean isEmptyBgIcon; // 0x28
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.ESuiteGroup suiteGroup, System.Int64 itemId, System.Int32 itemCount); // 0x05d83368
	System.Void Init(); // 0x05d83998
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SuitRemoteWeaponItemData : WizardGames.Soc.SocClient.Ui.SuiteItemData
{
	System.Int32 belongPosition; // 0x2c
	System.String weaponName; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SuiteAmmoItemData> ammoItemDataList; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SuiteWeaponAccessoryItemData> accessoryItemDataList; // 0x40
	System.Void .ctor(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SuiteWeaponAccessoryItemData> accessoryItemDataList, System.Int32 belongPosition, WizardGames.Soc.SocClient.Ui.ESuiteGroup suiteGroup, System.Int64 itemId, System.Int32 itemCount); // 0x05d83148
	System.Void Init(); // 0x05d83af4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SuitEquipItemData : WizardGames.Soc.SocClient.Ui.SuiteItemData
{
	System.Int32 belongPosition; // 0x2c
	System.Boolean isFlagEmpty; // 0x30
	System.String flagEmptyIconPath; // 0x38
	System.Void .ctor(System.Int32 belongPosition, WizardGames.Soc.SocClient.Ui.ESuiteGroup suiteGroup, System.Int64 itemId, System.Int32 itemCount); // 0x05d832b8
	System.Void Init(); // 0x05d83c84
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComCombatSuitWeapon : System.Object
{
	FairyGUI.GTextField txtWeaponName; // 0x10
	FairyGUI.GLoader weaponIcon; // 0x18
	FairyGUI.GList listBullet; // 0x20
	FairyGUI.GList listAccessory; // 0x28
	FairyGUI.Controller ctrStatus; // 0x30
	WizardGames.Soc.SocClient.Ui.SuitRemoteWeaponItemData remoteWeaponItemData; // 0x38
	System.Void OnInit(FairyGUI.GComponent root); // 0x05d83e6c
	System.Void RefreshPanel(WizardGames.Soc.SocClient.Ui.SuitRemoteWeaponItemData remoteWeaponItemData); // 0x05d840c4
	System.Void OnAmmoListItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x05d842d4
	System.Void OnAccessoryListItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x05d84500
	System.Void .ctor(); // 0x05d8483c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComCombatSuitWeapon.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.ComCombatSuitWeapon.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.SuiteWeaponAccessoryItemData> <>9__7_0; // 0x8
	static System.Void .cctor(); // 0x05d848a4
	System.Void .ctor(); // 0x05d84908
	System.Int32 <RefreshPanel>b__7_0(WizardGames.Soc.SocClient.Ui.SuiteWeaponAccessoryItemData a, WizardGames.Soc.SocClient.Ui.SuiteWeaponAccessoryItemData b); // 0x05d84970
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCombatSuit : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	SocLogger log; // 0x338
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x340
	FairyGUI.GList listTab; // 0x348
	WizardGames.Soc.SocClient.Ui.ComCombatSuitWeapon comWeapon1; // 0x350
	WizardGames.Soc.SocClient.Ui.ComCombatSuitWeapon comWeapon2; // 0x358
	FairyGUI.GList listThrowWeapon; // 0x360
	FairyGUI.GList listEquip; // 0x368
	FairyGUI.GList listSupply; // 0x370
	FairyGUI.GTextField txtDowntime; // 0x378
	WizardGames.Soc.SocClient.Ui.ComBtnKeyTipsAction btnSelect; // 0x380
	FairyGUI.GProgressBar progressBar; // 0x388
	FairyGUI.Transition transitionTime; // 0x390
	FairyGUI.Transition transitionClickTab; // 0x398
	System.Int32 lastSec; // 0x3a0
	System.Int64 autoCloseEndTime; // 0x3a8
	System.Int64 downtime; // 0x3b0
	System.Int64 autoUpdateTimerId; // 0x3b8
	System.Int64 calcSuitCountTimerId; // 0x3c0
	System.Collections.Generic.List<System.Int32> tabConfigList; // 0x3c8
	System.Collections.Generic.List<System.Int32> tabConfigPlayerCountList; // 0x3d0
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> suitCountDic; // 0x3d8
	WizardGames.Soc.SocClient.Ui.CombatSuitDataCtr combatSuitDataCtr; // 0x3e0
	System.Int32 playerDefaultSelectSuitId; // 0x3e8
	System.Int32 playerCurSelectSuitId; // 0x3ec
	System.Int32 playerCurSelectTabIndex; // 0x3f0
	System.Int64 teamId; // 0x3f8
	FairyGUI.Transition transitionComWeaponClick; // 0x400
	FairyGUI.Transition transitionComItemClick; // 0x408
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,FairyGUI.GObject>> tabItemTempDic; // 0x410
	System.Int64 listThrowWeaponItemClickAniTimerId; // 0x418
	System.Int64 listEquipItemClickAniTimerId; // 0x420
	System.Int64 listSupplyItemClickAniTimerId; // 0x428
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SuiteItemData> get_RemoteWeaponDataList(); // 0x05d84a04
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SuiteItemData> get_ThrowWeaponDataList(); // 0x05d84a74
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SuiteItemData> get_EquipDataList(); // 0x05d84ae4
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SuiteItemData> get_SupplyDataList(); // 0x05d84b54
	static System.Void TryOpenWindow(System.Int64 autoCloseEndTime, System.Int32 downtime, System.Boolean isShowCloseBtn); // 0x05d84bc4
	static System.Void TryCloseWindow(); // 0x05d84de0
	System.Void OnInit(); // 0x05d84ebc
	System.Void OnEnable(); // 0x05d85968
	System.Void OnDisable(); // 0x05d85a84
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05d85ef8
	System.Void Init(System.Int32 playRuleId, System.Int64 teamId, System.Int64 teamAttackerId, System.Int64 teamDefenderId, System.Int32 curSuitId, System.Int64 autoCloseEndTime, System.Int32 downtime, System.Boolean isShowCloseBtn); // 0x05507814
	System.Void OnUpdateDownTime(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x05d86a10
	System.Void OnUpdateCalcSuitCount(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x05d86c3c
	System.Void OnPickEquipmentSuccessCallback(System.Int32 suitId); // 0x05d87444
	System.Void RefreshSuitCount(); // 0x05d86d04
	System.Void InitTabData(System.Int32 playRuleId, System.Int64 teamAttackerId, System.Int64 teamDefenderId); // 0x05d86648
	System.Void UpdateTabList(); // 0x05d874c8
	System.Void OnTabListItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x05d8787c
	System.Void OnTabItemClick(FairyGUI.EventContext context); // 0x05d87f70
	System.Void RefreshPanel(System.Int32 dataIndex); // 0x05d875c0
	System.Void RefrshSelectBtnState(); // 0x05d87288
	System.Void OnThrowWeaponListItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x05d8809c
	System.Void OnEquipListItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x05d8849c
	System.Void UpdateEquipItemRenderer(WizardGames.Soc.SocClient.Ui.SuitEquipItemData suiteItemData, FairyGUI.GComponent comObj); // 0x05d885f4
	System.Void OnSupplyListItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x05d8897c
	System.Void UpdateItemRenderer(WizardGames.Soc.SocClient.Ui.SuiteItemData suiteItemData, FairyGUI.GComponent comObj); // 0x05d881ac
	System.Void OnBtnSelect(); // 0x05d88a8c
	System.Void .ctor(); // 0x05d88d24
	System.Void <OnInit>b__42_0(); // 0x05d88fb8
	System.Void <OnInit>b__42_1(); // 0x05d89058
	System.Void <OnInit>b__42_2(); // 0x05d890f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCombatSuit.<>c__DisplayClass40_0 : System.Object
{
	System.Int64 autoCloseEndTime; // 0x10
	System.Int32 downtime; // 0x18
	System.Boolean isShowCloseBtn; // 0x1c
	System.Void .ctor(); // 0x05d84d78
	System.Void <TryOpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiCombatSuit win); // 0x05d89198
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiComBlock : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	System.Action evCallBack; // 0x338
	System.Void OnInit(); // 0x05d89308
	System.Void OnDestroy(); // 0x05d89438
	System.Void OnTouchEnd(); // 0x05d894a4
	System.Void .ctor(); // 0x05d89538
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDropdownData : System.Object
{
	System.String Name; // 0x10
	System.Boolean Enable; // 0x18
	System.Action ClickAction; // 0x20
	System.Void .ctor(); // 0x05d895c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiComDropdown : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	SocLogger log; // 0x338
	FairyGUI.GComponent comDropdown; // 0x340
	FairyGUI.GList list; // 0x348
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiDropdownData> selfSetting; // 0x350
	static System.Single <MinX>k__BackingField; // 0x0
	static System.Single <MaxX>k__BackingField; // 0x4
	System.Void OnInit(); // 0x05d8962c
	System.Void OnListItemRender(System.Int32 index, FairyGUI.GObject item); // 0x05d8992c
	static System.Single get_MinX(); // 0x05d89c78
	static System.Single get_MaxX(); // 0x05d89cf0
	System.Void SetMainsPos(UnityEngine.Vector2 pos, System.Single high, System.Boolean tipsAtPosLeft); // 0x05d89d68
	static System.Void Open(UnityEngine.Vector2 pos, System.Boolean isLeft, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiDropdownData> dropdownDatas); // 0x05d8a140
	System.Void SetDropData(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiDropdownData> dropdownDatas); // 0x05d8a294
	System.Void .ctor(); // 0x05d8a33c
	System.Void <OnInit>b__4_0(FairyGUI.EventContext ctx); // 0x05d8a464
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiComDropdown.<>c__DisplayClass5_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiDropdownData cfg; // 0x10
	WizardGames.Soc.SocClient.Ui.UiComDropdown <>4__this; // 0x18
	System.Void .ctor(); // 0x05d89c10
	System.Void <OnListItemRender>b__0(FairyGUI.EventContext context); // 0x05d8a4e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiComItemSplit : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x338
	FairyGUI.GList itemList; // 0x340
	FairyGUI.GTextField title; // 0x348
	FairyGUI.GComponent comSlider; // 0x350
	FairyGUI.GSlider slider; // 0x358
	FairyGUI.GButton btnLess; // 0x360
	FairyGUI.GButton btnMore; // 0x368
	FairyGUI.GButton btnMax; // 0x370
	FairyGUI.Controller ctrlSliderHideMax; // 0x378
	System.Int32 lobbyRid; // 0x380
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.common.BTuple2> exchangeResourcesList; // 0x388
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiComItemSplit.ComItemSplitStruct> targetExchangeResourcesList; // 0x390
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ModalBtnInfo> btnInfos; // 0x398
	System.Void OnInit(); // 0x05d8a584
	System.Void OnRefreshItemAmount(); // 0x05d8ae78
	System.Void OnSliderValueChanged(FairyGUI.EventContext context); // 0x05d8b03c
	System.Void OnClickLess(); // 0x05d8b5a0
	System.Void OnClickMore(); // 0x05d8b848
	System.Void OnClickMax(); // 0x05d8baf0
	System.Void OnRenderListItem(System.Int32 index, FairyGUI.GObject obj); // 0x05d8bc2c
	System.Void OnClickClose(); // 0x05d8be60
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05d8becc
	System.Void OnEnable(); // 0x05d8bf44
	System.Void OnDisable(); // 0x05d8bfac
	System.Void OnDestroy(); // 0x05d8c014
	System.Void SetLobbyItem(System.Int32 rid, System.String title, System.String modalTitle, System.Int32 amount, System.Int32 maxAmount, System.Action<System.Int32> callback); // 0x05d8c07c
	static System.Void ShowLobbyItemSplit(System.Int32 rid, System.String title, System.String modalTitle, System.Int32 amount, System.Int32 maxAmount, System.Action<System.Int32> callback); // 0x05d8c8c4
	System.Void .ctor(); // 0x05d8caf8
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiComItemSplit.ComItemSplitStruct : System.ValueType
{
	System.Int32 rid; // 0x10
	System.Int32 amount; // 0x14
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiComItemSplit.<>c__DisplayClass14_0 : System.Object
{
	FairyGUI.GObject sliderGrip; // 0x10
	System.Void .ctor(); // 0x05d8ae10
	System.Void <OnInit>b__0(FairyGUI.EventContext ctx); // 0x05d8cc80
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiComItemSplit.<>c__DisplayClass26_0 : System.Object
{
	System.Action<System.Int32> callback; // 0x10
	WizardGames.Soc.SocClient.Ui.UiComItemSplit <>4__this; // 0x18
	System.Void .ctor(); // 0x05d8c85c
	System.Void <SetLobbyItem>b__0(); // 0x05d8cd70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiComItemSplit.<>c__DisplayClass27_0 : System.Object
{
	System.Int32 rid; // 0x10
	System.String title; // 0x18
	System.String modalTitle; // 0x20
	System.Int32 amount; // 0x28
	System.Int32 maxAmount; // 0x2c
	System.Action<System.Int32> callback; // 0x30
	System.Void .ctor(); // 0x05d8ca90
	System.Void <ShowLobbyItemSplit>b__0(WizardGames.Soc.SocClient.Ui.UiComItemSplit win); // 0x05d8ce64
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonAppWelfare : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonAppWelfare.RootCommonWelfareBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComModal modal; // 0x340
	System.Void OnInit(); // 0x05d8cef4
	System.Void SetPlatformType(System.String platformType); // 0x05d8d198
	System.Void .ctor(); // 0x05d8d26c
	System.Void <OnInit>b__2_0(); // 0x05d8d2f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonDataSetting : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GObject bg; // 0x338
	FairyGUI.GTextField textTitle; // 0x340
	FairyGUI.GTextField textDes; // 0x348
	FairyGUI.GTextInput textInput; // 0x350
	FairyGUI.GButton btnCancel; // 0x358
	FairyGUI.GButton btnConfirm; // 0x360
	WizardGames.Soc.SocClient.Ui.ViewCommonInfo commonInfo; // 0x368
	FairyGUI.GComponent panelRoot; // 0x370
	System.Void OnInit(); // 0x05d8d364
	static System.Void OpenWindow(WizardGames.Soc.SocClient.Ui.ViewCommonInfo info); // 0x05d8d7bc
	System.Void SetInfo(WizardGames.Soc.SocClient.Ui.ViewCommonInfo info); // 0x05d8d97c
	static System.Void CloseWindow(); // 0x05d8dab4
	System.Void OnValueChange(); // 0x05d8dba4
	System.Void Cancel(); // 0x05d8dc70
	System.Void SetValue(); // 0x05d8dcdc
	System.Void .ctor(); // 0x05d8dda8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonDataSetting.<>c__DisplayClass9_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ViewCommonInfo info; // 0x10
	System.Void .ctor(); // 0x05d8d914
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiCommonDataSetting win); // 0x05d8de34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ViewCommonInfo : System.Object
{
	System.String Title; // 0x10
	System.String Des; // 0x18
	System.String ConfirmBtnText; // 0x20
	System.String CancelBtnText; // 0x28
	System.String CurValue; // 0x30
	System.Func<System.String,System.String> AmendValueAction; // 0x38
	System.Action<System.String> ConfirmValueAction; // 0x40
	System.Void .ctor(); // 0x05d8deb8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInputNum : System.Object
{
	FairyGUI.GComponent root; // 0x10
	System.Int32 showRatio; // 0x18
	System.Int32 inputNum; // 0x1c
	System.Int32 inputMinNum; // 0x20
	System.Int32 inputMaxNum; // 0x24
	System.Int32 inputChangeNum; // 0x28
	FairyGUI.GLoader openHandlePanelTouchLoader; // 0x30
	FairyGUI.GSlider slider; // 0x38
	FairyGUI.GButton minusBtn; // 0x40
	FairyGUI.GButton addBtn; // 0x48
	FairyGUI.GButton maxBtn; // 0x50
	FairyGUI.Controller minusBtnCtrl; // 0x58
	FairyGUI.Controller addBtnCtrl; // 0x60
	FairyGUI.Controller maxBtnCtrl; // 0x68
	FairyGUI.Controller sliderCtrl; // 0x70
	UnityEngine.Vector2 CounterPos; // 0x78
	System.Action<System.Int32> OnValueChange; // 0x80
	System.Void OnInit(FairyGUI.GComponent component); // 0x05d8dfac
	System.Int32 get_InputNum(); // 0x05d8e408
	System.Int32 get_InputMaxNum(); // 0x05d8e46c
	System.Void SetData(System.Int32 curNum, System.Int32 minNum, System.Int32 maxNum, System.Int32 showRatio, System.Int32 changeNum); // 0x05d8e4d0
	System.Void SendValueChangeMsg(); // 0x05d8e81c
	System.Void OnCounterConfirmCallBack(System.Int32 num); // 0x05d8e8a0
	System.Void OnCounterChangeCallBack(System.Int32 num); // 0x05d8e92c
	System.Void OnMinusBtnClick(); // 0x05d8e9d4
	System.Void OnAddBtnClick(); // 0x05d8ea44
	System.Void OnMaxBtnClick(); // 0x05d8eab4
	System.Void OnSetNumChange(System.Int32 num); // 0x05d8e634
	System.Void .ctor(); // 0x05d8eb1c
	System.Void <OnInit>b__16_0(); // 0x05d8eb90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComFriendSearch : System.Object
{
	FairyGUI.GComponent root; // 0x10
	FairyGUI.GTextInput inputText; // 0x18
	FairyGUI.GButton btnClear; // 0x20
	FairyGUI.Controller searchState; // 0x28
	System.Action<System.String> searchAction; // 0x30
	System.Action clearAction; // 0x38
	System.Void .ctor(FairyGUI.GComponent component, System.Action<System.String> searchAction, System.Action clearAction); // 0x05d8ed4c
	System.Void InitComSearch(); // 0x05d8ee1c
	System.Void InputTextChange(FairyGUI.EventContext context); // 0x05d8f2a4
	System.Void OnClickClearText(); // 0x05d8f4a4
	System.Void OnClickSearch(System.Boolean needClearTxt); // 0x05d8f37c
	System.Void <InitComSearch>b__7_0(); // 0x05d8f560
	System.Void <InitComSearch>b__7_2(FairyGUI.EventContext context); // 0x05d8f5d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComFriendSearch.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.ComFriendSearch.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__7_1; // 0x8
	static FairyGUI.EventCallback1 <>9__7_3; // 0x10
	static System.Void .cctor(); // 0x05d8f690
	System.Void .ctor(); // 0x05d8f6f4
	System.Void <InitComSearch>b__7_1(FairyGUI.EventContext context); // 0x05d8f75c
	System.Void <InitComSearch>b__7_3(FairyGUI.EventContext context); // 0x05d8f7e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InviteFriendPanel : System.Object
{
	FairyGUI.GList glist; // 0x10
	FairyGUI.Controller numStatusCtrl; // 0x18
	FairyGUI.Controller typeCtrl; // 0x20
	FairyGUI.Controller friendTypeCtrl; // 0x28
	System.Boolean isMultiSelect; // 0x30
	System.Boolean isTempFriend; // 0x31
	System.Int32 multiLimitCount; // 0x34
	WizardGames.Soc.SocClient.Ui.ECommonInviteOperation inviteOperation; // 0x38
	System.String param; // 0x40
	System.Action<System.Collections.Generic.List<System.String>> doAction; // 0x48
	System.Collections.Generic.List<LobbyFriend.FriendInfo> friendInfos; // 0x50
	System.Collections.Generic.List<System.String> invitedFriendIds; // 0x58
	WizardGames.Soc.SocClient.Ui.UiCommonInvite uiCommonInvite; // 0x60
	System.Collections.Generic.List<LobbyFriend.FriendInfo> showFriendInfos; // 0x68
	WizardGames.Soc.SocClient.Ui.ComFriendSearch comFriendSearch; // 0x70
	System.Boolean hasAddListener; // 0x78
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiCommonInvite uiCommonInvite, FairyGUI.GComponent root, System.Action<System.Collections.Generic.List<System.String>> doAction); // 0x05d8f864
	System.Void ShowFriendList(); // 0x05d8ff00
	System.Void ShowgTempFriendList(); // 0x05d9048c
	System.Void OnSearchFriend(System.String keyword); // 0x05d90890
	System.Void OnClearSearch(); // 0x05d90c28
	System.Void RefreshList(); // 0x05d90394
	System.Void RenderListItem(System.Int32 index, FairyGUI.GObject obj); // 0x05d90cf0
	System.Boolean IsGrayed(System.String roleId); // 0x05d91a18
	System.Void OnCheckBoxClick(FairyGUI.GButton btn, System.String roleId); // 0x05d91af4
	System.Boolean IsIgnore(System.String roleId, System.UInt64 communityID); // 0x05d90254
	System.Void ReqFriendRoleInfoCb(); // 0x05d91c6c
	System.Void ReqTempFriendRoleInfoCb(); // 0x05d91ce4
	System.Void OnEnable(System.Boolean isTempFriend, System.Boolean isMultiple, System.Int32 multiLimitCount, WizardGames.Soc.SocClient.Ui.ECommonInviteOperation operation, System.String param); // 0x05d91d5c
	System.Void OnDisable(); // 0x05d92020
	System.Void CheckUnionLevel(FairyGUI.GButton btn, System.Int32 roleLevel); // 0x05d91870
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InviteFriendPanel.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.InviteFriendPanel.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__16_3; // 0x8
	static FairyGUI.EventCallback1 <>9__16_2; // 0x10
	static System.Void .cctor(); // 0x05d9217c
	System.Void .ctor(); // 0x05d921e0
	System.Void <.ctor>b__16_2(FairyGUI.EventContext ctx); // 0x05d92248
	System.Void <.ctor>b__16_3(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05d923d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InviteFriendPanel.<>c__DisplayClass16_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiCommonInvite uiCommonInvite; // 0x10
	WizardGames.Soc.SocClient.Ui.InviteFriendPanel <>4__this; // 0x18
	System.Action<System.Collections.Generic.List<System.String>> doAction; // 0x20
	System.Void .ctor(); // 0x05d8fe98
	System.Void <.ctor>b__0(FairyGUI.EventContext ctx); // 0x05d924bc
	System.Void <.ctor>b__1(FairyGUI.EventContext ctx); // 0x05d92574
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InviteFriendPanel.<>c__DisplayClass22_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.InviteFriendPanel <>4__this; // 0x10
	System.String roleId; // 0x18
	System.Void .ctor(); // 0x05d91738
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InviteFriendPanel.<>c__DisplayClass22_1 : System.Object
{
	FairyGUI.GButton btnCheckBox; // 0x10
	WizardGames.Soc.SocClient.Ui.InviteFriendPanel.<>c__DisplayClass22_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x05d917a0
	System.Void <RenderListItem>b__0(FairyGUI.EventContext ctx); // 0x05d92654
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InviteFriendPanel.<>c__DisplayClass22_2 : System.Object
{
	FairyGUI.GButton btnInvite; // 0x10
	WizardGames.Soc.SocClient.Ui.InviteFriendPanel.<>c__DisplayClass22_0 CS$<>8__locals2; // 0x18
	System.Void .ctor(); // 0x05d91808
	System.Void <RenderListItem>b__1(FairyGUI.EventContext ctx); // 0x05d92748
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InvitePlayWithPanel : System.Object
{
	SocLogger log; // 0x10
	FairyGUI.GList glist; // 0x18
	FairyGUI.Controller numStatusCtrl; // 0x20
	FairyGUI.Controller typeCtrl; // 0x28
	System.Int32 multiLimitCount; // 0x30
	System.Action<System.Collections.Generic.List<System.String>> doAction; // 0x38
	WizardGames.Soc.SocClient.Ui.UiCommonInvite uiCommonInvite; // 0x40
	System.Collections.Generic.IReadOnlyList<LobbyFriend.PlatformFriendInfo> curFriendInfos; // 0x48
	System.Collections.Generic.IReadOnlyList<LobbyFriend.PlatformFriendInfo> playWithFriendInfos; // 0x50
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiCommonInvite uiCommonInvite, FairyGUI.GComponent root, System.Action<System.Collections.Generic.List<System.String>> doAction); // 0x05d9295c
	System.Void ShowFriendList(); // 0x05d92e30
	System.Void RefreshList(); // 0x05d93010
	System.Void RenderListItem(System.Int32 index, FairyGUI.GObject obj); // 0x05d93154
	System.Void OnInviteOrCallbackClick(System.String openID, System.String roleId, System.String title, System.String desc); // 0x05d93cd8
	System.Void OnClickPlatformInvite(System.String openID, System.String roleId, System.String title, System.String desc); // 0x05d93ed0
	System.Void OnEnable(); // 0x05d941ac
	System.Void OnDisable(); // 0x05d94460
	System.Void Refresh(); // 0x05d94244
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InvitePlayWithPanel.<>c__DisplayClass12_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.InvitePlayWithPanel <>4__this; // 0x10
	LobbyFriend.PlatformFriendInfo curfriendInfo; // 0x18
	FairyGUI.GButton btnInvite; // 0x20
	FairyGUI.GTextField titleField; // 0x28
	System.String roleId; // 0x30
	System.Void .ctor(); // 0x05d93c70
	System.Void <RenderListItem>b__0(FairyGUI.EventContext ctx); // 0x05d94558
	System.Void <RenderListItem>b__1(FairyGUI.EventContext ctx); // 0x05d94748
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InvitePlayWithPanel.<>c__DisplayClass9_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiCommonInvite uiCommonInvite; // 0x10
	WizardGames.Soc.SocClient.Ui.InvitePlayWithPanel <>4__this; // 0x18
	System.Action<System.Collections.Generic.List<System.String>> doAction; // 0x20
	System.Void .ctor(); // 0x05d92dc8
	System.Void <.ctor>b__0(FairyGUI.EventContext ctx); // 0x05d948f8
	System.Void <.ctor>b__1(FairyGUI.EventContext ctx); // 0x05d949b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InviteSelfRecommendPanel : System.Object
{
	FairyGUI.GList glist; // 0x10
	WizardGames.Soc.SocClient.Ui.ECommonInviteOperation inviteOperation; // 0x18
	System.String param; // 0x20
	System.Action<System.Collections.Generic.List<System.String>> doAction; // 0x28
	WizardGames.Soc.SocClient.Ui.UiCommonInvite uiCommonInvite; // 0x30
	FairyGUI.GComponent header; // 0x38
	FairyGUI.Controller headerCtrl; // 0x40
	System.Boolean isWaitingForHeaderUnlock; // 0x48
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.InviteSelfRecommendPanel.SelfRecommendData> selfRecommendDatas; // 0x50
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.InviteSelfRecommendPanel.SelfRecommendData> allSelfRecommendDatas; // 0x58
	System.Int32 currentTeamModeId; // 0x60
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiCommonInvite uiCommonInvite, FairyGUI.GComponent root, System.Action<System.Collections.Generic.List<System.String>> doAction); // 0x05d94a90
	System.Void CheckAndResetHeaderState(); // 0x05d9511c
	System.Void OnPullDownRefreshInternal(); // 0x05d95264
	System.Void LoadSelfRecommendDataFromChat(); // 0x05d953b8
	System.Void ExtractSelfRecommendDataFromChat(); // 0x05d95830
	WizardGames.Soc.SocClient.Ui.InviteSelfRecommendPanel.SelfRecommendData ParseSelfRecommendMessage(WizardGames.Soc.SocClient.ClientChatMessage msg); // 0x05d95ca4
	System.Void ParseSelfRecommendContent(System.String content, System.Collections.Generic.List<System.Int32>& expertiseIds, System.String& notes); // 0x05d96138
	System.Boolean TryMatchExpertise(System.String text, System.Collections.Generic.List<System.Int32> expertiseIds); // 0x05d967ec
	System.Void RefreshSelfRecommendList(System.Action onComplete); // 0x05d96adc
	System.Void FilterSelfRecommendList(); // 0x05d96b88
	System.Void ShuffleList(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.InviteSelfRecommendPanel.SelfRecommendData> list); // 0x05d9736c
	System.Void GetCurrentTeamMode(); // 0x05d97068
	System.Void RefreshList(); // 0x05d96fbc
	System.Void RenderListItem(System.Int32 index, FairyGUI.GObject obj); // 0x05d974a4
	System.UInt64 GetMyRoleId(); // 0x05d97280
	System.Void OnEnable(WizardGames.Soc.SocClient.Ui.ECommonInviteOperation operation, System.String param); // 0x05d97d5c
	System.Void OnDisable(); // 0x05d97df4
	System.Void <OnPullDownRefreshInternal>b__14_0(System.Object _); // 0x05d97e54
	System.Void <OnPullDownRefreshInternal>b__14_1(); // 0x05d97f14
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InviteSelfRecommendPanel.SelfRecommendData : System.Object
{
	System.UInt64 roleId; // 0x10
	System.String roleName; // 0x18
	System.String portrait; // 0x20
	System.Int32 portraitFrame; // 0x28
	System.Int32 level; // 0x2c
	System.Int32 seasonPoints; // 0x30
	System.Collections.Generic.List<System.Int32> expertise; // 0x38
	System.Int32 modeId; // 0x40
	System.String notes; // 0x48
	System.Int64 sendTime; // 0x50
	System.Void .ctor(); // 0x05d98314
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InviteSelfRecommendPanel.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.InviteSelfRecommendPanel.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.InviteSelfRecommendPanel.SelfRecommendData> <>9__15_0; // 0x8
	static System.Void .cctor(); // 0x05d983c8
	System.Void .ctor(); // 0x05d9842c
	System.Int32 <LoadSelfRecommendDataFromChat>b__15_0(WizardGames.Soc.SocClient.Ui.InviteSelfRecommendPanel.SelfRecommendData a, WizardGames.Soc.SocClient.Ui.InviteSelfRecommendPanel.SelfRecommendData b); // 0x05d98494
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InviteSelfRecommendPanel.<>c__DisplayClass12_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.InviteSelfRecommendPanel <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.UiCommonInvite uiCommonInvite; // 0x18
	System.Action<System.Collections.Generic.List<System.String>> doAction; // 0x20
	System.Void .ctor(); // 0x05d98528
	System.Void <.ctor>b__0(); // 0x05d98590
	System.Void <.ctor>b__1(); // 0x05d98600
	System.Void <.ctor>b__2(FairyGUI.EventContext ctx); // 0x05d98670
	System.Void <.ctor>b__3(FairyGUI.EventContext ctx); // 0x05d98728
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InviteSelfRecommendPanel.<>c__DisplayClass25_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.InviteSelfRecommendPanel <>4__this; // 0x10
	System.String roleId; // 0x18
	System.Void .ctor(); // 0x05d98808
	System.Void <RenderListItem>b__0(FairyGUI.EventContext ctx); // 0x05d98870
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InviteTribeMemberPanel : System.Object
{
	FairyGUI.GList glist; // 0x10
	FairyGUI.Controller numStatusCtrl; // 0x18
	FairyGUI.Controller typeCtrl; // 0x20
	FairyGUI.GComponent topScrollItem; // 0x28
	System.Boolean isMultiSelect; // 0x30
	System.Int32 multiLimitCount; // 0x34
	WizardGames.Soc.SocClient.Ui.ECommonInviteOperation inviteOperation; // 0x38
	System.String param; // 0x40
	System.Action<System.Collections.Generic.List<System.String>> doAction; // 0x48
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeInfo> tribeInfos; // 0x50
	System.String curExpandTribeId; // 0x58
	System.Collections.Generic.Dictionary<System.String,Config.LobbyRoleInfo> roleId2PlayerInfo; // 0x60
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.InviteTribeMemberRowInfo> rowInfos; // 0x68
	System.Collections.Generic.List<System.String> invitedFriendIds; // 0x70
	WizardGames.Soc.SocClient.Ui.UiCommonInvite uiCommonInvite; // 0x78
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiCommonInvite uiCommonInvite, FairyGUI.GComponent root, System.Action<System.Collections.Generic.List<System.String>> doAction); // 0x05d989b4
	System.Void RenderListItem(System.Int32 index, FairyGUI.GObject obj); // 0x05d99038
	System.Void TribeTitleClick(System.String tribeID, System.Boolean showAudio); // 0x05d9a214
	System.Boolean IsGrayed(System.String roleId); // 0x05d9aef8
	System.Void RenderCheckBoxItem(FairyGUI.GComponent item, System.String roleId); // 0x05d9997c
	System.Void OnCheckBoxClick(FairyGUI.GButton btn, System.String roleId); // 0x05d9b03c
	System.Void RenderAvatar(WizardGames.Soc.SocClient.Ui.ComAvatarSquare head, Config.LobbyRoleInfo memberInfo); // 0x05d9a150
	System.Void RefreshList(); // 0x05d9a434
	System.Void ReqMemberInfos(WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo); // 0x05d9abb8
	System.Boolean IsIgnore(System.String roleId); // 0x05d9b1b4
	System.Void OnListScroll(); // 0x05d9b324
	System.Void TribeInfosChangeNotify(); // 0x05d9b5c8
	System.Void OnEnable(System.Boolean isMultiple, System.Int32 multiLimitCount, WizardGames.Soc.SocClient.Ui.ECommonInviteOperation operation, System.String param); // 0x05d9b62c
	System.Void OnDisable(); // 0x05d9b950
	System.Void CheckUnionLevel(FairyGUI.GButton btn, System.Int32 roleLevel); // 0x05d99fa8
	System.Void <ReqMemberInfos>b__23_0(SimpleJSON.JSONArray jsonArray); // 0x05d9ba48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InviteTribeMemberPanel.<>c__DisplayClass15_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.InviteTribeMemberPanel <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.UiCommonInvite uiCommonInvite; // 0x18
	System.Action<System.Collections.Generic.List<System.String>> doAction; // 0x20
	System.Void .ctor(); // 0x05d98fd0
	System.Void <.ctor>b__0(); // 0x05d9bc88
	System.Void <.ctor>b__1(FairyGUI.EventContext ctx); // 0x05d9bd40
	System.Void <.ctor>b__2(FairyGUI.EventContext ctx); // 0x05d9bdf8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InviteTribeMemberPanel.<>c__DisplayClass16_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.InviteTribeMemberPanel <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.InviteTribeMemberRowInfo rowInfo; // 0x18
	System.Void .ctor(); // 0x05d99914
	System.Void <RenderListItem>b__0(); // 0x05d9bed8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InviteTribeMemberPanel.<>c__DisplayClass16_1 : System.Object
{
	System.String roleId; // 0x10
	FairyGUI.GButton btnInvite; // 0x18
	WizardGames.Soc.SocClient.Ui.InviteTribeMemberPanel.<>c__DisplayClass16_0 CS$<>8__locals1; // 0x20
	System.Void .ctor(); // 0x05d99f40
	System.Void <RenderListItem>b__1(FairyGUI.EventContext ctx); // 0x05d9bf54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InviteTribeMemberPanel.<>c__DisplayClass19_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.InviteTribeMemberPanel <>4__this; // 0x10
	System.String roleId; // 0x18
	FairyGUI.GButton btnCheckBox; // 0x20
	System.Void .ctor(); // 0x05d9afd4
	System.Void <RenderCheckBoxItem>b__0(FairyGUI.EventContext ctx); // 0x05d9c160
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InviteUnionMemberPanel : System.Object
{
	FairyGUI.GList glist; // 0x10
	FairyGUI.Controller numStatusCtrl; // 0x18
	FairyGUI.Controller typeCtrl; // 0x20
	System.Boolean isMultiSelect; // 0x28
	System.Int32 multiLimitCount; // 0x2c
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UnionMember> memberInfos; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UnionMember> showMemberInfos; // 0x38
	System.Collections.Generic.List<System.UInt64> invitedMembers; // 0x40
	System.Action<System.Collections.Generic.List<System.String>> doAction; // 0x48
	WizardGames.Soc.SocClient.Ui.UiCommonInvite uiCommonInvite; // 0x50
	WizardGames.Soc.SocClient.Ui.ComFriendSearch comFriendSearch; // 0x58
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiCommonInvite uiCommonInvite, FairyGUI.GComponent root, System.Action<System.Collections.Generic.List<System.String>> doAction); // 0x05d9c248
	System.Void RenderListItem(System.Int32 index, FairyGUI.GObject obj); // 0x05d9c7d4
	System.Void OnCheckBoxClick(FairyGUI.GButton btn, System.String roleId); // 0x05d9d3a8
	System.Boolean IsGrayed(System.String roleId); // 0x05d9d2cc
	System.Void OnSearchFriend(System.String keyword); // 0x05d9d520
	System.Void OnClearSearch(); // 0x05d9dc8c
	System.Void OnEnable(System.Boolean isMultiSelect, System.Int32 multiLimitCount); // 0x05d9df5c
	System.Void RefreshList(); // 0x05d9db94
	System.Void <OnEnable>b__21_0(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UnionMember> memberInfos); // 0x05d9e0b0
	System.Void <OnEnable>b__21_1(SimpleJSON.JSONArray info); // 0x05d9e454
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InviteUnionMemberPanel.<>c__DisplayClass14_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiCommonInvite uiCommonInvite; // 0x10
	WizardGames.Soc.SocClient.Ui.InviteUnionMemberPanel <>4__this; // 0x18
	System.Action<System.Collections.Generic.List<System.String>> doAction; // 0x20
	System.Void .ctor(); // 0x05d9c76c
	System.Void <.ctor>b__0(FairyGUI.EventContext ctx); // 0x05d9e848
	System.Void <.ctor>b__1(FairyGUI.EventContext ctx); // 0x05d9e900
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InviteUnionMemberPanel.<>c__DisplayClass15_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.InviteUnionMemberPanel <>4__this; // 0x10
	System.UInt64 roleId; // 0x18
	System.Void .ctor(); // 0x05d9d194
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InviteUnionMemberPanel.<>c__DisplayClass15_1 : System.Object
{
	FairyGUI.GButton btnCheckBox; // 0x10
	WizardGames.Soc.SocClient.Ui.InviteUnionMemberPanel.<>c__DisplayClass15_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x05d9d1fc
	System.Void <RenderListItem>b__0(FairyGUI.EventContext ctx); // 0x05d9e9e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InviteUnionMemberPanel.<>c__DisplayClass15_2 : System.Object
{
	FairyGUI.GButton btnInvite; // 0x10
	WizardGames.Soc.SocClient.Ui.InviteUnionMemberPanel.<>c__DisplayClass15_0 CS$<>8__locals2; // 0x18
	System.Void .ctor(); // 0x05d9d264
	System.Void <RenderListItem>b__1(FairyGUI.EventContext ctx); // 0x05d9eae8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ShareToChannelPanel : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonInvite.ComShareChannelBinder channelBinder; // 0x10
	System.Action<System.String> doAction; // 0x18
	System.Collections.Generic.List<System.String> sharedChannelIds; // 0x20
	WizardGames.Soc.SocClient.Ui.UiShareToChat uiShareToChat; // 0x28
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.ShareToChannelSubList> subListObj; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.SocClient.EChatCategory> chatCategoryList; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.SocClient.EChatCategory> showChatCategoryList; // 0x40
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiShareToChat uiShareToChat, FairyGUI.GComponent root, System.Collections.Generic.List<WizardGames.Soc.SocClient.EChatCategory> chatCategories, System.Action<System.String> doAction); // 0x05d9ed14
	System.Void GetRealCategoryList(System.Collections.Generic.List<WizardGames.Soc.SocClient.EChatCategory> chatCategories); // 0x05d9f1d8
	System.Void RenderListItem(System.Int32 index, FairyGUI.GObject obj); // 0x05d9f37c
	System.Void OnClickShare(System.String channelId); // 0x05d9fb4c
	System.Boolean IsShared(System.String channleId); // 0x05d9fc0c
	System.Void RefreshCategoryList(); // 0x05d9fcb0
	System.Void OnEnable(System.Collections.Generic.List<WizardGames.Soc.SocClient.EChatCategory> chatCategories); // 0x05d9fd84
	System.Void OnDisable(); // 0x05da0064
	System.Void SortChatCategoryList(); // 0x05d9fe10
	System.Boolean CheckChatCategoryValid(WizardGames.Soc.SocClient.EChatCategory category); // 0x05da00c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ShareToChannelSubList : System.Object
{
	WizardGames.Soc.SocClient.EChatCategory chatCategory; // 0x10
	WizardGames.Soc.SocClient.Ui.ShareToChannelPanel shareToChannelPanel; // 0x18
	FairyGUI.GList subList; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.EChatChannelType> teamChat; // 0x28
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.ShareToChannelPanel shareToChannel, FairyGUI.GList subList, WizardGames.Soc.SocClient.EChatCategory chatCategory); // 0x05d9f690
	System.Void OnRenderSubItem(System.Int32 index, FairyGUI.GObject obj); // 0x05da03c8
	System.String GetBtnTitle(System.Boolean isShared); // 0x05da1c94
	System.String RenderTeamTypeItem(WizardGames.Soc.SocClient.Ui.Binder.CommonInvite.ComChannelContentBinder binder, System.Int32 index); // 0x05da0968
	System.String RenderUnionTypeItem(WizardGames.Soc.SocClient.Ui.Binder.CommonInvite.ComChannelContentBinder binder); // 0x05da0e94
	System.String RenderTribeTypeItem(WizardGames.Soc.SocClient.Ui.Binder.CommonInvite.ComChannelContentBinder binder, System.Int32 index); // 0x05da131c
	System.String RenderWorldTypeItem(WizardGames.Soc.SocClient.Ui.Binder.CommonInvite.ComChannelContentBinder binder); // 0x05da1964
	System.Void UpdateSubList(WizardGames.Soc.SocClient.EChatCategory curCategroy); // 0x05d9f800
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ShareToChannelSubList.<>c__DisplayClass5_0 : System.Object
{
	System.Boolean isShared; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonInvite.ComChannelContentBinder channelContentBinder; // 0x18
	WizardGames.Soc.SocClient.Ui.ShareToChannelSubList <>4__this; // 0x20
	System.String channelId; // 0x28
	System.Void .ctor(); // 0x05da0900
	System.Void <OnRenderSubItem>b__0(FairyGUI.EventContext ctx); // 0x05da1d50
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ShareToFriendPanel : System.Object
{
	FairyGUI.GList glist; // 0x10
	FairyGUI.Controller numStatusCtrl; // 0x18
	FairyGUI.Controller typeCtrl; // 0x20
	System.Action<System.String> doAction; // 0x28
	System.Collections.Generic.List<LobbyFriend.FriendInfo> friendInfos; // 0x30
	WizardGames.Soc.SocClient.Ui.UiShareToChat uiShareToChat; // 0x38
	System.Collections.Generic.List<LobbyFriend.FriendInfo> showFriendInfos; // 0x40
	WizardGames.Soc.SocClient.Ui.ComFriendSearch comFriendSearch; // 0x48
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiShareToChat uiShareToChat, FairyGUI.GComponent root, System.Action<System.String> doAction); // 0x05da1ec0
	System.Void ShowFriendList(); // 0x05da220c
	System.Void OnSearchFriend(System.String keyword); // 0x05da2634
	System.Void OnClearSearch(); // 0x05da29cc
	System.Void RefreshList(); // 0x05da2548
	System.Void RenderListItem(System.Int32 index, FairyGUI.GObject obj); // 0x05da2a94
	System.String GetBtnTitle(System.Boolean isShared); // 0x05da37dc
	System.Boolean IsShared(System.String roleId); // 0x05da3738
	System.Void OnEnable(); // 0x05da3898
	System.Void OnDisable(); // 0x05da3928
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ShareToFriendPanel.<>c__DisplayClass14_0 : System.Object
{
	System.Boolean shared; // 0x10
	WizardGames.Soc.SocClient.Ui.ShareToFriendPanel <>4__this; // 0x18
	System.String roleId; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.CommonInvite.ComFriendItemBinder friendBinder; // 0x28
	System.Void .ctor(); // 0x05da36d0
	System.Void <RenderListItem>b__0(FairyGUI.EventContext ctx); // 0x05da3988
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ShareTribePanel : System.Object
{
	static SocLogger logger; // 0x0
	FairyGUI.GList glist; // 0x10
	FairyGUI.Controller statusCtrl; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeInfo> infos; // 0x20
	System.String teamId; // 0x28
	WizardGames.Soc.SocClient.Ui.ERecruitType eRecruitType; // 0x30
	WizardGames.Soc.SocClient.Ui.ETeamType eTeamType; // 0x34
	System.Collections.Generic.List<FairyGUI.GButton> cdButtons; // 0x38
	System.Int64 timerId; // 0x40
	System.Int32 leftTime; // 0x48
	System.Void .ctor(FairyGUI.GComponent root); // 0x05da3bd0
	System.Void RefreshList(); // 0x05da3dc8
	System.Void RenderListItem(System.Int32 index, FairyGUI.GObject obj); // 0x05da3f30
	System.Void SetCdTimer(); // 0x05da45fc
	System.Void OnEnable(System.String teamId, WizardGames.Soc.SocClient.Ui.ERecruitType eRecruitType); // 0x05da479c
	System.Void OnDisable(); // 0x05da48e0
	System.Void ClearTimer(); // 0x05da4a0c
	static System.Void .cctor(); // 0x05da4b14
	System.Void <SetCdTimer>b__13_0(System.Int64 _, System.Object _, System.Boolean delete); // 0x05da4be8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ShareTribePanel.<>c__DisplayClass12_0 : System.Object
{
	FairyGUI.GButton shareBtn; // 0x10
	WizardGames.Soc.SocClient.Ui.ShareTribePanel <>4__this; // 0x18
	FairyGUI.GComponent item; // 0x20
	System.String tribeId; // 0x28
	System.Void .ctor(); // 0x05da4594
	System.Void <RenderListItem>b__0(FairyGUI.EventContext ctx); // 0x05da4fb8
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ECommonInviteOperation : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ECommonInviteOperation JoinTribe = 0;
	static WizardGames.Soc.SocClient.Ui.ECommonInviteOperation JoinTeam = 1;
	static WizardGames.Soc.SocClient.Ui.ECommonInviteOperation JoinUnion = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonInvite : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	System.Action<System.Collections.Generic.List<System.String>,System.String> itemClickAction; // 0x338
	System.String teamChangeEntrance; // 0x340
	System.Boolean isMultiSelect; // 0x348
	System.Int32 multiLimitCount; // 0x34c
	FairyGUI.Controller tagCtrl; // 0x350
	FairyGUI.GList leftBarList; // 0x358
	WizardGames.Soc.SocClient.Ui.ECommonInviteOperation inviteOperation; // 0x360
	System.String param; // 0x368
	WizardGames.Soc.SocClient.Ui.InviteTribeMemberPanel inviteTribeMemberPanel; // 0x370
	WizardGames.Soc.SocClient.Ui.InviteFriendPanel inviteFriendPanel; // 0x378
	WizardGames.Soc.SocClient.Ui.InvitePlayWithPanel invitePlayWithPanel; // 0x380
	WizardGames.Soc.SocClient.Ui.InviteSelfRecommendPanel inviteSelfRecommendPanel; // 0x388
	WizardGames.Soc.SocClient.Ui.InviteUnionMemberPanel inviteUnionMenberPanel; // 0x390
	System.Collections.Generic.HashSet<System.String> SelectedList; // 0x398
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiCommonInvite.ELeftTab> eLeftTabs; // 0x3a0
	System.Void OnInit(); // 0x05da5490
	System.Void SetData(WizardGames.Soc.SocClient.Ui.ECommonInviteOperation operation, System.Action<System.Collections.Generic.List<System.String>,System.String> action, System.String param, System.Int32 multiLimitCount, System.Boolean isMulti, System.Nullable<WizardGames.Soc.SocClient.Ui.UiCommonInvite.ELeftTab> initialTab); // 0x05da62b4
	System.Void InitLeftBarList(); // 0x05da57a8
	System.Boolean HideFindTeammate(); // 0x05da6d9c
	System.Void ChangeTab(WizardGames.Soc.SocClient.Ui.UiCommonInvite.ELeftTab tab); // 0x05da63b8
	System.Void OnEnable(); // 0x05da7170
	System.Void OnDisable(); // 0x05da7274
	static System.Void OpenWindow(WizardGames.Soc.SocClient.Ui.ECommonInviteOperation operation, System.Action<System.Collections.Generic.List<System.String>,System.String> action, System.String param, System.Boolean isMulti, System.Int32 multiLimitCount, System.Collections.Generic.List<System.String> alreadySelectIds, System.Nullable<WizardGames.Soc.SocClient.Ui.UiCommonInvite.ELeftTab> initialTab); // 0x05da73b8
	static System.Void CloseWindow(); // 0x05da7604
	System.String EleftTab2Name(WizardGames.Soc.SocClient.Ui.UiCommonInvite.ELeftTab tab); // 0x05da6fbc
	System.Boolean CheckPlatForm(); // 0x05da6c78
	System.Void .ctor(); // 0x05da76b4
	System.Void <OnInit>b__16_0(FairyGUI.EventContext ctx); // 0x05da7794
	System.Void <ChangeTab>b__20_0(System.Collections.Generic.List<System.String> list); // 0x05da7810
	System.Void <ChangeTab>b__20_1(System.Collections.Generic.List<System.String> list); // 0x05da78c4
	System.Void <ChangeTab>b__20_2(System.Collections.Generic.List<System.String> list); // 0x05da7978
	System.Void <ChangeTab>b__20_3(System.Collections.Generic.List<System.String> list); // 0x05da7a18
	System.Void <ChangeTab>b__20_4(System.Collections.Generic.List<System.String> list); // 0x05da7acc
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiCommonInvite.ELeftTab : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiCommonInvite.ELeftTab Friend = 0;
	static WizardGames.Soc.SocClient.Ui.UiCommonInvite.ELeftTab FindTeammate = 1;
	static WizardGames.Soc.SocClient.Ui.UiCommonInvite.ELeftTab Tribe = 2;
	static WizardGames.Soc.SocClient.Ui.UiCommonInvite.ELeftTab TempFriend = 3;
	static WizardGames.Soc.SocClient.Ui.UiCommonInvite.ELeftTab PlayWith = 4;
	static WizardGames.Soc.SocClient.Ui.UiCommonInvite.ELeftTab ShareChannel = 5;
	static WizardGames.Soc.SocClient.Ui.UiCommonInvite.ELeftTab Union = 6;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonInvite.<>c__DisplayClass18_0 : System.Object
{
	System.Int32 i1; // 0x10
	WizardGames.Soc.SocClient.Ui.UiCommonInvite <>4__this; // 0x18
	System.Void .ctor(); // 0x05da6f54
	System.Void <InitLeftBarList>b__0(FairyGUI.EventContext ctx); // 0x05da7b80
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonInvite.<>c__DisplayClass23_0 : System.Object
{
	System.Collections.Generic.List<System.String> alreadySelectIds; // 0x10
	WizardGames.Soc.SocClient.Ui.ECommonInviteOperation operation; // 0x18
	System.Action<System.Collections.Generic.List<System.String>,System.String> action; // 0x20
	System.String param; // 0x28
	System.Int32 multiLimitCount; // 0x30
	System.Boolean isMulti; // 0x34
	System.Nullable<WizardGames.Soc.SocClient.Ui.UiCommonInvite.ELeftTab> initialTab; // 0x38
	System.Void .ctor(); // 0x05da759c
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiCommonInvite win); // 0x05da7c30
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonShare : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.Controller tagCtrl; // 0x338
	FairyGUI.GList leftBarList; // 0x340
	WizardGames.Soc.SocClient.Ui.ShareTribePanel shareTribePanel; // 0x348
	System.String teamId; // 0x350
	WizardGames.Soc.SocClient.Ui.ERecruitType eRecruitType; // 0x358
	System.Void OnInit(); // 0x05da7d24
	System.Void SetShareTeamId(System.String teamId, WizardGames.Soc.SocClient.Ui.ERecruitType eRecruitType); // 0x05da8410
	System.Void InitLeftBarList(); // 0x05da8000
	System.Void ChangeTab(WizardGames.Soc.SocClient.Ui.UiCommonShare.ELeftTab tab); // 0x05da84a8
	System.Void OnEnable(); // 0x05da8768
	System.Void OnDisable(); // 0x05da87d0
	static System.Void OpenWindow(System.String teamId, WizardGames.Soc.SocClient.Ui.ERecruitType eRecruitType); // 0x05da8868
	static System.Void CloseWindow(); // 0x05da8a44
	System.String EleftTab2Name(WizardGames.Soc.SocClient.Ui.UiCommonShare.ELeftTab tab); // 0x05da8698
	System.Void .ctor(); // 0x05da8af4
	System.Void <OnInit>b__6_0(FairyGUI.EventContext ctx); // 0x05da8b80
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiCommonShare.ELeftTab : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiCommonShare.ELeftTab Tribe = 0;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonShare.<>c__DisplayClass12_0 : System.Object
{
	System.String teamId; // 0x10
	WizardGames.Soc.SocClient.Ui.ERecruitType eRecruitType; // 0x18
	System.Void .ctor(); // 0x05da89dc
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiCommonShare win); // 0x05da8bfc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonShare.<>c__DisplayClass8_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiCommonShare.ELeftTab i; // 0x10
	WizardGames.Soc.SocClient.Ui.UiCommonShare <>4__this; // 0x18
	System.Void .ctor(); // 0x05da8630
	System.Void <InitLeftBarList>b__0(FairyGUI.EventContext ctx); // 0x05da8c84
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelfRecommend : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	SocLogger log; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComSelfBinder binder; // 0x340
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x348
	WizardGames.Soc.SocClient.Ui.ComInputBox inputDesc; // 0x350
	System.Collections.Generic.HashSet<System.Int32> selectedSkilledIds; // 0x358
	System.Int32 selectedModeId; // 0x360
	System.Collections.Generic.List<System.Int32> currentRemarkOptionIds; // 0x368
	System.Int32 maxLength; // 0x370
	System.Int32 firstSkilledOptionId; // 0x374
	System.Void OnInit(); // 0x05da8d08
	System.Void InitPanel(); // 0x05da963c
	System.Void LoadDefaultPreferences(); // 0x05da96c0
	System.Void InitModalBtnInfos(); // 0x05da97d8
	System.Void InitRemarkNode(); // 0x05da9ad8
	System.Void InitSkilledNode(); // 0x05daa274
	System.Void InitExchangeNode(); // 0x05daa9b0
	System.Void OnRemarkItemClick(System.Int32 optionId, FairyGUI.GButton btn); // 0x05dab4f4
	System.Void OnSkilledItemClick(System.Int32 optionId, FairyGUI.GButton btn); // 0x05dabb2c
	System.Void OnExchangeItemClick(System.Int32 modeId, FairyGUI.GButton btn); // 0x05dac0b0
	System.Void UpdateSkilledTitle(); // 0x05dab178
	System.Void OnChangeDescWordsInput(); // 0x05da91b0
	System.Void OnSendClick(); // 0x05dac2e0
	System.Void SendSelfRecommend(System.String declaration, System.Collections.Generic.List<System.Int32> skilledIds, System.Int32 modeId); // 0x05dac814
	System.Void SavePreferenceListToMgrLobbyTeam(System.Collections.Generic.List<System.Int32> preferenceIds); // 0x05dad140
	static System.Void OpenWindow(); // 0x05dad49c
	System.String NormalizeRemarkFormat(System.String text); // 0x05dab9a0
	System.String GetPreferenceDisplayName(System.Int32 optionId); // 0x05dad628
	System.Collections.Generic.List<System.String> BuildPreferenceNameList(System.Collections.Generic.List<System.Int32> ids); // 0x05dad23c
	System.Void .ctor(); // 0x05dad790
	System.Void <InitModalBtnInfos>b__12_0(); // 0x05dad970
	System.Void <InitModalBtnInfos>b__12_1(); // 0x05dad9e4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelfRecommend.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiSelfRecommend.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.UiSelfRecommend> <>9__24_0; // 0x8
	static System.Void .cctor(); // 0x05dada48
	System.Void .ctor(); // 0x05dadaac
	System.Void <OpenWindow>b__24_0(WizardGames.Soc.SocClient.Ui.UiSelfRecommend win); // 0x05dadb14
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelfRecommend.<>c__DisplayClass13_0 : System.Object
{
	System.Int32 optionId; // 0x10
	FairyGUI.GButton btn; // 0x18
	WizardGames.Soc.SocClient.Ui.UiSelfRecommend <>4__this; // 0x20
	System.Void .ctor(); // 0x05dab040
	System.Void <InitRemarkNode>b__0(FairyGUI.EventContext ctx); // 0x05dadb9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelfRecommend.<>c__DisplayClass14_0 : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.team.OBJPreferenceOption> dataList; // 0x10
	WizardGames.Soc.SocClient.Ui.UiSelfRecommend <>4__this; // 0x18
	System.Void .ctor(); // 0x05dab0a8
	System.Int32 <InitSkilledNode>b__0(System.Int32 a, System.Int32 b); // 0x05dadc24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelfRecommend.<>c__DisplayClass14_1 : System.Object
{
	FairyGUI.GButton btn; // 0x10
	WizardGames.Soc.Common.Data.team.OBJPreferenceOption option; // 0x18
	WizardGames.Soc.SocClient.Ui.UiSelfRecommend.<>c__DisplayClass14_0 CS$<>8__locals1; // 0x20
	System.Void .ctor(); // 0x05dab110
	System.Void <InitSkilledNode>b__1(FairyGUI.EventContext ctx); // 0x05dadcf8
	System.Void <InitSkilledNode>b__2(FairyGUI.EventContext ctx); // 0x05dadd90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelfRecommend.<>c__DisplayClass15_0 : System.Object
{
	FairyGUI.GButton btn; // 0x10
	System.Int32 modeIdCfg; // 0x18
	WizardGames.Soc.SocClient.Ui.UiSelfRecommend <>4__this; // 0x20
	System.Void .ctor(); // 0x05dab48c
	System.Void <InitExchangeNode>b__0(FairyGUI.EventContext ctx); // 0x05dade28
	System.Void <InitExchangeNode>b__1(FairyGUI.EventContext ctx); // 0x05dadeb0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelfRecommend.<>c__DisplayClass22_0 : System.Object
{
	System.String targetChannelId; // 0x10
	System.String dataStr; // 0x18
	System.Void .ctor(); // 0x05dad0d8
	System.Void <SendSelfRecommend>b__0(WizardGames.Soc.SocClient.Ui.UiChat chatWin); // 0x05dadf38
	System.Void <SendSelfRecommend>b__1(); // 0x05dae10c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiShareToChat : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.ClientChatShareInfo shareInfo; // 0x338
	FairyGUI.Controller tagCtrl; // 0x340
	FairyGUI.GList leftBarList; // 0x348
	WizardGames.Soc.SocClient.Ui.ShareToFriendPanel shareToFriendPanel; // 0x350
	WizardGames.Soc.SocClient.Ui.ShareToChannelPanel shareToChannelPanel; // 0x358
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiCommonInvite.ELeftTab> eLeftTabs; // 0x360
	System.Collections.Generic.HashSet<System.String> SelectedChannelIdList; // 0x368
	System.Collections.Generic.List<WizardGames.Soc.SocClient.EChatCategory> eChatCategories; // 0x370
	System.Action<System.String> onShareAction; // 0x378
	System.Void OnInit(); // 0x05dae1ec
	System.Void InitLeftBarList(); // 0x05dae504
	System.String EleftTab2Name(WizardGames.Soc.SocClient.Ui.UiCommonInvite.ELeftTab tab); // 0x05dae970
	System.Void ChangeTab(WizardGames.Soc.SocClient.Ui.UiCommonInvite.ELeftTab tab); // 0x05daea6c
	System.Void OnClickShare(System.String channelId); // 0x05daed7c
	WizardGames.Soc.SocClient.Ui.UiCommonInvite.ELeftTab GetChildrenIndex(WizardGames.Soc.SocClient.Ui.UiCommonInvite.ELeftTab tab); // 0x05dae8f4
	System.Void OnEnable(); // 0x05daee54
	System.Void OnDisable(); // 0x05daeebc
	static System.Void OpenWindow(WizardGames.Soc.SocClient.ClientChatShareInfo shareInfo, System.Collections.Generic.List<WizardGames.Soc.SocClient.EChatCategory> chatCategories, System.Nullable<WizardGames.Soc.SocClient.Ui.UiCommonInvite.ELeftTab> initTab, System.Action<System.String> onClickAction); // 0x05daef4c
	System.Void SetData(WizardGames.Soc.SocClient.ClientChatShareInfo shareInfo, System.Collections.Generic.List<WizardGames.Soc.SocClient.EChatCategory> chatCategories, System.Nullable<WizardGames.Soc.SocClient.Ui.UiCommonInvite.ELeftTab> initTab, System.Action<System.String> onClickAction); // 0x05daf160
	System.Void .ctor(); // 0x05daf2b4
	System.Void <OnInit>b__9_0(FairyGUI.EventContext ctx); // 0x05daf4f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiShareToChat.<>c__DisplayClass10_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiCommonInvite.ELeftTab i; // 0x10
	WizardGames.Soc.SocClient.Ui.UiShareToChat <>4__this; // 0x18
	System.Void .ctor(); // 0x05dae88c
	System.Void <InitLeftBarList>b__0(FairyGUI.EventContext ctx); // 0x05daf574
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiShareToChat.<>c__DisplayClass18_0 : System.Object
{
	WizardGames.Soc.SocClient.ClientChatShareInfo shareInfo; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.EChatCategory> chatCategories; // 0x18
	System.Nullable<WizardGames.Soc.SocClient.Ui.UiCommonInvite.ELeftTab> initTab; // 0x20
	System.Action<System.String> onClickAction; // 0x28
	System.Void .ctor(); // 0x05daf0f8
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiShareToChat win); // 0x05daf5f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTendencyModify : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	SocLogger log; // 0x338
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x340
	FairyGUI.GLabel titleLabel; // 0x348
	FairyGUI.GList booklist; // 0x350
	System.Collections.Generic.HashSet<System.Int32> selectedPreferenceIds; // 0x358
	System.Collections.Generic.HashSet<System.Int32> originalPreferenceIds; // 0x360
	FairyGUI.GButton confirmBtn; // 0x368
	System.Int32 maxCount; // 0x370
	System.Int32 firstPreferenceOptionId; // 0x374
	System.Void OnInit(); // 0x05daf680
	System.Void InitPanel(); // 0x05daf9a4
	System.Void LoadPlayerPreferences(); // 0x05dafa18
	System.Void InitPreferenceList(); // 0x05dafc4c
	System.Void OnPreferenceItemClick(System.Int32 optionId, FairyGUI.GButton btn); // 0x05db08c8
	System.Void UpdatePreferenceTitle(); // 0x05db0788
	System.Void UpdateConfirmButtonState(); // 0x05db0c44
	System.Void InitModalBtnInfos(); // 0x05db0338
	System.Void OnConfirmClick(); // 0x05db0de8
	System.Void SavePreferences(); // 0x05db0ef8
	System.Void SavePreferenceListToMgrLobbyTeam(); // 0x05db1230
	static System.Void OpenWindow(); // 0x05db1584
	System.Void .ctor(); // 0x05db1710
	System.Void <InitModalBtnInfos>b__18_0(); // 0x05db18bc
	System.Void <InitModalBtnInfos>b__18_1(); // 0x05db1930
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTendencyModify.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiTendencyModify.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.UiTendencyModify> <>9__22_0; // 0x8
	static System.Void .cctor(); // 0x05db1994
	System.Void .ctor(); // 0x05db19f8
	System.Void <OpenWindow>b__22_0(WizardGames.Soc.SocClient.Ui.UiTendencyModify win); // 0x05db1a60
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTendencyModify.<>c__DisplayClass14_0 : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.team.OBJPreferenceOption> dataList; // 0x10
	WizardGames.Soc.SocClient.Ui.UiTendencyModify <>4__this; // 0x18
	System.Void .ctor(); // 0x05db06b8
	System.Int32 <InitPreferenceList>b__0(System.Int32 a, System.Int32 b); // 0x05db1af0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTendencyModify.<>c__DisplayClass14_1 : System.Object
{
	FairyGUI.GButton btn; // 0x10
	WizardGames.Soc.Common.Data.team.OBJPreferenceOption option; // 0x18
	WizardGames.Soc.SocClient.Ui.UiTendencyModify.<>c__DisplayClass14_0 CS$<>8__locals1; // 0x20
	System.Void .ctor(); // 0x05db0720
	System.Void <InitPreferenceList>b__1(FairyGUI.EventContext ctx); // 0x05db1bc4
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.SouDJRankInfo : System.ValueType
{
	System.Int32 Rank; // 0x10
	System.String Name; // 0x18
	System.Int32 Score; // 0x20
	System.Int32 Honour; // 0x24
	System.String Icon; // 0x28
	System.Int64 TeamEntityId; // 0x30
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.SouDJRankRewardInfo : System.ValueType
{
	System.Int32 Rank; // 0x10
	System.Int32 InGameReward; // 0x14
	System.Int32 OutGameReward; // 0x18
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.SouDJRankRewardDetailData : System.ValueType
{
	System.Int64 ItemId; // 0x10
	System.Int32 Amount; // 0x18
	System.Void .ctor(System.Int64 itemId, System.Int32 amount); // 0x05db1c5c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonRank : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update, WizardGames.Soc.SocClient.Ui.IJumpToUIWindow
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonRank.RootRankBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.CommonRank.UiRankBinder uiRankBinder; // 0x340
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x348
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x350
	System.Int32 selectedTabIndex; // 0x358
	System.Int32 selectedSubTabIndex; // 0x35c
	System.Int32 currentPage; // 0x360
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SouDJRankInfo> rankDataList; // 0x368
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SouDJRankRewardInfo>> rankRewards; // 0x370
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SouDJRankRewardInfo> currentRankRewards; // 0x378
	System.Boolean isLoading; // 0x380
	static System.Int32 JumpToIndex; // 0x0
	static System.Int32 JumpToSubIndex; // 0x4
	System.Int64 currentShowTeamEntityId; // 0x388
	WizardGames.Soc.SocClient.Manager.PreviewScene curPreviewScene; // 0x390
	UnityEngine.GameObject objModelRoot; // 0x398
	UnityEngine.Camera camPlayerModel; // 0x3a0
	UnityEngine.GameObject[] modelRootList; // 0x3a8
	System.Collections.Generic.Dictionary<System.UInt64,WizardGames.Soc.SocClient.Ui.UiCommonRank.RankTeamMember> displayModelDic; // 0x3b0
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.PlayerDisplaySimple> teamDisplayDataList; // 0x3b8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComMyTeamItemInfo> teamUIInfoList; // 0x3c0
	WizardGames.Soc.SocClient.Ui.Binder.CommonRank.RootRankContentBinder get_contentBinder(); // 0x05db1ce0
	WizardGames.Soc.SocClient.Ui.Binder.CommonRank.ComRankingTitleBinder get_titleBinder(); // 0x05db1d84
	WizardGames.Soc.SocClient.Ui.Binder.CommonRank.ComRankingBinder get_rankingBinder(); // 0x05db1e30
	System.Int32 get_curTeamMaxMemberCount(); // 0x05db1edc
	System.Void OnInit(); // 0x05db1f78
	System.Void OnEnable(); // 0x05db386c
	System.Void OnDisable(); // 0x05db3dd0
	System.Void OnDestroy(); // 0x05db4030
	System.Void SetTitle(); // 0x05db2b94
	System.Void OnSubTabListClick(System.Int32 index); // 0x05db4098
	System.Void SetRankHeaderData(); // 0x05db2eec
	System.Void RefreshRankList(); // 0x05db3bf8
	System.Void OnRankItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x05db4dc8
	System.Void UpdateSelfTeamRankInfo(); // 0x055049cc
	System.Void ReadRankRewardData(); // 0x05db27b0
	System.Int32 GetCurrentGroupId(); // 0x05db5698
	System.Void OnRewardItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x05db5780
	System.Void UpdateSelfRankReward(); // 0x05db62f0
	System.Void ShowRankRewardDetail(WizardGames.Soc.SocClient.Ui.Binder.CommonRank.ComRewardBinder binder, System.Int32 rank); // 0x05db5c78
	System.Void GetRankRange(System.Int32 rank, System.Int32& startRank, System.Int32& endRank); // 0x05db5b54
	System.Void GetRankRewards(System.Int32 rank, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SouDJRankRewardDetailData>& inGameRewards, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SouDJRankRewardDetailData>& outGameRewards); // 0x05db6794
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SouDJRankRewardDetailData> GetInGameReward(System.Int32 id); // 0x05db6a3c
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SouDJRankRewardDetailData> GetOutGameReward(System.Int32 id); // 0x05db6e68
	System.Void OnScroll(); // 0x05db716c
	System.Void OnRankListItemClick(FairyGUI.EventContext context); // 0x05db73ac
	System.Boolean IsDailyRank(); // 0x05db4d5c
	System.Void RequestData(System.Int32 pageIndex, System.Boolean isDailyRank); // 0x05db35a4
	System.Void OnSouDJRankListUpdate(System.Boolean isDailyRank); // 0x05db76e0
	System.Void OnSouDJTeamDetailInfoUpdate(System.Int64 teamEntityId); // 0x05db7fa4
	System.Void ShowEmptyState(); // 0x05db3774
	System.Void UpdateRankReward(); // 0x05db4bd0
	System.Void InitTeamUI(); // 0x05db318c
	System.Void ShowMyTeam(); // 0x05db7bc4
	System.Void RefreshCurPreviewScene(); // 0x05db3980
	System.Void RefreshModelInfo(); // 0x05db80fc
	System.Void OnRefreshItemInfo(); // 0x05db7e30
	System.Void SetPlayerComPos(); // 0x05db82ec
	System.Void RefreshModel(); // 0x05db8170
	System.Void CreatePlayModel(System.Int32 index, WizardGames.Soc.Common.SimpleCustom.PlayerDisplaySimple memberInfo); // 0x05db85b8
	System.Void ReleaseAllModels(); // 0x05db7c60
	System.Void ReleaseScene(); // 0x05db3f64
	System.Void MakeFullScreen(); // 0x05db86fc
	WizardGames.Soc.SocClient.GoLoader.DisplayModel CreateModel(UnityEngine.Transform parent, WizardGames.Soc.Common.SimpleCustom.PlayerDisplaySimple memberInfo, System.Int64 defaultModelId); // 0x05db876c
	System.Void RefreshModelCustomizeDataByRoleId(WizardGames.Soc.Common.SimpleCustom.PlayerDisplaySimple memberInfo, WizardGames.Soc.Common.CustomType.PlayerDisplayData displayData, WizardGames.Soc.SocClient.GoLoader.DisplayModel displayModel); // 0x05db8ce8
	System.Void RefreshWeaponDisplayData(WizardGames.Soc.SocClient.GoLoader.DisplayModel displayModel, WizardGames.Soc.Common.SimpleCustom.PlayerDisplaySimple memberInfo, WizardGames.Soc.Common.CustomType.PlayerDisplayData displayData); // 0x05db9028
	System.Void AfterWeaponLoaded(WizardGames.Soc.SocClient.GoLoader.DisplayWeapon weapon, WizardGames.Soc.SocClient.GoLoader.DisplayModel displayModel); // 0x05db9760
	System.Boolean EqualEquipmentDisplayDataList(WizardGames.Soc.Common.CustomType.EquipmentDisplayData data1, WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.EquipmentDisplayData> dataList); // 0x05db8f0c
	System.Boolean EqualEquipmentDisplayData(WizardGames.Soc.Common.CustomType.EquipmentDisplayData data1, WizardGames.Soc.Common.CustomType.EquipmentDisplayData data2); // 0x05db992c
	System.Boolean EqualWeaponDisplayDataList(WizardGames.Soc.Common.CustomType.WeaponDisplayData data1, WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.WeaponDisplayData> dataList); // 0x05db9644
	System.Boolean EqualWeaponDisplayData(WizardGames.Soc.Common.CustomType.WeaponDisplayData data1, WizardGames.Soc.Common.CustomType.WeaponDisplayData data2); // 0x05db9a04
	System.Void ClearModelScene(); // 0x05db3ea4
	System.Void OnFps10Update(System.Single dt); // 0x05db9adc
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05db9c84
	static System.Void OpenWindow(); // 0x05db9d04
	static System.Void OpenWindowToDailyRank(); // 0x05db9df4
	static System.Void OpenWindowToRewardTab(); // 0x05db9f64
	System.Void JumpToUIWindow(WizardGames.Soc.SocClient.Ui.JumpData jumpData); // 0x05dba0e4
	System.Void JumpToOverallRank(); // 0x05dba194
	System.Void JumpToDailyRank(); // 0x05db9efc
	System.Void JumpToRewardTab(); // 0x05dba070
	System.Void JumpToTab(System.Int32 tabIndex); // 0x05dba1fc
	System.Void SetTabs(); // 0x05db2c48
	System.Void LoadTabData(); // 0x05dba3f0
	System.Void LoadSubTabData(); // 0x05dba56c
	System.Void .ctor(); // 0x05dba854
	System.Void <RequestData>b__55_0(System.Object param); // 0x05dbaa34
	System.Void <RefreshCurPreviewScene>b__62_0(UnityEngine.GameObject a, UnityEngine.GameObject b); // 0x05dbab74
	System.Void <SetTabs>b__91_0(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x05dbae04
	System.Void <LoadSubTabData>b__93_0(FairyGUI.EventContext context); // 0x05dbb168
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonRank.RankTeamMember : System.Object
{
	WizardGames.Soc.SocClient.GoLoader.DisplayModel model; // 0x10
	WizardGames.Soc.SocClient.GoLoader.DisplayModel defaultModel; // 0x18
	System.Boolean isSelf; // 0x20
	System.Single startLoadTime; // 0x24
	System.Boolean showRealModel; // 0x28
	UnityEngine.Transform parent; // 0x30
	System.UInt64 roleId; // 0x38
	System.Void .ctor(WizardGames.Soc.Common.SimpleCustom.PlayerDisplaySimple memberInfo, UnityEngine.Transform parent, WizardGames.Soc.SocClient.Ui.UiCommonRank parentView); // 0x05dbb468
	System.Void Release(); // 0x05dbb5bc
	System.Void SetParent(UnityEngine.Transform parent); // 0x05dbb65c
	System.Void Update(System.Single dt); // 0x05dbb708
}
