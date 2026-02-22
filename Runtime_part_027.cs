// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIConstructionInfoTipsPopup : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static System.String UI_NMAE; // 0x0
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.EConstructionInfoType,WizardGames.Soc.SocClient.Ui.ConstructionInfoTipsCreator> infoTipsCreatorDic; // 0x338
	static System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.EConstructionEditMode,WizardGames.Soc.SocClient.Ui.EConstructionInfoType> editModeToInfoTypeDic; // 0x8
	FairyGUI.Controller ctrTipState; // 0x340
	WizardGames.Soc.SocClient.Ui.ConstructionInfoData curInfoData; // 0x348
	WizardGames.Soc.SocClient.Ui.EConstructionEditMode curEditMode; // 0x350
	WizardGames.Soc.SocClient.Ui.EConstructionInfoType curInfoType; // 0x354
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.EConstructionInfoType,WizardGames.Soc.SocClient.Ui.UIComInfoTipsBase> comInfoTipsDic; // 0x358
	WizardGames.Soc.SocClient.Ui.UIComInfoTipsBase lastComInfoTipsBase; // 0x360
	FairyGUI.GComponent panelRoot; // 0x368
	System.Boolean hideByHalfWin; // 0x370
	System.Void OnInit(); // 0x05eb3b14
	System.Void OnEnable(); // 0x05eb40c4
	System.Void OnDisable(); // 0x05eb41b0
	System.Void OnDestroy(); // 0x05eb4374
	System.Void OnBuildPopTipAlphaChange(System.Boolean isShow); // 0x05eb4568
	System.Void InitBuildTip(); // 0x05eb3e00
	static System.Void ShowWin(WizardGames.Soc.SocClient.Ui.EConstructionEditMode editMode, WizardGames.Soc.SocClient.Ui.ConstructionInfoData infoData); // 0x05eb4728
	static WizardGames.Soc.SocClient.Ui.UIConstructionInfoTipsPopup OpenTips(); // 0x05eb4820
	static System.Void HideWin(); // 0x05eb5128
	static System.Void RemoveWin(); // 0x05eb5238
	System.Void Show(WizardGames.Soc.SocClient.Ui.EConstructionEditMode editMode, WizardGames.Soc.SocClient.Ui.ConstructionInfoData infoData); // 0x05eb49d4
	System.Void ShowBuildTipInfo(); // 0x05eb5334
	System.Void ClearTipData(); // 0x05eb424c
	System.Void UpdatePos(); // 0x05eb4aec
	System.Void OnUiShowAnimFinishEvent(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05eb54b0
	System.Void OnUiHide(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05eb5610
	System.Void .ctor(); // 0x05eb5704
	static System.Void .cctor(); // 0x05eb5ff4
	System.Void <OnEnable>b__14_0(); // 0x05eb6184
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIConstructionInfoTipsPopup.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UIConstructionInfoTipsPopup.<>c <>9; // 0x0
	static System.Func<WizardGames.Soc.SocClient.Ui.UIComInfoTipsBase> <>9__29_0; // 0x8
	static System.Func<WizardGames.Soc.SocClient.Ui.UIComInfoTipsBase> <>9__29_1; // 0x10
	static System.Func<WizardGames.Soc.SocClient.Ui.UIComInfoTipsBase> <>9__29_2; // 0x18
	static System.Func<WizardGames.Soc.SocClient.Ui.UIComInfoTipsBase> <>9__29_3; // 0x20
	static System.Func<WizardGames.Soc.SocClient.Ui.UIComInfoTipsBase> <>9__29_4; // 0x28
	static System.Func<WizardGames.Soc.SocClient.Ui.UIComInfoTipsBase> <>9__29_5; // 0x30
	static System.Func<WizardGames.Soc.SocClient.Ui.UIComInfoTipsBase> <>9__29_6; // 0x38
	static System.Func<WizardGames.Soc.SocClient.Ui.UIComInfoTipsBase> <>9__29_7; // 0x40
	static System.Func<WizardGames.Soc.SocClient.Ui.UIComInfoTipsBase> <>9__29_8; // 0x48
	static System.Void .cctor(); // 0x05eb6254
	System.Void .ctor(); // 0x05eb62b8
	WizardGames.Soc.SocClient.Ui.UIComInfoTipsBase <.ctor>b__29_0(); // 0x05eb6320
	WizardGames.Soc.SocClient.Ui.UIComInfoTipsBase <.ctor>b__29_1(); // 0x05eb63a8
	WizardGames.Soc.SocClient.Ui.UIComInfoTipsBase <.ctor>b__29_2(); // 0x05eb6430
	WizardGames.Soc.SocClient.Ui.UIComInfoTipsBase <.ctor>b__29_3(); // 0x05eb64bc
	WizardGames.Soc.SocClient.Ui.UIComInfoTipsBase <.ctor>b__29_4(); // 0x05eb6548
	WizardGames.Soc.SocClient.Ui.UIComInfoTipsBase <.ctor>b__29_5(); // 0x05eb65d4
	WizardGames.Soc.SocClient.Ui.UIComInfoTipsBase <.ctor>b__29_6(); // 0x05eb665c
	WizardGames.Soc.SocClient.Ui.UIComInfoTipsBase <.ctor>b__29_7(); // 0x05eb66e8
	WizardGames.Soc.SocClient.Ui.UIComInfoTipsBase <.ctor>b__29_8(); // 0x05eb6774
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComUiPhoto : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiConstructionReport constructionReport; // 0x10
	FairyGUI.GButton btnClose; // 0x18
	FairyGUI.GButton btnPhoto; // 0x20
	FairyGUI.GComponent root; // 0x28
	System.Void Init(FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.UiConstructionReport constructionReport); // 0x05eb67fc
	System.Void OnEnable(); // 0x05eb6a28
	System.Void OnDisable(); // 0x05eb6b68
	System.Void OnBtnClose(); // 0x05eb6c48
	System.Void OnBtnPhoto(); // 0x05eb6d54
	System.Void .ctor(); // 0x05eb6f20
	System.Void <OnEnable>b__5_0(); // 0x05eb6f88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComUiReport : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.UiConstructionReport constructionReport; // 0x10
	FairyGUI.GTextInput input; // 0x18
	FairyGUI.GTextField txtInputCount; // 0x20
	FairyGUI.GLoader loaderImage; // 0x28
	WizardGames.Soc.Common.Entity.PartEntity partEntity; // 0x30
	UnityEngine.Vector3 outsidePos; // 0x38
	System.Int64 outsideEntityId; // 0x48
	System.UInt64 outsideCreatorId; // 0x50
	UnityEngine.Texture2D tex2D; // 0x58
	WizardGames.Soc.SocClient.Ui.ComModal modal; // 0x60
	System.Void Init(FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.UiConstructionReport constructionReport); // 0x05eb6fec
	System.Void OnInputChange(); // 0x05eb788c
	System.Void UpdateInputCount(); // 0x05eb76e4
	System.Void SetPhotot(UnityEngine.Texture2D tex2D); // 0x05eb78f0
	System.Void OnBtnClose(); // 0x05eb7a14
	System.Void OnBtnConfirm(); // 0x05eb7a80
	System.Void OnGetOutsideCreatorId(System.Int64 entityId, System.UInt64 creatorId); // 0x05eb7e24
	System.Void OnOnGetCosReportTempCredential(System.String url, System.String token, System.String tmpSecretId, System.String tmpSecretKey, System.String filePath); // 0x05eb80d4
	System.Void OnComplete(System.Boolean isSucecss, System.String urlAck); // 0x05eb8510
	System.Void .ctor(); // 0x05eb8ff4
	static System.Void .cctor(); // 0x05eb905c
	System.Void <Init>b__11_0(); // 0x05eb9130
	System.Void <Init>b__11_2(); // 0x05eb9194
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComUiReport.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.ComUiReport.<>c <>9; // 0x0
	static System.Action <>9__11_1; // 0x8
	static System.Void .cctor(); // 0x05eb91f8
	System.Void .ctor(); // 0x05eb925c
	System.Void <Init>b__11_1(); // 0x05eb92c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiConstructionReport : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static System.String UI_NMAE; // 0x0
	static System.Boolean IS_SHOW; // 0x8
	FairyGUI.Controller ctrState; // 0x338
	WizardGames.Soc.SocClient.Ui.ComUiReport comUiReport; // 0x340
	WizardGames.Soc.SocClient.Ui.ComUiPhoto comUiPhoto; // 0x348
	FairyGUI.GButton btnExitPC; // 0x350
	static WizardGames.Soc.SocClient.Ui.UiConstructionReport OpenWindow(); // 0x05eb9324
	static System.Void CloseWindow(); // 0x05eb94b8
	static System.Boolean IsOpen(); // 0x05eb95d0
	System.Void OnInit(); // 0x05eb9658
	System.Void OnEnable(); // 0x055049cc
	System.Void Dispose(); // 0x055049cc
	System.Void OnDyingEnter(WizardGames.Soc.Common.Entity.PlayerEntity entity); // 0x05eba2c4
	System.Void OnFastReconnected(); // 0x05eba378
	System.Void OnCampingTentLogoutSuccess(); // 0x05eba418
	System.Void OnHandleDamage(WizardGames.Soc.Common.SimpleCustom.DamageDataEvent data); // 0x05eba4b8
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05eba62c
	System.Void OnCosReportTooFrequency(); // 0x05eba6a4
	System.Void OnClose(); // 0x05eb6cb4
	System.Void OnOnGetCosReportTempCredential(System.String url, System.String token, System.String tmpSecretId, System.String tmpSecretKey, System.String filePath); // 0x05eba7bc
	System.Void OnGetOutsideCreatorId(System.Int64 entityId, System.UInt64 creatorId); // 0x05eba8f8
	System.Void TakeShot(); // 0x05eb6e2c
	System.Void UpdateCtr(System.Int32 index); // 0x05eba9f0
	System.Void .ctor(); // 0x05ebaae0
	static System.Void .cctor(); // 0x05ebab6c
	System.Void <OnEnable>b__10_0(); // 0x05ebabe4
	System.Void <TakeShot>b__21_0(UnityEngine.Texture2D tex2D); // 0x05ebac60
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiContainerUtil : System.Object
{
	static SocLogger logger; // 0x0
	static WizardGames.Soc.Common.CustomType.ItemContainerNode GetItemContainerNodeById(System.Int64 entityId, System.Int64 nodeId); // 0x05ebacf0
	static System.Int32 GetContainerAllItemAmount(System.Int64 entityId, System.Int64 nodeId); // 0x05ebae28
	static System.Int32 GetContainerItemAmount(WizardGames.Soc.SocClient.Ui.ItemContainerNodeParser itemContainerNodeParser, System.Int64 itemId); // 0x05ebb090
	static System.Int32 GetContainerCapcity(System.Int64 entityId, System.Int32& haveCout, System.Int64 nodeId, System.Int64 targetItemId); // 0x05ebb1d0
	static System.Int32 GetItemStackCount(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, WizardGames.Soc.SocClient.Ui.ItemContainerNodeParser itemContainerNodeParser, System.Int64 targetItemId); // 0x05ebb39c
	static WizardGames.Soc.SocClient.Ui.ItemContainerNodeParser GetItemContainerNodeParserById(System.Int64 entityId, System.Int64 nodeId); // 0x05ebaf58
	static System.Int64[] GetIdDivision(System.Int64 entityId, System.Int64 nodeId); // 0x05ebb544
	static System.Void RemoteCallQuickMerge(System.Int64 entityId, System.Boolean isNeedDefaultCout, System.Int64 nodeId, System.Int64 itemId, System.Int32 inputCount, System.Boolean isShowTip); // 0x05ebb5f4
	static System.Void RemoteCallQuickRequire(System.Int64 entityId, System.Int64 nodeId, System.Int64 itemId); // 0x05ebbba4
	static System.Int32 NeedMoveToOtherCount(System.Int64 entityId, System.Boolean isNeedDefaultCout, System.Int64 nodeId, System.Int64 itemId, System.Int32 inputCount, System.Boolean isShowTip); // 0x05ebb7e4
	static System.Int32 GetOwnCount(System.Int64 itemId); // 0x05ebc254
	static System.Int32 NeedMoveToInventoryCount(System.Int64 entityId, System.Int64 itemId, System.Int64 nodeId, System.Boolean& checkSuccess); // 0x05ebbd64
	static System.Int32 GetInventoryCapcity(WizardGames.Soc.Common.CustomType.ItemContainerNode containerNodePlayer, System.Int64 itemId, System.Int32& haveCout); // 0x05ebc300
	static System.Int32 GetStackByItemId(System.Int64 nodeId, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, System.Int64 itemID); // 0x05ebc564
	static System.Void RemoteCallMoveToOther(System.Int64 entityId, System.Boolean isNeedDefaultCout, System.Int64 nodeId, System.Int64 itemId, System.Int32 inputCount, System.Boolean isShowTip); // 0x05ebc77c
	static System.Void RemoteCallMoveToInventory(System.Int64 entityId, System.Int64 nodeId, System.Int64 itemId, System.Boolean& checkSuccess); // 0x05ebc9d4
	static System.Int32 GetWaterCur(System.Int64 entityId, System.Int32 index); // 0x05ebcbc4
	static System.Int32 GetWaterMax(System.Int64 entityId, System.Int32 idx); // 0x05ebcddc
	static WizardGames.Soc.Common.Component.WaterFacilityComponent GetWaterFacilityComponent(System.Int64 entityId); // 0x05ebcc80
	static System.Int64 GetWaterType(System.Int64 entityId, System.Int32 idx); // 0x05ebce98
	static System.Boolean IsOnlySaltWaterInPoweredWaterPurifier(System.Int64 entityId); // 0x05ebcf5c
	static System.Void DrinkWater(System.Int64 entityId, System.Int32 idx); // 0x05ebd0cc
	static System.Int32 GetWaterCountWithTips(System.Int64 entityId, System.Int32 idx, System.Boolean isGetWaterTips); // 0x05ebd3c4
	static System.Void .cctor(); // 0x05ebd7c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIComCombineDetailTips : System.Object
{
	FairyGUI.GButton btnSkin; // 0x10
	FairyGUI.GTextField txtName; // 0x18
	FairyGUI.GTextField txtType; // 0x20
	FairyGUI.GTextField txtDesc; // 0x28
	FairyGUI.GList listChildPart; // 0x30
	WizardGames.Soc.SocClient.Ui.UIConstructionDetailInfo detailInfo; // 0x38
	FairyGUI.GComponent root; // 0x40
	FairyGUI.GImage imgIconBg; // 0x48
	System.Collections.Generic.List<FairyGUI.GComponent> iconComponentList; // 0x50
	System.Void Init(FairyGUI.GComponent root); // 0x05ebd89c
	System.Void SetData(WizardGames.Soc.SocClient.Ui.UIConstructionDetailInfo detailInfo); // 0x05ebdb18
	System.Void CreateParentPartIcon(System.String url); // 0x05ebdf08
	System.Void OnDestroy(); // 0x05ebe110
	System.Void Clear(); // 0x05ebde08
	System.Void OnRenderList(System.Int32 index, FairyGUI.GObject obj); // 0x05ebe174
	System.Void OnItemClickEvent(FairyGUI.EventContext context); // 0x05ebe328
	System.Void .ctor(); // 0x05ebe844
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIComCoreDetailTips : System.Object
{
	FairyGUI.GButton btnSkin; // 0x10
	FairyGUI.GTextField txtName; // 0x18
	FairyGUI.GLoader loaderIcon1; // 0x20
	FairyGUI.GTextField txtType; // 0x28
	FairyGUI.GTextField txtDesc; // 0x30
	System.Void Init(FairyGUI.GComponent root); // 0x05ebe8f8
	System.Void SetData(WizardGames.Soc.SocClient.Ui.UIConstructionDetailInfo detailInfo); // 0x05ebeab0
	System.Void SetData(WizardGames.Soc.SocClient.Ui.UIConstructionBaseDetailInfo detailInfo); // 0x05ebebd4
	System.Void .ctor(); // 0x05ebece0
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EConstructionDetailType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EConstructionDetailType Prop = 0;
	static WizardGames.Soc.SocClient.Ui.EConstructionDetailType CoreConstruction = 1;
	static WizardGames.Soc.SocClient.Ui.EConstructionDetailType CombineConstruction = 2;
	static WizardGames.Soc.SocClient.Ui.EConstructionDetailType CustomBlueprint = 3;
	static WizardGames.Soc.SocClient.Ui.EConstructionDetailType SurvivalManual = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIConstructionDetailInfo : System.Object
{
	WizardGames.Soc.SocClient.Ui.EConstructionDetailType detailType; // 0x10
	WizardGames.Soc.SocClient.Ui.UIConstructionBaseDetailInfo parentPart; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UIConstructionBaseDetailInfo> childrenPart; // 0x20
	System.Void .ctor(); // 0x05ebed48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIConstructionBaseDetailInfo : System.Object
{
	System.Int64 partId; // 0x10
	System.String strIconUrl; // 0x18
	System.String strDesc; // 0x20
	System.String name; // 0x28
	System.Void .ctor(); // 0x05ebedb0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UICombineDetailTipsPopup : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static System.String UI_NAME; // 0x0
	FairyGUI.GObject btnClose; // 0x338
	WizardGames.Soc.SocClient.Ui.UIComCombineDetailTips comCombineDetailTips; // 0x340
	FairyGUI.GComponent componentRoot; // 0x348
	System.Void OnInit(); // 0x05ebee18
	System.Void OnEnable(); // 0x05ebf160
	System.Void OnDisable(); // 0x05ebf240
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05ebf314
	System.Void OnDestroy(); // 0x05ebf3a4
	static WizardGames.Soc.SocClient.Ui.UICombineDetailTipsPopup OpenTips(WizardGames.Soc.SocClient.Ui.UIConstructionDetailInfo detailInfo); // 0x05ebf41c
	System.Void SetData(WizardGames.Soc.SocClient.Ui.UIConstructionDetailInfo detailInfo); // 0x05ebf630
	System.Void OnClickClose(); // 0x05ebf6b4
	System.Void SetTipsPositionToBtnDetail(UnityEngine.Vector2 pos); // 0x05ebf808
	System.Void .ctor(); // 0x05ebfa48
	static System.Void .cctor(); // 0x05ebfb08
	System.Void <OnInit>b__4_0(FairyGUI.EventContext ctx); // 0x05ebfb70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UICoreDetailTipsPopup : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static System.String UI_NMAE; // 0x0
	FairyGUI.GObject btnClose; // 0x338
	FairyGUI.GComponent componentRoot; // 0x340
	WizardGames.Soc.SocClient.Ui.UIComCoreDetailTips comCoreDetailTips; // 0x348
	System.Void OnInit(); // 0x05ebfbe8
	System.Void OnEnable(); // 0x05ebff3c
	System.Void OnDisable(); // 0x05ec001c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05ec00f0
	static WizardGames.Soc.SocClient.Ui.UICoreDetailTipsPopup OpenTips(WizardGames.Soc.SocClient.Ui.UIConstructionDetailInfo detailInfo); // 0x05ec0180
	static WizardGames.Soc.SocClient.Ui.UICoreDetailTipsPopup OpenTips(WizardGames.Soc.SocClient.Ui.UIConstructionBaseDetailInfo baseDetailInfo); // 0x05ebe560
	static WizardGames.Soc.SocClient.Ui.UICoreDetailTipsPopup OpenTips(); // 0x05ec0220
	System.Void SetData(WizardGames.Soc.SocClient.Ui.UIConstructionDetailInfo detailInfo); // 0x05ec0418
	System.Void SetData(WizardGames.Soc.SocClient.Ui.UIConstructionBaseDetailInfo detailInfo); // 0x05ec049c
	System.Void SetTipsPositionToCombineDetailTips(UnityEngine.Vector3 pos); // 0x05ebe600
	System.Void SetTipsPositionToBtnDetail(UnityEngine.Vector2 pos); // 0x05ec0520
	System.Void SetInteractionState(System.Boolean isState); // 0x05ebe764
	System.Void OnClickClose(); // 0x05ec0760
	System.Void .ctor(); // 0x05ec07cc
	static System.Void .cctor(); // 0x05ec088c
	System.Void <OnInit>b__4_0(FairyGUI.EventContext ctx); // 0x05ec08f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCounter : System.Object
{
	FairyGUI.GComponent root; // 0x10
	FairyGUI.GComponent inputPad; // 0x18
	FairyGUI.GTextInput inputText; // 0x20
	FairyGUI.GButton btnClear; // 0x28
	FairyGUI.GButton btnSet; // 0x30
	System.Action<System.Int32> SetResultAction; // 0x38
	System.Action<System.Int32> ChangeAction; // 0x40
	System.Action<FairyGUI.EventContext> ClickCancelAction; // 0x48
	System.Boolean ClearPreviousInput; // 0x50
	System.Int32 maxNum; // 0x54
	System.Boolean isLongPressing; // 0x58
	System.Int64 longPressCompleteTs; // 0x60
	System.Int32 longPressInterval; // 0x68
	FairyGUI.Transition show_anim; // 0x70
	FairyGUI.Transition hide_anim; // 0x78
	System.Boolean isHideSelf; // 0x80
	System.Boolean showErrorTipsWhenSetTarget; // 0x81
	System.Collections.Generic.Dictionary<System.String,FairyGUI.Controller> btnControllers; // 0x88
	System.String get_EnterNumberStr(); // 0x05ec096c
	System.Void HideWithAnim(); // 0x05ec09fc
	System.Void Hide(); // 0x05ec0b04
	System.Void OnInit(FairyGUI.GComponent component, FairyGUI.Transition show_anim, FairyGUI.Transition hide_anim); // 0x05ec0b78
	System.Void OnUpdate(); // 0x05ec1234
	System.Void SetInputPad(); // 0x05ec0e5c
	System.Void ClickClear(); // 0x05ec13c8
	System.Void ClickNum(System.Int32 num); // 0x05ec1608
	System.Void OnClickSetDuration(FairyGUI.EventContext context); // 0x05ec1824
	System.Void SetCounterTarget(); // 0x05ec18b0
	System.Void Clear(); // 0x05ec1a60
	System.Void OnBtnClearTouchBegin(FairyGUI.EventContext context); // 0x05ec1bbc
	System.Void OnBtnClearTouchEnd(FairyGUI.EventContext context); // 0x05ec1c70
	System.Void Open(); // 0x05ec1ce8
	System.Void SetInputNum(System.Int32 num, System.Boolean canZero); // 0x05ec14e0
	System.Void .ctor(); // 0x05ec1db0
	System.Void <OnInit>b__23_0(FairyGUI.EventContext ctx); // 0x05ec1e74
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCounter.<>c__DisplayClass25_0 : System.Object
{
	System.Int32 index; // 0x10
	WizardGames.Soc.SocClient.Ui.UiCounter <>4__this; // 0x18
	System.Void .ctor(); // 0x05ec1360
	System.Void <SetInputPad>b__0(FairyGUI.EventContext ctx); // 0x05ec1ef0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCounterPopup : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	WizardGames.Soc.SocClient.Ui.UiCounter uiCounter; // 0x338
	FairyGUI.GComponent counterCom; // 0x340
	System.Action<System.Int32> ConfirmAction; // 0x348
	System.Action<System.Int32> ChangeCallBack; // 0x350
	System.Action CancelAction; // 0x358
	static System.Single <MinX>k__BackingField; // 0x0
	static System.Single <MaxX>k__BackingField; // 0x4
	static System.Single <MinY>k__BackingField; // 0x8
	static System.Single <MaxY>k__BackingField; // 0xc
	FairyGUI.GGraph backBg; // 0x360
	static System.Single get_MinX(); // 0x05ec1f74
	static System.Void set_MinX(System.Single value); // 0x05ec1fec
	static System.Single get_MaxX(); // 0x05ec2078
	static System.Void set_MaxX(System.Single value); // 0x05ec20f0
	static System.Single get_MinY(); // 0x05ec217c
	static System.Void set_MinY(System.Single value); // 0x05ec21f4
	static System.Single get_MaxY(); // 0x05ec2280
	static System.Void set_MaxY(System.Single value); // 0x05ec22f8
	System.Void OnInit(); // 0x05ec2384
	System.Void OnEnable(); // 0x05ec2910
	System.Void OnFps10Update(System.Single dt); // 0x05ec297c
	System.Void OnCancelAction(FairyGUI.EventContext context); // 0x05ec29fc
	System.Void OnCounterSetResultAction(System.Int32 inputNum); // 0x05ec2aa8
	System.Void OnCounterChangeAction(System.Int32 inputNum); // 0x05ec2b44
	static System.Void Open(UnityEngine.Vector2 pos, System.Int32 maxInput, System.Action<System.Int32> confirmCallBack, System.Action cancelCallBack, System.Action<System.Int32> changeCallBack, UnityEngine.Vector2 v2); // 0x05ec2bd0
	static System.Void SetWinData(WizardGames.Soc.Common.Unity.Ui.WindowComBase win, UnityEngine.Vector2 pos, System.Int32 maxInput, System.Action<System.Int32> confirmCallBack, System.Action cancelCallBack, System.Action<System.Int32> changeCallBack, UnityEngine.Vector2 v2); // 0x05ec2e8c
	System.Void SetData(UnityEngine.Vector2 pos, System.Int32 maxInput, System.Action<System.Int32> confirmCallBack, System.Action cancelCallBack, System.Action<System.Int32> changeCallBack, UnityEngine.Vector2 v2); // 0x05ec2fe0
	System.Void SetPanelPos(UnityEngine.Vector3 pos); // 0x05ec3390
	System.Void SetPanelOpaque(System.Boolean isOpaque); // 0x05ec343c
	static System.Void Close(); // 0x05ec3588
	System.Void .ctor(); // 0x05ec3674
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCounterPopup.<>c__DisplayClass29_0 : System.Object
{
	UnityEngine.Vector2 pos; // 0x10
	System.Int32 maxInput; // 0x18
	System.Action<System.Int32> confirmCallBack; // 0x20
	System.Action cancelCallBack; // 0x28
	System.Action<System.Int32> changeCallBack; // 0x30
	UnityEngine.Vector2 v2; // 0x38
	System.Void .ctor(); // 0x05ec2e24
	System.Void <Open>b__0(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05ec3734
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCounterPopupAtGamePlayOverlayLayer : WizardGames.Soc.SocClient.Ui.UiCounterPopup
{
	System.Action OnDisableAction; // 0x368
	System.Void OnDisable(); // 0x05ec37c0
	static System.Void OpenAtGamePlayOverlayLayer(UnityEngine.Vector2 pos, System.Int32 maxInput, System.Action<System.Int32> confirmCallBack, System.Action cancelCallBack, System.Action<System.Int32> changeCallBack, UnityEngine.Vector2 v2); // 0x05ec3844
	static System.Void SetWinDataAtGamePlayOverlayLayer(WizardGames.Soc.Common.Unity.Ui.WindowComBase win, UnityEngine.Vector2 pos, System.Int32 maxInput, System.Action<System.Int32> confirmCallBack, System.Action cancelCallBack, System.Action<System.Int32> changeCallBack, UnityEngine.Vector2 v2); // 0x05ec3b00
	static System.Void DestroyAtGamePlayOverlayLayer(); // 0x05ec3c54
	static WizardGames.Soc.SocClient.Ui.UiCounterPopupAtGamePlayOverlayLayer GetPanelAtGamePlayOverlayLayer(); // 0x05ec3d40
	System.Void .ctor(); // 0x05ec3e40
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCounterPopupAtGamePlayOverlayLayer.<>c__DisplayClass3_0 : System.Object
{
	UnityEngine.Vector2 pos; // 0x10
	System.Int32 maxInput; // 0x18
	System.Action<System.Int32> confirmCallBack; // 0x20
	System.Action cancelCallBack; // 0x28
	System.Action<System.Int32> changeCallBack; // 0x30
	UnityEngine.Vector2 v2; // 0x38
	System.Void .ctor(); // 0x05ec3a98
	System.Void <OpenAtGamePlayOverlayLayer>b__0(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05ec3ea4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrBlueprint : WizardGames.Soc.Common.Manager.MgrBase
{
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.BlueprintMainType> mainTypes; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.BlueprintMainType> sortedMainTypes; // 0x20
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.BlueprintClient> unlockedBps; // 0x28
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.BlueprintClient>> subType2UnlockedBps; // 0x30
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.BlueprintClient>> subType2ConfigBps; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.BlueprintClient> collectedBps; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.BlueprintClient> commonBps; // 0x48
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.CommonComposeElemClient> craftQueue; // 0x50
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> matNums; // 0x58
	WizardGames.Soc.SocClient.Ui.BlueprintMainType <SubTypeFavor>k__BackingField; // 0x60
	WizardGames.Soc.SocClient.Ui.BlueprintMainType <SubTypeCommon>k__BackingField; // 0x68
	WizardGames.Soc.SocClient.Ui.BlueprintMainType <MainTypeRecommend>k__BackingField; // 0x70
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<System.Int64>> allSkinData; // 0x78
	System.Collections.Generic.Dictionary<System.Int64,System.Collections.Generic.List<System.Int64>> skinList; // 0x80
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> selectedSkinData; // 0x88
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> lobbyDefaultSelectedSkinData; // 0x90
	System.Boolean hasLoadedLocalSkinData; // 0x98
	System.String recordServerId; // 0xa0
	System.Collections.Generic.List<System.Int64> newSkinList; // 0xa8
	System.Void GoToCraft(System.Int64 blueprintId); // 0x05ec3f30
	System.Void CancelCraft(System.Int64 blueprintId); // 0x05ec4a68
	System.Boolean IsCrafting(System.Int64 blueprintId, System.Int32& index); // 0x05ec41d8
	System.Int64 GetCraftEndTime(System.Int64 blueprintId); // 0x05ec4c7c
	System.Boolean CanClaimCraft(System.Int64 itemId); // 0x05ec4ebc
	WizardGames.Soc.Common.Component.BlueprintComponent get_BlueprintComponent(); // 0x05ec4fe4
	WizardGames.Soc.SocClient.Ui.BlueprintMainType get_SubTypeFavor(); // 0x05ec5098
	WizardGames.Soc.SocClient.Ui.BlueprintMainType get_SubTypeCommon(); // 0x05ec50fc
	WizardGames.Soc.Common.CustomType.SystemRootNode get_CommonComposeSystem(); // 0x05ec5160
	WizardGames.Soc.SocClient.Ui.BlueprintMainType get_MainTypeRecommend(); // 0x05ec5218
	System.Void Init(); // 0x05ec527c
	System.Threading.Tasks.Task AfterEnterWorld(); // 0x05ec5e10
	System.Threading.Tasks.Task OnExitWorld(); // 0x05ec5f90
	System.Void OnPlayerAwake(); // 0x05ec6110
	System.Void CleanUp(); // 0x05ec6860
	System.Void InitBpTypes(); // 0x05ec52f4
	System.Void InitConfigBps(); // 0x05ec5994
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.BlueprintMainType> GetTypeGroups(); // 0x05ec6db4
	System.Void UpdateBlueprintClientCache(); // 0x05ec6e18
	WizardGames.Soc.Common.CustomType.BluePrintInfo GetBluePrintNode(System.Int64 blueprintId); // 0x05ec7be4
	System.Void UpdateCraftQueueByCollection(); // 0x05ec7ca8
	System.Boolean IsBlueprintUnlocked(System.Int64 id); // 0x05eb2750
	System.Boolean IsSelfBlueprintUnlocked(System.Int64 id); // 0x05ec865c
	System.Void OnTeamDataInit(); // 0x05ec8704
	System.Void OnTeamMemberDictChange(WizardGames.Soc.Share.Framework.ECustomDictOpType changeType, System.UInt64 roleId, WizardGames.Soc.Common.CustomType.TeamMemberInfo oldMember); // 0x05ec8afc
	System.Void OnTeamMemberDictRemove(WizardGames.Soc.Share.Framework.ECustomDictOpType change, System.UInt64 key, WizardGames.Soc.Common.CustomType.TeamMemberInfo oldValue); // 0x05ec8be4
	System.Void OnTeamMemberDictInsertOrOverride(WizardGames.Soc.Share.Framework.ECustomDictOpType change, System.UInt64 key, WizardGames.Soc.Common.CustomType.TeamMemberInfo oldValue); // 0x05ec8cf8
	System.Void OnTeamBlueprintIdsChange(); // 0x05ec8eac
	System.Boolean IsTeamBlueprintUnlocked(System.Int64 id); // 0x05ec8278
	System.Boolean IsBlueprintUnlocked(System.Int64[] ids); // 0x05ec8f4c
	WizardGames.Soc.SocClient.Ui.BlueprintClient GetUnlockedBp(System.Int64 id); // 0x05ec9044
	System.Int32 GetSubTypeBlurprints(System.Int32 subType, System.Boolean unlockedOnly, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.BlueprintClient> res); // 0x05ec9110
	System.Int32 GetMainTypeBlueprints(System.Int32 typeGroup, System.Boolean unlockedOnly, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.BlueprintClient> res); // 0x05ec9460
	System.Boolean IsBlueprintNew(System.Int64 id); // 0x05ec96ec
	System.Void LocalClearBlueprintNew(System.Int64 id); // 0x05ec9894
	System.Boolean IsBlueprintCollected(System.Int64 id); // 0x05ec9920
	System.Void GetCommonBlueprints(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.BlueprintClient>& list, System.Int32 maxCount); // 0x05ec99b4
	System.Int32 GetCommonBlueprintsCount(); // 0x05ec9ba8
	System.Boolean IsCommonBlueprintsHasNew(); // 0x05ec9cc4
	System.Void GetCollectedBlueprints(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.BlueprintClient>& res); // 0x05ec9e88
	System.Int32 GetCollectedBlueprintsCount(); // 0x05ec9f6c
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.CommonComposeElemClient> GetCraftQueue(); // 0x05ec9fec
	WizardGames.Soc.SocClient.Ui.CommonComposeElemClient GetCraftQueueHead(); // 0x05eca050
	System.Boolean IsCraftQueueFull(); // 0x05eca0fc
	System.Boolean IsCraftQueuePending(); // 0x05eca210
	System.String GetBlueprintName(WizardGames.Soc.SocClient.Ui.CommonComposeElemClient data); // 0x05eca2d4
	System.Void RefreshMatItemNums(); // 0x05ec43c0
	System.Int32 GetMatNum(System.Int32 itemID); // 0x05eca41c
	System.Int32 GetCraftResTips(WizardGames.Soc.SocClient.Ui.ECraftCheckRes checkRes); // 0x05eca4cc
	WizardGames.Soc.SocClient.Ui.ECraftCheckRes CanCraft(WizardGames.Soc.Common.Data.blueprintData.Blueprint blueprint, System.Int32 makeNum, System.Int32& maxWorkbenchLv, System.Int64& maxWorkbenchEntityId); // 0x05eca55c
	System.Boolean IsBlueprintWorkbenchLevelEnough(WizardGames.Soc.Common.Data.blueprintData.Blueprint blueprint, System.Int32& maxWorkbenchLv, System.Int64& maxWorkbenchEntityId); // 0x05eca68c
	System.Boolean IsBlueprintMatEnough(WizardGames.Soc.Common.Data.blueprintData.Blueprint blueprint, System.Int32 makeNum); // 0x05eca7e8
	WizardGames.Soc.SocClient.Ui.ECraftCheckRes CanCraft(WizardGames.Soc.Common.Data.blueprintData.Blueprint blueprint, System.Int32 makeNum); // 0x05eca944
	System.Boolean CanCraftRetBool(WizardGames.Soc.Common.Data.blueprintData.Blueprint blueprint, System.Int32 makeNum); // 0x05eca9ec
	System.Boolean IsItemCanCraft(System.Int64 itemId, WizardGames.Soc.SocClient.Ui.ECraftCheckRes& reason); // 0x05ecaa9c
	System.Boolean IsItemBlueprintUnlocked(System.Int64 itemId); // 0x05ecab68
	System.Int32 GetBlueprintMaxCanMakeTime(WizardGames.Soc.Common.Data.blueprintData.Blueprint blueprint); // 0x05ecac04
	System.Boolean DoCraft(WizardGames.Soc.Common.Data.blueprintData.Blueprint blueprint, System.Int32 makeNum, System.Int64 skinId, System.Int32 source); // 0x05ec44d4
	System.Boolean IsFinished(System.Int32 index); // 0x05ec4d64
	System.Void CancelFail(System.Int32 reason); // 0x05ecb080
	WizardGames.Soc.Common.CustomType.CommonComposeQueueNode GetCommonComposeQueueNode(); // 0x05ec80a8
	WizardGames.Soc.Common.Data.blueprintData.Blueprint GetItemBlueprint(System.Int64 itemId); // 0x05ecb14c
	System.Void LoadSkinData(); // 0x05ec620c
	System.Collections.Generic.List<System.Int64> GetSkinList(System.Int64 itemId); // 0x05ecb380
	System.Collections.Generic.List<System.Int64> GetShowingSkinList(System.Int64 itemId); // 0x05ecb45c
	System.Void SetSelectedSkin(System.Int64 itemId, System.Int64 skinId); // 0x05ecb538
	System.Boolean IsItemSkinIdSelected(System.Int64 itemId, System.Int64 skinId); // 0x05ecb700
	System.Void TryLoadLocalSkinData(); // 0x05ecb808
	System.Void LoadLocalSkinData(); // 0x05ecb9ac
	System.Void SaveLocalSkinData(); // 0x05ecc000
	System.String GetLocalFileName(); // 0x05ecbf0c
	System.Boolean TryGetSelectedSkinId(System.Int64 itemId, System.Int64& skinId); // 0x05ecaec4
	System.Int64 GetCurrentCraftSkin(System.Int64 itemId); // 0x05ecc480
	System.Boolean CheckSkinDataIsValid(System.Int64 skinId); // 0x05ecafac
	System.Void SetItemSkinId(System.Int64 itemId, System.Int64 skinId); // 0x05ecc580
	System.Collections.Generic.List<System.Int64> GetSortedSkinIds(System.Int64 itemID); // 0x05ecc68c
	System.Boolean CheckIsNew(System.Int64 skinID); // 0x05eccafc
	System.Boolean CheckIsHave(System.Int64 skinID); // 0x05ecce48
	WizardGames.Soc.Common.Data.DataItem.SkinConfig GetSkinInfo(System.Int64 skinId); // 0x05eccf58
	System.Void .ctor(); // 0x05ecd058
	static System.Void .cctor(); // 0x05ecd29c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MgrBlueprint.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.MgrBlueprint.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.BlueprintMainType> <>9__36_0; // 0x8
	static System.Comparison<WizardGames.Soc.SocClient.Ui.BlueprintClient> <>9__39_0; // 0x10
	static System.Action<WizardGames.Soc.SocClient.Ui.CommonComposeElemClient> <>9__42_0; // 0x18
	static System.Void .cctor(); // 0x05ecd370
	System.Void .ctor(); // 0x05ecd3d4
	System.Int32 <InitBpTypes>b__36_0(WizardGames.Soc.SocClient.Ui.BlueprintMainType a, WizardGames.Soc.SocClient.Ui.BlueprintMainType b); // 0x05ecd43c
	System.Int32 <UpdateBlueprintClientCache>b__39_0(WizardGames.Soc.SocClient.Ui.BlueprintClient a, WizardGames.Soc.SocClient.Ui.BlueprintClient b); // 0x05ecd550
	System.Void <UpdateCraftQueueByCollection>b__42_0(WizardGames.Soc.SocClient.Ui.CommonComposeElemClient elem); // 0x05ecd5f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.BlueprintClient : System.Object
{
	System.Int64 <BizId>k__BackingField; // 0x10
	System.Int64 fakeCfgId; // 0x18
	WizardGames.Soc.Common.CustomType.BluePrintInfo <BpNode>k__BackingField; // 0x20
	System.Boolean LocalCheck; // 0x28
	System.Void .ctor(System.Int64 bizid); // 0x05ec6c24
	System.Int64 get_BizId(); // 0x05ecd6f4
	System.Void set_BizId(System.Int64 value); // 0x05ecd758
	WizardGames.Soc.Common.CustomType.BluePrintInfo get_BpNode(); // 0x05ecd7d0
	System.Void set_BpNode(WizardGames.Soc.Common.CustomType.BluePrintInfo value); // 0x05ecd834
	System.Int64 get_BpId(); // 0x05ec793c
	System.Int32 get_Count(); // 0x05ec7a28
	System.Boolean get_Collect(); // 0x05ec7ae4
	System.Boolean get_Check(); // 0x05ec9784
	System.Void SetData(WizardGames.Soc.Common.CustomType.BluePrintInfo node, System.Int64 fakeCfgId); // 0x05ec6cdc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.CommonComposeElemClient : Share.Common.ObjPool.Alpha3PooledObjectBase
{
	WizardGames.Soc.Common.CustomType.CommonComposeNode ElemNode; // 0x20
	System.Int32 get_Interval(); // 0x05ecd8b4
	System.Int32 get_Count(); // 0x05ecd924
	System.Int32 get_TotalCount(); // 0x05ecd994
	System.Int64 get_ItemId(); // 0x05ec4c0c
	System.Int64 get_EndTime(); // 0x05ec4e4c
	static WizardGames.Soc.SocClient.Ui.CommonComposeElemClient Generate(); // 0x05ec8174
	static System.Void Return(Share.Common.ObjPool.IPooledObjectNew obj); // 0x05ecd668
	System.Void Dispose(); // 0x05ecda04
	System.Void .ctor(); // 0x05ecda70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.BlueprintMainType : System.Object
{
	System.Int32 <GroupId>k__BackingField; // 0x10
	System.Int32 <Order>k__BackingField; // 0x14
	System.String <Name>k__BackingField; // 0x18
	System.String <Icon>k__BackingField; // 0x20
	System.Collections.Generic.List<System.Int32> <SubTypes>k__BackingField; // 0x28
	System.Int32 get_GroupId(); // 0x05ecdad8
	System.Void set_GroupId(System.Int32 value); // 0x05ecdb3c
	System.Int32 get_Order(); // 0x05ecdbb4
	System.Void set_Order(System.Int32 value); // 0x05ecdc18
	System.String get_Name(); // 0x05ecdc90
	System.Void set_Name(System.String value); // 0x05ecdcf4
	System.Void set_Icon(System.String value); // 0x05ecdd74
	System.Collections.Generic.List<System.Int32> get_SubTypes(); // 0x05ecddf4
	System.Void set_SubTypes(System.Collections.Generic.List<System.Int32> value); // 0x05ecde58
	System.Void .ctor(System.Int32 group, System.Int32 order, System.Int32 nameIndex, System.String icon); // 0x05ec6968
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ECraftCheckRes : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ECraftCheckRes OK = 0;
	static WizardGames.Soc.SocClient.Ui.ECraftCheckRes DataError = 1;
	static WizardGames.Soc.SocClient.Ui.ECraftCheckRes MatConfigError = 2;
	static WizardGames.Soc.SocClient.Ui.ECraftCheckRes NotUnlock = 3;
	static WizardGames.Soc.SocClient.Ui.ECraftCheckRes WorkbenchLvNotEnought = 4;
	static WizardGames.Soc.SocClient.Ui.ECraftCheckRes MatNotEnough = 5;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SkinSorter : System.Object
{
	
	static System.Void SortSkinList(System.Collections.Generic.List<System.Int64> skinList, System.Func<System.Int64,System.Boolean> checkIsNew, System.Func<System.Int64,System.Boolean> getSkinData, System.Func<System.Int64,WizardGames.Soc.Common.Data.DataItem.SkinConfig> getSkinInfo); // 0x05ecc9ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SkinSorter.SkinIdComparer : System.Object, System.Collections.Generic.IComparer<System.Int64>
{
	System.Func<System.Int64,System.Boolean> checkIsNew; // 0x10
	System.Func<System.Int64,System.Boolean> getSkinData; // 0x18
	System.Func<System.Int64,WizardGames.Soc.Common.Data.DataItem.SkinConfig> getSkinInfo; // 0x20
	System.Void .ctor(System.Func<System.Int64,System.Boolean> checkIsNew, System.Func<System.Int64,System.Boolean> getSkinData, System.Func<System.Int64,WizardGames.Soc.Common.Data.DataItem.SkinConfig> getSkinInfo); // 0x05ecded8
	System.Int32 Compare(System.Int64 x, System.Int64 y); // 0x05ecdfa0
	System.Int32 GetCategory(System.Boolean isNew, System.Boolean isOwned); // 0x05ece184
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraft : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	FairyGUI.GComponent content; // 0x338
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x340
	WizardGames.Soc.SocClient.Ui.UiCraftMainCom craft; // 0x348
	WizardGames.Soc.SocClient.Ui.TwoStyleNavBar navBar; // 0x350
	FairyGUI.GButton btnTechLevelInfo; // 0x358
	FairyGUI.GLoader imgTechLevel; // 0x360
	FairyGUI.GTextField textTechLevelTip; // 0x368
	FairyGUI.Controller stateTechLevelCtrl; // 0x370
	FairyGUI.GButton checkTechBtn; // 0x378
	System.String currentTechLevelTipStr; // 0x380
	System.String noTechLevelStr; // 0x388
	static System.Int64[] CraftTargetBpIDs; // 0x0
	System.Boolean needRefreshOnEnable; // 0x390
	System.Int64[] workbenchBPIds; // 0x398
	System.Void InitUIComponent(); // 0x05ece210
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05ece864
	System.Void OnInit(); // 0x05ece96c
	System.Void OnEnable(); // 0x05ecee8c
	System.Void OnDisable(); // 0x05ecf4a8
	System.Void OnDestroy(); // 0x05ecf548
	System.Void RefreshCurrentList(); // 0x05ecf5ec
	System.Void InitLanguage(); // 0x05ecea98
	System.Void OnFps10Update(System.Single dt); // 0x05ecf664
	System.Void RegisterEvents(); // 0x05ecebec
	System.Void InventortUpdate(); // 0x05ecf744
	System.Void OnBlueprintsUpdate(); // 0x05ecf7d0
	System.Void OnCraftQueueUpdate(); // 0x05ecf85c
	System.Void OnJumpToCraft(System.Int64 bpID); // 0x05ecf8d4
	System.Void OnCraftQueueCancelFail(System.Int32 errorCode); // 0x05ecfa18
	System.Void OnMissionChanged(); // 0x05ecfaac
	System.Void RefreshTargetBpID(); // 0x05ecfb24
	static System.Void ShowCraft(); // 0x05ecfda8
	static System.Void OpenWithTargetId(System.Int64 craftTarID); // 0x05ecf970
	System.Void UpdateTechLevelInfo(); // 0x05ecf034
	System.Void ShowAnim(System.Boolean isOn); // 0x05eceb58
	System.Void OnSkinPopupClick(WizardGames.Soc.Common.Data.blueprintData.Blueprint blueprint); // 0x05ecff30
	System.Void OnTechLevelInfoClick(); // 0x05ed0114
	System.Void OnCheckTechBtnClick(); // 0x05ed02ec
	static System.String GetTechLevelIcon(System.Int32 techLevel); // 0x05ecfe78
	static System.String FormatTime(System.Int64 time); // 0x05ed03e8
	System.Void TryGuide(); // 0x05ecf184
	FairyGUI.GObject GetGuideObjByID(System.Int64 id); // 0x05ed059c
	System.Void .ctor(); // 0x05ed0624
	static System.Void .cctor(); // 0x05ed0754
	System.Void <InitUIComponent>b__15_0(); // 0x05ed07c8
	System.Void <OnTechLevelInfoClick>b__39_0(WizardGames.Soc.SocClient.Ui.UiCraftBlueprintTechLevelPopup win); // 0x05ed0840
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraft.<>c__DisplayClass38_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiCraft <>4__this; // 0x10
	WizardGames.Soc.Common.Data.blueprintData.Blueprint blueprint; // 0x18
	System.Void .ctor(); // 0x05ed00ac
	System.Void <OnSkinPopupClick>b__0(WizardGames.Soc.SocClient.Ui.UiCraftBlueprintSkinPopup win); // 0x05ed08d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftBlueprintCollectPopup : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.UiCraft mainUi; // 0x338
	WizardGames.Soc.SocClient.Ui.UiCraftBlueprintList craftList; // 0x340
	FairyGUI.GTextField textCollectCount; // 0x348
	FairyGUI.GList listCollect; // 0x350
	FairyGUI.Controller controller; // 0x358
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.blueprintData.Blueprint> collectList; // 0x360
	System.Int32 allCollectNum; // 0x368
	System.Int32 minDisplayNum; // 0x36c
	System.Void OnInit(); // 0x05ed0974
	System.Void InitUIComponent(); // 0x05ed0ac0
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiCraft mainUi, WizardGames.Soc.SocClient.Ui.UiCraftBlueprintList list); // 0x05ed0e88
	System.Void Update(); // 0x05ed0d8c
	System.Void GetCollectData(); // 0x05ed0f20
	System.Void RenderCollectItem(System.Int32 index, FairyGUI.GObject item); // 0x05ed1384
	System.Void OnItemClick(WizardGames.Soc.Common.Data.blueprintData.Blueprint blueprint); // 0x05ed1738
	System.Void UpdateCollectNum(); // 0x05ed11bc
	System.Void Show(); // 0x05ed1b6c
	System.Void .ctor(); // 0x05ed1bd0
	System.Void <OnInit>b__8_0(); // 0x05ed1cb0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftBlueprintCollectPopup.<>c__DisplayClass13_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiCraftBlueprintCollectPopup <>4__this; // 0x10
	WizardGames.Soc.Common.Data.blueprintData.Blueprint curBlueprint; // 0x18
	System.Void .ctor(); // 0x05ed16d0
	System.Void <RenderCollectItem>b__0(); // 0x05ed1d88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftBlueprintInfo : System.Object
{
	static SocLogger logger; // 0x0
	FairyGUI.GTextField textName; // 0x10
	FairyGUI.GLoader itemIcon; // 0x18
	FairyGUI.GComponent itemDetails; // 0x20
	FairyGUI.GButton btnStar; // 0x28
	FairyGUI.GButton btnDetail; // 0x30
	FairyGUI.GButton btnSkin; // 0x38
	FairyGUI.GLoader imgTechLevelIcon; // 0x40
	FairyGUI.GTextField textWorkBenchTip; // 0x48
	FairyGUI.GTextField textDescTitle; // 0x50
	FairyGUI.GList listDesc; // 0x58
	FairyGUI.GTextField textMatTitle; // 0x60
	FairyGUI.GList listMaterials; // 0x68
	FairyGUI.GComponent comInputNum; // 0x70
	FairyGUI.GComponent btnCraft; // 0x78
	WizardGames.Soc.SocClient.Ui.ComPriceBtnNew btnCraftNormal; // 0x80
	FairyGUI.GButton btnCraftLock; // 0x88
	FairyGUI.Controller lockController; // 0x90
	FairyGUI.GTextField bpLockText; // 0x98
	FairyGUI.Controller ctrlBtnCraftStyle; // 0xa0
	FairyGUI.Transition animBtnCraft; // 0xa8
	FairyGUI.Controller ctrlStyle; // 0xb0
	FairyGUI.GLabel labelDesc; // 0xb8
	FairyGUI.Controller ctrlStar; // 0xc0
	FairyGUI.GTextField textEmpty; // 0xc8
	FairyGUI.GTextField textCraftTimeValue; // 0xd0
	System.Boolean isBpUnlock; // 0xd8
	System.Boolean isTechTreeHasBp; // 0xd9
	System.Boolean isMatEnough; // 0xda
	System.Boolean isWorkBenchLvEnough; // 0xdb
	System.Int32 needWorkBenchLv; // 0xdc
	System.Int32 currentInputNum; // 0xe0
	WizardGames.Soc.SocClient.Ui.UiCraftMainCom mainBoard; // 0xe8
	FairyGUI.GComponent comRoot; // 0xf0
	WizardGames.Soc.Common.Data.blueprintData.Blueprint curBlueprint; // 0xf8
	System.Int32 curCanMakeMaxTime; // 0x100
	WizardGames.Soc.SocClient.Ui.UiCraftBlueprintQueue blueprintQueue; // 0x108
	WizardGames.Soc.SocClient.Ui.UiCraftBlueprintList buleprintList; // 0x110
	WizardGames.Soc.SocClient.Ui.UiInputNum uiInputNum; // 0x118
	static System.Boolean OpenQueueWhenUpdate; // 0x8
	WizardGames.Soc.SocClient.Ui.Utils.WindowCDTime windowCDTime; // 0x120
	FairyGUI.GList tabList; // 0x128
	FairyGUI.Controller tabCtrl; // 0x130
	FairyGUI.GList listAttr; // 0x138
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.AttrData> attrs; // 0x140
	System.Collections.Generic.List<System.Int64> sortedSkinIds; // 0x148
	FairyGUI.GList skinList; // 0x150
	WizardGames.Soc.Common.Data.DataItem.ItemConfig curBlueprintItemCfg; // 0x158
	FairyGUI.GButton skinOperationBtn; // 0x160
	System.Int32 lastTabIndex; // 0x168
	System.Int32[] tabArray; // 0x170
	FairyGUI.GComponent lastSkinItemCom; // 0x178
	System.Int64 usingSkinID; // 0x180
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiCraftMainCom main, FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.UiCraftBlueprintList list, WizardGames.Soc.SocClient.Ui.UiCraftBlueprintQueue queue); // 0x05ed1df8
	System.Void InitTabList(); // 0x05ed2c24
	System.Void OnTabRender(System.Int32 index, FairyGUI.GObject obj); // 0x05ed3680
	System.Void ResetTabBtn(System.Int32 index); // 0x05ed38ec
	System.Void RefreshCraftBtnState(System.Boolean isSkin, System.Int64 skinID); // 0x05ed2d74
	System.Void RefreshSkinBtnState(WizardGames.Soc.SocClient.MallSkinData data); // 0x05ed3b8c
	System.Void SetStyle(); // 0x05ed35d8
	System.Void SetActive(System.Boolean state); // 0x05ed4290
	System.Void OnEnable(); // 0x05ed4580
	System.Void ItemDoubleClick(); // 0x05ed4834
	System.Void OnDisable(); // 0x05ed438c
	System.Void SetData(WizardGames.Soc.Common.Data.blueprintData.Blueprint data, System.Boolean isUpdate); // 0x05ed4990
	System.Void UpdateAllCraftTime(); // 0x05ed39e0
	System.Void SetMaterials(); // 0x05ed5a5c
	System.Void MatItemRender(System.Int32 index, FairyGUI.GObject item); // 0x05ed5d44
	System.Void IsMatCanCraft(System.Int32 matItemID, FairyGUI.GComponent comItem); // 0x05ed62a8
	System.Void OnQueueUpdate(); // 0x05ed6520
	System.Void OnBlueprintUpdate(); // 0x05ed6644
	System.Void OnClickCollected(); // 0x05ed66c0
	System.Void OnClickOpenDetail(); // 0x05ed6b5c
	System.Void OnClickSkinBtn(); // 0x05ed6ca4
	System.Void OnClickCraft(); // 0x05ed6d18
	System.Void SetDesc(System.String desc); // 0x05ed5614
	System.Void SetAttrList(); // 0x05ed50a4
	System.Void OnAttrRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05ed72d4
	System.Void OnMallInfoUpdate(); // 0x05ed7998
	System.Void InitAttrList(); // 0x05ed5694
	System.Void SetSkinList(System.Int64 itemID); // 0x05ed5794
	System.Void OnSkinItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05ed7a0c
	System.Void RefreshSkinTabStatus(); // 0x05ed593c
	System.Void .ctor(); // 0x05ed7f64
	static System.Void .cctor(); // 0x05ed8028
	System.Void <Bind>b__51_0(FairyGUI.EventContext context); // 0x05ed810c
	System.Void <Bind>b__51_1(System.Int32 value); // 0x05ed8198
	System.Void <OnEnable>b__59_0(); // 0x05ed822c
	System.Void <OnEnable>b__59_1(); // 0x05ed8340
	System.Void <SetData>b__62_0(); // 0x05ed8454
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftBlueprintInfo.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiCraftBlueprintInfo.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__55_0; // 0x8
	static FairyGUI.EventCallback0 <>9__56_1; // 0x10
	static System.Void .cctor(); // 0x05ed8654
	System.Void .ctor(); // 0x05ed86b8
	System.Void <RefreshCraftBtnState>b__55_0(); // 0x05ed8720
	System.Void <RefreshSkinBtnState>b__56_1(); // 0x05ed8830
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftBlueprintInfo.<>c__DisplayClass53_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiCraftBlueprintInfo <>4__this; // 0x10
	System.Int32 index; // 0x18
	FairyGUI.GButton tabBtn; // 0x20
	System.Void .ctor(); // 0x05ed8940
	System.Void <OnTabRender>b__0(); // 0x05ed89a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftBlueprintInfo.<>c__DisplayClass55_0 : System.Object
{
	System.Int64 skinID; // 0x10
	WizardGames.Soc.SocClient.Ui.UiCraftBlueprintInfo <>4__this; // 0x18
	System.Void .ctor(); // 0x05ed8ad8
	System.Void <RefreshCraftBtnState>b__1(); // 0x05ed8b40
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftBlueprintInfo.<>c__DisplayClass56_0 : System.Object
{
	WizardGames.Soc.SocClient.MallSkinData data; // 0x10
	System.Void .ctor(); // 0x05ed8e84
	System.Void <RefreshSkinBtnState>b__2(); // 0x05ed8eec
	System.Void <RefreshSkinBtnState>b__0(); // 0x05ed8f7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftBlueprintInfo.<>c__DisplayClass65_0 : System.Object
{
	WizardGames.Soc.Common.Data.DataItem.ItemConfig matItemConfig; // 0x10
	FairyGUI.GComponent comItem; // 0x18
	WizardGames.Soc.SocClient.Ui.UiCraftBlueprintInfo <>4__this; // 0x20
	System.Action <>9__1; // 0x28
	System.Void .ctor(); // 0x05ed9040
	System.Void <MatItemRender>b__0(FairyGUI.EventContext ctx); // 0x05ed90a8
	System.Void <MatItemRender>b__1(); // 0x05ed922c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftBlueprintInfo.<>c__DisplayClass83_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiCraftBlueprintInfo <>4__this; // 0x10
	FairyGUI.GComponent skinItem; // 0x18
	System.Boolean isNewSkin; // 0x20
	System.Int64 skinID; // 0x28
	WizardGames.Soc.Common.Data.DataItem.SkinConfig skinConfig; // 0x30
	FairyGUI.EventCallback0 <>9__1; // 0x38
	System.Void .ctor(); // 0x05ed92dc
	System.Void <OnSkinItemRenderer>b__0(); // 0x05ed9344
	System.Void <OnSkinItemRenderer>b__1(); // 0x05ed99a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftBlueprintList : System.Object
{
	FairyGUI.GList listIcon; // 0x10
	FairyGUI.GList normalLst; // 0x18
	WizardGames.Soc.SocClient.Ui.UiCraftMainCom mainBoard; // 0x20
	WizardGames.Soc.SocClient.Ui.UiCraftMainCom.AvaliableTypeInfo curCraft; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.blueprintData.Blueprint> canList; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.blueprintData.Blueprint> cannotList; // 0x38
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.Common.Data.blueprintData.Blueprint>> dataDic; // 0x40
	WizardGames.Soc.Common.Data.blueprintData.Blueprint curChooseBlueprint; // 0x48
	WizardGames.Soc.SocClient.Ui.UiCraftBlueprintInfo infoBoard; // 0x50
	WizardGames.Soc.SocClient.Ui.UiCraftBlueprintQueue queue; // 0x58
	System.Boolean isStarClicked; // 0x60
	System.Int32 currentClickType; // 0x64
	System.Int64 chooseBpID; // 0x68
	System.Boolean needPlayAnim; // 0x70
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiCraftMainCom main, FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.UiCraftBlueprintInfo infoBoard, WizardGames.Soc.SocClient.Ui.UiCraftBlueprintQueue queue); // 0x05ed9ad0
	FairyGUI.GObject CustomPoolGetter(System.String url); // 0x05ed9e74
	System.Void CustomPoolReturnner(FairyGUI.GObject obj); // 0x05eda050
	System.Void Refresh(); // 0x05eda178
	System.Void SetData(WizardGames.Soc.SocClient.Ui.UiCraftMainCom.AvaliableTypeInfo craft, System.Boolean isManualClick, System.Int64 chooseBpID); // 0x05eda1e8
	System.Void ProcessData(WizardGames.Soc.SocClient.Ui.UiCraftMainCom.AvaliableTypeInfo craft); // 0x05eda694
	System.Void PopulateBlueprintsForRecommend(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.BlueprintClient>& blueprintsModels, System.Collections.Generic.HashSet<System.Int64>& commonHashSet, System.Collections.Generic.HashSet<System.Int64>& favorHashSet); // 0x05edb4c4
	System.Void AddBlueprintsToDictionary(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.BlueprintClient> blueprints, System.Collections.Generic.HashSet<System.Int64> hashSet, System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.BlueprintClient> allDic); // 0x05edbed0
	System.Void InitializeLists(); // 0x05edb6d4
	System.Void ClassifyBlueprints(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.BlueprintClient> blueprintsModels); // 0x05edb838
	System.Void SortAndCategorizeBlueprints(System.Comparison<WizardGames.Soc.Common.Data.blueprintData.Blueprint> compare, WizardGames.Soc.SocClient.Ui.UiCraftMainCom.AvaliableTypeInfo craft, System.Boolean isRecommend, System.Collections.Generic.HashSet<System.Int64> commonHashSet, System.Collections.Generic.HashSet<System.Int64> favorHashSet); // 0x05edbcd8
	System.Void AddSearchResultToDataDic(System.Collections.Generic.HashSet<System.Int32> subTypeSet); // 0x05edc404
	System.Void AddTargetResultToDataDic(System.Collections.Generic.HashSet<System.Int32> subTypeSet); // 0x05edc7c4
	System.Void AddBlueprintsToDataDic(System.Collections.Generic.List<WizardGames.Soc.Common.Data.blueprintData.Blueprint> blueprints, System.Collections.Generic.HashSet<System.Int32> subTypeSet, System.Boolean isRecommend, System.Collections.Generic.HashSet<System.Int64> commonHashSet, System.Collections.Generic.HashSet<System.Int64> favorHashSet); // 0x05edc124
	System.Void AddToRecommendationGroups(WizardGames.Soc.Common.Data.blueprintData.Blueprint bp, System.Collections.Generic.HashSet<System.Int64> commonHashSet, System.Collections.Generic.HashSet<System.Int64> favorHashSet); // 0x05edcdd4
	System.Void AddBlueprintToGroup(WizardGames.Soc.Common.Data.blueprintData.Blueprint bp, System.Collections.Generic.HashSet<System.Int64> hashSet, System.Int32 subTypeId); // 0x05edd000
	System.Comparison<WizardGames.Soc.Common.Data.blueprintData.Blueprint> GetCompare(); // 0x05edbbd0
	System.Void TryAddData(System.Int32 subTypeId, WizardGames.Soc.Common.Data.blueprintData.Blueprint bp); // 0x05edcc90
	System.Boolean CheckFilterCondition(WizardGames.Soc.Common.Data.blueprintData.Blueprint bp); // 0x05edd17c
	WizardGames.Soc.Common.Data.blueprintData.Blueprint FindTargetBlueprint(System.Int32& index, System.Int32& subIndex, System.Boolean& isRecommend, System.Int64 targetId); // 0x05eda950
	System.Void CraftIconRender(System.Int32 index, FairyGUI.GObject item); // 0x05edd4a0
	System.Void RenderOneIconItem(WizardGames.Soc.SocClient.Ui.ComItemCardDisplay comItem, WizardGames.Soc.Common.Data.blueprintData.Blueprint blueprint, System.Int32 index, System.Int32 typeId, System.Boolean isLast); // 0x05ede130
	System.Void ScrollToItemAtTop(System.Int32 index, System.Int32 subIndex); // 0x05edafe8
	System.Void OnScroll(); // 0x05ede854
	System.Void OnBlueprintUpdate(); // 0x05edebd8
	System.Void OnClickStar(WizardGames.Soc.Common.Data.blueprintData.Blueprint blueprint, System.Boolean newState); // 0x05ededc4
	System.Void OnClickBlueprint(WizardGames.Soc.Common.Data.blueprintData.Blueprint blueprint, System.Int32 typeId, System.Boolean isManualClick); // 0x05edae28
	System.Void RefreshList(); // 0x05eded0c
	FairyGUI.GObject GetGuideObjByID(System.Int64 id); // 0x05edf100
	System.Void .ctor(); // 0x05edf3f8
	FairyGUI.GObject <CustomPoolGetter>b__15_0(System.String url); // 0x05edf470
	System.Void <CustomPoolGetter>b__15_1(FairyGUI.GObject obj); // 0x05edf5e4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftBlueprintList.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiCraftBlueprintList.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.Data.blueprintData.Blueprint> <>9__30_0; // 0x8
	static System.Void .cctor(); // 0x05edf750
	System.Void .ctor(); // 0x05edf7b4
	System.Int32 <GetCompare>b__30_0(WizardGames.Soc.Common.Data.blueprintData.Blueprint a, WizardGames.Soc.Common.Data.blueprintData.Blueprint b); // 0x05edf81c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftBlueprintList.<>c__DisplayClass35_0 : System.Object
{
	System.Boolean isLast; // 0x10
	WizardGames.Soc.SocClient.Ui.UiCraftBlueprintList <>4__this; // 0x18
	System.Int32 typeId; // 0x20
	WizardGames.Soc.Common.Data.blueprintData.Blueprint blueprint; // 0x28
	System.Boolean isCollected; // 0x30
	System.Void .ctor(); // 0x05ede7ec
	System.Void <RenderOneIconItem>b__0(); // 0x05edfa20
	System.Void <RenderOneIconItem>b__1(); // 0x05edfa98
	System.Void <RenderOneIconItem>b__2(); // 0x05edfb10
	System.Void <RenderOneIconItem>b__3(); // 0x05edfba4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftBlueprintQueue : System.Object
{
	FairyGUI.GList listIcons; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComRecipeInQueue> queueNodes; // 0x18
	FairyGUI.GTextField textTitle; // 0x20
	WizardGames.Soc.SocClient.Ui.UiCraftMainCom mainBoard; // 0x28
	FairyGUI.GComponent comRoot; // 0x30
	System.Int32 lastQueueCount; // 0x38
	WizardGames.Soc.SocClient.Ui.UiCraftBlueprintList craftList; // 0x40
	FairyGUI.Controller ctrlQueue; // 0x48
	System.String titleStr; // 0x50
	WizardGames.Soc.Common.CustomType.StackableItemNode fakeItemNode; // 0x58
	System.Int32 get_QueueLen(); // 0x05edfc20
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiCraftMainCom main, FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.UiCraftBlueprintList list); // 0x05edfca0
	System.Void OnQueueUpdate(System.Boolean isOpen); // 0x05ee0414
	System.Void OnCraftQueueCancelFail(System.Int32 errorCode); // 0x05ee0d04
	System.Void OnClickIconCancel(System.Int32 index); // 0x05ee0d80
	System.Void OnClickIconClaime(WizardGames.Soc.SocClient.Ui.ComRecipeInQueue icon); // 0x05ee109c
	System.Boolean IsBagFull(WizardGames.Soc.Common.Data.DataItem.ItemConfig config, System.Int32 count); // 0x05ee16d8
	System.Void UpdateTimer(); // 0x05ee1858
	System.Void DoUpdate(); // 0x05ee18ec
	System.Void .ctor(); // 0x05ee1b58
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftBlueprintQueue.<>c__DisplayClass15_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComRecipeInQueue node; // 0x10
	System.Int32 queueIndex; // 0x18
	WizardGames.Soc.SocClient.Ui.UiCraftBlueprintQueue <>4__this; // 0x20
	System.Void .ctor(); // 0x05ee03ac
	System.Void <Bind>b__0(); // 0x05ee1bc0
	System.Void <Bind>b__1(FairyGUI.EventContext ctx); // 0x05ee1c30
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftBlueprintQueue.<>c__DisplayClass16_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComRecipeInQueue lastNode; // 0x10
	System.Single oldValue; // 0x18
	System.Void .ctor(); // 0x05ee0c9c
	System.Void <OnQueueUpdate>b__0(); // 0x05ee1cb4
	System.Void <OnQueueUpdate>b__1(); // 0x05ee1d30
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftBlueprintQueue.<>c__DisplayClass18_0 : System.Object
{
	System.Int32 index; // 0x10
	WizardGames.Soc.SocClient.Ui.UiCraftBlueprintQueue <>4__this; // 0x18
	WizardGames.Soc.SocClient.Ui.ComRecipeInQueue nodeData; // 0x20
	System.Void .ctor(); // 0x05ee1034
	System.Void <OnClickIconCancel>b__0(); // 0x05ee1da4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftBlueprintQueue.<>c__DisplayClass19_0 : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.CommonComposeElemClient> queue; // 0x10
	System.Void .ctor(); // 0x05ee1670
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftBlueprintQueue.<>c__DisplayClass19_1 : System.Object
{
	System.Int32 i1; // 0x10
	WizardGames.Soc.SocClient.Ui.UiCraftBlueprintQueue.<>c__DisplayClass19_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x05ee17f0
	System.Void <OnClickIconClaime>b__0(); // 0x05ee1eb0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftBlueprintSearch : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiCraftMainCom mainBoard; // 0x10
	FairyGUI.GComponent comRoot; // 0x18
	WizardGames.Soc.SocClient.Ui.UiCraftBlueprintList craftList; // 0x20
	FairyGUI.GButton btnFilter; // 0x28
	FairyGUI.Controller btnFilterCtrl; // 0x30
	FairyGUI.GTextInput inputSearch; // 0x38
	FairyGUI.Controller ctrlSearchState; // 0x40
	FairyGUI.GButton btnClearInput; // 0x48
	FairyGUI.GList resultList; // 0x50
	FairyGUI.GTextField txtUnlock; // 0x58
	FairyGUI.GButton btnUnlock; // 0x60
	FairyGUI.GTextField txtWorkbench; // 0x68
	FairyGUI.GButton btnWorkbench; // 0x70
	FairyGUI.GTextField txtMaterial; // 0x78
	FairyGUI.GButton btnMaterial; // 0x80
	FairyGUI.Controller ctrlState; // 0x88
	System.String CraftFilterUnlockKey; // 0x90
	System.String CraftFilterWorkbenchKey; // 0x98
	System.String CraftFilterMaterialKey; // 0xa0
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.blueprintData.Blueprint> canMakeList; // 0xa8
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.blueprintData.Blueprint> cannotMakeList; // 0xb0
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.blueprintData.Blueprint> searchResult; // 0xb8
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiCraftMainCom main, FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.UiCraftBlueprintList list); // 0x05ee1ffc
	System.Void Init(); // 0x05ee2668
	System.Void OnBtnFilterClick(FairyGUI.EventContext context); // 0x05ee2d10
	System.Void OnInputChanged(FairyGUI.EventContext context); // 0x05ee2ebc
	System.Void OnBtnClearInputClick(FairyGUI.EventContext context); // 0x05ee34d8
	System.Void OnFilterItemBtnClick(FairyGUI.EventContext context); // 0x05ee35d4
	System.Void ShowSearchResult(); // 0x05ee30f0
	System.Void TryHideSearch(); // 0x05ee3a50
	System.Void SwitchState(System.String page); // 0x05ee2c14
	System.Void RenderListItem(System.Int32 index, FairyGUI.GObject item); // 0x05ee3b58
	System.Void ClearSearchResult(); // 0x05ee38b8
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.blueprintData.Blueprint> GetSearchResult(); // 0x05ee3e74
	System.Boolean IsDisplaylock(); // 0x05ee3ed8
	System.Boolean IsDisplayWorkbenchNotEnough(); // 0x05ee3f7c
	System.Boolean IsDisplayMaterialNotEnough(); // 0x05ee4020
	System.Void GenerateSearchResult(); // 0x05ee395c
	System.Void DoSearch(System.Collections.Generic.List<WizardGames.Soc.Common.Data.blueprintData.Blueprint> lst, System.String input); // 0x05ee4528
	System.Boolean IsMatch(WizardGames.Soc.Common.Data.blueprintData.Blueprint data, System.String key); // 0x05ee4738
	System.Void FilterBlueprints(); // 0x05ee40c4
	System.Void .ctor(); // 0x05ee485c
	System.Void <Init>b__23_0(FairyGUI.EventContext context); // 0x05ee49d0
	System.Void <Init>b__23_1(FairyGUI.EventContext context); // 0x05ee4a74
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftBlueprintSearch.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiCraftBlueprintSearch.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__23_2; // 0x8
	static System.Void .cctor(); // 0x05ee4b50
	System.Void .ctor(); // 0x05ee4bb4
	System.Void <Init>b__23_2(FairyGUI.EventContext context); // 0x05ee4c1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftBlueprintSearch.<>c__DisplayClass31_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiCraftBlueprintSearch <>4__this; // 0x10
	WizardGames.Soc.Common.Data.blueprintData.Blueprint curBlueprint; // 0x18
	System.Void .ctor(); // 0x05ee3e0c
	System.Void <RenderListItem>b__0(); // 0x05ee4ca0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftBlueprintSkinPopup : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.UiCraft mainUi; // 0x338
	WizardGames.Soc.Common.Data.blueprintData.Blueprint curBlueprint; // 0x340
	FairyGUI.GTextField textTitle; // 0x348
	FairyGUI.GTextField textSkinCount; // 0x350
	FairyGUI.GList listSkin; // 0x358
	FairyGUI.Controller controller; // 0x360
	System.Collections.Generic.List<System.Int64> skinList; // 0x368
	System.Int32 currentHasSkinCount; // 0x370
	System.Int32 minDisplayNum; // 0x374
	System.Void OnInit(); // 0x05ee5ba4
	System.Void InitUIComponent(); // 0x05ee5cf0
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiCraft mainUi, WizardGames.Soc.Common.Data.blueprintData.Blueprint blueprint); // 0x05ee5ef0
	System.Void Init(); // 0x05ee5f90
	System.Void Update(); // 0x05ee617c
	System.Void GetSkinData(); // 0x05ee6278
	System.Void RenderSkinItem(System.Int32 index, FairyGUI.GObject item); // 0x05ee678c
	System.Void OnItemClick(System.Int64 skinID); // 0x05ee6c34
	System.Void UpdateSkinNum(); // 0x05ee667c
	System.Void Show(); // 0x05ee7028
	System.Void Hide(); // 0x05ee6fbc
	System.Void .ctor(); // 0x05ee70f4
	System.Void <OnInit>b__9_0(); // 0x05ee71d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftBlueprintSkinPopup.<>c__DisplayClass14_0 : System.Object
{
	System.Int64 currentSelectedSkin; // 0x10
	System.Void .ctor(); // 0x05ee6724
	System.Int32 <GetSkinData>b__0(System.Int64 a, System.Int64 b); // 0x05ee72ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftBlueprintSkinPopup.<>c__DisplayClass15_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiCraftBlueprintSkinPopup <>4__this; // 0x10
	System.Int64 skinId; // 0x18
	System.Void .ctor(); // 0x05ee6bcc
	System.Void <RenderSkinItem>b__0(); // 0x05ee754c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftBlueprintTechLevelPopup : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.UiCraft mainUi; // 0x338
	FairyGUI.GLoader techLevel1IconLoader; // 0x340
	FairyGUI.GTextField techLevel1Name; // 0x348
	FairyGUI.GTextField techLevel1Desc; // 0x350
	FairyGUI.GButton btnGotoUnlock1; // 0x358
	FairyGUI.Controller techLevel1Control; // 0x360
	FairyGUI.GLoader techLevel2IconLoader; // 0x368
	FairyGUI.GTextField techLevel2Name; // 0x370
	FairyGUI.GTextField techLevel2Desc; // 0x378
	FairyGUI.GButton btnGotoUnlock2; // 0x380
	FairyGUI.Controller techLevel2Control; // 0x388
	FairyGUI.GLoader techLevel3IconLoader; // 0x390
	FairyGUI.GTextField techLevel3Name; // 0x398
	FairyGUI.GTextField techLevel3Desc; // 0x3a0
	FairyGUI.GButton btnGotoUnlock3; // 0x3a8
	FairyGUI.Controller techLevel3Control; // 0x3b0
	System.Void OnInit(); // 0x05ee75bc
	System.Void OnEnable(); // 0x05ee7db4
	System.Void InitUIComponent(); // 0x05ee7708
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiCraft mainUi); // 0x05ee7e8c
	System.Void Init(); // 0x05ee7f14
	System.Void OnBtnGotoUnlockClick(System.Int32 index); // 0x05ee8564
	System.Void .ctor(); // 0x05ee862c
	System.Void <OnInit>b__16_0(); // 0x05ee86b8
	System.Void <InitUIComponent>b__18_0(); // 0x05ee8790
	System.Void <InitUIComponent>b__18_1(); // 0x05ee87fc
	System.Void <InitUIComponent>b__18_2(); // 0x05ee8864
	System.Void <InitUIComponent>b__18_3(); // 0x05ee88cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftMainCom : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiCraftMainCom.AvaliableTypeInfo> availableTypes; // 0x10
	WizardGames.Soc.SocClient.Ui.UiCraftBlueprintList blueprintList; // 0x18
	WizardGames.Soc.SocClient.Ui.UiCraftBlueprintInfo blueprintInfo; // 0x20
	WizardGames.Soc.SocClient.Ui.UiCraftBlueprintQueue blueprintQueue; // 0x28
	WizardGames.Soc.SocClient.Ui.UiCraftBlueprintSearch blueprintSearch; // 0x30
	FairyGUI.GButton btnQuickCraft; // 0x38
	FairyGUI.GTextField quickCraftCount; // 0x40
	WizardGames.Soc.SocClient.Ui.UiCraftMainCom.AvaliableTypeInfo curChooseMainType; // 0x48
	WizardGames.Soc.SocClient.Ui.UiCraft winCraft; // 0x50
	System.Boolean isFolded; // 0x58
	FairyGUI.Transition animShow; // 0x60
	FairyGUI.Transition animHide; // 0x68
	FairyGUI.GComponent comRoot; // 0x70
	FairyGUI.GList comPoolList; // 0x78
	System.Boolean get_IsShow(); // 0x05ee8934
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiCraft mainBoard, FairyGUI.GComponent com); // 0x05ee89bc
	System.Void InitNavTabNew(); // 0x05ee8b34
	WizardGames.Soc.SocClient.Ui.UiCraftMainCom.AvaliableTypeInfo GetMainType(System.Int32 groupId); // 0x05ee9f94
	System.Void Load(); // 0x05eea0f8
	System.Void ClearPool(); // 0x05eea4c4
	FairyGUI.GObject GetFromPool(System.String url); // 0x05edf4f4
	System.Void ReturnToPool(FairyGUI.GObject obj); // 0x05edf668
	System.Void StopAnims(); // 0x05eea53c
	System.Void PlayAnim(System.Boolean isShow); // 0x05eea5d0
	System.Void OnEnable(); // 0x05eea680
	System.Void OnDisable(); // 0x05eea958
	System.Void DoUpdate(); // 0x05eea9d8
	System.Void Refresh(); // 0x05eeaa58
	System.Void RefreshTabs(System.Int64 tarBpID); // 0x05ee4d20
	System.Void SetNavTabSelectedIndex(System.Int32 mainTypeId, System.Int32 subTypeId); // 0x05edb3c0
	System.Void RefreshTrackDot(); // 0x05eeac8c
	System.Void GenerateTabData(System.Int64 tarBpID); // 0x05ee93c0
	System.Void OnBtnQuickCraftClick(); // 0x05eeaec0
	System.Void RefreshSubTypeList(System.Boolean isManualClick, System.Int64 tarBpID); // 0x05eeafec
	System.Void OnQueueUpdate(); // 0x05eeb190
	System.Void OnCraftQueueCancelFail(System.Int32 errorCode); // 0x05eeb228
	System.Void OnInventortUpdate(); // 0x05eeb2ac
	System.Void OnBlueprintUpdate(); // 0x05eeb37c
	System.Void OnMainTypeClick(WizardGames.Soc.SocClient.Ui.UiCraftMainCom.AvaliableTypeInfo mainCraftType, System.Boolean isManualClick); // 0x05eeb410
	System.Void OnSubTypeClick(System.Int32 typeId); // 0x05eeb53c
	System.Void OnClickMainTab(WizardGames.Soc.SocClient.Ui.UiCraftMainCom.AvaliableTypeInfo craft, System.Boolean isManualClick, System.Int64 tarBpID); // 0x05eead04
	System.Void OnClickSubTab(System.Boolean isManualClick, System.Int64 tarBpID); // 0x05eeb098
	static System.Int32 GetMaxWorktableLevel(); // 0x05ee843c
	WizardGames.Soc.SocClient.Ui.UiCraftBlueprintList GetBlueprintsList(); // 0x05eeb610
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.blueprintData.Blueprint> GetSearchResult(); // 0x05edcbec
	System.Void ClearSearchResult(); // 0x05eeb4d0
	System.Boolean IsDisplaylock(); // 0x05edd35c
	System.Boolean IsDisplayWorkbenchNotEnough(); // 0x05edd3c8
	System.Boolean IsDisplayMaterialNotEnough(); // 0x05edd434
	System.Void HideSearch(); // 0x05eeb674
	System.Void OnlyRefreshCurrentList(); // 0x05eeb6e8
	System.Void ShowSkinPopup(WizardGames.Soc.Common.Data.blueprintData.Blueprint blueprint); // 0x05eeb784
	FairyGUI.GObject GetGuideObjByID(System.Int64 id); // 0x05eeb818
	System.Void UpdateQuickCraftBtn(); // 0x05eea6f8
	System.Void .ctor(); // 0x05eeb89c
	System.Void <InitNavTabNew>b__20_0(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean b); // 0x05eeb950
	System.Void <Load>b__22_0(); // 0x05eebc28
	System.Void <OnBtnQuickCraftClick>b__37_0(WizardGames.Soc.SocClient.Ui.UiCraftBlueprintCollectPopup win); // 0x05eebc8c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftMainCom.AvaliableTypeInfo : System.Object
{
	WizardGames.Soc.SocClient.Ui.BlueprintMainType mainType; // 0x10
	System.Int32 count; // 0x18
	System.Boolean hasNew; // 0x1c
	System.Collections.Generic.List<System.Int32> avaliableSubTypes; // 0x20
	System.Int32 curSubTypeIndex; // 0x28
	System.Int32 GetSubType(System.Int32 index); // 0x05edb2f4
	System.Int32 GetCurSubType(); // 0x05edb45c
	System.Void .ctor(); // 0x05eeabd8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftMainCom.<>c__DisplayClass33_0 : System.Object
{
	System.Int64 tarBpID; // 0x10
	System.Void .ctor(); // 0x05eeab70
	System.Boolean <RefreshTabs>b__0(WizardGames.Soc.SocClient.Ui.BlueprintClient model); // 0x05eebd7c
	System.Boolean <RefreshTabs>b__1(WizardGames.Soc.SocClient.Ui.BlueprintClient model); // 0x05eebe10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCraftMainCom.<>c__DisplayClass36_0 : System.Object
{
	System.Int64 tarBpID; // 0x10
	System.Void .ctor(); // 0x05eeae58
	System.Boolean <GenerateTabData>b__0(WizardGames.Soc.SocClient.Ui.BlueprintClient model); // 0x05eebea4
	System.Boolean <GenerateTabData>b__1(WizardGames.Soc.SocClient.Ui.BlueprintClient model); // 0x05eebf38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChangePlayerAppearance : WizardGames.Soc.SocClient.Ui.UiCreateRole
{
	UnityEngine.GameObject objPlayerModel; // 0x410
	System.Void InitPlayerModel(); // 0x05eebfcc
	System.Void SetTitle(); // 0x05eec628
	System.Void ChangeAppearance(WizardGames.Soc.SocClient.Ui.PlayerAppearanceInfo info); // 0x05eec7b4
	System.Void InitDefaultData(); // 0x05eec95c
	System.Void RealseDisplayModel(); // 0x05eeca0c
	System.Void EnablePreviewScene(); // 0x05eecb64
	System.Void DisablePreviewScene(); // 0x05eeccf8
	System.Void ShowStep2(); // 0x05eecd9c
	System.Int32 GetDefaultFaceIndex(); // 0x05eece70
	System.Void InitPanelType(); // 0x05eecf98
	System.Void PlayCreateRoleMusic(); // 0x05eed148
	System.Void UnLoadMusic(); // 0x05eed1a8
	System.Void OnClickClose(); // 0x05eed208
	System.Void .ctor(); // 0x05eed67c
	System.Void <EnablePreviewScene>b__6_0(UnityEngine.GameObject a, UnityEngine.GameObject b); // 0x05eedc7c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ECreateRoleType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ECreateRoleType CreateRole = 0;
	static WizardGames.Soc.SocClient.Ui.ECreateRoleType ChangePlayerAppearance = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCreateRole : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	SocLogger logger; // 0x338
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>> faceInfo; // 0x340
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>> hairInfo; // 0x348
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>> hairColorInfo; // 0x350
	System.Collections.Generic.List<System.String> tabTitle; // 0x358
	System.Collections.Generic.List<System.String> tabIconUrl; // 0x360
	System.Collections.Generic.List<System.Boolean> lockType; // 0x368
	WizardGames.Soc.SocClient.Ui.Binder.LobbyCreateRole.UiCreateRoleBinder binder; // 0x370
	WizardGames.Soc.SocClient.Ui.PlayerAppearanceInfo info; // 0x378
	WizardGames.Soc.SocClient.Ui.ComUiPlayerModel uiPlayerModel; // 0x380
	FairyGUI.GTextInput inputBox; // 0x388
	WizardGames.Soc.SocClient.GoLoader.DisplayModel displayModel; // 0x390
	UnityEngine.Vector2 lastTouchPos; // 0x398
	System.Boolean IsTouchingModel; // 0x3a0
	WizardGames.Soc.SocClient.Ui.ComStateBtn finishBtn; // 0x3a8
	WizardGames.Soc.SocClient.Ui.ECreateRoleType type; // 0x3b0
	System.Int32 selectedTabIndex; // 0x3b4
	System.Int32 createRoleStep; // 0x3b8
	System.Boolean lastMultiTouchEnabled; // 0x3bc
	System.Int32 selectFaceIndex; // 0x3c0
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,FairyGUI.GObject>> coms; // 0x3c8
	System.Boolean scorlling; // 0x3d0
	UnityEngine.Transform playerLoader; // 0x3d8
	UnityEngine.Transform transLobbyPlayer; // 0x3e0
	WizardGames.Soc.Common.CustomType.PlayerDisplayData displayData; // 0x3e8
	System.Int32 selectHairColorIndex; // 0x3f0
	System.Int32 selectHairIndex; // 0x3f4
	UnityEngine.Camera sceneCamrea; // 0x3f8
	System.Int32 cameraTrack; // 0x400
	System.Boolean isCd; // 0x404
	System.Int32 hairColumnCount; // 0x408
	System.Void OnInit(); // 0x05eede44
	System.Void ChangeNameError(System.Int32 errorId); // 0x05eefe28
	System.Void MakeFullScreen(); // 0x05ef10a8
	System.Void InitPanelType(); // 0x05ef1128
	System.Void InitDefaultData(); // 0x05ef1188
	System.Void InitUIComponent(); // 0x05eee058
	System.Void onClickSex(FairyGUI.EventContext context, FairyGUI.GList tabList); // 0x05ef2390
	System.Void DoSpecialEffect(); // 0x05ef343c
	System.Void ReqChangeNameError(); // 0x05ef47d0
	System.Void SetPlaySound(); // 0x05ef11ec
	System.Void PlayInputBoxEffect(); // 0x05ef4890
	System.Void InitData(); // 0x05eefa64
	System.Void InitPlayerModel(); // 0x05ef4a8c
	System.Void PutOn(System.Collections.Generic.List<System.Int32> itemIds, System.Collections.Generic.List<System.Int32> skinIds); // 0x05eec458
	System.Void ChangeAppearance(WizardGames.Soc.SocClient.Ui.PlayerAppearanceInfo info); // 0x05eec874
	System.Void RealseDisplayModel(); // 0x05eecab8
	System.Boolean IsInputNameLegal(); // 0x05ef4f48
	System.Void FirstSetNickname(System.String firstName); // 0x05ef5010
	System.Void RefreshChangeNameSuccess(System.String newName); // 0x05ef5418
	System.Void RenderHairColorItem(System.Int32 index, FairyGUI.GObject item); // 0x05ef55c0
	System.Void RenderHairItem(System.Int32 index, FairyGUI.GObject item); // 0x05ef590c
	System.Void SetCreateRoleStep(System.Boolean first); // 0x05eed330
	System.Void ShowStep2(); // 0x05ef7a04
	System.Void ShowCreateRoleEnd(); // 0x05ef7c64
	System.Void RefreshRoleInfo(); // 0x05ef5d2c
	System.Void ShowRoleSelect(System.Int32 selectedTabIndex); // 0x05ef2668
	System.Int32 GetDefaultFaceIndex(); // 0x05ef83e4
	System.Void RefreshSelectRole(); // 0x05ef5cbc
	System.Void RefreshSelctRoleInfo(); // 0x05ef844c
	System.Void OnEnable(); // 0x05ef89fc
	System.Void SetTitle(); // 0x05ef8d94
	System.Void OnDisable(); // 0x05ef8f4c
	System.Void PlayCreateRoleMusic(); // 0x05ef9124
	System.Void UnLoadMusic(); // 0x05ef91dc
	System.Void OnDestroy(); // 0x05ef9264
	System.Void SetCamreaTrack(System.Int32 track); // 0x05ef92c8
	System.Void RenderTabItem(System.Int32 index, FairyGUI.GObject obj); // 0x05ef971c
	System.Void OnClickClose(); // 0x05ef9914
	System.Void ReturnLogin(); // 0x05ef9b98
	System.Void OnInputNameChanged(); // 0x05ef2328
	System.Void OnInputNameChanged(System.Boolean showTip); // 0x05ef031c
	System.Void OnModeTouchBegin(FairyGUI.EventContext ctx); // 0x05ef9c7c
	System.Void OnModeTouchMove(FairyGUI.EventContext ctx); // 0x05ef9d68
	System.Void OnModeTouchEnd(FairyGUI.EventContext ctx); // 0x05ef9f08
	System.Void DisablePreviewScene(); // 0x05ef9f80
	System.Void EnablePreviewScene(); // 0x05ef9fe0
	System.Void InitListAvatar(); // 0x05ef16f4
	System.Void OnClickItem(FairyGUI.EventContext context); // 0x05efa040
	System.Int32 GetFaceInfoCount(System.Int32 selectedTabIndex); // 0x05ef8170
	System.Void RenderListItem(System.Int32 index, FairyGUI.GObject obj); // 0x05efa6a0
	System.Void AvatarScrollToView(System.Int32 selectFaceIndex); // 0x05ef8224
	System.Void DoScrollEnd(FairyGUI.EventContext context); // 0x05efacc4
	System.Void ScrollEnd(System.Int32 index); // 0x05efb088
	System.Void SetBottomBarVisible(); // 0x05ef5c5c
	System.Void .ctor(); // 0x05eed6e0
	System.Void <OnClickClose>b__70_0(); // 0x05efb828
	System.Void <OnInputNameChanged>b__74_0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x05efb88c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCreateRole.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiCreateRole.<>c <>9; // 0x0
	static FairyGUI.TransitionHook <>9__33_0; // 0x8
	static FairyGUI.TransitionHook <>9__33_1; // 0x10
	static System.Action <>9__48_2; // 0x18
	static System.Action <>9__53_2; // 0x20
	static System.Action<WizardGames.Soc.SocClient.Ui.UiCreateRoleCG> <>9__53_1; // 0x28
	static FairyGUI.PlayCompleteCallback <>9__53_0; // 0x30
	static FairyGUI.ListItemRenderer <>9__55_0; // 0x38
	static System.Void .cctor(); // 0x05efb9e8
	System.Void .ctor(); // 0x05efba4c
	System.Void <SetPlaySound>b__33_0(); // 0x05efbab4
	System.Void <SetPlaySound>b__33_1(); // 0x05efbb54
	System.Void <RefreshChangeNameSuccess>b__48_2(); // 0x05efbbf4
	System.Void <ShowCreateRoleEnd>b__53_0(); // 0x05efbc54
	System.Void <ShowCreateRoleEnd>b__53_1(WizardGames.Soc.SocClient.Ui.UiCreateRoleCG win); // 0x05efbe34
	System.Void <ShowCreateRoleEnd>b__53_2(); // 0x05efbf60
	System.Void <ShowRoleSelect>b__55_0(System.Int32 a, FairyGUI.GObject b); // 0x05efbffc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCreateRole.<>c__DisplayClass26_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiCreateRole <>4__this; // 0x10
	FairyGUI.GList tabList; // 0x18
	FairyGUI.GList hairList; // 0x20
	FairyGUI.GList hairColorList; // 0x28
	System.Action <>9__9; // 0x30
	System.Action <>9__10; // 0x38
	System.Void .ctor(); // 0x05efc078
	System.Void <InitUIComponent>b__0(FairyGUI.EventContext _); // 0x05efc0e0
	System.Void <InitUIComponent>b__1(FairyGUI.EventContext _); // 0x05efc188
	System.Void <InitUIComponent>b__2(FairyGUI.EventContext _); // 0x05efc234
	System.Void <InitUIComponent>b__9(); // 0x05efc364
	System.Void <InitUIComponent>b__3(FairyGUI.EventContext _); // 0x05efc460
	System.Void <InitUIComponent>b__10(); // 0x05efc810
	System.Void <InitUIComponent>b__4(FairyGUI.EventContext c); // 0x05efc908
	System.Void <InitUIComponent>b__5(FairyGUI.EventContext context); // 0x05efc994
	System.Void <InitUIComponent>b__6(FairyGUI.EventContext context); // 0x05efca20
	System.Void <InitUIComponent>b__7(FairyGUI.EventContext context); // 0x05efcaac
	System.Void <InitUIComponent>b__8(FairyGUI.EventContext context); // 0x05efcc80
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCreateRole.<>c__DisplayClass46_0 : System.Object
{
	System.String firstName; // 0x10
	WizardGames.Soc.SocClient.Ui.UiCreateRole <>4__this; // 0x18
	System.Void .ctor(); // 0x05efce54
	System.Void <FirstSetNickname>b__0(SimpleJSON.JSONNode res); // 0x05efcebc
	System.Void <FirstSetNickname>b__1(SimpleJSON.JSONNode error); // 0x05efd044
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCreateRole.<>c__DisplayClass48_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiCreateRole <>4__this; // 0x10
	System.String newName; // 0x18
	System.Action<SimpleJSON.JSONNode> <>9__1; // 0x20
	System.Void .ctor(); // 0x05efd14c
	System.Void <RefreshChangeNameSuccess>b__0(); // 0x05efd1b4
	System.Void <RefreshChangeNameSuccess>b__1(SimpleJSON.JSONNode json); // 0x05efd438
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCreateRole.<>c__DisplayClass85_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiCreateRole <>4__this; // 0x10
	System.Int32 selectFaceIndex; // 0x18
	System.Void .ctor(); // 0x05efd630
	System.Void <AvatarScrollToView>b__0(System.Int64 _, System.Object __, System.Boolean ___); // 0x05efd698
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCreateRole.<>c__DisplayClass87_0 : System.Object
{
	System.Int32 sex; // 0x10
	WizardGames.Soc.SocClient.Ui.UiCreateRole <>4__this; // 0x18
	System.Void .ctor(); // 0x05efda9c
	System.Void <ScrollEnd>b__0(); // 0x05efdb04
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCreateRoleCG : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyCreateRoleCG.UiCreateRoleCGBinder uiCreateRoleCGBinder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComVideo videoPlayer; // 0x340
	System.String videoName; // 0x348
	System.Action closeCb; // 0x350
	System.Int64 delayShowCloseBtnTimerID; // 0x358
	System.Void MakeFullScreen(); // 0x05efdc18
	System.Void OnInit(); // 0x05efdcec
	System.Void InitVideoUI(); // 0x05efdd64
	System.Void RegisterSkipBtnAction(); // 0x05efe08c
	System.Void OnEnable(); // 0x05efe238
	System.Void OnDisable(); // 0x05efe8fc
	System.Void OnDestroy(); // 0x05efeb30
	System.Void PlayVideo(); // 0x05efe3cc
	static WizardGames.Soc.SocClient.Ui.UiCreateRoleCG OpenWindow(System.Action<WizardGames.Soc.SocClient.Ui.UiCreateRoleCG> cb); // 0x05efbd5c
	static System.Void CloseWindow(); // 0x05efec6c
	static WizardGames.Soc.SocClient.Ui.UiCreateRoleCG GetWindow(); // 0x05efece0
	System.Void SkipBtnDelayShow(); // 0x05efe618
	System.Void OnSkipBtnClick(); // 0x05efeda0
	System.Void .ctor(); // 0x05efefb8
	System.Void <PlayVideo>b__12_0(UnityEngine.Video.VideoPlayer player); // 0x05eff070
	System.Void <PlayVideo>b__12_2(System.Object param); // 0x05eff158
	System.Void <SkipBtnDelayShow>b__17_0(System.Int64 id, System.Object data, System.Boolean delete); // 0x05eff238
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCreateRoleCG.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiCreateRoleCG.<>c <>9; // 0x0
	static System.Action<UnityEngine.Video.VideoPlayer> <>9__12_1; // 0x8
	static System.Void .cctor(); // 0x05eff3a8
	System.Void .ctor(); // 0x05eff40c
	System.Void <PlayVideo>b__12_1(UnityEngine.Video.VideoPlayer player); // 0x05eff474
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiNewbieBlockPop : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger log; // 0x0
	FairyGUI.GTextField text; // 0x338
	FairyGUI.GTextField time; // 0x340
	WizardGames.Soc.SocClient.Ui.ComModal bgCom; // 0x348
	System.Int64 timerId; // 0x350
	System.Void OnInit(); // 0x05eff4e8
	System.Void ClearTimer(); // 0x05eff848
	System.Void CloseWindow(); // 0x05eff93c
	System.Void OnClickClose(); // 0x05eff9f4
	System.Void .ctor(); // 0x05effc10
	static System.Void .cctor(); // 0x05effc9c
	System.Void <OnClickClose>b__19_0(); // 0x05effd70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCursorEffect : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GObject effectCom; // 0x338
	FairyGUI.Transition effect; // 0x340
	System.Void OnInit(); // 0x05effe78
	System.Void .ctor(); // 0x05efff90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCurtain : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GComponent curtainCom; // 0x338
	System.Void OnInit(); // 0x05f0001c
	System.Void OnEnable(); // 0x05f00120
	System.Void OnDisable(); // 0x05f00188
	System.Void MakeFullScreen(); // 0x05f001f0
	System.Void .ctor(); // 0x05f00360
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDailyMission : System.Object
{
	FairyGUI.GComponent content; // 0x10
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar selectTypeBar; // 0x18
	FairyGUI.GTextField medalNumTxt; // 0x20
	FairyGUI.GList medalLst; // 0x28
	FairyGUI.GList missionLst; // 0x30
	System.Collections.Generic.List<System.Int64> medalDataLst; // 0x38
	System.Collections.Generic.List<System.Int64> normalDataLst; // 0x40
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,System.Object>> medalGODic; // 0x48
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,System.Object>> normalGODic; // 0x50
	WizardGames.Soc.Common.Data.DailyTaskType curDailyTaskType; // 0x58
	System.Collections.Generic.Dictionary<System.Int64,FairyGUI.GTextField> loopUpdateTxtDic; // 0x60
	static System.Int64 curSelectedMedalId; // 0x0
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> lastNumDic; // 0x68
	static SocLogger logger; // 0x8
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.Binder.GameBuzzOperation.UiDailyMissionBinder binder, WizardGames.Soc.SocClient.Ui.ComTopBar topBar); // 0x05f003ec
	System.Void OnEnable(); // 0x05f00aac
	System.Void OnDisable(); // 0x05f00dfc
	System.Void OnRenderMedalItem(System.Int32 index, FairyGUI.GObject obj); // 0x05f00f48
	System.Void OnRenderNormalItem(System.Int32 index, FairyGUI.GObject obj); // 0x05f02010
	System.Void RefreshDailyMission(); // 0x05f00c58
	System.Void JumpToMission(System.Int32 missionId); // 0x05f03110
	System.Void RefreshNormalMission(); // 0x05f031f4
	System.Void OnFps1Update(System.Single dt); // 0x05f032e4
	System.Void .ctor(); // 0x05f03770
	static System.Void .cctor(); // 0x05f03988
	System.Void <OnInit>b__14_0(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x05f03a70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDailyMission.<>c__DisplayClass17_0 : System.Object
{
	WizardGames.Soc.SocClient.EDailyMissionState state; // 0x10
	FairyGUI.Controller realStateCtrl; // 0x18
	WizardGames.Soc.SocClient.Ui.UiDailyMission <>4__this; // 0x20
	System.Int32 index; // 0x28
	FairyGUI.GObject obj; // 0x30
	System.Void .ctor(); // 0x05f01fa8
	System.Void <OnRenderMedalItem>b__0(); // 0x05f03bd0
	System.Void <OnRenderMedalItem>b__1(FairyGUI.EventContext ctx); // 0x05f03c74
	System.Void <OnRenderMedalItem>b__2(FairyGUI.EventContext ctx); // 0x05f03f5c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDailyMission.<>c__DisplayClass18_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiDailyMission <>4__this; // 0x10
	System.Int32 index; // 0x18
	FairyGUI.GObject obj; // 0x20
	System.Void .ctor(); // 0x05f030a8
	System.Void <OnRenderNormalItem>b__0(FairyGUI.EventContext ctx); // 0x05f042fc
	System.Void <OnRenderNormalItem>b__1(FairyGUI.EventContext ctx); // 0x05f046b8
	System.Void <OnRenderNormalItem>b__2(FairyGUI.EventContext ctx); // 0x05f047a4
	System.Void <OnRenderNormalItem>b__3(); // 0x05f04890
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDebugInfo : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	static System.Boolean ShowLog; // 0x0
	static WizardGames.Soc.Common.Character.ETpDebugBoneGroup ShowWeightMode; // 0x4
	static WizardGames.Soc.SocClient.Ui.UiDebugInfo.EShowMode ShowMode; // 0x8
	static System.Boolean ShowCameraDebugInfo; // 0xc
	static System.Boolean ShowHighLightInfo; // 0xd
	static System.String UIName; // 0x10
	static System.Int32 InputSystemFireFrame; // 0x18
	static System.Int32 CmdSetFireFrame; // 0x1c
	static System.Int32 DoFireFrame; // 0x20
	static System.Int32 BulletCreateFrame; // 0x24
	static System.Int32 BulletHitFrame; // 0x28
	System.String InfoContent; // 0x338
	FairyGUI.GComponent rootNode; // 0x340
	FairyGUI.GTextField textInfo; // 0x348
	FairyGUI.GGraph graphCameraTarget; // 0x350
	FairyGUI.GGraph graphCameraDeadZone; // 0x358
	FairyGUI.GGraph graphCameraSoftZone; // 0x360
	FairyGUI.GTextField textHighLight; // 0x368
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x05f04a38
	System.Void OnInit(); // 0x05f04ab8
	System.Void InitCompents(); // 0x05f04bf8
	System.Void UpdateUI(); // 0x05f04e34
	System.Void SetInfo(System.String info); // 0x05f0682c
	System.Boolean GetInfoVisible(); // 0x05f06a74
	System.Boolean GetGraphCameraTargetVisible(); // 0x05f06b1c
	System.Void SetGraphCameraTargetVisible(System.Boolean visible); // 0x05f069e0
	System.Boolean GetGraphCameraDeadZoneVisible(); // 0x05f06bc4
	System.Void SetGraphCameraDeadZoneVisible(System.Boolean visible); // 0x05f068b8
	System.Void SetGraphCameraSoftZoneVisible(System.Boolean visible); // 0x05f0694c
	System.String GetInfoText(); // 0x05f06c6c
	System.Void UpdateCameraDebugInfo(); // 0x05f06d04
	System.Void UpdateHighLightDebugInfo(); // 0x05f06ecc
	System.String GetOutlineRenderInfo(UnityEngine.GameObject mainGo); // 0x05f078c4
	System.String GetDotInfo(Systems.EnhancedDisplayBase display); // 0x05f07f68
	System.Void OnFps10Update(System.Single dt); // 0x05f08198
	System.Void UpdateWeightDebugInfo(); // 0x05f08220
	System.Void UpdateDebugInfo(); // 0x05f04f28
	static System.Void UpdateRotationInfo(); // 0x05f08888
	static System.Void UpdateTouchInfo(); // 0x05f08a14
	static System.Void UpdateVehicleCameraDebug(); // 0x05f08c48
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05f08dec
	System.Void .ctor(); // 0x05f090d4
	static System.Void .cctor(); // 0x05f0918c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiDebugInfo.EShowMode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiDebugInfo.EShowMode Speed = 0;
	static WizardGames.Soc.SocClient.Ui.UiDebugInfo.EShowMode Rotation = 1;
	static WizardGames.Soc.SocClient.Ui.UiDebugInfo.EShowMode Weight = 2;
	static WizardGames.Soc.SocClient.Ui.UiDebugInfo.EShowMode Fire = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDebugMonoMem : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	System.Single[] monoMemUsedData; // 0x338
	System.Single[] xUIAxisPos; // 0x340
	System.Single[] yUIAxisPos; // 0x348
	System.Collections.Generic.List<FairyGUI.GPathPoint> linePoints; // 0x350
	FairyGUI.LineMesh line; // 0x358
	FairyGUI.GGraph lineGraph; // 0x360
	FairyGUI.GComponent rootNode; // 0x368
	FairyGUI.GComponent MonoMemGraph; // 0x370
	FairyGUI.GGraph AxisAnchor; // 0x378
	FairyGUI.GTextField maxMem; // 0x380
	FairyGUI.GTextField minMem; // 0x388
	FairyGUI.GTextField curMem; // 0x390
	System.Single globalMaxMemValue; // 0x398
	System.Single globalMinMemValue; // 0x39c
	System.Void OnInit(); // 0x05f0920c
	System.Void InitComponents(FairyGUI.GComponent rootNode); // 0x05f09300
	System.Void UpdateMemGraph(); // 0x05f0983c
	System.Void OnFps1Update(System.Single dt); // 0x05f09dfc
	System.Void .ctor(); // 0x05f09e74
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDebugObjCount : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	System.Int32 frameCount; // 0x338
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiDebugObjCount.FrameInfo> frameInfos; // 0x340
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiDebugObjCount.ObjCountInfo> curFrameData; // 0x348
	System.Void OnInit(); // 0x05f09f0c
	System.Void OnComponentUpdate(); // 0x05f0a3a8
	System.Boolean CheckContainerUpdateInThisFrame(FairyGUI.Container con, System.Int32 index); // 0x05f0a8ac
	System.Int32 CollectObjCountOfFrame(System.Int32 index); // 0x05f0a480
	System.Void RefreshListOfFrame(System.Int32 index, System.Int32 max); // 0x05f0a734
	System.Void ItemListRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x05f0aa28
	System.Void .ctor(); // 0x05f0ac78
	System.Void <OnInit>b__8_0(); // 0x05f0ad50
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiDebugObjCount.InfoType : System.Enum
{
	System.Int16 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiDebugObjCount.InfoType Win = 0;
	static WizardGames.Soc.SocClient.Ui.UiDebugObjCount.InfoType Hud = 1;
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiDebugObjCount.ObjCountInfo : System.ValueType
{
	WizardGames.Soc.SocClient.Ui.UiDebugObjCount.InfoType type; // 0x10
	System.String name; // 0x18
	System.Int32 count; // 0x20
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDebugObjCount.FrameInfo : System.Object
{
	FairyGUI.GTextField sumTitle; // 0x10
	FairyGUI.GList infoList; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiDebugObjCount.ObjCountInfo> frameData; // 0x20
	System.Void .ctor(); // 0x05f0a340
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDebugObjCount.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiDebugObjCount.<>c <>9; // 0x0
	static System.Func<WizardGames.Soc.Common.Unity.Ui.UiEditableElem,System.Boolean> <>9__11_2; // 0x8
	static System.Comparison<WizardGames.Soc.SocClient.Ui.UiDebugObjCount.ObjCountInfo> <>9__11_1; // 0x10
	static System.Void .cctor(); // 0x05f0adbc
	System.Void .ctor(); // 0x05f0ae20
	System.Boolean <CollectObjCountOfFrame>b__11_2(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x05f0ae88
	System.Int32 <CollectObjCountOfFrame>b__11_1(WizardGames.Soc.SocClient.Ui.UiDebugObjCount.ObjCountInfo a, WizardGames.Soc.SocClient.Ui.UiDebugObjCount.ObjCountInfo b); // 0x05f0af54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDebugObjCount.<>c__DisplayClass11_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiDebugObjCount <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiDebugObjCount.ObjCountInfo> frame; // 0x20
	System.Int32 max; // 0x28
	System.Void .ctor(); // 0x05f0a9c0
	System.Void <CollectObjCountOfFrame>b__0(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05f0b00c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDebugObjCount.<>c__DisplayClass11_1 : System.Object
{
	System.Int32 childSum; // 0x10
	WizardGames.Soc.SocClient.Ui.UiDebugObjCount.<>c__DisplayClass11_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x05f0b44c
	System.Void <CollectObjCountOfFrame>b__3(WizardGames.Soc.Common.Unity.Ui.UiEditableElem elem); // 0x05f0b4b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDesignAreaDebug : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	
	System.Void OnInit(); // 0x05f0b760
	System.Void .ctor(); // 0x05f0b7c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDeployUpgrade : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger Logger; // 0x0
	FairyGUI.GComponent comDeployUpgrade; // 0x338
	FairyGUI.GTextField textTitle; // 0x340
	FairyGUI.GTextField textCurLevel; // 0x348
	FairyGUI.GTextField textTargetLevel; // 0x350
	FairyGUI.GTextField textLockTip; // 0x358
	FairyGUI.GLoader loaderIcon; // 0x360
	FairyGUI.GButton btnUpgrade; // 0x368
	FairyGUI.GButton btnClose; // 0x370
	FairyGUI.GList listRequireMaterials; // 0x378
	System.Int64 tempId; // 0x380
	WizardGames.Soc.Common.Entity.PartEntity partEntity; // 0x388
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,FairyGUI.GObject>> listItemGoDic; // 0x390
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> itemNeedDic; // 0x398
	System.Collections.Generic.List<System.Int64> itemIdList; // 0x3a0
	System.Boolean targetIsUnlock; // 0x3a8
	System.Int64 targetBlueprintId; // 0x3b0
	WizardGames.Soc.Common.Data.constraction.BuildingCore get_buildConfig(); // 0x05f0b854
	System.Void OnInit(); // 0x05f0b940
	System.Void OnEnable(); // 0x05f0bdb4
	System.Void OnDisable(); // 0x05f0bf34
	System.Void ClientPartGoRemove(System.Int64 entityId); // 0x05f0c0c8
	System.Void OnDestroy(); // 0x05f0c1b0
	static System.Void OpenUpgradeView(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x05f0c218
	System.Void OnRenderListNeed(System.Int32 index, FairyGUI.GObject obj); // 0x05f0c3d8
	System.Void OnClickUpgrade(); // 0x05f0c9d8
	System.Void SetViewData(WizardGames.Soc.Common.Entity.PartEntity _partEntity); // 0x05f0cb3c
	System.Void RefreshItemNeedData(); // 0x05f0d240
	System.Void .ctor(); // 0x05f0d36c
	static System.Void .cctor(); // 0x05f0d44c
	System.Void <OnClickUpgrade>b__27_0(System.Boolean canUpgrade); // 0x05f0d520
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDeployUpgrade.<>c__DisplayClass24_0 : System.Object
{
	WizardGames.Soc.Common.Entity.PartEntity partEntity; // 0x10
	System.Void .ctor(); // 0x05f0c370
	System.Void <OpenUpgradeView>b__0(WizardGames.Soc.SocClient.Ui.UiDeployUpgrade win); // 0x05f0d5b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDescTips : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	FairyGUI.GComponent comRoot; // 0x338
	FairyGUI.GObject objTouchClose; // 0x340
	FairyGUI.GComponent comTips; // 0x348
	FairyGUI.GTextField textTips; // 0x350
	static System.Boolean isShow; // 0x0
	System.Single lastTouchTime; // 0x358
	System.Boolean isTouchClose; // 0x35c
	static System.Func<System.String> updateMsg; // 0x8
	System.Void OnInit(); // 0x05f0d638
	System.Void OnFps1Update(System.Single dt); // 0x05f0d928
	System.Void OnFps10Update(System.Single dt); // 0x05f0da00
	System.Void SetData(System.String strMsg, UnityEngine.Vector2 basePos, System.Boolean onTheTop, System.Boolean touchToClose, System.Boolean isTouchScreenClose, System.Func<System.String> updateMsgFPS1); // 0x05f0dbc4
	static System.Void Show(System.String strMsg, UnityEngine.Vector2 basePos, System.Boolean onTheTop, System.Boolean touchToClose, System.Boolean isTouchScreenClose, System.Func<System.String> updateMsgFPS1); // 0x05f0dfbc
	static System.Void Hide(); // 0x05f0dad4
	System.Void .ctor(); // 0x05f0e148
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDialog : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger Log; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.LobbyDialogue.UiDialogueBinder binder; // 0x338
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Queue<System.Int32>> dialogDic; // 0x340
	System.Collections.Generic.Queue<System.Int32> dialogMainQueue; // 0x348
	FairyGUI.TypingEffect te; // 0x350
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Guide.GuideData> dialogId2GuideDataDic; // 0x358
	FairyGUI.Controller tipsCtrl; // 0x360
	System.Boolean showing; // 0x368
	System.Int32 curShowingId; // 0x36c
	System.Boolean isFirstDialog; // 0x370
	System.Void OnInit(); // 0x05f0e1d4
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05f0e554
	System.Void OnEnable(); // 0x05f0e630
	System.Void OnDisable(); // 0x05f0e698
	System.Void OnDestroy(); // 0x05f0e718
	System.Void ShowDialog(); // 0x05f0e780
	System.Void Setup(System.Int32 id, WizardGames.Soc.SocClient.Guide.GuideData guideData); // 0x05f0f274
	System.Void OnClickContinue(); // 0x05f0f610
	static WizardGames.Soc.SocClient.Ui.UiDialog OpenWindow(System.Action<WizardGames.Soc.SocClient.Ui.UiDialog> cb); // 0x05f0f92c
	static System.Void CloseWindow(); // 0x05f0f1dc
	static WizardGames.Soc.SocClient.Ui.UiDialog GetWindow(); // 0x05f0fa04
	static System.Boolean IsWindowOpen(); // 0x05f0fac4
	System.Void .ctor(); // 0x05f0fb70
	static System.Void .cctor(); // 0x05f0fd00
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDialog.<>c__DisplayClass15_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiDialog <>4__this; // 0x10
	System.Boolean isTrigger; // 0x18
	System.Void .ctor(); // 0x05f0f174
	System.Void <ShowDialog>b__0(); // 0x05f0fdd4
	System.Void <ShowDialog>b__1(); // 0x05f0ff0c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.DigContainerType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.DigContainerType Input = 0;
	static WizardGames.Soc.SocClient.Ui.DigContainerType Output = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDig : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	static SocLogger logger; // 0x0
	FairyGUI.GComponent root; // 0x338
	FairyGUI.GComponent contentRoot; // 0x340
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x348
	FairyGUI.GLabel topRoot; // 0x350
	FairyGUI.GButton btnBack; // 0x358
	FairyGUI.GComponent leftRoot; // 0x360
	FairyGUI.GList inputList; // 0x368
	FairyGUI.GButton btnTakeOutInput; // 0x370
	FairyGUI.Transition loopAnim; // 0x378
	FairyGUI.GLoader modelLoader; // 0x380
	FairyGUI.GComponent timeRoot; // 0x388
	FairyGUI.GRichTextField textTime; // 0x390
	FairyGUI.GComponent rightRoot; // 0x398
	FairyGUI.GTextField textOutputTitle; // 0x3a0
	FairyGUI.GList outputList; // 0x3a8
	FairyGUI.GButton btnTakeOutOutput; // 0x3b0
	FairyGUI.GButton btnStartDevice; // 0x3b8
	FairyGUI.GButton btnStopDevice; // 0x3c0
	FairyGUI.Controller statusControl; // 0x3c8
	FairyGUI.Controller btnToggleControl; // 0x3d0
	WizardGames.Soc.SocClient.Ui.UiDigEntityData uiData; // 0x3d8
	WizardGames.Soc.SocClient.Ui.UiDigItemIcon curFirstNodeIcon; // 0x3e0
	System.Int64 subFieldStateChangeId; // 0x3e8
	System.Int64 subFieldProgressChangeId; // 0x3f0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiDigItemIcon> inputIcons; // 0x3f8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComItemIcon> outputIcons; // 0x400
	System.Void OnInit(); // 0x05f10044
	System.Void OnEnable(); // 0x05f109e4
	System.Void OnDisable(); // 0x05f11eac
	System.Void OnQuickLootFinished(); // 0x05f12210
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05f122bc
	System.Void OnDigProgressChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int32 oldVal, System.Int32 newVal); // 0x05f123dc
	System.Void OnDigStateChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Boolean oldVal, System.Boolean newVal); // 0x05f12660
	System.Void SwitchDeviceState(System.Boolean isOpen); // 0x05f12764
	System.Void TakeOutInput(); // 0x05f12938
	System.Void QuickLootToMine(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05f12ce0
	System.Void DoAllQuickLoot(); // 0x05f12e44
	System.Void BindData(); // 0x05f116b4
	System.Boolean IsUsingInputIcon(WizardGames.Soc.SocClient.Ui.UiDigItemIcon itemIcon); // 0x05f132d4
	System.Void RefreshView(); // 0x05f117f8
	System.Void RefreshProgress(); // 0x05f11e18
	System.Void RefreshDeviceState(); // 0x05f124ec
	System.Void PlayLoopAnim(); // 0x05f138ac
	System.Void StopLoopAnim(); // 0x05f13988
	System.Void CollectIcons(); // 0x05f111b4
	static System.Void OpenWindow(System.Int64 collectionID); // 0x05f13da4
	System.Void AddResBtnClick(WizardGames.Soc.SocClient.Ui.UiDigItemIcon itemIcon); // 0x05f14010
	System.Void OnFps10Update(System.Single dt); // 0x05f143e8
	System.Void OnFps30Update(System.Single dt); // 0x05f14550
	System.Void .ctor(); // 0x05f14688
	static System.Void .cctor(); // 0x05f148bc
	System.Void <OnInit>b__27_0(); // 0x05f14990
	System.Void <OnInit>b__27_1(); // 0x05f149f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDig.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiDig.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__27_2; // 0x8
	static System.Action<System.Boolean> <>9__48_0; // 0x10
	static System.Void .cctor(); // 0x05f14a60
	System.Void .ctor(); // 0x05f14ac4
	System.Void <OnInit>b__27_2(); // 0x05f14b2c
	System.Void <OpenWindow>b__48_0(System.Boolean res); // 0x05f14bb4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDigEntityData : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Component.DigComponent digComponent; // 0x10
	WizardGames.Soc.Common.Entity.DigEntity curOpenDigEntity; // 0x18
	WizardGames.Soc.SocClient.Ui.ItemContainerNodeParser inputContainerParser; // 0x20
	WizardGames.Soc.SocClient.Ui.ItemContainerNodeParser outputContainerParser; // 0x28
	WizardGames.Soc.Common.Unity.Go.DigType CurDigType; // 0x30
	WizardGames.Soc.Common.CustomType.ItemContainerNode get_InputContainer(); // 0x05f11114
	WizardGames.Soc.Common.CustomType.ItemContainerNode get_OutputContainer(); // 0x05f1380c
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> get_inputItemList(); // 0x05f14cb4
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> get_OutputItemList(); // 0x05f1379c
	WizardGames.Soc.Common.Data.Play.DigProperty get_TbDigProperty(); // 0x05f142cc
	System.Void OnInit(); // 0x05f10da0
	System.Int32 GetInputSum(); // 0x05f1368c
	System.Boolean InputExistItem(); // 0x05f12884
	System.Boolean OutputExistItem(); // 0x05f13248
	System.Void OnDisable(); // 0x05f12194
	System.String GetOutputTitleName(); // 0x05f11580
	WizardGames.Soc.Common.Unity.Go.DigType GetDigType(); // 0x05f14d24
	System.Void .ctor(); // 0x05f147f8
	static System.Void .cctor(); // 0x05f14f14
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDigItemIcon : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	static SocLogger logger; // 0x0
	FairyGUI.GLoader emptySignLoader; // 0x10
	FairyGUI.GImage addResImg; // 0x18
	WizardGames.Soc.SocClient.Ui.ComItemIcon itemIconCom; // 0x20
	FairyGUI.GImage progressImg; // 0x28
	System.Action<WizardGames.Soc.SocClient.Ui.UiDigItemIcon> addResBtnClickCallback; // 0x30
	System.Void Init(FairyGUI.GComponent root, System.Action<WizardGames.Soc.SocClient.Ui.UiDigItemIcon> addCallback); // 0x05f13a58
	System.Void Refresh(); // 0x05f13410
	System.Void AddResBtnClick(); // 0x05f14fe8
	System.Void SetProgress(System.Single progress); // 0x05f135e4
	System.Void OnGet(); // 0x05f151e8
	System.Void OnRelease(); // 0x05f15248
	System.Void OnDestroy(); // 0x05f152f4
	System.Void .ctor(); // 0x05f15354
	static System.Void .cctor(); // 0x05f153bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDisplayRewardTip : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.UiDisplayRewardTipData uiData; // 0x338
	FairyGUI.GList rewardIconList; // 0x340
	System.Void .ctor(); // 0x05f15490
	System.Void OnInit(); // 0x05f1560c
	System.Void OnEnable(); // 0x05f158ac
	System.Void OnDisable(); // 0x05f1590c
	System.Void RenderRechargeBtnList(System.Int32 index, FairyGUI.GObject obj); // 0x05f15b70
	System.Void SetInfo(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RewardInfo> rewardInfoList); // 0x05f15fc8
	System.Void <OnInit>b__3_0(); // 0x05f16090
	System.Void <OnInit>b__3_1(); // 0x05f16124
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDisplayRewardTip.UiRewardListPage : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiDisplayRewardTipData data; // 0x10
	System.Int32 page; // 0x18
	FairyGUI.GList rewardUpList; // 0x20
	FairyGUI.GList rewardDownList; // 0x28
	FairyGUI.Controller lineCtrl; // 0x30
	System.Void Init(WizardGames.Soc.SocClient.Ui.UiDisplayRewardTipData data, FairyGUI.GObject obj); // 0x05f15c98
	System.Void RenderRewardUpList(System.Int32 index, FairyGUI.GObject obj); // 0x05f16198
	System.Void RenderRewardDownList(System.Int32 index, FairyGUI.GObject obj); // 0x05f16360
	System.Void SetRewardInfo(System.Int32 pageIndex); // 0x05f15e90
	System.Void .ctor(); // 0x05f15c30
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDisplayRewardTip.<>c__DisplayClass5_0 : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RewardInfo> infoList; // 0x10
	System.Void .ctor(); // 0x05f15b08
	System.Void <OnDisable>b__0(WizardGames.Soc.SocClient.Ui.UiDisplayRewardTip win); // 0x05f1652c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDisplayRewardTipData : System.Object
{
	static System.Collections.Generic.Queue<System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RewardInfo>> rewardInfoQueue; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RewardInfo> rewardInfoList; // 0x10
	System.Int32 lineRewardMaxNum; // 0x18
	System.Void .ctor(); // 0x05f15550
	static System.Void .cctor(); // 0x05f165b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RewardInfo : System.Object
{
	System.String iconUrl; // 0x10
	System.Int32 num; // 0x18
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiElectricalBranch : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.Common.Entity.PartEntity branchGo; // 0x338
	FairyGUI.GObject bg; // 0x340
	FairyGUI.GTextInput powerTextInput; // 0x348
	FairyGUI.GButton btnCancel; // 0x350
	FairyGUI.GButton btnSetting; // 0x358
	System.Int32 minPower; // 0x360
	System.Int32 maxPower; // 0x364
	FairyGUI.GComponent panelRoot; // 0x368
	System.Void OnInit(); // 0x05f16648
	static System.Void OpenWindow(System.Int64 entityId); // 0x05f16b00
	static System.Void CloseWindow(); // 0x05f16cb4
	System.Void CacheElectricalBranchData(System.Int64 entityId); // 0x05f16da4
	System.Void OnValueChange(); // 0x05f16ea4
	System.Void SetPower(); // 0x05f16fb0
	System.Void .ctor(); // 0x05f17124
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiElectricalBranch.<>c__DisplayClass9_0 : System.Object
{
	System.Int64 entityId; // 0x10
	System.Void .ctor(); // 0x05f16c4c
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiElectricalBranch win); // 0x05f171b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiElectricCounter : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	System.Int64 entityId; // 0x338
	FairyGUI.GButton btnSet; // 0x340
	FairyGUI.GButton btnCancel; // 0x348
	FairyGUI.GButton btnClose; // 0x350
	FairyGUI.GComponent inputPad; // 0x358
	FairyGUI.GTextField inputText; // 0x360
	System.Void OnInit(); // 0x05f17234
	System.Void SetInputPad(); // 0x05f17734
	System.Void ClickNum(System.Int32 num); // 0x05f17ad4
	System.Void OnClickSetDuration(); // 0x05f17bf4
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05f18120
	System.Void OnDestroy(); // 0x05f181a0
	System.Void SetCounterMode(System.Boolean isOpen); // 0x05f17c74
	System.Void SetCounterTarget(); // 0x05f17ea8
	System.Void .ctor(); // 0x05f18210
	System.Void <OnInit>b__6_0(FairyGUI.EventContext ctx); // 0x05f1829c
	System.Void <SetInputPad>b__7_0(FairyGUI.EventContext ctx); // 0x05f18314
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiElectricCounter.<>c__DisplayClass7_0 : System.Object
{
	System.Int32 index; // 0x10
	WizardGames.Soc.SocClient.Ui.UiElectricCounter <>4__this; // 0x18
	System.Void .ctor(); // 0x05f17a6c
	System.Void <SetInputPad>b__1(FairyGUI.EventContext ctx); // 0x05f183ac
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EBuildAimType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EBuildAimType None = 0;
	static WizardGames.Soc.SocClient.Ui.EBuildAimType NotTarget = 1;
	static WizardGames.Soc.SocClient.Ui.EBuildAimType Target = 2;
	static WizardGames.Soc.SocClient.Ui.EBuildAimType WireHasTarget = 3;
	static WizardGames.Soc.SocClient.Ui.EBuildAimType WireNoTarget = 4;
	static WizardGames.Soc.SocClient.Ui.EBuildAimType IntelligentWire = 5;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiElectricInfo : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger Logger; // 0x0
	FairyGUI.GGroup lineInfoGroup; // 0x338
	FairyGUI.GGroup ioSlotInfoGroup; // 0x340
	FairyGUI.GTextField textLineRemainDist; // 0x348
	FairyGUI.GTextField textElectricName; // 0x350
	FairyGUI.GTextField textSlotName; // 0x358
	FairyGUI.GTextField textElectricNameSub; // 0x360
	FairyGUI.Controller aimTypeController; // 0x368
	FairyGUI.GImage imageProgress; // 0x370
	System.String txtCache; // 0x378
	WizardGames.Soc.SocClient.Ui.EBuildAimType CurBuildAimType; // 0x380
	System.Void OnInit(); // 0x05f18430
	static WizardGames.Soc.SocClient.Ui.UiElectricInfo GetUiElectricInfoWin(); // 0x05f188c4
	System.Void OnEnable(); // 0x05f18a74
	System.Void OnDisable(); // 0x05f18cf0
	System.Void SetLineInfo(System.Single remainDist, System.Int32 remainPoint); // 0x05f18d64
	System.Void SetAimType(WizardGames.Soc.SocClient.Ui.EBuildAimType aimType, System.Single progress); // 0x05f18ec8
	System.Void CloseElectricInfo(WizardGames.Soc.SocClient.Construction.BuildMode.EElectricInfoGroup type); // 0x05f18ae8
	System.Void CloseWin(); // 0x05f19088
	System.Void .ctor(); // 0x05f19100
	static System.Void .cctor(); // 0x05f191b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiEventDispatchDebug : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GTextField textTitle; // 0x338
	WizardGames.Soc.SocClient.Ui.ComMarquee marqueeDetail; // 0x340
	WizardGames.Soc.SocClient.Ui.Binder.LobbySafeAreaDebug.ComDispatchtInfoBinder contentBinder; // 0x348
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.LobbySafeAreaDebug.ComDispatchInfoItemBinder> listItemBinders; // 0x350
	WizardGames.Soc.Common.Unity.Ui.EventDispatcherDebuger curDebuger; // 0x358
	System.Collections.Generic.List<FairyGUI.BaseEventDispatcherDebuger.DebugInfo> debugInfos; // 0x360
	System.Collections.Generic.List<System.String> popPath; // 0x368
	System.Void OnInit(); // 0x05f1928c
	System.Void InitDrag(); // 0x05f1975c
	System.Void DebugItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x05f19b94
	System.Void RefreshDebugCostInfo(); // 0x05f19890
	System.Void ShowDetail(System.Object eventTarget); // 0x05f1a0a4
	System.Void OnDestroy(); // 0x05f1a654
	System.Void .ctor(); // 0x05f1a798
	System.Void <OnInit>b__7_0(); // 0x05f1a920
	System.Void <InitDrag>b__8_0(FairyGUI.EventContext ctx); // 0x05f1a98c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiEventDispatchDebug.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiEventDispatchDebug.<>c <>9; // 0x0
	static FairyGUI.TimerCallback <>9__12_0; // 0x8
	static System.Void .cctor(); // 0x05f1b068
	System.Void .ctor(); // 0x05f1b0cc
	System.Void <OnDestroy>b__12_0(System.Object data); // 0x05f1b134
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiEventDispatchDebug.<>c__DisplayClass9_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiEventDispatchDebug <>4__this; // 0x10
	FairyGUI.BaseEventDispatcherDebuger.DebugInfo info; // 0x18
	System.Void .ctor(); // 0x05f1b1e8
	System.Void <DebugItemRender>b__0(); // 0x05f1b250
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiComHudBloodBar : WizardGames.Soc.SocClient.Ui.UiFocusInfoBase
{
	FairyGUI.GTextField leftTextField; // 0x38
	FairyGUI.GTextField rightTextField; // 0x40
	System.String buildStableStr; // 0x48
	FairyGUI.GComponent comHorseWeak; // 0x50
	FairyGUI.GComponent comVehicleDecay; // 0x58
	WizardGames.Soc.SocClient.Ui.HpBarScale hpBarScale; // 0x60
	WizardGames.Soc.SocClient.Ui.BloodController bloodController; // 0x68
	WizardGames.Soc.Common.Entity.IEntity Target; // 0x70
	System.Collections.Generic.HashSet<System.Int64> subscribesIds; // 0x78
	System.Action<WizardGames.Soc.Share.Framework.CustomTypeBase,System.Single,System.Single> onHpChangeAction; // 0x80
	System.Boolean UpdateBloodConstantly; // 0x88
	System.Void Init(FairyGUI.GComponent node); // 0x05f1b2c4
	System.Void OnInitWnd(); // 0x05f1b3e0
	System.Void Show(System.Single time); // 0x05f1b5ec
	System.Void Hide(); // 0x05f1b694
	System.Void OnFpsUpdate(); // 0x05f1b99c
	System.Void SetInfo(WizardGames.Soc.Common.Entity.IEntity entityBase); // 0x05f1ba14
	System.Void SetHpText(System.Single nowhp, System.Single maxhp); // 0x05f1c940
	System.Void ConfirmTarget(WizardGames.Soc.Common.Entity.IEntity& target); // 0x05f1c010
	System.Void OnHpChange(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Single oldValue, System.Single newValue); // 0x05f1ce7c
	System.Void GetHitableEntityHpInfo(WizardGames.Soc.Common.Entity.IEntity entity, System.Single& nowHp, System.Single& maxHp); // 0x05f1c2a0
	System.Void Update(WizardGames.Soc.Common.Entity.IEntity entityBase); // 0x05f1cfb4
	System.Void UpdateInfo(WizardGames.Soc.Common.Entity.IEntity entityBase); // 0x05f1cb24
	System.Void SetPartEntity(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x05f1d05c
	System.Void SetHittableEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x05f1d634
	System.Void SetVehicleModuleEntity(WizardGames.Soc.Common.CustomType.VehicleModuleCustom vehicleModuleEntity); // 0x05f1d844
	System.Void .ctor(); // 0x05f1d97c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiComNameInfo : WizardGames.Soc.SocClient.Ui.UiFocusInfoBase
{
	FairyGUI.GTextField Name; // 0x38
	FairyGUI.GComponent ComArmor; // 0x40
	FairyGUI.GComponent ComMaterial; // 0x48
	FairyGUI.GComponent ComShield; // 0x50
	WizardGames.Soc.Common.Data.Combat.CombatComponent CombatTable; // 0x58
	WizardGames.Soc.Common.Entity.IEntity Target; // 0x60
	System.Int64 partGradeSubscribeId; // 0x68
	System.Void Init(FairyGUI.GComponent node); // 0x05f1dad8
	System.Void OnInitWnd(); // 0x05f1db8c
	System.Void Show(System.Single time); // 0x05f1dd10
	System.Void Hide(); // 0x05f1df30
	System.Void OnShowHpBarChanged(); // 0x05f1e0c0
	System.Void OnPartGradeChange(System.Int64 entityid); // 0x05f1e160
	System.Void SetInfo(WizardGames.Soc.Common.Entity.IEntity entityBase); // 0x05f1e7a4
	System.Boolean CheckNeedHide(System.Int64 entityId); // 0x05f1ecd4
	System.Void Update(WizardGames.Soc.Common.Entity.IEntity entityBase); // 0x05f1f75c
	System.Void SetText(FairyGUI.GTextField textField, System.String textStr); // 0x05f1f7d0
	System.Void SetInfoForPlayerEntity(WizardGames.Soc.Common.Entity.PlayerEntity player); // 0x05f1ee14
	System.Void SetInfoForPartEntity(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x05f1e2b8
	System.Boolean CheckToolCupIsASafeBox(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x05f1f870
	System.Void SetInfoForBoxEntity(WizardGames.Soc.Common.Entity.BoxEntity boxEntity); // 0x05f1eff4
	System.Void SetInfoForIOEntity(WizardGames.Soc.Common.Entity.IOEntity ioEntity); // 0x05f1f12c
	System.Void SetInfoForMonsterEntity(WizardGames.Soc.Common.Entity.MonsterEntity monsterEntity); // 0x05f1f378
	System.Void .ctor(); // 0x05f1fa10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiFocusInfoBase : System.Object
{
	System.Boolean isShow; // 0x10
	System.Single hideDelayTime; // 0x14
	System.Single finalUpdateTime; // 0x18
	FairyGUI.GComponent rootCom; // 0x20
	FairyGUI.GComponent winNode; // 0x28
	System.Int64 timeId; // 0x30
	System.Void Init(FairyGUI.GComponent node); // 0x05f1fa7c
	System.Void Destroy(); // 0x05f1fafc
	System.Void Show(System.Single hideDelayTime); // 0x05513724
	System.Void Hide(); // 0x05f1b938
	System.Void SetInfo(WizardGames.Soc.Common.Entity.IEntity entityBase); // 0x05523a54
	System.Void Update(WizardGames.Soc.Common.Entity.IEntity entityBase); // 0x05523a54
	System.Void TrySetLoadCom(System.String comPath); // 0x05f1fd44
	System.Void OnInitWnd(); // 0x05f1b58c
	System.Void ResetLoadCom(); // 0x05f1fb5c
	System.Void SetTextFieldText(FairyGUI.GTextField textField, System.String textStr); // 0x05f1cdb0
	System.Void SetLoaderUrl(FairyGUI.GLoader loader, System.String urlStr); // 0x05f1ff10
	System.Void .ctor(); // 0x05f1da70
	System.Void <ResetLoadCom>b__17_0(System.Int64 timeId, System.Object data, System.Boolean delete); // 0x05f20008
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer : WizardGames.Soc.SocClient.Ui.UiFocusInfoBase
{
	static SocLogger logger; // 0x0
	FairyGUI.GList list; // 0x38
	WizardGames.Soc.Common.Entity.BaseMountableEntity mountableEntity; // 0x40
	System.Int32 fuelCapacity; // 0x48
	WizardGames.Soc.Common.Entity.PartEntity partEntity; // 0x50
	System.Int64 electricInfoEntityId; // 0x58
	System.Collections.Generic.List<System.Int32> powerNow; // 0x60
	System.Collections.Generic.List<System.String> batteryInfo; // 0x68
	WizardGames.Soc.Common.Entity.StorageDebrisEntity storageDebrisEntity; // 0x70
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType> containerInfoLabelTypeList; // 0x78
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType,WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.UiContainerInfoLabel> containerInfoLabelDic; // 0x80
	System.Collections.Generic.Dictionary<FairyGUI.GObject,System.Collections.Generic.Dictionary<System.String,FairyGUI.GObject>> itemGoDic; // 0x88
	System.Void Init(FairyGUI.GComponent node); // 0x05f20140
	System.Void OnInitWnd(); // 0x05f201f4
	System.Void Show(System.Single time); // 0x05f202a0
	System.Void Hide(); // 0x05f20490
	System.Void RecvElectricInfo(System.Int64 partId, System.Collections.Generic.List<System.Int32> powerNow); // 0x05f20818
	System.Void RecvElectricBatteryInfo(System.Int64 partId, System.Collections.Generic.List<System.Int32> batteryData); // 0x05f208a4
	System.Void SetInfo(WizardGames.Soc.Common.Entity.IEntity entityBase); // 0x05f20a50
	System.Void Update(WizardGames.Soc.Common.Entity.IEntity entityBase); // 0x05f210b8
	System.Void OnFps30Update(System.Single dt); // 0x05f214c4
	System.Void UpdateInfo(); // 0x05f20f68
	System.Void UpdatePartEntityInfo(); // 0x05f2153c
	System.Boolean NeedShowTransformFreeCostTime(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x05f22610
	System.Void UpdateMountableEntityInfo(); // 0x05f2227c
	System.Void UpdateStorageDebrisEntityInfo(); // 0x05f2235c
	System.Void AddWaterCapacity(); // 0x05f2243c
	System.Void OnItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x05f22950
	System.Void PartEntityItemRenderer(WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType infoLabelType, FairyGUI.GObject obj); // 0x05f22c98
	System.String GetBatteryInfo(System.Int32 idx); // 0x05f24640
	System.Void MountableEntityItemRenderer(WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType infoLabelType, FairyGUI.GObject obj); // 0x05f23ec8
	System.Void StorageDebrisEntityItemRenderer(WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType infoLabelType, FairyGUI.GObject obj); // 0x05f24250
	System.Void .ctor(); // 0x05f24768
	static System.Void .cctor(); // 0x05f25a80
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType ConsumptionElectric = 0;
	static WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType ConsumptionWater = 1;
	static WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType Fuel = 2;
	static WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType Ammo = 3;
	static WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType PureWaterCapacity = 4;
	static WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType SaltWaterCapacity = 5;
	static WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType WaterCatcherConvertRate = 6;
	static WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType SaltConvertPureRate = 7;
	static WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType PowerDuration = 8;
	static WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType EditLimitTime = 9;
	static WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType ElectricInfoChargeLeft = 10;
	static WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType ElectricInfoChargeTime = 11;
	static WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType ElectricInfoUsage = 12;
	static WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType ElectricInfoPower = 13;
	static WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType BurnDuration = 14;
	static WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType DebrisDestroyTime = 15;
	static WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType LargeSolarPanelGeneratePower = 16;
	static WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType WindTurbineGeneratePower = 17;
	static WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType WaterPumpEfficiency = 18;
	static WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType DoorControllerMatch = 19;
	static WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.EContainerInfoLabelType TranformFreeCostTime = 20;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiFocusInfoContainer.UiContainerInfoLabel : System.Object
{
	System.String iconPath; // 0x10
	System.String strTitle; // 0x18
	System.Void .ctor(); // 0x05f25a18
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiFocusInfoIcon : WizardGames.Soc.SocClient.Ui.UiFocusInfoBase
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon ComItem; // 0x38
	System.Void Init(FairyGUI.GComponent node); // 0x05f25b54
	System.Void OnInitWnd(); // 0x05f25c08
	System.Void Show(System.Single time); // 0x05f25d28
	System.Void Hide(); // 0x05f25de8
	System.Void SetInfo(WizardGames.Soc.Common.Entity.IEntity entityBase); // 0x05f25e50
	System.Void SetInfo(WizardGames.Soc.Common.Entity.IEntity entityBase, System.Boolean isUpdate); // 0x05f25ed0
	System.Void SetPartEntity(WizardGames.Soc.Common.Entity.PartEntity partEntity, System.Boolean isUpdate); // 0x05f2602c
	System.Void Update(WizardGames.Soc.Common.Entity.IEntity entityBase); // 0x05f261ac
	System.Void .ctor(); // 0x05f2622c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiFocusInfoObserverMode : WizardGames.Soc.SocClient.Ui.UiFocusInfoBase
{
	static SocLogger logger; // 0x0
	FairyGUI.GButton btnCreatorId; // 0x38
	FairyGUI.GButton btnTerrId; // 0x40
	FairyGUI.GButton btnOwnerId; // 0x48
	FairyGUI.GButton btnPos; // 0x50
	FairyGUI.GButton btnShowRadius; // 0x58
	FairyGUI.GTextInput inputRadius; // 0x60
	WizardGames.Soc.Common.Entity.PartEntity partEntity; // 0x68
	System.Int32 minRadius; // 0x70
	System.Int32 maxRadius; // 0x74
	System.Int32 defaultRadius; // 0x78
	System.Void Init(FairyGUI.GComponent node); // 0x05f26290
	System.Void OnInitWnd(); // 0x05f26344
	System.Void Show(System.Single time); // 0x05f26770
	System.Void TrySetLoadCom(System.String comPath); // 0x05f26830
	System.Void Hide(); // 0x05f268c4
	System.Void SetInfo(WizardGames.Soc.Common.Entity.IEntity entityBase); // 0x05f2693c
	System.Void Update(WizardGames.Soc.Common.Entity.IEntity entityBase); // 0x05f26e88
	System.Void UpdateInfo(); // 0x05f26a7c
	System.Void OnBtnCreatorId(); // 0x05f26fa0
	System.Void OnBtnTerrId(); // 0x05f271ac
	System.Void OnBtnOwnerId(); // 0x05f27268
	System.Void OnBtnPos(); // 0x05f27324
	System.Void OnBtnShowRadius(); // 0x05f273e0
	System.Void Copy(System.String str); // 0x05f2705c
	System.Void .ctor(); // 0x05f27560
	static System.Void .cctor(); // 0x05f2771c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiFocusInfoPartConsumption : WizardGames.Soc.SocClient.Ui.UiFocusInfoBase
{
	static SocLogger logger; // 0x0
	FairyGUI.GTextField labelInfoTextField; // 0x38
	FairyGUI.GTextField textState; // 0x40
	FairyGUI.GLoader iconLoader; // 0x48
	WritableString infoString; // 0x50
	System.Int64 partEntityId; // 0x60
	WizardGames.Soc.SocClient.Ui.UiFocusInfoPartConsumption.PartTypeEnum partTypeEnum; // 0x68
	System.Int32 consumptionNum; // 0x6c
	System.Int32 nextRequestTime; // 0x70
	System.Int32 requestInterval; // 0x74
	System.String currentPower; // 0x78
	System.String currentFlow; // 0x80
	System.String noConnected; // 0x88
	System.String noPower; // 0x90
	System.String inOperation; // 0x98
	System.String abnormalPower; // 0xa0
	System.String noConnectedWater; // 0xa8
	System.String noPowerWater; // 0xb0
	System.String inOperationWater; // 0xb8
	System.String abnormalPowerWater; // 0xc0
	System.Void Init(FairyGUI.GComponent node); // 0x05f277f0
	System.Void OnInitWnd(); // 0x05f278a4
	System.Void Show(System.Single hideDelayTime); // 0x05f27a1c
	System.Void Hide(); // 0x05f27b74
	System.Void SetInfo(WizardGames.Soc.Common.Entity.IEntity entityBase); // 0x05f27cb8
	System.Void Update(WizardGames.Soc.Common.Entity.IEntity entityBase); // 0x05f284d0
	System.Void RecvElectricInfo(System.Int64 partId, System.Collections.Generic.List<System.Int32> powerNowList); // 0x05f28540
	System.Void SetElectricalConsumptionUi(WizardGames.Soc.Common.Component.ElectricBaseComponent electricModule, System.Int32 powerNow); // 0x05f288e0
	System.Void SetDeviceState(System.String stateStr, System.String iconUrl); // 0x05f283c4
	System.Void SetWaterConsumptionUi(WizardGames.Soc.Common.Component.ElectricBaseComponent electricModule, System.Int32 powerNow); // 0x05f28bcc
	System.Void SetIconLoaderUrl(System.String urlStr); // 0x05f28e2c
	System.Void .ctor(); // 0x05f28ec4
	static System.Void .cctor(); // 0x05f29144
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiFocusInfoPartConsumption.PartTypeEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiFocusInfoPartConsumption.PartTypeEnum Electrical = 0;
	static WizardGames.Soc.SocClient.Ui.UiFocusInfoPartConsumption.PartTypeEnum Water = 1;
	static WizardGames.Soc.SocClient.Ui.UiFocusInfoPartConsumption.PartTypeEnum None = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiFocusInfoPartRecover : WizardGames.Soc.SocClient.Ui.UiFocusInfoBase
{
	FairyGUI.GTextField labelTextField; // 0x38
	System.String partRecoverRemainTimeStr; // 0x40
	System.String unitSecStr; // 0x48
	System.Void Init(FairyGUI.GComponent node); // 0x05f29218
	System.Void OnInitWnd(); // 0x05f292cc
	System.Void Show(System.Single time); // 0x05f29378
	System.Void Hide(); // 0x05f29430
	System.Void SetInfo(WizardGames.Soc.Common.Entity.IEntity entityBase); // 0x05f294ac
	System.Void Update(WizardGames.Soc.Common.Entity.IEntity entityBase); // 0x05f2976c
	System.Void SetLabelText(System.String textStr); // 0x05f296ec
	System.Void .ctor(); // 0x05f297dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiFocusInfoPlantWater : WizardGames.Soc.SocClient.Ui.UiFocusInfoBase
{
	FairyGUI.GTextField waterNumTextField; // 0x38
	System.Void Init(FairyGUI.GComponent node); // 0x05f298a4
	System.Void OnInitWnd(); // 0x05f29958
	System.Void Show(System.Single time); // 0x05f29a04
	System.Void Hide(); // 0x05f29ac4
	System.Void SetInfo(WizardGames.Soc.Common.Entity.IEntity entityBase); // 0x05f29b2c
	System.Void Update(WizardGames.Soc.Common.Entity.IEntity entityBase); // 0x05f29e68
	System.Void SetPartEntity(WizardGames.Soc.Common.Entity.PartEntity partEntity); // 0x05f29bf0
	System.Void .ctor(); // 0x05f29f2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiFocusInfo : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	static SocLogger logger; // 0x0
	static System.Int64 preEntityFocusId; // 0x8
	System.Int64 preHpFlagEntityId; // 0x338
	System.Int64 preLabelFlagEntityId; // 0x340
	System.Boolean isInitialized; // 0x348
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.UiFocusInfoBase> uiFocusInfoDic; // 0x350
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiFocusInfoBase> curUiFocusInfoList; // 0x358
	System.Int32[] mTrainFocusTypes; // 0x360
	System.Int32[] digEntityFocusTypes; // 0x368
	System.Int32 frameLimit; // 0x370
	System.Int32 frameCount; // 0x374
	static System.Boolean ForceUpdate; // 0x10
	static System.Boolean get_HasFocusInfo(); // 0x05f29f90
	static System.Int64 get_PreEntityFocusId(); // 0x05f2a020
	System.Void OnInit(); // 0x05f2a0a8
	System.Void OnDestroy(); // 0x05f2a4fc
	System.Void OnEnable(); // 0x05f2a6cc
	System.Void OnDisable(); // 0x05f2a844
	System.Void OnBuildModeChange(); // 0x05f2aa14
	System.Void OnUpdate(System.Collections.Generic.List<WizardGames.Soc.SocClient.Systems.HitObjData> hitObjDataList, WizardGames.Soc.SocClient.Systems.HitObjData obstacle); // 0x05f2aa74
	System.Void ShowFocusInfo(WizardGames.Soc.Common.Entity.IEntity focusEntity, WizardGames.Soc.SocClient.Systems.HitObjData hitObjData); // 0x05f2ac28
	System.Void ObserverShowFocusInfo(WizardGames.Soc.Common.Entity.IEntity focusEntity, WizardGames.Soc.SocClient.Systems.HitObjData hitObjData); // 0x05f2b3d4
	System.Void HandleFocusEntity(WizardGames.Soc.Common.Entity.IEntity focusEntity, UnityEngine.GameObject hitGo); // 0x05f2b6bc
	System.Void ObserverHandleFocusEntity(WizardGames.Soc.Common.Entity.IEntity focusEntity, UnityEngine.GameObject hitGo); // 0x05f2c108
	System.Void HandleLabelFlagEntity(WizardGames.Soc.Common.Entity.IEntity labelFlagEntity); // 0x05f2bc0c
	System.Void HandlePlayerEntityFocus(WizardGames.Soc.Common.Entity.IEntity baseEntity); // 0x05f2c5dc
	System.Void HandleMonsterEntityFocus(WizardGames.Soc.Common.Entity.IEntity baseEntity); // 0x05f2c78c
	System.Void HandleCollectableEntityFocus(WizardGames.Soc.Common.Entity.IEntity baseEntity); // 0x05f2c930
	System.Void HandleVehicleEntityFocus(WizardGames.Soc.Common.Entity.IEntity baseEntity); // 0x05f2cae0
	System.Void HandleHorseEntityFocus(WizardGames.Soc.Common.Entity.IEntity baseEntity); // 0x05f2da28
	System.Void HandleTrainCarEntityFocus(WizardGames.Soc.Common.Entity.IEntity baseEntity); // 0x05f2dde0
	System.Void HandlePartEntityFocus(WizardGames.Soc.Common.Entity.IEntity baseEntity); // 0x05f2cd4c
	System.Void HandleStorageDebrisEntityFocus(WizardGames.Soc.Common.Entity.IEntity baseEntity); // 0x05f2e2fc
	System.Void HandleTrapEntityFocus(WizardGames.Soc.Common.Entity.IEntity baseEntity); // 0x05f2d3f8
	System.Void HandleBoxEntityFocus(WizardGames.Soc.Common.Entity.IEntity baseEntity); // 0x05f2d508
	System.Void HandleCorpseEntityFocus(WizardGames.Soc.Common.Entity.IEntity baseEntity); // 0x05f2d698
	System.Void HandleIOEntityFocus(WizardGames.Soc.Common.Entity.IEntity baseEntity); // 0x05f2d828
	System.Void HandleDigEntityFocus(WizardGames.Soc.Common.Entity.IEntity baseEntity, UnityEngine.GameObject hitGo); // 0x05f2e138
	System.Void SetUIFocusInfo(System.Int32[] types, WizardGames.Soc.Common.Entity.IEntity entityBase); // 0x05f2dc10
	System.Void HidePreInfo(System.Boolean immediately); // 0x05f2c488
	System.Void ShowInfo(); // 0x05f2e5b0
	System.Int32[] UiTypeTransform(System.Int32 uiType); // 0x05f2e474
	System.Void OnFps30Update(System.Single dt); // 0x05f2e668
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05f2e76c
	System.Void .ctor(); // 0x05f2e864
	static System.Void .cctor(); // 0x05f2e974
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiFocusInfo.<>c__DisplayClass26_0 : System.Object
{
	System.Int64 labelFlagEntityId; // 0x10
	System.Void .ctor(); // 0x05f2e40c
	System.Void <HandleLabelFlagEntity>b__0(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05f2ea5c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiObserverFocusInfo : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	static System.Int64 preEntityFocusId; // 0x8
	System.Int64 preHpFlagEntityId; // 0x338
	System.Int64 preLabelFlagEntityId; // 0x340
	System.Boolean isInitialized; // 0x348
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.UiFocusInfoBase> uiFocusInfoDic; // 0x350
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiFocusInfoBase> curUiFocusInfoList; // 0x358
	System.Int32[] mTrainFocusTypes; // 0x360
	System.Int32[] digEntityFocusTypes; // 0x368
	System.Int32 frameLimit; // 0x370
	System.Int32 frameCount; // 0x374
	static System.Boolean ForceUpdate; // 0x10
	System.Void OnInit(); // 0x05f2eb28
	System.Void OnDestroy(); // 0x05f2ed60
	System.Void OnEnable(); // 0x05f2ef30
	System.Void OnDisable(); // 0x05f2f0a8
	System.Void OnBuildModeChange(); // 0x05f2f278
	System.Void OnUpdate(System.Collections.Generic.List<WizardGames.Soc.SocClient.Systems.HitObjData> hitObjDataList, WizardGames.Soc.SocClient.Systems.HitObjData obstacle); // 0x05f2f2d8
	System.Void ObserverShowFocusInfo(WizardGames.Soc.Common.Entity.IEntity focusEntity, WizardGames.Soc.SocClient.Systems.HitObjData hitObjData); // 0x05f2f474
	System.Void ObserverHandleFocusEntity(WizardGames.Soc.Common.Entity.IEntity focusEntity, UnityEngine.GameObject hitGo); // 0x05f2f75c
	System.Void SetUIFocusInfo(System.Int32[] types, WizardGames.Soc.Common.Entity.IEntity entityBase); // 0x05f2fc30
	System.Void HidePreInfo(System.Boolean immediately); // 0x05f2fadc
	System.Void ShowInfo(); // 0x05f2fe00
	System.Void .ctor(); // 0x05f2feb8
	static System.Void .cctor(); // 0x05f2ffc8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiForceChooseFullPop : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.GameForceChooseFullPop.UiForceChooseFullPopBinder rootBinder; // 0x338
	System.Collections.Generic.List<FairyGUI.GObject> allTextFileds; // 0x340
	WizardGames.Soc.SocClient.Ui.UiForceChooseFullPop.UiInfo curInfo; // 0x348
	System.String secPostfix; // 0x350
	System.Int64 countdownTimer; // 0x358
	UnityEngine.Material matMainTitle; // 0x360
	System.Void OnInit(); // 0x05f300b0
	System.Void ResetMainTitleMat(); // 0x05f30b44
	System.Void GlitchStart(); // 0x05f30c9c
	System.Void GlitchEnd(); // 0x05f30ec8
	System.Void OnComponentUpdate(); // 0x05f30f2c
	System.Void OnShowAnimFinish(); // 0x05f31288
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05f312f8
	System.Void OnChoose(FairyGUI.EventContext context); // 0x05f31374
	System.Void OnDestroy(); // 0x05f31424
	System.Void RefreshCountdownTips(); // 0x05f31538
	System.Void OnTimerUpdate(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x05f316f4
	System.Void SetData(WizardGames.Soc.SocClient.Ui.UiForceChooseFullPop.UiInfo info); // 0x05523a54
	static System.Void Open(WizardGames.Soc.SocClient.Ui.UiForceChooseFullPop.UiInfo info); // 0x05f321f0
	System.Void .ctor(); // 0x05f322e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiForceChooseFullPop.UiInfo : System.Object
{
	System.String MainTitle; // 0x10
	System.String SubLabel; // 0x18
	System.String SubTitle; // 0x20
	System.String Content; // 0x28
	System.String Tips; // 0x30
	System.String BacStyle; // 0x38
	System.Int32 Countdown; // 0x40
	System.Action OnChoose; // 0x48
	System.Void .ctor(System.Int32 forcePopCfgId, System.Action onChoose); // 0x05f3236c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.FrequencyRelatedMode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.FrequencyRelatedMode None = 0;
	static WizardGames.Soc.SocClient.Ui.FrequencyRelatedMode Transmitter = 1;
	static WizardGames.Soc.SocClient.Ui.FrequencyRelatedMode Receiver = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiFrequency : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.FrequencyRelatedMode relatedMode; // 0x338
	WizardGames.Soc.Common.Entity.IHeldItemEntity heldItemEntity; // 0x340
	WizardGames.Soc.Common.CustomType.IItemWithFrequency curItemWithFrequency; // 0x348
	WizardGames.Soc.SocClient.Ui.UIFrequencyRelatedContainer frequencyRelatedContainer; // 0x350
	System.Int64 curItemNodeId; // 0x358
	FairyGUI.GTextField frequenceTxt; // 0x360
	FairyGUI.GList list; // 0x368
	FairyGUI.GButton btnRelated; // 0x370
	WizardGames.Soc.SocClient.Ui.ComInfoButton btnInfo; // 0x378
	FairyGUI.Controller relatedStatusCtrl; // 0x380
	FairyGUI.GLoader containerLoader; // 0x388
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.IItemWithFrequency> frequencyItemList; // 0x390
	System.Void OnInit(); // 0x05f32548
	System.Void UnChooseAllIcons(); // 0x05f3322c
	System.Void OnClickBtnRelated(); // 0x05f332a0
	System.Void OnEnable(); // 0x05f33414
	UnityEngine.Rect GetHalfScreenHideArea(); // 0x05f33750
	System.Void RefreshSameFrequencyItem(); // 0x05f335bc
	System.Void GetFrequencyItem(WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap containerMain); // 0x05f338c4
	System.Void OnDisable(); // 0x05f33b20
	System.Void OnDestroy(); // 0x05f33c78
	System.Void OnClickClose(); // 0x05f33d50
	static WizardGames.Soc.SocClient.Ui.UiFrequency OpenWindow(System.Action<WizardGames.Soc.SocClient.Ui.UiFrequency> cb); // 0x05f33dbc
	static System.Void CloseWindow(); // 0x05f33e94
	static WizardGames.Soc.SocClient.Ui.UiFrequency GetWindow(); // 0x05f33f08
	System.Void .ctor(); // 0x05f33fc8
	System.Void <OnInit>b__12_0(FairyGUI.EventContext ctx); // 0x05f340a4
	System.Int32 <RefreshSameFrequencyItem>b__17_0(WizardGames.Soc.Common.CustomType.IItemWithFrequency left, WizardGames.Soc.Common.CustomType.IItemWithFrequency right); // 0x05f3411c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiFrequency.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiFrequency.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__12_1; // 0x8
	static System.Void .cctor(); // 0x05f34380
	System.Void .ctor(); // 0x05f343e4
	System.Void <OnInit>b__12_1(); // 0x05f3444c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIFrequencyRelatedContainer : WizardGames.Soc.SocClient.Ui.ClientContainerCore
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon preChooseIcon; // 0x68
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.IItemWithFrequency> curItemList; // 0x70
	System.Collections.Generic.HashSet<WizardGames.Soc.Common.CustomType.BaseItemNode> sameFrequencyItemList; // 0x78
	System.Collections.Generic.List<System.Int64> selectItemList; // 0x80
	System.Collections.Generic.List<System.Int64> unSelectItemList; // 0x88
	WizardGames.Soc.Common.CustomType.IItemWithFrequency curItemWithFrequency; // 0x90
	System.Boolean needSelect; // 0x98
	System.Void Bind(FairyGUI.GList iconParent, System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.IItemWithFrequency> itemList, WizardGames.Soc.Common.CustomType.IItemWithFrequency itemWithFrequency, System.Boolean needSelect, System.Boolean autoSetItemDatas, System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> onCollectIcon, System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> onSetIcon); // 0x05f32fd0
	System.Void ItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05f34710
	System.Void IconRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05f34c60
	System.Void DealIconWhenCollect(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05f34f98
	System.Void SetItemDatas(); // 0x05f34518
	System.Void OnClickItem(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x05f350e8
	System.Void Refresh(); // 0x05f35424
	System.Void .ctor(); // 0x05f32f68
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIFrequencyRelatedContainer.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UIFrequencyRelatedContainer.<>c <>9; // 0x0
	static System.Func<WizardGames.Soc.SocClient.Ui.ItemDragInfo,System.Boolean> <>9__12_0; // 0x8
	static System.Void .cctor(); // 0x05f35488
	System.Void .ctor(); // 0x05f354ec
	System.Boolean <DealIconWhenCollect>b__12_0(WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x05f35554
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIFrequencyRelatedContainer.<>c__DisplayClass10_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UIFrequencyRelatedContainer <>4__this; // 0x10
	WizardGames.Soc.Common.CustomType.BaseItemNode baseNode; // 0x18
	FairyGUI.GButton btnSelect; // 0x20
	System.Void .ctor(); // 0x05f34bf8
	System.Void <ItemRenderer>b__0(); // 0x05f355cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiFullScreenLoading : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	System.Boolean cacheGyro; // 0x338
	static System.Boolean get_IsOpening(); // 0x05f35828
	static System.Void HideLoading(); // 0x05f358d4
	System.Void OnEnable(); // 0x05f35984
	System.Void OnDisable(); // 0x05f35b18
	System.Void .ctor(); // 0x05f35bfc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiFullScreenVideo : WizardGames.Soc.SocClient.Ui.UiFullScreenVideoBase
{
	
	static System.Void StopVideo(System.Boolean destoryUi); // 0x05f35c88
	System.Void .ctor(); // 0x05f35e10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiFullScreenVideoBase : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger <Logger>k__BackingField; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.UiFullScreenVideoBinder uiBinder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComVideo video; // 0x340
	System.Boolean isLoop; // 0x348
	System.Boolean canSkip; // 0x349
	System.Action onClose; // 0x350
	System.Action onVideoPrepareCompleted; // 0x358
	WizardGames.Soc.SocClient.Ui.ComSkipBtn comSkipBtn; // 0x360
	static SocLogger get_Logger(); // 0x05f35f24
	System.Void OnInit(); // 0x05f35fac
	System.Void OnEnable(); // 0x05f363b0
	System.Void OnDisable(); // 0x05f36434
	System.Void OnDestroy(); // 0x05f364b8
	System.Void onVideoLoopPointReached(UnityEngine.Video.VideoPlayer player); // 0x05f36564
	System.Void onPrepareCompleted(UnityEngine.Video.VideoPlayer player); // 0x05f365f8
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05f36748
	System.Void PlayVideoInternal(System.String path, System.Boolean isLoop, System.Boolean canSkip, System.Action onClose, System.Action onVideoPrepareCompleted); // 0x05f367dc
	System.Void StopVideoInternal(System.Boolean destoryUi); // 0x05f35d68
	System.Void SetCanSkip(System.Boolean canSkip); // 0x05f368d4
	System.Void .ctor(); // 0x05f35e98
	static System.Void .cctor(); // 0x05f36a30
	System.Void <OnInit>b__10_0(); // 0x05f36b04
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiFullScreenVideoPop : WizardGames.Soc.SocClient.Ui.UiFullScreenVideoBase
{
	
	static System.Void PlayVideo(System.String path, System.Boolean isLoop, System.Boolean canSkip, System.Action onClose, System.Action onVideoPrepareCompleted); // 0x05f36b78
	System.Void .ctor(); // 0x05f36ce8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyFunctionButton : System.Object
{
	FairyGUI.GComponent root; // 0x10
	FairyGUI.GList btnList; // 0x18
	WizardGames.Soc.Common.Data.resource.OBJGenaral itemConfig; // 0x20
	FairyGUI.Controller btnStateCtrl; // 0x28
	FairyGUI.GButton btnNormal; // 0x30
	FairyGUI.GButton btnHighlight; // 0x38
	System.String uniqueID; // 0x40
	System.Int32 maxBtnNum; // 0x48
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.common.ENUMPropFunctionButton,System.Action<System.Int32>> btnActionDic; // 0x50
	System.Collections.Generic.List<System.Int32> functionBtnConfigList; // 0x58
	System.Void Bind(FairyGUI.GComponent comBtns); // 0x05f36d70
	System.Void SetData(System.String uniqueID); // 0x05f371c0
	System.Void SetData(System.Int32 rid); // 0x05f37460
	System.Void GetFunctionBtnIDs(); // 0x05f3758c
	System.Boolean IsExperienceCardAndOwnedSkin(); // 0x05f37bdc
	System.Int32 FindBtnTypeByFunctionButtonConfig(WizardGames.Soc.Common.Data.common.ENUMPropFunctionButton btnType); // 0x05f37a28
	System.Void RenderButtonItem(System.Int32 index, FairyGUI.GObject obj); // 0x05f37cd8
	System.Void OnClickFuncButton(FairyGUI.GButton btn, System.Int32 id); // 0x05f37dd4
	System.Void SetBtnVisible(FairyGUI.GButton btn); // 0x05f3805c
	System.Void RefreshBtnListInfo(); // 0x05f37398
	System.Void SetupMoreButton(); // 0x05f38234
	System.Void SetupLimitedButtons(System.Collections.Generic.List<System.Int32> btnIds); // 0x05f3839c
	System.Void SetButtonAction(FairyGUI.GButton button, System.Int32 id); // 0x05f384c8
	System.Void OnClickBtnGoUse(System.Int32 id); // 0x05f388ec
	System.Void OnClickBtnUse(System.Int32 id); // 0x05f38b3c
	System.Void OnHandleRandom(System.Int32 id, WizardGames.Soc.SocClient.Ui.LobbyStashIPropData propData); // 0x05f3972c
	System.Void OnHandleFix(System.Int32 id, WizardGames.Soc.SocClient.Ui.LobbyStashIPropData propData); // 0x05f3923c
	System.Void OnClickBtnExchange(System.Int32 id); // 0x05f39c90
	System.Void OnClickBtnDecompose(System.Int32 id); // 0x05f3a00c
	System.Void OnClickBtnJump(System.Int32 id); // 0x05f3a30c
	System.Void ResetBtnsVisible(); // 0x05f3714c
	System.Void OnClickBtnMore(); // 0x05f3a53c
	System.Void .ctor(); // 0x05f3a7e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyFunctionButton.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiLobbyFunctionButton.<>c <>9; // 0x0
	static System.Action <>9__27_0; // 0x8
	static System.Void .cctor(); // 0x05f3a89c
	System.Void .ctor(); // 0x05f3a900
	System.Void <OnClickBtnUse>b__27_0(); // 0x05f3a968
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyFunctionButton.<>c__DisplayClass20_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLobbyFunctionButton <>4__this; // 0x10
	WizardGames.Soc.Common.Data.common.OBJFunctionButton funcBtnConfig; // 0x18
	System.Int32 id; // 0x20
	System.Void .ctor(); // 0x05f37ff4
	System.Void <OnClickFuncButton>b__0(); // 0x05f3a9f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyFunctionButton.<>c__DisplayClass25_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLobbyFunctionButton <>4__this; // 0x10
	WizardGames.Soc.Common.Data.common.OBJFunctionButton config; // 0x18
	System.Int32 id; // 0x20
	System.Void .ctor(); // 0x05f38884
	System.Void <SetButtonAction>b__0(); // 0x05f3aba4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyFunctionButton.<>c__DisplayClass27_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLobbyFunctionButton <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.LobbyStashIPropData propData; // 0x18
	System.Void .ctor(); // 0x05f391d4
	System.Void <OnClickBtnUse>b__1(); // 0x05f3ad54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyFunctionButton.<>c__DisplayClass28_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.LobbyStashIPropData propData; // 0x10
	System.Void .ctor(); // 0x05f39bc0
	System.Void <OnHandleRandom>b__0(System.Int32 useAmount); // 0x05f3ae28
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyFunctionButton.<>c__DisplayClass29_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.LobbyStashIPropData propData; // 0x10
	System.Void .ctor(); // 0x05f39c28
	System.Void <OnHandleFix>b__0(System.Int32 useAmount); // 0x05f3afac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyFunctionButton.<>c__DisplayClass30_0 : System.Object
{
	WizardGames.Soc.Common.Data.resource.OBJSkinExchange skinExchangeConfig; // 0x10
	WizardGames.Soc.SocClient.Ui.UiLobbyFunctionButton <>4__this; // 0x18
	System.Action<System.Int32> <>9__1; // 0x20
	System.Void .ctor(); // 0x05f39fa4
	System.Void <OnClickBtnExchange>b__0(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05f3b130
	System.Void <OnClickBtnExchange>b__1(System.Int32 index); // 0x05f3b7d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyFunctionButton.<>c__DisplayClass31_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.LobbyStashIPropData propData; // 0x10
	System.Void .ctor(); // 0x05f3bd8c
	System.Void <OnClickBtnDecompose>b__0(System.Int32 useAmount); // 0x05f3bdf4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameAdvice : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	System.Int64 autoHideTimerHandler; // 0x338
	System.Void OnInit(); // 0x05f3bfe0
	System.Void OnEnable(); // 0x05f3c350
	System.Void OnDisable(); // 0x05f3c4d8
	System.Void OnDestroy(); // 0x05f3c5ec
	System.Void .ctor(); // 0x05f3c7cc
	System.Void <OnEnable>b__3_0(System.Int64 _, System.Object _, System.Boolean _); // 0x05f3c858
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameAdvice.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiGameAdvice.<>c <>9; // 0x0
	static WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__5_0; // 0x8
	static System.Void .cctor(); // 0x05f3c8f8
	System.Void .ctor(); // 0x05f3c95c
	System.Void <OnDestroy>b__5_0(System.Int64 _, System.Object _, System.Boolean _); // 0x05f3c9c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCenterConsole : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.GameConsole.RootCenterConsoleBinder rootBinder; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.GameConsole.ComConsoleIntelBinder informationCom; // 0x340
	FairyGUI.Transition intelLoopTransition; // 0x348
	WizardGames.Soc.SocClient.Ui.Binder.GameConsole.ComConsoleScreenPlayBinder storyBanner; // 0x350
	WizardGames.Soc.SocClient.Ui.ComMallRollPoster mallRollPoster; // 0x358
	FairyGUI.GComponent QRDownloadBtn; // 0x360
	FairyGUI.GComponent QRDownload; // 0x368
	WizardGames.Soc.SocClient.Ui.ComBattlePass comBattlePass; // 0x370
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.BottomButtonData> sysDataList; // 0x378
	WizardGames.Soc.SocClient.Ui.BottomButtonData escBottomData; // 0x380
	System.Collections.Generic.List<System.Int32> groupListData; // 0x388
	System.Int64 playAniTimerId; // 0x390
	System.Int64 updateTimerId; // 0x398
	System.Int64 intelEffectTimerId; // 0x3a0
	System.Int64 autoRollTimerId; // 0x3a8
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.mall.OBJHotSale> allSales; // 0x3b0
	System.Int32 curScrollIndex; // 0x3b8
	System.Int32 autoScrollCDMs; // 0x3bc
	System.Collections.Generic.Dictionary<System.Int32,FairyGUI.GObject> allFunctionBtns; // 0x3c0
	System.Boolean afterEnable; // 0x3c8
	System.Collections.Generic.Dictionary<System.String,FairyGUI.GComponent> pandoraBtns; // 0x3d0
	System.String battlePassBgUrl; // 0x3d8
	System.String intelBgUrl; // 0x3e0
	System.String exitIconUrl; // 0x3e8
	System.Int32 guideStepId1; // 0x3f0
	System.Int32 guideStepId2; // 0x3f4
	System.Int32 guideId; // 0x3f8
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.GameConsoleFunction,System.Func<System.String>> getDyanmicIconFunc; // 0x400
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.GameConsoleFunction,System.Action> funcClickAction; // 0x408
	System.Boolean isOpeningOpt; // 0x410
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.GameConsoleFunction,WizardGames.Soc.SocClient.Ui.RedDotType> checkRedDotAction; // 0x418
	System.Void OnInit(); // 0x05f3ca90
	System.Void OnLayerVisibleChanged(System.Boolean layerVisible); // 0x05f3e54c
	System.Void OnEnable(); // 0x05f3e5f4
	System.Void RefreshPlayerInfo(); // 0x05f3eb0c
	System.Void RefreshTopList(); // 0x05f3f03c
	System.Void InitShopSales(); // 0x05f3ef84
	System.Void RefreshSeasonBtn(); // 0x05f40bfc
	System.Void OpenSeasons(FairyGUI.EventContext ctx); // 0x05f41be8
	System.Void OnFirstRechargeClick(FairyGUI.EventContext ctx); // 0x05f41cc0
	System.Void OnBusinessListItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x05f41d70
	System.Void RenderBusinessListItem(FairyGUI.GComponent com, System.Int32 id); // 0x05f41ea4
	System.Void RefreshBussnessBtnList(); // 0x05f40d38
	System.Void RefreshFirstRechargeBtn(); // 0x05f41034
	System.Void AddUpdateTimer(); // 0x055049cc
	System.Void UpdateTimer(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x05f42af0
	System.Void RefreshStoryCom(); // 0x05f42b8c
	System.Void RefreshInformationCom(); // 0x05f4059c
	System.Void RefreshIntelEffects(); // 0x05f436f4
	System.Void AddIntelEffectUpdateTimer(); // 0x055049cc
	System.Void UpdateIntelEffectTimer(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x05f438bc
	System.Void RefreshConsoleGroupList(); // 0x05f3fa8c
	System.Void RefreshBottomList(); // 0x05f3f410
	UnityEngine.Rect GetHalfScreenHideArea(); // 0x05f43af8
	System.Void OnDestroy(); // 0x05f43cc4
	System.Void OnDisable(); // 0x05f43d98
	System.Void InitUIComponent(); // 0x05f3cc48
	System.Void RegisterEvents(); // 0x05f3e250
	System.Void PlayEffect(); // 0x05f40134
	System.Void ClearIntelEffectTimer(); // 0x05f437b4
	System.Void ClearPlayAniTimer(); // 0x05f440fc
	System.Void ClearUpdateTimer(); // 0x05f429e8
	System.Void AddShopScorllTimer(); // 0x055049cc
	System.Void ClearShopBannerScorllTimer(); // 0x05f44204
	System.Void OnShopAutoScrollTimer(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x05f4430c
	System.Void TryAddToAllFunctionBtns(System.Int32 id, FairyGUI.GObject btn); // 0x05f4260c
	System.Void HandleCanShowInCurrentMode(FairyGUI.GObject btn, WizardGames.Soc.Common.Data.Ui.GameCenterConsole config); // 0x05f42804
	FairyGUI.GObject GetObjByFunctionId(WizardGames.Soc.Common.Data.GameConsoleFunction funcId); // 0x05f443d4
	System.Void GenerateAllUnlockKey(); // 0x05f416f0
	System.Void CheckPandoraEntry(System.String appId); // 0x05f44688
	System.Void CheckPandoraEntryRedDot(System.String appId); // 0x05f447b8
	System.Void PlayerStateAction(System.Int32 stateId); // 0x05f4490c
	System.Void OnHandleDamage(WizardGames.Soc.Common.SimpleCustom.DamageDataEvent data); // 0x05f449a0
	System.Void OnTopListItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x05f44af8
	System.Void OnBottomListItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x05f439c4
	System.Void RenderRightListItem(FairyGUI.GComponent com, System.Int32 id); // 0x05f44c2c
	System.Void RegistQRDownloadBtn(); // 0x05f45250
	System.Void QRDownloadRollOver(); // 0x05f45398
	System.Void QRDownloadRollOut(); // 0x05f45b50
	System.Void SetQRDownLoadPos(); // 0x05f456f4
	System.Void OnConsoleGroupListItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x05f45bcc
	System.Void RenderNormalList(FairyGUI.GList list, System.Collections.Generic.List<System.Int32> listData); // 0x05f46080
	System.Collections.Generic.List<System.Int32> getFinalList(System.Collections.Generic.List<System.Int32> originalList); // 0x054f9d14
	System.Int32 GetListCount(System.Collections.Generic.List<System.Int32> listData); // 0x05f46318
	System.Void RenderNormalBtn(FairyGUI.GComponent com, System.Int32 id); // 0x05f463bc
	System.Void TryTriggerGuide(); // 0x05f413b0
	FairyGUI.GObject GetGuideObjByID(System.Int64 id); // 0x05f46a64
	System.Void InitGetDyanmicIconFunc(); // 0x05f3d9d0
	System.String GetStoryIconUrl(); // 0x05f46b24
	System.String GetInformationIconUrl(); // 0x05f46c34
	System.String GetShopIconUrl(); // 0x05f46cac
	System.String GetIconById(System.Int32 id); // 0x05f4234c
	System.Void InitFuncClickAction(); // 0x05f3db80
	System.Void OnCloseBtnClick(); // 0x05f46d7c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05f46de8
	System.Void OnTakePhotosBtnClick(); // 0x05f46f74
	System.Void OnBtnReleaseClick(); // 0x05f47074
	System.Void OnBtnReportVoiceClick(); // 0x05f47534
	System.Void OnBtnReportBuildingsClick(); // 0x05f47764
	System.Void OnBtnReportBuildingsClickNew(); // 0x05f477c8
	System.Void OnBtnGiveUpBtnClick(); // 0x05f47b94
	System.Void OnBtnCampingTentClick(); // 0x05f48028
	static System.Void OnTechnologyBtnClick(); // 0x05f48154
	System.Void OnStoryBtnClick(FairyGUI.EventContext ctx); // 0x05f48290
	System.Void OnSettingBtnClick(); // 0x05f48444
	System.Void OnEscapeBtnClick(); // 0x05f48500
	System.Void OnReportBtnClick(); // 0x05f48e70
	System.Void OnBtnReportAreaClick(FairyGUI.EventContext context); // 0x05f49834
	System.Void OnAnnouncementBtnClick(); // 0x05f49938
	System.Void OnActivityBtnClick(); // 0x05f49acc
	System.Void OnAdminBtnClick(); // 0x05f49b68
	System.Void OnHomePageClick(); // 0x05f49cb8
	System.Void OnHomeMedalPageClick(); // 0x05f49d94
	System.Void OnClickFinishNewbie(); // 0x05f49fd8
	System.Void OnClickSkipNewbie(); // 0x05f4a25c
	System.Void OnClickUnion(); // 0x05f4a4e0
	static System.Void Logout(); // 0x05f4a628
	System.Void OnIntelClick(FairyGUI.EventContext ctx); // 0x05f4a8fc
	System.Void OnFunctionBtnClick(System.Int32 id); // 0x055056e8
	System.Void OnBlankAreaClick(); // 0x05f4ae00
	System.Void OnReturnBtnClick(); // 0x05f4af88
	System.Void InitCheckRedDotAction(); // 0x05f3e060
	System.Void BindRedDot(FairyGUI.GComponent redDotCom, WizardGames.Soc.Common.Data.GameConsoleFunction function); // 0x05f41a50
	WizardGames.Soc.SocClient.Ui.ERedDotStyle FriendRedStyle(); // 0x05f4b51c
	System.Void .ctor(); // 0x05f4b5d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCenterConsole.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiCenterConsole.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__64_0; // 0x8
	static System.Action <>9__102_0; // 0x10
	static System.Action <>9__107_0; // 0x18
	static System.Action<WizardGames.Soc.Common.Unity.Ui.WindowComBase> <>9__116_0; // 0x20
	static System.Action <>9__121_0; // 0x28
	static System.Action <>9__122_0; // 0x30
	static System.Action <>9__124_0; // 0x38
	static System.Action <>9__128_0; // 0x40
	static System.Action <>9__128_1; // 0x48
	static System.Void .cctor(); // 0x05f4b8e8
	System.Void .ctor(); // 0x05f4b94c
	System.Void <HandleCanShowInCurrentMode>b__64_0(FairyGUI.EventContext context); // 0x05f4b9b4
	System.Void <OnBtnReleaseClick>b__102_0(); // 0x05f4bb54
	System.Void <OnBtnGiveUpBtnClick>b__107_0(); // 0x05f4bc28
	System.Void <OnAnnouncementBtnClick>b__116_0(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05f4bcd8
	System.Void <OnClickFinishNewbie>b__121_0(); // 0x05f4bdac
	System.Void <OnClickSkipNewbie>b__122_0(); // 0x05f4c064
	System.Void <Logout>b__124_0(); // 0x05f4c258
	System.Void <OnReturnBtnClick>b__128_0(); // 0x05f4c300
	System.Void <OnReturnBtnClick>b__128_1(); // 0x05f4c3a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCenterConsole.<>c__DisplayClass39_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiCenterConsole <>4__this; // 0x10
	System.Int32 id; // 0x18
	System.Void .ctor(); // 0x05f422e4
	System.Void <RenderBusinessListItem>b__0(); // 0x05f4c540
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCenterConsole.<>c__DisplayClass73_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiCenterConsole <>4__this; // 0x10
	System.Int32 id; // 0x18
	System.Void .ctor(); // 0x05f451e8
	System.Void <RenderRightListItem>b__0(); // 0x05f4c5b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCenterConsole.<>c__DisplayClass82_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.GameConsole.ListItemNormalBtnBinder itemNormal; // 0x10
	WizardGames.Soc.SocClient.Ui.UiCenterConsole <>4__this; // 0x18
	System.Int32 id; // 0x20
	System.Void .ctor(); // 0x05f469fc
	System.Void <RenderNormalBtn>b__0(); // 0x05f4c620
	System.Void <RenderNormalBtn>b__1(); // 0x05f4c710
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameDialog : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	WizardGames.Soc.SocClient.Ui.Binder.GameDialog.UiGameDialogBinder binder; // 0x338
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Queue<System.Int32>> dialogDic; // 0x340
	System.Collections.Generic.Queue<System.Int32> dialogMainQueue; // 0x348
	FairyGUI.TypingEffect te; // 0x350
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Guide.GuideData> dialogId2GuideDataDic; // 0x358
	System.Boolean showing; // 0x360
	System.Int32 curShowingId; // 0x364
	System.Single dialogInterval; // 0x368
	System.Void OnInit(); // 0x05f4c780
	System.Void OnEnable(); // 0x05f4c9a4
	System.Void OnDisable(); // 0x05f4ca0c
	System.Void OnDestroy(); // 0x05f4ca8c
	System.Void ShowDialog(); // 0x05f4caf4
	System.Void Setup(System.Int32 id, WizardGames.Soc.SocClient.Guide.GuideData guideData); // 0x05f4d548
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05f4d8e4
	static WizardGames.Soc.SocClient.Ui.UiGameDialog OpenWindow(System.Action<WizardGames.Soc.SocClient.Ui.UiGameDialog> cb); // 0x05f4dbe0
	static System.Void CloseWindow(); // 0x05f4d4d4
	static WizardGames.Soc.SocClient.Ui.UiGameDialog GetWindow(); // 0x05f4dcb8
	static System.Boolean IsWindowOpen(); // 0x05f4dd78
	System.Void .ctor(); // 0x05f4de24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameNewbieMissionCG : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.ComVideo videoPlayer; // 0x338
	FairyGUI.GButton backBtn; // 0x340
	System.String audioName; // 0x348
	System.Int64 delayShowCloseBtnTimerID; // 0x350
	static System.Boolean TrainingFinished; // 0x0
	System.Void OnInit(); // 0x05f4dfbc
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05f4e364
	System.Void OnEnable(); // 0x05f4e404
	System.Void OnDisable(); // 0x05f4ea0c
	System.Void OnDestroy(); // 0x05f4ebd4
	System.Void MakeFullScreen(); // 0x05f4f188
	System.Void PlayVideo(); // 0x05f4e6ac
	System.Void OnClickBack(); // 0x05f4f338
	static WizardGames.Soc.SocClient.Ui.UiGameNewbieMissionCG OpenWindow(System.Action<WizardGames.Soc.SocClient.Ui.UiGameNewbieMissionCG> cb); // 0x05f4f550
	static System.Void CloseWindow(); // 0x05f4f2c4
	static WizardGames.Soc.SocClient.Ui.UiGameNewbieMissionCG GetWindow(); // 0x05f4f628
	System.Void .ctor(); // 0x05f4f6e8
	System.Void <OnEnable>b__7_0(System.Int64 id, System.Object data, System.Boolean delete); // 0x05f4f7a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameNewbieMissionCG.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiGameNewbieMissionCG.<>c <>9; // 0x0
	static System.Action<UnityEngine.Video.VideoPlayer> <>9__11_1; // 0x8
	static System.Void .cctor(); // 0x05f4f86c
	System.Void .ctor(); // 0x05f4f8d0
	System.Void <PlayVideo>b__11_1(UnityEngine.Video.VideoPlayer player); // 0x05f4f938
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameNewbieMissionCG.<>c__DisplayClass11_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiGameNewbieMissionCG <>4__this; // 0x10
	System.String audioStr; // 0x18
	FairyGUI.TimerCallback <>9__2; // 0x20
	System.Void .ctor(); // 0x05f4f25c
	System.Void <PlayVideo>b__0(UnityEngine.Video.VideoPlayer player); // 0x05f4f9ac
	System.Void <PlayVideo>b__2(System.Object param); // 0x05f4faac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameNewbieMissionCG.<>c__DisplayClass9_0 : System.Object
{
	System.String currentBattleServerId; // 0x10
	System.Void .ctor(); // 0x05f4f120
	System.Void <OnDestroy>b__0(SimpleJSON.JSONNode ret); // 0x05f4fbd0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameOBPlayerList : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.GameOB_PC.RootGameOBPlayerListBinder binder; // 0x338
	FairyGUI.Controller obSearchState; // 0x340
	System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo>> teamList; // 0x348
	System.Int64 timerId; // 0x350
	System.UInt64 get_selectRoleId(); // 0x05f4fcd8
	System.Void OnInit(); // 0x05f4fda8
	System.Void OnDestroy(); // 0x05f50640
	System.Void OnEnable(); // 0x055049cc
	System.Void OnDisable(); // 0x05f50bd0
	System.Void ClearTimer(); // 0x05f50ac4
	System.Void TimerCallBack(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x05f511f8
	System.Void OnSearchInputChanged(FairyGUI.EventContext context); // 0x05f512c4
	System.Void OnClickObSearchBtn(FairyGUI.EventContext context); // 0x05f5149c
	System.Void OnClickObSearchClear(FairyGUI.EventContext context); // 0x05f50c4c
	System.Void OnObserverGetAllPlayer(); // 0x05f51cd4
	System.Void OnTeamListRender(System.Int32 teamIndex, FairyGUI.GObject teamGo); // 0x05f52048
	System.Void .ctor(); // 0x05f52a74
	static System.Void .cctor(); // 0x05f52b08
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameOBPlayerList.<>c__DisplayClass20_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiGameOBPlayerList <>4__this; // 0x10
	System.Collections.Generic.IReadOnlyList<WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo> playerList; // 0x18
	UnityEngine.Color teamColor; // 0x20
	System.Void .ctor(); // 0x05f52a0c
	System.Void <OnTeamListRender>b__0(System.Int32 playerIndex, FairyGUI.GObject playerGo); // 0x05f52bdc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameOBPlayerList.<>c__DisplayClass20_1 : System.Object
{
	WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo playerInfo; // 0x10
	WizardGames.Soc.SocClient.Ui.UiGameOBPlayerList.<>c__DisplayClass20_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x05f53398
	System.Void <OnTeamListRender>b__1(); // 0x05f53400
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameOBTerritoryInfo : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.GameOB_PC.RootGameOBTerritoryInfoBinder binder; // 0x338
	System.Collections.Generic.List<System.UInt64> territoryCabinetEditableRoleIds; // 0x340
	FairyGUI.GButton createRoleLord; // 0x348
	System.UInt64 get_selectRoleId(); // 0x05f53574
	System.Void OnInit(); // 0x05f53644
	System.Void OnDestroy(); // 0x05f53b08
	System.Void RemoteCallGetTerritoryDetail(System.Int64 territoryId); // 0x05f53c20
	System.Void OnObserverGetTerritoryDetail(WizardGames.Soc.Common.CustomType.PatrolTerritoryDetailInfo detailInfo); // 0x05f53cd4
	System.Void RefreshCreatorRoleInfo(WizardGames.Soc.Common.CustomType.PatrolTerritoryDetailInfo detailInfo); // 0x05f53f04
	System.Void CloseWindow(); // 0x05f53e98
	System.Void OnTeamListRender(System.Int32 index, FairyGUI.GObject teamGo); // 0x05f54598
	System.Void RefreshPlayerItemInfo(FairyGUI.GObject teamGo, WizardGames.Soc.Common.CustomType.PatrolPlayerDetailInfo info, System.Boolean isLastIndex); // 0x05f54014
	System.Int32 GetTeamIndex(System.Int64 teamId); // 0x05f546f0
	System.Void .ctor(); // 0x05f54a04
	static System.Void .cctor(); // 0x05f54adc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGoldRecord : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	
	System.Void OnInit(); // 0x05f54bb0
	System.Void .ctor(); // 0x05f54c8c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGuideView : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	FairyGUI.GButton maskBtn; // 0x338
	FairyGUI.GGraph showArea; // 0x340
	FairyGUI.GTextField tipsTxt; // 0x348
	WizardGames.Soc.SocClient.Guide.GuideData curGuide; // 0x350
	System.Void OnInit(); // 0x05f54d18
	System.Void OnEnable(); // 0x05f54f90
	System.Void OnDisable(); // 0x05f54ff8
	System.Void InitGuide(System.Int32 guideId); // 0x05f5506c
	static System.Void CloseWindow(); // 0x05f556b8
	static WizardGames.Soc.SocClient.Ui.UiGuideView GetWindow(); // 0x05f55750
	System.Void OnClickMask(); // 0x05f55810
	System.Void .ctor(); // 0x05f55ab8
	static System.Void .cctor(); // 0x05f55b44
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.BattleTeamData : System.Object
{
	System.String battleServerId; // 0x10
	System.String leader; // 0x18
	System.String teamID; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.BattleTeamData.BattleTeamMemberData> teamMemberDataList; // 0x28
	System.String get_Leader(); // 0x05f55c18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.BattleTeamData.BattleTeamMemberData> get_TeamMemberDataList(); // 0x05f55c7c
	System.Void .ctor(SimpleJSON.JSONNode node); // 0x05f55ce0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.BattleTeamData.BattleTeamMemberData : System.Object
{
	System.String battlePlayerData; // 0x10
	System.String joinTime; // 0x18
	System.String roleID; // 0x20
	System.Void .ctor(); // 0x05f5614c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.HistoryBattleControlAnim : UnityEngine.MonoBehaviour
{
	static SocLogger logger; // 0x0
	UnityEngine.GameObject targetObject; // 0x30
	UnityEngine.GameObject hideObject; // 0x38
	UnityEngine.GameObject PPV_GlitchRGBObj; // 0x40
	UnityEngine.Rendering.Universal.GlitchRGBSplit glitchRGBSplit; // 0x48
	System.Single playTime; // 0x50
	System.Void Start(); // 0x05f561b4
	UnityEngine.Transform FindDeepChild(UnityEngine.Transform parent, System.String childName); // 0x05f56318
	System.Void SetTargetObjVisible(System.Boolean show); // 0x05f56708
	System.Boolean GetGlitchRGBSplitActive(); // 0x05f567f4
	System.Void SetGlitchRGBSplitVisible(System.Boolean show); // 0x05f568a8
	System.Void .ctor(); // 0x05f569cc
	static System.Void .cctor(); // 0x05f56a3c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDeleteHistoryPop : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.ComModal modal; // 0x338
	FairyGUI.GLabel txtCheck; // 0x340
	FairyGUI.GTextInput inputDelete; // 0x348
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ModalBtnInfo> btnInfos; // 0x350
	System.String currentBattleServerId; // 0x358
	System.Int32 currentModeId; // 0x360
	UnityEngine.Color inputSelectColor; // 0x364
	UnityEngine.Color inputNotSelectColor; // 0x374
	System.Void OnInit(); // 0x05f56b10
	System.Void ClickConfirm(); // 0x05f5720c
	System.Void OnInputChange(); // 0x05f574c4
	System.Void OnInputNameFoces(); // 0x05f57594
	System.Void OnSubmitChangeName(); // 0x05f57638
	System.Void IsInputNameLegal(); // 0x05f572b4
	System.Void OnDisable(); // 0x05f5769c
	System.Void Show(System.Int32 modeId, System.String battleServerId); // 0x05f57730
	System.Void .ctor(); // 0x05f5786c
	System.Void <OnInit>b__9_0(); // 0x05f579b0
	System.Void <IsInputNameLegal>b__14_0(); // 0x05f57a1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHistoryBattle : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	static SocLogger Log; // 0x0
	FairyGUI.GButton btnPlay; // 0x338
	FairyGUI.Controller playController; // 0x340
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x348
	FairyGUI.GLoader RTLoader; // 0x350
	FairyGUI.GTextField serverStartTime; // 0x358
	FairyGUI.GTextField serverEndTime; // 0x360
	FairyGUI.GList historyPlayGList; // 0x368
	FairyGUI.GComponent[] playerComs; // 0x370
	FairyGUI.GButton btnDelete; // 0x378
	FairyGUI.GTextField deleteTime; // 0x380
	FairyGUI.Controller deleteController; // 0x388
	FairyGUI.GImage deleteImg; // 0x390
	FairyGUI.GTextField impeachTip; // 0x398
	System.Int32 selectModeId; // 0x3a0
	System.Int32 selectIndex; // 0x3a4
	UnityEngine.RenderTexture rtForModel; // 0x3a8
	FairyGUI.NTexture ntForModel; // 0x3b0
	System.Boolean isJoinBattle; // 0x3b8
	System.Collections.Generic.HashSet<System.String> roleIdList; // 0x3c0
	FairyGUI.GComponent content; // 0x3c8
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.OBJGameMode> curGameModeList; // 0x3d0
	System.Collections.Generic.Dictionary<System.Int32,System.Int64> timerDic; // 0x3d8
	System.String battleId; // 0x3e0
	WizardGames.Soc.Common.Data.Play.OBJGameMode oBJGameMode; // 0x3e8
	FairyGUI.Transition clickTrans; // 0x3f0
	FairyGUI.Transition bgClickTrans; // 0x3f8
	System.Int32 curClickOldPlayTime; // 0x400
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x05f57a88
	System.Void OnInit(); // 0x05f57b08
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05f5888c
	System.Void OnJoinOldBattleNotice(SimpleJSON.JSONNode node); // 0x05f5890c
	System.Void OnClickItem(System.Int32 index, FairyGUI.GComponent obj, System.Int32 modeId); // 0x05f5899c
	System.Void OnRefreshItemRedDot(System.String battleServerId, FairyGUI.GComponent redDot); // 0x05f58df0
	System.Void OnFps10Update(System.Single dt); // 0x05f59400
	System.Void UpdateDeleteTime(); // 0x05f59868
	System.String ConvertCountDown(System.Int64 countDown); // 0x05f59ac4
	System.Void UpdatePlayerNamePos(); // 0x05f59480
	System.Void RenderListItem(System.Int32 index, FairyGUI.GObject obj); // 0x05f59ee0
	System.Void ResetSelectControllerByModeId(System.Int32 modeId, System.Int32 index); // 0x05f5a670
	System.Void OnBattleItemRenderer(System.Int32 index, FairyGUI.GObject obj, System.Int32 modeId); // 0x0550fdd0
	System.Void RefreshRedDot(System.String battleServerId, WizardGames.Soc.SocClient.Ui.ComRedDot redDot, FairyGUI.Controller redDotPosCtrl); // 0x05f5b460
	System.Boolean IsBattleServerEnd(WizardGames.Soc.SocClient.Ui.LobbyBattleServerData serverData); // 0x05f5b1a8
	System.String FormatTimeFromSeconds(System.Int32 seconds); // 0x05f5b6b8
	System.Void OnClickConfirmPlay(); // 0x05f5b840
	System.Void OnClickOldPlay(WizardGames.Soc.SocClient.Ui.LobbyBattleServerData data); // 0x05f5bd94
	System.Void OnClickDelete(); // 0x05f5c6e8
	static System.Void OpenUiDeleteHistoryPop(WizardGames.Soc.SocClient.Ui.LobbyBattleServerData data); // 0x05f5ce24
	System.Void OnBattleEndSummaryNotice(); // 0x05f5cf6c
	System.Void OnEnable(); // 0x05f5d060
	System.Void OnDisable(); // 0x05f5d4e4
	System.Void OnDestroy(); // 0x05f5db90
	System.Void ResetSceneCamera(); // 0x05f5d920
	static System.Void Open(System.Int32 modeId, WizardGames.Soc.SocClient.Manager.EUiOpenTriggerType triggerType); // 0x05f5e000
	static System.Void OpenByBattleServerId(System.String battleServerId); // 0x05f5e218
	System.Void InitRT(); // 0x05f585c8
	System.Void DisposeRT(); // 0x05f5dc08
	System.Void SetStageCamRenderType(UnityEngine.Rendering.Universal.CameraRenderType renderType, System.Boolean show); // 0x05f5dcec
	System.Void RefreshRT(); // 0x05f5e750
	System.Void RefreshInfo(System.Int32 modeId); // 0x05f5cfd4
	System.Void RefreshInfoFromDeleteServer(); // 0x05f5ee5c
	System.Void RefreshBattleModeIdList(); // 0x05f5e908
	System.Boolean FindGameModeIndexById(System.Int32 modeId); // 0x05f5f050
	System.Void JumpByServerId(System.String battleServerId); // 0x05f5e438
	System.Void RefreshSelectBattleInfo(); // 0x05f58fe0
	System.Void RefreshDeleteTimeController(); // 0x05f59bfc
	System.String GetTransTime(System.UInt64 time, System.String serverStartTimeTitleStr); // 0x05f5f170
	System.Void SetPlayInfo(); // 0x05f5f280
	System.Void OnHandleTeamInfo(WizardGames.Soc.SocClient.Ui.BattleTeamData battleTeamData); // 0x05f5f58c
	System.Void ReqGetPlayerInfo(); // 0x05f5ff9c
	System.Void .ctor(); // 0x05f600a0
	static System.Void .cctor(); // 0x05f60230
	System.Void <OnInit>b__32_0(FairyGUI.EventContext ctx); // 0x05f60304
	System.Void <OnInit>b__32_1(FairyGUI.EventContext ctx); // 0x05f6037c
	System.Void <SetPlayInfo>b__71_0(WizardGames.Soc.SocClient.Ui.BattleTeamData battleTeamData); // 0x05f603f4
	System.Void <ReqGetPlayerInfo>b__73_0(SimpleJSON.JSONArray jsonArray); // 0x05f60584
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHistoryBattle.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiHistoryBattle.<>c <>9; // 0x0
	static System.Action <>9__50_0; // 0x8
	static System.Comparison<WizardGames.Soc.Common.Data.Play.OBJGameMode> <>9__65_0; // 0x10
	static System.Comparison<WizardGames.Soc.SocClient.Ui.BattleTeamData.BattleTeamMemberData> <>9__72_0; // 0x18
	static System.Void .cctor(); // 0x05f60be4
	System.Void .ctor(); // 0x05f60c48
	System.Void <OnClickDelete>b__50_0(); // 0x05f60cb0
	System.Int32 <RefreshBattleModeIdList>b__65_0(WizardGames.Soc.Common.Data.Play.OBJGameMode a, WizardGames.Soc.Common.Data.Play.OBJGameMode b); // 0x05f60d10
	System.Int32 <OnHandleTeamInfo>b__72_0(WizardGames.Soc.SocClient.Ui.BattleTeamData.BattleTeamMemberData x, WizardGames.Soc.SocClient.Ui.BattleTeamData.BattleTeamMemberData y); // 0x05f60da4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHistoryBattle.<>c__DisplayClass41_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHistoryBattle <>4__this; // 0x10
	WizardGames.Soc.Common.Data.Play.OBJGameMode config; // 0x18
	FairyGUI.GList list; // 0x20
	System.Int32 index; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.LobbyBattleServerData> serverDataByModeId; // 0x30
	System.Void .ctor(); // 0x05f60e98
	System.Void <RenderListItem>b__0(System.Int32 _index, FairyGUI.GObject _obj); // 0x05f60f00
	System.Void <RenderListItem>b__1(FairyGUI.EventContext context); // 0x05f60fa0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHistoryBattle.<>c__DisplayClass48_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHistoryBattle <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.LobbyBattleServerData data; // 0x18
	System.Void .ctor(); // 0x05f61184
	System.Void <OnClickConfirmPlay>b__0(); // 0x05f611ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHistoryBattle.<>c__DisplayClass50_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.LobbyBattleServerData data; // 0x10
	System.Void .ctor(); // 0x05f61260
	System.Void <OnClickDelete>b__1(); // 0x05f612c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHistoryBattle.<>c__DisplayClass51_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.LobbyBattleServerData data; // 0x10
	System.Void .ctor(); // 0x05f61358
	System.Void <OpenUiDeleteHistoryPop>b__0(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05f613c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHistoryBattle.<>c__DisplayClass57_0 : System.Object
{
	System.Int32 modeId; // 0x10
	System.Void .ctor(); // 0x05f61540
	System.Void <Open>b__0(WizardGames.Soc.SocClient.Ui.UiHistoryBattle win); // 0x05f615a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHistoryBattle.<>c__DisplayClass58_0 : System.Object
{
	System.String battleServerId; // 0x10
	System.Void .ctor(); // 0x05f61630
	System.Void <OpenByBattleServerId>b__0(WizardGames.Soc.SocClient.Ui.UiHistoryBattle win); // 0x05f61698
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHistoryBattle.<>c__DisplayClass66_0 : System.Object
{
	System.Int32 modeId; // 0x10
	System.Void .ctor(); // 0x05f61720
	System.Boolean <FindGameModeIndexById>b__0(WizardGames.Soc.Common.Data.Play.OBJGameMode x); // 0x05f61788
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHistoryBattle.<>c__DisplayClass67_0 : System.Object
{
	System.String battleServerId; // 0x10
	System.Void .ctor(); // 0x05f61814
	System.Boolean <JumpByServerId>b__0(WizardGames.Soc.SocClient.Ui.LobbyBattleServerData x); // 0x05f6187c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHoverTip : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	System.Single BG_X_OFFSET; // 0x338
	System.Single BG_Y_OFFSET; // 0x33c
	FairyGUI.GRichTextField textContent; // 0x340
	FairyGUI.GImage bg; // 0x348
	System.Single clickBtnWidth; // 0x350
	System.Single clickBtnHeight; // 0x354
	System.Void OnInit(); // 0x05f61948
	System.Void OnEnable(); // 0x05f61c28
	System.Void OnDisable(); // 0x05f61d08
	System.Void OnTouchBegin(FairyGUI.EventContext context); // 0x05f61de8
	System.Void RefreshContent(UnityEngine.Vector2 sourcePos, System.String content, System.Single clickBtnWidth, System.Single clickBtnHeight, WizardGames.Soc.SocClient.Ui.UiHoverTip.EHoverTipHorizontalDirection eDirection); // 0x05f61f54
	System.Void SetPosition(UnityEngine.Vector2 screenPos, WizardGames.Soc.SocClient.Ui.UiHoverTip.EHoverTipHorizontalDirection eDirection); // 0x05f62040
	static System.Void OpenWindow(FairyGUI.GObject sourceBtn, System.String content, WizardGames.Soc.SocClient.Ui.UiHoverTip.EHoverTipHorizontalDirection eDirection); // 0x05f624ac
	static System.Void HideWindow(); // 0x05f629fc
	System.Void .ctor(); // 0x05f62aac
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiHoverTip.EHoverTipHorizontalDirection : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiHoverTip.EHoverTipHorizontalDirection None = 0;
	static WizardGames.Soc.SocClient.Ui.UiHoverTip.EHoverTipHorizontalDirection Left = 1;
	static WizardGames.Soc.SocClient.Ui.UiHoverTip.EHoverTipHorizontalDirection Right = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHoverTip.<>c__DisplayClass15_0 : System.Object
{
	UnityEngine.Vector2 pos; // 0x10
	System.String content; // 0x18
	System.Single clickBtnWidth; // 0x20
	System.Single clickBtnHeight; // 0x24
	WizardGames.Soc.SocClient.Ui.UiHoverTip.EHoverTipHorizontalDirection eDirection; // 0x28
	System.Void .ctor(); // 0x05f62994
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiHoverTip win); // 0x05f62b38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudMarker : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	WizardGames.Soc.SocClient.Marker.HudMarkerStage markerStage; // 0x338
	FairyGUI.GComponent panelRoot; // 0x340
	System.Void OnInit(); // 0x05f62bc8
	System.Void OnEnable(); // 0x05f62ed0
	System.Void OnDisable(); // 0x05f62f54
	System.Void OnFps30Update(System.Single dt); // 0x05f62fd8
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x05f63108
	System.Void OnFps10Update(System.Single dt); // 0x05f631dc
	System.Void OnDestroy(); // 0x05f632a8
	System.Void OnFps1Update(System.Single dt); // 0x05f6332c
	System.Void .ctor(); // 0x05f63400
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudUsingItem : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GLoader loader; // 0x338
	FairyGUI.GProgressBar bar; // 0x340
	FairyGUI.GComponent node; // 0x348
	FairyGUI.Controller ctrlStyle; // 0x350
	FairyGUI.GTweener tweener; // 0x358
	FairyGUI.GTextField txt_info; // 0x360
	System.Int64 recordId; // 0x368
	System.Void set_RecordId(System.Int64 value); // 0x05f6348c
	System.Void OnInit(); // 0x05f63504
	System.Void OnCurrentWeaponIdChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int64 oldValue, System.Int64 newValue); // 0x05f638e0
	System.Void ShowEscapeBar(System.Single total, System.Action onComplete); // 0x05f63a50
	System.Void Hide(); // 0x05f63cac
	System.Void OnEnable(); // 0x05f63d54
	System.Void OnDisable(); // 0x05f63e60
	System.Void StartUseItem(System.Int64 recordId, System.Int64 tableId, System.Single total); // 0x05f63f0c
	System.Void StartUseItem(WizardGames.Soc.Common.Entity.IHeldItemEntity itemEntity, System.Single total); // 0x05f64228
	System.Void TryFinishUseItem(System.Int64 _recordId); // 0x05f643bc
	System.Void FinishUseItem(); // 0x05f639e8
	System.Void OnDestroy(); // 0x05f6445c
	System.Void .ctor(); // 0x05f6468c
	System.Boolean <OnEnable>b__13_0(); // 0x05f64718
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudUsingItem.<>c__DisplayClass11_0 : System.Object
{
	System.Action onComplete; // 0x10
	WizardGames.Soc.SocClient.Ui.UiHudUsingItem <>4__this; // 0x18
	System.Void .ctor(); // 0x05f63c44
	System.Void <ShowEscapeBar>b__0(); // 0x05f64784
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudVehicleTip : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	FairyGUI.GComponent comVehicleTip; // 0x338
	FairyGUI.Controller decayCtrl; // 0x340
	System.Int32 myDecayIndex; // 0x348
	FairyGUI.GTextField tipText; // 0x350
	WizardGames.Soc.SocClient.Ui.UiHudElemVehicleStatus vehicleStatus; // 0x358
	System.String mildcorrosionIconStr; // 0x360
	System.String moderatecorrosionIconStr; // 0x368
	System.String severecorrosionIconStr; // 0x370
	System.String horseMildcorrosionIconStr; // 0x378
	System.String horseModeratecorrosionIconStr; // 0x380
	System.String horseSeverecorrosionIconStr; // 0x388
	System.Boolean isHorse; // 0x390
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x05f64808
	System.Void OnInit(); // 0x05f64888
	System.Void OnEnable(); // 0x05f64f00
	System.Void OnFps10Update(System.Single dt); // 0x05f64fac
	System.Void UpdateDecayText(); // 0x05f64d60
	System.Void SetTipText(System.String str); // 0x05f65188
	System.Void OnDestroy(); // 0x05f65244
	System.Void OnListeningCloseWindow(UnityEngine.Vector2 uiPos); // 0x05f65368
	System.Void CloseWindow(); // 0x05f65024
	System.Void .ctor(); // 0x05f656c4
	System.Void <CloseWindow>b__20_0(); // 0x05f65750
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudWeaponChoose : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	FairyGUI.GComponent comRoot; // 0x338
	FairyGUI.GComponent comBoard; // 0x340
	FairyGUI.GLabel labelTitle; // 0x348
	FairyGUI.Controller ctrlBoardStyle; // 0x350
	FairyGUI.GComponent comDragTip; // 0x358
	WizardGames.Soc.SocClient.Ui.ComHudDropBar comDropbar; // 0x360
	FairyGUI.Controller ctrlDropBarStyle; // 0x368
	FairyGUI.GObject objAutoScrollTop; // 0x370
	FairyGUI.GObject objAutoScrollBottom; // 0x378
	FairyGUI.GList listIcons; // 0x380
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> curItems; // 0x388
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> itemListForResort; // 0x390
	System.Collections.Generic.HashSet<System.Int64> oldItemRec; // 0x398
	System.Collections.Generic.Queue<WizardGames.Soc.Common.CustomType.BaseItemNode> newItemQueue; // 0x3a0
	WizardGames.Soc.SocClient.Ui.UiHudElemWeapons elemWeapon; // 0x3a8
	System.Boolean isFirstRefresh; // 0x3b0
	System.Int32 minItemCount; // 0x3b4
	System.Boolean canShowAutoScrollTrigger; // 0x3b8
	System.Boolean isAutoScrollTriggerVisible; // 0x3b9
	System.Single autoScrollStep; // 0x3bc
	System.Single autoScrollFactor; // 0x3c0
	System.Single autoScrollTimer; // 0x3c4
	System.Single autoScrollTime; // 0x3c8
	System.Single triggerAutoChooseX; // 0x3cc
	FairyGUI.GObject elemWeaponCom; // 0x3d0
	static System.Boolean openWithDragState; // 0x0
	static System.Int32 <CurChooseIndex>k__BackingField; // 0x4
	static System.Boolean <IsChooseVisible>k__BackingField; // 0x8
	static System.Boolean <IsInDragging>k__BackingField; // 0x9
	static System.Int32 get_CurChooseIndex(); // 0x05f657bc
	static System.Void set_CurChooseIndex(System.Int32 value); // 0x05f65844
	static System.Boolean get_IsChooseVisible(); // 0x05f658d4
	static System.Void set_IsChooseVisible(System.Boolean value); // 0x05f6595c
	static System.Boolean get_IsInDragging(); // 0x05f659f0
	static System.Void set_IsInDragging(System.Boolean value); // 0x05f65a78
	System.Void set_IsInDragState(System.Boolean value); // 0x05f65b0c
	System.Void OnInit(); // 0x05f65c58
	System.Boolean CheckAndInsertItem(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05f66940
	System.Void RefreshList(); // 0x05f66b44
	System.Void OnUpdateItemNode(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x05f67574
	System.Void OnDestroy(); // 0x05f675ec
	System.Void OnMakeFullScreen(); // 0x05f67664
	System.Void IconRenderer(System.Int32 index, FairyGUI.GObject item); // 0x05f678b4
	System.Void ResetIconChoose(); // 0x05f67fd8
	System.Void OnIconDragEnd(); // 0x05f680dc
	System.Boolean OnIconAcceptDrag(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon, WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x05f68150
	System.Void OnHudWeaponIconDragEnd(); // 0x05f684dc
	System.Void OnIconDragging(System.Single x, System.Single y); // 0x05f686c4
	System.Void RegisterAutoScrollTigger(FairyGUI.GComponent trigger); // 0x05f66410
	System.Void CheckAutoScrollTriggerState(); // 0x05f68930
	System.Void ResetAutoScroll(); // 0x05f68ad0
	System.Void SetAutoScrollTriggerEnable(System.Boolean enable); // 0x05f685a8
	System.Void CheckAutoScroll(System.Single dt); // 0x05f68b38
	System.Void OnFps30Update(System.Single dt); // 0x05f68cb4
	static System.Boolean TrySwipeWeaponWithBeltIcon(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x05f68d28
	static System.Boolean TryResetIconChoose(); // 0x05f68fbc
	FairyGUI.GObject GetGuideObjByID(System.Int64 id); // 0x05f69148
	System.Void OnListeningCloseWindow(UnityEngine.Vector2 uiPos); // 0x05f69268
	System.Void RefreshBoardState(); // 0x05f676c8
	System.Void ItemsReSort(); // 0x05f67514
	System.Void OnHudWeaponIconDragStart_Plaform(); // 0x05f69484
	System.Void OnHudWeaponIconDragEnd_Plaform(); // 0x05f68664
	static WizardGames.Soc.SocClient.Ui.UiHudWeaponChoose Open(System.Boolean isDrag); // 0x05f694e4
	static System.Void Hide(); // 0x05f693b8
	System.Void OnEnable(); // 0x05f6961c
	System.Void OnClickIcon(WizardGames.Soc.SocClient.Ui.ComItemIcon icon, WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, System.Int32 index); // 0x05f698d0
	System.Void OnDisable(); // 0x05f69af8
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> GetRenderData(); // 0x05f69f34
	System.Void OnIconAcceptDrag_Palform(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon, WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x05f68460
	System.Void InitMinItemCount(); // 0x05f6666c
	System.Void RegisterHudBlockElemChange(); // 0x05f667ec
	System.Boolean OnIconDragStart(WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x05f69f98
	System.Void OnHudWeaponIconDragStart(WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x05f6a028
	System.Void .ctor(); // 0x05f6a150
	static System.Void .cctor(); // 0x05f6a308
	System.Boolean <OnInit>b__41_0(); // 0x05f6a35c
	System.Void <RegisterHudBlockElemChange>b__75_0(WizardGames.Soc.SocClient.Ui.UiHudElem elem); // 0x05f6a3c8
	System.Void <RegisterHudBlockElemChange>b__75_1(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05f6a468
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudWeaponChoose.<>c__DisplayClass47_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHudWeaponChoose <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x18
	WizardGames.Soc.Common.CustomType.BaseItemNode tarItem; // 0x20
	System.Int32 index; // 0x28
	System.Void .ctor(); // 0x05f67f70
	System.Void <IconRenderer>b__0(); // 0x05f6a5fc
	System.Void <IconRenderer>b__1(FairyGUI.EventContext ctx); // 0x05f6a670
	System.Void <IconRenderer>b__2(FairyGUI.EventContext ctx); // 0x05f6a934
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiHudWeaponChoose.<>c__DisplayClass53_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiHudWeaponChoose <>4__this; // 0x10
	System.Boolean isDirectionUp; // 0x18
	FairyGUI.Controller triggerStyleCtrl; // 0x20
	System.Void .ctor(); // 0x05f688c8
	System.Void <RegisterAutoScrollTigger>b__0(); // 0x05f6a9bc
	System.Void <RegisterAutoScrollTigger>b__1(); // 0x05f6aa6c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInputBox : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	System.Action<System.String> evConfirm; // 0x338
	FairyGUI.GTextField txtSubhead; // 0x340
	FairyGUI.GTextInput textInput; // 0x348
	FairyGUI.GTextField limitNum; // 0x350
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x358
	System.Boolean clickConfirmAutoClose; // 0x360
	static System.Boolean needClose; // 0x0
	System.Int32 inputLimit; // 0x364
	System.Boolean hasShowLimitHint; // 0x368
	System.String modalTitle; // 0x370
	System.Void OnInit(); // 0x05f6ab0c
	System.Void OnDestroy(); // 0x05f6b130
	System.Void OnClickConfirm(); // 0x05f6b19c
	System.Void OnInputNameChanged(); // 0x05f6b284
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05f6b344
	System.Void ClearSearchData(); // 0x05f6b3d8
	System.Void OpenWindowAct(System.Action<System.String> confirmAction, System.String initText, System.String sbuhead, System.Int32 inputLimit, System.Boolean inputImmediate, System.Boolean ignoreAutoClose, System.String title, System.String confirmText, System.String promptText); // 0x05f6b4ac
	static System.Void OpenWindow(System.Action<System.String> confirmAction, System.String initText, System.String subhead, System.Int32 inputLimit, System.Boolean inputImmediate, System.Boolean ignoreAutoClose, System.String title, System.String confirmText, System.String promptText); // 0x05f6b794
	static System.Void CloseWindow(); // 0x05f6baf0
	System.Void .ctor(); // 0x05f6bbe8
	System.Void <OnInit>b__10_0(); // 0x05f6bc7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInputBox.<>c__DisplayClass17_0 : System.Object
{
	System.Action<System.String> confirmAction; // 0x10
	System.String initText; // 0x18
	System.String subhead; // 0x20
	System.Int32 inputLimit; // 0x28
	System.Boolean inputImmediate; // 0x2c
	System.Boolean ignoreAutoClose; // 0x2d
	System.String title; // 0x30
	System.String confirmText; // 0x38
	System.String promptText; // 0x40
	System.Void .ctor(); // 0x05f6ba88
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiInputBox uiInputBox); // 0x05f6bce8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInputCandidate : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.InputCandidateRootBinder candidateRoot; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.CandidateListBinder candidateContent; // 0x340
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.CandidateItemBinder> cachedBinders; // 0x348
	FairyGUI.GTextInput attachedInput; // 0x350
	System.Single maxListLength; // 0x358
	System.Single maxCandidateLength; // 0x35c
	System.Single candidateOffsetY; // 0x360
	System.Int32 curSelectIndex; // 0x364
	System.Collections.Generic.List<System.String> curCandidates; // 0x368
	System.Text.StringBuilder compositionBuilder; // 0x370
	System.String beforeComposition; // 0x378
	System.Void OnInit(); // 0x05f6bd98
	System.Void OnEnable(); // 0x05f6c1c8
	System.Void OnDisable(); // 0x05f6c230
	System.Void ClearCandidate(System.Boolean unbindInput); // 0x05f6c2a4
	System.Void OnCandidateItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x05f6c44c
	System.Void .ctor(); // 0x05f6c8c4
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EPlayerCurStatus : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EPlayerCurStatus Offline = 1;
	static WizardGames.Soc.SocClient.Ui.EPlayerCurStatus Online = 2;
	static WizardGames.Soc.SocClient.Ui.EPlayerCurStatus LobbyTeam = 3;
	static WizardGames.Soc.SocClient.Ui.EPlayerCurStatus InGame = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EIngameErrorCode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EIngameErrorCode None = 0;
	static WizardGames.Soc.SocClient.Ui.EIngameErrorCode NotInTribe = 1;
	static WizardGames.Soc.SocClient.Ui.EIngameErrorCode GroupNotExist = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TribeMemberDetailInfo : System.Object
{
	System.String RoleID; // 0x10
	System.String NickName; // 0x18
	System.String Avatar; // 0x20
	System.Int32 AvatarFrame; // 0x28
	System.Int32 Level; // 0x2c
	System.Int32 ActiveScore; // 0x30
	System.Int32 LampLevel; // 0x34
	System.String LampTitle; // 0x38
	System.String CurStatusStr; // 0x40
	WizardGames.Soc.SocClient.Ui.EPlayerCurStatus CurStatus; // 0x48
	System.Void .ctor(); // 0x05f6ca6c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PlayerBaseInfoForTribe : System.Object
{
	System.String RoleID; // 0x10
	System.String NickName; // 0x18
	System.String Avatar; // 0x20
	System.Int32 AvatarFrame; // 0x28
	System.Int32 Level; // 0x2c
	System.String CurStatusStr; // 0x30
	WizardGames.Soc.SocClient.Ui.EPlayerCurStatus CurStatus; // 0x38
	System.Void .ctor(); // 0x05f6cad4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.InviteTribeMemberRowInfo : System.Object
{
	System.Boolean IsTitleItem; // 0x10
	System.String BelongTribeID; // 0x18
	System.String BelongTribeName; // 0x20
	System.Collections.Generic.List<System.String> MemberIds; // 0x28
	System.Void .ctor(); // 0x05f6cb3c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ETribeGroupType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ETribeGroupType NewbieGroup = 1;
	static WizardGames.Soc.SocClient.Ui.ETribeGroupType PlayGroup = 2;
	static WizardGames.Soc.SocClient.Ui.ETribeGroupType NormalGroup = 3;
	static WizardGames.Soc.SocClient.Ui.ETribeGroupType SuperGroup = 4;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TribeInviteInfo : System.Object
{
	System.String InviterID; // 0x10
	System.Int64 InviteTime; // 0x18
	WizardGames.Soc.SocClient.Ui.TribeInfo TribeInfo; // 0x20
	System.Void .ctor(); // 0x05f6cba4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ApplyEnterTribeInfo : System.Object
{
	System.String applicantID; // 0x10
	System.Int64 applyTime; // 0x18
	System.Void .ctor(); // 0x05f6cc0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TribeMemberInfo : System.Object
{
	System.Int32 ActiveScore; // 0x10
	System.Int32 ActiveLevel; // 0x14
	System.Int32 LampLevel; // 0x18
	System.String LampTitle; // 0x20
	System.Int64 JoinTime; // 0x28
	System.Int64 LastActiveTime; // 0x30
	System.String RoleID; // 0x38
	System.Void .ctor(); // 0x05f6cc74
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.TribeTagInfo : System.ValueType
{
	System.Int32 TagId; // 0x10
	System.String Name; // 0x18
	UnityEngine.Color BgColor; // 0x20
	UnityEngine.Color TextColor; // 0x30
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TribeInfo : System.Object
{
	System.String <TribeID>k__BackingField; // 0x10
	System.String <InGameGroupID>k__BackingField; // 0x18
	System.String <Name>k__BackingField; // 0x20
	System.Int32 <IconId>k__BackingField; // 0x28
	System.String <Owner>k__BackingField; // 0x30
	System.Int32 <ActiveScore>k__BackingField; // 0x38
	System.Collections.Generic.List<System.String> serverTagsCache; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeTagInfo> <TagInfos>k__BackingField; // 0x48
	System.Int64 <CreateTime>k__BackingField; // 0x50
	System.Int64 <LastActiveTime>k__BackingField; // 0x58
	System.Int64 <LastChangeNameTime>k__BackingField; // 0x60
	WizardGames.Soc.SocClient.Ui.ETribeGroupType <GroupType>k__BackingField; // 0x68
	System.Boolean <IsAdvanced>k__BackingField; // 0x6c
	System.Boolean <CanUpgrade>k__BackingField; // 0x6d
	System.Boolean <IsOfficialCertified>k__BackingField; // 0x6e
	System.Int32 <MemberCount>k__BackingField; // 0x70
	System.Int32 <MemberMaxCount>k__BackingField; // 0x74
	System.Boolean <IsFrozen>k__BackingField; // 0x78
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeMemberInfo> <Members>k__BackingField; // 0x80
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ApplyEnterTribeInfo> <ApplyEnterTribeInfos>k__BackingField; // 0x88
	System.Boolean <HasApprovalPermission>k__BackingField; // 0x90
	System.Boolean <HasInvitePermission>k__BackingField; // 0x91
	System.String[] <CustomLampTitles>k__BackingField; // 0x98
	System.String <Announcement>k__BackingField; // 0xa0
	System.Int64 <LastChangeAnnouncementTime>k__BackingField; // 0xa8
	System.Boolean IsOpenNotDisturbSwitch; // 0xb0
	WizardGames.Soc.SocClient.Ui.EIngameErrorCode IngameErrorCode; // 0xb4
	System.String get_TribeID(); // 0x05f6ccdc
	System.Void set_TribeID(System.String value); // 0x05f6cd40
	System.String get_InGameGroupID(); // 0x05f6cdc0
	System.Void set_InGameGroupID(System.String value); // 0x05f6ce24
	System.String get_Name(); // 0x05f6cea4
	System.Void set_Name(System.String value); // 0x05f6cf08
	System.Int32 get_IconId(); // 0x05f6cf88
	System.Void set_IconId(System.Int32 value); // 0x05f6cfec
	System.String get_Owner(); // 0x05f6d064
	System.Void set_Owner(System.String value); // 0x05f6d0c8
	System.Boolean get_IsOwner(); // 0x05f6d148
	System.Int32 get_ActiveScore(); // 0x05f6d240
	System.Void set_ActiveScore(System.Int32 value); // 0x05f6d2a4
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeTagInfo> get_TagInfos(); // 0x05f6d31c
	System.Void set_TagInfos(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeTagInfo> value); // 0x05f6d380
	System.Int64 get_CreateTime(); // 0x05f6d400
	System.Void set_CreateTime(System.Int64 value); // 0x05f6d464
	System.Void set_LastActiveTime(System.Int64 value); // 0x05f6d4dc
	System.Int64 get_LastChangeNameTime(); // 0x05f6d554
	System.Void set_LastChangeNameTime(System.Int64 value); // 0x05f6d5b8
	WizardGames.Soc.SocClient.Ui.ETribeGroupType get_GroupType(); // 0x05f6d630
	System.Void set_GroupType(WizardGames.Soc.SocClient.Ui.ETribeGroupType value); // 0x05f6d694
	System.Boolean get_IsAdvanced(); // 0x05f6d70c
	System.Void set_IsAdvanced(System.Boolean value); // 0x05f6d770
	System.Boolean get_CanUpgrade(); // 0x05f6d7ec
	System.Void set_CanUpgrade(System.Boolean value); // 0x05f6d850
	System.Boolean get_IsOfficialCertified(); // 0x05f6d8cc
	System.Void set_IsOfficialCertified(System.Boolean value); // 0x05f6d930
	System.Int32 get_MemberCount(); // 0x05f6d9ac
	System.Void set_MemberCount(System.Int32 value); // 0x05f6da10
	System.Int32 get_MemberMaxCount(); // 0x05f6da88
	System.Void set_MemberMaxCount(System.Int32 value); // 0x05f6daec
	System.Boolean get_IsFrozen(); // 0x05f6db64
	System.Void set_IsFrozen(System.Boolean value); // 0x05f6dbc8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeMemberInfo> get_Members(); // 0x05f6dc44
	System.Void set_Members(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeMemberInfo> value); // 0x05f6dca8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ApplyEnterTribeInfo> get_ApplyEnterTribeInfos(); // 0x05f6dd28
	System.Void set_ApplyEnterTribeInfos(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ApplyEnterTribeInfo> value); // 0x05f6dd8c
	System.Boolean get_HasApprovalPermission(); // 0x05f6de0c
	System.Void set_HasApprovalPermission(System.Boolean value); // 0x05f6de70
	System.Boolean get_HasInvitePermission(); // 0x05f6deec
	System.Void set_HasInvitePermission(System.Boolean value); // 0x05f6df50
	System.String[] get_CustomLampTitles(); // 0x05f6dfcc
	System.Void set_CustomLampTitles(System.String[] value); // 0x05f6e030
	System.String get_Announcement(); // 0x05f6e0b0
	System.Void set_Announcement(System.String value); // 0x05f6e114
	System.Int64 get_LastChangeAnnouncementTime(); // 0x05f6e194
	System.Void set_LastChangeAnnouncementTime(System.Int64 value); // 0x05f6e1f8
	System.Void .ctor(SimpleJSON.JSONNode node); // 0x05f6e270
	System.Void ReplaceTribeInfo(SimpleJSON.JSONNode node); // 0x05f6fdfc
	System.Void ParseAllData(SimpleJSON.JSONNode node, System.Boolean isReplace); // 0x05f6e348
	System.Void .ctor(System.String tribeID, System.String inGameGroupID, WizardGames.Soc.SocClient.Ui.ETribeGroupType groupType, System.String icon, System.String name, System.Collections.Generic.List<System.String> tags); // 0x05f71014
	System.Void UpdateIcon(System.Int32 iconId); // 0x05f72000
	System.Void UpdateName(System.String name); // 0x05f720ac
	System.Void UpdateTags(System.Collections.Generic.List<System.String> tags); // 0x05f721f0
	System.Void UpdateGroupSettings(System.Boolean allowMemberApproval, System.Boolean allowMemberInvite); // 0x05f724c0
	System.Void UpdateAnnouncement(System.String announcement); // 0x05f725e4
	System.Void UpgradeToAdvancedGroup(); // 0x05f72728
	System.Void UpdateCustomLampTitles(System.String[] customTitles); // 0x05f72880
	System.Void UpdateMemersLampTitle(); // 0x05f72ac8
	System.Void AddMember(WizardGames.Soc.SocClient.Ui.TribeMemberInfo member); // 0x05f72c74
	System.Void RemoveMember(System.String roleId); // 0x05f72fcc
	System.Void AddApplyEnterTribeInfo(WizardGames.Soc.SocClient.Ui.ApplyEnterTribeInfo applyInfo); // 0x05f732d8
	System.Void RemoveApplyEnterTribeInfo(System.String roleId); // 0x05f73708
	System.Void ClearApplyEnterTribeInfos(); // 0x05f73904
	System.Void SortApplyEnterTribeInfos(); // 0x05f70d70
	System.String GetLampTitleByLampLevel(System.Int32 lampLevel); // 0x05f70afc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TribeInfo.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.TribeInfo.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.ApplyEnterTribeInfo> <>9__119_0; // 0x8
	static System.Void .cctor(); // 0x05f73a20
	System.Void .ctor(); // 0x05f73a84
	System.Int32 <SortApplyEnterTribeInfos>b__119_0(WizardGames.Soc.SocClient.Ui.ApplyEnterTribeInfo x, WizardGames.Soc.SocClient.Ui.ApplyEnterTribeInfo y); // 0x05f73aec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TribeUtils : System.Object
{
	static System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.EPlayerCurStatus,System.String> PlayerCurStatus2CtrlName; // 0x0
	static System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeTagInfo> ParseServerTagList(System.Collections.Generic.List<System.String> tags); // 0x05f6fe7c
	static System.Collections.Generic.List<System.String> CombineTagList(System.Collections.Generic.List<System.Int32> tagIds, System.Collections.Generic.List<System.String> customTags); // 0x05f73b90
	static System.Int32 GetMaxMemberCount(WizardGames.Soc.SocClient.Ui.ETribeGroupType groupType, System.Boolean isAdvanced); // 0x05f70488
	static System.Boolean IsSystemTribe(WizardGames.Soc.SocClient.Ui.ETribeGroupType type); // 0x05f73f44
	static System.Boolean CanUpgradeTribe(System.Int32 activeScore, WizardGames.Soc.SocClient.Ui.ETribeGroupType eTribeGroup, System.Boolean alreadyIsAdvance); // 0x05f70ef4
	static WizardGames.Soc.SocClient.Ui.EPlayerCurStatus GetPlayerCurStatus(System.Int32 onlineStatus, System.Int32 teamStatus, System.Int32 lastlogouttime, System.Int32 battleGameMode, System.String& stateName); // 0x05f73fb0
	static System.Void SetActiveItemInfo(FairyGUI.GButton btn, WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo); // 0x05f742c0
	static System.Void SetTagItemInfo(FairyGUI.GComponent item, WizardGames.Soc.Common.Data.social.OBJGroupTag tagcfg); // 0x05f74670
	static System.Void SetTagItemInfo(FairyGUI.GComponent item, WizardGames.Soc.SocClient.Ui.TribeTagInfo tagInfo); // 0x05f747b4
	static System.Void SetLampItemInfo(FairyGUI.GComponent item, WizardGames.Soc.SocClient.Ui.TribeMemberInfo memberInfo); // 0x05f748f0
	static System.Void SetLampItemInfo(FairyGUI.GComponent item, System.Int32 level, System.String customName); // 0x05f74cbc
	static System.Void SetInActiveLampItemInfo(FairyGUI.GComponent item); // 0x05f74f64
	static System.Void _SetLampItemBaseInfo(FairyGUI.GComponent item, WizardGames.Soc.Common.Data.social.OBJLampLevel lampCfg); // 0x05f74afc
	static System.Boolean IsContainTribeBasicName(System.String str); // 0x05f75098
	static System.Int32 GetActiveLevelByActiveScore(System.Int32 activeScore); // 0x05f707e4
	static System.Int32 GetLampLevelByActiveLevel(System.Int32 level); // 0x05f70970
	static System.Void SetTribeTypeTagCtrl(FairyGUI.Controller tagCtrl, WizardGames.Soc.SocClient.Ui.TribeInfo info); // 0x05f75230
	static System.Void .cctor(); // 0x05f75498
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TribeUtils.<>c__DisplayClass7_0 : System.Object
{
	System.Boolean isShowFrozen; // 0x10
	FairyGUI.GButton btn; // 0x18
	System.Void .ctor(); // 0x05f74608
	System.Void <SetActiveItemInfo>b__0(FairyGUI.EventContext ctx); // 0x05f755f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComTribeCard : FairyGUI.GComponent
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonInterestTribe.ComTribeCardBinder binder; // 0x288
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x05f756c8
	System.Void SetData(WizardGames.Soc.SocClient.Ui.TribeInfo info); // 0x05f75784
	System.Void SetAvatarInfo(Config.LobbyRoleInfo roleInfo); // 0x05f75fa8
	System.Void SetBtnState(System.Boolean hasBtn); // 0x05f76194
	System.Void SetApplyState(System.Boolean hasApplied); // 0x05f7626c
	System.Void SetBtnClickCallback(System.Action callback); // 0x05f763b4
	System.Void .ctor(); // 0x05f765dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComTribeCard.<>c__DisplayClass6_0 : System.Object
{
	System.Action callback; // 0x10
	System.Void .ctor(); // 0x05f76574
	System.Void <SetBtnClickCallback>b__0(); // 0x05f76644
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MyTribePanel : System.Object
{
	FairyGUI.GComponent _root; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonInterestTribe.ComMyTribeBinder binder; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeInfo> tribeInfos; // 0x20
	System.Collections.Generic.Dictionary<System.String,System.String> roleId2PlayerName; // 0x28
	System.Void .ctor(FairyGUI.GComponent root); // 0x05f766bc
	System.Void RenderTribeItem(System.Int32 index, FairyGUI.GObject obj); // 0x05f76c74
	System.Void RenderTagList(FairyGUI.GList list, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeTagInfo> tagInfos); // 0x05f77ce8
	System.Void ReqCreatersName(); // 0x05f77e5c
	System.Void RefreshStatusCtrl(); // 0x05f78114
	WizardGames.Soc.SocClient.Ui.MyTribePanel.ECreateTribeLimitType CanCreateNormalTribe(); // 0x05f78690
	WizardGames.Soc.SocClient.Ui.MyTribePanel.ECreateTribeLimitType CanCreateSuperTribe(); // 0x05f787fc
	System.Void TribeDetailChange(System.String tribeId); // 0x05f78b54
	System.Void RefreshView(); // 0x05f78bcc
	System.Void RefreshApplyRedDot(System.Int32 val); // 0x05f78d4c
	System.Void RefreshUpgradeRedDot(System.Int32 val); // 0x05f78e1c
	System.Void OnEnable(); // 0x05f78eec
	System.Void OnDisable(); // 0x05f79170
	System.Void <ReqCreatersName>b__10_0(SimpleJSON.JSONArray jsonArrayInfo); // 0x05f793ec
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.MyTribePanel.ECreateTribeLimitType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.MyTribePanel.ECreateTribeLimitType None = 0;
	static WizardGames.Soc.SocClient.Ui.MyTribePanel.ECreateTribeLimitType CountLimit = 1;
	static WizardGames.Soc.SocClient.Ui.MyTribePanel.ECreateTribeLimitType LevelLimit = 2;
	static WizardGames.Soc.SocClient.Ui.MyTribePanel.ECreateTribeLimitType ConsumeLimit = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MyTribePanel.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.MyTribePanel.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__7_0; // 0x8
	static FairyGUI.EventCallback1 <>9__7_1; // 0x10
	static System.Void .cctor(); // 0x05f795f8
	System.Void .ctor(); // 0x05f7965c
	System.Void <.ctor>b__7_0(FairyGUI.EventContext ctx); // 0x05f796c4
	System.Void <.ctor>b__7_1(FairyGUI.EventContext ctx); // 0x05f798c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MyTribePanel.<>c__DisplayClass8_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.TribeInfo info; // 0x10
	System.Void .ctor(); // 0x05f77c80
	System.Void <RenderTribeItem>b__0(FairyGUI.EventContext ctx); // 0x05f7993c
	System.Void <RenderTribeItem>b__1(FairyGUI.EventContext ctx); // 0x05f79a7c
	System.Void <RenderTribeItem>b__2(FairyGUI.EventContext ctx); // 0x05f79af8
	System.Void <RenderTribeItem>b__3(FairyGUI.EventContext ctx); // 0x05f79b74
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SearchTribePanel : System.Object
{
	FairyGUI.GComponent _root; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonInterestTribe.ComSearchTribeBinder binder; // 0x18
	WizardGames.Soc.SocClient.Ui.ComInputBox inputBox; // 0x20
	FairyGUI.GList tagList; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeInfo> recommendList; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeInfo> searchResultList; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeInfo> displayList; // 0x40
	System.Collections.Generic.HashSet<System.String> hasAppliedSet; // 0x48
	System.Collections.Generic.Dictionary<System.String,Config.LobbyRoleInfo> roleId2PlayerInfo; // 0x50
	System.Int32 curSelectTagIndex; // 0x58
	WizardGames.Soc.SocClient.Ui.ComInputBox tagInputBgCom; // 0x60
	System.Void .ctor(FairyGUI.GComponent root); // 0x05f79bf4
	System.Void OnEnable(); // 0x05f7a5a8
	System.Void OnDisable(); // 0x05f7a764
	System.Void TryReqRecommendData(); // 0x05f7a670
	System.Void UpdateTribeList(); // 0x05f7a9a0
	System.Void ReqCreatersName(); // 0x05f7aa7c
	System.Void OnRenderRecommendItem(System.Int32 index, FairyGUI.GObject item); // 0x05f7ac98
	System.Void RenderTagItem(System.Int32 index, FairyGUI.GObject obj); // 0x05f7b070
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeInfo> FilterAndSortTribeList(SimpleJSON.JSONNode jsonData, System.Boolean needFilter); // 0x05f7b238
	System.Void OnTagItemClick(FairyGUI.EventContext context); // 0x05f7b7e0
	System.Int32 GetSelectedTagCount(); // 0x05f7c03c
	System.Void UpdateInputTag(); // 0x05f7babc
	System.String GetInput(); // 0x05f7c0a8
	System.Void OnBtnChooseTagClick(FairyGUI.EventContext context); // 0x05f7c160
	System.Void OnBtnSearchClick(); // 0x05f7c5bc
	System.Void TagSearch(); // 0x05f7bf10
	System.Void OnBtnChangeClick(); // 0x05f7c6f4
	System.Void OnRemoveTagBtnClick(); // 0x05f7c770
	System.Void <TryReqRecommendData>b__14_0(SimpleJSON.JSONNode jsonData); // 0x05f7c8f4
	System.Void <ReqCreatersName>b__16_0(SimpleJSON.JSONArray jsonArrayInfo); // 0x05f7cadc
	System.Void <OnBtnSearchClick>b__25_0(SimpleJSON.JSONNode jsonData); // 0x05f7cd40
	System.Void <TagSearch>b__26_0(SimpleJSON.JSONNode jsonData); // 0x05f7cf28
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SearchTribePanel.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.SearchTribePanel.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.TribeInfo> <>9__19_0; // 0x8
	static System.Void .cctor(); // 0x05f7d110
	System.Void .ctor(); // 0x05f7d174
	System.Int32 <FilterAndSortTribeList>b__19_0(WizardGames.Soc.SocClient.Ui.TribeInfo a, WizardGames.Soc.SocClient.Ui.TribeInfo b); // 0x05f7d1dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SearchTribePanel.<>c__DisplayClass17_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo; // 0x10
	WizardGames.Soc.SocClient.Ui.SearchTribePanel <>4__this; // 0x18
	WizardGames.Soc.SocClient.Ui.ComTribeCard comTribeCard; // 0x20
	System.Action <>9__1; // 0x28
	System.Void .ctor(); // 0x05f7b008
	System.Void <OnRenderRecommendItem>b__0(); // 0x05f7d3c4
	System.Void <OnRenderRecommendItem>b__1(); // 0x05f7d52c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChangeTribeName : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonChangeName.RootChangeNameBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x340
	WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo; // 0x348
	WizardGames.Soc.SocClient.Ui.ComInputBox comInput; // 0x350
	System.Int32 ruleTipId; // 0x358
	System.Void OnInit(); // 0x05f7d62c
	System.Void InitModalBtnInfos(); // 0x05f7da18
	System.Void InitText(); // 0x05f7dd18
	System.Void OnConfirmClick(); // 0x05f7e4e8
	System.Void SetData(WizardGames.Soc.SocClient.Ui.TribeInfo info); // 0x05f7ebec
	System.Void UpdateCostTip(); // 0x05f7edac
	System.Void UpdateCdTip(); // 0x05f7f238
	System.Void UpdateStatus(); // 0x05f7f508
	System.Void InputNameFocusIn(FairyGUI.EventContext ctx); // 0x05f7fb5c
	System.Void OnInputNameChanged(); // 0x05f7fdcc
	System.Boolean CheckChangeNameCost(); // 0x05f7f93c
	System.Int32 GetCostOwnedNum(System.Int32 id); // 0x05f80248
	System.Void OnEnable(); // 0x05f803c8
	System.Void OnDisable(); // 0x05f80430
	System.Void OnDestroy(); // 0x05f80498
	static System.Void OpenWindow(WizardGames.Soc.SocClient.Ui.TribeInfo info); // 0x05f80500
	System.Void .ctor(); // 0x05f806c0
	System.Void <InitModalBtnInfos>b__6_0(); // 0x05f80754
	System.Void <InitModalBtnInfos>b__6_1(); // 0x05f807c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChangeTribeName.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiChangeTribeName.<>c <>9; // 0x0
	static System.Action <>9__13_0; // 0x8
	static System.Void .cctor(); // 0x05f8082c
	System.Void .ctor(); // 0x05f80890
	System.Void <InputNameFocusIn>b__13_0(); // 0x05f808f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChangeTribeName.<>c__DisplayClass13_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiChangeTribeName <>4__this; // 0x10
	System.String cacheName; // 0x18
	System.Void .ctor(); // 0x05f7fd64
	System.Void <InputNameFocusIn>b__1(); // 0x05f80958
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChangeTribeName.<>c__DisplayClass20_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.TribeInfo info; // 0x10
	System.Void .ctor(); // 0x05f80658
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiChangeTribeName win); // 0x05f80a38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChangeTribeName.<>c__DisplayClass8_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiChangeTribeName <>4__this; // 0x10
	System.String name; // 0x18
	System.Action <>9__2; // 0x20
	System.Void .ctor(); // 0x05f7eb84
	System.Void <OnConfirmClick>b__0(); // 0x05f80abc
	System.Void <OnConfirmClick>b__2(); // 0x05f80c44
	System.Void <OnConfirmClick>b__1(); // 0x05f80cb8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChooseTribeAvatar : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x338
	System.Action<System.Int32> confirmCb; // 0x340
	System.Int32 oldSelectAvatarId; // 0x348
	FairyGUI.GList avatarList; // 0x350
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.social.OBJGroupIcon> oBJGroupIcons; // 0x358
	System.Void OnInit(); // 0x05f80d2c
	System.Void InitModalBtnInfos(); // 0x05f80f7c
	System.Void RenderAvatarItem(System.Int32 index, FairyGUI.GObject obj); // 0x05f813e0
	System.Void OnConfirmClick(); // 0x05f81528
	System.Void SetData(System.Action<System.Int32> callback, System.Int32 oldSelectAvatarId); // 0x05f815f0
	System.Void OnEnable(); // 0x05f81960
	System.Void OnDisable(); // 0x05f819c8
	System.Void OnDestroy(); // 0x05f81a30
	static System.Void OpenWindow(System.Action<System.Int32> callBack, System.Int32 oldSelectAvatarId); // 0x05f81a98
	System.Void .ctor(); // 0x05f81c74
	System.Void <InitModalBtnInfos>b__6_0(); // 0x05f81d4c
	System.Void <InitModalBtnInfos>b__6_1(); // 0x05f81dc0
	System.Void <InitModalBtnInfos>b__6_2(); // 0x05f81e2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChooseTribeAvatar.<>c__DisplayClass13_0 : System.Object
{
	System.Action<System.Int32> callBack; // 0x10
	System.Int32 oldSelectAvatarId; // 0x18
	System.Void .ctor(); // 0x05f81c0c
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiChooseTribeAvatar win); // 0x05f81e90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChooseTribeTag : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x338
	System.Action<System.Collections.Generic.List<System.Int32>> confirmCb; // 0x340
	System.Collections.Generic.List<System.Int32> curSelectTagIds; // 0x348
	FairyGUI.GList tagList; // 0x350
	System.Int32 limitCount; // 0x358
	FairyGUI.GLabel tagNumInfo; // 0x360
	System.Void OnInit(); // 0x05f81f18
	System.Void InitModalBtnInfos(); // 0x05f82264
	System.Void RenderTagItem(System.Int32 index, FairyGUI.GObject obj); // 0x05f826c8
	System.Void OnTagItemClick(FairyGUI.EventContext context); // 0x05f829c8
	System.Void RefreshTagNumInfo(); // 0x05f82da0
	System.Int32 GetSelectedTagCount(); // 0x05f8294c
	System.Void OnConfirmClick(); // 0x05f82ec8
	System.Void SetData(System.Action<System.Collections.Generic.List<System.Int32>> callback, System.Collections.Generic.List<System.Int32> oldSelectTagIds, System.Int32 limitCount); // 0x05f82f4c
	System.Void OnEnable(); // 0x05f830e4
	System.Void OnDisable(); // 0x05f8314c
	System.Void OnDestroy(); // 0x05f831b4
	static System.Void OpenWindow(System.Action<System.Collections.Generic.List<System.Int32>> callBack, System.Collections.Generic.List<System.Int32> oldSelectTagIds, System.Int32 limitCount); // 0x05f8321c
	System.Void .ctor(); // 0x05f83410
	System.Void <InitModalBtnInfos>b__7_0(); // 0x05f834e8
	System.Void <InitModalBtnInfos>b__7_1(); // 0x05f8355c
	System.Void <InitModalBtnInfos>b__7_2(); // 0x05f835c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiChooseTribeTag.<>c__DisplayClass17_0 : System.Object
{
	System.Action<System.Collections.Generic.List<System.Int32>> callBack; // 0x10
	System.Collections.Generic.List<System.Int32> oldSelectTagIds; // 0x18
	System.Int32 limitCount; // 0x20
	System.Void .ctor(); // 0x05f833a8
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiChooseTribeTag win); // 0x05f8362c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCreateTribe : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonInterestTribe.RootCreateTribeBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComInputBox comInput; // 0x340
	System.Int32 tribeType; // 0x348
	System.Int32 selectedAvatarId; // 0x34c
	System.Collections.Generic.List<System.Int32> selectSystemTagIds; // 0x350
	System.Collections.Generic.List<System.String> selectCustomTagNames; // 0x358
	System.Collections.Generic.List<System.String> selectRoleIDs; // 0x360
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.common.BTuple2> consumeItems; // 0x368
	System.Int32 ruleTipId; // 0x370
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.PlayerBaseInfoForTribe> roleId2PlayerInfo; // 0x378
	System.String initName; // 0x380
	System.Void OnInit(); // 0x05f836b4
	System.Void ChangeTribeType(FairyGUI.EventContext ctx); // 0x05f84674
	System.Void RefreshView(); // 0x05f849e8
	System.Void RefreshTribeName(); // 0x05f84a74
	System.Void RefreshTribeAvatar(); // 0x05f84c90
	System.Void RefreshTagList(); // 0x05f84e0c
	System.Void RenderTagItem(System.Int32 index, FairyGUI.GObject obj); // 0x05f85c00
	System.Void OnInputNameChanged(); // 0x05f85894
	System.Void InputDescFocusIn(FairyGUI.EventContext ctx); // 0x05f86394
	System.Void DeleteSystemTag(System.Int32 tagId); // 0x05f865ec
	System.Void DeleteCustomTag(System.String tagName); // 0x05f86690
	System.Void OnChooseTagClick(FairyGUI.EventContext ctx); // 0x05f86734
	System.Void OnCustomTagClick(FairyGUI.EventContext ctx); // 0x05f868a0
	System.Void DeleteSelectPlayer(System.String roleId); // 0x05f86bb8
	System.Void OnInviteMemberClick(); // 0x05f86c5c
	System.Void OnChooseAvatarClick(FairyGUI.EventContext ctx); // 0x05f86dcc
	System.Void RefreshMemberList(); // 0x05f85120
	System.Void RenderMemberItem(System.Int32 index, FairyGUI.GObject obj); // 0x05f86e8c
	System.Void RefreshCreateBtnState(); // 0x05f85738
	System.Void RefreshConsumeItems(); // 0x05f85554
	System.Void RenderConsumeItem(System.Int32 index, FairyGUI.GObject obj); // 0x05f873e4
	System.Boolean CheckSuperGroupCost(); // 0x05f87950
	System.Boolean CheckCreateTribeCost(); // 0x05f87b70
	System.Int32 GetCostOwnedNum(System.Int32 id); // 0x05f877d0
	System.Void ClearAllData(); // 0x05f84868
	System.Void OnCreateTribeClick(FairyGUI.EventContext ctx); // 0x05f88220
	System.Void RequestCreateTribe(System.String name); // 0x05f8880c
	System.Int32 GetRandomAvatarId(); // 0x05f87e0c
	System.Void OnDestroy(); // 0x05f88d84
	System.Void OnEnable(); // 0x05f88dec
	System.Void ResetWinInfo(); // 0x05f88f00
	System.Void RefreshCurrency(); // 0x05f890f4
	System.Void OnDisable(); // 0x05f89364
	static System.Void OpenWindow(); // 0x05f79738
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05f89468
	System.Void .ctor(); // 0x05f894e8
	System.Void <OnInit>b__11_0(); // 0x05f89734
	System.Void <OnChooseTagClick>b__22_0(System.Collections.Generic.List<System.Int32> tagIds); // 0x05f898e0
	System.Void <OnCustomTagClick>b__23_0(System.String tagName); // 0x05f89ae8
	System.Void <OnInviteMemberClick>b__25_0(System.Collections.Generic.List<System.String> roleIds, System.String teamChangeEntrance); // 0x05f89bdc
	System.Void <OnChooseAvatarClick>b__26_0(System.Int32 avatarId); // 0x05f89e40
	System.Void <RenderMemberItem>b__28_0(); // 0x05f89ebc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCreateTribe.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiCreateTribe.<>c <>9; // 0x0
	static System.Action <>9__19_0; // 0x8
	static System.Action<WizardGames.Soc.SocClient.Ui.UiCreateTribe> <>9__44_0; // 0x10
	static System.Void .cctor(); // 0x05f8a2e8
	System.Void .ctor(); // 0x05f8a34c
	System.Void <InputDescFocusIn>b__19_0(); // 0x05f8a3b4
	System.Void <OpenWindow>b__44_0(WizardGames.Soc.SocClient.Ui.UiCreateTribe win); // 0x05f8a414
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCreateTribe.<>c__DisplayClass17_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiCreateTribe <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Void .ctor(); // 0x05f8a498
	System.Void <RenderTagItem>b__0(); // 0x05f8a500
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCreateTribe.<>c__DisplayClass17_1 : System.Object
{
	System.Int32 customIndex; // 0x10
	WizardGames.Soc.SocClient.Ui.UiCreateTribe.<>c__DisplayClass17_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x05f8a5a0
	System.Void <RenderTagItem>b__1(); // 0x05f8a608
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCreateTribe.<>c__DisplayClass19_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiCreateTribe <>4__this; // 0x10
	System.String cacheDesc; // 0x18
	System.Void .ctor(); // 0x05f8a6b0
	System.Void <InputDescFocusIn>b__1(); // 0x05f8a718
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCreateTribe.<>c__DisplayClass27_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiCreateTribe <>4__this; // 0x10
	System.Int32 listCount; // 0x18
	System.Void .ctor(); // 0x05f8a844
	System.Void <RefreshMemberList>b__0(SimpleJSON.JSONArray jsonArray); // 0x05f8a8ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCreateTribe.<>c__DisplayClass28_0 : System.Object
{
	System.String roleId; // 0x10
	WizardGames.Soc.SocClient.Ui.UiCreateTribe <>4__this; // 0x18
	System.Void .ctor(); // 0x05f8ae80
	System.Void <RenderMemberItem>b__1(); // 0x05f8aee8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCreateTribe.<>c__DisplayClass36_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiCreateTribe <>4__this; // 0x10
	System.String name; // 0x18
	System.Void .ctor(); // 0x05f8af5c
	System.Void <OnCreateTribeClick>b__0(); // 0x05f8afc4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCreateTribe.<>c__DisplayClass37_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ETribeGroupType groupType; // 0x10
	WizardGames.Soc.SocClient.Ui.UiCreateTribe <>4__this; // 0x18
	System.String name; // 0x20
	System.Collections.Generic.List<System.String> serverTags; // 0x28
	System.Action<System.String> <>9__2; // 0x30
	System.Void .ctor(); // 0x05f8b038
	System.Void <RequestCreateTribe>b__1(); // 0x05f8b0a0
	System.Void <RequestCreateTribe>b__2(System.String groupID); // 0x05f8b1fc
	System.Void <RequestCreateTribe>b__0(System.String groupID); // 0x05f8b308
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDismissTribe : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x338
	WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo; // 0x340
	WizardGames.Soc.SocClient.Ui.ComInputBox comInput; // 0x348
	System.Void OnInit(); // 0x05f8b414
	System.Void InitModalBtnInfos(); // 0x05f8b6dc
	System.Void OnConfirmClick(); // 0x05f8bb18
	System.Void SetData(WizardGames.Soc.SocClient.Ui.TribeInfo info); // 0x05f8bd58
	System.Void OnEnable(); // 0x05f8bf00
	System.Void OnDisable(); // 0x05f8bf9c
	System.Void OnDestroy(); // 0x05f8c004
	static System.Void OpenWindow(WizardGames.Soc.SocClient.Ui.TribeInfo info); // 0x05f8c06c
	System.Void .ctor(); // 0x05f8c22c
	System.Void <InitModalBtnInfos>b__4_0(); // 0x05f8c2b8
	System.Void <InitModalBtnInfos>b__4_1(); // 0x05f8c32c
	System.Void <InitModalBtnInfos>b__4_2(); // 0x05f8c398
	System.Void <OnConfirmClick>b__5_0(); // 0x05f8c3fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiDismissTribe.<>c__DisplayClass10_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.TribeInfo info; // 0x10
	System.Void .ctor(); // 0x05f8c1c4
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiDismissTribe win); // 0x05f8c4f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGroupShare : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonInterestTribe.RootGroupShareBinder rootBinder; // 0x338
	WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo; // 0x340
	System.Action closeCallback; // 0x348
	System.Boolean needShowQR; // 0x350
	System.Void OnInit(); // 0x05f8c578
	System.Void OnEnable(); // 0x05f8c7b4
	System.Void OnDisable(); // 0x05f8c81c
	System.Void OnDestroy(); // 0x05f8c8b0
	System.Void SetData(WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo, System.Action closeCallback); // 0x05f8c918
	System.Void OnScreenCaptureFinished(); // 0x05f8d2cc
	System.Void UpdateTribeInfo(); // 0x05f8c9d8
	System.Void SetQRCode(); // 0x05f8cda8
	System.Void SetExpiredDate(System.Double seconds); // 0x05f8d3a0
	static System.Void OpenWindowAndShare(WizardGames.Soc.SocClient.Ui.TribeInfo info, System.Action closeCallback); // 0x05f8d5f0
	System.Void .ctor(); // 0x05f8d7d4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGroupShare.<>c__DisplayClass10_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiGroupShare <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.ComTribeCard com; // 0x18
	System.Void .ctor(); // 0x05f8d338
	System.Void <UpdateTribeInfo>b__0(SimpleJSON.JSONNode jsonNode); // 0x05f8d860
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGroupShare.<>c__DisplayClass13_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.TribeInfo info; // 0x10
	System.Action closeCallback; // 0x18
	System.Void .ctor(); // 0x05f8d76c
	System.Void <OpenWindowAndShare>b__0(WizardGames.Soc.SocClient.Ui.UiGroupShare win); // 0x05f8d9e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInterestTribeMain : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.SocClient.Ui.IJumpToUIWindow
{
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x338
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x340
	FairyGUI.Controller tabCtrl; // 0x348
	WizardGames.Soc.SocClient.Ui.MyTribePanel myTribePanel; // 0x350
	WizardGames.Soc.SocClient.Ui.SearchTribePanel searchTribePanel; // 0x358
	WizardGames.Soc.SocClient.Ui.UiInterestTribeMain.EViewTabType curTab; // 0x360
	System.Void OnInit(); // 0x05f8da6c
	System.Void OnClickTab(System.Int32 index); // 0x05f8e1a0
	System.Void JumpToSearchTribe(); // 0x05f8e294
	System.Void OnDestroy(); // 0x05f8e330
	System.Void OnEnable(); // 0x05f8e398
	System.Void OnDisable(); // 0x05f8e4a4
	System.Void JumpToUIWindow(WizardGames.Soc.SocClient.Ui.JumpData jumpData); // 0x05f8e540
	static System.Void OpenWindow(); // 0x05f8e5d8
	static System.Void OpenWindowJumpToSearch(); // 0x05f8e6a8
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05f8e780
	System.Void .ctor(); // 0x05f8e800
	System.Void <OnInit>b__9_0(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x05f8e88c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiInterestTribeMain.EViewTabType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiInterestTribeMain.EViewTabType MyTribe = 0;
	static WizardGames.Soc.SocClient.Ui.UiInterestTribeMain.EViewTabType SearchTribe = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInviteSomebody : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonInterestTribe.RootInviteSomebodyBinder rootBinder; // 0x338
	FairyGUI.GList groupList; // 0x340
	System.String invitePlayerId; // 0x348
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeInfo> tribeInfos; // 0x350
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.UiInviteSomebody.playerInfo> roleId2PlayerInfo; // 0x358
	System.Collections.Generic.HashSet<System.String> invitedSet; // 0x360
	System.Void OnInit(); // 0x05f8e960
	System.Void OnEnable(); // 0x05f8eb10
	System.Void OnDisable(); // 0x05f8f1c8
	System.Void OnDestroy(); // 0x05f8f230
	System.Void SetData(System.String invitePlayerId); // 0x05f8f2c0
	static System.Void OpenWindow(System.String invitePlayerId); // 0x05f8f340
	System.Void RefreshView(); // 0x05f8f140
	System.Void RenderInviteInfoItem(System.Int32 index, FairyGUI.GObject obj); // 0x05f8f500
	System.Boolean IsInTribe(System.String tribeID); // 0x05f90190
	System.Void RenderTagList(FairyGUI.GList list, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeTagInfo> tagInfos); // 0x05f90018
	System.Void OnBtnInviteClick(WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo, FairyGUI.GButton btn); // 0x05f90248
	System.Void .ctor(); // 0x05f90668
	System.Void <OnEnable>b__8_0(); // 0x05f907f0
	System.Void <OnEnable>b__8_1(SimpleJSON.JSONArray jsonArray); // 0x05f9085c
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiInviteSomebody.playerInfo : System.ValueType
{
	System.String roleId; // 0x10
	System.String name; // 0x18
	System.String portrait; // 0x20
	System.Int32 level; // 0x28
	System.Int32 portraitFrame; // 0x2c
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInviteSomebody.<>c__DisplayClass12_0 : System.Object
{
	System.String invitePlayerId; // 0x10
	System.Void .ctor(); // 0x05f8f498
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiInviteSomebody win); // 0x05f90b50
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiInviteSomebody.<>c__DisplayClass14_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiInviteSomebody <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo; // 0x18
	FairyGUI.GButton btnInvite; // 0x20
	System.Void .ctor(); // 0x05f8ffb0
	System.Void <RenderInviteInfoItem>b__0(FairyGUI.EventContext ctx); // 0x05f90c20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeAnnouncementPop : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x338
	WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo; // 0x340
	FairyGUI.Controller statusCtrl; // 0x348
	FairyGUI.GTextInput inputAnnouncement; // 0x350
	FairyGUI.GTextField textLength; // 0x358
	FairyGUI.GTextField textTip; // 0x360
	FairyGUI.GTextField textContent; // 0x368
	System.Void OnInit(); // 0x05f90ca4
	System.Void OnClose2(); // 0x05f912c4
	System.Void SetData(WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo); // 0x05f91598
	System.Void RefreshModalBtnInfos(); // 0x05f919cc
	System.Void OnInputChanged(); // 0x05f917e4
	System.Void OnFocusIn(); // 0x05f92044
	System.Void OnEditClick(); // 0x05f92240
	System.Void OnSendClick(); // 0x05f92374
	System.Void OnSaveAndSendClick(); // 0x05f92650
	System.Void OnSaveClick(); // 0x05f92ac0
	System.Void OnEnable(); // 0x05f92cb4
	System.Void OnDisable(); // 0x05f92d1c
	System.Void OnDestroy(); // 0x05f92d84
	static System.Void OpenWindow(WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo); // 0x05f92dec
	System.Void .ctor(); // 0x05f92fac
	System.Void <OnClose2>b__8_0(); // 0x05f93038
	System.Void <OnEditClick>b__13_0(); // 0x05f930ac
	System.Void <OnEditClick>b__13_1(); // 0x05f93184
	System.Void <OnSaveClick>b__16_0(); // 0x05f93238
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeAnnouncementPop.<>c__DisplayClass12_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiTribeAnnouncementPop <>4__this; // 0x10
	System.String cacheName; // 0x18
	System.Void .ctor(); // 0x05f921d8
	System.Void <OnFocusIn>b__0(); // 0x05f93360
	System.Void <OnFocusIn>b__1(); // 0x05f933fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeAnnouncementPop.<>c__DisplayClass15_0 : System.Object
{
	System.String curText; // 0x10
	WizardGames.Soc.SocClient.Ui.UiTribeAnnouncementPop <>4__this; // 0x18
	System.Void .ctor(); // 0x05f92a58
	System.Void <OnSaveAndSendClick>b__0(); // 0x05f934dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeAnnouncementPop.<>c__DisplayClass20_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo; // 0x10
	System.Void .ctor(); // 0x05f92f44
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiTribeAnnouncementPop win); // 0x05f9370c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeAuditInfos : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x338
	WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo; // 0x340
	FairyGUI.GList gList; // 0x348
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.UiTribeAuditInfos.playerInfo> roleId2PlayerInfo; // 0x350
	System.Void OnInit(); // 0x05f93790
	System.Void InitModalBtnInfos(); // 0x05f93a4c
	System.Void SetData(WizardGames.Soc.SocClient.Ui.TribeInfo info); // 0x05f93d24
	System.Void RefreshView(); // 0x05f94078
	System.Void RenderAuditInfoItem(System.Int32 index, FairyGUI.GObject obj); // 0x05f942b4
	System.Void OnRefuseClick(System.String roleId, System.String name); // 0x05f946bc
	System.Void OnAgreeClick(System.String roleId, System.String name); // 0x05f94830
	System.Void OnRefuseAllClick(); // 0x05f949a4
	System.Void OnEnable(); // 0x05f94b68
	System.Void OnDisable(); // 0x05f94bd0
	System.Void OnDestroy(); // 0x05f94c38
	static System.Void OpenWindow(WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo); // 0x05f94ca0
	System.Void .ctor(); // 0x05f94e60
	System.Void <InitModalBtnInfos>b__6_0(); // 0x05f94f38
	System.Void <SetData>b__7_0(SimpleJSON.JSONArray jsonArray); // 0x05f94fac
	System.Void <OnRefuseClick>b__10_0(); // 0x05f952a0
	System.Void <OnAgreeClick>b__11_0(); // 0x05f95318
	System.Void <OnRefuseAllClick>b__12_0(); // 0x05f95390
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiTribeAuditInfos.playerInfo : System.ValueType
{
	System.String roleid; // 0x10
	System.String name; // 0x18
	System.String portrait; // 0x20
	System.Int32 level; // 0x28
	System.Int32 portraitFrame; // 0x2c
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeAuditInfos.<>c__DisplayClass16_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo; // 0x10
	System.Void .ctor(); // 0x05f94df8
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiTribeAuditInfos win); // 0x05f95408
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeAuditInfos.<>c__DisplayClass9_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiTribeAuditInfos <>4__this; // 0x10
	System.String roleId; // 0x18
	WizardGames.Soc.SocClient.Ui.UiTribeAuditInfos.playerInfo player; // 0x20
	System.Void .ctor(); // 0x05f94654
	System.Void <RenderAuditInfoItem>b__0(FairyGUI.EventContext ctx); // 0x05f9548c
	System.Void <RenderAuditInfoItem>b__1(FairyGUI.EventContext ctx); // 0x05f95514
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeConfirmPop : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonInterestTribe.ComConfirmRootBinder rootBinder; // 0x338
	System.Void OnInit(); // 0x05f9559c
	System.Void OnEnable(); // 0x05f9568c
	System.Void OnDisable(); // 0x05f959cc
	System.Void OnDestroy(); // 0x05f95a34
	static System.Void OpenWindow(); // 0x05f95adc
	System.Void .ctor(); // 0x05f95c68
	System.Void <OnEnable>b__2_0(); // 0x05f95cf4
	System.Void <OnEnable>b__2_1(); // 0x05f95d60
	System.Void <OnEnable>b__2_3(); // 0x05f95e54
	System.Void <OnEnable>b__2_2(); // 0x05f95ec0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeConfirmPop.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiTribeConfirmPop.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.UiTribeConfirmPop> <>9__5_0; // 0x8
	static System.Void .cctor(); // 0x05f95f2c
	System.Void .ctor(); // 0x05f95f90
	System.Void <OpenWindow>b__5_0(WizardGames.Soc.SocClient.Ui.UiTribeConfirmPop win); // 0x05f95ff8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeCustomTag : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x338
	System.Action<System.String> cb; // 0x340
	WizardGames.Soc.SocClient.Ui.ComInputBox comInput; // 0x348
	System.Boolean showMinLengthTip; // 0x350
	System.Collections.Generic.HashSet<System.String> curSelectedAllTagNames; // 0x358
	System.Void OnInit(); // 0x05f9606c
	System.Void InitModalBtnInfos(); // 0x05f96414
	System.Void OnInputNameChanged(); // 0x05f96714
	System.Void InputDescFocusIn(FairyGUI.EventContext ctx); // 0x05f968b8
	System.Void OnSaveClick(); // 0x05f96b28
	System.Void SetData(System.Action<System.String> callback, System.Collections.Generic.HashSet<System.String> curSelectedAllTagNames); // 0x05f96e4c
	System.Void OnEnable(); // 0x05f96ee4
	System.Void OnDisable(); // 0x05f96f90
	System.Void OnDestroy(); // 0x05f96ff8
	static System.Void OpenWindow(System.Action<System.String> callBack, System.Collections.Generic.HashSet<System.String> curSelectedAllTagNames); // 0x05f97060
	System.Void .ctor(); // 0x05f97244
	System.Void <InitModalBtnInfos>b__6_0(); // 0x05f972d0
	System.Void <InitModalBtnInfos>b__6_1(); // 0x05f97344
	System.Void <OnSaveClick>b__9_0(); // 0x05f973a8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeCustomTag.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiTribeCustomTag.<>c <>9; // 0x0
	static System.Action <>9__8_0; // 0x8
	static System.Void .cctor(); // 0x05f97458
	System.Void .ctor(); // 0x05f974bc
	System.Void <InputDescFocusIn>b__8_0(); // 0x05f97524
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeCustomTag.<>c__DisplayClass14_0 : System.Object
{
	System.Action<System.String> callBack; // 0x10
	System.Collections.Generic.HashSet<System.String> curSelectedAllTagNames; // 0x18
	System.Void .ctor(); // 0x05f971dc
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiTribeCustomTag win); // 0x05f97584
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeCustomTag.<>c__DisplayClass8_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiTribeCustomTag <>4__this; // 0x10
	System.String cacheDesc; // 0x18
	System.Void .ctor(); // 0x05f96ac0
	System.Void <InputDescFocusIn>b__1(); // 0x05f97608
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeDetail : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.CommonInterestTribe.ComTribeDetailsContentBinder contentBinder; // 0x340
	FairyGUI.GComponent upGradeRedDot; // 0x348
	WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo; // 0x350
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeMemberDetailInfo> tribeMembers; // 0x358
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeMemberDetailInfo> onLineMemers; // 0x360
	System.Boolean showCd; // 0x368
	System.Int64 lastSetPermissionTime; // 0x370
	System.Void OnInit(); // 0x05f976e8
	System.Void RefreshView(WizardGames.Soc.SocClient.Ui.TribeInfo info, System.Boolean isEnabel); // 0x05f98940
	System.Void RefreshBtnStatus(); // 0x05f997dc
	System.Void RenderTagList(); // 0x05f99b84
	System.Void RefreshMemberInfos(); // 0x05f99efc
	System.Void RefreshMemberList(); // 0x05f9ad0c
	System.Void RenderMemberListItem(System.Int32 index, FairyGUI.GObject obj); // 0x05f9b668
	System.Void RenderMemberItem(FairyGUI.GComponent item, WizardGames.Soc.SocClient.Ui.TribeMemberDetailInfo memberInfo, System.Boolean isLeader); // 0x05f9afe4
	System.Void OnBtnCopyNameClick(FairyGUI.EventContext ctx); // 0x05f9b824
	System.Void OnBtnCopyCodeClick(FairyGUI.EventContext ctx); // 0x05f9b9a0
	System.Void OnBtnShowOnLineClick(FairyGUI.EventContext ctx); // 0x05f9bb1c
	System.Void OnBtnShareClick(FairyGUI.EventContext ctx); // 0x05f9bc78
	System.Void OnEnterEditClick(FairyGUI.EventContext ctx); // 0x05f9bcf4
	System.Void OnChooseAvatarClick(FairyGUI.EventContext ctx); // 0x05f9bddc
	System.Void OnChangeNameClick(FairyGUI.EventContext ctx); // 0x05f9bef4
	System.Void OnLampClick(FairyGUI.EventContext ctx); // 0x05f9bf70
	System.Void OnExitEditClick(FairyGUI.EventContext ctx); // 0x05f9c140
	System.Void OnBtnPermissionInfoClick(FairyGUI.EventContext ctx); // 0x05f9c228
	System.Void OnBtnPermissionClick(FairyGUI.EventContext ctx); // 0x05f9c388
	System.Void OnBtnReplaceTribeClick(FairyGUI.EventContext ctx); // 0x05f9c824
	System.Void OnBtnReplaceTribeCdClick(FairyGUI.EventContext ctx); // 0x05f9cc6c
	System.Void OnBtnDismissClick(FairyGUI.EventContext ctx); // 0x05f9cecc
	System.Void OnBtnInviteClick(FairyGUI.EventContext ctx); // 0x05f9cf44
	System.Void OnBtnQuitClick(FairyGUI.EventContext ctx); // 0x05f9d27c
	System.Void OnBtnUpgradeClick(); // 0x05f9d66c
	System.Void OnFps1Update(System.Single dt); // 0x05f9a3ac
	System.Void TribeLampTitleChange(); // 0x05f9dba8
	System.Void TribeDetailChange(System.String tribeId); // 0x05f9dcb8
	System.Void MemberNumsChange(System.String tribeId); // 0x05f9ddf0
	System.Void RefreshAnnouncement(); // 0x05f9a918
	System.Void OnBtnOpenAnnouncementClick(FairyGUI.EventContext ctx); // 0x05f9e088
	System.Void OnBtnSendAnnouncementClick(FairyGUI.EventContext ctx); // 0x05f9e100
	System.Void RefreshEditorTagList(); // 0x05f9a6f4
	System.Void RenderEditorTagListItem(System.Int32 index, FairyGUI.GObject obj); // 0x05f9e43c
	System.Void DeleteSystemTag(System.Int32 deleteIndex); // 0x05f9ea30
	System.Void OnChooseTagClick(FairyGUI.EventContext ctx); // 0x05f9ebb4
	System.Void OnCustomTagClick(FairyGUI.EventContext ctx); // 0x05f9f0b0
	System.Void OnEnable(); // 0x05f9f32c
	System.Void OnDisable(); // 0x05f9f50c
	static System.Void OpenWindow(WizardGames.Soc.SocClient.Ui.TribeInfo info); // 0x05f9f7cc
	System.Void .ctor(); // 0x05f9f9c0
	System.Void <OnInit>b__8_0(); // 0x05f9fac8
	System.Void <OnChooseAvatarClick>b__21_0(System.Int32 avatarId); // 0x05f9fb3c
	System.Void <OnBtnReplaceTribeClick>b__27_0(); // 0x05f9fc4c
	System.Void <OnBtnReplaceTribeClick>b__27_1(); // 0x05f9fd40
	System.Void <OnBtnQuitClick>b__31_0(); // 0x05f9fdac
	System.Void <OnBtnQuitClick>b__31_1(); // 0x05f9fefc
	System.Void <OnBtnUpgradeClick>b__32_0(); // 0x05fa0054
	System.Void <OnBtnSendAnnouncementClick>b__39_0(); // 0x05fa014c
	System.Void <OnCustomTagClick>b__44_0(System.String tagName); // 0x05fa0330
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeDetail.<>c__DisplayClass12_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiTribeDetail <>4__this; // 0x10
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.TribeMemberInfo> tempId2TribeMemberInfo; // 0x18
	System.Void .ctor(); // 0x05f9aca4
	System.Void <RefreshMemberInfos>b__0(SimpleJSON.JSONArray jsonArray); // 0x05fa0520
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeDetail.<>c__DisplayClass30_0 : System.Object
{
	System.String tribeId; // 0x10
	System.Void .ctor(); // 0x05f9d214
	System.Void <OnBtnInviteClick>b__0(System.Collections.Generic.List<System.String> roleIds, System.String teamChangeEntrance); // 0x05fa0ca8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeDetail.<>c__DisplayClass41_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiTribeDetail <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Void .ctor(); // 0x05f9e9c8
	System.Void <RenderEditorTagListItem>b__0(); // 0x05fa0d70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeDetail.<>c__DisplayClass43_0 : System.Object
{
	System.Collections.Generic.List<System.String> curCustomTagNames; // 0x10
	WizardGames.Soc.SocClient.Ui.UiTribeDetail <>4__this; // 0x18
	System.Void .ctor(); // 0x05f9f048
	System.Void <OnChooseTagClick>b__0(System.Collections.Generic.List<System.Int32> tagIds); // 0x05fa0de0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeDetail.<>c__DisplayClass47_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.TribeInfo info; // 0x10
	System.Action<WizardGames.Soc.SocClient.Ui.UiTribeDetail> <>9__1; // 0x18
	System.Void .ctor(); // 0x05f9f958
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.TribeInfo tribe); // 0x05fa0f38
	System.Void <OpenWindow>b__1(WizardGames.Soc.SocClient.Ui.UiTribeDetail win); // 0x05fa108c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeInviteInfos : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x338
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeInviteInfo> inviteInfos; // 0x340
	FairyGUI.GList inviteList; // 0x348
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.UiTribeInviteInfos.playerInfo> roleId2PlayerInfo; // 0x350
	System.Void OnInit(); // 0x05fa1114
	System.Void InitModalBtnInfos(); // 0x05fa1448
	System.Void OnRefuseAllClick(); // 0x05fa1748
	System.Void RefreshView(); // 0x05fa1858
	System.Void RenderInviteInfoItem(System.Int32 index, FairyGUI.GObject obj); // 0x05fa1908
	System.Void RenderTagList(FairyGUI.GList list, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.TribeTagInfo> tagInfos); // 0x05fa2378
	System.Void OnRefuseClick(WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo); // 0x05fa24f0
	System.Void OnAgreeClick(WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo); // 0x05fa2640
	System.Void OnEnable(); // 0x05fa2790
	System.Void OnDisable(); // 0x05fa2b48
	System.Void OnDestroy(); // 0x05fa2bb0
	static System.Void OpenWindow(); // 0x05fa2c18
	System.Void .ctor(); // 0x05fa2ce8
	System.Void <InitModalBtnInfos>b__6_0(); // 0x05fa2e18
	System.Void <OnRefuseAllClick>b__7_0(); // 0x05fa2e8c
	System.Void <OnRefuseClick>b__11_0(); // 0x05fa2f94
	System.Void <OnAgreeClick>b__12_0(); // 0x05fa309c
	System.Void <OnEnable>b__13_0(SimpleJSON.JSONArray jsonArray); // 0x05fa31a4
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiTribeInviteInfos.playerInfo : System.ValueType
{
	System.String roleId; // 0x10
	System.String name; // 0x18
	System.String portrait; // 0x20
	System.Int32 level; // 0x28
	System.Int32 portraitFrame; // 0x2c
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeInviteInfos.<>c__DisplayClass9_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiTribeInviteInfos <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo; // 0x18
	System.Void .ctor(); // 0x05fa2310
	System.Void <RenderInviteInfoItem>b__0(FairyGUI.EventContext ctx); // 0x05fa3498
	System.Void <RenderInviteInfoItem>b__1(FairyGUI.EventContext ctx); // 0x05fa351c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeLampView : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.TribeInfo tribeInfo; // 0x338
	FairyGUI.Controller pageCtrl; // 0x340
	FairyGUI.GComponent levelDescPanel; // 0x348
	FairyGUI.GComponent histogramPanel; // 0x350
	WizardGames.Soc.SocClient.Ui.TribeMemberInfo myInfo; // 0x358
	System.Void OnInit(); // 0x05fa35a0
	System.Void OnEnable(); // 0x05fa38d8
	System.Void InitModalBtnInfos(); // 0x05fa3744
	System.Void SetData(WizardGames.Soc.SocClient.Ui.TribeInfo info); // 0x05fa3a30
	System.Void RefreshLampLevelPanel(); // 0x05fa3cac
	System.Void InitLampLevelList(); // 0x05fa437c
	System.Void RefreshLampLevelList(); // 0x05fa44d8
	System.Void OnInputTitleChanged(FairyGUI.GTextInput inputText); // 0x05fa51e8
	System.Void InputTitleFocusIn(FairyGUI.GTextInput inputText); // 0x05fa5310
	System.Int32 ListIndex2CfgIndex(System.Int32 listIndex); // 0x05fa50d0
	System.Void EnterEditLampTitle(System.Int32 index); // 0x05fa5594
	System.Void ExitEditLampTitle(); // 0x05fa57e4
	System.Void ReqChangeLampTitle(System.Int32 index); // 0x05fa59ec
	System.Void RefreshHistogramPanel(); // 0x05fa4144
	System.Void RenderHistogramItem(System.Int32 index, FairyGUI.GObject obj); // 0x05fa604c
	System.Void OnDisable(); // 0x05fa67ac
	System.Void OnDestroy(); // 0x05fa6904
	static System.Void OpenWindow(WizardGames.Soc.SocClient.Ui.TribeInfo info); // 0x05f9bfe8
	System.Void .ctor(); // 0x05fa69d4
	System.Void <InitModalBtnInfos>b__7_0(); // 0x05fa6a60
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeLampView.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiTribeLampView.<>c <>9; // 0x0
	static System.Action <>9__13_0; // 0x8
	static System.Action <>9__15_1; // 0x10
	static System.Void .cctor(); // 0x05fa6ad4
	System.Void .ctor(); // 0x05fa6b38
	System.Void <InputTitleFocusIn>b__13_0(); // 0x05fa6ba0
	System.Void <EnterEditLampTitle>b__15_1(); // 0x05fa6c00
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeLampView.<>c__DisplayClass11_0 : System.Object
{
	System.Int32 tIndex; // 0x10
	FairyGUI.GTextInput input; // 0x18
	WizardGames.Soc.SocClient.Ui.UiTribeLampView <>4__this; // 0x20
	System.Void .ctor(); // 0x05fa5068
	System.Void <RefreshLampLevelList>b__0(); // 0x05fa6c60
	System.Void <RefreshLampLevelList>b__1(); // 0x05fa6cd0
	System.Void <RefreshLampLevelList>b__2(); // 0x05fa6d40
	System.Void <RefreshLampLevelList>b__3(); // 0x05fa6db0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeLampView.<>c__DisplayClass13_0 : System.Object
{
	FairyGUI.GTextInput inputText; // 0x10
	System.String cacheDesc; // 0x18
	WizardGames.Soc.SocClient.Ui.UiTribeLampView <>4__this; // 0x20
	System.Void .ctor(); // 0x05fa552c
	System.Void <InputTitleFocusIn>b__1(); // 0x05fa6e20
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeLampView.<>c__DisplayClass15_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiTribeLampView <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Void .ctor(); // 0x05fa577c
	System.Void <EnterEditLampTitle>b__0(); // 0x05fa6ef8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTribeLampView.<>c__DisplayClass22_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.TribeInfo info; // 0x10
