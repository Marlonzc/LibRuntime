	System.Void <ItemRenderer>b__0(FairyGUI.EventContext ctx); // 0x063e5fb0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerNameCardPage.<>c__DisplayClass5_0 : System.Object
{
	System.Int32 selectId; // 0x10
	WizardGames.Soc.SocClient.Ui.UiPlayerNameCardPage <>4__this; // 0x18
	System.Void .ctor(); // 0x063e5cdc
	System.Void <.ctor>b__1(); // 0x063e6050
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerNameCardPage.<>c__DisplayClass6_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.LobbyStashProfileData nowUse; // 0x10
	System.Void .ctor(); // 0x063e3510
	System.Boolean <RefreshData>b__1(WizardGames.Soc.SocClient.Ui.NameCardInfo a); // 0x063e62f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerNameCardPage.<>c__DisplayClass6_1 : System.Object
{
	System.Int32 id; // 0x10
	System.Void .ctor(); // 0x063e3578
	System.Boolean <RefreshData>b__0(WizardGames.Soc.SocClient.Ui.NameCardInfo a); // 0x063e63d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.NameCardInfo : System.Object
{
	WizardGames.Soc.Common.Data.resource.OBJNameCard cfg; // 0x10
	System.Boolean isUsed; // 0x18
	System.Boolean unLock; // 0x19
	WizardGames.Soc.SocClient.Ui.LobbyStashProfileData data; // 0x20
	System.Boolean get_IsExpired(); // 0x063e4430
	System.Void .ctor(WizardGames.Soc.Common.Data.resource.OBJNameCard item, System.Boolean v2, System.Boolean v3, WizardGames.Soc.SocClient.Ui.LobbyStashProfileData data); // 0x063e59a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerPersonalIntroduction : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.UiPlayerPersonalIntroductionBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.UiPersonalTagPage uiPersonalTagPage; // 0x340
	WizardGames.Soc.SocClient.Ui.UiTribeLampEquipPage uiTribeLampEquipPage; // 0x348
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RedDotType> tabRedDot; // 0x350
	System.Collections.Generic.List<System.String> tabTitlet; // 0x358
	System.Int32 selectedTabIndex; // 0x360
	System.Void OnInit(); // 0x063e6468
	System.Void TabItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x063e70d0
	System.Void OnClickTab(FairyGUI.EventContext context); // 0x063e728c
	System.Void JumpToTab(System.Int32 tabIndex); // 0x063e7708
	System.Void ShowPanel(System.Int32 selectedTabIndex); // 0x063e745c
	System.Void OnEnable(); // 0x063e7ae0
	System.Void OnDisable(); // 0x063e7b48
	System.Void OnDestroy(); // 0x063e7ba8
	static System.Void Open(System.Int32 tabIndex); // 0x063dd3c4
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x063e7c10
	System.Void .ctor(); // 0x063e7c90
	static System.Void .cctor(); // 0x063e7ffc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeLampEquipPage : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.RootChangePlayerGameInfo_LightSignBinder binder; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.EquipTribeLampInfo> myLampInfos; // 0x18
	System.Int64 lastBtnSwitchClickTime; // 0x20
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.CommonPlayerPage.RootChangePlayerGameInfo_LightSignBinder page); // 0x063e6ff0
	System.Void Init(); // 0x063e80d0
	System.Void OnRenderGameStyleItem(System.Int32 index, FairyGUI.GObject obj); // 0x063e8564
	System.Void RefreshConfirmStatus(); // 0x063e8918
	System.Void OnClickConfirm(); // 0x063e8b90
	System.Void OnClickSwitch(); // 0x063e8e90
	System.Void Refresh(); // 0x063e78dc
	System.Void UpdateLampInfos(); // 0x063e9244
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeLampEquipPage.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiTribeLampEquipPage.<>c <>9; // 0x0
	static System.Action <>9__7_0; // 0x8
	static System.Comparison<WizardGames.Soc.SocClient.Ui.EquipTribeLampInfo> <>9__10_0; // 0x10
	static System.Void .cctor(); // 0x063e9970
	System.Void .ctor(); // 0x063e99d4
	System.Void <OnClickConfirm>b__7_0(); // 0x063e9a3c
	System.Int32 <UpdateLampInfos>b__10_0(WizardGames.Soc.SocClient.Ui.EquipTribeLampInfo a, WizardGames.Soc.SocClient.Ui.EquipTribeLampInfo b); // 0x063e9b10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.EquipTribeLampInfo : System.Object
{
	System.String TribeId; // 0x10
	WizardGames.Soc.SocClient.Ui.TribeMemberInfo MemberInfo; // 0x18
	System.String TribeName; // 0x20
	System.Int32 get_LampLevel(); // 0x063e9c08
	System.Void .ctor(); // 0x063e9908
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerSelect : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	FairyGUI.GComponent node; // 0x338
	FairyGUI.GButton btnConfirm; // 0x340
	FairyGUI.GButton btnSearch; // 0x348
	FairyGUI.GButton btnClear; // 0x350
	FairyGUI.GTextInput inputText; // 0x358
	FairyGUI.GList lstPlayerInfo; // 0x360
	FairyGUI.GList lstPlayerType; // 0x368
	System.Action<System.UInt64> confirmFunc; // 0x370
	System.Int32 selectedPlayerType; // 0x378
	System.Boolean IsOnSearching; // 0x37c
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.TeamSearchItemData> <GlobalSearchData>k__BackingField; // 0x380
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.TeamSearchItemData> <SearchResultData>k__BackingField; // 0x388
	System.Boolean globalRefresh; // 0x390
	System.Boolean isCom; // 0x391
	static System.Int32[] playerTypeLst; // 0x8
	System.Collections.Generic.List<System.UInt64> teamIdxMap; // 0x398
	System.Collections.Generic.List<System.UInt64> friendIdxMap; // 0x3a0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.RoleInfo> globalRoleInfoCache; // 0x3a8
	System.Single nxtValidSearchTime; // 0x3b0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.RoleInfo> searchRoleInfoCache; // 0x3b8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.RoleInfo> allRoleInfoCache; // 0x3c0
	System.Boolean IsSeepingBag; // 0x3c8
	static System.Action<WizardGames.Soc.SocClient.RoleInfo> InnerReleaseRoleInfo; // 0x10
	System.String strDoubleConfirm; // 0x3d0
	System.Void set_GlobalSearchData(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.TeamSearchItemData> value); // 0x063e9c78
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.TeamSearchItemData> get_GlobalSearchData(); // 0x063e9cf8
	System.Void set_SearchResultData(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.TeamSearchItemData> value); // 0x063e9d5c
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.TeamSearchItemData> get_SearchResultData(); // 0x063e9ddc
	System.UInt64 get_selectedPlayer(); // 0x063e9e40
	System.Void OnInit(); // 0x063e9f68
	System.Void Init(FairyGUI.GComponent com, System.Boolean asCom); // 0x063ea028
	System.Void ClearSearchData(); // 0x063ea96c
	System.Void SetupConfirmFunc(System.Action<System.UInt64> confirmFunc); // 0x063ead70
	System.Void Enable(); // 0x063eadf0
	System.Void OnEnable(); // 0x063eaf48
	System.Void OnDestroy(); // 0x063eafb8
	System.Void Dispose(); // 0x063eb028
	System.Void OnClickConfirm(); // 0x063eb178
	System.Void CloseWindow(); // 0x063eb66c
	System.Void SetupPlayerType(); // 0x063ea670
	System.Void ForceClickType(System.Int32 i); // 0x063ea8dc
	System.Void ClickPlayerType(); // 0x063eb6e8
	System.Void RefreshPlayerInfo(System.Boolean tryRefresh); // 0x063eab58
	System.Void OnSearchResult(System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.TeamSearchItemData> searchResult); // 0x063eca08
	System.Void SearchPlayer(System.String searchWord); // 0x063ece7c
	System.Void RefreshPlayerInfo_Search(); // 0x063eb8d8
	System.Void RefreshPlayerInfo(); // 0x063ed044
	System.Void RefreshPlayerInfo_SearchResult(); // 0x063ecd84
	System.Void RefreshPlayerInfo_GlobalResult(); // 0x063ecc30
	System.Void RefreshPlayerInfo_Team(); // 0x063ebbec
	System.Void RefreshPlayerInfo_Friend(); // 0x063ec510
	System.Void OnClickSearch(); // 0x063ed42c
	static System.Void FillCache(System.Collections.Generic.List<WizardGames.Soc.SocClient.RoleInfo> lst, System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.TeamSearchItemData> result, System.Boolean isSleepingBag); // 0x063ed184
	static System.Void ClearCache(System.Collections.Generic.List<WizardGames.Soc.SocClient.RoleInfo> lst); // 0x063eaa68
	System.Void SetConfirmBtnName(System.String name); // 0x063ed6fc
	System.Boolean get_IsDoubleConfirm(); // 0x063eb5f8
	System.Void SetupDoubleConfirm(System.String str); // 0x063ed79c
	System.Void .ctor(); // 0x063ed81c
	static System.Void .cctor(); // 0x063eda40
	System.Void <Init>b__24_0(); // 0x063edc0c
	System.Void <Init>b__24_1(); // 0x063edd08
	System.Void <Init>b__24_2(); // 0x063edd7c
	System.Void <Init>b__24_3(); // 0x063ede18
	System.Void <Init>b__24_4(); // 0x063ede8c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerSelect.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiPlayerSelect.<>c <>9; // 0x0
	static System.Void .cctor(); // 0x063edf30
	System.Void .ctor(); // 0x063edf94
	System.Void <.cctor>b__67_0(WizardGames.Soc.SocClient.RoleInfo item); // 0x063edffc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerSelect.<>c__DisplayClass31_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiPlayerSelect <>4__this; // 0x10
	System.UInt64 select; // 0x18
	System.Void .ctor(); // 0x063ee0b0
	System.Void <OnClickConfirm>b__0(); // 0x063ee118
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerSelectWithModel : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GComponent comPlayerSelect; // 0x338
	FairyGUI.GLabel nameTxt; // 0x340
	WizardGames.Soc.SocClient.Ui.UiPlayerSelect uiPlayerSelect; // 0x348
	System.Action<System.UInt64> clickConfirm; // 0x350
	System.Int64 partType; // 0x358
	System.Int64 skinId; // 0x360
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x368
	FairyGUI.GComponent content; // 0x370
	FairyGUI.GLoader touchRotate; // 0x378
	UnityEngine.GameObject modelInstance; // 0x380
	System.String get_partPath(); // 0x063ee1c0
	System.Void OnInit(); // 0x063ee25c
	System.Void OnDestroy(); // 0x063ee6b0
	static System.Void OpenWindow(System.Int64 partType, System.Int64 skinId, System.Action<System.UInt64> clickConfirm, System.String confirmBtnName, System.String doubleConfirmStr, System.String modelName, System.Boolean isSleepingBag); // 0x063ee8dc
	System.Void OnEnable(); // 0x063eeb30
	System.Void OnDisable(); // 0x063eebac
	System.Void SearchContainSensitiveWord(); // 0x063eec1c
	System.Void ClickConfirm(System.UInt64 id); // 0x063eec94
	System.Void ReleaseOldModel(); // 0x063ee728
	System.Void SetupModel(System.Int64 newModelType, System.Int64 skinId); // 0x063eed44
	System.Void .ctor(); // 0x063eef78
	System.Void <SetupModel>b__20_0(UnityEngine.GameObject a, UnityEngine.GameObject b); // 0x063ef004
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerSelectWithModel.<>c__DisplayClass13_0 : System.Object
{
	System.Action<System.UInt64> clickConfirm; // 0x10
	System.Int64 partType; // 0x18
	System.Int64 skinId; // 0x20
	System.String confirmBtnName; // 0x28
	System.String doubleConfirmStr; // 0x30
	System.String modelName; // 0x38
	System.Boolean isSleepingBag; // 0x40
	System.Void .ctor(); // 0x063eeac8
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiPlayerSelectWithModel win); // 0x063ef2f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerStatusMsg : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.tips.MsgTip> playerHudMsgTipList; // 0x10
	FairyGUI.GComponent rootCom; // 0x18
	FairyGUI.GList playerStatusMsgList; // 0x20
	System.Boolean isBag; // 0x28
	FairyGUI.Controller ctrlType; // 0x30
	FairyGUI.Controller ctrlStyle; // 0x38
	FairyGUI.EventCallback0 ListSizeChanged; // 0x40
	FairyGUI.EventCallback0 ListEmpty; // 0x48
	FairyGUI.GLabel playerLifeLabel; // 0x50
	FairyGUI.GLabel playerHungerLabel; // 0x58
	FairyGUI.GLabel playerWaterLabel; // 0x60
	System.Int32 curLife; // 0x68
	System.Int32 curHunger; // 0x6c
	System.Int32 curWater; // 0x70
	System.Single redFlashingValue; // 0x74
	System.Single orangeFlashingValue; // 0x78
	WizardGames.Soc.SocClient.Ui.UiPlayerStatusData playerStatusData; // 0x80
	System.Void .ctor(FairyGUI.GComponent rootCom, System.Boolean isBag); // 0x063ef42c
	System.Void OnEnable(); // 0x063ef9bc
	System.Void OnDisable(); // 0x063f004c
	System.Void RefreshPlayerHudMsgIdList(); // 0x063f0158
	System.Void UpdatePlayerStatus(); // 0x063ef880
	System.Void UpdatePlayerStatusView(System.Int32& curValue, System.Int32& compareValue, System.Int32& maxValue, FairyGUI.GLabel label); // 0x063f0298
	System.Void RenderPlayerStatusMsg(System.Int32 index, FairyGUI.GObject obj); // 0x063f046c
	System.Void SetPlayerMsgInfo(FairyGUI.GComponent com, WizardGames.Soc.Common.Data.tips.MsgTip msgData); // 0x063f0560
	UnityEngine.Color GetAnoxiaUrlColor(System.Int32 id, System.String dataStr); // 0x063f0b30
	System.Void UpdatePlayerHudMsgIdList(System.Collections.Generic.List<System.Int32> idList); // 0x063efb7c
	System.Void ModifyCtrType(System.String pageName); // 0x063f0de0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerStatusMsgBox : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	FairyGUI.GComponent root; // 0x338
	FairyGUI.GComponent boxCom; // 0x340
	WizardGames.Soc.SocClient.Ui.UiPlayerStatusMsg uiPlayerStatusMsg; // 0x348
	FairyGUI.GButton btnClose; // 0x350
	System.Void OnInit(); // 0x063f0e74
	System.Void OnDestroy(); // 0x063f129c
	System.Void OnEnable(); // 0x063f13b4
	System.Void OnDisable(); // 0x063f17d8
	System.Void OnFps1Update(System.Single dt); // 0x063f185c
	System.Void ModifyUiPlayerStatusMsgCtrType(System.String pageName); // 0x063f18dc
	System.Void ListEmpty(); // 0x063f196c
	static System.Void ShowMsgBox(System.Int32 x, System.Int32 y); // 0x063f19d8
	System.Void RefreshPosition(); // 0x063f1484
	System.Void OnHudClickBg(); // 0x063f1bb4
	System.Void OnHudRootCaptureTouch(UnityEngine.Vector2 pos); // 0x063f1c20
	System.Void .ctor(); // 0x063f1ca8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerStatusMsgBox.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiPlayerStatusMsgBox.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.UiPlayerStatusMsgBox> <>9__13_0; // 0x8
	static System.Void .cctor(); // 0x063f1d34
	System.Void .ctor(); // 0x063f1d98
	System.Void <ShowMsgBox>b__13_0(WizardGames.Soc.SocClient.Ui.UiPlayerStatusMsgBox win); // 0x063f1e00
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerViewer : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	FairyGUI.GComponent content; // 0x338
	FairyGUI.GList listManWrapper; // 0x340
	FairyGUI.Transition animAttrFirst; // 0x348
	FairyGUI.Transition animAttrChange; // 0x350
	FairyGUI.Controller ctrlSign; // 0x358
	FairyGUI.GTextField textAttrTitle; // 0x360
	FairyGUI.GTextField textAttrBullet; // 0x368
	FairyGUI.GTextField textAttrStab; // 0x370
	FairyGUI.GTextField textAttrExplotion; // 0x378
	FairyGUI.GTextField textAttrCold; // 0x380
	FairyGUI.GTextField textAttrRadiotion; // 0x388
	FairyGUI.GTextField textAttrAnimal; // 0x390
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x398
	WizardGames.Soc.SocClient.Ui.UiInventoryPlayerInfo playerInfo; // 0x3a0
	UnityEngine.GameObject objPlayerModel; // 0x3a8
	UnityEngine.Camera camPlayerModel; // 0x3b0
	UnityEngine.Transform transLights; // 0x3b8
	UnityEngine.Transform transLightParent; // 0x3c0
	System.Single modelStateSwitchTime; // 0x3c8
	DG.Tweening.Sequence modelSwitchAnim; // 0x3d0
	System.Int32 curSwitchIndex; // 0x3d8
	UnityEngine.Vector2 manRotateStartPos; // 0x3dc
	UnityEngine.Vector3 manStartEulerAng; // 0x3e4
	System.Boolean hasTriggerManRotateL; // 0x3f0
	System.Boolean hasTriggerManRotateR; // 0x3f1
	System.Boolean skipReleaseTexOnDisable; // 0x3f2
	WizardGames.Soc.SocClient.Ui.UiPlayerStatusMsg uiPlayerStatusAttr; // 0x3f8
	WizardGames.Soc.SocClient.Ui.ComUiPlayerModel comUiPlayerModel; // 0x400
	System.Int32[] partAttrTitle; // 0x408
	System.Void OnInit(); // 0x063f1f00
	System.Void InitPlayerStatusAttr(); // 0x063f2be8
	System.Void InitPartAttrs(); // 0x063f26c4
	System.Void InitWholdAttrs(); // 0x063f28ec
	System.Void OnShow(WizardGames.Soc.SocClient.Ui.ComUiPlayerModel comUiPlayerModel); // 0x063f2ccc
	System.Void OnEnable(); // 0x063f3628
	System.Void SetAttrText(FairyGUI.GTextField comText, WizardGames.Soc.Common.SimpleCustom.DamageType attrType, System.Boolean isPartAttr, System.String format); // 0x063f36fc
	System.Void RefreshPartAttrs(); // 0x063f3504
	System.Void RefreshWholeAttrs(); // 0x063f3434
	System.Void SwitchModelState(System.Int32 index, System.Boolean withAnim); // 0x063f2ec4
	System.Void OnManRotateTouchBegin(FairyGUI.EventContext ctx); // 0x063f3920
	System.Void OnManRotateTouchMove(FairyGUI.EventContext ctx); // 0x063f3a6c
	System.Void OnManRotateTouchEnd(FairyGUI.EventContext ctx); // 0x063f3dc8
	System.Void OnFps30Update(System.Single dt); // 0x063f3f3c
	System.Void OnFps1Update(System.Single dt); // 0x063f3fcc
	System.Void OnHideByLayerStack(System.String coverUiName); // 0x063f4058
	System.Void OnDisable(); // 0x063f40e4
	System.Void OnDestroy(); // 0x063f41c8
	static System.Void PopWithLoader(WizardGames.Soc.SocClient.Ui.ComUiPlayerModel comUiPlayerModel); // 0x063f4254
	System.Void .ctor(); // 0x063f4348
	System.Void <OnInit>b__29_0(); // 0x063f4484
	System.Void <OnInit>b__29_1(); // 0x063f44f0
	System.Void <OnInit>b__29_2(); // 0x063f455c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPlayerViewer.<>c__DisplayClass38_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiPlayerViewer <>4__this; // 0x10
	UnityEngine.Vector2 startSoftness; // 0x18
	UnityEngine.Vector2 targetSoftness; // 0x20
	System.Void .ctor(); // 0x063f38b8
	System.Void <SwitchModelState>b__0(); // 0x063f45c8
	System.Void <SwitchModelState>b__1(); // 0x063f4668
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.QuestionAnswerData : System.Object
{
	WizardGames.Soc.Common.Data.Questionnaire.QuestionnaireAnswer TbConfig; // 0x10
	System.Boolean IsSelected; // 0x18
	System.Void .ctor(); // 0x063f46e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiQuestionnaire : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.Controller stepState; // 0x338
	FairyGUI.GTextField questionTitle; // 0x340
	FairyGUI.GTextField endTitle; // 0x348
	FairyGUI.GList optionsList; // 0x350
	FairyGUI.GTextField questionnaireCount; // 0x358
	FairyGUI.GButton btnPre; // 0x360
	FairyGUI.GButton btnNext; // 0x368
	FairyGUI.GButton btnConfirm; // 0x370
	FairyGUI.GButton btnFinish; // 0x378
	FairyGUI.GTextField nextField; // 0x380
	FairyGUI.GTextField finishField; // 0x388
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Questionnaire.QuestionnaireQuestion> questions; // 0x390
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.QuestionAnswerData>> answerMap; // 0x398
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.QuestionAnswerData> currentAnswerList; // 0x3a0
	System.Boolean isSelectCurrentQuestion; // 0x3a8
	System.Int32 index; // 0x3ac
	UnityEngine.Color nextSelectColor; // 0x3b0
	UnityEngine.Color nextNotSelectColor; // 0x3c0
	System.Void OnInit(); // 0x063f4748
	System.Void RefreshUI(); // 0x063f557c
	System.Void RefreshNextBtnUI(); // 0x063f58d0
	System.Void SetStepController(); // 0x063f57b4
	System.Void InitQuestionData(); // 0x063f4f0c
	System.Void OptionsRenderer(System.Int32 index, FairyGUI.GObject item); // 0x063f5b40
	System.Void OnClickOptions(WizardGames.Soc.SocClient.Ui.QuestionAnswerData answerData); // 0x063f5e40
	System.Void OnClickPre(); // 0x063f5f64
	System.Void OnClickNext(); // 0x063f5fe4
	System.Void OnClickConfirm(); // 0x063f6148
	System.Void .ctor(); // 0x063f6450
	System.Void <OnInit>b__18_0(FairyGUI.EventContext ctx); // 0x063f65ec
	System.Void <OnInit>b__18_1(FairyGUI.EventContext ctx); // 0x063f6664
	System.Void <OnInit>b__18_2(FairyGUI.EventContext ctx); // 0x063f66dc
	System.Void <OnInit>b__18_3(FairyGUI.EventContext ctx); // 0x063f6754
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiQuestionnaire.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiQuestionnaire.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.QuestionAnswerData> <>9__22_0; // 0x8
	static System.Void .cctor(); // 0x063f67cc
	System.Void .ctor(); // 0x063f6830
	System.Int32 <InitQuestionData>b__22_0(WizardGames.Soc.SocClient.Ui.QuestionAnswerData a, WizardGames.Soc.SocClient.Ui.QuestionAnswerData b); // 0x063f6898
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiQuestionnaire.<>c__DisplayClass23_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiQuestionnaire <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.QuestionAnswerData info; // 0x18
	System.Void .ctor(); // 0x063f5dd8
	System.Void <OptionsRenderer>b__0(FairyGUI.EventContext ctx); // 0x063f693c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiQuickChatBubble : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	FairyGUI.GObjectPool _chatBubblePool; // 0x338
	FairyGUI.GComponent visualBorder; // 0x340
	FairyGUI.GComponent PanelRoot; // 0x348
	UnityEngine.Vector2 topleft; // 0x350
	UnityEngine.Vector2 bottomright; // 0x358
	UnityEngine.Vector2 rectCenter; // 0x360
	UnityEngine.Vector2 rectCenterLocal; // 0x368
	System.Single axisX; // 0x370
	System.Single axisY; // 0x374
	System.Single bubbleOffset; // 0x378
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.ComQuickChatBubble> _chatBubbles; // 0x380
	System.Void OnInit(); // 0x063f69c0
	FairyGUI.GComponent InitVisualBorder(); // 0x063f6db0
	System.Void OnEnable(); // 0x063f6e44
	System.Void OnDisable(); // 0x063f6eac
	System.Void OnDestroy(); // 0x063f6f14
	System.Void OnGetQuickNearbyChat(System.Int32 textId, System.Int64 senderEntityId); // 0x063f6fb4
	System.Void ReturnPool(FairyGUI.GComponent bubble, System.Int64 senderEntityId); // 0x063f7650
	System.Void OnFps30Update(System.Single dt); // 0x063f7740
	System.ValueTuple<System.Single,System.Single> SetBubblePivot(UnityEngine.Vector2 pos); // 0x063f79c0
	static WizardGames.Soc.SocClient.Ui.UiQuickChatBubble Open(System.Action<WizardGames.Soc.SocClient.Ui.UiQuickChatBubble> cb); // 0x063f7b04
	System.Void .ctor(); // 0x063f7bdc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiQuickPurchase : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.LobbyMall.RootMallBundlePackageBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x340
	WizardGames.Soc.SocClient.Ui.Binder.LobbyMall.ComPayPriceBinder payPriceCom; // 0x348
	WizardGames.Soc.SocClient.Ui.Binder.LobbyMall.ComPayPriceBinder notEnoughPriceCom; // 0x350
	WizardGames.Soc.SocClient.Ui.Binder.LobbyMall.ComBundlePackageItemBinder bundleBinder; // 0x358
	WizardGames.Soc.SocClient.MallSkinData mallSkinData; // 0x360
	System.Void OnInit(); // 0x063f7cb4
	System.Void OnEnable(); // 0x063f82c0
	System.Void OnDisable(); // 0x063f83d8
	System.Void OnDestroy(); // 0x063f84f0
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x063f8558
	System.Void SetData(System.Int32 skinID); // 0x063f85d8
	System.Void SetData(WizardGames.Soc.SocClient.MallSkinData mallSkinData); // 0x063f868c
	System.Void OnMallSkinShopComplete(WizardGames.Soc.SocClient.MallSkinData mallSkinData); // 0x063f8bc8
	System.Void RefreshUI(WizardGames.Soc.SocClient.MallSkinData mallSkinData); // 0x063f8718
	System.Void SetPriceInfo(System.Int32 currencyId, System.Int32 num); // 0x063f9408
	System.Void SetPriceInfo(System.Collections.Generic.List<System.Tuple<System.Int32,System.Int32>> costList); // 0x063f9a64
	System.Void SetBundleInfo(WizardGames.Soc.SocClient.MallSkinData mallSkinData); // 0x063f8d54
	System.Void OnBtnBuy(); // 0x063fa68c
	System.Void OnJumpBundleShop(); // 0x063fad30
	static System.Void OpenWindow(System.Int32 skinID); // 0x063faed8
	static System.Void OpenWindow(WizardGames.Soc.SocClient.MallSkinData mallSkinData); // 0x063fb08c
	System.Void .ctor(); // 0x063fb24c
	static System.Void .cctor(); // 0x063fb2d8
	System.Void <OnInit>b__7_0(); // 0x063fb3ac
	System.Void <OnBtnBuy>b__19_0(System.String urlParams); // 0x063fb420
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiQuickPurchase.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiQuickPurchase.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SDK.MidasWrapper.EPayResult,System.String> <>9__19_1; // 0x8
	static System.Void .cctor(); // 0x063fb5f8
	System.Void .ctor(); // 0x063fb65c
	System.Void <OnBtnBuy>b__19_1(WizardGames.Soc.SDK.MidasWrapper.EPayResult result, System.String msg); // 0x063fb6c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiQuickPurchase.<>c__DisplayClass21_0 : System.Object
{
	System.Int32 skinID; // 0x10
	System.Void .ctor(); // 0x063fb024
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiQuickPurchase win); // 0x063fb740
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiQuickPurchase.<>c__DisplayClass22_0 : System.Object
{
	WizardGames.Soc.SocClient.MallSkinData mallSkinData; // 0x10
	System.Void .ctor(); // 0x063fb1e4
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiQuickPurchase win); // 0x063fb7c4
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.RankInfo : System.ValueType
{
	System.Int32 rank; // 0x10
	System.Int32 score; // 0x14
	System.String dateStr; // 0x18
	System.Collections.Generic.List<System.Int64> players; // 0x20
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRank : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RankInfo> rankInfos; // 0x338
	System.Collections.Generic.Dictionary<System.Int64,System.ValueTuple<System.String,System.String>> playerInfos; // 0x340
	FairyGUI.GList listItems; // 0x348
	System.Void OnInit(); // 0x063fb848
	System.Void ItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x063fbd90
	System.Void OnGetPlayerInfo(System.Int32 index, SimpleJSON.JSONArray jsonArray); // 0x063fc410
	System.Void GetPlayerInfo(System.Int32 index, System.Collections.Generic.List<System.Int64> players); // 0x063fc0dc
	System.Void OnGetRankInfo(SimpleJSON.JSONNode res); // 0x063fc714
	System.Void GetRankInfo(); // 0x063fbaf8
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x063fcc54
	System.Void .ctor(); // 0x063fccd4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRank.<>c__DisplayClass4_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.RankInfo info; // 0x10
	WizardGames.Soc.SocClient.Ui.UiRank <>4__this; // 0x28
	System.Void .ctor(); // 0x063fc074
	System.Void <ItemRender>b__0(System.Int32 i, FairyGUI.GObject item); // 0x063fce04
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRank.<>c__DisplayClass6_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiRank <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Void .ctor(); // 0x063fc6ac
	System.Void <GetPlayerInfo>b__0(SimpleJSON.JSONArray res); // 0x063fcf98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiReconnect : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	FairyGUI.Transition transRotate; // 0x338
	FairyGUI.GTextField textMsg; // 0x340
	System.String oriMsg; // 0x348
	System.String unitSec; // 0x350
	System.Single startSec; // 0x358
	System.Int32 lastShowSec; // 0x35c
	System.Boolean msgWithSec; // 0x360
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x063fd020
	System.Void OnInit(); // 0x063fd0a0
	System.Void OnEnable(); // 0x063fd254
	System.Void OnDisable(); // 0x063fd300
	System.String UpdateMsgWithSec(System.Int32 sec); // 0x063fd37c
	System.Void OnFps10Update(System.Single dt); // 0x063fd4a8
	System.Void SetMsg(System.String strMsg); // 0x063fd5ec
	static System.Void Show(System.String strMsg); // 0x063fd6e0
	static System.Void Hide(); // 0x063fd7d0
	System.Void .ctor(); // 0x063fd888
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRemoteControl : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.GameRemoteControl.UiRemoteControlBinder binder; // 0x338
	FairyGUI.Controller stateCtrl; // 0x340
	FairyGUI.Transition loopAnim; // 0x348
	FairyGUI.Transition showAnim; // 0x350
	System.Void OnInit(); // 0x063fd924
	System.Void OnEnable(); // 0x063fdeb4
	System.Void OnDisable(); // 0x063fdf1c
	System.Void OnDestroy(); // 0x063fdf98
	System.Void OnClickBtnGreen(); // 0x063fe000
	System.Void OnClickBtnRed(); // 0x063fe130
	static System.Void CloseWindow(); // 0x063fe0bc
	static WizardGames.Soc.SocClient.Ui.UiRemoteControl GetWindow(); // 0x063fe1ec
	System.Void .ctor(); // 0x063fe2ac
	System.Void <OnInit>b__4_0(); // 0x063fe338
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiRemoteControl.EWinState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiRemoteControl.EWinState Green = 0;
	static WizardGames.Soc.SocClient.Ui.UiRemoteControl.EWinState Red = 1;
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.NeedGredientData : System.ValueType
{
	System.Int32 templateId; // 0x10
	System.Int32 ownedCount; // 0x14
	System.Int32 needCount; // 0x18
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRepair : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.GameSingleSpecialContainer.UiRepairBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x340
	FairyGUI.Transition loopAnim; // 0x348
	WizardGames.Soc.SocClient.Ui.ComItemIcon containerItemIcon; // 0x350
	WizardGames.Soc.Common.CustomType.ItemContainerNode repairItemContainer; // 0x358
	WizardGames.Soc.Common.CustomType.BaseItemNode containerItem; // 0x360
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.InventoryUIInfo> dataList; // 0x368
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> needgredientCountDic; // 0x370
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.NeedGredientData> needIngredientList; // 0x378
	System.Boolean hasEnoughInGredient; // 0x380
	System.Int32 tipId; // 0x384
	WizardGames.Soc.SocClient.Manager.UiConstructionPreviewSceneController uiPreviewSceneController; // 0x388
	System.Boolean playingRepairAnim; // 0x390
	WizardGames.Soc.SocClient.Ui.InventoryUIInfo curChooseIcon; // 0x398
	WizardGames.Soc.Common.Component.RepairBenchComponent get_RepairBench(); // 0x063fe3bc
	System.Void OnInit(); // 0x063fe488
	System.Void OnDestroy(); // 0x063ff294
	System.Void OnClickContainerItem(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x063ff330
	System.Boolean OnIconAcceptDrag(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x063ff598
	System.Void OnEnable(); // 0x063ff618
	System.Void OnDisable(); // 0x06400280
	System.Void OnHideByLayerStack(System.String coverUiName); // 0x064005a0
	System.Void OnShowByLayerStack(); // 0x06400634
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x064006b0
	System.Void CloseWindow(); // 0x06400728
	System.Void OnItemNodeUpdate(WizardGames.Soc.Common.CustomType.BaseItemNode item); // 0x064007e0
	System.Void BindeData(); // 0x063ffb08
	System.Void Refresh(); // 0x064001fc
	System.Void RefreshRight(); // 0x06400c20
	System.Void SetRigtBtnState(System.String itemName, System.String btnTxt, System.Boolean enableRepairBtn, System.String rightStateCtrl, System.String btnStatusCtrl); // 0x06401f00
	System.Void OnIngredientItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x06402964
	System.Void OnClickRepair(); // 0x06402c7c
	System.Void PlayRepairAnim(); // 0x06402f64
	System.Void PlayLoopAnim(); // 0x06401c78
	System.Void StopLoopAnim(); // 0x06401ba8
	System.Void PlaySwitchAnim(); // 0x06401d54
	System.Void PlayBtnLightTipAnim(); // 0x06402738
	System.Void RefreshBag(); // 0x063ffc44
	System.Void RefreshBagList(); // 0x06400900
	System.Boolean CanAddToBagList(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x0640362c
	System.Void SortBagList(); // 0x064033ac
	System.Void BagRenderList(System.Int32 index, FairyGUI.GObject obj); // 0x0640380c
	System.Void DealIconWhenCollect(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06403eb0
	System.Void OnClickItemIcon(WizardGames.Soc.SocClient.Ui.InventoryUIInfo clickdata, WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x06404078
	System.Void UnChooseAllIcons(); // 0x06403304
	System.Void SetIconDarkState(WizardGames.Soc.SocClient.Ui.ComItemIcon icon, System.Boolean beDark); // 0x06403fdc
	static System.Void OpenWindow(System.Int64 collectionID); // 0x064045dc
	static System.Void Close(); // 0x06404848
	System.Void .ctor(); // 0x06404930
	static System.Void .cctor(); // 0x06404ac0
	System.Void <OnEnable>b__20_0(UnityEngine.GameObject bg, UnityEngine.GameObject model); // 0x06404b94
	System.Void <PlayRepairAnim>b__34_0(); // 0x06404d1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRepair.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiRepair.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__16_0; // 0x8
	static System.Action<WizardGames.Soc.SocClient.Ui.InventoryUIInfo> <>9__39_0; // 0x10
	static System.Comparison<WizardGames.Soc.SocClient.Ui.InventoryUIInfo> <>9__42_0; // 0x18
	static System.Action<WizardGames.Soc.SocClient.Ui.ComBaseIcon,System.Boolean> <>9__44_0; // 0x20
	static System.Action<System.Boolean> <>9__49_0; // 0x28
	static System.Void .cctor(); // 0x06404d8c
	System.Void .ctor(); // 0x06404df0
	System.Void <OnInit>b__16_0(); // 0x06404e58
	System.Void <RefreshBag>b__39_0(WizardGames.Soc.SocClient.Ui.InventoryUIInfo info); // 0x06404ee0
	System.Int32 <SortBagList>b__42_0(WizardGames.Soc.SocClient.Ui.InventoryUIInfo data1, WizardGames.Soc.SocClient.Ui.InventoryUIInfo data2); // 0x06404f64
	System.Void <DealIconWhenCollect>b__44_0(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, System.Boolean state); // 0x0640505c
	System.Void <OpenWindow>b__49_0(System.Boolean res); // 0x0640526c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRepair.<>c__DisplayClass43_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiRepair <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.InventoryUIInfo data; // 0x18
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x20
	System.Void .ctor(); // 0x06403e48
	System.Void <BagRenderList>b__0(WizardGames.Soc.SocClient.Ui.ComBaseIcon clickIcon); // 0x0640536c
	System.Void <BagRenderList>b__1(WizardGames.Soc.SocClient.Ui.ComItemIcon dataChangeIcon); // 0x064053f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrReport : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Collections.Generic.Dictionary<System.String,System.Int64> ReportList; // 0x18
	System.Void UpdateOn1Fps(System.Int32 dt); // 0x064054b4
	System.Void .ctor(); // 0x06405928
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ReportEntry : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ReportEntry Chat = 1;
	static WizardGames.Soc.SocClient.Ui.ReportEntry InfoCard = 2;
	static WizardGames.Soc.SocClient.Ui.ReportEntry Respawn = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EReportType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EReportType Single = 0;
	static WizardGames.Soc.SocClient.Ui.EReportType Area = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiReport : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ReportEntry,System.Collections.Generic.List<WizardGames.Soc.Common.Data.Ui.ReportInfo>> reportTypes; // 0x338
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ReportEntry,System.Collections.Generic.List<WizardGames.Soc.Common.Data.Ui.ReportInfo>> reportAreaTypes; // 0x340
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ReportEntry,System.Collections.Generic.List<WizardGames.Soc.Common.Data.Ui.ReportInfo>> curReportTypes; // 0x348
	WizardGames.Soc.SocClient.Ui.EReportType reportType; // 0x350
	WizardGames.Soc.SocClient.Ui.ComModal modal; // 0x358
	FairyGUI.Controller reportTypeCtrl; // 0x360
	FairyGUI.GTextInput reportDetail; // 0x368
	FairyGUI.GList reportContent; // 0x370
	FairyGUI.GList reportTypeList; // 0x378
	FairyGUI.GTextField idText; // 0x380
	FairyGUI.GTextField txtCount; // 0x388
	FairyGUI.GTextField selectedCount; // 0x390
	WizardGames.Soc.SocClient.Ui.ReportEntry reportEntry; // 0x398
	System.Int32 selectCount; // 0x39c
	System.Int32 lastSelectIndex; // 0x3a0
	System.String playerName; // 0x3a8
	System.UInt64 roleId; // 0x3b0
	System.String reportText; // 0x3b8
	FairyGUI.GComponent panelRoot; // 0x3c0
	System.Void OnInit(); // 0x064059dc
	System.Void RefreshSelectNum(); // 0x064069e0
	System.Void InitData(); // 0x06406334
	System.Void OnEnable(); // 0x06406acc
	System.Void SetWindow(WizardGames.Soc.SocClient.Ui.EReportType type); // 0x06406b34
	System.Void SetAreaWindow(); // 0x06406e50
	System.Void AddItemToTypeList(); // 0x06407090
	System.Void AddItemToContentList(System.Int32 index); // 0x06407268
	System.Boolean ReportPlayer(SimpleJSON.JSONObject param); // 0x064076b4
	System.Int32 GetLanguageId(WizardGames.Soc.SocClient.Data.LanguageId languageId); // 0x0640a008
	System.Boolean ReportPlayerArea(); // 0x0640867c
	System.Int32 GetReportCategory(); // 0x06409f50
	System.Void RefreshReportReason(); // 0x064074c0
	System.Collections.Generic.List<System.Int32> GetReportReason(); // 0x06409b88
	System.Void .ctor(); // 0x0640a114
	System.Void <OnInit>b__19_0(); // 0x0640a24c
	System.Void <OnInit>b__19_2(); // 0x0640a2c0
	System.Void <OnInit>b__19_3(FairyGUI.EventContext context); // 0x0640a348
	System.Void <OnInit>b__19_4(FairyGUI.EventContext context); // 0x0640a534
	System.Void <OnInit>b__19_5(FairyGUI.EventContext context); // 0x0640a750
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiReport.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiReport.<>c <>9; // 0x0
	static System.Action <>9__19_1; // 0x8
	static System.Void .cctor(); // 0x0640a974
	System.Void .ctor(); // 0x0640a9d8
	System.Void <OnInit>b__19_1(); // 0x0640aa40
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiReport.<>c__DisplayClass27_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiReport <>4__this; // 0x10
	System.String reasonStr; // 0x18
	System.Void .ctor(); // 0x06408614
	System.Void <ReportPlayer>b__0(Config.LobbyRoleInfo userInfo); // 0x0640aaa0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiResearch : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.GameSingleSpecialContainer.UiResearchBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x340
	WizardGames.Soc.SocClient.Ui.ComItemIcon inputIcon; // 0x348
	WizardGames.Soc.SocClient.Ui.ComItemIcon outputIcon; // 0x350
	WizardGames.Soc.Common.CustomType.ItemContainerNode inputItemContainer; // 0x358
	WizardGames.Soc.Common.CustomType.ItemContainerNode outputItemContainer; // 0x360
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.InventoryUIInfo> dataList; // 0x368
	WizardGames.Soc.SocClient.Ui.ComPriceBtn buyBtn; // 0x370
	WizardGames.Soc.SocClient.Ui.ComStateBtn buyBtnNew; // 0x378
	WizardGames.Soc.SocClient.Ui.ComStateBtn stopBtn; // 0x380
	WizardGames.Soc.SocClient.Ui.ComStateBtn btnStudy; // 0x388
	FairyGUI.GList studyCostList; // 0x390
	System.Int32 consumeNumNeed; // 0x398
	System.Int32 unlockStageId; // 0x39c
	System.Int64 researchingUpdateTimerId; // 0x3a0
	System.Int64 initTimerId; // 0x3a8
	WizardGames.Soc.SocClient.Manager.UiConstructionPreviewSceneController uiPreviewSceneController; // 0x3b0
	static System.Boolean IsFromDetailList; // 0x8
	System.Int64 totalResearchTime; // 0x3b8
	System.Int64 curResearchCompleteTimeTs; // 0x3c0
	WizardGames.Soc.SocClient.Ui.InventoryUIInfo curChooseIcon; // 0x3c8
	WizardGames.Soc.Common.Component.ResearchBenchComponent get_Research(); // 0x0640afcc
	System.Void OnInit(); // 0x0640b098
	System.Void OnEnable(); // 0x0640cfb0
	System.Void OnDestroy(); // 0x0640d8e4
	System.Void OnHideByLayerStack(System.String coverUiName); // 0x0640d980
	System.Void OnShowByLayerStack(); // 0x0640da14
	System.Void OnDisable(); // 0x0640da90
	System.Void UnChooseAndHideTip(); // 0x0640e44c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0640fd4c
	System.Void CloseWindow(); // 0x0640fdc4
	System.Void CancelTimer(); // 0x0640dee0
	System.Void CancelInitTimer(); // 0x0640e1f8
	System.Void OnItemNodeUpdate(WizardGames.Soc.Common.CustomType.BaseItemNode item); // 0x064104bc
	System.Void FirstOpenBag(); // 0x064105e4
	System.Void BindeData(); // 0x0640d748
	System.Void Refresh(); // 0x0640d858
	System.Void RefreshLeft(); // 0x06410790
	System.Void SetIconInfo(FairyGUI.GComponent iconComp, System.Int64 id, System.Int32 num, System.Int32 needNum); // 0x06411448
	System.Void RefreshRight(); // 0x055049cc
	System.Void PlayLoopAnim(); // 0x06411a3c
	System.Void StopLoopAnim(); // 0x0640fe7c
	System.Void PlayFinishAnim(); // 0x06410134
	System.Void PlaySwitchAnim(); // 0x06411764
	System.Void PlayStudyTipAnim(); // 0x064102e0
	System.Void ResearchingUpdateTimer(System.Int64 timerId, System.Object callbackData, System.Boolean needDelete); // 0x0641223c
	System.Void SetTimeInfo(); // 0x06411d00
	System.Void OnClickNormal(FairyGUI.EventContext ctx); // 0x064122d0
	System.Void StartResearch(); // 0x06412484
	System.Void OnClickStart(FairyGUI.EventContext ctx); // 0x064126e0
	System.Void OnClickStop(FairyGUI.EventContext ctx); // 0x06412764
	System.Void RequestCancelResearch(); // 0x064127e8
	System.Void OnClickGet(FairyGUI.EventContext ctx); // 0x06412880
	System.Void RequestStudy(); // 0x06412a64
	System.Void OnClickStudy(FairyGUI.EventContext ctx); // 0x06412cec
	System.Void OnClickItem(); // 0x06412d70
	System.Void OnClickOutputItem(); // 0x064134f4
	System.Void OnStopTipTouchEnd(FairyGUI.EventContext ctx); // 0x06412400
	System.Void ClearCurChooseIcon(); // 0x064137d8
	System.Void OnClickCloseBag(FairyGUI.EventContext ctx); // 0x06413c6c
	static System.String PrintPath<T>(T path); // 0x052af1f0
	System.Void HideBag(); // 0x0640e2fc
	System.Void RefreshBag(); // 0x06413030
	System.Void RefreshBagList(); // 0x06411060
	System.Boolean CanAddToBagList(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x06413fa8
	System.Void SortBagList(); // 0x06413cf8
	System.Int32 GetConsumeNumNeed(System.Int64 itemCfgId); // 0x06411910
	System.Void BagRenderList(System.Int32 index, FairyGUI.GObject obj); // 0x064140a0
	System.Void DealIconWhenCollect(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x06414830
	System.Void OnClickItemIcon(WizardGames.Soc.SocClient.Ui.InventoryUIInfo clickdata, WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x06414a74
	UnityEngine.Vector2 GetItemTipPos(WizardGames.Soc.SocClient.Ui.ComItemIcon iconItem); // 0x064150d0
	System.Void UnChooseAllIcons(); // 0x0640e5e4
	System.Void UnChooseAllIconsEvent(); // 0x06415374
	System.Void SetIconDarkState(WizardGames.Soc.SocClient.Ui.ComItemIcon icon, System.Boolean beDark); // 0x0641495c
	System.Void UnlockStateProcess(WizardGames.Soc.SocClient.Ui.Binder.GameSingleSpecialContainer.ComIconBinder binder, WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x064149f8
	System.Void OnClickTakeOut(); // 0x064153e0
	System.Void MoveItemFromInput(); // 0x06415444
	static System.Void OpenWindow(System.Int64 collectionID, System.Boolean isFromDetailList); // 0x06415718
	static System.Void Close(); // 0x0641593c
	System.Void .ctor(); // 0x06415a24
	static System.Void .cctor(); // 0x06415b98
	System.Void <OnInit>b__21_0(); // 0x06415c6c
	System.Void <OnInit>b__21_1(); // 0x06415cd0
	System.Void <OnEnable>b__22_0(UnityEngine.GameObject bg, UnityEngine.GameObject model); // 0x06415d34
	System.Void <FirstOpenBag>b__33_0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x06415ebc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiResearch.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiResearch.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.InventoryUIInfo> <>9__64_0; // 0x8
	static System.Action<WizardGames.Soc.SocClient.Ui.ComBaseIcon,System.Boolean> <>9__71_0; // 0x10
	static System.Void .cctor(); // 0x06416424
	System.Void .ctor(); // 0x06416488
	System.Void <RefreshBag>b__64_0(WizardGames.Soc.SocClient.Ui.InventoryUIInfo info); // 0x064164f0
	System.Void <DealIconWhenCollect>b__71_0(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, System.Boolean state); // 0x064168cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiResearch.<>c__DisplayClass67_0 : System.Object
{
	System.Int32 hasNum; // 0x10
	System.Void .ctor(); // 0x06416adc
	System.Int32 <SortBagList>b__0(WizardGames.Soc.SocClient.Ui.InventoryUIInfo data1, WizardGames.Soc.SocClient.Ui.InventoryUIInfo data2); // 0x06416b44
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiResearch.<>c__DisplayClass70_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiResearch <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.InventoryUIInfo data; // 0x18
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x20
	System.Void .ctor(); // 0x06416c6c
	System.Void <BagRenderList>b__0(WizardGames.Soc.SocClient.Ui.ComBaseIcon clickIcon); // 0x06416cd4
	System.Void <BagRenderList>b__1(WizardGames.Soc.SocClient.Ui.ComItemIcon dataChangeIcon); // 0x06416d60
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiResearch.<>c__DisplayClass81_0 : System.Object
{
	System.Boolean isFromDetailList; // 0x10
	System.Void .ctor(); // 0x06416e20
	System.Void <OpenWindow>b__0(System.Boolean res); // 0x06416e88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InventoryUIInfo : System.Object
{
	System.Int32 Pos; // 0x10
	WizardGames.Soc.Common.CustomType.BaseItemNode ItemNode; // 0x18
	System.Int32 itemType; // 0x20
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap container; // 0x28
	System.Boolean unlock; // 0x30
	System.Boolean isSelect; // 0x31
	System.Boolean isEquip; // 0x32
	System.Int32 consumeNumNeed; // 0x34
	WizardGames.Soc.SocClient.Ui.ComItemIcon itemIcon; // 0x38
	System.Boolean isBuleprint; // 0x40
	System.Boolean isStoryStageLock; // 0x41
	System.Int32 unlickStageId; // 0x44
	static System.Collections.Generic.Dictionary<System.Int32,System.Int32> needgredientCountDic; // 0x0
	static System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.NeedGredientData> needIngredientList; // 0x8
	System.Boolean hasEnoughInGredient; // 0x48
	System.Boolean isMaxCondition; // 0x49
	System.Void RefreshResearchData(); // 0x06416570
	System.Void RefreshRepairData(); // 0x064170f8
	System.Int32 GetConsumeNumNeed(System.Int64 itemCfgId); // 0x06416fcc
	static System.Void CollectionBagListData(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.InventoryUIInfo> dataList, System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> condItemNode, System.Action<WizardGames.Soc.SocClient.Ui.InventoryUIInfo> action); // 0x06417ae0
	static System.Void MainInventoryData(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.InventoryUIInfo> dataList, System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> condItemNode, System.Action<WizardGames.Soc.SocClient.Ui.InventoryUIInfo> action); // 0x06417c04
	static System.Void ExtendInventoryData(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.InventoryUIInfo> dataList, System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> condItemNode, System.Action<WizardGames.Soc.SocClient.Ui.InventoryUIInfo> action); // 0x06417f54
	static System.Void RangedWeaponData(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.InventoryUIInfo> dataList, System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> condItemNode, System.Action<WizardGames.Soc.SocClient.Ui.InventoryUIInfo> action); // 0x0641837c
	static System.Void EquipData(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.InventoryUIInfo> dataList, System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> condItemNode, System.Action<WizardGames.Soc.SocClient.Ui.InventoryUIInfo> action); // 0x064185cc
	static System.Void ShortcutBarData(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.InventoryUIInfo> dataList, System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> condItemNode, System.Action<WizardGames.Soc.SocClient.Ui.InventoryUIInfo> action); // 0x0641881c
	System.Void .ctor(); // 0x06418a6c
	static System.Void .cctor(); // 0x06418ad4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiReward : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonReward.UiRewardBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.Binder.CommonReward.ComRewardItemBinder> itemBinders; // 0x340
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiReward.TaskRewardData> rewards; // 0x348
	System.Void OnInit(); // 0x06418bc4
	System.Void OnDisable(); // 0x06418fa0
	System.Void OnJumpToUi(System.Int32 jumpResourceID); // 0x0641922c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x064192b4
	System.Void ItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x06419334
	System.Void Show(System.String title, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiReward.TaskRewardData> rewards, System.String text); // 0x0641997c
	System.Void Refresh(); // 0x06419bc0
	System.Void .ctor(); // 0x06419ce4
	System.Void <OnInit>b__6_0(); // 0x06419e84
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiReward.ERewardProgress : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiReward.ERewardProgress CannotClaim = 0;
	static WizardGames.Soc.SocClient.Ui.UiReward.ERewardProgress CanClaim = 1;
	static WizardGames.Soc.SocClient.Ui.UiReward.ERewardProgress Claimed = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiReward.RewardData : System.Object
{
	WizardGames.Soc.Common.Data.resource.OBJGenaral Item; // 0x10
	System.Int32 Amount; // 0x18
	System.Void .ctor(); // 0x06419ef8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiReward.TaskRewardData : System.Object
{
	System.Int32 Id; // 0x10
	System.Func<WizardGames.Soc.SocClient.Ui.UiReward.TaskRewardData,WizardGames.Soc.SocClient.Ui.UiReward.ERewardProgress> Progress; // 0x18
	System.String Text; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiReward.RewardData> Rewards; // 0x28
	System.Action<WizardGames.Soc.SocClient.Ui.UiReward.TaskRewardData> OnClick; // 0x30
	System.Void .ctor(); // 0x06419f60
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiReward.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiReward.<>c <>9; // 0x0
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.Binder.CommonReward.ComRewardItemBinder> <>9__13_0; // 0x8
	static System.Void .cctor(); // 0x0641a014
	System.Void .ctor(); // 0x0641a078
	WizardGames.Soc.SocClient.Ui.Binder.CommonReward.ComRewardItemBinder <.ctor>b__13_0(FairyGUI.GComponent g); // 0x0641a0e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiReward.<>c__DisplayClass10_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiReward.TaskRewardData reward; // 0x10
	WizardGames.Soc.SocClient.Ui.UiReward.ERewardProgress progress; // 0x18
	WizardGames.Soc.SocClient.Ui.UiReward <>4__this; // 0x20
	System.Void .ctor(); // 0x06419914
	System.Void <ItemRenderer>b__0(System.Int32 i, FairyGUI.GObject obj); // 0x0641a184
	System.Void <ItemRenderer>b__1(); // 0x0641a304
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIRightButtonMenu : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GList menuList; // 0x338
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RightButtonItemData> rightMenuDatas; // 0x340
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.UiRightButtonMenuBinder binder; // 0x348
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComMenuBinder comMenuBinder; // 0x350
	FairyGUI.GObject menuBg; // 0x358
	static System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RightButtonItemData> rightButtons; // 0x0
	static WizardGames.Soc.SocClient.Ui.UiItemTipsBoardBtns borardInst; // 0x8
	System.Void OnInit(); // 0x0641a3a0
	System.Void OnEnable(); // 0x0641a848
	System.Void OnDisable(); // 0x0641a8b0
	System.Void OnDestroy(); // 0x0641aacc
	System.Void OnClose(); // 0x0641ab34
	System.Void ItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x0641ac1c
	System.Void OnMenuItemClick(FairyGUI.EventContext context); // 0x0641aec0
	static System.Void HideRightMenu(); // 0x0641afec
	System.Void .ctor(); // 0x0641b0dc
	static System.Void .cctor(); // 0x0641b1b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RightButtonItemData : System.Object
{
	System.String Title; // 0x10
	System.String Icon; // 0x18
	System.Action ClickAction; // 0x20
	System.Void Clear(); // 0x0641aa60
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRoleInfo : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GComponent comRoleInfoMain; // 0x338
	WizardGames.Soc.SocClient.Ui.UiRoleInfoMain roleInfoMain; // 0x340
	FairyGUI.GGraph touchHideBac; // 0x348
	System.Void OnInit(); // 0x0641b288
	System.Void ShowHideAnim(); // 0x0641bc50
	static System.Void HideInfo(); // 0x0641be88
	System.Void OnDisable(); // 0x0641bf38
	System.Void OnDestroy(); // 0x0641bfa0
	System.Void .ctor(); // 0x0641c124
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRoleInfo.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiRoleInfo.<>c <>9; // 0x0
	static System.Action <>9__5_0; // 0x8
	static System.Void .cctor(); // 0x0641c1b0
	System.Void .ctor(); // 0x0641c214
	System.Void <ShowHideAnim>b__5_0(); // 0x0641c27c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ERoleInfoInteract : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ERoleInfoInteract None = 0;
	static WizardGames.Soc.SocClient.Ui.ERoleInfoInteract Chat = 1;
	static WizardGames.Soc.SocClient.Ui.ERoleInfoInteract AddTeam = 2;
	static WizardGames.Soc.SocClient.Ui.ERoleInfoInteract AddFriend = 3;
	static WizardGames.Soc.SocClient.Ui.ERoleInfoInteract PlayerInfo = 4;
	static WizardGames.Soc.SocClient.Ui.ERoleInfoInteract BlockPlayer = 5;
	static WizardGames.Soc.SocClient.Ui.ERoleInfoInteract ReportPlayer = 6;
	static WizardGames.Soc.SocClient.Ui.ERoleInfoInteract DeleteFriend = 7;
	static WizardGames.Soc.SocClient.Ui.ERoleInfoInteract UnBlockPlayer = 8;
	static WizardGames.Soc.SocClient.Ui.ERoleInfoInteract ChangeCaptain = 9;
	static WizardGames.Soc.SocClient.Ui.ERoleInfoInteract GivePermission = 10;
	static WizardGames.Soc.SocClient.Ui.ERoleInfoInteract KickOut = 11;
	static WizardGames.Soc.SocClient.Ui.ERoleInfoInteract KickOutLobbyTeam = 12;
	static WizardGames.Soc.SocClient.Ui.ERoleInfoInteract LeaveLobbyTeam = 13;
	static WizardGames.Soc.SocClient.Ui.ERoleInfoInteract RevokePermission = 14;
	static WizardGames.Soc.SocClient.Ui.ERoleInfoInteract LobbyTeamChangeCaptain = 15;
	static WizardGames.Soc.SocClient.Ui.ERoleInfoInteract KickOutTribe = 16;
	static WizardGames.Soc.SocClient.Ui.ERoleInfoInteract CallBackToBattle = 17;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRoleInfoMain : System.Object
{
	System.UInt64 roleID; // 0x10
	System.String roleName; // 0x18
	FairyGUI.Controller ctrlNoFunc; // 0x20
	FairyGUI.GList gButtonList; // 0x28
	FairyGUI.GLoader badgeIcon; // 0x30
	FairyGUI.GGraph gBg; // 0x38
	FairyGUI.GGraph gBg2; // 0x40
	UnityEngine.Vector2 pos; // 0x48
	FairyGUI.GComponent gRoot; // 0x50
	WizardGames.Soc.SocClient.Ui.ComAvatarSquare comHead; // 0x58
	FairyGUI.GTextField gName; // 0x60
	System.Collections.Generic.Dictionary<System.Int32,System.Action> funcList; // 0x68
	System.Collections.Generic.Dictionary<System.Int32,System.String> funcNameList; // 0x70
	System.Collections.Generic.List<System.Int32> activateFuncList; // 0x78
	FairyGUI.GComponent comReputationLevel; // 0x80
	FairyGUI.GTextField reputationLevel; // 0x88
	FairyGUI.Controller stateCtrl; // 0x90
	FairyGUI.Transition animShow; // 0x98
	FairyGUI.Transition animHide; // 0xa0
	WizardGames.Soc.SocClient.ClientChatMessage message; // 0xa8
	System.String tribeId; // 0xb0
	static System.String GetInteractIconUrl(System.Int32 id); // 0x0641c2dc
	System.Void .ctor(FairyGUI.GComponent gCom); // 0x0641b4c0
	System.Void Destroy(); // 0x0641c018
	System.Void OnEntityBriefInfoAck(WizardGames.Soc.Common.SimpleCustom.EntityBriefInfo info); // 0x0641cc64
	System.Void ButtonInit(); // 0x0641c40c
	System.Void ItemRendererFunc(System.Int32 index, FairyGUI.GObject obj); // 0x0641ce00
	System.Void ClickFunc(FairyGUI.EventContext context); // 0x0641d070
	System.Void PlayHideAnim(System.Action callback); // 0x0641bd80
	System.Void OnBtnClicked(); // 0x0641d274
	System.Void TeamInvite(); // 0x0641d39c
	System.Void PrivateChat(); // 0x0641d67c
	System.Void OnClickAddFriend(); // 0x0641d754
	System.Void OnChangeCaptain(); // 0x0641d9cc
	System.Void OnGivePermission(); // 0x0641dab8
	System.Void OnRevokePermission(); // 0x0641dba4
	System.Void OnLobbyTeamChangeCaptain(); // 0x0641dc90
	System.Void OnKickOut(); // 0x0641e12c
	System.Void OnKickOutTribe(System.String name); // 0x0641e22c
	System.Void OnKickOutLobbyTeam(); // 0x0641e66c
	System.Void OnLeaveLobbyTeam(); // 0x0641e820
	System.Void OnReportPlayer(); // 0x0641ec8c
	System.Void <ButtonInit>b__27_0(); // 0x0641edfc
	System.Void <ButtonInit>b__27_1(); // 0x0641eeb8
	System.Void <ButtonInit>b__27_2(); // 0x0641ef1c
	System.Void <ButtonInit>b__27_3(); // 0x0641efd0
	System.Void <ButtonInit>b__27_4(); // 0x0641f088
	System.Void <ButtonInit>b__27_5(); // 0x0641f13c
	System.Void <ButtonInit>b__27_6(); // 0x0641f1a0
	System.Void <ButtonInit>b__27_7(); // 0x0641f204
	System.Void <ButtonInit>b__27_8(); // 0x0641f268
	System.Void <ButtonInit>b__27_9(); // 0x0641f2cc
	System.Void <ButtonInit>b__27_10(); // 0x0641f330
	System.Void <ButtonInit>b__27_11(); // 0x0641f394
	System.Void <ButtonInit>b__27_12(); // 0x0641f3f8
	System.Void <ButtonInit>b__27_13(); // 0x0641f45c
	System.Void <TeamInvite>b__37_0(); // 0x0641f4c4
	System.Void <PrivateChat>g__deal|38_0(WizardGames.Soc.SocClient.Ui.UiChat chat); // 0x0641f580
	System.Void <OnKickOutTribe>b__45_0(); // 0x0641f67c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRoleInfoMain.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiRoleInfoMain.<>c <>9; // 0x0
	static System.Action <>9__32_0; // 0x8
	static System.Action <>9__43_0; // 0x10
	static System.Action <>9__47_0; // 0x18
	static System.Void .cctor(); // 0x0641f754
	System.Void .ctor(); // 0x0641f7b8
	System.Void <ClickFunc>b__32_0(); // 0x0641f820
	System.Void <OnLobbyTeamChangeCaptain>b__43_0(); // 0x0641f880
	System.Void <OnLeaveLobbyTeam>b__47_0(); // 0x0641f8e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRoleInfoMain.<>c__DisplayClass34_0 : System.Object
{
	System.Action callback; // 0x10
	System.Void .ctor(); // 0x0641d334
	System.Void <PlayHideAnim>b__0(); // 0x0641f988
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRoleInfoMain.<>c__DisplayClass37_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ETeamSource eTeamSource; // 0x10
	System.Void .ctor(); // 0x0641d614
	System.Void <TeamInvite>g__deal|1(WizardGames.Soc.SocClient.Ui.UiChat chat); // 0x0641fa00
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRoleInfoMain.<>c__DisplayClass39_0 : System.Object
{
	System.Boolean isPrivateChat; // 0x10
	System.Boolean isTeam; // 0x11
	System.Void .ctor(); // 0x0641d964
	System.Void <OnClickAddFriend>g__deal|0(WizardGames.Soc.SocClient.Ui.UiChat chat); // 0x0641fad0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRoleInfoMain.<>c__DisplayClass46_0 : System.Object
{
	System.String roleIdStr; // 0x10
	System.Action <>9__1; // 0x18
	System.Void .ctor(); // 0x0641e7b8
	System.Void <OnKickOutLobbyTeam>b__0(SimpleJSON.JSONNode jsonNode); // 0x0641fc18
	System.Void <OnKickOutLobbyTeam>b__1(); // 0x064200e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRoulette : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.UiHudElem btnAction; // 0x338
	FairyGUI.GObject mainBtnBg; // 0x340
	System.Action quitAction; // 0x348
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.GroupData> data; // 0x350
	System.Int32 selectGroup; // 0x358
	System.Int32 selectPage; // 0x35c
	System.Int32 selectRoulette; // 0x360
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.OptionData> pageData; // 0x368
	FairyGUI.Controller rouletteType; // 0x370
	FairyGUI.Controller centerType; // 0x378
	System.Int32 selectOption; // 0x380
	System.Int32 touchId; // 0x384
	System.Collections.Generic.Dictionary<System.Int32,FairyGUI.GComponent> roulette; // 0x388
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<FairyGUI.GButton>> btns; // 0x390
	FairyGUI.GList _listItem; // 0x398
	FairyGUI.GButton lastBtn; // 0x3a0
	FairyGUI.GButton nextBtn; // 0x3a8
	System.Boolean joystick; // 0x3b0
	FairyGUI.GImage JoyStick; // 0x3b8
	FairyGUI.GComponent keyRoot; // 0x3c0
	FairyGUI.GComponent arrow; // 0x3c8
	FairyGUI.GTextField text; // 0x3d0
	FairyGUI.Controller joystickState; // 0x3d8
	FairyGUI.GComponent rouletteCenter; // 0x3e0
	FairyGUI.Controller roulettePage; // 0x3e8
	System.Collections.Generic.List<FairyGUI.GButton> centerBtn; // 0x3f0
	System.Boolean isDraging; // 0x3f8
	System.Boolean isClickCancel; // 0x3f9
	System.Boolean isActionCancel; // 0x3fa
	UnityEngine.Vector2 touchStartPos; // 0x3fc
	System.Single RouletteCancelAreaDiameter; // 0x404
	System.Single RouletteJoystickSensitivity; // 0x408
	System.Single RouletteDragThreshold; // 0x40c
	UnityEngine.Vector2 startPos; // 0x410
	UnityEngine.Vector2 centerPos; // 0x418
	System.Void OnInit(); // 0x06420188
	System.Void OnEnable(); // 0x06421c6c
	System.Void OnDisable(); // 0x06421d94
	System.Void BindBtn(WizardGames.Soc.SocClient.Ui.UiHudElem btn, System.Action a); // 0x06421e24
	System.Void UiLayerOpenEvent(System.Int32 layer); // 0x0642203c
	System.Void InitRoulette(); // 0x064202b0
	System.Void InitPage(); // 0x06420d80
	System.Void InitJoyStick(); // 0x064212b0
	System.Void InitComKeyTips(); // 0x06421a88
	System.Void InitRouletteCenter(); // 0x06421658
	System.Void OnListeningCloseWindow(UnityEngine.Vector2 uiPos); // 0x06422568
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x064225e4
	System.Void CloseWindow(); // 0x06422170
	System.Void SetData(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.GroupData> d, System.Int32 defaultGroup); // 0x0642265c
	System.Void RefreshData(); // 0x06422738
	System.Void SelectRoulette(System.Int32 index); // 0x06422888
	System.Void RefreshPageData(); // 0x06422930
	System.Void ChangePage(System.Int32 add); // 0x0642316c
	System.Void ChangeGroup(System.Int32 i); // 0x0642326c
	System.Void Refresh(); // 0x06422a58
	System.Void RefreshItemList(); // 0x064232ec
	System.Void BtnOnClick(System.Int32 index); // 0x06423414
	System.Void SetupJoystick(System.Single cancelAD, System.Single sensity, System.Single threshold); // 0x06423514
	System.Void OnJoyStickTouchBegin(FairyGUI.EventContext context); // 0x064235b0
	System.Void OnJoyStickTouchMove(FairyGUI.EventContext context); // 0x06423768
	System.Void OnJoyStickTouchEnd(FairyGUI.EventContext context); // 0x06423c80
	System.Void StartDragJoyStick(FairyGUI.EventContext context); // 0x064239d8
	System.Void onDragingJoyStick(FairyGUI.EventContext context); // 0x06423c04
	System.Void UpdateJoyStickPos(FairyGUI.EventContext context); // 0x06423dd4
	System.Void EndDragJoyStick(FairyGUI.EventContext context); // 0x06423d28
	System.Int32 GetActiveIndex(System.Single rot); // 0x0642456c
	System.Void OnSelectedOver(System.Int32 index); // 0x064243d0
	System.Void .ctor(); // 0x064246ac
	System.Void <OnEnable>b__27_0(); // 0x06424990
	System.Void <InitPage>b__32_0(FairyGUI.EventContext ctx); // 0x064249f4
	System.Void <InitPage>b__32_1(FairyGUI.EventContext ctx); // 0x06424a70
	System.Void <RefreshItemList>b__47_0(System.Int32 index, FairyGUI.GObject item); // 0x06424aec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRoulette.<>c__DisplayClass31_0 : System.Object
{
	System.Int32 j; // 0x10
	WizardGames.Soc.SocClient.Ui.UiRoulette <>4__this; // 0x18
	System.Void .ctor(); // 0x06422360
	System.Void <InitRoulette>b__0(FairyGUI.EventContext ctx); // 0x06424b90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRoulette.<>c__DisplayClass31_1 : System.Object
{
	System.Int32 j; // 0x10
	WizardGames.Soc.SocClient.Ui.UiRoulette <>4__this; // 0x18
	System.Void .ctor(); // 0x064223c8
	System.Void <InitRoulette>b__1(FairyGUI.EventContext ctx); // 0x06424c14
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRoulette.<>c__DisplayClass31_2 : System.Object
{
	System.Int32 j; // 0x10
	WizardGames.Soc.SocClient.Ui.UiRoulette <>4__this; // 0x18
	System.Void .ctor(); // 0x06422430
	System.Void <InitRoulette>b__2(FairyGUI.EventContext ctx); // 0x06424c98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRoulette.<>c__DisplayClass31_3 : System.Object
{
	System.Int32 j; // 0x10
	WizardGames.Soc.SocClient.Ui.UiRoulette <>4__this; // 0x18
	System.Void .ctor(); // 0x06422498
	System.Void <InitRoulette>b__3(FairyGUI.EventContext ctx); // 0x06424d1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRoulette.<>c__DisplayClass35_0 : System.Object
{
	System.Int32 j; // 0x10
	WizardGames.Soc.SocClient.Ui.UiRoulette <>4__this; // 0x18
	System.Void .ctor(); // 0x06422500
	System.Void <InitRouletteCenter>b__0(FairyGUI.EventContext ctx); // 0x06424da0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRuntimeTools : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	
	System.Void .ctor(); // 0x06424e24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSafeAreaDebug : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	FairyGUI.GTextField textInfo; // 0x338
	FairyGUI.GGraph tgpaCom; // 0x340
	System.Void OnInit(); // 0x06424eb0
	System.Void RefreshInfo(); // 0x064250c8
	System.Void .ctor(); // 0x064255b0
	static System.Void .cctor(); // 0x0642563c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiScreenMask : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	
	System.Void .ctor(); // 0x06425710
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiScreenSave : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	System.Collections.Generic.Dictionary<System.Int32,System.Boolean> uiLayerVisibleDict; // 0x338
	System.Void OnInit(); // 0x0642579c
	System.Void OnEnable(); // 0x064258d8
	System.Void OnDisable(); // 0x06425ea8
	System.Void HideAllLayersExceptHud(System.Boolean isHide); // 0x0642594c
	System.Void .ctor(); // 0x06425f1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiScrollListDebug : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GSlider sliderFactor; // 0x338
	FairyGUI.GTextInput inputFactor; // 0x340
	FairyGUI.GList list1; // 0x348
	FairyGUI.GList list2; // 0x350
	System.Single curFactor; // 0x358
	System.Void OnInit(); // 0x06425ff4
	FairyGUI.ListItemRenderer GetItemRenderer(System.Int32 offset); // 0x0642658c
	System.Void SetFactor(System.Single factor); // 0x06426678
	System.Void OnClickApply(); // 0x064269d8
	System.Void .ctor(); // 0x06426d3c
	System.Void <OnInit>b__5_0(); // 0x06426dd0
	System.Void <OnInit>b__5_1(); // 0x06426e8c
	System.Void <OnInit>b__5_2(); // 0x06426f34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiScrollListDebug.<>c__DisplayClass6_0 : System.Object
{
	System.Int32 offset; // 0x10
	System.Void .ctor(); // 0x06426970
	System.Void <GetItemRenderer>b__0(System.Int32 index, FairyGUI.GObject obj); // 0x06426fa0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSeasonRankItem : System.Object
{
	FairyGUI.GTextField txtRankNum; // 0x10
	WizardGames.Soc.SocClient.Ui.ComAvatarSquare comAvatarSquare; // 0x18
	WizardGames.Soc.SocClient.Ui.ComNameMedal comNameMedal; // 0x20
	FairyGUI.GTextField txtRankNick; // 0x28
	FairyGUI.GTextField txtRankScore; // 0x30
	FairyGUI.Controller ctrStatus; // 0x38
	FairyGUI.Controller ctrRankNum; // 0x40
	FairyGUI.Controller ctrIsRank; // 0x48
	System.Void Init(FairyGUI.GComponent root); // 0x064270f4
	System.Void Refresh(WizardGames.Soc.SocClient.Ui.ESeasonRankType seasonRankType, WizardGames.Soc.SocClient.Ui.SeasonRankItemData seasonRankItemData, System.Int32 styleID); // 0x06427440
	System.String GetGradeRankName(System.Int32 rankScore); // 0x06427714
	System.Void .ctor(); // 0x06427c28
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SeasonRankItemData : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	System.UInt64 roleId; // 0x10
	System.String portraitIconId; // 0x18
	System.UInt32 portraitFrameId; // 0x20
	System.Int32 level; // 0x24
	System.String name; // 0x28
	System.UInt32 nameCardId; // 0x30
	System.Int32 rankScore; // 0x34
	System.Int32 rankNum; // 0x38
	System.UInt32 sex; // 0x3c
	System.UInt32 faceID; // 0x40
	System.UInt32 hairID; // 0x44
	System.UInt32 hairColorID; // 0x48
	System.Void Init(System.UInt64 roleId, System.String portraitIconId, System.UInt32 portraitFrameId, System.Int32 level, System.String name, System.Int32 rankScore); // 0x06427c90
	System.Void Init(System.UInt64 roleId, System.String portraitIconId, System.UInt32 portraitFrameId, System.Int32 level, System.String name, System.UInt32 nameCardId, System.Int32 rankScore, System.Int32 rankNum, System.UInt32 sex, System.UInt32 faceID, System.UInt32 hairID, System.UInt32 hairColorID); // 0x06427d88
	System.Void Clear(); // 0x06427ec4
	System.Void OnGet(); // 0x06427f6c
	System.Void OnRelease(); // 0x06427fd0
	System.Void OnDestroy(); // 0x06428034
	System.Void .ctor(); // 0x06428098
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SeasonRankData : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SeasonRankItemData> rankItemDataList; // 0x10
	WizardGames.Soc.SocClient.Ui.SeasonRankItemData selfRankItemData; // 0x18
	System.Int32 total; // 0x20
	System.Void .ctor(); // 0x06428100
	System.Void Parse(SimpleJSON.JSONNode ret); // 0x06428210
	System.Void ParseFriendsSeasonPoint(); // 0x06428e58
	System.Void Clear(); // 0x06429384
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SeasonRankData.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.SeasonRankData.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.SeasonRankItemData> <>9__5_0; // 0x8
	static System.Void .cctor(); // 0x0642957c
	System.Void .ctor(); // 0x064295e0
	System.Int32 <ParseFriendsSeasonPoint>b__5_0(WizardGames.Soc.SocClient.Ui.SeasonRankItemData a, WizardGames.Soc.SocClient.Ui.SeasonRankItemData b); // 0x06429648
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SeasonRankEquipItemData : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	System.UInt64 roleId; // 0x10
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> costumeSlotEquipDic; // 0x18
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> equipmentSlotEquipDic; // 0x20
	System.Collections.Generic.Dictionary<System.String,System.Boolean> showOptionDic; // 0x28
	System.Void Parse(System.UInt64 roleId, SimpleJSON.JSONNode ret); // 0x064296dc
	System.Void Clear(); // 0x06429b6c
	System.Void OnGet(); // 0x06429c2c
	System.Void OnRelease(); // 0x06429c8c
	System.Void OnDestroy(); // 0x06429cec
	System.Void .ctor(); // 0x06429d4c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SeasonRankAppearanceData : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	System.UInt64 roleId; // 0x10
	System.UInt32 sex; // 0x18
	System.UInt32 faceID; // 0x1c
	System.UInt32 hairID; // 0x20
	System.UInt32 hairColorID; // 0x24
	System.UInt32 nameCardId; // 0x28
	System.Void Parse(System.UInt64 roleId, SimpleJSON.JSONArray retArray); // 0x06429e88
	System.Void Clear(); // 0x0642a134
	System.Void OnGet(); // 0x0642a1a0
	System.Void OnRelease(); // 0x0642a200
	System.Void OnDestroy(); // 0x0642a260
	System.Void .ctor(); // 0x0642a2c0
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ESeasonRankType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ESeasonRankType None = 0;
	static WizardGames.Soc.SocClient.Ui.ESeasonRankType Global = 1;
	static WizardGames.Soc.SocClient.Ui.ESeasonRankType Friend = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ERefreshDataReason : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ERefreshDataReason First = 0;
	static WizardGames.Soc.SocClient.Ui.ERefreshDataReason Pull = 1;
	static WizardGames.Soc.SocClient.Ui.ERefreshDataReason Scroll = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSeasonRank : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	SocLogger logger; // 0x338
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x340
	FairyGUI.GComponent navBarComponent; // 0x348
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x350
	FairyGUI.GTextField txtRankRefreshTime; // 0x358
	FairyGUI.GList list; // 0x360
	FairyGUI.GComponent footer; // 0x368
	FairyGUI.Controller ctrFooterState; // 0x370
	FairyGUI.GButton btnSelfRank; // 0x378
	WizardGames.Soc.SocClient.Ui.ComSeasonRankItem selfSeasonRankItem; // 0x380
	FairyGUI.GButton btnPersonalHomepage; // 0x388
	WizardGames.Soc.SocClient.Ui.ComNameMedal comNameMedal; // 0x390
	FairyGUI.GLoader nameBg; // 0x398
	WizardGames.Soc.SocClient.Ui.ESeasonRankType curSelectedSeasonRankType; // 0x3a0
	WizardGames.Soc.SocClient.Ui.SeasonRankData seasonRankData; // 0x3a8
	WizardGames.Soc.SocClient.Ui.SeasonRankItemData curSelectRankItemData; // 0x3b0
	System.UInt64 lastSelectItemRoleId; // 0x3b8
	WizardGames.Soc.SocClient.Ui.UiSeasonRankShowModel rankShowModel; // 0x3c0
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.ComSeasonRankItem> tabItemTempDic; // 0x3c8
	System.Boolean get_IsClassify1Friends(); // 0x0642a328
	System.Int32 get_pullDataCount(); // 0x0642a394
	System.Void OnInit(); // 0x0642a47c
	System.Void OnEnable(); // 0x0642b168
	System.Void OnDisable(); // 0x0642b5fc
	System.Void OnDestroy(); // 0x0642b7dc
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0642b888
	System.Void OnSeasonRankCallBack(WizardGames.Soc.SocClient.Ui.ERefreshDataReason refreshDataReason, WizardGames.Soc.SocClient.Ui.SeasonRankData seasonRankData); // 0x0642b908
	System.Void ShowGradeTab(); // 0x0642bc28
	System.Void OnClickTab(WizardGames.Soc.SocClient.Ui.NavBarData navBarData, System.Boolean b); // 0x0642bca0
	System.Void OnPullUpToRefresh(); // 0x0642c1d4
	System.Void RequestSeasonRankInfo(WizardGames.Soc.SocClient.Ui.ERefreshDataReason refreshDataReason); // 0x0642bda4
	System.Void RenderListItem(System.Int32 index, FairyGUI.GObject obj); // 0x0642c3fc
	System.Void OnClickItem(FairyGUI.EventContext context); // 0x0642c5cc
	System.Void RefreshPanelWrap(); // 0x0642bb34
	System.Void GetFriendsUserInfo(); // 0x0642c708
	System.Void RefreshPanel(); // 0x0642c80c
	System.Void OnBtnSelfRank(); // 0x0642c9c4
	System.Void OnBtnPersonalHomepage(); // 0x0642cb90
	System.Void .ctor(); // 0x0642cc3c
	System.Void <GetFriendsUserInfo>b__36_0(WizardGames.Soc.SocClient.Ui.SeasonRankAppearanceData apparanceData); // 0x0642cdf0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSeasonRankShowModel : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComUiPlayerModel playerModel; // 0x10
	WizardGames.Soc.SocClient.Ui.PlayerAppearanceInfo playerAppearanceInfo; // 0x18
	System.Void Init(WizardGames.Soc.SocClient.Ui.UiSeasonRank uiSeasonRank); // 0x0642b2b0
	System.Void Dispose(); // 0x0642b730
	System.Void SetVisiblePlayOnly(System.Boolean isShow); // 0x0642c368
	System.Void RefreshModel(WizardGames.Soc.SocClient.Ui.SeasonRankItemData curSelectRankItemData); // 0x0642b478
	System.Void RefreshAppearance(WizardGames.Soc.SocClient.Ui.SeasonRankItemData curSelectRankItemData); // 0x0642cef0
	System.Void RefreshEquip(WizardGames.Soc.SocClient.Ui.SeasonRankEquipItemData equipItemData); // 0x0642cfe4
	System.Void .ctor(); // 0x0642b100
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSeasonRankShowModel.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiSeasonRankShowModel.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.ComUiPlayerModel> <>9__2_0; // 0x8
	static System.Void .cctor(); // 0x0642d64c
	System.Void .ctor(); // 0x0642d6b0
	System.Void <Init>b__2_0(WizardGames.Soc.SocClient.Ui.ComUiPlayerModel model); // 0x0642d718
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSeasonRankShowModel.<>c__DisplayClass5_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiSeasonRankShowModel <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.SeasonRankItemData curSelectRankItemData; // 0x18
	System.Void .ctor(); // 0x0642ce88
	System.Void <RefreshModel>b__0(WizardGames.Soc.SocClient.Ui.SeasonRankEquipItemData equipItemData); // 0x0642d7b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSeasonPreviewBg : System.Object
{
	static SocLogger <Log>k__BackingField; // 0x0
	System.Int32 defaultBgId; // 0x10
	FairyGUI.GLoader rankBgIcon; // 0x18
	FairyGUI.GLoader rankLevelIcon; // 0x20
	FairyGUI.GGraph fxRoot; // 0x28
	System.Void Init(FairyGUI.GComponent com); // 0x0642d864
	System.Void OnEnable(); // 0x0642db4c
	System.Void OnDisable(); // 0x0642ddd8
	System.Void RefreshRankInfo(); // 0x0642dbdc
	System.Void Hide(); // 0x0642de68
	System.Void .ctor(); // 0x0642dec8
	static System.Void .cctor(); // 0x0642df38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSeasonMedalinterface : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	Config.LobbyRoleInfo lobbyRoleInfo; // 0x338
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.OBJGroupMedal> groupMedals; // 0x340
	WizardGames.Soc.SocClient.Ui.UiSeasonPlayerBadgeInfo playerBadgeInfo; // 0x348
	FairyGUI.GObjectPool medalNodePool; // 0x350
	FairyGUI.GButton lastClickBtn; // 0x358
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.UiSeasonMedalinterfaceBinder binder; // 0x360
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar commonNavBar; // 0x368
	WizardGames.Soc.SocClient.Ui.ComComboBox comSeasonComboBox; // 0x370
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.DetailBadge_MedalListBinder> groupBinderMap; // 0x378
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.DetailBadge_ComItemICONBinder> badgBinderMap; // 0x380
	System.Int32 curSelectStyleId; // 0x388
	System.Int32 currentSelectMedalId; // 0x38c
	System.Int32 selectSeasonId; // 0x390
	System.Boolean get_isSelf(); // 0x0642e00c
	System.Void OnInit(); // 0x0642e0cc
	System.Void RefreshSeasonComBoxItem(); // 0x0642f698
	System.Void ComBoxChange(System.Int32 index); // 0x0642fba8
	System.Void InitTopBar(); // 0x0642f05c
	System.Void InitItemPool(); // 0x0642ee44
	System.Void InitNavBar(); // 0x0642f170
	System.Void OnEnable(); // 0x0642fde8
	System.Void OnDisable(); // 0x06430138
	System.Void OnGroupMedalItemRender(System.Int32 groupIndex, FairyGUI.GObject gObject); // 0x064302ac
	System.Void OnMedalItemRender(WizardGames.Soc.SocClient.Manager.MedalData_Game medalData_Game, FairyGUI.GObject gObject, System.Boolean isLast); // 0x06430820
	System.Void OnMedalItemClick(WizardGames.Soc.SocClient.Manager.MedalData_Game medalData_Game); // 0x064310d4
	System.Void OnRefreshlMaxLevel(System.Int32 styleId); // 0x06431344
	System.Void OnRefreshMedalTask(); // 0x064316b8
	System.Void RefreshMedalList(System.Int32 styleId); // 0x0642fc48
	System.Void RefreshMedalListInternal(System.Int32 styleId); // 0x064313c0
	static System.Void Show(Config.LobbyRoleInfo lobbyRoleInfo, System.Int32 styleConfigId); // 0x06431af8
	System.Void .ctor(); // 0x06431cd0
	static System.Void .cctor(); // 0x06431e60
	System.Void <InitNavBar>b__21_0(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x06431f34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSeasonMedalinterface.<>c__DisplayClass24_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiSeasonMedalinterface <>4__this; // 0x10
	WizardGames.Soc.SocClient.Manager.OBJGroupMedal groupMedalData; // 0x18
	System.Void .ctor(); // 0x064307b8
	FairyGUI.GObject <OnGroupMedalItemRender>b__0(System.String url); // 0x06432028
	System.Void <OnGroupMedalItemRender>b__1(FairyGUI.GObject obj); // 0x064320c0
	System.Void <OnGroupMedalItemRender>b__2(System.Int32 index, FairyGUI.GObject obj); // 0x06432154
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSeasonMedalinterface.<>c__DisplayClass25_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MedalData_Game medalData_Game; // 0x10
	System.Int32 maxLevel; // 0x18
	WizardGames.Soc.SocClient.Ui.UiSeasonMedalinterface <>4__this; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.DetailBadge_ComItemICONBinder itemBinder; // 0x28
	System.Void .ctor(); // 0x0643106c
	System.Void <OnMedalItemRender>b__0(); // 0x06432234
	System.Void <OnMedalItemRender>b__1(); // 0x064322e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSeasonPage : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.SeasonHomepageBinder binder; // 0x10
	System.Int64 updateTimerId; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiSeasonPage.SeaseonBtnListData> btnListDatas; // 0x20
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.SeasonHomepageBinder binder); // 0x0643244c
	System.Void InitButtonListData(); // 0x06432b34
	System.Void StartTimer(); // 0x055049cc
	System.Void CancelTimer(); // 0x064330c8
	System.Void UpdateTimer(System.Int64 timerId, System.Object callbackData, System.Boolean needDelete); // 0x064331cc
	System.Void OnEnable(); // 0x06433308
	System.Void OnDisable(); // 0x06433368
	System.Void OnDestory(); // 0x064333cc
	System.Void RefreshInfo(); // 0x0643342c
	System.Void RefreshRankInfo(); // 0x06433508
	System.Void OnClickSeasonRankResIcon(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x06434bd4
	System.Void RefreshRewardAnim(); // 0x06434ab4
	System.Boolean HaveReward(); // 0x06434c74
	System.Void ClickTalentBtn(); // 0x06434d10
	System.Void ClickRankBtn(); // 0x06434df4
	System.Void ClickSeasonPointTipBtn(); // 0x06434ed4
	System.Void OpenRewardView(); // 0x06434f98
	System.Void OnRenderButtonItem(System.Int32 index, FairyGUI.GObject obj); // 0x06435024
	static System.Void .cctor(); // 0x06435338
	System.Void <.ctor>b__5_0(FairyGUI.EventContext ctx); // 0x0643540c
	System.Void <.ctor>b__5_1(FairyGUI.EventContext ctx); // 0x06435484
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSeasonPage.SeaseonBtnListData : System.Object
{
	System.String iconuri; // 0x10
	System.String btnTxt; // 0x18
	System.Action clickCallBack; // 0x20
	WizardGames.Soc.SocClient.Ui.RedDotType redDotType; // 0x28
	System.Void .ctor(); // 0x06432ebc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSeasonPage.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiSeasonPage.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__5_2; // 0x8
	static FairyGUI.EventCallback1 <>9__5_3; // 0x10
	static System.Void .cctor(); // 0x064354fc
	System.Void .ctor(); // 0x06435560
	System.Void <.ctor>b__5_2(FairyGUI.EventContext ctx); // 0x064355c8
	System.Void <.ctor>b__5_3(FairyGUI.EventContext ctx); // 0x06435668
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSeasonPage.<>c__DisplayClass24_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiSeasonPage.SeaseonBtnListData data; // 0x10
	System.Void .ctor(); // 0x064352d0
	System.Void <OnRenderButtonItem>b__0(FairyGUI.EventContext context); // 0x06435740
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSeasonPlayerBadgeInfo : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.MedalDetailsBinder binder; // 0x10
	WizardGames.Soc.SocClient.Manager.MedalData_Game medalData_Game; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.DetailBadge_ComItemICON_SideShotBinder> allMedalItemIcon; // 0x20
	WizardGames.Soc.SocClient.Manager.EMedalTaskMode medalTaskMode; // 0x28
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.BadgeTaskItem_lobbyBinder> taskItemsBinderMap; // 0x30
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.ComCompletedItemBinder> inGameTaskItemsBinderMap; // 0x38
	WizardGames.Soc.SocClient.Manager.MedalLevelData_Game selectOBJMedal; // 0x40
	System.Boolean received; // 0x48
	System.Boolean canGetReward; // 0x49
	System.Boolean haveOneTaskComplete; // 0x4a
	System.Collections.Generic.List<System.Int64> taskIdList; // 0x50
	System.Boolean isUnlock; // 0x58
	System.Boolean isShowTask; // 0x59
	System.Collections.Generic.List<System.Int32> gameModeIDList; // 0x60
	System.Int32 curSelectIndex; // 0x68
	System.Int32 curSelectGroupIndex; // 0x6c
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.ReleaseElements> rewardList; // 0x70
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.MedalDetailsBinder binder); // 0x0642e580
	System.Void OnClickGetReward(); // 0x064357e4
	System.Void OnRefreshMedalTask(WizardGames.Soc.SocClient.Manager.MedalData_Game medalData_Game); // 0x064319a0
	System.Void OnClickMedalItem(System.Int32 index); // 0x06436624
	System.Void SetData(WizardGames.Soc.SocClient.Manager.MedalData_Game medalData_Game); // 0x06437188
	System.Void RefreshMedalItemInfo(WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.DetailBadge_ComItemICON_SideShotBinder binder, WizardGames.Soc.SocClient.Manager.MedalLevelData_Game data); // 0x06435bc0
	System.Void RefreshMedalDetailDesc(); // 0x06436700
	System.Void RefreshTaskShow(); // 0x0643750c
	System.Void RefreshRewardInfo(); // 0x06435fa8
	System.Void OnRewardItemRender(System.Int32 index, FairyGUI.GObject gObject); // 0x06437798
	System.Void OnClickOutGameItem(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x06437a44
	System.Void CheckTaskComplete(); // 0x06435e40
	System.Void OnBattleTaskItemRender(System.Int32 index, FairyGUI.GObject gObject); // 0x06437bd0
	System.Void ShowMedalInfo(WizardGames.Soc.SocClient.Manager.MedalData_Game medalData_Game); // 0x0643125c
	static System.Void .cctor(); // 0x0643835c
	System.Void <.ctor>b__18_0(); // 0x06438430
	System.Void <.ctor>b__18_1(); // 0x064384a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSeasonPlayerBadgeInfo.<>c__DisplayClass18_0 : System.Object
{
	System.Int32 index; // 0x10
	WizardGames.Soc.SocClient.Ui.UiSeasonPlayerBadgeInfo <>4__this; // 0x18
	System.Void .ctor(); // 0x064b50c0
	System.Void <.ctor>b__2(); // 0x064b5128
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSeasonsystem : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.UiSeasonsystemBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComSeasonPreviewBg comBg; // 0x340
	WizardGames.Soc.SocClient.Ui.UiSeasonPage uiSeasonPage; // 0x348
	System.Void OnInit(); // 0x064b519c
	System.Void InitTopBar(); // 0x064b54d4
	System.Void OnEnable(); // 0x064b55f0
	System.Void OnDisable(); // 0x064b5788
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x064b58a0
	System.Void OnDestroy(); // 0x064b5920
	System.Void RefreshInfo(); // 0x064b5710
	System.Void OnRefreshSeasonTask(); // 0x064b5998
	static System.Void Show(); // 0x064b59fc
	System.Void .ctor(); // 0x064b5ad4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSeasonsystemMedalReward : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.UiSeasonsystemMedalRewardBinder binder; // 0x338
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiSeasonsystemMedalReward.SeasonMadalRewardData> dataList; // 0x340
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.RootBattlemedallistBinder> itemsBinderMap; // 0x348
	System.Void OnInit(); // 0x064b5b60
	System.Void OnEnable(); // 0x064b60e4
	System.Void OnDisable(); // 0x064b6874
	System.Void OnRefreshSeasonTask(); // 0x064b6978
	System.Void RefreshInfo(); // 0x064b61f0
	System.Void OnRenderRatingItem(System.Int32 index, FairyGUI.GObject obj); // 0x064b6b48
	System.Void OnGetReward(WizardGames.Soc.SocClient.Ui.UiSeasonsystemMedalReward.SeasonMadalRewardData data); // 0x064b731c
	System.Void OnRewardListItemRender(WizardGames.Soc.Common.Data.resource.ReleaseElements reward, FairyGUI.GObject obj); // 0x064b74a8
	System.Void OnClickReawrdResIcon(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x064b76e4
	System.Void .ctor(); // 0x064b7870
	static System.Void .cctor(); // 0x064b7948
	System.Void <OnInit>b__4_0(); // 0x064b7a1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSeasonsystemMedalReward.SeasonMadalRewardData : System.Object
{
	WizardGames.Soc.SocClient.SeasonTaskData taskData; // 0x10
	WizardGames.Soc.Common.Data.task.OBJTask taskCfg; // 0x18
	WizardGames.Soc.Common.Data.Play.OBJStyleRankIcon rankIconCfg; // 0x20
	WizardGames.Soc.Common.Data.resource.OBJGroup rewards; // 0x28
	System.Void InitReward(); // 0x064b6a44
	System.Void .ctor(); // 0x064b69dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSeasonsystemMedalReward.<>c__DisplayClass10_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiSeasonsystemMedalReward.SeasonMadalRewardData data; // 0x10
	WizardGames.Soc.SocClient.Ui.UiSeasonsystemMedalReward <>4__this; // 0x18
	System.Void .ctor(); // 0x064b72b4
	System.Void <OnRenderRatingItem>b__0(System.Int32 rewadrIndex, FairyGUI.GObject obj); // 0x064b7a88
	System.Void <OnRenderRatingItem>b__1(); // 0x064b7b54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSeasonsystemPointsExplanation : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.UiSeasonsystemPointsExplanationBinder binder; // 0x338
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.OBJSeasonRank> dataList; // 0x340
	System.Void OnInit(); // 0x064b7bc4
	System.Void OnRenderRatingItem(System.Int32 index, FairyGUI.GObject obj); // 0x064b81d8
	System.Void OnEnable(); // 0x064b857c
	System.Void OnDisable(); // 0x064b87f0
	System.Void .ctor(); // 0x064b8850
	static System.Void .cctor(); // 0x064b88dc
	System.Void <OnInit>b__3_0(); // 0x064b89b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSeasonsystemReward : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.UiSeasonsystemRewardBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x340
	WizardGames.Soc.SocClient.Ui.UiSeasonsystemReward.ESeasonRewardTabType curSelectTab; // 0x348
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiSeasonsystemReward.RankLevelData> dataList; // 0x350
	System.Int32 noneItemCount; // 0x358
	System.Int64 updateTimerId; // 0x360
	UnityEngine.Vector2 itemSize; // 0x368
	System.Int32 progressMaxValue; // 0x370
	System.Int32 leftBarStartValue; // 0x374
	System.Int32 rightBarEndValue; // 0x378
	UnityEngine.Color iconColor; // 0x37c
	UnityEngine.Color iconColor_select; // 0x38c
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.ReleaseElements> rewards; // 0x3a0
	WizardGames.Soc.Common.Data.task.OBJTask seasonRankTask; // 0x3a8
	System.Int32 currentSelectIndex; // 0x3b0
	System.Int32 currentShowIndex; // 0x3b4
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.RankliskBinder> itemBinderDic; // 0x3b8
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.LobbySeasonsystem.RankiconBinder> rewardBinderDic; // 0x3c0
	System.Void OnInit(); // 0x064b8a1c
	System.Void InitTopBar(); // 0x064b9934
	System.Void OnEnable(); // 0x064b9f70
	System.Void OnDisable(); // 0x064ba904
	System.Void OnRefreshSeasonTask(); // 0x064bab18
	System.Void StartTimer(); // 0x055049cc
	System.Void CancelTimer(); // 0x064baa14
	System.Void UpdateTimer(System.Int64 timerId, System.Object callbackData, System.Boolean needDelete); // 0x064bb3b4
	System.Void OnClickTab(System.Int32 index); // 0x064bb4a8
	System.Void InitRankListInfo(); // 0x064ba2b8
	System.Void AddNoneRankItem(); // 0x064bb648
	System.Void OnRenderRankItem(System.Int32 index, FairyGUI.GObject obj); // 0x064bb7e8
	System.Void OnItemClicked(FairyGUI.EventContext context); // 0x064bc21c
	System.Void DoDragllEnd(FairyGUI.EventContext context); // 0x064bc4f0
	System.Void ScrollIndexToMiddle(System.Int32 index, System.Boolean ani); // 0x064ba6f8
	System.Void DoScrollEnd(FairyGUI.EventContext context); // 0x064bd4b0
	System.Void DoSpecialEffect(); // 0x064bc87c
	System.Void RefreshShowRewardInfo(System.Boolean force); // 0x064baca8
	System.Void OnRenderSeasonRewardItem(System.Int32 index, FairyGUI.GObject obj); // 0x064bd700
	System.Void OnClickOutGameItem(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x064bdbdc
	System.Void OnClickReceiveReward(System.Int32 taskId); // 0x064bdd68
	static System.Void Show(WizardGames.Soc.SocClient.Ui.UiSeasonsystemReward.ESeasonRewardTabType tabType); // 0x064bde34
	System.Void .ctor(); // 0x064bdf28
	static System.Void .cctor(); // 0x064be194
	System.Void <OnInit>b__23_0(FairyGUI.EventContext ctx); // 0x064be268
	System.Void <OnInit>b__23_1(FairyGUI.EventContext ctx); // 0x064be2f0
	System.Void <InitTopBar>b__24_0(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x064be378
	System.Void <OnRenderSeasonRewardItem>b__43_0(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x064be44c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiSeasonsystemReward.ESeasonRewardTabType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiSeasonsystemReward.ESeasonRewardTabType None = -1;
	static WizardGames.Soc.SocClient.Ui.UiSeasonsystemReward.ESeasonRewardTabType Rank = 0;
	static WizardGames.Soc.SocClient.Ui.UiSeasonsystemReward.ESeasonRewardTabType Season = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSeasonsystemReward.RankLevelData : System.Object
{
	System.Int32 state; // 0x10
	System.Int32 largeRank; // 0x14
	WizardGames.Soc.Common.Data.Play.OBJSeasonLargeRank rankCfg; // 0x18
	System.Boolean get_isLock(); // 0x064bc158
	System.Void .ctor(); // 0x064bb780
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ESeasonBtnStyle : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ESeasonBtnStyle Common = 0;
	static WizardGames.Soc.SocClient.Ui.ESeasonBtnStyle Lobby = 1;
	static WizardGames.Soc.SocClient.Ui.ESeasonBtnStyle History = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSeasonUiUtility : System.Object
{
	
	static System.Void SetSeasonBennerBtnInfo(WizardGames.Soc.SocClient.Ui.Binder.CommonLobby.ComSeasonBinder binder, WizardGames.Soc.SocClient.Ui.ESeasonBtnStyle style); // 0x064be4d4
	static System.Void OpenSeasons(FairyGUI.EventContext ctx); // 0x064beb90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSecondaryInteractionList : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger Log; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.GameHud_PC.RootInteractiveListBinder rootBinder; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.GameHud_PC.ElemInteractiveListBinder elemInteractiveListNewBinder; // 0x340
	FairyGUI.GList keyTipsList; // 0x348
	FairyGUI.GList interactiveBtnList; // 0x350
	FairyGUI.GList pickList; // 0x358
	FairyGUI.GImage bg; // 0x360
	UnityEngine.Material material; // 0x368
	System.String SHOW_INTERACTIVE; // 0x370
	System.String SHOW_PICKUP; // 0x378
	System.Int32 ITEM_HEIGHT; // 0x380
	System.Single SPECIAL_FACTOR; // 0x384
	System.Collections.Generic.List<System.Int32> expandInteractiveIdList; // 0x388
	System.String curPage; // 0x390
	System.Int64 playListAnimTimeId; // 0x398
	System.Int64 lastQuestGuideId; // 0x3a0
	System.Int32 curInteractiveIndex; // 0x3a8
	WizardGames.Soc.SocClient.Manager.HotKeyAction wheelUpAction; // 0x3b0
	WizardGames.Soc.SocClient.Manager.HotKeyAction wheelDownAction; // 0x3b8
	FairyGUI.GObject selectKeyObj; // 0x3c0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiSecondaryInteractionList.KeyTipsData> keyTipsDatas; // 0x3c8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiSecondaryInteractionList.KeyTipsData> oldKeyTipsDatas; // 0x3d0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiSecondaryInteractionList.KeyTipsData> sortedKeyTipsDatas; // 0x3d8
	static WizardGames.Soc.SocClient.Ui.UiSecondaryInteractionList.KeyTipsData dummyData; // 0x8
	System.Collections.Generic.Dictionary<FairyGUI.GComponent,System.String> hotkeyComs; // 0x3e0
	System.Int32 lastNum; // 0x3e8
	System.Collections.Generic.Dictionary<FairyGUI.GObject,FairyGUI.GObject> uiGObjectPool; // 0x3f0
	System.Collections.Generic.List<WizardGames.Soc.Common.Construction.ItemCostAmount> recoverChildPartCost; // 0x3f8
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.UiHudElemInteractiveList.UiInteractiveBtnCdType> uiInteractiveBtnCdTypeDic; // 0x400
	System.Int64 updateListId; // 0x408
	System.Boolean skipFramePre; // 0x410
	System.Boolean lockFramePre; // 0x411
	System.Int64 quickUseId; // 0x418
	System.Boolean isQuickPicking; // 0x420
	System.Boolean isPlayingBtnMoveAnim; // 0x421
	System.Int64 playMoveTimeId; // 0x428
	System.Void OnInit(); // 0x064bebf0
	System.Void CreateMaterialInstance(); // 0x064bf960
	System.Void SetImageBlurredEnabled(System.Boolean enabled); // 0x064bfac4
	System.Void OnDestroy(); // 0x064bfc48
	System.Void OnLayerVisibleChanged(System.Boolean layerVisible); // 0x064c01b4
	UnityEngine.Rect GetHalfScreenHideArea(); // 0x064c0248
	System.Void OnEnable(); // 0x064c0544
	System.Void OnDisable(); // 0x064c08bc
	System.Void OnInteractiveListChanged(System.Collections.Generic.List<System.Int32> interactiveList, System.String title); // 0x064c0b54
	System.Void CancelTimer(); // 0x064c00ac
	System.Void OnBgCloseClick(); // 0x064c1288
	System.Void OnHideSelf(); // 0x064c12f4
	System.Void PieMenuVisibleChange(); // 0x064c1360
	System.Void OnFastReconnected(); // 0x064c13fc
	FairyGUI.GList GetList(); // 0x064c149c
	System.Void SetShortCutAlpha(System.Single alpha); // 0x064c07dc
	System.Void OnClickButtonFirst(); // 0x064c1660
	System.Boolean TriggerGuide(); // 0x064c1b74
	FairyGUI.GObject GetGuideObjByID(System.Int64 id); // 0x064c21d0
	System.Void InitHotKey(); // 0x064bf748
	System.Void OnEnable_HotKey(); // 0x064c063c
	System.Void OnDisable_HotKey(); // 0x064c0a30
	System.Void HandleHotKeyPressedEvent(WizardGames.Soc.Common.Data.ActionName actionName); // 0x064c2600
	System.Boolean PlayerStateCheck(); // 0x064c2760
	System.Void ClearAllHotKeyComs(); // 0x064c2400
	static System.Boolean IsDummyData(WizardGames.Soc.SocClient.Ui.UiSecondaryInteractionList.KeyTipsData& data); // 0x064c2898
	System.Void OnKeyTipsListRender(System.Int32 index, FairyGUI.GObject item); // 0x064c2914
	System.Void OnSelectHotKey(); // 0x064c2c34
	System.Void SetInteractiveBtnLisItemNum(System.Int32 num); // 0x064c0cf8
	System.Void AdjustInteractiveBtnListSize(System.Collections.Generic.List<System.Int32> expandList); // 0x064c0fcc
	System.Void SetPickListNum(System.Int32 num); // 0x064c3bd8
	System.Void SetSelectKeyPosition(FairyGUI.GList list); // 0x064c377c
	System.Void OnWheelUp(); // 0x064c4234
	System.Void OnWheelDown(); // 0x064c42f8
	System.Void ForceRefreshKeyTipsList(); // 0x064c43d0
	System.Void UpdateAutoOpenDoorHotKey(); // 0x064c45c8
	System.Void UpdateKeyTipsList(); // 0x064c38c0
	System.Void SortKeyTipsData(System.Int32 columnCount); // 0x064c46e0
	System.Void CheckPickAllHotKey(); // 0x064c4e6c
	System.Void CheckQuickUseHotKey(); // 0x064c50ac
	System.Void OnQuickUseHotKey(); // 0x064c5980
	System.Void CheckAutoOpenDoorHotKey(); // 0x064c498c
	System.Void CheckLampAutoOpenHotKey(); // 0x064c56ac
	System.Void OnAutoOpenLampHotKey(); // 0x064c5c7c
	System.Void OnAutoOpenDoorHotKey(); // 0x064c5d20
	System.Void CheckReloadHotKey(); // 0x064c5374
	System.Void OnReloadHotKey(); // 0x064c5dc4
	System.Void InitInteraction(); // 0x064bf424
	System.Collections.Generic.List<System.Int32> GetExpandInteractiveList(); // 0x064c5e68
	System.Void OnRenderInteractiveBtn(System.Int32 index, FairyGUI.GObject obj); // 0x064c5ecc
	System.Void SetInteractiveBtnClickAction(FairyGUI.GButton interactiveBtn, System.Int32 interactiveId, WizardGames.Soc.SocClient.Ui.Binder.GameHud_PC.ComInteractiveBtnBinder binder); // 0x064c8f8c
	System.Void OnClickButton(System.Int32 interactiveId, WizardGames.Soc.SocClient.Ui.Binder.GameHud_PC.ComInteractiveBtnBinder binder); // 0x064c91f0
	System.Void SetStorageGoldCoins(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn, System.String nameStr); // 0x064c886c
	System.Boolean SetVehicleLockBtnStyle(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn); // 0x064c8368
	System.Void SetCdTypeBtnStyle(FairyGUI.GButton interactiveBtn, WizardGames.Soc.Common.Data.system.Interaction data, System.Int32 interactiveId); // 0x064c8e1c
	System.Void SetDriverSeatBtnStyle(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn); // 0x064c65a8
	System.Void SetPassengerSeatBtnStyle(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn); // 0x064c670c
	System.Void SetSwitchVehicleSeatBtnStyle(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn); // 0x064c6870
	System.Void SetPlantSystemWaterBtnStyle(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn); // 0x064c69d4
	System.Void SetOpenBatchUpgradeBtnStyle(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn); // 0x064c6e70
	System.Void SetPermRepairAllBtnStyle(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn); // 0x064c6f78
	System.Void SetHorseFeedBtnStyle(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn, FairyGUI.GTextField textNum, System.String& iconPath, System.String& nameStr); // 0x064c70b8
	System.Void SetDefaultBtnStyle(System.String& nameStr); // 0x064c8b5c
	System.Boolean SetRecoverChildPartBtnStyle(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn); // 0x064c7b1c
	System.Boolean SetStoargeDebrisBtnStyle(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn); // 0x064c7f00
	System.Boolean SetBuildingSkinBtnStyle(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn); // 0x064c87ec
	System.Boolean SetRepaireInteractiveBtnStyle(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn, System.Int32 type, System.Boolean isBuilding); // 0x064c74d0
	System.Void SetInteractiveBtnCostStyle(FairyGUI.GComponent com, FairyGUI.GButton interactiveBtn, System.Collections.Generic.List<WizardGames.Soc.Common.Construction.ItemCostAmount> itemsToTake); // 0x064c9414
	System.Void SetBtnType(FairyGUI.GButton btn, System.Int32 type); // 0x064c7a50
	System.Int64 GetTerrIdByCurRayPart(); // 0x064ca204
	System.Void CDFinishCallback(FairyGUI.GButton btn); // 0x064ca340
	System.Void UpdateBtnCd(System.Int32 interactiveId); // 0x064c9a54
	System.Void OnClickButtonByGuide(System.Int32 id); // 0x064ca3c0
	System.Void OnTouchBegin(); // 0x064ca524
	System.Void OnTouchEnd(); // 0x064ca7d8
	System.Void TryUnlockUpdate(); // 0x064ca588
	System.Void TryResumeLockUpdate(); // 0x064ca83c
	System.Void HandleSelectKeyObj(FairyGUI.GObject item); // 0x064c41c0
	System.Void CheckFullScreenHotKey(); // 0x064c4c2c
	System.Void OnFullScreenPickHotKey(); // 0x064caa2c
	System.Void InitPickUp(); // 0x064bf538
	System.Void SetPickTitleText(); // 0x064c3ff4
	System.Void OnBtnQuickPickClick(); // 0x064caad0
	System.Void TryQuickPick(); // 0x064cab3c
	System.Boolean CheckInventoryFull(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x064cb0a0
	System.Void RenderPickItem(System.Int32 index, FairyGUI.GObject obj); // 0x0550f6d4
	System.Void RegistPickItemEvent(FairyGUI.GButton btn, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, WizardGames.Soc.SocClient.Ui.Binder.GameHud_PC.ComItemBtnBinder binder); // 0x064cbbb4
	System.Void CancelMoveTimer(); // 0x064c1184
	System.Void DoPickItem(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, WizardGames.Soc.SocClient.Ui.Binder.GameHud_PC.ComItemBtnBinder binder); // 0x064c324c
	System.Void PlayBtnMoveAinm(); // 0x064cbf10
	System.Void RegistBtnQuickUseEvent(FairyGUI.GButton btn, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x064cbd0c
	System.Void DoQuickUseItem(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x064c5bc0
	System.Void TryQuickUseItem(); // 0x064cc464
	System.Void OnUpdatePickUpList(); // 0x064cc570
	FairyGUI.GObject CustomPoolGetter(System.String url); // 0x064cc7b4
	System.Void CustomPoolReturnner(FairyGUI.GObject obj); // 0x064cc890
	System.Void ResetItemCom(FairyGUI.GObject obj); // 0x064cc974
	System.Void ResetItemIcon(FairyGUI.GButton btn); // 0x064cca04
	System.Void .ctor(); // 0x064ccb7c
	static System.Void .cctor(); // 0x064cce78
	System.Void <PlayBtnMoveAinm>b__141_0(System.Int64 a, System.Object b, System.Boolean c); // 0x064ccf60
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiSecondaryInteractionList.KeyTipsData : System.ValueType
{
	WizardGames.Soc.Common.Data.ActionName actionName; // 0x10
	System.String title; // 0x18
	FairyGUI.EventCallback0 callback; // 0x20
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSecondaryInteractionList.<>c__DisplayClass138_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiSecondaryInteractionList <>4__this; // 0x10
	WizardGames.Soc.Common.CustomType.BaseItemNode itemNode; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameHud_PC.ComItemBtnBinder binder; // 0x20
	System.Void .ctor(); // 0x064cbe40
	System.Void <RegistPickItemEvent>b__0(); // 0x064ccff4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSecondaryInteractionList.<>c__DisplayClass140_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.BaseItemNode itemNode; // 0x10
	WizardGames.Soc.SocClient.Ui.UiSecondaryInteractionList <>4__this; // 0x18
	System.Void .ctor(); // 0x064cbea8
	System.Void <DoPickItem>b__0(); // 0x064cd064
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSecondaryInteractionList.<>c__DisplayClass142_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiSecondaryInteractionList <>4__this; // 0x10
	WizardGames.Soc.Common.CustomType.BaseItemNode itemNode; // 0x18
	System.Void .ctor(); // 0x064cc3fc
	System.Void <RegistBtnQuickUseEvent>b__0(); // 0x064cd104
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSecondaryInteractionList.<>c__DisplayClass61_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiSecondaryInteractionList <>4__this; // 0x10
	System.Int32 interactiveId; // 0x18
	System.Void .ctor(); // 0x064c31e4
	System.Void <OnSelectHotKey>b__0(); // 0x064cd174
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSecondaryInteractionList.<>c__DisplayClass90_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiSecondaryInteractionList <>4__this; // 0x10
	System.Int32 interactiveId; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.GameHud_PC.ComInteractiveBtnBinder binder; // 0x20
	System.Void .ctor(); // 0x064c9188
	System.Void <SetInteractiveBtnClickAction>b__0(); // 0x064cd1e4
	System.Void <SetInteractiveBtnClickAction>b__1(); // 0x064cd258
	System.Void <SetInteractiveBtnClickAction>b__2(); // 0x064cd2c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSecondaryInteractionList.<>c__DisplayClass91_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiSecondaryInteractionList <>4__this; // 0x10
	System.Int32 interactiveId; // 0x18
	System.Void .ctor(); // 0x064c93ac
	System.Void <OnClickButton>b__0(); // 0x064cd330
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelectCableColor : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GButton useBtn; // 0x338
	FairyGUI.GTextField usedTxt; // 0x340
	FairyGUI.GList cableLst; // 0x348
	FairyGUI.GLoader leftCableImgLoader; // 0x350
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.CableItemInfo> cableInfoLst; // 0x358
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Unity.Electric.WireColour,System.Int32> color2IdxDic; // 0x360
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,FairyGUI.GObject>> cableGODic; // 0x368
	WizardGames.Soc.Common.Unity.Electric.WireColour curSelectColor; // 0x370
	WizardGames.Soc.Common.Unity.Electric.WireColour curUseColor; // 0x374
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x378
	System.Void OnInit(); // 0x064cd3a0
	System.Void OnEnable(); // 0x064cdf38
	System.Void OnDisable(); // 0x064cdfc4
	System.Void OnClickUse(); // 0x064ce02c
	System.Void OnRenderCableItem(System.Int32 index, FairyGUI.GObject obj); // 0x064ce27c
	System.Void OnClickCable(FairyGUI.EventContext context); // 0x064ce694
	System.Void ChangeCableImg(WizardGames.Soc.Common.Unity.Electric.WireColour color); // 0x064ce924
	System.Void InitCableData(); // 0x064cd9b0
	static System.Void CloseWindow(); // 0x064ce208
	static WizardGames.Soc.SocClient.Ui.UiSelectCableColor GetWindow(); // 0x064ce9f8
	System.Void .ctor(); // 0x064ceab8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelectCamp : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	FairyGUI.GButton watchBtn; // 0x338
	FairyGUI.GButton exitBtn; // 0x340
	FairyGUI.GButton confirmBtn; // 0x348
	FairyGUI.GList selectCampLst; // 0x350
	FairyGUI.GGroup maskGroup; // 0x358
	FairyGUI.GTextField loadingTipsTxt; // 0x360
	FairyGUI.GTextField defendNumTxt; // 0x368
	FairyGUI.GTextField attackNumTxt; // 0x370
	FairyGUI.GTextField defendTitleTxt; // 0x378
	FairyGUI.GTextField attackTitleTxt; // 0x380
	FairyGUI.GTextField titleTxt; // 0x388
	FairyGUI.GLoader defendDefaultLoader; // 0x390
	FairyGUI.GLoader attackDefaultLoader; // 0x398
	FairyGUI.GLoader defendSelectLoader; // 0x3a0
	FairyGUI.GLoader attackSelectLoader; // 0x3a8
	System.Int32 tipsDuration; // 0x3b0
	FairyGUI.StageEngine monoTips; // 0x3b8
	FairyGUI.StageEngine monoShowMask; // 0x3c0
	System.Int32 selectedCampIdx; // 0x3c8
	System.Int32 totalDefendNum; // 0x3cc
	System.Int32 totalAttackNum; // 0x3d0
	System.String defendDefaultUrl; // 0x3d8
	System.String attackDefaultUrl; // 0x3e0
	System.String defendSelectUrl; // 0x3e8
	System.String attackSelectUrl; // 0x3f0
	UnityEngine.GameObject blueCardFx; // 0x3f8
	UnityEngine.GameObject redCardFx; // 0x400
	FairyGUI.GGraph blueCardIcon; // 0x408
	FairyGUI.GGraph redCardIcon; // 0x410
	FairyGUI.GoWrapper blueCardFxWrapper; // 0x418
	FairyGUI.GoWrapper redCardFxWrapper; // 0x420
	UnityEngine.Vector3 cardFxScale; // 0x428
	System.Int32 confirmDesc; // 0x434
	System.Int32 cancelDesc; // 0x438
	System.Int32 exitDesc; // 0x43c
	System.Int32 watchBtnDesc; // 0x440
	System.Int32 confirmWatchDesc; // 0x444
	System.Int32 confirmExitDesc; // 0x448
	System.Int32 defendDesc; // 0x44c
	System.Int32 attackDesc; // 0x450
	System.Int32 titleDesc; // 0x454
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> errorDescDic; // 0x458
	System.Collections.Generic.List<System.Int32> loadingTips; // 0x460
	System.Void OnInit(); // 0x064cec48
	System.Void RefreshUI(); // 0x064cf730
	System.Void OnChangeStage(WizardGames.Soc.Common.Data.Play1.StageType stageType); // 0x064cfa18
	System.Void RefreshCampNum(); // 0x064cf918
	System.Void OnClickWatch(); // 0x064cfb60
	System.Void ConfirmWatch(); // 0x064cff18
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x064cff78
	System.Void ConfirmExit(); // 0x064d0338
	System.Void OnClickConfirm(); // 0x064d0450
	System.Void OnSelectCamp(FairyGUI.EventContext context); // 0x064d04b0
	System.Void HideLoadingMask(); // 0x064d05c4
	System.Void OnEnable(); // 0x064d0654
	System.Void OnDisable(); // 0x064d07e0
	System.Void OnDestroy(); // 0x064d0874
	System.Void OnReceiveMemberChangeMsg(System.Int32 errorCode); // 0x064d091c
	System.String GetDesc(System.Int32 key); // 0x064cf978
	static System.Void TryOpenWindow(); // 0x064d0a58
	static System.Void CloseWindow(); // 0x064cfac8
	static WizardGames.Soc.SocClient.Ui.UiSelectCamp GetWindow(); // 0x064d0ab0
	System.Void .ctor(); // 0x064d0b70
	static System.Void .cctor(); // 0x064d0fd0
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.SelectCampMemeberInfo : System.ValueType
{
	System.String name; // 0x10
	System.Boolean isFriend; // 0x18
	System.Boolean isSelf; // 0x19
	System.String roleId; // 0x20
	System.Int32 level; // 0x28
	System.String portrait; // 0x30
	System.Int32 frameId; // 0x38
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelectCampNew : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x338
	FairyGUI.GList campCardList; // 0x340
	FairyGUI.GTextField countdownText; // 0x348
	System.Int64 autoUpdateTimerId; // 0x350
	System.Int64 beginShowTime; // 0x358
	System.Int64 autoCloseTime; // 0x360
	System.Int64 UpdateTeamMemberInterval; // 0x368
	System.Int64 graphEntityId; // 0x370
	System.Int64 roleIdToTeamId; // 0x378
	System.Int64 curUpdateTeamId; // 0x380
	WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.SelectableTeamInfo> teamSelectorData; // 0x388
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SelectCampMemeberInfo>> teamMembers; // 0x390
	System.Collections.Generic.Dictionary<System.String,System.Int64> roleIdMappingTeamId; // 0x398
	static SocLogger logger; // 0x0
	System.Int64 lastTime; // 0x3a0
	static System.Void TryOpenWindow(System.Int64 graphEntityId, WizardGames.Soc.Common.SimpleCustom.MultiLangStringBuilderCfg title, System.Int64 roleIdToTeamId, WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.SelectableTeamInfo> teamSelectorData, System.Int64 autoCloseTime); // 0x064d10a4
	System.Void OnInit(); // 0x064d12bc
	System.Void OnDisable(); // 0x064d159c
	System.Void InitCampInfo(System.Int64 graphEntityId, WizardGames.Soc.Common.SimpleCustom.MultiLangStringBuilderCfg title, System.Int64 roleIdToTeamId, WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.SelectableTeamInfo> teamSelectorData, System.Int64 autoCloseTime); // 0x05512c1c
	System.Void OnUpdate(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x064d233c
	System.Void OnRoleIdToTeamIdChange(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.Int64 a, WizardGames.Soc.Share.Framework.TypeBase b); // 0x064d263c
	System.Void UpdatePanel(); // 0x064d1c54
	System.Void OnUserInfoBack(SimpleJSON.JSONArray jsonArray); // 0x064d27a4
	System.Void CampCardListRenderer(System.Int32 index, FairyGUI.GObject item); // 0x064d2e00
	System.Void memberListRenderer(System.Int32 index, FairyGUI.GObject item); // 0x064d35c0
	System.Void RefreshCampCardList(); // 0x064d26d0
	System.Void RequestJoinTeam(System.String eventName); // 0x064d38a0
	System.Void TeamFullTip(); // 0x064d39f8
	System.Void .ctor(); // 0x064d3a58
	static System.Void .cctor(); // 0x064d3b40
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelectCampNew.<>c__DisplayClass19_0 : System.Object
{
	System.Int64 graphEntityId; // 0x10
	WizardGames.Soc.Common.SimpleCustom.MultiLangStringBuilderCfg title; // 0x18
	System.Int64 roleIdToTeamId; // 0x20
	WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.SelectableTeamInfo> teamSelectorData; // 0x28
	System.Int64 autoCloseTime; // 0x30
	System.Void .ctor(); // 0x064d1254
	System.Void <TryOpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiSelectCampNew win); // 0x064d3c14
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelectCampNew.<>c__DisplayClass28_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiSelectCampNew <>4__this; // 0x10
	WizardGames.Soc.Common.CustomType.SelectableTeamInfo teamData; // 0x18
	System.Void .ctor(); // 0x064d3558
	System.Void <CampCardListRenderer>b__0(); // 0x064d3ca0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelectGift : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static System.Int32 emptyCell; // 0x0
	System.Collections.Generic.List<System.Int32> selectGiftIdLst; // 0x338
	System.Int64 itemUid; // 0x340
	System.Int32 curDropId; // 0x348
	WizardGames.Soc.SocClient.Ui.Binder.GameInventory.UiSelectGiftBinder binder; // 0x350
	WizardGames.Soc.SocClient.Ui.ComBackpack backpack; // 0x358
	FairyGUI.Controller emptyController; // 0x360
	WizardGames.Soc.SocClient.Ui.ComItemIcon curSelectItem; // 0x368
	FairyGUI.GObject bg; // 0x370
	System.Void OnInit(); // 0x064d3d24
	System.Void OnEnable(); // 0x064d44d4
	System.Void OnDisable(); // 0x064d45c0
	System.Void OnDestroy(); // 0x064d4634
	System.Void OnClickConfirm(); // 0x064d46c8
	System.Void Setup(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x064d49a4
	System.Void OnItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x064d4cdc
	static System.Void OpenWindow(System.Action<WizardGames.Soc.SocClient.Ui.UiSelectGift> callBack); // 0x064d50a0
	static System.Void CloseWindow(); // 0x064d48c8
	static WizardGames.Soc.SocClient.Ui.UiSelectGift GetWindow(); // 0x064d5178
	System.Void .ctor(); // 0x064d5238
	static System.Void .cctor(); // 0x064d5320
	System.Void <OnEnable>b__11_0(System.Object obj); // 0x064d536c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelectGift.<>c__DisplayClass16_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiSelectGift <>4__this; // 0x10
	System.Int32 index; // 0x18
	WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg; // 0x20
	System.Void .ctor(); // 0x064d5fa0
	System.Void <OnItemRender>b__0(WizardGames.Soc.SocClient.Ui.ComBaseIcon baseItemIcon); // 0x064d6008
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChoosePlatformlPop : System.Object
{
	FairyGUI.GComponent teamNumberCom; // 0x10
	FairyGUI.GTextField teamNumberTitle; // 0x18
	FairyGUI.GList teamNumberGlist; // 0x20
	FairyGUI.GComponent platformCom; // 0x28
	FairyGUI.GTextField platformTitle; // 0x30
	FairyGUI.GList platformGlist; // 0x38
	FairyGUI.Controller areaStatusCtrl; // 0x40
	FairyGUI.GComponent root; // 0x48
	static System.Collections.Generic.List<System.String> iconList; // 0x0
	System.Collections.Generic.List<System.Int32> plantformList; // 0x50
	System.Int32 curClientPlatform; // 0x58
	System.String curRegion; // 0x60
	System.Int32 curMaxTeamNum; // 0x68
	System.Int32 initMaxTeamNum; // 0x6c
	System.Int32 initClientPlatform; // 0x70
	System.String initRegion; // 0x78
	System.Int32 modeId; // 0x80
	System.Boolean isAppointment; // 0x84
	System.Collections.Generic.List<System.Int32> teamCapacitys; // 0x88
	System.Int64 timerId; // 0x90
	System.Boolean isChangeCurTeamModeInfo; // 0x98
	System.Void .ctor(FairyGUI.GComponent root); // 0x064d6250
	System.Boolean IsRootVisible(); // 0x064d6750
	System.Void RefreshArea(); // 0x064d67f8
	System.Void OnClickChooseMaxTeamNum(FairyGUI.EventContext context); // 0x064d686c
	System.Void OnDisable(); // 0x064d6c70
	System.Void SetTeamCapacitys(System.Int32 modeId); // 0x064d6ef4
	System.Void OnClickPlatform(FairyGUI.EventContext context); // 0x064d7170
	System.Void Refreh(System.Int32 curMaxTeamNum, System.Int32 curClientPlatform, System.Int32 modeId, System.String region, System.Boolean isAppointment, System.Boolean isChangeCurTeamModeInfo); // 0x064d7294
	System.Int32 GetGlistSelectIndex(); // 0x064d6b30
	System.Void OnRenderTeamNumberItem(System.Int32 index, FairyGUI.GObject obj); // 0x064d7524
	System.Void OnRenderPlatformItem(System.Int32 index, FairyGUI.GObject obj); // 0x064d7884
	static System.Void .cctor(); // 0x064d7a14
	System.Void <OnDisable>b__27_0(System.Boolean checkNoChange); // 0x064d7c34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelectPlayMode : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.SocClient.Ui.IJumpToUIWindow
{
	static SocLogger Log; // 0x0
	System.Action<System.Int32> changeModeCallback; // 0x338
	System.Int32 selectModeId; // 0x340
	WizardGames.Soc.SocClient.Ui.Binder.LobbySelectPlayMode.RootSelectPlayModeContentBinder contentBinder; // 0x348
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.OBJGameMode> gameModeList; // 0x350
	System.Collections.Generic.List<System.Int32> curMaps; // 0x358
	System.Int32 curShowMapIndex; // 0x360
	System.Collections.Generic.List<System.Int32> timeRuleList; // 0x368
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.OBJGameModeDesc> descRuleConfigList; // 0x370
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x378
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar topNavBar; // 0x380
	System.Int32 curTopBarId; // 0x388
	WizardGames.Soc.SocClient.Ui.PlayModeNavBar navBar; // 0x390
	FairyGUI.GList.CustomGListPool subTagPool; // 0x398
	System.Boolean enableWheelMapScroll; // 0x3a0
	WizardGames.Soc.SocClient.Manager.HotKeyAction wheelUpAction; // 0x3a8
	WizardGames.Soc.SocClient.Manager.HotKeyAction wheelDownAction; // 0x3b0
	WizardGames.Soc.SocClient.Ui.UiChoosePlatformlPop choosePlatformlPop; // 0x3b8
	System.Int64 timerId; // 0x3c0
	System.Int32 recommendIdx; // 0x3c8
	WizardGames.Soc.SocClient.Ui.ModeSelectInfo modeSelectInfo; // 0x3d0
	FairyGUI.GLoader bgIcon; // 0x3e8
	System.Boolean isJump; // 0x3f0
	System.Int32 get_curLobbyMapIndex(); // 0x064d7df0
	System.Void OnInit(); // 0x064d7fc8
	System.Void OnClickWarSituation(); // 0x064d9728
	System.Void InitTopNavBarData(); // 0x064d90e4
	System.Void InitNavBarData(); // 0x064d94d8
	System.Void OnNavBarScroll(); // 0x064d9fe0
	System.Void OnLobbyTeamSelectModeInfoNotice(System.Int32 modeId, System.Int32 curMaxTeamNum, System.Int32 curClientPlatform, System.String curRegion); // 0x064da5c4
	System.Void SetNoTeamModeSelectInfo(System.Int32 modeId, System.Int32 curMaxTeamNum, System.Int32 curClientPlatform, System.String curRegion); // 0x064da684
	System.Void OnEnable(); // 0x064dac34
	System.Void OnNextGuide(System.Int32 guideId, System.Int32 stepId); // 0x064db4a4
	System.Void OnDisable(); // 0x064db590
	System.Void OnTouchBegin(FairyGUI.EventContext context); // 0x064db980
	System.Void OnClickBtnSelect(); // 0x064dbf38
	System.Void RefreshChoosePlatformlPop(); // 0x064dc2fc
	System.Void OnLevelChanged(); // 0x064dc66c
	System.Void OnWheelUp(); // 0x064dc6d0
	System.Void OnWheelDown(); // 0x064dc898
	System.Void OnClickReserve(); // 0x064dca60
	System.String GetTooltips(); // 0x064dccb4
	System.Boolean ModeVisibleByOpenServiceCard(WizardGames.Soc.Common.Data.Play.OBJGameMode config); // 0x064dcdb8
	System.Boolean BtnServerTouchable(WizardGames.Soc.Common.Data.Play.OBJGameMode config); // 0x064dce98
	System.Void RefreshNavBarData(); // 0x064d98ac
	System.Boolean CheckNewBieLimitCondition(System.Int32 modeId); // 0x064dcf64
	System.Void OnClickTopNavBarItem(WizardGames.Soc.SocClient.Ui.NavBarData navData, System.Boolean btnClicked); // 0x0552af28
	System.Void JumpToUIWindow(WizardGames.Soc.SocClient.Ui.JumpData jumpData); // 0x064deb1c
	System.Void RenderListDescItem(System.Int32 index, FairyGUI.GObject obj); // 0x064ded54
	System.Void RefreshConfirmStatus(); // 0x064deef4
	System.Void ClearTimer(); // 0x064db878
	System.Void PlayListItemAnim(); // 0x064db3a8
	System.Void OnClickItem(WizardGames.Soc.SocClient.Ui.NavBarData navData, System.Boolean btnClicked); // 0x0552af28
	System.Void OnRefreshBattleRoundList(); // 0x055049cc
	System.Void RefreshBattleRoundList(); // 0x055049cc
	System.String RefreshTimeText(System.Int32 modeId); // 0x064dd12c
	System.Void RefreshInfo(); // 0x064dd494
	System.Void RefreshBtnModeChooseInfo(); // 0x064de790
	System.Void SetBtnSelectInfo(System.Int32 teamCapacity, System.Int32 clientPlatform, System.String region); // 0x064da734
	System.Void RefreshWarSituationInfo(); // 0x064db0a0
	System.Void RenderListLobbyPageItem(System.Int32 index, FairyGUI.GObject obj); // 0x064e028c
	System.Void RenderListLobbyMapItem(System.Int32 index, FairyGUI.GObject obj); // 0x064e0360
	System.Void RefreshLobbyMap(WizardGames.Soc.Common.Data.Play.OBJGameMode mode); // 0x064e0628
	System.Void SetModelTagSubList(FairyGUI.GList subList, WizardGames.Soc.Common.Data.Play.OBJGameModeTag tagConfig); // 0x064e0a84
	System.Void RefreshModelTags(WizardGames.Soc.Common.Data.Play.OBJGameMode mode); // 0x064e0d1c
	System.Void SetCtrlType(WizardGames.Soc.Common.Data.Play.OBJGameMode config); // 0x064e1448
	System.Void RefreshModeInfo(); // 0x055049cc
	System.Void OnClickTagTitle(FairyGUI.Controller ctrl, FairyGUI.GList subList, WizardGames.Soc.Common.Data.Play.OBJGameModeTag tagConfig); // 0x064e15f4
	System.Void OnClickMiniMap(); // 0x064e17a4
	System.Void OnClickConfirm(); // 0x064e18fc
	System.Boolean CheckNewBieCompeleted(); // 0x064e1d84
	System.Void OpenLobbyTeamUI(System.Boolean isAppointment); // 0x064e1fe0
	static System.Void Open(System.Int32 modeId, System.Action<System.Int32> callback); // 0x064e22b0
	System.Void .ctor(); // 0x064e2524
	static System.Void .cctor(); // 0x064e26f8
	System.Void <OnClickItem>b__54_0(); // 0x064e27cc
	System.Void <CheckNewBieCompeleted>b__72_0(); // 0x064e2868
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelectPlayMode.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiSelectPlayMode.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.NavBarData,FairyGUI.GComponent> <>9__33_0; // 0x8
	static System.Action<WizardGames.Soc.SocClient.Ui.UiCommonTeamLobby> <>9__42_0; // 0x10
	static System.Comparison<WizardGames.Soc.Common.Data.Play.OBJGameMode> <>9__46_0; // 0x18
	static System.Comparison<WizardGames.Soc.Common.Data.Play.OBJGameMode> <>9__54_3; // 0x20
	static System.Action <>9__73_1; // 0x28
	static System.Void .cctor(); // 0x064e28fc
	System.Void .ctor(); // 0x064e2960
	System.Void <OnEnable>b__33_0(WizardGames.Soc.SocClient.Ui.NavBarData data, FairyGUI.GComponent com); // 0x064e29c8
	System.Void <OnClickReserve>b__42_0(WizardGames.Soc.SocClient.Ui.UiCommonTeamLobby win); // 0x064e2b5c
	System.Int32 <RefreshNavBarData>b__46_0(WizardGames.Soc.Common.Data.Play.OBJGameMode a, WizardGames.Soc.Common.Data.Play.OBJGameMode b); // 0x064e2be4
	System.Int32 <OnClickItem>b__54_3(WizardGames.Soc.Common.Data.Play.OBJGameMode a, WizardGames.Soc.Common.Data.Play.OBJGameMode b); // 0x064e2c78
	System.Void <OpenLobbyTeamUI>b__73_1(); // 0x064e2d0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelectPlayMode.<>c__DisplayClass26_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiSelectPlayMode <>4__this; // 0x10
	FairyGUI.GList pageChangeList; // 0x18
	FairyGUI.GList lobbyMapList; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.LobbySelectPlayMode.ComRightPopBinder rightPopBinder; // 0x28
	System.Action<System.Int32> <>9__5; // 0x30
	System.Void .ctor(); // 0x064d907c
	System.Void <OnInit>b__0(FairyGUI.EventContext ctx); // 0x064e2d70
	System.Void <OnInit>b__1(); // 0x064e2df0
	System.Void <OnInit>b__5(System.Int32 useAmount); // 0x064e3080
	System.Void <OnInit>b__2(); // 0x064e3144
	System.Void <OnInit>b__3(); // 0x064e31b4
	System.Void <OnInit>b__4(); // 0x064e3348
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelectPlayMode.<>c__DisplayClass54_0 : System.Object
{
	System.Int32 tmpSelectModeId; // 0x10
	WizardGames.Soc.SocClient.Ui.UiSelectPlayMode <>4__this; // 0x18
	System.Action<SimpleJSON.JSONNode> <>9__2; // 0x20
	System.Void .ctor(); // 0x064dfcac
	System.Void <OnClickItem>b__1(); // 0x064e34b4
	System.Void <OnClickItem>b__2(SimpleJSON.JSONNode node); // 0x064e3698
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelectPlayMode.<>c__DisplayClass66_0 : System.Object
{
	FairyGUI.Controller ctrlState; // 0x10
	FairyGUI.GList subList; // 0x18
	WizardGames.Soc.Common.Data.Play.OBJGameModeTag tagConfig; // 0x20
	WizardGames.Soc.SocClient.Ui.UiSelectPlayMode <>4__this; // 0x28
	System.Void .ctor(); // 0x064e13e0
	System.Void <RefreshModelTags>b__0(); // 0x064e3f68
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelectPlayMode.<>c__DisplayClass73_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiSelectPlayMode <>4__this; // 0x10
	System.Boolean isAppointment; // 0x18
	System.Void .ctor(); // 0x064e2248
	System.Void <OpenLobbyTeamUI>b__0(); // 0x064e3fdc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelectPlayMode.<>c__DisplayClass74_0 : System.Object
{
	System.Int32 modeId; // 0x10
	System.Action<System.Int32> callback; // 0x18
	System.Void .ctor(); // 0x064e24bc
	System.Void <Open>b__0(WizardGames.Soc.Common.Unity.Ui.LayerComBase layer, WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x064e40a4
	System.Void <Open>b__1(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x064e4190
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSetRF : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GLoader blank; // 0x338
	WizardGames.Soc.SocClient.Ui.UiCounter uiCounter; // 0x340
	System.Int64 itemUid; // 0x348
	System.Void OnInit(); // 0x064e4274
	System.Void OnEnable(); // 0x064e4680
	System.Void OnDisable(); // 0x064e4990
	System.Void OnConfirmKeyPad(System.Int32 num); // 0x064e4a3c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x064e4b20
	System.Void OnCancelKeyPad(FairyGUI.EventContext context); // 0x064e4ba0
	System.Void OnClickBlank(); // 0x064e4c14
	static WizardGames.Soc.SocClient.Ui.UiSetRF OpenWindow(System.Action<WizardGames.Soc.SocClient.Ui.UiSetRF> cb); // 0x064e4cb4
	static System.Void CloseWindow(); // 0x064e4d8c
	static WizardGames.Soc.SocClient.Ui.UiSetRF GetWindow(); // 0x064e4e00
	System.Void .ctor(); // 0x064e4ec0
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ESettingCtrlType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ESettingCtrlType BinarySwitch = 0;
	static WizardGames.Soc.SocClient.Ui.ESettingCtrlType MultiSwitch = 1;
	static WizardGames.Soc.SocClient.Ui.ESettingCtrlType Slider = 2;
	static WizardGames.Soc.SocClient.Ui.ESettingCtrlType SliderWithToggle = 3;
	static WizardGames.Soc.SocClient.Ui.ESettingCtrlType ThreeSwitch = 4;
	static WizardGames.Soc.SocClient.Ui.ESettingCtrlType SpeicalComBtn = 5;
	static WizardGames.Soc.SocClient.Ui.ESettingCtrlType ComboBox = 6;
	static WizardGames.Soc.SocClient.Ui.ESettingCtrlType HrefUrlLink = 7;
	static WizardGames.Soc.SocClient.Ui.ESettingCtrlType FillParam = 8;
	static WizardGames.Soc.SocClient.Ui.ESettingCtrlType TextBtn = 9;
	static WizardGames.Soc.SocClient.Ui.ESettingCtrlType Aim = 10;
	static WizardGames.Soc.SocClient.Ui.ESettingCtrlType ListColor = 11;
	static WizardGames.Soc.SocClient.Ui.ESettingCtrlType ScreenStyle = 12;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingContentBase : System.Object
{
	static SocLogger logger; // 0x0
	FairyGUI.GComponent Node; // 0x10
	FairyGUI.GLoader Loader; // 0x18
	WizardGames.Soc.SocClient.Ui.UiSettingBase winMain; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.ESettingItemGroup> groupKeyList; // 0x28
	WizardGames.Soc.Common.Data.ESettingTab <CurTab>k__BackingField; // 0x30
	System.Boolean isInit; // 0x34
	System.Boolean enable; // 0x35
	System.Action<FairyGUI.GList> UpdateBoundsCallback; // 0x38
	WizardGames.Soc.Common.Data.ESettingTab get_CurTab(); // 0x064e4f84
	System.Void set_CurTab(WizardGames.Soc.Common.Data.ESettingTab value); // 0x064e4fe8
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiSettingBase win); // 0x064e5060
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.UiSettingBase win); // 0x064e51ec
	System.Void OnDestroy(WizardGames.Soc.SocClient.Ui.UiSettingBase win); // 0x064e5384
	System.Void OnEnable(); // 0x064e552c
	System.Void OnDisable(); // 0x064e56d8
	System.Void Fps10Update(); // 0x064e5864
	System.Void Revert(); // 0x064e58c4
	System.Void RevertAllSettings(); // 0x064e5f20
	System.Boolean CanRevert(); // 0x064e5e70
	System.Boolean CanRevertByTab(WizardGames.Soc.Common.Data.ESettingTab tab); // 0x064e65dc
	System.Void RevertSettingByTab(WizardGames.Soc.Common.Data.ESettingTab tab); // 0x064e5fd0
	System.Void BindAllControl(); // 0x064e6bf4
	System.Void RefreshListLayout(FairyGUI.GList list); // 0x064e6ca8
	System.Void GenerateAllControls(FairyGUI.GList list, System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.ESettingItemGroup,System.Collections.Generic.List<System.Int32>> data); // 0x064e7558
	System.Boolean HasItemCanShow(System.Collections.Generic.List<System.Int32> settingItemList); // 0x064e7be8
	System.Void GenerateGroupControls(FairyGUI.GList list, System.Collections.Generic.List<System.Int32> settingItemList); // 0x064e8188
	System.Void GenerateGmGroupControls(FairyGUI.GList list, System.Collections.Generic.List<WizardGames.Soc.SocClient.Setting.GMCommandMeta> settingItemList); // 0x064e8f38
	System.Void SetItemData(FairyGUI.GComponent itemCom, WizardGames.Soc.SocClient.Ui.ESettingCtrlType ctrlType, System.String settingKey); // 0x064e8b90
	System.String GetControlUrlByType(System.Int32 ctrlType); // 0x064e8814
	static System.Void .cctor(); // 0x064e9310
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingContentBase.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiSettingContentBase.<>c <>9; // 0x0
	static System.Action<FairyGUI.GList> <>9__11_0; // 0x8
	static FairyGUI.EventCallback0 <>9__25_0; // 0x10
	static System.Comparison<WizardGames.Soc.Common.Data.ESettingItemGroup> <>9__25_1; // 0x18
	static System.Void .cctor(); // 0x064e93e4
	System.Void .ctor(); // 0x064e9448
	System.Void <.ctor>b__11_0(FairyGUI.GList list); // 0x064e94b0
	System.Void <GenerateAllControls>b__25_0(); // 0x064e9534
	System.Int32 <GenerateAllControls>b__25_1(WizardGames.Soc.Common.Data.ESettingItemGroup a, WizardGames.Soc.Common.Data.ESettingItemGroup b); // 0x064e95a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingContentBasics : WizardGames.Soc.SocClient.Ui.UiSettingContentBase
{
	FairyGUI.GList list; // 0x40
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiSettingBase win); // 0x064e97bc
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.UiSettingBase win); // 0x064e985c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingContentControl : WizardGames.Soc.SocClient.Ui.UiSettingContentBase
{
	FairyGUI.GComponent comBigCard; // 0x40
	FairyGUI.GList listBigCard; // 0x48
	WizardGames.Soc.SocClient.Ui.UiHudEdit hudEdit; // 0x50
	FairyGUI.GLabel titleControl; // 0x58
	System.Int32[] listMode; // 0x60
	System.Boolean isRequestedCloud; // 0x68
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiSettingBase win); // 0x064e9a40
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.UiSettingBase win); // 0x064e9b34
	System.Void RendModeList(FairyGUI.GList modeList); // 0x064ea060
	System.Void EnterCustomPanel(System.Int32 profileIndex, System.Int32 playId); // 0x064ea1d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingContentControl.<>c__DisplayClass10_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiSettingContentControl <>4__this; // 0x10
	System.Int32 playId; // 0x18
	System.Void .ctor(); // 0x064ea384
	System.Void <EnterCustomPanel>b__0(); // 0x064ea3ec
	System.Void <EnterCustomPanel>b__1(); // 0x064ea654
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingContentControl.<>c__DisplayClass8_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiSettingContentControl <>4__this; // 0x10
	System.Int32 i; // 0x18
	FairyGUI.EventCallback1 <>9__0; // 0x20
	System.Void .ctor(); // 0x064e9ff8
	System.Void <OnInit>b__0(FairyGUI.EventContext ctx); // 0x064ea778
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingContentGmCommandNew : WizardGames.Soc.SocClient.Ui.UiSettingContentBase
{
	static SocLogger logger; // 0x0
	FairyGUI.GList listCommandGroup; // 0x40
	FairyGUI.GList listTabLevelOne; // 0x48
	System.Collections.Generic.List<System.String> tabNameList; // 0x50
	System.Collections.Generic.List<System.String> GroupNameList; // 0x58
	System.String curTabName; // 0x60
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiSettingBase win); // 0x064ea800
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.UiSettingBase win); // 0x064ea918
	System.Void OnRenderGroupItem(System.Int32 index, FairyGUI.GObject obj); // 0x064eb308
	System.Void SetTabLevelOne(); // 0x064eae6c
	System.Void TabOnClick(System.String tabName); // 0x064eb1c0
	static System.Void .cctor(); // 0x064eb5e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingContentGmCommandNew.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiSettingContentGmCommandNew.<>c <>9; // 0x0
	static System.Comparison<System.String> <>9__6_0; // 0x8
	static FairyGUI.EventCallback0 <>9__6_1; // 0x10
	static System.Void .cctor(); // 0x064eb6b4
	System.Void .ctor(); // 0x064eb718
	System.Int32 <OnInit>b__6_0(System.String a, System.String b); // 0x064eb780
	System.Void <OnInit>b__6_1(); // 0x064eb8a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingContentGmCommandNew.<>c__DisplayClass8_0 : System.Object
{
	System.String propTypeName; // 0x10
	WizardGames.Soc.SocClient.Ui.UiSettingContentGmCommandNew <>4__this; // 0x18
	System.Void .ctor(); // 0x064eb578
	System.Void <SetTabLevelOne>b__0(); // 0x064eb9d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingContentPickUp : WizardGames.Soc.SocClient.Ui.UiSettingContentBase
{
	
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiSettingBase win); // 0x064eba48
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.UiSettingBase win); // 0x064ebae8
	System.Void BindAllControl(); // 0x064ebc38
	System.Void ReadTableForListPick(FairyGUI.GList listPickType); // 0x064ebd28
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingContentScreen : WizardGames.Soc.SocClient.Ui.UiSettingContentBase
{
	FairyGUI.GList list; // 0x40
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiSettingBase win); // 0x064ec044
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.UiSettingBase win); // 0x064ec0e4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingContentSensitivity : WizardGames.Soc.SocClient.Ui.UiSettingContentBase
{
	FairyGUI.GList list; // 0x40
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiSettingBase win); // 0x064ec358
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.UiSettingBase win); // 0x064ec3f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingContentSound : WizardGames.Soc.SocClient.Ui.UiSettingContentBase
{
	FairyGUI.GList list; // 0x40
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiSettingBase win); // 0x064ec65c
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.UiSettingBase win); // 0x064ec6fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingGmMonster : WizardGames.Soc.SocClient.Ui.UiSettingContentBase
{
	FairyGUI.GList listPropGroup; // 0x40
	FairyGUI.GList listTabLevelOne; // 0x48
	FairyGUI.GTextInput input; // 0x50
	FairyGUI.GButton btnConfirm; // 0x58
	System.Int32 choosedType; // 0x60
	WizardGames.Soc.Common.Data.units.MonsterOtherField choosedMonster; // 0x68
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.Common.Data.units.MonsterOtherField>> monsterType2Monsters; // 0x70
	System.Collections.Generic.IReadOnlyList<WizardGames.Soc.Common.Data.units.MonsterOtherField> Monsters; // 0x78
	System.Boolean isIconClicked; // 0x80
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiSettingBase win); // 0x064ec960
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.UiSettingBase win); // 0x064eca60
	System.Void ReadPropGroup(); // 0x064ed038
	System.Void PropIconRender(System.Int32 index, FairyGUI.GObject item); // 0x064ed8b4
	System.Void OnClickMonster(WizardGames.Soc.Common.Data.units.MonsterOtherField monster, System.Boolean refreshList, System.Boolean needStarAnim); // 0x064ede3c
	System.Void RequestforProps(); // 0x064edf08
	System.Void SummonMonster(System.Int64 templateId, System.Int32 monsterNum); // 0x064edfbc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingGmMonster.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiSettingGmMonster.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__10_0; // 0x8
	static System.Void .cctor(); // 0x064ee20c
	System.Void .ctor(); // 0x064ee270
	System.Void <OnInit>b__10_0(); // 0x064ee2d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingGmMonster.<>c__DisplayClass11_0 : System.Object
{
	System.Int32 key; // 0x10
	WizardGames.Soc.SocClient.Ui.UiSettingGmMonster <>4__this; // 0x18
	System.Void .ctor(); // 0x064ed84c
	System.Void <ReadPropGroup>b__0(); // 0x064ee414
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingGmMonster.<>c__DisplayClass12_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiSettingGmMonster <>4__this; // 0x10
	WizardGames.Soc.Common.Data.units.MonsterOtherField monsterOtherField; // 0x18
	System.Void .ctor(); // 0x064eddd4
	System.Void <PropIconRender>b__0(); // 0x064ee514
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingGmProperty : WizardGames.Soc.SocClient.Ui.UiSettingContentBase
{
	FairyGUI.GList listPropGroup; // 0x40
	FairyGUI.GList listTabLevelOne; // 0x48
	FairyGUI.GTextInput input; // 0x50
	FairyGUI.GButton btnConfirm; // 0x58
	System.Int32 choosedType; // 0x60
	WizardGames.Soc.Common.Data.DataItem.ItemConfig choosedProp; // 0x68
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.ItemConfig>> propType2Props; // 0x70
	System.Collections.Generic.IReadOnlyList<WizardGames.Soc.Common.Data.DataItem.ItemConfig> Props; // 0x78
	System.Boolean isIconClicked; // 0x80
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiSettingBase win); // 0x064ee58c
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.UiSettingBase win); // 0x064ee68c
	System.Void ReadPropGroup(); // 0x064eec58
	System.Void PropIconRender(System.Int32 index, FairyGUI.GObject item); // 0x064ef4dc
	System.Void OnClickProp(WizardGames.Soc.Common.Data.DataItem.ItemConfig comItem, System.Boolean refreshList, System.Boolean needStarAnim); // 0x064ef988
	System.Void RequestforProps(); // 0x064efa54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingGmProperty.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiSettingGmProperty.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__10_0; // 0x8
	static System.Void .cctor(); // 0x064efcc0
	System.Void .ctor(); // 0x064efd24
	System.Void <OnInit>b__10_0(); // 0x064efd8c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingGmProperty.<>c__DisplayClass11_0 : System.Object
{
	System.Int32 key; // 0x10
	WizardGames.Soc.SocClient.Ui.UiSettingGmProperty <>4__this; // 0x18
	System.Void .ctor(); // 0x064ef474
	System.Void <ReadPropGroup>b__0(); // 0x064efec8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingGmProperty.<>c__DisplayClass12_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiSettingGmProperty <>4__this; // 0x10
	WizardGames.Soc.Common.Data.DataItem.ItemConfig targetItem; // 0x18
	System.Void .ctor(); // 0x064ef920
	System.Void <PropIconRender>b__0(); // 0x064effc8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingGmSkin : WizardGames.Soc.SocClient.Ui.UiSettingContentBase
{
	static SocLogger logger; // 0x0
	FairyGUI.GList listPropGroup; // 0x40
	FairyGUI.GList listTabLevelOne; // 0x48
	FairyGUI.GTextInput input; // 0x50
	FairyGUI.GButton btnConfirm; // 0x58
	System.Int32 choosedType; // 0x60
	WizardGames.Soc.Common.Data.DataItem.SkinConfig choosedProp; // 0x68
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.SkinConfig>> propType2Props; // 0x70
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.SkinConfig> Props; // 0x78
	System.Boolean isIconClicked; // 0x80
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiSettingBase win); // 0x064f0040
	System.Void ReadPropGroup(); // 0x064f073c
	System.Void PropIconRender(System.Int32 index, FairyGUI.GObject item); // 0x064f0ef8
	System.Void OnClickProp(WizardGames.Soc.Common.Data.DataItem.SkinConfig comItem, System.Boolean refreshList, System.Boolean needStarAnim); // 0x064f141c
	System.Void RequestForProps(); // 0x064f14e8
	static System.Void .cctor(); // 0x064f1880
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingGmSkin.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiSettingGmSkin.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__10_0; // 0x8
	static System.Void .cctor(); // 0x064f1954
	System.Void .ctor(); // 0x064f19b8
	System.Void <.ctor>b__10_0(); // 0x064f1a20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingGmSkin.<>c__DisplayClass11_0 : System.Object
{
	System.Int32 key; // 0x10
	WizardGames.Soc.SocClient.Ui.UiSettingGmSkin <>4__this; // 0x18
	System.Void .ctor(); // 0x064f0e90
	System.Void <ReadPropGroup>b__0(); // 0x064f1b5c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingGmSkin.<>c__DisplayClass12_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiSettingGmSkin <>4__this; // 0x10
	WizardGames.Soc.Common.Data.DataItem.SkinConfig targetItem; // 0x18
	System.Void .ctor(); // 0x064f13b4
	System.Void <PropIconRender>b__0(); // 0x064f1c5c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingObserver : WizardGames.Soc.SocClient.Ui.UiSettingContentBase
{
	
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiSettingBase win); // 0x064f1cd4
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.UiSettingBase win); // 0x064f1d74
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingAimBase : WizardGames.Soc.SocClient.Ui.ComSettingBase
{
	FairyGUI.GSlider sliderSize; // 0x380
	FairyGUI.GList listColor; // 0x388
	System.Int32 max; // 0x390
	System.Void OnInit(System.String settingKey); // 0x064f1ee0
	System.Void InitSize(); // 0x064f23bc
	System.Void OnSizeChanged(); // 0x064f2ac8
	System.Void SetSlierMinAndMaxValue(System.Int32 maxValue); // 0x064f28cc
	System.Void RefreshSizeSliderValue(System.Int32 value); // 0x064f2970
	System.Void SetSizeValue(System.Boolean syncConfig); // 0x064f2bac
	System.String GetScaleIconUrl(); // 0x064f2d2c
	System.Void InitListColor(); // 0x064f25d4
	System.Void RefreshColorListValue(); // 0x064f2e0c
	System.Void OnColorRenderItem(System.Int32 index, FairyGUI.GObject obj); // 0x064f2f00
	System.Void OnColorItemClick(FairyGUI.EventContext context); // 0x064f3068
	UnityEngine.Color GetCurrentColor(); // 0x064f31c8
	System.Void SetColorValue(System.Int32 colorIndex, System.Boolean syncConfig); // 0x064f32e4
	WizardGames.Soc.SocClient.Setting.SettingAimConfig GetConfig(); // 0x064f2760
	System.Void SyncValue(); // 0x064f34d8
	System.Void .ctor(); // 0x064f35d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingAimMobile : WizardGames.Soc.SocClient.Ui.ComSettingAimBase
{
	FairyGUI.GLoader loaderAim; // 0x398
	FairyGUI.GLabel previewLabel; // 0x3a0
	FairyGUI.GLabel sizeLabel; // 0x3a8
	FairyGUI.GLabel colorLabel; // 0x3b0
	WizardGames.Soc.SocClient.Ui.ComInfoButton previewTips; // 0x3b8
	WizardGames.Soc.SocClient.Ui.ComInfoButton sizeTips; // 0x3c0
	WizardGames.Soc.SocClient.Ui.ComInfoButton colorTips; // 0x3c8
	FairyGUI.GTextField sliderLeftText; // 0x3d0
	FairyGUI.GTextField sliderRightText; // 0x3d8
	System.Void OnInit(System.String settingKey); // 0x064f3744
	System.Void SetSizeValue(System.Boolean syncConfig); // 0x064f3928
	System.Void SetColorValue(System.Int32 colorIndex, System.Boolean syncConfig); // 0x064f3a08
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x064f3ac4
	System.Void InitAllTitleLabel(); // 0x064f37c8
	System.Void SetLabelTitle(FairyGUI.GLabel label, WizardGames.Soc.SocClient.Setting.EAimPart part); // 0x064f41dc
	System.Void SetLabelBtnTip(WizardGames.Soc.SocClient.Ui.ComInfoButton btn, WizardGames.Soc.SocClient.Setting.EAimPart part); // 0x064f43c8
	System.Void .ctor(); // 0x064f4780
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingAimMobile.<>c__DisplayClass15_0 : System.Object
{
	System.String tipContent; // 0x10
	System.Void .ctor(); // 0x064f4718
	System.String <SetLabelBtnTip>b__0(); // 0x064f47e4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingBase : FairyGUI.GButton, WizardGames.Soc.SocClient.Ui.Utils.IToolTips, WizardGames.Soc.SocClient.Setting.IComSettingBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.ComInfoButton btnTips; // 0x318
	FairyGUI.GLabel titleLabel; // 0x320
	FairyGUI.GTextField textTitle; // 0x328
	System.String key; // 0x330
	System.String[] defaultOptions; // 0x338
	System.String defaultValue; // 0x340
	System.Single[] defaultLimitAndDefault; // 0x348
	System.Func<System.String> getTipsFunc; // 0x350
	System.Boolean comEnable; // 0x358
	System.String titleStr; // 0x360
	System.String subTitleStr; // 0x368
	System.String tips; // 0x370
	WizardGames.Soc.SocClient.Setting.SettingController <SettingController>k__BackingField; // 0x378
	WizardGames.Soc.SocClient.Setting.SettingController get_SettingController(); // 0x064f4848
	System.Void set_SettingController(WizardGames.Soc.SocClient.Setting.SettingController value); // 0x064f48ac
	System.Void OnInit(System.String settingKey); // 0x064f1f6c
	System.Void GetListenConfigs(System.Collections.Generic.List<WizardGames.Soc.SocClient.Setting.SettingConfig> configs); // 0x064f508c
	System.Void RegisterSettingControllerEvent(); // 0x064f4e1c
	System.Void ShowTips(FairyGUI.EventContext context); // 0x064f51ac
	System.Void Dispose(); // 0x064f5220
	System.Void OnConfigValueChanged(); // 0x064f533c
	T GetConfig<T>(); // 0x052af1f0
	System.Void RefreshSettingState(WizardGames.Soc.SocClient.Setting.SettingConfig config); // 0x064f53f8
	System.Void SyncValue(); // 0x064f3570
	System.Void SetDefault(System.Int32 ctrlType, System.Int32[] contentText, System.Single[] limitAndDefault); // 0x064f49bc
	System.Boolean get_Enable(); // 0x064f55a4
	System.Void set_Enable(System.Boolean value); // 0x064f5520
	System.Void SetKey(System.String key); // 0x064f492c
	System.String GetBtnTips(); // 0x064f5654
	System.Void set_ShowTipsBtn(System.Boolean value); // 0x064f4d88
	System.Void SetTitle(System.String titleStr); // 0x064f56ec
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x064f3ff0
	System.Void .ctor(); // 0x064f3660
	static System.Void .cctor(); // 0x064f57ac
	System.String <OnInit>b__17_0(); // 0x064f5880
	System.String <OnInit>b__17_1(); // 0x064f58e4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingBinarySwitch : WizardGames.Soc.SocClient.Ui.ComSettingBase
{
	FairyGUI.GButton btn; // 0x380
	FairyGUI.GTextField off; // 0x388
	FairyGUI.GTextField on; // 0x390
	System.Void OnInit(System.String settingKey); // 0x064f5948
	static System.Void OnClick(FairyGUI.GButton btn, WizardGames.Soc.SocClient.Setting.SettingSwitchConfig config); // 0x064f6080
	System.Void SyncValue(); // 0x064f62d8
	System.Void set_SwitchValue(System.Boolean value); // 0x064f5ff8
	System.Void set_SwicthIndex(System.Int32 value); // 0x064f5f6c
	System.Void set_SwitchEnable(System.Boolean value); // 0x064f6480
	System.Void SetOptions(System.String offStr, System.String onStr); // 0x064f5e78
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x064f6510
	System.Void RefreshSettingState(WizardGames.Soc.SocClient.Setting.SettingConfig config); // 0x064f6664
	System.Void .ctor(); // 0x064f68c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingBinarySwitch.<>c__DisplayClass4_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComSettingBinarySwitch <>4__this; // 0x10
	WizardGames.Soc.SocClient.Setting.SettingSwitchConfig config; // 0x18
	System.Void .ctor(); // 0x064f5e10
	System.Void <OnInit>b__0(); // 0x064f6948
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingComboBox : WizardGames.Soc.SocClient.Ui.ComSettingBase
{
	
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingFillParamBtn : WizardGames.Soc.SocClient.Ui.ComSettingBase
{
	FairyGUI.GButton btn; // 0x380
	FairyGUI.GTextInput paramInput; // 0x388
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x064f69bc
	System.Void OnInit(System.String settingKey); // 0x064f6b04
	System.Void OnClick(WizardGames.Soc.SocClient.Setting.SettingFillParamConfig config); // 0x064f6eb8
	System.Void .ctor(); // 0x064f7044
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingFillParamBtn.<>c__DisplayClass3_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComSettingFillParamBtn <>4__this; // 0x10
	WizardGames.Soc.SocClient.Setting.SettingFillParamConfig config; // 0x18
	System.Void .ctor(); // 0x064f7210
	System.Void <OnInit>b__0(); // 0x064f7278
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingFilter : WizardGames.Soc.SocClient.Ui.ComSettingMultiSwitch
{
	
	System.Void .ctor(); // 0x064f72ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingMultiSwitch : WizardGames.Soc.SocClient.Ui.ComSettingBase
{
	FairyGUI.GList switchList; // 0x380
	System.Collections.Generic.List<System.String> titleList; // 0x388
	System.Collections.Generic.List<System.String> iconPathList; // 0x390
	System.Void OnInit(System.String settingKey); // 0x064f7458
	System.Void SyncValue(); // 0x064f81b8
	System.Void RefreshViewState(); // 0x064f7d54
	static System.Void OnClick(WizardGames.Soc.SocClient.Setting.SettingSwitchConfig config, FairyGUI.GList btnList); // 0x064f83a0
	static System.Void ClickAskConfirm(WizardGames.Soc.SocClient.Setting.SettingSwitchConfig config, FairyGUI.GList btnList, System.Int32 selectIndex); // 0x064f8b38
	static System.Void DoClick(WizardGames.Soc.SocClient.Setting.SettingSwitchConfig config, System.Int32 index); // 0x064f8fcc
	System.Void set_SwicthIndex(System.Int32 value); // 0x064f7c88
	System.Void DisableSwitch(System.Int32 index); // 0x064f8228
	System.Void set_SwitchEnable(System.Boolean value); // 0x064f8300
	System.Void SetOptions(WizardGames.Soc.SocClient.Setting.EItemContentType itemContentType); // 0x064f7a3c
	System.Void SetButtonTitle(FairyGUI.GButton item, System.Int32 index); // 0x064f906c
	System.Void SetButtonIcon(FairyGUI.GButton item, System.Int32 index); // 0x064f914c
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x064f9234
	System.Void .ctor(); // 0x064f7350
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingMultiSwitch.<>c__DisplayClass10_0 : System.Object
{
	WizardGames.Soc.SocClient.Setting.SettingSwitchConfig config; // 0x10
	FairyGUI.GList btnList; // 0x18
	System.Int32 targetIndex; // 0x20
	System.Void .ctor(); // 0x064f8ad0
	System.Void <OnClick>b__0(); // 0x064f9304
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingMultiSwitch.<>c__DisplayClass11_0 : System.Object
{
	WizardGames.Soc.SocClient.Setting.SettingSwitchConfig config; // 0x10
	System.Int32 selectIndex; // 0x18
	System.Void .ctor(); // 0x064f8f64
	System.Void <ClickAskConfirm>b__0(); // 0x064f936c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingMultiSwitch.<>c__DisplayClass3_0 : System.Object
{
	WizardGames.Soc.SocClient.Setting.SettingSwitchConfig config; // 0x10
	WizardGames.Soc.SocClient.Ui.ComSettingMultiSwitch <>4__this; // 0x18
	System.Void .ctor(); // 0x064f79d4
	System.Void <OnInit>b__0(); // 0x064f93d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingSliderBase : WizardGames.Soc.SocClient.Ui.ComSettingBase
{
	FairyGUI.GSlider slider; // 0x380
	System.Void SetValue(WizardGames.Soc.SocClient.Setting.SettingSlideBarConfig config); // 0x064f9448
	System.Void ShowValue(WizardGames.Soc.SocClient.Setting.SettingSlideBarConfig config); // 0x064f969c
	System.Void .ctor(); // 0x064f9988
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingSliderBtn : WizardGames.Soc.SocClient.Ui.ComSettingSliderBase
{
	FairyGUI.GButton btnTick; // 0x388
	FairyGUI.Controller ctrlShowBtnTick; // 0x390
	FairyGUI.GButton btnLow; // 0x398
	FairyGUI.GButton btnHigh; // 0x3a0
	FairyGUI.GButton comSlider; // 0x3a8
	System.Double min; // 0x3b0
	System.Double max; // 0x3b8
	System.Double step; // 0x3c0
	System.String originTitleStr; // 0x3c8
	System.Void SetTickSelected(System.Boolean isSelected); // 0x064f9a14
	System.Void SyncValue(); // 0x064f9ac4
	System.Void SetSlierMinAndMaxValue(System.Double min, System.Double max); // 0x064f9dc0
	System.Void SetSliderStep(System.Double step); // 0x064f9e6c
	System.Void SetSliderValue(System.Double value); // 0x064f9c88
	System.Void OnBtnLowClick(); // 0x064f9ee4
	System.Void OnBtnHighClick(); // 0x064fa110
	System.Void OnInit(System.String settingKey); // 0x064fa33c
	System.Void SetTitle(System.String titleStr); // 0x064fae48
	System.Void SetBtnTickVisible(System.Boolean isVisible); // 0x064fad58
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x064faec8
	System.Void .ctor(); // 0x064fb104
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingSliderBtn.<>c__DisplayClass27_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComSettingSliderBtn <>4__this; // 0x10
	WizardGames.Soc.SocClient.Setting.SettingSlideBarConfig config; // 0x18
	System.Void .ctor(); // 0x064facf0
	System.Void <OnInit>b__0(); // 0x064fb1a4
	System.Void <OnInit>b__1(); // 0x064fb27c
	System.Void <OnInit>b__2(); // 0x064fb360
	System.Void <OnInit>b__4(); // 0x064fb444
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingSliderBtn.<>c__DisplayClass27_1 : System.Object
{
	WizardGames.Soc.SocClient.Setting.SettingSwitchConfig extConfig; // 0x10
	WizardGames.Soc.SocClient.Ui.ComSettingSliderBtn.<>c__DisplayClass27_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x064fade0
	System.Void <OnInit>b__3(FairyGUI.EventContext context); // 0x064fb6a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingSliderSwitch : WizardGames.Soc.SocClient.Ui.ComSettingSliderBase
{
	
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingSliderText : WizardGames.Soc.SocClient.Ui.ComSettingSliderBase
{
	FairyGUI.GButton btnTick; // 0x388
	FairyGUI.Controller ctrlShowBtnTick; // 0x390
	FairyGUI.GTextField textLow; // 0x398
	FairyGUI.GTextField textHigh; // 0x3a0
	FairyGUI.GButton comSlider; // 0x3a8
	FairyGUI.GButton btnLow; // 0x3b0
	FairyGUI.GButton btnHigh; // 0x3b8
	System.Double min; // 0x3c0
	System.Double max; // 0x3c8
	System.Double step; // 0x3d0
	System.String originTitleStr; // 0x3d8
	System.Void OnInit(System.String settingKey); // 0x064fb854
	System.Void GetListenConfigs(System.Collections.Generic.List<WizardGames.Soc.SocClient.Setting.SettingConfig> configs); // 0x064fcc20
	System.Void SetTickSelected(System.Boolean selected); // 0x064fca40
	System.Void SetSliderStep(System.Double step); // 0x064fcd64
	System.Void SyncValue(); // 0x064fcddc
	System.Void SetSlierMinAndMaxValue(System.Double min, System.Double max); // 0x064fc85c
	System.Void SetSliderValue(System.Double value); // 0x064fc908
	System.Void HandlePlayerMicVolumeSetting(System.String settingKey); // 0x064fc354
	System.Int32 GetTeammateCountExcludingSelf(); // 0x064fd13c
	System.Void AssociateVolumeWithTeammate(System.Int32 volumeIndex); // 0x064fd534
	System.Void SetupTeammateVolumeControl(System.UInt64 roleId, System.Int32 volumeIndex); // 0x064fda7c
	System.Void SetSettingState(System.Boolean enable); // 0x064fd024
	System.Void SetTitle(System.String titleStr); // 0x064fe054
	System.Void SetBtnTickVisible(System.Boolean visible); // 0x064fcb30
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x064fe0d4
	System.Void .ctor(); // 0x064fe310
	System.Void <AssociateVolumeWithTeammate>b__33_0(Config.LobbyRoleInfo userInfo); // 0x064fe3b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingSliderText.<>c__DisplayClass17_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComSettingSliderText <>4__this; // 0x10
	WizardGames.Soc.SocClient.Setting.SettingSlideBarConfig config; // 0x18
	System.Void .ctor(); // 0x064fc2ec
	System.Void <OnInit>b__0(); // 0x064fe450
	System.Void <OnInit>b__1(); // 0x064fe528
	System.Void <OnInit>b__2(); // 0x064fe78c
	System.Void <OnInit>b__3(); // 0x064fe960
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingSliderText.<>c__DisplayClass17_1 : System.Object
{
	WizardGames.Soc.SocClient.Setting.SettingSwitchConfig extConfig; // 0x10
	WizardGames.Soc.SocClient.Ui.ComSettingSliderText.<>c__DisplayClass17_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x064fcbb8
	System.Void <OnInit>b__4(FairyGUI.EventContext context); // 0x064feb34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingSliderText.<>c__DisplayClass34_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComSettingSliderText <>4__this; // 0x10
	System.UInt64 roleId; // 0x18
	WizardGames.Soc.SocClient.Setting.SettingSlideBarConfig config; // 0x20
	System.Void .ctor(); // 0x064fdfec
	System.Void <SetupTeammateVolumeControl>b__0(); // 0x064fedcc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingSliderUtil : System.Object
{
	
	static System.String GetConfigValueBySliderValue(WizardGames.Soc.SocClient.Setting.SettingSlideBarConfig config, System.Double value); // 0x064f9538
	static System.Void ShowSliderConfigValue(WizardGames.Soc.SocClient.Setting.SettingSlideBarConfig config, FairyGUI.GTextField text); // 0x064f972c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingSpecialItem : FairyGUI.GComponent, WizardGames.Soc.SocClient.Setting.IComSettingBase
{
	FairyGUI.GTextField textTitle; // 0x288
	FairyGUI.GButton btn1; // 0x290
	FairyGUI.GButton btn2; // 0x298
	WizardGames.Soc.SocClient.Setting.SettingController <SettingController>k__BackingField; // 0x2a0
	System.Void OnInit(System.String settingKey, System.String settingKey2); // 0x064ff04c
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x064ff570
	System.Void set_SettingController(WizardGames.Soc.SocClient.Setting.SettingController value); // 0x064ff6c4
	System.Void OnConfigValueChanged(); // 0x064ff744
	System.Void .ctor(); // 0x064ff7a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingSpecialItem.<>c__DisplayClass3_0 : System.Object
{
	WizardGames.Soc.SocClient.Setting.SettingTextBtnConfig config1; // 0x10
	WizardGames.Soc.SocClient.Setting.SettingTextBtnConfig config2; // 0x18
	System.Void .ctor(); // 0x064ff508
	System.Void <OnInit>b__0(FairyGUI.EventContext val); // 0x064ff80c
	System.Void <OnInit>b__1(FairyGUI.EventContext val); // 0x064ff8f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingText : WizardGames.Soc.SocClient.Ui.ComSettingBase
{
	
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x064ff9d4
	System.Void OnInit(System.String settingKey); // 0x064ffa94
	System.Void .ctor(); // 0x064ffd54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingText.<>c__DisplayClass1_0 : System.Object
{
	WizardGames.Soc.SocClient.Setting.SettingTextConfig config; // 0x10
	System.Void .ctor(); // 0x064ffcec
	System.Void <OnInit>b__0(); // 0x064ffde0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingTextBtn : WizardGames.Soc.SocClient.Ui.ComSettingBase
{
	static SocLogger logger; // 0x0
	FairyGUI.GButton btn; // 0x380
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x064fffac
	System.Void OnInit(System.String settingKey); // 0x065000b0
	static System.Void OnClick(FairyGUI.GButton btn, WizardGames.Soc.SocClient.Setting.SettingConfig config); // 0x065004f8
	System.Void .ctor(); // 0x065006fc
	static System.Void .cctor(); // 0x06500788
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingTextBtn.<>c__DisplayClass4_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComSettingTextBtn <>4__this; // 0x10
	WizardGames.Soc.SocClient.Setting.SettingTextBtnConfig config; // 0x18
	System.Void .ctor(); // 0x06500490
	System.Void <OnInit>b__0(); // 0x0650085c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSettingThreeSwitch : WizardGames.Soc.SocClient.Ui.ComSettingMultiSwitch
{
	
	System.Void .ctor(); // 0x065008fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ContentBasicsBottomPanel : System.Object
{
	static SocLogger logger; // 0x0
	FairyGUI.GButton btnQuest; // 0x10
	FairyGUI.GButton btnManual; // 0x18
	FairyGUI.GButton btnBack; // 0x20
	FairyGUI.GButton btnCode; // 0x28
	FairyGUI.GButton btnReset; // 0x30
	FairyGUI.GButton btnAccount; // 0x38
	System.Void OnInit(FairyGUI.GComponent node); // 0x06500960
	System.Void OnBtnQuestClick(); // 0x06500f44
	System.Void OnBtnManualClick(); // 0x06500fa4
	System.Void OnBtnBackClick(); // 0x06501044
	System.Void OnClickCode(FairyGUI.EventContext ctx); // 0x06501608
	System.Void InitUICompents(FairyGUI.GComponent com); // 0x06500b14
	System.Void .ctor(); // 0x065016c4
	static System.Void .cctor(); // 0x0650172c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ContentBasicsBottomPanel.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.ContentBasicsBottomPanel.<>c <>9; // 0x0
	static System.Action <>9__13_2; // 0x8
	static System.Action <>9__13_0; // 0x10
	static System.Action <>9__13_1; // 0x18
	static System.Void .cctor(); // 0x06501800
	System.Void .ctor(); // 0x06501864
	System.Void <OnBtnBackClick>b__13_0(); // 0x065018cc
	System.Void <OnBtnBackClick>b__13_2(); // 0x06501cbc
	System.Void <OnBtnBackClick>b__13_1(); // 0x06501d64
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingBinarySwitchControl : System.Object
{
	
	static System.Void Bind(FairyGUI.GComponent node, WizardGames.Soc.SocClient.Setting.SettingConfig settingConfig); // 0x06501ff4
	static System.Void ConfigOptionsName(FairyGUI.GButton btn, WizardGames.Soc.SocClient.Setting.SettingSwitchConfig config); // 0x0650245c
	static System.Void OnClick(FairyGUI.GButton btn, WizardGames.Soc.SocClient.Setting.SettingSwitchConfig config); // 0x065025d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingBinarySwitchControl.<>c__DisplayClass0_0 : System.Object
{
	FairyGUI.GButton btn; // 0x10
	WizardGames.Soc.SocClient.Setting.SettingSwitchConfig config; // 0x18
	System.Void .ctor(); // 0x065023f4
	System.Void <Bind>b__0(); // 0x065026f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingFillParamBtnControl : System.Object
{
	
	static System.Void Bind(FairyGUI.GComponent node, WizardGames.Soc.SocClient.Setting.SettingConfig settingConfig); // 0x06502754
	static System.Void OnClick(FairyGUI.GButton btn, FairyGUI.GTextInput input, WizardGames.Soc.SocClient.Setting.SettingFillParamConfig config); // 0x06502b68
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingFillParamBtnControl.<>c__DisplayClass0_0 : System.Object
{
	FairyGUI.GButton btn; // 0x10
	FairyGUI.GTextInput input; // 0x18
	WizardGames.Soc.SocClient.Setting.SettingFillParamConfig config; // 0x20
	System.Void .ctor(); // 0x06502b00
	System.Void <Bind>b__0(); // 0x06502c14
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingMultipleSwitchControl : System.Object
{
	static SocLogger logger; // 0x0
	static System.Void Bind(FairyGUI.GComponent node, WizardGames.Soc.SocClient.Setting.SettingConfig settingConfig); // 0x06502c7c
	static System.Void ConfigOptionsName(WizardGames.Soc.SocClient.Setting.SettingSwitchConfig config, FairyGUI.GList btnList); // 0x0650331c
	static System.Void SetOptionsBtnState(WizardGames.Soc.SocClient.Setting.SettingSwitchConfig config, FairyGUI.GList btnList); // 0x06503534
	static System.Void OnClick(WizardGames.Soc.SocClient.Setting.SettingSwitchConfig config, FairyGUI.GList btnList); // 0x0650372c
	static System.Void DoClick(WizardGames.Soc.SocClient.Setting.SettingSwitchConfig config, System.Int32 index); // 0x06503e00
	static System.Void DoRevert(WizardGames.Soc.SocClient.Setting.SettingSwitchConfig config, FairyGUI.GList btnList); // 0x06503d08
	static System.Void .cctor(); // 0x06503ea0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingMultipleSwitchControl.<>c__DisplayClass2_0 : System.Object
{
	WizardGames.Soc.SocClient.Setting.SettingSwitchConfig config; // 0x10
	FairyGUI.GList btnList; // 0x18
	System.Void .ctor(); // 0x065032b4
	System.Void <Bind>b__0(); // 0x06503f74
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingMultipleSwitchControl.<>c__DisplayClass5_0 : System.Object
{
	FairyGUI.GList btnList; // 0x10
	WizardGames.Soc.SocClient.Setting.SettingSwitchConfig config; // 0x18
	System.Int32 index; // 0x20
	System.Void .ctor(); // 0x06503ca0
	System.Void <OnClick>b__0(); // 0x06504004
	System.Void <OnClick>b__1(); // 0x0650420c
	System.Void <OnClick>b__2(); // 0x065042d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingSlideBarControl : System.Object
{
	
	static System.Void Bind(FairyGUI.GComponent node, WizardGames.Soc.SocClient.Setting.SettingConfig settingConfig); // 0x065044a8
	static System.Void SetValue(FairyGUI.GSlider sliderBar, FairyGUI.GTextField textCurValue, WizardGames.Soc.SocClient.Setting.SettingSlideBarConfig config); // 0x06504e98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingSlideBarControl.<>c__DisplayClass0_0 : System.Object
{
	FairyGUI.GSlider sliderBar; // 0x10
	WizardGames.Soc.SocClient.Setting.SettingSlideBarConfig config; // 0x18
	FairyGUI.GTextField textCurValue; // 0x20
	System.Void .ctor(); // 0x06504e30
	System.Void <Bind>b__0(FairyGUI.EventContext ctx); // 0x065051cc
	System.Void <Bind>b__1(FairyGUI.EventContext ctx); // 0x06505324
	System.Void <Bind>b__2(); // 0x0650547c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingTextBtnControl : System.Object
{
	
	static System.Void Bind(FairyGUI.GComponent node, WizardGames.Soc.SocClient.Setting.SettingConfig settingConfig); // 0x065054e4
	static System.Void OnClick(FairyGUI.GButton btn, WizardGames.Soc.SocClient.Setting.SettingTextBtnConfig config); // 0x06505828
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingTextBtnControl.<>c__DisplayClass0_0 : System.Object
{
	FairyGUI.GButton btn; // 0x10
	WizardGames.Soc.SocClient.Setting.SettingTextBtnConfig config; // 0x18
	System.Void .ctor(); // 0x065057c0
	System.Void <Bind>b__0(); // 0x06505a2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDebug : WizardGames.Soc.SocClient.Ui.UiSettingContentBase
{
	WizardGames.Soc.SocClient.Ui.UiDebugCheat contentCheat; // 0x40
	WizardGames.Soc.SocClient.Ui.UiDebugParam contentParam; // 0x48
	FairyGUI.Controller contentCtrl; // 0x50
	FairyGUI.GObject tabCheat; // 0x58
	FairyGUI.GObject tabParam; // 0x60
	FairyGUI.GTextField txtStatus; // 0x68
	WizardGames.Soc.Common.Utility.Counter counter; // 0x70
	System.Text.StringBuilder msgStatus; // 0x78
	FairyGUI.GComponent comBoard; // 0x80
	static System.Boolean IsShowCheat; // 0x0
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiSettingBase win); // 0x06505a90
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.UiSettingBase win); // 0x06505ba8
	System.Void RefreshPages(); // 0x0650665c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDebugCheat : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiDebug winMain; // 0x10
	FairyGUI.GList cheatList; // 0x18
	FairyGUI.GTextInput inputSearch; // 0x20
	FairyGUI.GTextInput inputParam; // 0x28
	FairyGUI.GButton btnConfirmSearch; // 0x30
	FairyGUI.GButton btnCancelSearch; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.MgrDebugCheat.Command> cmdList; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.MgrDebugCheat.Command> cmdFullList; // 0x48
	System.String FilterName; // 0x50
	WizardGames.Soc.SocClient.Manager.MgrDebugCheat mgrDebugCheat; // 0x58
	SocLogger logger; // 0x60
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.UiDebug win); // 0x06506110
	System.Void OnBtnCancelSearch(); // 0x06506b5c
	System.Void OnBtnConfirmSearch(); // 0x06506fa4
	System.Void RefreshCommandList(); // 0x065067a4
	System.Void RefreshUiDebugCheat(System.String param); // 0x06506bd8
	System.Void CheatItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x06507028
	System.Void SetupButtonFeedback(FairyGUI.GButton btn); // 0x06507378
	System.Void PlayClickFlash(FairyGUI.GButton btn, System.Single normalAlpha); // 0x06507744
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDebugCheat.<>c__DisplayClass16_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.MgrDebugCheat.Command cmd; // 0x10
	WizardGames.Soc.SocClient.Ui.UiDebugCheat <>4__this; // 0x18
	System.Void .ctor(); // 0x06507310
	System.Void <CheatItemRenderer>b__0(); // 0x06507904
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDebugCheat.<>c__DisplayClass17_0 : System.Object
{
	FairyGUI.GButton btn; // 0x10
	System.Single normalAlpha; // 0x18
	System.Single normalScaleX; // 0x1c
	System.Single normalScaleY; // 0x20
	WizardGames.Soc.SocClient.Ui.UiDebugCheat <>4__this; // 0x28
	System.Void .ctor(); // 0x065076dc
	System.Void <SetupButtonFeedback>b__0(); // 0x06507b0c
	System.Void <SetupButtonFeedback>b__1(); // 0x06507b8c
	System.Void <SetupButtonFeedback>b__2(FairyGUI.EventContext ctx); // 0x06507c00
	System.Void <SetupButtonFeedback>b__3(FairyGUI.EventContext ctx); // 0x06507c98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDebugCheat.<>c__DisplayClass18_0 : System.Object
{
	FairyGUI.GButton btn; // 0x10
	System.Single normalAlpha; // 0x18
	System.Void .ctor(); // 0x0650789c
	System.Void <PlayClickFlash>b__0(System.Object _); // 0x06507d34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDebugParam : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHudElemRightAttack rightAttack; // 0x10
	FairyGUI.GComboBox cbRightAttack; // 0x18
	System.Void RefreshPage(); // 0x06506708
	System.Boolean SetRightAttack(); // 0x06507e20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSetting : WizardGames.Soc.SocClient.Ui.UiSettingBase
{
	WizardGames.Soc.SocClient.Ui.UiSettingContentBasics contentBasics; // 0x3b0
	WizardGames.Soc.SocClient.Ui.UiSettingContentControl contentControl; // 0x3b8
	WizardGames.Soc.SocClient.Ui.UiSettingContentSound contentSound; // 0x3c0
	WizardGames.Soc.SocClient.Ui.UiSettingContentSensitivity contentSensitivity; // 0x3c8
	WizardGames.Soc.SocClient.Ui.UiSettingContentScreen contentScreen; // 0x3d0
	WizardGames.Soc.SocClient.Ui.UiSettingContentPickUp contentPickUp; // 0x3d8
	FairyGUI.GComponent bottomPanelCom; // 0x3e0
	WizardGames.Soc.Common.Data.ESettingTab curSelectTab; // 0x3e8
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x06507fc8
	System.Int32 TabSort(WizardGames.Soc.Common.Data.ESettingTab a, WizardGames.Soc.Common.Data.ESettingTab b); // 0x06508048
	System.Void OnInit(); // 0x06508254
	System.Void OnRootTouchBeginCapture(FairyGUI.EventContext context); // 0x06508858
	System.Void InitTab(); // 0x065089b0
	System.Void OnFps10Update(System.Single dt); // 0x06509530
	System.Void OnEnable(); // 0x065095a4
	System.Void OnDisable(); // 0x06509750
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x065099f8
	System.Void OnDestroy(); // 0x06509a78
	System.Void OnTabClick(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x06509ce4
	System.Void Revert(); // 0x06509fc8
	System.Void RefreshContentByIndex(System.Int32 index); // 0x0650a070
	WizardGames.Soc.SocClient.Ui.UiSettingContentBase GetSettingContentByTab(WizardGames.Soc.Common.Data.ESettingTab tabIndex); // 0x0650a29c
	System.Void .ctor(); // 0x0650a804
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.NavigationTab : System.Object
{
	System.Int32 NameKey; // 0x10
	System.String Name; // 0x18
	System.String TabControlName; // 0x20
	System.Boolean IsGm; // 0x28
	System.String ComPath; // 0x30
	System.Int32 TadId; // 0x38
	System.Void .ctor(System.Int32 tadId, System.String name, System.String tabControlName, System.Boolean isGm, System.String comPath); // 0x06509440
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSettingBase : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	static SocLogger Logger; // 0x0
	WizardGames.Soc.SocClient.Ui.ComTopBar TopBar; // 0x338
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x340
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.NavBarData> tabDataLst; // 0x348
	WizardGames.Soc.SocClient.Ui.UiSettingGmProperty contentGmProperty; // 0x350
	WizardGames.Soc.SocClient.Ui.UiSettingGmSkin contentGmSkin; // 0x358
	WizardGames.Soc.SocClient.Ui.UiSettingGmMonster contentGmMonster; // 0x360
	WizardGames.Soc.SocClient.Ui.UiSettingContentGmCommandNew contentGmCommand; // 0x368
	WizardGames.Soc.SocClient.Ui.UiDebug contentDebug; // 0x370
	WizardGames.Soc.SocClient.Ui.UiSettingObserver contentObserver; // 0x378
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.NavigationTab> navigationTabs; // 0x380
	FairyGUI.Controller navigationControl; // 0x388
	System.Boolean IsGmOpen; // 0x390
	FairyGUI.GComponent content; // 0x398
	FairyGUI.GTextField textDes; // 0x3a0
	WizardGames.Soc.SocClient.Ui.UiSettingContentBase currentContent; // 0x3a8
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x0650a920
	System.Void OnInit(); // 0x065084a8
	System.Void InitTab(); // 0x065091f8
	System.Void GenerateTab(); // 0x0650a9a0
	System.Void OnTabClick(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x0650adbc
	System.String GetTabComPath(System.Int32 tabIndex); // 0x0650ae38
	FairyGUI.GComponent LoadCom(FairyGUI.GLoader loader, System.Int32 tabIndex); // 0x0650aee0
	FairyGUI.GComponent LoadCom(FairyGUI.GLoader loader, WizardGames.Soc.Common.Data.ESettingTab tab); // 0x06506010
	FairyGUI.GComponent LoadCom(FairyGUI.GLoader loader, WizardGames.Soc.Common.Data.ESettingTab_PC tab); // 0x06505f10
	System.Void OnFps10Update(System.Single dt); // 0x0650b070
	System.Void RefreshGmBtnState(); // 0x065096a0
	System.Void OnEnable(); // 0x0650b104
	System.Void OnDisable(); // 0x0650b200
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0650b36c
	System.Void CloseShowSafeArea(); // 0x06509900
	System.Void RefreshContentByIndex(System.Int32 index); // 0x0650b3ec
	WizardGames.Soc.SocClient.Ui.NavigationTab GetCurrentTab(); // 0x0650b460
	System.Void ShowSettingControl(System.String settingKey); // 0x0650b710
	System.Void HideSettingControl(System.String settingKey); // 0x0650ba30
	FairyGUI.GComponent FindSettingControl(System.String settingKey); // 0x0650b974
	FairyGUI.GComponent FindControlRecursive(FairyGUI.GComponent parent, System.String controlName); // 0x0650bc94
	System.Void .ctor(); // 0x0650a894
	static System.Void .cctor(); // 0x0650bdb0
	System.Void <OnInit>b__18_0(); // 0x0650be84
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiShowSafeArea : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	
	System.Void OnInit(); // 0x0650bf08
	System.Void .ctor(); // 0x0650bfcc
	System.Void <OnInit>b__0_0(); // 0x0650c058
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiShinGuide : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GComponent joystickNode; // 0x338
	FairyGUI.GComponent jumpNode; // 0x340
	FairyGUI.GTextField joystickTipsText; // 0x348
	FairyGUI.GObject joystickTipsBg; // 0x350
	FairyGUI.GObject joystickRoot; // 0x358
	FairyGUI.Transition joystickTrans; // 0x360
	FairyGUI.Controller joystickArrowCtrl; // 0x368
	FairyGUI.GTextField jumpTipsText; // 0x370
	FairyGUI.GObject jumpTipsBg; // 0x378
	FairyGUI.GObject jumpRoot; // 0x380
	FairyGUI.Transition jumpTrans; // 0x388
	FairyGUI.Controller jumpArrowCtrl; // 0x390
	System.Void OnInit(); // 0x0650c0d4
	System.Void OnEnable(); // 0x0650c464
	System.Void OnDisable(); // 0x0650cc48
	System.Void SetTipsState(FairyGUI.GTextField tipsText, FairyGUI.GObject tipsTextBg, FairyGUI.GObject root); // 0x0650ccbc
	System.Void RefreshPos(FairyGUI.GObject guideGObj, FairyGUI.GObject root); // 0x0650d12c
	System.Void OnMissionChanged(); // 0x0650d4e8
	static WizardGames.Soc.SocClient.Ui.UiShinGuide OpenWindow(); // 0x0650d7b4
	static System.Void CloseWindow(); // 0x0650d740
	static WizardGames.Soc.SocClient.Ui.UiShinGuide GetWindow(); // 0x0650d884
	System.Void .ctor(); // 0x0650d944
	System.Void <OnEnable>b__15_0(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x0650d9d0
	System.Void <OnEnable>b__15_1(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x0650e34c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComItemCardLargeActivityBinder : System.Object
{
	FairyGUI.GComponent <BinderRoot>k__BackingField; // 0x10
	FairyGUI.GLoader <ClickMask>k__BackingField; // 0x18
	FairyGUI.GTextField <Name>k__BackingField; // 0x20
	FairyGUI.GLoader <Icon>k__BackingField; // 0x28
	FairyGUI.GLoader <CurrencyIcon>k__BackingField; // 0x30
	FairyGUI.GTextField <CurrencyNum>k__BackingField; // 0x38
	FairyGUI.GTextField <StorageNum>k__BackingField; // 0x40
	FairyGUI.GTextField <Num>k__BackingField; // 0x48
	FairyGUI.GButton <BtnCancel>k__BackingField; // 0x50
	FairyGUI.GButton <BtnAdd>k__BackingField; // 0x58
	FairyGUI.GTextField <Discount>k__BackingField; // 0x60
	FairyGUI.GTextField <OriginCurrencyNum>k__BackingField; // 0x68
	FairyGUI.Controller <CtrlState>k__BackingField; // 0x70
	FairyGUI.Controller <CtrlPressState>k__BackingField; // 0x78
	FairyGUI.Controller <CtrlSoldoutState>k__BackingField; // 0x80
	FairyGUI.Controller <CtrlDiscountState>k__BackingField; // 0x88
	FairyGUI.Controller <CtrlButton>k__BackingField; // 0x90
	FairyGUI.Transition <TransChooseShowAnim>k__BackingField; // 0x98
	FairyGUI.Transition <TransChooseHideAnim>k__BackingField; // 0xa0
	FairyGUI.GTextField get_Name(); // 0x0650e684
	FairyGUI.GLoader get_Icon(); // 0x0650e6e8
	FairyGUI.GLoader get_CurrencyIcon(); // 0x0650e74c
	FairyGUI.GTextField get_CurrencyNum(); // 0x0650e7b0
	FairyGUI.GTextField get_StorageNum(); // 0x0650e814
	FairyGUI.GTextField get_Num(); // 0x0650e878
	FairyGUI.GButton get_BtnCancel(); // 0x0650e8dc
	FairyGUI.GTextField get_Discount(); // 0x0650e940
	FairyGUI.GTextField get_OriginCurrencyNum(); // 0x0650e9a4
	FairyGUI.Controller get_CtrlState(); // 0x0650ea08
	FairyGUI.Controller get_CtrlPressState(); // 0x0650ea6c
	FairyGUI.Controller get_CtrlSoldoutState(); // 0x0650ead0
	FairyGUI.Controller get_CtrlDiscountState(); // 0x0650eb34
	System.Void .ctor(FairyGUI.GComponent root); // 0x0650eb98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComItemCardLarge_Activity : WizardGames.Soc.SocClient.Ui.ComItemCardBase, WizardGames.Soc.SocClient.Ui.IComBinderDestroy
{
	System.Action OnClickBtnCancel; // 0x2c8
	WizardGames.Soc.SocClient.Ui.ComItemCardLargeActivityBinder binder; // 0x2d0
	FairyGUI.GTextField get_Num(); // 0x0650f058
	System.Void .ctor(FairyGUI.GComponent node); // 0x0650f0fc
	System.Void Dispose(); // 0x0650f714
	System.Void SetName(System.String name); // 0x0650f7ac
	System.Void SetNumVisible(System.Boolean visible); // 0x0650f854
	System.Void SetStatus(WizardGames.Soc.SocClient.Ui.EComItemLargeState status); // 0x0650f908
	System.Void SetCurrencyNum(System.Int32 num, System.Boolean isStack); // 0x0650f9dc
	System.Void SetOriginCurrencyNum(System.Int32 num, System.Boolean isStack); // 0x0650fbf8
	System.Void SetCurrencyIcon(System.String iconPath); // 0x0650fe68
	System.Void SetStorageInfo(System.String storageInfo); // 0x0650ff3c
	System.Void SetSoldoutState(System.Boolean isSoldout); // 0x06510038
	System.Void SetCancelVisible(System.Boolean visible); // 0x0650f618
	System.Void SetDiscount(System.String discount); // 0x0651013c
	System.Void SetDiscountState(System.Int32 stateIndex); // 0x06510238
	System.Void SetDiscountInfo(System.UInt32 price, System.UInt32 originPrice, System.Single talentDiscount); // 0x0651030c
	System.Void RegisterEvents(); // 0x0650f340
	System.Void OnClickBtnCancelHandler(FairyGUI.EventContext context); // 0x0651061c
	System.Void OnDestroy(); // 0x065106b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ClientShopItemData : System.Object
{
	System.Int32 ShopId; // 0x10
	System.Int32 CanBuyCount; // 0x14
	System.UInt32 Price; // 0x18
	System.UInt32 NoTalentPrice; // 0x1c
	System.Int64 TemplateId; // 0x20
	System.Single TalentDiscount; // 0x28
	System.Void .ctor(System.Int32 shopId, System.Int32 canBuyCount, System.UInt32 noTalentPrice, System.Int64 templateId, System.Single talentDiscount); // 0x06510740
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EShopType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EShopType NpcShop = 1;
	static WizardGames.Soc.SocClient.Ui.EShopType PlayerShop = 2;
	static WizardGames.Soc.SocClient.Ui.EShopType HorseShop = 3;
	static WizardGames.Soc.SocClient.Ui.EShopType VehicleShop = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiShop : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiStopLooting
{
	System.Int32 currentInputNum; // 0x338
	System.Single lastClickTime; // 0x33c
	System.Single clickInterval; // 0x340
	System.Int64 timerId; // 0x348
	WizardGames.Soc.SocClient.Ui.EShopType ShopType; // 0x350
	System.Int64 ShopTemplateId; // 0x358
	System.Int32 saleItemShopId; // 0x360
	System.String shopName; // 0x368
	WizardGames.Soc.Common.Component.IClientShopBase clientShop; // 0x370
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.ClientShopItemData> shopDataDict; // 0x378
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> tabType2ItemNum; // 0x380
	System.Collections.Generic.Dictionary<System.Int32,System.String> itemType2TabName; // 0x388
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> tabIndex2Type; // 0x390
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>> tabType2Items; // 0x398
	System.Int32 curSelectedTabIndex; // 0x3a0
	System.Int32 curSelectedItemIndex; // 0x3a4
	System.Int32 curSelectedShopItemID; // 0x3a8
	System.Int32 shopItemID; // 0x3ac
	System.Int32 buyItemNum; // 0x3b0
	WizardGames.Soc.Common.CustomType.StackableItemNode buyItem; // 0x3b8
	WizardGames.Soc.SocClient.Ui.MsgBoxInfo msgBoxInfo; // 0x3c0
	System.Int32 successBuyTip; // 0x3c8
	System.Int32 failBuyTip; // 0x3cc
	System.Int32 inventotyFullTip; // 0x3d0
	System.Int32 itemInsufficienTip; // 0x3d4
	System.Int32 currencyInsufficienTip; // 0x3d8
	WizardGames.Soc.Common.Data.tips.CommonTip buyConfirmBtnContext; // 0x3e0
	WizardGames.Soc.Common.Data.tips.CommonTip buyCancelBtnContext; // 0x3e8
	System.Int32 buyMiniCopterMaxLimitTip; // 0x3f0
	System.Int32 buyBoatMaxLimitTip; // 0x3f4
	System.Int32 buyHorseMaxLimitTip; // 0x3f8
	FairyGUI.GComponent rootNode; // 0x400
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x408
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x410
	FairyGUI.GList itemGList; // 0x418
	FairyGUI.GTextField showItemNameText; // 0x420
	FairyGUI.GTextField showItemNumText; // 0x428
	WizardGames.Soc.SocClient.Ui.ComItemIcon showItemIcon; // 0x430
	FairyGUI.GLoader horseIconLoader; // 0x438
	FairyGUI.GTextField showItemSaleNumText; // 0x440
	FairyGUI.GTextField showItemDescText; // 0x448
	WizardGames.Soc.SocClient.Ui.ComStepper comStepper; // 0x450
	FairyGUI.GButton openInventoryBtn; // 0x458
	FairyGUI.GButton btnDetail; // 0x460
	FairyGUI.Controller showInventoryFullCtrl; // 0x468
	WizardGames.Soc.SocClient.Ui.ComPriceBtnNew comPriceBtn; // 0x470
	FairyGUI.Transition showUIAnim; // 0x478
	FairyGUI.Transition WatingShowAnim; // 0x480
	FairyGUI.Transition WatingLoopAnim; // 0x488
	FairyGUI.Transition WatingHideAnim; // 0x490
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,FairyGUI.GObject>> cacheSubGObjectDic; // 0x498
	FairyGUI.Controller shopTypeCtrl; // 0x4a0
	FairyGUI.GGraph tipsTouchArea; // 0x4a8
	FairyGUI.GButton tipsBtn; // 0x4b0
	FairyGUI.Controller storyLimit; // 0x4b8
	FairyGUI.GTextField stageNum; // 0x4c0
	FairyGUI.GTextField stageText; // 0x4c8
	System.Void OnInit(); // 0x0651084c
	System.Void SetData(WizardGames.Soc.Common.Component.IClientShopBase clientShopBase); // 0x065108b4
	System.Void InitTranstion(); // 0x065130d4
	System.Void InitData(); // 0x06510aa0
	System.Void LoadingShopData(); // 0x06513438
	System.Void InitTabBarAndTopBarUI(); // 0x0651157c
	System.Void InitItemGridUI(); // 0x06511bf0
	System.Void InitItemDetailUI(); // 0x06511e84
	System.Void RegisterUIEvent(); // 0x06513214
	System.Void OnShopItemBuyFinish(System.Int32 ret, System.Boolean isVehicle); // 0x06513a3c
	System.Void UpdateAllUI(); // 0x06514c38
	System.Void PlayWaitingAnim(); // 0x06514cac
	System.Void OnWatingShowAnimComplete(); // 0x06514e78
	System.Void PlayStopWaitingAnim(); // 0x065142d4
	System.Void RendererItemUI(System.Int32 index, FairyGUI.GObject item); // 0x06514ee8
	System.Void OnClickTab(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x06515634
	System.Void OnClickItem(FairyGUI.EventContext context); // 0x06515720
	System.Void SetItemShopID(System.Int32 index); // 0x06513944
	System.Void OnClickBuyBtn(FairyGUI.EventContext context); // 0x06515930
	System.Void OnEnable(); // 0x0651639c
	System.Void OnDisable(); // 0x06516404
	System.Void OnClickBuyMsgOkBtn(); // 0x0651646c
	System.Void OnClickOpenDetail(); // 0x065164d0
	System.Void HandleBuyRequest(); // 0x06516128
	System.Void ClearTimer(); // 0x065141c8
	System.Void OnClickOpenInventoryBtn(FairyGUI.EventContext context); // 0x065166b8
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06516730
	System.Void UpdateItemGridUI(); // 0x06511d98
	System.Void UpdateItemDetailUI(); // 0x0651275c
	System.Void UpdateBuySliderUI(WizardGames.Soc.SocClient.Ui.ClientShopItemData collectionData, WizardGames.Soc.Common.Data.Item.ShopList shopConfig); // 0x06514b18
	System.Void UpdateItemStorageUI(WizardGames.Soc.Common.Data.Item.ShopList shopConfig, WizardGames.Soc.SocClient.Ui.ClientShopItemData collectionData); // 0x06514928
	System.Void UpdateShopItemSaleCurrencyUI(WizardGames.Soc.Common.Data.Item.ShopList shopConfig); // 0x065167dc
	System.Void UpdateOpenInventoryBtnUI(); // 0x06516850
	System.Void UpdateBuyBtnUI(); // 0x06514368
	System.Void OnFastReconnected(); // 0x06516a54
	System.Void OnDestroy(); // 0x06516b28
	System.Void StopAnim(FairyGUI.Transition anim); // 0x06514d98
	static System.Void Open(WizardGames.Soc.Common.Component.ShopComponent shopComponent); // 0x06516c54
	static System.Void Open(WizardGames.Soc.Common.Component.VehicleShopComponent vehicleShopComponent); // 0x06516ec4
	static System.Void Open(WizardGames.Soc.Common.Component.HorseStableComponent horseShopComponent); // 0x06517134
	static System.Void Close(); // 0x065173a4
	System.Void StopLooting(); // 0x0651749c
	System.Void .ctor(); // 0x06517508
	System.Void <InitItemDetailUI>b__64_0(System.Int32 value); // 0x0651780c
	System.Void <InitItemDetailUI>b__64_1(FairyGUI.EventContext ctx); // 0x06517890
	System.Void <InitItemDetailUI>b__64_2(FairyGUI.EventContext ctx); // 0x0651790c
	System.Void <RegisterUIEvent>b__65_0(); // 0x06517984
	System.Void <RegisterUIEvent>b__65_1(); // 0x06517a9c
	System.Void <HandleBuyRequest>b__80_0(System.Int64 _, System.Object _, System.Boolean _); // 0x06517b00
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiShop.<>c__DisplayClass85_0 : System.Object
{
	WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg; // 0x10
	System.Void .ctor(); // 0x06517ee0
	System.Void <UpdateItemDetailUI>b__0(FairyGUI.EventContext context); // 0x06517f48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiShop.<>c__DisplayClass85_1 : System.Object
{
	FairyGUI.EventCallback1 tipsClickFunc; // 0x10
	System.Void .ctor(); // 0x0651815c
	System.Void <UpdateItemDetailUI>b__1(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x065181c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiShopActivity : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiStopLooting
{
	static System.Int64 NPCTemplateId; // 0x0
	System.Int32 currentInputNum; // 0x338
	System.Single lastClickTime; // 0x33c
	System.Single clickInterval; // 0x340
	System.Int64 timerId; // 0x348
	WizardGames.Soc.SocClient.Ui.EShopType ShopType; // 0x350
	System.Int64 ShopTemplateId; // 0x358
	System.Int32 saleItemShopId; // 0x360
	System.String shopName; // 0x368
	WizardGames.Soc.Common.Component.IClientShopBase clientShop; // 0x370
	WizardGames.Soc.Common.Component.ActivityStateComponent ActivityStateComponent; // 0x378
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.ClientShopItemData> shopDataDict; // 0x380
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> tabType2ItemNum; // 0x388
	System.Collections.Generic.Dictionary<System.Int32,System.String> itemType2TabName; // 0x390
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> tabIndex2Type; // 0x398
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>> tabType2Items; // 0x3a0
	System.Int32 curSelectedTabIndex; // 0x3a8
	System.Int32 curSelectedItemIndex; // 0x3ac
	System.Int32 curSelectedShopItemID; // 0x3b0
	System.Int32 shopItemID; // 0x3b4
	System.Int32 buyItemNum; // 0x3b8
	WizardGames.Soc.Common.CustomType.StackableItemNode buyItem; // 0x3c0
	WizardGames.Soc.SocClient.Ui.MsgBoxInfo msgBoxInfo; // 0x3c8
	System.Int32 successBuyTip; // 0x3d0
	System.Int32 failBuyTip; // 0x3d4
	System.Int32 inventotyFullTip; // 0x3d8
	System.Int32 itemInsufficienTip; // 0x3dc
	System.Int32 currencyInsufficienTip; // 0x3e0
	WizardGames.Soc.Common.Data.tips.CommonTip buyConfirmBtnContext; // 0x3e8
	WizardGames.Soc.Common.Data.tips.CommonTip buyCancelBtnContext; // 0x3f0
	System.Int32 buyMiniCopterMaxLimitTip; // 0x3f8
	System.Int32 buyBoatMaxLimitTip; // 0x3fc
	System.Int32 buyHorseMaxLimitTip; // 0x400
	FairyGUI.GComponent rootNode; // 0x408
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x410
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x418
	FairyGUI.GList itemGList; // 0x420
	FairyGUI.GTextField showItemNameText; // 0x428
	FairyGUI.GTextField showItemNumText; // 0x430
	WizardGames.Soc.SocClient.Ui.ComItemIcon showItemIcon; // 0x438
	FairyGUI.GLoader horseIconLoader; // 0x440
	FairyGUI.GTextField showItemSaleNumText; // 0x448
	FairyGUI.GTextField showItemDescText; // 0x450
	WizardGames.Soc.SocClient.Ui.ComStepper comStepper; // 0x458
	FairyGUI.GButton openInventoryBtn; // 0x460
	FairyGUI.GButton btnDetail; // 0x468
	FairyGUI.Controller showInventoryFullCtrl; // 0x470
	WizardGames.Soc.SocClient.Ui.ComPriceBtnNew comPriceBtn; // 0x478
	FairyGUI.Transition showUIAnim; // 0x480
	FairyGUI.Transition WatingShowAnim; // 0x488
	FairyGUI.Transition WatingLoopAnim; // 0x490
	FairyGUI.Transition WatingHideAnim; // 0x498
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,FairyGUI.GObject>> cacheSubGObjectDic; // 0x4a0
	FairyGUI.Controller shopTypeCtrl; // 0x4a8
	FairyGUI.GGraph tipsTouchArea; // 0x4b0
	FairyGUI.GButton tipsBtn; // 0x4b8
	FairyGUI.Controller countDownCtrl; // 0x4c0
	FairyGUI.GTextField countDownText; // 0x4c8
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.ComItemCardLarge_Activity> itemBinders; // 0x4d0
	System.Int64 openTimeId; // 0x4d8
	System.Int64 closeTimeId; // 0x4e0
	System.Void OnInit(); // 0x06518268
	System.Void SetData(WizardGames.Soc.Common.Component.IClientShopBase clientShopBase); // 0x065182d0
	System.Void InitTranstion(); // 0x0651aa78
	System.Void InitData(); // 0x065184bc
	System.Void LoadingShopData(); // 0x0651addc
	System.Void InitTabBarAndTopBarUI(); // 0x06518f98
	System.Void InitItemGridUI(); // 0x065195dc
	System.Void InitItemDetailUI(); // 0x06519870
	System.Void RegisterUIEvent(); // 0x0651abb8
	System.Void OnShopItemBuyFinish(System.Int32 ret, System.Boolean isVehicle); // 0x0651b3e4
	System.Void UpdateAllUI(); // 0x0651c4bc
	System.Void PlayWaitingAnim(); // 0x0651c530
	System.Void OnWatingShowAnimComplete(); // 0x0651c6fc
	System.Void PlayStopWaitingAnim(); // 0x0651bd1c
	System.Void RendererItemUI(System.Int32 index, FairyGUI.GObject item); // 0x0651c76c
	System.Void OnClickTab(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x0651ce10
	System.Void OnClickItem(FairyGUI.EventContext context); // 0x0651cefc
	System.Void SetItemShopID(System.Int32 index); // 0x0651b2ec
	System.Void OnClickBuyBtn(FairyGUI.EventContext context); // 0x0651d10c
	System.Void OnEnable(); // 0x0651dad0
	System.Void OnDisable(); // 0x0651db38
	System.Void OnClickBuyMsgOkBtn(); // 0x0651dba0
	System.Void OnClickOpenDetail(); // 0x0651dc04
	System.Void HandleBuyRequest(); // 0x0651d85c
	System.Void ClearTimer(); // 0x0651bc10
	System.Void OnClickOpenInventoryBtn(FairyGUI.EventContext context); // 0x0651ddec
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0651de64
	System.Void UpdateItemGridUI(); // 0x06519784
	System.Void UpdateItemDetailUI(); // 0x0651a108
	System.Void UpdateBuySliderUI(WizardGames.Soc.SocClient.Ui.ClientShopItemData collectionData, WizardGames.Soc.Common.Data.Item.ShopList shopConfig); // 0x0651c39c
	System.Void UpdateItemStorageUI(WizardGames.Soc.Common.Data.Item.ShopList shopConfig, WizardGames.Soc.SocClient.Ui.ClientShopItemData collectionData); // 0x0651c1ac
	System.Void UpdateShopItemSaleCurrencyUI(WizardGames.Soc.Common.Data.Item.ShopList shopConfig); // 0x0651df4c
	System.Void UpdateOpenInventoryBtnUI(); // 0x0651e028
	System.Void UpdateBuyBtnUI(); // 0x0651bdb0
	System.Boolean CheckActivityIsOpen(); // 0x0651e22c
	System.Void SetShopCloseText(System.Boolean isOpen); // 0x0651e2a4
	System.Void SetShopOpenState(System.Boolean isOpen); // 0x0651e358
	System.Void SetActivityCloseTimeWheel(); // 0x055049cc
	System.Void SetActivityOpenTimeWheel(); // 0x0651e9c8
	System.TimeSpan GetActivityOpenTime(); // 0x0651ee30
	System.Void AddActivityOpenTime(); // 0x0651eaf0
	System.Void ResetTimer(); // 0x0651f164
	System.Double GetMillisecondsDifference(System.TimeSpan ts1, System.TimeSpan ts2); // 0x0651f04c
	System.Double GetCyclicDifference(System.TimeSpan ts1, System.TimeSpan ts2); // 0x0651f2f0
	System.Void OnFastReconnected(); // 0x0651f3fc
	System.Void OnDestroy(); // 0x0651f4d0
	System.Void StopAnim(FairyGUI.Transition anim); // 0x0651c61c
	static System.Void Open(WizardGames.Soc.Common.Component.ShopComponent shopComponent, WizardGames.Soc.Common.Component.ActivityStateComponent activityStateComponent); // 0x0651f628
	static System.Void Open(WizardGames.Soc.Common.Component.VehicleShopComponent vehicleShopComponent, WizardGames.Soc.Common.Component.ActivityStateComponent activityStateComponent); // 0x0651f8b0
	static System.Void Open(WizardGames.Soc.Common.Component.HorseStableComponent horseShopComponent, WizardGames.Soc.Common.Component.ActivityStateComponent activityStateComponent); // 0x0651fb38
	System.Void StopLooting(); // 0x0651fdc0
	System.Void .ctor(); // 0x0651fe2c
	static System.Void .cctor(); // 0x06520220
	System.Void <InitItemDetailUI>b__68_0(System.Int32 value); // 0x0652026c
	System.Void <InitItemDetailUI>b__68_1(FairyGUI.EventContext ctx); // 0x065202f0
	System.Void <InitItemDetailUI>b__68_2(FairyGUI.EventContext ctx); // 0x0652036c
	System.Void <RegisterUIEvent>b__69_0(); // 0x065203e4
	System.Void <RegisterUIEvent>b__69_1(); // 0x065204fc
	System.Void <HandleBuyRequest>b__84_0(System.Int64 _, System.Object _, System.Boolean _); // 0x06520560
	System.Void <SetActivityCloseTimeWheel>b__98_0(System.Int64 a, System.Object b, System.Boolean c); // 0x06520644
	System.Void <AddActivityOpenTime>b__101_0(System.Int64 a, System.Object b, System.Boolean c); // 0x065206d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiShopActivity.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiShopActivity.<>c <>9; // 0x0
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.ComItemCardLarge_Activity> <>9__113_0; // 0x8
	static System.Void .cctor(); // 0x0652076c
	System.Void .ctor(); // 0x065207d0
	WizardGames.Soc.SocClient.Ui.ComItemCardLarge_Activity <.ctor>b__113_0(FairyGUI.GComponent c); // 0x06520838
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiShopActivity.<>c__DisplayClass89_0 : System.Object
{
	WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg; // 0x10
	System.Void .ctor(); // 0x0651dee4
	System.Void <UpdateItemDetailUI>b__0(FairyGUI.EventContext context); // 0x065208dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiShopActivity.<>c__DisplayClass89_1 : System.Object
{
	FairyGUI.EventCallback1 tipsClickFunc; // 0x10
	System.Void .ctor(); // 0x0651dfc0
	System.Void <UpdateItemDetailUI>b__1(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x06520b04
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiShopPlayer : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	System.Int32 currentInputNum; // 0x338
	System.Int64 shopEntityId; // 0x340
	WizardGames.Soc.Common.Component.VendingMachineComponent vendingMachineComp; // 0x348
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> tabType2ItemNum; // 0x350
	System.Collections.Generic.Dictionary<System.Int32,System.String> itemType2TabName; // 0x358
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> tabIndex2Type; // 0x360
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.PriceItem>> tabType2Items; // 0x368
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.CustomType.PriceItem,System.Int32> shopItem2CanBuyCount; // 0x370
	System.Int32 curSelectedTabIndex; // 0x378
	System.Int32 curSelectedItemIndex; // 0x37c
	WizardGames.Soc.Common.CustomType.PriceItem curSelectedItem; // 0x380
	System.Int32 buyItemNum; // 0x388
	WizardGames.Soc.Common.CustomType.StackableItemNode buyItem; // 0x390
	WizardGames.Soc.SocClient.Ui.MsgBoxInfo msgBoxInfo; // 0x398
	WizardGames.Soc.Common.Data.tips.CommonTip inventotyFullTipConfig; // 0x3a0
	WizardGames.Soc.Common.Data.tips.CommonTip buyConfirmBtnContext; // 0x3a8
	WizardGames.Soc.Common.Data.tips.CommonTip buyCancelBtnContext; // 0x3b0
	FairyGUI.GComponent content; // 0x3b8
	FairyGUI.GList itemGList; // 0x3c0
	FairyGUI.GTextField showItemNameText; // 0x3c8
	FairyGUI.GTextField showItemNumText; // 0x3d0
	WizardGames.Soc.SocClient.Ui.ComItemIcon showItemIcon; // 0x3d8
	FairyGUI.GTextField showItemSaleNumText; // 0x3e0
	FairyGUI.GTextField showItemDescText; // 0x3e8
	WizardGames.Soc.SocClient.Ui.ComStepper comStepper; // 0x3f0
	FairyGUI.GButton btnManagement; // 0x3f8
	FairyGUI.GButton openInventoryBtn; // 0x400
	FairyGUI.GButton btnDetail; // 0x408
	WizardGames.Soc.SocClient.Ui.ComPriceBtnNew buyBtn; // 0x410
	FairyGUI.Controller showInventoryFullCtrl; // 0x418
	FairyGUI.Controller waitingCtrl; // 0x420
	FairyGUI.Transition showUIAnim; // 0x428
	FairyGUI.Transition hideUIAnim; // 0x430
	FairyGUI.Transition WatingShowAnim; // 0x438
	FairyGUI.Transition WatingLoopAnim; // 0x440
	FairyGUI.Transition WatingHideAnim; // 0x448
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,FairyGUI.GObject>> cacheSubGObjectDic; // 0x450
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,FairyGUI.Controller>> cacheGObjControllerDic; // 0x458
	UnityEngine.Vector2 CounterPos; // 0x460
	FairyGUI.Controller shopTypeCtrl; // 0x468
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x470
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x478
	FairyGUI.GGraph tipsTouchArea; // 0x480
	FairyGUI.GButton tipsBtn; // 0x488
	System.Void InitTranstion(); // 0x06520ba8
	System.Void SetData(WizardGames.Soc.Common.Component.VendingMachineComponent vendingMachineComp, System.Int64 shopEntityId); // 0x06520d20
	System.Void OnEnable(); // 0x065236c0
	System.Void OnDisable(); // 0x065239d8
	System.Void InitData(); // 0x06520e80
	System.Void RefreshCanBuyCountData(); // 0x06523b68
	System.Void InitBtnManagementUI(); // 0x06521b18
	System.Void InitTabBarAndTopBarUI(); // 0x06521bd0
	System.Void RefreshNavBar(); // 0x06523764
	System.Void InitItemGridUI(); // 0x065222b8
	System.Void InitItemDetailUI(); // 0x0652254c
	System.Void RegisterUIEvent(); // 0x06523560
	System.Void OnShopItemBuyFinish(System.Int64 priceId, System.Int32 num, System.Int32 ret); // 0x06523db0
	System.Void UpdateAllUI(); // 0x06524684
	System.Void PlayWaitingAnim(); // 0x065246f0
	System.Void OnWatingShowAnimComplete(); // 0x065248bc
	System.Void PlayStopWaitingAnim(); // 0x065241bc
	System.Void RendererItemUI(System.Int32 index, FairyGUI.GObject item); // 0x0652492c
	System.Void OnClickTab(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x06524db8
	System.Void OnClickItem(FairyGUI.EventContext context); // 0x06524ea4
	System.Void SetItemShopID(System.Int32 index); // 0x06523a40
	System.Void OnClickBuyBtn(FairyGUI.EventContext context); // 0x06524fb4
	System.Void OnClickBuyMsgOkBtn(); // 0x065256c8
	System.Void OnClickOpenDetail(); // 0x0652572c
	System.Void HandleBuyRequest(); // 0x06525610
	System.Void OnClickOpenInventoryBtn(FairyGUI.EventContext context); // 0x06525884
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x065258fc
	System.Void UpdateItemGridUI(); // 0x06522460
	System.Void UpdateItemDetailUI(); // 0x065230f4
	System.Void UpdateBuySliderUI(WizardGames.Soc.Common.CustomType.PriceItem priceItem); // 0x06524514
	System.Void UpdateItemStorageUI(); // 0x065243c0
	System.Void UpdateShopItemSaleCurrencyUI(WizardGames.Soc.Common.CustomType.PriceItem priceItem); // 0x065259e4
	System.Void UpdateOpenInventoryBtnUI(); // 0x06525cb4
	System.Void UpdateBuyBtnUI(); // 0x06524250
	System.Void OnDestroy(); // 0x06525e60
	System.Void StopAnim(FairyGUI.Transition anim); // 0x065247dc
	static System.Void Open(System.Int64 shopEntityId); // 0x06525fc0
	System.Void TryStopLooting(); // 0x06525f18
	static System.Void Close(); // 0x0652618c
	System.Void .ctor(); // 0x065262f0
	System.Void <InitItemDetailUI>b__57_0(System.Int32 value); // 0x06526604
	System.Void <InitItemDetailUI>b__57_1(FairyGUI.EventContext ctx); // 0x06526688
	System.Void <RegisterUIEvent>b__58_0(); // 0x06526700
	System.Void <RegisterUIEvent>b__58_1(); // 0x06526780
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiShopPlayer.<>c__DisplayClass76_0 : System.Object
{
	WizardGames.Soc.Common.Data.DataItem.ItemConfig showItemConfig; // 0x10
	FairyGUI.EventCallback1 tipsClickFunc; // 0x18
	System.Void .ctor(); // 0x0652597c
	System.Void <UpdateItemDetailUI>b__0(FairyGUI.EventContext context); // 0x065267e4
	System.Void <UpdateItemDetailUI>b__1(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x06526a0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiShopPlayer.<>c__DisplayClass79_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.PriceItem priceItem; // 0x10
	System.Void .ctor(); // 0x06525df8
	System.String <UpdateShopItemSaleCurrencyUI>b__0(); // 0x06526ab0
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EPriceItemType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EPriceItemType Origin = 0;
	static WizardGames.Soc.SocClient.Ui.EPriceItemType Delete = 1;
	static WizardGames.Soc.SocClient.Ui.EPriceItemType Change = 2;
	static WizardGames.Soc.SocClient.Ui.EPriceItemType Add = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.EditPriceItem : System.Object
{
	System.Int32 Id; // 0x10
	WizardGames.Soc.Common.CustomType.PriceItem priceItem; // 0x18
	WizardGames.Soc.SocClient.Ui.EPriceItemType itemType; // 0x20
	System.Void .ctor(System.Int32 id, WizardGames.Soc.Common.CustomType.PriceItem priceItem, WizardGames.Soc.SocClient.Ui.EPriceItemType itemType); // 0x06526b88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiShopUpload : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	WizardGames.Soc.Common.Component.VendingMachineComponent vendingMachineComp; // 0x338
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.EditPriceItem> editPriceItemList; // 0x340
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.EditPriceItem> showEditPriceItemList; // 0x348
	static System.Boolean isFromMainWin; // 0x0
	static System.Int32 selectIconIndex; // 0x4
	FairyGUI.GComponent content; // 0x350
	FairyGUI.Controller priceItemControl; // 0x358
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x360
	FairyGUI.GButton btnChangeName; // 0x368
	WizardGames.Soc.SocClient.Ui.ComStateBtn btnAddOrder; // 0x370
	FairyGUI.GTextInput inputText; // 0x378
	WizardGames.Soc.SocClient.Ui.ComStateBtn btnStock; // 0x380
	WizardGames.Soc.SocClient.Ui.ComStateBtn btnSave; // 0x388
	FairyGUI.GList listPriceItems; // 0x390
	WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComStockManagement stockManagement; // 0x398
	WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComSelectItem selectItem; // 0x3a0
	WizardGames.Soc.SocClient.Ui.VendingMachineCom.ComChangeOrder changeOrder; // 0x3a8
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,FairyGUI.GObject>> cacheSubGObjectDic; // 0x3b0
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,FairyGUI.Controller>> cacheGObjControllerDic; // 0x3b8
	System.Void SetData(WizardGames.Soc.Common.Component.VendingMachineComponent vendingMachineComp); // 0x06526c3c
	System.Void OnInit(); // 0x06527120
	System.Void InitUi(); // 0x06526ccc
	System.Void OnEnable(); // 0x06527ce8
	System.Void UpdateAllUI(); // 0x06526de4
	System.Void OnPriceItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x0652821c
	System.Void LoadListData(); // 0x06527ebc
	System.Void OnClickPriceItemCancel(System.Int32 editItemId); // 0x06528c18
	System.Void OnClickDelete(System.Int32 editItemId); // 0x06528c94
	System.Int32 CanAddOrderNum(); // 0x06529024
	System.Void AddPriceItem(WizardGames.Soc.Common.CustomType.PriceItem priceItem); // 0x06529224
	System.Void EditPriceItem(System.Int32 id, WizardGames.Soc.Common.CustomType.PriceItem priceItem); // 0x0652997c
	System.Void RefreshSaveBtn(); // 0x06527a14
	System.Void OnClickChoose(System.Int32 index, System.Int32 editItemId, FairyGUI.GComponent com); // 0x06529dc4
	System.Void RefreshList(); // 0x06528104
	System.Void OnShopRenameCallBack(System.Int32 result); // 0x0652a144
	FairyGUI.Controller GetControllerByCache(FairyGUI.GComponent item, System.String name); // 0x06529f38
	System.Void OnClickAddOrder(); // 0x0652a2b0
	System.Void OpenSelectItem(); // 0x0652a49c
	System.Void OpenStockManage(); // 0x0652a510
	System.Void SelectItemIcon(WizardGames.Soc.Common.Data.DataItem.ItemConfig itemConfig); // 0x0652a584
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0652a60c
	System.Void CloseWin(); // 0x0652aa68
	System.Void OnClickChangeName(); // 0x0652ab20
	System.Void ChangeNameBanned(); // 0x0652ac54
	System.Void RealChangeName(); // 0x0652acc8
	System.Void OnClickSave(System.Boolean isSilent); // 0x0652addc
	System.Boolean CheckChange(); // 0x06529bf0
	System.Void OnDisable(); // 0x0652b4f8
	System.Void RefreshStockManager(); // 0x0652b700
	static System.Void Open(System.Int64 shopEntityId); // 0x0652b770
	static System.Void InitData(System.Int64 shopEntityId); // 0x0652b9a4
	static System.Void Close(); // 0x0652bb58
	System.Void OnFps1Update(System.Single dt); // 0x0652bc50
	System.Void .ctor(); // 0x0652bce4
	static System.Void .cctor(); // 0x0652be9c
	System.Void <RefreshSaveBtn>b__32_0(FairyGUI.EventContext ctx); // 0x0652beec
	System.Void <OnEscClose>b__42_0(); // 0x0652bf68
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiShopUpload.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiShopUpload.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__32_1; // 0x8
	static System.Void .cctor(); // 0x0652bfd8
	System.Void .ctor(); // 0x0652c03c
	System.Void <RefreshSaveBtn>b__32_1(FairyGUI.EventContext ctx); // 0x0652c0a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiShopUpload.<>c__DisplayClass25_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiShopUpload <>4__this; // 0x10
	System.Int32 index; // 0x18
	WizardGames.Soc.SocClient.Ui.ComItemCardLarge com; // 0x20
	System.Void .ctor(); // 0x06528b48
	System.Void <OnPriceItemRender>b__0(FairyGUI.EventContext ctx); // 0x0652c1c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiShopUpload.<>c__DisplayClass25_1 : System.Object
{
	WizardGames.Soc.SocClient.Ui.EditPriceItem editPriceItem; // 0x10
	WizardGames.Soc.SocClient.Ui.UiShopUpload.<>c__DisplayClass25_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x06528bb0
	System.Void <OnPriceItemRender>b__1(FairyGUI.EventContext ctx); // 0x0652c248
	System.Void <OnPriceItemRender>b__2(FairyGUI.EventContext ctx); // 0x0652c2dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiShopUpload.<>c__DisplayClass52_0 : System.Object
{
	System.Int64 shopEntityId; // 0x10
	System.Void .ctor(); // 0x0652b93c
	System.Void <Open>b__0(System.Boolean res); // 0x0652c380
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiShopUpload.<>c__DisplayClass53_0 : System.Object
{
	System.Int64 shopEntityId; // 0x10
	System.Void .ctor(); // 0x0652baf0
	System.Void <InitData>b__0(WizardGames.Soc.SocClient.Ui.UiShopUpload win); // 0x0652c440
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComSearch : System.Object
{
	FairyGUI.GComponent root; // 0x10
	FairyGUI.GTextInput inputText; // 0x18
	FairyGUI.GButton btnSearch; // 0x20
	FairyGUI.GButton btnClear; // 0x28
	System.Action<System.String> searchAction; // 0x30
	System.Action clearAction; // 0x38
	System.Void .ctor(FairyGUI.GComponent component, System.Action<System.String> searchAction, System.Action clearAction); // 0x0652c584
	System.Void InitComSearch(); // 0x0652c654
	System.Void InputTextChange(); // 0x0652c99c
	System.Void OnClickClearText(); // 0x0652cbf4
	System.Void OnClickSearch(System.Boolean needClearTxt); // 0x0652cacc
	System.Void <InitComSearch>b__7_0(FairyGUI.EventContext ctx); // 0x0652ccb8
	System.Void <InitComSearch>b__7_1(); // 0x0652cd34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSleep : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GLabel textTips; // 0x338
	FairyGUI.GTextField textCampingTentTimer; // 0x340
	FairyGUI.Controller ctrlTipsIconStyle; // 0x348
	System.String remainTimeFormat; // 0x350
	System.Int64 campingTimer; // 0x358
	System.Void OnInit(); // 0x055049cc
	System.Void OnUnAliveStateChange(System.Int64 entityId, WizardGames.Soc.Common.Entity.PlayerUnAliveStateEnum fromState, WizardGames.Soc.Common.Entity.PlayerUnAliveStateEnum toState); // 0x0652d72c
	System.Void SetSleepStyle(System.Boolean isCamping); // 0x0652d57c
	System.Void CancelCampingTimer(); // 0x0652da70
	System.Boolean CheckCampingTentState(); // 0x054c4760
	System.Void OnCampingTentCountdownOver(); // 0x0652ddbc
	System.Void RefreshCampingTentRemainTime(System.Int64 startMs, System.UInt32 validSec); // 0x0652dbe4
	System.Void OnDestroy(); // 0x0652de2c
	System.Void HandleAppPushUnregister(); // 0x0652df9c
	System.Void DoWakeUp(); // 0x0652e058
	System.Void .ctor(); // 0x0652e520
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSleep.<>c__DisplayClass10_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiSleep <>4__this; // 0x10
	System.Int64 startTime; // 0x18
	System.UInt32 validTime; // 0x20
	System.Void .ctor(); // 0x0652db7c
	System.Void <CheckCampingTentState>b__0(System.Int64 _, System.Object _, System.Boolean _); // 0x0652e5ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSlideGuide : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger Log; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.GameSlideGuide.UiSlideGuideBinder binder; // 0x338
	FairyGUI.Transition loopAnim; // 0x340
	FairyGUI.Transition showAnim; // 0x348
	System.Void OnInit(); // 0x0652e650
	System.Void OnEnable(); // 0x0652e964
	System.Void OnDisable(); // 0x0652ea68
	System.Void OnMissionChanged(); // 0x0652eb7c
	static WizardGames.Soc.SocClient.Ui.UiSlideGuide OpenWindow(); // 0x0652ee90
	static System.Void CloseWindow(); // 0x0652edf8
	static WizardGames.Soc.SocClient.Ui.UiSlideGuide GetWindow(); // 0x0652ef60
	System.Void .ctor(); // 0x0652f020
	static System.Void .cctor(); // 0x0652f0ac
	System.Void <OnInit>b__4_0(); // 0x0652f180
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSoundPrint : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	SocLogger log; // 0x338
	System.Int32[] ArrowShowAngle; // 0x340
	WizardGames.Soc.SocClient.Ui.Binder.GameSoundPrint.ArrowBinder LeftArrowBinder; // 0x348
	WizardGames.Soc.SocClient.Ui.ComLazyLoader[] LeftArrowIcon; // 0x350
	WizardGames.Soc.SocClient.Ui.Binder.GameSoundPrint.ArrowBinder RightArrowBinder; // 0x358
	WizardGames.Soc.SocClient.Ui.ComLazyLoader[] RightArrowIcon; // 0x360
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiSoundPrint.SoundPrintData> SoundPrintDatas; // 0x368
	System.Int32 SoundPrintMax; // 0x370
	System.Single Duration; // 0x374
	System.Single FreqSpace; // 0x378
	System.Single StartFadeTime; // 0x37c
	System.Single MergeAngle; // 0x380
	System.Single FloorDistance; // 0x384
	System.Single clearTimer; // 0x388
	System.Single clearTime; // 0x38c
	WizardGames.Soc.SocClient.Ui.UiSoundPrint.ArrowData arrowData; // 0x390
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SoundUI.Sound> lastSoundData; // 0x3a0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SoundUI.Sound> showList; // 0x3a8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SoundUI.Sound> adjustedAngles; // 0x3b0
	System.Func<WizardGames.Soc.SocClient.Ui.SoundUI.Sound,WizardGames.Soc.SocClient.Ui.SoundUI.Sound,System.Int32> CompareAngles; // 0x3b8
	UnityEngine.Vector3 pos; // 0x3c0
	System.String soundPrintUiId; // 0x3d0
	FairyGUI.Controller stateController; // 0x3d8
	FairyGUI.GComponent commMarkerContainer; // 0x3e0
	WizardGames.Soc.SocClient.Ui.UiHudElemDirection elemDirection; // 0x3e8
	System.Single comWidth; // 0x3f0
	System.Int32 columnGap; // 0x3f4
	System.Int32 distance; // 0x3f8
	System.Single mainIconHeight; // 0x3fc
	System.Single mainIconX; // 0x400
	System.Single mainIconWidth; // 0x404
	System.Single offset; // 0x408
	UnityEngine.Vector3 nodePos; // 0x40c
	System.Func<WizardGames.Soc.SocClient.Ui.SoundUI.Sound,WizardGames.Soc.SocClient.Ui.SoundUI.Sound,System.Int32> CompareSound; // 0x418
	FairyGUI.GObjectPool <SoundPrintUiPool>k__BackingField; // 0x420
	System.Void InitUIComponent(); // 0x0652f204
	FairyGUI.GObjectPool get_SoundPrintUiPool(); // 0x0652f340
	System.Void set_SoundPrintUiPool(FairyGUI.GObjectPool value); // 0x0652f3a4
	System.Void OnInit(); // 0x0652f424
	System.Void OnEnable(); // 0x06530474
	System.Void RegisterEvents(); // 0x06530354
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x06530514
	System.Void OnDisable(); // 0x06530c90
	System.Void OnDestroy(); // 0x06530d2c
	static System.Void Close(); // 0x06530d94
	System.Void RefreshSoundInfo(System.Single dt); // 0x0653059c
	System.Void ClearSoundPrint(); // 0x06531bb0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SoundUI.Sound> AdjustAngles(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SoundUI.Sound> showList); // 0x065316a4
	System.Single GetSoundPrintAngle(UnityEngine.Vector3 sourceDir); // 0x06532ba0
	System.Void UpdateSoundPrintPos(WizardGames.Soc.SocClient.Ui.SoundUI.Sound sound); // 0x0653124c
	System.Void ShowSoundPrint(WizardGames.Soc.SocClient.Ui.SoundUI.Sound sound, System.Int32 index); // 0x06531338
	System.Void ReturnSoundPrint(WizardGames.Soc.SocClient.Ui.SoundUI.Sound sound); // 0x06530e44
	System.Void ShowIcons(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.SoundUI.Sound> showList); // 0x06531d3c
	System.Void ShowArrow(); // 0x065322bc
	System.Void ReturnObject(FairyGUI.GObjectPool pool, FairyGUI.GObject obj); // 0x065331ac
	FairyGUI.GObject GetObject(FairyGUI.GObjectPool pool, System.String urlId); // 0x06533254
	System.Boolean IsNarrowScreen(); // 0x065303b4
	System.Void Push2Array(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiSoundPrint.SoundPrintData> list, System.Single angle, System.Int32 index); // 0x06532ee4
	System.Void ClearArray(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiSoundPrint.SoundPrintData> list); // 0x065310b8
	System.Void OnFps10Update(System.Single dt); // 0x065333a4
	System.Void SetSoundSwitch(System.String switchGroup, System.String switchState, UnityEngine.GameObject gameObject); // 0x065338b0
	System.Void .ctor(); // 0x06533c50
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiSoundPrint.ArrowData : System.ValueType
{
	System.Int32 leftArrowIndex; // 0x10
	System.Int32 RightArrowIndex; // 0x14
	System.Single leftAlpha; // 0x18
	System.Single rightAlpha; // 0x1c
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSoundPrint.SoundPrintData : System.Object
{
	System.Boolean <Valid>k__BackingField; // 0x10
	System.Single angle; // 0x14
	System.Int32 index; // 0x18
	System.Boolean get_Valid(); // 0x06533fb8
	System.Void set_Valid(System.Boolean value); // 0x0653401c
	System.Void .ctor(System.Single angle, System.Int32 index); // 0x06533308
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSoundPrint.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiSoundPrint.<>c <>9; // 0x0
	static System.Func<WizardGames.Soc.SocClient.Ui.SoundUI.Sound,WizardGames.Soc.SocClient.Ui.SoundUI.Sound,System.Int32> <>9__67_0; // 0x8
	static System.Func<WizardGames.Soc.SocClient.Ui.SoundUI.Sound,WizardGames.Soc.SocClient.Ui.SoundUI.Sound,System.Int32> <>9__67_1; // 0x10
	static System.Void .cctor(); // 0x06534098
	System.Void .ctor(); // 0x065340fc
	System.Int32 <.ctor>b__67_0(WizardGames.Soc.SocClient.Ui.SoundUI.Sound a, WizardGames.Soc.SocClient.Ui.SoundUI.Sound b); // 0x06534164
	System.Int32 <.ctor>b__67_1(WizardGames.Soc.SocClient.Ui.SoundUI.Sound a, WizardGames.Soc.SocClient.Ui.SoundUI.Sound b); // 0x0653420c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiStory : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update, WizardGames.Soc.SocClient.Ui.IJumpToUIWindow
{
	WizardGames.Soc.SocClient.Ui.UiStoryPage storyPage; // 0x338
	UiSouDJWnd souDJWnd; // 0x340
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.UiStoryBinder binder; // 0x348
	WizardGames.Soc.SocClient.Ui.UiStoryInfoWnd storyInfoWnd; // 0x350
	FairyGUI.Controller tagCtr; // 0x358
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x360
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x368
	System.Void OnInit(); // 0x0653429c
	System.Void JumpToUIWindow(WizardGames.Soc.SocClient.Ui.JumpData jumpData); // 0x06534efc
	System.Void JumpToStage(WizardGames.Soc.Common.Data.Play.StoryStageStage stage); // 0x06534f8c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06535058
	System.Void OnEnable(); // 0x065350f4
	System.Void UpdataReputationRed(); // 0x06535398
	System.Void OnDisable(); // 0x06535488
	System.Void OnDestroy(); // 0x065355dc
	System.Void OnFps1Update(System.Single dt); // 0x0653565c
	System.Void .ctor(); // 0x065357a0
	System.Void <OnInit>b__7_0(WizardGames.Soc.SocClient.Ui.NavBarData barData, System.Boolean b); // 0x0653582c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiStoryLevelRewardItem : System.Object, WizardGames.Soc.SocClient.Ui.IComBinderDestroy
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.ComRightListBinder binder; // 0x10
	System.Int64 <Data>k__BackingField; // 0x18
	System.Int32[] tempRewardIds; // 0x20
	System.Int32[] tempRewardNums; // 0x28
	System.Int64 get_Data(); // 0x06535a44
	System.Void set_Data(System.Int64 value); // 0x06535aa8
	System.Void .ctor(FairyGUI.GComponent root); // 0x06535b20
	System.Void RefreshItemRenderer(); // 0x06535bd8
	System.Void OnItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x06535ce4
	System.Void SetData(System.Int64 rewardId); // 0x0653605c
	System.Void OnDestroy(); // 0x0653669c
	static System.Void .cctor(); // 0x065366fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiStoryPage : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.UiStoryTaskItem> taskItems; // 0x10
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.UiStoryLevelRewardItem> levelRewardItems; // 0x18
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.Binder.GameStory.StageDesItemBinder> descriptBinders; // 0x20
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.Binder.GameStory.ComStoryStageItemBinder> stageBinders; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.ComStoryPageBinder binder; // 0x30
	WizardGames.Soc.Common.Data.Play.StoryStageStage selectedStage; // 0x38
	FairyGUI.GLoader bg; // 0x40
	System.Collections.Generic.List<System.Int64> taskList; // 0x48
	System.Collections.Generic.List<System.Int64> levelRewards; // 0x50
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.StoryStageStage> tempStageList; // 0x58
	System.Int64 tempEndTime; // 0x60
	System.Int64 stageOfEndTime; // 0x68
	System.Void OnInit(FairyGUI.GComponent root, FairyGUI.GLoader bg); // 0x06536978
	System.Void OnSettlementExplanation(FairyGUI.EventContext context); // 0x065370a4
	System.Void OnJumpTo(FairyGUI.EventContext context); // 0x06537118
	System.Void JumpToStage(WizardGames.Soc.Common.Data.Play.StoryStageStage stage); // 0x065373fc
	System.Void OnRefreshTask(); // 0x06537478
	System.Void OnRewardClicked(FairyGUI.EventContext context); // 0x06538c08
	System.Void TaskItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x0653978c
	System.Void NItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x0653a520
	System.Void DescriptItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x0653a63c
	System.Void OnStageClicked(FairyGUI.EventContext context); // 0x0653a85c
	System.Void StageItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x0653aa58
	System.Void RefreshStageList(); // 0x065374f4
	System.Void RefreshStageInfo(); // 0x06537b98
	System.Void RefreshStageRewardInfo(); // 0x06537ffc
	System.Void RefreshTaskList(); // 0x065387b8
	System.Void RefreshView(WizardGames.Soc.Common.Data.Play.StoryStageStage stage); // 0x065371e0
	System.Void OnDisable(); // 0x0653aed0
	System.Void OnDestroy(); // 0x0653afc8
	System.Void RefreshTime(); // 0x0653b108
	System.Void OnUpdate(); // 0x0653b734
	System.Void Show(); // 0x0653b798
	System.Void Hide(); // 0x0653b8a8
	System.Void .ctor(); // 0x0653b9a0
	System.Boolean <RefreshStageList>b__22_0(WizardGames.Soc.Common.Data.Play.StoryStageStage a); // 0x0653bdbc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiStoryPage.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiStoryPage.<>c <>9; // 0x0
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.UiStoryTaskItem> <>9__36_0; // 0x8
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.UiStoryLevelRewardItem> <>9__36_1; // 0x10
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.Binder.GameStory.StageDesItemBinder> <>9__36_2; // 0x18
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.Binder.GameStory.ComStoryStageItemBinder> <>9__36_3; // 0x20
	static System.Void .cctor(); // 0x0653be50
	System.Void .ctor(); // 0x0653beb4
	WizardGames.Soc.SocClient.Ui.UiStoryTaskItem <.ctor>b__36_0(FairyGUI.GComponent c); // 0x0653bf1c
	WizardGames.Soc.SocClient.Ui.UiStoryLevelRewardItem <.ctor>b__36_1(FairyGUI.GComponent c); // 0x0653c3b4
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.StageDesItemBinder <.ctor>b__36_2(FairyGUI.GComponent c); // 0x0653c458
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.ComStoryStageItemBinder <.ctor>b__36_3(FairyGUI.GComponent c); // 0x0653c4fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiStoryRewardPanel : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.Binder.GameStory.ComStoryTaskRewardItem02Binder> rewardBinders; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.UiStoryRewardPanelBinder binder; // 0x340
	WizardGames.Soc.SocClient.Ui.ComModal modal; // 0x348
	System.Int32[] tempRewardIds; // 0x350
	WizardGames.Soc.Common.Data.Play.StoryStageStage stage; // 0x358
	System.Void OnInit(); // 0x0653c5a0
	System.Void OnItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x0653c974
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0653cce4
	System.Void OnCloseClicked(); // 0x0653cd68
	System.Void OnCancelClicked(); // 0x0653cdd4
	System.Void Refresh(WizardGames.Soc.Common.Data.Play.StoryStageStage stage); // 0x06538e10
	System.Void OnOkClicked(); // 0x0653ce40
	System.Void OnEnable(); // 0x0653cef8
	System.Void OnDisable(); // 0x0653cf58
	System.Void OnDestroy(); // 0x0653cfb8
	System.Void .ctor(); // 0x0653d03c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiStoryRewardPanel.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiStoryRewardPanel.<>c <>9; // 0x0
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.Binder.GameStory.ComStoryTaskRewardItem02Binder> <>9__15_0; // 0x8
	static System.Void .cctor(); // 0x0653d1dc
	System.Void .ctor(); // 0x0653d240
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.ComStoryTaskRewardItem02Binder <.ctor>b__15_0(FairyGUI.GComponent c); // 0x0653d2a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiStoryRewardPanel.<>c__DisplayClass5_0 : System.Object
{
	FairyGUI.GObject item; // 0x10
	WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg; // 0x18
	System.Void .ctor(); // 0x0653cc7c
	System.Void <OnItemRenderer>b__0(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x0653d34c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiStoryTaskItem : System.Object, WizardGames.Soc.SocClient.Ui.IComBinderDestroy
{
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.Binder.GameStory.ComStoryTaskRewardItem01Binder> rewardBinders; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.ComStoryTaskItemBinder binder; // 0x18
	System.Int64 <Data>k__BackingField; // 0x20
	System.Int32[] tempRewardIds; // 0x28
	System.Int64 get_Data(); // 0x0653d458
	System.Void set_Data(System.Int64 value); // 0x0653d4bc
	System.Void .ctor(FairyGUI.GComponent root); // 0x0653bfbc
	System.Void RefreshItemRenderer(); // 0x065398a8
	System.Void OnButtonClicked(FairyGUI.EventContext context); // 0x0653d534
	System.Void OnGotoClicked(); // 0x0653d8ac
	System.Void OnReceiveClicked(); // 0x0653d7c0
	System.Void OnItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x0653dac8
	System.Void SetData(System.Int64 taskId); // 0x065399b4
	System.Void OnDestroy(); // 0x0653dd2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiStoryTaskItem.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiStoryTaskItem.<>c <>9; // 0x0
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.Binder.GameStory.ComStoryTaskRewardItem01Binder> <>9__6_0; // 0x8
	static System.Void .cctor(); // 0x0653ddb0
	System.Void .ctor(); // 0x0653de14
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.ComStoryTaskRewardItem01Binder <.ctor>b__6_0(FairyGUI.GComponent c); // 0x0653de7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiStoryInfoWnd : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.StoryInfoWndBinder binder; // 0x10
	FairyGUI.GButton memberBtn; // 0x18
	FairyGUI.GButton badgeBtn; // 0x20
	FairyGUI.GButton gameRewardBtn; // 0x28
	FairyGUI.GButton lobbyRewardBtn; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Reputation.BadgeData> badgeDatas; // 0x38
	System.Single minWidth; // 0x40
	FairyGUI.GImage cabinetLevelProgress; // 0x48
	FairyGUI.GObject cabinetLevelLine; // 0x50
	FairyGUI.GObject cabinetLevelCom; // 0x58
	FairyGUI.GLoader bg; // 0x60
	System.Boolean isKeepStroyInfo; // 0x68
	System.Void OnInit(FairyGUI.GComponent root, FairyGUI.GLoader bg); // 0x0653df20
	System.Void UpdataWnd(); // 0x0653e9ec
	System.Void UpdataLeftWnd(); // 0x0653f0e0
	System.Void UpdataNextStageTime(); // 0x06540198
	System.Void UpdataRightWnd(); // 0x0653ea8c
	System.Void UpdataReputationInfo(); // 0x06540970
	System.Void UpdateItemList(); // 0x06540d8c
	System.Void UpdateItemIcon(WizardGames.Soc.Common.Data.Reward dropReward, FairyGUI.GComponent com); // 0x065417e0
	System.Void UpdateSelelctItemIcon(System.Int32 selectId, FairyGUI.GComponent com); // 0x065419dc
	System.Void OnClickItem(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x06541cbc
	System.Void OnClickSelectItem(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon, System.Int32 selectItemId); // 0x06541e48
	System.Void UpdataCarckTime(); // 0x06540588
	System.Void UpdataDiskNum(); // 0x0654076c
	System.Void Hide(); // 0x06541fe8
	System.Void OnClickMemBtn(); // 0x06542048
	System.Void OnClickBadge(); // 0x06542114
	System.Void OnClickGameReward(); // 0x06542184
	System.Void OnClickLobbyReward(); // 0x06542298
	System.Void .ctor(); // 0x065423ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiStoryInfoWnd.<>c__DisplayClass20_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiStoryInfoWnd <>4__this; // 0x10
	System.Int32 selectId; // 0x18
	System.Void .ctor(); // 0x06541c54
	System.Void <UpdateSelelctItemIcon>b__0(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x0654241c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiStoryPlanBox : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.ComPopPictureMsgBoxSimpleBinder _comBinder; // 0x338
	FairyGUI.GComponent _picBoxCom; // 0x340
	WizardGames.Soc.SocClient.Ui.PicBoxInfo _info; // 0x348
	System.Void OnInit(); // 0x065424a4
	System.Void OnDestroy(); // 0x065425d8
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0654276c
	System.Void OnEnable(); // 0x065427ec
	System.Void OnFps30Update(System.Single dt); // 0x06542854
	System.Void RefreshTime(); // 0x06542930
	System.Void .ctor(); // 0x06542c0c
	static System.Void .cctor(); // 0x06542c98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiStoryPlanBox3D : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	static SocLogger logger; // 0x0
	FairyGUI.GComponent com; // 0x338
	WizardGames.Soc.SocClient.Ui.Com3DUiSceneModel Ui3d; // 0x340
	UnityEngine.RenderTexture texture; // 0x348
	System.Action<UnityEngine.RenderTexture> textureCallback; // 0x350
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.PicBoxBtnInfo> dic; // 0x358
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.PicBoxBtnInfo> btnListInfo; // 0x360
	WizardGames.Soc.SocClient.Ui.UiPicBoxBtnList btnList; // 0x368
	System.Int64 timeEnd; // 0x370
	System.Void OnInit(); // 0x06542d6c
	System.Void RefreshUi(FairyGUI.GComponent component, UnityEngine.RenderTexture texture); // 0x06543434
	System.Void OnDestroy(); // 0x06543510
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x065435a0
	System.Void CloseUi(FairyGUI.EventContext context); // 0x06543760
	System.Void OnEnable(); // 0x06543804
	System.Void SetInfo(); // 0x06543378
	System.Void OnFps30Update(System.Single dt); // 0x0654386c
	System.Void RefreshTime(); // 0x06543948
	System.Void .ctor(); // 0x06543a54
	static System.Void .cctor(); // 0x06543b2c
	System.Void <OnInit>b__8_1(); // 0x06543c00
	System.Void <OnInit>b__8_2(); // 0x06543c74
	System.Void <OnInit>b__8_0(); // 0x06543e0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiStoryPlanBox3D.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiStoryPlanBox3D.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__8_3; // 0x8
	static System.Action<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__8_4; // 0x10
	static System.Void .cctor(); // 0x06543fa4
	System.Void .ctor(); // 0x06544008
	System.Void <OnInit>b__8_3(WizardGames.Soc.Common.Unity.Ui.WindowComBase base); // 0x06544070
	System.Void <OnInit>b__8_4(WizardGames.Soc.Common.Unity.Ui.WindowComBase base); // 0x06544184
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiStoryStageInfo3D : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	static SocLogger logger; // 0x0
	FairyGUI.GComponent com; // 0x338
	WizardGames.Soc.SocClient.Ui.Com3DUiSceneModel Ui3d; // 0x340
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.ComStoryStageInfo3DBookBinder binder; // 0x348
	WizardGames.Soc.Common.Data.Play.StoryStageStage stageInfo; // 0x350
	WizardGames.Soc.Common.Data.Play.StoryStageStage nextStageInfo; // 0x358
	System.Int64 timeEnd; // 0x360
	UnityEngine.RenderTexture texture; // 0x368
	System.Action<UnityEngine.RenderTexture> textureCallback; // 0x370
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.PicBoxBtnInfo> dic; // 0x378
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.PicBoxBtnInfo> btnListInfo; // 0x380
	WizardGames.Soc.SocClient.Ui.UiPicBoxBtnList btnList; // 0x388
	System.Void OnInit(); // 0x06544298
	System.Void RefreshUi(FairyGUI.GComponent component, UnityEngine.RenderTexture texture); // 0x06544974
	System.Void Refresh3DUi(); // 0x06544a58
	System.Void NextStageTagItemRender(System.Int32 index, FairyGUI.GObject item); // 0x065450d8
	System.Void StageTagItemRender(System.Int32 index, FairyGUI.GObject item); // 0x0654534c
	System.Void TagItemRender(WizardGames.Soc.Common.Data.Play.StoryStageDescription cfg, FairyGUI.GObject item); // 0x06545214
	System.Void OnDestroy(); // 0x06545488
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06545644
	System.Void CloseUi(FairyGUI.EventContext context); // 0x06545804
	System.Void OnEnable(); // 0x065458a8
	System.Void SetInfo(); // 0x065448b8
	System.Void OnFps30Update(System.Single dt); // 0x06545910
	System.Void RefreshTime(); // 0x065459ec
	System.Void .ctor(); // 0x06545c4c
	static System.Void .cctor(); // 0x06545d24
	System.Void <OnInit>b__12_1(); // 0x06545df8
	System.Void <OnInit>b__12_2(); // 0x06545e6c
	System.Void <OnInit>b__12_3(WizardGames.Soc.Common.Unity.Ui.WindowComBase base); // 0x06545f9c
	System.Void <OnInit>b__12_0(); // 0x06546070
	System.Void <OnInit>b__12_4(WizardGames.Soc.Common.Unity.Ui.WindowComBase base); // 0x065461a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiStorySettlement : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	static SocLogger _logger; // 0x0
	FairyGUI.GComponent _root; // 0x338
	FairyGUI.Controller _ctrlStatus; // 0x340
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.UiStorySettlementBinder _uiBinder; // 0x348
	System.Boolean _canTouch; // 0x350
	System.String _battleServerId; // 0x358
	System.Boolean _maxLevelMaster; // 0x360
	WizardGames.Soc.SocClient.Ui.Binder.GameStory.ComSettlementPanelBinder _settlementPanel; // 0x368
	FairyGUI.PlayCompleteCallback _transShowAnimComplete; // 0x370
	FairyGUI.PlayCompleteCallback _showAnimCompleteOver; // 0x378
	FairyGUI.PlayCompleteCallback _transShowAnimFail; // 0x380
	FairyGUI.PlayCompleteCallback _showAnimFailOver; // 0x388
	System.Void OnInit(); // 0x06546274
	System.Void OnTransShowAnimComplete(); // 0x06546604
	System.Void OnTransShowAnimFail(); // 0x0654666c
	System.Void CloseBack(FairyGUI.EventContext context); // 0x065466d4
	System.Void OnEnable(); // 0x065469f8
	System.Void SetInfo(System.String battleServerId, System.Int64 duration); // 0x06546a68
	System.Void OnShowAnimFailOver(); // 0x06548168
	System.Void OnShowAnimCompleteOver(); // 0x065484ec
	System.Void OnDestroy(); // 0x06548870
	System.Void OnFps30Update(System.Single dt); // 0x06548980
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x065489f4
	static WizardGames.Soc.SocClient.Ui.UiStorySettlement ShowStorySettlement(System.String battleServerId, System.Int64 duration); // 0x06548b94
	System.Void .ctor(); // 0x06548dc0
	static System.Void .cctor(); // 0x06548e4c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiStorySettlement.<>c__DisplayClass23_0 : System.Object
{
	System.String battleServerId; // 0x10
	System.Int64 duration; // 0x18
	System.Void .ctor(); // 0x06548d58
	System.Void <ShowStorySettlement>b__0(WizardGames.Soc.SocClient.Ui.UiStorySettlement win); // 0x06548f20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSubtitle : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger Log; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.GameSubtitle.UiSubtitleBinder binder; // 0x338
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Queue<System.Int32>> subtitleDic; // 0x340
	System.Collections.Generic.Queue<System.Int32> subtitleMainQueue; // 0x348
	System.Collections.Generic.List<System.String> subtitleLst; // 0x350
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,System.Object>> subtitleGODic; // 0x358
	System.Boolean showing; // 0x360
	System.Int32 curShowingId; // 0x364
	System.String preAudioName; // 0x368
	System.Action<System.Int32> finishCallback; // 0x370
	System.Int64 timerId; // 0x378
	System.Void OnInit(); // 0x06548fa4
	System.Void OnEnable(); // 0x06549244
	System.Void OnDisable(); // 0x065493cc
	System.Void OnDestroy(); // 0x065496a8
	System.Void ShowSubtitle(); // 0x06549710
	System.Void Setup(System.Int32 id, System.Action<System.Int32> cb); // 0x06549d8c
	System.Void OnRenderSubtitle(System.Int32 index, FairyGUI.GObject obj); // 0x0654a174
	System.Void TryAddloopSubtitle(); // 0x0654a45c
	System.Void SetSubtitle(System.String txt); // 0x0654a754
	static WizardGames.Soc.SocClient.Ui.UiSubtitle OpenWindow(System.Action<WizardGames.Soc.SocClient.Ui.UiSubtitle> cb); // 0x0654a858
	static System.Void CloseWindow(); // 0x06549cf4
	static WizardGames.Soc.SocClient.Ui.UiSubtitle GetWindow(); // 0x0654a930
	static System.Boolean IsWindowOpen(); // 0x0654a9f0
	System.Void .ctor(); // 0x0654aa9c
	static System.Void .cctor(); // 0x0654acc4
	System.Void <ShowSubtitle>b__15_1(System.Int64 id, System.Object data, System.Boolean delete); // 0x0654ad98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSubtitle.<>c__DisplayClass15_0 : System.Object
{
	WizardGames.Soc.Common.Data.Play.SubtitleConfig stepCfg; // 0x10
	WizardGames.Soc.SocClient.Ui.UiSubtitle <>4__this; // 0x18
	System.Void .ctor(); // 0x06549c8c
	System.Void <ShowSubtitle>b__0(System.Int64 id, System.Object data, System.Boolean delete); // 0x0654b008
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSurvivalManual : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.UiSurvivalManualData uiData; // 0x338
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x340
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x348
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar searchNavBar; // 0x350
	WizardGames.Soc.SocClient.Ui.NavBarData curSelectSecondBarData; // 0x358
	FairyGUI.GButton searchBtn; // 0x360
	FairyGUI.GButton clearBtn; // 0x368
	FairyGUI.GTextInput inputText; // 0x370
	FairyGUI.GTextField unlockedNumText; // 0x378
	FairyGUI.GButton assistantBtn; // 0x380
	FairyGUI.Controller secondTabCtrl; // 0x388
	System.Boolean keepFirstTabOnRefresh; // 0x390
	System.Boolean playAnimWhenClose; // 0x391
	System.Boolean isInitTab; // 0x392
	FairyGUI.Controller searchStateCtr; // 0x398
	FairyGUI.Controller searchStateCtr2; // 0x3a0
	FairyGUI.Controller searchResultCtr; // 0x3a8
	FairyGUI.GComponent content; // 0x3b0
	System.Collections.Generic.List<System.Int32> saveLocalReadList; // 0x3b8
	System.Int32 saveNormalFirstTabId; // 0x3c0
	System.Int32 saveNormalSecondTabId; // 0x3c4
	FairyGUI.GComponent contentCom; // 0x3c8
	FairyGUI.GList pageList; // 0x3d0
	FairyGUI.GButton leftBtn; // 0x3d8
	FairyGUI.GButton rightBtn; // 0x3e0
	FairyGUI.GTextField leftTxt; // 0x3e8
	FairyGUI.GTextField rightTxt; // 0x3f0
	FairyGUI.Controller grayCtr; // 0x3f8
	FairyGUI.GList pointList; // 0x400
	System.Int32 curPageIndex; // 0x408
	System.Boolean toLastOnSetContent; // 0x40c
	WizardGames.Soc.SocClient.Ui.ComVideo videoPlayer; // 0x410
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x0654b470
	System.Void OnInit(); // 0x0654b4f0
	System.Void OnEnable(); // 0x0654daf4
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0654db5c
	System.Void ChangeSearchState(System.Boolean isSearch); // 0x0654dbe4
	System.Void UpdateSearchWnd(); // 0x0654dce8
	System.Void AutoSelectFirstTab(); // 0x0654d714
	System.Void UpdateComNavBarData(); // 0x0654cf0c
	System.Void OnClickTabBack(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x0654e490
	System.Void OnClickSearchTabBack(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x0654ec84
	System.Void OnDestroy(); // 0x0654ee0c
	System.Void AddSecondTab(System.Int32 secondTabId); // 0x0654f100
	System.Void RefreshUi(System.Int32 secondTabId); // 0x0654f3fc
	System.Void SelectedSecondTabIdChange(); // 0x0654f920
	System.Void OnFirstTabBtnClick(System.Int32 tabId, WizardGames.Soc.SocClient.Ui.NavBarData data); // 0x0654e66c
	System.Void CloseSecondTabRedDot(System.Int32 tabId); // 0x0654fc1c
	System.Void OnSecondTabBtnClick(System.Int32 tabId, WizardGames.Soc.SocClient.Ui.NavBarData data); // 0x0654e700
	System.Void OnClickSearch(); // 0x0654fd74
	System.Void OnDisable(); // 0x065501bc
	System.Void PlayAudio(System.String soundEvent); // 0x0654c190
	System.Void EnableImmediatelyClose(); // 0x065502d0
	System.Void OnInitContent(); // 0x0654c7a8
	System.Void OnScrollEnd(FairyGUI.EventContext context); // 0x065503e4
	System.Void OnRenderPageList(System.Int32 index, FairyGUI.GObject obj); // 0x06550458
	System.Void OnScrollBarScroll(); // 0x06550c88
	System.Void OnClickLeftBtn(); // 0x06551018
	System.Void TryMoveToLastNarData(); // 0x06551154
	System.Void OnClickRightBtn(); // 0x0655161c
	System.Void TryMoveToNextNarData(); // 0x06551774
	System.Boolean IsSecondFirstTab(); // 0x06551c50
	System.Boolean IsSecondLastTab(); // 0x06551e84
	System.Void OnRenderPointList(System.Int32 index, FairyGUI.GObject obj); // 0x065520bc
	System.Void SetContentInfo(); // 0x0654f984
	System.Void InitPageBtn(); // 0x06550334
	System.Void ClearPageBtn(); // 0x0654f0a0
	System.Void RefreshContentUi(System.Int32 pageNum, System.Int32 index); // 0x06550eac
	System.Void .ctor(); // 0x065521a4
	System.Void <OnInit>b__24_0(); // 0x06552404
	System.Void <OnInit>b__24_1(); // 0x06552478
	System.Void <OnInit>b__24_2(); // 0x065525b0
	System.Void <OnInit>b__24_3(); // 0x06552684
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSurvivalManual.<>c__DisplayClass64_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComVideo comVideo; // 0x10
	System.Void .ctor(); // 0x06550c20
	System.Void <OnRenderPageList>b__0(UnityEngine.Video.VideoPlayer player); // 0x06552824
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSurvivalManualData : System.Object
{
	System.Collections.Generic.List<System.Int32> firstTabSortList; // 0x10
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>> secondTabIdDic; // 0x18
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>> secondTabIdSearchDic; // 0x20
	System.Int32 selectedFirstTabId; // 0x28
	System.Int32 selectedSecondTabId; // 0x2c
	System.Boolean isInSearch; // 0x30
	System.Boolean dontRefOnClearSearch; // 0x31
	System.Action SelectedFirstTabIdChangeAction; // 0x38
	System.Action SelectedSecondTabIdChangeAction; // 0x40
	System.Int32 latelyUnLockFirstTabId; // 0x48
	System.Collections.Generic.List<System.Int32> get_FirstTabSortList(); // 0x065528c0
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>> get_SecondTabIdDic(); // 0x06552924
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>> get_SecondTabIdSearchDic(); // 0x06552988
	System.Collections.Generic.List<System.Int32> get_LatestUnlockedTabIdList(); // 0x065529ec
	System.Collections.Generic.List<System.Int32> get_DefaultUnlockedTabIdList(); // 0x06552abc
	System.Int32 get_UnlockedNum(); // 0x0654da3c
	System.Void set_SelectedFirstTabId(System.Int32 value); // 0x0654fb80
	System.Int32 get_SelectedSecondTabId(); // 0x06552b8c
	System.Void set_SelectedSecondTabId(System.Int32 value); // 0x0654ed70
	System.Void OnInit(); // 0x0654c2e0
	System.Void OnDestroy(); // 0x0654f024
	System.Void GetManualData(); // 0x0654c35c
	System.Void UnlockSecondTabId(System.Int32 tabId); // 0x0654f7b4
	System.Void AddFirstTab(System.Int32 tabId); // 0x06552bf0
	System.Int32 SearchContent(System.String searchStr); // 0x0654fef8
	System.Boolean SearchContentInConfig(WizardGames.Soc.Common.Data.Play.ManualSecondTabConfig config, System.String searchStr); // 0x0655315c
	System.Void UnlockSearchSecondTabId(System.Int32 tabId); // 0x06553420
	static System.Void AddSortSecondTabId(System.Collections.Generic.List<System.Int32> secondTabIdList, System.Int32 tabId); // 0x06552eb8
	static WizardGames.Soc.Common.Data.Play.ManualFirstTabConfig GetManualFirstTabConfig(System.Int32 tabId); // 0x0654e390
	static WizardGames.Soc.Common.Data.Play.ManualSecondTabConfig GetManualSecondTabConfig(System.Int32 tabId); // 0x0654e290
	System.Boolean IsTextMatch(System.String sourceStr, System.String searchStr); // 0x06553318
	System.String DeleteColorLabel(System.String str); // 0x065534e0
	System.String RemoveHtmlTags(System.String input); // 0x0655365c
	System.Void .ctor(); // 0x065522cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ConnectedGraph : System.Object
{
	System.Int32[,] graph; // 0x10
	System.Int32 width; // 0x18
	System.Int32 height; // 0x1c
	System.Void .ctor(System.Int32 width, System.Int32 height); // 0x0655372c
	System.Void SetWeight(WizardGames.Soc.SocClient.Ui.Vertex vertex, System.Int32 weight); // 0x06553800
	System.Void SetWeight(System.Int32 widthIndex, System.Int32 heightIndex, System.Int32 weight); // 0x06553970
	System.Int32 GetWeight(WizardGames.Soc.SocClient.Ui.Vertex vertex); // 0x06553af8
	System.Int32 GetWeight(System.Int32 widthIndex, System.Int32 heightIndex); // 0x06553bc8
	System.Boolean CanConnect(WizardGames.Soc.SocClient.Ui.Vertex originVertex, WizardGames.Soc.SocClient.Ui.Vertex targetVertex, WizardGames.Soc.SocClient.Ui.Vertex roadOriginVertex, System.Int32 roadOriginWeight); // 0x06553ca0
	System.Boolean IsVertexInGraph(WizardGames.Soc.SocClient.Ui.Vertex vertex); // 0x065538d0
	System.Boolean IsVertexInGraph(System.Int32 widthIndex, System.Int32 heightIndex); // 0x06553a54
	System.Boolean IsAdjacent(WizardGames.Soc.SocClient.Ui.Vertex originVertex, WizardGames.Soc.SocClient.Ui.Vertex targetVertex); // 0x06553e44
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.Vertex : System.ValueType
{
	System.Int32 x; // 0x10
	System.Int32 y; // 0x14
	System.Void .ctor(System.Int32 x, System.Int32 y); // 0x06553f48
	System.Void Set(System.Int32 x, System.Int32 y); // 0x06553fc8
	static System.Boolean op_Equality(WizardGames.Soc.SocClient.Ui.Vertex s1, WizardGames.Soc.SocClient.Ui.Vertex s2); // 0x06553db0
	System.Boolean Equals(System.Object obj); // 0x06554048
	System.Int32 GetHashCode(); // 0x0655410c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EAngleType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EAngleType AngleNone = -1;
	static WizardGames.Soc.SocClient.Ui.EAngleType Angle20 = 0;
	static WizardGames.Soc.SocClient.Ui.EAngleType Angle30 = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBoxOpeningGame : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	static SocLogger logger; // 0x0
	FairyGUI.GComponent _right; // 0x338
	FairyGUI.GComponent _n17; // 0x340
