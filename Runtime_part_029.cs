	static System.Boolean OnClickAllMoveToInventory(WizardGames.Soc.Common.Data.DataItem.ItemConfig curItem); // 0x0609d924
	static System.Boolean OnClickAllInPut(WizardGames.Soc.Common.Data.DataItem.ItemConfig curItem); // 0x0609dac0
	static System.Boolean OnClickDetail(WizardGames.Soc.Common.Data.DataItem.ItemConfig curItem); // 0x0609dde4
	static System.Boolean OnClicSkin(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x0609df00
	static System.Void ResetShareSkin(System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> resetItemList, WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x0609e264
	System.Void AddSpecialBtns(WizardGames.Soc.Common.Data.DataItem.ItemConfig config); // 0x060999d4
	System.Void BindItemTipsMain(WizardGames.Soc.SocClient.Ui.UiItemTipsMain tipsMain); // 0x06098380
	System.Void SetRootController(WizardGames.Soc.SocClient.Ui.UiItemTipsMain tipsMain); // 0x060984a8
	System.Void AddDetailBtn(); // 0x06099474
	static System.Boolean OnClickItemDrop(WizardGames.Soc.Common.CustomType.BaseItemNode curItem); // 0x0609e588
	System.Boolean InspectAddBtn(WizardGames.Soc.Common.CustomType.BaseItemNode item, System.Int32 mainType, System.Int32 subType); // 0x06099a48
	System.Void .ctor(); // 0x0609e690
	static System.Void .cctor(); // 0x060a0144
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardBtns.TipsBtnInfo : System.Object
{
	WizardGames.Soc.Common.Data.DataItem.ItemTIPSButtonManagement <Cfg>k__BackingField; // 0x10
	System.Int32 glistIndex; // 0x18
	System.Int32 allBtnIndex; // 0x1c
	System.String nameDir; // 0x20
	System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> onClickInst; // 0x28
	System.Func<WizardGames.Soc.Common.Data.DataItem.ItemConfig,System.Boolean> onClickConfig; // 0x30
	System.Func<WizardGames.Soc.Common.CustomType.BaseItemNode,System.Boolean> stateCond; // 0x38
	WizardGames.Soc.Common.Data.DataItem.ItemTIPSButtonManagement get_Cfg(); // 0x060a0218
	System.Void set_Cfg(WizardGames.Soc.Common.Data.DataItem.ItemTIPSButtonManagement value); // 0x060a027c
	System.String get_iconURL(); // 0x0609a208
	System.String get_name(); // 0x0609a2bc
	System.String get_soundEvent(); // 0x060a02fc
	System.Int32 get_order(); // 0x06099920
	System.Void .ctor(System.Int32 index); // 0x0609ffd4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardBtns.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiItemTipsBoardBtns.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.UiMissionView> <>9__29_0; // 0x8
	static System.Action<WizardGames.Soc.Share.Framework.EntityBase> <>9__40_1; // 0x10
	static System.Void .cctor(); // 0x060a03b0
	System.Void .ctor(); // 0x060a0414
	System.Void <OnClickNormalUse>b__29_0(WizardGames.Soc.SocClient.Ui.UiMissionView win); // 0x060a047c
	System.Void <OnClickMoveToOtherside>b__40_1(WizardGames.Soc.Share.Framework.EntityBase loot); // 0x060a0504
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardBtns.<>c__DisplayClass23_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiItemTipsBoardBtns.TipsBtnInfo btnInfo; // 0x10
	WizardGames.Soc.SocClient.Ui.UiItemTipsBoardBtns <>4__this; // 0x18
	System.Void .ctor(); // 0x0609a1a0
	System.Void <BtnRenderer>b__0(FairyGUI.EventContext ctx); // 0x060a0640
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardBtns.<>c__DisplayClass37_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.BaseItemNode curItem; // 0x10
	System.Void .ctor(); // 0x0609bdbc
	System.Void <OnClickUnloadPart>b__0(); // 0x060a099c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardBtns.<>c__DisplayClass40_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.BaseItemNode curItem; // 0x10
	System.Void .ctor(); // 0x0609c990
	System.Void <OnClickMoveToOtherside>b__0(WizardGames.Soc.Share.Framework.EntityBase loot, System.Boolean needToast); // 0x060a0a80
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardBtns.<>c__DisplayClass49_0 : System.Object
{
	WizardGames.Soc.Common.Data.DataItem.ItemConfig curItem; // 0x10
	WizardGames.Soc.Common.CustomType.BaseItemNode itemNode; // 0x18
	System.Void .ctor(); // 0x0609d8bc
	System.Boolean <OnClickMovetoCabinet>b__0(WizardGames.Soc.Common.CustomType.BaseItemNode node); // 0x060a0c18
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardBtns.<>c__DisplayClass53_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.BaseItemNode curItem; // 0x10
	System.Void .ctor(); // 0x0609e1fc
	System.Void <OnClicSkin>b__0(); // 0x060a0cd0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardBtns.<>c__DisplayClass54_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.BaseItemNode curItem; // 0x10
	System.Action <>9__0; // 0x18
	System.Void .ctor(); // 0x0609e520
	System.Void <ResetShareSkin>b__0(); // 0x060a0e10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardDesc : System.Object, WizardGames.Soc.SocClient.Ui.IItemTipsBoard
{
	FairyGUI.GComponent comDesc; // 0x10
	FairyGUI.GTextField textDesc; // 0x18
	FairyGUI.GComponent get_ComBoard(); // 0x060a0f74
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiItemTipsMain tipsMain, System.Boolean isSubTips); // 0x060a0fd8
	System.Void SetItem(WizardGames.Soc.Common.CustomType.BaseItemNode item, WizardGames.Soc.Common.Data.DataItem.ItemConfig tbItem); // 0x060a1138
	System.Void SetItem(WizardGames.Soc.Common.Data.resource.OBJGenaral item); // 0x060a12f0
	System.Void SetItem(WizardGames.Soc.SocClient.Talent.TalentNode item); // 0x060a1378
	System.Void SetItem(WizardGames.Soc.Common.Data.Reputation.ReputationSelectConfig item); // 0x060a1400
	System.Void .ctor(); // 0x060a1488
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardInfo : System.Object, WizardGames.Soc.SocClient.Ui.IItemTipsBoard
{
	FairyGUI.GComponent comInfo; // 0x10
	FairyGUI.GList listAttr; // 0x18
	System.Collections.Generic.List<System.Int32> curAttrs; // 0x20
	System.Collections.Generic.List<System.Int32> curAttrs2; // 0x28
	FairyGUI.GComponent get_ComBoard(); // 0x060a14f0
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiItemTipsMain tipsMain, System.Boolean isSubTips); // 0x060a1554
	System.Void SetItem(WizardGames.Soc.Common.CustomType.BaseItemNode item, WizardGames.Soc.Common.Data.DataItem.ItemConfig tbItem); // 0x060a1714
	System.Void SetItem(WizardGames.Soc.Common.Data.resource.OBJGenaral item); // 0x060a1ff0
	System.Void SetItem(WizardGames.Soc.SocClient.Talent.TalentNode item); // 0x060a2078
	System.Void SetItem(WizardGames.Soc.Common.Data.Reputation.ReputationSelectConfig item); // 0x060a2100
	System.Void ListItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x060a2188
	System.Void CollectItemCommonAttrs(WizardGames.Soc.Common.CustomType.BaseItemNode itemInst, WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg); // 0x060a1a48
	System.Void CollectItemTbAttrs(WizardGames.Soc.Common.CustomType.BaseItemNode itemInst, WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg); // 0x060a1dfc
	System.Void .ctor(); // 0x060a2470
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardLobbyFunctionBtns : System.Object, WizardGames.Soc.SocClient.Ui.IItemTipsBoard
{
	WizardGames.Soc.SocClient.Ui.UiLobbyFunctionButton uiLobbyFunctionButton; // 0x10
	FairyGUI.GComponent comBtnsCom; // 0x18
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiItemTipsMain tipsMain, System.Boolean isSubTips); // 0x060a24d8
	System.Void SetItem(WizardGames.Soc.Common.CustomType.BaseItemNode item, WizardGames.Soc.Common.Data.DataItem.ItemConfig tbItem); // 0x060a262c
	System.Void SetItem(WizardGames.Soc.Common.Data.resource.OBJGenaral item); // 0x060a26bc
	System.Void SetItem(WizardGames.Soc.SocClient.Talent.TalentNode item); // 0x060a275c
	System.Void SetItem(WizardGames.Soc.Common.Data.Reputation.ReputationSelectConfig item); // 0x060a27e4
	System.Void .ctor(); // 0x060a286c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardLobbyResDesc : System.Object, WizardGames.Soc.SocClient.Ui.IItemTipsBoard
{
	FairyGUI.GComponent comItemText; // 0x10
	FairyGUI.GRichTextField itemText; // 0x18
	WizardGames.Soc.SocClient.Ui.UiItemTipsMain mainTips; // 0x20
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiItemTipsMain tipsMain, System.Boolean isSubTips); // 0x060a28d4
	System.Void SetItem(WizardGames.Soc.Common.CustomType.BaseItemNode item, WizardGames.Soc.Common.Data.DataItem.ItemConfig tbItem); // 0x060a2a94
	System.Void SetItem(WizardGames.Soc.Common.Data.resource.OBJGenaral item); // 0x060a2b24
	System.Void SetItem(WizardGames.Soc.SocClient.Talent.TalentNode item); // 0x060a2bd0
	System.Single GetBoardHeight(); // 0x060a2d68
	System.Void SetItem(WizardGames.Soc.Common.Data.Reputation.ReputationSelectConfig item); // 0x060a2e6c
	System.Void .ctor(); // 0x060a2f38
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardLobbyResGetWay : System.Object, WizardGames.Soc.SocClient.Ui.IItemTipsBoard
{
	WizardGames.Soc.SocClient.Ui.UiItemGetWay itemGetWay; // 0x10
	WizardGames.Soc.SocClient.Ui.UiItemTipsMain mainTips; // 0x18
	System.Boolean blockGetWay; // 0x20
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiItemTipsMain tipsMain, System.Boolean isSubTips); // 0x060a2fa0
	System.Void SetItem(WizardGames.Soc.Common.CustomType.BaseItemNode item, WizardGames.Soc.Common.Data.DataItem.ItemConfig tbItem); // 0x060a3158
	System.Void SetItem(WizardGames.Soc.Common.Data.resource.OBJGenaral item); // 0x060a31e8
	System.Void SetItem(WizardGames.Soc.SocClient.Talent.TalentNode item); // 0x060a32a8
	System.Void SetItemWay(System.Boolean blockGetWay); // 0x060a3330
	System.Void SetItem(WizardGames.Soc.Common.Data.Reputation.ReputationSelectConfig item); // 0x060a33ac
	System.Void .ctor(); // 0x060a3434
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardLobbyResSourceInfo : System.Object, WizardGames.Soc.SocClient.Ui.IItemTipsBoard
{
	WizardGames.Soc.SocClient.Ui.UiResSourceInfo uiResSourceInfo; // 0x10
	WizardGames.Soc.SocClient.Ui.UiItemTipsMain mainTips; // 0x18
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiItemTipsMain tipsMain, System.Boolean isSubTips); // 0x060a349c
	System.Void SetItem(WizardGames.Soc.Common.CustomType.BaseItemNode item, WizardGames.Soc.Common.Data.DataItem.ItemConfig tbItem); // 0x060a364c
	System.Void SetItem(WizardGames.Soc.Common.Data.resource.OBJGenaral item); // 0x060a36dc
	System.Void SetItem(WizardGames.Soc.SocClient.Talent.TalentNode item); // 0x060a379c
	System.Void SetItem(WizardGames.Soc.Common.Data.Reputation.ReputationSelectConfig item); // 0x060a3824
	System.Void .ctor(); // 0x060a38ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardLobbyResTitle : System.Object, WizardGames.Soc.SocClient.Ui.IItemTipsBoard
{
	WizardGames.Soc.SocClient.Ui.UiResTitle uiResTitle; // 0x10
	WizardGames.Soc.SocClient.Ui.UiItemTipsMain mainTips; // 0x18
	System.Int32 ID; // 0x20
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiItemTipsMain tipsMain, System.Boolean isSubTips); // 0x060a3914
	System.Void Refresh(System.String timeLimitParam, System.Int64 time, System.Int32 timeLimitType); // 0x060a3a64
	System.Void SetItem(WizardGames.Soc.Common.CustomType.BaseItemNode item, WizardGames.Soc.Common.Data.DataItem.ItemConfig tbItem); // 0x060a3b14
	System.Void SetItem(WizardGames.Soc.Common.Data.resource.OBJGenaral item); // 0x060a3ba4
	System.Void SetItem(WizardGames.Soc.SocClient.Talent.TalentNode item); // 0x060a3c6c
	System.Void SetItem(WizardGames.Soc.Common.Data.Reputation.ReputationSelectConfig item); // 0x060a3cf4
	System.Void .ctor(); // 0x060a3d7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardMatCraft : System.Object, WizardGames.Soc.SocClient.Ui.IItemTipsBoard
{
	FairyGUI.GComponent comMatCraft; // 0x10
	FairyGUI.GList listIcons; // 0x18
	FairyGUI.GTextField textUnit; // 0x20
	FairyGUI.GButton btnStart; // 0x28
	FairyGUI.Controller ctrlStyle; // 0x30
	WizardGames.Soc.SocClient.Ui.ComStepper comStepper; // 0x38
	WizardGames.Soc.Common.Data.blueprintData.Blueprint curBpData; // 0x40
	FairyGUI.GComponent get_ComBoard(); // 0x060a3de4
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiItemTipsMain tipsMain, System.Boolean isSubTips); // 0x060a3e48
	System.Void SetItem(WizardGames.Soc.Common.CustomType.BaseItemNode item, WizardGames.Soc.Common.Data.DataItem.ItemConfig tbItem); // 0x060a41a0
	System.Void SetItem(WizardGames.Soc.Common.Data.resource.OBJGenaral item); // 0x060a4a98
	System.Void SetItem(WizardGames.Soc.SocClient.Talent.TalentNode item); // 0x060a4b20
	System.Void SetItem(WizardGames.Soc.Common.Data.Reputation.ReputationSelectConfig item); // 0x060a4ba8
	System.Boolean CanShowMatCraft(); // 0x060a43c8
	System.Void RefreshCraftBtnState(); // 0x060a4514
	System.Void OnStepperValChanged(System.Int32 val); // 0x060a4c30
	System.Void MatItemRender(System.Int32 index, FairyGUI.GObject item); // 0x060a4cb4
	System.Void OnCraft(); // 0x060a4ff4
	System.Void GoToTechTree(); // 0x060a5368
	System.Void .ctor(); // 0x060a543c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardParts : WizardGames.Soc.SocClient.Ui.ClientContainerFixed, WizardGames.Soc.SocClient.Ui.IItemTipsBoard
{
	FairyGUI.GObjectPool partIconPool; // 0x78
	FairyGUI.GComponent comParts; // 0x80
	FairyGUI.GGraph graphBac; // 0x88
	FairyGUI.GList listWeaponParts; // 0x90
	FairyGUI.GList listEngineParts; // 0x98
	System.Collections.Generic.Dictionary<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.Binder.GameItemTips.ComTipsItemPartsIconBinder> com2IconBinders; // 0xa0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Binder.GameItemTips.ComTipsItemPartsIconBinder> iconBinders; // 0xa8
	WizardGames.Soc.SocClient.Ui.UiItemTipsBoardPartsDoubleClick doubleClick; // 0xb0
	WizardGames.Soc.SocClient.Ui.UiItemTipsMain tipsMain; // 0xb8
	WizardGames.Soc.Common.CustomType.BaseItemNode curBodyItem; // 0xc0
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.ItemSlot> curSlots; // 0xc8
	System.Boolean isCurWeapon; // 0xd0
	FairyGUI.GComponent get_ComBoard(); // 0x060a54a4
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiItemTipsMain tipsMain, System.Boolean isSubTips); // 0x060a5508
	System.Void OnDisable(); // 0x060a59e0
	System.Void SetPartListVisible(System.Boolean isWeapon, System.Int32 capcity); // 0x060a5b28
	System.Void SetItem(WizardGames.Soc.Common.CustomType.BaseItemNode item, WizardGames.Soc.Common.Data.DataItem.ItemConfig tbItem); // 0x060a5c24
	System.Void SetItem(WizardGames.Soc.Common.Data.resource.OBJGenaral item); // 0x060a5e60
	System.Void SetItem(WizardGames.Soc.SocClient.Talent.TalentNode item); // 0x060a5ee8
	System.Void SetItem(WizardGames.Soc.Common.Data.Reputation.ReputationSelectConfig item); // 0x060a5f70
	System.Void CollectIcons(); // 0x060a5ff8
	System.Void DealIconWhenCollect(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x060a656c
	System.Void SetWeaponPartItemDatas(); // 0x060a67e0
	System.Void SetEnginePartItemDatas(); // 0x060a714c
	System.Void SetItemDatas(); // 0x060a7644
	System.Boolean TryWeaponPartEquip(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, WizardGames.Soc.Common.CustomType.BaseItemNode dropItem); // 0x060a76c0
	System.Boolean TryEnginePartEquip(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, WizardGames.Soc.Common.CustomType.BaseItemNode dropItem); // 0x060a7bc8
	System.Boolean TryPartEquip(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, WizardGames.Soc.SocClient.Ui.ItemDragInfo dropData); // 0x060a7f84
	System.Void CheckWeaponPartMainPackBlink(WizardGames.Soc.SocClient.Ui.ComItemIcon clickIcon); // 0x060a8190
	System.Boolean isEnginePartMatchToSlot(WizardGames.Soc.Common.CustomType.BaseItemNode node, System.Int32 slot); // 0x060a7e04
	System.Void CheckEnginePartMainPackBlink(WizardGames.Soc.SocClient.Ui.ComItemIcon clickIcon); // 0x060a846c
	System.Void UnChooseAllBoardIcons(); // 0x060a87b8
	System.Void OnClickItem(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x060a8818
	System.Void .ctor(); // 0x060a8d20
	FairyGUI.GObject <Bind>b__14_0(System.String url); // 0x060a8f48
	System.Void <Bind>b__14_1(FairyGUI.GObject obj); // 0x060a8fd8
	FairyGUI.GObject <Bind>b__14_2(System.String url); // 0x060a9064
	System.Void <Bind>b__14_3(FairyGUI.GObject obj); // 0x060a90f4
	System.Void <Bind>b__14_4(FairyGUI.EventContext ctx); // 0x060a9180
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardParts.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiItemTipsBoardParts.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.ComItemIcon> <>9__15_0; // 0x8
	static FairyGUI.EventCallback1 <>9__23_0; // 0x10
	static System.Void .cctor(); // 0x060a9294
	System.Void .ctor(); // 0x060a92f8
	System.Void <OnDisable>b__15_0(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x060a9360
	System.Void <SetWeaponPartItemDatas>b__23_0(FairyGUI.EventContext context); // 0x060a93e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardParts.<>c__DisplayClass22_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x10
	System.Void .ctor(); // 0x060a6778
	System.Void <DealIconWhenCollect>b__0(FairyGUI.EventContext ctx); // 0x060a946c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardParts.<>c__DisplayClass29_0 : System.Object
{
	System.Boolean hasItem; // 0x10
	WizardGames.Soc.Common.Data.DataItem.ItemSlot partType; // 0x14
	System.Void .ctor(); // 0x060a8404
	System.Boolean <CheckWeaponPartMainPackBlink>b__0(WizardGames.Soc.Common.CustomType.BaseItemNode node); // 0x060a9514
	System.Boolean <CheckWeaponPartMainPackBlink>b__1(WizardGames.Soc.Common.CustomType.BaseItemNode node); // 0x060a9668
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardParts.<>c__DisplayClass31_0 : System.Object
{
	System.Boolean hasItem; // 0x10
	WizardGames.Soc.SocClient.Ui.UiItemTipsBoardParts <>4__this; // 0x18
	System.Int32 curPartIndex; // 0x20
	System.Void .ctor(); // 0x060a8750
	System.Boolean <CheckEnginePartMainPackBlink>b__0(WizardGames.Soc.Common.CustomType.BaseItemNode node); // 0x060a97b4
	System.Boolean <CheckEnginePartMainPackBlink>b__1(WizardGames.Soc.Common.CustomType.BaseItemNode node); // 0x060a9850
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardParts.<>c__DisplayClass33_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon clickIcon; // 0x10
	System.Void .ctor(); // 0x060a8b7c
	System.Void <OnClickItem>b__0(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x060a98d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardPartsDoubleClick : System.Object
{
	WizardGames.Soc.SocClient.Ui.IconDoubleClickCfg <DoubleClickCfg>k__BackingField; // 0x10
	WizardGames.Soc.SocClient.Ui.IconDoubleClickCfg get_DoubleClickCfg(); // 0x060a9978
	System.Void set_DoubleClickCfg(WizardGames.Soc.SocClient.Ui.IconDoubleClickCfg value); // 0x060a99dc
	System.Void .ctor(); // 0x060a8dbc
	System.Void DoDoubleClick(WizardGames.Soc.SocClient.Ui.ComItemIcon icon); // 0x060a9a5c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardSeedGene : System.Object, WizardGames.Soc.SocClient.Ui.IItemTipsBoard
{
	FairyGUI.GComponent comGene; // 0x10
	FairyGUI.GList listGenes; // 0x18
	WizardGames.Soc.Common.CustomType.PlantSeedNode curSeedNode; // 0x20
	FairyGUI.Controller ctrlStyle; // 0x28
	FairyGUI.GComponent get_ComBoard(); // 0x060a9ce4
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiItemTipsMain tipsMain, System.Boolean isSubTips); // 0x060a9d48
	System.Void SetItem(WizardGames.Soc.Common.CustomType.BaseItemNode item, WizardGames.Soc.Common.Data.DataItem.ItemConfig tbItem); // 0x060a9f30
	System.Void SetItem(WizardGames.Soc.Common.Data.resource.OBJGenaral item); // 0x060aa154
	System.Void SetItem(WizardGames.Soc.SocClient.Talent.TalentNode item); // 0x060aa1dc
	System.Void SetItem(WizardGames.Soc.Common.Data.Reputation.ReputationSelectConfig item); // 0x060aa264
	System.Void SeedGenRenderer(System.Int32 index, FairyGUI.GObject objGen); // 0x060aa2ec
	System.Void .ctor(); // 0x060aa568
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardWaterBottle : System.Object, WizardGames.Soc.SocClient.Ui.IItemTipsBoard
{
	FairyGUI.GComponent comBoard; // 0x10
	WizardGames.Soc.SocClient.Ui.ComItemIcon iconWater; // 0x18
	WizardGames.Soc.Common.CustomType.WaterBottleItemNode curBottleItem; // 0x20
	WizardGames.Soc.SocClient.Ui.UiItemTipsMain tipsMain; // 0x28
	System.Boolean isSubTips; // 0x30
	FairyGUI.GList iconList; // 0x38
	WizardGames.Soc.SocClient.Ui.ComBaseIcon lastSelectedItemIcon; // 0x40
	FairyGUI.GComponent get_ComBoard(); // 0x060aa5d0
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiItemTipsMain tipsMain, System.Boolean isSubTips); // 0x060aa634
	System.Void OnEnable(); // 0x060aa810
	System.Void OnDisable(); // 0x060aa908
	System.Void OnHideSubItemTipsBack(); // 0x060aaa00
	System.Boolean OnIconAcceptDrop(WizardGames.Soc.SocClient.Ui.ComBaseIcon myIcon, WizardGames.Soc.SocClient.Ui.ItemDragInfo dropData); // 0x060aaa7c
	System.Void SetItem(WizardGames.Soc.Common.CustomType.BaseItemNode item, WizardGames.Soc.Common.Data.DataItem.ItemConfig tbItem); // 0x060aabdc
	System.Void InitWaterIcon(); // 0x060aad4c
	System.Void SetItem(WizardGames.Soc.Common.Data.resource.OBJGenaral item); // 0x060ab05c
	System.Void SetItem(WizardGames.Soc.SocClient.Talent.TalentNode item); // 0x060ab0e4
	System.Void SetItem(WizardGames.Soc.Common.Data.Reputation.ReputationSelectConfig item); // 0x060ab16c
	System.Void OnClickItem(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon, FairyGUI.EventContext ctx); // 0x060ab65c
	System.Void .ctor(); // 0x060abb44
	System.Void <InitWaterIcon>b__15_0(FairyGUI.EventContext context); // 0x060abbac
	System.Boolean <InitWaterIcon>b__15_1(WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x060abc2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsBoardWaterBottle.<>c__DisplayClass18_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon itemIcon; // 0x10
	WizardGames.Soc.SocClient.Ui.UiItemTipsBoardWaterBottle <>4__this; // 0x18
	System.Void .ctor(); // 0x060ab5f4
	System.Void <SetItem>b__0(FairyGUI.EventContext context); // 0x060abe00
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiEquipItemTips : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.UiExpandPopupBinder binder; // 0x10
	FairyGUI.GButton clickMask; // 0x18
	FairyGUI.Controller ctrlShow; // 0x20
	FairyGUI.GComponent <root>k__BackingField; // 0x28
	WizardGames.Soc.Common.CustomType.BaseItemNode weaponData; // 0x30
	WizardGames.Soc.Common.Data.gun.GunBase weaponConfig; // 0x38
	WizardGames.Soc.Common.CustomType.BaseItemNode partData; // 0x40
	System.Int64 bulletConfigId; // 0x48
	WizardGames.Soc.Common.Data.DataItem.ItemSlot selectedSlot; // 0x50
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> amountDic; // 0x58
	System.Collections.Generic.Dictionary<System.Int64,WizardGames.Soc.Common.CustomType.BaseItemNode> instDic; // 0x60
	System.Collections.Generic.List<System.Int64> selectList; // 0x68
	WizardGames.Soc.Common.Data.DataItem.ItemConfig selectedItemCfg; // 0x70
	WizardGames.Soc.SocClient.Ui.ComStateBtn equipBtn; // 0x78
	WizardGames.Soc.SocClient.Ui.ComStateBtn unequipBtn; // 0x80
	System.Int32 selectType; // 0x88
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComItemIconSimpleBinder> binders; // 0x90
	System.Int32 ItemHeight; // 0x98
	FairyGUI.GComponent get_root(); // 0x060abe88
	System.Void set_root(FairyGUI.GComponent value); // 0x060abeec
	System.Void Bind(FairyGUI.GComponent root, FairyGUI.GButton mask, FairyGUI.Controller ctrl); // 0x060abf6c
	System.Void OnUnequipClicked(FairyGUI.EventContext context); // 0x060ac508
	System.Void OnEquipClicked(FairyGUI.EventContext context); // 0x060acad8
	System.Void ItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x060accec
	System.Void OnClickSelectItem(FairyGUI.EventContext context); // 0x060ad3fc
	System.Void RefreshSelectItem(); // 0x060ad694
	System.Void ShowSelectPart(WizardGames.Soc.Common.CustomType.BaseItemNode weapon, WizardGames.Soc.Common.CustomType.BaseItemNode part, WizardGames.Soc.Common.Data.DataItem.ItemSlot partType, FairyGUI.GObject targetObj); // 0x060adc6c
	System.Void RefreshSelectPart(); // 0x060ae980
	System.Void GetPartData(); // 0x060ae208
	System.Void ShowSelectBullet(WizardGames.Soc.Common.CustomType.BaseItemNode weapon, FairyGUI.GObject targetObj); // 0x060aee0c
	System.Void GetBulletData(); // 0x060af384
	System.Void SortSelectList(); // 0x060aeac0
	System.Void OnClickMask(); // 0x060af640
	System.Void Hide(); // 0x060aca64
	System.Void .ctor(); // 0x060af6cc
	System.Void <OnUnequipClicked>b__21_0(); // 0x060af924
	System.Boolean <GetBulletData>b__32_0(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x060afb20
	System.Int32 <SortSelectList>b__33_0(System.Int64 a, System.Int64 b); // 0x060afd00
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiEquipItemTips.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiEquipItemTips.<>c <>9; // 0x0
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComItemIconSimpleBinder> <>9__36_0; // 0x8
	static System.Void .cctor(); // 0x060afe0c
	System.Void .ctor(); // 0x060afe70
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.ComItemIconSimpleBinder <.ctor>b__36_0(FairyGUI.GComponent c); // 0x060afed8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiSelectItemTips : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GComponent titleRoot; // 0x338
	FairyGUI.GLabel itemName; // 0x340
	FairyGUI.GLoader iconLoader; // 0x348
	FairyGUI.GComponent itemInfoRoot; // 0x350
	FairyGUI.GTextField descTxt; // 0x358
	FairyGUI.GList itemList; // 0x360
	FairyGUI.GObject bgObj; // 0x368
	FairyGUI.GButton detailBtn; // 0x370
	FairyGUI.GComponent panelRoot; // 0x378
	System.Void OnInit(); // 0x060aff7c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x060b0340
	System.Void OnEnable(); // 0x060b03c0
	System.Void OnDisable(); // 0x060b0428
	System.Void OnDestroy(); // 0x060b04d4
	System.Void .ctor(); // 0x060b053c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EOpenSource : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EOpenSource RewardPop = 0;
	static WizardGames.Soc.SocClient.Ui.EOpenSource Other = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.OpenItemTipsParam : System.Object
{
	WizardGames.Soc.Common.CustomType.BaseItemNode baseItemNode; // 0x10
	WizardGames.Soc.SocClient.Ui.ComItemIcon comItemNode; // 0x18
	WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg; // 0x20
	WizardGames.Soc.Common.Data.resource.OBJGenaral objGenaralNode; // 0x28
	WizardGames.Soc.SocClient.Talent.TalentNode talentNode; // 0x30
	WizardGames.Soc.Common.Data.Reputation.ReputationSelectConfig reputationSelectConfig; // 0x38
	FairyGUI.GComponent clickCom; // 0x40
	FairyGUI.GComponent alignmentAnchorCom; // 0x48
	System.Action onItemNodeClear; // 0x50
	System.Boolean autoSide; // 0x58
	System.Boolean ignoreFirstTouchUp; // 0x59
	UnityEngine.Vector2 exactPosition; // 0x5c
	System.Boolean useSpecialSafeArea; // 0x64
	System.Single bottonDistance; // 0x68
	System.Boolean hideBtns; // 0x6c
	System.Boolean detailBtnVisible; // 0x6d
	System.Boolean skinBtnVisible; // 0x6e
	System.Int32 amount; // 0x70
	System.Action onHideCallback; // 0x78
	System.Int64 expireAt; // 0x80
	WizardGames.Soc.SocClient.Ui.EOpenSource openSource; // 0x88
	System.Boolean tipsAtIconLeft; // 0x8c
	System.Boolean isCurrency; // 0x8d
	System.Single offsetX; // 0x90
	System.Void InitProperty(); // 0x060b05c8
	System.Void .ctor(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode, FairyGUI.GComponent clickCom, FairyGUI.GComponent alignmentAnchorCom); // 0x060b0700
	System.Void .ctor(WizardGames.Soc.Common.Data.DataItem.ItemConfig itemNode, FairyGUI.GComponent clickCom, FairyGUI.GComponent alignmentAnchorCom); // 0x060b07d0
	System.Void .ctor(WizardGames.Soc.Common.Data.resource.OBJGenaral itemNode, FairyGUI.GComponent clickCom, FairyGUI.GComponent alignmentAnchorCom); // 0x060b08a0
	System.Void .ctor(WizardGames.Soc.Common.Data.Reputation.ReputationSelectConfig itemNode, FairyGUI.GComponent clickCom, FairyGUI.GComponent alignmentAnchorCom); // 0x060b0970
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTips : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	FairyGUI.GComponent comBg; // 0x338
	FairyGUI.GComponent comRoot; // 0x340
	FairyGUI.GComponent comTipsMain; // 0x348
	FairyGUI.GLoader loaderTipsSub; // 0x350
	FairyGUI.GObject closeMask; // 0x358
	WizardGames.Soc.SocClient.Ui.UiItemTipsMain tipsMain; // 0x360
	WizardGames.Soc.SocClient.Ui.UiItemTipsMain tipsSub; // 0x368
	WizardGames.Soc.SocClient.Ui.UiEquipItemTips tipsEquip; // 0x370
	FairyGUI.GGraph outsideDropArea; // 0x378
	System.Action onDropOnOutsideArea; // 0x380
	System.Action onItemNodeClear; // 0x388
	UnityEngine.Vector2 lastTipsPos; // 0x390
	WizardGames.Soc.SocClient.Ui.EOpenSource curOpenSource; // 0x398
	System.Action onHideTips; // 0x3a0
	System.Int64 curSetInstItemID; // 0x3a8
	System.Int64 curSetSystemIndex; // 0x3b0
	System.Int64 curSetContainerIndex; // 0x3b8
	System.Boolean disableUpdateInventory; // 0x3c0
	System.Boolean dirtyToUpdateInventory; // 0x3c1
	System.Boolean DirtyToHideWin; // 0x3c2
	static WizardGames.Soc.Common.CustomType.BaseItemNode <CurSetItemNode>k__BackingField; // 0x0
	static System.Int64 <CurSetItemTableId>k__BackingField; // 0x8
	static System.Int32 <CurSetResTableId>k__BackingField; // 0x10
	static System.Int32 <CurSetTalentTableId>k__BackingField; // 0x14
	static System.Single <MinX>k__BackingField; // 0x18
	static System.Single <MaxX>k__BackingField; // 0x1c
	static WizardGames.Soc.SocClient.Ui.ComItemIcon ShowRightMenu; // 0x20
	System.UInt32 lastClickComID; // 0x3c4
	System.Boolean ignoreFirstTouchUp; // 0x3c8
	System.Boolean clickOtherComWithoutClose; // 0x3c9
	static System.Boolean isFirstShowTips; // 0x28
	static SocLogger <Log>k__BackingField; // 0x30
	System.Single offsetX; // 0x3cc
	System.Single offsetY; // 0x3d0
	System.Single subTipsOffsetX; // 0x3d4
	static WizardGames.Soc.Common.CustomType.BaseItemNode get_CurSetItemNode(); // 0x060b0a40
	static System.Void set_CurSetItemNode(WizardGames.Soc.Common.CustomType.BaseItemNode value); // 0x060b0ac8
	static System.Void set_CurSetItemTableId(System.Int64 value); // 0x060b0b64
	static System.Void set_CurSetResTableId(System.Int32 value); // 0x060b0bf4
	static System.Void set_CurSetTalentTableId(System.Int32 value); // 0x060b0c84
	static System.Single get_MinX(); // 0x060b0d14
	static System.Void set_MinX(System.Single value); // 0x060b0d9c
	static System.Single get_MaxX(); // 0x060b0e38
	static System.Void set_MaxX(System.Single value); // 0x060b0ec0
	System.Void MakeFullScreen(); // 0x060b0f5c
	static SocLogger get_Log(); // 0x060b1010
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x060b1098
	System.Void OnInit(); // 0x060b1118
	System.Void OnMouseUp(FairyGUI.EventContext context); // 0x060b1934
	System.Void OnEnable(); // 0x060b1a88
	System.Void OnAddOneGuideToUIView(System.UInt32 parentUIUniqueID); // 0x060b1d9c
	System.Void OnDisable(); // 0x060b1f58
	System.Void OnTipsPanelClick(FairyGUI.EventContext ctx); // 0x060b2610
	System.Void MarkItemUpdate(); // 0x060b2694
	System.Void MarkItemUpdate(WizardGames.Soc.Common.CustomType.BaseItemNode node); // 0x060b26fc
	System.Void OnItemUpdate(); // 0x060b2884
	System.Void ClearCurItemInfo(); // 0x060b22ac
	System.Void SetItem(WizardGames.Soc.Common.CustomType.BaseItemNode item, System.Boolean hideSub, System.Boolean hideBtns); // 0x060b3290
	System.Void SetItemConfig(WizardGames.Soc.Common.Data.DataItem.ItemConfig item, System.Int32 amount, System.Boolean hideBtns); // 0x060b3818
	System.Void SetDetailButtonVisible(System.Boolean visible); // 0x060b399c
	System.Void SetSkinButtonVisible(System.Boolean visible); // 0x060b3a24
	System.Void SetResItem(WizardGames.Soc.Common.Data.resource.OBJGenaral item, System.Boolean blockGetWay); // 0x060b3aac
	System.Void RefreshResTime(System.Int64 expireAt, System.String timeLimitParam, System.Int32 timeLimitType); // 0x060b3d68
	System.Void SetTalentItem(WizardGames.Soc.SocClient.Talent.TalentNode item); // 0x060b3e14
	System.Void SetReputationSelectConfig(WizardGames.Soc.Common.Data.Reputation.ReputationSelectConfig selectConfig); // 0x060b4138
	System.Void PlaySubTipsAnim(System.Boolean isShow); // 0x060b41fc
	System.Boolean CheckAndLoadSubTips(); // 0x060b44ac
	System.Void SetSubTipsItem(WizardGames.Soc.Common.CustomType.BaseItemNode item, UnityEngine.Vector2 pos, System.Boolean rightSide); // 0x060b4750
	System.Void SetSubTipsItemConfig(WizardGames.Soc.Common.Data.DataItem.ItemConfig item, UnityEngine.Vector2 pos, System.Boolean rightSide); // 0x060b50e0
	System.Void SetSubTipsResItem(WizardGames.Soc.Common.Data.resource.OBJGenaral item, UnityEngine.Vector2 pos, System.String timeLimitParam, System.Int32 timeLimitType, System.Boolean rightSide); // 0x060b51e0
	System.Void SetSubTipsPos(UnityEngine.Vector2 globalPos, System.Boolean rightSide, FairyGUI.GComponent baseCom, System.Boolean autoSide); // 0x060b484c
	System.Void SetSubTipsVisible(System.Boolean show); // 0x060b3764
	System.Void SetMainTipsPos(WizardGames.Soc.SocClient.Ui.OpenItemTipsParam param); // 0x060b5330
	System.Void SetMainTipsPos(UnityEngine.Vector2 pos, System.Boolean directly, System.Boolean tipsAtPosLeft, FairyGUI.GComponent clickCom, FairyGUI.GComponent baseCom, System.Boolean autoSide); // 0x060b2bf8
	static System.Void OpenAndSetTips(System.Action<WizardGames.Soc.SocClient.Ui.UiItemTips> deal, FairyGUI.GComponent itemCom); // 0x060b5b44
	static System.Void ShowTips(WizardGames.Soc.SocClient.Ui.OpenItemTipsParam param); // 0x060b5e84
	static System.Boolean ParamDataEmpty(WizardGames.Soc.SocClient.Ui.OpenItemTipsParam param); // 0x060b616c
	System.Void SetWinTips(WizardGames.Soc.SocClient.Ui.OpenItemTipsParam param); // 0x060b6210
	static System.Void ShowSubTips<T>(T item, System.String timeLimitParam, System.Int32 timeLimitType); // 0x052af1f0
	static System.Void ShowSelectPart(WizardGames.Soc.Common.CustomType.BaseItemNode weapon, WizardGames.Soc.Common.CustomType.BaseItemNode part, WizardGames.Soc.Common.Data.DataItem.ItemSlot type, FairyGUI.GObject targetObj); // 0x060a8be4
	static System.Void ShowSelectBullet(WizardGames.Soc.Common.CustomType.BaseItemNode weapon, FairyGUI.GObject targetObj); // 0x060b62a0
	static System.Void HideTips(); // 0x0609b1c4
	static WizardGames.Soc.SocClient.Ui.UiItemTips HideSubTips(); // 0x060aba1c
	static WizardGames.Soc.SocClient.Ui.UiItemTips HideEquipTips(); // 0x060afa30
	System.Void OnFps10Update(System.Single dt); // 0x060b643c
	System.Void OnDropOnOutsideArea(FairyGUI.EventContext ctx); // 0x060b64f4
	System.Void SetOutsideDropArea(System.Boolean state, System.Action onDrop); // 0x060b65d0
	System.Void SetHideTipsCallback(System.Action onHide); // 0x060b6670
	System.Void InvokeHideTipsCallback(); // 0x060b63b4
	System.Void OnAnyIconDragStart(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem); // 0x060b66f0
	System.Void OnAnyIconDragEnd(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem, System.Boolean isDargValid); // 0x060b6778
	System.Void OnReloadBulletStart(WizardGames.Soc.Common.CustomType.BaseItemNode bulletNode); // 0x060b681c
	System.Void OnReloadBulletEnd(); // 0x060b68ac
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x060b6918
	System.Void .ctor(); // 0x060b69f4
	static System.Void .cctor(); // 0x060b6ad4
	System.Void <OnInit>b__54_0(WizardGames.Soc.Common.CustomType.BaseItemNode node); // 0x060b6b9c
	System.Void <PlaySubTipsAnim>b__72_0(); // 0x060b6c18
	System.Void <CheckAndLoadSubTips>b__73_0(System.Single y); // 0x060b6c80
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTips.<>c__DisplayClass83_0 : System.Object
{
	FairyGUI.GComponent itemCom; // 0x10
	System.Action<WizardGames.Soc.SocClient.Ui.UiItemTips> deal; // 0x18
	System.Void .ctor(); // 0x060b5e1c
	System.Void <OpenAndSetTips>b__0(WizardGames.Soc.SocClient.Ui.UiItemTips tips); // 0x060b6d5c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTips.<>c__DisplayClass84_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.OpenItemTipsParam param; // 0x10
	System.Void .ctor(); // 0x060b6104
	System.Void <ShowTips>b__0(WizardGames.Soc.SocClient.Ui.UiItemTips winTips); // 0x060b6e38
	System.Void <ShowTips>b__1(WizardGames.Soc.SocClient.Ui.UiItemTips winTips); // 0x060b6f50
	System.Void <ShowTips>b__2(WizardGames.Soc.SocClient.Ui.UiItemTips winTips); // 0x060b70c0
	System.Void <ShowTips>b__3(WizardGames.Soc.SocClient.Ui.UiItemTips winTips); // 0x060b71f8
	System.Void <ShowTips>b__4(WizardGames.Soc.SocClient.Ui.UiItemTips winTips); // 0x060b7350
	System.Void <ShowTips>b__5(WizardGames.Soc.SocClient.Ui.UiItemTips winTips); // 0x060b7448
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsAmmoInfo : System.Object
{
	FairyGUI.GComponent comRoot; // 0x10
	FairyGUI.Controller ctrlStyle; // 0x18
	FairyGUI.Controller ctrlJewelry; // 0x20
	FairyGUI.GComponent comEmpty; // 0x28
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x30
	FairyGUI.GLoader loaderAmmoType; // 0x38
	FairyGUI.GTextField textName; // 0x40
	FairyGUI.GTextField textAmount; // 0x48
	FairyGUI.GButton btnChange; // 0x50
	FairyGUI.GLoader hangingsIcon; // 0x58
	WizardGames.Soc.Common.CustomType.WeaponItemNode curWeapon; // 0x60
	WizardGames.Soc.Common.Data.DataItem.ItemConfig curAmmoCfg; // 0x68
	WizardGames.Soc.SocClient.Ui.UiItemTipsMain tipMain; // 0x70
	System.Boolean hasAmmo; // 0x78
	System.Int32 hangingsId; // 0x7c
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiItemTipsMain tipsMain, FairyGUI.GComponent root); // 0x060b7578
	System.Void SetData(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x060b7ae4
	System.Void OnDropItem(FairyGUI.EventContext ctx); // 0x060b8118
	System.Void OnClickHangings(FairyGUI.EventContext context); // 0x060b82c0
	System.Void OnClickEmpty(); // 0x060b8448
	System.Void OnClickAmmoInfo(FairyGUI.EventContext ctx); // 0x060b882c
	System.Void OnReloadBulletStart(WizardGames.Soc.Common.CustomType.BaseItemNode bulletNode); // 0x060b893c
	System.Void OnClickChangeBtn(FairyGUI.EventContext ctx); // 0x060b8a44
	System.Void .ctor(); // 0x060b8b4c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsAmmoInfo.<>c__DisplayClass21_0 : System.Object
{
	System.Boolean hasItem; // 0x10
	System.Collections.Generic.HashSet<System.Int64> avaliableAmmo; // 0x18
	System.Void .ctor(); // 0x060b8d5c
	System.Boolean <OnClickEmpty>b__0(WizardGames.Soc.Common.CustomType.BaseItemNode node); // 0x060b8dc4
	System.Boolean <OnClickEmpty>b__1(WizardGames.Soc.Common.CustomType.BaseItemNode node); // 0x060b8e88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsMain : System.Object
{
	FairyGUI.GGroup groupContent; // 0x10
	FairyGUI.GComponent comFlexibleScroll; // 0x18
	FairyGUI.GGroup groupFlexible; // 0x20
	FairyGUI.GGroup groupMovable; // 0x28
	FairyGUI.GObject imgTipsBG; // 0x30
	FairyGUI.GGraph fullDropArea; // 0x38
	WizardGames.Soc.SocClient.Ui.UiItemTipsTitle itemTitle; // 0x40
	FairyGUI.GComponent <root>k__BackingField; // 0x48
	FairyGUI.GComponent <flexibleRoot>k__BackingField; // 0x50
	FairyGUI.GComponent <movableRoot>k__BackingField; // 0x58
	FairyGUI.Controller isWeaponCtrl; // 0x60
	System.Boolean isSubTips; // 0x68
	WizardGames.Soc.Common.CustomType.BaseItemNode curItemNode; // 0x70
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.IItemTipsBoard> boards; // 0x78
	System.Single fLastSumBoardHeight; // 0x80
	System.Single fBgHeightOffset; // 0x84
	System.Single movableRootOriX; // 0x88
	System.Single groupContentOriX; // 0x8c
	System.Single yForCaculate; // 0x90
	System.Collections.Generic.List<System.String> <CustomData>k__BackingField; // 0x98
	System.Action<System.Single> OnApplyCaculateY; // 0xa0
	WizardGames.Soc.SocClient.Ui.UiItemTipsBoardLobbyResTitle uiItemTipsBoardLobbyResTitle; // 0xa8
	WizardGames.Soc.SocClient.Ui.UiItemTipsBoardLobbyResGetWay uiItemTipsBoardLobbyResGetWay; // 0xb0
	WizardGames.Soc.SocClient.Ui.UiItemTipsBoardLobbyFunctionBtns uiItemTipsBoardLobbyFunctionBtns; // 0xb8
	FairyGUI.Controller PlatformController; // 0xc0
	System.Boolean useSpecialSafeArea; // 0xc8
	System.Single bottonDistance; // 0xcc
	FairyGUI.GComponent get_root(); // 0x060b8f38
	System.Void set_root(FairyGUI.GComponent value); // 0x060b8f9c
	FairyGUI.GComponent get_flexibleRoot(); // 0x060b901c
	System.Void set_flexibleRoot(FairyGUI.GComponent value); // 0x060b9080
	FairyGUI.GComponent get_movableRoot(); // 0x060b9100
	System.Void set_movableRoot(FairyGUI.GComponent value); // 0x060b9164
	System.Single get_UiRootScale(); // 0x060b91e4
	System.Boolean get_Visible(); // 0x060b9398
	System.Void set_Visible(System.Boolean value); // 0x060b9484
	System.Void set_CustomData(System.Collections.Generic.List<System.String> value); // 0x060b9550
	System.Void Bind(FairyGUI.GComponent root, System.Boolean isSubTips); // 0x060b95d0
	System.Boolean ForeachBoards(System.Action<WizardGames.Soc.SocClient.Ui.IItemTipsBoard> call); // 0x060bae54
	System.Void SetDetailButtonVisible(System.Boolean visible); // 0x060bb110
	System.Void SetSkinButtonVisible(System.Boolean visible); // 0x060bb21c
	System.Void SetItem(WizardGames.Soc.Common.CustomType.BaseItemNode item, System.Boolean moveableVisible); // 0x060bb444
	System.Void SetItemConfig(WizardGames.Soc.Common.Data.DataItem.ItemConfig item, System.Int32 amount, System.Boolean moveableVisible); // 0x060bc0e0
	System.Void SetResItem(WizardGames.Soc.Common.Data.resource.OBJGenaral item); // 0x060bc310
	System.Void SetResGetWay(System.Boolean blockGetWay); // 0x060bc5b0
	System.Void SetTalentItem(WizardGames.Soc.SocClient.Talent.TalentNode item); // 0x060bc66c
	System.Void SetReputationSelectConfig(WizardGames.Soc.Common.Data.Reputation.ReputationSelectConfig selectConfig); // 0x060bcaec
	System.Void RefreshResTitle(System.String timeLimitParam, System.Int64 time, System.Int32 timeLimitType); // 0x060bceb4
	System.Void ApplyCaculateY(); // 0x060bcf60
	System.Void UpdateFlexibleBounds(); // 0x060bd080
	System.Void UpdateMovableBounds(); // 0x060bd248
	System.Boolean GetMovableVisible(); // 0x060bd410
	System.Void UpdateRootBounds(System.Boolean keepPos); // 0x060bd4fc
	System.Void StartAdjustSize(); // 0x060bc060
	System.Void AdjustTipsPosOnTipsChange(); // 0x060bdd04
	System.Void AdjustFlexibleAreaHeight(); // 0x060bd59c
	System.Void CheckAndSetFlexibleToMin(); // 0x060bb674
	System.Void OnDropOnFullDropArea(FairyGUI.EventContext ctx); // 0x060bdfe0
	System.Void OnAnyIconDragStart(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x060be25c
	System.Void OnAnyIconDragEnd(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem, System.Boolean isDargValid); // 0x060be3c8
	System.Void OnReloadBulletStart(WizardGames.Soc.Common.CustomType.BaseItemNode bulletNode); // 0x060be458
	System.Void OnClickOnTips(); // 0x060be564
	System.Void OnEnable(); // 0x060be77c
	System.Void OnDisable(); // 0x060bea1c
	System.Void UnChooseAllIcons(); // 0x060be640
	System.Void .ctor(); // 0x060bec64
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsMain.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiItemTipsMain.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__50_0; // 0x8
	static System.Action<WizardGames.Soc.SocClient.Ui.IItemTipsBoard> <>9__76_0; // 0x10
	static System.Action<WizardGames.Soc.SocClient.Ui.IItemTipsBoard> <>9__77_0; // 0x18
	static System.Action<WizardGames.Soc.SocClient.Ui.IItemTipsBoard> <>9__78_0; // 0x20
	static System.Void .cctor(); // 0x060beccc
	System.Void .ctor(); // 0x060bed30
	System.Void <Bind>b__50_0(FairyGUI.EventContext ctx); // 0x060bed98
	System.Void <OnEnable>b__76_0(WizardGames.Soc.SocClient.Ui.IItemTipsBoard board); // 0x060bee10
	System.Void <OnDisable>b__77_0(WizardGames.Soc.SocClient.Ui.IItemTipsBoard board); // 0x060beef8
	System.Void <UnChooseAllIcons>b__78_0(WizardGames.Soc.SocClient.Ui.IItemTipsBoard board); // 0x060befe0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsMain.<>c__DisplayClass50_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiItemTipsMain <>4__this; // 0x10
	System.Boolean isSubTips; // 0x18
	System.Void .ctor(); // 0x060ba6cc
	System.Void <Bind>b__1(WizardGames.Soc.SocClient.Ui.IItemTipsBoard board); // 0x060bf0c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsMain.<>c__DisplayClass54_0 : System.Object
{
	WizardGames.Soc.Common.CustomType.BaseItemNode item; // 0x10
	System.Void .ctor(); // 0x060bb60c
	System.Void <SetItem>b__0(WizardGames.Soc.SocClient.Ui.IItemTipsBoard board); // 0x060bf1c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsMain.<>c__DisplayClass55_0 : System.Object
{
	WizardGames.Soc.Common.Data.DataItem.ItemConfig item; // 0x10
	System.Void .ctor(); // 0x060bc2a8
	System.Void <SetItemConfig>b__0(WizardGames.Soc.SocClient.Ui.IItemTipsBoard board); // 0x060bf2c8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsMain.<>c__DisplayClass56_0 : System.Object
{
	WizardGames.Soc.Common.Data.resource.OBJGenaral item; // 0x10
	System.Void .ctor(); // 0x060bc4c0
	System.Void <SetResItem>b__0(WizardGames.Soc.SocClient.Ui.IItemTipsBoard board); // 0x060bf3bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsMain.<>c__DisplayClass58_0 : System.Object
{
	WizardGames.Soc.SocClient.Talent.TalentNode item; // 0x10
	System.Void .ctor(); // 0x060bc824
	System.Void <SetTalentItem>b__0(WizardGames.Soc.SocClient.Ui.IItemTipsBoard board); // 0x060bf4a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsMain.<>c__DisplayClass59_0 : System.Object
{
	WizardGames.Soc.Common.Data.Reputation.ReputationSelectConfig selectConfig; // 0x10
	System.Void .ctor(); // 0x060bcca4
	System.Void <SetReputationSelectConfig>b__0(WizardGames.Soc.SocClient.Ui.IItemTipsBoard board); // 0x060bf584
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsTitle : System.Object
{
	FairyGUI.GComponent root; // 0x10
	WizardGames.Soc.SocClient.Ui.ComAutoIcon itemIcon; // 0x18
	WizardGames.Soc.SocClient.Ui.ComMarquee textName; // 0x20
	FairyGUI.Controller ctrlTitle; // 0x28
	FairyGUI.GComponent comLabelBroken; // 0x30
	FairyGUI.GComponent comLabelRare; // 0x38
	FairyGUI.GComponent comLabelType; // 0x40
	FairyGUI.GTextField textType; // 0x48
	WizardGames.Soc.Common.Data.DataItem.ItemConfig tbItem; // 0x50
	WizardGames.Soc.SocClient.Ui.UiItemTipsAmmoInfo ammoInfo; // 0x58
	FairyGUI.GButton btnDetail; // 0x60
	FairyGUI.GButton btnSkin; // 0x68
	FairyGUI.GTextField haveTxt; // 0x70
	FairyGUI.Controller ctrlTalent; // 0x78
	FairyGUI.GLoader penetratingLvLoader; // 0x80
	FairyGUI.GTextField penetratingLvTxt; // 0x88
	System.Boolean isSubTips; // 0x90
	System.Void .ctor(System.Boolean isSubTips); // 0x060ba734
	System.Void Bind(WizardGames.Soc.SocClient.Ui.UiItemTipsMain tipsMain, FairyGUI.GComponent root); // 0x060ba7bc
	System.Void OnBtnSkinClick(); // 0x060bf668
	System.Void ResetShareSkin(System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> resetItemList); // 0x060bfd20
	System.Void OpenSkinWnd(); // 0x060bfbb4
	System.Void SetRootVisible(System.Boolean isShow); // 0x060bc528
	System.Void SetDetailButtonVisible(System.Boolean visible); // 0x060bb194
	System.Void SetSkinButtonVisible(System.Boolean visible); // 0x060bb2a0
	System.Void SetItem(WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg, WizardGames.Soc.Common.CustomType.BaseItemNode itemInst, System.Int32 amount); // 0x060bb6e8
	System.Void SetPenetratingLvUI(WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg, WizardGames.Soc.Common.CustomType.BaseItemNode instItemNode); // 0x060c0038
	System.Int32 GetPenetratingLv(WizardGames.Soc.Common.Data.DataItem.ItemConfig itemCfg, WizardGames.Soc.Common.CustomType.BaseItemNode instItemNode); // 0x060c0178
	System.Int32 GetPenetratingLv_Tool(System.Int64 itemCfgID); // 0x060c02cc
	System.Int32 GetPenetratingLv_Weapon_Hold(System.Int64 itemCfgID); // 0x060c083c
	System.Int32 GetPenetratingLv_Weapon_Part(System.Int64 itemCfgID); // 0x060c0948
	System.Int32 GetPenetratingLv_Weapon_Throw(System.Int64 itemCfgID); // 0x060c0a54
	System.Int32 GetPenetratingLv_Ammo(System.Int64 itemCfgID); // 0x060c0b60
	System.Int32 GetPenetratingLv_Weapon_Gun(System.Int64 itemCfgID, WizardGames.Soc.Common.CustomType.BaseItemNode instItemNode); // 0x060c03d8
	System.Void SetItem(WizardGames.Soc.SocClient.Talent.TalentNode item); // 0x060bc88c
	System.Void SetItem(WizardGames.Soc.Common.Data.Reputation.ReputationSelectConfig item); // 0x060bcd0c
	System.Void OnReloadBulletStart(WizardGames.Soc.Common.CustomType.BaseItemNode bulletNode); // 0x060be4dc
	System.Void <Bind>b__20_0(); // 0x060c0c6c
	System.Void <Bind>b__20_1(); // 0x060c0d88
	System.Boolean <SetItem>b__27_0(WizardGames.Soc.Common.Data.DataItem.SkinConfig s); // 0x060c0ec0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemTipsTitle.<>c__DisplayClass21_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiItemTipsTitle <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x18
	System.Void .ctor(); // 0x060bfb4c
	System.Void <OnBtnSkinClick>b__0(); // 0x060c0f68
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.JumpData : System.Object
{
	System.Int32 rid; // 0x10
	System.Int32 firstTabId; // 0x14
	System.Int32 secondTabId; // 0x18
	System.Int32 selectNodeId; // 0x1c
	System.Void .ctor(); // 0x060c10e4
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Ui.IJumpToUIWindow : 
{
	
	System.Void JumpToUIWindow(WizardGames.Soc.SocClient.Ui.JumpData jumpData); // 0x05523a54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemGetWay : System.Object
{
	FairyGUI.GComponent comItemWay; // 0x10
	FairyGUI.GList itemWayList; // 0x18
	System.Int32 rid; // 0x20
	System.Void Bind(FairyGUI.GComponent itemWay); // 0x060c114c
	System.Void SetRootVisible(System.Boolean isVisible); // 0x060c128c
	System.Void SetData(System.Int32 rid); // 0x060c1314
	System.Void RenderItemWay(System.Int32 index, FairyGUI.GObject obj); // 0x060c1480
	System.Void .ctor(); // 0x060c1808
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiItemGetWay.<>c__DisplayClass6_0 : System.Object
{
	System.Int32 jumpResourceID; // 0x10
	System.Void .ctor(); // 0x060c17a0
	System.Void <RenderItemWay>b__0(); // 0x060c1870
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EKatyushaState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EKatyushaState None = 0;
	static WizardGames.Soc.SocClient.Ui.EKatyushaState LackMissiles = 1;
	static WizardGames.Soc.SocClient.Ui.EKatyushaState LackModule = 2;
	static WizardGames.Soc.SocClient.Ui.EKatyushaState ReadyFire = 3;
	static WizardGames.Soc.SocClient.Ui.EKatyushaState Aiming = 4;
	static WizardGames.Soc.SocClient.Ui.EKatyushaState CanFire = 5;
	static WizardGames.Soc.SocClient.Ui.EKatyushaState Firing = 6;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiKatyusha : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update, WizardGames.Soc.Common.Unity.Ui.IUiStopLooting, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	static SocLogger log; // 0x0
	System.String StartSnowFlakeSound; // 0x338
	System.String SnowFlakeSound; // 0x340
	System.String EndSnowFlakeSound; // 0x348
	FairyGUI.GButton btnInsertModule; // 0x350
	FairyGUI.GButton btnScreenModule; // 0x358
	System.Int32 _moduleCdTime; // 0x360
	FairyGUI.GButton btnLoadMissiles; // 0x368
	FairyGUI.GButton btnScreenLoadMissile; // 0x370
	FairyGUI.GButton btnUnLoadMissiles; // 0x378
	FairyGUI.GButton btnFire; // 0x380
	FairyGUI.GObject moduleTipPos; // 0x388
	FairyGUI.GObject missileTipPos; // 0x390
	FairyGUI.GObject moduleMissBg; // 0x398
	FairyGUI.GObject missileMissBg; // 0x3a0
	FairyGUI.GComponent moduleFinish; // 0x3a8
	FairyGUI.GComponent missileFinish; // 0x3b0
	FairyGUI.GTextField moduleText; // 0x3b8
	FairyGUI.GTextField missileText; // 0x3c0
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x3c8
	FairyGUI.GImage btnFireBac; // 0x3d0
	FairyGUI.GImage btnModuleBac; // 0x3d8
	FairyGUI.GImage btnMissilebac; // 0x3e0
	FairyGUI.GComponent comReadyFire; // 0x3e8
	WizardGames.Soc.Common.Entity.KatyushaEntity katyushaEntity; // 0x3f0
	WizardGames.Soc.SocClient.Go.KatyushaGo katyushaGo; // 0x3f8
	FairyGUI.GComponent comMissModule; // 0x400
	FairyGUI.GTextField errorCode; // 0x408
	FairyGUI.GTextField errorResult; // 0x410
	FairyGUI.GComponent[] comBlock; // 0x418
	FairyGUI.GComponent comMissileNotLoad; // 0x420
	FairyGUI.Transition showNotMissile; // 0x428
	FairyGUI.Transition hideNotMissile; // 0x430
	FairyGUI.Transition showMissModule; // 0x438
	FairyGUI.Transition hideMissModule; // 0x440
	FairyGUI.Transition showMissilePanel; // 0x448
	FairyGUI.Transition hideMissilePanel; // 0x450
	FairyGUI.GComponent comModuleState; // 0x458
	FairyGUI.GMovieClip movieModuleDamage; // 0x460
	FairyGUI.GMovieClip movieAddModule; // 0x468
	FairyGUI.GMovieClip movieModuleIncd; // 0x470
	FairyGUI.GComponent comMissilePanel; // 0x478
	FairyGUI.GList comMissileListLeft; // 0x480
	FairyGUI.GList comMissileListRight; // 0x488
	FairyGUI.GComponent comMissileNode; // 0x490
	FairyGUI.GTextField missileCount; // 0x498
	FairyGUI.GTextField userName; // 0x4a0
	WizardGames.Soc.SocClient.Ui.EKatyushaState nowState; // 0x4a8
	System.Int32 lastMissileCount; // 0x4ac
	System.Single lastMissileLaunchTime; // 0x4b0
	System.Int32 waitMissileOrder; // 0x4b4
	FairyGUI.GImage[] progressImg; // 0x4b8
	FairyGUI.Controller controller; // 0x4c0
	UnityEngine.Vector3 justBombPos; // 0x4c8
	FairyGUI.Transition showUIAnim; // 0x4d8
	FairyGUI.Transition hideUIAnim; // 0x4e0
	FairyGUI.Transition hideMapAnim; // 0x4e8
	FairyGUI.GComponent comModuleFire; // 0x4f0
	System.Single lastDropCarTime; // 0x4f8
	System.Boolean mIsIncd; // 0x4fc
	UnityEngine.Color colorBlack; // 0x500
	UnityEngine.Color colorYellow; // 0x510
	UnityEngine.Vector3 targetPos; // 0x520
	FairyGUI.GLoader moduleIcon; // 0x530
	FairyGUI.GLoader missileIcon; // 0x538
	static System.String waitShowReadyTipStr; // 0x8
	System.Int64 missileProgressCbHandle; // 0x540
	System.String ModuleIcon; // 0x548
	System.String MissileIcon; // 0x550
	System.String MissileFlyIcon; // 0x558
	System.String MissileBombUrl; // 0x560
	System.Collections.Generic.Dictionary<System.Int64,FairyGUI.GComponent> mMissilesMarkers; // 0x568
	System.Collections.Generic.List<FairyGUI.GComponent> mMissilesMarkersPool; // 0x570
	FairyGUI.GComponent mMissileBombCom; // 0x578
	System.Int32 mFirstMissileIconRenderIndex; // 0x580
	WizardGames.Soc.SocClient.Ui.UiKatyushaMissileContainer missileContainer; // 0x588
	WizardGames.Soc.SocClient.Ui.UiKatyushaLoadMissile loadMissile; // 0x590
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap moduleContainer; // 0x598
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap missilesContainer; // 0x5a0
	WizardGames.Soc.Common.CustomType.StackableItemNode missileItem; // 0x5a8
	System.Single readyFireTime; // 0x5b0
	WizardGames.Soc.SocClient.Ui.Map.KatyushaMap katyushaMap; // 0x5b8
	System.Boolean mIsPreviewMode; // 0x5c0
	System.String noModuleCodeStr; // 0x5c8
	System.String noModuleResultStr; // 0x5d0
	System.String katyushaInsertModuleStr; // 0x5d8
	System.String katyushaFiringStr; // 0x5e0
	System.String katyushaRemoveModuleStr; // 0x5e8
	System.String katyushaNoModuleStr; // 0x5f0
	System.String katyushaLoadMissilesStr; // 0x5f8
	System.String katyushaCoolDownStr; // 0x600
	System.String katyushaCannotFireStr; // 0x608
	System.String katyushaReadyStr; // 0x610
	System.String katyushaFireStr; // 0x618
	System.String katyushaAimingStr; // 0x620
	System.Single kSeconds; // 0x628
	System.Single kMinute; // 0x62c
	WizardGames.Soc.SocClient.Ui.EKatyushaState get_NowState(); // 0x060c1a18
	System.Boolean get_IsPreviewMode(); // 0x060c1a7c
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x060c1ae0
	System.Void OnInit(); // 0x060c1b60
	System.Void InitLanguageText(); // 0x060c4e58
	System.Void UpdateAimingModuleState(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Boolean oldValue, System.Boolean newValue); // 0x060c5058
	System.Void UpdateKatyushaState(); // 0x060c592c
	System.Void UpdateIsLaunchingState(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Boolean oldValue, System.Boolean newValue); // 0x060c5db8
	System.Void UpdateMissileCount(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int32 oldValue, System.Int32 newValue); // 0x060c5e84
	System.Void HideTips(); // 0x060c61cc
	System.Void ShowModuelConfig(); // 0x060c6254
	System.Void ShowMissileConfig(); // 0x060c63f4
	System.Void OnCreateEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x060c6594
	FairyGUI.GComponent getMissileNode(System.Int32 index); // 0x060c4d74
	System.Void OnRemoveEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x060c6b34
	System.Void ShowMissileBombUI(WizardGames.Soc.Common.Entity.MissileEntity entity); // 0x060c6d1c
	System.Void OnLaunchFinish(); // 0x060c71dc
	System.Void ReleaseMissileMark(System.Int64 entityID); // 0x060c7084
	static WizardGames.Soc.SocClient.Ui.UiKatyusha OpenKatyushaWin(System.Int64 collectionID); // 0x060c74e0
	System.Void InitData(); // 0x060c77a8
	System.Void OnEnable(); // 0x060c7884
	System.Void KatyushaStateChange(WizardGames.Soc.SocClient.Ui.EKatyushaState preState, WizardGames.Soc.SocClient.Ui.EKatyushaState nowState); // 0x060c85c8
	System.Void UpdateFlyingMissileNum(); // 0x060c9a28
	System.Void UpdateKatyushaCdState(System.Boolean inCd); // 0x060c9b30
	System.Void OnDisable(); // 0x060c9e24
	System.Void OnDestroy(); // 0x060ca4dc
	System.Void OnFps1Update(System.Single dt); // 0x060caa44
	System.Void OnFps30Update(System.Single dt); // 0x060caacc
	System.Void UpdateModuleCdTime(System.Single dt); // 0x060cab60
	System.Void OnFps10Update(System.Single dt); // 0x060cac04
	System.Void OnMapScaleChanged(System.Single oldScale, System.Single newScale); // 0x060cb7d4
	System.Void UpdateMissilePos(); // 0x060caf1c
	System.Void DropCar(); // 0x060cb854
	System.Void OnDropCar(); // 0x060cb9e0
	WizardGames.Soc.SocClient.Ui.EKatyushaState JudgeState(System.Single dt); // 0x060c5a10
	System.Void OnShowReadyTips(System.Int64 timerId, System.Object data, System.Boolean needDelete); // 0x060cbd50
	System.Void InsertModule(); // 0x060cbe14
	System.Void RemoveModule(); // 0x060cc358
	System.Void ShowMsgTipsModuleCd(); // 0x060cc248
	System.Void ShowMsgTipsNoModule(); // 0x060cc7d4
	System.Void ShowMsgTipsNoMissile(); // 0x060cc9a4
	System.Void ShowMsgTipsInCd(); // 0x060ccb74
	System.Void ShowMsgTipsFiring(); // 0x060ccd44
	System.Void LoadMissiles(System.Boolean load); // 0x060ccf14
	System.Void OnClickAim(UnityEngine.Vector3 pos, System.Boolean isFiring); // 0x060cd478
	System.Void OnClickFire(); // 0x060cd64c
	System.Void MissileProgressCb(); // 0x060cb50c
	System.Void OnStateLackMissiles(); // 0x060c945c
	System.Boolean CheckBagHasModule(); // 0x060cd890
	System.Void OnStateLackModule(); // 0x060c9218
	System.Void OnStateReadyFire(); // 0x060c9648
	System.Void OnStateAiming(); // 0x060c975c
	System.Void OnStateCanFire(); // 0x060c97d0
	System.Void OnHideMissModuleComplete(); // 0x060cd940
	System.Void OnStateFiring(); // 0x060c98b0
	System.Void CreateMissileMarker(WizardGames.Soc.Common.Entity.MissileEntity entity); // 0x060c685c
	System.Void UpdateModuleBtnStatus(); // 0x060c5430
	System.Void UpdateLoadMissileBtnStatus(); // 0x060c8784
	System.Void UpdateFireBtnStatus(); // 0x060c8a60
	System.Void UpdateModuleStatus(); // 0x060c5354
	System.Void UpdateTextReadyFireStatus(); // 0x060c918c
	System.String GetCDTime(System.Int64 millisecond); // 0x060cd9c8
	System.Void SetOperateBtnShowStatus(System.Boolean isPreviewMode); // 0x060c83d4
	System.Void OnFastReconnected(); // 0x060cdbf4
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x060cdefc
	System.Void OnClickCloseBtn(); // 0x060c7320
	System.Void StopLooting(); // 0x060cdfd4
	System.Void .ctor(); // 0x060ce108
	static System.Void .cctor(); // 0x060ce464
	System.Void <OnInit>b__100_0(); // 0x060ce568
	System.Void <OnInit>b__100_1(); // 0x060ce5d0
	System.Void <OnInit>b__100_2(); // 0x060ce770
	System.Void <UpdateAimingModuleState>b__102_0(); // 0x060ce888
	System.Void <UpdateFlyingMissileNum>b__119_0(); // 0x060ce91c
	System.Void <UpdateKatyushaCdState>b__120_0(); // 0x060ce990
	System.Void <UpdateKatyushaCdState>b__120_1(); // 0x060cea04
	System.Void <UpdateModuleBtnStatus>b__153_0(); // 0x060cea78
	System.Void <UpdateModuleBtnStatus>b__153_1(); // 0x060ceadc
	System.Void <UpdateModuleBtnStatus>b__153_2(FairyGUI.EventContext _); // 0x060ceb40
	System.Void <UpdateLoadMissileBtnStatus>b__154_0(); // 0x060cebb8
	System.Void <UpdateLoadMissileBtnStatus>b__154_1(); // 0x060cec1c
	System.Void <UpdateLoadMissileBtnStatus>b__154_2(); // 0x060cec80
	System.Void <UpdateLoadMissileBtnStatus>b__154_3(); // 0x060cece4
	System.Void <UpdateFireBtnStatus>b__155_4(); // 0x060ced4c
	System.Void <UpdateFireBtnStatus>b__155_0(); // 0x060cedb0
	System.Void <UpdateFireBtnStatus>b__155_1(); // 0x060cee14
	System.Void <UpdateFireBtnStatus>b__155_2(); // 0x060cee78
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiKatyusha.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiKatyusha.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__155_3; // 0x8
	static System.Void .cctor(); // 0x060ceedc
	System.Void .ctor(); // 0x060cef40
	System.Void <UpdateFireBtnStatus>b__155_3(); // 0x060cefa8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiKatyusha.<>c__DisplayClass133_0 : System.Object
{
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> listNode; // 0x10
	System.Void .ctor(); // 0x060cc1e0
	System.Boolean <InsertModule>b__0(WizardGames.Soc.Common.CustomType.BaseItemNode itemNode); // 0x060cf170
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiKatyushaLoadMissile : System.Object
{
	static SocLogger logger; // 0x0
	FairyGUI.GComponent node; // 0x10
	FairyGUI.GComponent SliderCom; // 0x18
	WizardGames.Soc.SocClient.Ui.ComItemIcon missileIcon; // 0x20
	FairyGUI.GTextField name; // 0x28
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x30
	FairyGUI.GComponent compCountInfo; // 0x38
	FairyGUI.GTextField txtOwnCount; // 0x40
	FairyGUI.GTextField txtCanPutCount; // 0x48
	FairyGUI.GTextField txtCanPutDesc; // 0x50
	FairyGUI.Transition showUIAnim; // 0x58
	FairyGUI.Transition hideUIAnim; // 0x60
	FairyGUI.GSlider slider; // 0x68
	FairyGUI.GButton btnLess; // 0x70
	FairyGUI.GButton btnMore; // 0x78
	System.Void .ctor(FairyGUI.GComponent content); // 0x060c42a0
	System.Void ChangeSliderValue(System.Int32 num); // 0x060cf284
	System.Void OnClickClose(); // 0x060cf4e8
	System.Void OnHideUIAnimComplete(); // 0x060cf5a4
	static System.Void .cctor(); // 0x060cf658
	System.Void <.ctor>b__17_0(); // 0x060cf72c
	System.Void <.ctor>b__17_1(); // 0x060cf790
	System.Void <.ctor>b__17_2(); // 0x060cf7f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiKatyushaMini : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	static SocLogger log; // 0x0
	System.String StartSnowFlakeSound; // 0x338
	System.String SnowFlakeSound; // 0x340
	System.String EndSnowFlakeSound; // 0x348
	FairyGUI.GButton btnInsertModule; // 0x350
	FairyGUI.GButton btnScreenModule; // 0x358
	FairyGUI.GButton btnLoadMissiles; // 0x360
	FairyGUI.GButton btnScreenLoadMissile; // 0x368
	FairyGUI.GButton btnFire; // 0x370
	FairyGUI.GObject moduleTipPos; // 0x378
	FairyGUI.GObject missileTipPos; // 0x380
	FairyGUI.GObject moduleMissBg; // 0x388
	FairyGUI.GObject missileMissBg; // 0x390
	FairyGUI.GComponent moduleFinish; // 0x398
	FairyGUI.GComponent missileFinish; // 0x3a0
	FairyGUI.GTextField moduleText; // 0x3a8
	FairyGUI.GTextField missileText; // 0x3b0
	FairyGUI.GImage btnModuleBac; // 0x3b8
	FairyGUI.GImage btnMissilebac; // 0x3c0
	FairyGUI.GComponent comReadyFire; // 0x3c8
	WizardGames.Soc.SocClient.Go.KatyushaGo katyushaGo; // 0x3d0
	FairyGUI.GComponent comMissModule; // 0x3d8
	FairyGUI.GTextField errorCode; // 0x3e0
	FairyGUI.GTextField errorResult; // 0x3e8
	FairyGUI.Transition showMapAnim; // 0x3f0
	FairyGUI.Transition hideMapAnim; // 0x3f8
	FairyGUI.GComponent[] comBlock; // 0x400
	FairyGUI.GComponent comMissileNotLoad; // 0x408
	FairyGUI.Transition showNotMissile; // 0x410
	FairyGUI.Transition hideNotMissile; // 0x418
	FairyGUI.Transition showMissModule; // 0x420
	FairyGUI.Transition hideMissModule; // 0x428
	FairyGUI.Transition showMissilePanel; // 0x430
	FairyGUI.Transition hideMissilePanel; // 0x438
	FairyGUI.GComponent comModuleState; // 0x440
	FairyGUI.GMovieClip movieModuleDamage; // 0x448
	FairyGUI.GMovieClip movieAddModule; // 0x450
	FairyGUI.GMovieClip movieModuleIncd; // 0x458
	FairyGUI.GComponent comMissilePanel; // 0x460
	FairyGUI.GList comMissileListLeft; // 0x468
	FairyGUI.GList comMissileListRight; // 0x470
	FairyGUI.GTextField missileCount; // 0x478
	WizardGames.Soc.SocClient.Ui.EKatyushaState nowState; // 0x480
	System.Int32 lastMissileCount; // 0x484
	System.Single lastMissileLaunchTime; // 0x488
	System.Int32 waitMissileOrder; // 0x48c
	FairyGUI.GImage[] progressImg; // 0x490
	FairyGUI.Controller controller; // 0x498
	UnityEngine.Vector3 justBombPos; // 0x4a0
	FairyGUI.Transition showUIAnim; // 0x4b0
	FairyGUI.Transition hideUIAnim; // 0x4b8
	FairyGUI.GComponent comModuleFire; // 0x4c0
	FairyGUI.GImage mapTexture; // 0x4c8
	System.Boolean mIsIncd; // 0x4d0
	UnityEngine.Color colorBlack; // 0x4d4
	UnityEngine.Color colorYellow; // 0x4e4
	FairyGUI.GComponent _comMapGuide; // 0x4f8
	FairyGUI.GLoader _lineIcon; // 0x500
	FairyGUI.GImage _icon; // 0x508
	FairyGUI.GImage _n24; // 0x510
	FairyGUI.GImage _progressBar; // 0x518
	UnityEngine.Vector3 targetPos; // 0x520
	FairyGUI.GLoader moduleIcon; // 0x530
	FairyGUI.GLoader missileIcon; // 0x538
	System.Int64 missileProgressCbHandle; // 0x540
	System.String ModuleIcon; // 0x548
	System.String MissileIcon; // 0x550
	System.String MissileFlyIcon; // 0x558
	System.String MissileBombUrl; // 0x560
	System.Collections.Generic.Dictionary<System.Int64,FairyGUI.GComponent> mMissilesMarkers; // 0x568
	System.Collections.Generic.List<FairyGUI.GComponent> mMissilesMarkersPool; // 0x570
	FairyGUI.GComponent mMissileBombCom; // 0x578
	WizardGames.Soc.SocClient.Ui.UiKatyushaMissileContainer missileContainer; // 0x580
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap moduleContainer; // 0x588
	WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap missilesContainer; // 0x590
	System.Single readyFireTime; // 0x598
	System.Boolean mIsPreviewMode; // 0x59c
	System.String noModuleCodeStr; // 0x5a0
	System.String noModuleResultStr; // 0x5a8
	System.String katyushaInsertModuleStr; // 0x5b0
	System.String katyushaFiringStr; // 0x5b8
	System.String katyushaRemoveModuleStr; // 0x5c0
	System.String katyushaNoModuleStr; // 0x5c8
	System.String katyushaLoadMissilesStr; // 0x5d0
	System.String katyushaCoolDownStr; // 0x5d8
	System.String katyushaCannotFireStr; // 0x5e0
	System.String katyushaReadyStr; // 0x5e8
	System.String katyushaFireStr; // 0x5f0
	System.String katyushaAimingStr; // 0x5f8
	FairyGUI.GComponent bg; // 0x600
	System.Boolean get_IsPreviewMode(); // 0x060cf860
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x060cf8c4
	System.Void OnInit(); // 0x060cf944
	System.Void ShowLineIcon(System.Boolean visible); // 0x060d10f0
	System.Void OnTouchBegin(FairyGUI.EventContext context); // 0x060d11d8
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x060d142c
	FairyGUI.GComponent getMissileNode(System.Int32 index); // 0x060d0e0c
	System.Void InitLanguageText(); // 0x060d0ef0
	System.Void UpdateAimingModuleState(System.Boolean has); // 0x060d14ec
	System.Void UpdateKatyushaState(); // 0x060d1718
	System.Void UpdateMissileCount(System.Int32 value); // 0x060d1874
	System.Void HideTips(); // 0x060d1a50
	System.Void ShowModuelConfig(); // 0x060d1ad8
	System.Void ShowMissileConfig(); // 0x060d1c78
	System.Void OnCreateEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x060d1e18
	System.Void OnRemoveEntity(WizardGames.Soc.Common.Entity.IEntity entity); // 0x060d2240
	System.Void ShowMissileBombUI(WizardGames.Soc.Common.Entity.MissileEntity entity); // 0x060d2428
	System.Void HideMap(); // 0x060d2948
	System.Void ShowMap(); // 0x060d29bc
	System.Void OnLaunchFinish(); // 0x060d28e8
	System.Void ReleaseMissileMark(System.Int64 entityID); // 0x060d2790
	System.Void InitData(); // 0x060d2a30
	System.Void OnEnable(); // 0x060d2b0c
	System.Void UpdateMission(); // 0x060d35bc
	System.Void KatyushaStateChange(WizardGames.Soc.SocClient.Ui.EKatyushaState preState, WizardGames.Soc.SocClient.Ui.EKatyushaState nowState); // 0x060d3824
	System.Void UpdateFlyingMissileNum(); // 0x060d45c4
	System.Void UpdateKatyushaCdState(System.Boolean inCd); // 0x060d46cc
	System.Void OnDisable(); // 0x060d49b0
	System.Void OnDestroy(); // 0x060d5110
	System.Void OnFps10Update(System.Single dt); // 0x060d51cc
	System.Void UpdateMissilePos(); // 0x060d5580
	WizardGames.Soc.SocClient.Ui.EKatyushaState JudgeState(System.Single dt); // 0x060d17fc
	System.Void RemoveModule(); // 0x060d58a8
	System.Void ShowMsgTipsNoModule(); // 0x060d5908
	System.Void ShowMsgTipsInCd(); // 0x060d5ad8
	System.Void ShowMsgTipsFiring(); // 0x060d5ca8
	System.Void LoadMissiles(); // 0x060d5e78
	System.Void OnClickAim(UnityEngine.Vector3 pos, System.Boolean isFiring); // 0x060d5fb8
	System.Void OnClickFire(); // 0x060d616c
	System.Void OnStateLackMissiles(); // 0x060d4054
	System.Void OnStateLackModule(); // 0x060d3e10
	System.Void OnStateReadyFire(); // 0x060d41e4
	System.Void OnStateAiming(); // 0x060d42f8
	System.Void OnStateCanFire(); // 0x060d436c
	System.Void OnHideMissModuleComplete(); // 0x060d6274
	System.Void OnStateFiring(); // 0x060d444c
	System.Void CreateMissileMarker(WizardGames.Soc.Common.Entity.MissileEntity entity); // 0x060d2004
	System.Void UpdateModuleBtnStatus(); // 0x060d3968
	System.Void UpdateLoadMissileBtnStatus(); // 0x060d3aa8
	System.Void InitFireBtnStatus(); // 0x060d34a4
	System.Void UpdateModuleStatus(System.Boolean has); // 0x060d3320
	System.Void UpdateTextReadyFireStatus(); // 0x060d3d84
	System.Void SetOperateBtnShowStatus(System.Boolean isPreviewMode); // 0x060d33ac
	System.Void OnClickCloseBtn(); // 0x060d3750
	System.Void .ctor(); // 0x060d62fc
	static System.Void .cctor(); // 0x060d65d8
	System.Void <OnInit>b__100_0(); // 0x060d66ac
	System.Void <OnInit>b__100_1(); // 0x060d684c
	System.Void <OnEnable>b__120_0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x060d6964
	System.Void <OnEnable>b__120_1(); // 0x060d6a50
	System.Void <UpdateFlyingMissileNum>b__123_0(); // 0x060d6ab4
	System.Void <UpdateKatyushaCdState>b__124_0(); // 0x060d6b28
	System.Void <UpdateKatyushaCdState>b__124_1(); // 0x060d6b9c
	System.Void <UpdateLoadMissileBtnStatus>b__146_0(); // 0x060d6c10
	System.Void <UpdateLoadMissileBtnStatus>b__146_1(); // 0x060d6c74
	System.Void <UpdateLoadMissileBtnStatus>b__146_2(); // 0x060d6cd8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiKatyushaMissileContainer : WizardGames.Soc.SocClient.Ui.ClientContainerFixed
{
	static SocLogger logger; // 0x0
	FairyGUI.GComponent node; // 0x78
	FairyGUI.GButton btnLoad; // 0x80
	FairyGUI.GButton btnBack; // 0x88
	FairyGUI.GButton btnUnLoad; // 0x90
	WizardGames.Soc.SocClient.Ui.ComItemIcon missileIcon; // 0x98
	WizardGames.Soc.SocClient.Ui.ComItemIcon othersideIcon; // 0xa0
	WizardGames.Soc.SocClient.Ui.ComItemIcon othersideIconDown; // 0xa8
	FairyGUI.GButton btnClose; // 0xb0
	FairyGUI.GImage highlight; // 0xb8
	FairyGUI.GImage highlightdown; // 0xc0
	System.Int32 lastMissileCount; // 0xc8
	FairyGUI.GObject[] missiles; // 0xd0
	FairyGUI.Transition showUIAnim; // 0xd8
	FairyGUI.Transition hideUIAnim; // 0xe0
	WizardGames.Soc.Common.Entity.KatyushaEntity katyushaEntity; // 0xe8
	WizardGames.Soc.Common.Component.KatyushaComponent katyushaCompClient; // 0xf0
	WizardGames.Soc.SocClient.Ui.UiKatyushaLoadMissile loadMissile; // 0xf8
	WizardGames.Soc.SocClient.Ui.UiKatyushaMissileContainer.EDragType mCurDragType; // 0x100
	System.Int32 lastMissileNum; // 0x104
	WizardGames.Soc.Common.CustomType.StackableItemNode missileItem; // 0x108
	System.Void .ctor(FairyGUI.GComponent bg, FairyGUI.GComponent content); // 0x060c3270
	System.Boolean MissileIconDragBegin(WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x060d6d3c
	System.Void MissileIconDragEnd(); // 0x060d7058
	System.Boolean OtherSideIconDragBegin(WizardGames.Soc.SocClient.Ui.ItemDragInfo info); // 0x060d70d0
	System.Void OtherSideIconDragEnd(); // 0x060d72d0
	System.Void OnClickLoadMissiles(); // 0x060d7348
	System.Void OnClickUnLoadMissiles(); // 0x060d7620
	System.Boolean OnOthersideIconAcceptDrag(WizardGames.Soc.SocClient.Ui.ComBaseIcon iconSelf, WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x060d78e4
	System.Boolean OnBagIconAcceptDrag(WizardGames.Soc.SocClient.Ui.ComBaseIcon iconSelf, WizardGames.Soc.SocClient.Ui.ItemDragInfo dragInfo); // 0x060d7af0
	System.Void OnDestory(); // 0x060ca6f0
	System.Void UpdateMissileCount(WizardGames.Soc.Share.Framework.CustomTypeBase owner, System.Int32 oldValue, System.Int32 newValue); // 0x060d7c74
	System.Void OnIconDragStart(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem); // 0x060d7f3c
	System.Void OnIconDragEnd(WizardGames.Soc.Common.CustomType.BaseItemNode dragItem, System.Boolean isDragValid); // 0x060d8120
	System.Void ShowMsgBagNotHaveMissile(); // 0x060d6f48
	System.Void ShowMsgKatyushaNotHaveMissile(); // 0x060d8250
	System.Void OnClickClose(); // 0x060d8418
	System.Void OnHideUIAnimComplete(); // 0x060d853c
	static System.Void .cctor(); // 0x060d8688
	System.Void <UpdateMissileCount>b__32_0(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x060d875c
	System.Void <UpdateMissileCount>b__32_1(); // 0x060d894c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiKatyushaMissileContainer.EDragType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiKatyushaMissileContainer.EDragType None = 0;
	static WizardGames.Soc.SocClient.Ui.UiKatyushaMissileContainer.EDragType MissileIcon = 1;
	static WizardGames.Soc.SocClient.Ui.UiKatyushaMissileContainer.EDragType OthersideIcon = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiKillDataEvent : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> damageType2WaysToDie; // 0x338
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.KillEventData> showList; // 0x340
	System.Collections.Generic.Queue<WizardGames.Soc.Common.SimpleCustom.KillEventData> waitList; // 0x348
	FairyGUI.GList list; // 0x350
	WizardGames.Soc.Common.Profile.EProfileFunc GetProfileFuncEnum(WizardGames.Soc.Common.Unity.Ui.ELoopType loopType); // 0x060d8b4c
	System.Void OnInit(); // 0x060d8bcc
	System.Void UpdateData(WizardGames.Soc.Common.SimpleCustom.KillEventData data); // 0x060d8e5c
	System.Void AutoClose(); // 0x060d8fec
	System.Void OnRenderList(System.Int32 index, FairyGUI.GObject obj); // 0x060d90a8
	System.Int32 GetShowTime(); // 0x060d9574
	System.Void OnFps10Update(System.Single dt); // 0x060d962c
	System.Void RefeshList(); // 0x060d8db8
	System.Void .ctor(); // 0x060d9874
	System.Boolean <OnFps10Update>b__12_0(WizardGames.Soc.Common.SimpleCustom.KillEventData data); // 0x060d9af0
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ELevelUpgradeStyle : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ELevelUpgradeStyle PlayerLevel = 0;
	static WizardGames.Soc.SocClient.Ui.ELevelUpgradeStyle BpLevel = 1;
	static WizardGames.Soc.SocClient.Ui.ELevelUpgradeStyle MedalLevel = 2;
	static WizardGames.Soc.SocClient.Ui.ELevelUpgradeStyle SeasonLevel = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.LevelUpgradeInfo : System.Object
{
	System.Int32 CurLV; // 0x10
	System.Int64 CurExp; // 0x18
	System.Int32 TarLV; // 0x20
	System.Int64 TarExp; // 0x28
	System.Int32 styleID; // 0x30
	System.Void .ctor(); // 0x060d9bc4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ExpBoundInfo : System.Object
{
	System.String Name; // 0x10
	System.Int32 expBonus; // 0x18
	System.Void .ctor(); // 0x060d9c2c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLevelUpgrade : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFpsUnlimitedUpdate
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLevelUpgrade.UiLevelUpgradeBinder binder; // 0x338
	FairyGUI.GLabel curLevelSign; // 0x340
	WizardGames.Soc.SocClient.Ui.ELevelUpgradeStyle curStyle; // 0x348
	WizardGames.Soc.SocClient.Ui.UiLevelUpgrade.EAnimStep animStep; // 0x34c
	System.Int32 animFinished; // 0x350
	System.Int32 currLevel; // 0x354
	WizardGames.Soc.SocClient.Ui.LevelUpgradeInfo upgradeInfo; // 0x358
	System.Single currProgress; // 0x360
	System.Int64 curLvMaxExp; // 0x368
	System.Int64 curLvMinExp; // 0x370
	System.Single newProgress; // 0x378
	System.Boolean removeWindowOnShowAnimFinish; // 0x37c
	FairyGUI.Transition updateTransition; // 0x380
	FairyGUI.GLoader gLoader; // 0x388
	FairyGUI.GImage medalsProgressBar; // 0x390
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.Binder.LobbyLevelUpgrade.ComSystemUnlockBinder> funcBinders; // 0x398
	WizardGames.Soc.SocClient.Ui.ComBinderDictionary<WizardGames.Soc.SocClient.Ui.Binder.LobbyLevelUpgrade.ComItemRewardsBinder> rewardBinders; // 0x3a0
	WizardGames.Soc.SocClient.Talent.MgrTalent.LevelData rewardData; // 0x3a8
	System.Int64 timerid; // 0x3b0
	WizardGames.Soc.SocClient.Ui.ComSeasonMedalItem seasonItem; // 0x3b8
	System.Single maxProgress; // 0x3c0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ExpBoundInfo> expBoundInfos; // 0x3c8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ELevelUpgradeStyle> signOrder; // 0x3d0
	System.Void OnInit(); // 0x060d9c94
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x060da064
	FairyGUI.Transition GetUpdateTransition(WizardGames.Soc.SocClient.Ui.ELevelUpgradeStyle upgradeStyle); // 0x060da1e4
	System.Void AddMedalIconPackage(WizardGames.Soc.SocClient.Ui.ELevelUpgradeStyle upgradeStyle); // 0x060da4a0
	System.Boolean ResetCurUpgradeInfo(); // 0x060da514
	System.Void RefreshRewards(); // 0x060dadc4
	System.Int64 GetToLvMaxExp(System.Int32 lv); // 0x060dbe5c
	System.Int64 GetToLvMinExp(System.Int32 lv); // 0x060dc164
	System.Void RefreshLevelSign(System.Int32 level); // 0x060dc320
	System.String GetLvStartAudio(); // 0x060dc8b4
	System.String GetLvLoopAudio(); // 0x060dc9f0
	System.String GetLvEndAudio(); // 0x060dcb0c
	System.Void CheckAndShowUpgradeInfo(System.Boolean fromOnEnable); // 0x060dcc48
	System.Void OnEnable(); // 0x060de0b8
	System.Void OnShowAnimFinish(); // 0x060de15c
	System.Void RefreshInfo(); // 0x060ddbc4
	System.Void RefreshFinalInfo(); // 0x060de3c8
	System.Void OnFpsUnlimitedUpdate(System.Single dt); // 0x060de830
	System.Void OnClickBg(FairyGUI.EventContext context); // 0x060da0e0
	System.Void RefreshLevelUpBoundInfos(); // 0x060dbbd0
	System.Void ModifyBonusInfos(); // 0x060df00c
	System.Void ModifyAppPrivilegeBonusInfos(); // 0x060df0bc
	System.Void ModifyExpBonusInfos(); // 0x060df60c
	System.Void ModifyMedalBoundInfos(); // 0x060df8a0
	System.Void ItemExpBoundRenderer(System.Int32 index, FairyGUI.GObject item); // 0x060dfb5c
	System.Void OnDisable(); // 0x060dfcd0
	System.Void OnDestroy(); // 0x060dfdc8
	System.Void .ctor(); // 0x060dff9c
	System.Void <OnShowAnimFinish>b__38_0(System.Object _); // 0x060e0454
	System.Void <OnShowAnimFinish>b__38_1(); // 0x060e04d4
	System.Void <OnFpsUnlimitedUpdate>b__41_4(); // 0x060e0540
	System.Void <OnFpsUnlimitedUpdate>b__41_5(); // 0x060e05ac
	System.Void <OnFpsUnlimitedUpdate>b__41_2(); // 0x060e0614
	System.Void <OnFpsUnlimitedUpdate>b__41_3(); // 0x060e0680
	System.Void <OnFpsUnlimitedUpdate>b__41_6(); // 0x060e0710
	System.Void <OnFpsUnlimitedUpdate>b__41_7(); // 0x060e077c
	System.Void <OnFpsUnlimitedUpdate>b__41_0(); // 0x060e089c
	System.Void <OnFpsUnlimitedUpdate>b__41_1(); // 0x055049cc
	System.Void <OnFpsUnlimitedUpdate>b__41_8(System.Int64 _, System.Object _, System.Boolean _); // 0x060e0b7c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiLevelUpgrade.EAnimStep : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiLevelUpgrade.EAnimStep Start = 0;
	static WizardGames.Soc.SocClient.Ui.UiLevelUpgrade.EAnimStep Progress = 1;
	static WizardGames.Soc.SocClient.Ui.UiLevelUpgrade.EAnimStep Level = 2;
	static WizardGames.Soc.SocClient.Ui.UiLevelUpgrade.EAnimStep Grow = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLevelUpgrade.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiLevelUpgrade.<>c <>9; // 0x0
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.Binder.LobbyLevelUpgrade.ComSystemUnlockBinder> <>9__51_0; // 0x8
	static System.Func<FairyGUI.GComponent,WizardGames.Soc.SocClient.Ui.Binder.LobbyLevelUpgrade.ComItemRewardsBinder> <>9__51_1; // 0x10
	static System.Void .cctor(); // 0x060e1104
	System.Void .ctor(); // 0x060e1168
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLevelUpgrade.ComSystemUnlockBinder <.ctor>b__51_0(FairyGUI.GComponent c); // 0x060e11d0
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLevelUpgrade.ComItemRewardsBinder <.ctor>b__51_1(FairyGUI.GComponent c); // 0x060e1274
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLiftingPlatform : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.UiLiftingPlatformBinder binder; // 0x338
	System.Int64 modularCarEntityId; // 0x340
	System.Int64 modularTemplateId; // 0x348
	WizardGames.Soc.Common.Entity.ModularCarEntity modularCarEntity; // 0x350
	WizardGames.Soc.SocClient.Go.ClientModularCarGo clientModularCarGo; // 0x358
	WizardGames.Soc.Common.Component.LiftPlatformComponent liftPlatformComponent; // 0x360
	WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComVehicleIconBinder[] slotItemBinders; // 0x368
	WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComDurabilityBinder comDurabilityBinder; // 0x370
	WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComMessageBinder[] comMessageBinders; // 0x378
	System.Int32 selectedSlotIndex; // 0x380
	System.Int32 recordOperateSlotIndex; // 0x384
	System.Int32 selectedIconIndex; // 0x388
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.ModuleIconInfo> iconList; // 0x390
	System.Collections.Generic.HashSet<System.Int64> iconSetTemp; // 0x398
	System.Collections.Generic.List<System.Int64> iconListTemp; // 0x3a0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.SlotInfo> installedModulesList; // 0x3a8
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> itemNums; // 0x3b0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.MaterialInfo> materialsList; // 0x3b8
	WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EBtnState btnState; // 0x3c0
	WizardGames.Soc.Common.Component.PlayerVehicleComponent vehicleComponent; // 0x3c8
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> installedParts; // 0x3d0
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap> _vehicleAllContainer; // 0x3d8
	WizardGames.Soc.SocClient.Ui.ItemContainerNodeParser[] allContainersParser; // 0x3e0
	WizardGames.Soc.SocClient.Ui.VehicleContainerType[] vehicleContainerTypes; // 0x3e8
	System.Boolean expandList; // 0x3f0
	System.String[] moduleIconUrl; // 0x3f8
	UnityEngine.AzureSky.AzureWeatherPresetEnum preTODEnum; // 0x400
	System.Boolean needRefreshWhenReturn; // 0x404
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EAttrType,System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComCellBinder>> attrRiseEffect; // 0x408
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EAttrType,System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComCellBinder>> attrRescendEffect; // 0x410
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x418
	System.Int64 delayRefreshTimerId; // 0x420
	UnityEngine.GameObject objPlayerPreview; // 0x428
	UnityEngine.Camera modelCamera; // 0x430
	UnityEngine.GameObject objModelHolder; // 0x438
	System.Collections.Generic.List<System.Int64> subscribeIds; // 0x440
	System.Collections.Generic.Dictionary<System.ValueTuple<System.Int32,System.Int32>,UnityEngine.Vector3> socketPos; // 0x448
	System.Collections.Generic.Dictionary<System.ValueTuple<System.Int32,System.Int32>,UnityEngine.Vector3> cameraPos; // 0x450
	UnityEngine.Vector3 ChassisCameraPos; // 0x458
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EModelType,WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.ModelInfo> loadModels; // 0x468
	WizardGames.Soc.SocClient.Manager.PreviewScene curPreviewScene; // 0x470
	UnityEngine.GameObject objModelRoot; // 0x478
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.IAlpha3ItemContainerWrap> get_VehicleAllContainer(); // 0x060e1318
	System.Void OnInit(); // 0x060e1aa8
	System.Void OnDestroy(); // 0x060e39e4
	System.Void OnDisable(); // 0x060e3f1c
	System.Void ClosePopUpWindow(); // 0x060e3fe8
	static System.Void Open(System.Int64 modularCarEntityId, WizardGames.Soc.Common.Component.LiftPlatformComponent comp); // 0x060e4350
	System.Void SetData(System.Int64 modularCarEntityId, WizardGames.Soc.Common.Component.LiftPlatformComponent comp); // 0x060e46fc
	System.Void OnLifeStageChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, System.Int32 oldValue, System.Int32 newValue); // 0x060e5124
	System.Void OnModuleHpChange(WizardGames.Soc.Common.CustomType.VehicleModuleCustom moduleCustom); // 0x060e51d8
	System.Void OnPlayerWounded(); // 0x060e61c8
	System.Void OnFastReconnected(); // 0x060e6234
	System.Int32 GetPlayerItemCount(System.Int64 templateId); // 0x060e62a0
	System.Boolean IsBagFull(WizardGames.Soc.Common.Data.DataItem.ItemConfig config, System.Int32 count); // 0x060e6354
	System.Void InventoryMainUpdate(); // 0x060e645c
	System.Void OnLiftingPlatformOperationNotify(System.Int32 opType, System.Int32 result, System.Boolean isRepalce); // 0x060e6e08
	System.Void OnLoadVehicleModularNotify(System.Int32 result, System.Boolean isRepalce); // 0x060e7204
	System.Void PlayInstallEffect(); // 0x060e72a8
	System.Void PlayAttrPanelEffect(); // 0x060e7458
	System.Void OnUnLoadVehicleModularNotify(System.Int32 result); // 0x060e6ee8
	System.Int32 GetSlotCount(); // 0x060e7dac
	System.Int32 GetTotalAttributeValue(WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EAttrType attrType); // 0x060e7ea4
	System.Int32 GetAddAttributeValue(WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EAttrType attrType, System.Int32 slotIndex); // 0x060e80b4
	System.Int32 GetModuleAttributeValue(System.Int64 templateId, WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EAttrType attrType); // 0x060e7f5c
	System.Single GetModuleDurabilityValue(System.Int64 templateId); // 0x060e81dc
	System.Void SetAttrValue(WizardGames.Soc.SocClient.Ui.Binder.GameLiftingPlatform.ComMessageBinder binder, WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EAttrType attrType, System.Int32 value, System.Int32 addValue); // 0x060e8330
	System.Void UpdateInstalledModulesInfo(); // 0x060e4a8c
	System.Int32 GetInstalledSoltIndex(System.Int64 templateId, System.Int64 entityId); // 0x060e88f0
	System.Boolean IsInstalledModule(System.Int64 templateId, System.Int64 entityId); // 0x060e8a88
	System.Boolean IsEngineOrCab(System.Int64 templateId); // 0x060e8c20
	System.Boolean IsEngine(System.Int64 templateId); // 0x060e8cc0
	System.Boolean IsCab(System.Int64 templateId); // 0x060e8d40
	System.Boolean IsStorage(System.Int64 templateId); // 0x060e8f24
	System.Boolean IsSomeType(System.Int64 templateId, WizardGames.Soc.Common.Data.VehicleModuleType type); // 0x060e8dc0
	System.Boolean IsSlotEnough(System.Int64 templateId); // 0x060e8fa4
	System.Boolean HasAnotherEngine(System.Int32 curEngineIndex); // 0x060e916c
	System.Boolean HasAnotherCab(System.Int32 curCabIndex); // 0x060e923c
	System.Int32 GetInstalledMouduleCount(WizardGames.Soc.Common.Data.VehicleModuleType moduleType); // 0x060e930c
	System.Boolean CanInstallModule(System.Int64 templateId); // 0x060e959c
	System.Void UpdateItemNums(); // 0x060e97fc
	System.Boolean HasModuleItemInBag(System.Int64 itemId); // 0x060e9774
	System.Int32 GetItemNum(System.Int64 itemId); // 0x060e9914
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> GetPartsFromContainer(System.Int64 templateId, System.Int32& num, System.Int32& capacity, System.Int64 entityId); // 0x060e99c4
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.BaseItemNode> GetPartsFromItemContainer(System.Int64 itemUid, System.Int32& num, System.Int32& capacity); // 0x060ea1f4
	System.Void RefreshSlotItemList(); // 0x060e4c20
	WizardGames.Soc.Common.CustomType.VehicleModuleCustom GetModuleCustomByIndex(System.Int32 slotIndex); // 0x060e7cc4
	System.Void SlotItemRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x060ea4d4
	System.Boolean IsSoltOccupy(System.Int32 index); // 0x060e7b44
	System.Void OnEnable(); // 0x060eb07c
	System.Void RecoverTODOnExit(); // 0x060e40e0
	System.Void RefreshCurPreviewScene(); // 0x060e4468
	System.Void RefreshModel(System.Int32 oldIndex); // 0x060eb3b8
	System.String GetReplaceModelUIPath(System.String path); // 0x060ec0f0
	System.Void ShowOutlineOnLoaded(UnityEngine.GameObject go, System.Object[] param); // 0x060ecac8
	System.Void ResetModel(); // 0x060ebb84
	System.Void ClearOutline(); // 0x060ec714
	System.Void ShowOutline(); // 0x060ecb48
	System.Void LoadModels(); // 0x060ed1b0
	System.Void SetCameraPos(WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EModelType type, System.Boolean tween); // 0x060ecf44
	System.Void OnSocketModuleCustomChange(WizardGames.Soc.Share.Framework.CustomTypeBase entity, WizardGames.Soc.Share.Framework.CustomTypeBase oldValue, WizardGames.Soc.Share.Framework.CustomTypeBase newValue); // 0x060ed838
	System.Void ReleaseModels(); // 0x060e3cbc
	System.Void ReleaseSingleModel(WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.ModelInfo info); // 0x060ec524
	System.Void LoadSingleModel(WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EModelType type, WizardGames.Soc.Common.Data.Vehicle.VehicleModule moduleInfo, System.String path, System.Object data, System.Action<UnityEngine.GameObject,System.Object[]> loadedCallback); // 0x060ec1a4
	System.Void OnPartLoaded(UnityEngine.GameObject go, System.Object[] param); // 0x060edbdc
	System.Void OnLoaded(UnityEngine.GameObject go, System.Object[] param); // 0x060ee0e8
	System.Void RefreshAttrList(); // 0x060e4d8c
	System.Void StatusRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x060ee600
	System.Void RefreshIconItemList(); // 0x060e5428
	System.Void ClearDelayRefreshTimer(); // 0x060e4244
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.ModuleIconInfo> GetIconList(); // 0x060eee78
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.ModuleIconInfo> GetAllIconInBag(); // 0x060ef78c
	System.Int64 GetSelectedIconTemplateId(); // 0x060ec910
	WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.ModuleIconInfo GetSelectedIcon(); // 0x060ec9d8
	System.Void IconRenderer(System.Int32 index, FairyGUI.GObject obj); // 0x060efda0
	System.Void RefreshDetailInfo(); // 0x060eb33c
	System.Void RefreshBasicInfo(); // 0x060e5614
	System.Void RefreshPartsInfo(); // 0x060e64d0
	System.String GetModuleIconUrlByIndex(System.Int32 index); // 0x060f14b4
	System.Void PartsIconRender(System.Int32 index, FairyGUI.GObject obj); // 0x060f1554
	System.Void RefreshMaterialsInfo(); // 0x060f0460
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.MaterialInfo> GetMaterialsIdList(WizardGames.Soc.Common.Data.blueprintData.Blueprint bp); // 0x060f1d58
	WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.MaterialInfo GetMaterialInfoByIndex(System.Int32 index); // 0x060f1ec4
	System.Void MaterialIconRender(System.Int32 index, FairyGUI.GObject obj); // 0x060f1f84
	System.Void OnClickIcon(WizardGames.Soc.SocClient.Ui.ComBaseIcon clickIcon); // 0x060f2198
	System.Void RefreshDetailBtn(); // 0x060f0878
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x060f2440
	System.Void OnSlotItemClick(FairyGUI.EventContext context); // 0x060f24c0
	System.Void OnRepairClick(); // 0x060f306c
	System.Void RemoteCallRepairModules(); // 0x060f3114
	System.Void RemoteCallRepairOneModule(System.Int32 index, System.Collections.Generic.Dictionary<System.Int64,System.Int32> expectToConsume); // 0x060f3e54
	System.Void OnDetailRepairClick(); // 0x060f3fe0
	System.Void OnUnequipClick(); // 0x060f4ec8
	System.Void OnUninstallClick(); // 0x060f5324
	System.Void OnInstallClick(); // 0x060f5830
	System.Void OnIconClick(FairyGUI.EventContext context); // 0x060f66e4
	System.Void .ctor(); // 0x060f6be0
	static System.Void .cctor(); // 0x060f75e0
	System.Void <RefreshCurPreviewScene>b__110_0(UnityEngine.GameObject a, UnityEngine.GameObject b); // 0x060f76b4
	System.Void <OnSocketModuleCustomChange>b__120_0(System.Object obj); // 0x060f7810
	System.Void <PartsIconRender>b__139_0(); // 0x060f78a8
	System.Void <PartsIconRender>b__139_1(); // 0x060f7914
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EAttrType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EAttrType Durability = 0;
	static WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EAttrType Speed = 1;
	static WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EAttrType Defense = 2;
	static WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EAttrType Function = 3;
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.MaterialInfo : System.ValueType
{
	System.Int64 ItemId; // 0x10
	System.Int32 ItemCount; // 0x18
	
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.SlotInfo : System.ValueType
{
	System.Int32 SlotIndex; // 0x10
	System.Int64 TemplateId; // 0x18
	System.Int64 EntityId; // 0x20
	System.Void .ctor(System.Int32 slotIndex, System.Int64 templateId, System.Int64 entityId); // 0x060f83d4
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.ModuleIconInfo : System.ValueType
{
	System.Int64 TemplateId; // 0x10
	System.Boolean IsInstalled; // 0x18
	System.Int64 ItemUid; // 0x20
	System.Int64 EntityId; // 0x28
	System.Void .ctor(System.Int64 templateId, System.Boolean isInstalled, System.Int64 itemUid, System.Int64 entityId); // 0x060f846c
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EBtnState : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EBtnState None = 0;
	static WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EBtnState Install = 1;
	static WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EBtnState Uninstall = 2;
	static WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EBtnState UninstallGray = 3;
	static WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EBtnState Replace = 4;
	static WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EBtnState CraftAndInstall = 5;
	static WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EBtnState Unlock = 6;
	static WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EBtnState MaterialNotEnough = 7;
	static WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EBtnState WorkbenchLvNotEnought = 8;
	static WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EBtnState MatAndWorkBenchNotEnough = 9;
	static WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EBtnState SlotNotEnough = 10;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EModelType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EModelType Chassis = -1;
	static WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EModelType Socket1 = 0;
	static WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EModelType Socket2 = 1;
	static WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EModelType Socket3 = 2;
	static WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EModelType Socket4 = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.ModelInfo : System.Object
{
	UnityEngine.GameObject Go; // 0x10
	WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.EModelType Type; // 0x18
	WizardGames.Soc.Common.Data.Vehicle.VehicleModule ModuleInfo; // 0x20
	System.String Path; // 0x28
	System.UInt64 AsyncId; // 0x30
	System.Int64 ItemUid; // 0x38
	WizardGames.Soc.Common.Entity.IBaseMountableEntity Entity; // 0x40
	ConditionalGibbable Gibbable; // 0x48
	System.String PartPath; // 0x50
	UnityEngine.GameObject PartGo; // 0x58
	System.UInt64 PartAsyncId; // 0x60
	System.Void .ctor(); // 0x060f8514
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.<>c <>9; // 0x0
	static System.Comparison<System.Int64> <>9__130_0; // 0x8
	static System.Void .cctor(); // 0x060f857c
	System.Void .ctor(); // 0x060f85e0
	System.Int32 <GetIconList>b__130_0(System.Int64 a, System.Int64 b); // 0x060f8648
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.<>c__DisplayClass123_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLiftingPlatform <>4__this; // 0x10
	System.Action<UnityEngine.GameObject,System.Object[]> loadedCallback; // 0x18
	System.Void .ctor(); // 0x060f87e0
	System.Void <LoadSingleModel>b__0(UnityEngine.GameObject go, System.Object[] param); // 0x060f8848
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.<>c__DisplayClass128_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLiftingPlatform <>4__this; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.ModuleIconInfo> iconList; // 0x18
	System.Void .ctor(); // 0x060f88e8
	System.Void <RefreshIconItemList>b__0(System.Int64 delayRefreshTimerId, System.Object data, System.Boolean delete); // 0x060f8950
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.<>c__DisplayClass144_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComItemIcon icon; // 0x10
	System.Void .ctor(); // 0x060f8b4c
	System.Void <OnClickIcon>b__0(); // 0x060f8bb4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.<>c__DisplayClass149_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLiftingPlatform <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.UiItemPopup win; // 0x18
	System.Collections.Generic.Dictionary<System.Int32,System.Single> expectToAddHp; // 0x20
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> expectToConsume; // 0x28
	System.Void .ctor(); // 0x060f8c28
	System.Void <RemoteCallRepairModules>b__0(); // 0x060f8c90
	System.Void <RemoteCallRepairModules>b__1(); // 0x060f8d48
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.<>c__DisplayClass151_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLiftingPlatform <>4__this; // 0x10
	WizardGames.Soc.Common.CustomType.VehicleModuleCustom custom; // 0x18
	WizardGames.Soc.SocClient.Ui.UiItemPopup win; // 0x20
	System.Collections.Generic.Dictionary<System.Int64,System.Int32> expectToConsume; // 0x28
	System.Void .ctor(); // 0x060f8eb8
	System.Void <OnDetailRepairClick>b__0(); // 0x060f8f20
	System.Void <OnDetailRepairClick>b__1(); // 0x060f8fd8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.<>c__DisplayClass153_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLiftingPlatform <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.UiItemPopup win; // 0x18
	System.Void .ctor(); // 0x060f90bc
	System.Void <OnUninstallClick>b__0(); // 0x060f9124
	System.Void <OnUninstallClick>b__1(); // 0x060f9198
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.<>c__DisplayClass154_0 : System.Object
{
	System.Int64 itemUid; // 0x10
	WizardGames.Soc.SocClient.Ui.UiLiftingPlatform <>4__this; // 0x18
	System.Void .ctor(); // 0x060f9230
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.<>c__DisplayClass154_1 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiItemPopup win; // 0x10
	WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.<>c__DisplayClass154_0 CS$<>8__locals1; // 0x18
	System.Void .ctor(); // 0x060f9298
	System.Void <OnInstallClick>b__0(); // 0x060f9300
	System.Void <OnInstallClick>b__1(); // 0x060f9374
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.<>c__DisplayClass154_2 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiItemPopup win; // 0x10
	WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.<>c__DisplayClass154_0 CS$<>8__locals2; // 0x18
	System.Void .ctor(); // 0x060f9418
	System.Void <OnInstallClick>b__2(); // 0x060f9480
	System.Void <OnInstallClick>b__3(); // 0x060f94f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLiftingPlatform.<>c__DisplayClass154_3 : System.Object
{
	WizardGames.Soc.Common.Data.blueprintData.Blueprint blueprintConfig; // 0x10
	WizardGames.Soc.SocClient.Ui.UiItemPopup win; // 0x18
	WizardGames.Soc.SocClient.Ui.UiLiftingPlatform <>4__this; // 0x20
	System.Void .ctor(); // 0x060f9598
	System.Void <OnInstallClick>b__4(); // 0x060f9600
	System.Void <OnInstallClick>b__5(); // 0x060f9674
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLiteLoading : WizardGames.Soc.SocClient.Ui.UiReconnect, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	System.Single duration; // 0x364
	System.Void OnInit(); // 0x060f98a4
	static System.Void ShowLoading(System.String strMsg, System.Int32 duration); // 0x060f9914
	static System.Void ShowLoading(System.Int32 lanKey); // 0x060f9a6c
	static System.Void HideLoading(); // 0x060f9b00
	System.Void OnFps1Update(System.Single dt); // 0x060f9bb0
	System.Void SetDuration(System.Single duration); // 0x060f9c54
	System.Void OnDisable(); // 0x060f9ccc
	System.Void .ctor(); // 0x060f9d3c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLoading : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	FairyGUI.GTextField textLoadingMsg; // 0x338
	FairyGUI.GProgressBar progress; // 0x340
	WizardGames.Soc.SocClient.Ui.ComMarquee labelTips; // 0x348
	FairyGUI.GLoader loaderBac; // 0x350
	FairyGUI.GLoader videoBac; // 0x358
	FairyGUI.GComponent comPlayMode; // 0x360
	FairyGUI.GTextField textModeName; // 0x368
	FairyGUI.GTextField textModeInfo; // 0x370
	FairyGUI.GLoader iconModeLoader; // 0x378
	FairyGUI.GTextField textModeDesc; // 0x380
	WizardGames.Soc.SocClient.Ui.ComVideo videoPlayer; // 0x388
	FairyGUI.Controller ctrlStyle; // 0x390
	System.String strLastMsg; // 0x398
	System.Boolean enableBacSwitch; // 0x3a0
	System.Boolean inLoginLoading; // 0x3a1
	static System.Boolean <IsForceCameraDisableDuringLoading>k__BackingField; // 0x0
	System.Single sceneCameraOffCheckTimer; // 0x3a4
	UnityEngine.GameObject sceneCameraObjCache; // 0x3a8
	System.Single showTime; // 0x3b0
	System.Single loadingTime; // 0x3b4
	System.Single loadingProgressLimit; // 0x3b8
	System.Func<System.Boolean> completeFunc; // 0x3c0
	System.Single fSwitchTipsTime; // 0x3c8
	System.Single fSwitchBacTime; // 0x3cc
	System.Action onLoadingDisable; // 0x3d0
	static WizardGames.Soc.SocClient.Ui.WeightedRandomSelector<System.Int32> loadingSelector; // 0x8
	static WizardGames.Soc.SocClient.Ui.WeightedRandomSelector<System.Int32> tipsSelector; // 0x10
	static System.Int32 curGameModeId; // 0x18
	static System.Boolean get_IsForceCameraDisableDuringLoading(); // 0x060f9dac
	static System.Void set_IsForceCameraDisableDuringLoading(System.Boolean value); // 0x060f9e34
	static System.Void ForceCameraDisableDuringLoading(); // 0x060f9ec8
	System.Void OnInit(); // 0x060f9fb8
	System.Void InitSelector(); // 0x060fa60c
	System.Void UpdateTipsAndBac(); // 0x060fad60
	System.Void CheckSwitchTips(System.Single dt); // 0x060fafc0
	System.Void CheckSwitchBac(System.Single dt); // 0x060fb170
	System.Void CheckGameSceneCameraStatus(System.Single dt); // 0x060fb31c
	System.Boolean IsCameraInGame(UnityEngine.Camera camera); // 0x060fb62c
	System.Void OnEnable(); // 0x060fb74c
	System.Void OnDisable(); // 0x060fbad8
	System.Void SetMsg(System.String msg, System.Single value); // 0x060fc10c
	System.Void SetProgress(System.Single value); // 0x060fc2a8
	System.Void SetPlayMode(System.Int32 modeId); // 0x060fc330
	System.Void TryRemoveSelf(System.Boolean immediately); // 0x060fcad4
	System.Void ResetShowTimeAndHide(); // 0x060fce6c
	System.Void OnFps30Update(System.Single dt); // 0x060fcf10
	static System.Void ShowMsg(System.String msg, System.Single value); // 0x060fd03c
	static System.Void ShowProgress(System.Single value); // 0x060fd1c8
	static WizardGames.Soc.SocClient.Ui.UiLoading ShowLoading(System.Int32 playMode, System.Action onHide); // 0x060fd288
	static System.Void HideLoading(System.Boolean remove); // 0x060fd458
	static WizardGames.Soc.SocClient.Ui.UiLoading GetThisWin(); // 0x060fd108
	static WizardGames.Soc.SocClient.Ui.UiLoading OpenThisWin(); // 0x060fd388
	System.Void .ctor(); // 0x060fd508
	static System.Void .cctor(); // 0x060fd5a4
	System.Void <SetPlayMode>b__44_0(UnityEngine.Video.VideoPlayer player); // 0x060fd67c
	System.Void <SetPlayMode>b__44_1(System.Object param); // 0x060fd764
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.WeightedRandomSelector<T> : System.Object
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.WeightedRandomSelector.WeightedItem<T,T>> items; // 0x0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.WeightedRandomSelector.WeightedItem<T,T>> availableItems; // 0x0
	System.Random random; // 0x0
	System.Void .ctor(); // 0x055049cc
	System.Void AddItem(T item, System.Int32 weight); // 0x052af1f0
	T GetNext(); // 0x052af1f0
	System.Void ResetAvailableItems(); // 0x055049cc
	System.Void Clear(); // 0x055049cc
	System.Int32 get_Count(); // 0x0548ba98
	static System.Void .cctor(); // 0x054fd168
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.WeightedRandomSelector.WeightedItem<T,TItem> : System.Object
{
	TItem <Item>k__BackingField; // 0x0
	System.Int32 <Weight>k__BackingField; // 0x0
	TItem get_Item(); // 0x052af1f0
	System.Int32 get_Weight(); // 0x0548ba98
	System.Void .ctor(TItem item, System.Int32 weight); // 0x052af1f0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyServerList : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	FairyGUI.GList serverTypeList; // 0x338
	WizardGames.Soc.SocClient.Ui.ComCustomButton btnRefresh; // 0x340
	FairyGUI.GButton btnSelect; // 0x348
	FairyGUI.GButton addButton; // 0x350
	FairyGUI.GButton subButton; // 0x358
	FairyGUI.GTextInput pageNumInputField; // 0x360
	FairyGUI.GTextField pageMaxNumText; // 0x368
	FairyGUI.GList serverInfosList; // 0x370
	FairyGUI.GList boomHouseInfoList; // 0x378
	FairyGUI.Controller rightItemControl; // 0x380
	FairyGUI.GButton backButton; // 0x388
	WizardGames.Soc.SocClient.Ui.UiServerInfoPopBox uiServerInfoPopBox; // 0x390
	FairyGUI.Controller popServerWindowControl; // 0x398
	System.Int32 selectIndex; // 0x3a0
	FairyGUI.GComponent floatOpGroupCom; // 0x3a8
	FairyGUI.Controller opGroupsController; // 0x3b0
	System.Int32 serverNum; // 0x3b8
	System.Int32 serverIdx; // 0x3bc
	System.Int32 pageIndex; // 0x3c0
	static System.Int32 pageSize; // 0x0
	System.Int32 pageMaxNum; // 0x3c4
	System.Timers.Timer timer; // 0x3c8
	System.Void OnInit(); // 0x060fd7ec
	System.Void BindFloatOpGroup(FairyGUI.GComponent floatOpGroupCom); // 0x060fe058
	System.Void AddListenersTotal(); // 0x060fed2c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x060ff104
	System.Void OnEnable(); // 0x060ff338
	System.Void OnDestroy(); // 0x060ff9f8
	System.Void SwitchOpServerWindowStatus(System.Boolean status); // 0x060ffd28
	System.Void GetAllServerTypeNum(); // 0x060ff6e8
	System.Void OnClickSvrGroup(System.Int32 groupIndex); // 0x060ffdec
	System.Void AddPage(); // 0x0610033c
	System.Void SubPage(); // 0x061003f8
	System.Void ChangePageNum(); // 0x061004b0
	System.Void ResetPage(); // 0x061002a0
	System.Void RefreshServerInfoList(); // 0x060ff4b0
	System.Void ServerInfoRenderer(System.Int32 index, FairyGUI.GObject item); // 0x0610059c
	System.Void BoomHouseInfoRenderer(System.Int32 index, FairyGUI.GObject item); // 0x061012d4
	System.Void OpenSvrInfoPopWin(WizardGames.Soc.SocClient.ServerList.ServerInfo info); // 0x06101ea0
	System.Void OnFps10Update(System.Single dt); // 0x06101ff4
	System.Void RefreshServerListAfterRequest(); // 0x06102288
	System.Void OnFps1Update(System.Single dt); // 0x06102450
	System.Void ReqServerNumIn10S(System.Object sender, System.Timers.ElapsedEventArgs e); // 0x06102554
	System.Void OpenPopWindow(WizardGames.Soc.SocClient.ServerList.ServerInfo info, System.Boolean boomHouseType); // 0x06101f34
	System.Void ClosePopWindow(); // 0x060ff1d0
	System.Void .ctor(); // 0x06102e98
	static System.Void .cctor(); // 0x06102f38
	System.Void <OnInit>b__24_0(FairyGUI.EventContext ctx); // 0x06102f84
	System.Void <BindFloatOpGroup>b__25_0(FairyGUI.EventContext ctx); // 0x06103158
	System.Void <AddListenersTotal>b__26_0(FairyGUI.EventContext ctx); // 0x06103640
	System.Void <AddListenersTotal>b__26_1(FairyGUI.EventContext ctx); // 0x06103720
	System.Void <AddListenersTotal>b__26_2(FairyGUI.EventContext ctx); // 0x06103798
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyServerList.<>c__DisplayClass38_0 : System.Object
{
	WizardGames.Soc.SocClient.ServerList.ServerInfo info; // 0x10
	FairyGUI.GButton btnFavorite; // 0x18
	FairyGUI.GObject objMoreSign; // 0x20
	FairyGUI.GList listLabel; // 0x28
	WizardGames.Soc.SocClient.Ui.UiLobbyServerList <>4__this; // 0x30
	System.Int32 index; // 0x38
	System.Void .ctor(); // 0x0610126c
	System.Void <ServerInfoRenderer>b__0(FairyGUI.EventContext ctx); // 0x06103810
	System.Void <ServerInfoRenderer>b__1(); // 0x06103958
	System.Void <ServerInfoRenderer>b__2(FairyGUI.EventContext ctx); // 0x06103a30
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyServerList.<>c__DisplayClass39_0 : System.Object
{
	WizardGames.Soc.SocClient.ServerList.ServerInfo info; // 0x10
	FairyGUI.GButton btnFavorite; // 0x18
	FairyGUI.GObject objMoreSign; // 0x20
	FairyGUI.GList listLabel; // 0x28
	WizardGames.Soc.SocClient.Ui.UiLobbyServerList <>4__this; // 0x30
	System.Int32 index; // 0x38
	System.Void .ctor(); // 0x06101e38
	System.Void <BoomHouseInfoRenderer>b__0(FairyGUI.EventContext ctx); // 0x06103ad4
	System.Void <BoomHouseInfoRenderer>b__1(); // 0x06103c1c
	System.Void <BoomHouseInfoRenderer>b__2(FairyGUI.EventContext ctx); // 0x06103cf4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiServerInfoPopBox : System.Object
{
	FairyGUI.GComponent winMain; // 0x10
	WizardGames.Soc.SocClient.Ui.UiLobbyServerList uiLobbyServerList; // 0x18
	FairyGUI.GComponent node; // 0x20
	FairyGUI.GButton joinButton; // 0x28
	FairyGUI.GTextField serverName; // 0x30
	FairyGUI.GTextField lastTime; // 0x38
	FairyGUI.GTextField ping; // 0x40
	FairyGUI.GTextField personNumber; // 0x48
	FairyGUI.GTextField serverInfo; // 0x50
	FairyGUI.GList lableList; // 0x58
	FairyGUI.GObject objMoreSign; // 0x60
	FairyGUI.GLoader showImg; // 0x68
	FairyGUI.Controller infoTypeControl; // 0x70
	FairyGUI.GTextField type; // 0x78
	FairyGUI.GTextField status; // 0x80
	FairyGUI.GButton btnClose; // 0x88
	FairyGUI.GButton btnFavorites; // 0x90
	WizardGames.Soc.SocClient.ServerList.ServerInfo info; // 0x98
	static SimpleJSON.JSONNode remoteServerInfo; // 0x0
	System.Void .ctor(FairyGUI.GComponent winMain, WizardGames.Soc.SocClient.Ui.UiLobbyServerList uiLobbyServerList); // 0x060fe4dc
	System.Void RefreshServerInfo(); // 0x055049cc
	System.Void OnJoinOldBattleNotice(SimpleJSON.JSONNode jsonNode); // 0x06103e00
	System.Void OnUpdate(); // 0x061020e0
	System.Void DoDestory(); // 0x060ffc0c
	System.Void ChooseConnectType(); // 0x06104060
	System.Void UpdateServerInfo(WizardGames.Soc.SocClient.ServerList.ServerInfo svrInfo); // 0x061026b4
	System.Void DirectConnected(System.String ip, System.Int32 port); // 0x06103f28
	System.Void <UpdateServerInfo>b__26_0(); // 0x061042f8
	System.Void <DirectConnected>b__27_0(WizardGames.Soc.SocClient.PersistentData.CommonAccountPersistentData data); // 0x061043d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiServerInfoPopBox.<>c__DisplayClass20_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLobbyServerList uiLobbyServerList; // 0x10
	WizardGames.Soc.SocClient.Ui.UiServerInfoPopBox <>4__this; // 0x18
	System.Void .ctor(); // 0x06103d98
	System.Void <.ctor>b__0(FairyGUI.EventContext ctx); // 0x061044f0
	System.Void <.ctor>b__1(FairyGUI.EventContext ctx); // 0x06104570
	System.Void <.ctor>b__2(FairyGUI.EventContext ctx); // 0x061046b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCustomBlueprintDetail : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubCustomBlueprintBinder subBlueprint; // 0x338
	WizardGames.Soc.SocClient.Ui.UiSubCustomBlueprint uiSubCustomBlueprint; // 0x340
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x348
	System.Void OnInit(); // 0x06104738
	System.Void OnEnable(); // 0x06104a5c
	System.Void OnDisable(); // 0x06104ac4
	System.Void OnFps30Update(System.Single dt); // 0x06104b48
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06104bdc
	static System.Void OpenWindow(System.Int32 slotId); // 0x06104c5c
	System.Void .ctor(); // 0x06104e10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiCustomBlueprintDetail.<>c__DisplayClass8_0 : System.Object
{
	System.Int32 slotId; // 0x10
	System.Void .ctor(); // 0x06104da8
	System.Void <OpenWindow>b__0(WizardGames.Soc.SocClient.Ui.UiCustomBlueprintDetail win); // 0x06104e9c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyCustomBlueprint : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyCustomBlueprint.UiLobbyCustomBlueprintBinder <binder>k__BackingField; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.GameInventoryOthersideTerritoryCenter.SubCustomBlueprintBinder subBlueprint; // 0x340
	WizardGames.Soc.SocClient.Ui.UiSubCustomBlueprint uiSubCustomBlueprint; // 0x348
	WizardGames.Soc.SocClient.Ui.UiSubpageSelect uiSubpageSelect; // 0x350
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x358
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x360
	WizardGames.Soc.SocClient.Ui.Binder.LobbyCustomBlueprint.UiLobbyCustomBlueprintBinder get_binder(); // 0x06104f28
	System.Void set_binder(WizardGames.Soc.SocClient.Ui.Binder.LobbyCustomBlueprint.UiLobbyCustomBlueprintBinder value); // 0x06104f8c
	System.Void OnInit(); // 0x0610500c
	System.Void OnEnable(); // 0x061058dc
	System.Void OnDisable(); // 0x06105990
	System.Void OnDestroy(); // 0x06105a18
	System.Void OnFps30Update(System.Single dt); // 0x06105a94
	System.Void SetBgVisible(System.Boolean isShow); // 0x06105b1c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06105c38
	static System.Void OpenWindow(); // 0x06105cb8
	System.Void .ctor(); // 0x06105d88
	System.Void <OnInit>b__9_0(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x06105e4c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.LobbyExitPc : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x338
	FairyGUI.GButton btnSetting; // 0x340
	FairyGUI.GButton btnExitGame; // 0x348
	FairyGUI.GButton btnCustomerService; // 0x350
	FairyGUI.GButton btnReturnLogin; // 0x358
	UnityEngine.Rendering.Universal.DepthOfField postProcessDepthOfField; // 0x360
	System.String PpvName; // 0x368
	System.Void OnInit(); // 0x06105fa4
	System.Void InitUiElement(); // 0x06106010
	System.Void InitPpvDepthofField(); // 0x0610672c
	System.Void ModifyPpvDepthofFieldState(System.Boolean isActivate); // 0x0610684c
	System.Void OnEnable(); // 0x06106910
	System.Void OnDisable(); // 0x06106984
	System.Void OnClickBtnSetting(); // 0x061069f8
	System.Void OnClickBtnExit(); // 0x06106a58
	System.Void OnClickBtnCustomerService(); // 0x06106d64
	System.Void OnClickBtnReturnLogin(); // 0x06106df8
	System.Void CloseWindow(); // 0x06107288
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x061072f4
	System.Void .ctor(); // 0x0610736c
	System.Void <InitUiElement>b__9_0(FairyGUI.EventContext ctx); // 0x0610741c
	System.Void <InitUiElement>b__9_1(FairyGUI.EventContext ctx); // 0x06107494
	System.Void <InitUiElement>b__9_2(FairyGUI.EventContext ctx); // 0x0610750c
	System.Void <InitUiElement>b__9_3(FairyGUI.EventContext ctx); // 0x06107584
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.LobbyExitPc.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.LobbyExitPc.<>c <>9; // 0x0
	static System.Action <>9__15_0; // 0x8
	static System.Action <>9__15_1; // 0x10
	static System.Action <>9__17_0; // 0x18
	static System.Void .cctor(); // 0x061075fc
	System.Void .ctor(); // 0x06107660
	System.Void <OnClickBtnExit>b__15_0(); // 0x061076c8
	System.Void <OnClickBtnExit>b__15_1(); // 0x06107754
	System.Void <OnClickBtnReturnLogin>b__17_0(); // 0x0610780c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiAddFriendListPop : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	FairyGUI.GComponent node; // 0x338
	FairyGUI.Controller pageControl; // 0x340
	FairyGUI.GComponent comSearch; // 0x348
	FairyGUI.GList listAddFriend; // 0x350
	FairyGUI.GObject bac; // 0x358
	FairyGUI.GTextInput textInput; // 0x360
	FairyGUI.GButton btnClear; // 0x368
	static WizardGames.Soc.SocClient.Ui.UiAddFriendListPop.CustomFriendInfoEqualityComparer customFriendInfoEqualityComparer; // 0x0
	System.Collections.Generic.HashSet<LobbyFriend.FriendInfo> tmpHashSet; // 0x370
	WizardGames.Soc.SocClient.Ui.ComSideShot comSide; // 0x378
	System.Void OnInit(); // 0x061078b8
	System.Void SetBacClickActive(System.Boolean b); // 0x06108234
	System.Void BindComSearch(); // 0x06107e10
	System.Void OnFps1Update(System.Single dt); // 0x061082bc
	System.Void ClickCallback(); // 0x061085e0
	System.Void Refresh(); // 0x061086ac
	System.Void UpdateData(); // 0x06108334
	System.Void OnClickSearch(System.String text); // 0x06108fb8
	System.Void SearchPlayer(System.String text); // 0x06109174
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0610949c
	System.Void .ctor(); // 0x061095c4
	static System.Void .cctor(); // 0x061096dc
	System.Void <OnInit>b__10_0(); // 0x061097bc
	System.Void <OnInit>b__10_1(); // 0x06109830
	System.Void <OnInit>b__10_2(); // 0x06109898
	System.Void <BindComSearch>b__12_0(FairyGUI.EventContext ctx); // 0x06109900
	System.Void <BindComSearch>b__12_1(); // 0x06109a1c
	System.Void <BindComSearch>b__12_2(FairyGUI.EventContext ctx); // 0x06109b10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiAddFriendListPop.CustomFriendInfoEqualityComparer : System.Object, System.Collections.Generic.IEqualityComparer<LobbyFriend.FriendInfo>
{
	
	System.Boolean Equals(LobbyFriend.FriendInfo x, LobbyFriend.FriendInfo y); // 0x06109ba8
	System.Int32 GetHashCode(LobbyFriend.FriendInfo obj); // 0x06109c3c
	System.Void .ctor(); // 0x06109754
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiAddFriendListPop.<>c__DisplayClass15_0 : System.Object
{
	LobbyFriend.FriendInfo playerInfo; // 0x10
	FairyGUI.GButton btnAddFriend; // 0x18
	System.Void .ctor(); // 0x06108f50
	System.Void <Refresh>b__0(FairyGUI.EventContext ctx); // 0x06109cc8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiAddFriendListPop.<>c__DisplayClass17_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiAddFriendListPop <>4__this; // 0x10
	System.String text; // 0x18
	System.Void .ctor(); // 0x0610910c
	System.Void <OnClickSearch>b__0(); // 0x06109e24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBlackListPop : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GComponent node; // 0x338
	FairyGUI.GList listBlack; // 0x340
	FairyGUI.Controller showEmptyCtr; // 0x348
	FairyGUI.GObject bac; // 0x350
	WizardGames.Soc.SocClient.Ui.ComSideShot comSide; // 0x358
	System.Void OnInit(); // 0x06109e94
	System.Void SetBacClickActive(System.Boolean b); // 0x0610a9d0
	System.Void Refresh(); // 0x0610a3fc
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0610aac0
	System.Void OnDestroy(); // 0x0610ab40
	System.Void .ctor(); // 0x0610abb4
	System.Void <OnInit>b__5_0(); // 0x0610ac40
	System.Void <OnInit>b__5_1(); // 0x0610acb4
	System.Void <OnInit>b__5_2(); // 0x0610ad1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiBlackListPop.<>c__DisplayClass7_0 : System.Object
{
	LobbyFriend.FriendInfo blackInfo; // 0x10
	System.Void .ctor(); // 0x0610aa58
	System.Void <Refresh>b__0(FairyGUI.EventContext ctx); // 0x0610ad84
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiFriendGiftSelect : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	FairyGUI.GList itemList; // 0x338
	FairyGUI.GTextField textIntimacy; // 0x340
	WizardGames.Soc.SocClient.Ui.ComSliderBarBtn comSliderBarBtn; // 0x348
	FairyGUI.GComponent comSlider; // 0x350
	FairyGUI.GButton btnLess; // 0x358
	FairyGUI.GButton btnMore; // 0x360
	FairyGUI.GButton btnMax; // 0x368
	FairyGUI.GTextField friendlyAddValue; // 0x370
	FairyGUI.GTextField canSendCount; // 0x378
	FairyGUI.GButton btnSend; // 0x380
	FairyGUI.Controller intimacyCtrl; // 0x388
	WizardGames.Soc.SocClient.Ui.ComInfoButton tipsBtn; // 0x390
	LobbyFriend.FriendInfo selectedFriend; // 0x398
	System.Int32 selectedItemIndex; // 0x3a0
	System.Int32 selectedItemCount; // 0x3a4
	System.Int32 selectedItemAddValue; // 0x3a8
	System.Int32 friendshipMaxLimit; // 0x3ac
	WizardGames.Soc.Common.Data.resource.OBJGenaral selectedItem; // 0x3b0
	System.Boolean needFireMsgWhenSend; // 0x3b8
	System.Int32 previousIntimacy; // 0x3bc
	System.Int64 timerId; // 0x3c0
	System.Collections.Generic.Dictionary<System.String,System.Int32> counterKV; // 0x3c8
	System.Int32 availableCount; // 0x3d0
	System.Int32 giftCounter; // 0x3d4
	SimpleJSON.JSONObject msgNode; // 0x3d8
	System.Void OnInit(); // 0x0610ae44
	System.Void InitValue(); // 0x0610aebc
	System.Void InitCom(); // 0x0610b084
	System.Void InitItemList(); // 0x0610be28
	System.Void RefreshGiftList(); // 0x0610c370
	System.Void ResetGiftCom(); // 0x0610c0f0
	System.Void SetGiftItem(System.Int32 index, FairyGUI.GComponent giftCom); // 0x0610c4d8
	System.Void OnGiftItemClick(System.Int32 index, System.Int32 storageAmount, WizardGames.Soc.Common.Data.resource.OBJGenaral itemOBJ); // 0x0610ce3c
	System.Void SetComStep(System.Int32 max); // 0x0610d15c
	System.Void OnClickMax(); // 0x0610d978
	System.Void OnSliderValueChanged(); // 0x0610d73c
	System.Void RefreshStepResult(); // 0x0610d9ec
	System.Void InitSelectedFriend(LobbyFriend.FriendInfo friendInfo, System.Boolean fromFriendUI); // 0x0610dc78
	System.Void RefreshUIValue(); // 0x0610de58
	System.Void OnSendGift(); // 0x0610df94
	System.Void FireMsgWhenSendSucceed(System.Int32 lastValue); // 0x0610e5c0
	System.Void ReqSendGift(); // 0x0610e1e4
	System.Void ReqCounterValue(); // 0x0610b964
	System.Void SendGiftSuccess(System.Int32 sendCount, System.Int32 addValue, System.Int32 lastValue); // 0x0610e7f0
	System.Void OnEnable(); // 0x0610f00c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0610f074
	System.Void OnDisable(); // 0x0610f0f4
	System.Void ClearTimer(); // 0x0610c268
	System.Void .ctor(); // 0x0610f164
	static System.Void .cctor(); // 0x0610f1f0
	System.Void <OnSendGift>b__40_0(); // 0x0610f2c4
	System.Void <ReqSendGift>b__42_0(SimpleJSON.JSONNode info); // 0x0610f328
	System.Void <ReqSendGift>b__42_1(SimpleJSON.JSONNode error); // 0x0610f558
	System.Void <ReqCounterValue>b__43_0(SimpleJSON.JSONNode info); // 0x0610f81c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiFriendGiftSelect.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiFriendGiftSelect.<>c <>9; // 0x0
	static System.Action<SimpleJSON.JSONNode> <>9__43_1; // 0x8
	static System.Void .cctor(); // 0x0610facc
	System.Void .ctor(); // 0x0610fb30
	System.Void <ReqCounterValue>b__43_1(SimpleJSON.JSONNode error); // 0x0610fb98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiFriendGiftSelect.<>c__DisplayClass32_0 : System.Object
{
	WizardGames.Soc.Common.Data.resource.OBJGenaral item; // 0x10
	FairyGUI.GComponent giftCom; // 0x18
	WizardGames.Soc.SocClient.Ui.UiFriendGiftSelect <>4__this; // 0x20
	System.Int32 index; // 0x28
	System.Int32 storageAmount; // 0x2c
	System.Void .ctor(); // 0x0610cdd4
	System.Void <SetGiftItem>b__0(); // 0x0610fdd4
	System.Void <SetGiftItem>b__1(); // 0x0610fea4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyFriend : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	static SocLogger logger; // 0x0
	FairyGUI.GList listFriend; // 0x338
	FairyGUI.Controller pageControl; // 0x340
	FairyGUI.GButton btnRequestList; // 0x348
	FairyGUI.GButton btnBlackList; // 0x350
	WizardGames.Soc.SocClient.Ui.UiWinTempFriend winTempFriend; // 0x358
	WizardGames.Soc.SocClient.Ui.UiWinPlatformFriend winPlatformFriend; // 0x360
	FairyGUI.GComponent intiMacyTip; // 0x368
	FairyGUI.GComponent comSearch; // 0x370
	FairyGUI.Controller normalPageControl; // 0x378
	FairyGUI.GTextField friendNums; // 0x380
	FairyGUI.GButton btnClear; // 0x388
	FairyGUI.GList recentlyEncounteredList; // 0x390
	System.Boolean onSearchState; // 0x398
	static System.Single refreshTime; // 0x8
	System.Collections.Generic.List<LobbyFriend.FriendInfo> showFriendList; // 0x3a0
	System.Boolean <TempFriendWndIsOpen>k__BackingField; // 0x3a8
	FairyGUI.GComponent content; // 0x3b0
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar navBar; // 0x3b8
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x3c0
	FairyGUI.GComponent friendIntimacyCom; // 0x3c8
	FairyGUI.Transition intimacyAnim; // 0x3d0
	FairyGUI.GComponent comTextTitle; // 0x3d8
	WizardGames.Soc.SocClient.Ui.ComInfoButton btnInfo; // 0x3e0
	WizardGames.Soc.SocClient.Ui.UiLobbyFriend.EFriendPage currentPage; // 0x3e8
	System.Collections.Generic.List<WizardGames.Soc.Common.CustomType.EncounteredPlayer> encList; // 0x3f0
	System.Collections.Generic.List<LobbyFriend.FriendInfo> encInfos; // 0x3f8
	System.Void set_TempFriendWndIsOpen(System.Boolean value); // 0x0610ff18
	System.Void OnInit(); // 0x0610ff94
	System.Void UpdateBtnTipsInfo(); // 0x06112398
	System.Void UpdateEncounteredPlayers(); // 0x06112518
	System.Void RefreshEncounteredPlayers(); // 0x06112588
	System.Void InitEncounteredPlayers(); // 0x06111a04
	System.Void OnRenderRecentlyEncountered(System.Int32 index, FairyGUI.GObject item); // 0x06112734
	System.Void OnClickInviteEnc(LobbyFriend.FriendInfo friendInfo); // 0x061132e0
	System.Void OnEnable(); // 0x061133f8
	System.Void InitIntiMacyTip(); // 0x0611153c
	System.Void OnFps1Update(System.Single dt); // 0x061136dc
	System.Void SetPageControl(System.String page); // 0x06113750
	System.Void SetFriendNormalPageControl(System.String page); // 0x061137e0
	System.Void SetTempFriendNormalPageControl(System.String page); // 0x061138ac
	System.Void SetEncounteredNormalPageControl(System.String page); // 0x06112668
	System.Void OnClickInvite(LobbyFriend.FriendInfo friendInfo, FairyGUI.GButton btnInviteTeam); // 0x06113978
	System.Void OnClickGift(LobbyFriend.FriendInfo friendInfo, FairyGUI.GComponent intymacyCom); // 0x06113b0c
	System.Void RefreshRequestRed(); // 0x061135f8
	System.Void OnBtnRequestClick(); // 0x06113c80
	System.Void OnBtnBlackListClick(); // 0x06113d68
	System.Void BindComSearch(); // 0x061111a4
	System.Void Refresh(); // 0x06113540
	System.Void RefreshFriendIntimacy(System.String animName, System.String roleID, System.Int32 lastValue); // 0x061141fc
	System.Void OnClickSearch(System.String nameOrId); // 0x0611444c
	System.Void SearchPlayer(System.String nameOrId); // 0x06114630
	System.Void OnRenderListFriend(System.Int32 index, FairyGUI.GObject item); // 0x06114b34
	System.Void OnWechatAppWelfareClick(); // 0x06115940
	System.Void OnQQAppWelfareClick(); // 0x06115a50
	System.Void RefreshFriendShip(LobbyFriend.FriendInfo friendInfo, FairyGUI.GComponent com); // 0x061156b0
	System.Void LoadListFriend(System.Collections.Generic.List<LobbyFriend.FriendInfo> infos, System.Boolean isFromSearch); // 0x06113e2c
	System.Collections.Generic.List<LobbyFriend.FriendInfo> CheckFriendInfoContainName(System.String nameOrId); // 0x06114890
	System.Void OnDestroy(); // 0x06115b84
	System.Void OnDisable(); // 0x06115c1c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06115cf8
	System.Void OnClickLeftBtn(WizardGames.Soc.SocClient.Ui.UiLobbyFriend.EFriendPage page); // 0x06115df0
	System.Void .ctor(); // 0x06116194
	static System.Void .cctor(); // 0x061162c4
	System.Void <OnInit>b__32_0(WizardGames.Soc.SocClient.Ui.NavBarData navData, System.Boolean btnClicked); // 0x061163b0
	System.Void <InitEncounteredPlayers>b__38_1(SimpleJSON.JSONArray jsonArray); // 0x06116484
	System.Void <InitIntiMacyTip>b__42_0(); // 0x0611709c
	System.Void <RefreshFriendShip>b__63_0(); // 0x06117110
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiLobbyFriend.EFriendPage : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiLobbyFriend.EFriendPage Normal = 0;
	static WizardGames.Soc.SocClient.Ui.UiLobbyFriend.EFriendPage TempFriend = 1;
	static WizardGames.Soc.SocClient.Ui.UiLobbyFriend.EFriendPage RecentlyEncountered = 2;
	static WizardGames.Soc.SocClient.Ui.UiLobbyFriend.EFriendPage Platform = 3;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyFriend.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiLobbyFriend.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__32_2; // 0x8
	static FairyGUI.EventCallback0 <>9__32_1; // 0x10
	static System.Comparison<WizardGames.Soc.Common.CustomType.EncounteredPlayer> <>9__38_0; // 0x18
	static System.Void .cctor(); // 0x061175ac
	System.Void .ctor(); // 0x06117610
	System.Void <OnInit>b__32_2(); // 0x06117678
	System.Void <OnInit>b__32_1(); // 0x061179b8
	System.Int32 <InitEncounteredPlayers>b__38_0(WizardGames.Soc.Common.CustomType.EncounteredPlayer a, WizardGames.Soc.Common.CustomType.EncounteredPlayer b); // 0x06117a7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyFriend.<>c__DisplayClass39_0 : System.Object
{
	LobbyFriend.FriendInfo friendInfo; // 0x10
	WizardGames.Soc.SocClient.Ui.UiLobbyFriend <>4__this; // 0x18
	System.Void .ctor(); // 0x06117b24
	System.Void <OnRenderRecentlyEncountered>b__0(FairyGUI.EventContext ctx); // 0x06117b8c
	System.Void <OnRenderRecentlyEncountered>b__1(FairyGUI.EventContext ctx); // 0x06117ccc
	System.Void <OnRenderRecentlyEncountered>b__2(FairyGUI.EventContext ctx); // 0x06117d54
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyFriend.<>c__DisplayClass50_0 : System.Object
{
	LobbyFriend.FriendInfo friendInfo; // 0x10
	System.Void .ctor(); // 0x06117e20
	System.Void <OnClickGift>b__0(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x06117e88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyFriend.<>c__DisplayClass55_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLobbyFriend <>4__this; // 0x10
	FairyGUI.GTextInput textInput; // 0x18
	System.Void .ctor(); // 0x06117f60
	System.Void <BindComSearch>b__0(FairyGUI.EventContext ctx); // 0x06117fc8
	System.Void <BindComSearch>b__1(); // 0x061181c8
	System.Void <BindComSearch>b__2(); // 0x0611826c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyFriend.<>c__DisplayClass57_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLobbyFriend <>4__this; // 0x10
	System.Int32 lastValue; // 0x18
	System.Void .ctor(); // 0x061182fc
	System.Void <RefreshFriendIntimacy>b__0(); // 0x06118364
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyFriend.<>c__DisplayClass58_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLobbyFriend <>4__this; // 0x10
	System.String nameOrId; // 0x18
	System.Void .ctor(); // 0x0611842c
	System.Void <OnClickSearch>b__0(); // 0x06118494
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyFriend.<>c__DisplayClass60_0 : System.Object
{
	LobbyFriend.FriendInfo friendInfo; // 0x10
	WizardGames.Soc.SocClient.Ui.UiLobbyFriend <>4__this; // 0x18
	FairyGUI.GButton btnInviteTeam; // 0x20
	FairyGUI.GComponent com; // 0x28
	System.Void .ctor(); // 0x06118508
	System.Void <OnRenderListFriend>b__0(FairyGUI.EventContext ctx); // 0x06118570
	System.Void <OnRenderListFriend>b__1(FairyGUI.EventContext ctx); // 0x06118630
	System.Void <OnRenderListFriend>b__2(FairyGUI.EventContext ctx); // 0x061187c8
	System.Void <OnRenderListFriend>b__3(FairyGUI.EventContext ctx); // 0x06118884
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRequestListPop : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GComponent node; // 0x338
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x340
	FairyGUI.GButton btnAgreeAll; // 0x348
	FairyGUI.GButton btnRejectAll; // 0x350
	FairyGUI.GList listRequest; // 0x358
	FairyGUI.Controller showControl; // 0x360
	FairyGUI.GObject bac; // 0x368
	System.Void OnInit(); // 0x06118948
	System.Void ClickCallback(); // 0x06119650
	System.Void Refresh(); // 0x06118fa4
	System.Void OnDestroy(); // 0x0611971c
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06119790
	System.Void OnClickAgreeAll(); // 0x06119810
	System.Void OnClickRejectAll(); // 0x061198cc
	System.Void .ctor(); // 0x061199d0
	System.Void <OnInit>b__7_0(FairyGUI.EventContext ctx); // 0x06119a5c
	System.Void <OnInit>b__7_1(FairyGUI.EventContext ctx); // 0x06119ad4
	System.Void <OnInit>b__7_2(); // 0x06119b4c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiRequestListPop.<>c__DisplayClass10_0 : System.Object
{
	LobbyFriend.FriendInfo requestInfo; // 0x10
	WizardGames.Soc.SocClient.Ui.UiRequestListPop <>4__this; // 0x18
	System.Void .ctor(); // 0x061196b4
	System.Void <Refresh>b__0(FairyGUI.EventContext ctx); // 0x06119bc0
	System.Void <Refresh>b__1(FairyGUI.EventContext ctx); // 0x06119cd8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWinPlatformFriend : System.Object
{
	FairyGUI.GList friendListCom; // 0x10
	System.Collections.Generic.IReadOnlyList<LobbyFriend.PlatformFriendInfo> curFriendInfos; // 0x18
	System.Collections.Generic.IReadOnlyList<LobbyFriend.PlatformFriendInfo> friendInfos; // 0x20
	WizardGames.Soc.SocClient.Ui.UiLobbyFriend parentWin; // 0x28
	static SocLogger logger; // 0x0
	System.Void .ctor(FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.UiLobbyFriend lobbyFriend); // 0x06119df0
	System.Void OnEnable(); // 0x0611a2d0
	System.Void Close(); // 0x0611a334
	System.Void SearchPlayer(System.String nameOrId); // 0x0611a42c
	System.Void PullFriendInfo(); // 0x06118124
	System.Void Refresh(); // 0x06119fdc
	System.Void OnQQAppWelfareClick(); // 0x0611a794
	System.Void OnItemRender(System.Int32 index, FairyGUI.GObject item); // 0x0611a8c8
	System.Void OnInviteOrCallbackClick(System.String openID, System.String title, System.String desc, WizardGames.Soc.SocClient.EShareScene sceneId); // 0x0611c250
	System.Void OnClickPlatformInvite(System.String openID, System.String title, System.String desc, WizardGames.Soc.SocClient.EShareScene sceneId); // 0x0611c420
	System.Void OnClickInvite(System.String roleId, FairyGUI.GButton btnInviteTeam); // 0x0611c5e8
	System.Void OnClickSendMsg(System.String roleId); // 0x0611c774
	static System.Void .cctor(); // 0x0611c828
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWinPlatformFriend.<>c__DisplayClass12_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiWinPlatformFriend <>4__this; // 0x10
	LobbyFriend.PlatformFriendInfo friendInfo; // 0x18
	FairyGUI.GButton btnInviteTeam; // 0x20
	System.Void .ctor(); // 0x0611c1e8
	System.Void <OnItemRender>b__0(FairyGUI.EventContext ctx); // 0x0611c8fc
	System.Void <OnItemRender>b__1(FairyGUI.EventContext ctx); // 0x0611cc44
	System.Void <OnItemRender>b__2(FairyGUI.EventContext ctx); // 0x0611cf8c
	System.Void <OnItemRender>b__3(FairyGUI.EventContext ctx); // 0x0611d06c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWinTempFriend : System.Object
{
	FairyGUI.GList tempFriendListCom; // 0x10
	WizardGames.Soc.SocClient.Ui.UiLobbyFriend parentWin; // 0x18
	System.Collections.Generic.List<LobbyFriend.TempFriendInfo> tempFriendInfoList; // 0x20
	System.Void .ctor(FairyGUI.GComponent root, WizardGames.Soc.SocClient.Ui.UiLobbyFriend lobbyFriend); // 0x0611d148
	System.Void OnItemRender(System.Int32 index, FairyGUI.GObject obj); // 0x0611d320
	System.Void OnClickInvite(LobbyFriend.FriendInfo friendInfo, FairyGUI.GButton btnInviteTeam); // 0x0611e058
	System.Void Refresh(); // 0x0611e1ec
	System.Void Close(); // 0x0611e30c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiWinTempFriend.<>c__DisplayClass4_0 : System.Object
{
	LobbyFriend.FriendInfo friendInfo; // 0x10
	WizardGames.Soc.SocClient.Ui.UiWinTempFriend <>4__this; // 0x18
	FairyGUI.GButton btnInviteTeam; // 0x20
	System.Void .ctor(); // 0x0611dff0
	System.Void <OnItemRender>b__0(FairyGUI.EventContext ctx); // 0x0611e404
	System.Void <OnItemRender>b__1(FairyGUI.EventContext ctx); // 0x0611e4c0
	System.Void <OnItemRender>b__2(FairyGUI.EventContext ctx); // 0x0611e548
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComLotteryDrawLineEffect : System.Object
{
	static SocLogger logger; // 0x0
	UnityEngine.Vector2 startWorldPosition; // 0x10
	UnityEngine.Vector2 endWorldPosition; // 0x18
	UnityEngine.TrailRenderer trailRenderer; // 0x20
	System.Int64 timeId; // 0x28
	FairyGUI.GoWrapper wrapper; // 0x30
	System.Void .ctor(FairyGUI.GGraph loader, FairyGUI.GButton emptyBtn); // 0x0611e614
	System.Void OnTouchBegin(FairyGUI.EventContext ctx); // 0x0611e864
	UnityEngine.Vector3 ScreenToWorldPointPosition(UnityEngine.Vector3 inputPos); // 0x0611ec58
	System.Void OnTouchMove(FairyGUI.EventContext ctx); // 0x0611ed44
	System.Void OnTouchEnd(FairyGUI.EventContext ctx); // 0x0611ef10
	System.Void ForceDrawLineFinish(); // 0x0611f148
	System.Void OnDispose(); // 0x0611f2cc
	static System.Void .cctor(); // 0x0611f3b0
	System.Void <OnTouchBegin>b__11_0(System.Int64 _, System.Object _, System.Boolean _); // 0x0611f484
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComMultiVideo : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.ComVideo comVideo1; // 0x10
	WizardGames.Soc.SocClient.Ui.ComVideo comVideo2; // 0x18
	WizardGames.Soc.SocClient.Ui.ComVideo comVideo3; // 0x20
	UnityEngine.Coroutine coVideoAutoPlay; // 0x28
	UnityEngine.WaitForSeconds waitForSeconds; // 0x30
	System.Int64 timeId; // 0x38
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.ComVideo comVideo1, WizardGames.Soc.SocClient.Ui.ComVideo comVideo2, WizardGames.Soc.SocClient.Ui.ComVideo comVideo3); // 0x0611f518
	System.Void Clear(); // 0x0611fa6c
	System.Collections.IEnumerator PlayVideoAndPreLoadNextEnumertor(System.String videoName, System.String nextVideoName, System.Boolean isLoop, System.Boolean nextVideoLoop, System.Boolean isFirst, System.Action onPrepareCompleted1, System.Action onFinishedCompleted1, System.Action onFinishedCompleted2); // 0x0611fb74
	System.ValueTuple<WizardGames.Soc.SocClient.Ui.ComVideo,WizardGames.Soc.SocClient.Ui.ComVideo> GetNotPlayingVideo(); // 0x0611fd74
	System.Collections.IEnumerator PlayVideo(System.String videoName, System.Boolean isLoop, System.Action onPrepareCompleted, System.Action onFinishedCompleted); // 0x0611fe44
	System.Void PlayVideoAndPreLoadEnumertor(System.String videoName, System.String nextVideoName, System.Boolean isLoop, System.Boolean nextVideoLoop, System.Boolean isFirst, System.Action onPrepareCompleted1, System.Action onFinishedCompleted1, System.Action onFinishedCompleted2); // 0x0611ffdc
	System.Void PlayVideoEnumertor(System.String videoName, System.Boolean isLoop, System.Action onPrepareCompleted, System.Action onFinishedCompleted); // 0x06120338
	System.Void StopVideoAutoPlay(UnityEngine.MonoBehaviour env); // 0x061201bc
	static System.Void .cctor(); // 0x061204c4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComMultiVideo.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.ComMultiVideo.<>c <>9; // 0x0
	static System.Action<UnityEngine.Video.VideoPlayer> <>9__9_4; // 0x8
	static System.Action<UnityEngine.Video.VideoPlayer> <>9__12_2; // 0x10
	static System.Void .cctor(); // 0x06120598
	System.Void .ctor(); // 0x061205fc
	System.Void <PlayVideoAndPreLoadNextEnumertor>b__9_4(UnityEngine.Video.VideoPlayer player); // 0x06120664
	System.Void <PlayVideo>b__12_2(UnityEngine.Video.VideoPlayer player); // 0x0612072c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComMultiVideo.<>c__DisplayClass12_0 : System.Object
{
	System.Action onFinishedCompleted; // 0x10
	WizardGames.Soc.SocClient.Ui.ComVideo comVideoToPlay; // 0x18
	System.Void .ctor(); // 0x06120808
	System.Void <PlayVideo>b__0(UnityEngine.Video.VideoPlayer player); // 0x06120870
	System.Void <PlayVideo>b__1(UnityEngine.Video.VideoPlayer player); // 0x06120960
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComMultiVideo.<>c__DisplayClass9_0 : System.Object
{
	System.Action onFinishedCompleted2; // 0x10
	System.Boolean isFirst; // 0x18
	System.Boolean isFirstVideo; // 0x19
	WizardGames.Soc.SocClient.Ui.ComMultiVideo <>4__this; // 0x20
	WizardGames.Soc.SocClient.Ui.ComVideo comVideoToPlay; // 0x28
	WizardGames.Soc.SocClient.Ui.ComVideo comVideoPlaying; // 0x30
	System.Action onFinishedCompleted1; // 0x38
	WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__5; // 0x40
	System.Void .ctor(); // 0x06120a50
	System.Void <PlayVideoAndPreLoadNextEnumertor>b__0(UnityEngine.Video.VideoPlayer player); // 0x06120ab8
	System.Void <PlayVideoAndPreLoadNextEnumertor>b__1(UnityEngine.Video.VideoPlayer player); // 0x06120ba8
	System.Void <PlayVideoAndPreLoadNextEnumertor>b__5(System.Int64 _, System.Object _, System.Boolean _); // 0x06120de8
	System.Void <PlayVideoAndPreLoadNextEnumertor>b__2(UnityEngine.Video.VideoPlayer player); // 0x06120f1c
	System.Void <PlayVideoAndPreLoadNextEnumertor>b__3(UnityEngine.Video.VideoPlayer player); // 0x0612100c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComMultiVideo.<PlayVideo>d__12 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.Action onFinishedCompleted; // 0x20
	WizardGames.Soc.SocClient.Ui.ComMultiVideo <>4__this; // 0x28
	System.String videoName; // 0x30
	System.Boolean isLoop; // 0x38
	WizardGames.Soc.SocClient.Ui.ComMultiVideo.<>c__DisplayClass12_0 <>8__1; // 0x40
	System.Action onPrepareCompleted; // 0x48
	WizardGames.Soc.SocClient.Ui.ComVideo <comVideoPlaying>5__2; // 0x50
	System.Void .ctor(System.Int32 <>1__state); // 0x0611ff58
	System.Void System.IDisposable.Dispose(); // 0x061210fc
	System.Boolean MoveNext(); // 0x0612115c
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x06121b14
	System.Void System.Collections.IEnumerator.Reset(); // 0x06121b78
	System.Object System.Collections.IEnumerator.get_Current(); // 0x06121c00
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComMultiVideo.<PlayVideoAndPreLoadNextEnumertor>d__9 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.Action onFinishedCompleted2; // 0x20
	System.Boolean isFirst; // 0x28
	WizardGames.Soc.SocClient.Ui.ComMultiVideo <>4__this; // 0x30
	System.Action onFinishedCompleted1; // 0x38
	System.String videoName; // 0x40
	System.Boolean isLoop; // 0x48
	System.String nextVideoName; // 0x50
	System.Boolean nextVideoLoop; // 0x58
	WizardGames.Soc.SocClient.Ui.ComMultiVideo.<>c__DisplayClass9_0 <>8__1; // 0x60
	System.Action onPrepareCompleted1; // 0x68
	System.UInt64 <frameCount>5__2; // 0x70
	System.Void .ctor(System.Int32 <>1__state); // 0x0611fcf0
	System.Void System.IDisposable.Dispose(); // 0x06121c64
	System.Boolean MoveNext(); // 0x06121cc4
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x06122ac4
	System.Void System.Collections.IEnumerator.Reset(); // 0x06122b28
	System.Object System.Collections.IEnumerator.get_Current(); // 0x06122bb0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLotteryDrawCG : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.UiLotteryDrawCGBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComVideo comVideo; // 0x340
	WizardGames.Soc.SocClient.Ui.ComVideo comVideo1; // 0x348
	WizardGames.Soc.SocClient.Ui.ComVideo comVideo2; // 0x350
	System.Action onClose; // 0x358
	WizardGames.Soc.SocClient.Ui.ComSkipBtn comSkipBtn; // 0x360
	System.Int32 lotteryID; // 0x368
	WizardGames.Soc.SocClient.Manager.EMallLotteryType lotteryType; // 0x36c
	System.Boolean isTenLottery; // 0x370
	System.Boolean isHotResources; // 0x371
	System.Int32 MAX_REMAIN_UI_TIME; // 0x374
	System.Int64 timeId; // 0x378
	WizardGames.Soc.SocClient.Ui.ComMultiVideo comMultiVideo; // 0x380
	System.Collections.Generic.HashSet<System.String> PlayerSoundEventSet; // 0x388
	System.Boolean isClickWaitDoor; // 0x390
	WizardGames.Soc.SocClient.Ui.ESingleFragmentLotteryProgress singleLotteryProgress; // 0x394
	System.Int64 lotteryTipsTimeId; // 0x398
	WizardGames.Soc.SocClient.Ui.ETenFragmentLotteryProgress tenLotteryProgress; // 0x3a0
	WizardGames.Soc.SocClient.Ui.ComLotteryDrawLineEffect comDrawLine; // 0x3a8
	System.Void OnInit(); // 0x06122c14
	System.Void OnClickSkip(); // 0x0612375c
	System.Void OnEnable(); // 0x061238dc
	System.Void PlayGachaVideo(); // 0x061239f0
	System.Void CloseWindow(); // 0x061237c0
	System.Void OnDisable(); // 0x06123d3c
	System.Void StopAllSoundEvent(); // 0x06123fd4
	System.Void OnDestroy(); // 0x061241b4
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x061242a4
	System.Void MakeFullScreen(); // 0x0612432c
	System.Void SetData(System.Int32 lotteryID, WizardGames.Soc.SocClient.Manager.EMallLotteryType lotteryType, System.Action onClose, System.Boolean isTenLottery, System.Boolean isHotResources); // 0x061243d4
	static System.Void ShowLotteryCG(System.Int32 lotteryID, WizardGames.Soc.SocClient.Manager.EMallLotteryType lotteryType, System.Action onClose, System.Boolean isTenLottery, System.Boolean isHotResources); // 0x061245bc
	System.Void PlayVideo(System.String videoPath, System.Boolean isLoop); // 0x06123bc4
	System.Void InitClickEvent(); // 0x06123400
	System.Void SetTouchBtnStatus(System.Boolean isActive); // 0x061247cc
	System.Void OnClickDoor(WizardGames.Soc.SocClient.Ui.EFragmentClickPosition pos); // 0x06124a44
	System.Void PlayFragmentVideo(); // 0x061244f0
	System.Void PlayStartFragmentVideo(); // 0x061253a4
	System.Void PlayWaitDoorVideo(); // 0x06125900
	System.Void OnPlayChooseDoorVideo(WizardGames.Soc.SocClient.Ui.EFragmentClickPosition pos); // 0x06124be4
	System.Void PlayTenStartFragmentVideo(); // 0x06124f48
	System.Void OnLotteryDrawLineEnd(); // 0x06125c3c
	System.Void PlayTenWarningDoorVideo(); // 0x06125e2c
	System.Void PlayTenBlastDoorVideo(); // 0x06126130
	System.Void .ctor(); // 0x061262d4
	static System.Void .cctor(); // 0x061263b4
	System.Void <PlayGachaVideo>b__18_0(UnityEngine.Video.VideoPlayer player); // 0x06126488
	System.Void <PlayGachaVideo>b__18_1(UnityEngine.Video.VideoPlayer player); // 0x06126560
	System.Void <InitClickEvent>b__31_0(); // 0x061265d8
	System.Void <InitClickEvent>b__31_1(); // 0x06126640
	System.Void <InitClickEvent>b__31_2(); // 0x061266a8
	System.Void <PlayWaitDoorVideo>b__36_0(System.Int64 _, System.Object _, System.Boolean _); // 0x06126710
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLotteryDrawCG.<>c__DisplayClass26_0 : System.Object
{
	System.Int32 lotteryID; // 0x10
	WizardGames.Soc.SocClient.Manager.EMallLotteryType lotteryType; // 0x14
	System.Action onClose; // 0x18
	System.Boolean isTenLottery; // 0x20
	System.Boolean isHotResources; // 0x21
	System.Void .ctor(); // 0x06124764
	System.Void <ShowLotteryCG>b__0(WizardGames.Soc.SocClient.Ui.UiLotteryDrawCG win); // 0x061267ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLotteryDrawCG.<>c__DisplayClass35_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLotteryDrawCG <>4__this; // 0x10
	WizardGames.Soc.Common.Data.mall.OBJLotteryBaseInfo config; // 0x18
	System.Void .ctor(); // 0x06125898
	System.Void <PlayStartFragmentVideo>b__0(); // 0x0612687c
	System.Void <PlayStartFragmentVideo>b__1(System.Int64 _, System.Object _, System.Boolean _); // 0x061269d0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLotteryDrawCG.<>c__DisplayClass37_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLotteryDrawCG <>4__this; // 0x10
	System.String audioEventName; // 0x18
	System.Void .ctor(); // 0x06125b6c
	System.Void <OnPlayChooseDoorVideo>b__0(); // 0x06126cdc
	System.Void <OnPlayChooseDoorVideo>b__1(); // 0x06126e98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLotteryDrawCG.<>c__DisplayClass40_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLotteryDrawCG <>4__this; // 0x10
	WizardGames.Soc.Common.Data.mall.OBJLotteryBaseInfo config; // 0x18
	System.Void .ctor(); // 0x06125bd4
	System.Void <PlayTenStartFragmentVideo>b__0(); // 0x06126f0c
	System.Void <PlayTenStartFragmentVideo>b__1(System.Int64 _, System.Object _, System.Boolean _); // 0x0612700c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLotteryDrawCG.<>c__DisplayClass43_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLotteryDrawCG <>4__this; // 0x10
	WizardGames.Soc.Common.Data.mall.OBJLotteryBaseInfo config; // 0x18
	System.Void .ctor(); // 0x061260c8
	System.Void <PlayTenWarningDoorVideo>b__0(); // 0x061274f8
	System.Void <PlayTenWarningDoorVideo>b__1(); // 0x06127624
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.EFragmentClickPosition : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.EFragmentClickPosition Left = 0;
	static WizardGames.Soc.SocClient.Ui.EFragmentClickPosition Center = 1;
	static WizardGames.Soc.SocClient.Ui.EFragmentClickPosition Right = 2;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ESingleFragmentLotteryProgress : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ESingleFragmentLotteryProgress None = 0;
	static WizardGames.Soc.SocClient.Ui.ESingleFragmentLotteryProgress Start = 1;
	static WizardGames.Soc.SocClient.Ui.ESingleFragmentLotteryProgress WaitDoor = 2;
	static WizardGames.Soc.SocClient.Ui.ESingleFragmentLotteryProgress ChooseDoor = 3;
	static WizardGames.Soc.SocClient.Ui.ESingleFragmentLotteryProgress Completed = 4;
	
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ETenFragmentLotteryProgress : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ETenFragmentLotteryProgress None = 0;
	static WizardGames.Soc.SocClient.Ui.ETenFragmentLotteryProgress Start = 1;
	static WizardGames.Soc.SocClient.Ui.ETenFragmentLotteryProgress WaitDoor = 2;
	static WizardGames.Soc.SocClient.Ui.ETenFragmentLotteryProgress DrawLine = 3;
	static WizardGames.Soc.SocClient.Ui.ETenFragmentLotteryProgress Warning = 4;
	static WizardGames.Soc.SocClient.Ui.ETenFragmentLotteryProgress BlastDoor = 5;
	static WizardGames.Soc.SocClient.Ui.ETenFragmentLotteryProgress Completed = 6;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComLotteryBg : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.ComBgBinder bgBinder; // 0x10
	FairyGUI.GLoader loaderKV; // 0x18
	FairyGUI.GLoader loaderBg; // 0x20
	WizardGames.Soc.SocClient.Ui.ComVideo comVideo; // 0x28
	FairyGUI.Controller ctrlStyle; // 0x30
	System.String curStyle; // 0x38
	System.Action onVideoFinished; // 0x40
	System.Action onVideoPrepareComplete; // 0x48
	UnityEngine.Coroutine coVideoAutoPlay; // 0x50
	System.Boolean get_IsPlayingVideo(); // 0x06127698
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.ComBgBinder bgBinder); // 0x06127708
	System.Void ClearPreContent(System.Boolean disposeRes); // 0x06127a28
	System.Void ClearAllContent(System.Boolean playBgAnim); // 0x06127f88
	System.Void SetCurStyle(System.String style); // 0x06127ec8
	System.Void SetKV(System.String url, System.Boolean disposeRes); // 0x061280c8
	System.Void OnVideoPrepareCompleted(UnityEngine.Video.VideoPlayer player); // 0x0612835c
	System.Void OnVideoLoopPointReached(UnityEngine.Video.VideoPlayer player); // 0x06128444
	System.Void StopVideo(System.Boolean callFinished); // 0x06127d80
	System.Collections.IEnumerator AutoPlayVideoCo(System.String kv, System.String videoPath, System.Action onFinished, System.Action onVideoPrepareComplete); // 0x061284dc
	System.Void SetVideoAutoPlay(System.String kv, System.String videoPath, System.Action onFinished, System.Action onVideoPrepareComplete); // 0x0612867c
	System.Void StopVideoAutoPlay(UnityEngine.MonoBehaviour env); // 0x06127b9c
	static System.Void .cctor(); // 0x06128808
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComLotteryBg.<AutoPlayVideoCo>d__25 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	System.String kv; // 0x20
	WizardGames.Soc.SocClient.Ui.ComLotteryBg <>4__this; // 0x28
	System.Action onFinished; // 0x30
	System.Action onVideoPrepareComplete; // 0x38
	System.String videoPath; // 0x40
	WizardGames.Soc.SocClient.Ui.ComCommonVideo <commonVideo>5__2; // 0x48
	System.Void .ctor(System.Int32 <>1__state); // 0x061285f8
	System.Void System.IDisposable.Dispose(); // 0x061288dc
	System.Boolean MoveNext(); // 0x0612893c
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x06128d24
	System.Void System.Collections.IEnumerator.Reset(); // 0x06128d88
	System.Object System.Collections.IEnumerator.get_Current(); // 0x06128e10
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComLotteryPreview : System.Object
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.ComLotteryPreviewBinder binder; // 0x10
	FairyGUI.GList largeList; // 0x18
	FairyGUI.GList smallList; // 0x20
	FairyGUI.Controller styleCtrl; // 0x28
	System.Int32 overviewType; // 0x30
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.mall.OBJLotteryPoolRewards> resourceGroupIds; // 0x38
	WizardGames.Soc.SocClient.Ui.UiLotteryGroup win; // 0x40
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.ComLotteryPreviewBinder binder, WizardGames.Soc.SocClient.Ui.UiLotteryGroup win); // 0x06128e74
	System.Void SetData(System.Int32 overviewType, System.Collections.Generic.List<WizardGames.Soc.Common.Data.mall.OBJLotteryPoolRewards> resourceGroupIds, System.String title); // 0x06129074
	System.Void OnItemRender(System.Int32 index, FairyGUI.GObject gObject); // 0x06129250
	System.Void OnClickPreview(WizardGames.Soc.Common.Data.mall.OBJLotteryPoolRewards reward); // 0x0612974c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComLotteryPreview.<>c__DisplayClass9_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ComLotteryPreview <>4__this; // 0x10
	WizardGames.Soc.Common.Data.mall.OBJLotteryPoolRewards rewardConfig; // 0x18
	System.Void .ctor(); // 0x061296e4
	System.Void <OnItemRender>b__0(WizardGames.Soc.SocClient.Ui.ComBaseIcon baseIcon); // 0x06129e64
	System.Void <OnItemRender>b__1(WizardGames.Soc.SocClient.Ui.ComBaseIcon baseIcon); // 0x06129ee8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UILotteryActiveDraw : WizardGames.Soc.SocClient.Ui.UiLotteryDrawBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.Common.Data.common.OBJConditionSwitch conditionSwitch; // 0x30
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.UiLotteryDrawBinder binder; // 0x38
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.RootLotteryDrawContentBinder lotteryDrawContentBinder; // 0x40
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.BtnBuyBinder btnBuyBinder; // 0x48
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.BtnBuyBinder btnBuy2Binder; // 0x50
	FairyGUI.GTextField countDownTxt; // 0x58
	WizardGames.Soc.SocClient.Ui.ComLotteryBg ComBg; // 0x60
	WizardGames.Soc.SocClient.Ui.ComTopBar comTopBar; // 0x68
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.UiLotteryDraw uiLotteryDraw); // 0x06129f6c
	System.Void OnEnable(System.Int32 lotteryID); // 0x0612a1d8
	System.Void OnDisable(); // 0x0612a3e4
	System.Void OnRefresh(System.Int32 lotteryID, System.Boolean isPlayFullScreenVideo, System.Boolean switchPool); // 0x0612a610
	System.Void OnDestroy(); // 0x0612b5d0
	System.Void OnLotteryBtn(); // 0x0612b758
	System.Void OnLotteryTenBtn(); // 0x0612bc0c
	System.Boolean CheckLotteryButton(System.Int32 times); // 0x0612b818
	System.Void OnDetailBtn(); // 0x0612bccc
	System.Void OnClickLotteryDetail(); // 0x0612bd40
	System.Void OnPlayBtn(); // 0x0612be6c
	System.Void RefreshCurrency(); // 0x0612becc
	System.Void RefreshLotteryBtn(); // 0x0612c3a8
	System.Void PlayBgm(); // 0x0612c7c4
	System.Void OnFps1Update(); // 0x0612c824
	System.Void OnShowByLayerStack(); // 0x0612c918
	System.Void .ctor(); // 0x0612ca2c
	static System.Void .cctor(); // 0x0612cb54
	System.Void <OnClickLotteryDetail>b__20_0(WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreview win); // 0x0612cc28
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UILotteryActiveDraw.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UILotteryActiveDraw.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__22_2; // 0x8
	static System.Void .cctor(); // 0x0612ccb0
	System.Void .ctor(); // 0x0612cd14
	System.Void <RefreshCurrency>b__22_2(); // 0x0612cd7c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UILotteryActiveDraw.<>c__DisplayClass22_0 : System.Object
{
	System.Int32 costResourceID; // 0x10
	WizardGames.Soc.SocClient.Ui.UILotteryActiveDraw <>4__this; // 0x18
	WizardGames.Soc.Common.Data.resource.OBJGenaral costConfig; // 0x20
	System.Void .ctor(); // 0x0612c340
	System.String <RefreshCurrency>b__0(); // 0x0612ce04
	System.Void <RefreshCurrency>b__1(); // 0x0612cec4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLotteryDraw : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update, WizardGames.Soc.SocClient.Ui.IJumpToUIWindow
{
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Manager.EMallLotteryType,System.Func<WizardGames.Soc.SocClient.Ui.UiLotteryDrawBase>> pageRegister; // 0x338
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Manager.EMallLotteryType,WizardGames.Soc.SocClient.Ui.UiLotteryDrawBase> lotteryPages; // 0x340
	static SocLogger logger; // 0x0
	static System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Manager.EMallLotteryType> lotteryTypeMap; // 0x8
	System.Int32 curLotteryID; // 0x348
	WizardGames.Soc.SocClient.Manager.EMallLotteryType curLotteryType; // 0x34c
	WizardGames.Soc.SocClient.Ui.ComTopBar comTopBar; // 0x350
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar commonNavBar; // 0x358
	System.Collections.Generic.List<System.Int32> lotteryList; // 0x360
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.NavBarData> navBarDataList; // 0x368
	WizardGames.Soc.SocClient.Ui.ComLotteryBg <ComBg>k__BackingField; // 0x370
	WizardGames.Soc.SocClient.Ui.UiLotteryDrawBase curLotteryDraw; // 0x378
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.UiLotteryDrawBinder binder; // 0x380
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.RootLotteryDrawContentBinder lotteryDrawContentBinder; // 0x388
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.BtnBuyBinder btnBuyBinder; // 0x390
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.BtnBuyBinder btnBuy2Binder; // 0x398
	FairyGUI.GTextField countDownTxt; // 0x3a0
	System.Boolean initBGMBank; // 0x3a8
	System.Action OnBankBGMLoaded; // 0x3b0
	WizardGames.Soc.SocClient.Ui.ComLotteryBg get_ComBg(); // 0x0612d040
	System.Void set_ComBg(WizardGames.Soc.SocClient.Ui.ComLotteryBg value); // 0x0612d0a4
	System.Void OnInit(); // 0x0612d124
	System.Void PostEventFinishedCallback(WizardGames.Soc.SocClient.Audio.WWise.AudioEventData audioeventdata, System.Object obj); // 0x0612e2d8
	System.Void InitNavBar(); // 0x0612dcd0
	System.Void RefreshRedDot(); // 0x0612e4b0
	System.Boolean IsTabRed(System.Int32 lotteryId); // 0x0612e668
	System.Void OnEnable(); // 0x0612e6f0
	System.Void OnShowByLayerStack(); // 0x0612ed48
	System.Void OnDisable(); // 0x0612ee3c
	System.Void OnDestroy(); // 0x0612f1b4
	System.Void OnDrawGachaInfoUpdate(System.Int32 lotteryID); // 0x0612f41c
	System.Void OnGachaInfoUpdate(); // 0x0612f67c
	System.Void OnMallBundleInfoUpdate(); // 0x0612f6ec
	System.Void OnMallItemIdInfoUpdate(System.Int32 mallItemShopId); // 0x0612f7a8
	System.Void OnCloseLotteryInnerVideo(); // 0x0612f870
	System.Void SetData(System.Int32 lotteryID); // 0x0612eb08
	System.Void RefreshLotteryUI(System.Int32 lotteryID, System.Boolean isPlayFullScreenVideo, System.Boolean switchPool); // 0x0612f4bc
	System.Void OnResetInnerVideoPlayer(); // 0x0612fcb0
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0612fd20
	System.Void OnFps1Update(System.Single dt); // 0x0612fea4
	System.Void JumpToUIWindow(WizardGames.Soc.SocClient.Ui.JumpData jumpData); // 0x0612ff3c
	static System.Void ShowLotteryDraw(System.Int32 lotteryID); // 0x061301e8
	System.Void SwitchLotteryPage(System.Int32 lotteryId, System.Boolean isPlayFullScreenVideo, System.Boolean switchPool); // 0x0612f92c
	System.Boolean IsGachaPoolRead(System.Int32 lotteryId); // 0x0612e3dc
	System.Void SetGachaPoolRead(System.Int32 lotteryId); // 0x061304f0
	System.String GenerateSaveKey(System.Int32 lotteryId); // 0x06130424
	static System.Boolean IsValidDrawLottery(System.Int32 lotteryId); // 0x061300c0
	System.Void OnLotteryBtn(); // 0x061305bc
	System.Void OnLotteryTenBtn(); // 0x06130630
	System.Void OnPlayBtn(); // 0x061306a8
	System.Void OnClickLotteryDetail(); // 0x06130720
	System.Void OnDetailBtn(); // 0x06130798
	System.Void .ctor(); // 0x06130810
	static System.Void .cctor(); // 0x06130b54
	System.Void <InitNavBar>b__25_0(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x06130c80
	System.Void <SetData>b__37_0(System.Object param); // 0x06130d90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLotteryDraw.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiLotteryDraw.<>c <>9; // 0x0
	static System.Func<WizardGames.Soc.SocClient.Ui.UiLotteryDrawBase> <>9__54_0; // 0x8
	static System.Func<WizardGames.Soc.SocClient.Ui.UiLotteryDrawBase> <>9__54_1; // 0x10
	static System.Func<WizardGames.Soc.SocClient.Ui.UiLotteryDrawBase> <>9__54_2; // 0x18
	static System.Void .cctor(); // 0x06130e10
	System.Void .ctor(); // 0x06130e74
	WizardGames.Soc.SocClient.Ui.UiLotteryDrawBase <.ctor>b__54_0(); // 0x06130edc
	WizardGames.Soc.SocClient.Ui.UiLotteryDrawBase <.ctor>b__54_1(); // 0x06130fec
	WizardGames.Soc.SocClient.Ui.UiLotteryDrawBase <.ctor>b__54_2(); // 0x061311a0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLotteryDraw.<>c__DisplayClass44_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLotteryDrawBase tarPage; // 0x10
	System.Int32 lotteryId; // 0x18
	WizardGames.Soc.SocClient.Ui.UiLotteryDraw <>4__this; // 0x20
	System.Void .ctor(); // 0x061303bc
	System.Void <SwitchLotteryPage>b__0(); // 0x06131228
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.ELotteryDrawDetailType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.ELotteryDrawDetailType ProbabilityPage = 0;
	static WizardGames.Soc.SocClient.Ui.ELotteryDrawDetailType RulePage = 1;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLotteryDrawBase : System.Object
{
	static SocLogger logger; // 0x0
	System.Int32 lotteryID; // 0x10
	WizardGames.Soc.SocClient.Ui.UiLotteryDraw uiLotteryDraw; // 0x18
	WizardGames.Soc.SocClient.Ui.Utils.WindowCDTime windowCDTime; // 0x20
	System.Boolean isActive; // 0x28
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.UiLotteryDraw uiLotteryDraw); // 0x0613131c
	System.Void OnEnable(System.Int32 lotteryID); // 0x0612a270
	System.Void OnDisable(); // 0x0612a448
	System.Void OnRefresh(System.Int32 lotteryID, System.Boolean isPlayFullScreenVideo, System.Boolean switchPool); // 0x0613139c
	System.Void OnDestroy(); // 0x0612b68c
	System.Void OnShowByLayerStack(); // 0x0612c9b4
	System.Void SetKV(System.String kvPath); // 0x06131430
	System.Void AutoPlayLotteryPv(); // 0x06131570
	System.Void OnLotteryBtn(); // 0x061315d0
	System.Void OnLotteryTenBtn(); // 0x06131630
	System.Void OnClickLotteryDetail(); // 0x06131690
	System.Void OnMallItemInfoUpdate(System.Int32 shopId); // 0x061316f0
	System.Void OnDetailBtn(); // 0x055049cc
	System.Void OnPlayBtn(); // 0x055049cc
	System.Void RefreshCurrency(); // 0x055049cc
	System.Void RefreshLotteryBtn(); // 0x055049cc
	System.Void PlayBgm(); // 0x055049cc
	System.Void OnFps1Update(); // 0x055049cc
	System.Void .ctor(); // 0x0612cab4
	static System.Void .cctor(); // 0x06131764
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UILotteryFragmentDraw : WizardGames.Soc.SocClient.Ui.UiLotteryDrawBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.ComRollPosterBinder mallExchangeBinder; // 0x30
	WizardGames.Soc.Common.Data.mall.OBJLotteryBaseInfo curTBLotteryBaseInfo; // 0x38
	WizardGames.Soc.SocClient.Manager.FragmentLotteryInfo serverLotteryInfo; // 0x40
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.MedalRewardItemBinder> comRewardItemMap; // 0x48
	WizardGames.Soc.Common.Data.common.OBJConditionSwitch conditionSwitch; // 0x50
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.HashSet<System.Int32>> progressIdMap; // 0x58
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.UiLotteryDrawBinder binder; // 0x60
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.RootLotteryDrawContentBinder lotteryDrawContentBinder; // 0x68
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.BtnBuyBinder btnBuyBinder; // 0x70
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.BtnBuyBinder btnBuy2Binder; // 0x78
	FairyGUI.GTextField countDownTxt; // 0x80
	WizardGames.Soc.SocClient.Ui.ComLotteryBg ComBg; // 0x88
	WizardGames.Soc.SocClient.Ui.ComTopBar comTopBar; // 0x90
	System.Boolean needAutoLottery; // 0x98
	System.Int32 curMallItemId; // 0x9c
	System.Int32 curLotteryCount; // 0xa0
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.UiLotteryDraw uiLotteryDraw); // 0x06131838
	System.Void OnClickMallExchange(FairyGUI.EventContext context); // 0x061320b0
	System.Void OnEnable(System.Int32 lotteryID); // 0x0613212c
	System.Void OnDisable(); // 0x0613247c
	System.Void OnMallItemInfoUpdate(System.Int32 shopId); // 0x0613269c
	System.Void ClearCostNoEoughData(); // 0x06132414
	System.Void DoDrawLottery(System.Int32 lotteryCount); // 0x0613288c
	System.Void OnLotteryProgressReward(System.Int32 lotteryId); // 0x06132c10
	System.Void OnLotteryProgressFinish(System.Boolean isInProgress); // 0x06133664
	System.Void OnCloseDoorAnimationCompleted(); // 0x06133748
	System.Void OnRefresh(System.Int32 lotteryID, System.Boolean isPlayFullScreenVideo, System.Boolean switchPool); // 0x06133804
	System.Void OnDestroy(); // 0x061344b0
	System.Void OnShowByLayerStack(); // 0x0613456c
	System.Void OnLotteryBtn(); // 0x06134644
	System.Void OnLotteryTenBtn(); // 0x06134bc0
	System.Void OnClickSkipAnimation(); // 0x061350bc
	System.Void OnDetailBtn(); // 0x06135200
	System.Void AutoPlayLotteryPv(); // 0x06135274
	System.Void OnPlayBtn(); // 0x0613566c
	System.Void OnClickLotteryDetail(); // 0x06135a0c
	System.Void RefreshCurrency(); // 0x06135b38
	System.Void RefreshLotteryBtn(); // 0x061363f8
	System.Void PlayBgm(); // 0x06136a28
	System.Void SetKV(System.String kvPath); // 0x06136ac4
	System.Void RefreshProgressReward(); // 0x061331f4
	System.Void RefreshMallEnterance(); // 0x06132cac
	System.Void OnMallEnteranceItemRender(System.Int32 index, FairyGUI.GObject gObject); // 0x06136b40
	System.Void OnProgressRewardItemRender(System.Int32 index, FairyGUI.GObject gObject); // 0x06136c24
	System.Void OnFps1Update(); // 0x06137348
	System.Void OnClickReward(FairyGUI.GObject obj, System.Int32 rewardId, System.Int32 index, FairyGUI.GComponent rewardItemCom); // 0x0613743c
	System.Void .ctor(); // 0x06131074
	static System.Void .cctor(); // 0x061377dc
	System.Void <OnInit>b__19_0(FairyGUI.EventContext ctx); // 0x061378b0
	System.Void <OnClickLotteryDetail>b__39_0(WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreview win); // 0x06137928
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UILotteryFragmentDraw.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UILotteryFragmentDraw.<>c <>9; // 0x0
	static System.Action <>9__37_1; // 0x8
	static System.Action <>9__38_1; // 0x10
	static FairyGUI.EventCallback0 <>9__40_2; // 0x18
	static FairyGUI.EventCallback1 <>9__40_4; // 0x20
	static FairyGUI.EventCallback0 <>9__40_6; // 0x28
	static System.Void .cctor(); // 0x061379b0
	System.Void .ctor(); // 0x06137a14
	System.Void <AutoPlayLotteryPv>b__37_1(); // 0x06137a7c
	System.Void <OnPlayBtn>b__38_1(); // 0x06137b18
	System.Void <RefreshCurrency>b__40_2(); // 0x06137bb4
	System.Void <RefreshCurrency>b__40_4(FairyGUI.EventContext context); // 0x06137c3c
	System.Void <RefreshCurrency>b__40_6(); // 0x06137d0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UILotteryFragmentDraw.<>c__DisplayClass37_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UILotteryFragmentDraw <>4__this; // 0x10
	WizardGames.Soc.Common.Data.mall.OBJLotteryBaseInfo lotteryInfo; // 0x18
	System.Void .ctor(); // 0x06135604
	System.Void <AutoPlayLotteryPv>b__0(); // 0x06137d94
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UILotteryFragmentDraw.<>c__DisplayClass38_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UILotteryFragmentDraw <>4__this; // 0x10
	WizardGames.Soc.Common.Data.mall.OBJLotteryBaseInfo lotteryInfo; // 0x18
	System.Void .ctor(); // 0x061359a4
	System.Void <OnPlayBtn>b__0(); // 0x06137f1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UILotteryFragmentDraw.<>c__DisplayClass40_0 : System.Object
{
	System.Int32 costResourceID; // 0x10
	WizardGames.Soc.SocClient.Ui.UILotteryFragmentDraw <>4__this; // 0x18
	WizardGames.Soc.Common.Data.resource.OBJGenaral costConfig; // 0x20
	System.Int32 currencyNum; // 0x28
	WizardGames.Soc.Common.Data.resource.OBJGenaral currencyConfig; // 0x30
	System.Void .ctor(); // 0x06136390
	System.String <RefreshCurrency>b__0(); // 0x061380c4
	System.Void <RefreshCurrency>b__1(); // 0x06138184
	System.String <RefreshCurrency>b__3(); // 0x06138308
	System.Void <RefreshCurrency>b__5(); // 0x06138370
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UILotteryFragmentDraw.<>c__DisplayClass47_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UILotteryFragmentDraw <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.MedalRewardItemBinder binder; // 0x18
	System.Int32 rewardId; // 0x20
	System.Int32 realIndex; // 0x24
	FairyGUI.GComponent item; // 0x28
	System.Void .ctor(); // 0x061372e0
	System.Void <OnProgressRewardItemRender>b__0(FairyGUI.EventContext content); // 0x061384f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UILotteryGachaDraw : WizardGames.Soc.SocClient.Ui.UiLotteryDrawBase
{
	static SocLogger logger; // 0x0
	System.Boolean initBGMBank; // 0x29
	WizardGames.Soc.Common.Data.common.OBJConditionSwitch conditionSwitch; // 0x30
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.UiLotteryDrawBinder binder; // 0x38
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.RootLotteryDrawContentBinder lotteryDrawContentBinder; // 0x40
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.BtnBuyBinder btnBuyBinder; // 0x48
	FairyGUI.GTextField countDownTxt; // 0x50
	WizardGames.Soc.SocClient.Ui.ComLotteryBg ComBg; // 0x58
	WizardGames.Soc.SocClient.Ui.ComTopBar comTopBar; // 0x60
	System.Boolean needAutoLottery; // 0x68
	System.Int32 curMallItemId; // 0x6c
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.UiLotteryDraw uiLotteryDraw); // 0x061385d4
	System.Void OnEnable(System.Int32 lotteryID); // 0x061387f0
	System.Void OnDisable(); // 0x061389e0
	System.Void OnRefresh(System.Int32 lotteryID, System.Boolean isPlayFullScreenVideo, System.Boolean switchPool); // 0x06138a4c
	System.Void OnDestroy(); // 0x061397fc
	System.Void OnLotteryBtn(); // 0x06139860
	System.Void DoDrawLottery(); // 0x06139d54
	System.Void OnMallItemInfoUpdate(System.Int32 shopId); // 0x0613a0c4
	System.Void ClearCostNoEoughData(); // 0x06138978
	System.Void OnDetailBtn(); // 0x0613a2b0
	System.Void AutoPlayLotteryPv(); // 0x0613a338
	System.Void OnPlayBtn(); // 0x0613a720
	System.Void OnClickLotteryDetail(); // 0x0613aab8
	System.Void OnShowByLayerStack(); // 0x0613abe4
	System.Void RefreshCurrency(); // 0x0613ac50
	System.Void RefreshLotteryBtn(); // 0x0613b4c4
	System.Void PlayBgm(); // 0x0613b9b8
	System.Void SetKV(System.String kvPath); // 0x0613ba54
	System.Void OnFps1Update(); // 0x0613bad0
	System.Void .ctor(); // 0x06130f64
	static System.Void .cctor(); // 0x0613bbc4
	System.Void <OnClickLotteryDetail>b__26_0(WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreview win); // 0x0613bc98
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UILotteryGachaDraw.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UILotteryGachaDraw.<>c <>9; // 0x0
	static System.Action <>9__24_1; // 0x8
	static System.Action <>9__25_1; // 0x10
	static FairyGUI.EventCallback0 <>9__28_2; // 0x18
	static FairyGUI.EventCallback1 <>9__28_4; // 0x20
	static FairyGUI.EventCallback0 <>9__28_6; // 0x28
	static System.Void .cctor(); // 0x0615b1a8
	System.Void .ctor(); // 0x0615b20c
	System.Void <AutoPlayLotteryPv>b__24_1(); // 0x0615b274
	System.Void <OnPlayBtn>b__25_1(); // 0x0615b310
	System.Void <RefreshCurrency>b__28_2(); // 0x0615b3ac
	System.Void <RefreshCurrency>b__28_4(FairyGUI.EventContext context); // 0x0615b434
	System.Void <RefreshCurrency>b__28_6(); // 0x0615b504
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UILotteryGachaDraw.<>c__DisplayClass24_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UILotteryGachaDraw <>4__this; // 0x10
	WizardGames.Soc.Common.Data.mall.OBJWithoutReplacementLotteryInfo lotteryInfo; // 0x18
	System.Void .ctor(); // 0x0615b58c
	System.Void <AutoPlayLotteryPv>b__0(); // 0x0615b5f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UILotteryGachaDraw.<>c__DisplayClass25_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UILotteryGachaDraw <>4__this; // 0x10
	WizardGames.Soc.Common.Data.mall.OBJWithoutReplacementLotteryInfo lotteryInfo; // 0x18
	System.Void .ctor(); // 0x0615b880
	System.Void <OnPlayBtn>b__0(); // 0x0615b8e8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UILotteryGachaDraw.<>c__DisplayClass28_0 : System.Object
{
	System.Int32 costResourceID; // 0x10
	WizardGames.Soc.SocClient.Ui.UILotteryGachaDraw <>4__this; // 0x18
	WizardGames.Soc.Common.Data.resource.OBJGenaral costConfig; // 0x20
	System.Int32 currencyNum; // 0x28
	WizardGames.Soc.Common.Data.resource.OBJGenaral currencyConfig; // 0x30
	System.Void .ctor(); // 0x0615ba8c
	System.String <RefreshCurrency>b__0(); // 0x0615baf4
	System.Void <RefreshCurrency>b__1(); // 0x0615bbb4
	System.String <RefreshCurrency>b__3(); // 0x0615bd38
	System.Void <RefreshCurrency>b__5(); // 0x0615bda0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreview : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	static SocLogger logger; // 0x0
	System.Collections.Generic.Dictionary<WizardGames.Soc.SocClient.Manager.EMallLotteryType,System.Func<WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreviewBase>> pageRegister; // 0x338
	WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreviewBase currentPage; // 0x340
	System.Int32 curLotteryID; // 0x348
	WizardGames.Soc.SocClient.Ui.ComTopBar comTopBar; // 0x350
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.UiLottertDrawDetailBinder binder; // 0x358
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.RootLottertDrawDetailBinder rootBinder; // 0x360
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.RootLottertDrawDetailContentBinder detailContentBinder; // 0x368
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.ComBuyDetailBinder buyDetailBinder; // 0x370
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.BtnBuyBinder btnBuyBinder; // 0x378
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.BtnBuyBinder btnBuy2Binder; // 0x380
	FairyGUI.GTextField countdownText; // 0x388
	FairyGUI.Controller ctrlRare; // 0x390
	WizardGames.Soc.SocClient.Ui.ComSceneModel comSceneModel; // 0x398
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> modelShowCfg; // 0x3a0
	WizardGames.Soc.SocClient.Manager.RotateModeConstraintAngle rotateModel; // 0x3a8
	WizardGames.Soc.SocClient.Manager.RotateModeConstraintAngleParams rotateAllParam; // 0x3b0
	WizardGames.Soc.SocClient.Manager.RotateModeConstraintAngleParams rotateHorizontalParam; // 0x3b8
	System.Int32 azureType; // 0x3c0
	System.Int32 newPreset; // 0x3c4
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.LotteryResInfo> allSubRes; // 0x3c8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComResIcon> allResIcons; // 0x3d0
	System.Int32 curShowResId; // 0x3d8
	FairyGUI.GButton skinModifyBtn; // 0x3e0
	WizardGames.Soc.SocClient.Ui.SprayBinder sprayBinder; // 0x3e8
	FairyGUI.GGraph fxRoot; // 0x3f0
	FairyGUI.GoWrapper fxSpray; // 0x3f8
	System.Boolean isPlayFX; // 0x400
	System.Single allFXTime; // 0x404
	System.Single playFXTime; // 0x408
	System.Boolean isInitFX; // 0x40c
	System.Int32 curBgId; // 0x410
	System.String originalBgUrl; // 0x418
	System.Int32 selectedIndex; // 0x420
	WizardGames.Soc.SocClient.Ui.ModelConfig playerModelConfig; // 0x428
	System.Int64 timerSprayId; // 0x430
	System.Void OnInit(); // 0x0615bf24
	System.Void InitTODData(); // 0x0615cb6c
	System.Int32 OnSwitchBgId(System.Int32 id); // 0x0615ccc0
	System.Void SetLotteryTodData(System.Int32 id); // 0x0615cfe8
	System.Void OnEnable(); // 0x0615d2d0
	System.Void OnDisable(); // 0x0615d55c
	System.Void OnDestroy(); // 0x0615db08
	System.Void Clear(); // 0x0615d9c4
	System.Void RecoverTODOnExit(); // 0x0615db88
	System.Void OnShowByLayerStack(); // 0x0615dbe8
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0615dc80
	System.Void RefreshLotteryUI(System.Int32 lotteryID); // 0x0615dd00
	System.Void OpenWin(System.Int32 lotteryID); // 0x0615df60
	System.Void RefreshRewardList(); // 0x0615e18c
	System.Void SelectLotteryPage(System.Int32 lotteryID); // 0x0615dd7c
	System.Void OnFps1Update(System.Single dt); // 0x0615e2d0
	System.Void OnLotteryBtn(); // 0x0615e368
	System.Void OnTenLotteryBtn(); // 0x0615e3dc
	System.Void OnDetailBtn(); // 0x0615e450
	System.Void OnClickCommonPreview(); // 0x0615e4c8
	System.Void OnClickModifySkin(); // 0x0615e5d4
	System.Void OnDrawGachaInfoUpdate(System.Int32 lotteryID); // 0x0615e68c
	System.Void OnGachaInfoUpdate(); // 0x0615e708
	System.Void OnMallBundleInfoUpdate(); // 0x0615e770
	System.Void OnMallItemIdInfoUpdate(System.Int32 shopId); // 0x0615e7e8
	System.Void ResItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x0615e870
	System.Void OnClickResIcon(System.Int32 index, WizardGames.Soc.SocClient.Ui.ComBaseIcon icon, WizardGames.Soc.Common.Data.resource.OBJGenaral resCfg, WizardGames.Soc.SocClient.Ui.LotteryResInfo info); // 0x0615ecd0
	System.Void RefreshResShow(WizardGames.Soc.Common.Data.resource.OBJGenaral resCfg); // 0x0615f098
	WizardGames.Soc.SocClient.Ui.ModelConfig GetModelConfigByResId(System.Int32 resId); // 0x06160088
	System.Void Refresh2DResShow(WizardGames.Soc.Common.Data.resource.OBJGenaral resCfg, WizardGames.Soc.Common.Data.resource.ENUMSkinType type); // 0x0616039c
	System.Void OnFxSprayDispose(); // 0x0616112c
	System.Void PlaySprayFX(System.Int32 id); // 0x055056e8
	System.Void Refresh2DResBg(WizardGames.Soc.Common.Data.resource.OBJGenaral resCfg, WizardGames.Soc.Common.Data.resource.ENUMSkinType type); // 0x06160aa4
	System.Void OnModelScenePrepared(UnityEngine.GameObject objModel, UnityEngine.GameObject objBg); // 0x061611d8
	System.Void SwitchCustomWeather(); // 0x061613f4
	System.Boolean IsNeedToShowPlayerModel(WizardGames.Soc.Common.Data.resource.OBJGenaral resCfg, System.Collections.Generic.Dictionary<System.Int32,System.Int32> res); // 0x0615f5f0
	System.Boolean IsNeedToShowCostumeSuitModel(WizardGames.Soc.Common.Data.resource.OBJGenaral resCfg, System.Collections.Generic.Dictionary<System.Int32,System.Int32> res, System.Int32& sex); // 0x0615f844
	System.Boolean IsNeedToShowFixedPackPlayerModel(WizardGames.Soc.Common.Data.resource.OBJGenaral resCfg, System.Collections.Generic.Dictionary<System.Int32,System.Int32> res, System.Int32& sex); // 0x0615fbbc
	System.Boolean IsNeedToShow2DRes(WizardGames.Soc.Common.Data.resource.OBJGenaral resCfg, WizardGames.Soc.Common.Data.resource.ENUMSkinType& skinType); // 0x0615ff44
	System.Void UpdateModifyState(); // 0x0615f4b4
	System.Void StopSprayFX(); // 0x0615d874
	System.Void UpdateFPS(System.Int64 timeId, System.Object callbackData, System.Boolean needDelete); // 0x0616156c
	System.Void .ctor(); // 0x06161654
	static System.Void .cctor(); // 0x06161c0c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreview.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreview.<>c <>9; // 0x0
	static System.Func<WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreviewBase> <>9__78_0; // 0x8
	static System.Func<WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreviewBase> <>9__78_1; // 0x10
	static System.Func<WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreviewBase> <>9__78_2; // 0x18
	static System.Void .cctor(); // 0x06161ce0
	System.Void .ctor(); // 0x06161d44
	WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreviewBase <.ctor>b__78_0(); // 0x06161dac
	WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreviewBase <.ctor>b__78_1(); // 0x06161e98
	WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreviewBase <.ctor>b__78_2(); // 0x06161f84
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreview.<>c__DisplayClass60_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreview <>4__this; // 0x10
	System.Int32 index; // 0x18
	WizardGames.Soc.Common.Data.resource.OBJGenaral resCfg; // 0x20
	WizardGames.Soc.SocClient.Ui.LotteryResInfo resInfo; // 0x28
	System.Void .ctor(); // 0x0615ec68
	System.Void <ResItemRenderer>b__0(WizardGames.Soc.SocClient.Ui.ComBaseIcon icon); // 0x06162070
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreview.<>c__DisplayClass62_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreview <>4__this; // 0x10
	WizardGames.Soc.Common.Data.resource.OBJGenaral resCfg; // 0x18
	WizardGames.Soc.Common.Data.resource.ENUMSkinType skinType; // 0x20
	System.Void .ctor(); // 0x0615f44c
	System.Void <RefreshResShow>b__0(UnityEngine.GameObject objModel, UnityEngine.GameObject objBg); // 0x061620fc
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.LotteryResInfo : System.ValueType
{
	System.Int32 <ResId>k__BackingField; // 0x10
	System.Boolean <IsOwned>k__BackingField; // 0x14
	System.Int32 get_ResId(); // 0x061621bc
	System.Void set_ResId(System.Int32 value); // 0x06162220
	System.Boolean get_IsOwned(); // 0x06162298
	System.Void set_IsOwned(System.Boolean value); // 0x061622fc
	static WizardGames.Soc.SocClient.Ui.LotteryResInfo CreateResInfo(System.Int32 resId, System.Boolean isOwned); // 0x06162378
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreviewBase : System.Object
{
	System.Int32 lotteryID; // 0x10
	WizardGames.Soc.SocClient.Ui.Utils.WindowCDTime windowCDTime; // 0x18
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreview uiLotteryDraw); // 0x06162490
	System.Void OnEnable(System.Int32 lotteryID); // 0x06162504
	System.Void OnDisable(); // 0x0616257c
	System.Void OnDestroy(); // 0x061625dc
	System.Void OnShowByLayerStack(); // 0x0616263c
	System.Void OnMallItemInfoUpdate(System.Int32 shopId); // 0x061626a0
	System.Void OnRefresh(); // 0x055049cc
	System.Void OnLotteryBtn(); // 0x055049cc
	System.Void OnLotteryTenBtn(); // 0x055049cc
	System.Void OnClickCommonPreview(System.Int32 index, System.Int32 resId); // 0x055057d4
	System.Void OnDetailBtn(); // 0x055049cc
	System.Void RefreshCurrency(); // 0x055049cc
	System.Void RefreshLotteryBtn(); // 0x055049cc
	System.Void OnFps1Update(); // 0x055049cc
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.LotteryResInfo> GetLotteryResInfos(); // 0x054e7844
	System.Void .ctor(); // 0x06162714
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UILotteryActiveDrawDetailPreview : WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreviewBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.UiLottertDrawDetailBinder binder; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.RootLottertDrawDetailBinder rootBinder; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.RootLottertDrawDetailContentBinder detailContentBinder; // 0x30
	WizardGames.Soc.SocClient.Ui.ComTopBar comTopBar; // 0x38
	FairyGUI.GTextField countDownTxt; // 0x40
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.BtnBuyBinder btnBuyBinder; // 0x48
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.BtnBuyBinder btnBuy2Binder; // 0x50
	WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreview owner; // 0x58
	WizardGames.Soc.Common.Data.common.OBJConditionSwitch conditionSwitch; // 0x60
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.SkinPreviewData> previewDatas; // 0x68
	System.Collections.Generic.List<System.Int32> rewardResourceIDs; // 0x70
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreview uiLotteryDraw); // 0x061627b4
	System.Void OnEnable(System.Int32 lotteryID); // 0x061628b8
	System.Void OnDisable(); // 0x06162984
	System.Void OnShowByLayerStack(); // 0x061629e8
	System.Void OnClickCommonPreview(System.Int32 selectedIndex, System.Int32 resId); // 0x06162a54
	System.Void OnDetailBtn(); // 0x0616310c
	System.Void OnFps1Update(); // 0x061632f8
	System.Void OnLotteryBtn(); // 0x061633e4
	System.Void OnLotteryTenBtn(); // 0x06163898
	System.Boolean CheckLotteryButton(System.Int32 times); // 0x061634a4
	System.Void OnRefresh(); // 0x06163958
	System.Void RefreshCurrency(); // 0x061642dc
	System.Void RefreshLotteryBtn(); // 0x061647b8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.LotteryResInfo> GetLotteryResInfos(); // 0x06164bd4
	System.Void .ctor(); // 0x0616200c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UILotteryActiveDrawDetailPreview.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UILotteryActiveDrawDetailPreview.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__22_2; // 0x8
	static System.Void .cctor(); // 0x061650cc
	System.Void .ctor(); // 0x06165130
	System.Void <RefreshCurrency>b__22_2(); // 0x06165198
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UILotteryActiveDrawDetailPreview.<>c__DisplayClass22_0 : System.Object
{
	System.Int32 costResourceID; // 0x10
	WizardGames.Soc.SocClient.Ui.UILotteryActiveDrawDetailPreview <>4__this; // 0x18
	WizardGames.Soc.Common.Data.resource.OBJGenaral costConfig; // 0x20
	System.Void .ctor(); // 0x06164750
	System.String <RefreshCurrency>b__0(); // 0x06165220
	System.Void <RefreshCurrency>b__1(); // 0x061652e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UILotteryFragmentDrawDetailPreview : WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreviewBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.UiLottertDrawDetailBinder binder; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.RootLottertDrawDetailBinder rootBinder; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.RootLottertDrawDetailContentBinder detailContentBinder; // 0x30
	WizardGames.Soc.SocClient.Ui.ComTopBar comTopBar; // 0x38
	FairyGUI.GTextField countDownTxt; // 0x40
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.BtnBuyBinder btnBuyBinder; // 0x48
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.BtnBuyBinder btnBuy2Binder; // 0x50
	WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreview owner; // 0x58
	WizardGames.Soc.Common.Data.common.OBJConditionSwitch conditionSwitch; // 0x60
	System.Boolean needAutoLottery; // 0x68
	System.Int32 curMallItemId; // 0x6c
	System.Int32 curLotteryCount; // 0x70
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreview uiLotteryDraw); // 0x06165464
	System.Void OnEnable(System.Int32 lotteryID); // 0x061656ac
	System.Void OnDisable(); // 0x06165778
	System.Void OnShowByLayerStack(); // 0x061657dc
	System.Void OnClickSkipAnimation(); // 0x06165848
	System.Void OnClickCommonPreview(System.Int32 selectedIndex, System.Int32 resId); // 0x0616598c
	System.Void OnDetailBtn(); // 0x06166080
	System.Void OnFps1Update(); // 0x061660f0
	System.Void OnLotteryBtn(); // 0x061661dc
	System.Void OnLotteryTenBtn(); // 0x061666f4
	System.Void OnRefresh(); // 0x06166bd4
	System.Void RefreshCurrency(); // 0x0616755c
	System.Void RefreshLotteryBtn(); // 0x06167dc8
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.LotteryResInfo> GetLotteryResInfos(); // 0x06168240
	System.Void ClearCostNoEoughData(); // 0x0616668c
	System.Void OnMallItemInfoUpdate(System.Int32 shopId); // 0x061686f8
	System.Void DoDrawLottery(System.Int32 lotteryCount); // 0x061688e8
	System.Void .ctor(); // 0x06161f20
	static System.Void .cctor(); // 0x06168c50
	System.Void <OnInit>b__14_0(FairyGUI.EventContext ctx); // 0x06168d24
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UILotteryFragmentDrawDetailPreview.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UILotteryFragmentDrawDetailPreview.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__25_2; // 0x8
	static FairyGUI.EventCallback1 <>9__25_4; // 0x10
	static FairyGUI.EventCallback0 <>9__25_6; // 0x18
	static System.Void .cctor(); // 0x06168d9c
	System.Void .ctor(); // 0x06168e00
	System.Void <RefreshCurrency>b__25_2(); // 0x06168e68
	System.Void <RefreshCurrency>b__25_4(FairyGUI.EventContext context); // 0x06168ef0
	System.Void <RefreshCurrency>b__25_6(); // 0x06168fc0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UILotteryFragmentDrawDetailPreview.<>c__DisplayClass25_0 : System.Object
{
	System.Int32 costResourceID; // 0x10
	WizardGames.Soc.SocClient.Ui.UILotteryFragmentDrawDetailPreview <>4__this; // 0x18
	WizardGames.Soc.Common.Data.resource.OBJGenaral costConfig; // 0x20
	System.Int32 currencyNum; // 0x28
	WizardGames.Soc.Common.Data.resource.OBJGenaral currencyConfig; // 0x30
	System.Void .ctor(); // 0x06167d60
	System.String <RefreshCurrency>b__0(); // 0x06169048
	System.Void <RefreshCurrency>b__1(); // 0x06169108
	System.String <RefreshCurrency>b__3(); // 0x06169284
	System.Void <RefreshCurrency>b__5(); // 0x061692ec
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UILotteryGachaDrawDetailPreview : WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreviewBase
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.UiLottertDrawDetailBinder binder; // 0x20
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.RootLottertDrawDetailBinder rootBinder; // 0x28
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.RootLottertDrawDetailContentBinder detailContentBinder; // 0x30
	WizardGames.Soc.SocClient.Ui.ComTopBar comTopBar; // 0x38
	FairyGUI.GTextField countDownTxt; // 0x40
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.BtnBuyBinder btnBuyBinder; // 0x48
	WizardGames.Soc.Common.Data.common.OBJConditionSwitch conditionSwitch; // 0x50
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Manager.SkinPreviewData> previewDatas; // 0x58
	WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreview owner; // 0x60
	System.Boolean needAutoLottery; // 0x68
	System.Int32 curMallItemId; // 0x6c
	System.Int32 curLotteryCount; // 0x70
	System.Void OnInit(WizardGames.Soc.SocClient.Ui.UiLottertDrawDetailPreview uiLotteryDraw); // 0x06169468
	System.Void OnEnable(System.Int32 lotteryID); // 0x0616955c
	System.Void OnDisable(); // 0x06169628
	System.Void OnClickCommonPreview(System.Int32 selectedIndex, System.Int32 resId); // 0x061696fc
	System.Void OnDetailBtn(); // 0x06169f30
	System.Void OnShowByLayerStack(); // 0x06169fa0
	System.Void OnFps1Update(); // 0x0616a00c
	System.Void OnLotteryBtn(); // 0x0616a0f8
	System.Void OnLotteryTenBtn(); // 0x0616a5e4
	System.Void RefreshCurrency(); // 0x0616a644
	System.Void RefreshLotteryBtn(); // 0x0616af1c
	System.Void OnRefresh(); // 0x0616b410
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.LotteryResInfo> GetLotteryResInfos(); // 0x0616bf14
	System.Void ClearCostNoEoughData(); // 0x06169694
	System.Void OnMallItemInfoUpdate(System.Int32 shopId); // 0x0616c39c
	System.Void DoDrawLottery(); // 0x0616c588
	System.Void .ctor(); // 0x06161e34
	static System.Void .cctor(); // 0x0616c8f8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UILotteryGachaDrawDetailPreview.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UILotteryGachaDrawDetailPreview.<>c <>9; // 0x0
	static FairyGUI.EventCallback0 <>9__23_2; // 0x8
	static FairyGUI.EventCallback1 <>9__23_4; // 0x10
	static FairyGUI.EventCallback0 <>9__23_6; // 0x18
	static System.Void .cctor(); // 0x0616c9cc
	System.Void .ctor(); // 0x0616ca30
	System.Void <RefreshCurrency>b__23_2(); // 0x0616ca98
	System.Void <RefreshCurrency>b__23_4(FairyGUI.EventContext context); // 0x0616cb20
	System.Void <RefreshCurrency>b__23_6(); // 0x0616cbf0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UILotteryGachaDrawDetailPreview.<>c__DisplayClass23_0 : System.Object
{
	System.Int32 costResourceID; // 0x10
	WizardGames.Soc.SocClient.Ui.UILotteryGachaDrawDetailPreview <>4__this; // 0x18
	WizardGames.Soc.Common.Data.resource.OBJGenaral costConfig; // 0x20
	System.Int32 currencyNum; // 0x28
	WizardGames.Soc.Common.Data.resource.OBJGenaral currencyConfig; // 0x30
	System.Void .ctor(); // 0x0616aeb4
	System.String <RefreshCurrency>b__0(); // 0x0616cc78
	System.Void <RefreshCurrency>b__1(); // 0x0616cd38
	System.String <RefreshCurrency>b__3(); // 0x0616ceb4
	System.Void <RefreshCurrency>b__5(); // 0x0616cf1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLotteryDrawDetail : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.UiComViewLotteryDrawBinder lotteryDrawBinder; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.ComViewLotteryDrawRootBinder binder; // 0x340
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x348
	WizardGames.Soc.SocClient.Ui.ComCommonNavBar commonNavBar; // 0x350
	System.String[] navBarNames; // 0x358
	WizardGames.Soc.SocClient.Ui.ELotteryDrawDetailType drawDetailType; // 0x360
	System.Int32 lotteryId; // 0x364
	WizardGames.Soc.SocClient.Manager.EMallLotteryType lotteryType; // 0x368
	WizardGames.Soc.Common.Data.mall.OBJWithoutReplacementLotteryInfo lotteryInfo; // 0x370
	WizardGames.Soc.Common.Data.mall.OBJLotteryBaseInfo lotteryBaseInfo; // 0x378
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.ComProbabilityItemBinder> comItemBinderMap; // 0x380
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.ComProbabilityItem_Type2Binder> comItemType2BinderMap; // 0x388
	System.Void OnInit(); // 0x0616d098
	System.Void OnItemRender(System.Int32 index, FairyGUI.GObject gObject); // 0x0616d734
	System.Void OnItemRenderType2(System.Int32 index, FairyGUI.GObject gObject); // 0x0616dc90
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0616e1c8
	static System.Void ShowLotteryDrawDetail(System.Int32 lotteryID, WizardGames.Soc.SocClient.Manager.EMallLotteryType type, WizardGames.Soc.SocClient.Manager.EUiOpenTriggerType triggerType, WizardGames.Soc.SocClient.Manager.EUiJumpSource jumpSource); // 0x0616317c
	System.Void RefreshUI(); // 0x0616e2b0
	System.Void SetData(System.Int32 lotteryID, WizardGames.Soc.SocClient.Manager.EMallLotteryType type); // 0x0616e974
	System.Void .ctor(); // 0x0616ea28
	System.Void <OnInit>b__12_0(); // 0x0616ec0c
	System.Void <OnInit>b__12_1(); // 0x0616ec80
	System.Void <OnInit>b__12_2(WizardGames.Soc.SocClient.Ui.NavBarData data, System.Boolean btnClicked); // 0x0616ecf4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLotteryDrawDetail.<>c__DisplayClass17_0 : System.Object
{
	System.Int32 lotteryID; // 0x10
	WizardGames.Soc.SocClient.Manager.EMallLotteryType type; // 0x14
	System.Void .ctor(); // 0x0616e248
	System.Void <ShowLotteryDrawDetail>b__0(WizardGames.Soc.SocClient.Ui.UiLotteryDrawDetail win); // 0x0616ede8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLotteryGroup : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.UiComViewLotteryGroupBinder lotteryBinder; // 0x338
	WizardGames.Soc.SocClient.Ui.Binder.LobbyLotteryDraw.ComViewLotteryGroupRootBinder rootBinder; // 0x340
	WizardGames.Soc.SocClient.Ui.ComModal comModal; // 0x348
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.Common.Data.mall.OBJLotteryPoolRewards>> overviewType2rewards; // 0x350
	System.Collections.Generic.Dictionary<FairyGUI.GObject,WizardGames.Soc.SocClient.Ui.ComLotteryPreview> comItemMap; // 0x358
	System.Collections.Generic.List<System.String> titles; // 0x360
	System.Void OnInit(); // 0x0616ee6c
	System.Void OnItemRender(System.Int32 index, FairyGUI.GObject gObject); // 0x0616f20c
	System.Void OnEnable(); // 0x0616f3e8
	System.Void OnDisable(); // 0x0616f450
	System.Void .ctor(); // 0x0616f568
	System.Void <OnInit>b__7_0(); // 0x0616f6f4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLotteryHelper : System.Object
{
	
	static System.Boolean TryAutoPlayInnerVideo(WizardGames.Soc.SocClient.Ui.ComLotteryBg comBg, System.String kv, System.String innerVideoUrl); // 0x0615b778
	static System.Boolean TryPlayFullScreenVideo(System.String fullScreenVideoUrl, System.Boolean checkTips, System.Action onVideoFinished, System.Action onVideoPrepareCompleted); // 0x0616f768
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComBattlePass : System.Object
{
	static SocLogger logger; // 0x0
	FairyGUI.GComponent comRoot; // 0x10
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.BtnBattlePassBinder binder; // 0x18
	WizardGames.Soc.SocClient.Ui.ComRedDot redDot; // 0x20
	System.Void .ctor(FairyGUI.GComponent comRoot); // 0x0616f87c
	System.Void OpenBattlePass(FairyGUI.EventContext ctx); // 0x0616fce4
	System.Void OnEnable(); // 0x0616fdbc
	System.Void OnDisable(); // 0x0617006c
	System.Void OnDestroy(); // 0x061700cc
	System.Void OnUpdateBattlePassInfo(); // 0x061701c4
	System.Void RefreshBpInfo(); // 0x0616fe20
	static System.Void .cctor(); // 0x06170228
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComMallRollPoster : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.Binder.LobbyMain.ComRollPosterBinder rootBinder; // 0x10
	System.Collections.Generic.List<FairyGUI.Controller> pageSignCtrls; // 0x18
	System.Int64 autoRollTimerId; // 0x20
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ComMallRollPoster.IBannerDataHandler> allPosters; // 0x28
	System.Int32 autoScrollCDMs; // 0x30
	System.Int32 lastShowIndex; // 0x34
	FairyGUI.GComponent comRoot; // 0x38
	WizardGames.Soc.SocClient.Ui.Utils.WindowCDTime windowCDTime; // 0x40
	System.Boolean autoScrollEnable; // 0x48
	WizardGames.Soc.SocClient.Ui.ComKeyTips comKeyTip; // 0x50
	System.Int32 get_curScrollIndex(); // 0x0548ba98
	System.Void .ctor(FairyGUI.GComponent comRoot); // 0x0617042c
	System.Void RestartTimer(); // 0x055049cc
	System.Void StopTimer(); // 0x06170d80
	System.Void RefreshBanners(); // 0x06170e88
	System.Void OnEnable(); // 0x061719e8
	System.Void OnDestroy(); // 0x06171b24
	System.Void OnDisable(); // 0x06171ba4
	System.Void ResetImgList(); // 0x061715fc
	System.Void ImgItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x061721f0
	System.Void PageListItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x06172394
	System.Void RefreshPageSign(); // 0x061724d0
	System.Void OnListScroll(FairyGUI.EventContext ctx); // 0x061725b4
	System.Void OnListScrollEnd(); // 0x061726d0
	System.Void OnRefreshText(); // 0x06171de0
	System.Void ResetPageList(); // 0x061717b0
	System.Void OnAutoScrollTimer(System.Int64 timerId, System.Object data, System.Boolean delete); // 0x06172880
	System.Void OnClickRoot(); // 0x061729e0
	static System.Void .cctor(); // 0x06172ca8
}

// Client.Runtime
interface WizardGames.Soc.SocClient.Ui.ComMallRollPoster.IBannerDataHandler : 
{
	
	System.Int32 get_Id(); // 0x0548ba98
	System.String get_Thumbnail(); // 0x054e7844
	System.String get_Name(); // 0x054e7844
	System.Int32 get_JumpId(); // 0x0548ba98
	System.Action get_JumpAct(); // 0x054e7844
	System.Int32 get_Order(); // 0x0548ba98
	System.Boolean get_TimeLimitSign(); // 0x054c4760
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.ComMallRollPoster.CustomBannerDataHandler : System.ValueType, WizardGames.Soc.SocClient.Ui.ComMallRollPoster.IBannerDataHandler
{
	WizardGames.Soc.SocClient.Manager.CustomBannerData data; // 0x10
	System.Int32 get_Id(); // 0x06172d7c
	System.String get_Thumbnail(); // 0x06172dec
	System.String get_Name(); // 0x06172e5c
	System.Int32 get_JumpId(); // 0x06172ecc
	System.Action get_JumpAct(); // 0x06172f3c
	System.Int32 get_Order(); // 0x06172fac
	System.Boolean get_TimeLimitSign(); // 0x0617301c
	System.Void .ctor(WizardGames.Soc.SocClient.Manager.CustomBannerData data); // 0x06173080
}

// Client.Runtime
struct WizardGames.Soc.SocClient.Ui.ComMallRollPoster.TableBannerDataHandler : System.ValueType, WizardGames.Soc.SocClient.Ui.ComMallRollPoster.IBannerDataHandler
{
	WizardGames.Soc.Common.Data.Ui.RollPoster data; // 0x10
	System.Int32 get_Id(); // 0x06173100
	System.String get_Thumbnail(); // 0x06173170
	System.String get_Name(); // 0x061731e0
	System.Int32 get_JumpId(); // 0x06173250
	System.Action get_JumpAct(); // 0x061732c0
	System.Int32 get_Order(); // 0x06173324
	System.Boolean get_TimeLimitSign(); // 0x06173394
	System.Void .ctor(WizardGames.Soc.Common.Data.Ui.RollPoster data); // 0x06173404
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComMallRollPoster.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.ComMallRollPoster.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.SocClient.Ui.ComMallRollPoster.IBannerDataHandler> <>9__22_0; // 0x8
	static System.Void .cctor(); // 0x06173484
	System.Void .ctor(); // 0x061734e8
	System.Int32 <RefreshBanners>b__22_0(WizardGames.Soc.SocClient.Ui.ComMallRollPoster.IBannerDataHandler a, WizardGames.Soc.SocClient.Ui.ComMallRollPoster.IBannerDataHandler b); // 0x06173550
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComPreMode : System.Object
{
	static SocLogger logger; // 0x0
	FairyGUI.GComponent comPreMode; // 0x10
	FairyGUI.GTextField preModeTitle; // 0x18
	FairyGUI.GTextField timeTxt; // 0x20
	FairyGUI.GLoader clickBg; // 0x28
	FairyGUI.Transition highLight; // 0x30
	System.Void Init(FairyGUI.GComponent comPreMode); // 0x06173808
	System.Void OnClickComPreMode(); // 0x06173a08
	System.Void RefreshPreModeTitle(); // 0x06173b70
	System.Void OnPlayTransition(); // 0x06173e98
	System.Void OnAppointServerOpenNotice(); // 0x06173f10
	System.Void OnLobbyTeamMemberLeaveNotice(System.String roleId, System.Boolean isAppointment); // 0x06173f74
	System.Void OnEnable(); // 0x06173ff4
	System.Void OnFps1Update(System.Single dt); // 0x06174320
	System.Void OnHandleLobbyOnReconnected(SimpleJSON.JSONNode node, System.Boolean _isApointment); // 0x06174394
	System.Void OnDisable(); // 0x06174414
	System.Void OnDestroy(); // 0x06174738
	System.Void .ctor(); // 0x06174798
	static System.Void .cctor(); // 0x06174800
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.LobbyBattleServerData : System.Object
{
	static SocLogger logger; // 0x0
	System.String battleServerId; // 0x10
	System.String lastJoinTime; // 0x18
	System.String lastLeaveTime; // 0x20
	System.Int32 modeId; // 0x28
	System.UInt64 serverOpenedTime; // 0x30
	System.String teamId; // 0x38
	System.Int32 totalPlayedSeconds; // 0x40
	System.UInt64 battleEndTime; // 0x48
	System.Int32 platform; // 0x50
	System.String region; // 0x58
	System.Int32 teamSize; // 0x60
	System.Boolean Settlement; // 0x64
	System.Collections.Generic.List<WizardGames.Soc.Common.SimpleCustom.GameEndResultDetailData> GameEndResultDetailDatas; // 0x68
	System.Boolean IsBattleSummaryDataNull; // 0x70
	System.String get_BattleServerId(); // 0x061748d4
	System.String get_LastJoinTime(); // 0x06174938
	System.String get_LastLeaveTime(); // 0x0617499c
	System.Int32 get_ModeId(); // 0x06174a00
	System.String get_TeamId(); // 0x06174a64
	System.Int32 get_TotalPlayedSeconds(); // 0x06174ac8
	System.UInt64 get_BattleEndTime(); // 0x06174b2c
	System.Int32 get_Platform(); // 0x06174b90
	System.Int32 get_TeamSize(); // 0x06174bf4
	System.Void .ctor(SimpleJSON.JSONNode node); // 0x06174c58
	static System.Void .cctor(); // 0x061750d8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ScreenShotListenManager : UnityEngine.MonoBehaviour
{
	System.Action Shoot; // 0x30
	static WizardGames.Soc.SocClient.Ui.ScreenShotListenManager _instance; // 0x0
	UnityEngine.AndroidJavaObject javaScreenShotManager; // 0x38
	System.Boolean isListening; // 0x40
	System.Boolean isInitialized; // 0x41
	static WizardGames.Soc.SocClient.Ui.ScreenShotListenManager get_Instance(); // 0x061751ac
	System.Void Awake(); // 0x06175308
	System.Collections.IEnumerator InitManagerNextFrame(); // 0x061754a0
	System.Void InitializeAndroidManager(); // 0x061755c8
	System.Void StartListen(); // 0x0617592c
	System.Void StopListen(); // 0x06175fd0
	System.Void EnsureAndroidImagePermission(); // 0x06175cb0
	System.Void .ctor(); // 0x061762e0
	System.Void <StartListen>b__10_0(); // 0x06176348
	System.Void <StopListen>b__11_0(); // 0x0617648c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ScreenShotListenManager.ScreenShotListener : UnityEngine.AndroidJavaProxy
{
	WizardGames.Soc.SocClient.Ui.ScreenShotListenManager parent; // 0x20
	System.Void .ctor(WizardGames.Soc.SocClient.Ui.ScreenShotListenManager parent); // 0x061765cc
	System.Void onShot(System.String imagePath); // 0x06176694
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ScreenShotListenManager.<>c__DisplayClass9_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.ScreenShotListenManager <>4__this; // 0x10
	UnityEngine.AndroidJavaObject currentActivity; // 0x18
	System.Void .ctor(); // 0x061758c4
	System.Void <InitializeAndroidManager>b__0(); // 0x061767bc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ScreenShotListenManager.<InitManagerNextFrame>d__8 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Ui.ScreenShotListenManager <>4__this; // 0x20
	System.Void .ctor(System.Int32 <>1__state); // 0x06175544
	System.Void System.IDisposable.Dispose(); // 0x06176a38
	System.Boolean MoveNext(); // 0x06176a98
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x06176b48
	System.Void System.Collections.IEnumerator.Reset(); // 0x06176bac
	System.Object System.Collections.IEnumerator.get_Current(); // 0x06176c34
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiAvatarSelectPopup : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	SocLogger logger; // 0x338
	FairyGUI.GGraph backBg; // 0x340
	FairyGUI.GTextField name; // 0x348
	FairyGUI.GTextField textID; // 0x350
	FairyGUI.GComponent comAvatarMain; // 0x358
	WizardGames.Soc.SocClient.Ui.ComAvatarSquare comHead; // 0x360
	FairyGUI.GButton changeBtn; // 0x368
	FairyGUI.GList avatarList; // 0x370
	System.Collections.Generic.IReadOnlyList<WizardGames.Soc.Common.Data.resource.OBJPortrait> avatarDataList; // 0x378
	System.Int32 CurChooseAvatarId; // 0x380
	System.Void OnInit(); // 0x06176c98
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x061773bc
	System.Void RefreshAvatarList(); // 0x0617722c
	System.Void AvatarItemRenderer(System.Int32 index, FairyGUI.GObject item); // 0x0617743c
	System.Void OnEnable(); // 0x0617780c
	System.Void RefreshAccountInfo(); // 0x06177870
	System.Void OnClickChangeHeadIcon(); // 0x06177a40
	System.Void .ctor(); // 0x06177b7c
	System.Void <OnInit>b__10_0(FairyGUI.EventContext ctx); // 0x06177ca4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiAvatarSelectPopup.<>c__DisplayClass13_0 : System.Object
{
	WizardGames.Soc.Common.Data.resource.OBJPortrait avatarData; // 0x10
	WizardGames.Soc.SocClient.Ui.UiAvatarSelectPopup <>4__this; // 0x18
	System.Void .ctor(); // 0x061777a4
	System.Void <AvatarItemRenderer>b__0(FairyGUI.EventContext ctx); // 0x06177d1c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyAppointmentBtn : System.Object
{
	FairyGUI.GButton btnAppointment; // 0x10
	WizardGames.Soc.SocClient.Ui.ComRedDot appointmentRedDot; // 0x18
	FairyGUI.Transition loopAnim; // 0x20
	System.Boolean isClicked; // 0x28
	System.Int32 curTime; // 0x2c
	FairyGUI.Controller statusCtrl; // 0x30
	System.Void Init(FairyGUI.GButton btn); // 0x06177db8
	System.Void PlayLoopAnim(); // 0x0617815c
	System.Void StopLoopAnim(); // 0x061781dc
	System.Void OnRefresh(); // 0x0617806c
	System.Void OnLobbyTeamMemberLeaveNotice(System.String roleId, System.Boolean isAppointment); // 0x061782ac
	System.Void OnHandleLobbyOnReconnected(SimpleJSON.JSONNode node, System.Boolean _isApointment); // 0x0617832c
	System.Void OnFps1Update(System.Single dt); // 0x061783ac
	System.Void OnDestroy(); // 0x0617854c
	System.Void OnEnable(); // 0x061785b0
	System.Void OnDisable(); // 0x0617886c
	System.Void .ctor(); // 0x06178af0
	System.Void <Init>b__6_0(FairyGUI.EventContext ctx); // 0x06178b8c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyAppointmentBtn.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiLobbyAppointmentBtn.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.UiCommonTeamLobby> <>9__6_1; // 0x8
	static System.Void .cctor(); // 0x06178d30
	System.Void .ctor(); // 0x06178d94
	System.Void <Init>b__6_1(WizardGames.Soc.SocClient.Ui.UiCommonTeamLobby win); // 0x06178dfc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyMain : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps1Update
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.ComAvatarSquare comHead; // 0x338
	FairyGUI.GTextField textName; // 0x340
	FairyGUI.GTextField textLevel; // 0x348
	UiLobbyQuickJoin quickJoin; // 0x350
	FairyGUI.GGraph graphManRotate; // 0x358
	FairyGUI.GComponent comPlayBtns; // 0x360
	UiLobbyPlayBtns playBtns; // 0x368
	FairyGUI.GComponent comBanner; // 0x370
	WizardGames.Soc.SocClient.Ui.ComMallRollPoster mallRollPoster; // 0x378
	FairyGUI.GButton btnSvrList; // 0x380
	WizardGames.Soc.SocClient.Ui.UiHudElemChat chat; // 0x388
	FairyGUI.GButton btnPandora; // 0x390
	FairyGUI.GButton btnFirstRecharge; // 0x398
	WizardGames.Soc.SocClient.Ui.UiLobbyAppointmentBtn lobbyAppointmentBtn; // 0x3a0
	WizardGames.Soc.SocClient.Ui.UiLobbyTeamBtn lobbyTeamBtn; // 0x3a8
	WizardGames.Soc.SocClient.Ui.ComPreMode comPreMode; // 0x3b0
	FairyGUI.Controller newFriendCtr; // 0x3b8
	System.Single manRotateStartPosX; // 0x3c0
	UnityEngine.Vector3 manStartEulerAng; // 0x3c4
	FairyGUI.GComponent comScreenShot; // 0x3d0
	FairyGUI.GButton btnClose; // 0x3d8
	FairyGUI.GButton btnWechat; // 0x3e0
	FairyGUI.GButton btnWechatFriend; // 0x3e8
	FairyGUI.GButton btnQQ; // 0x3f0
	FairyGUI.GButton btnQQFriend; // 0x3f8
	FairyGUI.GGroup btngroupWechat; // 0x400
	FairyGUI.GGroup btngroupQQ; // 0x408
	UnityEngine.Transform transLobbyPlayer; // 0x410
	WizardGames.Soc.SocClient.GoLoader.DisplayModel displayModel; // 0x418
	WizardGames.Soc.Common.CustomType.PlayerDisplayData displayData; // 0x420
	UnityEngine.Transform playerLoader; // 0x428
	UiTXAdditionalBtns uiTXAdditionalBtns; // 0x430
	FairyGUI.GTextField tribeTipText; // 0x438
	FairyGUI.GTextField unionTipText; // 0x440
	System.Boolean isReqUserInfoSuccess; // 0x448
	FairyGUI.Controller platformCtrl; // 0x450
	System.Boolean isDisplayModelLoaded; // 0x458
	FairyGUI.GButton btnRoleAppPrivilege; // 0x460
	System.Boolean canGuide; // 0x468
	WizardGames.Soc.SocClient.Ui.Binder.CommonLobby.ComSeasonBinder comSeason; // 0x470
	FairyGUI.GComponent obMenuPanel; // 0x478
	FairyGUI.GList obList; // 0x480
	System.Collections.Generic.List<WizardGames.Soc.SocClient.ServerList.ServerInfo> obBattleList; // 0x488
	WizardGames.Soc.SocClient.Ui.ComBattlePass comBattlePass; // 0x490
	System.Collections.Generic.Dictionary<System.String,FairyGUI.GButton> pandoraBtns; // 0x498
	FairyGUI.GButton news; // 0x4a0
	FairyGUI.Transition transMessageShow; // 0x4a8
	FairyGUI.Transition transMessageHide; // 0x4b0
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType> lobbyMessageTabOrder; // 0x4b8
	System.Int32 lobbyMessageRotateIndex; // 0x4c0
	System.Int32 lobbyMessageRotateSecCounter; // 0x4c4
	System.Int32 lobbyLastInviteCount; // 0x4c8
	System.Int32 lobbyLastLobbyApplyCount; // 0x4cc
	System.Int32 lobbyLastAppointmentApplyCount; // 0x4d0
	System.Boolean lobbyMsgTransPlaying; // 0x4d4
	System.Nullable<WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType> curLobbyMsgTabShown; // 0x4d8
	System.String curLobbyMsgText; // 0x4e0
	System.Boolean pendingLobbySwitch; // 0x4e8
	WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType pendingLobbyTab; // 0x4ec
	System.String pendingLobbyText; // 0x4f0
	System.Single intervalTime; // 0x4f8
	System.String imageTempPath; // 0x500
	FairyGUI.GGroup tribeTipGrp; // 0x508
	FairyGUI.GGroup unionTipGrp; // 0x510
	System.Void MakeFullScreen(); // 0x06178e84
	System.Void OnInit(); // 0x06178eec
	System.Void ReqGetUserInfo(WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule, System.Action callback); // 0x0617c240
	System.Void CheckTencentPrivilege(); // 0x0617a194
	System.Void InitQQWelfare(); // 0x0617d884
	System.Void OnClickQqChannel(); // 0x0617dbe0
	System.Void InitWechatWelfare(); // 0x0617da88
	System.Void InitSeasonbutton(); // 0x0617bcbc
	System.Void RefreshSeasonSystemInfo(); // 0x0617dd24
	System.Void InitRightAreaButtons(); // 0x055049cc
	System.Void InitBattlePassButton(); // 0x0617bde0
	System.Void InitFristRechargeButton(); // 0x055049cc
	System.Void RefreshFristRechargeButton(); // 0x0617dfc0
	System.Void OnClickFirstRecharge(); // 0x0617e0d8
	System.Void OnClickBtnVxTq(); // 0x0617e174
	System.Void RefreshBtnSvrListVisible(); // 0x0617a294
	System.Void InitRoleAppPrivilegeElement(); // 0x0617cfb4
	System.Void UpdateRoleAppPrivilegeState(Config.MgrConfig.ERoleAppPrivilegeType roleAppPrivilegeType); // 0x0617e2b8
	System.Void OnClickRoleAppPrivilege(); // 0x0617e398
	System.Void RegistEvent(); // 0x0617c544
	System.Void TryRefreshPlayerModel2(); // 0x0617e544
	System.Void RemoveEvent(); // 0x0617e6ac
	System.Void OnHandleLobbyOnReconnected(SimpleJSON.JSONNode node, System.Boolean _isApointment); // 0x0617efa4
	System.Void OnEnable(); // 0x0617f084
	System.Void OnRedDotPulled(); // 0x0617ff68
	System.Void OnLobbyModelSceneQualityChanged(); // 0x0617ffcc
	System.Void OnShowAnimFinish(); // 0x06180030
	System.Void OnDisable(); // 0x061801a8
	System.Void OnDestroy(); // 0x0618036c
	System.Void InitPlayerModel(); // 0x06180654
	System.Void RealseDisplayModel(); // 0x06180550
	System.Void OnRefreshRedDot(); // 0x0617f8e4
	System.Void OnFps1Update(System.Single dt); // 0x06180d1c
	System.Void RefreshLobbyMessageTicker(); // 0x06180ebc
	System.String BuildLobbyMessageText(WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType tab, System.Int32 inviteCount, System.Int32 lobbyApplyCount, System.Int32 appointmentApplyCount); // 0x061816d8
	System.Void SetLobbyMessageText(System.String text); // 0x061818e8
	System.Void SwitchLobbyMessageTo(WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType tab, System.String text); // 0x061819a4
	System.Void UpdateLobbyMessageOrder(WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType tab, System.Int32 curCount, System.Int32& lastCount); // 0x061814f8
	System.Void InitLobbyMessageButtonClick(); // 0x06181b4c
	System.Void RefreshAccountInfo(); // 0x06181c28
	System.Void OnHandleLobbyOnReconnected(); // 0x06181f44
	System.Void OnLobbyTeamTeamNotice(); // 0x06182068
	System.Void OnLevelOrExpChanged(); // 0x061820d8
	System.Void UpdateRoleLevel(); // 0x061821fc
	System.Void RefreshFriendRequest(); // 0x0617d760
	System.Void OnClickMail(); // 0x06182428
	System.Void OnClickTribe(); // 0x06182500
	System.Void OnClickUnion(); // 0x06182564
	System.Void TryRefreshPlayerModel(); // 0x0617e5a8
	System.Void Refresh(WizardGames.Soc.Common.CustomType.PlayerDisplayData data); // 0x06182620
	System.Void AfterWeaponLoaded(WizardGames.Soc.SocClient.GoLoader.DisplayWeapon weapon); // 0x06183240
	System.Void RefreshRoleCustomizeData(); // 0x06181e34
	System.Void OnClickCollection(); // 0x06183408
	System.Void RefreshPlayedServerList(); // 0x0617f674
	System.Void OpenWinFriend(); // 0x061834cc
	System.Void OnClickStash(); // 0x06183590
	System.Void OnClickMessage(); // 0x06183654
	System.Void OnClickMall(); // 0x061836bc
	System.Void OnClickCustomBlueprint(); // 0x06183780
	System.Void OnClickSkill(); // 0x061837e4
	System.Void OnClickActive(); // 0x061838c8
	System.Void OnClickMainQuest(); // 0x0618398c
	System.Void OnManRotateTouchBegin(FairyGUI.EventContext ctx); // 0x061839f4
	System.Void OnManRotateTouchMove(FairyGUI.EventContext ctx); // 0x06183b70
	System.Void InitLobbyMainPandoraBtns(); // 0x0617c0c8
	System.Void InitPandoraEntry(); // 0x0617de48
	System.Void CheckPandoraEntry(); // 0x0617f76c
	System.Void OnClickPandora(FairyGUI.EventContext ctx); // 0x06183e04
	System.Void RefreshPandoraEntry(System.String appId); // 0x06183eb4
	System.Void RefreshPandoraEntryRedDot(System.String appId); // 0x06183fe4
	System.Boolean TriggerGuide(); // 0x0617fad4
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06184138
	System.Void InitPlatformInfo(); // 0x0617d1e8
	System.Void InitTxAddition(); // 0x0617ce3c
	System.Void OnEscCloseOperation(); // 0x061841b0
	System.Void SetupShareButtons(); // 0x061844bc
	static System.Void UploadShareLog(System.String target, System.Int32 isSuccess); // 0x061847b8
	System.Void UpdateTribeState(); // 0x06182340
	System.Void UpdateUnionState(); // 0x06184a0c
	System.Void TakeScreenshotWithSuccess(System.String imagePath); // 0x06184be0
	System.Void InitAnchorMode(); // 0x0617c068
	System.Void InitSysBtnBar(); // 0x0617afb0
	System.Void EnableHotkey(); // 0x0617f884
	System.Void DisableHotkey(); // 0x0618030c
	System.Void InitTopBar(); // 0x0617a378
	System.Void RefreshLobbyModelScene(); // 0x0617f35c
	System.Void RefreshExitTeamBtnStatus(); // 0x0617f024
	System.Void .ctor(); // 0x06184d5c
	static System.Void .cctor(); // 0x06184e9c
	System.Void <OnInit>b__70_2(); // 0x06184f70
	System.Void <InitRightAreaButtons>b__78_0(FairyGUI.EventContext ctx); // 0x0618503c
	System.Void <InitFristRechargeButton>b__80_0(FairyGUI.EventContext ctx); // 0x061850b4
	System.Void <InitRoleAppPrivilegeElement>b__86_0(FairyGUI.EventContext ctx); // 0x0618512c
	System.Void <OnClickRoleAppPrivilege>b__88_0(WizardGames.Soc.Common.Unity.Ui.WindowComBase win); // 0x061851a4
	System.Void <InitLobbyMessageButtonClick>b__108_0(); // 0x06185278
	System.Void <OnHandleLobbyOnReconnected>b__110_0(); // 0x061853e8
	System.Void <Refresh>b__120_0(System.Object param); // 0x0618545c
	System.Void <InitPlatformInfo>b__149_0(); // 0x061854e4
	System.Void <SetupShareButtons>b__152_0(); // 0x06185558
	System.Void <SetupShareButtons>b__152_1(); // 0x061856e0
	System.Void <SetupShareButtons>b__152_2(); // 0x06185850
	System.Void <SetupShareButtons>b__152_3(); // 0x061859d8
	System.Void <TakeScreenshotWithSuccess>b__156_0(System.Object param); // 0x06185a78
	System.Void <TakeScreenshotWithSuccess>b__156_1(); // 0x06185b80
	System.Void <InitSysBtnBar>b__158_0(FairyGUI.EventContext ctx); // 0x06185bf4
	System.Void <InitSysBtnBar>b__158_1(FairyGUI.EventContext ctx); // 0x06185c6c
	System.Void <InitSysBtnBar>b__158_2(FairyGUI.EventContext ctx); // 0x06185ce4
	System.Void <InitSysBtnBar>b__158_3(FairyGUI.EventContext ctx); // 0x06185d5c
	System.Void <InitSysBtnBar>b__158_4(FairyGUI.EventContext ctx); // 0x06185dd4
	System.Void <InitSysBtnBar>b__158_5(FairyGUI.EventContext ctx); // 0x06185e4c
	System.Void <InitTopBar>b__161_0(FairyGUI.EventContext ctx); // 0x06185ec4
	System.Void <InitTopBar>b__161_1(FairyGUI.EventContext ctx); // 0x06185f3c
	System.Void <InitTopBar>b__161_3(FairyGUI.EventContext ctx); // 0x06185fb4
	System.Void <InitTopBar>b__161_5(FairyGUI.EventContext ctx); // 0x0618602c
	System.Void <InitTopBar>b__161_6(FairyGUI.EventContext ctx); // 0x061860a4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyMain.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiLobbyMain.<>c <>9; // 0x0
	static FairyGUI.EventCallback1 <>9__70_0; // 0x8
	static FairyGUI.EventCallback1 <>9__70_1; // 0x10
	static System.Action <>9__71_1; // 0x18
	static System.Action<WizardGames.Soc.SocClient.Ui.UiNewbieSelectMode> <>9__143_0; // 0x20
	static System.Action <>9__151_0; // 0x28
	static System.Action <>9__151_1; // 0x30
	static System.Action<System.Int32> <>9__152_4; // 0x38
	static System.Action<System.Int32> <>9__152_5; // 0x40
	static System.Action<System.Int32> <>9__152_6; // 0x48
	static FairyGUI.EventCallback1 <>9__161_2; // 0x50
	static FairyGUI.EventCallback1 <>9__161_4; // 0x58
	static System.Void .cctor(); // 0x0618675c
	System.Void .ctor(); // 0x061867c0
	System.Void <OnInit>b__70_0(FairyGUI.EventContext _); // 0x06186828
	System.Void <OnInit>b__70_1(FairyGUI.EventContext ctx); // 0x06186918
	System.Void <ReqGetUserInfo>b__71_1(); // 0x061869f0
	System.Void <TriggerGuide>b__143_0(WizardGames.Soc.SocClient.Ui.UiNewbieSelectMode win); // 0x06186aec
	System.Void <OnEscCloseOperation>b__151_0(); // 0x06186b74
	System.Void <OnEscCloseOperation>b__151_1(); // 0x06186c00
	System.Void <SetupShareButtons>b__152_4(System.Int32 isSuccess); // 0x06186cb8
	System.Void <SetupShareButtons>b__152_5(System.Int32 isSuccess); // 0x06186d70
	System.Void <SetupShareButtons>b__152_6(System.Int32 isSuccess); // 0x06186e28
	System.Void <InitTopBar>b__161_2(FairyGUI.EventContext ctx); // 0x06186ee0
	System.Void <InitTopBar>b__161_4(FairyGUI.EventContext ctx); // 0x06186f90
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyMain.<>c__DisplayClass106_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLobbyMain <>4__this; // 0x10
	System.String text; // 0x18
	WizardGames.Soc.SocClient.Ui.ETeamMessagePopTabType tab; // 0x20
	FairyGUI.PlayCompleteCallback <>9__1; // 0x28
	System.Void .ctor(); // 0x06187044
	System.Void <SwitchLobbyMessageTo>b__0(); // 0x061870ac
	System.Void <SwitchLobbyMessageTo>b__1(); // 0x061871ac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyMain.<>c__DisplayClass71_0 : System.Object
{
	WizardGames.Soc.SocClient.Http.EHttpReqModule reqModule; // 0x10
	System.Action callback; // 0x18
	System.Void .ctor(); // 0x06187294
	System.Void <ReqGetUserInfo>b__0(SimpleJSON.JSONNode res); // 0x061872fc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTeamBtn : System.Object
{
	FairyGUI.GButton btnTeamLobby; // 0x10
	FairyGUI.Transition loopAnim; // 0x18
	System.Boolean isClicked; // 0x20
	System.Int32 curTime; // 0x24
	System.Void Init(FairyGUI.GButton btn); // 0x06187a7c
	System.Void PlayLoopAnim(); // 0x06187c9c
	System.Void StopLoopAnim(); // 0x06187d1c
	System.Void OnFps1Update(System.Single dt); // 0x06187dec
	System.Void OnDestroy(); // 0x06187f8c
	System.Void OnEnable(); // 0x06187ff0
	System.Void OnDisable(); // 0x061880ac
	System.Void .ctor(); // 0x06188110
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbyTeamBtn.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiLobbyTeamBtn.<>c <>9; // 0x0
	static System.Action<WizardGames.Soc.SocClient.Ui.UiCommonTeamLobby> <>9__4_1; // 0x8
	static FairyGUI.EventCallback1 <>9__4_0; // 0x10
	static System.Void .cctor(); // 0x061881ac
	System.Void .ctor(); // 0x06188210
	System.Void <Init>b__4_0(FairyGUI.EventContext ctx); // 0x06188278
	System.Void <Init>b__4_1(WizardGames.Soc.SocClient.Ui.UiCommonTeamLobby win); // 0x06188414
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOverwrite : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GLoader screenshotLoader; // 0x338
	System.Int64 closeTimerId; // 0x340
	FairyGUI.NTexture nScreenTexture; // 0x348
	SocLogger <Logger>k__BackingField; // 0x350
	SocLogger get_Logger(); // 0x0618849c
	System.Void OnInit(); // 0x06188500
	System.Void OnDestroy(); // 0x06188634
	System.Void DisposeTexture(); // 0x061886ac
	System.Void CancelCloseTimer(); // 0x06188778
	System.Collections.IEnumerator CaptureAndShow(); // 0x0618887c
	static System.Void Open(System.Single delaySeconds); // 0x061889a4
	static System.Void ShowImmediately(); // 0x06188c00
	static System.Void Close(System.Single delaySeconds); // 0x06189008
	System.Void .ctor(); // 0x06189320
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOverwrite.CoroutineHelper : UnityEngine.MonoBehaviour
{
	
	System.Void .ctor(); // 0x06189448
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOverwrite.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiOverwrite.<>c <>9; // 0x0
	static WizardGames.Soc.Common.TimerWheel.TimerCallback <>9__12_0; // 0x8
	static System.Void .cctor(); // 0x061894b0
	System.Void .ctor(); // 0x06189514
	System.Void <Open>b__12_0(System.Int64 _, System.Object _, System.Boolean _); // 0x0618957c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOverwrite.<>c__DisplayClass15_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiOverwrite win; // 0x10
	System.Void .ctor(); // 0x061892b8
	System.Void <Close>b__0(System.Int64 _, System.Object _, System.Boolean _); // 0x0618960c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiOverwrite.<CaptureAndShow>d__11 : System.Object, System.Collections.Generic.IEnumerator<System.Object>, System.Collections.IEnumerator, System.IDisposable
{
	System.Int32 <>1__state; // 0x10
	System.Object <>2__current; // 0x18
	WizardGames.Soc.SocClient.Ui.UiOverwrite <>4__this; // 0x20
	System.Void .ctor(System.Int32 <>1__state); // 0x06188920
	System.Void System.IDisposable.Dispose(); // 0x061896b4
	System.Boolean MoveNext(); // 0x06189714
	System.Object System.Collections.Generic.IEnumerator<System.Object>.get_Current(); // 0x06189cc0
	System.Void System.Collections.IEnumerator.Reset(); // 0x06189d24
	System.Object System.Collections.IEnumerator.get_Current(); // 0x06189dac
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamInviteTips : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GButton btnInvite; // 0x338
	FairyGUI.GButton btnAppointmentInvite; // 0x340
	System.String roleId; // 0x348
	FairyGUI.GLoader bg; // 0x350
	FairyGUI.GGroup groupBtns; // 0x358
	WizardGames.Soc.SocClient.Ui.ETeamSource source; // 0x360
	System.Void OnInit(); // 0x06189e10
	System.Void OnEnable(); // 0x0618a244
	System.Void OnDisable(); // 0x0618a324
	System.Void OnDestroy(); // 0x0618a404
	System.Void OnTouchBegin(FairyGUI.EventContext context); // 0x0618a46c
	static System.Void Show(System.String roleId, UnityEngine.Vector2 pos, WizardGames.Soc.SocClient.Ui.ETeamSource source, System.String teamChangeEntrance); // 0x0618a5d8
	System.Void OnShow(System.String roleId, UnityEngine.Vector2 pos, WizardGames.Soc.SocClient.Ui.ETeamSource source); // 0x0618a9bc
	System.Void SetPosition(UnityEngine.Vector2 pos); // 0x0618ad2c
	System.Void OnClickInvite(); // 0x0618af98
	static System.Void OnInvite(System.String roleId, System.Boolean isAppointment, WizardGames.Soc.SocClient.Ui.ETeamSource source); // 0x0618aabc
	System.Void OnClickAppointmentInvite(); // 0x0618b06c
	System.Void .ctor(); // 0x0618b0d8
	System.Void <OnInit>b__6_0(FairyGUI.EventContext ctx); // 0x0618b164
	System.Void <OnInit>b__6_1(FairyGUI.EventContext ctx); // 0x0618b1dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamInviteTips.<>c__DisplayClass11_0 : System.Object
{
	System.String roleId; // 0x10
	UnityEngine.Vector2 pos; // 0x18
	WizardGames.Soc.SocClient.Ui.ETeamSource source; // 0x20
	System.Void .ctor(); // 0x0618a954
	System.Void <Show>b__0(WizardGames.Soc.SocClient.Ui.UiTeamInviteTips win); // 0x0618b254
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiTeamInviteTips.<>c__DisplayClass15_0 : System.Object
{
	System.String roleId; // 0x10
	System.Boolean isAppointment; // 0x18
	System.Int32 sourceIndex; // 0x1c
	System.Void .ctor(); // 0x0618b004
	System.Void <OnInvite>b__0(); // 0x0618b2e0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbySkinBase : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.UiLobbySkinBuildingBinder binder; // 0x338
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x340
	System.Boolean loaderShaderSetted; // 0x348
	WizardGames.Soc.SocClient.Ui.ComUiModel uiModel; // 0x350
	WizardGames.Soc.SocClient.Ui.ComUiModel weaponModel; // 0x358
	WizardGames.Soc.SocClient.Ui.ComDualTabs comDualTabs; // 0x360
	System.Int32 currentSortRule; // 0x368
	WizardGames.Soc.SocClient.Ui.ComAppWelfareText skinWeaponAppWelfareCom; // 0x370
	FairyGUI.GTextField lockedTextField; // 0x378
	WizardGames.Soc.SocClient.MallSkinData saveMallSkinData; // 0x380
	FairyGUI.GButton btnBuy; // 0x388
	System.Void BeforeClose(); // 0x055049cc
	System.Void OnInit(); // 0x0618b38c
	System.Void InitAppWelfareElement(); // 0x0618bc88
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x0618c008
	System.Void OnEnable(); // 0x0618c09c
	System.Void OnDisable(); // 0x0618c140
	System.Void OnDestroy(); // 0x0618c1e4
	System.Void OnFps10Update(System.Single dt); // 0x0618c2a8
	System.Void OnMallSkinChange(WizardGames.Soc.SocClient.MallSkinData mallSkinData); // 0x0618c35c
	System.Void OnClickBuy(); // 0x0618c5a8
	System.Void SetEquipState(System.String page); // 0x0618c684
	System.Int32 GetCurSkinId(); // 0x0618c6f8
	System.Int32 ThirdListSort(System.Int64 skinIdA, System.Int64 skinIdB, System.Int32 skinLvA, System.Int32 skinLvB, System.Int64 equipSkinId); // 0x0618c75c
	System.Void RefreshSkinWeaponAppWelfareInfo(System.Int64 skinId); // 0x0618caf4
	System.Void RefreshInUseTextPrivilegeInfo(WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.ThirdTabItemBinder thirdBinder, System.Int64 skinId); // 0x0618cc98
	System.Void .ctor(); // 0x0618ce88
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbySkinModify : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	WizardGames.Soc.SocClient.Ui.Binder.LobbySkin.RootLobbySkinModifyBinder modifyRootBind; // 0x338
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x340
	System.Int32 curSkinId; // 0x348
	System.Int32 curLevel; // 0x34c
	FairyGUI.GList levelList; // 0x350
	FairyGUI.GProgressBar levelProgress; // 0x358
	FairyGUI.GList rewardList; // 0x360
	FairyGUI.GTextField rewardTitle; // 0x368
	FairyGUI.GTextField rewardSubTitle; // 0x370
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiLobbySkinModify.LevelComInfo> levelComList; // 0x378
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.UiLobbySkinModify.RewardItemInfo> rewardItemList; // 0x380
	WizardGames.Soc.SocClient.Ui.UiLobbySkinModify.RewardItemInfo curRewardItemInfo; // 0x388
	WizardGames.Soc.SocClient.Ui.UiLobbySkinModify.LevelComInfo curLevelInfo; // 0x390
	FairyGUI.GButton unlockBtn; // 0x398
	System.Int32 coinId; // 0x3a0
	System.Boolean isAddListen; // 0x3a4
	WizardGames.Soc.SocClient.Ui.ComUiModel comWeaponModel; // 0x3a8
	WizardGames.Soc.SocClient.Ui.ComUiModel comUiModel; // 0x3b0
	WizardGames.Soc.SocClient.Ui.ComUiPlayerModel tpPlayerModel; // 0x3b8
	System.Int32 preivewItemId; // 0x3c0
	System.Int32 previewSkinId; // 0x3c4
	System.Int32 skinCharmId; // 0x3c8
	WizardGames.Soc.SocClient.Manager.EPreviewType curPreviewType; // 0x3cc
	DoMoveUtil doMoveUtil; // 0x3d0
	System.Void OnInit(); // 0x0618cf14
	System.Void InGameOnEquipChange(); // 0x0618dec8
	System.Void RemoveListen(); // 0x0618e378
	System.Void InGameReceiveEquipChange(); // 0x0618e454
	System.Void RefreshWnd(System.Int32 skinId); // 0x0618f17c
	System.Void OnRenderLevelList(System.Int32 index, FairyGUI.GObject obj); // 0x0618f35c
	System.Void OnClickLevel(WizardGames.Soc.SocClient.Ui.UiLobbySkinModify.LevelComInfo comInfo); // 0x0618f99c
	System.Void UpdateRewardItem(); // 0x0618fa8c
	System.Void UpdateUnlockBtn(); // 0x0618e868
	System.Void SetUnlockBtnState(System.String state); // 0x0619039c
	System.Void OnClickUnlockBtn(); // 0x061904c0
	System.Void ShowBuyCoidTip(System.Int32 coinId); // 0x06190ca0
	System.Void SendToUnlockReward(); // 0x06190bec
	System.Void OpenSelectTip(); // 0x06191168
	System.Void OnConfirmClickCallback(System.Int32 index); // 0x061917f4
	System.Void OnReciveEquipColorSkin(System.Int32 colorSkinId, System.Int32 opType); // 0x0619198c
	System.Void OnReciveUnLockColorReward(System.Int32 level, System.Int32 slot, System.Int32 skinId); // 0x06191a68
	System.Void UpdateLevelProgress(); // 0x06191c90
	System.Void OnClickRewardItem(WizardGames.Soc.SocClient.Ui.UiLobbySkinModify.RewardItemInfo rewardItem); // 0x06191d8c
	System.Void RefreshLevelList(); // 0x0618f1f8
	System.Void OnClickPreview(); // 0x06192364
	System.Void OnEscClose(FairyGUI.EventContext context); // 0x06192638
	System.Void Dispose(); // 0x061926b8
	System.Void Init(); // 0x0618dfa0
	System.Void OnClickPreviewShow(WizardGames.Soc.SocClient.Ui.UiLobbySkinModify.RewardItemInfo itemInfo); // 0x061923cc
	System.Void OpenPreviewWnd(System.Int32 Id, System.Int32 skinCharmId); // 0x061928b0
	System.Void SetPreviewType(WizardGames.Soc.SocClient.Ui.UiLobbySkinModify.RewardItemInfo itemInfo); // 0x06192174
	System.Void PlayVideo(WizardGames.Soc.SocClient.Ui.UiLobbySkinModify.RewardItemInfo itemInfo); // 0x06192784
	System.Void RefreshModel(WizardGames.Soc.SocClient.Manager.EPreviewType previewType); // 0x06192d28
	WizardGames.Soc.SocClient.Manager.EPreviewType GetPreviewTypeBySkinId(); // 0x06192bfc
	System.Void RefreshItemModel(); // 0x061935dc
	WizardGames.Soc.SocClient.Ui.ComUiModel ChoseUiModel(); // 0x0619375c
	System.Void InitTpPlayerModel(); // 0x06193010
	System.Int32 GetSex(); // 0x06193a90
	System.Void RefreshTpPlayerModel(); // 0x06193340
	System.Void StartDoMove(); // 0x061937e4
	System.Void EndDoMove(); // 0x06192ab4
	System.Void OnEnable(); // 0x06193c20
	System.Void OnDisable(); // 0x06193cd4
	System.Void OnDestroy(); // 0x06193d78
	System.Void .ctor(); // 0x06193e3c
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbySkinModify.RewardItemInfo : System.Object
{
	System.Int32 rewardId; // 0x10
	System.Int32 count; // 0x14
	FairyGUI.GComponent com; // 0x18
	WizardGames.Soc.SocClient.Ui.ComResIcon icon; // 0x20
	WizardGames.Soc.Common.Data.resource.OBJGenaral generalCfg; // 0x28
	WizardGames.Soc.Common.Data.resource.OBJSkinUpgradeReward upGradeRewardCfg; // 0x30
	WizardGames.Soc.SocClient.Ui.UiLobbySkinModify parent; // 0x38
	System.Boolean isUnlock; // 0x40
	System.Boolean canEquip; // 0x41
	System.Boolean isEquip; // 0x42
	System.Int32 skinId; // 0x44
	System.Int32 level; // 0x48
	System.Int32 slot; // 0x4c
	System.Collections.Generic.List<System.Int32> coinIds; // 0x50
	System.Collections.Generic.List<System.Int32> coinNums; // 0x58
	System.Int32 lackCoinId; // 0x60
	System.Int32 lackCoinNum; // 0x64
	System.Int32 unlockType; // 0x68
	System.Void Update(System.Int32 _rewardId, System.Int32 _count, System.Int32 _slot, System.Int32 _skinId, System.Int32 _level, FairyGUI.GComponent _com, WizardGames.Soc.SocClient.Ui.UiLobbySkinModify _parent); // 0x0618ff8c
	System.Void FireClick(); // 0x0618fe24
	System.Void UpdateEquipState(); // 0x0618e4c8
	System.Void UpdateUnLockCost(); // 0x06193ed0
	System.Boolean CheckEnoughCoin(); // 0x06190a24
	System.Void OnClickRewardItem(); // 0x061940c4
	System.Void .ctor(); // 0x0618fea8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbySkinModify.LevelComInfo : System.Object
{
	System.Int32 skinId; // 0x10
	System.Int32 level; // 0x14
	System.Boolean unlock; // 0x18
	WizardGames.Soc.SocClient.Ui.Binder.CommonGlobal.NavBtn_ProgressBinder comBind; // 0x20
	WizardGames.Soc.Common.Data.resource.OBJSkinUpgrade upGradeCfg; // 0x28
	System.Void .ctor(WizardGames.Soc.Common.Data.resource.OBJSkinUpgrade _upGradeCfg, System.Int32 _skinId, FairyGUI.GComponent _com); // 0x0618f688
	System.Void UpdateState(); // 0x06191bc8
	System.Void UpdateCom(); // 0x06194134
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.UiLobbySkinModify.ERewardPreviewType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.UiLobbySkinModify.ERewardPreviewType None = 0;
	static WizardGames.Soc.SocClient.Ui.UiLobbySkinModify.ERewardPreviewType ItemTips = 1;
	static WizardGames.Soc.SocClient.Ui.UiLobbySkinModify.ERewardPreviewType Video = 2;
	static WizardGames.Soc.SocClient.Ui.UiLobbySkinModify.ERewardPreviewType Model = 3;
	static WizardGames.Soc.SocClient.Ui.UiLobbySkinModify.ERewardPreviewType PartModel = 4;
	static WizardGames.Soc.SocClient.Ui.UiLobbySkinModify.ERewardPreviewType Com = 5;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbySkinModify.<>c__DisplayClass21_0 : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiLobbySkinModify <>4__this; // 0x10
	WizardGames.Soc.SocClient.Ui.UiLobbySkinModify.LevelComInfo comInfo; // 0x18
	System.Void .ctor(); // 0x0618f620
	System.Void <OnRenderLevelList>b__0(); // 0x06194348
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiLobbySkinModify.<>c__DisplayClass27_0 : System.Object
{
	System.Int32 jumpId; // 0x10
	System.Void .ctor(); // 0x0619178c
	System.Void <ShowBuyCoidTip>b__0(); // 0x061943b8
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.SkinWeaponRoleAppPrivilegeInfo : System.Object
{
	System.String title; // 0x10
	System.String titleSuffix; // 0x18
	System.Void .ctor(System.String title, System.String titleSuffix); // 0x06194474
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.ComAppWelfareText : FairyGUI.GComponent
{
	System.Collections.Generic.Dictionary<Config.MgrConfig.ERoleAppPrivilegeType,WizardGames.Soc.SocClient.Ui.SkinWeaponRoleAppPrivilegeInfo> skinWeaponRoleAppPrivilegeInfoDic; // 0x288
	FairyGUI.Controller welfareRootCtr; // 0x290
	FairyGUI.GComponent welfareLeftRootCom; // 0x298
	FairyGUI.GLoader welfareLeftIconGLoader; // 0x2a0
	FairyGUI.GTextField welfareLeftTextField; // 0x2a8
	FairyGUI.GComponent welfareRightRootCom; // 0x2b0
	FairyGUI.Controller welfareRightCtr; // 0x2b8
	FairyGUI.GTextField welfareRightextField; // 0x2c0
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x06194518
	System.Void RefreshAppWelfareInfo(System.Int64 skinWeaponId); // 0x0618cb84
	System.Void RefreshAppWelfarCommonInfo(Config.MgrConfig.ERoleAppPrivilegeType roleAppPrivilegeType); // 0x06194774
	System.Void .ctor(); // 0x06194934
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.GameSkinEquipItem : FairyGUI.GComponent
{
	WizardGames.Soc.Common.Data.DataItem.SkinArmorConfig <OriginSkinCfg>k__BackingField; // 0x288
	WizardGames.Soc.Common.Data.DataItem.ItemConfig <OriginSkinItemCfg>k__BackingField; // 0x290
	WizardGames.Soc.SocClient.Ui.UiGameSkinEquip <Owner>k__BackingField; // 0x298
	FairyGUI.GList <ParentListCom>k__BackingField; // 0x2a0
	FairyGUI.GComponent skinItem; // 0x2a8
	WizardGames.Soc.SocClient.Ui.GameSkinEquipItem.EArmorSkinType <SkinType>k__BackingField; // 0x2b0
	System.Int32 <SkinId>k__BackingField; // 0x2b4
	WizardGames.Soc.Common.Data.DataItem.SkinConfig skinConfig; // 0x2b8
	FairyGUI.GLoader loaderIcon; // 0x2c0
	FairyGUI.GTextField titleTxt; // 0x2c8
	FairyGUI.Controller equipCtr; // 0x2d0
	FairyGUI.Controller statusCtr; // 0x2d8
	FairyGUI.Controller collectCtr; // 0x2e0
	FairyGUI.Controller timeLimitCtr; // 0x2e8
	FairyGUI.Controller redDotCtr; // 0x2f0
	FairyGUI.Controller rarityCtr; // 0x2f8
	FairyGUI.Controller styleCtr; // 0x300
	FairyGUI.GLoader appWelfareIconGLoader; // 0x308
	WizardGames.Soc.Common.Data.DataItem.SkinArmorConfig get_OriginSkinCfg(); // 0x06194b04
	System.Void set_OriginSkinCfg(WizardGames.Soc.Common.Data.DataItem.SkinArmorConfig value); // 0x06194b68
	WizardGames.Soc.Common.Data.DataItem.ItemConfig get_OriginSkinItemCfg(); // 0x06194be8
	System.Void set_OriginSkinItemCfg(WizardGames.Soc.Common.Data.DataItem.ItemConfig value); // 0x06194c4c
	WizardGames.Soc.SocClient.Ui.UiGameSkinEquip get_Owner(); // 0x06194ccc
	System.Void set_Owner(WizardGames.Soc.SocClient.Ui.UiGameSkinEquip value); // 0x06194d30
	FairyGUI.GList get_ParentListCom(); // 0x06194db0
	System.Void set_ParentListCom(FairyGUI.GList value); // 0x06194e14
	WizardGames.Soc.SocClient.Ui.GameSkinEquipItem.EArmorSkinType get_SkinType(); // 0x06194e94
	System.Void set_SkinType(WizardGames.Soc.SocClient.Ui.GameSkinEquipItem.EArmorSkinType value); // 0x06194ef8
	System.Void set_SkinId(System.Int32 value); // 0x06194f70
	System.Int32 get_SkinId(); // 0x06194fe8
	System.Boolean get_IsEquip(); // 0x0619504c
	System.Boolean get_IsLock(); // 0x061950dc
	System.Boolean get_IsSelect(); // 0x0619516c
	System.Boolean get_IsCollect(); // 0x06195220
	System.Boolean get_IsExpired(); // 0x061952b0
	System.Void ConstructFromXML(FairyGUI.Utils.XML xml); // 0x06195340
	System.Void UpdataOriginSkin(WizardGames.Soc.SocClient.Ui.UiGameSkinEquip owner, FairyGUI.GList skinList, WizardGames.Soc.Common.Data.DataItem.SkinArmorConfig config, System.Boolean owned); // 0x061956f4
	System.Void UpdateOriginSkinCom(); // 0x06195a3c
	System.Void RefreshAppWelfareInfo(System.Int64 skinId); // 0x0619682c
	System.Void UpdataSkin(WizardGames.Soc.SocClient.Ui.UiGameSkinEquip owner, FairyGUI.GList skinList, WizardGames.Soc.Common.Data.DataItem.SkinConfig config, System.Boolean owned); // 0x061969c4
	System.Void RenderSkinListItem(); // 0x06196c24
	System.Void UpdataSkinEquipState(); // 0x06196e44
	System.Void SetNewState(System.Boolean isShow); // 0x06195ecc
	System.Void SetEquipState(System.String page); // 0x06196ffc
	System.Void SetRarityState(System.Int32 level); // 0x06195d14
	System.Void UpdataOriginEquipState(); // 0x06195d9c
	System.Void OnSkinListItemClick(FairyGUI.EventContext context); // 0x06196128
	System.Void CheckIsCoverServerData(System.Boolean isWear, System.Int32 part); // 0x06197180
	System.Void OnSkinWearChange(); // 0x06197084
	System.Void UpdataSelect(System.Boolean isSelect); // 0x061965d8
	System.Void UpdataCollect(); // 0x06195f84
	System.Void UpdataTimeLimit(); // 0x0619666c
	System.Void .ctor(); // 0x061972ec
}

// Client.Runtime
enum WizardGames.Soc.SocClient.Ui.GameSkinEquipItem.EArmorSkinType : System.Enum
{
	System.Int32 value__; // 0x10
	static WizardGames.Soc.SocClient.Ui.GameSkinEquipItem.EArmorSkinType None = 0;
	static WizardGames.Soc.SocClient.Ui.GameSkinEquipItem.EArmorSkinType OriginSkin = 1;
	static WizardGames.Soc.SocClient.Ui.GameSkinEquipItem.EArmorSkinType Skin = 2;
	
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameCostume : WizardGames.Soc.Common.Unity.Ui.WindowComBase
{
	FairyGUI.GComponent content; // 0x338
	FairyGUI.GComponent root; // 0x340
	FairyGUI.GButton btnModify; // 0x348
	FairyGUI.GButton btnEquip; // 0x350
	FairyGUI.GTextField desTitle; // 0x358
	FairyGUI.Controller desLevleController; // 0x360
	FairyGUI.GTextField desDetail; // 0x368
	FairyGUI.GLoader loaderModel; // 0x370
	WizardGames.Soc.SocClient.Ui.ComUiPlayerModel playerModel; // 0x378
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.SkinArmorType> primaryTabConfig; // 0x380
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.SkinArmorConfig> OnePartTabConfig; // 0x388
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.OBJSkin>> OnePartAllSkinDic; // 0x390
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.GSkinArmorItem> secondaryTabItem; // 0x398
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.SkinConfig> skinListConfig; // 0x3a0
	FairyGUI.GComponent titleCom; // 0x3a8
	FairyGUI.Controller titleComCtr; // 0x3b0
	FairyGUI.GTextField limitTimeTxt; // 0x3b8
	System.Boolean selectSuit; // 0x3c0
	WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor.ESkinOrderType <OrderType>k__BackingField; // 0x3c4
	System.Int32 <SelectedSecondIndex>k__BackingField; // 0x3c8
	WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor.EFirstTabType <SelectedFirstIndex>k__BackingField; // 0x3cc
	System.Boolean <IsEditPlan>k__BackingField; // 0x3d0
	System.Boolean isShowModel; // 0x3d1
	System.Int64 EquippedSkinId; // 0x3d8
	System.Int32 SelectSkinId; // 0x3e0
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> CachedSkin; // 0x3e8
	FairyGUI.Controller Status; // 0x3f0
	FairyGUI.Controller equipStateCtr; // 0x3f8
	System.Collections.Generic.List<Bright.Config.BeanBase> skinVirtualListDatas; // 0x400
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> virtualToSkinCfg; // 0x408
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> virtualToOriginSkin; // 0x410
	WizardGames.Soc.SocClient.Ui.ComDualTabs comdualTab; // 0x418
	FairyGUI.GComponent comDescription; // 0x420
	WizardGames.Soc.SocClient.Ui.ComComboBox sortCom; // 0x428
	WizardGames.Soc.SocClient.Ui.ComComboBox editPlanChose; // 0x430
	FairyGUI.GButton btnPreview; // 0x438
	FairyGUI.GComponent actionTip; // 0x440
	FairyGUI.GButton switchLightBtn; // 0x448
	FairyGUI.GButton switchSexBtn; // 0x450
	FairyGUI.GButton highLightBtn; // 0x458
	FairyGUI.GButton actionBtn; // 0x460
	FairyGUI.Controller sexCtr; // 0x468
	FairyGUI.Controller lightCtr; // 0x470
	System.Collections.Generic.List<System.String> editPlanName; // 0x478
	WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor.ENewSkinOrderType curSortType; // 0x480
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> editEquipPlan; // 0x488
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> editCostumePlan; // 0x490
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> tempEquipPlan; // 0x498
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> tempCostumePlan; // 0x4a0
	WizardGames.Soc.SocClient.Ui.UiGameCostumeData costumeIns; // 0x4a8
	FairyGUI.GList costumePartList; // 0x4b0
	FairyGUI.GList costumeSuitList; // 0x4b8
	FairyGUI.GList costumePlanList; // 0x4c0
	FairyGUI.GButton suitBtn; // 0x4c8
	FairyGUI.GButton planBtn; // 0x4d0
	FairyGUI.GObject collectBtn; // 0x4d8
	FairyGUI.GObject shareBtn; // 0x4e0
	FairyGUI.Controller collectCtr; // 0x4e8
	FairyGUI.Controller shareCtr; // 0x4f0
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x4f8
	FairyGUI.GButton showOptionBtn; // 0x500
	FairyGUI.GComponent optionRoot; // 0x508
	WizardGames.Soc.SocClient.Ui.GSkinOptionTip optionTipIns; // 0x510
	FairyGUI.GTextField lockedComTextField; // 0x518
	WizardGames.Soc.SocClient.Ui.ComAppWelfareText skinWeaponAppWelfareCom; // 0x520
	System.Boolean isFirstEnable; // 0x528
	WizardGames.Soc.SocClient.MallSkinData saveMallSkinData; // 0x530
	FairyGUI.GButton btnBuy; // 0x538
	System.Void set_OrderType(WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor.ESkinOrderType value); // 0x06197354
	System.Int32 get_SelectedSecondIndex(); // 0x061973cc
	System.Void set_SelectedSecondIndex(System.Int32 value); // 0x06197430
	WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor.EFirstTabType get_SelectedFirstIndex(); // 0x061974a8
	System.Void set_SelectedFirstIndex(WizardGames.Soc.SocClient.Ui.UiLobbySkinArmor.EFirstTabType value); // 0x0619750c
	System.Boolean get_IsEditPlan(); // 0x06197584
	System.Void OnInit(); // 0x061975e8
	System.Void InitComDualTab(); // 0x06199ecc
	System.Void UpdateSecondTab(System.Int32 parentIndex, System.Collections.Generic.List<System.String> secondDatas); // 0x0619a380
	System.Void FirstTabBack(System.Int32 index); // 0x0619a49c
	System.Void SecondTabBack(System.Int32 first, System.Int32 second); // 0x0619a9b4
	System.Void UpdataTitleCom(); // 0x0619b27c
	System.Void UpdataSecondIcon(); // 0x0619a560
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> ChoseEquipPlanDic(); // 0x0619bc9c
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> ChoseCostumePlanDic(); // 0x0619b8c0
	System.String CheckIsWearSuit(); // 0x0619b978
	System.Boolean CheckCostumeIsEquip(System.Int64 costumeId); // 0x0619bd54
	System.Void ShowSelectData(System.Boolean isShow); // 0x0619ab4c
	System.Void SetCollect(System.String pageName); // 0x0619c134
	System.Void SetShare(System.String pageName); // 0x0619c1bc
	System.Void OnSuitBtnClick(); // 0x0619c244
	System.Void OnPlanBtnClick(); // 0x0619c310
	System.Void OnClickShareBack(); // 0x0619c3d0
	System.Void OnClickCollectBack(); // 0x0619c760
	System.Void OnReceiveCollect(); // 0x0619cf10
	System.Void OnSortRefreshBack(System.Int32 index); // 0x0619d234
	System.Void RefreshPlan(); // 0x0619d34c
	System.Void InitTempPlan(); // 0x06199358
	System.Void OnEnable(); // 0x0619d44c
	System.Void OnDisable(); // 0x0619e4b8
	System.Void OnDestroy(); // 0x0619e574
	System.Void BeforeClose(); // 0x0619e638
	System.Void SyncToServer(); // 0x0619e6ac
	System.Boolean CheckPartIsLow(System.Int32 partSkinId, System.Boolean partIsEquip, System.Collections.Generic.Dictionary<System.Int32,System.Int32> targetDic); // 0x0619ea24
	System.Void SetLimitTimeTxt(); // 0x0619bee0
	System.Void RefreshCollectBtn(); // 0x0619cfa4
	System.Void RefreshEquipBtn(); // 0x0619e0c0
	System.Void RefreshDescription(System.String title, System.String desc, System.Int32 level); // 0x0619efec
	System.Void InitDescriptionCom(); // 0x06199a04
	System.Void InitSkinWeaponAppWelfareCom(); // 0x06199d24
	System.Void RefreshSkinWeaponAppWelfareInfo(); // 0x0619f0c8
	System.Void RefreshInUseTextPrivilegeInfo(); // 0x0619f140
	System.Void OnClickPreviewBtn(); // 0x0619f2c8
	System.Void SetEquipState(System.String pageName); // 0x0619ef5c
	System.Void UpdateModifyState(); // 0x0619f640
	System.Void OnClickModifyBtn(); // 0x0619f6b4
	System.Void OnMallSkinChange(WizardGames.Soc.SocClient.MallSkinData mallSkinData); // 0x0619f768
	System.Void OnClickBuy(); // 0x0619fabc
	System.Int32 GetCurSkinId(); // 0x0619f99c
	System.Void onClickEquip(); // 0x0619fb8c
	System.Void RefreshEquipBtnGroup(); // 0x0619b600
	System.Void OnClickSwtichLightBtn(); // 0x0619fd98
	System.Void OnClickSwitchSexBtn(); // 0x061a0014
	System.Void OnClickHighLightBtn(); // 0x061a01b8
	System.Void OnClickActionBtn(); // 0x061a0350
	System.Void OnClickEnterAction(); // 0x061a048c
	System.Void OnClickShowAction(); // 0x061a066c
	System.Void CheckIsShowOptionTip(); // 0x0619a1c0
	System.Void InitModel(); // 0x0619d6c0
	System.Void RefreshModel(); // 0x0619d948
	System.Void MakeFullScreen(); // 0x061a084c
	System.Void .ctor(); // 0x061a08b4
	System.Void <OnInit>b__99_0(FairyGUI.EventContext ctx); // 0x061a0c54
	WizardGames.Soc.SocClient.GoLoader.DisplayModel <OnInit>b__99_1(); // 0x061a0ccc
	System.Void <OnInit>b__99_2(); // 0x061a0d74
	System.Void <OnInit>b__99_3(FairyGUI.EventContext ctx); // 0x061a0de4
	System.Void <OnInit>b__99_4(FairyGUI.EventContext ctx); // 0x061a0e5c
	System.Void <OnClickShareBack>b__115_0(); // 0x061a0ed4
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameCostumeData : System.Object
{
	static SocLogger logger; // 0x0
	WizardGames.Soc.SocClient.Ui.UiGameCostume <UiGameCostumeIns>k__BackingField; // 0x10
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.CostumePartConfig> allCostumeParyCfg; // 0x18
	FairyGUI.GList partList; // 0x20
	FairyGUI.GList suitList; // 0x28
	FairyGUI.GList suitPlanList; // 0x30
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.CostumeConfig>> allCostumeCfg; // 0x38
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.CostumeConfig> curShowPartList; // 0x40
	System.Int32 curPart; // 0x48
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.GameCostumeItemData> costumeItemList; // 0x50
	WizardGames.Soc.SocClient.Ui.GameCostumeItemData curCostumeItemData; // 0x58
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.collection.OBJCostumeSuit> curShowSuitList; // 0x60
	System.Collections.Generic.List<WizardGames.Soc.SocClient.Ui.GameCostumeSuitItemData> costumeSuitItemList; // 0x68
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.collection.OBJCostumePlan> curShowPlanList; // 0x70
	WizardGames.Soc.SocClient.Ui.GameCostumeSuitItemData curCostumeSuitItemData; // 0x78
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> <SyncToServerDic>k__BackingField; // 0x80
	System.Int32 tempSex; // 0x88
	System.Void set_UiGameCostumeIns(WizardGames.Soc.SocClient.Ui.UiGameCostume value); // 0x061a0f50
	WizardGames.Soc.SocClient.Ui.UiGameCostume get_UiGameCostumeIns(); // 0x061a0fd0
	System.Void set_SyncToServerDic(System.Collections.Generic.Dictionary<System.Int32,System.Int32> value); // 0x061a1034
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> get_SyncToServerDic(); // 0x061a10b4
	System.Void Init(WizardGames.Soc.SocClient.Ui.UiGameCostume skinArmorIns, FairyGUI.GList comPartList, FairyGUI.GList comSuitList, FairyGUI.GList comSuitPlanList); // 0x06198f98
	System.Void InitToServerData(); // 0x061a1118
	System.Void UpdataList(System.Int32 partIndex); // 0x0619ac54
	System.Void SortShowList(); // 0x061a1e14
	System.Void UpdataCostumePart(); // 0x061a15e8
	System.Void UpdataCostumeSuit(); // 0x061a1828
	System.Void UpdataOnePart(System.Int32 costumePart); // 0x061a2254
	System.Void OnRenderPartList(System.Int32 index, FairyGUI.GObject obj); // 0x061a2684
	System.Void OnRenderSuitList(System.Int32 index, FairyGUI.GObject obj); // 0x061a2858
	System.Void OnRenderPlanList(System.Int32 index, FairyGUI.GObject obj); // 0x061a2a28
	System.Void OnCostumeItemClick(WizardGames.Soc.SocClient.Ui.GameCostumeItemData itemData, FairyGUI.EventContext context); // 0x061a3594
	System.Void OnCostumeSuitClick(WizardGames.Soc.SocClient.Ui.GameCostumeSuitItemData data, FairyGUI.EventContext context); // 0x061a4080
	System.Void CheckIsCoverServerData(System.Boolean isWear, System.Int32 part, System.Int32 skinId); // 0x061a3d90
	System.Void OnCostumeWearChange(); // 0x061a3f8c
	System.Void OnUseBtnBack(FairyGUI.EventContext context); // 0x061a4e7c
	System.Void UpdataPartListCount(System.Int32 count); // 0x061a2048
	System.Void UpdataSuitListCount(System.Int32 count); // 0x061a1c70
	System.Int32 ChangeSex(System.Int32 sex); // 0x061a54cc
	System.Void CheckUnWearBySex(System.Int32 costumeId); // 0x061a5550
	System.Void .ctor(); // 0x06198ee4
	static System.Void .cctor(); // 0x061a5720
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameCostumeData.<>c : System.Object
{
	static WizardGames.Soc.SocClient.Ui.UiGameCostumeData.<>c <>9; // 0x0
	static System.Comparison<WizardGames.Soc.Common.Data.DataItem.CostumePartConfig> <>9__27_0; // 0x8
	static System.Void .cctor(); // 0x061a57f4
	System.Void .ctor(); // 0x061a5858
	System.Int32 <UpdataCostumePart>b__27_0(WizardGames.Soc.Common.Data.DataItem.CostumePartConfig x, WizardGames.Soc.Common.Data.DataItem.CostumePartConfig y); // 0x061a58c0
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameCostumeData.<>c__DisplayClass26_0 : System.Object
{
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> costumeDic; // 0x10
	System.Void .ctor(); // 0x061a21ec
	System.Int32 <SortShowList>b__0(WizardGames.Soc.Common.Data.DataItem.CostumeConfig x, WizardGames.Soc.Common.Data.DataItem.CostumeConfig y); // 0x061a5954
	System.Int32 <SortShowList>b__1(WizardGames.Soc.Common.Data.DataItem.CostumeConfig x, WizardGames.Soc.Common.Data.DataItem.CostumeConfig y); // 0x061a5e04
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.GameCostumeSuitItemData : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiGameCostumeData <LobbyCostumeIns>k__BackingField; // 0x10
	WizardGames.Soc.Common.Data.collection.OBJCostumeSuit <CostumeSuitCfg>k__BackingField; // 0x18
	WizardGames.Soc.Common.Data.resource.OBJGenaral genaralCfg; // 0x20
	FairyGUI.GComponent <Com>k__BackingField; // 0x28
	System.Action<WizardGames.Soc.SocClient.Ui.GameCostumeSuitItemData,FairyGUI.EventContext> clickBack; // 0x30
	System.Boolean <IsSelect>k__BackingField; // 0x38
	System.Boolean <IsWear>k__BackingField; // 0x39
	System.Boolean <IsUnlock>k__BackingField; // 0x3a
	System.Boolean <IsCollect>k__BackingField; // 0x3b
	FairyGUI.Controller newStateCtr; // 0x40
	FairyGUI.Controller timeLimitCtr; // 0x48
	FairyGUI.Controller rarityCtr; // 0x50
	System.Void set_LobbyCostumeIns(WizardGames.Soc.SocClient.Ui.UiGameCostumeData value); // 0x061a62c8
	WizardGames.Soc.SocClient.Ui.UiGameCostumeData get_LobbyCostumeIns(); // 0x061a6348
	System.Void set_CostumeSuitCfg(WizardGames.Soc.Common.Data.collection.OBJCostumeSuit value); // 0x061a63ac
	WizardGames.Soc.Common.Data.collection.OBJCostumeSuit get_CostumeSuitCfg(); // 0x061a642c
	System.Void set_Com(FairyGUI.GComponent value); // 0x061a6490
	FairyGUI.GComponent get_Com(); // 0x061a6510
	System.Void set_IsSelect(System.Boolean value); // 0x061a6574
	System.Boolean get_IsSelect(); // 0x061a65f0
	System.Void set_IsWear(System.Boolean value); // 0x061a6654
	System.Boolean get_IsWear(); // 0x061a66d0
	System.Void set_IsUnlock(System.Boolean value); // 0x061a6734
	System.Boolean get_IsUnlock(); // 0x061a67b0
	System.Void set_IsCollect(System.Boolean value); // 0x061a6814
	System.Boolean get_IsCollect(); // 0x061a6890
	System.Void SetData(WizardGames.Soc.SocClient.Ui.UiGameCostumeData UiLobbyCostumeIns, System.Action<WizardGames.Soc.SocClient.Ui.GameCostumeSuitItemData,FairyGUI.EventContext> back, WizardGames.Soc.Common.Data.collection.OBJCostumeSuit data, FairyGUI.GComponent com); // 0x061a68f4
	System.Boolean CheckIsNew(); // 0x061a7480
	System.Boolean CheckIsGet(); // 0x061a72cc
	System.Boolean CheckIsCollect(); // 0x061a82d8
	System.Boolean CheckIsEquip(); // 0x061a762c
	System.Void UpdataSelect(System.Boolean isSelect); // 0x061a8000
	System.Boolean CheckCostumeIsEquip(System.Int64 costumeId); // 0x061a848c
	System.Void OnClickSuitItem(FairyGUI.EventContext context); // 0x061a7948
	System.Void UpdataCollect(); // 0x061a7794
	System.Void UpdataTimeLimit(System.Int32 id); // 0x061a815c
	System.Void Reset(); // 0x061a86b8
	System.Void .ctor(); // 0x061a8824
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.GameCostumeItemData : System.Object
{
	WizardGames.Soc.SocClient.Ui.UiGameCostumeData <LobbyCostumeIns>k__BackingField; // 0x10
	System.Int32 <CurPart>k__BackingField; // 0x18
	WizardGames.Soc.Common.Data.DataItem.CostumeConfig <CostumeCfg>k__BackingField; // 0x20
	FairyGUI.GComponent <Com>k__BackingField; // 0x28
	System.Action<WizardGames.Soc.SocClient.Ui.GameCostumeItemData,FairyGUI.EventContext> clickBack; // 0x30
	System.Boolean <IsSelect>k__BackingField; // 0x38
	System.Boolean <IsUnlock>k__BackingField; // 0x39
	System.Boolean <IsCollect>k__BackingField; // 0x3a
	FairyGUI.Controller timeLimitCtr; // 0x40
	System.Boolean <IsWear>k__BackingField; // 0x48
	FairyGUI.Controller newStateCtr; // 0x50
	FairyGUI.GLoader appWelfareIconGLoader; // 0x58
	System.Void set_LobbyCostumeIns(WizardGames.Soc.SocClient.Ui.UiGameCostumeData value); // 0x061a888c
	WizardGames.Soc.SocClient.Ui.UiGameCostumeData get_LobbyCostumeIns(); // 0x061a890c
	System.Void set_CurPart(System.Int32 value); // 0x061a8970
	System.Int32 get_CurPart(); // 0x061a89e8
	System.Void set_CostumeCfg(WizardGames.Soc.Common.Data.DataItem.CostumeConfig value); // 0x061a8a4c
	WizardGames.Soc.Common.Data.DataItem.CostumeConfig get_CostumeCfg(); // 0x061a8acc
	System.Void set_Com(FairyGUI.GComponent value); // 0x061a8b30
	FairyGUI.GComponent get_Com(); // 0x061a8bb0
	System.Void set_IsSelect(System.Boolean value); // 0x061a8c14
	System.Boolean get_IsSelect(); // 0x061a8c90
	System.Void set_IsUnlock(System.Boolean value); // 0x061a8cf4
	System.Boolean get_IsUnlock(); // 0x061a8d70
	System.Void set_IsCollect(System.Boolean value); // 0x061a8dd4
	System.Boolean get_IsCollect(); // 0x061a8e50
	System.Void set_IsWear(System.Boolean value); // 0x061a8eb4
	System.Boolean get_IsWear(); // 0x061a8f30
	System.Void SetData(WizardGames.Soc.SocClient.Ui.UiGameCostumeData UiLobbyCostumeIns, System.Action<WizardGames.Soc.SocClient.Ui.GameCostumeItemData,FairyGUI.EventContext> back, WizardGames.Soc.Common.Data.DataItem.CostumeConfig data, FairyGUI.GComponent com, System.Int32 curPart); // 0x061a8f94
	System.Void UpdateEquip(); // 0x061a99f4
	System.Void UpdataSelect(System.Boolean isSelect); // 0x061aa508
	System.Void UpdataTimeLimit(); // 0x061aa620
	System.Void RefreshAppWelfareInfo(System.Int64 skinId); // 0x061aa7e4
	System.Boolean CheckCostumeIsWear(System.Int64 costumeId); // 0x061a9844
	System.Void OnClickPartItem(FairyGUI.EventContext context); // 0x061a9f8c
	System.Void UpdataCollect(); // 0x061a9d34
	System.Void Reset(); // 0x061aa97c
	System.Void .ctor(); // 0x061aa9dc
}

// Client.Runtime
class WizardGames.Soc.SocClient.Ui.UiGameSkinEquip : WizardGames.Soc.Common.Unity.Ui.WindowComBase, WizardGames.Soc.Common.Unity.Ui.IUiFps10Update, WizardGames.Soc.Common.Unity.Ui.IUiFps30Update
{
	FairyGUI.GComponent content; // 0x338
	FairyGUI.GComponent root; // 0x340
	FairyGUI.GButton btnModify; // 0x348
	FairyGUI.GButton btnEquip; // 0x350
	FairyGUI.GTextField desTitle; // 0x358
	FairyGUI.Controller desLevleController; // 0x360
	FairyGUI.GTextField desDetail; // 0x368
	System.Boolean loaderShaderSetted; // 0x370
	FairyGUI.GLoader loaderModel; // 0x378
	WizardGames.Soc.SocClient.Ui.ComUiPlayerModel playerModel; // 0x380
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.SkinArmorType> primaryTabConfig; // 0x388
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.SkinArmorConfig> OnePartTabConfig; // 0x390
	System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<WizardGames.Soc.Common.Data.resource.OBJSkin>> OnePartAllSkinDic; // 0x398
	System.Collections.Generic.Dictionary<System.Int32,WizardGames.Soc.SocClient.Ui.GameSkinEquipItem> secondaryTabItem; // 0x3a0
	System.Collections.Generic.List<WizardGames.Soc.Common.Data.DataItem.SkinConfig> skinListConfig; // 0x3a8
	WizardGames.Soc.SocClient.Ui.GameSkinEquipItem curSelectArmor; // 0x3b0
	FairyGUI.GComponent titleCom; // 0x3b8
	FairyGUI.Controller titleComCtr; // 0x3c0
	FairyGUI.GTextField limitTimeTxt; // 0x3c8
	System.Boolean selectSuit; // 0x3d0
	WizardGames.Soc.SocClient.Ui.UiGameSkinEquip.ESkinOrderType <OrderType>k__BackingField; // 0x3d4
	System.Int32 <SelectedSecondIndex>k__BackingField; // 0x3d8
	WizardGames.Soc.SocClient.Ui.UiGameSkinEquip.EFirstTabType <SelectedFirstIndex>k__BackingField; // 0x3dc
	System.Boolean <IsEditPlan>k__BackingField; // 0x3e0
	System.Boolean isShowModel; // 0x3e1
	System.Int64 EquippedSkinId; // 0x3e8
	System.Int32 SelectSkinId; // 0x3f0
	System.Collections.Generic.Dictionary<System.Int64,System.Int64> CachedSkin; // 0x3f8
	FairyGUI.Controller Status; // 0x400
	FairyGUI.Controller equipStateCtr; // 0x408
	System.Collections.Generic.List<Bright.Config.BeanBase> skinVirtualListDatas; // 0x410
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> virtualToSkinCfg; // 0x418
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> virtualToOriginSkin; // 0x420
	WizardGames.Soc.SocClient.Ui.ComDualTabs comdualTab; // 0x428
	FairyGUI.GList thirdTab; // 0x430
	FairyGUI.GComponent comDescription; // 0x438
	WizardGames.Soc.SocClient.Ui.ComComboBox sortCom; // 0x440
	FairyGUI.GButton btnPreview; // 0x448
	FairyGUI.GComponent actionTip; // 0x450
	FairyGUI.GButton switchLightBtn; // 0x458
	FairyGUI.GButton switchSexBtn; // 0x460
	FairyGUI.GButton highLightBtn; // 0x468
	FairyGUI.GButton actionBtn; // 0x470
	FairyGUI.Controller sexCtr; // 0x478
	FairyGUI.Controller lightCtr; // 0x480
	WizardGames.Soc.SocClient.Ui.UiGameSkinEquip.ENewSkinOrderType curSortType; // 0x488
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> editEquipPlan; // 0x490
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> editCostumePlan; // 0x498
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> tempEquipPlan; // 0x4a0
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> tempCostumePlan; // 0x4a8
	System.Collections.Generic.Dictionary<System.Int32,System.Int32> toServerPlan; // 0x4b0
	FairyGUI.GObject collectBtn; // 0x4b8
	FairyGUI.GObject shareBtn; // 0x4c0
	FairyGUI.Controller collectCtr; // 0x4c8
	FairyGUI.Controller shareCtr; // 0x4d0
	WizardGames.Soc.SocClient.Ui.ComTopBar topBar; // 0x4d8
	FairyGUI.GButton showOptionBtn; // 0x4e0
	FairyGUI.GComponent optionRoot; // 0x4e8
	WizardGames.Soc.SocClient.Ui.GSkinOptionTip optionTipIns; // 0x4f0
	FairyGUI.GTextField lockedComTextField; // 0x4f8
	WizardGames.Soc.SocClient.Ui.ComAppWelfareText skinWeaponAppWelfareCom; // 0x500
	System.Boolean isFirstEnable; // 0x508
	System.Void set_OrderType(WizardGames.Soc.SocClient.Ui.UiGameSkinEquip.ESkinOrderType value); // 0x061aaa44
	System.Int32 get_SelectedSecondIndex(); // 0x061aaabc
	System.Void set_SelectedSecondIndex(System.Int32 value); // 0x061aab20
	WizardGames.Soc.SocClient.Ui.UiGameSkinEquip.EFirstTabType get_SelectedFirstIndex(); // 0x061aab98
	System.Void set_SelectedFirstIndex(WizardGames.Soc.SocClient.Ui.UiGameSkinEquip.EFirstTabType value); // 0x061aabfc
	System.Boolean get_IsEditPlan(); // 0x061aac74
	System.Void OnInit(); // 0x061aacd8
	System.Void InitComDualTab(); // 0x061acf90
	System.Void UpdateSecondTab(System.Int32 parentIndex, System.Collections.Generic.List<System.String> secondDatas); // 0x061ad580
	System.Void FirstTabBack(System.Int32 index); // 0x061ad69c
	System.Void SecondTabBack(System.Int32 first, System.Int32 second); // 0x061adc98
	System.Void UpdataTitleCom(); // 0x061aee98
	System.Void RenderThirdTab(System.Int32 index, FairyGUI.GObject obj); // 0x061af460
	System.Void SelectSkinItem(WizardGames.Soc.SocClient.Ui.GameSkinEquipItem clickItem); // 0x061af974
	System.Void UpdateSecondaryTabConfig(); // 0x061ae0e8
	System.Void UpdateOnePartAllSkin(); // 0x061ae6fc
