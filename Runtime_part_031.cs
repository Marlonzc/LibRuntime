	System.Void .ctor(System.Int32 <>1__state); // 0x062f5a44
	System.Void System.IDisposable.Dispose(); // 0x062fcb20
	System.Boolean MoveNext(); // 0x062fcb80
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x062fd46c
	System.Void System.Collections.IEnumerator.Reset(); // 0x062fd4d0
	System.Object System.Collections.IEnumerator.get_Current(); // 0x062fd558
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionBook.<IEPlaySurvivalTransitionsSequentially>d__75 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Ui.UiMissionBook <>4__this; // 0x20
	System.Action finishCb; // 0x28
	WizardGames.Soc.Common.Data.Play.QuestPhase <startCfg>5__2; // 0x30
	WizardGames.Soc.Common.Data.Play.QuestPhase <endCfg>5__3; // 0x38
	System.Int32 <i>5__4; // 0x40
	System.Void .ctor(System.Int32 <>1__state); // 0x062f852c
	System.Void System.IDisposable.Dispose(); // 0x062fd5bc
	System.Boolean MoveNext(); // 0x062fd61c
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x062fe2a0
	System.Void System.Collections.IEnumerator.Reset(); // 0x062fe304
	System.Object System.Collections.IEnumerator.get_Current(); // 0x062fe38c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionBook.<IEPlayTransitionsSequentially>d__46 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Ui.UiMissionBook <>4__this; // 0x20
	System.Int32 <i>5__2; // 0x28
	System.Void .ctor(System.Int32 <>1__state); // 0x062f593c
	System.Void System.IDisposable.Dispose(); // 0x062fe3f0
	System.Boolean MoveNext(); // 0x062fe450
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x062feb28
	System.Void System.Collections.IEnumerator.Reset(); // 0x062feb8c
	System.Object System.Collections.IEnumerator.get_Current(); // 0x062fec14
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionBook.<IEPlayTransitionsSequentially>d__49 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	FairyGUI.GList list; // 0x20
	System.Int32 <i>5__2; // 0x28
	System.Void .ctor(System.Int32 <>1__state); // 0x062f5b80
	System.Void System.IDisposable.Dispose(); // 0x062fec78
	System.Boolean MoveNext(); // 0x062fecd8
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x062fef48
	System.Void System.Collections.IEnumerator.Reset(); // 0x062fefac
	System.Object System.Collections.IEnumerator.get_Current(); // 0x062ff034
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionTrace : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar typeNavBar; // 0x338
	WizardGames.Soc.SocClient.Ui.MissionTraceNavBar detailNavBar; // 0x340
	System.Collections.Generic.List<System.Int32> typeDataLst; // 0x348
	static System.Int32 curTypeTabId; // 0x0
	System.Int32 curFirstTabId; // 0x350
	static System.Int32 curSelectedMissionId; // 0x4
	WizardGames.Soc.SocClient.Ui.Binder.GameLeftPopUp.UiLeftPopUpBinder binder; // 0x358
	FairyGUI.GList missionDescLst; // 0x360
	FairyGUI.GList rewardLst; // 0x368
	System.Collections.Generic.List<System.Int32> dailyTabLst; // 0x370
	System.Collections.Generic.List<System.Int64> dailyMissionDataLst; // 0x378
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Reward> rewardsData; // 0x380
	System.Collections.Generic.List<System.Int64> dailyMissionDescLst; // 0x388
	System.Collections.Generic.List<WizardGames.Soc.SocClient.MainQuestData> mainQuestDescDataLst; // 0x390
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.common.BTuple2> mainQuestRewardList; // 0x398
	System.Collections.Generic.List<WizardGames.Soc.SocClient.MainQuestData> mainQuestTabLst; // 0x3a0
	System.Collections.Generic.List<System.Int32> factionTabDataLst; // 0x3a8
	System.Collections.Generic.List<System.Int32> monumentTabLst; // 0x3b0
	System.Collections.Generic.List<System.Int32> monumentDataLst; // 0x3b8
	System.Collections.Generic.List<System.Int64> newbieDescLst; // 0x3c0
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.PoiTaskNode> poiNodes; // 0x3c8
	System.Collections.Generic.List<System.Int64> treasureDescLst; // 0x3d0
	System.Void OnInit(); // 0x062ff098
	System.Void OnEnable(); // 0x06300b78
	System.Void OnDestroy(); // 0x06300e74
	System.Void RefreshTypeTabs(); // 0x062fffd4
	static System.Void SetJumpInfo(System.Int32 tab, System.Int32 missionId); // 0x06301030
	System.Void RefreshMissionTabs(); // 0x0630072c
	System.Void RefreshMissionDetail(); // 0x06303688
	System.Int32 SortTab(System.Int32 a, System.Int32 b); // 0x06305778
	System.Void OnRenderMissionDescItem(System.Int32 index, FairyGUI.GObject obj); // 0x0630591c
	System.Void OnRenderRewardItem(System.Int32 index, FairyGUI.GObject obj); // 0x0630774c
	System.Void OnMissionTraceIdChanged(); // 0x06308588
	System.Void OnClickTrace(); // 0x063085ec
	System.Void OnClickUntrace(); // 0x06308730
	System.Void OnClickGo(); // 0x06308858
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06308c00
	static System.Void OpenWindow(System.Action<WizardGames.Soc.SocClient.Ui.UiMissionTrace> callBack); // 0x06308d2c
	static System.Void CloseWindow(); // 0x06308b24
	System.Void AddDailyTabData(); // 0x06301aa4
	System.Void FillDailyDetailData(System.Int32 missionId); // 0x06304a30
	System.Void OnRenderDailyDescItem(System.Int32 index, FairyGUI.GObject obj); // 0x06306288
	System.Void OnRenderDailyRewardItem(System.Int32 index, FairyGUI.GObject obj); // 0x06307ca4
	System.Void AddDeadSheepTabData(); // 0x063034c8
	System.Void FillDeadSheepDetailData(System.Int32 missionId); // 0x06305694
	System.Void OnRenderDeadSheepDescItem(System.Int32 index, FairyGUI.GObject obj); // 0x06307520
	System.Void OnRenderDeadSheepRewardItem(System.Int32 index, FairyGUI.GObject obj); // 0x0630850c
	System.Void AddMainQuestTabData(); // 0x063010d4
	System.Void FillMainQuestDetailData(System.Int32 missionId); // 0x063046b4
	System.Void OnRenderMainQuestDescItem(System.Int32 index, FairyGUI.GObject obj); // 0x06305aa8
	System.Void OnRenderMainQuestRewardItem(System.Int32 index, FairyGUI.GObject obj); // 0x063079e8
	System.Int32 CheckShowJumpBtn(WizardGames.Soc.SocClient.MainQuestData curSelectMission); // 0x06308e2c
	System.Void ClickJumpBtn(FairyGUI.EventContext context); // 0x06308f5c
	System.Void AddMonumentTabData(); // 0x063024f0
	System.Void FillMonumentDetailData(System.Int32 taskId); // 0x06304df4
	System.Void OnRenderMonumentDescItem(System.Int32 index, FairyGUI.GObject obj); // 0x0630672c
	System.Void AddNewbieTabData(); // 0x063030b8
	System.Void FillNewbieDetailData(System.Int32 missionId); // 0x06305284
	System.Void OnRenderNewbieDescItem(System.Int32 index, FairyGUI.GObject obj); // 0x063070ac
	System.Void OnRenderNewbieRewardItem(System.Int32 index, FairyGUI.GObject obj); // 0x06308248
	System.Void AddTreasureTabData(); // 0x06302be0
	System.Void FillTreasureDetailData(System.Int32 missionId); // 0x06304f4c
	System.Void OnRenderTreasureDescItem(System.Int32 index, FairyGUI.GObject obj); // 0x06306ad4
	System.Void OnRenderTreasureRewardItem(System.Int32 index, FairyGUI.GObject obj); // 0x06307f84
	System.Void .ctor(); // 0x06309134
	static System.Void .cctor(); // 0x063094bc
	System.Void <OnInit>b__9_0(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x06309508
	System.Void <OnInit>b__9_1(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x06309690
	System.Void <OnEnable>b__10_0(); // 0x06309928
	System.Void <RefreshMissionDetail>b__15_0(System.Object param); // 0x06309fc8
	System.Void <RefreshMissionDetail>b__15_1(System.Object _); // 0x0630a0b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionTrace.<>c__DisplayClass22_0 : System.Object
{
	System.Int32 factionId; // 0x10
	System.Void .ctor(); // 0x0630a524
	System.Void <OnClickGo>b__0(WizardGames.Soc.SocClient.Ui.UiMainQuestDetail win); // 0x0630a58c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionTrace.<>c__DisplayClass33_0 : System.Object
{
	WizardGames.Soc.Common.Data.DataItem.ItemConfig cfg; // 0x10
	FairyGUI.GObject obj; // 0x18
	System.Void .ctor(); // 0x0630a640
	System.Void <OnRenderDailyRewardItem>b__0(WizardGames.Soc.SocClient.Ui.ComBaseIcon baseItemIcon); // 0x0630a6a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionTrace.<>c__DisplayClass45_0 : System.Object
{
	WizardGames.Soc.Common.Data.resource.OBJGenaral cfg; // 0x10
	FairyGUI.GObject obj; // 0x18
	System.Void .ctor(); // 0x0630a7b4
	System.Void <OnRenderMainQuestRewardItem>b__0(WizardGames.Soc.SocClient.Ui.ComBaseIcon baseItemIcon); // 0x0630a81c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionTrace.<>c__DisplayClass58_0 : System.Object
{
	WizardGames.Soc.Common.Data.DataItem.ItemConfig cfg; // 0x10
	FairyGUI.GObject obj; // 0x18
	System.Void .ctor(); // 0x0630a928
	System.Void <OnRenderNewbieRewardItem>b__0(WizardGames.Soc.SocClient.Ui.ComBaseIcon baseItemIcon); // 0x0630a990
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMissionTrace.<>c__DisplayClass64_0 : System.Object
{
	WizardGames.Soc.Common.Data.DataItem.ItemConfig cfg; // 0x10
	FairyGUI.GObject obj; // 0x18
	System.Void .ctor(); // 0x0630aa9c
	System.Void <OnRenderTreasureRewardItem>b__0(WizardGames.Soc.SocClient.Ui.ComBaseIcon baseItemIcon); // 0x0630ab04
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiModerator : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Component.MixingTableComponent Component; // 0x338
	static System.Int64 moderatorLootingId; // 0x8
	static System.Int64 openTargetId; // 0x10
	FairyGUI.GList tabList; // 0x340
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiModerator.TabItemData>> tab2ItemDic; // 0x348
	System.Int32 curSelectTabIdx; // 0x350
	FairyGUI.GList itemList; // 0x358
	System.Int32 curSelectItemIdx; // 0x360
	WizardGames.Soc.SocClient.Ui.UiModerator.ECraftState craftState; // 0x364
	System.Int64 craftTargetItemId; // 0x368
	System.Int32 craftMinCount; // 0x370
	System.Int32 craftMaxCount; // 0x374
	System.Int32 craftCurCount; // 0x378
	System.Int32 craftFinishCount; // 0x37c
	System.Int64 craftStartTime; // 0x380
	System.Int64 craftFinishTime; // 0x388
	System.Single craftLastRemainTime; // 0x390
	System.Int64 opentargetId; // 0x398
	WizardGames.Soc.SocClient.Ui.ComItemIcon selectItemIcon; // 0x3a0
	FairyGUI.GTextField selectItemName; // 0x3a8
	FairyGUI.GTextField selectItemDesc; // 0x3b0
	FairyGUI.GTextField selectItemNumber; // 0x3b8
	FairyGUI.GButton btnDetail; // 0x3c0
	FairyGUI.GTextField selectCraftTimeText; // 0x3c8
	FairyGUI.GList selectCraftMatList; // 0x3d0
	FairyGUI.GComponent selectNumSet; // 0x3d8
	FairyGUI.GButton selectCountReduceBtn; // 0x3e0
	FairyGUI.GButton selectCountAddBtn; // 0x3e8
	FairyGUI.GButton selectCountMaxBtn; // 0x3f0
	FairyGUI.GSlider selectCountSlider; // 0x3f8
	FairyGUI.GComponent craftingInfo; // 0x400
	FairyGUI.GSlider craftTimeSlider; // 0x408
	FairyGUI.GTextField craftRemainTimeText; // 0x410
	FairyGUI.GTextField craftOutputCountTimerText; // 0x418
	FairyGUI.GButton craftEndBtn; // 0x420
	FairyGUI.GButton craftStartBtn; // 0x428
	FairyGUI.GButton pickupBtn; // 0x430
	WizardGames.Soc.SocClient.Ui.ComItemIcon craftOutputItemIcon; // 0x438
	FairyGUI.GTextField craftOutputCountText; // 0x440
	System.Boolean isBpItemRendered; // 0x448
	FairyGUI.Transition[] enableAnimArray; // 0x450
	FairyGUI.Transition[] disableAnimArray; // 0x458
	System.Int64 CraftTimeInfoCbHandle; // 0x460
	static System.String CraftTimeInfoStr; // 0x18
	static System.String UiModeratorStr; // 0x20
	System.Single pickUpClickTime; // 0x468
	WizardGames.Soc.SocClient.Ui.UiModerator.TabItemData get_curTab2ItemData(); // 0x0630ac10
	System.Int64 get_craftTotalTime(); // 0x0630acf4
	static System.Void Open(System.Int64 moderatorEntityId, System.Int64 targetId); // 0x0630ad60
	System.Void .ctor(); // 0x0630afe8
	System.Void OnInit(); // 0x0630b124
	System.Void OnDestroy(); // 0x0630c65c
	System.Void OnEnable(); // 0x0630c710
	System.Void OnDisable(); // 0x0630ce94
	System.Void InitModeratorData(); // 0x0630ca7c
	static System.Void RefreshLootingState(System.Boolean res); // 0x0630e464
	System.Void TryCancelCraftTimeInfo(); // 0x0630d2f8
	System.Void InitTabConstData(); // 0x0630d404
	System.Void SyncCraftState(); // 0x0630db5c
	System.Void InitSelectItemInfoPanel(); // 0x0630b588
	System.Void InitPanelUI(); // 0x0630b1a4
	System.Void InitTypeTab(); // 0x0630dbbc
	System.Void InitBpItem(); // 0x0630c464
	System.Void RenderTabUI(System.Int32 idx, FairyGUI.GObject obj); // 0x0630ec98
	System.Void OnTabClick(FairyGUI.EventContext context); // 0x0630f004
	System.Void UpdateItemUI(System.Int32 preSelectTabIndex, System.Int32 curSelectTabIndex); // 0x0630eb3c
	System.Void RenderItem(System.Int32 idx, FairyGUI.GObject obj); // 0x0630f320
	System.Void OnItemClick(FairyGUI.EventContext context); // 0x0630f8a0
	System.Void RenderCraftMatItem(System.Int32 index, FairyGUI.GObject obj); // 0x0630fb34
	System.Void OnStartCraftSuccess(); // 0x063100ac
	System.Void OnStopCraft(System.Int32 finishCount); // 0x06310118
	System.Void OnCraftFinish(); // 0x063101bc
	System.Void OnPickUpSuccess(); // 0x06310238
	System.Void OnCraftTargetCountChanged(System.Int32 changeCount); // 0x063102a8
	System.Void UpdateItemList(); // 0x0630f1c8
	System.Void UpdateSelectItemInfo(); // 0x0630e724
	System.Void UpdateCraftInfo(); // 0x0630de80
	System.Void UpdateCraftCountInfo(); // 0x0631049c
	System.Void UpdateCraftCountText(); // 0x06310f30
	System.Void UpdateCraftTimeInfo(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x06310cd4
	System.Void StartCraft(); // 0x06311154
	System.Void StopCraft(); // 0x06311364
	System.Void PickUp(); // 0x063113c4
	System.Int32 GetCraftMaxCount(); // 0x06310a8c
	WizardGames.Soc.SocClient.Ui.UiModerator.ECraftValidResult CheckCraftValid(); // 0x0631076c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06311668
	System.Void InActiveClosePanel(); // 0x06311790
	System.Void OnClickOpenDetail(); // 0x063117fc
	System.String GetSecondsStr(System.Int64 ms, System.Boolean isRounding); // 0x063105c8
	System.Void PlayOutputItemAudio(); // 0x0631150c
	static System.Void .cctor(); // 0x0631194c
	System.Void <InitSelectItemInfoPanel>b__65_0(); // 0x06311a78
	System.Void <InitSelectItemInfoPanel>b__65_1(); // 0x06311adc
	System.Void <InitSelectItemInfoPanel>b__65_2(FairyGUI.EventContext ctx); // 0x06311c08
	System.Void <InitSelectItemInfoPanel>b__65_3(FairyGUI.EventContext ctx); // 0x06311c84
	System.Void <InitSelectItemInfoPanel>b__65_4(FairyGUI.EventContext ctx); // 0x06311d00
	System.Void <InitSelectItemInfoPanel>b__65_5(); // 0x06311d7c
	System.Void <InitSelectItemInfoPanel>b__65_6(); // 0x06311de0
	System.Void <InitSelectItemInfoPanel>b__65_7(); // 0x06311e44
	System.Void <OnEscClose>b__91_0(); // 0x06311ea8
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiModerator.TabItemData : System.ValueType
{
	System.Int64 templateId; // 0x10
	System.Int32 catIdx; // 0x18
	System.Boolean unlocked; // 0x1c
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiModerator.ECraftState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiModerator.ECraftState Null = 0;
	static WizardGames.Soc.SocClient.Ui.UiModerator.ECraftState Crafting = 1;
	static WizardGames.Soc.SocClient.Ui.UiModerator.ECraftState Finished = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiModerator.ECraftValidResult : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiModerator.ECraftValidResult Success = 0;
	static WizardGames.Soc.SocClient.Ui.UiModerator.ECraftValidResult BlueprintLocked = 1;
	static WizardGames.Soc.SocClient.Ui.UiModerator.ECraftValidResult MatNotEnough = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiModerator.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiModerator.<>c <>9; // 0x0
	static System.Action<System.Boolean> <>9__54_0; // 0x8
	static System.Comparison<WizardGames.Soc.SocClient.Ui.UiModerator.TabItemData> <>9__63_0; // 0x10
	static System.Void .cctor(); // 0x06311f60
	System.Void .ctor(); // 0x06311fc4
	System.Void <Open>b__54_0(System.Boolean res); // 0x0631202c
	System.Int32 <InitTabConstData>b__63_0(WizardGames.Soc.SocClient.Ui.UiModerator.TabItemData a, WizardGames.Soc.SocClient.Ui.UiModerator.TabItemData b); // 0x06312154
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiModerator.<>c__DisplayClass74_0 : System.Object
{
	WizardGames.Soc.Common.Data.DataItem.ItemConfig matItemCfg; // 0x10
	FairyGUI.GObject obj; // 0x18
	System.Void .ctor(); // 0x06310044
	System.Void <RenderCraftMatItem>b__0(); // 0x06312210
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMoveView : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger Log; // 0x0
	FairyGUI.GGraph touchGraph; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.GameHud.UiMoveViewBinder uiMoveViewBinder; // 0x340
	FairyGUI.GGraph _forbidMoveArea1; // 0x348
	FairyGUI.GGraph _forbidMoveArea2; // 0x350
	WizardGames.Soc.SocClient.Ui.UiHud get_hudWindow(); // 0x0631235c
	WizardGames.Soc.SocClient.Ui.Binder.GameHud.UiMoveViewBinder get_MoveViewBinder(); // 0x06312460
	System.Void OnInit(); // 0x063124c4
	System.Void SetTouchBegin(FairyGUI.EventContext context, System.Object data); // 0x06312b10
	System.Void SetForbidMoveAreaScale(System.Single mulX, System.Single mulY); // 0x06312a4c
	System.Boolean IsInForbidMoveArea(UnityEngine.Vector2 pos); // 0x06313050
	System.Void TouchBegin(FairyGUI.EventContext context); // 0x06312bac
	System.Void ClearTouchHistory(System.Int32 layer); // 0x0631331c
	System.Void .ctor(); // 0x06313414
	static System.Void .cctor(); // 0x063134a0
	System.Void <OnInit>b__12_0(System.Int32 layer); // 0x06313574
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.PopupNoticeType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.PopupNoticeType None = 0;
	static WizardGames.Soc.SocClient.Ui.PopupNoticeType NearbyRespawn = 1;
	static WizardGames.Soc.SocClient.Ui.PopupNoticeType TodayNoNotice = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.NoPopupMsgBoxModel : System.Object
{
	static System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.PopupNoticeType,System.Boolean> popupNoticeDict; // 0x0
	static System.Void SetPopupNotice(WizardGames.Soc.SocClient.Ui.PopupNoticeType type, System.Boolean isShow); // 0x063135f0
	static System.Boolean GetPopupNotice(WizardGames.Soc.SocClient.Ui.PopupNoticeType type); // 0x063136bc
	static System.Void .cctor(); // 0x0631376c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMsgBox : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	SocLogger log; // 0x338
	static System.Int32 <TotalCounter>k__BackingField; // 0x0
	System.Int32 counter; // 0x340
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x348
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComMsgBoxBinder uiBinder; // 0x350
	WizardGames.Soc.SocClient.Ui.UiMsgBoxContent comMsg; // 0x358
	FairyGUI.GButton btnToggleNotice; // 0x360
	static System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Ui.MsgBoxInfo> curQueue; // 0x8
	static System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Ui.MsgBoxInfo> preQueue; // 0x10
	static System.Collections.Generic.HashSet<System.String> msgRepeatRecord; // 0x18
	WizardGames.Soc.SocClient.Ui.MsgBoxInfo curInfo; // 0x368
	WizardGames.Soc.SocClient.Manager.HotKeyAction noAction; // 0x370
	WizardGames.Soc.SocClient.Manager.HotKeyAction okAction; // 0x378
	System.Collections.Generic.List<System.Int32> timeList; // 0x380
	static System.UInt32 msgBoxId; // 0x20
	static System.Int32 get_TotalCounter(); // 0x06313808
	static System.Void set_TotalCounter(System.Int32 value); // 0x06313890
	static System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Ui.MsgBoxInfo> get_uiMsgQueue(); // 0x06313920
	System.Void OnInit(); // 0x063139a8
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06313fb4
	System.Void OnEnable(); // 0x06314164
	System.Void OnDisable(); // 0x063141cc
	System.Void OnClickToggleNotice(); // 0x06314374
	static System.Void CloseByCounter(System.Int32 counter); // 0x06314464
	System.Void OnBtnCloseClick(); // 0x063148f4
	System.Void Close(); // 0x06314560
	static System.UInt32 ShowMsgBox(WizardGames.Soc.SocClient.Ui.MsgBoxInfo info); // 0x06314db8
	static System.Void HideMsgBox(System.UInt32 msgId); // 0x06314f78
	static System.Int32 ShowMsgBoxImmediately(WizardGames.Soc.SocClient.Ui.MsgBoxInfo info); // 0x06315598
	static System.Void ShowQueueInfo(System.Boolean immediately); // 0x06314978
	static System.Void CloseMsgBox(System.Boolean clearQueue); // 0x0631543c
	static System.Void UpdateMsgBoxContent(System.String cotent); // 0x06315b18
	System.Void SetMsgContent(System.String content); // 0x06315c0c
	System.Void SetInfo(WizardGames.Soc.SocClient.Ui.MsgBoxInfo info); // 0x063157c8
	System.Void TrimQueueOnWoundedOrDie(); // 0x06316428
	System.Void OnFps1Update(System.Single dt); // 0x06316864
	System.Void RefreshBtnListCoundownTitle(); // 0x063160f0
	System.Boolean IsStopUpdateByBtnListCountDownTime(); // 0x06316a8c
	System.Void .ctor(); // 0x06316b64
	static System.Void .cctor(); // 0x06316ce4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MsgBoxInfo : System.Object
{
	System.String Title; // 0x10
	System.String Msg; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ModalBtnInfo> BtnList; // 0x20
	System.Boolean HasCloseBtn; // 0x28
	System.Boolean NeedShowNotice; // 0x29
	WizardGames.Soc.SocClient.Ui.PopupNoticeType PopupNoticeType; // 0x2c
	System.String NoticeText; // 0x30
	System.Action NoPopupAction; // 0x38
	System.Int32 NoPopupUseBtnIndex; // 0x40
	System.Action CloseCallback; // 0x48
	System.Action TimerCallback; // 0x50
	System.Boolean AutoCloseOnWoundedOrDie; // 0x58
	System.Single showTime; // 0x5c
	System.String TimerText; // 0x60
	System.Action UpdateMsgContent; // 0x68
	System.UInt32 msgId; // 0x70
	System.Void .ctor(); // 0x06316e10
	System.Void .ctor(System.Int32 msgBoxId, System.Collections.Generic.List<System.Action> callbacks); // 0x06316ef8
	System.Void InvokeNoPopupAction(); // 0x06316024
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMsgBoxContent : System.Object
{
	FairyGUI.GComponent comRoot; // 0x10
	FairyGUI.GTextField textNormal; // 0x18
	FairyGUI.GTextField textShort; // 0x20
	FairyGUI.GTextField textTimer; // 0x28
	System.Void .ctor(FairyGUI.GComponent root); // 0x06313e10
	System.Void SetContent(System.String msg); // 0x06315ca8
	FairyGUI.AlignType GetDynamicAlign(); // 0x063171cc
	System.Void SetTimerContent(System.String timerMsg); // 0x063169c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiNewbieCG : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyNewbieCG.UiNewbieCGBinder uiNewbieCGBinder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComVideo videoPlayer; // 0x340
	System.String videoName; // 0x348
	System.Action closeCb; // 0x350
	System.Int64 delayShowCloseBtnTimerID; // 0x358
	System.Void MakeFullScreen(); // 0x06317248
	System.Void OnInit(); // 0x0631731c
	System.Void InitNewBieCgUi(); // 0x06317394
	System.Void RegisterSkipBtnAction(); // 0x063176bc
	System.Void OnEnable(); // 0x06317868
	System.Void OnDisable(); // 0x06317fc8
	System.Void OnDestroy(); // 0x063183f8
	System.Void PlayVideo(); // 0x06317a94
	static WizardGames.Soc.SocClient.Ui.UiNewbieCG OpenWindow(System.Action<WizardGames.Soc.SocClient.Ui.UiNewbieCG> cb); // 0x06318534
	static System.Void CloseWindow(); // 0x0631860c
	static WizardGames.Soc.SocClient.Ui.UiNewbieCG GetWindow(); // 0x06318680
	System.Void SkipBtnDelayShow(); // 0x06317ce4
	System.Void OnSkipBtnClick(); // 0x06318740
	System.Void .ctor(); // 0x06318950
	System.Void <PlayVideo>b__13_0(UnityEngine.Video.VideoPlayer player); // 0x06318a08
	System.Void <PlayVideo>b__13_2(System.Object param); // 0x06318af0
	System.Void <PlayVideo>b__13_1(UnityEngine.Video.VideoPlayer player); // 0x06318bd0
	System.Void <SkipBtnDelayShow>b__18_0(System.Int64 id, System.Object data, System.Boolean delete); // 0x06318c60
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiNewbieEnd : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	
	System.Void .ctor(); // 0x06318dd0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiNewbieQuestionnaire : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyDialogue.UiAssessmentBinder binder; // 0x338
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.UiNewbieQuestionnaire.EPlayerType>> playerTypeDic; // 0x340
	System.String[] playerList; // 0x348
	System.Void OnInit(); // 0x06318e5c
	System.Void OnEnable(); // 0x06319ab8
	System.Void OnDestroy(); // 0x0631a228
	System.Void InitDataFromTable(System.String cfg, WizardGames.Soc.SocClient.Ui.UiNewbieQuestionnaire.EPlayerType playerType); // 0x06319fc4
	System.Void OnClickConfirm(); // 0x0631a35c
	System.Void OnClickMobileA1(); // 0x0631aa54
	System.Void OnClickMobileA2(); // 0x0631abb4
	System.Void OnClickMobileA3(); // 0x0631ad14
	System.Void OnClickPcA1(); // 0x0631ae74
	System.Void OnClickPcA2(); // 0x0631afd4
	System.Void OnClickPcA3(); // 0x0631b134
	System.Void OnMobileSelectionChanged(FairyGUI.EventContext context); // 0x0631b294
	System.Void OnPcSelectionChanged(FairyGUI.EventContext context); // 0x0631b6d0
	static WizardGames.Soc.SocClient.Ui.UiNewbieQuestionnaire OpenWindow(System.Action<WizardGames.Soc.SocClient.Ui.UiNewbieQuestionnaire> cb); // 0x0631bb0c
	static System.Void CloseWindow(); // 0x0631bbe4
	System.Void .ctor(); // 0x0631bcc0
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiNewbieQuestionnaire.EPlayerType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiNewbieQuestionnaire.EPlayerType None = 0;
	static WizardGames.Soc.SocClient.Ui.UiNewbieQuestionnaire.EPlayerType A = 1;
	static WizardGames.Soc.SocClient.Ui.UiNewbieQuestionnaire.EPlayerType B = 2;
	static WizardGames.Soc.SocClient.Ui.UiNewbieQuestionnaire.EPlayerType C = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiNewbieQuestionnaire.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiNewbieQuestionnaire.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.UiNewbieSelectMode> <>9__7_1; // 0x8
	static System.Void .cctor(); // 0x0631be6c
	System.Void .ctor(); // 0x0631bed0
	System.Void <OnClickConfirm>b__7_1(WizardGames.Soc.SocClient.Ui.UiNewbieSelectMode win); // 0x0631bf38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiNewbieQuestionnaire.<>c__DisplayClass7_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiNewbieQuestionnaire.EPlayerType playerType; // 0x10
	System.Int32 selA; // 0x14
	System.Int32 selB; // 0x18
	WizardGames.Soc.SocClient.Ui.UiNewbieQuestionnaire <>4__this; // 0x20
	System.Void .ctor(); // 0x0631a9ec
	System.Void <OnClickConfirm>b__0(); // 0x0631c808
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiNewbieSelectMode : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyDialogue.UiModeBinder binder; // 0x338
	FairyGUI.GTextField s1TitleTxt; // 0x340
	FairyGUI.GTextField s1DescTxt; // 0x348
	FairyGUI.GLoader s1IconLoader; // 0x350
	FairyGUI.GTextField s2TitleTxt; // 0x358
	FairyGUI.GTextField s2DescTxt; // 0x360
	FairyGUI.GLoader s2IconLoader; // 0x368
	WizardGames.Soc.SocClient.Ui.UiNewbieSelectMode.EShowType showType; // 0x370
	static SocLogger logger; // 0x0
	System.Void OnInit(); // 0x0631cc88
	System.Void OnEnable(); // 0x0631ced8
	System.Void OnDestroy(); // 0x0631d1e4
	System.Void OnClickConfirm(); // 0x0631d284
	System.Void Setup(WizardGames.Soc.SocClient.Ui.UiNewbieSelectMode.EShowType showType); // 0x0631bfbc
	static WizardGames.Soc.SocClient.Ui.UiNewbieSelectMode OpenWindow(System.Action<WizardGames.Soc.SocClient.Ui.UiNewbieSelectMode> cb); // 0x0631cb5c
	static System.Void CloseWindow(); // 0x0631d874
	System.Void .ctor(); // 0x0631d950
	static System.Void .cctor(); // 0x0631d9dc
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiNewbieSelectMode.EShowType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiNewbieSelectMode.EShowType None = 0;
	static WizardGames.Soc.SocClient.Ui.UiNewbieSelectMode.EShowType SelectMode = 1;
	static WizardGames.Soc.SocClient.Ui.UiNewbieSelectMode.EShowType FinishTraining = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiNewbieSelectMode.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiNewbieSelectMode.<>c <>9; // 0x0
	static System.Action<SimpleJSON.JSONNode> <>9__12_1; // 0x8
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMainQuestConfirm> <>9__12_0; // 0x10
	static System.Void .cctor(); // 0x0631dab0
	System.Void .ctor(); // 0x0631db14
	System.Void <OnClickConfirm>b__12_1(SimpleJSON.JSONNode node); // 0x0631db7c
	System.Void <OnClickConfirm>b__12_0(WizardGames.Soc.SocClient.Ui.UiMainQuestConfirm win); // 0x0631dda0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiNewbieWait : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.LobbyDialogue.UiNewbieWaitBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.LobbyDialogue.RootNewbieWaitContentBinder contentBinder; // 0x340
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x348
	FairyGUI.GTextField remainTimeText; // 0x350
	WizardGames.Soc.SocClient.Ui.ENewbieWaitState newbieWaitState; // 0x358
	System.Int64 lineUpTimeStamp; // 0x360
	System.Int64 lineUpAmount; // 0x368
	System.Int64 leftTime; // 0x370
	System.Boolean needCountDown; // 0x378
	System.Boolean againWait; // 0x379
	WizardGames.Soc.SocClient.Ui.Utils.WindowCDTime windowCDTime; // 0x380
	System.Void OnInit(); // 0x0631de34
	System.Void OnEnable(); // 0x0631e2a0
	System.Void OnDisable(); // 0x0631e308
	System.Void OnCLickExitQueue(); // 0x0631e370
	System.Void OnClickContinueWait(); // 0x0631e964
	System.Void OnClickJumpQueueConfirm(); // 0x0631ed08
	System.Void GotoLobby(); // 0x0631ef10
	System.Void OnClickJumpQueue(); // 0x0631f0e0
	System.Void OnFps1Update(System.Single dt); // 0x0631f4cc
	System.Void SetData(System.Int64 leftTimeStamp, System.Int64 lineUpAmount); // 0x0631f5e8
	System.Void RefreshWaitUI(); // 0x0631e3dc
	static System.Void ShowNewbieWait(System.Int64 leftTimeStamp, System.Int64 lineUpAmount); // 0x0631f878
	System.Void .ctor(); // 0x0631fa40
	static System.Void .cctor(); // 0x0631fb04
	System.Void <OnInit>b__13_0(); // 0x0631fbd8
	System.Void <OnClickJumpQueueConfirm>b__18_0(); // 0x0631fc3c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiNewbieWait.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiNewbieWait.<>c <>9; // 0x0
	static System.Action <>9__19_0; // 0x8
	static System.Void .cctor(); // 0x0631fcb0
	System.Void .ctor(); // 0x0631fd14
	System.Void <GotoLobby>b__19_0(); // 0x0631fd7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiNewbieWait.<>c__DisplayClass24_0 : System.Object
{
	System.Int64 leftTimeStamp; // 0x10
	System.Int64 lineUpAmount; // 0x18
	System.Void .ctor(); // 0x0631f9d8
	System.Void <ShowNewbieWait>b__0(WizardGames.Soc.SocClient.Ui.UiNewbieWait win); // 0x06320008
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ENewbieWaitState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ENewbieWaitState None = 0;
	static WizardGames.Soc.SocClient.Ui.ENewbieWaitState InQueue = 1;
	static WizardGames.Soc.SocClient.Ui.ENewbieWaitState InWait = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiObserverModeCancelRadius : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static System.String UI_NMAE; // 0x0
	FairyGUI.GButton btnClose; // 0x338
	Effect.EffectItemHandle<Effect.EffectItem> wallEffectItemHandle; // 0x340
	WizardGames.Soc.Common.Entity.PartEntity partEntity; // 0x350
	System.Single radius; // 0x358
	System.Void OnInit(); // 0x0632008c
	System.Void OnEnable(); // 0x063201f0
	System.Void OnDisable(); // 0x063204e8
	System.Void OnDestroy(); // 0x06320620
	System.Void UpdateShowEffect(WizardGames.Soc.Common.Entity.PartEntity partEntity, System.Single radius); // 0x06320268
	System.Void ReleaseEffect(); // 0x06320558
	System.Void OnBtnClose(); // 0x063206a4
	static WizardGames.Soc.SocClient.Ui.UiObserverModeCancelRadius OpenWindow(); // 0x06320710
	System.Void .ctor(); // 0x063208a4
	static System.Void .cctor(); // 0x06320930
	System.Void <UpdateShowEffect>b__9_0(System.Boolean b, Effect.EffectItem item, System.Object arg3); // 0x06320998
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiObtainNewSkin : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GLoader bg; // 0x338
	FairyGUI.Controller jumpAllCtrl; // 0x340
	FairyGUI.Controller shareCtrl; // 0x348
	FairyGUI.Controller collectedCtrl; // 0x350
	FairyGUI.Controller shareBtnCtrl; // 0x358
	FairyGUI.Controller detailCtrl; // 0x360
	FairyGUI.GTextField txtDetail; // 0x368
	FairyGUI.GButton btnShare; // 0x370
	WizardGames.Soc.SocClient.Ui.ComTopBar ComTopBar; // 0x378
	FairyGUI.GLoader modelLoader; // 0x380
	WizardGames.Soc.SocClient.Ui.ComStateBtn btnApply; // 0x388
	FairyGUI.GButton btnSkipAll; // 0x390
	System.Int32 curShowIndex; // 0x398
	System.Int32 curSuitID; // 0x39c
	WizardGames.Soc.SocClient.Manager.EPreviewType curPreviewType; // 0x3a0
	System.Collections.Generic.List<System.Int32> skinIDs; // 0x3a8
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> modelShowCfg; // 0x3b0
	System.Collections.Generic.List<System.Int32> curSuitCostumeIDs; // 0x3b8
	System.Action callback; // 0x3c0
	System.String skinName; // 0x3c8
	System.String skinDesc; // 0x3d0
	System.Int32 shareSkinId; // 0x3d8
	WizardGames.Soc.SocClient.Ui.ComUiModel weaponModel; // 0x3e0
	WizardGames.Soc.SocClient.Ui.ComUiModel itemModel; // 0x3e8
	WizardGames.Soc.SocClient.Ui.ComUiModel equipmentModel; // 0x3f0
	WizardGames.Soc.SocClient.Ui.ComUiPlayerModel playerModel; // 0x3f8
	WizardGames.Soc.SocClient.Ui.ComAppWelfareText skinWeaponAppWelfareCom; // 0x400
	System.Int32 azureType; // 0x408
	System.Int32 newPreset; // 0x40c
	WizardGames.Soc.SocClient.Ui.Binder.LobbyObtainNewSkin.ComObtainNewSkinContentBinder contentBinder; // 0x410
	WizardGames.Soc.SocClient.Ui.Binder.LobbyObtainNewSkin.SkinTitleBinder comDescriptionBinder; // 0x418
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComQualityTitleBinder comQualityTitleBinder; // 0x420
	System.Void OnInit(); // 0x06320b14
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x063216ac
	System.Void OnEnable(); // 0x063218e0
	System.Void MakeFullScreen(); // 0x063219a4
	System.Void OnDisable(); // 0x06321a0c
	System.Void OnDestroy(); // 0x06321ac0
	System.Void SetPlayerModel(System.Int32 rid); // 0x06321be8
	System.Void SetEquipmentSkinPlayerModel(System.Int32 skinId); // 0x06322630
	System.Void HideUiModelDic(); // 0x06322598
	System.Void GetCustomTodData(System.Int32 rid); // 0x063229a0
	System.Void SetUIModel(System.Int64 ownerID, System.Int32 rid, WizardGames.Soc.SocClient.Manager.ERotateMode rotateMode, WizardGames.Soc.SocClient.Manager.EPreviewType previewType); // 0x06322adc
	static System.Void Open(System.Collections.Generic.List<System.Int32> skinIDs, System.Action callback); // 0x06323040
	System.Void Refresh(System.Collections.Generic.List<System.Int32> ids, System.Action callback); // 0x063232f0
	System.Void SetSkinIDs(System.Collections.Generic.List<System.Int32> ids); // 0x06323fc4
	System.Int32 IsIdInCostumeSet(System.Int32 rid); // 0x0632410c
	System.Boolean IsEquipmentSkinNeedPlayerModel(System.Int32 skinId); // 0x0632444c
	System.Void ShowCurSkin(); // 0x063235b8
	System.Void RefreshSkinWeaponAppWelfareInfo(System.Int32 skinId); // 0x06324990
	System.Void OnClickShare(); // 0x06324a24
	System.Void OnCloseShareAction(); // 0x06324dcc
	System.Void OnClickApply(); // 0x06324e54
	System.Void SetApplyBtnDisable(); // 0x063248ac
	System.Void OnApplyCallback(); // 0x063257a0
	System.Void OnClickSkip(); // 0x06321724
	System.Void OnClickSkipAll(); // 0x06325804
	System.Boolean IsGlitterSkinOrAccessory(System.Int32 skinId); // 0x06324788
	System.Boolean IsNeedToShowPlayerModel(System.Int32 rid, System.Collections.Generic.Dictionary<System.Int32,System.Int32> res); // 0x06321fc8
	System.Boolean IsNeedToShowCostumeSuitModel(System.Int32 rid, System.Collections.Generic.Dictionary<System.Int32,System.Int32> res); // 0x0632224c
	System.Boolean IsBuildingSkin(System.Int32 skinId); // 0x0632588c
	WizardGames.Soc.Common.Data.mall.OBJReTailMallTod GetReTailMallTod(WizardGames.Soc.Common.Data.resource.ENUMSkinType resourceType); // 0x06321ea8
	System.Void RefreshResShow(System.Int32 rid); // 0x06324574
	System.Void .ctor(); // 0x06325a5c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiObtainNewSkin.<>c__DisplayClass45_0 : System.Object
{
	System.Collections.Generic.List<System.Int32> skinIDs; // 0x10
	System.Action callback; // 0x18
	System.Void .ctor(); // 0x06323288
	System.Void <Open>b__0(WizardGames.Soc.Common.Unity.Ui.LayerComBase layer, WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x06325c1c
	System.Void <Open>b__1(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x06325cf4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EHandleResShowType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EHandleResShowType ShowAll = 0;
	static WizardGames.Soc.SocClient.Ui.EHandleResShowType HideAll = 1;
	static WizardGames.Soc.SocClient.Ui.EHandleResShowType ShowOnlyConfirm = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideCommonBase : System.Object
{
	FairyGUI.GComponent root; // 0x10
	FairyGUI.GTextField titleTextField; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiOthersideCommonBase.UiResourceHandle> uiInputResourceHandleList; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiOthersideCommonBase.UiResourceHandle> uiFuelResourceHandleList; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiOthersideCommonBase.UiResourceHandle> uiOutputResourceHandleList; // 0x30
	FairyGUI.GComponent inputCom; // 0x38
	FairyGUI.GComponent fuelCom; // 0x40
	FairyGUI.GComponent outputCom; // 0x48
	FairyGUI.GTextField inputTextField; // 0x50
	FairyGUI.GTextField fuelTextField; // 0x58
	FairyGUI.GTextField outputTextField; // 0x60
	FairyGUI.GList listContainerInput; // 0x68
	FairyGUI.GList listContainerFuel; // 0x70
	FairyGUI.GList listContainerOutput; // 0x78
	WizardGames.Soc.SocClient.Ui.UiResHandle uiResHandle; // 0x80
	FairyGUI.GComponent handlePanelCom; // 0x88
	System.Boolean inited; // 0x90
	FairyGUI.GComponent curSelectedContainerCom; // 0x98
	System.Single curOriginPosY; // 0xa0
	System.Single inputPosY; // 0xa4
	System.Single fuelPosY; // 0xa8
	System.Single outputPosY; // 0xac
	System.Boolean inputDraggable; // 0xb0
	FairyGUI.GButton btnOpenSurvivalManual; // 0xb8
	System.Int32 openSurvivalManualId; // 0xc0
	System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> QuickLootToMineAction; // 0xc8
	FairyGUI.Transition showTrans; // 0xd0
	FairyGUI.Transition hideTrans; // 0xd8
	WizardGames.Soc.SocClient.Ui.UiOthersideCommonData get_UiData(); // 0x054e7844
	System.Single get_FocusPosY(); // 0x06325dc4
	System.String get_ShowAnimStr(); // 0x06325e2c
	System.String get_HideAnimStr(); // 0x06325ea4
	System.Void Bind(FairyGUI.GComponent node, WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType mode); // 0x06325f1c
	System.Void Show(WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType mode); // 0x06326058
	System.Void Hide(System.Boolean invokeDisable); // 0x06326130
	System.Boolean PlayHideTrans(FairyGUI.PlayCompleteCallback hideCompleteCallback); // 0x063261e4
	System.Void OnInit(); // 0x06326284
	System.Void OnEnable(); // 0x06326b58
	System.Void OnDisable(); // 0x063272e0
	System.Void Dispose(); // 0x06327654
	System.Void SetSurvivalManualId(System.Int32 id); // 0x0632773c
	System.Void OpenSurvivalManual(); // 0x063277c8
	System.Void OpenSurvivalManualCallback(); // 0x063278c8
	System.Void OnHandlePanelVisibleChanged(); // 0x06327928
	System.Void OnClickClose(); // 0x06327988
	System.Void OnInventoryUpdate(); // 0x06327a68
	System.Void OnPlayerLootUpdate(); // 0x06327aec
	System.Void OnUpdateFps30(); // 0x06327b70
	System.Void OnUpdateFps10(); // 0x06328244
	System.Void Refresh(); // 0x063282a4
	System.Void RefreshResHandle(); // 0x06328304
	System.Void RenderInputResourceList(System.Int32 index, FairyGUI.GObject obj); // 0x063285f8
	System.Void RenderFuelResourceList(System.Int32 index, FairyGUI.GObject obj); // 0x0632882c
	System.Void RenderOutputResourceList(System.Int32 index, FairyGUI.GObject obj); // 0x06328a4c
	System.Void OpenAddNewResPanel(WizardGames.Soc.SocClient.Ui.ContainTypeEnum containTypeEnum, System.Int32 index, System.Int32 row); // 0x06328c6c
	System.Void OpenAddNewResPanelResHandle(WizardGames.Soc.SocClient.Ui.ContainTypeEnum containTypeEnum); // 0x06328f90
	System.Void OnSelectedContainTypeChange(); // 0x06329250
	System.Void UpdateOwnedResCount(); // 0x063292b0
	System.Void UpdateNoStackRes(); // 0x063293cc
	System.Void OpenHandleResPanel(WizardGames.Soc.SocClient.Ui.ContainTypeEnum containTypeEnum, System.Int32 index, System.Int64 itemId, System.Int32 row); // 0x063294ec
	System.Void OpenHandleResPanelResHandle(WizardGames.Soc.SocClient.Ui.ContainTypeEnum containTypeEnum, System.Int64 itemId); // 0x0632983c
	System.Void OnOpenHandlePosChange(); // 0x06329ab0
	System.Void OpenAddNewResPanelCallback(); // 0x06329b8c
	System.Void OpenHandleResPanelCallback(System.Int64 itemId); // 0x06329bec
	System.Void CloseResPanelCallback(); // 0x06329c60
	System.Void QuickLootToMine(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06329e34
	System.Void OtherSideChooseNext(System.Boolean isToNext, System.Boolean isFull); // 0x06329f98
	System.Void CloseResHandlePanel(); // 0x0632a21c
	System.Void OtherSideChooseNextInput(System.Int32 lastSelectedIndex); // 0x0632a28c
	System.Void ChooseNotNext(); // 0x0632a494
	System.Void OnSelectedIndexChange(System.Int32 curSelectedIndex, System.Int32 lastSelectedIndex, System.Int32 row); // 0x0632a578
	System.Void OnSelectedIndexChangeInput(System.Int32 curSelectedIndex, System.Int32 lastSelectedIndex, System.Int32 row); // 0x0632a74c
	System.Void SwitchHandleResShowType(WizardGames.Soc.SocClient.Ui.EHandleResShowType handleResShowType); // 0x0632a848
	System.Boolean CheckTemplate(System.Int32 templateId, FairyGUI.GComponent& rootCom); // 0x0632a9f8
	System.Int64 GetTemplateId(); // 0x0632aaf8
	System.Void .ctor(); // 0x0632abc4
	System.Void <OnInit>b__40_1(FairyGUI.EventContext ctx); // 0x0632ac7c
	System.Void <OnInit>b__40_0(); // 0x0632acf4
	System.Void <OpenSurvivalManual>b__45_0(); // 0x0632adc4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideCommonBase.UiResourceHandle : System.Object
{
	FairyGUI.GLoader emptySignLoader; // 0x10
	FairyGUI.GButton addResBtn; // 0x18
	WizardGames.Soc.SocClient.Ui.ComItemIconLoader itemIconLoader; // 0x20
	WizardGames.Soc.SocClient.Ui.ComItemIcon itemIconCom; // 0x28
	FairyGUI.GImage progressImg; // 0x30
	FairyGUI.GMovieClip effectClip; // 0x38
	FairyGUI.GImage frameImg; // 0x40
	FairyGUI.Controller existCtrl; // 0x48
	FairyGUI.Controller canAddCtrl; // 0x50
	WizardGames.Soc.SocClient.Ui.ContainTypeEnum containType; // 0x58
	System.Int32 index; // 0x5c
	System.Boolean canAdd; // 0x60
	System.Int32 row; // 0x64
	System.Boolean isDraging; // 0x68
	System.Action<WizardGames.Soc.SocClient.Ui.ContainTypeEnum,System.Int32,System.Int32> OpenAddNewResPanelAction; // 0x70
	System.Action<WizardGames.Soc.SocClient.Ui.ContainTypeEnum,System.Int32,System.Int64,System.Int32> OpenHandleResPanelAction; // 0x78
	System.Int64 get_ItemId(); // 0x0632b03c
	System.Void .ctor(FairyGUI.GComponent root); // 0x0632b15c
	System.Void SetProperties(WizardGames.Soc.SocClient.Ui.ContainTypeEnum containTypeEnum, System.Int32 position, System.Boolean canAddRes, System.Int32 line); // 0x0632b658
	System.Void Clear(); // 0x0632b840
	System.Void SetContainerData(WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap itemContainerNode); // 0x0632ba10
	System.Void SetStyle(System.Boolean isExist); // 0x0632baac
	System.Void Refresh(); // 0x0632bb74
	System.Void OpenResHandlePanel(); // 0x0632bc58
	System.Void SetEffectVisible(System.Boolean isVisible); // 0x0632b5bc
	System.Void Select(System.Boolean isSelected); // 0x0632bd40
	System.Void DragStart(WizardGames.Soc.Common.CustomType.BaseItemNode dragIcon); // 0x0632bdd4
	System.Void DragEnd(WizardGames.Soc.Common.CustomType.BaseItemNode dragIcon, System.Boolean isDragValid); // 0x0632be50
	System.Void <.ctor>b__18_0(); // 0x0632bed0
	System.Void <.ctor>b__18_1(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x0632c1c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideCommonData : System.Object
{
	WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType mode; // 0x10
	System.Collections.Generic.List<System.Int64> inputAddResItemIdList; // 0x18
	System.Collections.Generic.List<System.Int64> fuelAddResItemIdList; // 0x20
	System.Collections.Generic.List<System.Int64> outputAddResItemIdList; // 0x28
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ContainTypeEnum,WizardGames.Soc.SocClient.Ui.ItemContainerNodeParser> itemContainerParserDic; // 0x30
	WizardGames.Soc.SocClient.Ui.ContainTypeEnum curSelectedContainType; // 0x38
	System.Int32 curSelectedIndex; // 0x3c
	System.Int64 curSelectedItemId; // 0x40
	System.Int32 curRow; // 0x48
	System.Boolean isNonStackable; // 0x4c
	System.Action OnInputOwnedResAmountChangeAction; // 0x50
	System.Action OnFuelOwnedResAmountChangeAction; // 0x58
	System.Action OnOutputOwnedResAmountChangeAction; // 0x60
	System.Comparison<System.Int64> InputOwnedResSortComparison; // 0x68
	System.Comparison<System.Int64> FuelOwnedResSortComparison; // 0x70
	System.Comparison<System.Int64> OutputOwnedResSortComparison; // 0x78
	WizardGames.Soc.SocClient.Ui.ItemContainerNodeParser fuelContainerParser; // 0x80
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> fuelOwnedResAmountDic; // 0x88
	WizardGames.Soc.SocClient.Ui.ItemContainerNodeParser inputContainerParser; // 0x90
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> inputOwnedResAmountDic; // 0x98
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.CustomType.BaseItemNode> showingItemNodeDic; // 0xa0
	System.Collections.Generic.List<System.Int64> showingItemNodeIdList; // 0xa8
	System.Action OnShowingItemNodeChangeAction; // 0xb0
	System.Comparison<System.Int64> ConditionSortComparison; // 0xb8
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> tempItemNodeList; // 0xc0
	WizardGames.Soc.SocClient.Ui.ItemContainerNodeParser outputContainerParser; // 0xc8
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> outputOwnedResAmountDic; // 0xd0
	WizardGames.Soc.Common.CustomType.ItemContainerNode get_InputContainer(); // 0x054e7844
	WizardGames.Soc.Common.CustomType.ItemContainerNode get_FuelContainer(); // 0x054e7844
	WizardGames.Soc.Common.CustomType.ItemContainerNode get_OutputContainer(); // 0x054e7844
	System.Collections.Generic.List<System.Int64> get_InputAddResItemIdList(); // 0x054e7844
	System.Collections.Generic.List<System.Int64> get_FuelAddResItemIdList(); // 0x054e7844
	System.Collections.Generic.List<System.Int64> get_OutputAddResItemIdList(); // 0x054e7844
	WizardGames.Soc.Common.Entity.PartEntity get_CurPartEntity(); // 0x0632c3f0
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap get_CurItemContainerNode(); // 0x0632c5a0
	System.Collections.Generic.List<System.Int64> get_CurHandleResItemIdList(); // 0x0632c65c
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> get_CurOwnedResAmountDic(); // 0x0632c700
	System.Void .ctor(); // 0x0632c798
	System.Void OnEnable(); // 0x0632cdc0
	System.Void OnDisable(); // 0x0632cf78
	System.Void SetCurSelectedItemId(System.Int64 itemId); // 0x0632d0fc
	System.Void RefreshOwnedResourceCount(); // 0x0632d180
	System.Int32 OwnedResDefaultSortComparison(System.Int64 itemTemplateIdA, System.Int64 itemTemplateIdB, System.Collections.Generic.Dictionary<System.Int64,System.Int32> ownedResAmountDic); // 0x0632dcc8
	System.Boolean CanAddRes(WizardGames.Soc.SocClient.Ui.ContainTypeEnum containTypeEnum); // 0x0632ddf8
	System.Void ClearOwnedResChangeAction(); // 0x0632df10
	System.String TimeFormat(System.Int64 time); // 0x0632dfac
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> get_FuelItemList(); // 0x0632e2a0
	System.Void RefreshFuelOwnedResAmount(); // 0x0632d444
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> get_InputItemList(); // 0x0632ea44
	System.Void RefreshInputOwnedResAmount(); // 0x0632d248
	System.Void RefreshShowingItemNode(); // 0x0632d840
	System.Int32 DefaultConditionSortComparison(System.Int64 itemNodeId1, System.Int64 itemNodeId2); // 0x0632eab0
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> get_OutputItemList(); // 0x0632ece4
	System.Void RefreshOutputOwnedResAmount(System.Boolean isRefresh); // 0x0632d640
	System.Int32 <.ctor>b__36_0(System.Int64 itemTemplateIdA, System.Int64 itemTemplateIdB); // 0x0632ed50
	System.Int32 <.ctor>b__36_1(System.Int64 itemTemplateIdA, System.Int64 itemTemplateIdB); // 0x0632eddc
	System.Int32 <.ctor>b__36_2(System.Int64 itemTemplateIdA, System.Int64 itemTemplateIdB); // 0x0632ee68
	System.Int32 <.ctor>b__36_3(System.Int64 itemNodeId1, System.Int64 itemNodeId2); // 0x0632eef4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ItemContainerNodeParser : System.Object
{
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap bindContainerNode; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> itemNodeList; // 0x18
	System.Collections.Generic.List<System.Int64> itemIdList; // 0x20
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> itemAmountDic; // 0x28
	System.Action OnItemAmountChangeAction; // 0x30
	System.Void Bind(WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap itemContainerNode); // 0x0632ef7c
	System.Void Clear(); // 0x0632cffc
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> GetItemNodeList(); // 0x0632e30c
	System.Int64[] GetIdDivision(); // 0x0632effc
	WizardGames.Soc.Common.Data.DataItem.Container GetContainer(); // 0x0632f100
	System.Void .ctor(); // 0x0632cc5c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ContainTypeEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ContainTypeEnum None = 0;
	static WizardGames.Soc.SocClient.Ui.ContainTypeEnum Input = 1;
	static WizardGames.Soc.SocClient.Ui.ContainTypeEnum Fuel = 2;
	static WizardGames.Soc.SocClient.Ui.ContainTypeEnum Output = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComOthersideDropBar : System.Object
{
	FairyGUI.GComponent comRoot; // 0x10
	System.Void set_Visible(System.Boolean value); // 0x0632f28c
	System.Void .ctor(FairyGUI.GComponent comBar); // 0x0632f320
	System.Void InitDtopCom(FairyGUI.GComponent com, System.Func<FairyGUI.EventContext,System.Boolean> onDrop); // 0x0632f4c8
	System.Boolean OnItemToBackpack(FairyGUI.EventContext context); // 0x0632f768
	System.Boolean OnItemToDrop(FairyGUI.EventContext context); // 0x0632f93c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComOthersideDropBar.<>c__DisplayClass5_0 : System.Object
{
	FairyGUI.Controller ctrl; // 0x10
	System.Func<FairyGUI.EventContext,System.Boolean> onDrop; // 0x18
	System.Void .ctor(); // 0x0632f700
	System.Void <InitDtopCom>b__0(); // 0x0632fab8
	System.Void <InitDtopCom>b__1(); // 0x0632fb40
	System.Void <InitDtopCom>b__2(FairyGUI.EventContext ctx); // 0x0632fbc8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideReputation : WizardGames.Soc.SocClient.Ui.UiOthersideCommonBase
{
	System.Int64 intelligenceItemId; // 0xe0
	System.Boolean hasShowIntelligenceItemAnim; // 0xe8
	WizardGames.Soc.SocClient.Ui.UiOthersideReputationData uiData; // 0xf0
	FairyGUI.GButton recordBtn; // 0xf8
	FairyGUI.GButton badgeBtn; // 0x100
	FairyGUI.GComponent timeCom; // 0x108
	FairyGUI.GComponent outputNewCom; // 0x110
	FairyGUI.Transition outputNewLoopAnim; // 0x118
	FairyGUI.Transition outputNewLoopAnim1; // 0x120
	FairyGUI.Transition outputNewLoopAnim2; // 0x128
	FairyGUI.Transition showIntelligenceItemAnim; // 0x130
	FairyGUI.Transition hideIntelligenceItemAnim; // 0x138
	FairyGUI.Controller reputationControl; // 0x140
	FairyGUI.GTextField itemNum; // 0x148
	FairyGUI.GTextField timeTextField; // 0x150
	FairyGUI.GImage arrowImg; // 0x158
	FairyGUI.GComponent prestigeCom; // 0x160
	FairyGUI.GTextField levelTextField; // 0x168
	FairyGUI.GTextField newLevelTextField; // 0x170
	FairyGUI.GTextField prestigeValTextField; // 0x178
	FairyGUI.GTextField nextLevelNumTextField; // 0x180
	FairyGUI.GImage progressImg; // 0x188
	FairyGUI.GImage pointerImg; // 0x190
	FairyGUI.GButton rewardBtn; // 0x198
	FairyGUI.GImage rewardNewImg; // 0x1a0
	FairyGUI.GButton upgradeBtn; // 0x1a8
	FairyGUI.Controller upgradeBtnCtrl; // 0x1b0
	FairyGUI.GButton btnShutdown; // 0x1b8
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> resAmountDic; // 0x1c0
	WizardGames.Soc.SocClient.Ui.UiOthersideCommonData get_UiData(); // 0x0632fcc0
	System.Single get_FocusPosY(); // 0x0632fd24
	System.Void OnInit(); // 0x0632fd88
	System.Void OnReputationRewardDictChanged(WizardGames.Soc.Share.Framework.CustomTypeBase baseEntity, System.Int32 oldValue, System.Int32 newValue); // 0x06330acc
	System.Void OnHandlePanelVisibleChanged(); // 0x06330bc4
	System.Void OnClickOutPutItem(); // 0x06330cc4
	System.Void OnEnable(); // 0x06331200
	System.Void SetPrestigeValInfo(); // 0x063312f8
	System.Void OnDisable(); // 0x06331ae0
	System.Void PlayAnim(); // 0x06331c34
	System.Void StopAnim(); // 0x06331d9c
	System.Void OpenSurvivalManualCallback(); // 0x06331ee4
	System.Void OnUpdateFps30(); // 0x06331fa8
	System.Void CloseResPanelCallback(); // 0x06332704
	System.Void OpenHandleResPanelCallback(System.Int64 itemId); // 0x063327f8
	System.Void OnClickShutdown(); // 0x06332920
	System.Void .ctor(); // 0x06332fd4
	System.Void <OnInit>b__33_2(); // 0x06333140
	System.Void <OnInit>b__33_4(); // 0x063333e0
	System.Void <OnInit>b__33_5(); // 0x063334e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideReputation.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiOthersideReputation.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__33_0; // 0x8
	static FairyGUI.EventCallback0 <>9__33_1; // 0x10
	static FairyGUI.EventCallback0 <>9__33_3; // 0x18
	static System.Action <>9__46_0; // 0x20
	static System.Void .cctor(); // 0x063335bc
	System.Void .ctor(); // 0x06333620
	System.Void <OnInit>b__33_0(FairyGUI.EventContext ctx); // 0x06333688
	System.Void <OnInit>b__33_1(); // 0x06333854
	System.Void <OnInit>b__33_3(); // 0x063339d0
	System.Void <OnClickShutdown>b__46_0(); // 0x06333ac0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideReputationData : WizardGames.Soc.SocClient.Ui.UiOthersideCommonData
{
	System.Int32 lastReputation; // 0xd8
	WizardGames.Soc.Common.CustomType.ItemContainerNode get_InputContainer(); // 0x06333d38
	WizardGames.Soc.Common.CustomType.ItemContainerNode get_FuelContainer(); // 0x06333db4
	WizardGames.Soc.Common.CustomType.ItemContainerNode get_OutputContainer(); // 0x06333e18
	System.Collections.Generic.List<System.Int64> get_InputAddResItemIdList(); // 0x06333e94
	System.Collections.Generic.List<System.Int64> get_FuelAddResItemIdList(); // 0x06333ff0
	System.Collections.Generic.List<System.Int64> get_OutputAddResItemIdList(); // 0x06334054
	WizardGames.Soc.Common.Component.TerritoryCabinetComponent get_ReputationConverter(); // 0x0633257c
	System.Int32 get_Reputation(); // 0x06331840
	System.Int32 get_PlayerReputation(); // 0x06331618
	System.Int32 get_Level(); // 0x06331a08
	System.Int32 get_ReputationMax(); // 0x06331900
	System.Int64 get_ConvertRemainingTime(); // 0x06330e88
	System.Single get_Efficiency(); // 0x063341b0
	System.Void SubmitRes(System.Action callback, System.Action error); // 0x06333328
	System.Boolean CheckReputationChange(); // 0x06332680
	System.Void .ctor(); // 0x063330d4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType None = 0;
	static WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType OvenFurnace = 2;
	static WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType OvenOilRefinery = 3;
	static WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType OvenCampfire = 4;
	static WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType OvenFurnaceLarge = 5;
	static WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType OvenHoboBarrel = 6;
	static WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType OvenBarbeque = 7;
	static WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType OvenStoneFireplace = 8;
	static WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType Dig = 15;
	static WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType Shotgun = 16;
	static WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType FlameTurret = 17;
	static WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType ModularCarEngine = 18;
	static WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType HorseEquip = 21;
	static WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType Reputation = 22;
	static WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType Fertilizer = 23;
	static WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType HitchPost = 25;
	static WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType VehicleOp = 26;
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiOtherSideInfo : System.ValueType
{
	System.String componentName; // 0x10
	System.Func<WizardGames.Soc.SocClient.Ui.UiOthersideCommonBase> creator; // 0x18
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOtherSide : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update, WizardGames.Soc.Common.Unity.Ui.IUiTriggerGuide
{
	static SocLogger Log; // 0x0
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType,WizardGames.Soc.SocClient.Ui.UiOtherSideInfo> othersideComNameMap; // 0x338
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType,WizardGames.Soc.SocClient.Ui.UiOthersideCommonBase> modes; // 0x340
	WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType curMode; // 0x348
	FairyGUI.GButton closeBtn; // 0x350
	FairyGUI.Transition closeBtnShowTrans; // 0x358
	FairyGUI.Transition closeBtnHideTrans; // 0x360
	FairyGUI.GLoader clickAreaLoader; // 0x368
	WizardGames.Soc.SocClient.Ui.ComOthersideDropBar dropBar; // 0x370
	System.Boolean isClosing; // 0x378
	FairyGUI.PlayCompleteCallback hideCompleteCallback; // 0x380
	static System.Action<WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType,System.Int64> OnCloseViewAction; // 0x8
	static System.Action<WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType,System.Int64> OnOpenViewAction; // 0x10
	System.String otherSideUrlStr; // 0x388
	System.String anchorStr; // 0x390
	System.Single defaultCloseWinDistanceSqr; // 0x398
	System.Single farCloseWinDistanceSqr; // 0x39c
	System.Boolean keepOthersideStateWhenDisable; // 0x3a0
	static System.Boolean ItemTipClick; // 0x18
	static UnityEngine.Vector3 interactionPos; // 0x1c
	static WizardGames.Soc.Share.Framework.IPositionEntity interactionPosEntity; // 0x28
	static UnityEngine.Transform interactionTrans; // 0x30
	static UnityEngine.Vector3 myEntityPos; // 0x38
	FairyGUI.GComponent panelRoot; // 0x3a8
	WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType get_CurMode(); // 0x0633422c
	static UnityEngine.Vector3 get_InteractionPos(); // 0x06334290
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x06334524
	System.Boolean TriggerGuide(); // 0x063345b0
	System.Void OnInit(); // 0x0633470c
	System.Void OnDestroy(); // 0x06334bcc
	System.Void OnDisable(); // 0x06334cc4
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x063350b4
	System.Void OnFps30Update(System.Single dt); // 0x0633549c
	System.Void OnFps10Update(System.Single dt); // 0x06335628
	System.Void CheckDis(); // 0x063356f4
	System.Void OnHideByLayerStack(System.String coverUiName); // 0x06335a38
	System.Void OnShowByLayerStack(); // 0x06335ab4
	static System.Void OpenOtherSideWin(WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType mode, System.Int64 collectionId, System.Action<WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType,System.Int64> onClose, System.Action<WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType,System.Int64> onOpen); // 0x06335b18
	static System.Void OpenOtherSideWinInLooting(WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType mode, System.Int64 collectionId, System.Action<WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType,System.Int64> onClose, System.Action<WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType,System.Int64> onOpen); // 0x06335df8
	System.Void ShowContainer(WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType mode); // 0x063361d0
	System.Void HideAllContainer(); // 0x06336300
	WizardGames.Soc.SocClient.Ui.UiOthersideCommonBase GetOrCreateUiOtherSideBase(WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType mode); // 0x063364ac
	System.Void PlayInventoryOthersideOpenAudio(System.Int64 lootingId); // 0x06336990
	System.Void PlayInventoryOthersideCloseAudio(System.Int64 lootingId); // 0x06334f18
	System.Void SetInteractionEntity(); // 0x06336bdc
	System.Boolean CheckTemplate(System.Int32 templateId, FairyGUI.GComponent& rootCom); // 0x06336f10
	static System.Void CloseOtherSideWin(); // 0x06333c40
	System.Void .ctor(); // 0x06336ff8
	static System.Void .cctor(); // 0x06337374
	System.Void <OnInit>b__30_0(); // 0x063374b0
	System.Void <OnInit>b__30_1(); // 0x06337520
	System.Void <OnInit>b__30_2(WizardGames.Soc.Common.CustomType.BaseItemNode item); // 0x063375a0
	System.Void <OnInit>b__30_3(WizardGames.Soc.Common.CustomType.BaseItemNode item, System.Boolean isDragValid); // 0x06337624
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOtherSide.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiOtherSide.<>c <>9; // 0x0
	static System.Func<WizardGames.Soc.SocClient.Ui.UiOthersideCommonBase> <>9__50_0; // 0x8
	static System.Func<WizardGames.Soc.SocClient.Ui.UiOthersideCommonBase> <>9__50_1; // 0x10
	static System.Void .cctor(); // 0x063376b0
	System.Void .ctor(); // 0x06337714
	WizardGames.Soc.SocClient.Ui.UiOthersideCommonBase <.ctor>b__50_0(); // 0x0633777c
	WizardGames.Soc.SocClient.Ui.UiOthersideCommonBase <.ctor>b__50_1(); // 0x06337804
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOtherSide.<>c__DisplayClass39_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType mode; // 0x10
	System.Int64 collectionId; // 0x18
	System.Action<WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType,System.Int64> onClose; // 0x20
	System.Action<WizardGames.Soc.SocClient.Ui.UiVehicleOperate> <>9__1; // 0x28
	System.Action<WizardGames.Soc.SocClient.Ui.UiOtherSide> <>9__2; // 0x30
	System.Void .ctor(); // 0x06335d90
	System.Void <OpenOtherSideWin>b__0(System.Boolean res); // 0x06337c10
	System.Void <OpenOtherSideWin>b__1(WizardGames.Soc.SocClient.Ui.UiVehicleOperate win); // 0x06337e2c
	System.Void <OpenOtherSideWin>b__2(WizardGames.Soc.SocClient.Ui.UiOtherSide win); // 0x0633804c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOtherSide.<>c__DisplayClass40_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType mode; // 0x10
	System.Int64 collectionId; // 0x18
	System.Action<WizardGames.Soc.SocClient.Ui.EUiHalfOthersideType,System.Int64> onClose; // 0x20
	System.Void .ctor(); // 0x06336168
	System.Void <OpenOtherSideWinInLooting>b__0(WizardGames.Soc.SocClient.Ui.UiVehicleOperate win); // 0x063382a8
	System.Void <OpenOtherSideWinInLooting>b__1(WizardGames.Soc.SocClient.Ui.UiOtherSide win); // 0x063384f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOtherSideVehicleOp : WizardGames.Soc.SocClient.Ui.UiOthersideCommonBase
{
	static SocLogger Log; // 0x0
	WizardGames.Soc.SocClient.Ui.UiOtherSideVehicleOpData uiData; // 0xe0
	FairyGUI.GComponent resHandlePanel; // 0xe8
	FairyGUI.GComponent rollingComp; // 0xf0
	FairyGUI.Controller rollingVehicleTypeCtrl; // 0xf8
	FairyGUI.GComponent statusOilComp; // 0x100
	FairyGUI.GButton btnCloseHandlePanel; // 0x108
	FairyGUI.Controller statusOilVehicleTypeCtrl; // 0x110
	FairyGUI.GComponent fuelNodeIcon; // 0x118
	WizardGames.Soc.SocClient.Ui.UiOthersideCommonBase.UiResourceHandle fuelIconResHandle; // 0x120
	FairyGUI.GList containerList; // 0x128
	FairyGUI.GTextField statusText; // 0x130
	FairyGUI.GRichTextField valueText; // 0x138
	FairyGUI.GTextField titleText; // 0x140
	FairyGUI.GLoader posLoader; // 0x148
	FairyGUI.GImage downArrowImg; // 0x150
	WizardGames.Soc.SocClient.Ui.ComItemIconLoader fuelItemIconLoader; // 0x158
	FairyGUI.GLoader iconDesc1; // 0x160
	FairyGUI.GComponent tipCom; // 0x168
	FairyGUI.GTextField tipText; // 0x170
	FairyGUI.GLoader tipCloseLoader1; // 0x178
	FairyGUI.GLoader tipCloseLoader2; // 0x180
	WizardGames.Soc.Common.Entity.IBaseMountableEntity baseMountableEntity; // 0x188
	WizardGames.Soc.Common.Unity.Go.BaseMountableGo baseMountableGo; // 0x190
	WizardGames.Soc.SocClient.Ui.UiResHandle uiNonStackResHandle; // 0x198
	System.Collections.Generic.List<System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiOthersideCommonBase.UiResourceHandle>> allContainersResHandle; // 0x1a0
	System.Int32 modularCnt; // 0x1a8
	System.Int32 storagetCnt; // 0x1ac
	System.String[] horseEquipIconUrl; // 0x1b0
	System.String[] moduleIconUrl; // 0x1b8
	System.Single scrollYBeforeOpenFuelResPanel; // 0x1c0
	System.Single contentListPosYBeforeOpenResPanel; // 0x1c4
	System.Single contentListTargetPosY; // 0x1c8
	WizardGames.Soc.SocClient.Ui.UiOthersideCommonData get_UiData(); // 0x06338750
	System.Void OnInit(); // 0x063387b4
	System.Boolean PlayHideTrans(FairyGUI.PlayCompleteCallback hideCompleteCallback); // 0x063398ac
	System.Void OnClickIconDesc(FairyGUI.EventContext context); // 0x06339954
	System.Void OnClickCloseTipWindowArea(); // 0x06339adc
	System.Void RefreshDecayHungerTip(); // 0x06339590
	System.Void RefreshStatusText(); // 0x06339410
	System.Void RefreshStatusValueText(); // 0x0633a4ec
	System.Void RefreshModularCarStatus(); // 0x06339e9c
	System.Void RefreshModularCarStatusValue(); // 0x0633ac14
	System.Void GetStorageNowAndMax(System.Int32& nowV, System.Int32& maxV); // 0x0633bb88
	System.Void RefreshDefaultVehicleStatus(); // 0x06339b78
	System.Void RefreshDefaultVehicleStatusValue(); // 0x0633a630
	System.String GetDecayDes(); // 0x0633b8ec
	System.Void RefreshHorseStatus(); // 0x0633a1e4
	System.Void RefreshHorseStatusValue(); // 0x055049cc
	System.Void OnEntityRemove(WizardGames.Soc.Common.Entity.IEntity entity); // 0x0633be30
	System.Void Close(); // 0x0633bee8
	System.Void OnEnable(); // 0x0633bfcc
	System.Void CheckHeight(); // 0x0633c89c
	System.Void OnUpdateItemNode(WizardGames.Soc.Common.CustomType.BaseItemNode node); // 0x0633cbec
	System.Void InitFuelIcon(); // 0x0633c3a0
	System.Void RefreshContainerList(); // 0x0633c664
	System.Void ContainerListRender(System.Int32 index, FairyGUI.GObject obj); // 0x0633d58c
	static System.String GetHorseContainerName(WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap bindContainerNode); // 0x0633dd9c
	System.Void resListRender(System.Int32 index, FairyGUI.GObject obj); // 0x0633e3ec
	System.Void OpenBtnClick(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x0633e8d8
	System.Void OpenBtnClick(); // 0x0633e950
	System.Void RefreshModulePower(FairyGUI.GComponent comAddRes, System.Int32 index); // 0x0633e080
	System.Void OnDisable(); // 0x0633ea94
	System.Void ChooseNotNext(); // 0x0633f090
	System.Void AllContainersUpdateFull(); // 0x0633f33c
	System.Void FuelUpdateFull(); // 0x0633f5d0
	System.Void RefreshResHandle(); // 0x0633f724
	System.Void HandleUpdateFull(); // 0x0633f784
	System.Void Refresh(); // 0x0633f8f0
	System.Void OpenHandleResPanel(WizardGames.Soc.SocClient.Ui.ContainTypeEnum containTypeEnum, System.Int32 index, System.Int64 itemId, System.Int32 row); // 0x0633f958
	System.Void OnSelectedIndexChangeInput(System.Int32 curSelectedIndex, System.Int32 lastSelectedIndex, System.Int32 row); // 0x0633fa40
	System.Void OnSelectedContainTypeChange(); // 0x0633fc78
	System.Void OtherSideChooseNextInput(System.Int32 lastSelectedIndex); // 0x0633fdb8
	System.Void CloseResHandlePanel(); // 0x0633ff60
	System.Void OnUpdateFps10(); // 0x0633ffdc
	System.Void RefreshModulePower(); // 0x06340054
	System.Void OpenAddNewResPanelResHandle(WizardGames.Soc.SocClient.Ui.ContainTypeEnum containTypeEnum); // 0x06340110
	System.Void OpenHandleResPanelResHandle(WizardGames.Soc.SocClient.Ui.ContainTypeEnum containTypeEnum, System.Int64 itemId); // 0x06340a68
	System.Void UpdateNoStackRes(); // 0x06340cd8
	System.Void CloseResPanelCallback(); // 0x06340e0c
	System.Void FuelScrollStart(); // 0x06340854
	System.Void InputScrollStart(System.Int32 row, System.Int32 index); // 0x0634038c
	System.Void OnUpdateFps30(); // 0x06341108
	System.Void UpdateAll(); // 0x0633cb70
	System.Void CheckCloseWin(); // 0x06341274
	System.Void UpdateContentListPosY(); // 0x06341174
	System.Void .ctor(); // 0x0633788c
	static System.Void .cctor(); // 0x063414cc
	System.Void <OnInit>b__29_0(); // 0x063415a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOtherSideVehicleOp.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiOtherSideVehicleOp.<>c <>9; // 0x0
	static System.Action <>9__60_0; // 0x8
	static System.Void .cctor(); // 0x063416dc
	System.Void .ctor(); // 0x06341740
	System.Void <OpenBtnClick>b__60_0(); // 0x063417a8
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.VehicleContainerType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.VehicleContainerType Modular = 0;
	static WizardGames.Soc.SocClient.Ui.VehicleContainerType HorseEquip = 1;
	static WizardGames.Soc.SocClient.Ui.VehicleContainerType Storage = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOtherSideVehicleOpData : WizardGames.Soc.SocClient.Ui.UiOthersideCommonData
{
	WizardGames.Soc.SocClient.Ui.VehicleContainerType[] vehicleContainerTypes; // 0xd8
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap> _vehicleAllContainer; // 0xe0
	WizardGames.Soc.SocClient.Ui.ItemContainerNodeParser[] allContainersParser; // 0xe8
	WizardGames.Soc.Common.CustomType.ItemContainerNode get_InputContainer(); // 0x0634183c
	WizardGames.Soc.Common.CustomType.ItemContainerNode get_FuelContainer(); // 0x063418e8
	WizardGames.Soc.Common.CustomType.ItemContainerNode get_OutputContainer(); // 0x06341984
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap> get_VehicleAllContainer(); // 0x0633cc64
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap get_CurItemContainerNode(); // 0x063419e8
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> GetItemListByIndex(System.Int32 index); // 0x0633f51c
	System.Collections.Generic.List<System.Int64> get_InputAddResItemIdList(); // 0x06341ad0
	System.Collections.Generic.List<System.Int64> get_FuelAddResItemIdList(); // 0x06341ffc
	System.Collections.Generic.List<System.Int64> get_OutputAddResItemIdList(); // 0x06342200
	WizardGames.Soc.Common.Entity.IBaseMountableEntity get_CurVehicleEntity(); // 0x0633934c
	System.Void OnEnable(); // 0x06342264
	System.Void OnDisable(); // 0x0634233c
	System.Void .ctor(); // 0x06341408
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ClientCollectionItem : System.Object
{
	System.Int64 EntityId; // 0x10
	WizardGames.Soc.Common.Entity.PartEntity Entity; // 0x18
	WizardGames.Soc.Common.Data.DataItem.ContainerUI ContainerUIConfig; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.QueueData> queueDatas; // 0x28
	System.String get_Name(); // 0x063423a8
	System.Int32 get_QueuesMax(); // 0x06342554
	WizardGames.Soc.Common.Component.OvenComponent get_ComponentOven(); // 0x063425c4
	System.Boolean Refresh(System.String uiName, System.Int32 uiType); // 0x063426c8
	System.Boolean IsQueueFull(); // 0x06342ac8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.QueueData> get_QueueDatas(); // 0x06342bec
	System.Void RefreshQueueData(); // 0x06342c50
	System.Boolean DoCraft(System.Int32 recipeId, System.Int32 makeNum); // 0x06343270
	System.Boolean DoClaim(System.Int32 index, WizardGames.Soc.Common.Data.DataItem.ItemConfig itemConfig, System.Int64 count); // 0x063433ec
	System.Void DoCancel(System.Int32 index); // 0x06343680
	System.Void DoMoveToHead(System.Int32 index); // 0x063439bc
	System.Boolean IsBagFull(WizardGames.Soc.Common.Data.DataItem.ItemConfig config, System.Int64 count); // 0x06343578
	System.Boolean IsBagFull(WizardGames.Soc.Common.Data.DataItem.ItemConfig itemConfig); // 0x063437f8
	System.Void .ctor(); // 0x06343a68
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiElectricalStatePanel : System.Object
{
	FairyGUI.GComponent root; // 0x10
	FairyGUI.GLoader loaderElectricalState; // 0x18
	FairyGUI.GTextField txtElectricalState; // 0x20
	WizardGames.Soc.SocClient.Ui.UiOthersideNewOven othersideNewOven; // 0x28
	FairyGUI.Controller ctrStyle; // 0x30
	System.Int32 nextRequestTime; // 0x38
	System.Int32 requestInterval; // 0x3c
	System.Int64 entityId; // 0x40
	System.Boolean isForceUpdate; // 0x48
	System.String noConnected; // 0x50
	System.String noPower; // 0x58
	System.String inOperation; // 0x60
	System.String abnormalPower; // 0x68
	FairyGUI.Controller get_CtrStyle(); // 0x06343b1c
	System.Void OnInit(FairyGUI.GComponent component, WizardGames.Soc.SocClient.Ui.UiOthersideNewOven othersideNewOven); // 0x06343b80
	System.Void UpdateEntity(System.Int64 entity); // 0x06343ce8
	System.Void RegisterEvents(); // 0x06343e1c
	System.Void UnRegisterEvents(); // 0x06343f28
	System.Void UpdateElectricalData(); // 0x06344034
	System.Void RecvElectricInfo(System.Int64 partId, System.Collections.Generic.List<System.Int32> powerNowList); // 0x0634419c
	System.Void SetElectricalConsumptionUi(WizardGames.Soc.Common.Component.ElectricBaseComponent electricModule, System.Int32 powerNow); // 0x06344448
	System.Void SetDeviceState(System.String stateStr, System.String iconUrl); // 0x06344734
	System.Void .ctor(); // 0x063448d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.QueueData : System.Object
{
	WizardGames.Soc.SocClient.Ui.ClientCollectionItem CollectionItem; // 0x10
	System.Int64 RecipeId; // 0x18
	WizardGames.Soc.Common.Data.DataItem.Recipe RecipeConfig; // 0x20
	System.Int32 ItemId; // 0x28
	System.Int32 ItemCount; // 0x2c
	WizardGames.Soc.Common.Data.DataItem.ItemConfig ItemConfig; // 0x30
	System.Int64 Interval; // 0x38
	System.Int64 EndTime; // 0x40
	System.Int64 FinishCount; // 0x48
	System.Int64 Count; // 0x50
	System.Boolean get_IsFinish(); // 0x063449e4
	System.Void Init(); // 0x06343058
	System.Void .ctor(); // 0x06342ff0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiQueueItem : System.Object
{
	FairyGUI.GComponent root; // 0x10
	FairyGUI.Controller ctrl; // 0x18
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x20
	FairyGUI.GButton btnCancel; // 0x28
	FairyGUI.GButton btnToHead; // 0x30
	FairyGUI.GTextField textTime; // 0x38
	FairyGUI.GProgressBar barProgress; // 0x40
	System.Int64 roundTime; // 0x48
	System.Int64 endTime; // 0x50
	System.Boolean isEmpty; // 0x58
	static System.Int64 lastestPlayedFinishAnimTime; // 0x0
	WizardGames.Soc.SocClient.Ui.UiQueuePanel queuePanel; // 0x60
	FairyGUI.Transition animDelete; // 0x68
	FairyGUI.Transition animJoin; // 0x70
	FairyGUI.Transition animInit; // 0x78
	FairyGUI.Transition animMove; // 0x80
	FairyGUI.Transition complete; // 0x88
	FairyGUI.Transition progressTran; // 0x90
	WizardGames.Soc.SocClient.Ui.QueueData data; // 0x98
	System.Int32 index; // 0xa0
	System.Void Bind(FairyGUI.GComponent comItem, WizardGames.Soc.SocClient.Ui.UiQueuePanel queuePanel); // 0x06344a50
	System.Void DoClaim(); // 0x06345080
	System.Boolean CheckCanClaim(); // 0x06345458
	System.Void OnClickIconClaim(FairyGUI.EventContext context); // 0x063454f4
	System.Void OnClickIconCancel(FairyGUI.EventContext context); // 0x0634561c
	System.Void OnClickIconToHead(FairyGUI.EventContext context); // 0x06345820
	System.Void SetData(System.Int32 index, WizardGames.Soc.SocClient.Ui.QueueData queueData, System.Boolean isUpdate, System.Boolean isFirstSetData); // 0x063458bc
	System.Void SetEmpty(System.Boolean hasAnim, System.Action callback); // 0x063451d8
	System.Boolean DoUpdateNew(System.Single dt); // 0x06345e78
	System.String FormatTime(System.Int64 time); // 0x0634623c
	System.Void .ctor(); // 0x063463f0
	System.Void <Bind>b__19_0(FairyGUI.EventContext ctx); // 0x06346458
	System.Void <Bind>b__19_1(FairyGUI.EventContext ctx); // 0x063464d4
	System.Void <DoClaim>b__21_0(); // 0x06346550
	System.Void <OnClickIconCancel>b__24_1(); // 0x063465fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiQueueItem.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiQueueItem.<>c <>9; // 0x0
	static System.Action <>9__24_0; // 0x8
	static System.Void .cctor(); // 0x063468d0
	System.Void .ctor(); // 0x06346934
	System.Void <OnClickIconCancel>b__24_0(); // 0x0634699c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiQueueItem.<>c__DisplayClass29_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiQueueItem <>4__this; // 0x10
	System.Action callback; // 0x18
	System.Void .ctor(); // 0x063469fc
	System.Void <SetEmpty>b__0(); // 0x06346a64
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiQueuePanel : System.Object
{
	FairyGUI.GComponent root; // 0x10
	FairyGUI.GTextField textTitle; // 0x18
	FairyGUI.Controller ctrlQueue; // 0x20
	FairyGUI.GList listIcons; // 0x28
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.UiQueueItem> queueItemeGODic; // 0x30
	WizardGames.Soc.SocClient.Ui.ClientCollectionItem data; // 0x38
	System.Int32 lastQueueCount; // 0x40
	System.Boolean isUpdateSetQueue; // 0x44
	System.Boolean isFirstSetData; // 0x45
	System.Int32 playNum; // 0x48
	System.Action todo; // 0x50
	System.Int32 ClaimIndex; // 0x58
	System.Boolean playingClaimAnim; // 0x5c
	System.Void OnInit(FairyGUI.GComponent component); // 0x06346b84
	System.Void OnIconRender(System.Int32 index, FairyGUI.GObject item); // 0x06346d9c
	WizardGames.Soc.SocClient.Ui.UiQueueItem GetQueueItemByIndex(System.Int32 index); // 0x06346fe8
	System.Void SetData(WizardGames.Soc.SocClient.Ui.ClientCollectionItem collectionItem, System.Boolean isUpdate); // 0x063470ac
	System.Void DoMoveAnim(System.Int32 startIndex, System.Action todo); // 0x06347820
	System.Void CheckFinishAnim(); // 0x063479ec
	System.Void DoUpdateNew(System.Single dt); // 0x06347a90
	System.String GetSumTimeStr(); // 0x06347c28
	System.Int64 GetRemainTime(WizardGames.Soc.SocClient.Ui.QueueData queueData); // 0x06347e1c
	System.String FormatTime(System.Int64 time); // 0x06347f30
	System.Void PlayClaimAnim(WizardGames.Soc.SocClient.Ui.ClientCollectionItem data); // 0x063480e4
	System.Void .ctor(); // 0x063483f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiQueuePanel.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiQueuePanel.<>c <>9; // 0x0
	static System.Action <>9__25_0; // 0x8
	static System.Void .cctor(); // 0x063484bc
	System.Void .ctor(); // 0x06348520
	System.Void <PlayClaimAnim>b__25_0(); // 0x06348588
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiQueuePanel.<>c__DisplayClass25_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ClientCollectionItem data; // 0x10
	WizardGames.Soc.SocClient.Ui.UiQueuePanel <>4__this; // 0x18
	System.Void .ctor(); // 0x06348390
	System.Void <PlayClaimAnim>b__1(); // 0x063485e8
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Ui.IOtherSideRecipe : 
{
	
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RecipeData : System.Object
{
	WizardGames.Soc.SocClient.Ui.ClientCollectionItem CollectionItem; // 0x10
	WizardGames.Soc.Common.Data.DataItem.Recipe Config; // 0x18
	System.Boolean inQueue; // 0x20
	System.Boolean unLock; // 0x21
	System.Collections.Generic.List<System.Int32> IngredientItemId; // 0x28
	System.Collections.Generic.List<System.Int32> IngredientItemCount; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.ItemConfig> IngredientItemConfig; // 0x38
	System.Int32 ItemId; // 0x40
	System.Int32 ItemCount; // 0x44
	WizardGames.Soc.Common.Data.DataItem.ItemConfig ItemConfig; // 0x48
	System.Boolean IsMatEnough; // 0x50
	System.Void Init(); // 0x0634867c
	System.Void DoCraft(System.Int32 inputNum); // 0x06348a54
	System.Void RefreshMatEnough(); // 0x06348ae8
	System.Void .ctor(); // 0x06348c2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIRecipeItem : System.Object
{
	FairyGUI.GComponent root; // 0x10
	FairyGUI.GLoader loaderIcon; // 0x18
	FairyGUI.GTextField textName; // 0x20
	FairyGUI.GTextField textNum; // 0x28
	FairyGUI.Controller selectedCtrl; // 0x30
	FairyGUI.Controller makeCtrl; // 0x38
	FairyGUI.Controller tagCtrl; // 0x40
	FairyGUI.Transition animAppear; // 0x48
	FairyGUI.Transition animAppear01; // 0x50
	WizardGames.Soc.SocClient.Ui.IOtherSideRecipe ownerOtherSide; // 0x58
	WizardGames.Soc.SocClient.Ui.RecipeData data; // 0x60
	System.Void Bind(FairyGUI.GComponent comItem, WizardGames.Soc.SocClient.Ui.IOtherSideRecipe otherSide); // 0x06348d68
	System.Void SetData(System.Int32 index, WizardGames.Soc.SocClient.Ui.RecipeData recipeData, System.Boolean needPlayAnim); // 0x06348fcc
	System.Void .ctor(); // 0x063493ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRecipePanel : System.Object
{
	SocLogger logger; // 0x10
	FairyGUI.GComponent root; // 0x18
	FairyGUI.GButton btnDetail; // 0x20
	FairyGUI.GComponent textDescTitle; // 0x28
	FairyGUI.GList listDesc; // 0x30
	FairyGUI.GComponent textMatTitle; // 0x38
	FairyGUI.GList listMaterials; // 0x40
	FairyGUI.GLabel labelDesc; // 0x48
	FairyGUI.GObject objDescTouch; // 0x50
	FairyGUI.GList listBoard; // 0x58
	FairyGUI.GComponent comCraft; // 0x60
	FairyGUI.GButton btnCraft; // 0x68
	FairyGUI.GButton btnUnlock; // 0x70
	FairyGUI.Transition animBtnCraft; // 0x78
	FairyGUI.Controller ctrlBtnCraftStyle; // 0x80
	FairyGUI.GTextField textCraftTimeValue; // 0x88
	FairyGUI.GButton changeNameBtn; // 0x90
	FairyGUI.GTextField textNane; // 0x98
	WizardGames.Soc.SocClient.Ui.UiInputNum uiInputNum; // 0xa0
	WizardGames.Soc.SocClient.Ui.RecipeData data; // 0xa8
	System.Boolean isMatEnough; // 0xb0
	FairyGUI.GComponent itemDetail; // 0xb8
	System.Int64 entityId; // 0xc0
	WizardGames.Soc.SocClient.Ui.UiOthersideNewOven othersideNewOven; // 0xc8
	WizardGames.Soc.Common.Entity.PartEntity othersideEntity; // 0xd0
	System.Boolean unlock; // 0xd8
	WizardGames.Soc.SocClient.Ui.ComItemIcon chooseItem; // 0xe0
	System.Void OnInit(FairyGUI.GComponent component, System.Int64 entityId, WizardGames.Soc.SocClient.Ui.UiOthersideNewOven othersideNewOven); // 0x06349454
	System.Void UpdateName(); // 0x0634a308
	System.Void OnClickChangeName(); // 0x0634a5f8
	System.Void RenameName(); // 0x0634a6fc
	System.String GetContainerOthersideName(); // 0x0634a390
	System.Void ClientRename(System.String newName); // 0x0634a8f8
	System.Void RequestCraft(); // 0x0634a9d0
	System.Void OnClickCraft(); // 0x0634b034
	System.Void OnClickOpenDetail(); // 0x0634b098
	System.Void OnInputValueChange(System.Int32 inputValue); // 0x0634b150
	System.Void OnClickDescTouch(); // 0x0634b474
	System.Void RefreshCraftBtnState(); // 0x0634a0d8
	System.Void MatItemRender(System.Int32 index, FairyGUI.GObject item); // 0x0634b4d4
	System.Void ClearChooseIcon(); // 0x0634bbd8
	System.Void SetData(WizardGames.Soc.SocClient.Ui.RecipeData recipeData, System.Boolean maxInputNum); // 0x0634bc64
	System.Void SetDetail(System.String iconPath); // 0x0634c7c4
	System.Void SetInputNum(System.Boolean maxInputNum); // 0x0634c50c
	System.Void SetDesc(System.String desc); // 0x0634c024
	System.Void SetMaterials(); // 0x0634c0c4
	System.String FormatTime(System.Int64 time); // 0x0634b2c0
	System.Void .ctor(); // 0x0634c88c
	System.Void <OnInit>b__25_0(); // 0x0634c9c8
	System.Void <OnInit>b__25_1(FairyGUI.EventContext ctx); // 0x0634ca2c
	System.Void <OnInit>b__25_2(FairyGUI.EventContext ctx); // 0x0634caa4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRecipePanel.<>c__DisplayClass25_0 : System.Object
{
	FairyGUI.GButton btnDetail; // 0x10
	WizardGames.Soc.SocClient.Ui.UiRecipePanel <>4__this; // 0x18
	System.Void .ctor(); // 0x0634a070
	System.Void <OnInit>b__3(FairyGUI.EventContext ctx); // 0x0634cb1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRecipePanel.<>c__DisplayClass40_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiRecipePanel <>4__this; // 0x10
	FairyGUI.GComponent comItem; // 0x18
	WizardGames.Soc.SocClient.Ui.ComItemIcon itemIcon; // 0x20
	WizardGames.Soc.Common.Data.DataItem.ItemConfig matItemConfig; // 0x28
	System.Void .ctor(); // 0x0634bb70
	System.Void <MatItemRender>b__0(FairyGUI.EventContext ctx); // 0x0634cc74
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideNewComBase : System.Object
{
	FairyGUI.GComponent root; // 0x10
	System.Boolean inited; // 0x18
	FairyGUI.Transition showTrans; // 0x20
	FairyGUI.Transition hideTrans; // 0x28
	WizardGames.Soc.SocClient.Ui.ClientCollectionItem data; // 0x30
	System.Action OnQueueDataChange; // 0x38
	System.Boolean registerEvents; // 0x40
	System.String get_ShowAnimStr(); // 0x0634ce68
	System.String get_HideAnimStr(); // 0x0634cee0
	System.Void Bind(FairyGUI.GComponent node, System.String mode); // 0x0634cf58
	System.Void Refresh(WizardGames.Soc.SocClient.Ui.ClientCollectionItem collectionItem); // 0x0634d080
	System.Void Show(WizardGames.Soc.SocClient.Ui.ClientCollectionItem collectionItem); // 0x0634d100
	System.Void Hide(); // 0x0634d20c
	System.Void RegisterEvents(); // 0x0634d298
	System.Void UnRegisterEvents(); // 0x0634d2f8
	System.Void OnInit(); // 0x0634d358
	System.Void OnEnable(); // 0x0634d3b8
	System.Void OnDisable(); // 0x0634d418
	System.Void OnFps10Update(System.Single dt); // 0x0634d494
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x0634d508
	System.Void CacheStatus(); // 0x0634d57c
	System.Void UpdateName(); // 0x0634d5dc
	System.Void ClearChooseIcon(); // 0x0634d63c
	System.Boolean CheckTemplate(System.Int32 templateId); // 0x0634d69c
	System.Void .ctor(); // 0x0634d73c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.OtherSideTabItemData : System.Object
{
	System.Int32 TabId; // 0x10
	System.String Title; // 0x18
	System.String iconUrl; // 0x20
	System.Boolean redPoint; // 0x28
	System.Int64 EntityId; // 0x30
	System.Void .ctor(); // 0x0634d7a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideNewOven : WizardGames.Soc.SocClient.Ui.UiOthersideNewComBase, WizardGames.Soc.SocClient.Ui.IOtherSideRecipe
{
	WizardGames.Soc.SocClient.Ui.RecipeData curRecipeData; // 0x48
	FairyGUI.GList iconList; // 0x50
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RecipeData> recipeDatas; // 0x58
	FairyGUI.GComponent queueCom; // 0x60
	WizardGames.Soc.SocClient.Ui.UiQueuePanel uiQueuePanel; // 0x68
	FairyGUI.GComponent recipePanelCom; // 0x70
	FairyGUI.GComponent leftTimeNode; // 0x78
	FairyGUI.GTextField leftTimeText; // 0x80
	WizardGames.Soc.SocClient.Ui.ComComboBox ccbox; // 0x88
	FairyGUI.Controller recipeController; // 0x90
	FairyGUI.Controller ctrIsElectrical; // 0x98
	WizardGames.Soc.SocClient.Ui.UiRecipePanel uiRecipePanel; // 0xa0
	WizardGames.Soc.SocClient.Ui.UiElectricalStatePanel uiElectricalStatePanel; // 0xa8
	FairyGUI.GComponent electricalStatePanelCom; // 0xb0
	System.Int32 cacheSelectId; // 0xb8
	System.Int32 cacheComboBoxIndex; // 0xbc
	System.Boolean needPlayAnim; // 0xc0
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.UIRecipeItem> recipeItemGODic; // 0xc8
	System.Collections.Generic.List<System.Int32> tablist; // 0xd0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RecipeData> curTabRecipeDatas; // 0xd8
	System.Void OnInit(); // 0x0634d80c
	System.Void OnClickListItem(FairyGUI.EventContext context); // 0x0634dca0
	System.Void OnEnable(); // 0x0634df58
	System.Void RegisterEvents(); // 0x0634e72c
	System.Void UnRegisterEvents(); // 0x0634ea0c
	System.Void UpdateCtrIsElectrical(System.Boolean isElectrical); // 0x0634ecec
	System.Int32 GetEletricalState(); // 0x0634af40
	System.Void UpdateName(); // 0x0634ed84
	System.Void OnDisable(); // 0x0634edf0
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x0634ee54
	System.Void OnFps10Update(System.Single dt); // 0x0634ef64
	System.Void CacheStatus(); // 0x0634efd8
	System.Void OnOvenDataUpdate(System.Int64 id); // 0x0634f0a8
	System.Void OnOvenDataClaimUpdate(System.Int64 id); // 0x0634f15c
	System.Void OnClaimMoveAimFinish(); // 0x0634f354
	System.Void OnOvenDataCancelUpdate(System.Int64 id); // 0x0634f3c8
	System.Void OnOvenQueueMove(System.Int64 id); // 0x0634f5c0
	System.Void OnInventoryUpdate(); // 0x0634f674
	System.Void Refresh(WizardGames.Soc.SocClient.Ui.ClientCollectionItem collectionItem); // 0x0634fd14
	System.Void OnIconRender(System.Int32 index, FairyGUI.GObject item); // 0x0634fde4
	System.Void SetData(); // 0x0634e024
	System.Void RefreshIconList(); // 0x063504e4
	System.Void ComBoxChange(System.Int32 index); // 0x0634f9b4
	System.Void OnComBoxChange(System.Int32 index); // 0x0635054c
	System.Collections.Generic.List<System.String> GetTitles(); // 0x063500f4
	System.Void RefreshTargetRecpiaId(); // 0x0634ff68
	System.Void SelectRecipe(WizardGames.Soc.SocClient.Ui.RecipeData recipeData); // 0x0634ded8
	System.Void SetRecipe(WizardGames.Soc.SocClient.Ui.RecipeData recipeData); // 0x06350424
	System.Void ClearChooseIcon(); // 0x06350650
	System.Void SoftRecipeList(); // 0x0634f824
	System.Void .ctor(); // 0x063506bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOthersideNewOven.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiOthersideNewOven.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.RecipeData> <>9__53_0; // 0x8
	static System.Void .cctor(); // 0x063508f8
	System.Void .ctor(); // 0x0635095c
	System.Int32 <SoftRecipeList>b__53_0(WizardGames.Soc.SocClient.Ui.RecipeData item1, WizardGames.Soc.SocClient.Ui.RecipeData item2); // 0x063509c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOtherSideNew : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update, WizardGames.Soc.Common.Unity.Ui.IUiTriggerGuide, WizardGames.Soc.Common.Unity.Ui.IUiStopLooting, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	static WizardGames.Soc.SocClient.Ui.UiOtherSideNew Instance; // 0x0
	static SocLogger Log; // 0x8
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.UiOtherSideNewInfo> othersideComNameMap; // 0x338
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.UiOthersideNewComBase> modes; // 0x340
	System.Int64 curCollectionId; // 0x348
	System.Collections.Generic.List<System.Int64> curCollectionIds; // 0x350
	System.String curMode; // 0x358
	WizardGames.Soc.SocClient.Ui.UiOthersideNewComBase curOtherSide; // 0x360
	System.Boolean isClosing; // 0x368
	System.String otherSideUrlStr; // 0x370
	System.String anchorStr; // 0x378
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x380
	System.Int64 foundationId; // 0x388
	UnityEngine.Vector3 checkPos; // 0x390
	UnityEngine.Vector3 playerPos; // 0x39c
	System.Single maxDisSqr; // 0x3a8
	System.Single defaultCloseWinDistanceSqr; // 0x3ac
	System.Single farCloseWinDistanceSqr; // 0x3b0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.OtherSideTabItemData> tabItemDatas; // 0x3b8
	System.Collections.Generic.Dictionary<System.Int64,System.String> entityIdToNames; // 0x3c0
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.ClientCollectionItem> collectionDatas; // 0x3c8
	System.Int64 cacheCollectionId; // 0x3d0
	FairyGUI.GComponent content; // 0x3d8
	FairyGUI.GList tabList; // 0x3e0
	FairyGUI.GLoader loaderTouchRotate; // 0x3e8
	FairyGUI.GGraph graphFx; // 0x3f0
	System.Boolean needReloadWin; // 0x3f8
	WizardGames.Soc.SocClient.Manager.UiConstructionPreviewSceneController uiPreviewSceneController; // 0x400
	UnityEngine.GameObject curGoModel; // 0x408
	System.Int64 curEntityId; // 0x410
	System.Collections.Generic.List<Effect.EffectItemHandle<Effect.EffectItem>> effectItemDic; // 0x418
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x06350aa4
	System.Boolean TriggerGuide(); // 0x06350b30
	System.Void OnInit(); // 0x06350b94
	System.Void OnDestroy(); // 0x063510fc
	System.Void OnCloseItemTips(); // 0x06351258
	System.Void OnClickListItem(FairyGUI.EventContext context); // 0x063512e0
	System.Void RenderLeftTab(System.Int32 index, FairyGUI.GObject obj); // 0x063514cc
	System.Void OnEnable(); // 0x0635165c
	System.Void OnDisable(); // 0x06351c10
	System.Void OnHideByLayerStack(System.String coverUiName); // 0x06352170
	System.Void OnShowByLayerStack(); // 0x06352204
	System.Void OnHideItemTipsBack(); // 0x063526f8
	System.Void OnClientGoCreate(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06352768
	System.Void OnClientGoRemove(WizardGames.Soc.Common.Entity.IEntity entity); // 0x06352848
	System.Void OnPartContainerLinkUpdate(System.Int64 entityId, System.Int64 oldValue, System.Int64 newValue); // 0x06352d98
	System.Void OnSwitchLootingAck(System.Int64 collectionId, System.Collections.Generic.List<System.Int64> collectionIds); // 0x06353048
	System.Void OnOvenNameUpdate(System.Int64 entityId); // 0x063533b4
	System.Void RefreshOtherSideView(System.Boolean isPlaySound); // 0x0635228c
	System.Void OnQueueDataChange(); // 0x06353a5c
	System.Void HideCurOtherSide(); // 0x063520e8
	System.Void InitTabData(); // 0x06353abc
	System.Void InitNavTabNew(); // 0x06353d98
	System.Void SwitchCollection(System.Int64 collectionId); // 0x06351430
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06354b08
	System.Boolean ReloadSwitchLooting(System.Int64 selectCollectionId, System.Int64 removeCollectionId); // 0x06353edc
	System.Void CacheStatusData(); // 0x06352068
	System.Void CloseWin(); // 0x06352c48
	System.Void OnFps30Update(System.Single dt); // 0x06354b80
	System.Void OnFps10Update(System.Single dt); // 0x06354c0c
	System.Void CheckReloadWin(); // 0x06354ea0
	System.Void CheckDis(); // 0x06354c94
	static System.Void OpenOtherSideWin(System.Int64 collectionId, System.Collections.Generic.List<System.Int64> collectionIds, System.Boolean isFromDetailList); // 0x063530f4
	static System.Void OpenOtherSideWin(System.Int64 collectionId, System.Boolean isFromDetailList); // 0x06351a94
	System.Void SelectContainer(System.Int64 collectionId, System.Collections.Generic.List<System.Int64> collectionIds, System.Boolean force, System.Boolean isPlaySound); // 0x06355428
	System.Void InitMaxDis(); // 0x06355b24
	WizardGames.Soc.SocClient.Ui.UiOthersideNewComBase GetOrCreateUiOtherSideBase(System.String mode); // 0x0635357c
	System.Void StopLooting(); // 0x06355e88
	static System.Void RemoveOtherSideWin(); // 0x06355f2c
	System.Void RefreshTabRedPoint(); // 0x06355288
	System.Boolean CheckTemplate(System.Int32 templateId); // 0x06356008
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x063560d4
	System.Void PreparePreviewScene(); // 0x06351068
	System.Void InitPreviewScene(System.Int64 collectionId, WizardGames.Soc.Common.Unity.Ui.WindowComBase windowComBase, System.Boolean isFromDetailList); // 0x063558b8
	System.Void ChangePreviewScene(System.Int64 collectionId); // 0x06355584
	System.Void OnRegisterFlagChangeCallback(System.Int32 lastFlag, System.Int32 newFlag); // 0x06356230
	System.Void DisposePreviewScene(); // 0x0635117c
	System.Void CheckCurFlagWorkingState(System.Int64 collectionId); // 0x063564e0
	System.Void OnSwitchStateChange(System.Int64 entityId, System.Boolean isOpen); // 0x063563b0
	System.Void UpdateEffectState(WizardGames.Soc.Common.Entity.PartEntity partEntity, System.Boolean isOpen, UnityEngine.GameObject goModel); // 0x06356654
	System.Void UpdateBurnModelState(UnityEngine.GameObject goModel, System.Boolean isOpen); // 0x06356c3c
	System.Int32[] GetFxId(System.Int64 partType, System.Int64 skinId); // 0x063570f0
	System.Void LoadEffect(UnityEngine.Transform trParent, System.Int32 fxId, System.Int64 entityId, UnityEngine.GameObject goModel); // 0x06356e38
	System.Void ReleaseEffect(); // 0x0635695c
	System.Void .ctor(); // 0x06357284
	static System.Void .cctor(); // 0x063576e4
	System.Boolean <InitNavTabNew>b__52_0(WizardGames.Soc.SocClient.Ui.OtherSideTabItemData item); // 0x063577b4
	System.Void <DisposePreviewScene>b__81_0(); // 0x06357840
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOtherSideNew.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiOtherSideNew.<>c <>9; // 0x0
	static System.Action<System.Boolean,Effect.EffectItem,System.Object> <>9__87_0; // 0x8
	static System.Func<WizardGames.Soc.SocClient.Ui.UiOthersideNewComBase> <>9__89_0; // 0x10
	static System.Void .cctor(); // 0x06357960
	System.Void .ctor(); // 0x063579c4
	System.Void <LoadEffect>b__87_0(System.Boolean success, Effect.EffectItem item, System.Object obj); // 0x06357a2c
	WizardGames.Soc.SocClient.Ui.UiOthersideNewComBase <.ctor>b__89_0(); // 0x06357b34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOtherSideNew.<>c__DisplayClass63_0 : System.Object
{
	System.Boolean isFromDetailList; // 0x10
	System.Void .ctor(); // 0x06355abc
	System.Void <OpenOtherSideWin>b__0(System.Int64 collectionId, System.Collections.Generic.List<System.Int64> collectionIds); // 0x06357bbc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOtherSideNew.<>c__DisplayClass78_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiOtherSideNew <>4__this; // 0x10
	System.Int64 collectionId; // 0x18
	System.Void .ctor(); // 0x06356160
	System.Void <InitPreviewScene>b__0(UnityEngine.GameObject goBg, UnityEngine.GameObject goModel); // 0x06357c6c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOtherSideNew.<>c__DisplayClass79_0 : System.Object
{
	System.Boolean isUnregister; // 0x10
	WizardGames.Soc.SocClient.Ui.UiOtherSideNew <>4__this; // 0x18
	System.Int64 collectionId; // 0x20
	System.Void .ctor(); // 0x063561c8
	System.Void <ChangePreviewScene>b__0(UnityEngine.GameObject goBg, UnityEngine.GameObject goModel); // 0x06357d30
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiOtherSideNewInfo : System.ValueType
{
	System.String componentName; // 0x10
	System.Func<WizardGames.Soc.SocClient.Ui.UiOthersideNewComBase> creator; // 0x18
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PandoraGraphicRaycaster : UnityEngine.UI.GraphicRaycaster, UnityEngine.ICanvasRaycastFilter
{
	System.Boolean debugLog; // 0x58
	System.Boolean enableFguiBlocking; // 0x59
	static SocLogger logger; // 0x0
	System.Boolean IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera); // 0x06357de8
	System.Void TryLog(System.String msg); // 0x06357fe8
	System.Void .ctor(); // 0x063580b4
	static System.Void .cctor(); // 0x06358148
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPandora : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	UnityEngine.GameObject canvasGo; // 0x338
	System.Void SetPandoraData(System.String appId, UnityEngine.GameObject pandoraGo, System.Boolean bUseCommonCanvas); // 0x0635821c
	System.Void SetAnchorFullScreen(UnityEngine.RectTransform rectTransform); // 0x06358994
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06358aec
	System.Void OnEnable(); // 0x06358ba0
	System.Void OnDisable(); // 0x06358c08
	System.Void .ctor(); // 0x06358cb4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPerformance : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	FairyGUI.GComponent comFps; // 0x338
	FairyGUI.GTextField textFps; // 0x340
	FairyGUI.GComponent comPing; // 0x348
	FairyGUI.GTextField textPing; // 0x350
	FairyGUI.GComponent comLag; // 0x358
	FairyGUI.GTextField textLag; // 0x360
	FairyGUI.GComponent comServerLag; // 0x368
	FairyGUI.GTextField textServerLag; // 0x370
	FairyGUI.GComponent comDeviceFps; // 0x378
	FairyGUI.GTextField textDeviceFps; // 0x380
	FairyGUI.GComponent comThermal; // 0x388
	FairyGUI.GTextField textThermal; // 0x390
	FairyGUI.GComponent comFGUIObj; // 0x398
	FairyGUI.GTextField textFGUIObj; // 0x3a0
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComPerformanceLogInfoBinder binderLogInfo; // 0x3a8
	WizardGames.Soc.Common.Utility.Counter counter; // 0x3b0
	System.Int32 curTarFrame; // 0x3b8
	WizardGames.Soc.AdaptivePerformance.ThermalObserver.EThermalStatus curThermalStatus; // 0x3bc
	System.UInt32 curLag; // 0x3c0
	System.Int32 curSvrLag; // 0x3c4
	System.Int32 curFPS; // 0x3c8
	System.Int32 caculatedFPS; // 0x3cc
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x06358d40
	System.Void OnInit(); // 0x06358dcc
	System.Void OnDestroy(); // 0x063594fc
	System.Void RefreshItemsVisible(); // 0x0635937c
	System.Void onClickLogInfo(); // 0x06359564
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x063595c4
	System.Void RefreshPing(); // 0x06359638
	System.Void OnFps1Update(System.Single dt); // 0x063597bc
	System.Void .ctor(); // 0x06359854
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AddMemberItem : WizardGames.Soc.SocClient.Ui.AnimatedClickableItem
{
	FairyGUI.GGraph animBG; // 0x2d8
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x0635992c
	System.Void Render(System.UInt64 roleId); // 0x06359b24
	System.Void OnAddMemberBtnClick(); // 0x06359d18
	System.Void ResetAnimState(); // 0x0635a2b0
	System.Void .ctor(); // 0x0635a478
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AnimatedClickableItem : WizardGames.Soc.SocClient.Ui.PermissionItemBase
{
	FairyGUI.GButton btnRight; // 0x2b8
	FairyGUI.GGroup animGroup; // 0x2c0
	FairyGUI.Transition animationRemove; // 0x2c8
	FairyGUI.PlayCompleteCallback <AnimCompleteCallback>k__BackingField; // 0x2d0
	FairyGUI.PlayCompleteCallback get_AnimCompleteCallback(); // 0x0635a540
	System.Void set_AnimCompleteCallback(FairyGUI.PlayCompleteCallback value); // 0x0635a5a4
	System.Boolean get_IsPlayingAnim(); // 0x0635a624
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x063599f0
	System.Void Render(System.UInt64 roleId); // 0x06359c88
	System.Void ClearItem(); // 0x0635a944
	System.Void ResetAnimState(); // 0x0635a378
	System.Void .ctor(); // 0x0635a4dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AssignmentItem : WizardGames.Soc.SocClient.Ui.PermissionItemBase
{
	FairyGUI.GList <ContentList>k__BackingField; // 0x2b8
	FairyGUI.GButton btnCntHelp; // 0x2c0
	FairyGUI.Controller identityCtrl; // 0x2c8
	FairyGUI.GList get_ContentList(); // 0x0635aae0
	System.Void set_ContentList(FairyGUI.GList value); // 0x0635ab44
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x0635abc4
	System.Void OnCntHelpClick(FairyGUI.EventContext context); // 0x0635ae08
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiDropdownData> GetDropListData(); // 0x0635afd0
	System.Void AddDataToList(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiDropdownData> dropdownDatas, WizardGames.Soc.SocClient.Ui.UiDropdownData data); // 0x0635b2c4
	WizardGames.Soc.SocClient.Ui.UiDropdownData GetDropListData_AddManger(WizardGames.Soc.SocClient.Ui.RoleIdentity myIdentity); // 0x0635b120
	WizardGames.Soc.SocClient.Ui.UiDropdownData GetDropListData_RemoveManger(WizardGames.Soc.SocClient.Ui.RoleIdentity myIdentity); // 0x0635b3d8
	WizardGames.Soc.SocClient.Ui.UiDropdownData GetDropListData_RemoveMember(WizardGames.Soc.SocClient.Ui.RoleIdentity myIdentity); // 0x0635b54c
	System.Void OnUpgradeClick(); // 0x0635b87c
	System.Void OnDeleteClick(); // 0x0635be24
	System.Void OnDowngradeClick(); // 0x0635c018
	System.Void Render(System.UInt64 roleId); // 0x0635c4ac
	System.Void OnTogglesRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x0635c6bc
	System.String GetAdminUrl(); // 0x0635cc3c
	System.String GetTeammateUrl(); // 0x0635cce0
	System.String GetNormalUrl(); // 0x0635cd84
	System.Void OnToggleClick(FairyGUI.EventContext context); // 0x0635ce28
	System.Boolean IsPermissionOpLock(System.Int32 groupId); // 0x0635c97c
	System.Void ClearItem(); // 0x0635d920
	System.Void .ctor(); // 0x0635da7c
	System.Void <OnUpgradeClick>b__13_0(); // 0x0635dae0
	System.Void <OnDowngradeClick>b__15_0(); // 0x0635dcd0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AssignmentItem.<>c__DisplayClass21_0 : System.Object
{
	System.Int32 targetGroupId; // 0x10
	WizardGames.Soc.SocClient.Ui.AssignmentItem <>4__this; // 0x18
	System.Void .ctor(); // 0x0635d8b8
	System.Void <OnToggleClick>b__0(); // 0x0635dec0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.BuildingDoorData : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.GamePermissionCenter.ItemBuildingDoorBinder binder; // 0x10
	System.String <Title>k__BackingField; // 0x18
	System.String <TipStr>k__BackingField; // 0x20
	System.String get_Title(); // 0x0635dff8
	System.String get_TipStr(); // 0x0635e05c
	System.Void Render(WizardGames.Soc.SocClient.Ui.Binder.GamePermissionCenter.ItemBuildingDoorBinder binder); // 0x0635e0c0
	System.Void .ctor(); // 0x0635e27c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.BuildingDoorSwitchData : WizardGames.Soc.SocClient.Ui.BuildingDoorData
{
	FairyGUI.GTextField off; // 0x28
	FairyGUI.GTextField on; // 0x30
	System.Void Render(WizardGames.Soc.SocClient.Ui.Binder.GamePermissionCenter.ItemBuildingDoorBinder binder); // 0x0635e2e4
	System.Boolean GetSwitchState(); // 0x0635e5bc
	System.Void OnClickSwitchBtn(); // 0x0635e620
	System.Void .ctor(); // 0x0635e680
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.BuildingDoorTwoBtnData : WizardGames.Soc.SocClient.Ui.BuildingDoorData
{
	System.Single LastClickTime; // 0x28
	System.String <FirstBtnStr>k__BackingField; // 0x30
	System.String <TwoBtnStr>k__BackingField; // 0x38
	System.String get_FirstBtnStr(); // 0x0635e6e4
	System.String get_TwoBtnStr(); // 0x0635e748
	System.Void Render(WizardGames.Soc.SocClient.Ui.Binder.GamePermissionCenter.ItemBuildingDoorBinder binder); // 0x0635e7ac
	System.Void ClickBtn1(); // 0x0635ea08
	System.Void ClickBtn2(); // 0x0635eaa0
	System.Void OnClickFirstBtn(); // 0x0635eb38
	System.Void OnClickTwoBtn(); // 0x0635eb98
	System.Void .ctor(); // 0x0635ebf8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.AutoOpenDoorSwitchData : WizardGames.Soc.SocClient.Ui.BuildingDoorTwoBtnData
{
	
	System.String get_Title(); // 0x0635ec5c
	System.String get_TipStr(); // 0x0635ecec
	System.String get_FirstBtnStr(); // 0x0635ed7c
	System.String get_TwoBtnStr(); // 0x0635ee0c
	System.Void OnClickFirstBtn(); // 0x0635ee9c
	System.Void OnClickTwoBtn(); // 0x0635f10c
	System.Void SetAutoDoorState(System.Boolean onlyAutoClose); // 0x0635ef04
	System.Void .ctor(); // 0x0635f174
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.OpenDoorDirSwitchData : WizardGames.Soc.SocClient.Ui.BuildingDoorSwitchData
{
	
	System.String get_Title(); // 0x0635f1d8
	System.String get_TipStr(); // 0x0635f268
	System.Boolean GetSwitchState(); // 0x0635f2f8
	System.Void OnClickSwitchBtn(); // 0x0635f3b8
	System.Void .ctor(); // 0x0635f698
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.BuildingDoorBatchSetDoorBtnData : WizardGames.Soc.SocClient.Ui.BuildingDoorTwoBtnData
{
	
	System.String get_Title(); // 0x0635f6fc
	System.String get_TipStr(); // 0x0635f78c
	System.String get_FirstBtnStr(); // 0x0635f81c
	System.String get_TwoBtnStr(); // 0x0635f8ac
	System.Void OnClickFirstBtn(); // 0x0635f93c
	System.Void OnClickTwoBtn(); // 0x0635fc50
	System.Void .ctor(); // 0x0635ff64
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.BuildingDoorBatchSetDoorBtnData.<>c__DisplayClass8_0 : System.Object
{
	WizardGames.Soc.Common.Entity.TerritoryEntity terrEnt; // 0x10
	System.Void .ctor(); // 0x0635fbe8
	System.Void <OnClickFirstBtn>b__0(); // 0x0635ffc8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.BuildingDoorBatchSetDoorBtnData.<>c__DisplayClass9_0 : System.Object
{
	WizardGames.Soc.Common.Entity.TerritoryEntity terrEnt; // 0x10
	System.Void .ctor(); // 0x0635fefc
	System.Void <OnClickTwoBtn>b__0(); // 0x0636004c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.BuildingDoorItem : FairyGUI.GComponent
{
	WizardGames.Soc.SocClient.Ui.Binder.GamePermissionCenter.ItemBuildingDoorBinder binder; // 0x288
	WizardGames.Soc.SocClient.Ui.BuildingDoorData buildingDoorData; // 0x290
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x063600d0
	System.Void OnSwitchBtnClick(FairyGUI.EventContext context); // 0x06360440
	System.Void OnFirstBtnClick(FairyGUI.EventContext context); // 0x06360510
	System.Void OnTwoBtnClick(FairyGUI.EventContext context); // 0x063605dc
	System.Void SetData(WizardGames.Soc.SocClient.Ui.BuildingDoorData data); // 0x063606a8
	System.Void .ctor(); // 0x06360738
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ManageItem : WizardGames.Soc.SocClient.Ui.AnimatedClickableItem
{
	FairyGUI.GRichTextField inoperable; // 0x2d8
	FairyGUI.GImage meTip; // 0x2e0
	FairyGUI.GButton btnLeft; // 0x2e8
	FairyGUI.GGraph animBG; // 0x2f0
	static UnityEngine.Color RedColor; // 0x0
	static UnityEngine.Color GreenColor; // 0x10
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x063607a0
	System.Void Render(System.UInt64 roleId); // 0x06360920
	System.Void SetButton(System.Boolean leftVisible, System.Boolean rightVisible, System.String left, System.String right, FairyGUI.EventCallback0 leftCallback, FairyGUI.EventCallback0 rightCallback); // 0x06360d10
	System.String GetButtonIcon(System.String buttonName); // 0x06360f50
	UnityEngine.Color GetIconColor(System.String buttonName); // 0x063610dc
	System.Void OnUpgradeClick(); // 0x06361270
	System.Void OnDeleteClick(); // 0x06361818
	System.Void OnDowngradeClick(); // 0x06361a6c
	System.Void ClearItem(); // 0x06361f00
	System.Void ResetAnimState(); // 0x06361f98
	System.Void .ctor(); // 0x063620c0
	static System.Void .cctor(); // 0x06362124
	System.Void <OnUpgradeClick>b__11_0(); // 0x0636217c
	System.Void <OnDowngradeClick>b__13_0(); // 0x0636236c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PermissionItemBase : FairyGUI.GComponent
{
	WizardGames.Soc.SocClient.Ui.ComAvatarSquare comHead; // 0x288
	FairyGUI.GLoader identityIcon; // 0x290
	FairyGUI.GRichTextField playerName; // 0x298
	FairyGUI.GRichTextField playerId; // 0x2a0
	System.UInt64 itemRoleId; // 0x2a8
	WizardGames.Soc.SocClient.Ui.RoleIdentity itemIdentity; // 0x2b0
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x0635a6c8
	System.Void Render(System.UInt64 roleId); // 0x0635a8c8
	System.Boolean HasRole(WizardGames.Soc.SocClient.Ui.RoleIdentity identity); // 0x0635b77c
	System.Boolean OnlyHasRole(WizardGames.Soc.SocClient.Ui.RoleIdentity identity); // 0x0635b7fc
	System.Boolean HasRole(WizardGames.Soc.SocClient.Ui.RoleIdentity checkIdentity, WizardGames.Soc.SocClient.Ui.RoleIdentity identity); // 0x0635b6f8
	System.Void SetPlayerInfo(System.UInt64 roleId); // 0x0636255c
	System.String GetAdminUrl(); // 0x0636289c
	System.String GetTeammateUrl(); // 0x06362914
	System.String GetNormalUrl(); // 0x0636298c
	System.Void ClearItem(); // 0x0635a9b0
	System.Void .ctor(); // 0x0635aa78
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.NoDataView : System.Object
{
	FairyGUI.GComponent bindComponent; // 0x10
	FairyGUI.GRichTextField title; // 0x18
	FairyGUI.GGraph fxRoot; // 0x20
	System.Void .ctor(FairyGUI.GComponent bindComponent); // 0x06362a04
	System.Void SetTitle(System.String content); // 0x06362b18
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.RoleIdentity : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.RoleIdentity None = 0;
	static WizardGames.Soc.SocClient.Ui.RoleIdentity Lord = 1;
	static WizardGames.Soc.SocClient.Ui.RoleIdentity Admin = 2;
	static WizardGames.Soc.SocClient.Ui.RoleIdentity Teammate = 4;
	static WizardGames.Soc.SocClient.Ui.RoleIdentity NormalMember = 16;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPermissionAddMemberPop : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GList contentList; // 0x338
	FairyGUI.Controller emptyController; // 0x340
	FairyGUI.Controller searchController; // 0x348
	FairyGUI.GTextInput searchNameInput; // 0x350
	FairyGUI.GButton searchBtn; // 0x358
	FairyGUI.GButton searchCancelBtn; // 0x360
	WizardGames.Soc.SocClient.Ui.NoDataView noDataView; // 0x368
	WizardGames.Soc.SocClient.Ui.ShadowNavBar navBar; // 0x370
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x378
	FairyGUI.GComponent content; // 0x380
	SocLogger log; // 0x388
	System.Void OnInit(); // 0x06362b98
	System.Void OnEnable(); // 0x06363488
	System.Void OnDisable(); // 0x06363500
	System.Void OnPlayerSearchResultGet(); // 0x06363568
	System.Void Refresh(); // 0x06363778
	System.Void OnLabelClick(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x06363a04
	System.Void OnMemberItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x06363c28
	System.Void OnSearchBtnClick(); // 0x06363ee8
	System.Boolean HasItemPlayingAnim(); // 0x06363894
	System.Void .ctor(); // 0x06364278
	System.Void <OnInit>b__11_0(); // 0x063643a0
	System.Void <OnInit>b__11_1(); // 0x0636444c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPermissionCenter : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.UiPermissionCenter.ELeftTab curTabType; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.GamePermissionCenter.RootPermissionCenterBinder binder; // 0x340
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x348
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x350
	FairyGUI.GList listHeader; // 0x358
	FairyGUI.GList listBody; // 0x360
	FairyGUI.GList buildingList; // 0x368
	System.Int64 tickTimer; // 0x370
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiPermissionCenter.ELeftTab> leftTabs; // 0x378
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.BuildingDoorData> buildingDoorDatas; // 0x380
	System.Void OnInit(); // 0x063644f4
	System.Void OnEnable(); // 0x055049cc
	System.Void OnDisable(); // 0x06365d30
	System.Void OnDestroy(); // 0x06365e5c
	System.Void InitLeftTab(); // 0x06365748
	System.Void RefreshView(); // 0x06365f0c
	System.Void RefreshPermissionView(); // 0x06366128
	System.Void RefreshUnionInfo(); // 0x06366c3c
	System.Boolean IsShowUnion(System.String& unionName, System.Collections.Generic.List<System.Int32>& iconList); // 0x063672e0
	System.Void RefreshAdminCnt(); // 0x06366918
	System.Void RefreshCenterName(System.Int64 entityId); // 0x0636754c
	System.Void RefreshRename(); // 0x06366410
	System.String GetCenterName(); // 0x06367634
	System.Void RefreshBuildingView(); // 0x06366388
	System.Void OnClickAddMember(); // 0x06367768
	System.Void OnClickRename(); // 0x063677cc
	System.Void RenameTerritory(); // 0x063678d0
	System.Void ClientRename(System.String newName); // 0x06367adc
	System.Void OnHeaderRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x06367edc
	System.Void OnAssignmentItemsRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x06368384
	System.Void OnBuildingItemsRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x06368500
	System.Void TickCheck(); // 0x06368604
	System.Void CloseCenterUI(); // 0x06368c4c
	static System.Void Open(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x06368e38
	static System.Boolean IsIdentityLegal(); // 0x06368fdc
	System.Void .ctor(); // 0x06369384
	System.Void <OnInit>b__11_0(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x063694b4
	System.Void <OnEnable>b__12_0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x0636958c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiPermissionCenter.ELeftTab : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiPermissionCenter.ELeftTab Permission = 0;
	static WizardGames.Soc.SocClient.Ui.UiPermissionCenter.ELeftTab Building = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPermissionGuidePop : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GButton btnClose; // 0x338
	FairyGUI.GList guideList; // 0x340
	System.Void OnInit(); // 0x06369684
	System.Void OnItemGuideRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x06369ae0
	System.Void .ctor(); // 0x06369ee4
	System.Void <OnInit>b__2_0(FairyGUI.EventContext ctx); // 0x06369f70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPermissionSearch : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GList leftBarList; // 0x338
	FairyGUI.GTextInput _inputSearch; // 0x340
	FairyGUI.GButton _btnSearchClear; // 0x348
	FairyGUI.GButton _btnSearchConfirm; // 0x350
	FairyGUI.Controller _searchController; // 0x358
	FairyGUI.GList contentList; // 0x360
	WizardGames.Soc.SocClient.Ui.Binder.GamePermissionCenter.UiPermissionSearchBinder binder; // 0x368
	SocLogger log; // 0x370
	System.Void OnInit(); // 0x06369ff0
	System.Void OnInputSearchChanged(FairyGUI.EventContext context); // 0x0636ac50
	System.Void OnBtnSearchConfirmClicked(FairyGUI.EventContext context); // 0x0636ad0c
	System.Void OnBtnSearchClearClicked(FairyGUI.EventContext context); // 0x0636b19c
	System.Void InitLeftBarList(); // 0x0636a840
	System.String EleftTab2Name(WizardGames.Soc.SocClient.Ui.UiPermissionSearch.ELeftTab tab); // 0x0636b2bc
	System.Void ChangeTab(WizardGames.Soc.SocClient.Ui.UiPermissionSearch.ELeftTab tab); // 0x0636b3e4
	System.Void OnPlayerSearchResultGet(); // 0x0636b5e0
	System.Void OnMemberItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x0636babc
	System.Void Refresh(); // 0x0636b9a0
	System.Boolean HasItemPlayingAnim(); // 0x0636bd7c
	static System.Void Open(); // 0x0636bef0
	System.Void .ctor(); // 0x0636bfcc
	System.Void <OnInit>b__9_0(FairyGUI.EventContext ctx); // 0x0636c0f4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiPermissionSearch.ELeftTab : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiPermissionSearch.ELeftTab Search = 0;
	static WizardGames.Soc.SocClient.Ui.UiPermissionSearch.ELeftTab Friend = 1;
	static WizardGames.Soc.SocClient.Ui.UiPermissionSearch.ELeftTab TempFriend = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPermissionSearch.<>c__DisplayClass13_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiPermissionSearch.ELeftTab i; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPermissionSearch <>4__this; // 0x18
	System.Void .ctor(); // 0x0636b254
	System.Void <InitLeftBarList>b__0(FairyGUI.EventContext ctx); // 0x0636c170
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiJoyStickBase : System.Object
{
	FairyGUI.GComponent Root; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPhoto Parent; // 0x18
	FairyGUI.GButton MainBtn; // 0x20
	FairyGUI.GObject DraggableObject; // 0x28
	FairyGUI.GObject TouchAreaObject; // 0x30
	System.Boolean <CanControlView>k__BackingField; // 0x38
	System.Boolean get_CanControlView(); // 0x0636c1f4
	System.Void OnCreate(); // 0x0636c258
	System.Void OnDestroy(); // 0x0636c2b8
	System.Void TouchBegin(FairyGUI.EventContext context); // 0x0636c334
	System.Void TouchMove(FairyGUI.EventContext context); // 0x0636c414
	System.Void TouchEnd(FairyGUI.EventContext context); // 0x0636c550
	System.Void UpdateTouchPos(UnityEngine.Vector2 pos, WizardGames.Soc.Common.Unity.EPhotoControlPhaseEnum phaseEnum); // 0x0636c610
	System.Void SetCenterPos(FairyGUI.GObject obj, UnityEngine.Vector2 pos); // 0x0636c6a0
	UnityEngine.Vector2 GetCenterPos(FairyGUI.GObject obj); // 0x0636c7f8
	System.Void .ctor(); // 0x0636c918
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiJoyStickMove : WizardGames.Soc.SocClient.Ui.UiJoyStickBase
{
	
	System.Void OnCreate(); // 0x0636c988
	System.Void OnDestroy(); // 0x0636cbb4
	System.Void TouchBegin(FairyGUI.EventContext context); // 0x0636cc18
	System.Void TouchMove(FairyGUI.EventContext context); // 0x0636cf80
	System.Void TouchEnd(FairyGUI.EventContext context); // 0x0636cffc
	System.Void UpdateTouchPos(UnityEngine.Vector2 pos, WizardGames.Soc.Common.Unity.EPhotoControlPhaseEnum phaseEnum); // 0x0636d1a4
	System.Void SetVisible(System.Boolean visible); // 0x0636d470
	System.Void .ctor(); // 0x0636d50c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiJoyStickRoll : WizardGames.Soc.SocClient.Ui.UiJoyStickBase
{
	System.Boolean _isRollOver; // 0x39
	FairyGUI.Controller _resetController; // 0x40
	System.Void OnCreate(); // 0x0636d570
	System.Void OnDestroy(); // 0x0636d960
	System.Void TouchBegin(FairyGUI.EventContext context); // 0x0636d9c4
	System.Void TouchMove(FairyGUI.EventContext context); // 0x0636dae8
	System.Void TouchEnd(FairyGUI.EventContext context); // 0x0636db64
	System.Void UpdateTouchPos(UnityEngine.Vector2 pos, WizardGames.Soc.Common.Unity.EPhotoControlPhaseEnum phaseEnum); // 0x0636dd20
	System.Void OnResetBtnRollOver(FairyGUI.EventContext context); // 0x0636e098
	System.Void OnResetBtnRollOut(FairyGUI.EventContext context); // 0x0636e114
	System.Void OnSetButtonTouchEnd(); // 0x0636e18c
	System.Void ShowResetBtn(System.Boolean show); // 0x0636e2e8
	System.Void SetVisible(System.Boolean visible); // 0x0636e370
	System.Void .ctor(); // 0x0636e438
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiJoyStickRotate : WizardGames.Soc.SocClient.Ui.UiJoyStickBase
{
	
	System.Void OnCreate(); // 0x0636e49c
	System.Void OnDestroy(); // 0x0636e6a4
	System.Void TouchBegin(FairyGUI.EventContext context); // 0x0636e708
	System.Void TouchMove(FairyGUI.EventContext context); // 0x0636e79c
	System.Void TouchEnd(FairyGUI.EventContext context); // 0x0636e818
	System.Void UpdateTouchPos(UnityEngine.Vector2 pos, WizardGames.Soc.Common.Unity.EPhotoControlPhaseEnum phaseEnum); // 0x0636e944
	System.Void .ctor(); // 0x0636ecdc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBottomBarPC : WizardGames.Soc.SocClient.Ui.UiPhotoComBase
{
	FairyGUI.GList _list; // 0x20
	System.Void InitComponents(); // 0x0636ed40
	System.Void AddListItems(); // 0x0636ee4c
	System.Void OnEnable(); // 0x0636eeac
	System.Void OnDisable(); // 0x0636ef78
	System.Void RegisterEvents(); // 0x0636f03c
	System.Void UnregisterEvents(); // 0x0636f26c
	System.Void Destroy(); // 0x0636f49c
	System.Void OnPhotoFreeEntered(); // 0x0636f564
	System.Void OnPhotoFreeLeaved(); // 0x0636f5c4
	System.Void OnPhotoHideAllUI(System.Boolean isHide); // 0x0636f624
	System.Void .ctor(); // 0x0636f698
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCameraControl : WizardGames.Soc.SocClient.Ui.UiPhotoComBase
{
	FairyGUI.Controller _scaleController; // 0x20
	FairyGUI.Controller _perspectiveController; // 0x28
	FairyGUI.GButton _btnDistance; // 0x30
	FairyGUI.GButton _btnTakeShot; // 0x38
	FairyGUI.GObject _tickMarkBig; // 0x40
	FairyGUI.GComponent _touchArea; // 0x48
	UnityEngine.Vector2 _lastTouchPos; // 0x50
	System.Single _angleForAudio; // 0x58
	System.Single _multiplier; // 0x5c
	System.Single _minAngle; // 0x60
	System.Single _maxAngle; // 0x64
	System.Single _angleForAudioTotal; // 0x68
	System.Void InitComponents(); // 0x0636f764
	System.Void InitData(WizardGames.Soc.Common.Unity.PhotoData data); // 0x0636fc7c
	System.Void Destroy(); // 0x0636ff24
	System.Void RegisterEvents(); // 0x0636ff8c
	System.Void UnregisterEvents(); // 0x0637015c
	System.Void OnClose(); // 0x0637032c
	System.Void ResetConfig(WizardGames.Soc.Common.Unity.PhotoData data); // 0x0637049c
	System.Void UpdateUI(WizardGames.Soc.Common.Unity.PhotoData data); // 0x063705a0
	System.Void OnPhotoFpEntered(); // 0x06370624
	System.Void OnPhotoTpEntered(); // 0x06370698
	System.Void OnTouchAreaTouchBegin(FairyGUI.EventContext context); // 0x0637070c
	System.Void OnTouchAreaTouchMove(FairyGUI.EventContext context); // 0x06370a5c
	System.Void OnTouchAreaTouchEnd(FairyGUI.EventContext context); // 0x063712c0
	System.Single GetWheelAngle(UnityEngine.Vector2 value); // 0x06370f04
	System.Void OnBtnTakeShotClicked(); // 0x063714e4
	System.Void SetText(System.Single value); // 0x0636fdfc
	UnityEngine.Vector2 GetCenterPos(FairyGUI.GObject obj); // 0x0637093c
	System.Void PlayAudio(System.Single angle); // 0x06371060
	System.Void HideExceptShotBtn(System.Boolean isHide); // 0x06371580
	System.Void SetTouchable(System.Boolean isTouchable); // 0x06370414
	System.Void .ctor(); // 0x0637160c
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.DollyTrackCameraSettings : System.ValueType
{
	System.Single DollyTrackSpeed; // 0x10
	System.Boolean IsSpeedAdaptToPathDensity; // 0x14
	System.Boolean IslookingAtPoint; // 0x15
	System.Single LookAtPointSpeed; // 0x18
	UnityEngine.Vector2 OffsetRatio; // 0x1c
	System.Single NaturalShakeAmplitude; // 0x24
	System.Void .ctor(System.Single speed, System.Boolean adaptToDensity, System.Boolean lookAtPoint, System.Single lookAtSpeed, UnityEngine.Vector2 offsetRatio, System.Single naturalShakeAmplitude); // 0x0637167c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCameraRoute : WizardGames.Soc.SocClient.Ui.UiPhotoComBase
{
	SocLogger logger; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.GameCamera.ComCameraRouteBinder _binder; // 0x28
	WizardGames.Soc.SocClient.Ui.DollyTrackCameraSettings _cameraSettings; // 0x30
	WizardGames.Soc.SocClient.Ui.Binder.GameCamera.BtnSwitchTextBinder _pathEditSwitchBtn; // 0x48
	System.Boolean _isPathEditMode; // 0x50
	FairyGUI.GButton _trackCameraStartBtn; // 0x58
	WizardGames.Soc.SocClient.Ui.Binder.GameCamera.BtnSwitchTextBinder _trackPathLoopBtn; // 0x60
	FairyGUI.GSlider _trackCameraSpeedSlider; // 0x68
	WizardGames.Soc.SocClient.Ui.Binder.GameCamera.BtnSwitchTextBinder _pathSpeedAdaptBtn; // 0x70
	WizardGames.Soc.SocClient.Ui.Binder.GameCamera.BtnSwitchTextBinder _lookAtTargetBtn; // 0x78
	FairyGUI.GSlider _lookAtTargetSpeedSlider; // 0x80
	FairyGUI.GSlider _lookAtTargetHorizontalOffsetSlider; // 0x88
	FairyGUI.GSlider _lookAtTargetVerticalOffsetSlider; // 0x90
	FairyGUI.GSlider _naturalShakeAmplitudeSlider; // 0x98
	System.Void InitComponents(); // 0x06371760
	System.Void OnShow(); // 0x063722b0
	System.Void RegisterEvents(); // 0x063723f4
	System.Void UnregisterEvents(); // 0x06372500
	System.Void OnPathEditSwitchBtnClick(); // 0x0637260c
	System.Void StartTrackCameraWithCurrentSetting(); // 0x063727a4
	System.Void OnTrackCameraStartBtnClick(); // 0x06372bfc
	System.Void OnPathLoopBtnClick(); // 0x06372c60
	System.Void OnPathLoopChange(System.Boolean isLoop); // 0x06372da8
	System.Void OnClose(); // 0x06372ebc
	System.Void .ctor(); // 0x06372f1c
	System.Void <InitComponents>b__14_0(); // 0x06373050
	System.Void <InitComponents>b__14_1(); // 0x0637314c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCameraSetting : WizardGames.Soc.SocClient.Ui.UiPhotoComBase
{
	FairyGUI.GTextField _txtFocalLength; // 0x20
	FairyGUI.GSlider _sliderFocalLength; // 0x28
	FairyGUI.GTextField _txtAperture; // 0x30
	FairyGUI.GSlider _sliderAperture; // 0x38
	FairyGUI.GButton _btnManualFocus; // 0x40
	FairyGUI.GTextField _txtRealFocalLength; // 0x48
	FairyGUI.GSlider _sliderRealFocalLength; // 0x50
	FairyGUI.GTextField _txtFocusDistance; // 0x58
	FairyGUI.GSlider _sliderFocusDistance; // 0x60
	FairyGUI.GButton _btnHideSelf; // 0x68
	FairyGUI.GButton _btnHideTeam; // 0x70
	FairyGUI.Controller _manualFocusController; // 0x78
	System.Void InitComponents(); // 0x06373248
	System.Void InitData(WizardGames.Soc.Common.Unity.PhotoData data); // 0x06373b10
	System.Void ResetConfig(WizardGames.Soc.Common.Unity.PhotoData data); // 0x06374d98
	System.Void RegisterEvents(); // 0x06374e14
	System.Void UnregisterEvents(); // 0x06374f28
	System.Void Destroy(); // 0x0637503c
	System.Void OnClose(); // 0x063750a0
	System.Void UpdateUI(WizardGames.Soc.Common.Unity.PhotoData data); // 0x06375104
	System.Void InitFocalLength(); // 0x06373700
	System.Void InitAperture(); // 0x063737d0
	System.Void InitRealFocalLength(); // 0x063738a0
	System.Void InitManualFocus(); // 0x06373970
	System.Void OnBtnManualFocusClicked(); // 0x063753e8
	System.Void InitFocusDistance(); // 0x06373a40
	System.Void OnSliderFocalLengthChanged(FairyGUI.EventContext context); // 0x06375514
	System.Void OnSliderApertureChanged(FairyGUI.EventContext context); // 0x063755f0
	System.Void OnSliderRealFocalLengthChanged(FairyGUI.EventContext context); // 0x063756cc
	System.Void OnSliderFocusDistanceChanged(FairyGUI.EventContext context); // 0x063757a8
	System.Void SetTxtFocalLength(); // 0x06374118
	System.Void SetTxtAperture(); // 0x063742d8
	System.Void SetTxtRealFocalLength(); // 0x0637446c
	System.Void SetTxtFocusDistance(); // 0x063745b0
	System.Void OnBtnHideSelfClicked(); // 0x06375884
	System.Void OnBtnHideTeamClicked(); // 0x06375948
	System.Void .ctor(); // 0x06375a0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLeftNavBar : WizardGames.Soc.SocClient.Ui.UiPhotoComBase
{
	FairyGUI.GList _btnList; // 0x20
	FairyGUI.GButton _adminBtn; // 0x28
	FairyGUI.Controller _typeController; // 0x30
	FairyGUI.Controller _adminController; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.PhotoComData> _btnDataList; // 0x40
	System.Int32 _lastIndex; // 0x48
	System.Boolean _isSelected; // 0x4c
	System.Boolean _isFold; // 0x4d
	System.Boolean shrink; // 0x4e
	System.Void InitComponents(); // 0x06375a70
	System.Void OnEnable(); // 0x06375cf8
	System.Void OnDisable(); // 0x063764b0
	System.Void ClearKeyTipsAction(); // 0x0637652c
	System.Void RegisterEvents(); // 0x0637658c
	System.Void UnregisterEvents(); // 0x06376788
	System.Void Destroy(); // 0x06376984
	System.Void ResetConfig(WizardGames.Soc.Common.Unity.PhotoData data); // 0x06376a44
	System.Void InitBtnListData(); // 0x06375df0
	System.Void RefreshBtnList(System.Boolean shrink); // 0x06376bc4
	System.Void OnItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x06376c84
	System.Void HandleRedDot(WizardGames.Soc.SocClient.Ui.PhotoComData data, FairyGUI.GButton btn); // 0x06377124
	System.Void RefreshGestureRedDot(); // 0x063772b8
	System.Void OnBtnRollOver(System.Int32 index); // 0x06377328
	System.Void OnBtnClicked(System.Int32 index); // 0x0637740c
	System.Void ResetBtn(System.Int32 index); // 0x06377684
	System.Void OnClose(); // 0x06377914
	System.Void OnPhotoFpEntered(); // 0x06377ad4
	System.Void OnPhotoTpEntered(); // 0x06377ce4
	System.Void OnPhotoFreeEntered(); // 0x06377d70
	System.Void ResetNavBar(); // 0x06377e40
	System.Void ResetNavBar(System.Boolean hasChanged, System.Boolean toShrink); // 0x06377ba4
	System.Void OnAdminBtnClicked(); // 0x06377f94
	System.Void ResetAdminBtn(); // 0x06378108
	System.Void ResetBg(); // 0x0637817c
	System.Void .ctor(); // 0x063781f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLeftNavBar.<>c__DisplayClass19_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLeftNavBar <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Void .ctor(); // 0x063770bc
	System.Void <OnItemRenderer>b__0(FairyGUI.EventContext _); // 0x063782b0
	System.Void <OnItemRenderer>b__1(FairyGUI.EventContext _); // 0x06378334
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLeftPage : WizardGames.Soc.SocClient.Ui.UiPhotoComBase
{
	FairyGUI.GList _templateList; // 0x20
	FairyGUI.GList _gestureList; // 0x28
	FairyGUI.GList _filterList; // 0x30
	WizardGames.Soc.SocClient.Ui.UiCameraSetting _uiCameraSetting; // 0x38
	WizardGames.Soc.SocClient.Ui.UiCameraRoute _cameraRoute; // 0x40
	FairyGUI.Controller _controller; // 0x48
	System.Int32 _lastTemplateId; // 0x50
	System.Int64 _lastGestureId; // 0x58
	System.Int32 _lastFilterId; // 0x60
	System.Boolean _isFilterSelected; // 0x64
	System.Void InitComponents(); // 0x063783b8
	System.Void Destroy(); // 0x063786a8
	System.Void OnClose(); // 0x06378744
	System.Void RegisterEvents(); // 0x0637881c
	System.Void UnregisterEvents(); // 0x063788a4
	System.Void InitData(WizardGames.Soc.Common.Unity.PhotoData data); // 0x0637892c
	System.Void ResetConfig(WizardGames.Soc.Common.Unity.PhotoData data); // 0x06378e04
	System.Void ShowPageByIndex(System.Int32 index); // 0x063791d0
	System.Void RefreshPage(System.Int32 index); // 0x0637928c
	System.Void InitTemplateList(System.Int32 calledId); // 0x06378a10
	System.Void OnTemplateBtnClickedByCall(FairyGUI.GComponent com, System.Int32 templateId); // 0x063796c0
	System.Void OnTemplateBtnClicked(System.Int32 templateId); // 0x0637978c
	System.Void InitGestureList(); // 0x06379400
	System.Void OnGestureBtnClicked(System.Int64 gestureId); // 0x06379890
	System.Void InitFilterList(System.Int32 callId); // 0x06378c08
	System.Void OnFilterBtnClickedByCall(FairyGUI.GComponent com, System.Int32 filterId); // 0x06379b34
	System.Void OnFilterBtnClicked(System.Int32 filterId); // 0x06379c08
	System.Void InitCameraSetting(); // 0x063793a0
	System.Void StartTrackCamera(); // 0x06379da0
	System.Void .ctor(); // 0x06379e14
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLeftPage.<>c__DisplayClass19_0 : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Photo.PhotoPreset> tb; // 0x10
	WizardGames.Soc.SocClient.Ui.UiLeftPage <>4__this; // 0x18
	System.Int32 calledId; // 0x20
	System.Void .ctor(); // 0x06379658
	System.Void <InitTemplateList>b__0(System.Int32 index, FairyGUI.GObject item); // 0x06379e94
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLeftPage.<>c__DisplayClass19_1 : System.Object
{
	WizardGames.Soc.Common.Data.Photo.PhotoPreset data; // 0x10
	WizardGames.Soc.SocClient.Ui.UiLeftPage.<>c__DisplayClass19_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x0637a164
	System.Void <InitTemplateList>b__1(FairyGUI.EventContext _); // 0x0637a1cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLeftPage.<>c__DisplayClass22_0 : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.GestureConfig> tb; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Manager.CommonSkinData> ownedGestures; // 0x18
	WizardGames.Soc.SocClient.Ui.UiLeftPage <>4__this; // 0x20
	System.Void .ctor(); // 0x06379828
	System.Void <InitGestureList>b__0(System.Int32 index, FairyGUI.GObject item); // 0x0637a260
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLeftPage.<>c__DisplayClass22_1 : System.Object
{
	WizardGames.Soc.Common.Data.DataItem.GestureConfig data; // 0x10
	WizardGames.Soc.SocClient.Ui.UiLeftPage.<>c__DisplayClass22_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x0637a61c
	System.Void <InitGestureList>b__1(FairyGUI.EventContext _); // 0x0637a684
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLeftPage.<>c__DisplayClass24_0 : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Photo.PhotoFilter> tb; // 0x10
	WizardGames.Soc.SocClient.Ui.UiLeftPage <>4__this; // 0x18
	System.Void .ctor(); // 0x06379acc
	System.Void <InitFilterList>b__0(System.Int32 index, FairyGUI.GObject item); // 0x0637a718
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLeftPage.<>c__DisplayClass24_1 : System.Object
{
	WizardGames.Soc.Common.Data.Photo.PhotoFilter data; // 0x10
	WizardGames.Soc.SocClient.Ui.UiLeftPage.<>c__DisplayClass24_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x0637aa50
	System.Void <InitFilterList>b__1(FairyGUI.EventContext _); // 0x0637aab8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPhoto : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GComponent _content; // 0x338
	FairyGUI.GList _topRightBtnList; // 0x340
	FairyGUI.GButton _closeBtn; // 0x348
	FairyGUI.GButton _tpFpSwitchBtn; // 0x350
	FairyGUI.GButton _vehicleUiSwitchBtn; // 0x358
	WizardGames.Soc.SocClient.Ui.UiJoyStickRotate _camRotateBtn; // 0x360
	WizardGames.Soc.SocClient.Ui.UiJoyStickMove _camMoveBtn; // 0x368
	WizardGames.Soc.SocClient.Ui.UiJoyStickRoll _camRollBtn; // 0x370
	FairyGUI.Controller _leftPageController; // 0x378
	FairyGUI.Controller _perspectiveController; // 0x380
	FairyGUI.Controller _visibleController; // 0x388
	WizardGames.Soc.SocClient.Ui.UiLeftNavBar _leftNavBar; // 0x390
	WizardGames.Soc.SocClient.Ui.UiCameraControl _cameraControl; // 0x398
	WizardGames.Soc.SocClient.Ui.UiLeftPage _leftPage; // 0x3a0
	WizardGames.Soc.SocClient.Ui.UiBottomBarPC _bottomBarPC; // 0x3a8
	FairyGUI.GTextField _wheelTextPC; // 0x3b0
	WizardGames.Soc.SocClient.Ui.UiRightActionList _rightActionList; // 0x3b8
	FairyGUI.GTextField _countDownNum; // 0x3c0
	FairyGUI.GButton _continueBtn; // 0x3c8
	FairyGUI.GButton _quitBtn; // 0x3d0
	FairyGUI.Controller _playStatusCtrl; // 0x3d8
	FairyGUI.GLoader _clickMask; // 0x3e0
	System.Boolean _isVisible; // 0x3e8
	WizardGames.Soc.Common.Unity.PhotoData _defaultData; // 0x3f0
	WizardGames.Soc.Common.Unity.PhotoData _savedData; // 0x3f8
	System.Int32 _countDownTotal; // 0x400
	System.Int32 _countDownCurrent; // 0x404
	System.Int64 _timerId; // 0x408
	System.Boolean _isFp; // 0x410
	System.Boolean IsNavBarShrink; // 0x411
	System.Boolean _isSwitchFpTpBtnVisible; // 0x412
	System.Boolean _isHideVehicleUIBtnVisible; // 0x413
	WizardGames.Soc.Common.Unity.PhotoData get_SavedData(); // 0x0637ab4c
	System.Boolean get_IsFp(); // 0x0637abb0
	System.Void set_IsFp(System.Boolean value); // 0x0637ac14
	System.Void InitComponents(); // 0x0637ae70
	System.Void OnInit(); // 0x0637b9f8
	System.Void InitData(WizardGames.Soc.Common.Unity.PhotoData defaultData, WizardGames.Soc.Common.Unity.PhotoData savedData, System.Boolean isFirst); // 0x0637c58c
	System.Void OnEnable(); // 0x0637c69c
	System.Void OnDisable(); // 0x0637ca50
	System.Void OnDestroy(); // 0x0637cad0
	System.Void RegisterEvents(); // 0x0637bc20
	System.Void UnregisterEvent(); // 0x0637ccec
	System.Void InitRightBtnList(); // 0x0637c0a0
	System.Void UpdateSideGuide(System.Boolean isFreeMode, System.Boolean visible); // 0x0637aca4
	System.Void SetUiVisible(FairyGUI.GButton btn); // 0x0637c730
	System.Void SetAllUiVisible(System.Boolean isVisible); // 0x0637cf94
	System.Void ResetConfig(); // 0x0637d0f8
	System.Void OnPhotoFpEntered(); // 0x0637d1f8
	System.Void OnPhotoTpEntered(); // 0x0637d5fc
	System.Void OnPhotoFreeEntered(); // 0x0637d784
	System.Void OnPhotoFreeLeaved(); // 0x0637d8ec
	System.Void OnPhotoTrackEntered(); // 0x0637d94c
	System.Void EnterTrackCountDown(); // 0x055049cc
	System.Void UpdateCountDownNum(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x0637dcb0
	System.Void OnCountDownOver(); // 0x0637de04
	System.Void TrackCameraMaskOnClick(); // 0x0637df70
	System.Void OnContinueBtnClicked(); // 0x0637e140
	System.Void OnQuitBtnClicked(); // 0x0637e218
	System.Void OnPhotoTrackLeaved(); // 0x0637e2b4
	System.Void StartDollyTrackCamera(); // 0x0637e334
	System.Void OnLeftNavBtnClicked(System.Int32 index, System.Boolean isOtherBtnClicked); // 0x06377810
	System.Void LeftPageVisible(System.Boolean isVisible); // 0x06377f0c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0637e3a8
	System.Void OnClose(); // 0x0637e420
	System.Void OnEmptyForTouchBtnClicked(UnityEngine.Vector2 touchPos); // 0x0637e840
	System.Boolean IsInsideCom(FairyGUI.GComponent com, UnityEngine.Vector2 pos); // 0x0637e988
	System.Void RefreshGestureRedDot(); // 0x06379a60
	System.Void OnMountableChanged(System.Int64 mountableId); // 0x0637eb08
	System.Void ChangeTemplate(System.Int32 index, System.Boolean isReset); // 0x06378f18
	System.Void ChangeGesture(System.Int64 index, System.Boolean isReset); // 0x06379000
	System.Void ChangeFilter(System.Int32 index, System.Boolean isReset); // 0x063790e8
	System.Void ChangeFocalLengthScale(System.Double focalLengthScale); // 0x063746fc
	System.Void ChangeAperture(System.Double aperture); // 0x063747e0
	System.Void ChangeIsManualFocus(System.Boolean isManualFocus); // 0x06374aec
	System.Void ChangeRealFocalLength(System.Double realFocalLength); // 0x06374cb4
	System.Void ChangeFocusDistance(System.Double focusDistance); // 0x06374bd0
	System.Void ChangeRigRadius(System.Single radiusScale); // 0x063711d8
	System.Void ChangeHideSelf(System.Boolean hideSelf); // 0x06374924
	System.Void ChangeHideTeam(System.Boolean hideTeam); // 0x06374a08
	System.Void ApplyWheelRotation(); // 0x0637ecb0
	System.Void ApplyWheelRotationPC(); // 0x0637ad20
	System.Void SwitchFpTp(FairyGUI.GButton btn); // 0x0637ed28
	System.Void SetSwitchFpTpBtnIcon(); // 0x0637d380
	System.Void SwitchVehicleUI(FairyGUI.GButton btn); // 0x0637f0c0
	System.Void OnPhotoShowVehicleHud(); // 0x0637f344
	System.Void OnPhotoHideVehicleHud(); // 0x0637f3b4
	System.Void SetSwitchVehicleUIBtnIcon(); // 0x0637e698
	System.Void OnJoyStickRollTouchBegin(); // 0x0636da78
	System.Void OnJoyStickRollTouchEnd(); // 0x0636dcb0
	System.Void OnJoyStickMoveTouchBegin(); // 0x0636ccb8
	System.Void OnJoyStickMoveTouchEnd(); // 0x0636d134
	System.Void OnJoyStickReset(); // 0x0636e1f8
	System.Void HideAllExceptJoystick(WizardGames.Soc.Common.Unity.EPhotoControlEnum controlEnum, System.Boolean isVisible); // 0x0636cd28
	System.Void HideJoySticks(System.Boolean isVisible); // 0x0637d528
	System.Void .ctor(); // 0x0637f424
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPhoto.<>c__DisplayClass46_0 : System.Object
{
	System.Collections.Generic.List<System.String[]> iconList; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPhoto <>4__this; // 0x18
	System.Void .ctor(); // 0x0637cf2c
	System.Void <InitRightBtnList>b__0(System.Int32 index, FairyGUI.GObject item); // 0x0637f4c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPhoto.<>c__DisplayClass46_1 : System.Object
{
	System.Int32 index; // 0x10
	FairyGUI.GButton btn; // 0x18
	WizardGames.Soc.SocClient.Ui.UiPhoto.<>c__DisplayClass46_0 CS$<>8__locals1; // 0x20
	System.Void .ctor(); // 0x0637f6a4
	System.Void <InitRightBtnList>b__1(FairyGUI.EventContext _); // 0x0637f70c
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.PhotoComData : System.ValueType
{
	System.String Name; // 0x10
	System.String IconPath; // 0x18
	System.String IconBgPath; // 0x20
	System.String IconSelectedPath; // 0x28
	WizardGames.Soc.Common.Data.ActionName ActionName; // 0x30
	System.Void .ctor(WizardGames.Soc.Common.Data.ActionName actionName, System.String name, System.String iconPath, System.String iconBgPath, System.String iconSelectedPath); // 0x06376ad4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPhotoComBase : System.Object
{
	FairyGUI.GComponent Root; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPhoto Parent; // 0x18
	System.Void InitComponents(); // 0x0636edec
	System.Void InitData(WizardGames.Soc.Common.Unity.PhotoData data); // 0x0636fd88
	System.Void ResetConfig(WizardGames.Soc.Common.Unity.PhotoData data); // 0x0637052c
	System.Void RegisterEvents(); // 0x0636f20c
	System.Void UnregisterEvents(); // 0x0636f43c
	System.Void Destroy(); // 0x0636f504
	System.Void OnClose(); // 0x063703b4
	System.Void OnEnable(); // 0x0636ef18
	System.Void OnDisable(); // 0x0636efdc
	System.Void .ctor(); // 0x0636f6fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRightActionList : WizardGames.Soc.SocClient.Ui.UiPhotoComBase
{
	FairyGUI.GList _rightActionList; // 0x20
	FairyGUI.GLoader _rightActionListBg; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiRightActionList.ActionBtnData> _actionBtnDataList; // 0x30
	System.Void InitComponents(); // 0x0637f908
	System.Void ActionListItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x06380478
	System.Void InitActionListData(); // 0x0637fa88
	System.Void .ctor(); // 0x0637b994
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiRightActionList.ActionBtnData : System.ValueType
{
	System.String iconUrl; // 0x10
	System.String title; // 0x18
	System.Action onClick; // 0x20
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRightActionList.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiRightActionList.<>c <>9; // 0x0
	static System.Action <>9__8_0; // 0x8
	static System.Action <>9__8_1; // 0x10
	static System.Action <>9__8_2; // 0x18
	static System.Action <>9__8_3; // 0x20
	static System.Action <>9__8_4; // 0x28
	static System.Action <>9__8_5; // 0x30
	static System.Void .cctor(); // 0x063807c4
	System.Void .ctor(); // 0x06380828
	System.Void <InitActionListData>b__8_0(); // 0x06380890
	System.Void <InitActionListData>b__8_1(); // 0x0638092c
	System.Void <InitActionListData>b__8_2(); // 0x063809c8
	System.Void <InitActionListData>b__8_3(); // 0x06380a64
	System.Void <InitActionListData>b__8_4(); // 0x06380b00
	System.Void <InitActionListData>b__8_5(); // 0x06380b9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRightActionList.<>c__DisplayClass7_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiRightActionList <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Void .ctor(); // 0x0638075c
	System.Void <ActionListItemRenderer>b__0(); // 0x06380c38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPicBox : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	WizardGames.Soc.SocClient.Ui.UiPicBoxContent uiPicBoxContent; // 0x338
	static System.Collections.Generic.Queue<WizardGames.Soc.SocClient.Ui.PicBoxInfo> uiMsgQueue; // 0x0
	System.Void .ctor(); // 0x06380cf4
	static WizardGames.Soc.SocClient.Ui.UiPicBox ShowPicBox(WizardGames.Soc.SocClient.Ui.PicBoxInfo info); // 0x06380e80
	static System.Void ShowPicBoxById(System.Int32 TbPicBoxId); // 0x0638130c
	static WizardGames.Soc.SocClient.Ui.PicBoxInfo GetPicBoxInfo(System.Int32 TbPicBoxId); // 0x063813c0
	static System.Boolean Equals(WizardGames.Soc.SocClient.Ui.PicBoxInfo info1, WizardGames.Soc.SocClient.Ui.PicBoxInfo info2); // 0x06381250
	System.Void OnInit(); // 0x06381950
	System.Void OnDestroy(); // 0x063826d4
	System.Void OnDisable(); // 0x06382798
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06382c98
	System.Void SetInfo(WizardGames.Soc.SocClient.Ui.PicBoxInfo info); // 0x06382f10
	System.Void ClosePicBoxForGuide(); // 0x0638349c
	static System.Void CloseForGuide(); // 0x063835a4
	System.Void OnFps30Update(System.Single dt); // 0x0638368c
	static System.Void .cctor(); // 0x06383d84
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPicBox.<>c__DisplayClass3_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.PicBoxInfo info; // 0x10
	System.Void .ctor(); // 0x063811e8
	System.Void <ShowPicBox>b__0(WizardGames.Soc.SocClient.Ui.UiPicBox win); // 0x06383e1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPicBox.<>c__DisplayClass9_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.PicBoxInfo info; // 0x10
	System.Void .ctor(); // 0x063829e0
	System.Void <OnDisable>b__0(WizardGames.Soc.SocClient.Ui.UiPicBox win); // 0x06383ea0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PicBoxInfo : System.Object
{
	System.String titleStr; // 0x10
	System.String[] picUrlArray; // 0x18
	System.String[] videoNameArray; // 0x20
	System.String[] videoPathArray; // 0x28
	System.String[] textArray; // 0x30
	System.Int32 guideId; // 0x38
	System.Int32 guideStepId; // 0x3c
	System.Boolean triggerNextWhenClose; // 0x40
	System.Int64 timeEnd; // 0x48
	System.String timeStageChangeTitle; // 0x50
	System.String timeSettlementTitle; // 0x58
	System.Int32 countDownLeft; // 0x60
	System.Void .ctor(); // 0x063818bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPicBoxBtnList : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComBtnFaceSlapPhotoBinder binder; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.PicBoxBtnInfo> list; // 0x18
	System.Single time; // 0x20
	System.Void .ctor(FairyGUI.GComponent com); // 0x06383f24
	System.Void ItemRender(System.Int32 index, FairyGUI.GObject item); // 0x063840d8
	System.Void Init(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.PicBoxBtnInfo> list, System.Single time); // 0x06384560
	System.Void SetTime(System.String time); // 0x063847c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPicBoxBtnList.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiPicBoxBtnList.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.PicBoxBtnInfo> <>9__5_0; // 0x8
	static System.Void .cctor(); // 0x06384894
	System.Void .ctor(); // 0x063848f8
	System.Int32 <Init>b__5_0(WizardGames.Soc.SocClient.Ui.PicBoxBtnInfo a, WizardGames.Soc.SocClient.Ui.PicBoxBtnInfo b); // 0x06384960
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPicBoxBtnList.<>c__DisplayClass4_0 : System.Object
{
	FairyGUI.GButton btn; // 0x10
	WizardGames.Soc.SocClient.Ui.PicBoxBtnInfo data; // 0x18
	System.Void .ctor(); // 0x063844f8
	System.Void <ItemRender>b__0(FairyGUI.EventContext ctx); // 0x063849f4
	System.Void <ItemRender>b__1(FairyGUI.EventContext ctx); // 0x06384adc
	System.Void <ItemRender>b__2(); // 0x06384bc4
	System.Void <ItemRender>b__3(); // 0x06384c70
	System.Void <ItemRender>b__4(); // 0x06384d1c
	System.Void <ItemRender>b__5(); // 0x06384dc8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PicBoxBtnInfo : System.Object
{
	System.String title; // 0x10
	System.Action action; // 0x18
	System.Int32 sort; // 0x20
	System.Boolean enabled; // 0x24
	System.Boolean touchable; // 0x25
	System.Int32 disabledTip; // 0x28
	System.Void .ctor(); // 0x06384f24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPicBoxContent : System.Object
{
	WizardGames.Soc.Common.Unity.Ui.WindowComBase win; // 0x10
	FairyGUI.GComponent root; // 0x18
	WizardGames.Soc.SocClient.Ui.PicBoxInfo curInfo; // 0x20
	FairyGUI.GList picList; // 0x28
	FairyGUI.GTextField desText; // 0x30
	FairyGUI.GList pointList; // 0x38
	System.Int32 curPageIndex; // 0x40
	FairyGUI.Transition showAnim; // 0x48
	FairyGUI.Transition hideAnim; // 0x50
	WizardGames.Soc.SocClient.Ui.ComVideo videoPlayer; // 0x58
	System.Boolean isFirstTimeShow; // 0x60
	System.Int64 timeId; // 0x68
	FairyGUI.GGroup <Countdown>k__BackingField; // 0x70
	FairyGUI.GTextField <countdownStrong>k__BackingField; // 0x78
	FairyGUI.Controller <CtrlStatus>k__BackingField; // 0x80
	FairyGUI.Controller <CtrGray>k__BackingField; // 0x88
	FairyGUI.Controller <CtrButton>k__BackingField; // 0x90
	FairyGUI.Controller CtrlPlatform; // 0x98
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.PicBoxBtnInfo> dic; // 0xa0
	WizardGames.Soc.SocClient.Ui.UiPicBoxBtnList btnList; // 0xa8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.PicBoxBtnInfo> btnListInfo; // 0xb0
	System.Boolean canClickClose; // 0xb8
	System.Boolean isShowClose; // 0xb9
	System.Int32 countDownTime; // 0xbc
	System.Boolean hasReachedLastPage; // 0xc0
	System.Boolean countdownStarted; // 0xc1
	System.Boolean countdownFinished; // 0xc2
	FairyGUI.GGroup get_Countdown(); // 0x06384f94
	System.Void set_Countdown(FairyGUI.GGroup value); // 0x06384ff8
	FairyGUI.GTextField get_countdownStrong(); // 0x06385078
	System.Void set_countdownStrong(FairyGUI.GTextField value); // 0x063850dc
	FairyGUI.Controller get_CtrlStatus(); // 0x0638515c
	System.Void set_CtrlStatus(FairyGUI.Controller value); // 0x063851c0
	System.Void set_CtrGray(FairyGUI.Controller value); // 0x06385240
	FairyGUI.Controller get_CtrButton(); // 0x063852c0
	System.Void OnInit(WizardGames.Soc.Common.Unity.Ui.WindowComBase winCom, FairyGUI.GComponent rootCom); // 0x06381abc
	System.Void OnEscClose(); // 0x06382d24
	System.Void OnClickClose(); // 0x06385590
	System.Void OnRenderPicList(System.Int32 index, FairyGUI.GObject obj); // 0x06385810
	System.Void OnScrollEnd(FairyGUI.EventContext context); // 0x06385984
	System.Void OnScroll(FairyGUI.EventContext context); // 0x06386298
	System.Void TryPlayVideo(); // 0x06385b00
	System.Void OnClickLeftBtn(); // 0x06386510
	System.Void OnClickRightBtn(); // 0x06386618
	System.Void OnRenderPointList(System.Int32 index, FairyGUI.GObject obj); // 0x0638673c
	System.Void SetInfo(WizardGames.Soc.SocClient.Ui.PicBoxInfo info); // 0x06383098
	System.Void OnFps30Update(); // 0x0638370c
	System.Void RefreshUi(System.Int32 picNum, System.Int32 index); // 0x06385ed8
	System.Void StartTimer(System.Int32 countDownTime); // 0x055056e8
	System.Void OnClear(); // 0x06382a48
	System.Void SetActive(System.Boolean active); // 0x06382640
	System.Void PlayShowAnim(); // 0x06383358
	System.Void PlayHideAnim(System.Action callback); // 0x06385674
	System.Void CloseForGuide(); // 0x06383508
	System.Void OnCreatePlatform(); // 0x06385324
	System.Void SetCloseTitle(System.String str); // 0x06386824
	System.Void UpdatePageButtons(System.Boolean showLeftBtn, System.Boolean showRightBtn); // 0x06386d28
	System.Void OnClearPlatform(); // 0x06386edc
	System.Void SetCloseButtonStateForPlatform(System.Boolean isLastPage); // 0x06386c44
	System.Void OnCountdownFinishedPlatform(); // 0x06386f3c
	System.Void OnCountdownTickPlatform(); // 0x0638702c
	System.Void .ctor(); // 0x06380db4
	System.Void <OnClickClose>b__49_0(); // 0x063870f8
	System.Void <TryPlayVideo>b__53_0(UnityEngine.Video.VideoPlayer player); // 0x0638747c
	System.Void <TryPlayVideo>b__53_2(System.Object param); // 0x06387564
	System.Void <PlayShowAnim>b__64_0(); // 0x06387600
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPicBoxContent.<>c__DisplayClass49_0 : System.Object
{
	System.String uiName; // 0x10
	System.Void .ctor(); // 0x06387414
	System.Void <OnClickClose>b__1(System.Object obj); // 0x06387664
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPicBoxContent.<>c__DisplayClass53_0 : System.Object
{
	System.String name; // 0x10
	System.Void .ctor(); // 0x063864a8
	System.Void <TryPlayVideo>b__1(UnityEngine.Video.VideoPlayer player); // 0x0638771c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPicBoxContent.<>c__DisplayClass61_0 : System.Object
{
	System.Int32 countDownTime; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPicBoxContent <>4__this; // 0x18
	System.String closeBaseText; // 0x20
	System.Void .ctor(); // 0x06386e74
	System.Void <StartTimer>b__0(System.Int64 id, System.Object data, System.Boolean delete); // 0x06387838
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPicBoxContent.<>c__DisplayClass65_0 : System.Object
{
	System.Action callback; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPicBoxContent <>4__this; // 0x18
	System.Void .ctor(); // 0x06387b8c
	System.Void <PlayHideAnim>b__0(); // 0x06387bf4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHybridGame : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	WizardGames.Soc.SocClient.Ui.HybridAdjustData hybridAdjustData; // 0x338
	static SocLogger logger; // 0x0
	FairyGUI.GTextField timeTxt; // 0x340
	FairyGUI.GGroup gNeedleGroup; // 0x348
	FairyGUI.GLoader[] pollenTubeLoaders; // 0x350
	FairyGUI.GLoader waterLoader; // 0x358
	FairyGUI.GButton buttonClose; // 0x360
	FairyGUI.GLoader bgGLoader; // 0x368
	FairyGUI.GGroup groupPollenTube; // 0x370
	UnityEngine.Vector2 needleInitPos; // 0x378
	UnityEngine.Vector2 waterInitPos; // 0x380
	FairyGUI.GList listMaterialPlants; // 0x388
	System.Single time; // 0x390
	System.Int32 gameId; // 0x394
	WizardGames.Soc.Share.Framework.BasicTypeList<System.Int32> oldGenes; // 0x398
	FairyGUI.Transition moveYoyoTrans; // 0x3a0
	FairyGUI.Transition moveDownTrans; // 0x3a8
	WizardGames.Soc.SocClient.Plant.PlantBoxData curPlantBox; // 0x3b0
	System.Boolean resultUIOpening; // 0x3b8
	System.Boolean isTimeOver; // 0x3b9
	System.Boolean isPlanting; // 0x3ba
	System.Int32 MaxLength; // 0x3bc
	System.Single[,] badRangeX; // 0x3c0
	System.Single[,] goodRangeX; // 0x3c8
	System.Single[,] niceRangeX; // 0x3d0
	System.Single[] perfectRangeX; // 0x3d8
	WizardGames.Soc.SocClient.Ui.UiHybridGame.GameResultTipIds tipsId; // 0x3e0
	System.Void OnInit(); // 0x06387c80
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0638831c
	System.Void OnEnable(); // 0x0638844c
	System.Void OnRenderMaterialList(System.Int32 index, FairyGUI.GObject obj); // 0x063884b4
	System.Collections.IEnumerator DelayFinishFunc(System.Int64 index); // 0x063887f0
	System.Void OnGameFinish(System.Int64 index); // 0x06388930
	System.Void OnFps1Update(System.Single dt); // 0x06388b30
	System.Void OnDisable(); // 0x06388d14
	System.Void OnDestroy(); // 0x06388d7c
	static System.Void CloseWindow(); // 0x063883b4
	static WizardGames.Soc.SocClient.Ui.UiHybridGame GetWindow(); // 0x06388e94
	System.Void OnClickStart(); // 0x06388f54
	System.Void RefreshByStop(); // 0x06389050
	WizardGames.Soc.SocClient.Ui.UiHybridGame.GameResultTipIds GetGameResultTipIds(WizardGames.Soc.SocClient.Ui.UiHybridGame.GameResult result); // 0x06389364
	WizardGames.Soc.SocClient.Ui.UiHybridGame.GameResult GetGameResult(); // 0x06389154
	System.Void .ctor(); // 0x063893ec
	static System.Void .cctor(); // 0x06389494
	System.Void <OnInit>b__17_0(); // 0x06389568
	System.Void <OnClickStart>b__36_0(); // 0x063895cc
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiHybridGame.GameResultTipIds : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiHybridGame.GameResultTipIds None = 1045;
	static WizardGames.Soc.SocClient.Ui.UiHybridGame.GameResultTipIds Perfect = 1042;
	static WizardGames.Soc.SocClient.Ui.UiHybridGame.GameResultTipIds Nice = 1043;
	static WizardGames.Soc.SocClient.Ui.UiHybridGame.GameResultTipIds Good = 1044;
	static WizardGames.Soc.SocClient.Ui.UiHybridGame.GameResultTipIds Bad = 1045;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiHybridGame.GameResult : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiHybridGame.GameResult None = 0;
	static WizardGames.Soc.SocClient.Ui.UiHybridGame.GameResult Perfect = 1;
	static WizardGames.Soc.SocClient.Ui.UiHybridGame.GameResult Nice = 2;
	static WizardGames.Soc.SocClient.Ui.UiHybridGame.GameResult Good = 3;
	static WizardGames.Soc.SocClient.Ui.UiHybridGame.GameResult Bad = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHybridGame.<>c__DisplayClass25_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHybridGame <>4__this; // 0x10
	WizardGames.Soc.Share.Framework.BasicTypeList<System.Int32> newGenes; // 0x18
	System.Int64 index; // 0x20
	Assets.Scripts.Plant.PlantBoxItemData plantBoxItemData; // 0x28
	System.Void .ctor(); // 0x06389630
	System.Void <DelayFinishFunc>b__0(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x06389698
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHybridGame.<DelayFinishFunc>d__25 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Ui.UiHybridGame <>4__this; // 0x20
	System.Int64 index; // 0x28
	WizardGames.Soc.SocClient.Ui.UiHybridGame.<>c__DisplayClass25_0 <>8__1; // 0x30
	System.Void .ctor(System.Int32 <>1__state); // 0x063888ac
	System.Void System.IDisposable.Dispose(); // 0x06389938
	System.Boolean MoveNext(); // 0x06389998
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x06389c1c
	System.Void System.Collections.IEnumerator.Reset(); // 0x06389c80
	System.Object System.Collections.IEnumerator.get_Current(); // 0x06389d08
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHybridGameResult : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Share.Framework.BasicTypeList<System.Int32> oldGenes; // 0x338
	WizardGames.Soc.Share.Framework.BasicTypeList<System.Int32> newGenes; // 0x340
	WizardGames.Soc.Share.Framework.BasicTypeList<System.Int32> slotPoints; // 0x348
	System.Int64 index; // 0x350
	Assets.Scripts.Plant.PlantBoxItemData PlantBoxItemData; // 0x358
	FairyGUI.GLoader icon; // 0x360
	FairyGUI.GButton buttonNext; // 0x368
	FairyGUI.GButton buttonClose; // 0x370
	FairyGUI.GTextField title; // 0x378
	FairyGUI.GTextField geneResult; // 0x380
	FairyGUI.GTextField plantAttributes; // 0x388
	FairyGUI.GTextField[] geneNameList; // 0x390
	FairyGUI.GGraph graph; // 0x398
	System.Collections.Generic.List<UnityEngine.Vector2> vector2s; // 0x3a0
	UnityEngine.Vector2 circlePos; // 0x3a8
	System.Collections.Generic.List<FairyGUI.GComponent> targetGeneList; // 0x3b0
	System.Collections.Generic.List<FairyGUI.GComponent> bestGeneList; // 0x3b8
	System.Collections.Generic.List<FairyGUI.GGraph> lineList; // 0x3c0
	System.Collections.Generic.List<UnityEngine.Vector2> bestItemPositionList; // 0x3c8
	System.Void OnInit(); // 0x06389d6c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0638a5e0
	System.Void RefreshGene(); // 0x0638a710
	System.Void RefreshInfo(); // 0x0638ac74
	System.Collections.Generic.List<System.Int32> GetPointsValue(); // 0x0638ae30
	System.Void ReBuildGraph(); // 0x0638b1f4
	System.Void InitGameResult(WizardGames.Soc.Share.Framework.BasicTypeList<System.Int32> oldGenes, WizardGames.Soc.Share.Framework.BasicTypeList<System.Int32> newGenes, WizardGames.Soc.Share.Framework.BasicTypeList<System.Int32> slotPoints, System.Int64 index, Assets.Scripts.Plant.PlantBoxItemData plantBoxItemData); // 0x063897a4
	static System.Void CloseWindow(); // 0x0638a678
	static WizardGames.Soc.SocClient.Ui.UiHybridGameResult GetWindow(); // 0x0638b6e8
	System.Collections.Generic.List<UnityEngine.Vector2> CalculateSegmentCoordinates(UnityEngine.Vector2 startPoint, UnityEngine.Vector2 endPoint, System.Int32 segmentCount); // 0x0638b550
	System.Void .ctor(); // 0x0638b7a8
	static System.Void .cctor(); // 0x0638b960
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHybridGameResult.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiHybridGameResult.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__20_0; // 0x8
	static System.Void .cctor(); // 0x0638ba34
	System.Void .ctor(); // 0x0638ba98
	System.Void <OnInit>b__20_0(); // 0x0638bb00
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHybridMain : System.Object
{
	FairyGUI.GComponent rootNode; // 0x10
	System.Collections.Generic.List<Assets.Scripts.Plant.PlantBoxItemData> CurSelectPlants; // 0x18
	WizardGames.Soc.SocClient.Ui.UiPlantMain UiPlantMain; // 0x20
	WizardGames.Soc.SocClient.Ui.UiHybridSelectPlant uiHybridSelectPlant; // 0x28
	WizardGames.Soc.SocClient.Plant.HybridData HybridData; // 0x30
	System.Void RefreshHybridData(); // 0x0638bb84
	System.Void Hide(); // 0x063898a8
	System.Void OnRenderGeneList(FairyGUI.GList list, System.Int32 index); // 0x0638bcb0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.HybridAdjustData : System.Object
{
	System.Collections.Generic.List<Assets.Scripts.Plant.PlantBoxItemData> CurSelectPlants; // 0x10
	System.Int32 MagicNum; // 0x18
	WizardGames.Soc.Share.Framework.BasicTypeList<System.Int32> SlotToPlantIndexs; // 0x20
	WizardGames.Soc.Share.Framework.BasicTypeList<System.Int32> SlotPoints; // 0x28
	WizardGames.Soc.SocClient.Ui.UiHybridMain uiHybridMain; // 0x30
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.SelectStep : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.SelectStep Target = 0;
	static WizardGames.Soc.SocClient.Ui.SelectStep Material = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHybridSelectPlant : System.Object
{
	static SocLogger logger; // 0x0
	FairyGUI.GButton btnNextStep; // 0x10
	FairyGUI.GTextField textPlantNum; // 0x18
	FairyGUI.GList listMaterialPlants; // 0x20
	FairyGUI.Controller selectControl; // 0x28
	WizardGames.Soc.SocClient.Ui.ComShowItemModel comShowItemModel; // 0x30
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,FairyGUI.GObject>> listItemGoDic; // 0x38
	WizardGames.Soc.SocClient.Ui.UiHybridMain uiHybridMain; // 0x40
	WizardGames.Soc.SocClient.Ui.UiPlantBox2D uiPlantBox2D; // 0x48
	WizardGames.Soc.SocClient.Ui.SelectStep get_CurSelectStep(); // 0x0638bf18
	System.Collections.Generic.List<Assets.Scripts.Plant.PlantBoxItemData> get_CurSelectPlants(); // 0x0638bfc0
	WizardGames.Soc.SocClient.Plant.PlantBoxData get_CurPlantBox(); // 0x0638c070
	System.Void Hide(); // 0x0638bbf8
	System.Void RefreshNextStepBtn(); // 0x0638c2e8
	System.Void OnRenderMaterialList(System.Int32 index, FairyGUI.GObject obj); // 0x0638c44c
	System.Void RefreshPlantList(); // 0x0638cd78
	System.Void RemovePlant(System.Int32 index); // 0x0638c1d0
	System.Void RefreshSelectedPlant(); // 0x0638cf54
	static System.Void .cctor(); // 0x0638d324
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHybridSelectPlant.<>c__DisplayClass30_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHybridSelectPlant <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Void .ctor(); // 0x0638cd10
	System.Void <OnRenderMaterialList>b__0(); // 0x0638d3f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHybridExplainTabPanel : WizardGames.Soc.SocClient.Ui.UiTabBasePanel
{
	FairyGUI.GLoader m_naturalHandler; // 0x20
	FairyGUI.GLoader m_artificialHandler; // 0x28
	FairyGUI.GComponent gRoot; // 0x30
	WizardGames.Soc.SocClient.Ui.ETabType get_TabType(); // 0x0638d468
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.UiPlantMain uiPlantMain); // 0x0638d4cc
	System.Void OnNatrualClicked(); // 0x0638d82c
	System.Void OnArtificialClicked(); // 0x0638d984
	System.Void .ctor(); // 0x0638da94
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHybridExplainTabPanel.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiHybridExplainTabPanel.<>c <>9; // 0x0
	static System.Action <>9__6_1; // 0x8
	static System.Action <>9__6_0; // 0x10
	static System.Void .cctor(); // 0x0638dafc
	System.Void .ctor(); // 0x0638db60
	System.Void <OnNatrualClicked>b__6_0(); // 0x0638dbc8
	System.Void <OnNatrualClicked>b__6_1(); // 0x0638dd20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PlantEffectEmitter : System.Object
{
	UnityEngine.GameObject m_plantBoxFx; // 0x10
	UnityEngine.GameObject m_splashFx; // 0x18
	System.String plantEffectKey; // 0x20
	System.String splashEffectKey; // 0x28
	System.UInt64 waterPlantEffectAsyncId; // 0x30
	System.UInt64 waterSplashEffectAsyncId; // 0x38
	System.UInt64 fertilizePlantEffectAsyncId; // 0x40
	System.UInt64 fertilizeSplashEffectAsyncId; // 0x48
	UnityEngine.Transform get_TrEffectParent(); // 0x0638de18
	System.Void OnDisable(); // 0x0638df48
	System.Void PlayWaterEffect(); // 0x0638e3e8
	System.Void PlayFertilizeEffect(); // 0x0638e76c
	System.Void ReleaseGo(); // 0x0638dfac
	System.Void .ctor(); // 0x0638eaf0
	System.Void <PlayWaterEffect>b__11_0(UnityEngine.GameObject go, System.Object[] objs); // 0x0638eb58
	System.Void <PlayWaterEffect>b__11_1(UnityEngine.GameObject go, System.Object[] objs); // 0x0638ed84
	System.Void <PlayFertilizeEffect>b__12_0(UnityEngine.GameObject go, System.Object[] objs); // 0x0638efb0
	System.Void <PlayFertilizeEffect>b__12_1(UnityEngine.GameObject go, System.Object[] objs); // 0x0638f1dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIPlantScreenEffect : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static System.String UI_NAME; // 0x0
	FairyGUI.GGraph effectHolder; // 0x338
	FairyGUI.GoWrapper goWwrapper; // 0x340
	UnityEngine.GameObject screenWatering; // 0x348
	UnityEngine.GameObject screenFertilize; // 0x350
	System.UInt64 asyncIdWater; // 0x358
	System.UInt64 asyncIdFertilize; // 0x360
	System.Void OnInit(); // 0x0638f408
	System.Void CloseWindow(); // 0x0638f54c
	System.Void PlayFx(WizardGames.Soc.SocClient.Ui.UIPlantScreenEffect.EPlayPlantScreenEffectType plantScreenEffectType); // 0x0638f8c0
	System.Void DestroyFx(WizardGames.Soc.SocClient.Ui.UIPlantScreenEffect.EPlayPlantScreenEffectType plantScreenEffectType); // 0x0638f5d0
	System.Void .ctor(); // 0x0638fa40
	static System.Void .cctor(); // 0x0638facc
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UIPlantScreenEffect.EPlayPlantScreenEffectType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UIPlantScreenEffect.EPlayPlantScreenEffectType Water = 0;
	static WizardGames.Soc.SocClient.Ui.UIPlantScreenEffect.EPlayPlantScreenEffectType Fertilize = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIPlantScreenEffect.<>c__DisplayClass10_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UIPlantScreenEffect <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.UIPlantScreenEffect.EPlayPlantScreenEffectType plantScreenEffectType; // 0x18
	System.Action<UnityEngine.GameObject,System.Object[]> <>9__1; // 0x20
	System.Action<UnityEngine.GameObject,System.Object[]> <>9__2; // 0x28
	System.Void .ctor(); // 0x0638f9d8
	System.Void <PlayFx>b__0(System.Object obj); // 0x0638fb34
	System.Void <PlayFx>b__1(UnityEngine.GameObject go, System.Object[] objs); // 0x0638fef8
	System.Void <PlayFx>b__2(UnityEngine.GameObject go, System.Object[] objs); // 0x06390140
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlantBasePage : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiPlantOperationSubPanel uiPlantOperationSubPanel; // 0x10
	WizardGames.Soc.SocClient.Ui.EPageType <PageType>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.EPageType get_PageType(); // 0x06390388
	System.Void Init(FairyGUI.GComponent com, WizardGames.Soc.SocClient.Ui.UiPlantOperationSubPanel uiPlantOperationSubPanel); // 0x063903ec
	System.Void OnInit(FairyGUI.GComponent com, WizardGames.Soc.SocClient.Ui.UiPlantOperationSubPanel uiPlantOperationSubPanel); // 0x06390464
	System.Void Enable(System.Object data); // 0x063904ec
	System.Void OnEnable(System.Object plantBox); // 0x0639055c
	System.Void Disable(); // 0x063905d0
	System.Void OnDisable(); // 0x06390630
	System.Void Refresh(); // 0x06390690
	System.Void OnRefresh(); // 0x063906f0
	System.Void Dispose(); // 0x06390750
	System.Void OnDispose(); // 0x063907b0
	System.Void .ctor(); // 0x06390810
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlantDefaultPage : WizardGames.Soc.SocClient.Ui.UiPlantBasePage
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.ComStateBtn waterBtn; // 0x20
	WizardGames.Soc.SocClient.Ui.ComStateBtn harvestBtn; // 0x28
	WizardGames.Soc.SocClient.Ui.ComStateBtn manureBtn; // 0x30
	WizardGames.Soc.SocClient.Ui.ComStateBtn seedBtn; // 0x38
	WizardGames.Soc.SocClient.Ui.UiPlantBox2D uiPlantBox2D; // 0x40
	WizardGames.Soc.SocClient.Plant.PlantBoxData curPlantBox; // 0x48
	WizardGames.Soc.SocClient.Ui.EPageType get_PageType(); // 0x06390878
	static WizardGames.Soc.SocClient.Ui.UiPlantBasePage Create(FairyGUI.GComponent com, WizardGames.Soc.SocClient.Ui.UiPlantOperationSubPanel uiPlantOperationSubPanel); // 0x063908dc
	System.Void OnInit(FairyGUI.GComponent com, WizardGames.Soc.SocClient.Ui.UiPlantOperationSubPanel uiPlantOperationSubPanel); // 0x063909f4
	System.Void OnEnable(System.Object data); // 0x06391048
	System.Void OnDispose(); // 0x06391110
	System.Void OnRefresh(); // 0x063913f0
	System.Void OnClickSeed(); // 0x06391948
	System.Void OnClickManure(); // 0x06391aa4
	System.Void OnClickWater(); // 0x06391c00
	System.Void OnClickHarvest(); // 0x06391d58
	System.Void .ctor(); // 0x06390990
	static System.Void .cctor(); // 0x06391e9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlantDetailPage : WizardGames.Soc.SocClient.Ui.UiPlantBasePage
{
	static SocLogger logger; // 0x0
	FairyGUI.GButton closeBtn; // 0x20
	WizardGames.Soc.SocClient.Ui.ComItemIcon itemIconCom; // 0x28
	FairyGUI.GTextField plantNameTxt; // 0x30
	FairyGUI.GTextField plantProgressTxt; // 0x38
	FairyGUI.GTextField plantDescTxt; // 0x40
	FairyGUI.GTextField plantStageText; // 0x48
	FairyGUI.GButton removeBtn; // 0x50
	FairyGUI.GButton manualBtn; // 0x58
	FairyGUI.Controller manualBtnCtrl; // 0x60
	FairyGUI.GButton harvestBtn; // 0x68
	FairyGUI.Controller harvestBtnCtrl; // 0x70
	FairyGUI.GButton detailBtn; // 0x78
	FairyGUI.GTextField waterIntakeTxt; // 0x80
	FairyGUI.GTextField harvestTxt; // 0x88
	FairyGUI.GProgressBar manualProgressBar; // 0x90
	FairyGUI.GProgressBar waterProgressBar; // 0x98
	FairyGUI.GProgressBar lightProgressBar; // 0xa0
	FairyGUI.GProgressBar tempuratureProgressBar; // 0xa8
	FairyGUI.GProgressBar overallProgressBar; // 0xb0
	FairyGUI.GList geneLst; // 0xb8
	FairyGUI.Controller removeBtnCtrl; // 0xc0
	WizardGames.Soc.SocClient.Plant.PlantBoxData curPlantBox; // 0xc8
	Assets.Scripts.Plant.PlantBoxItemData curPlantBoxItemData; // 0xd0
	System.Int32 slotIndex; // 0xd8
	FairyGUI.GObject waterBuff; // 0xe0
	FairyGUI.GObject manualBuff; // 0xe8
	WizardGames.Soc.SocClient.Ui.EPageType get_PageType(); // 0x06391f70
	static WizardGames.Soc.SocClient.Ui.UiPlantBasePage Create(FairyGUI.GComponent com, WizardGames.Soc.SocClient.Ui.UiPlantOperationSubPanel uiPlantOperationSubPanel); // 0x06391fd4
	System.Void OnInit(FairyGUI.GComponent com, WizardGames.Soc.SocClient.Ui.UiPlantOperationSubPanel uiPlantOperationSubPanel); // 0x063920ec
	System.Void OnEnable(System.Object plantBox); // 0x06392a24
	System.Void OnDisable(); // 0x06392d48
	System.Void OnDetailPageSelectedSlot(System.Int32 slot); // 0x06392fe0
	System.Void RefreshPlant(System.Int32 slot); // 0x0639305c
	System.Void OnClickClose(); // 0x063943e4
	System.Void OnClickDetail(); // 0x06394458
	System.Void OnClickRemove(); // 0x06394578
	System.Void OnClickManual(); // 0x06394980
	System.Void OnClickHarvest(); // 0x06394b0c
	System.Void OnHarvestSuccess(System.Int64 collectionId, System.Int32 idx); // 0x06394bdc
	System.Void OnRemovePlantSuccess(System.Int64 collectionId, System.Int32 slot); // 0x06394c88
	System.Void OnUpdatePlantsInfo(System.Int64 collectionId); // 0x06394d94
	System.Int32 GetRealHarvest(WizardGames.Soc.Common.Data.Plant.PlantSeedConfig cfg, WizardGames.Soc.Share.Framework.BasicTypeList<System.Int32> geneLst); // 0x06394074
	System.Int32 GetRealWaterIntake(WizardGames.Soc.Common.Data.Plant.PlantSeedConfig cfg, WizardGames.Soc.Share.Framework.BasicTypeList<System.Int32> geneLst); // 0x06393d70
	System.Void .ctor(); // 0x06392088
	static System.Void .cctor(); // 0x06394e40
	System.Void <OnClickRemove>b__37_0(); // 0x06394f14
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlantManurePage : WizardGames.Soc.SocClient.Ui.UiPlantBasePage
{
	static SocLogger logger; // 0x0
	FairyGUI.GButton closeBtn; // 0x20
	FairyGUI.GButton manureBtn; // 0x28
	FairyGUI.GTextField manureBtnNum; // 0x30
	FairyGUI.Controller manureBtnCtrl; // 0x38
	WizardGames.Soc.SocClient.Ui.UiPlantBox2D uiPlantBox2D; // 0x40
	WizardGames.Soc.SocClient.Plant.PlantBoxData curPlantBox; // 0x48
	System.Boolean hasSetSelected; // 0x50
	System.Int32 totalManure; // 0x54
	WizardGames.Soc.SocClient.Ui.EPageType get_PageType(); // 0x06394ffc
	static WizardGames.Soc.SocClient.Ui.UiPlantBasePage Create(FairyGUI.GComponent com, WizardGames.Soc.SocClient.Ui.UiPlantOperationSubPanel uiPlantOperationSubPanel); // 0x06395060
	System.Void OnInit(FairyGUI.GComponent com, WizardGames.Soc.SocClient.Ui.UiPlantOperationSubPanel uiPlantOperationSubPanel); // 0x06395178
	System.Void OnEnable(System.Object data); // 0x063954a4
	System.Void OnRefresh(); // 0x0639572c
	System.Void OnDisable(); // 0x06395978
	System.Void OnDispose(); // 0x06395b84
	System.Void RefreshPlants(); // 0x063957a4
	System.Void OnClickClose(); // 0x06395c00
	System.Void OnClickManure(); // 0x06395d44
	System.Void OnManureSuccess(System.Int64 collectionId); // 0x063960b0
	System.Void OnPlantBoxModelSelectedSlot(System.Int32 a, System.Int32 b); // 0x06396150
	System.Void OnManurePageSelectedSlot(System.Int32 index); // 0x06395828
	System.Void .ctor(); // 0x06395114
	static System.Void .cctor(); // 0x063961d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlantSeedPage : WizardGames.Soc.SocClient.Ui.UiPlantBasePage
{
	static SocLogger logger; // 0x0
	FairyGUI.GButton closeBtn; // 0x20
	FairyGUI.GButton seedBtn; // 0x28
	WizardGames.Soc.SocClient.Ui.UiPlantBox2D uiPlantBox2D; // 0x30
	FairyGUI.GList seedLst; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Plant.PlantSeedData> seedDataLst; // 0x40
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,FairyGUI.GObject>> seedGODic; // 0x48
	WizardGames.Soc.SocClient.Plant.PlantBoxData curPlantBox; // 0x50
	System.Boolean hasSetSelected; // 0x58
	FairyGUI.Controller m_seedBtnCtrl; // 0x60
	System.Int32 lastSelectedIndex; // 0x68
	WizardGames.Soc.SocClient.Ui.EPageType get_PageType(); // 0x063962a8
	static WizardGames.Soc.SocClient.Ui.UiPlantBasePage Create(FairyGUI.GComponent com, WizardGames.Soc.SocClient.Ui.UiPlantOperationSubPanel uiPlantOperationSubPanel); // 0x0639630c
	System.Void OnInit(FairyGUI.GComponent com, WizardGames.Soc.SocClient.Ui.UiPlantOperationSubPanel uiPlantOperationSubPanel); // 0x06396470
	System.Void OnEnable(System.Object data); // 0x06396820
	System.Void OnRefresh(); // 0x06396c80
	System.Void OnDisable(); // 0x06396d68
	System.Void OnDispose(); // 0x06397014
	System.Void SelectSeed(System.Int64 instanceId); // 0x06397090
	System.Void SetLastSelectedIndex(System.Int32 curIndex); // 0x0639723c
	System.Int32 GetPrevSelectedIndex(); // 0x063972f4
	System.Void RefreshPlants(); // 0x06396ce4
	System.Void RefreshSeeds(); // 0x06396b34
	System.Void OnRenderSeedItem(System.Int32 index, FairyGUI.GObject obj); // 0x06397364
	System.Void OnCancelPrePlant(System.Int32 slot, System.Int64 seedId); // 0x063980ec
	System.Void OnPrePlant(System.Int32 index, System.Int64 seedId, System.Int64 instanceId); // 0x0639854c
	System.Void RefreshCount(System.Collections.Generic.Dictionary<System.String,FairyGUI.GObject> comDict, WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x063983d4
	System.Void OnClickClose(); // 0x063989ac
	System.Void OnClickSeedBtn(); // 0x06398afc
	System.Void OnClickSeedLstItemIcon(); // 0x06398e9c
	System.Void OnPlantSuccess(System.Int64 collectionId); // 0x063992e4
	System.Void OnPlantPageSelectedSlot(System.Int32 slot); // 0x06399384
	System.Void .ctor(); // 0x063963c0
	static System.Void .cctor(); // 0x06399bbc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlantSeedPage.<>c__DisplayClass24_0 : System.Object
{
	WizardGames.Soc.SocClient.Plant.PlantSeedData info; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPlantSeedPage <>4__this; // 0x18
	System.Void .ctor(); // 0x06398084
	System.Boolean <OnRenderSeedItem>b__0(WizardGames.Soc.SocClient.Ui.ItemDragInfo item); // 0x06399c90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PlantBoxCtrl : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	UnityEngine.Transform[] slots; // 0x30
	UnityEngine.Transform[] hightlights; // 0x38
	WizardGames.Soc.SocClient.Plant.PlantBoxData curPlantBox; // 0x40
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.PlantCtrl> curPlantDic; // 0x48
	System.String layer; // 0x50
	System.Collections.Generic.Dictionary<System.Int32,System.Int64> prePlantDic; // 0x58
	System.Collections.Generic.List<Effect.EffectItemHandle<Effect.EffectItem>> effectItemHandleList; // 0x60
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.PlantBoxCtrl.FxData> fxDataList; // 0x68
	static System.Int32 FX_ID = 9650;
	static System.Int32 FX_ID_PUMPKIN = 9651;
	static System.Int64 pumpkinItemId = 23070004;
	System.Int64 timerHandler; // 0x70
	System.Boolean get_IsInUIMode(); // 0x06399f00
	System.Void OnEnable(); // 0x06399f80
	System.Void OnDisable(); // 0x0639a108
	System.Void OnDestroy(); // 0x0639a690
	System.Void ClearPlants(); // 0x0639a6fc
	System.Void SetLayer(System.String layer); // 0x0639aa94
	System.Void RefreshPlants(WizardGames.Soc.SocClient.Plant.PlantBoxData plantBox); // 0x0639ab14
	System.Void ToggleHighLight(System.Int32 index); // 0x0639b7b0
	System.Void RefreshHighLight(System.Int32 selectedIndex); // 0x0639b8b8
	System.Void RefreshHighLight(System.Collections.Generic.List<System.Int32> allIndexes); // 0x0639ba30
	System.Void OnUpdatePlantsInfo(System.Int64 collectionId); // 0x0639bc2c
	System.Void PrePlant(System.Int32 slot, System.Int64 seedId); // 0x0639bd9c
	System.Void CancelPrePlant(System.Int32 slot, System.Int64 seedId); // 0x0639bec0
	System.Void UnHighLightAllSlots(); // 0x0639a478
	System.Void ClearAllPrePlantContext(); // 0x0639c068
	System.Void HighLightOneSlot(System.Int32 slotIndex); // 0x0639b93c
	System.Void UnHighLightOneSlot(System.Int32 slotIndex); // 0x0639bfa0
	System.Void EnableOutline(System.Int32 slot); // 0x0639c240
	System.Void DisableAllOutline(); // 0x0639a564
	System.Void HighLightMultiple(System.Collections.Generic.List<System.Int32> indexes); // 0x0639bab4
	System.Void Start(); // 0x0639c474
	System.Void OnHarvestSuccess(System.Int64 collectionId, System.Int32 idx); // 0x0639c798
	System.Void PlayFx(System.Int32 idx, System.Int64 entityId, UnityEngine.Transform trParent); // 0x0639cd64
	System.Void OnDestroyFx(); // 0x0639a918
	System.Void ClearFx(); // 0x0639c9e4
	System.Void ClearEffectItemHandle(); // 0x0639cc24
	System.Void .ctor(); // 0x0639d4e0
	static System.Void .cctor(); // 0x0639d6c8
	System.Void <OnHarvestSuccess>b__36_0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x0639d79c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PlantBoxCtrl.FxData : System.Object
{
	System.UInt64 effectAsyncId; // 0x10
	UnityEngine.GameObject goFx; // 0x18
	System.String fxPath; // 0x20
	System.Int32 defaultLayer; // 0x28
	UnityEngine.Renderer[] rendererlist; // 0x30
	System.Void SetLayerToUI(); // 0x0639d834
	System.Void RsetLayer(); // 0x0639d3cc
	System.Void .ctor(); // 0x0639c730
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PlantBoxCtrl.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.PlantBoxCtrl.<>c <>9; // 0x0
	static System.Action<System.Boolean,Effect.EffectItem,System.Object> <>9__37_1; // 0x8
	static System.Void .cctor(); // 0x0639d9e0
	System.Void .ctor(); // 0x0639da44
	System.Void <PlayFx>b__37_1(System.Boolean success, Effect.EffectItem effectItem, System.Object o); // 0x0639daac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PlantBoxCtrl.<>c__DisplayClass37_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.PlantBoxCtrl <>4__this; // 0x10
	System.Int32 idx; // 0x18
	UnityEngine.Transform trParent; // 0x20
	System.Void .ctor(); // 0x0639d364
	System.Void <PlayFx>b__0(UnityEngine.GameObject go, System.Object[] objs); // 0x0639db6c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PlantCtrl : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	System.Int64 seedId; // 0x10
	WizardGames.Soc.Common.Data.PlantStage stage; // 0x18
	System.Boolean isManured; // 0x1c
	System.Boolean isWatered; // 0x1d
	UnityEngine.Transform root; // 0x20
	UnityEngine.GameObject plantObj; // 0x28
	System.UInt64 asyncId; // 0x30
	System.Int64 get_SeedId(); // 0x0639de7c
	WizardGames.Soc.Common.Data.PlantStage get_Stage(); // 0x0639dee0
	WizardGames.Soc.Common.Data.tips.OutlineConfig get_outlineConfig(); // 0x0639df44
	System.Void RefreshModel(Assets.Scripts.Plant.PlantBoxItemData plantBoxItemData, UnityEngine.Transform parent, System.String layer, System.Boolean watered); // 0x0639b07c
	System.Void RefreshModelPrePlant(System.Int64 seedId, WizardGames.Soc.Common.Data.PlantStage stage, UnityEngine.Transform parent, System.String layer); // 0x0639b548
	System.Void RefreshLayer(System.String layer); // 0x0639e2d0
	System.Void SetLayer(System.String layerName); // 0x0639e3e4
	System.Void EnableOutline(); // 0x0639c2f8
	System.Void DisableOutline(); // 0x0639c3e0
	System.Void ReleaseGO(); // 0x0639e098
	System.Void OnGet(); // 0x0639e5dc
	System.Void OnRelease(); // 0x0639e63c
	System.Void OnDestroy(); // 0x0639e6bc
	System.Void .ctor(); // 0x0639e73c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PlantCtrl.<>c__DisplayClass13_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.PlantCtrl <>4__this; // 0x10
	System.String layer; // 0x18
	WizardGames.Soc.Common.Data.PlantModelCfg modelCfg; // 0x20
	System.Void .ctor(); // 0x0639e030
	System.Void <RefreshModel>b__0(UnityEngine.GameObject go, System.Object[] objs); // 0x0639e7a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PlantCtrl.<>c__DisplayClass14_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.PlantCtrl <>4__this; // 0x10
	System.String layer; // 0x18
	WizardGames.Soc.Common.Data.PlantModelCfg modelCfg; // 0x20
	System.Void .ctor(); // 0x0639e37c
	System.Void <RefreshModelPrePlant>b__0(UnityEngine.GameObject go, System.Object[] objs); // 0x0639eb08
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PlantModelPreview : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiPlantOperationSubPanel uiPlantOperationSubPanel; // 0x10
	WizardGames.Soc.SocClient.Ui.PlantBoxCtrl plantBoxCtrl; // 0x18
	UnityEngine.Vector2 touchStartPos; // 0x20
	UnityEngine.Vector3 modelFixedRot; // 0x28
	UnityEngine.Vector3 modelOriRot; // 0x34
	FairyGUI.GLoader loader3D; // 0x40
	System.Single rotateSpeed; // 0x48
	UnityEngine.GameObject goSeedModel; // 0x50
	UnityEngine.RaycastHit[] hitBuffer; // 0x58
	WizardGames.Soc.SocClient.Manager.PreviewScene get_plantPreviewScene(); // 0x0639ee40
	static WizardGames.Soc.SocClient.Ui.PlantModelPreview Create(FairyGUI.GLoader loader3D, WizardGames.Soc.SocClient.Ui.UiPlantOperationSubPanel uiPlantOperationSubPanel); // 0x0639eee0
	System.Void OnInit(FairyGUI.GLoader loader3D, WizardGames.Soc.SocClient.Ui.UiPlantOperationSubPanel uiPlantOperationSubPanel); // 0x0639f07c
	System.Void Show(); // 0x0639f114
	System.Void Hide(); // 0x0639f458
	System.Void RegisterEvent(); // 0x0639f70c
	System.Void UnRegisterEvent(); // 0x0639f9ec
	System.Void OnFps10Update(); // 0x0639fccc
	System.Void OnChangePage(WizardGames.Soc.SocClient.Ui.EPageType pageType); // 0x063a02c8
	System.Void RefreshPlants(WizardGames.Soc.SocClient.Plant.PlantBoxData curPlantBox); // 0x063a0544
	System.Void OnItemTouchBegin(FairyGUI.EventContext context); // 0x063a05c8
	System.Void OnItemTouchMove(FairyGUI.EventContext context); // 0x063a07a4
	System.Void OnClickPlantBoxModel(FairyGUI.EventContext context); // 0x063a0b58
	System.Void OnItemDrop(FairyGUI.EventContext context); // 0x063a12e4
	System.Void RayCastPlant(UnityEngine.Vector2 touchPos, UnityEngine.RaycastHit& hit); // 0x0639fff0
	System.Void UpdateHighLight(System.Int32 index); // 0x063a16c8
	System.Void OnPrePlant(System.Int32 slot, System.Int64 seedId, System.Int64 instanceId); // 0x063a175c
	System.Void OnCancelPrePlant(System.Int32 slot, System.Int64 seedId); // 0x063a1850
	System.Void OnPlantPageSelectedSlot(System.Int32 selectedIndex); // 0x063a1260
	System.Void OnSelectMultipleSlotWhenOpenManurePage(System.Collections.Generic.List<System.Int32> selectedIndex); // 0x063a192c
	System.Void OnManurePageSelectedSlot(System.Int32 slotIndex); // 0x063a1af8
	System.Void .ctor(); // 0x0639ef94
	System.Void <Show>b__13_0(UnityEngine.GameObject a, UnityEngine.GameObject b); // 0x063a1b7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlantBox2D : System.Object
{
	static SocLogger logger; // 0x0
	FairyGUI.GList plantLst; // 0x10
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,FairyGUI.GObject>> plantGODic; // 0x18
	WizardGames.Soc.SocClient.Plant.PlantBoxData curPlantBox; // 0x20
	WizardGames.Soc.SocClient.Ui.EPageType pageType; // 0x28
	WizardGames.Soc.SocClient.Ui.UiHybridSelectPlant uiHybridSelectPlant; // 0x30
	System.Collections.Generic.List<System.Int32> selectedIdxes; // 0x38
	System.Action itemSelectChangeAction; // 0x40
	System.Int32 lastSelectedIndex; // 0x48
	WizardGames.Soc.SocClient.Ui.UiPlantOperationSubPanel uiPlantOperationSubPanel; // 0x50
	System.Collections.Generic.List<System.Int32> SelectedIndexSort; // 0x58
	static WizardGames.Soc.SocClient.Ui.UiPlantBox2D Create(FairyGUI.GComponent com, WizardGames.Soc.SocClient.Ui.UiPlantOperationSubPanel plantOperationSubPanel, WizardGames.Soc.SocClient.Ui.EPageType pageType, System.Action onChangeAction, WizardGames.Soc.SocClient.Ui.UiHybridSelectPlant uiSelectPlant); // 0x06390f64
	System.Void Init(FairyGUI.GComponent com, WizardGames.Soc.SocClient.Ui.UiPlantOperationSubPanel plantOperationSubPanel, WizardGames.Soc.SocClient.Ui.EPageType pageType, System.Action onChangeAction, WizardGames.Soc.SocClient.Ui.UiHybridSelectPlant uiSelectPlant); // 0x063a25a8
	System.Void Refresh(WizardGames.Soc.SocClient.Plant.PlantBoxData plantBox, System.Boolean first); // 0x06391624
	System.Void OnRenderPlant(System.Int32 index, FairyGUI.GObject obj); // 0x063a2b98
	System.Void OnClickPlant(FairyGUI.EventContext context); // 0x063a3918
	System.Boolean IsFirstSelect(System.Int32 index); // 0x063a3850
	System.Void OnPrePlant(System.Int32 selectedId, System.Int64 bizId, System.Int64 seedId); // 0x063a3d70
	System.Void OnCancelPrePlant(System.Int32 slot, System.Int64 instanceId); // 0x063a3fe4
	System.Void OnPlantDefaultPageToSeedPage(System.Int32 slot, System.Int32 pageType); // 0x063a4178
	System.Void OnPlantBoxModelSelectedSlot(System.Int32 slot, System.Int32 pageType); // 0x063a42ec
	System.Void SetLastSelectedIndex(System.Int32 curIndex); // 0x063a45dc
	System.Void Release(); // 0x0639118c
	System.Collections.Generic.List<System.Int32> GetSelected(); // 0x06396010
	System.Void RemoveAllSelected(); // 0x063a4654
	System.Void RemoveIndex(System.Int32 index); // 0x0638ce58
	System.Void .ctor(); // 0x063a2470
	static System.Void .cctor(); // 0x063a46e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlantBox2D.<>c__DisplayClass13_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiPlantBox2D <>4__this; // 0x10
	System.Int32 index; // 0x18
	Assets.Scripts.Plant.PlantBoxItemData plantData; // 0x20
	System.Void .ctor(); // 0x063a4adc
	System.Void <OnRenderPlant>b__0(FairyGUI.EventContext ctx); // 0x063a4b44
	System.Boolean <OnRenderPlant>b__1(WizardGames.Soc.SocClient.Ui.ComBaseIcon item1, WizardGames.Soc.SocClient.Ui.ItemDragInfo item2); // 0x063a4d0c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EPageType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EPageType None = -1;
	static WizardGames.Soc.SocClient.Ui.EPageType Default = 0;
	static WizardGames.Soc.SocClient.Ui.EPageType Seed = 1;
	static WizardGames.Soc.SocClient.Ui.EPageType Water = 2;
	static WizardGames.Soc.SocClient.Ui.EPageType Manure = 3;
	static WizardGames.Soc.SocClient.Ui.EPageType Harvest = 4;
	static WizardGames.Soc.SocClient.Ui.EPageType Hybrid = 5;
	static WizardGames.Soc.SocClient.Ui.EPageType PlantDetail = 6;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlantOperationSubPanel : WizardGames.Soc.SocClient.Ui.UiTabBasePanel
{
	FairyGUI.GComponent comWateringBar; // 0x20
	FairyGUI.GProgressBar wateringBar; // 0x28
	FairyGUI.GComponent comManualBar; // 0x30
	FairyGUI.GProgressBar manualBar; // 0x38
	FairyGUI.GTextField plantBoxWaterTxt; // 0x40
	FairyGUI.Controller rightWindownCtrl; // 0x48
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.EPageType,WizardGames.Soc.SocClient.Ui.UiPlantBasePage> plantPageDic; // 0x50
	WizardGames.Soc.SocClient.Plant.PlantBoxData curPlantBox; // 0x58
	WizardGames.Soc.SocClient.Ui.EPageType lastPageType; // 0x60
	System.Boolean isRegister; // 0x64
	WizardGames.Soc.SocClient.Ui.PlantEffectEmitter m_effectEmitter; // 0x68
	WizardGames.Soc.SocClient.Ui.PlantModelPreview plantModelPreview; // 0x70
	WizardGames.Soc.SocClient.Ui.ETabType get_TabType(); // 0x063a4e98
	FairyGUI.Controller get_RightWindownCtrl(); // 0x063a4efc
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.EPageType,WizardGames.Soc.SocClient.Ui.UiPlantBasePage> get_PlantPageDic(); // 0x063a4f60
	WizardGames.Soc.SocClient.Plant.PlantBoxData get_CurPlantBox(); // 0x063a4fc4
	WizardGames.Soc.SocClient.Ui.EPageType get_LastPageType(); // 0x063a5028
	WizardGames.Soc.SocClient.Ui.PlantModelPreview get_PlantModelPreview(); // 0x063a508c
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.UiPlantMain uiPlantMain); // 0x063a50f0
	System.Void Show(); // 0x063a57bc
	System.Void Hide(); // 0x063a6148
	System.Void OnFps10Update(); // 0x063a64f0
	System.Void OnDestroy(); // 0x063a65d0
	System.Void RegisterEvent(); // 0x063a5b64
	System.Void UnRegisterEvent(); // 0x063a6294
	System.Void OnUpdatePlantWater(System.Int64 collectionId); // 0x063a5f10
	System.Void ChangePage(WizardGames.Soc.SocClient.Ui.EPageType page); // 0x063a5dc4
	System.Void OnChangePage(); // 0x063a6818
	System.Void OnUpdatePlantsInfo(System.Int64 entityId); // 0x063a6aac
	System.Void RefreshPlants(System.Int64 entityId); // 0x063a5e58
	System.Void RefreshPage(); // 0x063a6b28
	System.Void OnWaterSuccess(System.Int64 collectionId, System.Int32 value); // 0x063a6c9c
	System.Void OnManualSuccess(System.Int64 collectionId); // 0x063a6de4
	System.Void .ctor(); // 0x063a6f24
	System.Void <OnWaterSuccess>b__37_0(); // 0x063a7044
	System.Void <OnManualSuccess>b__38_0(); // 0x063a70cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTabBasePanel : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiPlantMain uiPlantMain; // 0x10
	WizardGames.Soc.SocClient.Ui.ETabType <TabType>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.ETabType get_TabType(); // 0x063a7154
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.UiPlantMain uiPlantMain); // 0x063a71b8
	System.Void OnDestroy(); // 0x063a67b8
	System.Void Show(); // 0x063a5a6c
	System.Void Hide(); // 0x063a6234
	System.Void OnFps10Update(); // 0x063a6570
	System.Void .ctor(); // 0x063a6fdc
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ETabType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ETabType PlantOperation = 0;
	static WizardGames.Soc.SocClient.Ui.ETabType Hybridization = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlantMain : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	static SocLogger logger; // 0x0
	static System.Boolean IsOpen; // 0x8
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x338
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x340
	FairyGUI.GComponent navBarComponent; // 0x348
	FairyGUI.GComponent comContent; // 0x350
	FairyGUI.Controller ctrlTabType; // 0x358
	FairyGUI.Controller ctrlUIMainTabType; // 0x360
	WizardGames.Soc.SocClient.Ui.UiTabBasePanel curTabPanel; // 0x368
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ETabType,WizardGames.Soc.SocClient.Ui.UiTabBasePanel> tabPanelDic; // 0x370
	System.Int64 curEntityId; // 0x378
	WizardGames.Soc.SocClient.Ui.EPageType targetPageType; // 0x380
	WizardGames.Soc.Common.CustomType.BaseItemNode curInstanceItem; // 0x388
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ETabType,WizardGames.Soc.SocClient.Ui.UiTabBasePanel> get_TabPanelDic(); // 0x063a7238
	System.Void OnInit(); // 0x063a729c
	System.Void OnEnable(); // 0x063a7cb0
	System.Void OnDisable(); // 0x063a7e50
	System.Void OnDestroy(); // 0x063a7f08
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x063a8130
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x063a81c8
	System.Void OnInventoryUpdate(); // 0x063a7de0
	System.Void OpenDefaultPlantOperationSubPage(System.Int64 entityId, WizardGames.Soc.SocClient.Ui.EPageType ePageType, WizardGames.Soc.Common.CustomType.BaseItemNode instanceItem); // 0x063a825c
	System.Void OnClickTab(WizardGames.Soc.SocClient.Ui.ETabType page); // 0x063a8358
	System.Void UpdateNavBarTouchableState(WizardGames.Soc.SocClient.Ui.EPageType pageType); // 0x063a69fc
	static System.Void RemoteCallStartLooting(System.Int64 entityId, System.Action<System.Boolean> callBack); // 0x063a84b0
	static WizardGames.Soc.SocClient.Ui.UiPlantMain OpenWindow(); // 0x063a88a4
	static WizardGames.Soc.SocClient.Ui.UiPlantMain GetWindow(); // 0x063a8974
	static System.Void CloseWindow(); // 0x063a5acc
	System.Void .ctor(); // 0x063a8a34
	static System.Void .cctor(); // 0x063a8b0c
	System.Void <OnInit>b__15_0(WizardGames.Soc.SocClient.Ui.NavBarData navBarData, System.Boolean b); // 0x063a8bf0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlantMain.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiPlantMain.<>c <>9; // 0x0
	static System.Func<System.String> <>9__15_1; // 0x8
	static System.Func<System.String> <>9__15_2; // 0x10
	static System.Void .cctor(); // 0x063a8d28
	System.Void .ctor(); // 0x063a8d8c
	System.String <OnInit>b__15_1(); // 0x063a8df4
	System.String <OnInit>b__15_2(); // 0x063a8eac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlantMain.<>c__DisplayClass25_0 : System.Object
{
	System.Action<System.Boolean> callBack; // 0x10
	System.Void .ctor(); // 0x063a883c
	System.Void <RemoteCallStartLooting>b__0(System.Boolean res); // 0x063a8f64
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PlantUtils : System.Object
{
	
	static WizardGames.Soc.Common.Data.PlantModelCfg GetPlantModelCfg(System.Int64 seed, WizardGames.Soc.Common.Data.PlantStage stage); // 0x063a8ff8
	static UnityEngine.Vector3 GetVec(System.Single[] arr, UnityEngine.Vector3 r); // 0x063a9148
	static System.String GetStageDesc(WizardGames.Soc.Common.Data.PlantStage stage); // 0x063a9210
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerInfoCard : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	LobbyFriend.FriendInfo friendInfo; // 0x338
	FairyGUI.GButton btnBack; // 0x340
	FairyGUI.GLoader avatar; // 0x348
	FairyGUI.GTextInput textName; // 0x350
	FairyGUI.GTextField textId; // 0x358
	FairyGUI.GButton btnReportName; // 0x360
	System.Void OnInit(); // 0x063a935c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x063a9734
	System.Void OnClickReportBtn(); // 0x063a97b4
	System.Void ReportPlayerName(); // 0x063a9b90
	System.Void .ctor(); // 0x063a9ee4
	System.Void <OnInit>b__6_0(FairyGUI.EventContext ctx); // 0x063a9f70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerBadgeInfo : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	System.Boolean ignoreFirstTouchUp; // 0x338
	System.Boolean clickItemIcon; // 0x339
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.UiPlayerBadgeInfoBinder binder; // 0x340
	WizardGames.Soc.SocClient.Manager.OneMedalData medalData; // 0x348
	WizardGames.Soc.SocClient.Manager.EMedalTaskMode medalTaskMode; // 0x350
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.BadgeTaskItem_lobbyBinder> taskItemsBinderMap; // 0x358
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.ComtextBinder> scoreItemsBinderMap; // 0x360
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.ComiconBinder> rewardItemsBinderMap; // 0x368
	System.Collections.Generic.List<System.Int64> taskIdList; // 0x370
	System.Collections.Generic.List<System.Int32> playerIDList; // 0x378
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.ReleaseElements> rewardList; // 0x380
	System.Int32 curSelectGroupIndex; // 0x388
	System.Void OnInit(); // 0x063a9fe8
	System.Void OnClose(); // 0x063aa2f8
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x063aa36c
	System.Void OnEnable(); // 0x063aa534
	System.Void OnDisable(); // 0x063aa798
	System.Void OnSafeAreaClick(FairyGUI.EventContext ctx); // 0x063aaa7c
	System.Void OnMouseUp(FairyGUI.EventContext context); // 0x063aac28
	System.Boolean TryHideUiItemTips(); // 0x063aab24
	System.Void SetData(WizardGames.Soc.SocClient.Manager.OneMedalData oneMedalData); // 0x063aacd0
	System.Void RefreshMedalItemInfo(); // 0x063aad70
	System.Void RefreshMedalDetailDesc(); // 0x063ab320
	System.Void OnToggleListItemRender(System.Int32 index, FairyGUI.GObject gObject); // 0x063ab810
	System.Void OnToggleItemClick(FairyGUI.EventContext context); // 0x063ab950
	System.Void PlayRefreshAnim(); // 0x063abb50
	System.Void RefreshLobbyTaskInfo(WizardGames.Soc.SocClient.Manager.EMedalTaskMode medalTaskMode); // 0x063abdb8
	System.Void OnTaskItemRender(System.Int32 index, FairyGUI.GObject gObject); // 0x063ad444
	System.Void RefreshRewardInfo(); // 0x063ac72c
	System.Void OnRewardItemRender(System.Int32 index, FairyGUI.GObject gObject); // 0x063ad7b0
	System.Void OnClickOutGameItem(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x063adb50
	System.Void RefreshLobbyScoreInfo(); // 0x063acdc0
	System.Void OnScoreItemRender(System.Int32 index, FairyGUI.GObject gObject); // 0x063adce4
	static System.Void ShowMedalInfo(WizardGames.Soc.SocClient.Manager.OneMedalData oneMedalData); // 0x063ae1b8
	System.Void .ctor(); // 0x063ae378
	static System.Void .cctor(); // 0x063ae60c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerBadgeInfo.<>c__DisplayClass34_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.OneMedalData oneMedalData; // 0x10
	System.Void .ctor(); // 0x063ae310
	System.Void <ShowMedalInfo>b__0(WizardGames.Soc.SocClient.Ui.UiPlayerBadgeInfo win); // 0x063ae6e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerMedalHistory : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.UiPlayerAwardHistoryBinder binder; // 0x338
	System.Int32 styleType; // 0x340
	System.Collections.Generic.List<System.Int32> styleIdList; // 0x348
	FairyGUI.GObjectPool medalNodePool; // 0x350
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.MedalRecord>> medalInfoMap; // 0x358
	System.Collections.Generic.Dictionary<System.ValueTuple<System.Int64,System.Int32>,System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.MedalRecordInfo>> medalItemMap; // 0x360
	FairyGUI.Controller emptyController; // 0x368
	WizardGames.Soc.Common.CustomType.MedalTaskContainer get_medalContainer(); // 0x063ae764
	System.Void OnInit(); // 0x063ae880
	System.Void OnEnable(); // 0x063af620
	System.Void InitItemPool(); // 0x063af408
	System.Void OnClickItem(FairyGUI.EventContext ctx); // 0x063afb10
	System.Void OnMenuItemRender(System.Int32 Index, FairyGUI.GObject gObject); // 0x063b002c
	System.Void OnMedalRecordItemRender(System.Int32 index, FairyGUI.GObject gObject); // 0x063b02a4
	System.Void OnBadgeRecordItemRender(System.Int32 Index, FairyGUI.GObject gObject, WizardGames.Soc.Common.CustomType.MedalRecord medalRecord); // 0x063b0c6c
	System.Void OnDestroy(); // 0x063b0edc
	System.Void OnFps1Update(System.Single dt); // 0x063b0fb0
	System.Void .ctor(); // 0x063b1160
	static System.Void .cctor(); // 0x063b12f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerMedalHistory.<>c__DisplayClass15_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiPlayerMedalHistory <>4__this; // 0x10
	WizardGames.Soc.Common.CustomType.MedalRecord recordData; // 0x18
	System.Void .ctor(); // 0x063b0c04
	FairyGUI.GObject <OnMedalRecordItemRender>b__0(System.String url); // 0x063b13c8
	System.Void <OnMedalRecordItemRender>b__1(FairyGUI.GObject obj); // 0x063b1460
	System.Void <OnMedalRecordItemRender>b__2(System.Int32 index, FairyGUI.GObject gObject); // 0x063b14f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MedalListData : System.Object
{
	Config.LobbyRoleInfo lobbyRoleInfo; // 0x10
	WizardGames.Soc.Common.Data.resource.OBJStyleRankPoints styleCfg; // 0x18
	WizardGames.Soc.Common.Data.resource.OBJGenaral objGenaral; // 0x20
	WizardGames.Soc.Common.Data.Play.OBJStyleRankIcon iconConfig; // 0x28
	System.Int32 rankPoint; // 0x30
	System.Int32 curValue; // 0x34
	System.Int32 maxValue; // 0x38
	System.Int32 processCurValue; // 0x3c
	System.Int32 processMaxValue; // 0x40
	System.Boolean isMax; // 0x44
	System.Void InitData(); // 0x063b1588
	System.Void .ctor(); // 0x063b18d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerMedalHomePage : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.MedalHomepageBinder binder; // 0x10
	Config.LobbyRoleInfo lobbyRoleInfo; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.MedalListData> medalListDatas; // 0x20
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.ComMedalQualityBinder> medalCounBinderMap; // 0x28
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Manager.StyleMedalLevelCountInfo> otherPlayerStyleInfo; // 0x30
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.MedalbuttonBinder> itemBinderDic; // 0x38
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.MedalHomepageBinder binder); // 0x063b1940
	System.Void OnEnable(); // 0x063b1c1c
	System.Void OnDisable(); // 0x063b1d14
	System.Void OnDestory(); // 0x063b1e2c
	System.Void OpenRewardView(); // 0x063b1e8c
	System.Void OnRefreshSeasonTask(); // 0x063b1f50
	System.Void RefreshInfo(Config.LobbyRoleInfo lobbyRoleInfo); // 0x063b2054
	System.Void InitMedalListData(); // 0x063b2d2c
	System.Void OnRenderMedalItem(System.Int32 index, FairyGUI.GObject obj); // 0x063b2ff0
	System.Collections.Generic.List<System.Int32> GetOtherPlayerStyleCount(System.Int32 styleId); // 0x063b3bd0
	System.Void OnMedalCountItemRender(System.Collections.Generic.List<System.Int32> medalNumList, System.Int32 index, FairyGUI.GObject gObject); // 0x063b3cf4
	static System.Void .cctor(); // 0x063b3f44
	System.Void <.ctor>b__6_0(FairyGUI.EventContext ctx); // 0x063b4018
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerMedalHomePage.<>c__DisplayClass12_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiPlayerMedalHomePage <>4__this; // 0x10
	System.String roleId; // 0x18
	System.Void .ctor(); // 0x063b2cc4
	System.Void <RefreshInfo>b__0(System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Manager.StyleMedalLevelCountInfo> styleMedalLevelCountInfos); // 0x063b4090
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerMedalHomePage.<>c__DisplayClass15_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiPlayerMedalHomePage <>4__this; // 0x10
	System.Boolean isSelf; // 0x18
	WizardGames.Soc.SocClient.Ui.MedalListData data; // 0x20
	System.Void .ctor(); // 0x063b3b00
	System.Void <OnRenderMedalItem>b__0(FairyGUI.EventContext ctx); // 0x063b4158
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerMedalHomePage.<>c__DisplayClass15_1 : System.Object
{
	System.Collections.Generic.List<System.Int32> medalNumList; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPlayerMedalHomePage.<>c__DisplayClass15_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x063b3b68
	System.Void <OnRenderMedalItem>b__1(System.Int32 index, FairyGUI.GObject obj); // 0x063b4484
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChangeName : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.UiChangeNameBinder binder; // 0x338
	SocLogger logger; // 0x340
	WizardGames.Soc.SocClient.Ui.ComInputBox inputName; // 0x348
	WizardGames.Soc.SocClient.Ui.ComModal modal; // 0x350
	System.Void OnInit(); // 0x063b4520
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x063b4e04
	System.Void OnEnable(); // 0x063b4e84
	System.Void OnDisable(); // 0x063b5aac
	System.Void RefreshChangeNameCD(); // 0x063b5bb0
	static System.DateTime ConvertFromUnixTimestamp(System.Int64 timestamp); // 0x063b5c14
	System.Boolean RefreshChangeCD(); // 0x063b50dc
	System.Void OnInputNameChanged(); // 0x063b5cf8
	System.Boolean IsInputNameLegal(); // 0x063b65b8
	System.Void OnConfirmChange(); // 0x063b6680
	System.Void .ctor(); // 0x063b6d6c
	System.Void <OnInit>b__4_0(); // 0x063b6e94
	System.Void <OnConfirmChange>b__13_0(); // 0x063b6f08
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameStyle : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.UiGameSytleBinder binder; // 0x338
	System.Collections.Generic.List<System.Int32> curSelectInfo; // 0x340
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.OBJStyleRankPoints> SelectItems; // 0x348
	System.Void OnInit(); // 0x063b7050
	System.Void OnClickMedal(FairyGUI.EventContext context); // 0x063b7954
	System.Void OnEnable(); // 0x063b7b04
	System.Void OnDisable(); // 0x063b7c10
	System.Void OnRefreshStyleMedalLevelCount(System.Collections.Generic.List<System.Int32> list); // 0x063b7d1c
	System.Void OnClickSave(FairyGUI.EventContext context); // 0x063b7e54
	System.Void OnClickItem(FairyGUI.EventContext context); // 0x063b7fc4
	System.Void RefreshNum(); // 0x063b77bc
	System.Void Init(); // 0x063b7758
	System.Void ItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x063b8a80
	System.Void RefreshItem(System.Int32 styleId, FairyGUI.GComponent com); // 0x063b8b50
	System.Collections.Generic.List<System.Int32> GetStyleMedalNum(System.Int32 styleId); // 0x063b9274
	System.Void RefreshItems(); // 0x063b8484
	System.Void InitData(); // 0x063b8634
	System.Void .ctor(); // 0x063b9328
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameStyle.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiGameStyle.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__3_0; // 0x8
	static System.Action <>9__8_0; // 0x10
	static System.Void .cctor(); // 0x063b9458
	System.Void .ctor(); // 0x063b94bc
	System.Void <OnInit>b__3_0(); // 0x063b9524
	System.Void <OnClickSave>b__8_0(); // 0x063b95dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameStyle.<>c__DisplayClass13_0 : System.Object
{
	System.Collections.Generic.List<System.Int32> nums; // 0x10
	System.Void .ctor(); // 0x063b920c
	System.Void <RefreshItem>b__0(System.Int32 index, FairyGUI.GObject item); // 0x063b96b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMedalInterface : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.UiMedalInterfaceBinder binder; // 0x338
	WizardGames.Soc.SocClient.Manager.StyleMedalLevelCountInfo currStyleMadlLevelCountInfo; // 0x340
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.OBJGroupMedal_Lobby> groupMedals; // 0x348
	Config.LobbyRoleInfo lobbyRoleInfo; // 0x350
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar commonNavBar; // 0x358
	System.Int32 curSelectStyleId; // 0x360
	FairyGUI.GButton lastClickBtn; // 0x368
	FairyGUI.GObjectPool medalNodePool; // 0x370
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.DetailBadge_MedalInterfaceListBinder> groupBinderMap; // 0x378
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.DetailBadge_ComItemICONBinder> badgBinderMap; // 0x380
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.ComMedalQualityBinder> medalCounBinderMap; // 0x388
	System.Collections.Generic.List<System.Int32> medalNumList; // 0x390
	System.Collections.Generic.List<System.String> medalQuality; // 0x398
	System.Boolean get_isSelf(); // 0x063b982c
	System.Void OnInit(); // 0x063b98ec
	System.Void OnEnable(); // 0x063ba470
	System.Void OnDisable(); // 0x063ba758
	System.Void InitTopBar(); // 0x063b9ef4
	System.Void InitNavBar(); // 0x063ba008
	System.Void InitItemPool(); // 0x063b9cdc
	System.Void OnRefreshStyleMedalLevelcount(System.Collections.Generic.List<System.Int32> styleIds); // 0x063ba9c4
	System.Void RefreshMedalList(System.Int32 styleId); // 0x063bc02c
	System.Void RefreshMedalListInternal(System.Int32 styleId); // 0x063bab04
	System.Void OnGroupMedalItemRender(System.Int32 groupIndex, FairyGUI.GObject gObject); // 0x063bc4b8
	System.Void OnMedalItemRender(WizardGames.Soc.SocClient.Manager.OBJGroupMedal_Lobby groupMedalData, System.Int32 index, FairyGUI.GObject gObject); // 0x063bca2c
	System.Void OnMedalItemClick(WizardGames.Soc.SocClient.Manager.OneMedalData oneMedalData); // 0x063bd20c
	System.Void SetPlayerBadgeStyle(System.Boolean showBg); // 0x063bd3c0
	System.Void OnMedalCountItemRender(System.Int32 index, FairyGUI.GObject gObject); // 0x063bd434
	System.Void CloseBadgeInfoWindow(System.Boolean isHide); // 0x063ba874
	static System.Void Show(Config.LobbyRoleInfo lobbyRoleInfo, System.Int32 styleConfigId); // 0x063b42b4
	static System.Void ShowDeailBg(); // 0x063aa414
	System.Void .ctor(); // 0x063bd76c
	static System.Void .cctor(); // 0x063bdc9c
	System.Void <InitNavBar>b__20_0(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x063bdd70
	System.Void <RefreshMedalList>b__23_0(System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Manager.StyleMedalLevelCountInfo> styleMedalLevelCountInfos); // 0x063bde74
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMedalInterface.<>c__DisplayClass25_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiMedalInterface <>4__this; // 0x10
	WizardGames.Soc.SocClient.Manager.OBJGroupMedal_Lobby groupMedalData; // 0x18
	System.Void .ctor(); // 0x063bc9c4
	FairyGUI.GObject <OnGroupMedalItemRender>b__0(System.String url); // 0x063be028
	System.Void <OnGroupMedalItemRender>b__1(FairyGUI.GObject obj); // 0x063be0c0
	System.Void <OnGroupMedalItemRender>b__2(System.Int32 index, FairyGUI.GObject obj); // 0x063be154
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiMedalInterface.<>c__DisplayClass26_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.OneMedalData oneMedalData; // 0x10
	WizardGames.Soc.SocClient.Ui.UiMedalInterface <>4__this; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.DetailBadge_ComItemICONBinder itemBinder; // 0x20
	WizardGames.Soc.SocClient.Ui.ComBadgeItem comMedal; // 0x28
	System.Void .ctor(); // 0x063bd1a4
	System.Void <OnMedalItemRender>b__0(); // 0x063be1e8
	System.Void <OnMedalItemRender>b__1(); // 0x063be298
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPersonalTagPage : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.RootChangePlayerGameInfo_PersonalTagBinder binder; // 0x10
	System.Collections.Generic.List<System.String> tabTitles; // 0x18
	System.Collections.Generic.List<System.Int32> tabBelongTab; // 0x20
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.PersonalTagInfo>> dataDic; // 0x28
	System.Int32 selectTab; // 0x30
	System.Collections.Generic.List<System.Int32> curSelectTag; // 0x38
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.RootChangePlayerGameInfo_PersonalTagBinder page); // 0x063be520
	System.Void OnClickSave(FairyGUI.EventContext context); // 0x063bf13c
	System.Void OnClickTag(FairyGUI.EventContext context); // 0x063bf2ac
	System.Void OnClickTab(FairyGUI.EventContext context); // 0x063bed94
	System.Void TabItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x063bfa90
	System.Void Init(); // 0x063bed30
	System.Void ItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x063c0658
	System.Void RefreshInfo(); // 0x063bef34
	System.Void InitData(); // 0x063bfd50
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPersonalTagPage.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiPersonalTagPage.<>c <>9; // 0x0
	static System.Action <>9__5_0; // 0x8
	static System.Comparison<WizardGames.Soc.SocClient.Ui.PersonalTagInfo> <>9__14_0; // 0x10
	static System.Void .cctor(); // 0x063c0ba8
	System.Void .ctor(); // 0x063c0c0c
	System.Void <OnClickSave>b__5_0(); // 0x063c0c74
	System.Int32 <InitData>b__14_0(WizardGames.Soc.SocClient.Ui.PersonalTagInfo a, WizardGames.Soc.SocClient.Ui.PersonalTagInfo b); // 0x063c0d48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PersonalTagInfo : System.Object
{
	WizardGames.Soc.Common.Data.resource.OBJPersonalTag cfg; // 0x10
	System.Boolean selected; // 0x18
	System.Boolean unLock; // 0x19
	System.Boolean redDot; // 0x1a
	System.Void .ctor(WizardGames.Soc.Common.Data.resource.OBJPersonalTag item, System.Boolean v2, System.Boolean v3, System.Boolean v4); // 0x063c0adc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerAvatarFramePage : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.RootPlayerSkinViewContent_FrameBinder binder; // 0x10
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.HeadFraneInfo curSelect; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.HeadFraneInfo> list; // 0x20
	System.Int32 curUsedId; // 0x28
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.RootPlayerSkinViewContent_FrameBinder avatarPage); // 0x063c0dec
	System.Void RefreshData(); // 0x063c113c
	System.Void Init(); // 0x063c1030
	System.Void OnEnable(); // 0x063c18d8
	System.Void ItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x063c20b0
	System.String GetOwnNumber(); // 0x063c15ec
	System.Void RefreshInfo(); // 0x063c2608
	System.Void InitData(); // 0x063c1a2c
	static System.Void .cctor(); // 0x063c39c8
	System.Void <.ctor>b__5_0(FairyGUI.EventContext ctx); // 0x063c3a9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerAvatarFramePage.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiPlayerAvatarFramePage.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.HeadFraneInfo> <>9__12_0; // 0x8
	static System.Void .cctor(); // 0x063c3c98
	System.Void .ctor(); // 0x063c3cfc
	System.Int32 <InitData>b__12_0(WizardGames.Soc.SocClient.Ui.HeadFraneInfo a, WizardGames.Soc.SocClient.Ui.HeadFraneInfo b); // 0x063c3d64
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerAvatarFramePage.<>c__DisplayClass5_0 : System.Object
{
	System.Int32 selectId; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPlayerAvatarFramePage <>4__this; // 0x18
	System.Void .ctor(); // 0x063c3c30
	System.Void <.ctor>b__1(); // 0x063c3f04
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerAvatarFramePage.<>c__DisplayClass6_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.LobbyStashProfileData nowUse; // 0x10
	System.Void .ctor(); // 0x063c151c
	System.Boolean <RefreshData>b__1(WizardGames.Soc.SocClient.Ui.HeadFraneInfo a); // 0x063c41a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerAvatarFramePage.<>c__DisplayClass6_1 : System.Object
{
	System.Int32 id; // 0x10
	System.Void .ctor(); // 0x063c1584
	System.Boolean <RefreshData>b__0(WizardGames.Soc.SocClient.Ui.HeadFraneInfo a); // 0x063c4288
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerAvatarFramePage.<>c__DisplayClass9_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiPlayerAvatarFramePage <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.HeadFraneInfo data; // 0x18
	System.Void .ctor(); // 0x063c2528
	System.Void <ItemRenderer>b__0(FairyGUI.EventContext ctx); // 0x063c431c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.HeadFraneInfo : System.Object
{
	WizardGames.Soc.Common.Data.resource.OBJPortraitFrame cfg; // 0x10
	System.Boolean isUsed; // 0x18
	System.Boolean unLock; // 0x19
	WizardGames.Soc.SocClient.Ui.LobbyStashProfileData data; // 0x20
	System.Boolean get_IsExpired(); // 0x063c2590
	System.Void .ctor(WizardGames.Soc.Common.Data.resource.OBJPortraitFrame item, System.Boolean v2, System.Boolean v3, WizardGames.Soc.SocClient.Ui.LobbyStashProfileData data); // 0x063c38f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerAvatarPage : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.RootPlayerSkinViewContent_AvatarBinder binder; // 0x10
	WizardGames.Soc.SocClient.Ui.HeadInfo curSelect; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.HeadInfo> list; // 0x20
	System.String curUsedId; // 0x28
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.RootPlayerSkinViewContent_AvatarBinder avatarPage); // 0x063c43bc
	System.Void RefreshData(); // 0x063c470c
	System.Void Init(); // 0x063c4600
	System.Void OnEnable(); // 0x063c4f10
	System.Void ItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x063c5804
	System.String GetOwnNumber(); // 0x063c4c24
	System.Void RefreshInfo(); // 0x063c5ec8
	System.Void InitData(); // 0x063c5064
	static System.Void .cctor(); // 0x063c7638
	System.Void <.ctor>b__5_0(FairyGUI.EventContext ctx); // 0x063c770c
	System.Void <.ctor>b__5_1(); // 0x063c7a0c
	System.Void <RefreshInfo>b__11_0(WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconHandle handle); // 0x063c7c84
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerAvatarPage.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiPlayerAvatarPage.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.HeadInfo> <>9__12_0; // 0x8
	static System.Void .cctor(); // 0x063c7f40
	System.Void .ctor(); // 0x063c7fa4
	System.Int32 <InitData>b__12_0(WizardGames.Soc.SocClient.Ui.HeadInfo a, WizardGames.Soc.SocClient.Ui.HeadInfo b); // 0x063c800c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerAvatarPage.<>c__DisplayClass5_0 : System.Object
{
	System.Int32 selectId; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPlayerAvatarPage <>4__this; // 0x18
	System.Action <>9__3; // 0x20
	System.Void .ctor(); // 0x063c79a4
	System.Void <.ctor>b__2(); // 0x063c81bc
	System.Void <.ctor>b__3(); // 0x063c82d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerAvatarPage.<>c__DisplayClass6_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.LobbyStashProfileData nowUse; // 0x10
	System.Void .ctor(); // 0x063c4b54
	System.Boolean <RefreshData>b__1(WizardGames.Soc.SocClient.Ui.HeadInfo a); // 0x063c85a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerAvatarPage.<>c__DisplayClass6_1 : System.Object
{
	System.Int32 id; // 0x10
	System.Void .ctor(); // 0x063c4bbc
	System.Boolean <RefreshData>b__0(WizardGames.Soc.SocClient.Ui.HeadInfo a); // 0x063c8688
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerAvatarPage.<>c__DisplayClass9_0 : System.Object
{
	FairyGUI.GObject item; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPlayerAvatarPage <>4__this; // 0x18
	WizardGames.Soc.SocClient.Ui.HeadInfo data; // 0x20
	System.Void .ctor(); // 0x063c5de8
	System.Void <ItemRenderer>b__0(WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconHandle handle); // 0x063c871c
	System.Void <ItemRenderer>b__1(FairyGUI.EventContext ctx); // 0x063c8978
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.HeadInfo : System.Object
{
	WizardGames.Soc.Common.Data.resource.OBJPortrait cfg; // 0x10
	System.Boolean isWeChat; // 0x18
	System.Boolean isUsed; // 0x19
	System.Boolean unLock; // 0x1a
	WizardGames.Soc.SocClient.Ui.LobbyStashProfileData data; // 0x20
	System.Boolean get_IsExpired(); // 0x063c5e50
	System.Void .ctor(WizardGames.Soc.Common.Data.resource.OBJPortrait item, System.Boolean v1, System.Boolean v2, System.Boolean v3, WizardGames.Soc.SocClient.Ui.LobbyStashProfileData data); // 0x063c754c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerChatBgPage : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.RootPlayerSkinViewContent_ChatBubbleBinder binder; // 0x10
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.ChatBgInfo curSelect; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ChatBgInfo> list; // 0x20
	System.Int32 curUsedId; // 0x28
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.RootPlayerSkinViewContent_ChatBubbleBinder avatarPage); // 0x063c8a18
	System.Void Init(); // 0x063c8c5c
	System.Void OnEnable(); // 0x063c8d68
	System.String GetOwnNumber(); // 0x063c9548
	System.Void ItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x063c9834
	System.Void RefreshData(); // 0x063c9ce4
	System.Void RefreshInfo(); // 0x063ca0c4
	System.Void InitData(); // 0x063c8ebc
	static System.Void .cctor(); // 0x063cb5c8
	System.Void <.ctor>b__5_0(FairyGUI.EventContext ctx); // 0x063cb69c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerChatBgPage.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiPlayerChatBgPage.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.ChatBgInfo> <>9__12_0; // 0x8
	static System.Void .cctor(); // 0x063cbce0
	System.Void .ctor(); // 0x063cbd44
	System.Int32 <InitData>b__12_0(WizardGames.Soc.SocClient.Ui.ChatBgInfo a, WizardGames.Soc.SocClient.Ui.ChatBgInfo b); // 0x063cbdac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerChatBgPage.<>c__DisplayClass10_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.LobbyStashProfileData nowUse; // 0x10
	System.Void .ctor(); // 0x063cbfc4
	System.Boolean <RefreshData>b__1(WizardGames.Soc.SocClient.Ui.ChatBgInfo a); // 0x063cc02c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerChatBgPage.<>c__DisplayClass10_1 : System.Object
{
	System.Int32 id; // 0x10
	System.Void .ctor(); // 0x063cc10c
	System.Boolean <RefreshData>b__0(WizardGames.Soc.SocClient.Ui.ChatBgInfo a); // 0x063cc174
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerChatBgPage.<>c__DisplayClass5_0 : System.Object
{
	System.Int32 selectId; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPlayerChatBgPage <>4__this; // 0x18
	System.Void .ctor(); // 0x063cc208
	System.Void <.ctor>b__1(); // 0x063cc270
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerChatBgPage.<>c__DisplayClass9_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiPlayerChatBgPage <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.ChatBgInfo data; // 0x18
	System.Void .ctor(); // 0x063cc508
	System.Void <ItemRenderer>b__0(FairyGUI.EventContext ctx); // 0x063cc570
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ChatBgInfo : System.Object
{
	WizardGames.Soc.Common.Data.resource.OBJChatBubble cfg; // 0x10
	System.Boolean isUsed; // 0x18
	System.Boolean unLock; // 0x19
	WizardGames.Soc.SocClient.Ui.LobbyStashProfileData data; // 0x20
	System.Boolean get_IsExpired(); // 0x063cbf4c
	System.Void .ctor(WizardGames.Soc.Common.Data.resource.OBJChatBubble item, System.Boolean v2, System.Boolean v3, WizardGames.Soc.SocClient.Ui.LobbyStashProfileData data); // 0x063cc618
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerDeckOut : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.UiPlayerDeckOutBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.UiPlayerAvatarPage avatarPanel; // 0x340
	WizardGames.Soc.SocClient.Ui.UiPlayerAvatarFramePage avatarFramePanel; // 0x348
	WizardGames.Soc.SocClient.Ui.UiPlayerNameCardPage nameCardPanel; // 0x350
	WizardGames.Soc.SocClient.Ui.UiPlayerChatBgPage chatBgPanel; // 0x358
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x360
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x368
	System.Int32 selectedTabIndex; // 0x370
	System.Action closeCb; // 0x378
	System.Void OnInit(); // 0x063cc6e8
	System.Void JumpToTab(System.Int32 tabIndex); // 0x063cd6bc
	System.Void ShowPanel(System.Int32 selectedTabIndex); // 0x063cd758
	System.Void OnEnable(); // 0x063cdab4
	System.Void LoadTabData(); // 0x063cd218
	System.Void OnDisable(); // 0x063cdb28
	System.Void OnDestroy(); // 0x063cdb90
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x063cdbf8
	System.Void .ctor(); // 0x063cdc90
	static System.Void .cctor(); // 0x063cdd1c
	System.Void <OnInit>b__9_0(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x063cddf0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerHomeCard : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.UiPlayerHomeCardBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.UiPlayerHomepageViewMain mainPanel; // 0x340
	System.String resourceWin; // 0x348
	Config.LobbyRoleInfo roleInfo; // 0x350
	System.Void OnInit(); // 0x063cdefc
	System.Void MakeFullScreen(); // 0x063ce770
	System.Void OnEnable(); // 0x063ce7d8
	System.Void OnDisable(); // 0x063cecd8
	System.Void OnDestroy(); // 0x063cf420
	static System.Void Open(System.UInt64 roleId, System.Boolean fromTeamUi, System.Boolean isAppointment, System.String fromTribeId, WizardGames.Soc.SocClient.Ui.ReportEntry reportEntry, System.String resourceWin); // 0x063cf4f8
	System.Void Refresh(System.Boolean fromTeamUi, System.Boolean isAppointment, System.String fromTribeId); // 0x063cf718
	static System.Void CloseWindow(); // 0x063cfb2c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x063cfbdc
	System.Void .ctor(); // 0x063cfcc8
	static System.Void .cctor(); // 0x063cfd80
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerHomeCard.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiPlayerHomeCard.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__6_0; // 0x8
	static System.Void .cctor(); // 0x063cfe54
	System.Void .ctor(); // 0x063cfeb8
	System.Void <OnInit>b__6_0(); // 0x063cff20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerHomeCard.<>c__DisplayClass11_0 : System.Object
{
	System.String resourceWin; // 0x10
	System.Boolean fromTeamUi; // 0x18
	System.Boolean isAppointment; // 0x19
	System.String fromTribeId; // 0x20
	WizardGames.Soc.SocClient.Ui.ReportEntry reportEntry; // 0x28
	System.Void .ctor(); // 0x063cf6b0
	System.Void <Open>b__0(SimpleJSON.JSONNode jsonNode); // 0x063cffa4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerHomeCard.<>c__DisplayClass11_1 : System.Object
{
	SimpleJSON.JSONNode jsonNode; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPlayerHomeCard.<>c__DisplayClass11_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x063d0120
	System.Void <Open>b__1(WizardGames.Soc.SocClient.Ui.UiPlayerHomeCard uiPlayerHomepage); // 0x063d0188
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerHomeCard.<>c__DisplayClass11_2 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiPlayerHomeCard uiPlayerHomepage; // 0x10
	System.Void .ctor(); // 0x063d0398
	System.Void <Open>b__2(); // 0x063d0400
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EHomePageTab : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EHomePageTab MainPage = 0;
	static WizardGames.Soc.SocClient.Ui.EHomePageTab HistoryPage = 1;
	static WizardGames.Soc.SocClient.Ui.EHomePageTab DetailPage = 2;
	static WizardGames.Soc.SocClient.Ui.EHomePageTab BadgePage = 3;
	static WizardGames.Soc.SocClient.Ui.EHomePageTab MedalPage = 5;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerHomepage : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.UiPlayerHomeViewBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.UiPlayerHomepageViewMain uiPlayerHomeViewMain; // 0x340
	WizardGames.Soc.SocClient.Ui.UiPlayerMedalHomePage uiPlayerMedalHomePage; // 0x348
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x350
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x358
	Config.LobbyRoleInfo roleInfo; // 0x360
	WizardGames.Soc.SocClient.Ui.EHomePageTab curHomePage; // 0x368
	System.Int32 subTabId; // 0x36c
	System.Void OnInit(); // 0x063d1780
	System.Void JumpToTab(WizardGames.Soc.SocClient.Ui.EHomePageTab page); // 0x063d2810
	System.Void RefreshAccountInfo(); // 0x063d289c
	System.Void MakeFullScreen(); // 0x063d29c4
	System.Void ShowPanel(WizardGames.Soc.SocClient.Ui.EHomePageTab pageTab); // 0x063d2588
	System.Void OnEnable(); // 0x063d2bec
	System.Void LoadTabData(); // 0x063d20e4
	System.Boolean isSelfRole(); // 0x063d2d5c
	System.Void OnDisable(); // 0x063d2e24
	System.Void OnDestroy(); // 0x063d2ea4
	System.Void RefreshSelfRoleInfo(); // 0x063d3018
	System.Void RefreshInfo(Config.LobbyRoleInfo info, WizardGames.Soc.SocClient.Ui.EHomePageTab tabId, System.Int32 subTabId); // 0x063d31b0
	static System.Void Open(System.UInt64 roleId); // 0x063d3594
	static System.Void Open(System.UInt64 roleId, WizardGames.Soc.SocClient.Ui.EHomePageTab tabId, System.Int32 subId); // 0x063d375c
	static System.Void CloseWindow(); // 0x063d3954
	System.Void Refresh(); // 0x063d2b38
	System.Void OnFps1Update(System.Single dt); // 0x063d3a04
	System.Void .ctor(); // 0x063d3a78
	static System.Void .cctor(); // 0x063d3b04
	System.Void <OnInit>b__9_0(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x063d3bd8
	System.Void <RefreshAccountInfo>b__11_0(SimpleJSON.JSONNode jsonNode); // 0x063d3d9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerHomepage.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiPlayerHomepage.<>c <>9; // 0x0
	static System.Action<SimpleJSON.JSONNode> <>9__21_0; // 0x8
	static System.Void .cctor(); // 0x063d3f00
	System.Void .ctor(); // 0x063d3f64
	System.Void <Open>b__21_0(SimpleJSON.JSONNode jsonNode); // 0x063d3fcc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerHomepage.<>c__DisplayClass21_0 : System.Object
{
	Config.LobbyRoleInfo info; // 0x10
	System.Void .ctor(); // 0x063d4258
	System.Void <Open>b__1(WizardGames.Soc.SocClient.Ui.UiPlayerHomepage uiPlayerHomepage); // 0x063d42c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerHomepage.<>c__DisplayClass22_0 : System.Object
{
	System.String cacheAvatar; // 0x10
	WizardGames.Soc.SocClient.Ui.EHomePageTab tabId; // 0x18
	System.Int32 subId; // 0x1c
	System.Void .ctor(); // 0x063d38ec
	System.Void <Open>b__0(SimpleJSON.JSONNode jsonNode); // 0x063d4358
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerHomepage.<>c__DisplayClass22_1 : System.Object
{
	Config.LobbyRoleInfo info; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPlayerHomepage.<>c__DisplayClass22_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x063d4698
	System.Void <Open>b__1(WizardGames.Soc.SocClient.Ui.UiPlayerHomepage uiPlayerHomepage); // 0x063d4700
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EPlayerHomepageType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EPlayerHomepageType PlayerInfo = 0;
	static WizardGames.Soc.SocClient.Ui.EPlayerHomepageType PlayerCard = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerHomepageViewMain : System.Object
{
	System.String fromTribeId; // 0x10
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.ComUiPlayerModel model; // 0x18
	System.Boolean modelInit; // 0x20
	WizardGames.Soc.SocClient.Ui.ReportEntry reportEntry; // 0x24
	FairyGUI.GLoader loader; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.RootPlayerHomeViewContent_HomePageBinder binder; // 0x30
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.EOperationType,System.Action> setActionList; // 0x38
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.EOperationType,WizardGames.Soc.SocClient.Ui.RedDotType> settingRed; // 0x40
	System.Boolean fromTeamUI; // 0x48
	System.Boolean IsAppointment; // 0x49
	FairyGUI.GObject compareCom; // 0x50
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> selfOperations; // 0x58
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> otherOperations; // 0x60
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> selfNameCard; // 0x68
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> otherNameCard; // 0x70
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> selfSetting; // 0x78
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> otherMoreOperations; // 0x80
	FairyGUI.GButton teamInviteBtn; // 0x88
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> curBtn; // 0x90
	WizardGames.Soc.SocClient.Ui.EPlayerHomepageType type; // 0x98
	System.Boolean isSelf; // 0x9c
	Config.LobbyRoleInfo info; // 0xa0
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> <AllCostumePlan>k__BackingField; // 0xa8
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> <AllEquipPlan>k__BackingField; // 0xb0
	WizardGames.Soc.SocClient.Ui.PlayerAppearanceInfo avatorInfo; // 0xb8
	WizardGames.Soc.SocClient.Ui.ComUiPlayerModel get_uiPlayerModel(); // 0x063d47a8
	System.Void OnInit(FairyGUI.GComponent com, FairyGUI.GLoader loader, WizardGames.Soc.SocClient.Ui.EPlayerHomepageType type, FairyGUI.GObject compareCom); // 0x063ce66c
	System.Void MakeFullScreen(); // 0x063cec78
	System.Void InitEvent(); // 0x063d51cc
	System.Void CheckTencentPrivilege(); // 0x063d61c4
	System.Void OnWechatAppWelfareClick(); // 0x063d72a8
	System.Void InitPrivilegeBtn(System.String btnType, System.Boolean showAppWelfare2); // 0x063d6ad4
	System.Void OnAppWelfare2ClickVx(); // 0x063d73b8
	System.Void OnAppWelfare2ClickQq(); // 0x063d74ec
	System.Void RefreshOperationData(); // 0x063d7620
	System.Void ChangeTeamBtnData(); // 0x063d8230
	System.Void InitSettingBtnAction(); // 0x063d49a8
	System.Void SetWechatName(); // 0x063d8458
	System.Void RefreshRoleInfo(); // 0x063d8688
	System.Void OnClickCopyTextId(); // 0x063d93c4
	System.Void RefreshUnOpen(); // 0x063d94e8
	System.Void RefreshUnion(); // 0x063d9548
	System.Void RefreshLampTitle(); // 0x063d9844
	System.Void RegisterEvents(); // 0x063ce85c
	System.Void ResetWeapon(); // 0x063d9d48
	System.Void ShowRoleWeapon(System.Int32 id); // 0x063d9dbc
	System.Void OnLeaveTeamNotice(WizardGames.Soc.Share.Framework.ECustomDictOpType type, System.UInt64 arg2, WizardGames.Soc.Common.CustomType.TeamMemberInfo info); // 0x063da158
	System.Void UnRegisterEvents(); // 0x063cef14
	System.Void OnSetPlatformLaunchPrivilege(Config.MgrConfig.ERoleAppPrivilegeType roleAppPrivilegeType); // 0x063da26c
	System.Void OnLeaveTeamNotice(); // 0x063da208
	System.Void RefreshRoleWeapon(System.Int32 id); // 0x063da308
	System.Void RefreshRoleAvatar(System.Int32 id); // 0x063da430
	System.Void RefreshSelfRoleInfo(); // 0x063d309c
	System.Void RefreshBtn(); // 0x063d0474
	System.Void OnDisable(); // 0x063cf330
	System.Void OnDestory(); // 0x063cf498
	System.Void ShowModel(System.Boolean v); // 0x063d2a2c
	System.Void Refresh(Config.LobbyRoleInfo roleInfo); // 0x063cf7f4
	System.Void RefreshSeasonGroupUI(); // 0x063dab24
	System.Void RefreshSeasonRankUI(); // 0x063dad84
	System.Void RefreshGameStyle(); // 0x063db16c
	System.Void RendererGameStyle(System.Int32 index, FairyGUI.GObject item); // 0x063db478
	System.Void RefreshTag(); // 0x063da6c4
	System.Void RendererTag(System.Int32 index, FairyGUI.GObject item); // 0x063dba90
	System.Void set_AllCostumePlan(System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> value); // 0x063dbd44
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> get_AllCostumePlan(); // 0x063dbdc4
	System.Void set_AllEquipPlan(System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> value); // 0x063dbe28
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> get_AllEquipPlan(); // 0x063dbea8
	System.Void RefreshRoleAvator(); // 0x063da558
	System.Void RefreshCostumPlan(); // 0x063dbf0c
	System.Void SetAvatorInfo(System.Boolean isSelf, System.Int32 sex); // 0x063dc4f0
	System.Int32 GetPlanSex(System.Int32 curChosePlanId); // 0x063dc7d0
	System.Int32 GetPlanSexByDic(System.Collections.Generic.Dictionary<System.Int32,System.Int32> dic); // 0x063dc8d4
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> GetUsePlanData(System.Int32 planId, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> dic); // 0x063dc698
	System.Void GetPlayerAllCustomPlan(System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> AllCostumePlan, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> AllEquipPlan); // 0x063dcb24
	System.Void OnClick(WizardGames.Soc.SocClient.Ui.EOperationType type); // 0x063dcc54
	System.Void OnClickChangeName(); // 0x063dcf34
	System.Void OnClickChangeHeadIcon(); // 0x063dcff8
	System.Void OnClickChangeHeadFrame(); // 0x063dd108
	System.Void OnClickChangeNameCard(); // 0x063dd218
	System.Void OnClickChangeLightCard(); // 0x063dd328
	System.Void OnClickUnion(); // 0x063dd4a8
	System.Void OnClickChangeRoleAvator(); // 0x063dd59c
	System.Void OnClickChangeShowAvator(); // 0x063dd674
	System.Void OnClickChangeGameStyle(); // 0x063dd738
	System.Void OnClickChangeSeason(); // 0x063dd810
	System.Void OnClickChangePersonalTags(); // 0x063dd888
	System.Void OnClickChangeChatBg(); // 0x063dd924
	System.Void OnClickSetting(); // 0x063dda34
	System.Void OnReportPlayer(); // 0x063ddc70
	System.Void OnClickAddFriend(); // 0x063ddd9c
	System.Void PrivateChat(); // 0x063de00c
	System.Void TeamInvite(); // 0x063de0e4
	System.Void KickOutTeam(); // 0x063de214
	System.Void OnChangeTeamLeader(); // 0x063de580
	System.Void OnRemoveTribeMember(); // 0x063deba8
	System.Void OnTribeInvite(); // 0x063def90
	System.Void OnKickOut(); // 0x063de2dc
	System.Void OnChangeCaptain(); // 0x063de648
	System.Void OnKickOutLobbyTeam(); // 0x063de3e8
	System.Void OnLobbyTeamChangeCaptain(); // 0x063de748
	System.Void OnEnable(); // 0x063d2c6c
	System.Void .ctor(); // 0x063ce34c
	static System.Void .cctor(); // 0x063df06c
	System.Void <InitEvent>b__18_0(FairyGUI.EventContext ctx); // 0x063df140
	System.Void <InitEvent>b__18_1(FairyGUI.EventContext ctx); // 0x063df1bc
	System.Void <InitEvent>b__18_2(FairyGUI.EventContext ctx); // 0x063df234
	System.Void <InitEvent>b__18_3(FairyGUI.EventContext ctx); // 0x063df2b0
	System.Void <InitEvent>b__18_4(FairyGUI.EventContext ctx); // 0x063df32c
	System.Void <InitEvent>b__18_5(FairyGUI.EventContext ctx); // 0x063df3a8
	System.Void <InitEvent>b__18_6(FairyGUI.EventContext ctx); // 0x063df424
	System.Void <InitEvent>b__18_7(FairyGUI.EventContext ctx); // 0x063df4a0
	System.Void <InitEvent>b__18_8(FairyGUI.EventContext ctx); // 0x063df51c
	System.Void <InitEvent>b__18_9(FairyGUI.EventContext ctx); // 0x063df598
	System.Void <InitEvent>b__18_10(FairyGUI.EventContext ctx); // 0x063df614
	System.Void <InitEvent>b__18_11(FairyGUI.EventContext context); // 0x063df690
	System.Void <InitEvent>b__18_12(System.Int32 index, FairyGUI.GObject obj); // 0x063df824
	System.Void <InitEvent>b__18_13(System.Int32 index, FairyGUI.GObject obj); // 0x063dfb34
	System.Void <InitEvent>b__18_14(System.Int32 index, FairyGUI.GObject obj); // 0x063dfd30
	System.Void <InitEvent>b__18_15(FairyGUI.EventContext ctx); // 0x063e0078
	System.Void <InitEvent>b__18_16(FairyGUI.EventContext ctx); // 0x063e00f4
	System.Void <CheckTencentPrivilege>b__19_0(); // 0x063e0170
	System.Void <CheckTencentPrivilege>b__19_1(); // 0x063e01f0
	System.Void <InitSettingBtnAction>b__32_0(); // 0x063e0270
	System.Void <InitSettingBtnAction>b__32_1(); // 0x063e0320
	System.Void <InitSettingBtnAction>b__32_2(); // 0x063e04f8
	System.Void <InitSettingBtnAction>b__32_3(); // 0x063e0674
	System.Void <RefreshUnion>b__37_0(SimpleJSON.JSONArray json); // 0x063e0720
	System.Void <RefreshRoleWeapon>b__47_0(); // 0x063e08e8
	System.Void <RefreshRoleWeapon>b__47_1(SimpleJSON.JSONNode jsonNode); // 0x063e09f4
	System.Void <RefreshRoleAvatar>b__48_0(); // 0x063e0a88
	System.Void <RefreshRoleAvatar>b__48_1(SimpleJSON.JSONNode jsonNode); // 0x063e0b94
	System.Void <RefreshSelfRoleInfo>b__49_0(SimpleJSON.JSONNode jsonNode); // 0x063e0c50
	System.Void <PrivateChat>g__deal|97_0(WizardGames.Soc.SocClient.Ui.UiChat chat); // 0x063e0dd4
	System.Void <OnRemoveTribeMember>b__101_1(); // 0x063e0f10
	System.Void <OnLobbyTeamChangeCaptain>b__106_0(); // 0x063e10bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerHomepageViewMain.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiPlayerHomepageViewMain.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.ComUiPlayerModel> <>9__8_0; // 0x8
	static System.Comparison<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> <>9__30_0; // 0x10
	static System.Comparison<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> <>9__30_1; // 0x18
	static System.Comparison<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> <>9__30_2; // 0x20
	static System.Comparison<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> <>9__30_3; // 0x28
	static System.Comparison<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> <>9__30_4; // 0x30
	static System.Comparison<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> <>9__30_5; // 0x38
	static System.Predicate<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> <>9__31_0; // 0x40
	static System.Predicate<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> <>9__31_1; // 0x48
	static System.Action <>9__32_4; // 0x50
	static System.Predicate<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> <>9__51_4; // 0x58
	static System.Predicate<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> <>9__51_5; // 0x60
	static System.Predicate<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> <>9__51_6; // 0x68
	static System.Predicate<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> <>9__51_7; // 0x70
	static System.Predicate<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> <>9__51_8; // 0x78
	static System.Predicate<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> <>9__51_9; // 0x80
	static System.Predicate<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> <>9__51_10; // 0x88
	static System.Predicate<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> <>9__51_11; // 0x90
	static System.Predicate<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> <>9__51_12; // 0x98
	static System.Predicate<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> <>9__51_13; // 0xa0
	static System.Predicate<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> <>9__51_14; // 0xa8
	static System.Predicate<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> <>9__51_15; // 0xb0
	static System.Predicate<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> <>9__51_0; // 0xb8
	static System.Predicate<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> <>9__51_1; // 0xc0
	static System.Predicate<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> <>9__51_2; // 0xc8
	static System.Predicate<WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations> <>9__51_3; // 0xd0
	static System.Action <>9__101_0; // 0xd8
	static System.Action <>9__101_2; // 0xe0
	static System.Void .cctor(); // 0x063e1170
	System.Void .ctor(); // 0x063e11d4
	System.Void <get_uiPlayerModel>b__8_0(WizardGames.Soc.SocClient.Ui.ComUiPlayerModel model); // 0x063e123c
	System.Int32 <RefreshOperationData>b__30_0(WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations a, WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations b); // 0x063e12d8
	System.Int32 <RefreshOperationData>b__30_1(WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations a, WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations b); // 0x063e1390
	System.Int32 <RefreshOperationData>b__30_2(WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations a, WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations b); // 0x063e1448
	System.Int32 <RefreshOperationData>b__30_3(WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations a, WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations b); // 0x063e1500
	System.Int32 <RefreshOperationData>b__30_4(WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations a, WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations b); // 0x063e15b8
	System.Int32 <RefreshOperationData>b__30_5(WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations a, WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations b); // 0x063e1670
	System.Boolean <ChangeTeamBtnData>b__31_0(WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations x); // 0x063e1728
	System.Boolean <ChangeTeamBtnData>b__31_1(WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations x); // 0x063e17b0
	System.Void <InitSettingBtnAction>b__32_4(); // 0x063e1838
	System.Boolean <RefreshBtn>b__51_4(WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations a); // 0x063e18bc
	System.Boolean <RefreshBtn>b__51_5(WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations a); // 0x063e1944
	System.Boolean <RefreshBtn>b__51_6(WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations a); // 0x063e19cc
	System.Boolean <RefreshBtn>b__51_7(WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations a); // 0x063e1a54
	System.Boolean <RefreshBtn>b__51_8(WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations a); // 0x063e1adc
	System.Boolean <RefreshBtn>b__51_9(WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations a); // 0x063e1b64
	System.Boolean <RefreshBtn>b__51_10(WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations a); // 0x063e1bec
	System.Boolean <RefreshBtn>b__51_11(WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations a); // 0x063e1c74
	System.Boolean <RefreshBtn>b__51_12(WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations a); // 0x063e1cfc
	System.Boolean <RefreshBtn>b__51_13(WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations a); // 0x063e1d84
	System.Boolean <RefreshBtn>b__51_14(WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations a); // 0x063e1e0c
	System.Boolean <RefreshBtn>b__51_15(WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations a); // 0x063e1e94
	System.Boolean <RefreshBtn>b__51_0(WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations a); // 0x063e1f1c
	System.Boolean <RefreshBtn>b__51_1(WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations a); // 0x063e1fa4
	System.Boolean <RefreshBtn>b__51_2(WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations a); // 0x063e202c
	System.Boolean <RefreshBtn>b__51_3(WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations a); // 0x063e20b4
	System.Void <OnRemoveTribeMember>b__101_0(); // 0x063e213c
	System.Void <OnRemoveTribeMember>b__101_2(); // 0x063e21c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerHomepageViewMain.<>c__DisplayClass105_0 : System.Object
{
	System.String roleIdStr; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPlayerHomepageViewMain <>4__this; // 0x18
	System.Action <>9__1; // 0x20
	System.Void .ctor(); // 0x063df004
	System.Void <OnKickOutLobbyTeam>b__0(SimpleJSON.JSONNode jsonNode); // 0x063e224c
	System.Void <OnKickOutLobbyTeam>b__1(); // 0x063e2714
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerHomepageViewMain.<>c__DisplayClass18_0 : System.Object
{
	System.Int32 index; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPlayerHomepageViewMain <>4__this; // 0x18
	System.Void .ctor(); // 0x063dfacc
	System.Void <InitEvent>b__17(FairyGUI.EventContext context); // 0x063e27c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerHomepageViewMain.<>c__DisplayClass18_1 : System.Object
{
	System.Int32 index; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPlayerHomepageViewMain <>4__this; // 0x18
	System.Void .ctor(); // 0x063dfcc8
	System.Void <InitEvent>b__18(FairyGUI.EventContext context); // 0x063e29e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerHomepageViewMain.<>c__DisplayClass18_2 : System.Object
{
	System.Int32 index; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPlayerHomepageViewMain <>4__this; // 0x18
	System.Void .ctor(); // 0x063e0010
	System.Void <InitEvent>b__19(FairyGUI.EventContext context); // 0x063e2c1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerHomepageViewMain.<>c__DisplayClass81_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.EOperationType type; // 0x10
	System.Void .ctor(); // 0x063dcecc
	System.Boolean <OnClick>b__0(WizardGames.Soc.Common.Data.resource.OBJPersonalPageOperations a); // 0x063e2e50
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerHomepageViewMain.<>c__DisplayClass96_0 : System.Object
{
	System.Boolean isPrivateChat; // 0x10
	System.Boolean isTeam; // 0x11
	System.Void .ctor(); // 0x063ddfa4
	System.Void <OnClickAddFriend>g__deal|0(WizardGames.Soc.SocClient.Ui.UiChat chat); // 0x063e2edc
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EOperationType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EOperationType None = 0;
	static WizardGames.Soc.SocClient.Ui.EOperationType Info = 1;
	static WizardGames.Soc.SocClient.Ui.EOperationType AddFriend = 2;
	static WizardGames.Soc.SocClient.Ui.EOperationType PrivateChat = 3;
	static WizardGames.Soc.SocClient.Ui.EOperationType TeamInvite = 4;
	static WizardGames.Soc.SocClient.Ui.EOperationType More = 5;
	static WizardGames.Soc.SocClient.Ui.EOperationType Setting = 6;
	static WizardGames.Soc.SocClient.Ui.EOperationType Black = 7;
	static WizardGames.Soc.SocClient.Ui.EOperationType Report = 8;
	static WizardGames.Soc.SocClient.Ui.EOperationType RemoveFriend = 9;
	static WizardGames.Soc.SocClient.Ui.EOperationType ChangeName = 10;
	static WizardGames.Soc.SocClient.Ui.EOperationType ChangeHeadIcon = 11;
	static WizardGames.Soc.SocClient.Ui.EOperationType ChangeHeadFrame = 12;
	static WizardGames.Soc.SocClient.Ui.EOperationType ChangeShowAvatar = 13;
	static WizardGames.Soc.SocClient.Ui.EOperationType ChangeNameCard = 14;
	static WizardGames.Soc.SocClient.Ui.EOperationType ChangeRoleAvatar = 15;
	static WizardGames.Soc.SocClient.Ui.EOperationType ChangeLightCard = 16;
	static WizardGames.Soc.SocClient.Ui.EOperationType ChangePersonalTag = 17;
	static WizardGames.Soc.SocClient.Ui.EOperationType ChangeGameStyle = 18;
	static WizardGames.Soc.SocClient.Ui.EOperationType ChangeChatBubble = 19;
	static WizardGames.Soc.SocClient.Ui.EOperationType ChangeTeamLeader = 20;
	static WizardGames.Soc.SocClient.Ui.EOperationType RemoveTeamMember = 21;
	static WizardGames.Soc.SocClient.Ui.EOperationType TribeInvite = 22;
	static WizardGames.Soc.SocClient.Ui.EOperationType RemoveTribeMember = 23;
	static WizardGames.Soc.SocClient.Ui.EOperationType ChangeSeasonTag = 24;
	static WizardGames.Soc.SocClient.Ui.EOperationType ChangeUnion = 50;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerNameCardPage : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.RootPlayerSkinViewContent_NameCardBinder binder; // 0x10
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.NameCardInfo curSelect; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.NameCardInfo> list; // 0x20
	System.Int32 curUsedId; // 0x28
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.RootPlayerSkinViewContent_NameCardBinder avatarPage); // 0x063ccfd4
	System.Void RefreshData(); // 0x063e3130
	System.Void Init(); // 0x063e3024
	System.Void OnEnable(); // 0x063cd960
	System.String GetOwnNumber(); // 0x063e35e0
	System.Void ItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x063e3f50
	System.Void RefreshInfo(); // 0x063e44a8
	System.Void InitData(); // 0x063e38cc
	static System.Void .cctor(); // 0x063e5a74
	System.Void <.ctor>b__5_0(FairyGUI.EventContext ctx); // 0x063e5b48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerNameCardPage.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiPlayerNameCardPage.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.NameCardInfo> <>9__12_0; // 0x8
	static System.Void .cctor(); // 0x063e5d44
	System.Void .ctor(); // 0x063e5da8
	System.Int32 <InitData>b__12_0(WizardGames.Soc.SocClient.Ui.NameCardInfo a, WizardGames.Soc.SocClient.Ui.NameCardInfo b); // 0x063e5e10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerNameCardPage.<>c__DisplayClass10_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiPlayerNameCardPage <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.NameCardInfo data; // 0x18
	System.Void .ctor(); // 0x063e43c8
