
// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonRank.<>c__DisplayClass71_0 : System.Object
{
	WizardGames.Soc.SocClient.GoLoader.DisplayModel displayModel; // 0x10
	System.Void .ctor(); // 0x05dbb8e0
	System.Void <CreateModel>b__0(UnityEngine.GameObject go); // 0x05dbb948
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonRank.<>c__DisplayClass73_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiCommonRank <>4__this; // 0x10
	WizardGames.Soc.SocClient.GoLoader.DisplayModel displayModel; // 0x18
	System.Void .ctor(); // 0x05dbb9cc
	System.Void <RefreshWeaponDisplayData>b__0(WizardGames.Soc.SocClient.GoLoader.DisplayWeapon weapon); // 0x05dbba34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiAddNewResPanel : WizardGames.Soc.SocClient.Ui.UiResPanelBase
{
	System.Int32 loadedNumCache; // 0xfc
	System.Collections.Generic.List<System.Int64> get_HandleResourceItemIdList(); // 0x05dbbac0
	System.Int32 get_InputQuantityMax(); // 0x05dbbb30
	System.Void OnInit(FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.UiResHandleData uiData); // 0x05dbbc60
	System.Void OnEnable(); // 0x05dbc4b8
	System.Void OpenSet(System.Int64 itemId); // 0x05dbce84
	System.Void OnUpdateWin(); // 0x05dbcef8
	System.Void RefreshOwnedResList(); // 0x05dbd084
	System.Void RefreshPanel(); // 0x05dbd344
	System.Int32 GetResourceItemCount(System.Int64 itemId); // 0x05dbd5ac
	System.Void SetChangeText(System.Int32 changeAmount); // 0x05dbd6e4
	System.Void OnHandleBtnClick(); // 0x05dbd818
	System.Void RefreshHandleBtn(); // 0x05dbde08
	System.Void RefreshSelectedItemId(); // 0x05dbde68
	System.Void .ctor(); // 0x05dbdf4c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiAddResPanel : WizardGames.Soc.SocClient.Ui.UiResPanelBase
{
	WizardGames.Soc.SocClient.Ui.UiResPanelBase.UiResSelectBtn uiItemSelectBtn; // 0x100
	System.Int32 loadedNumCache; // 0x108
	System.Collections.Generic.List<System.Int64> get_HandleResourceItemIdList(); // 0x05dbe100
	System.Int32 get_InputQuantityMax(); // 0x05dbe170
	System.Void OnEnable(); // 0x05dbe1dc
	System.Void OnDisable(); // 0x05dbe8f8
	System.Void OpenSet(System.Int64 itemId); // 0x05dbebf4
	System.Void OnUpdateWin(); // 0x05dbed0c
	System.Void RefreshOwnedResList(); // 0x05dbef04
	System.Void RefreshPanel(); // 0x05dbf30c
	System.Int32 GetResourceItemCount(System.Int64 itemId); // 0x05dbf494
	System.Void SetChangeText(System.Int32 changeAmount); // 0x05dbf550
	System.Void OnHandleBtnClick(); // 0x05dbf684
	System.Void RefreshHandleBtn(); // 0x05dbff20
	System.Void .ctor(); // 0x05dbff80
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiNonStackResPanel : WizardGames.Soc.SocClient.Ui.UiResPanelBase
{
	System.Collections.Generic.HashSet<System.Int64> st; // 0x100
	System.Collections.Generic.List<System.Int64> _leftResItemIdList; // 0x108
	FairyGUI.GButton nonStackLoad; // 0x110
	FairyGUI.GButton nonStackUnLoad; // 0x118
	FairyGUI.GButton nonStackReplace; // 0x120
	System.Collections.Generic.List<System.Int64> get_HandleResourceItemIdList(); // 0x05dc0010
	System.Collections.Generic.List<System.Int64> get_leftResItemIdList(); // 0x05dc0080
	System.Int32 get_InputQuantityMax(); // 0x05dc050c
	System.Void OnInit(FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.UiResHandleData uiData); // 0x05dc0570
	System.Void OnClickReplace(); // 0x05dc0860
	System.Void OnEnable(); // 0x05dc0c44
	System.Void OnSelectedItemIdChange(); // 0x05dc0f68
	System.Void OpenSet(System.Int64 itemId); // 0x05dc1080
	System.Void OnUpdateWin(); // 0x05dc1198
	System.Void RefreshOwnedResList(); // 0x05dc11f8
	System.Void RefreshPanel(); // 0x05dc14b0
	System.Void RefreshHandleCom(); // 0x05dc1514
	System.Int32 GetResourceItemCount(System.Int64 itemId); // 0x05dc1574
	System.Void SetChangeText(System.Int32 changeAmount); // 0x05dc15f0
	System.Void OnHandleBtnClick(); // 0x05dc1664
	System.Void RefreshHandleBtn(); // 0x05dc16c4
	System.Void OnDisable(); // 0x05dc1724
	System.Void RenderSelectResourceList(System.Int32 index, FairyGUI.GObject obj); // 0x05dc18f0
	System.Void .ctor(); // 0x05dc1c90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRemoveResPanel : WizardGames.Soc.SocClient.Ui.UiResPanelBase
{
	WizardGames.Soc.SocClient.Ui.UiResPanelBase.UiResSelectBtn uiItemSelectBtn; // 0x100
	System.Int32 loadedNumCache; // 0x108
	System.Int32 selectedItemOwnedResAmountCache; // 0x10c
	System.Collections.Generic.List<System.Int64> get_HandleResourceItemIdList(); // 0x05dc1d64
	System.Int32 get_InputQuantityMax(); // 0x05dc1dd4
	System.Void OnEnable(); // 0x05dc1f2c
	System.Void OnDisable(); // 0x05dc220c
	System.Void OpenSet(System.Int64 itemId); // 0x05dc22ac
	System.Void OnUpdateWin(); // 0x05dc23c4
	System.Void RefreshOwnedResList(); // 0x05dc2780
	System.Void RefreshPanel(); // 0x05dc2908
	System.Int32 GetResourceItemCount(System.Int64 itemId); // 0x05dc2f54
	System.Void SetChangeText(System.Int32 changeAmount); // 0x05dc2fd4
	System.Void OnHandleBtnClick(); // 0x05dc3108
	System.Void RefreshHandleBtn(); // 0x05dc316c
	System.Void .ctor(); // 0x05dc31cc
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EResHandleType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EResHandleType Add = 0;
	static WizardGames.Soc.SocClient.Ui.EResHandleType AddNew = 1;
	static WizardGames.Soc.SocClient.Ui.EResHandleType Remove = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiResHandle : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiResHandleData uiData; // 0x10
	FairyGUI.GComponent handlePanelCom; // 0x18
	FairyGUI.GButton addPageBtn; // 0x20
	FairyGUI.Controller addPageSelectCtrl; // 0x28
	FairyGUI.GButton removePageBtn; // 0x30
	FairyGUI.Controller removePageSelectCtrl; // 0x38
	FairyGUI.GButton removeOnlyPageBtn; // 0x40
	FairyGUI.Transition showTrans; // 0x48
	FairyGUI.Transition hideTrans; // 0x50
	WizardGames.Soc.SocClient.Ui.UiResPanelBase uiAddNewResPanel; // 0x58
	WizardGames.Soc.SocClient.Ui.UiResPanelBase uiAddResPanel; // 0x60
	WizardGames.Soc.SocClient.Ui.UiResPanelBase uiRemoveResPanel; // 0x68
	WizardGames.Soc.SocClient.Ui.UiNonStackResPanel uiNonStackResPanel; // 0x70
	WizardGames.Soc.SocClient.Ui.UiResPanelBase uiCurResPanel; // 0x78
	System.Action CloseResPanelAction; // 0x80
	System.Action OpenAddNewResPanelAction; // 0x88
	System.Action<System.Int64> OpenHandleResPanelAction; // 0x90
	FairyGUI.PlayCompleteCallback hideCompleteCallback; // 0x98
	System.Void Close(); // 0x05dc325c
	System.Void OnInit(FairyGUI.GComponent root); // 0x05dc33a4
	System.Void OnInitNonStack(FairyGUI.GComponent root); // 0x05dc395c
	System.Void OnUpdate(); // 0x05dc3c68
	System.Void OpenAddNewResPanel(WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap itemContainerNode, System.Int32 index); // 0x05dc3d38
	System.Void OpenNonStackResPanel(WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap itemContainerNode, System.Int32 index, System.Int64 itemId, System.Boolean isAdd); // 0x05dc4244
	System.Void OpenHandleResPanel(WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap itemContainerNode, System.Int32 index, System.Int64 itemId, System.Boolean isAdd); // 0x05dc43b4
	System.Void SetCurResPanel(WizardGames.Soc.SocClient.Ui.UiResPanelBase openPanel, System.Int64 itemId); // 0x05dc3ff4
	System.Void SwitchToAddPage(); // 0x05dc46b8
	System.Void RefreshCurResPanel(); // 0x05dc414c
	System.Void CloseAddResPanel(); // 0x05dc32fc
	System.Void SetHandlePanelVisible(System.Boolean isVisible); // 0x05dc3ec8
	System.Void SetHandleResItemIdList(System.Collections.Generic.List<System.Int64> handleResItemIdList); // 0x05dc4898
	System.Void SetAddResItemIdList(System.Collections.Generic.List<System.Int64> addResItemIdList); // 0x05dc49f8
	System.Void SetRemoveResItemIdList(System.Collections.Generic.List<System.Int64> removeResItemIdList); // 0x05dc4b58
	System.Void SetOwnedResAmountDic(System.Collections.Generic.Dictionary<System.Int64,System.Int32> ownedResAmountDic); // 0x05dc4cb8
	System.Void SetRemoveResAmountDic(System.Collections.Generic.Dictionary<System.Int64,System.Int32> removeResAmountDic); // 0x05dc4f1c
	System.Void UpdateOwnedResCount(); // 0x05dc5180
	System.Void RefreshSelectedItemId(); // 0x05dc5268
	WizardGames.Soc.SocClient.Ui.EResHandleType GetResHandleType(); // 0x05dc4630
	System.Int32 GetInputQuantity(); // 0x05dc5328
	System.Int64 GetInputItemBizId(); // 0x05dc5398
	System.Void OnClickRemoveBtn(); // 0x05dc5408
	System.Void SetNoStackHandleResItemIdList(System.Collections.Generic.List<System.Int64> handleResItemNodeIdList); // 0x05dc54c4
	System.Void SetNoStackOwnedResAmountDic(System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.CustomType.BaseItemNode> ownedResItemNodeDic); // 0x05dc5624
	System.Void SetCanAddRes(System.Boolean canAddRes); // 0x05dc588c
	System.Void .ctor(); // 0x05dc5914
	System.Void <OnInit>b__20_0(FairyGUI.EventContext ctx); // 0x05dc5ccc
	System.Void <OnInit>b__20_1(); // 0x05dc5d44
	System.Void <OnInit>b__20_2(); // 0x05dc5da8
	System.Void <OnInitNonStack>b__21_0(FairyGUI.EventContext ctx); // 0x05dc5e1c
	System.Void <OnInitNonStack>b__21_1(); // 0x05dc5e94
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiResHandleData : System.Object
{
	WizardGames.Soc.SocClient.Ui.ItemContainerNodeParser itemContainerNodeParser; // 0x10
	System.Collections.Generic.List<System.Int64> curHandleResItemIdList; // 0x18
	System.Collections.Generic.List<System.Int64> curHandleDefaultResItemIdList; // 0x20
	System.Collections.Generic.List<System.Int64> curAddResItemIdList; // 0x28
	System.Collections.Generic.List<System.Int64> curRemoveResItemIdList; // 0x30
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> curOwnedResAmountDic; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> curRemoveResAmountDic; // 0x40
	System.Boolean canAddRes; // 0x48
	System.Int32 curSelectedIndex; // 0x4c
	System.Int64 curSelectedItemId; // 0x50
	System.Int32 curInputQuantity; // 0x58
	System.Int32 inputQuantityMin; // 0x5c
	System.Collections.Generic.List<System.Int64> tempSrcPath; // 0x60
	System.Collections.Generic.List<System.Int64> tempTargetPath; // 0x68
	System.Boolean IsNonStackState; // 0x70
	System.Collections.Generic.List<System.Int64> curNoStackHandleResItemNodeIdList; // 0x78
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.CustomType.BaseItemNode> curNoStackOwnedResItemNodeDic; // 0x80
	System.Int64 curSelectedItemNodeId; // 0x88
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap get_CurItemContainerNode(); // 0x05dbf9c8
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> get_CurContainItemList(); // 0x05dbd014
	System.Int32 get_SelectedItemOwnedResAmount(); // 0x05dbbbb4
	System.Void Clear(); // 0x05dc4774
	System.Void SetHandleResItemIdList(System.Collections.Generic.List<System.Int64> handleResItemIdList); // 0x05dc491c
	System.Void SetAddResItemIdList(System.Collections.Generic.List<System.Int64> addResItemIdList); // 0x05dc4a7c
	System.Void SetRemoveResItemIdList(System.Collections.Generic.List<System.Int64> removeResItemIdList); // 0x05dc4bdc
	System.Void SetOwnedResAmountDic(System.Collections.Generic.Dictionary<System.Int64,System.Int32> ownedResAmountDic); // 0x05dc4d3c
	System.Void SetRemoveResAmountDic(System.Collections.Generic.Dictionary<System.Int64,System.Int32> removeResAmountDic); // 0x05dc4fa0
	System.Void SetCurSelectedItemId(System.Int64 itemId); // 0x05dbce00
	System.Void SetInputQuantity(System.Int32 curInputQuantity); // 0x05dc0ffc
	System.Int32 GetNodeCount(); // 0x05dc5f08
	System.Void InventoryToOtherSide(System.Int64 itemNodeBizId, System.Int32 amount, System.Collections.Generic.IList<System.Int64> inventoryPathList, WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap container, System.Int64 targetPos); // 0x05dbfa38
	System.Void OtherSideToInventory(System.Int64 itemNodeBizId, System.Int32 amount, WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap container, System.Int64 srcPos, System.Boolean withConfirm); // 0x05dc6080
	System.Void SetNoStackHandleResItemIdList(System.Collections.Generic.List<System.Int64> handleResItemNodeIdList); // 0x05dc5548
	System.Void SetNoStackOwnedResItemNodeDic(System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.CustomType.BaseItemNode> ownedResItemNodeDic); // 0x05dc56b0
	System.Void SetCurSelectedItemNodeId(System.Int64 itemNodeId); // 0x05dc6274
	System.Void .ctor(); // 0x05dc59b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiResPanelBase : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.UiResHandleData uiData; // 0x10
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.SocClient.Ui.UiResPanelBase.UiResSelectBtn> uiItemSelectBtnDic; // 0x18
	FairyGUI.GButton selectedItemBtn; // 0x20
	FairyGUI.GTextField selectedItemText; // 0x28
	FairyGUI.GComponent handleCom; // 0x30
	FairyGUI.GComponent rootCom; // 0x38
	FairyGUI.GTextField loadedNumTextField; // 0x40
	FairyGUI.GTextField loadedChangeNumTextField; // 0x48
	FairyGUI.GTextField ownedNumTextField; // 0x50
	FairyGUI.GTextField ownedChangeNumTextField; // 0x58
	FairyGUI.GLoader openHandlePanelTouchLoader; // 0x60
	FairyGUI.GTextField touchNumTextField; // 0x68
	FairyGUI.GSlider setQuantitySlider; // 0x70
	FairyGUI.GButton minusBtn; // 0x78
	FairyGUI.GButton addBtn; // 0x80
	FairyGUI.GButton maxBtn; // 0x88
	WizardGames.Soc.SocClient.Ui.ComStateBtn handleBtn; // 0x90
	FairyGUI.GLabel handleTextField; // 0x98
	FairyGUI.Controller stateCtrl; // 0xa0
	FairyGUI.GButton emptyBtn; // 0xa8
	FairyGUI.Controller minusBtnCtrl; // 0xb0
	FairyGUI.Controller addBtnCtrl; // 0xb8
	FairyGUI.Controller maxBtnCtrl; // 0xc0
	FairyGUI.GList selectResourceList; // 0xc8
	System.Boolean needShowAddMinusBtn; // 0xd0
	FairyGUI.Controller opCtrl; // 0xd8
	System.Boolean containerHas; // 0xe0
	System.Boolean isOperateHorseSaddle; // 0xe1
	System.Boolean isFireClick; // 0xe2
	System.Collections.Generic.HashSet<System.Int64> curItemTmpIdSet; // 0xe8
	System.Int32 inputQuantityMaxCache; // 0xf0
	UnityEngine.Vector2 CounterPos; // 0xf4
	System.Collections.Generic.List<System.Int64> get_HandleResourceItemIdList(); // 0x054e7844
	System.Int32 get_InputQuantityMax(); // 0x0548ba98
	System.Collections.Generic.List<System.Int64> get_NoStackHandleResItemNodeIdList(); // 0x05dbc7d4
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.CustomType.BaseItemNode> get_NoStackOwnedResItemNodeDic(); // 0x05dc049c
	System.Void OnInit(FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.UiResHandleData uiData); // 0x05dbbd30
	System.Void OnChangePage(); // 0x05dc6360
	System.Void OnEnable(); // 0x05dbc844
	System.Void OnDisable(); // 0x05dbe96c
	System.Void OpenSet(System.Int64 itemId); // 0x055112ac
	System.Void OnUpdateWin(); // 0x055049cc
	System.Void RefreshOwnedResList(); // 0x055049cc
	System.Void UpdateOwnedResCount(); // 0x05dc51f4
	System.Void RefreshPanel(); // 0x055049cc
	System.Void RefreshPanelAddNewRes(); // 0x05dbd3a8
	System.Void RefreshHandleCom(); // 0x05dc64b8
	System.Void RefreshHandle(); // 0x05dc26b4
	System.Int32 GetResourceItemCount(System.Int64 itemId); // 0x0548c86c
	System.Int32 GetResourceItemCountAddNewRes(System.Int64 itemId); // 0x05dbd628
	System.Void OnSelectedItemIdChange(); // 0x05dc6690
	System.Void OnSetQuantityChange(System.Int32 inputNum); // 0x05dc2a70
	System.Void SetChangeText(System.Int32 changeAmount); // 0x055056e8
	System.Void OnSetQuantitySliderChange(); // 0x05dc6740
	System.Void OnClickSlider(); // 0x05dc6810
	System.Void OnMinusBtnClick(); // 0x05dc6994
	System.Void OnAddBtnClick(); // 0x05dc6a0c
	System.Void OnMaxBtnClick(); // 0x05dc6a84
	System.Void SetDefaultInputValue(); // 0x05dc41c0
	System.Void OnHandleBtnClick(); // 0x055049cc
	System.Void AddNewResHandleBtnClick(); // 0x05dbd8fc
	System.Void RemoveResHandleBtnClick(); // 0x05dc0978
	System.Void RefreshHandleBtn(); // 0x055049cc
	System.Void SetHandleVisible(System.Boolean visible); // 0x05dc65a8
	System.Void RenderSelectResourceList(System.Int32 index, FairyGUI.GObject obj); // 0x05dc6afc
	System.Void RenderSelectResourceListNoStack(System.Int32 index, FairyGUI.GButton selectBtn); // 0x05dc1ac0
	System.Void RenderSelectResourceListCanStack(System.Int32 index, FairyGUI.GButton selectBtn); // 0x05dc6bd4
	System.Void OnItemSelectBtnClick(FairyGUI.EventContext context); // 0x05dc7004
	System.Void OnItemSelectBtnClickNoStack(FairyGUI.EventContext context); // 0x05dc7208
	System.Void SetOpCtrl(System.Boolean selectEmpty); // 0x05dc0e7c
	System.Int32 GetSelectItemIndex(FairyGUI.EventContext context); // 0x05dc74dc
	System.Void SetNoStackSelectItem(System.Int32 index); // 0x05dbcc94
	System.Void .ctor(); // 0x05dbdfdc
	static System.Void .cctor(); // 0x05dc75cc
	System.Void <OnEnable>b__45_0(FairyGUI.EventContext ctx); // 0x05dc76a0
	System.Void <OnEnable>b__45_1(FairyGUI.EventContext ctx); // 0x05dc7718
	System.Void <OnEnable>b__45_2(FairyGUI.EventContext ctx); // 0x05dc7790
	System.Void <OnEnable>b__45_3(FairyGUI.EventContext ctx); // 0x05dc7808
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiResPanelBase.UiResSelectBtn : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIconLoader itemIconLoader; // 0x10
	WizardGames.Soc.SocClient.Ui.ComItemIcon itemIconCom; // 0x18
	FairyGUI.Controller existCtrl; // 0x20
	System.Void .ctor(FairyGUI.GButton btn, System.Int64 itemId); // 0x05dbe4f8
	System.Void .ctor(FairyGUI.GButton btn, WizardGames.Soc.Common.CustomType.BaseItemNode baseItemNode); // 0x05dc6d1c
	System.Void Clear(); // 0x05dbd2c4
	System.Void UpdateItemId(FairyGUI.GButton btn, System.Int64 itemId); // 0x05dbf0f8
	System.Void UpdateCount(System.Int32 count); // 0x05dbe838
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiResPanelBase.UiResSelectBtn.<>c__DisplayClass3_0 : System.Object
{
	FairyGUI.GButton btn; // 0x10
	WizardGames.Soc.Common.Data.DataItem.ItemConfig itemConfig; // 0x18
	System.Void .ctor(); // 0x05dc788c
	System.Void <.ctor>b__0(); // 0x05dc79c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiResPanelBase.UiResSelectBtn.<>c__DisplayClass4_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.BaseItemNode baseItemNode; // 0x10
	FairyGUI.GButton btn; // 0x18
	System.Void .ctor(); // 0x05dc78f4
	System.Void <.ctor>b__0(); // 0x05dc7b3c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiResPanelBase.UiResSelectBtn.<>c__DisplayClass6_0 : System.Object
{
	WizardGames.Soc.Common.Data.DataItem.ItemConfig itemConfig; // 0x10
	FairyGUI.GButton btn; // 0x18
	System.Void .ctor(); // 0x05dc795c
	System.Void <UpdateItemId>b__0(); // 0x05dc7cb0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiResPanelBase.<>c__DisplayClass42_0 : System.Object
{
	FairyGUI.GObject sliderGrip; // 0x10
	System.Void .ctor(); // 0x05dc62f8
	System.Void <OnInit>b__0(FairyGUI.EventContext ctx); // 0x05dc7e28
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonRewardDrawPop : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RewardData> rewardDataList; // 0x338
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RewardData> fragmentDataList; // 0x340
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RewardData> cacheRewardDataList; // 0x348
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RewardData> cacheFragmentDataList; // 0x350
	System.Int64 timerId; // 0x358
	UnityEngine.GameObject fxPrefabGo; // 0x360
	System.Boolean isHideByPageSake; // 0x368
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ExchangeResourceItem> exchangeResourceItemSplitList; // 0x370
	System.Collections.Generic.HashSet<System.Int32> exchangedRewardPos; // 0x378
	System.Collections.Generic.HashSet<System.Int32> expiredRewardPos; // 0x380
	WizardGames.Soc.SocClient.Ui.Binder.CommonGetReward.UiCommonRewardDrawPopBinder commonRewardDrawPopBinder; // 0x388
	WizardGames.Soc.SocClient.Ui.Binder.CommonGetReward.RootCommonRewardDrawPopBinder binder; // 0x390
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.CommonGetReward.ComGetRewardIcon_TenLotteryBinder> rewardItemComMap; // 0x398
	System.Void OnInit(); // 0x05dc7f18
	System.Void OnCloseClicked(FairyGUI.EventContext context); // 0x05dc84fc
	System.Void OnClickShareBtn(FairyGUI.EventContext context); // 0x05dc85a8
	System.Void SetBtnVisible(System.Boolean visible); // 0x05dc8850
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05dc8b8c
	System.Void OpenWin(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RewardData> rewardDataList, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RewardData> fragmentDataList); // 0x05dc90b4
	System.Void ShowExchangeRewardInfo(); // 0x05dc97ac
	System.Void RefreshExchangedItemsUI(); // 0x05dc9e10
	System.Void OnExchangedRenderRewardItem(System.Int32 index, FairyGUI.GObject obj); // 0x05dca154
	System.Void OnEnable(); // 0x05dca3b8
	System.Void OnDisable(); // 0x05dca5dc
	System.Void OnHideByLayerStack(System.String coverUiName); // 0x05dca850
	System.Void RenderRewardItem(System.Int32 index, FairyGUI.GObject obj); // 0x05dca8dc
	System.Void CheckRewardItemLoopAni(FairyGUI.GComponent rewardCom, WizardGames.Soc.SocClient.Ui.RewardData rewardData); // 0x05dcb0f8
	System.Void PlayItemAni(); // 0x05dcbc8c
	System.Void CheckIsShowRareAni(System.Int32 index, FairyGUI.GComponent com); // 0x05dcbed0
	System.Void PlayFx(); // 0x05dc9580
	System.Void ClearTimer(); // 0x05dc8fac
	System.Void .ctor(); // 0x05dcc3ac
	static System.Void .cctor(); // 0x05dcc628
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonRewardDrawPop.<>c__DisplayClass16_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiCommonRewardDrawPop <>4__this; // 0x10
	System.String state; // 0x18
	System.Void .ctor(); // 0x05dc87e8
	System.Void <OnClickShareBtn>b__0(); // 0x05dcc6fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonRewardDrawPop.<>c__DisplayClass27_0 : System.Object
{
	FairyGUI.GComponent rewardCom; // 0x10
	System.String itemAniName; // 0x18
	WizardGames.Soc.SocClient.Ui.UiCommonRewardDrawPop <>4__this; // 0x20
	WizardGames.Soc.SocClient.Ui.RewardData rewardData; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.CommonGetReward.ComGetRewardIcon_TenLotteryBinder binder; // 0x50
	FairyGUI.GComponent icon; // 0x58
	System.Action loopTransition; // 0x60
	System.Action breakTransition; // 0x68
	FairyGUI.TransitionHook <>9__3; // 0x70
	FairyGUI.TransitionHook <>9__4; // 0x78
	System.Void .ctor(); // 0x05dcbc24
	System.Void <CheckRewardItemLoopAni>b__0(); // 0x05dcc7d4
	System.Void <CheckRewardItemLoopAni>b__1(); // 0x05dcc868
	System.Void <CheckRewardItemLoopAni>b__3(); // 0x05dccc30
	System.Void <CheckRewardItemLoopAni>b__4(); // 0x05dcccc8
	System.Void <CheckRewardItemLoopAni>b__2(); // 0x05dccd60
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ERewardType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ERewardType Lobby = 1;
	static WizardGames.Soc.SocClient.Ui.ERewardType Game = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ExchangeResourceItem : System.Object
{
	System.Int64 itemId; // 0x10
	System.Int32 amount; // 0x18
	System.Void .ctor(); // 0x05dca0ec
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.RewardData : System.ValueType
{
	System.Int64 ItemId; // 0x10
	System.Int32 Num; // 0x18
	WizardGames.Soc.SocClient.Ui.ERewardType Type; // 0x1c
	System.Int64 FailureTimestamp; // 0x20
	System.Int64 ValidityPeriod; // 0x28
	System.Int32 ExchangeGroupNum; // 0x30
	System.Int32 Index; // 0x34
	System.Void .ctor(System.Int64 itemId1, System.Int32 itemNum, WizardGames.Soc.SocClient.Ui.ERewardType type, System.Int64 failureTimestamp, System.Int64 validityPeriod, System.Int32 exchangeGroupNum, System.Int32 index); // 0x05dccdd8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonRewardPop : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	FairyGUI.GList rewardItemListSmall; // 0x338
	FairyGUI.GList rewardItemListBig; // 0x340
	FairyGUI.GList exchangedItemList; // 0x348
	FairyGUI.GTextField tipsText; // 0x350
	FairyGUI.GButton closeBtn; // 0x358
	FairyGUI.Controller textVisibleCtrl; // 0x360
	FairyGUI.Controller tipsVisibleCtrl; // 0x368
	FairyGUI.GGroup exchangedGroup; // 0x370
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RewardData> rewardDataList; // 0x378
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RewardData> fragmentDataList; // 0x380
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RewardData> cacheRewardDataList; // 0x388
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RewardData> cacheFragmentDataList; // 0x390
	System.Int64 timerId; // 0x398
	UnityEngine.GameObject fxPrefabGo; // 0x3a0
	System.Boolean isHideByPageSake; // 0x3a8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ExchangeResourceItem> exchangeResourceItemSplitList; // 0x3b0
	System.Collections.Generic.HashSet<System.Int32> exchangedRewardPos; // 0x3b8
	System.Collections.Generic.HashSet<System.Int32> expiredRewardPos; // 0x3c0
	System.Collections.Generic.HashSet<System.Int32> playTransitionsSlots; // 0x3c8
	System.Void OnInit(); // 0x05dcceb4
	System.Void InitCloseButton(FairyGUI.GComponent root); // 0x05dcd2e4
	System.Void OnCloseClicked(FairyGUI.EventContext context); // 0x05dcd444
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05dcd4f0
	System.Void OnDestroy(); // 0x05dcd8e4
	System.Void OpenWin(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RewardData> rewardDataList, System.String tipStr, System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RewardData> fragmentDataList); // 0x05dcd99c
	System.Void ShowExchangeRewardInfo(); // 0x05dce0d8
	System.Void RefreshExchangedItemsUI(); // 0x05dce738
	System.Void OnExchangedRenderRewardItem(System.Int32 index, FairyGUI.GObject obj); // 0x05dce9a8
	System.Void OnEnable(); // 0x05dcec48
	System.Void OnDisable(); // 0x05dcecb8
	System.Void OnHideByLayerStack(System.String coverUiName); // 0x05dcee88
	System.Void RenderRewardItem(System.Int32 index, FairyGUI.GObject obj); // 0x05dcef14
	System.Void RefreshRewardItem(FairyGUI.GComponent rewardCom, WizardGames.Soc.SocClient.Ui.RewardData rewardData); // 0x05dd0278
	System.Void CheckRewardItemLoopAni(FairyGUI.GComponent rewardCom, WizardGames.Soc.SocClient.Ui.RewardData rewardData); // 0x05dcf84c
	System.Void PlayItemAni(); // 0x05dd04c4
	System.Void CheckIsShowRareAni(System.Int32 index, FairyGUI.GComponent com); // 0x05dd0630
	System.Void PlayFx(); // 0x05dcde48
	System.Void ClearTimer(); // 0x05dcd7dc
	System.Void .ctor(); // 0x05dd0a7c
	static System.Void .cctor(); // 0x05dd0cc4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonRewardPop.<>c__DisplayClass34_0 : System.Object
{
	FairyGUI.GComponent icon; // 0x10
	System.String itemAniName; // 0x18
	FairyGUI.GComponent rewardCom; // 0x20
	WizardGames.Soc.SocClient.Ui.UiCommonRewardPop <>4__this; // 0x28
	WizardGames.Soc.SocClient.Ui.RewardData rewardData; // 0x30
	FairyGUI.Controller rewardStateController; // 0x58
	System.Action loopTransition; // 0x60
	System.Action breakTransition; // 0x68
	FairyGUI.TransitionHook <>9__3; // 0x70
	FairyGUI.TransitionHook <>9__4; // 0x78
	System.Void .ctor(); // 0x05dd045c
	System.Void <CheckRewardItemLoopAni>b__0(); // 0x05dd0d98
	System.Void <CheckRewardItemLoopAni>b__1(); // 0x05dd0e2c
	System.Void <CheckRewardItemLoopAni>b__3(); // 0x05dd1080
	System.Void <CheckRewardItemLoopAni>b__4(); // 0x05dd1118
	System.Void <CheckRewardItemLoopAni>b__2(); // 0x05dd11b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonRoleAppPrivilegeTips : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GList roleAppPrivilegeListCom; // 0x338
	FairyGUI.GButton btnLobbyRoleAppPrivilege; // 0x340
	System.Void OnInit(); // 0x05dd1228
	System.Void OnEnable(); // 0x05dd1410
	System.Void InitUiElement(); // 0x05dd128c
	System.Void RefreshUi(); // 0x05dd14f8
	System.Void OnItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x05dd164c
	System.Void OnTouchBegin(FairyGUI.EventContext context); // 0x05dd1a1c
	System.Void OnDisable(); // 0x05dd1bb8
	System.Void CloseWindow(); // 0x05dd15e0
	System.Void .ctor(); // 0x05dd1c98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonRoleAppPrivilegeTips.<>c__DisplayClass6_0 : System.Object
{
	WizardGames.Soc.Common.Data.common.OBJPrivilege tbPrivilegeData; // 0x10
	System.Void .ctor(); // 0x05dd19b4
	System.Void <OnItemRender>b__0(System.Int32 infoIndex, FairyGUI.GObject infoObj); // 0x05dd1d24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonSharePop : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonShare.UiCommonShareBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.CommonShare.RootCommonShare_ComShareBinder shareBind; // 0x340
	WizardGames.Soc.SocClient.Ui.Binder.CommonShare.RootCommonShare_ComShotBinder shotBind; // 0x348
	FairyGUI.Controller watermarkCtrl; // 0x350
	FairyGUI.GButton playerInfoSelectBtn; // 0x358
	FairyGUI.GButton numInfoSelectBtn; // 0x360
	FairyGUI.GButton lotteryNumInfoSelectBtn; // 0x368
	UnityEngine.Texture2D showTex2D; // 0x370
	UnityEngine.Texture2D saveTex2D; // 0x378
	System.String folderName; // 0x380
	static SocLogger logger; // 0x0
	static System.Action onCloseAction; // 0x8
	WizardGames.Soc.SocClient.Ui.ECommonShareQRLogoType qrLogoType; // 0x388
	WizardGames.Soc.SocClient.Ui.ECommonShareWXLogoType wxLogoType; // 0x38c
	WizardGames.Soc.Common.Data.resource.OBJSkin skinConf; // 0x390
	System.Boolean isNewGet; // 0x398
	System.String comMarkUrl; // 0x3a0
	System.Boolean isBigPicShare; // 0x3a8
	static System.Boolean isCaptured; // 0x10
	static WizardGames.Soc.SocClient.Ui.ECommonShareWaterMarkType curMarkType; // 0x14
	static System.Boolean isSkinNewGet; // 0x18
	System.Int32 commercializationId; // 0x3ac
	FairyGUI.GComponent shotNameTitle; // 0x3b0
	FairyGUI.Controller shotSkinTitleCtrl; // 0x3b8
	System.Boolean isShowWaterMark; // 0x3c0
	System.Boolean isShowPerformance; // 0x3c1
	System.Boolean isShowNumInfo; // 0x3c2
	static System.Action<WizardGames.Soc.SocClient.Ui.UiCommonSharePop.EShareType> onShareSuccessAction; // 0x20
	WizardGames.Soc.SocClient.Ui.UiCommonSharePop.OnShareDelegate onShareDelegate; // 0x3c8
	System.Void set_QRLogoType(WizardGames.Soc.SocClient.Ui.ECommonShareQRLogoType value); // 0x05dd20a4
	WizardGames.Soc.SocClient.Ui.ECommonShareQRLogoType get_QRLogoType(); // 0x05dd211c
	System.Void OnInit(); // 0x05dd21d0
	System.Void OnShotToShare(FairyGUI.EventContext context); // 0x05dd2cb8
	System.Void RefreshWnd(System.String texPath, WizardGames.Soc.SocClient.Ui.ECommonShareWaterMarkType markType, System.String skinName, System.String skinDesc, System.Int32 skinId, System.String bgUrl, WizardGames.Soc.SocClient.Ui.ECommonShareQRLogoType qrLogoType); // 0x05dd2e90
	System.Void RefreshWnd(System.String bgUrl, WizardGames.Soc.SocClient.Ui.ECommonShareQRLogoType qrLogoType); // 0x05dd3798
	static System.Void OpenWindow(WizardGames.Soc.SocClient.Ui.ECommonShareWaterMarkType markType, System.Action closeCallback, System.String skinName, System.String skinDesc, System.Int32 skinId, System.String bgUrl, System.Boolean isNewGet, System.Int32 commercializationId, WizardGames.Soc.SocClient.Ui.ECommonShareQRLogoType qrLogoType); // 0x05dc8984
	static System.Void OpenWindow(System.Int32 leftTopX, System.Int32 leftTopY, System.Int32 rightBottomX, System.Int32 rightBottomY, System.String bgUrl, System.String text, System.Action closeCallback); // 0x05dd3a5c
	static System.Collections.IEnumerator Open(System.String bgUrl, System.String text, UnityEngine.Vector2 leftTop, UnityEngine.Vector2 rightBottom); // 0x05dd3c4c
	System.Void ShowDesc2(System.String text); // 0x05dd3d58
	System.Void InitPureWindow(System.Int32 skinId); // 0x05dd3e7c
	System.Void UpdatePlayerInfo(WizardGames.Soc.SocClient.Ui.Binder.CommonShare.ComWatermarkerDefaultBinder defaultDownMask, System.Int32 skinId); // 0x05dd45bc
	System.Void OnPlayerInfoSelectClicked(); // 0x05dd4d98
	System.Void OnNumInfoSelectClicked(); // 0x05dd4fd0
	System.Void OnLotteryNumInfoSelectClicked(FairyGUI.EventContext context); // 0x05dd5208
	System.Collections.IEnumerator StartSaveCapture(System.Boolean showTips); // 0x05dd5454
	System.Void OnSaveCapture(System.Boolean showTips); // 0x05dd5518
	System.Void SetOnCloseAction(System.Action closeCallback); // 0x05dd564c
	static System.Collections.IEnumerator Open(WizardGames.Soc.SocClient.Ui.ECommonShareWaterMarkType markType, System.String skinName, System.String skinDesc, System.Int32 skinId, System.String bgUrl, System.Int32 commercializationId, System.Boolean isNewGet, WizardGames.Soc.SocClient.Ui.ECommonShareQRLogoType qrLogoType); // 0x05dd3910
	System.Void RefreshWnd(UnityEngine.Texture2D rt, WizardGames.Soc.SocClient.Ui.ECommonShareWaterMarkType markType, System.String skinName, System.String skinDesc, System.Int32 skinId, System.String bgUrl, System.Boolean isNewGet, WizardGames.Soc.SocClient.Ui.ECommonShareQRLogoType qrLogoType); // 0x05dd56f4
	System.Void RefreshWnd(WizardGames.Soc.SocClient.Ui.ECommonShareWaterMarkType markType, System.Int32 commercializationId); // 0x05dd5984
	System.Collections.IEnumerator DelayedCapture(); // 0x05dd641c
	System.Collections.IEnumerator StartCapturePic(); // 0x05dd2de8
	System.Void UpdateShotRootUI(WizardGames.Soc.SocClient.Ui.ECommonShareWaterMarkType type, System.String skinName, System.String skinDesc, System.Int32 skinId); // 0x05dd31c4
	System.Void CapturePic(); // 0x05dd64c4
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05dd6910
	System.Void SetCommercializationConfig(WizardGames.Soc.SocClient.Ui.Binder.CommonShare.RootCommonShare_ComShotBinder binder, WizardGames.Soc.SocClient.Ui.ECommonShareWaterMarkType markType, System.Int32 id); // 0x05dd5bd8
	System.Void OnDestroy(); // 0x05dd6a28
	static System.Void SetOnShareSuccessAction(System.Action<WizardGames.Soc.SocClient.Ui.UiCommonSharePop.EShareType> action); // 0x05dd6b6c
	System.Void InitPlatformComs(); // 0x05dd2b14
	System.Void CheckQQChannel(); // 0x05dd6c00
	System.Void CheckWechatChannel(); // 0x05dd7164
	System.Boolean IsQQInstalled(); // 0x05dd76c8
	System.Boolean IsWxInstalled(); // 0x05dd7768
	System.Void OnQqBtnClicked(); // 0x05dd7808
	System.Void OnQqZoneBtnClicked(); // 0x05dd79e0
	System.Void OnWxBtnClicked(); // 0x05dd7b08
	System.Void OnWxZoneBtnClicked(); // 0x05dd7ce0
	System.Void OnQQShare(System.String path); // 0x05dd7eb8
	static System.Void UploadQQShareLog(System.Int32 isSuccess); // 0x05dd8030
	System.Void OnWxShare(System.String path); // 0x05dd8268
	static System.Void UploadWxShareLog(System.Int32 isSuccess); // 0x05dd83e0
	System.Void OnWxZoneShare(System.String path); // 0x05dd8618
	static System.Void UploadWxZoneShareLog(System.Int32 isSuccess); // 0x05dd8778
	System.Void RefreshMediaLibrary(System.String filePath); // 0x05dd89b0
	System.Void OnClickSave(System.Boolean showTips); // 0x05dd8e70
	System.Void OnSaveBackAndShowTips(System.Boolean isSuccess, System.String path); // 0x05dd92f8
	System.Void OnSaveImageBack(System.Boolean isSuccess, System.String path); // 0x05dd94f8
	System.Void OnSaveImage(System.String path); // 0x05dd9430
	System.Void .ctor(); // 0x05dd9644
	static System.Void .cctor(); // 0x05dd9738
	System.Void <OnInit>b__30_0(); // 0x05dd97e4
	System.Void <OnInit>b__30_1(); // 0x05dd9858
	System.Void <RefreshWnd>b__35_0(WizardGames.Soc.SocClient.PlatformPlayerInfo.HeadIconHandle handle); // 0x05dd98c0
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiCommonSharePop.EShareType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiCommonSharePop.EShareType QQ = 1;
	static WizardGames.Soc.SocClient.Ui.UiCommonSharePop.EShareType WX = 2;
	static WizardGames.Soc.SocClient.Ui.UiCommonSharePop.EShareType WXZone = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonSharePop.OnShareDelegate : System.MulticastDelegate
{
	
	System.Void .ctor(System.Object object, System.IntPtr method); // 0x05dd9b44
	System.Void Invoke(System.String path); // 0x05dd9c1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonSharePop.<DelayedCapture>d__52 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Ui.UiCommonSharePop <>4__this; // 0x20
	System.Void .ctor(System.Int32 <>1__state); // 0x05dd9c68
	System.Void System.IDisposable.Dispose(); // 0x05dd9cec
	System.Boolean MoveNext(); // 0x05dd9d4c
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x05dd9e64
	System.Void System.Collections.IEnumerator.Reset(); // 0x05dd9ec8
	System.Object System.Collections.IEnumerator.get_Current(); // 0x05dd9f50
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonSharePop.<Open>d__39 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.String bgUrl; // 0x20
	UnityEngine.Vector2 leftTop; // 0x28
	UnityEngine.Vector2 rightBottom; // 0x30
	System.String text; // 0x38
	System.Void .ctor(System.Int32 <>1__state); // 0x05dd9fb4
	System.Void System.IDisposable.Dispose(); // 0x05dda038
	System.Boolean MoveNext(); // 0x05dda098
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x05dda3c8
	System.Void System.Collections.IEnumerator.Reset(); // 0x05dda42c
	System.Object System.Collections.IEnumerator.get_Current(); // 0x05dda4b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonSharePop.<Open>d__49 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Ui.ECommonShareWaterMarkType markType; // 0x20
	System.Int32 commercializationId; // 0x24
	System.String skinName; // 0x28
	System.String skinDesc; // 0x30
	System.Int32 skinId; // 0x38
	System.String bgUrl; // 0x40
	System.Boolean isNewGet; // 0x48
	WizardGames.Soc.SocClient.Ui.ECommonShareQRLogoType qrLogoType; // 0x4c
	System.Void .ctor(System.Int32 <>1__state); // 0x05dda518
	System.Void System.IDisposable.Dispose(); // 0x05dda59c
	System.Boolean MoveNext(); // 0x05dda5fc
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x05dda8a0
	System.Void System.Collections.IEnumerator.Reset(); // 0x05dda904
	System.Object System.Collections.IEnumerator.get_Current(); // 0x05dda98c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonSharePop.<StartCapturePic>d__53 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Ui.UiCommonSharePop <>4__this; // 0x20
	System.Void .ctor(System.Int32 <>1__state); // 0x05dda9f0
	System.Void System.IDisposable.Dispose(); // 0x05ddaa74
	System.Boolean MoveNext(); // 0x05ddaad4
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x05ddb030
	System.Void System.Collections.IEnumerator.Reset(); // 0x05ddb094
	System.Object System.Collections.IEnumerator.get_Current(); // 0x05ddb11c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonSharePop.<StartSaveCapture>d__46 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Ui.UiCommonSharePop <>4__this; // 0x20
	System.Boolean showTips; // 0x28
	System.Void .ctor(System.Int32 <>1__state); // 0x05ddb180
	System.Void System.IDisposable.Dispose(); // 0x05ddb204
	System.Boolean MoveNext(); // 0x05ddb264
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x05ddbc98
	System.Void System.Collections.IEnumerator.Reset(); // 0x05ddbcfc
	System.Object System.Collections.IEnumerator.get_Current(); // 0x05ddbd84
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ECommonShareWaterMarkType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ECommonShareWaterMarkType None = 0;
	static WizardGames.Soc.SocClient.Ui.ECommonShareWaterMarkType Tribe = 1;
	static WizardGames.Soc.SocClient.Ui.ECommonShareWaterMarkType SKin = 2;
	static WizardGames.Soc.SocClient.Ui.ECommonShareWaterMarkType Photo = 3;
	static WizardGames.Soc.SocClient.Ui.ECommonShareWaterMarkType BattleReport = 4;
	static WizardGames.Soc.SocClient.Ui.ECommonShareWaterMarkType Down = 5;
	static WizardGames.Soc.SocClient.Ui.ECommonShareWaterMarkType Season = 6;
	static WizardGames.Soc.SocClient.Ui.ECommonShareWaterMarkType Common = 7;
	static WizardGames.Soc.SocClient.Ui.ECommonShareWaterMarkType Bundle = 8;
	static WizardGames.Soc.SocClient.Ui.ECommonShareWaterMarkType Gacha = 9;
	static WizardGames.Soc.SocClient.Ui.ECommonShareWaterMarkType FragmentLottery = 10;
	static WizardGames.Soc.SocClient.Ui.ECommonShareWaterMarkType TenLottery = 11;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ECommonShareQRLogoType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ECommonShareQRLogoType have = 0;
	static WizardGames.Soc.SocClient.Ui.ECommonShareQRLogoType hide = 1;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ECommonShareWXLogoType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ECommonShareWXLogoType have = 0;
	static WizardGames.Soc.SocClient.Ui.ECommonShareWXLogoType hide = 1;
	
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Ui.ITeamSubView : 
{
	
	System.Void set_TabType(WizardGames.Soc.SocClient.Ui.ETeamTabType value); // 0x055056e8
	System.Void OnInit(FairyGUI.GComponent root); // 0x05523a54
	System.Void OnDestory(); // 0x055049cc
	System.Void OnEnable(); // 0x055049cc
	System.Void OnDisable(); // 0x055049cc
	System.Void OnFps10Update(System.Single dt); // 0x05ddbde8
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Ui.ITeamMessagePopSubView : 
{
	
	System.Void set_TabType(WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType value); // 0x055056e8
	System.Void OnInit(FairyGUI.GComponent root); // 0x05523a54
	System.Void OnDestory(); // 0x055049cc
	System.Void OnEnable(); // 0x055049cc
	System.Void OnDisable(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TeamStaticUtil : System.Object
{
	static System.Int32 PlatformMobile; // 0x0
	static System.Int32 PlatformPc; // 0x4
	static System.Collections.Generic.List<System.Int32> GetOpenRecruitModeIds(WizardGames.Soc.SocClient.Ui.ERecruitType recruitType); // 0x05ddbe5c
	static System.Boolean IsOpenRecruit(System.Int32 modeId, WizardGames.Soc.SocClient.Ui.ERecruitType recruitType); // 0x05ddc158
	static System.Int32 GetCurModeMaxTeamCapacity(System.Int32 modeId); // 0x05ddc2e8
	static System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.RecruitOptionType,WizardGames.Soc.Common.Data.team.OBJRecruitOption> GetOptions(System.Int32 modeId, WizardGames.Soc.SocClient.Ui.ERecruitType recruitType); // 0x05ddc428
	static System.Int32[] GetAllJogTagByModeId(System.Int32 modeId); // 0x05ddc8cc
	static System.String GetRecruitTimeDesc(System.Int64 seconds, System.Boolean isAppointment); // 0x05ddcb1c
	static System.String GetRecruitFilterDesc(WizardGames.Soc.SocClient.Ui.RecruitFilterConditionData data); // 0x05ddd2cc
	static System.String GetRecruitPlayerTagPreferenceDesc(System.Collections.Generic.HashSet<System.Int32> playerTags); // 0x05ddd608
	static System.String GetRecruitCustomDesc(WizardGames.Soc.SocClient.Ui.RecruitData data); // 0x05ddd960
	static System.String ParseRecruitDescString(System.String desc); // 0x05dddd00
	static System.String ParseSelfRecommendDescString(System.String desc); // 0x05dde0b8
	static System.String ParseSelfRecommendAllDescString(System.String desc); // 0x05dde470
	static System.Void SortRecruitInfos(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RecruitData> recruitDatas, System.Collections.Generic.Dictionary<System.String,System.Int32> defaultSortDic); // 0x05ddf984
	static System.Int32 get_CurClientPlatform(); // 0x05ddfb40
	static System.Void .cctor(); // 0x05ddfbc8
	static System.Void <ParseSelfRecommendAllDescString>g__FlushRun|13_0(WizardGames.Soc.SocClient.Ui.TeamStaticUtil.<>c__DisplayClass13_0& Client.Runtime); // 0x05ddf844
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TeamStaticUtil.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.TeamStaticUtil.<>c <>9; // 0x0
	static System.Comparison<System.ValueTuple<System.String,System.String>> <>9__13_1; // 0x8
	static System.Comparison<System.ValueTuple<System.String,System.String,System.String>> <>9__13_2; // 0x10
	static System.Void .cctor(); // 0x05ddfc18
	System.Void .ctor(); // 0x05ddfc7c
	System.Int32 <ParseSelfRecommendAllDescString>b__13_1(System.ValueTuple<System.String,System.String> a, System.ValueTuple<System.String,System.String> b); // 0x05ddfce4
	System.Int32 <ParseSelfRecommendAllDescString>b__13_2(System.ValueTuple<System.String,System.String,System.String> a, System.ValueTuple<System.String,System.String,System.String> b); // 0x05ddfdac
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.TeamStaticUtil.<>c__DisplayClass13_0 : System.ValueType
{
	System.String runColor; // 0x10
	System.String tempStr; // 0x18
	System.String runContent; // 0x20
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TeamStaticUtil.<>c__DisplayClass14_0 : System.Object
{
	System.Boolean needResetSort; // 0x10
	System.Collections.Generic.Dictionary<System.String,System.Int32> defaultSortDic; // 0x18
	System.Void .ctor(); // 0x05ddfad8
	System.Int32 <SortRecruitInfos>b__0(WizardGames.Soc.SocClient.Ui.RecruitData a, WizardGames.Soc.SocClient.Ui.RecruitData b); // 0x05ddfe74
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ETeamHallListAnimType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ETeamHallListAnimType None = 0;
	static WizardGames.Soc.SocClient.Ui.ETeamHallListAnimType Refresh = 1;
	static WizardGames.Soc.SocClient.Ui.ETeamHallListAnimType Show = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ETeamShareType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ETeamShareType Tribe = 0;
	static WizardGames.Soc.SocClient.Ui.ETeamShareType World = 1;
	static WizardGames.Soc.SocClient.Ui.ETeamShareType CurBattle = 2;
	static WizardGames.Soc.SocClient.Ui.ETeamShareType Lobby = 3;
	static WizardGames.Soc.SocClient.Ui.ETeamShareType BattleToLobby = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ERecruitType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ERecruitType Lobby = 0;
	static WizardGames.Soc.SocClient.Ui.ERecruitType LobbyAppointment = 1;
	static WizardGames.Soc.SocClient.Ui.ERecruitType Battle = 2;
	static WizardGames.Soc.SocClient.Ui.ERecruitType BattleToLobby = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ERecruitSource : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ERecruitSource None = 0;
	static WizardGames.Soc.SocClient.Ui.ERecruitSource TeamHall = 1;
	static WizardGames.Soc.SocClient.Ui.ERecruitSource AppointmentHall = 2;
	static WizardGames.Soc.SocClient.Ui.ERecruitSource GameHall = 3;
	static WizardGames.Soc.SocClient.Ui.ERecruitSource Tribe = 4;
	static WizardGames.Soc.SocClient.Ui.ERecruitSource Battle = 5;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ETeamTabType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ETeamTabType QuickInvite = 0;
	static WizardGames.Soc.SocClient.Ui.ETeamTabType TeamHall = 1;
	static WizardGames.Soc.SocClient.Ui.ETeamTabType RecommendFriend = 2;
	static WizardGames.Soc.SocClient.Ui.ETeamTabType InviteInfo = 3;
	static WizardGames.Soc.SocClient.Ui.ETeamTabType MyTeam = 4;
	static WizardGames.Soc.SocClient.Ui.ETeamTabType AppointmentHall = 5;
	static WizardGames.Soc.SocClient.Ui.ETeamTabType GameHall = 6;
	static WizardGames.Soc.SocClient.Ui.ETeamTabType None = 7;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType TeamInviteInfo = 0;
	static WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType RecruitApply = 1;
	static WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType AppointmentRecruitApply = 2;
	static WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType InGameRecruitApply = 3;
	static WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType Captain = 4;
	static WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType None = 5;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EMatchState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EMatchState Matching = 0;
	static WizardGames.Soc.SocClient.Ui.EMatchState MatcheSuccess = 1;
	static WizardGames.Soc.SocClient.Ui.EMatchState Cancel = 2;
	static WizardGames.Soc.SocClient.Ui.EMatchState MatchFailed = 3;
	static WizardGames.Soc.SocClient.Ui.EMatchState None = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ETeamSource : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ETeamSource WorldChat = 0;
	static WizardGames.Soc.SocClient.Ui.ETeamSource PrivateChat = 1;
	static WizardGames.Soc.SocClient.Ui.ETeamSource Friend = 2;
	static WizardGames.Soc.SocClient.Ui.ETeamSource Search = 3;
	static WizardGames.Soc.SocClient.Ui.ETeamSource Wave = 4;
	static WizardGames.Soc.SocClient.Ui.ETeamSource Other = 5;
	static WizardGames.Soc.SocClient.Ui.ETeamSource RecommendSelf = 6;
	static WizardGames.Soc.SocClient.Ui.ETeamSource PlatformFriend = 7;
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.ModeSelectInfo : System.ValueType
{
	System.Int32 ModeId; // 0x10
	System.Int32 TeamCapacity; // 0x14
	System.Int32 ClientPlatform; // 0x18
	System.String Region; // 0x20
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ETeamType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ETeamType Normal = 0;
	static WizardGames.Soc.SocClient.Ui.ETeamType Appointment = 1;
	static WizardGames.Soc.SocClient.Ui.ETeamType BattleTeam = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamDefine : System.Object
{
	static SocLogger Log; // 0x0
	static System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ETeamSource,System.String> TeamSourceDic; // 0x8
	static System.Void .cctor(); // 0x05de03ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamDefine.TeamChangeEntrance : System.Object
{
	static System.String ChatFloating; // 0x0
	static System.String RecruitSystem; // 0x8
	static System.String CommunityChat; // 0x10
	static System.String WorldChat; // 0x18
	static System.String PrivateChat; // 0x20
	static System.String FriendNormal; // 0x28
	static System.String FriendTemp; // 0x30
	static System.String FriendPlatform; // 0x38
	static System.String CommunityMember; // 0x40
	static System.String FriendsFinder; // 0x48
	static System.String WaveInvite; // 0x50
	static System.String InvitedList; // 0x58
	static System.String SidebarPopup; // 0x60
	static System.Void .cctor(); // 0x05de061c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo : System.Object
{
	System.Boolean IsFetchedByLobby; // 0x10
	System.Int32 GameMode; // 0x14
	System.String SenderID; // 0x18
	System.String InvitationID; // 0x20
	System.Int64 InviteTime; // 0x28
	System.Int64 InviteEndTime; // 0x30
	System.String TeamID; // 0x38
	System.String GameServerId; // 0x40
	System.String GameServerName; // 0x48
	System.Boolean IsUnRead; // 0x50
	System.Int32 InviteType; // 0x54
	System.Int64 AppointmentTime; // 0x58
	System.Boolean IsAppointment; // 0x60
	System.Void .ctor(SimpleJSON.JSONNode json, System.Boolean isAppointment); // 0x05de0884
	System.Void .ctor(WizardGames.Soc.Common.CustomType.TeamInviteInfo info); // 0x05de0dd0
	System.Void SetLobbyExpireTimer(); // 0x05de0c0c
	System.Void DestorySelf(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x05de0fc0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RecruitData : System.Object
{
	System.String leaderId; // 0x10
	System.Collections.Generic.List<System.String> memberRoleIdList; // 0x18
	System.Int64 publishTime; // 0x20
	System.String requirementMsg; // 0x28
	System.String teamId; // 0x30
	System.String teamName; // 0x38
	System.Int32 teamNum; // 0x40
	System.Int32 modeId; // 0x44
	System.Boolean needAudit; // 0x48
	System.Boolean needMic; // 0x49
	System.Int64 appointmentTime; // 0x50
	System.Collections.Generic.HashSet<System.Int32> playerTagList; // 0x58
	System.Int64 openServerTime; // 0x60
	System.String serverID; // 0x68
	System.String serverName; // 0x70
	System.Int32 platform; // 0x78
	System.Int32 teamCapacity; // 0x7c
	System.Int32 regularDay; // 0x80
	System.Int32 regularTime; // 0x84
	System.String get_LeaderId(); // 0x05de10a0
	System.Collections.Generic.List<System.String> get_MemberRoleIdList(); // 0x05de1104
	System.Int64 get_PublishTime(); // 0x05de1168
	System.String get_RequirementMsg(); // 0x05de11cc
	System.String get_TeamId(); // 0x05de1230
	System.Int32 get_TeamNum(); // 0x05de1294
	System.Int32 get_ModeId(); // 0x05de12f8
	System.Boolean get_NeedAudit(); // 0x05de135c
	System.Boolean get_NeedMic(); // 0x05de13c0
	System.Int64 get_AppointmentTime(); // 0x05de1424
	System.Boolean get_IsAppointment(); // 0x05de1488
	System.Collections.Generic.HashSet<System.Int32> get_PlayerTagList(); // 0x05de14f4
	System.Int64 get_OpenServerTime(); // 0x05de1558
	System.String get_ServerID(); // 0x05de15bc
	System.String get_ServerName(); // 0x05de1620
	System.Int32 get_TeamCapacity(); // 0x05de1684
	System.Int32 get_RegularDay(); // 0x05de16e8
	System.Int32 get_RegularTime(); // 0x05de174c
	System.Void .ctor(System.String leaderId, System.Collections.Generic.List<System.String> memberRoleIds, System.Int64 publishTime, System.String requirementMsg, System.String teamId, System.String teamName, System.Int32 modeId, System.Boolean needAudit, System.Boolean needMic, System.Int64 appointmentTime, System.Collections.Generic.HashSet<System.Int32> tagList, System.Int32 platform, System.Int32 teamCapacity, System.Int32 regularDay, System.Int32 regularTime); // 0x05de17b0
	System.Void .ctor(System.String leaderId, System.Collections.Generic.List<System.String> memberRoleIds, System.Int64 publishTime, System.String requirementMsg, System.String teamId, System.String teamName, System.Int32 modeId, System.Int32 teamNum, System.Boolean needAudit, System.Boolean needMic, System.Int64 appointmentTime, System.Collections.Generic.HashSet<System.Int32> tagList, System.Int32 platform, System.Int32 teamCapacity, System.Int32 regularDay, System.Int32 regularTime); // 0x05de1ccc
	System.Void .ctor(System.Int32 modeId, System.String leaderId, System.Collections.Generic.HashSet<System.Int32> tagsSet, System.Collections.Generic.List<System.String> memberRoleIds, System.Int64 openServerTime, System.String serverID, System.String serverName, System.String requirementMsg, System.String teamId, System.String teamName, System.Boolean needMic, System.Int32 platform, System.Int32 teamCapacity, System.Int32 regularDay, System.Int32 regularTime); // 0x05de21c8
	System.Void .ctor(System.String leaderId, WizardGames.Soc.Share.Framework.BasicTypeList<System.Int32> tagsSet, System.Collections.Generic.List<System.String> memberRoleIds, System.String requirementMsg, System.String teamId, System.String teamName, System.Boolean needMic, System.Int32 teamCapacity, System.Int32 regularDay, System.Int32 regularTime); // 0x05de26d8
	System.Void ReplaceData(System.Collections.Generic.List<System.String> memberRoleIds, System.Int64 appointmentTime); // 0x05de2cec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RecruitFilterConditionData : System.Object
{
	System.Int32 ModelId; // 0x10
	System.Int32 ApplyLimit; // 0x14
	System.Int32 MicLimit; // 0x18
	System.Collections.Generic.HashSet<System.Int32> PlayerJobTag; // 0x20
	System.Int32 Platform; // 0x28
	System.Int32 TeamCapacity; // 0x2c
	System.Int32 OpenServerTime; // 0x30
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.RecruitOptionType,WizardGames.Soc.Common.Data.team.OBJRecruitOption> NeedShowOptions; // 0x38
	System.Void ReplaceData(WizardGames.Soc.SocClient.Ui.RecruitFilterConditionData data); // 0x05de2ef4
	System.Void .ctor(); // 0x05de2fac
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ETeamInviteNotifyType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ETeamInviteNotifyType Add = 0;
	static WizardGames.Soc.SocClient.Ui.ETeamInviteNotifyType Remove = 1;
	static WizardGames.Soc.SocClient.Ui.ETeamInviteNotifyType Clear = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PlayerApplyEnterTeamInfo : System.Object
{
	System.String RoleId; // 0x10
	System.Int64 ApplyTime; // 0x18
	System.Boolean IsUnRead; // 0x20
	WizardGames.Soc.SocClient.Ui.ERecruitSource RecruitSource; // 0x24
	System.String SourceTribeId; // 0x28
	System.String JoinRemark; // 0x30
	System.Void .ctor(System.String roleId, System.Int64 applyTime, System.String joinRemark, System.Int32 sourceID, System.String sourceTribeId); // 0x05de30ec
	System.Void .ctor(System.String roleId, System.String joinRemark, System.Int32 sourceID, System.String sourceTribeId); // 0x05de322c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.MyTeamRecruitData : System.Object
{
	System.String <LeaderRoleID>k__BackingField; // 0x10
	System.String <PublishTime>k__BackingField; // 0x18
	System.Boolean <NeedAudit>k__BackingField; // 0x20
	System.Boolean <NeedMic>k__BackingField; // 0x21
	System.String <RequirementMsg>k__BackingField; // 0x28
	System.String <TeamName>k__BackingField; // 0x30
	System.Int32 <RegularDay>k__BackingField; // 0x38
	System.Int32 <RegularTime>k__BackingField; // 0x3c
	System.Collections.Generic.HashSet<System.Int32> <PlayerTagList>k__BackingField; // 0x40
	System.Void set_LeaderRoleID(System.String value); // 0x05de3394
	System.String get_PublishTime(); // 0x05de3414
	System.Void set_PublishTime(System.String value); // 0x05de3478
	System.Boolean get_NeedAudit(); // 0x05de34f8
	System.Void set_NeedAudit(System.Boolean value); // 0x05de355c
	System.Boolean get_NeedMic(); // 0x05de35d8
	System.Void set_NeedMic(System.Boolean value); // 0x05de363c
	System.String get_RequirementMsg(); // 0x05de36b8
	System.Void set_RequirementMsg(System.String value); // 0x05de371c
	System.String get_TeamName(); // 0x05de379c
	System.Void set_TeamName(System.String value); // 0x05de3800
	System.Int32 get_RegularDay(); // 0x05de3880
	System.Void set_RegularDay(System.Int32 value); // 0x05de38e4
	System.Int32 get_RegularTime(); // 0x05de395c
	System.Void set_RegularTime(System.Int32 value); // 0x05de39c0
	System.Collections.Generic.HashSet<System.Int32> get_PlayerTagList(); // 0x05de3a38
	System.Void set_PlayerTagList(System.Collections.Generic.HashSet<System.Int32> value); // 0x05de3a9c
	System.Void .ctor(SimpleJSON.JSONNode json); // 0x05de3b1c
	System.Void .ctor(System.Boolean needMic, System.Boolean needAudit, System.String requirementMsg, System.String teamName, System.Collections.Generic.HashSet<System.Int32> tagList, System.Int32 regularDay, System.Int32 regularTime); // 0x05de40d8
	System.Void ReplaceData(SimpleJSON.JSONNode json); // 0x05de4524
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TeamShareCdInfo : System.Object
{
	System.String TeamId; // 0x10
	System.Int64 FirstClickTime; // 0x18
	System.Int32 ClickCount; // 0x20
	System.Void .ctor(); // 0x05de4aec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTeamInvite : System.Object
{
	static SocLogger Log; // 0x0
	FairyGUI.GComponent node; // 0x10
	WizardGames.Soc.SocClient.Ui.ComCustomButton btnRefresh; // 0x18
	WizardGames.Soc.SocClient.Ui.ComCustomButton btnSearch; // 0x20
	FairyGUI.GButton btnClear; // 0x28
	FairyGUI.GTextInput inputText; // 0x30
	FairyGUI.GList list; // 0x38
	FairyGUI.Controller controller; // 0x40
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.LobbyPlayerInfoData> searchPlayerInfoList; // 0x48
	System.Collections.Generic.Dictionary<System.String,System.Boolean> roleIdInviteDic; // 0x50
	System.Collections.Generic.HashSet<System.String> checkInviteRoleIdList; // 0x58
	System.Void .ctor(FairyGUI.GComponent root); // 0x05de4b80
	System.Void ReqRandomRoleIds(); // 0x05de5394
	System.Void ReqRolePlayerInfo(System.Collections.Generic.HashSet<System.String> roleIds); // 0x05de548c
	System.Void RendererListItem(System.Int32 index, FairyGUI.GObject obj); // 0x05de564c
	System.Void OnClickRefresh(); // 0x05de5c1c
	System.Void OnClickSearch(); // 0x05de5cf8
	System.Void OnHandleErrorCodeCallback(); // 0x05de6090
	System.Void RefreshListInfo(System.Collections.Generic.HashSet<System.String> roleIds); // 0x05de6104
	System.Void ReqCheckOKToInviteCallback(System.Collections.Generic.HashSet<System.String> canInviteRoleIds); // 0x05de62d4
	System.Void Invite(WizardGames.Soc.SocClient.Manager.LobbyPlayerInfoData player, FairyGUI.GButton btn); // 0x05de65f0
	static System.Void .cctor(); // 0x05de6864
	System.Void <.ctor>b__10_0(); // 0x05de6938
	System.Void <.ctor>b__10_1(); // 0x05de69ac
	System.Void <.ctor>b__10_2(FairyGUI.EventContext ctx); // 0x05de6a80
	System.Void <.ctor>b__10_3(FairyGUI.EventContext ctx); // 0x05de6b84
	System.Void <ReqRandomRoleIds>b__11_0(SimpleJSON.JSONNode res); // 0x05de6bfc
	System.Void <OnClickSearch>b__16_0(SimpleJSON.JSONNode res); // 0x05de6d04
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTeamInvite.<>c__DisplayClass12_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLobbyTeamInvite <>4__this; // 0x10
	System.Collections.Generic.HashSet<System.String> roleIds; // 0x18
	System.Void .ctor(); // 0x05de55e4
	System.Void <ReqRolePlayerInfo>b__0(SimpleJSON.JSONArray jsonArray); // 0x05de7250
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTeamInvite.<>c__DisplayClass13_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLobbyTeamInvite <>4__this; // 0x10
	WizardGames.Soc.SocClient.Manager.LobbyPlayerInfoData itemData; // 0x18
	FairyGUI.GButton btnInvite; // 0x20
	System.Void .ctor(); // 0x05de5bb4
	System.Void <RendererListItem>b__0(FairyGUI.EventContext ctx); // 0x05de772c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTeamInvite.<>c__DisplayClass20_0 : System.Object
{
	WizardGames.Soc.SocClient.Manager.LobbyPlayerInfoData player; // 0x10
	FairyGUI.GButton btn; // 0x18
	System.Void .ctor(); // 0x05de67fc
	System.Void <Invite>b__0(); // 0x05de77b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamGMSearch : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.UiTeamInvite uiTeamInviteGame; // 0x338
	WizardGames.Soc.SocClient.Ui.UiLobbyTeamInvite uiTeamInviteLobby; // 0x340
	FairyGUI.GButton btnClose; // 0x348
	System.Void OnInit(); // 0x05de78d0
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05de8484
	System.Void OnEnable(); // 0x05de8514
	System.Void OnDisable(); // 0x05de86b4
	System.Void OnDestroy(); // 0x05de8854
	System.Void .ctor(); // 0x05de8a14
	System.Void <OnInit>b__3_0(FairyGUI.EventContext ctx); // 0x05de8aa0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamInvite : System.Object
{
	static SocLogger Log; // 0x0
	FairyGUI.GComponent node; // 0x10
	FairyGUI.GButton btnRefresh; // 0x18
	FairyGUI.GButton btnSearch; // 0x20
	FairyGUI.GButton btnClear; // 0x28
	FairyGUI.GButton btnBack; // 0x30
	FairyGUI.GTextInput inputText; // 0x38
	FairyGUI.GList list; // 0x40
	FairyGUI.Controller controller; // 0x48
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.LobbyPlayerInfoData> listSearchInfo; // 0x50
	System.Collections.Generic.HashSet<System.String> roleIdStrList; // 0x58
	System.Void .ctor(FairyGUI.GComponent root); // 0x05de7c84
	System.Void OnInputTextChange(); // 0x05de8b84
	System.Void RemoteCallPlayerRoleIds(); // 0x05de8ca8
	System.Void Destory(); // 0x05de8908
	System.Void OnRefreshSearchBattlePlayInfo(System.Collections.Generic.List<System.UInt64> roleIds); // 0x05de8d60
	System.Void RendererListItem(System.Int32 index, FairyGUI.GObject obj); // 0x05de9004
	System.Void ClearSearchData(); // 0x05de95f4
	System.Void OnClickBack(); // 0x05de96d0
	System.Void OnClickRefresh(); // 0x05de9744
	System.Void OnClickSearch(); // 0x05de97a8
	System.Void ReqSearchInfo(); // 0x05de9a3c
	System.Void Invite(WizardGames.Soc.SocClient.Manager.LobbyPlayerInfoData user, FairyGUI.GButton btn); // 0x05de9bcc
	System.Void ReqRolePlayerInfo(System.Collections.Generic.HashSet<System.String> roleIds); // 0x05de8eac
	System.Void RefreshUi(); // 0x05de8b20
	System.Void OpenWindow(); // 0x05de8394
	System.Void OnDisable(); // 0x05de875c
	System.Void OnEnable(); // 0x05de85bc
	static System.Void .cctor(); // 0x05de9d80
	System.Void <.ctor>b__11_0(); // 0x05de9e54
	System.Void <.ctor>b__11_1(); // 0x05de9ec8
	System.Void <ReqSearchInfo>b__21_0(SimpleJSON.JSONNode res); // 0x05de9fcc
	System.Void <ReqSearchInfo>b__21_1(); // 0x05dea68c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamInvite.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiTeamInvite.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Manager.LobbyPlayerInfoData> <>9__23_1; // 0x8
	static System.Void .cctor(); // 0x05dea714
	System.Void .ctor(); // 0x05dea778
	System.Int32 <ReqRolePlayerInfo>b__23_1(WizardGames.Soc.SocClient.Manager.LobbyPlayerInfoData a, WizardGames.Soc.SocClient.Manager.LobbyPlayerInfoData b); // 0x05dea7e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamInvite.<>c__DisplayClass16_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiTeamInvite <>4__this; // 0x10
	WizardGames.Soc.SocClient.Manager.LobbyPlayerInfoData itemData; // 0x18
	FairyGUI.GButton btnInvite; // 0x20
	System.Void .ctor(); // 0x05de958c
	System.Void <RendererListItem>b__0(); // 0x05dea880
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamInvite.<>c__DisplayClass23_0 : System.Object
{
	System.Collections.Generic.HashSet<System.String> roleIds; // 0x10
	WizardGames.Soc.SocClient.Ui.UiTeamInvite <>4__this; // 0x18
	System.Void .ctor(); // 0x05de9d18
	System.Void <ReqRolePlayerInfo>b__0(SimpleJSON.JSONArray jsonArray); // 0x05deaa80
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamDepartureTips : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComTeamPromptBinder binder; // 0x338
	System.Int64 timerId; // 0x340
	System.Void OnInit(); // 0x05deb17c
	System.Void SetData(System.String modeName, System.Int32 num, System.Int32 modeId); // 0x05deb2a4
	System.Void SetData(System.String str); // 0x05deba78
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05debee4
	System.Void DestorySelf(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x05debfc0
	System.Void ClearTimer(); // 0x05deb970
	System.Void OnEnable(); // 0x05dec05c
	System.Void OnDisable(); // 0x05dec0c4
	System.Void OnDestroy(); // 0x05dec134
	System.Void .ctor(); // 0x05dec19c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamDepartureTips.<>c__DisplayClass3_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiTeamDepartureTips <>4__this; // 0x10
	System.Int32 modeId; // 0x18
	System.Void .ctor(); // 0x05deb908
	System.Void <SetData>b__0(FairyGUI.EventContext ctx); // 0x05dec228
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamRecommendFriend : System.Object, WizardGames.Soc.SocClient.Ui.ITeamSubView
{
	WizardGames.Soc.SocClient.Ui.ETeamTabType <TabType>k__BackingField; // 0x10
	System.Void set_TabType(WizardGames.Soc.SocClient.Ui.ETeamTabType value); // 0x05dec2fc
	System.Void OnInit(FairyGUI.GComponent root); // 0x05dec374
	System.Void OnDestory(); // 0x05dec3e8
	System.Void OnEnable(); // 0x05dec448
	System.Void OnDisable(); // 0x05dec4a8
	System.Void .ctor(); // 0x05dec508
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComMyTeamItemInfo : FairyGUI.GComponent
{
	WizardGames.Soc.SocClient.Ui.ComAvatarSquare authorHead; // 0x288
	WizardGames.Soc.SocClient.Ui.ComNameMedal authorName; // 0x290
	FairyGUI.GLoader authorBgLoader; // 0x298
	WizardGames.Soc.SocClient.Ui.ComNameMedal comNameMedal; // 0x2a0
	FairyGUI.GLoader medalLoader; // 0x2a8
	FairyGUI.Controller medalController; // 0x2b0
	System.String playerName; // 0x2b8
	FairyGUI.GList authorList; // 0x2c0
	FairyGUI.GList signList; // 0x2c8
	FairyGUI.GComponent authorListPanel; // 0x2d0
	System.UInt64 roleId; // 0x2d8
	System.String <RoleIdStr>k__BackingField; // 0x2e0
	System.Boolean isRank; // 0x2e8
	FairyGUI.GGraph touchGesture; // 0x2f0
	System.Single manRotateStartPosX; // 0x2f8
	UnityEngine.Vector3 manStartEulerAng; // 0x2fc
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ERoleInfoInteract> needShowBtnList; // 0x308
	UnityEngine.Transform parentRoot; // 0x310
	FairyGUI.Controller inviteStatusCtrl; // 0x318
	FairyGUI.GButton invitationBtn; // 0x320
	FairyGUI.GComponent playerCom; // 0x328
	FairyGUI.Transition speakerTransition; // 0x330
	FairyGUI.Controller voiceCtrl; // 0x338
	FairyGUI.Controller nameStatusCtrl; // 0x340
	FairyGUI.Controller captainStatusCtrl; // 0x348
	FairyGUI.Controller playerComStatusCtrl; // 0x350
	FairyGUI.GTextField lobbyTeamOnlineStatusTxt; // 0x358
	FairyGUI.Controller isPreparedCtrl; // 0x360
	FairyGUI.GButton preferenceBtn; // 0x368
	FairyGUI.Controller bodyStatusCtrl; // 0x370
	FairyGUI.GTextField playStatus; // 0x378
	FairyGUI.GImage arrowImage; // 0x380
	FairyGUI.Controller highlightStatusCtrl; // 0x388
	FairyGUI.Controller unionCtrl; // 0x390
	FairyGUI.GComponent unionInfoCom; // 0x398
	System.Int32 defaultSortingOrder; // 0x3a0
	System.Single authorListHeight; // 0x3a4
	WizardGames.Soc.SocClient.Ui.UiTeamMyTeam teamMyTeamPanel; // 0x3a8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComMyTeamItemInfo.LampInfo> lampInfoList; // 0x3b0
	System.UInt64 get_RoleId(); // 0x05dec570
	System.Void set_RoleId(System.UInt64 value); // 0x05dec5d4
	System.String get_RoleIdStr(); // 0x05dec6d0
	System.Void set_RoleIdStr(System.String value); // 0x05dec734
	System.Void SetTeamMyTeamPanel(WizardGames.Soc.SocClient.Ui.UiTeamMyTeam panel); // 0x05dec7b4
	System.Void OnInit(); // 0x05dec834
	System.Void OnRootCapture(FairyGUI.EventContext context); // 0x05ded66c
	System.Void SetParentRoot(UnityEngine.Transform parentRoot); // 0x05ded7dc
	System.Void OnClickPreference(); // 0x05ded85c
	System.Void OnClickInvitation(FairyGUI.EventContext context); // 0x05ded960
	System.Void OnClickAuthorItem(FairyGUI.EventContext context); // 0x05dede88
	System.Void CloseAuthorPanel(); // 0x05dee95c
	System.Void OnCallToBackBattle(); // 0x05dee540
	System.Void OnChangeCaptain(); // 0x05dee3fc
	System.Void OnKickOut(); // 0x05dee2c8
	System.Void OnGivePermission(); // 0x05dee040
	System.Void OnRevokePermission(); // 0x05dee184
	System.Void OnSignItemRender(System.Int32 index, FairyGUI.GObject item); // 0x05deea5c
	System.Void OnAuthorItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x05deeb80
	System.Void Highlight(); // 0x05deee10
	System.Void RefreshPlayerVoiceState(); // 0x05deeea0
	System.Void OnManRotateTouchMove(FairyGUI.EventContext ctx); // 0x05def280
	System.Void OnManRotateTouchBegin(FairyGUI.EventContext ctx); // 0x05def514
	System.Void OnClickChat(); // 0x05dee744
	System.Void OnClickAddFriend(); // 0x05dee81c
	System.Void OnClickAuthor(); // 0x05def690
	System.Void OpenAuthorPanel(); // 0x05def944
	System.Void SetInviteStatusInvite(); // 0x05df0408
	System.Void RefreshInfo(System.UInt64 roleId, System.Boolean isRank); // 0x05df04a4
	System.Void SetInviteStatus(System.Boolean showInvite); // 0x05df0c24
	System.Void RefreshStatus(); // 0x05df091c
	System.Void RefreshUnionInfo(System.String roleid, System.String communityID); // 0x05df0cec
	System.Void SetUnionInfoCom(WizardGames.Soc.SocClient.Ui.UnionInfo info); // 0x05df0f94
	System.Void Clear(); // 0x05df136c
	System.Void .ctor(); // 0x05df1494
	System.Void <OnClickChat>g__deal|68_0(WizardGames.Soc.SocClient.Ui.UiChat chat); // 0x05df15a0
	System.Void <RefreshUnionInfo>b__76_0(SimpleJSON.JSONNode info); // 0x05df16ec
	System.Void <RefreshUnionInfo>b__76_1(); // 0x05df17cc
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.ComMyTeamItemInfo.LampInfo : System.ValueType
{
	System.Int32 Level; // 0x10
	System.String Title; // 0x18
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComMyTeamItemInfo.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.ComMyTeamItemInfo.<>c <>9; // 0x0
	static System.Action<System.Collections.Generic.List<System.String>,System.String> <>9__54_0; // 0x8
	static System.Void .cctor(); // 0x05df1854
	System.Void .ctor(); // 0x05df18b8
	System.Void <OnClickInvitation>b__54_0(System.Collections.Generic.List<System.String> roleIds, System.String teamChangeEntrance); // 0x05df1920
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComMyTeamItemInfo.<>c__DisplayClass73_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComMyTeamItemInfo <>4__this; // 0x10
	System.UInt64 roleId; // 0x18
	System.Boolean isRank; // 0x20
	System.Void .ctor(); // 0x05df08b4
	System.Void <RefreshInfo>b__0(SimpleJSON.JSONNode jsonNode); // 0x05df1b24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamMyTeam : System.Object, WizardGames.Soc.SocClient.Ui.ITeamSubView
{
	static SocLogger <Logger>k__BackingField; // 0x0
	FairyGUI.GButton btnQuitTeam; // 0x10
	WizardGames.Soc.SocClient.Manager.PreviewScene curPreviewScene; // 0x18
	UnityEngine.Camera camPlayerModel; // 0x20
	UnityEngine.GameObject[] modelRootList; // 0x28
	System.Collections.Generic.Dictionary<System.UInt64,WizardGames.Soc.SocClient.Ui.UiTeamMyTeam.TeamMember> displayModelDic; // 0x30
	FairyGUI.GComponent root; // 0x38
	UnityEngine.AzureSky.AzureWeatherPresetEnum preTODEnum; // 0x40
	FairyGUI.GButton btnRecruit; // 0x48
	FairyGUI.Transition btnRecruitAnim; // 0x50
	FairyGUI.Transition btnRecruitStopAnim; // 0x58
	FairyGUI.Controller recruitTypeCtrl; // 0x60
	FairyGUI.GButton btnMessage; // 0x68
	FairyGUI.Controller hasTeamCtrl; // 0x70
	FairyGUI.GButton btnPublishLobbyRecruit; // 0x78
	FairyGUI.Controller unionTeamCtrl; // 0x80
	FairyGUI.GComponent btnUnionTeam; // 0x88
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComMyTeamItemInfo> teamUIInfoList; // 0x90
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.TeamMemberInfo> teamServerDataList; // 0x98
	WizardGames.Soc.SocClient.Ui.ETeamTabType <TabType>k__BackingField; // 0xa0
	System.Int32 MAX_TEAM_SHOW_NUM; // 0xa4
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiTeamMyTeam.RecruitBtnInfo> recruitBtnInfos; // 0xa8
	FairyGUI.GButton btnShareTeam; // 0xb0
	FairyGUI.GButton btnInviteFriend; // 0xb8
	FairyGUI.GLoader btnInviteFriendIconLoader; // 0xc0
	FairyGUI.Transition btnInviteFriendAnim; // 0xc8
	FairyGUI.Transition btnInviteFriendStopAnim; // 0xd0
	WizardGames.Soc.SocClient.Ui.TeamShareListPanel teamShareListPanel; // 0xd8
	FairyGUI.GTextField tipsText; // 0xe0
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0xe8
	FairyGUI.GButton bgBtn; // 0xf0
	static SocLogger get_Logger(); // 0x05df228c
	FairyGUI.GButton get_BtnPublishLobbyRecruit(); // 0x05df2314
	System.Void set_TabType(WizardGames.Soc.SocClient.Ui.ETeamTabType value); // 0x05df2410
	System.Int32 get_CurTeamMaxMemberCount(); // 0x05df2488
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.ComTopBar topBar); // 0x05df2524
	System.Void OnInit(FairyGUI.GComponent root); // 0x05df26a8
	System.Void SetTipsText(); // 0x05df3694
	System.Void OnRootCapture(FairyGUI.EventContext context); // 0x05ded6fc
	System.Void ShowBgBtn(); // 0x05def8d0
	System.Void PlayInviteFrinedAnim(); // 0x05df3984
	System.Void OnClickMessage(); // 0x05df3c8c
	System.Void RefreshGameRecruitButtonTitle(); // 0x05df3cf4
	System.Void RefreshDownBtns(); // 0x05df3e6c
	WizardGames.Soc.SocClient.GoLoader.DisplayModel CreateModel(UnityEngine.Transform parent, WizardGames.Soc.Common.CustomType.TeamMemberInfo memberInfo, System.Int64 defaultModelId); // 0x05df4080
	System.Void RefreshModelCustomizeDataByRoleId(WizardGames.Soc.Common.CustomType.TeamMemberInfo memberInfo, WizardGames.Soc.Common.CustomType.PlayerDisplayData displayData, WizardGames.Soc.SocClient.GoLoader.DisplayModel displayModel); // 0x05df46a4
	System.Void RefreshWeaponDisplayData(WizardGames.Soc.SocClient.GoLoader.DisplayModel displayModel, WizardGames.Soc.Common.CustomType.TeamMemberInfo memberInfo, WizardGames.Soc.Common.CustomType.PlayerDisplayData displayData); // 0x05df4e78
	System.Void AfterWeaponLoaded(WizardGames.Soc.SocClient.GoLoader.DisplayWeapon weapon, WizardGames.Soc.SocClient.GoLoader.DisplayModel displayModel); // 0x05df5554
	System.Void OnClickBtnInviteFriend(); // 0x05df5720
	System.Void OnClickPublishLobbyRecruit(); // 0x05df5c6c
	System.Void OnClickPublishGameRecruit(); // 0x05df5fcc
	System.Void OnTouchBegin(FairyGUI.EventContext context); // 0x05df6258
	System.Void OnClickBottomShareBtn(); // 0x05df6538
	System.Void CloseSharePanel(); // 0x05df6694
	System.Void SetExpandSharePanel(System.Boolean isExpand); // 0x05df6448
	System.Void InitRecruitNodes(); // 0x05df2ce8
	System.Void OnRecruitBtnListRender(System.Int32 index, FairyGUI.GObject item); // 0x05df66fc
	System.Void RefreshRecruitBtnsVisible(); // 0x05df6934
	System.Void OnTeamUpdateDisplayData(); // 0x05df6d28
	System.Void OnNextViewGuide(System.Int32 guideId, System.Int32 stepId); // 0x05df78a8
	System.Void OnCheckTeammateTerritoryCabinetAck(System.UInt64 teammateRoleId, System.Int32 code); // 0x05df7a6c
	System.Void GameRecruitChange(); // 0x05df8180
	System.Void OnTeamCreate(); // 0x05df81e4
	System.Void OnTeamClear(); // 0x05df8678
	System.Void OnTeamUIClear(); // 0x05df8920
	System.Boolean HasTeam(); // 0x05df89dc
	System.Void OnTeammateLoginNotice(System.UInt64 roleId); // 0x05df8b1c
	System.Void OnRefreshItemInfo(); // 0x05df8bb0
	System.Void RefreshStatus(); // 0x05df8cfc
	System.Void OnTeamMemberDictChange(WizardGames.Soc.Share.Framework.ECustomDictOpType changeType, System.UInt64 roleId, WizardGames.Soc.Common.CustomType.TeamMemberInfo oldMember); // 0x05df8dc0
	System.Void OnClickQuitTeam(); // 0x05df98d8
	System.Void SetTeamServerDataList(); // 0x05df99bc
	System.Void RefreshCurPreviewScene(); // 0x05df34a0
	System.Void SetPlayerComPos(); // 0x05df9e34
	System.Void ReleaseAllModels(); // 0x05df8774
	System.Void RefreshModel(); // 0x05dfa0d4
	System.Void RefreshModelInfo(); // 0x05df9088
	System.Void CreatePlayModel(System.Int32 index, WizardGames.Soc.Common.CustomType.TeamMemberInfo memberInfo, System.Boolean gotInfo); // 0x05dfa58c
	System.Void RemoveModel(System.UInt64 roleId); // 0x05df8fa4
	System.Void OnRefreshPlayerModelInfo(); // 0x05df6fe0
	System.Boolean EqualWeaponDisplayDataList(WizardGames.Soc.Common.CustomType.WeaponDisplayData data1, WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.WeaponDisplayData> dataList); // 0x05df5438
	System.Boolean EqualWeaponDisplayData(WizardGames.Soc.Common.CustomType.WeaponDisplayData data1, WizardGames.Soc.Common.CustomType.WeaponDisplayData data2); // 0x05dfa990
	System.Boolean EqualEquipmentDisplayDataList(WizardGames.Soc.Common.CustomType.EquipmentDisplayData data1, WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.EquipmentDisplayData> dataList); // 0x05df4d5c
	System.Boolean EqualEquipmentDisplayData(WizardGames.Soc.Common.CustomType.EquipmentDisplayData data1, WizardGames.Soc.Common.CustomType.EquipmentDisplayData data2); // 0x05dfaa68
	System.Void OnEnable(); // 0x05dfab40
	System.Void OnClickTeamTip(System.String roleId); // 0x05dfb2a0
	System.Void RecoverTODOnExit(); // 0x05dfb414
	System.Void ReleaseScene(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x05dfb578
	System.Void UpdatePublishRecruitBtnCd(); // 0x05dfb658
	System.Void RefreshUnionTeam(System.Action<System.Boolean> action); // 0x05dfa6f4
	System.Void OnDisable(); // 0x05dfb944
	System.Void OnFps10Update(System.Single dt); // 0x05dfc25c
	System.Void OnDestory(); // 0x05dfc464
	System.Void InitDownList(); // 0x05df32bc
	System.Void SetDownListVisible(System.Boolean visible); // 0x05dfb22c
	System.Void SetbBnInviteFriendIcon(System.String url); // 0x05df3bf8
	System.Void RefreshTeamInfoByAided(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, System.Int64 oldValue, System.Int64 newValue); // 0x05dfc4c4
	System.Void RefreshTeamInfoByLifeCycle(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, System.Int32 oldValue, System.Int32 newValue); // 0x05dfc60c
	System.Void RefreshTeamInfoByOnline(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, System.Boolean oldValue, System.Boolean newValue); // 0x05dfc754
	System.Void RefreshTeamInfoByCharacter(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, System.Byte oldValue, System.Byte newValue); // 0x05dfc89c
	System.Void RefreshTeamInfoByUnAlive(WizardGames.Soc.Share.Framework.CustomTypeBase customTypeBase, System.Byte oldValue, System.Byte newValue); // 0x05dfc9e4
	System.Void OnTeamSubscribeFieldChange(); // 0x05df8250
	System.Void OnTeamUnSubscribeFieldChange(); // 0x05dfbee8
	System.Void StatusSubscribeFieldChange(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x05df95a4
	System.Void StatusUnSubscribeFieldChange(WizardGames.Soc.Common.Entity.PlayerEntity playerEntity); // 0x05df927c
	static System.Void .cctor(); // 0x05dfcb2c
	System.Void <OnInit>b__47_0(); // 0x05dfcc00
	System.Void <RefreshDownBtns>b__54_0(); // 0x05dfcca8
	System.Void <RefreshDownBtns>b__54_1(); // 0x05dfcd0c
	System.Void <RefreshCurPreviewScene>b__83_0(UnityEngine.GameObject a, UnityEngine.GameObject b); // 0x05dfcd70
	System.Void <RefreshModelInfo>b__87_0(System.Boolean isUnionTeam); // 0x05dfcf98
	System.Void <RefreshModelInfo>b__87_1(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x05dfd050
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamMyTeam.TeamMember : System.Object
{
	WizardGames.Soc.SocClient.GoLoader.DisplayModel model; // 0x10
	WizardGames.Soc.SocClient.GoLoader.DisplayModel defaultModel; // 0x18
	System.Boolean isSelf; // 0x20
	System.Single startLoadTime; // 0x24
	System.Boolean gotInfo; // 0x28
	System.Boolean showRealModel; // 0x29
	UnityEngine.Transform parent; // 0x30
	System.UInt64 roleId; // 0x38
	System.Void .ctor(WizardGames.Soc.Common.CustomType.TeamMemberInfo memberInfo, UnityEngine.Transform parent, System.Boolean gotInfo, WizardGames.Soc.SocClient.Ui.UiTeamMyTeam parentView); // 0x05dfd4f0
	System.Void Release(); // 0x05dfd664
	System.Void SetParent(UnityEngine.Transform parent); // 0x05dfd704
	System.Void ShowDefaultModel(WizardGames.Soc.SocClient.Ui.UiTeamMyTeam parentView); // 0x05dfd7b0
	System.Void Refresh(WizardGames.Soc.Common.CustomType.PlayerDisplayData displayData); // 0x05dfd94c
	System.Void RefreshCustomize(); // 0x05dfda80
	System.Void Update(System.Single dt); // 0x05dfdaf0
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiTeamMyTeam.ERecruiteBtnType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiTeamMyTeam.ERecruiteBtnType Lobby = 0;
	static WizardGames.Soc.SocClient.Ui.UiTeamMyTeam.ERecruiteBtnType Game = 1;
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiTeamMyTeam.RecruitBtnInfo : System.ValueType
{
	System.String Name; // 0x10
	System.Action OnClick; // 0x18
	WizardGames.Soc.SocClient.Ui.UiTeamMyTeam.ERecruiteBtnType Type; // 0x20
	FairyGUI.GButton Button; // 0x28
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamMyTeam.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiTeamMyTeam.<>c <>9; // 0x0
	static System.Action<System.Collections.Generic.List<System.String>,System.String> <>9__59_0; // 0x8
	static System.Action <>9__71_1; // 0x10
	static System.Comparison<WizardGames.Soc.Common.CustomType.TeamMemberInfo> <>9__82_0; // 0x18
	static System.Void .cctor(); // 0x05dfdcd0
	System.Void .ctor(); // 0x05dfdd34
	System.Void <OnClickBtnInviteFriend>b__59_0(System.Collections.Generic.List<System.String> roleIds, System.String teamChangeEntrance); // 0x05dfdd9c
	System.Void <OnCheckTeammateTerritoryCabinetAck>b__71_1(); // 0x05dfdfa0
	System.Int32 <SetTeamServerDataList>b__82_0(WizardGames.Soc.Common.CustomType.TeamMemberInfo p1, WizardGames.Soc.Common.CustomType.TeamMemberInfo p2); // 0x05dfe03c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamMyTeam.<>c__DisplayClass100_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiTeamMyTeam <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.UnionInfo unionInfo; // 0x18
	System.Action<System.Boolean> action; // 0x20
	System.Void .ctor(); // 0x05dfe1ac
	System.Void <RefreshUnionTeam>b__0(System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UnionMember> lst); // 0x05dfe214
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamMyTeam.<>c__DisplayClass55_0 : System.Object
{
	WizardGames.Soc.SocClient.GoLoader.DisplayModel displayModel; // 0x10
	System.Void .ctor(); // 0x05dfe44c
	System.Void <CreateModel>b__0(UnityEngine.GameObject go); // 0x05dfe4b4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamMyTeam.<>c__DisplayClass57_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiTeamMyTeam <>4__this; // 0x10
	WizardGames.Soc.SocClient.GoLoader.DisplayModel displayModel; // 0x18
	System.Void .ctor(); // 0x05dfe538
	System.Void <RefreshWeaponDisplayData>b__0(WizardGames.Soc.SocClient.GoLoader.DisplayWeapon weapon); // 0x05dfe5a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamMyTeam.<>c__DisplayClass67_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiTeamMyTeam.RecruitBtnInfo info; // 0x10
	System.Void .ctor(); // 0x05dfe62c
	System.Void <OnRecruitBtnListRender>b__0(); // 0x05dfe694
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamMyTeam.<>c__DisplayClass71_0 : System.Object
{
	System.String contentText; // 0x10
	System.UInt64 teammateRoleId; // 0x18
	System.Action <>9__2; // 0x20
	System.Void .ctor(); // 0x05dfe704
	System.Void <OnCheckTeammateTerritoryCabinetAck>b__0(System.String name); // 0x05dfe76c
	System.Void <OnCheckTeammateTerritoryCabinetAck>b__2(); // 0x05dfec34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamMyTeam.<>c__DisplayClass86_0 : System.Object
{
	System.UInt64 roleId; // 0x10
	System.Void .ctor(); // 0x05dfecd4
	System.Boolean <RefreshModel>b__0(WizardGames.Soc.Common.CustomType.TeamMemberInfo t); // 0x05dfed3c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TeamShareListPanel : System.Object
{
	FairyGUI.GComponent root; // 0x10
	FairyGUI.GList gList; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ETeamShareType> shareTypes; // 0x20
	WizardGames.Soc.SocClient.Ui.ETeamType curTeamType; // 0x28
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ETeamShareType,FairyGUI.GButton> hasCdButtons; // 0x30
	System.Int64 timerId; // 0x38
	System.Int32 cdTotalTime; // 0x40
	System.Int32 leftShareCdTime; // 0x44
	System.Int32 leftSendChatCdTime; // 0x48
	System.String teamId; // 0x50
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ETeamShareType,System.String> shareTypeTexts; // 0x58
	System.Boolean get_Visible(); // 0x05dfedd0
	System.Void .ctor(FairyGUI.GComponent listPanel); // 0x05dfee78
	System.Void SetData(WizardGames.Soc.SocClient.Ui.ETeamType curTeamType); // 0x05dff150
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ETeamShareType> GetETeamShareTypesByTeamType(WizardGames.Soc.SocClient.Ui.ETeamType teamType); // 0x05dff1c8
	System.Void SetVisible(System.Boolean visible); // 0x05dff720
	System.Void ItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x05dffd90
	System.Void OnClickShareItem(WizardGames.Soc.SocClient.Ui.ETeamShareType shareType); // 0x05e00028
	System.Void RefreshShareCdStatus(); // 0x05dff854
	System.Void BeginCdTimer(); // 0x05e00b98
	System.Void ClearTimer(); // 0x05dffc88
	System.Void <OnClickShareItem>b__18_0(WizardGames.Soc.SocClient.Ui.UiCommonTeamLobby win); // 0x05e00d2c
	System.Void <BeginCdTimer>b__20_0(System.Int64 _, System.Object _, System.Boolean delete); // 0x05e00dc0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TeamShareListPanel.<>c__DisplayClass17_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.TeamShareListPanel <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.ETeamShareType shareType; // 0x18
	System.Void .ctor(); // 0x05dfffc0
	System.Void <ItemRenderer>b__0(); // 0x05e01280
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiApplyJoinTeam : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComApplyJoinBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x340
	System.Action<System.String,SimpleJSON.JSONArray> action; // 0x348
	WizardGames.Soc.SocClient.Ui.ComInputBox descInput; // 0x350
	System.Boolean needAudit; // 0x358
	System.Int32 get_selectedTagLimit(); // 0x05e012f0
	System.Void OnInit(); // 0x05e013d8
	System.Void InputDescFocusIn(FairyGUI.EventContext ctx); // 0x05e02140
	System.Void OnChangeDescWordsInput(); // 0x05e023b0
	System.Void InitModalBtnInfos(); // 0x05e017e8
	System.Void InitQuickTextList(); // 0x05e01aa4
	System.Void QuickTextItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x05e02640
	System.Void InitTagList(); // 0x05e01cac
	System.Void TagItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x05e028f4
	System.Void TagItemClick(System.Int32 index); // 0x05e02be0
	SimpleJSON.JSONArray GetSelectedTagsJsonArrayValue(); // 0x05e031e4
	System.Collections.Generic.List<System.Int32> GetSelectedTagListValue(); // 0x05e034f0
	System.Void OnBtnClick(); // 0x05e03824
	System.Void CloseView(); // 0x05e03ac0
	System.Void SetData(System.Boolean needAudit, System.Action<System.String,SimpleJSON.JSONArray> cb); // 0x05e03b2c
	System.Void OnEnable(); // 0x05e03cac
	static System.Void OpenWindow(System.Boolean needAudit, System.Action<System.String,SimpleJSON.JSONArray> cb); // 0x05e03e00
	System.Void OnDisable(); // 0x05e040ac
	System.Void OnDestroy(); // 0x05e041b0
	System.Void .ctor(); // 0x05e04218
	System.Void <InitModalBtnInfos>b__10_0(); // 0x05e042a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiApplyJoinTeam.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiApplyJoinTeam.<>c <>9; // 0x0
	static System.Action <>9__8_0; // 0x8
	static System.Void .cctor(); // 0x05e04318
	System.Void .ctor(); // 0x05e0437c
	System.Void <InputDescFocusIn>b__8_0(); // 0x05e043e4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiApplyJoinTeam.<>c__DisplayClass12_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiApplyJoinTeam <>4__this; // 0x10
	WizardGames.Soc.Common.Data.team.OBJRemarkOption info; // 0x18
	System.Void .ctor(); // 0x05e0288c
	System.Void <QuickTextItemRender>b__0(); // 0x05e04444
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiApplyJoinTeam.<>c__DisplayClass14_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiApplyJoinTeam <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Void .ctor(); // 0x05e02b78
	System.Void <TagItemRender>b__0(); // 0x05e04578
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiApplyJoinTeam.<>c__DisplayClass22_0 : System.Object
{
	System.Boolean needAudit; // 0x10
	System.Action<System.String,SimpleJSON.JSONArray> cb; // 0x18
	System.Void .ctor(); // 0x05e04044
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiApplyJoinTeam win); // 0x05e045e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiApplyJoinTeam.<>c__DisplayClass8_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiApplyJoinTeam <>4__this; // 0x10
	System.String cacheDesc; // 0x18
	System.Void .ctor(); // 0x05e02348
	System.Void <InputDescFocusIn>b__1(); // 0x05e04670
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCreateTeam : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x338
	WizardGames.Soc.SocClient.Ui.ComComboBox comComboBox; // 0x340
	System.Action createSuccessCb; // 0x348
	System.Int32 modeId; // 0x350
	System.Void OnInit(); // 0x05e04750
	System.Void InitModalBtnInfos(); // 0x05e049f0
	System.Void InitComBox(); // 0x05e04cd4
	System.Void ComBoxChange(System.Int32 index); // 0x05e0511c
	System.Void OnCreateClick(); // 0x05e051b0
	System.Void SetData(System.Action cb); // 0x05e052e8
	System.Void OnEnable(); // 0x05e05368
	static System.Void Open(System.Action cb); // 0x05e053d0
	System.Void OnDisable(); // 0x05e0565c
	System.Void OnDestroy(); // 0x05e056c4
	System.Void .ctor(); // 0x05e0573c
	System.Void <InitModalBtnInfos>b__5_0(); // 0x05e057c8
	System.Void <InitModalBtnInfos>b__5_1(); // 0x05e0583c
	System.Void <OnCreateClick>b__8_0(); // 0x05e058a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCreateTeam.<>c__DisplayClass11_0 : System.Object
{
	System.Action cb; // 0x10
	System.Void .ctor(); // 0x05e055f4
	System.Void <Open>b__0(WizardGames.Soc.SocClient.Ui.UiCreateTeam win); // 0x05e05928
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPublishGameRecruit : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	SocLogger log; // 0x338
	WizardGames.Soc.SocClient.Ui.RecruitDescOption recruitDescOption; // 0x340
	WizardGames.Soc.SocClient.Ui.RecruitMicOption micOption; // 0x348
	WizardGames.Soc.SocClient.Ui.RecruitTeamNameOption teamNameOption; // 0x350
	WizardGames.Soc.SocClient.Ui.RecruitPlayerTagOption playerTagOption; // 0x358
	WizardGames.Soc.SocClient.Ui.RecruitAlwaysTimeOption regularDayOption; // 0x360
	WizardGames.Soc.SocClient.Ui.RecruitAlwaysTimeOption regularTimeOption; // 0x368
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x370
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComConditionsBinder conditionsBinder; // 0x378
	FairyGUI.GButton btnShowMore; // 0x380
	WizardGames.Soc.SocClient.Ui.MyTeamRecruitData myTeamRecruitData; // 0x388
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.RecruitOptionType,WizardGames.Soc.Common.Data.team.OBJRecruitOption> needShowOptions; // 0x390
	System.Boolean isPublishToLobby; // 0x398
	System.String viewOpenSource; // 0x3a0
	System.Boolean hasTeam; // 0x3a8
	System.Void OnInit(); // 0x05e059f8
	System.Void InitModalBtnInfos(); // 0x05e05ed0
	System.Void SetViewName(); // 0x05e06810
	System.Void InitAllOptions(); // 0x05e061a8
	System.Void InitData(System.Boolean isPublishToLobby, System.String openSource); // 0x05e0739c
	System.Void RefreshExtendOptions(); // 0x05e0760c
	System.Void RefreshRecruitDescOption(); // 0x05e07698
	System.Void RefreshTeamNameOption(); // 0x05e07720
	System.Void RefreshMicOption(); // 0x05e077a8
	System.Void RefreshPlayerTagOption(); // 0x05e07860
	System.Void RefreshRegularDayOption(); // 0x05e079dc
	System.Void RefreshRegularTimeOption(); // 0x05e07ab0
	System.Void OnBtnPublishClick(); // 0x05e08b78
	System.String AssembleTlogParam(); // 0x05e094ac
	System.Void OnBtnShowMore(); // 0x05e09af4
	System.Void ForceRequestFocus(); // 0x05e09c44
	System.Void PublishGameRecruitSuccess(); // 0x05e09cf8
	System.Void CloseView(); // 0x05e09d5c
	static System.Void OpenWindow(System.Boolean isPublishToLobby, System.String openSource); // 0x05e00354
	System.Void OnEnable(); // 0x05e09e30
	System.Void OnDisable(); // 0x05e09f48
	System.Boolean CheckMicOptionIsShow(System.Boolean& defaultValue); // 0x05e07e64
	System.Boolean CheckPlayerTagOptionIsShow(); // 0x05e081e8
	System.Boolean CheckRegularDayOptionIsShow(); // 0x05e085d4
	System.Boolean CheckRegularTimeOptionIsShow(); // 0x05e08ac0
	System.Void .ctor(); // 0x05e0a04c
	System.Void <InitModalBtnInfos>b__16_0(); // 0x05e0a1a0
	System.Void <InitModalBtnInfos>b__16_1(); // 0x05e0a214
	System.Void <OnBtnShowMore>b__29_0(System.Object param); // 0x05e0a278
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPublishGameRecruit.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiPublishGameRecruit.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__15_0; // 0x8
	static System.Void .cctor(); // 0x05e0a418
	System.Void .ctor(); // 0x05e0a47c
	System.Void <OnInit>b__15_0(); // 0x05e0a4e4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPublishGameRecruit.<>c__DisplayClass33_0 : System.Object
{
	System.Boolean isPublishToLobby; // 0x10
	System.String openSource; // 0x18
	System.Void .ctor(); // 0x05e09dc8
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiPublishGameRecruit win); // 0x05e0a558
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPublishRecruit : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	SocLogger log; // 0x338
	WizardGames.Soc.SocClient.Ui.RecruitMemberNumOption memberNumOption; // 0x340
	WizardGames.Soc.SocClient.Ui.RecruitFixedModeOption fixedModeOption; // 0x348
	WizardGames.Soc.SocClient.Ui.RecruitComboBoxModeOption comboBoxModeOption; // 0x350
	WizardGames.Soc.SocClient.Ui.RecruitAppointmentTimeOption appointmentTimeOption; // 0x358
	WizardGames.Soc.SocClient.Ui.RecruitDescOption recruitDescOption; // 0x360
	WizardGames.Soc.SocClient.Ui.RecruitMicOption micOption; // 0x368
	WizardGames.Soc.SocClient.Ui.RecruitApplyOption applyOption; // 0x370
	WizardGames.Soc.SocClient.Ui.RecruitTeamNameOption teamNameOption; // 0x378
	WizardGames.Soc.SocClient.Ui.RecruitPlayerTagOption playerTagOption; // 0x380
	WizardGames.Soc.SocClient.Ui.RecruitAlwaysTimeOption regularDayOption; // 0x388
	WizardGames.Soc.SocClient.Ui.RecruitAlwaysTimeOption regularTimeOption; // 0x390
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x398
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComConditionsBinder conditionsBinder; // 0x3a0
	FairyGUI.GButton btnShowMore; // 0x3a8
	FairyGUI.GButton btnPublishRecruitCheckBox; // 0x3b0
	System.Boolean isAppointment; // 0x3b8
	System.Boolean hasTeam; // 0x3b9
	System.Int32 curModeId; // 0x3bc
	WizardGames.Soc.SocClient.Ui.MyTeamRecruitData myTeamRecruitData; // 0x3c0
	System.Collections.Generic.Dictionary<WizardGames.Soc.Common.Data.RecruitOptionType,WizardGames.Soc.Common.Data.team.OBJRecruitOption> needShowOptions; // 0x3c8
	System.String viewOpenSource; // 0x3d0
	System.Void OnInit(); // 0x05e0a5e0
	System.Void InitModalBtnInfos(); // 0x05e0ab88
	System.Void SetViewName(); // 0x05e0b4b8
	System.Void InitAllOptions(); // 0x05e0ae60
	System.Void InitData(System.Boolean isAppointment, System.String openSource); // 0x05e0bb68
	System.Void InitModeOption(); // 0x05e0bdc8
	System.Void RefreshExtendOptions(); // 0x05e0c6b4
	System.Void RefershExtendOptions2(); // 0x05e0c95c
	System.Void RefreshMemberNumOption(); // 0x05e0c774
	System.Void RefreshAppointmentTimeOption(); // 0x05e0c82c
	System.Void RefreshRecruitDescOption(); // 0x05e0c9f0
	System.Void RefreshTeamNameOption(); // 0x05e0ca98
	System.Void RefreshMicOption(); // 0x05e0cb40
	System.Void RefreshApplyOption(); // 0x05e0cbf8
	System.Void RefreshPlayerTagOption(); // 0x05e0ccb0
	System.Void RefreshRegularDayOption(); // 0x05e0ce2c
	System.Void RefreshRegularTimeOption(); // 0x05e0cf00
	System.Void OnBtnPublishClick(); // 0x05e0de88
	SimpleJSON.JSONObject AssembleRecruitParam(); // 0x05e0e384
	System.String AssembleTlogParam(); // 0x05e0ec64
	System.Void OnBtnPublishRecruitCheckBox(); // 0x05e0f43c
	System.Void OnBtnShowMore(); // 0x05e0f5a0
	System.Void ForceRequestFocus(); // 0x05e0f6f0
	static System.Void OpenWindow(System.Boolean isAppointment, System.String openSource); // 0x05e007b8
	System.Boolean CheckMemberNumOptionIsShow(System.Collections.Generic.List<System.Int32>& options); // 0x05e0cfd4
	System.Boolean CheckAppointmentTimeOptionIsShow(); // 0x05e0d4b0
	System.Boolean CheckMicOptionIsShow(System.Boolean& defaultValue); // 0x05e0d62c
	System.Boolean CheckApplyOptionIsShow(System.Boolean& defaultValue); // 0x05e0d774
	System.Boolean CheckRecruitDescOptionIsShow(); // 0x05e0d524
	System.Boolean CheckTeamNameOptionIsShow(); // 0x05e0d5c8
	System.Boolean CheckPlayerTagOptionIsShow(); // 0x05e0db58
	System.Boolean CheckRegularDayOptionIsShow(); // 0x05e0dc68
	System.Boolean CheckRegularTimeOptionIsShow(); // 0x05e0dd78
	System.Void .ctor(); // 0x05e0f80c
	System.Void <InitModalBtnInfos>b__23_0(); // 0x05e0f958
	System.Void <InitModalBtnInfos>b__23_1(); // 0x05e0f9cc
	System.Void <InitModeOption>b__27_0(System.Int32 modeId); // 0x05e0fa30
	System.Void <RefreshAppointmentTimeOption>b__31_0(); // 0x055049cc
	System.Void <OnBtnShowMore>b__43_0(System.Object param); // 0x05e10084
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPublishRecruit.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiPublishRecruit.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__22_0; // 0x8
	static System.Void .cctor(); // 0x05e10224
	System.Void .ctor(); // 0x05e10288
	System.Void <OnInit>b__22_0(); // 0x05e102f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPublishRecruit.<>c__DisplayClass39_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiPublishRecruit <>4__this; // 0x10
	SimpleJSON.JSONObject param; // 0x18
	System.Void .ctor(); // 0x05e0e31c
	System.Void <OnBtnPublishClick>b__0(); // 0x05e10364
	System.Void <OnBtnPublishClick>b__1(); // 0x05e10438
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPublishRecruit.<>c__DisplayClass39_1 : System.Object
{
	System.String tlogData; // 0x10
	System.Void .ctor(); // 0x05e10648
	System.Void <OnBtnPublishClick>b__2(); // 0x05e106b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiPublishRecruit.<>c__DisplayClass45_0 : System.Object
{
	System.Boolean isAppointment; // 0x10
	System.String openSource; // 0x18
	System.Void .ctor(); // 0x05e0f7a4
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiPublishRecruit win); // 0x05e1075c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RecruitAlwaysTimeOption : WizardGames.Soc.SocClient.Ui.RecruitOptionBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComOptionTimeBinder binder; // 0x18
	WizardGames.Soc.SocClient.Ui.ComComboBox comboBox; // 0x20
	System.Boolean isDay; // 0x28
	System.Int32 curSelectValue; // 0x2c
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComOptionTimeBinder binder, System.Boolean isDay); // 0x05e071f8
	System.Void SetVisible(System.Boolean visible); // 0x05e1084c
	System.Void RefreshComboBox(WizardGames.Soc.SocClient.Ui.MyTeamRecruitData myTeamRecruit, WizardGames.Soc.Common.Data.team.OBJRecruitOption optionCfg); // 0x05e0868c
	System.Void ComboBoxChange(System.Int32 index); // 0x05e10928
	System.Int32 GetSelectValue(); // 0x05e109bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RecruitApplyOption : WizardGames.Soc.SocClient.Ui.RecruitOptionBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComSelect_TwoBinder binder; // 0x18
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComSelect_TwoBinder recruitBinder); // 0x05e0bac4
	System.Void SetVisible(System.Boolean visible); // 0x05e10d08
	System.Void RefreshOption(System.Boolean defaultValue, WizardGames.Soc.SocClient.Ui.MyTeamRecruitData myTeamRecruit); // 0x05e0d8c4
	System.Void InitApplyOption(); // 0x05e10a20
	System.Void OnApplyForOnClick(FairyGUI.EventContext ctx); // 0x05e10de4
	System.Void OnApplyForOffClick(FairyGUI.EventContext ctx); // 0x05e10f64
	System.Boolean GetApplyForValue(); // 0x05e0e8ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RecruitAppointmentTimeOption : WizardGames.Soc.SocClient.Ui.RecruitOptionBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComOptionAppointmentTimeBinder binder; // 0x18
	WizardGames.Soc.SocClient.Ui.ComComboBox comTimeComboBox; // 0x20
	System.Int64 appointmentTime; // 0x28
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComOptionAppointmentTimeBinder binder); // 0x05e0b940
	System.Void SetVisible(System.Boolean visible); // 0x05e110e4
	System.Void RefreshTimeComboBox(System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.RoundTimeData> roundTimeDataList); // 0x05e0fd10
	System.Void ComTimeBoxChange(System.Int32 index); // 0x05e111c0
	System.Int64 GetAppointmentTime(); // 0x05e11254
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RecruitComboBoxModeOption : WizardGames.Soc.SocClient.Ui.RecruitOptionBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComOptionModeAndMemberNumBinder binder; // 0x18
	WizardGames.Soc.SocClient.Ui.ComComboBox comModeComboBox; // 0x20
	System.Int32 curSelectModeId; // 0x28
	System.Action<System.Int32> cb; // 0x30
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComOptionModeAndMemberNumBinder binder); // 0x05e0b674
	System.Void SetVisible(System.Boolean visible); // 0x05e112b8
	System.Void RefreshComboBox(System.Int32 defaultModeId, System.Boolean isAppointment, System.Collections.Generic.List<System.Int32> modeIds, System.Action<System.Int32> cb); // 0x05e0c1b8
	System.Void ComModeBoxChange(System.Int32 index); // 0x05e11394
	System.Int32 GetCurSelectModeId(); // 0x05e11444
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RecruitDescOption : WizardGames.Soc.SocClient.Ui.RecruitOptionBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComRecruitBinder binder; // 0x18
	WizardGames.Soc.SocClient.Ui.ComInputBox descInput; // 0x20
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComRecruitBinder binder); // 0x05e06afc
	System.Void SetVisible(System.Boolean visible); // 0x05e116b0
	System.Void InitRemarkList(); // 0x05e114a8
	System.Void RemarkItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x05e1178c
	System.Void RefreshDesc(WizardGames.Soc.SocClient.Ui.MyTeamRecruitData myTeamRecruit); // 0x05e07b84
	System.Void InputDescFocusIn(FairyGUI.EventContext ctx); // 0x05e11cd0
	System.Void OnChangeDescWordsInput(); // 0x05e11a40
	System.String GetDesc(); // 0x05e09098
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RecruitDescOption.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.RecruitDescOption.<>c <>9; // 0x0
	static System.Action <>9__7_0; // 0x8
	static System.Void .cctor(); // 0x05e11f40
	System.Void .ctor(); // 0x05e11fa4
	System.Void <InputDescFocusIn>b__7_0(); // 0x05e1200c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RecruitDescOption.<>c__DisplayClass5_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.RecruitDescOption <>4__this; // 0x10
	WizardGames.Soc.Common.Data.team.OBJRecruitDescRemarkOption info; // 0x18
	System.Void .ctor(); // 0x05e119d8
	System.Void <RemarkItemRender>b__0(); // 0x05e1206c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RecruitDescOption.<>c__DisplayClass7_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.RecruitDescOption <>4__this; // 0x10
	System.String cacheDesc; // 0x18
	System.Void .ctor(); // 0x05e11ed8
	System.Void <InputDescFocusIn>b__1(); // 0x05e121a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RecruitFixedModeOption : WizardGames.Soc.SocClient.Ui.RecruitOptionBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComDisplayModeBinder binder; // 0x18
	System.Int32 modeId; // 0x20
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComDisplayModeBinder binder); // 0x05e0b5d8
	System.Void SetVisible(System.Boolean visible); // 0x05e12264
	System.Void RefreshMode(System.Int32 modeId, System.Boolean isAppointment); // 0x05e0bfc0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RecruitMemberNumOption : WizardGames.Soc.SocClient.Ui.RecruitOptionBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComOptionModeAndMemberNumBinder binder; // 0x18
	System.Collections.Generic.List<System.Int32> memberNumList; // 0x20
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComOptionModeAndMemberNumBinder binder); // 0x05e0b7f8
	System.Void SetVisible(System.Boolean visible); // 0x05e12340
	System.Void RefreshOption(System.Collections.Generic.List<System.Int32> memberNumList, System.Int32 defaultValus); // 0x05e0d208
	System.Boolean NeedHide(); // 0x05e1244c
	System.Void RenderMemberNumItem(System.Int32 index, FairyGUI.GObject obj); // 0x05e125b8
	System.Int32 GetSelectedMemberNum(); // 0x05e0e7dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RecruitMicOption : WizardGames.Soc.SocClient.Ui.RecruitOptionBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComSelect_TwoBinder binder; // 0x18
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComSelect_TwoBinder recruitBinder); // 0x05e0700c
	System.Void SetVisible(System.Boolean visible); // 0x05e12a0c
	System.Void RefreshOption(System.Boolean defaultValue, WizardGames.Soc.SocClient.Ui.MyTeamRecruitData myTeamRecruit); // 0x05e07f54
	System.Void InitMicOption(); // 0x05e12724
	System.Void OnMicrophoneOffClick(FairyGUI.EventContext ctx); // 0x05e12ae8
	System.Void OnMicrophoneOnClick(FairyGUI.EventContext ctx); // 0x05e12c68
	System.Boolean GetMicValue(); // 0x05e09108
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RecruitOpenServerTimeOption : WizardGames.Soc.SocClient.Ui.RecruitOptionBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComOptionOpenServerTimeBinder binder; // 0x18
	WizardGames.Soc.SocClient.Ui.ComComboBox comTimeComboBox; // 0x20
	System.Int32 openServerTime; // 0x28
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComOptionOpenServerTimeBinder binder); // 0x05e12de8
	System.Void SetVisible(System.Boolean visible); // 0x05e12f6c
	System.Void RefreshTimeComboBox(System.Int32[] timeDatas, System.Int32 defaultValue); // 0x05e13048
	System.Void ComTimeBoxChange(System.Int32 index); // 0x05e13484
	System.Int32 GetOpenServerTime(); // 0x05e13518
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RecruitOptionBase : System.Object
{
	System.Boolean IsValid; // 0x10
	System.Void SetVisible(System.Boolean visible); // 0x05523a7c
	System.Void .ctor(); // 0x05e107e4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RecruitPlatformOption : WizardGames.Soc.SocClient.Ui.RecruitOptionBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComPlatformBinder binder; // 0x18
	System.Collections.Generic.List<System.Int32> options; // 0x20
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComPlatformBinder binder); // 0x05e1357c
	System.Void SetVisible(System.Boolean visible); // 0x05e136c4
	System.Void RefreshOption(System.Int32[] datas, System.Int32 defaultValue); // 0x05e137a0
	System.Void RenderItem(System.Int32 index, FairyGUI.GObject obj); // 0x05e13954
	System.Int32 GetSelectedPlatform(); // 0x05e13a70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RecruitPlayerTagOption : WizardGames.Soc.SocClient.Ui.RecruitOptionBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComSkilledBinder binder; // 0x18
	WizardGames.Soc.Common.Data.team.OBJRecruitOption optionCfg; // 0x20
	System.Int32 get_selectedTagLimit(); // 0x05e13b80
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComSkilledBinder binder); // 0x05e070b0
	System.Void SetVisible(System.Boolean visible); // 0x05e13c68
	System.Void RefreshOption(WizardGames.Soc.Common.Data.team.OBJRecruitOption optionCfg, System.Collections.Generic.HashSet<System.Int32> defaultTagList); // 0x05e082a0
	System.Void OnItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x05e13d44
	System.Void TagItemClick(System.Int32 index); // 0x05e1409c
	SimpleJSON.JSONArray GetSelectedTags(); // 0x05e0e9e0
	System.Collections.Generic.List<System.Int32> GetSelectedTagsList(); // 0x05e091fc
	System.Collections.Generic.HashSet<System.Int32> GetSelectedTagsHashSet(); // 0x05e146a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RecruitPlayerTagOption.<>c__DisplayClass7_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.RecruitPlayerTagOption <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Void .ctor(); // 0x05e14034
	System.Void <OnItemRenderer>b__0(); // 0x05e1490c
	System.Void <OnItemRenderer>b__1(); // 0x05e1497c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RecruitTeamNameOption : WizardGames.Soc.SocClient.Ui.RecruitOptionBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComTextInputBinder binder; // 0x18
	WizardGames.Soc.SocClient.Ui.ComInputBox nameInput; // 0x20
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComTextInputBinder recruitBinder); // 0x05e06dac
	System.Void SetVisible(System.Boolean visible); // 0x05e149ec
	System.Void RefreshTeamName(WizardGames.Soc.SocClient.Ui.MyTeamRecruitData myTeamRecruit); // 0x05e07cac
	System.Void InputNameFocusIn(FairyGUI.EventContext ctx); // 0x05e14d08
	System.Void OnChangeNameWordsInput(); // 0x05e14ac8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RecruitTeamNameOption.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.RecruitTeamNameOption.<>c <>9; // 0x0
	static System.Action <>9__5_0; // 0x8
	static System.Void .cctor(); // 0x05e14f78
	System.Void .ctor(); // 0x05e14fdc
	System.Void <InputNameFocusIn>b__5_0(); // 0x05e15044
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.RecruitTeamNameOption.<>c__DisplayClass5_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.RecruitTeamNameOption <>4__this; // 0x10
	System.String cacheDesc; // 0x18
	System.Void .ctor(); // 0x05e14f10
	System.Void <InputNameFocusIn>b__1(); // 0x05e150a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameTeamHall : System.Object, WizardGames.Soc.SocClient.Ui.ITeamSubView
{
	static SocLogger log; // 0x0
	FairyGUI.GList recruitList; // 0x10
	FairyGUI.Controller stateCtrl; // 0x18
	FairyGUI.GButton refreshBtn; // 0x20
	FairyGUI.GComponent myTeamInfoPanel; // 0x28
	FairyGUI.Controller myTeamInfoStateCtrl; // 0x30
	FairyGUI.GButton btnPublish; // 0x38
	FairyGUI.GButton btnOpenFilter; // 0x40
	FairyGUI.Transition refreshListAni; // 0x48
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RecruitData> recruitDatas; // 0x50
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.UiGameTeamHall.playerInfo> roleId2PlayerInfo; // 0x58
	WizardGames.Soc.SocClient.Ui.ETeamTabType <TabType>k__BackingField; // 0x60
	System.Int64 refreshListCDTimerId; // 0x68
	System.Collections.Generic.List<System.Int64> applyCdTimerIds; // 0x70
	System.Int64 autoRefreshTimerId; // 0x78
	WizardGames.Soc.Common.Data.Play.OBJGameMode gameModeCfg; // 0x80
	System.Int64 lastRefreshTime; // 0x88
	System.Int64 animationTimerId; // 0x90
	System.Boolean showEnableListAnim; // 0x98
	System.Boolean showRefreshListAnim; // 0x99
	System.Void set_TabType(WizardGames.Soc.SocClient.Ui.ETeamTabType value); // 0x05e15168
	System.Void OnInit(FairyGUI.GComponent root); // 0x05e151e0
	System.Void RefreshRecruitDatas(); // 0x05e16338
	System.Void RefreshList(System.Collections.Generic.Dictionary<System.String,System.Int32> defaultSortDic); // 0x05e16738
	System.Void RenderListItem(System.Int32 index, FairyGUI.GObject obj); // 0x05e16ab0
	System.Void OnClickJoinBtn(WizardGames.Soc.SocClient.Ui.RecruitData data, FairyGUI.GButton joinBtn); // 0x05e17d24
	System.Void OnRefreshBtnClick(FairyGUI.EventContext ctx); // 0x05e184b8
	System.Void OnRecruitDelete(System.String teamId); // 0x05e18328
	System.Void UpdateRefreshBtnStatus(); // 0x05e18650
	System.Void OnTeamMemberDictChange(WizardGames.Soc.Share.Framework.ECustomDictOpType changeType, System.UInt64 roleId, WizardGames.Soc.Common.CustomType.TeamMemberInfo oldMember); // 0x05e18928
	System.Void RefreshMyTeamInfo(); // 0x05e189bc
	System.Void RefreshMyTeamMembersAvatar(System.Collections.Generic.List<System.String> memberRoleIds); // 0x05e19640
	System.Collections.Generic.List<System.String> GetSortedTeamMemberDataList(); // 0x05e19110
	System.Void OnPublishBtnClick(FairyGUI.EventContext ctx); // 0x05e19c88
	System.Void OnEditRecruitBtnClick(FairyGUI.EventContext ctx); // 0x05e19d18
	System.Void ReqRecruitListResult(WizardGames.Soc.Share.Framework.CustomTypeList<WizardGames.Soc.Common.CustomType.WarZoneTeamRecruitment> infos); // 0x05e19da8
	System.Void OnApplyListBtnClick(FairyGUI.EventContext ctx); // 0x05e1aa24
	System.Void OnCancelRecruitBtnClick(FairyGUI.EventContext ctx); // 0x05e1aaa0
	System.Void OnQuitTeamBtnClick(FairyGUI.EventContext ctx); // 0x05e1ad6c
	System.Void OnCheckTeammateTerritoryCabinetAck(System.UInt64 teammateRoleId, System.Int32 code); // 0x05e1ae64
	System.Void TimerCallBack(System.Int64 timerId, System.Object _, System.Boolean delete); // 0x05e1b3a4
	System.Void ClearRefreshListCDTimer(); // 0x05e1b7c0
	System.Void ClearApplyCdTimer(); // 0x05e16864
	System.Void ClearAutoRefreshTimer(); // 0x05e1b8c8
	System.Void RefreshFilterDesc(); // 0x05e16258
	System.Void OnOpenFilterClick(); // 0x05e1b9d0
	System.Void ResetFilterConditionData(); // 0x05e15e10
	System.Void ClearAnimationTimer(); // 0x05e1a91c
	System.Void OnEnable(); // 0x055049cc
	System.Void OnDisable(); // 0x05e1c050
	System.Void OnDestory(); // 0x05e1c428
	System.Void .ctor(); // 0x05e1c494
	static System.Void .cctor(); // 0x05e1c5f8
	System.Void <RefreshRecruitDatas>b__25_0(System.Int64 _, System.Object _, System.Boolean _); // 0x05e1c6cc
	System.Void <OnOpenFilterClick>b__48_0(WizardGames.Soc.SocClient.Ui.RecruitFilterConditionData filterData); // 0x05e1c760
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiGameTeamHall.playerInfo : System.ValueType
{
	System.String roleid; // 0x10
	System.String name; // 0x18
	System.String portrait; // 0x20
	System.Int32 portraitFrame; // 0x28
	System.Int32 level; // 0x2c
	System.Int32 gameStyleID; // 0x30
	Config.EUserPrivacy userPrivacy; // 0x34
	System.Int32 rankPoint; // 0x38
	System.Int32 seasonPoints; // 0x3c
	System.UInt64 communityID; // 0x40
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameTeamHall.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiGameTeamHall.<>c <>9; // 0x0
	static System.Action <>9__42_0; // 0x8
	static System.Void .cctor(); // 0x05e1c834
	System.Void .ctor(); // 0x05e1c898
	System.Void <OnCheckTeammateTerritoryCabinetAck>b__42_0(); // 0x05e1c900
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameTeamHall.<>c__DisplayClass24_0 : System.Object
{
	FairyGUI.GButton tipsBtn; // 0x10
	System.Void .ctor(); // 0x05e15da8
	System.Void <OnInit>b__0(FairyGUI.EventContext ctx); // 0x05e1c99c
	System.Void <OnInit>b__1(FairyGUI.EventContext ctx); // 0x05e1ca58
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameTeamHall.<>c__DisplayClass27_0 : System.Object
{
	FairyGUI.GButton joinBtn; // 0x10
	WizardGames.Soc.SocClient.Ui.UiGameTeamHall <>4__this; // 0x18
	WizardGames.Soc.SocClient.Ui.RecruitData data; // 0x20
	FairyGUI.Controller unionTeamCtrl; // 0x28
	System.Void .ctor(); // 0x05e17c54
	System.Void <RenderListItem>b__3(System.Int64 _, System.Object _, System.Boolean _); // 0x05e1cb14
	System.Void <RenderListItem>b__0(FairyGUI.EventContext ctx); // 0x05e1cbf0
	System.Void <RenderListItem>b__1(System.Boolean isUnionTeam); // 0x05e1cc78
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameTeamHall.<>c__DisplayClass27_1 : System.Object
{
	FairyGUI.Controller relationCtrl; // 0x10
	System.Boolean isFriend; // 0x18
	System.Void .ctor(); // 0x05e17cbc
	System.Void <RenderListItem>b__2(System.Boolean isUnionMember); // 0x05e1cd30
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameTeamHall.<>c__DisplayClass28_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.RecruitData data; // 0x10
	FairyGUI.GButton joinBtn; // 0x18
	WizardGames.Soc.SocClient.Ui.UiGameTeamHall <>4__this; // 0x20
	WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__1; // 0x28
	System.Void .ctor(); // 0x05e182c0
	System.Void <OnClickJoinBtn>b__0(System.String str, SimpleJSON.JSONArray tagArray); // 0x05e1cdf0
	System.Void <OnClickJoinBtn>b__1(System.Int64 _, System.Object _, System.Boolean _); // 0x05e1d390
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameTeamHall.<>c__DisplayClass33_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiGameTeamHall <>4__this; // 0x10
	System.Collections.Generic.List<System.String> memberRoleIds; // 0x18
	System.Void .ctor(); // 0x05e190a8
	System.Void <RefreshMyTeamInfo>b__0(SimpleJSON.JSONArray jsonArrayInfo); // 0x05e1d46c
	System.Void <RefreshMyTeamInfo>b__1(System.Boolean isUnionTeam); // 0x05e1d98c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameToLobbyTeamHall : System.Object, WizardGames.Soc.SocClient.Ui.ITeamSubView
{
	static SocLogger log; // 0x0
	FairyGUI.GList recruitList; // 0x10
	FairyGUI.Controller stateCtrl; // 0x18
	FairyGUI.GButton refreshBtn; // 0x20
	FairyGUI.GButton btnOpenFilter; // 0x28
	FairyGUI.Transition refreshListAni; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RecruitData> recruitDatas; // 0x38
	System.Collections.Generic.Dictionary<System.String,Config.LobbyRoleInfo> roleId2PlayerInfo; // 0x40
	WizardGames.Soc.SocClient.Ui.ETeamTabType <TabType>k__BackingField; // 0x48
	System.Int64 autoRefreshListTimerId; // 0x50
	System.Int64 refreshBtnCdTimerId; // 0x58
	System.Collections.Generic.List<System.Int64> applyCdTimerIds; // 0x60
	WizardGames.Soc.SocClient.Ui.RecruitFilterConditionData curFilterConditionData; // 0x68
	System.Int64 lastRefreshTime; // 0x70
	System.Int64 animationTimerId; // 0x78
	System.Void set_TabType(WizardGames.Soc.SocClient.Ui.ETeamTabType value); // 0x05e1da70
	System.Void OnInit(FairyGUI.GComponent root); // 0x05e1dae8
	System.Void RefreshRecruitDatas(WizardGames.Soc.SocClient.Ui.ETeamHallListAnimType animType); // 0x05e1e284
	System.Void ParseServerDataAndRefreshPanel(SimpleJSON.JSONArray jsonArray, WizardGames.Soc.SocClient.Ui.ETeamHallListAnimType animType); // 0x05e1e59c
	System.Void RefreshList(WizardGames.Soc.SocClient.Ui.ETeamHallListAnimType animType, System.Collections.Generic.Dictionary<System.String,System.Int32> defaultSortDic); // 0x05e1f140
	System.Void RenderListItem(System.Int32 index, FairyGUI.GObject obj); // 0x05e1f640
	System.Void OnClickJoinBtn(WizardGames.Soc.SocClient.Ui.RecruitData data, FairyGUI.GButton joinBtn); // 0x05e20930
	System.Void OnRefreshBtnClick(FairyGUI.EventContext ctx); // 0x05e210b4
	System.Void OnRecruitDelete(System.String teamId, System.String serverId); // 0x05e21248
	System.Void UpdateRefreshBtnStatus(); // 0x05e21448
	System.Void ResetAutoRefreshListTimer(); // 0x055049cc
	System.Void AutoRefreshList(System.Int64 timerId, System.Object _, System.Boolean delete); // 0x05e21a50
	System.Void RefreshFilterDesc(); // 0x05e1e1d8
	System.Void OnOpenFilterClick(); // 0x05e21da0
	WizardGames.Soc.SocClient.Ui.RecruitFilterConditionData ResetFilterConditionData(); // 0x05e1df10
	System.Void ClearRefreshBtnCdTimer(); // 0x05e21e58
	System.Void ClearApplyCdTimer(); // 0x05e1f2ec
	System.Void ClearAutoRefreshListTimer(); // 0x05e21948
	System.Void ClearAnimationTimer(); // 0x05e1f538
	System.Void OnEnable(); // 0x05e21f60
	System.Void OnDisable(); // 0x05e22088
	System.Void OnDestory(); // 0x05e221f0
	System.Void .ctor(); // 0x05e2225c
	static System.Void .cctor(); // 0x05e223c0
	System.Void <AutoRefreshList>b__28_0(SimpleJSON.JSONArray jsonArray); // 0x05e22494
	System.Void <OnOpenFilterClick>b__30_0(WizardGames.Soc.SocClient.Ui.RecruitFilterConditionData filterData); // 0x05e2252c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameToLobbyTeamHall.<>c__DisplayClass18_0 : System.Object
{
	FairyGUI.GButton tipsBtn; // 0x10
	System.Void .ctor(); // 0x05e2262c
	System.Void <OnInit>b__0(FairyGUI.EventContext ctx); // 0x05e22694
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameToLobbyTeamHall.<>c__DisplayClass19_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiGameToLobbyTeamHall <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.ETeamHallListAnimType animType; // 0x18
	System.Void .ctor(); // 0x05e22750
	System.Void <RefreshRecruitDatas>b__0(System.Int64 _, System.Object _, System.Boolean _); // 0x05e227b8
	System.Void <RefreshRecruitDatas>b__1(SimpleJSON.JSONArray jsonArray); // 0x05e22858
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameToLobbyTeamHall.<>c__DisplayClass20_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiGameToLobbyTeamHall <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.ETeamHallListAnimType animType; // 0x18
	System.Collections.Generic.Dictionary<System.String,System.Int32> teamId2SortIndex; // 0x20
	System.Void .ctor(); // 0x05e2290c
	System.Void <ParseServerDataAndRefreshPanel>b__0(SimpleJSON.JSONArray jsonArrayInfo); // 0x05e22974
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameToLobbyTeamHall.<>c__DisplayClass22_0 : System.Object
{
	FairyGUI.GButton joinBtn; // 0x10
	WizardGames.Soc.SocClient.Ui.UiGameToLobbyTeamHall <>4__this; // 0x18
	WizardGames.Soc.SocClient.Ui.RecruitData data; // 0x20
	System.Void .ctor(); // 0x05e22b74
	System.Void <RenderListItem>b__1(System.Int64 _, System.Object _, System.Boolean _); // 0x05e22bdc
	System.Void <RenderListItem>b__0(FairyGUI.EventContext ctx); // 0x05e22cb8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameToLobbyTeamHall.<>c__DisplayClass23_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.RecruitData data; // 0x10
	FairyGUI.GButton joinBtn; // 0x18
	WizardGames.Soc.SocClient.Ui.UiGameToLobbyTeamHall <>4__this; // 0x20
	SimpleJSON.JSONObject param; // 0x28
	WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__1; // 0x30
	System.Void .ctor(); // 0x05e22d44
	System.Void <OnClickJoinBtn>b__0(System.String str, SimpleJSON.JSONArray tagArray); // 0x05e22dac
	System.Void <OnClickJoinBtn>b__1(System.Int64 _, System.Object _, System.Boolean _); // 0x05e232b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRecruitFilterPop : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.RecruitComboBoxModeOption comboBoxModeOption; // 0x338
	WizardGames.Soc.SocClient.Ui.RecruitMemberNumOption memberNumOption; // 0x340
	WizardGames.Soc.SocClient.Ui.RecruitPlayerTagOption playerTagOption; // 0x348
	WizardGames.Soc.SocClient.Ui.RecruitMicOption micOption; // 0x350
	WizardGames.Soc.SocClient.Ui.RecruitApplyOption applyOption; // 0x358
	WizardGames.Soc.SocClient.Ui.RecruitOpenServerTimeOption openServerTimeOption; // 0x360
	WizardGames.Soc.SocClient.Ui.RecruitPlatformOption platformOption; // 0x368
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x370
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComRecruitItemsBinder conditionsBinder; // 0x378
	WizardGames.Soc.SocClient.Ui.RecruitFilterConditionData recruitFilterConditionData; // 0x380
	System.Action<WizardGames.Soc.SocClient.Ui.RecruitFilterConditionData> onConfirmCallback; // 0x388
	WizardGames.Soc.SocClient.Ui.ERecruitType curRecruitType; // 0x390
	System.Int32 curModeId; // 0x394
	System.Void OnInit(); // 0x05e23394
	System.Void InitModalBtnInfos(); // 0x05e23600
	System.Void InitAllOptions(); // 0x05e238d8
	System.Void InitData(WizardGames.Soc.SocClient.Ui.ERecruitType eRecruitType, WizardGames.Soc.SocClient.Ui.RecruitFilterConditionData data, System.Action<WizardGames.Soc.SocClient.Ui.RecruitFilterConditionData> cb); // 0x05e23d28
	System.Void RefreshOptions(); // 0x05e23df8
	System.Void RefreshExtendOptions(); // 0x05e23fec
	System.Void RefreshMemberNumOption(); // 0x05e240dc
	System.Void RefreshOpenServerTimeOption(); // 0x05e241a0
	System.Void RefreshPlayerTagOption(); // 0x05e2428c
	System.Void RefreshMicOption(); // 0x05e24370
	System.Void RefreshApplyOption(); // 0x05e2445c
	System.Void RefreshPlatformOption(); // 0x05e24548
	System.Void OnBtnConfirmClick(); // 0x05e24c5c
	static System.Void OpenWindow(WizardGames.Soc.SocClient.Ui.ERecruitType eRecruitType, WizardGames.Soc.SocClient.Ui.RecruitFilterConditionData data, System.Action<WizardGames.Soc.SocClient.Ui.RecruitFilterConditionData> cb); // 0x05e24f44
	System.Boolean CheckModeOptionIsShow(); // 0x05e23f58
	System.Boolean CheckMemberNumOptionIsShow(System.Collections.Generic.List<System.Int32>& options); // 0x05e24634
	System.Boolean CheckOpenServerTimeIsShow(); // 0x05e24890
	System.Boolean CheckPlayerTagOptionIsShow(); // 0x05e2495c
	System.Boolean CheckMicOptionIsShow(); // 0x05e24a1c
	System.Boolean CheckApplyOptionIsShow(); // 0x05e24adc
	System.Boolean CheckPlatformOptionIsShow(); // 0x05e24b9c
	System.Void .ctor(); // 0x05e25134
	System.Void <InitModalBtnInfos>b__14_0(); // 0x05e251f8
	System.Void <InitModalBtnInfos>b__14_1(); // 0x05e2526c
	System.Void <RefreshOptions>b__17_0(System.Int32 modeId); // 0x05e252d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRecruitFilterPop.<>c__DisplayClass26_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ERecruitType eRecruitType; // 0x10
	WizardGames.Soc.SocClient.Ui.RecruitFilterConditionData data; // 0x18
	System.Action<WizardGames.Soc.SocClient.Ui.RecruitFilterConditionData> cb; // 0x20
	System.Void .ctor(); // 0x05e250cc
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiRecruitFilterPop win); // 0x05e2534c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamHall : System.Object, WizardGames.Soc.SocClient.Ui.ITeamSubView
{
	FairyGUI.GList recruitList; // 0x10
	FairyGUI.Controller stateCtrl; // 0x18
	FairyGUI.GComponent myTeamInfoPanel; // 0x20
	FairyGUI.Controller myTeamInfoStateCtrl; // 0x28
	FairyGUI.GButton quickJoinBtn; // 0x30
	FairyGUI.GButton applyListBtn; // 0x38
	FairyGUI.GButton btnPublish; // 0x40
	FairyGUI.GButton refreshBtn; // 0x48
	FairyGUI.GButton btnOpenFilter; // 0x50
	FairyGUI.Transition refreshListAni; // 0x58
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.RecruitData> recruitDatas; // 0x60
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.UiTeamHall.playerInfo> roleId2PlayerInfo; // 0x68
	WizardGames.Soc.SocClient.Ui.ETeamTabType <TabType>k__BackingField; // 0x70
	System.Int64 timerId; // 0x78
	System.Boolean AutoRefreshRecruitSign; // 0x80
	System.Int32 reqRecruitCd; // 0x84
	System.Collections.Generic.List<System.Int64> applyCdTimerIds; // 0x88
	WizardGames.Soc.SocClient.Ui.RecruitFilterConditionData curFilterConditionData; // 0x90
	System.Int64 lastRefreshTime; // 0x98
	System.Int64 animationTimerId; // 0xa0
	System.Boolean get_isAppointment(); // 0x05e253d4
	WizardGames.Soc.SocClient.Ui.ETeamTabType get_TabType(); // 0x05e25484
	System.Void set_TabType(WizardGames.Soc.SocClient.Ui.ETeamTabType value); // 0x05e254e8
	System.Void OnInit(FairyGUI.GComponent root); // 0x05e25560
	SimpleJSON.JSONObject GetFilterParams(); // 0x05e26548
	System.Void RefreshRecruitDatas(WizardGames.Soc.SocClient.Ui.ETeamHallListAnimType animType); // 0x05e26a58
	System.Void RefreshList(WizardGames.Soc.SocClient.Ui.ETeamHallListAnimType animType); // 0x05e26f48
	System.Void RenderListItem(System.Int32 index, FairyGUI.GObject obj); // 0x05e27448
	System.Void OnClickJoinBtn(WizardGames.Soc.SocClient.Ui.RecruitData data, FairyGUI.GButton joinBtn); // 0x05e289e8
	System.Void TeamInfoChange(); // 0x05e2908c
	System.Void TeamMemberChange(System.String roleId, System.Boolean isAppointmentT); // 0x05e294b4
	System.Void RecruitDataChange(); // 0x05e29558
	System.Void RefreshMyTeamInfo(System.Boolean needRefreshRecruitList); // 0x05e290f4
	System.Void RefreshMyTeamPanel(); // 0x05e29628
	System.Void OnQuickJoinBtnClick(FairyGUI.EventContext ctx); // 0x05e2a320
	System.Void OnPublishBtnClick(FairyGUI.EventContext ctx); // 0x05e2a490
	System.Void OnEditRecruitBtnClick(FairyGUI.EventContext ctx); // 0x05e2a52c
	System.Void OnApplyListBtnClick(FairyGUI.EventContext ctx); // 0x05e2a5c8
	System.Void OnQuitTeamBtnClick(FairyGUI.EventContext ctx); // 0x05e2a79c
	System.Void OnCancelRecruitBtnClick(FairyGUI.EventContext ctx); // 0x05e2abcc
	System.Void OnRefreshBtnClick(FairyGUI.EventContext ctx); // 0x05e2acd8
	System.Void UpdateRefreshBtnStatus(); // 0x05e26c70
	System.Void OnRecruitChange(SimpleJSON.JSONNode json, System.String clearTeamId, System.Boolean isAppointment); // 0x05e2ae6c
	System.Void OnRecruitMembersChange(System.Collections.Generic.List<System.String> newRoleIds, System.String teamId); // 0x05e2b888
	System.Void TimerCallBack(System.Int64 timerId, System.Object _, System.Boolean delete); // 0x05e2bc94
	System.Void ClearTimer(); // 0x05e2c098
	System.Void ClearApplyCdTimer(); // 0x05e270f4
	System.Void OnEnable(); // 0x055049cc
	System.Void OnDisable(); // 0x05e2c5f4
	System.Void OnNextViewGuide(System.Int32 guideId, System.Int32 stepId); // 0x05e2c98c
	System.Void OnDestory(); // 0x05e2cb7c
	FairyGUI.GObject GetGuideObjByID(System.Int64 id); // 0x05e2cbe8
	System.Void RefreshFilterDesc(); // 0x05e2649c
	System.Void OnOpenFilterClick(); // 0x05e2cd20
	System.Void ClearAnimationTimer(); // 0x05e27340
	WizardGames.Soc.SocClient.Ui.RecruitFilterConditionData ResetFilterConditionData(); // 0x05e25fc0
	System.Void .ctor(); // 0x05e2cdf0
	System.Void <OnQuitTeamBtnClick>b__41_0(); // 0x05e2cf5c
	System.Void <OnQuitTeamBtnClick>b__41_1(); // 0x05e2d060
	System.Void <OnCancelRecruitBtnClick>b__42_0(); // 0x05e2d1f4
	System.Void <OnRecruitChange>b__45_0(SimpleJSON.JSONArray jsonArrayInfo); // 0x05e2d270
	System.Void <OnRecruitMembersChange>b__46_0(SimpleJSON.JSONArray jsonArrayInfo); // 0x05e2d888
	System.Void <TimerCallBack>b__47_0(SimpleJSON.JSONNode jsonNode); // 0x05e2da64
	System.Void <TimerCallBack>b__47_1(SimpleJSON.JSONArray jsonArrayInfo); // 0x05e2e388
	System.Void <OnOpenFilterClick>b__56_0(WizardGames.Soc.SocClient.Ui.RecruitFilterConditionData filterData); // 0x05e2e564
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiTeamHall.playerInfo : System.ValueType
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
	System.Void SetPlayerInfo(SimpleJSON.JSONNode jsonNode); // 0x05e2d44c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamHall.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiTeamHall.<>c <>9; // 0x0
	static System.Action <>9__37_1; // 0x8
	static System.Void .cctor(); // 0x05e2e600
	System.Void .ctor(); // 0x05e2e664
	System.Void <OnQuickJoinBtnClick>b__37_1(); // 0x05e2e6cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamHall.<>c__DisplayClass26_0 : System.Object
{
	FairyGUI.GButton tipsBtn; // 0x10
	WizardGames.Soc.SocClient.Ui.UiTeamHall <>4__this; // 0x18
	System.Void .ctor(); // 0x05e25f58
	System.Void <OnInit>b__0(FairyGUI.EventContext ctx); // 0x05e2e76c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamHall.<>c__DisplayClass28_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiTeamHall <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.ETeamHallListAnimType animType; // 0x18
	System.Action<SimpleJSON.JSONArray> <>9__1; // 0x20
	System.Void .ctor(); // 0x05e26c08
	System.Void <RefreshRecruitDatas>b__0(SimpleJSON.JSONNode jsonArray); // 0x05e2e850
	System.Void <RefreshRecruitDatas>b__1(SimpleJSON.JSONArray jsonArrayInfo); // 0x05e2f1dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamHall.<>c__DisplayClass30_0 : System.Object
{
	FairyGUI.GButton joinBtn; // 0x10
	WizardGames.Soc.SocClient.Ui.UiTeamHall <>4__this; // 0x18
	WizardGames.Soc.SocClient.Ui.RecruitData data; // 0x20
	FairyGUI.Controller unionTeamCtrl; // 0x28
	System.Void .ctor(); // 0x05e28918
	System.Void <RenderListItem>b__3(System.Int64 _, System.Object _, System.Boolean _); // 0x05e2f3cc
	System.Void <RenderListItem>b__0(FairyGUI.EventContext ctx); // 0x05e2f4a8
	System.Void <RenderListItem>b__1(System.Boolean isUnionTeam); // 0x05e2f530
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamHall.<>c__DisplayClass30_1 : System.Object
{
	FairyGUI.Controller relationCtrl; // 0x10
	System.Boolean isFriend; // 0x18
	System.Void .ctor(); // 0x05e28980
	System.Void <RenderListItem>b__2(System.Boolean isUnionMember); // 0x05e2f5e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamHall.<>c__DisplayClass31_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.RecruitData data; // 0x10
	WizardGames.Soc.SocClient.Ui.UiTeamHall <>4__this; // 0x18
	FairyGUI.GButton joinBtn; // 0x20
	WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__1; // 0x28
	System.Void .ctor(); // 0x05e29024
	System.Void <OnClickJoinBtn>b__0(System.Boolean isSuccess); // 0x05e2f6a8
	System.Void <OnClickJoinBtn>b__1(System.Int64 _, System.Object _, System.Boolean _); // 0x05e2fc34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamHall.<>c__DisplayClass35_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiTeamHall <>4__this; // 0x10
	System.Boolean needRefreshRecruitList; // 0x18
	System.Void .ctor(); // 0x05e295c0
	System.Void <RefreshMyTeamInfo>b__0(SimpleJSON.JSONArray jsonArrayInfo); // 0x05e2fd10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamHall.<>c__DisplayClass36_0 : System.Object
{
	FairyGUI.Controller unionTeamCtrl; // 0x10
	System.Void .ctor(); // 0x05e2a250
	System.Void <RefreshMyTeamPanel>b__0(System.Boolean isUnionTeam); // 0x05e2ff14
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamHall.<>c__DisplayClass36_1 : System.Object
{
	FairyGUI.Controller relationCtrl; // 0x10
	System.Void .ctor(); // 0x05e2a2b8
	System.Void <RefreshMyTeamPanel>b__1(System.Boolean isUnionMember); // 0x05e2ffcc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamHall.<>c__DisplayClass37_0 : System.Object
{
	SimpleJSON.JSONObject param; // 0x10
	System.Void .ctor(); // 0x05e2a428
	System.Void <OnQuickJoinBtnClick>b__0(System.String str, SimpleJSON.JSONArray tagArray); // 0x05e30084
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TeamTipsRuntimeCache : System.Object
{
	static SocLogger logger; // 0x0
	static System.Boolean initialized; // 0x8
	static WizardGames.Soc.Share.Framework.CustomValueDictionary<System.Int64,WizardGames.Soc.Common.CustomType.NodeBase> getNodes; // 0x10
	static System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.MailNode> cachedTips; // 0x18
	static System.Collections.Generic.HashSet<System.Int64> removedMailIds; // 0x20
	static System.Collections.Generic.HashSet<System.Int64> hudHandledMailIds; // 0x28
	static System.Collections.Generic.HashSet<System.Int64> redDotClearedMailIds; // 0x30
	static System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.MailNode> hudVisibleTipsCache; // 0x38
	static System.String cachedTeamTips; // 0x40
	static System.Collections.Generic.Dictionary<System.UInt64,System.String> cachedRoleNames; // 0x48
	static System.Int32 lastNodesCount; // 0x50
	static System.Collections.Generic.IReadOnlyList<WizardGames.Soc.Common.CustomType.MailNode> get_Tips(); // 0x05e3022c
	static System.Void SaveReadIds(); // 0x05e304ac
	static System.Void LoadReadIds(); // 0x05e305f4
	static System.Int32 get_UnviewedTipsCount(); // 0x05e308a4
	static System.Collections.Generic.IReadOnlyList<WizardGames.Soc.Common.CustomType.MailNode> get_HudVisibleTips(); // 0x05e30aec
	static System.Void MarkAllTipsAsViewed(); // 0x05e30e30
	static System.Void MarkAllTipAsHudHandled(); // 0x05e31084
	static System.Void Initialize(); // 0x05e312c4
	static System.Void RemoveTips(System.Collections.Generic.IList<System.Int64> mailIds); // 0x05e31470
	static System.Void OnTeamEntityInit(); // 0x05e31c84
	static System.Void OnTeamEntityClientCleanUp(); // 0x05e31d00
	static System.Void TryAttach(); // 0x05e302e4
	static System.Void Detach(); // 0x05e31d7c
	static System.Void OnNodesChanged(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.Int64 mailId, WizardGames.Soc.Common.CustomType.NodeBase oldNode); // 0x05e329fc
	static System.Void RefreshCache(); // 0x05e31fc0
	static System.Void ForceRefresh(); // 0x05e32d98
	static System.String GetTipTitle(WizardGames.Soc.Common.CustomType.MailNode mailNode); // 0x05e32e14
	static System.String GetTipContent(WizardGames.Soc.Common.CustomType.MailNode mailNode); // 0x05e337d0
	static System.String FormatMailContent(System.String template, WizardGames.Soc.Share.Framework.BasicTypeList<System.String> args, System.Int32 templateId); // 0x05e33038
	static System.Boolean ShouldResolveRoleName(System.Int32 templateId, System.Int32 argIndex); // 0x05e339f4
	static System.String ResolveRoleName(System.String arg); // 0x05e33a88
	static System.String FormatHoursToDayHour(System.Int32 hours); // 0x05e33c7c
	static System.Void .cctor(); // 0x05e33ea8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TeamTipsRuntimeCache.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.TeamTipsRuntimeCache.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.CustomType.MailNode> <>9__32_0; // 0x8
	static System.Void .cctor(); // 0x05e34120
	System.Void .ctor(); // 0x05e34184
	System.Int32 <RefreshCache>b__32_0(WizardGames.Soc.Common.CustomType.MailNode lhs, WizardGames.Soc.Common.CustomType.MailNode rhs); // 0x05e341ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TeamTipsRuntimeCache.<>c__DisplayClass24_0 : System.Object
{
	System.Collections.Generic.IList<System.Int64> mailIds; // 0x10
	System.Void .ctor(); // 0x05e31bb4
	System.Boolean <RemoveTips>b__0(WizardGames.Soc.Common.CustomType.MailNode tip); // 0x05e342ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TeamTipsRuntimeCache.<>c__DisplayClass24_1 : System.Object
{
	System.Int64 mailId; // 0x10
	System.Void .ctor(); // 0x05e31c1c
	System.Boolean <RemoveTips>b__1(WizardGames.Soc.Common.CustomType.MailNode t); // 0x05e3439c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TeamTipsRuntimeCache.<>c__DisplayClass32_0 : System.Object
{
	System.Collections.Generic.HashSet<System.Int64> currentIds; // 0x10
	System.Void .ctor(); // 0x05e32d30
	System.Boolean <RefreshCache>b__1(System.Int64 id); // 0x05e34430
	System.Boolean <RefreshCache>b__2(System.Int64 id); // 0x05e344d8
	System.Boolean <RefreshCache>b__3(System.Int64 id); // 0x05e34580
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.TeamTipsRuntimeCache.<>c__DisplayClass38_0 : System.Object
{
	System.UInt64 roleId; // 0x10
	System.Void .ctor(); // 0x05e33e40
	System.Void <ResolveRoleName>b__0(System.String name); // 0x05e34628
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRecruitApplyListPop : System.Object, WizardGames.Soc.SocClient.Ui.ITeamMessagePopSubView
{
	WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType <TabType>k__BackingField; // 0x10
	FairyGUI.GList list; // 0x18
	FairyGUI.Controller emptyCtrl; // 0x20
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.UiRecruitApplyListPop.playerInfo> playerInfosCache; // 0x28
	System.Boolean isAppointment; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.PlayerApplyEnterTeamInfo> applyDatas; // 0x38
	WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType get_TabType(); // 0x05e34754
	System.Void set_TabType(WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType value); // 0x05e347b8
	System.Void OnInit(FairyGUI.GComponent root); // 0x05e34830
	System.Void Refersh(); // 0x05e3498c
	System.Void RenderListItem(System.Int32 index, FairyGUI.GObject obj); // 0x05e35030
	System.Void RefuseBtnClick(System.Int32 index); // 0x05e35610
	System.Void AgreeBtnClick(System.Int32 index); // 0x05e358dc
	System.Void NewRecruitmentApplicationNotify(); // 0x05e35ba8
	System.Void OnEnable(); // 0x05e35c44
	System.Void OnDisable(); // 0x05e35e50
	System.Void OnDestory(); // 0x05e35f9c
	System.Void .ctor(); // 0x05e35ffc
	System.Void <Refersh>b__11_1(SimpleJSON.JSONArray jsonArray); // 0x05e36108
	System.Void <RefuseBtnClick>b__13_0(); // 0x05e366f0
	System.Void <AgreeBtnClick>b__14_0(); // 0x05e36754
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiRecruitApplyListPop.playerInfo : System.ValueType
{
	System.String RoleId; // 0x10
	System.String Name; // 0x18
	System.String Portrait; // 0x20
	System.Int32 PortraitFrame; // 0x28
	System.Int32 level; // 0x2c
	Config.EUserPrivacy userPrivacy; // 0x30
	System.Int32 styleID; // 0x34
	System.Int32 rankPoint; // 0x38
	System.Boolean CompletedNewbieTutorial; // 0x3c
	System.Int32 seasonPoints; // 0x40
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRecruitApplyListPop.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiRecruitApplyListPop.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.PlayerApplyEnterTeamInfo> <>9__11_0; // 0x8
	static System.Void .cctor(); // 0x05e367b8
	System.Void .ctor(); // 0x05e3681c
	System.Int32 <Refersh>b__11_0(WizardGames.Soc.SocClient.Ui.PlayerApplyEnterTeamInfo a, WizardGames.Soc.SocClient.Ui.PlayerApplyEnterTeamInfo b); // 0x05e36884
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRecruitApplyListPop.<>c__DisplayClass12_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiRecruitApplyListPop <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Void .ctor(); // 0x05e355a8
	System.Void <RenderListItem>b__0(); // 0x05e36918
	System.Void <RenderListItem>b__1(); // 0x05e36988
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamCaptainApply : System.Object, WizardGames.Soc.SocClient.Ui.ITeamMessagePopSubView
{
	FairyGUI.GLoader comLoader; // 0x10
	FairyGUI.GList list; // 0x18
	FairyGUI.Controller statusCtrl; // 0x20
	WizardGames.Soc.SocClient.Ui.ComAvatarSquare portrait; // 0x28
	FairyGUI.GLabel nameText; // 0x30
	FairyGUI.GButton refuseBtn; // 0x38
	FairyGUI.GButton agreeBtn; // 0x40
	FairyGUI.GList voteList; // 0x48
	FairyGUI.Controller voteStatusCtrl; // 0x50
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.MailNode> teamTipNodes; // 0x58
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiTeamCaptainApply.TeamMsgItem> msgItems; // 0x60
	WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType <TabType>k__BackingField; // 0x68
	System.Void set_TabType(WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType value); // 0x055056e8
	System.Void OnInit(FairyGUI.GComponent root); // 0x05523a54
	System.Void Refresh(); // 0x055049cc
	System.Void RefreshMessageList(); // 0x055049cc
	System.Void RenderItem(FairyGUI.GComponent item, WizardGames.Soc.SocClient.Ui.UiTeamCaptainApply.TeamMsgItem data); // 0x0552af00
	System.Void RenderImpeach(FairyGUI.GComponent item, System.String text); // 0x05e38404
	System.Void RenderVote(FairyGUI.GComponent item); // 0x05523a54
	System.Void RenderSystem(FairyGUI.GComponent item, System.String text); // 0x05e38614
	System.Void OnRefreshVoteList(); // 0x055049cc
	System.Void OnVoteItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x0550f6d4
	System.Void OnDestory(); // 0x05e38750
	System.Void OnImpeachStateChange(System.Int32 oldState, System.Int32 newState); // 0x05e387b0
	System.Void OnEnable(); // 0x05e38830
	System.Void OnDisable(); // 0x05e38a84
	System.Void OnTeamEntityInit(); // 0x05e38ca0
	System.Void RefreshTeamTips(); // 0x055049cc
	System.Void RenderTeamTip(FairyGUI.GComponent item, WizardGames.Soc.Common.CustomType.MailNode mail); // 0x0552af00
	System.String BuildImpeachNoticeText(); // 0x05e37eb8
	static System.String FormatImpeachDuration(System.Int32 offlineHours); // 0x05e38d6c
	static System.Boolean IsLocalPlayerCaptain(); // 0x05e38f88
	System.Void .ctor(); // 0x055049cc
	System.Void <RenderVote>b__24_0(Config.LobbyRoleInfo userInfo); // 0x05523a54
	System.Void <RenderVote>b__24_1(); // 0x055049cc
	System.Void <RenderVote>b__24_2(); // 0x055049cc
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiTeamCaptainApply.ETeamMsgItemType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiTeamCaptainApply.ETeamMsgItemType TeamTip = 0;
	static WizardGames.Soc.SocClient.Ui.UiTeamCaptainApply.ETeamMsgItemType Impeach = 1;
	static WizardGames.Soc.SocClient.Ui.UiTeamCaptainApply.ETeamMsgItemType Vote = 2;
	static WizardGames.Soc.SocClient.Ui.UiTeamCaptainApply.ETeamMsgItemType System = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamCaptainApply.TeamMsgItem : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiTeamCaptainApply.ETeamMsgItemType Type; // 0x10
	WizardGames.Soc.Common.CustomType.MailNode Mail; // 0x18
	System.String Text; // 0x20
	System.Void .ctor(); // 0x05e37e50
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamCaptainApply.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiTeamCaptainApply.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__23_0; // 0x8
	static System.Comparison<WizardGames.Soc.Common.CustomType.MailNode> <>9__33_0; // 0x10
	static System.Action<WizardGames.Soc.SocClient.Ui.UiCommonTeamBattle> <>9__34_2; // 0x18
	static System.Void .cctor(); // 0x05e39454
	System.Void .ctor(); // 0x05e394b8
	System.Void <RenderImpeach>b__23_0(); // 0x05e39520
	System.Int32 <RefreshTeamTips>b__33_0(WizardGames.Soc.Common.CustomType.MailNode a, WizardGames.Soc.Common.CustomType.MailNode b); // 0x054a3b30
	System.Void <RenderTeamTip>b__34_2(WizardGames.Soc.SocClient.Ui.UiCommonTeamBattle ui); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamCaptainApply.<>c__DisplayClass34_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.MailNode mail; // 0x10
	WizardGames.Soc.SocClient.Ui.UiTeamCaptainApply <>4__this; // 0x18
	System.Void .ctor(); // 0x055049cc
	System.Void <RenderTeamTip>b__0(); // 0x055049cc
	System.Void <RenderTeamTip>b__1(); // 0x055049cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamInviteInfos : System.Object, WizardGames.Soc.SocClient.Ui.ITeamMessagePopSubView
{
	WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType <TabType>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.ComInvitationMessageBinder binder; // 0x18
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo> inviteInfos; // 0x20
	System.Collections.Generic.Dictionary<System.String,WizardGames.Soc.SocClient.Ui.UiTeamInviteInfos.playerInfo> playerInfosCache; // 0x28
	System.Int64 animationTimerId; // 0x30
	System.Void set_TabType(WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType value); // 0x05e39cc8
	System.Void OnInit(FairyGUI.GComponent root); // 0x05e39d40
	System.Void RefreshView(System.Boolean needAni, WizardGames.Soc.Common.CustomType.TeamInviteInfo inviteInfo); // 0x05e39f5c
	System.Int32 SortFunc(WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo a, WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo b); // 0x05e3aa8c
	System.Void RenderListItem(System.Int32 index, FairyGUI.GObject obj); // 0x05e3abc0
	System.Void RefreshLabelList(FairyGUI.GList list, WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo info); // 0x05e3affc
	System.Void RefuseBtnClick(System.Int32 index); // 0x05e3b4a8
	System.Void AcceptBtnClick(System.Int32 index); // 0x05e3b65c
	System.Void RefuseAllBtnClick(); // 0x05e3b8e8
	System.Void ReqRefuseInvite(System.Collections.Generic.List<System.String> invitationIDs, System.Boolean isAppointment); // 0x05e3bda4
	System.Void GameInviteInfosChange(WizardGames.Soc.Share.Framework.ECustomDictOpType opType, System.UInt64 roleId, WizardGames.Soc.Common.CustomType.TeamInviteInfo oldInfo); // 0x05e3c2d4
	System.Void LobbyNewTeamInviteNotify(WizardGames.Soc.SocClient.Ui.ETeamInviteNotifyType opt, System.String id); // 0x05e3c3ac
	System.Void ClearAnimationTimer(); // 0x05e3c434
	System.Void OnEnable(); // 0x05e3c53c
	System.Void OnDisable(); // 0x05e3c754
	System.Void OnDestory(); // 0x05e3c964
	System.Void .ctor(); // 0x05e3c9c4
	System.Void <RefuseBtnClick>b__14_0(); // 0x05e3cad0
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiTeamInviteInfos.playerInfo : System.ValueType
{
	System.String RoleId; // 0x10
	System.String Name; // 0x18
	System.String Portrait; // 0x20
	System.Int32 Level; // 0x28
	System.Int32 PortraitFrame; // 0x2c
	Config.EUserPrivacy userPrivacy; // 0x30
	System.Int32 styleID; // 0x34
	System.Int32 rankPoint; // 0x38
	System.Int32 seasonPoints; // 0x3c
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamInviteInfos.<>c__DisplayClass10_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiTeamInviteInfos <>4__this; // 0x10
	System.Boolean needAni; // 0x18
	System.Void .ctor(); // 0x05e3aa24
	System.Void <RefreshView>b__0(SimpleJSON.JSONArray jsonArray); // 0x05e3cb3c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamInviteInfos.<>c__DisplayClass12_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiTeamInviteInfos <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Void .ctor(); // 0x05e3af94
	System.Void <RenderListItem>b__0(); // 0x05e3d284
	System.Void <RenderListItem>b__1(); // 0x05e3d2f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamInviteInfos.<>c__DisplayClass15_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComTeamInviteInfo inviteInfo; // 0x10
	System.Void .ctor(); // 0x05e3b880
	System.Void <AcceptBtnClick>b__0(); // 0x05e3d364
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamInviteInfos.<>c__DisplayClass17_0 : System.Object
{
	System.Boolean isAppointment; // 0x10
	System.Void .ctor(); // 0x05e3c204
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamInviteInfos.<>c__DisplayClass17_1 : System.Object
{
	System.Collections.Generic.List<System.String> temp2; // 0x10
	WizardGames.Soc.SocClient.Ui.UiTeamInviteInfos.<>c__DisplayClass17_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x05e3c26c
	System.Void <ReqRefuseInvite>b__0(System.Int64 _, System.Object _, System.Boolean _); // 0x05e3d460
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamMessagePop : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComModal_LargeBinder ModalBinder; // 0x338
	WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType curSelectTab; // 0x340
	FairyGUI.Controller statusCtrl; // 0x348
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType,WizardGames.Soc.SocClient.Ui.UiTeamMessagePop.UiSubViewInfo> subViewInfoMap; // 0x350
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType,WizardGames.Soc.SocClient.Ui.ITeamMessagePopSubView> subViewMap; // 0x358
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType,System.String> tabTypeNameMap; // 0x360
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType,WizardGames.Soc.SocClient.Ui.RedDotType> battleTabTypeRedDotMap; // 0x368
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType,WizardGames.Soc.SocClient.Ui.RedDotType> lobbyTabTypeRedDotMap; // 0x370
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType> battleTabTypeList; // 0x378
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType> lobbyTabTypeList; // 0x380
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType> singlePeopleTTabTypeList; // 0x388
	FairyGUI.GLoader invitationGLoader; // 0x390
	FairyGUI.GLoader recruitGLoader; // 0x398
	FairyGUI.GLoader appointmentRecruitGLoader; // 0x3a0
	FairyGUI.GLoader inGameRecruitGLoader; // 0x3a8
	FairyGUI.GLoader capatainGLoader; // 0x3b0
	FairyGUI.GButton shieldBtn; // 0x3b8
	System.Void OnInit(); // 0x05e3d540
	System.Void InitData(); // 0x05e3dd74
	System.Void SetData(WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType tabType); // 0x05e3e89c
	System.Void RenderTabItem(System.Int32 index, FairyGUI.GObject obj); // 0x05e3f358
	System.Void RefreshTabRedDot(WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType tabType, WizardGames.Soc.SocClient.Ui.ComRedDot redDot); // 0x05e3f654
	System.Void OnClickTab(WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType tabType); // 0x05e3eb4c
	System.Void OnClickClose(); // 0x05e3f750
	System.Void OnEnable(); // 0x05e3f7bc
	System.Void OnDisable(); // 0x05e3f8d0
	System.Void OnDestroy(); // 0x05e3f9e4
	static System.Void OpenWindow(WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType type); // 0x05e2a650
	System.Void ShieldBtnClick(FairyGUI.EventContext ctx); // 0x05e3fcd8
	System.Void OnTeamTipsChanged(); // 0x05e3fdf8
	System.Void .ctor(); // 0x05e40104
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiTeamMessagePop.UiSubViewInfo : System.ValueType
{
	FairyGUI.GLoader GLoader; // 0x10
	System.String ComponentUrl; // 0x18
	System.Func<WizardGames.Soc.SocClient.Ui.ITeamMessagePopSubView> Creator; // 0x20
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamMessagePop.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiTeamMessagePop.<>c <>9; // 0x0
	static System.Func<WizardGames.Soc.SocClient.Ui.ITeamMessagePopSubView> <>9__19_0; // 0x8
	static System.Func<WizardGames.Soc.SocClient.Ui.ITeamMessagePopSubView> <>9__19_1; // 0x10
	static System.Func<WizardGames.Soc.SocClient.Ui.ITeamMessagePopSubView> <>9__19_2; // 0x18
	static System.Func<WizardGames.Soc.SocClient.Ui.ITeamMessagePopSubView> <>9__19_3; // 0x20
	static System.Func<WizardGames.Soc.SocClient.Ui.ITeamMessagePopSubView> <>9__19_4; // 0x28
	static System.Void .cctor(); // 0x05e401e4
	System.Void .ctor(); // 0x05e40248
	WizardGames.Soc.SocClient.Ui.ITeamMessagePopSubView <InitData>b__19_0(); // 0x05e402b0
	WizardGames.Soc.SocClient.Ui.ITeamMessagePopSubView <InitData>b__19_1(); // 0x05e40338
	WizardGames.Soc.SocClient.Ui.ITeamMessagePopSubView <InitData>b__19_2(); // 0x05e403c0
	WizardGames.Soc.SocClient.Ui.ITeamMessagePopSubView <InitData>b__19_3(); // 0x05e40448
	WizardGames.Soc.SocClient.Ui.ITeamMessagePopSubView <InitData>b__19_4(); // 0x05e404d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamMessagePop.<>c__DisplayClass21_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiTeamMessagePop <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType tabType; // 0x18
	System.Void .ctor(); // 0x05e3f5ec
	System.Void <RenderTabItem>b__0(); // 0x05e40558
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamMessagePop.<>c__DisplayClass28_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType type; // 0x10
	System.Void .ctor(); // 0x05e3fc70
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiTeamMessagePop win); // 0x05e405c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonTeamBattle : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update, WizardGames.Soc.SocClient.Ui.IJumpToUIWindow
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.UiCommonTeamBinder binder; // 0x338
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ETeamTabType,WizardGames.Soc.SocClient.Ui.UiCommonTeamBattle.UiSubViewInfo> subViewInfoMap; // 0x340
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ETeamTabType,WizardGames.Soc.SocClient.Ui.ITeamSubView> subViewMap; // 0x348
	WizardGames.Soc.SocClient.Ui.ETeamTabType curSelectTab; // 0x350
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x358
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x360
	FairyGUI.GButton tipsButton; // 0x368
	FairyGUI.Controller btnTipStyleCtrl; // 0x370
	System.Void OnInit(); // 0x05e4064c
	System.Void InitBar(); // 0x05e40c98
	System.Void InitSubViewData(); // 0x05e41534
	System.Void SetHelpTooltips(System.String text); // 0x05e41a4c
	System.Void SetTipsBtnText(System.String str); // 0x05e419c4
	System.Void OnClickTab(System.Int32 index); // 0x05e41cd8
	System.Void JumpToTab(WizardGames.Soc.SocClient.Ui.ETeamTabType tabType); // 0x05e3971c
	System.Void OnEnable(); // 0x05e42370
	System.Void OnDisable(); // 0x05e42668
	System.Void MakeFullScreen(); // 0x05e428ac
	System.Void OnDestroy(); // 0x05e42914
	System.Void OnFps10Update(System.Single dt); // 0x05e42be8
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05e42d04
	System.Void JumpToUIWindow(WizardGames.Soc.SocClient.Ui.JumpData jumpData); // 0x05e42d84
	System.Void NotificationPermissionForAppointmentTeam(); // 0x05e41b84
	System.Void ShotNotificationPermission(); // 0x05e42e24
	System.Void .ctor(); // 0x05e42f14
	System.Void <InitBar>b__11_0(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x05e42ff4
	WizardGames.Soc.SocClient.Ui.ITeamSubView <InitSubViewData>b__12_1(); // 0x05e430c8
	System.Void <NotificationPermissionForAppointmentTeam>b__24_0(System.Boolean result); // 0x05e4315c
	System.Void <ShotNotificationPermission>b__25_0(System.Boolean result); // 0x05e4355c
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiCommonTeamBattle.UiSubViewInfo : System.ValueType
{
	FairyGUI.GLoader GLoader; // 0x10
	System.String ComponentUrl; // 0x18
	System.Func<WizardGames.Soc.SocClient.Ui.ITeamSubView> Creator; // 0x20
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonTeamBattle.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiCommonTeamBattle.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__10_0; // 0x8
	static FairyGUI.TransitionHook <>9__10_1; // 0x10
	static System.Func<WizardGames.Soc.SocClient.Ui.ITeamSubView> <>9__12_0; // 0x18
	static System.Void .cctor(); // 0x05e43790
	System.Void .ctor(); // 0x05e437f4
	System.Void <OnInit>b__10_0(FairyGUI.EventContext ctx); // 0x05e4385c
	System.Void <OnInit>b__10_1(); // 0x05e43948
	WizardGames.Soc.SocClient.Ui.ITeamSubView <InitSubViewData>b__12_0(); // 0x05e43a50
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonTeamBattle.<>c__DisplayClass13_0 : System.Object
{
	System.Boolean isTipOpen; // 0x10
	WizardGames.Soc.SocClient.Ui.UiCommonTeamBattle <>4__this; // 0x18
	System.String text; // 0x20
	System.Void .ctor(); // 0x05e41c70
	System.Void <SetHelpTooltips>b__0(); // 0x05e43adc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonTeamLobby : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonTeam.UiCommonTeamBinder binder; // 0x338
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ETeamTabType,WizardGames.Soc.SocClient.Ui.UiCommonTeamLobby.UiSubViewInfo> subViewInfoMap; // 0x340
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.ETeamTabType,WizardGames.Soc.SocClient.Ui.ITeamSubView> subViewMap; // 0x348
	WizardGames.Soc.SocClient.Ui.ETeamTabType curSelectTab; // 0x350
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x358
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x360
	System.Void OnInit(); // 0x05e43bcc
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05e45140
	System.Void InitTabButton(); // 0x05e44c6c
	System.Void JumpToTab(WizardGames.Soc.SocClient.Ui.ETeamTabType tabType); // 0x05e451c0
	System.Void InitData(); // 0x05e44404
	System.Void OnClickTab(System.Int32 index, System.Boolean needAni); // 0x05e452c8
	System.Void OnEnable(); // 0x05e45884
	System.Void OnDisable(); // 0x05e45b78
	System.Void OnDestroy(); // 0x05e45c80
	System.Void OnFps10Update(System.Single dt); // 0x05e45ec8
	FairyGUI.GObject GetGuideObjByID(System.Int64 id); // 0x05e45fe4
	System.Void .ctor(); // 0x05e460f0
	System.Void <InitTabButton>b__9_0(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x05e461d0
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiCommonTeamLobby.UiSubViewInfo : System.ValueType
{
	FairyGUI.GLoader GLoader; // 0x10
	System.String ComponentUrl; // 0x18
	System.Func<WizardGames.Soc.SocClient.Ui.ITeamSubView> Creator; // 0x20
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonTeamLobby.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiCommonTeamLobby.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__7_0; // 0x8
	static System.Func<WizardGames.Soc.SocClient.Ui.ITeamSubView> <>9__11_0; // 0x10
	static System.Func<WizardGames.Soc.SocClient.Ui.ITeamSubView> <>9__11_1; // 0x18
	static System.Func<WizardGames.Soc.SocClient.Ui.ITeamSubView> <>9__11_2; // 0x20
	static System.Func<WizardGames.Soc.SocClient.Ui.ITeamSubView> <>9__11_3; // 0x28
	static System.Void .cctor(); // 0x05e632a0
	System.Void .ctor(); // 0x05e63304
	System.Void <OnInit>b__7_0(FairyGUI.EventContext ctx); // 0x05e6336c
	WizardGames.Soc.SocClient.Ui.ITeamSubView <InitData>b__11_0(); // 0x05e63458
	WizardGames.Soc.SocClient.Ui.ITeamSubView <InitData>b__11_1(); // 0x05e634e4
	WizardGames.Soc.SocClient.Ui.ITeamSubView <InitData>b__11_2(); // 0x05e63570
	WizardGames.Soc.SocClient.Ui.ITeamSubView <InitData>b__11_3(); // 0x05e635fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCommonTeamLobby.<>c__DisplayClass7_0 : System.Object
{
	FairyGUI.GButton tipbtn; // 0x10
	System.Void .ctor(); // 0x05e63688
	System.Void <OnInit>b__1(FairyGUI.EventContext ctx); // 0x05e636f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionBadgeFlag : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.UnionFlagBinder rootBinder; // 0x10
	FairyGUI.GTextField txtName; // 0x18
	System.Action onChange; // 0x20
	System.Action<System.Collections.Generic.List<System.Int32>> onSave; // 0x28
	System.Action<System.Collections.Generic.List<System.Int32>> onRandom; // 0x30
	WizardGames.Soc.SocClient.Ui.UnionBadge unionBadge; // 0x38
	System.Collections.Generic.SortedDictionary<System.Int32,System.Int32> iconDic; // 0x40
	System.Boolean onlyShow; // 0x48
	System.Void .ctor(FairyGUI.GComponent root, System.Boolean onlyShow); // 0x05e637ac
	System.Void OnEnable(); // 0x05e63d8c
	System.Void OnDisable(); // 0x05e63ea0
	System.Void SetData(System.Collections.Generic.List<System.Int32> values); // 0x05e63fb4
	System.Void SetDataById(System.Int32 id); // 0x05e64740
	System.Collections.Generic.List<System.Int32> GetValues(); // 0x05e64814
	System.Void UpdateDic(System.Int32 id); // 0x05e64180
	System.Void OnInit(); // 0x05e638dc
	System.Void OnBtnChangeClick(); // 0x05e649bc
	System.Void SetOnChange(System.Action callback); // 0x05e64a34
	System.Void OnBtnSaveClick(); // 0x05e64ab4
	System.Void SetOnSave(System.Action<System.Collections.Generic.List<System.Int32>> callback); // 0x05e64b40
	System.Void OnBtnRandomClick(); // 0x05e64bc0
	System.Void SetOnRandom(System.Action<System.Collections.Generic.List<System.Int32>> callback); // 0x05e652a4
	System.Void SetName(System.String name); // 0x05e65324
	System.Void SetChangeBtnCdState(System.Boolean cdState); // 0x05e65444
	System.Void SetChangeBtnVisible(System.Boolean show); // 0x05e65740
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionBadgeFlag.<>c__DisplayClass14_0 : System.Object
{
	System.Int32 id; // 0x10
	System.Void .ctor(); // 0x05e648b4
	System.Boolean <UpdateDic>b__0(WizardGames.Soc.Common.Data.Play.OBJCommunityIcon v); // 0x05e65814
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EType Icon = 0;
	static WizardGames.Soc.SocClient.Ui.EType Color = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionBadgeGroup : System.Object
{
	System.Int32 index; // 0x10
	System.Boolean isCreate; // 0x14
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComBadgeInputBinder rootBinder; // 0x18
	System.Int32 unionLevel; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.OBJCommunityIcon> iconList; // 0x28
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.OBJCommunityIcon> colorList; // 0x30
	System.Int32 colNum; // 0x38
	System.Void .ctor(System.Int32 index, FairyGUI.GObject obj, System.Boolean isCreate); // 0x05e658a0
	System.Void OnInit(); // 0x05e65a94
	System.Void RenderElementItem(System.Int32 index, FairyGUI.GObject obj); // 0x05e66978
	System.Void RenderElementColorItem(System.Int32 index, FairyGUI.GObject obj); // 0x05e66fa0
	System.Void UpdateIconInfo(System.Int32 index, FairyGUI.GObject obj); // 0x05e66b6c
	System.Void UpdateColorInfo(System.Int32 index, FairyGUI.GObject obj); // 0x05e67194
	System.Void ItemOnClick(FairyGUI.EventContext ctx, System.Int32 index, WizardGames.Soc.SocClient.Ui.EType type); // 0x05e67678
	System.Boolean GetLockStatus(WizardGames.Soc.Common.Data.Play.OBJCommunityIcon cfg); // 0x05e67584
	System.Boolean <OnInit>b__8_0(WizardGames.Soc.Common.Data.Play.OBJCommunityIcon cfg); // 0x05e67a40
	System.Boolean <OnInit>b__8_1(WizardGames.Soc.Common.Data.Play.OBJCommunityIcon cfg); // 0x05e67acc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionBadgeGroup.<>c__DisplayClass10_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiUnionBadgeGroup <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Void .ctor(); // 0x05e6712c
	System.Void <RenderElementColorItem>b__0(FairyGUI.EventContext ctx); // 0x05e67b58
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionBadgeGroup.<>c__DisplayClass11_0 : System.Object
{
	WizardGames.Soc.Common.Data.Play.OBJCommunityIcon cfg; // 0x10
	System.Void .ctor(); // 0x05e6751c
	System.Boolean <UpdateIconInfo>b__0(System.Int32 v); // 0x05e67be4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionBadgeGroup.<>c__DisplayClass12_0 : System.Object
{
	WizardGames.Soc.Common.Data.Play.OBJCommunityIcon cfg; // 0x10
	System.Void .ctor(); // 0x05e67610
	System.Boolean <UpdateColorInfo>b__0(System.Int32 v); // 0x05e67c70
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionBadgeGroup.<>c__DisplayClass9_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiUnionBadgeGroup <>4__this; // 0x10
	System.Int32 index; // 0x18
	System.Void .ctor(); // 0x05e66b04
	System.Void <RenderElementItem>b__0(FairyGUI.EventContext ctx); // 0x05e67cfc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UnionBadge : System.Object
{
	FairyGUI.GComponent root; // 0x10
	System.Void .ctor(FairyGUI.GComponent component, System.Collections.Generic.List<System.Int32> iconData); // 0x05e6491c
	System.Void Reset(); // 0x05e67d88
	System.Void Update(System.Collections.Generic.List<System.Int32> iconData); // 0x05e64354
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UnionBaseInfoCard : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.UnionBaceInfoBinder binder; // 0x10
	WizardGames.Soc.SocClient.Ui.UnionInfo unionInfo; // 0x18
	WizardGames.Soc.SocClient.Ui.UnionBadge unionBadge; // 0x20
	FairyGUI.GButton btnJoin; // 0x28
	FairyGUI.GTextField inpAnnouncement; // 0x30
	FairyGUI.GTextField txtName; // 0x38
	FairyGUI.GTextField txtJoinLevel; // 0x40
	FairyGUI.GTextField txtReview; // 0x48
	FairyGUI.GTextField txtLevel; // 0x50
	FairyGUI.GTextField txtIdNum; // 0x58
	WizardGames.Soc.SocClient.Ui.ComAvatarSquare head; // 0x60
	System.Boolean applyState; // 0x68
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.UnionBaceInfoBinder root); // 0x05e67f98
	System.Void OnInit(); // 0x05e6802c
	System.Void SetDefault(); // 0x05e686bc
	System.Void Reset(); // 0x05e68ad4
	System.Void UpdateInfo(WizardGames.Soc.SocClient.Ui.UnionInfo info); // 0x05e68b38
	System.Void SetCdState(); // 0x05e698c8
	System.Void SetBtnApplied(); // 0x05e69800
	System.Void GetPresidentInfo(System.UInt64 id); // 0x05e69ab8
	System.Void UpdatePresidentInfo(WizardGames.Soc.SocClient.Ui.PresidentInfo info); // 0x05e6881c
	System.Void OnBtnClick(); // 0x05e69dd4
	System.Void QuickJoinUnion(); // 0x055049cc
	System.Void <GetPresidentInfo>b__19_0(SimpleJSON.JSONArray info); // 0x05e6a0a0
	System.Void <OnBtnClick>b__21_0(SimpleJSON.JSONNode info); // 0x05e6a284
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UnionBaseInfoCard.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UnionBaseInfoCard.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.UnionInfo> <>9__22_0; // 0x8
	static System.Void .cctor(); // 0x05e6a48c
	System.Void .ctor(); // 0x05e6a4f0
	System.Void <QuickJoinUnion>b__22_0(WizardGames.Soc.SocClient.Ui.UnionInfo info); // 0x05e6a558
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UnionComOptionaModeParams : System.Object
{
	System.Nullable<System.Int32> <LevelValue>k__BackingField; // 0x10
	System.Nullable<System.Int32> <ReviewValue>k__BackingField; // 0x18
	System.Action<System.Int32> <LevelCallback>k__BackingField; // 0x20
	System.Action<System.Int32> <ReviewCallback>k__BackingField; // 0x28
	System.Nullable<System.Int32> get_LevelValue(); // 0x05e6a6c4
	System.Void set_LevelValue(System.Nullable<System.Int32> value); // 0x05e6a728
	System.Nullable<System.Int32> get_ReviewValue(); // 0x05e6a7a0
	System.Void set_ReviewValue(System.Nullable<System.Int32> value); // 0x05e6a804
	System.Action<System.Int32> get_LevelCallback(); // 0x05e6a87c
	System.Void set_LevelCallback(System.Action<System.Int32> value); // 0x05e6a8e0
	System.Action<System.Int32> get_ReviewCallback(); // 0x05e6a960
	System.Void set_ReviewCallback(System.Action<System.Int32> value); // 0x05e6a9c4
	System.Void .ctor(); // 0x05e6aa44
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UnionComOptionaMode : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComOptionalModeBinder rootBinder; // 0x10
	WizardGames.Soc.SocClient.Ui.ComComboBox selectReview; // 0x18
	FairyGUI.GTextInput inputLevel; // 0x20
	FairyGUI.GButton btnLevelHelp; // 0x28
	System.Int32 levelDefault; // 0x30
	System.Int32 reviewDefault; // 0x34
	System.Int32 levelValue; // 0x38
	System.Int32 reviewValue; // 0x3c
	System.Collections.Generic.List<System.Int32> reviewValueList; // 0x40
	System.Action<System.Int32> levelChanged; // 0x48
	System.Action<System.Int32> reviewChanged; // 0x50
	System.Void .ctor(FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.UnionComOptionaModeParams opt); // 0x05e6aaac
	System.Void OnInit(); // 0x05e6ad68
	System.Void InitReview(); // 0x05e6afb8
	System.Void ComBoxChange(System.Int32 index); // 0x05e6b450
	System.Void InitLevelLimit(); // 0x05e6b1c8
	System.Void OnLevelFocusOut(); // 0x05e6b50c
	System.Int32 GetLevelValue(); // 0x05e6b7b8
	System.Void SetLevelEnabled(System.Boolean val); // 0x05e6b838
	System.Int32 GetReviewValue(); // 0x05e6b8c0
	System.Int32 GetReviewIndexByVal(System.Int32 val); // 0x05e6b338
	System.Void SetReviewEnabled(System.Boolean val); // 0x05e6b9a0
	System.Boolean IsDefaultValue(); // 0x05e6ba28
	System.Void Reset(); // 0x05e6bb04
	System.Void ResetReview(System.Int32 val); // 0x05e6bbb4
	System.Void ResetLevel(System.Int32 val); // 0x05e6bc80
	System.Void <InitLevelLimit>b__15_0(); // 0x05e6bd24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UnionComOptionaMode.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UnionComOptionaMode.<>c <>9; // 0x0
	static System.Converter<System.Int32,System.String> <>9__13_0; // 0x8
	static System.Void .cctor(); // 0x05e6be2c
	System.Void .ctor(); // 0x05e6be90
	System.String <InitReview>b__13_0(System.Int32 v); // 0x05e6bef8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UnionComOptionaMode.<>c__DisplayClass21_0 : System.Object
{
	System.Int32 val; // 0x10
	System.Void .ctor(); // 0x05e6b938
	System.Boolean <GetReviewIndexByVal>b__0(System.Int32 v); // 0x05e6bf7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UnionComSearch : System.Object
{
	FairyGUI.GComponent root; // 0x10
	FairyGUI.GTextInput inputText; // 0x18
	FairyGUI.GButton btnSearch; // 0x20
	FairyGUI.GButton btnClear; // 0x28
	System.Action<System.String> searchAction; // 0x30
	System.Action clearAction; // 0x38
	System.Void .ctor(FairyGUI.GComponent component, System.Action<System.String> searchAction, System.Action clearAction); // 0x05e6bffc
	System.Void InitComSearch(); // 0x05e6c0cc
	System.Void InputTextChange(); // 0x05e6c414
	System.Void OnClickClearText(); // 0x05e6c544
	System.Void OnClickSearch(System.Boolean needClearTxt); // 0x05e6c608
	System.Void <InitComSearch>b__7_0(FairyGUI.EventContext ctx); // 0x05e6c6c0
	System.Void <InitComSearch>b__7_1(); // 0x05e6c73c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EUnionReviewType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EUnionReviewType NeedReview = 1;
	static WizardGames.Soc.SocClient.Ui.EUnionReviewType AutoJoin = 2;
	static WizardGames.Soc.SocClient.Ui.EUnionReviewType Deny = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EUnionModifyPermission : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EUnionModifyPermission ModifyName = 0;
	static WizardGames.Soc.SocClient.Ui.EUnionModifyPermission ModifyIcon = 1;
	static WizardGames.Soc.SocClient.Ui.EUnionModifyPermission ModifyAnnouncement = 2;
	static WizardGames.Soc.SocClient.Ui.EUnionModifyPermission PositionAdjustment = 3;
	static WizardGames.Soc.SocClient.Ui.EUnionModifyPermission InviteMember = 4;
	static WizardGames.Soc.SocClient.Ui.EUnionModifyPermission ApproveMembership = 5;
	static WizardGames.Soc.SocClient.Ui.EUnionModifyPermission KickMember = 6;
	static WizardGames.Soc.SocClient.Ui.EUnionModifyPermission ChangeApprovalMethod = 7;
	static WizardGames.Soc.SocClient.Ui.EUnionModifyPermission BanCommunityChat = 8;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EUnionIdentityType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EUnionIdentityType normal = 0;
	static WizardGames.Soc.SocClient.Ui.EUnionIdentityType master = 1;
	static WizardGames.Soc.SocClient.Ui.EUnionIdentityType deputy = 2;
	static WizardGames.Soc.SocClient.Ui.EUnionIdentityType manager = 3;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EUnionOperationType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EUnionOperationType appoint = 1;
	static WizardGames.Soc.SocClient.Ui.EUnionOperationType unappoint = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UnionCreateOptions : System.Object
{
	System.String <Announcement>k__BackingField; // 0x10
	System.Int32 <ApplicationLevelLimit>k__BackingField; // 0x18
	System.String <HireAnnouncement>k__BackingField; // 0x20
	System.Collections.Generic.List<System.Int32> <Icons>k__BackingField; // 0x28
	System.String <Name>k__BackingField; // 0x30
	System.Int32 <ReviewType>k__BackingField; // 0x38
	System.String get_Announcement(); // 0x05e6c7b0
	System.Void set_Announcement(System.String value); // 0x05e6c814
	System.Int32 get_ApplicationLevelLimit(); // 0x05e6c894
	System.Void set_ApplicationLevelLimit(System.Int32 value); // 0x05e6c8f8
	System.String get_HireAnnouncement(); // 0x05e6c970
	System.Void set_HireAnnouncement(System.String value); // 0x05e6c9d4
	System.Collections.Generic.List<System.Int32> get_Icons(); // 0x05e6ca54
	System.Void set_Icons(System.Collections.Generic.List<System.Int32> value); // 0x05e6cab8
	System.String get_Name(); // 0x05e6cb38
	System.Void set_Name(System.String value); // 0x05e6cb9c
	System.Int32 get_ReviewType(); // 0x05e6cc1c
	System.Void set_ReviewType(System.Int32 value); // 0x05e6cc80
	System.Void .ctor(); // 0x05e6ccf8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ExtendedPresidentInfo : System.Object
{
	System.Int32 Contribution; // 0x10
	System.Int32 Identity; // 0x14
	System.String Icon; // 0x18
	System.Int32 FrameId; // 0x20
	System.Int32 Level; // 0x24
	System.String Name; // 0x28
	System.Boolean Deleted; // 0x30
	System.String RoleId; // 0x38
	System.Int32 Status; // 0x40
	System.String Lastlogouttime; // 0x48
	System.String Lastlogintime; // 0x50
	System.Int32 BattleGameMode; // 0x58
	System.Int32 TeamStatus; // 0x5c
	Config.EUserPrivacy UserPrivacy; // 0x60
	System.Int32 SeasonPoints; // 0x64
	System.Void .ctor(); // 0x05e6cd60
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UnionInfo : System.Object
{
	System.UInt64 <CommunityID>k__BackingField; // 0x10
	System.Int32 <ActiveScore>k__BackingField; // 0x18
	System.Int32 <Exp>k__BackingField; // 0x1c
	System.Int32 <Level>k__BackingField; // 0x20
	System.Int32 <ApplicationLevelLimit>k__BackingField; // 0x24
	System.Int32 <LevelExp>k__BackingField; // 0x28
	System.Int32 <MemberCount>k__BackingField; // 0x2c
	System.Int32 <NewerReviewType>k__BackingField; // 0x30
	System.Int32 <NextLevelExp>k__BackingField; // 0x34
	System.String <Announcement>k__BackingField; // 0x38
	System.String <CreateTime>k__BackingField; // 0x40
	System.String <HireAnnouncement>k__BackingField; // 0x48
	SimpleJSON.JSONArray <Icons>k__BackingField; // 0x50
	System.String <InGameGroupID>k__BackingField; // 0x58
	System.String <Name>k__BackingField; // 0x60
	System.UInt64 <PresidentID>k__BackingField; // 0x68
	System.UInt64 get_CommunityID(); // 0x05e6cdc8
	System.Void set_CommunityID(System.UInt64 value); // 0x05e6ce2c
	System.Int32 get_ActiveScore(); // 0x05e6cea4
	System.Void set_ActiveScore(System.Int32 value); // 0x05e6cf08
	System.Int32 get_Exp(); // 0x05e6cf80
	System.Void set_Exp(System.Int32 value); // 0x05e6cfe4
	System.Int32 get_Level(); // 0x05e6d05c
	System.Void set_Level(System.Int32 value); // 0x05e6d0c0
	System.Int32 get_ApplicationLevelLimit(); // 0x05e6d138
	System.Void set_ApplicationLevelLimit(System.Int32 value); // 0x05e6d19c
	System.Int32 get_LevelExp(); // 0x05e6d214
	System.Void set_LevelExp(System.Int32 value); // 0x05e6d278
	System.Int32 get_MemberCount(); // 0x05e6d2f0
	System.Void set_MemberCount(System.Int32 value); // 0x05e6d354
	System.Int32 get_NewerReviewType(); // 0x05e6d3cc
	System.Void set_NewerReviewType(System.Int32 value); // 0x05e6d430
	System.Int32 get_NextLevelExp(); // 0x05e6d4a8
	System.Void set_NextLevelExp(System.Int32 value); // 0x05e6d50c
	System.String get_Announcement(); // 0x05e6d584
	System.Void set_Announcement(System.String value); // 0x05e6d5e8
	System.Void set_CreateTime(System.String value); // 0x05e6d668
	System.String get_HireAnnouncement(); // 0x05e6d6e8
	System.Void set_HireAnnouncement(System.String value); // 0x05e6d74c
	SimpleJSON.JSONArray get_Icons(); // 0x05e6d7cc
	System.Void set_Icons(SimpleJSON.JSONArray value); // 0x05e6d830
	System.String get_InGameGroupID(); // 0x05e6d8b0
	System.Void set_InGameGroupID(System.String value); // 0x05e6d914
	System.String get_Name(); // 0x05e6d994
	System.Void set_Name(System.String value); // 0x05e6d9f8
	System.UInt64 get_PresidentID(); // 0x05e6da78
	System.Void set_PresidentID(System.UInt64 value); // 0x05e6dadc
	System.Void .ctor(SimpleJSON.JSONNode node); // 0x05e6db54
	System.Void ParseData(SimpleJSON.JSONNode node, System.Boolean isReplace); // 0x05e6dbe0
	System.Void SetName(System.String value); // 0x05e6e5ac
	System.Void SetAnnouncement(System.String value); // 0x05e6e6b8
	System.Void SetHireAnnoucement(System.String value); // 0x05e6e7c4
	System.Void SetReviewType(System.Int32 value); // 0x05e6e8d0
	System.Void SetApplicationLevelLimit(System.Int32 value); // 0x05e6e9d0
	System.Void SetIcons(System.Collections.Generic.List<System.Int32> value); // 0x05e6eb08
	System.Void SetMemberCount(System.Int32 val); // 0x05e6ed9c
	System.Boolean IsPresident(); // 0x05e6ee48
	System.Void SetPresidentID(System.UInt64 value); // 0x05e6ef68
	System.Int32 GetMemberLimit(); // 0x05e6f068
	System.Collections.Generic.List<System.Int32> GetIconList(); // 0x05e694cc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PresidentInfo : System.Object
{
	System.String Icon; // 0x10
	System.Int32 FrameId; // 0x18
	System.Int32 Level; // 0x1c
	System.String Name; // 0x20
	System.Boolean Deleted; // 0x28
	System.String RoleId; // 0x30
	System.Int32 Status; // 0x38
	System.String Lastlogouttime; // 0x40
	System.String Lastlogintime; // 0x48
	System.Int32 BattleGameMode; // 0x50
	System.Int32 TeamStatus; // 0x54
	Config.EUserPrivacy UserPrivacy; // 0x58
	System.Int32 SeasonPoints; // 0x5c
	System.Void .ctor(SimpleJSON.JSONNode node); // 0x05e6a1f8
	System.Void ParseData(SimpleJSON.JSONNode node, System.Boolean isReplace); // 0x05e6f26c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UnionMember : System.Object
{
	System.Int32 <Contribution>k__BackingField; // 0x10
	System.Int32 <Identity>k__BackingField; // 0x14
	System.Int32 <JoinedTime>k__BackingField; // 0x18
	System.UInt64 <RoleID>k__BackingField; // 0x20
	System.Int32 get_Contribution(); // 0x05e6f6d4
	System.Void set_Contribution(System.Int32 value); // 0x05e6f738
	System.Int32 get_Identity(); // 0x05e6f7b0
	System.Void set_Identity(System.Int32 value); // 0x05e6f814
	System.Void set_JoinedTime(System.Int32 value); // 0x05e6f88c
	System.UInt64 get_RoleID(); // 0x05e6f904
	System.Void set_RoleID(System.UInt64 value); // 0x05e6f968
	System.Void .ctor(SimpleJSON.JSONNode node); // 0x05e6f9e0
	System.Void ParseData(SimpleJSON.JSONNode node, System.Boolean isReplace); // 0x05e6fa6c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UnionInvitation : System.Object
{
	WizardGames.Soc.SocClient.Ui.UnionInfo <Community>k__BackingField; // 0x10
	System.UInt64 <InviterID>k__BackingField; // 0x18
	WizardGames.Soc.SocClient.Ui.UnionInfo get_Community(); // 0x05e6fd28
	System.Void set_Community(WizardGames.Soc.SocClient.Ui.UnionInfo value); // 0x05e6fd8c
	System.UInt64 get_InviterID(); // 0x05e6fe0c
	System.Void set_InviterID(System.UInt64 value); // 0x05e6fe70
	System.Void .ctor(SimpleJSON.JSONNode node); // 0x05e6fee8
	System.Void ParseData(SimpleJSON.JSONNode node, System.Boolean isReplace); // 0x05e6ff74
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.ApplicatonPlayerInfo : System.ValueType
{
	System.String RoleId; // 0x10
	System.String Name; // 0x18
	System.String Portrait; // 0x20
	System.Int32 PortraitFrame; // 0x28
	System.Int32 Level; // 0x2c
	Config.EUserPrivacy UserPrivacy; // 0x30
	System.Int32 SeasonPoints; // 0x34
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UnionLogInfo : System.ValueType
{
	System.String EventData; // 0x10
	System.String EventID; // 0x18
	System.String EventTime; // 0x20
	System.String EventTimes; // 0x28
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UnionUtils : System.Object
{
	static System.Collections.Generic.List<System.Int32> ReviewValues; // 0x0
	static System.Collections.Generic.List<System.String> ReviewOptions; // 0x8
	static System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.EUnionReviewType,System.String> ReviewShowTxt; // 0x10
	static System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.EUnionReviewType,System.String> ReviewBtnTxt; // 0x18
	static System.Collections.Generic.List<System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.OBJCommunityIcon>> iconConfigGroup; // 0x20
	static System.Int32 IconColorType; // 0x28
	static System.Boolean GetModifyPermission(WizardGames.Soc.SocClient.Ui.UnionMember member, WizardGames.Soc.SocClient.Ui.EUnionModifyPermission type); // 0x05e7013c
	static WizardGames.Soc.Common.Data.Play.OBJCommunityRule GetRuleConfigById(System.Int32 ruleId); // 0x05e69c5c
	static WizardGames.Soc.Common.Data.Play.OBJCommunityLevel GetLevelConfigByLv(System.Int32 lv); // 0x05e702d0
	static System.Int32 GetMemberLimitByLv(System.Int32 lv); // 0x05e6f13c
	static System.Collections.Generic.List<WizardGames.Soc.Common.Data.common.BTuple2> GetCreateCost(); // 0x05e70490
	static System.Boolean CheckCreateCost(); // 0x05e70570
	static System.ValueTuple<System.Int32,System.Int32> GetNameLimit(); // 0x05e708a4
	static System.ValueTuple<System.Int32,System.Int32> GetHireAnnouncementLimit(); // 0x05e70a20
	static System.ValueTuple<System.Int32,System.Int32> GetAnnouncementLimit(); // 0x05e70b34
	static System.ValueTuple<System.Int32,System.Int32> GetLevelLimit(); // 0x05e6b674
	static System.Int32 GetPlayerLevelMax(); // 0x05e70c48
	static System.Int32 GetCostOwnedNum(System.Int32 id); // 0x05e7073c
	static System.Collections.Generic.List<System.Int32> GetBadgeDefaultValue(); // 0x05e70dfc
	static System.Collections.Generic.List<System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.OBJCommunityIcon>> GetIconConfigGrp(); // 0x05e710cc
	static System.Collections.Generic.List<System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.OBJCommunityIcon>> GetBadgeIconGrp(); // 0x05e665c4
	static System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.OBJCommunityIcon> GetBadgeColorList(); // 0x05e66874
	static System.Collections.Generic.List<System.Int32> GetBadgeValueRandom(System.Int32 level); // 0x05e64d98
	static System.Collections.Generic.SortedDictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.Common.Data.Play.OBJCommunityIcon>> GetIconConfigSortedDic(); // 0x05e711f4
	static WizardGames.Soc.Common.Data.Play.OBJCommunityIcon GetIconConfigById(System.Int32 id); // 0x05e67e20
	static System.String GetReviewName(System.Int32 val); // 0x05e693b4
	static System.String GetReviewBtnTxt(System.Int32 val); // 0x05e696e8
	static System.ValueTuple<System.Boolean,System.Boolean> GetApplyState(System.Int32 roleLevel, System.Int32 reviewType, System.Int32 levelimit); // 0x05e69260
	static System.Boolean GetInviteState(System.Int32 roleLevel, System.Int32 levelimit); // 0x05e7159c
	static System.Int32 GetCreateLevelState(); // 0x05e716a8
	static System.ValueTuple<System.Int32,System.String> GetRuleCommunityPositionInfo(System.Int32 Identity, WizardGames.Soc.Common.Data.Play.OBJCommunityRule cfg); // 0x05e717d4
	static System.Void .cctor(); // 0x05e71944
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UnionUtils.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UnionUtils.<>c <>9; // 0x0
	static System.Func<WizardGames.Soc.Common.Data.common.OBJPlayerLevel,System.Int32> <>9__14_0; // 0x8
	static System.Void .cctor(); // 0x05e71eb4
	System.Void .ctor(); // 0x05e71f18
	System.Int32 <GetPlayerLevelMax>b__14_0(WizardGames.Soc.Common.Data.common.OBJPlayerLevel x); // 0x05e71f80
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionApplicationPopUp : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GList applicationList; // 0x338
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x340
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.UiUnionApplicationPopUpBinder rootBinder; // 0x348
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ApplicatonPlayerInfo> tempApplicaionList; // 0x350
	System.Single lastClickTime; // 0x358
	System.Void OnInit(); // 0x05e72000
	System.Void OnEnable(); // 0x05e7264c
	System.Void Refresh(); // 0x05e72750
	System.Void RenderApplicationPage(System.Int32 index, FairyGUI.GObject obj); // 0x05e72848
	System.Void OnClickReject(System.Int32 index, System.String roleId); // 0x05e72d28
	System.Void OnClickAccept(System.Int32 index, System.String roleId, System.String roleName); // 0x05e72f34
	System.Void OnRejectAll(); // 0x05e73168
	System.Void CloseBack(); // 0x05e73260
	static System.Void OpenWindow(); // 0x05e732cc
	System.Void .ctor(); // 0x05e73390
	System.Void <OnEnable>b__7_0(); // 0x05e73424
	System.Void <OnRejectAll>b__12_0(); // 0x05e734e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionApplicationPopUp.<>c__DisplayClass10_0 : System.Object
{
	System.String roleId; // 0x10
	WizardGames.Soc.SocClient.Ui.UiUnionApplicationPopUp <>4__this; // 0x18
	System.Void .ctor(); // 0x05e72ecc
	System.Void <OnClickReject>b__0(); // 0x05e735a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionApplicationPopUp.<>c__DisplayClass11_0 : System.Object
{
	System.String roleName; // 0x10
	System.String roleId; // 0x18
	WizardGames.Soc.SocClient.Ui.UiUnionApplicationPopUp <>4__this; // 0x20
	System.Void .ctor(); // 0x05e73100
	System.Void <OnClickAccept>b__0(); // 0x05e736c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionApplicationPopUp.<>c__DisplayClass9_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiUnionApplicationPopUp <>4__this; // 0x10
	System.Int32 index; // 0x18
	WizardGames.Soc.SocClient.Ui.ApplicatonPlayerInfo applicaitonInfo; // 0x20
	System.Void .ctor(); // 0x05e72cc0
	System.Void <RenderApplicationPage>b__0(); // 0x05e738f4
	System.Void <RenderApplicationPage>b__1(); // 0x05e73968
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionBadgeSetting : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.RootCreateUnionBinder rootBinder; // 0x340
	FairyGUI.Controller pageControl; // 0x348
	WizardGames.Soc.SocClient.Ui.UiUnionBadgeFlag badgeFlag; // 0x350
	static System.Void OpenWindow(); // 0x05e739dc
	System.Void OnDestroy(); // 0x05e73aa0
	System.Void OnEnable(); // 0x05e73b08
	System.Void OnDisable(); // 0x05e73e4c
	System.Void OnInit(); // 0x05e73f7c
	System.Boolean IsDefaultValue(); // 0x05e74718
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05e74844
	System.Void InitModal(); // 0x05e74120
	System.Void InitFlagData(); // 0x05e74d1c
	System.Void InitBadgeSetting(); // 0x05e74310
	System.Void InitIconList(); // 0x05e745a0
	System.Void IconListClear(); // 0x05e73ebc
	System.Void IconListReload(); // 0x05e73c4c
	System.Void .ctor(); // 0x05e74e20
	System.Void <>n__0(FairyGUI.EventContext context); // 0x05e74eac
	System.Void <InitModal>b__11_0(); // 0x05e74f2c
	System.Void <InitBadgeSetting>b__13_0(System.Collections.Generic.List<System.Int32> values); // 0x05e74fa0
	System.Void <InitBadgeSetting>b__13_1(System.Collections.Generic.List<System.Int32> values); // 0x05e752a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionBadgeSetting.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiUnionBadgeSetting.<>c <>9; // 0x0
	static FairyGUI.ListItemRenderer <>9__14_0; // 0x8
	static System.Void .cctor(); // 0x05e753ac
	System.Void .ctor(); // 0x05e75410
	System.Void <InitIconList>b__14_0(System.Int32 index, FairyGUI.GObject obj); // 0x05e75478
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionBadgeSetting.<>c__DisplayClass10_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiUnionBadgeSetting <>4__this; // 0x10
	FairyGUI.EventContext context; // 0x18
	System.Void .ctor(); // 0x05e74cb4
	System.Void <OnEscClose>b__0(); // 0x05e7551c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionBadgeSetting.<>c__DisplayClass13_0 : System.Object
{
	System.Collections.Generic.List<System.Int32> values; // 0x10
	WizardGames.Soc.SocClient.Ui.UiUnionBadgeSetting <>4__this; // 0x18
	System.Void .ctor(); // 0x05e7523c
	System.Void <InitBadgeSetting>b__2(SimpleJSON.JSONNode info); // 0x05e75598
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionChangeAnnouncement : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComGongGaoRootBinder rootBinder; // 0x338
	WizardGames.Soc.SocClient.Ui.UnionInfo unionInfo; // 0x340
	System.Int32 cdEndTime; // 0x348
	FairyGUI.GTextInput txtInput; // 0x350
	FairyGUI.GTextField txtCount; // 0x358
	System.Int32 ruleTipId; // 0x360
	System.Boolean isHireAnnouncement; // 0x364
	System.Void OnEnable(); // 0x05e75764
	System.Void OnDisable(); // 0x05e757cc
	System.Void OnDestroy(); // 0x05e75834
	static System.Void OpenWindow(System.Boolean type); // 0x05e7589c
	System.Void OnInit(); // 0x05e75a58
	System.Void UpdatePromptAndTips(); // 0x05e75d34
	System.Void InitModalBtnInfos(); // 0x05e75f08
	System.Void UpdateModalTitle(); // 0x05e763fc
	System.Void OnCancelClick(); // 0x05e76550
	System.Void OnConfirmClick(); // 0x05e76adc
	System.Void SetData(System.Boolean type); // 0x05e76efc
	System.Void OnChanged(); // 0x05e77430
	System.Boolean IsCDCompleted(); // 0x05e76a44
	System.Void UpdateCdStatus(); // 0x05e77234
	System.Void .ctor(); // 0x05e77684
	System.Void <InitModalBtnInfos>b__13_0(); // 0x05e77718
	System.Void <InitModalBtnInfos>b__13_1(); // 0x05e7777c
	System.Void <InitModalBtnInfos>b__13_2(); // 0x05e777e0
	System.Void <OnCancelClick>b__15_0(); // 0x05e77844
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionChangeAnnouncement.<>c__DisplayClass10_0 : System.Object
{
	System.Boolean type; // 0x10
	System.Void .ctor(); // 0x05e759f0
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiUnionChangeAnnouncement win); // 0x05e778b0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionChangeAnnouncement.<>c__DisplayClass16_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiUnionChangeAnnouncement <>4__this; // 0x10
	System.String value; // 0x18
	System.Void .ctor(); // 0x05e76e94
	System.Void <OnConfirmClick>b__0(SimpleJSON.JSONNode info); // 0x05e77934
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionChangeName : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonChangeName.RootChangeNameBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x340
	WizardGames.Soc.SocClient.Ui.UnionInfo unionInfo; // 0x348
	WizardGames.Soc.SocClient.Ui.ComInputBox comInput; // 0x350
	System.Int32 ruleTipId; // 0x358
	System.Void OnEnable(); // 0x05e77b18
	System.Void OnDisable(); // 0x05e77b80
	System.Void OnDestroy(); // 0x05e77be8
	static System.Void OpenWindow(); // 0x05e77c50
	System.Void OnInit(); // 0x05e77ddc
	System.DateTime ConvertTimestampToDate(System.Int64 timeStamp); // 0x05e78bf4
	System.Void InitModalBtnInfos(); // 0x05e781c8
	System.Void InitText(); // 0x05e784c8
	System.Void OnConfirmClick(); // 0x05e78cf4
	System.Void SetData(); // 0x05e792ac
	System.Void UpdateCostTip(); // 0x05e794e0
	System.Void UpdateCdTip(); // 0x05e7996c
	System.Void UpdateStatus(); // 0x05e79c00
	System.Void InputNameFocusIn(FairyGUI.EventContext ctx); // 0x05e7a248
	System.Void OnInputNameChanged(); // 0x05e7a4b8
	System.Boolean CheckChangeNameCost(); // 0x05e7a028
	System.Int32 GetCostOwnedNum(System.Int32 id); // 0x05e7a8e4
	System.Void .ctor(); // 0x05e7aa64
	System.Void <InitModalBtnInfos>b__11_0(); // 0x05e7aaf8
	System.Void <InitModalBtnInfos>b__11_1(); // 0x05e7ab6c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionChangeName.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiUnionChangeName.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.UiUnionChangeName> <>9__8_0; // 0x8
	static System.Action <>9__18_0; // 0x10
	static System.Void .cctor(); // 0x05e7abd0
	System.Void .ctor(); // 0x05e7ac34
	System.Void <OpenWindow>b__8_0(WizardGames.Soc.SocClient.Ui.UiUnionChangeName win); // 0x05e7ac9c
	System.Void <InputNameFocusIn>b__18_0(); // 0x05e7ad1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionChangeName.<>c__DisplayClass13_0 : System.Object
{
	System.String name; // 0x10
	WizardGames.Soc.SocClient.Ui.UiUnionChangeName <>4__this; // 0x18
	System.Action<SimpleJSON.JSONNode> <>9__1; // 0x20
	System.Void .ctor(); // 0x05e79244
	System.Void <OnConfirmClick>b__0(); // 0x05e7ad7c
	System.Void <OnConfirmClick>b__1(SimpleJSON.JSONNode info); // 0x05e7af18
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionChangeName.<>c__DisplayClass18_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiUnionChangeName <>4__this; // 0x10
	System.String cacheName; // 0x18
	System.Void .ctor(); // 0x05e7a450
	System.Void <InputNameFocusIn>b__1(); // 0x05e7b128
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionCreate : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.RootCreateUnionBinder rootBinder; // 0x340
	WizardGames.Soc.SocClient.Ui.UnionComOptionaMode comOptional; // 0x348
	WizardGames.Soc.SocClient.Ui.ComInputBox inputName; // 0x350
	FairyGUI.GTextInput inputAnnouncement; // 0x358
	WizardGames.Soc.SocClient.Ui.ComStateBtn btnSubmit; // 0x360
	FairyGUI.Controller pageControl; // 0x368
	WizardGames.Soc.SocClient.Ui.UiUnionBadgeFlag badgeFlag; // 0x370
	WizardGames.Soc.SocClient.Ui.UiUnionBadgeFlag badgeSetting; // 0x378
	System.String defName; // 0x380
	System.String defAnnouncement; // 0x388
	System.Int32 tipName; // 0x390
	System.Int32 tipAnnouncement; // 0x394
	static System.Void OpenWindow(); // 0x05e7b208
	System.Void OnDestroy(); // 0x05e7b2cc
	System.Void OnEnable(); // 0x05e7b334
	System.Void OnDisable(); // 0x05e7bc14
	System.Void OnInit(); // 0x05e7be24
	System.Boolean IsDefaultValue(); // 0x05e7d5b4
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05e7d69c
	System.Void InitModal(); // 0x05e7c558
	System.Void SetModelClose(); // 0x05e7db74
	System.Void InitName(); // 0x05e7c9c4
	System.Void InitAnnouncement(); // 0x05e7cd4c
	System.Void InitConsume(); // 0x05e7cbf8
	System.Void UpdateConsume(); // 0x05e7bb14
	System.Void ClearConsume(); // 0x05e7bca4
	System.Void InitBadgeShow(); // 0x05e7cfcc
	System.Void InitBadgeSetting(); // 0x05e7d1b4
	System.Void InitIconList(); // 0x05e7d43c
	System.Void IconListClear(); // 0x05e7bd64
	System.Void IconListReload(); // 0x05e7ba10
	System.Void InitBtnSubmit(); // 0x05e7c744
	System.Void UpdateSubmit(); // 0x05e7dc30
	System.Void OnSubmit(); // 0x05e7de18
	System.Void RenderConsumeItem(System.Int32 index, FairyGUI.GObject obj); // 0x05e7e22c
	System.Void OnInputNameChanged(); // 0x05e7e64c
	System.Void OnAnnouncementChanged(); // 0x05e7b648
	System.Void .ctor(); // 0x05e7e88c
	System.Void <>n__0(FairyGUI.EventContext context); // 0x05e7e954
	System.Void <SetModelClose>b__21_0(); // 0x05e7e9d4
	System.Void <InitBadgeShow>b__27_0(); // 0x05e7ea48
	System.Void <InitBadgeShow>b__27_1(); // 0x05e7eb20
	System.Void <InitBadgeSetting>b__28_0(System.Collections.Generic.List<System.Int32> values); // 0x05e7eb9c
	System.Void <InitBadgeSetting>b__28_1(System.Collections.Generic.List<System.Int32> values); // 0x05e7ec7c
	System.Void <InitBtnSubmit>b__32_0(FairyGUI.EventContext ctx); // 0x05e7ed8c
	System.Void <OnSubmit>b__34_0(SimpleJSON.JSONNode info); // 0x05e7ee04
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionCreate.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiUnionCreate.<>c <>9; // 0x0
	static FairyGUI.ListItemRenderer <>9__29_0; // 0x8
	static System.Void .cctor(); // 0x05e7efd0
	System.Void .ctor(); // 0x05e7f034
	System.Void <InitIconList>b__29_0(System.Int32 index, FairyGUI.GObject obj); // 0x05e7f09c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionCreate.<>c__DisplayClass19_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiUnionCreate <>4__this; // 0x10
	FairyGUI.EventContext context; // 0x18
	System.Void .ctor(); // 0x05e7db0c
	System.Void <OnEscClose>b__0(); // 0x05e7f140
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionCurrentWeekRankPage : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.RootUnionContent_RankingList_ActivityBinder rootBinder; // 0x338
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.UnionRankData> curRankDataLst; // 0x340
	WizardGames.Soc.SocClient.Manager.UnionRankData curSelectData; // 0x348
	FairyGUI.Controller presidentCardLabelCtrl; // 0x350
	FairyGUI.GTextField presidentCardLabelText; // 0x358
	FairyGUI.GLoader cardLoader; // 0x360
	WizardGames.Soc.SocClient.Ui.ComNameMedal comNameMedal; // 0x368
	System.UInt64 finalStartNum; // 0x370
	WizardGames.Soc.SocClient.Ui.ComUiPlayerModel model; // 0x378
	Config.LobbyRoleInfo info; // 0x380
	WizardGames.Soc.SocClient.Ui.PlayerAppearanceInfo avatorInfo; // 0x388
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> <AllCostumePlan>k__BackingField; // 0x390
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> <AllEquipPlan>k__BackingField; // 0x398
	WizardGames.Soc.SocClient.Ui.ComUiPlayerModel get_uiPlayerModel(); // 0x05e7f1b0
	System.Void .ctor(FairyGUI.GComponent root); // 0x05e7f33c
	System.Void OnInit(); // 0x05e7f834
	System.Void OnEnable(); // 0x05e8007c
	System.Void OnDisable(); // 0x05e80e48
	System.Void RefreshRank(); // 0x05e80d4c
	System.Void RefreshRankList(); // 0x05e80fdc
	System.Void RefreshMyRank(); // 0x05e8038c
	System.Void OnDestroy(); // 0x05e810f8
	System.Void InitRankList(); // 0x05e7fe34
	System.Void OnClickRankItem(FairyGUI.EventContext context); // 0x05e81174
	System.Void OnRenderRankItem(System.Int32 index, FairyGUI.GObject obj); // 0x05e8136c
	System.Void OnPullUpToRefresh(); // 0x05e81ef8
	System.Void set_AllCostumePlan(System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> value); // 0x05e82030
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> get_AllCostumePlan(); // 0x05e820b0
	System.Void set_AllEquipPlan(System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> value); // 0x05e82114
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> get_AllEquipPlan(); // 0x05e82194
	System.Void PlayerShow(); // 0x05e80db8
	System.Void PlayerDestroy(); // 0x05e80f54
	System.Void RefreshRoleAvator(); // 0x05e821f8
	System.Void GetPlayerAllCustomPlan(System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> AllCostumePlan, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> AllEquipPlan); // 0x05e82aac
	System.Void RefreshCostumPlan(); // 0x05e82380
	System.Void SetAvatorInfo(System.Boolean isSelf, System.Int32 sex); // 0x05e82bdc
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> GetUsePlanData(System.Int32 planId, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> dic); // 0x05e82d84
	System.Int32 GetPlanSex(System.Int32 curChosePlanId); // 0x05e82ebc
	System.Int32 GetPlanSexByDic(System.Collections.Generic.Dictionary<System.Int32,System.Int32> dic); // 0x05e82fc0
	System.Void <OnInit>b__12_0(); // 0x05e83210
	System.Void <OnEnable>b__13_0(); // 0x05e8335c
	System.Void <RefreshMyRank>b__17_0(WizardGames.Soc.SocClient.Ui.UnionInfo info); // 0x05e83434
	System.Void <RefreshRoleAvator>b__35_0(WizardGames.Soc.SocClient.RoleInfo roleInfo); // 0x05e83eec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionCurrentWeekRankPage.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiUnionCurrentWeekRankPage.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.ComUiPlayerModel> <>9__10_0; // 0x8
	static System.Void .cctor(); // 0x05e8400c
	System.Void .ctor(); // 0x05e84070
	System.Void <get_uiPlayerModel>b__10_0(WizardGames.Soc.SocClient.Ui.ComUiPlayerModel model); // 0x05e840d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionGrowthRewardPage : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.RootUnionContent_Award_UnionGrowthPageBinder rootBinder; // 0x338
	WizardGames.Soc.SocClient.Ui.UnionInfo myUnion; // 0x340
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.UnionGrowthRewardData> curRewardDataLst; // 0x348
	System.Void .ctor(FairyGUI.GComponent root); // 0x05e84174
	System.Void OnInit(); // 0x05e842b0
	System.Void OnEnable(); // 0x05e8447c
	System.Void OnDisable(); // 0x05e845d0
	System.Void OnDestroy(); // 0x05e84638
	System.Void RefreshUnionInfo(); // 0x05e846b4
	System.Void RefreshReward(); // 0x05e85028
	System.Void InitRewardList(); // 0x05e84360
	System.Void OnRenderRewardItem(System.Int32 index, FairyGUI.GObject obj); // 0x05e850fc
	System.Int32 GetPreTotalExp(System.Int32 level); // 0x05e84e14
	System.Void <OnEnable>b__5_0(WizardGames.Soc.SocClient.Ui.UnionInfo info); // 0x05e85c54
	System.Void <RefreshUnionInfo>b__8_0(); // 0x05e85ce4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionGrowthRewardPage.<>c__DisplayClass11_0 : System.Object
{
	FairyGUI.GObject obj; // 0x10
	WizardGames.Soc.SocClient.Manager.UnionGrowthRewardData data; // 0x18
	System.Void .ctor(); // 0x05e85bec
	System.Void <OnRenderRewardItem>b__0(); // 0x05e85de0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionHomePage : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	SocLogger logger; // 0x338
	WizardGames.Soc.SocClient.Ui.UnionInfo unionInfo; // 0x340
	WizardGames.Soc.SocClient.Ui.UnionBadge unionBadge; // 0x348
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.RootUnionContent_HomePageBinder rootBinder; // 0x350
	System.Boolean groupEnable; // 0x358
	System.Boolean isWechat; // 0x359
	System.Boolean isQQ; // 0x35a
	System.String platformName; // 0x360
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> errorCodeDic; // 0x368
	WizardGames.Soc.SocClient.Ui.ComUiPlayerModel model; // 0x370
	System.Boolean isSelf; // 0x378
	Config.LobbyRoleInfo presidentInfo; // 0x380
	WizardGames.Soc.SocClient.Ui.PlayerAppearanceInfo avatorInfo; // 0x388
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> <AllCostumePlan>k__BackingField; // 0x390
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> <AllEquipPlan>k__BackingField; // 0x398
	System.Void .ctor(FairyGUI.GComponent root); // 0x05e85e5c
	System.Void OnEnable(); // 0x05e86184
	System.Void OnDisable(); // 0x05e86498
	System.Void OnFocusChanged(System.Boolean hasFocus); // 0x05e86740
	System.Void OnDestroy(); // 0x05e87034
	WizardGames.Soc.SocClient.Ui.ComUiPlayerModel get_uiPlayerModel(); // 0x05e870b0
	System.Void OnInit(); // 0x05e8723c
	System.Void UpdateInfo(); // 0x05e87d2c
	System.Void UpdateBaseInfo(); // 0x05e87eb0
	System.Void UpdateLevelBar(); // 0x05e88c34
	System.Void UpdateAnnouncement(); // 0x05e88690
	System.Void OnBtnCopyNameClick(FairyGUI.EventContext ctx); // 0x05e897dc
	System.Void OnBtnCopyCodeClick(FairyGUI.EventContext ctx); // 0x05e89958
	System.Void OnBtnShareClick(FairyGUI.EventContext ctx); // 0x05e89ae8
	System.Void OnBtnLogClick(FairyGUI.EventContext ctx); // 0x05e89c0c
	System.Void InitGroup(); // 0x05e879a8
	System.Void OnBtnSocialClick(FairyGUI.EventContext ctx); // 0x05e89ca8
	System.Void UpdateGroup(); // 0x05e86b0c
	System.Void UpdateGroupState(); // 0x055049cc
	System.Void GetGroupRelation(); // 0x05e8ad64
	System.Void GroupCreate(); // 0x05e8a618
	System.Void ShowGroupErrorTip(System.Int32 errorCode, System.Int32 thirdCode); // 0x05e8aefc
	System.Void GroupRemind(); // 0x05e8a9b4
	System.Void GroupUnbind(); // 0x05e89ee0
	System.Void GroupJoin(); // 0x05e8a274
	System.Void set_AllCostumePlan(System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> value); // 0x05e8b0dc
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> get_AllCostumePlan(); // 0x05e8b15c
	System.Void set_AllEquipPlan(System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> value); // 0x05e8b1c0
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> get_AllEquipPlan(); // 0x05e8b240
	System.Void PlayerShow(); // 0x05e89638
	System.Void PlayerDestroy(); // 0x05e866b8
	System.Void RefreshRoleAvator(); // 0x05e8b2a4
	System.Void GetPlayerAllCustomPlan(System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> AllCostumePlan, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> AllEquipPlan); // 0x05e8ba3c
	System.Void RefreshCostumPlan(); // 0x05e8b458
	System.Void SetAvatorInfo(System.Boolean isSelf, System.Int32 sex); // 0x05e8bb6c
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> GetUsePlanData(System.Int32 planId, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> dic); // 0x05e8bd14
	System.Int32 GetPlanSex(System.Int32 curChosePlanId); // 0x05e8be4c
	System.Int32 GetPlanSexByDic(System.Collections.Generic.Dictionary<System.Int32,System.Int32> dic); // 0x05e8bf50
	System.Void InitLeaderIdCard(); // 0x05e87c10
	System.Void UpdateLeaderIdCard(); // 0x05e88fa0
	System.Void <OnEnable>b__10_0(WizardGames.Soc.SocClient.Ui.UnionInfo info); // 0x05e8c1a0
	System.Void <UpdateGroupState>b__29_0(WizardGames.Soc.SDK.SDKGroupRet result, System.Int32 errorCode); // 0x05e8c218
	System.Void <GetGroupRelation>b__30_0(WizardGames.Soc.SDK.SDKGroupRet result, System.Int32 errorCode); // 0x05e8c32c
	System.Void <GroupCreate>b__31_0(WizardGames.Soc.SDK.SDKGroupRet result, System.Int32 errorCode); // 0x05e8c3fc
	System.Void <GroupRemind>b__33_0(WizardGames.Soc.SDK.SDKGroupRet result, System.Int32 errorCode); // 0x05e8c4e4
	System.Void <GroupUnbind>b__34_0(WizardGames.Soc.SDK.SDKGroupRet result, System.Int32 errorCode); // 0x05e8c574
	System.Void <GroupJoin>b__35_0(WizardGames.Soc.SDK.SDKGroupRet result, System.Int32 errorCode); // 0x05e8c65c
	System.Void <RefreshRoleAvator>b__49_0(WizardGames.Soc.SocClient.RoleInfo roleInfo); // 0x05e8c6fc
	System.Void <InitLeaderIdCard>b__56_0(); // 0x05e8c81c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionHomePage.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiUnionHomePage.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.ComUiPlayerModel> <>9__16_0; // 0x8
	static System.Void .cctor(); // 0x05e8c8f4
	System.Void .ctor(); // 0x05e8c958
	System.Void <get_uiPlayerModel>b__16_0(WizardGames.Soc.SocClient.Ui.ComUiPlayerModel model); // 0x05e8c9c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionHomePage.<>c__DisplayClass21_0 : System.Object
{
	System.Boolean permission; // 0x10
	System.Void .ctor(); // 0x05e8ca5c
	System.Void <UpdateAnnouncement>b__0(FairyGUI.EventContext ctx); // 0x05e8cac4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionHomePage.<>c__DisplayClass57_0 : System.Object
{
	FairyGUI.GLoader cardLoader; // 0x10
	WizardGames.Soc.SocClient.Ui.ComNameMedal comNameMedal; // 0x18
	System.Void .ctor(); // 0x05e8cb58
	System.Void <UpdateLeaderIdCard>b__0(WizardGames.Soc.SocClient.RoleInfo info); // 0x05e8cbc0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionInvitation : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.RootUnionInvitationBinder rootBinder; // 0x338
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UnionInvitation> listData; // 0x340
	System.Single lastClickTime; // 0x348
	System.Void OnEnable(); // 0x05e8ccd4
	System.Void OnDisable(); // 0x05e8ce8c
	System.Void CloseBack(); // 0x05e8cef4
	static System.Void OpenWindow(); // 0x05e8cf60
	System.Void OnInit(); // 0x05e8d024
	System.Void InitModal(); // 0x05e8d124
	System.Void InitList(); // 0x05e8d4c0
	System.Void Reload(); // 0x05e8cd44
	System.Void ListUpdate(); // 0x05e8d62c
	System.Void ItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x05e8d884
	System.Void OnClickBtnNo(WizardGames.Soc.SocClient.Ui.UnionInvitation info); // 0x05e8e51c
	System.Void OnClickBtnOk(WizardGames.Soc.SocClient.Ui.UnionInvitation info); // 0x05e8e804
	System.Void OnClickRejectAll(); // 0x05e8eb90
	System.Void .ctor(); // 0x05e8ec88
	System.Void <InitModal>b__9_0(); // 0x05e8ed68
	System.Void <Reload>b__11_0(SimpleJSON.JSONArray info); // 0x05e8edcc
	System.Void <OnClickRejectAll>b__16_0(); // 0x05e8ef80
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionInvitation.<>c__DisplayClass13_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiUnionInvitation <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.UnionInvitation data; // 0x18
	System.Void .ctor(); // 0x05e8e4b4
	System.Void <ItemRender>b__0(FairyGUI.EventContext ctx); // 0x05e8efe4
	System.Void <ItemRender>b__1(FairyGUI.EventContext ctx); // 0x05e8f068
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionInvitation.<>c__DisplayClass14_0 : System.Object
{
	System.UInt64 communityId; // 0x10
	WizardGames.Soc.SocClient.Ui.UiUnionInvitation <>4__this; // 0x18
	System.Void .ctor(); // 0x05e8e79c
	System.Void <OnClickBtnNo>b__0(); // 0x05e8f0ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionInvitation.<>c__DisplayClass15_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiUnionInvitation <>4__this; // 0x10
	System.String communityName; // 0x18
	System.Action<WizardGames.Soc.SocClient.Ui.UnionInfo> <>9__1; // 0x20
	System.Void .ctor(); // 0x05e8eb28
	System.Void <OnClickBtnOk>b__0(); // 0x055049cc
	System.Void <OnClickBtnOk>b__1(WizardGames.Soc.SocClient.Ui.UnionInfo info); // 0x05e8f2ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionLastWeekRankPage : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.RootUnionContent_RankingList_ActivityBinder rootBinder; // 0x338
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.UnionRankData> curRankDataLst; // 0x340
	WizardGames.Soc.SocClient.Manager.UnionRankData curSelectData; // 0x348
	FairyGUI.Controller presidentCardLabelCtrl; // 0x350
	FairyGUI.GTextField presidentCardLabelText; // 0x358
	FairyGUI.GLoader cardLoader; // 0x360
	WizardGames.Soc.SocClient.Ui.ComNameMedal comNameMedal; // 0x368
	System.UInt64 finalStartNum; // 0x370
	WizardGames.Soc.SocClient.Ui.ComUiPlayerModel model; // 0x378
	Config.LobbyRoleInfo info; // 0x380
	WizardGames.Soc.SocClient.Ui.PlayerAppearanceInfo avatorInfo; // 0x388
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> <AllCostumePlan>k__BackingField; // 0x390
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> <AllEquipPlan>k__BackingField; // 0x398
	WizardGames.Soc.SocClient.Ui.ComUiPlayerModel get_uiPlayerModel(); // 0x05e8f548
	System.Void .ctor(FairyGUI.GComponent root); // 0x05e8f6d4
	System.Void OnInit(); // 0x05e8fbcc
	System.Void OnEnable(); // 0x05e90414
	System.Void OnDisable(); // 0x05e91b54
	System.Void RefreshRank(); // 0x05e91a58
	System.Void RefreshRankList(); // 0x05e91ce8
	System.Void RefreshMyRank(); // 0x05e90724
	System.Void OnDestroy(); // 0x05e91e04
	System.Void InitRankList(); // 0x05e901cc
	System.Void OnClickRankItem(FairyGUI.EventContext context); // 0x05e91e80
	System.Void OnRenderRankItem(System.Int32 index, FairyGUI.GObject obj); // 0x05e92078
	System.Void OnPullUpToRefresh(); // 0x05e92c0c
	System.Void set_AllCostumePlan(System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> value); // 0x05e92d44
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> get_AllCostumePlan(); // 0x05e92dc4
	System.Void set_AllEquipPlan(System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> value); // 0x05e92e28
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> get_AllEquipPlan(); // 0x05e92ea8
	System.Void PlayerShow(); // 0x05e91ac4
	System.Void PlayerDestroy(); // 0x05e91c60
	System.Void RefreshRoleAvator(); // 0x05e92f0c
	System.Void GetPlayerAllCustomPlan(System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> AllCostumePlan, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> AllEquipPlan); // 0x05e937d8
	System.Void RefreshCostumPlan(); // 0x05e93094
	System.Void SetAvatorInfo(System.Boolean isSelf, System.Int32 sex); // 0x05e93908
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> GetUsePlanData(System.Int32 planId, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.Dictionary<System.Int32,System.Int32>> dic); // 0x05e93ab0
	System.Int32 GetPlanSex(System.Int32 curChosePlanId); // 0x05e93be8
	System.Int32 GetPlanSexByDic(System.Collections.Generic.Dictionary<System.Int32,System.Int32> dic); // 0x05e93cec
	System.Void <OnInit>b__12_0(); // 0x05e93f3c
	System.Void <OnEnable>b__13_0(); // 0x05e94088
	System.Void <RefreshMyRank>b__17_0(WizardGames.Soc.SocClient.Ui.UnionInfo info); // 0x05e94160
	System.Void <RefreshRoleAvator>b__35_0(WizardGames.Soc.SocClient.RoleInfo roleInfo); // 0x05e94480
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionLastWeekRankPage.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiUnionLastWeekRankPage.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.ComUiPlayerModel> <>9__10_0; // 0x8
	static System.Void .cctor(); // 0x05e945a0
	System.Void .ctor(); // 0x05e94604
	System.Void <get_uiPlayerModel>b__10_0(WizardGames.Soc.SocClient.Ui.ComUiPlayerModel model); // 0x05e9466c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionLog : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComLogPopupBinder rootBinder; // 0x338
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UnionLogInfo> logsList; // 0x340
	System.Collections.Generic.Dictionary<System.String,System.String> _playerNameCache; // 0x348
	System.Threading.CancellationTokenSource _cancellationTokenSource; // 0x350
	System.Boolean _isDataLoading; // 0x358
	System.Boolean _disposed; // 0x359
	static SocLogger log; // 0x0
	System.Void OnEnable(); // 0x05e94708
	System.Void OnDisable(); // 0x05e94990
	System.Void Dispose(); // 0x05e94a28
	System.Void Cleanup(); // 0x05e94ab4
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05e94c04
	static System.Void OpenWindow(); // 0x05e94c84
	System.Void OnInit(); // 0x05e94d48
	System.Void InitModal(); // 0x05e94e48
	System.Void InitList(); // 0x05e94fe4
	System.Void UpdateList(); // 0x05e947b0
	System.Void PreloadPlayerNames(); // 0x05e95208
	System.String[] ExtractPlayerIdsFromEventData(System.String eventData, System.String eventId); // 0x05e95630
	System.Void OnItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x05e958b0
	System.Void OnEventRender(System.Int32 index, FairyGUI.GObject obj, WizardGames.Soc.SocClient.Ui.UnionLogInfo logInfo); // 0x05e95cd0
	System.Void SetupEventItem(WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComLogListItemBBinder item, WizardGames.Soc.SocClient.Ui.UnionLogInfo logInfo, System.String eventData, System.String eventId, System.String time); // 0x05e95fa8
	System.Void SetEventText(WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComLogListItemBBinder item, System.String eventId); // 0x05e96144
	System.Void HandleUpgradeEvent(WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComLogListItemBBinder item, System.String eventData); // 0x05e96574
	System.Void HandlePlayerEvent(WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComLogListItemBBinder item, System.String eventId, System.String eventData); // 0x05e96804
	System.Void SetupPlayerButtons(WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComLogListItemBBinder item, System.String[] playerIds); // 0x05e96940
	System.Void UpdatePlayerNames(WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComLogListItemBBinder item, System.String[] playerIds); // 0x05e96da8
	System.Void .ctor(); // 0x05e97020
	static System.Void .cctor(); // 0x05e970f8
	System.Void <InitModal>b__20_0(); // 0x05e971cc
	System.Void <PreloadPlayerNames>b__23_0(SimpleJSON.JSONArray info); // 0x05e97240
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionLog.<>c__DisplayClass22_0 : System.Object
{
	System.Threading.CancellationToken cancellationToken; // 0x10
	WizardGames.Soc.SocClient.Ui.UiUnionLog <>4__this; // 0x18
	System.Void .ctor(); // 0x05e951a0
	System.Void <UpdateList>b__0(); // 0x05e97648
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionLog.<>c__DisplayClass25_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiUnionLog <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.UnionLogInfo logInfo; // 0x18
	System.Void .ctor(); // 0x05e95c68
	System.Void <OnItemRender>b__0(System.Int32 itemIndex, FairyGUI.GObject itemObj); // 0x05e97904
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionLog.<>c__DisplayClass31_0 : System.Object
{
	System.String[] playerIds; // 0x10
	System.Void .ctor(); // 0x05e96f50
	System.Void <SetupPlayerButtons>b__0(); // 0x05e979b4
	System.Void <SetupPlayerButtons>b__1(); // 0x05e97a98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionLog.<>c__DisplayClass31_1 : System.Object
{
	System.String playerId; // 0x10
	System.Void .ctor(); // 0x05e96fb8
	System.Void <SetupPlayerButtons>b__2(); // 0x05e97b78
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionMain : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.SocClient.Ui.IJumpToUIWindow
{
	WizardGames.Soc.SocClient.Ui.UiUnionMain.EViewTabType curTab; // 0x338
	System.Int32 curSecTab; // 0x33c
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x340
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x348
	FairyGUI.GLoader pageLoader; // 0x350
	FairyGUI.Controller pageControl; // 0x358
	WizardGames.Soc.Common.Unity.Ui.WindowComBase currentPage; // 0x360
	FairyGUI.GLoader bg; // 0x368
	System.Void OnDestroy(); // 0x05e97c40
	System.Void OnEnable(); // 0x05e97cc0
	System.Void OnDisable(); // 0x05e98168
	System.Void OnUnionLeave(); // 0x05e982dc
	System.Void OnInit(); // 0x05e98350
	System.Void InitTopBar(); // 0x05e9855c
	System.Void InitNavBar(); // 0x05e9878c
	System.Void OnBgHide(); // 0x05e98e70
	System.Void currentPageOnDestroy(); // 0x05e98f14
	System.Void InitHomePage(); // 0x05e98f9c
	System.Void InitSettingPage(); // 0x05e99164
	System.Void InitMemberPage(); // 0x05e993cc
	System.Void InitRewardPage(); // 0x05e99b10
	System.Void InitCurrentWeekRankPage(); // 0x05e99c80
	System.Void InitLastWeekRankPage(); // 0x05e99df0
	System.Void OnClickTab(WizardGames.Soc.SocClient.Ui.NavBarData data); // 0x05e99f5c
	System.Void ChangePage(System.Int32 index, System.Int32 subIdx); // 0x05e97fa8
	System.Void JumpToUIWindow(WizardGames.Soc.SocClient.Ui.JumpData jumpData); // 0x05e9a294
	static System.Void OpenWindow(); // 0x05e8f3dc
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05e9a308
	System.Void .ctor(); // 0x05e9a388
	System.Void <InitNavBar>b__17_0(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x05e9a41c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiUnionMain.EViewTabType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiUnionMain.EViewTabType MainPage = 0;
	static WizardGames.Soc.SocClient.Ui.UiUnionMain.EViewTabType Setting = 1;
	static WizardGames.Soc.SocClient.Ui.UiUnionMain.EViewTabType Member = 2;
	static WizardGames.Soc.SocClient.Ui.UiUnionMain.EViewTabType Reward = 3;
	static WizardGames.Soc.SocClient.Ui.UiUnionMain.EViewTabType Rank = 6;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionMemberPage : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	System.Collections.Generic.List<System.Int32> MemberValues; // 0x338
	System.Collections.Generic.List<System.Int32> ContributionValues; // 0x340
	System.Collections.Generic.List<System.String> MemberOptions; // 0x348
	System.Collections.Generic.List<System.String> ContributionOptions; // 0x350
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.RootUnionContent_MemberPageBinder MemberBinder; // 0x358
	WizardGames.Soc.SocClient.Ui.UnionInfo unionInfo; // 0x360
	FairyGUI.GList recommendedList; // 0x368
	WizardGames.Soc.SocClient.Ui.ComComboBox selectMember; // 0x370
	WizardGames.Soc.SocClient.Ui.ComComboBox selectContribution; // 0x378
	FairyGUI.GButton leaveBtn; // 0x380
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComUnionBottomBtnBinder content; // 0x388
	WizardGames.Soc.SocClient.Ui.UnionMember myMemberInfo; // 0x390
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ExtendedPresidentInfo> sourceData; // 0x398
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ExtendedPresidentInfo> orderData; // 0x3a0
	System.Int32 CurReviewValue; // 0x3a8
	System.Int32 CurContributionValue; // 0x3ac
	WizardGames.Soc.Common.Data.Play.OBJCommunityRule myRule; // 0x3b0
	System.Void .ctor(FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.UiUnionMain lobbyFriend); // 0x05e9953c
	System.Void OnEnable(); // 0x05e9a4a0
	System.Void OnDisable(); // 0x05e9a770
	System.Void OnDestroy(); // 0x05e9a8ac
	System.Void OnInit(); // 0x05e9a928
	System.Void InitSelectMember(); // 0x05e9b33c
	System.Void InitSelectContribution(); // 0x05e9b4f0
	System.Void MemberComBoxChange(System.Int32 index); // 0x05e9b6a4
	System.Void ContributionComBoxChange(System.Int32 index); // 0x05e9b7d0
	System.Void Reload(); // 0x05e9a628
	System.Void UpdateInfo(); // 0x05e9b8fc
	System.Void SortMemberDefault(); // 0x05e9c2a4
	System.Void SortMemberOnlineList(); // 0x05e9c9c4
	System.Void SortContributionList(); // 0x05e9c764
	System.Void LeaveUnion(); // 0x05e9cdd0
	System.Void SelectMember(); // 0x05e9b734
	System.Void SelectContribution(); // 0x05e9b860
	System.Int32 GetReviewValue(); // 0x05e9b204
	System.Int32 GetContributionValue(); // 0x05e9b2a0
	System.Void OnItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x05e9d2f8
	System.Void BuildMemberOperationList(WizardGames.Soc.SocClient.Ui.UnionMember myMemberInfo, WizardGames.Soc.SocClient.Ui.ExtendedPresidentInfo info, System.Collections.Generic.List<System.String> titles, System.Collections.Generic.List<System.Action> actions); // 0x05e9e0e8
	System.Void OnClickInvite(WizardGames.Soc.SocClient.Ui.ExtendedPresidentInfo friendInfo, FairyGUI.GButton btnInviteTeam); // 0x05e9f048
	System.Void AppointCommunityIdentity(WizardGames.Soc.SocClient.Ui.EUnionIdentityType identity, WizardGames.Soc.SocClient.Ui.EUnionOperationType operation, System.String roleid); // 0x05e9f1c8
	System.Void Transferpresident(System.String roleid); // 0x05e9f3d0
	System.Boolean IsLeader(); // 0x05e9c1e4
	System.Boolean IsAllowPositionAdjust(System.Int32 identity); // 0x05e9dc48
	System.Boolean IsAllowInviteMember(); // 0x05e9f588
	System.Boolean IsAllowKick(System.Int32 identity); // 0x05e9dd30
	System.Void ResetListItemState(WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComMemberListItemBinder com); // 0x05e9d9dc
	System.Void SetupMemberActions(WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComMemberListItemBinder com, WizardGames.Soc.SocClient.Ui.ExtendedPresidentInfo info, FairyGUI.GObject obj); // 0x05e9ddcc
	System.Void OnInviteMemberClick(); // 0x05e9f664
	System.Void <OnEnable>b__18_0(WizardGames.Soc.SocClient.Ui.UnionInfo info); // 0x05e9f7c8
	System.Void <OnInit>b__21_1(); // 0x05e9f840
	System.Void <Reload>b__26_0(SimpleJSON.JSONArray info); // 0x05e9f8a4
	System.Void <LeaveUnion>b__31_0(); // 0x05e9fa58
	System.Void <OnInviteMemberClick>b__47_0(System.Collections.Generic.List<System.String> roleIds, System.String teamChangeEntrance); // 0x05e9fc08
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionMemberPage.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiUnionMemberPage.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__21_0; // 0x8
	static System.Converter<System.Int32,System.String> <>9__22_0; // 0x10
	static System.Converter<System.Int32,System.String> <>9__23_0; // 0x18
	static System.Comparison<WizardGames.Soc.SocClient.Ui.ExtendedPresidentInfo> <>9__28_0; // 0x20
	static System.Comparison<WizardGames.Soc.SocClient.Ui.ExtendedPresidentInfo> <>9__28_1; // 0x28
	static System.Comparison<WizardGames.Soc.SocClient.Ui.ExtendedPresidentInfo> <>9__29_0; // 0x30
	static System.Comparison<WizardGames.Soc.SocClient.Ui.ExtendedPresidentInfo> <>9__29_1; // 0x38
	static System.Comparison<WizardGames.Soc.SocClient.Ui.ExtendedPresidentInfo> <>9__30_0; // 0x40
	static System.Action <>9__31_1; // 0x48
	static System.Action <>9__39_0; // 0x50
	static System.Void .cctor(); // 0x05e9fef4
	System.Void .ctor(); // 0x05e9ff58
	System.Void <OnInit>b__21_0(); // 0x05e9ffc0
	System.String <InitSelectMember>b__22_0(System.Int32 v); // 0x05ea0024
	System.String <InitSelectContribution>b__23_0(System.Int32 v); // 0x05ea00a8
	System.Int32 <SortMemberDefault>b__28_0(WizardGames.Soc.SocClient.Ui.ExtendedPresidentInfo x, WizardGames.Soc.SocClient.Ui.ExtendedPresidentInfo y); // 0x05ea012c
	System.Int32 <SortMemberDefault>b__28_1(WizardGames.Soc.SocClient.Ui.ExtendedPresidentInfo x, WizardGames.Soc.SocClient.Ui.ExtendedPresidentInfo y); // 0x05ea01c4
	System.Int32 <SortMemberOnlineList>b__29_0(WizardGames.Soc.SocClient.Ui.ExtendedPresidentInfo x, WizardGames.Soc.SocClient.Ui.ExtendedPresidentInfo y); // 0x05ea025c
	System.Int32 <SortMemberOnlineList>b__29_1(WizardGames.Soc.SocClient.Ui.ExtendedPresidentInfo x, WizardGames.Soc.SocClient.Ui.ExtendedPresidentInfo y); // 0x05ea02f4
	System.Int32 <SortContributionList>b__30_0(WizardGames.Soc.SocClient.Ui.ExtendedPresidentInfo x, WizardGames.Soc.SocClient.Ui.ExtendedPresidentInfo y); // 0x05ea038c
	System.Void <LeaveUnion>b__31_1(); // 0x05ea0420
	System.Void <AppointCommunityIdentity>b__39_0(); // 0x05ea0660
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionMemberPage.<>c__DisplayClass37_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiUnionMemberPage <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.ExtendedPresidentInfo info; // 0x18
	System.Action <>9__13; // 0x20
	System.Void .ctor(); // 0x05e9efe0
	System.Void <BuildMemberOperationList>b__0(); // 0x05ea0788
	System.Void <BuildMemberOperationList>b__1(); // 0x05ea0800
	System.Void <BuildMemberOperationList>b__2(); // 0x05ea0880
	System.Void <BuildMemberOperationList>b__3(); // 0x05ea0900
	System.Void <BuildMemberOperationList>b__4(); // 0x05ea0980
	System.Void <BuildMemberOperationList>b__5(); // 0x05ea0a00
	System.Void <BuildMemberOperationList>b__6(); // 0x05ea0a80
	System.Void <BuildMemberOperationList>b__7(); // 0x05ea0b00
	System.Void <BuildMemberOperationList>b__8(); // 0x05ea0b80
	System.Void <BuildMemberOperationList>b__9(); // 0x05ea0c00
	System.Void <BuildMemberOperationList>b__10(); // 0x05ea0c80
	System.Void <BuildMemberOperationList>b__11(); // 0x05ea0d00
	System.Void <BuildMemberOperationList>b__12(); // 0x05ea0d80
	System.Void <BuildMemberOperationList>b__13(); // 0x05ea0eb8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionMemberPage.<>c__DisplayClass40_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiUnionMemberPage <>4__this; // 0x10
	System.String roleid; // 0x18
	System.Void .ctor(); // 0x05e9f520
	System.Void <Transferpresident>b__0(); // 0x05ea0fd0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionMemberPage.<>c__DisplayClass46_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ExtendedPresidentInfo info; // 0x10
	WizardGames.Soc.SocClient.Ui.UiUnionMemberPage <>4__this; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.ComMemberListItemBinder com; // 0x20
	FairyGUI.GObject obj; // 0x28
	System.Action <>9__3; // 0x30
	System.Void .ctor(); // 0x05e9f5fc
	System.Void <SetupMemberActions>b__0(FairyGUI.EventContext ctx); // 0x05ea120c
	System.Void <SetupMemberActions>b__1(FairyGUI.EventContext ctx); // 0x05ea12e4
	System.Void <SetupMemberActions>b__2(); // 0x05ea14cc
	System.Void <SetupMemberActions>b__3(); // 0x05ea1778
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionRecommend : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.RootUnionRecommendBinder rootBinder; // 0x338
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UnionInfo> currList; // 0x340
	WizardGames.Soc.SocClient.Ui.UnionBaseInfoCard unionCard; // 0x348
	FairyGUI.Controller loadingController; // 0x350
	System.Boolean searchState; // 0x358
	System.Void OnEnable(); // 0x05ea1890
	System.Void OnDisable(); // 0x05ea20ac
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x05ea22b4
	static System.Void OpenWindow(); // 0x05ea04f4
	System.Void OnInit(); // 0x05ea2334
	System.Void InitTopBar(); // 0x05ea2464
	System.Void InitList(); // 0x05ea2fdc
	System.Void OnPullUpToRefresh(); // 0x05ea35c8
	System.Void ListItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x05ea3798
	System.Void ListItemOnClick(FairyGUI.EventContext ctx, WizardGames.Soc.SocClient.Ui.UnionInfo data); // 0x05ea3fb0
	System.Void ListRecommentUpdate(); // 0x05ea1ca0
	System.Void ListSearchUpdate(); // 0x05ea4294
	System.Void InitData(); // 0x05ea334c
	System.Void InitCreateBtn(); // 0x05ea2bb8
	System.Void UpdateCreateBtn(); // 0x05ea199c
	System.Void InitInvitationBtn(); // 0x05ea2d7c
	System.Void InitSearchForms(); // 0x05ea2610
	System.Void InitUnionCard(); // 0x05ea2a78
	System.Void OnClickSearch(System.String searchStr); // 0x05ea44a8
	System.Void InitBottomState(); // 0x05ea3444
	System.Void OnClickCreate(); // 0x05ea4614
	System.Void OnClickInvitation(); // 0x05ea47c0
	System.Void .ctor(); // 0x05ea4820
	System.Void <InitData>b__17_0(SimpleJSON.JSONNode info); // 0x05ea48f8
	System.Void <InitSearchForms>b__21_0(); // 0x05ea49bc
	System.Void <InitSearchForms>b__21_1(); // 0x05ea4a20
	System.Void <InitSearchForms>b__21_2(); // 0x05ea4a84
	System.Void <OnClickSearch>b__23_0(SimpleJSON.JSONNode info); // 0x05ea4ae8
	System.Void <OnClickSearch>b__23_1(); // 0x05ea4bac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionRecommend.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiUnionRecommend.<>c <>9; // 0x0
	static System.Action <>9__25_0; // 0x8
	static System.Void .cctor(); // 0x05ea4c5c
	System.Void .ctor(); // 0x05ea4cc0
	System.Void <OnClickCreate>b__25_0(); // 0x05ea4d28
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionRecommend.<>c__DisplayClass12_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiUnionRecommend <>4__this; // 0x10
	System.Int32 currLen; // 0x18
	System.Void .ctor(); // 0x05ea3730
	System.Void <OnPullUpToRefresh>b__0(SimpleJSON.JSONNode info); // 0x05ea4d8c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionRecommend.<>c__DisplayClass13_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiUnionRecommend <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.UnionInfo data; // 0x18
	System.Void .ctor(); // 0x05ea3f48
	System.Void <ListItemRender>b__0(FairyGUI.EventContext ctx); // 0x05ea4eac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionSettingPage : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.UnionInfo unionInfo; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.CommonUnion.RootUnionContent_Setting_CommonBinder rootBinder; // 0x340
	FairyGUI.GTextInput inputName; // 0x348
	FairyGUI.GTextInput inputAnnouncement; // 0x350
	FairyGUI.GTextField inputAnnouncementNum; // 0x358
	FairyGUI.GTextInput inputHireAnnouncement; // 0x360
	FairyGUI.GTextField inputHireAnnouncementNum; // 0x368
	WizardGames.Soc.SocClient.Ui.UnionComOptionaMode comOptional; // 0x370
	WizardGames.Soc.SocClient.Ui.UiUnionBadgeFlag badgeFlag; // 0x378
	System.Void .ctor(FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.UiUnionMain lobbyFriend); // 0x05e992d4
	System.Void OnEnable(); // 0x05ea4f34
	System.Void OnDisable(); // 0x05ea5154
	System.Void OnDestroy(); // 0x05ea5268
	System.Void OnInit(); // 0x05ea52e4
	System.Void UpdateInfo(); // 0x05ea65b4
	System.Void InitName(); // 0x05ea5370
	System.Void InitAnnouncement(); // 0x05ea582c
	System.Void InitHireAnnouncement(); // 0x05ea5c6c
	System.Void InitOptionalMode(); // 0x05ea60ac
	System.Void UpdateOptionalMode(); // 0x05ea6c18
	System.Void UpdateName(); // 0x05ea66dc
	System.Void UpdateAnnouncement(); // 0x05ea67c0
	System.Void UpdateHireAnnouncement(); // 0x05ea69ec
	System.String GetAnnouncementLength(System.String str, System.Int32 maxLen); // 0x05ea7070
	System.Void OnSaveLevelLimit(System.Int32 val); // 0x05ea7294
	System.Void OnSaveReview(System.Int32 val); // 0x05ea74bc
	System.Void InitBadgeFlag(); // 0x05ea6358
	System.Void UpdateBadge(); // 0x05ea6dc4
	System.Void UpdateCdStatus(); // 0x05ea76e4
	System.Void <OnEnable>b__10_0(WizardGames.Soc.SocClient.Ui.UnionInfo info); // 0x05ea7870
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionSettingPage.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiUnionSettingPage.<>c <>9; // 0x0
	static System.Action <>9__15_1; // 0x8
	static System.Action <>9__16_1; // 0x10
	static System.Action <>9__17_1; // 0x18
	static System.Action <>9__26_0; // 0x20
	static System.Void .cctor(); // 0x05ea78e8
	System.Void .ctor(); // 0x05ea794c
	System.Void <InitName>b__15_1(); // 0x05ea79b4
	System.Void <InitAnnouncement>b__16_1(); // 0x05ea7a18
	System.Void <InitHireAnnouncement>b__17_1(); // 0x05ea7a80
	System.Void <InitBadgeFlag>b__26_0(); // 0x05ea7ae8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionSettingPage.<>c__DisplayClass15_0 : System.Object
{
	System.Boolean permission; // 0x10
	System.Void .ctor(); // 0x05ea6f38
	System.Void <InitName>b__0(FairyGUI.EventContext ctx); // 0x05ea7b4c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionSettingPage.<>c__DisplayClass16_0 : System.Object
{
	System.Boolean permission; // 0x10
	System.Void .ctor(); // 0x05ea6fa0
	System.Void <InitAnnouncement>b__0(FairyGUI.EventContext ctx); // 0x05ea7cd4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionSettingPage.<>c__DisplayClass17_0 : System.Object
{
	System.Boolean permission; // 0x10
	System.Void .ctor(); // 0x05ea7008
	System.Void <InitHireAnnouncement>b__0(FairyGUI.EventContext ctx); // 0x05ea7e5c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionSettingPage.<>c__DisplayClass24_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiUnionSettingPage <>4__this; // 0x10
	System.Int32 val; // 0x18
	System.Void .ctor(); // 0x05ea7454
	System.Void <OnSaveLevelLimit>b__0(SimpleJSON.JSONNode info); // 0x05ea7fe4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiUnionSettingPage.<>c__DisplayClass25_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiUnionSettingPage <>4__this; // 0x10
	System.Int32 val; // 0x18
	System.Void .ctor(); // 0x05ea767c
	System.Void <OnSaveReview>b__0(SimpleJSON.JSONNode info); // 0x05ea8124
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBtnKeyTipsAction : WizardGames.Soc.SocClient.Ui.ComStateBtn
{
	
	System.Void InitCom(WizardGames.Soc.Common.Data.ActionName actionName); // 0x05ea8264
	System.Void SetClickAction(FairyGUI.EventCallback0 callBack); // 0x05ea8324
	System.Void OnEnable(); // 0x05ea83b4
	System.Void OnDisable(); // 0x05ea8484
	System.Void .ctor(); // 0x05ea8504
	System.Void <OnEnable>b__2_0(); // 0x05ea856c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PartSortData : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	System.Single Distance; // 0x10
	System.Int32 Tag; // 0x14
	System.Void RegisterData(System.Single dis, System.Int32 tag); // 0x05ea8674
	System.Void OnGet(); // 0x05ea8704
	System.Void OnRelease(); // 0x05ea8768
	System.Void OnDestroy(); // 0x05ea87c8
	System.Void .ctor(); // 0x05ea8828
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.SelectEnum : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.SelectEnum None = 0;
	static WizardGames.Soc.SocClient.Ui.SelectEnum All = 1;
	static WizardGames.Soc.SocClient.Ui.SelectEnum Part = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.PartUpgradeData : System.Object, WizardGames.Soc.Common.ObjPool.IRecyclable
{
	static SocLogger logger; // 0x0
	System.Boolean IsFolder; // 0x10
	System.Int32 <Tag>k__BackingField; // 0x14
	System.Int64 <TemplateId>k__BackingField; // 0x18
	System.Int32 <Grade>k__BackingField; // 0x20
	System.Boolean <IsComboPart>k__BackingField; // 0x24
	System.Int64 <ComboGroupId>k__BackingField; // 0x28
	System.Int32 <Count>k__BackingField; // 0x30
	System.Int64 NeedBluePrint; // 0x38
	System.Collections.Generic.List<System.ValueTuple<System.Collections.Generic.List<System.Int64>,System.Int32>> numCounts; // 0x40
	System.Collections.Generic.List<System.Int64> deadChilds; // 0x48
	System.Int32 DisableCount; // 0x50
	WizardGames.Soc.SocClient.Ui.SelectEnum select; // 0x54
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> ItemNeedDic; // 0x58
	System.Collections.Generic.List<System.Int64> ItemNeedKeys; // 0x60
	System.Int32 get_Tag(); // 0x05ea8890
	System.Void set_Tag(System.Int32 value); // 0x05ea88f4
	System.Int64 get_TemplateId(); // 0x05ea896c
	System.Void set_TemplateId(System.Int64 value); // 0x05ea89d0
	System.Int32 get_Grade(); // 0x05ea8a48
	System.Void set_Grade(System.Int32 value); // 0x05ea8aac
	System.Boolean get_IsComboPart(); // 0x05ea8b24
	System.Void set_IsComboPart(System.Boolean value); // 0x05ea8b88
	System.Int64 get_ComboGroupId(); // 0x05ea8c04
	System.Void set_ComboGroupId(System.Int64 value); // 0x05ea8c68
	System.Int32 get_Count(); // 0x05ea8ce0
	System.Void set_Count(System.Int32 value); // 0x05ea8d44
	System.Boolean GetIsLocked(System.Int32 targetGrade, System.Boolean isUpgrade); // 0x05ea8dbc
	System.ValueTuple<System.Int64,System.Int64> GetTargetAndNeedBluePrint(System.Int32 targetGrade, System.Boolean isUpgrade); // 0x05ea8e64
	static System.Int64 GetPartNeedBluePrint(System.Int64 id); // 0x05ea9564
	static System.ValueTuple<System.Int64,System.Int64> GetTargetAndNeedBluePrint(WizardGames.Soc.SocClient.Ui.PartUpgradeData data, System.Int32 targetGrade, System.Boolean isUpgrade); // 0x05ea8f10
	WizardGames.Soc.SocClient.Ui.SelectEnum get_Select(); // 0x05ea9664
	System.Void set_Select(WizardGames.Soc.SocClient.Ui.SelectEnum value); // 0x05ea96c8
	WizardGames.Soc.Common.Data.constraction.BuildingCore get_CoreConfig(); // 0x05ea975c
	System.Boolean RegisterData(System.Int64 templateId, System.Int32 grade, System.Int32 count); // 0x05ea9898
	System.Boolean RegisterData(WizardGames.Soc.Common.SimpleCustom.ComboPartInfo comboPartInfo); // 0x05ea9c50
	System.Boolean RegisterDataCombo(System.Int64 comboGroupId, System.Int32 key, System.Int32 count); // 0x05eaa228
	System.Boolean RegisterDataCombo(System.Int64 templateId, System.Int32 grade, System.Int64 comboGroupId, System.Int32 count, System.Collections.Generic.List<System.Int64> aliveChildren, System.Collections.Generic.List<System.Int64> nonExistLst); // 0x05ea9eb8
	System.Boolean RegisterDataFolder(System.Int64 templateId); // 0x05eaa5b0
	System.Boolean TryMerge(WizardGames.Soc.Common.SimpleCustom.ComboPartInfo comboPartInfo); // 0x05eaa6e4
	System.Boolean IsEqual(WizardGames.Soc.Common.Entity.PartEntity part); // 0x05eaaa7c
	System.Void RefreshUpgradeCost(System.Int32 upgrade); // 0x05eaaca4
	System.Void RefreshFixCost(); // 0x05eab6f0
	System.Int32 GetEncodedKey(); // 0x05eabb70
	System.Void OnGet(); // 0x05eabe6c
	System.Void OnRelease(); // 0x05eac290
	System.Void ClearPooledMembers(); // 0x05eac064
	System.Void OnDestroy(); // 0x05eac2f4
	static System.String GetPartName(WizardGames.Soc.SocClient.Ui.PartUpgradeData upgradeData); // 0x05eac354
	static System.String GetPartName(System.Boolean isCombo, System.Int64 comboGroupId); // 0x05eac634
	static System.Void SetPartIcon(FairyGUI.GLoader icon, FairyGUI.GList iconChilds, WizardGames.Soc.SocClient.Ui.PartUpgradeData upgradeData); // 0x05eac7fc
	static System.Void SetPartIcon(FairyGUI.GLoader icon, FairyGUI.GList iconChilds, System.Int32 grade, System.Int64 comboGroupId, System.Int64 templateId); // 0x05eac9a8
	System.Void .ctor(); // 0x05eace8c
	static System.Void .cctor(); // 0x05eacff0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIComInfoTipsBase : System.Object
{
	WizardGames.Soc.SocClient.Ui.ConstructionInfoData curInfoData; // 0x10
	FairyGUI.GComponent root; // 0x18
	FairyGUI.GComponent comGroup; // 0x20
	FairyGUI.GButton <Button>k__BackingField; // 0x28
	System.Void InitNode(FairyGUI.GComponent root); // 0x05ead0c4
	FairyGUI.GButton get_Button(); // 0x05ead190
	System.Void Hide(); // 0x05ead1f4
	System.Void Show(WizardGames.Soc.SocClient.Ui.ConstructionInfoData infoData); // 0x05ead254
	System.Void InitItemList(); // 0x05ead310
	System.Void .ctor(); // 0x05ead370
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIComInfoTipsBlueprintLock : WizardGames.Soc.SocClient.Ui.UIComInfoTipsLock
{
	
	System.Void OnClick(FairyGUI.EventContext context); // 0x05ead3d8
	System.Void .ctor(); // 0x05ead52c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIComInfoTipsCraft : WizardGames.Soc.SocClient.Ui.UIComInfoTipsDetail
{
	FairyGUI.GButton btnCraft; // 0x78
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> craftNeedItemDic; // 0x80
	System.String get_titleStr(); // 0x05ead594
	System.Void InitNode(FairyGUI.GComponent root); // 0x05ead624
	FairyGUI.GButton get_Button(); // 0x05eada30
	System.Void Show(WizardGames.Soc.SocClient.Ui.ConstructionInfoData infoData); // 0x05eada94
	System.Void InitItemList(); // 0x05eae080
	System.Void ItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x05eae3f8
	System.Void OnClick(FairyGUI.EventContext context); // 0x05eae5e0
	System.Boolean CanCraft(); // 0x05eade94
	System.Void .ctor(); // 0x05eae848
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIComInfoTipsDeploy : WizardGames.Soc.SocClient.Ui.UIComInfoTipsInfo
{
	FairyGUI.Controller ctrBtnType; // 0x40
	FairyGUI.GButton btnDetail; // 0x48
	FairyGUI.GButton btnJump; // 0x50
	FairyGUI.GTextField btnHaveCount; // 0x58
	FairyGUI.GTextField btnRemainCount; // 0x60
	System.Int32 controllerIndex; // 0x68
	System.Void InitNode(FairyGUI.GComponent root); // 0x05eaea0c
	System.Void Show(WizardGames.Soc.SocClient.Ui.ConstructionInfoData infoData); // 0x05eaecf8
	System.Void Hide(); // 0x05eaf66c
	System.Void OnClickDetail(); // 0x05eaf6fc
	System.Void OnClickJump(); // 0x05eaf860
	System.Void .ctor(); // 0x05eaf9b8
	System.Void <Show>b__7_0(); // 0x05eafa28
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIComInfoTipsDeployLock : WizardGames.Soc.SocClient.Ui.UIComInfoTipsInfo
{
	FairyGUI.Controller ctrBtnType; // 0x40
	FairyGUI.GButton btnDetail; // 0x48
	FairyGUI.GButton btnUnlock; // 0x50
	FairyGUI.GButton btnJump; // 0x58
	System.Int32 controllerIndex; // 0x60
	System.Void InitNode(FairyGUI.GComponent root); // 0x05eafb6c
	FairyGUI.GButton get_Button(); // 0x05eafe8c
	System.Void Show(WizardGames.Soc.SocClient.Ui.ConstructionInfoData infoData); // 0x05eafef0
	System.Void Hide(); // 0x05eb0288
	System.Void OnClick(FairyGUI.EventContext context); // 0x05eb0318
	System.Void OnClickDetail(); // 0x05eb056c
	System.Void OnClickJump(); // 0x05eb06d0
	System.Void .ctor(); // 0x05eb0828
	System.Void <Show>b__8_0(); // 0x05eb0898
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIComInfoTipsDetail : WizardGames.Soc.SocClient.Ui.UIComInfoTipsInfo
{
	FairyGUI.Controller ctrBtnType; // 0x40
	FairyGUI.GButton btnDetail; // 0x48
	FairyGUI.GButton btnJump; // 0x50
	FairyGUI.GList listItem; // 0x58
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.ComItemIconForConstruction> object2ItemIconDic; // 0x60
	System.Collections.Generic.List<System.Int64> itemIdList; // 0x68
	System.Int32 controllerIndex; // 0x70
	System.Void InitNode(FairyGUI.GComponent root); // 0x05ead78c
	System.Void Show(WizardGames.Soc.SocClient.Ui.ConstructionInfoData infoData); // 0x05eadbf8
	System.Void InitItemList(); // 0x05eb09dc
	System.Void Hide(); // 0x05eb0f70
	System.Void ItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x05eb1018
	System.Void OnClickDetail(); // 0x05eb1240
	System.Void OnClickJump(); // 0x05eb13a4
	System.Void .ctor(); // 0x05eae8f8
	System.Void <Show>b__8_0(); // 0x05eb14fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIComInfoTipsEmpty : WizardGames.Soc.SocClient.Ui.UIComInfoTipsBase
{
	
	System.Void .ctor(); // 0x05eb1e74
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIComInfoTipsInfo : WizardGames.Soc.SocClient.Ui.UIComInfoTipsBase
{
	FairyGUI.GTextField txtName; // 0x30
	FairyGUI.GTextField txtInfo; // 0x38
	System.Void InitNode(FairyGUI.GComponent root); // 0x05eb1edc
	System.Void Show(WizardGames.Soc.SocClient.Ui.ConstructionInfoData infoData); // 0x05eb1fec
	System.Void .ctor(); // 0x05eb2168
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIComInfoTipsLock : WizardGames.Soc.SocClient.Ui.UIComInfoTipsDetail
{
	FairyGUI.GButton btnUnlock; // 0x78
	System.Void InitNode(FairyGUI.GComponent root); // 0x05eb21d0
	FairyGUI.GButton get_Button(); // 0x05eb230c
	System.Void Show(WizardGames.Soc.SocClient.Ui.ConstructionInfoData infoData); // 0x05eb2370
	System.Void OnClick(FairyGUI.EventContext context); // 0x05eb2550
	System.Void .ctor(); // 0x05eb280c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UIComInfoTipsWithBtn : WizardGames.Soc.SocClient.Ui.UIComInfoTipsInfo
{
	FairyGUI.Controller ctrBtnType; // 0x40
	FairyGUI.GButton btnDetail; // 0x48
	FairyGUI.GButton btnJump; // 0x50
	FairyGUI.GButton btnCustom; // 0x58
	System.Int32 controllerIndex; // 0x60
	System.Void InitNode(FairyGUI.GComponent root); // 0x05eb2874
	FairyGUI.GButton get_Button(); // 0x05eb2b88
	System.Void Show(WizardGames.Soc.SocClient.Ui.ConstructionInfoData infoData); // 0x05eb2bec
	System.Void Hide(); // 0x05eb2ef8
	System.Void OnClick(FairyGUI.EventContext context); // 0x05eb2f8c
	System.Void OnClickDetail(); // 0x05eb3074
	System.Void OnClickJump(); // 0x05eb31d8
	System.Void .ctor(); // 0x05eb3330
	System.Void <Show>b__8_0(); // 0x05eb339c
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.ConstructionInfoTipsCreator : System.ValueType
{
	System.String comName; // 0x10
	System.Func<WizardGames.Soc.SocClient.Ui.UIComInfoTipsBase> creator; // 0x18
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EConstructionEditMode : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EConstructionEditMode None = 0;
	static WizardGames.Soc.SocClient.Ui.EConstructionEditMode TestEmpty = 1;
	static WizardGames.Soc.SocClient.Ui.EConstructionEditMode TestInfo = 2;
	static WizardGames.Soc.SocClient.Ui.EConstructionEditMode TestDetail = 3;
	static WizardGames.Soc.SocClient.Ui.EConstructionEditMode TestDeploy = 4;
	static WizardGames.Soc.SocClient.Ui.EConstructionEditMode TestCraft = 5;
	static WizardGames.Soc.SocClient.Ui.EConstructionEditMode TestLock = 6;
	static WizardGames.Soc.SocClient.Ui.EConstructionEditMode TestDeployLock = 7;
	static WizardGames.Soc.SocClient.Ui.EConstructionEditMode TestBlueprintLock = 8;
	static WizardGames.Soc.SocClient.Ui.EConstructionEditMode TestTipsWithBtn = 9;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EConstructionInfoType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EConstructionInfoType Empty = 0;
	static WizardGames.Soc.SocClient.Ui.EConstructionInfoType Info = 1;
	static WizardGames.Soc.SocClient.Ui.EConstructionInfoType Detail = 2;
	static WizardGames.Soc.SocClient.Ui.EConstructionInfoType Deploy = 3;
	static WizardGames.Soc.SocClient.Ui.EConstructionInfoType Craft = 4;
	static WizardGames.Soc.SocClient.Ui.EConstructionInfoType Lock = 5;
	static WizardGames.Soc.SocClient.Ui.EConstructionInfoType DeployLock = 6;
	static WizardGames.Soc.SocClient.Ui.EConstructionInfoType BlueprintLock = 7;
	static WizardGames.Soc.SocClient.Ui.EConstructionInfoType TipsWithBtn = 8;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ConstructionInfoData : System.Object
{
	WizardGames.Soc.SocClient.Ui.EConstructionEditMode editMode; // 0x10
	System.String strName; // 0x18
	System.String info; // 0x20
	System.Int64 itemId; // 0x28
	System.Int64 blueprintId; // 0x30
	UnityEngine.Vector3 position; // 0x38
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> itemNeedDic; // 0x48
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> itemDeployNeedDic; // 0x50
	WizardGames.Soc.SocClient.Ui.UIConstructionDetailInfo detailInfo; // 0x58
	System.String btnCustomTitle; // 0x60
	System.Action btnOnClickAction; // 0x68
	System.Boolean IsCustomBlueprint; // 0x70
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.HotKeyResData> hotKeyResDataList; // 0x78
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> itemNeedGuildDic; // 0x80
	System.String guildInfo; // 0x88
	System.String guildTitle; // 0x90
	WizardGames.Soc.SocClient.Manager.HotKeyCenterGuideData hotKeyCenterGuideData; // 0x98
	System.Int64 get_ItemCount(); // 0x05eb34e0
	System.Void Reset(System.Boolean isBuildGuide); // 0x05eb3578
	System.Int64 get_TargetBlueprintId(); // 0x05eb26dc
	System.Int64 GetItemBlueprintId(); // 0x05eb38e4
	System.Void RefreshBuildGuild(); // 0x05eb3884
	System.Void RefreshBuildGuide(System.String titleStr); // 0x05eb2454
	System.Void .ctor(); // 0x05eb3990
}

